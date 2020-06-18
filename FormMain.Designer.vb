<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Debug")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Defaults")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Offsets")
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.tlsMain = New System.Windows.Forms.ToolStrip()
        Me.tlbStart = New System.Windows.Forms.ToolStripButton()
        Me.tlbReset = New System.Windows.Forms.ToolStripButton()
        Me.tlbSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbSendFeedback = New System.Windows.Forms.ToolStripButton()
        Me.tlbHelp = New System.Windows.Forms.ToolStripButton()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tbpConvertRoute = New System.Windows.Forms.TabPage()
        Me.spcConvertRoute = New System.Windows.Forms.SplitContainer()
        Me.pnlConvertRoute = New System.Windows.Forms.Panel()
        Me.grbCourse = New System.Windows.Forms.GroupBox()
        Me.lblCourseFileName = New System.Windows.Forms.Label()
        Me.txtCourseFileName = New System.Windows.Forms.TextBox()
        Me.btnSaveCourseFile = New System.Windows.Forms.Button()
        Me.grbMapEditor = New System.Windows.Forms.GroupBox()
        Me.lblMapEditorFileName = New System.Windows.Forms.Label()
        Me.txtMapEditorFileName = New System.Windows.Forms.TextBox()
        Me.btnOpenMapEditorFile = New System.Windows.Forms.Button()
        Me.tabDebugWindow = New System.Windows.Forms.TabControl()
        Me.tbpOutput = New System.Windows.Forms.TabPage()
        Me.pnlOutput = New System.Windows.Forms.Panel()
        Me.rtfOutput = New System.Windows.Forms.RichTextBox()
        Me.tbpDataset = New System.Windows.Forms.TabPage()
        Me.pnlDataset = New System.Windows.Forms.Panel()
        Me.spcDataset = New System.Windows.Forms.SplitContainer()
        Me.tvwDataset = New System.Windows.Forms.TreeView()
        Me.dgvDataset = New System.Windows.Forms.DataGridView()
        Me.imlTab = New System.Windows.Forms.ImageList(Me.components)
        Me.tbpSettings = New System.Windows.Forms.TabPage()
        Me.spcSettings = New System.Windows.Forms.SplitContainer()
        Me.tvwSettings = New System.Windows.Forms.TreeView()
        Me.pnlSettingsDebug = New System.Windows.Forms.Panel()
        Me.grbDebug = New System.Windows.Forms.GroupBox()
        Me.chkDebugShowWindow = New System.Windows.Forms.CheckBox()
        Me.pnlSettingsDefaults = New System.Windows.Forms.Panel()
        Me.grbDefaultFileName = New System.Windows.Forms.GroupBox()
        Me.chkGenerateFileName = New System.Windows.Forms.CheckBox()
        Me.grbDefaultDirectories = New System.Windows.Forms.GroupBox()
        Me.lblDefaultDirectoryMapEditor = New System.Windows.Forms.Label()
        Me.txtDefaultDirectoryMapEditor = New System.Windows.Forms.TextBox()
        Me.btnSetMapEditorDirectory = New System.Windows.Forms.Button()
        Me.lblDefaultDirectoryCourse = New System.Windows.Forms.Label()
        Me.txtDefaultDirectoryCourse = New System.Windows.Forms.TextBox()
        Me.btnSetCourseDirectory = New System.Windows.Forms.Button()
        Me.pnlSettingsOffsets = New System.Windows.Forms.Panel()
        Me.grbOffsets = New System.Windows.Forms.GroupBox()
        Me.nudZOffset = New System.Windows.Forms.NumericUpDown()
        Me.nudYOffset = New System.Windows.Forms.NumericUpDown()
        Me.nudXOffset = New System.Windows.Forms.NumericUpDown()
        Me.lblZOffset = New System.Windows.Forms.Label()
        Me.lblYOffset = New System.Windows.Forms.Label()
        Me.lblXOffset = New System.Windows.Forms.Label()
        Me.chkEnableOffsets = New System.Windows.Forms.CheckBox()
        Me.stsStatus = New System.Windows.Forms.StatusStrip()
        Me.tssStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.tlsMain.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tbpConvertRoute.SuspendLayout()
        CType(Me.spcConvertRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcConvertRoute.Panel1.SuspendLayout()
        Me.spcConvertRoute.Panel2.SuspendLayout()
        Me.spcConvertRoute.SuspendLayout()
        Me.pnlConvertRoute.SuspendLayout()
        Me.grbCourse.SuspendLayout()
        Me.grbMapEditor.SuspendLayout()
        Me.tabDebugWindow.SuspendLayout()
        Me.tbpOutput.SuspendLayout()
        Me.pnlOutput.SuspendLayout()
        Me.tbpDataset.SuspendLayout()
        Me.pnlDataset.SuspendLayout()
        CType(Me.spcDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcDataset.Panel1.SuspendLayout()
        Me.spcDataset.Panel2.SuspendLayout()
        Me.spcDataset.SuspendLayout()
        CType(Me.dgvDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpSettings.SuspendLayout()
        CType(Me.spcSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcSettings.Panel1.SuspendLayout()
        Me.spcSettings.Panel2.SuspendLayout()
        Me.spcSettings.SuspendLayout()
        Me.pnlSettingsDebug.SuspendLayout()
        Me.grbDebug.SuspendLayout()
        Me.pnlSettingsDefaults.SuspendLayout()
        Me.grbDefaultFileName.SuspendLayout()
        Me.grbDefaultDirectories.SuspendLayout()
        Me.pnlSettingsOffsets.SuspendLayout()
        Me.grbOffsets.SuspendLayout()
        CType(Me.nudZOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Title = "Select Route"
        '
        'tlsMain
        '
        Me.tlsMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlsMain.BackColor = System.Drawing.SystemColors.Control
        Me.tlsMain.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsMain.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tlsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbStart, Me.tlbReset, Me.tlbSeparator, Me.tlbSendFeedback, Me.tlbHelp})
        Me.tlsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tlsMain.Location = New System.Drawing.Point(519, -1)
        Me.tlsMain.Name = "tlsMain"
        Me.tlsMain.Padding = New System.Windows.Forms.Padding(0)
        Me.tlsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlsMain.Size = New System.Drawing.Size(100, 25)
        Me.tlsMain.TabIndex = 35
        '
        'tlbStart
        '
        Me.tlbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbStart.Image = CType(resources.GetObject("tlbStart.Image"), System.Drawing.Image)
        Me.tlbStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbStart.Name = "tlbStart"
        Me.tlbStart.Size = New System.Drawing.Size(23, 22)
        Me.tlbStart.Text = "Start (F5)"
        '
        'tlbReset
        '
        Me.tlbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbReset.Image = CType(resources.GetObject("tlbReset.Image"), System.Drawing.Image)
        Me.tlbReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbReset.Name = "tlbReset"
        Me.tlbReset.Size = New System.Drawing.Size(23, 22)
        Me.tlbReset.Text = "Reset (Del)"
        '
        'tlbSeparator
        '
        Me.tlbSeparator.Name = "tlbSeparator"
        Me.tlbSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'tlbSendFeedback
        '
        Me.tlbSendFeedback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbSendFeedback.Image = CType(resources.GetObject("tlbSendFeedback.Image"), System.Drawing.Image)
        Me.tlbSendFeedback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSendFeedback.Name = "tlbSendFeedback"
        Me.tlbSendFeedback.Size = New System.Drawing.Size(23, 22)
        Me.tlbSendFeedback.Text = "Send Feedback (F2)"
        Me.tlbSendFeedback.ToolTipText = "Send Feedback (F2)"
        '
        'tlbHelp
        '
        Me.tlbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbHelp.Image = CType(resources.GetObject("tlbHelp.Image"), System.Drawing.Image)
        Me.tlbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbHelp.Name = "tlbHelp"
        Me.tlbHelp.Size = New System.Drawing.Size(23, 22)
        Me.tlbHelp.Text = "Help (F1)"
        Me.tlbHelp.ToolTipText = "Help (F1)"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tbpConvertRoute)
        Me.tabMain.Controls.Add(Me.tbpSettings)
        Me.tabMain.ImageList = Me.imlTab
        Me.tabMain.Location = New System.Drawing.Point(3, 3)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(620, 295)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabStop = False
        '
        'tbpConvertRoute
        '
        Me.tbpConvertRoute.Controls.Add(Me.spcConvertRoute)
        Me.tbpConvertRoute.ImageKey = "tabConvertRoute"
        Me.tbpConvertRoute.Location = New System.Drawing.Point(4, 23)
        Me.tbpConvertRoute.Name = "tbpConvertRoute"
        Me.tbpConvertRoute.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConvertRoute.Size = New System.Drawing.Size(612, 268)
        Me.tbpConvertRoute.TabIndex = 1
        Me.tbpConvertRoute.Text = "Convert Route"
        Me.tbpConvertRoute.UseVisualStyleBackColor = True
        '
        'spcConvertRoute
        '
        Me.spcConvertRoute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcConvertRoute.Location = New System.Drawing.Point(3, 3)
        Me.spcConvertRoute.Name = "spcConvertRoute"
        Me.spcConvertRoute.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcConvertRoute.Panel1
        '
        Me.spcConvertRoute.Panel1.Controls.Add(Me.pnlConvertRoute)
        '
        'spcConvertRoute.Panel2
        '
        Me.spcConvertRoute.Panel2.Controls.Add(Me.tabDebugWindow)
        Me.spcConvertRoute.Size = New System.Drawing.Size(606, 262)
        Me.spcConvertRoute.SplitterDistance = 140
        Me.spcConvertRoute.TabIndex = 3
        '
        'pnlConvertRoute
        '
        Me.pnlConvertRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConvertRoute.Controls.Add(Me.grbCourse)
        Me.pnlConvertRoute.Controls.Add(Me.grbMapEditor)
        Me.pnlConvertRoute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConvertRoute.Location = New System.Drawing.Point(0, 0)
        Me.pnlConvertRoute.Name = "pnlConvertRoute"
        Me.pnlConvertRoute.Size = New System.Drawing.Size(606, 140)
        Me.pnlConvertRoute.TabIndex = 2
        '
        'grbCourse
        '
        Me.grbCourse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbCourse.Controls.Add(Me.lblCourseFileName)
        Me.grbCourse.Controls.Add(Me.txtCourseFileName)
        Me.grbCourse.Controls.Add(Me.btnSaveCourseFile)
        Me.grbCourse.Location = New System.Drawing.Point(9, 73)
        Me.grbCourse.Name = "grbCourse"
        Me.grbCourse.Size = New System.Drawing.Size(586, 56)
        Me.grbCourse.TabIndex = 3
        Me.grbCourse.TabStop = False
        Me.grbCourse.Text = "Course"
        '
        'lblCourseFileName
        '
        Me.lblCourseFileName.AutoSize = True
        Me.lblCourseFileName.Location = New System.Drawing.Point(14, 26)
        Me.lblCourseFileName.Name = "lblCourseFileName"
        Me.lblCourseFileName.Size = New System.Drawing.Size(57, 13)
        Me.lblCourseFileName.TabIndex = 37
        Me.lblCourseFileName.Text = "File Name:"
        '
        'txtCourseFileName
        '
        Me.txtCourseFileName.AllowDrop = True
        Me.txtCourseFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourseFileName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCourseFileName.Location = New System.Drawing.Point(77, 23)
        Me.txtCourseFileName.Name = "txtCourseFileName"
        Me.txtCourseFileName.ReadOnly = True
        Me.txtCourseFileName.Size = New System.Drawing.Size(462, 20)
        Me.txtCourseFileName.TabIndex = 38
        Me.txtCourseFileName.TabStop = False
        '
        'btnSaveCourseFile
        '
        Me.btnSaveCourseFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveCourseFile.FlatAppearance.BorderSize = 0
        Me.btnSaveCourseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSaveCourseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCourseFile.Image = CType(resources.GetObject("btnSaveCourseFile.Image"), System.Drawing.Image)
        Me.btnSaveCourseFile.Location = New System.Drawing.Point(551, 23)
        Me.btnSaveCourseFile.Name = "btnSaveCourseFile"
        Me.btnSaveCourseFile.Size = New System.Drawing.Size(21, 21)
        Me.btnSaveCourseFile.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.btnSaveCourseFile, "Set Course File (Ctrl+S)")
        Me.btnSaveCourseFile.UseVisualStyleBackColor = True
        '
        'grbMapEditor
        '
        Me.grbMapEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbMapEditor.Controls.Add(Me.lblMapEditorFileName)
        Me.grbMapEditor.Controls.Add(Me.txtMapEditorFileName)
        Me.grbMapEditor.Controls.Add(Me.btnOpenMapEditorFile)
        Me.grbMapEditor.Location = New System.Drawing.Point(9, 7)
        Me.grbMapEditor.Name = "grbMapEditor"
        Me.grbMapEditor.Size = New System.Drawing.Size(586, 56)
        Me.grbMapEditor.TabIndex = 2
        Me.grbMapEditor.TabStop = False
        Me.grbMapEditor.Text = "Map Editor"
        '
        'lblMapEditorFileName
        '
        Me.lblMapEditorFileName.AutoSize = True
        Me.lblMapEditorFileName.Location = New System.Drawing.Point(14, 26)
        Me.lblMapEditorFileName.Name = "lblMapEditorFileName"
        Me.lblMapEditorFileName.Size = New System.Drawing.Size(57, 13)
        Me.lblMapEditorFileName.TabIndex = 8
        Me.lblMapEditorFileName.Text = "File Name:"
        '
        'txtMapEditorFileName
        '
        Me.txtMapEditorFileName.AllowDrop = True
        Me.txtMapEditorFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMapEditorFileName.BackColor = System.Drawing.SystemColors.Window
        Me.txtMapEditorFileName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMapEditorFileName.Location = New System.Drawing.Point(77, 23)
        Me.txtMapEditorFileName.Name = "txtMapEditorFileName"
        Me.txtMapEditorFileName.ReadOnly = True
        Me.txtMapEditorFileName.Size = New System.Drawing.Size(462, 20)
        Me.txtMapEditorFileName.TabIndex = 0
        Me.txtMapEditorFileName.TabStop = False
        '
        'btnOpenMapEditorFile
        '
        Me.btnOpenMapEditorFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenMapEditorFile.FlatAppearance.BorderSize = 0
        Me.btnOpenMapEditorFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnOpenMapEditorFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenMapEditorFile.Image = CType(resources.GetObject("btnOpenMapEditorFile.Image"), System.Drawing.Image)
        Me.btnOpenMapEditorFile.Location = New System.Drawing.Point(551, 23)
        Me.btnOpenMapEditorFile.Name = "btnOpenMapEditorFile"
        Me.btnOpenMapEditorFile.Size = New System.Drawing.Size(21, 21)
        Me.btnOpenMapEditorFile.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.btnOpenMapEditorFile, "Set Map Editor File (Ctrl+O)")
        Me.btnOpenMapEditorFile.UseVisualStyleBackColor = False
        '
        'tabDebugWindow
        '
        Me.tabDebugWindow.Controls.Add(Me.tbpOutput)
        Me.tabDebugWindow.Controls.Add(Me.tbpDataset)
        Me.tabDebugWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDebugWindow.ImageList = Me.imlTab
        Me.tabDebugWindow.Location = New System.Drawing.Point(0, 0)
        Me.tabDebugWindow.Name = "tabDebugWindow"
        Me.tabDebugWindow.SelectedIndex = 0
        Me.tabDebugWindow.Size = New System.Drawing.Size(606, 118)
        Me.tabDebugWindow.TabIndex = 4
        '
        'tbpOutput
        '
        Me.tbpOutput.Controls.Add(Me.pnlOutput)
        Me.tbpOutput.ImageKey = "tabOutput.png"
        Me.tbpOutput.Location = New System.Drawing.Point(4, 23)
        Me.tbpOutput.Name = "tbpOutput"
        Me.tbpOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOutput.Size = New System.Drawing.Size(598, 91)
        Me.tbpOutput.TabIndex = 1
        Me.tbpOutput.Text = "Ouput"
        Me.tbpOutput.UseVisualStyleBackColor = True
        '
        'pnlOutput
        '
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOutput.Controls.Add(Me.rtfOutput)
        Me.pnlOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOutput.Location = New System.Drawing.Point(3, 3)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(592, 85)
        Me.pnlOutput.TabIndex = 0
        '
        'rtfOutput
        '
        Me.rtfOutput.BackColor = System.Drawing.SystemColors.Window
        Me.rtfOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfOutput.Location = New System.Drawing.Point(0, 0)
        Me.rtfOutput.Name = "rtfOutput"
        Me.rtfOutput.ReadOnly = True
        Me.rtfOutput.Size = New System.Drawing.Size(590, 83)
        Me.rtfOutput.TabIndex = 0
        Me.rtfOutput.Text = ""
        '
        'tbpDataset
        '
        Me.tbpDataset.Controls.Add(Me.pnlDataset)
        Me.tbpDataset.ImageKey = "tlbElements"
        Me.tbpDataset.Location = New System.Drawing.Point(4, 23)
        Me.tbpDataset.Name = "tbpDataset"
        Me.tbpDataset.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDataset.Size = New System.Drawing.Size(598, 91)
        Me.tbpDataset.TabIndex = 0
        Me.tbpDataset.Text = "Dataset"
        Me.tbpDataset.UseVisualStyleBackColor = True
        '
        'pnlDataset
        '
        Me.pnlDataset.Controls.Add(Me.spcDataset)
        Me.pnlDataset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataset.Location = New System.Drawing.Point(3, 3)
        Me.pnlDataset.Name = "pnlDataset"
        Me.pnlDataset.Size = New System.Drawing.Size(592, 85)
        Me.pnlDataset.TabIndex = 8
        '
        'spcDataset
        '
        Me.spcDataset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcDataset.Location = New System.Drawing.Point(0, 0)
        Me.spcDataset.Name = "spcDataset"
        '
        'spcDataset.Panel1
        '
        Me.spcDataset.Panel1.Controls.Add(Me.tvwDataset)
        '
        'spcDataset.Panel2
        '
        Me.spcDataset.Panel2.Controls.Add(Me.dgvDataset)
        Me.spcDataset.Size = New System.Drawing.Size(592, 85)
        Me.spcDataset.SplitterDistance = 139
        Me.spcDataset.TabIndex = 8
        '
        'tvwDataset
        '
        Me.tvwDataset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwDataset.Location = New System.Drawing.Point(0, 0)
        Me.tvwDataset.Name = "tvwDataset"
        Me.tvwDataset.Size = New System.Drawing.Size(139, 85)
        Me.tvwDataset.TabIndex = 0
        '
        'dgvDataset
        '
        Me.dgvDataset.AllowUserToAddRows = False
        Me.dgvDataset.AllowUserToDeleteRows = False
        Me.dgvDataset.AllowUserToOrderColumns = True
        Me.dgvDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDataset.Location = New System.Drawing.Point(0, 0)
        Me.dgvDataset.Name = "dgvDataset"
        Me.dgvDataset.ReadOnly = True
        Me.dgvDataset.Size = New System.Drawing.Size(449, 85)
        Me.dgvDataset.TabIndex = 2
        '
        'imlTab
        '
        Me.imlTab.ImageStream = CType(resources.GetObject("imlTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTab.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTab.Images.SetKeyName(0, "tabConvertRoute")
        Me.imlTab.Images.SetKeyName(1, "tabSettings")
        Me.imlTab.Images.SetKeyName(2, "tabOutput.png")
        Me.imlTab.Images.SetKeyName(3, "tlbElements")
        '
        'tbpSettings
        '
        Me.tbpSettings.Controls.Add(Me.spcSettings)
        Me.tbpSettings.ImageKey = "tabSettings"
        Me.tbpSettings.Location = New System.Drawing.Point(4, 23)
        Me.tbpSettings.Name = "tbpSettings"
        Me.tbpSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSettings.Size = New System.Drawing.Size(612, 268)
        Me.tbpSettings.TabIndex = 3
        Me.tbpSettings.Text = "Settings"
        Me.tbpSettings.UseVisualStyleBackColor = True
        '
        'spcSettings
        '
        Me.spcSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcSettings.Location = New System.Drawing.Point(3, 3)
        Me.spcSettings.Name = "spcSettings"
        '
        'spcSettings.Panel1
        '
        Me.spcSettings.Panel1.Controls.Add(Me.tvwSettings)
        '
        'spcSettings.Panel2
        '
        Me.spcSettings.Panel2.Controls.Add(Me.pnlSettingsDebug)
        Me.spcSettings.Panel2.Controls.Add(Me.pnlSettingsDefaults)
        Me.spcSettings.Panel2.Controls.Add(Me.pnlSettingsOffsets)
        Me.spcSettings.Size = New System.Drawing.Size(606, 262)
        Me.spcSettings.SplitterDistance = 167
        Me.spcSettings.TabIndex = 1
        '
        'tvwSettings
        '
        Me.tvwSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwSettings.FullRowSelect = True
        Me.tvwSettings.HideSelection = False
        Me.tvwSettings.Location = New System.Drawing.Point(0, 0)
        Me.tvwSettings.Name = "tvwSettings"
        TreeNode4.Name = "nodeDebug"
        TreeNode4.Text = "Debug"
        TreeNode5.Name = "nodeDefaults"
        TreeNode5.Text = "Defaults"
        TreeNode6.Name = "nodeOffset"
        TreeNode6.Text = "Offsets"
        Me.tvwSettings.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Me.tvwSettings.ShowLines = False
        Me.tvwSettings.ShowPlusMinus = False
        Me.tvwSettings.ShowRootLines = False
        Me.tvwSettings.Size = New System.Drawing.Size(167, 262)
        Me.tvwSettings.TabIndex = 0
        '
        'pnlSettingsDebug
        '
        Me.pnlSettingsDebug.Controls.Add(Me.grbDebug)
        Me.pnlSettingsDebug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettingsDebug.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsDebug.Name = "pnlSettingsDebug"
        Me.pnlSettingsDebug.Size = New System.Drawing.Size(435, 262)
        Me.pnlSettingsDebug.TabIndex = 4
        '
        'grbDebug
        '
        Me.grbDebug.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDebug.Controls.Add(Me.chkDebugShowWindow)
        Me.grbDebug.Location = New System.Drawing.Point(9, 7)
        Me.grbDebug.Name = "grbDebug"
        Me.grbDebug.Size = New System.Drawing.Size(415, 56)
        Me.grbDebug.TabIndex = 3
        Me.grbDebug.TabStop = False
        Me.grbDebug.Text = "Debug"
        '
        'chkDebugShowWindow
        '
        Me.chkDebugShowWindow.AutoSize = True
        Me.chkDebugShowWindow.Location = New System.Drawing.Point(17, 24)
        Me.chkDebugShowWindow.Name = "chkDebugShowWindow"
        Me.chkDebugShowWindow.Size = New System.Drawing.Size(130, 17)
        Me.chkDebugShowWindow.TabIndex = 2
        Me.chkDebugShowWindow.TabStop = False
        Me.chkDebugShowWindow.Text = "Show Debug Window"
        Me.chkDebugShowWindow.UseVisualStyleBackColor = True
        '
        'pnlSettingsDefaults
        '
        Me.pnlSettingsDefaults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSettingsDefaults.Controls.Add(Me.grbDefaultFileName)
        Me.pnlSettingsDefaults.Controls.Add(Me.grbDefaultDirectories)
        Me.pnlSettingsDefaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettingsDefaults.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsDefaults.Name = "pnlSettingsDefaults"
        Me.pnlSettingsDefaults.Size = New System.Drawing.Size(435, 262)
        Me.pnlSettingsDefaults.TabIndex = 2
        '
        'grbDefaultFileName
        '
        Me.grbDefaultFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDefaultFileName.Controls.Add(Me.chkGenerateFileName)
        Me.grbDefaultFileName.Location = New System.Drawing.Point(9, 7)
        Me.grbDefaultFileName.Name = "grbDefaultFileName"
        Me.grbDefaultFileName.Size = New System.Drawing.Size(415, 56)
        Me.grbDefaultFileName.TabIndex = 2
        Me.grbDefaultFileName.TabStop = False
        Me.grbDefaultFileName.Text = "Default File Name"
        '
        'chkGenerateFileName
        '
        Me.chkGenerateFileName.AutoSize = True
        Me.chkGenerateFileName.Location = New System.Drawing.Point(17, 24)
        Me.chkGenerateFileName.Name = "chkGenerateFileName"
        Me.chkGenerateFileName.Size = New System.Drawing.Size(115, 17)
        Me.chkGenerateFileName.TabIndex = 2
        Me.chkGenerateFileName.TabStop = False
        Me.chkGenerateFileName.Text = "Generate file name"
        Me.chkGenerateFileName.UseVisualStyleBackColor = True
        '
        'grbDefaultDirectories
        '
        Me.grbDefaultDirectories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDefaultDirectories.Controls.Add(Me.lblDefaultDirectoryMapEditor)
        Me.grbDefaultDirectories.Controls.Add(Me.txtDefaultDirectoryMapEditor)
        Me.grbDefaultDirectories.Controls.Add(Me.btnSetMapEditorDirectory)
        Me.grbDefaultDirectories.Controls.Add(Me.lblDefaultDirectoryCourse)
        Me.grbDefaultDirectories.Controls.Add(Me.txtDefaultDirectoryCourse)
        Me.grbDefaultDirectories.Controls.Add(Me.btnSetCourseDirectory)
        Me.grbDefaultDirectories.Location = New System.Drawing.Point(9, 73)
        Me.grbDefaultDirectories.Name = "grbDefaultDirectories"
        Me.grbDefaultDirectories.Size = New System.Drawing.Size(415, 99)
        Me.grbDefaultDirectories.TabIndex = 3
        Me.grbDefaultDirectories.TabStop = False
        Me.grbDefaultDirectories.Text = "Default Directories"
        '
        'lblDefaultDirectoryMapEditor
        '
        Me.lblDefaultDirectoryMapEditor.AutoSize = True
        Me.lblDefaultDirectoryMapEditor.Location = New System.Drawing.Point(14, 26)
        Me.lblDefaultDirectoryMapEditor.Name = "lblDefaultDirectoryMapEditor"
        Me.lblDefaultDirectoryMapEditor.Size = New System.Drawing.Size(61, 13)
        Me.lblDefaultDirectoryMapEditor.TabIndex = 7
        Me.lblDefaultDirectoryMapEditor.Text = "Map Editor:"
        '
        'txtDefaultDirectoryMapEditor
        '
        Me.txtDefaultDirectoryMapEditor.AllowDrop = True
        Me.txtDefaultDirectoryMapEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDefaultDirectoryMapEditor.BackColor = System.Drawing.SystemColors.Window
        Me.txtDefaultDirectoryMapEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDefaultDirectoryMapEditor.Location = New System.Drawing.Point(82, 23)
        Me.txtDefaultDirectoryMapEditor.Name = "txtDefaultDirectoryMapEditor"
        Me.txtDefaultDirectoryMapEditor.ReadOnly = True
        Me.txtDefaultDirectoryMapEditor.Size = New System.Drawing.Size(287, 20)
        Me.txtDefaultDirectoryMapEditor.TabIndex = 9
        Me.txtDefaultDirectoryMapEditor.TabStop = False
        '
        'btnSetMapEditorDirectory
        '
        Me.btnSetMapEditorDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetMapEditorDirectory.FlatAppearance.BorderSize = 0
        Me.btnSetMapEditorDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSetMapEditorDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetMapEditorDirectory.Image = CType(resources.GetObject("btnSetMapEditorDirectory.Image"), System.Drawing.Image)
        Me.btnSetMapEditorDirectory.Location = New System.Drawing.Point(380, 23)
        Me.btnSetMapEditorDirectory.Name = "btnSetMapEditorDirectory"
        Me.btnSetMapEditorDirectory.Size = New System.Drawing.Size(21, 21)
        Me.btnSetMapEditorDirectory.TabIndex = 3
        Me.btnSetMapEditorDirectory.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnSetMapEditorDirectory, "Set Map Editor Directory")
        Me.btnSetMapEditorDirectory.UseVisualStyleBackColor = False
        '
        'lblDefaultDirectoryCourse
        '
        Me.lblDefaultDirectoryCourse.AutoSize = True
        Me.lblDefaultDirectoryCourse.Location = New System.Drawing.Point(14, 66)
        Me.lblDefaultDirectoryCourse.Name = "lblDefaultDirectoryCourse"
        Me.lblDefaultDirectoryCourse.Size = New System.Drawing.Size(43, 13)
        Me.lblDefaultDirectoryCourse.TabIndex = 10
        Me.lblDefaultDirectoryCourse.Text = "Course:"
        '
        'txtDefaultDirectoryCourse
        '
        Me.txtDefaultDirectoryCourse.AllowDrop = True
        Me.txtDefaultDirectoryCourse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDefaultDirectoryCourse.BackColor = System.Drawing.SystemColors.Window
        Me.txtDefaultDirectoryCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDefaultDirectoryCourse.Location = New System.Drawing.Point(82, 63)
        Me.txtDefaultDirectoryCourse.Name = "txtDefaultDirectoryCourse"
        Me.txtDefaultDirectoryCourse.ReadOnly = True
        Me.txtDefaultDirectoryCourse.Size = New System.Drawing.Size(287, 20)
        Me.txtDefaultDirectoryCourse.TabIndex = 12
        Me.txtDefaultDirectoryCourse.TabStop = False
        '
        'btnSetCourseDirectory
        '
        Me.btnSetCourseDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetCourseDirectory.FlatAppearance.BorderSize = 0
        Me.btnSetCourseDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSetCourseDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetCourseDirectory.Image = CType(resources.GetObject("btnSetCourseDirectory.Image"), System.Drawing.Image)
        Me.btnSetCourseDirectory.Location = New System.Drawing.Point(380, 63)
        Me.btnSetCourseDirectory.Name = "btnSetCourseDirectory"
        Me.btnSetCourseDirectory.Size = New System.Drawing.Size(21, 21)
        Me.btnSetCourseDirectory.TabIndex = 3
        Me.btnSetCourseDirectory.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnSetCourseDirectory, "Set Course Directory")
        Me.btnSetCourseDirectory.UseVisualStyleBackColor = False
        '
        'pnlSettingsOffsets
        '
        Me.pnlSettingsOffsets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSettingsOffsets.Controls.Add(Me.grbOffsets)
        Me.pnlSettingsOffsets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettingsOffsets.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsOffsets.Name = "pnlSettingsOffsets"
        Me.pnlSettingsOffsets.Size = New System.Drawing.Size(435, 262)
        Me.pnlSettingsOffsets.TabIndex = 4
        '
        'grbOffsets
        '
        Me.grbOffsets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbOffsets.Controls.Add(Me.nudZOffset)
        Me.grbOffsets.Controls.Add(Me.nudYOffset)
        Me.grbOffsets.Controls.Add(Me.nudXOffset)
        Me.grbOffsets.Controls.Add(Me.lblZOffset)
        Me.grbOffsets.Controls.Add(Me.lblYOffset)
        Me.grbOffsets.Controls.Add(Me.lblXOffset)
        Me.grbOffsets.Controls.Add(Me.chkEnableOffsets)
        Me.grbOffsets.Location = New System.Drawing.Point(9, 7)
        Me.grbOffsets.Name = "grbOffsets"
        Me.grbOffsets.Size = New System.Drawing.Size(415, 89)
        Me.grbOffsets.TabIndex = 2
        Me.grbOffsets.TabStop = False
        Me.grbOffsets.Text = "Offsets"
        '
        'nudZOffset
        '
        Me.nudZOffset.DecimalPlaces = 3
        Me.nudZOffset.Enabled = False
        Me.nudZOffset.Location = New System.Drawing.Point(298, 52)
        Me.nudZOffset.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudZOffset.Name = "nudZOffset"
        Me.nudZOffset.Size = New System.Drawing.Size(70, 20)
        Me.nudZOffset.TabIndex = 5
        Me.nudZOffset.TabStop = False
        '
        'nudYOffset
        '
        Me.nudYOffset.DecimalPlaces = 3
        Me.nudYOffset.Enabled = False
        Me.nudYOffset.Location = New System.Drawing.Point(176, 52)
        Me.nudYOffset.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudYOffset.Name = "nudYOffset"
        Me.nudYOffset.Size = New System.Drawing.Size(70, 20)
        Me.nudYOffset.TabIndex = 4
        Me.nudYOffset.TabStop = False
        '
        'nudXOffset
        '
        Me.nudXOffset.DecimalPlaces = 3
        Me.nudXOffset.Enabled = False
        Me.nudXOffset.Location = New System.Drawing.Point(59, 52)
        Me.nudXOffset.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudXOffset.Name = "nudXOffset"
        Me.nudXOffset.Size = New System.Drawing.Size(70, 20)
        Me.nudXOffset.TabIndex = 3
        Me.nudXOffset.TabStop = False
        '
        'lblZOffset
        '
        Me.lblZOffset.AutoSize = True
        Me.lblZOffset.Location = New System.Drawing.Point(275, 54)
        Me.lblZOffset.Name = "lblZOffset"
        Me.lblZOffset.Size = New System.Drawing.Size(17, 13)
        Me.lblZOffset.TabIndex = 9
        Me.lblZOffset.Text = "Z:"
        '
        'lblYOffset
        '
        Me.lblYOffset.AutoSize = True
        Me.lblYOffset.Location = New System.Drawing.Point(153, 54)
        Me.lblYOffset.Name = "lblYOffset"
        Me.lblYOffset.Size = New System.Drawing.Size(17, 13)
        Me.lblYOffset.TabIndex = 7
        Me.lblYOffset.Text = "Y:"
        '
        'lblXOffset
        '
        Me.lblXOffset.AutoSize = True
        Me.lblXOffset.Location = New System.Drawing.Point(36, 54)
        Me.lblXOffset.Name = "lblXOffset"
        Me.lblXOffset.Size = New System.Drawing.Size(17, 13)
        Me.lblXOffset.TabIndex = 5
        Me.lblXOffset.Text = "X:"
        '
        'chkEnableOffsets
        '
        Me.chkEnableOffsets.AutoSize = True
        Me.chkEnableOffsets.Location = New System.Drawing.Point(17, 24)
        Me.chkEnableOffsets.Name = "chkEnableOffsets"
        Me.chkEnableOffsets.Size = New System.Drawing.Size(95, 17)
        Me.chkEnableOffsets.TabIndex = 2
        Me.chkEnableOffsets.TabStop = False
        Me.chkEnableOffsets.Text = "Enable Offsets"
        Me.chkEnableOffsets.UseVisualStyleBackColor = True
        '
        'stsStatus
        '
        Me.stsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssStatus})
        Me.stsStatus.Location = New System.Drawing.Point(0, 299)
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(624, 22)
        Me.stsStatus.TabIndex = 36
        Me.stsStatus.Text = "Ready"
        '
        'tssStatus
        '
        Me.tssStatus.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.tssStatus.Name = "tssStatus"
        Me.tssStatus.Size = New System.Drawing.Size(39, 17)
        Me.tssStatus.Text = "Ready"
        '
        'ToolTip
        '
        Me.ToolTip.BackColor = System.Drawing.SystemColors.Control
        Me.ToolTip.ShowAlways = True
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.ShowNewFolderButton = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 321)
        Me.Controls.Add(Me.tlsMain)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.stsStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(640, 360)
        Me.Name = "FormMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Grand Theft Bike V - Route Builder"
        Me.tlsMain.ResumeLayout(False)
        Me.tlsMain.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tbpConvertRoute.ResumeLayout(False)
        Me.spcConvertRoute.Panel1.ResumeLayout(False)
        Me.spcConvertRoute.Panel2.ResumeLayout(False)
        CType(Me.spcConvertRoute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcConvertRoute.ResumeLayout(False)
        Me.pnlConvertRoute.ResumeLayout(False)
        Me.grbCourse.ResumeLayout(False)
        Me.grbCourse.PerformLayout()
        Me.grbMapEditor.ResumeLayout(False)
        Me.grbMapEditor.PerformLayout()
        Me.tabDebugWindow.ResumeLayout(False)
        Me.tbpOutput.ResumeLayout(False)
        Me.pnlOutput.ResumeLayout(False)
        Me.tbpDataset.ResumeLayout(False)
        Me.pnlDataset.ResumeLayout(False)
        Me.spcDataset.Panel1.ResumeLayout(False)
        Me.spcDataset.Panel2.ResumeLayout(False)
        CType(Me.spcDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcDataset.ResumeLayout(False)
        CType(Me.dgvDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpSettings.ResumeLayout(False)
        Me.spcSettings.Panel1.ResumeLayout(False)
        Me.spcSettings.Panel2.ResumeLayout(False)
        CType(Me.spcSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcSettings.ResumeLayout(False)
        Me.pnlSettingsDebug.ResumeLayout(False)
        Me.grbDebug.ResumeLayout(False)
        Me.grbDebug.PerformLayout()
        Me.pnlSettingsDefaults.ResumeLayout(False)
        Me.grbDefaultFileName.ResumeLayout(False)
        Me.grbDefaultFileName.PerformLayout()
        Me.grbDefaultDirectories.ResumeLayout(False)
        Me.grbDefaultDirectories.PerformLayout()
        Me.pnlSettingsOffsets.ResumeLayout(False)
        Me.grbOffsets.ResumeLayout(False)
        Me.grbOffsets.PerformLayout()
        CType(Me.nudZOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsStatus.ResumeLayout(False)
        Me.stsStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents imlTab As ImageList
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tbpConvertRoute As TabPage
    Friend WithEvents tbpSettings As TabPage
    Friend WithEvents tlsMain As ToolStrip
    Friend WithEvents tlbStart As ToolStripButton
    Friend WithEvents tlbReset As ToolStripButton
    Friend WithEvents tlbSeparator As ToolStripSeparator
    Friend WithEvents tlbSendFeedback As ToolStripButton
    Friend WithEvents tlbHelp As ToolStripButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents stsStatus As StatusStrip
    Friend WithEvents tssStatus As ToolStripStatusLabel
    Friend WithEvents spcConvertRoute As SplitContainer
    Friend WithEvents tabDebugWindow As TabControl
    Friend WithEvents tbpDataset As TabPage
    Friend WithEvents tbpOutput As TabPage
    Friend WithEvents pnlConvertRoute As Panel
    Friend WithEvents grbCourse As GroupBox
    Friend WithEvents lblCourseFileName As Label
    Friend WithEvents txtCourseFileName As TextBox
    Friend WithEvents btnSaveCourseFile As Button
    Friend WithEvents grbMapEditor As GroupBox
    Friend WithEvents lblMapEditorFileName As Label
    Friend WithEvents txtMapEditorFileName As TextBox
    Friend WithEvents btnOpenMapEditorFile As Button
    Friend WithEvents pnlDataset As Panel
    Friend WithEvents spcDataset As SplitContainer
    Friend WithEvents tvwDataset As TreeView
    Friend WithEvents dgvDataset As DataGridView
    Friend WithEvents pnlOutput As Panel
    Friend WithEvents rtfOutput As RichTextBox
    Friend WithEvents pnlSettingsDefaults As Panel
    Friend WithEvents grbDefaultFileName As GroupBox
    Friend WithEvents chkGenerateFileName As CheckBox
    Friend WithEvents spcSettings As SplitContainer
    Friend WithEvents tvwSettings As TreeView
    Friend WithEvents grbDefaultDirectories As GroupBox
    Friend WithEvents lblDefaultDirectoryMapEditor As Label
    Friend WithEvents txtDefaultDirectoryMapEditor As TextBox
    Friend WithEvents btnSetMapEditorDirectory As Button
    Friend WithEvents lblDefaultDirectoryCourse As Label
    Friend WithEvents txtDefaultDirectoryCourse As TextBox
    Friend WithEvents btnSetCourseDirectory As Button
    Friend WithEvents pnlSettingsOffsets As Panel
    Friend WithEvents grbOffsets As GroupBox
    Friend WithEvents chkEnableOffsets As CheckBox
    Friend WithEvents lblXOffset As Label
    Friend WithEvents lblZOffset As Label
    Friend WithEvents lblYOffset As Label
    Friend WithEvents nudXOffset As NumericUpDown
    Friend WithEvents nudZOffset As NumericUpDown
    Friend WithEvents nudYOffset As NumericUpDown
    Friend WithEvents pnlSettingsDebug As Panel
    Friend WithEvents grbDebug As GroupBox
    Friend WithEvents chkDebugShowWindow As CheckBox
End Class
