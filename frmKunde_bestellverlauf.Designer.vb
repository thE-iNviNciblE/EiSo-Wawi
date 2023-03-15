<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKunde_bestellverlauf
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKunde_bestellverlauf))
        Me.lvwBestellverlauf = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayBeschreibung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bids = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yabe_auktionsende = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yabe_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.versandkosten = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.paypal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mitglied = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsBestellübersicht = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MakierenAlleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CockpitArtikelErneutVersendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblGesammtsumme = New System.Windows.Forms.Label()
        Me.lblBestellverlauf = New System.Windows.Forms.Label()
        Me.txtLand = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStraße = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrtPLZ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUserId = New System.Windows.Forms.TextBox()
        Me.LblUserId = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSprachenVorlage = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail_klicks = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail_letzte = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.AnsichtAktuallisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABERechnungsdruckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestellstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestelltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BezahltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschicktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KomplettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StorniertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABEArtikelansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheBestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheKundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheArtikelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenArtikelnummerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenMitgliedsnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.cmsBestellübersicht.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwBestellverlauf
        '
        Me.lvwBestellverlauf.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBestellverlauf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBestellverlauf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBestellverlauf.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.eBayBeschreibung, Me.Preis, Me.bids, Me.status, Me.yabe_auktionsende, Me.yabe_plattform, Me.versandkosten, Me.paypal, Me.mitglied, Me.email, Me.bild, Me.menge})
        Me.lvwBestellverlauf.ContextMenuStrip = Me.cmsBestellübersicht
        Me.lvwBestellverlauf.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBestellverlauf.FullRowSelect = True
        Me.lvwBestellverlauf.GridLines = True
        Me.lvwBestellverlauf.HideSelection = False
        Me.lvwBestellverlauf.LargeImageList = Me.ImageList1
        Me.lvwBestellverlauf.Location = New System.Drawing.Point(9, 41)
        Me.lvwBestellverlauf.Name = "lvwBestellverlauf"
        Me.lvwBestellverlauf.Size = New System.Drawing.Size(1094, 275)
        Me.lvwBestellverlauf.SmallImageList = Me.ImageList1
        Me.lvwBestellverlauf.TabIndex = 2
        Me.lvwBestellverlauf.UseCompatibleStateImageBehavior = False
        Me.lvwBestellverlauf.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.DisplayIndex = 1
        Me.ID.Text = "ID"
        Me.ID.Width = 100
        '
        'eBayBeschreibung
        '
        Me.eBayBeschreibung.DisplayIndex = 4
        Me.eBayBeschreibung.Text = "Beschreibung"
        Me.eBayBeschreibung.Width = 365
        '
        'Preis
        '
        Me.Preis.DisplayIndex = 6
        Me.Preis.Text = "Endpreis"
        Me.Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Preis.Width = 70
        '
        'bids
        '
        Me.bids.DisplayIndex = 5
        Me.bids.Text = "Gebote"
        Me.bids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.bids.Width = 59
        '
        'status
        '
        Me.status.DisplayIndex = 7
        Me.status.Text = "Status"
        Me.status.Width = 141
        '
        'yabe_auktionsende
        '
        Me.yabe_auktionsende.DisplayIndex = 3
        Me.yabe_auktionsende.Text = "Auktionsende"
        Me.yabe_auktionsende.Width = 91
        '
        'yabe_plattform
        '
        Me.yabe_plattform.DisplayIndex = 2
        Me.yabe_plattform.Text = "Plattform"
        Me.yabe_plattform.Width = 66
        '
        'versandkosten
        '
        Me.versandkosten.DisplayIndex = 8
        Me.versandkosten.Text = "Versandkosten"
        Me.versandkosten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'paypal
        '
        Me.paypal.DisplayIndex = 9
        Me.paypal.Text = "Paypal"
        Me.paypal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mitglied
        '
        Me.mitglied.DisplayIndex = 10
        Me.mitglied.Text = "Mitglied"
        '
        'email
        '
        Me.email.DisplayIndex = 11
        Me.email.Text = "email"
        '
        'bild
        '
        Me.bild.DisplayIndex = 0
        Me.bild.Text = "Bild"
        '
        'menge
        '
        Me.menge.Text = "Menge"
        '
        'cmsBestellübersicht
        '
        Me.cmsBestellübersicht.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsichtAktuallisierenToolStripMenuItem, Me.ToolStripSeparator6, Me.MakierenAlleToolStripMenuItem, Me.YABERechnungsdruckToolStripMenuItem, Me.BestellstatusToolStripMenuItem, Me.YABEArtikelansichtToolStripMenuItem, Me.ToolStripSeparator2, Me.SucheBestellungenToolStripMenuItem, Me.SucheKundeToolStripMenuItem, Me.SucheArtikelToolStripMenuItem, Me.ToolStripSeparator3, Me.LöschenToolStripMenuItem, Me.ToolStripSeparator4, Me.KopierenEmailToolStripMenuItem, Me.KopierenArtikelnummerToolStripMenuItem, Me.KopierenMitgliedsnameToolStripMenuItem, Me.ToolStripSeparator5, Me.ÜbersichtExportierenZumDruckenToolStripMenuItem, Me.CockpitArtikelErneutVersendenToolStripMenuItem})
        Me.cmsBestellübersicht.Name = "cmsBestellübersicht"
        Me.cmsBestellübersicht.Size = New System.Drawing.Size(313, 342)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(309, 6)
        '
        'MakierenAlleToolStripMenuItem
        '
        Me.MakierenAlleToolStripMenuItem.Name = "MakierenAlleToolStripMenuItem"
        Me.MakierenAlleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MakierenAlleToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.MakierenAlleToolStripMenuItem.Text = "Makieren -> Alle"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(309, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(309, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(309, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(309, 6)
        '
        'CockpitArtikelErneutVersendenToolStripMenuItem
        '
        Me.CockpitArtikelErneutVersendenToolStripMenuItem.Name = "CockpitArtikelErneutVersendenToolStripMenuItem"
        Me.CockpitArtikelErneutVersendenToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.CockpitArtikelErneutVersendenToolStripMenuItem.Text = "Cockpit -> Artikel erneut versenden"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(60, 60)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblGesammtsumme
        '
        Me.lblGesammtsumme.AutoSize = True
        Me.lblGesammtsumme.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblGesammtsumme.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGesammtsumme.Location = New System.Drawing.Point(210, 16)
        Me.lblGesammtsumme.Name = "lblGesammtsumme"
        Me.lblGesammtsumme.Size = New System.Drawing.Size(0, 18)
        Me.lblGesammtsumme.TabIndex = 63
        '
        'lblBestellverlauf
        '
        Me.lblBestellverlauf.AutoSize = True
        Me.lblBestellverlauf.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestellverlauf.Location = New System.Drawing.Point(11, 7)
        Me.lblBestellverlauf.Name = "lblBestellverlauf"
        Me.lblBestellverlauf.Size = New System.Drawing.Size(293, 18)
        Me.lblBestellverlauf.TabIndex = 64
        Me.lblBestellverlauf.Text = "Kunden - Allgemeine Infomationen"
        '
        'txtLand
        '
        Me.txtLand.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLand.Location = New System.Drawing.Point(556, 58)
        Me.txtLand.Name = "txtLand"
        Me.txtLand.ReadOnly = True
        Me.txtLand.Size = New System.Drawing.Size(220, 21)
        Me.txtLand.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(506, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 23)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Land"
        '
        'txtStraße
        '
        Me.txtStraße.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStraße.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStraße.Location = New System.Drawing.Point(123, 58)
        Me.txtStraße.Name = "txtStraße"
        Me.txtStraße.ReadOnly = True
        Me.txtStraße.Size = New System.Drawing.Size(263, 21)
        Me.txtStraße.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 23)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Straße"
        '
        'txtOrtPLZ
        '
        Me.txtOrtPLZ.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrtPLZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrtPLZ.Location = New System.Drawing.Point(123, 85)
        Me.txtOrtPLZ.Name = "txtOrtPLZ"
        Me.txtOrtPLZ.ReadOnly = True
        Me.txtOrtPLZ.Size = New System.Drawing.Size(220, 21)
        Me.txtOrtPLZ.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Ort + PLZ"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(123, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(220, 21)
        Me.txtName.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Name"
        '
        'TxtUserId
        '
        Me.TxtUserId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserId.Location = New System.Drawing.Point(556, 31)
        Me.TxtUserId.Name = "TxtUserId"
        Me.TxtUserId.ReadOnly = True
        Me.TxtUserId.Size = New System.Drawing.Size(220, 21)
        Me.TxtUserId.TabIndex = 101
        '
        'LblUserId
        '
        Me.LblUserId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserId.Location = New System.Drawing.Point(444, 33)
        Me.LblUserId.Name = "LblUserId"
        Me.LblUserId.Size = New System.Drawing.Size(110, 23)
        Me.LblUserId.TabIndex = 102
        Me.LblUserId.Text = "Mitgliedsname"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(558, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(147, 21)
        Me.TextBox1.TabIndex = 111
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 23)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Profilalter"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(123, 112)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(220, 21)
        Me.txtEmail.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 23)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Email"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSprachenVorlage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail_klicks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail_letzte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBestellverlauf)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtUserId)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblUserId)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtOrtPLZ)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtLand)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtStraße)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnBack)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblGesammtsumme)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvwBestellverlauf)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCloseForm)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnVor)
        Me.SplitContainer1.Size = New System.Drawing.Size(1116, 542)
        Me.SplitContainer1.SplitterDistance = 209
        Me.SplitContainer1.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(472, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(73, 23)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Sprache"
        '
        'cmbSprachenVorlage
        '
        Me.cmbSprachenVorlage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprachenVorlage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprachenVorlage.FormattingEnabled = True
        Me.cmbSprachenVorlage.Location = New System.Drawing.Point(558, 87)
        Me.cmbSprachenVorlage.Name = "cmbSprachenVorlage"
        Me.cmbSprachenVorlage.Size = New System.Drawing.Size(218, 21)
        Me.cmbSprachenVorlage.TabIndex = 142
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(555, 146)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(104, 13)
        Me.LinkLabel1.TabIndex = 123
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Kunden editieren"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(70, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 19)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Klicks"
        '
        'txtEmail_klicks
        '
        Me.txtEmail_klicks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail_klicks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail_klicks.Location = New System.Drawing.Point(123, 172)
        Me.txtEmail_klicks.Name = "txtEmail_klicks"
        Me.txtEmail_klicks.ReadOnly = True
        Me.txtEmail_klicks.Size = New System.Drawing.Size(73, 21)
        Me.txtEmail_klicks.TabIndex = 121
        Me.txtEmail_klicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 18)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Kunden - Newsletter"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(229, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 23)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Letzter Klick"
        '
        'txtEmail_letzte
        '
        Me.txtEmail_letzte.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail_letzte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail_letzte.Location = New System.Drawing.Point(324, 172)
        Me.txtEmail_letzte.Name = "txtEmail_letzte"
        Me.txtEmail_letzte.ReadOnly = True
        Me.txtEmail_letzte.Size = New System.Drawing.Size(173, 21)
        Me.txtEmail_letzte.TabIndex = 118
        Me.txtEmail_letzte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(174, 18)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Kundenbestellungen"
        '
        'btnCloseForm
        '
        Me.btnCloseForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseForm.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseForm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseForm.Image = Global.YabE.My.Resources.Resources.abbrechen1
        Me.btnCloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseForm.Location = New System.Drawing.Point(958, 12)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(145, 23)
        Me.btnCloseForm.TabIndex = 0
        Me.btnCloseForm.Text = "Schließen"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(687, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 23)
        Me.btnBack.TabIndex = 60
        Me.btnBack.Text = "&Zurück"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'AnsichtAktuallisierenToolStripMenuItem
        '
        Me.AnsichtAktuallisierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.AnsichtAktuallisierenToolStripMenuItem.Name = "AnsichtAktuallisierenToolStripMenuItem"
        Me.AnsichtAktuallisierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AnsichtAktuallisierenToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.AnsichtAktuallisierenToolStripMenuItem.Text = "Ansicht -> aktuallisieren"
        '
        'YABERechnungsdruckToolStripMenuItem
        '
        Me.YABERechnungsdruckToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.money_add
        Me.YABERechnungsdruckToolStripMenuItem.Name = "YABERechnungsdruckToolStripMenuItem"
        Me.YABERechnungsdruckToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.YABERechnungsdruckToolStripMenuItem.Text = "EiSo -> Rechnungsdruck"
        '
        'BestellstatusToolStripMenuItem
        '
        Me.BestellstatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BestelltToolStripMenuItem, Me.BezahltToolStripMenuItem, Me.VerschicktToolStripMenuItem, Me.KomplettToolStripMenuItem, Me.ToolStripSeparator1, Me.StorniertToolStripMenuItem})
        Me.BestellstatusToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.time_go
        Me.BestellstatusToolStripMenuItem.Name = "BestellstatusToolStripMenuItem"
        Me.BestellstatusToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.BestellstatusToolStripMenuItem.Text = "Bestellstatus "
        '
        'BestelltToolStripMenuItem
        '
        Me.BestelltToolStripMenuItem.Name = "BestelltToolStripMenuItem"
        Me.BestelltToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.BestelltToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BestelltToolStripMenuItem.Text = "&Bestellt"
        '
        'BezahltToolStripMenuItem
        '
        Me.BezahltToolStripMenuItem.Name = "BezahltToolStripMenuItem"
        Me.BezahltToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BezahltToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BezahltToolStripMenuItem.Text = "&Bezahlt"
        '
        'VerschicktToolStripMenuItem
        '
        Me.VerschicktToolStripMenuItem.Name = "VerschicktToolStripMenuItem"
        Me.VerschicktToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.VerschicktToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.VerschicktToolStripMenuItem.Text = "&Verschickt"
        '
        'KomplettToolStripMenuItem
        '
        Me.KomplettToolStripMenuItem.Name = "KomplettToolStripMenuItem"
        Me.KomplettToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.KomplettToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.KomplettToolStripMenuItem.Text = "&Komplett"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'StorniertToolStripMenuItem
        '
        Me.StorniertToolStripMenuItem.Name = "StorniertToolStripMenuItem"
        Me.StorniertToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.StorniertToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.StorniertToolStripMenuItem.Text = "&Storniert"
        '
        'YABEArtikelansichtToolStripMenuItem
        '
        Me.YABEArtikelansichtToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.YABEArtikelansichtToolStripMenuItem.Name = "YABEArtikelansichtToolStripMenuItem"
        Me.YABEArtikelansichtToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.YABEArtikelansichtToolStripMenuItem.Text = "EiSo -> Artikelansicht"
        '
        'SucheBestellungenToolStripMenuItem
        '
        Me.SucheBestellungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheBestellungenToolStripMenuItem.Name = "SucheBestellungenToolStripMenuItem"
        Me.SucheBestellungenToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SucheBestellungenToolStripMenuItem.Text = "Suche -> Kunden Bestellungen"
        '
        'SucheKundeToolStripMenuItem
        '
        Me.SucheKundeToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheKundeToolStripMenuItem.Name = "SucheKundeToolStripMenuItem"
        Me.SucheKundeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.SucheKundeToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SucheKundeToolStripMenuItem.Text = "Suche -> &Kunden"
        '
        'SucheArtikelToolStripMenuItem
        '
        Me.SucheArtikelToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheArtikelToolStripMenuItem.Name = "SucheArtikelToolStripMenuItem"
        Me.SucheArtikelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SucheArtikelToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SucheArtikelToolStripMenuItem.Text = "Suche -> EiSo &Artikeldatenbank"
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.LöschenToolStripMenuItem.Text = "Bestellung -> &löschen"
        '
        'KopierenEmailToolStripMenuItem
        '
        Me.KopierenEmailToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenEmailToolStripMenuItem.Name = "KopierenEmailToolStripMenuItem"
        Me.KopierenEmailToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenEmailToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.KopierenEmailToolStripMenuItem.Text = "Kopieren -> Email"
        '
        'KopierenArtikelnummerToolStripMenuItem
        '
        Me.KopierenArtikelnummerToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenArtikelnummerToolStripMenuItem.Name = "KopierenArtikelnummerToolStripMenuItem"
        Me.KopierenArtikelnummerToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.KopierenArtikelnummerToolStripMenuItem.Text = "Kopieren -> Artikelnummer"
        '
        'KopierenMitgliedsnameToolStripMenuItem
        '
        Me.KopierenMitgliedsnameToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenMitgliedsnameToolStripMenuItem.Name = "KopierenMitgliedsnameToolStripMenuItem"
        Me.KopierenMitgliedsnameToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.KopierenMitgliedsnameToolStripMenuItem.Text = "Kopieren -> Mitgliedsname"
        '
        'ÜbersichtExportierenZumDruckenToolStripMenuItem
        '
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Name = "ÜbersichtExportierenZumDruckenToolStripMenuItem"
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Text = "&Übersicht -> Exportieren zum Drucken"
        '
        'btnVor
        '
        Me.btnVor.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(823, 12)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(129, 23)
        Me.btnVor.TabIndex = 61
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'frmKunde_bestellverlauf
        '
        Me.AcceptButton = Me.btnCloseForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 542)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmKunde_bestellverlauf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo - Bestellverlauf von Kunden"
        Me.cmsBestellübersicht.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCloseForm As System.Windows.Forms.Button
    Friend WithEvents lvwBestellverlauf As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayBeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents status As System.Windows.Forms.ColumnHeader
    Friend WithEvents bids As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblGesammtsumme As System.Windows.Forms.Label
    Friend WithEvents lblBestellverlauf As System.Windows.Forms.Label
    Friend WithEvents txtLand As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStraße As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrtPLZ As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtUserId As System.Windows.Forms.TextBox
    Friend WithEvents LblUserId As System.Windows.Forms.Label
    Friend WithEvents yabe_auktionsende As System.Windows.Forms.ColumnHeader
    Friend WithEvents yabe_plattform As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmsBestellübersicht As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BestellstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestelltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BezahltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschicktToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KomplettToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StorniertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AnsichtAktuallisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents YABERechnungsdruckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents versandkosten As System.Windows.Forms.ColumnHeader
    Friend WithEvents paypal As System.Windows.Forms.ColumnHeader
    Friend WithEvents mitglied As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents YABEArtikelansichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KopierenEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenArtikelnummerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenMitgliedsnameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ÜbersichtExportierenZumDruckenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MakierenAlleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmail_letzte As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmail_klicks As System.Windows.Forms.TextBox
    Friend WithEvents SucheBestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheKundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheArtikelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbSprachenVorlage As System.Windows.Forms.ComboBox
    Friend WithEvents bild As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CockpitArtikelErneutVersendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menge As ColumnHeader
End Class
