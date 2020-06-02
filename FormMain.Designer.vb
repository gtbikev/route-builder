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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.lblMapEditor = New System.Windows.Forms.Label()
        Me.txtMapEditor = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.lblApplication = New System.Windows.Forms.Label()
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.imlTab = New System.Windows.Forms.ImageList(Me.components)
        Me.grbBody = New System.Windows.Forms.GroupBox()
        Me.pnlMain.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(526, 23)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(25, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(526, 63)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(25, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "..."
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Title = "Select Route"
        '
        'lblMapEditor
        '
        Me.lblMapEditor.AutoSize = True
        Me.lblMapEditor.Location = New System.Drawing.Point(14, 28)
        Me.lblMapEditor.Name = "lblMapEditor"
        Me.lblMapEditor.Size = New System.Drawing.Size(61, 13)
        Me.lblMapEditor.TabIndex = 4
        Me.lblMapEditor.Text = "Map Editor:"
        '
        'txtMapEditor
        '
        Me.txtMapEditor.AllowDrop = True
        Me.txtMapEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMapEditor.BackColor = System.Drawing.Color.White
        Me.txtMapEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapEditor.Location = New System.Drawing.Point(81, 25)
        Me.txtMapEditor.Name = "txtMapEditor"
        Me.txtMapEditor.ReadOnly = True
        Me.txtMapEditor.Size = New System.Drawing.Size(436, 20)
        Me.txtMapEditor.TabIndex = 5
        Me.txtMapEditor.TabStop = False
        Me.txtMapEditor.WordWrap = False
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(14, 68)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(43, 13)
        Me.lblCourse.TabIndex = 6
        Me.lblCourse.Text = "Course:"
        '
        'txtCourse
        '
        Me.txtCourse.AllowDrop = True
        Me.txtCourse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse.BackColor = System.Drawing.Color.White
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Location = New System.Drawing.Point(81, 65)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(436, 20)
        Me.txtCourse.TabIndex = 7
        Me.txtCourse.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.btnCreate)
        Me.pnlMain.Controls.Add(Me.btnClear)
        Me.pnlMain.Controls.Add(Me.lblStatus)
        Me.pnlMain.Controls.Add(Me.imgLogo)
        Me.pnlMain.Controls.Add(Me.lblApplication)
        Me.pnlMain.Controls.Add(Me.lblSoftware)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(588, 203)
        Me.pnlMain.TabIndex = 30
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(486, 167)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 28
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(386, 167)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(24, 167)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(342, 18)
        Me.lblStatus.TabIndex = 29
        Me.lblStatus.Text = "Ready"
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(27, 11)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(32, 32)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'lblApplication
        '
        Me.lblApplication.BackColor = System.Drawing.Color.Transparent
        Me.lblApplication.Location = New System.Drawing.Point(90, 28)
        Me.lblApplication.Name = "lblApplication"
        Me.lblApplication.Size = New System.Drawing.Size(200, 14)
        Me.lblApplication.TabIndex = 26
        Me.lblApplication.Text = "Route Builder"
        '
        'lblSoftware
        '
        Me.lblSoftware.BackColor = System.Drawing.Color.Transparent
        Me.lblSoftware.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoftware.Location = New System.Drawing.Point(90, 12)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(200, 14)
        Me.lblSoftware.TabIndex = 25
        Me.lblSoftware.Text = "Grand Theft Bike V"
        '
        'imlTab
        '
        Me.imlTab.ImageStream = CType(resources.GetObject("imlTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTab.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTab.Images.SetKeyName(0, "tab_deployment")
        Me.imlTab.Images.SetKeyName(1, "tab_package")
        Me.imlTab.Images.SetKeyName(2, "tab_deployment")
        Me.imlTab.Images.SetKeyName(3, "tab_archive")
        Me.imlTab.Images.SetKeyName(4, "tab_release_note")
        Me.imlTab.Images.SetKeyName(5, "tab_validate")
        '
        'grbBody
        '
        Me.grbBody.Controls.Add(Me.lblMapEditor)
        Me.grbBody.Controls.Add(Me.btnOpen)
        Me.grbBody.Controls.Add(Me.btnSave)
        Me.grbBody.Controls.Add(Me.txtMapEditor)
        Me.grbBody.Controls.Add(Me.lblCourse)
        Me.grbBody.Controls.Add(Me.txtCourse)
        Me.grbBody.Location = New System.Drawing.Point(10, 46)
        Me.grbBody.Name = "grbBody"
        Me.grbBody.Size = New System.Drawing.Size(566, 108)
        Me.grbBody.TabIndex = 32
        Me.grbBody.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 203)
        Me.Controls.Add(Me.grbBody)
        Me.Controls.Add(Me.pnlMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbBody.ResumeLayout(False)
        Me.grbBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents lblMapEditor As Label
    Friend WithEvents txtMapEditor As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblApplication As Label
    Friend WithEvents lblSoftware As Label
    Friend WithEvents imlTab As ImageList
    Friend WithEvents grbBody As GroupBox
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblStatus As Label
End Class
