Public Class frmDemoVersion
    Dim bNotEnde As Boolean = False


    Private Sub frmDemoVersion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing        
        e.Cancel = bNotEnde
    End Sub

    Private Sub frmDemoVersion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim strResult As String = ""



        Dim strServerInfo() As String = getHTTPResponseMessage_updater("https://api.bludau-media.de/SafeSandy/fetchAuth.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode), mgetUpdaterMessage_updater.getAuthCode, True)

        If strServerInfo(0) = "ADD_AUTHCODE" Then

            Dim strServerInfo2() As String = getHTTPResponseMessage_updater("https://api.bludau-media.de/SafeSandy/SendAuthCode.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&programID=2&programname=EiSo Auktionsabwicklung&demoende=" & Date.Now.AddDays(15), mgetUpdaterMessage_updater.getAuthCode, True)
            'MessageBox.Show(strServerInfo2(0))
            strServerInfo = getHTTPResponseMessage_updater("https://api.bludau-media.de/SafeSandy/fetchAuth.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode), mgetUpdaterMessage_updater.getAuthCode, True)
        End If

        '######################################
        '# mgetUpdaterMessage.getAuthCode
        '######################################
        ' 0: Produktname
        ' 1: Authcode
        ' 2: installiert am
        ' 3: Demo Ende Datum
        ' 4: gekauft
        ' 5: gekauft datum
        ' 6: KundenID

        pgrTage.Value = 0


        '# Fortschritt anzeigen
        Dim strInstalliertam() As String = strServerInfo(2).Split("=")
        Dim dInstalliert As DateTime = getDateTimeVar(strInstalliertam(1))
        lblInstallDatum.Text = "Installiert am: " & dInstalliert.Date

        '# DEMO ABGELAUFEN
        Dim strDemoEnde() As String = strServerInfo(3).Split("=")
        Dim dDemoEnde As DateTime = getDateTimeVar(strDemoEnde(1))
        lblDemoEnde.Text = "Demoversion endet am: " & dDemoEnde.Date

        pgrTage.Maximum = dDemoEnde.Date.Subtract(dInstalliert.Date).Days
        'MessageBox.Show(dDemoEnde.Date.Subtract(Date.Now.Date).Days)
        Dim str As String = ""
        If dDemoEnde < Date.Now Then
            strResult = "DEMO ABGELAUFEN"
            Dim strProgrammName() As String = strServerInfo(0).Split("=")
            lblMainMessage.Text = "IHR DEMO VERSION VON " & strProgrammName(1).ToUpper & " IST ABGELAUFEN!" & vbCrLf & vbCrLf & "Bitte Registrieren Sie Ihre Software jetzt um weiter damit arbeiten zu können" & vbCrLf & vbCrLf & "Mit freundlichen Grüßen Jan Bludau (cubss)"
            pgrTage.Value = pgrTage.Maximum
            str = "DEMO ABGELAUFEN"
        Else
            pgrTage.Value = pgrTage.Maximum - dDemoEnde.Date.Subtract(Date.Now.Date).Days
            str = "DEMO LÄUFT"
        End If

        setBludauMediaLogbuch(str & "DEMO - " & lblInstallDatum.Text & " bis " & lblDemoEnde.Text, "DEMO")


        If strResult = "DEMO ABGELAUFEN" Then
            btnProgrammRegister.BackColor = Color.PapayaWhip
            btnProgrammStart.Enabled = False
            bNotEnde = True
        End If
    End Sub

    Private Sub btnProgrammStart_Click(sender As System.Object, e As System.EventArgs) Handles btnProgrammStart.Click
        If bRegistered = True Then
            bNotEnde = False
        End If
        Me.Close()
    End Sub

    Private Sub btnProgrammRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnProgrammRegister.Click
        Dim frmDemoRegister As New frmDemoVersionRegistrieren
        frmDemoRegister.ShowDialog()
        If bRegistered = True Then
            btnProgrammStart.Enabled = True
            btnProgrammRegister.Enabled = False
            lblMainMessage.Text = "Vielen Dank für die Registrierung von EiSo Verkaufsabwicklung" & vbCrLf & "Version: " & gbl_KeyCode & vbCrLf & vbCrLf & "Sie können EiSo  " & strVersionString & " Auktionsabwicklung jetzt uneingeschränkt nutzen"
        End If
    End Sub
 
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnProgrammEnde.Click
        bNotEnde = False
        bExitProgramm = True
        Me.Close()
    End Sub
End Class