Imports System.Windows.Forms

Public Class frmYABE_Center_Events

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    '####################################################
    '# >> Items laden 
    '####################################################
    Private Function getItems() As Boolean

        Me.ListView1.Items.Clear()
        Dim i As Integer = 0
        Dim iArtikel As Integer = 0
        Dim iGebote As Integer = 0
        Dim dblSumme As Double

        For i = 0 To frmMain.frmManage.lvwEiSoCockpit.Items.Count - 1
            Dim listparams(4) As String

            listparams(0) = frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(0).Text
            listparams(1) = frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(2).Text
            listparams(2) = frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(1).Text
            listparams(3) = frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(5).Text
            listparams(4) = frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(4).Text

            If Convert.ToInt16(frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(4).Text) > 0 Then
                dblSumme += Convert.ToDouble(frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(2).Text)
                iGebote += Convert.ToInt16(frmMain.frmManage.lvwEiSoCockpit.Items(i).SubItems(4).Text)
                iArtikel += 1
            End If

            Dim vi As ListViewItem = New ListViewItem(listparams)
            Me.ListView1.Items.Add(vi)
        Next


        lblInfopanel.Text = "Umsatz: " & dblSumme & " Euro " & vbCrLf & "Verkaufte Artikel: " & iArtikel & vbCrLf & "Gebote: " & iGebote

        Return True
    End Function

    Private Sub frmMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call getItems()
    End Sub

    Private Sub CopyEBayIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyEBayIDToolStripMenuItem.Click

        If ListView1.SelectedItems.Count > 0 Then
            Clipboard.SetText(ListView1.SelectedItems(0).SubItems(1).Text)
        End If

    End Sub

    Private Sub Copy_Beschreibung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_Beschreibung.Click
        If ListView1.SelectedItems.Count > 0 Then
            Clipboard.SetText(ListView1.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub LiveÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiveÖffnenToolStripMenuItem.Click

        Try
            '# 
            If ListView1.SelectedItems.Count > 0 Then
                Dim ExterneAnwendung As New System.Diagnostics.Process()
                ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & ListView1.SelectedItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
                ExterneAnwendung.Start()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkBidsOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBidsOnly.CheckedChanged
        If chkBidsOnly.Checked = True Then
            frmMain.frmManage.chkGebote.Checked = True
            Call getItems()
        Else
            frmMain.frmManage.chkGebote.Checked = False
            Call getItems()
        End If
    End Sub
End Class
