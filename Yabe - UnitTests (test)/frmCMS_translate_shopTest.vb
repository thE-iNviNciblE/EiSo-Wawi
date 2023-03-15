Imports System

Imports System.Data

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmCMS_translate_shopTest" und soll
'''alle frmCMS_translate_shopTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmCMS_translate_shopTest


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
    '''Ein Test für "frmCMS_translate_shop-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmCMS_translate_shopConstructorTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnSpeichern_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnSpeichern_ClickTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnSpeichern_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSuchen_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnSuchen_ClickTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnSuchen_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbShopCategory_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbShopCategory_SelectedIndexChangedTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbShopCategory_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSprache_Artikeldatenbank_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbSprache_Artikeldatenbank_SelectedIndexChangedTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbSprache_Artikeldatenbank_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DataGridView1_CellEnter"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DataGridView1_CellEnterTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DataGridView1_CellEnter(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DataGridView1_MouseClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DataGridView1_MouseClickTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DataGridView1_MouseClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmShopStringTranslator_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmShopStringTranslator_LoadTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmShopStringTranslator_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getSQLQuery"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getSQLQueryTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim bSuchen As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getSQLQuery(bSuchen)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtQuelle_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtQuelle_KeyDownTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtQuelle_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtQuelle_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtQuelle_TextChangedTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtQuelle_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSuchen_GotFocus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSuchen_GotFocusTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSuchen_GotFocus(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSuchen_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSuchen_KeyDownTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSuchen_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSuchen_LostFocus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtSuchen_LostFocusTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtSuchen_LostFocus(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtZiel_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtZiel_TextChangedTest()
        Dim target As frmCMS_translate_shop_Accessor = New frmCMS_translate_shop_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtZiel_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSpeichern"
    '''</summary>
    <TestMethod()> _
    Public Sub btnSpeichernTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnSpeichern = expected
        actual = target.btnSpeichern
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSuchen"
    '''</summary>
    <TestMethod()> _
    Public Sub btnSuchenTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnSuchen = expected
        actual = target.btnSuchen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbShopCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbShopCategoryTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbShopCategory = expected
        actual = target.cmbShopCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSprache_Artikeldatenbank"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbSprache_ArtikeldatenbankTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbSprache_Artikeldatenbank = expected
        actual = target.cmbSprache_Artikeldatenbank
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DataGridView1"
    '''</summary>
    <TestMethod()> _
    Public Sub DataGridView1Test()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As DataGridView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DataGridView
        target.DataGridView1 = expected
        actual = target.DataGridView1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DataTable1"
    '''</summary>
    <TestMethod()> _
    Public Sub DataTable1Test()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As DataTable = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DataTable
        target.DataTable1 = expected
        actual = target.DataTable1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label119"
    '''</summary>
    <TestMethod()> _
    Public Sub Label119Test()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label119 = expected
        actual = target.Label119
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label19"
    '''</summary>
    <TestMethod()> _
    Public Sub Label19Test()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label19 = expected
        actual = target.Label19
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblQuellsprache"
    '''</summary>
    <TestMethod()> _
    Public Sub lblQuellspracheTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblQuellsprache = expected
        actual = target.lblQuellsprache
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblZielsprache"
    '''</summary>
    <TestMethod()> _
    Public Sub lblZielspracheTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblZielsprache = expected
        actual = target.lblZielsprache
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tblMisc"
    '''</summary>
    <TestMethod()> _
    Public Sub tblMiscTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As DataSet = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DataSet
        target.tblMisc = expected
        actual = target.tblMisc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtQuelle"
    '''</summary>
    <TestMethod()> _
    Public Sub txtQuelleTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtQuelle = expected
        actual = target.txtQuelle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSuchen"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSuchenTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSuchen = expected
        actual = target.txtSuchen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtZiel"
    '''</summary>
    <TestMethod()> _
    Public Sub txtZielTest()
        Dim target As frmCMS_translate_shop = New frmCMS_translate_shop ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtZiel = expected
        actual = target.txtZiel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
