<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaypal_status
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
        Me.lvwBestellverlauf = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.eBayBeschreibung = New System.Windows.Forms.ColumnHeader
        Me.Preis = New System.Windows.Forms.ColumnHeader
        Me.bids = New System.Windows.Forms.ColumnHeader
        Me.status = New System.Windows.Forms.ColumnHeader
        Me.yabe_auktionsende = New System.Windows.Forms.ColumnHeader
        Me.yabe_plattform = New System.Windows.Forms.ColumnHeader
        Me.versandkosten = New System.Windows.Forms.ColumnHeader
        Me.paypal = New System.Windows.Forms.ColumnHeader
        Me.mitglied = New System.Windows.Forms.ColumnHeader
        Me.email = New System.Windows.Forms.ColumnHeader
        Me.cmsBestellübersicht = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BestellstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BestelltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BezahltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerschicktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KomplettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.StorniertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SucheBestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SucheKundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SucheArtikelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblBestellverlauf = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnVor = New System.Windows.Forms.Button
        Me.btnBezahlt = New System.Windows.Forms.Button
        Me.btnVerschickt = New System.Windows.Forms.Button
        Me.lblKundendata = New System.Windows.Forms.Label
        Me.btnCloseForm = New System.Windows.Forms.Button
        Me.lblPaypalSumme = New System.Windows.Forms.Label
        Me.lblEinkauf = New System.Windows.Forms.Label
        Me.cmsBestellübersicht.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwBestellverlauf
        '
        Me.lvwBestellverlauf.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBestellverlauf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBestellverlauf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBestellverlauf.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.eBayBeschreibung, Me.Preis, Me.bids, Me.status, Me.yabe_auktionsende, Me.yabe_plattform, Me.versandkosten, Me.paypal, Me.mitglied, Me.email})
        Me.lvwBestellverlauf.ContextMenuStrip = Me.cmsBestellübersicht
        Me.lvwBestellverlauf.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBestellverlauf.FullRowSelect = True
        Me.lvwBestellverlauf.GridLines = True
        Me.lvwBestellverlauf.HideSelection = False
        Me.lvwBestellverlauf.Location = New System.Drawing.Point(12, 75)
        Me.lvwBestellverlauf.Name = "lvwBestellverlauf"
        Me.lvwBestellverlauf.Size = New System.Drawing.Size(877, 243)
        Me.lvwBestellverlauf.TabIndex = 3
        Me.lvwBestellverlauf.UseCompatibleStateImageBehavior = False
        Me.lvwBestellverlauf.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'eBayBeschreibung
        '
        Me.eBayBeschreibung.DisplayIndex = 6
        Me.eBayBeschreibung.Text = "Beschreibung"
        Me.eBayBeschreibung.Width = 365
        '
        'Preis
        '
        Me.Preis.DisplayIndex = 3
        Me.Preis.Text = "Endpreis"
        Me.Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Preis.Width = 70
        '
        'bids
        '
        Me.bids.DisplayIndex = 7
        Me.bids.Text = "Gebote"
        Me.bids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.bids.Width = 59
        '
        'status
        '
        Me.status.DisplayIndex = 1
        Me.status.Text = "Status"
        Me.status.Width = 141
        '
        'yabe_auktionsende
        '
        Me.yabe_auktionsende.DisplayIndex = 4
        Me.yabe_auktionsende.Text = "Auktionsende"
        Me.yabe_auktionsende.Width = 91
        '
        'yabe_plattform
        '
        Me.yabe_plattform.DisplayIndex = 5
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
        Me.paypal.DisplayIndex = 2
        Me.paypal.Text = "Paypal"
        Me.paypal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mitglied
        '
        Me.mitglied.Text = "Mitglied"
        '
        'email
        '
        Me.email.Text = "email"
        '
        'cmsBestellübersicht
        '
        Me.cmsBestellübersicht.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BestellstatusToolStripMenuItem, Me.ToolStripSeparator2, Me.SucheBestellungenToolStripMenuItem, Me.SucheKundeToolStripMenuItem, Me.SucheArtikelToolStripMenuItem, Me.ToolStripSeparator5, Me.ÜbersichtExportierenZumDruckenToolStripMenuItem})
        Me.cmsBestellübersicht.Name = "cmsBestellübersicht"
        Me.cmsBestellübersicht.Size = New System.Drawing.Size(313, 126)
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
        Me.BestelltToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BestelltToolStripMenuItem.Text = "&Bestellt"
        '
        'BezahltToolStripMenuItem
        '
        Me.BezahltToolStripMenuItem.Name = "BezahltToolStripMenuItem"
        Me.BezahltToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BezahltToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BezahltToolStripMenuItem.Text = "&Bezahlt"
        '
        'VerschicktToolStripMenuItem
        '
        Me.VerschicktToolStripMenuItem.Name = "VerschicktToolStripMenuItem"
        Me.VerschicktToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.VerschicktToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VerschicktToolStripMenuItem.Text = "&Verschickt"
        '
        'KomplettToolStripMenuItem
        '
        Me.KomplettToolStripMenuItem.Name = "KomplettToolStripMenuItem"
        Me.KomplettToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.KomplettToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.KomplettToolStripMenuItem.Text = "&Komplett"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'StorniertToolStripMenuItem
        '
        Me.StorniertToolStripMenuItem.Name = "StorniertToolStripMenuItem"
        Me.StorniertToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.StorniertToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.StorniertToolStripMenuItem.Text = "&Storniert"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(309, 6)
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
        Me.SucheArtikelToolStripMenuItem.Text = "Suche -> YABE &Artikeldatenbank"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(309, 6)
        '
        'ÜbersichtExportierenZumDruckenToolStripMenuItem
        '
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Name = "ÜbersichtExportierenZumDruckenToolStripMenuItem"
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.ÜbersichtExportierenZumDruckenToolStripMenuItem.Text = "&Übersicht -> Exportieren zum Drucken"
        '
        'lblBestellverlauf
        '
        Me.lblBestellverlauf.AutoSize = True
        Me.lblBestellverlauf.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestellverlauf.Location = New System.Drawing.Point(9, 9)
        Me.lblBestellverlauf.Name = "lblBestellverlauf"
        Me.lblBestellverlauf.Size = New System.Drawing.Size(184, 18)
        Me.lblBestellverlauf.TabIndex = 65
        Me.lblBestellverlauf.Text = "Paypal Status ändern"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(381, 336)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 23)
        Me.btnBack.TabIndex = 66
        Me.btnBack.Text = "&Zurück"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnVor
        '
        Me.btnVor.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(517, 336)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(129, 23)
        Me.btnVor.TabIndex = 67
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'btnBezahlt
        '
        Me.btnBezahlt.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnBezahlt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBezahlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBezahlt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBezahlt.Image = Global.YabE.My.Resources.Resources._24
        Me.btnBezahlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBezahlt.Location = New System.Drawing.Point(12, 336)
        Me.btnBezahlt.Name = "btnBezahlt"
        Me.btnBezahlt.Size = New System.Drawing.Size(129, 23)
        Me.btnBezahlt.TabIndex = 68
        Me.btnBezahlt.Text = "&Bezahlt"
        Me.btnBezahlt.UseVisualStyleBackColor = False
        '
        'btnVerschickt
        '
        Me.btnVerschickt.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnVerschickt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVerschickt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerschickt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerschickt.Image = Global.YabE.My.Resources.Resources._24
        Me.btnVerschickt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerschickt.Location = New System.Drawing.Point(162, 336)
        Me.btnVerschickt.Name = "btnVerschickt"
        Me.btnVerschickt.Size = New System.Drawing.Size(129, 23)
        Me.btnVerschickt.TabIndex = 69
        Me.btnVerschickt.Text = "&Verschickt"
        Me.btnVerschickt.UseVisualStyleBackColor = False
        '
        'lblKundendata
        '
        Me.lblKundendata.AutoSize = True
        Me.lblKundendata.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKundendata.Location = New System.Drawing.Point(17, 44)
        Me.lblKundendata.Name = "lblKundendata"
        Me.lblKundendata.Size = New System.Drawing.Size(0, 20)
        Me.lblKundendata.TabIndex = 70
        '
        'btnCloseForm
        '
        Me.btnCloseForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseForm.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseForm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseForm.Image = Global.YabE.My.Resources.Resources.abbrechen1
        Me.btnCloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseForm.Location = New System.Drawing.Point(744, 336)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(145, 23)
        Me.btnCloseForm.TabIndex = 71
        Me.btnCloseForm.Text = "Schließen"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'lblPaypalSumme
        '
        Me.lblPaypalSumme.AutoSize = True
        Me.lblPaypalSumme.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaypalSumme.Location = New System.Drawing.Point(585, 44)
        Me.lblPaypalSumme.Name = "lblPaypalSumme"
        Me.lblPaypalSumme.Size = New System.Drawing.Size(0, 20)
        Me.lblPaypalSumme.TabIndex = 72
        '
        'lblEinkauf
        '
        Me.lblEinkauf.AutoSize = True
        Me.lblEinkauf.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEinkauf.Location = New System.Drawing.Point(272, 44)
        Me.lblEinkauf.Name = "lblEinkauf"
        Me.lblEinkauf.Size = New System.Drawing.Size(0, 20)
        Me.lblEinkauf.TabIndex = 73
        '
        'frmPaypal_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 373)
        Me.Controls.Add(Me.lblEinkauf)
        Me.Controls.Add(Me.lblPaypalSumme)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.lblKundendata)
        Me.Controls.Add(Me.btnVerschickt)
        Me.Controls.Add(Me.btnBezahlt)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.lblBestellverlauf)
        Me.Controls.Add(Me.lvwBestellverlauf)
        Me.Name = "frmPaypal_status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paypal - Artikelstatus setzten"
        Me.cmsBestellübersicht.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwBestellverlauf As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayBeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents bids As System.Windows.Forms.ColumnHeader
    Friend WithEvents status As System.Windows.Forms.ColumnHeader
    Friend WithEvents yabe_auktionsende As System.Windows.Forms.ColumnHeader
    Friend WithEvents yabe_plattform As System.Windows.Forms.ColumnHeader
    Friend WithEvents versandkosten As System.Windows.Forms.ColumnHeader
    Friend WithEvents paypal As System.Windows.Forms.ColumnHeader
    Friend WithEvents mitglied As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblBestellverlauf As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnBezahlt As System.Windows.Forms.Button
    Friend WithEvents btnVerschickt As System.Windows.Forms.Button
    Friend WithEvents lblKundendata As System.Windows.Forms.Label
    Friend WithEvents btnCloseForm As System.Windows.Forms.Button
    Friend WithEvents lblPaypalSumme As System.Windows.Forms.Label
    Friend WithEvents cmsBestellübersicht As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BestellstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestelltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BezahltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschicktToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KomplettToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StorniertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SucheBestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheKundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheArtikelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ÜbersichtExportierenZumDruckenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEinkauf As System.Windows.Forms.Label
End Class
