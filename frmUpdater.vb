Public Class frmUpdater

    Private Sub frmUpdater_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        frmMain.setMainWindowTitle("Programm Aktuallisierung", Me)

        Dim strServerInfo() As String = getHTTPResponseMessage_updater("https://api.bludau-media.de/SafeSandy/Update.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&programID=2&versionsnummer=" & strVersionsNummer, mgetUpdaterMessage_updater.getProgramUpdateCheck, True)

        If strServerInfo(0) = "VERSION_AKTUELL" Then
            lblUpdateMessage.Text = "Sie besitzten bereits die aktuellste Version!" & vbCrLf & strServerInfo(3).Replace("br/>", vbCrLf) & " " & strServerInfo(2).Replace("br/>", vbCrLf) & vbCrLf & strServerInfo(4).Replace("br/>", vbCrLf)
        Else


            lblUpdateMessage.Text = "NEUE VERSION VERFÜGBAR!" & vbCrLf & strServerInfo(3).Replace("br/>", vbCrLf) & " " & strServerInfo(2).Replace("br/>", vbCrLf) & vbCrLf & strServerInfo(4).Replace("br/>", vbCrLf) & vbCrLf & strServerInfo(5).Replace("br/>", vbCrLf)
        End If


    End Sub
 
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnDownload_Click(sender As System.Object, e As System.EventArgs) Handles btnDownload.Click

        If MessageBox.Show("Möchten Sie das Update von EiSo Auktionsabwicklung jetzt installieren?", "EiSo Auktionsabwicklung Update Installation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call setUpdateCheck(pgrUpdate, lblUpdater)

        End If

    End Sub
 
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "http://updater.cubss.net/software-download.php?programID=2&name=EiSo%20Auktionsabwicklung"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
    End Sub
End Class