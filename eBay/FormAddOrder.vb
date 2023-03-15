Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util





Public Class FormAddOrder
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



		Friend WithEvents GrpResult As System.Windows.Forms.GroupBox 

		Friend WithEvents BtnAddOrder As System.Windows.Forms.Button 




    Friend WithEvents CboShipSvc As System.Windows.Forms.ComboBox

    Friend WithEvents LblShipSvc As System.Windows.Forms.Label







    Friend WithEvents TxtShipCost As System.Windows.Forms.TextBox

    Friend WithEvents LblShipCost As System.Windows.Forms.Label

    Friend WithEvents TxtPaymentInstructions As System.Windows.Forms.TextBox

    Friend WithEvents LblPaymentInstructions As System.Windows.Forms.Label

    Friend WithEvents LblOrderId As System.Windows.Forms.Label

    Friend WithEvents TxtOrderId As System.Windows.Forms.TextBox

    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lvwIDs As System.Windows.Forms.ListView
    Friend WithEvents coleBayID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTransaktion As System.Windows.Forms.ColumnHeader
    Friend WithEvents colBeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbleBayVersandkosten As System.Windows.Forms.LinkLabel

    Friend WithEvents LblTotal As System.Windows.Forms.Label





    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.GrpResult = New System.Windows.Forms.GroupBox()
        Me.LblOrderId = New System.Windows.Forms.Label()
        Me.TxtOrderId = New System.Windows.Forms.TextBox()
        Me.CboShipSvc = New System.Windows.Forms.ComboBox()
        Me.LblShipSvc = New System.Windows.Forms.Label()
        Me.TxtShipCost = New System.Windows.Forms.TextBox()
        Me.LblShipCost = New System.Windows.Forms.Label()
        Me.TxtPaymentInstructions = New System.Windows.Forms.TextBox()
        Me.LblPaymentInstructions = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.lvwIDs = New System.Windows.Forms.ListView()
        Me.coleBayID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTransaktion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBeschreibung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbleBayVersandkosten = New System.Windows.Forms.LinkLabel()
        Me.GrpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddOrder.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddOrder.Image = Global.YabE.My.Resources.Resources._19
        Me.BtnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddOrder.Location = New System.Drawing.Point(128, 336)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(401, 32)
        Me.BtnAddOrder.TabIndex = 56
        Me.BtnAddOrder.Text = "Bestellung hinzufügen"
        Me.BtnAddOrder.UseVisualStyleBackColor = False
        '
        'GrpResult
        '
        Me.GrpResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpResult.Controls.Add(Me.LblOrderId)
        Me.GrpResult.Controls.Add(Me.TxtOrderId)
        Me.GrpResult.Location = New System.Drawing.Point(19, 379)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(508, 0)
        Me.GrpResult.TabIndex = 25
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'LblOrderId
        '
        Me.LblOrderId.Location = New System.Drawing.Point(21, 29)
        Me.LblOrderId.Name = "LblOrderId"
        Me.LblOrderId.Size = New System.Drawing.Size(107, 28)
        Me.LblOrderId.TabIndex = 42
        Me.LblOrderId.Text = "Order Id:"
        '
        'TxtOrderId
        '
        Me.TxtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOrderId.Location = New System.Drawing.Point(128, 29)
        Me.TxtOrderId.Name = "TxtOrderId"
        Me.TxtOrderId.ReadOnly = True
        Me.TxtOrderId.Size = New System.Drawing.Size(356, 24)
        Me.TxtOrderId.TabIndex = 41
        '
        'CboShipSvc
        '
        Me.CboShipSvc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboShipSvc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboShipSvc.Location = New System.Drawing.Point(128, 102)
        Me.CboShipSvc.Name = "CboShipSvc"
        Me.CboShipSvc.Size = New System.Drawing.Size(399, 25)
        Me.CboShipSvc.TabIndex = 55
        '
        'LblShipSvc
        '
        Me.LblShipSvc.Location = New System.Drawing.Point(21, 102)
        Me.LblShipSvc.Name = "LblShipSvc"
        Me.LblShipSvc.Size = New System.Drawing.Size(107, 22)
        Me.LblShipSvc.TabIndex = 54
        Me.LblShipSvc.Text = "Versandart"
        '
        'TxtShipCost
        '
        Me.TxtShipCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtShipCost.Location = New System.Drawing.Point(128, 147)
        Me.TxtShipCost.Name = "TxtShipCost"
        Me.TxtShipCost.Size = New System.Drawing.Size(107, 24)
        Me.TxtShipCost.TabIndex = 65
        '
        'LblShipCost
        '
        Me.LblShipCost.Location = New System.Drawing.Point(-3, 147)
        Me.LblShipCost.Name = "LblShipCost"
        Me.LblShipCost.Size = New System.Drawing.Size(126, 28)
        Me.LblShipCost.TabIndex = 66
        Me.LblShipCost.Text = "Versandkosten"
        '
        'TxtPaymentInstructions
        '
        Me.TxtPaymentInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPaymentInstructions.Location = New System.Drawing.Point(128, 182)
        Me.TxtPaymentInstructions.Multiline = True
        Me.TxtPaymentInstructions.Name = "TxtPaymentInstructions"
        Me.TxtPaymentInstructions.Size = New System.Drawing.Size(401, 101)
        Me.TxtPaymentInstructions.TabIndex = 67
        '
        'LblPaymentInstructions
        '
        Me.LblPaymentInstructions.Location = New System.Drawing.Point(13, 183)
        Me.LblPaymentInstructions.Name = "LblPaymentInstructions"
        Me.LblPaymentInstructions.Size = New System.Drawing.Size(115, 28)
        Me.LblPaymentInstructions.TabIndex = 68
        Me.LblPaymentInstructions.Text = "Anweisungen"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Location = New System.Drawing.Point(128, 294)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(107, 24)
        Me.TxtTotal.TabIndex = 69
        '
        'LblTotal
        '
        Me.LblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTotal.Location = New System.Drawing.Point(13, 294)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(107, 0)
        Me.LblTotal.TabIndex = 70
        Me.LblTotal.Text = "Summe:"
        '
        'lvwIDs
        '
        Me.lvwIDs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.coleBayID, Me.colTransaktion, Me.colBeschreibung})
        Me.lvwIDs.Location = New System.Drawing.Point(25, 5)
        Me.lvwIDs.Name = "lvwIDs"
        Me.lvwIDs.Size = New System.Drawing.Size(504, 85)
        Me.lvwIDs.TabIndex = 71
        Me.lvwIDs.UseCompatibleStateImageBehavior = False
        Me.lvwIDs.View = System.Windows.Forms.View.Details
        '
        'coleBayID
        '
        Me.coleBayID.Text = "eBayID"
        Me.coleBayID.Width = 78
        '
        'colTransaktion
        '
        Me.colTransaktion.Text = "TransID"
        Me.colTransaktion.Width = 54
        '
        'colBeschreibung
        '
        Me.colBeschreibung.Text = "eBay Artikelbeschreibung"
        Me.colBeschreibung.Width = 222
        '
        'lbleBayVersandkosten
        '
        Me.lbleBayVersandkosten.AutoSize = True
        Me.lbleBayVersandkosten.Location = New System.Drawing.Point(360, 147)
        Me.lbleBayVersandkosten.Name = "lbleBayVersandkosten"
        Me.lbleBayVersandkosten.Size = New System.Drawing.Size(153, 17)
        Me.lbleBayVersandkosten.TabIndex = 72
        Me.lbleBayVersandkosten.TabStop = True
        Me.lbleBayVersandkosten.Text = "eBay Versandkosten"
        '
        'FormAddOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 17)
        Me.ClientSize = New System.Drawing.Size(552, 389)
        Me.Controls.Add(Me.lbleBayVersandkosten)
        Me.Controls.Add(Me.lvwIDs)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.TxtPaymentInstructions)
        Me.Controls.Add(Me.LblPaymentInstructions)
        Me.Controls.Add(Me.TxtShipCost)
        Me.Controls.Add(Me.LblShipCost)
        Me.Controls.Add(Me.CboShipSvc)
        Me.Controls.Add(Me.LblShipSvc)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnAddOrder)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormAddOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YABE -> eBay Versandkostenerfassung"
        Me.GrpResult.ResumeLayout(False)
        Me.GrpResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public strVersand As String
    Public strKosten As String
    Public strPaymentText As String
    Public lvwDataInput As ListView

    Public Context As ApiContext

    Private Sub FrmAddOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Dim shpsvcs As Type = GetType(ShippingServiceCodeType)
        Dim svc As String

        TxtShipCost.Text = strVersand
        TxtTotal.Text = strKosten
        TxtPaymentInstructions.Text = strPaymentText

        For Each svc In [Enum].GetNames(shpsvcs)
            If svc <> "CustomCode" Then

                If svc.Contains("DE_") = True Then
                    CboShipSvc.Items.Add(svc)
                End If

            End If
        Next svc
        CboShipSvc.SelectedIndex = 0

        '# Alle benötigten Einträge hinzufügen
        For icount As Integer = 0 To lvwDataInput.Items.Count - 1
            Dim lvwItem As New ListViewItem
            lvwItem.Text = lvwDataInput.Items(icount).Text
            lvwItem.SubItems.Add(0)
            lvwItem.SubItems.Add(lvwDataInput.Items(icount).SubItems(1).Text)

            lvwIDs.Items.Add(lvwItem)
        Next

    End Sub

    Private Sub BtnAddOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddOrder.Click
        Dim strAryeBayID() As String
        Dim strAryTransID() As String

        ReDim strAryeBayID(lvwIDs.Items.Count - 1)
        ReDim strAryTransID(lvwIDs.Items.Count - 1)

        For iCount As Integer = 0 To lvwIDs.Items.Count - 1
            strAryeBayID(iCount) = lvwIDs.Items(iCount).Text
            strAryTransID(iCount) = lvwIDs.Items(iCount).SubItems(1).Text
        Next

        TxtOrderId.Text = clseBayAPI.setNewOrder(strAryeBayID, strAryTransID, TxtShipCost.Text, TxtTotal.Text, TxtPaymentInstructions.Text, CboShipSvc.Text)


    End Sub

    Private Sub CboShipSvc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboShipSvc.SelectedIndexChanged

    End Sub

    Private Sub lbleBayVersandkosten_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbleBayVersandkosten.LinkClicked

        If lvwIDs.Items.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://payments.ebay.de/ws/eBayISAPI.dll?UnifiedCheckoutSellerUpdateDetails&itemId=" & lvwIDs.Items(0).Text & "&transId=0&buyerid=0&ssPageName=ADME:L:EOISSA:DE:1156"
            ExterneAnwendung.Start()

        End If

    End Sub
End Class


