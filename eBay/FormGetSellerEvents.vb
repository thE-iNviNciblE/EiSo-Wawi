Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FrmGetSellerEvents
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

    Friend WithEvents BtnGetSellerEvents As System.Windows.Forms.Button

    Friend WithEvents DatePickModTo As System.Windows.Forms.DateTimePicker

    Friend WithEvents DatePickModFrom As System.Windows.Forms.DateTimePicker

    Friend WithEvents LblModSep As System.Windows.Forms.Label

    Friend WithEvents OptModTime As System.Windows.Forms.RadioButton

    Friend WithEvents DatePickStartTo As System.Windows.Forms.DateTimePicker

    Friend WithEvents LblStartSep As System.Windows.Forms.Label

    Friend WithEvents OptStartTime As System.Windows.Forms.RadioButton

    Friend WithEvents DatePickEndTo As System.Windows.Forms.DateTimePicker

    Friend WithEvents LblEndSep As System.Windows.Forms.Label

    Friend WithEvents OptEndTime As System.Windows.Forms.RadioButton

    Friend WithEvents GrpResult As System.Windows.Forms.GroupBox

    Friend WithEvents txtUserID As System.Windows.Forms.TextBox

    Friend WithEvents ChkIncludeNew As System.Windows.Forms.CheckBox

    Friend WithEvents LblUserId As System.Windows.Forms.Label


    Friend WithEvents DatePickStartFrom As System.Windows.Forms.DateTimePicker

    Friend WithEvents DatePickEndFrom As System.Windows.Forms.DateTimePicker

    Friend WithEvents ClmItemId As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmTitle As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmPrice As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmSold As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmBids As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EBayArtikelAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents LstEvents As System.Windows.Forms.ListView


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGetSellerEvents))
        Me.GrpResult = New System.Windows.Forms.GroupBox()
        Me.LstEvents = New System.Windows.Forms.ListView()
        Me.ClmItemId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmSold = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmBids = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EBayArtikelAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnGetSellerEvents = New System.Windows.Forms.Button()
        Me.DatePickModTo = New System.Windows.Forms.DateTimePicker()
        Me.DatePickModFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblModSep = New System.Windows.Forms.Label()
        Me.OptModTime = New System.Windows.Forms.RadioButton()
        Me.DatePickStartTo = New System.Windows.Forms.DateTimePicker()
        Me.DatePickStartFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblStartSep = New System.Windows.Forms.Label()
        Me.OptStartTime = New System.Windows.Forms.RadioButton()
        Me.DatePickEndTo = New System.Windows.Forms.DateTimePicker()
        Me.DatePickEndFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblEndSep = New System.Windows.Forms.Label()
        Me.OptEndTime = New System.Windows.Forms.RadioButton()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.ChkIncludeNew = New System.Windows.Forms.CheckBox()
        Me.LblUserId = New System.Windows.Forms.Label()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.GrpResult.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpResult
        '
        Me.GrpResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpResult.Controls.Add(Me.LstEvents)
        Me.GrpResult.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpResult.Location = New System.Drawing.Point(11, 216)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(821, 399)
        Me.GrpResult.TabIndex = 24
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'LstEvents
        '
        Me.LstEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmItemId, Me.ClmTitle, Me.ClmPrice, Me.ClmSold, Me.ClmBids, Me.ClmStatus})
        Me.LstEvents.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LstEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstEvents.FullRowSelect = True
        Me.LstEvents.GridLines = True
        Me.LstEvents.HideSelection = False
        Me.LstEvents.Location = New System.Drawing.Point(3, 19)
        Me.LstEvents.MultiSelect = False
        Me.LstEvents.Name = "LstEvents"
        Me.LstEvents.Size = New System.Drawing.Size(815, 377)
        Me.LstEvents.TabIndex = 4
        Me.LstEvents.UseCompatibleStateImageBehavior = False
        Me.LstEvents.View = System.Windows.Forms.View.Details
        '
        'ClmItemId
        '
        Me.ClmItemId.Text = "ArtikelID"
        Me.ClmItemId.Width = 91
        '
        'ClmTitle
        '
        Me.ClmTitle.Text = "Titel"
        Me.ClmTitle.Width = 309
        '
        'ClmPrice
        '
        Me.ClmPrice.Text = "Preis"
        '
        'ClmSold
        '
        Me.ClmSold.Text = "Verkauft"
        Me.ClmSold.Width = 80
        '
        'ClmBids
        '
        Me.ClmBids.Text = "Gebote"
        Me.ClmBids.Width = 50
        '
        'ClmStatus
        '
        Me.ClmStatus.Text = "Status"
        Me.ClmStatus.Width = 76
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EBayArtikelAnzeigenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(222, 28)
        '
        'EBayArtikelAnzeigenToolStripMenuItem
        '
        Me.EBayArtikelAnzeigenToolStripMenuItem.Name = "EBayArtikelAnzeigenToolStripMenuItem"
        Me.EBayArtikelAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.EBayArtikelAnzeigenToolStripMenuItem.Text = "&eBay Artikel anzeigen"
        '
        'BtnGetSellerEvents
        '
        Me.BtnGetSellerEvents.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetSellerEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetSellerEvents.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetSellerEvents.Image = Global.YabE.My.Resources.Resources._24
        Me.BtnGetSellerEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetSellerEvents.Location = New System.Drawing.Point(221, 187)
        Me.BtnGetSellerEvents.Name = "BtnGetSellerEvents"
        Me.BtnGetSellerEvents.Size = New System.Drawing.Size(266, 28)
        Me.BtnGetSellerEvents.TabIndex = 23
        Me.BtnGetSellerEvents.Text = "eBay Verkaufsevents"
        Me.BtnGetSellerEvents.UseVisualStyleBackColor = False
        '
        'DatePickModTo
        '
        Me.DatePickModTo.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Me.DatePickModTo.Location = New System.Drawing.Point(561, 96)
        Me.DatePickModTo.Name = "DatePickModTo"
        Me.DatePickModTo.Size = New System.Drawing.Size(271, 23)
        Me.DatePickModTo.TabIndex = 61
        '
        'DatePickModFrom
        '
        Me.DatePickModFrom.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Me.DatePickModFrom.Location = New System.Drawing.Point(221, 96)
        Me.DatePickModFrom.Name = "DatePickModFrom"
        Me.DatePickModFrom.Size = New System.Drawing.Size(266, 23)
        Me.DatePickModFrom.TabIndex = 60
        '
        'LblModSep
        '
        Me.LblModSep.Location = New System.Drawing.Point(515, 96)
        Me.LblModSep.Name = "LblModSep"
        Me.LblModSep.Size = New System.Drawing.Size(23, 28)
        Me.LblModSep.TabIndex = 59
        Me.LblModSep.Text = " - "
        '
        'OptModTime
        '
        Me.OptModTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptModTime.Location = New System.Drawing.Point(24, 91)
        Me.OptModTime.Name = "OptModTime"
        Me.OptModTime.Size = New System.Drawing.Size(179, 30)
        Me.OptModTime.TabIndex = 58
        Me.OptModTime.Text = "Verändert zwischen:"
        '
        'DatePickStartTo
        '
        Me.DatePickStartTo.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Me.DatePickStartTo.Location = New System.Drawing.Point(561, 126)
        Me.DatePickStartTo.Name = "DatePickStartTo"
        Me.DatePickStartTo.Size = New System.Drawing.Size(271, 23)
        Me.DatePickStartTo.TabIndex = 65
        '
        'DatePickStartFrom
        '
        Me.DatePickStartFrom.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Me.DatePickStartFrom.Location = New System.Drawing.Point(221, 126)
        Me.DatePickStartFrom.Name = "DatePickStartFrom"
        Me.DatePickStartFrom.Size = New System.Drawing.Size(266, 23)
        Me.DatePickStartFrom.TabIndex = 64
        '
        'LblStartSep
        '
        Me.LblStartSep.Location = New System.Drawing.Point(515, 126)
        Me.LblStartSep.Name = "LblStartSep"
        Me.LblStartSep.Size = New System.Drawing.Size(23, 28)
        Me.LblStartSep.TabIndex = 63
        Me.LblStartSep.Text = " - "
        '
        'OptStartTime
        '
        Me.OptStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptStartTime.Location = New System.Drawing.Point(24, 121)
        Me.OptStartTime.Name = "OptStartTime"
        Me.OptStartTime.Size = New System.Drawing.Size(220, 29)
        Me.OptStartTime.TabIndex = 62
        Me.OptStartTime.Text = "Angefangen zwischen:"
        '
        'DatePickEndTo
        '
        Me.DatePickEndTo.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Me.DatePickEndTo.Location = New System.Drawing.Point(561, 155)
        Me.DatePickEndTo.Name = "DatePickEndTo"
        Me.DatePickEndTo.Size = New System.Drawing.Size(271, 23)
        Me.DatePickEndTo.TabIndex = 69
        '
        'DatePickEndFrom
        '
        Me.DatePickEndFrom.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Me.DatePickEndFrom.Location = New System.Drawing.Point(221, 155)
        Me.DatePickEndFrom.Name = "DatePickEndFrom"
        Me.DatePickEndFrom.Size = New System.Drawing.Size(266, 23)
        Me.DatePickEndFrom.TabIndex = 68
        '
        'LblEndSep
        '
        Me.LblEndSep.Location = New System.Drawing.Point(515, 155)
        Me.LblEndSep.Name = "LblEndSep"
        Me.LblEndSep.Size = New System.Drawing.Size(23, 28)
        Me.LblEndSep.TabIndex = 67
        Me.LblEndSep.Text = " - "
        '
        'OptEndTime
        '
        Me.OptEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptEndTime.Location = New System.Drawing.Point(24, 150)
        Me.OptEndTime.Name = "OptEndTime"
        Me.OptEndTime.Size = New System.Drawing.Size(179, 30)
        Me.OptEndTime.TabIndex = 66
        Me.OptEndTime.Text = "Beendet zwischen"
        '
        'txtUserID
        '
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Location = New System.Drawing.Point(221, 62)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(266, 23)
        Me.txtUserID.TabIndex = 70
        '
        'ChkIncludeNew
        '
        Me.ChkIncludeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkIncludeNew.Location = New System.Drawing.Point(561, 59)
        Me.ChkIncludeNew.Name = "ChkIncludeNew"
        Me.ChkIncludeNew.Size = New System.Drawing.Size(180, 30)
        Me.ChkIncludeNew.TabIndex = 71
        Me.ChkIncludeNew.Text = "Neue Artikel"
        '
        'LblUserId
        '
        Me.LblUserId.Location = New System.Drawing.Point(97, 64)
        Me.LblUserId.Name = "LblUserId"
        Me.LblUserId.Size = New System.Drawing.Size(177, 25)
        Me.LblUserId.TabIndex = 72
        Me.LblUserId.Text = "Benutzername"
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.Location = New System.Drawing.Point(27, 11)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(334, 32)
        Me.lblTitel.TabIndex = 73
        Me.lblTitel.Text = "eBay Verkaufsevents"
        '
        'FrmGetSellerEvents
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(844, 621)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblTitel)
        Me.Controls.Add(Me.ChkIncludeNew)
        Me.Controls.Add(Me.LblUserId)
        Me.Controls.Add(Me.DatePickEndTo)
        Me.Controls.Add(Me.DatePickEndFrom)
        Me.Controls.Add(Me.LblEndSep)
        Me.Controls.Add(Me.OptEndTime)
        Me.Controls.Add(Me.DatePickStartTo)
        Me.Controls.Add(Me.DatePickStartFrom)
        Me.Controls.Add(Me.LblStartSep)
        Me.Controls.Add(Me.OptStartTime)
        Me.Controls.Add(Me.DatePickModTo)
        Me.Controls.Add(Me.DatePickModFrom)
        Me.Controls.Add(Me.LblModSep)
        Me.Controls.Add(Me.OptModTime)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnGetSellerEvents)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGetSellerEvents"
        Me.Text = "EiSo - Verkaufsevents"
        Me.GrpResult.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext

    Private Sub FrmGetSellerList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtUserID.Text = My.Settings.ebay_username

        OptModTime.Checked = True
        Dim now As DateTime = DateTime.Now
        DatePickModTo.Value = now
        DatePickModFrom.Value = now.AddDays(-5)
        DatePickStartTo.Value = now
        DatePickStartFrom.Value = now.AddDays(-5)
        DatePickEndTo.Value = now.AddDays(5)
        DatePickEndFrom.Value = now

    End Sub

    Private Sub OptStartTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptStartTime.CheckedChanged

        If OptStartTime.Checked Then
            DatePickModFrom.Enabled = False
            DatePickModTo.Enabled = False
            DatePickStartFrom.Enabled = True
            DatePickStartTo.Enabled = True
            DatePickEndFrom.Enabled = False
            DatePickEndTo.Enabled = False
        End If

    End Sub

    Private Sub OptEndTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptEndTime.CheckedChanged

        If OptEndTime.Checked Then
            DatePickModFrom.Enabled = False
            DatePickModTo.Enabled = False
            DatePickStartFrom.Enabled = False
            DatePickStartTo.Enabled = False
            DatePickEndFrom.Enabled = True
            DatePickEndTo.Enabled = True
        End If

    End Sub

    Private Sub OptModTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptModTime.CheckedChanged

        If OptModTime.Checked Then
            DatePickModFrom.Enabled = True
            DatePickModTo.Enabled = True
            DatePickStartFrom.Enabled = False
            DatePickStartTo.Enabled = False
            DatePickEndFrom.Enabled = False
            DatePickEndTo.Enabled = False

        End If

    End Sub



    Private Sub BtnGetSellerEvents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetSellerEvents.Click

        Try

            BtnGetSellerEvents.Enabled = False
            LstEvents.Items.Clear()
            Context = clseBayAPI.setAPIContext()


            Dim ApiCall As GetSellerEventsCall = New GetSellerEventsCall(Context)

            If txtUserID.Text.Length > 0 Then
                ApiCall.UserID = txtUserID.Text()
            End If

            ApiCall.IncludeNewItem = ChkIncludeNew.Checked

            If OptModTime.Checked Then
                ApiCall.ModTimeFilter = New TimeFilter(DatePickModFrom.Value, DatePickModTo.Value)
            ElseIf OptStartTime.Checked Then
                ApiCall.StartTimeFilter = New TimeFilter(DatePickStartFrom.Value, DatePickStartTo.Value)
            ElseIf OptEndTime.Checked Then
                ApiCall.EndTimeFilter = New TimeFilter(DatePickEndFrom.Value, DatePickEndTo.Value)
            End If

            ApiCall.Execute()

            Dim evt As ItemType

            For Each evt In ApiCall.ItemEventList
                Dim listparams(5) As String

                listparams(0) = evt.ItemID
                listparams(1) = evt.Title
                listparams(2) = evt.SellingStatus.CurrentPrice.Value.ToString()
                listparams(3) = evt.SellingStatus.QuantitySold.ToString()
                listparams(4) = evt.SellingStatus.BidCount.ToString()
                listparams(5) = evt.SellingStatus.ListingStatus.ToString()


                Dim vi As ListViewItem = New ListViewItem(listparams)

                LstEvents.Items.Add(vi)

            Next evt
            BtnGetSellerEvents.Enabled = True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "btnGetSellerEvents")
            BtnGetSellerEvents.Enabled = True
        End Try

    End Sub

    Private Sub EBayArtikelAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayArtikelAnzeigenToolStripMenuItem.Click

        If LstEvents.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & LstEvents.SelectedItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
            ExterneAnwendung.Start()
        End If

    End Sub
End Class


