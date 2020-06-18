Public Class Properties

    '-- Application Info
    Protected Shared strInfoAssemblyName As String
    Protected Shared strInfoDirectoryPath As String
    Protected Shared strInfoUrlHelp As String
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

    Shared Property InfoUrlHelp() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strInfoUrlHelp
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strInfoUrlHelp = strValue
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

    '-- Settings
    Protected Shared blnDebugShowWindow As Boolean
    Protected Shared blnDefaultGenerateFileName As Boolean
    Protected Shared blnOffsetEnabled As Boolean
    Protected Shared decXOffset As Decimal
    Protected Shared decYOffset As Decimal
    Protected Shared decZOffset As Decimal
    Protected Shared strDefaultDefaultDirectoryCourse As String
    Protected Shared strDefaultDirectoryMapEditor As String

    Shared Property DebugShowWindow() As Boolean
        '--------------------------------------------------------------------------------------
        Get
            Return blnDebugShowWindow
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal blnValue As Boolean)
            blnDebugShowWindow = blnValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property DefaultGenerateFileName() As Boolean
        '--------------------------------------------------------------------------------------
        Get
            Return blnDefaultGenerateFileName
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal blnValue As Boolean)
            blnDefaultGenerateFileName = blnValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property DefaultDirectoryCourse() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strDefaultDefaultDirectoryCourse
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strDefaultDefaultDirectoryCourse = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property DefaultDirectoryMapEditor() As String
        '--------------------------------------------------------------------------------------
        Get
            Return strDefaultDirectoryMapEditor
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal strValue As String)
            strDefaultDirectoryMapEditor = strValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property OffsetEnabled() As Boolean
        '--------------------------------------------------------------------------------------
        Get
            Return blnOffsetEnabled
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal blnValue As Boolean)
            blnOffsetEnabled = blnValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property XOffset() As Decimal
        '--------------------------------------------------------------------------------------
        Get
            Return decXOffset
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal decValue As Decimal)
            decXOffset = decValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property YOffset() As Decimal
        '--------------------------------------------------------------------------------------
        Get
            Return decYOffset
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal decValue As Decimal)
            decYOffset = decValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    Shared Property ZOffset() As Decimal
        '--------------------------------------------------------------------------------------
        Get
            Return decZOffset
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal decValue As Decimal)
            decZOffset = decValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

    '-- Validation
    Protected Shared blnValidInputFile As Boolean

    Shared Property ValidInputFile() As Boolean
        '--------------------------------------------------------------------------------------
        Get
            Return blnValidInputFile
        End Get
        '--------------------------------------------------------------------------------------
        Set(ByVal blnValue As Boolean)
            blnValidInputFile = blnValue
        End Set
        '--------------------------------------------------------------------------------------
    End Property

End Class
