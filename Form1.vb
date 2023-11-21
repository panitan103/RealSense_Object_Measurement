Imports System.IO
Imports System.Runtime.Remoting
Imports System.Threading
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports Emgu.CV
Imports Emgu.CV.Aruco
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.Util
Imports Intel.RealSense

Public Class Form1
    Private pipeline As New Pipeline
    Private colorizer As New Colorizer
    Private align As Align = New Align(Intel.RealSense.Stream.Color)
    Private profile As PipelineProfile

    Private tokenSource As CancellationTokenSource = New CancellationTokenSource()

    Private tab_select As Integer = 1

    Private colorImage As New Mat
    Private depthAlignImage As New Mat
    'Private depthAlignImageScale As Mat

    Private img_filtered As New Mat

    Private CheckRealSenseConnection As New Boolean
    Private CheckRealSensePipeline As New Boolean

    Dim rs_width As Integer
    Dim rs_height As Integer
    Dim rs_framerate As Integer

    Private Aruco_coordinate As New List(Of Tuple(Of Integer, Integer))
    Private size_obj As New List(Of Tuple(Of Tuple(Of Double, Double), Tuple(Of Double, Double), Tuple(Of Double, Double), Tuple(Of Double, Double, Double, Double), Tuple(Of Double, Double)))

    Dim beta_1_x As Double
    Dim beta_0_x As Double

    Dim beta_1_y As Double
    Dim beta_0_y As Double

    Dim RealSense_ArUco_thread As New Thread(AddressOf Realsense_ArUco)
    Dim RealSense_Measurement_thread As New Thread(AddressOf Realsense_Measurement)

    Dim maker_x As Double = 2
    Dim maker_y As Double = 2
    Dim X_real As New List(Of Double)({0, maker_x / 2, maker_x, maker_x, maker_x, maker_x / 2, 0, 0})
    Dim Y_real As New List(Of Double)({0, 0, 0, maker_y / 2, maker_y, maker_y, maker_y, maker_y / 2})

    Dim pixel_per_matric_x As Double
    Dim pixel_per_matric_y As Double

    Dim distance_x_pixel As Double
    Dim distance_y_pixel As Double
    Dim distance_x As Double
    Dim distance_Y As Double
    Dim distance_x_ppm As Double
    Dim distance_y_ppm As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

        If tab_select = 1 Then
            If txt_aruco_RS_Resolution.Text = "1280 x 720" Then
                rs_width = 1280
                rs_height = 720
            ElseIf txt_aruco_RS_Resolution.Text = "848 x 480" Then
                rs_width = 848
                rs_height = 480
            ElseIf txt_aruco_RS_Resolution.Text = "640 x 480" Then
                rs_width = 640
                rs_height = 480
            ElseIf txt_aruco_RS_Resolution.Text = "640 x 360" Then
                rs_width = 640
                rs_height = 360
            ElseIf txt_aruco_RS_Resolution.Text = "424 x 240" Then
                rs_width = 424
                rs_height = 240

            End If
            rs_framerate = txt_aruco_RS_FrameRate.Text
        ElseIf tab_select = 2 Then
            If txt_measurement_RS_Resolution.Text = "1280 x 720" Then
                rs_width = 1280
                rs_height = 720
            ElseIf txt_measurement_RS_Resolution.Text = "848 x 480" Then
                rs_width = 848
                rs_height = 480
            ElseIf txt_measurement_RS_Resolution.Text = "640 x 480" Then
                rs_width = 640
                rs_height = 480
            ElseIf txt_measurement_RS_Resolution.Text = "640 x 360" Then
                rs_width = 640
                rs_height = 360
            ElseIf txt_measurement_RS_Resolution.Text = "424 x 240" Then
                rs_width = 424
                rs_height = 240
            End If
            rs_framerate = txt_measurement_RS_FrameRate.Text
        End If

        txt_ROIX.Maximum = rs_width / 2
        txt_ROIY.Maximum = rs_height / 2
        txt_ROIWidth.Maximum = rs_width / 2
        txt_ROIHeight.Maximum = rs_height / 2

        txt_ROIX.Text = rs_width / 4
        txt_ROIY.Text = rs_height / 4
        txt_ROIWidth.Text = rs_width - txt_ROIX.Text
        txt_ROIHeight.Text = rs_height - txt_ROIY.Text



    End Sub

    Public Function VideoFrameToMat(ByVal frame As VideoFrame) As Mat
        Dim source As BitmapSource
        Using colorFrame As VideoFrame = frame
            Dim bytes = New Byte(frame.Stride * frame.Height - 1) {}
            ' Copy stream into the array of byte
            frame.CopyTo(bytes)
            source = BitmapSource.Create(frame.Width, frame.Height, 300, 300, PixelFormats.Rgb24, Nothing, bytes, frame.Stride)
        End Using

        If source.Format = PixelFormats.Bgra32 Then
            Dim result As New Mat()
            result.Create(source.PixelHeight, source.PixelWidth, DepthType.Cv8U, 4)
            source.CopyPixels(Windows.Int32Rect.Empty, result.DataPointer, result.Step * result.Rows, result.Step)
            Return result
        ElseIf source.Format = PixelFormats.Bgr24 Then
            Dim result As New Mat()
            result.Create(source.PixelHeight, source.PixelWidth, DepthType.Cv8U, 3)
            source.CopyPixels(Windows.Int32Rect.Empty, result.DataPointer, result.Step * result.Rows, result.Step)
            Return result
        ElseIf source.Format = PixelFormats.Rgb24 Then
            Dim result As New Mat()
            result.Create(source.PixelHeight, source.PixelWidth, DepthType.Cv8U, 3)
            source.CopyPixels(Windows.Int32Rect.Empty, result.DataPointer, result.Step * result.Rows, result.Step)
            CvInvoke.CvtColor(result, result, ColorConversion.Rgb2Bgr)
            Return result
        Else
            Throw New Exception(String.Format("Convertion from BitmapSource of format {0} is not supported.", source.Format))
        End If

    End Function
    Private Sub RealSense_initial()




        colorizer = New Colorizer()
        'pipeline = New Pipeline()



        Using ctx As New Context()
            Dim cfg As New Config()

            Dim devices = ctx.QueryDevices()


            While devices.Count = 0
                Debug.Print("Cannot find RealSense Device")
                Debug.Print("Wait for RealSense connection")
                devices = ctx.QueryDevices()
            End While

            Dim dev = devices(0)
            Dim sensors = dev.QuerySensors()
            Dim depthSensor = sensors(0)
            Dim colorSensor = sensors(1)

            'Dim depthProfile = depthSensor.StreamProfiles _
            '    .Where(Function(p) p.Stream = Stream.Depth) _
            '    .OrderBy(Function(p) p.Framerate) _
            '    .Select(Function(p) p.As(Of VideoStreamProfile)()) _
            '    .First()

            'Dim colorProfile = colorSensor.StreamProfiles _
            '    .Where(Function(p) p.Stream = Stream.Color) _
            '    .OrderBy(Function(p) p.Framerate) _
            '    .Select(Function(p) p.As(Of VideoStreamProfile)()) _
            '    .First()

            'cfg.EnableStream(Stream.Depth, depthProfile.Width, depthProfile.Height, depthProfile.Format, depthProfile.Framerate)
            'cfg.EnableStream(Stream.Color, colorProfile.Width, colorProfile.Height, colorProfile.Format, colorProfile.Framerate)

            'RGB()
            '1280*720
            '960*540 
            '848*480
            '640*480
            '640*360
            '424*240
            '320*240

            'depth
            '1280 * 800
            '1280 * 720
            '848*480
            '848*100
            '640*480
            '640*400
            '640*360
            '480*270
            '424*240
            '256*144
            'same
            '1280 x 720
            '848 x 480
            '640 x 480
            '640 x 360
            '424 x 240

            If tab_select = 1 Then
                If txt_aruco_RS_Resolution.Text = "1280 x 720" Then
                    rs_width = 1280
                    rs_height = 720
                ElseIf txt_aruco_RS_Resolution.Text = "848 x 480" Then
                    rs_width = 848
                    rs_height = 480
                ElseIf txt_aruco_RS_Resolution.Text = "640 x 480" Then
                    rs_width = 640
                    rs_height = 480
                ElseIf txt_aruco_RS_Resolution.Text = "640 x 360" Then
                    rs_width = 640
                    rs_height = 360
                ElseIf txt_aruco_RS_Resolution.Text = "424 x 240" Then
                    rs_width = 424
                    rs_height = 240

                End If
                rs_framerate = txt_aruco_RS_FrameRate.Text
            ElseIf tab_select = 2 Then
                If txt_measurement_RS_Resolution.Text = "1280 x 720" Then
                    rs_width = 1280
                    rs_height = 720
                ElseIf txt_measurement_RS_Resolution.Text = "848 x 480" Then
                    rs_width = 848
                    rs_height = 480
                ElseIf txt_measurement_RS_Resolution.Text = "640 x 480" Then
                    rs_width = 640
                    rs_height = 480
                ElseIf txt_measurement_RS_Resolution.Text = "640 x 360" Then
                    rs_width = 640
                    rs_height = 360
                ElseIf txt_measurement_RS_Resolution.Text = "424 x 240" Then
                    rs_width = 424
                    rs_height = 240
                End If
                rs_framerate = txt_measurement_RS_FrameRate.Text
            End If

            Debug.Print(rs_width & " , " & rs_height & " , " & rs_framerate)

            cfg.EnableStream(Intel.RealSense.Stream.Depth, width:=rs_width, height:=rs_height, framerate:=rs_framerate)
            cfg.EnableStream(Intel.RealSense.Stream.Color, width:=rs_width, height:=rs_height, Format.Rgb8, framerate:=rs_framerate)


            If profile Is Nothing Then
                profile = (pipeline.Start(cfg))

                Debug.Print("Pipeline is started.")
            Else
                pipeline.Stop()

                profile = (pipeline.Start(cfg))
                Debug.Print("Pipeline is restart.")
            End If

            'CheckRealSensePipeline = True


        End Using

    End Sub
    Private Sub RealSense_Image(ByVal img_aruco_RealSenseImage As UI.ImageBox)


        'Try


        Using frames As FrameSet = pipeline.WaitForFrames()


            colorImage = VideoFrameToMat(frames.ColorFrame)

            Dim colorizedDepth = colorizer.Process(Of VideoFrame)(frames.DepthFrame).DisposeWith(frames)
            Dim depthImage = VideoFrameToMat(colorizedDepth)


            'RealSenseDepthImage.Image = depthImage

            Dim aligned As Frame = align.Process(frames).DisposeWith(frames)
            Using alignedframeset As FrameSet = aligned.AsFrameSet
                Dim colorFrame = alignedframeset.ColorFrame.DisposeWith(alignedframeset)
                Dim DepthFrame = alignedframeset.DepthFrame.DisposeWith(alignedframeset).As(Of VideoFrame)
                DepthFrame = colorizer.Process(Of VideoFrame)(alignedframeset.DepthFrame).DisposeWith(frames)
                'Dim depthAlignImage As Mat
                depthAlignImage = VideoFrameToMat(DepthFrame)
                Dim rs_alpha As Integer
                Dim rs_beta As Integer
                If tab_select = 1 Then
                    rs_alpha = txt_aruco_rs_alpha.Text
                    rs_beta = txt_aruco_rs_beta.Text
                ElseIf tab_select = 2 Then
                    rs_alpha = txt_measurement_rs_alpha.Text
                    rs_beta = txt_measurement_rs_beta.Text
                End If

                If btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen Then

                    img_aruco_RealSenseImage.Image = colorImage

                    If tab_select = 1 Then
                        img_aruco_RealSenseDepthImage.Image = depthAlignImage
                    End If

                ElseIf btn_aruco_image_mode.BackColor = System.Drawing.Color.RoyalBlue Then
                    img_aruco_RealSenseImage.Image = depthAlignImage
                    If txt_aruco_rs_alpha.Text <> Nothing And txt_aruco_rs_alpha.Text <> 0 Then
                        CvInvoke.ConvertScaleAbs(depthAlignImage, depthAlignImage, (rs_alpha / 500), rs_beta)
                        CvInvoke.ApplyColorMap(depthAlignImage, depthAlignImage, ColorMapType.Jet)
                    End If
                    img_aruco_RealSenseDepthImage.Image = depthAlignImage
                End If
                'RealSenseImage.Image = depthAlignImage


            End Using
        End Using


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    '    Application.Exit()
        'End Try

    End Sub
    Private Sub Aruco_process()
        img_filtered = New Mat()
        Dim img_get = New Mat()

        If btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen Then

            colorImage.CopyTo(img_get)


        ElseIf btn_aruco_image_mode.BackColor = System.Drawing.Color.RoyalBlue Then
            depthAlignImage.CopyTo(img_get)


        End If
        img_aruco_ArUcoImage.Image = img_get

        CvInvoke.CvtColor(img_get, img_filtered, ColorConversion.Bgr2Gray)

        If (txt_aruco_ThrshBlockSize.Text Mod 2) = 0 Or txt_aruco_ThrshBlockSize.Text < 3 Or txt_aruco_ThrshBlockSize.Text Is Nothing Then
            Return
        End If

        If txt_aruco_ThrshSelect.Text = "threshold adaptive" Then
            CvInvoke.AdaptiveThreshold(img_filtered, img_filtered, 255, AdaptiveThresholdType.MeanC, ThresholdType.Binary, txt_aruco_ThrshBlockSize.Text, txt_aruco_ThrshSubMean.Text)

        ElseIf txt_aruco_ThrshSelect.Text = "threshold adaptive invert" Then

            CvInvoke.AdaptiveThreshold(img_filtered, img_filtered, 255, AdaptiveThresholdType.MeanC, ThresholdType.BinaryInv, txt_aruco_ThrshBlockSize.Text, txt_aruco_ThrshSubMean.Text)

        End If

        img_aruco_RealSenseDepthImageThresh.Image = img_filtered
        CvInvoke.CvtColor(img_filtered, img_filtered, ColorConversion.Gray2Bgr)

        Dim Dictionary As Dictionary = New Dictionary(Dictionary.PredefinedDictionaryName.Dict4X4_50)
        Dim corners As VectorOfVectorOfPointF = New VectorOfVectorOfPointF()
        Dim ids As VectorOfInt = New VectorOfInt()

        Dim distortionCoefficients As New Mat(1, 5, DepthType.Cv32F, 1)
        ArucoInvoke.DetectMarkers(img_filtered, Dictionary, corners, ids, DetectorParameters.GetDefault())
        'ArucoInvoke.DrawDetectedMarkers(img_filtered, corners, ids, New MCvScalar(20, 255, 20))


        Aruco_coordinate = New List(Of Tuple(Of Integer, Integer))
        For i As Integer = 0 To corners.Size - 1
            Dim vec As VectorOfPointF = corners(i)
            Dim value As Integer = ids(i)

            Dim centerX As Integer = (vec(0).X + vec(1).X + vec(2).X + vec(3).X) / 4
            Dim centerY As Integer = (vec(0).Y + vec(1).Y + vec(2).Y + vec(3).Y) / 4


            Dim corner_0_to_1 As Point = New Point((vec(0).X + vec(1).X) / 2, (vec(0).Y + vec(1).Y) / 2)
            Dim corner_1_to_2 As Point = New Point((vec(1).X + vec(2).X) / 2, (vec(1).Y + vec(2).Y) / 2)
            Dim corner_2_to_3 As Point = New Point((vec(2).X + vec(3).X) / 2, (vec(2).Y + vec(3).Y) / 2)
            Dim corner_3_to_0 As Point = New Point((vec(0).X + vec(3).X) / 2, (vec(0).Y + vec(3).Y) / 2)
            Dim corner_half As New List(Of Point)
            corner_half.Add(corner_0_to_1)
            corner_half.Add(corner_1_to_2)
            corner_half.Add(corner_2_to_3)
            corner_half.Add(corner_3_to_0)

            For j As Integer = 0 To vec.Size - 1

                Dim vec_point As Point = New Point(vec(j).X, vec(j).Y)

                CvInvoke.Circle(img_get, vec_point, 5, New MCvScalar(0, 0, 255), -1)
                CvInvoke.PutText(img_get, j * 2 & "," & vec(j).X & "," & vec(j).Y, vec_point, FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                CvInvoke.Circle(img_filtered, vec_point, 5, New MCvScalar(0, 0, 255), -1)
                CvInvoke.PutText(img_filtered, j * 2 & "," & vec(j).X & "," & vec(j).Y, vec_point, FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                Aruco_coordinate.Add(Tuple.Create(CInt(vec(j).X), CInt(vec(j).Y)))

                CvInvoke.Circle(img_get, corner_half(j), 5, New MCvScalar(0, 0, 255), -1)
                CvInvoke.PutText(img_get, (j * 2) + 1 & "," & corner_half(j).X & "," & corner_half(j).Y, corner_half(j), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                CvInvoke.Circle(img_filtered, corner_half(j), 5, New MCvScalar(0, 0, 255), -1)
                CvInvoke.PutText(img_filtered, (j * 2) + 1 & "," & corner_half(j).X & "," & corner_half(j).Y, corner_half(j), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                Aruco_coordinate.Add(Tuple.Create(CInt(corner_half(j).X), CInt(corner_half(j).Y)))


            Next

            'Dim centerPoint As New Point(centerX, centerY)
            'Aruco_coordinate.Add(Tuple.Create(centerX, centerY))

            'CvInvoke.Circle(img_get, centerPoint, 5, New MCvScalar(0, 0, 255), -1)
            'CvInvoke.PutText(img_get, value & "," & centerX & "," & centerY, centerPoint, FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
            'CvInvoke.Circle(img_filtered, centerPoint, 5, New MCvScalar(0, 0, 255), -1)
            'CvInvoke.PutText(img_filtered, value & "," & centerX & "," & centerY, centerPoint, FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
            img_aruco_ArUcoImage.Image = img_get
            img_aruco_RealSenseDepthImageThresh.Image = img_filtered


        Next


    End Sub
    Private Sub Measurement_process()
        Dim cameraMat As New Mat
        Dim img_filtered As New Mat()
        Dim Edge_out As New Mat()

        If btn_measurement_image_mode.BackColor = System.Drawing.Color.LimeGreen Then

            colorImage.CopyTo(cameraMat)


        ElseIf btn_measurement_image_mode.BackColor = System.Drawing.Color.RoyalBlue Then
            depthAlignImage.CopyTo(cameraMat)

        End If
        'img_Measurement_RealSense_Measurement.Image = cameraMat

        CvInvoke.CvtColor(cameraMat, img_filtered, ColorConversion.Bgr2Gray)

        'cameraMat.CopyTo(img_filtered)
        cameraMat.CopyTo(Edge_out)
        'If btn_Morph.BackColor = System.Drawing.Color.Green Then

        'Try
        If (txt_measurement_ThrshBlockSize.Text Mod 2) = 0 Or txt_measurement_ThrshBlockSize.Text < 3 Or txt_measurement_ThrshBlockSize.Text Is Nothing Then
            Return
        End If
        If txt_measurement_ThrshSelect.Text = "threshold adaptive" Then
            CvInvoke.AdaptiveThreshold(img_filtered, img_filtered, 255, AdaptiveThresholdType.MeanC, ThresholdType.Binary, txt_measurement_ThrshBlockSize.Text, txt_measurement_ThrshSubMean.Text)
        ElseIf txt_measurement_ThrshSelect.Text = "threshold adaptive invert" Then
            CvInvoke.AdaptiveThreshold(img_filtered, img_filtered, 255, AdaptiveThresholdType.MeanC, ThresholdType.BinaryInv, txt_measurement_ThrshBlockSize.Text, txt_measurement_ThrshSubMean.Text)
        End If

        img_Measurement_RealSense_thresh.Image = img_filtered
        'ImageBox2.Image = img_filtered

        If txt_MorphDilateKernel.Text Is Nothing Then
            Return
        End If
        If txt_MorphOpenKernel.Text Is Nothing Then
            Return
        End If
        If txt_MorphDilateIteration.Text Is Nothing Then
            Return
        End If
        If txt_MorphOpenIteration.Text Is Nothing Then
            Return
        End If

        Dim kernel_dilate_size As Size = New Size(txt_MorphDilateKernel.Text, txt_MorphDilateKernel.Text)
        Dim se_dilate As Mat = CvInvoke.GetStructuringElement(ElementShape.Rectangle, kernel_dilate_size, New Point(-1, -1))
        Dim kernel_open_size As Size = New Size(txt_MorphOpenKernel.Text, txt_MorphOpenKernel.Text)
        Dim se_open As Mat = CvInvoke.GetStructuringElement(ElementShape.Rectangle, kernel_open_size, New Point(-1, -1))

        If txt_MorphSelct1.Text = "Dilate" Then
            CvInvoke.MorphologyEx(img_filtered, img_filtered, MorphOp.Dilate, se_dilate, New Point(-1, -1), txt_MorphDilateIteration.Text, Emgu.CV.CvEnum.BorderType.Default, New MCvScalar())
        ElseIf txt_MorphSelct1.Text = "Erode" Then
            CvInvoke.MorphologyEx(img_filtered, img_filtered, MorphOp.Erode, se_dilate, New Point(-1, -1), txt_MorphDilateIteration.Text, Emgu.CV.CvEnum.BorderType.Default, New MCvScalar())
        End If

        If txt_MorphSelct2.Text = "Open" Then
            CvInvoke.MorphologyEx(img_filtered, img_filtered, MorphOp.Open, se_open, New Point(-1, -1), txt_MorphOpenIteration.Text, Emgu.CV.CvEnum.BorderType.Default, New MCvScalar())
        ElseIf txt_MorphSelct2.Text = "Close" Then
            CvInvoke.MorphologyEx(img_filtered, img_filtered, MorphOp.Close, se_open, New Point(-1, -1), txt_MorphOpenIteration.Text, Emgu.CV.CvEnum.BorderType.Default, New MCvScalar())
        End If



        If btn_EdgeDetect.BackColor = System.Drawing.Color.Green Then

            Dim cropRegion As New Rectangle(txt_ROIX.Text, txt_ROIY.Text, txt_ROIWidth.Text, txt_ROIHeight.Text)
            CvInvoke.Rectangle(Edge_out, cropRegion, New MCvScalar(255, 0, 0), 2)
            Dim croppedImage As New Mat(img_filtered, cropRegion)
            Dim croppedImage_color As New Mat(cameraMat, cropRegion)
            Dim ctn As New VectorOfVectorOfPoint
            CvInvoke.FindContours(croppedImage, ctn, Nothing, RetrType.List, ChainApproxMethod.ChainApproxSimple)
            CvInvoke.CvtColor(img_filtered, img_filtered, ColorConversion.Gray2Bgr)
            If ctn.Size = 0 Then
                Debug.Print("No contour found")
                img_Measurement_RealSense_detection.Image = Edge_out

                Return
            End If

            Dim largestContourIndex As Integer = 0
            Dim largestContourArea As Double = 0.0


            For i As Integer = 0 To ctn.Size - 1
                Dim contourArea As Double = CvInvoke.ContourArea(ctn(i))
                If contourArea > largestContourArea Then
                    largestContourIndex = i
                    largestContourArea = contourArea

                End If
            Next


            'size_obj = New List(Of Tuple(Of Double, Double, Double, Double))
            'For i As Integer = 0 To ctn.Size - 1
            Dim rect_crop As RotatedRect = CvInvoke.MinAreaRect(ctn(largestContourIndex))
            Dim rectPoints_crop() As PointF = rect_crop.GetVertices()
            Dim rectCorners() As Point = Array.ConvertAll(rectPoints_crop, Function(p) New Point(CInt(p.X + txt_ROIX.Text), CInt(p.Y + txt_ROIY.Text)))
            Dim rectCorners_TL = rectCorners(0)
            Dim rectCorners_TR = rectCorners(1)
            Dim rectCorners_BL = rectCorners(2)
            Dim rectCorners_BR = rectCorners(3)

            Dim rectCorners_TL_x_lrg = ((rectCorners_TL.X * beta_1_x) + beta_0_x)
            Dim rectCorners_TL_y_lrg = ((rectCorners_TL.Y * beta_1_y) + beta_0_y)
            Dim rectCorners_TR_x_lrg = ((rectCorners_TR.X * beta_1_x) + beta_0_x)
            Dim rectCorners_TR_y_lrg = ((rectCorners_TR.Y * beta_1_y) + beta_0_y)
            Dim rectCorners_BR_x_lrg = ((rectCorners_BR.X * beta_1_x) + beta_0_x)
            Dim rectCorners_BR_y_lrg = ((rectCorners_BR.Y * beta_1_y) + beta_0_y)
            Dim rectCorners_BL_x_lrg = ((rectCorners_BL.X * beta_1_x) + beta_0_x)
            Dim rectCorners_BL_y_lrg = ((rectCorners_BL.Y * beta_1_y) + beta_0_y)

            If rectCorners_TL.X > rectCorners_BR.X Then
                distance_x_pixel = (System.Math.Sqrt((rectCorners_TL.X - rectCorners_TR.X) ^ 2 + (rectCorners_TL.Y - rectCorners_TR.Y) ^ 2))
                distance_y_pixel = (System.Math.Sqrt((rectCorners_TL.X - rectCorners_BL.X) ^ 2 + (rectCorners_TL.Y - rectCorners_BL.Y) ^ 2))
                distance_x = (System.Math.Sqrt((rectCorners_TL_x_lrg - rectCorners_TR_x_lrg) ^ 2 + (rectCorners_TL_y_lrg - rectCorners_TR_y_lrg) ^ 2))
                distance_Y = (System.Math.Sqrt((rectCorners_TL_x_lrg - rectCorners_BL_x_lrg) ^ 2 + (rectCorners_TL_y_lrg - rectCorners_BL_y_lrg) ^ 2))

                'Dim rect As Rectangle = New Rectangle(rect_crop.X + txt_ROIX.Text, rect_crop.Y + txt_ROIY.Text, rect_crop.Width, rect_crop.Height)
            Else
                distance_x_pixel = (System.Math.Sqrt((rectCorners_TR.X - rectCorners_BR.X) ^ 2 + (rectCorners_TR.Y - rectCorners_BR.Y) ^ 2))
                distance_y_pixel = (System.Math.Sqrt((rectCorners_TL.X - rectCorners_TR.X) ^ 2 + (rectCorners_TL.Y - rectCorners_TR.Y) ^ 2))
                distance_x = (System.Math.Sqrt((rectCorners_TR_x_lrg - rectCorners_BR_x_lrg) ^ 2 + (rectCorners_TR_y_lrg - rectCorners_BR_y_lrg) ^ 2))
                distance_Y = (System.Math.Sqrt((rectCorners_TL_x_lrg - rectCorners_TR_x_lrg) ^ 2 + (rectCorners_TL_y_lrg - rectCorners_TR_y_lrg) ^ 2))

            End If
            distance_x_ppm = distance_x_pixel / pixel_per_matric_x
            distance_y_ppm = distance_y_pixel / pixel_per_matric_y

            If btn_measurement_mode.BackColor = System.Drawing.Color.LimeGreen Then
                'CvInvoke.DrawContours(Edge_out, ctn, largestContourIndex, New MCvScalar(0, 0, 255), 2)

                CvInvoke.Polylines(Edge_out, rectCorners, True, New MCvScalar(0, 255, 0), 2)
                CvInvoke.Polylines(img_filtered, rectCorners, True, New MCvScalar(0, 255, 0), 2)

                CvInvoke.PutText(Edge_out, "TL", rectCorners_TL, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))
                CvInvoke.PutText(Edge_out, "TR", rectCorners_TR, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))
                CvInvoke.PutText(Edge_out, "BL", rectCorners_BL, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))
                CvInvoke.PutText(Edge_out, "BR", rectCorners_BR, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))

                CvInvoke.PutText(img_filtered, "TL", rectCorners_TL, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))
                CvInvoke.PutText(img_filtered, "TR", rectCorners_TR, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))
                CvInvoke.PutText(img_filtered, "BL", rectCorners_BL, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))
                CvInvoke.PutText(img_filtered, "BR", rectCorners_BR, FontFace.HersheyDuplex, 1, New MCvScalar(255, 0, 255))
                If rectCorners_TL.X > rectCorners_BR.X Then
                    CvInvoke.PutText(Edge_out, distance_x, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(Edge_out, distance_Y, New Point(CInt((rectCorners_TL.X + rectCorners_BR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_BR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                    CvInvoke.PutText(img_filtered, distance_x, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(img_filtered, distance_Y, New Point(CInt((rectCorners_TL.X + rectCorners_BR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_BR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                Else
                    CvInvoke.PutText(Edge_out, distance_x, New Point(CInt((rectCorners_TR.X + rectCorners_BL.X) / 2), CInt((rectCorners_TR.Y + rectCorners_BL.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(Edge_out, distance_Y, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                    CvInvoke.PutText(img_filtered, distance_x, New Point(CInt((rectCorners_TR.X + rectCorners_BL.X) / 2), CInt((rectCorners_TR.Y + rectCorners_BL.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(img_filtered, distance_Y, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                End If

                CvInvoke.PutText(Edge_out, "Linear regresstion", New Point(10, 20), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0), 2)
                CvInvoke.PutText(img_filtered, "Linear regresstion", New Point(10, 20), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0), 2)

            ElseIf btn_measurement_mode.BackColor = System.Drawing.Color.RoyalBlue Then
                'CvInvoke.DrawContours(Edge_out, ctn, largestContourIndex, New MCvScalar(0, 0, 255), 2)
                CvInvoke.Polylines(Edge_out, rectCorners, True, New MCvScalar(0, 255, 0), 2)
                CvInvoke.Polylines(img_filtered, rectCorners, True, New MCvScalar(0, 255, 0), 2)


                If rectCorners_TL.X > rectCorners_BR.X Then
                    CvInvoke.PutText(Edge_out, distance_x_pixel, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(Edge_out, distance_y_pixel, New Point(CInt((rectCorners_TL.X + rectCorners_BR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_BR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                    CvInvoke.PutText(img_filtered, distance_x_pixel, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(img_filtered, distance_y_pixel, New Point(CInt((rectCorners_TL.X + rectCorners_BR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_BR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                Else
                    CvInvoke.PutText(Edge_out, distance_x_pixel, New Point(CInt((rectCorners_TR.X + rectCorners_BL.X) / 2), CInt((rectCorners_TR.Y + rectCorners_BL.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(Edge_out, distance_y_pixel, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                    CvInvoke.PutText(img_filtered, distance_x_pixel, New Point(CInt((rectCorners_TR.X + rectCorners_BL.X) / 2), CInt((rectCorners_TR.Y + rectCorners_BL.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))
                    CvInvoke.PutText(img_filtered, distance_y_pixel, New Point(CInt((rectCorners_TL.X + rectCorners_TR.X) / 2), CInt((rectCorners_TL.Y + rectCorners_TR.Y) / 2)), FontFace.HersheyDuplex, 0.75, New MCvScalar(255, 0, 0))

                End If

            End If

            img_Measurement_RealSense_morph.Image = img_filtered
            img_Measurement_RealSense_detection.Image = Edge_out

            'End If


            'Next


            Return
        End If


    End Sub
    Private Sub Realsense_ArUco()
        Try

            RealSense_initial()

            While Not tokenSource.IsCancellationRequested And tab_select = 1
                RealSense_Image(img_aruco_RealSenseImage)

                If btn_aruco_Aruco.BackColor = System.Drawing.Color.Green Then
                    Aruco_process()
                End If

            End While
        Catch ex As ThreadAbortException
            'MessageBox.Show(ex.Message)

            RealSense_ArUco_thread.ResetAbort()
        Catch otherEx As Exception
            ' Handle other exceptions
            MessageBox.Show(otherEx.Message)
        End Try

    End Sub

    Private Sub Realsense_Measurement()
        Try

            RealSense_initial()

            While Not tokenSource.IsCancellationRequested And tab_select = 2
                RealSense_Image(img_Measurement_RealSense)

                If btn_EdgeDetect.BackColor = System.Drawing.Color.Green Then
                    Measurement_process()
                End If

            End While
        Catch ex As ThreadAbortException
            'MessageBox.Show(ex.Message)

            RealSense_Measurement_thread.ResetAbort()
            'Catch otherEx As Exception
            ' Handle other exceptions
            'MessageBox.Show(otherEx.Message)
        End Try
    End Sub

    Private Sub btn_Start_RealSense_Click(sender As Object, e As EventArgs) Handles btn_Start_aruco_RealSense.Click



        If btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Red And tab_select = 1 Then
            RealSense_ArUco_thread = New Thread(AddressOf Realsense_ArUco)
            'Debug.Print("Start RealSense")
            tokenSource = New CancellationTokenSource()

            RealSense_ArUco_thread.Start()


            btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Green
            btn_Start_aruco_RealSense.ForeColor = SystemColors.Window
            btn_Start_aruco_RealSense.Text = "Stop RealSense"

        ElseIf btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Green Or tab_select = 2 Then
            RealSense_ArUco_thread.Abort()

            tokenSource.Cancel()
            'pipeline.Stop()


            Debug.Print("Thread aborted.")


            btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Red
            btn_Start_aruco_RealSense.ForeColor = SystemColors.Window
            btn_Start_aruco_RealSense.Text = "Start RealSense"

        End If

    End Sub

    Sub find_linear_regression()
        If Aruco_coordinate.Count = 0 Then

            Return
        End If

        Dim sum_X_pixel As Double = Aruco_coordinate.Sum(Function(item_x) item_x.Item1)
        Dim sum_Y_pixel As Double = Aruco_coordinate.Sum(Function(item_y) item_y.Item2)

        Dim X_pixel_avg As Double = Aruco_coordinate.Average(Function(item_x) item_x.Item1)
        Dim Y_pixel_avg As Double = Aruco_coordinate.Average(Function(item_y) item_y.Item2)


        Dim list_X_pixelxreal As New List(Of Double)
        Dim list_X_pixelxpixel As New List(Of Double)

        Dim list_Y_pixelxreal As New List(Of Double)
        Dim list_Y_pixelxpixel As New List(Of Double)

        For i = 0 To X_real.Count - 1

            list_X_pixelxreal.Add(X_real.Item(i) * Aruco_coordinate.Item(i).Item1)
            list_X_pixelxpixel.Add(Aruco_coordinate.Item(i).Item1 * Aruco_coordinate.Item(i).Item1)
            list_Y_pixelxreal.Add(Y_real.Item(i) * Aruco_coordinate.Item(i).Item2)
            list_Y_pixelxpixel.Add(Aruco_coordinate.Item(i).Item2 * Aruco_coordinate.Item(i).Item2)

        Next
        Dim sum_X_pixelxreal As Double = list_X_pixelxreal.Sum(Function(item_x) item_x)
        Dim sum_Y_pixelxreal As Double = list_Y_pixelxreal.Sum(Function(item_x) item_x)

        Dim sum_X_pixelxpixel As Double = list_X_pixelxpixel.Sum(Function(item_x) item_x)
        Dim sum_Y_pixelxpixel As Double = list_Y_pixelxpixel.Sum(Function(item_x) item_x)

        Dim sum_X_real As Double = X_real.Sum(Function(item_x) item_x)
        Dim sum_Y_real As Double = Y_real.Sum(Function(item_y) item_y)

        Dim X_real_avg As Double = X_real.Average(Function(item_x) item_x)
        Dim Y_real_avg As Double = Y_real.Average(Function(item_y) item_y)

        beta_1_x = (sum_X_pixelxreal - ((sum_X_pixel * sum_X_real) / X_real.Count)) / (sum_X_pixelxpixel - (sum_X_pixel * sum_X_pixel / X_real.Count))
        beta_0_x = X_real_avg - (beta_1_x * X_pixel_avg)

        beta_1_y = (sum_Y_pixelxreal - ((sum_Y_pixel * sum_Y_real) / Y_real.Count)) / (sum_Y_pixelxpixel - (sum_Y_pixel * sum_Y_pixel / Y_real.Count))
        beta_0_y = Y_real_avg - (beta_1_y * Y_pixel_avg)

        Debug.Print("sum_X_pixel" & " = " & sum_X_pixel & vbCrLf &
                    "sum_X_real" & " = " & sum_X_real & vbCrLf &
                    "sum_X_pixelxpixel" & " = " & sum_X_pixelxpixel & vbCrLf &
                    "sum_X_pixelxreal" & " = " & sum_X_pixelxreal & vbCrLf &
                    "X_pixel_avg" & " = " & X_pixel_avg & vbCrLf &
                    "X_real_avg" & " = " & X_real_avg & vbCrLf &
                    "sum_Y_pixel" & " = " & sum_Y_pixel & vbCrLf &
                    "sum_Y_real" & " = " & sum_Y_real & vbCrLf &
                    "sum_Y_pixelxpixel" & " = " & sum_Y_pixelxpixel & vbCrLf &
                    "sum_Y_pixelxreal" & " = " & sum_Y_pixelxreal & vbCrLf &
                    "Y_pixel_avg" & " = " & Y_pixel_avg & vbCrLf &
                    "Y_real_avg" & " = " & Y_real_avg & vbCrLf &
                    "beta_1_x" & " = " & beta_1_x & vbCrLf &
                    "beta_0_x" & " = " & beta_0_x & vbCrLf &
                    "beta_1_y" & " = " & beta_1_y & vbCrLf &
                    "beta_0_y" & " = " & beta_0_y)

    End Sub

    Sub find_pixel_per_matric()
        If Aruco_coordinate.Count = 0 Then
            Return
        End If
        'Dim distance_x_pixel = (System.Math.Sqrt((Aruco_coordinate.Item(2).Item1 - Aruco_coordinate.Item(0).Item1) ^ 2 + (Aruco_coordinate.Item(2).Item2 - Aruco_coordinate.Item(0).Item2) ^ 2))
        'Dim distance_y_pixel = (System.Math.Sqrt((Aruco_coordinate.Item(6).Item1 - Aruco_coordinate.Item(0).Item1) ^ 2 + (Aruco_coordinate.Item(6).Item2 - Aruco_coordinate.Item(0).Item2) ^ 2))
        Dim degree_x = System.Math.Abs(System.Math.Atan((Aruco_coordinate.Item(6).Item1 - Aruco_coordinate.Item(0).Item1) / (Aruco_coordinate.Item(6).Item2 - Aruco_coordinate.Item(0).Item2)))
        Dim degree_y = System.Math.Abs(System.Math.Atan((Aruco_coordinate.Item(2).Item2 - Aruco_coordinate.Item(0).Item2) / (Aruco_coordinate.Item(2).Item1 - Aruco_coordinate.Item(0).Item1)))
        Dim dst_x_pixel = System.Math.Abs(Aruco_coordinate.Item(2).Item1 - Aruco_coordinate.Item(0).Item1)
        Dim dst_y_pixel = System.Math.Abs(Aruco_coordinate.Item(6).Item2 - Aruco_coordinate.Item(0).Item2)
        Dim re_x = (System.Math.Cos(degree_x) * maker_x)
        Dim re_y = (System.Math.Cos(degree_y) * maker_y)
        pixel_per_matric_x = dst_x_pixel / re_x
        pixel_per_matric_y = dst_y_pixel / re_y

        Debug.Print("TL" & " = " & Aruco_coordinate.Item(0).Item1 & "," & Aruco_coordinate.Item(0).Item2 & vbCrLf &
                    "TR" & " = " & Aruco_coordinate.Item(2).Item1 & "," & Aruco_coordinate.Item(2).Item2 & vbCrLf &
                    "BL" & " = " & Aruco_coordinate.Item(6).Item1 & "," & Aruco_coordinate.Item(6).Item2 & vbCrLf &
                    "TL to TR X" & " = " & distance_x_pixel & vbCrLf &
                    "TL to BL Y" & " = " & distance_y_pixel & vbCrLf &
                    "degree x" & " = " & degree_x * 180 / System.Math.PI & vbCrLf &
                    "degree y" & " = " & degree_y * 180 / System.Math.PI & vbCrLf &
                    "re-size x" & " = " & re_x & vbCrLf &
                    "re-size y" & " = " & re_y & vbCrLf &
                    "pixel per metric x" & " = " & pixel_per_matric_x & vbCrLf &
                    "pixel per metric y" & " = " & pixel_per_matric_y)

    End Sub
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles tab_ArUco.Enter
        tab_select = 1
        RealSense_Measurement_thread.Abort()

        tokenSource.Cancel()


        Debug.Print("Thread aborted.")

        btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Red
        btn_Start_aruco_RealSense.ForeColor = SystemColors.Window
        btn_Start_aruco_RealSense.Text = "Start RealSense"

        btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen
        btn_aruco_image_mode.ForeColor = SystemColors.ControlText
        btn_aruco_image_mode.Text = "RGB"

        btn_aruco_Aruco.BackColor = System.Drawing.Color.Red
        btn_aruco_Aruco.ForeColor = SystemColors.Window
        btn_aruco_Aruco.Text = "Start ArUco"
    End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles tab_measurement.Enter
        'Dim RealSense_thread As New Thread(Sub()
        '                                       RealSense_initial()
        '                                       While Not tokenSource.IsCancellationRequested And tab_select = 1
        '                                           RealSense_Image()
        '                                           If btn_aruco_Aruco.BackColor = System.Drawing.Color.Green Then
        '                                               Aruco_process()
        '                                           End If

        '                                       End While
        '                                   End Sub)
        tab_select = 2
        RealSense_ArUco_thread.Abort()

        tokenSource.Cancel()


        Debug.Print("Thread aborted.")

        btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Red
        btn_Start_Measurment_Realsense.ForeColor = SystemColors.Window
        btn_Start_Measurment_Realsense.Text = "Start RealSense"

    End Sub

    Private Sub btn_EXIT_Click(sender As Object, e As EventArgs) Handles btn_aruco_EXIT.Click
        'Dim RealSense_thread As New Thread(Sub()
        '                                       RealSense_initial()
        '                                       While Not tokenSource.IsCancellationRequested And tab_select = 1
        '                                           RealSense_Image()
        '                                           If btn_aruco_Aruco.BackColor = System.Drawing.Color.Green Then
        '                                               Aruco_process()
        '                                           End If

        '                                       End While
        '                                   End Sub)
        RealSense_ArUco_thread.Abort()
        If CheckRealSensePipeline Then
            tokenSource.Cancel()
            'pipeline.Stop()
        End If

        Debug.Print("Thread aborted.")
        Me.Close()
    End Sub

    Private Sub btn_Aruco_image_mode_Click(sender As Object, e As EventArgs) Handles btn_aruco_image_mode.Click
        If btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen Then
            btn_aruco_image_mode.BackColor = System.Drawing.Color.RoyalBlue
            btn_aruco_image_mode.ForeColor = SystemColors.Window
            btn_aruco_image_mode.Text = "Depth"

        ElseIf btn_aruco_image_mode.BackColor = System.Drawing.Color.RoyalBlue Then
            btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen
            btn_aruco_image_mode.ForeColor = SystemColors.ControlText
            btn_aruco_image_mode.Text = "RGB"

        End If
    End Sub

    Private Sub btn_Aruco_Click(sender As Object, e As EventArgs) Handles btn_aruco_Aruco.Click
        If btn_aruco_Aruco.BackColor = System.Drawing.Color.Red Then
            btn_aruco_Aruco.BackColor = System.Drawing.Color.Green
            btn_aruco_Aruco.ForeColor = SystemColors.Window
            btn_aruco_Aruco.Text = "Stop ArUco"

        ElseIf btn_aruco_Aruco.BackColor = System.Drawing.Color.Green Then
            btn_aruco_Aruco.BackColor = System.Drawing.Color.Red
            btn_aruco_Aruco.ForeColor = SystemColors.Window
            btn_aruco_Aruco.Text = "Start ArUco"

        End If
    End Sub

    Private Sub btn_Start_Measurment_Realsense_Click(sender As Object, e As EventArgs) Handles btn_Start_Measurment_Realsense.Click
        If btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Red And tab_select = 2 Then
            RealSense_Measurement_thread = New Thread(AddressOf Realsense_Measurement)
            Debug.Print("Start RealSense")
            tokenSource = New CancellationTokenSource()

            RealSense_Measurement_thread.Start()

            btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Green
            btn_Start_Measurment_Realsense.ForeColor = SystemColors.Window
            btn_Start_Measurment_Realsense.Text = "Stop RealSense"

        ElseIf btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Green Or tab_select = 1 Then

            RealSense_Measurement_thread.Abort()
            If CheckRealSensePipeline Then
                tokenSource.Cancel()
                'pipeline.Stop()
            End If

            Debug.Print("Thread aborted.")


            btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Red
            btn_Start_Measurment_Realsense.ForeColor = SystemColors.Window
            btn_Start_Measurment_Realsense.Text = "Start RealSense"

        End If
    End Sub



    Private Sub bnt_Measurement_Exit_Click(sender As Object, e As EventArgs) Handles btn_Measurement_Exit.Click
        RealSense_Measurement_thread.Abort()
        If CheckRealSensePipeline Then
            tokenSource.Cancel()
            'pipeline.Stop()
        End If

        Debug.Print("Thread aborted.")
        Me.Close()
    End Sub

    Private Sub btn_measurement_image_mode_Click(sender As Object, e As EventArgs) Handles btn_measurement_image_mode.Click
        If btn_measurement_image_mode.BackColor = System.Drawing.Color.LimeGreen Then
            btn_measurement_image_mode.BackColor = System.Drawing.Color.RoyalBlue
            btn_measurement_image_mode.ForeColor = SystemColors.Window
            btn_measurement_image_mode.Text = "Depth"

        ElseIf btn_measurement_image_mode.BackColor = System.Drawing.Color.RoyalBlue Then
            btn_measurement_image_mode.BackColor = System.Drawing.Color.LimeGreen
            btn_measurement_image_mode.ForeColor = SystemColors.Window
            btn_measurement_image_mode.Text = "RGB"

        End If
    End Sub



    Private Sub btn_EdgeDetect_Click(sender As Object, e As EventArgs) Handles btn_EdgeDetect.Click
        If btn_EdgeDetect.BackColor = System.Drawing.Color.Red Then
            btn_EdgeDetect.BackColor = System.Drawing.Color.Green
            btn_EdgeDetect.ForeColor = SystemColors.Window


        ElseIf btn_EdgeDetect.BackColor = System.Drawing.Color.Green Then
            btn_EdgeDetect.BackColor = System.Drawing.Color.Red
            btn_EdgeDetect.ForeColor = SystemColors.Window


        End If
    End Sub

    Private Sub btn_aruco_csv_Click(sender As Object, e As EventArgs) Handles btn_aruco_csv.Click


        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog = SaveFileDialog1
            saveFileDialog.InitialDirectory = Application.StartupPath
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Create a StreamWriter to write the CSV file
                Using writer As New IO.StreamWriter(saveFileDialog.FileName)
                    ' Write the header row
                    writer.WriteLine("Width pixel,Width real,Height pixel,Height real")
                    ' Write the data rows
                    Dim i As Integer = 0
                    For Each item In Aruco_coordinate

                        writer.WriteLine($"{item.Item1},{X_real.Item(i)},{item.Item2},{Y_real.Item(i)}")
                        i = i + 1
                    Next
                    ' Flush the StreamWriter to ensure all data is written to the file
                    writer.Flush()
                    ' Close the StreamWriter to release the lock on the file
                    writer.Close()
                End Using

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save_csv.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog = SaveFileDialog1
            saveFileDialog.InitialDirectory = Application.StartupPath
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Create a StreamWriter to write the CSV file
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    ' Write the header row
                    writer.WriteLine("Width LRG,Width PPM,Height LRG,Height PPM,Width,Height,beta_1_x,beta_0_x,beta_1_y,beta_0_y,distance_x_ppm,distance_y_ppm")
                    ' Write the data rows
                    For Each item In size_obj
                        writer.WriteLine($"{item.Item1.Item1},{item.Item1.Item2},{item.Item2.Item1},{item.Item2.Item2},{item.Item3.Item1},{item.Item3.Item2},{item.Item4.Item1},{item.Item4.Item2},{item.Item4.Item3},{item.Item4.Item4},{item.Item5.Item1},{item.Item5.Item2}")
                    Next
                    ' Flush the StreamWriter to ensure all data is written to the file
                    writer.Flush()
                    ' Close the StreamWriter to release the lock on the file
                    writer.Close()
                End Using

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_get_regression.Click
        find_linear_regression()
        find_pixel_per_matric()
    End Sub

    Private Sub btn_measurement_mode_Click(sender As Object, e As EventArgs) Handles btn_measurement_mode.Click
        If btn_measurement_mode.BackColor = System.Drawing.Color.LimeGreen Then
            btn_measurement_mode.BackColor = System.Drawing.Color.RoyalBlue
            btn_measurement_mode.ForeColor = SystemColors.Window
            btn_measurement_mode.Text = "PPM"

        ElseIf btn_measurement_mode.BackColor = System.Drawing.Color.RoyalBlue Then
            btn_measurement_mode.BackColor = System.Drawing.Color.LimeGreen
            btn_measurement_mode.ForeColor = SystemColors.Window
            btn_measurement_mode.Text = "LRG"

        End If
    End Sub

    Private Sub btn_save_size_Click(sender As Object, e As EventArgs) Handles btn_save_size.Click
        Debug.Print("Width" & " = " & distance_x_pixel & vbCrLf &
                    "Height" & " = " & distance_y_pixel & vbCrLf &
                    "beta_1_x" & " = " & beta_1_x & vbCrLf &
                    "beta_0_x" & " = " & beta_0_x & vbCrLf &
                    "beta_1_y" & " = " & beta_1_y & vbCrLf &
                    "beta_0_y" & " = " & beta_0_y & vbCrLf &
                    "distance_x" & " = " & distance_x & vbCrLf &
                    "distance_Y" & " = " & distance_Y & vbCrLf &
                    "pixel per metric x" & " = " & pixel_per_matric_x & vbCrLf &
                    "pixel per metric y" & " = " & pixel_per_matric_y & vbCrLf &
                    "distance_x_ppm" & " = " & distance_x_ppm & vbCrLf &
                    "distance_y_ppm" & " = " & distance_y_ppm)

        size_obj.Add(Tuple.Create(Tuple.Create(distance_x, distance_x_ppm), Tuple.Create(distance_Y, distance_y_ppm), Tuple.Create(distance_x_pixel, distance_y_pixel), Tuple.Create(beta_1_x, beta_0_x, beta_1_y, beta_0_y), Tuple.Create(pixel_per_matric_x, pixel_per_matric_y)))
    End Sub

    Private Sub btn_clear_size_Click(sender As Object, e As EventArgs) Handles btn_clear_size.Click
        size_obj = New List(Of Tuple(Of Tuple(Of Double, Double), Tuple(Of Double, Double), Tuple(Of Double, Double), Tuple(Of Double, Double, Double, Double), Tuple(Of Double, Double)))

    End Sub
End Class

