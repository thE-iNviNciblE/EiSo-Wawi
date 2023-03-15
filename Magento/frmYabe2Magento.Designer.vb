<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYabe2Magento
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
        Me.yabe_dashboard_header = New System.Windows.Forms.Label
        Me.lvwMenue = New System.Windows.Forms.ListView
        Me.cms_kategorieID = New System.Windows.Forms.ColumnHeader
        Me.cms_menueName = New System.Windows.Forms.ColumnHeader
        Me.cms_clickcount = New System.Windows.Forms.ColumnHeader
        Me.cms_kategorie_delcampe = New System.Windows.Forms.ColumnHeader
        Me.cms_kategorie_magento = New System.Windows.Forms.ColumnHeader
        Me.cms_hauptkategorie = New System.Windows.Forms.ColumnHeader
        Me.cms_artikel = New System.Windows.Forms.ColumnHeader
        Me.lvwWebArtikel = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Beschreibung = New System.Windows.Forms.ColumnHeader
        Me.Preis = New System.Windows.Forms.ColumnHeader
        Me.Bild = New System.Windows.Forms.ColumnHeader
        Me.magento_id = New System.Windows.Forms.ColumnHeader
        Me.delcampe_id = New System.Windows.Forms.ColumnHeader
        Me.cms_datum = New System.Windows.Forms.ColumnHeader
        Me.cmsBlidCounter = New System.Windows.Forms.ColumnHeader
        Me.cmsStatus = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMagentoKategorien = New System.Windows.Forms.TextBox
        Me.pgrStatus = New System.Windows.Forms.ProgressBar
        Me.btnImport2Magento = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbSichtbarkeit = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAttributset = New System.Windows.Forms.ComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnThread = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MagentoArtikelLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MagentoArtikelNeuHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MagentoArtikelBestelltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MagentoArtikelAktivToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(10, 10)
        Me.yabe_dashboard_header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(298, 23)
        Me.yabe_dashboard_header.TabIndex = 36
        Me.yabe_dashboard_header.Text = "YabE zu Magento Importer"
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
        Me.lvwMenue.Location = New System.Drawing.Point(10, 40)
        Me.lvwMenue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lvwMenue.Name = "lvwMenue"
        Me.lvwMenue.ShowItemToolTips = True
        Me.lvwMenue.Size = New System.Drawing.Size(264, 535)
        Me.lvwMenue.TabIndex = 37
        Me.lvwMenue.UseCompatibleStateImageBehavior = False
        Me.lvwMenue.View = System.Windows.Forms.View.Details
        '
        'cms_kategorieID
        '
        Me.cms_kategorieID.DisplayIndex = 4
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
        Me.cms_clickcount.DisplayIndex = 3
        Me.cms_clickcount.Text = "Zugriffe"
        Me.cms_clickcount.Width = 73
        '
        'cms_kategorie_delcampe
        '
        Me.cms_kategorie_delcampe.DisplayIndex = 5
        Me.cms_kategorie_delcampe.Text = "DelcampeID"
        Me.cms_kategorie_delcampe.Width = 0
        '
        'cms_kategorie_magento
        '
        Me.cms_kategorie_magento.DisplayIndex = 1
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
        Me.cms_artikel.DisplayIndex = 2
        Me.cms_artikel.Text = "Artikel"
        '
        'lvwWebArtikel
        '
        Me.lvwWebArtikel.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwWebArtikel.AllowColumnReorder = True
        Me.lvwWebArtikel.AllowDrop = True
        Me.lvwWebArtikel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwWebArtikel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwWebArtikel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Beschreibung, Me.Preis, Me.Bild, Me.magento_id, Me.delcampe_id, Me.cms_datum, Me.cmsBlidCounter, Me.cmsStatus})
        Me.lvwWebArtikel.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwWebArtikel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwWebArtikel.FullRowSelect = True
        Me.lvwWebArtikel.GridLines = True
        Me.lvwWebArtikel.HideSelection = False
        Me.lvwWebArtikel.Location = New System.Drawing.Point(281, 40)
        Me.lvwWebArtikel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lvwWebArtikel.Name = "lvwWebArtikel"
        Me.lvwWebArtikel.ShowItemToolTips = True
        Me.lvwWebArtikel.Size = New System.Drawing.Size(418, 535)
        Me.lvwWebArtikel.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwWebArtikel.TabIndex = 38
        Me.lvwWebArtikel.UseCompatibleStateImageBehavior = False
        Me.lvwWebArtikel.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "WebID"
        '
        'Beschreibung
        '
        Me.Beschreibung.DisplayIndex = 5
        Me.Beschreibung.Text = "Beschreibung"
        Me.Beschreibung.Width = 475
        '
        'Preis
        '
        Me.Preis.DisplayIndex = 6
        Me.Preis.Text = "Preis"
        Me.Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Preis.Width = 51
        '
        'Bild
        '
        Me.Bild.DisplayIndex = 8
        Me.Bild.Text = "Bild"
        Me.Bild.Width = 0
        '
        'magento_id
        '
        Me.magento_id.DisplayIndex = 1
        Me.magento_id.Text = "MagentoID"
        Me.magento_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.magento_id.Width = 78
        '
        'delcampe_id
        '
        Me.delcampe_id.DisplayIndex = 2
        Me.delcampe_id.Text = "DelcampeID"
        Me.delcampe_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.delcampe_id.Width = 0
        '
        'cms_datum
        '
        Me.cms_datum.DisplayIndex = 7
        Me.cms_datum.Text = "Datum"
        Me.cms_datum.Width = 82
        '
        'cmsBlidCounter
        '
        Me.cmsBlidCounter.DisplayIndex = 3
        Me.cmsBlidCounter.Text = "Counter"
        Me.cmsBlidCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmsStatus
        '
        Me.cmsStatus.DisplayIndex = 4
        Me.cmsStatus.Text = "Status"
        Me.cmsStatus.Width = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 621)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 14)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Magento Kategorien"
        '
        'txtMagentoKategorien
        '
        Me.txtMagentoKategorien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoKategorien.Location = New System.Drawing.Point(10, 638)
        Me.txtMagentoKategorien.Name = "txtMagentoKategorien"
        Me.txtMagentoKategorien.Size = New System.Drawing.Size(129, 20)
        Me.txtMagentoKategorien.TabIndex = 40
        '
        'pgrStatus
        '
        Me.pgrStatus.Location = New System.Drawing.Point(10, 581)
        Me.pgrStatus.Name = "pgrStatus"
        Me.pgrStatus.Size = New System.Drawing.Size(689, 23)
        Me.pgrStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgrStatus.TabIndex = 41
        '
        'btnImport2Magento
        '
        Me.btnImport2Magento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport2Magento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport2Magento.Image = Global.YabE.My.Resources.Resources._03
        Me.btnImport2Magento.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnImport2Magento.Location = New System.Drawing.Point(477, 679)
        Me.btnImport2Magento.Name = "btnImport2Magento"
        Me.btnImport2Magento.Size = New System.Drawing.Size(218, 23)
        Me.btnImport2Magento.TabIndex = 42
        Me.btnImport2Magento.Text = "Import starten..."
        Me.btnImport2Magento.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(157, 621)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 14)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Sichtbarkeit"
        '
        'cmbSichtbarkeit
        '
        Me.cmbSichtbarkeit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSichtbarkeit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSichtbarkeit.FormattingEnabled = True
        Me.cmbSichtbarkeit.Items.AddRange(New Object() {"Einzeln nicht sichtbar", "Katalog", "Suche", "Katalog,Suche"})
        Me.cmbSichtbarkeit.Location = New System.Drawing.Point(160, 638)
        Me.cmbSichtbarkeit.Name = "cmbSichtbarkeit"
        Me.cmbSichtbarkeit.Size = New System.Drawing.Size(218, 23)
        Me.cmbSichtbarkeit.TabIndex = 43
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(398, 621)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 14)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Aktiviert", "Inaktiv"})
        Me.cmbStatus.Location = New System.Drawing.Point(401, 637)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(128, 23)
        Me.cmbStatus.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 661)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Atributset"
        '
        'cmbAttributset
        '
        Me.cmbAttributset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttributset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAttributset.FormattingEnabled = True
        Me.cmbAttributset.Items.AddRange(New Object() {"25", "26"})
        Me.cmbAttributset.Location = New System.Drawing.Point(10, 677)
        Me.cmbAttributset.Name = "cmbAttributset"
        Me.cmbAttributset.Size = New System.Drawing.Size(198, 23)
        Me.cmbAttributset.TabIndex = 47
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 711)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(705, 22)
        Me.StatusStrip1.TabIndex = 49
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'btnThread
        '
        Me.btnThread.Location = New System.Drawing.Point(396, 679)
        Me.btnThread.Name = "btnThread"
        Me.btnThread.Size = New System.Drawing.Size(75, 23)
        Me.btnThread.TabIndex = 50
        Me.btnThread.Text = "Button1"
        Me.btnThread.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MagentoArtikelLöschenToolStripMenuItem, Me.MagentoArtikelNeuHinzufügenToolStripMenuItem, Me.MagentoArtikelBestelltToolStripMenuItem, Me.MagentoArtikelAktivToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(264, 114)
        '
        'MagentoArtikelLöschenToolStripMenuItem
        '
        Me.MagentoArtikelLöschenToolStripMenuItem.Name = "MagentoArtikelLöschenToolStripMenuItem"
        Me.MagentoArtikelLöschenToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.MagentoArtikelLöschenToolStripMenuItem.Text = "&Magento Artikel -> Löschen"
        '
        'MagentoArtikelNeuHinzufügenToolStripMenuItem
        '
        Me.MagentoArtikelNeuHinzufügenToolStripMenuItem.Name = "MagentoArtikelNeuHinzufügenToolStripMenuItem"
        Me.MagentoArtikelNeuHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.MagentoArtikelNeuHinzufügenToolStripMenuItem.Text = "Magento Artikel -> Neu hinzufügen"
        '
        'MagentoArtikelBestelltToolStripMenuItem
        '
        Me.MagentoArtikelBestelltToolStripMenuItem.Name = "MagentoArtikelBestelltToolStripMenuItem"
        Me.MagentoArtikelBestelltToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.MagentoArtikelBestelltToolStripMenuItem.Text = "Magento Artikel -> Bestellt"
        '
        'MagentoArtikelAktivToolStripMenuItem
        '
        Me.MagentoArtikelAktivToolStripMenuItem.Name = "MagentoArtikelAktivToolStripMenuItem"
        Me.MagentoArtikelAktivToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.MagentoArtikelAktivToolStripMenuItem.Text = "Magento Artikel -> Aktiv"
        '
        'frmYabe2Magento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 733)
        Me.Controls.Add(Me.btnThread)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAttributset)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmbSichtbarkeit)
        Me.Controls.Add(Me.btnImport2Magento)
        Me.Controls.Add(Me.pgrStatus)
        Me.Controls.Add(Me.txtMagentoKategorien)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwWebArtikel)
        Me.Controls.Add(Me.lvwMenue)
        Me.Controls.Add(Me.yabe_dashboard_header)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmYabe2Magento"
        Me.Text = "YabE 2 Magento"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
    Friend WithEvents lvwMenue As System.Windows.Forms.ListView
    Friend WithEvents cms_kategorieID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_menueName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_clickcount As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_kategorie_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_kategorie_magento As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_hauptkategorie As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_artikel As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwWebArtikel As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Beschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents Bild As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents delcampe_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_datum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsBlidCounter As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoKategorien As System.Windows.Forms.TextBox
    Friend WithEvents pgrStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents btnImport2Magento As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbSichtbarkeit As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAttributset As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnThread As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MagentoArtikelLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoArtikelNeuHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoArtikelBestelltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoArtikelAktivToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
