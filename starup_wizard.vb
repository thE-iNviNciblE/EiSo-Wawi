Imports System.ComponentModel

Public Class starup_wizard
    Dim gbl_KeyCode As String

    '######################################################
    '# >> Schlüssel berechnen 
    '######################################################
    Private Function getWMI_KeyCode() As String
        Dim strHDD As String = ""
        Dim strCPU As String = ""
        Dim strKeyCode As String = ""
        Try

            strHDD = getWMI_HDD_Serial()
            If strHDD = "-1" Or strHDD = "" Then
                MsgBox("Fehler beim Empfangen der HDD Serial", MsgBoxStyle.Critical)
                Exit Function
            End If

            Dim strMAC As String = getMacAddress() & "AAAA"

            ''PC ID 
            'strCPU = getWMI_CPU()
            'If strCPU = "-1" Or strCPU = "" Then
            '    MsgBox("Fehler beim empfangen der MAC Addresse", MsgBoxStyle.Critical)
            '    Exit Function
            'End If

            strKeyCode = Encrypt(strHDD & strMAC)

            strKeyCode = strKeyCode.Replace("+", "")
            strKeyCode = strKeyCode.Replace("=", "")
            strKeyCode = strKeyCode.Substring(0, 7)

            Return strKeyCode
        Catch ex As Exception
            Call debug_message(ex, "getWMI_KeyCode")
            Return "-1"
        End Try
    End Function

    '# WMI MAC 
    Private Function getWMI_CPU() As String
        Dim strCPU As String = ""
        Dim objWMIService As Object
        Dim colItems As Object
        Dim objItem As Object
        Dim strComputer As String = "."

        Try

            objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
            colItems = objWMIService.ExecQuery("Select * from Win32_Processor")

            For Each objItem In colItems
                Application.DoEvents()
                lstServerMessage.Items.Add("-- HDD INFO --")
                lstServerMessage.Items.Add("Prozessor ID:" & objItem.ProcessorId)
                strCPU = objItem.ProcessorId
                lstServerMessage.Items.Add("Geschwindigkeit:" & objItem.MaxClockSpeed & " Mhz")
                lstServerMessage.Items.Add("BUS-System:" & objItem.DataWidth & " Bit")
                lstServerMessage.Items.Add("Datum:" & objItem.InstallDate)
                lstServerMessage.Items.Add("-- ENDE --")
                lstServerMessage.Items.Add("")
            Next

            Return strCPU
        Catch ex As Exception
            Return "-1"
        End Try
    End Function

    '#  WMI HDD Serial 
    Private Function getWMI_HDD_Serial() As String
        Dim strHDD As String = ""
        Dim colDisks As Object
        Dim objDisk As Object

        Try
            colDisks = GetObject(
               "Winmgmts:").ExecQuery("Select * from Win32_LogicalDisk")

            For Each objDisk In colDisks
                Application.DoEvents()
                Select Case objDisk.DriveType

                    Case 3
                        lstServerMessage.Items.Add("-- HDD INFO --")
                        lstServerMessage.Items.Add("Bezeichnung: " & objDisk.Caption & " - " & objDisk.VolumeName & " - Typ: Festplatte")
                        lstServerMessage.Items.Add("Seriennummer: " & objDisk.VolumeSerialNumber)
                        lstServerMessage.Items.Add("Dateisystem: " & objDisk.FileSystem)
                        lstServerMessage.Items.Add("-- ENDE --")
                        lstServerMessage.Items.Add("")
                        strHDD = objDisk.VolumeSerialNumber
                        Exit For
                End Select
            Next

            Return strHDD
        Catch ex As Exception

            Return "-1"
        End Try
    End Function

    '# >> Neue Datenbank anlegen 
    Private Function setNewDB(ByVal strKey As String) As Boolean
        Try

            If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=DB&KEY=" & strKey & "&usr=" & System.Uri.EscapeDataString(txtUsername.Text) & "&pwd=" & System.Uri.EscapeDataString(settings_crypt(True, My.Settings.yabe_pwd)), mgetUpdaterMessage.getNewDB, True) = False Then
                MsgBox("Fehler beim empfangen der Daten vom Server")
            Else
                lstServerMessage.Items.Add("- Datenbank angelegt")

                '# Daten in Settings speichern 
                My.Settings.datenbank_db = "JBM_" & strKey
                My.Settings.Save()

            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '# >> Neuen User anlegen 
    Private Function setNewDB_User(ByVal strKey As String) As Boolean
        Try
            If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=USER&KEY=" & strKey, mgetUpdaterMessage.getNewUser, True) = False Then
                MsgBox("Fehler beim empfangen der Daten vom Server")
            Else
                lstServerMessage.Items.Add("Neuer USER angelegt")
                My.Settings.startup_setup = False
                My.Settings.Save()

            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function setNewUser_yabe(ByVal strkey As String, ByVal strUser As String, ByVal strPWD As String) As Boolean
        Try

            If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=YABE_USER&usr=" & System.Uri.EscapeDataString(strUser) & "&pwd=" & System.Uri.EscapeDataString(settings_crypt(True, strPWD)) & "&vorname=" & System.Uri.EscapeDataString(txtAddVorname.Text) & "&nachname=" & System.Uri.EscapeDataString(txtAddNachname.Text) & "&strasse=" & System.Uri.EscapeDataString(txtAddStrasse.Text) & "&ort=" & System.Uri.EscapeDataString(txtAddOrt.Text) & "&plz=" & System.Uri.EscapeDataString(txtAddPLZ.Text) & "&land=" & System.Uri.EscapeDataString(txtAddLand.Text) & "&email=" & System.Uri.EscapeDataString(txtAddEmail.Text) & "&KEY=" & strkey & "&mysql_user=" & System.Uri.EscapeDataString(txtMYSQL_USER.Text) & "&mysql_pwd=" & System.Uri.EscapeDataString(settings_crypt(True, txtMYSQL_PWD.Text)) & "&KEY=" & gbl_KeyCode, mgetUpdaterMessage.getNewYabe_User, True) = False Then
                MsgBox("Fehler beim empfangen der Daten vom Server", MsgBoxStyle.Exclamation)
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub starup_wizard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '# KEY - Crypt holen 
        gbl_KeyCode = getWMI_KeyCode()

        setBludauMediaLogbuch(">> CONFIG >> Starte Registrierung und Anmeldung - erster Start: " & My.Settings.sys_first_start, "EBAY_TOKEN")


        V054BetaToolStripMenuItem.Text = "   " & strVersionString & "    "
        ApplicationIDToolStripMenuItem.Text = "Application ID: " & gbl_KeyCode

        My.Settings.yabe_keycode = gbl_KeyCode
        My.Settings.Save()

        '# 
        If My.Settings.startup_setup = False Then
            btnOptionenLaden.Visible = True
            btnWeiter2.Visible = True
            btnWeiter3.Visible = True
        End If


        '# Tab Pages entfernen
        If My.Settings.bDeveloper_Mode = False Then
            TabControl1.TabPages.Remove(tb_server)
        End If

        TabControl1.TabPages.Remove(tb_mail)
        TabControl1.TabPages.Remove(tb_server)
        TabControl1.TabPages.Remove(tb_schließen)
        TabControl1.TabPages.Remove(tb_ebay)
        chkMailSSLSupport.Checked = My.Settings.email_ssl

        txtAddLand.Text = My.Settings.user_land
        txtAddOrt.Text = My.Settings.user_ort
        txtAddPLZ.Text = My.Settings.user_plz
        txtAddStrasse.Text = My.Settings.user_strasse
        txtAddNachname.Text = My.Settings.user_nachname
        txtAddVorname.Text = My.Settings.user_vorname
        txtAddEmail.Text = My.Settings.user_email
        txtAddTelefon.Text = My.Settings.user_telefon

        txtPOP3Port.Text = My.Settings.email_pop_port
        txtPOP3Server.Text = My.Settings.email_pop3
        txtSMTPServer.Text = My.Settings.email_smtp
        txtSMTPPort.Text = My.Settings.email_smtp_port
        txtEmail_User.Text = My.Settings.email_username
        txtEmail_pwd.Text = settings_crypt(False, My.Settings.email_pwd)


        txtUsername.Text = My.Settings.yabe_username
        txtPasswort.Text = settings_crypt(False, My.Settings.yabe_pwd)
        txtPasswort2.Text = txtPasswort.Text


        txteBay_user.Text = My.Settings.ebay_username

        txtMYSQL_PWD.Text = settings_crypt(False, My.Settings.datenbank_pwd)
        txtMYSQL_USER.Text = My.Settings.datenbank_username

        txteBayToken.Text = My.Settings.Production_ebaytoken
        txtAddShop.Text = My.Settings.shop_url
        chkShowthiswindow.Checked = My.Settings.startup_setup

        If My.Settings.sys_first_start = True Then
            If Not My.Settings.datenbank_server = "bludau-media.de" Then
                '   btnNewUser.Enabled = False
                '   btnNewUser.Text = "EiSo Online Datenbank aktuallisieren"
            Else
                '   btnNewUser.Text = "EiSo Online Datenbank aktuallisieren"
            End If

            chkShowthiswindow.Enabled = True
        Else
            chkShowthiswindow.Checked = True
            chkShowthiswindow.Enabled = False
            btnNewUser.Text = "EiSo Online Datenbank kostenlos anlegen"
        End If
    End Sub

    Private Sub setNewDB_main()
        If Not gbl_KeyCode = "-1" Or Not gbl_KeyCode = "" Then
            btnServer_anlegen.Enabled = False
            '# Neue Datenbank 
            If setNewDB(gbl_KeyCode) = True Then

                '# Neuer Benutzer anlegen 
                If setNewDB_User(gbl_KeyCode) = True Then
                    txtMYSQL_PWD.Text = settings_crypt(False, My.Settings.datenbank_pwd)
                    txtMYSQL_USER.Text = My.Settings.datenbank_username

                    '# -> Daten setzten 
                    clsDatenbank_modul.setINITDB("", "")
                Else
                    MsgBox("Fehler beim Anlegen eines neuen Benutzers", MsgBoxStyle.Critical)
                End If
            Else
                Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?Mod= SYS_MESSAGE&nachricht=" & System.Uri.EscapeDataString("Fehler beim Anlegen der neuen Datenbank, weil keine Lizenzid generiert werden konnte.") & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setDebugMessage2HTTPServer, False)

                MsgBox("Fehler beim Anlegen der neuen Datenbank, weil keine Lizenzid generiert werden konnte.", MsgBoxStyle.Critical)

            End If
            btnServer_anlegen.Enabled = True
        End If
    End Sub

    Private Sub btnServer_anlegen_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServer_anlegen.Click

        Call setNewDB_main()

    End Sub

    Private Sub cmbSMTPAnbieter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSMTPAnbieter.SelectedIndexChanged
        Select Case cmbSMTPAnbieter.Text
            Case "GMX"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "mail.gmx.net"
                txtPOP3Server.Text = "pop.gmx.net"

            Case "Web"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.web.de"
                txtPOP3Server.Text = "pop3.web.de"
            Case "Live"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.live.com"
                txtPOP3Server.Text = "pop3.live.com"
            Case "Google Mail"
                txtSMTPPort.Text = "465"
                txtPOP3Port.Text = "587"
                txtSMTPServer.Text = "smtp.googlemail.com"
                txtPOP3Server.Text = "pop.googlemail.com "
            Case "Yahoo"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.mail.yahoo.de"
                txtPOP3Server.Text = "pop.mail.yahoo.com"
            Case "Keine Auswahl"
                txtSMTPPort.Text = ""
                txtPOP3Port.Text = ""
                txtSMTPServer.Text = ""
                txtPOP3Server.Text = ""
        End Select
    End Sub

    Private Sub btneBay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneBay.Click
        Dim frmUser As New FrmGetUser

        btneBay.Enabled = False

        If txteBay_user.Text.Length = 0 Then
            MsgBox("Bitte einen 'Benutzernamen' einfügen", MsgBoxStyle.Information)
            btneBay.Enabled = True
            Exit Sub
        End If

        If txteBayToken.Text.Length = 0 Then
            MsgBox("Bitte den eBay Zugangsschlüssel (Token) einfügen", MsgBoxStyle.Information)
            btneBay.Enabled = True
            Exit Sub
        End If

        If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?Mod= EBAY_USER&eBay_User=" & txteBay_user.Text & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.getNewEbay_User, True) = False Then
            MsgBox("Fehler beim empfangen der Daten vom Server")
        Else

            setBludauMediaLogbuch(">> CONFIG >> eBay TOKEN gespeichert <br/>EISO USER:" & My.Settings.yabe_username, "EBAY_TOKEN")

            TabControl1.TabPages.Add(tb_mail)
            TabControl1.SelectedIndex = 2
        End If

        btneBay.Enabled = True

    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click

        btnEmail.Enabled = False

        If txtPOP3Port.Text.Length = 0 Then
            MsgBox("Bitte das Feld Pop3 ausfüllen, normalerweise '110'", MsgBoxStyle.Information)
            txtPOP3Port.Focus()
            btnEmail.Enabled = True
            Exit Sub
        End If

        If txtPOP3Server.Text.Length = 0 Then
            MsgBox("Bitte das Feld 'Pop-Server' ausfüllen", MsgBoxStyle.Information)
            txtPOP3Server.Focus()
            btnEmail.Enabled = True
            Exit Sub
        End If

        If txtSMTPServer.Text.Length = 0 Then
            MsgBox("Bitte das Feld 'SMTP-Server' ausfüllen", MsgBoxStyle.Information)
            txtSMTPServer.Focus()
            btnEmail.Enabled = True
            Exit Sub
        End If

        If txtSMTPPort.Text.Length = 0 Then
            MsgBox("Bitte das Feld 'SMTP-Port' ausfüllen, normalerweise '25'", MsgBoxStyle.Information)
            txtSMTPPort.Focus()
            btnEmail.Enabled = True
            Exit Sub
        End If

        If txtEmail_User.Text.Length = 0 Then
            MsgBox("Bitte das Feld 'Email-User' ausfüllen", MsgBoxStyle.Information)
            txtEmail_User.Focus()
            btnEmail.Enabled = True
            Exit Sub
        End If

        If txtEmail_pwd.Text.Length = 0 Then
            MsgBox("Bitte das Feld 'Email-Passwort' ausfüllen", MsgBoxStyle.Information)
            txtEmail_pwd.Focus()
            btnEmail.Enabled = True
            Exit Sub
        End If

        '# Speichern der INI 
        My.Settings.email_pop_port = txtPOP3Port.Text
        My.Settings.email_pop3 = txtPOP3Server.Text
        My.Settings.email_smtp = txtSMTPServer.Text
        My.Settings.email_smtp_port = txtSMTPPort.Text
        My.Settings.email_username = txtEmail_User.Text
        My.Settings.email_pwd = settings_crypt(True, txtEmail_pwd.Text)
        My.Settings.Save()

        Dim clsMail As New clsEmail
        clsMail.bDebug_mail = True
        clsMail.strEmail_empfänger_email = txtEmail_User.Text

        If clsMail.setSendMail("<h2>YabE Testemail</h2><br/>Vielen Dank für Ihr Interesse an EiSo <a href=""https://bludau-media.de"" target=""_blank"">Webseite</a>", "Testemail für " & My.Settings.yabe_username) = True Then

            Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=OPT_EMAIL&email_server_smtp=" + txtSMTPServer.Text + "&email_user=" + txtEmail_User.Text + "&email_pwd=" + settings_crypt(True, txtEmail_pwd.Text) + "&email_server_pop3=" + txtPOP3Server.Text + "&email_absendename=" & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setShopUserData, True)

            setBludauMediaLogbuch(">> CONFIG >> Email Adresse ist ok: " & txtEmail_User.Text, "EMAIL_TEST")

            MsgBox("Eine Testemail wurde an " & My.Settings.email_username & " bitte rufen Sie Ihre Emails ab.", MsgBoxStyle.Information)

            If txteBayToken.Text.Length > 0 Then
                btneBay.Enabled = True
            End If

            '# Nächsten Tab einbinden
            If getTabControlls("tb_schließen") Then
                TabControl1.TabPages.Add(tb_schließen)
            End If

            TabControl1.SelectedIndex = 3
        End If

        btnEmail.Enabled = True
    End Sub

    Private Sub btnSchließen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchließen.Click
        btnSchließen.Enabled = False

        If My.Settings.ebay_username.Length > 0 And My.Settings.ebay_pwd.Length > 0 And My.Settings.email_username.Length > 0 And My.Settings.email_pwd.Length > 0 And My.Settings.datenbank_db.Length > 0 And My.Settings.datenbank_pwd.Length > 0 And My.Settings.datenbank_username.Length > 0 Then

            My.Settings.startup_setup = False



            Call frmMain.laden_auktionsmanagement()

            Me.Close()

        Else
            MsgBox("Es sind nicht alle Felder ausgefüllt", MsgBoxStyle.Information)
            My.Settings.startup_setup = True
        End If


        btnSchließen.Enabled = True
    End Sub



    Private Sub txteBayToken_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteBayToken.TextChanged

        My.Settings.Production_ebaytoken = txteBayToken.Text
        My.Settings.Save()

    End Sub

    Private Sub txtAddVorname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_vorname = txtAddVorname.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddNachname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_nachname = txtAddNachname.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddStrasse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_strasse = txtAddStrasse.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddPLZ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_plz = txtAddPLZ.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddOrt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_ort = txtAddOrt.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddLand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_land = txtAddLand.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_email = txtAddEmail.Text
        My.Settings.Save()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frmEiSoLogin As New frmEiSoLogin
        frmEiSoLogin.Show()

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.yabe_username = txtUsername.Text
        My.Settings.yabe_shop_url = txtUsername.Text
        txtAddShop.Text = "http://eiso-shop.cubss.net/" & txtUsername.Text & "/"
        My.Settings.Save()
    End Sub

    Private Sub txtPasswort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtAddTelefon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.user_telefon = txtAddTelefon.Text
        My.Settings.Save()
    End Sub



    Private Sub ProblemMeldenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProblemMeldenToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://bludau-media.de/de/3513/Projektanfrage/"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://bludau-media.de/de/3529/Bludau-Media-Windows-Software/Eiso-Verkaufsabwicklung/Hilfe-zu-EiSo/"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
    End Sub

    Private Sub txteBay_user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteBay_user.TextChanged
        My.Settings.ebay_username = txteBay_user.Text
        My.Settings.Save()
    End Sub

    Private Sub txteBay_pwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   My.Settings.ebay_pwd = txteBay_pwd.Text
        '   My.Settings.Save()
    End Sub

    Private Sub DownloadTeamviewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadTeamviewerToolStripMenuItem.Click
        '==============================================
        '# Teamviewer Quick Start Download 
        '##############################################
        clsUpdateDownloader = New WebFileDownloader
        Application.DoEvents()
        strPathUpdater = Application.StartupPath & "\Updater\TeamViewerQS.exe"
        clsUpdateDownloader.DownloadFileWithProgress("http://www.teamviewer.com/download/TeamViewerQS.exe", strPathUpdater, False)

        '# Starten von Teamviewer 
        If MsgBox("Möchten Sie Teamviewer Starten?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            Dim strFile As String = strPathUpdater
            ExterneAnwendung.StartInfo.FileName = strFile
            ExterneAnwendung.Start()
        End If

    End Sub

    Private Sub btnWeiter1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If getTabControlls("tb_mail") Then
            TabControl1.TabPages.Add(tb_mail)
        End If

        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnWeiter3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeiter3.Click

        If getTabControlls("tb_schließen") Then
            TabControl1.TabPages.Add(tb_mail)
            TabControl1.TabPages.Add(tb_schließen)
        End If

        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub btnWeiter2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeiter2.Click

        If getTabControlls("tb_ebay") Then
            TabControl1.TabPages.Add(tb_ebay)
        End If
        TabControl1.SelectedIndex = 2
    End Sub

    Function getTabControlls(ByVal strTabName As String) As Boolean
        Dim iCount As Integer
        For iCount = 0 To TabControl1.Controls.Count - 1

            If TabControl1.Controls.Item(iCount).Name = strTabName Then
                Return False
                Exit For
            End If

        Next
        Return True
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub txtAddShop_TextChanged(sender As System.Object, e As System.EventArgs)
        My.Settings.shop_url = txtAddShop.Text
        My.Settings.Save()
    End Sub

    Private Sub txtMYSQL_PWD_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMYSQL_PWD.TextChanged

    End Sub

    Private Sub txtMYSQL_USER_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMYSQL_USER.TextChanged

    End Sub

    Private Sub txtEmail_email_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmail_email.TextChanged
        My.Settings.email_versand_username = txtEmail_email.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSMTPPort_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSMTPPort.TextChanged
        If txtSMTPPort.Text = "587" Then
            If MessageBox.Show("Möchten Sie für Ihre Email den SSL Support aktivieren?", "Email Verschlüsselung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                My.Settings.email_ssl = True
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnShopsteLogin_Click(sender As Object, e As EventArgs) Handles btnShopsteLogin.Click
        Dim frmShopsteLogin As New LoginForm1
        frmShopsteLogin.Show()
    End Sub

    Private Sub txtEmail_pwd_TextChanged(sender As Object, e As EventArgs) Handles txtEmail_pwd.TextChanged

    End Sub

    Private Sub starup_wizard_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        '# Wenn Login in Benutzer klappt login starten
        If bFormLoaded = False Then


            If clsDatenbank_modul.chkLogin(My.Settings.yabe_username.Replace("'", "''"), My.Settings.yabe_pwd.Replace("'", "''")) = True Then

                Call frmMain.laden_auktionsmanagement()
            Else
                MessageBox.Show("Kann micht nicht in der " & My.Settings.EISO_SERVER & " Datenbank anmelden...")
            End If
        End If

    End Sub


    Private Sub txtEmail_User_TextChanged(sender As Object, e As EventArgs) Handles txtEmail_User.TextChanged
        My.Settings.email_versand_username = txtEmail_User.Text
        My.Settings.Save()
    End Sub

    Private Sub chkMailSSLSupport_CheckedChanged(sender As Object, e As EventArgs) Handles chkMailSSLSupport.CheckedChanged
        My.Settings.email_ssl = chkMailSSLSupport.Checked
        My.Settings.Save()
    End Sub

    Private Sub btneBaySandbox_Click(sender As Object, e As EventArgs) Handles btneBaySandbox.Click

        setBludauMediaLogbuch(">> CONFIG >> eBay Benutzer Sandbox TOKEN holen:" & txteBay_user.Text, "EBAY_CONFIG")

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "https: //signin.sandbox.ebay.com/ws/eBayISAPI.dll?SignIn&runame=auth_tool_sdk_11c3666f3d354678b6a1c5ebd50394fa&ruparams=params|Sandbox-auth_tool_sdk_11c3666f3d354678b6a1c5ebd50394fa-true-5049&hc=1&hm=vo.sk73%283350036"
        frmWeb.Show()
    End Sub

    Private Sub btneBayTest_Click(sender As Object, e As EventArgs) Handles btneBayTest.Click
        Dim frmUser As New FrmGetUser

        btneBayTest.Enabled = False

        frmUser.TxtItemId.Visible = False
        frmUser.LblItemId.Visible = False
        frmUser.btnVor.Visible = False
        frmUser.btnBack.Visible = False
        frmUser.TxtUserId.Text = My.Settings.ebay_username
        frmUser.Show()
        frmUser.BtnGetUser.PerformClick()

        btneBayTest.Enabled = True
    End Sub

    Private Sub btneBayGetToken_Click(sender As Object, e As EventArgs) Handles btneBayGetToken.Click

        setBludauMediaLogbuch(">> CONFIG >> eBay Benutzer Produktiv TOKEN holen:" & txteBay_user.Text, "EBAY_CONFIG")

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "https://signin.ebay.de/ws/eBayISAPI.dll?SignIn&runame=auth_tool_sdk_2b6b54516b704cef9b66447741d6689e&ruparams=params|Production-auth_tool_sdk_2b6b54516b704cef9b66447741d6689e-true-5045"
        frmWeb.Show()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim frmEiSoLogin As New frmEiSoLogin
        frmEiSoLogin.Show()
    End Sub

    Private Sub chkShowthiswindow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowthiswindow.CheckedChanged
        My.Settings.startup_setup = chkShowthiswindow.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnWeiter1_Click_1(sender As Object, e As EventArgs) Handles btnOptionenLaden.Click
        Dim frmOptions As New frmOptions
        frmOptions.ShowDialog()
    End Sub

    Private Sub btnNewUser_Click_1(sender As Object, e As EventArgs) Handles btnNewUser.Click

        Try

            If txtUsername.Text.Length = 0 Then
                MsgBox("Bitte Benutzernamen eingeben!", MsgBoxStyle.Information)
                txtUsername.Focus()
                Exit Sub
            End If

            If txtPasswort.Text.Length = 0 Or txtPasswort2.Text.Length = 0 Then
                MsgBox("Bitte beide Passwortfelder ausfüllen!", MsgBoxStyle.Information)
                txtPasswort.Focus()
                Exit Sub
            End If

            If Not txtPasswort2.Text = txtPasswort.Text Then
                MsgBox("Es wurde nicht in beide Passwortfelder das gleiche Passwort eingetragen!", MsgBoxStyle.Exclamation)
                txtPasswort.Focus()
            End If


            If txtAddEmail.Text.Length = 0 Then
                MsgBox("Bitte Emailadresse eingeben!", MsgBoxStyle.Information)
                txtAddEmail.Focus()
                Exit Sub
            End If

            If txtAddVorname.Text.Length = 0 Then
                MsgBox("Bitte Vornamen eingeben!", MsgBoxStyle.Information)
                txtAddVorname.Focus()
                Exit Sub
            End If

            If txtAddNachname.Text.Length = 0 Then
                MsgBox("Bitte Nachnamen eingeben!", MsgBoxStyle.Information)
                txtAddNachname.Focus()
                Exit Sub
            End If

            If txtAddStrasse.Text.Length = 0 Then
                MsgBox("Bitte Strasse eingeben!", MsgBoxStyle.Information)
                txtAddStrasse.Focus()
                Exit Sub
            End If

            If txtAddPLZ.Text.Length = 0 Then
                MsgBox("Bitte Postleitzahl eingeben!", MsgBoxStyle.Information)
                txtAddPLZ.Focus()
                Exit Sub
            End If

            If txtAddLand.Text.Length = 0 Then
                MsgBox("Bitte Land eingeben!", MsgBoxStyle.Information)
                txtAddLand.Focus()
                Exit Sub
            End If

            If txtAddOrt.Text.Length = 0 Then
                MsgBox("Bitte Ort eingeben!", MsgBoxStyle.Information)
                txtAddOrt.Focus()
                Exit Sub
            End If

            btnNewUser.Enabled = False
            btnLogin.Enabled = False

            '# NEUE  DATENBANK ANLEGEN 
            Call setNewDB_main()

            btnNewUser.Enabled = False
            '#########################################
            '# Neues EiSo Mitglied anmelden
            '#########################################
            If setNewUser_yabe(My.Settings.yabe_keycode, txtUsername.Text, txtPasswort.Text) = True And frmMain.master_Message_label.Text.Contains("YabE Benutzer") Then

                '# NEUEN FTP ORDNER ANLEGEN 
                If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://api.bludau-media.de/EiSo/ftp.php?mod=FTP_FOLDER&usr=" & My.Settings.yabe_username & "&yabe_passwort=" & settings_crypt(True, txtPasswort.Text), mgetUpdaterMessage.setFTPFOLDER, True) = False Then
                    MsgBox("Es gab einen Fehler beim Erzeugen des FTP Ordners", MsgBoxStyle.Exclamation)
                Else
                    My.Settings.ftp_hochladepfad = "/httpdocs/eBay/" & My.Settings.yabe_username
                End If


                Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=OPT_USER&user_vorname=" + System.Uri.EscapeDataString(txtAddVorname.Text) + "&user_nachname=" + System.Uri.EscapeDataString(txtAddNachname.Text) + "&user_strasse=" + System.Uri.EscapeDataString(txtAddStrasse.Text) + "&user_plz=" + System.Uri.EscapeDataString(txtAddPLZ.Text) + "&user_ort=" + System.Uri.EscapeDataString(txtAddOrt.Text) + "&user_land=" + System.Uri.EscapeDataString(txtAddLand.Text) + "&user_telefon=" + System.Uri.EscapeDataString(txtAddTelefon.Text) & "&reg=true&user_email=" & System.Uri.EscapeDataString(txtAddEmail.Text) & "&shop_url_key=" & System.Uri.EscapeDataString(txtUsername.Text) & "&yabe_username=" & System.Uri.EscapeDataString(txtUsername.Text) & "&user_firma=" & System.Uri.EscapeDataString(txtUserFirmenname.Text) & "&user_shopname=" & System.Uri.EscapeDataString(txtEmailShopName.Text) & "&yabe_passwort=" & System.Uri.EscapeDataString(settings_crypt(True, txtPasswort.Text)) & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setShopUserData, True)

                Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=FTP_SYM&usr=" & txtUsername.Text & "&KEY=" & My.Settings.yabe_keycode & "&yabe_passwort=" & settings_crypt(True, txtPasswort.Text), mgetUpdaterMessage.setSYM_LINK, True)
                '# BASSIS SETTINGS ÜBERNEHMEN 
                '# > Shop URL 
                '# > Bilderverzeichnis
                '# > Galerie Verzeichnis
                '  If My.Settings.shop_url.Length = 0 Then
                txtAddShop.Text = "http://eiso-shop.cubss.net/" & txtUsername.Text & "/"
                My.Settings.shop_url = "http://eiso-shop.cubss.net/" & txtUsername.Text & "/"
                My.Settings.shop_url_bilder = "http://eiso-shop.cubss.net/"
                '# Bilderverzeichnis anpassen
                'My.Settings.shop_url_bilder = "http://bilder-upload.cubss.net" & My.Settings.ftp_hochladepfad.Replace("/httpdocs", "") & "/"
                My.Settings.shop_url_galerie = "http://ebay-galerie.cubss.net/"
                My.Settings.Save()
                'End If
                setBludauMediaLogbuch(">> CONFIG >> Datenbank JBM_" & gbl_KeyCode & " angelegt. <br/>EISO USER:" & My.Settings.yabe_username, "DBINIT")

            Else

                Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=OPT_USER&user_vorname=" + System.Uri.EscapeDataString(txtAddVorname.Text) + "&user_nachname=" + System.Uri.EscapeDataString(txtAddNachname.Text) + "&user_strasse=" + System.Uri.EscapeDataString(txtAddStrasse.Text) + "&user_plz=" + System.Uri.EscapeDataString(txtAddPLZ.Text) + "&user_ort=" + System.Uri.EscapeDataString(txtAddOrt.Text) + "&user_land=" + System.Uri.EscapeDataString(txtAddLand.Text) + "&user_telefon=" + System.Uri.EscapeDataString(txtAddTelefon.Text) & "&reg=true&user_email=" & System.Uri.EscapeDataString(txtAddEmail.Text) & "&shop_url_key=" & System.Uri.EscapeDataString(txtUsername.Text) & "&yabe_username=" & System.Uri.EscapeDataString(txtUsername.Text) & "&yabe_passwort=" & System.Uri.EscapeDataString(settings_crypt(True, txtPasswort.Text)) & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setShopUserData, True)

                setBludauMediaLogbuch(">> CONFIG >> Datenbank UPDATE JBM_" & gbl_KeyCode & " angelegt. <br/>EISO USER:" & My.Settings.yabe_username, "DBINIT")

            End If

            If Not frmMain.master_Message_label.Text = "Benutzer bereits vorhanden!" Then
                '# Nächsten Tab einbinden
                If RadioButton1.Checked = False Then
                    If getTabControlls("tb_ebay") Then
                        TabControl1.TabPages.Add(tb_ebay)
                    End If
                Else
                    TabControl1.TabPages.Add(tb_mail)
                End If

                TabControl1.SelectedIndex = 1
            Else
                MessageBox.Show("Bitte benutzen Sie einen anderen Benutzernamen")
            End If


            My.Settings.yabe_username = txtUsername.Text
            My.Settings.yabe_pwd = settings_crypt(True, txtPasswort.Text)
            My.Settings.Save()

            btnNewUser.Enabled = True
        Catch ex As Exception
            btnNewUser.Enabled = True
        End Try
    End Sub

    Private Sub txtAddEmail_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddEmail.TextChanged
        My.Settings.user_email = txtAddEmail.Text
        My.Settings.anmeldung_email = txtAddEmail.Text
        My.Settings.Save()
    End Sub

    Private Sub txtPasswort2_TextChanged(sender As Object, e As EventArgs) Handles txtPasswort2.TextChanged

    End Sub

    Private Sub txtPasswort_TextChanged_1(sender As Object, e As EventArgs) Handles txtPasswort.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged_1(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtAddVorname_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddVorname.TextChanged
        My.Settings.user_vorname = txtAddVorname.Text
        My.Settings.anmeldung_vorname = txtAddVorname.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddNachname_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddNachname.TextChanged
        My.Settings.user_nachname = txtAddNachname.Text
        My.Settings.anmeldung_nachname = txtAddNachname.Text
        My.Settings.Save()
    End Sub

    Private Sub tb_user_Click(sender As Object, e As EventArgs) Handles tb_user.Click

    End Sub

    Private Sub txtAddStrasse_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddStrasse.TextChanged
        My.Settings.user_strasse = txtAddStrasse.Text
        My.Settings.anmeldung_strasse = txtAddStrasse.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddTelefon_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddTelefon.TextChanged
        My.Settings.user_telefon = txtAddTelefon.Text
        My.Settings.anmeldung_handy = txtAddTelefon.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddPLZ_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddPLZ.TextChanged
        My.Settings.user_plz = txtAddPLZ.Text
        My.Settings.anmeldung_postleitzahl = txtAddPLZ.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddOrt_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddOrt.TextChanged
        My.Settings.user_ort = txtAddOrt.Text
        My.Settings.anmeldung_stadt = txtAddOrt.Text
        My.Settings.Save()
    End Sub

    Private Sub txtAddLand_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddLand.TextChanged
        My.Settings.user_land = txtAddLand.Text
        My.Settings.anmeldung_land = txtAddLand.Text
        My.Settings.Save()
    End Sub

    Private Sub txtFirma_TextChanged(sender As Object, e As EventArgs) Handles txtUserFirmenname.TextChanged
        My.Settings.user_firmenname = txtUserFirmenname.Text
        My.Settings.anmeldung_firma = txtUserFirmenname.Text
        My.Settings.Save()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnÜberspringen_Click(sender As Object, e As EventArgs) Handles btnÜberspringen.Click

        setBludauMediaLogbuch(">> CONFIG >> eBay Token holen übersprungen" & txteBay_user.Text, "EBAY_TOKEN")

        TabControl1.TabPages.Add(tb_mail)
    End Sub

    Private Sub starup_wizard_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        setBludauMediaLogbuch(">> CONFIG >> Beende Registrierung und Anmeldung - erster Start: " & My.Settings.sys_first_start, "EBAY_TOKEN")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://signin.sandbox.ebay.com/ws/eBayISAPI.dll?SignIn&runame=auth_tool_sdk_11c3666f3d354678b6a1c5ebd50394fa&ruparams=params|Sandbox-auth_tool_sdk_11c3666f3d354678b6a1c5ebd50394fa-true-5049&hc=1&hm=vo.sk73%283350036")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Process.Start("https://signin.ebay.de/ws/eBayISAPI.dll?SignIn&runame=auth_tool_sdk_2b6b54516b704cef9b66447741d6689e&ruparams=params|Production-auth_tool_sdk_2b6b54516b704cef9b66447741d6689e-true-5045")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://www.sandbox.ebay.de/")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://developer.ebay.com/DevZone/sandboxuser/default.aspx")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("http://www.patshaping.de/hilfen_ta/pop3_smtp.htm")
    End Sub
End Class