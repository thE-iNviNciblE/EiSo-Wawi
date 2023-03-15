Imports System.Xml

Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmDelcampe_Category_editorTest" und soll
'''alle frmDelcampe_Category_editorTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmDelcampe_Category_editorTest


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
    '''Ein Test für "frmDelcampe_Category_editor-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmDelcampe_Category_editorConstructorTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "AddTreeViewChildNodes"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub AddTreeViewChildNodesTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim parent_nodes As TreeNodeCollection = Nothing ' TODO: Passenden Wert initialisieren
        Dim xml_node As XmlNode = Nothing ' TODO: Passenden Wert initialisieren
        target.AddTreeViewChildNodes(parent_nodes, xml_node)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button1_ClickTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Form1_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Form1_LoadTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Form1_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmDelcampe_Category_editor_FormClosing"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmDelcampe_Category_editor_FormClosingTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As FormClosingEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmDelcampe_Category_editor_FormClosing(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getDelcampeXML_base_category"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getDelcampeXML_base_categoryTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim iMinus_selected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDelcampeXML_base_category(iMinus_selected)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getDelcampeXML_category"
    '''</summary>
    <TestMethod()> _
    Public Sub getDelcampeXML_categoryTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim xml_node As XmlNode = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strCategoryID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bSuchen As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDelcampeXML_category(xml_node, lvw, strName, strCategoryID, bSuchen)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getDelcampeXML_category_find"
    '''</summary>
    <TestMethod()> _
    Public Sub getDelcampeXML_category_findTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim xml_node As XmlNode = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDelcampeXML_category_find(xml_node)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getDelcampeXML_search_id"
    '''</summary>
    <TestMethod()> _
    Public Sub getDelcampeXML_search_idTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDelcampeXML_search_id
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getDelcampeXML_sites"
    '''</summary>
    <TestMethod()> _
    Public Sub getDelcampeXML_sitesTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim xml_node As XmlNode = Nothing ' TODO: Passenden Wert initialisieren
        Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDelcampeXML_sites(xml_node, strName)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getKategorieName"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getKategorieNameTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getKategorieName
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lstDelcampeXML_main_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lstDelcampeXML_main_SelectedIndexChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lstDelcampeXML_main_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_2_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwMain_2_SelectedIndexChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwMain_2_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_3_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwMain_3_SelectedIndexChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwMain_3_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_4_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwMain_4_SelectedIndexChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwMain_4_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_5_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwMain_5_SelectedIndexChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwMain_5_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_6_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwMain_6_SelectedIndexChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwMain_6_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwMain_SelectedIndexChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwMain_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setComboBoxIndex"
    '''</summary>
    <TestMethod()> _
    Public Sub setComboBoxIndexTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim iid As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setComboBoxIndex(iid)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setLVW_search_select"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setLVW_search_selectTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim iid As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setLVW_search_select(lvw, iid)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TextBox1_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TextBox1_KeyDownTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TextBox1_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TextBox1_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TextBox1_TextChangedTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TextBox1_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSearchID_DoubleClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSearchID_DoubleClickTest()
        Dim target As frmDelcampe_Category_editor_Accessor = New frmDelcampe_Category_editor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSearchID_DoubleClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSuchen"
    '''</summary>
    <TestMethod()> _
    Public Sub btnSuchenTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnSuchen = expected
        actual = target.btnSuchen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colCategoryID"
    '''</summary>
    <TestMethod()> _
    Public Sub colCategoryIDTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colCategoryID = expected
        actual = target.colCategoryID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colKategorie_2"
    '''</summary>
    <TestMethod()> _
    Public Sub colKategorie_2Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colKategorie_2 = expected
        actual = target.colKategorie_2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colName"
    '''</summary>
    <TestMethod()> _
    Public Sub colNameTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colName = expected
        actual = target.colName
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colName_2"
    '''</summary>
    <TestMethod()> _
    Public Sub colName_2Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colName_2 = expected
        actual = target.colName_2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colParent"
    '''</summary>
    <TestMethod()> _
    Public Sub colParentTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colParent = expected
        actual = target.colParent
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colParent_2"
    '''</summary>
    <TestMethod()> _
    Public Sub colParent_2Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colParent_2 = expected
        actual = target.colParent_2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader1"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader1Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader1 = expected
        actual = target.ColumnHeader1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader10"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader10Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader10 = expected
        actual = target.ColumnHeader10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader11"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader11Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader11 = expected
        actual = target.ColumnHeader11
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader12"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader12Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader12 = expected
        actual = target.ColumnHeader12
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader2"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader2Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader2 = expected
        actual = target.ColumnHeader2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader3"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader3Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader3 = expected
        actual = target.ColumnHeader3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader4"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader4Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader4 = expected
        actual = target.ColumnHeader4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader5"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader5Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader5 = expected
        actual = target.ColumnHeader5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader6"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader6Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader6 = expected
        actual = target.ColumnHeader6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader7"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader7Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader7 = expected
        actual = target.ColumnHeader7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader8"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader8Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader8 = expected
        actual = target.ColumnHeader8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader9"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader9Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader9 = expected
        actual = target.ColumnHeader9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
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
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblBereich"
    '''</summary>
    <TestMethod()> _
    Public Sub lblBereichTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblBereich = expected
        actual = target.lblBereich
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lstDelcampeXML_main"
    '''</summary>
    <TestMethod()> _
    Public Sub lstDelcampeXML_mainTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.lstDelcampeXML_main = expected
        actual = target.lstDelcampeXML_main
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMainTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMain = expected
        actual = target.lvwMain
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_2"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMain_2Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMain_2 = expected
        actual = target.lvwMain_2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_3"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMain_3Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMain_3 = expected
        actual = target.lvwMain_3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_4"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMain_4Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMain_4 = expected
        actual = target.lvwMain_4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_5"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMain_5Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMain_5 = expected
        actual = target.lvwMain_5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMain_6"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMain_6Test()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMain_6 = expected
        actual = target.lvwMain_6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSearchID"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSearchIDTest()
        Dim target As frmDelcampe_Category_editor = New frmDelcampe_Category_editor ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSearchID = expected
        actual = target.txtSearchID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
