<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_change_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCMS_change_item))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBildURL = New System.Windows.Forms.TextBox()
        Me.txtQuelle = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtZiel = New System.Windows.Forms.TextBox()
        Me.cmbErstsprache = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPreis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.wbrMain = New System.Windows.Forms.WebBrowser()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbZweitSprache = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜbersetzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mainLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnFTPUpload = New System.Windows.Forms.Button()
        Me.btnBildauswahl = New System.Windows.Forms.Button()
        Me.btnZurück = New System.Windows.Forms.Button()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.btnItemAdd = New System.Windows.Forms.Button()
        Me.btnItemSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbItemStatus = New System.Windows.Forms.ComboBox()
        Me.btnItemDelete = New System.Windows.Forms.Button()
        Me.lvwMenue = New System.Windows.Forms.ListView()
        Me.cms_kategorieID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_menueName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_clickcount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_kategorie_delcampe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_kategorie_magento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_hauptkategorie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCat = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAnzahl = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(811, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Bild für die Artikeldatenbank und EiSo Online Shop"
        '
        'txtBildURL
        '
        Me.txtBildURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBildURL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBildURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBildURL.Location = New System.Drawing.Point(268, 336)
        Me.txtBildURL.Name = "txtBildURL"
        Me.txtBildURL.Size = New System.Drawing.Size(580, 21)
        Me.txtBildURL.TabIndex = 1
        '
        'txtQuelle
        '
        Me.txtQuelle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQuelle.BackColor = System.Drawing.Color.White
        Me.txtQuelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuelle.Location = New System.Drawing.Point(272, 471)
        Me.txtQuelle.Multiline = True
        Me.txtQuelle.Name = "txtQuelle"
        Me.txtQuelle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuelle.Size = New System.Drawing.Size(371, 175)
        Me.txtQuelle.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "button_ok.ico")
        Me.ImageList1.Images.SetKeyName(1, "Search.ico")
        '
        'txtZiel
        '
        Me.txtZiel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtZiel.BackColor = System.Drawing.Color.White
        Me.txtZiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZiel.Location = New System.Drawing.Point(688, 472)
        Me.txtZiel.Multiline = True
        Me.txtZiel.Name = "txtZiel"
        Me.txtZiel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtZiel.Size = New System.Drawing.Size(389, 175)
        Me.txtZiel.TabIndex = 16
        '
        'cmbErstsprache
        '
        Me.cmbErstsprache.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbErstsprache.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbErstsprache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbErstsprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbErstsprache.FormattingEnabled = True
        Me.cmbErstsprache.Items.AddRange(New Object() {"Deutsch -> Englisch", "Deutsch -> Französisch", "Englisch -> Französisch "})
        Me.cmbErstsprache.Location = New System.Drawing.Point(272, 437)
        Me.cmbErstsprache.Name = "cmbErstsprache"
        Me.cmbErstsprache.Size = New System.Drawing.Size(275, 21)
        Me.cmbErstsprache.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(269, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(811, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Quellsprache (Deutsch)"
        Me.ToolTip1.SetToolTip(Me.Label6, "Bitte Quellsprache auswählen für Google Translate. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bitte F5 drücken für Überset" &
        "zung")
        '
        'txtPreis
        '
        Me.txtPreis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPreis.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreis.Location = New System.Drawing.Point(268, 385)
        Me.txtPreis.Name = "txtPreis"
        Me.txtPreis.Size = New System.Drawing.Size(102, 21)
        Me.txtPreis.TabIndex = 20
        Me.txtPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(811, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Preis in EUR"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Euro"
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(530, 665)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(500, 664)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ID:"
        '
        'wbrMain
        '
        Me.wbrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbrMain.Location = New System.Drawing.Point(269, 36)
        Me.wbrMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrMain.Name = "wbrMain"
        Me.wbrMain.Size = New System.Drawing.Size(861, 255)
        Me.wbrMain.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(424, 385)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 21)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Artikelalter"
        '
        'cmbZweitSprache
        '
        Me.cmbZweitSprache.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbZweitSprache.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbZweitSprache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbZweitSprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbZweitSprache.FormattingEnabled = True
        Me.cmbZweitSprache.Items.AddRange(New Object() {"Deutsch -> Englisch", "Deutsch -> Französisch", "Englisch -> Französisch "})
        Me.cmbZweitSprache.Location = New System.Drawing.Point(688, 438)
        Me.cmbZweitSprache.Name = "cmbZweitSprache"
        Me.cmbZweitSprache.Size = New System.Drawing.Size(270, 21)
        Me.cmbZweitSprache.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(685, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Übersetzung in... F5"
        Me.ToolTip1.SetToolTip(Me.Label2, "Bitte Zielsprache auswählen für Google Translate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bitte F5 drücken für Übersetzun" &
        "g")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.AnsichtToolStripMenuItem, Me.ÜbersetzeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1151, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.closedown
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'AnsichtToolStripMenuItem
        '
        Me.AnsichtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebansichtToolStripMenuItem})
        Me.AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem"
        Me.AnsichtToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AnsichtToolStripMenuItem.Text = "Ansicht"
        '
        'WebansichtToolStripMenuItem
        '
        Me.WebansichtToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.world_edit
        Me.WebansichtToolStripMenuItem.Name = "WebansichtToolStripMenuItem"
        Me.WebansichtToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.WebansichtToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.WebansichtToolStripMenuItem.Text = "Webansicht"
        '
        'ÜbersetzeToolStripMenuItem
        '
        Me.ÜbersetzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem})
        Me.ÜbersetzeToolStripMenuItem.Name = "ÜbersetzeToolStripMenuItem"
        Me.ÜbersetzeToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ÜbersetzeToolStripMenuItem.Text = "Übersetzen"
        '
        'ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem
        '
        Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem})
        Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Web
        Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem.Name = "ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem"
        Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem.Text = "Übersetzung starten"
        '
        'ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem
        '
        Me.ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Name = "ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem"
        Me.ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Text = "&Zweite Sprache -> Übersetzungstext anhängen?"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Alle Dateien|*.*|jpg|*.jpg|gif|*.gif"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainLabel, Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 685)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1151, 22)
        Me.StatusStrip1.TabIndex = 42
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'mainLabel
        '
        Me.mainLabel.Name = "mainLabel"
        Me.mainLabel.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(300, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar1.Visible = False
        '
        'btnFTPUpload
        '
        Me.btnFTPUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFTPUpload.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnFTPUpload.Enabled = False
        Me.btnFTPUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTPUpload.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTPUpload.Image = Global.YabE.My.Resources.Resources._03
        Me.btnFTPUpload.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnFTPUpload.Location = New System.Drawing.Point(920, 333)
        Me.btnFTPUpload.Name = "btnFTPUpload"
        Me.btnFTPUpload.Size = New System.Drawing.Size(160, 24)
        Me.btnFTPUpload.TabIndex = 41
        Me.btnFTPUpload.Text = "&Bild hochladen"
        Me.ToolTip1.SetToolTip(Me.btnFTPUpload, "Upload der Datei per FTP starten")
        Me.btnFTPUpload.UseVisualStyleBackColor = False
        '
        'btnBildauswahl
        '
        Me.btnBildauswahl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBildauswahl.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBildauswahl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBildauswahl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBildauswahl.Image = Global.YabE.My.Resources.Resources._24
        Me.btnBildauswahl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBildauswahl.Location = New System.Drawing.Point(854, 333)
        Me.btnBildauswahl.Name = "btnBildauswahl"
        Me.btnBildauswahl.Size = New System.Drawing.Size(54, 24)
        Me.btnBildauswahl.TabIndex = 40
        Me.btnBildauswahl.Text = "    ..."
        Me.ToolTip1.SetToolTip(Me.btnBildauswahl, "Bitte Datei für den Upload auswählen")
        Me.btnBildauswahl.UseVisualStyleBackColor = False
        '
        'btnZurück
        '
        Me.btnZurück.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnZurück.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnZurück.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZurück.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZurück.Image = Global.YabE.My.Resources.Resources.links
        Me.btnZurück.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZurück.Location = New System.Drawing.Point(272, 658)
        Me.btnZurück.Name = "btnZurück"
        Me.btnZurück.Size = New System.Drawing.Size(104, 24)
        Me.btnZurück.TabIndex = 30
        Me.btnZurück.Text = "&Zurück"
        Me.ToolTip1.SetToolTip(Me.btnZurück, "In der Artikelliste rückwärts gehen")
        Me.btnZurück.UseVisualStyleBackColor = False
        '
        'btnVor
        '
        Me.btnVor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(386, 658)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(104, 24)
        Me.btnVor.TabIndex = 29
        Me.btnVor.Text = "&Vor"
        Me.ToolTip1.SetToolTip(Me.btnVor, "In der Liste vorwärts gehen")
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'btnItemAdd
        '
        Me.btnItemAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnItemAdd.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemAdd.Image = Global.YabE.My.Resources.Resources._03
        Me.btnItemAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnItemAdd.Location = New System.Drawing.Point(688, 658)
        Me.btnItemAdd.Name = "btnItemAdd"
        Me.btnItemAdd.Size = New System.Drawing.Size(123, 24)
        Me.btnItemAdd.TabIndex = 22
        Me.btnItemAdd.Text = "&Neuer Artikel"
        Me.ToolTip1.SetToolTip(Me.btnItemAdd, "Stelle eine leere Maske für einen komplett neuen Artikel zur Verfügung.")
        Me.btnItemAdd.UseVisualStyleBackColor = False
        '
        'btnItemSave
        '
        Me.btnItemSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnItemSave.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnItemSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemSave.Image = Global.YabE.My.Resources.Resources._24
        Me.btnItemSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnItemSave.Location = New System.Drawing.Point(817, 658)
        Me.btnItemSave.Name = "btnItemSave"
        Me.btnItemSave.Size = New System.Drawing.Size(134, 24)
        Me.btnItemSave.TabIndex = 13
        Me.btnItemSave.Text = "&Aktuallisieren"
        Me.ToolTip1.SetToolTip(Me.btnItemSave, "+ Aktuallisieren oder " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ Neuen Artikel anlegen")
        Me.btnItemSave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(855, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Artikelstatus"
        Me.ToolTip1.SetToolTip(Me.Label8, "Ändert den Artikelstatus")
        '
        'cmbItemStatus
        '
        Me.cmbItemStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbItemStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbItemStatus.FormattingEnabled = True
        Me.cmbItemStatus.Items.AddRange(New Object() {"Aktuell", "Bestellt", "Warteliste", "Delcampe Lister", "Importiert"})
        Me.cmbItemStatus.Location = New System.Drawing.Point(858, 384)
        Me.cmbItemStatus.Name = "cmbItemStatus"
        Me.cmbItemStatus.Size = New System.Drawing.Size(222, 21)
        Me.cmbItemStatus.TabIndex = 43
        '
        'btnItemDelete
        '
        Me.btnItemDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnItemDelete.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemDelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemDelete.Image = Global.YabE.My.Resources.Resources.delete
        Me.btnItemDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemDelete.Location = New System.Drawing.Point(957, 658)
        Me.btnItemDelete.Name = "btnItemDelete"
        Me.btnItemDelete.Size = New System.Drawing.Size(120, 24)
        Me.btnItemDelete.TabIndex = 45
        Me.btnItemDelete.Text = "&Löschen"
        Me.ToolTip1.SetToolTip(Me.btnItemDelete, "Löscht den aktuellen Artikel aus der Datenbank")
        Me.btnItemDelete.UseVisualStyleBackColor = False
        '
        'lvwMenue
        '
        Me.lvwMenue.AllowColumnReorder = True
        Me.lvwMenue.AllowDrop = True
        Me.lvwMenue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwMenue.BackColor = System.Drawing.Color.White
        Me.lvwMenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMenue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cms_kategorieID, Me.cms_menueName, Me.cms_clickcount, Me.cms_kategorie_delcampe, Me.cms_kategorie_magento, Me.cms_hauptkategorie, Me.cms_artikel})
        Me.lvwMenue.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMenue.FullRowSelect = True
        Me.lvwMenue.GridLines = True
        Me.lvwMenue.HideSelection = False
        Me.lvwMenue.Location = New System.Drawing.Point(12, 36)
        Me.lvwMenue.MultiSelect = False
        Me.lvwMenue.Name = "lvwMenue"
        Me.lvwMenue.Size = New System.Drawing.Size(251, 646)
        Me.lvwMenue.TabIndex = 46
        Me.lvwMenue.UseCompatibleStateImageBehavior = False
        Me.lvwMenue.View = System.Windows.Forms.View.Details
        '
        'cms_kategorieID
        '
        Me.cms_kategorieID.DisplayIndex = 3
        Me.cms_kategorieID.Width = 0
        '
        'cms_menueName
        '
        Me.cms_menueName.DisplayIndex = 0
        Me.cms_menueName.Text = "Name"
        Me.cms_menueName.Width = 250
        '
        'cms_clickcount
        '
        Me.cms_clickcount.Text = "Zugriffe"
        Me.cms_clickcount.Width = 0
        '
        'cms_kategorie_delcampe
        '
        Me.cms_kategorie_delcampe.DisplayIndex = 4
        Me.cms_kategorie_delcampe.Text = "DelcampeID"
        Me.cms_kategorie_delcampe.Width = 0
        '
        'cms_kategorie_magento
        '
        Me.cms_kategorie_magento.DisplayIndex = 5
        Me.cms_kategorie_magento.Text = "MagentoID"
        Me.cms_kategorie_magento.Width = 0
        '
        'cms_hauptkategorie
        '
        Me.cms_hauptkategorie.DisplayIndex = 6
        Me.cms_hauptkategorie.Text = "Hauptkategorie"
        Me.cms_hauptkategorie.Width = 0
        '
        'cms_artikel
        '
        Me.cms_artikel.DisplayIndex = 1
        Me.cms_artikel.Text = "Artikel"
        Me.cms_artikel.Width = 0
        '
        'lblCat
        '
        Me.lblCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(613, 679)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(0, 13)
        Me.lblCat.TabIndex = 47
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(643, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Menge auf Lager"
        Me.ToolTip1.SetToolTip(Me.Label9, "Ändert den Artikelstatus")
        '
        'txtAnzahl
        '
        Me.txtAnzahl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAnzahl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAnzahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnzahl.Location = New System.Drawing.Point(646, 385)
        Me.txtAnzahl.Name = "txtAnzahl"
        Me.txtAnzahl.Size = New System.Drawing.Size(57, 21)
        Me.txtAnzahl.TabIndex = 49
        Me.txtAnzahl.Text = "1"
        Me.txtAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCMS_change_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1151, 707)
        Me.Controls.Add(Me.txtAnzahl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.lvwMenue)
        Me.Controls.Add(Me.btnItemDelete)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbItemStatus)
        Me.Controls.Add(Me.btnFTPUpload)
        Me.Controls.Add(Me.btnBildauswahl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbZweitSprache)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnZurück)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnItemAdd)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtPreis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbErstsprache)
        Me.Controls.Add(Me.txtZiel)
        Me.Controls.Add(Me.btnItemSave)
        Me.Controls.Add(Me.txtQuelle)
        Me.Controls.Add(Me.txtBildURL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.wbrMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCMS_change_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo Shop - Artikel editieren / anlegen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBildURL As System.Windows.Forms.TextBox
    Friend WithEvents txtQuelle As System.Windows.Forms.TextBox
    Friend WithEvents btnItemSave As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtZiel As System.Windows.Forms.TextBox
    Friend WithEvents cmbErstsprache As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPreis As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnItemAdd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents btnZurück As System.Windows.Forms.Button
    Private WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents wbrMain As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbZweitSprache As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebansichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜbersetzeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBildauswahl As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFTPUpload As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents mainLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbItemStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnItemDelete As System.Windows.Forms.Button
    Friend WithEvents lvwMenue As System.Windows.Forms.ListView
    Friend WithEvents cms_kategorieID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_menueName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_clickcount As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_kategorie_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_kategorie_magento As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_hauptkategorie As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_artikel As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAnzahl As System.Windows.Forms.TextBox
End Class
