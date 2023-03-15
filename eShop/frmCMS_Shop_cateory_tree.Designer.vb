<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_Shop_cateory_tree
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
        Me.TreeViewCategory = New System.Windows.Forms.TreeView
        Me.cmsCategory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NeueHauptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnterkategorieAnlegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.KategorieLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAuktionsanfang = New System.Windows.Forms.Button
        Me.btnExpandAll = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmsCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeViewCategory
        '
        Me.TreeViewCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeViewCategory.ContextMenuStrip = Me.cmsCategory
        Me.TreeViewCategory.Location = New System.Drawing.Point(12, 12)
        Me.TreeViewCategory.Name = "TreeViewCategory"
        Me.TreeViewCategory.Size = New System.Drawing.Size(315, 387)
        Me.TreeViewCategory.TabIndex = 0
        '
        'cmsCategory
        '
        Me.cmsCategory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeueHauptToolStripMenuItem, Me.UnterkategorieAnlegenToolStripMenuItem, Me.ToolStripSeparator1, Me.KategorieLöschenToolStripMenuItem})
        Me.cmsCategory.Name = "cmsCategory"
        Me.cmsCategory.Size = New System.Drawing.Size(211, 76)
        '
        'NeueHauptToolStripMenuItem
        '
        Me.NeueHauptToolStripMenuItem.Name = "NeueHauptToolStripMenuItem"
        Me.NeueHauptToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.NeueHauptToolStripMenuItem.Text = "Hauptkategorie anlegen..."
        '
        'UnterkategorieAnlegenToolStripMenuItem
        '
        Me.UnterkategorieAnlegenToolStripMenuItem.Name = "UnterkategorieAnlegenToolStripMenuItem"
        Me.UnterkategorieAnlegenToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.UnterkategorieAnlegenToolStripMenuItem.Text = "Unterkategorie anlegen..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'KategorieLöschenToolStripMenuItem
        '
        Me.KategorieLöschenToolStripMenuItem.Name = "KategorieLöschenToolStripMenuItem"
        Me.KategorieLöschenToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.KategorieLöschenToolStripMenuItem.Text = "Kategorie löschen"
        '
        'btnAuktionsanfang
        '
        Me.btnAuktionsanfang.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnAuktionsanfang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuktionsanfang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuktionsanfang.ImageIndex = 0
        Me.btnAuktionsanfang.Location = New System.Drawing.Point(490, 405)
        Me.btnAuktionsanfang.Name = "btnAuktionsanfang"
        Me.btnAuktionsanfang.Size = New System.Drawing.Size(289, 25)
        Me.btnAuktionsanfang.TabIndex = 12
        Me.btnAuktionsanfang.Text = "&Schließen"
        Me.btnAuktionsanfang.UseVisualStyleBackColor = False
        '
        'btnExpandAll
        '
        Me.btnExpandAll.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExpandAll.ImageIndex = 0
        Me.btnExpandAll.Location = New System.Drawing.Point(12, 405)
        Me.btnExpandAll.Name = "btnExpandAll"
        Me.btnExpandAll.Size = New System.Drawing.Size(101, 25)
        Me.btnExpandAll.TabIndex = 13
        Me.btnExpandAll.Text = "&Aufklappen"
        Me.btnExpandAll.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.Location = New System.Drawing.Point(133, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 25)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Test"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(358, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(421, 387)
        Me.TextBox1.TabIndex = 15
        '
        'frmShop_cateory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 439)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExpandAll)
        Me.Controls.Add(Me.btnAuktionsanfang)
        Me.Controls.Add(Me.TreeViewCategory)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShop_cateory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "eShop - Neue Kategorie"
        Me.cmsCategory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeViewCategory As System.Windows.Forms.TreeView
    Friend WithEvents cmsCategory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NeueHauptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnterkategorieAnlegenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAuktionsanfang As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KategorieLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExpandAll As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
