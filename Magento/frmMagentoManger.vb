Public Class frmMagentoManger
    Private mc As New clsMagentoAPI
    Enum bShowOnStartup
        artikel = 0
        bestellungen = 1
        kunden = 2
    End Enum
    Public ShowOnStartup As bShowOnStartup
    Private bIsLoading As Boolean = True

    Private Sub frmMagentoManger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mc.setStoreviewName = "admin"

        If mc.getLogin() = True Then
            getMagento()
        End If

        '# Fenster beim Startup auswählen
        Select Case ShowOnStartup
            Case bShowOnStartup.artikel
                tbMagentoSub.SelectedIndex = 0
            Case bShowOnStartup.bestellungen
                tbMagentoSub.SelectedIndex = 2
                Call AktionButtons()
            Case bShowOnStartup.kunden
                tbMagentoSub.SelectedIndex = 1
        End Select



        bIsLoading = False

    End Sub
 
 

    Private Sub getMagento()        


        lvwMagentoKategorie.Items.Clear()
        lvwMagentoKategorie.BeginUpdate()
        Call mc.getCategoryTree(lvwMagentoKategorie, False)
        lvwMagentoKategorie.EndUpdate()

        'Call mc.getCategory_products(lvwMagentoArtikel, 2)

        'Call mc.getUserList(lvwMagentoKunden)

    End Sub

    '#################################################
    '# >> Aktionssteuerung je Tab 
    '#################################################
    Private Sub AktionButtons()
        Select Case tbMagentoSub.SelectedIndex
            Case 0
                lvwMagentoKategorie.Items.Clear()
                lvwMagentoKategorie.BeginUpdate()
                Call mc.getCategoryTree(lvwMagentoKategorie, False)
                lvwMagentoKategorie.EndUpdate()
                ' Call mc.getCategory_products(lvwMagentoArtikel, 2)
            Case 1
                Call mc.getUserList(lvwMagentoKunden)
            Case 2
                Call mc.getOrders(lvwMagento_bestellungen)
        End Select
    End Sub

    Private Sub tbMagentoSub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMagentoSub.SelectedIndexChanged

        If bIsLoading = False Then
            Select Case tbMagentoSub.SelectedIndex
                Case 0
                    If lvwMagentoKategorie.Items.Count = 0 Or lvwMagentoArtikel.Items.Count = 0 Then
                        Call AktionButtons()
                    End If
                Case 1
                    If lvwMagentoKunden.Items.Count = 0 Then
                        Call AktionButtons()
                    End If
                Case 2
                    If lvwMagento_bestellungen.Items.Count = 0 Then
                        Call AktionButtons()
                    End If
            End Select

        End If
    End Sub

    Private Sub lvwMagentoKategorie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMagentoKategorie.SelectedIndexChanged


        If lvwMagentoKategorie.SelectedItems.Count > 0 Then
            If MsgBox("Möchten Sie die Kategorie wirklich laden?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                getDataByArtikelStammView()
            End If
        End If
    End Sub

    '#######################################################
    '# >> Artikelstamm: Kategorie Data 
    '#######################################################
    Private Function getKategorieData() As Boolean
        Try
            If lvwMagentoKategorie.SelectedItems.Count > 0 Then
                btnMagentoKategorieInfo.Enabled = False
                Dim CatInfo As YabE.net.cubss.catalogCategoryInfo
                CatInfo = mc.getCategoryInfo(lvwMagentoKategorie.SelectedItems(0).Text)

                If Not CatInfo.created_at = Nothing Then
                    txtMagentoCat_beschreibung.Text = CatInfo.description
                    txtMagentoCat_Urlkey.Text = CatInfo.url_key
                    txtURLPath.Text = CatInfo.url_path
                    txtMagentoCat_layout.Text = CatInfo.page_layout

                    txtMCCat_Name.Text = CatInfo.name
                    txtMagentoCat_MetaTitel.Text = CatInfo.meta_title
                    txtMagentoCat_MetaDescription.Text = CatInfo.meta_description
                    txtMagentoCat_MetaKeywords.Text = CatInfo.meta_keywords
                    txtMagentoCat_Aktiv.Text = CatInfo.is_active
                    txtMagentoCat_Anker.Text = CatInfo.is_anchor
                    txtMCCat_ID.Text = CatInfo.category_id
                    txtMCCat_LayoutXML.Text = CatInfo.custom_layout_update
                    txtMCcat_updated.Text = CatInfo.updated_at
                    txtMCcat_erstellt.Text = CatInfo.created_at

                    txtMagentoCat_Design.Text = CatInfo.custom_design
                    txtMagentoCat_Apply.Text = CatInfo.custom_design_apply
                    txtMagentoCat_DesignAktiv.Text = CatInfo.custom_design_from
                    txtMagentoCat_DesignEnde.Text = CatInfo.custom_design_to
                    txtMagentoCat_Pagelayout.Text = CatInfo.page_layout
                    txtMagentoCat_Anzeigemodus.Text = CatInfo.display_mode
                    txtMagentoCat_Sortierung.Text = CatInfo.default_sort_by
                End If
                btnMagentoKategorieInfo.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            btnMagentoKategorieInfo.Enabled = True
        End Try
    End Function

    Private Sub btnMagentoKategorieInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagentoKategorieInfo.Click

        If lvwMagentoKategorie.SelectedItems.Count > 0 Then
            getDataByArtikelStammView()
        End If

    End Sub

    '#######################################################
    '# >> Magento Artikel Comboboxen setzen
    '#######################################################
    Private Function setCMBData(ByVal cmb As ComboBox, ByVal iValue As Integer) As Boolean
        Try
            Select Case cmb.Name
                Case "cmbStatus"
                    If iValue = 1 Then
                        cmb.SelectedIndex = 0
                    Else
                        cmb.SelectedIndex = 1
                    End If
                Case "cmbSichtbarkeit"
                    cmb.SelectedIndex = iValue - 1
            End Select

            Return True
        Catch ex As Exception

        End Try
    End Function

    '#######################################################
    '# >> Magento Artikel holen
    '#######################################################
    Private Sub getMagentoItem()
        If lvwMagentoArtikel.SelectedItems.Count > 0 Then
            txtItemName.Text = lvwMagentoArtikel.SelectedItems(0).SubItems(1).Text
            txtItemLong.Text = lvwMagentoArtikel.SelectedItems(0).SubItems(9).Text
            txtItemShort.Text = lvwMagentoArtikel.SelectedItems(0).SubItems(8).Text
            txtItemPreis.Text = lvwMagentoArtikel.SelectedItems(0).SubItems(2).Text
            Call setCMBData(cmbStatus, lvwMagentoArtikel.SelectedItems(0).SubItems(7).Text)
            Call setCMBData(cmbSichtbarkeit, lvwMagentoArtikel.SelectedItems(0).SubItems(5).Text)
        End If
    End Sub

    '#######################################################
    '# >> Tab: Artikelstamm Aktions 
    '#######################################################
    Private Function getDataByArtikelStammView() As Boolean
        Try
            Select Case tabMCArtikelstamm.SelectedIndex
                Case 0

                    If lvwMagentoKategorie.SelectedItems.Count > 0 Then
                        mc.getCategory_productsBYcat(lvwMagentoArtikel, lvwMagentoKategorie.SelectedItems(0).Text)
                        'mc.getCategory_products(lvwMagentoArtikel, lvwMagentoKategorie.SelectedItems(0).Text)

                    End If

                Case 1

                    Call getMagentoItem()

                Case 2
                    Call getKategorieData()
            End Select
        Catch ex As Exception

        End Try
    End Function
    Private Sub tabMCArtikelstamm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabMCArtikelstamm.SelectedIndexChanged

        getDataByArtikelStammView()
    End Sub

    Private Sub lvwMagentoArtikel_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwMagentoArtikel.MouseDoubleClick
        tabMCArtikelstamm.SelectedIndex = 1

    End Sub

    Private Sub btnMagentoKategorieInfo_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagentoKategorieInfo_save.Click

        btnMagentoKategorieInfo.Enabled = False
        btnMagentoKategorieInfo_save.Enabled = False
        Dim catDataUpdate As New YabE.net.cubss.catalogCategoryEntityCreate
        '# Meta 
        catDataUpdate.meta_title = txtMagentoCat_MetaTitel.Text
        catDataUpdate.meta_keywords = txtMagentoCat_MetaKeywords.Text
        catDataUpdate.meta_description = txtMagentoCat_MetaDescription.Text

        catDataUpdate.name = txtMCCat_Name.Text
        catDataUpdate.page_layout = txtMagentoCat_Pagelayout.Text
        catDataUpdate.url_key = txtMagentoCat_Urlkey.Text
        catDataUpdate.description = txtMagentoCat_beschreibung.Text
        catDataUpdate.custom_design = txtMagentoCat_Design.Text
        catDataUpdate.custom_design_applySpecified = True
        catDataUpdate.custom_design_apply = txtMagentoCat_Apply.Text
        catDataUpdate.custom_design_from = txtMagentoCat_DesignAktiv.Text
        catDataUpdate.custom_design_to = txtMagentoCat_DesignEnde.Text
        catDataUpdate.display_mode = txtMagentoCat_Anzeigemodus.Text

        catDataUpdate.is_activeSpecified = True
        catDataUpdate.is_active = txtMagentoCat_Aktiv.Text

        catDataUpdate.is_anchorSpecified = True
        catDataUpdate.is_anchor = txtMagentoCat_Anker.Text
        catDataUpdate.custom_layout_update = txtMCCat_LayoutXML.Text
        catDataUpdate.default_sort_by = txtMagentoCat_Sortierung.Text

        '# >> Übertragen der Daten 
        Call mc.setCategoryInfo(txtMCCat_ID.Text, catDataUpdate)

        btnMagentoKategorieInfo.Enabled = True
        btnMagentoKategorieInfo_save.Enabled = True
    End Sub

    Private Sub lvwMagentoArtikel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMagentoArtikel.SelectedIndexChanged

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        lvwMagentoKategorie.BeginUpdate()
        Call mc.getCategoryTree(lvwMagentoKategorie, False)
        lvwMagentoKategorie.EndUpdate()
    End Sub

    Private Sub AktuallisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktuallisierenToolStripMenuItem.Click
        Call mc.getUserList(lvwMagentoKunden)
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click

        If lvwMagentoKategorie.SelectedItems.Count > 0 Then
            Call mc.getCategory_products(lvwMagentoArtikel, lvwMagentoKategorie.SelectedItems(0).Text)
        End If

    End Sub

    Private Sub BearbeitenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BearbeitenToolStripMenuItem.Click

        If lvwMagentoKunden.SelectedItems.Count > 0 Then
            Dim frmMagentoUser As New frmMagento_UserEdit
            frmMagentoUser.lvwData = lvwMagentoKunden.SelectedItems(0)
            frmMagentoUser.ShowDialog(Me)
        End If

    End Sub

    Private Sub NeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripMenuItem.Click

        Dim frmMagentoUser As New frmMagento_UserEdit
        Dim lvwData As ListViewItem
        frmMagentoUser.lvwData = lvwData
        frmMagentoUser.bNew = True
        frmMagentoUser.ShowDialog(Me)

    End Sub

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click

        If lvwMagentoKunden.SelectedItems.Count > 0 Then
            If MsgBox("Möchten Sie den Kunden löschen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If mc.setCustomer_delete(lvwMagentoKunden.SelectedItems(0).Text) = True Then
                    MsgBox("Der Kunde wurde erfolgreich gelöscht", MsgBoxStyle.Information)
                Else
                    MsgBox("Kunde wurde nicht erfolgreich gelöscht", MsgBoxStyle.Exclamation)
                End If
            End If

        End If

    End Sub

    Private Function getAdresses(ByRef lvwOutlook_contacts As ListView) As Boolean
        Try
            Dim i As Integer = 0
            lvwOutlook_contacts.Items.Clear()

            For i = 0 To frmMain.frmManage.lvwKunden.Items.Count - 1
                Dim lvwItem As New ListViewItem
                lvwItem.Text = frmMain.frmManage.lvwKunden.Items(i).Text
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(1).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(2).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(3).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(4).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(5).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(6).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(7).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(8).Text)
                lvwItem.SubItems.Add(frmMain.frmManage.lvwKunden.Items(i).SubItems(9).Text)
                lvwOutlook_contacts.Items.Add(lvwItem)
                lvwOutlook_contacts.Items(i).EnsureVisible()
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Sub EinlesenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinlesenToolStripMenuItem.Click
        Try
            frmMain.frmManage.tab_verwaltung.SelectedIndex = 1

            If frmMain.frmManage.lvwKunden.Items.Count > 0 Then
                Call getAdresses(lvwKunden_YabE)

            Else
                frmMain.frmManage.btnKundenHolen.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HinzufügenToolStripMenuItem.Click


    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        tabMCArtikelstamm.SelectedIndex = 1
    End Sub

    Private Sub SYNCYabEArtikelstammImportierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYNCYabEArtikelstammImportierenToolStripMenuItem.Click
        Dim frmYabe2Magento As New frmYabe2Magento
        frmYabe2Magento.ShowDialog()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'mc.setItemNew()
        ' mc.setNewImage("41")
    End Sub

    Private Sub PreisanalyseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreisanalyseToolStripMenuItem.Click


        If lvwMagentoArtikel.SelectedItems.Count > 0 Then
            Dim frmPreisvergleich As New frmPreisanalyse
            frmPreisvergleich.strPreis = lvwMagentoArtikel.SelectedItems(0).SubItems(1).Text
            frmPreisvergleich.strTitel = lvwMagentoArtikel.SelectedItems(0).SubItems(2).Text
            frmPreisvergleich.strID = lvwMagentoArtikel.SelectedItems(0).Text
            frmPreisvergleich.strSKU = lvwMagentoArtikel.SelectedItems(0).SubItems(6).Text
            frmPreisvergleich.Show()
        End If

    End Sub

    Private Sub AlleHinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlleHinzufügenToolStripMenuItem.Click

    End Sub

    Private Sub YabE2MagentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YabE2MagentoToolStripMenuItem.Click
        Dim frmMain As New frmMenueSync
        frmMain.Show()
    End Sub

    Private Sub lvwOrders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMagento_bestellungen.SelectedIndexChanged

    End Sub

    '##########################################################
    '# >> Bestellungen Sync
    '##########################################################
    Private Function getBestellungenSync() As Boolean
        Try

            Dim iCount As Integer = 0
            Dim strSQL As String = ""
            Dim strArrayList As ArrayList
            Dim strEmail As String
            Dim strAryList As New ArrayList

            For iCount = 0 To lvwMagento_bestellungen.Items.Count - 1

                lvwMagento_bestellungen.Items(iCount).Selected = True

                '################################################
                If clsDatenbank_modul.chkUpdate_Add(lvwMagento_bestellungen.Items(iCount).SubItems(11).Text, "yabe_auction_list_history") = "ADD" And clsDatenbank_modul.chkUpdate_Add(lvwMagento_bestellungen.Items(iCount).SubItems(11).Text, "yabe_auction_list_live") = "ADD" Then

                    strEmail = lvwMagento_bestellungen.Items(iCount).SubItems(2).Text

                    strSQL = clsDatenbank_modul.setInsert_Update_tLvw2SQL(lvwMagento_bestellungen.Items(iCount), "lvwMagento_bestellungen", "ADD")
                    '# Datenquery ausführen 
                    If strSQL.Length > 0 Then
                        clsDatenbank_modul.dbConnect.Close()
                        clsDatenbank_modul.dbConnect.Open()
                        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, clsDatenbank_modul.dbConnect)
                        command.ExecuteNonQuery()
                        clsDatenbank_modul.dbConnect.Close()
                    End If

                    '#################################
                    '# Neues Benutzerprofil anlegen 
                    '#################################
                    Dim strStatus As String = clsDatenbank_modul.chkUpdate_Add(strEmail, "yabe_personals_adress", "email")
                    If strStatus = "ADD" Then
                        If clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.insert, lvwMagento_bestellungen.Items(iCount).SubItems(10).Text, strEmail, strArrayList) = False Then
                            MsgBox("Es gab einen Fehler beim abspeichern des Kunden Profils", MsgBoxStyle.Information + MsgBoxStyle.SystemModal + MsgBoxStyle.Critical)

                        End If
                        ' 1 - Email
                        ' 2 - Feedback Score
                        ' 3 - RegDate
                        ' 4 - Seller Level 
                        ' 5 - Site (de / en) 
                        ' 6 - Positiv % 
                        ' 7 - Store URL 
                        ' 8 - Neuer Benutzer ? 
                        ' 9 - Verified Account
                        ' 10- Letzte Änderung 
                        ' 11- Paypal Status 
                        ' 12- Paypal bestätigt

                        '# Anschrift 
                        ' 13 - Name 
                        ' 14 - PLZ
                        ' 15 - Ort
                        ' 16 - Straße
                        ' 17 - Land
                        ' 18 - star
                        ' 19 - Account Name 
                        ' - 
                        ' 20 - Telefon
                        ' 21 - Handy 
                        ' 22 - Company
                        ' 23 - Bundesland
                        strAryList.Add(strEmail)
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add("")
                        strAryList.Add(lvwMagento_bestellungen.Items(iCount).SubItems(1).Text) ' Name
                        strAryList.Add(lvwMagento_bestellungen.Items(iCount).SubItems(12).Text) ' PLZ
                        strAryList.Add(lvwMagento_bestellungen.Items(iCount).SubItems(3).Text) ' Ort
                        strAryList.Add(lvwMagento_bestellungen.Items(iCount).SubItems(5).Text) ' strasse
                        strAryList.Add(lvwMagento_bestellungen.Items(iCount).SubItems(4).Text) ' land
                        strAryList.Add("") ' star
                        strAryList.Add("") ' account
                        strAryList.Add("") ' telefon
                        strAryList.Add("") ' handy
                        strAryList.Add("") ' company
                        strAryList.Add("") ' bundesland
                        clsDatenbank_modul.setYABE_kunden_adress_ArrayList(clsDatenbank.modus.insert, strAryList)

                        '#################################
                        '# >> ProfilID Mappen 
                        '#################################
                        Dim strProfile_id As String = clsDatenbank_modul.getYABE_profil_id(strEmail)
                        If IsNumeric(strProfile_id) = True Then
                            clsDatenbank_modul.setYABE_Kunde_Profil2Adress(strProfile_id, strEmail)
                        End If
                    End If

                    '#################################
                    '# >> Persönliche ID zuordnen 
                    '#################################
                    Dim iPersonal As Integer
                    iPersonal = clsDatenbank_modul.getPersonalID(strEmail)
                    If Not iPersonal = -1 Then
                        If clsDatenbank_modul.setPersonalID2Item_email(strEmail, iPersonal) = False Then
                            MsgBox("Zuordnung -> Artikel zum Kunden fehlgeschlafen" & vbCrLf & "Artikel: " & lvwMagento_bestellungen.Items(iCount).SubItems(10).Text, MsgBoxStyle.Critical)
                        End If
                    End If

                End If
               

               
            Next

            MsgBox("Die Bestellungen wurden Synchronisiert", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    Private Sub btnBestellungen_sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestellungen_sync.Click
        Call getBestellungenSync()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Call mc.getOrders(lvwMagento_bestellungen)
    End Sub
End Class