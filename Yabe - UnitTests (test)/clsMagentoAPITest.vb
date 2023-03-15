Imports YabE.net.cubss

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsMagentoAPITest" und soll
'''alle clsMagentoAPITest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsMagentoAPITest


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
    '''Ein Test für "clsMagentoAPI-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsMagentoAPIConstructorTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "getAry2Category"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getAry2CategoryTest()
        Dim target As clsMagentoAPI_Accessor = New clsMagentoAPI_Accessor ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strAry As catalogCategoryTree = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getAry2Category(lvw, strAry)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getAry2Category_level"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getAry2Category_levelTest()
        Dim target As clsMagentoAPI_Accessor = New clsMagentoAPI_Accessor ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strAry As catalogCategoryEntity = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getAry2Category_level(lvw, strAry)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getAry2Products"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getAry2ProductsTest()
        Dim target As clsMagentoAPI_Accessor = New clsMagentoAPI_Accessor ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strAry() As catalogProductEntity = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getAry2Products(lvw, strAry)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getAryKunden2Listview"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getAryKunden2ListviewTest()
        Dim target As clsMagentoAPI_Accessor = New clsMagentoAPI_Accessor ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strAry() As customerCustomerEntity = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getAryKunden2Listview(lvw, strAry)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCategory_info"
    '''</summary>
    <TestMethod()> _
    Public Sub getCategory_infoTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim Category_id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCategory_info(lvw, Category_id)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCategory_products"
    '''</summary>
    <TestMethod()> _
    Public Sub getCategory_productsTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim Category_id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCategory_products(lvw, Category_id)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCategory_products_info"
    '''</summary>
    <TestMethod()> _
    Public Sub getCategory_products_infoTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim sku As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCategory_products_info(lvw, sku)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCategoryTree"
    '''</summary>
    <TestMethod()> _
    Public Sub getCategoryTreeTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCategoryTree(lvw)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getLogin"
    '''</summary>
    <TestMethod()> _
    Public Sub getLoginTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getLogin
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getUserList"
    '''</summary>
    <TestMethod()> _
    Public Sub getUserListTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getUserList(lvw)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCSVExporter"
    '''</summary>
    <TestMethod()> _
    Public Sub setCSVExporterTest()
        Dim target As clsMagentoAPI = New clsMagentoAPI ' TODO: Passenden Wert initialisieren
        Dim oItem As ListViewItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setCSVExporter(oItem)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
