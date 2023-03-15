Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FrmGetCrossPromotions
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

    Friend WithEvents LblCategory As System.Windows.Forms.Label

    Friend WithEvents LstCrossPromotions As System.Windows.Forms.ListView

    Friend WithEvents BtnGetCrossPromotions As System.Windows.Forms.Button

    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox

    Friend WithEvents CboMethod As System.Windows.Forms.ComboBox

    Friend WithEvents LblMethod As System.Windows.Forms.Label

    Friend WithEvents CboViewMode As System.Windows.Forms.ComboBox

    Friend WithEvents LblViewMode As System.Windows.Forms.Label


    Friend WithEvents ClmPriceType As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblArtikel As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImBrowser÷ffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents ClmListingType As System.Windows.Forms.ColumnHeader



    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGetCrossPromotions))
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.LstCrossPromotions = New System.Windows.Forms.ListView
        Me.ClmItemId = New System.Windows.Forms.ColumnHeader
        Me.ClmTitle = New System.Windows.Forms.ColumnHeader
        Me.ClmPrice = New System.Windows.Forms.ColumnHeader
        Me.ClmPriceType = New System.Windows.Forms.ColumnHeader
        Me.ClmListingType = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImBrowser÷ffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnGetCrossPromotions = New System.Windows.Forms.Button
        Me.LblCategory = New System.Windows.Forms.Label
        Me.TxtItemId = New System.Windows.Forms.TextBox
        Me.CboMethod = New System.Windows.Forms.ComboBox
        Me.LblMethod = New System.Windows.Forms.Label
        Me.CboViewMode = New System.Windows.Forms.ComboBox
        Me.LblViewMode = New System.Windows.Forms.Label
        Me.btnVor = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.lblArtikel = New System.Windows.Forms.Label
        Me.GrpResult.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.LstCrossPromotions)
        Me.GrpResult.Location = New System.Drawing.Point(8, 122)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(774, 339)
        Me.GrpResult.TabIndex = 24
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnise"
        '
        'LstCrossPromotions
        '
        Me.LstCrossPromotions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstCrossPromotions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmItemId, Me.ClmTitle, Me.ClmPrice, Me.ClmPriceType, Me.ClmListingType})
        Me.LstCrossPromotions.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LstCrossPromotions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstCrossPromotions.FullRowSelect = True
        Me.LstCrossPromotions.GridLines = True
        Me.LstCrossPromotions.Location = New System.Drawing.Point(3, 17)
        Me.LstCrossPromotions.Name = "LstCrossPromotions"
        Me.LstCrossPromotions.Size = New System.Drawing.Size(768, 319)
        Me.LstCrossPromotions.TabIndex = 4
        Me.LstCrossPromotions.UseCompatibleStateImageBehavior = False
        Me.LstCrossPromotions.View = System.Windows.Forms.View.Details
        '
        'ClmItemId
        '
        Me.ClmItemId.Text = "ArtikelNr."
        Me.ClmItemId.Width = 80
        '
        'ClmTitle
        '
        Me.ClmTitle.Text = "Titel"
        Me.ClmTitle.Width = 312
        '
        'ClmPrice
        '
        Me.ClmPrice.Text = "Preis"
        Me.ClmPrice.Width = 117
        '
        'ClmPriceType
        '
        Me.ClmPriceType.Text = "Auktionstyp"
        Me.ClmPriceType.Width = 125
        '
        'ClmListingType
        '
        Me.ClmListingType.Text = "Format"
        Me.ClmListingType.Width = 132
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImBrowser÷ffnenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(172, 26)
        '
        'ImBrowser÷ffnenToolStripMenuItem
        '
        Me.ImBrowser÷ffnenToolStripMenuItem.Name = "ImBrowser÷ffnenToolStripMenuItem"
        Me.ImBrowser÷ffnenToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ImBrowser÷ffnenToolStripMenuItem.Text = "Im Browser ˆffnen"
        '
        'BtnGetCrossPromotions
        '
        Me.BtnGetCrossPromotions.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetCrossPromotions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetCrossPromotions.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetCrossPromotions.Image = Global.YabE.My.Resources.Resources._24
        Me.BtnGetCrossPromotions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetCrossPromotions.Location = New System.Drawing.Point(565, 93)
        Me.BtnGetCrossPromotions.Name = "BtnGetCrossPromotions"
        Me.BtnGetCrossPromotions.Size = New System.Drawing.Size(217, 23)
        Me.BtnGetCrossPromotions.TabIndex = 23
        Me.BtnGetCrossPromotions.Text = "&CrossPromotion"
        Me.BtnGetCrossPromotions.UseVisualStyleBackColor = False
        '
        'LblCategory
        '
        Me.LblCategory.Location = New System.Drawing.Point(12, 56)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(80, 23)
        Me.LblCategory.TabIndex = 78
        Me.LblCategory.Text = "Artikel-Nr:"
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(92, 56)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(136, 21)
        Me.TxtItemId.TabIndex = 77
        '
        'CboMethod
        '
        Me.CboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboMethod.Location = New System.Drawing.Point(283, 56)
        Me.CboMethod.Name = "CboMethod"
        Me.CboMethod.Size = New System.Drawing.Size(136, 21)
        Me.CboMethod.TabIndex = 87
        '
        'LblMethod
        '
        Me.LblMethod.Location = New System.Drawing.Point(248, 59)
        Me.LblMethod.Name = "LblMethod"
        Me.LblMethod.Size = New System.Drawing.Size(80, 18)
        Me.LblMethod.TabIndex = 86
        Me.LblMethod.Text = "Art:"
        '
        'CboViewMode
        '
        Me.CboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboViewMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboViewMode.Location = New System.Drawing.Point(92, 93)
        Me.CboViewMode.Name = "CboViewMode"
        Me.CboViewMode.Size = New System.Drawing.Size(136, 21)
        Me.CboViewMode.TabIndex = 89
        '
        'LblViewMode
        '
        Me.LblViewMode.Location = New System.Drawing.Point(12, 93)
        Me.LblViewMode.Name = "LblViewMode"
        Me.LblViewMode.Size = New System.Drawing.Size(80, 18)
        Me.LblViewMode.TabIndex = 88
        Me.LblViewMode.Text = "Ansicht:"
        '
        'btnVor
        '
        Me.btnVor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(409, 93)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(150, 23)
        Me.btnVor.TabIndex = 129
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(251, 93)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 23)
        Me.btnBack.TabIndex = 128
        Me.btnBack.Text = "&Zur¸ck"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblArtikel
        '
        Me.lblArtikel.AutoSize = True
        Me.lblArtikel.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikel.Location = New System.Drawing.Point(17, 13)
        Me.lblArtikel.Name = "lblArtikel"
        Me.lblArtikel.Size = New System.Drawing.Size(0, 25)
        Me.lblArtikel.TabIndex = 130
        '
        'FrmGetCrossPromotions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 470)
        Me.Controls.Add(Me.lblArtikel)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.CboViewMode)
        Me.Controls.Add(Me.LblViewMode)
        Me.Controls.Add(Me.CboMethod)
        Me.Controls.Add(Me.LblMethod)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.TxtItemId)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnGetCrossPromotions)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGetCrossPromotions"
        Me.Text = "YabE - eBay Crosspromotion"
        Me.GrpResult.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public lvwDataInput As ListView
    Public Context As ApiContext

    '# Daten holen 
    Private Function getFormData() As Boolean
        Try

            Select Case lvwDataInput.Name
                Case "lvwEiSoCockpit"

                    If lvwDataInput.SelectedItems.Count > 0 Then
                        TxtItemId.Text = lvwDataInput.SelectedItems(0).Text
                        lblArtikel.Text = lvwDataInput.SelectedItems(0).SubItems(1).Text
                        BtnGetCrossPromotions.PerformClick()
                    End If

            End Select

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub FrmGetCrossPromotions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim s() As String = [Enum].GetNames(GetType(PromotionMethodCodeType))
        Dim item As String

        For Each item In s
            If item <> "CustomCode" Then
                CboMethod.Items.Add(item)
            End If
        Next item

        CboMethod.SelectedIndex = 0


        s = [Enum].GetNames(GetType(TradingRoleCodeType))

        For Each item In s
            If item <> "CustomCode" Then
                CboViewMode.Items.Add(item.Replace("Buyer", "K‰ufer").Replace("Seller", "Verk‰ufer"))
            End If
        Next item

        CboViewMode.SelectedIndex = 1 ' Verk‰ufer 

        '# Automatisch klicken 
        If TxtItemId.Text.Length > 0 Then
            lblArtikel.Text = lvwDataInput.SelectedItems(0).SubItems(1).Text
            BtnGetCrossPromotions.PerformClick()
        End If

    End Sub


    Private Sub BtnGetCrossPromotions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetCrossPromotions.Click

        Try

            BtnGetCrossPromotions.Enabled = False
            LstCrossPromotions.Items.Clear()

            Context = clseBayAPI.setAPIContext()
            Dim apicall As GetCrossPromotionsCall = New GetCrossPromotionsCall(Context)

            apicall.PromotionViewMode = [Enum].Parse(GetType(TradingRoleCodeType), CboViewMode.SelectedItem.ToString().Replace("K‰ufer", "Buyer").Replace("Verk‰ufer", "Seller"))

            Dim promotions As CrossPromotionsType = apicall.GetCrossPromotions(TxtItemId.Text, [Enum].Parse(GetType(PromotionMethodCodeType), CboMethod.SelectedItem.ToString))
            Dim promo As PromotedItemType
            For Each promo In promotions.PromotedItem

                Dim listparams(5) As String

                listparams(0) = promo.ItemID

                listparams(1) = promo.Title

                listparams(3) = promo.ListingType.ToString()


                Dim vi As ListViewItem = New ListViewItem(listparams)

                LstCrossPromotions.Items.Add(vi)
            Next promo
            BtnGetCrossPromotions.Enabled = True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "btnGetCrossPromotion")
            BtnGetCrossPromotions.Enabled = True
        End Try

    End Sub

    Private Sub TxtItemId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemId.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnGetCrossPromotions.PerformClick()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then


            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False
            iAnzahl -= 1
            btnVor.Enabled = True

            If iAnzahl = 0 Then
                btnBack.Enabled = False
            Else
                btnBack.Enabled = True
            End If

            lvwDataInput.Items(iAnzahl).Selected = True
            lvwDataInput.Items(iAnzahl).EnsureVisible()

            Call getFormData()
        End If
    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then


            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False

            iAnzahl += 1
            btnVor.Enabled = True

            If iAnzahl = lvwDataInput.Items.Count Then
                btnVor.Enabled = False
            Else
                btnVor.Enabled = True
            End If

            lvwDataInput.Items(iAnzahl).Selected = True
            lvwDataInput.Items(iAnzahl).EnsureVisible()

            Call getFormData()
        End If
    End Sub

    Private Sub ImBrowser÷ffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImBrowser÷ffnenToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwDataInput.SelectedItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
        ExterneAnwendung.Start()
    End Sub
End Class

