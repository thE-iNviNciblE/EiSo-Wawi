Public Class frmOutlook_sync
    Dim clsYABE_Outlook As New clsOutlook

    Public bAutoMode As Boolean = False

    Private Sub frmOutlook_sync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Application.DoEvents()
        frmMain.master_Message_label.Text = "Starte YABE Outlook Sync - Delcampe..."

        If bAutoMode = False Then
            Me.Visible = True
            Me.ShowInTaskbar = True

            '# Farbiges Makieren beim Laden 
            YABEMakiereBekannteKundenToolStripMenuItem.Checked = True

            Call setLvwDataSelect_Aktion("TOPKUNDEN")

            If getOutlook2Yabe_emails() = False Then
                MsgBox("Es gab Probleme beim einlesen von Outlook", )
            End If

        Else
            Me.Visible = False
            Me.ShowInTaskbar = False

            If getOutlook2Yabe_emails() = False Then
                MsgBox("Es gab Probleme beim einlesen von Outlook", )
            End If

            Call setOutLook2Yabe()

            frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)

            Me.Close()
        End If

    End Sub

    Private Sub btnOutlook_items_sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim clsoutlook As New clsOutlook
        clsoutlook.getContacts(lvwOutlook_items)
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

    Private Sub btnOutlook_contacts_sync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutlook_contacts_sync.Click
        If TabControl1.SelectedIndex = 0 Then
            Dim clsoutlook As New clsOutlook
            clsoutlook.getContacts(lvwOutlook_contacts)
            'clsoutlook.FindContactEmailByName("Jan", "Bludau")
            StatusStrip1.Items(0).Text = "Kontakte eingelesen: " & lvwOutlook_contacts.Items.Count
        Else
            bIsLoading = True

            Try
                frmMain.frmManage.tab_verwaltung.SelectedIndex = 1

                If frmMain.frmManage.lvwKunden.Items.Count > 0 Then
                    Call getAdresses(lvwKunden_outlook)

                Else
                    frmMain.frmManage.btnKundenHolen.PerformClick()
                End If
            Catch ex As Exception

            End Try
   




            bIsLoading = False
        End If

    End Sub

    Private Function lookform(ByVal modus As Boolean, Optional ByVal bAutoModus As Boolean = False) As Boolean
        optOutlook_filter_alle.Enabled = modus
        optOutlook_filter_delcampe.Enabled = modus
        optOutlook_filter_ebay.Enabled = modus
        btnEmailsRead.Enabled = modus
        chkHeute.Enabled = modus
        btnOoutLook2Yabe.Enabled = modus

        If bAutoModus = True Then
            chkAutomatisch_abrufen.Enabled = True
        Else
            chkAutomatisch_abrufen.Enabled = modus
        End If

        Return True
    End Function

    Private Function getOutlook2Yabe_emails() As Boolean
        Dim strDate As Date = Nothing


        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If

        Call lookform(False)
        ToolStripProgressBar1.Visible = True

        If optOutlook_filter_alle.Checked = True Then
            clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.alle, "", strDate, Me)
        ElseIf optOutlook_filter_delcampe.Checked = True Then
            clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, My.Settings.gui_outlooksync_outlook_folder_delcampe, strDate, Me)
        ElseIf optOutlook_filter_ebay.Checked = True Then
            clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.eBay, My.Settings.gui_outlooksync_outlook_folder_ebay, strDate, Me)
        End If

        ToolStripProgressBar1.Visible = False
        Call lookform(True)

        Try
            StatusStrip1.Items(0).Text = "eMails eingelesen: " & lvwOutlook_items.Items.Count
        Catch ex As Exception

        End Try


        Return True

    End Function

    Private Sub btnEmailsRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailsRead.Click

        getOutlook2Yabe_emails()

    End Sub

    Private Sub TextLesenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextLesenToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim frmOutlookRead As New frmOutlook_message_read
            frmOutlookRead.lvwDataInput = lvwOutlook_items
            frmOutlookRead.txtOutlookEmail.Text = lvwOutlook_items.SelectedItems(0).SubItems(4).Text
            frmOutlookRead.Show(Me)
        End If

    End Sub

    Private Sub YABEKundendatenbanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEKundendatenbanToolStripMenuItem.Click

        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Call frmMain.frmManage.getOrderHistory(lvwOutlook_items, lvwOutlook_items.SelectedItems(0).SubItems(2).Text)
        End If

    End Sub

    Private Sub outlook_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles outlook_items.Click

    End Sub

    '########################################################################
    '# >> CMS Suche auslösen 
    '########################################################################
    Private Sub ArtikeldatenbankArtikelSuchenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikeldatenbankArtikelSuchenToolStripMenuItem.Click

        ' Eintrag selektiert 
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            ' Tab wechseln 
            frmMain.frmManage.tabMenue.SelectedIndex = 4

            '# Suchtext übertragen 
            If IsNumeric(lvwOutlook_items.SelectedItems(0).SubItems(10).Text) = True Then
                frmMain.frmManage.txtSuchen.Text = lvwOutlook_items.SelectedItems(0).SubItems(14).Text
            Else
                frmMain.frmManage.txtSuchen.Text = lvwOutlook_items.SelectedItems(0).SubItems(10).Text
            End If

            frmMain.frmManage.btnSuchen.PerformClick() ' suchen ausführen 
        End If

    End Sub

    Private Sub ExportAnsichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAnsichtToolStripMenuItem.Click

        If lvwOutlook_items.SelectedItems.Count >= 2 Then
            Call frmMain.frmManage.export(lvwOutlook_items, frmAuktionmanagement.export_targets.standard, frmAuktionmanagement.selectModus.part)
        Else
            Call frmMain.frmManage.export(lvwOutlook_items, frmAuktionmanagement.export_targets.standard, frmAuktionmanagement.selectModus.ganz)
        End If

    End Sub

    '################################################################################
    '# >> Artikel import + Bestellung / Kunden import 
    '################################################################################
    Public Function setOutLook2Yabe() As Boolean
        Dim iCount As Integer = 0
        Dim iCountNeu As Integer = 0
        Dim iCountUpdate As Integer = 0
        Dim iInsertItems As Integer = 0
        Dim iInsertItems_skipped As Integer = 0
        Dim iInsertItems_history As Integer = 0
        Dim strSQL As String = ""
        Dim iSetOrded As Integer = 0
        Dim iPersonal As Integer = 0
        Dim strArrayList As New ArrayList
        Dim strEmail_old As String = ""
        Dim bKdExists As Boolean = False
        Try

            lvwOutlook_items.BeginUpdate()
            ToolStripProgressBar1.Maximum = lvwOutlook_items.Items.Count
            ToolStripProgressBar1.Value = 0
            '# Magento Artikel auf Bestellt stellen 

            Dim mc As New clsMagentoAPI
            If My.Settings.yabe_magento_aktiv = True Then
                mc.getLogin()
            End If

            '# >> ALLE Einträge Bearbeiten 
            For iCount = 0 To lvwOutlook_items.Items.Count - 1

                ToolStripProgressBar1.Value += 1

                '# >> Denn Bearbeitungsmodus bestimmen 
                Select Case lvwOutlook_items.Items(iCount).SubItems(18).Text
                    Case "bezahlt"
                        Call clsDatenbank_modul.setEiSoOrder_status(lvwOutlook_items.Items(iCount).SubItems(11).Text, clsDatenbank.yabe_bestellstatus.bezahlt)
                    Case "bewertung"
                        Call clsDatenbank_modul.setEiSoOrder_status(lvwOutlook_items.Items(iCount).SubItems(11).Text, clsDatenbank.yabe_bestellstatus.verschickt)
                    Case "verkauft"
                        Dim lvwItemData As New ListViewItem

                        Dim strEmail As String = lvwOutlook_items.Items(iCount).SubItems(2).Text

                        If Not strEmail_old = strEmail Then
                            strEmail_old = strEmail
                            bKdExists = False
                        Else
                            bKdExists = True
                        End If

                        strArrayList.Clear()

                        '# Status holen für Adressen (ist richtig mit dem ersten Parameter leer
                        ' strEmail = "luisperezherreros@hotmail.com"
                        Dim strStatus As String = clsDatenbank_modul.chkUpdate_Add(strEmail, "yabe_personals_adress", "email")

                        '##############################################################################
                        '# >> ADD Profil / UPDATE Profil
                        '##############################################################################
                        If strStatus = "ADD" Then

                            '##########################
                            '# Vorab Prüfung eMail ok 
                            '##########################
                            If Not lvwOutlook_items.Items(iCount).SubItems(2).Text = "" Then
                                If bKdExists = False Then


                                    iCountNeu += 1
                                    lvwOutlook_items.Items(iCount).EnsureVisible()
                                    '##########################
                                    '# Neue Adresse anlegen 
                                    '##########################
                                    strSQL = clsDatenbank_modul.setInsert_Update_tLvw2SQL(lvwOutlook_items.Items(iCount), "lvwOutlook_items-kunden", strStatus)
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
                                    strArrayList.Add(lvwOutlook_items.Items(iCount).SubItems(15).Text) ' Delcampe User ID 
                                    strArrayList.Add(lvwOutlook_items.Items(iCount).SubItems(16).Text) ' Muttersprache
                                    strArrayList.Add(lvwOutlook_items.Items(iCount).SubItems(17).Text) ' Sprachliste 

                                    If clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.insert, lvwOutlook_items.Items(iCount).SubItems(12).Text, strEmail, strArrayList) = False Then
                                        MsgBox("Es gab einen Fehler beim abspeichern des Kunden Profils", MsgBoxStyle.Information + MsgBoxStyle.SystemModal + MsgBoxStyle.Critical)

                                    End If

                                    '#################################
                                    '# >> ProfilID Mappen 
                                    '#################################
                                    Dim strProfile_id As String = clsDatenbank_modul.getYABE_profil_id(strEmail)
                                    If IsNumeric(strProfile_id) = True Then
                                        clsDatenbank_modul.setYABE_Kunde_Profil2Adress(strProfile_id, strEmail)
                                    End If
                                End If

                                '################################################
                                '# >> Artikel in YABE Live anlegen 
                                '################################################
                                strSQL = clsDatenbank_modul.setInsert_Update_tLvw2SQL(lvwOutlook_items.Items(iCount), "lvwOutlook_items-aktive_liste", "ADD")
                                If strSQL.Length > 0 Then
                                    clsDatenbank_modul.dbConnect.Close()
                                    clsDatenbank_modul.dbConnect.Open()
                                    Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, clsDatenbank_modul.dbConnect)
                                    command.ExecuteNonQuery()
                                    iInsertItems += 1
                                    clsDatenbank_modul.dbConnect.Close()

                                    ' Artikel ID benutzen um Artikel auf bestellt zu stellen
                                    If lvwOutlook_items.Items(iCount).SubItems(14).Text.Length > 0 Then
                                        Dim strYABEID() As String = lvwOutlook_items.Items(iCount).SubItems(14).Text.Split("-")
                                        If clsDatenbank_modul.setOrdered_byYABEID(strYABEID(0)) = True Then

                                            '# Magento Artikel auf Bestellt stellen 
                                            If My.Settings.yabe_magento_aktiv = True Then


                                                mc.setItem_update_disable(strYABEID(0), "2")
                                            End If

                                            iSetOrded += 1
                                        End If
                                    End If

                                End If



                                '################################################
                                '# >> Übertragen eMail 
                                '################################################
                                If clsDatenbank_modul.chkUpdate_Add(lvwOutlook_items.Items(iCount).SubItems(11).Text, "yabe_auction_list_history") = "ADD" And clsDatenbank_modul.chkUpdate_Add(lvwOutlook_items.Items(iCount).SubItems(11).Text, "yabe_auction_list_live") = "ADD" Then

                                    strSQL = clsDatenbank_modul.setInsert_Update_tLvw2SQL(lvwOutlook_items.Items(iCount), "lvwOutlook_items-aktive_liste", "ADD")
                                    If strSQL.Length > 0 Then
                                        clsDatenbank_modul.dbConnect.Close()
                                        clsDatenbank_modul.dbConnect.Open()

                                        Try
                                            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, clsDatenbank_modul.dbConnect)
                                            command.ExecuteNonQuery()
                                            iInsertItems += 1
                                        Catch ex As Exception
                                            '    MsgBox(ex.Message)
                                            iInsertItems_skipped += 1

                                        End Try


                                        clsDatenbank_modul.dbConnect.Close()
                                    End If

                                Else

                                    iInsertItems_history += 1
                                End If




                            End If

                            '#################################
                            '# >> Persönliche ID zuordnen 
                            '#################################
                            iPersonal = clsDatenbank_modul.getPersonalID(lvwOutlook_items.Items(iCount).SubItems(2).Text)
                            If Not iPersonal = -1 Then
                                If clsDatenbank_modul.setPersonalID2Item(lvwOutlook_items.Items(iCount).SubItems(11).Text, iPersonal) = False Then
                                    MsgBox("Zuordnung -> Artikel zum Kunden fehlgeschlafen" & vbCrLf & "Artikel: " & lvwOutlook_items.Items(iCount).SubItems(10).Text, MsgBoxStyle.Critical)
                                End If
                            End If

                            '#  UPDATE Adresse
                        Else

                            '##############################################################################
                            '# >> ZWANGSUPDATE DURCH GUI SCHALTER 
                            '##############################################################################
                            If DelcampeKundenprofileAktullisierenToolStripMenuItem.Checked = True Then
                                '#################################
                                '# Neues Benutzerprofil anlegen 
                                '#################################
                                strArrayList.Add(lvwOutlook_items.Items(iCount).SubItems(15).Text) ' Delcampe User ID 
                                strArrayList.Add(lvwOutlook_items.Items(iCount).SubItems(16).Text) ' Muttersprache
                                strArrayList.Add(lvwOutlook_items.Items(iCount).SubItems(17).Text) ' Sprachliste 

                                If clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.update, lvwOutlook_items.Items(iCount).SubItems(12).Text, strEmail, strArrayList) = False Then
                                    MsgBox("Es gab einen Fehler beim abspeichern des Kunden Profils", MsgBoxStyle.Information + MsgBoxStyle.SystemModal + MsgBoxStyle.Critical)
                                Else
                                    iCountUpdate += 1
                                End If
                            End If

                            '################################################
                            '# >> Übertragen eMail 
                            '################################################
                            If clsDatenbank_modul.chkUpdate_Add(lvwOutlook_items.Items(iCount).SubItems(11).Text, "yabe_auction_list_history") = "ADD" And clsDatenbank_modul.chkUpdate_Add(lvwOutlook_items.Items(iCount).SubItems(11).Text, "yabe_auction_list_live") = "ADD" Then

                                '# Email vorhanden 
                                If Not lvwOutlook_items.Items(iCount).SubItems(2).Text = "" Then
                                    If bKdExists = False Then


                                        iCountUpdate += 1

                                        '################################################
                                        '# >> Adresse aktuallisieren
                                        '################################################
                                        strSQL = clsDatenbank_modul.setInsert_Update_tLvw2SQL(lvwOutlook_items.Items(iCount), "lvwOutlook_items-kunden", strStatus)

                                        If strSQL.Length > 0 Then
                                            clsDatenbank_modul.dbConnect.Close()
                                            clsDatenbank_modul.dbConnect.Open()
                                            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, clsDatenbank_modul.dbConnect)
                                            command.ExecuteNonQuery()
                                            clsDatenbank_modul.dbConnect.Close()
                                        End If

                                    End If

                                    strSQL = clsDatenbank_modul.setInsert_Update_tLvw2SQL(lvwOutlook_items.Items(iCount), "lvwOutlook_items-aktive_liste", "ADD")
                                    If strSQL.Length > 0 Then
                                        clsDatenbank_modul.dbConnect.Close()
                                        clsDatenbank_modul.dbConnect.Open()

                                        Try
                                            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, clsDatenbank_modul.dbConnect)
                                            command.ExecuteNonQuery()
                                            iInsertItems += 1
                                        Catch ex As Exception
                                            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                                            iInsertItems_skipped += 1

                                        End Try


                                        clsDatenbank_modul.dbConnect.Close()

                                    End If
                                    ' Artikel ID benutzen um Artikel auf bestellt zu stellen
                                    ' Artikel ID benutzen um Artikel auf bestellt zu stellen
                                    If lvwOutlook_items.Items(iCount).SubItems(14).Text.Length > 0 Then
                                        Dim strYABEID() As String = lvwOutlook_items.Items(iCount).SubItems(14).Text.Split("-")
                                        If clsDatenbank_modul.setOrdered_byYABEID(strYABEID(0)) = True Then

                                            '# Magento Artikel auf Bestellt stellen 
                                            If My.Settings.yabe_magento_aktiv = True Then

                                                mc.setItem_update_disable(strYABEID(0), "2")
                                            End If

                                            iSetOrded += 1
                                        End If
                                    End If

                                Else

                                    iInsertItems_history += 1
                                End If

                                '#################################
                                '# >> Persönliche ID zuordnen 
                                '#################################
                                iPersonal = clsDatenbank_modul.getPersonalID(lvwOutlook_items.Items(iCount).SubItems(2).Text)
                                If Not iPersonal = -1 Then
                                    If clsDatenbank_modul.setPersonalID2Item(lvwOutlook_items.Items(iCount).SubItems(11).Text, iPersonal) = False Then
                                        MsgBox("Zuordnung -> Artikel zum Kunden fehlgeschlafen" & vbCrLf & "Artikel: " & lvwOutlook_items.Items(iCount).SubItems(10).Text, MsgBoxStyle.Critical)
                                    End If
                                End If

                            End If
                        End If

                        Application.DoEvents()
                        StatusStrip1.Items(0).Text = "Kunden Name: " & lvwOutlook_items.Items(iCount).SubItems(6).Text & " - Neu: " & iCountNeu & " - aktuallisert: " & iCountUpdate & " - Artikel eingefügt: " & iInsertItems & " - übersprungen: " & iInsertItems_skipped & " - Verlauf: " & iInsertItems_history

                        Try

                            If iCount > 0 Then
                                lvwOutlook_items.Items(iCount - 1).Selected = False
                            End If
                        Catch ex As Exception

                        End Try


                        lvwOutlook_items.Items(iCount).Selected = True

                    Case "bewertung"
                        '  Dim frmWeb As New frmWebBrowser
                        '  frmWeb.lvwDataView = lvwOutlook_items
                        '  frmWeb.mWebLinkCollectionStatus = frmWebBrowser.mWebLinksCol.delcampe_bewerten
                        ' frmWeb.Show(Me)
                End Select


            Next
            lvwOutlook_items.EndUpdate()

            MsgBox("Es wurden '" & iSetOrded & "' von '" & lvwOutlook_items.Items.Count & "'  Artikel als Bestellt makiert", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)

        Catch ex As Exception
            lvwOutlook_items.EndUpdate()
            Call debug_message(ex, "setOutlook2Yabe" & strSQL)
        End Try

    End Function
    Private Sub btnOoutLook2Yabe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOoutLook2Yabe.Click
        Call lookform(False)
        ToolStripProgressBar1.Visible = True
        setOutLook2Yabe()
        ToolStripProgressBar1.Visible = False
        frmMain.frmManage.chkBestellungen_verkauft.Checked = True
        Call lookform(True)
        'StatusStrip1.Items(0).Text = "Es wurden '" & lvwOutlook_items.Items.Count & "' Artikel übertragen"
    End Sub

    Private Sub frmOutlook_sync_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub frmOutlook_sync_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        'Me.Opacity = 0.15
    End Sub


    Private Sub lvwOutlook_items_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwOutlook_items.MouseDoubleClick

        If lvwOutlook_items.SelectedItems.Count > 0 Then

            Select Case lvwOutlook_items.SelectedItems(0).SubItems(18).Text
                Case "bewertung"

                    Call setOpenWebBrowser()

                Case Else
                    Dim frmOutlookRead As New frmOutlook_message_read
                    frmOutlookRead.lvwDataInput = lvwOutlook_items
                    frmOutlookRead.txtOutlookEmail.Text = lvwOutlook_items.SelectedItems(0).SubItems(4).Text
                    frmOutlookRead.Show(Me)
            End Select



        End If
    End Sub

    Private Sub lvwOutlook_items_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwOutlook_items.SelectedIndexChanged

    End Sub

    Private Sub DelcampeKundenprofileAktullisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeKundenprofileAktullisierenToolStripMenuItem.Click
        If DelcampeKundenprofileAktullisierenToolStripMenuItem.Checked = False Then
            DelcampeKundenprofileAktullisierenToolStripMenuItem.Checked = True
        Else
            DelcampeKundenprofileAktullisierenToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub SucheKundenbestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheKundenbestellungenToolStripMenuItem.Click

        If lvwOutlook_items.SelectedItems.Count > 0 Then
            frmMain.frmManage.txtSuchen.Text = lvwOutlook_items.SelectedItems(0).SubItems(2).Text
            frmMain.frmManage.tabMenue.SelectedIndex = 2
            frmMain.frmManage.btnSuchen.PerformClick()
        End If

    End Sub

    Private Sub YABEMakiereBekannteKundenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEMakiereBekannteKundenToolStripMenuItem.Click

        Call setLvwDataSelect_Aktion("TOPKUNDEN")

    End Sub

    Private Sub YABEKundenbestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEKundenbestellungenToolStripMenuItem.Click

        If lvwOutlook_items.SelectedItems.Count > 0 Then

            Dim frmVersand As New frmBestellung_Versandkosten
            frmVersand.strEmail = lvwOutlook_items.SelectedItems(0).SubItems(14).Text
            frmVersand.mModusSelect = frmBestellung_Versandkosten.mModus.history
            frmVersand.Show()

        End If

    End Sub

    '# >> Öffnet YABE Browser
    Private Sub setOpenWebBrowser()
        If lvwOutlook_items.SelectedItems.Count > 0 Then

            Select Case lvwOutlook_items.SelectedItems(0).SubItems(18).Text
                Case "bewertung"
                    Dim frmWeb As New frmYABE_WebBrowser
                    frmWeb.lvwDataView = lvwOutlook_items
                    frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_bewerten
                    frmWeb.Show(Me)

                Case "verkauft"
                    Dim frmWeb As New frmYABE_WebBrowser
                    frmWeb.lvwDataView = lvwOutlook_items
                    frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                    frmWeb.Show(Me)

            End Select

        End If
    End Sub


    '### MEINE SACHEN
    Private Function setLvwDataSelect_Aktion(ByVal strModus As String) As Boolean
        Dim strEmail As String = ""

        Select Case strModus.ToUpper
            Case "TOPKUNDEN"
                If YABEMakiereBekannteKundenToolStripMenuItem.Checked = False Then
                    YABEMakiereBekannteKundenToolStripMenuItem.Checked = True

                    Dim iCount As Integer = 0
                    For iCount = 0 To lvwOutlook_items.Items.Count - 1

                        strEmail = lvwOutlook_items.Items(iCount).SubItems(2).Text
                        If Not clsDatenbank_modul.chkUpdate_Add(strEmail, "yabe_personals_profile", "email") = "ADD" Then
                            lvwOutlook_items.Items(iCount).BackColor = Color.Lavender
                        End If

                    Next iCount

                Else
                    YABEMakiereBekannteKundenToolStripMenuItem.Checked = False
                End If


            Case "DELETE"
                If YABEMakiereBekannteKundenToolStripMenuItem.Checked = False Then

                    YABEMakiereBekannteKundenToolStripMenuItem.Checked = True

                    Dim iCount As Integer = 0
                    For iCount = 0 To lvwOutlook_items.SelectedItems.Count - 1

                        lvwOutlook_items.SelectedItems(iCount).Remove()
                    Next iCount

                Else
                    YABEMakiereBekannteKundenToolStripMenuItem.Checked = False
                End If


        End Select
    End Function

    Private Sub YABEBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEBrowserToolStripMenuItem.Click

        Call setOpenWebBrowser()

    End Sub

    Private Sub NurVerkäufeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NurVerkäufeToolStripMenuItem.Click

    End Sub

    Private Sub NurBewertungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NurBewertungenToolStripMenuItem.Click

    End Sub

    Private Sub EntferneMakierteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntferneMakierteToolStripMenuItem.Click

        If lvwOutlook_items.SelectedItems.Count > 0 Then
            setLvwDataSelect_Aktion("DELETE")
        End If

    End Sub

 

    Private Sub InboxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InboxToolStripMenuItem.Click

        If InboxToolStripMenuItem.Checked = False Then
            InboxToolStripMenuItem.Checked = True

            Call lookform(False)
            Dim strDate As Date = Nothing

            If chkHeute.Checked = True Then
                strDate = Date.Now
            End If
            If optOutlook_filter_delcampe.Checked = True Then
                clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, "", strDate)
            ElseIf optOutlook_filter_ebay.Checked = True Then
                clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.eBay, "", strDate)
            End If

            Call lookform(True)

        Else
            InboxToolStripMenuItem.Checked = False

        End If

    End Sub

    Private Sub GesendeteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GesendeteToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, 5, strDate)
        Call lookform(True)

    End Sub

    Private Sub EBayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, My.Settings.gui_outlooksync_outlook_folder_ebay, strDate)
        Call lookform(True)
    End Sub

    Private Sub DelcampeOrdnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeOrdnerToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, My.Settings.gui_outlooksync_outlook_folder_delcampe, strDate)
        Call lookform(True)
    End Sub

    Private Sub EntwürfeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntwürfeToolStripMenuItem.Click
        Call lookform(False)

        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, 16)
        Call lookform(True)
    End Sub

    Private Sub PostausgangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostausgangToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, 4, strDate)
        Call lookform(True)
    End Sub

    Private Sub GelöschteEmailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GelöschteEmailsToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, 3, strDate)
        Call lookform(True)
    End Sub

    Private Sub MeineAufgabenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeineAufgabenToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, 13, strDate)
        Call lookform(True)
    End Sub

    Private Sub KalenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KalenderToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, 9, strDate)
        Call lookform(True)
    End Sub

  

    Private Sub lvwOutlook_items_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwOutlook_items.ColumnClick

        Call frmMain.frmManage.setSort(lvwOutlook_items, e)

    End Sub

    '########################################
    '# >> Outlook Drag n Drop 
    '########################################
    Private Sub lvwOutlook_items_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwOutlook_items.DragDrop
        Dim app As New Microsoft.Office.Interop.Outlook.Application()
        Dim iCount As Integer = 0

        'MsgBox(DirectCast(app.ActiveExplorer.Selection(1), Microsoft.Office.Interop.Outlook.MailItem).Subject)
        'lvwItem.Text = DirectCast(app.ActiveExplorer.Selection(1), Microsoft.Office.Interop.Outlook.MailItem).Subject

        For iCount = 1 To app.ActiveExplorer.Selection.Count
            Call clsYABE_Outlook.getOutlook2Yabe_items(lvwOutlook_items, DirectCast(app.ActiveExplorer.Selection(iCount), Microsoft.Office.Interop.Outlook.MailItem), clsOutlook.mOutlook.delcampe)
        Next

        lvwOutlook_items.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub

    Private Sub lvwOutlook_items_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwOutlook_items.DragEnter


        e.Effect = DragDropEffects.Move


    End Sub

    Private Sub lvwOutlook_items_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lvwOutlook_items.ItemDrag


    End Sub

    Private Sub EBayArchivToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayArchivToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, My.Settings.gui_outlooksync_outlook_folder_ebay_archiv, strDate)
        Call lookform(True)
    End Sub

    Private Sub DelcampeArchivToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeArchivToolStripMenuItem.Click
        Call lookform(False)
        Dim strDate As Date = Nothing

        If chkHeute.Checked = True Then
            strDate = Date.Now
        End If
        Call clsYABE_Outlook.email_filter(lvwOutlook_items, YabE.clsOutlook.mOutlook.delcampe, My.Settings.gui_outlooksync_outlook_folder_delcampe_archiv, strDate)
        Call lookform(True)
    End Sub

    Private Sub chkHeute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHeute.CheckedChanged

    End Sub

    Private Sub ImmerImVordergrundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImmerImVordergrundToolStripMenuItem.Click
        If ImmerImVordergrundToolStripMenuItem.Checked = False Then
            ImmerImVordergrundToolStripMenuItem.Checked = True
            Me.TopMost = True
        Else
            ImmerImVordergrundToolStripMenuItem.Checked = False
            Me.TopMost = False
        End If
    End Sub

    Private Sub TransparentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransparentToolStripMenuItem.Click
        If TransparentToolStripMenuItem.Checked = False Then
            TransparentToolStripMenuItem.Checked = True
            Me.Opacity = 0.6
        Else
            TransparentToolStripMenuItem.Checked = False
            Me.Opacity = 1
        End If
    End Sub

    Private Sub HinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HinzufügenToolStripMenuItem.Click


        If lvwKunden_outlook.SelectedItems.Count > 0 Then
            '# Vorname und Nachname holen 
            Dim str() As String = lvwKunden_outlook.SelectedItems(0).Text.Split(" ")

            If str.Length > 1 Then

                '# Suchen ob Konakt bereits vorhanden
                If clsYABE_Outlook.SearchForEmail(lvwKunden_outlook.SelectedItems(0).SubItems(2).Text) = False Then
                    '# Neuen Kontakt hinzufügen 
                    clsYABE_Outlook.olAddContact(str(0), str(1), "", "", lvwKunden_outlook.SelectedItems(0).SubItems(2).Text, "", lvwKunden_outlook.SelectedItems(0).SubItems(3).Text, lvwKunden_outlook.SelectedItems(0).SubItems(4).Text, lvwKunden_outlook.SelectedItems(0).SubItems(5).Text, lvwKunden_outlook.SelectedItems(0).SubItems(6).Text)
                Else
                    MsgBox("Kontakt " & str(0) & " " & str(1) & "wurde bereits hinzugefügt", MsgBoxStyle.Information)
                End If

            End If

        End If

    End Sub

    Private Sub AlleHinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlleHinzufügenToolStripMenuItem.Click

        If MsgBox("Möchten Sie wirklich alle YabE Kontakte synchronisieren?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim i As Integer = 0
            For i = 0 To lvwKunden_outlook.Items.Count - 1

                lvwKunden_outlook.Items(i).Selected = True
                lvwKunden_outlook.Items(i).EnsureVisible()

                Application.DoEvents()

                '# Vorname und Nachname holen 
                Dim str() As String = lvwKunden_outlook.Items(i).Text.Split(" ")

                If str.Length > 1 Then

                    '# Suchen ob Konakt bereits vorhanden
                    If clsYABE_Outlook.SearchForEmail(lvwKunden_outlook.Items(i).SubItems(2).Text) = False Then
                        '# Neuen Kontakt hinzufügen 
                        clsYABE_Outlook.olAddContact(str(0), str(1), "", "", lvwKunden_outlook.Items(i).SubItems(2).Text, "", lvwKunden_outlook.Items(i).SubItems(3).Text, lvwKunden_outlook.Items(i).SubItems(4).Text, lvwKunden_outlook.Items(i).SubItems(5).Text, lvwKunden_outlook.SelectedItems(0).SubItems(6).Text)
                        ToolStripStatusLabel1.Text = i + 1 & " / " & lvwKunden_outlook.Items.Count - 1 & " " & str(0) & " " & str(1) & " "

                    Else
                        ToolStripStatusLabel1.Text = i + 1 & " / " & lvwKunden_outlook.Items.Count - 1 & " Kontakt " & str(0) & " " & str(1) & " wurde bereits hinzugefügt"
                    End If

                End If


            Next

        End If
    End Sub

    Private Sub SuchenKundenbestellungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuchenKundenbestellungToolStripMenuItem.Click

        If lvwOutlook_contacts.SelectedItems.Count > 0 Then
            frmMain.frmManage.tabMenue.SelectedIndex = 2
            frmMain.frmManage.txtSuchen.Text = lvwOutlook_contacts.SelectedItems(0).SubItems(6).Text
            frmMain.frmManage.btnSuchen.PerformClick()

        End If
    End Sub

   
    Private Sub btnMailerdeamon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailerdeamon.Click
        Dim outlook As New clsOutlook

        lvwMailerdeamons.Items.Clear()
        lvwMailerdeamons.BeginUpdate()
        Call outlook.getNewsletter_deamons(txtMailerdeamons_ordner.Text, lvwMailerdeamons)
        lvwMailerdeamons.EndUpdate()

    End Sub

    Private Function setAbmelden() As Boolean
        Try
            Dim iCount As Integer = 0

            For iCount = 0 To lvwMailerdeamons.Items.Count - 1
                Call clsDatenbank_modul.setNewsletter(lvwMailerdeamons.Items(iCount).Text, "N")
                lvwMailerdeamons.Items(iCount).Selected = True
                lvwMailerdeamons.Items(iCount).EnsureVisible()
                Application.DoEvents()
            Next

        Catch ex As Exception

        End Try
    End Function

    Private Sub btnAbmelden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbmelden.Click
        Call setAbmelden()
    End Sub

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click
        If lvwMailerdeamons.SelectedItems.Count > 0 Then
            lvwMailerdeamons.SelectedItems(0).Remove()
        End If
    End Sub
    '############################################
    '# >> Delcampe Artikel löschen
    '############################################
    Private Sub getDelcampe_delete_items(Optional ByVal iID As String = "-1")
        '  If lvwOutlook_items.SelectedItems.Count > 0 Then
        Dim frmDelcampeSearch As New frmOutlook_sync_duplicate
        If iID = "-1" Then
            frmDelcampeSearch.strReferenz = lvwOutlook_items.SelectedItems(0).SubItems(14).Text
        Else
            frmDelcampeSearch.strReferenz = iID
        End If

        Dim strYABEID() As String = frmDelcampeSearch.strReferenz.Split("-")
        If strYABEID.Length > 1 Then
            If strYABEID(1) = "Deutsch" Then
                frmDelcampeSearch.strSprache = "EN"
            Else
                frmDelcampeSearch.strSprache = "DE"
            End If
        End If

        frmDelcampeSearch.bshowMessage = False
        frmDelcampeSearch.bUnsichtbar = True
        frmDelcampeSearch.Show()

        If frmDelcampeSearch.bResult = True Then
            MsgBox("Artikel gelöscht", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub DoppeltenSuchenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoppeltenSuchenToolStripMenuItem.Click
        Call getDelcampe_delete_items()
    
    End Sub

    Private Sub LöschenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem1.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then


            Dim iCount As Integer = 0

            For iCount = 0 To lvwOutlook_items.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwOutlook_items.SelectedItems(iCount).SubItems(14).Text.Split("-")

                Dim strBild As String = clsDatenbank_modul.getCMS_ShopItems("Bild", strYABEID(0))

                If frmMain.frmManage.setDeletePictures(strBild, True) = True Then
                    If clsDatenbank_modul.getCMS_items_delete("DELETE FROM tblGes WHERE ID=" & strYABEID(0)) = True Then
                        frmMain.master_Message_label.Text = lvwOutlook_items.SelectedItems(iCount).SubItems(14).Text & " / " & lvwOutlook_items.SelectedItems(iCount).SubItems(14).Text
                    Else
                        MsgBox("Probleme beim Löschen des Artikels mit ID: '" & lvwOutlook_items.SelectedItems(iCount).SubItems(10).Text & "'  auf dem Server", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Probleme beim Löschen des Bildes Artikels mit ID: '" & lvwOutlook_items.SelectedItems(iCount).SubItems(14).Text & "' auf dem Server", MsgBoxStyle.Exclamation)
                End If

            Next

            MsgBox("Artikel gelöscht", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwOutlook_items.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwOutlook_items.SelectedItems(iCount).SubItems(14).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(1, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'bestellt' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub WartelisteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WartelisteToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwOutlook_items.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwOutlook_items.SelectedItems(iCount).SubItems(14).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(2, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'Warteliste' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub AktivToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktivToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwOutlook_items.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwOutlook_items.SelectedItems(iCount).SubItems(14).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(0, strYABEID(0))
            Next

        End If
        MsgBox("Artikel auf 'aktiv' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub BildAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BildAnzeigenToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim frmPicture As New frmShowPicture
            frmPicture.strYABE_ID = lvwOutlook_items.SelectedItems(0).SubItems(14).Text
            frmPicture.Show()
        End If

    End Sub

    Private Sub ArtikelAktivierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelAktivierenToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwOutlook_items.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwOutlook_items.SelectedItems.Count - 1 & " " & lvwOutlook_items.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()

                Dim strSKU As String = lvwOutlook_items.SelectedItems(iloop).SubItems(14).Text
                Dim strYABEID() As String = strSKU.Split("-")
                Call mc.setItem_update_disable(strYABEID(0), "1")


            Next
            MsgBox("Artikel wurden wieder aktiviert ", MsgBoxStyle.Information)
        End If
       
    End Sub

    Private Sub ArtikelBestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelBestelltToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwOutlook_items.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwOutlook_items.SelectedItems.Count - 1 & " " & lvwOutlook_items.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()

                Dim strSKU As String = lvwOutlook_items.SelectedItems(iloop).SubItems(14).Text
                Dim strYABEID() As String = strSKU.Split("-")
                Call mc.setItem_update_disable(strYABEID(0), "2")


            Next

            MsgBox("Artikel wurden auf bestellt gestellt", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ArtikelLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelLöschenToolStripMenuItem.Click
        If lvwOutlook_items.SelectedItems.Count > 0 Then
            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwOutlook_items.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwOutlook_items.SelectedItems.Count - 1 & " " & lvwOutlook_items.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()

                Dim strSKU As String = lvwOutlook_items.SelectedItems(iloop).SubItems(14).Text
                Dim strYABEID() As String = strSKU.Split("-")
                Call mc.setItem_delete(strYABEID(0))


            Next

            MsgBox("Artikel wurden gelöscht", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub conOutlook_items_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles conOutlook_items.Opening
        If My.Settings.yabe_magento_aktiv = False Then
            MagentoToolStripMenuItem.Visible = False
        Else
            MagentoToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub chkAutomatisch_abrufen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutomatisch_abrufen.CheckedChanged
        If chkAutomatisch_abrufen.Checked = True Then
            Call lookform(False, True)
            tmrOutlookSync.Interval = My.Settings.yabe_delcampe_gui_timer * 60000
            tmrOutlookSync.Enabled = True
            ToolStripProgressBar1.Maximum = My.Settings.yabe_delcampe_gui_timer * 60000
            ToolStripProgressBar1.Visible = True
            ToolStripProgressBar1.Value = 0
            tmrOutlookSync_wait.Enabled = True
        Else
            Call lookform(True, True)
            tmrOutlookSync.Enabled = False
            tmrOutlookSync_wait.Enabled = False
            ToolStripProgressBar1.Visible = False
        End If
    End Sub

    Private Sub tmrOutlookSync_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOutlookSync.Tick

        tmrOutlookSync_wait.Enabled = False
        Call getOutlook2Yabe_emails()

        'Dim iLoop As Integer = 0
        'For iLoop = 0 To lvwOutlook_items.Items.Count - 1
        '    '# Nur Verkaufte berücksichtigen + Delcampe
        '    If lvwOutlook_items.Items(iLoop).SubItems(18).Text = "verkauft" Then

        '        '# Nur bei WebID 
        '        If lvwOutlook_items.Items(iLoop).SubItems(14).Text.Length > 0 Then
        '            Call getDelcampe_delete_items(lvwOutlook_items.Items(iLoop).SubItems(14).Text)
        '            ToolStripStatusLabel1.Text = iLoop + 1 & " " & lvwOutlook_items.Items(iLoop).SubItems(14).Text & " / " & lvwOutlook_items.Items(iLoop).SubItems(10).Text
        '        End If

        '    End If

        'Next
        ToolStripProgressBar1.Maximum = My.Settings.yabe_delcampe_gui_timer * 60000
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        tmrOutlookSync_wait.Enabled = True
    End Sub

    Private Sub tmrOutlookSync_wait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOutlookSync_wait.Tick
        If Not ToolStripProgressBar1.Maximum = ToolStripProgressBar1.Value Then
            ToolStripProgressBar1.Value += 1000
        Else
            ToolStripProgressBar1.Value = 0
        End If

    End Sub
End Class