<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_translate_shop
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
        Me.Label119 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbSprache_Artikeldatenbank = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbShopCategory = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnSpeichern = New System.Windows.Forms.Button
        Me.tblMisc = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.txtSuchen = New System.Windows.Forms.TextBox
        Me.btnSuchen = New System.Windows.Forms.Button
        Me.txtZiel = New System.Windows.Forms.TextBox
        Me.txtQuelle = New System.Windows.Forms.TextBox
        Me.lblZielsprache = New System.Windows.Forms.Label
        Me.lblQuellsprache = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(16, 9)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(360, 25)
        Me.Label119.TabIndex = 19
        Me.Label119.Text = "YABE -> Shop Übersetzungen"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(219, 17)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Sprachauswahl"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSprache_Artikeldatenbank
        '
        Me.cmbSprache_Artikeldatenbank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSprache_Artikeldatenbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprache_Artikeldatenbank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprache_Artikeldatenbank.FormattingEnabled = True
        Me.cmbSprache_Artikeldatenbank.Location = New System.Drawing.Point(19, 62)
        Me.cmbSprache_Artikeldatenbank.Name = "cmbSprache_Artikeldatenbank"
        Me.cmbSprache_Artikeldatenbank.Size = New System.Drawing.Size(219, 21)
        Me.cmbSprache_Artikeldatenbank.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Kategorie"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbShopCategory
        '
        Me.cmbShopCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbShopCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShopCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbShopCategory.FormattingEnabled = True
        Me.cmbShopCategory.Location = New System.Drawing.Point(279, 62)
        Me.cmbShopCategory.Name = "cmbShopCategory"
        Me.cmbShopCategory.Size = New System.Drawing.Size(219, 21)
        Me.cmbShopCategory.TabIndex = 44
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(974, 292)
        Me.DataGridView1.TabIndex = 46
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSpeichern.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSpeichern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeichern.Image = Global.YabE.My.Resources.Resources._03
        Me.btnSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSpeichern.Location = New System.Drawing.Point(525, 57)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(281, 23)
        Me.btnSpeichern.TabIndex = 47
        Me.btnSpeichern.Text = "&Übersetzung speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = False
        '
        'tblMisc
        '
        Me.tblMisc.DataSetName = "NewDataSet"
        Me.tblMisc.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "Table1"
        '
        'txtSuchen
        '
        Me.txtSuchen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSuchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuchen.ForeColor = System.Drawing.Color.DimGray
        Me.txtSuchen.Location = New System.Drawing.Point(13, 590)
        Me.txtSuchen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSuchen.Name = "txtSuchen"
        Me.txtSuchen.Size = New System.Drawing.Size(387, 20)
        Me.txtSuchen.TabIndex = 48
        Me.txtSuchen.Text = "Suchbegriff..."
        '
        'btnSuchen
        '
        Me.btnSuchen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSuchen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuchen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuchen.Image = Global.YabE.My.Resources.Resources.search2
        Me.btnSuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuchen.Location = New System.Drawing.Point(408, 588)
        Me.btnSuchen.Name = "btnSuchen"
        Me.btnSuchen.Size = New System.Drawing.Size(175, 23)
        Me.btnSuchen.TabIndex = 49
        Me.btnSuchen.Text = "Suche starten"
        Me.btnSuchen.UseVisualStyleBackColor = False
        '
        'txtZiel
        '
        Me.txtZiel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtZiel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtZiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZiel.Location = New System.Drawing.Point(417, 106)
        Me.txtZiel.Multiline = True
        Me.txtZiel.Name = "txtZiel"
        Me.txtZiel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtZiel.Size = New System.Drawing.Size(389, 175)
        Me.txtZiel.TabIndex = 53
        '
        'txtQuelle
        '
        Me.txtQuelle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQuelle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuelle.Location = New System.Drawing.Point(17, 106)
        Me.txtQuelle.Multiline = True
        Me.txtQuelle.Name = "txtQuelle"
        Me.txtQuelle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuelle.Size = New System.Drawing.Size(371, 175)
        Me.txtQuelle.TabIndex = 52
        '
        'lblZielsprache
        '
        Me.lblZielsprache.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblZielsprache.AutoSize = True
        Me.lblZielsprache.BackColor = System.Drawing.Color.Silver
        Me.lblZielsprache.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZielsprache.Location = New System.Drawing.Point(414, 90)
        Me.lblZielsprache.Name = "lblZielsprache"
        Me.lblZielsprache.Size = New System.Drawing.Size(61, 13)
        Me.lblZielsprache.TabIndex = 50
        Me.lblZielsprache.Text = "Englisch"
        '
        'lblQuellsprache
        '
        Me.lblQuellsprache.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuellsprache.BackColor = System.Drawing.Color.Silver
        Me.lblQuellsprache.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuellsprache.Location = New System.Drawing.Point(16, 90)
        Me.lblQuellsprache.Name = "lblQuellsprache"
        Me.lblQuellsprache.Size = New System.Drawing.Size(790, 13)
        Me.lblQuellsprache.TabIndex = 51
        Me.lblQuellsprache.Text = "Deutsch"
        '
        'frmCMS_translate_shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1001, 623)
        Me.Controls.Add(Me.txtZiel)
        Me.Controls.Add(Me.txtQuelle)
        Me.Controls.Add(Me.lblZielsprache)
        Me.Controls.Add(Me.lblQuellsprache)
        Me.Controls.Add(Me.txtSuchen)
        Me.Controls.Add(Me.btnSuchen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbShopCategory)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmbSprache_Artikeldatenbank)
        Me.Controls.Add(Me.Label119)
        Me.Name = "frmCMS_translate_shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YabE - Shop Texte übersetzten"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblMisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbSprache_Artikeldatenbank As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbShopCategory As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents tblMisc As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents txtSuchen As System.Windows.Forms.TextBox
    Friend WithEvents btnSuchen As System.Windows.Forms.Button
    Friend WithEvents txtZiel As System.Windows.Forms.TextBox
    Friend WithEvents txtQuelle As System.Windows.Forms.TextBox
    Friend WithEvents lblZielsprache As System.Windows.Forms.Label
    Friend WithEvents lblQuellsprache As System.Windows.Forms.Label
End Class
