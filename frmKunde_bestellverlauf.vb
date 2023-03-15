Imports System.Windows.Forms

Public Class frmKunde_bestellverlauf

    Public stremail As String = ""
    Public lvwDataInput As ListView


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    '#####################################################
    '# >> Bestellverlauf 
    '#####################################################
    Public Function getBestellverlauf() As Boolean
        Dim strUserData As ArrayList

        Try

            Select Case lvwDataInput.Name
                Case "lvwEiSoCockpit"
                    stremail = lvwDataInput.SelectedItems(0).SubItems(6).Text
                Case "lvwKunden"
                    strEmail = lvwDataInput.SelectedItems(0).SubItems(2).Text
                Case "lvwBestellverwaltung_nach_artikel"
                    stremail = lvwDataInput.SelectedItems(0).SubItems(9).Text
                Case "lvwBewertungen"
                    stremail = lvwDataInput.SelectedItems(0).SubItems(10).Text
                Case "lvMailStatus"
                    stremail = lvwDataInput.SelectedItems(0).SubItems(2).Text
            End Select

            If stremail.Length > 0 Then

                Call setGUILook(False)

                '# Bestellverlauf abrufen
                clsDatenbank_modul.getListviewData(lvwBestellverlauf, "SELECT * FROM yabe_auction_list_history WHERE email ='" & stremail & "' OR eBay_account='" & stremail & "' ORDER BY auction_end DESC", ImageList1)

                '# Kundendaten abrufen 
                strUserData = clsDatenbank_modul.getYABEUserData(stremail)
                ' Benutzerdaten gefunden
                If strUserData.Count <> 0 Then
                    '# 
                    txtName.Text = strUserData.Item(0).ToString & "' (" & strUserData.Item(3).ToString & ")"
                    txtStraße.Text = strUserData.Item(1).ToString
                    txtOrtPLZ.Text = strUserData.Item(3).ToString & " " & strUserData.Item(2).ToString
                    txtLand.Text = strUserData.Item(5).ToString
                    TextBox1.Text = strUserData.Item(4).ToString
                    TxtUserId.Text = strUserData.Item(6).ToString

                    'txtSprachen.Text = strUserData.Item(7).ToString
                    txtEmail_klicks.Text = strUserData.Item(8).ToString
                    txtEmail_letzte.Text = strUserData.Item(9).ToString


                    txtEmail.Text = strEmail
                Else
                    txtEmail.Text = strEmail
                End If



                lblGesammtsumme.Text = "Artikel:" & lvwBestellverlauf.Items.Count & "x Umsatz:" & clsDatenbank_modul.strOutPut & " €"
                clsDatenbank_modul.dblSumme = 0

                Call frmMain.frmManage.setStatusMessage(lvwBestellverlauf)
                Call setGUILook(True)
                lvwBestellverlauf.Columns(0).Width = 120
            Else
                MsgBox("Keine Übergabe eines Benutzernamens")
            End If


        Catch ex As Exception
            Call setGUILook(True)
            Call debug_message(ex, strQuery & vbCrLf & "getBestellverlauf")
            Return False
        End Try

        Return True

    End Function

    Private Sub frmBestellverlauf_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmBestellverlauf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Size = My.Settings.yabe_gui_bestellverlauf_size
        Me.Location = My.Settings.yabe_gui_bestellverlauf_location

        Call getBestellverlauf()

        Call clsDatenbank_modul.getComboSprachen(cmbSprachenVorlage)

        Dim strSprache As String = clsDatenbank_modul.getCustomer_sprache(txtEmail.Text)

        If strSprache = "Deutsch" Then
            cmbSprachenVorlage.SelectedIndex = 0
        ElseIf strSprache = "Englisch" Then
            cmbSprachenVorlage.SelectedIndex = 1
        ElseIf strSprache = "Französisch" Then
            cmbSprachenVorlage.SelectedIndex = 2
        ElseIf strSprache = "Spanisch" Then
            cmbSprachenVorlage.SelectedIndex = 3
        End If

        If lvwDataInput.SelectedItems(0).Index = 0 Then
            btnBack.Enabled = False
        End If

        If lvwDataInput.SelectedItems(0).Index = lvwDataInput.Items.Count - 1 Then
            btnVor.Enabled = False
        End If


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then


            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False
            iAnzahl -= 1
            btnVor.Enabled = True

 

            Try
                lvwDataInput.Items(iAnzahl).Selected = True
                lvwDataInput.Items(iAnzahl).EnsureVisible()
            Catch ex As Exception
                btnBack.Enabled = False
            End Try

            Call getBestellverlauf()

            Dim strSprache As String = clsDatenbank_modul.getCustomer_sprache(txtEmail.Text)

            If strSprache = "Deutsch" Then
                cmbSprachenVorlage.SelectedIndex = 0
            ElseIf strSprache = "Englisch" Then
                cmbSprachenVorlage.SelectedIndex = 1
            ElseIf strSprache = "Französisch" Then
                cmbSprachenVorlage.SelectedIndex = 2
            ElseIf strSprache = "Spanisch" Then
                cmbSprachenVorlage.SelectedIndex = 3
            ElseIf strSprache = "Russisch" Then
                cmbSprachenVorlage.SelectedIndex = 4
            ElseIf strSprache = "Chinesisch" Then
                cmbSprachenVorlage.SelectedIndex = 5
            End If

            If iAnzahl = -1 Then
                btnBack.Enabled = False
                Exit Sub
            End If

            If iAnzahl = 0 Then
                btnBack.Enabled = False
            Else
                btnBack.Enabled = True
                btnVor.Enabled = True
            End If

        End If
    End Sub

    '# Sperren der GUI 
    Private Sub setGUILook(ByVal bEnabled As Boolean)
        btnVor.Enabled = bEnabled
        btnBack.Enabled = bEnabled
        btnCloseForm.Enabled = bEnabled
    End Sub


    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then


            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False
            iAnzahl += 1
            btnBack.Enabled = True



            Try
                lvwDataInput.Items(iAnzahl).Selected = True
                lvwDataInput.Items(iAnzahl).EnsureVisible()
            Catch ex As Exception
                btnVor.Enabled = False
            End Try



            Call getBestellverlauf()

            Dim strSprache As String = clsDatenbank_modul.getCustomer_sprache(txtEmail.Text)

            If strSprache = "Deutsch" Then
                cmbSprachenVorlage.SelectedIndex = 0
            ElseIf strSprache = "Englisch" Then
                cmbSprachenVorlage.SelectedIndex = 1
            ElseIf strSprache = "Französisch" Then
                cmbSprachenVorlage.SelectedIndex = 2
            ElseIf strSprache = "Spanisch" Then
                cmbSprachenVorlage.SelectedIndex = 3
            ElseIf strSprache = "Russisch" Then
                cmbSprachenVorlage.SelectedIndex = 4
            ElseIf strSprache = "Chinesisch" Then
                cmbSprachenVorlage.SelectedIndex = 5
            End If

            If iAnzahl = lvwDataInput.Items.Count - 1 Then
                btnVor.Enabled = False

            Else
                btnVor.Enabled = True
                btnBack.Enabled = True
            End If

        End If
    End Sub

    Private Sub BestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestelltToolStripMenuItem.Click


        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.bestellt)


    End Sub

    Private Sub BezahltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BezahltToolStripMenuItem.Click

        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.bezahlt)

    End Sub

    Private Sub VerschicktToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerschicktToolStripMenuItem.Click

        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.verschickt)

    End Sub

    Private Sub StorniertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StorniertToolStripMenuItem.Click

        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.storniert)

    End Sub

    Private Sub KomplettToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KomplettToolStripMenuItem.Click

        Call frmMain.frmManage.setStatus_new(lvwBestellverlauf, clsDatenbank.yabe_bestellstatus.komplett)

    End Sub

    Private Sub AnsichtAktuallisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnsichtAktuallisierenToolStripMenuItem.Click
        Call getBestellverlauf()

    End Sub

    Private Sub YABERechnungsdruckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABERechnungsdruckToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then

            Dim frmYABE_Rechnungsdruck As New frmYABE_Rechnungsdruck
            frmYABE_Rechnungsdruck.lvwDataInput = lvwBestellverlauf
            frmYABE_Rechnungsdruck.Show(Me)

        End If
    End Sub

    Private Sub KopierenEmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenEmailToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwBestellverlauf.SelectedItems(0).SubItems(10).Text)
        End If
    End Sub

    Private Sub KopierenArtikelnummerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenArtikelnummerToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwBestellverlauf.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub KopierenMitgliedsnameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenMitgliedsnameToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwBestellverlauf.SelectedItems(0).SubItems(9).Text)
        End If
    End Sub

    Private Sub ÜbersichtExportierenZumDruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÜbersichtExportierenZumDruckenToolStripMenuItem.Click
        Call frmMain.frmManage.export(lvwBestellverlauf)
    End Sub

    Private Sub MakierenAlleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakierenAlleToolStripMenuItem.Click
        Dim iCount As Integer = 0

        For iCount = 0 To lvwBestellverlauf.Items.Count - 1
            lvwBestellverlauf.Items(iCount).Selected = True
        Next

    End Sub

    Private Sub SucheBestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheBestellungenToolStripMenuItem.Click

        If lvwBestellverlauf.SelectedItems.Count > 0 Then
            frmMain.frmManage.txtSuchen.Text = lvwBestellverlauf.SelectedItems(0).SubItems(10).Text
            frmMain.frmManage.tabMenue.SelectedIndex = 2
            frmMain.frmManage.btnSuchen.PerformClick()
        End If

    End Sub

    Private Sub lvwBestellverlauf_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwBestellverlauf.ColumnClick
        Call frmMain.frmManage.setSort(lvwBestellverlauf, e)
    End Sub

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then

            If MsgBox("Möchten Sie den Artikel '" & lvwBestellverlauf.SelectedItems(0).SubItems(1).Text & "' wirklich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If clsDatenbank_modul.setDeleteReal(lvwBestellverlauf.SelectedItems(0).Text, "yabe_auction_list_history") = True Then
                    lvwBestellverlauf.SelectedItems(0).Remove()
                End If

            End If

        End If
    End Sub

    Private Sub SucheKundeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheKundeToolStripMenuItem.Click
        If txtEmail.Text.Length > 0 Then
            frmMain.frmManage.txtSuchen.Text = txtEmail.Text
            frmMain.frmManage.tabMenue.SelectedIndex = 1
            frmMain.frmManage.btnSuchen.PerformClick()
        End If

    End Sub

    Private Sub SucheArtikelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheArtikelToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then

            If IsNumeric(lvwBestellverlauf.SelectedItems(0).Text) = True Then
                frmMain.frmManage.txtSuchen.Text = lvwBestellverlauf.SelectedItems(0).Text
            Else
                frmMain.frmManage.txtSuchen.Text = lvwBestellverlauf.SelectedItems(0).SubItems(1).Text
            End If

            frmMain.frmManage.tabMenue.SelectedIndex = 4
            frmMain.frmManage.btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub YABEArtikelansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEArtikelansichtToolStripMenuItem.Click
        '# 
        If lvwBestellverlauf.SelectedItems.Count > 0 Then
            Dim frmWeb As New frmYABE_WebBrowser

            '# Welche Plattform 
            Select Case lvwBestellverlauf.SelectedItems(0).SubItems(6).Text

                Case "eBay"
                    ' Bestellungen Status auswerten 
                    Select Case lvwBestellverlauf.SelectedItems(0).SubItems(4).Text
                        Case "Bestellt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                        Case "Verschickt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                    End Select


                Case "delcampe"

                    ' Bestellungen Status auswerten 
                    Select Case lvwBestellverlauf.SelectedItems(0).SubItems(4).Text
                        Case "Bestellt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_versand
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                        Case "Verschickt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                    End Select

                    ' Andere Plattform 
                Case Else

            End Select

            frmWeb.lvwDataView = lvwBestellverlauf
            frmWeb.Show(Me)

        End If
    End Sub

    Private Sub frmBestellverlauf_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.yabe_gui_bestellverlauf_size = Me.Size
        My.Settings.yabe_gui_bestellverlauf_location = Me.Location
        My.Settings.Save()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        'If lvwDataInput.SelectedItems.Count > 0 Then

        Dim frmKundenEdit As New frmYABE_Kundenverwaltung
        frmKundenEdit.lvwDataInput = lvwDataInput
        frmKundenEdit.bNoNext = True
        frmKundenEdit.strLoadEmail = txtEmail.Text
        frmKundenEdit.ShowDialog()
        'End If

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub


    Private Sub lvwBestellverlauf_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwBestellverlauf.SelectedIndexChanged

    End Sub

    Private Sub CockpitArtikelErneutVersendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CockpitArtikelErneutVersendenToolStripMenuItem.Click
        If lvwBestellverlauf.SelectedItems.Count > 0 Then

            If MsgBox("Möchten Sie den Artikel '" & lvwBestellverlauf.SelectedItems(0).SubItems(1).Text & "' wirklich zurück in die Cockpit Ansicht aufnehmen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sync - History => Cockpit") = MsgBoxResult.Yes Then

                Dim iCount As Integer
                For iCount = 0 To lvwBestellverlauf.SelectedItems.Count - 1

                    '#########################################
                    '# Holt Makierten Artikel zurück 
                    '#########################################
                    If clsDatenbank_modul.setSYNC_History_live(lvwBestellverlauf.SelectedItems(iCount).Text) = True Then
                        'lvwArtikelListe.SelectedItems(0).Remove()
                        lvwBestellverlauf.SelectedItems(iCount).SubItems(4).Text = lvwBestellverlauf.SelectedItems(iCount).SubItems(4).Text.Replace("history", "live")

                        Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)
                        Call frmMain.frmManage.getRadioOptions_counts("lvweBayLiveList")

                    End If


                Next

            End If ' Frage 



        End If ' Prüfung mehr als 0 

    End Sub
End Class
