Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmYABE_WebBrowserTest" und soll
'''alle frmYABE_WebBrowserTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmYABE_WebBrowserTest


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
    '''Ein Test für "frmYABE_WebBrowser-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmYABE_WebBrowserConstructorTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikelvorbestelltToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ArtikelvorbestelltToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ArtikelvorbestelltToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikelVorToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ArtikelVorToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ArtikelVorToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikelZurückToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ArtikelZurückToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ArtikelZurückToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BenutzeAutomatischNeuladenhintergrundToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BenutzeAutomatischNeuladenhintergrundToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BenutzeAutomatischNeuladenhintergrundToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbVorlagen_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbVorlagen_SelectedIndexChangedTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbVorlagen_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmdSprachen_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmdSprachen_SelectedIndexChangedTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmdSprachen_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeArtikelansichtToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeArtikelansichtToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeArtikelansichtToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeAutoprintToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeAutoprintToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeAutoprintToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeBewertungToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeBewertungToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeBewertungToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeVersandkostenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeVersandkostenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeVersandkostenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeVersandkostenToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeVersandkostenToolStripMenuItem1_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeVersandkostenToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DirektDruckenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DirektDruckenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DirektDruckenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckvorschauToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DruckvorschauToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DruckvorschauToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayAdressenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayAdressenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayAdressenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArtikelansichtToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayArtikelansichtToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayArtikelansichtToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayBewertungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayBewertungenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayBewertungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayVersanddatenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayVersanddatenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayVersanddatenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWebBrowser_Activated"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWebBrowser_ActivatedTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWebBrowser_Activated(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWebBrowser_Deactivate"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWebBrowser_DeactivateTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWebBrowser_Deactivate(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWebBrowser_FormClosing"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWebBrowser_FormClosingTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As FormClosingEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWebBrowser_FormClosing(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWebBrowser_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWebBrowser_KeyDownTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWebBrowser_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWebBrowser_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWebBrowser_LoadTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWebBrowser_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWebBrowser_Resize"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWebBrowser_ResizeTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWebBrowser_Resize(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWebBrowser_ResizeEnd"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWebBrowser_ResizeEndTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWebBrowser_ResizeEnd(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FullscreenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FullscreenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FullscreenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getDasOertliche"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getDasOertlicheTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDasOertliche
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getDelcampeStatus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getDelcampeStatusTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDelcampeStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getGoogleMaps"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getGoogleMapsTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getGoogleMaps
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getTransaktionWhole"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getTransaktionWholeTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getTransaktionWhole
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getYasniPerson"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getYasniPersonTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getYasniPerson
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "goNavigate"
    '''</summary>
    <TestMethod()> _
    Public Sub goNavigateTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim strURL As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.goNavigate(strURL)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ImmerImVordergrundToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ImmerImVordergrundToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ImmerImVordergrundToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ImmerImVordergrundToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ImmerImVordergrundToolStripMenuItem1_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ImmerImVordergrundToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InfobarAnzeigenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InfobarAnzeigenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.InfobarAnzeigenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinDelcampeToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeinDelcampeToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeinDelcampeToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinDelcampeToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeinDelcampeToolStripMenuItem1_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeinDelcampeToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinEBayToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeinEBayToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeinEBayToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinEBayToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeinEBayToolStripMenuItem1_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeinEBayToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineBewertungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeineBewertungenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeineBewertungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineKontostandToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeineKontostandToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeineKontostandToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineStatistikToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeineStatistikToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeineStatistikToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "parameter_laden"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub parameter_ladenTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.parameter_laden
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PlattformArtikelansichtToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub PlattformArtikelansichtToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.PlattformArtikelansichtToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SchließenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SchließenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SchließenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SchließenToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SchließenToolStripMenuItem1_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SchließenToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setAutoNeuLaden"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setAutoNeuLadenTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        target.setAutoNeuLaden()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setBack"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setBackTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setBack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDataUpdate"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setDataUpdateTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim bBlättern As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setDataUpdate(bBlättern)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setInfobar"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setInfobarTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        target.setInfobar()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setModebyBestellstatus"
    '''</summary>
    <TestMethod()> _
    Public Sub setModebyBestellstatusTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim iAnzahl As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setModebyBestellstatus(iAnzahl)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setOnTop"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setOnTopTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        target.setOnTop()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setReloadModus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setReloadModusTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setReloadModus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setStatus2Modus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setStatus2ModusTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim strStatus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strPlattform As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setStatus2Modus(strStatus, strPlattform)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setTransparent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setTransparentTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        target.setTransparent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setVor"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setVorTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setVor
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebBrowser_delcampe_bewertung"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setWebBrowser_delcampe_bewertungTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim strOverWriteLanguage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebBrowser_delcampe_bewertung(strOverWriteLanguage)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebBrowser_delcampe_login"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setWebBrowser_delcampe_loginTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebBrowser_delcampe_login
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebBrowser_delcampe_versand"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setWebBrowser_delcampe_versandTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim strOverWriteLanguage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebBrowser_delcampe_versand(strOverWriteLanguage)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebContextMenue"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setWebContextMenueTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebContextMenue
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopAdminbestellungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ShopAdminbestellungenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ShopAdminbestellungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopAdminpanelToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ShopAdminpanelToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ShopAdminpanelToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopAdminpanelToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ShopAdminpanelToolStripMenuItem1_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ShopAdminpanelToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopArtikelvorbestelltToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ShopArtikelvorbestelltToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ShopArtikelvorbestelltToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopBestelltToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ShopBestelltToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ShopBestelltToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1_Panel1_MouseDoubleClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SplitContainer1_Panel1_MouseDoubleClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SplitContainer1_Panel1_MouseDoubleClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1_Panel1_MouseDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SplitContainer1_Panel1_MouseDownTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SplitContainer1_Panel1_MouseDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1_Panel1_Paint"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SplitContainer1_Panel1_PaintTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As PaintEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SplitContainer1_Panel1_Paint(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1_Resize"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SplitContainer1_ResizeTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SplitContainer1_Resize(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TransparentToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TransparentToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TransparentToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPlattform_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPlattform_TextChangedTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPlattform_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtURL_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtURL_KeyDownTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtURL_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "VollbildToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub VollbildToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.VollbildToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "VorToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub VorToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.VorToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "VorToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub VorToolStripMenuItem1_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.VorToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "WebAnsichtToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub WebAnsichtToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.WebAnsichtToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "webDelcampe_navigateSelector"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webDelcampe_navigateSelectorTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim strSKU As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strDelCampUserID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strWebID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.webDelcampe_navigateSelector(strSKU, strDelCampUserID, strWebID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "webMain_DocumentCompleted"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webMain_DocumentCompletedTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As WebBrowserDocumentCompletedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.webMain_DocumentCompleted(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "webMain_DocumentCompleted_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webMain_DocumentCompleted_1Test()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As WebBrowserDocumentCompletedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.webMain_DocumentCompleted_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "webMain_DocumentCompleted_2"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webMain_DocumentCompleted_2Test()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As WebBrowserDocumentCompletedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.webMain_DocumentCompleted_2(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "webMain_FileDownload"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webMain_FileDownloadTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.webMain_FileDownload(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "webMain_PreviewKeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webMain_PreviewKeyDownTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As PreviewKeyDownEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.webMain_PreviewKeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "webMain_ProgressChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webMain_ProgressChangedTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As WebBrowserProgressChangedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.webMain_ProgressChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEDasOertlicheToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEDasOertlicheToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEDasOertlicheToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundenverlaufToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEKundenverlaufToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEKundenverlaufToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEMapsToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEMapsToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEMapsToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABESeiteDruckenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABESeiteDruckenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABESeiteDruckenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEVersandkostenÄndernToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEVersandkostenÄndernToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEVersandkostenÄndernToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEVorlageneditorToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEVorlageneditorToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEVorlageneditorToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEYASNIToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEYASNIToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEYASNIToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ZurückToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ZurückToolStripMenuItem_ClickTest()
        Dim target As frmYABE_WebBrowser_Accessor = New frmYABE_WebBrowser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ZurückToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AnsichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub AnsichtToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.AnsichtToolStripMenuItem = expected
        actual = target.AnsichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikelvorbestelltToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ArtikelvorbestelltToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ArtikelvorbestelltToolStripMenuItem = expected
        actual = target.ArtikelvorbestelltToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikelVorToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ArtikelVorToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ArtikelVorToolStripMenuItem = expected
        actual = target.ArtikelVorToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikelZurückToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ArtikelZurückToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ArtikelZurückToolStripMenuItem = expected
        actual = target.ArtikelZurückToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BenutzeAutomatischNeuladenhintergrundToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BenutzeAutomatischNeuladenhintergrundToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BenutzeAutomatischNeuladenhintergrundToolStripMenuItem = expected
        actual = target.BenutzeAutomatischNeuladenhintergrundToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbVorlagen"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbVorlagenTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbVorlagen = expected
        actual = target.cmbVorlagen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmdSprachen"
    '''</summary>
    <TestMethod()> _
    Public Sub cmdSprachenTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmdSprachen = expected
        actual = target.cmdSprachen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ContextMenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ContextMenuStrip1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.ContextMenuStrip1 = expected
        actual = target.ContextMenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeArtikelansichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeArtikelansichtToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeArtikelansichtToolStripMenuItem = expected
        actual = target.DelcampeArtikelansichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeAutoprintToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeAutoprintToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeAutoprintToolStripMenuItem = expected
        actual = target.DelcampeAutoprintToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeBewertungToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeBewertungToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeBewertungToolStripMenuItem = expected
        actual = target.DelcampeBewertungToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeVersandkostenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeVersandkostenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeVersandkostenToolStripMenuItem = expected
        actual = target.DelcampeVersandkostenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeVersandkostenToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeVersandkostenToolStripMenuItem1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeVersandkostenToolStripMenuItem1 = expected
        actual = target.DelcampeVersandkostenToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DirektDruckenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DirektDruckenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DirektDruckenToolStripMenuItem = expected
        actual = target.DirektDruckenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DruckenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DruckenToolStripMenuItem = expected
        actual = target.DruckenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckvorschauToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DruckvorschauToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DruckvorschauToolStripMenuItem = expected
        actual = target.DruckvorschauToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayAdressenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayAdressenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayAdressenToolStripMenuItem = expected
        actual = target.EBayAdressenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArtikelansichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayArtikelansichtToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayArtikelansichtToolStripMenuItem = expected
        actual = target.EBayArtikelansichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayBewertungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayBewertungenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayBewertungenToolStripMenuItem = expected
        actual = target.EBayBewertungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayVersanddatenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayVersanddatenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayVersanddatenToolStripMenuItem = expected
        actual = target.EBayVersanddatenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FullscreenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub FullscreenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.FullscreenToolStripMenuItem = expected
        actual = target.FullscreenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ImmerImVordergrundToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub ImmerImVordergrundToolStripMenuItem1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ImmerImVordergrundToolStripMenuItem1 = expected
        actual = target.ImmerImVordergrundToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InfobarAnzeigenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub InfobarAnzeigenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.InfobarAnzeigenToolStripMenuItem = expected
        actual = target.InfobarAnzeigenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label2"
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label25"
    '''</summary>
    <TestMethod()> _
    Public Sub Label25Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label25 = expected
        actual = target.Label25
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label3"
    '''</summary>
    <TestMethod()> _
    Public Sub Label3Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label3 = expected
        actual = target.Label3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label4"
    '''</summary>
    <TestMethod()> _
    Public Sub Label4Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label4 = expected
        actual = target.Label4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label5"
    '''</summary>
    <TestMethod()> _
    Public Sub Label5Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label5 = expected
        actual = target.Label5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label7"
    '''</summary>
    <TestMethod()> _
    Public Sub Label7Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label7 = expected
        actual = target.Label7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblKategorien"
    '''</summary>
    <TestMethod()> _
    Public Sub lblKategorienTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblKategorien = expected
        actual = target.lblKategorien
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblTitel"
    '''</summary>
    <TestMethod()> _
    Public Sub lblTitelTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblTitel = expected
        actual = target.lblTitel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LinksToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub LinksToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.LinksToolStripMenuItem = expected
        actual = target.LinksToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinDelcampeToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeinDelcampeToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeinDelcampeToolStripMenuItem = expected
        actual = target.MeinDelcampeToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinDelcampeToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub MeinDelcampeToolStripMenuItem1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeinDelcampeToolStripMenuItem1 = expected
        actual = target.MeinDelcampeToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinEBayToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeinEBayToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeinEBayToolStripMenuItem = expected
        actual = target.MeinEBayToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinEBayToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub MeinEBayToolStripMenuItem1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeinEBayToolStripMenuItem1 = expected
        actual = target.MeinEBayToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineBewertungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeineBewertungenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeineBewertungenToolStripMenuItem = expected
        actual = target.MeineBewertungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineKontostandToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeineKontostandToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeineKontostandToolStripMenuItem = expected
        actual = target.MeineKontostandToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineStatistikToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeineStatistikToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeineStatistikToolStripMenuItem = expected
        actual = target.MeineStatistikToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub MenuStrip1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As MenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As MenuStrip
        target.MenuStrip1 = expected
        actual = target.MenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MenuStrip2"
    '''</summary>
    <TestMethod()> _
    Public Sub MenuStrip2Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As MenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As MenuStrip
        target.MenuStrip2 = expected
        actual = target.MenuStrip2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NavigationToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub NavigationToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.NavigationToolStripMenuItem = expected
        actual = target.NavigationToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NaviToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub NaviToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.NaviToolStripMenuItem = expected
        actual = target.NaviToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PlattformArtikelansichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub PlattformArtikelansichtToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.PlattformArtikelansichtToolStripMenuItem = expected
        actual = target.PlattformArtikelansichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SchließenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SchließenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SchließenToolStripMenuItem = expected
        actual = target.SchließenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SchließenToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub SchließenToolStripMenuItem1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SchließenToolStripMenuItem1 = expected
        actual = target.SchließenToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopAdminbestellungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ShopAdminbestellungenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ShopAdminbestellungenToolStripMenuItem = expected
        actual = target.ShopAdminbestellungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopAdminpanelToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ShopAdminpanelToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ShopAdminpanelToolStripMenuItem = expected
        actual = target.ShopAdminpanelToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopAdminpanelToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub ShopAdminpanelToolStripMenuItem1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ShopAdminpanelToolStripMenuItem1 = expected
        actual = target.ShopAdminpanelToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopArtikelvorbestelltToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ShopArtikelvorbestelltToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ShopArtikelvorbestelltToolStripMenuItem = expected
        actual = target.ShopArtikelvorbestelltToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopBestelltToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ShopBestelltToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ShopBestelltToolStripMenuItem = expected
        actual = target.ShopBestelltToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1"
    '''</summary>
    <TestMethod()> _
    Public Sub SplitContainer1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As SplitContainer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As SplitContainer
        target.SplitContainer1 = expected
        actual = target.SplitContainer1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripBYtes"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripBYtesTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.ToolStripBYtes = expected
        actual = target.ToolStripBYtes
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripProgressBar1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripProgressBar1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripProgressBar
        target.ToolStripProgressBar1 = expected
        actual = target.ToolStripProgressBar1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator1 = expected
        actual = target.ToolStripSeparator1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator2"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator2Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator2 = expected
        actual = target.ToolStripSeparator2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator3"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator3Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator3 = expected
        actual = target.ToolStripSeparator3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator4"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator4Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator4 = expected
        actual = target.ToolStripSeparator4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator5"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator5Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator5 = expected
        actual = target.ToolStripSeparator5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator6"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator6Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator6 = expected
        actual = target.ToolStripSeparator6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolTip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolTip1Test()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolTip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolTip
        target.ToolTip1 = expected
        actual = target.ToolTip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TransparentToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub TransparentToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.TransparentToolStripMenuItem = expected
        actual = target.TransparentToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBild"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBildTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBild = expected
        actual = target.txtBild
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEndpreis"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEndpreisTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEndpreis = expected
        actual = target.txtEndpreis
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtHerkunftSprachen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtHerkunftSprachenTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtHerkunftSprachen = expected
        actual = target.txtHerkunftSprachen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtKategorien"
    '''</summary>
    <TestMethod()> _
    Public Sub txtKategorienTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtKategorien = expected
        actual = target.txtKategorien
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtKundenAnschrift"
    '''</summary>
    <TestMethod()> _
    Public Sub txtKundenAnschriftTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtKundenAnschrift = expected
        actual = target.txtKundenAnschrift
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMitteilung"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMitteilungTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMitteilung = expected
        actual = target.txtMitteilung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPlattformGebühr"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPlattformGebührTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPlattformGebühr = expected
        actual = target.txtPlattformGebühr
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtTitel"
    '''</summary>
    <TestMethod()> _
    Public Sub txtTitelTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtTitel = expected
        actual = target.txtTitel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtURL"
    '''</summary>
    <TestMethod()> _
    Public Sub txtURLTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripTextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripTextBox
        target.txtURL = expected
        actual = target.txtURL
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "VollbildToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub VollbildToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.VollbildToolStripMenuItem = expected
        actual = target.VollbildToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "VorToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub VorToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.VorToolStripMenuItem = expected
        actual = target.VorToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "WebAnsichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub WebAnsichtToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.WebAnsichtToolStripMenuItem = expected
        actual = target.WebAnsichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "webMain"
    '''</summary>
    <TestMethod()> _
    Public Sub webMainTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As WebBrowser = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As WebBrowser
        target.webMain = expected
        actual = target.webMain
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "webMessageStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub webMessageStatusTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.webMessageStatus = expected
        actual = target.webMessageStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEDasOertlicheToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEDasOertlicheToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEDasOertlicheToolStripMenuItem = expected
        actual = target.YABEDasOertlicheToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundenverlaufToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEKundenverlaufToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEKundenverlaufToolStripMenuItem = expected
        actual = target.YABEKundenverlaufToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEMapsToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEMapsToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEMapsToolStripMenuItem = expected
        actual = target.YABEMapsToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABESeiteDruckenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABESeiteDruckenToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABESeiteDruckenToolStripMenuItem = expected
        actual = target.YABESeiteDruckenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEVersandkostenÄndernToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEVersandkostenÄndernToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEVersandkostenÄndernToolStripMenuItem = expected
        actual = target.YABEVersandkostenÄndernToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEVorlageneditorToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEVorlageneditorToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEVorlageneditorToolStripMenuItem = expected
        actual = target.YABEVorlageneditorToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEYASNIToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEYASNIToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEYASNIToolStripMenuItem = expected
        actual = target.YABEYASNIToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ZurückToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ZurückToolStripMenuItemTest()
        Dim target As frmYABE_WebBrowser = New frmYABE_WebBrowser ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ZurückToolStripMenuItem = expected
        actual = target.ZurückToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
