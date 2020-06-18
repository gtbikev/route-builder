Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports System.Xml

Public Class Configuration

    Shared Sub readConfiguration()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Read configuration
            FileSystem.openFile(FormMain.dsSettings, Properties.FileSettings)
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub setControlSettings()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set application name and version
            FormMain.Text = Properties.InfoVersion
            '--------------------------------------------------------------------------------------
            'Verify file valid
            If Properties.ValidInputFile = False Then Exit Sub
            '--------------------------------------------------------------------------------------
            'Set Settings
            FormMain.chkDebugShowWindow.Checked = Properties.DebugShowWindow
            FormMain.chkGenerateFileName.Checked = Properties.DefaultGenerateFileName
            FormMain.chkEnableOffsets.Checked = Properties.OffsetEnabled
            FormMain.nudXOffset.Value = Properties.XOffset
            FormMain.nudYOffset.Value = Properties.YOffset
            FormMain.nudZOffset.Value = Properties.ZOffset
            FormMain.txtDefaultDirectoryMapEditor.Text = Properties.DefaultDirectoryMapEditor
            FormMain.txtDefaultDirectoryCourse.Text = Properties.DefaultDirectoryCourse
            '--------------------------------------------------------------------------------------
            'Set control display properties
            WinFormControls.setControlDisplayProperties("init")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub setCulture()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set user interface culture
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US", True)
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub setDefaults()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set application properties
            Properties.InfoAssemblyName = My.Application.Info.AssemblyName
            Properties.InfoDirectoryPath = My.Application.Info.DirectoryPath
            Properties.InfoUrlHelp = "https://github.com/gtbikev/docs/blob/master/route-builder/INDEX.md"
            Properties.InfoUrlSendFeedback = "https://github.com/gtbikev/route-builder/issues"
            Properties.InfoVersion = My.Application.Info.ProductName & " " & System.Windows.Forms.Application.ProductVersion

            'Set file properties
            Properties.FileSettings = Properties.InfoDirectoryPath & "\" & Properties.InfoAssemblyName & ".config"
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub setInitialization()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Initialize
            Configuration.setCulture()
            Configuration.setDefaults()
            Configuration.readConfiguration()
            Configuration.setProperties()
            Configuration.setControlSettings()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub setProperties()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set variables
            Dim blnValidateBoolean As Boolean = False
            Dim decValidateDecimal As Decimal = 0.000
            Dim strDataTable As String = Nothing
            '--------------------------------------------------------------------------------------
            'Set default file name properties
            strDataTable = "Debug"
            Select Case FormMain.dsSettings.Tables(strDataTable).Rows.Count
                Case 1
                    '------------------------------------------------------------------------------
                    'Validate boolean
                    If Boolean.TryParse(FormMain.dsSettings.Tables(strDataTable).Rows(0)("ShowWindow"), blnValidateBoolean) Then
                        '--------------------------------------------------------------------------
                        Properties.DebugShowWindow = FormMain.dsSettings.Tables(strDataTable).Rows(0)("ShowWindow")
                        '--------------------------------------------------------------------------
                    End If
                    '------------------------------------------------------------------------------
                Case Else
                    '------------------------------------------------------------------------------
                    'Set default in case no entry found
                    Properties.DebugShowWindow = False
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
            'Set default file name properties
            strDataTable = "Defaults"
            Select Case FormMain.dsSettings.Tables(strDataTable).Rows.Count
                Case 1
                    '------------------------------------------------------------------------------
                    'Validate boolean
                    If Boolean.TryParse(FormMain.dsSettings.Tables(strDataTable).Rows(0)("GenerateFileName"), blnValidateBoolean) Then
                        '--------------------------------------------------------------------------
                        Properties.DefaultGenerateFileName = FormMain.dsSettings.Tables(strDataTable).Rows(0)("GenerateFileName")
                        '--------------------------------------------------------------------------
                    End If
                    '------------------------------------------------------------------------------
                Case Else
                    '------------------------------------------------------------------------------
                    'Set default in case no entry found
                    Properties.DefaultGenerateFileName = False
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
            'Set default directory properties
            strDataTable = "Defaults"
            Select Case FormMain.dsSettings.Tables(strDataTable).Rows.Count
                '----------------------------------------------------------------------------------
                Case 1
                    '------------------------------------------------------------------------------
                    'Validate folders
                    If FileSystem.getFolderExists(FormMain.dsSettings.Tables(strDataTable).Rows(0)("DirectoryMapEditor")) Then
                        '--------------------------------------------------------------------------
                        Properties.DefaultDirectoryMapEditor = FormMain.dsSettings.Tables(strDataTable).Rows(0)("DirectoryMapEditor")
                        '--------------------------------------------------------------------------
                    Else
                        '--------------------------------------------------------------------------
                        Properties.DefaultDirectoryMapEditor = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                        '--------------------------------------------------------------------------
                    End If
                    If FileSystem.getFolderExists(FormMain.dsSettings.Tables(strDataTable).Rows(0)("DirectoryCourse")) Then
                        '--------------------------------------------------------------------------
                        Properties.DefaultDirectoryCourse = FormMain.dsSettings.Tables(strDataTable).Rows(0)("DirectoryCourse")
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
            '--------------------------------------------------------------------------------------
            'Set offset properties
            strDataTable = "Offsets"
            Select Case FormMain.dsSettings.Tables(strDataTable).Rows.Count
                Case 1
                    '------------------------------------------------------------------------------
                    'Validate boolean
                    If Boolean.TryParse(FormMain.dsSettings.Tables(strDataTable).Rows(0)("Enabled"), blnValidateBoolean) Then
                        '--------------------------------------------------------------------------
                        Properties.OffsetEnabled = FormMain.dsSettings.Tables(strDataTable).Rows(0)("Enabled")
                        '--------------------------------------------------------------------------
                    End If
                    'Validate decimal
                    If Decimal.TryParse(FormMain.dsSettings.Tables(strDataTable).Rows(0)("X"), decValidateDecimal) Then
                        '--------------------------------------------------------------------------
                        Properties.XOffset = CDec(FormMain.dsSettings.Tables(strDataTable).Rows(0)("X"))
                        '--------------------------------------------------------------------------
                    End If
                    If Decimal.TryParse(FormMain.dsSettings.Tables(strDataTable).Rows(0)("Y"), decValidateDecimal) Then
                        '--------------------------------------------------------------------------
                        Properties.YOffset = CDec(FormMain.dsSettings.Tables(strDataTable).Rows(0)("Y"))
                        '--------------------------------------------------------------------------
                    End If
                    If Decimal.TryParse(FormMain.dsSettings.Tables(strDataTable).Rows(0)("Z"), decValidateDecimal) Then
                        '--------------------------------------------------------------------------
                        Properties.ZOffset = CDec(FormMain.dsSettings.Tables(strDataTable).Rows(0)("Z"))
                        '--------------------------------------------------------------------------
                    End If
                    '------------------------------------------------------------------------------
                Case Else
                    '------------------------------------------------------------------------------
                    'Set offset in case no entry found
                    Properties.OffsetEnabled = False
                    Properties.XOffset = 0.000
                    Properties.YOffset = 0.000
                    Properties.ZOffset = 0.000
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

