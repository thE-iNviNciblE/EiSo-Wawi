Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FormGetSearchResults
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

		Friend WithEvents ClmItemId As System.Windows.Forms.ColumnHeader 

		Friend WithEvents ClmTitle As System.Windows.Forms.ColumnHeader 

		Friend WithEvents ClmPrice As System.Windows.Forms.ColumnHeader 

		Friend WithEvents ClmBids As System.Windows.Forms.ColumnHeader 

		Friend WithEvents BtnGetSearchResults As System.Windows.Forms.Button 

		Friend WithEvents TxtQuery As System.Windows.Forms.TextBox 

		Friend WithEvents ChkSearchDescription As System.Windows.Forms.CheckBox 

		Friend WithEvents LblQuery As System.Windows.Forms.Label 

		Friend WithEvents TxtPriceFrom As System.Windows.Forms.TextBox 

		Friend WithEvents TxtPriceTo As System.Windows.Forms.TextBox 

		Friend WithEvents LblPriceRange As System.Windows.Forms.Label 

		Friend WithEvents LblPriceSep As System.Windows.Forms.Label 

		Friend WithEvents LblCategory As System.Windows.Forms.Label 

		Friend WithEvents TxtCategory As System.Windows.Forms.TextBox 

		Friend WithEvents ChkPayPal As System.Windows.Forms.CheckBox 

		Friend WithEvents CboSort  As System.Windows.Forms.ComboBox 

		Friend WithEvents LblSort As System.Windows.Forms.Label 

		Friend WithEvents LstSearchResults As System.Windows.Forms.ListView 



    Friend WithEvents ClmTimeLeft As System.Windows.Forms.ColumnHeader


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGetSearchResults))
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.LstSearchResults = New System.Windows.Forms.ListView
        Me.ClmItemId = New System.Windows.Forms.ColumnHeader
        Me.ClmTitle = New System.Windows.Forms.ColumnHeader
        Me.ClmPrice = New System.Windows.Forms.ColumnHeader
        Me.ClmBids = New System.Windows.Forms.ColumnHeader
        Me.ClmTimeLeft = New System.Windows.Forms.ColumnHeader
        Me.BtnGetSearchResults = New System.Windows.Forms.Button
        Me.TxtQuery = New System.Windows.Forms.TextBox
        Me.ChkSearchDescription = New System.Windows.Forms.CheckBox
        Me.LblQuery = New System.Windows.Forms.Label
        Me.TxtPriceFrom = New System.Windows.Forms.TextBox
        Me.TxtPriceTo = New System.Windows.Forms.TextBox
        Me.LblPriceRange = New System.Windows.Forms.Label
        Me.LblPriceSep = New System.Windows.Forms.Label
        Me.LblCategory = New System.Windows.Forms.Label
        Me.TxtCategory = New System.Windows.Forms.TextBox
        Me.ChkPayPal = New System.Windows.Forms.CheckBox
        Me.CboSort = New System.Windows.Forms.ComboBox
        Me.LblSort = New System.Windows.Forms.Label
        Me.GrpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpResult
        '
        Me.GrpResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpResult.Controls.Add(Me.LstSearchResults)
        Me.GrpResult.Location = New System.Drawing.Point(8, 125)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(674, 391)
        Me.GrpResult.TabIndex = 24
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnisse"
        '
        'LstSearchResults
        '
        Me.LstSearchResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmItemId, Me.ClmTitle, Me.ClmPrice, Me.ClmBids, Me.ClmTimeLeft})
        Me.LstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstSearchResults.FullRowSelect = True
        Me.LstSearchResults.GridLines = True
        Me.LstSearchResults.Location = New System.Drawing.Point(3, 16)
        Me.LstSearchResults.Name = "LstSearchResults"
        Me.LstSearchResults.Size = New System.Drawing.Size(668, 372)
        Me.LstSearchResults.TabIndex = 4
        Me.LstSearchResults.UseCompatibleStateImageBehavior = False
        Me.LstSearchResults.View = System.Windows.Forms.View.Details
        '
        'ClmItemId
        '
        Me.ClmItemId.Text = "ArtikelID"
        Me.ClmItemId.Width = 107
        '
        'ClmTitle
        '
        Me.ClmTitle.Text = "Titel"
        Me.ClmTitle.Width = 298
        '
        'ClmPrice
        '
        Me.ClmPrice.Text = "Preis"
        '
        'ClmBids
        '
        Me.ClmBids.Text = "Gebote"
        Me.ClmBids.Width = 88
        '
        'ClmTimeLeft
        '
        Me.ClmTimeLeft.Text = "Verbleibene Zeit"
        Me.ClmTimeLeft.Width = 110
        '
        'BtnGetSearchResults
        '
        Me.BtnGetSearchResults.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetSearchResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetSearchResults.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetSearchResults.Image = Global.YabE.My.Resources.Resources._24
        Me.BtnGetSearchResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetSearchResults.Location = New System.Drawing.Point(215, 96)
        Me.BtnGetSearchResults.Name = "BtnGetSearchResults"
        Me.BtnGetSearchResults.Size = New System.Drawing.Size(169, 23)
        Me.BtnGetSearchResults.TabIndex = 23
        Me.BtnGetSearchResults.Text = "&Suche starten"
        Me.BtnGetSearchResults.UseVisualStyleBackColor = False
        '
        'TxtQuery
        '
        Me.TxtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuery.Location = New System.Drawing.Point(96, 16)
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.Size = New System.Drawing.Size(266, 20)
        Me.TxtQuery.TabIndex = 70
        '
        'ChkSearchDescription
        '
        Me.ChkSearchDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSearchDescription.Location = New System.Drawing.Point(96, 40)
        Me.ChkSearchDescription.Name = "ChkSearchDescription"
        Me.ChkSearchDescription.Size = New System.Drawing.Size(240, 24)
        Me.ChkSearchDescription.TabIndex = 71
        Me.ChkSearchDescription.Text = "Suche in Textbeschreibung"
        '
        'LblQuery
        '
        Me.LblQuery.Location = New System.Drawing.Point(16, 16)
        Me.LblQuery.Name = "LblQuery"
        Me.LblQuery.Size = New System.Drawing.Size(80, 16)
        Me.LblQuery.TabIndex = 72
        Me.LblQuery.Text = "Suchbegriff"
        Me.LblQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPriceFrom
        '
        Me.TxtPriceFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPriceFrom.Location = New System.Drawing.Point(95, 70)
        Me.TxtPriceFrom.Name = "TxtPriceFrom"
        Me.TxtPriceFrom.Size = New System.Drawing.Size(100, 20)
        Me.TxtPriceFrom.TabIndex = 73
        '
        'TxtPriceTo
        '
        Me.TxtPriceTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPriceTo.Location = New System.Drawing.Point(215, 70)
        Me.TxtPriceTo.Name = "TxtPriceTo"
        Me.TxtPriceTo.Size = New System.Drawing.Size(100, 20)
        Me.TxtPriceTo.TabIndex = 74
        '
        'LblPriceRange
        '
        Me.LblPriceRange.Location = New System.Drawing.Point(15, 70)
        Me.LblPriceRange.Name = "LblPriceRange"
        Me.LblPriceRange.Size = New System.Drawing.Size(80, 23)
        Me.LblPriceRange.TabIndex = 75
        Me.LblPriceRange.Text = "Preisbereich:"
        Me.LblPriceRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceSep
        '
        Me.LblPriceSep.Location = New System.Drawing.Point(199, 70)
        Me.LblPriceSep.Name = "LblPriceSep"
        Me.LblPriceSep.Size = New System.Drawing.Size(8, 23)
        Me.LblPriceSep.TabIndex = 76
        Me.LblPriceSep.Text = "-"
        '
        'LblCategory
        '
        Me.LblCategory.Location = New System.Drawing.Point(15, 94)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(80, 23)
        Me.LblCategory.TabIndex = 78
        Me.LblCategory.Text = "Kategorie:"
        Me.LblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCategory
        '
        Me.TxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategory.Location = New System.Drawing.Point(95, 94)
        Me.TxtCategory.Name = "TxtCategory"
        Me.TxtCategory.Size = New System.Drawing.Size(100, 20)
        Me.TxtCategory.TabIndex = 77
        '
        'ChkPayPal
        '
        Me.ChkPayPal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkPayPal.Location = New System.Drawing.Point(242, 42)
        Me.ChkPayPal.Name = "ChkPayPal"
        Me.ChkPayPal.Size = New System.Drawing.Size(120, 24)
        Me.ChkPayPal.TabIndex = 79
        Me.ChkPayPal.Text = "Paypal Zahlmethode"
        '
        'CboSort
        '
        Me.CboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboSort.Location = New System.Drawing.Point(438, 16)
        Me.CboSort.Name = "CboSort"
        Me.CboSort.Size = New System.Drawing.Size(240, 22)
        Me.CboSort.TabIndex = 81
        '
        'LblSort
        '
        Me.LblSort.Location = New System.Drawing.Point(374, 17)
        Me.LblSort.Name = "LblSort"
        Me.LblSort.Size = New System.Drawing.Size(64, 18)
        Me.LblSort.TabIndex = 80
        Me.LblSort.Text = "Sortieren:"
        Me.LblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormGetSearchResults
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 521)
        Me.Controls.Add(Me.CboSort)
        Me.Controls.Add(Me.LblSort)
        Me.Controls.Add(Me.ChkPayPal)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.TxtCategory)
        Me.Controls.Add(Me.LblPriceSep)
        Me.Controls.Add(Me.LblPriceRange)
        Me.Controls.Add(Me.TxtPriceTo)
        Me.Controls.Add(Me.TxtPriceFrom)
        Me.Controls.Add(Me.LblQuery)
        Me.Controls.Add(Me.ChkSearchDescription)
        Me.Controls.Add(Me.TxtQuery)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnGetSearchResults)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormGetSearchResults"
        Me.Text = "Yabe - eBay Suche"
        Me.GrpResult.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext

    Private Sub FrmGetSearchResults_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim s() As String = [Enum].GetNames(GetType(SearchSortOrderCodeType))
        'Dim item As String

        'For Each item In s
        '    If item <> "CustomCode" Then

        '        CboSort.Items.Add(item)

        '    End If
        'Next item

        'CboSort.SelectedIndex = 0

    End Sub



    Private Sub BtnGetSearchResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetSearchResults.Click

        Try

            'BtnGetSearchResults.Enabled = False
            'LstSearchResults.Items.Clear()
            'Context = clseBayAPI.setAPIContext()
            'Dim apicall As GetSearchResultsCall = New GetSearchResultsCall(Context)

            'If ChkSearchDescription.Checked Or ChkPayPal.Checked Then
            '    apicall.SearchFlagsList = New SearchFlagsCodeTypeCollection()
            'End If

            'If ChkSearchDescription.Checked Then
            '    apicall.SearchFlagsList.Add(SearchFlagsCodeType.SearchInDescription)
            'End If


            'If ChkPayPal.Checked Then

            '    apicall.SearchFlagsList.Add(SearchFlagsCodeType.PayPalBuyerPaymentOption)

            'End If

            'If TxtPriceFrom.Text.Length > 0 And TxtPriceTo.Text.Length > 0 Then

            '    apicall.PriceRangeFilter = New PriceRangeFilterType()
            '    apicall.PriceRangeFilter.MinPrice = New AmountType()
            '    apicall.PriceRangeFilter.MaxPrice = New AmountType()
            '    apicall.PriceRangeFilter.MinPrice.Value = Convert.ToDouble(TxtPriceFrom.Text)
            '    apicall.PriceRangeFilter.MaxPrice.Value = Convert.ToDouble(TxtPriceTo.Text)

            'End If



            'apicall.CategoryID = TxtCategory.Text

            'apicall.Order = [Enum].Parse(GetType(SearchSortOrderCodeType), CboSort.SelectedItem.ToString())

            'Dim fnditems As SearchResultItemTypeCollection = apicall.GetSearchResults(TxtQuery.Text)
            'Dim fnditem As SearchResultItemType

            'For Each fnditem In fnditems
            '    Dim listparams(5) As String

            '    listparams(0) = fnditem.Item.ItemID
            '    listparams(1) = fnditem.Item.Title
            '    listparams(2) = fnditem.Item.SellingStatus.CurrentPrice.Value.ToString()
            '    listparams(3) = fnditem.Item.SellingStatus.BidCount.ToString()
            '    listparams(4) = DateTime.Now.ToString()


            '    Dim vi As ListViewItem = New ListViewItem(listparams)

            '    LstSearchResults.Items.Add(vi)
            'Next fnditem

            BtnGetSearchResults.Enabled = True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "BtnGetSearchResults")
            BtnGetSearchResults.Enabled = True
        End Try

    End Sub

    Private Sub TxtQuery_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuery.KeyDown

        If e.KeyCode = Keys.Enter Then
            BtnGetSearchResults.PerformClick()
        End If

    End Sub
End Class


