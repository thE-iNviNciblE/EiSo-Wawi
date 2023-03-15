Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FormGetAccount
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


		Friend WithEvents GrpResults As System.Windows.Forms.GroupBox 

		Friend WithEvents label1 As System.Windows.Forms.Label 

		Friend WithEvents BtnGetAccount As System.Windows.Forms.Button 

		Friend WithEvents OptLastInvoice As System.Windows.Forms.RadioButton 

		Friend WithEvents OptInvoiceDate As System.Windows.Forms.RadioButton 

		Friend WithEvents OptRange As System.Windows.Forms.RadioButton 



		Friend WithEvents DatePickInvoice As System.Windows.Forms.DateTimePicker 

		Friend WithEvents DatePickFrom As System.Windows.Forms.DateTimePicker 

		Friend WithEvents DatePickTo As System.Windows.Forms.DateTimePicker 

		Friend WithEvents LblEntries As System.Windows.Forms.Label 

		Friend WithEvents LstAccountEntries As System.Windows.Forms.ListView 

		Friend WithEvents ClmRef As System.Windows.Forms.ColumnHeader 

		Friend WithEvents ClmType As System.Windows.Forms.ColumnHeader 

		Friend WithEvents ClmItemId As System.Windows.Forms.ColumnHeader 

		Friend WithEvents ClmBalance As System.Windows.Forms.ColumnHeader 

    Friend WithEvents ClmDate As System.Windows.Forms.ColumnHeader

    Friend WithEvents LblAccState As System.Windows.Forms.Label

		Friend WithEvents TxtAccState As System.Windows.Forms.TextBox 

		Friend WithEvents TxtAccBalance As System.Windows.Forms.TextBox 

		Friend WithEvents TxtPayMethod As System.Windows.Forms.TextBox 

    Friend WithEvents LblAccBalance As System.Windows.Forms.Label
    Friend WithEvents txtBezahltag As System.Windows.Forms.TextBox
    Friend WithEvents clmTitel As System.Windows.Forms.ColumnHeader

		Friend WithEvents LblPayMethod As System.Windows.Forms.Label 



		<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGetAccount))
        Me.GrpResults = New System.Windows.Forms.GroupBox
        Me.LblPayMethod = New System.Windows.Forms.Label
        Me.LblAccBalance = New System.Windows.Forms.Label
        Me.TxtPayMethod = New System.Windows.Forms.TextBox
        Me.TxtAccBalance = New System.Windows.Forms.TextBox
        Me.txtBezahltag = New System.Windows.Forms.TextBox
        Me.TxtAccState = New System.Windows.Forms.TextBox
        Me.LblAccState = New System.Windows.Forms.Label
        Me.LblEntries = New System.Windows.Forms.Label
        Me.LstAccountEntries = New System.Windows.Forms.ListView
        Me.ClmRef = New System.Windows.Forms.ColumnHeader
        Me.clmTitel = New System.Windows.Forms.ColumnHeader
        Me.ClmType = New System.Windows.Forms.ColumnHeader
        Me.ClmItemId = New System.Windows.Forms.ColumnHeader
        Me.ClmBalance = New System.Windows.Forms.ColumnHeader
        Me.ClmDate = New System.Windows.Forms.ColumnHeader
        Me.BtnGetAccount = New System.Windows.Forms.Button
        Me.OptLastInvoice = New System.Windows.Forms.RadioButton
        Me.OptInvoiceDate = New System.Windows.Forms.RadioButton
        Me.OptRange = New System.Windows.Forms.RadioButton
        Me.label1 = New System.Windows.Forms.Label
        Me.DatePickInvoice = New System.Windows.Forms.DateTimePicker
        Me.DatePickFrom = New System.Windows.Forms.DateTimePicker
        Me.DatePickTo = New System.Windows.Forms.DateTimePicker
        Me.GrpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpResults
        '
        Me.GrpResults.Controls.Add(Me.LblPayMethod)
        Me.GrpResults.Controls.Add(Me.LblAccBalance)
        Me.GrpResults.Controls.Add(Me.TxtPayMethod)
        Me.GrpResults.Controls.Add(Me.TxtAccBalance)
        Me.GrpResults.Controls.Add(Me.txtBezahltag)
        Me.GrpResults.Controls.Add(Me.TxtAccState)
        Me.GrpResults.Controls.Add(Me.LblAccState)
        Me.GrpResults.Controls.Add(Me.LblEntries)
        Me.GrpResults.Controls.Add(Me.LstAccountEntries)
        Me.GrpResults.Location = New System.Drawing.Point(8, 96)
        Me.GrpResults.Name = "GrpResults"
        Me.GrpResults.Size = New System.Drawing.Size(592, 320)
        Me.GrpResults.TabIndex = 45
        Me.GrpResults.TabStop = False
        Me.GrpResults.Text = "Results"
        '
        'LblPayMethod
        '
        Me.LblPayMethod.Location = New System.Drawing.Point(278, 62)
        Me.LblPayMethod.Name = "LblPayMethod"
        Me.LblPayMethod.Size = New System.Drawing.Size(127, 23)
        Me.LblPayMethod.TabIndex = 21
        Me.LblPayMethod.Text = "Bezahlmethode"
        '
        'LblAccBalance
        '
        Me.LblAccBalance.Location = New System.Drawing.Point(309, 24)
        Me.LblAccBalance.Name = "LblAccBalance"
        Me.LblAccBalance.Size = New System.Drawing.Size(96, 23)
        Me.LblAccBalance.TabIndex = 20
        Me.LblAccBalance.Text = "Kontostand"
        '
        'TxtPayMethod
        '
        Me.TxtPayMethod.BackColor = System.Drawing.Color.White
        Me.TxtPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPayMethod.Location = New System.Drawing.Point(405, 60)
        Me.TxtPayMethod.Name = "TxtPayMethod"
        Me.TxtPayMethod.ReadOnly = True
        Me.TxtPayMethod.Size = New System.Drawing.Size(165, 21)
        Me.TxtPayMethod.TabIndex = 19
        '
        'TxtAccBalance
        '
        Me.TxtAccBalance.BackColor = System.Drawing.Color.White
        Me.TxtAccBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccBalance.Location = New System.Drawing.Point(405, 24)
        Me.TxtAccBalance.Name = "TxtAccBalance"
        Me.TxtAccBalance.ReadOnly = True
        Me.TxtAccBalance.Size = New System.Drawing.Size(165, 21)
        Me.TxtAccBalance.TabIndex = 18
        '
        'txtBezahltag
        '
        Me.txtBezahltag.BackColor = System.Drawing.Color.White
        Me.txtBezahltag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBezahltag.Location = New System.Drawing.Point(110, 60)
        Me.txtBezahltag.Name = "txtBezahltag"
        Me.txtBezahltag.ReadOnly = True
        Me.txtBezahltag.Size = New System.Drawing.Size(159, 21)
        Me.txtBezahltag.TabIndex = 17
        '
        'TxtAccState
        '
        Me.TxtAccState.BackColor = System.Drawing.Color.White
        Me.TxtAccState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccState.Location = New System.Drawing.Point(110, 20)
        Me.TxtAccState.Name = "TxtAccState"
        Me.TxtAccState.ReadOnly = True
        Me.TxtAccState.Size = New System.Drawing.Size(159, 21)
        Me.TxtAccState.TabIndex = 17
        '
        'LblAccState
        '
        Me.LblAccState.Location = New System.Drawing.Point(16, 24)
        Me.LblAccState.Name = "LblAccState"
        Me.LblAccState.Size = New System.Drawing.Size(88, 23)
        Me.LblAccState.TabIndex = 16
        Me.LblAccState.Text = "Status"
        '
        'LblEntries
        '
        Me.LblEntries.Location = New System.Drawing.Point(13, 62)
        Me.LblEntries.Name = "LblEntries"
        Me.LblEntries.Size = New System.Drawing.Size(91, 23)
        Me.LblEntries.TabIndex = 14
        Me.LblEntries.Text = "Bezahltag"
        '
        'LstAccountEntries
        '
        Me.LstAccountEntries.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LstAccountEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstAccountEntries.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmRef, Me.clmTitel, Me.ClmType, Me.ClmItemId, Me.ClmBalance, Me.ClmDate})
        Me.LstAccountEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstAccountEntries.FullRowSelect = True
        Me.LstAccountEntries.GridLines = True
        Me.LstAccountEntries.HideSelection = False
        Me.LstAccountEntries.HotTracking = True
        Me.LstAccountEntries.HoverSelection = True
        Me.LstAccountEntries.Location = New System.Drawing.Point(4, 87)
        Me.LstAccountEntries.MultiSelect = False
        Me.LstAccountEntries.Name = "LstAccountEntries"
        Me.LstAccountEntries.Size = New System.Drawing.Size(582, 224)
        Me.LstAccountEntries.TabIndex = 15
        Me.LstAccountEntries.UseCompatibleStateImageBehavior = False
        Me.LstAccountEntries.View = System.Windows.Forms.View.Details
        '
        'ClmRef
        '
        Me.ClmRef.Text = "Referenz"
        Me.ClmRef.Width = 0
        '
        'clmTitel
        '
        Me.clmTitel.Text = "Titel"
        Me.clmTitel.Width = 149
        '
        'ClmType
        '
        Me.ClmType.Text = "Type"
        Me.ClmType.Width = 124
        '
        'ClmItemId
        '
        Me.ClmItemId.Text = "eBayID"
        Me.ClmItemId.Width = 105
        '
        'ClmBalance
        '
        Me.ClmBalance.Text = "Saldo"
        Me.ClmBalance.Width = 89
        '
        'ClmDate
        '
        Me.ClmDate.Text = "Datum"
        Me.ClmDate.Width = 111
        '
        'BtnGetAccount
        '
        Me.BtnGetAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnGetAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetAccount.Image = Global.YabE.My.Resources.Resources.send
        Me.BtnGetAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetAccount.Location = New System.Drawing.Point(8, 423)
        Me.BtnGetAccount.Name = "BtnGetAccount"
        Me.BtnGetAccount.Size = New System.Drawing.Size(592, 26)
        Me.BtnGetAccount.TabIndex = 46
        Me.BtnGetAccount.Text = "    Rechnung anzeigen"
        Me.BtnGetAccount.UseVisualStyleBackColor = False
        '
        'OptLastInvoice
        '
        Me.OptLastInvoice.Checked = True
        Me.OptLastInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptLastInvoice.Location = New System.Drawing.Point(16, 8)
        Me.OptLastInvoice.Name = "OptLastInvoice"
        Me.OptLastInvoice.Size = New System.Drawing.Size(186, 24)
        Me.OptLastInvoice.TabIndex = 47
        Me.OptLastInvoice.TabStop = True
        Me.OptLastInvoice.Text = "Seitdem letzten Einzug"
        '
        'OptInvoiceDate
        '
        Me.OptInvoiceDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptInvoiceDate.Location = New System.Drawing.Point(16, 36)
        Me.OptInvoiceDate.Name = "OptInvoiceDate"
        Me.OptInvoiceDate.Size = New System.Drawing.Size(150, 24)
        Me.OptInvoiceDate.TabIndex = 48
        Me.OptInvoiceDate.Text = "Rechnungsdatum"
        '
        'OptRange
        '
        Me.OptRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptRange.Location = New System.Drawing.Point(16, 66)
        Me.OptRange.Name = "OptRange"
        Me.OptRange.Size = New System.Drawing.Size(128, 24)
        Me.OptRange.TabIndex = 49
        Me.OptRange.Text = "Zwischen"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(304, 56)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(16, 23)
        Me.label1.TabIndex = 54
        Me.label1.Text = " - "
        '
        'DatePickInvoice
        '
        Me.DatePickInvoice.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DatePickInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickInvoice.Location = New System.Drawing.Point(160, 35)
        Me.DatePickInvoice.Name = "DatePickInvoice"
        Me.DatePickInvoice.Size = New System.Drawing.Size(193, 20)
        Me.DatePickInvoice.TabIndex = 55
        '
        'DatePickFrom
        '
        Me.DatePickFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DatePickFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickFrom.Location = New System.Drawing.Point(160, 66)
        Me.DatePickFrom.Name = "DatePickFrom"
        Me.DatePickFrom.Size = New System.Drawing.Size(193, 20)
        Me.DatePickFrom.TabIndex = 56
        '
        'DatePickTo
        '
        Me.DatePickTo.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DatePickTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickTo.Location = New System.Drawing.Point(382, 68)
        Me.DatePickTo.Name = "DatePickTo"
        Me.DatePickTo.Size = New System.Drawing.Size(201, 20)
        Me.DatePickTo.TabIndex = 57
        '
        'FormGetAccount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.ClientSize = New System.Drawing.Size(612, 461)
        Me.Controls.Add(Me.DatePickTo)
        Me.Controls.Add(Me.DatePickFrom)
        Me.Controls.Add(Me.DatePickInvoice)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.OptRange)
        Me.Controls.Add(Me.OptInvoiceDate)
        Me.Controls.Add(Me.OptLastInvoice)
        Me.Controls.Add(Me.BtnGetAccount)
        Me.Controls.Add(Me.GrpResults)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGetAccount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "eBay Rechnung abrufen"
        Me.GrpResults.ResumeLayout(False)
        Me.GrpResults.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Context As ApiContext

    Private Sub OptLastInvoice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptLastInvoice.CheckedChanged
        Dim sel As Boolean = OptLastInvoice.Checked
        If sel = True Then
            DatePickInvoice.Enabled = False
            DatePickFrom.Enabled = False
            DatePickTo.Enabled = False
        End If
    End Sub

    Private Sub OptInvoiceDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptInvoiceDate.CheckedChanged
        Dim sel As Boolean = OptInvoiceDate.Checked
        If sel = True Then
            DatePickInvoice.Enabled = True
            DatePickFrom.Enabled = False
            DatePickTo.Enabled = False
        End If
    End Sub

    Private Sub OptRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptRange.CheckedChanged
        Dim sel As Boolean = OptRange.Checked
        If sel = True Then
            DatePickInvoice.Enabled = False
            DatePickFrom.Enabled = True
            DatePickTo.Enabled = True
        End If
    End Sub



    Private Sub BtnGetAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetAccount.Click

        Try
            LstAccountEntries.Items.Clear()
            TxtAccBalance.Text = ""
            TxtAccState.Text = ""
            TxtPayMethod.Text = ""

            Context = clseBayAPI.setAPIContext()

            Application.DoEvents()

            Dim apicall As GetAccountCall = New GetAccountCall(Context)
            Dim seltype As AccountHistorySelectionCodeType = AccountHistorySelectionCodeType.CustomCode

            If OptLastInvoice.Checked = True Then
                seltype = AccountHistorySelectionCodeType.LastInvoice
            ElseIf OptInvoiceDate.Checked = True Then
                seltype = AccountHistorySelectionCodeType.SpecifiedInvoice
                apicall.InvoiceDate = DatePickInvoice.Value
            ElseIf OptRange.Checked = True Then
                seltype = AccountHistorySelectionCodeType.BetweenSpecifiedDates
                apicall.StartTimeFilter = New TimeFilter(DatePickFrom.Value, DatePickTo.Value)
            End If

            Dim entrylist As AccountEntryTypeCollection = apicall.GetAccount(seltype)
            If Not apicall.AccountSummary Is Nothing Then
                TxtAccBalance.Text = apicall.AccountSummary.CurrentBalance.Value.ToString()
                TxtAccState.Text = apicall.AccountSummary.AccountState.ToString()
                TxtPayMethod.Text = apicall.AccountSummary.PaymentMethod.ToString()
                txtBezahltag.Text = apicall.AccountSummary.LastPaymentDate.ToString

            End If

            If Not entrylist Is Nothing Then

                Dim entry As AccountEntryType

                For Each entry In entrylist

                    Dim listparams(7) As String
                    listparams(0) = entry.RefNumber
                    listparams(1) = entry.Title.ToString 'entry.Balance.Value.ToString()
                    listparams(2) = entry.AccountDetailsEntryType.ToString()
                    listparams(3) = entry.ItemID
                    listparams(4) = entry.Balance.Value
                    listparams(5) = entry.Date.ToString()

                    Dim vi As ListViewItem = New ListViewItem(listparams)

                    Me.LstAccountEntries.Items.Add(vi)

                Next entry
            End If

        Catch ex As Exception
            MsgBox(ex)

        End Try

    End Sub

    Private Sub FormGetAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FormGetAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OptRange.Checked = True
        Dim Now As DateTime = DateTime.Now
        DatePickInvoice.Value = Now
        DatePickTo.Value = Now
        DatePickFrom.Value = Now.AddDays(-5)

    End Sub
End Class


