Imports System.Collections

Imports System.Windows.Forms

Imports eBay.Service.Core.Soap

Imports eBay.Service.Core.Sdk

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clseAPI_eBayTest" und soll
'''alle clseAPI_eBayTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clseAPI_eBayTest


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
    '''Ein Test für "clseAPI_eBay-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clseAPI_eBayConstructorTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test)
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "expSellerTransaktions"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub expSellerTransaktionsTest()
        Dim param0 As PrivateObject = Nothing ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay_Accessor = New clseAPI_eBay_Accessor(param0) ' TODO: Passenden Wert initialisieren
        Dim oTransaction As TransactionType = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.expSellerTransaktions(oTransaction)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Finalize"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FinalizeTest()
        Dim param0 As PrivateObject = Nothing ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay_Accessor = New clseAPI_eBay_Accessor(param0) ' TODO: Passenden Wert initialisieren
        target.Finalize()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayBewertungen_open"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayBewertungen_openTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.geteBayBewertungen_open
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayBidderList"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayBidderListTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strItemID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bInsertLVW As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.geteBayBidderList(lvw, strItemID, strModus, bInsertLVW)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayMessages"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayMessagesTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.geteBayMessages
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayPicture"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayPictureTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim strBeschreibung As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModus As clseAPI_eBay.strBildModus = New clseAPI_eBay.strBildModus ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.geteBayPicture(strBeschreibung, strModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayRechnungen"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayRechnungenTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.geteBayRechnungen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBaySellerList"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBaySellerListTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim iCallPageTotal As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iCallPageTotalExpected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim bEndTime As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim bGeboteOnly As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.geteBaySellerList(iCallPageTotal, bEndTime, bGeboteOnly)
        Assert.AreEqual(iCallPageTotalExpected, iCallPageTotal)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayTime"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayTimeTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim expected As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Object
        actual = target.geteBayTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayUser"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayUserTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strEbayUser As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ArrayList
        actual = target.geteBayUser(streBayID, strEbayUser)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayUserDetails"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayUserDetailsTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim strItem As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strUserID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ArrayList
        actual = target.geteBayUserDetails(strItem, strUserID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getFeedBackList"
    '''</summary>
    <TestMethod()> _
    Public Sub getFeedBackListTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strUserID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lblMessageMaster As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getFeedBackList(lvw, strUserID, lblMessageMaster)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getItemInfo"
    '''</summary>
    <TestMethod()> _
    Public Sub getItemInfoTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim ieBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As ItemType = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ItemType
        actual = target.getItemInfo(ieBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getSellerTransaktions"
    '''</summary>
    <TestMethod()> _
    Public Sub getSellerTransaktionsTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim bExport2Text As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim iVon() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim iBis() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getSellerTransaktions(bExport2Text, iVon, iBis)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getShippment"
    '''</summary>
    <TestMethod()> _
    Public Sub getShippmentTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim itemId As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strMenge As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ZIP As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bInternational As CountryCodeType = New CountryCodeType ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getShippment(itemId, strMenge, ZIP, bInternational)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setAPIContext"
    '''</summary>
    <TestMethod()> _
    Public Sub setAPIContextTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim expected As ApiContext = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ApiContext
        actual = target.setAPIContext
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCompleteSale"
    '''</summary>
    <TestMethod()> _
    Public Sub setCompleteSaleTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim strItemID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strStatus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCompleteSale(strItemID, strStatus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "seteBayOrderStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub seteBayOrderStatusTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.seteBayOrderStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewOrder"
    '''</summary>
    <TestMethod()> _
    Public Sub setNewOrderTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim strAryeBayID() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim strAryTransaktionID() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim strVersandkosten As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strKostenTotal As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strPaymentText As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strVersandServiceName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setNewOrder(strAryeBayID, strAryTransaktionID, strVersandkosten, strKostenTotal, strPaymentText, strVersandServiceName)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setOrderInvoice"
    '''</summary>
    <TestMethod()> _
    Public Sub setOrderInvoiceTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim itemID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim transaktionID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim versandkosten As Double = 0.0! ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setOrderInvoice(itemID, transaktionID, versandkosten)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setTextbox"
    '''</summary>
    <TestMethod()> _
    Public Sub setTextboxTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim str As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setTextbox(str)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "wait4something"
    '''</summary>
    <TestMethod()> _
    Public Sub wait4somethingTest()
        Dim test As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clseAPI_eBay = New clseAPI_eBay(test) ' TODO: Passenden Wert initialisieren
        Dim bMode As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.wait4something(bMode)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
