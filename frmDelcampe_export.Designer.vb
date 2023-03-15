<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelcampe_export
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelcampe_export))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbDelcampe = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDelcampeSteigerung = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkDelcampeAuktion = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbErneuern = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDelcampe_erneuern = New System.Windows.Forms.TextBox()
        Me.chkDelcampe3 = New System.Windows.Forms.CheckBox()
        Me.btnLoadSelectedList = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbÜberschriftSprache = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbTextVorlageDelcampe = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDelcampePlattform = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDelcampe_enduhrzeit = New System.Windows.Forms.TextBox()
        Me.cmbDelcampe_auslauftag = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUntertitel = New System.Windows.Forms.TextBox()
        Me.chkDelcampe_description_no_image = New System.Windows.Forms.CheckBox()
        Me.chkDelcampe_startseite = New System.Windows.Forms.CheckBox()
        Me.ckkDelcampe_category_top = New System.Windows.Forms.CheckBox()
        Me.chkDelcampe_listing_top = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkDelcampe_untertitel = New System.Windows.Forms.CheckBox()
        Me.chkDelcampe_umrandet = New System.Windows.Forms.CheckBox()
        Me.chkFluoresierend = New System.Windows.Forms.CheckBox()
        Me.chkDelcampe_TitelFett = New System.Windows.Forms.CheckBox()
        Me.chkDelcampe_last_minute = New System.Windows.Forms.CheckBox()
        Me.chkDelcampe_privat = New System.Windows.Forms.CheckBox()
        Me.lvwMultiSelect = New System.Windows.Forms.ListView()
        Me.item_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_descrition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_delcampe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_ebay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_magento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenu_Listview = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelektierteArtikelEntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.yabe_dashboard_header = New System.Windows.Forms.Label()
        Me.cmbDelcampeDauer = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnDelcampeAPI = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbDelcampe.SuspendLayout()
        Me.ContextMenu_Listview.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tbDelcampe)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1064, 577)
        Me.TabControl1.TabIndex = 0
        '
        'tbDelcampe
        '
        Me.tbDelcampe.BackColor = System.Drawing.Color.Gainsboro
        Me.tbDelcampe.Controls.Add(Me.btnDelcampeAPI)
        Me.tbDelcampe.Controls.Add(Me.Label13)
        Me.tbDelcampe.Controls.Add(Me.txtDelcampeSteigerung)
        Me.tbDelcampe.Controls.Add(Me.Label12)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampeAuktion)
        Me.tbDelcampe.Controls.Add(Me.Label11)
        Me.tbDelcampe.Controls.Add(Me.cmbErneuern)
        Me.tbDelcampe.Controls.Add(Me.Label6)
        Me.tbDelcampe.Controls.Add(Me.txtDelcampe_erneuern)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe3)
        Me.tbDelcampe.Controls.Add(Me.btnLoadSelectedList)
        Me.tbDelcampe.Controls.Add(Me.Label3)
        Me.tbDelcampe.Controls.Add(Me.Label10)
        Me.tbDelcampe.Controls.Add(Me.cmbÜberschriftSprache)
        Me.tbDelcampe.Controls.Add(Me.Label9)
        Me.tbDelcampe.Controls.Add(Me.cmbTextVorlageDelcampe)
        Me.tbDelcampe.Controls.Add(Me.Label8)
        Me.tbDelcampe.Controls.Add(Me.cmbDelcampePlattform)
        Me.tbDelcampe.Controls.Add(Me.Button1)
        Me.tbDelcampe.Controls.Add(Me.Button3)
        Me.tbDelcampe.Controls.Add(Me.Label7)
        Me.tbDelcampe.Controls.Add(Me.txtDelcampe_enduhrzeit)
        Me.tbDelcampe.Controls.Add(Me.cmbDelcampe_auslauftag)
        Me.tbDelcampe.Controls.Add(Me.Label5)
        Me.tbDelcampe.Controls.Add(Me.txtUntertitel)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_description_no_image)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_startseite)
        Me.tbDelcampe.Controls.Add(Me.ckkDelcampe_category_top)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_listing_top)
        Me.tbDelcampe.Controls.Add(Me.Label4)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_untertitel)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_umrandet)
        Me.tbDelcampe.Controls.Add(Me.chkFluoresierend)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_TitelFett)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_last_minute)
        Me.tbDelcampe.Controls.Add(Me.chkDelcampe_privat)
        Me.tbDelcampe.Controls.Add(Me.lvwMultiSelect)
        Me.tbDelcampe.Controls.Add(Me.Label1)
        Me.tbDelcampe.Controls.Add(Me.Label2)
        Me.tbDelcampe.Controls.Add(Me.yabe_dashboard_header)
        Me.tbDelcampe.Controls.Add(Me.cmbDelcampeDauer)
        Me.tbDelcampe.Location = New System.Drawing.Point(4, 29)
        Me.tbDelcampe.Name = "tbDelcampe"
        Me.tbDelcampe.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDelcampe.Size = New System.Drawing.Size(1056, 544)
        Me.tbDelcampe.TabIndex = 0
        Me.tbDelcampe.Text = "Delcampe"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(631, 461)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 17)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Export Optionen"
        '
        'txtDelcampeSteigerung
        '
        Me.txtDelcampeSteigerung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelcampeSteigerung.Location = New System.Drawing.Point(196, 522)
        Me.txtDelcampeSteigerung.Name = "txtDelcampeSteigerung"
        Me.txtDelcampeSteigerung.Size = New System.Drawing.Size(66, 24)
        Me.txtDelcampeSteigerung.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.txtDelcampeSteigerung, "Preissteigerung beim nächsten Bieter Schritt")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(193, 506)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 17)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Steigerung"
        '
        'chkDelcampeAuktion
        '
        Me.chkDelcampeAuktion.AutoSize = True
        Me.chkDelcampeAuktion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampeAuktion.Location = New System.Drawing.Point(21, 525)
        Me.chkDelcampeAuktion.Name = "chkDelcampeAuktion"
        Me.chkDelcampeAuktion.Size = New System.Drawing.Size(80, 21)
        Me.chkDelcampeAuktion.TabIndex = 74
        Me.chkDelcampeAuktion.Text = "&Auktion"
        Me.ToolTip1.SetToolTip(Me.chkDelcampeAuktion, "Auktion oder Sofortkauf")
        Me.chkDelcampeAuktion.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 506)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1030, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Auktion / Sofortkauf"
        '
        'cmbErneuern
        '
        Me.cmbErneuern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbErneuern.FormattingEnabled = True
        Me.cmbErneuern.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "99"})
        Me.cmbErneuern.Location = New System.Drawing.Point(422, 477)
        Me.cmbErneuern.Name = "cmbErneuern"
        Me.cmbErneuern.Size = New System.Drawing.Size(121, 25)
        Me.cmbErneuern.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.cmbErneuern, "Wie oft sollen die Artikel wiedereingestellt werden?")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(419, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Erneuern"
        '
        'txtDelcampe_erneuern
        '
        Me.txtDelcampe_erneuern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelcampe_erneuern.Location = New System.Drawing.Point(549, 478)
        Me.txtDelcampe_erneuern.Name = "txtDelcampe_erneuern"
        Me.txtDelcampe_erneuern.Size = New System.Drawing.Size(66, 24)
        Me.txtDelcampe_erneuern.TabIndex = 70
        Me.txtDelcampe_erneuern.Visible = False
        '
        'chkDelcampe3
        '
        Me.chkDelcampe3.AutoSize = True
        Me.chkDelcampe3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe3.Location = New System.Drawing.Point(881, 478)
        Me.chkDelcampe3.Name = "chkDelcampe3"
        Me.chkDelcampe3.Size = New System.Drawing.Size(151, 21)
        Me.chkDelcampe3.TabIndex = 69
        Me.chkDelcampe3.Text = "Delcampe Lister 3"
        Me.ToolTip1.SetToolTip(Me.chkDelcampe3, "Export für Delcampe Lister2 oder Delcampe Lister 3")
        Me.chkDelcampe3.UseVisualStyleBackColor = True
        '
        'btnLoadSelectedList
        '
        Me.btnLoadSelectedList.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnLoadSelectedList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadSelectedList.Location = New System.Drawing.Point(386, 25)
        Me.btnLoadSelectedList.Name = "btnLoadSelectedList"
        Me.btnLoadSelectedList.Size = New System.Drawing.Size(180, 23)
        Me.btnLoadSelectedList.TabIndex = 68
        Me.btnLoadSelectedList.Text = "Lade Selektierte Artikeliste"
        Me.btnLoadSelectedList.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Zusatz Optionen..."
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(233, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Überschriftsprache"
        '
        'cmbÜberschriftSprache
        '
        Me.cmbÜberschriftSprache.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbÜberschriftSprache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbÜberschriftSprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbÜberschriftSprache.FormattingEnabled = True
        Me.cmbÜberschriftSprache.Location = New System.Drawing.Point(229, 417)
        Me.cmbÜberschriftSprache.Name = "cmbÜberschriftSprache"
        Me.cmbÜberschriftSprache.Size = New System.Drawing.Size(172, 25)
        Me.cmbÜberschriftSprache.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 398)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(383, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Vorlagensprache"
        '
        'cmbTextVorlageDelcampe
        '
        Me.cmbTextVorlageDelcampe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbTextVorlageDelcampe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTextVorlageDelcampe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTextVorlageDelcampe.FormattingEnabled = True
        Me.cmbTextVorlageDelcampe.Items.AddRange(New Object() {"Deutsch", "Englisch"})
        Me.cmbTextVorlageDelcampe.Location = New System.Drawing.Point(21, 417)
        Me.cmbTextVorlageDelcampe.Name = "cmbTextVorlageDelcampe"
        Me.cmbTextVorlageDelcampe.Size = New System.Drawing.Size(185, 25)
        Me.cmbTextVorlageDelcampe.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(226, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Einstellplattform"
        '
        'cmbDelcampePlattform
        '
        Me.cmbDelcampePlattform.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDelcampePlattform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelcampePlattform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDelcampePlattform.FormattingEnabled = True
        Me.cmbDelcampePlattform.Items.AddRange(New Object() {"Nur International", "Deutschland + International"})
        Me.cmbDelcampePlattform.Location = New System.Drawing.Point(229, 348)
        Me.cmbDelcampePlattform.Name = "cmbDelcampePlattform"
        Me.cmbDelcampePlattform.Size = New System.Drawing.Size(172, 25)
        Me.cmbDelcampePlattform.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmbDelcampePlattform, "International / DE + Int.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.YabE.My.Resources.Resources._03
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(634, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Artikel als CSV speichern"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(881, 522)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "&Abbrechen"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(295, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "End-Uhrzeit"
        '
        'txtDelcampe_enduhrzeit
        '
        Me.txtDelcampe_enduhrzeit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelcampe_enduhrzeit.Location = New System.Drawing.Point(298, 477)
        Me.txtDelcampe_enduhrzeit.Name = "txtDelcampe_enduhrzeit"
        Me.txtDelcampe_enduhrzeit.Size = New System.Drawing.Size(103, 24)
        Me.txtDelcampe_enduhrzeit.TabIndex = 6
        Me.txtDelcampe_enduhrzeit.Text = "00:00:00"
        Me.txtDelcampe_enduhrzeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDelcampe_auslauftag
        '
        Me.cmbDelcampe_auslauftag.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDelcampe_auslauftag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelcampe_auslauftag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDelcampe_auslauftag.FormattingEnabled = True
        Me.cmbDelcampe_auslauftag.Items.AddRange(New Object() {"Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"})
        Me.cmbDelcampe_auslauftag.Location = New System.Drawing.Point(21, 477)
        Me.cmbDelcampe_auslauftag.Name = "cmbDelcampe_auslauftag"
        Me.cmbDelcampe_auslauftag.Size = New System.Drawing.Size(239, 25)
        Me.cmbDelcampe_auslauftag.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1030, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Auslauf Tag"
        '
        'txtUntertitel
        '
        Me.txtUntertitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUntertitel.Location = New System.Drawing.Point(634, 395)
        Me.txtUntertitel.Name = "txtUntertitel"
        Me.txtUntertitel.Size = New System.Drawing.Size(160, 24)
        Me.txtUntertitel.TabIndex = 54
        Me.txtUntertitel.Visible = False
        '
        'chkDelcampe_description_no_image
        '
        Me.chkDelcampe_description_no_image.AutoSize = True
        Me.chkDelcampe_description_no_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_description_no_image.Location = New System.Drawing.Point(634, 477)
        Me.chkDelcampe_description_no_image.Name = "chkDelcampe_description_no_image"
        Me.chkDelcampe_description_no_image.Size = New System.Drawing.Size(289, 21)
        Me.chkDelcampe_description_no_image.TabIndex = 53
        Me.chkDelcampe_description_no_image.Text = "&Kein eigenes Bild in der Beschreibung"
        Me.ToolTip1.SetToolTip(Me.chkDelcampe_description_no_image, "Artikel besitzen kein eigenes Bild in der Beschreibung")
        Me.chkDelcampe_description_no_image.UseVisualStyleBackColor = True
        '
        'chkDelcampe_startseite
        '
        Me.chkDelcampe_startseite.AutoSize = True
        Me.chkDelcampe_startseite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_startseite.Location = New System.Drawing.Point(818, 395)
        Me.chkDelcampe_startseite.Name = "chkDelcampe_startseite"
        Me.chkDelcampe_startseite.Size = New System.Drawing.Size(192, 21)
        Me.chkDelcampe_startseite.TabIndex = 52
        Me.chkDelcampe_startseite.Text = "Auf der Startseite (4 €)"
        Me.chkDelcampe_startseite.UseVisualStyleBackColor = True
        '
        'ckkDelcampe_category_top
        '
        Me.ckkDelcampe_category_top.AutoSize = True
        Me.ckkDelcampe_category_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckkDelcampe_category_top.Location = New System.Drawing.Point(818, 372)
        Me.ckkDelcampe_category_top.Name = "ckkDelcampe_category_top"
        Me.ckkDelcampe_category_top.Size = New System.Drawing.Size(289, 21)
        Me.ckkDelcampe_category_top.TabIndex = 51
        Me.ckkDelcampe_category_top.Text = "In der Kategorie ganz oben (+ 2,4 €)"
        Me.ckkDelcampe_category_top.UseVisualStyleBackColor = True
        '
        'chkDelcampe_listing_top
        '
        Me.chkDelcampe_listing_top.AutoSize = True
        Me.chkDelcampe_listing_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_listing_top.Location = New System.Drawing.Point(818, 349)
        Me.chkDelcampe_listing_top.Name = "chkDelcampe_listing_top"
        Me.chkDelcampe_listing_top.Size = New System.Drawing.Size(239, 21)
        Me.chkDelcampe_listing_top.TabIndex = 50
        Me.chkDelcampe_listing_top.Text = "&In der Liste ganz oben (0,8 €)"
        Me.chkDelcampe_listing_top.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(815, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Kategorie Optionen"
        '
        'chkDelcampe_untertitel
        '
        Me.chkDelcampe_untertitel.AutoSize = True
        Me.chkDelcampe_untertitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_untertitel.Location = New System.Drawing.Point(634, 372)
        Me.chkDelcampe_untertitel.Name = "chkDelcampe_untertitel"
        Me.chkDelcampe_untertitel.Size = New System.Drawing.Size(91, 21)
        Me.chkDelcampe_untertitel.TabIndex = 48
        Me.chkDelcampe_untertitel.Text = "&Untertitel"
        Me.chkDelcampe_untertitel.UseVisualStyleBackColor = True
        '
        'chkDelcampe_umrandet
        '
        Me.chkDelcampe_umrandet.AutoSize = True
        Me.chkDelcampe_umrandet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_umrandet.Location = New System.Drawing.Point(634, 349)
        Me.chkDelcampe_umrandet.Name = "chkDelcampe_umrandet"
        Me.chkDelcampe_umrandet.Size = New System.Drawing.Size(142, 21)
        Me.chkDelcampe_umrandet.TabIndex = 47
        Me.chkDelcampe_umrandet.Text = "&Farbig umrandet"
        Me.chkDelcampe_umrandet.UseVisualStyleBackColor = True
        '
        'chkFluoresierend
        '
        Me.chkFluoresierend.AutoSize = True
        Me.chkFluoresierend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFluoresierend.Location = New System.Drawing.Point(460, 418)
        Me.chkFluoresierend.Name = "chkFluoresierend"
        Me.chkFluoresierend.Size = New System.Drawing.Size(128, 21)
        Me.chkFluoresierend.TabIndex = 46
        Me.chkFluoresierend.Text = "&Fluroeszierend"
        Me.chkFluoresierend.UseVisualStyleBackColor = True
        '
        'chkDelcampe_TitelFett
        '
        Me.chkDelcampe_TitelFett.AutoSize = True
        Me.chkDelcampe_TitelFett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_TitelFett.Location = New System.Drawing.Point(460, 395)
        Me.chkDelcampe_TitelFett.Name = "chkDelcampe_TitelFett"
        Me.chkDelcampe_TitelFett.Size = New System.Drawing.Size(177, 21)
        Me.chkDelcampe_TitelFett.TabIndex = 45
        Me.chkDelcampe_TitelFett.Text = "&Titel Fett geschrieben"
        Me.chkDelcampe_TitelFett.UseVisualStyleBackColor = True
        '
        'chkDelcampe_last_minute
        '
        Me.chkDelcampe_last_minute.AutoSize = True
        Me.chkDelcampe_last_minute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_last_minute.Location = New System.Drawing.Point(460, 372)
        Me.chkDelcampe_last_minute.Name = "chkDelcampe_last_minute"
        Me.chkDelcampe_last_minute.Size = New System.Drawing.Size(177, 21)
        Me.chkDelcampe_last_minute.TabIndex = 44
        Me.chkDelcampe_last_minute.Text = "&Last Minute  Angebot"
        Me.chkDelcampe_last_minute.UseVisualStyleBackColor = True
        '
        'chkDelcampe_privat
        '
        Me.chkDelcampe_privat.AutoSize = True
        Me.chkDelcampe_privat.Checked = True
        Me.chkDelcampe_privat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDelcampe_privat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelcampe_privat.Location = New System.Drawing.Point(460, 349)
        Me.chkDelcampe_privat.Name = "chkDelcampe_privat"
        Me.chkDelcampe_privat.Size = New System.Drawing.Size(132, 21)
        Me.chkDelcampe_privat.TabIndex = 43
        Me.chkDelcampe_privat.Text = "&Private Auktion"
        Me.chkDelcampe_privat.UseVisualStyleBackColor = True
        '
        'lvwMultiSelect
        '
        Me.lvwMultiSelect.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMultiSelect.AllowColumnReorder = True
        Me.lvwMultiSelect.AllowDrop = True
        Me.lvwMultiSelect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMultiSelect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMultiSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMultiSelect.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.item_id, Me.item_descrition, Me.item_delcampe, Me.item_ebay, Me.item_magento})
        Me.lvwMultiSelect.ContextMenuStrip = Me.ContextMenu_Listview
        Me.lvwMultiSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lvwMultiSelect.FullRowSelect = True
        Me.lvwMultiSelect.GridLines = True
        Me.lvwMultiSelect.HideSelection = False
        Me.lvwMultiSelect.HoverSelection = True
        Me.lvwMultiSelect.Location = New System.Drawing.Point(21, 67)
        Me.lvwMultiSelect.Name = "lvwMultiSelect"
        Me.lvwMultiSelect.ShowItemToolTips = True
        Me.lvwMultiSelect.Size = New System.Drawing.Size(1027, 243)
        Me.lvwMultiSelect.TabIndex = 0
        Me.lvwMultiSelect.UseCompatibleStateImageBehavior = False
        Me.lvwMultiSelect.View = System.Windows.Forms.View.Details
        '
        'item_id
        '
        Me.item_id.Text = "ID"
        Me.item_id.Width = 74
        '
        'item_descrition
        '
        Me.item_descrition.Text = "Beschreibung"
        Me.item_descrition.Width = 378
        '
        'item_delcampe
        '
        Me.item_delcampe.Text = "DelcampeID"
        Me.item_delcampe.Width = 89
        '
        'item_ebay
        '
        Me.item_ebay.Text = "eBayID"
        '
        'item_magento
        '
        Me.item_magento.Text = "MagentoID"
        Me.item_magento.Width = 89
        '
        'ContextMenu_Listview
        '
        Me.ContextMenu_Listview.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelektierteArtikelEntfernenToolStripMenuItem})
        Me.ContextMenu_Listview.Name = "ContextMenu_Listview"
        Me.ContextMenu_Listview.Size = New System.Drawing.Size(263, 28)
        '
        'SelektierteArtikelEntfernenToolStripMenuItem
        '
        Me.SelektierteArtikelEntfernenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.SelektierteArtikelEntfernenToolStripMenuItem.Name = "SelektierteArtikelEntfernenToolStripMenuItem"
        Me.SelektierteArtikelEntfernenToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.SelektierteArtikelEntfernenToolStripMenuItem.Text = "Selektierte Artikel entfernen"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1027, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Ausgewählte Artikel"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(978, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Auktionsdauer Dauer "
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(17, 15)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(410, 29)
        Me.yabe_dashboard_header.TabIndex = 35
        Me.yabe_dashboard_header.Text = "EiSo - Export Delcampe Lister"
        '
        'cmbDelcampeDauer
        '
        Me.cmbDelcampeDauer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDelcampeDauer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelcampeDauer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDelcampeDauer.FormattingEnabled = True
        Me.cmbDelcampeDauer.Items.AddRange(New Object() {"7", "10", "14", "21", "28"})
        Me.cmbDelcampeDauer.Location = New System.Drawing.Point(21, 352)
        Me.cmbDelcampeDauer.Name = "cmbDelcampeDauer"
        Me.cmbDelcampeDauer.Size = New System.Drawing.Size(185, 25)
        Me.cmbDelcampeDauer.TabIndex = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Delcampe Lister Export "
        '
        'btnDelcampeAPI
        '
        Me.btnDelcampeAPI.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnDelcampeAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelcampeAPI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelcampeAPI.Image = Global.YabE.My.Resources.Resources._03
        Me.btnDelcampeAPI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelcampeAPI.Location = New System.Drawing.Point(386, 522)
        Me.btnDelcampeAPI.Name = "btnDelcampeAPI"
        Me.btnDelcampeAPI.Size = New System.Drawing.Size(236, 23)
        Me.btnDelcampeAPI.TabIndex = 78
        Me.btnDelcampeAPI.Text = "&Delcampe API übertragen"
        Me.btnDelcampeAPI.UseVisualStyleBackColor = False
        '
        'frmDelcampe_export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 577)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDelcampe_export"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YABE Export für den Delcampe Lister"
        Me.TabControl1.ResumeLayout(False)
        Me.tbDelcampe.ResumeLayout(False)
        Me.tbDelcampe.PerformLayout()
        Me.ContextMenu_Listview.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbDelcampe As System.Windows.Forms.TabPage
    Friend WithEvents cmbDelcampeDauer As System.Windows.Forms.ComboBox
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvwMultiSelect As System.Windows.Forms.ListView
    Friend WithEvents item_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_descrition As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_ebay As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_magento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkDelcampe_privat As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelcampe_last_minute As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelcampe_TitelFett As System.Windows.Forms.CheckBox
    Friend WithEvents chkFluoresierend As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelcampe_umrandet As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelcampe_untertitel As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDelcampe_listing_top As System.Windows.Forms.CheckBox
    Friend WithEvents ckkDelcampe_category_top As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelcampe_startseite As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelcampe_description_no_image As System.Windows.Forms.CheckBox
    Friend WithEvents txtUntertitel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDelcampe_auslauftag As System.Windows.Forms.ComboBox
    Friend WithEvents txtDelcampe_enduhrzeit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbDelcampePlattform As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTextVorlageDelcampe As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbÜberschriftSprache As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenu_Listview As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelektierteArtikelEntfernenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLoadSelectedList As System.Windows.Forms.Button
    Friend WithEvents chkDelcampe3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDelcampe_erneuern As System.Windows.Forms.TextBox
    Friend WithEvents cmbErneuern As System.Windows.Forms.ComboBox
    Friend WithEvents chkDelcampeAuktion As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDelcampeSteigerung As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnDelcampeAPI As System.Windows.Forms.Button
End Class
