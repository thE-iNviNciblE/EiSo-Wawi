<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmDelcampeIDZuweisung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelcampeIDZuweisung))
        Me.tabMainTab = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnKategorieEdotir = New System.Windows.Forms.Button
        Me.lblMainArtikel = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnOKArtikelID = New System.Windows.Forms.Button
        Me.lvwMultiSelect = New System.Windows.Forms.ListView
        Me.item_id = New System.Windows.Forms.ColumnHeader
        Me.item_descrition = New System.Windows.Forms.ColumnHeader
        Me.item_delcampe = New System.Windows.Forms.ColumnHeader
        Me.item_ebay = New System.Windows.Forms.ColumnHeader
        Me.item_magento = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BenutzeDelcampeIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtNeueID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblMainMenue = New System.Windows.Forms.Label
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.txtDelcampeID = New System.Windows.Forms.TextBox
        Me.txtKategoriename = New System.Windows.Forms.TextBox
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.tabMainTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMainTab
        '
        Me.tabMainTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMainTab.Controls.Add(Me.TabPage1)
        Me.tabMainTab.Controls.Add(Me.TabPage2)
        Me.tabMainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMainTab.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMainTab.Location = New System.Drawing.Point(0, 0)
        Me.tabMainTab.Margin = New System.Windows.Forms.Padding(5)
        Me.tabMainTab.Name = "tabMainTab"
        Me.tabMainTab.SelectedIndex = 0
        Me.tabMainTab.Size = New System.Drawing.Size(781, 488)
        Me.tabMainTab.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.btnKategorieEdotir)
        Me.TabPage1.Controls.Add(Me.lblMainArtikel)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.btnOKArtikelID)
        Me.TabPage1.Controls.Add(Me.lvwMultiSelect)
        Me.TabPage1.Controls.Add(Me.txtNeueID)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(773, 459)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ArtikelID"
        '
        'btnKategorieEdotir
        '
        Me.btnKategorieEdotir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnKategorieEdotir.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnKategorieEdotir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnKategorieEdotir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategorieEdotir.Image = Global.YabE.My.Resources.Resources._19
        Me.btnKategorieEdotir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKategorieEdotir.Location = New System.Drawing.Point(228, 427)
        Me.btnKategorieEdotir.Name = "btnKategorieEdotir"
        Me.btnKategorieEdotir.Size = New System.Drawing.Size(154, 23)
        Me.btnKategorieEdotir.TabIndex = 18
        Me.btnKategorieEdotir.Text = "&Kategorien..."
        Me.btnKategorieEdotir.UseVisualStyleBackColor = False
        '
        'lblMainArtikel
        '
        Me.lblMainArtikel.AutoSize = True
        Me.lblMainArtikel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainArtikel.Location = New System.Drawing.Point(17, 16)
        Me.lblMainArtikel.Name = "lblMainArtikel"
        Me.lblMainArtikel.Size = New System.Drawing.Size(0, 23)
        Me.lblMainArtikel.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(630, 427)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "&Abbrechen"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnOKArtikelID
        '
        Me.btnOKArtikelID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOKArtikelID.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnOKArtikelID.Enabled = False
        Me.btnOKArtikelID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOKArtikelID.Image = Global.YabE.My.Resources.Resources._03
        Me.btnOKArtikelID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOKArtikelID.Location = New System.Drawing.Point(388, 426)
        Me.btnOKArtikelID.Name = "btnOKArtikelID"
        Me.btnOKArtikelID.Size = New System.Drawing.Size(236, 24)
        Me.btnOKArtikelID.TabIndex = 15
        Me.btnOKArtikelID.Text = "&Neue Kategorie speichern"
        Me.btnOKArtikelID.UseVisualStyleBackColor = False
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
        Me.lvwMultiSelect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMultiSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lvwMultiSelect.FullRowSelect = True
        Me.lvwMultiSelect.GridLines = True
        Me.lvwMultiSelect.HideSelection = False
        Me.lvwMultiSelect.HoverSelection = True
        Me.lvwMultiSelect.Location = New System.Drawing.Point(9, 49)
        Me.lvwMultiSelect.MultiSelect = False
        Me.lvwMultiSelect.Name = "lvwMultiSelect"
        Me.lvwMultiSelect.Size = New System.Drawing.Size(755, 355)
        Me.lvwMultiSelect.TabIndex = 14
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
        Me.item_descrition.Width = 441
        '
        'item_delcampe
        '
        Me.item_delcampe.Text = "DelcampeID"
        Me.item_delcampe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.item_delcampe.Width = 89
        '
        'item_ebay
        '
        Me.item_ebay.Text = "eBayID"
        Me.item_ebay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'item_magento
        '
        Me.item_magento.Text = "MagentoID"
        Me.item_magento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.item_magento.Width = 89
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem, Me.BenutzeDelcampeIDToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 48)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LöschenToolStripMenuItem.Text = "&Löschen"
        '
        'BenutzeDelcampeIDToolStripMenuItem
        '
        Me.BenutzeDelcampeIDToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.BenutzeDelcampeIDToolStripMenuItem.Name = "BenutzeDelcampeIDToolStripMenuItem"
        Me.BenutzeDelcampeIDToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.BenutzeDelcampeIDToolStripMenuItem.Text = "Benutze Delcampe ID "
        '
        'txtNeueID
        '
        Me.txtNeueID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNeueID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNeueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNeueID.Location = New System.Drawing.Point(8, 427)
        Me.txtNeueID.Name = "txtNeueID"
        Me.txtNeueID.Size = New System.Drawing.Size(214, 21)
        Me.txtNeueID.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(2, 407)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "&Delcampe Kategorie ID eingeben"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.lblMainMenue)
        Me.TabPage2.Controls.Add(Me.Cancel)
        Me.TabPage2.Controls.Add(Me.OK)
        Me.TabPage2.Controls.Add(Me.txtDelcampeID)
        Me.TabPage2.Controls.Add(Me.txtKategoriename)
        Me.TabPage2.Controls.Add(Me.PasswordLabel)
        Me.TabPage2.Controls.Add(Me.UsernameLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(773, 459)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MenueID"
        '
        'lblMainMenue
        '
        Me.lblMainMenue.AutoSize = True
        Me.lblMainMenue.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenue.Location = New System.Drawing.Point(24, 17)
        Me.lblMainMenue.Name = "lblMainMenue"
        Me.lblMainMenue.Size = New System.Drawing.Size(0, 23)
        Me.lblMainMenue.TabIndex = 19
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.NavajoWhite
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Location = New System.Drawing.Point(516, 138)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(110, 23)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "&Abbrechen"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.NavajoWhite
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Image = Global.YabE.My.Resources.Resources._24
        Me.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK.Location = New System.Drawing.Point(300, 138)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(210, 23)
        Me.OK.TabIndex = 10
        Me.OK.Text = "&Änderungen speichern"
        Me.OK.UseVisualStyleBackColor = False
        '
        'txtDelcampeID
        '
        Me.txtDelcampeID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDelcampeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelcampeID.ForeColor = System.Drawing.Color.Black
        Me.txtDelcampeID.Location = New System.Drawing.Point(27, 141)
        Me.txtDelcampeID.Name = "txtDelcampeID"
        Me.txtDelcampeID.Size = New System.Drawing.Size(256, 21)
        Me.txtDelcampeID.TabIndex = 9
        '
        'txtKategoriename
        '
        Me.txtKategoriename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKategoriename.Enabled = False
        Me.txtKategoriename.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtKategoriename.Location = New System.Drawing.Point(27, 84)
        Me.txtKategoriename.Name = "txtKategoriename"
        Me.txtKategoriename.Size = New System.Drawing.Size(256, 21)
        Me.txtKategoriename.TabIndex = 7
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(25, 121)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(257, 23)
        Me.PasswordLabel.TabIndex = 8
        Me.PasswordLabel.Text = "&Delcampe Kategorie ID eingeben"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(25, 64)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(257, 23)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "&Kateogriename"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDelcampeIDZuweisung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 488)
        Me.Controls.Add(Me.tabMainTab)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDelcampeIDZuweisung"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Artikeldatenbank -> Delcampe -> Kategorie ID zuweisen"
        Me.tabMainTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMainTab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtDelcampeID As System.Windows.Forms.TextBox
    Friend WithEvents txtKategoriename As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents txtNeueID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvwMultiSelect As System.Windows.Forms.ListView
    Friend WithEvents item_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_descrition As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_ebay As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_magento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnOKArtikelID As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BenutzeDelcampeIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMainArtikel As System.Windows.Forms.Label
    Friend WithEvents lblMainMenue As System.Windows.Forms.Label
    Friend WithEvents btnKategorieEdotir As System.Windows.Forms.Button

End Class
