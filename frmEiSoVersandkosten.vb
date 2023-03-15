Public Class frmEiSoVersandkosten
    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Private Function getSQLQuery(Optional ByVal bSuchen As Boolean = False) As String
        Dim strQuery As String = ""
        Dim strWhere As String = ""
        Try



            strQuery = "SELECT order_shippment_method_id,name_de,price,aditional_info,extra_cost FROM yabe_order_shippment_method"
            strQuery = strQuery + strWhere

            Return strQuery
        Catch ex As Exception
            Call debug_message(ex, "getSQLQuery")
            Return "-1"
        End Try
    End Function


    Private Sub frmEiSoVersandkosten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clsDatenbank_modul.setDataGrid(DataGridView1, getSQLQuery(), tblMisc, da)
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        da.Update(tblMisc.Tables(0))
    End Sub
End Class