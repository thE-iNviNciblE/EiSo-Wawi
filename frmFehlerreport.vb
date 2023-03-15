Public Class frmFehlerreport
    Public strMessage As String

    Private Sub btnProgrammreport_email_Click(sender As Object, e As EventArgs) Handles btnProgrammreport_email.Click

        Dim clsDebug As New clsEmail
        If My.Settings.email_pwd.Length > 0 Then
            clsDebug.setSendDebugReport("EiSo " & strVersionString & " / " & My.Settings.yabe_username & " - Fehlerbericht: Nr." & My.Settings.developer_crashcount, Application.StartupPath & "\LOG")
        End If

    End Sub

    Private Sub btnProgramm_neustarten_Click(sender As Object, e As EventArgs) Handles btnProgramm_neustarten.Click
        End
    End Sub

    Private Sub frmFehlerreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblError.Text = strMessage

    End Sub

    Private Sub btnWeitermachen_Click(sender As Object, e As EventArgs) Handles btnWeitermachen.Click
        bCrashReport = True
        Me.Close()
    End Sub
End Class