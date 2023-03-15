Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FrmGetHighBiddersTest" und soll
'''alle FrmGetHighBiddersTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FrmGetHighBiddersTest


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
    '''Ein Test für "FrmGetHighBidders-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FrmGetHighBiddersConstructorTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnBack_ClickTest()
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnBack_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetHighBidders_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnGetHighBidders_ClickTest()
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnGetHighBidders_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnVor_ClickTest()
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmGetHighBidders_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmGetHighBidders_KeyDownTest()
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmGetHighBidders_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmGetHighBidders_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmGetHighBidders_LoadTest()
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmGetHighBidders_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtItemId_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TxtItemId_TextChangedTest()
        Dim target As FrmGetHighBidders_Accessor = New FrmGetHighBidders_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TxtItemId_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack"
    '''</summary>
    <TestMethod()> _
    Public Sub btnBackTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnBack = expected
        actual = target.btnBack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetHighBidders"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnGetHighBiddersTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnGetHighBidders = expected
        actual = target.BtnGetHighBidders
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor"
    '''</summary>
    <TestMethod()> _
    Public Sub btnVorTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnVor = expected
        actual = target.btnVor
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmAction"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmActionTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmAction = expected
        actual = target.ClmAction
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmCurrency"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmCurrencyTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmCurrency = expected
        actual = target.ClmCurrency
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmMaxBid"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmMaxBidTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmMaxBid = expected
        actual = target.ClmMaxBid
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmQuantiy"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmQuantiyTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmQuantiy = expected
        actual = target.ClmQuantiy
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmTimeBid"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmTimeBidTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmTimeBid = expected
        actual = target.ClmTimeBid
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmUser"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmUserTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmUser = expected
        actual = target.ClmUser
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpResults"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpResultsTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpResults = expected
        actual = target.GrpResults
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblItemIdTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblItemId = expected
        actual = target.LblItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LstHighBids"
    '''</summary>
    <TestMethod()> _
    Public Sub LstHighBidsTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.LstHighBids = expected
        actual = target.LstHighBids
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtItemIdTest()
        Dim target As FrmGetHighBidders = New FrmGetHighBidders ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtItemId = expected
        actual = target.TxtItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
