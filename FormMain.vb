Imports System.Text

Public Class FormMain

#Region "Constants"

    Public dsMapEditor As New DataSet("MapEditor")

#End Region

#Region "Functions"

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

#End Region

#Region "Events"

    '-- Button

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Clear map textboxes
            Me.txtMapEditor.Text = ""
            Me.txtCourse.Text = ""

            'Set control display settings
            setControlDisplaySettings()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set hourglass cursor
            Me.Cursor = Cursors.WaitCursor

            'Create course
            Dim strOutput As String() = createCourse()

            'Save file
            saveFile(strOutput, Me.txtCourse.Text)

            'Display status
            Me.lblStatus.Text = "Course file created"
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

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set hourglass cursor
            Me.Cursor = Cursors.WaitCursor

            'Declare variable
            Dim strInitialDirectory As String = Environment.SpecialFolder.MyDocuments

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
                'Open file
                openFile("Map Editor", Me.OpenFileDialog.FileName)
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set hourglass cursor
            Me.Cursor = Cursors.WaitCursor

            'Declare variables
            Dim dsDataSet As DataSet = Nothing
            Dim strInitialDirectory As String = Environment.SpecialFolder.MyDocuments

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
                'Open file
                openFile("Course", Me.SaveFileDialog.FileName)
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

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set application name and version
            Me.lblApplication.Text = My.Application.Info.ProductName & " " & System.Windows.Forms.Application.ProductVersion

            'Set control display settings
            setControlDisplaySettings()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Me.lblStatus.Text = "An error occurred: " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    '-- Textbox

    Private Sub txtCourse_DragDrop(sender As Object, e As DragEventArgs) Handles txtCourse.DragDrop
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
                    'Open file
                    openFile("Course", e.Data.GetData(DataFormats.FileDrop)(0))
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

    Private Sub txtCourse_DragEnter(sender As Object, e As DragEventArgs) Handles txtCourse.DragEnter
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

    Private Sub txtMapEditor_DragDrop(sender As Object, e As DragEventArgs) Handles txtMapEditor.DragDrop
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
                    'Open file
                    openFile("Map Editor", e.Data.GetData(DataFormats.FileDrop)(0))
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

    Private Sub txtMapEditor_DragEnter(sender As Object, e As DragEventArgs) Handles txtMapEditor.DragEnter
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

    Public Sub openFile(ByVal strFileType As String, ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            Select Case strFileType
                Case = "Map Editor"
                    '------------------------------------------------------------------------------
                    'Assign file name to textbox
                    Me.txtMapEditor.Text = strPath

                    'Reset Dataset
                    Me.dsMapEditor.Reset()

                    'Read data
                    Me.dsMapEditor.ReadXml(strPath)

                    'Display status
                    Me.lblStatus.Text = strFileType & " file loaded"
                    '------------------------------------------------------------------------------
                Case = "Course"
                    '------------------------------------------------------------------------------
                    'Assign file name to textbox
                    Me.txtCourse.Text = strPath

                    'Display status
                    Me.lblStatus.Text = strFileType & " file path specified"
                    '------------------------------------------------------------------------------
            End Select

            'Set control display settings
            setControlDisplaySettings()
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

    Public Sub setControlDisplaySettings()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set control properties
            If Me.txtMapEditor.Text <> "" AndAlso Me.txtCourse.Text <> "" Then Me.btnCreate.Enabled = True Else Me.btnCreate.Enabled = False
            If Me.txtMapEditor.Text <> "" Or Me.txtCourse.Text <> "" Then Me.btnClear.Enabled = True Else Me.btnClear.Enabled = False
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