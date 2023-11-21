Imports System.Threading
Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.Aruco
Imports Emgu.CV.Util


Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Imports Intel.RealSense



Public Class Form1
    Private pipeline As New Pipeline
    Private colorizer As New Colorizer
    Private align As Align = New Align(Stream.Color)
    Private profile As PipelineProfile

    Private tokenSource As CancellationTokenSource = New CancellationTokenSource()

    Private tab_select As New Integer

    Private colorImage As New Mat
    Private depthAlignImage As New Mat
    'Private depthAlignImageScale As Mat

    Private img_filtered As New Mat

    Private CheckRealSenseConnection As New Boolean
    Private CheckRealSensePipeline As New Boolean




    Private Aruco_coordinate As New List(Of Tuple(Of Integer, Integer))

    Dim beta_1_x As Double
    Dim beta_0_x As Double

    Dim beta_1_y As Double
    Dim beta_0_y As Double

    Dim RealSense_ArUco_thread As New Thread(AddressOf Realsense_ArUco)
    Dim RealSense_Measurement_thread As New Thread(AddressOf Realsense_Measurement)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False




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

        Dim rs_width As Integer
        Dim rs_height As Integer
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



            cfg.EnableStream(Stream.Depth, width:=rs_width, height:=rs_height, framerate:=txt_aruco_RS_FrameRate.Text)
            cfg.EnableStream(Stream.Color, width:=rs_width, height:=rs_height, Format.Rgb8, framerate:=txt_aruco_RS_FrameRate.Text)

            Debug.Print("pipeline Start")

            profile = (pipeline.Start(cfg))

            CheckRealSensePipeline = True


        End Using

    End Sub
    Private Function RealSense_Image(ByVal img_aruco_RealSenseImage As UI.ImageBox, ByVal img_aruco_RealSenseDepthImage As UI.ImageBox)


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
                If btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen Then
                    img_aruco_RealSenseImage.Image = colorImage
                    img_aruco_RealSenseDepthImage.Image = depthAlignImage
                ElseIf btn_aruco_image_mode.BackColor = System.Drawing.Color.RoyalBlue Then
                    img_aruco_RealSenseImage.Image = depthAlignImage
                    If txt_aruco_rs_alpha.Text <> Nothing And txt_aruco_rs_alpha.Text <> 0 Then
                        CvInvoke.ConvertScaleAbs(depthAlignImage, depthAlignImage, (txt_aruco_rs_alpha.Text / 500), txt_aruco_rs_beta.Text)
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

    End Function
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
        img_Measurement_RealSense.Image = colorImage
    End Sub
    Private Sub Realsense_ArUco()
        Try
            If Not CheckRealSensePipeline Then
                RealSense_initial()
            End If


            While Not tokenSource.IsCancellationRequested And tab_select = 1
                RealSense_Image(img_aruco_RealSenseImage, img_aruco_RealSenseDepthImage)

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
            If Not CheckRealSensePipeline Then
                RealSense_initial()
            End If


            While Not tokenSource.IsCancellationRequested And tab_select = 1
                RealSense_Image(img_Measurement_RealSense, img_Measurement_RealSense_Measurement)

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

    Private Sub btn_Start_RealSense_Click(sender As Object, e As EventArgs) Handles btn_Start_aruco_RealSense.Click



        If btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Red And tab_select = 1 Then
            RealSense_ArUco_thread = New Thread(AddressOf Realsense_ArUco)
            Debug.Print("Start RealSense")
            tokenSource = New CancellationTokenSource()

            RealSense_ArUco_thread.Start()


            btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Green
            btn_Start_aruco_RealSense.ForeColor = SystemColors.Window
            btn_Start_aruco_RealSense.Text = "Stop RealSense"

        ElseIf btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Green Or tab_select = 2 Then
            RealSense_ArUco_thread.Abort()
            If CheckRealSensePipeline Then
                tokenSource.Cancel()
                pipeline.Stop()
            End If

            Debug.Print("Thread aborted.")


            btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Red
            btn_Start_aruco_RealSense.ForeColor = SystemColors.Window
            btn_Start_aruco_RealSense.Text = "Start RealSense"

        End If

    End Sub

    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_aruco_csv.Click
        find_linear_regression()

        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog = SaveFileDialog1
            saveFileDialog.InitialDirectory = Application.StartupPath
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Create a StreamWriter to write the CSV file
                Using writer As New IO.StreamWriter(saveFileDialog.FileName)
                    ' Write the header row
                    writer.WriteLine("Width,Height")
                    ' Write the data rows

                    For Each item In Aruco_coordinate
                        writer.WriteLine($"{item.Item1},{item.Item2}")

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

    Sub find_linear_regression()
        Dim sum_X_pixel As Double = Aruco_coordinate.Sum(Function(item_x) item_x.Item1)
        Dim sum_Y_pixel As Double = Aruco_coordinate.Sum(Function(item_y) item_y.Item2)

        Dim X_pixel_avg As Double = Aruco_coordinate.Average(Function(item_x) item_x.Item1)
        Dim Y_pixel_avg As Double = Aruco_coordinate.Average(Function(item_y) item_y.Item2)

        Dim X_real As New List(Of Double)({0, 2.5, 5, 5, 5, 2.5, 0, 0})
        Dim Y_real As New List(Of Double)({0, 0, 0, 2.5, 5, 5, 5, 2.5})

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
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        tab_select = 1
        RealSense_Measurement_thread.Abort()
        If CheckRealSensePipeline Then
            tokenSource.Cancel()
            pipeline.Stop()
        End If
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
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
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
        If CheckRealSensePipeline Then
            tokenSource.Cancel()
            pipeline.Stop()
        End If
        Debug.Print("Thread aborted.")

        btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Red
        btn_Start_Measurment_Realsense.ForeColor = SystemColors.Window
        btn_Start_Measurment_Realsense.Text = "Start RealSense"

        btn_Start_Measurment_Realsense_measurement.BackColor = System.Drawing.Color.Red
        btn_Start_Measurment_Realsense_measurement.ForeColor = SystemColors.Window
        btn_Start_Measurment_Realsense_measurement.Text = "Start ArUco"
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
            pipeline.Stop()
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
            Debug.Print("test")
            RealSense_Measurement_thread.Abort()
            If CheckRealSensePipeline Then
                tokenSource.Cancel()
                pipeline.Stop()
            End If

            Debug.Print("Thread aborted.")


            btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Red
            btn_Start_Measurment_Realsense.ForeColor = SystemColors.Window
            btn_Start_Measurment_Realsense.Text = "Start RealSense"

        End If
    End Sub

    Private Sub btn_Start_Measurment_Realsense_measurement_Click(sender As Object, e As EventArgs) Handles btn_Start_Measurment_Realsense_measurement.Click

    End Sub

    Private Sub bnt_Measurement_Exit_Click(sender As Object, e As EventArgs) Handles bnt_Measurement_Exit.Click
        RealSense_Measurement_thread.Abort()
        If CheckRealSensePipeline Then
            tokenSource.Cancel()
            pipeline.Stop()
        End If

        Debug.Print("Thread aborted.")
        Me.Close()
    End Sub
End Class

