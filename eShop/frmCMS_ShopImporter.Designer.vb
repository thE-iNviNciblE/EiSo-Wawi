<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_ShopImporter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCMS_ShopImporter))
        Me.lvwImporter = New System.Windows.Forms.ListView
        Me.Beschreibung = New System.Windows.Forms.ColumnHeader
        Me.Preis = New System.Windows.Forms.ColumnHeader
        Me.Bild = New System.Windows.Forms.ColumnHeader
        Me.cmsStatus = New System.Windows.Forms.ColumnHeader
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label119 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.roeBay = New System.Windows.Forms.RadioButton
        Me.btnSuchen = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.roDelcampeImport = New System.Windows.Forms.RadioButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.toolMain = New System.Windows.Forms.ToolStripStatusLabel
        Me.Button3 = New System.Windows.Forms.Button
        Me.cmsMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwImporter
        '
        Me.lvwImporter.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwImporter.AllowColumnReorder = True
        Me.lvwImporter.AllowDrop = True
        Me.lvwImporter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwImporter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwImporter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwImporter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Beschreibung, Me.Preis, Me.Bild, Me.cmsStatus})
        Me.lvwImporter.ContextMenuStrip = Me.cmsMain
        Me.lvwImporter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwImporter.FullRowSelect = True
        Me.lvwImporter.GridLines = True
        Me.lvwImporter.HideSelection = False
        Me.lvwImporter.Location = New System.Drawing.Point(14, 101)
        Me.lvwImporter.Name = "lvwImporter"
        Me.lvwImporter.Size = New System.Drawing.Size(980, 504)
        Me.lvwImporter.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwImporter.TabIndex = 14
        Me.lvwImporter.UseCompatibleStateImageBehavior = False
        Me.lvwImporter.View = System.Windows.Forms.View.Details
        '
        'Beschreibung
        '
        Me.Beschreibung.DisplayIndex = 1
        Me.Beschreibung.Text = "Beschreibung"
        Me.Beschreibung.Width = 571
        '
        'Preis
        '
        Me.Preis.DisplayIndex = 2
        Me.Preis.Text = "Preis"
        Me.Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Preis.Width = 93
        '
        'Bild
        '
        Me.Bild.DisplayIndex = 3
        Me.Bild.Text = "Bild"
        Me.Bild.Width = 290
        '
        'cmsStatus
        '
        Me.cmsStatus.DisplayIndex = 0
        Me.cmsStatus.Text = "Status"
        Me.cmsStatus.Width = 64
        '
        'cmsMain
        '
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem})
        Me.cmsMain.Name = "cmsMain"
        Me.cmsMain.Size = New System.Drawing.Size(119, 26)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LöschenToolStripMenuItem.Text = "Löschen"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(14, 9)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(364, 25)
        Me.Label119.TabIndex = 44
        Me.Label119.Text = "Artikeldatenbank -> Importer"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "CSV-Dateien|*.csv"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'roeBay
        '
        Me.roeBay.AutoSize = True
        Me.roeBay.Checked = True
        Me.roeBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roeBay.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roeBay.Location = New System.Drawing.Point(25, 53)
        Me.roeBay.Name = "roeBay"
        Me.roeBay.Size = New System.Drawing.Size(139, 17)
        Me.roeBay.TabIndex = 45
        Me.roeBay.TabStop = True
        Me.roeBay.Text = "eBay Turbo Lister"
        Me.roeBay.UseVisualStyleBackColor = True
        '
        'btnSuchen
        '
        Me.btnSuchen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuchen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuchen.Image = Global.YabE.My.Resources.Resources._19
        Me.btnSuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuchen.Location = New System.Drawing.Point(305, 50)
        Me.btnSuchen.Name = "btnSuchen"
        Me.btnSuchen.Size = New System.Drawing.Size(213, 23)
        Me.btnSuchen.TabIndex = 46
        Me.btnSuchen.Text = "1. &Import von Artikeln..."
        Me.btnSuchen.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.YabE.My.Resources.Resources._03
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(524, 50)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(279, 23)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "2. &Artikeldatenbank übertragen"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 79)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(980, 16)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 48
        Me.ProgressBar1.Visible = False
        '
        'roDelcampeImport
        '
        Me.roDelcampeImport.AutoSize = True
        Me.roDelcampeImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roDelcampeImport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roDelcampeImport.Location = New System.Drawing.Point(170, 53)
        Me.roDelcampeImport.Name = "roDelcampeImport"
        Me.roDelcampeImport.Size = New System.Drawing.Size(129, 17)
        Me.roDelcampeImport.TabIndex = 50
        Me.roDelcampeImport.Text = "Delcampe Lister"
        Me.roDelcampeImport.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolMain})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 615)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 51
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'toolMain
        '
        Me.toolMain.Name = "toolMain"
        Me.toolMain.Size = New System.Drawing.Size(0, 17)
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(848, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 23)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "&Schließen"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmCMS_ShopImporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1008, 637)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.roDelcampeImport)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnSuchen)
        Me.Controls.Add(Me.roeBay)
        Me.Controls.Add(Me.Label119)
        Me.Controls.Add(Me.lvwImporter)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCMS_ShopImporter"
        Me.Text = "YabE -> Artikel importieren"
        Me.cmsMain.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwImporter As System.Windows.Forms.ListView
    Friend WithEvents Beschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents Bild As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents roeBay As System.Windows.Forms.RadioButton
    Friend WithEvents btnSuchen As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents roDelcampeImport As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents toolMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
