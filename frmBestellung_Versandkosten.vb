Imports eBay.Service.Core.Soap

Public Class frmBestellung_Versandkosten

    Public strEmail As String = ""
    Dim bChange As Boolean = False
    Dim bIsloading As Boolean = False
    Dim bIsLoadingRabatt As Boolean = False
    Enum mModus
        live = 0
        history = 1
    End Enum

    Public mModusSelect As mModus

    Public lvwDataInput As ListView ' Zentrales Datenobjekt 


    Private Sub frmVersandkostenanzeige_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If bChange = True Then

            Select Case mModusSelect
                Case mModus.live
                    Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)
                    Call frmMain.frmManage.setStatusMessage(frmMain.frmManage.lvwEiSoCockpit)
                Case mModus.history
                    Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwBestellverwaltung_nach_artikel)
                    Call frmMain.frmManage.setStatusMessage(frmMain.frmManage.lvwBestellverwaltung_nach_artikel)
            End Select


        End If
    End Sub

    Private Sub frmVersandkostenanzeige_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub frmVersandkostenanzeige_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            If My.Settings.eiso_gui_eiso_versandart_anzeigen = True Then
                lblEiSoVersandarten.Visible = True
                cmbVersandart.Visible = True
            Else
                lblEiSoVersandarten.Visible = False
                cmbVersandart.Visible = False
            End If

            RechnungDirektAusdruckenToolStripMenuItem.Checked = My.Settings.gui_eiso_rechnungsdruck_druckansicht
            chkPrintRechnung.Checked = My.Settings.gui_eiso_rechnungsdruck_druckansicht

            '##########################################################################################
            '# >> Aufnahme der Artikel zu Bestellungen....
            '##########################################################################################
            Select Case clsDatenbank_modul.setBestellungen_Orderlist_insert()
                Case "true"
                    If frmMain.frmManage.chkAutomatischerModus.Checked = False Then
                        frmMain.frmManage.tabMenue.SelectedIndex = 2
                        Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)
                        Call frmMain.frmManage.setStatusMessage(frmMain.frmManage.lvwEiSoCockpit)
                        Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwBestellverwaltung_nach_artikel)
                        Call frmMain.frmManage.setStatusMessage(frmMain.frmManage.lvwBestellverwaltung_nach_artikel)

                        MessageBox.Show("Alle Artikel wurden erfolgreich zu den Bestellungen synchronisiert", "EiSo Bestellungen Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    End If
                Case "false"

                    MessageBox.Show("Das synchronisieren mit der EiSo Bestellungen  wurde unterbrochen", "EiSo Bestellungen Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Case "-1"
                    If frmMain.frmManage.chkAutomatischerModus.Checked = False Then
                        MessageBox.Show("Es gab keine YABE Artikel für die Synchronisation mit den Bestellungen", "EiSo Bestellungen  Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select

            Dim dtp_von As New DateTimePicker
            Dim dtp_bis As New DateTimePicker

            dtp_von.Value = Date.Now
            dtp_bis.Value = Date.Now.AddDays(1)

            Dim shpsvcs As Type = GetType(ShippingServiceCodeType)
            Dim svc As String

            For Each svc In [Enum].GetNames(shpsvcs)
                If svc <> "CustomCode" Then
                    If svc.IndexOf("DE_") >= 0 Then
                        cmbeBayVersandart.Items.Add(svc)
                    End If
                End If
            Next svc

            cmbeBayVersandart.SelectedIndex = 0

            clsDatenbank_modul.getComboSprachen(cmbSprachenVorlage)

            clsDatenbank_modul.getComboVersandkosten(cmbVersandart)
            Try
                cmbVersandart.SelectedIndex = 0
            Catch ex As Exception

            End Try


            '# Modus auswerten 
            Select Case mModusSelect
                Case mModus.history

                Case mModus.live

                    If lvwDataInput.SelectedItems(0).SubItems(17).Text = "eBay" Then
                        ' If Not (MsgBox("eBay Kundenadressen vom '" & dtp_von.Value & "' bis zum '" & dtp_bis.Value & "' holen ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "eBay Kundenadressen holen") = MsgBoxResult.Yes) Then

                        'Else
                        If lvwDataInput.Name = "lvwBestellverwaltung_nach_artikel" Then
                            frmMain.frmManage.getSellerTransaction(dtp_von, dtp_bis)
                        Else
                            frmMain.frmManage.getSellerTransaction(dtp_von, dtp_bis)
                        End If

                        'End If
                    End If

            End Select



            If strEmail.Length = 0 Then
                If lvwDataInput.SelectedItems.Count > 0 Then

                    '# Modus auswerten 
                    Select Case mModusSelect
                        Case mModus.history
                            Me.Text = "EiSo - Bestellungen -> " & lvwDataInput.SelectedItems(0).SubItems(2).Text & " von " & lvwDataInput.SelectedItems(0).SubItems(17).Text
                            strEmail = lvwDataInput.SelectedItems(0).SubItems(2).Text
                        Case mModus.live
                            Me.Text = "EiSo - Aufträge -> Auktionsende Versandkosten eingeben " & lvwDataInput.SelectedItems(0).SubItems(5).Text
                            strEmail = lvwDataInput.SelectedItems(0).SubItems(6).Text
                    End Select

                End If

            End If


            Select Case mModusSelect

                Case mModus.history
                    If clsDatenbank_modul.getUniqueBuyer_lvw(lvwKundenliste, strEmail, mModusSelect.ToString, ImageList2) = True Then
                        'MsgBox("Es wurden alle Käuferdaten ermittelt", MsgBoxStyle.Information)

                    Else
                        MsgBox("Es gab einen Fehler beim Abruf der Käuferdaten", MsgBoxStyle.Exclamation)
                    End If

                Case mModus.live
                    If clsDatenbank_modul.getUniqueBuyer_lvw(lvwKundenliste, lvwDataInput.SelectedItems(0).SubItems(5).Text, mModusSelect.ToString, ImageList2) = True Then

                    End If

            End Select

        Catch ex As Exception
            Call debug_message(ex)
        End Try
    End Sub

    Private Sub setGUI_enabled(ByVal bModus As Boolean)

        lvwKundenliste.Enabled = bModus
        txtBenutzername.Enabled = bModus
        txtAnschrift.Enabled = bModus
        txtEmail.Enabled = bModus
        txtEmail.Enabled = bModus
        txtVersandkosten.Enabled = bModus
        txtEndbetrag.Enabled = bModus
        btnSaveShippment.Enabled = bModus
        btnClose.Enabled = bModus
        lbleBayVersand.Enabled = bModus
        lvwArtikelListe.Enabled = bModus
        txtLand.Enabled = bModus
        chkPaypalMit.Enabled = bModus
        txtMitPaypal.Enabled = bModus

    End Sub



    Private Sub lvwKundenliste_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwKundenliste.SelectedIndexChanged
        Dim aryList As New ArrayList
        Dim aryKunde As New ArrayList
        Dim strKundenDetails() As String

        If bIsloading = False Then

            bIsloading = True
            chkeBayInternational.Checked = False
            bIsloading = False

            '# Nur wenn wirklich selektiert wurde 
            If lvwKundenliste.SelectedItems.Count > 0 Then

                Call setGUI_enabled(False)

                '# Verkaufte Artikel anzeigen 
                lvwArtikelListe.Items.Clear()
                Application.DoEvents()

                chkPaypalMit.Checked = False

                If chkPaypalMit.Checked = True Then
                    txtMitPaypal.Text = setCalcPaypal(txtUmsatz.Text, txtVersandkosten.Text)
                Else
                    txtMitPaypal.Text = "0"
                    txtMitPaypal.Enabled = False
                End If


                If clsDatenbank_modul.getSoldItemsbyEmail(lvwKundenliste.SelectedItems(0).SubItems(3).Text, lvwArtikelListe, aryList, mModusSelect.ToString, ImageList2) = True Then

                    If mModusSelect = mModus.live Then
                        Call clsDatenbank_modul.getSoldItemsbyEmail(lvwKundenliste.SelectedItems(0).SubItems(3).Text, lvwArtikelListe, aryList, "history", ImageList2)
                    End If
                    '# Status im Hauptfenster von YABE ändern 
                    Call frmMain.frmManage.setStatusMessage(lvwArtikelListe)

                    txtBenutzername.Text = aryList.Item(0).ToString
                    txtEmail.Text = aryList.Item(1).ToString

                    ' eBay Weg
                    'aryKunde = clseBayAPI.geteBayUser(lvwArtikelListe.SelectedItems(0).SubItems(0).Text, aryList.Item(0).ToString)

                    ' Datenbank Weg 
                    ReDim strKundenDetails(10)
                    '# Kundenprofil abrufen 
                    Dim strMembername As String = lvwKundenliste.SelectedItems(0).SubItems(0).Text
                    strKundenDetails = clsDatenbank_modul.getEiSoIsCostumerAdressByEmailOrID(lvwKundenliste.SelectedItems(0).SubItems(3).Text)

                    If strKundenDetails.Length >= 2 Then
                        txtLand.Text = strKundenDetails(3)
                        txtAnschrift.Text = strKundenDetails(1)
                        txtBenutzername.Text = strKundenDetails(0)
                        txtCountryCode.Text = strKundenDetails(4)
                        txtOrt.Text = strKundenDetails(5) & " " & strKundenDetails(7)
                    End If

                    Dim strKaufAnzahl_summe As String = clsDatenbank_modul.getEiSoBestellungen_kunde_summe(lvwKundenliste.SelectedItems(0).SubItems(3).Text)
                    Dim strKäufe_anzahl As String = clsDatenbank_modul.getEiSoBestellungen_kunde_anzahl_artikel(lvwKundenliste.SelectedItems(0).SubItems(3).Text)
                    Dim strItem_last(3) As String
                    strItem_last = clsDatenbank_modul.getEiSoBestellungen_kunde_last_order(lvwKundenliste.SelectedItems(0).SubItems(3).Text)
                    Dim days As Double
                    Try

                        Dim date1 As Date = Date.Now
                        Dim date2 As Date = strItem_last(0)

                        Dim span = date1 - date2

                        days = Math.Round(span.TotalDays, 0)
                    Catch ex As Exception

                    End Try
                    If strItem_last(0) = Nothing Then
                        lbl_kunden_stat.Text = "Hat noch nie bei Ihnen eingekauft"
                    Else
                        lbl_kunden_stat.Text = "Letzter Kauf am: " & strItem_last(0) & " (Tage " & days & " her)" & vbCrLf & "Letzte Plattform: " & strItem_last(3) & vbCrLf & "Vorher gekaufte Artikel: " & strKäufe_anzahl & "x" & vbCrLf & "Vorher Umsatz gesamt: " & strKaufAnzahl_summe & " €" ' & " | " & strItem_last(1) & " für " & strItem_last(2) & " € "

                    End If

                    txtVersandkosten.Text = aryList.Item(2).ToString.Replace(".", ",")
                    txtUmsatz.Text = aryList.Item(3).ToString.Replace(".", ",")
                    txtEndbetrag.Text = aryList.Item(4).ToString.Replace(".", ",")

                    If Not aryList.Item(5).ToString = "0" Then
                        chkPaypalMit.Checked = True
                        txtMitPaypal.Text = aryList.Item(5).ToString
                        txtMitPaypal.Text = setCalcPaypal(txtUmsatz.Text, txtVersandkosten.Text)
                    End If

                    If Not txtLand.Text = "Deutschland" Then
                        chkeBayInternational.Checked = True
                    End If

                    Dim iLoop As Integer = 0
                    Dim strDatum As DateTime
                    Dim strDatumEnde As DateTime

                    Call geteBayVersandkostenAPI()

                    '# Selektieren der Bestellungen JETZT - 1 Tag
                    For iLoop = 0 To lvwArtikelListe.Items.Count - 1
                        Try
                            strDatum = Convert.ToDateTime(lvwArtikelListe.Items(iLoop).SubItems(7).Text)
                        Catch ex As Exception
                            strDatum = "2011-01-01 12:00:00"
                        End Try

                        If iLoop = 0 Then
                            strDatumEnde = strDatum.AddDays(-1)
                        End If

                        If strDatumEnde < strDatum And lvwArtikelListe.Items(iLoop).SubItems(5).Text = "eBay - live" Then
                            lvwArtikelListe.Items(iLoop).Selected = True
                        End If
                    Next
                    ToolStripStatusLabel1.Text = lvwArtikelListe.SelectedItems.Count - 1 & "x Artikel ausgewählt"
                    lvwArtikelListe.Columns(4).Width = 0

                Else
                    MsgBox("Es ist leider ein Fehler beim abrufen der Artikeldaten aufgetreten", MsgBoxStyle.Critical)
                    Call setGUI_enabled(True)
                End If
            End If

            Call setGUI_enabled(True)
            lvwArtikelListe.Columns(0).Width = 120
        End If

    End Sub

    Private Sub EBayKundeninformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnSaveShippment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveShippment.Click

        Dim bStatus As Boolean = False
        '# Liegt kein Fehler vor (Farbe) 
        txtVersandkosten.Text = txtVersandkosten.Text.Replace("'", "")
        txtMitPaypal.Text = txtMitPaypal.Text.Replace("'", "")
        btnSaveShippment.Enabled = False
        txtUmsatz.Enabled = False
        txtMitPaypal.Enabled = False
        txtEndbetrag.Enabled = False


        bChange = True

        '# Profildaten speichern
        clsDatenbank_modul.setCustomer_muttersprache(txtEmail.Text, cmbSprachenVorlage.Text)

        ' Eintrag Selektiert 
        If lvwKundenliste.SelectedItems.Count < 0 Or lvwArtikelListe.SelectedItems.Count < 0 Then
            lvwKundenliste.SelectedItems(0).BackColor = Color.Wheat
            Exit Sub
        End If

        If chkPaypalMit.Checked = True Then
            txtMitPaypal.Text = setCalcPaypal(txtUmsatz.Text, txtVersandkosten.Text)
            txtMitPaypal.Enabled = True
        Else
            txtMitPaypal.Text = "0"
            txtMitPaypal.Enabled = False
        End If

        If Not lvwArtikelListe.SelectedItems.Count > 0 Then
            If lvwArtikelListe.Items.Count > 0 Then
                lvwArtikelListe.Items(0).Selected = True
            End If
        End If

        Dim oItem As MyListItem = CType(cmbVersandart.SelectedItem, MyListItem)

        If Convert.ToDouble(txtRabatt.Text) > 0 Then

            clsDatenbank_modul.setEiSoOrderTable(lvwArtikelListe.SelectedItems(0).SubItems(12).Text, txtVersandkosten.Text, txtUmsatz.Text, txtRabattPaypal.Text, txtRabattEndsumme.Text, txtRabatt.Text, txtRabattEUR.Text, oItem.Value)
        Else
            clsDatenbank_modul.setEiSoOrderTable(lvwArtikelListe.SelectedItems(0).SubItems(12).Text, txtVersandkosten.Text, txtUmsatz.Text, txtMitPaypal.Text, txtEndbetrag.Text, txtRabatt.Text, txtRabattEUR.Text, oItem.Value)
        End If


        bStatus = clsDatenbank_modul.setUpdateVersandkosten(lvwArtikelListe.SelectedItems(0).Text, txtVersandkosten.Text, mModusSelect.ToString, txtMitPaypal.Text)

        If lvwArtikelListe.SelectedItems.Count > 0 Then
            If lvwArtikelListe.SelectedItems(0).SubItems(5).Text = "eBay - Aufträge" Then
                btnCreateOrder.PerformClick()
                clseBayAPI.setSendInvoice(Me)
            End If
        End If

        If My.Settings.eiso_gui_eiso_versandkosten_rechnung_drucken = True Then
            Dim frmRechnung As New frmYABE_Rechnungsdruck
            frmRechnung.lvwDataInput = lvwArtikelListe
            frmRechnung.ShowDialog(Me)
        End If

        If bStatus = True Then
            Dim strAddMessage As String = ""
            If RechnungDirektAusdruckenToolStripMenuItem.Checked = True Then
                strAddMessage = vbCrLf & "+ Die Rechnung wird jetzt erstellt."
            End If
            MessageBox.Show("Artikel Versandinformationen wurden erfolgreich aktualisiert!" & strAddMessage, "EiSo - Versandkosten + Rechnungsdruck", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim iAnzahl As Integer = 0

            If lvwKundenliste.SelectedItems.Count > 0 Then

                iAnzahl = lvwKundenliste.SelectedItems(0).Index
                iAnzahl += 1

                Try
                    txtOrderID.Text = ""
                    lvwKundenliste.Items(iAnzahl).Selected = True
                    lvwKundenliste.Items(iAnzahl).EnsureVisible()
                Catch ex As Exception

                End Try


            End If


        End If



        btnSaveShippment.Enabled = True
        txtUmsatz.Enabled = True
        txtEndbetrag.Enabled = True

        ' Rechnung direkt nach Erstellen drucken
        If RechnungDirektAusdruckenToolStripMenuItem.Checked = True Then

            Dim iCount As Integer = 0
            lvwDataInput.BeginUpdate()
            If lvwDataInput.SelectedItems.Count < 3 Then
                For iCount = 0 To lvwDataInput.Items.Count - 1
                    lvwDataInput.Items(iCount).Selected = True
                    Application.DoEvents()
                Next
            End If
            lvwDataInput.EndUpdate()

            Dim frmYABE_Rechnungsdruck As New frmYABE_Rechnungsdruck
            frmYABE_Rechnungsdruck.lvwDataInput = lvwArtikelListe
            frmYABE_Rechnungsdruck.Show(Me)
        End If

        txtVersandkosten.Focus()

    End Sub

    Private Sub txtVersandkosten_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVersandkosten.Leave

        Call checkEndpreis()

    End Sub
    Private Sub checkEndpreis()
        '# Handelt es sich um eine Zahl
        If IsNumeric(txtVersandkosten.Text) Then
            ' Endbetrag neu ausrechnen            
            txtEndbetrag.Text = Convert.ToDouble(txtUmsatz.Text.Replace(".", ",")) + Convert.ToDouble(txtVersandkosten.Text.Replace(".", ","))
            txtVersandkosten.BackColor = Color.White

            If chkPaypalMit.Checked = True Then
                txtMitPaypal.Text = setCalcPaypal(txtUmsatz.Text, txtVersandkosten.Text)
            End If

        Else
            txtVersandkosten.BackColor = Color.Crimson
        End If
    End Sub

    Private Sub txtVersandkosten_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVersandkosten.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call checkEndpreis()
        End If
    End Sub

    Private Sub BildanzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BildanzeigenToolStripMenuItem.Click
        If lvwArtikelListe.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = lvwArtikelListe.SelectedItems(0).SubItems(4).Text
            ExterneAnwendung.Start()
        End If
    End Sub

    Private Sub EBayArtikelAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayArtikelAnzeigenToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()

        If lvwArtikelListe.SelectedItems.Count > 0 Then

            If lvwArtikelListe.SelectedItems(0).SubItems(5).Text = "delcampe" Then
                ExterneAnwendung.StartInfo.FileName = "http://www.delcampe.de/item.php?language=G&id=" & lvwArtikelListe.SelectedItems(0).SubItems(0).Text
            Else
                ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwArtikelListe.SelectedItems(0).SubItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
            End If


            ExterneAnwendung.Start()
        End If
    End Sub

    Private Sub lvwKundenliste_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwKundenliste.ColumnClick
        Try
            bIsloading = True
            Call frmMain.frmManage.setSort(lvwKundenliste, e)
            bIsloading = False
        Catch ex As Exception
            Call debug_message(ex, "Versandkostenberechnung")
        End Try

    End Sub

    Private Sub lvwArtikelListe_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwArtikelListe.ColumnClick
        Try
            Call frmMain.frmManage.setSort(lvwArtikelListe, e)
        Catch ex As Exception
            Call debug_message(ex, "Versandkostenberechnung - lvwArtikelListe")
        End Try
    End Sub


    Private Sub chkPaypalMit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaypalMit.CheckedChanged

        txtMitPaypal.Enabled = chkPaypalMit.Checked

        If chkPaypalMit.Checked = True Then
            getPayPalSum()
        Else
            txtMitPaypal.Text = "0"
        End If


    End Sub


    Public Function getPayPalSum() As Boolean
        If My.Settings.yabe_paypal_emailusername.Length = 0 Then
            MessageBox.Show("Bitte Paypal Email-Adresse hinzufügen unter EiSo Werkzeuge -> EiSo Einstellungen -> Allgemein -> Paypal Emailadresse")
            chkPaypalMit.Checked = False
            My.Settings.gui_options_last_tab = optionGUI_Tab_ID.paypal

            Exit Function
        End If

        '# Berechnungsmodus aktiv 
        If My.Settings.APP_paypal_aktiv = True Then
            txtMitPaypal.Text = setCalcPaypal(txtUmsatz.Text, txtVersandkosten.Text)
            If Convert.ToDouble(txtRabattEUR.Text) > 0 Then
                txtRabattPaypal.Text = setCalcPaypal(txtArtikelsummeRabatt.Text, txtVersandkosten.Text)
            End If
        Else
            txtMitPaypal.Text = txtEndbetrag.Text '# Endbetrag => Paypalsumme
        End If

    End Function

    Private Sub lvwArtikelListe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwArtikelListe.SelectedIndexChanged

        If lvwArtikelListe.SelectedItems.Count > 0 Then
            Dim str() As String = lvwArtikelListe.SelectedItems(0).SubItems(5).Text.Split("-")
            LinkLabel1.Text = str(0) & "Versand"
            Select Case str(0)
                Case "delcampe "
                    chkeBayInternational.Visible = False
                    lbleBayVersandkosten.Visible = False
                    LinkLabel1.Visible = True
                    EBayArtikelinformationToolStripMenuItem.Visible = False
                    ToolStripSeparator3.Visible = False
                    cmbeBayVersandart.Visible = False
                Case "eBay "
                    chkeBayInternational.Visible = True
                    lbleBayVersandkosten.Visible = True
                    LinkLabel1.Visible = True
                    cmbeBayVersandart.Visible = True
                    EBayArtikelinformationToolStripMenuItem.Visible = True
                    ToolStripSeparator3.Visible = True
                Case "CMS "
                    chkeBayInternational.Visible = False
                    lbleBayVersandkosten.Visible = False
                    LinkLabel1.Visible = False
                    EBayArtikelinformationToolStripMenuItem.Visible = False
                    ToolStripSeparator3.Visible = False
                    cmbeBayVersandart.Visible = False
                Case "Shopste "
                    chkeBayInternational.Visible = False
                    lbleBayVersandkosten.Visible = False
                    LinkLabel1.Visible = False
                    EBayArtikelinformationToolStripMenuItem.Visible = False
                    ToolStripSeparator3.Visible = False
                    cmbeBayVersandart.Visible = False
                Case "Magento "
                    chkeBayInternational.Visible = False
                    lbleBayVersandkosten.Visible = False
                    LinkLabel1.Visible = False
                    EBayArtikelinformationToolStripMenuItem.Visible = False
                    ToolStripSeparator3.Visible = False
                    cmbeBayVersandart.Visible = False
            End Select
        End If

    End Sub

    Private Sub YABEKundenverlaufToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEKundenverlaufToolStripMenuItem.Click

    End Sub

    Private Sub EBayInformationenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayInformationenToolStripMenuItem.Click
        Dim str() As String

        If lvwKundenliste.SelectedItems.Count > 0 Then
            Dim frmHöchstbietender As New FrmGetUser
            frmHöchstbietender.TxtItemId.Text = lvwArtikelListe.Items(0).Text
            str = txtBenutzername.Text.Split(" ")
            frmHöchstbietender.TxtUserId.Text = str(0)
            frmHöchstbietender.ShowDialog()
        End If
    End Sub

    Private Sub SucheKundenbestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheKundenbestellungenToolStripMenuItem.Click

        Select Case mModusSelect

            Case mModus.history

                frmMain.frmManage.txtSuchen.Text = txtEmail.Text
                frmMain.frmManage.tabMenue.SelectedIndex = 2
                frmMain.frmManage.btnSuchen.PerformClick()

            Case mModus.live
                frmMain.frmManage.txtSuchen.Text = txtEmail.Text
                frmMain.frmManage.tabMenue.SelectedIndex = 2
                frmMain.frmManage.btnSuchen.PerformClick()


        End Select
    End Sub

    Private Sub BewertetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BewertetToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwArtikelListe, clsDatenbank.yabe_bestellstatus.bestellt)
    End Sub

    Private Sub BezahltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BezahltToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwArtikelListe, clsDatenbank.yabe_bestellstatus.bezahlt)
    End Sub

    Private Sub VerschicktToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerschicktToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwArtikelListe, clsDatenbank.yabe_bestellstatus.verschickt)
    End Sub

    Private Sub CompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwArtikelListe, clsDatenbank.yabe_bestellstatus.komplett)
    End Sub

    Private Sub StorniertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StorniertToolStripMenuItem.Click
        Call frmMain.frmManage.setStatus_new(lvwArtikelListe, clsDatenbank.yabe_bestellstatus.storniert)
    End Sub

    Private Sub BestellungArtikelNochmalVersendenliveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestellungArtikelNochmalVersendenliveToolStripMenuItem.Click
        If lvwArtikelListe.SelectedItems.Count > 0 Then

            If MsgBox("Möchten Sie den Artikel '" & lvwArtikelListe.SelectedItems(0).SubItems(1).Text & "' wirklich zurück in die Aufträge verschieben?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sync - Bestellungen => Aufträge") = MsgBoxResult.Yes Then

                Dim iCount As Integer
                For iCount = 0 To lvwArtikelListe.SelectedItems.Count - 1

                    '#########################################
                    '# Holt Makierten Artikel zurück 
                    '#########################################
                    If clsDatenbank_modul.setSYNC_History_live(lvwArtikelListe.SelectedItems(iCount).Text) = True Then
                        'lvwArtikelListe.SelectedItems(0).Remove()
                        lvwArtikelListe.SelectedItems(iCount).SubItems(5).Text = lvwArtikelListe.SelectedItems(iCount).SubItems(5).Text.Replace("history", "live")
                        Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)
                        Call frmMain.frmManage.getRadioOptions_counts("lvweBayLiveList")
                    End If


                Next

            End If ' Frage 



        End If ' Prüfung mehr als 0 

    End Sub

    Private Sub BestellungLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestellungLöschenToolStripMenuItem.Click
        If lvwArtikelListe.SelectedItems.Count > 0 Then


            If Not lvwArtikelListe.SelectedItems(0).Text = "" Then

                If MessageBox.Show("Wollen Sie die '" & lvwArtikelListe.SelectedItems(0).SubItems(5).Text & "' Bestellung vom Kunden '" & txtAnschrift.Text & vbCrLf & "Artikel: '" & lvwArtikelListe.SelectedItems(0).SubItems(1).Text & "' wirklich unwiderruflich löschen?", "Bestellung löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim iCount As Integer
                    For iCount = 0 To lvwArtikelListe.SelectedItems.Count - 1

                        If clsDatenbank_modul.setDeleteReal(lvwArtikelListe.SelectedItems(iCount).Text, "yabe_auction_list_history") = True Then
                            lvwArtikelListe.SelectedItems(iCount).Remove()
                        End If

                    Next

                End If

            End If
        End If
    End Sub

    Private Sub SucheKundenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheKundenToolStripMenuItem.Click

        If lvwKundenliste.SelectedItems.Count > 0 Then

            frmMain.frmManage.txtSuchen.Text = txtEmail.Text
            frmMain.frmManage.tabMenue.SelectedIndex = 1
            frmMain.frmManage.btnSuchen.PerformClick()

        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub conArtikelliste_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles conArtikelliste.Opening
        If lvwArtikelListe.SelectedItems.Count > 0 Then


            If lvwArtikelListe.SelectedItems(0).SubItems(5).Text.Contains("history") > -1 Then
                BestellungArtikelNochmalVersendenliveToolStripMenuItem.Visible = False
            Else
                BestellungArtikelNochmalVersendenliveToolStripMenuItem.Visible = True
            End If

        End If
    End Sub

    '########################################################################
    '# >> eBay Versandmethode setzen 
    '########################################################################
    Private Function setVersandMethode(strVersandCode As String) As Boolean
        Try
            Dim iCount As Integer = 0
            cmbeBayVersandart.Enabled = False
            For iCount = 0 To cmbeBayVersandart.Items.Count - 1
                If strVersandCode = cmbeBayVersandart.Items(iCount).ToString Then
                    cmbeBayVersandart.Enabled = True
                    cmbeBayVersandart.SelectedIndex = iCount
                    Exit Function
                End If
            Next
            cmbeBayVersandart.Enabled = True
            Return True
        Catch ex As Exception
            cmbeBayVersandart.Enabled = True
            debug_message(ex, "setVersandMethode")
            Return False
        End Try
    End Function
    Private Function geteBayVersandkostenAPI() As Boolean
        Try
            Dim ebay As New clseAPI_eBay
            Dim shippmentItem As New eBay.Service.Core.Soap.ShippingDetailsType
            Dim item As New eBay.Service.Core.Soap.ItemType
            Dim strVersand(1) As String
            'item = ebay.getItemInfo(lvwArtikelListe.SelectedItems(0).Text)
            'item = 

            If My.Settings.anmeldung_postleitzahl.Length = 0 Then
                MessageBox.Show("Keine PLZ unter 'Persönliche Daten' eingetragen! Bitte nachholen!", "Keine PLZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Function
            End If

            If bIsloading = False Then

                chkeBayInternational.Enabled = False

                If lvwArtikelListe.SelectedItems.Count > 0 Then

                    If lvwArtikelListe.SelectedItems(0).SubItems(5).Text.Contains("eBay") = True Then

                        If chkeBayInternational.Checked = True Then

                            If txtCountryCode.Text.Length > 0 Then
                                Dim country As eBay.Service.Core.Soap.CountryCodeType
                                country = Convert.ToInt16(txtCountryCode.Text)
                                strVersand = ebay.getShippment(lvwArtikelListe.SelectedItems(0).Text, "1", My.Settings.anmeldung_postleitzahl, country)
                                Call setVersandMethode(strVersand(0))
                                txtVersandkosten.Text = strVersand(1)
                            Else
                                strVersand = ebay.getShippment(lvwArtikelListe.SelectedItems(0).Text, "1", My.Settings.anmeldung_postleitzahl, Global.eBay.Service.Core.Soap.CountryCodeType.SE)
                                Call setVersandMethode(strVersand(0))
                                txtVersandkosten.Text = strVersand(1)
                            End If

                        Else
                            strVersand = ebay.getShippment(lvwArtikelListe.SelectedItems(0).Text, "1", My.Settings.anmeldung_postleitzahl, Global.eBay.Service.Core.Soap.CountryCodeType.DE)
                            Call setVersandMethode(strVersand(0))
                            txtVersandkosten.Text = strVersand(1)
                        End If

                        '# Paypal neuberechnen
                        If chkPaypalMit.Checked = True Then
                            txtMitPaypal.Text = setCalcPaypal(txtUmsatz.Text, txtVersandkosten.Text)
                        End If

                        '# Endpreis berechnen 
                        Call checkEndpreis()
                    End If


                Else
                    MsgBox("Bitte aus der unteren Liste einen aktuellen Artikel selektieren", MsgBoxStyle.Information)
                End If

                chkeBayInternational.Enabled = True

            End If


        Catch ex As Exception
            debug_message(ex, "geteBayVersandkostenAPI")
        End Try
    End Function
    Private Sub chkInternational_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeBayInternational.CheckedChanged
        Call geteBayVersandkostenAPI()
    End Sub

    Private Sub txtVersandkosten_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVersandkosten.TextChanged
        txtVersandkosten.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub txtUmsatz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUmsatz.TextChanged

    End Sub

    Private Sub txtEndbetrag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndbetrag.TextChanged

    End Sub

    Private Sub txtMitPaypal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMitPaypal.TextChanged

    End Sub

    Private Sub lbleBayVersand_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbleBayVersand.LinkClicked
        lbleBayVersand.Enabled = False

        Dim frmeBayVersand As New FormAddOrder
        frmeBayVersand.strVersand = txtVersandkosten.Text
        frmeBayVersand.strKosten = txtUmsatz.Text
        frmeBayVersand.lvwDataInput = lvwArtikelListe
        frmeBayVersand.Show()

        lbleBayVersand.Enabled = True
    End Sub

    Private Sub EBayArtikelinformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayArtikelinformationToolStripMenuItem.Click

        If lvwKundenliste.SelectedItems.Count > 0 Then
            Dim frmeBayItem As New FormGetItem
            frmeBayItem.txteBayID.Text = lvwArtikelListe.SelectedItems(0).Text
            frmeBayItem.ShowDialog()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim frmWeb As New frmYABE_WebBrowser
        Try
            Clipboard.SetText(txtVersandkosten.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Select Case LinkLabel1.Text
            Case "eBay Versand"
                frmWeb.strURL = "http://payments.ebay.de/ws/eBayISAPI.dll?UnifiedCheckoutSellerUpdateDetails&itemId=" & lvwArtikelListe.Items(0).Text & "&transId=0&buyerid=0&ssPageName=ADME:L:EOISSA:DE:1156"
                frmWeb.Show()
            Case "delcampe Versand"
                frmWeb.strURL = "https://www.delcampe.net/de/sammlerobjekte/sell/sold-items/list"
                frmWeb.Show()
        End Select


    End Sub

    Private Sub txtLand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLand.TextChanged
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
        ElseIf strSprache = "" Then
            If txtLand.Text.ToUpper = "DEUTSCHLAND" Or txtLand.Text.ToUpper = "ÖSTERREICH" Then
                cmbSprachenVorlage.SelectedIndex = 0
            Else
                cmbSprachenVorlage.SelectedIndex = 1
            End If

        End If
    End Sub

    Private Sub cmbSprachenVorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSprachenVorlage.SelectedIndexChanged

    End Sub

    Private Sub btnCreateOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateOrder.Click
        Dim icount As Integer = 0

        If lvwArtikelListe.SelectedItems.Count >= 2 Then

            clseBayAPI.seteBayOrder(Me)
        End If
    End Sub

    Private Sub cmbVersand_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbeBayVersandart.SelectedIndexChanged
        'MsgBox(cmbVersand.SelectedIndex)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim frmKundenEdit As New frmYABE_Kundenverwaltung
        frmKundenEdit.lvwDataInput = lvwDataInput
        frmKundenEdit.bNoNext = True
        frmKundenEdit.strLoadEmail = txtEmail.Text
        frmKundenEdit.ShowDialog()
    End Sub

    Private Sub chkMitRechnung_CheckedChanged(sender As Object, e As EventArgs) Handles chkMitRechnung.CheckedChanged

    End Sub

    Private Sub txtRabatt_TextChanged(sender As Object, e As EventArgs) Handles txtRabatt.TextChanged

        If bIsLoadingRabatt = False Then
            If txtRabatt.Text.Length > 0 Then
                If IsNumeric(txtRabatt.Text) = True And IsNumeric(txtUmsatz.Text) = True Then
                    bIsLoadingRabatt = True
                    txtRabattEUR.Text = Math.Round(((Convert.ToDouble(txtUmsatz.Text) / 100) * Convert.ToDouble(txtRabatt.Text)), 2)
                    txtArtikelsummeRabatt.Text = Math.Round((Convert.ToDouble(txtUmsatz.Text) - Convert.ToDouble(txtRabattEUR.Text)), 2)
                    txtRabattEndsumme.Text = Math.Round((Convert.ToDouble(txtEndbetrag.Text) - Convert.ToDouble(txtRabattEUR.Text)), 2)
                    Call getPayPalSum()
                    bIsLoadingRabatt = False
                End If

            End If
        End If
    End Sub

    Private Sub txtRabattEUR_TextChanged(sender As Object, e As EventArgs) Handles txtRabattEUR.TextChanged
        'If bIsLoadingRabatt = False Then
        '    If Convert.ToDouble(txtRabattEUR.Text) > 0 Then
        '        txtArtikelsummeRabatt.Text = (Convert.ToDouble(txtUmsatz.Text) - Convert.ToDouble(txtRabattEUR.Text))
        '        txtRabattEndsumme.Text = (Convert.ToDouble(txtEndbetrag.Text) - Convert.ToDouble(txtRabattEUR.Text))
        '    End If
        'End If
    End Sub

    Private Sub cmbVersandart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVersandart.SelectedIndexChanged

        Dim oItem As MyListItem = CType(cmbVersandart.SelectedItem, MyListItem)
        txtVersandkosten.Text = clsDatenbank_modul.getComboVersandkosten_preis(oItem.Value)
    End Sub

    Private Sub txtRabattEndsumme_TextChanged(sender As Object, e As EventArgs) Handles txtRabattEndsumme.TextChanged
        If txtRabattEndsumme.Text.Length > 0 Then
            If bIsLoadingRabatt = False Then
                If IsNumeric(Convert.ToDouble(txtRabattEndsumme.Text)) = True Then
                    bIsLoadingRabatt = True
                    Try
                        txtRabatt.Text = Math.Round(100 - ((100 / Convert.ToDouble(txtUmsatz.Text)) * Convert.ToDouble(txtRabattEndsumme.Text)), 2)
                        txtRabattEUR.Text = Math.Round((Convert.ToDouble(txtUmsatz.Text) - Convert.ToDouble(txtRabattEndsumme.Text)), 2)
                        txtArtikelsummeRabatt.Text = Math.Round((Convert.ToDouble(txtUmsatz.Text) - Convert.ToDouble(txtRabattEUR.Text)), 2)
                        Call getPayPalSum()
                    Catch ex As Exception

                    End Try
                    bIsLoadingRabatt = False
                End If

            End If

        End If
    End Sub

    Private Sub lblKommentar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblKommentar.LinkClicked
        Dim frmKommentar As New frmVersandKommentar
        frmKommentar.strEiSoOrderID = lvwArtikelListe.SelectedItems(0).SubItems(12).Text
        frmKommentar.ShowDialog()

    End Sub

    Private Sub VersandartenÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersandartenÖffnenToolStripMenuItem.Click
        Dim frmEiSoVersandarten As New frmEiSoVersandkosten
        frmEiSoVersandarten.Show()
    End Sub

    Private Sub RechnungDirektAusdruckenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechnungDirektAusdruckenToolStripMenuItem.Click

        If RechnungDirektAusdruckenToolStripMenuItem.Checked = False Then
            RechnungDirektAusdruckenToolStripMenuItem.Checked = True
            btnSaveShippment.Text = "&Versandkosten speichern und Rechnung ausdrucken"
            My.Settings.gui_eiso_rechnungsdruck_druckansicht = RechnungDirektAusdruckenToolStripMenuItem.Checked
        Else
            RechnungDirektAusdruckenToolStripMenuItem.Checked = False
            My.Settings.gui_eiso_rechnungsdruck_druckansicht = RechnungDirektAusdruckenToolStripMenuItem.Checked
            btnSaveShippment.Text = "&Versandkosten speichern"
        End If


        My.Settings.Save()
    End Sub

    Private Sub RechnungDirektAusdruckenToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs) Handles RechnungDirektAusdruckenToolStripMenuItem.CheckStateChanged

        If RechnungDirektAusdruckenToolStripMenuItem.Checked = False Then
            btnSaveShippment.Text = "&Versandkosten speichern"
        Else
            btnSaveShippment.Text = "&Versandkosten speichern und Rechnung ausdrucken"
        End If
    End Sub

    Private Sub chkPrintRechnung_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrintRechnung.CheckedChanged

        My.Settings.gui_eiso_rechnungsdruck_druckansicht = chkPrintRechnung.Checked

        RechnungDirektAusdruckenToolStripMenuItem.Checked = chkPrintRechnung.Checked

        My.Settings.Save()

    End Sub

    Private Sub chkBestellung_versand_MitRabatt_CheckedChanged(sender As Object, e As EventArgs) Handles chkBestellung_versand_MitRabatt.CheckedChanged
        If chkBestellung_versand_MitRabatt.Checked = True Then
            Label25.Visible = True
            txtArtikelsummeRabatt.Visible = True
            Label18.Visible = True
            txtRabattEUR.Visible = True
            Label17.Visible = True
            LinkLabel3.Visible = True
            txtRabattEndsumme.Visible = True
            Label19.Visible = True
            Label21.Visible = True
            txtRabattPaypal.Visible = True
            Label22.Visible = True
        Else
            Label25.Visible = False
            txtArtikelsummeRabatt.Visible = False
            Label18.Visible = False
            txtRabattEUR.Visible = False
            Label17.Visible = False
            LinkLabel3.Visible = False
            txtRabattEndsumme.Visible = False
            Label19.Visible = False
            Label21.Visible = False
            txtRabattPaypal.Visible = False
            Label22.Visible = False
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

    End Sub

    Private Sub lvwArtikelListe_ItemMouseHover(sender As Object, e As ListViewItemMouseHoverEventArgs) Handles lvwArtikelListe.ItemMouseHover

        If e.Item.SubItems(10).Text.Length > 0 And My.Settings.chkBildvorschau = True Then
            Dim frmPic As New frmBildvorschau
            frmPic.strPfad = Application.StartupPath & "\bilderexport\" & e.Item.SubItems(10).Text
            frmPic.ShowDialog(Me)
        End If


    End Sub
End Class