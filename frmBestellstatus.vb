Public Class frmBestellstatus
    Public bSendMail As Boolean = False
    Public bWebshopLöschen As Boolean = False
    Public strStatus As String = ""
    Public lvw As New ListView
    Public lvw_kunden As New ListView

    Public bOK As Boolean = False
    Public lvwSelected As Boolean = True

    Private Sub chkWebshopLöschen_CheckedChanged(sender As Object, e As EventArgs) Handles chkWebshopLöschen.CheckedChanged
        bWebshopLöschen = chkWebshopLöschen.Checked
    End Sub

    Private Sub chkEmailSenden_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmailSenden.CheckedChanged
        bSendMail = chkEmailSenden.Checked
    End Sub

    Private Sub frmBestellstatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = strStatus

        Dim i As Integer = 0
        If lvwSelected = True Then
            For i = 0 To lvw.SelectedItems.Count - 1
                lvwBestellungen_bestelliste_neu.Items.Add(lvw.SelectedItems(i).Clone())

                If Not lvw.Name = "lvwBestellverwaltung_nach_artikel" Then
                    If i = 0 Then
                        lvwBestellungen_bestelliste_neu.Items(i).SubItems(24).Text = lvw_kunden.SelectedItems(0).SubItems(15).Text
                    Else
                        lvwBestellungen_bestelliste_neu.Items(i - 1).SubItems(24).Text = lvw_kunden.SelectedItems(0).SubItems(15).Text
                    End If

                End If


            Next

        End If

        '   lvwBestellungen_bestelliste_neu.Items.AddRange(lvw.Items)
    End Sub

    Private Sub btnBestellstatusChange_Click(sender As Object, e As EventArgs) Handles btnBestellstatusChange.Click
        bOK = True
        Me.Close()
    End Sub
End Class