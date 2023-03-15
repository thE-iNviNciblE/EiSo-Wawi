Public Class frmEiSoLogin
    Public strMessage As String = ""
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click

        btnLogin.Enabled = False

        If My.Settings.yabe_keycode = "" Then
            My.Settings.yabe_keycode = gbl_KeyCode
            My.Settings.Save()
        End If
        Dim strEiSoServerTMP As String = My.Settings.EISO_SERVER

        If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=YABE_LOGIN&usr=" & System.Uri.EscapeDataString(txtUsername.Text) & "&pwd=" & System.Uri.EscapeDataString(settings_crypt(True, txtPasswort.Text)) & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.getYABEConfig, True) = False And frmMain.master_Message_label.Text = "Nicht eingeloggt" Then
            '  MessageBox.Show("Fehler beim EiSo Login, bitte erneut versuchen.", "Fehler beim Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            setBludauMediaLogbuch("Fehler beim EiSo Login, bitte mit einem anderen Passwort versuchen." & My.Settings.yabe_username, "LOGIN")
            lblMessage.Text = "Fehler beim EiSo Login, bitte mit einem anderen Passwort versuchen."
        Else

            setBludauMediaLogbuch(">>> EiSo erfolgreicher Login " & My.Settings.yabe_username, "LOGIN")


            MsgBox("EiSo Login war erfolgreich als '" & txtUsername.Text & "'" & vbCrLf & "Ihre Einstellungen wurden vom '" & My.Settings.EISO_SERVER & "' Server übernommen", MsgBoxStyle.Information)

            Call clsDatenbank_modul.setINITDB("", "")
            Application.DoEvents()
            Call frmMain.laden_auktionsmanagement()
            Application.DoEvents()
            Me.Close()

        End If

        btnLogin.Enabled = True
    End Sub

    Private Sub frmEiSoLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If strMessage.Length > 0 Then
            lblMessage.Text = strMessage
        End If

        txtUsername.Text = My.Settings.yabe_username
        txtPasswort.Text = settings_crypt(False, My.Settings.yabe_pwd)
    End Sub

    Private Sub txtUsername_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsername.TextChanged
        My.Settings.yabe_username = txtUsername.Text
        My.Settings.Save()
    End Sub

    Private Sub txtPasswort_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPasswort.TextChanged
        My.Settings.yabe_pwd = settings_crypt(True, txtPasswort.Text)
        My.Settings.Save()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frmPasswort As New frmEiSoLoginPasswortvergessen
        frmPasswort.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim frmPasswortneu As New frmEiSoPasswortändern
        frmPasswortneu.Show()
    End Sub
End Class