<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_Item2Shop
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
        Me.txtBildURL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvwMenue = New System.Windows.Forms.ListView()
        Me.cms_kategorieID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_menueName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_clickcount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_kategorie_delcampe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_kategorie_magento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_hauptkategorie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtPreis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuelle = New System.Windows.Forms.TextBox()
        Me.lblQuellsprache = New System.Windows.Forms.Label()
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnZurück = New System.Windows.Forms.Button()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKategorie = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnFTPUpload = New System.Windows.Forms.Button()
        Me.btnBildauswahl = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbleBayBeschreibung = New System.Windows.Forms.LinkLabel()
        Me.chkStatus = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbleBayKategorie = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnzahl = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBildURL
        '
        Me.txtBildURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBildURL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBildURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBildURL.Location = New System.Drawing.Point(342, 291)
        Me.txtBildURL.Name = "txtBildURL"
        Me.txtBildURL.Size = New System.Drawing.Size(443, 24)
        Me.txtBildURL.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(660, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bild für den Online Shop"
        '
        'lvwMenue
        '
        Me.lvwMenue.AllowColumnReorder = True
        Me.lvwMenue.AllowDrop = True
        Me.lvwMenue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMenue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cms_kategorieID, Me.cms_menueName, Me.cms_clickcount, Me.cms_kategorie_delcampe, Me.cms_kategorie_magento, Me.cms_hauptkategorie, Me.cms_artikel})
        Me.lvwMenue.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMenue.FullRowSelect = True
        Me.lvwMenue.GridLines = True
        Me.lvwMenue.HideSelection = False
        Me.lvwMenue.Location = New System.Drawing.Point(9, 8)
        Me.lvwMenue.Name = "lvwMenue"
        Me.lvwMenue.ShowItemToolTips = True
        Me.lvwMenue.Size = New System.Drawing.Size(317, 578)
        Me.lvwMenue.TabIndex = 19
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
        Me.cms_clickcount.Width = 73
        '
        'cms_kategorie_delcampe
        '
        Me.cms_kategorie_delcampe.DisplayIndex = 4
        Me.cms_kategorie_delcampe.Text = "DelcampeID"
        '
        'cms_kategorie_magento
        '
        Me.cms_kategorie_magento.DisplayIndex = 5
        Me.cms_kategorie_magento.Text = "MagentoID"
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
        '
        'txtPreis
        '
        Me.txtPreis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPreis.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreis.Location = New System.Drawing.Point(343, 332)
        Me.txtPreis.Name = "txtPreis"
        Me.txtPreis.Size = New System.Drawing.Size(119, 24)
        Me.txtPreis.TabIndex = 23
        Me.txtPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(470, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Euro"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(338, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Preis"
        '
        'txtQuelle
        '
        Me.txtQuelle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQuelle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuelle.Location = New System.Drawing.Point(342, 377)
        Me.txtQuelle.Multiline = True
        Me.txtQuelle.Name = "txtQuelle"
        Me.txtQuelle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuelle.Size = New System.Drawing.Size(424, 175)
        Me.txtQuelle.TabIndex = 24
        '
        'lblQuellsprache
        '
        Me.lblQuellsprache.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuellsprache.BackColor = System.Drawing.Color.Silver
        Me.lblQuellsprache.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuellsprache.Location = New System.Drawing.Point(338, 361)
        Me.lblQuellsprache.Name = "lblQuellsprache"
        Me.lblQuellsprache.Size = New System.Drawing.Size(425, 13)
        Me.lblQuellsprache.TabIndex = 25
        Me.lblQuellsprache.Text = "Deutsch"
        '
        'btnNeu
        '
        Me.btnNeu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNeu.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNeu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNeu.Image = Global.YabE.My.Resources.Resources._03
        Me.btnNeu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnNeu.Location = New System.Drawing.Point(342, 558)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(259, 24)
        Me.btnNeu.TabIndex = 26
        Me.btnNeu.Text = "&Artikeldatenbank neu hinzufügen"
        Me.btnNeu.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(342, 8)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(23, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(655, 258)
        Me.WebBrowser1.TabIndex = 33
        '
        'btnZurück
        '
        Me.btnZurück.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnZurück.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnZurück.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZurück.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZurück.Image = Global.YabE.My.Resources.Resources.links
        Me.btnZurück.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZurück.Location = New System.Drawing.Point(607, 558)
        Me.btnZurück.Name = "btnZurück"
        Me.btnZurück.Size = New System.Drawing.Size(121, 24)
        Me.btnZurück.TabIndex = 35
        Me.btnZurück.Text = "&Zurück"
        Me.btnZurück.UseVisualStyleBackColor = False
        '
        'btnVor
        '
        Me.btnVor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(733, 558)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(121, 24)
        Me.btnVor.TabIndex = 34
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(778, 503)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 24)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Kategorie"
        '
        'lblKategorie
        '
        Me.lblKategorie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblKategorie.AutoSize = True
        Me.lblKategorie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKategorie.Location = New System.Drawing.Point(524, 333)
        Me.lblKategorie.Name = "lblKategorie"
        Me.lblKategorie.Size = New System.Drawing.Size(0, 17)
        Me.lblKategorie.TabIndex = 38
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(775, 435)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 17)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "eBay Link öffnen"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1, Me.message})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 600)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1009, 22)
        Me.StatusStrip1.TabIndex = 43
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(350, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar1.Visible = False
        '
        'message
        '
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(0, 17)
        '
        'btnFTPUpload
        '
        Me.btnFTPUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFTPUpload.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnFTPUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTPUpload.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTPUpload.Image = Global.YabE.My.Resources.Resources._03
        Me.btnFTPUpload.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnFTPUpload.Location = New System.Drawing.Point(861, 288)
        Me.btnFTPUpload.Name = "btnFTPUpload"
        Me.btnFTPUpload.Size = New System.Drawing.Size(142, 24)
        Me.btnFTPUpload.TabIndex = 45
        Me.btnFTPUpload.Text = "&Hochladen"
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
        Me.btnBildauswahl.Location = New System.Drawing.Point(791, 288)
        Me.btnBildauswahl.Name = "btnBildauswahl"
        Me.btnBildauswahl.Size = New System.Drawing.Size(63, 24)
        Me.btnBildauswahl.TabIndex = 44
        Me.btnBildauswahl.Text = "    ..."
        Me.btnBildauswahl.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Alle Dateien|*.*|jpg|*.jpg|gif|*.gif"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'lbleBayBeschreibung
        '
        Me.lbleBayBeschreibung.AutoSize = True
        Me.lbleBayBeschreibung.Location = New System.Drawing.Point(775, 404)
        Me.lbleBayBeschreibung.Name = "lbleBayBeschreibung"
        Me.lbleBayBeschreibung.Size = New System.Drawing.Size(227, 17)
        Me.lbleBayBeschreibung.TabIndex = 46
        Me.lbleBayBeschreibung.TabStop = True
        Me.lbleBayBeschreibung.Text = "eBay lange Beschreibung holen"
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(775, 377)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(66, 17)
        Me.chkStatus.TabIndex = 47
        Me.chkStatus.TabStop = True
        Me.chkStatus.Text = "Status: "
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(778, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "eBay Kategorie"
        '
        'lbleBayKategorie
        '
        Me.lbleBayKategorie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbleBayKategorie.AutoSize = True
        Me.lbleBayKategorie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleBayKategorie.Location = New System.Drawing.Point(785, 332)
        Me.lbleBayKategorie.Name = "lbleBayKategorie"
        Me.lbleBayKategorie.Size = New System.Drawing.Size(0, 17)
        Me.lbleBayKategorie.TabIndex = 49
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(778, 487)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(177, 17)
        Me.LinkLabel2.TabIndex = 50
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "eBay Categorie Mapping"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(680, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Anzahl"
        '
        'txtAnzahl
        '
        Me.txtAnzahl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAnzahl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAnzahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnzahl.Location = New System.Drawing.Point(683, 332)
        Me.txtAnzahl.Name = "txtAnzahl"
        Me.txtAnzahl.Size = New System.Drawing.Size(57, 24)
        Me.txtAnzahl.TabIndex = 52
        Me.txtAnzahl.Text = "1"
        Me.txtAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCMS_Item2Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1009, 622)
        Me.Controls.Add(Me.txtAnzahl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.lbleBayKategorie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkStatus)
        Me.Controls.Add(Me.lbleBayBeschreibung)
        Me.Controls.Add(Me.btnFTPUpload)
        Me.Controls.Add(Me.btnBildauswahl)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblKategorie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnZurück)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnNeu)
        Me.Controls.Add(Me.lblQuellsprache)
        Me.Controls.Add(Me.txtQuelle)
        Me.Controls.Add(Me.txtPreis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwMenue)
        Me.Controls.Add(Me.txtBildURL)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCMS_Item2Shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo Artikelübernahme"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBildURL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvwMenue As System.Windows.Forms.ListView
    Friend WithEvents cms_kategorieID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_menueName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_clickcount As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_kategorie_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_kategorie_magento As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_hauptkategorie As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_artikel As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPreis As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuelle As System.Windows.Forms.TextBox
    Friend WithEvents lblQuellsprache As System.Windows.Forms.Label
    Friend WithEvents btnNeu As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents btnZurück As System.Windows.Forms.Button
    Private WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblKategorie As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnFTPUpload As System.Windows.Forms.Button
    Friend WithEvents btnBildauswahl As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbleBayBeschreibung As System.Windows.Forms.LinkLabel
    Friend WithEvents chkStatus As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbleBayKategorie As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents message As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAnzahl As System.Windows.Forms.TextBox
End Class
