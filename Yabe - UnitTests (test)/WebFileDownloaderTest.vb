Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "WebFileDownloaderTest" und soll
'''alle WebFileDownloaderTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class WebFileDownloaderTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Ruft den Testkontext auf, der Informationen
    '''über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Zusätzliche Testattribute"
    '
    'Sie können beim Verfassen Ihrer Tests die folgenden zusätzlichen Attribute verwenden:
    '
    'Mit ClassInitialize führen Sie Code aus, bevor Sie den ersten Test in der Klasse ausführen.
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Mit ClassCleanup führen Sie Code aus, nachdem alle Tests in einer Klasse ausgeführt wurden.
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen.
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''Ein Test für "WebFileDownloader-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub WebFileDownloaderConstructorTest()
        Dim target As WebFileDownloader = New WebFileDownloader
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "DownloadFile"
    '''</summary>
    <TestMethod()> _
    Public Sub DownloadFileTest()
        Dim target As WebFileDownloader = New WebFileDownloader ' TODO: Passenden Wert initialisieren
        Dim URL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim Location As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.DownloadFile(URL, Location)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DownloadFileWithProgress"
    '''</summary>
    <TestMethod()> _
    Public Sub DownloadFileWithProgressTest()
        Dim target As WebFileDownloader = New WebFileDownloader ' TODO: Passenden Wert initialisieren
        Dim URL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim Location As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.DownloadFileWithProgress(URL, Location)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FormatFileSize"
    '''</summary>
    <TestMethod()> _
    Public Sub FormatFileSizeTest()
        Dim Size As Long = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = WebFileDownloader.FormatFileSize(Size)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GetFileName"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub GetFileNameTest()
        Dim target As WebFileDownloader_Accessor = New WebFileDownloader_Accessor ' TODO: Passenden Wert initialisieren
        Dim URL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.GetFileName(URL)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CurrentFile"
    '''</summary>
    <TestMethod()> _
    Public Sub CurrentFileTest()
        Dim target As WebFileDownloader = New WebFileDownloader ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.CurrentFile
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
