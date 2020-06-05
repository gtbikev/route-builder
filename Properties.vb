Public Class Properties

    '-- Application Info
    Protected Shared strInfoAssemblyName As String
    Protected Shared strInfoDirectoryPath As String
    Protected Shared strInfoUrlAbout As String
    Protected Shared strInfoUrlSendFeedback As String
    Protected Shared strInfoVersion As String

    Shared Property InfoAssemblyName() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strInfoAssemblyName
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strInfoAssemblyName = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property InfoDirectoryPath() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strInfoDirectoryPath
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strInfoDirectoryPath = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property InfoUrlAbout() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strInfoUrlAbout
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strInfoUrlAbout = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property InfoUrlSendFeedback() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strInfoUrlSendFeedback
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strInfoUrlSendFeedback = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property InfoVersion() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strInfoVersion
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strInfoVersion = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    '-- Control
    Protected Shared blnControlGenerateFileChecked As Boolean

    Shared Property ControlGenerateFileChecked() As Boolean
        '--------------------------------------------------------------------------------------
        Get
            Return blnControlGenerateFileChecked
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal blnValue As Boolean)
            blnControlGenerateFileChecked = blnValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    '-- Directory
    Protected Shared strDirectoryDefaultMapEditor As String
    Protected Shared strDirectoryDefaultCourse As String

    Shared Property DirectoryDefaultCourse() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strDirectoryDefaultCourse
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strDirectoryDefaultCourse = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property DirectoryDefaultMapEditor() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strDirectoryDefaultMapEditor
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strDirectoryDefaultMapEditor = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    '-- File
    Protected Shared strFileCourse As String
    Protected Shared strFileMapEditor As String
    Protected Shared strFileSettings As String

    Shared Property FileCourse() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strFileCourse
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strFileCourse = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property FileMapEditor() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strFileMapEditor
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strFileMapEditor = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property FileSettings() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strFileSettings
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strFileSettings = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    '-- Validation
    Protected Shared blnValidateFileSettings As Boolean

    Shared Property ValidateFileSettings() As Boolean
        '--------------------------------------------------------------------------------------
        Get
            Return blnValidateFileSettings
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal blnValue As Boolean)
            blnValidateFileSettings = blnValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property
End Class
