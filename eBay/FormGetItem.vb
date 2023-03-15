
Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FormGetItem
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

    Friend WithEvents BtnListItem As System.Windows.Forms.Button


























    Private WithEvents BtnGetItem As System.Windows.Forms.Button
    Private WithEvents btnVor As System.Windows.Forms.Button
    Private WithEvents btnZurück As System.Windows.Forms.Button
    Friend WithEvents webBildvorschau As System.Windows.Forms.WebBrowser
    Private WithEvents GrpResult As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBestOfferCount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVersand_International As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVersandart As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVersand As System.Windows.Forms.TextBox
    Private WithEvents TxtQuantitySold As System.Windows.Forms.TextBox
    Private WithEvents TxtEndTime As System.Windows.Forms.TextBox
    Friend WithEvents TxtPayPalEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblPayPalEmailAddress As System.Windows.Forms.Label
    Friend WithEvents LblBestOfferEnabled As System.Windows.Forms.Label
    Friend WithEvents TxtBestOfferEnabled As System.Windows.Forms.TextBox
    Friend WithEvents LblBestOfferCount As System.Windows.Forms.Label
    Private WithEvents TxtCurrentPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblCurrentPrice As System.Windows.Forms.Label
    Friend WithEvents LblBidCount As System.Windows.Forms.Label
    Private WithEvents TxtBidCount As System.Windows.Forms.TextBox
    Private WithEvents TxtCategory As System.Windows.Forms.TextBox
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Private WithEvents TxtCategory2 As System.Windows.Forms.TextBox
    Friend WithEvents LblCategory2 As System.Windows.Forms.Label
    Private WithEvents TxtStartTime As System.Windows.Forms.TextBox
    Friend WithEvents LblStartTime As System.Windows.Forms.Label
    Private WithEvents TxtBuyItNowPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblBuyItNowPrice As System.Windows.Forms.Label
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Private WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LblQuantitySold As System.Windows.Forms.Label
    Friend WithEvents LblEndTime As System.Windows.Forms.Label
    Private WithEvents TxtHighBidder As System.Windows.Forms.TextBox
    Friend WithEvents LblHighBidder As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents txteBayID As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGetItem))
        Me.BtnGetItem = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnVor = New System.Windows.Forms.Button()
        Me.btnZurück = New System.Windows.Forms.Button()
        Me.webBildvorschau = New System.Windows.Forms.WebBrowser()
        Me.GrpResult = New System.Windows.Forms.GroupBox()
        Me.TxtBestOfferCount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVersand_International = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVersandart = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVersand = New System.Windows.Forms.TextBox()
        Me.TxtQuantitySold = New System.Windows.Forms.TextBox()
        Me.TxtEndTime = New System.Windows.Forms.TextBox()
        Me.TxtPayPalEmailAddress = New System.Windows.Forms.TextBox()
        Me.LblPayPalEmailAddress = New System.Windows.Forms.Label()
        Me.LblBestOfferEnabled = New System.Windows.Forms.Label()
        Me.TxtBestOfferEnabled = New System.Windows.Forms.TextBox()
        Me.LblBestOfferCount = New System.Windows.Forms.Label()
        Me.TxtCurrentPrice = New System.Windows.Forms.TextBox()
        Me.LblCurrentPrice = New System.Windows.Forms.Label()
        Me.LblBidCount = New System.Windows.Forms.Label()
        Me.TxtBidCount = New System.Windows.Forms.TextBox()
        Me.TxtCategory = New System.Windows.Forms.TextBox()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.TxtCategory2 = New System.Windows.Forms.TextBox()
        Me.LblCategory2 = New System.Windows.Forms.Label()
        Me.TxtStartTime = New System.Windows.Forms.TextBox()
        Me.LblStartTime = New System.Windows.Forms.Label()
        Me.TxtBuyItNowPrice = New System.Windows.Forms.TextBox()
        Me.LblBuyItNowPrice = New System.Windows.Forms.Label()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.LblQuantitySold = New System.Windows.Forms.Label()
        Me.LblEndTime = New System.Windows.Forms.Label()
        Me.TxtHighBidder = New System.Windows.Forms.TextBox()
        Me.LblHighBidder = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.txteBayID = New System.Windows.Forms.TextBox()
        Me.GrpResult.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGetItem
        '
        Me.BtnGetItem.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetItem.ImageIndex = 4
        Me.BtnGetItem.ImageList = Me.ImageList1
        Me.BtnGetItem.Location = New System.Drawing.Point(314, 438)
        Me.BtnGetItem.Name = "BtnGetItem"
        Me.BtnGetItem.Size = New System.Drawing.Size(344, 28)
        Me.BtnGetItem.TabIndex = 28
        Me.BtnGetItem.Text = "&eBay Artikel Details abrufen"
        Me.BtnGetItem.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "abbrechen.ico")
        Me.ImageList1.Images.SetKeyName(1, "Search.ico")
        Me.ImageList1.Images.SetKeyName(2, "rechts.gif")
        Me.ImageList1.Images.SetKeyName(3, "links.gif")
        Me.ImageList1.Images.SetKeyName(4, "send.ico")
        '
        'btnVor
        '
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.ImageIndex = 2
        Me.btnVor.ImageList = Me.ImageList1
        Me.btnVor.Location = New System.Drawing.Point(170, 438)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(133, 28)
        Me.btnVor.TabIndex = 28
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'btnZurück
        '
        Me.btnZurück.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnZurück.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZurück.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZurück.ImageIndex = 3
        Me.btnZurück.ImageList = Me.ImageList1
        Me.btnZurück.Location = New System.Drawing.Point(28, 438)
        Me.btnZurück.Name = "btnZurück"
        Me.btnZurück.Size = New System.Drawing.Size(134, 28)
        Me.btnZurück.TabIndex = 28
        Me.btnZurück.Text = "&Zurück"
        Me.btnZurück.UseVisualStyleBackColor = False
        '
        'webBildvorschau
        '
        Me.webBildvorschau.Location = New System.Drawing.Point(23, 33)
        Me.webBildvorschau.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBildvorschau.Name = "webBildvorschau"
        Me.webBildvorschau.Size = New System.Drawing.Size(540, 411)
        Me.webBildvorschau.TabIndex = 106
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.TxtBestOfferCount)
        Me.GrpResult.Controls.Add(Me.Label3)
        Me.GrpResult.Controls.Add(Me.txtVersand_International)
        Me.GrpResult.Controls.Add(Me.Label2)
        Me.GrpResult.Controls.Add(Me.txtVersandart)
        Me.GrpResult.Controls.Add(Me.Label1)
        Me.GrpResult.Controls.Add(Me.txtVersand)
        Me.GrpResult.Controls.Add(Me.TxtQuantitySold)
        Me.GrpResult.Controls.Add(Me.TxtEndTime)
        Me.GrpResult.Controls.Add(Me.TxtPayPalEmailAddress)
        Me.GrpResult.Controls.Add(Me.LblPayPalEmailAddress)
        Me.GrpResult.Controls.Add(Me.LblBestOfferEnabled)
        Me.GrpResult.Controls.Add(Me.TxtBestOfferEnabled)
        Me.GrpResult.Controls.Add(Me.LblBestOfferCount)
        Me.GrpResult.Controls.Add(Me.TxtCurrentPrice)
        Me.GrpResult.Controls.Add(Me.LblCurrentPrice)
        Me.GrpResult.Controls.Add(Me.LblBidCount)
        Me.GrpResult.Controls.Add(Me.TxtBidCount)
        Me.GrpResult.Controls.Add(Me.TxtCategory)
        Me.GrpResult.Controls.Add(Me.LblCategory)
        Me.GrpResult.Controls.Add(Me.TxtCategory2)
        Me.GrpResult.Controls.Add(Me.LblCategory2)
        Me.GrpResult.Controls.Add(Me.TxtStartTime)
        Me.GrpResult.Controls.Add(Me.LblStartTime)
        Me.GrpResult.Controls.Add(Me.TxtBuyItNowPrice)
        Me.GrpResult.Controls.Add(Me.LblBuyItNowPrice)
        Me.GrpResult.Controls.Add(Me.LblQuantity)
        Me.GrpResult.Controls.Add(Me.TxtQuantity)
        Me.GrpResult.Controls.Add(Me.LblQuantitySold)
        Me.GrpResult.Controls.Add(Me.LblEndTime)
        Me.GrpResult.Controls.Add(Me.TxtHighBidder)
        Me.GrpResult.Controls.Add(Me.LblHighBidder)
        Me.GrpResult.Location = New System.Drawing.Point(15, 68)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(709, 363)
        Me.GrpResult.TabIndex = 107
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'TxtBestOfferCount
        '
        Me.TxtBestOfferCount.BackColor = System.Drawing.Color.White
        Me.TxtBestOfferCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBestOfferCount.Location = New System.Drawing.Point(496, 288)
        Me.TxtBestOfferCount.Name = "TxtBestOfferCount"
        Me.TxtBestOfferCount.ReadOnly = True
        Me.TxtBestOfferCount.Size = New System.Drawing.Size(128, 24)
        Me.TxtBestOfferCount.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 26)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Versandart"
        '
        'txtVersand_International
        '
        Me.txtVersand_International.BackColor = System.Drawing.Color.White
        Me.txtVersand_International.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersand_International.Location = New System.Drawing.Point(492, 101)
        Me.txtVersand_International.Name = "txtVersand_International"
        Me.txtVersand_International.ReadOnly = True
        Me.txtVersand_International.Size = New System.Drawing.Size(93, 24)
        Me.txtVersand_International.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(294, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 25)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Versand International"
        '
        'txtVersandart
        '
        Me.txtVersandart.BackColor = System.Drawing.Color.White
        Me.txtVersandart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersandart.Location = New System.Drawing.Point(154, 136)
        Me.txtVersandart.Name = "txtVersandart"
        Me.txtVersandart.ReadOnly = True
        Me.txtVersandart.Size = New System.Drawing.Size(198, 24)
        Me.txtVersandart.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Versand"
        '
        'txtVersand
        '
        Me.txtVersand.BackColor = System.Drawing.Color.White
        Me.txtVersand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersand.Location = New System.Drawing.Point(154, 98)
        Me.txtVersand.Name = "txtVersand"
        Me.txtVersand.ReadOnly = True
        Me.txtVersand.Size = New System.Drawing.Size(92, 24)
        Me.txtVersand.TabIndex = 101
        '
        'TxtQuantitySold
        '
        Me.TxtQuantitySold.BackColor = System.Drawing.Color.White
        Me.TxtQuantitySold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantitySold.Location = New System.Drawing.Point(496, 255)
        Me.TxtQuantitySold.Name = "TxtQuantitySold"
        Me.TxtQuantitySold.ReadOnly = True
        Me.TxtQuantitySold.Size = New System.Drawing.Size(59, 24)
        Me.TxtQuantitySold.TabIndex = 63
        '
        'TxtEndTime
        '
        Me.TxtEndTime.BackColor = System.Drawing.Color.White
        Me.TxtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEndTime.Location = New System.Drawing.Point(492, 29)
        Me.TxtEndTime.Name = "TxtEndTime"
        Me.TxtEndTime.ReadOnly = True
        Me.TxtEndTime.Size = New System.Drawing.Size(207, 24)
        Me.TxtEndTime.TabIndex = 65
        '
        'TxtPayPalEmailAddress
        '
        Me.TxtPayPalEmailAddress.BackColor = System.Drawing.Color.White
        Me.TxtPayPalEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPayPalEmailAddress.Location = New System.Drawing.Point(154, 323)
        Me.TxtPayPalEmailAddress.Name = "TxtPayPalEmailAddress"
        Me.TxtPayPalEmailAddress.ReadOnly = True
        Me.TxtPayPalEmailAddress.Size = New System.Drawing.Size(322, 24)
        Me.TxtPayPalEmailAddress.TabIndex = 99
        '
        'LblPayPalEmailAddress
        '
        Me.LblPayPalEmailAddress.Location = New System.Drawing.Point(15, 329)
        Me.LblPayPalEmailAddress.Name = "LblPayPalEmailAddress"
        Me.LblPayPalEmailAddress.Size = New System.Drawing.Size(155, 20)
        Me.LblPayPalEmailAddress.TabIndex = 92
        Me.LblPayPalEmailAddress.Text = "PayPalEmail:"
        '
        'LblBestOfferEnabled
        '
        Me.LblBestOfferEnabled.Location = New System.Drawing.Point(15, 285)
        Me.LblBestOfferEnabled.Name = "LblBestOfferEnabled"
        Me.LblBestOfferEnabled.Size = New System.Drawing.Size(134, 28)
        Me.LblBestOfferEnabled.TabIndex = 74
        Me.LblBestOfferEnabled.Text = "Best Offer Enabled:"
        '
        'TxtBestOfferEnabled
        '
        Me.TxtBestOfferEnabled.BackColor = System.Drawing.Color.White
        Me.TxtBestOfferEnabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBestOfferEnabled.Location = New System.Drawing.Point(154, 283)
        Me.TxtBestOfferEnabled.Name = "TxtBestOfferEnabled"
        Me.TxtBestOfferEnabled.ReadOnly = True
        Me.TxtBestOfferEnabled.Size = New System.Drawing.Size(155, 24)
        Me.TxtBestOfferEnabled.TabIndex = 77
        '
        'LblBestOfferCount
        '
        Me.LblBestOfferCount.Location = New System.Drawing.Point(383, 291)
        Me.LblBestOfferCount.Name = "LblBestOfferCount"
        Me.LblBestOfferCount.Size = New System.Drawing.Size(124, 28)
        Me.LblBestOfferCount.TabIndex = 75
        Me.LblBestOfferCount.Text = "Best Offer Count:"
        '
        'TxtCurrentPrice
        '
        Me.TxtCurrentPrice.BackColor = System.Drawing.Color.White
        Me.TxtCurrentPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCurrentPrice.Location = New System.Drawing.Point(154, 217)
        Me.TxtCurrentPrice.Name = "TxtCurrentPrice"
        Me.TxtCurrentPrice.ReadOnly = True
        Me.TxtCurrentPrice.Size = New System.Drawing.Size(92, 24)
        Me.TxtCurrentPrice.TabIndex = 73
        '
        'LblCurrentPrice
        '
        Me.LblCurrentPrice.Location = New System.Drawing.Point(15, 225)
        Me.LblCurrentPrice.Name = "LblCurrentPrice"
        Me.LblCurrentPrice.Size = New System.Drawing.Size(93, 28)
        Me.LblCurrentPrice.TabIndex = 60
        Me.LblCurrentPrice.Text = "Preis:"
        '
        'LblBidCount
        '
        Me.LblBidCount.Location = New System.Drawing.Point(379, 64)
        Me.LblBidCount.Name = "LblBidCount"
        Me.LblBidCount.Size = New System.Drawing.Size(93, 28)
        Me.LblBidCount.TabIndex = 62
        Me.LblBidCount.Text = "Gebote"
        '
        'TxtBidCount
        '
        Me.TxtBidCount.BackColor = System.Drawing.Color.White
        Me.TxtBidCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBidCount.Location = New System.Drawing.Point(492, 62)
        Me.TxtBidCount.Name = "TxtBidCount"
        Me.TxtBidCount.ReadOnly = True
        Me.TxtBidCount.Size = New System.Drawing.Size(83, 24)
        Me.TxtBidCount.TabIndex = 69
        '
        'TxtCategory
        '
        Me.TxtCategory.BackColor = System.Drawing.Color.White
        Me.TxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategory.Location = New System.Drawing.Point(154, 185)
        Me.TxtCategory.Name = "TxtCategory"
        Me.TxtCategory.ReadOnly = True
        Me.TxtCategory.Size = New System.Drawing.Size(92, 24)
        Me.TxtCategory.TabIndex = 70
        '
        'LblCategory
        '
        Me.LblCategory.Location = New System.Drawing.Point(15, 189)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(93, 28)
        Me.LblCategory.TabIndex = 54
        Me.LblCategory.Text = "Kat I:"
        '
        'TxtCategory2
        '
        Me.TxtCategory2.BackColor = System.Drawing.Color.White
        Me.TxtCategory2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategory2.Location = New System.Drawing.Point(496, 187)
        Me.TxtCategory2.Name = "TxtCategory2"
        Me.TxtCategory2.ReadOnly = True
        Me.TxtCategory2.Size = New System.Drawing.Size(89, 24)
        Me.TxtCategory2.TabIndex = 67
        '
        'LblCategory2
        '
        Me.LblCategory2.Location = New System.Drawing.Point(383, 187)
        Me.LblCategory2.Name = "LblCategory2"
        Me.LblCategory2.Size = New System.Drawing.Size(93, 28)
        Me.LblCategory2.TabIndex = 55
        Me.LblCategory2.Text = "Kat II:"
        '
        'TxtStartTime
        '
        Me.TxtStartTime.BackColor = System.Drawing.Color.White
        Me.TxtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStartTime.Location = New System.Drawing.Point(150, 27)
        Me.TxtStartTime.Name = "TxtStartTime"
        Me.TxtStartTime.ReadOnly = True
        Me.TxtStartTime.Size = New System.Drawing.Size(198, 24)
        Me.TxtStartTime.TabIndex = 68
        '
        'LblStartTime
        '
        Me.LblStartTime.Location = New System.Drawing.Point(12, 32)
        Me.LblStartTime.Name = "LblStartTime"
        Me.LblStartTime.Size = New System.Drawing.Size(92, 28)
        Me.LblStartTime.TabIndex = 52
        Me.LblStartTime.Text = "Start"
        '
        'TxtBuyItNowPrice
        '
        Me.TxtBuyItNowPrice.BackColor = System.Drawing.Color.White
        Me.TxtBuyItNowPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuyItNowPrice.Location = New System.Drawing.Point(496, 221)
        Me.TxtBuyItNowPrice.Name = "TxtBuyItNowPrice"
        Me.TxtBuyItNowPrice.ReadOnly = True
        Me.TxtBuyItNowPrice.Size = New System.Drawing.Size(128, 24)
        Me.TxtBuyItNowPrice.TabIndex = 71
        '
        'LblBuyItNowPrice
        '
        Me.LblBuyItNowPrice.Location = New System.Drawing.Point(383, 223)
        Me.LblBuyItNowPrice.Name = "LblBuyItNowPrice"
        Me.LblBuyItNowPrice.Size = New System.Drawing.Size(93, 28)
        Me.LblBuyItNowPrice.TabIndex = 53
        Me.LblBuyItNowPrice.Text = "BIN Price:"
        '
        'LblQuantity
        '
        Me.LblQuantity.Location = New System.Drawing.Point(15, 253)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(93, 28)
        Me.LblQuantity.TabIndex = 58
        Me.LblQuantity.Text = "Menge"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.White
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Location = New System.Drawing.Point(154, 250)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.ReadOnly = True
        Me.TxtQuantity.Size = New System.Drawing.Size(49, 24)
        Me.TxtQuantity.TabIndex = 64
        '
        'LblQuantitySold
        '
        Me.LblQuantitySold.Location = New System.Drawing.Point(383, 259)
        Me.LblQuantitySold.Name = "LblQuantitySold"
        Me.LblQuantitySold.Size = New System.Drawing.Size(124, 25)
        Me.LblQuantitySold.TabIndex = 59
        Me.LblQuantitySold.Text = "Menge:"
        '
        'LblEndTime
        '
        Me.LblEndTime.Location = New System.Drawing.Point(379, 32)
        Me.LblEndTime.Name = "LblEndTime"
        Me.LblEndTime.Size = New System.Drawing.Size(93, 28)
        Me.LblEndTime.TabIndex = 56
        Me.LblEndTime.Text = "Ende"
        '
        'TxtHighBidder
        '
        Me.TxtHighBidder.BackColor = System.Drawing.Color.White
        Me.TxtHighBidder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHighBidder.Location = New System.Drawing.Point(150, 60)
        Me.TxtHighBidder.Name = "TxtHighBidder"
        Me.TxtHighBidder.ReadOnly = True
        Me.TxtHighBidder.Size = New System.Drawing.Size(198, 24)
        Me.TxtHighBidder.TabIndex = 66
        '
        'LblHighBidder
        '
        Me.LblHighBidder.Location = New System.Drawing.Point(12, 64)
        Me.LblHighBidder.Name = "LblHighBidder"
        Me.LblHighBidder.Size = New System.Drawing.Size(123, 26)
        Me.LblHighBidder.TabIndex = 57
        Me.LblHighBidder.Text = "Mitglied"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.webBildvorschau)
        Me.GroupBox1.Location = New System.Drawing.Point(732, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 470)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bildervorschau"
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.Location = New System.Drawing.Point(23, 24)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(0, 25)
        Me.lblTitel.TabIndex = 110
        '
        'txteBayID
        '
        Me.txteBayID.Location = New System.Drawing.Point(1158, 38)
        Me.txteBayID.Name = "txteBayID"
        Me.txteBayID.Size = New System.Drawing.Size(129, 24)
        Me.txteBayID.TabIndex = 111
        Me.txteBayID.Visible = False
        '
        'FormGetItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(9, 17)
        Me.ClientSize = New System.Drawing.Size(1324, 544)
        Me.Controls.Add(Me.txteBayID)
        Me.Controls.Add(Me.lblTitel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.btnZurück)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.BtnGetItem)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FormGetItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EiSo - eBay Artikel Details anzeigen"
        Me.GrpResult.ResumeLayout(False)
        Me.GrpResult.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext
    Private fetchedItem As ItemType
    Private shippmentItem As ShippingDetailsType
    Public lvwDataInput As ListView
    Private rtb As RichTextBox

    '############################################################################################
    '# >> Internationale Versandkosten 
    '############################################################################################
    Public Function getShippment(ByVal itemId As String, ByVal strMenge As String, ByVal ZIP As String, ByVal country As CountryCodeType) As String

        Try
            Context = clseBayAPI.setAPIContext()

            Dim Apicall As GetItemShippingCall = New GetItemShippingCall(Context)
            Apicall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll)

            shippmentItem = Apicall.GetItemShipping(itemId, ZIP, country)

            Dim shippment() As eBay.Service.Core.Soap.InternationalShippingServiceOptionsType
            shippment = shippmentItem.InternationalShippingServiceOption.ToArray

            If shippment.Length > 0 Then
                Return shippment(0).ShippingServiceCost.Value
                'MsgBox(shippment(0).ShippingServiceCost.Value)
            Else
                Return 0
            End If


            'shippmentItem.ShippingServiceOptions.ShippingServiceCost()

            Return True
        Catch ex As Exception
            setLookGUI(True)
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    '############################################
    '# >> Abfrage der Artikel Infos 
    '############################################
    Public Function getItemInfo() As Boolean
        Try
            BtnGetItem.Enabled = False


            TxtCategory.Text = ""
            TxtCategory2.Text = ""
            TxtCurrentPrice.Text = ""
            TxtBuyItNowPrice.Text = ""
            TxtBidCount.Text = ""
            TxtHighBidder.Text = ""
            TxtStartTime.Text = ""
            TxtEndTime.Text = ""
            TxtQuantity.Text = ""
            TxtQuantitySold.Text = ""

            Context = clseBayAPI.setAPIContext()

            Dim Apicall As GetItemCall = New GetItemCall(Context)
            Apicall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll)
            fetchedItem = Apicall.GetItem(txteBayID.Text)

            ' Set values from the item returned
            lblTitel.Text = fetchedItem.Title
            TxtCategory.Text = fetchedItem.PrimaryCategory.CategoryID

            If fetchedItem.SecondaryCategory Is Nothing Then
                TxtCategory2.Text = ""
            Else
                TxtCategory2.Text = fetchedItem.SecondaryCategory.CategoryID
            End If

            Me.Text = "YABE - eBay Artikel Details anzeigen - " & fetchedItem.Title

            TxtCurrentPrice.Text = fetchedItem.SellingStatus.CurrentPrice.Value.ToString()
            TxtBuyItNowPrice.Text = fetchedItem.BuyItNowPrice.Value.ToString()
            TxtBidCount.Text = fetchedItem.SellingStatus.BidCount.ToString()

            If fetchedItem.SellingStatus.HighBidder Is Nothing Then
                TxtHighBidder.Text = "N/A"
                txtVersand_International.Text = "N/A"
            Else
                TxtHighBidder.Text = fetchedItem.SellingStatus.HighBidder.UserID
                txtVersand_International.Text = getShippment(fetchedItem.ItemID, "26125", "26125", fetchedItem.SellingStatus.HighBidder.RegistrationAddress.Country)

            End If


            TxtStartTime.Text = fetchedItem.ListingDetails.StartTime.ToString()

            TxtEndTime.Text = fetchedItem.ListingDetails.EndTime.ToString()

            TxtQuantity.Text = fetchedItem.Quantity.ToString()

            '# Besucherzähler 
            'MsgBox(fetchedItem.HitCount.ToString)

            'fetchedItem.SellingStatus.
 
            '# DAUER 
            'MsgBox(fetchedItem.ListingDuration.ToString)
            Dim shippment() As eBay.Service.Core.Soap.ShippingServiceOptionsType
            shippment = fetchedItem.ShippingDetails.ShippingServiceOptions.ToArray()


            If shippment.Length > 0 Then
                txtVersand.Text = shippment(0).ShippingServiceCost.Value   '"---" 'item.ShippingDetails.DefaultShippingCost.Value 
                txtVersandart.Text = shippment(0).ShippingService
            End If

            TxtQuantitySold.Text = fetchedItem.SellingStatus.QuantitySold.ToString()

            TxtBestOfferCount.Text = ""
            TxtBestOfferEnabled.Text = ""
            If Not fetchedItem.BestOfferDetails Is Nothing Then
                TxtBestOfferCount.Text = fetchedItem.BestOfferDetails.BestOfferCount.ToString()
                TxtBestOfferEnabled.Text = fetchedItem.BestOfferDetails.BestOfferEnabled.ToString()
            End If

            If Not fetchedItem.PayPalEmailAddress Is Nothing Then
                TxtPayPalEmailAddress.Text = fetchedItem.PayPalEmailAddress.ToString()
            End If

            'TxtPictureURL.Text = ""            
            If Not fetchedItem.PictureDetails Is Nothing Then
                Dim PictureURLs As StringCollection = fetchedItem.PictureDetails.PictureURL

                If Not PictureURLs Is Nothing Then
                    Dim PictureURL As String = ""
                    Dim i As Integer = 0
                    Dim iMax As Integer = PictureURLs.Count - 1
                    For i = 0 To iMax
                        PictureURL += PictureURLs(i) + ","
                    Next

                    'TxtPictureURL.Text = PictureURL
                    webBildvorschau.Navigate(PictureURL)
                End If
 

            End If

            BtnGetItem.Enabled = True

        Catch ex As Exception
            'Me.txtErrors.Text = ex
            ' MsgBox(ex)

        End Try

    End Function

    Private Function setLookGUI(ByVal bModus As Boolean) As Boolean
        Try
            txteBayID.Enabled = bModus
            BtnGetItem.Enabled = bModus
            TxtStartTime.Enabled = bModus
            TxtEndTime.Enabled = bModus
            TxtHighBidder.Enabled = bModus
            TxtBidCount.Enabled = bModus            
            TxtCategory.Enabled = bModus
            TxtCategory2.Enabled = bModus
            TxtQuantity.Enabled = bModus
            TxtQuantitySold.Enabled = bModus
            TxtBestOfferEnabled.Enabled = bModus
            TxtBestOfferCount.Enabled = bModus
            TxtPayPalEmailAddress.Enabled = bModus
            txtVersand.Enabled = bModus
            txtVersand_International.Enabled = bModus
            txtVersandart.Enabled = bModus

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setLookGUI")
            Return False
        End Try
    End Function

    Private Sub BtnGetItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetItem.Click

        '# Zurücksetzten 
        TxtStartTime.Text = ""
        TxtEndTime.Text = ""
        TxtHighBidder.Text = ""
        TxtBidCount.Text = ""
        TxtCategory.Text = ""
        TxtCategory2.Text = ""
        TxtQuantity.Text = ""
        TxtQuantitySold.Text = ""
        TxtBestOfferEnabled.Text = ""
        TxtBestOfferCount.Text = ""
        TxtPayPalEmailAddress.Text = ""        
        txtVersand.Text = ""
        txtVersand_International.Text = ""
        txtVersandart.Text = ""

        Call setLookGUI(False)
        Call getItemInfo()
        Call setLookGUI(True)

    End Sub

    Private Sub FormGetItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If

        If e.KeyCode = Keys.Left Then
            btnZurück.PerformClick()
        End If

        If e.KeyCode = Keys.Right Then
            btnVor.PerformClick()
        End If
    End Sub


    Private Sub FormGetItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txteBayID.Focus()
        If txteBayID.Text.Length > 0 Then
            Dim iAnzahl As Integer
            iAnzahl = lvwDataInput.SelectedItems(0).Index

            If iAnzahl = 0 Then
                btnZurück.Enabled = False
        
            End If

            If iAnzahl = lvwDataInput.Items.Count - 1 Then
                btnVor.Enabled = False
            End If
        End If

        Application.DoEvents()

        BtnGetItem.PerformClick()


    End Sub

    Public Function getItem() As ItemType
        Return fetchedItem
    End Function


    Private Sub btnZurück_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZurück.Click
        Dim iAnzahl As Integer = 0

        If frmMain.frmManage.lvwEiSoCockpit.SelectedItems.Count > 0 Then

            Call setLvwView_blättern(lvwBlättern_modus.back, lvwDataInput, btnVor, btnZurück, txteBayID)
            BtnGetItem.PerformClick()
        End If
    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then

            Call setLvwView_blättern(lvwBlättern_modus.vor, lvwDataInput, btnVor, btnZurück, txteBayID)
            BtnGetItem.PerformClick()
        End If
    End Sub

    Private Sub TxtCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCategory.TextChanged

    End Sub
End Class

