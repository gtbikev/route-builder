Imports System.IO
Imports System.Text

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

    '-- File System

    Public Function getFileExists(ByVal strPath As String) As Boolean
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare file info object
            Dim file As New IO.FileInfo(strPath)

            'Return bolean
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
            'Return bolean
            Return False
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

#End Region

#Region "Events"

    '-- Directory

    Private Sub btnOpenMapEditorDirectory_Click(sender As Object, e As EventArgs) Handles btnOpenMapEditorDirectory.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare properties
            Me.FolderBrowserDialog.Description = "Select default map editor directory"
            Me.FolderBrowserDialog.SelectedPath = Properties.DirectoryDefaultMapEditor
            Me.FolderBrowserDialog.ShowNewFolderButton = False

            'Check if ok button has been pressed
            If (Me.FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set property
                Properties.DirectoryDefaultMapEditor = Me.FolderBrowserDialog.SelectedPath

                'Set textbox
                Me.txtDirectoryDefaultMapEditor.Text = Properties.DirectoryDefaultMapEditor

                'Update data
                Dim objDirectoryDefaultMapEditor As Object = Properties.DirectoryDefaultMapEditor
                editDataValue(dsSettings, "DirectoryDefault", 0, objDirectoryDefaultMapEditor)

                'Save settings file
                saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)
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

    Private Sub btnOpenCourseDirectory_Click(sender As Object, e As EventArgs) Handles btnOpenCourseDirectory.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare properties
            Me.FolderBrowserDialog.Description = "Select default course directory"
            Me.FolderBrowserDialog.SelectedPath = Properties.DirectoryDefaultCourse
            Me.FolderBrowserDialog.ShowNewFolderButton = False

            'Check if ok button has been pressed
            If (Me.FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set property
                Properties.DirectoryDefaultCourse = Me.FolderBrowserDialog.SelectedPath

                'Set textbox
                Me.txtDirectoryDefaultCourse.Text = Properties.DirectoryDefaultCourse

                'Update data
                Dim objDirectoryDefaultCourse As Object = Properties.DirectoryDefaultCourse
                editDataValue(dsSettings, "DirectoryDefault", 1, objDirectoryDefaultCourse)

                'Save config file
                saveFile(Me.dsSettings.GetXml(), Properties.FileSettings)
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
            Dim strInitialDirectory As String = Properties.DirectoryDefaultMapEditor

            'Declare properties
            Me.OpenFileDialog.Title = "Open Map Editor File"
            Me.OpenFileDialog.DefaultExt = ".xml"
            Me.OpenFileDialog.FileName = ""
            Me.OpenFileDialog.FilterIndex = 0
            Me.OpenFileDialog.InitialDirectory = strInitialDirectory
            Me.OpenFileDialog.Multiselect = False
            Me.OpenFileDialog.Filter = "xml files (*.xml)|*.xml"
            Me.OpenFileDialog.RestoreDirectory = True
            Me.OpenFileDialog.SupportMultiDottedExtensions = True

            'Check if ok button has been pressed
            If (Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set file
                setFile("Map Editor", Me.OpenFileDialog.FileName)
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
            Dim strInitialDirectory As String = Properties.DirectoryDefaultCourse

            'Delare properties
            Me.SaveFileDialog.Title = "Save Course File"
            Me.SaveFileDialog.DefaultExt = ".json"
            Me.SaveFileDialog.FileName = ""
            Me.SaveFileDialog.Filter = "json files (*.json)|*.json"
            Me.SaveFileDialog.FilterIndex = 0
            Me.SaveFileDialog.InitialDirectory = strInitialDirectory
            Me.SaveFileDialog.SupportMultiDottedExtensions = True

            'Check if ok button has been pressed
            If (Me.SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                '----------------------------------------------------------------------------------
                'Set file
                setFile("Course", Me.SaveFileDialog.FileName)
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

    Private Sub tlbClearAll_Click(sender As Object, e As EventArgs) Handles tlbClearAll.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Reset controls
            Me.rdbGenerateFileName.Checked = True
            Me.txtMapEditorFileName.Text = ""
            Me.txtGenerateCourseFileName.Text = ""
            Me.txtSpecifyCourseFileName.Text = ""

            'Clear properties
            Properties.FileMapEditor = ""
            Properties.FileCourse = ""

            'Set control display settings
            setControlDisplaySettings("Toolbar")
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
            'Validate input
            If Properties.FileMapEditor <> "" AndAlso Properties.FileCourse <> "" Then
                '----------------------------------------------------------------------------------
                'Set hourglass cursor
                Me.Cursor = Cursors.WaitCursor

                'Create course
                Dim strOutput As String() = createCourse()

                'Save file
                saveFile(strOutput, Properties.FileCourse)

                'Display status
                Me.lblStatus.Text = "Course file created"
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
                    'Call button tlbAbout_Click
                    tlbAbout_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F2
                    '------------------------------------------------------------------------------
                    'Call button tlbSendFeedback_Click
                    tlbSendFeedback_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F5
                    '------------------------------------------------------------------------------
                    'Call button tlbStart_Click
                    tlbStart_Click(sender, e) : e.Handled = True
                    '------------------------------------------------------------------------------
                Case = Keys.F12
                    '------------------------------------------------------------------------------
                    'Open form debug console
                    'Dim frmDebug As New FormDebugConsole() : frmDebug.Show() :
                    e.Handled = True
                    '------------------------------------------------------------------------------
            End Select

            'Handel delete key
            If e.KeyCode = Keys.Delete Then
                '----------------------------------------------------------------------------------
                tlbClearAll_Click(sender, e) : e.Handled = True
                '----------------------------------------------------------------------------------
            End If

            'Handle control + key
            If ((e.Modifiers = (Keys.Control)) AndAlso (e.KeyCode = Keys.O)) Then
                '----------------------------------------------------------------------------------
                'Call button btnOpenMapEditorFile
                btnOpenMapEditorFile_Click(sender, e) : e.Handled = True
                '----------------------------------------------------------------------------------
            End If
            If ((e.Modifiers = (Keys.Control)) AndAlso (e.KeyCode = Keys.S)) Then
                '----------------------------------------------------------------------------------
                'Call button btnSaveCourseFile
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

            'Set control display settings
            setControlDisplaySettings("Toolbar")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Radiobutton

    Private Sub rdbGenerateFileName_CheckedChanged(sender As Object, e As EventArgs)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify if radio button is checked
            If Me.rdbGenerateFileName.Checked = True Then
                '----------------------------------------------------------------------------------
                'Set property
                Properties.FileCourse = Me.txtGenerateCourseFileName.Text
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

    Private Sub rdbSpecifyFileName_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSpecifyFileName.CheckedChanged
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify if radio button is checked
            If Me.rdbSpecifyFileName.Checked = True Then
                '----------------------------------------------------------------------------------
                'Set property
                Properties.FileCourse = Me.txtSpecifyCourseFileName.Text
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

    '-- Textbox

    Private Sub txtMapEditorFileName_DragDrop(sender As Object, e As DragEventArgs) Handles txtMapEditorFileName.DragDrop
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Activate form
            Me.Activate()

            'Check if drag event args is file
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                '----------------------------------------------------------------------------------
                'Declare file info object
                Dim file As New IO.FileInfo(e.Data.GetData(DataFormats.FileDrop)(0))

                'Verify if file is .xml
                If file.Extension = ".xml" Then
                    '------------------------------------------------------------------------------
                    'Set file
                    setFile("Map Editor", e.Data.GetData(DataFormats.FileDrop)(0))
                    '------------------------------------------------------------------------------
                Else
                    '------------------------------------------------------------------------------
                    'Display message
                    Me.lblStatus.Text = "Input file is not a xml file"
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
        'Check if drag event args is file
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            '--------------------------------------------------------------------------------------
            'Use copy as drag & drop effect
            e.Effect = DragDropEffects.Copy
            '--------------------------------------------------------------------------------------
        End If
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub txtSpecifyCourseFileName_DragDrop(sender As Object, e As DragEventArgs) Handles txtSpecifyCourseFileName.DragDrop
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Activate form
            Me.Activate()

            'Check if drag event args is file
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                '----------------------------------------------------------------------------------
                'Declare file info object
                Dim file As New IO.FileInfo(e.Data.GetData(DataFormats.FileDrop)(0))

                'Verify if file is .xml
                If file.Extension = ".json" Then
                    '------------------------------------------------------------------------------
                    'Set file
                    setFile("Course", e.Data.GetData(DataFormats.FileDrop)(0))
                    '------------------------------------------------------------------------------
                Else
                    '------------------------------------------------------------------------------
                    'Display message
                    Me.lblStatus.Text = "Input file is not a json file"
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
        'Check if drag event args is file
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            '--------------------------------------------------------------------------------------
            'Use copy as drag & drop effect
            e.Effect = DragDropEffects.Copy
            '--------------------------------------------------------------------------------------
        End If
        '------------------------------------------------------------------------------------------
    End Sub

#End Region

#Region "Subs"

    '-- Data

    Shared Sub editDataValue(ByVal dsDataSet As DataSet, ByVal strDataTable As String, ByVal intDataColumn As Integer, ByVal objDataValue As Object)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare objects and variables
            Dim dtDataTable As DataTable = dsDataSet.Tables(strDataTable)
            Dim drDataRow As DataRow = dtDataTable.Rows(0)
            Dim strDataValue As String = ""

            'Check if ID column is not null
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
                    drDataRow(dsDataSet.Tables(strDataTable).Columns(intDataColumn)) = ""
                End If
                '----------------------------------------------------------------------------------
            End If

            'Add new row permanently in data table
            dsDataSet.AcceptChanges()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            FormMain.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Initialization

    Public Sub setInitialization()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Initialize
            setPropertySettings()
            readFileSettings()
            setControlSettings()
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
            'Verify file settings
            If Properties.ValidateFileSettings = False Then Exit Sub
            '--------------------------------------------------------------------------------------
            'Set variable
            Dim strDataTable As String = String.Empty

            'Set directory default properties
            strDataTable = "DirectoryDefault"
            Select Case Me.dsSettings.Tables(strDataTable).Rows.Count
                '----------------------------------------------------------------------------------
                Case 1
                    '------------------------------------------------------------------------------
                    'Validate folders
                    If getFolderExists(Me.dsSettings.Tables(strDataTable).Rows(0)("DirectoryDefaultMapEditor")) Then
                        '--------------------------------------------------------------------------
                        Properties.DirectoryDefaultMapEditor = Me.dsSettings.Tables(strDataTable).Rows(0)("DirectoryDefaultMapEditor")
                        '--------------------------------------------------------------------------
                    Else
                        '--------------------------------------------------------------------------
                        Properties.DirectoryDefaultMapEditor = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                        '--------------------------------------------------------------------------
                    End If
                    If getFolderExists(Me.dsSettings.Tables(strDataTable).Rows(0)("DirectoryDefaultCourse")) Then
                        '--------------------------------------------------------------------------
                        Properties.DirectoryDefaultCourse = Me.dsSettings.Tables(strDataTable).Rows(0)("DirectoryDefaultCourse")
                        '--------------------------------------------------------------------------
                    Else
                        '--------------------------------------------------------------------------
                        Properties.DirectoryDefaultCourse = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                        '--------------------------------------------------------------------------
                    End If
                    '------------------------------------------------------------------------------
                Case Else
                    '------------------------------------------------------------------------------
                    'Set default in case no entry found
                    Properties.DirectoryDefaultMapEditor = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                    Properties.DirectoryDefaultCourse = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                    '------------------------------------------------------------------------------
            End Select

            'Set default directories
            Me.txtDirectoryDefaultMapEditor.Text = Properties.DirectoryDefaultMapEditor
            Me.txtDirectoryDefaultCourse.Text = Properties.DirectoryDefaultCourse
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

    Public Sub saveFile(ByVal strOutput As String, ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare and initialize StreamWriter
            Dim swOutputFile As New IO.StreamWriter(strPath, False, New UTF8Encoding(False))

            'Write content to file
            swOutputFile.Write(strOutput)

            'Close StreamWriter
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
            'Declare and initialize StreamWriter
            Dim swOutputFile As New IO.StreamWriter(strPath, False, New UTF8Encoding(False))

            'Declare variables
            Dim intOutputFileCounter As Integer

            'Loop through array and write content to file
            For intOutputFileCounter = 0 To strOutput.GetUpperBound(0)
                '----------------------------------------------------------------------------------
                swOutputFile.WriteLine(strOutput(intOutputFileCounter))
                '----------------------------------------------------------------------------------
            Next

            'Close StreamWriter
            swOutputFile.Close()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Public Sub setFile(ByVal strFileType As String, ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            Select Case strFileType
                Case = "Map Editor"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileMapEditor = strPath

                    'Assign file name to textbox
                    Me.txtMapEditorFileName.Text = Properties.FileMapEditor

                    'Read data
                    Me.dsMapEditor.Reset()
                    Me.dsMapEditor.ReadXml(strPath)

                    'Display status
                    Me.lblStatus.Text = strFileType & " file loaded"
                    '------------------------------------------------------------------------------
                Case = "Course"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileCourse = strPath

                    'Assign file name to textbox
                    Me.txtSpecifyCourseFileName.Text = Properties.FileCourse

                    'Check radio button
                    Me.rdbSpecifyFileName.Checked = True

                    'Display status
                    Me.lblStatus.Text = strFileType & " file path specified"
                    '------------------------------------------------------------------------------
            End Select

            'Set control display settings
            setControlDisplaySettings("Toolbar")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Menu and Status Control

    Public Sub setControlDisplaySettings(ByVal strControlDisplaySettings As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            Select Case strControlDisplaySettings
                Case = ""
                    '------------------------------------------------------------------------------
                    '------------------------------------------------------------------------------
                Case = "Toolbar"
                    '------------------------------------------------------------------------------
                    'Set control properties
                    If Properties.FileMapEditor <> "" Or Properties.FileCourse <> "" Then Me.tlbClearAll.Enabled = True Else Me.tlbClearAll.Enabled = False
                    If Properties.FileMapEditor <> "" AndAlso Properties.FileCourse <> "" Then Me.tlbStart.Enabled = True Else Me.tlbStart.Enabled = False
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

    '-- Settings

    Public Sub readFileSettings()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Verify if config file exist
            If getFileExists(Properties.FileSettings) = True Then
                '----------------------------------------------------------------------------------
                'Read configuration
                Me.dsSettings.Reset()
                Me.dsSettings.ReadXml(Properties.FileSettings)
                '----------------------------------------------------------------------------------
            Else
                '----------------------------------------------------------------------------------
                Throw New System.Exception("MissingConfigFile")
                '----------------------------------------------------------------------------------
            End If

            'Set validation flag
            Properties.ValidateFileSettings = True
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            'Set validation flag
            Properties.ValidateFileSettings = False

            'Disable controls
            Me.grbMapEditor.Enabled = False
            Me.grbCourse.Enabled = False
            Me.grbDefaultDirectories.Enabled = False

            'Display status
            Me.lblStatus.Text = "Configuration file does not exist. Please reinstall " & Properties.InfoVersion & "."
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

#End Region

End Class