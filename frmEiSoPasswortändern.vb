Public Class frmEiSoPasswortändern
    Private Sub btnPasswortLost_Click(sender As Object, e As EventArgs) Handles btnPasswortLost.Click
        If txtBenutzername.Text.Length = 0 Then
            txtBenutzername.Focus()
            MessageBox.Show("Bitte Benutzernamen ausfüllen", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtPasswortNeu.Text.Length = 0 Or txtPasswortNeu2.Text.Length = 0 Then
            MessageBox.Show("Bitte Passwortfelder beide ausfüllen", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPasswortNeu.Focus()
            Exit Sub
        End If

        If Not txtPasswortNeu.Text = txtPasswortNeu2.Text Then
            MessageBox.Show("Es sind nicht beide neuen Passwörter identisch", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=EISO_PWD_CHG&user=" & System.Uri.EscapeDataString(txtBenutzername.Text) & "&pwd_alt=" & System.Uri.EscapeDataString(settings_crypt(True, txtPasswortAktuell.Text)) & "&pwd_neu=" & System.Uri.EscapeDataString(settings_crypt(True, txtPasswortNeu.Text)) & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setEiSoPasswordNeu, True) = True Then

            If frmMain.master_Message_label.Text = "PASSWORT_CHANGE" Then
                MessageBox.Show("Ihr Passwort wurde erfolgreich geändert", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Settings.yabe_pwd = settings_crypt(True, txtPasswortNeu.Text)
                My.Settings.Save()
            ElseIf frmMain.master_Message_label.Text = "PASSWORT_ALT_FALSCH"
                MessageBox.Show("Ihr aktuelles Passwort ist nicht richtig eingegeben.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Else

        End If

    End Sub
End Class