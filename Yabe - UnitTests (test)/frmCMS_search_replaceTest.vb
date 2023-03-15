Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmCMS_search_replaceTest" und soll
'''alle frmCMS_search_replaceTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmCMS_search_replaceTest


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
    '''Ein Test für "frmCMS_search_replace-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmCMS_search_replaceConstructorTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnOKSearchReplace_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnOKSearchReplace_ClickTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnOKSearchReplace_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button2_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button2_ClickTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button2_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkLiveAlle_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkLiveAlle_CheckedChangedTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkLiveAlle_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeKategorieIDZuweisenToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeKategorieIDZuweisenToolStripMenuItem1_ClickTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeKategorieIDZuweisenToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmCMS_search_replace_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmCMS_search_replace_KeyDownTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmCMS_search_replace_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmCMS_search_replace_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmCMS_search_replace_LoadTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmCMS_search_replace_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setMarkColor"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setMarkColorTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim strSuchen As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setMarkColor(strSuchen)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSearchReplace"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setSearchReplaceTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim strSuche As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strErsetzten As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSearchReplace(strSuche, strErsetzten)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSelected2Listview"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setSelected2ListviewTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSelected2Listview
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setUpdateLvwData"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setUpdateLvwDataTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setUpdateLvwData
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSuchen_LostFocus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSuchen_LostFocusTest()
        Dim target As frmCMS_search_replace_Accessor = New frmCMS_search_replace_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSuchen_LostFocus(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnOKSearchReplace"
    '''</summary>
    <TestMethod()> _
    Public Sub btnOKSearchReplaceTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnOKSearchReplace = expected
        actual = target.btnOKSearchReplace
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button2"
    '''</summary>
    <TestMethod()> _
    Public Sub Button2Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button2 = expected
        actual = target.Button2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkVorschau"
    '''</summary>
    <TestMethod()> _
    Public Sub chkVorschauTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkVorschau = expected
        actual = target.chkVorschau
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ContextMenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ContextMenuStrip1Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.ContextMenuStrip1 = expected
        actual = target.ContextMenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeKategorieIDZuweisenToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeKategorieIDZuweisenToolStripMenuItem1Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeKategorieIDZuweisenToolStripMenuItem1 = expected
        actual = target.DelcampeKategorieIDZuweisenToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_delcampe"
    '''</summary>
    <TestMethod()> _
    Public Sub item_delcampeTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_delcampe = expected
        actual = target.item_delcampe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_descrition"
    '''</summary>
    <TestMethod()> _
    Public Sub item_descritionTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_descrition = expected
        actual = target.item_descrition
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_ebay"
    '''</summary>
    <TestMethod()> _
    Public Sub item_ebayTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_ebay = expected
        actual = target.item_ebay
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_id"
    '''</summary>
    <TestMethod()> _
    Public Sub item_idTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_id = expected
        actual = target.item_id
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_magento"
    '''</summary>
    <TestMethod()> _
    Public Sub item_magentoTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_magento = expected
        actual = target.item_magento
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
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
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblMainArtikel"
    '''</summary>
    <TestMethod()> _
    Public Sub lblMainArtikelTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblMainArtikel = expected
        actual = target.lblMainArtikel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMultiSelect"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMultiSelectTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMultiSelect = expected
        actual = target.lvwMultiSelect
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MagentoKategorieIDZuweisenToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub MagentoKategorieIDZuweisenToolStripMenuItem1Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MagentoKategorieIDZuweisenToolStripMenuItem1 = expected
        actual = target.MagentoKategorieIDZuweisenToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator1Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator1 = expected
        actual = target.ToolStripSeparator1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripStatusLabel1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripStatusLabel1Test()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.ToolStripStatusLabel1 = expected
        actual = target.ToolStripStatusLabel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtErsetzen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtErsetzenTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtErsetzen = expected
        actual = target.txtErsetzen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSuchen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSuchenTest()
        Dim target As frmCMS_search_replace = New frmCMS_search_replace ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSuchen = expected
        actual = target.txtSuchen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
