Public Class frmCMS_translate_menue
    Dim bisloading As Boolean = True
    Dim bStopp As Boolean = False
    Private Sub frmGoogleTranslate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '# Zielsprachen holen
        Call clsDatenbank_modul.getComboSprachen(cmbSprache_Artikeldatenbank)
        cmbSprache_Artikeldatenbank.SelectedIndex = 1
        bisloading = False
    End Sub

    '######################################################
    '# >> Google Übersetzung holen 
    '######################################################
    Public Function setGoogleTranslate(ByVal bMissing As Boolean) As Boolean
        Dim icount As Integer = 0
        Dim str() As String
        Dim strSprache_ISO As String
        Dim strÜbersetzung As String

        strSprache_ISO = clsDatenbank_modul.getTranslate_l18n_mapping(cmbSprache_Artikeldatenbank.Text)
        Dim strGoogleSprache As String = clsDatenbank_modul.getLanuage2GoogleCode(cmbSprache_Artikeldatenbank.Text)

        If bMissing = True Then
            Dim strQuery As String = "SELECT * FROM tbl_menue WHERE `Bezeichnung" & strSprache_ISO & "` = ''  OR `Bezeichnung" & strSprache_ISO & "` is NULL"
            clsDatenbank_modul.dbConnect.Close()
            clsDatenbank_modul.dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, clsDatenbank_modul.dbConnect)
            Dim dbReader As MySql.Data.MySqlClient.MySqlDataReader
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                Dim i As Integer = 0
                Dim iID As Integer = 0
                While Not dbReader.Read() = False
                    iID = dbReader("ID")
                    str = clsDatenbank_modul.getCMS_menuItem(iID, strSprache_ISO)
                    strÜbersetzung = frmMain.frmManage.getGoogleTranslate(str(0), strGoogleSprache)
                    clsDatenbank_modul.setCMS_menueItem_save(iID, strSprache_ISO, strÜbersetzung)

                    '# Zum Listview hinzufügen
                    Dim lvwItem As New ListViewItem
                    lvwItem.Text = str(0)
                    lvwItem.SubItems.Add(strÜbersetzung)
                    lvwItem.SubItems.Add(frmMain.frmManage.lvwMenue.Items(icount).Text)
                    Application.DoEvents()
                    lvwGoogleTranslate.Items.Add(lvwItem)
                    lvwGoogleTranslate.EnsureVisible(lvwGoogleTranslate.Items.Count - 1)

                    '# Abbruch 
                    If bStopp = True Then
                        btnStopp.Enabled = True
                        cmbSprache_Artikeldatenbank.Enabled = True
                        ToolStripStatusLabel1.Text = "Einlesen wurde gestoppt..."
                        Exit While
                    End If

                End While
            End If

            MsgBox("Alle fehlenden Übersetzungen wurden geholt", MsgBoxStyle.Information)
        Else
            '# Import und Alle Überspringen (deshalb bei 2) 
            pgrMain.Maximum = frmMain.frmManage.lvwMenue.Items.Count - 1
            pgrMain.Value = 0
            lvwGoogleTranslate.Items.Clear()

            For icount = 2 To frmMain.frmManage.lvwMenue.Items.Count - 1

                str = clsDatenbank_modul.getCMS_menuItem(frmMain.frmManage.lvwMenue.Items(icount).Text, strSprache_ISO)
                strÜbersetzung = frmMain.frmManage.getGoogleTranslate(str(0), strGoogleSprache)
                clsDatenbank_modul.setCMS_menueItem_save(frmMain.frmManage.lvwMenue.Items(icount).Text, strSprache_ISO, strÜbersetzung)

                '# Zum Listview hinzufügen
                Dim lvwItem As New ListViewItem
                lvwItem.Text = str(0)
                lvwItem.SubItems.Add(strÜbersetzung)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwMenue.Items(icount).Text)
                Application.DoEvents()
                lvwGoogleTranslate.Items.Add(lvwItem)
                lvwGoogleTranslate.EnsureVisible(lvwGoogleTranslate.Items.Count - 1)
                ToolStripStatusLabel1.Text = icount & " / " & frmMain.frmManage.lvwMenue.Items.Count - 1
                pgrMain.Value = icount
                Application.DoEvents()

                '# Abbruch 
                If bStopp = True Then
                    btnStopp.Enabled = True
                    cmbSprache_Artikeldatenbank.Enabled = True
                    ToolStripStatusLabel1.Text = "Einlesen wurde gestoppt..."
                    Exit For
                End If

            Next
        End If
     

    End Function

    Private Sub cmbSprache_Artikeldatenbank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSprache_Artikeldatenbank.SelectedIndexChanged

        If bisloading = False Then
            If MsgBox("Möchten Sie das Menü von 'Deutsch' nach '" & cmbSprache_Artikeldatenbank.Text & "' starten?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmbSprache_Artikeldatenbank.Enabled = False
                If chkOnlyMissing.Checked = True Then
                    Call setGoogleTranslate(True)
                Else
                    Call setGoogleTranslate(False)
                End If

                cmbSprache_Artikeldatenbank.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnStopp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopp.Click
        btnStopp.Enabled = False
        bStopp = True
    End Sub
End Class