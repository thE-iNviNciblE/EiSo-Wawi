<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYABE_Vorlageneditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYABE_Vorlageneditor))
        Me.btnAbschickenNewsletter = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.lblVorlagenHeader = New System.Windows.Forms.Label()
        Me.cmbSprache = New System.Windows.Forms.ComboBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnLaden = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmbGruppierung = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbVorlage = New System.Windows.Forms.ComboBox()
        Me.conNeueVorlage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UmbennenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeueVorlageAnlegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.yabe_dashboard_header = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conNeueVorlage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAbschickenNewsletter
        '
        Me.btnAbschickenNewsletter.BackColor = System.Drawing.Color.Moccasin
        Me.btnAbschickenNewsletter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbschickenNewsletter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbschickenNewsletter.Image = Global.YabE.My.Resources.Resources.world_edit
        Me.btnAbschickenNewsletter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbschickenNewsletter.Location = New System.Drawing.Point(665, 119)
        Me.btnAbschickenNewsletter.Name = "btnAbschickenNewsletter"
        Me.btnAbschickenNewsletter.Size = New System.Drawing.Size(225, 22)
        Me.btnAbschickenNewsletter.TabIndex = 4
        Me.btnAbschickenNewsletter.Text = "&Änderungen speichern"
        Me.btnAbschickenNewsletter.UseVisualStyleBackColor = False
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.BackColor = System.Drawing.Color.Moccasin
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbbrechen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbbrechen.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.btnAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbbrechen.Location = New System.Drawing.Point(897, 119)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(225, 22)
        Me.btnAbbrechen.TabIndex = 11
        Me.btnAbbrechen.Text = "&Schließen"
        Me.btnAbbrechen.UseVisualStyleBackColor = False
        '
        'lblVorlagenHeader
        '
        Me.lblVorlagenHeader.AutoSize = True
        Me.lblVorlagenHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVorlagenHeader.Location = New System.Drawing.Point(12, 66)
        Me.lblVorlagenHeader.Name = "lblVorlagenHeader"
        Me.lblVorlagenHeader.Size = New System.Drawing.Size(66, 16)
        Me.lblVorlagenHeader.TabIndex = 12
        Me.lblVorlagenHeader.Text = "Sprache"
        '
        'cmbSprache
        '
        Me.cmbSprache.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSprache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprache.FormattingEnabled = True
        Me.cmbSprache.Location = New System.Drawing.Point(95, 63)
        Me.cmbSprache.Name = "cmbSprache"
        Me.cmbSprache.Size = New System.Drawing.Size(182, 24)
        Me.cmbSprache.TabIndex = 0
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.DHTMLControll)
        Me.Panel1.Controls.Add(Me.txtVorlageQuellcode)
        Me.Panel1.Location = New System.Drawing.Point(-1, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1148, 568)
        Me.Panel1.TabIndex = 14
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(403, 5)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(104, 16)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Browseransicht"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 546)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1148, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(359, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(48, 17)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "HTML"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripButton, Me.ÖffnenToolStripButton, Me.SpeichernToolStripButton, Me.DruckenToolStripButton, Me.toolStripSeparator, Me.AusschneidenToolStripButton, Me.KopierenToolStripButton, Me.EinfügenToolStripButton, Me.toolStripSeparator2, Me.Bold, Me.Hyperlink, Me.Suchen, Me.Bild, Me.Redo, Me.Undo, Me.tabelle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1148, 25)
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
        Me.DHTMLControll.Size = New System.Drawing.Size(1142, 515)
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
        Me.txtVorlageQuellcode.Size = New System.Drawing.Size(1137, 540)
        Me.txtVorlageQuellcode.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "HTML Dateien | *.htm"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.ShowHelp = True
        '
        'btnLaden
        '
        Me.btnLaden.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnLaden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaden.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaden.Image = Global.YabE.My.Resources.Resources.adressbuch
        Me.btnLaden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaden.Location = New System.Drawing.Point(465, 119)
        Me.btnLaden.Name = "btnLaden"
        Me.btnLaden.Size = New System.Drawing.Size(194, 22)
        Me.btnLaden.TabIndex = 1
        Me.btnLaden.Text = "&Vorlage Laden"
        Me.btnLaden.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "HTML Dateien | *.htm"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'cmbGruppierung
        '
        Me.cmbGruppierung.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbGruppierung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGruppierung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGruppierung.FormattingEnabled = True
        Me.cmbGruppierung.Location = New System.Drawing.Point(95, 91)
        Me.cmbGruppierung.Name = "cmbGruppierung"
        Me.cmbGruppierung.Size = New System.Drawing.Size(263, 24)
        Me.cmbGruppierung.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Gruppierung"
        '
        'cmbVorlage
        '
        Me.cmbVorlage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbVorlage.ContextMenuStrip = Me.conNeueVorlage
        Me.cmbVorlage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVorlage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVorlage.FormattingEnabled = True
        Me.cmbVorlage.Location = New System.Drawing.Point(95, 119)
        Me.cmbVorlage.Name = "cmbVorlage"
        Me.cmbVorlage.Size = New System.Drawing.Size(345, 24)
        Me.cmbVorlage.TabIndex = 17
        '
        'conNeueVorlage
        '
        Me.conNeueVorlage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UmbennenToolStripMenuItem, Me.NeueVorlageAnlegenToolStripMenuItem, Me.ToolStripSeparator1, Me.LöschenToolStripMenuItem})
        Me.conNeueVorlage.Name = "conNeueVorlage"
        Me.conNeueVorlage.Size = New System.Drawing.Size(239, 82)
        '
        'UmbennenToolStripMenuItem
        '
        Me.UmbennenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.tab_edit
        Me.UmbennenToolStripMenuItem.Name = "UmbennenToolStripMenuItem"
        Me.UmbennenToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.UmbennenToolStripMenuItem.Text = "Vorlage -> Umbennen..."
        '
        'NeueVorlageAnlegenToolStripMenuItem
        '
        Me.NeueVorlageAnlegenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.NeueVorlageAnlegenToolStripMenuItem.Name = "NeueVorlageAnlegenToolStripMenuItem"
        Me.NeueVorlageAnlegenToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.NeueVorlageAnlegenToolStripMenuItem.Text = "Vorlage -> &Neu anlegen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(235, 6)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.delete
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.LöschenToolStripMenuItem.Text = "Vorlage -> &Löschen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Vorlage"
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(12, 18)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(363, 29)
        Me.yabe_dashboard_header.TabIndex = 35
        Me.yabe_dashboard_header.Text = "EiSo - Textvorlagen Editor"
        '
        'frmYABE_Vorlageneditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1144, 724)
        Me.Controls.Add(Me.yabe_dashboard_header)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbVorlage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbGruppierung)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSprache)
        Me.Controls.Add(Me.lblVorlagenHeader)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnLaden)
        Me.Controls.Add(Me.btnAbschickenNewsletter)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmYABE_Vorlageneditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo - Textvorlagen Editor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conNeueVorlage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbschickenNewsletter As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents lblVorlagenHeader As System.Windows.Forms.Label
    Friend WithEvents cmbSprache As System.Windows.Forms.ComboBox
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DHTMLControll As AxDHTMLEDLib.AxDHTMLEdit
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
    Friend WithEvents txtVorlageQuellcode As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnLaden As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmbGruppierung As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbVorlage As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents conNeueVorlage As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NeueVorlageAnlegenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbennenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
End Class
