<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBestellung_Versandkosten
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBestellung_Versandkosten))
        Me.lvwArtikelListe = New System.Windows.Forms.ListView()
        Me.versand_ebayID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_Artikelbeschreibung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_endpreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_versandkosten = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_bild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_auktionsende = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_member = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_bildname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_menge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versand_eiso_orderid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.conArtikelliste = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BestellungsstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewertetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BezahltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschicktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.StorniertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ErinnerungSendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestellungArtikelNochmalVersendenliveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestellungLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BildanzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayArtikelAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EBayArtikelinformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.YABEKundenverlaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayInformationenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SucheKundenbestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheKundenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lvwKundenliste = New System.Windows.Forms.ListView()
        Me.liste_benutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.liste_artikel_anzahl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.liste_umsatz = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.liste_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.liste_delcampe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnschrift = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVersandkosten = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUmsatz = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEndbetrag = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLand = New System.Windows.Forms.TextBox()
        Me.chkPaypalMit = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMitPaypal = New System.Windows.Forms.TextBox()
        Me.chkMitRechnung = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkeBayInternational = New System.Windows.Forms.CheckBox()
        Me.lbleBayVersand = New System.Windows.Forms.LinkLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCountryCode = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmbSprachenVorlage = New System.Windows.Forms.ComboBox()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.cmbeBayVersandart = New System.Windows.Forms.ComboBox()
        Me.btnCreateOrder = New System.Windows.Forms.Button()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.lbleBayVersandkosten = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRabatt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRabattEUR = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRabattEndsumme = New System.Windows.Forms.TextBox()
        Me.txtRabattPaypal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbVersandart = New System.Windows.Forms.ComboBox()
        Me.cmsEiSoVersandkostenCMB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VersandartenÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEiSoVersandarten = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtArtikelsummeRabatt = New System.Windows.Forms.TextBox()
        Me.lblKommentar = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaveShippment = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechnungDirektAusdruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkPrintRechnung = New System.Windows.Forms.CheckBox()
        Me.lbl_kunden_stat = New System.Windows.Forms.Label()
        Me.chkBestellung_versand_MitRabatt = New System.Windows.Forms.CheckBox()
        Me.conArtikelliste.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.cmsEiSoVersandkostenCMB.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwArtikelListe
        '
        Me.lvwArtikelListe.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwArtikelListe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwArtikelListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwArtikelListe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.versand_ebayID, Me.versand_Artikelbeschreibung, Me.versand_endpreis, Me.versand_versandkosten, Me.versand_bild, Me.versand_plattform, Me.versand_status, Me.versand_auktionsende, Me.versand_email, Me.versand_member, Me.versand_bildname, Me.versand_menge, Me.versand_eiso_orderid})
        Me.lvwArtikelListe.ContextMenuStrip = Me.conArtikelliste
        Me.lvwArtikelListe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwArtikelListe.FullRowSelect = True
        Me.lvwArtikelListe.GridLines = True
        Me.lvwArtikelListe.HideSelection = False
        Me.lvwArtikelListe.LargeImageList = Me.ImageList2
        Me.lvwArtikelListe.Location = New System.Drawing.Point(8, 52)
        Me.lvwArtikelListe.Name = "lvwArtikelListe"
        Me.lvwArtikelListe.ShowItemToolTips = True
        Me.lvwArtikelListe.Size = New System.Drawing.Size(1075, 221)
        Me.lvwArtikelListe.SmallImageList = Me.ImageList2
        Me.lvwArtikelListe.TabIndex = 2
        Me.lvwArtikelListe.UseCompatibleStateImageBehavior = False
        Me.lvwArtikelListe.View = System.Windows.Forms.View.Details
        '
        'versand_ebayID
        '
        Me.versand_ebayID.Text = "Artikel ID"
        Me.versand_ebayID.Width = 120
        '
        'versand_Artikelbeschreibung
        '
        Me.versand_Artikelbeschreibung.DisplayIndex = 7
        Me.versand_Artikelbeschreibung.Text = "Artikelbeschreibung"
        Me.versand_Artikelbeschreibung.Width = 292
        '
        'versand_endpreis
        '
        Me.versand_endpreis.DisplayIndex = 5
        Me.versand_endpreis.Text = "Endpreis"
        Me.versand_endpreis.Width = 80
        '
        'versand_versandkosten
        '
        Me.versand_versandkosten.DisplayIndex = 6
        Me.versand_versandkosten.Text = "Versandkosten"
        Me.versand_versandkosten.Width = 100
        '
        'versand_bild
        '
        Me.versand_bild.DisplayIndex = 9
        Me.versand_bild.Text = "Bild"
        Me.versand_bild.Width = 267
        '
        'versand_plattform
        '
        Me.versand_plattform.DisplayIndex = 2
        Me.versand_plattform.Text = "Plattform"
        Me.versand_plattform.Width = 94
        '
        'versand_status
        '
        Me.versand_status.DisplayIndex = 8
        Me.versand_status.Text = "Status"
        '
        'versand_auktionsende
        '
        Me.versand_auktionsende.DisplayIndex = 1
        Me.versand_auktionsende.Text = "Auktionsende"
        '
        'versand_email
        '
        Me.versand_email.DisplayIndex = 10
        Me.versand_email.Text = "Email"
        '
        'versand_member
        '
        Me.versand_member.DisplayIndex = 3
        Me.versand_member.Text = "Member"
        '
        'versand_bildname
        '
        Me.versand_bildname.DisplayIndex = 11
        Me.versand_bildname.Text = "Bild"
        '
        'versand_menge
        '
        Me.versand_menge.DisplayIndex = 4
        Me.versand_menge.Text = "Menge"
        '
        'versand_eiso_orderid
        '
        Me.versand_eiso_orderid.Text = "EiSo Orderlist ID"
        '
        'conArtikelliste
        '
        Me.conArtikelliste.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BestellungsstatusToolStripMenuItem, Me.BestellungArtikelNochmalVersendenliveToolStripMenuItem, Me.BestellungLöschenToolStripMenuItem, Me.ToolStripSeparator2, Me.BildanzeigenToolStripMenuItem, Me.EBayArtikelAnzeigenToolStripMenuItem, Me.ToolStripSeparator3, Me.EBayArtikelinformationToolStripMenuItem})
        Me.conArtikelliste.Name = "ContextMenuStrip1"
        Me.conArtikelliste.Size = New System.Drawing.Size(319, 148)
        '
        'BestellungsstatusToolStripMenuItem
        '
        Me.BestellungsstatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BewertetToolStripMenuItem, Me.BezahltToolStripMenuItem, Me.VerschicktToolStripMenuItem, Me.CompleteToolStripMenuItem, Me.ToolStripSeparator28, Me.StorniertToolStripMenuItem, Me.ToolStripSeparator17, Me.ErinnerungSendenToolStripMenuItem})
        Me.BestellungsstatusToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.time_go
        Me.BestellungsstatusToolStripMenuItem.Name = "BestellungsstatusToolStripMenuItem"
        Me.BestellungsstatusToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.BestellungsstatusToolStripMenuItem.Text = "EiSo -> Bestellungsstatus"
        '
        'BewertetToolStripMenuItem
        '
        Me.BewertetToolStripMenuItem.Name = "BewertetToolStripMenuItem"
        Me.BewertetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.BewertetToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.BewertetToolStripMenuItem.Text = "&Bestellt"
        '
        'BezahltToolStripMenuItem
        '
        Me.BezahltToolStripMenuItem.Name = "BezahltToolStripMenuItem"
        Me.BezahltToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BezahltToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.BezahltToolStripMenuItem.Text = "&Bezahlt"
        '
        'VerschicktToolStripMenuItem
        '
        Me.VerschicktToolStripMenuItem.Name = "VerschicktToolStripMenuItem"
        Me.VerschicktToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.VerschicktToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.VerschicktToolStripMenuItem.Text = "&Verschickt"
        '
        'CompleteToolStripMenuItem
        '
        Me.CompleteToolStripMenuItem.Name = "CompleteToolStripMenuItem"
        Me.CompleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.CompleteToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CompleteToolStripMenuItem.Text = "&Komplett"
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(219, 6)
        '
        'StorniertToolStripMenuItem
        '
        Me.StorniertToolStripMenuItem.Name = "StorniertToolStripMenuItem"
        Me.StorniertToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.StorniertToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.StorniertToolStripMenuItem.Text = "&Storniert"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(219, 6)
        '
        'ErinnerungSendenToolStripMenuItem
        '
        Me.ErinnerungSendenToolStripMenuItem.Enabled = False
        Me.ErinnerungSendenToolStripMenuItem.Name = "ErinnerungSendenToolStripMenuItem"
        Me.ErinnerungSendenToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ErinnerungSendenToolStripMenuItem.Text = "Zahlungserinnerung senden"
        '
        'BestellungArtikelNochmalVersendenliveToolStripMenuItem
        '
        Me.BestellungArtikelNochmalVersendenliveToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.email3
        Me.BestellungArtikelNochmalVersendenliveToolStripMenuItem.Name = "BestellungArtikelNochmalVersendenliveToolStripMenuItem"
        Me.BestellungArtikelNochmalVersendenliveToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.BestellungArtikelNochmalVersendenliveToolStripMenuItem.Text = "Bestellung -> Artikel nochmal versenden (live)"
        '
        'BestellungLöschenToolStripMenuItem
        '
        Me.BestellungLöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.delete
        Me.BestellungLöschenToolStripMenuItem.Name = "BestellungLöschenToolStripMenuItem"
        Me.BestellungLöschenToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.BestellungLöschenToolStripMenuItem.Text = "Bestellung -> Löschen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(315, 6)
        '
        'BildanzeigenToolStripMenuItem
        '
        Me.BildanzeigenToolStripMenuItem.Name = "BildanzeigenToolStripMenuItem"
        Me.BildanzeigenToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.BildanzeigenToolStripMenuItem.Text = "Artikel -> &Bild anzeigen"
        '
        'EBayArtikelAnzeigenToolStripMenuItem
        '
        Me.EBayArtikelAnzeigenToolStripMenuItem.Name = "EBayArtikelAnzeigenToolStripMenuItem"
        Me.EBayArtikelAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.EBayArtikelAnzeigenToolStripMenuItem.Text = "Artikel -> &anzeigen"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(315, 6)
        '
        'EBayArtikelinformationToolStripMenuItem
        '
        Me.EBayArtikelinformationToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.EBayArtikelinformationToolStripMenuItem.Name = "EBayArtikelinformationToolStripMenuItem"
        Me.EBayArtikelinformationToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.EBayArtikelinformationToolStripMenuItem.Text = "eBay Artikelinformation"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(60, 60)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "001_01.ico")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kundeninformation"
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBenutzername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBenutzername.Location = New System.Drawing.Point(149, 309)
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(245, 21)
        Me.txtBenutzername.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Emailadresse"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtEmail.Location = New System.Drawing.Point(149, 336)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(245, 21)
        Me.txtEmail.TabIndex = 15
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YABEKundenverlaufToolStripMenuItem, Me.EBayInformationenToolStripMenuItem, Me.ToolStripSeparator1, Me.SucheKundenbestellungenToolStripMenuItem, Me.SucheKundenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(235, 98)
        '
        'YABEKundenverlaufToolStripMenuItem
        '
        Me.YABEKundenverlaufToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.YABEKundenverlaufToolStripMenuItem.Name = "YABEKundenverlaufToolStripMenuItem"
        Me.YABEKundenverlaufToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.YABEKundenverlaufToolStripMenuItem.Text = "EiSo -> Kundenverlauf"
        '
        'EBayInformationenToolStripMenuItem
        '
        Me.EBayInformationenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.EBayInformationenToolStripMenuItem.Name = "EBayInformationenToolStripMenuItem"
        Me.EBayInformationenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.EBayInformationenToolStripMenuItem.Text = "eBay -> Informationen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(231, 6)
        '
        'SucheKundenbestellungenToolStripMenuItem
        '
        Me.SucheKundenbestellungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheKundenbestellungenToolStripMenuItem.Name = "SucheKundenbestellungenToolStripMenuItem"
        Me.SucheKundenbestellungenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SucheKundenbestellungenToolStripMenuItem.Text = "Suche -> Kundenbestellungen"
        '
        'SucheKundenToolStripMenuItem
        '
        Me.SucheKundenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheKundenToolStripMenuItem.Name = "SucheKundenToolStripMenuItem"
        Me.SucheKundenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SucheKundenToolStripMenuItem.Text = "Suche -> Kunden"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(354, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Gekaufte Artikel vom selektierten Mitglied"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(769, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(314, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Weitere Versandkosten berechnen"
        '
        'lvwKundenliste
        '
        Me.lvwKundenliste.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwKundenliste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwKundenliste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwKundenliste.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.liste_benutzername, Me.liste_artikel_anzahl, Me.liste_umsatz, Me.liste_email, Me.liste_delcampe})
        Me.lvwKundenliste.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwKundenliste.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwKundenliste.FullRowSelect = True
        Me.lvwKundenliste.GridLines = True
        Me.lvwKundenliste.HideSelection = False
        Me.lvwKundenliste.Location = New System.Drawing.Point(768, 309)
        Me.lvwKundenliste.MultiSelect = False
        Me.lvwKundenliste.Name = "lvwKundenliste"
        Me.lvwKundenliste.Size = New System.Drawing.Size(320, 418)
        Me.lvwKundenliste.TabIndex = 0
        Me.lvwKundenliste.UseCompatibleStateImageBehavior = False
        Me.lvwKundenliste.View = System.Windows.Forms.View.Details
        '
        'liste_benutzername
        '
        Me.liste_benutzername.Text = "Benutzername"
        Me.liste_benutzername.Width = 106
        '
        'liste_artikel_anzahl
        '
        Me.liste_artikel_anzahl.Text = "Anzahl"
        Me.liste_artikel_anzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.liste_artikel_anzahl.Width = 75
        '
        'liste_umsatz
        '
        Me.liste_umsatz.Text = "Umsatz"
        Me.liste_umsatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.liste_umsatz.Width = 129
        '
        'liste_email
        '
        Me.liste_email.Text = "Email"
        Me.liste_email.Width = 0
        '
        'liste_delcampe
        '
        Me.liste_delcampe.Text = "ID"
        Me.liste_delcampe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.liste_delcampe.Width = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Anschrift"
        '
        'txtAnschrift
        '
        Me.txtAnschrift.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAnschrift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnschrift.Location = New System.Drawing.Point(400, 363)
        Me.txtAnschrift.Name = "txtAnschrift"
        Me.txtAnschrift.Size = New System.Drawing.Size(314, 21)
        Me.txtAnschrift.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 556)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Versandkosten"
        '
        'txtVersandkosten
        '
        Me.txtVersandkosten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVersandkosten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersandkosten.Location = New System.Drawing.Point(148, 554)
        Me.txtVersandkosten.Name = "txtVersandkosten"
        Me.txtVersandkosten.Size = New System.Drawing.Size(63, 21)
        Me.txtVersandkosten.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 499)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Artikelumsatz"
        '
        'txtUmsatz
        '
        Me.txtUmsatz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUmsatz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUmsatz.Enabled = False
        Me.txtUmsatz.Location = New System.Drawing.Point(148, 497)
        Me.txtUmsatz.Name = "txtUmsatz"
        Me.txtUmsatz.Size = New System.Drawing.Size(63, 21)
        Me.txtUmsatz.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 585)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Endsumme"
        '
        'txtEndbetrag
        '
        Me.txtEndbetrag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEndbetrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndbetrag.Location = New System.Drawing.Point(148, 583)
        Me.txtEndbetrag.Name = "txtEndbetrag"
        Me.txtEndbetrag.Size = New System.Drawing.Size(63, 21)
        Me.txtEndbetrag.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(245, 18)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Versandkostenberechnung"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(105, 392)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Land"
        '
        'txtLand
        '
        Me.txtLand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLand.Location = New System.Drawing.Point(149, 390)
        Me.txtLand.Name = "txtLand"
        Me.txtLand.Size = New System.Drawing.Size(245, 21)
        Me.txtLand.TabIndex = 30
        '
        'chkPaypalMit
        '
        Me.chkPaypalMit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkPaypalMit.AutoSize = True
        Me.chkPaypalMit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPaypalMit.Location = New System.Drawing.Point(148, 610)
        Me.chkPaypalMit.Name = "chkPaypalMit"
        Me.chkPaypalMit.Size = New System.Drawing.Size(109, 17)
        Me.chkPaypalMit.TabIndex = 3
        Me.chkPaypalMit.Text = "Mit Paypal-Link"
        Me.chkPaypalMit.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 635)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Paypal Endsumme"
        '
        'txtMitPaypal
        '
        Me.txtMitPaypal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMitPaypal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMitPaypal.Enabled = False
        Me.txtMitPaypal.Location = New System.Drawing.Point(148, 633)
        Me.txtMitPaypal.Name = "txtMitPaypal"
        Me.txtMitPaypal.Size = New System.Drawing.Size(63, 21)
        Me.txtMitPaypal.TabIndex = 34
        '
        'chkMitRechnung
        '
        Me.chkMitRechnung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkMitRechnung.AutoSize = True
        Me.chkMitRechnung.Enabled = False
        Me.chkMitRechnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMitRechnung.Location = New System.Drawing.Point(148, 663)
        Me.chkMitRechnung.Name = "chkMitRechnung"
        Me.chkMitRechnung.Size = New System.Drawing.Size(145, 17)
        Me.chkMitRechnung.TabIndex = 36
        Me.chkMitRechnung.Text = "Mit Rechnung als PDF"
        Me.chkMitRechnung.UseVisualStyleBackColor = True
        Me.chkMitRechnung.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 781)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1100, 22)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'chkeBayInternational
        '
        Me.chkeBayInternational.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkeBayInternational.AutoSize = True
        Me.chkeBayInternational.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkeBayInternational.Location = New System.Drawing.Point(409, 442)
        Me.chkeBayInternational.Name = "chkeBayInternational"
        Me.chkeBayInternational.Size = New System.Drawing.Size(158, 17)
        Me.chkeBayInternational.TabIndex = 39
        Me.chkeBayInternational.Text = "Internationaler Versand"
        Me.chkeBayInternational.UseVisualStyleBackColor = True
        '
        'lbleBayVersand
        '
        Me.lbleBayVersand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbleBayVersand.AutoSize = True
        Me.lbleBayVersand.Location = New System.Drawing.Point(373, 714)
        Me.lbleBayVersand.Name = "lbleBayVersand"
        Me.lbleBayVersand.Size = New System.Drawing.Size(86, 13)
        Me.lbleBayVersand.TabIndex = 40
        Me.lbleBayVersand.TabStop = True
        Me.lbleBayVersand.Text = "eBay Versand"
        Me.lbleBayVersand.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(37, 686)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Email Sprache"
        '
        'txtCountryCode
        '
        Me.txtCountryCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCountryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountryCode.Location = New System.Drawing.Point(143, 686)
        Me.txtCountryCode.Name = "txtCountryCode"
        Me.txtCountryCode.Size = New System.Drawing.Size(96, 21)
        Me.txtCountryCode.TabIndex = 41
        Me.txtCountryCode.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(140, 714)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(217, 13)
        Me.LinkLabel1.TabIndex = 43
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "eBay Versandkosten erfassen (WEB)"
        '
        'cmbSprachenVorlage
        '
        Me.cmbSprachenVorlage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbSprachenVorlage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprachenVorlage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprachenVorlage.FormattingEnabled = True
        Me.cmbSprachenVorlage.Location = New System.Drawing.Point(143, 686)
        Me.cmbSprachenVorlage.Name = "cmbSprachenVorlage"
        Me.cmbSprachenVorlage.Size = New System.Drawing.Size(172, 21)
        Me.cmbSprachenVorlage.TabIndex = 44
        '
        'txtOrt
        '
        Me.txtOrt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrt.Location = New System.Drawing.Point(149, 363)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(245, 21)
        Me.txtOrt.TabIndex = 45
        '
        'cmbeBayVersandart
        '
        Me.cmbeBayVersandart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbeBayVersandart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbeBayVersandart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbeBayVersandart.FormattingEnabled = True
        Me.cmbeBayVersandart.Location = New System.Drawing.Point(148, 439)
        Me.cmbeBayVersandart.Name = "cmbeBayVersandart"
        Me.cmbeBayVersandart.Size = New System.Drawing.Size(250, 21)
        Me.cmbeBayVersandart.TabIndex = 46
        '
        'btnCreateOrder
        '
        Me.btnCreateOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateOrder.Location = New System.Drawing.Point(513, 490)
        Me.btnCreateOrder.Name = "btnCreateOrder"
        Me.btnCreateOrder.Size = New System.Drawing.Size(196, 28)
        Me.btnCreateOrder.TabIndex = 47
        Me.btnCreateOrder.Text = "Zusammenfassen"
        Me.btnCreateOrder.UseVisualStyleBackColor = True
        Me.btnCreateOrder.Visible = False
        '
        'txtOrderID
        '
        Me.txtOrderID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderID.Enabled = False
        Me.txtOrderID.Location = New System.Drawing.Point(513, 524)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(129, 21)
        Me.txtOrderID.TabIndex = 48
        Me.txtOrderID.Visible = False
        '
        'lbleBayVersandkosten
        '
        Me.lbleBayVersandkosten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbleBayVersandkosten.AutoSize = True
        Me.lbleBayVersandkosten.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleBayVersandkosten.Location = New System.Drawing.Point(27, 447)
        Me.lbleBayVersandkosten.Name = "lbleBayVersandkosten"
        Me.lbleBayVersandkosten.Size = New System.Drawing.Size(115, 13)
        Me.lbleBayVersandkosten.TabIndex = 49
        Me.lbleBayVersandkosten.Text = "eBay Versandart"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(402, 392)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(104, 13)
        Me.LinkLabel2.TabIndex = 124
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Kunden editieren"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(88, 525)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "Rabatt"
        '
        'txtRabatt
        '
        Me.txtRabatt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRabatt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRabatt.Location = New System.Drawing.Point(149, 523)
        Me.txtRabatt.Name = "txtRabatt"
        Me.txtRabatt.Size = New System.Drawing.Size(63, 21)
        Me.txtRabatt.TabIndex = 125
        Me.txtRabatt.Text = "0"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(218, 527)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "%"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(473, 526)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 130
        Me.Label17.Text = "EUR"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(349, 524)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "Rabatt"
        Me.Label18.Visible = False
        '
        'txtRabattEUR
        '
        Me.txtRabattEUR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRabattEUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRabattEUR.Enabled = False
        Me.txtRabattEUR.Location = New System.Drawing.Point(404, 522)
        Me.txtRabattEUR.Name = "txtRabattEUR"
        Me.txtRabattEUR.Size = New System.Drawing.Size(63, 21)
        Me.txtRabattEUR.TabIndex = 128
        Me.txtRabattEUR.Text = "0"
        Me.txtRabattEUR.Visible = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(473, 584)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "EUR"
        Me.Label19.Visible = False
        '
        'txtRabattEndsumme
        '
        Me.txtRabattEndsumme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRabattEndsumme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRabattEndsumme.Location = New System.Drawing.Point(404, 582)
        Me.txtRabattEndsumme.Name = "txtRabattEndsumme"
        Me.txtRabattEndsumme.Size = New System.Drawing.Size(63, 21)
        Me.txtRabattEndsumme.TabIndex = 131
        Me.txtRabattEndsumme.Text = "0"
        Me.txtRabattEndsumme.Visible = False
        '
        'txtRabattPaypal
        '
        Me.txtRabattPaypal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRabattPaypal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRabattPaypal.Enabled = False
        Me.txtRabattPaypal.Location = New System.Drawing.Point(404, 632)
        Me.txtRabattPaypal.Name = "txtRabattPaypal"
        Me.txtRabattPaypal.Size = New System.Drawing.Size(63, 21)
        Me.txtRabattPaypal.TabIndex = 134
        Me.txtRabattPaypal.Visible = False
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(309, 634)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 135
        Me.Label21.Text = "Paypal Rabatt"
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(474, 634)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 13)
        Me.Label22.TabIndex = 136
        Me.Label22.Text = "EUR"
        Me.Label22.Visible = False
        '
        'cmbVersandart
        '
        Me.cmbVersandart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbVersandart.ContextMenuStrip = Me.cmsEiSoVersandkostenCMB
        Me.cmbVersandart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVersandart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVersandart.FormattingEnabled = True
        Me.cmbVersandart.Location = New System.Drawing.Point(148, 466)
        Me.cmbVersandart.Name = "cmbVersandart"
        Me.cmbVersandart.Size = New System.Drawing.Size(250, 21)
        Me.cmbVersandart.TabIndex = 137
        '
        'cmsEiSoVersandkostenCMB
        '
        Me.cmsEiSoVersandkostenCMB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersandartenÖffnenToolStripMenuItem})
        Me.cmsEiSoVersandkostenCMB.Name = "cmsEiSoVersandkostenCMB"
        Me.cmsEiSoVersandkostenCMB.Size = New System.Drawing.Size(190, 26)
        '
        'VersandartenÖffnenToolStripMenuItem
        '
        Me.VersandartenÖffnenToolStripMenuItem.Name = "VersandartenÖffnenToolStripMenuItem"
        Me.VersandartenÖffnenToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VersandartenÖffnenToolStripMenuItem.Text = "Versandarten öffnen..."
        '
        'lblEiSoVersandarten
        '
        Me.lblEiSoVersandarten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEiSoVersandarten.AutoSize = True
        Me.lblEiSoVersandarten.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEiSoVersandarten.Location = New System.Drawing.Point(31, 469)
        Me.lblEiSoVersandarten.Name = "lblEiSoVersandarten"
        Me.lblEiSoVersandarten.Size = New System.Drawing.Size(111, 13)
        Me.lblEiSoVersandarten.TabIndex = 138
        Me.lblEiSoVersandarten.Text = "EiSo Versandart"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(473, 501)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 141
        Me.Label24.Text = "EUR"
        Me.Label24.Visible = False
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(349, 499)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 13)
        Me.Label25.TabIndex = 140
        Me.Label25.Text = "Rabatt"
        Me.Label25.Visible = False
        '
        'txtArtikelsummeRabatt
        '
        Me.txtArtikelsummeRabatt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtArtikelsummeRabatt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArtikelsummeRabatt.Enabled = False
        Me.txtArtikelsummeRabatt.Location = New System.Drawing.Point(404, 497)
        Me.txtArtikelsummeRabatt.Name = "txtArtikelsummeRabatt"
        Me.txtArtikelsummeRabatt.Size = New System.Drawing.Size(63, 21)
        Me.txtArtikelsummeRabatt.TabIndex = 139
        Me.txtArtikelsummeRabatt.Visible = False
        '
        'lblKommentar
        '
        Me.lblKommentar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblKommentar.AutoSize = True
        Me.lblKommentar.Location = New System.Drawing.Point(319, 690)
        Me.lblKommentar.Name = "lblKommentar"
        Me.lblKommentar.Size = New System.Drawing.Size(272, 13)
        Me.lblKommentar.TabIndex = 142
        Me.lblKommentar.TabStop = True
        Me.lblKommentar.Text = "Freitext Kommentar zur Bestellung hinzufügen"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(261, 585)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(133, 13)
        Me.LinkLabel3.TabIndex = 143
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Endsumme mit Rabatt"
        Me.LinkLabel3.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(565, 755)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(197, 23)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "S&chließen"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSaveShippment
        '
        Me.btnSaveShippment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveShippment.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnSaveShippment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveShippment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveShippment.Image = Global.YabE.My.Resources.Resources._24
        Me.btnSaveShippment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveShippment.Location = New System.Drawing.Point(8, 755)
        Me.btnSaveShippment.Name = "btnSaveShippment"
        Me.btnSaveShippment.Size = New System.Drawing.Size(541, 23)
        Me.btnSaveShippment.TabIndex = 4
        Me.btnSaveShippment.Text = "&Versandkosten speichern"
        Me.btnSaveShippment.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1100, 24)
        Me.MenuStrip1.TabIndex = 144
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechnungDirektAusdruckenToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'RechnungDirektAusdruckenToolStripMenuItem
        '
        Me.RechnungDirektAusdruckenToolStripMenuItem.Name = "RechnungDirektAusdruckenToolStripMenuItem"
        Me.RechnungDirektAusdruckenToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.RechnungDirektAusdruckenToolStripMenuItem.Text = "Rechnung erstellen"
        '
        'chkPrintRechnung
        '
        Me.chkPrintRechnung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkPrintRechnung.AutoSize = True
        Me.chkPrintRechnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPrintRechnung.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintRechnung.Location = New System.Drawing.Point(8, 730)
        Me.chkPrintRechnung.Name = "chkPrintRechnung"
        Me.chkPrintRechnung.Size = New System.Drawing.Size(148, 17)
        Me.chkPrintRechnung.TabIndex = 145
        Me.chkPrintRechnung.Text = "Rechnung erstellen"
        Me.chkPrintRechnung.UseVisualStyleBackColor = True
        '
        'lbl_kunden_stat
        '
        Me.lbl_kunden_stat.AutoSize = True
        Me.lbl_kunden_stat.Location = New System.Drawing.Point(406, 288)
        Me.lbl_kunden_stat.Name = "lbl_kunden_stat"
        Me.lbl_kunden_stat.Size = New System.Drawing.Size(19, 13)
        Me.lbl_kunden_stat.TabIndex = 146
        Me.lbl_kunden_stat.Text = "..."
        '
        'chkBestellung_versand_MitRabatt
        '
        Me.chkBestellung_versand_MitRabatt.AutoSize = True
        Me.chkBestellung_versand_MitRabatt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBestellung_versand_MitRabatt.Location = New System.Drawing.Point(173, 732)
        Me.chkBestellung_versand_MitRabatt.Name = "chkBestellung_versand_MitRabatt"
        Me.chkBestellung_versand_MitRabatt.Size = New System.Drawing.Size(221, 17)
        Me.chkBestellung_versand_MitRabatt.TabIndex = 147
        Me.chkBestellung_versand_MitRabatt.Text = "Bestellung mit Rabatt anlegen"
        Me.chkBestellung_versand_MitRabatt.UseVisualStyleBackColor = True
        '
        'frmBestellung_Versandkosten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1100, 803)
        Me.Controls.Add(Me.chkBestellung_versand_MitRabatt)
        Me.Controls.Add(Me.lbl_kunden_stat)
        Me.Controls.Add(Me.chkPrintRechnung)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.lblKommentar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtArtikelsummeRabatt)
        Me.Controls.Add(Me.cmbVersandart)
        Me.Controls.Add(Me.lblEiSoVersandarten)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtRabattPaypal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtRabattEndsumme)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtRabattEUR)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtRabatt)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.cmbeBayVersandart)
        Me.Controls.Add(Me.lbleBayVersandkosten)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.btnCreateOrder)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.cmbSprachenVorlage)
        Me.Controls.Add(Me.lvwKundenliste)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCountryCode)
        Me.Controls.Add(Me.chkeBayInternational)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbleBayVersand)
        Me.Controls.Add(Me.lvwArtikelListe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtMitPaypal)
        Me.Controls.Add(Me.chkMitRechnung)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkPaypalMit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLand)
        Me.Controls.Add(Me.txtEndbetrag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUmsatz)
        Me.Controls.Add(Me.txtAnschrift)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVersandkosten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSaveShippment)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBestellung_Versandkosten"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo Verkaufsabwicklung - Versandkosten + Rechnung stellen"
        Me.conArtikelliste.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.cmsEiSoVersandkostenCMB.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwArtikelListe As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtBenutzername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvwKundenliste As System.Windows.Forms.ListView
    Friend WithEvents liste_benutzername As System.Windows.Forms.ColumnHeader
    Friend WithEvents liste_artikel_anzahl As System.Windows.Forms.ColumnHeader
    Friend WithEvents versand_Artikelbeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents versand_versandkosten As System.Windows.Forms.ColumnHeader
    Friend WithEvents versand_endpreis As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtAnschrift As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txtVersandkosten As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveShippment As System.Windows.Forms.Button
    Friend WithEvents liste_umsatz As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtUmsatz As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txtEndbetrag As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents versand_ebayID As System.Windows.Forms.ColumnHeader
    Friend WithEvents conArtikelliste As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents versand_bild As System.Windows.Forms.ColumnHeader
    Friend WithEvents BildanzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayArtikelAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtLand As System.Windows.Forms.TextBox
    Friend WithEvents chkPaypalMit As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtMitPaypal As System.Windows.Forms.TextBox
    Friend WithEvents chkMitRechnung As System.Windows.Forms.CheckBox
    Friend WithEvents versand_plattform As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents YABEKundenverlaufToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents versand_status As System.Windows.Forms.ColumnHeader
    Friend WithEvents versand_auktionsende As System.Windows.Forms.ColumnHeader
    Friend WithEvents SucheKundenbestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayInformationenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BestellungsstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BewertetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BezahltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschicktToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StorniertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErinnerungSendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SucheKundenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestellungLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BestellungArtikelNochmalVersendenliveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkeBayInternational As System.Windows.Forms.CheckBox
    Friend WithEvents lbleBayVersand As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EBayArtikelinformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtCountryCode As System.Windows.Forms.TextBox
    Friend WithEvents liste_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents liste_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbSprachenVorlage As System.Windows.Forms.ComboBox
    Public WithEvents txtOrt As System.Windows.Forms.TextBox
    Friend WithEvents versand_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents versand_member As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbeBayVersandart As System.Windows.Forms.ComboBox
    Friend WithEvents btnCreateOrder As System.Windows.Forms.Button
    Public WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents lbleBayVersandkosten As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents versand_bildname As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents versand_menge As ColumnHeader
    Friend WithEvents versand_eiso_orderid As ColumnHeader
    Friend WithEvents Label15 As Label
    Public WithEvents txtRabatt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Public WithEvents txtRabattEUR As TextBox
    Friend WithEvents Label19 As Label
    Public WithEvents txtRabattEndsumme As TextBox
    Public WithEvents txtRabattPaypal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbVersandart As ComboBox
    Friend WithEvents lblEiSoVersandarten As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Public WithEvents txtArtikelsummeRabatt As TextBox
    Friend WithEvents lblKommentar As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents cmsEiSoVersandkostenCMB As ContextMenuStrip
    Friend WithEvents VersandartenÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechnungDirektAusdruckenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkPrintRechnung As CheckBox
    Friend WithEvents lbl_kunden_stat As Label
    Friend WithEvents chkBestellung_versand_MitRabatt As CheckBox
End Class
