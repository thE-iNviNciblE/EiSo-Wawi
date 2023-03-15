Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmMagentoMangerTest" und soll
'''alle frmMagentoMangerTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmMagentoMangerTest


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
    '''Ein Test für "frmMagentoManger-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmMagentoMangerConstructorTest()
        Dim target As frmMagentoManger = New frmMagentoManger
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnMagentoLogin_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnMagentoLogin_Click_1Test()
        Dim target As frmMagentoManger_Accessor = New frmMagentoManger_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnMagentoLogin_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmMagentoManger_Accessor = New frmMagentoManger_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmMagentoManger_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmMagentoManger_LoadTest()
        Dim target As frmMagentoManger_Accessor = New frmMagentoManger_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmMagentoManger_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmMagentoManger_Accessor = New frmMagentoManger_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnMagentoLogin"
    '''</summary>
    <TestMethod()> _
    Public Sub btnMagentoLoginTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnMagentoLogin = expected
        actual = target.btnMagentoLogin
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader1"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader1Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
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
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader10 = expected
        actual = target.ColumnHeader10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader19"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader19Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader19 = expected
        actual = target.ColumnHeader19
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader2"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader2Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader2 = expected
        actual = target.ColumnHeader2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader20"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader20Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader20 = expected
        actual = target.ColumnHeader20
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader21"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader21Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader21 = expected
        actual = target.ColumnHeader21
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader22"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader22Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader22 = expected
        actual = target.ColumnHeader22
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader23"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader23Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader23 = expected
        actual = target.ColumnHeader23
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader24"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader24Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader24 = expected
        actual = target.ColumnHeader24
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColumnHeader3"
    '''</summary>
    <TestMethod()> _
    Public Sub ColumnHeader3Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
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
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
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
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
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
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
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
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
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
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
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
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ColumnHeader9 = expected
        actual = target.ColumnHeader9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMagentoArtikel"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMagentoArtikelTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMagentoArtikel = expected
        actual = target.lvwMagentoArtikel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMagentoKategorie"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMagentoKategorieTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMagentoKategorie = expected
        actual = target.lvwMagentoKategorie
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwMagentoKunden"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwMagentoKundenTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwMagentoKunden = expected
        actual = target.lvwMagentoKunden
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "magento_email"
    '''</summary>
    <TestMethod()> _
    Public Sub magento_emailTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.magento_email = expected
        actual = target.magento_email
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "magento_user_city"
    '''</summary>
    <TestMethod()> _
    Public Sub magento_user_cityTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.magento_user_city = expected
        actual = target.magento_user_city
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "magento_user_country"
    '''</summary>
    <TestMethod()> _
    Public Sub magento_user_countryTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.magento_user_country = expected
        actual = target.magento_user_country
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "magento_user_id"
    '''</summary>
    <TestMethod()> _
    Public Sub magento_user_idTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.magento_user_id = expected
        actual = target.magento_user_id
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "magento_user_name"
    '''</summary>
    <TestMethod()> _
    Public Sub magento_user_nameTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.magento_user_name = expected
        actual = target.magento_user_name
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "magento_user_pwdhash"
    '''</summary>
    <TestMethod()> _
    Public Sub magento_user_pwdhashTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.magento_user_pwdhash = expected
        actual = target.magento_user_pwdhash
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SplitContainer1"
    '''</summary>
    <TestMethod()> _
    Public Sub SplitContainer1Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As SplitContainer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As SplitContainer
        target.SplitContainer1 = expected
        actual = target.SplitContainer1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabPage3"
    '''</summary>
    <TestMethod()> _
    Public Sub TabPage3Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.TabPage3 = expected
        actual = target.TabPage3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabPage4"
    '''</summary>
    <TestMethod()> _
    Public Sub TabPage4Test()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.TabPage4 = expected
        actual = target.TabPage4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tbMagentoSub"
    '''</summary>
    <TestMethod()> _
    Public Sub tbMagentoSubTest()
        Dim target As frmMagentoManger = New frmMagentoManger ' TODO: Passenden Wert initialisieren
        Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabControl
        target.tbMagentoSub = expected
        actual = target.tbMagentoSub
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
