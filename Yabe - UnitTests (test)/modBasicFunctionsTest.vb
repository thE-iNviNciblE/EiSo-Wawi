Imports System

Imports System.Collections

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "modBasicFunctionsTest" und soll
'''alle modBasicFunctionsTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class modBasicFunctionsTest


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
    '''Ein Test für "_Downloader_AmountDownloadedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub _Downloader_AmountDownloadedChangedTest()
        Dim iNewProgress As Long = 0 ' TODO: Passenden Wert initialisieren
        modBasicFunctions_Accessor._Downloader_AmountDownloadedChanged(iNewProgress)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "_Downloader_FileDownloadComplete"
    '''</summary>
    <TestMethod()> _
    Public Sub _Downloader_FileDownloadCompleteTest()
        modBasicFunctions._Downloader_FileDownloadComplete()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "_Downloader_FileDownloadSizeObtained"
    '''</summary>
    <TestMethod()> _
    Public Sub _Downloader_FileDownloadSizeObtainedTest()
        Dim iFileSize As Long = 0 ' TODO: Passenden Wert initialisieren
        modBasicFunctions._Downloader_FileDownloadSizeObtained(iFileSize)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AppPrevInstance"
    '''</summary>
    <TestMethod()> _
    Public Sub AppPrevInstanceTest()
        Dim bShowMsg As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim bAppActivate As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.AppPrevInstance(bShowMsg, bAppActivate)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkPing"
    '''</summary>
    <TestMethod()> _
    Public Sub chkPingTest()
        Dim strHost As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.chkPing(strHost)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CreateMyOpaqueForm"
    '''</summary>
    <TestMethod()> _
    Public Sub CreateMyOpaqueFormTest()
        modBasicFunctions.CreateMyOpaqueForm()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "debug_message"
    '''</summary>
    <TestMethod()> _
    Public Sub debug_messageTest()
        Dim strMessage As Exception = Nothing ' TODO: Passenden Wert initialisieren
        Dim strFunktion As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.debug_message(strMessage, strFunktion)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DropChar"
    '''</summary>
    <TestMethod()> _
    Public Sub DropCharTest()
        Dim sText As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iCharToDrop As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.DropChar(sText, iCharToDrop)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Encrypt"
    '''</summary>
    <TestMethod()> _
    Public Sub EncryptTest()
        Dim plainText As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.Encrypt(plainText)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GetFileNameFromURL"
    '''</summary>
    <TestMethod()> _
    Public Sub GetFileNameFromURLTest()
        Dim URL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.GetFileNameFromURL(URL)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getHTTPResponseMessage"
    '''</summary>
    <TestMethod()> _
    Public Sub getHTTPResponseMessageTest()
        Dim strURL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim mModus As modBasicFunctions.mgetUpdaterMessage = New modBasicFunctions.mgetUpdaterMessage ' TODO: Passenden Wert initialisieren
        Dim bMessage As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.getHTTPResponseMessage(strURL, mModus, bMessage)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getINI_Config"
    '''</summary>
    <TestMethod()> _
    Public Sub getINI_ConfigTest()
        Dim strFeldname As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strFeldwert As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.getINI_Config(strFeldname, strFeldwert)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getINI_Structure"
    '''</summary>
    <TestMethod()> _
    Public Sub getINI_StructureTest()
        Dim strFeldname As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strFeldwert As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.getINI_Structure(strFeldname, strFeldwert)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getPopUp"
    '''</summary>
    <TestMethod()> _
    Public Sub getPopUpTest()
        Dim strMessage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.getPopUp(strMessage)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getTranslateText"
    '''</summary>
    <TestMethod()> _
    Public Sub getTranslateTextTest()
        Dim TextToTranslate As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lngInput As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lngOutput As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.getTranslateText(TextToTranslate, lngInput, lngOutput)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getWMI"
    '''</summary>
    <TestMethod()> _
    Public Sub getWMITest()
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.getWMI
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ListviewToCSV"
    '''</summary>
    <TestMethod()> _
    Public Sub ListviewToCSVTest()
        Dim oLV As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim sFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bIncludeHidden As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim strCat As frmAuktionmanagement.export_targets = New frmAuktionmanagement.export_targets ' TODO: Passenden Wert initialisieren
        Dim mModus As modBasicFunctions.selectModus = New modBasicFunctions.selectModus ' TODO: Passenden Wert initialisieren
        Dim aryAuktion As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.ListviewToCSV(oLV, sFile, bIncludeHidden, strCat, mModus, aryAuktion)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "mciSendString"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub mciSendStringTest()
        Dim lpszCommand As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lpszCommandExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lpszReturnString As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lpszReturnStringExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim cchReturnLength As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim hwndCallback As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = modBasicFunctions_Accessor.mciSendString(lpszCommand, lpszReturnString, cchReturnLength, hwndCallback)
        Assert.AreEqual(lpszCommandExpected, lpszCommand)
        Assert.AreEqual(lpszReturnStringExpected, lpszReturnString)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MP3_Play"
    '''</summary>
    <TestMethod()> _
    Public Sub MP3_PlayTest()
        Dim sFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim sAlias As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.MP3_Play(sFile, sAlias)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MP3_Stop"
    '''</summary>
    <TestMethod()> _
    Public Sub MP3_StopTest()
        Dim sAlias As String = String.Empty ' TODO: Passenden Wert initialisieren
        modBasicFunctions.MP3_Stop(sAlias)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "printPopup"
    '''</summary>
    <TestMethod()> _
    Public Sub printPopupTest()
        Dim strNachricht As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.printPopup(strNachricht)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setBeschreibungsLänge"
    '''</summary>
    <TestMethod()> _
    Public Sub setBeschreibungsLängeTest()
        Dim strData As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iWords As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.setBeschreibungsLänge(strData, iWords)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setBR"
    '''</summary>
    <TestMethod()> _
    Public Sub setBRTest()
        Dim strData As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.setBR(strData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDecrypt_file"
    '''</summary>
    <TestMethod()> _
    Public Sub setDecrypt_fileTest()
        Dim strFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strKey As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bSetUpdate As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.setDecrypt_file(strFile, strKey, bSetUpdate)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setEncrypt_file"
    '''</summary>
    <TestMethod()> _
    Public Sub setEncrypt_fileTest()
        Dim strFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strKey As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bSetUpdate As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.setEncrypt_file(strFile, strKey, bSetUpdate)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setINI"
    '''</summary>
    <TestMethod()> _
    Public Sub setINITest()
        Dim strFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.setINI(strFile)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setLvwView_blättern"
    '''</summary>
    <TestMethod()> _
    Public Sub setLvwView_blätternTest()
        Dim mModus As modBasicFunctions.lvwBlättern_modus = New modBasicFunctions.lvwBlättern_modus ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim btnVor As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim btnBack As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim btnBackExpected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim txtID As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim txtIDExpected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.setLvwView_blättern(mModus, lvw, btnVor, btnBack, txtID)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(btnBackExpected, btnBack)
        Assert.AreEqual(txtIDExpected, txtID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setStopuhr"
    '''</summary>
    <TestMethod()> _
    Public Sub setStopuhrTest()
        Dim bModus As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.setStopuhr(bModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setUpdateCheck"
    '''</summary>
    <TestMethod()> _
    Public Sub setUpdateCheckTest()
        Dim pgrUpdate As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim lblUpdater As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.setUpdateCheck(pgrUpdate, lblUpdater)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setXML_write"
    '''</summary>
    <TestMethod()> _
    Public Sub setXML_writeTest()
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = modBasicFunctions.setXML_write
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "URLDecode"
    '''</summary>
    <TestMethod()> _
    Public Sub URLDecodeTest()
        Dim StringToDecode As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.URLDecode(StringToDecode)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "URLEncode"
    '''</summary>
    <TestMethod()> _
    Public Sub URLEncodeTest()
        Dim StringToEncode As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim UsePlusRatherThanHexForSpace As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = modBasicFunctions.URLEncode(StringToEncode, UsePlusRatherThanHexForSpace)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "XMLReader_INI"
    '''</summary>
    <TestMethod()> _
    Public Sub XMLReader_INITest()
        Dim strFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        modBasicFunctions.XMLReader_INI(strFile, strModus)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "XMLWriter_INI"
    '''</summary>
    <TestMethod()> _
    Public Sub XMLWriter_INITest()
        Dim strFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        modBasicFunctions.XMLWriter_INI(strFile)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "clsUpdateDownloader"
    '''</summary>
    <TestMethod()> _
    Public Sub clsUpdateDownloaderTest()
        Dim expected As WebFileDownloader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As WebFileDownloader
        modBasicFunctions.clsUpdateDownloader = expected
        actual = modBasicFunctions.clsUpdateDownloader
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
