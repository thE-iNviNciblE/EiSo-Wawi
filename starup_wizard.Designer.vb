<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class starup_wizard
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(starup_wizard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tb_user = New System.Windows.Forms.TabPage()
        Me.txtEmailShopName = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtUserFirmenname = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtPasswort2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkShowthiswindow = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOptionenLaden = New System.Windows.Forms.Button()
        Me.txtAddTelefon = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtAddShop = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtAddLand = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtAddOrt = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAddPLZ = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtAddStrasse = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtAddNachname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAddVorname = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAddEmail = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tb_server = New System.Windows.Forms.TabPage()
        Me.txtMYSQL_USER = New System.Windows.Forms.TextBox()
        Me.txtMYSQL_PWD = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstServerMessage = New System.Windows.Forms.ListBox()
        Me.btnServer_anlegen = New System.Windows.Forms.Button()
        Me.tb_ebay = New System.Windows.Forms.TabPage()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnÜberspringen = New System.Windows.Forms.Button()
        Me.btneBayTest = New System.Windows.Forms.Button()
        Me.btneBayGetToken = New System.Windows.Forms.Button()
        Me.btneBaySandbox = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txteBayToken = New System.Windows.Forms.TextBox()
        Me.txteBay_user = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnWeiter3 = New System.Windows.Forms.Button()
        Me.btneBay = New System.Windows.Forms.Button()
        Me.tb_mail = New System.Windows.Forms.TabPage()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.chkMailSSLSupport = New System.Windows.Forms.CheckBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtEmail_email = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPOP3Port = New System.Windows.Forms.TextBox()
        Me.txtSMTPPort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cmbSMTPAnbieter = New System.Windows.Forms.ComboBox()
        Me.txtPOP3Server = New System.Windows.Forms.TextBox()
        Me.txtSMTPServer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmail_User = New System.Windows.Forms.TextBox()
        Me.txtEmail_pwd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnWeiter2 = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.tb_schließen = New System.Windows.Forms.TabPage()
        Me.btnShopsteLogin = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSchließen = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.V054BetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadTeamviewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProblemMeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tb_user.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tb_server.SuspendLayout()
        Me.tb_ebay.SuspendLayout()
        Me.tb_mail.SuspendLayout()
        Me.tb_schließen.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(6, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1246, 512)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tb_user)
        Me.TabControl1.Controls.Add(Me.tb_server)
        Me.TabControl1.Controls.Add(Me.tb_ebay)
        Me.TabControl1.Controls.Add(Me.tb_mail)
        Me.TabControl1.Controls.Add(Me.tb_schließen)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1228, 506)
        Me.TabControl1.TabIndex = 0
        '
        'tb_user
        '
        Me.tb_user.Controls.Add(Me.txtEmailShopName)
        Me.tb_user.Controls.Add(Me.Label39)
        Me.tb_user.Controls.Add(Me.txtUserFirmenname)
        Me.tb_user.Controls.Add(Me.Label38)
        Me.tb_user.Controls.Add(Me.txtPasswort2)
        Me.tb_user.Controls.Add(Me.Label7)
        Me.tb_user.Controls.Add(Me.chkShowthiswindow)
        Me.tb_user.Controls.Add(Me.Label35)
        Me.tb_user.Controls.Add(Me.RadioButton2)
        Me.tb_user.Controls.Add(Me.RadioButton1)
        Me.tb_user.Controls.Add(Me.txtPasswort)
        Me.tb_user.Controls.Add(Me.Label3)
        Me.tb_user.Controls.Add(Me.btnOptionenLaden)
        Me.tb_user.Controls.Add(Me.txtAddTelefon)
        Me.tb_user.Controls.Add(Me.Label29)
        Me.tb_user.Controls.Add(Me.txtAddShop)
        Me.tb_user.Controls.Add(Me.Label28)
        Me.tb_user.Controls.Add(Me.btnLogin)
        Me.tb_user.Controls.Add(Me.txtAddLand)
        Me.tb_user.Controls.Add(Me.Label24)
        Me.tb_user.Controls.Add(Me.txtAddOrt)
        Me.tb_user.Controls.Add(Me.Label23)
        Me.tb_user.Controls.Add(Me.txtAddPLZ)
        Me.tb_user.Controls.Add(Me.Label22)
        Me.tb_user.Controls.Add(Me.txtAddStrasse)
        Me.tb_user.Controls.Add(Me.Label21)
        Me.tb_user.Controls.Add(Me.txtAddNachname)
        Me.tb_user.Controls.Add(Me.Label20)
        Me.tb_user.Controls.Add(Me.txtAddVorname)
        Me.tb_user.Controls.Add(Me.Label19)
        Me.tb_user.Controls.Add(Me.txtAddEmail)
        Me.tb_user.Controls.Add(Me.Label18)
        Me.tb_user.Controls.Add(Me.txtUsername)
        Me.tb_user.Controls.Add(Me.Label2)
        Me.tb_user.Controls.Add(Me.btnNewUser)
        Me.tb_user.Controls.Add(Me.Label34)
        Me.tb_user.Controls.Add(Me.Panel2)
        Me.tb_user.Controls.Add(Me.Label25)
        Me.tb_user.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(4, 22)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_user.Size = New System.Drawing.Size(1220, 480)
        Me.tb_user.TabIndex = 0
        Me.tb_user.Text = "1. Anmeldung / Login"
        Me.tb_user.UseVisualStyleBackColor = True
        '
        'txtEmailShopName
        '
        Me.txtEmailShopName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailShopName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailShopName.Location = New System.Drawing.Point(861, 130)
        Me.txtEmailShopName.Name = "txtEmailShopName"
        Me.txtEmailShopName.Size = New System.Drawing.Size(210, 21)
        Me.txtEmailShopName.TabIndex = 3
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(862, 114)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(75, 13)
        Me.Label39.TabIndex = 100
        Me.Label39.Text = "Shopname"
        '
        'txtUserFirmenname
        '
        Me.txtUserFirmenname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserFirmenname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserFirmenname.Location = New System.Drawing.Point(610, 132)
        Me.txtUserFirmenname.Name = "txtUserFirmenname"
        Me.txtUserFirmenname.Size = New System.Drawing.Size(210, 21)
        Me.txtUserFirmenname.TabIndex = 2
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(611, 116)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(45, 13)
        Me.Label38.TabIndex = 98
        Me.Label38.Text = "Firma"
        '
        'txtPasswort2
        '
        Me.txtPasswort2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswort2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswort2.Location = New System.Drawing.Point(861, 212)
        Me.txtPasswort2.Name = "txtPasswort2"
        Me.txtPasswort2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswort2.Size = New System.Drawing.Size(210, 21)
        Me.txtPasswort2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtPasswort2, "Wählen Sie ein starkes Passwort")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(858, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 13)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Passwort wiederholen*"
        '
        'chkShowthiswindow
        '
        Me.chkShowthiswindow.AutoSize = True
        Me.chkShowthiswindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowthiswindow.Location = New System.Drawing.Point(609, 417)
        Me.chkShowthiswindow.Name = "chkShowthiswindow"
        Me.chkShowthiswindow.Size = New System.Drawing.Size(229, 17)
        Me.chkShowthiswindow.TabIndex = 18
        Me.chkShowthiswindow.Text = "Dieses Fenster immer anzeigen"
        Me.chkShowthiswindow.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(607, 62)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(85, 13)
        Me.Label35.TabIndex = 93
        Me.Label35.Text = "Anmeldetyp"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(759, 88)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(288, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mit eBay, Delcampe, EiSo Shop, Shopste "
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "Beinhaltet Shopste, eBay, Delcampe, EiSo Shop Konfiguration.")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(609, 88)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(135, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Nur Shopste.com"
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "Bedeutet das Sie bei der Anmeldung nicht die Konfiguration von eBay API aufgeford" &
        "ert werden.")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtPasswort
        '
        Me.txtPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswort.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswort.Location = New System.Drawing.Point(861, 170)
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswort.Size = New System.Drawing.Size(210, 21)
        Me.txtPasswort.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtPasswort, "Wählen Sie ein starkes Passwort")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(858, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Passwort*"
        '
        'btnOptionenLaden
        '
        Me.btnOptionenLaden.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnOptionenLaden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptionenLaden.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptionenLaden.Image = Global.YabE.My.Resources.Resources._03
        Me.btnOptionenLaden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOptionenLaden.Location = New System.Drawing.Point(983, 411)
        Me.btnOptionenLaden.Name = "btnOptionenLaden"
        Me.btnOptionenLaden.Size = New System.Drawing.Size(210, 28)
        Me.btnOptionenLaden.TabIndex = 20
        Me.btnOptionenLaden.Text = "&EiSo Einstellungen..."
        Me.ToolTip1.SetToolTip(Me.btnOptionenLaden, "EiSo Einstellungen laden")
        Me.btnOptionenLaden.UseVisualStyleBackColor = False
        Me.btnOptionenLaden.Visible = False
        '
        'txtAddTelefon
        '
        Me.txtAddTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddTelefon.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddTelefon.Location = New System.Drawing.Point(861, 292)
        Me.txtAddTelefon.Name = "txtAddTelefon"
        Me.txtAddTelefon.Size = New System.Drawing.Size(126, 21)
        Me.txtAddTelefon.TabIndex = 12
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(858, 276)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 13)
        Me.Label29.TabIndex = 89
        Me.Label29.Text = "Telefon*"
        '
        'txtAddShop
        '
        Me.txtAddShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddShop.Enabled = False
        Me.txtAddShop.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddShop.Location = New System.Drawing.Point(861, 372)
        Me.txtAddShop.Name = "txtAddShop"
        Me.txtAddShop.Size = New System.Drawing.Size(259, 21)
        Me.txtAddShop.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtAddShop, resources.GetString("txtAddShop.ToolTip"))
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(858, 356)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 13)
        Me.Label28.TabIndex = 88
        Me.Label28.Text = "EiSo Shop URL"
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = Global.YabE.My.Resources.Resources.user_add
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(983, 443)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(210, 28)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "EiSo Login..."
        Me.ToolTip1.SetToolTip(Me.btnLogin, resources.GetString("btnLogin.ToolTip"))
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtAddLand
        '
        Me.txtAddLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddLand.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddLand.Location = New System.Drawing.Point(610, 372)
        Me.txtAddLand.Name = "txtAddLand"
        Me.txtAddLand.Size = New System.Drawing.Size(210, 21)
        Me.txtAddLand.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(611, 356)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 87
        Me.Label24.Text = "Land*"
        '
        'txtAddOrt
        '
        Me.txtAddOrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddOrt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddOrt.Location = New System.Drawing.Point(861, 332)
        Me.txtAddOrt.Name = "txtAddOrt"
        Me.txtAddOrt.Size = New System.Drawing.Size(210, 21)
        Me.txtAddOrt.TabIndex = 15
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(858, 316)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Ort*"
        '
        'txtAddPLZ
        '
        Me.txtAddPLZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddPLZ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPLZ.Location = New System.Drawing.Point(610, 332)
        Me.txtAddPLZ.Name = "txtAddPLZ"
        Me.txtAddPLZ.Size = New System.Drawing.Size(80, 21)
        Me.txtAddPLZ.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(607, 316)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 85
        Me.Label22.Text = "PLZ*"
        '
        'txtAddStrasse
        '
        Me.txtAddStrasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddStrasse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddStrasse.Location = New System.Drawing.Point(609, 292)
        Me.txtAddStrasse.Name = "txtAddStrasse"
        Me.txtAddStrasse.Size = New System.Drawing.Size(210, 21)
        Me.txtAddStrasse.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(607, 276)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 13)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "Strasse + Nr.*"
        '
        'txtAddNachname
        '
        Me.txtAddNachname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddNachname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddNachname.Location = New System.Drawing.Point(861, 252)
        Me.txtAddNachname.Name = "txtAddNachname"
        Me.txtAddNachname.Size = New System.Drawing.Size(210, 21)
        Me.txtAddNachname.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(858, 236)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Nachname*"
        '
        'txtAddVorname
        '
        Me.txtAddVorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddVorname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddVorname.Location = New System.Drawing.Point(610, 252)
        Me.txtAddVorname.Name = "txtAddVorname"
        Me.txtAddVorname.Size = New System.Drawing.Size(210, 21)
        Me.txtAddVorname.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(606, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Vorname*"
        '
        'txtAddEmail
        '
        Me.txtAddEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddEmail.Location = New System.Drawing.Point(609, 212)
        Me.txtAddEmail.Name = "txtAddEmail"
        Me.txtAddEmail.Size = New System.Drawing.Size(210, 21)
        Me.txtAddEmail.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtAddEmail, "Geben Sie Ihre Buisness Emailadresse an")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(606, 196)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Email*"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(609, 172)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(161, 21)
        Me.txtUsername.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Wählen Sie einen Mitgliedsnamen")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(606, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Mitgliedsname*"
        '
        'btnNewUser
        '
        Me.btnNewUser.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.Image = Global.YabE.My.Resources.Resources.add_user
        Me.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewUser.Location = New System.Drawing.Point(609, 443)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(368, 28)
        Me.btnNewUser.TabIndex = 19
        Me.btnNewUser.Text = "1. &Online Datenbank kostenlos erstellen..."
        Me.ToolTip1.SetToolTip(Me.btnNewUser, "Bitte alle mit Sternchen gekennzeichneten Felder ausfüllen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sollten Sie sich ber" &
        "eits registriert haben wird mit Ihrem EiSo Mitgliedsnamen und Passwortüberprüfun" &
        "g eine Aktuallisierung durchgeführt." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnNewUser.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(30, 17)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(531, 23)
        Me.Label34.TabIndex = 64
        Me.Label34.Text = "1. Informationen über EiSo Verkaufsverwaltung"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Location = New System.Drawing.Point(15, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 420)
        Me.Panel2.TabIndex = 63
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 11)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(535, 372)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = resources.GetString("Label30.Text")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(605, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(482, 23)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "EiSo kostenlose Registrierung | Anmeldung"
        '
        'tb_server
        '
        Me.tb_server.Controls.Add(Me.txtMYSQL_USER)
        Me.tb_server.Controls.Add(Me.txtMYSQL_PWD)
        Me.tb_server.Controls.Add(Me.Label14)
        Me.tb_server.Controls.Add(Me.Label15)
        Me.tb_server.Controls.Add(Me.Label1)
        Me.tb_server.Controls.Add(Me.lstServerMessage)
        Me.tb_server.Controls.Add(Me.btnServer_anlegen)
        Me.tb_server.Location = New System.Drawing.Point(4, 22)
        Me.tb_server.Name = "tb_server"
        Me.tb_server.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_server.Size = New System.Drawing.Size(1220, 480)
        Me.tb_server.TabIndex = 1
        Me.tb_server.Text = "0. Datenbank"
        Me.tb_server.UseVisualStyleBackColor = True
        '
        'txtMYSQL_USER
        '
        Me.txtMYSQL_USER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMYSQL_USER.Location = New System.Drawing.Point(149, 231)
        Me.txtMYSQL_USER.Name = "txtMYSQL_USER"
        Me.txtMYSQL_USER.Size = New System.Drawing.Size(210, 21)
        Me.txtMYSQL_USER.TabIndex = 44
        '
        'txtMYSQL_PWD
        '
        Me.txtMYSQL_PWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMYSQL_PWD.Location = New System.Drawing.Point(149, 258)
        Me.txtMYSQL_PWD.Name = "txtMYSQL_PWD"
        Me.txtMYSQL_PWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMYSQL_PWD.Size = New System.Drawing.Size(210, 21)
        Me.txtMYSQL_PWD.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(39, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Passwort:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(39, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Benutzername:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "EiSo - Benutzername Anlegen"
        '
        'lstServerMessage
        '
        Me.lstServerMessage.FormattingEnabled = True
        Me.lstServerMessage.Location = New System.Drawing.Point(37, 52)
        Me.lstServerMessage.Name = "lstServerMessage"
        Me.lstServerMessage.Size = New System.Drawing.Size(772, 147)
        Me.lstServerMessage.TabIndex = 0
        '
        'btnServer_anlegen
        '
        Me.btnServer_anlegen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnServer_anlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServer_anlegen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnServer_anlegen.Image = CType(resources.GetObject("btnServer_anlegen.Image"), System.Drawing.Image)
        Me.btnServer_anlegen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServer_anlegen.Location = New System.Drawing.Point(37, 318)
        Me.btnServer_anlegen.Name = "btnServer_anlegen"
        Me.btnServer_anlegen.Size = New System.Drawing.Size(772, 37)
        Me.btnServer_anlegen.TabIndex = 1
        Me.btnServer_anlegen.Text = "Datenbank auf Server anlegen"
        Me.btnServer_anlegen.UseVisualStyleBackColor = False
        '
        'tb_ebay
        '
        Me.tb_ebay.Controls.Add(Me.LinkLabel4)
        Me.tb_ebay.Controls.Add(Me.LinkLabel3)
        Me.tb_ebay.Controls.Add(Me.LinkLabel2)
        Me.tb_ebay.Controls.Add(Me.LinkLabel1)
        Me.tb_ebay.Controls.Add(Me.btnÜberspringen)
        Me.tb_ebay.Controls.Add(Me.btneBayTest)
        Me.tb_ebay.Controls.Add(Me.btneBayGetToken)
        Me.tb_ebay.Controls.Add(Me.btneBaySandbox)
        Me.tb_ebay.Controls.Add(Me.Label37)
        Me.tb_ebay.Controls.Add(Me.Label32)
        Me.tb_ebay.Controls.Add(Me.Label17)
        Me.tb_ebay.Controls.Add(Me.txteBayToken)
        Me.tb_ebay.Controls.Add(Me.txteBay_user)
        Me.tb_ebay.Controls.Add(Me.Label8)
        Me.tb_ebay.Controls.Add(Me.Label9)
        Me.tb_ebay.Controls.Add(Me.btnWeiter3)
        Me.tb_ebay.Controls.Add(Me.btneBay)
        Me.tb_ebay.Location = New System.Drawing.Point(4, 22)
        Me.tb_ebay.Name = "tb_ebay"
        Me.tb_ebay.Size = New System.Drawing.Size(1220, 480)
        Me.tb_ebay.TabIndex = 3
        Me.tb_ebay.Text = "2. eBay"
        Me.tb_ebay.UseVisualStyleBackColor = True
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(1021, 345)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(191, 13)
        Me.LinkLabel4.TabIndex = 101
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Sandbox TESTUSER registrieren"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(716, 51)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(147, 13)
        Me.LinkLabel3.TabIndex = 100
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Deutsche eBay Sandbox"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(1019, 318)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(193, 13)
        Me.LinkLabel2.TabIndex = 99
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Im Standard Webbrowser öffnen"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1019, 288)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(193, 13)
        Me.LinkLabel1.TabIndex = 98
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Im Standard Webbrowser öffnen"
        '
        'btnÜberspringen
        '
        Me.btnÜberspringen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnÜberspringen.Enabled = False
        Me.btnÜberspringen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnÜberspringen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnÜberspringen.Image = CType(resources.GetObject("btnÜberspringen.Image"), System.Drawing.Image)
        Me.btnÜberspringen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnÜberspringen.Location = New System.Drawing.Point(1001, 439)
        Me.btnÜberspringen.Name = "btnÜberspringen"
        Me.btnÜberspringen.Size = New System.Drawing.Size(216, 25)
        Me.btnÜberspringen.TabIndex = 97
        Me.btnÜberspringen.Text = "&Überspringen"
        Me.btnÜberspringen.UseVisualStyleBackColor = False
        '
        'btneBayTest
        '
        Me.btneBayTest.BackColor = System.Drawing.Color.NavajoWhite
        Me.btneBayTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneBayTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneBayTest.ImageIndex = 6
        Me.btneBayTest.Location = New System.Drawing.Point(719, 357)
        Me.btneBayTest.Name = "btneBayTest"
        Me.btneBayTest.Size = New System.Drawing.Size(294, 24)
        Me.btneBayTest.TabIndex = 96
        Me.btneBayTest.Text = "&2. eBay Login testen"
        Me.ToolTip1.SetToolTip(Me.btneBayTest, "Sie können nachdem Sie den eBay Schlüssel geholt haben hier Anmelden, diese Funkt" &
        "ion dient nur zum Testen.")
        Me.btneBayTest.UseVisualStyleBackColor = False
        '
        'btneBayGetToken
        '
        Me.btneBayGetToken.BackColor = System.Drawing.Color.PapayaWhip
        Me.btneBayGetToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneBayGetToken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneBayGetToken.ImageIndex = 6
        Me.btneBayGetToken.Location = New System.Drawing.Point(719, 312)
        Me.btneBayGetToken.Name = "btneBayGetToken"
        Me.btneBayGetToken.Size = New System.Drawing.Size(294, 24)
        Me.btneBayGetToken.TabIndex = 95
        Me.btneBayGetToken.Text = "&1. eBay Token holen (produktiv)"
        Me.ToolTip1.SetToolTip(Me.btneBayGetToken, resources.GetString("btneBayGetToken.ToolTip"))
        Me.btneBayGetToken.UseVisualStyleBackColor = False
        '
        'btneBaySandbox
        '
        Me.btneBaySandbox.BackColor = System.Drawing.Color.PapayaWhip
        Me.btneBaySandbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneBaySandbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneBaySandbox.ImageIndex = 6
        Me.btneBaySandbox.Location = New System.Drawing.Point(719, 282)
        Me.btneBaySandbox.Name = "btneBaySandbox"
        Me.btneBaySandbox.Size = New System.Drawing.Size(294, 24)
        Me.btneBaySandbox.TabIndex = 94
        Me.btneBaySandbox.Text = "&1. eBay Token holen (Sandbox)"
        Me.ToolTip1.SetToolTip(Me.btneBaySandbox, "Holen Sie sich Ihren eBay Sandbox Schlüssel (Token) von eBay mithilfe eines Sandb" &
        "ox TESTUSER der auf der Webseite angelegt werden kann.")
        Me.btneBaySandbox.UseVisualStyleBackColor = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(561, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(329, 23)
        Me.Label37.TabIndex = 63
        Me.Label37.Text = "eBay Zugangsdaten eingeben"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(37, 51)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(481, 413)
        Me.Label32.TabIndex = 61
        Me.Label32.Text = resources.GetString("Label32.Text")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(530, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(183, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "eBay Token von Webseite*"
        '
        'txteBayToken
        '
        Me.txteBayToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txteBayToken.Location = New System.Drawing.Point(719, 110)
        Me.txteBayToken.Multiline = True
        Me.txteBayToken.Name = "txteBayToken"
        Me.txteBayToken.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txteBayToken.Size = New System.Drawing.Size(410, 166)
        Me.txteBayToken.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.txteBayToken, "eBay Token wird über ""1. eBay einrichten"" geholt, bitte folgen Sie den eBay Anwei" &
        "sungen")
        '
        'txteBay_user
        '
        Me.txteBay_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txteBay_user.Location = New System.Drawing.Point(719, 73)
        Me.txteBay_user.Name = "txteBay_user"
        Me.txteBay_user.Size = New System.Drawing.Size(210, 21)
        Me.txteBay_user.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txteBay_user, "Bitte Ihr eBay Mitgliedsnamen angeben")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(568, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "eBay Mitgliedsname*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(485, 23)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "2. Informationen zur eBay Token Erstellung"
        '
        'btnWeiter3
        '
        Me.btnWeiter3.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnWeiter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeiter3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeiter3.Image = Global.YabE.My.Resources.Resources._03
        Me.btnWeiter3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWeiter3.Location = New System.Drawing.Point(719, 387)
        Me.btnWeiter3.Name = "btnWeiter3"
        Me.btnWeiter3.Size = New System.Drawing.Size(210, 25)
        Me.btnWeiter3.TabIndex = 62
        Me.btnWeiter3.Text = "&Weiter"
        Me.ToolTip1.SetToolTip(Me.btnWeiter3, "Anmeldung bei YABE. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bitte alle Benutzerdaten für die Vorlagen ausfüllen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnWeiter3.UseVisualStyleBackColor = False
        Me.btnWeiter3.Visible = False
        '
        'btneBay
        '
        Me.btneBay.BackColor = System.Drawing.Color.NavajoWhite
        Me.btneBay.Enabled = False
        Me.btneBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneBay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btneBay.Image = CType(resources.GetObject("btneBay.Image"), System.Drawing.Image)
        Me.btneBay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneBay.Location = New System.Drawing.Point(719, 439)
        Me.btneBay.Name = "btneBay"
        Me.btneBay.Size = New System.Drawing.Size(276, 25)
        Me.btneBay.TabIndex = 2
        Me.btneBay.Text = "&3. eBay Token speichern"
        Me.ToolTip1.SetToolTip(Me.btneBay, "Speichert den eBay Token und geht zum nächsten Schritt")
        Me.btneBay.UseVisualStyleBackColor = False
        '
        'tb_mail
        '
        Me.tb_mail.Controls.Add(Me.LinkLabel5)
        Me.tb_mail.Controls.Add(Me.chkMailSSLSupport)
        Me.tb_mail.Controls.Add(Me.Label36)
        Me.tb_mail.Controls.Add(Me.Label31)
        Me.tb_mail.Controls.Add(Me.Label33)
        Me.tb_mail.Controls.Add(Me.txtEmail_email)
        Me.tb_mail.Controls.Add(Me.Label27)
        Me.tb_mail.Controls.Add(Me.txtPOP3Port)
        Me.tb_mail.Controls.Add(Me.txtSMTPPort)
        Me.tb_mail.Controls.Add(Me.Label13)
        Me.tb_mail.Controls.Add(Me.Label57)
        Me.tb_mail.Controls.Add(Me.Label50)
        Me.tb_mail.Controls.Add(Me.cmbSMTPAnbieter)
        Me.tb_mail.Controls.Add(Me.txtPOP3Server)
        Me.tb_mail.Controls.Add(Me.txtSMTPServer)
        Me.tb_mail.Controls.Add(Me.Label10)
        Me.tb_mail.Controls.Add(Me.Label11)
        Me.tb_mail.Controls.Add(Me.Label12)
        Me.tb_mail.Controls.Add(Me.txtEmail_User)
        Me.tb_mail.Controls.Add(Me.txtEmail_pwd)
        Me.tb_mail.Controls.Add(Me.Label4)
        Me.tb_mail.Controls.Add(Me.Label5)
        Me.tb_mail.Controls.Add(Me.Label6)
        Me.tb_mail.Controls.Add(Me.btnWeiter2)
        Me.tb_mail.Controls.Add(Me.btnEmail)
        Me.tb_mail.Location = New System.Drawing.Point(4, 22)
        Me.tb_mail.Name = "tb_mail"
        Me.tb_mail.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_mail.Size = New System.Drawing.Size(1220, 480)
        Me.tb_mail.TabIndex = 2
        Me.tb_mail.Text = "3. Email"
        Me.tb_mail.UseVisualStyleBackColor = True
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(686, 167)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(220, 13)
        Me.LinkLabel5.TabIndex = 87
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Hilfe wie lauten meine Server Daten?"
        '
        'chkMailSSLSupport
        '
        Me.chkMailSSLSupport.AutoSize = True
        Me.chkMailSSLSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMailSSLSupport.Location = New System.Drawing.Point(691, 246)
        Me.chkMailSSLSupport.Name = "chkMailSSLSupport"
        Me.chkMailSSLSupport.Size = New System.Drawing.Size(94, 17)
        Me.chkMailSSLSupport.TabIndex = 86
        Me.chkMailSSLSupport.Text = "SSL Support"
        Me.ToolTip1.SetToolTip(Me.chkMailSSLSupport, "Im Normalfall ist SSL Support aktiv auf Ja zu stellen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sollten Sie keine Testema" &
        "il verschicken können, ändern Sie diese Einstellung.")
        Me.chkMailSSLSupport.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(577, 20)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(406, 23)
        Me.Label36.TabIndex = 67
        Me.Label36.Text = "Server Daten zum Email verschicken"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(33, 238)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(11, 13)
        Me.Label31.TabIndex = 66
        Me.Label31.Text = " "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(579, 196)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(624, 26)
        Me.Label33.TabIndex = 64
        Me.Label33.Text = "Benutzername und Email sind z.B. bei GMX gleich (Benutzername = Email), bei Anbie" &
    "tern wie Alphahosting " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sind Benutzername und Email unterschiedlich"
        '
        'txtEmail_email
        '
        Me.txtEmail_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail_email.Location = New System.Drawing.Point(691, 303)
        Me.txtEmail_email.Name = "txtEmail_email"
        Me.txtEmail_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmail_email.Size = New System.Drawing.Size(210, 21)
        Me.txtEmail_email.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.txtEmail_email, "Ihre Emailadresse bei Ihrem Provider eintragen")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(584, 305)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "EMail*"
        '
        'txtPOP3Port
        '
        Me.txtPOP3Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOP3Port.Location = New System.Drawing.Point(968, 130)
        Me.txtPOP3Port.Name = "txtPOP3Port"
        Me.txtPOP3Port.Size = New System.Drawing.Size(57, 21)
        Me.txtPOP3Port.TabIndex = 4
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSMTPPort.Location = New System.Drawing.Point(968, 91)
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(57, 21)
        Me.txtSMTPPort.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(870, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "POP3 Port*"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(871, 95)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(80, 13)
        Me.Label57.TabIndex = 56
        Me.Label57.Text = "SMTP Port*"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label50.Location = New System.Drawing.Point(34, 60)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(481, 404)
        Me.Label50.TabIndex = 54
        Me.Label50.Text = resources.GetString("Label50.Text")
        '
        'cmbSMTPAnbieter
        '
        Me.cmbSMTPAnbieter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSMTPAnbieter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSMTPAnbieter.FormattingEnabled = True
        Me.cmbSMTPAnbieter.Items.AddRange(New Object() {"Keine Auswahl", "GMX", "Google Mail", "Web", "Live"})
        Me.cmbSMTPAnbieter.Location = New System.Drawing.Point(690, 57)
        Me.cmbSMTPAnbieter.Name = "cmbSMTPAnbieter"
        Me.cmbSMTPAnbieter.Size = New System.Drawing.Size(335, 21)
        Me.cmbSMTPAnbieter.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cmbSMTPAnbieter, "Eine kleine Vorauswahl von Email Anbietern, Sie können diese Liste auch ignoriere" &
        "n")
        '
        'txtPOP3Server
        '
        Me.txtPOP3Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOP3Server.Location = New System.Drawing.Point(689, 130)
        Me.txtPOP3Server.Name = "txtPOP3Server"
        Me.txtPOP3Server.Size = New System.Drawing.Size(160, 21)
        Me.txtPOP3Server.TabIndex = 2
        '
        'txtSMTPServer
        '
        Me.txtSMTPServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSMTPServer.Location = New System.Drawing.Point(690, 91)
        Me.txtSMTPServer.Name = "txtSMTPServer"
        Me.txtSMTPServer.Size = New System.Drawing.Size(159, 21)
        Me.txtSMTPServer.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(578, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "POP3-Server*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(580, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Email Anbieter"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(579, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "SMTP-Server*"
        '
        'txtEmail_User
        '
        Me.txtEmail_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail_User.Location = New System.Drawing.Point(691, 269)
        Me.txtEmail_User.Name = "txtEmail_User"
        Me.txtEmail_User.Size = New System.Drawing.Size(210, 21)
        Me.txtEmail_User.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtEmail_User, "Sollten Sie nur eine Emailadresse kennen ist diese wahrscheinlich auch Ihr Benutz" &
        "ername.")
        '
        'txtEmail_pwd
        '
        Me.txtEmail_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail_pwd.Location = New System.Drawing.Point(690, 340)
        Me.txtEmail_pwd.Name = "txtEmail_pwd"
        Me.txtEmail_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmail_pwd.Size = New System.Drawing.Size(210, 21)
        Me.txtEmail_pwd.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtEmail_pwd, "Bitte Ihr Email Passwort eintragen")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(580, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Passwort*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Benutzername*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(399, 23)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "3. Informationen zum Emailversand"
        '
        'btnWeiter2
        '
        Me.btnWeiter2.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnWeiter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeiter2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeiter2.Image = Global.YabE.My.Resources.Resources._03
        Me.btnWeiter2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWeiter2.Location = New System.Drawing.Point(968, 436)
        Me.btnWeiter2.Name = "btnWeiter2"
        Me.btnWeiter2.Size = New System.Drawing.Size(210, 28)
        Me.btnWeiter2.TabIndex = 61
        Me.btnWeiter2.Text = "&Weiter"
        Me.ToolTip1.SetToolTip(Me.btnWeiter2, "Anmeldung bei YABE. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bitte alle Benutzerdaten für die Vorlagen ausfüllen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnWeiter2.UseVisualStyleBackColor = False
        Me.btnWeiter2.Visible = False
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmail.Location = New System.Drawing.Point(583, 436)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(317, 28)
        Me.btnEmail.TabIndex = 7
        Me.btnEmail.Text = "Emailversand testen und weiter..."
        Me.ToolTip1.SetToolTip(Me.btnEmail, "Testet Ihre Einstellungen mit einer Testemaill.")
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'tb_schließen
        '
        Me.tb_schließen.Controls.Add(Me.btnShopsteLogin)
        Me.tb_schließen.Controls.Add(Me.Label26)
        Me.tb_schließen.Controls.Add(Me.Label16)
        Me.tb_schließen.Controls.Add(Me.btnSchließen)
        Me.tb_schließen.Location = New System.Drawing.Point(4, 22)
        Me.tb_schließen.Name = "tb_schließen"
        Me.tb_schließen.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_schließen.Size = New System.Drawing.Size(1220, 480)
        Me.tb_schließen.TabIndex = 4
        Me.tb_schließen.Text = "4. Schließen"
        Me.tb_schließen.UseVisualStyleBackColor = True
        '
        'btnShopsteLogin
        '
        Me.btnShopsteLogin.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnShopsteLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShopsteLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShopsteLogin.ImageIndex = 6
        Me.btnShopsteLogin.Location = New System.Drawing.Point(46, 117)
        Me.btnShopsteLogin.Name = "btnShopsteLogin"
        Me.btnShopsteLogin.Size = New System.Drawing.Size(366, 26)
        Me.btnShopsteLogin.TabIndex = 120
        Me.btnShopsteLogin.Text = "&Shopste.com Login Formular && Synchronisation"
        Me.btnShopsteLogin.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(43, 55)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(588, 39)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Alle Konfigurationsschritte wurden abgeschlossen. Sie können jetzt auf ""Speichern" &
    " schließen"" klicken." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nächste Schritte: Es wird unter ""EiSo Werkzeuge -> ""Verk" &
    "aufabwicklung starten...."" aufgerufen."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(42, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(512, 23)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "4. Abschluss von Erstellung und Konfiguration"
        '
        'btnSchließen
        '
        Me.btnSchließen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchließen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSchließen.Image = CType(resources.GetObject("btnSchließen.Image"), System.Drawing.Image)
        Me.btnSchließen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchließen.Location = New System.Drawing.Point(46, 170)
        Me.btnSchließen.Name = "btnSchließen"
        Me.btnSchließen.Size = New System.Drawing.Size(398, 37)
        Me.btnSchließen.TabIndex = 3
        Me.btnSchließen.Text = "&Alle Einstellungen speichern und && schließen"
        Me.btnSchließen.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "EiSo Info"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.V054BetaToolStripMenuItem, Me.ApplicationIDToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProblemMeldenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 524)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.TestToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(203, 20)
        Me.TestToolStripMenuItem.Text = "Hilfe zur Registierung bei EiSo"
        Me.TestToolStripMenuItem.ToolTipText = "Ruft die Hilfe zur Installation auf"
        '
        'V054BetaToolStripMenuItem
        '
        Me.V054BetaToolStripMenuItem.Enabled = False
        Me.V054BetaToolStripMenuItem.Name = "V054BetaToolStripMenuItem"
        Me.V054BetaToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.V054BetaToolStripMenuItem.Text = "v.1.0.16 BETA"
        Me.V054BetaToolStripMenuItem.ToolTipText = "Zeigt die Programmversion an"
        '
        'ApplicationIDToolStripMenuItem
        '
        Me.ApplicationIDToolStripMenuItem.Enabled = False
        Me.ApplicationIDToolStripMenuItem.Name = "ApplicationIDToolStripMenuItem"
        Me.ApplicationIDToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ApplicationIDToolStripMenuItem.Text = "Anwendungsid:"
        Me.ApplicationIDToolStripMenuItem.ToolTipText = "Zugewiesene ComputerID"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadTeamviewerToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(426, 20)
        Me.ToolStripMenuItem1.Text = "Support Telefon: 0441-2 3333 05 oder per Email an jbludau@bludau-media.de"
        Me.ToolStripMenuItem1.ToolTipText = "Bei Problemen bei der Einrichtung können Sie mich anrufen"
        '
        'DownloadTeamviewerToolStripMenuItem
        '
        Me.DownloadTeamviewerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.DownloadTeamviewerToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.DownloadTeamviewerToolStripMenuItem.Name = "DownloadTeamviewerToolStripMenuItem"
        Me.DownloadTeamviewerToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DownloadTeamviewerToolStripMenuItem.Text = "Download Teamviewer"
        Me.DownloadTeamviewerToolStripMenuItem.ToolTipText = "Remote Unterstützung für das Telefonieren"
        '
        'ProblemMeldenToolStripMenuItem
        '
        Me.ProblemMeldenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProblemMeldenToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.ProblemMeldenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.ProblemMeldenToolStripMenuItem.Name = "ProblemMeldenToolStripMenuItem"
        Me.ProblemMeldenToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.ProblemMeldenToolStripMenuItem.Text = "Problem melden"
        Me.ProblemMeldenToolStripMenuItem.ToolTipText = "Melden von Problemen"
        '
        'starup_wizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 548)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "starup_wizard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo Verkaufsverwaltung - Registierung / Login"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tb_user.ResumeLayout(False)
        Me.tb_user.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.tb_server.ResumeLayout(False)
        Me.tb_server.PerformLayout()
        Me.tb_ebay.ResumeLayout(False)
        Me.tb_ebay.PerformLayout()
        Me.tb_mail.ResumeLayout(False)
        Me.tb_mail.PerformLayout()
        Me.tb_schließen.ResumeLayout(False)
        Me.tb_schließen.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tb_user As System.Windows.Forms.TabPage
    Friend WithEvents tb_server As System.Windows.Forms.TabPage
    Friend WithEvents lstServerMessage As System.Windows.Forms.ListBox
    Friend WithEvents btnServer_anlegen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_mail As System.Windows.Forms.TabPage
    Friend WithEvents txtEmail_User As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents tb_ebay As System.Windows.Forms.TabPage
    Friend WithEvents txteBay_user As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btneBay As System.Windows.Forms.Button
    Friend WithEvents txtPOP3Port As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPPort As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents cmbSMTPAnbieter As System.Windows.Forms.ComboBox
    Friend WithEvents txtPOP3Server As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPServer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMYSQL_USER As System.Windows.Forms.TextBox
    Friend WithEvents txtMYSQL_PWD As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txteBayToken As System.Windows.Forms.TextBox
    Friend WithEvents tb_schließen As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSchließen As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents V054BetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicationIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProblemMeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadTeamviewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnWeiter2 As System.Windows.Forms.Button
    Friend WithEvents btnWeiter3 As System.Windows.Forms.Button
    Friend WithEvents txtEmail_email As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As Label
    Friend WithEvents btnShopsteLogin As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOptionenLaden As Button
    Friend WithEvents txtAddTelefon As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtAddShop As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtAddLand As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtAddOrt As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtAddPLZ As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtAddStrasse As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtAddNachname As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtAddVorname As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtAddEmail As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNewUser As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents chkMailSSLSupport As CheckBox
    Friend WithEvents btneBaySandbox As Button
    Friend WithEvents btneBayGetToken As Button
    Friend WithEvents btneBayTest As Button
    Friend WithEvents chkShowthiswindow As CheckBox
    Friend WithEvents txtPasswort2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserFirmenname As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtEmailShopName As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents btnÜberspringen As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
End Class
