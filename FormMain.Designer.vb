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
        Me.tlsToolbarMain = New System.Windows.Forms.ToolStrip()
        Me.tlbStart = New System.Windows.Forms.ToolStripButton()
        Me.tlbClearAll = New System.Windows.Forms.ToolStripButton()
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
        Me.rdbSpecifyFileName = New System.Windows.Forms.RadioButton()
        Me.lblSpecifyCourseFileName = New System.Windows.Forms.Label()
        Me.txtSpecifyCourseFileName = New System.Windows.Forms.TextBox()
        Me.btnSaveCourseFile = New System.Windows.Forms.Button()
        Me.tbpSettings = New System.Windows.Forms.TabPage()
        Me.grbDefaultDirectories = New System.Windows.Forms.GroupBox()
        Me.txtDirectoryDefaultCourse = New System.Windows.Forms.TextBox()
        Me.btnOpenCourseDirectory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDirectoryDefaultMapEditor = New System.Windows.Forms.TextBox()
        Me.btnOpenMapEditorDirectory = New System.Windows.Forms.Button()
        Me.lblDirectoryDefaultMapEditor = New System.Windows.Forms.Label()
        Me.imlTab = New System.Windows.Forms.ImageList(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtGenerateCourseFileName = New System.Windows.Forms.TextBox()
        Me.lblGenerateCourseFileName = New System.Windows.Forms.Label()
        Me.rdbGenerateFileName = New System.Windows.Forms.RadioButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.pnlMain.SuspendLayout()
        Me.tlsToolbarMain.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tbpConvertRoute.SuspendLayout()
        Me.grbMapEditor.SuspendLayout()
        Me.grbCourse.SuspendLayout()
        Me.tbpSettings.SuspendLayout()
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
        Me.pnlMain.Controls.Add(Me.tlsToolbarMain)
        Me.pnlMain.Controls.Add(Me.tabMain)
        Me.pnlMain.Controls.Add(Me.lblStatus)
        Me.pnlMain.Controls.Add(Me.txtGenerateCourseFileName)
        Me.pnlMain.Controls.Add(Me.lblGenerateCourseFileName)
        Me.pnlMain.Controls.Add(Me.rdbGenerateFileName)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(589, 232)
        Me.pnlMain.TabIndex = 30
        '
        'tlsToolbarMain
        '
        Me.tlsToolbarMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlsToolbarMain.BackColor = System.Drawing.SystemColors.Control
        Me.tlsToolbarMain.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsToolbarMain.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tlsToolbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsToolbarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbStart, Me.tlbClearAll, Me.tlbSeparator, Me.tlbSendFeedback, Me.tlbAbout})
        Me.tlsToolbarMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tlsToolbarMain.Location = New System.Drawing.Point(477, 8)
        Me.tlsToolbarMain.Name = "tlsToolbarMain"
        Me.tlsToolbarMain.Padding = New System.Windows.Forms.Padding(0)
        Me.tlsToolbarMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlsToolbarMain.Size = New System.Drawing.Size(100, 25)
        Me.tlsToolbarMain.TabIndex = 35
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
        'tlbClearAll
        '
        Me.tlbClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbClearAll.Image = CType(resources.GetObject("tlbClearAll.Image"), System.Drawing.Image)
        Me.tlbClearAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbClearAll.Name = "tlbClearAll"
        Me.tlbClearAll.Size = New System.Drawing.Size(23, 22)
        Me.tlbClearAll.Text = "Clear All (Del)"
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
        Me.tabMain.Size = New System.Drawing.Size(570, 186)
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
        Me.tbpConvertRoute.Size = New System.Drawing.Size(562, 159)
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
        Me.txtMapEditorFileName.TabIndex = 3
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
        Me.grbCourse.Controls.Add(Me.rdbSpecifyFileName)
        Me.grbCourse.Controls.Add(Me.lblSpecifyCourseFileName)
        Me.grbCourse.Controls.Add(Me.txtSpecifyCourseFileName)
        Me.grbCourse.Controls.Add(Me.btnSaveCourseFile)
        Me.grbCourse.Location = New System.Drawing.Point(9, 73)
        Me.grbCourse.Name = "grbCourse"
        Me.grbCourse.Size = New System.Drawing.Size(544, 78)
        Me.grbCourse.TabIndex = 0
        Me.grbCourse.TabStop = False
        Me.grbCourse.Text = "Course"
        '
        'rdbSpecifyFileName
        '
        Me.rdbSpecifyFileName.AutoSize = True
        Me.rdbSpecifyFileName.Checked = True
        Me.rdbSpecifyFileName.Location = New System.Drawing.Point(17, 23)
        Me.rdbSpecifyFileName.Name = "rdbSpecifyFileName"
        Me.rdbSpecifyFileName.Size = New System.Drawing.Size(105, 17)
        Me.rdbSpecifyFileName.TabIndex = 9
        Me.rdbSpecifyFileName.TabStop = True
        Me.rdbSpecifyFileName.Text = "Specify file name"
        Me.rdbSpecifyFileName.UseVisualStyleBackColor = True
        '
        'lblSpecifyCourseFileName
        '
        Me.lblSpecifyCourseFileName.AutoSize = True
        Me.lblSpecifyCourseFileName.Location = New System.Drawing.Point(38, 47)
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
        Me.txtSpecifyCourseFileName.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpecifyCourseFileName.Location = New System.Drawing.Point(98, 44)
        Me.txtSpecifyCourseFileName.Name = "txtSpecifyCourseFileName"
        Me.txtSpecifyCourseFileName.ReadOnly = True
        Me.txtSpecifyCourseFileName.Size = New System.Drawing.Size(400, 20)
        Me.txtSpecifyCourseFileName.TabIndex = 5
        '
        'btnSaveCourseFile
        '
        Me.btnSaveCourseFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveCourseFile.FlatAppearance.BorderSize = 0
        Me.btnSaveCourseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSaveCourseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCourseFile.Image = CType(resources.GetObject("btnSaveCourseFile.Image"), System.Drawing.Image)
        Me.btnSaveCourseFile.Location = New System.Drawing.Point(506, 44)
        Me.btnSaveCourseFile.Name = "btnSaveCourseFile"
        Me.btnSaveCourseFile.Size = New System.Drawing.Size(21, 21)
        Me.btnSaveCourseFile.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.btnSaveCourseFile, "Save Course File (Ctrl+S)")
        Me.btnSaveCourseFile.UseVisualStyleBackColor = True
        '
        'tbpSettings
        '
        Me.tbpSettings.Controls.Add(Me.grbDefaultDirectories)
        Me.tbpSettings.ImageKey = "tabSettings"
        Me.tbpSettings.Location = New System.Drawing.Point(4, 23)
        Me.tbpSettings.Name = "tbpSettings"
        Me.tbpSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSettings.Size = New System.Drawing.Size(562, 159)
        Me.tbpSettings.TabIndex = 3
        Me.tbpSettings.Text = "Settings"
        Me.tbpSettings.UseVisualStyleBackColor = True
        '
        'grbDefaultDirectories
        '
        Me.grbDefaultDirectories.Controls.Add(Me.txtDirectoryDefaultCourse)
        Me.grbDefaultDirectories.Controls.Add(Me.btnOpenCourseDirectory)
        Me.grbDefaultDirectories.Controls.Add(Me.Label1)
        Me.grbDefaultDirectories.Controls.Add(Me.txtDirectoryDefaultMapEditor)
        Me.grbDefaultDirectories.Controls.Add(Me.btnOpenMapEditorDirectory)
        Me.grbDefaultDirectories.Controls.Add(Me.lblDirectoryDefaultMapEditor)
        Me.grbDefaultDirectories.Location = New System.Drawing.Point(9, 7)
        Me.grbDefaultDirectories.Name = "grbDefaultDirectories"
        Me.grbDefaultDirectories.Size = New System.Drawing.Size(544, 99)
        Me.grbDefaultDirectories.TabIndex = 0
        Me.grbDefaultDirectories.TabStop = False
        Me.grbDefaultDirectories.Text = "Default Directories"
        '
        'txtDirectoryDefaultCourse
        '
        Me.txtDirectoryDefaultCourse.AllowDrop = True
        Me.txtDirectoryDefaultCourse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirectoryDefaultCourse.BackColor = System.Drawing.SystemColors.Window
        Me.txtDirectoryDefaultCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDirectoryDefaultCourse.Location = New System.Drawing.Point(98, 63)
        Me.txtDirectoryDefaultCourse.Name = "txtDirectoryDefaultCourse"
        Me.txtDirectoryDefaultCourse.ReadOnly = True
        Me.txtDirectoryDefaultCourse.Size = New System.Drawing.Size(400, 20)
        Me.txtDirectoryDefaultCourse.TabIndex = 12
        '
        'btnOpenCourseDirectory
        '
        Me.btnOpenCourseDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenCourseDirectory.FlatAppearance.BorderSize = 0
        Me.btnOpenCourseDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnOpenCourseDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenCourseDirectory.Image = CType(resources.GetObject("btnOpenCourseDirectory.Image"), System.Drawing.Image)
        Me.btnOpenCourseDirectory.Location = New System.Drawing.Point(506, 63)
        Me.btnOpenCourseDirectory.Name = "btnOpenCourseDirectory"
        Me.btnOpenCourseDirectory.Size = New System.Drawing.Size(21, 21)
        Me.btnOpenCourseDirectory.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.btnOpenCourseDirectory, "Open Course Directory")
        Me.btnOpenCourseDirectory.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Course:"
        '
        'txtDirectoryDefaultMapEditor
        '
        Me.txtDirectoryDefaultMapEditor.AllowDrop = True
        Me.txtDirectoryDefaultMapEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirectoryDefaultMapEditor.BackColor = System.Drawing.SystemColors.Window
        Me.txtDirectoryDefaultMapEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDirectoryDefaultMapEditor.Location = New System.Drawing.Point(98, 23)
        Me.txtDirectoryDefaultMapEditor.Name = "txtDirectoryDefaultMapEditor"
        Me.txtDirectoryDefaultMapEditor.ReadOnly = True
        Me.txtDirectoryDefaultMapEditor.Size = New System.Drawing.Size(400, 20)
        Me.txtDirectoryDefaultMapEditor.TabIndex = 9
        '
        'btnOpenMapEditorDirectory
        '
        Me.btnOpenMapEditorDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenMapEditorDirectory.FlatAppearance.BorderSize = 0
        Me.btnOpenMapEditorDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnOpenMapEditorDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenMapEditorDirectory.Image = CType(resources.GetObject("btnOpenMapEditorDirectory.Image"), System.Drawing.Image)
        Me.btnOpenMapEditorDirectory.Location = New System.Drawing.Point(506, 23)
        Me.btnOpenMapEditorDirectory.Name = "btnOpenMapEditorDirectory"
        Me.btnOpenMapEditorDirectory.Size = New System.Drawing.Size(21, 21)
        Me.btnOpenMapEditorDirectory.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.btnOpenMapEditorDirectory, "Open Map Editor Directory")
        Me.btnOpenMapEditorDirectory.UseVisualStyleBackColor = False
        '
        'lblDirectoryDefaultMapEditor
        '
        Me.lblDirectoryDefaultMapEditor.AutoSize = True
        Me.lblDirectoryDefaultMapEditor.Location = New System.Drawing.Point(14, 26)
        Me.lblDirectoryDefaultMapEditor.Name = "lblDirectoryDefaultMapEditor"
        Me.lblDirectoryDefaultMapEditor.Size = New System.Drawing.Size(61, 13)
        Me.lblDirectoryDefaultMapEditor.TabIndex = 7
        Me.lblDirectoryDefaultMapEditor.Text = "Map Editor:"
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
        Me.lblStatus.Location = New System.Drawing.Point(12, 206)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(561, 13)
        Me.lblStatus.TabIndex = 29
        Me.lblStatus.Text = "Ready"
        '
        'txtGenerateCourseFileName
        '
        Me.txtGenerateCourseFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGenerateCourseFileName.BackColor = System.Drawing.SystemColors.Control
        Me.txtGenerateCourseFileName.Enabled = False
        Me.txtGenerateCourseFileName.Location = New System.Drawing.Point(135, 149)
        Me.txtGenerateCourseFileName.Name = "txtGenerateCourseFileName"
        Me.txtGenerateCourseFileName.ReadOnly = True
        Me.txtGenerateCourseFileName.Size = New System.Drawing.Size(400, 20)
        Me.txtGenerateCourseFileName.TabIndex = 38
        Me.txtGenerateCourseFileName.Visible = False
        '
        'lblGenerateCourseFileName
        '
        Me.lblGenerateCourseFileName.AutoSize = True
        Me.lblGenerateCourseFileName.Location = New System.Drawing.Point(75, 152)
        Me.lblGenerateCourseFileName.Name = "lblGenerateCourseFileName"
        Me.lblGenerateCourseFileName.Size = New System.Drawing.Size(57, 13)
        Me.lblGenerateCourseFileName.TabIndex = 37
        Me.lblGenerateCourseFileName.Text = "File Name:"
        Me.lblGenerateCourseFileName.Visible = False
        '
        'rdbGenerateFileName
        '
        Me.rdbGenerateFileName.AutoSize = True
        Me.rdbGenerateFileName.Checked = True
        Me.rdbGenerateFileName.Location = New System.Drawing.Point(54, 128)
        Me.rdbGenerateFileName.Name = "rdbGenerateFileName"
        Me.rdbGenerateFileName.Size = New System.Drawing.Size(114, 17)
        Me.rdbGenerateFileName.TabIndex = 36
        Me.rdbGenerateFileName.TabStop = True
        Me.rdbGenerateFileName.Text = "Generate file name"
        Me.rdbGenerateFileName.UseVisualStyleBackColor = True
        Me.rdbGenerateFileName.Visible = False
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
        Me.ClientSize = New System.Drawing.Size(589, 232)
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
        Me.tlsToolbarMain.ResumeLayout(False)
        Me.tlsToolbarMain.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tbpConvertRoute.ResumeLayout(False)
        Me.grbMapEditor.ResumeLayout(False)
        Me.grbMapEditor.PerformLayout()
        Me.grbCourse.ResumeLayout(False)
        Me.grbCourse.PerformLayout()
        Me.tbpSettings.ResumeLayout(False)
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
    Friend WithEvents lblDirectoryDefaultMapEditor As Label
    Friend WithEvents grbMapEditor As GroupBox
    Friend WithEvents lblMapEditorFileName As Label
    Friend WithEvents txtMapEditorFileName As TextBox
    Friend WithEvents btnOpenMapEditorFile As Button
    Friend WithEvents tlsToolbarMain As ToolStrip
    Friend WithEvents tlbStart As ToolStripButton
    Friend WithEvents tlbClearAll As ToolStripButton
    Friend WithEvents tlbSeparator As ToolStripSeparator
    Friend WithEvents tlbSendFeedback As ToolStripButton
    Friend WithEvents tlbAbout As ToolStripButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents txtDirectoryDefaultMapEditor As TextBox
    Friend WithEvents btnOpenMapEditorDirectory As Button
    Friend WithEvents txtDirectoryDefaultCourse As TextBox
    Friend WithEvents btnOpenCourseDirectory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGenerateCourseFileName As TextBox
    Friend WithEvents lblGenerateCourseFileName As Label
    Friend WithEvents rdbGenerateFileName As RadioButton
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
End Class
