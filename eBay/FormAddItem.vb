Imports System
Imports System.Globalization
Imports System.Collections
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util





Public Class FormAddItem
    Inherits System.Windows.Forms.Form

    Public lvwWebArtikel As New ListView

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


    Friend WithEvents OpenFileDialogIMG As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnVerifyAddItem As System.Windows.Forms.Button
    Friend WithEvents grpResults As System.Windows.Forms.GroupBox
    Friend WithEvents LblItemId As System.Windows.Forms.Label
    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox
    Friend WithEvents TxtListingFee As System.Windows.Forms.TextBox
    Friend WithEvents LblListingFee As System.Windows.Forms.Label
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents GrpPictures As System.Windows.Forms.GroupBox
    Friend WithEvents CboPicDisplay As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddPic As System.Windows.Forms.Button
    Friend WithEvents ListPictures As System.Windows.Forms.ListBox
    Friend WithEvents BtnRemovePic As System.Windows.Forms.Button
    Friend WithEvents CboListType As System.Windows.Forms.ComboBox
    Friend WithEvents LblListType As System.Windows.Forms.Label
    Friend WithEvents TxtPayPalEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblPayPalEmailAddress As System.Windows.Forms.Label
    Friend WithEvents TxtApplicationData As System.Windows.Forms.TextBox
    Friend WithEvents lblApplicationData As System.Windows.Forms.Label
    Friend WithEvents TxtCategory2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory2 As System.Windows.Forms.Label
    Friend WithEvents ChkEnableBestOffer As System.Windows.Forms.CheckBox
    Friend WithEvents CboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLocation As System.Windows.Forms.TextBox
    Friend WithEvents LblLocation As System.Windows.Forms.Label
    Friend WithEvents LblDuration As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Friend WithEvents ChkHighLight As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBoldTitle As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuyItNowPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtCategory As System.Windows.Forms.TextBox
    Friend WithEvents TxtReservePrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents LblStartPrice As System.Windows.Forms.Label
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblBuyItNowPrice As System.Windows.Forms.Label
    Friend WithEvents txtExternBild As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbVersand As ComboBox
    Friend WithEvents txtVersandKosten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblReservePrice As System.Windows.Forms.Label
































    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialogIMG = New System.Windows.Forms.OpenFileDialog()
        Me.BtnVerifyAddItem = New System.Windows.Forms.Button()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.TxtItemId = New System.Windows.Forms.TextBox()
        Me.LblItemId = New System.Windows.Forms.Label()
        Me.TxtListingFee = New System.Windows.Forms.TextBox()
        Me.LblListingFee = New System.Windows.Forms.Label()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.GrpPictures = New System.Windows.Forms.GroupBox()
        Me.CboPicDisplay = New System.Windows.Forms.ComboBox()
        Me.BtnAddPic = New System.Windows.Forms.Button()
        Me.ListPictures = New System.Windows.Forms.ListBox()
        Me.BtnRemovePic = New System.Windows.Forms.Button()
        Me.CboListType = New System.Windows.Forms.ComboBox()
        Me.LblListType = New System.Windows.Forms.Label()
        Me.TxtPayPalEmailAddress = New System.Windows.Forms.TextBox()
        Me.LblPayPalEmailAddress = New System.Windows.Forms.Label()
        Me.TxtApplicationData = New System.Windows.Forms.TextBox()
        Me.lblApplicationData = New System.Windows.Forms.Label()
        Me.TxtCategory2 = New System.Windows.Forms.TextBox()
        Me.lblCategory2 = New System.Windows.Forms.Label()
        Me.ChkEnableBestOffer = New System.Windows.Forms.CheckBox()
        Me.CboDuration = New System.Windows.Forms.ComboBox()
        Me.TxtLocation = New System.Windows.Forms.TextBox()
        Me.LblLocation = New System.Windows.Forms.Label()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.ChkHighLight = New System.Windows.Forms.CheckBox()
        Me.ChkBoldTitle = New System.Windows.Forms.CheckBox()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.TxtBuyItNowPrice = New System.Windows.Forms.TextBox()
        Me.TxtCategory = New System.Windows.Forms.TextBox()
        Me.TxtReservePrice = New System.Windows.Forms.TextBox()
        Me.TxtStartPrice = New System.Windows.Forms.TextBox()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblStartPrice = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblBuyItNowPrice = New System.Windows.Forms.Label()
        Me.LblReservePrice = New System.Windows.Forms.Label()
        Me.txtExternBild = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbVersand = New System.Windows.Forms.ComboBox()
        Me.txtVersandKosten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpResults.SuspendLayout()
        Me.GrpPictures.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialogIMG
        '
        Me.OpenFileDialogIMG.Filter = "JPEG files (*.jpg)|*.jpg|GIf files (*.gIf)|*.gIf|All Files|*.*"
        '
        'BtnVerifyAddItem
        '
        Me.BtnVerifyAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnVerifyAddItem.BackColor = System.Drawing.Color.PapayaWhip
        Me.BtnVerifyAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerifyAddItem.Location = New System.Drawing.Point(26, 506)
        Me.BtnVerifyAddItem.Name = "BtnVerifyAddItem"
        Me.BtnVerifyAddItem.Size = New System.Drawing.Size(194, 23)
        Me.BtnVerifyAddItem.TabIndex = 87
        Me.BtnVerifyAddItem.Text = "&Überprüfe Artikel"
        Me.BtnVerifyAddItem.UseVisualStyleBackColor = False
        '
        'grpResults
        '
        Me.grpResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResults.Controls.Add(Me.TxtItemId)
        Me.grpResults.Controls.Add(Me.LblItemId)
        Me.grpResults.Controls.Add(Me.TxtListingFee)
        Me.grpResults.Controls.Add(Me.LblListingFee)
        Me.grpResults.Location = New System.Drawing.Point(12, 547)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(710, 49)
        Me.grpResults.TabIndex = 79
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Ergebnis"
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(117, 18)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.ReadOnly = True
        Me.TxtItemId.Size = New System.Drawing.Size(159, 21)
        Me.TxtItemId.TabIndex = 0
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(30, 20)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(100, 23)
        Me.LblItemId.TabIndex = 1
        Me.LblItemId.Text = "ArtikelID"
        '
        'TxtListingFee
        '
        Me.TxtListingFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtListingFee.Location = New System.Drawing.Point(456, 18)
        Me.TxtListingFee.Name = "TxtListingFee"
        Me.TxtListingFee.ReadOnly = True
        Me.TxtListingFee.Size = New System.Drawing.Size(143, 21)
        Me.TxtListingFee.TabIndex = 0
        '
        'LblListingFee
        '
        Me.LblListingFee.Location = New System.Drawing.Point(383, 17)
        Me.LblListingFee.Name = "LblListingFee"
        Me.LblListingFee.Size = New System.Drawing.Size(100, 23)
        Me.LblListingFee.TabIndex = 1
        Me.LblListingFee.Text = "Gebühren"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddItem.BackColor = System.Drawing.Color.PapayaWhip
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Location = New System.Drawing.Point(258, 506)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(194, 23)
        Me.BtnAddItem.TabIndex = 71
        Me.BtnAddItem.Text = "&Artikel hinzufügen"
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'GrpPictures
        '
        Me.GrpPictures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPictures.Controls.Add(Me.txtExternBild)
        Me.GrpPictures.Controls.Add(Me.Label1)
        Me.GrpPictures.Controls.Add(Me.CboPicDisplay)
        Me.GrpPictures.Controls.Add(Me.BtnAddPic)
        Me.GrpPictures.Controls.Add(Me.ListPictures)
        Me.GrpPictures.Controls.Add(Me.BtnRemovePic)
        Me.GrpPictures.Location = New System.Drawing.Point(12, 357)
        Me.GrpPictures.Name = "GrpPictures"
        Me.GrpPictures.Size = New System.Drawing.Size(710, 136)
        Me.GrpPictures.TabIndex = 78
        Me.GrpPictures.TabStop = False
        Me.GrpPictures.Text = "Bilder welche bei Ebay hochgeladen werden"
        '
        'CboPicDisplay
        '
        Me.CboPicDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboPicDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPicDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboPicDisplay.Location = New System.Drawing.Point(516, 96)
        Me.CboPicDisplay.Name = "CboPicDisplay"
        Me.CboPicDisplay.Size = New System.Drawing.Size(183, 21)
        Me.CboPicDisplay.TabIndex = 54
        '
        'BtnAddPic
        '
        Me.BtnAddPic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddPic.BackColor = System.Drawing.Color.PapayaWhip
        Me.BtnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPic.Location = New System.Drawing.Point(524, 24)
        Me.BtnAddPic.Name = "BtnAddPic"
        Me.BtnAddPic.Size = New System.Drawing.Size(137, 23)
        Me.BtnAddPic.TabIndex = 1
        Me.BtnAddPic.Text = "Hinzufügen"
        Me.BtnAddPic.UseVisualStyleBackColor = False
        '
        'ListPictures
        '
        Me.ListPictures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListPictures.Location = New System.Drawing.Point(16, 63)
        Me.ListPictures.Name = "ListPictures"
        Me.ListPictures.Size = New System.Drawing.Size(494, 54)
        Me.ListPictures.TabIndex = 0
        '
        'BtnRemovePic
        '
        Me.BtnRemovePic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemovePic.BackColor = System.Drawing.Color.PapayaWhip
        Me.BtnRemovePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemovePic.Location = New System.Drawing.Point(524, 56)
        Me.BtnRemovePic.Name = "BtnRemovePic"
        Me.BtnRemovePic.Size = New System.Drawing.Size(137, 23)
        Me.BtnRemovePic.TabIndex = 1
        Me.BtnRemovePic.Text = "Entfernen"
        Me.BtnRemovePic.UseVisualStyleBackColor = False
        '
        'CboListType
        '
        Me.CboListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboListType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboListType.Location = New System.Drawing.Point(123, 37)
        Me.CboListType.Name = "CboListType"
        Me.CboListType.Size = New System.Drawing.Size(121, 21)
        Me.CboListType.TabIndex = 116
        '
        'LblListType
        '
        Me.LblListType.Location = New System.Drawing.Point(25, 40)
        Me.LblListType.Name = "LblListType"
        Me.LblListType.Size = New System.Drawing.Size(100, 23)
        Me.LblListType.TabIndex = 115
        Me.LblListType.Text = "Auktions Typ"
        '
        'TxtPayPalEmailAddress
        '
        Me.TxtPayPalEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPayPalEmailAddress.Location = New System.Drawing.Point(432, 218)
        Me.TxtPayPalEmailAddress.Name = "TxtPayPalEmailAddress"
        Me.TxtPayPalEmailAddress.Size = New System.Drawing.Size(213, 21)
        Me.TxtPayPalEmailAddress.TabIndex = 113
        '
        'LblPayPalEmailAddress
        '
        Me.LblPayPalEmailAddress.Location = New System.Drawing.Point(288, 220)
        Me.LblPayPalEmailAddress.Name = "LblPayPalEmailAddress"
        Me.LblPayPalEmailAddress.Size = New System.Drawing.Size(144, 19)
        Me.LblPayPalEmailAddress.TabIndex = 114
        Me.LblPayPalEmailAddress.Text = "PayPal Email Address:"
        '
        'TxtApplicationData
        '
        Me.TxtApplicationData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApplicationData.Location = New System.Drawing.Point(529, 80)
        Me.TxtApplicationData.Name = "TxtApplicationData"
        Me.TxtApplicationData.Size = New System.Drawing.Size(100, 21)
        Me.TxtApplicationData.TabIndex = 111
        '
        'lblApplicationData
        '
        Me.lblApplicationData.Location = New System.Drawing.Point(433, 80)
        Me.lblApplicationData.Name = "lblApplicationData"
        Me.lblApplicationData.Size = New System.Drawing.Size(100, 23)
        Me.lblApplicationData.TabIndex = 112
        Me.lblApplicationData.Text = "ApplicationData:"
        '
        'TxtCategory2
        '
        Me.TxtCategory2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategory2.Location = New System.Drawing.Point(305, 107)
        Me.TxtCategory2.Name = "TxtCategory2"
        Me.TxtCategory2.Size = New System.Drawing.Size(100, 21)
        Me.TxtCategory2.TabIndex = 109
        '
        'lblCategory2
        '
        Me.lblCategory2.Location = New System.Drawing.Point(232, 109)
        Me.lblCategory2.Name = "lblCategory2"
        Me.lblCategory2.Size = New System.Drawing.Size(100, 23)
        Me.lblCategory2.TabIndex = 110
        Me.lblCategory2.Text = "Kategorie2"
        '
        'ChkEnableBestOffer
        '
        Me.ChkEnableBestOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkEnableBestOffer.Location = New System.Drawing.Point(258, 32)
        Me.ChkEnableBestOffer.Name = "ChkEnableBestOffer"
        Me.ChkEnableBestOffer.Size = New System.Drawing.Size(136, 32)
        Me.ChkEnableBestOffer.TabIndex = 108
        Me.ChkEnableBestOffer.Text = "Best Offer"
        Me.ChkEnableBestOffer.Visible = False
        '
        'CboDuration
        '
        Me.CboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboDuration.Location = New System.Drawing.Point(305, 76)
        Me.CboDuration.Name = "CboDuration"
        Me.CboDuration.Size = New System.Drawing.Size(104, 21)
        Me.CboDuration.TabIndex = 107
        '
        'TxtLocation
        '
        Me.TxtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLocation.Location = New System.Drawing.Point(116, 220)
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(155, 21)
        Me.TxtLocation.TabIndex = 105
        Me.TxtLocation.Text = "Oldenburg"
        '
        'LblLocation
        '
        Me.LblLocation.Location = New System.Drawing.Point(20, 220)
        Me.LblLocation.Name = "LblLocation"
        Me.LblLocation.Size = New System.Drawing.Size(100, 23)
        Me.LblLocation.TabIndex = 106
        Me.LblLocation.Text = "Standort"
        '
        'LblDuration
        '
        Me.LblDuration.Location = New System.Drawing.Point(248, 76)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(73, 23)
        Me.LblDuration.TabIndex = 104
        Me.LblDuration.Text = "Dauer"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Location = New System.Drawing.Point(120, 77)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(100, 21)
        Me.TxtQuantity.TabIndex = 102
        Me.TxtQuantity.Text = "1"
        '
        'LblQuantity
        '
        Me.LblQuantity.Location = New System.Drawing.Point(25, 77)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(56, 23)
        Me.LblQuantity.TabIndex = 103
        Me.LblQuantity.Text = "Menge"
        '
        'ChkHighLight
        '
        Me.ChkHighLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkHighLight.Location = New System.Drawing.Point(495, 7)
        Me.ChkHighLight.Name = "ChkHighLight"
        Me.ChkHighLight.Size = New System.Drawing.Size(104, 24)
        Me.ChkHighLight.TabIndex = 101
        Me.ChkHighLight.Text = "HighLight"
        '
        'ChkBoldTitle
        '
        Me.ChkBoldTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkBoldTitle.Location = New System.Drawing.Point(432, 8)
        Me.ChkBoldTitle.Name = "ChkBoldTitle"
        Me.ChkBoldTitle.Size = New System.Drawing.Size(104, 24)
        Me.ChkBoldTitle.TabIndex = 100
        Me.ChkBoldTitle.Text = "Fett"
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTitle.Location = New System.Drawing.Point(123, 7)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(286, 21)
        Me.TxtTitle.TabIndex = 88
        Me.TxtTitle.Text = "API Testprodukt A"
        '
        'TxtDescription
        '
        Me.TxtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescription.Location = New System.Drawing.Point(12, 259)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescription.Size = New System.Drawing.Size(710, 92)
        Me.TxtDescription.TabIndex = 93
        Me.TxtDescription.Text = "Meine Beschreibung"
        '
        'TxtBuyItNowPrice
        '
        Me.TxtBuyItNowPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuyItNowPrice.Location = New System.Drawing.Point(116, 184)
        Me.TxtBuyItNowPrice.Name = "TxtBuyItNowPrice"
        Me.TxtBuyItNowPrice.Size = New System.Drawing.Size(104, 21)
        Me.TxtBuyItNowPrice.TabIndex = 92
        '
        'TxtCategory
        '
        Me.TxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategory.Location = New System.Drawing.Point(121, 111)
        Me.TxtCategory.Name = "TxtCategory"
        Me.TxtCategory.Size = New System.Drawing.Size(100, 21)
        Me.TxtCategory.TabIndex = 89
        Me.TxtCategory.Text = "31740"
        '
        'TxtReservePrice
        '
        Me.TxtReservePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReservePrice.Location = New System.Drawing.Point(305, 143)
        Me.TxtReservePrice.Name = "TxtReservePrice"
        Me.TxtReservePrice.Size = New System.Drawing.Size(100, 21)
        Me.TxtReservePrice.TabIndex = 90
        '
        'TxtStartPrice
        '
        Me.TxtStartPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStartPrice.Location = New System.Drawing.Point(123, 145)
        Me.TxtStartPrice.Name = "TxtStartPrice"
        Me.TxtStartPrice.Size = New System.Drawing.Size(100, 21)
        Me.TxtStartPrice.TabIndex = 91
        Me.TxtStartPrice.Text = "1,00"
        '
        'LblCategory
        '
        Me.LblCategory.Location = New System.Drawing.Point(25, 111)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(100, 23)
        Me.LblCategory.TabIndex = 95
        Me.LblCategory.Text = "Kategorie"
        '
        'LblStartPrice
        '
        Me.LblStartPrice.Location = New System.Drawing.Point(24, 145)
        Me.LblStartPrice.Name = "LblStartPrice"
        Me.LblStartPrice.Size = New System.Drawing.Size(100, 23)
        Me.LblStartPrice.TabIndex = 97
        Me.LblStartPrice.Text = "Startpreis"
        '
        'LblTitle
        '
        Me.LblTitle.Location = New System.Drawing.Point(24, 8)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(100, 23)
        Me.LblTitle.TabIndex = 94
        Me.LblTitle.Text = "Titel"
        '
        'LblBuyItNowPrice
        '
        Me.LblBuyItNowPrice.Location = New System.Drawing.Point(40, 184)
        Me.LblBuyItNowPrice.Name = "LblBuyItNowPrice"
        Me.LblBuyItNowPrice.Size = New System.Drawing.Size(104, 23)
        Me.LblBuyItNowPrice.TabIndex = 98
        Me.LblBuyItNowPrice.Text = "Buy it Now"
        '
        'LblReservePrice
        '
        Me.LblReservePrice.Location = New System.Drawing.Point(232, 145)
        Me.LblReservePrice.Name = "LblReservePrice"
        Me.LblReservePrice.Size = New System.Drawing.Size(80, 23)
        Me.LblReservePrice.TabIndex = 96
        Me.LblReservePrice.Text = "Reserve Price:"
        '
        'txtExternBild
        '
        Me.txtExternBild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExternBild.Location = New System.Drawing.Point(108, 36)
        Me.txtExternBild.Name = "txtExternBild"
        Me.txtExternBild.Size = New System.Drawing.Size(402, 21)
        Me.txtExternBild.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "externes Bild"
        '
        'cmbVersand
        '
        Me.cmbVersand.FormattingEnabled = True
        Me.cmbVersand.Location = New System.Drawing.Point(528, 108)
        Me.cmbVersand.Name = "cmbVersand"
        Me.cmbVersand.Size = New System.Drawing.Size(176, 21)
        Me.cmbVersand.TabIndex = 117
        '
        'txtVersandKosten
        '
        Me.txtVersandKosten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersandKosten.Location = New System.Drawing.Point(529, 143)
        Me.txtVersandKosten.Name = "txtVersandKosten"
        Me.txtVersandKosten.Size = New System.Drawing.Size(100, 21)
        Me.txtVersandKosten.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(426, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 23)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Versandkosten"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(429, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Versandart"
        '
        'FormAddItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(734, 608)
        Me.Controls.Add(Me.cmbVersand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVersandKosten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboDuration)
        Me.Controls.Add(Me.CboListType)
        Me.Controls.Add(Me.LblListType)
        Me.Controls.Add(Me.TxtPayPalEmailAddress)
        Me.Controls.Add(Me.LblPayPalEmailAddress)
        Me.Controls.Add(Me.TxtApplicationData)
        Me.Controls.Add(Me.lblApplicationData)
        Me.Controls.Add(Me.TxtCategory2)
        Me.Controls.Add(Me.lblCategory2)
        Me.Controls.Add(Me.ChkEnableBestOffer)
        Me.Controls.Add(Me.TxtLocation)
        Me.Controls.Add(Me.LblLocation)
        Me.Controls.Add(Me.LblDuration)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.LblQuantity)
        Me.Controls.Add(Me.ChkHighLight)
        Me.Controls.Add(Me.ChkBoldTitle)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.TxtBuyItNowPrice)
        Me.Controls.Add(Me.TxtCategory)
        Me.Controls.Add(Me.TxtReservePrice)
        Me.Controls.Add(Me.TxtStartPrice)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.LblStartPrice)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblBuyItNowPrice)
        Me.Controls.Add(Me.LblReservePrice)
        Me.Controls.Add(Me.BtnVerifyAddItem)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.BtnAddItem)
        Me.Controls.Add(Me.GrpPictures)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo -> eBay Artikel einstellen"
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.GrpPictures.ResumeLayout(False)
        Me.GrpPictures.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Context As ApiContext

    Private Sub FrmAddItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim item As String

        TxtPayPalEmailAddress.Text = My.Settings.yabe_paypal_emailusername
        txtVersandKosten.Text = My.Settings.eiso_ebay_item_add_versand_kosten
        TxtLocation.Text = My.Settings.eiso_ebay_item_add_standort
        TxtCategory.Text = My.Settings.eiso_ebay_item_add_kategorie


        If My.Settings.ebay_sandbox = True Then
            Me.Text = Me.Text & " (Sandbox) "
        Else
            Me.Text = Me.Text & " (Produktiv) "
        End If

        Dim durations() As String = Split("Days_1;Days_3;Days_5;Days_7", ";")
        REM Dim durations() As String = [Enum].GetNames(GetType(ListingDurationCodeType))
        For Each item In durations
            If item <> "CustomCode" Then
                CboDuration.Items.Add(item)
            End If
        Next item

        Dim shpsvcs As Type = GetType(ShippingServiceCodeType)
        Dim svc As String

        For Each svc In [Enum].GetNames(shpsvcs)
            If svc <> "CustomCode" Then
                If svc.IndexOf("DE_") >= 0 Then
                    cmbVersand.Items.Add(svc)
                End If
            End If
        Next svc
        cmbVersand.SelectedIndex = My.Settings.eiso_ebay_item_add_versand_index
        ' cmbVersand.SelectedIndex = 0
        Dim photoDisplay As Type = GetType(PhotoDisplayCodeType)
        For Each item In [Enum].GetNames(photoDisplay)
            If item <> "CustomCode" Then
                CboPicDisplay.Items.Add(item)
            End If
        Next item

        Dim listingType As Type = GetType(ListingTypeCodeType)
        For Each item In [Enum].GetNames(listingType)
            If item <> "CustomCode" And item <> "Unknown" Then
                CboListType.Items.Add(item)
            End If
        Next item

        If Not lvwWebArtikel.Items.Count = Nothing Then
            TxtDescription.Text = lvwWebArtikel.SelectedItems(0).SubItems(1).Text
            txtExternBild.Text = lvwWebArtikel.SelectedItems(0).SubItems(3).Text

        End If

        CboDuration.SelectedIndex = 0
        CboPicDisplay.SelectedIndex = 0
        CboListType.SelectedIndex = 0

    End Sub


    Private Function FillItem() As ItemType

        Dim item As ItemType = New ItemType
        ' Set UP Defaults
        Context = clseBayAPI.setAPIContext()
        item.Currency = CurrencyUtility.GetDefaultCurrencyCodeType(Context.Site)
        item.Country = SiteUtility.GetCountryCodeType(Context.Site)

        item.PaymentMethods = New BuyerPaymentMethodCodeTypeCollection
        item.PaymentMethods.Add(BuyerPaymentMethodCodeType.PayPal)
        item.RegionID = "0"

        ' Set specIfied values from the form

        item.Title = Me.TxtTitle.Text

        item.Description = Me.TxtDescription.Text



        item.Quantity = Int32.Parse(TxtQuantity.Text, NumberStyles.None)

        item.Location = TxtLocation.Text

        item.ListingDuration = CboDuration.SelectedItem.ToString()

        item.PrimaryCategory = New CategoryType

        item.PrimaryCategory.CategoryID = Me.TxtCategory.Text

        If TxtStartPrice.Text.Length > 0 Then
            item.StartPrice = New AmountType
            item.StartPrice.currencyID = item.Currency
            item.StartPrice.Value = Convert.ToDouble(Me.TxtStartPrice.Text)
        End If

        If TxtReservePrice.Visible And TxtReservePrice.Text.Length > 0 Then

            item.ReservePrice = New AmountType

            item.ReservePrice.currencyID = item.Currency

            item.ReservePrice.Value = Convert.ToDouble(Me.TxtReservePrice.Text)

        End If

        If TxtBuyItNowPrice.Visible And TxtBuyItNowPrice.Text.Length > 0 Then
            item.BuyItNowPrice = New AmountType
            item.BuyItNowPrice.currencyID = item.Currency
            item.BuyItNowPrice.Value = Convert.ToDouble(Me.TxtBuyItNowPrice.Text)
        End If

        Dim enhancements As ListingEnhancementsCodeTypeCollection = New ListingEnhancementsCodeTypeCollection

        If Me.ChkBoldTitle.Checked Then
            enhancements.Add(ListingEnhancementsCodeType.BoldTitle)
        End If

        If Me.ChkHighLight.Checked Then
            enhancements.Add(ListingEnhancementsCodeType.Highlight)
        End If

        item.ListingType = [Enum].Parse(GetType(ListingTypeCodeType), CboListType.SelectedItem.ToString())

        If ChkEnableBestOffer.Visible Then
            item.BestOfferDetails = New BestOfferDetailsType
            item.BestOfferDetails.BestOfferEnabled = ChkEnableBestOffer.Checked
        End If


        If enhancements.Count > 0 Then
            item.ListingEnhancement = enhancements
        End If

        item.BestOfferDetails = New BestOfferDetailsType
        item.BestOfferDetails.BestOfferEnabled = ChkEnableBestOffer.Checked

        If TxtPayPalEmailAddress.Text.Length > 0 Then
            item.PayPalEmailAddress = TxtPayPalEmailAddress.Text
        End If

        item.ApplicationData = TxtApplicationData.Text

        If TxtCategory2.Text.Length > 0 Then
            item.SecondaryCategory = New CategoryType
            item.SecondaryCategory.CategoryID = TxtCategory2.Text
        End If

        'add shipping information
        'item.ShippingDetails = getShippingDetails()
        item.ShippingDetails = BuildShippingDetails()

        'add handling time
        item.DispatchTimeMax = 1
        'add policy
        ' return policy

        ' NEU = 100
        ' http://developer.ebay.com/devzone/finding/callref/Enums/conditionIdList.html#ConditionIDValues
        item.ConditionID = 1000

        item.ReturnPolicy = New ReturnPolicyType()
        item.ReturnPolicy.ReturnsAcceptedOption = "ReturnsAccepted"

        Return item

    End Function



    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click

        Try

            TxtItemId.Text = ""

            TxtListingFee.Text = ""

            Dim item As ItemType = FillItem()
            Dim ApiCall As AddItemCall = New AddItemCall(Context)
            Dim pic As String

            'If ListPictures.Items.Count > 0 Then
            '    ApiCall.PictureFileList = New StringCollection
            '    item.PictureDetails = New PictureDetailsType
            '    item.PictureDetails.PhotoDisplay = [Enum].Parse(GetType(PhotoDisplayCodeType), CboPicDisplay.SelectedItem.ToString())
            'End If

            ''For Each pic In ListPictures.Items
            ''    ApiCall.PictureFileList.Add(pic)
            ''Next

            'item.PictureDetails = New PictureDetailsType()
            'item.PictureDetails.PictureURL = New StringCollection()
            'item.PictureDetails.PictureURL.Add(txtExternBild.Text)

            '#
            '# Externes oder Lokales Bild
            '# 
            If txtExternBild.Text.Length > 0 Then
                item.PictureDetails = New PictureDetailsType()
                item.PictureDetails.PictureURL = New StringCollection()
                item.PictureDetails.PictureURL.Add(txtExternBild.Text)
            Else

                'For Each pic In ListPictures.Items
                ' & pic
                If ListPictures.Items.Count > 0 Then
                    ApiCall.PictureFileList = New StringCollection()

                    item.PictureDetails = New PictureDetailsType()
                    'item.PictureDetails.PhotoDisplay = [Enum].Parse(GetType(PhotoDisplayCodeType), CboPicDisplay.SelectedItem.ToString())
                    item.PictureDetails.GalleryType = GalleryTypeCodeType.Gallery
                    item.PictureDetails.PhotoDisplay = PhotoDisplayCodeType.PicturePack
                End If

                For Each pic In ListPictures.Items
                    ApiCall.PictureFileList.Add(pic)
                Next


                '   ApiCall.PictureFileList.Add(@"C:\Users\jbludau\Desktop\2015-08-27 18_03_28-Amazon Error Page.png")
                ' Next
                'If ListPictures.Items.Count > 0 Then

                'item.PictureDetails.PictureURL = ""
                'End If
            End If

            Dim fees As FeeTypeCollection = ApiCall.AddItem(item)
            Dim fee As FeeType
            TxtItemId.Text = item.ItemID

            For Each fee In fees
                If fee.Name = "ListingFee" Then
                    TxtListingFee.Text = fee.Fee.Value.ToString()
                End If
            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub BtnVerIfyAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerifyAddItem.Click

        Try

            TxtItemId.Text = ""

            TxtListingFee.Text = ""
            Dim pic As String

            Dim item As ItemType = FillItem()
            Context = clseBayAPI.setAPIContext()
            Dim ApiCall As VerifyAddItemCall = New VerifyAddItemCall(Context)

            '#
            '# Externes oder Lokales Bild
            '# 
            If txtExternBild.Text.Length > 0 Then
                item.PictureDetails = New PictureDetailsType()
                item.PictureDetails.PictureURL = New StringCollection()
                item.PictureDetails.PictureURL.Add(txtExternBild.Text)
            Else
                If ListPictures.Items.Count > 0 Then
                    ApiCall.PictureFileList = New StringCollection()

                    item.PictureDetails = New PictureDetailsType()
                    'item.PictureDetails.PhotoDisplay = [Enum].Parse(GetType(PhotoDisplayCodeType), CboPicDisplay.SelectedItem.ToString())
                    item.PictureDetails.GalleryType = GalleryTypeCodeType.Gallery
                    item.PictureDetails.PhotoDisplay = PhotoDisplayCodeType.PicturePack
                End If

                For Each pic In ListPictures.Items
                    ApiCall.PictureFileList.Add(pic)
                Next

            End If


            'ent



            Dim fees As FeeTypeCollection = ApiCall.VerifyAddItem(item)
            Dim fee As FeeType


            For Each fee In fees
                If fee.Name = "ListingFee" Then
                    TxtListingFee.Text = fee.Fee.Value.ToString()
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub BtnAddPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPic.Click
        If OpenFileDialogIMG.ShowDialog() = DialogResult.OK Then
            ListPictures.Items.Add(OpenFileDialogIMG.FileName)
        End If
    End Sub



    Private Sub BtnRemovePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePic.Click

        If -1 <> ListPictures.SelectedIndex Then
            ListPictures.Items.RemoveAt(ListPictures.SelectedIndex)
        End If

    End Sub

    Private Sub CboListType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboListType.SelectedIndexChanged
        Dim selectedText As String = CboListType.Text
        Dim VisibleFlag As Boolean = (selectedText.Equals("StoresFixedPrice") Or selectedText.Equals("FixedPriceItem"))

        ChkEnableBestOffer.Visible = VisibleFlag
        TxtReservePrice.Visible = Not VisibleFlag
        TxtBuyItNowPrice.Visible = Not VisibleFlag

    End Sub

    Private Sub TxtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescription.TextChanged

    End Sub

    Private Sub OpenFileDialogIMG_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogIMG.FileOk

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblDuration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDuration.Click

    End Sub
    Private Function BuildShippingDetails() As ShippingDetailsType
        ' Shipping details
        Dim sd As ShippingDetailsType = New ShippingDetailsType()

        sd.ApplyShippingDiscount = True
        Dim amount As AmountType = New AmountType()
        'amount.Value = 2.8
        'amount.currencyID = CurrencyCodeType.EUR
        sd.PaymentInstructions = ""

        ' Shipping type and shipping service options
        sd.ShippingType = ShippingTypeCodeType.Flat
        Dim shippingOptions As ShippingServiceOptionsType = New ShippingServiceOptionsType()
        'ShippingServiceCodeType.DE_DeutschePostBrief.ToString
        shippingOptions.ShippingService = cmbVersand.Text

        'amount = New AmountType()
        'amount.Value = 2.0
        'amount.currencyID = CurrencyCodeType.EUR
        'shippingOptions.ShippingServiceAdditionalCost = amount
        amount = New AmountType()
        amount.Value = Convert.ToDouble(txtVersandKosten.Text)
        amount.currencyID = CurrencyCodeType.EUR
        shippingOptions.ShippingServiceCost = amount
        shippingOptions.ShippingServicePriority = 1

        'amount = New AmountType()
        'amount.Value = 1.0
        'amount.currencyID = CurrencyCodeType.EUR
        'shippingOptions.ShippingInsuranceCost = amount

        sd.ShippingServiceOptions = New ShippingServiceOptionsTypeCollection()
        sd.ShippingServiceOptions.Add(shippingOptions)

        Return sd

    End Function
    Private Function getShippingDetails() As ShippingDetailsType
        'Shipping details.
        Dim sd As ShippingDetailsType = New ShippingDetailsType
        Dim salesTax As SalesTaxType = New SalesTaxType
        salesTax.SalesTaxPercent = 0.0825F
        salesTax.SalesTaxState = "CA"
        sd.ApplyShippingDiscount = True
        Dim at As AmountType = New AmountType
        at.Value = 2.8
        at.currencyID = CurrencyCodeType.EUR
        sd.InsuranceFee = at
        sd.InsuranceOption = InsuranceOptionCodeType.Optional
        sd.PaymentInstructions = "eBay DotNet SDK test instruction."

        'Set calculated shipping.
        sd.ShippingType = ShippingTypeCodeType.Flat

        Dim st1 As ShippingServiceOptionsType = New ShippingServiceOptionsType
        st1.ShippingService = ShippingServiceCodeType.ShippingMethodStandard.ToString()
        at = New AmountType
        at.Value = 2.0
        at.currencyID = CurrencyCodeType.EUR
        st1.ShippingServiceAdditionalCost = at
        at = New AmountType
        at.Value = 10
        at.currencyID = CurrencyCodeType.EUR
        st1.ShippingServiceCost = at
        st1.ShippingServicePriority = 1
        at = New AmountType
        at.Value = 1.0
        at.currencyID = CurrencyCodeType.EUR
        st1.ShippingInsuranceCost = at

        Dim st2 As ShippingServiceOptionsType = New ShippingServiceOptionsType
        st2.ExpeditedService = True
        st2.ShippingService = ShippingServiceCodeType.ShippingMethodExpress.ToString()
        at = New AmountType
        at.Value = 2.0
        at.currencyID = CurrencyCodeType.EUR
        st2.ShippingServiceAdditionalCost = at
        at = New AmountType
        at.Value = 15
        at.currencyID = CurrencyCodeType.EUR
        st2.ShippingServiceCost = at
        st2.ShippingServicePriority = 2
        at = New AmountType
        at.Value = 1.0
        at.currencyID = CurrencyCodeType.EUR
        st2.ShippingInsuranceCost = at

        Dim serviceOptions As ShippingServiceOptionsTypeCollection = New ShippingServiceOptionsTypeCollection
        serviceOptions.Add(st1)
        serviceOptions.Add(st2)

        sd.ShippingServiceOptions = serviceOptions

        Return sd

    End Function

    'get policy
    Public Function GetPolicyForUS() As ReturnPolicyType
        Dim policy As ReturnPolicyType = New ReturnPolicyType
        policy.Refund = "MoneyBack"
        policy.ReturnsWithinOption = "Days_3"
        policy.ReturnsAcceptedOption = "ReturnsAccepted"
        policy.ShippingCostPaidByOption = "Buyer"
        Return policy
    End Function

    Private Sub txtVersandKosten_TextChanged(sender As Object, e As EventArgs) Handles txtVersandKosten.TextChanged
        My.Settings.eiso_ebay_item_add_versand_kosten = txtVersandKosten.Text
        My.Settings.Save()
    End Sub

    Private Sub cmbVersand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVersand.SelectedIndexChanged
        My.Settings.eiso_ebay_item_add_versand_index = cmbVersand.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub TxtCategory_TextChanged(sender As Object, e As EventArgs) Handles TxtCategory.TextChanged
        My.Settings.eiso_ebay_item_add_kategorie = TxtCategory.Text
        My.Settings.Save()
    End Sub

    Private Sub TxtLocation_TextChanged(sender As Object, e As EventArgs) Handles TxtLocation.TextChanged
        My.Settings.eiso_ebay_item_add_standort = TxtLocation.Text
        My.Settings.Save()
    End Sub
End Class


