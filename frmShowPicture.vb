Public Class frmShowPicture
    Public strURL As String
    Public strYABE_ID As String
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub frmShowPicture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If strYABE_ID.Length > 0 Then
            Dim strYABEID() As String = strYABE_ID.Split("-")

            Dim strBild As String = clsDatenbank_modul.getCMS_ShopItems("Bild", strYABEID(0))

            WebBrowser1.Navigate(strBild)
        Else
            WebBrowser1.Navigate(strURL)
        End If
    End Sub
End Class