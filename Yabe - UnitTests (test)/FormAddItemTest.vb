Imports eBay.Service.Core.Soap

Imports System.ComponentModel

Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FormAddItemTest" und soll
'''alle FormAddItemTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FormAddItemTest


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
    '''Ein Test für "FormAddItem-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FormAddItemConstructorTest()
        Dim target As FormAddItem = New FormAddItem
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BtnAddItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnAddItem_ClickTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnAddItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnAddPic_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnAddPic_ClickTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnAddPic_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnRemovePic_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnRemovePic_ClickTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnRemovePic_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnVerIfyAddItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnVerIfyAddItem_ClickTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnVerIfyAddItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "CboListType_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CboListType_SelectedIndexChangedTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.CboListType_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FillItem"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FillItemTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As ItemType = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ItemType
        actual = target.FillItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmAddItem_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmAddItem_LoadTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmAddItem_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "GetPolicyForUS"
    '''</summary>
    <TestMethod()> _
    Public Sub GetPolicyForUSTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As ReturnPolicyType = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ReturnPolicyType
        actual = target.GetPolicyForUS
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getShippingDetails"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getShippingDetailsTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As ShippingDetailsType = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ShippingDetailsType
        actual = target.getShippingDetails
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Label1_ClickTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Label1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LblDuration_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LblDuration_ClickTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LblDuration_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OpenFileDialogIMG_FileOk"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OpenFileDialogIMG_FileOkTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OpenFileDialogIMG_FileOk(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtDescription_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TxtDescription_TextChangedTest()
        Dim target As FormAddItem_Accessor = New FormAddItem_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TxtDescription_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnAddItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnAddItemTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnAddItem = expected
        actual = target.BtnAddItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnAddPic"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnAddPicTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnAddPic = expected
        actual = target.BtnAddPic
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnRemovePic"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnRemovePicTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnRemovePic = expected
        actual = target.BtnRemovePic
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnVerifyAddItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnVerifyAddItemTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnVerifyAddItem = expected
        actual = target.BtnVerifyAddItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboDuration"
    '''</summary>
    <TestMethod()> _
    Public Sub CboDurationTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboDuration = expected
        actual = target.CboDuration
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboListType"
    '''</summary>
    <TestMethod()> _
    Public Sub CboListTypeTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboListType = expected
        actual = target.CboListType
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboPicDisplay"
    '''</summary>
    <TestMethod()> _
    Public Sub CboPicDisplayTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboPicDisplay = expected
        actual = target.CboPicDisplay
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ChkBoldTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub ChkBoldTitleTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.ChkBoldTitle = expected
        actual = target.ChkBoldTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ChkEnableBestOffer"
    '''</summary>
    <TestMethod()> _
    Public Sub ChkEnableBestOfferTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.ChkEnableBestOffer = expected
        actual = target.ChkEnableBestOffer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ChkHighLight"
    '''</summary>
    <TestMethod()> _
    Public Sub ChkHighLightTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.ChkHighLight = expected
        actual = target.ChkHighLight
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpPictures"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpPicturesTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpPictures = expected
        actual = target.GrpPictures
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "grpResults"
    '''</summary>
    <TestMethod()> _
    Public Sub grpResultsTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.grpResults = expected
        actual = target.grpResults
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblApplicationData"
    '''</summary>
    <TestMethod()> _
    Public Sub lblApplicationDataTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblApplicationData = expected
        actual = target.lblApplicationData
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblBuyItNowPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblBuyItNowPriceTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblBuyItNowPrice = expected
        actual = target.LblBuyItNowPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub LblCategoryTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblCategory = expected
        actual = target.LblCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblCategory2"
    '''</summary>
    <TestMethod()> _
    Public Sub lblCategory2Test()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblCategory2 = expected
        actual = target.lblCategory2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblDuration"
    '''</summary>
    <TestMethod()> _
    Public Sub LblDurationTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblDuration = expected
        actual = target.LblDuration
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblItemIdTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblItemId = expected
        actual = target.LblItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblListingFee"
    '''</summary>
    <TestMethod()> _
    Public Sub LblListingFeeTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblListingFee = expected
        actual = target.LblListingFee
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblListType"
    '''</summary>
    <TestMethod()> _
    Public Sub LblListTypeTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblListType = expected
        actual = target.LblListType
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblLocation"
    '''</summary>
    <TestMethod()> _
    Public Sub LblLocationTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblLocation = expected
        actual = target.LblLocation
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblPayPalEmailAddress"
    '''</summary>
    <TestMethod()> _
    Public Sub LblPayPalEmailAddressTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblPayPalEmailAddress = expected
        actual = target.LblPayPalEmailAddress
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblQuantity"
    '''</summary>
    <TestMethod()> _
    Public Sub LblQuantityTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblQuantity = expected
        actual = target.LblQuantity
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblReservePrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblReservePriceTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblReservePrice = expected
        actual = target.LblReservePrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblStartPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblStartPriceTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblStartPrice = expected
        actual = target.LblStartPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub LblTitleTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblTitle = expected
        actual = target.LblTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ListPictures"
    '''</summary>
    <TestMethod()> _
    Public Sub ListPicturesTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As ListBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListBox
        target.ListPictures = expected
        actual = target.ListPictures
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OpenFileDialogIMG"
    '''</summary>
    <TestMethod()> _
    Public Sub OpenFileDialogIMGTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As OpenFileDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As OpenFileDialog
        target.OpenFileDialogIMG = expected
        actual = target.OpenFileDialogIMG
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtApplicationData"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtApplicationDataTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtApplicationData = expected
        actual = target.TxtApplicationData
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtBuyItNowPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtBuyItNowPriceTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtBuyItNowPrice = expected
        actual = target.TxtBuyItNowPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtCategoryTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtCategory = expected
        actual = target.TxtCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtCategory2"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtCategory2Test()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtCategory2 = expected
        actual = target.TxtCategory2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtDescription"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtDescriptionTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtDescription = expected
        actual = target.TxtDescription
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtItemIdTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtItemId = expected
        actual = target.TxtItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtListingFee"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtListingFeeTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtListingFee = expected
        actual = target.TxtListingFee
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtLocation"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtLocationTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtLocation = expected
        actual = target.TxtLocation
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtPayPalEmailAddress"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtPayPalEmailAddressTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtPayPalEmailAddress = expected
        actual = target.TxtPayPalEmailAddress
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtQuantity"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtQuantityTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtQuantity = expected
        actual = target.TxtQuantity
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtReservePrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtReservePriceTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtReservePrice = expected
        actual = target.TxtReservePrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtStartPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtStartPriceTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtStartPrice = expected
        actual = target.TxtStartPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtTitleTest()
        Dim target As FormAddItem = New FormAddItem ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtTitle = expected
        actual = target.TxtTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
