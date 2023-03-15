Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmCMS_Shop_cateory_treeTest" und soll
'''alle frmCMS_Shop_cateory_treeTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmCMS_Shop_cateory_treeTest


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
    '''Ein Test für "frmCMS_Shop_cateory_tree-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmCMS_Shop_cateory_treeConstructorTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnExpandAll_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnExpandAll_ClickTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnExpandAll_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button1_ClickTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmShop_cateory_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmShop_cateory_LoadTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmShop_cateory_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KategorieLöschenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KategorieLöschenToolStripMenuItem_ClickTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KategorieLöschenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NeueHauptToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NeueHauptToolStripMenuItem_ClickTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NeueHauptToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TreeViewCategory_NodeMouseDoubleClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TreeViewCategory_NodeMouseDoubleClickTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As TreeNodeMouseClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TreeViewCategory_NodeMouseDoubleClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "UnterkategorieAnlegenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub UnterkategorieAnlegenToolStripMenuItem_ClickTest()
        Dim target As frmCMS_Shop_cateory_tree_Accessor = New frmCMS_Shop_cateory_tree_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.UnterkategorieAnlegenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAuktionsanfang"
    '''</summary>
    <TestMethod()> _
    Public Sub btnAuktionsanfangTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnAuktionsanfang = expected
        actual = target.btnAuktionsanfang
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnExpandAll"
    '''</summary>
    <TestMethod()> _
    Public Sub btnExpandAllTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnExpandAll = expected
        actual = target.btnExpandAll
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1"
    '''</summary>
    <TestMethod()> _
    Public Sub Button1Test()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button1 = expected
        actual = target.Button1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmsCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub cmsCategoryTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.cmsCategory = expected
        actual = target.cmsCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KategorieLöschenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub KategorieLöschenToolStripMenuItemTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KategorieLöschenToolStripMenuItem = expected
        actual = target.KategorieLöschenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NeueHauptToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub NeueHauptToolStripMenuItemTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.NeueHauptToolStripMenuItem = expected
        actual = target.NeueHauptToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TextBox1"
    '''</summary>
    <TestMethod()> _
    Public Sub TextBox1Test()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
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
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator1 = expected
        actual = target.ToolStripSeparator1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TreeViewCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub TreeViewCategoryTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As TreeView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TreeView
        target.TreeViewCategory = expected
        actual = target.TreeViewCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "UnterkategorieAnlegenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub UnterkategorieAnlegenToolStripMenuItemTest()
        Dim target As frmCMS_Shop_cateory_tree = New frmCMS_Shop_cateory_tree ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.UnterkategorieAnlegenToolStripMenuItem = expected
        actual = target.UnterkategorieAnlegenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
