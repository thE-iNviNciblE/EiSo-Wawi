<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYABE_Rechnungsdruck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYABE_Rechnungsdruck))
        Me.Label34 = New System.Windows.Forms.Label()
        Me.webYabeRechnung = New System.Windows.Forms.WebBrowser()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NeuToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ÖffnenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SpeichernToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DruckenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.KopierenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EinfügenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Bold = New System.Windows.Forms.ToolStripButton()
        Me.Hyperlink = New System.Windows.Forms.ToolStripButton()
        Me.Suchen = New System.Windows.Forms.ToolStripButton()
        Me.Bild = New System.Windows.Forms.ToolStripButton()
        Me.Redo = New System.Windows.Forms.ToolStripButton()
        Me.Undo = New System.Windows.Forms.ToolStripButton()
        Me.tabelle = New System.Windows.Forms.ToolStripButton()
        Me.DHTMLControll = New AxDHTMLEDLib.AxDHTMLEdit()
        Me.txtVorlageQuellcode = New System.Windows.Forms.TextBox()
        Me.chkArchiv = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbSprache_Rechnungsdruck = New System.Windows.Forms.ComboBox()
        Me.cmbVorlagen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkMitEmail = New System.Windows.Forms.CheckBox()
        Me.chkRechnungDruck = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.chkMwstOhne = New System.Windows.Forms.CheckBox()
        Me.chkMwstInkl = New System.Windows.Forms.CheckBox()
        Me.chkOhnePaypal = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(7, 6)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(203, 25)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "EiSo - Rechnung"
        '
        'webYabeRechnung
        '
        Me.webYabeRechnung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webYabeRechnung.Location = New System.Drawing.Point(0, 25)
        Me.webYabeRechnung.MinimumSize = New System.Drawing.Size(23, 20)
        Me.webYabeRechnung.Name = "webYabeRechnung"
        Me.webYabeRechnung.Size = New System.Drawing.Size(988, 547)
        Me.webYabeRechnung.TabIndex = 20
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechen.BackColor = System.Drawing.Color.Moccasin
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbbrechen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbbrechen.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.btnAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbbrechen.Location = New System.Drawing.Point(245, 687)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(225, 22)
        Me.btnAbbrechen.TabIndex = 21
        Me.btnAbbrechen.Text = "&Schließen"
        Me.btnAbbrechen.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.webYabeRechnung)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.DHTMLControll)
        Me.Panel1.Controls.Add(Me.txtVorlageQuellcode)
        Me.Panel1.Location = New System.Drawing.Point(12, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 572)
        Me.Panel1.TabIndex = 23
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(866, 5)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(117, 13)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Rechnung &editieren"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(822, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "HTML"
        Me.LinkLabel1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripButton, Me.ÖffnenToolStripButton, Me.SpeichernToolStripButton, Me.DruckenToolStripButton, Me.toolStripSeparator, Me.AusschneidenToolStripButton, Me.KopierenToolStripButton, Me.EinfügenToolStripButton, Me.toolStripSeparator2, Me.Bold, Me.Hyperlink, Me.Suchen, Me.Bild, Me.Redo, Me.Undo, Me.tabelle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NeuToolStripButton
        '
        Me.NeuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NeuToolStripButton.Image = CType(resources.GetObject("NeuToolStripButton.Image"), System.Drawing.Image)
        Me.NeuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripButton.Name = "NeuToolStripButton"
        Me.NeuToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NeuToolStripButton.Text = "&Neu"
        '
        'ÖffnenToolStripButton
        '
        Me.ÖffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ÖffnenToolStripButton.Image = CType(resources.GetObject("ÖffnenToolStripButton.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripButton.Name = "ÖffnenToolStripButton"
        Me.ÖffnenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ÖffnenToolStripButton.Text = "Ö&ffnen"
        '
        'SpeichernToolStripButton
        '
        Me.SpeichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SpeichernToolStripButton.Image = CType(resources.GetObject("SpeichernToolStripButton.Image"), System.Drawing.Image)
        Me.SpeichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripButton.Name = "SpeichernToolStripButton"
        Me.SpeichernToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SpeichernToolStripButton.Text = "&Speichern"
        '
        'DruckenToolStripButton
        '
        Me.DruckenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DruckenToolStripButton.Image = CType(resources.GetObject("DruckenToolStripButton.Image"), System.Drawing.Image)
        Me.DruckenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripButton.Name = "DruckenToolStripButton"
        Me.DruckenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DruckenToolStripButton.Text = "&Drucken"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'AusschneidenToolStripButton
        '
        Me.AusschneidenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AusschneidenToolStripButton.Image = CType(resources.GetObject("AusschneidenToolStripButton.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripButton.Name = "AusschneidenToolStripButton"
        Me.AusschneidenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AusschneidenToolStripButton.Text = "&Ausschneiden"
        '
        'KopierenToolStripButton
        '
        Me.KopierenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KopierenToolStripButton.Image = CType(resources.GetObject("KopierenToolStripButton.Image"), System.Drawing.Image)
        Me.KopierenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripButton.Name = "KopierenToolStripButton"
        Me.KopierenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.KopierenToolStripButton.Text = "&Kopieren"
        '
        'EinfügenToolStripButton
        '
        Me.EinfügenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EinfügenToolStripButton.Image = CType(resources.GetObject("EinfügenToolStripButton.Image"), System.Drawing.Image)
        Me.EinfügenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripButton.Name = "EinfügenToolStripButton"
        Me.EinfügenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EinfügenToolStripButton.Text = "&Einfügen"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Bold
        '
        Me.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bold.Image = CType(resources.GetObject("Bold.Image"), System.Drawing.Image)
        Me.Bold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bold.Name = "Bold"
        Me.Bold.Size = New System.Drawing.Size(23, 22)
        Me.Bold.Text = "Fett schreiben"
        '
        'Hyperlink
        '
        Me.Hyperlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Hyperlink.Image = CType(resources.GetObject("Hyperlink.Image"), System.Drawing.Image)
        Me.Hyperlink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Hyperlink.Name = "Hyperlink"
        Me.Hyperlink.Size = New System.Drawing.Size(23, 22)
        Me.Hyperlink.Text = "Hyperlink"
        '
        'Suchen
        '
        Me.Suchen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Suchen.Image = CType(resources.GetObject("Suchen.Image"), System.Drawing.Image)
        Me.Suchen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Suchen.Name = "Suchen"
        Me.Suchen.Size = New System.Drawing.Size(23, 22)
        Me.Suchen.Text = "Suchen"
        '
        'Bild
        '
        Me.Bild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bild.Image = CType(resources.GetObject("Bild.Image"), System.Drawing.Image)
        Me.Bild.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bild.Name = "Bild"
        Me.Bild.Size = New System.Drawing.Size(23, 22)
        Me.Bild.Text = "Bild einfügen"
        '
        'Redo
        '
        Me.Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Redo.Image = Global.YabE.My.Resources.Resources.links
        Me.Redo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Redo.Name = "Redo"
        Me.Redo.Size = New System.Drawing.Size(23, 22)
        Me.Redo.Text = "Vorwärts"
        '
        'Undo
        '
        Me.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Undo.Image = Global.YabE.My.Resources.Resources.rechts
        Me.Undo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Undo.Name = "Undo"
        Me.Undo.Size = New System.Drawing.Size(23, 22)
        Me.Undo.Text = "Zurück"
        '
        'tabelle
        '
        Me.tabelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tabelle.Image = CType(resources.GetObject("tabelle.Image"), System.Drawing.Image)
        Me.tabelle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tabelle.Name = "tabelle"
        Me.tabelle.Size = New System.Drawing.Size(23, 22)
        Me.tabelle.Text = "Tabelle einfügen"
        '
        'DHTMLControll
        '
        Me.DHTMLControll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DHTMLControll.Enabled = True
        Me.DHTMLControll.Location = New System.Drawing.Point(0, 28)
        Me.DHTMLControll.Name = "DHTMLControll"
        Me.DHTMLControll.OcxState = CType(resources.GetObject("DHTMLControll.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DHTMLControll.Size = New System.Drawing.Size(1208, 584)
        Me.DHTMLControll.TabIndex = 7
        '
        'txtVorlageQuellcode
        '
        Me.txtVorlageQuellcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVorlageQuellcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVorlageQuellcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVorlageQuellcode.Location = New System.Drawing.Point(11, 31)
        Me.txtVorlageQuellcode.Multiline = True
        Me.txtVorlageQuellcode.Name = "txtVorlageQuellcode"
        Me.txtVorlageQuellcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVorlageQuellcode.Size = New System.Drawing.Size(977, 544)
        Me.txtVorlageQuellcode.TabIndex = 3
        '
        'chkArchiv
        '
        Me.chkArchiv.AutoSize = True
        Me.chkArchiv.Checked = True
        Me.chkArchiv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkArchiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkArchiv.Location = New System.Drawing.Point(15, 38)
        Me.chkArchiv.Name = "chkArchiv"
        Me.chkArchiv.Size = New System.Drawing.Size(162, 17)
        Me.chkArchiv.TabIndex = 24
        Me.chkArchiv.Text = "Rechnungen &Archivieren"
        Me.chkArchiv.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "HTML Dateien | *.htm"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(524, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(224, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Sprachauswahl"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSprache_Rechnungsdruck
        '
        Me.cmbSprache_Rechnungsdruck.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSprache_Rechnungsdruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprache_Rechnungsdruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprache_Rechnungsdruck.FormattingEnabled = True
        Me.cmbSprache_Rechnungsdruck.Location = New System.Drawing.Point(525, 54)
        Me.cmbSprache_Rechnungsdruck.Name = "cmbSprache_Rechnungsdruck"
        Me.cmbSprache_Rechnungsdruck.Size = New System.Drawing.Size(219, 21)
        Me.cmbSprache_Rechnungsdruck.TabIndex = 42
        '
        'cmbVorlagen
        '
        Me.cmbVorlagen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbVorlagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVorlagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVorlagen.FormattingEnabled = True
        Me.cmbVorlagen.Items.AddRange(New Object() {"Alle", "eBay", "Delcampe", "Shopsysteme"})
        Me.cmbVorlagen.Location = New System.Drawing.Point(756, 54)
        Me.cmbVorlagen.Name = "cmbVorlagen"
        Me.cmbVorlagen.Size = New System.Drawing.Size(239, 21)
        Me.cmbVorlagen.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(754, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Vorlage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(443, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkMitEmail
        '
        Me.chkMitEmail.AutoSize = True
        Me.chkMitEmail.Checked = True
        Me.chkMitEmail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMitEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMitEmail.Location = New System.Drawing.Point(183, 38)
        Me.chkMitEmail.Name = "chkMitEmail"
        Me.chkMitEmail.Size = New System.Drawing.Size(137, 17)
        Me.chkMitEmail.TabIndex = 67
        Me.chkMitEmail.Text = "Rechnung per &Email"
        Me.chkMitEmail.UseVisualStyleBackColor = True
        '
        'chkRechnungDruck
        '
        Me.chkRechnungDruck.AutoSize = True
        Me.chkRechnungDruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkRechnungDruck.Location = New System.Drawing.Point(326, 38)
        Me.chkRechnungDruck.Name = "chkRechnungDruck"
        Me.chkRechnungDruck.Size = New System.Drawing.Size(129, 17)
        Me.chkRechnungDruck.TabIndex = 68
        Me.chkRechnungDruck.Text = "Rechnung drucken"
        Me.chkRechnungDruck.UseVisualStyleBackColor = True
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
        Me.btnBack.Location = New System.Drawing.Point(809, 687)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 23)
        Me.btnBack.TabIndex = 69
        Me.btnBack.Text = "&Zurück"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnVor
        '
        Me.btnVor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(908, 687)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(93, 23)
        Me.btnVor.TabIndex = 70
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.Moccasin
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.YabE.My.Resources.Resources.time_go
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(12, 686)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(225, 24)
        Me.btnPrint.TabIndex = 71
        Me.btnPrint.Text = "&Rechnung abschicken"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'chkMwstOhne
        '
        Me.chkMwstOhne.AutoSize = True
        Me.chkMwstOhne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMwstOhne.Location = New System.Drawing.Point(15, 74)
        Me.chkMwstOhne.Name = "chkMwstOhne"
        Me.chkMwstOhne.Size = New System.Drawing.Size(144, 17)
        Me.chkMwstOhne.TabIndex = 72
        Me.chkMwstOhne.Text = "&Keine Mwst. Ausgabe"
        Me.chkMwstOhne.UseVisualStyleBackColor = True
        '
        'chkMwstInkl
        '
        Me.chkMwstInkl.AutoSize = True
        Me.chkMwstInkl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMwstInkl.Location = New System.Drawing.Point(183, 74)
        Me.chkMwstInkl.Name = "chkMwstInkl"
        Me.chkMwstInkl.Size = New System.Drawing.Size(177, 17)
        Me.chkMwstInkl.TabIndex = 73
        Me.chkMwstInkl.Text = "&Gesamtsumme zzgl. MwSt."
        Me.chkMwstInkl.UseVisualStyleBackColor = True
        '
        'chkOhnePaypal
        '
        Me.chkOhnePaypal.AutoSize = True
        Me.chkOhnePaypal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOhnePaypal.Location = New System.Drawing.Point(375, 74)
        Me.chkOhnePaypal.Name = "chkOhnePaypal"
        Me.chkOhnePaypal.Size = New System.Drawing.Size(185, 17)
        Me.chkOhnePaypal.TabIndex = 74
        Me.chkOhnePaypal.Text = "&Ohne Paypal Gesamtsumme"
        Me.chkOhnePaypal.UseVisualStyleBackColor = True
        '
        'frmYABE_Rechnungsdruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1008, 725)
        Me.Controls.Add(Me.chkOhnePaypal)
        Me.Controls.Add(Me.chkMwstInkl)
        Me.Controls.Add(Me.chkMwstOhne)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.chkRechnungDruck)
        Me.Controls.Add(Me.chkMitEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbVorlagen)
        Me.Controls.Add(Me.cmbSprache_Rechnungsdruck)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.chkArchiv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.Label34)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmYABE_Rechnungsdruck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EiSo Verkaufsabwicklung - Rechnungsdruck"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents webYabeRechnung As System.Windows.Forms.WebBrowser
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NeuToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ÖffnenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SpeichernToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DruckenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AusschneidenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents KopierenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EinfügenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Bold As System.Windows.Forms.ToolStripButton
    Friend WithEvents Hyperlink As System.Windows.Forms.ToolStripButton
    Friend WithEvents Suchen As System.Windows.Forms.ToolStripButton
    Friend WithEvents Bild As System.Windows.Forms.ToolStripButton
    Friend WithEvents Redo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Undo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabelle As System.Windows.Forms.ToolStripButton
    Friend WithEvents DHTMLControll As AxDHTMLEDLib.AxDHTMLEdit
    Friend WithEvents txtVorlageQuellcode As System.Windows.Forms.TextBox
    Friend WithEvents chkArchiv As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbSprache_Rechnungsdruck As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVorlagen As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkMitEmail As System.Windows.Forms.CheckBox
    Friend WithEvents chkRechnungDruck As System.Windows.Forms.CheckBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents chkMwstOhne As System.Windows.Forms.CheckBox
    Friend WithEvents chkMwstInkl As System.Windows.Forms.CheckBox
    Friend WithEvents chkOhnePaypal As System.Windows.Forms.CheckBox
End Class
