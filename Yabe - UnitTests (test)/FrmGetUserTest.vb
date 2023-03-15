Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FrmGetUserTest" und soll
'''alle FrmGetUserTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FrmGetUserTest


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
    '''Ein Test für "FrmGetUser-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FrmGetUserConstructorTest()
        Dim target As FrmGetUser = New FrmGetUser
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnBack_ClickTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnBack_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetUser_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnGetUser_ClickTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnGetUser_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnVor_ClickTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnVor_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmGetUser_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmGetUser_KeyDownTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmGetUser_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmGetUser_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmGetUser_LoadTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmGetUser_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getBestellverlauf"
    '''</summary>
    <TestMethod()> _
    Public Sub getBestellverlaufTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim stremail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getBestellverlauf(stremail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setEnable_Disable"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setEnable_DisableTest()
        Dim target As FrmGetUser_Accessor = New FrmGetUser_Accessor ' TODO: Passenden Wert initialisieren
        Dim bModus As Boolean = False ' TODO: Passenden Wert initialisieren
        target.setEnable_Disable(bModus)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "bids"
    '''</summary>
    <TestMethod()> _
    Public Sub bidsTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnBack = expected
        actual = target.btnBack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetUser"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnGetUserTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnGetUser = expected
        actual = target.BtnGetUser
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor"
    '''</summary>
    <TestMethod()> _
    Public Sub btnVorTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnVor = expected
        actual = target.btnVor
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "eBayBeschreibung"
    '''</summary>
    <TestMethod()> _
    Public Sub eBayBeschreibungTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.eBayBeschreibung = expected
        actual = target.eBayBeschreibung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GroupBox1"
    '''</summary>
    <TestMethod()> _
    Public Sub GroupBox1Test()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GroupBox1 = expected
        actual = target.GroupBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpResult"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpResultTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpResult = expected
        actual = target.GrpResult
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ID"
    '''</summary>
    <TestMethod()> _
    Public Sub IDTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ID = expected
        actual = target.ID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label5 = expected
        actual = target.Label5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblEmail"
    '''</summary>
    <TestMethod()> _
    Public Sub LblEmailTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblEmail = expected
        actual = target.LblEmail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblFeedBackScore"
    '''</summary>
    <TestMethod()> _
    Public Sub LblFeedBackScoreTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblFeedBackScore = expected
        actual = target.LblFeedBackScore
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblItemIdTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblItemId = expected
        actual = target.LblItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblLastChanged"
    '''</summary>
    <TestMethod()> _
    Public Sub LblLastChangedTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblLastChanged = expected
        actual = target.LblLastChanged
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblNew"
    '''</summary>
    <TestMethod()> _
    Public Sub LblNewTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblNew = expected
        actual = target.LblNew
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblPaypal"
    '''</summary>
    <TestMethod()> _
    Public Sub lblPaypalTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblPaypal = expected
        actual = target.lblPaypal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblPreis"
    '''</summary>
    <TestMethod()> _
    Public Sub lblPreisTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblPreis = expected
        actual = target.lblPreis
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblRatingPercent"
    '''</summary>
    <TestMethod()> _
    Public Sub lblRatingPercentTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblRatingPercent = expected
        actual = target.lblRatingPercent
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblRegDate"
    '''</summary>
    <TestMethod()> _
    Public Sub LblRegDateTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblRegDate = expected
        actual = target.LblRegDate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblSellerLevel"
    '''</summary>
    <TestMethod()> _
    Public Sub LblSellerLevelTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblSellerLevel = expected
        actual = target.LblSellerLevel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblSite"
    '''</summary>
    <TestMethod()> _
    Public Sub LblSiteTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblSite = expected
        actual = target.LblSite
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblStoreUrl"
    '''</summary>
    <TestMethod()> _
    Public Sub LblStoreUrlTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblStoreUrl = expected
        actual = target.LblStoreUrl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblUserId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblUserIdTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblUserId = expected
        actual = target.LblUserId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblVerified"
    '''</summary>
    <TestMethod()> _
    Public Sub LblVerifiedTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblVerified = expected
        actual = target.LblVerified
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwBestellverlauf"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwBestellverlaufTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwBestellverlauf = expected
        actual = target.lvwBestellverlauf
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Preis"
    '''</summary>
    <TestMethod()> _
    Public Sub PreisTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.Preis = expected
        actual = target.Preis
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "status"
    '''</summary>
    <TestMethod()> _
    Public Sub statusTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.status = expected
        actual = target.status
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tab_bassisinformation"
    '''</summary>
    <TestMethod()> _
    Public Sub tab_bassisinformationTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tab_bassisinformation = expected
        actual = target.tab_bassisinformation
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tab_details"
    '''</summary>
    <TestMethod()> _
    Public Sub tab_detailsTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tab_details = expected
        actual = target.tab_details
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tabUserDetails"
    '''</summary>
    <TestMethod()> _
    Public Sub tabUserDetailsTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabControl
        target.tabUserDetails = expected
        actual = target.tabUserDetails
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtChanged"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtChangedTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtChanged = expected
        actual = target.TxtChanged
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtEmail"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtEmailTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtEmail = expected
        actual = target.TxtEmail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtFeedBackScore"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtFeedBackScoreTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtFeedBackScore = expected
        actual = target.TxtFeedBackScore
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtItemIdTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtItemId = expected
        actual = target.TxtItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLand"
    '''</summary>
    <TestMethod()> _
    Public Sub txtLandTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtName = expected
        actual = target.txtName
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtNew"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtNewTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtNew = expected
        actual = target.TxtNew
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtOrtPLZ"
    '''</summary>
    <TestMethod()> _
    Public Sub txtOrtPLZTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtOrtPLZ = expected
        actual = target.txtOrtPLZ
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypalAccount"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypalAccountTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypalAccount = expected
        actual = target.txtPaypalAccount
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPaypalConfirmed"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPaypalConfirmedTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPaypalConfirmed = expected
        actual = target.txtPaypalConfirmed
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtRegDate"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtRegDateTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtRegDate = expected
        actual = target.TxtRegDate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtSellerLevel"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtSellerLevelTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtSellerLevel = expected
        actual = target.TxtSellerLevel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtSite"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtSiteTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtSite = expected
        actual = target.TxtSite
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtStar"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtStarTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtStar = expected
        actual = target.TxtStar
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtStoreUrl"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtStoreUrlTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtStoreUrl = expected
        actual = target.TxtStoreUrl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtStraße"
    '''</summary>
    <TestMethod()> _
    Public Sub txtStraßeTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtUserId = expected
        actual = target.TxtUserId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtVerified"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtVerifiedTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtVerified = expected
        actual = target.TxtVerified
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "yabe_auktionsende"
    '''</summary>
    <TestMethod()> _
    Public Sub yabe_auktionsendeTest()
        Dim target As FrmGetUser = New FrmGetUser ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.yabe_auktionsende = expected
        actual = target.yabe_auktionsende
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
