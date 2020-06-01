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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.lblMapEditor = New System.Windows.Forms.Label()
        Me.txtMapEditor = New System.Windows.Forms.TextBox()
        Me.lblGtBikeVCourse = New System.Windows.Forms.Label()
        Me.txtGtBikeVCourse = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(572, 18)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(25, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(572, 60)
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
        Me.lblMapEditor.Location = New System.Drawing.Point(10, 23)
        Me.lblMapEditor.Name = "lblMapEditor"
        Me.lblMapEditor.Size = New System.Drawing.Size(61, 13)
        Me.lblMapEditor.TabIndex = 4
        Me.lblMapEditor.Text = "Map Editor:"
        '
        'txtMapEditor
        '
        Me.txtMapEditor.BackColor = System.Drawing.Color.White
        Me.txtMapEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapEditor.Location = New System.Drawing.Point(115, 20)
        Me.txtMapEditor.Name = "txtMapEditor"
        Me.txtMapEditor.ReadOnly = True
        Me.txtMapEditor.Size = New System.Drawing.Size(440, 20)
        Me.txtMapEditor.TabIndex = 5
        Me.txtMapEditor.TabStop = False
        Me.txtMapEditor.WordWrap = False
        '
        'lblGtBikeVCourse
        '
        Me.lblGtBikeVCourse.AutoSize = True
        Me.lblGtBikeVCourse.Location = New System.Drawing.Point(10, 63)
        Me.lblGtBikeVCourse.Name = "lblGtBikeVCourse"
        Me.lblGtBikeVCourse.Size = New System.Drawing.Size(95, 13)
        Me.lblGtBikeVCourse.TabIndex = 6
        Me.lblGtBikeVCourse.Text = "GT Bike V Course:"
        '
        'txtGtBikeVCourse
        '
        Me.txtGtBikeVCourse.BackColor = System.Drawing.Color.White
        Me.txtGtBikeVCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGtBikeVCourse.Location = New System.Drawing.Point(115, 60)
        Me.txtGtBikeVCourse.Name = "txtGtBikeVCourse"
        Me.txtGtBikeVCourse.ReadOnly = True
        Me.txtGtBikeVCourse.Size = New System.Drawing.Size(440, 20)
        Me.txtGtBikeVCourse.TabIndex = 7
        Me.txtGtBikeVCourse.TabStop = False
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(522, 100)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(12, 105)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(400, 13)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Ready"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(437, 100)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 136)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtGtBikeVCourse)
        Me.Controls.Add(Me.lblGtBikeVCourse)
        Me.Controls.Add(Me.txtMapEditor)
        Me.Controls.Add(Me.lblMapEditor)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Grand Theft Bike V - Route Builder 0.1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents lblMapEditor As Label
    Friend WithEvents txtMapEditor As TextBox
    Friend WithEvents lblGtBikeVCourse As Label
    Friend WithEvents txtGtBikeVCourse As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnClear As Button
End Class
