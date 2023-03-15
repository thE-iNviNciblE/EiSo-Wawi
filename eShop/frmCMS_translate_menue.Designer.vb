<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_translate_menue
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
        Me.lvwGoogleTranslate = New System.Windows.Forms.ListView
        Me.colQuelle = New System.Windows.Forms.ColumnHeader
        Me.colZiel = New System.Windows.Forms.ColumnHeader
        Me.colMenuID = New System.Windows.Forms.ColumnHeader
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbSprache_Artikeldatenbank = New System.Windows.Forms.ComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.pgrMain = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnStopp = New System.Windows.Forms.Button
        Me.chkOnlyMissing = New System.Windows.Forms.CheckBox
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwGoogleTranslate
        '
        Me.lvwGoogleTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwGoogleTranslate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colQuelle, Me.colZiel, Me.colMenuID})
        Me.lvwGoogleTranslate.FullRowSelect = True
        Me.lvwGoogleTranslate.GridLines = True
        Me.lvwGoogleTranslate.HideSelection = False
        Me.lvwGoogleTranslate.Location = New System.Drawing.Point(12, 61)
        Me.lvwGoogleTranslate.MultiSelect = False
        Me.lvwGoogleTranslate.Name = "lvwGoogleTranslate"
        Me.lvwGoogleTranslate.Size = New System.Drawing.Size(781, 408)
        Me.lvwGoogleTranslate.TabIndex = 0
        Me.lvwGoogleTranslate.UseCompatibleStateImageBehavior = False
        Me.lvwGoogleTranslate.View = System.Windows.Forms.View.Details
        '
        'colQuelle
        '
        Me.colQuelle.Text = "Quellsprache"
        Me.colQuelle.Width = 336
        '
        'colZiel
        '
        Me.colZiel.Text = "Zielsprache"
        Me.colZiel.Width = 441
        '
        'colMenuID
        '
        Me.colMenuID.Text = "ID"
        Me.colMenuID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colMenuID.Width = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(275, 23)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "YABE - Menü übersetzen"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(325, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(219, 17)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Zielsprache auswählen"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSprache_Artikeldatenbank
        '
        Me.cmbSprache_Artikeldatenbank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSprache_Artikeldatenbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprache_Artikeldatenbank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprache_Artikeldatenbank.FormattingEnabled = True
        Me.cmbSprache_Artikeldatenbank.Location = New System.Drawing.Point(326, 34)
        Me.cmbSprache_Artikeldatenbank.Name = "cmbSprache_Artikeldatenbank"
        Me.cmbSprache_Artikeldatenbank.Size = New System.Drawing.Size(219, 21)
        Me.cmbSprache_Artikeldatenbank.TabIndex = 44
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pgrMain, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 479)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(807, 22)
        Me.StatusStrip1.TabIndex = 46
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pgrMain
        '
        Me.pgrMain.Name = "pgrMain"
        Me.pgrMain.Size = New System.Drawing.Size(250, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'btnStopp
        '
        Me.btnStopp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStopp.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnStopp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopp.Image = Global.YabE.My.Resources.Resources.adressbuch
        Me.btnStopp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStopp.Location = New System.Drawing.Point(651, 31)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(142, 24)
        Me.btnStopp.TabIndex = 47
        Me.btnStopp.Text = "&Stopp"
        Me.btnStopp.UseVisualStyleBackColor = False
        '
        'chkOnlyMissing
        '
        Me.chkOnlyMissing.AutoSize = True
        Me.chkOnlyMissing.Checked = True
        Me.chkOnlyMissing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOnlyMissing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOnlyMissing.Location = New System.Drawing.Point(132, 38)
        Me.chkOnlyMissing.Name = "chkOnlyMissing"
        Me.chkOnlyMissing.Size = New System.Drawing.Size(185, 17)
        Me.chkOnlyMissing.TabIndex = 48
        Me.chkOnlyMissing.Text = "Nur fehlende Übersetzungen"
        Me.chkOnlyMissing.UseVisualStyleBackColor = True
        '
        'frmCMS_translate_menue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 501)
        Me.Controls.Add(Me.chkOnlyMissing)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmbSprache_Artikeldatenbank)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lvwGoogleTranslate)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCMS_translate_menue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YabE - Menü Google Translate"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwGoogleTranslate As System.Windows.Forms.ListView
    Friend WithEvents colQuelle As System.Windows.Forms.ColumnHeader
    Friend WithEvents colZiel As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMenuID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbSprache_Artikeldatenbank As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pgrMain As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnStopp As System.Windows.Forms.Button
    Friend WithEvents chkOnlyMissing As System.Windows.Forms.CheckBox
End Class
