Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmKunde_bestellverlaufTest" und soll
'''alle frmKunde_bestellverlaufTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmKunde_bestellverlaufTest


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
    '''Ein Test für "frmKunde_bestellverlauf-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmKunde_bestellverlaufConstructorTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "AnsichtAktuallisierenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub AnsichtAktuallisierenToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.AnsichtAktuallisierenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BestelltToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BestelltToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BestelltToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BezahltToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BezahltToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BezahltToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnBack_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnBack_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnTest_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnTest_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnTest_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnVor_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnVor_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Cancel_Button_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Cancel_Button_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Cancel_Button_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmBestellverlauf_FormClosing"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmBestellverlauf_FormClosingTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As FormClosingEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmBestellverlauf_FormClosing(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmBestellverlauf_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmBestellverlauf_KeyDownTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmBestellverlauf_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmBestellverlauf_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmBestellverlauf_LoadTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmBestellverlauf_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getBestellverlauf"
    '''</summary>
    <TestMethod()> _
    Public Sub getBestellverlaufTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getBestellverlauf
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KomplettToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KomplettToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KomplettToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenArtikelnummerToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KopierenArtikelnummerToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KopierenArtikelnummerToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenEmailToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KopierenEmailToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KopierenEmailToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenMitgliedsnameToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KopierenMitgliedsnameToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KopierenMitgliedsnameToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LöschenToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LöschenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwBestellverlauf_ColumnClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwBestellverlauf_ColumnClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwBestellverlauf_ColumnClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MakierenAlleToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MakierenAlleToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MakierenAlleToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OK_Button_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OK_Button_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OK_Button_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setGUILook"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setGUILookTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim bEnabled As Boolean = False ' TODO: Passenden Wert initialisieren
        target.setGUILook(bEnabled)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1_Panel2_Paint"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SplitContainer1_Panel2_PaintTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As PaintEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SplitContainer1_Panel2_Paint(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "StorniertToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub StorniertToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.StorniertToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheArtikelToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SucheArtikelToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SucheArtikelToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheBestellungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SucheBestellungenToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SucheBestellungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundeToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SucheKundeToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SucheKundeToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ÜbersichtExportierenZumDruckenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ÜbersichtExportierenZumDruckenToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ÜbersichtExportierenZumDruckenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "VerschicktToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub VerschicktToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.VerschicktToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEArtikelansichtToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEArtikelansichtToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEArtikelansichtToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABERechnungsdruckToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABERechnungsdruckToolStripMenuItem_ClickTest()
        Dim target As frmKunde_bestellverlauf_Accessor = New frmKunde_bestellverlauf_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABERechnungsdruckToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AnsichtAktuallisierenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub AnsichtAktuallisierenToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.AnsichtAktuallisierenToolStripMenuItem = expected
        actual = target.AnsichtAktuallisierenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellstatusToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BestellstatusToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BestellstatusToolStripMenuItem = expected
        actual = target.BestellstatusToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BestelltToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BestelltToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BestelltToolStripMenuItem = expected
        actual = target.BestelltToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BezahltToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BezahltToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BezahltToolStripMenuItem = expected
        actual = target.BezahltToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "bids"
    '''</summary>
    <TestMethod()> _
    Public Sub bidsTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.bids = expected
        actual = target.bids
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack"
    '''</summary>
    <TestMethod()> _
    Public Sub btnBackTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnBack = expected
        actual = target.btnBack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnCloseForm"
    '''</summary>
    <TestMethod()> _
    Public Sub btnCloseFormTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnCloseForm = expected
        actual = target.btnCloseForm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnTest"
    '''</summary>
    <TestMethod()> _
    Public Sub btnTestTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnTest = expected
        actual = target.btnTest
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor"
    '''</summary>
    <TestMethod()> _
    Public Sub btnVorTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnVor = expected
        actual = target.btnVor
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmsBestellübersicht"
    '''</summary>
    <TestMethod()> _
    Public Sub cmsBestellübersichtTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.cmsBestellübersicht = expected
        actual = target.cmsBestellübersicht
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "eBayBeschreibung"
    '''</summary>
    <TestMethod()> _
    Public Sub eBayBeschreibungTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.eBayBeschreibung = expected
        actual = target.eBayBeschreibung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "email"
    '''</summary>
    <TestMethod()> _
    Public Sub emailTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.email = expected
        actual = target.email
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ID"
    '''</summary>
    <TestMethod()> _
    Public Sub IDTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ID = expected
        actual = target.ID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KomplettToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub KomplettToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KomplettToolStripMenuItem = expected
        actual = target.KomplettToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenArtikelnummerToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub KopierenArtikelnummerToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KopierenArtikelnummerToolStripMenuItem = expected
        actual = target.KopierenArtikelnummerToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenEmailToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub KopierenEmailToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KopierenEmailToolStripMenuItem = expected
        actual = target.KopierenEmailToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenMitgliedsnameToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub KopierenMitgliedsnameToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KopierenMitgliedsnameToolStripMenuItem = expected
        actual = target.KopierenMitgliedsnameToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label10 = expected
        actual = target.Label10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label2"
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label3"
    '''</summary>
    <TestMethod()> _
    Public Sub Label3Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label5 = expected
        actual = target.Label5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label6"
    '''</summary>
    <TestMethod()> _
    Public Sub Label6Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label6 = expected
        actual = target.Label6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label7"
    '''</summary>
    <TestMethod()> _
    Public Sub Label7Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label7 = expected
        actual = target.Label7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label8"
    '''</summary>
    <TestMethod()> _
    Public Sub Label8Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label8 = expected
        actual = target.Label8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label9"
    '''</summary>
    <TestMethod()> _
    Public Sub Label9Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label9 = expected
        actual = target.Label9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblBestellverlauf"
    '''</summary>
    <TestMethod()> _
    Public Sub lblBestellverlaufTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblBestellverlauf = expected
        actual = target.lblBestellverlauf
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblGesammtsumme"
    '''</summary>
    <TestMethod()> _
    Public Sub lblGesammtsummeTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblGesammtsumme = expected
        actual = target.lblGesammtsumme
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblUserId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblUserIdTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblUserId = expected
        actual = target.LblUserId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub LöschenToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.LöschenToolStripMenuItem = expected
        actual = target.LöschenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwBestellverlauf"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwBestellverlaufTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwBestellverlauf = expected
        actual = target.lvwBestellverlauf
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MakierenAlleToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MakierenAlleToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MakierenAlleToolStripMenuItem = expected
        actual = target.MakierenAlleToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "mitglied"
    '''</summary>
    <TestMethod()> _
    Public Sub mitgliedTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.mitglied = expected
        actual = target.mitglied
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "paypal"
    '''</summary>
    <TestMethod()> _
    Public Sub paypalTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.paypal = expected
        actual = target.paypal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Preis"
    '''</summary>
    <TestMethod()> _
    Public Sub PreisTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.Preis = expected
        actual = target.Preis
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1"
    '''</summary>
    <TestMethod()> _
    Public Sub SplitContainer1Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As SplitContainer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As SplitContainer
        target.SplitContainer1 = expected
        actual = target.SplitContainer1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "status"
    '''</summary>
    <TestMethod()> _
    Public Sub statusTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.status = expected
        actual = target.status
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StorniertToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub StorniertToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.StorniertToolStripMenuItem = expected
        actual = target.StorniertToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheArtikelToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SucheArtikelToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SucheArtikelToolStripMenuItem = expected
        actual = target.SucheArtikelToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheBestellungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SucheBestellungenToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SucheBestellungenToolStripMenuItem = expected
        actual = target.SucheBestellungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundeToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SucheKundeToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SucheKundeToolStripMenuItem = expected
        actual = target.SucheKundeToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TextBox1"
    '''</summary>
    <TestMethod()> _
    Public Sub TextBox1Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TextBox1 = expected
        actual = target.TextBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator1Test()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
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
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator6 = expected
        actual = target.ToolStripSeparator6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmail"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEmailTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEmail = expected
        actual = target.txtEmail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmail_klicks"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEmail_klicksTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEmail_klicks = expected
        actual = target.txtEmail_klicks
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmail_letzte"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEmail_letzteTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEmail_letzte = expected
        actual = target.txtEmail_letzte
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLand"
    '''</summary>
    <TestMethod()> _
    Public Sub txtLandTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtLand = expected
        actual = target.txtLand
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtName"
    '''</summary>
    <TestMethod()> _
    Public Sub txtNameTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtName = expected
        actual = target.txtName
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtOrtPLZ"
    '''</summary>
    <TestMethod()> _
    Public Sub txtOrtPLZTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtOrtPLZ = expected
        actual = target.txtOrtPLZ
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSprachen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSprachenTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSprachen = expected
        actual = target.txtSprachen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtStraße"
    '''</summary>
    <TestMethod()> _
    Public Sub txtStraßeTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtStraße = expected
        actual = target.txtStraße
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtUserId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtUserIdTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtUserId = expected
        actual = target.TxtUserId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ÜbersichtExportierenZumDruckenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ÜbersichtExportierenZumDruckenToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ÜbersichtExportierenZumDruckenToolStripMenuItem = expected
        actual = target.ÜbersichtExportierenZumDruckenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versandkosten"
    '''</summary>
    <TestMethod()> _
    Public Sub versandkostenTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versandkosten = expected
        actual = target.versandkosten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "VerschicktToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub VerschicktToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.VerschicktToolStripMenuItem = expected
        actual = target.VerschicktToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "yabe_auktionsende"
    '''</summary>
    <TestMethod()> _
    Public Sub yabe_auktionsendeTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.yabe_auktionsende = expected
        actual = target.yabe_auktionsende
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "yabe_plattform"
    '''</summary>
    <TestMethod()> _
    Public Sub yabe_plattformTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.yabe_plattform = expected
        actual = target.yabe_plattform
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEArtikelansichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEArtikelansichtToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEArtikelansichtToolStripMenuItem = expected
        actual = target.YABEArtikelansichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABERechnungsdruckToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABERechnungsdruckToolStripMenuItemTest()
        Dim target As frmKunde_bestellverlauf = New frmKunde_bestellverlauf ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABERechnungsdruckToolStripMenuItem = expected
        actual = target.YABERechnungsdruckToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
