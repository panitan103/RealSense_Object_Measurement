﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_MorphOpenIteration = New System.Windows.Forms.NumericUpDown()
        Me.txt_MorphSelct2 = New System.Windows.Forms.ComboBox()
        Me.txt_MorphOpenKernel = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_MorphSelct1 = New System.Windows.Forms.ComboBox()
        Me.txt_MorphDilateKernel = New System.Windows.Forms.NumericUpDown()
        Me.txt_MorphDilateIteration = New System.Windows.Forms.NumericUpDown()
        Me.btn_Start_Measurment_Realsense = New System.Windows.Forms.Button()
        Me.btn_Measurement_Exit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_measurement_ThrshSelect = New System.Windows.Forms.ComboBox()
        Me.txt_measurement_ThrshBlockSize = New System.Windows.Forms.NumericUpDown()
        Me.txt_measurement_ThrshSubMean = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ROIHeight = New System.Windows.Forms.NumericUpDown()
        Me.txt_ROIWidth = New System.Windows.Forms.NumericUpDown()
        Me.txt_ROIY = New System.Windows.Forms.NumericUpDown()
        Me.txt_ROIX = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_measurement_mode = New System.Windows.Forms.Button()
        Me.btn_measurement_image_mode = New System.Windows.Forms.Button()
        Me.btn_EdgeDetect = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_measurement_rs_beta = New System.Windows.Forms.NumericUpDown()
        Me.txt_measurement_RS_Resolution = New System.Windows.Forms.ComboBox()
        Me.txt_measurement_RS_FrameRate = New System.Windows.Forms.ComboBox()
        Me.txt_measurement_rs_alpha = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_save_size = New System.Windows.Forms.Button()
        Me.btn_save_csv = New System.Windows.Forms.Button()
        Me.img_Measurement_RealSense = New Emgu.CV.UI.ImageBox()
        Me.img_Measurement_RealSense_thresh = New Emgu.CV.UI.ImageBox()
        Me.img_Measurement_RealSense_morph = New Emgu.CV.UI.ImageBox()
        Me.tab_ArUco = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_aruco_image_mode = New System.Windows.Forms.Button()
        Me.btn_aruco_Aruco = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_aruco_ThrshSelect = New System.Windows.Forms.ComboBox()
        Me.txt_aruco_ThrshBlockSize = New System.Windows.Forms.NumericUpDown()
        Me.txt_aruco_ThrshSubMean = New System.Windows.Forms.NumericUpDown()
        Me.btn_Start_aruco_RealSense = New System.Windows.Forms.Button()
        Me.btn_aruco_EXIT = New System.Windows.Forms.Button()
        Me.btn_aruco_csv = New System.Windows.Forms.Button()
        Me.btn_get_regression = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_aruco_rs_beta = New System.Windows.Forms.NumericUpDown()
        Me.txt_aruco_RS_Resolution = New System.Windows.Forms.ComboBox()
        Me.txt_aruco_RS_FrameRate = New System.Windows.Forms.ComboBox()
        Me.txt_aruco_rs_alpha = New System.Windows.Forms.NumericUpDown()
        Me.img_aruco_RealSenseDepthImage = New Emgu.CV.UI.ImageBox()
        Me.img_aruco_ArUcoImage = New Emgu.CV.UI.ImageBox()
        Me.img_aruco_RealSenseDepthImageThresh = New Emgu.CV.UI.ImageBox()
        Me.img_aruco_RealSenseImage = New Emgu.CV.UI.ImageBox()
        Me.img_Measurement_RealSenseImage = New System.Windows.Forms.TabControl()
        Me.tab_config = New System.Windows.Forms.TabPage()
        Me.btn_clear_size = New System.Windows.Forms.Button()
        Me.tab_measurement.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.img_Measurement_RealSense_detection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        CType(Me.txt_MorphOpenIteration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MorphOpenKernel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel14.SuspendLayout()
        CType(Me.txt_MorphDilateKernel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MorphDilateIteration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel13.SuspendLayout()
        CType(Me.txt_measurement_ThrshBlockSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_measurement_ThrshSubMean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel16.SuspendLayout()
        CType(Me.txt_ROIHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ROIWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ROIY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ROIX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.txt_measurement_rs_beta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_measurement_rs_alpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.img_Measurement_RealSense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Measurement_RealSense_thresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Measurement_RealSense_morph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_ArUco.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.txt_aruco_ThrshBlockSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aruco_ThrshSubMean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.txt_aruco_rs_beta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aruco_rs_alpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_aruco_RealSenseDepthImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_aruco_ArUcoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_aruco_RealSenseDepthImageThresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_aruco_RealSenseImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.img_Measurement_RealSense, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.img_Measurement_RealSense_thresh, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.img_Measurement_RealSense_morph, 0, 1)
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
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 9
        Me.TableLayoutPanel6.SetColumnSpan(Me.TableLayoutPanel7, 2)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel15, 5, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel14, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_Start_Measurment_Realsense, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_Measurement_Exit, 8, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel13, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel16, 6, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel1, 7, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 571)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(988, 75)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 1
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.txt_MorphOpenIteration, 0, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.txt_MorphSelct2, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.txt_MorphOpenKernel, 0, 1)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(548, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 3
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(103, 69)
        Me.TableLayoutPanel15.TabIndex = 7
        '
        'txt_MorphOpenIteration
        '
        Me.txt_MorphOpenIteration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphOpenIteration.Location = New System.Drawing.Point(3, 49)
        Me.txt_MorphOpenIteration.Name = "txt_MorphOpenIteration"
        Me.txt_MorphOpenIteration.Size = New System.Drawing.Size(97, 20)
        Me.txt_MorphOpenIteration.TabIndex = 11
        '
        'txt_MorphSelct2
        '
        Me.txt_MorphSelct2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphSelct2.FormattingEnabled = True
        Me.txt_MorphSelct2.Items.AddRange(New Object() {"Open", "Close"})
        Me.txt_MorphSelct2.Location = New System.Drawing.Point(3, 3)
        Me.txt_MorphSelct2.Name = "txt_MorphSelct2"
        Me.txt_MorphSelct2.Size = New System.Drawing.Size(97, 21)
        Me.txt_MorphSelct2.TabIndex = 7
        Me.txt_MorphSelct2.Text = "Open"
        '
        'txt_MorphOpenKernel
        '
        Me.txt_MorphOpenKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphOpenKernel.Location = New System.Drawing.Point(3, 26)
        Me.txt_MorphOpenKernel.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.txt_MorphOpenKernel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MorphOpenKernel.Name = "txt_MorphOpenKernel"
        Me.txt_MorphOpenKernel.Size = New System.Drawing.Size(97, 20)
        Me.txt_MorphOpenKernel.TabIndex = 9
        Me.txt_MorphOpenKernel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.txt_MorphSelct1, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_MorphDilateKernel, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_MorphDilateIteration, 0, 2)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(439, 3)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 3
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(103, 69)
        Me.TableLayoutPanel14.TabIndex = 6
        '
        'txt_MorphSelct1
        '
        Me.txt_MorphSelct1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphSelct1.FormattingEnabled = True
        Me.txt_MorphSelct1.Items.AddRange(New Object() {"Dilate", "Erode"})
        Me.txt_MorphSelct1.Location = New System.Drawing.Point(3, 3)
        Me.txt_MorphSelct1.Name = "txt_MorphSelct1"
        Me.txt_MorphSelct1.Size = New System.Drawing.Size(97, 21)
        Me.txt_MorphSelct1.TabIndex = 6
        Me.txt_MorphSelct1.Text = "Dilate"
        '
        'txt_MorphDilateKernel
        '
        Me.txt_MorphDilateKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphDilateKernel.Location = New System.Drawing.Point(3, 26)
        Me.txt_MorphDilateKernel.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.txt_MorphDilateKernel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MorphDilateKernel.Name = "txt_MorphDilateKernel"
        Me.txt_MorphDilateKernel.Size = New System.Drawing.Size(97, 20)
        Me.txt_MorphDilateKernel.TabIndex = 8
        Me.txt_MorphDilateKernel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_MorphDilateIteration
        '
        Me.txt_MorphDilateIteration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MorphDilateIteration.Location = New System.Drawing.Point(3, 49)
        Me.txt_MorphDilateIteration.Name = "txt_MorphDilateIteration"
        Me.txt_MorphDilateIteration.Size = New System.Drawing.Size(97, 20)
        Me.txt_MorphDilateIteration.TabIndex = 10
        '
        'btn_Start_Measurment_Realsense
        '
        Me.btn_Start_Measurment_Realsense.BackColor = System.Drawing.Color.Red
        Me.btn_Start_Measurment_Realsense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Start_Measurment_Realsense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start_Measurment_Realsense.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Start_Measurment_Realsense.Location = New System.Drawing.Point(3, 3)
        Me.btn_Start_Measurment_Realsense.Name = "btn_Start_Measurment_Realsense"
        Me.btn_Start_Measurment_Realsense.Size = New System.Drawing.Size(103, 69)
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
        Me.btn_Measurement_Exit.Location = New System.Drawing.Point(875, 3)
        Me.btn_Measurement_Exit.Name = "btn_Measurement_Exit"
        Me.btn_Measurement_Exit.Size = New System.Drawing.Size(110, 69)
        Me.btn_Measurement_Exit.TabIndex = 2
        Me.btn_Measurement_Exit.Text = "Exit"
        Me.btn_Measurement_Exit.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 1
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.txt_measurement_ThrshSelect, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.txt_measurement_ThrshBlockSize, 0, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.txt_measurement_ThrshSubMean, 0, 2)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(330, 3)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 3
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(103, 69)
        Me.TableLayoutPanel13.TabIndex = 5
        '
        'txt_measurement_ThrshSelect
        '
        Me.txt_measurement_ThrshSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_ThrshSelect.FormattingEnabled = True
        Me.txt_measurement_ThrshSelect.Items.AddRange(New Object() {"threshold adaptive", "threshold adaptive invert"})
        Me.txt_measurement_ThrshSelect.Location = New System.Drawing.Point(3, 3)
        Me.txt_measurement_ThrshSelect.Name = "txt_measurement_ThrshSelect"
        Me.txt_measurement_ThrshSelect.Size = New System.Drawing.Size(97, 21)
        Me.txt_measurement_ThrshSelect.TabIndex = 0
        Me.txt_measurement_ThrshSelect.Text = "threshold adaptive"
        '
        'txt_measurement_ThrshBlockSize
        '
        Me.txt_measurement_ThrshBlockSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_ThrshBlockSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txt_measurement_ThrshBlockSize.Location = New System.Drawing.Point(3, 26)
        Me.txt_measurement_ThrshBlockSize.Maximum = New Decimal(New Integer() {1001, 0, 0, 0})
        Me.txt_measurement_ThrshBlockSize.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txt_measurement_ThrshBlockSize.Name = "txt_measurement_ThrshBlockSize"
        Me.txt_measurement_ThrshBlockSize.Size = New System.Drawing.Size(97, 20)
        Me.txt_measurement_ThrshBlockSize.TabIndex = 1
        Me.txt_measurement_ThrshBlockSize.Value = New Decimal(New Integer() {71, 0, 0, 0})
        '
        'txt_measurement_ThrshSubMean
        '
        Me.txt_measurement_ThrshSubMean.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_ThrshSubMean.Location = New System.Drawing.Point(3, 49)
        Me.txt_measurement_ThrshSubMean.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.txt_measurement_ThrshSubMean.Name = "txt_measurement_ThrshSubMean"
        Me.txt_measurement_ThrshSubMean.Size = New System.Drawing.Size(97, 20)
        Me.txt_measurement_ThrshSubMean.TabIndex = 2
        Me.txt_measurement_ThrshSubMean.Value = New Decimal(New Integer() {22, 0, 0, 0})
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
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(657, 3)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(103, 69)
        Me.TableLayoutPanel16.TabIndex = 8
        '
        'txt_ROIHeight
        '
        Me.txt_ROIHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIHeight.Location = New System.Drawing.Point(54, 37)
        Me.txt_ROIHeight.Name = "txt_ROIHeight"
        Me.txt_ROIHeight.Size = New System.Drawing.Size(46, 20)
        Me.txt_ROIHeight.TabIndex = 10
        '
        'txt_ROIWidth
        '
        Me.txt_ROIWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIWidth.Location = New System.Drawing.Point(54, 3)
        Me.txt_ROIWidth.Name = "txt_ROIWidth"
        Me.txt_ROIWidth.Size = New System.Drawing.Size(46, 20)
        Me.txt_ROIWidth.TabIndex = 8
        '
        'txt_ROIY
        '
        Me.txt_ROIY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIY.Location = New System.Drawing.Point(3, 37)
        Me.txt_ROIY.Name = "txt_ROIY"
        Me.txt_ROIY.Size = New System.Drawing.Size(45, 20)
        Me.txt_ROIY.TabIndex = 9
        '
        'txt_ROIX
        '
        Me.txt_ROIX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ROIX.Location = New System.Drawing.Point(3, 3)
        Me.txt_ROIX.Name = "txt_ROIX"
        Me.txt_ROIX.Size = New System.Drawing.Size(45, 20)
        Me.txt_ROIX.TabIndex = 7
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.btn_measurement_mode, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_measurement_image_mode, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_EdgeDetect, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(112, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(103, 69)
        Me.TableLayoutPanel8.TabIndex = 4
        '
        'btn_measurement_mode
        '
        Me.btn_measurement_mode.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_measurement_mode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_measurement_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_measurement_mode.Location = New System.Drawing.Point(3, 51)
        Me.btn_measurement_mode.Name = "btn_measurement_mode"
        Me.btn_measurement_mode.Size = New System.Drawing.Size(97, 15)
        Me.btn_measurement_mode.TabIndex = 7
        Me.btn_measurement_mode.Text = "LRG"
        Me.btn_measurement_mode.UseVisualStyleBackColor = False
        '
        'btn_measurement_image_mode
        '
        Me.btn_measurement_image_mode.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_measurement_image_mode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_measurement_image_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_measurement_image_mode.Location = New System.Drawing.Point(3, 27)
        Me.btn_measurement_image_mode.Name = "btn_measurement_image_mode"
        Me.btn_measurement_image_mode.Size = New System.Drawing.Size(97, 18)
        Me.btn_measurement_image_mode.TabIndex = 3
        Me.btn_measurement_image_mode.Text = "RGB"
        Me.btn_measurement_image_mode.UseVisualStyleBackColor = False
        '
        'btn_EdgeDetect
        '
        Me.btn_EdgeDetect.BackColor = System.Drawing.Color.Red
        Me.btn_EdgeDetect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_EdgeDetect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EdgeDetect.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_EdgeDetect.Location = New System.Drawing.Point(3, 3)
        Me.btn_EdgeDetect.Name = "btn_EdgeDetect"
        Me.btn_EdgeDetect.Size = New System.Drawing.Size(97, 18)
        Me.btn_EdgeDetect.TabIndex = 6
        Me.btn_EdgeDetect.Text = "edge"
        Me.btn_EdgeDetect.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(221, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(103, 69)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'txt_measurement_rs_beta
        '
        Me.txt_measurement_rs_beta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_rs_beta.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_measurement_rs_beta.Location = New System.Drawing.Point(54, 37)
        Me.txt_measurement_rs_beta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_measurement_rs_beta.Name = "txt_measurement_rs_beta"
        Me.txt_measurement_rs_beta.Size = New System.Drawing.Size(46, 20)
        Me.txt_measurement_rs_beta.TabIndex = 3
        '
        'txt_measurement_RS_Resolution
        '
        Me.txt_measurement_RS_Resolution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_RS_Resolution.Items.AddRange(New Object() {"1280 x 720", "848 x 480", "640 x 480", "640 x 360", "424 x 240"})
        Me.txt_measurement_RS_Resolution.Location = New System.Drawing.Point(3, 3)
        Me.txt_measurement_RS_Resolution.Name = "txt_measurement_RS_Resolution"
        Me.txt_measurement_RS_Resolution.Size = New System.Drawing.Size(45, 21)
        Me.txt_measurement_RS_Resolution.TabIndex = 0
        Me.txt_measurement_RS_Resolution.Text = "640 x 480"
        '
        'txt_measurement_RS_FrameRate
        '
        Me.txt_measurement_RS_FrameRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_RS_FrameRate.Items.AddRange(New Object() {"60", "30", "15", "6"})
        Me.txt_measurement_RS_FrameRate.Location = New System.Drawing.Point(54, 3)
        Me.txt_measurement_RS_FrameRate.Name = "txt_measurement_RS_FrameRate"
        Me.txt_measurement_RS_FrameRate.Size = New System.Drawing.Size(46, 21)
        Me.txt_measurement_RS_FrameRate.TabIndex = 1
        Me.txt_measurement_RS_FrameRate.Text = "30"
        '
        'txt_measurement_rs_alpha
        '
        Me.txt_measurement_rs_alpha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_measurement_rs_alpha.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_measurement_rs_alpha.Location = New System.Drawing.Point(3, 37)
        Me.txt_measurement_rs_alpha.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_measurement_rs_alpha.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_measurement_rs_alpha.Name = "txt_measurement_rs_alpha"
        Me.txt_measurement_rs_alpha.Size = New System.Drawing.Size(45, 20)
        Me.txt_measurement_rs_alpha.TabIndex = 2
        Me.txt_measurement_rs_alpha.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_clear_size, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save_size, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save_csv, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(766, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(103, 69)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'btn_save_size
        '
        Me.btn_save_size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_save_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_size.Location = New System.Drawing.Point(3, 3)
        Me.btn_save_size.Name = "btn_save_size"
        Me.btn_save_size.Size = New System.Drawing.Size(45, 28)
        Me.btn_save_size.TabIndex = 10
        Me.btn_save_size.Text = "Save obj size"
        Me.btn_save_size.UseVisualStyleBackColor = True
        '
        'btn_save_csv
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btn_save_csv, 2)
        Me.btn_save_csv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_save_csv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_csv.Location = New System.Drawing.Point(3, 37)
        Me.btn_save_csv.Name = "btn_save_csv"
        Me.btn_save_csv.Size = New System.Drawing.Size(97, 29)
        Me.btn_save_csv.TabIndex = 9
        Me.btn_save_csv.Text = "Save to CSV"
        Me.btn_save_csv.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_RealSenseDepthImage, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_ArUcoImage, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_RealSenseDepthImageThresh, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.img_aruco_RealSenseImage, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 3
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(994, 649)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel10.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel9, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Start_aruco_RealSense, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_aruco_EXIT, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_aruco_csv, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_get_regression, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 571)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(988, 75)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.btn_aruco_image_mode, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.btn_aruco_Aruco, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(144, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(135, 69)
        Me.TableLayoutPanel9.TabIndex = 7
        '
        'btn_aruco_image_mode
        '
        Me.btn_aruco_image_mode.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_aruco_image_mode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_image_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_image_mode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_aruco_image_mode.Location = New System.Drawing.Point(3, 37)
        Me.btn_aruco_image_mode.Name = "btn_aruco_image_mode"
        Me.btn_aruco_image_mode.Size = New System.Drawing.Size(129, 29)
        Me.btn_aruco_image_mode.TabIndex = 6
        Me.btn_aruco_image_mode.Text = "RGB"
        Me.btn_aruco_image_mode.UseVisualStyleBackColor = False
        '
        'btn_aruco_Aruco
        '
        Me.btn_aruco_Aruco.BackColor = System.Drawing.Color.Red
        Me.btn_aruco_Aruco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_Aruco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_Aruco.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_aruco_Aruco.Location = New System.Drawing.Point(3, 3)
        Me.btn_aruco_Aruco.Name = "btn_aruco_Aruco"
        Me.btn_aruco_Aruco.Size = New System.Drawing.Size(129, 28)
        Me.btn_aruco_Aruco.TabIndex = 1
        Me.btn_aruco_Aruco.Text = "Start ArUco"
        Me.btn_aruco_Aruco.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txt_aruco_ThrshSelect, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_aruco_ThrshBlockSize, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_aruco_ThrshSubMean, 1, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(426, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(135, 69)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'txt_aruco_ThrshSelect
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.txt_aruco_ThrshSelect, 2)
        Me.txt_aruco_ThrshSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_ThrshSelect.FormattingEnabled = True
        Me.txt_aruco_ThrshSelect.Items.AddRange(New Object() {"threshold adaptive", "threshold adaptive invert"})
        Me.txt_aruco_ThrshSelect.Location = New System.Drawing.Point(3, 3)
        Me.txt_aruco_ThrshSelect.Name = "txt_aruco_ThrshSelect"
        Me.txt_aruco_ThrshSelect.Size = New System.Drawing.Size(129, 21)
        Me.txt_aruco_ThrshSelect.TabIndex = 0
        Me.txt_aruco_ThrshSelect.Text = "threshold adaptive"
        '
        'txt_aruco_ThrshBlockSize
        '
        Me.txt_aruco_ThrshBlockSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_ThrshBlockSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txt_aruco_ThrshBlockSize.Location = New System.Drawing.Point(3, 37)
        Me.txt_aruco_ThrshBlockSize.Maximum = New Decimal(New Integer() {1001, 0, 0, 0})
        Me.txt_aruco_ThrshBlockSize.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txt_aruco_ThrshBlockSize.Name = "txt_aruco_ThrshBlockSize"
        Me.txt_aruco_ThrshBlockSize.Size = New System.Drawing.Size(61, 20)
        Me.txt_aruco_ThrshBlockSize.TabIndex = 1
        Me.txt_aruco_ThrshBlockSize.Value = New Decimal(New Integer() {71, 0, 0, 0})
        '
        'txt_aruco_ThrshSubMean
        '
        Me.txt_aruco_ThrshSubMean.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_ThrshSubMean.Location = New System.Drawing.Point(70, 37)
        Me.txt_aruco_ThrshSubMean.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.txt_aruco_ThrshSubMean.Name = "txt_aruco_ThrshSubMean"
        Me.txt_aruco_ThrshSubMean.Size = New System.Drawing.Size(62, 20)
        Me.txt_aruco_ThrshSubMean.TabIndex = 2
        Me.txt_aruco_ThrshSubMean.Value = New Decimal(New Integer() {22, 0, 0, 0})
        '
        'btn_Start_aruco_RealSense
        '
        Me.btn_Start_aruco_RealSense.BackColor = System.Drawing.Color.Red
        Me.btn_Start_aruco_RealSense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Start_aruco_RealSense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start_aruco_RealSense.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_Start_aruco_RealSense.Location = New System.Drawing.Point(3, 3)
        Me.btn_Start_aruco_RealSense.Name = "btn_Start_aruco_RealSense"
        Me.btn_Start_aruco_RealSense.Size = New System.Drawing.Size(135, 69)
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
        Me.btn_aruco_EXIT.Location = New System.Drawing.Point(849, 3)
        Me.btn_aruco_EXIT.Name = "btn_aruco_EXIT"
        Me.btn_aruco_EXIT.Size = New System.Drawing.Size(136, 69)
        Me.btn_aruco_EXIT.TabIndex = 4
        Me.btn_aruco_EXIT.Text = "EXIT"
        Me.btn_aruco_EXIT.UseVisualStyleBackColor = False
        '
        'btn_aruco_csv
        '
        Me.btn_aruco_csv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_aruco_csv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aruco_csv.Location = New System.Drawing.Point(708, 3)
        Me.btn_aruco_csv.Name = "btn_aruco_csv"
        Me.btn_aruco_csv.Size = New System.Drawing.Size(135, 69)
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
        Me.btn_get_regression.Location = New System.Drawing.Point(567, 3)
        Me.btn_get_regression.Name = "btn_get_regression"
        Me.btn_get_regression.Size = New System.Drawing.Size(135, 69)
        Me.btn_get_regression.TabIndex = 9
        Me.btn_get_regression.Text = "Get equation"
        Me.btn_get_regression.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(285, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(135, 69)
        Me.TableLayoutPanel4.TabIndex = 10
        '
        'txt_aruco_rs_beta
        '
        Me.txt_aruco_rs_beta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_rs_beta.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_aruco_rs_beta.Location = New System.Drawing.Point(70, 37)
        Me.txt_aruco_rs_beta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_aruco_rs_beta.Name = "txt_aruco_rs_beta"
        Me.txt_aruco_rs_beta.Size = New System.Drawing.Size(62, 20)
        Me.txt_aruco_rs_beta.TabIndex = 3
        '
        'txt_aruco_RS_Resolution
        '
        Me.txt_aruco_RS_Resolution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_RS_Resolution.Items.AddRange(New Object() {"1280 x 720", "848 x 480", "640 x 480", "640 x 360", "424 x 240"})
        Me.txt_aruco_RS_Resolution.Location = New System.Drawing.Point(3, 3)
        Me.txt_aruco_RS_Resolution.Name = "txt_aruco_RS_Resolution"
        Me.txt_aruco_RS_Resolution.Size = New System.Drawing.Size(61, 21)
        Me.txt_aruco_RS_Resolution.TabIndex = 0
        Me.txt_aruco_RS_Resolution.Text = "640 x 480"
        '
        'txt_aruco_RS_FrameRate
        '
        Me.txt_aruco_RS_FrameRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_RS_FrameRate.Items.AddRange(New Object() {"60", "30", "15", "6"})
        Me.txt_aruco_RS_FrameRate.Location = New System.Drawing.Point(70, 3)
        Me.txt_aruco_RS_FrameRate.Name = "txt_aruco_RS_FrameRate"
        Me.txt_aruco_RS_FrameRate.Size = New System.Drawing.Size(62, 21)
        Me.txt_aruco_RS_FrameRate.TabIndex = 1
        Me.txt_aruco_RS_FrameRate.Text = "30"
        '
        'txt_aruco_rs_alpha
        '
        Me.txt_aruco_rs_alpha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aruco_rs_alpha.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_aruco_rs_alpha.Location = New System.Drawing.Point(3, 37)
        Me.txt_aruco_rs_alpha.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_aruco_rs_alpha.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_aruco_rs_alpha.Name = "txt_aruco_rs_alpha"
        Me.txt_aruco_rs_alpha.Size = New System.Drawing.Size(61, 20)
        Me.txt_aruco_rs_alpha.TabIndex = 2
        Me.txt_aruco_rs_alpha.Value = New Decimal(New Integer() {500, 0, 0, 0})
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
        'img_Measurement_RealSenseImage
        '
        Me.img_Measurement_RealSenseImage.Controls.Add(Me.tab_ArUco)
        Me.img_Measurement_RealSenseImage.Controls.Add(Me.tab_measurement)
        Me.img_Measurement_RealSenseImage.Controls.Add(Me.tab_config)
        Me.img_Measurement_RealSenseImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_Measurement_RealSenseImage.Location = New System.Drawing.Point(0, 0)
        Me.img_Measurement_RealSenseImage.Name = "img_Measurement_RealSenseImage"
        Me.img_Measurement_RealSenseImage.SelectedIndex = 0
        Me.img_Measurement_RealSenseImage.Size = New System.Drawing.Size(1008, 681)
        Me.img_Measurement_RealSenseImage.TabIndex = 1
        '
        'tab_config
        '
        Me.tab_config.Location = New System.Drawing.Point(4, 22)
        Me.tab_config.Name = "tab_config"
        Me.tab_config.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_config.Size = New System.Drawing.Size(1000, 655)
        Me.tab_config.TabIndex = 4
        Me.tab_config.Text = "Config"
        Me.tab_config.UseVisualStyleBackColor = True
        '
        'btn_clear_size
        '
        Me.btn_clear_size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_clear_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear_size.Location = New System.Drawing.Point(54, 3)
        Me.btn_clear_size.Name = "btn_clear_size"
        Me.btn_clear_size.Size = New System.Drawing.Size(46, 28)
        Me.btn_clear_size.TabIndex = 11
        Me.btn_clear_size.Text = "Clear obj size"
        Me.btn_clear_size.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        CType(Me.txt_MorphOpenIteration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MorphOpenKernel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel14.ResumeLayout(False)
        CType(Me.txt_MorphDilateKernel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MorphDilateIteration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel13.ResumeLayout(False)
        CType(Me.txt_measurement_ThrshBlockSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_measurement_ThrshSubMean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel16.ResumeLayout(False)
        CType(Me.txt_ROIHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ROIWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ROIY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ROIX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.txt_measurement_rs_beta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_measurement_rs_alpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.img_Measurement_RealSense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Measurement_RealSense_thresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Measurement_RealSense_morph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_ArUco.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.txt_aruco_ThrshBlockSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aruco_ThrshSubMean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.txt_aruco_rs_beta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aruco_rs_alpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_aruco_RealSenseDepthImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_aruco_ArUcoImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_aruco_RealSenseDepthImageThresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_aruco_RealSenseImage, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_MorphDilateIteration As NumericUpDown
    Friend WithEvents btn_Start_Measurment_Realsense As Button
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents btn_measurement_image_mode As Button
    Friend WithEvents btn_EdgeDetect As Button
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents txt_measurement_ThrshSelect As ComboBox
    Friend WithEvents txt_measurement_ThrshBlockSize As NumericUpDown
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
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
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
    Friend WithEvents tab_config As TabPage
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_save_size As Button
    Friend WithEvents btn_clear_size As Button
End Class
