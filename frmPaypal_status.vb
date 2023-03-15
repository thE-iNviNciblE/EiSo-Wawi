Public Class frmPaypal_status
    Public lvwDataInput As ListView

    Private Sub btnBezahlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBezahlt.Click

        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.bezahlt)
    End Sub

    Private Sub btnVerschickt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerschickt.Click
        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.verschickt)
    End Sub

    Public Function getBestellverlauf() As Boolean

        Dim strEmail As String = lvwDataInput.SelectedItems(0).SubItems(2).Text
        lblKundendata.Text = lvwDataInput.SelectedItems(0).Text
        lblPaypalSumme.Text = "Eingang: " & lvwDataInput.SelectedItems(0).SubItems(7).Text & "    Gebühren:" & lvwDataInput.SelectedItems(0).SubItems(5).Text & "    Summe: " & lvwDataInput.SelectedItems(0).SubItems(6).Text


        If lblKundendata.Text = "Bank Account" Then
            btnVor.PerformClick()
            Exit Function
        End If


        clsDatenbank_modul.getListviewData(lvwBestellverlauf, "SELECT * FROM yabe_auction_list_history WHERE email ='" & strEmail & "' OR eBay_account='" & strEmail & "' ORDER BY auction_end DESC", frmMain.frmManage.bilder_history)
        Call frmMain.frmManage.setStatusMessage(lvwBestellverlauf)


        Dim iCount As Integer = 0
        Dim dblSumme As Double = 0
        For iCount = 0 To lvwBestellverlauf.Items.Count - 1
            dblSumme += lvwBestellverlauf.Items(iCount).SubItems(2).Text
        Next
        lblEinkauf.Text = "Umsatz: " & dblSumme
    End Function
    Private Sub frmPaypal_status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call getBestellverlauf()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then


            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False
            iAnzahl -= 1
            btnVor.Enabled = True



            Try
                lvwDataInput.Items(iAnzahl).Selected = True
                lvwDataInput.Items(iAnzahl).EnsureVisible()
            Catch ex As Exception
                btnBack.Enabled = False
            End Try

            Call getBestellverlauf()

            If iAnzahl = -1 Then
                btnBack.Enabled = False
                Exit Sub
            End If

            If iAnzahl = 0 Then
                btnBack.Enabled = False
            Else
                btnBack.Enabled = True
                btnVor.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then


            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False
            iAnzahl += 1
            btnBack.Enabled = True



            Try
                lvwDataInput.Items(iAnzahl).Selected = True
                lvwDataInput.Items(iAnzahl).EnsureVisible()
            Catch ex As Exception
                btnVor.Enabled = False
            End Try



            Call getBestellverlauf()

            If iAnzahl = lvwDataInput.Items.Count - 1 Then
                btnVor.Enabled = False

            Else
                btnVor.Enabled = True
                btnBack.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        Me.Close()
    End Sub

    Private Sub SucheBestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheBestellungenToolStripMenuItem.Click

        If lvwBestellverlauf.SelectedItems.Count > 0 Then
            frmMain.frmManage.txtSuchen.Text = lvwBestellverlauf.SelectedItems(0).SubItems(10).Text
            frmMain.frmManage.tabMenue.SelectedIndex = 2
            frmMain.frmManage.btnSuchen.PerformClick()
        End If

    End Sub

    Private Sub SucheKundeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheKundeToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then
            frmMain.frmManage.txtSuchen.Text = lvwBestellverlauf.SelectedItems(0).SubItems(10).Text
            frmMain.frmManage.tabMenue.SelectedIndex = 1
            frmMain.frmManage.btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub SucheArtikelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheArtikelToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then

            If IsNumeric(lvwBestellverlauf.SelectedItems(0).Text) = True Then
                frmMain.frmManage.txtSuchen.Text = lvwBestellverlauf.SelectedItems(0).Text
            Else
                frmMain.frmManage.txtSuchen.Text = lvwBestellverlauf.SelectedItems(0).SubItems(1).Text
            End If

            frmMain.frmManage.tabMenue.SelectedIndex = 4
            frmMain.frmManage.btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub BestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestelltToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.bestellt)
    End Sub

    Private Sub BezahltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BezahltToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.bezahlt)
    End Sub

    Private Sub VerschicktToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerschicktToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.komplett)
    End Sub

    Private Sub KomplettToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KomplettToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.komplett)
    End Sub

    Private Sub StorniertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StorniertToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.storniert)
    End Sub
End Class