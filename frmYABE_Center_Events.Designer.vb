<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYABE_Center_Events
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYABE_Center_Events))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.Preis = New System.Windows.Forms.ColumnHeader
        Me.Nachricht = New System.Windows.Forms.ColumnHeader
        Me.mitglied = New System.Windows.Forms.ColumnHeader
        Me.bids = New System.Windows.Forms.ColumnHeader
        Me.lvwLiveAnsicht = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyEBayIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Copy_Beschreibung = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.LiveÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmeBayLive_Detailansicht = New System.Windows.Forms.ToolStripMenuItem
        Me.BietverlaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HöchstbietenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.chkBidsOnly = New System.Windows.Forms.CheckBox
        Me.lblInfopanel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.lvwLiveAnsicht.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.517241!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.48276!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(301, 201)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(98, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.NavajoWhite
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(12, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Preis, Me.Nachricht, Me.mitglied, Me.bids})
        Me.ListView1.ContextMenuStrip = Me.lvwLiveAnsicht
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HotTracking = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(10, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(389, 187)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'Preis
        '
        Me.Preis.DisplayIndex = 4
        Me.Preis.Text = "Preis"
        '
        'Nachricht
        '
        Me.Nachricht.DisplayIndex = 1
        Me.Nachricht.Text = "Nachricht"
        Me.Nachricht.Width = 204
        '
        'mitglied
        '
        Me.mitglied.DisplayIndex = 2
        Me.mitglied.Text = "Mitglied"
        '
        'bids
        '
        Me.bids.DisplayIndex = 3
        Me.bids.Text = "bids"
        '
        'lvwLiveAnsicht
        '
        Me.lvwLiveAnsicht.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyEBayIDToolStripMenuItem, Me.Copy_Beschreibung, Me.ToolStripSeparator1, Me.LiveÖffnenToolStripMenuItem, Me.ToolStripSeparator2, Me.tsmeBayLive_Detailansicht, Me.BietverlaufToolStripMenuItem, Me.HöchstbietenderToolStripMenuItem, Me.ToolStripSeparator3})
        Me.lvwLiveAnsicht.Name = "lvwLiveAnsicht"
        Me.lvwLiveAnsicht.Size = New System.Drawing.Size(220, 154)
        '
        'CopyEBayIDToolStripMenuItem
        '
        Me.CopyEBayIDToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.speichern
        Me.CopyEBayIDToolStripMenuItem.Name = "CopyEBayIDToolStripMenuItem"
        Me.CopyEBayIDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.CopyEBayIDToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CopyEBayIDToolStripMenuItem.Text = "&Copy eBayID"
        '
        'Copy_Beschreibung
        '
        Me.Copy_Beschreibung.Image = Global.YabE.My.Resources.Resources.speichern
        Me.Copy_Beschreibung.Name = "Copy_Beschreibung"
        Me.Copy_Beschreibung.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.Copy_Beschreibung.Size = New System.Drawing.Size(219, 22)
        Me.Copy_Beschreibung.Text = "Copy Beschreibung"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(216, 6)
        '
        'LiveÖffnenToolStripMenuItem
        '
        Me.LiveÖffnenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.firefox_button
        Me.LiveÖffnenToolStripMenuItem.Name = "LiveÖffnenToolStripMenuItem"
        Me.LiveÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LiveÖffnenToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.LiveÖffnenToolStripMenuItem.Text = "&Live Öffnen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(216, 6)
        '
        'tsmeBayLive_Detailansicht
        '
        Me.tsmeBayLive_Detailansicht.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.tsmeBayLive_Detailansicht.Name = "tsmeBayLive_Detailansicht"
        Me.tsmeBayLive_Detailansicht.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmeBayLive_Detailansicht.Size = New System.Drawing.Size(219, 22)
        Me.tsmeBayLive_Detailansicht.Text = "&Detail Ansicht"
        '
        'BietverlaufToolStripMenuItem
        '
        Me.BietverlaufToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.verlauf
        Me.BietverlaufToolStripMenuItem.Name = "BietverlaufToolStripMenuItem"
        Me.BietverlaufToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BietverlaufToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.BietverlaufToolStripMenuItem.Text = "&Bietverlauf"
        '
        'HöchstbietenderToolStripMenuItem
        '
        Me.HöchstbietenderToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.add_user
        Me.HöchstbietenderToolStripMenuItem.Name = "HöchstbietenderToolStripMenuItem"
        Me.HöchstbietenderToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HöchstbietenderToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.HöchstbietenderToolStripMenuItem.Text = "&Höchstbietender"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(216, 6)
        '
        'chkBidsOnly
        '
        Me.chkBidsOnly.AutoSize = True
        Me.chkBidsOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBidsOnly.Location = New System.Drawing.Point(12, 196)
        Me.chkBidsOnly.Name = "chkBidsOnly"
        Me.chkBidsOnly.Size = New System.Drawing.Size(88, 17)
        Me.chkBidsOnly.TabIndex = 3
        Me.chkBidsOnly.Text = "Nur Gebote"
        Me.chkBidsOnly.UseVisualStyleBackColor = True
        '
        'lblInfopanel
        '
        Me.lblInfopanel.AutoSize = True
        Me.lblInfopanel.Location = New System.Drawing.Point(12, 201)
        Me.lblInfopanel.Name = "lblInfopanel"
        Me.lblInfopanel.Size = New System.Drawing.Size(0, 13)
        Me.lblInfopanel.TabIndex = 4
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 246)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblInfopanel)
        Me.Controls.Add(Me.chkBidsOnly)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMessage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YabE - eBay Central"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.lvwLiveAnsicht.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nachricht As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwLiveAnsicht As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyEBayIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copy_Beschreibung As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LiveÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmeBayLive_Detailansicht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BietverlaufToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HöchstbietenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkBidsOnly As System.Windows.Forms.CheckBox
    Friend WithEvents mitglied As System.Windows.Forms.ColumnHeader
    Friend WithEvents bids As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblInfopanel As System.Windows.Forms.Label

End Class
