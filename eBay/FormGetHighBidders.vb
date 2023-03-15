Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FrmGetHighBidders
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



    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox

    Friend WithEvents LblItemId As System.Windows.Forms.Label


    Friend WithEvents BtnGetHighBidders As System.Windows.Forms.Button

    Friend WithEvents ClmAction As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmUser As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmCurrency As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmMaxBid As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmQuantiy As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmTimeBid As System.Windows.Forms.ColumnHeader

    Friend WithEvents GrpResults As System.Windows.Forms.GroupBox
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cmbBidModus As System.Windows.Forms.ComboBox

    Friend WithEvents LstHighBids As System.Windows.Forms.ListView



    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGetHighBidders))
        Me.TxtItemId = New System.Windows.Forms.TextBox()
        Me.LblItemId = New System.Windows.Forms.Label()
        Me.GrpResults = New System.Windows.Forms.GroupBox()
        Me.LstHighBids = New System.Windows.Forms.ListView()
        Me.ClmAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmCurrency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmMaxBid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmQuantiy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmTimeBid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.BtnGetHighBidders = New System.Windows.Forms.Button()
        Me.cmbBidModus = New System.Windows.Forms.ComboBox()
        Me.GrpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(402, 17)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(204, 24)
        Me.TxtItemId.TabIndex = 30
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(318, 21)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(82, 22)
        Me.LblItemId.TabIndex = 37
        Me.LblItemId.Text = "eBayID"
        '
        'GrpResults
        '
        Me.GrpResults.Controls.Add(Me.LstHighBids)
        Me.GrpResults.Location = New System.Drawing.Point(9, 66)
        Me.GrpResults.Name = "GrpResults"
        Me.GrpResults.Size = New System.Drawing.Size(870, 330)
        Me.GrpResults.TabIndex = 45
        Me.GrpResults.TabStop = False
        Me.GrpResults.Text = "Höchstbieter"
        '
        'LstHighBids
        '
        Me.LstHighBids.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstHighBids.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstHighBids.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmAction, Me.ClmUser, Me.ClmCurrency, Me.ClmMaxBid, Me.ClmQuantiy, Me.ClmTimeBid})
        Me.LstHighBids.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstHighBids.GridLines = True
        Me.LstHighBids.Location = New System.Drawing.Point(8, 24)
        Me.LstHighBids.Name = "LstHighBids"
        Me.LstHighBids.Size = New System.Drawing.Size(855, 299)
        Me.LstHighBids.TabIndex = 15
        Me.LstHighBids.UseCompatibleStateImageBehavior = False
        Me.LstHighBids.View = System.Windows.Forms.View.Details
        '
        'ClmAction
        '
        Me.ClmAction.Text = "Aktion"
        Me.ClmAction.Width = 86
        '
        'ClmUser
        '
        Me.ClmUser.Text = "Mitglied"
        Me.ClmUser.Width = 80
        '
        'ClmCurrency
        '
        Me.ClmCurrency.Text = "Währung"
        Me.ClmCurrency.Width = 95
        '
        'ClmMaxBid
        '
        Me.ClmMaxBid.Text = "Preis"
        '
        'ClmQuantiy
        '
        Me.ClmQuantiy.Text = "Menge"
        Me.ClmQuantiy.Width = 76
        '
        'ClmTimeBid
        '
        Me.ClmTimeBid.Text = "Gebotszeit"
        Me.ClmTimeBid.Width = 158
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(14, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 28)
        Me.btnBack.TabIndex = 60
        Me.btnBack.Text = "&Zurück"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnVor
        '
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(165, 15)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(142, 28)
        Me.btnVor.TabIndex = 61
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'BtnGetHighBidders
        '
        Me.BtnGetHighBidders.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetHighBidders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetHighBidders.Image = Global.YabE.My.Resources.Resources._24
        Me.BtnGetHighBidders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetHighBidders.Location = New System.Drawing.Point(624, 15)
        Me.BtnGetHighBidders.Name = "BtnGetHighBidders"
        Me.BtnGetHighBidders.Size = New System.Drawing.Size(248, 28)
        Me.BtnGetHighBidders.TabIndex = 46
        Me.BtnGetHighBidders.Text = "&eBay Bieter abrufen"
        Me.BtnGetHighBidders.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGetHighBidders.UseVisualStyleBackColor = False
        '
        'cmbBidModus
        '
        Me.cmbBidModus.FormattingEnabled = True
        Me.cmbBidModus.Location = New System.Drawing.Point(402, 47)
        Me.cmbBidModus.Name = "cmbBidModus"
        Me.cmbBidModus.Size = New System.Drawing.Size(204, 25)
        Me.cmbBidModus.TabIndex = 62
        '
        'FrmGetHighBidders
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(9, 17)
        Me.ClientSize = New System.Drawing.Size(696, 338)
        Me.Controls.Add(Me.cmbBidModus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.LblItemId)
        Me.Controls.Add(Me.BtnGetHighBidders)
        Me.Controls.Add(Me.TxtItemId)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.GrpResults)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGetHighBidders"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EiSo - Liste der Höchstbietenden"
        Me.GrpResults.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext
    Public lvwDataInput As ListView

    Private Sub BtnGetHighBidders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetHighBidders.Click

        Try

            LstHighBids.Items.Clear()

            Context = clseBayAPI.setAPIContext()
            Application.DoEvents()
            Dim apicall As GetAllBiddersCall = New GetAllBiddersCall(Context)
            Dim bids As OfferTypeCollection = apicall.GetAllBidders(TxtItemId.Text, [Enum].Parse(GetType(GetAllBiddersModeCodeType), cmbBidModus.SelectedItem.ToString()))


            Dim offer As OfferType

            For Each offer In bids
                Dim listparams(6) As String

                listparams(0) = offer.Action.ToString()
                listparams(1) = offer.User.UserID
                listparams(2) = offer.Currency.ToString()
                listparams(3) = offer.MaxBid.Value.ToString()
                listparams(4) = offer.Quantity.ToString()
                listparams(5) = offer.TimeBid.ToString()

                Dim vi As ListViewItem = New ListViewItem(listparams)

                Me.LstHighBids.Items.Add(vi)
            Next offer

        Catch ex As Exception
            MsgBox(ex)

        End Try

    End Sub

    Private Sub TxtItemId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemId.TextChanged

    End Sub

    Private Sub FrmGetHighBidders_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmGetHighBidders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim modes() As String = [Enum].GetNames(GetType(GetAllBiddersModeCodeType))
        Dim mode As String

        For Each mode In modes
            If mode <> "CustomCode" Then
                cmbBidModus.Items.Add(mode)

            End If
        Next mode

        cmbBidModus.SelectedIndex = 0

        '# Automodus
        If TxtItemId.Text.Length > 0 Then
            BtnGetHighBidders.PerformClick()
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        btnBack.Enabled = False

        Call setLvwView_blättern(lvwBlättern_modus.back, lvwDataInput, btnVor, btnBack, TxtItemId)

        BtnGetHighBidders.PerformClick()
        btnBack.Enabled = True
    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        btnVor.Enabled = False

        Call setLvwView_blättern(lvwBlättern_modus.vor, lvwDataInput, btnVor, btnBack, TxtItemId)

        BtnGetHighBidders.PerformClick()
        btnVor.Enabled = True
    End Sub
End Class

