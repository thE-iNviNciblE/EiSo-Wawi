Public Class frmPreisanalyse
    Public strTitel As String = ""
    Public strPreis As String = ""
    Public strSKU As String = ""
    Public strID As String = ""

    Private Sub btnStartPreisvergleich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartPreisvergleich.Click

        Select Case cmbPreisanbieter.Text
            Case "Idealo"
                wbVergleich.Navigate("")
        End Select

    End Sub

    Private Sub frmPreisanalyse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMagentoPreis.Text = strPreis
        txtMagentoTitel.Text = strTitel
        cmbPreisanbieter.SelectedIndex = 0
    End Sub

    Private Sub wbVergleich_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wbVergleich.DocumentCompleted

        Select Case cmbPreisanbieter.Text
            Case "Idealo"
                Call getIdealoSource(lvwPreisData)
        End Select
    End Sub

    Private Function getIdealoSource(ByVal lvw As ListView) As Boolean



    End Function
End Class