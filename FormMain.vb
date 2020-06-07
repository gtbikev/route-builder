Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml

Public Class FormMain

#Region "Constants"

    '-- DataSets
    Public dsMapEditor As New DataSet("MapEditor")
    Public dsSettings As New DataSet("Settings")

#End Region

#Region "Functions"

    '-- Course
    Public Function createCourse() As String()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare array
            Dim strJson(1000000) As String

            'Declare variables
            Dim intRowCounter As Integer = 0
            Dim intDataCounter As Integer = 0
            Dim intDataIndex As Integer = Me.dsMapEditor.Tables("Position").Rows.Count - 1
            Dim strWhitespace As String = "  "
            '======================================================================================
            'Begin
            '======================================================================================
            'Add open bracket
            strJson(intRowCounter) = "{" : intRowCounter = intRowCounter + 1
            '======================================================================================
            'Course
            '======================================================================================
            'Add route name
            strJson(intRowCounter) = strWhitespace & Chr(34) & "Name" & Chr(34) & ": " & Chr(34) & dsMapEditor.Tables("Metadata").Rows(0)("Name") & Chr(34) & "," : intRowCounter = intRowCounter + 1

            'Add start point
            strJson(intRowCounter) = strWhitespace & Chr(34) & "StartPoint" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1

            'Add position
            strJson(intRowCounter) = strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(0)("X") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(0)("Y") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(0)("Z") : intRowCounter = intRowCounter + 1

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & "}," : intRowCounter = intRowCounter + 1
            '======================================================================================
            'Props
            '======================================================================================
            'Add props
            strJson(intRowCounter) = strWhitespace & Chr(34) & "Props" & Chr(34) & ": [" : intRowCounter = intRowCounter + 1
            '--------------------------------------------------------------------------------------
            'Add open bracket
            strJson(intRowCounter) = strWhitespace & strWhitespace & "{" : intRowCounter = intRowCounter + 1

            'Add start banner
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Name" & Chr(34) & ": " & Chr(34) & "prop_tri_start_banner" & Chr(34) & "," : intRowCounter = intRowCounter + 1

            'Add Position
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Position" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(1)("X") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(1)("Y") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(1)("Z") : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1

            'Add Rotation
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Rotation" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & "0.0" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1
            '--------------------------------------------------------------------------------------
            'Add open bracket
            strJson(intRowCounter) = strWhitespace & strWhitespace & "{" : intRowCounter = intRowCounter + 1

            'Add finish banner
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Name" & Chr(34) & ": " & Chr(34) & "prop_tri_finish_banner" & Chr(34) & "," : intRowCounter = intRowCounter + 1

            'Add Position
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Position" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataIndex)("X") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataIndex)("Y") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataIndex)("Z") : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1

            'Add Rotation
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Rotation" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & "0.0" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & "]," : intRowCounter = intRowCounter + 1
            '======================================================================================
            'WayPointList"
            '======================================================================================
            'Add props
            strJson(intRowCounter) = strWhitespace & Chr(34) & "WayPointList" & Chr(34) & ": [" : intRowCounter = intRowCounter + 1
            '--------------------------------------------------------------------------------------
            For Each drPosition As DataRow In dsMapEditor.Tables("Position").Rows
                '----------------------------------------------------------------------------------
                Select Case intDataCounter
                    Case 2 To (intDataIndex - 2)
                        '--------------------------------------------------------------------------
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "{" : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataCounter)("X") & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataCounter)("Y") & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataCounter)("Z") : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1
                        '----------------------------------------------------------------------
                    Case (intDataIndex - 1)
                        '----------------------------------------------------------------------
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "{" : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataCounter)("X") & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataCounter)("Y") & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & dsMapEditor.Tables("Position").Rows(intDataCounter)("Z") : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1
                        '--------------------------------------------------------------------------
                End Select

                'Increase data counter
                intDataCounter = intDataCounter + 1
                '----------------------------------------------------------------------------------
            Next

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & "]" : intRowCounter = intRowCounter + 1
            '======================================================================================
            'End
            '======================================================================================
            'Add close bracket
            strJson(intRowCounter) = "}" : intRowCounter = intRowCounter + 1
            '======================================================================================

            'Resize array with real length
            ReDim Preserve strJson(intRowCounter - 1)

            'Return array
            Return strJson
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Public Function generateCourseFileName() As String
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare course file name
            Dim strCourseFileName As String = Nothing

            'Verify if folder exists
            If getFolderExists(Properties.DefaultDirectoryCourse) = True Then
                '----------------------------------------------------------------------------------
                'Set course file name
                strCourseFileName = Properties.DefaultDirectoryCourse & "\" & Replace(getFileName(Properties.FileMapEditor), ".xml", ".json")
                '----------------------------------------------------------------------------------
            End If

            'Retrun string
            Return strCourseFileName
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    '-- File System
    Public Function getFileExists(ByVal strPath As String) As Boolean
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare file info object
            Dim file As New IO.FileInfo(strPath)

            'Return boolean
            Return file.Exists
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            Return False
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Public Function getFileName(ByVal strPath As String) As String
        '--------------------------------------------------------------------------
        Try
            '----------------------------------------------------------------------
            'Declare file info object
            Dim file As New IO.FileInfo(strPath)

            'Return string
            Return file.Name.ToString()
            '----------------------------------------------------------------------
        Catch exp As Exception
            '----------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            Return Nothing
            '----------------------------------------------------------------------
        End Try
        '--------------------------------------------------------------------------
    End Function

    Public Function getFolder(ByVal strPath As String) As String
        '--------------------------------------------------------------------------
        Try
            '----------------------------------------------------------------------
            'Declare file info object
            Dim file As New IO.FileInfo(strPath)

            'Return string
            Return file.Directory.ToString()
            '----------------------------------------------------------------------
        Catch exp As Exception
            '----------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            Return Nothing
            '----------------------------------------------------------------------
        End Try
        '--------------------------------------------------------------------------
    End Function

    Public Function getFolderExists(ByVal strPath As String) As Boolean
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare file info ob
            Dim file As New IO.DirectoryInfo(strPath)

            'Return boolean
            Return file.Exists
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Return False
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

