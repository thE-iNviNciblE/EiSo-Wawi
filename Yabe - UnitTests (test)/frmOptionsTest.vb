Imports System

Imports DHTMLEDLib

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmOptionsTest" und soll
'''alle frmOptionsTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmOptionsTest


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
    '''Ein Test für "frmOptions-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmOptionsConstructorTest()
        Dim target As frmOptions = New frmOptions
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "_Downloader_AmountDownloadedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub _Downloader_AmountDownloadedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim iNewProgress As Long = 0 ' TODO: Passenden Wert initialisieren
        target._Downloader_AmountDownloadedChanged(iNewProgress)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "_Downloader_FileDownloadComplete"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub _Downloader_FileDownloadCompleteTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        target._Downloader_FileDownloadComplete()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "_Downloader_FileDownloadFailed"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub _Downloader_FileDownloadFailedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim ex As Exception = Nothing ' TODO: Passenden Wert initialisieren
        target._Downloader_FileDownloadFailed(ex)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "_Downloader_FileDownloadSizeObtained"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub _Downloader_FileDownloadSizeObtainedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim iFileSize As Long = 0 ' TODO: Passenden Wert initialisieren
        target._Downloader_FileDownloadSizeObtained(iFileSize)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "bEigeneBilder_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub bEigeneBilder_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.bEigeneBilder_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAdminPanelLogin_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnAdminPanelLogin_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnAdminPanelLogin_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAllgemein_save_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnAllgemein_save_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnAllgemein_save_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnArtikel_color_bestellt_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnArtikel_color_bestellt_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnArtikel_color_bestellt_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnArtikel_color_warteliste_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnArtikel_color_warteliste_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnArtikel_color_warteliste_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBestellungen_bestellt_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnBestellungen_bestellt_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnBestellungen_bestellt_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnChooseSoundeffekt_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnChooseSoundeffekt_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnChooseSoundeffekt_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnColorKomplette_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnColorKomplette_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnColorKomplette_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDelcampe_login_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnDelcampe_login_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnDelcampe_login_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDelcampeExportPath_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnDelcampeExportPath_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnDelcampeExportPath_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDelcampeXMLCatOpenFile_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnDelcampeXMLCatOpenFile_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnDelcampeXMLCatOpenFile_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDropLiveListe_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnDropLiveListe_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnDropLiveListe_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDropLiveListe_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnDropLiveListe_Click_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnDropLiveListe_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDropLiveListe_Click_2"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnDropLiveListe_Click_2Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnDropLiveListe_Click_2(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btneBayTest_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btneBayTest_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btneBayTest_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnExportExcelPath_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnExportExcelPath_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnExportExcelPath_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnExportExcelPath_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnExportExcelPath_Click_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnExportExcelPath_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnFTPLoginTesten_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnFTPLoginTesten_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnFTPLoginTesten_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnMagentoLoginTest_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnMagentoLoginTest_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnMagentoLoginTest_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnPersonal_Save_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnPersonal_Save_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnPersonal_Save_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnPlayEffekt_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnPlayEffekt_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnPlayEffekt_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnPopupTest_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnPopupTest_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnPopupTest_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnTesteMail_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnTesteMail_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnTesteMail_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnTestmySQL_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnTestmySQL_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnTestmySQL_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnUpdateProgramm_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnUpdateProgramm_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnUpdateProgramm_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button1_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button2_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button2_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button2_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button3_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button3_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button3_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button4_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button4_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button4_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button5_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button5_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button5_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "CheckBox1_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CheckBox1_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.CheckBox1_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAdressblockAdd_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkAdressblockAdd_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkAdressblockAdd_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutoDelcampe_bestellstatus_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkAutoDelcampe_bestellstatus_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkAutoDelcampe_bestellstatus_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutomatischesUpdateBeiStart_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkAutomatischesUpdateBeiStart_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkAutomatischesUpdateBeiStart_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutomodus_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkAutomodus_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkAutomodus_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutomodus_CheckedChanged_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkAutomodus_CheckedChanged_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkAutomodus_CheckedChanged_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutoReloadTabs_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkAutoReloadTabs_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkAutoReloadTabs_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkDatenbank_compress_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkDatenbank_compress_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkDatenbank_compress_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkDatenbank_pooling_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkDatenbank_pooling_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkDatenbank_pooling_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkeBay_automatik_sync_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkeBay_automatik_sync_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkeBay_automatik_sync_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkeBayAPILog_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkeBayAPILog_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkeBayAPILog_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkEbayLiveVersandkosten_add_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkEbayLiveVersandkosten_add_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkEbayLiveVersandkosten_add_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkebaysandbox_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkebaysandbox_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkebaysandbox_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkebaysandbox_CheckedChanged_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkebaysandbox_CheckedChanged_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkebaysandbox_CheckedChanged_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkEbayWarteZeit_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkEbayWarteZeit_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkEbayWarteZeit_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkEmail_cc_mailreport_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkEmail_cc_mailreport_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkEmail_cc_mailreport_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkeMailReconnect_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkeMailReconnect_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkeMailReconnect_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkExaktProgressbar_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkExaktProgressbar_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkExaktProgressbar_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkFehlerbericht_hardware_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkFehlerbericht_hardware_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkFehlerbericht_hardware_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkGroupBy_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkGroupBy_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkGroupBy_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkLvwHottrack_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkLvwHottrack_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkLvwHottrack_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkLVWReorder_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkLVWReorder_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkLVWReorder_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkMail_dekcampe_status_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkMail_dekcampe_status_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkMail_dekcampe_status_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkMail_ebay_status_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkMail_ebay_status_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkMail_ebay_status_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkMail_shop_status_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkMail_shop_status_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkMail_shop_status_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkOption2Farben_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkOption2Farben_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkOption2Farben_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkPaypal_Gebühren_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkPaypal_Gebühren_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkPaypal_Gebühren_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkPlaySound_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkPlaySound_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkPlaySound_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkSMTPModus_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkSMTPModus_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkSMTPModus_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupeBayTime_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkStartupeBayTime_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkStartupeBayTime_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupPopups_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkStartupPopups_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkStartupPopups_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupRückbewertung_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkStartupRückbewertung_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkStartupRückbewertung_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupWizard_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkStartupWizard_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkStartupWizard_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkYABE_bestellstatus_debugmail_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkYABE_bestellstatus_debugmail_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkYABE_bestellstatus_debugmail_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkYABE_minimizeToTray_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkYABE_minimizeToTray_CheckedChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkYABE_minimizeToTray_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSMTPAnbieter_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbSMTPAnbieter_SelectedIndexChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbSMTPAnbieter_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripButton_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DruckenToolStripButton_Click_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DruckenToolStripButton_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "eBayDaten_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub eBayDaten_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.eBayDaten_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmOptions_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmOptions_KeyDownTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmOptions_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmOptions_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmOptions_LoadTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmOptions_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getOptionValue"
    '''</summary>
    <TestMethod()> _
    Public Sub getOptionValueTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getOptionValue
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getUpdaterMessage"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getUpdaterMessageTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim strURL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getUpdaterMessage(strURL)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel1_LinkClicked"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LinkLabel1_LinkClickedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As LinkLabelLinkClickedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LinkLabel1_LinkClicked(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NeuToolStripButton_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NeuToolStripButton_Click_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NeuToolStripButton_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setGUI"
    '''</summary>
    <TestMethod()> _
    Public Sub setGUITest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setGUI
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SpeichernToolStripButton_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SpeichernToolStripButton_Click_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SpeichernToolStripButton_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "tbOptions_DrawItem"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub tbOptions_DrawItemTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As DrawItemEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.tbOptions_DrawItem(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "tbOptions_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub tbOptions_SelectedIndexChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.tbOptions_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TextBox1_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TextBox1_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TextBox1_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TextBox1_TextChanged_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TextBox1_TextChanged_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TextBox1_TextChanged_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripButton16_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ToolStripButton16_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ToolStripButton16_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddLand_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddLand_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddLand_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddNachname_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddNachname_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddNachname_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddOrt_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddOrt_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddOrt_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddPLZ_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddPLZ_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddPLZ_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddStrasse_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddStrasse_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddStrasse_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddTelefon_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddTelefon_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddTelefon_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddVorname_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddVorname_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddVorname_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_BIC_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtBank_BIC_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtBank_BIC_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_IBAN_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtBank_IBAN_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtBank_IBAN_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_leitzahl_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtBank_leitzahl_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtBank_leitzahl_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_name_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtBank_name_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtBank_name_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_nr_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtBank_nr_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtBank_nr_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_USTID_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtBank_USTID_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtBank_USTID_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBewertungen_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtBewertungen_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtBewertungen_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDatenbankname_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDatenbankname_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDatenbankname_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_bestellungen_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDauer_bestellungen_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDauer_bestellungen_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_bewertungen_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDauer_bewertungen_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDauer_bewertungen_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_cockpit_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDauer_cockpit_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDauer_cockpit_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_kunden_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDauer_kunden_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDauer_kunden_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_export_path_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDelcampe_export_path_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDelcampe_export_path_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_outlook_archiv_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDelcampe_outlook_archiv_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDelcampe_outlook_archiv_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_outlook_folder_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDelcampe_outlook_folder_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDelcampe_outlook_folder_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_pwd_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDelcampe_pwd_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDelcampe_pwd_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_username_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDelcampe_username_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDelcampe_username_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampeKategorie_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtDelcampeKategorie_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtDelcampeKategorie_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEbay_Outlook_ordner_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtEbay_Outlook_ordner_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtEbay_Outlook_ordner_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBayOutllook_archiv_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txteBayOutllook_archiv_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txteBayOutllook_archiv_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBayToken_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txteBayToken_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txteBayToken_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmailAbsendeName_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtEmailAbsendeName_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtEmailAbsendeName_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txteMailPassword_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txteMailPassword_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txteMailPassword_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txteMailUser_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txteMailUser_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txteMailUser_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFTPPasswort_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtFTPPasswort_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtFTPPasswort_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFTPServer_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtFTPServer_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtFTPServer_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFTPUsername_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtFTPUsername_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtFTPUsername_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLiveAPICall_length_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtLiveAPICall_length_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtLiveAPICall_length_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLiveRefresh_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtLiveRefresh_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtLiveRefresh_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLiveRefresh_TextChanged_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtLiveRefresh_TextChanged_1Test()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtLiveRefresh_TextChanged_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMagentoPwD_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtMagentoPwD_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtMagentoPwD_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMagentoURL_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtMagentoURL_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtMagentoURL_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMagentoUsername_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtMagentoUsername_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtMagentoUsername_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMitgliedsname_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtMitgliedsname_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtMitgliedsname_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtmySQLBenutzer_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtmySQLBenutzer_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtmySQLBenutzer_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtmySQLKennwort_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtmySQLKennwort_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtmySQLKennwort_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMySQLServer_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtMySQLServer_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtMySQLServer_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPasswort_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPasswort_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPasswort_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_20_transaktion_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPaypal_20_transaktion_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPaypal_20_transaktion_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_21_prozent_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPaypal_21_prozent_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPaypal_21_prozent_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_21_transaktion_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPaypal_21_transaktion_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPaypal_21_transaktion_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_API_Benutzername_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPaypal_API_Benutzername_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPaypal_API_Benutzername_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_API_pwd_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPaypal_API_pwd_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPaypal_API_pwd_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_API_Signatur_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPaypal_API_Signatur_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPaypal_API_Signatur_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPOP3Port_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPOP3Port_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPOP3Port_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPOP3Server_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPOP3Server_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPOP3Server_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPopupDauer_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPopupDauer_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPopupDauer_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtShop_url_bilder_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtShop_url_bilder_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtShop_url_bilder_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtShopGalerie_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtShopGalerie_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtShopGalerie_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSMTPPort_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSMTPPort_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSMTPPort_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSMTPServer_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSMTPServer_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSMTPServer_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSoundeffekt_LostFocus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSoundeffekt_LostFocusTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSoundeffekt_LostFocus(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSoundeffekt_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSoundeffekt_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSoundeffekt_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSplashscreen_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSplashscreen_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSplashscreen_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtUploadPfad_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtUploadPfad_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtUploadPfad_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtYABE_pwd_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtYABE_pwd_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtYABE_pwd_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtYABE_usr_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtYABE_usr_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtYABE_usr_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtYABETrennzeichen_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtYABETrennzeichen_TextChangedTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtYABETrennzeichen_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Yabe_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Yabe_ClickTest()
        Dim target As frmOptions_Accessor = New frmOptions_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Yabe_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AusschneidenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub AusschneidenToolStripButtonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.AusschneidenToolStripButton = expected
        actual = target.AusschneidenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "AxDHTMLEdit1"
    '''</summary>
    <TestMethod()> _
    Public Sub AxDHTMLEdit1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As DHTMLEdit = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DHTMLEdit
        target.AxDHTMLEdit1 = expected
        actual = target.AxDHTMLEdit1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "bEigeneBilder"
    '''</summary>
    <TestMethod()> _
    Public Sub bEigeneBilderTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.bEigeneBilder = expected
        actual = target.bEigeneBilder
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Bild"
    '''</summary>
    <TestMethod()> _
    Public Sub BildTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Bild = expected
        actual = target.Bild
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Bold"
    '''</summary>
    <TestMethod()> _
    Public Sub BoldTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Bold = expected
        actual = target.Bold
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAdminPanelLogin"
    '''</summary>
    <TestMethod()> _
    Public Sub btnAdminPanelLoginTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnAdminPanelLogin = expected
        actual = target.btnAdminPanelLogin
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnArtikel_color_bestellt"
    '''</summary>
    <TestMethod()> _
    Public Sub btnArtikel_color_bestelltTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnArtikel_color_bestellt = expected
        actual = target.btnArtikel_color_bestellt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnArtikel_color_warteliste"
    '''</summary>
    <TestMethod()> _
    Public Sub btnArtikel_color_wartelisteTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnArtikel_color_warteliste = expected
        actual = target.btnArtikel_color_warteliste
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBestellungen_bestellt"
    '''</summary>
    <TestMethod()> _
    Public Sub btnBestellungen_bestelltTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnBestellungen_bestellt = expected
        actual = target.btnBestellungen_bestellt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnChooseSoundeffekt"
    '''</summary>
    <TestMethod()> _
    Public Sub btnChooseSoundeffektTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnChooseSoundeffekt = expected
        actual = target.btnChooseSoundeffekt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnColorKomplette"
    '''</summary>
    <TestMethod()> _
    Public Sub btnColorKompletteTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnColorKomplette = expected
        actual = target.btnColorKomplette
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDelcampe_login"
    '''</summary>
    <TestMethod()> _
    Public Sub btnDelcampe_loginTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnDelcampe_login = expected
        actual = target.btnDelcampe_login
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDelcampeExportPath"
    '''</summary>
    <TestMethod()> _
    Public Sub btnDelcampeExportPathTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnDelcampeExportPath = expected
        actual = target.btnDelcampeExportPath
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDelcampeLokaleBilder"
    '''</summary>
    <TestMethod()> _
    Public Sub btnDelcampeLokaleBilderTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnDelcampeLokaleBilder = expected
        actual = target.btnDelcampeLokaleBilder
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDelcampeXMLCatOpenFile"
    '''</summary>
    <TestMethod()> _
    Public Sub btnDelcampeXMLCatOpenFileTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnDelcampeXMLCatOpenFile = expected
        actual = target.btnDelcampeXMLCatOpenFile
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnDropLiveListe"
    '''</summary>
    <TestMethod()> _
    Public Sub btnDropLiveListeTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnDropLiveListe = expected
        actual = target.btnDropLiveListe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btneBayTest"
    '''</summary>
    <TestMethod()> _
    Public Sub btneBayTestTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btneBayTest = expected
        actual = target.btneBayTest
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnExportExcelPath"
    '''</summary>
    <TestMethod()> _
    Public Sub btnExportExcelPathTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnExportExcelPath = expected
        actual = target.btnExportExcelPath
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnFTPLoginTesten"
    '''</summary>
    <TestMethod()> _
    Public Sub btnFTPLoginTestenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnFTPLoginTesten = expected
        actual = target.btnFTPLoginTesten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnMagentoLoginTest"
    '''</summary>
    <TestMethod()> _
    Public Sub btnMagentoLoginTestTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnMagentoLoginTest = expected
        actual = target.btnMagentoLoginTest
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnPersonal_Save"
    '''</summary>
    <TestMethod()> _
    Public Sub btnPersonal_SaveTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnPersonal_Save = expected
        actual = target.btnPersonal_Save
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnPlayEffekt"
    '''</summary>
    <TestMethod()> _
    Public Sub btnPlayEffektTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnPlayEffekt = expected
        actual = target.btnPlayEffekt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnPopupTest"
    '''</summary>
    <TestMethod()> _
    Public Sub btnPopupTestTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnPopupTest = expected
        actual = target.btnPopupTest
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnTesteMail"
    '''</summary>
    <TestMethod()> _
    Public Sub btnTesteMailTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnTesteMail = expected
        actual = target.btnTesteMail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnTestmySQL"
    '''</summary>
    <TestMethod()> _
    Public Sub btnTestmySQLTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnTestmySQL = expected
        actual = target.btnTestmySQL
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnUpdateProgramm"
    '''</summary>
    <TestMethod()> _
    Public Sub btnUpdateProgrammTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnUpdateProgramm = expected
        actual = target.btnUpdateProgramm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1"
    '''</summary>
    <TestMethod()> _
    Public Sub Button1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button1 = expected
        actual = target.Button1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button2"
    '''</summary>
    <TestMethod()> _
    Public Sub Button2Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button2 = expected
        actual = target.Button2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button3"
    '''</summary>
    <TestMethod()> _
    Public Sub Button3Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button3 = expected
        actual = target.Button3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button4"
    '''</summary>
    <TestMethod()> _
    Public Sub Button4Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button4 = expected
        actual = target.Button4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAdressblockAdd"
    '''</summary>
    <TestMethod()> _
    Public Sub chkAdressblockAddTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkAdressblockAdd = expected
        actual = target.chkAdressblockAdd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutoDelcampe_bestellstatus"
    '''</summary>
    <TestMethod()> _
    Public Sub chkAutoDelcampe_bestellstatusTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkAutoDelcampe_bestellstatus = expected
        actual = target.chkAutoDelcampe_bestellstatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutomatischesUpdateBeiStart"
    '''</summary>
    <TestMethod()> _
    Public Sub chkAutomatischesUpdateBeiStartTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkAutomatischesUpdateBeiStart = expected
        actual = target.chkAutomatischesUpdateBeiStart
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutomodus"
    '''</summary>
    <TestMethod()> _
    Public Sub chkAutomodusTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkAutomodus = expected
        actual = target.chkAutomodus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkAutoReloadTabs"
    '''</summary>
    <TestMethod()> _
    Public Sub chkAutoReloadTabsTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkAutoReloadTabs = expected
        actual = target.chkAutoReloadTabs
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkDatenbank_compress"
    '''</summary>
    <TestMethod()> _
    Public Sub chkDatenbank_compressTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkDatenbank_compress = expected
        actual = target.chkDatenbank_compress
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkDatenbank_pooling"
    '''</summary>
    <TestMethod()> _
    Public Sub chkDatenbank_poolingTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkDatenbank_pooling = expected
        actual = target.chkDatenbank_pooling
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkeBay_automatik_sync"
    '''</summary>
    <TestMethod()> _
    Public Sub chkeBay_automatik_syncTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkeBay_automatik_sync = expected
        actual = target.chkeBay_automatik_sync
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkeBayAPILog"
    '''</summary>
    <TestMethod()> _
    Public Sub chkeBayAPILogTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkeBayAPILog = expected
        actual = target.chkeBayAPILog
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkEbayLiveVersandkosten_add"
    '''</summary>
    <TestMethod()> _
    Public Sub chkEbayLiveVersandkosten_addTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkEbayLiveVersandkosten_add = expected
        actual = target.chkEbayLiveVersandkosten_add
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkebaysandbox"
    '''</summary>
    <TestMethod()> _
    Public Sub chkebaysandboxTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkebaysandbox = expected
        actual = target.chkebaysandbox
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkEbayWarteZeit"
    '''</summary>
    <TestMethod()> _
    Public Sub chkEbayWarteZeitTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkEbayWarteZeit = expected
        actual = target.chkEbayWarteZeit
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkEmail_cc_mailreport"
    '''</summary>
    <TestMethod()> _
    Public Sub chkEmail_cc_mailreportTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkEmail_cc_mailreport = expected
        actual = target.chkEmail_cc_mailreport
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkeMailReconnect"
    '''</summary>
    <TestMethod()> _
    Public Sub chkeMailReconnectTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkeMailReconnect = expected
        actual = target.chkeMailReconnect
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkExaktProgressbar"
    '''</summary>
    <TestMethod()> _
    Public Sub chkExaktProgressbarTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkExaktProgressbar = expected
        actual = target.chkExaktProgressbar
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkExportAutosave"
    '''</summary>
    <TestMethod()> _
    Public Sub chkExportAutosaveTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkExportAutosave = expected
        actual = target.chkExportAutosave
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkFehlerbericht_hardware"
    '''</summary>
    <TestMethod()> _
    Public Sub chkFehlerbericht_hardwareTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkFehlerbericht_hardware = expected
        actual = target.chkFehlerbericht_hardware
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkGroupBy"
    '''</summary>
    <TestMethod()> _
    Public Sub chkGroupByTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkGroupBy = expected
        actual = target.chkGroupBy
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkLvwHottrack"
    '''</summary>
    <TestMethod()> _
    Public Sub chkLvwHottrackTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkLvwHottrack = expected
        actual = target.chkLvwHottrack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkLVWReorder"
    '''</summary>
    <TestMethod()> _
    Public Sub chkLVWReorderTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkLVWReorder = expected
        actual = target.chkLVWReorder
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkMail_dekcampe_status"
    '''</summary>
    <TestMethod()> _
    Public Sub chkMail_dekcampe_statusTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkMail_dekcampe_status = expected
        actual = target.chkMail_dekcampe_status
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkMail_ebay_status"
    '''</summary>
    <TestMethod()> _
    Public Sub chkMail_ebay_statusTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkMail_ebay_status = expected
        actual = target.chkMail_ebay_status
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkMail_shop_status"
    '''</summary>
    <TestMethod()> _
    Public Sub chkMail_shop_statusTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkMail_shop_status = expected
        actual = target.chkMail_shop_status
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkOptionKundeSelector"
    '''</summary>
    <TestMethod()> _
    Public Sub chkOptionKundeSelectorTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkOptionKundeSelector = expected
        actual = target.chkOptionKundeSelector
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkPaypal_Gebühren"
    '''</summary>
    <TestMethod()> _
    Public Sub chkPaypal_GebührenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkPaypal_Gebühren = expected
        actual = target.chkPaypal_Gebühren
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkPlaySound"
    '''</summary>
    <TestMethod()> _
    Public Sub chkPlaySoundTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkPlaySound = expected
        actual = target.chkPlaySound
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkSMTPModus"
    '''</summary>
    <TestMethod()> _
    Public Sub chkSMTPModusTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkSMTPModus = expected
        actual = target.chkSMTPModus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkSplashscreen"
    '''</summary>
    <TestMethod()> _
    Public Sub chkSplashscreenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkSplashscreen = expected
        actual = target.chkSplashscreen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupeBayTime"
    '''</summary>
    <TestMethod()> _
    Public Sub chkStartupeBayTimeTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkStartupeBayTime = expected
        actual = target.chkStartupeBayTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupPopups"
    '''</summary>
    <TestMethod()> _
    Public Sub chkStartupPopupsTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkStartupPopups = expected
        actual = target.chkStartupPopups
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupRückbewertung"
    '''</summary>
    <TestMethod()> _
    Public Sub chkStartupRückbewertungTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkStartupRückbewertung = expected
        actual = target.chkStartupRückbewertung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkStartupWizard"
    '''</summary>
    <TestMethod()> _
    Public Sub chkStartupWizardTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkStartupWizard = expected
        actual = target.chkStartupWizard
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkVollbildonAlert"
    '''</summary>
    <TestMethod()> _
    Public Sub chkVollbildonAlertTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkVollbildonAlert = expected
        actual = target.chkVollbildonAlert
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkYABE_bestellstatus_debugmail"
    '''</summary>
    <TestMethod()> _
    Public Sub chkYABE_bestellstatus_debugmailTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkYABE_bestellstatus_debugmail = expected
        actual = target.chkYABE_bestellstatus_debugmail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkYABE_minimizeToTray"
    '''</summary>
    <TestMethod()> _
    Public Sub chkYABE_minimizeToTrayTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkYABE_minimizeToTray = expected
        actual = target.chkYABE_minimizeToTray
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "clsUpdateDownloader"
    '''</summary>
    <TestMethod()> _
    Public Sub clsUpdateDownloaderTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As WebFileDownloader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As WebFileDownloader
        target.clsUpdateDownloader = expected
        actual = target.clsUpdateDownloader
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSMTPAnbieter"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbSMTPAnbieterTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbSMTPAnbieter = expected
        actual = target.cmbSMTPAnbieter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colBackground"
    '''</summary>
    <TestMethod()> _
    Public Sub colBackgroundTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ColorDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColorDialog
        target.colBackground = expected
        actual = target.colBackground
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ComboBox2"
    '''</summary>
    <TestMethod()> _
    Public Sub ComboBox2Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.ComboBox2 = expected
        actual = target.ComboBox2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DHTMLControll"
    '''</summary>
    <TestMethod()> _
    Public Sub DHTMLControllTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As DHTMLEdit = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DHTMLEdit
        target.DHTMLControll = expected
        actual = target.DHTMLControll
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub DruckenToolStripButtonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.DruckenToolStripButton = expected
        actual = target.DruckenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EinfügenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub EinfügenToolStripButtonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.EinfügenToolStripButton = expected
        actual = target.EinfügenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FolderBrowserDialog1"
    '''</summary>
    <TestMethod()> _
    Public Sub FolderBrowserDialog1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As FolderBrowserDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As FolderBrowserDialog
        target.FolderBrowserDialog1 = expected
        actual = target.FolderBrowserDialog1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Hyperlink"
    '''</summary>
    <TestMethod()> _
    Public Sub HyperlinkTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Hyperlink = expected
        actual = target.Hyperlink
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ImageList1"
    '''</summary>
    <TestMethod()> _
    Public Sub ImageList1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ImageList = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ImageList
        target.ImageList1 = expected
        actual = target.ImageList1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub KopierenToolStripButtonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.KopierenToolStripButton = expected
        actual = target.KopierenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label10"
    '''</summary>
    <TestMethod()> _
    Public Sub Label10Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label10 = expected
        actual = target.Label10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label100"
    '''</summary>
    <TestMethod()> _
    Public Sub Label100Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label100 = expected
        actual = target.Label100
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label101"
    '''</summary>
    <TestMethod()> _
    Public Sub Label101Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label101 = expected
        actual = target.Label101
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label102"
    '''</summary>
    <TestMethod()> _
    Public Sub Label102Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label102 = expected
        actual = target.Label102
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label103"
    '''</summary>
    <TestMethod()> _
    Public Sub Label103Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label103 = expected
        actual = target.Label103
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label104"
    '''</summary>
    <TestMethod()> _
    Public Sub Label104Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label104 = expected
        actual = target.Label104
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label105"
    '''</summary>
    <TestMethod()> _
    Public Sub Label105Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label105 = expected
        actual = target.Label105
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label106"
    '''</summary>
    <TestMethod()> _
    Public Sub Label106Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label106 = expected
        actual = target.Label106
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label107"
    '''</summary>
    <TestMethod()> _
    Public Sub Label107Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label107 = expected
        actual = target.Label107
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label108"
    '''</summary>
    <TestMethod()> _
    Public Sub Label108Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label108 = expected
        actual = target.Label108
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label109"
    '''</summary>
    <TestMethod()> _
    Public Sub Label109Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label109 = expected
        actual = target.Label109
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label11"
    '''</summary>
    <TestMethod()> _
    Public Sub Label11Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label11 = expected
        actual = target.Label11
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label110"
    '''</summary>
    <TestMethod()> _
    Public Sub Label110Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label110 = expected
        actual = target.Label110
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label111"
    '''</summary>
    <TestMethod()> _
    Public Sub Label111Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label111 = expected
        actual = target.Label111
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label112"
    '''</summary>
    <TestMethod()> _
    Public Sub Label112Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label112 = expected
        actual = target.Label112
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label113"
    '''</summary>
    <TestMethod()> _
    Public Sub Label113Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label113 = expected
        actual = target.Label113
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label114"
    '''</summary>
    <TestMethod()> _
    Public Sub Label114Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label114 = expected
        actual = target.Label114
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label115"
    '''</summary>
    <TestMethod()> _
    Public Sub Label115Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label115 = expected
        actual = target.Label115
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label116"
    '''</summary>
    <TestMethod()> _
    Public Sub Label116Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label116 = expected
        actual = target.Label116
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label117"
    '''</summary>
    <TestMethod()> _
    Public Sub Label117Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label117 = expected
        actual = target.Label117
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label118"
    '''</summary>
    <TestMethod()> _
    Public Sub Label118Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label118 = expected
        actual = target.Label118
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label119"
    '''</summary>
    <TestMethod()> _
    Public Sub Label119Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label119 = expected
        actual = target.Label119
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label12"
    '''</summary>
    <TestMethod()> _
    Public Sub Label12Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label12 = expected
        actual = target.Label12
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label120"
    '''</summary>
    <TestMethod()> _
    Public Sub Label120Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label120 = expected
        actual = target.Label120
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label121"
    '''</summary>
    <TestMethod()> _
    Public Sub Label121Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label121 = expected
        actual = target.Label121
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label122"
    '''</summary>
    <TestMethod()> _
    Public Sub Label122Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label122 = expected
        actual = target.Label122
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label123"
    '''</summary>
    <TestMethod()> _
    Public Sub Label123Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label123 = expected
        actual = target.Label123
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label124"
    '''</summary>
    <TestMethod()> _
    Public Sub Label124Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label124 = expected
        actual = target.Label124
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label125"
    '''</summary>
    <TestMethod()> _
    Public Sub Label125Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label125 = expected
        actual = target.Label125
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label126"
    '''</summary>
    <TestMethod()> _
    Public Sub Label126Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label126 = expected
        actual = target.Label126
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label127"
    '''</summary>
    <TestMethod()> _
    Public Sub Label127Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label127 = expected
        actual = target.Label127
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label128"
    '''</summary>
    <TestMethod()> _
    Public Sub Label128Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label128 = expected
        actual = target.Label128
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label129"
    '''</summary>
    <TestMethod()> _
    Public Sub Label129Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label129 = expected
        actual = target.Label129
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label13"
    '''</summary>
    <TestMethod()> _
    Public Sub Label13Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label13 = expected
        actual = target.Label13
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label130"
    '''</summary>
    <TestMethod()> _
    Public Sub Label130Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label130 = expected
        actual = target.Label130
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label131"
    '''</summary>
    <TestMethod()> _
    Public Sub Label131Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label131 = expected
        actual = target.Label131
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label132"
    '''</summary>
    <TestMethod()> _
    Public Sub Label132Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label132 = expected
        actual = target.Label132
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label133"
    '''</summary>
    <TestMethod()> _
    Public Sub Label133Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label133 = expected
        actual = target.Label133
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label134"
    '''</summary>
    <TestMethod()> _
    Public Sub Label134Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label134 = expected
        actual = target.Label134
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label135"
    '''</summary>
    <TestMethod()> _
    Public Sub Label135Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label135 = expected
        actual = target.Label135
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label136"
    '''</summary>
    <TestMethod()> _
    Public Sub Label136Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label136 = expected
        actual = target.Label136
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label137"
    '''</summary>
    <TestMethod()> _
    Public Sub Label137Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label137 = expected
        actual = target.Label137
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label138"
    '''</summary>
    <TestMethod()> _
    Public Sub Label138Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label138 = expected
        actual = target.Label138
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label139"
    '''</summary>
    <TestMethod()> _
    Public Sub Label139Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label139 = expected
        actual = target.Label139
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label14"
    '''</summary>
    <TestMethod()> _
    Public Sub Label14Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label14 = expected
        actual = target.Label14
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label140"
    '''</summary>
    <TestMethod()> _
    Public Sub Label140Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label140 = expected
        actual = target.Label140
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label141"
    '''</summary>
    <TestMethod()> _
    Public Sub Label141Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label141 = expected
        actual = target.Label141
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label142"
    '''</summary>
    <TestMethod()> _
    Public Sub Label142Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label142 = expected
        actual = target.Label142
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label143"
    '''</summary>
    <TestMethod()> _
    Public Sub Label143Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label143 = expected
        actual = target.Label143
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label144"
    '''</summary>
    <TestMethod()> _
    Public Sub Label144Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label144 = expected
        actual = target.Label144
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label15"
    '''</summary>
    <TestMethod()> _
    Public Sub Label15Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label15 = expected
        actual = target.Label15
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label16"
    '''</summary>
    <TestMethod()> _
    Public Sub Label16Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label16 = expected
        actual = target.Label16
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label17"
    '''</summary>
    <TestMethod()> _
    Public Sub Label17Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label17 = expected
        actual = target.Label17
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label18"
    '''</summary>
    <TestMethod()> _
    Public Sub Label18Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label18 = expected
        actual = target.Label18
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label19"
    '''</summary>
    <TestMethod()> _
    Public Sub Label19Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label19 = expected
        actual = target.Label19
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label2"
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label20"
    '''</summary>
    <TestMethod()> _
    Public Sub Label20Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label20 = expected
        actual = target.Label20
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label21"
    '''</summary>
    <TestMethod()> _
    Public Sub Label21Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label21 = expected
        actual = target.Label21
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label22"
    '''</summary>
    <TestMethod()> _
    Public Sub Label22Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label22 = expected
        actual = target.Label22
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label23"
    '''</summary>
    <TestMethod()> _
    Public Sub Label23Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label23 = expected
        actual = target.Label23
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label24"
    '''</summary>
    <TestMethod()> _
    Public Sub Label24Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label24 = expected
        actual = target.Label24
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label25"
    '''</summary>
    <TestMethod()> _
    Public Sub Label25Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label25 = expected
        actual = target.Label25
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label26"
    '''</summary>
    <TestMethod()> _
    Public Sub Label26Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label26 = expected
        actual = target.Label26
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label27"
    '''</summary>
    <TestMethod()> _
    Public Sub Label27Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label27 = expected
        actual = target.Label27
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label28"
    '''</summary>
    <TestMethod()> _
    Public Sub Label28Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label28 = expected
        actual = target.Label28
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label29"
    '''</summary>
    <TestMethod()> _
    Public Sub Label29Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label29 = expected
        actual = target.Label29
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label3"
    '''</summary>
    <TestMethod()> _
    Public Sub Label3Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label3 = expected
        actual = target.Label3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label30"
    '''</summary>
    <TestMethod()> _
    Public Sub Label30Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label30 = expected
        actual = target.Label30
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label31"
    '''</summary>
    <TestMethod()> _
    Public Sub Label31Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label31 = expected
        actual = target.Label31
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label32"
    '''</summary>
    <TestMethod()> _
    Public Sub Label32Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label32 = expected
        actual = target.Label32
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label33"
    '''</summary>
    <TestMethod()> _
    Public Sub Label33Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label33 = expected
        actual = target.Label33
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label34"
    '''</summary>
    <TestMethod()> _
    Public Sub Label34Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label34 = expected
        actual = target.Label34
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label35"
    '''</summary>
    <TestMethod()> _
    Public Sub Label35Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label35 = expected
        actual = target.Label35
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label36"
    '''</summary>
    <TestMethod()> _
    Public Sub Label36Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label36 = expected
        actual = target.Label36
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label37"
    '''</summary>
    <TestMethod()> _
    Public Sub Label37Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label37 = expected
        actual = target.Label37
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label38"
    '''</summary>
    <TestMethod()> _
    Public Sub Label38Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label38 = expected
        actual = target.Label38
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label39"
    '''</summary>
    <TestMethod()> _
    Public Sub Label39Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label39 = expected
        actual = target.Label39
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label4"
    '''</summary>
    <TestMethod()> _
    Public Sub Label4Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label4 = expected
        actual = target.Label4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label40"
    '''</summary>
    <TestMethod()> _
    Public Sub Label40Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label40 = expected
        actual = target.Label40
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label41"
    '''</summary>
    <TestMethod()> _
    Public Sub Label41Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label41 = expected
        actual = target.Label41
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label42"
    '''</summary>
    <TestMethod()> _
    Public Sub Label42Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label42 = expected
        actual = target.Label42
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label43"
    '''</summary>
    <TestMethod()> _
    Public Sub Label43Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label43 = expected
        actual = target.Label43
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label44"
    '''</summary>
    <TestMethod()> _
    Public Sub Label44Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label44 = expected
        actual = target.Label44
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label45"
    '''</summary>
    <TestMethod()> _
    Public Sub Label45Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label45 = expected
        actual = target.Label45
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label46"
    '''</summary>
    <TestMethod()> _
    Public Sub Label46Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label46 = expected
        actual = target.Label46
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label47"
    '''</summary>
    <TestMethod()> _
    Public Sub Label47Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label47 = expected
        actual = target.Label47
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label48"
    '''</summary>
    <TestMethod()> _
    Public Sub Label48Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label48 = expected
        actual = target.Label48
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label49"
    '''</summary>
    <TestMethod()> _
    Public Sub Label49Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label49 = expected
        actual = target.Label49
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label5"
    '''</summary>
    <TestMethod()> _
    Public Sub Label5Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label5 = expected
        actual = target.Label5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label50"
    '''</summary>
    <TestMethod()> _
    Public Sub Label50Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label50 = expected
        actual = target.Label50
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label51"
    '''</summary>
    <TestMethod()> _
    Public Sub Label51Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label51 = expected
        actual = target.Label51
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label52"
    '''</summary>
    <TestMethod()> _
    Public Sub Label52Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label52 = expected
        actual = target.Label52
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label53"
    '''</summary>
    <TestMethod()> _
    Public Sub Label53Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label53 = expected
        actual = target.Label53
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label54"
    '''</summary>
    <TestMethod()> _
    Public Sub Label54Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label54 = expected
        actual = target.Label54
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label55"
    '''</summary>
    <TestMethod()> _
    Public Sub Label55Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label55 = expected
        actual = target.Label55
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label56"
    '''</summary>
    <TestMethod()> _
    Public Sub Label56Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label56 = expected
        actual = target.Label56
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label57"
    '''</summary>
    <TestMethod()> _
    Public Sub Label57Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label57 = expected
        actual = target.Label57
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label58"
    '''</summary>
    <TestMethod()> _
    Public Sub Label58Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label58 = expected
        actual = target.Label58
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label59"
    '''</summary>
    <TestMethod()> _
    Public Sub Label59Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label59 = expected
        actual = target.Label59
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label6"
    '''</summary>
    <TestMethod()> _
    Public Sub Label6Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label6 = expected
        actual = target.Label6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label60"
    '''</summary>
    <TestMethod()> _
    Public Sub Label60Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label60 = expected
        actual = target.Label60
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label61"
    '''</summary>
    <TestMethod()> _
    Public Sub Label61Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label61 = expected
        actual = target.Label61
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label62"
    '''</summary>
    <TestMethod()> _
    Public Sub Label62Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label62 = expected
        actual = target.Label62
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label63"
    '''</summary>
    <TestMethod()> _
    Public Sub Label63Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label63 = expected
        actual = target.Label63
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label64"
    '''</summary>
    <TestMethod()> _
    Public Sub Label64Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label64 = expected
        actual = target.Label64
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label65"
    '''</summary>
    <TestMethod()> _
    Public Sub Label65Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label65 = expected
        actual = target.Label65
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label66"
    '''</summary>
    <TestMethod()> _
    Public Sub Label66Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label66 = expected
        actual = target.Label66
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label67"
    '''</summary>
    <TestMethod()> _
    Public Sub Label67Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label67 = expected
        actual = target.Label67
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label68"
    '''</summary>
    <TestMethod()> _
    Public Sub Label68Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label68 = expected
        actual = target.Label68
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label69"
    '''</summary>
    <TestMethod()> _
    Public Sub Label69Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label69 = expected
        actual = target.Label69
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label7"
    '''</summary>
    <TestMethod()> _
    Public Sub Label7Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label7 = expected
        actual = target.Label7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label70"
    '''</summary>
    <TestMethod()> _
    Public Sub Label70Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label70 = expected
        actual = target.Label70
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label71"
    '''</summary>
    <TestMethod()> _
    Public Sub Label71Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label71 = expected
        actual = target.Label71
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label72"
    '''</summary>
    <TestMethod()> _
    Public Sub Label72Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label72 = expected
        actual = target.Label72
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label73"
    '''</summary>
    <TestMethod()> _
    Public Sub Label73Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label73 = expected
        actual = target.Label73
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label74"
    '''</summary>
    <TestMethod()> _
    Public Sub Label74Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label74 = expected
        actual = target.Label74
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label75"
    '''</summary>
    <TestMethod()> _
    Public Sub Label75Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label75 = expected
        actual = target.Label75
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label76"
    '''</summary>
    <TestMethod()> _
    Public Sub Label76Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label76 = expected
        actual = target.Label76
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label77"
    '''</summary>
    <TestMethod()> _
    Public Sub Label77Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label77 = expected
        actual = target.Label77
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label78"
    '''</summary>
    <TestMethod()> _
    Public Sub Label78Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label78 = expected
        actual = target.Label78
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label79"
    '''</summary>
    <TestMethod()> _
    Public Sub Label79Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label79 = expected
        actual = target.Label79
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label8"
    '''</summary>
    <TestMethod()> _
    Public Sub Label8Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label8 = expected
        actual = target.Label8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label80"
    '''</summary>
    <TestMethod()> _
    Public Sub Label80Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label80 = expected
        actual = target.Label80
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label81"
    '''</summary>
    <TestMethod()> _
    Public Sub Label81Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label81 = expected
        actual = target.Label81
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label82"
    '''</summary>
    <TestMethod()> _
    Public Sub Label82Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label82 = expected
        actual = target.Label82
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label83"
    '''</summary>
    <TestMethod()> _
    Public Sub Label83Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label83 = expected
        actual = target.Label83
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label84"
    '''</summary>
    <TestMethod()> _
    Public Sub Label84Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label84 = expected
        actual = target.Label84
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label85"
    '''</summary>
    <TestMethod()> _
    Public Sub Label85Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label85 = expected
        actual = target.Label85
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label86"
    '''</summary>
    <TestMethod()> _
    Public Sub Label86Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label86 = expected
        actual = target.Label86
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label87"
    '''</summary>
    <TestMethod()> _
    Public Sub Label87Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label87 = expected
        actual = target.Label87
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label88"
    '''</summary>
    <TestMethod()> _
    Public Sub Label88Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label88 = expected
        actual = target.Label88
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label89"
    '''</summary>
    <TestMethod()> _
    Public Sub Label89Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label89 = expected
        actual = target.Label89
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label9"
    '''</summary>
    <TestMethod()> _
    Public Sub Label9Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label9 = expected
        actual = target.Label9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label90"
    '''</summary>
    <TestMethod()> _
    Public Sub Label90Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label90 = expected
        actual = target.Label90
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label91"
    '''</summary>
    <TestMethod()> _
    Public Sub Label91Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label91 = expected
        actual = target.Label91
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label92"
    '''</summary>
    <TestMethod()> _
    Public Sub Label92Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label92 = expected
        actual = target.Label92
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label93"
    '''</summary>
    <TestMethod()> _
    Public Sub Label93Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label93 = expected
        actual = target.Label93
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label94"
    '''</summary>
    <TestMethod()> _
    Public Sub Label94Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label94 = expected
        actual = target.Label94
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label95"
    '''</summary>
    <TestMethod()> _
    Public Sub Label95Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label95 = expected
        actual = target.Label95
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label96"
    '''</summary>
    <TestMethod()> _
    Public Sub Label96Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label96 = expected
        actual = target.Label96
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label97"
    '''</summary>
    <TestMethod()> _
    Public Sub Label97Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label97 = expected
        actual = target.Label97
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label98"
    '''</summary>
    <TestMethod()> _
    Public Sub Label98Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label98 = expected
        actual = target.Label98
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label99"
    '''</summary>
    <TestMethod()> _
    Public Sub Label99Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label99 = expected
        actual = target.Label99
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblUpdater"
    '''</summary>
    <TestMethod()> _
    Public Sub lblUpdaterTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblUpdater = expected
        actual = target.lblUpdater
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel1"
    '''</summary>
    <TestMethod()> _
    Public Sub LinkLabel1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As LinkLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As LinkLabel
        target.LinkLabel1 = expected
        actual = target.LinkLabel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NeuToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub NeuToolStripButtonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.NeuToolStripButton = expected
        actual = target.NeuToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ÖffnenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub ÖffnenToolStripButtonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.ÖffnenToolStripButton = expected
        actual = target.ÖffnenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OpenFileDialog1"
    '''</summary>
    <TestMethod()> _
    Public Sub OpenFileDialog1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As OpenFileDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As OpenFileDialog
        target.OpenFileDialog1 = expected
        actual = target.OpenFileDialog1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Panel1"
    '''</summary>
    <TestMethod()> _
    Public Sub Panel1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As Panel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "pgrUpdate"
    '''</summary>
    <TestMethod()> _
    Public Sub pgrUpdateTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ProgressBar
        target.pgrUpdate = expected
        actual = target.pgrUpdate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Redo"
    '''</summary>
    <TestMethod()> _
    Public Sub RedoTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Redo = expected
        actual = target.Redo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SpeichernToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub SpeichernToolStripButtonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.SpeichernToolStripButton = expected
        actual = target.SpeichernToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Suchen"
    '''</summary>
    <TestMethod()> _
    Public Sub SuchenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Suchen = expected
        actual = target.Suchen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tabelle"
    '''</summary>
    <TestMethod()> _
    Public Sub tabelleTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.tabelle = expected
        actual = target.tabelle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TableLayoutPanel1"
    '''</summary>
    <TestMethod()> _
    Public Sub TableLayoutPanel1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TableLayoutPanel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TableLayoutPanel
        target.TableLayoutPanel1 = expected
        actual = target.TableLayoutPanel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tbOptions"
    '''</summary>
    <TestMethod()> _
    Public Sub tbOptionsTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabControl
        target.tbOptions = expected
        actual = target.tbOptions
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStrip1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStrip
        target.ToolStrip1 = expected
        actual = target.ToolStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparatorTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator = expected
        actual = target.toolStripSeparator
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator2"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparator2Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator2 = expected
        actual = target.toolStripSeparator2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator3"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator3Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator3 = expected
        actual = target.ToolStripSeparator3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripStatusLabel1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripStatusLabel1Test()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.ToolStripStatusLabel1 = expected
        actual = target.ToolStripStatusLabel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_allgemein"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_allgemeinTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_allgemein = expected
        actual = target.tp_allgemein
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_Datenbank"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_DatenbankTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_Datenbank = expected
        actual = target.tp_Datenbank
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_Delcampe"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_DelcampeTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_Delcampe = expected
        actual = target.tp_Delcampe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_eBayDaten"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_eBayDatenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_eBayDaten = expected
        actual = target.tp_eBayDaten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_emaildaten"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_emaildatenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_emaildaten = expected
        actual = target.tp_emaildaten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_magento"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_magentoTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_magento = expected
        actual = target.tp_magento
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_paypal"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_paypalTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_paypal = expected
        actual = target.tp_paypal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_personal"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_personalTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_personal = expected
        actual = target.tp_personal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_Popups"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_PopupsTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_Popups = expected
        actual = target.tp_Popups
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_Shop"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_ShopTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_Shop = expected
        actual = target.tp_Shop
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tp_Yabe"
    '''</summary>
    <TestMethod()> _
    Public Sub tp_YabeTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tp_Yabe = expected
        actual = target.tp_Yabe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddLand"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddLandTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddLand = expected
        actual = target.txtAddLand
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddNachname"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddNachnameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddNachname = expected
        actual = target.txtAddNachname
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddOrt"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddOrtTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddOrt = expected
        actual = target.txtAddOrt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddPLZ"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddPLZTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddPLZ = expected
        actual = target.txtAddPLZ
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddStrasse"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddStrasseTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddStrasse = expected
        actual = target.txtAddStrasse
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddTelefon"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddTelefonTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddTelefon = expected
        actual = target.txtAddTelefon
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddVorname"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddVornameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddVorname = expected
        actual = target.txtAddVorname
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtArtikel_color_bestellt"
    '''</summary>
    <TestMethod()> _
    Public Sub txtArtikel_color_bestelltTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtArtikel_color_bestellt = expected
        actual = target.txtArtikel_color_bestellt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtArtikel_color_warteliste"
    '''</summary>
    <TestMethod()> _
    Public Sub txtArtikel_color_wartelisteTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtArtikel_color_warteliste = expected
        actual = target.txtArtikel_color_warteliste
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_BIC"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBank_BICTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBank_BIC = expected
        actual = target.txtBank_BIC
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_IBAN"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBank_IBANTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBank_IBAN = expected
        actual = target.txtBank_IBAN
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_leitzahl"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBank_leitzahlTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBank_leitzahl = expected
        actual = target.txtBank_leitzahl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_name"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBank_nameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBank_name = expected
        actual = target.txtBank_name
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_nr"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBank_nrTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBank_nr = expected
        actual = target.txtBank_nr
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBank_USTID"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBank_USTIDTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBank_USTID = expected
        actual = target.txtBank_USTID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBekannterKunde"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBekannterKundeTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBekannterKunde = expected
        actual = target.txtBekannterKunde
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBewertungen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBewertungenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBewertungen = expected
        actual = target.txtBewertungen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtColor_bestellung_komplett"
    '''</summary>
    <TestMethod()> _
    Public Sub txtColor_bestellung_komplettTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtColor_bestellung_komplett = expected
        actual = target.txtColor_bestellung_komplett
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtColor_bestellungen_bestellt"
    '''</summary>
    <TestMethod()> _
    Public Sub txtColor_bestellungen_bestelltTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtColor_bestellungen_bestellt = expected
        actual = target.txtColor_bestellungen_bestellt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtColor_bestellungen_verschickt"
    '''</summary>
    <TestMethod()> _
    Public Sub txtColor_bestellungen_verschicktTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtColor_bestellungen_verschickt = expected
        actual = target.txtColor_bestellungen_verschickt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtColorBestellungen_bezahl"
    '''</summary>
    <TestMethod()> _
    Public Sub txtColorBestellungen_bezahlTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtColorBestellungen_bezahl = expected
        actual = target.txtColorBestellungen_bezahl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDatenbankname"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDatenbanknameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDatenbankname = expected
        actual = target.txtDatenbankname
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_bestellungen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDauer_bestellungenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDauer_bestellungen = expected
        actual = target.txtDauer_bestellungen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_bewertungen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDauer_bewertungenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDauer_bewertungen = expected
        actual = target.txtDauer_bewertungen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_cockpit"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDauer_cockpitTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDauer_cockpit = expected
        actual = target.txtDauer_cockpit
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDauer_kunden"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDauer_kundenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDauer_kunden = expected
        actual = target.txtDauer_kunden
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_BilderVerzeichnis"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampe_BilderVerzeichnisTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampe_BilderVerzeichnis = expected
        actual = target.txtDelcampe_BilderVerzeichnis
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_export_path"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampe_export_pathTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampe_export_path = expected
        actual = target.txtDelcampe_export_path
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_outlook_archiv"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampe_outlook_archivTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampe_outlook_archiv = expected
        actual = target.txtDelcampe_outlook_archiv
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_outlook_folder"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampe_outlook_folderTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampe_outlook_folder = expected
        actual = target.txtDelcampe_outlook_folder
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_pwd"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampe_pwdTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampe_pwd = expected
        actual = target.txtDelcampe_pwd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampe_username"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampe_usernameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampe_username = expected
        actual = target.txtDelcampe_username
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampeKategorie"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampeKategorieTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampeKategorie = expected
        actual = target.txtDelcampeKategorie
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEbay_Outlook_ordner"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEbay_Outlook_ordnerTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEbay_Outlook_ordner = expected
        actual = target.txtEbay_Outlook_ordner
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBayOutllook_archiv"
    '''</summary>
    <TestMethod()> _
    Public Sub txteBayOutllook_archivTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txteBayOutllook_archiv = expected
        actual = target.txteBayOutllook_archiv
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBayToken"
    '''</summary>
    <TestMethod()> _
    Public Sub txteBayTokenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txteBayToken = expected
        actual = target.txteBayToken
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmailAbsendeName"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEmailAbsendeNameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEmailAbsendeName = expected
        actual = target.txtEmailAbsendeName
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txteMailPassword"
    '''</summary>
    <TestMethod()> _
    Public Sub txteMailPasswordTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txteMailPassword = expected
        actual = target.txteMailPassword
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txteMailUser"
    '''</summary>
    <TestMethod()> _
    Public Sub txteMailUserTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txteMailUser = expected
        actual = target.txteMailUser
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtExportExcelPath"
    '''</summary>
    <TestMethod()> _
    Public Sub txtExportExcelPathTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtExportExcelPath = expected
        actual = target.txtExportExcelPath
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFTPPasswort"
    '''</summary>
    <TestMethod()> _
    Public Sub txtFTPPasswortTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtFTPPasswort = expected
        actual = target.txtFTPPasswort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFTPServer"
    '''</summary>
    <TestMethod()> _
    Public Sub txtFTPServerTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtFTPServer = expected
        actual = target.txtFTPServer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFTPUsername"
    '''</summary>
    <TestMethod()> _
    Public Sub txtFTPUsernameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtFTPUsername = expected
        actual = target.txtFTPUsername
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLiveAPICall_length"
    '''</summary>
    <TestMethod()> _
    Public Sub txtLiveAPICall_lengthTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtLiveAPICall_length = expected
        actual = target.txtLiveAPICall_length
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLiveRefresh"
    '''</summary>
    <TestMethod()> _
    Public Sub txtLiveRefreshTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtLiveRefresh = expected
        actual = target.txtLiveRefresh
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLivwHintergrund"
    '''</summary>
    <TestMethod()> _
    Public Sub txtLivwHintergrundTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtLivwHintergrund = expected
        actual = target.txtLivwHintergrund
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMagentoPwD"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMagentoPwDTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMagentoPwD = expected
        actual = target.txtMagentoPwD
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMagentoURL"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMagentoURLTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMagentoURL = expected
        actual = target.txtMagentoURL
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMagentoUsername"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMagentoUsernameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMagentoUsername = expected
        actual = target.txtMagentoUsername
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMitgliedsname"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMitgliedsnameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMitgliedsname = expected
        actual = target.txtMitgliedsname
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtmySQLBenutzer"
    '''</summary>
    <TestMethod()> _
    Public Sub txtmySQLBenutzerTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtmySQLBenutzer = expected
        actual = target.txtmySQLBenutzer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtmySQLKennwort"
    '''</summary>
    <TestMethod()> _
    Public Sub txtmySQLKennwortTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtmySQLKennwort = expected
        actual = target.txtmySQLKennwort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMySQLServer"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMySQLServerTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMySQLServer = expected
        actual = target.txtMySQLServer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPasswort"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPasswortTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPasswort = expected
        actual = target.txtPasswort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_20_prozent"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypal_20_prozentTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypal_20_prozent = expected
        actual = target.txtPaypal_20_prozent
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_20_transaktion"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypal_20_transaktionTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypal_20_transaktion = expected
        actual = target.txtPaypal_20_transaktion
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_21_prozent"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypal_21_prozentTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypal_21_prozent = expected
        actual = target.txtPaypal_21_prozent
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_21_transaktion"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypal_21_transaktionTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypal_21_transaktion = expected
        actual = target.txtPaypal_21_transaktion
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_API_Benutzername"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypal_API_BenutzernameTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypal_API_Benutzername = expected
        actual = target.txtPaypal_API_Benutzername
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_API_pwd"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypal_API_pwdTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypal_API_pwd = expected
        actual = target.txtPaypal_API_pwd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypal_API_Signatur"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypal_API_SignaturTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypal_API_Signatur = expected
        actual = target.txtPaypal_API_Signatur
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPOP3Port"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPOP3PortTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPOP3Port = expected
        actual = target.txtPOP3Port
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPOP3Server"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPOP3ServerTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPOP3Server = expected
        actual = target.txtPOP3Server
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPopupDauer"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPopupDauerTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPopupDauer = expected
        actual = target.txtPopupDauer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtShop_url_bilder"
    '''</summary>
    <TestMethod()> _
    Public Sub txtShop_url_bilderTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtShop_url_bilder = expected
        actual = target.txtShop_url_bilder
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtShopGalerie"
    '''</summary>
    <TestMethod()> _
    Public Sub txtShopGalerieTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtShopGalerie = expected
        actual = target.txtShopGalerie
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtShopURL"
    '''</summary>
    <TestMethod()> _
    Public Sub txtShopURLTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtShopURL = expected
        actual = target.txtShopURL
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSMTPPort"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSMTPPortTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSMTPPort = expected
        actual = target.txtSMTPPort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSMTPServer"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSMTPServerTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSMTPServer = expected
        actual = target.txtSMTPServer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSoundeffekt"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSoundeffektTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSoundeffekt = expected
        actual = target.txtSoundeffekt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSplashscreen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSplashscreenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSplashscreen = expected
        actual = target.txtSplashscreen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtUploadPfad"
    '''</summary>
    <TestMethod()> _
    Public Sub txtUploadPfadTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtUploadPfad = expected
        actual = target.txtUploadPfad
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtVorlageQuellcode"
    '''</summary>
    <TestMethod()> _
    Public Sub txtVorlageQuellcodeTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtVorlageQuellcode = expected
        actual = target.txtVorlageQuellcode
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtYABE_pwd"
    '''</summary>
    <TestMethod()> _
    Public Sub txtYABE_pwdTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtYABE_pwd = expected
        actual = target.txtYABE_pwd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtYABE_usr"
    '''</summary>
    <TestMethod()> _
    Public Sub txtYABE_usrTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtYABE_usr = expected
        actual = target.txtYABE_usr
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtYABETrennzeichen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtYABETrennzeichenTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtYABETrennzeichen = expected
        actual = target.txtYABETrennzeichen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Undo"
    '''</summary>
    <TestMethod()> _
    Public Sub UndoTest()
        Dim target As frmOptions = New frmOptions ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Undo = expected
        actual = target.Undo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
