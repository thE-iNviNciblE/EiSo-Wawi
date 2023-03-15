Public Class frmVersandKommentar
    Public strEiSoOrderID As String = ""
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If IsNumeric(strEiSoOrderID) = True Then
            clsDatenbank_modul.setOrderKommentar(strEiSoOrderID, txtVersandKommentar.Text)
            Me.Close()
        End If

    End Sub

    Private Sub frmVersandKommentar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtVersandKommentar.Text = clsDatenbank_modul.getOrderKommentar(strEiSoOrderID)
    End Sub
End Class