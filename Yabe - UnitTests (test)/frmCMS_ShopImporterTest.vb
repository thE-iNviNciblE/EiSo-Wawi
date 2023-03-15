Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmCMS_ShopImporterTest" und soll
'''alle frmCMS_ShopImporterTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmCMS_ShopImporterTest


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
    '''Ein Test für "frmCMS_ShopImporter-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmCMS_ShopImporterConstructorTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnSuchen_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnSuchen_ClickTest()
        Dim target As frmCMS_ShopImporter_Accessor = New frmCMS_ShopImporter_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnSuchen_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button1_ClickTest()
        Dim target As frmCMS_ShopImporter_Accessor = New frmCMS_ShopImporter_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button3_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button3_ClickTest()
        Dim target As frmCMS_ShopImporter_Accessor = New frmCMS_ShopImporter_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button3_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmCMS_ShopImporter_Accessor = New frmCMS_ShopImporter_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmShopImporter_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmShopImporter_LoadTest()
        Dim target As frmCMS_ShopImporter_Accessor = New frmCMS_ShopImporter_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmShopImporter_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmCMS_ShopImporter_Accessor = New frmCMS_ShopImporter_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LöschenToolStripMenuItem_ClickTest()
        Dim target As frmCMS_ShopImporter_Accessor = New frmCMS_ShopImporter_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LöschenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Beschreibung"
    '''</summary>
    <TestMethod()> _
    Public Sub BeschreibungTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.Beschreibung = expected
        actual = target.Beschreibung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Bild"
    '''</summary>
    <TestMethod()> _
    Public Sub BildTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.Bild = expected
        actual = target.Bild
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSave"
    '''</summary>
    <TestMethod()> _
    Public Sub btnSaveTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnSave = expected
        actual = target.btnSave
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSuchen"
    '''</summary>
    <TestMethod()> _
    Public Sub btnSuchenTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnSuchen = expected
        actual = target.btnSuchen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button3"
    '''</summary>
    <TestMethod()> _
    Public Sub Button3Test()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button3 = expected
        actual = target.Button3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmsMain"
    '''</summary>
    <TestMethod()> _
    Public Sub cmsMainTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.cmsMain = expected
        actual = target.cmsMain
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmsStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub cmsStatusTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.cmsStatus = expected
        actual = target.cmsStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label119"
    '''</summary>
    <TestMethod()> _
    Public Sub Label119Test()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label119 = expected
        actual = target.Label119
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub LöschenToolStripMenuItemTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.LöschenToolStripMenuItem = expected
        actual = target.LöschenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwImporter"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwImporterTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwImporter = expected
        actual = target.lvwImporter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OpenFileDialog1"
    '''</summary>
    <TestMethod()> _
    Public Sub OpenFileDialog1Test()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As OpenFileDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As OpenFileDialog
        target.OpenFileDialog1 = expected
        actual = target.OpenFileDialog1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Preis"
    '''</summary>
    <TestMethod()> _
    Public Sub PreisTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.Preis = expected
        actual = target.Preis
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ProgressBar1"
    '''</summary>
    <TestMethod()> _
    Public Sub ProgressBar1Test()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ProgressBar
        target.ProgressBar1 = expected
        actual = target.ProgressBar1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "roDelcampeImport"
    '''</summary>
    <TestMethod()> _
    Public Sub roDelcampeImportTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.roDelcampeImport = expected
        actual = target.roDelcampeImport
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "roeBay"
    '''</summary>
    <TestMethod()> _
    Public Sub roeBayTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.roeBay = expected
        actual = target.roeBay
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolMain"
    '''</summary>
    <TestMethod()> _
    Public Sub toolMainTest()
        Dim target As frmCMS_ShopImporter = New frmCMS_ShopImporter ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.toolMain = expected
        actual = target.toolMain
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
