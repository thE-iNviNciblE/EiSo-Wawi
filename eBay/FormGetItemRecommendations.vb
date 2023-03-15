Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util

Public Class FormGetItemRecommendations
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents BtnGetCategories As System.Windows.Forms.Button
    Friend WithEvents TxtSecondaryCategory As System.Windows.Forms.TextBox
    Friend WithEvents LblSecondaryCategory As System.Windows.Forms.Label
    Friend WithEvents TxtBuyItNowPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblBuyItNowPrice As System.Windows.Forms.Label
    Friend WithEvents TxtPrimaryCategory As System.Windows.Forms.TextBox
    Friend WithEvents LblPrimaryCategory As System.Windows.Forms.Label
    Friend WithEvents TxtStartPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblStartPrice As System.Windows.Forms.Label
    Friend WithEvents TxtReservePrice As System.Windows.Forms.TextBox
    Friend WithEvents LblReservePrice As System.Windows.Forms.Label
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents TabSettings As System.Windows.Forms.TabControl
    Friend WithEvents TabListingAnalyzer As System.Windows.Forms.TabPage
    Friend WithEvents BtnListingAnalyzer As System.Windows.Forms.Button
    Friend WithEvents CboListingFlow As System.Windows.Forms.ComboBox
    Friend WithEvents LblListingFlow As System.Windows.Forms.Label
    Friend WithEvents TabProductPricing As System.Windows.Forms.TabPage
    Friend WithEvents GrpResult As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAverageStartPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtAverageSoldPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblAverageStartPrice As System.Windows.Forms.Label
    Friend WithEvents LblAverageSoldPrice As System.Windows.Forms.Label
    Friend WithEvents TxtCatalogTitle As System.Windows.Forms.TextBox
    Friend WithEvents LblCatalogTitle As System.Windows.Forms.Label
    Friend WithEvents TxtExternalProductID As System.Windows.Forms.TextBox
    Friend WithEvents BtnProductPricing As System.Windows.Forms.Button
    Friend WithEvents LblExternalProductID As System.Windows.Forms.Label
    Friend WithEvents TabSuggestedAttributes As System.Windows.Forms.TabPage
    Friend WithEvents GrpSuggestedProducts As System.Windows.Forms.GroupBox
    Friend WithEvents lstProduct As System.Windows.Forms.ListView
    Friend WithEvents GrpSuggestedAttr As System.Windows.Forms.GroupBox
    Friend WithEvents LstAttr As System.Windows.Forms.ListView
    Friend WithEvents TxtQuery As System.Windows.Forms.TextBox
    Friend WithEvents LblQuery As System.Windows.Forms.Label
    Friend WithEvents BtnSuggestedAttr As System.Windows.Forms.Button
    Friend WithEvents ClmTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmInfoID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmAvgStartPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmAvgSoldPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmCSID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmNoOfAttr As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtItemID As System.Windows.Forms.TextBox
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents BtnGetItem As System.Windows.Forms.Button
    Friend WithEvents LstTips As System.Windows.Forms.ListView
    Friend WithEvents ClmID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmFieldID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmPriority As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmMessage As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmFieldTip As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmFieldText As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmHelpURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblGetItem As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnGetCategories = New System.Windows.Forms.Button
        Me.TxtSecondaryCategory = New System.Windows.Forms.TextBox
        Me.LblSecondaryCategory = New System.Windows.Forms.Label
        Me.TxtBuyItNowPrice = New System.Windows.Forms.TextBox
        Me.LblBuyItNowPrice = New System.Windows.Forms.Label
        Me.TxtPrimaryCategory = New System.Windows.Forms.TextBox
        Me.LblPrimaryCategory = New System.Windows.Forms.Label
        Me.TxtStartPrice = New System.Windows.Forms.TextBox
        Me.LblStartPrice = New System.Windows.Forms.Label
        Me.TxtReservePrice = New System.Windows.Forms.TextBox
        Me.LblReservePrice = New System.Windows.Forms.Label
        Me.TxtTitle = New System.Windows.Forms.TextBox
        Me.LblTitle = New System.Windows.Forms.Label
        Me.TabSettings = New System.Windows.Forms.TabControl
        Me.TabListingAnalyzer = New System.Windows.Forms.TabPage
        Me.TxtItemID = New System.Windows.Forms.TextBox
        Me.LblItemID = New System.Windows.Forms.Label
        Me.BtnListingAnalyzer = New System.Windows.Forms.Button
        Me.CboListingFlow = New System.Windows.Forms.ComboBox
        Me.LblListingFlow = New System.Windows.Forms.Label
        Me.TabProductPricing = New System.Windows.Forms.TabPage
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.TxtAverageStartPrice = New System.Windows.Forms.TextBox
        Me.TxtAverageSoldPrice = New System.Windows.Forms.TextBox
        Me.LblAverageStartPrice = New System.Windows.Forms.Label
        Me.LblAverageSoldPrice = New System.Windows.Forms.Label
        Me.TxtCatalogTitle = New System.Windows.Forms.TextBox
        Me.LblCatalogTitle = New System.Windows.Forms.Label
        Me.TxtExternalProductID = New System.Windows.Forms.TextBox
        Me.BtnProductPricing = New System.Windows.Forms.Button
        Me.LblExternalProductID = New System.Windows.Forms.Label
        Me.TabSuggestedAttributes = New System.Windows.Forms.TabPage
        Me.GrpSuggestedProducts = New System.Windows.Forms.GroupBox
        Me.lstProduct = New System.Windows.Forms.ListView
        Me.ClmTitle = New System.Windows.Forms.ColumnHeader
        Me.ClmInfoID = New System.Windows.Forms.ColumnHeader
        Me.ClmAvgStartPrice = New System.Windows.Forms.ColumnHeader
        Me.ClmAvgSoldPrice = New System.Windows.Forms.ColumnHeader
        Me.GrpSuggestedAttr = New System.Windows.Forms.GroupBox
        Me.LstAttr = New System.Windows.Forms.ListView
        Me.ClmCSID = New System.Windows.Forms.ColumnHeader
        Me.ClmVersion = New System.Windows.Forms.ColumnHeader
        Me.ClmNoOfAttr = New System.Windows.Forms.ColumnHeader
        Me.TxtQuery = New System.Windows.Forms.TextBox
        Me.LblQuery = New System.Windows.Forms.Label
        Me.BtnSuggestedAttr = New System.Windows.Forms.Button
        Me.lblGetItem = New System.Windows.Forms.Label
        Me.BtnGetItem = New System.Windows.Forms.Button
        Me.LstTips = New System.Windows.Forms.ListView
        Me.ClmID = New System.Windows.Forms.ColumnHeader
        Me.ClmFieldID = New System.Windows.Forms.ColumnHeader
        Me.ClmPriority = New System.Windows.Forms.ColumnHeader
        Me.ClmMessage = New System.Windows.Forms.ColumnHeader
        Me.ClmFieldTip = New System.Windows.Forms.ColumnHeader
        Me.ClmFieldText = New System.Windows.Forms.ColumnHeader
        Me.ClmHelpURL = New System.Windows.Forms.ColumnHeader
        Me.TabSettings.SuspendLayout()
        Me.TabListingAnalyzer.SuspendLayout()
        Me.TabProductPricing.SuspendLayout()
        Me.GrpResult.SuspendLayout()
        Me.TabSuggestedAttributes.SuspendLayout()
        Me.GrpSuggestedProducts.SuspendLayout()
        Me.GrpSuggestedAttr.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGetCategories
        '
        Me.BtnGetCategories.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnGetCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetCategories.Location = New System.Drawing.Point(234, 46)
        Me.BtnGetCategories.Name = "BtnGetCategories"
        Me.BtnGetCategories.Size = New System.Drawing.Size(96, 23)
        Me.BtnGetCategories.TabIndex = 100
        Me.BtnGetCategories.Text = "Kategorie..."
        Me.BtnGetCategories.UseVisualStyleBackColor = False
        '
        'TxtSecondaryCategory
        '
        Me.TxtSecondaryCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSecondaryCategory.Location = New System.Drawing.Point(146, 78)
        Me.TxtSecondaryCategory.Name = "TxtSecondaryCategory"
        Me.TxtSecondaryCategory.Size = New System.Drawing.Size(72, 21)
        Me.TxtSecondaryCategory.TabIndex = 99
        '
        'LblSecondaryCategory
        '
        Me.LblSecondaryCategory.Location = New System.Drawing.Point(18, 78)
        Me.LblSecondaryCategory.Name = "LblSecondaryCategory"
        Me.LblSecondaryCategory.Size = New System.Drawing.Size(112, 23)
        Me.LblSecondaryCategory.TabIndex = 98
        Me.LblSecondaryCategory.Text = "2. Kategorie"
        '
        'TxtBuyItNowPrice
        '
        Me.TxtBuyItNowPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuyItNowPrice.Location = New System.Drawing.Point(490, 78)
        Me.TxtBuyItNowPrice.Name = "TxtBuyItNowPrice"
        Me.TxtBuyItNowPrice.Size = New System.Drawing.Size(72, 21)
        Me.TxtBuyItNowPrice.TabIndex = 97
        Me.TxtBuyItNowPrice.Text = "3000"
        '
        'LblBuyItNowPrice
        '
        Me.LblBuyItNowPrice.Location = New System.Drawing.Point(370, 78)
        Me.LblBuyItNowPrice.Name = "LblBuyItNowPrice"
        Me.LblBuyItNowPrice.Size = New System.Drawing.Size(96, 23)
        Me.LblBuyItNowPrice.TabIndex = 96
        Me.LblBuyItNowPrice.Text = "Sofortkauf"
        '
        'TxtPrimaryCategory
        '
        Me.TxtPrimaryCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrimaryCategory.Location = New System.Drawing.Point(146, 46)
        Me.TxtPrimaryCategory.Name = "TxtPrimaryCategory"
        Me.TxtPrimaryCategory.Size = New System.Drawing.Size(72, 21)
        Me.TxtPrimaryCategory.TabIndex = 95
        Me.TxtPrimaryCategory.Text = "80208"
        '
        'LblPrimaryCategory
        '
        Me.LblPrimaryCategory.Location = New System.Drawing.Point(18, 46)
        Me.LblPrimaryCategory.Name = "LblPrimaryCategory"
        Me.LblPrimaryCategory.Size = New System.Drawing.Size(112, 23)
        Me.LblPrimaryCategory.TabIndex = 94
        Me.LblPrimaryCategory.Text = "Hauptkategorie"
        '
        'TxtStartPrice
        '
        Me.TxtStartPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStartPrice.Location = New System.Drawing.Point(490, 14)
        Me.TxtStartPrice.Name = "TxtStartPrice"
        Me.TxtStartPrice.Size = New System.Drawing.Size(72, 21)
        Me.TxtStartPrice.TabIndex = 93
        Me.TxtStartPrice.Text = "1"
        '
        'LblStartPrice
        '
        Me.LblStartPrice.Location = New System.Drawing.Point(370, 14)
        Me.LblStartPrice.Name = "LblStartPrice"
        Me.LblStartPrice.Size = New System.Drawing.Size(96, 23)
        Me.LblStartPrice.TabIndex = 92
        Me.LblStartPrice.Text = "Startpreis"
        '
        'TxtReservePrice
        '
        Me.TxtReservePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReservePrice.Location = New System.Drawing.Point(490, 54)
        Me.TxtReservePrice.Name = "TxtReservePrice"
        Me.TxtReservePrice.Size = New System.Drawing.Size(72, 21)
        Me.TxtReservePrice.TabIndex = 91
        Me.TxtReservePrice.Text = "1000"
        '
        'LblReservePrice
        '
        Me.LblReservePrice.Location = New System.Drawing.Point(370, 52)
        Me.LblReservePrice.Name = "LblReservePrice"
        Me.LblReservePrice.Size = New System.Drawing.Size(96, 23)
        Me.LblReservePrice.TabIndex = 90
        Me.LblReservePrice.Text = "Reserve Price:"
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTitle.Location = New System.Drawing.Point(58, 14)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(208, 21)
        Me.TxtTitle.TabIndex = 89
        Me.TxtTitle.Text = "DELL new"
        '
        'LblTitle
        '
        Me.LblTitle.Location = New System.Drawing.Point(20, 12)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(32, 23)
        Me.LblTitle.TabIndex = 88
        Me.LblTitle.Text = "Titel"
        '
        'TabSettings
        '
        Me.TabSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabSettings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabSettings.Controls.Add(Me.TabListingAnalyzer)
        Me.TabSettings.Controls.Add(Me.TabProductPricing)
        Me.TabSettings.Controls.Add(Me.TabSuggestedAttributes)
        Me.TabSettings.Location = New System.Drawing.Point(12, 105)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.SelectedIndex = 0
        Me.TabSettings.Size = New System.Drawing.Size(600, 436)
        Me.TabSettings.TabIndex = 87
        '
        'TabListingAnalyzer
        '
        Me.TabListingAnalyzer.Controls.Add(Me.LstTips)
        Me.TabListingAnalyzer.Controls.Add(Me.TxtItemID)
        Me.TabListingAnalyzer.Controls.Add(Me.LblItemID)
        Me.TabListingAnalyzer.Controls.Add(Me.BtnListingAnalyzer)
        Me.TabListingAnalyzer.Controls.Add(Me.CboListingFlow)
        Me.TabListingAnalyzer.Controls.Add(Me.LblListingFlow)
        Me.TabListingAnalyzer.Location = New System.Drawing.Point(4, 25)
        Me.TabListingAnalyzer.Name = "TabListingAnalyzer"
        Me.TabListingAnalyzer.Size = New System.Drawing.Size(592, 407)
        Me.TabListingAnalyzer.TabIndex = 0
        Me.TabListingAnalyzer.Text = "Listing Analyzer"
        '
        'TxtItemID
        '
        Me.TxtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemID.Location = New System.Drawing.Point(400, 16)
        Me.TxtItemID.Name = "TxtItemID"
        Me.TxtItemID.Size = New System.Drawing.Size(144, 21)
        Me.TxtItemID.TabIndex = 87
        Me.TxtItemID.Visible = False
        '
        'LblItemID
        '
        Me.LblItemID.Location = New System.Drawing.Point(336, 16)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(48, 23)
        Me.LblItemID.TabIndex = 86
        Me.LblItemID.Text = "Item ID:"
        Me.LblItemID.Visible = False
        '
        'BtnListingAnalyzer
        '
        Me.BtnListingAnalyzer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnListingAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListingAnalyzer.Location = New System.Drawing.Point(124, 56)
        Me.BtnListingAnalyzer.Name = "BtnListingAnalyzer"
        Me.BtnListingAnalyzer.Size = New System.Drawing.Size(120, 24)
        Me.BtnListingAnalyzer.TabIndex = 64
        Me.BtnListingAnalyzer.Text = "Starte Analyse"
        Me.BtnListingAnalyzer.UseVisualStyleBackColor = False
        '
        'CboListingFlow
        '
        Me.CboListingFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboListingFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboListingFlow.Location = New System.Drawing.Point(104, 16)
        Me.CboListingFlow.Name = "CboListingFlow"
        Me.CboListingFlow.Size = New System.Drawing.Size(216, 21)
        Me.CboListingFlow.TabIndex = 58
        '
        'LblListingFlow
        '
        Me.LblListingFlow.Location = New System.Drawing.Point(16, 16)
        Me.LblListingFlow.Name = "LblListingFlow"
        Me.LblListingFlow.Size = New System.Drawing.Size(72, 24)
        Me.LblListingFlow.TabIndex = 0
        Me.LblListingFlow.Text = "Listing Flow:"
        '
        'TabProductPricing
        '
        Me.TabProductPricing.Controls.Add(Me.GrpResult)
        Me.TabProductPricing.Controls.Add(Me.TxtExternalProductID)
        Me.TabProductPricing.Controls.Add(Me.BtnProductPricing)
        Me.TabProductPricing.Controls.Add(Me.LblExternalProductID)
        Me.TabProductPricing.Location = New System.Drawing.Point(4, 25)
        Me.TabProductPricing.Name = "TabProductPricing"
        Me.TabProductPricing.Size = New System.Drawing.Size(592, 407)
        Me.TabProductPricing.TabIndex = 3
        Me.TabProductPricing.Text = "Product Pricing"
        Me.TabProductPricing.Visible = False
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.TxtAverageStartPrice)
        Me.GrpResult.Controls.Add(Me.TxtAverageSoldPrice)
        Me.GrpResult.Controls.Add(Me.LblAverageStartPrice)
        Me.GrpResult.Controls.Add(Me.LblAverageSoldPrice)
        Me.GrpResult.Controls.Add(Me.TxtCatalogTitle)
        Me.GrpResult.Controls.Add(Me.LblCatalogTitle)
        Me.GrpResult.Location = New System.Drawing.Point(16, 112)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(520, 224)
        Me.GrpResult.TabIndex = 67
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Result"
        '
        'TxtAverageStartPrice
        '
        Me.TxtAverageStartPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAverageStartPrice.Location = New System.Drawing.Point(192, 68)
        Me.TxtAverageStartPrice.Name = "TxtAverageStartPrice"
        Me.TxtAverageStartPrice.Size = New System.Drawing.Size(256, 21)
        Me.TxtAverageStartPrice.TabIndex = 23
        '
        'TxtAverageSoldPrice
        '
        Me.TxtAverageSoldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAverageSoldPrice.Location = New System.Drawing.Point(192, 104)
        Me.TxtAverageSoldPrice.Name = "TxtAverageSoldPrice"
        Me.TxtAverageSoldPrice.Size = New System.Drawing.Size(256, 21)
        Me.TxtAverageSoldPrice.TabIndex = 65
        '
        'LblAverageStartPrice
        '
        Me.LblAverageStartPrice.Location = New System.Drawing.Point(80, 68)
        Me.LblAverageStartPrice.Name = "LblAverageStartPrice"
        Me.LblAverageStartPrice.Size = New System.Drawing.Size(200, 16)
        Me.LblAverageStartPrice.TabIndex = 24
        Me.LblAverageStartPrice.Text = "Average Start Price:"
        '
        'LblAverageSoldPrice
        '
        Me.LblAverageSoldPrice.Location = New System.Drawing.Point(80, 104)
        Me.LblAverageSoldPrice.Name = "LblAverageSoldPrice"
        Me.LblAverageSoldPrice.Size = New System.Drawing.Size(200, 16)
        Me.LblAverageSoldPrice.TabIndex = 66
        Me.LblAverageSoldPrice.Text = "Average Sold Price:"
        '
        'TxtCatalogTitle
        '
        Me.TxtCatalogTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCatalogTitle.Location = New System.Drawing.Point(192, 32)
        Me.TxtCatalogTitle.Name = "TxtCatalogTitle"
        Me.TxtCatalogTitle.Size = New System.Drawing.Size(256, 21)
        Me.TxtCatalogTitle.TabIndex = 2
        '
        'LblCatalogTitle
        '
        Me.LblCatalogTitle.Location = New System.Drawing.Point(80, 32)
        Me.LblCatalogTitle.Name = "LblCatalogTitle"
        Me.LblCatalogTitle.Size = New System.Drawing.Size(192, 16)
        Me.LblCatalogTitle.TabIndex = 22
        Me.LblCatalogTitle.Text = "Catalog Title:"
        '
        'TxtExternalProductID
        '
        Me.TxtExternalProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtExternalProductID.Location = New System.Drawing.Point(216, 16)
        Me.TxtExternalProductID.Name = "TxtExternalProductID"
        Me.TxtExternalProductID.Size = New System.Drawing.Size(208, 21)
        Me.TxtExternalProductID.TabIndex = 64
        Me.TxtExternalProductID.Text = "79328:2:1431:561576419:57669919:391bc1eb4871c4a4e930a52fca6eccfd:1:1:1:1348602270" & _
            ""
        '
        'BtnProductPricing
        '
        Me.BtnProductPricing.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnProductPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductPricing.Location = New System.Drawing.Point(168, 56)
        Me.BtnProductPricing.Name = "BtnProductPricing"
        Me.BtnProductPricing.Size = New System.Drawing.Size(168, 23)
        Me.BtnProductPricing.TabIndex = 63
        Me.BtnProductPricing.Text = "Run Product Pricing Engine"
        Me.BtnProductPricing.UseVisualStyleBackColor = False
        '
        'LblExternalProductID
        '
        Me.LblExternalProductID.Location = New System.Drawing.Point(104, 16)
        Me.LblExternalProductID.Name = "LblExternalProductID"
        Me.LblExternalProductID.Size = New System.Drawing.Size(112, 16)
        Me.LblExternalProductID.TabIndex = 20
        Me.LblExternalProductID.Text = "External Product ID:"
        '
        'TabSuggestedAttributes
        '
        Me.TabSuggestedAttributes.Controls.Add(Me.GrpSuggestedProducts)
        Me.TabSuggestedAttributes.Controls.Add(Me.GrpSuggestedAttr)
        Me.TabSuggestedAttributes.Controls.Add(Me.TxtQuery)
        Me.TabSuggestedAttributes.Controls.Add(Me.LblQuery)
        Me.TabSuggestedAttributes.Controls.Add(Me.BtnSuggestedAttr)
        Me.TabSuggestedAttributes.Location = New System.Drawing.Point(4, 25)
        Me.TabSuggestedAttributes.Name = "TabSuggestedAttributes"
        Me.TabSuggestedAttributes.Size = New System.Drawing.Size(592, 407)
        Me.TabSuggestedAttributes.TabIndex = 1
        Me.TabSuggestedAttributes.Text = "Suggested Attributes"
        Me.TabSuggestedAttributes.Visible = False
        '
        'GrpSuggestedProducts
        '
        Me.GrpSuggestedProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSuggestedProducts.Controls.Add(Me.lstProduct)
        Me.GrpSuggestedProducts.Location = New System.Drawing.Point(280, 88)
        Me.GrpSuggestedProducts.Name = "GrpSuggestedProducts"
        Me.GrpSuggestedProducts.Size = New System.Drawing.Size(309, 295)
        Me.GrpSuggestedProducts.TabIndex = 75
        Me.GrpSuggestedProducts.TabStop = False
        Me.GrpSuggestedProducts.Text = "Suggested Products"
        '
        'lstProduct
        '
        Me.lstProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstProduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmTitle, Me.ClmInfoID, Me.ClmAvgStartPrice, Me.ClmAvgSoldPrice})
        Me.lstProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstProduct.GridLines = True
        Me.lstProduct.Location = New System.Drawing.Point(3, 17)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(303, 275)
        Me.lstProduct.TabIndex = 15
        Me.lstProduct.UseCompatibleStateImageBehavior = False
        Me.lstProduct.View = System.Windows.Forms.View.Details
        '
        'ClmTitle
        '
        Me.ClmTitle.Text = "Title"
        Me.ClmTitle.Width = 40
        '
        'ClmInfoID
        '
        Me.ClmInfoID.Text = "Info ID"
        Me.ClmInfoID.Width = 50
        '
        'ClmAvgStartPrice
        '
        Me.ClmAvgStartPrice.Text = "Avg Start Price"
        Me.ClmAvgStartPrice.Width = 70
        '
        'ClmAvgSoldPrice
        '
        Me.ClmAvgSoldPrice.Text = "Avg Sold Price"
        Me.ClmAvgSoldPrice.Width = 70
        '
        'GrpSuggestedAttr
        '
        Me.GrpSuggestedAttr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSuggestedAttr.Controls.Add(Me.LstAttr)
        Me.GrpSuggestedAttr.Location = New System.Drawing.Point(16, 88)
        Me.GrpSuggestedAttr.Name = "GrpSuggestedAttr"
        Me.GrpSuggestedAttr.Size = New System.Drawing.Size(256, 295)
        Me.GrpSuggestedAttr.TabIndex = 74
        Me.GrpSuggestedAttr.TabStop = False
        Me.GrpSuggestedAttr.Text = "Suggested Attributes   "
        '
        'LstAttr
        '
        Me.LstAttr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstAttr.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmCSID, Me.ClmVersion, Me.ClmNoOfAttr})
        Me.LstAttr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstAttr.GridLines = True
        Me.LstAttr.Location = New System.Drawing.Point(3, 17)
        Me.LstAttr.Name = "LstAttr"
        Me.LstAttr.Size = New System.Drawing.Size(250, 275)
        Me.LstAttr.TabIndex = 16
        Me.LstAttr.UseCompatibleStateImageBehavior = False
        Me.LstAttr.View = System.Windows.Forms.View.Details
        '
        'ClmCSID
        '
        Me.ClmCSID.Text = "CSID"
        '
        'ClmVersion
        '
        Me.ClmVersion.Text = "Version"
        Me.ClmVersion.Width = 50
        '
        'ClmNoOfAttr
        '
        Me.ClmNoOfAttr.Text = "# of Attributes"
        Me.ClmNoOfAttr.Width = 110
        '
        'TxtQuery
        '
        Me.TxtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuery.Location = New System.Drawing.Point(192, 16)
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.Size = New System.Drawing.Size(178, 21)
        Me.TxtQuery.TabIndex = 73
        Me.TxtQuery.Text = "DELL Inspiron"
        '
        'LblQuery
        '
        Me.LblQuery.Location = New System.Drawing.Point(136, 16)
        Me.LblQuery.Name = "LblQuery"
        Me.LblQuery.Size = New System.Drawing.Size(48, 23)
        Me.LblQuery.TabIndex = 72
        Me.LblQuery.Text = "Query:"
        '
        'BtnSuggestedAttr
        '
        Me.BtnSuggestedAttr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSuggestedAttr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuggestedAttr.Location = New System.Drawing.Point(184, 56)
        Me.BtnSuggestedAttr.Name = "BtnSuggestedAttr"
        Me.BtnSuggestedAttr.Size = New System.Drawing.Size(184, 24)
        Me.BtnSuggestedAttr.TabIndex = 70
        Me.BtnSuggestedAttr.Text = "Run Suggested Attributes Engine"
        Me.BtnSuggestedAttr.UseVisualStyleBackColor = False
        '
        'lblGetItem
        '
        Me.lblGetItem.Location = New System.Drawing.Point(387, 101)
        Me.lblGetItem.Name = "lblGetItem"
        Me.lblGetItem.Size = New System.Drawing.Size(200, 23)
        Me.lblGetItem.TabIndex = 101
        '
        'BtnGetItem
        '
        Me.BtnGetItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnGetItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetItem.Location = New System.Drawing.Point(272, 12)
        Me.BtnGetItem.Name = "BtnGetItem"
        Me.BtnGetItem.Size = New System.Drawing.Size(96, 23)
        Me.BtnGetItem.TabIndex = 102
        Me.BtnGetItem.Text = "Hole Artikel"
        Me.BtnGetItem.UseVisualStyleBackColor = False
        '
        'LstTips
        '
        Me.LstTips.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstTips.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmID, Me.ClmFieldID, Me.ClmPriority, Me.ClmMessage, Me.ClmFieldTip, Me.ClmFieldText, Me.ClmHelpURL})
        Me.LstTips.GridLines = True
        Me.LstTips.Location = New System.Drawing.Point(19, 101)
        Me.LstTips.Name = "LstTips"
        Me.LstTips.Size = New System.Drawing.Size(555, 292)
        Me.LstTips.TabIndex = 88
        Me.LstTips.UseCompatibleStateImageBehavior = False
        Me.LstTips.View = System.Windows.Forms.View.Details
        '
        'ClmID
        '
        Me.ClmID.Text = "ID"
        Me.ClmID.Width = 40
        '
        'ClmFieldID
        '
        Me.ClmFieldID.Text = "Field ID"
        Me.ClmFieldID.Width = 53
        '
        'ClmPriority
        '
        Me.ClmPriority.Text = "Priority"
        Me.ClmPriority.Width = 50
        '
        'ClmMessage
        '
        Me.ClmMessage.Text = "Message"
        Me.ClmMessage.Width = 100
        '
        'ClmFieldTip
        '
        Me.ClmFieldTip.Text = "Field Tip"
        Me.ClmFieldTip.Width = 86
        '
        'ClmFieldText
        '
        Me.ClmFieldText.Text = "Field Text"
        '
        'ClmHelpURL
        '
        Me.ClmHelpURL.Text = "Help URL"
        Me.ClmHelpURL.Width = 95
        '
        'FormGetItemRecommendations
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(624, 553)
        Me.Controls.Add(Me.BtnGetItem)
        Me.Controls.Add(Me.lblGetItem)
        Me.Controls.Add(Me.BtnGetCategories)
        Me.Controls.Add(Me.TxtSecondaryCategory)
        Me.Controls.Add(Me.LblSecondaryCategory)
        Me.Controls.Add(Me.TxtBuyItNowPrice)
        Me.Controls.Add(Me.LblBuyItNowPrice)
        Me.Controls.Add(Me.TxtPrimaryCategory)
        Me.Controls.Add(Me.LblPrimaryCategory)
        Me.Controls.Add(Me.TxtStartPrice)
        Me.Controls.Add(Me.LblStartPrice)
        Me.Controls.Add(Me.TxtReservePrice)
        Me.Controls.Add(Me.LblReservePrice)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.TabSettings)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormGetItemRecommendations"
        Me.Text = "YABE - Analyser"
        Me.TabSettings.ResumeLayout(False)
        Me.TabListingAnalyzer.ResumeLayout(False)
        Me.TabListingAnalyzer.PerformLayout()
        Me.TabProductPricing.ResumeLayout(False)
        Me.TabProductPricing.PerformLayout()
        Me.GrpResult.ResumeLayout(False)
        Me.GrpResult.PerformLayout()
        Me.TabSuggestedAttributes.ResumeLayout(False)
        Me.TabSuggestedAttributes.PerformLayout()
        Me.GrpSuggestedProducts.ResumeLayout(False)
        Me.GrpSuggestedAttr.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Context As ApiContext
    Private fetchedItem As ItemType

    Private Sub BtnListingAnalyzer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListingAnalyzer.Click
        Try
            Context = clseBayAPI.setAPIContext()
            Dim ApiCall As GetItemRecommendationsCall = New GetItemRecommendationsCall(Context)
            Dim req As GetRecommendationsRequestContainerType = New GetRecommendationsRequestContainerType()
            Dim reqc As GetRecommendationsRequestContainerTypeCollection = New GetRecommendationsRequestContainerTypeCollection()
            reqc.Add(req)
            req.RecommendationEngine = New RecommendationEngineCodeTypeCollection()
            req.RecommendationEngine.Add(RecommendationEngineCodeType.ListingAnalyzer)
            req.ListingFlow = [Enum].Parse(GetType(ListingFlowCodeType), CboListingFlow.SelectedItem.ToString())
            Dim item As ItemType = FillItem(RecommendationEngineCodeType.ListingAnalyzer)
            req.Item = item
            If req.ListingFlow = ListingFlowCodeType.AddItem Then
                req.Item.ItemID = Nothing
            ElseIf Not (fetchedItem Is Nothing) Then
                req.Item.ItemID = fetchedItem.ItemID
            End If
            ' Make API call
            ApiCall.GetItemRecommendations(reqc)
            Dim resps As GetRecommendationsResponseContainerTypeCollection = ApiCall.ApiResponse.GetRecommendationsResponseContainer
            Dim listingAnalyzerRecommendations As ListingAnalyzerRecommendationsType = resps(0).ListingAnalyzerRecommendations
            LstTips.Items.Clear()
            If Not (listingAnalyzerRecommendations Is Nothing) Then
                Dim tips As ListingTipTypeCollection = listingAnalyzerRecommendations.ListingTipArray
                If Not tips Is Nothing Then
                    Dim tip As ListingTipType
                    For Each tip In tips
                        Dim listparams(8) As String
                        listparams(0) = tip.ListingTipID
                        listparams(1) = tip.Field.ListingTipFieldID
                        listparams(2) = tip.Priority.ToString()
                        listparams(3) = tip.Message.LongMessage
                        listparams(4) = StripCDATA(tip.Field.FieldTip)
                        listparams(5) = StripCDATA(tip.Field.CurrentFieldText)
                        listparams(6) = StripCDATA(tip.Message.HelpURLPath)

                        Dim vi As ListViewItem = New ListViewItem(listparams)
                        LstTips.Items.Add(vi)
                    Next tip
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BtnProductPricing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductPricing.Click
        Try

            TxtAverageSoldPrice.Text = ""
            TxtAverageStartPrice.Text = ""
            TxtCatalogTitle.Text = ""
            Context = clseBayAPI.setAPIContext()
            Dim ApiCall As GetItemRecommendationsCall = New GetItemRecommendationsCall(Context)
            Dim req As GetRecommendationsRequestContainerType = New GetRecommendationsRequestContainerType()
            req.RecommendationEngine = New RecommendationEngineCodeTypeCollection()
            req.RecommendationEngine.Add(RecommendationEngineCodeType.ProductPricing)
            req.ListingFlow = ListingFlowCodeType.AddItem
            Dim item As ItemType = FillItem(RecommendationEngineCodeType.ProductPricing)
            req.Item = item
            Dim reqc As GetRecommendationsRequestContainerTypeCollection = New GetRecommendationsRequestContainerTypeCollection()
            reqc.Add(req)
            ' Make API call
            ApiCall.GetItemRecommendations(reqc)
            Dim resps As GetRecommendationsResponseContainerTypeCollection = ApiCall.ApiResponse.GetRecommendationsResponseContainer
            Dim pricingRecommendations As PricingRecommendationsType = resps(0).PricingRecommendations
            If pricingRecommendations Is Nothing Then
                Return
            End If
            If pricingRecommendations.ProductInfo Is Nothing Then
                Return
            End If

            TxtCatalogTitle.Text = pricingRecommendations.ProductInfo.Title
            Dim avgSoldPrice As AmountType = pricingRecommendations.ProductInfo.AverageSoldPrice
            If Not avgSoldPrice Is Nothing Then
                TxtAverageSoldPrice.Text = avgSoldPrice.Value.ToString
            End If
            Dim avgStartPrice As AmountType = pricingRecommendations.ProductInfo.AverageStartPrice
            If Not avgStartPrice Is Nothing Then
                TxtAverageStartPrice.Text = avgStartPrice.Value.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BtnSuggestedAttr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuggestedAttr.Click
        Try
            Context = clseBayAPI.setAPIContext()
            Dim ApiCall As GetItemRecommendationsCall = New GetItemRecommendationsCall(Context)
            Dim req As GetRecommendationsRequestContainerType = New GetRecommendationsRequestContainerType()
            req.RecommendationEngine = New RecommendationEngineCodeTypeCollection()
            req.RecommendationEngine.Add(RecommendationEngineCodeType.ProductPricing)
            req.ListingFlow = ListingFlowCodeType.AddItem
            Dim item As ItemType = FillItem(RecommendationEngineCodeType.SuggestedAttributes)
            req.Item = item
            If (TxtQuery.Text.Length > 0) Then
                req.Query = TxtQuery.Text
            End If
            Dim reqc As GetRecommendationsRequestContainerTypeCollection = New GetRecommendationsRequestContainerTypeCollection()
            reqc.Add(req)
            ' Make API call
            ApiCall.GetItemRecommendations(reqc)
            Dim resps As GetRecommendationsResponseContainerTypeCollection = ApiCall.ApiResponse.GetRecommendationsResponseContainer
            Dim attrs As AttributeRecommendationsType = resps(0).AttributeRecommendations
            Dim attrSets As AttributeSetTypeCollection

            If Not attrSets Is Nothing Then
                Dim attribute As AttributeSetType
                For Each attribute In attrSets
                    If Not attribute Is Nothing Then
                        Dim listparams(3) As String
                        listparams(0) = attribute.attributeSetID.ToString()
                        listparams(1) = attribute.attributeSetVersion
                        listparams(2) = attribute.Attribute.Count.ToString()

                        Dim vi As ListViewItem = New ListViewItem(listparams)
                        LstAttr.Items.Add(vi)
                    End If
                Next attribute
            End If

            Dim products As ProductInfoTypeCollection = resps(0).ProductRecommendations
            If Not products Is Nothing Then
                Dim product As ProductInfoType
                For Each product In products
                    If Not product Is Nothing Then
                        Dim listparams(4) As String
                        listparams(0) = product.Title
                        listparams(1) = product.productInfoID

                        If Not product.AverageStartPrice Is Nothing Then
                            listparams(2) = product.AverageStartPrice.Value.ToString()
                        End If

                        If Not product.AverageSoldPrice Is Nothing Then
                            listparams(3) = product.AverageSoldPrice.Value.ToString()
                        End If

                        Dim vi As ListViewItem = New ListViewItem(listparams)
                        lstProduct.Items.Add(vi)
                    End If
                Next product
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Function FillItem(ByVal engine As RecommendationEngineCodeType) As ItemType
        Dim item As ItemType = New ItemType()
        If TxtTitle.Text.Length > 0 Then
            item.Title = TxtTitle.Text
        End If

        Dim currencyID As CurrencyCodeType = CurrencyUtility.GetDefaultCurrencyCodeType(Context.Site)

        item.Currency = currencyID
        If (TxtStartPrice.Text.Length > 0) Then
            item.StartPrice = New AmountType()
            item.StartPrice.Value = Convert.ToDouble(TxtStartPrice.Text)
            item.StartPrice.currencyID = currencyID
        End If


        If (TxtReservePrice.Text.Length > 0) Then
            item.ReservePrice = New AmountType()
            item.ReservePrice.Value = Convert.ToDouble(TxtReservePrice.Text)
            item.ReservePrice.currencyID = currencyID
        End If

        If (TxtBuyItNowPrice.Text.Length > 0) Then
            item.BuyItNowPrice = New AmountType()
            item.BuyItNowPrice.Value = Convert.ToDouble(TxtBuyItNowPrice.Text)
            item.BuyItNowPrice.currencyID = currencyID
        End If


        If (TxtPrimaryCategory.Text.Length > 0) Then
            item.PrimaryCategory = New CategoryType()
            item.PrimaryCategory.CategoryID = TxtPrimaryCategory.Text
        End If


        If (TxtSecondaryCategory.Text.Length > 0) Then
            item.SecondaryCategory = New CategoryType()
            item.SecondaryCategory.CategoryID = TxtSecondaryCategory.Text
        End If


        If (TxtItemID.Visible) Then
            item.ItemID = TxtItemID.Text
        End If

        If engine = RecommendationEngineCodeType.ProductPricing Then
            Dim s As String = TxtExternalProductID.Text
            If s.Length > 0 Then
                Dim pld As ProductListingDetailsType = New ProductListingDetailsType()
                pld.ProductID = s
                item.ProductListingDetails = pld
            End If
        End If

        Return item

    End Function

    Private Function StripCDATA(ByVal cdataString As String) As String
        Dim CDATA_START As String = "<![CDATA["
        Dim CDATA_END As String = "]]>"

        If cdataString Is Nothing Then
            Return ""
        End If
        Dim index1 As Integer = cdataString.IndexOf(CDATA_START)
        If index1 = -1 Then
            Return cdataString
        End If
        Dim index2 As Integer = cdataString.IndexOf(CDATA_END)
        If index2 = -1 Then
            Return cdataString.Substring(CDATA_START.Length)
        Else
            Return cdataString.Substring(CDATA_START.Length, (cdataString.Length - CDATA_START.Length - CDATA_END.Length))
        End If

    End Function

    Private Sub BtnGetCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetCategories.Click
        'Dim form As FormGetCategories = New FormGetCategories()
        'form.Context = Context
        'form.ShowDialog()
    End Sub

    Private Sub BtnGetItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetItem.Click
        Dim form As FormGetItem = New FormGetItem()
        form.Context = Context
        form.ShowDialog()
        fetchedItem = form.getItem()
        If Not (fetchedItem Is Nothing) Then
            TxtTitle.Text = fetchedItem.Title
            TxtPrimaryCategory.Text = fetchedItem.PrimaryCategory.CategoryID
            Dim secondaryCategory As CategoryType = fetchedItem.SecondaryCategory
            If secondaryCategory Is Nothing Then
                TxtSecondaryCategory.Text = ""
            Else
                TxtSecondaryCategory.Text = secondaryCategory.CategoryID
            End If
            TxtStartPrice.Text = fetchedItem.SellingStatus.CurrentPrice.Value.ToString()
            Dim amt As AmountType = fetchedItem.ReservePrice
            If amt Is Nothing Then
                TxtReservePrice.Text = ""
            Else
                TxtReservePrice.Text = amt.Value.ToString()
            End If
            amt = fetchedItem.BuyItNowPrice
            If amt Is Nothing Then
                TxtBuyItNowPrice.Text = ""
            Else
                TxtBuyItNowPrice.Text = amt.Value.ToString()
            End If
            TxtItemID.Text = fetchedItem.ItemID
        End If
    End Sub

    Private Sub FormGetRecommendations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim enums As Type = GetType(ListingFlowCodeType)
        Dim item As String
        For Each item In [Enum].GetNames(enums)
            If (item <> "CustomCode") Then
                CboListingFlow.Items.Add(item)
            End If
        Next item

        CboListingFlow.SelectedIndex = 0
    End Sub

    Private Sub CboListingFlow_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboListingFlow.SelectedIndexChanged
        If CboListingFlow.Text.Equals("AddItem") Then
            LblItemID.Visible = False
            TxtItemID.Visible = False
        Else
            LblItemID.Visible = True
            TxtItemID.Visible = True
        End If
    End Sub

    Private Sub TxtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTitle.TextChanged

    End Sub

    Private Sub LstTips_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

