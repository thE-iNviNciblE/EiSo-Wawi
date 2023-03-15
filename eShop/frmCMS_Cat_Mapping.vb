Public Class frmDelcampeIDZuweisung
    Enum bModus
        delcampe = 0
        magento = 1
    End Enum

    Enum bMultiSelect
        normal = 0
        multiselect = 1
    End Enum

    Public bModus_select As New bModus
    Public bMulti_select As New bMultiSelect
    Public lvwData_multiselect As New ListView

    Public strKategorieName As String
    Public iCMSMenueID As Integer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    '############################################################
    '# >> Selektierte einträge laden 
    '############################################################
    Private Function setSelected2Listview() As Boolean
        Dim i As Integer = 0

        lvwMultiSelect.Items.Clear()

        Try
            For i = 0 To lvwData_multiselect.SelectedItems.Count - 1
                Dim lvwItem As New ListViewItem

                lvwItem.Text = lvwData_multiselect.SelectedItems(i).Text
                lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(1).Text)
                lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(5).Text)
                lvwItem.SubItems.Add("--")
                lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(4).Text)

                lvwMultiSelect.Items.Add(lvwItem)
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frmDelcampeIDZuweisung_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmDelcampeIDZuweisung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtKategoriename.Text = strKategorieName
        Me.Text = "YABE Kategorie -> Zuordnung von Plattformen"

        Select Case bMulti_select
            Case bMultiSelect.multiselect

            Case bMultiSelect.normal

        End Select

        Select Case bModus_select
            Case bModus.delcampe
                PasswordLabel.Text = "&Delcampe Kategorie ID eingeben"
                Label1.Text = "&Delcampe Kategorie ID eingeben"
                lblMainArtikel.Text = "YABE Delcampe -> Artikel ID zuweisen"
                lblMainMenue.Text = "YABE Delcampe -> Menue ID zuweisen"
            Case bModus.magento
                PasswordLabel.Text = "&Magento Kategorie ID eingeben"
                Label1.Text = "&Magento Kategorie ID eingeben"                
                lblMainArtikel.Text = "YABE Magento -> Artikel ID zuweisen"
                lblMainMenue.Text = "YABE Magento -> Menue ID zuweisen"
        End Select

        If bMulti_select = bMultiSelect.multiselect Then
            tabMainTab.SelectedIndex = 0

            '# Selektierte Einträge übertragen
            If setSelected2Listview() = False Then
                MsgBox("Fehler bei der Übernahme der Daten in das Listview", MsgBoxStyle.Critical)
            End If

        Else
            tabMainTab.SelectedIndex = 1
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKArtikelID.Click

        Dim iCount As Integer = 0
        txtNeueID.Enabled = False
        btnOKArtikelID.Enabled = False

        Select Case bModus_select
            Case bModus.delcampe
                '# DELCAMPE Steuerung beim Speichern
                If IsNumeric(txtNeueID.Text) = False Then
                    MsgBox("Bitte nur eine Zahl eingeben", MsgBoxStyle.Critical, "YabE - Numerischer Wert erforderlich")
                Else

                    For iCount = 0 To lvwMultiSelect.Items.Count - 1


                        If clsDatenbank_modul.setCMS_item_delcampe(lvwMultiSelect.Items(iCount).Text, Convert.ToInt32(txtNeueID.Text)) = True Then
                            '   iSelected = frmMain.frmManage.lvwMenue.SelectedItems(0).Index
                            'clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue group by Parent", frmMain.frmManage.lvwMenue)
                            '    frmMain.frmManage.lvwMenue.Items(iSelected).Selected = True
                            'Me.Close()
                            'lvwMultiSelect.Items(iCount).Text = txtNeueID.Text
                            frmMain.frmManage.lvwWebArtikel.Items(frmMain.frmManage.lvwWebArtikel.SelectedItems(iCount).Index).BackColor = Color.Bisque
                        Else
                            MsgBox("Es ist ein Fehler beim abspeichern aufgetreten", MsgBoxStyle.Exclamation, "YabE - Fehler beim setzten der Delcampe ID")
                        End If

                    Next

                End If

            Case bModus.magento

                For iCount = 0 To lvwMultiSelect.Items.Count - 1
                    If clsDatenbank_modul.setCMS_item_magento(iCMSMenueID, txtNeueID.Text) = True Then
                        '    iSelected = frmMain.frmManage.lvwMenue.SelectedItems(0).Index
                        '    clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue group by Parent", frmMain.frmManage.lvwMenue)
                        '    frmMain.frmManage.lvwMenue.Items(iSelected).Selected = True

                        '    Me.Close()
                    End If
                Next

        End Select

        Me.Close()

        txtNeueID.Enabled = True
        btnOKArtikelID.Enabled = True
    End Sub

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click
        If lvwMultiSelect.SelectedItems.Count > 0 Then
            lvwMultiSelect.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub BenutzeDelcampeIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BenutzeDelcampeIDToolStripMenuItem.Click
        If lvwMultiSelect.SelectedItems.Count > 0 Then

            Select Case bModus_select
                Case bModus.delcampe
                    txtNeueID.Text = lvwMultiSelect.SelectedItems(0).SubItems(2).Text
                Case bModus.magento
                    txtNeueID.Text = lvwMultiSelect.SelectedItems(0).SubItems(4).Text
            End Select

        End If


    End Sub

    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim iSelected As Integer = 0


        Select Case bModus_select
            Case bModus.delcampe
                '# DELCAMPE Steuerung beim Speichern
                If IsNumeric(txtDelcampeID.Text) = False Then
                    MsgBox("Bitte nur eine Zahl eingeben", MsgBoxStyle.Critical, "YabE - Numerischer Wert erforderlich")
                Else
                    If clsDatenbank_modul.setCMS_menue_delcampe(iCMSMenueID, Convert.ToInt32(txtDelcampeID.Text)) = True Then
                        iSelected = frmMain.frmManage.lvwMenue.SelectedItems(0).Index
                        'clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue group by Parent", frmMain.frmManage.lvwMenue, frmMain.frmManage.cmbSprache_Artikeldatenbank.Text)
                        clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", frmMain.frmManage.lvwMenue, frmMain.frmManage.cmbSprache_Artikeldatenbank.Text)
                        Try
                            frmMain.frmManage.lvwMenue.Items(iSelected).Selected = True
                            frmMain.frmManage.lvwMenue.EnsureVisible(iSelected)
                        Catch ex As Exception

                        End Try

                        Me.Close()
                    Else
                        MsgBox("Es ist ein Fehler beim abspeichern aufgetreten", MsgBoxStyle.Exclamation, "YabE - Fehler beim setzten der Delcampe ID")
                    End If

                End If

            Case bModus.magento
                If clsDatenbank_modul.setCMS_menue_magento(iCMSMenueID, txtDelcampeID.Text) = True Then
                    iSelected = frmMain.frmManage.lvwMenue.SelectedItems(0).Index
                    'clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue group by Parent", frmMain.frmManage.lvwMenue, frmMain.frmManage.cmbSprache_Artikeldatenbank.Text)
                    clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", frmMain.frmManage.lvwMenue, frmMain.frmManage.cmbSprache_Artikeldatenbank.Text)

                    frmMain.frmManage.lvwMenue.Items(iSelected).Selected = True
                    frmMain.frmManage.lvwMenue.EnsureVisible(iSelected)
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub lvwMultiSelect_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMultiSelect.ColumnClick
        Try
            Call frmMain.frmManage.setSort(lvwMultiSelect, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnKategorieEdotir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKategorieEdotir.Click

        Dim frmCat As New frmDelcampe_Category_editor        
        frmCat.ShowDialog(Me)
        txtNeueID.Text = frmCat.strSelectedCat
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub txtNeueID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNeueID.TextChanged
        If txtNeueID.Text.Length > 0 Then
            btnOKArtikelID.Enabled = True
        Else
            btnOKArtikelID.Enabled = False
        End If
    End Sub
End Class
