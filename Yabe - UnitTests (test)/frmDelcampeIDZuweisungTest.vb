Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmDelcampeIDZuweisungTest" und soll
'''alle frmDelcampeIDZuweisungTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmDelcampeIDZuweisungTest


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
    '''Ein Test für "frmDelcampeIDZuweisung-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmDelcampeIDZuweisungConstructorTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BenutzeDelcampeIDToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BenutzeDelcampeIDToolStripMenuItem_ClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BenutzeDelcampeIDToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnKategorieEdotir_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnKategorieEdotir_ClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnKategorieEdotir_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button1_ClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button2_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Cancel_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Cancel_ClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Cancel_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Cancel_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Cancel_Click_1Test()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Cancel_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmDelcampeIDZuweisung_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmDelcampeIDZuweisung_KeyDownTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmDelcampeIDZuweisung_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmDelcampeIDZuweisung_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmDelcampeIDZuweisung_LoadTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmDelcampeIDZuweisung_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LöschenToolStripMenuItem_ClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LöschenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMultiSelect_ColumnClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwMultiSelect_ColumnClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwMultiSelect_ColumnClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OK_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OK_ClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OK_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OK_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OK_Click_1Test()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OK_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setSelected2Listview"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setSelected2ListviewTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSelected2Listview
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabPage1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TabPage1_ClickTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TabPage1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtNeueID_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtNeueID_TextChangedTest()
        Dim target As frmDelcampeIDZuweisung_Accessor = New frmDelcampeIDZuweisung_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtNeueID_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BenutzeDelcampeIDToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BenutzeDelcampeIDToolStripMenuItemTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BenutzeDelcampeIDToolStripMenuItem = expected
        actual = target.BenutzeDelcampeIDToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnKategorieEdotir"
    '''</summary>
    <TestMethod()> _
    Public Sub btnKategorieEdotirTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnKategorieEdotir = expected
        actual = target.btnKategorieEdotir
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnOKArtikelID"
    '''</summary>
    <TestMethod()> _
    Public Sub btnOKArtikelIDTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnOKArtikelID = expected
        actual = target.btnOKArtikelID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Button2"
    '''</summary>
    <TestMethod()> _
    Public Sub Button2Test()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Button2 = expected
        actual = target.Button2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Cancel"
    '''</summary>
    <TestMethod()> _
    Public Sub CancelTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Cancel = expected
        actual = target.Cancel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ContextMenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ContextMenuStrip1Test()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.ContextMenuStrip1 = expected
        actual = target.ContextMenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_delcampe"
    '''</summary>
    <TestMethod()> _
    Public Sub item_delcampeTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblMainArtikel"
    '''</summary>
    <TestMethod()> _
    Public Sub lblMainArtikelTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblMainArtikel = expected
        actual = target.lblMainArtikel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblMainMenue"
    '''</summary>
    <TestMethod()> _
    Public Sub lblMainMenueTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblMainMenue = expected
        actual = target.lblMainMenue
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub LöschenToolStripMenuItemTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.LöschenToolStripMenuItem = expected
        actual = target.LöschenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMultiSelect"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMultiSelectTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMultiSelect = expected
        actual = target.lvwMultiSelect
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OK"
    '''</summary>
    <TestMethod()> _
    Public Sub OKTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.OK = expected
        actual = target.OK
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PasswordLabel"
    '''</summary>
    <TestMethod()> _
    Public Sub PasswordLabelTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.PasswordLabel = expected
        actual = target.PasswordLabel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tabMainTab"
    '''</summary>
    <TestMethod()> _
    Public Sub tabMainTabTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabControl
        target.tabMainTab = expected
        actual = target.tabMainTab
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabPage1"
    '''</summary>
    <TestMethod()> _
    Public Sub TabPage1Test()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.TabPage1 = expected
        actual = target.TabPage1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabPage2"
    '''</summary>
    <TestMethod()> _
    Public Sub TabPage2Test()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.TabPage2 = expected
        actual = target.TabPage2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtDelcampeID"
    '''</summary>
    <TestMethod()> _
    Public Sub txtDelcampeIDTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtDelcampeID = expected
        actual = target.txtDelcampeID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtKategoriename"
    '''</summary>
    <TestMethod()> _
    Public Sub txtKategorienameTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtKategoriename = expected
        actual = target.txtKategoriename
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtNeueID"
    '''</summary>
    <TestMethod()> _
    Public Sub txtNeueIDTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtNeueID = expected
        actual = target.txtNeueID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "UsernameLabel"
    '''</summary>
    <TestMethod()> _
    Public Sub UsernameLabelTest()
        Dim target As frmDelcampeIDZuweisung = New frmDelcampeIDZuweisung ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.UsernameLabel = expected
        actual = target.UsernameLabel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
