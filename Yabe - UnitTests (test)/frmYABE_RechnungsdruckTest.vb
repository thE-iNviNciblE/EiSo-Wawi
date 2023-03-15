Imports System

Imports AxDHTMLEDLib

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmYABE_RechnungsdruckTest" und soll
'''alle frmYABE_RechnungsdruckTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmYABE_RechnungsdruckTest


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
    '''Ein Test für "frmYABE_Rechnungsdruck-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmYABE_RechnungsdruckConstructorTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnAbbrechen_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnAbbrechen_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnAbbrechen_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnBack_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnBack_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnVor_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnVor_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button1_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSprache_Rechnungsdruck_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbSprache_Rechnungsdruck_SelectedIndexChangedTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbSprache_Rechnungsdruck_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbVorlagen_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbVorlagen_SelectedIndexChangedTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbVorlagen_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DruckenToolStripButton_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DruckenToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmYABERechnung_FormClosing"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmYABERechnung_FormClosingTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As FormClosingEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmYABERechnung_FormClosing(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmYABERechnung_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmYABERechnung_KeyDownTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmYABERechnung_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmYABERechnung_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmYABERechnung_LoadTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmYABERechnung_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getReload"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getReloadTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getReload
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getYABERechnung_Artikel"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getYABERechnung_ArtikelTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim strData As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strDataExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getYABERechnung_Artikel(strData)
        Assert.AreEqual(strDataExpected, strData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getYABERechnung_Kundenanschrift"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getYABERechnung_KundenanschriftTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim strData As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strDataExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getYABERechnung_Kundenanschrift(strData)
        Assert.AreEqual(strDataExpected, strData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel1_LinkClicked"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LinkLabel1_LinkClickedTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As LinkLabelLinkClickedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LinkLabel1_LinkClicked(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel2_LinkClicked"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LinkLabel2_LinkClickedTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As LinkLabelLinkClickedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LinkLabel2_LinkClicked(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NeuToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NeuToolStripButton_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NeuToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ÖffnenToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ÖffnenToolStripButton_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ÖffnenToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setBack"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setBackTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setBack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setLook"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setLookTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim bModus As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setLook(bModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setToolbar"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setToolbarTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim bMode As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setToolbar(bMode)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setVor"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setVorTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setVor
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABENewRechnung"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setYABENewRechnungTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABENewRechnung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SpeichernToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SpeichernToolStripButton_ClickTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SpeichernToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "webYabeRechnung_DocumentCompleted"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub webYabeRechnung_DocumentCompletedTest()
        Dim target As frmYABE_Rechnungsdruck_Accessor = New frmYABE_Rechnungsdruck_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As WebBrowserDocumentCompletedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.webYabeRechnung_DocumentCompleted(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AusschneidenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub AusschneidenToolStripButtonTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.AusschneidenToolStripButton = expected
        actual = target.AusschneidenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Bild"
    '''</summary>
    <TestMethod()> _
    Public Sub BildTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Bold = expected
        actual = target.Bold
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAbbrechen"
    '''</summary>
    <TestMethod()> _
    Public Sub btnAbbrechenTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnAbbrechen = expected
        actual = target.btnAbbrechen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack"
    '''</summary>
    <TestMethod()> _
    Public Sub btnBackTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnBack = expected
        actual = target.btnBack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnPrint"
    '''</summary>
    <TestMethod()> _
    Public Sub btnPrintTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnPrint = expected
        actual = target.btnPrint
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor"
    '''</summary>
    <TestMethod()> _
    Public Sub btnVorTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnVor = expected
        actual = target.btnVor
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkArchiv"
    '''</summary>
    <TestMethod()> _
    Public Sub chkArchivTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkArchiv = expected
        actual = target.chkArchiv
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSprache_Rechnungsdruck"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbSprache_RechnungsdruckTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbSprache_Rechnungsdruck = expected
        actual = target.cmbSprache_Rechnungsdruck
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbVorlagen"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbVorlagenTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbVorlagen = expected
        actual = target.cmbVorlagen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DHTMLControll"
    '''</summary>
    <TestMethod()> _
    Public Sub DHTMLControllTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As AxDHTMLEdit = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As AxDHTMLEdit
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.EinfügenToolStripButton = expected
        actual = target.EinfügenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Hyperlink"
    '''</summary>
    <TestMethod()> _
    Public Sub HyperlinkTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Hyperlink = expected
        actual = target.Hyperlink
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub KopierenToolStripButtonTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label19"
    '''</summary>
    <TestMethod()> _
    Public Sub Label19Test()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label19 = expected
        actual = target.Label19
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label34"
    '''</summary>
    <TestMethod()> _
    Public Sub Label34Test()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label34 = expected
        actual = target.Label34
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel1"
    '''</summary>
    <TestMethod()> _
    Public Sub LinkLabel1Test()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As LinkLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As LinkLabel
        target.LinkLabel1 = expected
        actual = target.LinkLabel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel2"
    '''</summary>
    <TestMethod()> _
    Public Sub LinkLabel2Test()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As LinkLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As LinkLabel
        target.LinkLabel2 = expected
        actual = target.LinkLabel2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NeuToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub NeuToolStripButtonTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As Panel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Redo"
    '''</summary>
    <TestMethod()> _
    Public Sub RedoTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Redo = expected
        actual = target.Redo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SaveFileDialog1"
    '''</summary>
    <TestMethod()> _
    Public Sub SaveFileDialog1Test()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As SaveFileDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As SaveFileDialog
        target.SaveFileDialog1 = expected
        actual = target.SaveFileDialog1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SpeichernToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub SpeichernToolStripButtonTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.SpeichernToolStripButton = expected
        actual = target.SpeichernToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Suchen"
    '''</summary>
    <TestMethod()> _
    Public Sub SuchenTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.tabelle = expected
        actual = target.tabelle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStrip1Test()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
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
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator2 = expected
        actual = target.toolStripSeparator2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtVorlageQuellcode"
    '''</summary>
    <TestMethod()> _
    Public Sub txtVorlageQuellcodeTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtVorlageQuellcode = expected
        actual = target.txtVorlageQuellcode
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Undo"
    '''</summary>
    <TestMethod()> _
    Public Sub UndoTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Undo = expected
        actual = target.Undo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "webYabeRechnung"
    '''</summary>
    <TestMethod()> _
    Public Sub webYabeRechnungTest()
        Dim target As frmYABE_Rechnungsdruck = New frmYABE_Rechnungsdruck ' TODO: Passenden Wert initialisieren
        Dim expected As WebBrowser = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As WebBrowser
        target.webYabeRechnung = expected
        actual = target.webYabeRechnung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
