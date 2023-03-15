<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYABE_Kundenverwaltung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYABE_Kundenverwaltung))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLand = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStraße = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPLZ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUserId = New System.Windows.Forms.TextBox()
        Me.LblUserId = New System.Windows.Forms.Label()
        Me.lblBestellverlauf = New System.Windows.Forms.Label()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnKundenSave = New System.Windows.Forms.Button()
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtStadt = New System.Windows.Forms.TextBox()
        Me.chkKunde_Shop = New System.Windows.Forms.CheckBox()
        Me.chkKunde_ebay = New System.Windows.Forms.CheckBox()
        Me.chkKundeDelcampe = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSprachenVorlage = New System.Windows.Forms.ComboBox()
        Me.txtCountryCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtShopUserName = New System.Windows.Forms.TextBox()
        Me.txtShopPasswort = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(619, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(118, 24)
        Me.TextBox1.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(506, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Profilalter"
        '
        'txtLand
        '
        Me.txtLand.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLand.Location = New System.Drawing.Point(619, 77)
        Me.txtLand.Name = "txtLand"
        Me.txtLand.Size = New System.Drawing.Size(256, 24)
        Me.txtLand.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(509, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Land"
        '
        'txtStraße
        '
        Me.txtStraße.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStraße.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStraße.Location = New System.Drawing.Point(145, 105)
        Me.txtStraße.Name = "txtStraße"
        Me.txtStraße.Size = New System.Drawing.Size(306, 24)
        Me.txtStraße.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(14, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(127, 23)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Straße"
        '
        'txtPLZ
        '
        Me.txtPLZ.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPLZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPLZ.Location = New System.Drawing.Point(145, 131)
        Me.txtPLZ.Name = "txtPLZ"
        Me.txtPLZ.Size = New System.Drawing.Size(81, 24)
        Me.txtPLZ.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(14, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "PLZ und Stadt"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(145, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(256, 24)
        Me.txtName.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Name"
        '
        'TxtUserId
        '
        Me.TxtUserId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserId.Location = New System.Drawing.Point(145, 77)
        Me.TxtUserId.Name = "TxtUserId"
        Me.TxtUserId.Size = New System.Drawing.Size(187, 24)
        Me.TxtUserId.TabIndex = 114
        '
        'LblUserId
        '
        Me.LblUserId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserId.ForeColor = System.Drawing.Color.Sienna
        Me.LblUserId.Location = New System.Drawing.Point(10, 79)
        Me.LblUserId.Name = "LblUserId"
        Me.LblUserId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUserId.Size = New System.Drawing.Size(131, 23)
        Me.LblUserId.TabIndex = 115
        Me.LblUserId.Text = "Mitgliedsname"
        '
        'lblBestellverlauf
        '
        Me.lblBestellverlauf.AutoSize = True
        Me.lblBestellverlauf.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestellverlauf.Location = New System.Drawing.Point(14, 19)
        Me.lblBestellverlauf.Name = "lblBestellverlauf"
        Me.lblBestellverlauf.Size = New System.Drawing.Size(293, 23)
        Me.lblBestellverlauf.TabIndex = 113
        Me.lblBestellverlauf.Text = "Kundenadresse verändern"
        '
        'btnVor
        '
        Me.btnVor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVor.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(728, 238)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(150, 23)
        Me.btnVor.TabIndex = 127
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(570, 238)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 23)
        Me.btnBack.TabIndex = 126
        Me.btnBack.Text = "&Zurück"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnKundenSave
        '
        Me.btnKundenSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnKundenSave.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnKundenSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKundenSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKundenSave.Image = Global.YabE.My.Resources.Resources.user_edit
        Me.btnKundenSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKundenSave.Location = New System.Drawing.Point(20, 238)
        Me.btnKundenSave.Name = "btnKundenSave"
        Me.btnKundenSave.Size = New System.Drawing.Size(206, 23)
        Me.btnKundenSave.TabIndex = 128
        Me.btnKundenSave.Text = "&Änderungen speichern"
        Me.btnKundenSave.UseVisualStyleBackColor = False
        '
        'btnNeu
        '
        Me.btnNeu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNeu.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNeu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNeu.Image = Global.YabE.My.Resources.Resources.user_add
        Me.btnNeu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeu.Location = New System.Drawing.Point(233, 238)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(197, 23)
        Me.btnNeu.TabIndex = 129
        Me.btnNeu.Text = "&Neuer Kunde"
        Me.btnNeu.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(619, 105)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(256, 24)
        Me.txtEmail.TabIndex = 130
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Sienna
        Me.Label6.Location = New System.Drawing.Point(506, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(509, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Sprache"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 292)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(890, 0)
        Me.StatusStrip1.TabIndex = 134
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtStadt
        '
        Me.txtStadt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStadt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStadt.Location = New System.Drawing.Point(233, 131)
        Me.txtStadt.Name = "txtStadt"
        Me.txtStadt.Size = New System.Drawing.Size(218, 24)
        Me.txtStadt.TabIndex = 135
        '
        'chkKunde_Shop
        '
        Me.chkKunde_Shop.AutoSize = True
        Me.chkKunde_Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKunde_Shop.Location = New System.Drawing.Point(151, 211)
        Me.chkKunde_Shop.Name = "chkKunde_Shop"
        Me.chkKunde_Shop.Size = New System.Drawing.Size(63, 21)
        Me.chkKunde_Shop.TabIndex = 136
        Me.chkKunde_Shop.Text = "Shop"
        Me.chkKunde_Shop.UseVisualStyleBackColor = True
        '
        'chkKunde_ebay
        '
        Me.chkKunde_ebay.AutoSize = True
        Me.chkKunde_ebay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKunde_ebay.Location = New System.Drawing.Point(209, 211)
        Me.chkKunde_ebay.Name = "chkKunde_ebay"
        Me.chkKunde_ebay.Size = New System.Drawing.Size(60, 21)
        Me.chkKunde_ebay.TabIndex = 137
        Me.chkKunde_ebay.Text = "eBay"
        Me.chkKunde_ebay.UseVisualStyleBackColor = True
        '
        'chkKundeDelcampe
        '
        Me.chkKundeDelcampe.AutoSize = True
        Me.chkKundeDelcampe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKundeDelcampe.Location = New System.Drawing.Point(267, 211)
        Me.chkKundeDelcampe.Name = "chkKundeDelcampe"
        Me.chkKundeDelcampe.Size = New System.Drawing.Size(93, 21)
        Me.chkKundeDelcampe.TabIndex = 138
        Me.chkKundeDelcampe.Text = "Delcampe"
        Me.chkKundeDelcampe.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(18, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(127, 23)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Plattformen"
        '
        'cmbSprachenVorlage
        '
        Me.cmbSprachenVorlage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprachenVorlage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprachenVorlage.FormattingEnabled = True
        Me.cmbSprachenVorlage.Location = New System.Drawing.Point(619, 135)
        Me.cmbSprachenVorlage.Name = "cmbSprachenVorlage"
        Me.cmbSprachenVorlage.Size = New System.Drawing.Size(257, 25)
        Me.cmbSprachenVorlage.TabIndex = 141
        '
        'txtCountryCode
        '
        Me.txtCountryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountryCode.Location = New System.Drawing.Point(619, 136)
        Me.txtCountryCode.Name = "txtCountryCode"
        Me.txtCountryCode.Size = New System.Drawing.Size(181, 24)
        Me.txtCountryCode.TabIndex = 140
        Me.txtCountryCode.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Sienna
        Me.Label9.Location = New System.Drawing.Point(57, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 23)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Shop User"
        '
        'txtShopUserName
        '
        Me.txtShopUserName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtShopUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShopUserName.Location = New System.Drawing.Point(145, 166)
        Me.txtShopUserName.Name = "txtShopUserName"
        Me.txtShopUserName.Size = New System.Drawing.Size(218, 24)
        Me.txtShopUserName.TabIndex = 143
        '
        'txtShopPasswort
        '
        Me.txtShopPasswort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtShopPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShopPasswort.Location = New System.Drawing.Point(619, 168)
        Me.txtShopPasswort.Name = "txtShopPasswort"
        Me.txtShopPasswort.Size = New System.Drawing.Size(218, 24)
        Me.txtShopPasswort.TabIndex = 145
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Sienna
        Me.Label10.Location = New System.Drawing.Point(489, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 23)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Shop Passwort"
        '
        'frmYABE_Kundenverwaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(890, 292)
        Me.Controls.Add(Me.txtShopPasswort)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtShopUserName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbSprachenVorlage)
        Me.Controls.Add(Me.txtCountryCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkKundeDelcampe)
        Me.Controls.Add(Me.chkKunde_ebay)
        Me.Controls.Add(Me.chkKunde_Shop)
        Me.Controls.Add(Me.txtStadt)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNeu)
        Me.Controls.Add(Me.btnKundenSave)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLand)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtStraße)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPLZ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUserId)
        Me.Controls.Add(Me.LblUserId)
        Me.Controls.Add(Me.lblBestellverlauf)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmYABE_Kundenverwaltung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YABE - Kundendaten veränderungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLand As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStraße As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPLZ As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtUserId As System.Windows.Forms.TextBox
    Friend WithEvents LblUserId As System.Windows.Forms.Label
    Friend WithEvents lblBestellverlauf As System.Windows.Forms.Label
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnKundenSave As System.Windows.Forms.Button
    Friend WithEvents btnNeu As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtStadt As System.Windows.Forms.TextBox
    Friend WithEvents chkKunde_Shop As System.Windows.Forms.CheckBox
    Friend WithEvents chkKunde_ebay As System.Windows.Forms.CheckBox
    Friend WithEvents chkKundeDelcampe As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSprachenVorlage As System.Windows.Forms.ComboBox
    Public WithEvents txtCountryCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtShopUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtShopPasswort As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
