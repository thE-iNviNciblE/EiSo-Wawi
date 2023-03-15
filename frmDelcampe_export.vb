Public Class frmDelcampe_export

    Public lvwData_multiselect As New ListView
    Public aryAuktionData As New ArrayList
    Public bAbort As Boolean = False
    Public bIsloading As Boolean = True
    Private bStopReadInSelected As Boolean = False
    Private bOK As Boolean = False

    Private Sub tbDelcampe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDelcampe.Click

    End Sub

    '########################################################
    '# >> Daten vom Listview ins Fenster Laden
    '########################################################
    Private Function setSelected2Listview(Optional ByVal bLoad As Boolean = False) As Boolean
        Dim i As Integer = 0
        Try

            If Not lvwData_multiselect.SelectedItems.Count > 250 Or bLoad = True Then
                lvwMultiSelect.Visible = True
                lvwMultiSelect.BeginUpdate()
                Application.DoEvents()
                For i = 0 To lvwData_multiselect.SelectedItems.Count - 1

                    If bStopReadInSelected = True Then
                        lvwMultiSelect.EndUpdate()
                        Exit For
                    End If

                    If i Mod 10 = 0 Then
                        Application.DoEvents()
                        frmMain.master_Message_label.Text = "Lade " & i + 1 & " von " & lvwData_multiselect.SelectedItems.Count
                    End If

                    If Not lvwData_multiselect.SelectedItems(i).SubItems(5).Text = "-1" Or lvwData_multiselect.SelectedItems(i).SubItems(5).Text = "1" Then
                        Dim lvwItem As New ListViewItem

                        lvwItem.Text = lvwData_multiselect.SelectedItems(i).Text
                        lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(1).Text)

                        lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(5).Text)
                        lvwItem.SubItems.Add("--")
                        lvwItem.SubItems.Add(lvwData_multiselect.SelectedItems(i).SubItems(4).Text)

                        lvwMultiSelect.Items.Add(lvwItem)
                    End If

                Next

                lvwMultiSelect.EndUpdate()
            Else
                lvwMultiSelect.Visible = False
            End If



            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frmYABE_export_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim i As Integer

            '# Übertragen der selektierten Einträge in Listview 
            Call setSelected2Listview()
            For i = 0 To frmMain.frmManage.cmbSprache_Artikeldatenbank.Items.Count - 1
                cmbÜberschriftSprache.Items.Add(frmMain.frmManage.cmbSprache_Artikeldatenbank.Items(i))
            Next i

            '# Gespeicherte GUI Oberfläche setzen 
            chkDelcampe_last_minute.Checked = My.Settings.yabe_gui_delcampe_export_lastminute
            chkDelcampe_TitelFett.Checked = My.Settings.yabe_gui_delcampe_export_fett
            chkFluoresierend.Checked = My.Settings.yabe_gui_delcampe_export_fluroeszierend
            chkDelcampe_umrandet.Checked = My.Settings.yabe_gui_delcampe_export_farbig_umrandet
            chkDelcampe_untertitel.Checked = My.Settings.yabe_gui_delcampe_export_untertitel
            chkDelcampe_startseite.Checked = My.Settings.yabe_gui_delcampe_export_coast_startseite
            ckkDelcampe_category_top.Checked = My.Settings.yabe_gui_delcampe_export_coast_cat_ganzoben
            chkDelcampe_listing_top.Checked = My.Settings.yabe_gui_delcampe_export_coast_liste_ganzoben

            cmbDelcampeDauer.SelectedIndex = My.Settings.yabe_gui_delcampe_export_dauer
            cmbDelcampe_auslauftag.SelectedIndex = My.Settings.yabe_gui_delcampe_export_wochentag
            bIsloading = True
            txtDelcampe_enduhrzeit.Text = My.Settings.yabe_gui_delcampe_export_uhrzeit
            bIsloading = False
            cmbDelcampePlattform.SelectedIndex = My.Settings.yabe_gui_delcampe_export_plattform

            chkDelcampe3.Checked = My.Settings.yabe_gui_delcampe_lister3
            'cmbErneuern.SelectedIndex = 1

            chkDelcampeAuktion.Checked = My.Settings.yabe_delcampe_export_sofortkauf
            txtDelcampeSteigerung.Text = My.Settings.yabe_delcampe_export_steigerung

            cmbErneuern.SelectedIndex = My.Settings.yabe_delcampe_export_erneuern
        Catch ex As Exception
            debug_message(ex, "frmYABE_export_Load")
        End Try

    End Sub

    '#####################################################################
    '# >> aryAuktion wird gefüllt
    '# - chkDelcampe_last_minute
    '# - chkDelcampe_listing_top
    '# - chkDelcampe_privat
    '# - chkDelcampe_startseite
    '# - chkDelcampe_TitelFett
    '# - chkDelcampe_umrandet
    '# - chkDelcampe_untertitel
    '# - ckkDelcampe_category_top
    '#  - chkDelcampe_startseite
    '# - cmbDelcampeDauer = 9 
    ' - 
    '#####################################################################
    Private Function setGUI2CSV() As Boolean
        Try
            '# Last Minute Bidding 
            If chkDelcampe_last_minute.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If

            '# Top Kategorie 
            If chkDelcampe_listing_top.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If

            '# Private Auktion 
            If chkDelcampe_privat.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If

            If chkDelcampe_startseite.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If

            If chkDelcampe_TitelFett.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If

            If chkDelcampe_umrandet.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If

            If chkDelcampe_untertitel.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If


            If chkDelcampe_startseite.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If

            If ckkDelcampe_category_top.Checked = True Then
                aryAuktionData.Add("Y")
            Else
                aryAuktionData.Add("N")
            End If


            aryAuktionData.Add(cmbDelcampeDauer.Text)

            aryAuktionData.Add(cmbDelcampe_auslauftag.SelectedIndex + 1) ' 10 
            aryAuktionData.Add(txtDelcampe_enduhrzeit.Text) ' 11 

            ' Text auswerten 
            Select Case cmbDelcampePlattform.Text
                Case "Nur International"
                    aryAuktionData.Add("IN") ' 12  - Einstellplattform
                Case Else
                    aryAuktionData.Add("GE") ' 12  - Einstellplattform
            End Select

            ' Text auswerten 
            Select Case cmbTextVorlageDelcampe.Text
                Case "Deutsch"
                    aryAuktionData.Add("12_de") ' 13  - Einstellplattform (12_ Vorlage)
                Case Else
                    aryAuktionData.Add("12_eng") ' 13  - Einstellplattform
            End Select

            '# Nur Lokales Bild benutzen 
            aryAuktionData.Add(chkDelcampe_description_no_image.Checked) ' 14 

            aryAuktionData.Add(cmbÜberschriftSprache.Text) ' 15

            aryAuktionData.Add(chkDelcampe3.Checked) ' 16

            aryAuktionData.Add(cmbErneuern.Text) ' 17 Erneuern Anzahl


            If chkDelcampeAuktion.Checked = True Then
                aryAuktionData.Add("Y") ' 18 Auktion / Sofortkauf
            Else
                aryAuktionData.Add("N") ' 18 Auktion / Sofortkauf
            End If

            aryAuktionData.Add(txtDelcampeSteigerung.Text) ' 19 Steigerung

        Catch ex As Exception

        End Try
    End Function
    Private Sub btnOKArtikelID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call setGUI2CSV()

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bAbort = True
        Me.Close()
    End Sub

    '##############################################################
    '# >> 
    '##############################################################
    Private Sub setCHKUpdate()

        If bIsloading = False Then
            bIsloading = True

            If chkDelcampe_listing_top.Checked = True Then
                ckkDelcampe_category_top.Checked = False
                chkDelcampe_startseite.Checked = False
            ElseIf ckkDelcampe_category_top.Checked = True Then
                chkDelcampe_listing_top.Checked = False
                chkDelcampe_startseite.Checked = False
            ElseIf chkDelcampe_startseite.Checked = True Then
                chkDelcampe_listing_top.Checked = False
                ckkDelcampe_category_top.Checked = False
            End If

            bIsloading = False
        End If

    End Sub

    Private Sub chkDelcampe_listing_top_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_listing_top.CheckedChanged
        Call setCHKUpdate()
        My.Settings.yabe_gui_delcampe_export_coast_liste_ganzoben = chkDelcampe_listing_top.Checked
        My.Settings.Save()

    End Sub

    Private Sub ckkDelcampe_category_top_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckkDelcampe_category_top.CheckedChanged
        Call setCHKUpdate()
        My.Settings.yabe_gui_delcampe_export_coast_cat_ganzoben = ckkDelcampe_category_top.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampe_startseite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_startseite.CheckedChanged
        Call setCHKUpdate()
        My.Settings.yabe_gui_delcampe_export_coast_startseite = chkDelcampe_startseite.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampe_untertitel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_untertitel.CheckedChanged

        My.Settings.yabe_gui_delcampe_export_untertitel = chkDelcampe_untertitel.Checked
        My.Settings.Save()

        txtUntertitel.Visible = chkDelcampe_untertitel.Checked

    End Sub

    Private Sub lvwMultiSelect_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwMultiSelect.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Integer
            ' Assign the files to an array. 
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Loop through the array and add the files to the list. 
            For i = 0 To MyFiles.Length - 1
                lvwData_multiselect.Items.Add(MyFiles(i))
            Next
        End If

    End Sub


    Private Sub lvwMultiSelect_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwMultiSelect.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        bOK = True
        Call setGUI2CSV()

        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        bAbort = True
        Me.Close()
    End Sub

    Private Sub cmbDelcampePlattform_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelcampePlattform.SelectedIndexChanged

        '# Wenn International
        If cmbDelcampePlattform.SelectedIndex = 0 Then
            cmbÜberschriftSprache.SelectedIndex = 1  ' Deutsch
            cmbTextVorlageDelcampe.SelectedIndex = 1 ' Deutsch
        Else
            cmbÜberschriftSprache.SelectedIndex = 0 ' Englisch
            cmbTextVorlageDelcampe.SelectedIndex = 0 ' Deutsch
        End If

        My.Settings.yabe_gui_delcampe_export_plattform = cmbDelcampePlattform.SelectedIndex
        My.Settings.Save()

    End Sub

    Private Sub cmbTextVorlageDelcampe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTextVorlageDelcampe.SelectedIndexChanged

    End Sub

    Private Sub chkDelcampe_description_no_image_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_description_no_image.CheckedChanged

    End Sub

    Private Sub cmbDelcampeDauer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelcampeDauer.SelectedIndexChanged
        My.Settings.yabe_gui_delcampe_export_dauer = cmbDelcampeDauer.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub cmbDelcampe_auslauftag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelcampe_auslauftag.SelectedIndexChanged
        My.Settings.yabe_gui_delcampe_export_wochentag = cmbDelcampe_auslauftag.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub txtDelcampe_enduhrzeit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDelcampe_enduhrzeit.LostFocus

        Dim str() As String
        str = txtDelcampe_enduhrzeit.Text.Split(":")
        If Not str.Length = 2 Then
            MsgBox("Es handelt sich bei Ihrer Eingabe um keine gültige Uhrzeit." & vbCrLf & "Bite im Format: hh:mm:ss", MsgBoxStyle.Exclamation)
            txtDelcampe_enduhrzeit.Focus()
        End If

    End Sub

    Private Sub txtDelcampe_enduhrzeit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampe_enduhrzeit.TextChanged

        If bIsloading = False Then
            My.Settings.yabe_gui_delcampe_export_uhrzeit = txtDelcampe_enduhrzeit.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub SelektierteArtikelEntfernenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelektierteArtikelEntfernenToolStripMenuItem.Click
        Dim i As Integer

        For i = 0 To lvwMultiSelect.SelectedItems.Count - 1
            lvwMultiSelect.SelectedItems(0).Remove()
        Next
    End Sub

    Private Sub chkDelcampe_last_minute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_last_minute.CheckedChanged
        My.Settings.yabe_gui_delcampe_export_lastminute = chkDelcampe_last_minute.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampe_TitelFett_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_TitelFett.CheckedChanged
        My.Settings.yabe_gui_delcampe_export_fett = chkDelcampe_TitelFett.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkFluoresierend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFluoresierend.CheckedChanged
        My.Settings.yabe_gui_delcampe_export_fluroeszierend = chkFluoresierend.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampe_umrandet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_umrandet.CheckedChanged
        My.Settings.yabe_gui_delcampe_export_farbig_umrandet = chkDelcampe_umrandet.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnLoadSelectedList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSelectedList.Click

        If btnLoadSelectedList.Text = "Lade Selektierte Artikeliste" Then
            bStopReadInSelected = False
            btnLoadSelectedList.Text = "Abbrechen"
            Call setSelected2Listview(True)
            btnLoadSelectedList.Text = "Lade Selektierte Artikeliste"            
        Else
            bStopReadInSelected = True
            btnLoadSelectedList.Text = "Lade Selektierte Artikeliste"
        End If

    End Sub

    Private Sub frmDelcampe_export_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If bOK = False Then
            bAbort = True
        End If
    End Sub

    Private Sub chkDelcampe3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe3.CheckedChanged
        My.Settings.yabe_gui_delcampe_lister3 = chkDelcampe3.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampeAuktion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampeAuktion.CheckedChanged
        If chkDelcampeAuktion.Checked = True Then
            chkDelcampeAuktion.Text = "&Sofortkauf"
        Else
            chkDelcampeAuktion.Text = "&Auktion"
        End If
        My.Settings.yabe_delcampe_export_sofortkauf = chkDelcampeAuktion.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtDelcampeSteigerung_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampeSteigerung.TextChanged

        If IsNumeric(txtDelcampeSteigerung.Text) = True Then
            txtDelcampeSteigerung.BackColor = Color.White
        Else
            txtDelcampeSteigerung.BackColor = Color.Beige
        End If
        My.Settings.yabe_delcampe_export_steigerung = txtDelcampeSteigerung.Text
        My.Settings.Save()
    End Sub

    Private Sub cmbErneuern_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbErneuern.SelectedIndexChanged
        My.Settings.yabe_delcampe_export_erneuern = cmbErneuern.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub btnDelcampeAPI_Click(sender As System.Object, e As System.EventArgs) Handles btnDelcampeAPI.Click
        Dim strURL As String = ""
        Dim iCount As Integer = 0

        For iCount = 0 To lvwMultiSelect.Items.Count - 1

            If Not lvwMultiSelect.Items(iCount).BackColor = Color.Aqua Then

                frmMain.master_Message_label.Text = iCount + 1 & " von " & lvwMultiSelect.Items.Count
                strURL = My.Settings.shop_url & "/delcampe/index.php?mod=add_fixed&eisoid=" & lvwMultiSelect.Items(iCount).SubItems(0).Text
                strURL &= "&duration=" & cmbDelcampeDauer.Text
                strURL &= "&renew=" & cmbErneuern.Text
                strURL &= "&renew=" & cmbErneuern.Text
                lvwMultiSelect.EnsureVisible(iCount)
                '# Last Minute Bidding 
                If chkDelcampe_last_minute.Checked = True Then
                    strURL &= "&lastm=true"
                Else
                    strURL &= "&lastm=false"
                End If

                '# Top Kategorie 
                If chkDelcampe_listing_top.Checked = True Then
                    strURL &= "&topl=true"
                Else
                    strURL &= "&topl=false"
                End If

                '# Private Auktion 
                If chkDelcampe_privat.Checked = True Then
                    strURL &= "&privat=true"
                Else
                    strURL &= "&privat=false"
                End If


                '# Highlight?
                If chkDelcampe_startseite.Checked = True Then
                    strURL &= "&startseite=true"
                Else
                    strURL &= "&startseite=false"
                End If

                If chkDelcampe_TitelFett.Checked = True Then
                    strURL &= "&bold=true"
                Else
                    strURL &= "&bold=false"
                End If

                If chkDelcampe_umrandet.Checked = True Then
                    strURL &= "&border=true"
                Else
                    strURL &= "&border=false"
                End If

                If chkDelcampe_untertitel.Checked = True Then
                    strURL &= "&subtitle=true"
                    strURL &= "&subtitletxt=" & txtUntertitel.Text
                Else
                    strURL &= "&subtitle=false"
                End If


                'If chkDelcampe_startseite.Checked = True Then
                '    aryAuktionData.Add("Y")
                'Else
                '    aryAuktionData.Add("N")
                'End If

                If ckkDelcampe_category_top.Checked = True Then
                    strURL &= "&topcat=false"
                Else
                    strURL &= "&topcat=true"
                End If

                getHTTPResponseMessage(strURL, mgetUpdaterMessage.setDelcampe_API_add, True)            
                If Not frmMain.master_Message_label.Text.IndexOf("Your request was taken into account!") > 0 Then
                    MessageBox.Show("Fehler Artikel nicht eingestellt", "Delcampe API", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit For
                End If
                lvwMultiSelect.Items(iCount).BackColor = Color.Aqua
                lvwMultiSelect.Items(iCount).Selected = True
                Application.DoEvents()
            End If
        Next
    End Sub
End Class