End Class

Public Class ConvertRoute

    Shared Function createCourse() As String()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare array
            Dim strJson(1000000) As String

            'Declare variables
            Dim intRowCounter As Integer = 0
            Dim intDataCounter As Integer = 0
            Dim intDataIndex As Integer = FormMain.dsMapEditor.Tables("Position").Rows.Count - 1
            Dim strWaypointPositionX As String = String.Empty
            Dim strWaypointPositionY As String = String.Empty
            Dim strWaypointPositionZ As String = String.Empty
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
            strJson(intRowCounter) = strWhitespace & Chr(34) & "Name" & Chr(34) & ": " & Chr(34) & FormMain.dsMapEditor.Tables("Metadata").Rows(0)("Name") & Chr(34) & "," : intRowCounter = intRowCounter + 1

            'Add start point
            strJson(intRowCounter) = strWhitespace & Chr(34) & "StartPoint" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1

            'Add position
            strJson(intRowCounter) = strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(0)("X") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(0)("Y") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(0)("Z") : intRowCounter = intRowCounter + 1

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & "}," : intRowCounter = intRowCounter + 1

            'Set output message
            Output.setOutputMessage("Course -> main element added")
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
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(1)("X") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(1)("Y") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(1)("Z") : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1

            'Add Rotation
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Rotation" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & "0.0" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1

            'Set output message
            Output.setOutputMessage("Course -> start banner added")
            '--------------------------------------------------------------------------------------
            'Add open bracket
            strJson(intRowCounter) = strWhitespace & strWhitespace & "{" : intRowCounter = intRowCounter + 1

            'Add finish banner
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Name" & Chr(34) & ": " & Chr(34) & "prop_tri_finish_banner" & Chr(34) & "," : intRowCounter = intRowCounter + 1

            'Add Position
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Position" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(intDataIndex)("X") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(intDataIndex)("Y") & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & FormMain.dsMapEditor.Tables("Position").Rows(intDataIndex)("Z") : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1

            'Add Rotation
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Rotation" & Chr(34) & ": {" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & "0.0" & "," : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & "0.0" : intRowCounter = intRowCounter + 1
            strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1

            'Set output message
            Output.setOutputMessage("Course -> end banner added")

            'Add close bracket
            strJson(intRowCounter) = strWhitespace & "]," : intRowCounter = intRowCounter + 1
            '======================================================================================
            'WayPointList"
            '======================================================================================
            'Add props
            strJson(intRowCounter) = strWhitespace & Chr(34) & "WayPointList" & Chr(34) & ": [" : intRowCounter = intRowCounter + 1
            '--------------------------------------------------------------------------------------
            For Each drPosition As DataRow In FormMain.dsMapEditor.Tables("Position").Rows
                '----------------------------------------------------------------------------------
                'Set waypoint position
                strWaypointPositionX = FormMain.dsMapEditor.Tables("Position").Rows(intDataCounter)("X")
                strWaypointPositionY = FormMain.dsMapEditor.Tables("Position").Rows(intDataCounter)("Y")
                strWaypointPositionZ = FormMain.dsMapEditor.Tables("Position").Rows(intDataCounter)("Z")

                'Set waypoint offset
                If Properties.OffsetEnabled = True Then
                    '------------------------------------------------------------------------------
                    strWaypointPositionX = (CDec(strWaypointPositionX) + Properties.XOffset).ToString
                    strWaypointPositionY = (CDec(strWaypointPositionY) + Properties.YOffset).ToString
                    strWaypointPositionZ = (CDec(strWaypointPositionZ) + Properties.ZOffset).ToString
                    '------------------------------------------------------------------------------
                End If

                'Add position
                Select Case intDataCounter
                    Case 2 To (intDataIndex - 2)
                        '--------------------------------------------------------------------------
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "{" : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & strWaypointPositionX & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & strWaypointPositionY & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & strWaypointPositionZ : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "}," : intRowCounter = intRowCounter + 1
                        '--------------------------------------------------------------------------
                    Case (intDataIndex - 1)
                        '--------------------------------------------------------------------------
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "{" : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "X" & Chr(34) & ": " & strWaypointPositionX & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Y" & Chr(34) & ": " & strWaypointPositionY & "," : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & strWhitespace & Chr(34) & "Z" & Chr(34) & ": " & strWaypointPositionZ : intRowCounter = intRowCounter + 1
                        strJson(intRowCounter) = strWhitespace & strWhitespace & "}" : intRowCounter = intRowCounter + 1
                        '--------------------------------------------------------------------------
                End Select

                'Increase data counter
                intDataCounter = intDataCounter + 1
                '----------------------------------------------------------------------------------
            Next

            'Set output message
            Output.setOutputMessage("Course -> " & intDataCounter.ToString & " waypoints added")

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
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Shared Function generateCourseFileName() As String
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare course file name
            Dim strCourseFileName As String = Nothing

            'Verify if folder exists
            If FileSystem.getFolderExists(Properties.DefaultDirectoryCourse) = True Then
                '----------------------------------------------------------------------------------
                'Set course file name
                strCourseFileName = Properties.DefaultDirectoryCourse & "\" & Replace(FileSystem.getFileName(Properties.FileMapEditor), ".xml", ".json")
                '----------------------------------------------------------------------------------
            End If

            'Retrun string
            Return strCourseFileName
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

End Class

Public Class Data

    Shared Sub editDataValue(ByVal dsDataSet As DataSet, ByVal strDataTable As String, ByVal intDataColumn As Integer, ByVal objDataValue As Object)
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
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

End Class

Public Class ExceptionHandler

    Shared Sub logException(ByVal strLogEntryType As String, ByVal strCurrentMethod As String, ByVal strExceptionMessage As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare error message
            Dim strErrorMessage As String = strLogEntryType & " [" & strCurrentMethod & "] " & strExceptionMessage

            'Log exception
            Select Case strLogEntryType
                Case "ERROR"
                    '------------------------------------------------------------------------------
                    WinFormControls.setStatus(strErrorMessage)
                    Output.setOutputMessage(strErrorMessage, Color.Red)
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            WinFormControls.setStatus(strLogEntryType & " [" & MethodBase.GetCurrentMethod.Name & "] " & exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

End Class

Public Class FileSystem

    Shared Function getFileExists(ByVal strPath As String) As Boolean
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
            Return False
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Shared Function getFileName(ByVal strPath As String) As String
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare file info object
            Dim file As New IO.FileInfo(strPath)

            'Return string
            Return file.Name.ToString()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Shared Function getFolder(ByVal strPath As String) As String
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare file info object
            Dim file As New IO.FileInfo(strPath)

            'Return string
            Return file.Directory.ToString()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Shared Function getFolderExists(ByVal strPath As String) As Boolean
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

    Shared Sub openFile(ByVal dsDataSet As DataSet, ByVal strPath As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Read xml
            dsDataSet.Reset()
            dsDataSet.ReadXml(strPath)

            'Set file validation
            Properties.ValidInputFile = True

            'Set output message
            If strPath = Properties.FileMapEditor Then Output.setOutputMessage("Map Editor -> '" & Properties.FileMapEditor & "'")
            '--------------------------------------------------------------------------------------
        Catch fnf As FileNotFoundException
            '--------------------------------------------------------------------------------------
            'Set file validation
            Properties.ValidInputFile = False

            'Set exception handling 
            Select Case strPath
                Case = Properties.FileMapEditor
                    '------------------------------------------------------------------------------
                    Dim strStatus As String = "Map editor file '" & getFileName(Properties.FileMapEditor) & "' does not exist."
                    Output.setOutputMessage(strStatus, Color.Red)
                    WinFormControls.setStatus(strStatus)
                    '------------------------------------------------------------------------------
                Case = Properties.FileSettings
                    '------------------------------------------------------------------------------
                    'Set control display properties
                    WinFormControls.setControlDisplayProperties("invalidConfiguration")

                    'Log exception
                    ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, "Configuration file '" & getFileName(Properties.FileSettings) & "' does not exist.")
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
                    ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, "Invalid map editor file. Please verify content of file '" & getFileName(strPath) & "'.")
                    '------------------------------------------------------------------------------
                Case = Properties.FileSettings
                    '------------------------------------------------------------------------------
                    'Set control display properties
                    WinFormControls.setControlDisplayProperties("invalidConfiguration")

                    'Log exception
                    ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, "Invalid configuration file. Please verify content of file '" & getFileName(strPath) & "'.")
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub saveFile(ByVal strOutput As String, ByVal strPath As String)
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
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub saveFile(ByVal strOutput As String(), ByVal strPath As String)
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

            'Set output message
            Output.setOutputMessage("Course '" & FileSystem.getFileName(Properties.FileCourse) & "' created")
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

End Class

Public Class Output

    Shared Function getOutputFooter(ByVal strFooterText As String) As String
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare line
            Dim strLine As String = getOutputLine("=", 5)

            'Set footer
            Dim strOutputFooter As String = strLine & " " & strFooterText & " " & strLine & ControlChars.CrLf

            'Return string
            Return strOutputFooter
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Shared Function getOutputHeader(ByVal strHeaderText As String) As String
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare line
            Dim strLine As String = getOutputLine("-", 10)

            'Set header
            Dim strOutputHeader As String = strLine & " " & strHeaderText & " " & strLine

            'Return string
            Return strOutputHeader
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Shared Function getOutputLine(ByVal strChar As String, ByVal intRepeat As Integer) As String
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set line
            Dim strLine As String = New String(strChar, intRepeat)

            'Return string
            Return strLine
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            Return Nothing
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Function

    Shared Sub setOutputMessage(ByVal strAppendText As String, Optional ByVal colColor As Color = Nothing)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Declare control
            Dim ctlRichTextBox As RichTextBox = FormMain.rtfOutput

            'Set default color
            If colColor = Nothing Then colColor = Color.Black

            'Add CrLf to text
            strAppendText = strAppendText & ControlChars.CrLf

            'Append colored text
            ctlRichTextBox.SelectionColor = colColor
            ctlRichTextBox.AppendText(strAppendText)

            'Commit append
            ctlRichTextBox.Update()

            'Scroll to the end
            ctlRichTextBox.SelectionStart = ctlRichTextBox.TextLength
            ctlRichTextBox.ScrollToCaret()
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

End Class

Public Class WinFormControls

    Shared Sub setControlDisplayProperties(ByVal strControl As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set control display properties (backcolor, checked, enabled, visible)
            Select Case strControl
                Case = "chkShowDebugWindow"
                    '------------------------------------------------------------------------------
                    Select Case Properties.DebugShowWindow
                        Case = True
                            '----------------------------------------------------------------------
                            FormMain.spcConvertRoute.Panel2Collapsed = False
                            '----------------------------------------------------------------------
                        Case = False
                            '----------------------------------------------------------------------
                            FormMain.spcConvertRoute.Panel2Collapsed = True
                            '----------------------------------------------------------------------
                    End Select
                    '------------------------------------------------------------------------------
                Case = "chkEnableOffsets"
                    '------------------------------------------------------------------------------
                    FormMain.nudXOffset.Enabled = Properties.OffsetEnabled
                    FormMain.nudYOffset.Enabled = Properties.OffsetEnabled
                    FormMain.nudZOffset.Enabled = Properties.OffsetEnabled
                    '------------------------------------------------------------------------------
                Case = "init"
                    '------------------------------------------------------------------------------
                    WinFormControls.setControlDisplayProperties("chkShowDebugWindow")
                    WinFormControls.setControlDisplayProperties("chkEnableOffsets")
                    WinFormControls.setControlDisplayProperties("tlsMain")
                    WinFormControls.setControlDisplayProperties("tvwSettings")
                    '------------------------------------------------------------------------------
                Case = "invalidConfiguration"
                    '------------------------------------------------------------------------------
                    FormMain.grbMapEditor.Enabled = False
                    FormMain.grbCourse.Enabled = False
                    FormMain.grbDefaultFileName.Enabled = False
                    FormMain.grbDefaultDirectories.Enabled = False
                    '------------------------------------------------------------------------------
                Case = "tlsMain"
                    '------------------------------------------------------------------------------
                    If Properties.FileMapEditor IsNot Nothing Or Properties.FileCourse IsNot Nothing Then FormMain.tlbReset.Enabled = True Else FormMain.tlbReset.Enabled = False
                    If Properties.FileMapEditor IsNot Nothing AndAlso Properties.FileCourse IsNot Nothing Then FormMain.tlbStart.Enabled = True Else FormMain.tlbStart.Enabled = False
                    '------------------------------------------------------------------------------
                Case = "tvwSettings"
                    '------------------------------------------------------------------------------
                    If FormMain.tvwSettings.SelectedNode Is Nothing Then Exit Sub
                    Select Case FormMain.tvwSettings.SelectedNode.Text
                        Case = "Debug"
                            '----------------------------------------------------------------------
                            FormMain.pnlSettingsDebug.BringToFront()
                            '----------------------------------------------------------------------
                        Case = "Defaults"
                            '----------------------------------------------------------------------
                            FormMain.pnlSettingsDefaults.BringToFront()
                            '----------------------------------------------------------------------
                        Case = "Offsets"
                            '----------------------------------------------------------------------
                            FormMain.pnlSettingsOffsets.BringToFront()
                            '----------------------------------------------------------------------
                    End Select
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub setElementData()
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Open map editor file
            FileSystem.openFile(FormMain.dsElements, Properties.FileMapEditor)

            'Clear treeview
            FormMain.tvwDataset.Nodes.Clear()
            '--------------------------------------------------------------------------------------
            'Populate element data tables
            For Each dtTables In FormMain.dsElements.Tables()
                '----------------------------------------------------------------------------------
                FormMain.tvwDataset.Nodes.Add(dtTables.TableName.ToString)
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

    Shared Sub setFileProperties(ByVal strControl As String, Optional ByVal strPath As String = Nothing)
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
                    FormMain.txtMapEditorFileName.Text = Properties.FileMapEditor

                    'Verify if generate file name is checked
                    If Properties.DefaultGenerateFileName = True Then
                        '--------------------------------------------------------------------------
                        'Set property
                        Properties.FileCourse = ConvertRoute.generateCourseFileName()

                        'Set textbox
                        FormMain.txtCourseFileName.Text = Properties.FileCourse

                        'Set output message
                        Output.setOutputMessage("Course -> " & Properties.FileCourse)
                        '--------------------------------------------------------------------------
                    End If

                    'Set status
                    WinFormControls.setStatus("Map Editor file specified")
                    '------------------------------------------------------------------------------
                Case = "btnSaveCourseFile_Click", "txtCourseFileName_DragDrop"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileCourse = strPath

                    'Set textbox
                    FormMain.txtCourseFileName.Text = Properties.FileCourse

                    'Set output message
                    Output.setOutputMessage("Course -> " & Properties.FileCourse)

                    'Set status
                    WinFormControls.setStatus("Course file specified")
                    '------------------------------------------------------------------------------
                Case = "btnSetCourseDirectory_Click"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.FileCourse = ConvertRoute.generateCourseFileName()

                    'Set textbox
                    FormMain.txtCourseFileName.Text = Properties.FileCourse

                    'Set output message
                    Output.setOutputMessage("Course -> " & Properties.FileCourse)
                    '------------------------------------------------------------------------------
                Case = "tlbReset_Click"
                    '------------------------------------------------------------------------------
                    'Clear properties
                    Properties.FileMapEditor = Nothing
                    Properties.FileCourse = Nothing

                    'Set textbox
                    FormMain.txtMapEditorFileName.Text = Properties.FileMapEditor
                    FormMain.txtCourseFileName.Text = Properties.FileCourse

                    'Set control display properties
                    WinFormControls.setControlDisplayProperties("tlbReset")

                    'Set output message
                    Output.setOutputMessage("Map Editor File -> Reset")
                    Output.setOutputMessage("Course File -> Reset")

                    'Set status
                    WinFormControls.setStatus("Reset done")
                    '------------------------------------------------------------------------------
            End Select

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

    Shared Sub setFolderProperties(ByVal strControl As String, ByVal strPath As String)
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
                    Data.editDataValue(FormMain.dsSettings, "Defaults", 0, objDefaultDirectoryCourse)

                    'Save settings file
                    FileSystem.saveFile(FormMain.dsSettings.GetXml(), Properties.FileSettings)

                    'Set textbox
                    FormMain.txtDefaultDirectoryCourse.Text = Properties.DefaultDirectoryCourse

                    'Set file properties
                    If Properties.FileMapEditor IsNot Nothing AndAlso Properties.DefaultGenerateFileName = True Then setFileProperties(strControl)

                    'Set output message
                    Output.setOutputMessage("Course Directory -> '" & Properties.DefaultDirectoryCourse & "'")

                    'Set status
                    WinFormControls.setStatus("Default course directory specified")
                    '------------------------------------------------------------------------------
                Case = "btnSetMapEditorDirectory_Click"
                    '------------------------------------------------------------------------------
                    'Set property
                    Properties.DefaultDirectoryMapEditor = strPath

                    'Update data
                    Dim objDefaultDirectoryMapEditor As Object = Properties.DefaultDirectoryMapEditor
                    Data.editDataValue(FormMain.dsSettings, "Defaults", 1, objDefaultDirectoryMapEditor)

                    'Save settings file
                    FileSystem.saveFile(FormMain.dsSettings.GetXml(), Properties.FileSettings)

                    'Set textbox
                    FormMain.txtDefaultDirectoryMapEditor.Text = Properties.DefaultDirectoryMapEditor

                    'Set output message
                    Output.setOutputMessage("Map Editor Directory -> '" & Properties.DefaultDirectoryMapEditor & "'")

                    'Set status
                    WinFormControls.setStatus("Default map editor directory specified")
                    '------------------------------------------------------------------------------
            End Select
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            ExceptionHandler.logException("ERROR", MethodBase.GetCurrentMethod.Name, exp.Message)
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Shared Sub setStatus(ByVal strMessage As String)
        '------------------------------------------------------------------------------------------
        Try
            '--------------------------------------------------------------------------------------
            'Set status
            FormMain.tssStatus.Text = strMessage
            '--------------------------------------------------------------------------------------
        Catch exp As Exception
            '--------------------------------------------------------------------------------------
            FormMain.tssStatus.Text = "ERROR [" & MethodBase.GetCurrentMethod.Name & "] " & exp.Message
            '--------------------------------------------------------------------------------------
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

End Class