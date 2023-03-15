'###############################################
'# >> 
'###############################################
Imports System.Globalization
Imports System.IO

Public Class clsEmail

    Public Enum bPlattform
        eBay = 0
        delcampe = 1
        shopsystem = 2
        magento = 3
        shopste = 4
    End Enum


    Public strEmail_empfänger_email As String
    Public bDebug_mail As Boolean
    Public bInit As Boolean = False
    Public setFrom As String
    Public lvwReadIn As ListView
    Public bIsWating As Boolean = False
    Public iIsWatingTime As Integer
    Public SmtpObj As New System.Net.Mail.SmtpClient


    '###########################################
    '# >> Configuriert die Optionen
    '###########################################
    Public Function setConfig(ByVal lvw As ListView, ByVal bsetDebug As Boolean) As Boolean

        Try
            bInit = True
            '# Listview Übertragen
            lvwReadIn = lvw
            bDebug_mail = bsetDebug

        Catch ex As Exception

        End Try

        Return True
    End Function
    '########################################################
    '# >> Liest das eMail Template ein 
    '########################################################
    Public Function getEMailTemplate(ByVal strPfad As String) As String
        Dim strContent As String = ""

        Try
            If Not strPfad.Length = 0 Then
                strContent = My.Computer.FileSystem.ReadAllText(strPfad)
            Else
                MessageBox.Show(Me, "ACHTUNG: Kein Template Pfad definiert", "Kein Template", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return strContent = "-1"
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEMailTemplate")
        End Try

        Return strContent
    End Function

    '#########################################################
    '# >> Template Daten holen 
    '#########################################################
    Public Function getTemplateVars(ByRef strData As String, ByVal strModul As String, ByVal iWoPos As Integer, ByVal strPlattform As bPlattform, strFieldMapping As String) As String

        Dim strTitle As String = ""
        Dim col_Mail As Byte = 0
        Dim col_member As Byte = 0
        Dim col_preis_ende As Byte = 0
        Dim col_plattform As Byte = 0
        Dim col_beschreibung As Byte = 0
        Dim col_yabe_id As Byte = 0
        Dim col_bild_name As Byte = 0
        Dim col_menge As Byte = 0

        '# Dynamische spalten 
        Select Case lvwReadIn.Name
            Case "lvwEiSoCockpit"
                col_Mail = 6
                col_member = 5
                col_preis_ende = 2
                col_plattform = 17
                col_beschreibung = 1
                col_yabe_id = 19
                col_bild_name = 24
                col_menge = 23
            Case "lvwBestellungen_bestelliste_neu"
                col_Mail = 9
                col_member = 2
                col_preis_ende = 5
                col_plattform = 13
                col_beschreibung = 4
                col_yabe_id = 15
                col_bild_name = 22
                col_menge = 23
            Case "lvwBestellverwaltung_nach_artikel"
                col_Mail = 9
                col_member = 2
                col_preis_ende = 5
                col_plattform = 13
                col_beschreibung = 4
                col_yabe_id = 15
                col_bild_name = 22
                col_menge = 23
            '# Kein Mapping vorhanden  -> Abbruch 
            Case "lvwBestellverlauf"
                col_Mail = 10
                col_member = 9
                col_preis_ende = 2
                col_plattform = 6
                col_beschreibung = 1
                col_yabe_id = 0 'teilweise falsch
                col_bild_name = 11
                col_menge = 12
            Case "lvwArtikelListe"
                col_Mail = 8
                col_member = 9
                col_preis_ende = 2
                col_plattform = 5
                col_beschreibung = 1
                col_yabe_id = 0 'teilweise falsch
                col_bild_name = 10
                col_menge = 11
            Case Else
                Return False
                Exit Function
        End Select

        '# Selektion der passenden Variablen
        Select Case strModul

            Case "GetArtikel"

                '# Artikel Datenblock

                '# Template 
                '<table width="200" border="0">
                '  <tr>
                '    <td>&nbsp;</td>
                '    <td>&nbsp;</td>
                '  </tr>
                '  <tr>
                '    <td>&nbsp;</td>
                '    <td>&nbsp;</td>
                '  </tr>
                '</table>

                If My.Settings.eiso_basis_sprache = False Then
                    Select Case strFieldMapping
                        Case "_eng"
                            strTitle = clsDatenbank_modul.getTitlebyID(lvwReadIn.SelectedItems(iWoPos).SubItems(col_yabe_id).Text, strFieldMapping)

                            If strTitle = "" Then
                                strTitle = lvwReadIn.SelectedItems(iWoPos).SubItems(col_beschreibung).Text
                            End If
                        Case "_fr"
                            strTitle = clsDatenbank_modul.getTitlebyID(lvwReadIn.SelectedItems(iWoPos).SubItems(col_yabe_id).Text, strFieldMapping)

                            If strTitle = "" Then
                                strTitle = clsDatenbank_modul.getTitlebyID(lvwReadIn.SelectedItems(iWoPos).SubItems(col_yabe_id).Text, strFieldMapping)
                                If strTitle = "" Then
                                    strTitle = lvwReadIn.SelectedItems(iWoPos).SubItems(col_beschreibung).Text
                                End If
                            End If

                        Case Else
                            strTitle = lvwReadIn.SelectedItems(iWoPos).SubItems(col_beschreibung).Text
                    End Select

                Else
                    strTitle = lvwReadIn.SelectedItems(iWoPos).SubItems(col_beschreibung).Text
                End If

                Dim bHasImage As Boolean = False
                If File.Exists(Application.StartupPath & "\bilderexport\" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_bild_name).Text) = True Then
                    bHasImage = True
                End If

                'ToString("C", CultureInfo.CurrentCulture)
                Dim dblEinzelPreis As Double = Convert.ToDouble(lvwReadIn.SelectedItems(iWoPos).SubItems(col_preis_ende).Text)
                Dim dblSammelPreis As Double = Convert.ToDouble(Convert.ToDouble(lvwReadIn.SelectedItems(iWoPos).SubItems(col_preis_ende).Text) * Convert.ToInt32(lvwReadIn.SelectedItems(iWoPos).SubItems(col_menge).Text))
                Select Case strPlattform
                    Case bPlattform.eBay
                        strData = "<tr><td>" & lvwReadIn.SelectedItems(iWoPos).SubItems(0).Text & "</td>"
                        If bHasImage = True Then
                            strData &= "<td><img width=""100px"" height=""100""  src=""data:image/jpeg;base64," & Convert.ToBase64String(
                        My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\bilderexport\" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_bild_name).Text)) & """/></td>"
                        Else
                            strData &= "<td>KEIN BILD</td>"
                        End If

                        strData &= "<td>" & strTitle & "</td><td>"
                        strData &= dblEinzelPreis.ToString("C", CultureInfo.CurrentCulture)
                        strData &= "</td>"
                        strData &= "<td align=""center"">" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_menge).Text & "</td>"
                        strData &= "<td>" & dblSammelPreis.ToString("C", CultureInfo.CurrentCulture) & "</td>"
                        strData &= "<td><a href=http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item="
                        strData &= lvwReadIn.SelectedItems(iWoPos).SubItems(0).Text & "&ssPageName=STRK:MESE:IT&ih=003>"
                        strData &= "eBay Ansicht</a></td></tr>"

                    Case bPlattform.delcampe
                        strData = "<tr><td>" & lvwReadIn.SelectedItems(iWoPos).SubItems(0).Text & "</td>"
                        If bHasImage = True Then
                            strData &= "<td><img width=""100px"" height=""100""  src=""data:image/jpeg;base64," & Convert.ToBase64String(
                        My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\bilderexport\" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_bild_name).Text)) & """/></td>"
                        Else
                            strData &= "<td>KEIN BILD</td>"
                        End If
                        strData &= "<td>" & strTitle & "</td><td>"
                        strData &= dblEinzelPreis.ToString("C", CultureInfo.CurrentCulture)
                        strData &= "</td>"
                        strData &= "<td align=""center"">" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_menge).Text & "</td>"
                        strData &= "<td>" & dblSammelPreis.ToString("C", CultureInfo.CurrentCulture) & "</td>"
                        strData &= "<td><a href=""http://www.delcampe.de/item.php?language=G&id="
                        strData &= lvwReadIn.SelectedItems(iWoPos).SubItems(0).Text & """>"
                        strData &= "Delcampe Ansicht</a></td></tr>"
                    Case bPlattform.shopsystem
                        strData = "<tr><td>" & lvwReadIn.SelectedItems(iWoPos).SubItems(0).Text & "</td>"
                        If bHasImage = True Then
                            strData &= "<td><img width=""100px"" height=""100""   src=""data:image/jpeg;base64," & Convert.ToBase64String(
                        My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\bilderexport\" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_bild_name).Text)) & """/></td>"
                        Else
                            strData &= "<td>KEIN BILD</td>"
                        End If
                        strData &= "<td>" & strTitle & "</td><td>"
                        strData &= dblEinzelPreis.ToString("C", CultureInfo.CurrentCulture)
                        strData &= "</td>"
                        strData &= "<td align=""center"">" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_menge).Text & "</td>"
                        strData &= "<td>" & dblSammelPreis.ToString("C", CultureInfo.CurrentCulture) & "</td>"
                        strData &= "<td><a href=""" & My.Settings.shop_url & "/suchen_Webseite.php?q=" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_yabe_id).Text & "&id=on&sprache=" & strFieldMapping
                        strData &= """>"
                        strData &= "Shop Ansicht</a></td></tr>"
                    Case bPlattform.shopste
                        strData = "<tr><td>" & lvwReadIn.SelectedItems(iWoPos).SubItems(0).Text & "</td>"
                        If bHasImage = True Then
                            strData &= "<td><img  width=""100px"" height=""100""  src=""data:image/jpeg;base64," & Convert.ToBase64String(
                        My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\bilderexport\" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_bild_name).Text)) & """/></td>"
                        Else
                            strData &= "<td>KEIN BILD</td>"
                        End If
                        strData &= "<td>" & strTitle & "</td><td>"
                        strData &= dblEinzelPreis.ToString("C", CultureInfo.CurrentCulture)
                        strData &= "</td>"
                        strData &= "<td align=""center"">" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_menge).Text & "</td>"
                        strData &= "<td>" & dblSammelPreis.ToString("C", CultureInfo.CurrentCulture) & "</td>"
                        strData &= "<td><a href=""http://shopste.com?q=" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_yabe_id).Text & "&id=on&sprache=" & strFieldMapping
                        strData &= """>"
                        strData &= "Shopste Ansicht</a></td></tr>"
                    Case bPlattform.magento
                        strData = "<tr><td>" & lvwReadIn.SelectedItems(iWoPos).SubItems(0).Text & "</td>"
                        If bHasImage = True Then
                            strData &= "<td><img  width=""100px"" height=""100""  src=""data:image/jpeg;base64," & Convert.ToBase64String(
                        My.Computer.FileSystem.ReadAllBytes(Application.StartupPath & "\bilderexport\" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_bild_name).Text)) & """/></td>"
                        Else
                            strData &= "<td>KEIN BILD</td>"
                        End If
                        strData &= "<td>" & strTitle & "</td><td>"
                        strData &= dblEinzelPreis.ToString("C", CultureInfo.CurrentCulture)
                        strData &= " </td>"
                        strData &= "<td align=""center"">" & lvwReadIn.SelectedItems(iWoPos).SubItems(col_menge).Text & "</td>"
                        strData &= "<td>" & dblSammelPreis.ToString("C", CultureInfo.CurrentCulture) & "</td>"
                        strData &= "<td>&nbsp;"
                        strData &= "</td></tr>"
                End Select



        End Select


        Return strData
    End Function

    '#########################################################
    '# >> Sucht und ersetzt innerhalb der Template Vorlage
    '#########################################################
    Public Function setReplaceData(ByVal strContent As String, ByVal iWoPos As Integer) As String
        Dim strData As String
        Try

            strData = lvwReadIn.Items(iWoPos).SubItems("live_email").Text


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEMailTemplate")
        End Try

        Return strContent
    End Function

    '######################################################################
    '# >> Rechnung per Email schicken 
    '######################################################################
    Public Function setRechnung(ByVal strContent As String, ByVal strBetreff As String, ByVal strFilename As String, Optional ByVal bDebug As Boolean = True) As Boolean
        Try


            '# ->> Fehlerprüfung
            If strContent.Length = 0 Then
                MessageBox.Show("Die Rechnungsvorlage enthält keinen Text" & vbCrLf & vbCrLf & "Bitte überprüfen Sie in den EiSo Werkzeuge -> EiSo Einstellungen -> jeweilige Plattform die Emailvorlagen", "Rechnung")

                Return False
                Exit Function
            End If
            If strBetreff.Length = 0 Then
                MessageBox.Show("Die Rechnungsvorlage enthält keinen Betrefftext" & vbCrLf & vbCrLf & "Bitte überprüfen Sie in den EiSo Werkzeuge -> EiSo Einstellungen -> jeweilige Plattform die Betreffvorlage", "Rechnung")

                Return False
                Exit Function
            End If
            If strEmail_empfänger_email.Length = 0 Then
                MessageBox.Show("Es wurde keine Emailadresse vom Verkäufer gefunden! Versuchen Sie unter Kunden -> rechte Maustaste dem Kunden eine gültige Emailadresse zu geben.")
                Return False
                Exit Function
            End If
            If My.Settings.user_email.Length = 0 Then
                MessageBox.Show("Es wurde keine Verkäuferemailadresse gefunden, bitte in den Eiso Werkzeuge -> Eiso Einstellungen -> Email Adresse eintragen.")
                My.Settings.gui_options_last_tab = optionGUI_Tab_ID.allgemein

                Return False
            End If




            Dim MailNachricht As New System.Net.Mail.MailMessage()

            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_versand_username, settings_crypt(False, My.Settings.email_pwd))
            SmtpObj.Port = My.Settings.email_smtp_port
            SmtpObj.Host = My.Settings.email_smtp
            SmtpObj.EnableSsl = My.Settings.email_ssl

            If IsNumeric(My.Settings.email_auktionsende_timeout) = True Then
                SmtpObj.Timeout = My.Settings.email_auktionsende_timeout
            Else
                SmtpObj.Timeout = 5000
            End If

            With MailNachricht
                .From = New System.Net.Mail.MailAddress(My.Settings.email_username, My.Settings.email_absende_name)
                .BodyEncoding = System.Text.Encoding.UTF8

                If My.Settings.eiso_debug_email = True Then
                    .To.Add(New System.Net.Mail.MailAddress(My.Settings.email_username, My.Settings.email_absende_name)) '# >> Auktionsemail empfänger 
                Else
                    .To.Add(strEmail_empfänger_email) '# >> Auktionsemail empfänger 
                End If


                If My.Settings.eiso_email_cc = True Then
                    .CC.Add(New System.Net.Mail.MailAddress(My.Settings.email_username, My.Settings.email_absende_name))
                End If

                If bDebug = True Then
                    .Bcc.Add(New System.Net.Mail.MailAddress(My.Settings.developer_email, "Bludau Media DEV"))
                End If
                .Subject = strBetreff
                .IsBodyHtml = True
                .Body = strContent
                Dim attachment As New System.Net.Mail.Attachment(strFilename)
                .Attachments.Add(attachment)
            End With

            'MailNachricht.Attachments.Clear()


            SmtpObj.Send(MailNachricht)

            setBludauMediaLogbuch(">> RECHNUNG >>>> Email wurde verschickt an: " & strEmail_empfänger_email & " verschickt.", "RECHNUNG")


            Return True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "Rechnung emailen setRechnung")
            Return False
        End Try
    End Function

    Public Function setSendNewsletter(ByVal strContent As String, ByVal strBetreff As String, Optional ByVal bDebug As Boolean = True) As Boolean


        Try


            '# ->> Fehlerprüfung
            If strContent.Length = 0 Then
                MsgBox("Fehler kein inhalt")
                Return False
                Exit Function
            End If
            If strBetreff.Length = 0 Then
                MsgBox("Fehler kein Betrefftext")
                Return False
                Exit Function
            End If
            If strEmail_empfänger_email.Length = 0 Then
                MsgBox("Fehler kein Empfänger")
                Stop
                Return False
                Exit Function
            End If



            If bDebug = True Then
                strEmail_empfänger_email = My.Settings.email_username
            End If


            Dim MailNachricht As New System.Net.Mail.MailMessage()

            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_newsletter_username, settings_crypt(False, My.Settings.newsletter_versand_pwd))
            SmtpObj.Port = My.Settings.newsletter_smtp_port
            SmtpObj.Host = My.Settings.newsletter_smtp
            SmtpObj.EnableSsl = My.Settings.email_newsletter_ssl

            'SmtpObj.Host = My.Settings.email_smtp
            If IsNumeric(My.Settings.email_newsletter_timeout) = True Then
                SmtpObj.Timeout = My.Settings.email_newsletter_timeout
            Else
                SmtpObj.Timeout = 5000
            End If

            With MailNachricht
                .From = New System.Net.Mail.MailAddress(My.Settings.newsletter_versand_email, My.Settings.newsletter_versand_name)
                .BodyEncoding = System.Text.Encoding.UTF8

                .To.Add(strEmail_empfänger_email) '# >> Auktionsemail empfänger 

                .Subject = strBetreff
                .IsBodyHtml = True
                .Body = strContent
            End With

            'MailNachricht.Attachments.Clear()


            SmtpObj.Send(MailNachricht)

            Return True

        Catch ex As System.Net.Mail.SmtpException
            Call debug_message(ex, strQuery & vbCrLf & "setSendNewsletter")
            Return False
        End Try

    End Function

    '###############################################################
    '# >> Email -> Bestellstatus auslösen 
    '###############################################################
    Public Function setSendMail_bestellstatus(ByVal strStatus As String, ByVal lvwData As ListView, ByVal strPlattform As bPlattform) As Boolean
        Try
            Dim strContent As String = ""
            Dim strBetreff As String = ""
            Dim strFieldMapping As String = ""
            Dim dblVersandaktuell As Double
            Dim dblVersandkosten As Double
            Dim strPaypal As Double = 0
            Dim dblPayPal As Double = 0
            Dim strPaypal_link As String = ""
            Dim iCount As Integer = 0
            Dim strGetArtikel As String = ""
            Dim strMember As String = ""
            Dim strContent_tmp As String = ""
            Dim strGetGespreis As Double = 0

            Dim col_Mail As Byte = 0
            Dim col_member As Byte = 0
            Dim col_preis_ende As Byte = 0
            Dim col_plattform As Byte = 0
            Dim col_beschreibung As Byte = 0

            Dim col_yabe_id As Byte = 0

            Dim strPlattf As String = ""
            Dim bSetDelete As Boolean = False
            Dim strPlattform_neu As String = ""
            Dim bItemDelete As Boolean = False
            Dim col_bild_name As Byte = 0

            '# Dynamische spalten 
            Select Case lvwData.Name
                Case "lvwBestellverwaltung_nach_artikel"
                    col_Mail = 9
                    col_member = 2
                    col_preis_ende = 5
                    col_plattform = 13
                    col_beschreibung = 4
                    col_yabe_id = 15
                    col_bild_name = 22
                '# Kein Mapping vorhanden  -> Abbruch 
                Case "lvwBestellverlauf"
                    col_Mail = 10
                    col_member = 9
                    col_preis_ende = 2
                    col_plattform = 6
                    col_beschreibung = 1
                    col_yabe_id = 0
                    col_bild_name = 11
                Case "lvwArtikelListe"
                    col_Mail = 8
                    col_member = 9
                    col_preis_ende = 2
                    col_plattform = 5
                    col_beschreibung = 1
                    col_yabe_id = 0
                    col_bild_name = 10
                Case "lvwBestellungen_bestelliste_neu"
                    col_Mail = 9
                    col_member = 2
                    col_preis_ende = 5
                    col_plattform = 13
                    col_beschreibung = 4
                    col_yabe_id = 15
                    col_bild_name = 22
                Case Else
                    Return False
                    Exit Function
            End Select

            lvwData.Enabled = False

            If Not lvwData.SelectedItems(iCount).SubItems(col_plattform).Text = "eBay" Then
                If My.Settings.eiso_gui_shop_ask_delete_status = True Then
                    If MsgBox("Möchten Sie den Artikel '" & lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "' bei '" & lvwData.SelectedItems(iCount).SubItems(col_plattform).Text & "' löschen ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        bSetDelete = True
                    Else
                        bSetDelete = False
                    End If
                Else
                    bSetDelete = False
                End If
            End If

            '##########################################################
            '# >> Alle selektierten berücksichtigen 
            '##########################################################
            Dim iNext As Integer = 1

            '  Dim mc As New clsMagentoAPI
            '  If My.Settings.yabe_magento_aktiv = True Then
            ' mc.getLogin()
            ' End If

            lvwReadIn = lvwData

            For iCount = 0 To lvwData.SelectedItems.Count - 1

                strFieldMapping = clsDatenbank_modul.getTranslate_l18n_mapping(clsDatenbank_modul.getCustomer_sprache(lvwData.SelectedItems(iCount).SubItems(col_Mail).Text))

                If lvwData.SelectedItems.Count - 1 = iCount Or lvwData.SelectedItems.Count = iCount Then
                    iNext = 0
                Else
                    iNext = 1
                End If

                ' Ist es noch der gleiche Käufer?
                If lvwData.SelectedItems(iCount).SubItems(col_Mail).Text.ToLower = lvwData.SelectedItems(iCount + iNext).SubItems(col_Mail).Text.ToLower Then


                    lvwData.EnsureVisible(iCount)
                    Application.DoEvents()

                    '# Artikeldaten holen 
                    Select Case lvwData.SelectedItems(iCount).SubItems(col_plattform).Text
                        Case "eBay"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.eBay, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= " <a href=http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item="
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(0).Text & "&ssPageName=STRK:MESE:IT&ih=003>"
                            'strGetArtikel &= "eBay Ansicht</a><br/>"
                            strPlattform_neu = "eBay"
                            bItemDelete = False
                        Case "delcampe"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.delcampe, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= " <a href=""http://www.delcampe.de/item.php?language=G&id="
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(0).Text & """>"
                            'strGetArtikel &= "Delcampe Ansicht</a><br/>"
                            strPlattform_neu = "delcampe"
                            bItemDelete = True
                        Case "CMS"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.shopsystem, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= "<br/>"
                            strPlattform_neu = "CMS"
                            bItemDelete = True
                        Case "Magento"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.magento, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= "<br/>"
                            strPlattform_neu = "Magento"
                            bItemDelete = True
                        Case "Shopste"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.shopste, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= "<br/>"
                            strPlattform_neu = "Shopste"
                            bItemDelete = True
                    End Select


                    ' Mitgliedsname holen 
                    strMember = lvwData.SelectedItems(iCount).SubItems(col_member).Text

                    '# LÖSCHEN IN DEN SHOPS ! 
                    If bSetDelete = True And bItemDelete = True Then

                        '# SHOP Artikel löschen 
                        If strPlattform_neu = "CMS" Then
                            col_yabe_id = 0
                        End If

                        Dim strYABEID() As String = lvwData.SelectedItems(iCount).SubItems(col_yabe_id).Text.Split("-")

                        Dim strBild As String = clsDatenbank_modul.getCMS_ShopItems("Bild", strYABEID(0))

                        If frmMain.frmManage.setDeletePictures(strBild, True) = True Then
                            If clsDatenbank_modul.getCMS_items_delete("DELETE FROM tblGes WHERE ID=" & strYABEID(0)) = True Then
                                frmMain.master_Message_label.Text = lvwData.SelectedItems(iCount).SubItems(14).Text & " / " & lvwData.SelectedItems(iCount).SubItems(col_yabe_id).Text
                                Application.DoEvents()
                            Else
                                MsgBox("Probleme beim Löschen des Artikels mit ID: '" & lvwData.SelectedItems(iCount).SubItems(col_yabe_id).Text & "'  auf dem Server", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Probleme beim Löschen des Bildes Artikels mit ID: '" & lvwData.SelectedItems(iCount).SubItems(col_yabe_id).Text & "' auf dem Server / Artikel nicht gelöscht", MsgBoxStyle.Exclamation)
                        End If

                        '# Wenn Magento Aktiv ist 
                        If My.Settings.yabe_magento_aktiv = True And Not strPlattform_neu = "eBay" Then

                            frmMain.master_Message_label.Text = "Lösche... " & iCount + 1 & " / " & lvwData.SelectedItems.Count - 1 & " " & lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text
                            Application.DoEvents()
                            'Call mc.setItem_delete(strYABEID(0))



                        End If
                    End If

                    '# Versandkosten bestimmen
                    If dblVersandkosten < dblVersandaktuell Then
                        dblVersandkosten = dblVersandaktuell
                    End If

                    '# Paypal Gesummtsumme finden 
                    If strPaypal < dblPayPal Then
                        strPaypal = dblPayPal
                    End If

                    ' Sicherung der alten Content variablen
                    strContent_tmp = strContent

                    ' Gesamtpreis 
                    strGetGespreis += Convert.ToDouble(lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text.Replace(".", ","))
                    lvwData.SelectedItems(iCount).BackColor = Color.Coral
                    ' iCount += 1

                    '################################################################
                    '#
                    '#################################################################
                Else

                    lvwData.EnsureVisible(iCount)
                    'lvwData.SelectedItems(iCount).Selected = True
                    Application.DoEvents()



                    '# Versandkosten bestimmen
                    If dblVersandkosten < dblVersandaktuell Then
                        dblVersandkosten = dblVersandaktuell
                    End If

                    '# Paypal Gesummtsumme finden 
                    If strPaypal < dblPayPal Then
                        strPaypal = dblPayPal
                    End If

                    ' Mitgliedsname holen 
                    strMember = lvwData.SelectedItems(iCount).SubItems(col_member).Text

                    '# Artikeldaten holen 
                    Select Case lvwData.SelectedItems(iCount).SubItems(col_plattform).Text
                        Case "eBay"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.eBay, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= " <a href=http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item="
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(0).Text & "&ssPageName=STRK:MESE:IT&ih=003>"
                            'strGetArtikel &= "eBay Ansicht</a><br/>"
                            strPlattform_neu = "eBay"
                            bItemDelete = False
                        Case "delcampe"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.delcampe, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= " <a href=""http://www.delcampe.de/item.php?language=G&id="
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(0).Text & """>"
                            'strGetArtikel &= "Delcampe Ansicht</a><br/>"
                            strPlattform_neu = "delcampe"
                            bItemDelete = True
                        Case "CMS"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.shopsystem, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= "<br/>"
                            strPlattform_neu = "CMS"
                            bItemDelete = True
                        Case "Magento"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.magento, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= "<br/>"
                            strPlattform_neu = "Magento"
                            bItemDelete = True
                        Case "Shopste"
                            strGetArtikel &= getTemplateVars(strGetArtikel, "GetArtikel", iCount, bPlattform.shopste, strFieldMapping)
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_beschreibung).Text & "</td><td>&nbsp;&nbsp;"
                            'strGetArtikel &= lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text
                            'strGetArtikel &= " Euro &nbsp;"
                            'strGetArtikel &= "<br/>"
                            strPlattform_neu = "Shopste"
                            bItemDelete = True
                    End Select

                    ' Sicherung der alten Content variablen
                    strContent_tmp = strContent

                    ' Gesamtpreis 
                    strGetGespreis += Convert.ToDouble(lvwData.SelectedItems(iCount).SubItems(col_preis_ende).Text.Replace(".", ","))

                    'strVersandkosten = 0 'zurücksetzen der Versandkosten

                    Exit For

                End If
            Next


            '###########################################
            '# >> Bestellstatus Template holen 
            '###########################################
            Dim strSprache = clsDatenbank_modul.getCustomer_sprache(lvwData.SelectedItems(0).SubItems(col_Mail).Text)
            If strSprache = "" Then
                Dim frmVersandstatus As New frmVersandstatus
                frmVersandstatus.lvwData = lvwData
                frmVersandstatus.strEmail = lvwData.SelectedItems(0).SubItems(col_Mail).Text
                frmVersandstatus.ShowDialog()
                strSprache = frmVersandstatus.cmbSprache_Versandstatus.Text
            End If

            '# Mapping holen
            strFieldMapping = clsDatenbank_modul.getTranslate_l18n_mapping(strSprache)

            Select Case strPlattform
                Case bPlattform.delcampe
                    strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_delcampe_text, "Text" & strFieldMapping)
                    strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_betreff_delcampe, "Text" & strFieldMapping)
                    strBetreff = strBetreff.Replace("###PLATTFORM###", "Delcampe")
                Case bPlattform.eBay
                    strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_ebay_text, "Text" & strFieldMapping)
                    strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_betreff_ebay, "Text" & strFieldMapping)
                    strBetreff = strBetreff.Replace("###PLATTFORM###", "eBay")
                Case bPlattform.shopsystem
                    strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_shop_text, "Text" & strFieldMapping)
                    strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_betreff_shop, "Text" & strFieldMapping)
                    strBetreff = strBetreff.Replace("###PLATTFORM###", "Shop")
                Case bPlattform.shopste
                    strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_shop_text, "Text" & strFieldMapping)
                    strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_bestellstatus_betreff_shop, "Text" & strFieldMapping)
                    strBetreff = strBetreff.Replace("###PLATTFORM###", "Shopste")
            End Select


            strEmail_empfänger_email = lvwData.SelectedItems(0).SubItems(col_Mail).Text


                '# Kundenprofil abrufen 
                Dim strKundenDetails() As String
            Dim strKundenDetails_msg As String = ""

            ReDim strKundenDetails(10)
            '# Kundendaten holen 
            'strKundenDetails = clsDatenbank_modul.getMemberAdress(strMember)
            strKundenDetails = clsDatenbank_modul.getEiSoIsCostumerAdressByEmailOrID(lvwData.SelectedItems(0).SubItems(col_Mail).Text)
            '# Template Nachricht 
            strKundenDetails_msg = strKundenDetails(0) & "<br>" & strKundenDetails(1) & "<br>" & strKundenDetails(2) & "<br>" & strKundenDetails(3)
            strContent = strContent.Replace("###KUNDE_NAME###", strKundenDetails(0))
            strContent = strContent.Replace("###KUNDE_STRASSE###", strKundenDetails(1))
            strContent = strContent.Replace("###KUNDE_ORT###", strKundenDetails(2))
            strContent = strContent.Replace("###KUNDE_LAND###", strKundenDetails(3))
            '################################
            '# >> Umwandlung durchführen
            '#################################
            ' strContent_tmp = strContent_tmp.Replace("<###gesPreis###>", strGetGespreis2)
            strContent = strContent.Replace("###ENDSUMME###", strGetGespreis)
            strContent = strContent.Replace("###ARTIKEL###", strGetArtikel)
            strContent = strContent.Replace("###KUNDEN###", strKundenDetails_msg)
            strContent = strContent.Replace("###NACHNAME###", strKundenDetails(0))
            strContent = strContent.Replace("###NAME###", strKundenDetails(0))
            strContent = strContent.Replace("###VERSANDKOSTEN###", dblVersandkosten)
            strContent = strContent.Replace("###MEMBER###", strMember)
            strContent = strContent.Replace("###STATUS###", getTranslatedOrderStatus(strStatus, strSprache))
            strContent = strContent.Replace("###VERKÄUFER_NAME###", My.Settings.user_vorname & " " & My.Settings.user_nachname)
            strContent = strContent.Replace("###VERKÄUFER_EBAYNAME###", My.Settings.ebay_username)
            strContent = strContent.Replace("###VERKÄUFER_EISOUSER###", My.Settings.yabe_username)
            strContent = strContent.Replace("###VERKÄUFER_EMAIL###", My.Settings.user_email)
            strContent = strContent.Replace("###VERKÄUFER_ORT###", My.Settings.user_ort)
            strContent = strContent.Replace("###VERKÄUFER_PLZ###", My.Settings.user_plz)
            strContent = strContent.Replace("###VERKÄUFER_STRASSE###", My.Settings.user_strasse)
            strContent = strContent.Replace("###VERKÄUFER_SHOPNAME###", My.Settings.eiso_shopname)
            strContent = strContent.Replace("###SHOP_URL###", My.Settings.shop_url)
            strContent = strContent.Replace("###VERKÄUFER_FIRMA###", My.Settings.user_firmenname)
            'Select Case frmVersandstatus.cmbSprache_Versandstatus.Text
            '    Case "Deutsch"
            '        strBetreff = "Neuer Bestellstatus - ###STATUS### für ###NAME###"
            '    Case "Englisch"
            '        strBetreff = "New order status - ###STATUS### for ###NAME###"
            'End Select

            ' Suchen und ersetzten 
            strBetreff = strBetreff.Replace("###STATUS###", getTranslatedOrderStatus(strStatus, strSprache))
            strBetreff = strBetreff.Replace("###NAME###", strKundenDetails(0))

            If IsNumeric(strMember) = True Then
                strMember = strKundenDetails(0) & " (" & strMember & ")"
            End If

            strBetreff = strBetreff.Replace("###KUNDEN_MEMBER###", strMember)
            strBetreff = strBetreff.Replace("###VERKÄUFER_SHOPNAME###", My.Settings.eiso_shopname)
            strBetreff = strBetreff.Replace("###VERKÄUFER_FIRMA###", My.Settings.user_firmenname)
            ' Email abschicken 

            setBludauMediaLogbuch(">> BESTELLUNG >>>> Email wurde verschickt an: " & lvwData.SelectedItems(0).SubItems(col_Mail).Text & " / " & strKundenDetails(0), "EMAIL_BESTELLSTATUS")


            Call setSendMail(strContent, strBetreff)
            frmMain.master_Message_label.Text = "Artikel wurden verschickt"
            lvwData.Enabled = True

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setSendMail_bestellstatus")
            lvwData.Enabled = True
            Return False
        End Try
    End Function

    '######################################################################
    '# >> 
    '######################################################################
    Public Function getTranslatedOrderStatus(ByVal strStatus As String, ByVal strSprache As String) As String
        Dim strData As String = ""
        Select Case strStatus
            Case "Bestellt"

                Select Case strSprache
                    Case "Deutsch"
                        strData = "Bestellt"
                    Case "Englisch"
                        strData = "Ordered"
                End Select
            Case "Bezahlt"
                Select Case strSprache
                    Case "Deutsch"
                        strData = "Bezahlt"
                    Case "Englisch"
                        strData = "Paid"
                End Select
            Case "Verschickt"
                Select Case strSprache
                    Case "Deutsch"
                        strData = "Verschickt"
                    Case "Englisch"
                        strData = "Shipped"
                End Select
            Case "Storniert"
                Select Case strSprache
                    Case "Deutsch"
                        strData = "Storniert"
                    Case "Englisch"
                        strData = "Canceled"
                End Select
            Case "Komplett"
                Select Case strSprache
                    Case "Deutsch"
                        strData = "Komplett"
                    Case "Englisch"
                        strData = "Complete"
                End Select
        End Select
        Return strData
    End Function

    '###############################################################
    '# >> Allgemeines eMail Senden 
    '###############################################################
    Public Function setSendMail(ByVal strContent As String, ByVal strBetreff As String) As Boolean
        Dim SmtpObj As New System.Net.Mail.SmtpClient(My.Settings.email_smtp, My.Settings.email_smtp_port)

        Try
            '# ->> Fehlerprüfung
            If strContent.Length = 0 Then
                MsgBox("Fehler kein inhalt", MsgBoxStyle.Exclamation)
                Return False
                Exit Function
            End If
            If strBetreff.Length = 0 Then
                MsgBox("Fehler kein Betrefftext", MsgBoxStyle.Exclamation)
                Return False
                Exit Function
            End If
            If strEmail_empfänger_email.Length = 0 Then
                MsgBox("Fehler kein Empfänger", MsgBoxStyle.Exclamation)
                ' Stop
                Return False
                Exit Function
            End If

            If My.Settings.email_username = "" Then
                MessageBox.Show("Email Einstellungen in den Werkzeuge -> Einstellungen -> Email", "Email Setting Fehler")
            End If

            '# Neues Email Objekt erzeugen 
            Dim MailNachricht As New System.Net.Mail.MailMessage()

            'SmtpObj.Host = My.Settings.email_smtp
            If IsNumeric(My.Settings.email_auktionsende_timeout) = True Then
                SmtpObj.Timeout = My.Settings.email_auktionsende_timeout
            Else
                SmtpObj.Timeout = 5000
            End If


            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_versand_username, settings_crypt(False, My.Settings.email_pwd))

            SmtpObj.EnableSsl = My.Settings.email_ssl
            'SmtpObj.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network

            '# Email SMTP Port festlegen aus Settings 
            If IsNumeric(My.Settings.email_smtp_port) = True Then
                SmtpObj.Port = My.Settings.email_smtp_port
            Else
                SmtpObj.Port = 25
            End If

            '# Wenn kein eigener Absende Name definiert wurde 
            If My.Settings.email_absende_name.Length = 0 Then
                My.Settings.email_absende_name = My.Settings.email_username
            End If

            With MailNachricht

                If My.Settings.email_absende_name.ToString = "" Then
                    .From = New System.Net.Mail.MailAddress(My.Settings.email_username, "Bestellbestätigung")
                Else
                    .From = New System.Net.Mail.MailAddress(My.Settings.email_username, My.Settings.email_absende_name)

                End If

                .BodyEncoding = System.Text.Encoding.UTF8
                If My.Settings.eiso_debug_email = True Then
                    .To.Add(New System.Net.Mail.MailAddress(My.Settings.email_username, My.Settings.user_vorname & " " & My.Settings.user_nachname)) '# >> Auktionsemail empfänger 
                Else
                    .To.Add(strEmail_empfänger_email) '# >> Auktionsemail empfänger 
                End If

                If My.Settings.eiso_email_cc = True Then
                    .CC.Add(New System.Net.Mail.MailAddress(My.Settings.email_username, My.Settings.email_absende_name))
                End If

                If bDebug_mail = True Then
                    .Bcc.Add(New System.Net.Mail.MailAddress(My.Settings.developer_email, "Bludau Media DEV"))
                End If

                .DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnSuccess
                .IsBodyHtml = True

                .Subject = strBetreff
                .Body = strContent
            End With

            MailNachricht.Attachments.Clear()

            SmtpObj.Send(MailNachricht)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf, "Fehler beim Email Versand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Call getMailMessageError(ex.Message, "setSendMail" & ex.Message)
            'Call debug_message(ex,strQuery & vbcrlf & "setSendMail")
            Return False
        End Try

        Return True
    End Function

    '#############################################################
    '# >> eMail Fehlerreport senden 
    '#############################################################
    Public Function setSendDebugReport(ByVal strBetreff As String, ByVal strfile As String) As Boolean
        Dim SmtpObj As New System.Net.Mail.SmtpClient
        Static iCounter As Integer = 0
        Try

            iCounter += 1

            If iCounter Mod 4 = 0 Then
                If MsgBox("Endlosschleife ", MsgBoxStyle.Critical & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Application.Exit()
                End If
            End If

            Dim MailNachricht As New System.Net.Mail.MailMessage()
            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_versand_username, settings_crypt(False, My.Settings.email_pwd))
            SmtpObj.Port = 25
            SmtpObj.EnableSsl = My.Settings.email_ssl
            SmtpObj.Host = My.Settings.email_smtp

            With MailNachricht
                .From = New System.Net.Mail.MailAddress(My.Settings.email_username, "Bludau Media")
                .BodyEncoding = System.Text.Encoding.UTF8

                .To.Add(My.Settings.developer_email) '# >> Developer empfänger 

                If My.Settings.yabe_email_debug_cc = True Then
                    .CC.Add(My.Settings.email_username) '# Bekommt Fehlerreport 
                End If


                .Subject = strBetreff
                .IsBodyHtml = True
                .Body = getDebugEmail_Content(strfile)
            End With

            MailNachricht.Attachments.Clear()

            SmtpObj.Send(MailNachricht)

            Return True
        Catch ex As Exception
            MsgBox("ACHTUNG: Ihre Mailservereinstellungen wurden noch nicht vorgenommen.!" & ex.Message & vbCrLf & "Wahrscheinlich wurde der Email-Server noch nicht eingerichtet." & vbCrLf & "Bitte unter EiSo Werkzeuge -> EiSo Optionen aufrufen dort Email Versand", MsgBoxStyle.Information)
            My.Settings.gui_options_last_tab = optionGUI_Tab_ID.email_server
            'End
            Return False
        End Try
    End Function

    '##############################################
    '# >> Whitespace erzeugen 
    '##############################################
    Private Function setWhitespace2HTML(ByVal strWhitespace As String) As String

        strWhitespace = strWhitespace.Replace("", "&nbsp;")
        Return strWhitespace

    End Function
    '###############################################
    '# >> Inhalt der Report Datei erzeugen 
    '###############################################
    Private Function getDebugEmail_Content(ByVal strFile As String) As String
        Dim strContent As String
        Try

            If My.Settings.developer_crashcount > 1000 Then
                My.Settings.developer_crashcount = 1
                My.Settings.developer_crash_last = "Maximum erreicht"

            End If

            Dim strMonitor() As String
            strMonitor = My.Computer.Screen.ToString.Split("Primary=True")

            strContent = "<h1>EiSo - Selbstdiagnose </h1><br>Entschuldigung " & My.Settings.ebay_username & ",<br>Hopla! Es ist ein Fehler aufgetreten der dem EiSo System automatisch mitgeteilt wurde.<br>"
            strContent &= "<h2>Error Report von EiSo v." & strVersionString & "</h2>"
            strContent &= "<strong>EiSo Benutzer:</strong> " & My.Settings.yabe_username & "<br>"
            strContent &= "<strong>eBay ID:</strong> " & My.Settings.ebay_username & "<br>"
            strContent &= "<strong>Zeitpunkt:</strong> " & Date.Now & "<br>"
            strContent &= "<strong>Letzter Crash:</strong> " & My.Settings.developer_crash_last & "<br>"
            strContent &= "<strong>Crashcount:</strong> " & My.Settings.developer_crashcount & "<br>"
            strContent &= "<strong>Maschinenname:</strong> " & My.Computer.Name & "<br>"
            strContent &= "<strong>Betriebssystem:</strong> " & My.Computer.Info.OSFullName & " (" & My.Computer.Info.OSVersion & ") <br>"
            strContent &= "<strong>Arbeitsspeicher installiert:</strong> " & (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024) & "MB <br>"
            strContent &= "<strong>Arbeitsspeicher frei:</strong> " & (My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024) & "MB <br>"
            strContent &= "<strong>Bildschirm - Farbtiefe:</strong> " & strMonitor(0) & " <br>"
            strContent &= "<strong>Bildschirm - Auflösung:</strong> " & My.Computer.Screen.Bounds.X & " x " & My.Computer.Screen.Bounds.Y & " <br>"
            strContent &= "<strong>Logbucheintrag:</strong> " & strFile & "<br>"


            If My.Settings.yabe_debugmail_hardware = True Then
                strContent &= getWMI()
            End If


            My.Settings.developer_crash_last = Date.Now

            My.Settings.Save()
            strContent &= "<h2>Fehlerlog für " & My.Settings.yabe_username & "</h2><br>"

            strContent &= My.Computer.FileSystem.ReadAllText(strFile)
            strContent = strContent.Replace(vbNewLine, "<br>")
            strContent = strContent
            Return strContent
        Catch ex As Exception
            'Call debug_message(ex, strQuery & vbCrLf & "getContent")
            Return False
        End Try
    End Function
    '#######################################################################################
    '# >> Ruft eMail Versende Fehler auf 
    '#######################################################################################
    Public Function getMailMessageError(ByVal strMessage As String, ByVal strMethode As String) As Boolean
        Dim str() As String
        Try

            'MsgBox(strMessage)
            '######################
            '# >> GMX Modus 
            '######################
            str = strMessage.ToString.Split(",")
            str(1) = str(1).Replace("try again in ", "")
            str = str(1).Split(" ")

            MsgBox("Meldung vom Mailserver:" & strMessage, MsgBoxStyle.Critical)

            bIsWating = True
            iIsWatingTime = str(1)

            If iIsWatingTime > 0 Then
                frmMain.frmManage.frmLoad(iIsWatingTime * 1000 * 60, strMessage)
            End If

            'frmMain.frmManage.tmrEMailWaitTime.Interval = iIsWatingTime * 1000 * 60

            'frmMain.frmManage.tmrEMailWaitTime.Enabled = True
            'frmMain.frmManage.lblMessageNewsletter.Text = "Wartepause eingeleitet..."

            frmMain.master_Message_label.Text = "Email Fehler -> Wartepause wird eingeleitet"

        Catch ex As Exception
            Call debug_message(ex, strMessage & vbCrLf & "setSendMail")
            Return False
        End Try

        Return True
    End Function

End Class