#End Region

#Region "Events"

    '-- Checkbox
    Private Sub chkGenerateFileName_CheckedChanged(sender As Object, e As EventArgs) Handles chkDefaultGenerateFileName.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set property
            Properties.DefaultGenerateFileName = chkDefaultGenerateFileName.Checked

            'Update data
            Dim objDefaultDirectoryMapEditor As Object = Properties.DefaultGenerateFileName
            editDataValue(dsSettings, "DefaultFileName", 0, objDefaultDirectoryMapEditor)

            'Save settings file
            saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

            'Set control display properties
            setControlDisplayProperties("chkGenerateFileName")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Directory
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
                'Set folder properties
                setFolderProperties("btnSetCourseDirectory_Click", Me.FolderBrowserDialog.SelectedPath)
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
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
                'Set folder properties
                setFolderProperties("btnSetMapEditorDirectory_Click", Me.FolderBrowserDialog.SelectedPath)
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

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
            Me.OpenFileDialog.Title = "Open Map Editor File"
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
                'Set file properties
                setFileProperties("btnOpenMapEditorFile_Click", Me.OpenFileDialog.FileName)
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
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
            Me.SaveFileDialog.Title = "Save Course File"
            Me.SaveFileDialog.DefaultExt = ".json"
            Me.SaveFileDialog.FileName = Nothing
            Me.SaveFileDialog.Filter = "json files (*.json)|*.json"
            Me.SaveFileDialog.FilterIndex = 0
            Me.SaveFileDialog.InitialDirectory = strInitialDirectory
            Me.SaveFileDialog.SupportMultiDottedExtensions = True

            'Verify if ok button is pressed
            If (Me.SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set file properties
                setFileProperties("btnSaveCourseFile_Click", Me.SaveFileDialog.FileName)
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        Finally
            '--------------------------------------------------------------------------------------
            'Set default cursor
            Me.Cursor = Cursors.Default
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
                    tlbAbout_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F2
                    '------------------------------------------------------------------------------
                    tlbSendFeedback_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F5
                    '------------------------------------------------------------------------------
                    tlbStart_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F12
                    '------------------------------------------------------------------------------
                    'Dim frmDebug As New FormDebugConsole() : frmDebug.Show() :
                    e.Handled = True
                    '------------------------------------------------------------------------------
            End Select

            'Handle delete key
            If e.KeyCode = Keys.Delete Then
                '----------------------------------------------------------------------------------
                tlbReset_Click(sender, e) : e.Handled = True
                '----------------------------------------------------------------------------------
            End If

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
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Initialization
            setInitialization()

            'Set control display properties
            setControlDisplayProperties("tlsMain")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Menu
    Private Sub tlbAbout_Click(sender As Object, e As EventArgs) Handles tlbAbout.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Open url in browser
            Process.Start(Properties.InfoUrlAbout)
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
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
                'Set file properties
                setFileProperties("tlbReset_Click")
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub tlbSendFeedback_Click(sender As Object, e As EventArgs) Handles tlbSendFeedback.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Open url in browser
            Process.Start(Properties.InfoUrlSendFeedback)
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
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

                'Open map editor file
                openFile(Me.dsMapEditor, Properties.FileMapEditor)

                'Verify valid input file
                If Properties.ValidInputFile = False Then Exit Sub

                'Create course
                Dim strOutput As String() = createCourse()

                'Save course file
                saveFile(strOutput, Properties.FileCourse)

                'Display status
                Me.lblStatus.Text = "Course '" & getFileName(Properties.FileCourse) & "' created"
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        Finally
            '--------------------------------------------------------------------------------------
            'Set default cursor
            Me.Cursor = Cursors.Default
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Radiobutton
    Private Sub rdbGenerateFileName_Click(sender As Object, e As EventArgs) Handles rdbGenerateFileName.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set file properties
            setFileProperties("rdbGenerateFileName_Click")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub rdbSpecifyFileName_Click(sender As Object, e As EventArgs) Handles rdbSpecifyFileName.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set file properties
            setFileProperties("rdbSpecifyFileName_Click")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Tab Control
    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Display status
            Me.lblStatus.Text = "Ready"
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Textbox
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
                    'Set file properties
                    setFileProperties("txtMapEditorFileName_DragDrop", e.Data.GetData(DataFormats.FileDrop)(0))
                    '------------------------------------------------------------------------------
                Else
                    '------------------------------------------------------------------------------
                    'Display message
                    Me.lblStatus.Text = "Input is not a xml file"
                    '------------------------------------------------------------------------------
                End If
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
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
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub txtSpecifyCourseFileName_DragDrop(sender As Object, e As DragEventArgs) Handles txtSpecifyCourseFileName.DragDrop
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
                    'Set file properties
                    setFileProperties("txtSpecifyCourseFileName_DragDrop", e.Data.GetData(DataFormats.FileDrop)(0))
                    '------------------------------------------------------------------------------
                Else
                    '------------------------------------------------------------------------------
                    'Display message
                    Me.lblStatus.Text = "Input is not a json file"
                    '------------------------------------------------------------------------------
                End If
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub txtSpecifyCourseFileName_DragEnter(sender As Object, e As DragEventArgs) Handles txtSpecifyCourseFileName.DragEnter
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify if drag event args is file
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                '--------------------------------------------------------------------------------------
                'Use copy as drag & drop effect
                e.Effect = DragDropEffects.Copy
                '--------------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

#End Region

#Region "Subs"

    '-- Data
    Public Sub editDataValue(ByVal dsDataSet As DataSet, ByVal strDataTable As String, ByVal intDataColumn As Integer, ByVal objDataValue As Object)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare objects and variables
            Dim dtDataTable As DataTable = dsDataSet.Tables(strDataTable)
            Dim drDataRow As DataRow = dtDataTable.Rows(0)
            Dim strDataValue As String = Nothing

            'Verify if ID column is not null
            If Not drDataRow.IsNull(0) Then
                '----------------------------------------------------------------------------------
                If TypeOf drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) Is String Then
                    drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) = CStr(objDataValue)
                End If
                '----------------------------------------------------------------------------------
                If TypeOf drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) Is Integer Then
                    drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) = CInt(objDataValue)
                End If
                '----------------------------------------------------------------------------------
                If TypeOf drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) Is Boolean Then
                    drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) = CBool(objDataValue)
                End If
                '----------------------------------------------------------------------------------
                If drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) Is System.DBNull.Value Then
                    drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) = Nothing
                End If
                '----------------------------------------------------------------------------------
            End If

            'Add new row permanently in data table
            dsDataSet.AcceptChanges()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Initialization
    Public Sub readConfiguration()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Read configuration
            openFile(Me.dsSettings, Properties.FileSettings)
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub setControlSettings()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set application name and version
            Me.Text = Properties.InfoVersion
            '--------------------------------------------------------------------------------------
            'Verify file valid
            If Properties.ValidInputFile = False Then Exit Sub
            '--------------------------------------------------------------------------------------
            'Set variables
            Dim blnValidateBoolean As Boolean = False
            Dim strDataTable As String = Nothing

            'Set default file name properties
            strDataTable = "DefaultFileName"
            Select Case Me.dsSettings.Tables("DefaultFileName").Rows.Count
                Case 1
                    '------------------------------------------------------------------------------
                    'Validate boolean
                    If Boolean.TryParse(Me.dsSettings.Tables(strDataTable).Rows(0)("DefaultGenerateFileName"), blnValidateBoolean) Then
                        '--------------------------------------------------------------------------
                        Properties.DefaultGenerateFileName = Me.dsSettings.Tables(strDataTable).Rows(0)("DefaultGenerateFileName")
                        '--------------------------------------------------------------------------
                    End If
                    '------------------------------------------------------------------------------
                Case Else
                    '------------------------------------------------------------------------------
                    'Set default in case no entry found
                    Properties.DefaultGenerateFileName = False
                    '------------------------------------------------------------------------------
            End Select

            'Set default file name control
            Me.chkDefaultGenerateFileName.Checked = Properties.DefaultGenerateFileName

            'Set output control
            If Properties.DefaultGenerateFileName = True Then
                '----------------------------------------------------------------------------------
                Me.rdbGenerateFileName.Checked = True
                setControlDisplayProperties("rdbGenerateFileName")
                '----------------------------------------------------------------------------------
            Else
                '----------------------------------------------------------------------------------
                Me.rdbSpecifyFileName.Checked = True
                setControlDisplayProperties("rdbSpecifyFileName")
                '----------------------------------------------------------------------------------
            End If
            '--------------------------------------------------------------------------------------
            'Set default directory properties
            strDataTable = "DefaultDirectory"
            Select Case Me.dsSettings.Tables(strDataTable).Rows.Count
                '----------------------------------------------------------------------------------
                Case 1
                    '------------------------------------------------------------------------------
                    'Validate folders
                    If getFolderExists(Me.dsSettings.Tables(strDataTable).Rows(0)("DefaultDirectoryMapEditor")) Then
                        '--------------------------------------------------------------------------
                        Properties.DefaultDirectoryMapEditor = Me.dsSettings.Tables(strDataTable).Rows(0)("DefaultDirectoryMapEditor")
                        '--------------------------------------------------------------------------
                    Else
                        '--------------------------------------------------------------------------
                        Properties.DefaultDirectoryMapEditor = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                        '--------------------------------------------------------------------------
                    End If
                    If getFolderExists(Me.dsSettings.Tables(strDataTable).Rows(0)("DefaultDirectoryCourse")) Then
                        '--------------------------------------------------------------------------
                        Properties.DefaultDirectoryCourse = Me.dsSettings.Tables(strDataTable).Rows(0)("DefaultDirectoryCourse")
                        '--------------------------------------------------------------------------
                    Else
                        '--------------------------------------------------------------------------
                        Properties.DefaultDirectoryCourse = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                        '--------------------------------------------------------------------------
                    End If
                    '------------------------------------------------------------------------------
                Case Else
                    '------------------------------------------------------------------------------
                    'Set default in case no entry found
                    Properties.DefaultDirectoryMapEditor = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                    Properties.DefaultDirectoryCourse = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                    '------------------------------------------------------------------------------
            End Select

            'Set default directories
            Me.txtDefaultDirectoryMapEditor.Text = Properties.DefaultDirectoryMapEditor
            Me.txtDefaultDirectoryCourse.Text = Properties.DefaultDirectoryCourse
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub setCulture()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set user interface culture
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US", True)
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub setInitialization()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Initialize
            setCulture()
            setPropertySettings()
            readConfiguration()
            setControlSettings()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub setPropertySettings()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set application properties
            Properties.InfoAssemblyName = My.Application.Info.AssemblyName
            Properties.InfoDirectoryPath = My.Application.Info.DirectoryPath
            Properties.InfoUrlAbout = "https://github.com/gtbikev/route-builder"
            Properties.InfoUrlSendFeedback = "https://github.com/gtbikev/route-builder/issues"
            Properties.InfoVersion = My.Application.Info.ProductName & " " & System.Windows.Forms.Application.ProductVersion

            'Set file properties
            Properties.FileSettings = Properties.InfoDirectoryPath & "\" & Properties.InfoAssemblyName & ".config"
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- File System
    Public Sub openFile(ByVal dsDataSet As DataSet, ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Read xml
            dsDataSet.Reset()
            dsDataSet.ReadXml(strPath)

            'Set file validation
            Properties.ValidInputFile = True
            '--------------------------------------------------------------------------------------
        Catch fnf As FileNotFoundException
            '--------------------------------------------------------------------------------------
            'Set file validation
            Properties.ValidInputFile = False

            'Set exception handling 
            Select Case strPath
                Case = Properties.FileMapEditor
                    '------------------------------------------------------------------------------
                    'Display status
                    Me.lblStatus.Text = "Map editor file '" & getFileName(Properties.FileMapEditor) & "' does not exist."
                    '------------------------------------------------------------------------------
                Case = Properties.FileSettings
                    '------------------------------------------------------------------------------
                    'Set control display properties
                    setControlDisplayProperties("invalidConfiguration")

                    'Display status
                    Me.lblStatus.Text = "Configuration file '" & getFileName(Properties.FileSettings) & "' does not exist."
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        Catch xml As XmlException
            '--------------------------------------------------------------------------------------
            'Set file validation
            Properties.ValidInputFile = False

            'Set exception handling 
            Select Case strPath
                Case = Properties.FileMapEditor
                    '------------------------------------------------------------------------------
                    'Display status
                    Me.lblStatus.Text = "Invalid map editor file. Please verify content of file '" & getFileName(strPath) & "'."
                    '------------------------------------------------------------------------------
                Case = Properties.FileSettings
                    '------------------------------------------------------------------------------
                    'Set control display properties
                    setControlDisplayProperties("invalidConfiguration")

                    'Display status
                    Me.lblStatus.Text = "Invalid configuration file. Please verify content of file '" & getFileName(strPath) & "'."
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub saveFile(ByVal strOutput As String, ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare and initialize streamwriter
            Dim swOutputFile As New IO.StreamWriter(strPath, False, New UTF8Encoding(False))

            'Write content to file
            swOutputFile.Write(strOutput)

            'Close streamwriter
            swOutputFile.Close()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub saveFile(ByVal strOutput As String(), ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare and initialize streamwriter
            Dim swOutputFile As New IO.StreamWriter(strPath, False, New UTF8Encoding(False))

            'Loop through array and write content to file
            Dim intOutputFileCounter As Integer
            For intOutputFileCounter = 0 To strOutput.GetUpperBound(0)
                '----------------------------------------------------------------------------------
                swOutputFile.WriteLine(strOutput(intOutputFileCounter))
                '----------------------------------------------------------------------------------
            Next

            'Close streamwriter
            swOutputFile.Close()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Controls
    Public Sub setControlDisplayProperties(ByVal strControl As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set control display properties (backcolor, checked, enabled, visible)
            Select Case strControl
                Case = "invalidConfiguration"
                    '------------------------------------------------------------------------------
                    Me.grbMapEditor.Enabled = False
                    Me.grbCourse.Enabled = False
                    Me.grbDefaultFileName.Enabled = False
                    Me.grbDefaultDirectories.Enabled = False
                    '------------------------------------------------------------------------------
                Case = "rdbGenerateFileName"
                    '------------------------------------------------------------------------------
                    Me.txtGenerateCourseFileName.BackColor = SystemColors.Window
                    Me.txtSpecifyCourseFileName.BackColor = SystemColors.Control
                    '------------------------------------------------------------------------------
                Case = "rdbSpecifyFileName"
                    '------------------------------------------------------------------------------
                    Me.rdbSpecifyFileName.Checked = True
                    Me.txtGenerateCourseFileName.BackColor = SystemColors.Control
                    Me.txtSpecifyCourseFileName.BackColor = SystemColors.Window
                    '------------------------------------------------------------------------------
                Case = "tlbReset", "chkGenerateFileName"
                    '------------------------------------------------------------------------------
                    Select Case Properties.DefaultGenerateFileName
                        Case True
                            '----------------------------------------------------------------------
                            Me.rdbGenerateFileName.Checked = True
                            Me.txtGenerateCourseFileName.BackColor = SystemColors.Window
                            Me.txtSpecifyCourseFileName.BackColor = SystemColors.Control
                            '----------------------------------------------------------------------
                        Case False
                            '----------------------------------------------------------------------
                            Me.rdbSpecifyFileName.Checked = True
                            Me.txtGenerateCourseFileName.BackColor = SystemColors.Control
                            Me.txtSpecifyCourseFileName.BackColor = SystemColors.Window
                            '----------------------------------------------------------------------
                    End Select
                    '------------------------------------------------------------------------------
                Case = "tlsMain"
                    '------------------------------------------------------------------------------
                    If Properties.FileMapEditor IsNot Nothing Or Properties.FileCourse IsNot Nothing Then Me.tlbReset.Enabled = True Else Me.tlbReset.Enabled = False
                    If Properties.FileMapEditor IsNot Nothing AndAlso Properties.FileCourse IsNot Nothing Then Me.tlbStart.Enabled = True Else Me.tlbStart.Enabled = False
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub setFileProperties(ByVal strControl As String, Optional ByVal strPath As String = Nothing)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set file properties
            Select Case strControl
                Case = "btnOpenMapEditorFile_Click", "txtMapEditorFileName_DragDrop"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileMapEditor = strPath

                    'Set textbox
                    Me.txtMapEditorFileName.Text = Properties.FileMapEditor

                    'Verify if generate file name is checked
                    If Me.rdbGenerateFileName.Checked = True Then
                        '--------------------------------------------------------------------------
                        'Set property
                        Properties.FileCourse = generateCourseFileName()

                        'Set textbox
                        Me.txtGenerateCourseFileName.Text = Properties.FileCourse
                        '--------------------------------------------------------------------------
                    End If

                    'Display status
                    Me.lblStatus.Text = "Map Editor file specified"
                    '------------------------------------------------------------------------------
                Case = "btnSaveCourseFile_Click", "txtSpecifyCourseFileName_DragDrop"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileCourse = strPath

                    'Set textbox
                    Me.txtGenerateCourseFileName.Text = Nothing
                    Me.txtSpecifyCourseFileName.Text = Properties.FileCourse

                    'Set control display properties
                    setControlDisplayProperties("rdbSpecifyFileName")

                    'Display status
                    Me.lblStatus.Text = "Course file specified"
                    '------------------------------------------------------------------------------
                Case = "btnSetCourseDirectory_Click"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileCourse = generateCourseFileName()

                    'Set textbox
                    Me.txtGenerateCourseFileName.Text = Properties.FileCourse
                    '------------------------------------------------------------------------------
                Case = "rdbGenerateFileName_Click"
                    '------------------------------------------------------------------------------
                    'Verify if map editor file is loaded
                    If Properties.FileMapEditor IsNot Nothing Then
                        '--------------------------------------------------------------------------
                        'Set property
                        Properties.FileCourse = generateCourseFileName()

                        'Set textbox
                        Me.txtGenerateCourseFileName.Text = Properties.FileCourse
                        '--------------------------------------------------------------------------
                    End If

                    'Set textbox
                    Me.txtSpecifyCourseFileName.Text = Nothing

                    'Set control display properties
                    setControlDisplayProperties("rdbGenerateFileName")

                    'Display status
                    Me.lblStatus.Text = "Ready"
                    '------------------------------------------------------------------------------
                Case = "rdbSpecifyFileName_Click"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileCourse = Nothing

                    'Set textbox
                    Me.txtGenerateCourseFileName.Text = Properties.FileCourse

                    'Set control display properties
                    setControlDisplayProperties("rdbSpecifyFileName")

                    'Display status
                    Me.lblStatus.Text = "Ready"
                    '------------------------------------------------------------------------------
                Case = "tlbReset_Click"
                    '------------------------------------------------------------------------------
                    'Clear properties
                    Properties.FileMapEditor = Nothing
                    Properties.FileCourse = Nothing

                    'Set textbox
                    Me.txtMapEditorFileName.Text = Properties.FileMapEditor
                    Me.txtGenerateCourseFileName.Text = Properties.FileCourse
                    Me.txtSpecifyCourseFileName.Text = Properties.FileCourse

                    'Set control display properties
                    setControlDisplayProperties("tlbReset")

                    'Display status
                    Me.lblStatus.Text = "Reset done"
                    '------------------------------------------------------------------------------
            End Select

            'Set control display properties
            setControlDisplayProperties("tlsMain")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub setFolderProperties(ByVal strControl As String, ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            Select Case strControl
                Case = "btnSetCourseDirectory_Click"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.DefaultDirectoryCourse = strPath

                    'Update data
                    Dim objDefaultDirectoryCourse As Object = Properties.DefaultDirectoryCourse
                    editDataValue(dsSettings, "DefaultDirectory", 1, objDefaultDirectoryCourse)

                    'Save settings file
                    saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                    'Set textbox
                    Me.txtDefaultDirectoryCourse.Text = Properties.DefaultDirectoryCourse

                    'Set file properties
                    If Properties.FileMapEditor IsNot Nothing AndAlso Me.rdbGenerateFileName.Checked = True Then setFileProperties(strControl)

                    'Display status
                    Me.lblStatus.Text = "Default course directory specified"
                    '------------------------------------------------------------------------------
                Case = "btnSetMapEditorDirectory_Click"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.DefaultDirectoryMapEditor = strPath

                    'Update data
                    Dim objDefaultDirectoryMapEditor As Object = Properties.DefaultDirectoryMapEditor
                    editDataValue(dsSettings, "DefaultDirectory", 0, objDefaultDirectoryMapEditor)

                    'Save settings file
                    saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)

                    'Set textbox
                    Me.txtDefaultDirectoryMapEditor.Text = Properties.DefaultDirectoryMapEditor

                    'Display status
                    Me.lblStatus.Text = "Default map editor directory specified"
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

#End Region

End Class