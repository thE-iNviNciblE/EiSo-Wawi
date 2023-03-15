<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_search_replace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCMS_search_replace))
        Me.lvwMultiSelect = New System.Windows.Forms.ListView
        Me.item_id = New System.Windows.Forms.ColumnHeader
        Me.item_descrition = New System.Windows.Forms.ColumnHeader
        Me.item_delcampe = New System.Windows.Forms.ColumnHeader
        Me.item_ebay = New System.Windows.Forms.ColumnHeader
        Me.item_magento = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.lblMainArtikel = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnOKSearchReplace = New System.Windows.Forms.Button
        Me.txtSuchen = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtErsetzen = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkVorschau = New System.Windows.Forms.CheckBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwMultiSelect
        '
        Me.lvwMultiSelect.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMultiSelect.AllowColumnReorder = True
        Me.lvwMultiSelect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMultiSelect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMultiSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMultiSelect.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.item_id, Me.item_descrition, Me.item_delcampe, Me.item_ebay, Me.item_magento})
        Me.lvwMultiSelect.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwMultiSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lvwMultiSelect.FullRowSelect = True
        Me.lvwMultiSelect.GridLines = True
        Me.lvwMultiSelect.HideSelection = False
        Me.lvwMultiSelect.HoverSelection = True
        Me.lvwMultiSelect.Location = New System.Drawing.Point(12, 113)
        Me.lvwMultiSelect.MultiSelect = False
        Me.lvwMultiSelect.Name = "lvwMultiSelect"
        Me.lvwMultiSelect.Size = New System.Drawing.Size(862, 424)
        Me.lvwMultiSelect.TabIndex = 15
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelcampeKategorieIDZuweisenToolStripMenuItem1, Me.ToolStripSeparator1, Me.MagentoKategorieIDZuweisenToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(331, 54)
        '
        'DelcampeKategorieIDZuweisenToolStripMenuItem1
        '
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._03
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Name = "DelcampeKategorieIDZuweisenToolStripMenuItem1"
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Size = New System.Drawing.Size(330, 22)
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Text = "Zuordnung -> Delcampe Artikel ID..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(327, 6)
        '
        'MagentoKategorieIDZuweisenToolStripMenuItem1
        '
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._03
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Name = "MagentoKategorieIDZuweisenToolStripMenuItem1"
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Size = New System.Drawing.Size(330, 22)
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Text = "Zuordnung -> Magento -> Kategorie Artikel ID..."
        '
        'lblMainArtikel
        '
        Me.lblMainArtikel.AutoSize = True
        Me.lblMainArtikel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainArtikel.Location = New System.Drawing.Point(8, 9)
        Me.lblMainArtikel.Name = "lblMainArtikel"
        Me.lblMainArtikel.Size = New System.Drawing.Size(474, 23)
        Me.lblMainArtikel.TabIndex = 18
        Me.lblMainArtikel.Text = "Artikeldatenbank -> Suchen und ersetzten"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.YabE.My.Resources.Resources.abbrechen1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(239, 543)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "&Abbrechen"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnOKSearchReplace
        '
        Me.btnOKSearchReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOKSearchReplace.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnOKSearchReplace.Enabled = False
        Me.btnOKSearchReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOKSearchReplace.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKSearchReplace.Image = Global.YabE.My.Resources.Resources._24
        Me.btnOKSearchReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOKSearchReplace.Location = New System.Drawing.Point(12, 543)
        Me.btnOKSearchReplace.Name = "btnOKSearchReplace"
        Me.btnOKSearchReplace.Size = New System.Drawing.Size(221, 23)
        Me.btnOKSearchReplace.TabIndex = 3
        Me.btnOKSearchReplace.Text = "&Änderungen speichern"
        Me.btnOKSearchReplace.UseVisualStyleBackColor = False
        '
        'txtSuchen
        '
        Me.txtSuchen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSuchen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSuchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuchen.Location = New System.Drawing.Point(18, 71)
        Me.txtSuchen.Name = "txtSuchen"
        Me.txtSuchen.Size = New System.Drawing.Size(298, 21)
        Me.txtSuchen.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Suchbegriff eingeben"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtErsetzen
        '
        Me.txtErsetzen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtErsetzen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtErsetzen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtErsetzen.Location = New System.Drawing.Point(326, 71)
        Me.txtErsetzen.Name = "txtErsetzen"
        Me.txtErsetzen.Size = New System.Drawing.Size(298, 21)
        Me.txtErsetzen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Ersetzungsbegriff eingeben"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkVorschau
        '
        Me.chkVorschau.AutoSize = True
        Me.chkVorschau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVorschau.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVorschau.Location = New System.Drawing.Point(720, 71)
        Me.chkVorschau.Name = "chkVorschau"
        Me.chkVorschau.Size = New System.Drawing.Size(154, 17)
        Me.chkVorschau.TabIndex = 2
        Me.chkVorschau.Text = "&Vorschau aktivieren"
        Me.chkVorschau.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(890, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'frmCMS_search_replace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(890, 600)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkVorschau)
        Me.Controls.Add(Me.txtErsetzen)
        Me.Controls.Add(Me.btnOKSearchReplace)
        Me.Controls.Add(Me.txtSuchen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMainArtikel)
        Me.Controls.Add(Me.lvwMultiSelect)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCMS_search_replace"
        Me.Text = "YabE -> Artikeldatenbank -> Suchen und ersetzten"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwMultiSelect As System.Windows.Forms.ListView
    Friend WithEvents item_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_descrition As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_ebay As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_magento As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMainArtikel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnOKSearchReplace As System.Windows.Forms.Button
    Friend WithEvents txtSuchen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtErsetzen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkVorschau As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelcampeKategorieIDZuweisenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MagentoKategorieIDZuweisenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
