Public Class frmCMS_ShopImporter

    Public Enum modus
        delcampe = 0
        ebay = 1
    End Enum

    Public mModus As New modus

    Private Sub btnSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuchen.Click

        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            '# Importer Klasse laden
            Dim import As New clsImporter
            import.pgrBar = ProgressBar1
            import.strFile = OpenFileDialog1.FileName

            btnSuchen.Enabled = False
            btnSave.Enabled = False

            If roeBay.Checked = True Then
                If import.getImportFile(lvwImporter, clsImporter.Importmodus.ebay) = True Then
                    MsgBox("Es wurden alle Artikel importiert")
                End If
            ElseIf roDelcampeImport.Checked = True Then
                If import.getImportFile(lvwImporter, clsImporter.Importmodus.delcampe) = True Then
                    MsgBox("Es wurden alle Artikel importiert")
                End If
            End If
            btnSuchen.Enabled = True
            btnSave.Enabled = True
        End If
    End Sub


    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click

        If lvwImporter.SelectedItems.Count > 0 Then

            lvwImporter.SelectedItems(0).Remove()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim iCount As Integer = 0
        Dim strQuery As String = ""

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = lvwImporter.Items.Count - 1
        ProgressBar1.Visible = True
        btnSuchen.Enabled = False
        btnSave.Enabled = False

        For iCount = 0 To lvwImporter.Items.Count - 1

            '# Speichern der Artikel in Datenbank 
            strQuery = clsDatenbank_modul.setInsert_Update_tLvw2SQL(lvwImporter.Items(iCount), "lvwImporter", "ADD")

            Application.DoEvents()
            Dim dbConnect_con As New MySql.Data.MySqlClient.MySqlConnection(clsDatenbank_modul.dbConnect.ConnectionString)
            'dbConnect_con.Close()
            dbConnect_con.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect_con)
            command.ExecuteNonQuery()
            dbConnect_con.Close()
            toolMain.Text = lvwImporter.Items(iCount).Text
            ProgressBar1.Value = iCount
        Next

        ProgressBar1.Visible = False
        btnSuchen.Enabled = True
        btnSave.Enabled = True
        MsgBox("Die Artikel wurden erfolgreich in die Liste der importierten Artikel übertragen", MsgBoxStyle.Information)


    End Sub

    Private Sub frmShopImporter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case mModus
            Case modus.ebay
                roeBay.Checked = True
            Case modus.delcampe
                roDelcampeImport.Checked = True
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class