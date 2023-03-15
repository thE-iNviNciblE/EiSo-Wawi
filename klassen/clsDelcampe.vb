Public Enum selectModus
    ganz = 0
    part = 1
End Enum

Public Class clsDelcampe

    Public strISO_ary(,) As String

    Public Function getCSVExport_Repeat(ByVal oLV As ListView, ByVal sFile As String, ByVal bIncludeHidden As Boolean, ByVal sLine As String, ByVal strSprache() As String, ByVal strBeschreibung As String, ByVal oItem As ListViewItem, Optional ByVal mModus As selectModus = selectModus.ganz, Optional ByVal aryAuktion As ArrayList = Nothing) As String


        Dim strBild As String
        Dim strBild_TN As String
        'Dim Q As String = Chr(34)
        Dim Q As String
        'Dim QC As String = Chr(34) + ";"
        Dim QC As String = ";"
        Dim strBeschreibung_tmp As String = ""

        Dim strBeschreibung_data(10, 1) As String
        Try



            sLine = Q + aryAuktion.Item(12).ToString() + QC
            sLine += Q + "1" + QC
            sLine += Q + oItem.SubItems(5).Text + QC ' # KATEGORIE 

            '####################################
            '# >> Listviewdaten aufbereiten
            '##################################
            oItem.SubItems(1).Text = oItem.SubItems(1).Text.Replace(">", "-")
            oItem.SubItems(1).Text = oItem.SubItems(1).Text.Replace("&gt;", "-")
            oItem.SubItems(1).Text = oItem.SubItems(1).Text.Replace("<", "-")
            oItem.SubItems(1).Text = oItem.SubItems(1).Text.Replace("Propaganda - Karte :", "WW II ")
            oItem.SubItems(1).Text = oItem.SubItems(1).Text.Replace("Propaganda - ", "WW II ")
            oItem.SubItems(1).Text = Trim(oItem.SubItems(1).Text.Replace("NS ", ""))
            oItem.SubItems(1).Text = Trim(oItem.SubItems(1).Text.Replace("<br>", ""))
            oItem.SubItems(1).Text = Trim(oItem.SubItems(1).Text.Replace("&#39;", ""))
            oItem.SubItems(1).Text = Trim(oItem.SubItems(1).Text.Replace("&quot;", """"))
            oItem.SubItems(1).Text = Trim(oItem.SubItems(1).Text.Replace("'", ""))


            strBeschreibung_data = clsDatenbank_modul.getCMS_Beschreibung_all(strISO_ary, oItem.Text)

            '###############################################
            '# >> Title 
            '# - Für International einstellbar 
            '###############################################

            Dim iCount As Integer = 0
            Dim strTitel As String = ""

            If Not frmMain.frmManage.cmbSprache_Artikeldatenbank.Text = aryAuktion.Item(15).ToString Then

                For iCount = 0 To strISO_ary.GetUpperBound(0) - 1
                    If Not strISO_ary(iCount, 0) = Nothing Then
                        If strBeschreibung.IndexOf("###BESCHREIBUNG_" & strISO_ary(iCount, 0).ToUpper & "###") > -1 Then

                            If aryAuktion.Item(15).ToString = strISO_ary(iCount, 1) Then
                                '# Delcampe Titel Länge auf 120 Zeichen begrentzt
                                'strTitel = clsDatenbank_modul.getArtikeldatenbank_Beschreibung_Export(oItem.Text, iCount)
                                strTitel = strBeschreibung_data(iCount, 1)

                                '# Größer als 118 Zeichen... dann ist schneiden erlaubt 
                                If strTitel.Length > 117 Then
                                    sLine += Q & strTitel.Substring(0, 118) & QC ' Name
                                Else
                                    sLine += Q & strTitel & QC
                                End If

                                'Exit For ' Es wird nur der Titel gesucht 
                            End If

                        End If
                    End If
                Next
            Else

                If oItem.SubItems(1).Text.Length > 118 Then
                    sLine += Q & oItem.SubItems(1).Text.Substring(0, 118) & QC ' Name
                Else
                    sLine += Q & oItem.SubItems(1).Text & QC ' Name
                End If

            End If

            sLine += Q + oItem.SubItems(0).Text & "-" & aryAuktion.Item(15).ToString + QC ' Persönliche Referenz 

            '#######################################################
            '# Beschreibung Laden 
            '# > Variablen ersetzen
            '#######################################################

            iCount = 0
            strBeschreibung_tmp = strBeschreibung


            For iCount = 0 To strISO_ary.GetUpperBound(0) - 1
                If Not strISO_ary(iCount, 0) = Nothing Then
                    '# Template Variable gefunden
                    If strBeschreibung.IndexOf("###BESCHREIBUNG_" & strISO_ary(iCount, 0).ToUpper & "###") > -1 Then

                        '# Vorhandene Sprache im Listview (Input Data)
                        If frmMain.frmManage.cmbSprache_Artikeldatenbank.Text = strISO_ary(iCount, 1) Then
                            strBeschreibung_tmp = strBeschreibung_tmp.Replace("###BESCHREIBUNG_" & strISO_ary(iCount, 0).ToUpper & "###", oItem.SubItems(1).Text)
                        Else
                            ' strBeschreibung_tmp = strBeschreibung_tmp.Replace("###BESCHREIBUNG_" & strISO_ary(iCount, 0).ToUpper & "###", clsDatenbank_modul.getArtikeldatenbank_Beschreibung_Export(oItem.Text, iCount))
                            strBeschreibung_tmp = strBeschreibung_tmp.Replace("###BESCHREIBUNG_" & strISO_ary(iCount, 0).ToUpper & "###", strBeschreibung_data(iCount, 1))

                        End If

                    End If

                End If
            Next


            '# Bilder Lokal oder vom Server Laden
            Dim strBild_neu As String = ""

            If aryAuktion.Item(14).ToString = True Then
                'strBild_neu = oItem.SubItems(3).Text.Replace(My.Settings.shop_url_bilder, "http://www.briefmarken-karten-philatelie.de/eBay_black/")
                'strBild_neu = oItem.SubItems(3).Text.Replace("http://www.briefmarken-karten-philatelie.de/eBay/", "http://www.briefmarken-karten-philatelie.de/eBay_black/")
            Else

                If My.Settings.chkEiSoDelcampe_remote_bilder_nutzen = True Then
                    strBild_neu = oItem.SubItems(3).Text '.Replace(My.Settings.shop_url_bilder, My.Settings.yabe_delcampe_bilder & "\")
                    If My.Settings.chkEiSoDelcampe_remote_bilder_http_ersetzen = True Then
                        strBild_neu = strBild_neu.Replace("https://", "http://")
                    End If
                Else
                    strBild_neu = oItem.SubItems(3).Text.Replace(My.Settings.shop_url_bilder, My.Settings.yabe_delcampe_bilder & "\")
                End If

            End If

            'strBild_neu = oItem.SubItems(3).Text.Replace("/", "\")

            strBeschreibung_tmp = strBeschreibung_tmp.Replace("###BILD###", oItem.SubItems(3).Text)

            strBeschreibung_tmp = strBeschreibung_tmp.Replace(vbCrLf, "")
            strBeschreibung_tmp = strBeschreibung_tmp.Replace(";", "-")

            sLine += Q + strBeschreibung_tmp + QC ' Beschreibung

            strBild = strBild_neu ' Bild 
            strBild_TN = oItem.SubItems(3).Text.Replace("/", "\")

            sLine += Q + strBild + QC ' Hauptbild
            sLine += Q + "" + QC ' img2 
            sLine += Q + "" + QC ' img3 

            sLine += Q + "EUR" + QC ' Währung 
            sLine += Q + oItem.SubItems(2).Text + QC ' Preis

            sLine += Q + aryAuktion.Item(19).ToString + QC ' Increment  
            sLine += Q + aryAuktion.Item(18).ToString + QC ' Netto preis 
            sLine += Q + "0" + QC '  
            sLine += Q + aryAuktion.Item(9).ToString() + QC ' dauert 
            sLine += Q + aryAuktion.Item(17).ToString() + QC ' renew
            sLine += Q + aryAuktion.Item(11).ToString() + QC ' endtime 
            sLine += Q + aryAuktion.Item(10).ToString() + QC ' prefered_end_day
            sLine += Q + "" + QC ' user_note
            sLine += Q + "0000-00-00" + QC ' date_sent

            '# Delcampe Lister 3 
            If aryAuktion.Item(16).ToString() = "True" Then
                sLine += Q + "Y" + QC ' to_send (Delcampe Lister 2 = N / Delcampe Lister 3 = Y)
            Else
                sLine += Q + "N" + QC ' to_send (Delcampe Lister 2 = N / Delcampe Lister 3 = Y)
            End If


            '# >> aryAuktion wird gefüllt
            '# - chkDelcampe_last_minute = 0 
            '# - chkDelcampe_listing_top = 1
            '# - chkDelcampe_privat      = 2
            '# - chkDelcampe_startseite  = 3
            '# - chkDelcampe_TitelFett   = 4
            '# - chkDelcampe_umrandet    = 5
            '# - chkDelcampe_untertitel  = 6 
            '# - ckkDelcampe_category_top = 7
            '#  - chkDelcampe_startseite  = 8 

            sLine += Q + aryAuktion.Item(0).ToString() + QC ' option_lastminutebidding
            sLine += Q + aryAuktion.Item(2).ToString() + QC ' option_private_auction
            sLine += Q + aryAuktion.Item(6).ToString() + QC ' option_subtitle
            sLine += Q + "" + QC ' subtitle
            sLine += Q + aryAuktion.Item(4).ToString() + QC ' option_boldtitle
            sLine += Q + "N" + QC ' option_highlight
            sLine += Q + aryAuktion.Item(5).ToString() + QC ' option_coloredborder
            sLine += Q + aryAuktion.Item(1).ToString() + QC ' option_toplisting
            sLine += Q + aryAuktion.Item(7).ToString() + QC ' option_topcategory
            sLine += Q + aryAuktion.Item(8).ToString() + QC ' option_topmain
            sLine += Q + "Y" + QC ' option_keepoptionsonrenewal

            'sLine += Q + "N" + QC ' option_lastminutebidding
            'sLine += Q + "Y" + QC ' option_private_auction
            'sLine += Q + "N" + QC ' option_subtitle
            'sLine += Q + "" + QC ' subtitle
            'sLine += Q + "N" + QC ' option_boldtitle
            'sLine += Q + "N" + QC ' option_highlight
            'sLine += Q + "N" + QC ' option_coloredborder
            'sLine += Q + "N" + QC ' option_toplisting
            'sLine += Q + "N" + QC ' option_topcategory
            'sLine += Q + "N" + QC ' option_topmain
            'sLine += Q + "Y" + QC ' option_keepoptionsonrenewal

            Return sLine

        Catch ex As Exception
            Call debug_message(ex, "getCSVExport_Repeat")
            Return "-1"
        End Try
    End Function
End Class
