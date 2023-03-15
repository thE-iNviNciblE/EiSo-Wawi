<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenueSync
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
        Me.lvwMagentoKategorie = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.cmsMagentoView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnImport2Magento = New System.Windows.Forms.Button
        Me.yabe_dashboard_header = New System.Windows.Forms.Label
        Me.cmsMagentoView.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwMagentoKategorie
        '
        Me.lvwMagentoKategorie.AllowColumnReorder = True
        Me.lvwMagentoKategorie.AllowDrop = True
        Me.lvwMagentoKategorie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMagentoKategorie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwMagentoKategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMagentoKategorie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwMagentoKategorie.ContextMenuStrip = Me.cmsMagentoView
        Me.lvwMagentoKategorie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMagentoKategorie.FullRowSelect = True
        Me.lvwMagentoKategorie.GridLines = True
        Me.lvwMagentoKategorie.HideSelection = False
        Me.lvwMagentoKategorie.Location = New System.Drawing.Point(18, 55)
        Me.lvwMagentoKategorie.Name = "lvwMagentoKategorie"
        Me.lvwMagentoKategorie.Size = New System.Drawing.Size(538, 445)
        Me.lvwMagentoKategorie.TabIndex = 19
        Me.lvwMagentoKategorie.UseCompatibleStateImageBehavior = False
        Me.lvwMagentoKategorie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 2
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 0
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 1
        Me.ColumnHeader3.Text = "Zugriffe"
        Me.ColumnHeader3.Width = 73
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DelcampeID"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MagentoID"
        '
        'cmsMagentoView
        '
        Me.cmsMagentoView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem})
        Me.cmsMagentoView.Name = "cmsMagentoView"
        Me.cmsMagentoView.Size = New System.Drawing.Size(119, 26)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LöschenToolStripMenuItem.Text = "&Löschen"
        '
        'btnImport2Magento
        '
        Me.btnImport2Magento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport2Magento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport2Magento.Image = Global.YabE.My.Resources.Resources._03
        Me.btnImport2Magento.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnImport2Magento.Location = New System.Drawing.Point(338, 506)
        Me.btnImport2Magento.Name = "btnImport2Magento"
        Me.btnImport2Magento.Size = New System.Drawing.Size(218, 25)
        Me.btnImport2Magento.TabIndex = 43
        Me.btnImport2Magento.Text = "&Import starten..."
        Me.btnImport2Magento.UseVisualStyleBackColor = True
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(14, 10)
        Me.yabe_dashboard_header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(250, 23)
        Me.yabe_dashboard_header.TabIndex = 44
        Me.yabe_dashboard_header.Text = "YabE Menü 2 Magento"
        '
        'frmMenueSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 543)
        Me.Controls.Add(Me.yabe_dashboard_header)
        Me.Controls.Add(Me.lvwMagentoKategorie)
        Me.Controls.Add(Me.btnImport2Magento)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMenueSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenueSync"
        Me.cmsMagentoView.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwMagentoKategorie As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnImport2Magento As System.Windows.Forms.Button
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
    Friend WithEvents cmsMagentoView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
