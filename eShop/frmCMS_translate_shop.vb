Public Class frmCMS_translate_shop
    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim bisLoading As Boolean = True

    Private Function getSQLQuery(Optional ByVal bSuchen As Boolean = False) As String
        Dim strQuery As String = ""
        Dim strWhere As String = ""
        Try

            '# Sprachauswahl Laden 
            If cmbSprache_Artikeldatenbank.Text.Contains("Alle") = True Or cmbSprache_Artikeldatenbank.Text = "" Then
                strQuery = "SELECT ID,Inhalt,Inhalt_eng,Inhalt_fr FROM tbl_misc_Texte"
            Else
                Dim strISO As String = clsDatenbank_modul.getTranslate_l18n_mapping(cmbSprache_Artikeldatenbank.Text)
                strQuery = "SELECT ID,Inhalt,Inhalt" + strISO + " FROM tbl_misc_Texte"
            End If

            '# Keine Suche 
            If bSuchen = False Then

                If cmbShopCategory.Text.Contains("Alle") = True Or cmbShopCategory.Text = "" Then
                    strWhere = ""
                Else
                    strWhere = " WHERE Bereich='" + cmbShopCategory.Text + "'"
                End If

            Else ' Suchmodus aktiv 
                strWhere = " WHERE Inhalt LIKE '%" + txtSuchen.Text + "%' OR Inhalt_eng LIKE '%" + txtSuchen.Text + "%' OR Inhalt_fr LIKE '%" + txtSuchen.Text + "%'"
            End If

            strQuery = strQuery + strWhere

            Return strQuery
        Catch ex As Exception
            Call debug_message(ex, "getSQLQuery")
            Return "-1"
        End Try
    End Function

    Private Sub frmShopStringTranslator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '# Alle Sprachen holen

        Call clsDatenbank_modul.getComboShopGroups(cmbShopCategory)
        cmbShopCategory.Items.Add("Alle")
        bisLoading = False

        Call clsDatenbank_modul.getComboSprachen(cmbSprache_Artikeldatenbank)
        cmbSprache_Artikeldatenbank.Items.Add("Alle")
        cmbSprache_Artikeldatenbank.SelectedIndex = 1

        'Call clsDatenbank_modul.setDataGrid(DataGridView1, getSQLQuery(), tblMisc, da)
    End Sub

    Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click

        da.Update(tblMisc.Tables(0))

    End Sub

    Private Sub cmbSprache_Artikeldatenbank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSprache_Artikeldatenbank.SelectedIndexChanged
        If bisLoading = False Then
            Call clsDatenbank_modul.setDataGrid(DataGridView1, getSQLQuery(), tblMisc, da)
        End If

    End Sub

    Private Sub cmbShopCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShopCategory.SelectedIndexChanged

        If bisLoading = False Then
            Call clsDatenbank_modul.setDataGrid(DataGridView1, getSQLQuery(), tblMisc, da)
        End If

    End Sub

    Private Sub txtSuchen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuchen.GotFocus
        If txtSuchen.Text = "Suchbegriff..." Then
            txtSuchen.Text = ""
        End If
    End Sub

    Private Sub txtSuchen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSuchen.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub txtSuchen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuchen.LostFocus
        If txtSuchen.Text = "" Then
            txtSuchen.Text = "Suchbegriff..."
        End If
    End Sub


    Private Sub btnSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuchen.Click
        Call clsDatenbank_modul.setDataGrid(DataGridView1, getSQLQuery(True), tblMisc, da)
    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick

    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.SelectedCells.Count > 0 Then

            If DataGridView1.SelectedCells(0).ColumnIndex = 1 Then
                Try
                    txtQuelle.Text = DataGridView1.SelectedCells(0).Value
                    txtZiel.Text = DataGridView1.Item(cmbSprache_Artikeldatenbank.SelectedIndex + 1, DataGridView1.SelectedCells(0).RowIndex).Value
                Catch ex As Exception
                    txtQuelle.Text = ""
                End Try

            ElseIf DataGridView1.SelectedCells(0).ColumnIndex = 2 Then
                Try
                    txtZiel.Text = DataGridView1.SelectedCells(0).Value
                    txtQuelle.Text = DataGridView1.Item(1, DataGridView1.SelectedCells(0).RowIndex).Value
                Catch ex As Exception
                    txtZiel.Text = ""
                End Try
            ElseIf DataGridView1.SelectedCells(0).ColumnIndex = 3 Then
                Try
                    txtZiel.Text = DataGridView1.SelectedCells(0).Value
                    txtQuelle.Text = DataGridView1.Item(1, DataGridView1.SelectedCells(0).RowIndex).Value
                Catch ex As Exception
                    txtZiel.Text = ""
                End Try
            End If


        End If
    End Sub

    Private Sub txtQuelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuelle.TextChanged

        If DataGridView1.SelectedCells.Count > 0 Then

            If DataGridView1.SelectedCells(0).ColumnIndex = 1 Then
                Try
                    DataGridView1.SelectedCells(0).Value = txtQuelle.Text
                Catch ex As Exception
                    txtQuelle.Text = ""
                End Try

            ElseIf DataGridView1.SelectedCells(0).ColumnIndex = 2 Then
                Try
                    DataGridView1.SelectedCells(0).Value = txtZiel.Text

                Catch ex As Exception
                    txtZiel.Text = ""
                End Try
            ElseIf DataGridView1.SelectedCells(0).ColumnIndex = 3 Then
                Try
                    DataGridView1.SelectedCells(0).Value = txtZiel.Text
                Catch ex As Exception
                    txtZiel.Text = ""
                End Try

            End If


        End If

    End Sub

    Private Sub txtZiel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZiel.TextChanged

    End Sub

    Private Sub txtQuelle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuelle.KeyDown

        If e.KeyCode = Keys.F5 Then
            txtQuelle.Enabled = False
            txtZiel.Enabled = False
            Dim strGoogleSprache As String = clsDatenbank_modul.getLanuage2GoogleCode(cmbSprache_Artikeldatenbank.Text)
            txtZiel.Text = getTranslateText(txtQuelle.Text, "de", strGoogleSprache)
            txtQuelle.Enabled = True
            txtZiel.Enabled = True
        End If

    End Sub
End Class