Public Class frmCMS_search_replace

    Public lvwData_multiselect As New ListView
    Public lvwData_cache As ListView

    '###############################################################
    '# >> Daten die Selektiert sind übernehmen 
    '###############################################################
    Private Function setSelected2Listview() As Boolean
        Dim i As Integer = 0
        Try
            lvwMultiSelect.Items.Clear()
            lvwMultiSelect.BeginUpdate()

            For i = 0 To lvwData_multiselect.SelectedItems.Count - 1
                Dim lvwItem As New ListViewItem

                lvwItem.Text = lvwData_multiselect.SelectedItems(i).Text
                lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(1).Text)
                lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(5).Text)
                lvwItem.SubItems.Add("--")
                lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(4).Text)

                lvwMultiSelect.Items.Add(lvwItem)
                Application.DoEvents()
                frmMain.master_Message_label.Text = i & " von " & lvwData_multiselect.Items.Count - 1

            Next

            lvwData_cache = lvwMultiSelect
            lvwMultiSelect.EndUpdate()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '##########################################################
    '# >> setMarkColor
    '##########################################################
    Private Function setMarkColor(ByVal strSuchen As String) As Boolean
        Try
            Dim iCount As Integer = 0
            Dim iGefunden As Integer = 0

            lvwMultiSelect.BeginUpdate()

            For iCount = 0 To lvwMultiSelect.Items.Count - 1


                If lvwMultiSelect.Items(iCount).SubItems(1).Text.Contains(strSuchen) = True Then
                    Application.DoEvents()
                    lvwMultiSelect.Items(iCount).BackColor = Color.Moccasin
                    iGefunden += 1
                Else
                    lvwMultiSelect.Items(iCount).BackColor = Color.WhiteSmoke
                End If

            Next

            lvwMultiSelect.EndUpdate()

            Me.StatusStrip1.Items(0).Text = iGefunden & " makiert von " & lvwMultiSelect.Items.Count

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setMarkColor")
            Return False
        End Try
    End Function
    Private Sub frmCMS_search_replace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setSelected2Listview()
        txtSuchen.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    '##########################################################################################################
    '# >> setSearchReplace 
    '##########################################################################################################
    Private Function setSearchReplace(ByVal strSuche As String, ByVal strErsetzten As String) As Boolean
        Try
            Dim iCount As Integer = 0

            '# Alle Einträge durchlaufen 
            For iCount = 0 To lvwMultiSelect.Items.Count - 1

                Application.DoEvents()
                lvwMultiSelect.Items(iCount).Selected = True
                lvwMultiSelect.Items(iCount).SubItems(1).Text = lvwMultiSelect.Items(iCount).SubItems(1).Text.Replace(strSuche, strErsetzten)

            Next iCount

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setSearchReplace")
            Return False
        End Try
    End Function

    Private Sub chkLiveAlle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVorschau.CheckedChanged
        If chkVorschau.Checked = True Then

            '# Prüfungen ob Daten vorhanden 
            If txtSuchen.Text.Length = 0 Then
                txtSuchen.Focus()
                Exit Sub
            End If

            If txtErsetzen.Text.Length = 0 Then
                txtErsetzen.Focus()
                Exit Sub
            End If
            Call setMarkColor(txtSuchen.Text)

            '# Suchen und ersetzen einleiten 
            If setSearchReplace(txtSuchen.Text, txtErsetzen.Text) = True Then
                btnOKSearchReplace.Enabled = True
            Else
                MsgBox("Es gab einen Fehler beim Suchen ersetzten! - Daten dürfen nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            End If

        Else
            If setSearchReplace(txtErsetzen.Text, txtSuchen.Text) = True Then

            End If
            Call setMarkColor(txtSuchen.Text)
            btnOKSearchReplace.Enabled = False
        End If

    End Sub

    Private Sub txtSuchen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuchen.LostFocus
        '# Farbiges Markieren beim Suchen 
        If txtSuchen.Text.Length > 0 Then
            Call setMarkColor(txtSuchen.Text)
        End If
    End Sub

 

    Private Sub frmCMS_search_replace_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    '########################################################
    '# >> Alle durchgehen 
    '########################################################
    Private Function setUpdateLvwData() As Boolean
        Try
            Dim iCount As Integer = 0


            For iCount = 0 To lvwMultiSelect.Items.Count - 1

                '# Nur Änderungen übertragen 
                If lvwMultiSelect.Items(iCount).BackColor = Color.Moccasin Then
                    If clsDatenbank_modul.setWebArtikel_update_replace(frmMain.frmManage.cmbSprache_Artikeldatenbank.Text, lvwMultiSelect.Items(iCount).Text, lvwMultiSelect.Items(iCount).SubItems(1).Text) = False Then
                        MsgBox("Fehler beim Abspeichern der Ansicht", MsgBoxStyle.Exclamation, "Fehler beim Speichern...")
                    End If
                End If

            Next iCount

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setUpdateLVWData")
            Return False
        End Try
    End Function

    Private Sub btnOKSearchReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKSearchReplace.Click

        If txtErsetzen.Text.Length > 0 And txtSuchen.Text.Length > 0 Then
            Call setUpdateLvwData()
        End If

    End Sub

    Private Sub DelcampeKategorieIDZuweisenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeKategorieIDZuweisenToolStripMenuItem1.Click

        If lvwData_multiselect.SelectedItems.Count > 0 Then
            Dim frmDialog As New frmDelcampeIDZuweisung
            frmDialog.bModus_select = frmDelcampeIDZuweisung.bModus.delcampe
            frmDialog.bMulti_select = frmDelcampeIDZuweisung.bMultiSelect.multiselect
            frmDialog.iCMSMenueID = lvwData_multiselect.SelectedItems(0).Text
            'frmDialog.strKategorieName = lvwMenue.SelectedItems(0).SubItems(1).Text
            frmDialog.lvwData_multiselect = lvwData_multiselect
            frmDialog.txtDelcampeID.Text = lvwData_multiselect.SelectedItems(0).SubItems(5).Text
            frmDialog.Show(Me)
        Else
            MessageBox.Show("Bitte eine Kategorie auswählen im Kategorie links", "YABE Kategorie auswählen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class