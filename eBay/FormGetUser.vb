Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FrmGetUser
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



    Friend WithEvents BtnGetUser As System.Windows.Forms.Button


    Friend WithEvents GrpResult As System.Windows.Forms.GroupBox






















    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents tabUserDetails As System.Windows.Forms.TabControl
    Friend WithEvents tab_bassisinformation As System.Windows.Forms.TabPage
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPaypalAccount As System.Windows.Forms.TextBox
    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox
    Friend WithEvents LblItemId As System.Windows.Forms.Label
    Friend WithEvents lblPaypal As System.Windows.Forms.Label
    Friend WithEvents TxtUserId As System.Windows.Forms.TextBox
    Friend WithEvents TxtVerified As System.Windows.Forms.TextBox
    Friend WithEvents LblUserId As System.Windows.Forms.Label
    Friend WithEvents LblVerified As System.Windows.Forms.Label
    Friend WithEvents TxtStar As System.Windows.Forms.TextBox
    Friend WithEvents lblRatingPercent As System.Windows.Forms.Label
    Friend WithEvents TxtSite As System.Windows.Forms.TextBox
    Friend WithEvents LblSite As System.Windows.Forms.Label
    Friend WithEvents TxtRegDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtFeedBackScore As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents LblRegDate As System.Windows.Forms.Label
    Friend WithEvents LblFeedBackScore As System.Windows.Forms.Label
    Friend WithEvents tab_details As System.Windows.Forms.TabPage
    Friend WithEvents txtPaypalConfirmed As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNew As System.Windows.Forms.TextBox
    Friend WithEvents LblNew As System.Windows.Forms.Label
    Friend WithEvents TxtChanged As System.Windows.Forms.TextBox
    Friend WithEvents LblLastChanged As System.Windows.Forms.Label
    Friend WithEvents TxtStoreUrl As System.Windows.Forms.TextBox
    Friend WithEvents LblStoreUrl As System.Windows.Forms.Label
    Friend WithEvents TxtSellerLevel As System.Windows.Forms.TextBox
    Friend WithEvents LblSellerLevel As System.Windows.Forms.Label
    Friend WithEvents txtOrtPLZ As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStraﬂe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLand As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvwBestellverlauf As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayBeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents bids As System.Windows.Forms.ColumnHeader
    Friend WithEvents status As System.Windows.Forms.ColumnHeader
    Friend WithEvents yabe_auktionsende As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents lblPreis As System.Windows.Forms.Label





    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGetUser))
        Me.BtnGetUser = New System.Windows.Forms.Button
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.tabUserDetails = New System.Windows.Forms.TabControl
        Me.tab_bassisinformation = New System.Windows.Forms.TabPage
        Me.txtLand = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtStraﬂe = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOrtPLZ = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPaypalAccount = New System.Windows.Forms.TextBox
        Me.TxtItemId = New System.Windows.Forms.TextBox
        Me.LblItemId = New System.Windows.Forms.Label
        Me.lblPaypal = New System.Windows.Forms.Label
        Me.TxtUserId = New System.Windows.Forms.TextBox
        Me.TxtVerified = New System.Windows.Forms.TextBox
        Me.LblUserId = New System.Windows.Forms.Label
        Me.LblVerified = New System.Windows.Forms.Label
        Me.TxtStar = New System.Windows.Forms.TextBox
        Me.lblRatingPercent = New System.Windows.Forms.Label
        Me.TxtSite = New System.Windows.Forms.TextBox
        Me.LblSite = New System.Windows.Forms.Label
        Me.TxtRegDate = New System.Windows.Forms.TextBox
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.TxtFeedBackScore = New System.Windows.Forms.TextBox
        Me.LblEmail = New System.Windows.Forms.Label
        Me.LblRegDate = New System.Windows.Forms.Label
        Me.LblFeedBackScore = New System.Windows.Forms.Label
        Me.tab_details = New System.Windows.Forms.TabPage
        Me.txtPaypalConfirmed = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNew = New System.Windows.Forms.TextBox
        Me.LblNew = New System.Windows.Forms.Label
        Me.TxtChanged = New System.Windows.Forms.TextBox
        Me.LblLastChanged = New System.Windows.Forms.Label
        Me.TxtStoreUrl = New System.Windows.Forms.TextBox
        Me.LblStoreUrl = New System.Windows.Forms.Label
        Me.TxtSellerLevel = New System.Windows.Forms.TextBox
        Me.LblSellerLevel = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvwBestellverlauf = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.eBayBeschreibung = New System.Windows.Forms.ColumnHeader
        Me.Preis = New System.Windows.Forms.ColumnHeader
        Me.bids = New System.Windows.Forms.ColumnHeader
        Me.status = New System.Windows.Forms.ColumnHeader
        Me.yabe_auktionsende = New System.Windows.Forms.ColumnHeader
        Me.lblPreis = New System.Windows.Forms.Label
        Me.btnVor = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.lblTitel = New System.Windows.Forms.Label
        Me.GrpResult.SuspendLayout()
        Me.tabUserDetails.SuspendLayout()
        Me.tab_bassisinformation.SuspendLayout()
        Me.tab_details.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGetUser
        '
        Me.BtnGetUser.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetUser.Image = Global.YabE.My.Resources.Resources.send
        Me.BtnGetUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetUser.Location = New System.Drawing.Point(151, 617)
        Me.BtnGetUser.Name = "BtnGetUser"
        Me.BtnGetUser.Size = New System.Drawing.Size(450, 23)
        Me.BtnGetUser.TabIndex = 23
        Me.BtnGetUser.Text = "&Benutzerinformation abrufen"
        Me.BtnGetUser.UseVisualStyleBackColor = False
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.tabUserDetails)
        Me.GrpResult.Location = New System.Drawing.Point(12, 48)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(726, 287)
        Me.GrpResult.TabIndex = 25
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Allgemeine Daten"
        '
        'tabUserDetails
        '
        Me.tabUserDetails.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabUserDetails.Controls.Add(Me.tab_bassisinformation)
        Me.tabUserDetails.Controls.Add(Me.tab_details)
        Me.tabUserDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabUserDetails.Location = New System.Drawing.Point(3, 17)
        Me.tabUserDetails.Name = "tabUserDetails"
        Me.tabUserDetails.SelectedIndex = 0
        Me.tabUserDetails.Size = New System.Drawing.Size(720, 267)
        Me.tabUserDetails.TabIndex = 0
        '
        'tab_bassisinformation
        '
        Me.tab_bassisinformation.Controls.Add(Me.txtLand)
        Me.tab_bassisinformation.Controls.Add(Me.Label5)
        Me.tab_bassisinformation.Controls.Add(Me.txtStraﬂe)
        Me.tab_bassisinformation.Controls.Add(Me.Label4)
        Me.tab_bassisinformation.Controls.Add(Me.txtOrtPLZ)
        Me.tab_bassisinformation.Controls.Add(Me.Label3)
        Me.tab_bassisinformation.Controls.Add(Me.txtName)
        Me.tab_bassisinformation.Controls.Add(Me.Label2)
        Me.tab_bassisinformation.Controls.Add(Me.txtPaypalAccount)
        Me.tab_bassisinformation.Controls.Add(Me.TxtItemId)
        Me.tab_bassisinformation.Controls.Add(Me.LblItemId)
        Me.tab_bassisinformation.Controls.Add(Me.lblPaypal)
        Me.tab_bassisinformation.Controls.Add(Me.TxtUserId)
        Me.tab_bassisinformation.Controls.Add(Me.TxtVerified)
        Me.tab_bassisinformation.Controls.Add(Me.LblUserId)
        Me.tab_bassisinformation.Controls.Add(Me.LblVerified)
        Me.tab_bassisinformation.Controls.Add(Me.TxtStar)
        Me.tab_bassisinformation.Controls.Add(Me.lblRatingPercent)
        Me.tab_bassisinformation.Controls.Add(Me.TxtSite)
        Me.tab_bassisinformation.Controls.Add(Me.LblSite)
        Me.tab_bassisinformation.Controls.Add(Me.TxtRegDate)
        Me.tab_bassisinformation.Controls.Add(Me.TxtEmail)
        Me.tab_bassisinformation.Controls.Add(Me.TxtFeedBackScore)
        Me.tab_bassisinformation.Controls.Add(Me.LblEmail)
        Me.tab_bassisinformation.Controls.Add(Me.LblRegDate)
        Me.tab_bassisinformation.Controls.Add(Me.LblFeedBackScore)
        Me.tab_bassisinformation.Location = New System.Drawing.Point(4, 25)
        Me.tab_bassisinformation.Name = "tab_bassisinformation"
        Me.tab_bassisinformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_bassisinformation.Size = New System.Drawing.Size(712, 238)
        Me.tab_bassisinformation.TabIndex = 0
        Me.tab_bassisinformation.Text = "Bassisinformation"
        Me.tab_bassisinformation.UseVisualStyleBackColor = True
        '
        'txtLand
        '
        Me.txtLand.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLand.Location = New System.Drawing.Point(136, 123)
        Me.txtLand.Name = "txtLand"
        Me.txtLand.Size = New System.Drawing.Size(220, 21)
        Me.txtLand.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Land"
        '
        'txtStraﬂe
        '
        Me.txtStraﬂe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStraﬂe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStraﬂe.Location = New System.Drawing.Point(136, 70)
        Me.txtStraﬂe.Name = "txtStraﬂe"
        Me.txtStraﬂe.Size = New System.Drawing.Size(263, 21)
        Me.txtStraﬂe.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Straﬂe"
        '
        'txtOrtPLZ
        '
        Me.txtOrtPLZ.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrtPLZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrtPLZ.Location = New System.Drawing.Point(136, 96)
        Me.txtOrtPLZ.Name = "txtOrtPLZ"
        Me.txtOrtPLZ.Size = New System.Drawing.Size(220, 21)
        Me.txtOrtPLZ.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Ort + PLZ"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(136, 15)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 21)
        Me.txtName.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Name:"
        '
        'txtPaypalAccount
        '
        Me.txtPaypalAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPaypalAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaypalAccount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaypalAccount.Location = New System.Drawing.Point(136, 186)
        Me.txtPaypalAccount.Name = "txtPaypalAccount"
        Me.txtPaypalAccount.ReadOnly = True
        Me.txtPaypalAccount.Size = New System.Drawing.Size(142, 21)
        Me.txtPaypalAccount.TabIndex = 85
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(553, 211)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(146, 21)
        Me.TxtItemId.TabIndex = 67
        Me.TxtItemId.Visible = False
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(441, 211)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(64, 23)
        Me.LblItemId.TabIndex = 68
        Me.LblItemId.Text = "eBay ID"
        Me.LblItemId.Visible = False
        '
        'lblPaypal
        '
        Me.lblPaypal.Location = New System.Drawing.Point(24, 188)
        Me.lblPaypal.Name = "lblPaypal"
        Me.lblPaypal.Size = New System.Drawing.Size(127, 23)
        Me.lblPaypal.TabIndex = 87
        Me.lblPaypal.Text = "Paypal Account"
        '
        'TxtUserId
        '
        Me.TxtUserId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserId.Location = New System.Drawing.Point(136, 44)
        Me.TxtUserId.Name = "TxtUserId"
        Me.TxtUserId.Size = New System.Drawing.Size(220, 21)
        Me.TxtUserId.TabIndex = 65
        '
        'TxtVerified
        '
        Me.TxtVerified.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtVerified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVerified.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVerified.Location = New System.Drawing.Point(553, 70)
        Me.TxtVerified.Name = "TxtVerified"
        Me.TxtVerified.ReadOnly = True
        Me.TxtVerified.Size = New System.Drawing.Size(146, 21)
        Me.TxtVerified.TabIndex = 84
        '
        'LblUserId
        '
        Me.LblUserId.Location = New System.Drawing.Point(24, 48)
        Me.LblUserId.Name = "LblUserId"
        Me.LblUserId.Size = New System.Drawing.Size(109, 23)
        Me.LblUserId.TabIndex = 66
        Me.LblUserId.Text = "Mitgliedsname"
        '
        'LblVerified
        '
        Me.LblVerified.Location = New System.Drawing.Point(441, 73)
        Me.LblVerified.Name = "LblVerified"
        Me.LblVerified.Size = New System.Drawing.Size(112, 23)
        Me.LblVerified.TabIndex = 83
        Me.LblVerified.Text = "Verifiziert:"
        '
        'TxtStar
        '
        Me.TxtStar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtStar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStar.Location = New System.Drawing.Point(553, 124)
        Me.TxtStar.Name = "TxtStar"
        Me.TxtStar.ReadOnly = True
        Me.TxtStar.Size = New System.Drawing.Size(146, 21)
        Me.TxtStar.TabIndex = 81
        '
        'lblRatingPercent
        '
        Me.lblRatingPercent.Location = New System.Drawing.Point(441, 128)
        Me.lblRatingPercent.Name = "lblRatingPercent"
        Me.lblRatingPercent.Size = New System.Drawing.Size(112, 23)
        Me.lblRatingPercent.TabIndex = 82
        Me.lblRatingPercent.Text = "Bewert. in %"
        '
        'TxtSite
        '
        Me.TxtSite.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSite.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSite.Location = New System.Drawing.Point(553, 42)
        Me.TxtSite.Name = "TxtSite"
        Me.TxtSite.ReadOnly = True
        Me.TxtSite.Size = New System.Drawing.Size(146, 21)
        Me.TxtSite.TabIndex = 77
        '
        'LblSite
        '
        Me.LblSite.Location = New System.Drawing.Point(441, 44)
        Me.LblSite.Name = "LblSite"
        Me.LblSite.Size = New System.Drawing.Size(112, 23)
        Me.LblSite.TabIndex = 78
        Me.LblSite.Text = "Seite:"
        '
        'TxtRegDate
        '
        Me.TxtRegDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtRegDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRegDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegDate.Location = New System.Drawing.Point(136, 159)
        Me.TxtRegDate.Name = "TxtRegDate"
        Me.TxtRegDate.ReadOnly = True
        Me.TxtRegDate.Size = New System.Drawing.Size(142, 21)
        Me.TxtRegDate.TabIndex = 75
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(553, 15)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(146, 21)
        Me.TxtEmail.TabIndex = 70
        '
        'TxtFeedBackScore
        '
        Me.TxtFeedBackScore.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFeedBackScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFeedBackScore.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFeedBackScore.Location = New System.Drawing.Point(553, 97)
        Me.TxtFeedBackScore.Name = "TxtFeedBackScore"
        Me.TxtFeedBackScore.ReadOnly = True
        Me.TxtFeedBackScore.Size = New System.Drawing.Size(146, 21)
        Me.TxtFeedBackScore.TabIndex = 69
        '
        'LblEmail
        '
        Me.LblEmail.Location = New System.Drawing.Point(441, 17)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(112, 23)
        Me.LblEmail.TabIndex = 73
        Me.LblEmail.Text = "Email:"
        '
        'LblRegDate
        '
        Me.LblRegDate.Location = New System.Drawing.Point(24, 161)
        Me.LblRegDate.Name = "LblRegDate"
        Me.LblRegDate.Size = New System.Drawing.Size(112, 23)
        Me.LblRegDate.TabIndex = 76
        Me.LblRegDate.Text = "Registierung:"
        '
        'LblFeedBackScore
        '
        Me.LblFeedBackScore.Location = New System.Drawing.Point(441, 100)
        Me.LblFeedBackScore.Name = "LblFeedBackScore"
        Me.LblFeedBackScore.Size = New System.Drawing.Size(112, 23)
        Me.LblFeedBackScore.TabIndex = 74
        Me.LblFeedBackScore.Text = "Bewertung:"
        '
        'tab_details
        '
        Me.tab_details.Controls.Add(Me.txtPaypalConfirmed)
        Me.tab_details.Controls.Add(Me.Label1)
        Me.tab_details.Controls.Add(Me.TxtNew)
        Me.tab_details.Controls.Add(Me.LblNew)
        Me.tab_details.Controls.Add(Me.TxtChanged)
        Me.tab_details.Controls.Add(Me.LblLastChanged)
        Me.tab_details.Controls.Add(Me.TxtStoreUrl)
        Me.tab_details.Controls.Add(Me.LblStoreUrl)
        Me.tab_details.Controls.Add(Me.TxtSellerLevel)
        Me.tab_details.Controls.Add(Me.LblSellerLevel)
        Me.tab_details.Location = New System.Drawing.Point(4, 25)
        Me.tab_details.Name = "tab_details"
        Me.tab_details.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_details.Size = New System.Drawing.Size(712, 239)
        Me.tab_details.TabIndex = 1
        Me.tab_details.Text = "Benutzerdetails"
        Me.tab_details.UseVisualStyleBackColor = True
        '
        'txtPaypalConfirmed
        '
        Me.txtPaypalConfirmed.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPaypalConfirmed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaypalConfirmed.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaypalConfirmed.Location = New System.Drawing.Point(161, 119)
        Me.txtPaypalConfirmed.Name = "txtPaypalConfirmed"
        Me.txtPaypalConfirmed.ReadOnly = True
        Me.txtPaypalConfirmed.Size = New System.Drawing.Size(142, 21)
        Me.txtPaypalConfirmed.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 23)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Paypal best‰tigt"
        '
        'TxtNew
        '
        Me.TxtNew.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNew.Location = New System.Drawing.Point(161, 35)
        Me.TxtNew.Name = "TxtNew"
        Me.TxtNew.ReadOnly = True
        Me.TxtNew.Size = New System.Drawing.Size(141, 21)
        Me.TxtNew.TabIndex = 100
        '
        'LblNew
        '
        Me.LblNew.Location = New System.Drawing.Point(24, 37)
        Me.LblNew.Name = "LblNew"
        Me.LblNew.Size = New System.Drawing.Size(112, 23)
        Me.LblNew.TabIndex = 99
        Me.LblNew.Text = "Neuer Nutzer:"
        '
        'TxtChanged
        '
        Me.TxtChanged.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtChanged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtChanged.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChanged.Location = New System.Drawing.Point(161, 90)
        Me.TxtChanged.Name = "TxtChanged"
        Me.TxtChanged.ReadOnly = True
        Me.TxtChanged.Size = New System.Drawing.Size(141, 21)
        Me.TxtChanged.TabIndex = 97
        '
        'LblLastChanged
        '
        Me.LblLastChanged.Location = New System.Drawing.Point(24, 95)
        Me.LblLastChanged.Name = "LblLastChanged"
        Me.LblLastChanged.Size = New System.Drawing.Size(127, 23)
        Me.LblLastChanged.TabIndex = 98
        Me.LblLastChanged.Text = "ƒnderungsdatum"
        '
        'TxtStoreUrl
        '
        Me.TxtStoreUrl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtStoreUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStoreUrl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStoreUrl.Location = New System.Drawing.Point(161, 61)
        Me.TxtStoreUrl.Name = "TxtStoreUrl"
        Me.TxtStoreUrl.ReadOnly = True
        Me.TxtStoreUrl.Size = New System.Drawing.Size(407, 21)
        Me.TxtStoreUrl.TabIndex = 95
        '
        'LblStoreUrl
        '
        Me.LblStoreUrl.Location = New System.Drawing.Point(24, 63)
        Me.LblStoreUrl.Name = "LblStoreUrl"
        Me.LblStoreUrl.Size = New System.Drawing.Size(112, 23)
        Me.LblStoreUrl.TabIndex = 96
        Me.LblStoreUrl.Text = "Shop URL:"
        '
        'TxtSellerLevel
        '
        Me.TxtSellerLevel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtSellerLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSellerLevel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSellerLevel.Location = New System.Drawing.Point(161, 9)
        Me.TxtSellerLevel.Name = "TxtSellerLevel"
        Me.TxtSellerLevel.ReadOnly = True
        Me.TxtSellerLevel.Size = New System.Drawing.Size(141, 21)
        Me.TxtSellerLevel.TabIndex = 93
        '
        'LblSellerLevel
        '
        Me.LblSellerLevel.Location = New System.Drawing.Point(24, 11)
        Me.LblSellerLevel.Name = "LblSellerLevel"
        Me.LblSellerLevel.Size = New System.Drawing.Size(112, 23)
        Me.LblSellerLevel.TabIndex = 94
        Me.LblSellerLevel.Text = "Seller Level:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvwBestellverlauf)
        Me.GroupBox1.Controls.Add(Me.lblPreis)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 270)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Letzte K‰ufe"
        '
        'lvwBestellverlauf
        '
        Me.lvwBestellverlauf.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBestellverlauf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBestellverlauf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBestellverlauf.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.eBayBeschreibung, Me.Preis, Me.bids, Me.status, Me.yabe_auktionsende})
        Me.lvwBestellverlauf.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBestellverlauf.FullRowSelect = True
        Me.lvwBestellverlauf.GridLines = True
        Me.lvwBestellverlauf.Location = New System.Drawing.Point(7, 20)
        Me.lvwBestellverlauf.Name = "lvwBestellverlauf"
        Me.lvwBestellverlauf.Size = New System.Drawing.Size(716, 250)
        Me.lvwBestellverlauf.TabIndex = 5
        Me.lvwBestellverlauf.UseCompatibleStateImageBehavior = False
        Me.lvwBestellverlauf.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'eBayBeschreibung
        '
        Me.eBayBeschreibung.Text = "Beschreibung"
        Me.eBayBeschreibung.Width = 325
        '
        'Preis
        '
        Me.Preis.Text = "Endpreis"
        Me.Preis.Width = 79
        '
        'bids
        '
        Me.bids.Text = "Gebote"
        Me.bids.Width = 62
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 141
        '
        'yabe_auktionsende
        '
        Me.yabe_auktionsende.Text = "Auktionsende"
        Me.yabe_auktionsende.Width = 105
        '
        'lblPreis
        '
        Me.lblPreis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPreis.AutoSize = True
        Me.lblPreis.Location = New System.Drawing.Point(437, 247)
        Me.lblPreis.Name = "lblPreis"
        Me.lblPreis.Size = New System.Drawing.Size(0, 13)
        Me.lblPreis.TabIndex = 4
        '
        'btnVor
        '
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(623, 617)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(111, 23)
        Me.btnVor.TabIndex = 63
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(12, 617)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(111, 23)
        Me.btnBack.TabIndex = 62
        Me.btnBack.Text = "&Zur¸ck"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.Location = New System.Drawing.Point(14, 9)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(350, 25)
        Me.lblTitel.TabIndex = 64
        Me.lblTitel.Text = "eBay Benutzerinformationen"
        '
        'FrmGetUser
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.ClientSize = New System.Drawing.Size(746, 649)
        Me.Controls.Add(Me.lblTitel)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnGetUser)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGetUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YABE - eBay Benutzerinformation abrufen"
        Me.GrpResult.ResumeLayout(False)
        Me.tabUserDetails.ResumeLayout(False)
        Me.tab_bassisinformation.ResumeLayout(False)
        Me.tab_bassisinformation.PerformLayout()
        Me.tab_details.ResumeLayout(False)
        Me.tab_details.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext

    Private Sub BtnGetUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetUser.Click
        Dim aryList As New ArrayList
        Try
            setEnable_Disable(False)

            TxtEmail.Text = ""
            TxtFeedBackScore.Text = ""
            TxtRegDate.Text = ""
            TxtSellerLevel.Text = ""
            TxtSite.Text = ""
            TxtStar.Text = ""
            TxtStoreUrl.Text = ""
            TxtNew.Text = ""
            TxtVerified.Text = ""
            TxtChanged.Text = ""


            ' 1 - Email
            ' 2 - Feedback Score
            ' 3 - RegDate
            ' 4 - Seller Level 
            ' 5 - Site (de / en) 
            ' 6 - Positiv % 
            ' 7 - Store URL 
            ' 8 - Neuer Benutzer ? 
            ' 9 - Verified Account
            ' 10- Letzte ƒnderung 
            ' 11- Paypal Status 
            ' 12- Paypal best‰tigt
            '# Anschrift 
            ' 13- Name 
            ' 14- PLZ
            ' 15- Ort
            ' 16- Straﬂe
            ' 17- Land
            ' 18

            aryList = clseBayAPI.geteBayUserDetails(TxtItemId.Text, TxtUserId.Text)


            If aryList.Count > 0 Then

                TxtEmail.Text = aryList.Item(0).ToString
                TxtFeedBackScore.Text = aryList.Item(1).ToString
                '            TxtItemId.Text = aryList.Item(TxtItemId.Text).ToString
                txtLand.Text = aryList.Item(16).ToString
                txtName.Text = aryList.Item(12).ToString
                TxtNew.Text = aryList.Item(7).ToString
                txtOrtPLZ.Text = aryList.Item(13).ToString & " " & aryList.Item(14).ToString
                txtPaypalAccount.Text = aryList.Item(10).ToString
                txtPaypalConfirmed.Text = aryList.Item(11).ToString
                TxtRegDate.Text = aryList.Item(2).ToString
                TxtSellerLevel.Text = aryList.Item(3).ToString
                TxtSite.Text = aryList.Item(4).ToString
                TxtStar.Text = aryList.Item(17).ToString
                TxtStoreUrl.Text = aryList.Item(6).ToString
                txtStraﬂe.Text = aryList.Item(15).ToString
                TxtUserId.Text = TxtUserId.Text
                TxtVerified.Text = aryList.Item(11).ToString

                Call getBestellverlauf(aryList.Item(1).ToString)
                setBludauMediaLogbuch("eBay Benutzerdaten erfolgreich abgerufen:" & aryList.Item(12).ToString & "(" & TxtFeedBackScore.Text & ")" & System.Uri.EscapeDataString(TxtUserId.Text) & " PAYPAL EMAIL: " & txtPaypalAccount.Text & " IN EISO:" & My.Settings.yabe_paypal_emailusername, "EBAY_DATA")

            Else
                setBludauMediaLogbuch("eBay Benutzerdaten NICHT erfolgreich abgerufen!!!", "EBAY_DATA")
            End If


            'user.BuyerInfo.ShippingAddress.Country
            'user.BuyerInfo.ShippingAddress.Street
            'user.BuyerInfo.ShippingAddress.PostalCode 
            'user.BuyerInfo.ShippingAddress.CityName
            'lbPersonal.Text = user.BuyerInfo.ShippingAddress.AddressStatus & vbCrLf & user.BuyerInfo.ShippingAddress.Street.ToString & vbCrLf & user.BuyerInfo.ShippingAddress.Street.ToString & user.BuyerInfo.ShippingAddress.PostalCode.ToString & " " & user.BuyerInfo.ShippingAddress.CityName.ToString

            setEnable_Disable(True)
        Catch ex As Exception
            setBludauMediaLogbuch("FEHLER: eBay Benutzerdaten - " & ex.Message, "BUGREPORT")

            setEnable_Disable(True)
            '   MsgBox(ex)

        End Try

    End Sub

    '#####################################################
    '# >> Bestellverlauf 
    '#####################################################
    Public Function getBestellverlauf(ByVal stremail As String) As Boolean

        Try

            If stremail.Length > 0 Then

                clsDatenbank_modul.getListviewData(lvwBestellverlauf, "SELECT * FROM yabe_auction_list_history WHERE email ='" & stremail & "'", frmMain.frmManage.bilder_history)

                lblPreis.Text = clsDatenbank_modul.strOutPut & " Euro"
                clsDatenbank_modul.dblSumme = 0

            Else
                MsgBox("Keine ‹bergabe eines Benutzernamens")
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getBestellverlauf")
            Return False
        End Try

        Return True

    End Function

    Private Sub FrmGetUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmGetUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TxtUserId.Text.Length > 0 And TxtUserId.Text.Length > 0 Then
            BtnGetUser.PerformClick()
        End If

    End Sub

    Private Sub setEnable_Disable(ByVal bModus As Boolean)
        btnBack.Enabled = bModus
        btnVor.Enabled = bModus
        BtnGetUser.Enabled = bModus
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0
        Dim strUserName() As String

        If frmMain.frmManage.lvwEiSoCockpit.SelectedItems.Count > 0 Then

            setEnable_Disable(False)


            iAnzahl = frmMain.frmManage.lvwEiSoCockpit.SelectedItems(0).Index
            iAnzahl -= 1
            btnVor.Enabled = True

            If iAnzahl = -1 Then
                btnBack.Enabled = False
                Exit Sub
            End If


            frmMain.frmManage.lvwEiSoCockpit.Items(iAnzahl).Selected = True
            frmMain.frmManage.lvwEiSoCockpit.Items(iAnzahl).EnsureVisible()

            TxtItemId.Text = frmMain.frmManage.lvwEiSoCockpit.SelectedItems(0).Text
            strUserName = frmMain.frmManage.lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text.Split(" ")

            TxtUserId.Text = strUserName(0)

            If Not TxtUserId.Text = "---" Then
                BtnGetUser.PerformClick()
            End If

            setEnable_Disable(True)
        End If
    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0
        Dim strUserName() As String

        If frmMain.frmManage.lvwEiSoCockpit.SelectedItems.Count > 0 Then

            setEnable_Disable(False)

            iAnzahl = frmMain.frmManage.lvwEiSoCockpit.SelectedItems(0).Index
            iAnzahl += 1
            btnBack.Enabled = True

            If iAnzahl = frmMain.frmManage.lvwEiSoCockpit.Items.Count - 1 Then
                btnVor.Enabled = False
            End If

            frmMain.frmManage.lvwEiSoCockpit.Items(iAnzahl).Selected = True
            frmMain.frmManage.lvwEiSoCockpit.Items(iAnzahl).EnsureVisible()

            TxtItemId.Text = frmMain.frmManage.lvwEiSoCockpit.SelectedItems(0).Text

            strUserName = frmMain.frmManage.lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text.Split(" ")
            TxtUserId.Text = strUserName(0)

            ' Form wieder aktivieren 
            setEnable_Disable(True)

            ' Klicken aktivieren 
            If Not TxtUserId.Text = "---" Then
                BtnGetUser.PerformClick()
            End If

        End If
    End Sub
End Class