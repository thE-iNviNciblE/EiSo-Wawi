<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMagentoManger
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tbMagentoSub = New System.Windows.Forms.TabControl
        Me.Artikel = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lvwMagentoKategorie = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.cmsKategorie = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YabE2MagentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tabMCArtikelstamm = New System.Windows.Forms.TabControl
        Me.tb_Artikeliste = New System.Windows.Forms.TabPage
        Me.lvwMagentoArtikel = New System.Windows.Forms.ListView
        Me.col_magentoID = New System.Windows.Forms.ColumnHeader
        Me.col_magentoBeschreibung = New System.Windows.Forms.ColumnHeader
        Me.col_magentoPreis = New System.Windows.Forms.ColumnHeader
        Me.col_magentoAttribut = New System.Windows.Forms.ColumnHeader
        Me.col_magentoType = New System.Windows.Forms.ColumnHeader
        Me.col_magentoSichtbarkeit = New System.Windows.Forms.ColumnHeader
        Me.col_magentoSKU = New System.Windows.Forms.ColumnHeader
        Me.col_magentoStatus = New System.Windows.Forms.ColumnHeader
        Me.col_magentoShort = New System.Windows.Forms.ColumnHeader
        Me.col_magentoLong = New System.Windows.Forms.ColumnHeader
        Me.cmsArtikel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SYNCYabEArtikelstammImportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreisanalyseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tb_ArtikelInfo = New System.Windows.Forms.TabPage
        Me.btnNew = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtItemPreis = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtItemLong = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtItemShort = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbSichtbarkeit = New System.Windows.Forms.ComboBox
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.tb_KategorieInfo = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.tab_KateInfo_sub = New System.Windows.Forms.TabControl
        Me.col_mcCat_Status = New System.Windows.Forms.TabPage
        Me.txtMagentoCat_Sortierung = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtMagentoCat_Anker = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMagentoCat_Aktiv = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMagentoCat_MetaTitel = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtMagentoCat_MetaDescription = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMagentoCat_MetaKeywords = New System.Windows.Forms.TextBox
        Me.txtMagentoCat_Urlkey = New System.Windows.Forms.TextBox
        Me.txtMCCat_Name = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.col_mcCat_Beschreibung = New System.Windows.Forms.TabPage
        Me.txtMagentoCat_beschreibung = New System.Windows.Forms.TextBox
        Me.col_mcCat_xml = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMagentoCat_Anzeigemodus = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtMagentoCat_Pagelayout = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMagentoCat_Apply = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMagentoCat_layout = New System.Windows.Forms.TextBox
        Me.txtMagentoCat_Design = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtMagentoCat_DesignEnde = New System.Windows.Forms.TextBox
        Me.txtMagentoCat_DesignAktiv = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMCCat_LayoutXML = New System.Windows.Forms.TextBox
        Me.col_mcCat_more = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMCCat_ID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMCcat_updated = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMCcat_erstellt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtURLPath = New System.Windows.Forms.TextBox
        Me.btnMagentoKategorieInfo = New System.Windows.Forms.Button
        Me.btnMagentoKategorieInfo_save = New System.Windows.Forms.Button
        Me.Kunden = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lvwMagentoKunden = New System.Windows.Forms.ListView
        Me.magento_user_id = New System.Windows.Forms.ColumnHeader
        Me.magento_user_name = New System.Windows.Forms.ColumnHeader
        Me.magento_email = New System.Windows.Forms.ColumnHeader
        Me.magento_user_country = New System.Windows.Forms.ColumnHeader
        Me.magento_user_pwdhash = New System.Windows.Forms.ColumnHeader
        Me.magento_user_street = New System.Windows.Forms.ColumnHeader
        Me.magento_user_PLZ = New System.Windows.Forms.ColumnHeader
        Me.magento_user_Ort = New System.Windows.Forms.ColumnHeader
        Me.magento_user_Art = New System.Windows.Forms.ColumnHeader
        Me.magento_user_nachname = New System.Windows.Forms.ColumnHeader
        Me.magento_user_telefone = New System.Windows.Forms.ColumnHeader
        Me.magento_user_adressID = New System.Windows.Forms.ColumnHeader
        Me.cmsKunden = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AktuallisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lvwKunden_YabE = New System.Windows.Forms.ListView
        Me.kd_nachname = New System.Windows.Forms.ColumnHeader
        Me.kd_eBayName = New System.Windows.Forms.ColumnHeader
        Me.kd_eMail = New System.Windows.Forms.ColumnHeader
        Me.kd_strasse = New System.Windows.Forms.ColumnHeader
        Me.kd_PLZ = New System.Windows.Forms.ColumnHeader
        Me.kd_Ort = New System.Windows.Forms.ColumnHeader
        Me.kd_Land = New System.Windows.Forms.ColumnHeader
        Me.kd_käufe = New System.Windows.Forms.ColumnHeader
        Me.kd_Artikel = New System.Windows.Forms.ColumnHeader
        Me.kd_newsletter = New System.Windows.Forms.ColumnHeader
        Me.kd_last = New System.Windows.Forms.ColumnHeader
        Me.kd_plattform = New System.Windows.Forms.ColumnHeader
        Me.kd_sprachenliste = New System.Windows.Forms.ColumnHeader
        Me.kd_muttersprache = New System.Windows.Forms.ColumnHeader
        Me.cmsKunden_YabE = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EinlesenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.AlleHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.bestellungen = New System.Windows.Forms.TabPage
        Me.btnBestellungen_sync = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.lvwMagento_bestellungen = New System.Windows.Forms.ListView
        Me.colMCBestellung_id = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellung_name = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellung_email = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellung_ort = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellung_land = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellung_strasse = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellung_preis = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellung_beschreibung = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellungen_mcid = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellungen_cdatum = New System.Windows.Forms.ColumnHeader
        Me.colMcBestellungen_customerid = New System.Windows.Forms.ColumnHeader
        Me.colMCBestellungen_SKU = New System.Windows.Forms.ColumnHeader
        Me.cmsBestellungen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.yabe_dashboard_header = New System.Windows.Forms.Label
        Me.colMCBestellung_plz = New System.Windows.Forms.ColumnHeader
        Me.tbMagentoSub.SuspendLayout()
        Me.Artikel.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.cmsKategorie.SuspendLayout()
        Me.tabMCArtikelstamm.SuspendLayout()
        Me.tb_Artikeliste.SuspendLayout()
        Me.cmsArtikel.SuspendLayout()
        Me.tb_ArtikelInfo.SuspendLayout()
        Me.tb_KategorieInfo.SuspendLayout()
        Me.tab_KateInfo_sub.SuspendLayout()
        Me.col_mcCat_Status.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.col_mcCat_Beschreibung.SuspendLayout()
        Me.col_mcCat_xml.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.col_mcCat_more.SuspendLayout()
        Me.Kunden.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.cmsKunden.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.cmsKunden_YabE.SuspendLayout()
        Me.bestellungen.SuspendLayout()
        Me.cmsBestellungen.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMagentoSub
        '
        Me.tbMagentoSub.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMagentoSub.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbMagentoSub.Controls.Add(Me.Artikel)
        Me.tbMagentoSub.Controls.Add(Me.Kunden)
        Me.tbMagentoSub.Controls.Add(Me.bestellungen)
        Me.tbMagentoSub.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMagentoSub.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMagentoSub.Location = New System.Drawing.Point(14, 59)
        Me.tbMagentoSub.Multiline = True
        Me.tbMagentoSub.Name = "tbMagentoSub"
        Me.tbMagentoSub.SelectedIndex = 0
        Me.tbMagentoSub.Size = New System.Drawing.Size(975, 617)
        Me.tbMagentoSub.TabIndex = 28
        '
        'Artikel
        '
        Me.Artikel.BackColor = System.Drawing.Color.Gainsboro
        Me.Artikel.Controls.Add(Me.SplitContainer1)
        Me.Artikel.Location = New System.Drawing.Point(4, 25)
        Me.Artikel.Name = "Artikel"
        Me.Artikel.Padding = New System.Windows.Forms.Padding(3)
        Me.Artikel.Size = New System.Drawing.Size(967, 588)
        Me.Artikel.TabIndex = 0
        Me.Artikel.Text = "Artikelstamm"
        Me.Artikel.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(-142, 9)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwMagentoKategorie)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tabMCArtikelstamm)
        Me.SplitContainer1.Size = New System.Drawing.Size(1250, 569)
        Me.SplitContainer1.SplitterDistance = 363
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 27
        '
        'lvwMagentoKategorie
        '
        Me.lvwMagentoKategorie.AllowColumnReorder = True
        Me.lvwMagentoKategorie.AllowDrop = True
        Me.lvwMagentoKategorie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMagentoKategorie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMagentoKategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMagentoKategorie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwMagentoKategorie.ContextMenuStrip = Me.cmsKategorie
        Me.lvwMagentoKategorie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMagentoKategorie.FullRowSelect = True
        Me.lvwMagentoKategorie.GridLines = True
        Me.lvwMagentoKategorie.HideSelection = False
        Me.lvwMagentoKategorie.Location = New System.Drawing.Point(148, 0)
        Me.lvwMagentoKategorie.Name = "lvwMagentoKategorie"
        Me.lvwMagentoKategorie.Size = New System.Drawing.Size(214, 566)
        Me.lvwMagentoKategorie.TabIndex = 18
        Me.lvwMagentoKategorie.UseCompatibleStateImageBehavior = False
        Me.lvwMagentoKategorie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 2
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 0
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 1
        Me.ColumnHeader3.Text = "Zugriffe"
        Me.ColumnHeader3.Width = 73
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DelcampeID"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MagentoID"
        '
        'cmsKategorie
        '
        Me.cmsKategorie.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.YabE2MagentoToolStripMenuItem})
        Me.cmsKategorie.Name = "cmsKategorie"
        Me.cmsKategorie.Size = New System.Drawing.Size(170, 48)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'YabE2MagentoToolStripMenuItem
        '
        Me.YabE2MagentoToolStripMenuItem.Name = "YabE2MagentoToolStripMenuItem"
        Me.YabE2MagentoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.YabE2MagentoToolStripMenuItem.Text = "YabE 2 Magento..."
        '
        'tabMCArtikelstamm
        '
        Me.tabMCArtikelstamm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMCArtikelstamm.Controls.Add(Me.tb_Artikeliste)
        Me.tabMCArtikelstamm.Controls.Add(Me.tb_ArtikelInfo)
        Me.tabMCArtikelstamm.Controls.Add(Me.tb_KategorieInfo)
        Me.tabMCArtikelstamm.Location = New System.Drawing.Point(4, 3)
        Me.tabMCArtikelstamm.Name = "tabMCArtikelstamm"
        Me.tabMCArtikelstamm.SelectedIndex = 0
        Me.tabMCArtikelstamm.Size = New System.Drawing.Size(741, 563)
        Me.tabMCArtikelstamm.TabIndex = 14
        '
        'tb_Artikeliste
        '
        Me.tb_Artikeliste.Controls.Add(Me.lvwMagentoArtikel)
        Me.tb_Artikeliste.Location = New System.Drawing.Point(4, 22)
        Me.tb_Artikeliste.Name = "tb_Artikeliste"
        Me.tb_Artikeliste.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Artikeliste.Size = New System.Drawing.Size(733, 537)
        Me.tb_Artikeliste.TabIndex = 0
        Me.tb_Artikeliste.Text = "Artikeliste"
        Me.tb_Artikeliste.UseVisualStyleBackColor = True
        '
        'lvwMagentoArtikel
        '
        Me.lvwMagentoArtikel.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMagentoArtikel.AllowColumnReorder = True
        Me.lvwMagentoArtikel.AllowDrop = True
        Me.lvwMagentoArtikel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMagentoArtikel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMagentoArtikel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_magentoID, Me.col_magentoBeschreibung, Me.col_magentoPreis, Me.col_magentoAttribut, Me.col_magentoType, Me.col_magentoSichtbarkeit, Me.col_magentoSKU, Me.col_magentoStatus, Me.col_magentoShort, Me.col_magentoLong})
        Me.lvwMagentoArtikel.ContextMenuStrip = Me.cmsArtikel
        Me.lvwMagentoArtikel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvwMagentoArtikel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMagentoArtikel.FullRowSelect = True
        Me.lvwMagentoArtikel.GridLines = True
        Me.lvwMagentoArtikel.HideSelection = False
        Me.lvwMagentoArtikel.Location = New System.Drawing.Point(3, 3)
        Me.lvwMagentoArtikel.Name = "lvwMagentoArtikel"
        Me.lvwMagentoArtikel.Size = New System.Drawing.Size(741, 531)
        Me.lvwMagentoArtikel.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwMagentoArtikel.TabIndex = 13
        Me.lvwMagentoArtikel.UseCompatibleStateImageBehavior = False
        Me.lvwMagentoArtikel.View = System.Windows.Forms.View.Details
        '
        'col_magentoID
        '
        Me.col_magentoID.Text = "MagentoID"
        '
        'col_magentoBeschreibung
        '
        Me.col_magentoBeschreibung.Text = "Beschreibung"
        Me.col_magentoBeschreibung.Width = 475
        '
        'col_magentoPreis
        '
        Me.col_magentoPreis.Text = "Preis"
        Me.col_magentoPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_magentoPreis.Width = 51
        '
        'col_magentoAttribut
        '
        Me.col_magentoAttribut.DisplayIndex = 4
        Me.col_magentoAttribut.Text = "Attribut"
        Me.col_magentoAttribut.Width = 0
        '
        'col_magentoType
        '
        Me.col_magentoType.DisplayIndex = 5
        Me.col_magentoType.Text = "Type"
        Me.col_magentoType.Width = 78
        '
        'col_magentoSichtbarkeit
        '
        Me.col_magentoSichtbarkeit.DisplayIndex = 3
        Me.col_magentoSichtbarkeit.Text = "Sichtbarkeit"
        Me.col_magentoSichtbarkeit.Width = 82
        '
        'col_magentoSKU
        '
        Me.col_magentoSKU.Text = "SKU"
        '
        'col_magentoStatus
        '
        Me.col_magentoStatus.Text = "Status"
        '
        'col_magentoShort
        '
        Me.col_magentoShort.Text = "Kurzbeschreibung"
        Me.col_magentoShort.Width = 0
        '
        'col_magentoLong
        '
        Me.col_magentoLong.Text = "Lange Beschreibung"
        Me.col_magentoLong.Width = 0
        '
        'cmsArtikel
        '
        Me.cmsArtikel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem1, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.SYNCYabEArtikelstammImportierenToolStripMenuItem, Me.PreisanalyseToolStripMenuItem})
        Me.cmsArtikel.Name = "cmsArtikel"
        Me.cmsArtikel.Size = New System.Drawing.Size(173, 98)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.RefreshToolStripMenuItem1.Text = "&Refresh"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.user_edit
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem1.Text = "&Bearbeiten..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'SYNCYabEArtikelstammImportierenToolStripMenuItem
        '
        Me.SYNCYabEArtikelstammImportierenToolStripMenuItem.Name = "SYNCYabEArtikelstammImportierenToolStripMenuItem"
        Me.SYNCYabEArtikelstammImportierenToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SYNCYabEArtikelstammImportierenToolStripMenuItem.Text = "YabE 2 Magento...."
        '
        'PreisanalyseToolStripMenuItem
        '
        Me.PreisanalyseToolStripMenuItem.Name = "PreisanalyseToolStripMenuItem"
        Me.PreisanalyseToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PreisanalyseToolStripMenuItem.Text = "Preisanalyse..."
        '
        'tb_ArtikelInfo
        '
        Me.tb_ArtikelInfo.Controls.Add(Me.btnNew)
        Me.tb_ArtikelInfo.Controls.Add(Me.TextBox1)
        Me.tb_ArtikelInfo.Controls.Add(Me.Label27)
        Me.tb_ArtikelInfo.Controls.Add(Me.txtItemPreis)
        Me.tb_ArtikelInfo.Controls.Add(Me.Label26)
        Me.tb_ArtikelInfo.Controls.Add(Me.txtItemLong)
        Me.tb_ArtikelInfo.Controls.Add(Me.Label25)
        Me.tb_ArtikelInfo.Controls.Add(Me.txtItemShort)
        Me.tb_ArtikelInfo.Controls.Add(Me.Label24)
        Me.tb_ArtikelInfo.Controls.Add(Me.Label23)
        Me.tb_ArtikelInfo.Controls.Add(Me.Label22)
        Me.tb_ArtikelInfo.Controls.Add(Me.cmbSichtbarkeit)
        Me.tb_ArtikelInfo.Controls.Add(Me.cmbStatus)
        Me.tb_ArtikelInfo.Controls.Add(Me.txtItemName)
        Me.tb_ArtikelInfo.Controls.Add(Me.Label21)
        Me.tb_ArtikelInfo.Location = New System.Drawing.Point(4, 22)
        Me.tb_ArtikelInfo.Name = "tb_ArtikelInfo"
        Me.tb_ArtikelInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_ArtikelInfo.Size = New System.Drawing.Size(733, 537)
        Me.tb_ArtikelInfo.TabIndex = 2
        Me.tb_ArtikelInfo.Text = "Artikel Info"
        Me.tb_ArtikelInfo.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(49, 485)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(155, 23)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "Neuer Artikel"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(178, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 21)
        Me.TextBox1.TabIndex = 13
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(175, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 13)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Attributset"
        '
        'txtItemPreis
        '
        Me.txtItemPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemPreis.Location = New System.Drawing.Point(49, 147)
        Me.txtItemPreis.Name = "txtItemPreis"
        Me.txtItemPreis.Size = New System.Drawing.Size(78, 21)
        Me.txtItemPreis.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(46, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Preis"
        '
        'txtItemLong
        '
        Me.txtItemLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemLong.Location = New System.Drawing.Point(49, 346)
        Me.txtItemLong.Multiline = True
        Me.txtItemLong.Name = "txtItemLong"
        Me.txtItemLong.Size = New System.Drawing.Size(506, 122)
        Me.txtItemLong.TabIndex = 9
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(46, 330)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(138, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Lange Beschreibung"
        '
        'txtItemShort
        '
        Me.txtItemShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemShort.Location = New System.Drawing.Point(49, 188)
        Me.txtItemShort.Multiline = True
        Me.txtItemShort.Name = "txtItemShort"
        Me.txtItemShort.Size = New System.Drawing.Size(506, 122)
        Me.txtItemShort.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(46, 172)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(124, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Kurzbeschreibung"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(334, 91)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Sichtbarkeit"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(46, 91)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Status"
        '
        'cmbSichtbarkeit
        '
        Me.cmbSichtbarkeit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSichtbarkeit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSichtbarkeit.FormattingEnabled = True
        Me.cmbSichtbarkeit.Items.AddRange(New Object() {"Einzeln nicht sichtbar", "Katalog", "Suche", "Katalog,Suche"})
        Me.cmbSichtbarkeit.Location = New System.Drawing.Point(337, 107)
        Me.cmbSichtbarkeit.Name = "cmbSichtbarkeit"
        Me.cmbSichtbarkeit.Size = New System.Drawing.Size(218, 21)
        Me.cmbSichtbarkeit.TabIndex = 3
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Aktiviert", "Inaktiv"})
        Me.cmbStatus.Location = New System.Drawing.Point(49, 107)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(218, 21)
        Me.cmbStatus.TabIndex = 2
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Location = New System.Drawing.Point(49, 56)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(506, 21)
        Me.txtItemName.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(46, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Name"
        '
        'tb_KategorieInfo
        '
        Me.tb_KategorieInfo.BackColor = System.Drawing.SystemColors.Control
        Me.tb_KategorieInfo.Controls.Add(Me.Label4)
        Me.tb_KategorieInfo.Controls.Add(Me.tab_KateInfo_sub)
        Me.tb_KategorieInfo.Controls.Add(Me.btnMagentoKategorieInfo)
        Me.tb_KategorieInfo.Controls.Add(Me.btnMagentoKategorieInfo_save)
        Me.tb_KategorieInfo.Location = New System.Drawing.Point(4, 22)
        Me.tb_KategorieInfo.Name = "tb_KategorieInfo"
        Me.tb_KategorieInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_KategorieInfo.Size = New System.Drawing.Size(733, 537)
        Me.tb_KategorieInfo.TabIndex = 1
        Me.tb_KategorieInfo.Text = "Kategorie Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 23)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Kategorie Information"
        '
        'tab_KateInfo_sub
        '
        Me.tab_KateInfo_sub.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_KateInfo_sub.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tab_KateInfo_sub.Controls.Add(Me.col_mcCat_Status)
        Me.tab_KateInfo_sub.Controls.Add(Me.col_mcCat_Beschreibung)
        Me.tab_KateInfo_sub.Controls.Add(Me.col_mcCat_xml)
        Me.tab_KateInfo_sub.Controls.Add(Me.col_mcCat_more)
        Me.tab_KateInfo_sub.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_KateInfo_sub.Location = New System.Drawing.Point(6, 44)
        Me.tab_KateInfo_sub.Name = "tab_KateInfo_sub"
        Me.tab_KateInfo_sub.SelectedIndex = 0
        Me.tab_KateInfo_sub.Size = New System.Drawing.Size(721, 460)
        Me.tab_KateInfo_sub.TabIndex = 39
        '
        'col_mcCat_Status
        '
        Me.col_mcCat_Status.Controls.Add(Me.txtMagentoCat_Sortierung)
        Me.col_mcCat_Status.Controls.Add(Me.Label20)
        Me.col_mcCat_Status.Controls.Add(Me.txtMagentoCat_Anker)
        Me.col_mcCat_Status.Controls.Add(Me.Label13)
        Me.col_mcCat_Status.Controls.Add(Me.txtMagentoCat_Aktiv)
        Me.col_mcCat_Status.Controls.Add(Me.Label12)
        Me.col_mcCat_Status.Controls.Add(Me.Label9)
        Me.col_mcCat_Status.Controls.Add(Me.Label1)
        Me.col_mcCat_Status.Controls.Add(Me.txtMagentoCat_MetaTitel)
        Me.col_mcCat_Status.Controls.Add(Me.Panel1)
        Me.col_mcCat_Status.Controls.Add(Me.txtMagentoCat_Urlkey)
        Me.col_mcCat_Status.Controls.Add(Me.txtMCCat_Name)
        Me.col_mcCat_Status.Controls.Add(Me.Label5)
        Me.col_mcCat_Status.Location = New System.Drawing.Point(4, 25)
        Me.col_mcCat_Status.Name = "col_mcCat_Status"
        Me.col_mcCat_Status.Padding = New System.Windows.Forms.Padding(3)
        Me.col_mcCat_Status.Size = New System.Drawing.Size(713, 431)
        Me.col_mcCat_Status.TabIndex = 0
        Me.col_mcCat_Status.Text = "Status & Meta"
        Me.col_mcCat_Status.UseVisualStyleBackColor = True
        '
        'txtMagentoCat_Sortierung
        '
        Me.txtMagentoCat_Sortierung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Sortierung.Location = New System.Drawing.Point(121, 168)
        Me.txtMagentoCat_Sortierung.Name = "txtMagentoCat_Sortierung"
        Me.txtMagentoCat_Sortierung.Size = New System.Drawing.Size(163, 21)
        Me.txtMagentoCat_Sortierung.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(39, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Sortierung"
        '
        'txtMagentoCat_Anker
        '
        Me.txtMagentoCat_Anker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Anker.Location = New System.Drawing.Point(121, 135)
        Me.txtMagentoCat_Anker.Name = "txtMagentoCat_Anker"
        Me.txtMagentoCat_Anker.Size = New System.Drawing.Size(127, 21)
        Me.txtMagentoCat_Anker.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(69, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Anker"
        '
        'txtMagentoCat_Aktiv
        '
        Me.txtMagentoCat_Aktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Aktiv.Location = New System.Drawing.Point(121, 108)
        Me.txtMagentoCat_Aktiv.Name = "txtMagentoCat_Aktiv"
        Me.txtMagentoCat_Aktiv.Size = New System.Drawing.Size(127, 21)
        Me.txtMagentoCat_Aktiv.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Aktiv"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Meta Titel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "URL Key"
        '
        'txtMagentoCat_MetaTitel
        '
        Me.txtMagentoCat_MetaTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_MetaTitel.Location = New System.Drawing.Point(121, 78)
        Me.txtMagentoCat_MetaTitel.Name = "txtMagentoCat_MetaTitel"
        Me.txtMagentoCat_MetaTitel.Size = New System.Drawing.Size(564, 21)
        Me.txtMagentoCat_MetaTitel.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtMagentoCat_MetaDescription)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtMagentoCat_MetaKeywords)
        Me.Panel1.Location = New System.Drawing.Point(6, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 230)
        Me.Panel1.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(15, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 37)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Meta Beschreibung"
        '
        'txtMagentoCat_MetaDescription
        '
        Me.txtMagentoCat_MetaDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_MetaDescription.Location = New System.Drawing.Point(115, 41)
        Me.txtMagentoCat_MetaDescription.Multiline = True
        Me.txtMagentoCat_MetaDescription.Name = "txtMagentoCat_MetaDescription"
        Me.txtMagentoCat_MetaDescription.Size = New System.Drawing.Size(541, 95)
        Me.txtMagentoCat_MetaDescription.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Keywords"
        '
        'txtMagentoCat_MetaKeywords
        '
        Me.txtMagentoCat_MetaKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_MetaKeywords.Location = New System.Drawing.Point(115, 14)
        Me.txtMagentoCat_MetaKeywords.Name = "txtMagentoCat_MetaKeywords"
        Me.txtMagentoCat_MetaKeywords.Size = New System.Drawing.Size(541, 21)
        Me.txtMagentoCat_MetaKeywords.TabIndex = 38
        '
        'txtMagentoCat_Urlkey
        '
        Me.txtMagentoCat_Urlkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Urlkey.Location = New System.Drawing.Point(121, 47)
        Me.txtMagentoCat_Urlkey.Name = "txtMagentoCat_Urlkey"
        Me.txtMagentoCat_Urlkey.Size = New System.Drawing.Size(127, 21)
        Me.txtMagentoCat_Urlkey.TabIndex = 33
        '
        'txtMCCat_Name
        '
        Me.txtMCCat_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMCCat_Name.Location = New System.Drawing.Point(121, 19)
        Me.txtMCCat_Name.Name = "txtMCCat_Name"
        Me.txtMCCat_Name.Size = New System.Drawing.Size(564, 21)
        Me.txtMCCat_Name.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Kategoriename"
        '
        'col_mcCat_Beschreibung
        '
        Me.col_mcCat_Beschreibung.Controls.Add(Me.txtMagentoCat_beschreibung)
        Me.col_mcCat_Beschreibung.Location = New System.Drawing.Point(4, 25)
        Me.col_mcCat_Beschreibung.Name = "col_mcCat_Beschreibung"
        Me.col_mcCat_Beschreibung.Padding = New System.Windows.Forms.Padding(3)
        Me.col_mcCat_Beschreibung.Size = New System.Drawing.Size(713, 431)
        Me.col_mcCat_Beschreibung.TabIndex = 3
        Me.col_mcCat_Beschreibung.Text = "Beschreibung"
        Me.col_mcCat_Beschreibung.UseVisualStyleBackColor = True
        '
        'txtMagentoCat_beschreibung
        '
        Me.txtMagentoCat_beschreibung.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMagentoCat_beschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_beschreibung.Location = New System.Drawing.Point(7, 34)
        Me.txtMagentoCat_beschreibung.Multiline = True
        Me.txtMagentoCat_beschreibung.Name = "txtMagentoCat_beschreibung"
        Me.txtMagentoCat_beschreibung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMagentoCat_beschreibung.Size = New System.Drawing.Size(703, 391)
        Me.txtMagentoCat_beschreibung.TabIndex = 33
        '
        'col_mcCat_xml
        '
        Me.col_mcCat_xml.Controls.Add(Me.Panel2)
        Me.col_mcCat_xml.Controls.Add(Me.txtMCCat_LayoutXML)
        Me.col_mcCat_xml.Location = New System.Drawing.Point(4, 25)
        Me.col_mcCat_xml.Name = "col_mcCat_xml"
        Me.col_mcCat_xml.Padding = New System.Windows.Forms.Padding(3)
        Me.col_mcCat_xml.Size = New System.Drawing.Size(713, 431)
        Me.col_mcCat_xml.TabIndex = 1
        Me.col_mcCat_xml.Text = "XML-Update"
        Me.col_mcCat_xml.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtMagentoCat_Anzeigemodus)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txtMagentoCat_Pagelayout)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txtMagentoCat_Apply)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtMagentoCat_layout)
        Me.Panel2.Controls.Add(Me.txtMagentoCat_Design)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtMagentoCat_DesignEnde)
        Me.Panel2.Controls.Add(Me.txtMagentoCat_DesignAktiv)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(6, 303)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(701, 125)
        Me.Panel2.TabIndex = 49
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(346, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Anzeigemodus"
        '
        'txtMagentoCat_Anzeigemodus
        '
        Me.txtMagentoCat_Anzeigemodus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Anzeigemodus.Location = New System.Drawing.Point(349, 29)
        Me.txtMagentoCat_Anzeigemodus.Name = "txtMagentoCat_Anzeigemodus"
        Me.txtMagentoCat_Anzeigemodus.Size = New System.Drawing.Size(313, 21)
        Me.txtMagentoCat_Anzeigemodus.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 13)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Page Layout"
        '
        'txtMagentoCat_Pagelayout
        '
        Me.txtMagentoCat_Pagelayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Pagelayout.Location = New System.Drawing.Point(16, 29)
        Me.txtMagentoCat_Pagelayout.Name = "txtMagentoCat_Pagelayout"
        Me.txtMagentoCat_Pagelayout.Size = New System.Drawing.Size(313, 21)
        Me.txtMagentoCat_Pagelayout.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Design - übernehmen"
        '
        'txtMagentoCat_Apply
        '
        Me.txtMagentoCat_Apply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Apply.Location = New System.Drawing.Point(16, 161)
        Me.txtMagentoCat_Apply.Name = "txtMagentoCat_Apply"
        Me.txtMagentoCat_Apply.Size = New System.Drawing.Size(313, 21)
        Me.txtMagentoCat_Apply.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Layout"
        '
        'txtMagentoCat_layout
        '
        Me.txtMagentoCat_layout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_layout.Location = New System.Drawing.Point(16, 69)
        Me.txtMagentoCat_layout.Name = "txtMagentoCat_layout"
        Me.txtMagentoCat_layout.Size = New System.Drawing.Size(313, 21)
        Me.txtMagentoCat_layout.TabIndex = 39
        '
        'txtMagentoCat_Design
        '
        Me.txtMagentoCat_Design.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_Design.Location = New System.Drawing.Point(349, 69)
        Me.txtMagentoCat_Design.Name = "txtMagentoCat_Design"
        Me.txtMagentoCat_Design.Size = New System.Drawing.Size(313, 21)
        Me.txtMagentoCat_Design.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(346, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Design - Ende bis"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(346, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Design"
        '
        'txtMagentoCat_DesignEnde
        '
        Me.txtMagentoCat_DesignEnde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_DesignEnde.Location = New System.Drawing.Point(349, 117)
        Me.txtMagentoCat_DesignEnde.Name = "txtMagentoCat_DesignEnde"
        Me.txtMagentoCat_DesignEnde.Size = New System.Drawing.Size(313, 21)
        Me.txtMagentoCat_DesignEnde.TabIndex = 45
        '
        'txtMagentoCat_DesignAktiv
        '
        Me.txtMagentoCat_DesignAktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoCat_DesignAktiv.Location = New System.Drawing.Point(16, 117)
        Me.txtMagentoCat_DesignAktiv.Name = "txtMagentoCat_DesignAktiv"
        Me.txtMagentoCat_DesignAktiv.Size = New System.Drawing.Size(313, 21)
        Me.txtMagentoCat_DesignAktiv.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Design - Aktiv vom"
        '
        'txtMCCat_LayoutXML
        '
        Me.txtMCCat_LayoutXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMCCat_LayoutXML.Location = New System.Drawing.Point(4, 6)
        Me.txtMCCat_LayoutXML.Multiline = True
        Me.txtMCCat_LayoutXML.Name = "txtMCCat_LayoutXML"
        Me.txtMCCat_LayoutXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMCCat_LayoutXML.Size = New System.Drawing.Size(703, 284)
        Me.txtMCCat_LayoutXML.TabIndex = 33
        '
        'col_mcCat_more
        '
        Me.col_mcCat_more.Controls.Add(Me.Label8)
        Me.col_mcCat_more.Controls.Add(Me.txtMCCat_ID)
        Me.col_mcCat_more.Controls.Add(Me.Label7)
        Me.col_mcCat_more.Controls.Add(Me.txtMCcat_updated)
        Me.col_mcCat_more.Controls.Add(Me.Label6)
        Me.col_mcCat_more.Controls.Add(Me.txtMCcat_erstellt)
        Me.col_mcCat_more.Controls.Add(Me.Label2)
        Me.col_mcCat_more.Controls.Add(Me.txtURLPath)
        Me.col_mcCat_more.Location = New System.Drawing.Point(4, 25)
        Me.col_mcCat_more.Name = "col_mcCat_more"
        Me.col_mcCat_more.Padding = New System.Windows.Forms.Padding(3)
        Me.col_mcCat_more.Size = New System.Drawing.Size(713, 431)
        Me.col_mcCat_more.TabIndex = 2
        Me.col_mcCat_more.Text = "Weitere Informationen"
        Me.col_mcCat_more.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Kategorie ID"
        '
        'txtMCCat_ID
        '
        Me.txtMCCat_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMCCat_ID.Location = New System.Drawing.Point(18, 90)
        Me.txtMCCat_ID.Name = "txtMCCat_ID"
        Me.txtMCCat_ID.Size = New System.Drawing.Size(145, 21)
        Me.txtMCCat_ID.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(186, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Aktuallisiert am"
        '
        'txtMCcat_updated
        '
        Me.txtMCcat_updated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMCcat_updated.Location = New System.Drawing.Point(189, 138)
        Me.txtMCcat_updated.Name = "txtMCcat_updated"
        Me.txtMCcat_updated.Size = New System.Drawing.Size(145, 21)
        Me.txtMCcat_updated.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Erzeugt am"
        '
        'txtMCcat_erstellt
        '
        Me.txtMCcat_erstellt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMCcat_erstellt.Location = New System.Drawing.Point(18, 138)
        Me.txtMCcat_erstellt.Name = "txtMCcat_erstellt"
        Me.txtMCcat_erstellt.Size = New System.Drawing.Size(145, 21)
        Me.txtMCcat_erstellt.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "URL Path"
        '
        'txtURLPath
        '
        Me.txtURLPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURLPath.Location = New System.Drawing.Point(18, 39)
        Me.txtURLPath.Name = "txtURLPath"
        Me.txtURLPath.Size = New System.Drawing.Size(667, 21)
        Me.txtURLPath.TabIndex = 37
        '
        'btnMagentoKategorieInfo
        '
        Me.btnMagentoKategorieInfo.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnMagentoKategorieInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMagentoKategorieInfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagentoKategorieInfo.Image = Global.YabE.My.Resources.Resources._24
        Me.btnMagentoKategorieInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMagentoKategorieInfo.Location = New System.Drawing.Point(13, 506)
        Me.btnMagentoKategorieInfo.Name = "btnMagentoKategorieInfo"
        Me.btnMagentoKategorieInfo.Size = New System.Drawing.Size(164, 25)
        Me.btnMagentoKategorieInfo.TabIndex = 30
        Me.btnMagentoKategorieInfo.Text = "&Einlesen"
        Me.btnMagentoKategorieInfo.UseVisualStyleBackColor = False
        '
        'btnMagentoKategorieInfo_save
        '
        Me.btnMagentoKategorieInfo_save.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnMagentoKategorieInfo_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMagentoKategorieInfo_save.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagentoKategorieInfo_save.Image = Global.YabE.My.Resources.Resources._03
        Me.btnMagentoKategorieInfo_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMagentoKategorieInfo_save.Location = New System.Drawing.Point(183, 506)
        Me.btnMagentoKategorieInfo_save.Name = "btnMagentoKategorieInfo_save"
        Me.btnMagentoKategorieInfo_save.Size = New System.Drawing.Size(164, 25)
        Me.btnMagentoKategorieInfo_save.TabIndex = 31
        Me.btnMagentoKategorieInfo_save.Text = "&Speichern"
        Me.btnMagentoKategorieInfo_save.UseVisualStyleBackColor = False
        '
        'Kunden
        '
        Me.Kunden.BackColor = System.Drawing.Color.Gainsboro
        Me.Kunden.Controls.Add(Me.TabControl1)
        Me.Kunden.Location = New System.Drawing.Point(4, 25)
        Me.Kunden.Name = "Kunden"
        Me.Kunden.Padding = New System.Windows.Forms.Padding(3)
        Me.Kunden.Size = New System.Drawing.Size(967, 588)
        Me.Kunden.TabIndex = 1
        Me.Kunden.Text = "Kunden"
        Me.Kunden.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(955, 576)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvwMagentoKunden)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(947, 550)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Magento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvwMagentoKunden
        '
        Me.lvwMagentoKunden.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMagentoKunden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMagentoKunden.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMagentoKunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMagentoKunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.magento_user_id, Me.magento_user_name, Me.magento_email, Me.magento_user_country, Me.magento_user_pwdhash, Me.magento_user_street, Me.magento_user_PLZ, Me.magento_user_Ort, Me.magento_user_Art, Me.magento_user_nachname, Me.magento_user_telefone, Me.magento_user_adressID})
        Me.lvwMagentoKunden.ContextMenuStrip = Me.cmsKunden
        Me.lvwMagentoKunden.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMagentoKunden.FullRowSelect = True
        Me.lvwMagentoKunden.GridLines = True
        Me.lvwMagentoKunden.HideSelection = False
        Me.lvwMagentoKunden.Location = New System.Drawing.Point(6, 6)
        Me.lvwMagentoKunden.MultiSelect = False
        Me.lvwMagentoKunden.Name = "lvwMagentoKunden"
        Me.lvwMagentoKunden.Size = New System.Drawing.Size(935, 538)
        Me.lvwMagentoKunden.TabIndex = 1
        Me.lvwMagentoKunden.UseCompatibleStateImageBehavior = False
        Me.lvwMagentoKunden.View = System.Windows.Forms.View.Details
        '
        'magento_user_id
        '
        Me.magento_user_id.Text = "Nr."
        Me.magento_user_id.Width = 40
        '
        'magento_user_name
        '
        Me.magento_user_name.DisplayIndex = 2
        Me.magento_user_name.Text = "Vorname"
        Me.magento_user_name.Width = 75
        '
        'magento_email
        '
        Me.magento_email.DisplayIndex = 5
        Me.magento_email.Text = "eMail"
        '
        'magento_user_country
        '
        Me.magento_user_country.DisplayIndex = 4
        Me.magento_user_country.Text = "Land"
        Me.magento_user_country.Width = 109
        '
        'magento_user_pwdhash
        '
        Me.magento_user_pwdhash.DisplayIndex = 6
        Me.magento_user_pwdhash.Text = "Benutzername"
        Me.magento_user_pwdhash.Width = 210
        '
        'magento_user_street
        '
        Me.magento_user_street.DisplayIndex = 7
        Me.magento_user_street.Text = "Straße"
        Me.magento_user_street.Width = 250
        '
        'magento_user_PLZ
        '
        Me.magento_user_PLZ.DisplayIndex = 8
        Me.magento_user_PLZ.Text = "PLZ"
        '
        'magento_user_Ort
        '
        Me.magento_user_Ort.DisplayIndex = 9
        Me.magento_user_Ort.Text = "Ort"
        '
        'magento_user_Art
        '
        Me.magento_user_Art.DisplayIndex = 1
        Me.magento_user_Art.Text = "Art"
        Me.magento_user_Art.Width = 130
        '
        'magento_user_nachname
        '
        Me.magento_user_nachname.DisplayIndex = 3
        Me.magento_user_nachname.Text = "Nachname"
        Me.magento_user_nachname.Width = 75
        '
        'magento_user_telefone
        '
        Me.magento_user_telefone.Text = "Telefone"
        '
        'magento_user_adressID
        '
        Me.magento_user_adressID.Text = "ID"
        Me.magento_user_adressID.Width = 0
        '
        'cmsKunden
        '
        Me.cmsKunden.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AktuallisierenToolStripMenuItem, Me.ToolStripSeparator2, Me.NeuToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.LöschenToolStripMenuItem})
        Me.cmsKunden.Name = "cmsKunden"
        Me.cmsKunden.Size = New System.Drawing.Size(146, 98)
        '
        'AktuallisierenToolStripMenuItem
        '
        Me.AktuallisierenToolStripMenuItem.Name = "AktuallisierenToolStripMenuItem"
        Me.AktuallisierenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AktuallisierenToolStripMenuItem.Text = "&Aktuallisieren"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(142, 6)
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_add
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NeuToolStripMenuItem.Text = "&Neu..."
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_edit
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten..."
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LöschenToolStripMenuItem.Text = "&Löschen"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvwKunden_YabE)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(947, 550)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "YabE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvwKunden_YabE
        '
        Me.lvwKunden_YabE.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwKunden_YabE.AllowColumnReorder = True
        Me.lvwKunden_YabE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwKunden_YabE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwKunden_YabE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwKunden_YabE.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kd_nachname, Me.kd_eBayName, Me.kd_eMail, Me.kd_strasse, Me.kd_PLZ, Me.kd_Ort, Me.kd_Land, Me.kd_käufe, Me.kd_Artikel, Me.kd_newsletter, Me.kd_last, Me.kd_plattform, Me.kd_sprachenliste, Me.kd_muttersprache})
        Me.lvwKunden_YabE.ContextMenuStrip = Me.cmsKunden_YabE
        Me.lvwKunden_YabE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwKunden_YabE.FullRowSelect = True
        Me.lvwKunden_YabE.GridLines = True
        Me.lvwKunden_YabE.HideSelection = False
        Me.lvwKunden_YabE.Location = New System.Drawing.Point(3, 6)
        Me.lvwKunden_YabE.MultiSelect = False
        Me.lvwKunden_YabE.Name = "lvwKunden_YabE"
        Me.lvwKunden_YabE.ShowItemToolTips = True
        Me.lvwKunden_YabE.Size = New System.Drawing.Size(938, 541)
        Me.lvwKunden_YabE.TabIndex = 1
        Me.lvwKunden_YabE.UseCompatibleStateImageBehavior = False
        Me.lvwKunden_YabE.View = System.Windows.Forms.View.Details
        '
        'kd_nachname
        '
        Me.kd_nachname.Text = "Name"
        Me.kd_nachname.Width = 116
        '
        'kd_eBayName
        '
        Me.kd_eBayName.Text = "Mitgliedsname"
        Me.kd_eBayName.Width = 150
        '
        'kd_eMail
        '
        Me.kd_eMail.Text = "Email"
        Me.kd_eMail.Width = 104
        '
        'kd_strasse
        '
        Me.kd_strasse.Text = "Strasse"
        Me.kd_strasse.Width = 100
        '
        'kd_PLZ
        '
        Me.kd_PLZ.Text = "Ort"
        Me.kd_PLZ.Width = 74
        '
        'kd_Ort
        '
        Me.kd_Ort.Text = "PLZ"
        Me.kd_Ort.Width = 103
        '
        'kd_Land
        '
        Me.kd_Land.Text = "Land"
        Me.kd_Land.Width = 172
        '
        'kd_käufe
        '
        Me.kd_käufe.Text = "Käufe"
        Me.kd_käufe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.kd_käufe.Width = 96
        '
        'kd_Artikel
        '
        Me.kd_Artikel.Text = "Artikel"
        Me.kd_Artikel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'kd_newsletter
        '
        Me.kd_newsletter.Text = "Newsletter"
        '
        'kd_last
        '
        Me.kd_last.Text = "Änderung"
        Me.kd_last.Width = 73
        '
        'kd_plattform
        '
        Me.kd_plattform.Text = "Plattform"
        Me.kd_plattform.Width = 72
        '
        'kd_sprachenliste
        '
        Me.kd_sprachenliste.Text = "Sprachenliste"
        '
        'kd_muttersprache
        '
        Me.kd_muttersprache.Text = "Muttersprache"
        '
        'cmsKunden_YabE
        '
        Me.cmsKunden_YabE.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinlesenToolStripMenuItem, Me.ToolStripSeparator3, Me.HinzufügenToolStripMenuItem, Me.ToolStripSeparator4, Me.AlleHinzufügenToolStripMenuItem})
        Me.cmsKunden_YabE.Name = "cmsKunden_YabE"
        Me.cmsKunden_YabE.Size = New System.Drawing.Size(158, 82)
        '
        'EinlesenToolStripMenuItem
        '
        Me.EinlesenToolStripMenuItem.Name = "EinlesenToolStripMenuItem"
        Me.EinlesenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EinlesenToolStripMenuItem.Text = "&Einlesen..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(154, 6)
        '
        'HinzufügenToolStripMenuItem
        '
        Me.HinzufügenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.HinzufügenToolStripMenuItem.Name = "HinzufügenToolStripMenuItem"
        Me.HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.HinzufügenToolStripMenuItem.Text = "&Hinzufügen"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(154, 6)
        '
        'AlleHinzufügenToolStripMenuItem
        '
        Me.AlleHinzufügenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.AlleHinzufügenToolStripMenuItem.Name = "AlleHinzufügenToolStripMenuItem"
        Me.AlleHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AlleHinzufügenToolStripMenuItem.Text = "&Alle hinzufügen"
        '
        'bestellungen
        '
        Me.bestellungen.Controls.Add(Me.btnBestellungen_sync)
        Me.bestellungen.Controls.Add(Me.Label28)
        Me.bestellungen.Controls.Add(Me.lvwMagento_bestellungen)
        Me.bestellungen.Location = New System.Drawing.Point(4, 25)
        Me.bestellungen.Name = "bestellungen"
        Me.bestellungen.Padding = New System.Windows.Forms.Padding(3)
        Me.bestellungen.Size = New System.Drawing.Size(967, 588)
        Me.bestellungen.TabIndex = 2
        Me.bestellungen.Text = "Bestellungen"
        Me.bestellungen.UseVisualStyleBackColor = True
        '
        'btnBestellungen_sync
        '
        Me.btnBestellungen_sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestellungen_sync.Location = New System.Drawing.Point(475, 18)
        Me.btnBestellungen_sync.Name = "btnBestellungen_sync"
        Me.btnBestellungen_sync.Size = New System.Drawing.Size(200, 23)
        Me.btnBestellungen_sync.TabIndex = 37
        Me.btnBestellungen_sync.Text = "&Bestellungen Sync"
        Me.btnBestellungen_sync.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(252, 23)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Magento Bestellungen"
        '
        'lvwMagento_bestellungen
        '
        Me.lvwMagento_bestellungen.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMagento_bestellungen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMagento_bestellungen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMagento_bestellungen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMagento_bestellungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMCBestellung_id, Me.colMCBestellung_name, Me.colMCBestellung_email, Me.colMCBestellung_ort, Me.colMCBestellung_land, Me.colMCBestellung_strasse, Me.colMCBestellung_preis, Me.colMCBestellung_beschreibung, Me.colMCBestellungen_mcid, Me.colMCBestellungen_cdatum, Me.colMcBestellungen_customerid, Me.colMCBestellungen_SKU, Me.colMCBestellung_plz})
        Me.lvwMagento_bestellungen.ContextMenuStrip = Me.cmsBestellungen
        Me.lvwMagento_bestellungen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMagento_bestellungen.FullRowSelect = True
        Me.lvwMagento_bestellungen.GridLines = True
        Me.lvwMagento_bestellungen.HideSelection = False
        Me.lvwMagento_bestellungen.Location = New System.Drawing.Point(0, 60)
        Me.lvwMagento_bestellungen.MultiSelect = False
        Me.lvwMagento_bestellungen.Name = "lvwMagento_bestellungen"
        Me.lvwMagento_bestellungen.Size = New System.Drawing.Size(967, 512)
        Me.lvwMagento_bestellungen.TabIndex = 2
        Me.lvwMagento_bestellungen.UseCompatibleStateImageBehavior = False
        Me.lvwMagento_bestellungen.View = System.Windows.Forms.View.Details
        '
        'colMCBestellung_id
        '
        Me.colMCBestellung_id.Text = "Nr."
        Me.colMCBestellung_id.Width = 40
        '
        'colMCBestellung_name
        '
        Me.colMCBestellung_name.DisplayIndex = 4
        Me.colMCBestellung_name.Text = "Name"
        Me.colMCBestellung_name.Width = 150
        '
        'colMCBestellung_email
        '
        Me.colMCBestellung_email.DisplayIndex = 6
        Me.colMCBestellung_email.Text = "eMail"
        '
        'colMCBestellung_ort
        '
        Me.colMCBestellung_ort.DisplayIndex = 7
        Me.colMCBestellung_ort.Text = "Ort"
        '
        'colMCBestellung_land
        '
        Me.colMCBestellung_land.DisplayIndex = 5
        Me.colMCBestellung_land.Text = "Land"
        Me.colMCBestellung_land.Width = 109
        '
        'colMCBestellung_strasse
        '
        Me.colMCBestellung_strasse.DisplayIndex = 8
        Me.colMCBestellung_strasse.Text = "Strasse"
        Me.colMCBestellung_strasse.Width = 210
        '
        'colMCBestellung_preis
        '
        Me.colMCBestellung_preis.DisplayIndex = 2
        Me.colMCBestellung_preis.Text = "Preis"
        '
        'colMCBestellung_beschreibung
        '
        Me.colMCBestellung_beschreibung.DisplayIndex = 3
        Me.colMCBestellung_beschreibung.Text = "Beschreibung"
        Me.colMCBestellung_beschreibung.Width = 371
        '
        'colMCBestellungen_mcid
        '
        Me.colMCBestellungen_mcid.DisplayIndex = 9
        Me.colMCBestellungen_mcid.Text = "ID"
        '
        'colMCBestellungen_cdatum
        '
        Me.colMCBestellungen_cdatum.DisplayIndex = 1
        Me.colMCBestellungen_cdatum.Text = "Datum"
        '
        'colMcBestellungen_customerid
        '
        Me.colMcBestellungen_customerid.Text = "KundenID"
        '
        'colMCBestellungen_SKU
        '
        Me.colMCBestellungen_SKU.Text = "SKU"
        '
        'cmsBestellungen
        '
        Me.cmsBestellungen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator5, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.cmsBestellungen.Name = "cmsKunden"
        Me.cmsBestellungen.Size = New System.Drawing.Size(153, 120)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "&Aktuallisieren"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.YabE.My.Resources.Resources.user_add
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "&Neu..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.YabE.My.Resources.Resources.user_edit
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "&Bearbeiten..."
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem5.Text = "&Löschen"
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(20, 9)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(201, 23)
        Me.yabe_dashboard_header.TabIndex = 35
        Me.yabe_dashboard_header.Text = "Magento Zentrale"
        '
        'colMCBestellung_plz
        '
        Me.colMCBestellung_plz.Text = "PLZ"
        '
        'frmMagentoManger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 694)
        Me.Controls.Add(Me.yabe_dashboard_header)
        Me.Controls.Add(Me.tbMagentoSub)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMagentoManger"
        Me.Text = "Magento Zugriff"
        Me.tbMagentoSub.ResumeLayout(False)
        Me.Artikel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.cmsKategorie.ResumeLayout(False)
        Me.tabMCArtikelstamm.ResumeLayout(False)
        Me.tb_Artikeliste.ResumeLayout(False)
        Me.cmsArtikel.ResumeLayout(False)
        Me.tb_ArtikelInfo.ResumeLayout(False)
        Me.tb_ArtikelInfo.PerformLayout()
        Me.tb_KategorieInfo.ResumeLayout(False)
        Me.tb_KategorieInfo.PerformLayout()
        Me.tab_KateInfo_sub.ResumeLayout(False)
        Me.col_mcCat_Status.ResumeLayout(False)
        Me.col_mcCat_Status.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.col_mcCat_Beschreibung.ResumeLayout(False)
        Me.col_mcCat_Beschreibung.PerformLayout()
        Me.col_mcCat_xml.ResumeLayout(False)
        Me.col_mcCat_xml.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.col_mcCat_more.ResumeLayout(False)
        Me.col_mcCat_more.PerformLayout()
        Me.Kunden.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.cmsKunden.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.cmsKunden_YabE.ResumeLayout(False)
        Me.bestellungen.ResumeLayout(False)
        Me.bestellungen.PerformLayout()
        Me.cmsBestellungen.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMagentoSub As System.Windows.Forms.TabControl
    Friend WithEvents Artikel As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lvwMagentoKategorie As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMagentoArtikel As System.Windows.Forms.ListView
    Friend WithEvents col_magentoID As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_magentoBeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_magentoPreis As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_magentoAttribut As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_magentoType As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_magentoSichtbarkeit As System.Windows.Forms.ColumnHeader
    Friend WithEvents Kunden As System.Windows.Forms.TabPage
    Friend WithEvents cmsKunden As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsArtikel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bestellungen As System.Windows.Forms.TabPage
    Friend WithEvents lvwMagento_bestellungen As System.Windows.Forms.ListView
    Friend WithEvents colMCBestellung_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellung_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellung_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellung_ort As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellung_land As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellung_strasse As System.Windows.Forms.ColumnHeader
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
    Friend WithEvents tabMCArtikelstamm As System.Windows.Forms.TabControl
    Friend WithEvents tb_Artikeliste As System.Windows.Forms.TabPage
    Friend WithEvents tb_KategorieInfo As System.Windows.Forms.TabPage
    Friend WithEvents btnMagentoKategorieInfo As System.Windows.Forms.Button
    Friend WithEvents btnMagentoKategorieInfo_save As System.Windows.Forms.Button
    Friend WithEvents txtMagentoCat_Urlkey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_ArtikelInfo As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tab_KateInfo_sub As System.Windows.Forms.TabControl
    Friend WithEvents col_mcCat_Status As System.Windows.Forms.TabPage
    Friend WithEvents col_mcCat_xml As System.Windows.Forms.TabPage
    Friend WithEvents txtMCCat_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMCCat_LayoutXML As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_layout As System.Windows.Forms.TextBox
    Friend WithEvents col_mcCat_more As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMCcat_updated As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMCcat_erstellt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtURLPath As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMCCat_ID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_MetaTitel As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_MetaKeywords As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_MetaDescription As System.Windows.Forms.TextBox
    Friend WithEvents col_mcCat_Beschreibung As System.Windows.Forms.TabPage
    Friend WithEvents txtMagentoCat_Aktiv As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_beschreibung As System.Windows.Forms.TextBox
    Friend WithEvents txtMagentoCat_Anker As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_Design As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_DesignEnde As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_DesignAktiv As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_Apply As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_Pagelayout As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoCat_Anzeigemodus As System.Windows.Forms.TextBox
    Friend WithEvents txtMagentoCat_Sortierung As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents col_magentoSKU As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsKategorie As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SYNCYabEArtikelstammImportierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AktuallisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvwMagentoKunden As System.Windows.Forms.ListView
    Friend WithEvents magento_user_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_country As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_pwdhash As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_street As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_PLZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_Ort As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_Art As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_nachname As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_telefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_user_adressID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvwKunden_YabE As System.Windows.Forms.ListView
    Friend WithEvents kd_nachname As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_eBayName As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_eMail As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_strasse As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_PLZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_Ort As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_Land As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_käufe As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_Artikel As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_newsletter As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_last As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_plattform As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_sprachenliste As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_muttersprache As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsKunden_YabE As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EinlesenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlleHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents col_magentoStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbSichtbarkeit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemShort As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtItemLong As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtItemPreis As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents col_magentoShort As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_magentoLong As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents PreisanalyseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YabE2MagentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colMCBestellung_preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellung_beschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBestellungen_sync As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents colMCBestellungen_mcid As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsBestellungen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colMCBestellungen_cdatum As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMcBestellungen_customerid As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellungen_SKU As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMCBestellung_plz As System.Windows.Forms.ColumnHeader
End Class
