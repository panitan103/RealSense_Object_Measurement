<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.tab_measurement = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.img_Measurement_RealSense_detection = New Emgu.CV.UI.ImageBox()
        Me.img_Measurement_RealSense = New Emgu.CV.UI.ImageBox()
        Me.img_Measurement_RealSense_thresh = New Emgu.CV.UI.ImageBox()
        Me.img_Measurement_RealSense_morph = New Emgu.CV.UI.ImageBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_measurement_Detection_method = New System.Windows.Forms.Button()
        Me.btn_clear_size = New System.Windows.Forms.Button()
        Me.btn_measurement_image_mode = New System.Windows.Forms.Button()
        Me.btn_save_size = New System.Windows.Forms.Button()
        Me.btn_measurement_mode = New System.Windows.Forms.Button()
        Me.btn_Start_Measurment_Realsense = New System.Windows.Forms.Button()
        Me.btn_Measurement_Exit = New System.Windows.Forms.Button()
        Me.btn_EdgeDetect = New System.Windows.Forms.Button()
        Me.btn_save_csv = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_MorphSelct2 = New System.Windows.Forms.ComboBox()
        Me.txt_MorphOpenIteration = New System.Windows.Forms.NumericUpDown()
        Me.txt_MorphOpenKernel = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_measurement_rs_beta = New System.Windows.Forms.NumericUpDown()
        Me.txt_measurement_RS_Resolution = New System.Windows.Forms.ComboBox()
        Me.txt_measurement_RS_FrameRate = New System.Windows.Forms.ComboBox()
        Me.txt_measurement_rs_alpha = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ROIHeight = New System.Windows.Forms.NumericUpDown()
        Me.txt_ROIWidth = New System.Windows.Forms.NumericUpDown()
        Me.txt_ROIY = New System.Windows.Forms.NumericUpDown()
        Me.txt_ROIX = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_MorphSelct1 = New System.Windows.Forms.ComboBox()
        Me.txt_MorphDilateKernel = New System.Windows.Forms.NumericUpDown()
        Me.txt_MorphDilateIteration = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_measurement_ThrshSelect = New System.Windows.Forms.ComboBox()
        Me.txt_measurement_ThrshBlockSize = New System.Windows.Forms.NumericUpDown()
        Me.txt_measurement_ThrshSubMean = New System.Windows.Forms.NumericUpDown()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Measurement_Hue_Shift = New System.Windows.Forms.NumericUpDown()
        Me.txt_Measurement_Val_Shift = New System.Windows.Forms.NumericUpDown()
        Me.txt_Measurement_Val_low = New System.Windows.Forms.NumericUpDown()
        Me.txt_Measurement_Sat_low = New System.Windows.Forms.NumericUpDown()
        Me.txt_Measurement_Hue_low = New System.Windows.Forms.NumericUpDown()
        Me.txt_Measurement_Sat_Shift = New System.Windows.Forms.NumericUpDown()
        Me.btn_Measurement_color_INV = New System.Windows.Forms.Button()
        Me.tab_ArUco = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.img_aruco_RealSenseDepthImage = New Emgu.CV.UI.ImageBox()
        Me.img_aruco_ArUcoImage = New Emgu.CV.UI.ImageBox()
        Me.img_aruco_RealSenseDepthImageThresh = New Emgu.CV.UI.ImageBox()
        Me.img_aruco_RealSenseImage = New Emgu.CV.UI.ImageBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_aruco_align = New System.Windows.Forms.Button()
        Me.btn_Aruco_Detection_method = New System.Windows.Forms.Button()
        Me.btn_aruco_image_mode = New System.Windows.Forms.Button()
        Me.btn_Start_aruco_RealSense = New System.Windows.Forms.Button()
        Me.btn_aruco_EXIT = New System.Windows.Forms.Button()
        Me.btn_aruco_csv = New System.Windows.Forms.Button()
        Me.btn_get_regression = New System.Windows.Forms.Button()
        Me.btn_aruco_Aruco = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_aruco_rs_beta = New System.Windows.Forms.NumericUpDown()
        Me.txt_aruco_RS_Resolution = New System.Windows.Forms.ComboBox()
        Me.txt_aruco_RS_FrameRate = New System.Windows.Forms.ComboBox()
        Me.txt_aruco_rs_alpha = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_aruco_ThrshBlockSize = New System.Windows.Forms.NumericUpDown()
        Me.txt_aruco_ThrshSubMean = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_aruco_ThrshSelect = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Aruco_MorphSelct1 = New System.Windows.Forms.ComboBox()
        Me.txt_Aruco_MorphDilateKernel = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_MorphDilateIteration = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_MorphSelct2 = New System.Windows.Forms.ComboBox()
        Me.txt_Aruco_MorphOpenIteration = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_MorphOpenKernel = New System.Windows.Forms.NumericUpDown()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Aruco_Hue_Shift = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_Val_Shift = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_Val_low = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_Sat_low = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_Hue_low = New System.Windows.Forms.NumericUpDown()
        Me.txt_Aruco_Sat_Shift = New System.Windows.Forms.NumericUpDown()
        Me.btn_Aruco_color_INV = New System.Windows.Forms.Button()
        Me.img_Measurement_RealSenseImage = New System.Windows.Forms.TabControl()
        Me.btn_measure_align = New System.Windows.Forms.Button()
        Me.tab_measurement.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.img_Measurement_RealSense_detection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Measurement_RealSense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Measurement_RealSense_thresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Measurement_RealSense_morph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        CType(Me.txt_MorphOpenIteration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MorphOpenKernel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.txt_measurement_rs_beta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_measurement_rs_alpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel16.SuspendLayout()
        CType(Me.txt_ROIHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ROIWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ROIY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ROIX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel14.SuspendLayout()
        CType(Me.txt_MorphDilateKernel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MorphDilateIteration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel13.SuspendLayout()
        CType(Me.txt_measurement_ThrshBlockSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_measurement_ThrshSubMean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        CType(Me.txt_Measurement_Hue_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Measurement_Val_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Measurement_Val_low, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Measurement_Sat_low, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Measurement_Hue_low, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Measurement_Sat_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_ArUco.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.img_aruco_RealSenseDepthImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_aruco_ArUcoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_aruco_RealSenseDepthImageThresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_aruco_RealSenseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.txt_aruco_rs_beta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aruco_rs_alpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.txt_aruco_ThrshBlockSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aruco_ThrshSubMean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_Aruco_MorphDilateKernel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_MorphDilateIteration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_MorphOpenIteration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_MorphOpenKernel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.txt_Aruco_Hue_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_Val_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_Val_low, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_Sat_low, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_Hue_low, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aruco_Sat_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.img_Measurement_RealSenseImage.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_measurement
        '
        Me.tab_measurement.Controls.Add(Me.TableLayoutPanel6)
        Me.tab_measurement.Location = New System.Drawing.Point(4, 22)
        Me.tab_measurement.Name = "tab_measurement"
        Me.tab_measurement.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_measurement.Size = New System.Drawing.Size(1000, 655)
        Me.tab_measurement.TabIndex = 3
        Me.tab_measurement.Text = "RealSense Measurement"
        Me.tab_measurement.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.img_Measurement_RealSense_detection, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.img_Measurement_RealSense, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.img_Measurement_RealSense_thresh, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.img_Measurement_RealSense_morph, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TabControl2, 0, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(994, 649)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'img_Measurement_RealSense_detection
        '
        Me.img_Measurement_RealSense_detection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Measurement_RealSense_detection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_Measurement_RealSense_detection.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum
        Me.img_Measurement_RealSense_detection.Location = New System.Drawing.Point(500, 287)
        Me.img_Measurement_RealSense_detection.Name = "img_Measurement_RealSense_detection"
        Me.img_Measurement_RealSense_detection.Size = New System.Drawing.Size(491, 278)
        Me.img_Measurement_RealSense_detection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_Measurement_RealSense_detection.TabIndex = 3
        Me.img_Measurement_RealSense_detection.TabStop = False
        '
        'img_Measurement_RealSense
        '
        Me.img_Measurement_RealSense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Measurement_RealSense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_Measurement_RealSense.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum
        Me.img_Measurement_RealSense.Location = New System.Drawing.Point(3, 3)
        Me.img_Measurement_RealSense.Name = "img_Measurement_RealSense"
        Me.img_Measurement_RealSense.Size = New System.Drawing.Size(491, 278)
        Me.img_Measurement_RealSense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_Measurement_RealSense.TabIndex = 2
        Me.img_Measurement_RealSense.TabStop = False
        '
        'img_Measurement_RealSense_thresh
        '
        Me.img_Measurement_RealSense_thresh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Measurement_RealSense_thresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_Measurement_RealSense_thresh.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum
        Me.img_Measurement_RealSense_thresh.Location = New System.Drawing.Point(500, 3)
        Me.img_Measurement_RealSense_thresh.Name = "img_Measurement_RealSense_thresh"
        Me.img_Measurement_RealSense_thresh.Size = New System.Drawing.Size(491, 278)
        Me.img_Measurement_RealSense_thresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_Measurement_RealSense_thresh.TabIndex = 2
        Me.img_Measurement_RealSense_thresh.TabStop = False
        '
        'img_Measurement_RealSense_morph
        '
        Me.img_Measurement_RealSense_morph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Measurement_RealSense_morph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_Measurement_RealSense_morph.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum
        Me.img_Measurement_RealSense_morph.Location = New System.Drawing.Point(3, 287)
        Me.img_Measurement_RealSense_morph.Name = "img_Measurement_RealSense_morph"
        Me.img_Measurement_RealSense_morph.Size = New System.Drawing.Size(491, 278)
        Me.img_Measurement_RealSense_morph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_Measurement_RealSense_morph.TabIndex = 2
        Me.img_Measurement_RealSense_morph.TabStop = False
        '
        'TabControl2
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.TabControl2, 2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 571)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(988, 75)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(980, 49)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Measurement"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 10
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btn_measure_align, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_measurement_Detection_method, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_clear_size, 6, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_measurement_image_mode, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_save_size, 5, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_measurement_mode, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_Start_Measurment_Realsense, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_Measurement_Exit, 8, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_EdgeDetect, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_save_csv, 7, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(974, 43)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'btn_measurement_Detection_method
        '
        Me.btn_measurement_Detection_method.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_measurement_Detection_method.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_measurement_Detection_method.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_measurement_Detection_method.Location = New System.Drawing.Point(488, 3)
        Me.btn_measurement_Detection_method.Name = "btn_measurement_Detection_method"
        Me.btn_measurement_Detection_method.Size = New System.Drawing.Size(91, 37)
        Me.btn_measurement_Detection_method.TabIndex = 12
        Me.btn_measurement_Detection_method.Text = "Thresh"
        Me.btn_measurement_Detection_method.UseVisualStyleBackColor = False
        '
        'btn_clear_size
        '
        Me.btn_clear_size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_clear_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear_size.Location = New System.Drawing.Point(682, 3)
        Me.btn_clear_size.Name = "btn_clear_size"
        Me.btn_clear_size.Size = New System.Drawing.Size(91, 37)
        Me.btn_clear_size.TabIndex = 11
        Me.btn_clear_size.Text = "Clear obj size"
        Me.btn_clear_size.UseVisualStyleBackColor = True
        '
        'btn_measurement_image_mode
        '
        Me.btn_measurement_image_mode.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_measurement_image_mode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_measurement_image_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_measurement_image_mode.Location = New System.Drawing.Point(197, 3)
        Me.btn_measurement_image_mode.Name = "btn_measurement_image_mode"
        Me.btn_measurement_image_mode.Size = New System.Drawing.Size(91, 37)
        Me.btn_measurement_image_mode.TabIndex = 3
        Me.btn_measurement_image_mode.Text = "RGB"
        Me.btn_measurement_image_mode.UseVisualStyleBackColor = False
        '
        'btn_save_size
        '
        Me.btn_save_size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_save_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_size.Location = New System.Drawing.Point(585, 3)
        Me.btn_save_size.Name = "btn_save_size"
        Me.btn_save_size.Size = New System.Drawing.Size(91, 37)
        Me.btn_save_size.TabIndex = 10
        Me.btn_save_size.Text = "Save obj size"
        Me.btn_save_size.UseVisualStyleBackColor = True
        '
        'btn_measurement_mode
        '
        Me.btn_measurement_mode.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_measurement_mode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_measurement_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_measurement_mode.Location = New System.Drawing.Point(294, 3)
        Me.btn_measurement_mode.Name = "btn_measurement_mode"
        Me.btn_measurement_mode.Size = New System.Drawing.Size(91, 37)
        Me.btn_measurement_mode.TabIndex = 7
        Me.btn_measurement_mode.Text = "LRG"
        Me.btn_measurement_mode.UseVisualStyleBackColor = False
        '
        'btn_Start_Measurment_Realsense
        '
        Me.btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Red
        Me.btn_Start_Measurment_Realsense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Start_Measurment_Realsense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start_Measurment_Realsense.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Start_Measurment_Realsense.Location = New System.Drawing.Point(3, 3)
        Me.btn_Start_Measurment_Realsense.Name = "btn_Start_Measurment_Realsense"
        Me.btn_Start_Measurment_Realsense.Size = New System.Drawing.Size(91, 37)
        Me.btn_Start_Measurment_Realsense.TabIndex = 0
        Me.btn_Start_Measurment_Realsense.Text = "Start RealSense"
        Me.btn_Start_Measurment_Realsense.UseVisualStyleBackColor = False
        '
        'btn_Measurement_Exit
        '
        Me.btn_Measurement_Exit.BackColor = System.Drawing.Color.Red
        Me.btn_Measurement_Exit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Measurement_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Measurement_Exit.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Measurement_Exit.Location = New System.Drawing.Point(876, 3)
        Me.btn_Measurement_Exit.Name = "btn_Measurement_Exit"
        Me.btn_Measurement_Exit.Size = New System.Drawing.Size(95, 37)
        Me.btn_Measurement_Exit.TabIndex = 2
        Me.btn_Measurement_Exit.Text = "Exit"
        Me.btn_Measurement_Exit.UseVisualStyleBackColor = False
        '
        'btn_EdgeDetect
        '
        Me.btn_EdgeDetect.BackColor = System.Drawing.Color.Red
        Me.btn_EdgeDetect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_EdgeDetect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EdgeDetect.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_EdgeDetect.Location = New System.Drawing.Point(100, 3)
        Me.btn_EdgeDetect.Name = "btn_EdgeDetect"
        Me.btn_EdgeDetect.Size = New System.Drawing.Size(91, 37)
        Me.btn_EdgeDetect.TabIndex = 6
        Me.btn_EdgeDetect.Text = "edge"
        Me.btn_EdgeDetect.UseVisualStyleBackColor = False
        '
        'btn_save_csv
        '
        Me.btn_save_csv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_save_csv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_csv.Location = New System.Drawing.Point(779, 3)
        Me.btn_save_csv.Name = "btn_save_csv"
        Me.btn_save_csv.Size = New System.Drawing.Size(91, 37)
        Me.btn_save_csv.TabIndex = 9
        Me.btn_save_csv.Text = "Save to CSV"
        Me.btn_save_csv.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TableLayoutPanel9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(980, 49)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Config"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 5
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel15, 3, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel16, 4, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel14, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel13, 1, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(974, 43)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.txt_MorphSelct2, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.txt_MorphOpenIteration, 1, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.txt_MorphOpenKernel, 1, 0)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(585, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(188, 37)
        Me.TableLayoutPanel15.TabIndex = 7
        '
        'txt_MorphSelct2
        '
        Me.txt_MorphSelct2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphSelct2.FormattingEnabled = True
        Me.txt_MorphSelct2.Items.AddRange(New Object() {"Open", "Close"})
        Me.txt_MorphSelct2.Location = New System.Drawing.Point(3, 3)
        Me.txt_MorphSelct2.Name = "txt_MorphSelct2"
        Me.txt_MorphSelct2.Size = New System.Drawing.Size(88, 21)
        Me.txt_MorphSelct2.TabIndex = 7
        Me.txt_MorphSelct2.Text = "Open"
        '
        'txt_MorphOpenIteration
        '
        Me.txt_MorphOpenIteration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphOpenIteration.Location = New System.Drawing.Point(97, 21)
        Me.txt_MorphOpenIteration.Name = "txt_MorphOpenIteration"
        Me.txt_MorphOpenIteration.Size = New System.Drawing.Size(88, 20)
        Me.txt_MorphOpenIteration.TabIndex = 11
        '
        'txt_MorphOpenKernel
        '
        Me.txt_MorphOpenKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphOpenKernel.Location = New System.Drawing.Point(97, 3)
        Me.txt_MorphOpenKernel.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.txt_MorphOpenKernel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MorphOpenKernel.Name = "txt_MorphOpenKernel"
        Me.txt_MorphOpenKernel.Size = New System.Drawing.Size(88, 20)
        Me.txt_MorphOpenKernel.TabIndex = 9
        Me.txt_MorphOpenKernel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_measurement_rs_beta, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_measurement_RS_Resolution, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_measurement_RS_FrameRate, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_measurement_rs_alpha, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(188, 37)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'txt_measurement_rs_beta
        '
        Me.txt_measurement_rs_beta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_rs_beta.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_measurement_rs_beta.Location = New System.Drawing.Point(97, 21)
        Me.txt_measurement_rs_beta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_measurement_rs_beta.Name = "txt_measurement_rs_beta"
        Me.txt_measurement_rs_beta.Size = New System.Drawing.Size(88, 20)
        Me.txt_measurement_rs_beta.TabIndex = 3
        '
        'txt_measurement_RS_Resolution
        '
        Me.txt_measurement_RS_Resolution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_RS_Resolution.Items.AddRange(New Object() {"1280 x 720", "848 x 480", "640 x 480", "640 x 360", "424 x 240"})
        Me.txt_measurement_RS_Resolution.Location = New System.Drawing.Point(3, 3)
        Me.txt_measurement_RS_Resolution.Name = "txt_measurement_RS_Resolution"
        Me.txt_measurement_RS_Resolution.Size = New System.Drawing.Size(88, 21)
        Me.txt_measurement_RS_Resolution.TabIndex = 0
        Me.txt_measurement_RS_Resolution.Text = "640 x 480"
        '
        'txt_measurement_RS_FrameRate
        '
        Me.txt_measurement_RS_FrameRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_RS_FrameRate.Items.AddRange(New Object() {"60", "30", "15", "6"})
        Me.txt_measurement_RS_FrameRate.Location = New System.Drawing.Point(97, 3)
        Me.txt_measurement_RS_FrameRate.Name = "txt_measurement_RS_FrameRate"
        Me.txt_measurement_RS_FrameRate.Size = New System.Drawing.Size(88, 21)
        Me.txt_measurement_RS_FrameRate.TabIndex = 1
        Me.txt_measurement_RS_FrameRate.Text = "30"
        '
        'txt_measurement_rs_alpha
        '
        Me.txt_measurement_rs_alpha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_rs_alpha.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_measurement_rs_alpha.Location = New System.Drawing.Point(3, 21)
        Me.txt_measurement_rs_alpha.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_measurement_rs_alpha.Name = "txt_measurement_rs_alpha"
        Me.txt_measurement_rs_alpha.Size = New System.Drawing.Size(88, 20)
        Me.txt_measurement_rs_alpha.TabIndex = 2
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 2
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.txt_ROIHeight, 1, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_ROIWidth, 1, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_ROIY, 0, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_ROIX, 0, 0)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(779, 3)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(192, 37)
        Me.TableLayoutPanel16.TabIndex = 8
        '
        'txt_ROIHeight
        '
        Me.txt_ROIHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIHeight.Location = New System.Drawing.Point(99, 21)
        Me.txt_ROIHeight.Name = "txt_ROIHeight"
        Me.txt_ROIHeight.Size = New System.Drawing.Size(90, 20)
        Me.txt_ROIHeight.TabIndex = 10
        '
        'txt_ROIWidth
        '
        Me.txt_ROIWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIWidth.Location = New System.Drawing.Point(99, 3)
        Me.txt_ROIWidth.Name = "txt_ROIWidth"
        Me.txt_ROIWidth.Size = New System.Drawing.Size(90, 20)
        Me.txt_ROIWidth.TabIndex = 8
        '
        'txt_ROIY
        '
        Me.txt_ROIY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIY.Location = New System.Drawing.Point(3, 21)
        Me.txt_ROIY.Name = "txt_ROIY"
        Me.txt_ROIY.Size = New System.Drawing.Size(90, 20)
        Me.txt_ROIY.TabIndex = 9
        '
        'txt_ROIX
        '
        Me.txt_ROIX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIX.Location = New System.Drawing.Point(3, 3)
        Me.txt_ROIX.Name = "txt_ROIX"
        Me.txt_ROIX.Size = New System.Drawing.Size(90, 20)
        Me.txt_ROIX.TabIndex = 7
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.txt_MorphSelct1, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_MorphDilateKernel, 1, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_MorphDilateIteration, 1, 1)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(391, 3)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(188, 37)
        Me.TableLayoutPanel14.TabIndex = 6
        '
        'txt_MorphSelct1
        '
        Me.txt_MorphSelct1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphSelct1.FormattingEnabled = True
        Me.txt_MorphSelct1.Items.AddRange(New Object() {"Dilate", "Erode"})
        Me.txt_MorphSelct1.Location = New System.Drawing.Point(3, 3)
        Me.txt_MorphSelct1.Name = "txt_MorphSelct1"
        Me.txt_MorphSelct1.Size = New System.Drawing.Size(88, 21)
        Me.txt_MorphSelct1.TabIndex = 6
        Me.txt_MorphSelct1.Text = "Dilate"
        '
        'txt_MorphDilateKernel
        '
        Me.txt_MorphDilateKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphDilateKernel.Location = New System.Drawing.Point(97, 3)
        Me.txt_MorphDilateKernel.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.txt_MorphDilateKernel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MorphDilateKernel.Name = "txt_MorphDilateKernel"
        Me.txt_MorphDilateKernel.Size = New System.Drawing.Size(88, 20)
        Me.txt_MorphDilateKernel.TabIndex = 8
        Me.txt_MorphDilateKernel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_MorphDilateIteration
        '
        Me.txt_MorphDilateIteration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphDilateIteration.Location = New System.Drawing.Point(97, 21)
        Me.txt_MorphDilateIteration.Name = "txt_MorphDilateIteration"
        Me.txt_MorphDilateIteration.Size = New System.Drawing.Size(88, 20)
        Me.txt_MorphDilateIteration.TabIndex = 10
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.txt_measurement_ThrshSelect, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.txt_measurement_ThrshBlockSize, 1, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.txt_measurement_ThrshSubMean, 1, 1)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(197, 3)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 2
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(188, 37)
        Me.TableLayoutPanel13.TabIndex = 5
        '
        'txt_measurement_ThrshSelect
        '
        Me.txt_measurement_ThrshSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_ThrshSelect.FormattingEnabled = True
        Me.txt_measurement_ThrshSelect.Items.AddRange(New Object() {"threshold adaptive", "threshold adaptive invert", "threshold", "threshold invert"})
        Me.txt_measurement_ThrshSelect.Location = New System.Drawing.Point(3, 3)
        Me.txt_measurement_ThrshSelect.Name = "txt_measurement_ThrshSelect"
        Me.txt_measurement_ThrshSelect.Size = New System.Drawing.Size(88, 21)
        Me.txt_measurement_ThrshSelect.TabIndex = 0
        Me.txt_measurement_ThrshSelect.Text = "threshold adaptive"
        '
        'txt_measurement_ThrshBlockSize
        '
        Me.txt_measurement_ThrshBlockSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_ThrshBlockSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txt_measurement_ThrshBlockSize.Location = New System.Drawing.Point(97, 3)
        Me.txt_measurement_ThrshBlockSize.Maximum = New Decimal(New Integer() {1001, 0, 0, 0})
        Me.txt_measurement_ThrshBlockSize.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txt_measurement_ThrshBlockSize.Name = "txt_measurement_ThrshBlockSize"
        Me.txt_measurement_ThrshBlockSize.Size = New System.Drawing.Size(88, 20)
        Me.txt_measurement_ThrshBlockSize.TabIndex = 1
        Me.txt_measurement_ThrshBlockSize.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'txt_measurement_ThrshSubMean
        '
        Me.txt_measurement_ThrshSubMean.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_ThrshSubMean.Location = New System.Drawing.Point(97, 21)
        Me.txt_measurement_ThrshSubMean.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_measurement_ThrshSubMean.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.txt_measurement_ThrshSubMean.Name = "txt_measurement_ThrshSubMean"
        Me.txt_measurement_ThrshSubMean.Size = New System.Drawing.Size(88, 20)
        Me.txt_measurement_ThrshSubMean.TabIndex = 2
        Me.txt_measurement_ThrshSubMean.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel12)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(980, 49)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Color"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 8
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel12.Controls.Add(Me.txt_Measurement_Hue_Shift, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_Measurement_Val_Shift, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_Measurement_Val_low, 2, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_Measurement_Sat_low, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_Measurement_Hue_low, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_Measurement_Sat_Shift, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.btn_Measurement_color_INV, 3, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(974, 43)
        Me.TableLayoutPanel12.TabIndex = 1
        '
        'txt_Measurement_Hue_Shift
        '
        Me.txt_Measurement_Hue_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Measurement_Hue_Shift.Location = New System.Drawing.Point(3, 24)
        Me.txt_Measurement_Hue_Shift.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.txt_Measurement_Hue_Shift.Name = "txt_Measurement_Hue_Shift"
        Me.txt_Measurement_Hue_Shift.Size = New System.Drawing.Size(115, 20)
        Me.txt_Measurement_Hue_Shift.TabIndex = 9
        Me.txt_Measurement_Hue_Shift.Value = New Decimal(New Integer() {122, 0, 0, 0})
        '
        'txt_Measurement_Val_Shift
        '
        Me.txt_Measurement_Val_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Measurement_Val_Shift.Location = New System.Drawing.Point(245, 24)
        Me.txt_Measurement_Val_Shift.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Measurement_Val_Shift.Name = "txt_Measurement_Val_Shift"
        Me.txt_Measurement_Val_Shift.Size = New System.Drawing.Size(115, 20)
        Me.txt_Measurement_Val_Shift.TabIndex = 8
        Me.txt_Measurement_Val_Shift.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'txt_Measurement_Val_low
        '
        Me.txt_Measurement_Val_low.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Measurement_Val_low.Location = New System.Drawing.Point(245, 3)
        Me.txt_Measurement_Val_low.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Measurement_Val_low.Name = "txt_Measurement_Val_low"
        Me.txt_Measurement_Val_low.Size = New System.Drawing.Size(115, 20)
        Me.txt_Measurement_Val_low.TabIndex = 2
        Me.txt_Measurement_Val_low.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'txt_Measurement_Sat_low
        '
        Me.txt_Measurement_Sat_low.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Measurement_Sat_low.Location = New System.Drawing.Point(124, 3)
        Me.txt_Measurement_Sat_low.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Measurement_Sat_low.Name = "txt_Measurement_Sat_low"
        Me.txt_Measurement_Sat_low.Size = New System.Drawing.Size(115, 20)
        Me.txt_Measurement_Sat_low.TabIndex = 1
        Me.txt_Measurement_Sat_low.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'txt_Measurement_Hue_low
        '
        Me.txt_Measurement_Hue_low.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Measurement_Hue_low.Location = New System.Drawing.Point(3, 3)
        Me.txt_Measurement_Hue_low.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Measurement_Hue_low.Name = "txt_Measurement_Hue_low"
        Me.txt_Measurement_Hue_low.Size = New System.Drawing.Size(115, 20)
        Me.txt_Measurement_Hue_low.TabIndex = 0
        Me.txt_Measurement_Hue_low.Value = New Decimal(New Integer() {94, 0, 0, 0})
        '
        'txt_Measurement_Sat_Shift
        '
        Me.txt_Measurement_Sat_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Measurement_Sat_Shift.Location = New System.Drawing.Point(124, 24)
        Me.txt_Measurement_Sat_Shift.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Measurement_Sat_Shift.Name = "txt_Measurement_Sat_Shift"
        Me.txt_Measurement_Sat_Shift.Size = New System.Drawing.Size(115, 20)
        Me.txt_Measurement_Sat_Shift.TabIndex = 3
        Me.txt_Measurement_Sat_Shift.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'btn_Measurement_color_INV
        '
        Me.btn_Measurement_color_INV.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_Measurement_color_INV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Measurement_color_INV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Measurement_color_INV.Location = New System.Drawing.Point(366, 3)
        Me.btn_Measurement_color_INV.Name = "btn_Measurement_color_INV"
        Me.TableLayoutPanel12.SetRowSpan(Me.btn_Measurement_color_INV, 2)
        Me.btn_Measurement_color_INV.Size = New System.Drawing.Size(115, 37)
        Me.btn_Measurement_color_INV.TabIndex = 10
        Me.btn_Measurement_color_INV.Text = "Normal"
        Me.btn_Measurement_color_INV.UseVisualStyleBackColor = False
        '
        'tab_ArUco
        '
        Me.tab_ArUco.Controls.Add(Me.TableLayoutPanel10)
        Me.tab_ArUco.Location = New System.Drawing.Point(4, 22)
        Me.tab_ArUco.Name = "tab_ArUco"
        Me.tab_ArUco.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ArUco.Size = New System.Drawing.Size(1000, 655)
        Me.tab_ArUco.TabIndex = 2
        Me.tab_ArUco.Text = "RealSense ArUco"
        Me.tab_ArUco.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_RealSenseDepthImage, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_ArUcoImage, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_RealSenseDepthImageThresh, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_RealSenseImage, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.TabControl1, 0, 2)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 3
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(994, 649)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'img_aruco_RealSenseDepthImage
        '
        Me.img_aruco_RealSenseDepthImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_aruco_RealSenseDepthImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_aruco_RealSenseDepthImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum
        Me.img_aruco_RealSenseDepthImage.Location = New System.Drawing.Point(500, 3)
        Me.img_aruco_RealSenseDepthImage.Name = "img_aruco_RealSenseDepthImage"
        Me.img_aruco_RealSenseDepthImage.Size = New System.Drawing.Size(491, 278)
        Me.img_aruco_RealSenseDepthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_aruco_RealSenseDepthImage.TabIndex = 4
        Me.img_aruco_RealSenseDepthImage.TabStop = False
        '
        'img_aruco_ArUcoImage
        '
        Me.img_aruco_ArUcoImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_aruco_ArUcoImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_aruco_ArUcoImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum
        Me.img_aruco_ArUcoImage.Location = New System.Drawing.Point(3, 287)
        Me.img_aruco_ArUcoImage.Name = "img_aruco_ArUcoImage"
        Me.img_aruco_ArUcoImage.Size = New System.Drawing.Size(491, 278)
        Me.img_aruco_ArUcoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_aruco_ArUcoImage.TabIndex = 5
        Me.img_aruco_ArUcoImage.TabStop = False
        '
        'img_aruco_RealSenseDepthImageThresh
        '
        Me.img_aruco_RealSenseDepthImageThresh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_aruco_RealSenseDepthImageThresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_aruco_RealSenseDepthImageThresh.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum
        Me.img_aruco_RealSenseDepthImageThresh.Location = New System.Drawing.Point(500, 287)
        Me.img_aruco_RealSenseDepthImageThresh.Name = "img_aruco_RealSenseDepthImageThresh"
        Me.img_aruco_RealSenseDepthImageThresh.Size = New System.Drawing.Size(491, 278)
        Me.img_aruco_RealSenseDepthImageThresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_aruco_RealSenseDepthImageThresh.TabIndex = 6
        Me.img_aruco_RealSenseDepthImageThresh.TabStop = False
        '
        'img_aruco_RealSenseImage
        '
        Me.img_aruco_RealSenseImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_aruco_RealSenseImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_aruco_RealSenseImage.Location = New System.Drawing.Point(3, 3)
        Me.img_aruco_RealSenseImage.Name = "img_aruco_RealSenseImage"
        Me.img_aruco_RealSenseImage.Size = New System.Drawing.Size(491, 278)
        Me.img_aruco_RealSenseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_aruco_RealSenseImage.TabIndex = 2
        Me.img_aruco_RealSenseImage.TabStop = False
        '
        'TabControl1
        '
        Me.TableLayoutPanel10.SetColumnSpan(Me.TabControl1, 2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 571)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(988, 75)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(980, 49)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ArUco"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 8
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_aruco_align, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Aruco_Detection_method, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_aruco_image_mode, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Start_aruco_RealSense, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_aruco_EXIT, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_aruco_csv, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_get_regression, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_aruco_Aruco, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(974, 43)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'btn_aruco_align
        '
        Me.btn_aruco_align.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_aruco_align.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_align.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_align.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_aruco_align.Location = New System.Drawing.Point(366, 3)
        Me.btn_aruco_align.Name = "btn_aruco_align"
        Me.btn_aruco_align.Size = New System.Drawing.Size(115, 37)
        Me.btn_aruco_align.TabIndex = 12
        Me.btn_aruco_align.Text = "Aligned"
        Me.btn_aruco_align.UseVisualStyleBackColor = False
        '
        'btn_Aruco_Detection_method
        '
        Me.btn_Aruco_Detection_method.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_Aruco_Detection_method.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Aruco_Detection_method.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aruco_Detection_method.Location = New System.Drawing.Point(487, 3)
        Me.btn_Aruco_Detection_method.Name = "btn_Aruco_Detection_method"
        Me.btn_Aruco_Detection_method.Size = New System.Drawing.Size(115, 37)
        Me.btn_Aruco_Detection_method.TabIndex = 11
        Me.btn_Aruco_Detection_method.Text = "Thresh"
        Me.btn_Aruco_Detection_method.UseVisualStyleBackColor = False
        '
        'btn_aruco_image_mode
        '
        Me.btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_aruco_image_mode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_image_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_image_mode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_aruco_image_mode.Location = New System.Drawing.Point(245, 3)
        Me.btn_aruco_image_mode.Name = "btn_aruco_image_mode"
        Me.btn_aruco_image_mode.Size = New System.Drawing.Size(115, 37)
        Me.btn_aruco_image_mode.TabIndex = 6
        Me.btn_aruco_image_mode.Text = "RGB"
        Me.btn_aruco_image_mode.UseVisualStyleBackColor = False
        '
        'btn_Start_aruco_RealSense
        '
        Me.btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Red
        Me.btn_Start_aruco_RealSense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Start_aruco_RealSense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start_aruco_RealSense.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Start_aruco_RealSense.Location = New System.Drawing.Point(3, 3)
        Me.btn_Start_aruco_RealSense.Name = "btn_Start_aruco_RealSense"
        Me.btn_Start_aruco_RealSense.Size = New System.Drawing.Size(115, 37)
        Me.btn_Start_aruco_RealSense.TabIndex = 0
        Me.btn_Start_aruco_RealSense.Text = "Start RealSense"
        Me.btn_Start_aruco_RealSense.UseVisualStyleBackColor = False
        '
        'btn_aruco_EXIT
        '
        Me.btn_aruco_EXIT.BackColor = System.Drawing.Color.Red
        Me.btn_aruco_EXIT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_EXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_EXIT.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_aruco_EXIT.Location = New System.Drawing.Point(850, 3)
        Me.btn_aruco_EXIT.Name = "btn_aruco_EXIT"
        Me.btn_aruco_EXIT.Size = New System.Drawing.Size(121, 37)
        Me.btn_aruco_EXIT.TabIndex = 4
        Me.btn_aruco_EXIT.Text = "EXIT"
        Me.btn_aruco_EXIT.UseVisualStyleBackColor = False
        '
        'btn_aruco_csv
        '
        Me.btn_aruco_csv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_csv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_csv.Location = New System.Drawing.Point(729, 3)
        Me.btn_aruco_csv.Name = "btn_aruco_csv"
        Me.btn_aruco_csv.Size = New System.Drawing.Size(115, 37)
        Me.btn_aruco_csv.TabIndex = 8
        Me.btn_aruco_csv.Text = "Save to CSV"
        Me.btn_aruco_csv.UseVisualStyleBackColor = True
        '
        'btn_get_regression
        '
        Me.btn_get_regression.BackColor = System.Drawing.Color.Transparent
        Me.btn_get_regression.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_get_regression.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_get_regression.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_get_regression.Location = New System.Drawing.Point(608, 3)
        Me.btn_get_regression.Name = "btn_get_regression"
        Me.btn_get_regression.Size = New System.Drawing.Size(115, 37)
        Me.btn_get_regression.TabIndex = 9
        Me.btn_get_regression.Text = "Get equation"
        Me.btn_get_regression.UseVisualStyleBackColor = False
        '
        'btn_aruco_Aruco
        '
        Me.btn_aruco_Aruco.BackColor = System.Drawing.Color.Red
        Me.btn_aruco_Aruco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_Aruco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_Aruco.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_aruco_Aruco.Location = New System.Drawing.Point(124, 3)
        Me.btn_aruco_Aruco.Name = "btn_aruco_Aruco"
        Me.btn_aruco_Aruco.Size = New System.Drawing.Size(115, 37)
        Me.btn_aruco_Aruco.TabIndex = 1
        Me.btn_aruco_Aruco.Text = "Start ArUco"
        Me.btn_aruco_Aruco.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(980, 49)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Config"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 3
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel5, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(974, 43)
        Me.TableLayoutPanel11.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_aruco_rs_beta, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_aruco_RS_Resolution, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_aruco_RS_FrameRate, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_aruco_rs_alpha, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(318, 37)
        Me.TableLayoutPanel4.TabIndex = 10
        '
        'txt_aruco_rs_beta
        '
        Me.txt_aruco_rs_beta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_rs_beta.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_aruco_rs_beta.Location = New System.Drawing.Point(162, 21)
        Me.txt_aruco_rs_beta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_aruco_rs_beta.Name = "txt_aruco_rs_beta"
        Me.txt_aruco_rs_beta.Size = New System.Drawing.Size(153, 20)
        Me.txt_aruco_rs_beta.TabIndex = 3
        '
        'txt_aruco_RS_Resolution
        '
        Me.txt_aruco_RS_Resolution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_RS_Resolution.Items.AddRange(New Object() {"1280 x 720", "848 x 480", "640 x 480", "640 x 360", "424 x 240"})
        Me.txt_aruco_RS_Resolution.Location = New System.Drawing.Point(3, 3)
        Me.txt_aruco_RS_Resolution.Name = "txt_aruco_RS_Resolution"
        Me.txt_aruco_RS_Resolution.Size = New System.Drawing.Size(153, 21)
        Me.txt_aruco_RS_Resolution.TabIndex = 0
        Me.txt_aruco_RS_Resolution.Text = "640 x 480"
        '
        'txt_aruco_RS_FrameRate
        '
        Me.txt_aruco_RS_FrameRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_RS_FrameRate.Items.AddRange(New Object() {"60", "30", "15", "6"})
        Me.txt_aruco_RS_FrameRate.Location = New System.Drawing.Point(162, 3)
        Me.txt_aruco_RS_FrameRate.Name = "txt_aruco_RS_FrameRate"
        Me.txt_aruco_RS_FrameRate.Size = New System.Drawing.Size(153, 21)
        Me.txt_aruco_RS_FrameRate.TabIndex = 1
        Me.txt_aruco_RS_FrameRate.Text = "30"
        '
        'txt_aruco_rs_alpha
        '
        Me.txt_aruco_rs_alpha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_rs_alpha.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txt_aruco_rs_alpha.Location = New System.Drawing.Point(3, 21)
        Me.txt_aruco_rs_alpha.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_aruco_rs_alpha.Name = "txt_aruco_rs_alpha"
        Me.txt_aruco_rs_alpha.Size = New System.Drawing.Size(153, 20)
        Me.txt_aruco_rs_alpha.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txt_aruco_ThrshBlockSize, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_aruco_ThrshSubMean, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_aruco_ThrshSelect, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(651, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(320, 37)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'txt_aruco_ThrshBlockSize
        '
        Me.txt_aruco_ThrshBlockSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_ThrshBlockSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txt_aruco_ThrshBlockSize.Location = New System.Drawing.Point(3, 21)
        Me.txt_aruco_ThrshBlockSize.Maximum = New Decimal(New Integer() {1001, 0, 0, 0})
        Me.txt_aruco_ThrshBlockSize.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txt_aruco_ThrshBlockSize.Name = "txt_aruco_ThrshBlockSize"
        Me.txt_aruco_ThrshBlockSize.Size = New System.Drawing.Size(154, 20)
        Me.txt_aruco_ThrshBlockSize.TabIndex = 1
        Me.txt_aruco_ThrshBlockSize.Value = New Decimal(New Integer() {71, 0, 0, 0})
        '
        'txt_aruco_ThrshSubMean
        '
        Me.txt_aruco_ThrshSubMean.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_ThrshSubMean.Location = New System.Drawing.Point(163, 21)
        Me.txt_aruco_ThrshSubMean.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_aruco_ThrshSubMean.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.txt_aruco_ThrshSubMean.Name = "txt_aruco_ThrshSubMean"
        Me.txt_aruco_ThrshSubMean.Size = New System.Drawing.Size(154, 20)
        Me.txt_aruco_ThrshSubMean.TabIndex = 2
        Me.txt_aruco_ThrshSubMean.Value = New Decimal(New Integer() {22, 0, 0, 0})
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "200"
        '
        'txt_aruco_ThrshSelect
        '
        Me.txt_aruco_ThrshSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_ThrshSelect.FormattingEnabled = True
        Me.txt_aruco_ThrshSelect.Items.AddRange(New Object() {"threshold adaptive", "threshold adaptive invert", "threshold", "threshold invert"})
        Me.txt_aruco_ThrshSelect.Location = New System.Drawing.Point(163, 3)
        Me.txt_aruco_ThrshSelect.Name = "txt_aruco_ThrshSelect"
        Me.txt_aruco_ThrshSelect.Size = New System.Drawing.Size(154, 21)
        Me.txt_aruco_ThrshSelect.TabIndex = 0
        Me.txt_aruco_ThrshSelect.Text = "threshold"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Aruco_MorphSelct1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Aruco_MorphDilateKernel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Aruco_MorphDilateIteration, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Aruco_MorphSelct2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Aruco_MorphOpenIteration, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Aruco_MorphOpenKernel, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(327, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(318, 37)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'txt_Aruco_MorphSelct1
        '
        Me.txt_Aruco_MorphSelct1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_MorphSelct1.FormattingEnabled = True
        Me.txt_Aruco_MorphSelct1.Items.AddRange(New Object() {"Dilate", "Erode"})
        Me.txt_Aruco_MorphSelct1.Location = New System.Drawing.Point(3, 3)
        Me.txt_Aruco_MorphSelct1.Name = "txt_Aruco_MorphSelct1"
        Me.txt_Aruco_MorphSelct1.Size = New System.Drawing.Size(100, 21)
        Me.txt_Aruco_MorphSelct1.TabIndex = 12
        Me.txt_Aruco_MorphSelct1.Text = "Dilate"
        '
        'txt_Aruco_MorphDilateKernel
        '
        Me.txt_Aruco_MorphDilateKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_MorphDilateKernel.Location = New System.Drawing.Point(109, 3)
        Me.txt_Aruco_MorphDilateKernel.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.txt_Aruco_MorphDilateKernel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Aruco_MorphDilateKernel.Name = "txt_Aruco_MorphDilateKernel"
        Me.txt_Aruco_MorphDilateKernel.Size = New System.Drawing.Size(100, 20)
        Me.txt_Aruco_MorphDilateKernel.TabIndex = 15
        Me.txt_Aruco_MorphDilateKernel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_Aruco_MorphDilateIteration
        '
        Me.txt_Aruco_MorphDilateIteration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_MorphDilateIteration.Location = New System.Drawing.Point(215, 3)
        Me.txt_Aruco_MorphDilateIteration.Name = "txt_Aruco_MorphDilateIteration"
        Me.txt_Aruco_MorphDilateIteration.Size = New System.Drawing.Size(100, 20)
        Me.txt_Aruco_MorphDilateIteration.TabIndex = 17
        '
        'txt_Aruco_MorphSelct2
        '
        Me.txt_Aruco_MorphSelct2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_MorphSelct2.FormattingEnabled = True
        Me.txt_Aruco_MorphSelct2.Items.AddRange(New Object() {"Open", "Close"})
        Me.txt_Aruco_MorphSelct2.Location = New System.Drawing.Point(3, 21)
        Me.txt_Aruco_MorphSelct2.Name = "txt_Aruco_MorphSelct2"
        Me.txt_Aruco_MorphSelct2.Size = New System.Drawing.Size(100, 21)
        Me.txt_Aruco_MorphSelct2.TabIndex = 13
        Me.txt_Aruco_MorphSelct2.Text = "Open"
        '
        'txt_Aruco_MorphOpenIteration
        '
        Me.txt_Aruco_MorphOpenIteration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_MorphOpenIteration.Location = New System.Drawing.Point(215, 21)
        Me.txt_Aruco_MorphOpenIteration.Name = "txt_Aruco_MorphOpenIteration"
        Me.txt_Aruco_MorphOpenIteration.Size = New System.Drawing.Size(100, 20)
        Me.txt_Aruco_MorphOpenIteration.TabIndex = 16
        '
        'txt_Aruco_MorphOpenKernel
        '
        Me.txt_Aruco_MorphOpenKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_MorphOpenKernel.Location = New System.Drawing.Point(109, 21)
        Me.txt_Aruco_MorphOpenKernel.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.txt_Aruco_MorphOpenKernel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Aruco_MorphOpenKernel.Name = "txt_Aruco_MorphOpenKernel"
        Me.txt_Aruco_MorphOpenKernel.Size = New System.Drawing.Size(100, 20)
        Me.txt_Aruco_MorphOpenKernel.TabIndex = 14
        Me.txt_Aruco_MorphOpenKernel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TableLayoutPanel8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(980, 49)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Color"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 8
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Aruco_Hue_Shift, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Aruco_Val_Shift, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Aruco_Val_low, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Aruco_Sat_low, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Aruco_Hue_low, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Aruco_Sat_Shift, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_Aruco_color_INV, 3, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(974, 43)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'txt_Aruco_Hue_Shift
        '
        Me.txt_Aruco_Hue_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_Hue_Shift.Location = New System.Drawing.Point(3, 24)
        Me.txt_Aruco_Hue_Shift.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.txt_Aruco_Hue_Shift.Name = "txt_Aruco_Hue_Shift"
        Me.txt_Aruco_Hue_Shift.Size = New System.Drawing.Size(115, 20)
        Me.txt_Aruco_Hue_Shift.TabIndex = 9
        Me.txt_Aruco_Hue_Shift.Value = New Decimal(New Integer() {122, 0, 0, 0})
        '
        'txt_Aruco_Val_Shift
        '
        Me.txt_Aruco_Val_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_Val_Shift.Location = New System.Drawing.Point(245, 24)
        Me.txt_Aruco_Val_Shift.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Aruco_Val_Shift.Name = "txt_Aruco_Val_Shift"
        Me.txt_Aruco_Val_Shift.Size = New System.Drawing.Size(115, 20)
        Me.txt_Aruco_Val_Shift.TabIndex = 8
        Me.txt_Aruco_Val_Shift.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'txt_Aruco_Val_low
        '
        Me.txt_Aruco_Val_low.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_Val_low.Location = New System.Drawing.Point(245, 3)
        Me.txt_Aruco_Val_low.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Aruco_Val_low.Name = "txt_Aruco_Val_low"
        Me.txt_Aruco_Val_low.Size = New System.Drawing.Size(115, 20)
        Me.txt_Aruco_Val_low.TabIndex = 2
        Me.txt_Aruco_Val_low.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'txt_Aruco_Sat_low
        '
        Me.txt_Aruco_Sat_low.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_Sat_low.Location = New System.Drawing.Point(124, 3)
        Me.txt_Aruco_Sat_low.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Aruco_Sat_low.Name = "txt_Aruco_Sat_low"
        Me.txt_Aruco_Sat_low.Size = New System.Drawing.Size(115, 20)
        Me.txt_Aruco_Sat_low.TabIndex = 1
        Me.txt_Aruco_Sat_low.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'txt_Aruco_Hue_low
        '
        Me.txt_Aruco_Hue_low.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_Hue_low.Location = New System.Drawing.Point(3, 3)
        Me.txt_Aruco_Hue_low.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Aruco_Hue_low.Name = "txt_Aruco_Hue_low"
        Me.txt_Aruco_Hue_low.Size = New System.Drawing.Size(115, 20)
        Me.txt_Aruco_Hue_low.TabIndex = 0
        Me.txt_Aruco_Hue_low.Value = New Decimal(New Integer() {94, 0, 0, 0})
        '
        'txt_Aruco_Sat_Shift
        '
        Me.txt_Aruco_Sat_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Aruco_Sat_Shift.Location = New System.Drawing.Point(124, 24)
        Me.txt_Aruco_Sat_Shift.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txt_Aruco_Sat_Shift.Name = "txt_Aruco_Sat_Shift"
        Me.txt_Aruco_Sat_Shift.Size = New System.Drawing.Size(115, 20)
        Me.txt_Aruco_Sat_Shift.TabIndex = 3
        Me.txt_Aruco_Sat_Shift.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'btn_Aruco_color_INV
        '
        Me.btn_Aruco_color_INV.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_Aruco_color_INV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Aruco_color_INV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aruco_color_INV.Location = New System.Drawing.Point(366, 3)
        Me.btn_Aruco_color_INV.Name = "btn_Aruco_color_INV"
        Me.TableLayoutPanel8.SetRowSpan(Me.btn_Aruco_color_INV, 2)
        Me.btn_Aruco_color_INV.Size = New System.Drawing.Size(115, 37)
        Me.btn_Aruco_color_INV.TabIndex = 10
        Me.btn_Aruco_color_INV.Text = "Normal"
        Me.btn_Aruco_color_INV.UseVisualStyleBackColor = False
        '
        'img_Measurement_RealSenseImage
        '
        Me.img_Measurement_RealSenseImage.Controls.Add(Me.tab_ArUco)
        Me.img_Measurement_RealSenseImage.Controls.Add(Me.tab_measurement)
        Me.img_Measurement_RealSenseImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_Measurement_RealSenseImage.Location = New System.Drawing.Point(0, 0)
        Me.img_Measurement_RealSenseImage.Name = "img_Measurement_RealSenseImage"
        Me.img_Measurement_RealSenseImage.SelectedIndex = 0
        Me.img_Measurement_RealSenseImage.Size = New System.Drawing.Size(1008, 681)
        Me.img_Measurement_RealSenseImage.TabIndex = 1
        '
        'btn_measure_align
        '
        Me.btn_measure_align.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_measure_align.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_measure_align.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_measure_align.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_measure_align.Location = New System.Drawing.Point(391, 3)
        Me.btn_measure_align.Name = "btn_measure_align"
        Me.btn_measure_align.Size = New System.Drawing.Size(91, 37)
        Me.btn_measure_align.TabIndex = 13
        Me.btn_measure_align.Text = "Aligned"
        Me.btn_measure_align.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 681)
        Me.Controls.Add(Me.img_Measurement_RealSenseImage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tab_measurement.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.img_Measurement_RealSense_detection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Measurement_RealSense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Measurement_RealSense_thresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Measurement_RealSense_morph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        CType(Me.txt_MorphOpenIteration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MorphOpenKernel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.txt_measurement_rs_beta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_measurement_rs_alpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel16.ResumeLayout(False)
        CType(Me.txt_ROIHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ROIWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ROIY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ROIX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel14.ResumeLayout(False)
        CType(Me.txt_MorphDilateKernel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MorphDilateIteration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel13.ResumeLayout(False)
        CType(Me.txt_measurement_ThrshBlockSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_measurement_ThrshSubMean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        CType(Me.txt_Measurement_Hue_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Measurement_Val_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Measurement_Val_low, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Measurement_Sat_low, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Measurement_Hue_low, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Measurement_Sat_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_ArUco.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        CType(Me.img_aruco_RealSenseDepthImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_aruco_ArUcoImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_aruco_RealSenseDepthImageThresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_aruco_RealSenseImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.txt_aruco_rs_beta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aruco_rs_alpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.txt_aruco_ThrshBlockSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aruco_ThrshSubMean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.txt_Aruco_MorphDilateKernel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_MorphDilateIteration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_MorphOpenIteration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_MorphOpenKernel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.txt_Aruco_Hue_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_Val_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_Val_low, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_Sat_low, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_Hue_low, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aruco_Sat_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.img_Measurement_RealSenseImage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents tab_measurement As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents img_Measurement_RealSense_detection As Emgu.CV.UI.ImageBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents txt_MorphOpenIteration As NumericUpDown
    Friend WithEvents txt_MorphSelct2 As ComboBox
    Friend WithEvents txt_MorphOpenKernel As NumericUpDown
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents txt_MorphSelct1 As ComboBox
    Friend WithEvents txt_MorphDilateKernel As NumericUpDown
    Friend WithEvents btn_Start_Measurment_Realsense As Button
    Friend WithEvents btn_measurement_image_mode As Button
    Friend WithEvents btn_EdgeDetect As Button
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents txt_measurement_ThrshSelect As ComboBox
    Friend WithEvents txt_measurement_ThrshSubMean As NumericUpDown
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents txt_ROIHeight As NumericUpDown
    Friend WithEvents txt_ROIWidth As NumericUpDown
    Friend WithEvents txt_ROIY As NumericUpDown
    Friend WithEvents txt_ROIX As NumericUpDown
    Friend WithEvents btn_save_csv As Button
    Friend WithEvents img_Measurement_RealSense As Emgu.CV.UI.ImageBox
    Friend WithEvents img_Measurement_RealSense_thresh As Emgu.CV.UI.ImageBox
    Friend WithEvents img_Measurement_RealSense_morph As Emgu.CV.UI.ImageBox
    Friend WithEvents tab_ArUco As TabPage
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_aruco_image_mode As Button
    Friend WithEvents btn_aruco_Aruco As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txt_aruco_ThrshSelect As ComboBox
    Friend WithEvents txt_aruco_ThrshBlockSize As NumericUpDown
    Friend WithEvents txt_aruco_ThrshSubMean As NumericUpDown
    Friend WithEvents btn_Start_aruco_RealSense As Button
    Friend WithEvents btn_aruco_EXIT As Button
    Friend WithEvents btn_aruco_csv As Button
    Friend WithEvents btn_get_regression As Button
    Friend WithEvents img_aruco_RealSenseDepthImage As Emgu.CV.UI.ImageBox
    Friend WithEvents img_aruco_ArUcoImage As Emgu.CV.UI.ImageBox
    Friend WithEvents img_aruco_RealSenseDepthImageThresh As Emgu.CV.UI.ImageBox
    Friend WithEvents img_Measurement_RealSenseImage As TabControl
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txt_aruco_rs_beta As NumericUpDown
    Friend WithEvents txt_aruco_RS_Resolution As ComboBox
    Friend WithEvents txt_aruco_RS_FrameRate As ComboBox
    Friend WithEvents txt_aruco_rs_alpha As NumericUpDown
    Friend WithEvents btn_Measurement_Exit As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txt_measurement_rs_beta As NumericUpDown
    Friend WithEvents txt_measurement_RS_Resolution As ComboBox
    Friend WithEvents txt_measurement_RS_FrameRate As ComboBox
    Friend WithEvents txt_measurement_rs_alpha As NumericUpDown
    Friend WithEvents img_aruco_RealSenseImage As Emgu.CV.UI.ImageBox
    Friend WithEvents btn_measurement_mode As Button
    Friend WithEvents btn_save_size As Button
    Friend WithEvents btn_clear_size As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents txt_MorphDilateIteration As NumericUpDown
    Friend WithEvents txt_measurement_ThrshBlockSize As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txt_Aruco_MorphSelct1 As ComboBox
    Friend WithEvents txt_Aruco_MorphOpenKernel As NumericUpDown
    Friend WithEvents txt_Aruco_MorphOpenIteration As NumericUpDown
    Friend WithEvents txt_Aruco_MorphDilateKernel As NumericUpDown
    Friend WithEvents txt_Aruco_MorphSelct2 As ComboBox
    Friend WithEvents txt_Aruco_MorphDilateIteration As NumericUpDown
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents txt_Aruco_Val_low As NumericUpDown
    Friend WithEvents txt_Aruco_Sat_low As NumericUpDown
    Friend WithEvents txt_Aruco_Hue_low As NumericUpDown
    Friend WithEvents txt_Aruco_Sat_Shift As NumericUpDown
    Friend WithEvents txt_Aruco_Hue_Shift As NumericUpDown
    Friend WithEvents txt_Aruco_Val_Shift As NumericUpDown
    Friend WithEvents btn_Aruco_Detection_method As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents txt_Measurement_Hue_Shift As NumericUpDown
    Friend WithEvents txt_Measurement_Val_Shift As NumericUpDown
    Friend WithEvents txt_Measurement_Val_low As NumericUpDown
    Friend WithEvents txt_Measurement_Sat_low As NumericUpDown
    Friend WithEvents txt_Measurement_Hue_low As NumericUpDown
    Friend WithEvents txt_Measurement_Sat_Shift As NumericUpDown
    Friend WithEvents btn_measurement_Detection_method As Button
    Friend WithEvents btn_Aruco_color_INV As Button
    Friend WithEvents btn_Measurement_color_INV As Button
    Friend WithEvents btn_aruco_align As Button
    Friend WithEvents btn_measure_align As Button
End Class
