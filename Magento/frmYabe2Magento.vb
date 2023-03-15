Public Class frmYabe2Magento

    Dim mc As New clsMagentoAPI
    Dim bStop As Boolean = True

    '#############################################################
    '# >> Magento Import 
    '#############################################################
    Private Function setNewMagentoItems(ByVal lvwWebArtikel As ListView) As Boolean
        Try

            Dim iLoop As Integer = 0

            '# Alle Artikel holen 
            pgrStatus.Minimum = 0
            pgrStatus.Maximum = lvwWebArtikel.Items.Count - 1
            pgrStatus.Value = 0

            If lvwWebArtikel.SelectedItems.Count = 0 Then
                lvwWebArtikel.Items(0).Selected = True
            End If

            Dim iProduktID As Integer

            For iLoop = lvwWebArtikel.SelectedItems(0).Index To lvwWebArtikel.Items.Count - 1
                pgrStatus.Value += 1
                '# 0 - Gewicht
                '# 1 - Steuerklasse (ID)
                '# 2 - Preis  (0.0)
                '# 3 - Kurzbeschreibung
                '# 4 - Lange Beschreibung
                '# 5 - Name
                '# 6 - Status (ID)
                '# 7 - Sichtbarkeit (ID)
                '# 8 - URL - KEY (Name) 
                '# 9 - Attributset (ID)
                '# 10 - SKU 

                If bStop = True Then
                    Exit For
                End If

                Dim arryList As New ArrayList
                arryList.Add("0.0") ' Gewicht
                arryList.Add("1") ' Steuerklasse 
                arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(2).Text) ' Preis
                arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text) ' Kurzbeschreibung
                arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text) ' Lange Beschreibung

                If lvwWebArtikel.Items(iLoop).SubItems(1).Text.Length > 40 Then
                    arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text.Substring(0, 40)) ' Name
                End If

                arryList.Add(cmbStatus.SelectedIndex + 1) ' Status (Aktiv)
                arryList.Add(cmbSichtbarkeit.SelectedIndex + 1) ' Sichtbarkeit (4 = Katalog, Suche)
                arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text) ' URL KEY 
                arryList.Add(24) ' Atributset
                arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(0).Text) ' 10. SKU 
                arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(4).Text) ' Kategorien
                ToolStripStatusLabel1.Text = iLoop + 1 & " / " & lvwWebArtikel.Items.Count - 1 & lvwWebArtikel.Items(iLoop).SubItems(1).Text
                lvwWebArtikel.Items(iLoop).Selected = True
                lvwWebArtikel.Items(iLoop).EnsureVisible()

                Application.DoEvents()
                '# Einzelnen Artikel hinzufügen 
                Try
                    iProduktID = mc.setItemNew(arryList)
                    If iProduktID = -1 Then
                        'MsgBox("Session abgelaufen, bitte neu einloggen")
                        ' Exit For
                    End If

                    '# Bild hochladen
                    Call mc.setNewImage(lvwWebArtikel.Items(iLoop).SubItems(0).Text, lvwWebArtikel.Items(iLoop).SubItems(3).Text)

                Catch ex As Exception
                    ToolStripStatusLabel1.Text = ex.Message
                End Try
               
            Next

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setNewMagentoItems")
            Return False
        End Try
    End Function

    Private Sub btnImport2Magento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport2Magento.Click

        If bStop = True Then
            '# Einloggen 
            bStop = False
            btnImport2Magento.Text = "Import stoppen..."
            Call mc.getLogin()
            Call setNewMagentoItems(lvwWebArtikel)


        Else
            btnImport2Magento.Text = "Import starten..."
            bStop = True
        End If

    End Sub

    Private Sub frmYabe2Magento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '# Menü abrufen
        If clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", lvwMenue, frmMain.frmManage.cmbSprache_Artikeldatenbank.Text) = False Then
            MsgBox("Fehler beim abrufen der Kategorieliste", MsgBoxStyle.Critical)
        End If

        '# Attributliste Laden 
        'mc.getAttributList(cmbAttributset)
    End Sub

    Private Sub lvwMenue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMenue.SelectedIndexChanged
        Dim iDelcampeID As Integer = 0
        Dim strHauptkategorie As String = ""
        Dim iId As Integer = 0

        If lvwMenue.SelectedItems.Count > 0 Then

            iDelcampeID = lvwMenue.SelectedItems(0).SubItems(3).Text
            strHauptkategorie = lvwMenue.SelectedItems(0).SubItems(5).Text
            iId = lvwMenue.SelectedItems(0).SubItems(0).Text
            txtMagentoKategorien.Text = lvwMenue.SelectedItems(0).SubItems(4).Text
            cmbSichtbarkeit.SelectedIndex = 3
            cmbStatus.SelectedIndex = 0

            Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Kategorie_neo='" & iId & "' AND bestellt=0 ORDER BY Datum DESC", lvwWebArtikel, lvwMenue, iDelcampeID, strHauptkategorie, , lvwMenue.SelectedItems(0).SubItems(6).Text, frmMain.frmManage.bilder_history)
        End If

    End Sub

    Private Sub btnThread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThread.Click
        Dim tobj1 As New clsMagento_thread()
        Dim iLoop = 0

        '# 0 - Gewicht
        '# 1 - Steuerklasse (ID)
        '# 2 - Preis  (0.0)
        '# 3 - Kurzbeschreibung
        '# 4 - Lange Beschreibung
        '# 5 - Name
        '# 6 - Status (ID)
        '# 7 - Sichtbarkeit (ID)
        '# 8 - URL - KEY (Name) 
        '# 9 - Attributset (ID)
        '# 10 - SKU 
        '# Alle Artikel holen 
        pgrStatus.Minimum = 0
        pgrStatus.Maximum = lvwWebArtikel.Items.Count - 1
        pgrStatus.Value = 0

        If lvwWebArtikel.SelectedItems.Count = 0 Then
            lvwWebArtikel.Items(0).Selected = True
        End If

        Dim iProduktID As Integer

        For iLoop = lvwWebArtikel.SelectedItems(0).Index To lvwWebArtikel.Items.Count - 1


            pgrStatus.Value += 1
            Dim arryList As New ArrayList
            arryList.Add("0.0") ' Gewicht
            arryList.Add("1") ' Steuerklasse 
            arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(2).Text) ' Preis
            arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text) ' Kurzbeschreibung
            arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text) ' Lange Beschreibung

            If lvwWebArtikel.Items(iLoop).SubItems(1).Text.Length > 40 Then
                arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text.Substring(0, 40)) ' Name
            End If

            arryList.Add(cmbStatus.SelectedIndex + 1) ' Status (Aktiv)
            arryList.Add(cmbSichtbarkeit.SelectedIndex + 1) ' Sichtbarkeit (4 = Katalog, Suche)
            arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(1).Text) ' URL KEY 
            arryList.Add(24) ' Atributset
            arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(0).Text) ' 10. SKU 
            arryList.Add(lvwWebArtikel.Items(iLoop).SubItems(4).Text) ' Kategorien
            ToolStripStatusLabel1.Text = iLoop + 1 & " / " & lvwWebArtikel.Items.Count - 1 & lvwWebArtikel.Items(iLoop).SubItems(1).Text

            tobj1.arryList = arryList
            Dim t As New System.Threading.Thread(AddressOf tobj1.setItemNew)
            t.Start()
        Next

    End Sub

    Private Sub MagentoArtikelLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentoArtikelLöschenToolStripMenuItem.Click
        mc.getLogin()
        If mc.setItem_delete(lvwWebArtikel.SelectedItems(0).Text) = True Then
            MsgBox("Der Artikel wurde gelöscht", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub MagentoArtikelNeuHinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentoArtikelNeuHinzufügenToolStripMenuItem.Click
        If lvwWebArtikel.SelectedItems.Count > 0 Then

            Dim arryList As New ArrayList
            arryList.Add("0.0") ' Gewicht
            arryList.Add("1") ' Steuerklasse 
            arryList.Add(lvwWebArtikel.SelectedItems(0).SubItems(2).Text) ' Preis
            arryList.Add(lvwWebArtikel.SelectedItems(0).SubItems(1).Text) ' Kurzbeschreibung
            arryList.Add(lvwWebArtikel.SelectedItems(0).SubItems(1).Text) ' Lange Beschreibung

            If lvwWebArtikel.SelectedItems(0).SubItems(1).Text.Length > 40 Then
                arryList.Add(lvwWebArtikel.SelectedItems(0).SubItems(1).Text.Substring(0, 40)) ' Name
            End If

            arryList.Add(cmbStatus.SelectedIndex + 1) ' Status (Aktiv)
            arryList.Add(cmbSichtbarkeit.SelectedIndex + 1) ' Sichtbarkeit (4 = Katalog, Suche)
            arryList.Add(lvwWebArtikel.SelectedItems(0).SubItems(1).Text) ' URL KEY 
            arryList.Add(24) ' Atributset
            arryList.Add(lvwWebArtikel.SelectedItems(0).SubItems(0).Text) ' 10. SKU 
            arryList.Add(lvwWebArtikel.SelectedItems(0).SubItems(4).Text) ' Kategorien

            mc.getLogin()
            mc.setItemNew(arryList)

            '# Bild hochladen
            Call mc.setNewImage(lvwWebArtikel.SelectedItems(0).SubItems(0).Text, lvwWebArtikel.SelectedItems(0).SubItems(3).Text)

            MsgBox("Der Artikel wurde hinzugefügt", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub MagentoArtikelBestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentoArtikelBestelltToolStripMenuItem.Click

        If lvwWebArtikel.SelectedItems.Count > 0 Then
            mc.getLogin()
            Call mc.setItem_update_disable(lvwWebArtikel.SelectedItems(0).SubItems(0).Text, "2")
            MsgBox("Der Artikel wurde auf bestellt gestellt", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub MagentoArtikelAktivToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentoArtikelAktivToolStripMenuItem.Click
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            mc.getLogin()
            Call mc.setItem_update_disable(lvwWebArtikel.SelectedItems(0).SubItems(0).Text, "1")
            MsgBox("Der Artikel wurde auf bestellt gestellt", MsgBoxStyle.Information)
        End If
    End Sub
End Class