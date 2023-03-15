Imports eBay.Service.Core.Soap

Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FormGetItemRecommendationsTest" und soll
'''alle FormGetItemRecommendationsTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FormGetItemRecommendationsTest


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
    '''Ein Test für "FormGetItemRecommendations-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FormGetItemRecommendationsConstructorTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetCategories_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnGetCategories_ClickTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnGetCategories_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnGetItem_ClickTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnGetItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnListingAnalyzer_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnListingAnalyzer_ClickTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnListingAnalyzer_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnProductPricing_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnProductPricing_ClickTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnProductPricing_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnSuggestedAttr_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnSuggestedAttr_ClickTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnSuggestedAttr_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "CboListingFlow_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CboListingFlow_SelectedIndexChangedTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.CboListingFlow_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
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
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim engine As RecommendationEngineCodeType = New RecommendationEngineCodeType ' TODO: Passenden Wert initialisieren
        Dim expected As ItemType = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ItemType
        actual = target.FillItem(engine)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FormGetRecommendations_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FormGetRecommendations_LoadTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FormGetRecommendations_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LstTips_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LstTips_SelectedIndexChangedTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LstTips_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "StripCDATA"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub StripCDATATest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim cdataString As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.StripCDATA(cdataString)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtTitle_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TxtTitle_TextChangedTest()
        Dim target As FormGetItemRecommendations_Accessor = New FormGetItemRecommendations_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TxtTitle_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetCategories"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnGetCategoriesTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnGetCategories = expected
        actual = target.BtnGetCategories
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnGetItemTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnGetItem = expected
        actual = target.BtnGetItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnListingAnalyzer"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnListingAnalyzerTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnListingAnalyzer = expected
        actual = target.BtnListingAnalyzer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnProductPricing"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnProductPricingTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnProductPricing = expected
        actual = target.BtnProductPricing
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnSuggestedAttr"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnSuggestedAttrTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnSuggestedAttr = expected
        actual = target.BtnSuggestedAttr
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboListingFlow"
    '''</summary>
    <TestMethod()> _
    Public Sub CboListingFlowTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboListingFlow = expected
        actual = target.CboListingFlow
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmAvgSoldPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmAvgSoldPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmAvgSoldPrice = expected
        actual = target.ClmAvgSoldPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmAvgStartPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmAvgStartPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmAvgStartPrice = expected
        actual = target.ClmAvgStartPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmCSID"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmCSIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmCSID = expected
        actual = target.ClmCSID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmFieldID"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmFieldIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmFieldID = expected
        actual = target.ClmFieldID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmFieldText"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmFieldTextTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmFieldText = expected
        actual = target.ClmFieldText
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmFieldTip"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmFieldTipTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmFieldTip = expected
        actual = target.ClmFieldTip
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmHelpURL"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmHelpURLTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmHelpURL = expected
        actual = target.ClmHelpURL
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmID"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmID = expected
        actual = target.ClmID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmInfoID"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmInfoIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmInfoID = expected
        actual = target.ClmInfoID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmMessage"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmMessageTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmMessage = expected
        actual = target.ClmMessage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmNoOfAttr"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmNoOfAttrTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmNoOfAttr = expected
        actual = target.ClmNoOfAttr
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmPriority"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmPriorityTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmPriority = expected
        actual = target.ClmPriority
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmTitleTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmTitle = expected
        actual = target.ClmTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmVersion"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmVersionTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmVersion = expected
        actual = target.ClmVersion
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpResult"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpResultTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpResult = expected
        actual = target.GrpResult
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpSuggestedAttr"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpSuggestedAttrTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpSuggestedAttr = expected
        actual = target.GrpSuggestedAttr
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpSuggestedProducts"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpSuggestedProductsTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpSuggestedProducts = expected
        actual = target.GrpSuggestedProducts
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblAverageSoldPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblAverageSoldPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblAverageSoldPrice = expected
        actual = target.LblAverageSoldPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblAverageStartPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblAverageStartPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblAverageStartPrice = expected
        actual = target.LblAverageStartPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblBuyItNowPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblBuyItNowPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblBuyItNowPrice = expected
        actual = target.LblBuyItNowPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblCatalogTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub LblCatalogTitleTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblCatalogTitle = expected
        actual = target.LblCatalogTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblExternalProductID"
    '''</summary>
    <TestMethod()> _
    Public Sub LblExternalProductIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblExternalProductID = expected
        actual = target.LblExternalProductID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblGetItem"
    '''</summary>
    <TestMethod()> _
    Public Sub lblGetItemTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblGetItem = expected
        actual = target.lblGetItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblItemID"
    '''</summary>
    <TestMethod()> _
    Public Sub LblItemIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblItemID = expected
        actual = target.LblItemID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblListingFlow"
    '''</summary>
    <TestMethod()> _
    Public Sub LblListingFlowTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblListingFlow = expected
        actual = target.LblListingFlow
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblPrimaryCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub LblPrimaryCategoryTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblPrimaryCategory = expected
        actual = target.LblPrimaryCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblQuery"
    '''</summary>
    <TestMethod()> _
    Public Sub LblQueryTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblQuery = expected
        actual = target.LblQuery
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblReservePrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblReservePriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblReservePrice = expected
        actual = target.LblReservePrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblSecondaryCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub LblSecondaryCategoryTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblSecondaryCategory = expected
        actual = target.LblSecondaryCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblStartPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub LblStartPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
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
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblTitle = expected
        actual = target.LblTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LstAttr"
    '''</summary>
    <TestMethod()> _
    Public Sub LstAttrTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.LstAttr = expected
        actual = target.LstAttr
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lstProduct"
    '''</summary>
    <TestMethod()> _
    Public Sub lstProductTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lstProduct = expected
        actual = target.lstProduct
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LstTips"
    '''</summary>
    <TestMethod()> _
    Public Sub LstTipsTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.LstTips = expected
        actual = target.LstTips
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabListingAnalyzer"
    '''</summary>
    <TestMethod()> _
    Public Sub TabListingAnalyzerTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.TabListingAnalyzer = expected
        actual = target.TabListingAnalyzer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabProductPricing"
    '''</summary>
    <TestMethod()> _
    Public Sub TabProductPricingTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.TabProductPricing = expected
        actual = target.TabProductPricing
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabSettings"
    '''</summary>
    <TestMethod()> _
    Public Sub TabSettingsTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabControl
        target.TabSettings = expected
        actual = target.TabSettings
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabSuggestedAttributes"
    '''</summary>
    <TestMethod()> _
    Public Sub TabSuggestedAttributesTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.TabSuggestedAttributes = expected
        actual = target.TabSuggestedAttributes
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtAverageSoldPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtAverageSoldPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtAverageSoldPrice = expected
        actual = target.TxtAverageSoldPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtAverageStartPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtAverageStartPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtAverageStartPrice = expected
        actual = target.TxtAverageStartPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtBuyItNowPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtBuyItNowPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtBuyItNowPrice = expected
        actual = target.TxtBuyItNowPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtCatalogTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtCatalogTitleTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtCatalogTitle = expected
        actual = target.TxtCatalogTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtExternalProductID"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtExternalProductIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtExternalProductID = expected
        actual = target.TxtExternalProductID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtItemID"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtItemIDTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtItemID = expected
        actual = target.TxtItemID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtPrimaryCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtPrimaryCategoryTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtPrimaryCategory = expected
        actual = target.TxtPrimaryCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtQuery"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtQueryTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtQuery = expected
        actual = target.TxtQuery
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtReservePrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtReservePriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtReservePrice = expected
        actual = target.TxtReservePrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtSecondaryCategory"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtSecondaryCategoryTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtSecondaryCategory = expected
        actual = target.TxtSecondaryCategory
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtStartPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtStartPriceTest()
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
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
        Dim target As FormGetItemRecommendations = New FormGetItemRecommendations ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtTitle = expected
        actual = target.TxtTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
