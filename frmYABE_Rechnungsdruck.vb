Public Class frmYABE_Rechnungsdruck

    Public lvwDataInput As ListView


    Dim clsRechungsdruck As New clsRechnungsdruck

    Private strPathVorlage As String = ""
    Dim dblNr As Double
    Dim strMaster_Email As String

    Private Function getYABERechnung_Kundenanschrift(ByRef strData As String) As Boolean
        Dim strUserData As ArrayList
        Try
            '# Kundendaten abrufen         
            strUserData = clsDatenbank_modul.getYABEUserData(lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_email).Text)

            ' Benutzerdaten gefunden
            If strUserData.Count <> 0 Then

                '# Kundenanschrift 
                strData = strData.Replace("###NAME###", strUserData.Item(0).ToString)
                strData = strData.Replace("###STRASSE###", strUserData.Item(1).ToString)
                strData = strData.Replace("###PLZ###", strUserData.Item(3).ToString)
                strData = strData.Replace("###ORT###", strUserData.Item(2).ToString)
                strData = strData.Replace("###LAND###", strUserData.Item(5).ToString)
                strData = strData.Replace("###EMAIL###", lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_email).Text)
                strMaster_Email = lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_email).Text
                strData = strData.Replace("###MITGLIEDSNAME###", lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_mitglied).Text)

            End If

        Catch ex As Exception
            Call debug_message(ex, "getYABERechnung_Kundenanschrift")
            Return False
        End Try
    End Function

    Private Function getYABERechnung_Artikel(ByRef strData As String, strFieldMapping As String, ByVal strEmail_kunde_rechnung As String) As Boolean
        Dim iCount As Integer = 0
        Dim strArtikelListe As String = ""
        Dim dblGesPreis As Double = 0
        Dim dblGesVersandkosten As Double = 0
        Dim dblGesPaypal As Double = 0
        Dim dblMwst_artikel As Double = 0
        Dim dblMwst_versand As Double = 0
        Dim dblMwst_gesammt As Double = 0
        Dim strTitle As String = ""
        Dim strEiSoID_ary() As String
        strArtikelListe &= "<div>"
        Try


            For iCount = 0 To lvwDataInput.SelectedItems.Count - 1


                If strEmail_kunde_rechnung = lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_email).Text Then


                    If My.Settings.eiso_basis_sprache = False Then

                        strEiSoID_ary = lvwDataInput.SelectedItems(iCount).SubItems(0).Text.Split("-")

                        Select Case strFieldMapping
                            Case "_eng"
                                strTitle = clsDatenbank_modul.getTitlebyID(strEiSoID_ary(0), strFieldMapping)

                                If strTitle = "" Then
                                    strTitle = lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_beschreibung).Text
                                End If
                            Case "_fr"
                                strTitle = clsDatenbank_modul.getTitlebyID(strEiSoID_ary(0), strFieldMapping)

                                If strTitle = "" Then
                                    strTitle = clsDatenbank_modul.getTitlebyID(strEiSoID_ary(0), strFieldMapping)
                                    If strTitle = "" Then
                                        strTitle = lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_beschreibung).Text
                                    End If
                                End If

                            Case Else
                                strTitle = lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_beschreibung).Text
                        End Select

                    Else
                        strTitle = lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_beschreibung).Text
                    End If

                    Try
                        dblGesPreis += Convert.ToDouble(lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_preis).Text)
                    Catch ex As Exception

                    End Try

                    If dblGesVersandkosten < Convert.ToDouble(lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_versand).Text.Replace(",", ".")) Then
                        dblGesVersandkosten = lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_versand).Text
                    End If

                    If dblGesPaypal < Convert.ToDouble(lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_paypal).Text.Replace(",", ".")) Then
                        dblGesPaypal = lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_paypal).Text
                    End If

                    strArtikelListe &= "<div style=""width:70%;float:left"">"
                    strArtikelListe &= strTitle
                    strArtikelListe &= "</div>"
                    strArtikelListe &= "<div style=""width:30%;float:left"">"
                    strArtikelListe &= lvwDataInput.SelectedItems(iCount).SubItems(clsRechungsdruck.ilvwMapp_preis).Text & " Euro"
                    strArtikelListe &= "</div>"
                    strArtikelListe &= "<div style=""float:clear"">&nbsp;"
                    strArtikelListe &= "</div>"

                End If
            Next iCount

            '# 

            strArtikelListe &= "<br/><div style=""float:left;width:40%;padding:3px;text-align:right"">"

            If chkMwstOhne.Checked = True Then
                Select Case cmbSprache_Rechnungsdruck.Text
                    Case "Deutsch"
                        strArtikelListe &= "Artikel Umsatz: "
                    Case "Englisch"
                        strArtikelListe &= "Item sales: "
                End Select

            Else
                Select Case cmbSprache_Rechnungsdruck.Text
                    Case "Deutsch"
                        strArtikelListe &= "Artikel Umsatz: "
                    Case "Englisch"
                        strArtikelListe &= "Item sales: "
                End Select
            End If

            'Str(0) = dbReader("shippment_amount").ToString
            'Str(1) = dbReader("order_total").ToString
            'Str(2) = dbReader("paypal_total_sum").ToString
            'Str(3) = dbReader("total_sum_amount").ToString
            'Str(4) = dbReader("total_rabatt").ToString
            'Str(5) = dbReader("total_rabatt_prozent").ToString
            ' 6 = Kommentar
            ' 7 = Versandart
            Dim strSplitID() As String = lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_eiso_orderlist_id).Text.Split("-")
            Dim strOrderData() As String = clsDatenbank_modul.getOrderListDetails(strSplitID(0))


            strArtikelListe &= "</div>"
            strArtikelListe &= "<div style=""float:clear;width:50%;padding:3px;"">"
            strArtikelListe &= strOrderData(1) & " Euro"
            strArtikelListe &= "</div>"


            '# Rabatt Spalte anzeigen
            If Convert.ToDouble(strOrderData(5)) > 0 Then
                strArtikelListe &= "<div style=""float:left;width:40%;padding:3px;text-align:right"">"

                Select Case cmbSprache_Rechnungsdruck.Text
                    Case "Deutsch"
                        strArtikelListe &= "Rabatt " & strOrderData(5) & "%: "
                    Case "Englisch"
                        strArtikelListe &= "Discount " & strOrderData(5) & ": "
                End Select

                strArtikelListe &= "</div>"
                strArtikelListe &= "<div style=""float:clear;width:50%;padding:3px;"">"
                strArtikelListe &= strOrderData(4) & " Euro"
                strArtikelListe &= "</div>"

                strArtikelListe &= "<div style=""float:left;width:40%;padding:3px;text-align:right"">"

                Select Case cmbSprache_Rechnungsdruck.Text
                    Case "Deutsch"
                        strArtikelListe &= "Zwischensumme:"
                    Case "Englisch"
                        strArtikelListe &= "Sum:"
                End Select

                strArtikelListe &= "</div>"
                strArtikelListe &= "<div style=""float:clear;width:50%;padding:3px;"">"
                strArtikelListe &= Convert.ToDouble(strOrderData(1)) - Convert.ToDouble(strOrderData(4)) & " Euro"
                strArtikelListe &= "</div>"
            End If

            strArtikelListe &= "<div style=""float:left;width:40%;padding:3px;text-align:right"">"

            Select Case cmbSprache_Rechnungsdruck.Text
                Case "Deutsch"
                    strArtikelListe &= "Versandkosten: "
                Case "Englisch"
                    strArtikelListe &= "Shipping costs: "
            End Select

            strArtikelListe &= "</div>"
            strArtikelListe &= "<div style=""float:clear;width:50%;padding:3px;"">"
            strArtikelListe &= strOrderData(0) & " Euro"
            strArtikelListe &= "</div>"

            '####################################################
            '# >> Email Rechnung Vorlage
            '####################################################
            If chkMwstOhne.Checked = False Then
                strArtikelListe &= "<div style=""float:left;width:40%;padding:3px;text-align:right"">"

                Select Case cmbSprache_Rechnungsdruck.Text
                    Case "Deutsch"
                        strArtikelListe &= "Mwst: "
                    Case "Englisch"
                        strArtikelListe &= "Sales tax:"
                End Select

                strArtikelListe &= "</div>"
                strArtikelListe &= "<div style=""float:clear;width:50%;padding:3px;"">"
                Dim dblMwst As Double = Convert.ToDouble(strOrderData(1)) + Convert.ToDouble(strOrderData(0))
                dblMwst_artikel = Convert.ToDouble(strOrderData(1)) / 100 * My.Settings.yabe_gui_rechnung_mwst
                dblMwst_versand = Convert.ToDouble(strOrderData(0)) / 100 * My.Settings.yabe_gui_rechnung_mwst_versand
                dblMwst_gesammt = dblMwst_artikel + dblMwst_versand
                strArtikelListe &= Math.Round(dblMwst_gesammt, 2) & " Euro"
                strArtikelListe &= "</div>"
            End If

            strArtikelListe &= "<div style=""float:left;width:40%;text-align:right;padding:3px;"">"

            Select Case cmbSprache_Rechnungsdruck.Text
                Case "Deutsch"
                    strArtikelListe &= "<strong>Endsumme:</strong>"
                Case "Englisch"
                    strArtikelListe &= "<strong>total sum:</strong>"
            End Select

            strArtikelListe &= "</div>"
            strArtikelListe &= "<div style=""float:clear;width:50%;padding:3px;"">"
            If chkMwstInkl.Checked = True Then
                strArtikelListe &= "<strong>" & Math.Round(Convert.ToDouble(strOrderData(3)) + Convert.ToDouble(strOrderData(0)) + dblMwst_gesammt, 2) & " Euro" & "</strong>"
            Else
                strArtikelListe &= "<strong>" & Convert.ToDouble(strOrderData(3)) & " Euro" & "</strong>"
            End If

            strArtikelListe &= "</div>"

            If chkOhnePaypal.Checked = False Then
                strArtikelListe &= "<div style=""float:left;width:40%;padding:3px;text-align:right"">"


                Select Case cmbSprache_Rechnungsdruck.Text
                    Case "Deutsch"
                        strArtikelListe &= "Mit Paypal Brutto: "
                    Case "Englisch"
                        strArtikelListe &= "with paypal pre-tax"
                End Select

                strArtikelListe &= "</div>"
                strArtikelListe &= "<div style=""float:clear;width:50%;padding:3px;"">"
                strArtikelListe &= strOrderData(2) & " Euro"
                strArtikelListe &= "</div>"
            End If


            strArtikelListe &= "</div>" ' Rahmen außen 
            strData = strData.Replace("###ARTIKELLISTE###", strArtikelListe)

            Dim strNr As String = clsDatenbank_modul.getInvioce_Nr()
            'Dim strNr As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\rechnungen\nr.dat")
            dblNr = Convert.ToDouble(strNr)

            dblNr += 1
            strData = strData.Replace("###RNR###", Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & "/" & dblNr)
            Return True
        Catch ex As Exception
            Call debug_message(ex, "getYABERechnung_Artikel")
            Return False
        End Try
    End Function


    Private Function setYABENewRechnung() As Boolean
        Try

            If bIsLoading = False Then


                Dim strData As String = ""
                Dim strFile As String
                Dim strISOName As String = ""

                '# Vorlage YABE Rechnung -> Laden 
                strISOName = clsDatenbank_modul.getTranslate_l18n_mapping(cmbSprache_Rechnungsdruck.Text)
                strData = clsDatenbank_modul.getTranslationText(cmbVorlagen.Text, "Text" & strISOName) ' Englische Vorlage 



                '# Kundendaten ersetzen 
                Call getYABERechnung_Kundenanschrift(strData)

                '# Artikelliste holen 
                Call getYABERechnung_Artikel(strData, strISOName, lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_email).Text)

                '# Logo entfernen
                strData = strData.Replace("###LOGO###", "")
                strData = strData.Replace("###KAUFDATUM###", " - " & lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_kaufdatum).Text)
                strData = strData.Replace("###PLATTFORM###", " - " & lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_plattform).Text)

                strFile = Application.StartupPath & "\vorlagen\YABE_Rechnung.html"
                My.Computer.FileSystem.WriteAllText(strFile, strData, False)
                webYabeRechnung.Navigate("file://" & strFile)

            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setYABENewRechnung")
            Return False
        End Try

    End Function
    Private Sub frmYABERechnung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '    Me.Location = My.Settings.yabe_gui_rechnungsdruck_location
        '  Me.Size = My.Settings.yabe_gui_rechnungsdruck_size

        Call setToolbar(False)

        chkArchiv.Checked = My.Settings.eiso_rechnung_gui_archivieren
        chkMitEmail.Checked = My.Settings.eiso_rechnung_gui_email
        chkRechnungDruck.Checked = My.Settings.eiso_rechnung_gui_druck
        chkMwstOhne.Checked = My.Settings.eiso_rechnung_gui_keine_mwst
        chkOhnePaypal.Checked = My.Settings.eiso_rechnung_gui_ohnePaypal

        '# Sprachen abrufen 
        Application.DoEvents()

        bIsLoading = True
        Call clsDatenbank_modul.getComboSprachen(cmbSprache_Rechnungsdruck)
        Dim strSprache As String = ""

        Select Case lvwDataInput.Name
            Case "lvwBestellungen_bestelliste_neu", "lvwBestellverwaltung_nach_artikel"
                'strSprache = lvwDataInput.SelectedItems(0).SubItems(13).Text
                strSprache = clsDatenbank_modul.getCustomer_sprache(lvwDataInput.SelectedItems(0).SubItems(9).Text)

            Case "lvwEiSoCockpit"
                strSprache = clsDatenbank_modul.getCustomer_sprache(lvwDataInput.SelectedItems(0).SubItems(6).Text)
        End Select

        If strSprache.Contains("Deutsch") = True Then
            cmbSprache_Rechnungsdruck.SelectedIndex = 0
        ElseIf strSprache.Contains("Englisch") Then
            cmbSprache_Rechnungsdruck.SelectedIndex = 1
        ElseIf strSprache.Contains("Französisch") Then
            cmbSprache_Rechnungsdruck.SelectedIndex = 2
        ElseIf strSprache.Contains("Spanisch") Then
            cmbSprache_Rechnungsdruck.SelectedIndex = 3
        ElseIf strSprache.Contains("Russisch") Then
            cmbSprache_Rechnungsdruck.SelectedIndex = 4
        ElseIf strSprache.Contains("Chinesisch") Then
            cmbSprache_Rechnungsdruck.SelectedIndex = 5
        ElseIf strSprache = "" Then
            cmbSprache_Rechnungsdruck.SelectedIndex = 0
        End If



        '   cmbSprache_Rechnungsdruck.SelectedIndex = 0
        Call clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlagen, "Rechnungen")
        cmbVorlagen.SelectedIndex = 0
        bIsLoading = False

        Select Case lvwDataInput.Name

            Case "lvwEiSoCockpit"
                clsRechungsdruck.ilvwMapp_email = 6
                clsRechungsdruck.ilvwMapp_versand = 12
                clsRechungsdruck.ilvwMapp_mitglied = 5
                clsRechungsdruck.ilvwMapp_beschreibung = 1
                clsRechungsdruck.ilvwMapp_preis = 2
                clsRechungsdruck.ilvwMapp_paypal = 18
                clsRechungsdruck.ilvwMapp_kaufdatum = 9
                clsRechungsdruck.ilvwMapp_plattform = 17
                clsRechungsdruck.ilvwMapp_eiso_orderlist_id = 26
            Case "lvwArtikelListe"
                clsRechungsdruck.ilvwMapp_email = 8
                clsRechungsdruck.ilvwMapp_versand = 2
                clsRechungsdruck.ilvwMapp_mitglied = 9
                clsRechungsdruck.ilvwMapp_beschreibung = 1
                clsRechungsdruck.ilvwMapp_preis = 2
                clsRechungsdruck.ilvwMapp_paypal = 2
                clsRechungsdruck.ilvwMapp_kaufdatum = 7
                clsRechungsdruck.ilvwMapp_plattform = 5
                clsRechungsdruck.ilvwMapp_eiso_orderlist_id = 12

            Case "lvwBestellverwaltung_nach_artikel", "lvwBestellungen_bestelliste_neu"
                clsRechungsdruck.ilvwMapp_email = 9
                clsRechungsdruck.ilvwMapp_versand = 6
                clsRechungsdruck.ilvwMapp_mitglied = 1
                clsRechungsdruck.ilvwMapp_beschreibung = 4
                clsRechungsdruck.ilvwMapp_preis = 5
                clsRechungsdruck.ilvwMapp_paypal = 16
                clsRechungsdruck.ilvwMapp_kaufdatum = 10
                clsRechungsdruck.ilvwMapp_plattform = 13
            Case Else
                clsRechungsdruck.ilvwMapp_email = 10
                clsRechungsdruck.ilvwMapp_versand = 7
                clsRechungsdruck.ilvwMapp_mitglied = 9
                clsRechungsdruck.ilvwMapp_beschreibung = 1
                clsRechungsdruck.ilvwMapp_preis = 2
                clsRechungsdruck.ilvwMapp_paypal = 8
                clsRechungsdruck.ilvwMapp_kaufdatum = 5
                clsRechungsdruck.ilvwMapp_plattform = 6
        End Select

        Application.DoEvents()
        Call setYABENewRechnung()

    End Sub

    Private Sub webYabeRechnung_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webYabeRechnung.DocumentCompleted

    End Sub

    Private Sub frmYABERechnung_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    '#############################################################
    '# >> Bearbeitungsschaltflächen ausblenden, wenn erforderlich 
    '#############################################################
    Private Function setToolbar(ByVal bMode As Boolean) As Boolean
        Try

            NeuToolStripButton.Visible = bMode
            ÖffnenToolStripButton.Visible = bMode
            SpeichernToolStripButton.Visible = bMode
            DruckenToolStripButton.Visible = bMode
            AusschneidenToolStripButton.Visible = bMode
            KopierenToolStripButton.Visible = bMode
            EinfügenToolStripButton.Visible = bMode
            Bold.Visible = bMode
            Suchen.Visible = bMode
            Hyperlink.Visible = bMode
            Bild.Visible = bMode
            Redo.Visible = bMode
            Undo.Visible = bMode
            tabelle.Visible = bMode
            toolStripSeparator.Visible = bMode
            toolStripSeparator2.Visible = bMode

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setToolbar")
            Return False
        End Try
    End Function

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Static bStatic As Boolean

        If bStatic = False Then
            DHTMLControll.DOM.body.innerHTML = webYabeRechnung.DocumentText
            webYabeRechnung.Visible = False
            DHTMLControll.Visible = True
            bStatic = True
            btnPrint.Enabled = False
            LinkLabel2.Text = "Editiermodus &beenden"
            Call setToolbar(True)
            LinkLabel1.Visible = True
        Else
            Dim strFile As String = Application.StartupPath & "\vorlagen\tmp_rechnung.html"
            My.Computer.FileSystem.WriteAllText(strFile, DHTMLControll.DOM.body.innerHTML, False)
            btnPrint.Enabled = True
            webYabeRechnung.Visible = True
            webYabeRechnung.Navigate(strFile)
            Call setToolbar(False)
            LinkLabel2.Text = "Rechnung &editieren"
            DHTMLControll.Visible = False
            LinkLabel1.Visible = False
            bStatic = False
        End If


    End Sub

    Private Sub frmYABERechnung_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.yabe_gui_rechnungsdruck_location = Me.Location
        My.Settings.yabe_gui_rechnungsdruck_size = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Text = "HTML" Then
            LinkLabel1.Text = "Design"
            txtVorlageQuellcode.Visible = True
            txtVorlageQuellcode.Text = DHTMLControll.DOM.body.innerHTML
            DHTMLControll.Visible = False
        Else
            LinkLabel1.Text = "HTML"
            DHTMLControll.DOM.body.innerHTML = txtVorlageQuellcode.Text
            txtVorlageQuellcode.Visible = False
            DHTMLControll.Visible = True
        End If
    End Sub

    Private Sub NeuToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripButton.Click
        If DHTMLControll.DocumentHTML.Length > 0 Then

            If MessageBox.Show("Soll die Datei " & strPathVorlage & " wirklich geschlossen werden?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                DHTMLControll.DocumentHTML = ""
            End If
        End If
    End Sub

    Private Sub ÖffnenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripButton.Click


        OpenFileDialog1.Title = "YABE -> HTML Import"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            strPathVorlage = OpenFileDialog1.FileName

            DHTMLControll.DOM.body.innerHTML = ""
            txtVorlageQuellcode.Text = ""

            If LinkLabel1.Text = "HTML" Then
                DHTMLControll.DOM.body.innerHTML = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Else
                txtVorlageQuellcode.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If

            frmMain.master_Message_label.Text = "Lade Vorlage:  " & OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub SpeichernToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripButton.Click
        Dim strHTMLExport As String = ""

        SaveFileDialog1.Title = "YABE -> HTML Export"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strHTMLExport = SaveFileDialog1.FileName
        Else
            MsgBox("Es ist ein Fehler beim Speichern aufgetretten", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "YABE -> Fehler beim Speichern")
        End If


        If LinkLabel1.Text = "HTML" Then
            My.Computer.FileSystem.WriteAllText(strHTMLExport, DHTMLControll.DOM.body.innerHTML, False)
        Else
            My.Computer.FileSystem.WriteAllText(strHTMLExport, txtVorlageQuellcode.Text, False)
        End If

        MsgBox("Datei wurde unter '" & strHTMLExport & "' gespeichert", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "YABE - Datei gespeichert")

    End Sub

    Private Sub DruckenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripButton.Click
        DHTMLControll.PrintDocument()
    End Sub

    Private Function setLook(ByVal bModus As Boolean) As Boolean
        Try

            cmbSprache_Rechnungsdruck.Enabled = bModus
            cmbVorlagen.Enabled = bModus
            btnAbbrechen.Enabled = bModus
            btnPrint.Enabled = bModus

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setLook")
            Return False
        End Try
    End Function

    '######################################################
    '# >> Neuladen der Vorlage 
    '######################################################
    Private Function getReload() As Boolean
        Try
            Dim strISOName As String = ""

            Call setLook(False)

            strISOName = clsDatenbank_modul.getTranslate_l18n_mapping(cmbSprache_Rechnungsdruck.Text)
            DHTMLControll.DOM.body.innerHTML = clsDatenbank_modul.getTranslationText(cmbVorlagen.Text, "Text" & strISOName) ' Englische Vorlage 
            Call setYABENewRechnung()

            Call setLook(True)
            Return True

        Catch ex As Exception
            Call debug_message(ex, "getReload")
            Return False
        End Try
    End Function

    Private Sub cmbSprache_Rechnungsdruck_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSprache_Rechnungsdruck.SelectedIndexChanged

        If bIsLoading = False Then
            Call getReload()
        End If

    End Sub

    Private Sub cmbVorlagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVorlagen.SelectedIndexChanged
        If bIsLoading = False Then
            Call getReload()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call setBack()
    End Sub

    '#################################################
    '# >> Artikel -> zurückblättern
    '#################################################
    Private Function setBack() As Boolean
        Try


            If lvwDataInput.SelectedItems.Count > 0 Then

                If lvwDataInput.SelectedItems.Count > 1 Then
                    Dim iSelected As Integer = 0
                    For iSelected = 0 To lvwDataInput.SelectedItems.Count - 1
                        lvwDataInput.SelectedItems(iSelected).Selected = False
                    Next
                End If


                Dim strName As String = ""
                Dim iSel As Integer = 0
                Dim ianzahl As Integer = 0
                Dim iSel2 As Integer = 0

                '# Aktuellen abwählen 
                strName = lvwDataInput.SelectedItems(0).SubItems(1).Text
                iAnzahl = lvwDataInput.SelectedItems(0).Index
                'lvwDataView.Items(iAnzahl).Selected = False

                For iSel = iAnzahl To 0 Step -1

                    If Not strName = lvwDataInput.Items(iSel).SubItems(1).Text Then
                        lvwDataInput.Items(iAnzahl).Selected = False
                        lvwDataInput.Items(iSel).Selected = True

                        '# Artikel selektieren 
                        strName = lvwDataInput.Items(iSel).SubItems(1).Text
                        For iSel2 = iSel To 0 Step -1

                            If strName = lvwDataInput.Items(iSel2).SubItems(1).Text Then
                                lvwDataInput.Items(iSel2).Selected = True
                            Else
                                Exit For
                            End If

                        Next

                        Exit For
                    End If
                Next

                If iSel = -1 Then
                    lvwDataInput.Items(1).Selected = False
                    lvwDataInput.Items(0).Selected = True
                End If

                lvwDataInput.Items(iAnzahl).EnsureVisible()

                Call getReload()
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '#################################################
    '# >> Artikel -> weiterblättern 
    '#################################################
    Private Function setVor() As Boolean
        Try

            If lvwDataInput.SelectedItems.Count > 0 Then

                If lvwDataInput.SelectedItems.Count > 1 Then
                    Dim iSelected As Integer = 0
                    Dim iCount As Integer = lvwDataInput.SelectedItems.Count - 1
                    For iSelected = 0 To iCount
                        lvwDataInput.SelectedItems(iSelected).Selected = False
                    Next
                End If

                Dim ianzahl As Integer = 0

                Dim strName As String = ""
                Dim iSel As Integer = 0
                Dim iSel2 As Integer = 0
                '# Aktuellen abwählen 
                strName = lvwDataInput.SelectedItems(0).SubItems(1).Text
                ianzahl = lvwDataInput.SelectedItems(0).Index
                'lvwDataView.Items(iAnzahl).Selected = False

                For iSel = ianzahl To lvwDataInput.Items.Count - 1

                    If Not strName = lvwDataInput.Items(iSel).SubItems(1).Text Then
                        lvwDataInput.Items(ianzahl).Selected = False
                        lvwDataInput.Items(iSel).Selected = True

                        '# Artikel selektieren 
                        strName = lvwDataInput.Items(iSel).SubItems(1).Text
                        For iSel2 = iSel To lvwDataInput.Items.Count - 1

                            If strName = lvwDataInput.Items(iSel2).SubItems(1).Text Then
                                lvwDataInput.Items(iSel2).Selected = True
                            Else
                                Exit For
                            End If

                        Next

                        Exit For

                    End If
                Next
                lvwDataInput.Items(ianzahl).EnsureVisible()
                Call getReload()
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkArchiv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArchiv.CheckedChanged
        If bIsLoading = False Then
            My.Settings.eiso_rechnung_gui_archivieren = chkArchiv.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkRechnungDruck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRechnungDruck.CheckedChanged
        My.Settings.eiso_rechnung_gui_druck = chkRechnungDruck.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkMwstOhne_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMwstOhne.CheckedChanged
        My.Settings.eiso_rechnung_gui_keine_mwst = chkMwstOhne.Checked
        My.Settings.Save()

        If bIsLoading = False Then
            Call setYABENewRechnung()
            If chkMwstOhne.Checked = False Then
                chkMwstInkl.Enabled = True
            Else
                chkMwstInkl.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkMwstInkl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMwstInkl.CheckedChanged

        If bIsLoading = False Then
            Call setYABENewRechnung()
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim strUserData As ArrayList
        Dim bStatus As Boolean
        btnPrint.Enabled = False
        If chkRechnungDruck.Checked = True Then
            '# Drucken starten 
            webYabeRechnung.Print()
        End If

        '# Archivieren von Rechnungen 
        If chkArchiv.Checked = True Then
            Dim strFilename As String = "RNr." & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "--" & dblNr & ".html"
            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\rechnungen\" & strFilename, webYabeRechnung.DocumentText, False)
            Catch ex As Exception

            End Try

        End If

        '# Neue Rechnungsnummer speichern 
        'My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\rechnungen\nr.dat", dblNr, False)
        clsDatenbank_modul.getInvioce_Nr_update(dblNr)

        '# Email verschicken 
        If chkMitEmail.Checked = True Then
            Dim strFilename As String = "RNr." & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "--" & dblNr & ".html"
            Dim clsRechnung As New clsEmail
            Dim strInhalt As String = ""
            Dim strBetreff As String = ""

            clsRechnung.strEmail_empfänger_email = strMaster_Email

            Dim strISOName As String = clsDatenbank_modul.getTranslate_l18n_mapping(cmbSprache_Rechnungsdruck.Text)
            strInhalt = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_rechnung_emailtext, "Text" & strISOName)

            '# Kundendaten abrufen         
            strUserData = clsDatenbank_modul.getYABEUserData(lvwDataInput.SelectedItems(0).SubItems(clsRechungsdruck.ilvwMapp_email).Text)
            strInhalt = strInhalt.Replace("###NAME###", strUserData.Item(0).ToString)

            strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_rechnung_email_betreff, "Text" & strISOName)
            'strBetreff = "Rechnung Nr." & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & "/" & dblNr

            strBetreff = strBetreff.Replace("###DATUM###", Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year)
            strBetreff = strBetreff.Replace("###RNR###", dblNr)
            strBetreff = strBetreff.Replace("###VERKÄUFER_SHOPNAME###", My.Settings.eiso_shopname)
            strBetreff = strBetreff.Replace("###VERKÄUFER_NAME###", My.Settings.user_vorname & " " & My.Settings.user_nachname)
            strBetreff = strBetreff.Replace("###VERKÄUFER_EBAYNAME###", My.Settings.ebay_username)
            strBetreff = strBetreff.Replace("###VERKÄUFER_EISOUSER###", My.Settings.yabe_username)
            strBetreff = strBetreff.Replace("###VERKÄUFER_EMAIL###", My.Settings.user_email)
            strBetreff = strBetreff.Replace("###VERKÄUFER_ORT###", My.Settings.user_ort)
            strBetreff = strBetreff.Replace("###VERKÄUFER_PLZ###", My.Settings.user_plz)
            strBetreff = strBetreff.Replace("###VERKÄUFER_STRASSE###", My.Settings.user_strasse)
            strBetreff = strBetreff.Replace("###VERKÄUFER_SHOPNAME###", My.Settings.eiso_shopname)
            strBetreff = strBetreff.Replace("###SHOP_URL###", My.Settings.shop_url)
            strBetreff = strBetreff.Replace("###VERKÄUFER_FIRMA###", My.Settings.user_firmenname)

            strInhalt = strInhalt.Replace("###VERKÄUFER_NAME###", My.Settings.user_vorname & " " & My.Settings.user_nachname)
            strInhalt = strInhalt.Replace("###VERKÄUFER_EBAYNAME###", My.Settings.ebay_username)
            strInhalt = strInhalt.Replace("###VERKÄUFER_EISOUSER###", My.Settings.yabe_username)
            strInhalt = strInhalt.Replace("###VERKÄUFER_EMAIL###", My.Settings.user_email)
            strInhalt = strInhalt.Replace("###VERKÄUFER_ORT###", My.Settings.user_ort)
            strInhalt = strInhalt.Replace("###VERKÄUFER_PLZ###", My.Settings.user_plz)
            strInhalt = strInhalt.Replace("###VERKÄUFER_STRASSE###", My.Settings.user_strasse)
            strInhalt = strInhalt.Replace("###VERKÄUFER_SHOPNAME###", My.Settings.eiso_shopname)
            strInhalt = strInhalt.Replace("###SHOP_URL###", My.Settings.shop_url)
            strInhalt = strInhalt.Replace("###VERKÄUFER_FIRMA###", My.Settings.user_firmenname)

            clsRechnung.bDebug_mail = My.Settings.email_testmodus_only
            bStatus = clsRechnung.setRechnung(strInhalt, strBetreff, Application.StartupPath & "\rechnungen\" & strFilename, False)

        End If
        btnPrint.Enabled = True

        Dim strMessage As String = ""
        If bStatus = True Then

            If chkMitEmail.Checked = True Then
                strMessage = vbCr + "Und als Email verschickt."
            End If

            If chkRechnungDruck.Checked = True Then
                strMessage += vbCrLf + "Und an den Standarddrucker gesendet."
            End If

            If chkArchiv.Checked = True Then
                strMessage += vbCrLf + "Und als Archiv HTML gespeichert."
            End If

            MsgBox("Rechnung wurde erstellt" + strMessage, MsgBoxStyle.Information)
        Else
            MsgBox("Rechnung wurde erstellt, aber allem Anschein keine Email an den Kunden geschickt...", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnBack_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Call setBack()
    End Sub

    Private Sub btnVor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Call setVor()
    End Sub

    Private Sub chkOhnePaypal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOhnePaypal.CheckedChanged
        My.Settings.eiso_rechnung_gui_ohnePaypal = chkOhnePaypal.Checked
        My.Settings.Save()

        If bIsLoading = False Then
            Call setYABENewRechnung()
        End If

    End Sub

    Private Sub chkMitEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkMitEmail.CheckedChanged
        My.Settings.eiso_rechnung_gui_email = chkMitEmail.Checked
        My.Settings.Save()

    End Sub
End Class