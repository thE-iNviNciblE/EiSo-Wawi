<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutlook_sync
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutlook_sync))
        Me.tabOutlook_menue = New System.Windows.Forms.TabControl()
        Me.outlook_items = New System.Windows.Forms.TabPage()
        Me.chkAutomatisch_abrufen = New System.Windows.Forms.CheckBox()
        Me.chkHeute = New System.Windows.Forms.CheckBox()
        Me.yabe_dashboard_header = New System.Windows.Forms.Label()
        Me.btnOoutLook2Yabe = New System.Windows.Forms.Button()
        Me.optOutlook_filter_ebay = New System.Windows.Forms.RadioButton()
        Me.optOutlook_filter_delcampe = New System.Windows.Forms.RadioButton()
        Me.optOutlook_filter_alle = New System.Windows.Forms.RadioButton()
        Me.btnEmailsRead = New System.Windows.Forms.Button()
        Me.lvwOutlook_items = New System.Windows.Forms.ListView()
        Me.item_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_auctionservice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_subject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_content = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_person_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_person_street = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_person_city = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_person_zip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_item_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_item_sku = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_person_login = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_item_price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_webID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_delcampeuser_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_delcampe_mutter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_delcampe_sprachliste = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_plattformModus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_person_country = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.conOutlook_items = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DoppeltenSuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelAktivierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelBestelltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ArtikelLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WartelisteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktivToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BildAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.YABEKundenbestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABEKundendatenbanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextLesenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SucheKundenbestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikeldatenbankArtikelSuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportAnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABEBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EntferneMakierteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.outlook_contacts = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbOutlook = New System.Windows.Forms.TabPage()
        Me.lvwOutlook_contacts = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.outlook_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.outlook_Strasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.outlook_PLZ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.outlook_Ort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.outlook_Land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.outlook_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsOutlook_export_outlook = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuchenKundenbestellungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbYabe = New System.Windows.Forms.TabPage()
        Me.lvwKunden_outlook = New System.Windows.Forms.ListView()
        Me.kd_nachname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_eBayName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_eMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_strasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_PLZ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_Ort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_Land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_käufe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_Artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_newsletter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_last = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_sprachenliste = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_muttersprache = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsOutlook_export_yabe = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlleHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOutlook_contacts_sync = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMailerdeamons_ordner = New System.Windows.Forms.TextBox()
        Me.btnAbmelden = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMailerdeamon = New System.Windows.Forms.Button()
        Me.lvwMailerdeamons = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmLöschen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OutlookOrdnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DelcampeOrdnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelcampeArchivToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayArchivToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.GelöschteEmailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntwürfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.GesendeteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostausgangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeineAufgabenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KalenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunktionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelcampeKundenprofileAktullisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABEMakiereBekannteKundenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NurVerkäufeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NurBewertungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImmerImVordergrundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrOutlookSync = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOutlookSync_wait = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabOutlook_menue.SuspendLayout()
        Me.outlook_items.SuspendLayout()
        Me.conOutlook_items.SuspendLayout()
        Me.outlook_contacts.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbOutlook.SuspendLayout()
        Me.cmsOutlook_export_outlook.SuspendLayout()
        Me.tbYabe.SuspendLayout()
        Me.cmsOutlook_export_yabe.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.cmLöschen.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabOutlook_menue
        '
        Me.tabOutlook_menue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabOutlook_menue.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabOutlook_menue.Controls.Add(Me.outlook_items)
        Me.tabOutlook_menue.Controls.Add(Me.outlook_contacts)
        Me.tabOutlook_menue.Controls.Add(Me.TabPage1)
        Me.tabOutlook_menue.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOutlook_menue.HotTrack = True
        Me.tabOutlook_menue.ImageList = Me.ImageList1
        Me.tabOutlook_menue.Location = New System.Drawing.Point(0, 27)
        Me.tabOutlook_menue.Name = "tabOutlook_menue"
        Me.tabOutlook_menue.SelectedIndex = 0
        Me.tabOutlook_menue.Size = New System.Drawing.Size(1008, 600)
        Me.tabOutlook_menue.TabIndex = 15
        '
        'outlook_items
        '
        Me.outlook_items.Controls.Add(Me.chkAutomatisch_abrufen)
        Me.outlook_items.Controls.Add(Me.chkHeute)
        Me.outlook_items.Controls.Add(Me.yabe_dashboard_header)
        Me.outlook_items.Controls.Add(Me.btnOoutLook2Yabe)
        Me.outlook_items.Controls.Add(Me.optOutlook_filter_ebay)
        Me.outlook_items.Controls.Add(Me.optOutlook_filter_delcampe)
        Me.outlook_items.Controls.Add(Me.optOutlook_filter_alle)
        Me.outlook_items.Controls.Add(Me.btnEmailsRead)
        Me.outlook_items.Controls.Add(Me.lvwOutlook_items)
        Me.outlook_items.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outlook_items.ImageIndex = 3
        Me.outlook_items.Location = New System.Drawing.Point(4, 34)
        Me.outlook_items.Name = "outlook_items"
        Me.outlook_items.Padding = New System.Windows.Forms.Padding(3)
        Me.outlook_items.Size = New System.Drawing.Size(1000, 562)
        Me.outlook_items.TabIndex = 1
        Me.outlook_items.Text = "Outlook - eMail Sync"
        Me.outlook_items.UseVisualStyleBackColor = True
        '
        'chkAutomatisch_abrufen
        '
        Me.chkAutomatisch_abrufen.AutoSize = True
        Me.chkAutomatisch_abrufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAutomatisch_abrufen.Location = New System.Drawing.Point(529, 22)
        Me.chkAutomatisch_abrufen.Name = "chkAutomatisch_abrufen"
        Me.chkAutomatisch_abrufen.Size = New System.Drawing.Size(173, 21)
        Me.chkAutomatisch_abrufen.TabIndex = 37
        Me.chkAutomatisch_abrufen.Text = "Automatisch abrufen"
        Me.ToolTip1.SetToolTip(Me.chkAutomatisch_abrufen, "Ruft die Outlook Emails ab / Löschen von doppelten Delcampe Artikeln")
        Me.chkAutomatisch_abrufen.UseVisualStyleBackColor = True
        '
        'chkHeute
        '
        Me.chkHeute.AutoSize = True
        Me.chkHeute.Checked = True
        Me.chkHeute.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHeute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHeute.Location = New System.Drawing.Point(252, 22)
        Me.chkHeute.Name = "chkHeute"
        Me.chkHeute.Size = New System.Drawing.Size(316, 21)
        Me.chkHeute.TabIndex = 36
        Me.chkHeute.Text = "Emails der letzten 24 std berücksichtigen"
        Me.ToolTip1.SetToolTip(Me.chkHeute, "Emails der letzten 24 std berücksichtigen")
        Me.chkHeute.UseVisualStyleBackColor = True
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(8, 8)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(230, 29)
        Me.yabe_dashboard_header.TabIndex = 35
        Me.yabe_dashboard_header.Text = "Outlook abrufen"
        '
        'btnOoutLook2Yabe
        '
        Me.btnOoutLook2Yabe.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnOoutLook2Yabe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOoutLook2Yabe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOoutLook2Yabe.Image = Global.YabE.My.Resources.Resources._03
        Me.btnOoutLook2Yabe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOoutLook2Yabe.Location = New System.Drawing.Point(529, 45)
        Me.btnOoutLook2Yabe.Name = "btnOoutLook2Yabe"
        Me.btnOoutLook2Yabe.Size = New System.Drawing.Size(269, 23)
        Me.btnOoutLook2Yabe.TabIndex = 30
        Me.btnOoutLook2Yabe.Text = "2. &Emails übertragen"
        Me.ToolTip1.SetToolTip(Me.btnOoutLook2Yabe, "Überträgt die Artikel in die Bestellungen")
        Me.btnOoutLook2Yabe.UseVisualStyleBackColor = False
        '
        'optOutlook_filter_ebay
        '
        Me.optOutlook_filter_ebay.AutoSize = True
        Me.optOutlook_filter_ebay.Enabled = False
        Me.optOutlook_filter_ebay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optOutlook_filter_ebay.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOutlook_filter_ebay.Location = New System.Drawing.Point(174, 51)
        Me.optOutlook_filter_ebay.Name = "optOutlook_filter_ebay"
        Me.optOutlook_filter_ebay.Size = New System.Drawing.Size(66, 21)
        Me.optOutlook_filter_ebay.TabIndex = 29
        Me.optOutlook_filter_ebay.Text = "&eBay"
        Me.ToolTip1.SetToolTip(Me.optOutlook_filter_ebay, "Nur eBay Emails")
        Me.optOutlook_filter_ebay.UseVisualStyleBackColor = True
        '
        'optOutlook_filter_delcampe
        '
        Me.optOutlook_filter_delcampe.AutoSize = True
        Me.optOutlook_filter_delcampe.Checked = True
        Me.optOutlook_filter_delcampe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optOutlook_filter_delcampe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOutlook_filter_delcampe.Location = New System.Drawing.Point(80, 51)
        Me.optOutlook_filter_delcampe.Name = "optOutlook_filter_delcampe"
        Me.optOutlook_filter_delcampe.Size = New System.Drawing.Size(102, 21)
        Me.optOutlook_filter_delcampe.TabIndex = 28
        Me.optOutlook_filter_delcampe.TabStop = True
        Me.optOutlook_filter_delcampe.Text = "&Delcampe"
        Me.ToolTip1.SetToolTip(Me.optOutlook_filter_delcampe, "Nur Delcampe Emails")
        Me.optOutlook_filter_delcampe.UseVisualStyleBackColor = True
        '
        'optOutlook_filter_alle
        '
        Me.optOutlook_filter_alle.AutoSize = True
        Me.optOutlook_filter_alle.Enabled = False
        Me.optOutlook_filter_alle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optOutlook_filter_alle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOutlook_filter_alle.Location = New System.Drawing.Point(25, 51)
        Me.optOutlook_filter_alle.Name = "optOutlook_filter_alle"
        Me.optOutlook_filter_alle.Size = New System.Drawing.Size(56, 21)
        Me.optOutlook_filter_alle.TabIndex = 27
        Me.optOutlook_filter_alle.Text = "&Alle"
        Me.ToolTip1.SetToolTip(Me.optOutlook_filter_alle, "Alle Emails einlesen")
        Me.optOutlook_filter_alle.UseVisualStyleBackColor = True
        '
        'btnEmailsRead
        '
        Me.btnEmailsRead.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnEmailsRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmailsRead.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmailsRead.Image = Global.YabE.My.Resources.Resources._24
        Me.btnEmailsRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmailsRead.Location = New System.Drawing.Point(252, 45)
        Me.btnEmailsRead.Name = "btnEmailsRead"
        Me.btnEmailsRead.Size = New System.Drawing.Size(269, 23)
        Me.btnEmailsRead.TabIndex = 26
        Me.btnEmailsRead.Text = "1. Emails &abrufen"
        Me.ToolTip1.SetToolTip(Me.btnEmailsRead, "Ruft die Emails bei Outlook ab (Standardmäßig Posteingang)")
        Me.btnEmailsRead.UseVisualStyleBackColor = False
        '
        'lvwOutlook_items
        '
        Me.lvwOutlook_items.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwOutlook_items.AllowDrop = True
        Me.lvwOutlook_items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwOutlook_items.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwOutlook_items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwOutlook_items.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.item_id, Me.item_auctionservice, Me.item_email, Me.item_subject, Me.item_content, Me.item_date, Me.item_person_name, Me.item_person_street, Me.item_person_city, Me.item_person_zip, Me.item_item_name, Me.item_item_sku, Me.item_person_login, Me.item_item_price, Me.item_webID, Me.item_delcampeuser_id, Me.item_delcampe_mutter, Me.item_delcampe_sprachliste, Me.item_plattformModus, Me.item_person_country})
        Me.lvwOutlook_items.ContextMenuStrip = Me.conOutlook_items
        Me.lvwOutlook_items.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwOutlook_items.FullRowSelect = True
        Me.lvwOutlook_items.GridLines = True
        Me.lvwOutlook_items.HideSelection = False
        Me.lvwOutlook_items.Location = New System.Drawing.Point(12, 86)
        Me.lvwOutlook_items.Name = "lvwOutlook_items"
        Me.lvwOutlook_items.Size = New System.Drawing.Size(983, 470)
        Me.lvwOutlook_items.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwOutlook_items.TabIndex = 16
        Me.lvwOutlook_items.UseCompatibleStateImageBehavior = False
        Me.lvwOutlook_items.View = System.Windows.Forms.View.Details
        '
        'item_id
        '
        Me.item_id.Text = "WebID"
        Me.item_id.Width = 0
        '
        'item_auctionservice
        '
        Me.item_auctionservice.Text = "Auktionshaus"
        Me.item_auctionservice.Width = 88
        '
        'item_email
        '
        Me.item_email.Text = "eMail"
        Me.item_email.Width = 153
        '
        'item_subject
        '
        Me.item_subject.Text = "Betreff"
        Me.item_subject.Width = 0
        '
        'item_content
        '
        Me.item_content.Text = "Inhalt"
        Me.item_content.Width = 0
        '
        'item_date
        '
        Me.item_date.Text = "Datum"
        Me.item_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.item_date.Width = 53
        '
        'item_person_name
        '
        Me.item_person_name.Text = "Name"
        Me.item_person_name.Width = 112
        '
        'item_person_street
        '
        Me.item_person_street.Text = "Straße"
        Me.item_person_street.Width = 106
        '
        'item_person_city
        '
        Me.item_person_city.Text = "Stadt"
        Me.item_person_city.Width = 138
        '
        'item_person_zip
        '
        Me.item_person_zip.Text = "PLZ"
        Me.item_person_zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.item_person_zip.Width = 126
        '
        'item_item_name
        '
        Me.item_item_name.Text = "Artikelname"
        Me.item_item_name.Width = 217
        '
        'item_item_sku
        '
        Me.item_item_sku.Text = "Auktion-ID"
        Me.item_item_sku.Width = 92
        '
        'item_person_login
        '
        Me.item_person_login.Text = "Mitgliedsname"
        Me.item_person_login.Width = 0
        '
        'item_item_price
        '
        Me.item_item_price.Text = "Preis"
        Me.item_item_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.item_item_price.Width = 50
        '
        'item_webID
        '
        Me.item_webID.Text = "YABE ID"
        Me.item_webID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'item_delcampeuser_id
        '
        Me.item_delcampeuser_id.Text = "del - id"
        Me.item_delcampeuser_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'item_delcampe_mutter
        '
        Me.item_delcampe_mutter.Text = "Muttersprache"
        '
        'item_delcampe_sprachliste
        '
        Me.item_delcampe_sprachliste.Text = "Sprachliste"
        '
        'item_plattformModus
        '
        Me.item_plattformModus.Text = "Modus"
        '
        'item_person_country
        '
        Me.item_person_country.Text = "Land"
        '
        'conOutlook_items
        '
        Me.conOutlook_items.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoppeltenSuchenToolStripMenuItem, Me.MagentoToolStripMenuItem, Me.ShopToolStripMenuItem, Me.ToolStripSeparator11, Me.YABEKundenbestellungenToolStripMenuItem, Me.YABEKundendatenbanToolStripMenuItem, Me.ToolStripSeparator3, Me.TextLesenToolStripMenuItem, Me.ToolStripSeparator2, Me.SucheKundenbestellungenToolStripMenuItem, Me.ArtikeldatenbankArtikelSuchenToolStripMenuItem, Me.ToolStripSeparator1, Me.ExportAnsichtToolStripMenuItem, Me.YABEBrowserToolStripMenuItem, Me.ToolStripSeparator4, Me.EntferneMakierteToolStripMenuItem})
        Me.conOutlook_items.Name = "conOutlook_items"
        Me.conOutlook_items.Size = New System.Drawing.Size(317, 298)
        '
        'DoppeltenSuchenToolStripMenuItem
        '
        Me.DoppeltenSuchenToolStripMenuItem.Name = "DoppeltenSuchenToolStripMenuItem"
        Me.DoppeltenSuchenToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.DoppeltenSuchenToolStripMenuItem.Text = "&Doppelten Suchen..."
        '
        'MagentoToolStripMenuItem
        '
        Me.MagentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtikelAktivierenToolStripMenuItem, Me.ArtikelBestelltToolStripMenuItem, Me.ToolStripSeparator12, Me.ArtikelLöschenToolStripMenuItem})
        Me.MagentoToolStripMenuItem.Name = "MagentoToolStripMenuItem"
        Me.MagentoToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.MagentoToolStripMenuItem.Text = "Magento"
        '
        'ArtikelAktivierenToolStripMenuItem
        '
        Me.ArtikelAktivierenToolStripMenuItem.Name = "ArtikelAktivierenToolStripMenuItem"
        Me.ArtikelAktivierenToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.ArtikelAktivierenToolStripMenuItem.Text = "Artikel aktivieren"
        '
        'ArtikelBestelltToolStripMenuItem
        '
        Me.ArtikelBestelltToolStripMenuItem.Name = "ArtikelBestelltToolStripMenuItem"
        Me.ArtikelBestelltToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.ArtikelBestelltToolStripMenuItem.Text = "Artikel bestellt"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(186, 6)
        '
        'ArtikelLöschenToolStripMenuItem
        '
        Me.ArtikelLöschenToolStripMenuItem.Name = "ArtikelLöschenToolStripMenuItem"
        Me.ArtikelLöschenToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.ArtikelLöschenToolStripMenuItem.Text = "Artikel löschen"
        '
        'ShopToolStripMenuItem
        '
        Me.ShopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem1, Me.BToolStripMenuItem, Me.WartelisteToolStripMenuItem, Me.AktivToolStripMenuItem, Me.ToolStripSeparator10, Me.BildAnzeigenToolStripMenuItem})
        Me.ShopToolStripMenuItem.Name = "ShopToolStripMenuItem"
        Me.ShopToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.ShopToolStripMenuItem.Text = "Shop"
        '
        'LöschenToolStripMenuItem1
        '
        Me.LöschenToolStripMenuItem1.Name = "LöschenToolStripMenuItem1"
        Me.LöschenToolStripMenuItem1.Size = New System.Drawing.Size(168, 24)
        Me.LöschenToolStripMenuItem1.Text = "&Löschen"
        '
        'BToolStripMenuItem
        '
        Me.BToolStripMenuItem.Name = "BToolStripMenuItem"
        Me.BToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.BToolStripMenuItem.Text = "Bestellt"
        '
        'WartelisteToolStripMenuItem
        '
        Me.WartelisteToolStripMenuItem.Name = "WartelisteToolStripMenuItem"
        Me.WartelisteToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.WartelisteToolStripMenuItem.Text = "Warteliste"
        '
        'AktivToolStripMenuItem
        '
        Me.AktivToolStripMenuItem.Name = "AktivToolStripMenuItem"
        Me.AktivToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.AktivToolStripMenuItem.Text = "Aktiv"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(165, 6)
        '
        'BildAnzeigenToolStripMenuItem
        '
        Me.BildAnzeigenToolStripMenuItem.Name = "BildAnzeigenToolStripMenuItem"
        Me.BildAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.BildAnzeigenToolStripMenuItem.Text = "Bild anzeigen"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(313, 6)
        '
        'YABEKundenbestellungenToolStripMenuItem
        '
        Me.YABEKundenbestellungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._33
        Me.YABEKundenbestellungenToolStripMenuItem.Name = "YABEKundenbestellungenToolStripMenuItem"
        Me.YABEKundenbestellungenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.YABEKundenbestellungenToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.YABEKundenbestellungenToolStripMenuItem.Text = "EiSo -> Kundenbestellungen"
        '
        'YABEKundendatenbanToolStripMenuItem
        '
        Me.YABEKundendatenbanToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.YABEKundendatenbanToolStripMenuItem.Name = "YABEKundendatenbanToolStripMenuItem"
        Me.YABEKundendatenbanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.YABEKundendatenbanToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.YABEKundendatenbanToolStripMenuItem.Text = "&EiSo ->  Kundendatenbank"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(313, 6)
        '
        'TextLesenToolStripMenuItem
        '
        Me.TextLesenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.TextLesenToolStripMenuItem.Name = "TextLesenToolStripMenuItem"
        Me.TextLesenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.TextLesenToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.TextLesenToolStripMenuItem.Text = "&Email ->  &lesen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(313, 6)
        '
        'SucheKundenbestellungenToolStripMenuItem
        '
        Me.SucheKundenbestellungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheKundenbestellungenToolStripMenuItem.Name = "SucheKundenbestellungenToolStripMenuItem"
        Me.SucheKundenbestellungenToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.SucheKundenbestellungenToolStripMenuItem.Text = "Suche -> Kundenbestellungen"
        '
        'ArtikeldatenbankArtikelSuchenToolStripMenuItem
        '
        Me.ArtikeldatenbankArtikelSuchenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.ArtikeldatenbankArtikelSuchenToolStripMenuItem.Name = "ArtikeldatenbankArtikelSuchenToolStripMenuItem"
        Me.ArtikeldatenbankArtikelSuchenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ArtikeldatenbankArtikelSuchenToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.ArtikeldatenbankArtikelSuchenToolStripMenuItem.Text = "Suche -> In Artikeldatenbank"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(313, 6)
        '
        'ExportAnsichtToolStripMenuItem
        '
        Me.ExportAnsichtToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportAnsichtToolStripMenuItem.Name = "ExportAnsichtToolStripMenuItem"
        Me.ExportAnsichtToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportAnsichtToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.ExportAnsichtToolStripMenuItem.Text = "Export -> Ansicht"
        '
        'YABEBrowserToolStripMenuItem
        '
        Me.YABEBrowserToolStripMenuItem.Name = "YABEBrowserToolStripMenuItem"
        Me.YABEBrowserToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.YABEBrowserToolStripMenuItem.Text = "EiSo -> Browser"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(313, 6)
        '
        'EntferneMakierteToolStripMenuItem
        '
        Me.EntferneMakierteToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.EntferneMakierteToolStripMenuItem.Name = "EntferneMakierteToolStripMenuItem"
        Me.EntferneMakierteToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.EntferneMakierteToolStripMenuItem.Text = "Entferne -> makierte"
        '
        'outlook_contacts
        '
        Me.outlook_contacts.Controls.Add(Me.TabControl1)
        Me.outlook_contacts.Controls.Add(Me.Label1)
        Me.outlook_contacts.Controls.Add(Me.btnOutlook_contacts_sync)
        Me.outlook_contacts.ImageIndex = 3
        Me.outlook_contacts.Location = New System.Drawing.Point(4, 34)
        Me.outlook_contacts.Name = "outlook_contacts"
        Me.outlook_contacts.Padding = New System.Windows.Forms.Padding(3)
        Me.outlook_contacts.Size = New System.Drawing.Size(1000, 562)
        Me.outlook_contacts.TabIndex = 0
        Me.outlook_contacts.Text = "Outlook - Kontakte Sync"
        Me.outlook_contacts.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbOutlook)
        Me.TabControl1.Controls.Add(Me.tbYabe)
        Me.TabControl1.Location = New System.Drawing.Point(11, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(981, 484)
        Me.TabControl1.TabIndex = 36
        '
        'tbOutlook
        '
        Me.tbOutlook.Controls.Add(Me.lvwOutlook_contacts)
        Me.tbOutlook.Location = New System.Drawing.Point(4, 26)
        Me.tbOutlook.Name = "tbOutlook"
        Me.tbOutlook.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOutlook.Size = New System.Drawing.Size(973, 454)
        Me.tbOutlook.TabIndex = 0
        Me.tbOutlook.Text = "Outlook"
        Me.tbOutlook.UseVisualStyleBackColor = True
        '
        'lvwOutlook_contacts
        '
        Me.lvwOutlook_contacts.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwOutlook_contacts.AllowDrop = True
        Me.lvwOutlook_contacts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwOutlook_contacts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwOutlook_contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwOutlook_contacts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.outlook_Name, Me.outlook_Strasse, Me.outlook_PLZ, Me.outlook_Ort, Me.outlook_Land, Me.outlook_email})
        Me.lvwOutlook_contacts.ContextMenuStrip = Me.cmsOutlook_export_outlook
        Me.lvwOutlook_contacts.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwOutlook_contacts.FullRowSelect = True
        Me.lvwOutlook_contacts.GridLines = True
        Me.lvwOutlook_contacts.HideSelection = False
        Me.lvwOutlook_contacts.Location = New System.Drawing.Point(8, 14)
        Me.lvwOutlook_contacts.Name = "lvwOutlook_contacts"
        Me.lvwOutlook_contacts.Size = New System.Drawing.Size(959, 437)
        Me.lvwOutlook_contacts.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwOutlook_contacts.TabIndex = 15
        Me.lvwOutlook_contacts.UseCompatibleStateImageBehavior = False
        Me.lvwOutlook_contacts.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "WebID"
        Me.ID.Width = 0
        '
        'outlook_Name
        '
        Me.outlook_Name.Text = "Name"
        Me.outlook_Name.Width = 182
        '
        'outlook_Strasse
        '
        Me.outlook_Strasse.DisplayIndex = 3
        Me.outlook_Strasse.Text = "Straße"
        Me.outlook_Strasse.Width = 174
        '
        'outlook_PLZ
        '
        Me.outlook_PLZ.DisplayIndex = 4
        Me.outlook_PLZ.Text = "PLZ"
        '
        'outlook_Ort
        '
        Me.outlook_Ort.DisplayIndex = 5
        Me.outlook_Ort.Text = "Ort"
        Me.outlook_Ort.Width = 133
        '
        'outlook_Land
        '
        Me.outlook_Land.DisplayIndex = 6
        Me.outlook_Land.Text = "Land"
        Me.outlook_Land.Width = 174
        '
        'outlook_email
        '
        Me.outlook_email.DisplayIndex = 2
        Me.outlook_email.Text = "Email"
        Me.outlook_email.Width = 232
        '
        'cmsOutlook_export_outlook
        '
        Me.cmsOutlook_export_outlook.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuchenKundenbestellungToolStripMenuItem})
        Me.cmsOutlook_export_outlook.Name = "cmsOutlook_export_outlook"
        Me.cmsOutlook_export_outlook.Size = New System.Drawing.Size(249, 28)
        '
        'SuchenKundenbestellungToolStripMenuItem
        '
        Me.SuchenKundenbestellungToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SuchenKundenbestellungToolStripMenuItem.Name = "SuchenKundenbestellungToolStripMenuItem"
        Me.SuchenKundenbestellungToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.SuchenKundenbestellungToolStripMenuItem.Text = "&Suchen Kundenbestellung"
        '
        'tbYabe
        '
        Me.tbYabe.Controls.Add(Me.lvwKunden_outlook)
        Me.tbYabe.Location = New System.Drawing.Point(4, 26)
        Me.tbYabe.Name = "tbYabe"
        Me.tbYabe.Padding = New System.Windows.Forms.Padding(3)
        Me.tbYabe.Size = New System.Drawing.Size(973, 454)
        Me.tbYabe.TabIndex = 1
        Me.tbYabe.Text = "Yabe"
        Me.tbYabe.UseVisualStyleBackColor = True
        '
        'lvwKunden_outlook
        '
        Me.lvwKunden_outlook.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwKunden_outlook.AllowColumnReorder = True
        Me.lvwKunden_outlook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwKunden_outlook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwKunden_outlook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwKunden_outlook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kd_nachname, Me.kd_eBayName, Me.kd_eMail, Me.kd_strasse, Me.kd_PLZ, Me.kd_Ort, Me.kd_Land, Me.kd_käufe, Me.kd_Artikel, Me.kd_newsletter, Me.kd_last, Me.kd_plattform, Me.kd_sprachenliste, Me.kd_muttersprache})
        Me.lvwKunden_outlook.ContextMenuStrip = Me.cmsOutlook_export_yabe
        Me.lvwKunden_outlook.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwKunden_outlook.FullRowSelect = True
        Me.lvwKunden_outlook.GridLines = True
        Me.lvwKunden_outlook.HideSelection = False
        Me.lvwKunden_outlook.Location = New System.Drawing.Point(6, 6)
        Me.lvwKunden_outlook.MultiSelect = False
        Me.lvwKunden_outlook.Name = "lvwKunden_outlook"
        Me.lvwKunden_outlook.ShowItemToolTips = True
        Me.lvwKunden_outlook.Size = New System.Drawing.Size(961, 444)
        Me.lvwKunden_outlook.TabIndex = 17
        Me.lvwKunden_outlook.UseCompatibleStateImageBehavior = False
        Me.lvwKunden_outlook.View = System.Windows.Forms.View.Details
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
        'cmsOutlook_export_yabe
        '
        Me.cmsOutlook_export_yabe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlleHinzufügenToolStripMenuItem, Me.ToolStripSeparator9, Me.HinzufügenToolStripMenuItem})
        Me.cmsOutlook_export_yabe.Name = "cmsOutlook_export"
        Me.cmsOutlook_export_yabe.Size = New System.Drawing.Size(182, 58)
        '
        'AlleHinzufügenToolStripMenuItem
        '
        Me.AlleHinzufügenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.AlleHinzufügenToolStripMenuItem.Name = "AlleHinzufügenToolStripMenuItem"
        Me.AlleHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.AlleHinzufügenToolStripMenuItem.Text = "&Alle hinzufügen"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(178, 6)
        '
        'HinzufügenToolStripMenuItem
        '
        Me.HinzufügenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.HinzufügenToolStripMenuItem.Name = "HinzufügenToolStripMenuItem"
        Me.HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.HinzufügenToolStripMenuItem.Text = "&Hinzufügen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 29)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "YABE - Outlook Kontakte"
        '
        'btnOutlook_contacts_sync
        '
        Me.btnOutlook_contacts_sync.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOutlook_contacts_sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutlook_contacts_sync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOutlook_contacts_sync.ImageIndex = 0
        Me.btnOutlook_contacts_sync.ImageList = Me.ImageList1
        Me.btnOutlook_contacts_sync.Location = New System.Drawing.Point(520, 43)
        Me.btnOutlook_contacts_sync.Name = "btnOutlook_contacts_sync"
        Me.btnOutlook_contacts_sync.Size = New System.Drawing.Size(353, 23)
        Me.btnOutlook_contacts_sync.TabIndex = 24
        Me.btnOutlook_contacts_sync.Text = "&Outlook Kontakte Sync"
        Me.btnOutlook_contacts_sync.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "001_06.ico")
        Me.ImageList1.Images.SetKeyName(1, "001_47.ico")
        Me.ImageList1.Images.SetKeyName(2, "001_37.ico")
        Me.ImageList1.Images.SetKeyName(3, "001_44.ico")
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtMailerdeamons_ordner)
        Me.TabPage1.Controls.Add(Me.btnAbmelden)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnMailerdeamon)
        Me.TabPage1.Controls.Add(Me.lvwMailerdeamons)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 562)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Newsletter Mailerdeamons"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Outlook Ordner"
        '
        'txtMailerdeamons_ordner
        '
        Me.txtMailerdeamons_ordner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMailerdeamons_ordner.Location = New System.Drawing.Point(427, 48)
        Me.txtMailerdeamons_ordner.Name = "txtMailerdeamons_ordner"
        Me.txtMailerdeamons_ordner.Size = New System.Drawing.Size(254, 24)
        Me.txtMailerdeamons_ordner.TabIndex = 38
        '
        'btnAbmelden
        '
        Me.btnAbmelden.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAbmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbmelden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbmelden.ImageIndex = 0
        Me.btnAbmelden.ImageList = Me.ImageList1
        Me.btnAbmelden.Location = New System.Drawing.Point(843, 45)
        Me.btnAbmelden.Name = "btnAbmelden"
        Me.btnAbmelden.Size = New System.Drawing.Size(134, 23)
        Me.btnAbmelden.TabIndex = 37
        Me.btnAbmelden.Text = "&Abmelden"
        Me.btnAbmelden.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 29)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Mailer Deamons"
        '
        'btnMailerdeamon
        '
        Me.btnMailerdeamon.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMailerdeamon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMailerdeamon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMailerdeamon.ImageIndex = 0
        Me.btnMailerdeamon.ImageList = Me.ImageList1
        Me.btnMailerdeamon.Location = New System.Drawing.Point(703, 45)
        Me.btnMailerdeamon.Name = "btnMailerdeamon"
        Me.btnMailerdeamon.Size = New System.Drawing.Size(134, 23)
        Me.btnMailerdeamon.TabIndex = 25
        Me.btnMailerdeamon.Text = "&Einlesen"
        Me.btnMailerdeamon.UseVisualStyleBackColor = False
        '
        'lvwMailerdeamons
        '
        Me.lvwMailerdeamons.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMailerdeamons.AllowDrop = True
        Me.lvwMailerdeamons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMailerdeamons.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMailerdeamons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMailerdeamons.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvwMailerdeamons.ContextMenuStrip = Me.cmLöschen
        Me.lvwMailerdeamons.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMailerdeamons.FullRowSelect = True
        Me.lvwMailerdeamons.GridLines = True
        Me.lvwMailerdeamons.HideSelection = False
        Me.lvwMailerdeamons.Location = New System.Drawing.Point(18, 77)
        Me.lvwMailerdeamons.Name = "lvwMailerdeamons"
        Me.lvwMailerdeamons.Size = New System.Drawing.Size(959, 441)
        Me.lvwMailerdeamons.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwMailerdeamons.TabIndex = 16
        Me.lvwMailerdeamons.UseCompatibleStateImageBehavior = False
        Me.lvwMailerdeamons.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Emailadresse"
        Me.ColumnHeader8.Width = 230
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Grund"
        Me.ColumnHeader9.Width = 725
        '
        'cmLöschen
        '
        Me.cmLöschen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem})
        Me.cmLöschen.Name = "cmLöschen"
        Me.cmLöschen.Size = New System.Drawing.Size(132, 28)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.LöschenToolStripMenuItem.Text = "&Löschen"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(16, 17)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutlookOrdnerToolStripMenuItem, Me.FunktionenToolStripMenuItem, Me.AnsichtToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 28)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OutlookOrdnerToolStripMenuItem
        '
        Me.OutlookOrdnerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InboxToolStripMenuItem, Me.ToolStripSeparator6, Me.DelcampeOrdnerToolStripMenuItem, Me.DelcampeArchivToolStripMenuItem, Me.EBayToolStripMenuItem, Me.EBayArchivToolStripMenuItem, Me.ToolStripSeparator8, Me.GelöschteEmailsToolStripMenuItem, Me.EntwürfeToolStripMenuItem, Me.ToolStripSeparator7, Me.GesendeteToolStripMenuItem, Me.PostausgangToolStripMenuItem, Me.MeineAufgabenToolStripMenuItem, Me.KalenderToolStripMenuItem})
        Me.OutlookOrdnerToolStripMenuItem.Name = "OutlookOrdnerToolStripMenuItem"
        Me.OutlookOrdnerToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.OutlookOrdnerToolStripMenuItem.Text = "Outlook Ordner"
        '
        'InboxToolStripMenuItem
        '
        Me.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem"
        Me.InboxToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.InboxToolStripMenuItem.Text = "Outook -> Posteingang"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(278, 6)
        '
        'DelcampeOrdnerToolStripMenuItem
        '
        Me.DelcampeOrdnerToolStripMenuItem.Name = "DelcampeOrdnerToolStripMenuItem"
        Me.DelcampeOrdnerToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.DelcampeOrdnerToolStripMenuItem.Text = "&Delcampe -> Aktuelle Mails"
        '
        'DelcampeArchivToolStripMenuItem
        '
        Me.DelcampeArchivToolStripMenuItem.Name = "DelcampeArchivToolStripMenuItem"
        Me.DelcampeArchivToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.DelcampeArchivToolStripMenuItem.Text = "&Delcampe -> Archiv"
        '
        'EBayToolStripMenuItem
        '
        Me.EBayToolStripMenuItem.Name = "EBayToolStripMenuItem"
        Me.EBayToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.EBayToolStripMenuItem.Text = "&eBay -> Aktuelle Mails"
        '
        'EBayArchivToolStripMenuItem
        '
        Me.EBayArchivToolStripMenuItem.Name = "EBayArchivToolStripMenuItem"
        Me.EBayArchivToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.EBayArchivToolStripMenuItem.Text = "eBay -> Archiv"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(278, 6)
        '
        'GelöschteEmailsToolStripMenuItem
        '
        Me.GelöschteEmailsToolStripMenuItem.Name = "GelöschteEmailsToolStripMenuItem"
        Me.GelöschteEmailsToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.GelöschteEmailsToolStripMenuItem.Text = "Outlook -> Gelöschte Objekte"
        '
        'EntwürfeToolStripMenuItem
        '
        Me.EntwürfeToolStripMenuItem.Name = "EntwürfeToolStripMenuItem"
        Me.EntwürfeToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.EntwürfeToolStripMenuItem.Text = "Outlook -> Entwürfe"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(278, 6)
        '
        'GesendeteToolStripMenuItem
        '
        Me.GesendeteToolStripMenuItem.Name = "GesendeteToolStripMenuItem"
        Me.GesendeteToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.GesendeteToolStripMenuItem.Text = "Outlook -> Gesendete Objekte"
        '
        'PostausgangToolStripMenuItem
        '
        Me.PostausgangToolStripMenuItem.Name = "PostausgangToolStripMenuItem"
        Me.PostausgangToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.PostausgangToolStripMenuItem.Text = "Outlook -> Postausgang"
        '
        'MeineAufgabenToolStripMenuItem
        '
        Me.MeineAufgabenToolStripMenuItem.Name = "MeineAufgabenToolStripMenuItem"
        Me.MeineAufgabenToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.MeineAufgabenToolStripMenuItem.Text = "Outlook -> Meine Aufgaben"
        '
        'KalenderToolStripMenuItem
        '
        Me.KalenderToolStripMenuItem.Name = "KalenderToolStripMenuItem"
        Me.KalenderToolStripMenuItem.Size = New System.Drawing.Size(281, 24)
        Me.KalenderToolStripMenuItem.Text = "Outlook -> &Kalender"
        '
        'FunktionenToolStripMenuItem
        '
        Me.FunktionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelcampeKundenprofileAktullisierenToolStripMenuItem, Me.YABEMakiereBekannteKundenToolStripMenuItem})
        Me.FunktionenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.world_edit
        Me.FunktionenToolStripMenuItem.Name = "FunktionenToolStripMenuItem"
        Me.FunktionenToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.FunktionenToolStripMenuItem.Text = "Funktionen"
        '
        'DelcampeKundenprofileAktullisierenToolStripMenuItem
        '
        Me.DelcampeKundenprofileAktullisierenToolStripMenuItem.Checked = True
        Me.DelcampeKundenprofileAktullisierenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DelcampeKundenprofileAktullisierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.add_user
        Me.DelcampeKundenprofileAktullisierenToolStripMenuItem.Name = "DelcampeKundenprofileAktullisierenToolStripMenuItem"
        Me.DelcampeKundenprofileAktullisierenToolStripMenuItem.Size = New System.Drawing.Size(353, 24)
        Me.DelcampeKundenprofileAktullisierenToolStripMenuItem.Text = "&Delcampe -> Alle Kundenprofile updaten"
        '
        'YABEMakiereBekannteKundenToolStripMenuItem
        '
        Me.YABEMakiereBekannteKundenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_add
        Me.YABEMakiereBekannteKundenToolStripMenuItem.Name = "YABEMakiereBekannteKundenToolStripMenuItem"
        Me.YABEMakiereBekannteKundenToolStripMenuItem.Size = New System.Drawing.Size(353, 24)
        Me.YABEMakiereBekannteKundenToolStripMenuItem.Text = "YABE -> Makiere bekannte Kunden"
        '
        'AnsichtToolStripMenuItem
        '
        Me.AnsichtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NurVerkäufeToolStripMenuItem, Me.NurBewertungenToolStripMenuItem, Me.ToolStripSeparator5, Me.ImmerImVordergrundToolStripMenuItem, Me.TransparentToolStripMenuItem})
        Me.AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem"
        Me.AnsichtToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.AnsichtToolStripMenuItem.Text = "&Ansicht"
        '
        'NurVerkäufeToolStripMenuItem
        '
        Me.NurVerkäufeToolStripMenuItem.Enabled = False
        Me.NurVerkäufeToolStripMenuItem.Name = "NurVerkäufeToolStripMenuItem"
        Me.NurVerkäufeToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.NurVerkäufeToolStripMenuItem.Text = "&Nur Verkäufe"
        '
        'NurBewertungenToolStripMenuItem
        '
        Me.NurBewertungenToolStripMenuItem.Enabled = False
        Me.NurBewertungenToolStripMenuItem.Name = "NurBewertungenToolStripMenuItem"
        Me.NurBewertungenToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.NurBewertungenToolStripMenuItem.Text = "&Nur Bewertungen"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(227, 6)
        '
        'ImmerImVordergrundToolStripMenuItem
        '
        Me.ImmerImVordergrundToolStripMenuItem.Name = "ImmerImVordergrundToolStripMenuItem"
        Me.ImmerImVordergrundToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.ImmerImVordergrundToolStripMenuItem.Text = "Immer im Vordergrund"
        '
        'TransparentToolStripMenuItem
        '
        Me.TransparentToolStripMenuItem.Name = "TransparentToolStripMenuItem"
        Me.TransparentToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.TransparentToolStripMenuItem.Text = "Transparent"
        '
        'tmrOutlookSync
        '
        Me.tmrOutlookSync.Interval = 60000
        '
        'tmrOutlookSync_wait
        '
        Me.tmrOutlookSync_wait.Interval = 1000
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Outlook Sync"
        '
        'frmOutlook_sync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 652)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tabOutlook_menue)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmOutlook_sync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EiSo - Outlook synchronisieren"
        Me.tabOutlook_menue.ResumeLayout(False)
        Me.outlook_items.ResumeLayout(False)
        Me.outlook_items.PerformLayout()
        Me.conOutlook_items.ResumeLayout(False)
        Me.outlook_contacts.ResumeLayout(False)
        Me.outlook_contacts.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbOutlook.ResumeLayout(False)
        Me.cmsOutlook_export_outlook.ResumeLayout(False)
        Me.tbYabe.ResumeLayout(False)
        Me.cmsOutlook_export_yabe.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.cmLöschen.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabOutlook_menue As System.Windows.Forms.TabControl
    Friend WithEvents lvwOutlook_contacts As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents outlook_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents outlook_items As System.Windows.Forms.TabPage
    Friend WithEvents outlook_contacts As System.Windows.Forms.TabPage
    Friend WithEvents btnOutlook_contacts_sync As System.Windows.Forms.Button
    Friend WithEvents lvwOutlook_items As System.Windows.Forms.ListView
    Friend WithEvents item_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEmailsRead As System.Windows.Forms.Button
    Friend WithEvents item_subject As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_content As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_auctionservice As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents conOutlook_items As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TextLesenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEKundendatenbanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optOutlook_filter_ebay As System.Windows.Forms.RadioButton
    Friend WithEvents optOutlook_filter_delcampe As System.Windows.Forms.RadioButton
    Friend WithEvents optOutlook_filter_alle As System.Windows.Forms.RadioButton
    Friend WithEvents item_person_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_person_street As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_person_city As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_person_zip As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_item_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents ArtikeldatenbankArtikelSuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents item_item_sku As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_person_login As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExportAnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents item_item_price As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOoutLook2Yabe As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents item_webID As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_delcampeuser_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_delcampe_mutter As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_delcampe_sprachliste As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FunktionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelcampeKundenprofileAktullisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheKundenbestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents YABEMakiereBekannteKundenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEKundenbestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents item_plattformModus As System.Windows.Forms.ColumnHeader
    Friend WithEvents YABEBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NurVerkäufeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NurBewertungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EntferneMakierteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkHeute As System.Windows.Forms.CheckBox
    Friend WithEvents OutlookOrdnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InboxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GesendeteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelcampeOrdnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GelöschteEmailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntwürfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostausgangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeineAufgabenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KalenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelcampeArchivToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayArchivToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImmerImVordergrundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransparentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbOutlook As System.Windows.Forms.TabPage
    Friend WithEvents tbYabe As System.Windows.Forms.TabPage
    Friend WithEvents lvwKunden_outlook As System.Windows.Forms.ListView
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
    Friend WithEvents cmsOutlook_export_yabe As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AlleHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents outlook_Strasse As System.Windows.Forms.ColumnHeader
    Friend WithEvents outlook_PLZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents outlook_Ort As System.Windows.Forms.ColumnHeader
    Friend WithEvents outlook_Land As System.Windows.Forms.ColumnHeader
    Friend WithEvents outlook_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsOutlook_export_outlook As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SuchenKundenbestellungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnAbmelden As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMailerdeamon As System.Windows.Forms.Button
    Friend WithEvents lvwMailerdeamons As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMailerdeamons_ordner As System.Windows.Forms.TextBox
    Friend WithEvents cmLöschen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoppeltenSuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WartelisteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AktivToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BildAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MagentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelBestelltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelAktivierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkAutomatisch_abrufen As System.Windows.Forms.CheckBox
    Friend WithEvents tmrOutlookSync As System.Windows.Forms.Timer
    Friend WithEvents tmrOutlookSync_wait As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents item_person_country As System.Windows.Forms.ColumnHeader
End Class
