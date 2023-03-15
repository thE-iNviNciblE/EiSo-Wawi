<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBestellstatus
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
        Me.lvwBestellungen_bestelliste_neu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader49 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.msgMaster = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnBestellstatusChange = New System.Windows.Forms.Button()
        Me.chkEmailSenden = New System.Windows.Forms.CheckBox()
        Me.chkWebshopLöschen = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwBestellungen_bestelliste_neu
        '
        Me.lvwBestellungen_bestelliste_neu.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBestellungen_bestelliste_neu.AllowColumnReorder = True
        Me.lvwBestellungen_bestelliste_neu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBestellungen_bestelliste_neu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwBestellungen_bestelliste_neu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBestellungen_bestelliste_neu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader49})
        Me.lvwBestellungen_bestelliste_neu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBestellungen_bestelliste_neu.FullRowSelect = True
        Me.lvwBestellungen_bestelliste_neu.GridLines = True
        Me.lvwBestellungen_bestelliste_neu.HideSelection = False
        Me.lvwBestellungen_bestelliste_neu.Location = New System.Drawing.Point(8, 8)
        Me.lvwBestellungen_bestelliste_neu.Name = "lvwBestellungen_bestelliste_neu"
        Me.lvwBestellungen_bestelliste_neu.ShowItemToolTips = True
        Me.lvwBestellungen_bestelliste_neu.Size = New System.Drawing.Size(983, 223)
        Me.lvwBestellungen_bestelliste_neu.TabIndex = 14
        Me.lvwBestellungen_bestelliste_neu.UseCompatibleStateImageBehavior = False
        Me.lvwBestellungen_bestelliste_neu.View = System.Windows.Forms.View.Details
        Me.lvwBestellungen_bestelliste_neu.VirtualListSize = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 139
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Benutzername"
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ort"
        Me.ColumnHeader4.Width = 117
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Beschreibung"
        Me.ColumnHeader5.Width = 284
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Preis"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 43
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Versand"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 74
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Bestellstatus"
        Me.ColumnHeader8.Width = 101
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Bewertung"
        Me.ColumnHeader9.Width = 76
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "eMail"
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Verkaufsende"
        Me.ColumnHeader19.Width = 96
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Bids"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Gebühr"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Plattform"
        Me.ColumnHeader22.Width = 70
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Bild"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "YABE ID"
        Me.ColumnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader24.Width = 0
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Paypalsumme"
        Me.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Land"
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Muttersprache"
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Straße"
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Sprachliste"
        Me.ColumnHeader30.Width = 0
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "Bild"
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "Menge"
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "Order ID"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msgMaster})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 285)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(994, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'msgMaster
        '
        Me.msgMaster.Name = "msgMaster"
        Me.msgMaster.Size = New System.Drawing.Size(0, 17)
        '
        'btnBestellstatusChange
        '
        Me.btnBestellstatusChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBestellstatusChange.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBestellstatusChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestellstatusChange.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestellstatusChange.Image = Global.YabE.My.Resources.Resources._24
        Me.btnBestellstatusChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestellstatusChange.Location = New System.Drawing.Point(755, 250)
        Me.btnBestellstatusChange.Name = "btnBestellstatusChange"
        Me.btnBestellstatusChange.Size = New System.Drawing.Size(227, 23)
        Me.btnBestellstatusChange.TabIndex = 16
        Me.btnBestellstatusChange.Text = "&Bestellstatus ändern"
        Me.btnBestellstatusChange.UseVisualStyleBackColor = False
        '
        'chkEmailSenden
        '
        Me.chkEmailSenden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEmailSenden.AutoSize = True
        Me.chkEmailSenden.Checked = True
        Me.chkEmailSenden.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEmailSenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEmailSenden.Location = New System.Drawing.Point(635, 253)
        Me.chkEmailSenden.Name = "chkEmailSenden"
        Me.chkEmailSenden.Size = New System.Drawing.Size(109, 17)
        Me.chkEmailSenden.TabIndex = 17
        Me.chkEmailSenden.Text = "Email verschicken"
        Me.chkEmailSenden.UseVisualStyleBackColor = True
        '
        'chkWebshopLöschen
        '
        Me.chkWebshopLöschen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkWebshopLöschen.AutoSize = True
        Me.chkWebshopLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWebshopLöschen.Location = New System.Drawing.Point(367, 253)
        Me.chkWebshopLöschen.Name = "chkWebshopLöschen"
        Me.chkWebshopLöschen.Size = New System.Drawing.Size(250, 17)
        Me.chkWebshopLöschen.TabIndex = 18
        Me.chkWebshopLöschen.Text = "Verknüpfte Artikel aus Artikeldatenbank löschen"
        Me.chkWebshopLöschen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 37)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Neuer Status..."
        '
        'frmBestellstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 307)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkWebshopLöschen)
        Me.Controls.Add(Me.chkEmailSenden)
        Me.Controls.Add(Me.btnBestellstatusChange)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lvwBestellungen_bestelliste_neu)
        Me.Name = "frmBestellstatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bestellstatus ändern"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwBestellungen_bestelliste_neu As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ColumnHeader31 As ColumnHeader
    Friend WithEvents ColumnHeader32 As ColumnHeader
    Friend WithEvents ColumnHeader49 As ColumnHeader
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents msgMaster As ToolStripStatusLabel
    Friend WithEvents btnBestellstatusChange As Button
    Friend WithEvents chkEmailSenden As CheckBox
    Friend WithEvents chkWebshopLöschen As CheckBox
    Friend WithEvents Label1 As Label
End Class
