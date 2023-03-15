Public Class frmEiSoLoginPasswortvergessen
    Public strEmail As String = ""

    Private Sub frmEiSoLoginPasswortvergessen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If strEmail.Length > 0 Then
            txtEmailadresse.Text = strEmail
        End If
    End Sub

    Private Sub btnPasswortLost_Click(sender As Object, e As EventArgs) Handles btnPasswortLost.Click

        If txtEmailadresse.Text.Length = 0 Then
            MessageBox.Show("Bitte Ihre bei EiSo hinterlegte Emailadresse eintragen...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmailadresse.Focus()
            Exit Sub
        End If

        If txtEmailadresse.Text.Contains("@") = False Then
            MessageBox.Show("Bitte eine gültige Emailadresse mit @ eingeben", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmailadresse.Focus()
            Exit Sub
        End If

        If getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=EISO_PWD_LOST&email=" & System.Uri.EscapeDataString(txtEmailadresse.Text) & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.getEiSoPassword, True) = True Then

            If frmMain.master_Message_label.Text = "ALLES_OK" Then
                MessageBox.Show("Es wurden die Zugangsdaten an Ihre Email Adresse geschickt.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Es wurden die Zugangsdaten NICHT an Ihre Email Adresse geschickt.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Else

        End If

    End Sub
End Class