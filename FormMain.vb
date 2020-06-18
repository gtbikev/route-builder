
Imports System.Reflection

Public Class FormMain

#Region "Constants"

    '-- DataSets
    Public dsElements As New DataSet("Elements")
    Public dsMapEditor As New DataSet("MapEditor")
    Public dsSettings As New DataSet("Settings")

#End Region

#Region "Events"

    '-- File
    Private Sub btnOpenMapEditorFile_Click(sender As Object, e As EventArgs) Handles btnOpenMapEditorFile.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set hourglass cursor
            Me.Cursor = Cursors.WaitCursor

            'Declare variable
            Dim strInitialDirectory As String = Properties.DefaultDirectoryMapEditor

            'Declare properties
            Me.OpenFileDialog.Title = "Specify Map Editor File"
            Me.OpenFileDialog.DefaultExt = ".xml"
            Me.OpenFileDialog.FileName = Nothing
            Me.OpenFileDialog.FilterIndex = 0
            Me.OpenFileDialog.InitialDirectory = strInitialDirectory
            Me.OpenFileDialog.Multiselect = False
            Me.OpenFileDialog.Filter = "xml files (*.xml)|*.xml"
            Me.OpenFileDialog.RestoreDirectory = True
            Me.OpenFileDialog.SupportMultiDottedExtensions = True

            'Verify if ok button is pressed
            If (Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Specify Map Editor File: Started"))

                'Set file properties
                WinFormControls.setFileProperties("btnOpenMapEditorFile_Click", Me.OpenFileDialog.FileName)

                'Set element data
                WinFormControls.setElementData()

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Specify Map Editor File: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        Finally
            '--------------------------------------------------------------------------------------
            'Set default cursor
            Me.Cursor = Cursors.Default
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub btnSaveCourseFile_Click(sender As Object, e As EventArgs) Handles btnSaveCourseFile.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set hourglass cursor
            Me.Cursor = Cursors.WaitCursor

            'Declare variables
            Dim dsDataSet As DataSet = Nothing
            Dim strInitialDirectory As String = Properties.DefaultDirectoryCourse

            'Delare properties
            Me.SaveFileDialog.Title = "Specify Course File"
            Me.SaveFileDialog.DefaultExt = ".json"
            Me.SaveFileDialog.FileName = Nothing
            Me.SaveFileDialog.Filter = "json files (*.json)|*.json"
            Me.SaveFileDialog.FilterIndex = 0
            Me.SaveFileDialog.InitialDirectory = strInitialDirectory
            Me.SaveFileDialog.SupportMultiDottedExtensions = True

            'Verify if ok button is pressed
            If (Me.SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Specify Course File: Started"))

                'Set file properties
                WinFormControls.setFileProperties("btnSaveCourseFile_Click", Me.SaveFileDialog.FileName)

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Specify Course File: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        Finally
            '--------------------------------------------------------------------------------------
            'Set default cursor
            Me.Cursor = Cursors.Default
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub txtCourseFileName_DragDrop(sender As Object, e As DragEventArgs) Handles txtCourseFileName.DragDrop
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Activate form
            Me.Activate()

            'Verify if drag event args is file
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                '----------------------------------------------------------------------------------
                'Declare file info object
                Dim file As New IO.FileInfo(e.Data.GetData(DataFormats.FileDrop)(0))

                'Verify if file is .xml
                If file.Extension = ".json" Then
                    '------------------------------------------------------------------------------
                    'Set output message
                    Output.setOutputMessage(Output.getOutputHeader("Specify Course File: Started"))

                    'Set file properties
                    WinFormControls.setFileProperties("txtCourseFileName_DragDrop", e.Data.GetData(DataFormats.FileDrop)(0))

                    'Set output message
                    Output.setOutputMessage(Output.getOutputFooter("Specify Course File: Completed"))
                    '------------------------------------------------------------------------------
                Else
                    '------------------------------------------------------------------------------
                    'Set output message
                    Output.setOutputMessage("[WARNING] Input is not a json file" & ControlChars.CrLf)

                    'Set status
                    WinFormControls.setStatus("Input is not a json file")
                    '------------------------------------------------------------------------------
                End If
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub txtCourseFileName_DragEnter(sender As Object, e As DragEventArgs) Handles txtCourseFileName.DragEnter
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify if drag event args is file
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                '----------------------------------------------------------------------------------
                'Use copy as drag & drop effect
                e.Effect = DragDropEffects.Copy
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub txtMapEditorFileName_DragDrop(sender As Object, e As DragEventArgs) Handles txtMapEditorFileName.DragDrop
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Activate form
            Me.Activate()

            'Verify if drag event args is file
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                '----------------------------------------------------------------------------------
                'Declare file info object
                Dim file As New IO.FileInfo(e.Data.GetData(DataFormats.FileDrop)(0))

                'Verify if file is .xml
                If file.Extension = ".xml" Then
                    '------------------------------------------------------------------------------
                    'Set output message
                    Output.setOutputMessage(Output.getOutputHeader("Specify Map Editor File: Started"))

                    'Set file properties
                    WinFormControls.setFileProperties("txtMapEditorFileName_DragDrop", e.Data.GetData(DataFormats.FileDrop)(0))

                    'Set element data
                    WinFormControls.setElementData()

                    'Set output message
                    Output.setOutputMessage(Output.getOutputFooter("Specify Map Editor File: Completed"))
                    '------------------------------------------------------------------------------
                Else
                    '------------------------------------------------------------------------------
                    'Set output message
                    Output.setOutputMessage("[WARNING] Input is not a xml file" & ControlChars.CrLf)

                    'Set status
                    WinFormControls.setStatus("Input is not a xml file")
                    '------------------------------------------------------------------------------
                End If
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub txtMapEditorFileName_DragEnter(sender As Object, e As DragEventArgs) Handles txtMapEditorFileName.DragEnter
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify if drag event args is file
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                '----------------------------------------------------------------------------------
                'Use copy as drag & drop effect
                e.Effect = DragDropEffects.Copy
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Form
    Private Sub FormMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Handle function keys
            Select Case e.KeyCode
                Case = Keys.F1
                    '------------------------------------------------------------------------------
                    tlbHelp_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F2
                    '------------------------------------------------------------------------------
                    tlbSendFeedback_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F5
                    '------------------------------------------------------------------------------
                    tlbStart_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F11
                    '------------------------------------------------------------------------------
                    Select Case Me.chkDebugShowWindow.Checked
                        Case = True
                            '----------------------------------------------------------------------
                            Me.chkDebugShowWindow.Checked = False
                            '----------------------------------------------------------------------
                        Case = False
                            '----------------------------------------------------------------------
                            Me.chkDebugShowWindow.Checked = True
                            '----------------------------------------------------------------------
                    End Select
                    e.Handled = True
                    '------------------------------------------------------------------------------
            End Select

            'Handle keys
            Select Case e.KeyCode
                Case Keys.Delete
                    '------------------------------------------------------------------------------
                    tlbReset_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
            End Select

            'Handle control + key
            If ((e.Modifiers = (Keys.Control)) AndAlso (e.KeyCode = Keys.O)) Then
                '----------------------------------------------------------------------------------
                btnOpenMapEditorFile_Click(sender, e) : e.Handled = True
                '----------------------------------------------------------------------------------
            End If
            If ((e.Modifiers = (Keys.Control)) AndAlso (e.KeyCode = Keys.S)) Then
                '----------------------------------------------------------------------------------
                btnSaveCourseFile_Click(sender, e) : e.Handled = True
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Initialization
            Configuration.setInitialization()

            'Set control display properties
            WinFormControls.setControlDisplayProperties("tlsMain")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set focus
            Me.tvwSettings.SelectedNode = Me.tvwSettings.Nodes.Item(0)
            Me.tvwSettings.Focus()

            'Set control display properties
            WinFormControls.setControlDisplayProperties("tvwSettings")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Menu
    Private Sub tlbHelp_Click(sender As Object, e As EventArgs) Handles tlbHelp.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set output message
            Output.setOutputMessage(Output.getOutputHeader("Help: Started"))

            'Open url in browser
            Process.Start(Properties.InfoUrlHelp)

            'Set output message
            Output.setOutputMessage("URL -> '" & Properties.InfoUrlHelp & "'")

            'Set output message
            Output.setOutputMessage(Output.getOutputFooter("Help: Completed"))
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub tlbReset_Click(sender As Object, e As EventArgs) Handles tlbReset.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify input
            If Properties.FileMapEditor IsNot Nothing Or Properties.FileCourse IsNot Nothing Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Reset: Started"))

                'Set file properties
                WinFormControls.setFileProperties("tlbReset_Click")

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Reset: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub tlbSendFeedback_Click(sender As Object, e As EventArgs) Handles tlbSendFeedback.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set output message
            Output.setOutputMessage(Output.getOutputHeader("Send Feedback: Started"))

            'Open url in browser
            Process.Start(Properties.InfoUrlSendFeedback)

            'Set output message
            Output.setOutputMessage("URL -> '" & Properties.InfoUrlSendFeedback & "'")

            'Set output message
            Output.setOutputMessage(Output.getOutputFooter("Send Feedback: Completed"))
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub tlbStart_Click(sender As Object, e As EventArgs) Handles tlbStart.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify input
            If Properties.FileMapEditor IsNot Nothing AndAlso Properties.FileCourse IsNot Nothing Then
                '----------------------------------------------------------------------------------
                'Set hourglass cursor
                Me.Cursor = Cursors.WaitCursor

                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Convert Route: Started"))

                'Open map editor file
                FileSystem.openFile(Me.dsMapEditor, Properties.FileMapEditor)

                'Verify valid input file
                If Properties.ValidInputFile = False Then Exit Sub

                'Create course
                Dim strOutput As String() = ConvertRoute.createCourse()

                'Save course file
                FileSystem.saveFile(strOutput, Properties.FileCourse)

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Convert Route: Completed"))

                'Set status
                WinFormControls.setStatus("Course '" & FileSystem.getFileName(Properties.FileCourse) & "' created")
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        Finally
            '--------------------------------------------------------------------------------------
            'Set default cursor
            Me.Cursor = Cursors.Default
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Settings
    Private Sub btnSetCourseDirectory_Click(sender As Object, e As EventArgs) Handles btnSetCourseDirectory.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare properties
            Me.FolderBrowserDialog.Description = "Select default course directory"
            Me.FolderBrowserDialog.SelectedPath = Properties.DefaultDirectoryCourse
            Me.FolderBrowserDialog.ShowNewFolderButton = False

            'Verify if ok button is pressed
            If (Me.FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Default Course Directory: Started"))

                'Set folder properties
                WinFormControls.setFolderProperties("btnSetCourseDirectory_Click", Me.FolderBrowserDialog.SelectedPath)

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Default Course Directory: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub btnSetMapEditorDirectory_Click(sender As Object, e As EventArgs) Handles btnSetMapEditorDirectory.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare properties
            Me.FolderBrowserDialog.Description = "Select default map editor directory"
            Me.FolderBrowserDialog.SelectedPath = Properties.DefaultDirectoryMapEditor
            Me.FolderBrowserDialog.ShowNewFolderButton = False

            'Verify if ok button is pressed
            If (Me.FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Default Map Editor Directory: Started"))

                'Set folder properties
                WinFormControls.setFolderProperties("btnSetMapEditorDirectory_Click", Me.FolderBrowserDialog.SelectedPath)

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Default Map Editor Directory: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub chkDebugShowWindow_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebugShowWindow.CheckedChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify change
            If Properties.DebugShowWindow <> chkDebugShowWindow.Checked Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Show Debug Window: Started"))

                'Set property
                Properties.DebugShowWindow = chkDebugShowWindow.Checked

                'Update data
                Dim objDebugShowWindow As Object = Properties.DebugShowWindow
                Data.editDataValue(Me.dsSettings, "Debug", 0, objDebugShowWindow)

                'Save settings file
                FileSystem.saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                'Set control display properties
                WinFormControls.setControlDisplayProperties("chkShowDebugWindow")

                'Set output message
                Output.setOutputMessage("Show Debug Window -> '" & Properties.DebugShowWindow & "'")

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Show Debug Window: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub chkEnableOffsets_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableOffsets.CheckedChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify change
            If Properties.OffsetEnabled <> chkEnableOffsets.Checked Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Enable Offset: Started"))

                'Set property
                Properties.OffsetEnabled = chkEnableOffsets.Checked

                'Update data
                Dim objOffsetEnabled As Object = Properties.OffsetEnabled
                Data.editDataValue(Me.dsSettings, "Offsets", 0, objOffsetEnabled)

                'Save settings file
                FileSystem.saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                'Set control display properties
                WinFormControls.setControlDisplayProperties("chkEnableOffsets")

                'Set output message
                Output.setOutputMessage("Enable Offset -> '" & Properties.OffsetEnabled & "'")

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Enable Offset: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub chkGenerateFileName_CheckedChanged(sender As Object, e As EventArgs) Handles chkGenerateFileName.CheckedChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify change
            If Properties.DefaultGenerateFileName <> chkGenerateFileName.Checked Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Generate File Name: Started"))

                'Set property
                Properties.DefaultGenerateFileName = chkGenerateFileName.Checked

                'Update data
                Dim objDefaultDirectoryMapEditor As Object = Properties.DefaultGenerateFileName
                Data.editDataValue(dsSettings, "Defaults", 2, objDefaultDirectoryMapEditor)

                'Save settings file
                FileSystem.saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                'Set control display properties
                WinFormControls.setControlDisplayProperties("chkGenerateFileName")

                'Set output message
                Output.setOutputMessage("Generate File Name -> '" & Properties.DefaultGenerateFileName & "'")

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Generate File Name: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub nudXOffset_ValueChanged(sender As Object, e As EventArgs) Handles nudXOffset.ValueChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify change
            If Properties.XOffset <> nudXOffset.Value Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("X Offset: Started"))

                'Set property
                Properties.XOffset = nudXOffset.Value

                'Update data
                Dim objXOffset As Object = Properties.XOffset
                Data.editDataValue(Me.dsSettings, "Offsets", 1, objXOffset)

                'Save settings file
                FileSystem.saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                'Set output message
                Output.setOutputMessage("X Offset -> '" & Properties.XOffset.ToString & "'")

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("X Offset: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub nudYOffset_ValueChanged(sender As Object, e As EventArgs) Handles nudYOffset.ValueChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify change
            If Properties.YOffset <> nudYOffset.Value Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Y Offset: Started"))

                'Set property
                Properties.YOffset = nudYOffset.Value

                'Update data
                Dim objYOffset As Object = Properties.YOffset
                Data.editDataValue(Me.dsSettings, "Offsets", 2, objYOffset)

                'Save settings file
                FileSystem.saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                'Set output message
                Output.setOutputMessage("Y Offset -> '" & Properties.YOffset.ToString & "'")

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Y Offset: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub nudZOffset_ValueChanged(sender As Object, e As EventArgs) Handles nudZOffset.ValueChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify change
            If Properties.ZOffset <> nudZOffset.Value Then
                '----------------------------------------------------------------------------------
                'Set output message
                Output.setOutputMessage(Output.getOutputHeader("Z Offset: Started"))

                'Set property
                Properties.ZOffset = nudZOffset.Value

                'Update data
                Dim objZOffset As Object = Properties.ZOffset
                Data.editDataValue(Me.dsSettings, "Offsets", 3, objZOffset)

                'Save settings file
                FileSystem.saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                'Set output message
                Output.setOutputMessage("Z Offset -> '" & Properties.ZOffset.ToString & "'")

                'Set output message
                Output.setOutputMessage(Output.getOutputFooter("Z Offset: Completed"))
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub tvwSettings_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwSettings.AfterSelect
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set control display properties
            WinFormControls.setControlDisplayProperties("tvwSettings")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Elements
    Private Sub tvwElementData_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwDataset.AfterSelect
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set datagrid
            For Each dtDataTable As DataTable In Me.dsElements.Tables
                '----------------------------------------------------------------------------------
                If dtDataTable.TableName.ToString = e.Node.FullPath.ToString Then
                    '------------------------------------------------------------------------------
                    Me.dgvDataset.DataSource = dsElements.Tables(dtDataTable.TableName.ToString)
                    Me.dgvDataset.Show()
                    Me.dgvDataset.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                    '------------------------------------------------------------------------------
                End If
                '----------------------------------------------------------------------------------
            Next
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub pnlSettingsDebug_VisibleChanged(sender As Object, e As EventArgs) Handles pnlSettingsDebug.VisibleChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set control display properties
            WinFormControls.setControlDisplayProperties("pnlSettingsDebug")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

#End Region

End Class