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
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlsMain = New System.Windows.Forms.ToolStrip()
        Me.tlbStart = New System.Windows.Forms.ToolStripButton()
        Me.tlbReset = New System.Windows.Forms.ToolStripButton()
        Me.tlbSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbSendFeedback = New System.Windows.Forms.ToolStripButton()
        Me.tlbAbout = New System.Windows.Forms.ToolStripButton()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tbpConvertRoute = New System.Windows.Forms.TabPage()
        Me.grbMapEditor = New System.Windows.Forms.GroupBox()
        Me.lblMapEditorFileName = New System.Windows.Forms.Label()
        Me.txtMapEditorFileName = New System.Windows.Forms.TextBox()
        Me.btnOpenMapEditorFile = New System.Windows.Forms.Button()
        Me.grbCourse = New System.Windows.Forms.GroupBox()
        Me.rdbGenerateFileName = New System.Windows.Forms.RadioButton()
        Me.lblGenerateCourseFileName = New System.Windows.Forms.Label()
        Me.txtGenerateCourseFileName = New System.Windows.Forms.TextBox()
        Me.rdbSpecifyFileName = New System.Windows.Forms.RadioButton()
        Me.lblSpecifyCourseFileName = New System.Windows.Forms.Label()
        Me.txtSpecifyCourseFileName = New System.Windows.Forms.TextBox()
        Me.btnSaveCourseFile = New System.Windows.Forms.Button()
        Me.tbpSettings = New System.Windows.Forms.TabPage()
        Me.grbDefaultFileName = New System.Windows.Forms.GroupBox()
        Me.chkDefaultGenerateFileName = New System.Windows.Forms.CheckBox()
        Me.grbDefaultDirectories = New System.Windows.Forms.GroupBox()
        Me.lblDefaultDirectoryMapEditor = New System.Windows.Forms.Label()
        Me.txtDefaultDirectoryMapEditor = New System.Windows.Forms.TextBox()
        Me.btnSetMapEditorDirectory = New System.Windows.Forms.Button()
        Me.lblDefaultDirectoryCourse = New System.Windows.Forms.Label()
        Me.txtDefaultDirectoryCourse = New System.Windows.Forms.TextBox()
        Me.btnSetCourseDirectory = New System.Windows.Forms.Button()
        Me.imlTab = New System.Windows.Forms.ImageList(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.pnlMain.SuspendLayout()
        Me.tlsMain.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tbpConvertRoute.SuspendLayout()
        Me.grbMapEditor.SuspendLayout()
        Me.grbCourse.SuspendLayout()
        Me.tbpSettings.SuspendLayout()
        Me.grbDefaultFileName.SuspendLayout()
        Me.grbDefaultDirectories.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Title = "Select Route"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.tlsMain)
        Me.pnlMain.Controls.Add(Me.tabMain)
        Me.pnlMain.Controls.Add(Me.lblStatus)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(589, 296)
        Me.pnlMain.TabIndex = 30
        '
        'tlsMain
        '
        Me.tlsMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlsMain.BackColor = System.Drawing.SystemColors.Control
        Me.tlsMain.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsMain.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tlsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbStart, Me.tlbReset, Me.tlbSeparator, Me.tlbSendFeedback, Me.tlbAbout})
        Me.tlsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tlsMain.Location = New System.Drawing.Point(477, 8)
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
        'tlbAbout
        '
        Me.tlbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbAbout.Image = CType(resources.GetObject("tlbAbout.Image"), System.Drawing.Image)
        Me.tlbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbAbout.Name = "tlbAbout"
        Me.tlbAbout.Size = New System.Drawing.Size(23, 22)
        Me.tlbAbout.Text = "About (F1)"
        Me.tlbAbout.ToolTipText = "About (F1)"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tbpConvertRoute)
        Me.tabMain.Controls.Add(Me.tbpSettings)
        Me.tabMain.ImageList = Me.imlTab
        Me.tabMain.Location = New System.Drawing.Point(10, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(570, 250)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabStop = False
        '
        'tbpConvertRoute
        '
        Me.tbpConvertRoute.Controls.Add(Me.grbMapEditor)
        Me.tbpConvertRoute.Controls.Add(Me.grbCourse)
        Me.tbpConvertRoute.ImageKey = "tabConvertRoute"
        Me.tbpConvertRoute.Location = New System.Drawing.Point(4, 23)
        Me.tbpConvertRoute.Name = "tbpConvertRoute"
        Me.tbpConvertRoute.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConvertRoute.Size = New System.Drawing.Size(562, 223)
        Me.tbpConvertRoute.TabIndex = 1
        Me.tbpConvertRoute.Text = "Convert Route"
        Me.tbpConvertRoute.UseVisualStyleBackColor = True
        '
        'grbMapEditor
        '
        Me.grbMapEditor.Controls.Add(Me.lblMapEditorFileName)
        Me.grbMapEditor.Controls.Add(Me.txtMapEditorFileName)
        Me.grbMapEditor.Controls.Add(Me.btnOpenMapEditorFile)
        Me.grbMapEditor.Location = New System.Drawing.Point(9, 7)
        Me.grbMapEditor.Name = "grbMapEditor"
        Me.grbMapEditor.Size = New System.Drawing.Size(544, 56)
        Me.grbMapEditor.TabIndex = 1
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
        Me.txtMapEditorFileName.Location = New System.Drawing.Point(98, 23)
        Me.txtMapEditorFileName.Name = "txtMapEditorFileName"
        Me.txtMapEditorFileName.ReadOnly = True
        Me.txtMapEditorFileName.Size = New System.Drawing.Size(400, 20)
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
        Me.btnOpenMapEditorFile.Location = New System.Drawing.Point(506, 23)
        Me.btnOpenMapEditorFile.Name = "btnOpenMapEditorFile"
        Me.btnOpenMapEditorFile.Size = New System.Drawing.Size(21, 21)
        Me.btnOpenMapEditorFile.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.btnOpenMapEditorFile, "Open Map Editor File (Ctrl+O)")
        Me.btnOpenMapEditorFile.UseVisualStyleBackColor = False
        '
        'grbCourse
        '
        Me.grbCourse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbCourse.Controls.Add(Me.rdbGenerateFileName)
        Me.grbCourse.Controls.Add(Me.lblGenerateCourseFileName)
        Me.grbCourse.Controls.Add(Me.txtGenerateCourseFileName)
        Me.grbCourse.Controls.Add(Me.rdbSpecifyFileName)
        Me.grbCourse.Controls.Add(Me.lblSpecifyCourseFileName)
        Me.grbCourse.Controls.Add(Me.txtSpecifyCourseFileName)
        Me.grbCourse.Controls.Add(Me.btnSaveCourseFile)
        Me.grbCourse.Location = New System.Drawing.Point(9, 73)
        Me.grbCourse.Name = "grbCourse"
        Me.grbCourse.Size = New System.Drawing.Size(544, 142)
        Me.grbCourse.TabIndex = 0
        Me.grbCourse.TabStop = False
        Me.grbCourse.Text = "Course"
        '
        'rdbGenerateFileName
        '
        Me.rdbGenerateFileName.AutoSize = True
        Me.rdbGenerateFileName.Checked = True
        Me.rdbGenerateFileName.Location = New System.Drawing.Point(17, 23)
        Me.rdbGenerateFileName.Name = "rdbGenerateFileName"
        Me.rdbGenerateFileName.Size = New System.Drawing.Size(114, 17)
        Me.rdbGenerateFileName.TabIndex = 1
        Me.rdbGenerateFileName.TabStop = True
        Me.rdbGenerateFileName.Text = "Generate file name"
        Me.rdbGenerateFileName.UseVisualStyleBackColor = True
        '
        'lblGenerateCourseFileName
        '
        Me.lblGenerateCourseFileName.AutoSize = True
        Me.lblGenerateCourseFileName.Location = New System.Drawing.Point(38, 47)
        Me.lblGenerateCourseFileName.Name = "lblGenerateCourseFileName"
        Me.lblGenerateCourseFileName.Size = New System.Drawing.Size(57, 13)
        Me.lblGenerateCourseFileName.TabIndex = 37
        Me.lblGenerateCourseFileName.Text = "File Name:"
        '
        'txtGenerateCourseFileName
        '
        Me.txtGenerateCourseFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGenerateCourseFileName.BackColor = System.Drawing.SystemColors.Window
        Me.txtGenerateCourseFileName.Location = New System.Drawing.Point(98, 44)
        Me.txtGenerateCourseFileName.Name = "txtGenerateCourseFileName"
        Me.txtGenerateCourseFileName.ReadOnly = True
        Me.txtGenerateCourseFileName.Size = New System.Drawing.Size(400, 20)
        Me.txtGenerateCourseFileName.TabIndex = 38
        Me.txtGenerateCourseFileName.TabStop = False
        '
        'rdbSpecifyFileName
        '
        Me.rdbSpecifyFileName.AutoSize = True
        Me.rdbSpecifyFileName.Location = New System.Drawing.Point(17, 82)
        Me.rdbSpecifyFileName.Name = "rdbSpecifyFileName"
        Me.rdbSpecifyFileName.Size = New System.Drawing.Size(105, 17)
        Me.rdbSpecifyFileName.TabIndex = 2
        Me.rdbSpecifyFileName.Text = "Specify file name"
        Me.rdbSpecifyFileName.UseVisualStyleBackColor = True
        '
        'lblSpecifyCourseFileName
        '
        Me.lblSpecifyCourseFileName.AutoSize = True
        Me.lblSpecifyCourseFileName.Location = New System.Drawing.Point(35, 109)
        Me.lblSpecifyCourseFileName.Name = "lblSpecifyCourseFileName"
        Me.lblSpecifyCourseFileName.Size = New System.Drawing.Size(57, 13)
        Me.lblSpecifyCourseFileName.TabIndex = 7
        Me.lblSpecifyCourseFileName.Text = "File Name:"
        '
        'txtSpecifyCourseFileName
        '
        Me.txtSpecifyCourseFileName.AllowDrop = True
        Me.txtSpecifyCourseFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSpecifyCourseFileName.BackColor = System.Drawing.SystemColors.Control
        Me.txtSpecifyCourseFileName.Location = New System.Drawing.Point(98, 106)
        Me.txtSpecifyCourseFileName.Name = "txtSpecifyCourseFileName"
        Me.txtSpecifyCourseFileName.ReadOnly = True
        Me.txtSpecifyCourseFileName.Size = New System.Drawing.Size(400, 20)
        Me.txtSpecifyCourseFileName.TabIndex = 5
        Me.txtSpecifyCourseFileName.TabStop = False
        '
        'btnSaveCourseFile
        '
        Me.btnSaveCourseFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveCourseFile.FlatAppearance.BorderSize = 0
        Me.btnSaveCourseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSaveCourseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCourseFile.Image = CType(resources.GetObject("btnSaveCourseFile.Image"), System.Drawing.Image)
        Me.btnSaveCourseFile.Location = New System.Drawing.Point(506, 106)
        Me.btnSaveCourseFile.Name = "btnSaveCourseFile"
        Me.btnSaveCourseFile.Size = New System.Drawing.Size(21, 21)
        Me.btnSaveCourseFile.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.btnSaveCourseFile, "Save Course File (Ctrl+S)")
        Me.btnSaveCourseFile.UseVisualStyleBackColor = True
        '
        'tbpSettings
        '
        Me.tbpSettings.Controls.Add(Me.grbDefaultFileName)
        Me.tbpSettings.Controls.Add(Me.grbDefaultDirectories)
        Me.tbpSettings.ImageKey = "tabSettings"
        Me.tbpSettings.Location = New System.Drawing.Point(4, 23)
        Me.tbpSettings.Name = "tbpSettings"
        Me.tbpSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSettings.Size = New System.Drawing.Size(562, 223)
        Me.tbpSettings.TabIndex = 3
        Me.tbpSettings.Text = "Settings"
        Me.tbpSettings.UseVisualStyleBackColor = True
        '
        'grbDefaultFileName
        '
        Me.grbDefaultFileName.Controls.Add(Me.chkDefaultGenerateFileName)
        Me.grbDefaultFileName.Location = New System.Drawing.Point(9, 7)
        Me.grbDefaultFileName.Name = "grbDefaultFileName"
        Me.grbDefaultFileName.Size = New System.Drawing.Size(544, 56)
        Me.grbDefaultFileName.TabIndex = 1
        Me.grbDefaultFileName.TabStop = False
        Me.grbDefaultFileName.Text = "Default File Name"
        '
        'chkDefaultGenerateFileName
        '
        Me.chkDefaultGenerateFileName.AutoSize = True
        Me.chkDefaultGenerateFileName.Location = New System.Drawing.Point(17, 24)
        Me.chkDefaultGenerateFileName.Name = "chkDefaultGenerateFileName"
        Me.chkDefaultGenerateFileName.Size = New System.Drawing.Size(115, 17)
        Me.chkDefaultGenerateFileName.TabIndex = 4
        Me.chkDefaultGenerateFileName.Text = "Generate file name"
        Me.chkDefaultGenerateFileName.UseVisualStyleBackColor = True
        '
        'grbDefaultDirectories
        '
        Me.grbDefaultDirectories.Controls.Add(Me.lblDefaultDirectoryMapEditor)
        Me.grbDefaultDirectories.Controls.Add(Me.txtDefaultDirectoryMapEditor)
        Me.grbDefaultDirectories.Controls.Add(Me.btnSetMapEditorDirectory)
        Me.grbDefaultDirectories.Controls.Add(Me.lblDefaultDirectoryCourse)
        Me.grbDefaultDirectories.Controls.Add(Me.txtDefaultDirectoryCourse)
        Me.grbDefaultDirectories.Controls.Add(Me.btnSetCourseDirectory)
        Me.grbDefaultDirectories.Location = New System.Drawing.Point(9, 73)
        Me.grbDefaultDirectories.Name = "grbDefaultDirectories"
        Me.grbDefaultDirectories.Size = New System.Drawing.Size(544, 99)
        Me.grbDefaultDirectories.TabIndex = 0
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
        Me.txtDefaultDirectoryMapEditor.Location = New System.Drawing.Point(98, 23)
        Me.txtDefaultDirectoryMapEditor.Name = "txtDefaultDirectoryMapEditor"
        Me.txtDefaultDirectoryMapEditor.ReadOnly = True
        Me.txtDefaultDirectoryMapEditor.Size = New System.Drawing.Size(400, 20)
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
        Me.btnSetMapEditorDirectory.Location = New System.Drawing.Point(506, 23)
        Me.btnSetMapEditorDirectory.Name = "btnSetMapEditorDirectory"
        Me.btnSetMapEditorDirectory.Size = New System.Drawing.Size(21, 21)
        Me.btnSetMapEditorDirectory.TabIndex = 5
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
        Me.txtDefaultDirectoryCourse.Location = New System.Drawing.Point(98, 63)
        Me.txtDefaultDirectoryCourse.Name = "txtDefaultDirectoryCourse"
        Me.txtDefaultDirectoryCourse.ReadOnly = True
        Me.txtDefaultDirectoryCourse.Size = New System.Drawing.Size(400, 20)
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
        Me.btnSetCourseDirectory.Location = New System.Drawing.Point(506, 63)
        Me.btnSetCourseDirectory.Name = "btnSetCourseDirectory"
        Me.btnSetCourseDirectory.Size = New System.Drawing.Size(21, 21)
        Me.btnSetCourseDirectory.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.btnSetCourseDirectory, "Set Course Directory")
        Me.btnSetCourseDirectory.UseVisualStyleBackColor = False
        '
        'imlTab
        '
        Me.imlTab.ImageStream = CType(resources.GetObject("imlTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTab.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTab.Images.SetKeyName(0, "tabConvertRoute")
        Me.imlTab.Images.SetKeyName(1, "tabSettings")
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Location = New System.Drawing.Point(12, 270)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(561, 13)
        Me.lblStatus.TabIndex = 29
        Me.lblStatus.Text = "Ready"
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
        Me.ClientSize = New System.Drawing.Size(589, 296)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Grand Theft Bike V - Route Builder"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.tlsMain.ResumeLayout(False)
        Me.tlsMain.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tbpConvertRoute.ResumeLayout(False)
        Me.grbMapEditor.ResumeLayout(False)
        Me.grbMapEditor.PerformLayout()
        Me.grbCourse.ResumeLayout(False)
        Me.grbCourse.PerformLayout()
        Me.tbpSettings.ResumeLayout(False)
        Me.grbDefaultFileName.ResumeLayout(False)
        Me.grbDefaultFileName.PerformLayout()
        Me.grbDefaultDirectories.ResumeLayout(False)
        Me.grbDefaultDirectories.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents imlTab As ImageList
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tbpConvertRoute As TabPage
    Friend WithEvents grbCourse As GroupBox
    Friend WithEvents rdbSpecifyFileName As RadioButton
    Friend WithEvents lblSpecifyCourseFileName As Label
    Friend WithEvents txtSpecifyCourseFileName As TextBox
    Friend WithEvents btnSaveCourseFile As Button
    Friend WithEvents tbpSettings As TabPage
    Friend WithEvents grbDefaultDirectories As GroupBox
    Friend WithEvents lblDefaultDirectoryMapEditor As Label
    Friend WithEvents grbMapEditor As GroupBox
    Friend WithEvents lblMapEditorFileName As Label
    Friend WithEvents txtMapEditorFileName As TextBox
    Friend WithEvents btnOpenMapEditorFile As Button
    Friend WithEvents tlsMain As ToolStrip
    Friend WithEvents tlbStart As ToolStripButton
    Friend WithEvents tlbReset As ToolStripButton
    Friend WithEvents tlbSeparator As ToolStripSeparator
    Friend WithEvents tlbSendFeedback As ToolStripButton
    Friend WithEvents tlbAbout As ToolStripButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents txtDefaultDirectoryMapEditor As TextBox
    Friend WithEvents btnSetMapEditorDirectory As Button
    Friend WithEvents txtDefaultDirectoryCourse As TextBox
    Friend WithEvents btnSetCourseDirectory As Button
    Friend WithEvents lblDefaultDirectoryCourse As Label
    Friend WithEvents txtGenerateCourseFileName As TextBox
    Friend WithEvents lblGenerateCourseFileName As Label
    Friend WithEvents rdbGenerateFileName As RadioButton
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents grbDefaultFileName As GroupBox
    Friend WithEvents chkDefaultGenerateFileName As CheckBox
End Class
