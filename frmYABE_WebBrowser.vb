Imports System.Web

Public Class frmYABE_WebBrowser

    Public lvwDataView As ListView
    Public strURL As String = ""

    Private strMessage() As String
    Private dblEndsumme As Double = 0
    Private dblVersnd As Double = 0
    Private dblPaypal As Double = 0
    Private bAutoModus As Boolean = False
    Private webIsLoading As Boolean = False
    Private strLastValue As String
    Private bNeuLaden As Boolean = False
    Private bIsForm_load As Boolean = True

    Private Structure Yabeperson
        Dim strName As String
        Dim strAdress As String
        Dim strOrt As String
        Dim strLand As String
        Dim del_userID As String
        Dim strAccountName As String
        Dim strSprachliste As String
    End Structure

    Private Structure YabeBestellung
        Dim strArtikel_SKU As String
        Dim strArtikel As String
        Dim strBild As String
        Dim strPreis_anfang As String
        Dim strPreis_ende As String
        Dim strPreis_paypal As String
        Dim strPreis_versand As String
        Dim strAuktionsende As String
        Dim strPlattform As String
        Dim strWebID As String
        Dim strStatus As String
    End Structure

    Dim iAnzahl As Integer = 0

    '# Gruppenauswahl
    Enum mVorlagen_Gruppen
        Bewertungen = 0
        Newstletter = 1
        Delcampe_Versand = 2
        Auktionsende = 3
        Rechnungen = 4
        Shopsystem = 5
        Artikel_einstellen = 6
    End Enum

    '# >> Modi für den Webbrowser 
    Enum mWebLinksCol
        delcampe_versand = 10
        delcampe_adressen = 11
        delcampe_bewerten = 12
        delcampe_artikelview = 13
        shop_einzelview = 20
        ebay_artikelview = 30
        ebay_versandkosten = 31
        yabe_google_maps = 40
        yabe_personensuche_yasni = 41
        yabe_dasoertliche = 42
        google = 50
    End Enum

    Public mVorlagen_Gruppe As mVorlagen_Gruppen
    Public mWebLinkCollectionStatus As mWebLinksCol

    Private webPerson As New Yabeperson
    Private webBestellung As New YabeBestellung



    Private Sub webMain_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub


    Private Sub SchließenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchließenToolStripMenuItem.Click
        Me.Close()
    End Sub



    '#################################################
    '# >> Artikel -> zurückblättern
    '#################################################
    Private Function setBack() As Boolean
        Try


            If lvwDataView.SelectedItems.Count > 0 Then

                If webBestellung.strWebID.Length > 0 Then
                    WebAnsichtToolStripMenuItem.Enabled = True
                Else
                    WebAnsichtToolStripMenuItem.Enabled = False
                End If

                lblTitel.Text = "YABE Browser -  bei " & iAnzahl & " von " & lvwDataView.Items.Count

                Dim strName As String = ""
                Dim iSel As Integer = 0

                '# Blättern beeinflussen je nach Modus 
                Select Case mWebLinkCollectionStatus
                    Case mWebLinksCol.delcampe_adressen, mWebLinksCol.delcampe_versand, mWebLinksCol.yabe_google_maps, mWebLinksCol.yabe_personensuche_yasni, mWebLinksCol.yabe_dasoertliche


                        '# Aktuellen abwählen 
                        strName = lvwDataView.SelectedItems(0).SubItems(1).Text
                        iAnzahl = lvwDataView.SelectedItems(0).Index
                        'lvwDataView.Items(iAnzahl).Selected = False

                        For iSel = iAnzahl To 0 Step -1

                            If Not strName = lvwDataView.Items(iSel).SubItems(1).Text Then
                                lvwDataView.Items(iAnzahl).Selected = False
                                lvwDataView.Items(iSel).Selected = True
                                Exit For
                            End If
                        Next

                        If iSel = -1 Then
                            lvwDataView.Items(1).Selected = False
                            lvwDataView.Items(0).Selected = True
                        End If

                    Case Else

                        iAnzahl = lvwDataView.SelectedItems(0).Index

                        '# Blättermodus festlegen 
                        Call setModebyBestellstatus(iAnzahl)

                        lvwDataView.Items(iAnzahl).Selected = False
                        iAnzahl -= 1
                        ArtikelVorToolStripMenuItem.Enabled = True

                        If iAnzahl = 0 Then
                            ArtikelZurückToolStripMenuItem.Enabled = False
                        Else
                            ArtikelVorToolStripMenuItem.Enabled = True
                        End If

                        lvwDataView.Items(iAnzahl).Selected = True


                End Select

                lvwDataView.Items(iAnzahl).EnsureVisible()

                Call setDataUpdate(True)
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '############################################################################
    '# >> Beim blättern auf den Bestellstatus reagieren 
    '############################################################################
    Public Function setModebyBestellstatus(ByVal iAnzahl As Integer) As Boolean
        Try
            Select Case lvwDataView.Items(iAnzahl).SubItems(7).Text
                Case "Bezahlt"
                    mWebLinkCollectionStatus = mWebLinksCol.delcampe_artikelview
                Case "Verschickt"
                    mWebLinkCollectionStatus = mWebLinksCol.delcampe_bewerten
                Case Else

            End Select


            Return True
        Catch ex As Exception
            Call debug_message(ex, "")
            Return False
        End Try
    End Function


    '#################################################
    '# >> Artikel -> weiterblättern 
    '#################################################
    Private Function setVor() As Boolean


        Try

            If lvwDataView.SelectedItems.Count > 0 Then

                lblTitel.Text = "YABE Browser -  bei " & iAnzahl & " von " & lvwDataView.Items.Count



                If webBestellung.strWebID.Length > 0 Then
                    WebAnsichtToolStripMenuItem.Enabled = True
                Else
                    WebAnsichtToolStripMenuItem.Enabled = False
                End If

                Dim strName As String = ""
                Dim iSel As Integer = 0

                '# Blättern beeinflussen je nach Modus 
                Select Case mWebLinkCollectionStatus
                    Case mWebLinksCol.delcampe_adressen, mWebLinksCol.delcampe_versand, mWebLinksCol.yabe_google_maps, mWebLinksCol.yabe_personensuche_yasni, mWebLinksCol.yabe_dasoertliche

                        '# Aktuellen abwählen 
                        strName = lvwDataView.SelectedItems(0).SubItems(1).Text
                        iAnzahl = lvwDataView.SelectedItems(0).Index
                        'lvwDataView.Items(iAnzahl).Selected = False

                        For iSel = iAnzahl To lvwDataView.Items.Count - 1

                            If Not strName = lvwDataView.Items(iSel).SubItems(1).Text Then
                                lvwDataView.Items(iAnzahl).Selected = False
                                lvwDataView.Items(iSel).Selected = True



                                Exit For
                            End If
                        Next

                        If iAnzahl = lvwDataView.Items.Count - 2 Then
                            ArtikelVorToolStripMenuItem.Enabled = False
                        Else
                            ArtikelZurückToolStripMenuItem.Enabled = True
                        End If

                    Case Else

                        iAnzahl = lvwDataView.SelectedItems(0).Index
                        lvwDataView.Items(iAnzahl).Selected = False

                        '# Blättermodus festlegen 
                        If mWebLinkCollectionStatus = mWebLinksCol.delcampe_adressen Or mWebLinkCollectionStatus = mWebLinksCol.delcampe_versand Then
                            Call setModebyBestellstatus(iAnzahl)
                        End If


                        iAnzahl += 1
                        ArtikelVorToolStripMenuItem.Enabled = True

                        If iAnzahl = lvwDataView.Items.Count Then
                            ArtikelVorToolStripMenuItem.Enabled = False
                        Else
                            ArtikelZurückToolStripMenuItem.Enabled = True
                        End If

                        lvwDataView.Items(iAnzahl).Selected = True
                        lvwDataView.Items(iAnzahl).EnsureVisible()

                End Select


                Call setDataUpdate(True)


            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '####################################################################################################
    '# >> Dynamische Menüs sichtbar / unsichtbar 
    '####################################################################################################
    Private Function setWebContextMenue() As Boolean
        Try


            Select Case lvwDataView.Name
                Case "lvwBestellverwaltung_nach_artikel", "lvweBayLiveList", "lvwBestellungen_bestelliste_neu"

                    Select Case lvwDataView.SelectedItems(0).SubItems(13).Text
                        Case "eBay"
                            DelcampeVersandkostenToolStripMenuItem.Visible = False
                            DelcampeBewertungToolStripMenuItem.Visible = False
                            DelcampeVersandkostenToolStripMenuItem1.Visible = False
                            DelcampeArtikelansichtToolStripMenuItem.Visible = False

                            EBayArtikelansichtToolStripMenuItem.Visible = True
                            EBayBewertungenToolStripMenuItem.Visible = True
                            EBayAdressenToolStripMenuItem.Visible = True
                            EBayVersanddatenToolStripMenuItem.Visible = True

                        Case "delcampe"

                            DelcampeVersandkostenToolStripMenuItem.Visible = True
                            DelcampeBewertungToolStripMenuItem.Visible = True
                            DelcampeVersandkostenToolStripMenuItem1.Visible = True
                            DelcampeArtikelansichtToolStripMenuItem.Visible = True

                            EBayArtikelansichtToolStripMenuItem.Visible = False
                            EBayBewertungenToolStripMenuItem.Visible = False
                            EBayAdressenToolStripMenuItem.Visible = False
                            EBayVersanddatenToolStripMenuItem.Visible = False
                    End Select

                Case "lvwKunden"

                    DelcampeVersandkostenToolStripMenuItem.Visible = False
                    DelcampeBewertungToolStripMenuItem.Visible = False
                    DelcampeVersandkostenToolStripMenuItem1.Visible = False
                    DelcampeArtikelansichtToolStripMenuItem.Visible = False

                    EBayArtikelansichtToolStripMenuItem.Visible = False
                    EBayBewertungenToolStripMenuItem.Visible = False
                    EBayAdressenToolStripMenuItem.Visible = False
                    EBayVersanddatenToolStripMenuItem.Visible = False

                    WebAnsichtToolStripMenuItem.Visible = False
                    ToolStripSeparator2.Visible = False
                    ToolStripSeparator5.Visible = False

                Case "lvwBewertungen"

                    DelcampeVersandkostenToolStripMenuItem.Visible = False
                    DelcampeBewertungToolStripMenuItem.Visible = False
                    DelcampeVersandkostenToolStripMenuItem1.Visible = False
                    DelcampeArtikelansichtToolStripMenuItem.Visible = False

                    EBayArtikelansichtToolStripMenuItem.Visible = True
                    EBayBewertungenToolStripMenuItem.Visible = True
                    EBayAdressenToolStripMenuItem.Visible = True
                    EBayVersanddatenToolStripMenuItem.Visible = False

                    WebAnsichtToolStripMenuItem.Visible = True
                    ToolStripSeparator2.Visible = False
                    ToolStripSeparator5.Visible = False


            End Select

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '####################################################################################################
    '# >> Komplette Transaktion abrufen 
    '####################################################################################################
    Private Function getTransaktionWhole() As Boolean
        Dim strMember As String = ""
        Dim strPlattform As String = ""
        Dim iCount As Integer = 0
        Try

            dblEndsumme = 0
            dblVersnd = 0
            dblPaypal = 0
            '# Daten zwischenspeichern
            strMember = lvwDataView.SelectedItems(0).SubItems(2).Text
            strPlattform = lvwDataView.SelectedItems(0).SubItems(13).Text

            '# Alle Items durchgehen bei Bestellungen und sumieren 
            For iCount = 0 To lvwDataView.Items.Count - 1

                Application.DoEvents()
                '# Gleicher Member -> Summieren 
                If strMember = lvwDataView.Items(iCount).SubItems(2).Text And lvwDataView.Items(iCount).SubItems(7).Text = "Bestellt" Then

                    dblEndsumme += Convert.ToDouble(lvwDataView.Items(iCount).SubItems(5).Text) ' Preis zu Endsumme

                    ' Paypal Höchste Summe ermitteln 
                    If dblPaypal < Convert.ToDouble(lvwDataView.Items(iCount).SubItems(16).Text) Then
                        dblPaypal = Convert.ToDouble(lvwDataView.Items(iCount).SubItems(16).Text)
                    End If

                    '# Höchste Versandkosten ermitteln 
                    If dblVersnd < Convert.ToDouble(lvwDataView.Items(iCount).SubItems(6).Text) Then
                        dblVersnd = Convert.ToDouble(lvwDataView.Items(iCount).SubItems(6).Text)
                    End If

                End If

            Next iCount

            '# Keine Paypal Gebühr gefunden 
            If dblPaypal = 0 Or dblPaypal = 0.0 Then
                txtPlattformGebühr.Text = dblVersnd
            Else
                txtPlattformGebühr.Text = dblPaypal - dblEndsumme
            End If


        Catch ex As Exception
            Call debug_message(ex, "getTransaktionWhole")
        End Try

    End Function

    '########################################################################################################
    '# >> Modus im Programm festlegen 
    '########################################################################################################
    Private Function setStatus2Modus(ByVal strStatus As String, ByVal strPlattform As String) As Boolean
        Try

            Select Case strPlattform
                Case "eBay"
                    mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_versandkosten
                Case "delcampe"
                    Select Case strStatus
                        Case "Bezahlt"
                            mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                        Case "Verschickt"
                            mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_bewerten
                        Case Else
                            mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_versand
                    End Select
                Case "CMS"
                    mWebLinkCollectionStatus = mWebLinksCol.shop_einzelview
            End Select

            Return True
        Catch ex As Exception
            Call debug_message(ex, "")
            Return False
        End Try
    End Function

    '#####################################################
    '# >> Daten aktualliseren 
    '#####################################################
    Private Function setDataUpdate(Optional ByVal bBlättern As Boolean = False) As Boolean

        '# Update des Webbrowser Menüs 
        Application.DoEvents()
        Call setWebContextMenue()
        Static strModus As String = ""


        Select Case lvwDataView.Name
            Case "lvwBestellverwaltung_nach_artikel", "lvweBayLiveList", "lvwBestellungen_bestelliste_neu"

                '# Sichbarkeit und Unsichtbarkeit je nach Daten 
                PlattformArtikelansichtToolStripMenuItem.Visible = True
                WebAnsichtToolStripMenuItem.Visible = True
                txtKategorien.Visible = False
                lblKategorien.Visible = False

                Call getTransaktionWhole()

                Select Case lvwDataView.Name
                    Case "lvwEiSoCockpit"
                        Me.Text = "YABE Cockpit -> " & webBestellung.strArtikel & " - " & webPerson.strName & " aus " & webPerson.strLand & " - Preis:" & webBestellung.strPreis_ende & "(" & dblEndsumme & ") Versand:" & dblVersnd

                        webPerson.strName = lvwDataView.SelectedItems(0).SubItems(1).Text
                        webPerson.strAdress = lvwDataView.SelectedItems(0).SubItems(20).Text
                        webPerson.strOrt = lvwDataView.SelectedItems(0).SubItems(3).Text
                        webPerson.strLand = lvwDataView.SelectedItems(0).SubItems(17).Text

                        webBestellung.strArtikel_SKU = lvwDataView.SelectedItems(0).Text
                        webBestellung.strArtikel = lvwDataView.SelectedItems(0).SubItems(1).Text

                        webBestellung.strArtikel_SKU = lvwDataView.SelectedItems(0).Text
                        webBestellung.strArtikel = lvwDataView.SelectedItems(0).SubItems(1).Text
                        webBestellung.strPlattform = lvwDataView.SelectedItems(0).SubItems(17).Text
                        webPerson.strSprachliste = ""

                        WebAnsichtToolStripMenuItem.Visible = False
                        PlattformArtikelansichtToolStripMenuItem.Visible = False
                        SplitContainer1.Panel1Collapsed = True
                    Case "lvwBestellverwaltung_nach_artikel", "lvwBestellungen_bestelliste_neu"

                        webPerson.strName = lvwDataView.SelectedItems(0).SubItems(1).Text
                        webPerson.strAdress = lvwDataView.SelectedItems(0).SubItems(20).Text
                        webPerson.strOrt = lvwDataView.SelectedItems(0).SubItems(3).Text
                        webPerson.strLand = lvwDataView.SelectedItems(0).SubItems(17).Text
                        webPerson.strSprachliste = lvwDataView.SelectedItems(0).SubItems(19).Text
                        webPerson.strAccountName = lvwDataView.SelectedItems(0).SubItems(2).Text

                        webBestellung.strArtikel_SKU = lvwDataView.SelectedItems(0).Text
                        webBestellung.strArtikel = lvwDataView.SelectedItems(0).SubItems(4).Text
                        webBestellung.strPreis_ende = lvwDataView.SelectedItems(0).SubItems(5).Text
                        webBestellung.strPlattform = lvwDataView.SelectedItems(0).SubItems(13).Text

                        webPerson.del_userID = lvwDataView.SelectedItems(0).SubItems(18).Text
                        webBestellung.strWebID = lvwDataView.SelectedItems(0).SubItems(15).Text
                        webBestellung.strBild = lvwDataView.SelectedItems(0).SubItems(14).Text

                        webBestellung.strStatus = lvwDataView.SelectedItems(0).SubItems(7).Text
                        Me.Text = webPerson.strName & " - " & webPerson.strLand & " - Preis:" & webBestellung.strPreis_ende & "(" & dblEndsumme & ") Versand:" & dblVersnd

                        '####################################################################################################
                        '# >> Datenausgabe in die Textboxen
                        '####################################################################################################
                        If IsNumeric(webBestellung.strWebID) = True Then
                            '# Bild abrufen
                            txtBild.Text = clsDatenbank_modul.getCMS_ShopItems("Bild", webBestellung.strWebID)
                            txtBild.Text = txtBild.Text.Replace(My.Settings.shop_url & "/eBay/", "")

                        Else
                            txtBild.Text = ""
                        End If

                        Dim str() As String = webPerson.strSprachliste.Split(" ")
                        Dim iCount As Integer = 0
                        txtHerkunftSprachen.Text = ""
                        For iCount = 0 To str.Length - 1

                            If str(iCount).Length > 0 Then
                                txtHerkunftSprachen.Text &= My.Settings.yabe_trennzeichen & " " & str(iCount)
                            End If

                        Next

                        txtEndpreis.Text = My.Settings.yabe_trennzeichen & " Umsatz: " & dblEndsumme & " "
                        txtEndpreis.Text &= My.Settings.yabe_trennzeichen & " Paypal: " & dblPaypal & " "
                        txtEndpreis.Text &= My.Settings.yabe_trennzeichen & "  + Versand: " & dblVersnd & " "
                        If dblPaypal > 0 Then
                            Me.Text &= My.Settings.yabe_trennzeichen & " Paypal: " & dblPaypal
                        End If


                        txtTitel.Text = My.Settings.yabe_trennzeichen & " " & webBestellung.strStatus & My.Settings.yabe_trennzeichen & " " & webBestellung.strArtikel
                        iAnzahl = lvwDataView.SelectedItems(0).Index + 1
                        txtBild.Text = My.Settings.yabe_trennzeichen & " " & webBestellung.strWebID
                        txtBild.Text &= My.Settings.yabe_trennzeichen & " " & webBestellung.strBild


                        txtKundenAnschrift.Text = My.Settings.yabe_trennzeichen & " " & webPerson.strAccountName
                        txtKundenAnschrift.Text &= My.Settings.yabe_trennzeichen & " " & webPerson.strName
                        txtKundenAnschrift.Text &= My.Settings.yabe_trennzeichen & " " & webPerson.strOrt & " / " & webPerson.strLand


                        PlattformArtikelansichtToolStripMenuItem.Text = webBestellung.strPlattform & " - Funktionen"

                        If bBlättern = True Then
                            Call setStatus2Modus(webBestellung.strStatus, webBestellung.strPlattform)
                        End If


                        '# Textbox einfärben
                        Call frmMain.frmManage.setColorToTxt(txtTitel, webBestellung.strStatus)
                    Case "lvwBestellverlauf"


                    Case Else


                        Me.Text = "YABE Browser"

                End Select



                Select Case mWebLinkCollectionStatus
                    Case mWebLinksCol.yabe_google_maps
                        Call getGoogleMaps()
                        Return True
                    Case mWebLinksCol.yabe_personensuche_yasni
                        Call getYasniPerson()
                    Case mWebLinksCol.yabe_dasoertliche
                        Call getDasOertliche()
                End Select

                If Not PlattformArtikelansichtToolStripMenuItem.Text = webBestellung.strPlattform & " - Funktionen" Then
                    Select Case webBestellung.strPlattform
                        Case "eBay"
                            mWebLinkCollectionStatus = mWebLinksCol.ebay_artikelview
                        Case "delcampe"
                            mWebLinkCollectionStatus = mWebLinksCol.delcampe_versand
                        Case "CMS"
                            mWebLinkCollectionStatus = mWebLinksCol.shop_einzelview
                    End Select
                End If

                '# Delcampe Ansicht 
                Call webDelcampe_navigateSelector(webBestellung.strArtikel_SKU, webPerson.del_userID, webBestellung.strWebID)

                If Not strModus = mWebLinkCollectionStatus.ToString Then

                    Dim iSel As Integer = cmbVorlagen.SelectedIndex

                    Select Case mWebLinkCollectionStatus
                        Case mWebLinksCol.delcampe_bewerten
                            mVorlagen_Gruppe = mVorlagen_Gruppen.Bewertungen
                            Call clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlagen, mVorlagen_Gruppe.ToString.Replace("_", " "))
                        Case mWebLinksCol.delcampe_versand
                            mVorlagen_Gruppe = mVorlagen_Gruppen.Delcampe_Versand
                            Call clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlagen, mVorlagen_Gruppe.ToString.Replace("_", " "))
                    End Select

                    If iSel = -1 Then
                        iSel = 0
                    End If

                    cmbVorlagen.SelectedIndex = iSel
                    strModus = mWebLinkCollectionStatus.ToString
                End If



            '####################################################################################################
            '# >> Webartikel 
            '####################################################################################################
            Case "lvwWebArtikel"

                If Not strURL.Length > 0 Then
                    txtKategorien.Visible = False
                    lblKategorien.Visible = False
                    PlattformArtikelansichtToolStripMenuItem.Visible = False
                    WebAnsichtToolStripMenuItem.Visible = False

                    txtHerkunftSprachen.Visible = True
                    txtKundenAnschrift.Text = lvwDataView.SelectedItems(0).SubItems(2).Text
                    Me.Text = "Web -> " & lvwDataView.SelectedItems(0).SubItems(1).Text
                    txtTitel.Text = lvwDataView.SelectedItems(0).SubItems(1).Text
                    txtHerkunftSprachen.Text = lvwDataView.SelectedItems(0).SubItems(3).Text.Replace(My.Settings.shop_url & "/eBay/", "")
                    txtBild.Text = lvwDataView.SelectedItems(0).Text
                    txtKategorien.Text = "Magento: " & lvwDataView.SelectedItems(0).SubItems(4).Text & "    - Delcampe: " & lvwDataView.SelectedItems(0).SubItems(5).Text
                    webMain.Navigate(My.Settings.shop_url & "/suchen_Webseite_ID.php?txtIDSuchen=" & lvwDataView.SelectedItems(0).Text & "&KEY=" & My.Settings.yabe_keycode)
                Else
                    SplitContainer1.Panel1Collapsed = False

                End If
            '####################################################################################################
            '# >> Outlook 
            '####################################################################################################
            Case "lvwOutlook_items"

                Me.Text = "Outlook -> "
                If lvwDataView.SelectedItems.Count > 0 Then
                    Call webDelcampe_navigateSelector(lvwDataView.SelectedItems(0).SubItems(11).Text, lvwDataView.SelectedItems(0).SubItems(15).Text, "")
                End If

            '####################################################################################################
            '# >> Kunden 
            '####################################################################################################
            Case "lvwKunden"


                webPerson.strAccountName = lvwDataView.SelectedItems(0).SubItems(1).Text
                webPerson.strName = lvwDataView.SelectedItems(0).Text
                webPerson.strAdress = lvwDataView.SelectedItems(0).SubItems(3).Text
                webPerson.strOrt = lvwDataView.SelectedItems(0).SubItems(4).Text
                webPerson.strLand = lvwDataView.SelectedItems(0).SubItems(6).Text
                webPerson.strSprachliste = lvwDataView.SelectedItems(0).SubItems(12).Text

                txtKundenAnschrift.Text = My.Settings.yabe_trennzeichen & " " & webPerson.strAccountName
                txtKundenAnschrift.Text &= My.Settings.yabe_trennzeichen & " " & webPerson.strName
                txtKundenAnschrift.Text &= My.Settings.yabe_trennzeichen & " " & webPerson.strOrt & " / " & webPerson.strLand

                Me.Text = webPerson.strName & " - " & webPerson.strAccountName

                Dim str() As String = webPerson.strSprachliste.Split(" ")
                Dim iCount As Integer = 0
                txtHerkunftSprachen.Text = ""
                For iCount = 0 To str.Length - 1

                    If str(iCount).Length > 0 Then
                        txtHerkunftSprachen.Text &= My.Settings.yabe_trennzeichen & " " & str(iCount)
                    End If

                Next

                Select Case mWebLinkCollectionStatus
                    Case mWebLinksCol.yabe_google_maps
                        Call getGoogleMaps()
                        Return True
                    Case mWebLinksCol.yabe_personensuche_yasni
                        Call getYasniPerson()
                    Case mWebLinksCol.yabe_dasoertliche
                        Call getDasOertliche()
                End Select

            '####################################################################################################
            '# >> Bewertungen 
            '####################################################################################################
            Case "lvwBewertungen"
                Me.Text = "Bewertungen -> "

            Case "lvwBestellverlauf"
                webBestellung.strArtikel_SKU = lvwDataView.SelectedItems(0).Text

                '# Delcampe Ansicht 
                Call webDelcampe_navigateSelector(webBestellung.strArtikel_SKU, webPerson.del_userID, webBestellung.strWebID)

        End Select

        Return True
    End Function

    '#############################################################
    '# >> Kapselung für eBay History + Outlook Sync
    '#############################################################
    Private Function webDelcampe_navigateSelector(ByVal strSKU As String, ByVal strDelCampUserID As String, Optional ByVal strWebID As String = "") As Boolean

        '#########################################
        '# >> Letzter Modus 
        '#########################################
        Select Case mWebLinkCollectionStatus

            '# >> DELCAMPE -> Versand
            Case mWebLinksCol.delcampe_versand
                If IsNumeric(lvwDataView.SelectedItems(0).SubItems(18).Text) = True Then
                    'webMain.Navigate("http://www.delcampe.net/status.php?language=G&page=40&id_buyer=" & strDelCampUserID & "&hideMenu=Y")
                    '  Dim strURL As String = "http://www.delcampe.net/de/mein-delcampe/kaufen/meine-gewonnenen-gebote/zu-zahlen/" + strDelCampUserID + "?action=pay&return=pay-my-sellers"
                    Dim strURL As String = "https://www.delcampe.net/de/sammlerobjekte/sell/sold-items/list"
                    '# Vorlage kopieren 
                    'My.Computer.FileSystem.CopyFile(Application.StartupPath & "\vorlagen\delcampe-rechnung-erstellen.html", Application.StartupPath & "\vorlagen\delcampe-rechnung-erstellen-tmp.html")

                    Dim strData As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\vorlagen\delcampe-rechnung-erstellen.html")
                    strData = strData.Replace("###DELCAMPE_BUYER_ID###", strDelCampUserID)
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\vorlagen\delcampe-rechnung-erstellen-tmp.html", strData, False)
                    'file:///E:/Programmierung%20-%20Codeing/VB%20.NET/Cubss%20-%20YABE/Cubss%20-%20YABE/bin/Debug/vorlagen/delcampe-rechnung-erstellen.html
                    Dim strLokalPath As String = Application.StartupPath & "\vorlagen\delcampe-rechnung-erstellen-tmp.html"
                    strLokalPath = strLokalPath.Replace("\", "/")
                    'webMain.Navigate("file://" + strLokalPath)
                    webMain.Navigate(strURL)

                Else
                    mWebLinkCollectionStatus = mWebLinksCol.ebay_versandkosten
                    'setDataUpdate()
                    StatusStrip1.Items(0).Text = "Keine gültige Delcampe UserID / YABE Webbrowser"
                End If

            '# >> DELCAMPE -> Bewertung 
            Case mWebLinksCol.delcampe_bewerten
                webMain.Navigate("http://delcampe.de/rating_action.php?language=G&action=create&id_auction=" & strSKU & "&step=1&reload=Y")
            '# >> DELCAMPE -> Adressen 
            Case mWebLinksCol.delcampe_adressen

                If IsNumeric(lvwDataView.SelectedItems(0).SubItems(18).Text) = True Then
                    webMain.Navigate("http://delcampe.de/status.php?language=G&page=40&id_buyer=" & lvwDataView.SelectedItems(0).SubItems(18).Text & "&sendlist=Y&hideMenu=Y")
                Else
                    webMain.Navigate("http://delcampe.de/page/item/id," & lvwDataView.SelectedItems(0).Text & ",language,G.html")
                End If

            '# >> DELCAMPE -> Einzelansicht
            Case mWebLinksCol.shop_einzelview
                If IsNumeric(lvwDataView.SelectedItems(0).SubItems(15).Text) = True Then
                    Dim strYABEID() As String = strWebID.Split("-")
                    webMain.Navigate(My.Settings.shop_url & "/suchen_Webseite_ID.php?txtIDSuchen=" & strYABEID(0) & "&KEY=" & My.Settings.yabe_keycode & "&usr=" & My.Settings.shop_username & "&pwd=" & My.Settings.shop_pwd)
                Else
                    webMain.Navigate(My.Settings.shop_url & "/suchen_Webseite_ID.php?txtTEXTSuchen=" & lvwDataView.SelectedItems(0).SubItems(4).Text & strWebID & "&KEY=" & My.Settings.yabe_keycode & "&usr=" & My.Settings.shop_username & "&pwd=" & My.Settings.shop_pwd)
                End If

            '# >> DELCAMPE -> Einzelansicht
            Case mWebLinksCol.delcampe_artikelview
                Try
                    webMain.Navigate("http://delcampe.de/page/item/id," & lvwDataView.SelectedItems(0).Text & ",language,G.html")
                Catch ex As Exception

                End Try


            '# >> eBay -> Einzelansicht
            Case mWebLinksCol.ebay_artikelview

                If My.Settings.ebay_sandbox = False Then
                    webMain.Navigate("http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&item=" & lvwDataView.SelectedItems(0).Text)
                Else
                    webMain.Navigate("http://cgi.sandbox.ebay.de/" & lvwDataView.SelectedItems(0).Text & "?ru=http%3A%2F%2Fwww.sandbox.ebay.de%3A80%2Fsch%2Fi.html%3F_from%3DR40%26_trksid%3Dp3984.m570.l1313.TR0.TRC0.H0.X110167585364.TRS0%26_nkw%3D110167585364%26_sacat%3D0%26_fvi%3D1&_rdc=1&autorefresh=true")
                End If

            Case mWebLinksCol.ebay_versandkosten
                webMain.Navigate("http://payments.ebay.de/ws/eBayISAPI.dll?UnifiedCheckoutSellerUpdateDetails&itemId=" & lvwDataView.SelectedItems(0).Text & "&transId=0&buyerid=0&ssPageName=ADME:L:EOISSA:DE:1156")
        End Select

    End Function

    Private Sub frmWebBrowser_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        If webIsLoading = False And strURL.Length = 0 And bNeuLaden = True Then

            If lvwDataView.SelectedItems.Count > 0 Then
                If Not strURL.Length > 0 Then

                    If Not strLastValue = lvwDataView.SelectedItems(0).Text Then
                        Call setDataUpdate()
                    End If

                End If

            End If


        Else
            webIsLoading = False
        End If

    End Sub

    Private Function parameter_laden() As Boolean
        Try
            ReDim strMessage(1)

            If My.Settings.gui_webbrowser_transparent = True Then
                Call setTransparent()
            End If

            If My.Settings.gui_webbrowser_IsOnTop = True Then
                Call setOnTop()
            End If

            If My.Settings.gui_webbrowser_InfoBar = True Then
                Call setInfobar()
            End If

            If My.Settings.gui_webbrowser_NeuLaden = True Then
                setAutoNeuLaden()
            End If

            '# Benutzerdefinierte URL gesetzt 
            If strURL.Length > 0 Then
                PlattformArtikelansichtToolStripMenuItem.Visible = False
                WebAnsichtToolStripMenuItem.Visible = False
                SplitContainer1.Panel1Collapsed = True
                webIsLoading = False
                webMain.Navigate(strURL)
                webIsLoading = True
                Exit Function
            End If

            '# Statup GUI Änderungen 
            Select Case lvwDataView.Name
                Case "lvwKunden"
                    SplitContainer1.Panel1Collapsed = False
                Case "lvwEiSoCockpit"
                    SplitContainer1.Panel1Collapsed = False
            End Select

            webIsLoading = True

            '# Daten Update 
            Call setDataUpdate()

        Catch ex As Exception
            MsgBox(ex.Message, "parameter_laden")
        End Try
    End Function
    Private Sub frmWebBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim strLanguage As String = ""
        'strLanguage = lvwDataView.SelectedItems(0).SubItems(17).Text.ToUpper

        Application.DoEvents()
        Try
            Call parameter_laden()

            'webBestellung.strArtikel = ""
            'webBestellung.strArtikel_SKU = ""
            'webBestellung.strAuktionsende = ""
            'webBestellung.strBild = ""
            'webBestellung.strPlattform = ""
            'webBestellung.strPreis_anfang = ""
            'webBestellung.strPreis_ende = ""
            'webBestellung.strPreis_paypal = ""
            'webBestellung.strPreis_versand = ""
            'webBestellung.strStatus = ""
            'webBestellung.strWebID = ""

            If My.Settings.eiso_delcampe_versandkostenUndPaypal_de = True Then
                chkPaypalMit.Checked = True
            End If
            If My.Settings.eiso_delcampe_versandkostenUndPaypal_en = True Then
                chkPaypalMit.Checked = True
            End If

            Me.Location = My.Settings.yabe_gui_browser_location
            Dim bIn As Boolean = True
            Try
                If Not lvwDataView.Items.Count = Nothing Then
                    bIn = True
                End If
            Catch ex As Exception
                bIn = False
            End Try

            If bIn = True Then


                '# Sprachen abrufen 
                If lvwDataView.Name = "lvweBayLiveList" Or lvwDataView.Name = "lvwKunden" Then
                    Label1.Visible = False
                    cmdSprachen.Visible = False
                    Label2.Visible = False
                    cmbVorlagen.Visible = False
                    Label6.Visible = False
                    chkPaypalMit.Visible = False
                    If lvwDataView.Name = "lvwKunden" Then
                        Label25.Visible = False
                        txtTitel.Visible = False
                        txtEndpreis.Visible = False
                        Label4.Visible = False
                        txtKategorien.Visible = False
                        lblKategorien.Visible = False
                        Label5.Visible = False
                        txtBild.Visible = False
                        txtKundenAnschrift.Focus()
                        Dim location As New System.Drawing.Point
                        location.X = 10
                        location.Y = 63
                        txtKundenAnschrift.Location = location
                        location.X = 12
                        location.Y = 47
                        Label3.Location = location

                        location.X = 530
                        location.Y = 65
                        txtHerkunftSprachen.Location = location

                        location.X = 525
                        location.Y = 47
                        Label7.Location = location
                        PlattformArtikelansichtToolStripMenuItem.Text = "Kunden -> Information"
                        SplitContainer1.SplitterDistance = 100
                    End If
                Else
                    Call clsDatenbank_modul.getComboSprachen(cmdSprachen)
                End If


                '# Länderprüfung fehlt noch 
                If webPerson.strLand.ToUpper = "DEUTSCHLAND" Or webPerson.strSprachliste.IndexOf("Deutsch") > 0 Then
                    cmdSprachen.SelectedIndex = 0
                    chkPaypalMit.Checked = False
                Else
                    cmdSprachen.SelectedIndex = 1
                    If lvwDataView.SelectedItems(0).SubItems(16).Text = "0,00 " Then
                        chkPaypalMit.Checked = False
                    Else
                        chkPaypalMit.Checked = True
                    End If

                End If

            End If

            Me.Size = My.Settings.yabe_gui_browser_windows_size
            bIsForm_load = False
            ' lvwDataView
        Catch ex As Exception
            debug_message(ex, "Webbrowser Load")
            'MsgBox(ex.Message, "parameter_laden")
        End Try


    End Sub

    Private Sub frmWebBrowser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.F5 Then
            webMain.Refresh()
        End If
    End Sub

    Private Sub webMain_DocumentCompleted_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub


    Private Sub ArtikelvorbestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelvorbestelltToolStripMenuItem.Click
        webMain.Navigate(My.Settings.shop_url & "/ACP/bestellung_vorbestellt.php?type=1&KEY=" & My.Settings.yabe_keycode)
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenToolStripMenuItem.Click

        If FullscreenToolStripMenuItem.Checked = True Then
            FullscreenToolStripMenuItem.Checked = False
            MenuStrip1.Visible = True
            SplitContainer1.Panel1Collapsed = False
            Me.WindowState = FormWindowState.Normal
        Else
            FullscreenToolStripMenuItem.Checked = True
            MenuStrip1.Visible = False
            SplitContainer1.Panel1Collapsed = True
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub ZurückToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZurückToolStripMenuItem.Click
        If webMain.GoBack() = False Then
            ZurückToolStripMenuItem.Enabled = False
        Else
            ZurückToolStripMenuItem.Enabled = True
            VorToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub VorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VorToolStripMenuItem.Click
        If webMain.GoForward() = False Then
            VorToolStripMenuItem.Enabled = False
        Else
            VorToolStripMenuItem.Enabled = True
            ZurückToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub SchließenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchließenToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub



    Private Sub PlattformArtikelansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlattformArtikelansichtToolStripMenuItem.Click

        WebAnsichtToolStripMenuItem.Enabled = True
        '  PlattformArtikelansichtToolStripMenuItem.Enabled = False
    End Sub

    Private Sub frmWebBrowser_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    End Sub

    Private Sub SplitContainer1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitContainer1.Resize
        ' SplitContainer1.SplitterDistance = 130
    End Sub

    Private Sub ArtikelZurückToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelZurückToolStripMenuItem.Click
        Call setBack()
        ArtikelVorToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ArtikelVorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelVorToolStripMenuItem.Click
        Call setVor()
    End Sub

    Private Sub VorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setVor()
    End Sub



    Private Sub MeinDelcampeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeinDelcampeToolStripMenuItem.Click
        webMain.Navigate("http://delcampe.de/status.php?&language=G&page=05&noarchive=Y&sort=date_end&showImages=Y#StatusContent")
    End Sub

    Private Sub MeinEBayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeinEBayToolStripMenuItem.Click
        webMain.Navigate("http://my.ebay.de/ws/eBayISAPI.dll?MyEbay")
    End Sub

    Private Sub ShopBestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopBestelltToolStripMenuItem.Click
        webMain.Navigate(My.Settings.shop_url & "/ACP/admin_Bestellungen.php")
    End Sub

    Private Sub ShopAdminpanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopAdminpanelToolStripMenuItem.Click
        webMain.Navigate(My.Settings.shop_url & "/ACP/adminpanel.php")
    End Sub



    Private Sub WebAnsichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebAnsichtToolStripMenuItem.Click
        WebAnsichtToolStripMenuItem.Enabled = False
        mWebLinkCollectionStatus = mWebLinksCol.shop_einzelview
        setDataUpdate()
    End Sub

    Private Sub DelcampeBewertungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeBewertungToolStripMenuItem.Click

        mWebLinkCollectionStatus = mWebLinksCol.delcampe_bewerten
        setDataUpdate()

    End Sub

    Private Sub DelcampeVersandkostenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeVersandkostenToolStripMenuItem.Click
        mWebLinkCollectionStatus = mWebLinksCol.delcampe_adressen
        setDataUpdate()


    End Sub

    Private Sub SplitContainer1_Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer1.Panel1.MouseDown
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        '    setVor()
        'ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
        '    setBack()
        'End If
    End Sub

    'Mausrad
    'Private Sub SplitContainer1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer1.MouseWheel

    '    If e.Delta > 0 Then
    '        btnVor.PerformClick()
    '    Else
    '        btnZurück.PerformClick()
    '    End If


    'End Sub

    Private Sub DelcampeVersandkostenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeVersandkostenToolStripMenuItem1.Click

        mWebLinkCollectionStatus = mWebLinksCol.delcampe_versand
        setDataUpdate()
    End Sub


    Private Sub DelcampeArtikelansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeArtikelansichtToolStripMenuItem.Click

        mWebLinkCollectionStatus = mWebLinksCol.delcampe_artikelview
        setDataUpdate()

    End Sub

    Private Sub EBayArtikelansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayArtikelansichtToolStripMenuItem.Click

        mWebLinkCollectionStatus = mWebLinksCol.ebay_artikelview
        setDataUpdate()


    End Sub


    Private Function setWebBrowser_delcampe_login() As Boolean
        Dim i As Integer = 0

        For i = 0 To webMain.Document.Forms.Count - 1
            webMain.Document.GetElementById("nickname").InnerText = My.Settings.delcampe_username
            webMain.Document.GetElementById("password").InnerText = My.Settings.delcampe_pwd
        Next

        Return True
    End Function

    '# DELCAMPE Bewertungen 
    Private Function setWebBrowser_delcampe_bewertung(Optional ByVal strOverWriteLanguage As String = "") As Boolean

        Dim strLanguage As String = ""
        Dim strSprache_liste As String = ""
        Dim strISOName As String
        Dim strText As String = ""

        '# Sprache überschreiben 
        If strOverWriteLanguage.Length > 0 Then
            strLanguage = strOverWriteLanguage
        Else
            strLanguage = lvwDataView.SelectedItems(0).SubItems(17).Text.ToUpper
            strSprache_liste = lvwDataView.SelectedItems(0).SubItems(21).Text.ToUpper
        End If

        If lvwDataView.SelectedItems(0).SubItems(17).Text.ToUpper = "DEUTSCHLAND" Then

            strISOName = clsDatenbank_modul.getTranslate_l18n_mapping(strLanguage)
            strText = clsDatenbank_modul.getTranslationText(cmbVorlagen.Text, "Text" & strISOName) ' Englische Vorlage 
            Try
                Try
                    webMain.Document.GetElementById("comment").InnerText = strText
                Catch ex As Exception
                    StatusStrip1.Text = "Kein Textfeld vorhanden"
                End Try

            Catch ex As Exception

            End Try

        Else
            strISOName = clsDatenbank_modul.getTranslate_l18n_mapping(strLanguage)
            strText = clsDatenbank_modul.getTranslationText(cmbVorlagen.Text, "Text" & strISOName) ' Englische Vorlage 
            Try
                webMain.Document.GetElementById("comment").InnerText = strText
            Catch ex As Exception
                StatusStrip1.Text = "Kein Textfeld vorhanden"
            End Try

        End If


    End Function

    '################################################################################
    '# >> Delcampe Versand 
    '################################################################################
    Private Function setWebBrowser_delcampe_versand(Optional ByVal strOverWriteLanguage As String = "") As Boolean
        Dim i As Integer = 0
        Dim strTemp As String = ""
        Dim strLanguage As String = ""
        Dim strSprache_liste As String = ""


        '# Abgeschickt an den Verkäufer 
        If webMain.DocumentText.IndexOf("Die Mitteilung wurde Ihrem K") > -1 Then

            '# Weiterblättern...
            mWebLinkCollectionStatus = mWebLinksCol.delcampe_adressen
            webMain.Navigate("http://delcampe.de/status.php?language=G&page=40&id_buyer=" & lvwDataView.SelectedItems(0).SubItems(18).Text & "&sendlist=Y&hideMenu=Y")

        Else

            '# Gebühren übertragen (Paypal oder nicht wird berücksichtig)
            Try
                Application.DoEvents()


                '#########################################
                '# Richtige Sprache auswählen 
                '#########################################
                If strOverWriteLanguage.Length > 0 Then
                    strLanguage = strOverWriteLanguage
                Else
                    strLanguage = lvwDataView.SelectedItems(0).SubItems(17).Text.ToUpper
                    strSprache_liste = lvwDataView.SelectedItems(0).SubItems(21).Text.ToUpper
                End If

                '#########################################
                '# Länderprüfung fehlt noch 
                '#########################################
                If strLanguage.ToUpper = "DEUTSCHLAND" Or strLanguage = "Deutsch" Then
                    If My.Settings.eiso_delcampe_versandkostenUndPaypal_de = True Then
                        Dim dblVersnd2 As Double = 0
                        Dim strVersand As String = dblVersnd
                        'strVersand = strVersand.Replace(",", ".")

                        Dim iVersandPaypal As Double = dblPaypal - dblEndsumme
                        Dim strVersandPaypal As String = iVersandPaypal
                        strVersandPaypal = strVersandPaypal.Replace(",", ".")

                        If dblPaypal > 0 Then
                            dblVersnd2 = dblPaypal - dblEndsumme
                        Else
                            dblVersnd2 = dblVersnd
                            dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)
                        End If


                        '# Paypal Anteil in Versandkosten vorhanden? 
                        If chkPaypalMit.Checked = True Then
                            Try
                                webMain.Document.GetElementById("port_fees").InnerText = strVersandPaypal
                            Catch ex As Exception
                                StatusStrip1.Text = "Kein Paypal Versand"
                            End Try

                        Else
                            Try
                                webMain.Document.GetElementById("port_fees").InnerText = strVersand
                            Catch ex As Exception
                                StatusStrip1.Text = "Kein Versand"
                            End Try

                        End If
                    Else
                        ' strMessage(0) = clsDatenbank_modul.getTranslationText(16, "Text") ' Deutsche Vorlage

                        Dim strVersand As String = dblVersnd
                        strVersand = strVersand.Replace(",", ".")

                        Dim iVersandPaypal As Double = dblPaypal - dblEndsumme
                        Dim strVersandPaypal As String = iVersandPaypal
                        'strVersandPaypal = strVersandPaypal.Replace(",", ".")

                        If Not dblVersnd = 0 Then
                            Try
                                webMain.Document.GetElementById("port_fees").InnerText = strVersand
                            Catch ex As Exception
                                StatusStrip1.Text = "Kein Versand"
                            End Try

                        End If

                        '# Paypal Anteil in Versandkosten vorhanden? 
                        If chkPaypalMit.Checked = True Then
                            dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)
                            Try
                                webMain.Document.GetElementById("port_fees").InnerText = strVersandPaypal
                            Catch ex As Exception
                                StatusStrip1.Text = "Kein Versand"
                            End Try

                        Else
                            Try
                                webMain.Document.GetElementById("port_fees").InnerText = strVersand
                            Catch ex As Exception
                                StatusStrip1.Text = "Kein Versand"
                            End Try

                        End If
                    End If


                Else

                    Dim dblVersnd2 As Double = 0
                    Dim strVersand As String = dblVersnd
                    'strVersand = strVersand.Replace(",", ".")

                    Dim iVersandPaypal As Double = dblPaypal - dblEndsumme
                    Dim strVersandPaypal As String = iVersandPaypal
                    strVersandPaypal = strVersandPaypal.Replace(",", ".")

                    If dblPaypal > 0 Then
                        dblVersnd2 = dblPaypal - dblEndsumme
                    Else
                        dblVersnd2 = dblVersnd
                        dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)
                    End If


                    '# Paypal Anteil in Versandkosten vorhanden? 
                    If My.Settings.eiso_delcampe_versandkostenUndPaypal_en = True Then
                        If chkPaypalMit.Checked = True Then
                            Try
                                webMain.Document.GetElementById("port_fees").InnerText = strVersandPaypal
                            Catch ex As Exception
                                StatusStrip1.Text = "Kein Paypal Versand"
                            End Try

                        Else
                            Try
                                webMain.Document.GetElementById("port_fees").InnerText = strVersand
                            Catch ex As Exception
                                StatusStrip1.Text = "Kein Versand"
                            End Try

                        End If

                    Else
                        Try
                            webMain.Document.GetElementById("port_fees").InnerText = strVersand
                        Catch ex As Exception
                            StatusStrip1.Text = "Kein Versand"
                        End Try

                    End If


                End If

                Try
                    webMain.Document.GetElementById("port_fees").Focus()
                Catch ex As Exception
                    StatusStrip1.Text = "Kein Focus möglich"
                End Try


                SendKeys.Send(" ")


            Catch ex As Exception
                debug_message(ex, "setWebBrowser_delcampe_versand")
                Return False
            End Try

            Select Case mWebLinkCollectionStatus

                Case mWebLinksCol.delcampe_versand

                    setDelcampe_Kommentar(strLanguage)

                Case mWebLinksCol.delcampe_adressen

                    SendKeys.Send("{ENTER}")

            End Select
            'MsgBox("6 Schritt..." & dblPaypal)
        End If
        Return True
    End Function

    '###########################################################################################
    '# >> Delcampe Kommentar setzten 
    '###########################################################################################
    Private Function setDelcampe_Kommentar(ByVal strOverWriteLanguage As String) As String
        Try
            Dim strISOName As String = ""
            Dim strTemp As String = ""

            strISOName = clsDatenbank_modul.getTranslate_l18n_mapping(strOverWriteLanguage)
            strMessage(0) = clsDatenbank_modul.getTranslationText(cmbVorlagen.Text, "Text" & strISOName) ' Englische Vorlage 

            strTemp = strMessage(0) ' Orginal übergeben 
            strTemp = strTemp.Replace("<BR>", vbCrLf).Replace("&nbsp;", "")

            strTemp = strTemp.Replace("###ENDSUMME###", dblEndsumme + dblVersnd).Replace("###NAME###", lvwDataView.SelectedItems(0).SubItems(1).Text).Replace("###PAYPAL###", dblPaypal)

            Try
                webMain.Document.GetElementById("comment").InnerText = strTemp
                webMain.Document.GetElementById("comment").Style = "height:300px;"
            Catch ex As Exception
                StatusStrip1.Text = "Kein Kommentar auf der Seite"
            End Try

            Return strTemp
        Catch ex As Exception
            Call debug_message(ex, "setDelcampe_Kommentar")
            Return "-1"
        End Try

    End Function

    Private Sub DruckvorschauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckvorschauToolStripMenuItem.Click
        webMain.ShowPrintPreviewDialog()
    End Sub

    Private Sub DirektDruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirektDruckenToolStripMenuItem.Click
        webMain.Print()
    End Sub


    Private Sub YABEKundenverlaufToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEKundenverlaufToolStripMenuItem.Click
        If frmMain.frmManage.lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Call frmMain.frmManage.getOrderHistory(frmMain.frmManage.lvwBestellverwaltung_nach_artikel, frmMain.frmManage.lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(9).Text)
        End If
    End Sub

    Private Sub YABESeiteDruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABESeiteDruckenToolStripMenuItem.Click
        webMain.ShowPrintPreviewDialog()
    End Sub

    Private Sub YABEVersandkostenÄndernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEVersandkostenÄndernToolStripMenuItem.Click
        If frmMain.frmManage.lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmVersand As New frmBestellung_Versandkosten
            frmVersand.lvwDataInput = lvwDataView
            frmVersand.mModusSelect = frmBestellung_Versandkosten.mModus.history
            frmVersand.Show()
        End If
    End Sub

    '####################################################
    '# >> YABE -> Delcampe Status 
    '####################################################
    Private Function getDelcampeStatus() As Boolean
        Dim strSourceLines() As String
        Dim iCount As Integer
        Dim strTemp() As String
        Dim strTemp_sub() As String
        Dim iCount_actions As Integer = 0
        strSourceLines = webMain.DocumentText.Split(vbCrLf)

        For iCount = 0 To strSourceLines.Length

            Application.DoEvents()

            '# Mitgliedsname 
            If strSourceLines(iCount).IndexOf("ufer: <a href=""page/member/") > -1 Then
                strTemp = strSourceLines(iCount).Split("[")
                strTemp_sub = strTemp(0).Split(";"">")
                webPerson.strAccountName = strTemp_sub(1).Replace(""">", "").Trim
            End If

            '# Status holen 
            If strSourceLines(iCount).IndexOf("<td valign=top align=right><span class=txt0910>") > -1 Or strSourceLines(iCount).IndexOf("<td valign=top align=right><span class=""txt0810"">") > -1 Then

                strTemp = strSourceLines(iCount).Trim.Split("class=txt0910") ' Transaktion Komplett 910

                If Not strTemp.Length > 0 Then
                    strTemp = strSourceLines(iCount).Split("class=""txt0810""") ' In Bearbeitungsmodus (bezahl, verschickt)
                End If

                strTemp(1) = strTemp(1).Trim.Replace("</b></span><br>", "")
                strTemp_sub = strTemp(1).Split("<b>")

                If strTemp_sub.Length > 0 Then
                    webBestellung.strStatus = strTemp_sub(1).Replace("b>", "").Trim
                End If

                'MsgBox(webPerson.strAccountName & " / " & webBestellung.strStatus & " / " & iCount & " von " & strSourceLines.Length)
            End If

            '# Artikel holen 
            If strSourceLines(iCount).IndexOf("href=""page/item/id,") > -1 Then

                strTemp = strSourceLines(iCount).Trim.Split("href=""page/item/id,") ' ID isolieren 
                iCount_actions += 1
                strTemp_sub = strTemp(1).Split(",")

                If strTemp_sub.Length > 0 Then
                    webBestellung.strArtikel_SKU = strTemp_sub(1).Replace(",", "").Substring(2)
                End If

                'If webPerson.strAccountName = "Sgj" Then
                '    Stop
                'End If

                Select Case webBestellung.strStatus
                    Case "Summe angefordert"
                        frmMain.master_Message_label.Text = webPerson.strAccountName & " - speichere Artikel:" & webBestellung.strArtikel_SKU & " - bestellt : " & iCount_actions
                        clsDatenbank_modul.setEiSoOrder_status(webBestellung.strArtikel_SKU, clsDatenbank.yabe_bestellstatus.bestellt)
                    Case "Bezahlung erfolgt"
                        frmMain.master_Message_label.Text = webPerson.strAccountName & " - Speichere Artikel:" & webBestellung.strArtikel_SKU & " - bezahlt :" & iCount_actions
                        clsDatenbank_modul.setEiSoOrder_status(webBestellung.strArtikel_SKU, clsDatenbank.yabe_bestellstatus.bezahlt)
                    Case "Artikel zugestellt"
                        frmMain.master_Message_label.Text = webPerson.strAccountName & " - Speichere Artikel:" & webBestellung.strArtikel_SKU & " - verschickt : " & iCount_actions
                        clsDatenbank_modul.setEiSoOrder_status(webBestellung.strArtikel_SKU, clsDatenbank.yabe_bestellstatus.verschickt)
                    Case "Transaktion abges"
                        frmMain.master_Message_label.Text = webPerson.strAccountName & " - Speichere Artikel:" & webBestellung.strArtikel_SKU & " - Transaktion abgeschlossen : " & iCount_actions
                        clsDatenbank_modul.setEiSoOrder_status(webBestellung.strArtikel_SKU, clsDatenbank.yabe_bestellstatus.komplett)
                    Case "Transaktion abgeschlossen"
                        frmMain.master_Message_label.Text = webPerson.strAccountName & " - Speichere Artikel:" & webBestellung.strArtikel_SKU & " - Transaktion abgeschlossen : " & iCount_actions
                        clsDatenbank_modul.setEiSoOrder_status(webBestellung.strArtikel_SKU, clsDatenbank.yabe_bestellstatus.komplett)
                        'Case ""
                        'clsDatenbank_modul.setYABE_Order_status(webBestellung.strArtikel_SKU, clsDatenbank.yabe_bestellstatus.storniert)
                End Select


                '   MsgBox(webPerson.strAccountName & " / " & webBestellung.strStatus & " / SKU:" & webBestellung.strArtikel_SKU & " - " & iCount & " von " & strSourceLines.Length)
            End If



        Next iCount

    End Function

    '####################################################
    '# >> YABE -> Webbrwser LADEN KOMPLETT 
    '####################################################
    Private Sub webMain_DocumentCompleted_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webMain.DocumentCompleted

        If webIsLoading = False Then

            webIsLoading = True
            StatusStrip1.Items(0).Text = "Fertig: " & webMain.Url.ToString

            If strURL = "http://delcampe.de/status.php?language=G&page=05&noarchive=Y#StatusContent" Or strURL = "http://delcampe.de/status.php?language=G&page=05&noarchive=N&p=all&rs_count=176#StatusContent" Then
                ' Stauts von Delcampe holen (aktuell oder Archiv) 
                If getDelcampeStatus() = True Then
                    '# Refresh vom Hintergrundliste 

                Else
                    MsgBox("Probleme beim empfangen")
                End If



            End If

            '# TO CHANGE JB
            If webMain.DocumentText.IndexOf("Geben Sie Ihr Login und Pa") > -1 Then
                webMain.Document.GetElementById("password").Focus()
                webMain.Document.GetElementById("nickname").InnerText = My.Settings.delcampe_username
                webMain.Document.GetElementById("password").InnerText = My.Settings.delcampe_pwd
                webMain.Document.GetElementById("autologin").InnerText = "checked"
                SendKeys.Send("{ENTER]")
            End If

            Select Case mWebLinkCollectionStatus
                '# VERSAND + Adressen 
                Case mWebLinksCol.delcampe_adressen

                    If bAutoModus = True Then
                        webMain.Print()
                        bAutoModus = False
                    End If
                    Call setWebBrowser_delcampe_adressen(cmdSprachen.Text)

                    '# Delcampe - Versand 
                Case mWebLinksCol.delcampe_versand

                    webMain.Focus()

                    Call setWebBrowser_delcampe_versand(cmdSprachen.Text)

                    '# Delcampe - BEWERTEN 
                Case mWebLinksCol.delcampe_bewerten
                    Call setWebBrowser_delcampe_bewertung()

                    '# eBay - Versandkosten 
                Case mWebLinksCol.ebay_versandkosten

                    dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)

                    If chkPaypalMit.Checked = True Then
                        Try
                            webMain.Document.GetElementById("ShippingAndHandling1").InnerText = dblPaypal - dblEndsumme
                        Catch ex As Exception
                            StatusStrip1.Text = "Kein Preis auf bei Delcampe"
                        End Try

                    Else
                        Try
                            webMain.Document.GetElementById("ShippingAndHandling1").InnerText = dblVersnd
                        Catch ex As Exception
                            StatusStrip1.Text = "Kein Preis auf bei Delcampe"
                        End Try

                    End If

            End Select

            webIsLoading = False

        End If
    End Sub

    Public Function setWebBrowser_delcampe_adressen(Optional ByVal strOverWriteLanguage As String = "")
        Dim strLanguage As String = ""
        Dim strSprache_liste As String = ""
        Try
            '#########################################
            '# Richtige Sprache auswählen 
            '#########################################
            If strOverWriteLanguage.Length > 0 Then
                strLanguage = strOverWriteLanguage
            Else
                strLanguage = lvwDataView.SelectedItems(0).SubItems(17).Text.ToUpper
                strSprache_liste = lvwDataView.SelectedItems(0).SubItems(21).Text.ToUpper
            End If

            '#########################################
            '# Länderprüfung fehlt noch 
            '#########################################
            If strLanguage.ToUpper = "DEUTSCHLAND" Or strLanguage = "Deutsch" Then

                ' strMessage(0) = clsDatenbank_modul.getTranslationText(16, "Text") ' Deutsche Vorlage


                If Not dblVersnd = 0 Then
                    Try
                        webMain.Document.GetElementById("port_fees").InnerText = dblVersnd
                    Catch ex As Exception
                        StatusStrip1.Text = "Kein Versandfeld"
                    End Try

                End If

                '# Paypal Anteil in Versandkosten vorhanden? 
                If chkPaypalMit.Checked = True Then
                    dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)
                    Try
                        webMain.Document.GetElementById("port_fees").InnerText = dblPaypal - dblEndsumme
                    Catch ex As Exception
                        StatusStrip1.Text = "Kein Versandfeld"
                    End Try

                Else
                    Try
                        webMain.Document.GetElementById("port_fees").InnerText = dblVersnd
                    Catch ex As Exception
                        StatusStrip1.Text = "Kein Versandfeld"
                    End Try

                End If

            Else

                Dim dblVersnd2 As Double = 0


                If dblPaypal > 0 Then
                    dblVersnd2 = dblPaypal - dblEndsumme
                Else
                    dblVersnd2 = dblVersnd
                    dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)
                End If

                '# Paypal Anteil in Versandkosten vorhanden? 
                If chkPaypalMit.Checked = True Then
                    Try
                        webMain.Document.GetElementById("port_fees").InnerText = dblPaypal - dblEndsumme
                    Catch ex As Exception
                        StatusStrip1.Text = "Kein Versandfeld"
                    End Try

                Else
                    Try
                        webMain.Document.GetElementById("port_fees").InnerText = dblVersnd
                    Catch ex As Exception
                        StatusStrip1.Text = "Kein Versandfeld"
                    End Try

                End If

            End If

            Try
                webMain.Document.GetElementById("port_fees").Focus()
            Catch ex As Exception
                StatusStrip1.Text = "Kein Focus für Versand möglich"
            End Try

            SendKeys.Send(" ")
        Catch ex As Exception

        End Try
    End Function
    Private Sub DelcampeAutoprintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeAutoprintToolStripMenuItem.Click
        mWebLinkCollectionStatus = mWebLinksCol.delcampe_adressen
        bAutoModus = True
        setDataUpdate()
    End Sub

    Private Sub EBayVersanddatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayVersanddatenToolStripMenuItem.Click
        mWebLinkCollectionStatus = mWebLinksCol.ebay_versandkosten
        setDataUpdate()
    End Sub

    Private Sub ShopAdminpanelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopAdminpanelToolStripMenuItem1.Click
        webMain.Navigate(My.Settings.shop_url & "/ACP/adminpanel.php")
    End Sub

    Private Sub ShopAdminbestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopAdminbestellungenToolStripMenuItem.Click
        webMain.Navigate(My.Settings.shop_url & "/ACP/admin_Bestellungen.php")
    End Sub

    Private Sub ShopArtikelvorbestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopArtikelvorbestelltToolStripMenuItem.Click
        webMain.Navigate(My.Settings.shop_url & "/CMS/ACP/bestellung_vorbestellt.php?type=1")
    End Sub

    Private Sub MeinDelcampeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeinDelcampeToolStripMenuItem1.Click
        webMain.Navigate("http://delcampe.de/status.php?&language=G&page=05&noarchive=Y&sort=date_end&showImages=Y#StatusContent")
    End Sub

    Private Sub MeinEBayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeinEBayToolStripMenuItem1.Click
        webMain.Navigate("http://my.ebay.de/ws/eBayISAPI.dll?MyEbay")
    End Sub

    Private Sub MeineBewertungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeineBewertungenToolStripMenuItem.Click
        webMain.Navigate("http://delcampe.de/status.php?language=G&page=20#StatusContent")

    End Sub

    Private Sub MeineStatistikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeineStatistikToolStripMenuItem.Click
        webMain.Navigate("http://delcampe.de/status.php?language=G&page=23#StatusContent")
    End Sub

    Private Sub MeineKontostandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeineKontostandToolStripMenuItem.Click

        webMain.Navigate("http://delcampe.de/status.php?language=G&page=27#StatusContent")

    End Sub

    Private Sub YABEMapsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEMapsToolStripMenuItem.Click

        mWebLinkCollectionStatus = mWebLinksCol.yabe_google_maps
        Call setDataUpdate()

    End Sub

    '# >> Zeige Google Karte 
    Private Function getGoogleMaps() As Boolean


        Dim strAdresse As String = ""
        strAdresse = webPerson.strAdress & ", " & webPerson.strOrt
        strAdresse = strAdresse.Replace(" ", "+")
        strAdresse &= "," & webPerson.strLand.Replace(" ", "")

        Try
            webMain.Navigate("http://maps.google.de/?f=d&source=s_d&saddr=Alter+Postweg+154,+26133+Oldenburg+(Oldenburg),+Niedersachsen&daddr=" & strAdresse)
        Catch ex As Exception

        End Try


    End Function

    Private Function getYasniPerson() As Boolean

        Dim strName As String = ""
        strName = webPerson.strName.Replace(" ", "+")

        Try
            webMain.Navigate("http://www.yasni.de/index.php?action=search&search=1&sh=&name=" & strName & "&filter=Stichwort")
        Catch ex As Exception

        End Try


    End Function

    Private Function getDasOertliche() As Boolean

        Dim strName As String = ""
        Dim strOrt As String = ""

        strName = webPerson.strName.Replace(" ", "+")
        strOrt = webPerson.strOrt.Replace(" ", "+")

        Try
            webMain.Navigate("http://www1.dasoertliche.de/?form_name=search_nat&vert_ok=1&zvo_ok=1&kgs=03403000&rgid=&buab=&zbuab=&buc=553&action=43&page=0&image=+&topKw=0&rci=yes&ci=" & strOrt & "&la=de&choose=true&kw=" & strName & "&context=0&noList=false")
        Catch ex As Exception

        End Try


    End Function

    Private Sub YABEYASNIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEYASNIToolStripMenuItem.Click

        mWebLinkCollectionStatus = mWebLinksCol.yabe_personensuche_yasni
        Call setDataUpdate()

    End Sub

    Private Sub YABEDasOertlicheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEDasOertlicheToolStripMenuItem.Click

        mWebLinkCollectionStatus = mWebLinksCol.yabe_dasoertliche
        Call setDataUpdate()

    End Sub

    Private Sub SplitContainer1_Panel1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer1.Panel1.MouseDoubleClick

    End Sub

    Private Sub ImmerImVordergrundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPlattform_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub setInfobar()

        If InfobarAnzeigenToolStripMenuItem.Checked = False Then
            InfobarAnzeigenToolStripMenuItem.Checked = True
            SplitContainer1.Panel1Collapsed = True
            My.Settings.gui_webbrowser_InfoBar = True
            My.Settings.Save()
        Else
            InfobarAnzeigenToolStripMenuItem.Checked = False
            SplitContainer1.Panel1Collapsed = False
            My.Settings.gui_webbrowser_InfoBar = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub InfobarAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfobarAnzeigenToolStripMenuItem.Click

        Call setInfobar()

    End Sub


    Public Sub goNavigate(ByVal strURL As String)
        webMain.Navigate(strURL)
    End Sub

    Private Sub setOnTop()
        If ImmerImVordergrundToolStripMenuItem1.Checked = False Then
            ImmerImVordergrundToolStripMenuItem1.Checked = True
            Me.TopMost = True
            My.Settings.gui_webbrowser_IsOnTop = True
            My.Settings.Save()
        Else
            ImmerImVordergrundToolStripMenuItem1.Checked = False
            Me.TopMost = False
            My.Settings.gui_webbrowser_IsOnTop = False
            My.Settings.Save()
        End If

    End Sub
    Private Sub ImmerImVordergrundToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImmerImVordergrundToolStripMenuItem1.Click
        setOnTop()
    End Sub


    Private Sub setTransparent()
        If TransparentToolStripMenuItem.Checked = False Then
            TransparentToolStripMenuItem.Checked = True
            Me.Opacity = 0.6
            My.Settings.gui_webbrowser_transparent = True
            My.Settings.Save()
        Else
            TransparentToolStripMenuItem.Checked = False
            Me.Opacity = 1
            My.Settings.gui_webbrowser_transparent = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub TransparentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransparentToolStripMenuItem.Click
        setTransparent()
    End Sub

    Private Sub webMain_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles webMain.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.F5 Then
            Call setDataUpdate()
        End If
    End Sub

    Private Sub frmWebBrowser_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate

        If strURL.Length = 0 Then
            If lvwDataView.SelectedItems.Count > 0 Then
                strLastValue = lvwDataView.SelectedItems(0).Text
            End If

        End If

    End Sub

    '####################################################################################
    '# >> Neuladen wenn im Hintergrund etwas geändert wurde 
    '####################################################################################
    Private Sub setAutoNeuLaden()
        If BenutzeAutomatischNeuladenhintergrundToolStripMenuItem.Checked = False Then
            BenutzeAutomatischNeuladenhintergrundToolStripMenuItem.Checked = True
            bNeuLaden = True
            My.Settings.gui_webbrowser_NeuLaden = True
            My.Settings.Save()
        Else
            BenutzeAutomatischNeuladenhintergrundToolStripMenuItem.Checked = False
            bNeuLaden = False
            My.Settings.gui_webbrowser_NeuLaden = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub BenutzeAutomatischNeuladenhintergrundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BenutzeAutomatischNeuladenhintergrundToolStripMenuItem.Click

        Call setAutoNeuLaden()

    End Sub

    Private Sub webMain_FileDownload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webMain.FileDownload

    End Sub

    Private Sub webMain_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles webMain.ProgressChanged
        Try
            ToolStripProgressBar1.Maximum = e.MaximumProgress
            ToolStripProgressBar1.Value = e.CurrentProgress
            If Not e.CurrentProgress = e.MaximumProgress Then

                ToolStripBYtes.Text = (Convert.ToDouble(e.CurrentProgress.ToString) / 1024) & " KB"
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdSprachen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSprachen.SelectedIndexChanged

        If bIsForm_load = False Then
            cmdSprachen.Enabled = False
            cmbVorlagen.Enabled = False
            chkPaypalMit.Enabled = False
            'Call setReloadModus()
            '# Kommentar in Echtzeit setzen 
            Call setDelcampe_Kommentar(cmdSprachen.Text)

            cmdSprachen.Enabled = True
            cmbVorlagen.Enabled = True
            chkPaypalMit.Enabled = True
        End If


    End Sub

    Private Sub cmbVorlagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVorlagen.SelectedIndexChanged

        If bIsForm_load = False Then
            cmdSprachen.Enabled = False
            cmbVorlagen.Enabled = False
            chkPaypalMit.Enabled = False
            Call setReloadModus()
            cmdSprachen.Enabled = True
            cmbVorlagen.Enabled = True
            chkPaypalMit.Enabled = True
        End If

    End Sub

    Private Function setReloadModus() As Boolean
        Try
            If bIsForm_load = False Then
                Select Case mWebLinkCollectionStatus
                    Case mWebLinksCol.delcampe_versand
                        Call setWebBrowser_delcampe_versand(cmdSprachen.Text)
                    Case mWebLinksCol.delcampe_bewerten
                        Call setWebBrowser_delcampe_bewertung(cmdSprachen.Text)
                End Select
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setReloadModus")
            Return False
        End Try
    End Function

    Private Sub YABEVorlageneditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEVorlageneditorToolStripMenuItem.Click

        Dim frmEditor As New frmYABE_Vorlageneditor
        frmEditor.StartPosition = FormStartPosition.CenterParent
        frmEditor.iCMBIndex = cmbVorlagen.Text
        frmEditor.Show()

    End Sub

    Private Sub VollbildToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VollbildToolStripMenuItem.Click

        If FullscreenToolStripMenuItem.Checked = True Then
            FullscreenToolStripMenuItem.Checked = False
            MenuStrip1.Visible = True
            SplitContainer1.Panel1Collapsed = False
            Me.WindowState = FormWindowState.Normal
        Else
            FullscreenToolStripMenuItem.Checked = True
            MenuStrip1.Visible = False
            SplitContainer1.Panel1Collapsed = True
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub frmWebBrowser_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        My.Settings.yabe_gui_browser_windows_size = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub frmWebBrowser_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.yabe_gui_browser_location = Me.Location
        My.Settings.Save()
    End Sub

    Private Sub EBayBewertungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayBewertungenToolStripMenuItem.Click

    End Sub

    Private Sub EBayAdressenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayAdressenToolStripMenuItem.Click

    End Sub

    Private Sub chkPaypalMit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaypalMit.CheckedChanged

        If bIsForm_load = False Then
            cmdSprachen.Enabled = False
            cmbVorlagen.Enabled = False
            chkPaypalMit.Enabled = False

            Select Case mWebLinkCollectionStatus

                Case mWebLinksCol.delcampe_versand
                    dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)

                    '# Paypal Anteil in Versandkosten vorhanden? 
                    If chkPaypalMit.Checked = True Then
                        Try
                            webMain.Document.GetElementById("port_fees").InnerText = dblPaypal - dblEndsumme
                        Catch ex As Exception
                            StatusStrip1.Text = "Versandkostenfeld vorhanden"
                        End Try

                    Else
                        Try
                            webMain.Document.GetElementById("port_fees").InnerText = dblVersnd
                        Catch ex As Exception
                            StatusStrip1.Text = "Versandkostenfeld vorhanden"
                        End Try

                    End If

                    Try
                        webMain.Document.GetElementById("port_fees").Focus()
                    Catch ex As Exception
                        StatusStrip1.Text = "Kein Focus auf Versandkosten möglich"
                    End Try

                    SendKeys.Send(" ")

                Case mWebLinksCol.ebay_versandkosten
                    dblPaypal = setCalcPaypal(dblEndsumme, dblVersnd)

                    If chkPaypalMit.Checked = True Then
                        Try
                            webMain.Document.GetElementById("ShippingAndHandling1").InnerText = dblPaypal - dblEndsumme
                        Catch ex As Exception
                            StatusStrip1.Text = "Keine Versandkosten vorhanden"
                        End Try

                    Else
                        Try
                            webMain.Document.GetElementById("ShippingAndHandling1").InnerText = dblVersnd
                        Catch ex As Exception
                            StatusStrip1.Text = "Keine Versandkosten"
                        End Try
                        
                    End If

            End Select


            cmdSprachen.Enabled = True
            cmbVorlagen.Enabled = True
            chkPaypalMit.Enabled = True

        End If

    End Sub

    Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class