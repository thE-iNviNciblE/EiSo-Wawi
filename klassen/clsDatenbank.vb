'###########################################################
'# >> Alle Datenbank operationen
'###########################################################
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Public Class clsDatenbank

    '###############################
    '# >> Datenbank 
    '###############################

    Public dbConnect As New MySql.Data.MySqlClient.MySqlConnection  ' Globale Datenbankverbindung
    Public dbReader As MySql.Data.MySqlClient.MySqlDataReader ' MySql.Data.MySqlClient.MySqlDataReader ' Datenreader
    Public dblSumme As Double = 0
    Public strOutPut As String = ""
    Public bkundendetail As Boolean = False
    Public bStopReadIn As Boolean = False
    Public pgr_global_aktiv As ProgressBar
    Public lvwMasterMenue As ListView
    Public strMenueIDs As String
    Public dblGesamtsumme As Double = 0

    Public Enum status_date
        bezahlt = 0
        verschickt = 1
        bewertet = 2
        abgeschlossen = 3
        storniert = 4
    End Enum

    '# Spracheinstellungen für die eMail 
    Public Enum email_sprache
        de = 0
        eng = 1
        fr = 2
        sp = 3
        cn = 4
        ru = 5
        all = 6
    End Enum

    '# YABE -> Bestellstatus verwalten 
    Public Enum yabe_bestellstatus
        bestellt = 1
        bezahlt = 2
        verschickt = 3
        komplett = 4
        storniert = 5
        uebernommen = 6
    End Enum
    '# Datenbankzugriff steuern 
    Public Enum datenbankzugriff
        CMS = 0
        YABE = 1
    End Enum

    Public Enum chkBilderData
        download = 0
        check = 1
    End Enum

    '# Modus INSERT, UPDATE 
    Public Enum modus
        insert = 0
        update = 1
    End Enum

    '# Zuordnung der möglichen Tabellen 
    Public Enum datentabelle
        yabe_personals_profile = 0
        yabe_personals_adress = 1
        yabe_auction_list_history = 2
        yabe_auction_list_live = 4
    End Enum


    '##############################################
    '# >> Mapping für eBay Liveliste
    '##############################################
    Public Structure getlvwEbayLive
        Dim ID As Integer
        Dim email As Integer
        Dim mitgliedsname As Integer
        Dim gebote As Integer
        Dim preisStart As Integer
        Dim preisJetzt As Integer
        Dim beschreibung As Integer
        Dim zeitpunkt As Integer
        Dim eBayAuktionType As Integer
        Dim eBayWatchCount As Integer
        Dim ebayAnfang As Integer
        Dim eBayEnde As Integer
        Dim eBayGebühr As Integer
        Dim ebayVersandkosten As Integer
    End Structure

    Public getEbayList As New getlvwEbayLive

    Public Function getCustomer_delcampe_id(ByVal strEmail As String) As String
        Try
            Dim strDelcampeID As String
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "SELECT delcampe_userid FROM yabe_personals_profile WHERE email='" & strEmail & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then
                dbReader.Read()
                strDelcampeID = dbReader("delcampe_userid")
                dbConnect.Close()
                Return strDelcampeID
            Else
                Return -1
            End If
        Catch ex As Exception
            Call debug_message(ex, "getCustomer_delcampe_id")
        End Try
    End Function
    Public Function getTitlebyID(id As String, strFieldMapping As String) As String

        Try
            dbConnect.Close()
            dbConnect.Open()
            Dim str() As String

            str = id.Split("-")
            strQuery = "SELECT * FROM tblGes WHERE ID=" & str(0)
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then
                dbReader.Read()
                Return dbReader("Beschreibung" & strFieldMapping)
            End If

        Catch ex As Exception
            Call debug_message(ex, "getTitlebyID")
            Return "-1"
        End Try
    End Function

    Public Function chkeBayID(ByVal eBaycatID As String) As Integer
        Dim iMenueID As Integer
        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "SELECT * FROM tbl_menue2ebay WHERE ebay_id=" & eBaycatID
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then
                dbReader.Read()
                iMenueID = dbReader("menue_id")
                dbConnect.Close()
                Return iMenueID
            Else
                Return -1
            End If
        Catch ex As Exception
            Call debug_message(ex, "chkeBayID")
        End Try
    End Function

    Public Function seteBayID2Menue(ByVal eBaycatID As String, ByVal menueId As Integer, ByVal streBayName As String) As Boolean
        Try
            strQuery = "INSERT INTO `tbl_menue2ebay` (`menue_id`, `ebay_id`, `ebay_name`) VALUES (" & menueId & ", " & eBaycatID & ", '" & streBayName & "');"

            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Call debug_message(ex, "seteBayID2Menue")
            Return False
        End Try
    End Function

    '######################################################################
    '# >> Direktes Kopieren von Datensätzen ohne Select 
    '######################################################################
    Public Function setSYNC_History_live(ByVal ID As String) As Boolean
        Dim strQuery As String = ""
        Try

            strQuery = "INSERT INTO yabe_auction_list_live (eBay_ID, eBay_account,email,startprice,bids,current_price,auction_end,auction_begin,ListType,iseBayEnded,auction_title,shippment,payment_method,watchcount,eBayBild,personal_id,hitcounter,questions,YABE_ID,auction_type,eiso_orderlist_id,bild_url,bildname,menge) SELECT eBay_ID, eBay_account,email,startprice,bids,current_price,auction_end,auction_begin,ListType,iseBayEnded,auction_title,shippment,payment_method,watchcount,eBayBild,personal_id,hitcounter,questions,YABE_ID,auction_type,eiso_orderlist_id,bild_url,bildname,menge FROM yabe_auction_list_history WHERE eBay_ID='" & ID & "';"

            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            '# Löschen nach Kopieren 
            strQuery = "DELETE FROM `yabe_auction_list_history` WHERE eBay_ID='" & ID & "';"
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command2.ExecuteNonQuery()

            dbConnect.Close()



            Return True
        Catch ex As Exception
            Call debug_message(ex, "setSYNC_History_live")
            Return False
        End Try
    End Function

    '######################################################################
    '# >> Aktuallisieren des Artikels anhand der TransaktionsDaten
    '######################################################################
    Public Function seteBayTransaktionData(ByVal oTransaktions As eBay.Service.Core.Soap.TransactionType) As Boolean
        Dim strQuery As String = ""
        Dim strOrderID As String = ""
        Dim strStatus As String = ""
        Try

            If getIseBayIDStored(oTransaktions.Item.ItemID) = True Then

                Try
                    strOrderID = oTransaktions.ContainingOrder.OrderID
                Catch ex As Exception

                End Try

                If oTransaktions.Status.CompleteStatus.ToString() = "Complete" Then
                    strStatus = ",status='Komplett'"
                Else
                    strStatus = ""
                End If


                strQuery = "UPDATE yabe_auction_list_history SET finalfee='" & oTransaktions.FinalValueFee.Value.ToString.Replace(",", ".") & "',orderID='" & strOrderID & "'" & strStatus & "  WHERE eBay_ID='" & oTransaktions.Item.ItemID & "'"
            Else
                strQuery = "UPDATE yabe_auction_list_live SET orderID='" & strOrderID & "' WHERE eBay_ID='" & oTransaktions.Item.ItemID & "'"
            End If

            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()
            Return True
        Catch ex As Exception
            Call debug_message(ex, "setEbayHistoryUpdate" & vbCrLf & strQuery)
            Return False
        End Try
    End Function

    '###############################################################################
    '# >> Abrufen einzigartiger Käufer 
    '###############################################################################
    Public Function getUniqueBuyer_lvw(ByRef lvwKäuferliste As ListView, ByVal streBayAccount As String, ByVal bHistory As String, Optional imgList As ImageList = Nothing) As Boolean

        Dim strQuery As String
        Dim strTabele As String = ""

        If bHistory = "live" Then
            strTabele = "yabe_auction_list_live"
        Else
            strTabele = "yabe_auction_list_history"
        End If

        strQuery = "SELECT *, count(*) as anzahl, sum(current_price) as endpreis FROM " & strTabele & " WHERE not email = '' AND iseBayEnded='Completed' AND isDeleted='false' AND isSend='false' GROUP BY email ORDER BY auction_end DESC"
        Dim iSelected As Integer = -1
        Try

            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                Dim i As Integer = 0

                While Not dbReader.Read() = False

                    If streBayAccount = dbReader("eBay_account").ToString Then
                        iSelected = i
                    End If

                    i += 1

                    Dim lvwItem As New ListViewItem


                    lvwItem.Text = dbReader("eBay_account").ToString
                    lvwItem.SubItems.Add(dbReader("anzahl").ToString)
                    lvwItem.SubItems.Add(dbReader("endpreis").ToString)
                    lvwItem.SubItems.Add(dbReader("email").ToString)

                    'lvwItem.SubItems.Add(strBildName)


                    lvwKäuferliste.Items.Add(lvwItem)

                End While
            End If

            If Not iSelected = -1 Then
                lvwKäuferliste.Items(iSelected).Selected = True
                lvwKäuferliste.Items(iSelected).EnsureVisible()
            End If

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "getUniquebuyer " & strQuery)
            Return False
        End Try
    End Function

    '##################################################################################
    '# >> GLOBAL Emailadresse ändern [Bestellungen;Profile;Adress;Bewertung] 
    '##################################################################################
    Public Function setYABE_Kunden_email_updater(ByVal strEmail_neu As String, ByVal strEmail_old As String) As Boolean
        Try

            '# Adressen
            strQuery = "UPDATE yabe_personals_adress SET email='" & strEmail_neu & "' WHERE email='" & strEmail_old & "'"
            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()

            '# Profile 
            strQuery = "UPDATE yabe_personals_profile SET eMail='" & strEmail_neu & "' WHERE eMail='" & strEmail_old & "'"
            dbConnect.Open()
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command2.ExecuteNonQuery()
            dbConnect.Close()

            '# Bestellungen 
            strQuery = "UPDATE yabe_auction_list_history SET email='" & strEmail_neu & "' WHERE email='" & strEmail_old & "'"
            dbConnect.Open()
            Dim command3 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command3.ExecuteNonQuery()
            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "getUniquebuyer")
        End Try
    End Function

    '############################################################
    '# >> YABE Kunden speichern 
    '# >> INPUT: Arraylist 
    '############################################################
    Public Function setYABE_Kunden_adress_update(ByVal aryList As ArrayList, ByVal strEmail As String, ByVal bInsert As Boolean) As Boolean
        Try

            If Not strEmail.Length > 0 Then
                Return False
            End If

            ' Insert
            If bInsert = True Then

                If chkYABE_Kunden_isUserStored(aryList.Item(3).ToString, datentabelle.yabe_personals_profile) = False Then
                    setYABE_Kunde_newProfile(modus.insert, aryList.Item(3).ToString, strEmail)
                End If


            Else ' Update 
                strQuery = "UPDATE yabe_personals_adress SET name='" & aryList.Item(0).ToString.Replace("'", "\'") & "',"
                strQuery &= "street='" & aryList.Item(1).ToString.Replace("'", "\'") & "',"
                strQuery &= "zipcode='" & aryList.Item(2).ToString.Replace("'", "\'") & "',"
                strQuery &= "city='" & aryList.Item(3).ToString.Replace("'", "\'") & "',"
                strQuery &= "country='" & aryList.Item(4).ToString.Replace("'", "\'") & "'"
                strQuery &= "WHERE email='" & strEmail & "'"

                dbConnect.Close()
                dbConnect.Open()
                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
                command.ExecuteNonQuery()


                dbConnect.Close()
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setYABEKunden " & strQuery)
            Return False
        End Try
    End Function

    '#################################################################################################################
    '# >> Magento Kategorie Zuweisung speichern 
    '#################################################################################################################
    Public Function setCMS_item_magento(ByVal iID As Integer, ByVal strMagento As String) As Boolean
        Dim strQuery As String = ""
        Try

            strQuery = "UPDATE tblGes SET export_magento='" & strMagento & "' WHERE ID=" & iID

            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()


            dbConnect.Close()

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function
    '#################################################################################################################
    '# >> Magento Kategorie Zuweisung speichern 
    '#################################################################################################################
    Public Function setCMS_menue_magento(ByVal iMenueId As Integer, ByVal strMagento As String) As Boolean
        Dim strQuery As String = ""
        Try

            strQuery = "UPDATE tbl_menue SET export_magento='" & strMagento & "' WHERE ID=" & iMenueId

            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()


            dbConnect.Close()

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    '#################################################################################################################
    '# >> Delcampe Artikelzuordnung
    '#################################################################################################################
    Public Function setCMS_item_delcampe(ByVal iItemID As Integer, ByVal iDelcampeID As Integer) As Boolean
        Dim strQuery As String = ""
        Try
            strQuery = "UPDATE tblGes SET delcampe_id=" & iDelcampeID & " WHERE ID=" & iItemID

            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()


            dbConnect.Close()

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    '#################################################################################################################
    '# >> Delcampe Kategorie Zuweisung speichern 
    '#################################################################################################################
    Public Function setCMS_menue_delcampe(ByVal iMenueId As Integer, ByVal iDelcampeNeu As Integer) As Boolean
        Dim strQuery As String = ""
        Try
            strQuery = "UPDATE tbl_menue SET delcampe_id=" & iDelcampeNeu & " WHERE ID=" & iMenueId

            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()


            dbConnect.Close()

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Public Function getOrderKommentar(strOrderID As String) As String
        Try
            Dim str As String = ""
            dbConnect.Close()
            dbConnect.Open()
            Dim strQuery As String = "SELECT * FROM yabe_order_list WHERE orderID='" & strOrderID & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                While Not dbReader.Read() = False
                    Try
                        str = dbReader("kommentar")
                    Catch ex As Exception

                    End Try

                End While

            End If

            Return str
        Catch ex As Exception
            Call debug_message(ex, "getOrderKommentar")
        End Try
    End Function

    Public Function setOrderKommentar(strOrderID As String, strKommentar As String) As Boolean
        Try

            strQuery = "UPDATE yabe_order_list SET kommentar='" & strKommentar & "' WHERE orderID='" & strOrderID & "'"


            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()
        Catch ex As Exception
            Call debug_message(ex, "setOrderKommentar")
            Return False
        End Try
    End Function

    '#################################################################################################################
    '# >> Versandkosten setzen 
    '#################################################################################################################
    Public Function setEiSoOrderTable(ByVal strOrderID As String, ByVal strVersandkosten As String, strOrderTotal As String, strPaypalSum As String, total_sum As String, strRabattProzent As String, strRabattEUR As String, strShippmentMethodID As String) As Boolean
        Try
            Dim strQuery As String = ""
            Dim strTabelle As String = ""


            strQuery = "UPDATE yabe_order_list SET shippment_amount='" & strVersandkosten.Replace(",", ".") & "',order_total='" & strOrderTotal.Replace(",", ".") & "',paypal_total_sum='" & strPaypalSum.Replace(",", ".") & "',total_sum_amount='" & total_sum.Replace(",", ".") & "',total_rabatt_prozent='" & strRabattProzent.Replace(",", ".") & "',total_rabatt='" & strRabattEUR.Replace(",", ".") & "',order_shippment_method_id='" & strShippmentMethodID & "' WHERE orderID='" & strOrderID & "'"


            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setEiSoOrderTable")
            Return False
        End Try
    End Function

    '#################################################################################################################
    '# >> Versandkosten setzen 
    '#################################################################################################################
    Public Function setUpdateVersandkosten(ByVal streBayID As String, ByVal strVersandkosten As String, ByVal bModus As String, Optional ByVal strPaypal As String = "") As Boolean
        Try
            Dim strQuery As String = ""
            Dim strTabelle As String = ""

            Select Case bModus
                Case "live"
                    strTabelle = "yabe_auction_list_live"
                Case "history"
                    strTabelle = "yabe_auction_list_history"
            End Select


            If strPaypal.Length > 0 Then
                strQuery = "UPDATE " & strTabelle & " SET shippment='" & strVersandkosten.Replace(",", ".") & "',paypal_sum='" & strPaypal.Replace(",", ".") & "' WHERE eBay_ID='" & streBayID & "'"
            Else
                strQuery = "UPDATE " & strTabelle & " SET shippment='" & strVersandkosten.Replace(",", ".") & "' WHERE eBay_ID='" & streBayID & "'"
            End If


            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setUpdateVersandkosten")
            Return False
        End Try
    End Function


    '#####################################################################
    '# >> Verkaufte Artikel 
    '#####################################################################
    Public Function getSoldItemsbyEmail(ByVal strEmail As String, ByRef lvwArtikelListe As ListView, ByRef aryListData As ArrayList, ByVal bModus As String, Optional imgList As ImageList = Nothing) As Boolean
        Dim strQuery As String = ""
        Dim iCount As Integer = 0
        Dim dblVersandHighest As Double = 0
        Dim dblVerand As Double = 0
        Dim dblGesSumme As Double = 0
        Dim dblPaypal As Double = 0
        Dim dblPaypal_highest As Double = 0
        Dim strTabelle As String = ""
        Dim strFilename() As String
        Select Case bModus
            Case "history"
                strTabelle = "yabe_auction_list_history"
            Case "live"
                strTabelle = "yabe_auction_list_live"

        End Select

        strQuery = "SELECT * FROM " & strTabelle & " WHERE email='" & strEmail & "' ORDER BY auction_end DESC"

        Try

            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                lvwArtikelListe.BeginUpdate()


                '# Datenbank wechseln 
                '# --------------------
                While Not dbReader.Read() = False

                    '# 1 Durchlauf Kundendaten holen 
                    If iCount = 0 Then
                        aryListData.Add(dbReader("eBay_account").ToString)
                        aryListData.Add(dbReader("email").ToString)
                        iCount = 1
                    End If

                    '# Höchste Versandkosten ermitteln 
                    dblVerand = Convert.ToDouble(dbReader("shippment").ToString.Replace(".", ","))
                    If dblVerand > dblVersandHighest Then
                        dblVersandHighest = dblVerand
                    End If

                    dblPaypal = Convert.ToDouble(dbReader("paypal_sum").ToString.Replace(".", ","))
                    If dblPaypal > dblPaypal_highest Then
                        dblPaypal_highest = dblPaypal
                    End If


                    '# Listview hinzufügen 
                    Dim lvwItem As New ListViewItem

                    Dim strBildName As String = ""
                    Dim strID() As String
                    Dim strBild As String
                    Dim strBild_ary() As String
                    Dim bIsEiSoID As Boolean = True

                    If dbReader("bildname").ToString.Length > 0 Then
                        strBildName = dbReader("bildname").ToString
                        strID = dbReader("YABE_ID").ToString.Split("-")
                    Else


                        If dbReader("bild_url").ToString.Length > 0 Then
                            strBild = dbReader("bild_url").ToString
                            '# Externer Bild zum Download angegeben?
                            strID = dbReader("eBay_ID").ToString.Split("-")
                            bIsEiSoID = False
                            If Not strBild Is Nothing Then
                                strFilename = strBild.Split("/")
                                strBildName = strFilename(strFilename.Length - 1)
                                strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))

                            Else
                                strBildName = Nothing
                            End If
                        Else
                            '# Externer Bild zum Download angegeben?
                            strID = dbReader("YABE_ID").ToString.Split("-")

                            strBild = getEiSoBildbyEisoID(strID(0))
                            If Not strBild Is Nothing Then
                                strFilename = strBild.Split("/")
                                strBildName = strFilename(strFilename.Length - 1)
                                strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))

                            Else
                                strBildName = Nothing
                            End If
                        End If
                    End If


                    'lvwItem.Text = dbReader("eBay_ID").ToString

                    If Not strBild Is Nothing Then
                        If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildName) = True Then
                            Try
                                imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                'MessageBox.Show(frmMain.frmManage.bilder_history.Images(0).Size.ToString)
                                lvwItem.ImageKey = strID(0)
                            Catch ex As Exception

                            End Try
                        Else
                            If strBild.Length > 0 Then
                                Try
                                    Application.DoEvents()
                                    If My.Settings.domain_id = 43 Then
                                        strBild_ary = strBild.Split("/")
                                        strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                        strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                        My.Computer.Network.DownloadFile(strBild.Replace("http://", "https://"), Application.StartupPath & "\bilderexport\" & strBildName)
                                    Else
                                        My.Computer.Network.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildName)
                                    End If

                                    ' Bildnamen speichern
                                    Call setBildName(dbReader("YABE_ID").ToString, strBildName, bIsEiSoID)

                                    Try
                                        imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                        lvwItem.ImageKey = strID(0)
                                    Catch ex As Exception

                                    End Try

                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                End Try

                            End If

                        End If
                    End If

                    lvwItem.Text = dbReader("eBay_ID").ToString
                    lvwItem.SubItems.Add(dbReader("auction_title").ToString)
                    lvwItem.SubItems.Add(dbReader("current_price").ToString)
                    lvwItem.SubItems.Add(dbReader("shippment").ToString.Replace(".", ","))
                    lvwItem.SubItems.Add(dbReader("eBayBild").ToString)
                    lvwItem.SubItems.Add(dbReader("auction_type").ToString & " - " & bModus.ToString)

                    Select Case bModus
                        Case "history"
                            lvwItem.SubItems.Add(dbReader("status").ToString)
                        Case "live"
                            lvwItem.SubItems.Add("")
                    End Select


                    lvwItem.SubItems.Add(dbReader("auction_end").ToString)
                    lvwItem.SubItems.Add(dbReader("email").ToString)
                    lvwItem.SubItems.Add(dbReader("eBay_account").ToString)
                    lvwItem.SubItems.Add(strBildName)
                    lvwItem.SubItems.Add(dbReader("menge").ToString)

                    Try
                        lvwItem.SubItems.Add(dbReader("eiso_orderlist_id").ToString)
                    Catch ex As Exception

                    End Try

                    lvwArtikelListe.Items.Add(lvwItem)

                    dblGesSumme += Convert.ToDouble(dbReader("current_price").ToString)

                End While
                lvwArtikelListe.EndUpdate()

                lvwArtikelListe.Items(0).Selected = True ' ersten Eintrag selektierern

                '# Höchste Versandkosten 
                aryListData.Add(dblVersandHighest)
                aryListData.Add(dblGesSumme)
                aryListData.Add(dblVersandHighest + dblGesSumme)
                aryListData.Add(dblPaypal_highest)

            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "getSoldItemsbyEmail")
            Return False
        End Try
    End Function

    Public Function setBildName(ID As Integer, strBildname As String, bIsEiSoID As Boolean) As String
        Try
            Dim strQuery As String = ""
            Dim dbcon2 As New MySql.Data.MySqlClient.MySqlConnection
            dbcon2.ConnectionString = dbConnect.ConnectionString

            dbcon2.Close()
            dbcon2.Open()
            If bIsEiSoID = True Then
                strQuery = "UPDATE yabe_auction_list_history SET bildname='" & strBildname & "' WHERE YABE_ID='" & ID & "'"
            Else
                strQuery = "UPDATE yabe_auction_list_history SET bildname='" & strBildname & "' WHERE eBay_ID='" & ID & "'"
            End If

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbcon2)
            command.ExecuteNonQuery()

            dbcon2.Close()
        Catch ex As Exception
            Call debug_message(ex, "setBildName")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> SQL-STRING Generator für Listboxen 
    '# 
    '###########################################################
    Public Function setInsert_Update_tLvw2SQL(ByVal lvwData As ListViewItem, ByVal lvwName As String, ByVal strModus As String) As String

        Dim strSQL As String = ""
        Dim streMailAdd As String = ""
        Dim str() As String
        Dim str2() As String
        Dim strDatum_update As String = ""
        Dim strDatum_auktionsende As String = ""
        Dim strDatum_auktionsanfang As String = ""
        Try


            '#########################
            '# Selektion der SQL Querys 
            '#########################
            Select Case lvwName

                Case "lvwOutlook_items-aktive_liste" ' lvwOutlook_items-ebay | lvwOutlook_items-delcampe

                    '  lvwData.SubItems(2).Text = "test@philafriend.de"
                    '# >> Hinzufügen oder aktualliserien
                    Select Case strModus

                        Case "ADD"

                            'strDatum_auktionsende = lvwData.SubItems(5).Text
                            str = lvwData.SubItems(5).Text.Split(" ")
                            str2 = str(0).ToString.Split(".")

                            If str(0).LastIndexOf(".") = -1 Then
                                strDatum_auktionsende = str(0) & " " & str(1)
                            Else
                                strDatum_auktionsende = str2(2) & "-" & str2(1) & "-" & str2(0) & " " & str(1)
                            End If

                            strDatum_auktionsanfang = strDatum_auktionsende

                            'strDatum_auktionsanfang = 
                            strSQL = "INSERT INTO yabe_auction_list_live(eBay_ID,eBay_account, email, auction_title,current_price, startprice,iseBayEnded,ListType,auction_end,auction_begin,watchcount,shippment,eBayBild,bids,auction_type,YABE_ID,hitcounter) "
                            strSQL &= "Values('"
                            strSQL &= lvwData.SubItems(11).Text & "'," ' eBay ID 
                            strSQL &= "'" & lvwData.SubItems(12).Text & "'," ' Account 
                            strSQL &= "'" & lvwData.SubItems(2).Text & "'," ' email 
                            strSQL &= "'" & lvwData.SubItems(10).Text.Replace("'", "") & "'," ' titel
                            strSQL &= lvwData.SubItems(13).Text & "," ' current price 
                            strSQL &= "0," ' startprice 
                            strSQL &= "'Completed'," 'iseBayEnded
                            strSQL &= "'FixedPrice'," ' ListType
                            strSQL &= "'" & strDatum_auktionsende & "'," ' auktionsende 
                            strSQL &= "'" & strDatum_auktionsanfang & "'," ' auktionsanfang 
                            strSQL &= "0," ' beobachter
                            strSQL &= "0," ' versand

                            strSQL &= "'---'," 'ebay bild 

                            strSQL &= "1," ' gebote 
                            strSQL &= "'delcampe'," ' Auktionstyp -> Delcampe
                            strSQL &= "'" & lvwData.SubItems(14).Text & "'," ' WEB ID 

                            strSQL &= "0)" ' besucher

                        Case "UPDATE"
                            '# Access Datum 
                            '# #10/14/2007 12:0:0#
                            strDatum_update = "#" & Date.Now.Month & "/" & Date.Now.Day & "/" & Date.Now.Year & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "#"
                            If Not lvwData.SubItems(6).Text = "ERR_zu_alt" Then
                                streMailAdd = "email='" & lvwData.SubItems(6).Text & "', "
                            Else
                                streMailAdd = ""
                            End If

                            strSQL = "UPDATE yabe_auction_list_live set auction_title = '" & lvwData.SubItems(1).Text.Replace("'", "''") & "',current_price = " & lvwData.SubItems(2).Text.Replace(",", ".") & ", startprice = " & lvwData.SubItems(3).Text.Replace(",", ".") & ",bids=" & lvwData.SubItems(4).Text.Replace(",", ".") & ",iseBayEnded='" & lvwData.SubItems(7).Text & "',ListType='" & lvwData.SubItems(8).Text & "',eBay_account='" & lvwData.SubItems(5).Text & "'," & streMailAdd & "auction_end='" & strDatum_auktionsende & "',watchcount=" & Convert.ToInt16(lvwData.SubItems(10).Text) & ",auction_begin='" & strDatum_auktionsanfang & ",YABE_ID='" & lvwData.SubItems(14).Text & "',auction_type='delcampe',questions=" & lvwData.SubItems(16).Text & ",eBayBild='" & lvwData.SubItems(14).Text & "',hitcounter=" & lvwData.SubItems(15).Text & " WHERE eBay_ID='" & lvwData.SubItems(0).Text & "'"

                    End Select

                Case "lvwImporter"

                    '# Beschreibung
                    '# Preis 
                    '# Bild 
                    strSQL = "INSERT INTO tblGes(Beschreibung,Preis,Bild,Bestellt) VALUES("
                    strSQL &= "'" & lvwData.Text & "',"
                    strSQL &= "'" & lvwData.SubItems(1).Text & "',"
                    strSQL &= "'" & lvwData.SubItems(2).Text.Replace("\", "\\") & "',"
                    strSQL &= "3"
                    strSQL &= ")"

                Case "lvwOutlook_items-kunden"

                    '  strModus = "ADD"
                    '  lvwData.SubItems(2).Text = "test@philafriend.de"
                    '# >> Hinzufügen oder aktualliserien
                    Select Case strModus

                        '########################
                        '# >> Auktionsartikel
                        '########################
                        Case "ADD"



                            strSQL = "INSERT INTO yabe_personals_adress(eBay_account,email,Type,name,street,zipcode,city,country)"
                            strSQL &= "Values( "
                            strSQL &= "'" & lvwData.SubItems(12).Text & "'," ' account
                            strSQL &= "'" & lvwData.SubItems(2).Text & "'," ' email 
                            strSQL &= "'" & lvwData.SubItems(1).Text & "'," ' type
                            strSQL &= "'" & lvwData.SubItems(6).Text.Replace("'", "") & "'," '  ' name
                            strSQL &= "'" & lvwData.SubItems(7).Text.Replace("'", "") & "',"  ' street

                            '# PLZ 
                            Try
                                strSQL &= "'" & lvwData.SubItems(9).Text & "'," ' zipcode
                            Catch ex As Exception
                                strSQL &= "" & "'," ' zipcode
                            End Try

                            '# STRAßE 
                            strSQL &= "'" & lvwData.SubItems(8).Text & "'," ' zipcode

                            strSQL &= "'" & lvwData.SubItems(19).Text & "')" ' country

                        '########################
                        '# >> Update 
                        '########################
                        Case "UPDATE"

                            '# Access Datum 
                            '# #10/14/2007 12:0:0#
                            strDatum_update = "#" & Date.Now.Month & "/" & Date.Now.Day & "/" & Date.Now.Year & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "#"

                            strSQL = "UPDATE yabe_personals_adress set "
                            strSQL &= "eBay_account= '" & lvwData.SubItems(12).Text & "',"
                            strSQL &= "email= '" & lvwData.SubItems(2).Text & "',"
                            strSQL &= "Type= '" & lvwData.SubItems(1).Text & "',"
                            strSQL &= "name= '" & lvwData.SubItems(6).Text.Replace("'", "") & "',"
                            strSQL &= "street= '" & lvwData.SubItems(7).Text.Replace("'", "") & "',"

                            'Dim strCity As String = ""
                            'strCity = lvwData.SubItems(8).Text.Substring(lvwData.SubItems(8).Text.IndexOf(" "), lvwData.SubItems(8).Text.Length)



                            '# PLZ 
                            Try
                                strSQL &= "zipcode= '" & lvwData.SubItems(9).Text & "',"
                            Catch ex As Exception
                                strSQL &= "zipcode= '---',"
                            End Try

                            '# Straße 
                            Try
                                strSQL &= "city= '" & lvwData.SubItems(8).Text & "',"
                            Catch ex As Exception
                                strSQL &= "city= '---',"
                            End Try

                            strSQL &= "country= '" & lvwData.SubItems(19).Text & "'"

                            strSQL &= " WHERE email = '" & lvwData.SubItems(2).Text & "'"

                    End Select

                '#################################################
                '# >> LIST: eBay Live Liste 
                '#################################################                
                Case "lvwEiSoCockpit"

                    '# Auktionsende Datum setzen 
                    str = lvwData.SubItems(9).Text.Split(" ")
                    str2 = str(0).ToString.Split(".")

                    If str(0).LastIndexOf(".") = -1 Then
                        strDatum_auktionsende = str(0) & " " & str(1)
                    Else
                        strDatum_auktionsende = str2(2) & "-" & str2(1) & "-" & str2(0) & " " & str(1)
                    End If

                    '# Auktionsbeginn Datum setzen 
                    str = lvwData.SubItems(11).Text.Split(" ")
                    str2 = str(0).ToString.Split(".")

                    If str(0).LastIndexOf(".") = -1 Then
                        strDatum_auktionsanfang = str(0) & " " & str(1)
                    Else
                        strDatum_auktionsanfang = str2(2) & "-" & str2(1) & "-" & str2(0) & " " & str(1)
                    End If


                    '# >> Hinzufügen oder aktualliserien
                    Select Case strModus

                        '########################
                        '# >> Auktionsartikel
                        '########################
                        Case "ADD"

                            strSQL = "INSERT INTO yabe_auction_list_live(eBay_ID,eBay_account, email, auction_title,current_price, startprice,iseBayEnded,ListType,auction_end,auction_begin,watchcount,shippment,eBayBild,bids,hitcounter) "
                            strSQL &= "Values( "
                            strSQL &= "'" & lvwData.SubItems(0).Text & "',"
                            strSQL &= "'" & lvwData.SubItems(5).Text & "'," ' Account 
                            strSQL &= "'" & lvwData.SubItems(6).Text & "'," ' email 
                            strSQL &= "'" & lvwData.SubItems(1).Text.Replace("'", "''") & "',"
                            strSQL &= lvwData.SubItems(2).Text.Replace(",", ".") & ","
                            strSQL &= lvwData.SubItems(3).Text.Replace(",", ".") & ","
                            strSQL &= "'" & lvwData.SubItems(7).Text & "',"
                            strSQL &= "'" & lvwData.SubItems(8).Text & "',"
                            strSQL &= "'" & strDatum_auktionsende & "',"
                            strSQL &= "'" & strDatum_auktionsanfang & "',"
                            strSQL &= lvwData.SubItems(10).Text & ","
                            strSQL &= "'" & lvwData.SubItems(13).Text & "',"

                            If Not lvwData.SubItems(14).Text = Nothing Then
                                strSQL &= "'" & lvwData.SubItems(14).Text & "',"
                            Else
                                strSQL &= "'0',"
                            End If

                            strSQL &= "'" & lvwData.SubItems(4).Text & "',"
                            strSQL &= lvwData.SubItems(15).Text & ")"

                            '# Gibt es einen Account namen 
                            If lvwData.SubItems(5).Text.Length > 0 Then

                                '# Prüfen ob Adresse exisiert 

                            End If

                        '########################
                        '# >> Update 
                        '########################
                        Case "UPDATE"

                            '# Access Datum 
                            '# #10/14/2007 12:0:0#
                            strDatum_update = "#" & Date.Now.Month & "/" & Date.Now.Day & "/" & Date.Now.Year & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "#"
                            If Not lvwData.SubItems(6).Text = "ERR_zu_alt" Then
                                streMailAdd = "email='" & lvwData.SubItems(6).Text & "', "
                            Else
                                streMailAdd = ""
                            End If


                            strSQL = "UPDATE yabe_auction_list_live set auction_title = '" & lvwData.SubItems(1).Text.Replace("'", "''") & "',current_price = " & lvwData.SubItems(2).Text.Replace(",", ".") & ", startprice = " & lvwData.SubItems(3).Text.Replace(",", ".") & ",bids=" & lvwData.SubItems(4).Text & ",iseBayEnded='" & lvwData.SubItems(7).Text & "',ListType='" & lvwData.SubItems(8).Text & "',eBay_account='" & lvwData.SubItems(5).Text & "'," & streMailAdd & "auction_end='" & strDatum_auktionsende & "',watchcount=" & Convert.ToInt16(lvwData.SubItems(10).Text) & ",auction_begin='" & strDatum_auktionsanfang & "',questions=" & lvwData.SubItems(16).Text & ",eBayBild='" & lvwData.SubItems(14).Text & "',hitcounter=" & lvwData.SubItems(15).Text & " WHERE eBay_ID='" & lvwData.SubItems(0).Text & "'"

                    End Select
                Case "lvwMagento_bestellungen"

                    '# >> Hinzufügen oder aktualliserien
                    Select Case strModus

                        '########################
                        '# >> Auktionsartikel
                        '########################
                        Case "ADD"
                            strSQL = "INSERT INTO yabe_auction_list_live(eBay_ID,eBay_account, email, auction_title,current_price, startprice,iseBayEnded,ListType,auction_end,auction_begin,watchcount,shippment,eBayBild,bids,auction_type,YABE_ID,hitcounter) "
                            strSQL &= "Values( "
                            strSQL &= "'" & lvwData.SubItems(11).Text & "',"

                            If Not lvwData.SubItems(10).Text = "" Then
                                strSQL &= "'" & lvwData.SubItems(10).Text & "'," ' Account  - 
                            Else
                                strSQL &= "'" & lvwData.SubItems(2).Text & "'," ' Account  - 
                            End If

                            strSQL &= "'" & lvwData.SubItems(2).Text & "'," ' email 
                            strSQL &= "'" & lvwData.SubItems(7).Text.Replace("'", "''") & "',"
                            strSQL &= lvwData.SubItems(6).Text.Replace(",", ".") & ","
                            strSQL &= lvwData.SubItems(6).Text.Replace(",", ".") & "," ' startprice 
                            strSQL &= "'Completed'," 'iseBayEnded
                            strSQL &= "'FixedPrice'," ' ListType
                            strSQL &= "'" & lvwData.SubItems(9).Text & "'," ' auktionsende 
                            strSQL &= "'" & lvwData.SubItems(9).Text & "'," ' auktionsanfang 
                            strSQL &= "0," ' beobachter
                            strSQL &= "0," ' versand

                            strSQL &= "'---'," 'ebay bild 

                            strSQL &= "1," ' gebote 
                            strSQL &= "'Magento'," ' Auktionstyp -> Delcampe
                            strSQL &= "'" & lvwData.SubItems(11).Text & "'," ' WEB ID 

                            strSQL &= "0)" ' besucher

                        Case "UPDATE"

                            strSQL = "UPDATE yabe_auction_list_live set auction_title = '" & lvwData.SubItems(7).Text.Replace("'", "''") & "',current_price = " & lvwData.SubItems(6).Text.Replace(",", ".") & ", startprice = " & lvwData.SubItems(6).Text.Replace(",", ".") & ",bids=1,iseBayEnded='Completed',ListType='FixedPrice',eBay_account='" & lvwData.SubItems(10).Text & "'," & streMailAdd & "auction_end='" & lvwData.SubItems(9).Text & ",auction_begin='" & lvwData.SubItems(9).Text & "' WHERE eBay_ID='" & lvwData.SubItems(8).Text & "'"
                    End Select

                '#################################################
                '# >> LIST: Bewertungen
                '#################################################
                Case "lvwBewertungen"

                    '# >> Hinzufügen oder aktualliserien
                    Select Case strModus
                        Case "ADD"

                            '# Eintragsdatum setzen 
                            str = lvwData.SubItems(6).Text.Split(" ")
                            str2 = str(0).ToString.Split(".")

                            If str(0).LastIndexOf(".") = -1 Then
                                strDatum_update = str(0) & " " & str(1)
                            Else
                                strDatum_update = str2(2) & "-" & str2(1) & "-" & str2(0) & " " & str(1)
                            End If


                            strSQL = "INSERT INTO yabe_auction_feedback(eBay_ID,ebay_account,points,type,comment,rolle,feedback_time) "
                            strSQL &= "Values( "
                            strSQL &= lvwData.SubItems(2).Text & ","
                            strSQL &= "'" & lvwData.SubItems(0).Text & "',"
                            strSQL &= "'" & lvwData.SubItems(1).Text & "',"
                            strSQL &= "'" & lvwData.SubItems(3).Text & "',"
                            strSQL &= "'" & lvwData.SubItems(4).Text.Replace("'", "\'") & "',"
                            strSQL &= "'" & lvwData.SubItems(5).Text & "',"
                            strSQL &= "'" & strDatum_update & "')"

                        Case "UPDATE"

                            '# Access Datum 
                            '# #10/14/2007 12:0:0#
                            strDatum_update = "#" & Date.Now.Month & "/" & Date.Now.Day & "/" & Date.Now.Year & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "#"

                            strSQL = "UPDATE yabe_auction_feedback set ebay_account = '" & lvwData.SubItems(0).Text.Replace("'", "''") & "',points = " & lvwData.SubItems(1).Text & ", type = '" & lvwData.SubItems(3).Text & "',comment='" & lvwData.SubItems(4).Text & "' WHERE eBay_ID='" & lvwData.SubItems(2).Text & "'"

                    End Select

            End Select '# Listview

            Return strSQL
        Catch ex As Exception
            Call debug_message(ex, strSQL & vbCrLf & "seInsert_Update_tLvw2SQL")
            Return False
        End Try


    End Function



    '################################################
    '# >> mysql Timestamp erzeugen 
    '################################################
    Public Function getMysqlTimestamp(ByVal datum As Date) As String
        Dim strDatum As String
        Try
            strDatum = datum.Year & "-" & datum.Month & "-" & datum.Day & " " & datum.Hour & ":" & datum.Minute & ":" & datum.Second
            Return strDatum
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getMysqlTimestamp")
            Return False
        End Try
    End Function

    '##########################################################
    '# >> Login Prüfen 
    '##########################################################
    Public Function chkLogin(ByVal strUsername As String, ByVal strPWD As String) As Boolean
        Dim strQuery As String = ""
        Try

            ' setChangeDB("", datenbankzugriff.YABE)

            strQuery = "SELECT * FROM yabe_login WHERE account='" & strUsername & "' AND pwd='" & strPWD & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            Application.DoEvents()
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                While Not dbReader.Read() = False

                    '# Zugrifflevel für YABE holen 
                    My.Settings.yabe_accesslevel = dbReader("access_level")

                    My.Settings.Save()

                    Dim con_update As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                    con_update.Open()
                    strQuery = "UPDATE yabe_login set logincount= logincount +1, lastlogin='" & getMysqlTimestamp(Date.Now) & "'  WHERE account='" & strUsername & "'"
                    Dim command_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_update)
                    command_update.ExecuteNonQuery()
                    con_update.Close()

                    'setChangeDB(My.Settings.datenbank_db, datenbankzugriff.CMS)
                    Return True
                End While
            Else
                Return False
            End If
        Catch ex As Exception
            If ex.Message.Contains("mysql_native_password") = True Then
                MessageBox.Show("Konnte sich nicht mit der Datenbank verbinden!" & vbCrLf & vbCrLf & "Datenbankserver:" & My.Settings.datenbank_server & vbCrLf & "Datenbankbenutzer: " & My.Settings.datenbank_username & vbCrLf & "Datenbankname: " & My.Settings.datenbank_db, "Datenbank login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call debug_message(ex, strQuery & vbCrLf & "chkLogin")
            End If

            Return False
        End Try
        Return True

    End Function

    '###########################################################
    '# >> Datenbank wechseln 
    '###########################################################
    Public Function setChangeDB(strDB As String, ByVal strModus As datenbankzugriff) As Boolean
        Dim strQuery As String = ""

        Try

            Select Case strModus
                Case datenbankzugriff.YABE
                    strQuery = "USE yabe_master"
                Case datenbankzugriff.CMS
                    strQuery = "USE " & strDB

            End Select

            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setDB")
            Return False
        End Try
    End Function



    '######################################################################
    '# >> Artikel auf die Oberfläche übertragen
    '######################################################################
    Public Function getWebArtikel2GUI(ByVal strQuery As String, ByRef frm As frmCMS_change_item) As Boolean

        Try
            'If setChangeDB(datenbankzugriff.CMS) = True Then

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                Dim strISO As String = ""
                Dim strISO2 As String = ""
                strISO = clsDatenbank_modul.getTranslate_l18n_mapping(frm.cmbErstsprache.Text)
                strISO2 = clsDatenbank_modul.getTranslate_l18n_mapping(frm.cmbZweitSprache.Text)

                While Not dbReader.Read() = False

                    frm.txtQuelle.Text = dbReader("Beschreibung" & strISO).ToString
                    frm.txtZiel.Text = dbReader("Beschreibung" & strISO2).ToString

                    frm.lblID.Text = dbReader("ID").ToString
                    frm.txtBildURL.Text = dbReader("Bild").ToString
                    frm.txtAnzahl.Text = dbReader("anzahl").ToString
                    frm.txtPreis.Text = dbReader("Preis").ToString
                    frm.TextBox1.Text = dbReader("price_change_date").ToString
                    frm.bIsLoading = True
                    frm.cmbItemStatus.SelectedIndex = dbReader("Bestellt").ToString
                    '# Selektion richtig setzten 
                    frm.lblCat.Text = dbReader("Kategorie_neo").ToString
                    frm.bIsLoading = False
                End While
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getWebArtikel")
            Return False
        End Try
    End Function

    '###############################################
    '# >> getBEzahlmethode
    '###############################################
    Private Function getWebBezahlmethode(ByVal iModus As Integer) As String
        Try

            Select Case iModus
                Case 0
                    Return "Keine Auswahl"
                Case 1
                    Return "Barzahlung"
                Case 2
                    Return "Paypal"
                Case 3
                    Return "Transfer"
            End Select

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getBezahlmethode")
            Return "-1"
        End Try
        Return "-1"
    End Function


    '###############################################
    '# >> getBEzahlmethode
    '###############################################
    Private Function getWebWoher(ByVal iModus As Integer) As String
        Try

            Select Case iModus
                Case 0
                    Return "eBay Link"
                Case 1
                    Return "Werbe eMail"
                Case 2
                    Return "Linkliste"
                Case 3
                    Return "Google"
                Case 4
                    Return "Dauerkunde"
                Case 5
                    Return "Werbezettel"
                Case 10
                    Return "Keine Auswahl"
            End Select

            Return "-1"
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getWebWoher")
            Return "-1"
        End Try
    End Function

    '####################################################
    '# >> Yabe User Data
    '####################################################
    Public Function getYABEUserData(ByVal strEmail As String) As ArrayList
        Dim strQuery As String
        Dim aryList As New ArrayList

        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "SELECT * FROM yabe_personals_adress JOIN yabe_personals_profile ON yabe_personals_adress.profil_id = yabe_personals_profile.ID WHERE yabe_personals_profile.email='" & strEmail & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                While Not dbReader.Read() = False

                    aryList.Add(dbReader("name").ToString)
                    aryList.Add(dbReader("street").ToString)
                    aryList.Add(dbReader("city").ToString)
                    aryList.Add(dbReader("zipcode").ToString)
                    aryList.Add(dbReader("adress_lastupdate").ToString)
                    aryList.Add(dbReader("country").ToString)
                    aryList.Add(dbReader("eBay_account").ToString)
                    aryList.Add(dbReader("sprach_liste").ToString)
                    aryList.Add(dbReader("eMail_click_count").ToString)
                    aryList.Add(dbReader("letzter_email_klick").ToString)
                    aryList.Add(dbReader("email").ToString)
                    aryList.Add(dbReader("isWebUser").ToString)
                    aryList.Add(dbReader("delcampe_userid").ToString)
                    aryList.Add(dbReader("website_account").ToString)
                    aryList.Add(dbReader("website_pwd").ToString)
                End While

                dbConnect.Close()
            End If

            Return aryList

        Catch ex As Exception
            Call debug_message(ex, "getYABEUserData")
            Return aryList
        End Try
    End Function

    '###########################################################
    '# >> Prüfen der eBay Bilder 
    '###########################################################
    Public Function getWebBestellungen(ByVal strQuery As String, ByRef lvw As ListView) As Boolean
        Try
            Dim iCount As Byte = 0
            lvw.Items.Clear()
            dbConnect.Close()
            dbConnect.Open()
            'dbConnect.ChangeDatabase("db_u10097_01")

            lvw.BeginUpdate()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                While Not dbReader.Read() = False
                    Dim lvwItem As New ListViewItem

                    '# Bestellungen


                    Dim conYABE As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                    conYABE.Open()
                    Dim strQuery2 As String

                    strQuery2 = "SELECT * FROM yabe_personals_adress WHERE ID=" & dbReader("KID").ToString
                    Dim cmdYABE As New MySql.Data.MySqlClient.MySqlCommand(strQuery2, conYABE)
                    Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
                    dbReader2 = cmdYABE.ExecuteReader()

                    '# Gibt es einen Treffer
                    If dbReader2.HasRows = True Then

                        '# Datenbank wechseln 
                        '# --------------------
                        While Not dbReader2.Read() = False
                            lvwItem.Text = dbReader("ID").ToString
                            lvwItem.SubItems.Add(dbReader2("Name").ToString)
                            lvwItem.SubItems.Add(dbReader("ArtikelID").ToString)
                            lvwItem.SubItems.Add(getWebBezahlmethode(dbReader("optZahlung")))
                            lvwItem.SubItems.Add(dbReader("preis").ToString)
                            lvwItem.SubItems.Add(dbReader("date").ToString & " " & dbReader("uhrzeit").ToString)
                            lvwItem.SubItems.Add(getWebWoher(dbReader("optWas").ToString))

                        End While
                    Else
                        lvwItem.Text = dbReader("ID").ToString
                        lvwItem.SubItems.Add("---")
                        lvwItem.SubItems.Add(dbReader("ArtikelID").ToString)
                        lvwItem.SubItems.Add(getWebBezahlmethode(dbReader("optZahlung")))
                        lvwItem.SubItems.Add(dbReader("preis").ToString)
                        lvwItem.SubItems.Add(dbReader("date").ToString & " " & dbReader("uhrzeit").ToString)
                        lvwItem.SubItems.Add(getWebWoher(dbReader("optWas").ToString))
                        conYABE.Close()
                    End If

                    If iCount = 1 Then
                        lvwItem.BackColor = Color.White
                    Else
                        lvwItem.BackColor = Color.WhiteSmoke
                        iCount = 0
                    End If
                    iCount += 1

                    '# Hinzufügen zum Listview 
                    lvw.Items.Add(lvwItem)

                End While

            End If

            lvw.EndUpdate()
            dbConnect.Close()
            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getWebBestellungen")
            Return False
        End Try

    End Function

    Public Function CMS2MagentoID(ByVal strCMSID As String) As String
        Try
            Select Case strCMSID
                Case "1"
                    Return "12"
                Case "2"
                    Return "12,63"
                Case "3"
                    Return "12,64"
                Case "4"
                    Return "12,65"
                Case ""
                    Return "12,66"
                Case "5"
                    Return "12,67"
                Case "6"
                    Return "12,68"
                Case "7"
                    Return "12,69"
                Case "8"
                    Return "12,70"
                Case "9"
                    Return "12,72"
                Case "10"
                    Return "14"
                Case "11"
                    Return "14,76"
                Case "12"
                    Return "14,77"
                Case "13"
                    Return "14,78"
                Case "14"
                    Return "14,79"
                Case "15"
                    Return "9"
                Case "16"
                    Return "9,51"
                Case "17"
                    Return "9,52"
                Case "18"
                    Return "9,53"
                Case "19"
                    Return "9,54"
                Case "20"
                    Return "6"
                Case "21"
                    Return "6,42"
                Case "22"
                    Return "6,43"
                Case "23"
                    Return "6,44"
                Case "24"
                    Return "11"
                Case "25"
                    Return "11,60"
                Case "26"
                    Return "11,61"
                Case "27"
                    Return "11,62"
                Case "28"
                    Return "16"
                Case "29"
                    Return "16,80"
                Case "30"
                    Return "16,81"
                Case "31"
                    Return "16,82"
                Case "32"
                    Return "16,83"
                Case "33"
                    Return "16,84"
                Case "34"
                    Return "16,85"
                Case "35"
                    Return "16,86"
                Case "36"
                    Return "16,87"
                Case "37"
                    Return "16,88"
                Case "38"
                    Return "17"
                Case "39"
                    Return "17,89"
                Case "40"
                    Return "17,90"
                Case "41"
                    Return "17,91"
                Case "42"
                    Return "17,92"
                Case "43"
                    Return "17,93"
                Case "44"
                    Return "17,94"
                Case "45"
                    Return "17,95"
                Case "46"
                    Return "17,96"
                Case "47"
                    Return "17,97"
                Case "48"
                    Return "17,98"
                Case "49"
                    Return "3"
                Case "50"
                    Return "3,23"
                Case "51"
                    Return "3,24"
                Case "52"
                    Return "3,25"
                Case "53"
                    Return "3,26"
                Case "54"
                    Return "3,27"
                Case "55"
                    Return "3,28"
                Case "56"
                    Return "3,29"
                Case "57"
                    Return "3,30"
                Case "65"
                    Return "5"
                Case "66"
                    Return "5,34"
                Case "67"
                    Return "5,35"
                Case "68"
                    Return "5,36"
                Case "69"
                    Return "5,37"
                Case "70"
                    Return "5,38"
                Case "71"
                    Return "5,39"
                Case "72"
                    Return "5,40"
                Case "73"
                    Return "5,41"
                Case "74"
                    Return "4"
                Case "75"
                    Return "4,31"
                Case "76"
                    Return "4,32"
                Case "77"
                    Return "4,33"
                Case "78"
                    Return "7"
                Case "79"
                    Return "8"
                Case "80"
                    Return "10"
                Case "81"
                    Return "10,55"
                Case "82"
                    Return "10,56"
                Case "83"
                    Return "10,57"
                Case "84"
                    Return "10,58"
                Case "85"
                    Return "10,59"
                Case "86"
                    Return "13"
                Case "87"
                    Return "13,73"
                Case "88"
                    Return "13,74"
                Case "89"
                    Return "13,75"
                Case "90"
                    Return "18"
                Case "91"
                    Return "18,99"
                Case "92"
                    Return "18,100"
                Case "93"
                    Return "18,101"
                Case "94"
                    Return "18,102"
                Case "95"
                    Return "18,103"
                Case "96"
                    Return "19"
                Case "97"
                    Return "19,104"
                Case "98"
                    Return "19,105"
                Case "99"
                    Return "19,106"
                Case "100"
                    Return "20"
                Case "101"
                    Return "20,107"
                Case "102"
                    Return "20,108"
                Case "103"
                    Return "21"
                Case "104"
                    Return "21,109"
                Case "105"
                    Return "21,110"
                Case "106"
                    Return "21,111"
                Case "107"
                    Return "22"
                Case "108"
                    Return "22,112"
                Case "109"
                    Return "22,112"
                Case "110"
                    Return "22,113"
                Case "111"
                    Return "22,114"
                Case "112"
                    Return "22,115"
                Case "113"
                    Return "22,116"
                Case "114"
                    Return "22,117"
                Case "115"
                    Return "22,118"
                Case "116"
                    Return "22,119"
                Case "117"
                    Return "22,120"
                Case "118"
                    Return "22,121"
                Case "120"
                    Return "22,122"
                Case "120"
                    Return "7,45"
                Case "121"
                    Return "7,46"
                Case "122"
                    Return "8,48"
                Case "123"
                    Return "8,49"
                Case "124"
                    Return "7,47"
                Case "125"
                    Return "8,50"
            End Select


        Catch ex As Exception
            Call debug_message(ex, "CMS2MagentoID")
            Return "-1"
        End Try

        Return "-1"
    End Function

    '##########################################################
    '# >> Artikel löschen 
    '##########################################################
    Public Function getCMS_items_delete(ByVal strQuery As String) As Boolean

        Try
            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()
            Return True
        Catch ex As Exception
            Call debug_message(ex, "getWebArtikel_delete")
        End Try

    End Function

    '###########################################################
    '# >> Prüfen der eBay Bilder 
    '###########################################################
    Public Function getEiSoItems(ByVal strQuery As String, ByRef lvw As ListView, ByRef lvwMenue As ListView, Optional ByVal iDelcampeID As Integer = -2, Optional ByVal iHauptkategorie As String = "-1", Optional ByVal strMagento_Catid As String = "-2", Optional strShopste_catid As String = "-3", Optional imgList As ImageList = Nothing) As Boolean
        Dim iCount As Integer = 0
        Dim strQuery2 As String = ""
        Dim strSQL_where As String = ""
        Try



            lvw.Items.Clear()
            lvw.BeginUpdate()

            '# -3 Alle Artikel
            '# -2 Importierte Artikel 
            '# -1 Normale Kategorie ladn
            If iHauptkategorie = "-1" Or iHauptkategorie = "-2" Or iHauptkategorie = "-3" Then

                '# Anzahl holen
                If iHauptkategorie = -3 Then
                    strQuery2 = "SELECT  count(*) as anzahl FROM tbl_menue LEFT JOIN tblGes ON tbl_menue.iD = tblGes.Kategorie_neo WHERE  tblGes.Bestellt = 0"
                ElseIf iHauptkategorie = -2 Then
                    'strQuery2 = "SELECT count(*) as anzahl FROM tblGes WHERE Bestellt=4 OR Kategorie_neo is NULL ORDER BY Datum DESC"
                    strQuery2 = "SELECT  count(*) as anzahl FROM tbl_menue RIGHT JOIN tblGes ON tbl_menue.iD = tblGes.Kategorie_neo WHERE  tblGes.Bestellt = 3 OR Kategorie_neo is NULL"
                    iDelcampeID = -999
                ElseIf iHauptkategorie = -1 Then
                    strQuery2 = strQuery
                    strQuery2 = strQuery2.Replace("SELECT * FROM", "SELECT count(*) as anzahl FROM")

                    strQuery2 = strQuery2.Replace("SELECT tblGes.*", "SELECT count(*) as anzahl,tblGes.*")
                End If


                Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection
                Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
                dbConnect2.ConnectionString = dbConnect.ConnectionString
                dbConnect2.Close()
                dbConnect2.Open()
                Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery2, dbConnect2)
                dbReader2 = command2.ExecuteReader()
                If dbReader2.HasRows = True Then
                    dbReader2.Read()
                    frmMain.master_verlauf.Maximum = dbReader2("anzahl")
                    dbConnect2.Close()
                End If


                dbConnect.Close()
                dbConnect.Open()

                '# Artikel holen 
                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
                dbReader = command.ExecuteReader()

                '# Gibt es einen Treffer
                If dbReader.HasRows = True Then

                    Dim strISO As String = ""
                    strISO = getTranslate_l18n_mapping(frmMain.frmManage.cmbSprache_Artikeldatenbank.Text)

                    frmMain.master_verlauf.Visible = True
                    frmMain.master_verlauf.Value = 0

                    '# Datenbank wechseln 
                    '# --------------------
                    While Not dbReader.Read() = False
                        Dim lvwItem As New ListViewItem

                        frmMain.master_verlauf.Value = iCount
                        If iCount Mod 10 = 0 Then
                            Application.DoEvents()
                            frmMain.master_Message_label.Text = "Lade '" & iCount & "'" & dbReader("Beschreibung").ToString
                        End If


                        '# Abbruch erkannt
                        If bStopReadIn = True Then
                            frmMain.StatusStrip1.Items(1).Text = "Abbruch durch Benutzer '" & My.Settings.yabe_username & "' - Sperre aktiv"
                            lvw.EndUpdate()
                            Return False
                            Exit Function
                        End If

                        iCount += 1
                        frmMain.master_Message_label.Text = "Bei: " & iCount & " - " & dbReader("Beschreibung").ToString

                        Dim strBildName As String = ""
                        Dim strID() As String
                        Dim strBild As String
                        Dim strBild_ary() As String
                        If dbReader("ID").ToString.Length > 0 Then
                            strID = dbReader("ID").ToString.Split("-")
                            Dim strFilename() As String
                            strBild = dbReader("Bild").ToString
                            If Not strBild Is Nothing Then
                                strFilename = strBild.Split("/")
                                strBildName = strFilename(strFilename.Length - 1)
                                strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))
                            Else

                            End If
                        Else
                            strBildName = ""
                        End If


                        lvw.Text = dbReader("ID").ToString

                        If Not strBild Is Nothing And My.Settings.lvw_eiso_shop_picture = True Then
                            If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildName) = True Then
                                imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                'MessageBox.Show(frmMain.frmManage.bilder_history.Images(0).Size.ToString)
                                lvwItem.ImageKey = strID(0)
                            Else
                                If strBild.Length > 0 Then
                                    Try
                                        Application.DoEvents()
                                        If My.Settings.domain_id = 43 Then
                                            strBild_ary = strBild.Split("/")
                                            strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                            strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                            My.Computer.Network.DownloadFile(strBild.Replace("http://", "https://"), Application.StartupPath & "\bilderexport\" & strBildName)
                                        Else
                                            My.Computer.Network.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildName)
                                        End If



                                        imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                        lvwItem.ImageKey = strID(0)
                                    Catch ex As Exception
                                        'MessageBox.Show(ex.Message)
                                    End Try

                                End If

                            End If
                        End If

                        lvwItem.Text = dbReader("ID").ToString

                        If frmMain.frmManage.cmbSprache_Artikeldatenbank.Text.Contains("Deutsch") Then
                            lvwItem.SubItems.Add(dbReader("Beschreibung").ToString)
                        Else

                            lvwItem.SubItems.Add(dbReader("Beschreibung" & strISO).ToString)
                        End If

                        lvwItem.SubItems.Add(dbReader("Preis").ToString)
                        lvwItem.SubItems.Add(dbReader("Bild").ToString)

                        If dbReader("export_magento").ToString = "-1" Then

                            If strMagento_Catid = -999 Then
                                lvwItem.SubItems.Add(iDelcampeID)
                            ElseIf strMagento_Catid = -2 Then
                                Try
                                    lvwItem.SubItems.Add(dbReader("magento_menue").ToString)
                                Catch ex As Exception
                                    lvwItem.SubItems.Add(iDelcampeID)
                                End Try
                            ElseIf strMagento_Catid = -1 Then
                                lvwItem.SubItems.Add(strMagento_Catid)
                            ElseIf Not strMagento_Catid = -1 Then
                                lvwItem.SubItems.Add(strMagento_Catid)


                            End If
                        Else
                            lvwItem.SubItems.Add(dbReader("export_magento").ToString)
                        End If


                        '# Auswahl der Delcampe ID 
                        If dbReader("delcampe_id").ToString = "-1" Then

                            If iDelcampeID = -999 Then
                                lvwItem.SubItems.Add(iDelcampeID)
                            ElseIf iDelcampeID = -2 Then
                                Try
                                    lvwItem.SubItems.Add(dbReader("delcampe_menue_id").ToString())
                                Catch ex As Exception
                                    lvwItem.SubItems.Add(iDelcampeID)
                                End Try
                            ElseIf iDelcampeID = -1 Then
                                lvwItem.SubItems.Add(iDelcampeID)
                            ElseIf Not iDelcampeID = -1 Then
                                lvwItem.SubItems.Add(iDelcampeID)


                            End If

                        Else
                            lvwItem.SubItems.Add(dbReader("delcampe_id").ToString)

                        End If

                        lvwItem.SubItems.Add(dbReader("Datum").ToString)
                        lvwItem.SubItems.Add(dbReader("Counter").ToString)

                        '# Bestellstatus auswählen 
                        Select Case dbReader("Bestellt").ToString
                            Case "1"
                                lvwItem.SubItems.Add("Bestellt")
                            Case "2"
                                lvwItem.SubItems.Add("Warteliste")
                            Case "0"
                                lvwItem.SubItems.Add("Aktuell")
                            Case "3"
                                lvwItem.SubItems.Add("Delcampe Lister")
                            Case "4"
                                lvwItem.SubItems.Add("Importiert")
                        End Select

                        lvwItem.SubItems.Add(dbReader("anzahl").ToString)
                        lvwItem.SubItems.Add(strBildName)
                        lvwItem.SubItems.Add(dbReader("Kategorie_neo").ToString)

                        '# Shopste Kategorie
                        If Not dbReader("shopste_itemid").ToString = "" Then
                            lvwItem.SubItems.Add(dbReader("shopste_itemid").ToString)
                        Else
                            If Not dbReader("shopste_catid").ToString Is Nothing Then
                                If dbReader("shopste_catid").ToString = "" Then
                                    lvwItem.SubItems.Add(dbReader("shopste_menue_catid").ToString)
                                Else
                                    lvwItem.SubItems.Add(dbReader("shopste_catid").ToString)
                                End If
                            End If


                        End If
                        lvwItem.SubItems.Add(dbReader("shopste_id").ToString)
                        lvwItem.SubItems.Add(dbReader("shopste_lagerbestand").ToString)
                        lvwItem.SubItems.Add(dbReader("shopste_eingestellt_am").ToString)

                        'lvw.Items.Add(dbReader("anzahl").ToString)
                        lvw.Items.Add(lvwItem)

                    End While

                    frmMain.master_verlauf.Visible = False

                    'lvw.Items(0).Selected = True
                Else
                    '   MessageBox.Show("Keine Artikel gefunden.")
                End If
                dbConnect.Close()
                '###########################
                '# HAUPTKATEGORIE 
                '###########################
            Else

                'strQuery = "SELECT * FROM tbl_menue WHERE Parent=" & iHauptkategorie
                If iHauptkategorie = 0 Then
                    clsDatenbank_modul.strMenueIDs = ""
                    clsDatenbank_modul.getCMS_Menue_tree_ids(lvwMenue.SelectedItems(0).Text, 0)

                    Dim strMenueIDs() As String = clsDatenbank_modul.strMenueIDs.Split(",")
                    Dim iLoop_menue As Integer = 0


                    For iLoop_menue = 0 To strMenueIDs.Length - 2

                        If iLoop_menue = 0 Then
                            strSQL_where &= "("
                        End If

                        If iLoop_menue = strMenueIDs.Length - 2 Then
                            strSQL_where &= " tblGes.Kategorie_neo =" & strMenueIDs(iLoop_menue) & ")"
                        Else
                            strSQL_where &= " tblGes.Kategorie_neo =" & strMenueIDs(iLoop_menue) & " OR "
                        End If

                    Next




                Else
                    strSQL_where = "tblGes.Kategorie_neo=" & lvwMenue.SelectedItems(0).Text & ""

                End If

                Dim strSQL_where_finish As String = ""
                If strSQL_where.Length = 0 Then
                    strSQL_where_finish = "tblGes.Bestellt = 0"
                Else
                    strSQL_where_finish = strSQL_where & " AND tblGes.Bestellt = 0"
                End If

                strQuery2 = "SELECT count(*) as anzahl FROM tbl_menue LEFT JOIN tblGes ON tbl_menue.iD = tblGes.Kategorie_neo WHERE " & strSQL_where_finish

                Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection
                Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
                dbConnect2.ConnectionString = dbConnect.ConnectionString
                dbConnect2.Close()
                dbConnect2.Open()
                Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery2, dbConnect2)
                dbReader2 = command2.ExecuteReader()
                If dbReader.HasRows = True Then
                    dbReader2.Read()
                    frmMain.master_verlauf.Maximum = dbReader2("anzahl")
                    dbConnect2.Close()
                End If

                dbConnect.Close()
                dbConnect.Open()

                strQuery = "SELECT  tbl_menue.delcampe_id as delcampe_menue_id , tbl_menue.export_magento as magento_menue_id, tblGes.*  FROM tbl_menue JOIN tblGes ON tbl_menue.ID = tblGes.Kategorie_neo WHERE " & strSQL_where_finish
                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)

                dbReader = command.ExecuteReader()

                '# Gibt es einen Treffer
                If dbReader.HasRows = True Then


                    '# Daten lesen 
                    '# --------------------

                    Dim strISO As String = ""
                    strISO = getTranslate_l18n_mapping(frmMain.frmManage.cmbSprache_Artikeldatenbank.Text)

                    frmMain.master_verlauf.Visible = True
                    frmMain.master_verlauf.Value = 0

                    If lvwMenue.SelectedItems.Count > 0 Then
                        If lvwMenue.SelectedItems(0).SubItems(6).Text = "" Then
                            lvwMenue.SelectedItems(0).SubItems(6).Text = 0
                        End If
                        frmMain.master_verlauf.Maximum = lvwMenue.SelectedItems(0).SubItems(6).Text + 1
                    End If



                    While Not dbReader.Read() = False

                        iCount += 1
                        Try
                            frmMain.master_verlauf.Value = iCount
                        Catch ex As Exception

                        End Try

                        'If iCount = 49 Then
                        'Stop
                        'End If

                        If iCount Mod 10 = 0 Then
                            Application.DoEvents()
                            frmMain.master_Message_label.Text = "Lade '" & iCount & "'" & dbReader("Beschreibung").ToString
                        End If



                        '# Artikel der Kategorien abrufen 
                        'strQuery = "SELECT * FROM tblGes WHERE Kategorie_neo=" & dbReader("ID").ToString & " AND Bestellt=0"
                        'dbConnect2.Close()
                        'dbConnect2.Open()
                        'Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect2)
                        'dbReader2 = command2.ExecuteReader()
                        ' MsgBox(dbReader("Bezeichnung").ToString)
                        iDelcampeID = dbReader("delcampe_menue_id").ToString
                        strMagento_Catid = dbReader("magento_menue_id").ToString
                        'If dbReader2.HasRows = True Then

                        '    While Not dbReader2.Read() = False



                        Dim lvwItem As New ListViewItem

                        Dim strBildName As String = ""
                        Dim strID() As String
                        Dim strBild As String
                        Dim strBild_ary() As String
                        If dbReader("ID").ToString.Length > 0 Then
                            strID = dbReader("ID").ToString.Split("-")
                            Dim strFilename() As String
                            strBild = dbReader("Bild").ToString
                            If Not strBild Is Nothing Then
                                strFilename = strBild.Split("/")
                                strBildName = strFilename(strFilename.Length - 1)
                                strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))
                            Else

                            End If
                        Else
                            strBildName = ""
                        End If


                        lvw.Text = dbReader("ID").ToString

                        If Not strBild Is Nothing And My.Settings.lvw_eiso_shop_picture = True Then
                            If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildName) = True Then

                                Try
                                    imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                    'MessageBox.Show(frmMain.frmManage.bilder_history.Images(0).Size.ToString)
                                    lvwItem.ImageKey = strID(0)
                                Catch ex As Exception

                                End Try

                            Else
                                If strBild.Length > 0 Then
                                    Try
                                        Application.DoEvents()
                                        If My.Settings.domain_id = 43 Then
                                            strBild_ary = strBild.Split("/")
                                            strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                            strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                            My.Computer.Network.DownloadFile(strBild.Replace("http://", "https://"), Application.StartupPath & "\bilderexport\" & strBildName)
                                        Else
                                            My.Computer.Network.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildName)
                                        End If



                                        imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                        lvwItem.ImageKey = strID(0)
                                    Catch ex As Exception
                                        'MessageBox.Show(ex.Message)
                                    End Try

                                End If

                            End If
                        End If

                        lvwItem.Text = dbReader("ID").ToString
                        Application.DoEvents()
                        '# Abbruch erkannt
                        If bStopReadIn = True Then
                            frmMain.StatusStrip1.Items(1).Text = "Abbruch durch Benutzer '" & My.Settings.yabe_username & "' - Sperre aktiv"
                            lvw.EndUpdate()
                            Return False
                            Exit Function
                        End If

                        If frmMain.frmManage.cmbSprache_Artikeldatenbank.Text.Contains("Deutsch") Then
                            lvwItem.SubItems.Add(dbReader("Beschreibung").ToString)

                        Else
                            lvwItem.SubItems.Add(dbReader("Beschreibung" & strISO).ToString)
                        End If

                        lvwItem.SubItems.Add(dbReader("Preis").ToString)
                        lvwItem.SubItems.Add(dbReader("Bild").ToString)


                        If dbReader("export_magento").ToString = "-1" Then

                            lvwItem.SubItems.Add(strMagento_Catid)


                        Else
                            lvwItem.SubItems.Add(dbReader("export_magento").ToString)
                        End If

                        '# Auswahl der Delcampe ID 
                        If dbReader("delcampe_id").ToString = "-1" Then
                            lvwItem.SubItems.Add(iDelcampeID)
                        Else
                            lvwItem.SubItems.Add(dbReader("delcampe_id").ToString)
                        End If

                        lvwItem.SubItems.Add(dbReader("Datum").ToString)
                        lvwItem.SubItems.Add(dbReader("Counter").ToString)

                        '# Bestellstatus auswählen 
                        Select Case dbReader("Bestellt").ToString
                            Case "1"
                                lvwItem.SubItems.Add("Bestellt")
                            Case "2"
                                lvwItem.SubItems.Add("Warteliste")
                            Case Else
                                lvwItem.SubItems.Add("Aktuell")
                        End Select

                        lvwItem.SubItems.Add(dbReader("anzahl").ToString)
                        lvwItem.SubItems.Add(strBildName)
                        lvwItem.SubItems.Add(dbReader("Kategorie_neo").ToString)

                        If Not dbReader("shopste_itemid").ToString = "" Then
                            lvwItem.SubItems.Add(dbReader("shopste_itemid").ToString)
                        Else
                            lvwItem.SubItems.Add(strShopste_catid)
                        End If

                        lvwItem.SubItems.Add(dbReader("shopste_id").ToString)
                        lvwItem.SubItems.Add(dbReader("shopste_lagerbestand").ToString)
                        lvwItem.SubItems.Add(dbReader("shopste_eingestellt_am").ToString)

                        lvw.Items.Add(lvwItem)

                        '    End While


                        'End If

                    End While
                    frmMain.master_verlauf.Visible = False
                    'lvw.Items(0).Selected = True
                End If


                'dbConnect2.Close()
            End If
            dbConnect.Close()
            lvw.EndUpdate()
        Catch ex As Exception
            lvw.EndUpdate()
            Call debug_message(ex, strQuery & vbCrLf & "getCMS_items")
            Return False
        End Try
        Return True
    End Function

    '###########################################################
    '# >> Bestellungen -> Status setzen 
    '###########################################################
    Public Function setEiSoOrder_status_orderlist(ByVal strOrderID As String, ByVal strModus As yabe_bestellstatus) As Boolean
        Dim strStatus As String = ""
        Dim iStatusFlag As Integer = 0
        Try
            Select Case strModus
                Case yabe_bestellstatus.bestellt
                    strStatus = "Bestellt"
                    iStatusFlag = 1
                Case yabe_bestellstatus.bezahlt
                    strStatus = "Bezahlt"
                    iStatusFlag = 8
                Case yabe_bestellstatus.komplett
                    strStatus = "Komplett"
                    iStatusFlag = 10
                Case yabe_bestellstatus.verschickt
                    strStatus = "Verschickt"
                    iStatusFlag = 9
                Case yabe_bestellstatus.storniert
                    strStatus = "Storniert"
                    iStatusFlag = 11
                Case yabe_bestellstatus.uebernommen
                    strStatus = "Übernommen"
                    iStatusFlag = 13
            End Select


            Select Case strModus
                Case status_date.bezahlt
                    strQuery = "UPDATE yabe_order_list SET order_status_history_id='" & iStatusFlag & "',bezahlt_am='@newDate' WHERE orderID='" & strOrderID & "'"

                Case status_date.verschickt
                    strQuery = "UPDATE yabe_order_list SET order_status_history_id='" & iStatusFlag & "',verschickt_am='@newDate' WHERE orderID='" & strOrderID & "'"

                Case status_date.bewertet
                    strQuery = "UPDATE yabe_order_list SET order_status_history_id='" & iStatusFlag & "',bewertet_am='@newDate' WHERE orderID='" & strOrderID & "'"

                Case status_date.abgeschlossen
                    strQuery = "UPDATE yabe_order_list SET order_status_history_id='" & iStatusFlag & "',abschlossen_am='@newDate' WHERE orderID='" & strOrderID & "'"
                Case status_date.storniert
                    strQuery = "UPDATE yabe_order_list SET order_status_history_id='" & iStatusFlag & "',storniert_am='@newDate' WHERE orderID='" & strOrderID & "'"
            End Select


            '# JB Neue Struktur alle Unterartikel
            dbConnect.Close()
            dbConnect.Open()
            'strQuery = "UPDATE yabe_order_list SET order_status_history_id='" & iStatusFlag & "' WHERE orderID='" & strID & "'"
            Dim command22 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim db_date As Date = Date.Now
            command22.Parameters.Add("newDate", SqlDbType.DateTime).Value = db_date.ToString("yyyy-MM-dd HH:mm:ss")

            command22.ExecuteNonQuery()
            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setYABE_Order_status")
            Return False
        End Try
    End Function

    Public Function setDB_status_date(strModus As status_date, strOrderID As String) As Boolean
        Try
            dbConnect.Close()
            dbConnect.Open()

            Select Case strModus
                Case status_date.bezahlt
                    strQuery = "UPDATE yabe_order_list SET bezahlt_am='@newDate' WHERE orderID='" & strOrderID & "'"

                Case status_date.verschickt
                    strQuery = "UPDATE yabe_order_list SET verschickt_am='@newDate' WHERE orderID='" & strOrderID & "'"

                Case status_date.bewertet
                    strQuery = "UPDATE yabe_order_list SET bewertet_am='@newDate' WHERE orderID='" & strOrderID & "'"

                Case status_date.abgeschlossen
                    strQuery = "UPDATE yabe_order_list SET abschlossen_am='@newDate' WHERE orderID='" & strOrderID & "'"
                Case status_date.storniert
                    strQuery = "UPDATE yabe_order_list SET storniert_am='@newDate' WHERE orderID='" & strOrderID & "'"
            End Select

            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim db_date As Date = Date.Now

            command2.Parameters.Add("newDate", SqlDbType.DateTime).Value = db_date.ToString("yyyy-MM-dd HH:mm:ss")

            dbConnect.Close()
            dbConnect.Open()
            command2.ExecuteNonQuery()
            dbConnect.Close()
        Catch ex As Exception
            Call debug_message(ex, "setDB_status_date")
            Return False
        End Try
    End Function


    '###########################################################
    '# >> Bestellungen -> Status setzen 
    '###########################################################
    Public Function setEiSoOrder_status(ByVal strID As String, ByVal strModus As yabe_bestellstatus) As Boolean
        Dim strStatus As String = ""
        Dim iStatusFlag As Integer = 0
        Try
            Select Case strModus
                Case yabe_bestellstatus.bestellt
                    strStatus = "Bestellt"
                    iStatusFlag = 1
                Case yabe_bestellstatus.bezahlt
                    strStatus = "Bezahlt"
                    iStatusFlag = 8
                Case yabe_bestellstatus.komplett
                    strStatus = "Komplett"
                    iStatusFlag = 10
                Case yabe_bestellstatus.verschickt
                    strStatus = "Verschickt"
                    iStatusFlag = 9
                Case yabe_bestellstatus.storniert
                    strStatus = "Storniert"
                    iStatusFlag = 11
                Case yabe_bestellstatus.uebernommen
                    strStatus = "Übernommen"
                    iStatusFlag = 13
            End Select

            ' api.php?objectType=auction&action='+action+'&language='+language+'&login=delcampe&password=delcampe'
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_auction_list_history SET status='" & strStatus & "' WHERE eBay_ID='" & strID & "'"
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            command2.ExecuteNonQuery()
            dbConnect.Close()


            '# JB Neue Struktur alle Unterartikel
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_order_item SET order_history_status_id='" & iStatusFlag & "' WHERE received_orderid='" & strID & "'"
            Dim command22 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            command22.ExecuteNonQuery()
            dbConnect.Close()



            Return True
        Catch ex As Exception
            Call debug_message(ex, "setEiSoOrder_status")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> eBay Galerie -> Artikel  abrufen
    '###########################################################
    Public Function getEBayArtikelGalerie(ByRef lvw As ListView) As Boolean

        Dim strQuery As String = ""
        Try

            lvw.Items.Clear()
            strQuery = "SELECT * FROM yabe_cubss_galerie"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            'dbConnect.ChangeDatabase("db_u10097_01")
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                While Not dbReader.Read() = False
                    Dim lvwItem As New ListViewItem

                    lvwItem.Text = dbReader("ID").ToString
                    lvwItem.SubItems.Add(dbReader("eBayBeschreibung").ToString)
                    lvwItem.SubItems.Add(dbReader("aktuellerPreis").ToString)
                    lvwItem.SubItems.Add(dbReader("eBayBildURL").ToString)

                    lvw.Items.Add(lvwItem)

                End While

            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "geteBayArtikel")
            Return False
        End Try
        Return True
    End Function

    '###########################################################
    '# >> Prüfen der eBay Bilder 
    '###########################################################
    Public Function chkCMS_picture_check(ByRef lvw As ListView, ByVal lblMessage As Label, Optional ByRef lvwTarget As ListView = Nothing) As Boolean
        Dim strQuery As String = ""
        Try

            lvw.BeginUpdate()

            Select Case lvw.Name
                Case "lvwWebArtikel"

                    lvwTarget.Items.Clear()
                    '# Datenbank wechseln 
                    '# --------------------
                    Dim iCount As Integer = 0

                    For iCount = 0 To lvw.Items.Count - 1
                        Dim lvwItem As New ListViewItem

                        lvwItem.Text = lvw.Items(iCount).Text
                        lvwItem.SubItems.Add(lvw.Items(iCount).SubItems(1).Text)
                        lvwItem.SubItems.Add(lvw.Items(iCount).SubItems(2).Text)
                        lvwItem.SubItems.Add(DownloadWebpage(lvw.Items(iCount).SubItems(3).Text, chkBilderData.check))

                        lvwTarget.Items.Add(lvwItem)
                        Application.DoEvents()
                        lblMessage.Text = "Bildprüfung: " & lvw.Items.Count - 1
                        lvwTarget.EnsureVisible(lvwTarget.Items.Count - 1)

                    Next


                Case "lvweBayGalerie"


                    strQuery = "SELECT * FROM yabe_auction_list_live WHERE not eBayBild='' AND not isEbayEnded = 'Completed'"
                    Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
                    dbConnect.Close()
                    dbConnect.Open()
                    dbReader = command.ExecuteReader()
                    lvw.Items.Clear()
                    '# Gibt es einen Treffer
                    If dbReader.HasRows = True Then

                        '# Datenbank wechseln 
                        '# --------------------
                        While Not dbReader.Read() = False
                            Dim lvwItem As New ListViewItem

                            lvwItem.Text = dbReader("eBay_ID").ToString
                            lvwItem.SubItems.Add(dbReader("auction_title").ToString)
                            lvwItem.SubItems.Add(dbReader("eBayBild").ToString)
                            lvwItem.SubItems.Add(DownloadWebpage(dbReader("eBayBild").ToString, chkBilderData.check))

                            lvw.Items.Add(lvwItem)
                            Application.DoEvents()
                            lblMessage.Text = "Bildprüfung: " & lvw.Items.Count - 1
                            lvw.EnsureVisible(lvw.Items.Count - 1)
                        End While

                    End If

            End Select

            lvw.EndUpdate()

        Catch ex As Exception
            lvw.EndUpdate()
            Call debug_message(ex, strQuery & vbCrLf & "chkBilder")
            Return False
        End Try

        Return True
    End Function

    '###########################################################
    '# >> setDropLivelist: Löschen der Live Liste
    '###########################################################
    Function setDropLivelist() As Boolean
        Dim strQuery As String = ""

        Try

            strQuery = "DELETE FROM yabe_auction_list_live"
            Clipboard.SetText(strQuery)
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader()
            dbConnect.Close()
            Return True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setDropLivelist")
            Return False
        End Try

    End Function

    '###########################################################
    '# >> Berechnen der Gesammtsumem für Käufer
    '###########################################################
    Function getTotalSum(ByVal strMitgliedsname As String, Optional ByVal strTable As String = "") As String
        Dim strQuery As String = ""
        Try

            If strTable.Length = 0 Then
                strTable = "yabe_auction_list_live"
            End If

            strQuery = "SELECT sum(current_price) as anzahl FROM " & strTable & " WHERE eBay_account='" & strMitgliedsname & "'"
            'Clipboard.SetText(strQuery)
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then
                dbReader.Read()

                Return dbReader("anzahl").ToString
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getTotalSum")
            Return False
        End Try

        Return False
    End Function

    '###########################################################
    '# >> Download des Bildes 
    '###########################################################
    ' Lädt den Quelltext einer Seite aus dem Inter-/Intranet herunter  
    ' und liefert ihn als String zurück. Bei Auftreten eines 
    ' beliebigen Fehlers wird ein leerer String returniert. 
    Public Function DownloadWebpage(ByVal URL As String, ByVal strModus As chkBilderData) As String
        Dim IoStream As System.IO.Stream

        Try
            ' Einen WebRequest für den URL erzeugen 
            Dim Request As System.Net.WebRequest = System.Net.WebRequest.Create(URL)


            ' Die Antwort auf den Request in einen Stream legen 
            IoStream = Request.GetResponse.GetResponseStream
            IoStream.Close()
            Return "202 OK"

        Catch ex As Exception ' bei beliebigem Fehler 
            Return ex.Message
        End Try
    End Function

    '###########################################################
    '# >> ALTE: eMail Datenbank 
    '###########################################################
    Public Function seteMailDb(ByVal lvw As ListView) As Boolean
        Dim iCount As Integer = 0
        Dim strSQL As String = ""

        Try


            For iCount = 0 To lvw.Items.Count - 1

                strSQL = ""
                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
                dbConnect.Close()
                dbConnect.Open()
                command.ExecuteNonQuery()
                dbConnect.Close()
            Next iCount

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "seteMailDb")
            Return False
        End Try

        Return True
    End Function

    '###########################################################
    '# >> Persönliche ID ermitteln 
    '###########################################################
    Public Function getPersonalID(ByVal streMail As String) As String
        Dim strData As String = ""
        Dim strSQL As String = ""
        Try


            strSQL = "SELECT * FROM `yabe_personals_adress` WHERE email='" & streMail & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            If dbReader.HasRows Then
                dbReader.Read()
                strData = dbReader("ID").ToString
                dbConnect.Close()
            End If

            Return strData
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getPersonalID")
            Return "-1"
        End Try
    End Function

    '######################################################################
    '# >> YABE Artikel -> ID => als Bestellt markieren
    '######################################################################
    Public Function setOrdered_byYABEID(ByVal strYABEID As String) As Boolean
        Dim strSQL As String
        Try

            If strYABEID.Length = 0 Then
                Return False
            End If

            strSQL = "SELECT * FROM `tblGes` WHERE ID=" & strYABEID
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            If dbReader.HasRows Then
                dbReader.Read()

                '# Anzahl berücksichtigen
                Dim iAnzahl As Integer = Convert.ToInt16(dbReader("anzahl").ToString)
                iAnzahl = iAnzahl - 1
                If iAnzahl <= 0 Then
                    strSQL = "UPDATE tblGes SET Bestellt=1,anzahl=" & iAnzahl & " WHERE ID=" & strYABEID
                Else
                    strSQL = "UPDATE tblGes SET anzahl=" & iAnzahl & " WHERE ID=" & strYABEID
                End If


                Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
                dbConnect.Close()
                dbConnect.Open()
                command2.ExecuteNonQuery()
                Return True
            Else
                dbConnect.Close()
                Return False
            End If

            Return True

        Catch ex As Exception
            Call debug_message(ex, "setOrdered_byYABEID")
            Return False
        End Try
    End Function

    '######################################################################
    '# >> YABE Artikel -> Beschreibung => als Bestellt markieren
    '######################################################################
    Public Function setOrdered_byBeschreibung(ByVal strBeschreibung As String) As Boolean
        Dim strSQL As String = ""
        Try

            strSQL = "SELECT * FROM `tblGes` WHERE Beschreibung='" & strBeschreibung & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection
            dbConnect2.ConnectionString = dbConnect.ConnectionString
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            If dbReader.HasRows Then
                dbReader.Read()
                strSQL = "UPDATE tblGes SET Bestellt=1 WHERE ID=" & dbReader("ID").ToString
                Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect2)
                dbConnect2.Close()
                dbConnect2.Open()
                command2.ExecuteNonQuery()
                Return True
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try

    End Function
    '###########################################################
    '# >> Persönliche ID ermitteln 
    '###########################################################
    Public Function getMemberAdress_email(ByVal strEmail As String) As String()
        Dim strData(10) As String
        Dim strSQL As String = ""
        Dim str() As String
        Try

            str = strEmail.Split(" ")
            If str.Length > 0 Then

                If IsNumeric(strEmail) Then
                    strSQL = "SELECT * FROM `yabe_personals_adress` WHERE profil_id='" & str(0) & "'"
                Else
                    strSQL = "SELECT * FROM `yabe_personals_adress` WHERE email='" & str(0) & "'"
                End If


                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
                dbConnect.Close()
                dbConnect.Open()
                dbReader = command.ExecuteReader

                If dbReader.HasRows Then
                    dbReader.Read()
                    strData(0) = dbReader("name").ToString
                    strData(1) = dbReader("street").ToString
                    strData(2) = dbReader("zipcode").ToString & " " & dbReader("city").ToString
                    strData(3) = dbReader("country").ToString
                    strData(4) = dbReader("country_code").ToString
                End If
            End If

            Return strData
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getMemberAdress")
            strData(0) = "-1"
            Return strData
        End Try

    End Function

    Public Function getMemberProfil_by_email(ByVal strEmail As String) As String()
        Dim strSQL As String = ""
        Dim strData(3) As String

        strSQL = "SELECT * FROM `yabe_personals_profile` WHERE email='" & strEmail & "'"

        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
        dbConnect.Close()
        dbConnect.Open()
        dbReader = command.ExecuteReader

        If dbReader.HasRows Then
            dbReader.Read()
            '0 - Name
            '1 - Straße
            '2 - PLz  + ORT
            '3 - Land
            '4 - Land Code
            '5 - PLZ
            '6 - Stadt
            strData(0) = dbReader("website_account").ToString
            strData(1) = dbReader("website_pwd").ToString
            strData(2) = dbReader("CRC").ToString
        End If

        Return strData
    End Function

    '###########################################################
    '# >> Persönliche ID ermitteln 
    '###########################################################
    Public Function getEiSoOrderDetails(ByVal strEmail As String) As String()
        Dim strData(10) As String
        Dim strSQL As String = ""
        Dim str() As String
        Dim dblGesSum As Double = 0
        Dim dblShippment As Double = 0.0
        Dim dblOrderTotal As Double = 0
        Dim dblPayPalsum As Double = 0
        Dim strShippment As String = ""
        Dim dblTotalSum As Double = 0
        Try

            str = strEmail.Split(" ")
            If str.Length > 0 Then

                If IsNumeric(strEmail) Then
                    strSQL = "SELECT * FROM `yabe_auction_list_live` WHERE profil_id='" & str(0) & "'"
                Else
                    strSQL = "SELECT * FROM `yabe_auction_list_live` WHERE email='" & str(0) & "'"
                End If

                Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection
                dbConnect2.ConnectionString = dbConnect.ConnectionString
                dbConnect2.Close()
                dbConnect2.Open()
                Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect2)

                dbReader2 = command.ExecuteReader

                If dbReader2.HasRows Then
                    While Not dbReader2.Read() = False

                        If dbReader2("eiso_orderlist_id") IsNot Nothing Then
                            If dbReader2("eiso_orderlist_id") > 0 Then
                                'Str(0) = dbReader("shippment_amount").ToString
                                'Str(1) = dbReader("order_total").ToString
                                'Str(2) = dbReader("paypal_total_sum").ToString
                                'Str(3) = dbReader("total_sum_amount").ToString
                                'Str(4) = dbReader("total_rabatt").ToString
                                'Str(5) = dbReader("total_rabatt_prozent").ToString
                                ' 6 = Kommentar
                                ' 7 = Versandart
                                Dim strOrderData() As String = clsDatenbank_modul.getOrderListDetails(dbReader2("eiso_orderlist_id"))

                                dblOrderTotal = strOrderData(1)
                                dblShippment = strOrderData(0)
                                dblPayPalsum = strOrderData(2)
                                dblTotalSum = strOrderData(3)
                                Exit While
                            Else
                                dblOrderTotal += Convert.ToDouble(dbReader2("current_price").ToString.Replace(".", ","))

                                strShippment = dbReader2("shippment")
                                If dblShippment < Convert.ToDouble(strShippment) Then
                                    dblShippment = Convert.ToDouble(strShippment.Replace(".", ","))
                                End If

                                If dblPayPalsum < Convert.ToDouble(dbReader2("paypal_sum").ToString.Replace(".", ",")) Then
                                    dblPayPalsum = Convert.ToDouble(dbReader2("paypal_sum").ToString.Replace(".", ","))
                                End If
                            End If

                        End If


                    End While

                End If


                strData(0) = dblOrderTotal
                strData(1) = dblShippment
                strData(2) = dblPayPalsum
                strData(3) = dblTotalSum
                dbConnect2.Close()
            End If

            Return strData
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEiSoOrderDetails")
            strData(0) = "-1"
            Return strData
        End Try

    End Function

    Public Function getOrderListDetails(strEiSoOrderID As String) As String()
        Try
            Dim strSQL As String = "SELECT * FROM `yabe_order_list` LEFT JOIN yabe_order_shippment_method ON yabe_order_list.order_shippment_method_id = yabe_order_shippment_method.order_shippment_method_id  WHERE orderID='" & strEiSoOrderID & "'"
            Dim str(10) As String

            Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection
            dbConnect2.ConnectionString = dbConnect.ConnectionString
            dbConnect2.Close()
            dbConnect2.Open()
            Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect2)

            dbReader2 = command.ExecuteReader

            If dbReader2.HasRows Then
                While Not dbReader2.Read() = False
                    str(0) = dbReader2("shippment_amount").ToString
                    str(1) = dbReader2("order_total").ToString
                    str(2) = dbReader2("paypal_total_sum").ToString
                    str(3) = dbReader2("total_sum_amount").ToString
                    str(4) = dbReader2("total_rabatt").ToString
                    str(5) = dbReader2("total_rabatt_prozent").ToString
                    str(6) = dbReader2("kommentar").ToString
                    str(7) = dbReader2("name_de").ToString
                End While
            End If
            If str(0) = "" Then
                str(0) = 0
            End If
            If str(1) = "" Then
                str(1) = 0
            End If
            If str(2) = "" Then
                str(2) = 0
            End If
            If str(3) = "" Then
                str(3) = 0
            End If
            If str(4) = "" Then
                str(4) = 0
            End If
            If str(5) = "" Then
                str(5) = 0
            End If
            If str(7) = "" Then
                str(7) = 0
            End If
            dbConnect2.Close()
            Return str
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getOrderListDetails")
        End Try
    End Function

    '###########################################################
    '# >> Persönliche ID ermitteln 
    '###########################################################
    Public Function getEiSoIsCostumerAdressByEmailOrID(ByVal strEmail As String) As String()
        Dim strData(10) As String
        Dim strSQL As String = ""
        Dim str() As String
        Try

            str = strEmail.Split(" ")
            If str.Length > 0 Then

                If IsNumeric(strEmail) Then
                    strSQL = "SELECT * FROM `yabe_personals_adress` WHERE profil_id='" & str(0) & "'"
                Else
                    strSQL = "SELECT * FROM `yabe_personals_adress` WHERE email='" & str(0) & "'"
                End If

                Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection
                dbConnect2.ConnectionString = dbConnect.ConnectionString
                dbConnect2.Close()
                dbConnect2.Open()

                Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect2)


                dbReader2 = command.ExecuteReader

                If dbReader2.HasRows Then
                    dbReader2.Read()
                    '0 - Name
                    '1 - Straße
                    '2 - PLz  + ORT
                    '3 - Land
                    '4 - Land Code
                    '5 - PLZ
                    '6 - Stadt
                    strData(0) = dbReader2("name").ToString
                    strData(1) = dbReader2("street").ToString
                    strData(2) = dbReader2("zipcode").ToString & " " & dbReader2("city").ToString
                    strData(3) = dbReader2("country").ToString
                    strData(4) = dbReader2("country_code").ToString
                    strData(5) = dbReader2("zipcode").ToString
                    strData(7) = dbReader2("city").ToString
                    strData(6) = dbReader2("profil_id").ToString
                End If
                dbConnect2.Close()
            End If



            Return strData
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getMemberAdress")
            strData(0) = "-1"
            Return strData
        End Try

    End Function

    '###########################################################
    '# >> Persönliche ID ermitteln 
    '###########################################################
    Public Function getMemberAdress(ByVal strMembername As String) As String()
        Dim strData(10) As String
        Dim strSQL As String = ""
        Dim str() As String
        Try

            str = strMembername.Split(" ")
            If str.Length > 0 Then

                If IsNumeric(strMembername) Then
                    strSQL = "SELECT * FROM `yabe_personals_adress` WHERE profil_id='" & str(0) & "'"
                Else
                    strSQL = "SELECT * FROM `yabe_personals_adress` WHERE eBay_account='" & str(0) & "'"
                End If


                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
                dbConnect.Close()
                dbConnect.Open()
                dbReader = command.ExecuteReader

                If dbReader.HasRows Then
                    dbReader.Read()
                    strData(0) = dbReader("name").ToString
                    strData(1) = dbReader("street").ToString
                    strData(2) = dbReader("zipcode").ToString & " " & dbReader("city").ToString
                    strData(3) = dbReader("country").ToString
                    strData(4) = dbReader("country_code").ToString
                End If
            End If

            Return strData
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getMemberAdress")
            strData(0) = "-1"
            Return strData
        End Try

    End Function

    '###########################################################
    '# >> eBay Anzahl abrufen 
    '###########################################################
    Public Function getQueryCount(ByVal strTable As datentabelle, ByVal strWhere As String) As String
        Dim strSQL As String = ""
        Dim strAnzahl As String = ""
        Try
            Select Case strTable.ToString
                Case "yabe_personals_adress"
                    Return -1
                    Exit Function
            End Select
            strSQL = "SELECT count(*) as anzahl FROM " & strTable.ToString & " " & strWhere

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader
            dbReader.Read()
            strAnzahl = dbReader(0).ToString
            dbConnect.Close()

            Return strAnzahl
        Catch ex As Exception
            Call debug_message(ex, "getQueryCount")
            Return -1
        End Try

    End Function

    '###########################################################
    '# >> Update oder Neu 
    '###########################################################
    Public Function chkUpdate_Add(ByVal strValue As String, Optional ByVal strTable As String = "yabe_auction_list_live", Optional ByVal col As String = "-1") As String

        Dim strSQL As String = ""
        Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
        Try
            '# Es kein Kein Spalten Mapping 
            If col = "-1" Then
                strSQL = "SELECT count(*) as anzahl FROM " & strTable & " WHERE eBay_ID='" & strValue & "'"

            Else ' Es gibt ein Mapping 
                strSQL = "SELECT count(*) as anzahl FROM " & strTable & " WHERE " & col & "='" & strValue & "'"
            End If


            'dbConnect.Close()
            'dbConnect.ConnectionString = strConnection_OLEDB_ADO

            'Dim command As New Data.Odbc.OleDbCommand(strSQL, dbConnect)
            Dim dbConnect_con As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            dbConnect_con.Close()
            dbConnect_con.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect_con)
            dbReader2 = command.ExecuteReader

            If dbReader2.HasRows = True Then
                dbReader2.Read()
                Try
                    If Convert.ToInt32(dbReader2("anzahl").ToString) > 0 Then
                        dbConnect_con.Close()
                        Return "UPDATE"
                    Else
                        dbConnect_con.Close()
                        Return "ADD"
                    End If
                Catch ex As Exception
                    Call debug_message(ex, "chkUpdate_Add")
                    Return "-1"
                End Try

            End If

            Return "-1"
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "chkUpdate_add")
            Return "-1"
        End Try

    End Function

    '#############################################
    '# >> Testen ob DB Verbindung klappt
    '#############################################
    Public Function setTestOpenDB() As String
        Try
            If dbConnect.State = ConnectionState.Open Then
                dbConnect.Close()
            End If
            dbConnect.Open()

            Return "Datenbankverbindung zum Server OK"
        Catch ex As Exception
            Return ex.Message.ToString()

        End Try
    End Function

    '#############################################
    '# >> Konfiguriert Datenbank Schnittstelle
    '#############################################
    Public Function setINITDB(ByVal strDBPfad As String, ByVal strConnection As String) As Boolean

        Try
            '# Datenbank 
            If dbConnect.State = ConnectionState.Open Then
                dbConnect.Close()
            End If

            'strConnection_OLEDB_ADO = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBPfad
            If strConnection.Length = 0 Then

                strINI_serverdaten.strmySQL_server = My.Settings.datenbank_server
                strINI_serverdaten.strmySQL_user = My.Settings.datenbank_username
                strINI_serverdaten.strmySQL_pwd = settings_crypt(False, My.Settings.datenbank_pwd)
                'strConnection = "Server=" & strINI_serverdaten.strmySQL_server & ";Database=" & My.Settings.datenbank_db & ";UID=" & strINI_serverdaten.strmySQL_user & ";PWD=" & strINI_serverdaten.strmySQL_pwd & ";Options=3"

                strConnection = "persist security info=True;server=" & strINI_serverdaten.strmySQL_server & ";user id=" & strINI_serverdaten.strmySQL_user & ";Password='" & strINI_serverdaten.strmySQL_pwd & "';database=" & My.Settings.datenbank_db & ";Compress=" & My.Settings.datenbank_compress & ";Allow Zero Datetime=True;Connect Timeout=" & My.Settings.mysql_timeout & ";Pooling=" & My.Settings.datenbank_pooling
                strConnection_master_template = strConnection
                dbConnect.ConnectionString = strConnection_master_template
            Else
                strConnection_master_template = strConnection & ";Allow Zero Datetime=True;Connect Timeout=" & My.Settings.mysql_timeout
                dbConnect.ConnectionString = strConnection_master_template
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setINITDB")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> Prüfen der Gebotsanzahl in der Datenbank
    '###########################################################
    Public Function chkGebote(ByVal streBay_ID As String) As String
        Dim strSQL As String = ""
        Dim strGebote As String = ""
        Try

            strSQL = "SELECT bids FROM yabe_auction_list_live where eBay_ID='" & streBay_ID & "'"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader
            dbReader.Read()

            strGebote = dbReader("bids").ToString
            dbConnect.Close()
            Return strGebote

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "chkGebote")
            Return "-1"
        End Try

    End Function

    Public Function geteBayLive_email(ByVal eBayID As String) As String
        Dim strSQL As String
        Dim strData As String
        Try
            ' 
            strSQL = "SELECT email FROM yabe_auction_list_live where eBay_ID='" & eBayID & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            If dbReader.HasRows = True Then
                dbReader.Read()
                strData = dbReader("email").ToString
                dbConnect.Close()
                Return strData
            Else
                Return "-1"
            End If
        Catch ex As Exception
            Call debug_message(ex, "getEbayLive")
            Return "-1"
        End Try
    End Function

    '###########################################################
    '# >> Wurde bereits eingefügt
    '###########################################################
    Public Function getIseBayIDStored(ByVal eBayID As String) As Boolean
        Dim strSQL As String

        Try
            ' 
            strSQL = "SELECT eBay_ID FROM yabe_auction_list_history where eBay_ID='" & eBayID & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            If dbReader.HasRows = True Then
                dbReader.Read()
                dbConnect.Close()
                Return True
            Else
                Return False
            End If

            Return False ' Sonderfall 
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getIseBayIDStored")
            Return False ' Fehler 
        End Try
    End Function

    '###########################################################
    '# >> LISTVIEW - Daten in der Datenbank speichern 
    '###########################################################
    Public Function setListviewData_save(ByRef lvwData As ListView, ByVal frm As frmAuktionmanagement, ByRef pgreBayLiveUpdate As ProgressBar) As Boolean

        Dim strSQL As String = ""
        Dim streBay_ID As String = ""
        Dim lngCount As Integer
        Dim bInsert As Boolean = False
        Dim iBewertet_nicht As Integer = 0
        Dim iBewertet As Integer = 0
        Try

            iGeboteNeu_Anzahl = 0
            pgreBayLiveUpdate.Value = 0
            pgreBayLiveUpdate.Maximum = lvwData.Items.Count

            'lvwData.BeginUpdate()
            '  lvwData.Enabled = False


            '# Schleifendurchlauf für komplette Listview 
            For lngCount = 0 To lvwData.Items.Count - 1


                If bStopReadIn = True Then
                    Exit For
                End If
                'Application.DoEvents()

                ' Anzeige aktuallisieren 
                pgreBayLiveUpdate.Value += 1

                'If lngCount = 0 Then
                '    lvwData.Items(lngCount).Selected = True
                'Else
                '    lvwData.Items(lngCount - 1).Selected = False
                '    lvwData.Items(lngCount).Selected = True
                'End If



                '#########################################
                '# >> Modull bestimmen 
                '#########################################
                Select Case lvwData.Name

                    '##############################
                    '# LIST: eBay Live Liste 
                    '##############################
                    Case "lvwEiSoCockpit"


                        '# Abbruch gedrückt 
                        If frmMain.frmManage.bStoppLiveRefresh = True Then
                            Exit For
                        End If

                        'If getIseBayIDStored(lvwData.Items(lngCount).SubItems(0).Text) = False Then

                        '# eBay ID bestimmen 
                        streBay_ID = lvwData.Items(lngCount).SubItems(0).Text
                        lvwData.Items(lngCount).Selected = True
                        lvwData.EnsureVisible(lngCount)
                        Application.DoEvents()
                        frmMain.master_Message_label.Text = (lngCount + 1) & " / " & lvwData.Items.Count & " | " & lvwData.Items(lngCount).SubItems(1).Text

                        '##############################
                        '# >> Aktuallisieren / Neu 
                        '##############################
                        Dim strStatus As String = chkUpdate_Add(streBay_ID)

                        If strStatus = "ADD" Then

                            strSQL = setInsert_Update_tLvw2SQL(lvwData.Items(lngCount), "lvweBayLiveList", "ADD")

                            iGeboteNeu_Anzahl += 1



                        ElseIf strStatus = "UPDATE" Then


                            If Not chkGebote(streBay_ID) = lvwData.Items(lngCount).SubItems(4).Text Then
                                iGeboteNeu_Anzahl += 1
                            End If

                            strSQL = setInsert_Update_tLvw2SQL(lvwData.Items(lngCount), "lvweBayLiveList", "UPDATE")
                        Else
                            MsgBox("Kein richtiger Modus gefunden [ADD / UPDATE]", MsgBoxStyle.Critical)
                            strSQL = ""
                        End If


                        If strSQL.Length > 0 Then
                            Dim dbConnect_con As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                            dbConnect_con.Close()
                            dbConnect_con.Open()
                            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect_con)

                            command.ExecuteNonQuery()

                            dbConnect_con.Close()
                        End If

                    '  End If '# End Inserted

                    '##############################
                    '# LIST: eBay Bewertungen
                    '##############################
                    Case "lvwBewertungen"

                        '# eBay ID bestimmen 
                        streBay_ID = lvwData.Items(lngCount).SubItems(2).Text
                        Dim strTransaktion As String = lvwData.Items(lngCount).SubItems(7).Text
                        Dim strUser As String = lvwData.Items(lngCount).SubItems(0).Text
                        '# Update Nachricht 
                        Application.DoEvents()

                        frmMain.master_Message_label.Text = (lngCount + 1) & " / " & lvwData.Items.Count & My.Settings.yabe_trennzeichen & lvwData.Items(lngCount).Text & " - " & lvwData.Items(lngCount).SubItems(3).Text & My.Settings.yabe_trennzeichen & " Neue Bewertungen: " & iBewertungenNeu_Anzahl

                        '##############################
                        '# >> Aktuallisieren / Neu 
                        '##############################
                        lvwData.EndUpdate()
                        lvwData.Items(lngCount).Selected = True
                        lvwData.Items(lngCount).EnsureVisible()
                        If chkUpdate_Add(streBay_ID, "yabe_auction_feedback", "eBay_ID") = "ADD" Then

                            '# Artikel Updaten 
                            Call seteBayFeedBack2Article(streBay_ID)

                            strSQL = setInsert_Update_tLvw2SQL(lvwData.Items(lngCount), "lvwBewertungen", "ADD")
                            iBewertungenNeu_Anzahl += 1

                            If strSQL.Length > 0 Then
                                Application.DoEvents()
                                Dim dbConnect_con As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                                'dbConnect_con.Close()
                                dbConnect_con.Open()
                                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect_con)
                                command.ExecuteNonQuery()
                                dbConnect_con.Close()
                            End If

                            '# Automatisch bei eBay Bewerten
                            If frmMain.frmManage.chkeBayBewertung_automatischRE.Checked = True Then
                                If clseBayAPI.seteBayLeaveFeedback(streBay_ID, My.Settings.yabe_gui_bewerten_defaultText, strTransaktion, strUser) = True Then
                                    iBewertet += 1
                                Else
                                    iBewertet_nicht += 1
                                End If

                            End If

                            frmMain.master_Message_label.Text = "Aktuell bei: '" & strUser & "' | Bewertet:" & iBewertet & " / nicht: " & iBewertet_nicht

                            '                        ElseIf chkUpdate_Add(streBay_ID, "yabe_auction_feedback", "eBay_ID") = "UPDATE" Then

                            ' strSQL = setInsert_Update_tLvw2SQL(lvwData.Items(lngCount), "lvwBewertungen", "UPDATE")

                        End If



                End Select

                Application.DoEvents()

            Next lngCount

            'lvwData.EndUpdate()
            '    lvwData.Enabled = True

            '#################################
            '# >> Nachrichten nach Update 
            '#################################
            Select Case lvwData.Name


                Case "lvwEiSoCockpit"
                    'MsgBox(lvwData.Items.Count - 1 & " - Ebay-Artikel wurden aktuallisiert", MsgBoxStyle.Information)

                Case "lvwBewertungen"
                    MsgBox(lvwData.Items.Count & " - Ebay-Bewertungen wurden aktuallisiert" & vbCrLf & "Bewertet:" & iBewertet & " / nicht: " & iBewertet_nicht, MsgBoxStyle.Information)

            End Select

            Return True
        Catch ex As Exception
            lvwData.EndUpdate()
            Call debug_message(ex, strSQL & vbCrLf & "setListviewData_save")
            Return False
        End Try
    End Function

    '##################################################################
    '# >> Ist Datenbank geöffnet 
    '##################################################################
    Public Function setListViewTranslation(ByVal setListviewId As getlvwEbayLive) As Boolean
        Try
            getEbayList = setListviewId

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setListViewTranslation")
            Return False
        End Try
    End Function

    '###############################################
    '# >> Versendet Status setzen 
    '###############################################
    Public Function setUpdateIsSend(ByVal strEmail As String) As Boolean
        Dim strQuery As String = ""
        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_auction_list_live set isSend='true' WHERE email = '" & strEmail & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setUpdateIsSend")
            Return False
        End Try
    End Function

    '#########################################################
    '# >> Shopste Import Daten in EiSo Artikelverwaltung 
    '#########################################################
    Public Function setEiSoArtikelverwaltung_shopste_summary(ByVal strEiSoShop_id As String, ByVal strShopste_id As String, ByVal strShopste_lagerbestand As String) As Boolean
        Dim strQuery As String = ""
        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE tblGes SET shopste_id='" & strShopste_id & "',shopste_lagerbestand='" & strShopste_lagerbestand & "',shopste_eingestellt_am='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE ID = '" & strEiSoShop_id & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            ' Dim date_db As DateTime = DateTime.Now

            '   command.Parameters.AddWithValue("newdate", DateTime.Now)
            command.ExecuteNonQuery()
            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setEiSoArtikelverwaltung_shopste_summary")
            Return False
        End Try
    End Function

    '###############################################
    '# >> YABE Artikel Bewertet
    '###############################################
    Public Function setFeedbackBewerted(ByVal streBayID As String) As Boolean
        Dim strQuery As String = ""

        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_auction_feedback SET bIsFeedback ='Y' WHERE eBay_ID ='" & streBayID & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setFeedbackBewerted")
            Return False
        End Try

    End Function

    '###############################################
    '# >> Artikel gesendet...
    '###############################################
    Public Function seteMail_send(ByVal streBayID As String) As Boolean
        Dim strQuery As String = ""

        Try

            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_auction_list_live set isSend='true' WHERE eBay_ID='" & streBayID & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "seteMail_send")
            Return False
        End Try
    End Function

    '###############################################
    '# >> Löscht den Artikel
    '###############################################
    Public Function setDeleteReal(ByVal streBayID As String, Optional ByVal strTable As String = "yabe_auction_list_live") As Boolean
        Dim strQuery As String = ""

        Try

            dbConnect.Close()
            dbConnect.Open()
            strQuery = "DELETE FROM " & strTable & " WHERE eBay_ID ='" & streBayID & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setDeleteReal")
            Return False
        End Try

    End Function
    '###############################################
    '# >> Makriert Artikel als gelöscht...
    '###############################################
    Public Function setDeleted(ByVal streBayID As String, Optional ByVal strTable As String = "yabe_auction_list_live") As Boolean
        Dim strQuery As String = ""

        Try

            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE " & strTable & " SET isDeleted='true' WHERE eBay_ID = " & streBayID
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()


            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setDeleted")
            Return False
        End Try

    End Function
    '###################################################################
    '# >> Cockpit Bilder Speichern
    '# -> Wenn Bildname gesetzt ist, dann wurde eine lokale kopie angefertigt
    '# -> EiSo ID und Verkaufs-ID möglich
    '###################################################################
    Private Function setEiSoCockpitBildName(strBildName As String, ID As String, bIsEiSoID As Boolean) As Boolean
        Try

            Dim dbcon2 As New MySql.Data.MySqlClient.MySqlConnection
            dbcon2.ConnectionString = dbConnect.ConnectionString

            dbcon2.Close()
            dbcon2.Open()

            If bIsEiSoID = True Then
                strQuery = "UPDATE yabe_auction_list_live SET bildname='" & strBildName & "' WHERE YABE_ID = " & ID
            Else
                strQuery = "UPDATE yabe_auction_list_live SET bildname='" & strBildName & "' WHERE eBay_ID = " & ID
            End If

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbcon2)
            command.ExecuteNonQuery()

            dbcon2.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setEiSoCockpitBildName")
            Return False
        End Try
    End Function


    Private Function getEiSoVersandartByID(id As String) As String
        Try
            Dim str As String = ""
            Dim dbcon2 As New MySql.Data.MySqlClient.MySqlConnection
            dbcon2.ConnectionString = dbConnect.ConnectionString

            dbcon2.Close()
            dbcon2.Open()

            Dim strQuery As String = "SELECT * FROM yabe_order_shippment_method WHERE order_shippment_method_id='" & id & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbcon2)
            Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
            dbReader2 = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader2.HasRows = True Then

                '# Datenbank wechseln 
                '# --------------------
                While Not dbReader2.Read() = False
                    str = dbReader2("name_de")
                End While

            End If

            dbcon2.Close()

            Return str
        Catch ex As Exception
            debug_message(ex, "getEiSoVersandartByID")
            Return "-1"
        End Try
    End Function
    ''' <summary>
    ''' Konvertiert ein Image in einen Base64-codierten String
    ''' </summary>
    ''' <param name="oImage">Image-Objekt</param>
    ''' <returns>Base64-codierter String</returns>
    Public Function ImageToBase64(ByVal oImage As Image) As String
        If oImage IsNot Nothing Then
            With New System.Drawing.ImageConverter
                ' Image in Byte-Array umwandeln
                Dim nBytes() As Byte = CType(.ConvertTo(oImage, GetType(Byte())), Byte())

                ' Byte-Array in Base64-codierten String umwandeln
                Return (Convert.ToBase64String(nBytes,
        Base64FormattingOptions.InsertLineBreaks))
            End With
        Else
            ' Leerstring zurückgeben
            Return ("")
        End If
    End Function
    '###########################################################
    '# >> DATENVERARBEITUNG
    '###########################################################
    Private Function getListviewData(ByRef lvwdata As ListView, ByVal dbReader As MySql.Data.MySqlClient.MySqlDataReader, Optional ByVal nr As Integer = 0, Optional imgList As ImageList = Nothing) As Boolean

        Static iCount As Byte = 1
        Dim bIn As Boolean = False
        Dim lvw As New ListViewItem
        Dim bIsEiSoID As Boolean = True
        Dim strFilename() As String

        Try
            '# Modusunterscheidung 
            Select Case lvwdata.Name
                Case "lvwWebArtikel"
                    Dim lvwItem As New ListViewItem

                    Dim strBildName As String = ""
                    Dim strID() As String
                    Dim strBild As String = ""
                    Dim strBild_ary() As String

                    If My.Settings.lvw_eiso_shop_picture = True Then


                        If dbReader("bildname").ToString.Length > 0 Then
                            strBildName = dbReader("bildname").ToString
                            strID = dbReader("YABE_ID").ToString.Split("-")
                        Else

                            If dbReader("bild_url").ToString.Length > 0 Then
                                strBild = dbReader("bild_url").ToString
                                '# Externer Bild zum Download angegeben?
                                If Not strBild Is Nothing Then
                                    strFilename = strBild.Split("/")
                                    strBildName = strFilename(strFilename.Length - 1)
                                    strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                    strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                    strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))

                                Else
                                    strBildName = Nothing
                                End If
                                strID = dbReader("eBay_ID").ToString.Split("-")
                                bIsEiSoID = False
                            Else
                                '# Externer Bild zum Download angegeben?
                                strID = dbReader("YABE_ID").ToString.Split("-")

                                strBild = getEiSoBildbyEisoID(strID(0))
                                If Not strBild Is Nothing Then
                                    strFilename = strBild.Split("/")
                                    strBildName = strFilename(strFilename.Length - 1)
                                    strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                    strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                    strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))

                                Else
                                    strBildName = Nothing
                                End If
                            End If
                        End If
                    End If


                    lvw.Text = dbReader("ID").ToString

                    If Not strBildName Is Nothing And My.Settings.lvw_eiso_shop_picture = True Then
                        If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildName) = True Then
                            Try
                                imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                'MessageBox.Show(frmMain.frmManage.bilder_history.Images(0).Size.ToString)
                                lvw.ImageKey = strID(0)
                            Catch ex As Exception

                            End Try

                        Else
                            If strBild.Length > 0 Then
                                Try
                                    Application.DoEvents()
                                    If My.Settings.domain_id = 43 Then
                                        Try
                                            strBild_ary = strBild.Split("/")
                                            strBild = strBild.Replace(strBild_ary(strBild_ary.Length), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                            strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                            My.Computer.Network.DownloadFile(strBild.Replace("http://", "https://"), Application.StartupPath & "\bilderexport\" & strBildName)
                                        Catch ex As Exception
                                            frmMain.master_Message_label.Text = ex.Message
                                        End Try

                                    Else
                                        Try
                                            My.Computer.Network.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildName)
                                        Catch ex As Exception
                                            frmMain.master_Message_label.Text = ex.Message
                                        End Try

                                    End If


                                    ' Bildnamen speichern
                                    Call setBildName(strID(0), strBildName, bIsEiSoID)

                                    Try
                                        imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                        lvw.ImageKey = strID(0)
                                    Catch ex As Exception

                                    End Try

                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                End Try

                            End If

                        End If
                    End If

                    lvwItem.Text = dbReader("ID").ToString

                    If frmMain.frmManage.cmbSprache_Artikeldatenbank.Text.Contains("Deutsch") Then
                        lvwItem.SubItems.Add(dbReader("Beschreibung").ToString.Trim)
                    Else
                        Dim strISO As String = ""
                        strISO = clsDatenbank_modul.getTranslate_l18n_mapping(frmMain.frmManage.cmbSprache_Artikeldatenbank.Text)
                        lvwItem.SubItems.Add(dbReader("Beschreibung" & strISO).ToString.Trim)
                    End If

                    lvwItem.SubItems.Add(dbReader("Preis").ToString)
                    lvwItem.SubItems.Add(dbReader("Bild").ToString)
                    lvwItem.SubItems.Add(CMS2MagentoID(dbReader("Kategorie_neo").ToString))
                    lvwItem.SubItems.Add(dbReader("delcampe_id").ToString)
                    lvwItem.SubItems.Add(dbReader("Datum").ToString)
                    lvwItem.SubItems.Add(dbReader("Counter").ToString)

                    '# Bestellstatus auswählen 
                    Select Case dbReader("Bestellt").ToString
                        Case "1"
                            lvwItem.SubItems.Add("Bestellt")
                        Case "2"
                            lvwItem.SubItems.Add("Warteliste")
                        Case Else

                    End Select
                    lvwItem.SubItems.Add(strBildName)
                    lvwItem.SubItems.Add(dbReader("menge").ToString)
                    Application.DoEvents()

                    frmMain.master_Message_label.Text = dbReader("Beschreibung").ToString

                    lvwdata.Items.Add(lvwItem)

                Case "lvwEiSoCockpit"

                    '# eBay_ID
                    '# Beschreibung
                    '# Preis
                    '# Startpreis 
                    '# Gebote 
                    '# Mitgliedsname
                    '# eMail
                    '# Bild
                    '# Zeit

                    Dim strBildName As String = ""
                    Dim strID() As String
                    Dim strBild As String = ""
                    Dim strBild_ary() As String

                    If My.Settings.lvw_live_picture = True Then


                        If dbReader("bildname").ToString.Length > 0 Then
                            strBildName = dbReader("bildname").ToString
                            strID = dbReader("YABE_ID").ToString.Split("-")
                        Else


                            If dbReader("bild_url").ToString.Length > 0 Then
                                strBild = dbReader("bild_url").ToString
                                '# Externer Bild zum Download angegeben?
                                strID = dbReader("eBay_ID").ToString.Split("-")
                                If Not strBild Is Nothing Then
                                    strFilename = strBild.Split("/")
                                    strBildName = strFilename(strFilename.Length - 1)
                                    strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                    strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                    strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))
                                    bIsEiSoID = False
                                End If
                            Else
                                '# Externer Bild zum Download angegeben?
                                strID = dbReader("YABE_ID").ToString.Split("-")

                                strBild = getEiSoBildbyEisoID(strID(0))
                                If Not strBild Is Nothing Then
                                    strFilename = strBild.Split("/")
                                    strBildName = strFilename(strFilename.Length - 1)
                                    strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                    strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                    strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))

                                Else
                                    strBildName = Nothing
                                End If
                            End If
                        End If
                    End If


                    lvw.Text = dbReader("eBay_ID").ToString

                    If Not strBildName Is Nothing And My.Settings.lvw_live_picture = True Then
                        If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildName) = True Then
                            Try
                                imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                'MessageBox.Show(frmMain.frmManage.bilder_history.Images(0).Size.ToString)
                                lvw.ImageKey = strID(0)
                            Catch ex As Exception
                                frmMain.master_Message_label.Text = ex.Message
                            End Try
                        Else

                            strID = dbReader("YABE_ID").ToString.Split("-")
                            strBild = getEiSoBildbyEisoID(strID(0))

                            If strBild.Length > 0 Then

                                Application.DoEvents()
                                If My.Settings.domain_id = 43 Then
                                    strBild_ary = strBild.Split("/")
                                    strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                    strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                    Try
                                        My.Computer.Network.DownloadFile(strBild.Replace("http://", "https://"), Application.StartupPath & "\bilderexport\" & strBildName)
                                    Catch ex As Exception

                                    End Try

                                Else
                                    Try
                                        My.Computer.Network.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildName)
                                    Catch ex As Exception
                                        frmMain.master_Message_label.Text = ex.Message
                                    End Try

                                End If

                                setEiSoCockpitBildName(strBildName, strID(0), bIsEiSoID)
                                Try
                                    imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                    lvw.ImageKey = strID(0)


                                Catch ex As Exception
                                    frmMain.master_Message_label.Text = ex.Message
                                End Try

                            End If

                        End If
                    End If

                    lvw.Text = dbReader("eBay_ID").ToString
                    lvw.SubItems.Add(dbReader("auction_title").ToString)
                    lvw.SubItems.Add(dbReader("current_price").ToString)
                    lvw.SubItems.Add(dbReader("startprice").ToString)
                    lvw.SubItems.Add(dbReader("bids").ToString)
                    lvw.SubItems.Add(dbReader("eBay_account").ToString)
                    lvw.SubItems.Add(dbReader("eMail").ToString)
                    lvw.SubItems.Add(dbReader("iseBayEnded").ToString)
                    lvw.SubItems.Add(dbReader("ListType").ToString)
                    lvw.SubItems.Add(Convert.ToDateTime(dbReader("auction_end").ToString).AddHours(2))
                    lvw.SubItems.Add(dbReader("watchcount").ToString)
                    lvw.SubItems.Add(Convert.ToDateTime(dbReader("auction_begin").ToString).AddHours(2))
                    lvw.SubItems.Add(dbReader("shippment").ToString.Replace(".", ","))
                    lvw.SubItems.Add(dbReader("eBayBild").ToString)

                    If Not dbReader("lastupdate").ToString = "00.00.0000 00:00:00" Then
                        lvw.SubItems.Add(dbReader("lastupdate").ToString)
                    Else
                        lvw.SubItems.Add("")
                    End If

                    lvw.SubItems.Add(dbReader("hitcounter").ToString)
                    lvw.SubItems.Add(dbReader("questions").ToString)

                    lvw.SubItems.Add(dbReader("auction_type").ToString)
                    lvw.SubItems.Add(dbReader("paypal_sum").ToString)

                    lvw.SubItems.Add(dbReader("YABE_ID").ToString)
                    If bIn = False Then
                        If iCount = 1 Then
                            lvw.BackColor = Color.WhiteSmoke
                        Else
                            lvw.BackColor = My.Settings.gui_live_color
                            iCount = 0
                        End If
                        iCount += 1
                    End If

                    '# Kundendaten 
                    Try
                        lvw.SubItems.Add(dbReader("name").ToString)
                        lvw.SubItems.Add(dbReader("country").ToString)
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                    End Try

                    lvw.SubItems.Add(dbReader("isSend").ToString)
                    lvw.SubItems.Add(dbReader("menge").ToString)
                    lvw.SubItems.Add(strBildName)
                    Try
                        lvw.SubItems.Add(dbReader("city").ToString)
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try

                    Try
                        lvw.SubItems.Add(dbReader("eiso_orderlist_id").ToString)
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try

                    lvwdata.Items.Add(lvw)
                    Application.DoEvents()

                Case "lvwBewertungen"
                    '# Mitglied
                    '# Punkte
                    '# eBay_ID
                    '# Type
                    '# Kommentar
                    '# Role 
                    '# Zeit 
                    lvw.Text = dbReader("ebay_account").ToString
                    lvw.SubItems.Add(dbReader("points").ToString)
                    lvw.SubItems.Add(dbReader("eBay_ID").ToString)
                    lvw.SubItems.Add(dbReader("type").ToString)
                    lvw.SubItems.Add(dbReader("comment").ToString)
                    lvw.SubItems.Add(dbReader("rolle").ToString)
                    lvw.SubItems.Add(dbReader("feedback_time").ToString)
                    lvw.SubItems.Add("")
                    lvw.SubItems.Add(dbReader("auction_title").ToString)
                    lvw.SubItems.Add(dbReader("current_price").ToString)

                    lvw.SubItems.Add(dbReader("email").ToString)
                    lvw.SubItems.Add(dbReader("hitcounter").ToString())
                    lvw.SubItems.Add(dbReader("watchcount").ToString)
                    lvw.SubItems.Add(dbReader("status").ToString)

                    If bIn = False Then
                        If iCount = 1 Then
                            lvw.BackColor = Color.WhiteSmoke
                        Else
                            lvw.BackColor = My.Settings.gui_live_color
                            iCount = 0
                        End If
                        iCount += 1
                    End If


                    lvwdata.Items.Add(lvw)

                Case "lvwBestellverwaltung_nach_artikel", "lvwBestellungen_bestelliste_neu"

                    '# eBayID
                    '# name
                    '# PLZ + ort
                    '# beschreibung
                    '# eBay Preis
                    '# eBay Kosten
                    '# Versandkosten
                    '# Bewertung
                    '# Status
                    '# Verschickt

                    Dim strBildName As String = ""
                    Dim strID() As String
                    Dim strBild As String = ""
                    Dim strBild_ary() As String

                    If My.Settings.lvw_bestellung_picture = True Then



                        If dbReader("bildname").ToString.Length > 0 Then
                            strBildName = dbReader("bildname").ToString
                            strID = dbReader("YABE_ID").ToString.Split("-")
                            strBild = ""
                        Else


                            If dbReader("bild_url").ToString.Length > 0 Then
                                strBild = dbReader("bild_url").ToString
                                '# Externer Bild zum Download angegeben?
                                strID = dbReader("eBay_ID").ToString.Split("-")
                                If Not strBild Is Nothing Then
                                    strFilename = strBild.Split("/")
                                    strBildName = strFilename(strFilename.Length - 1)
                                    strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                    strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                    strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))

                                Else
                                    strBildName = Nothing
                                End If

                                bIsEiSoID = False
                            Else
                                '# Externer Bild zum Download angegeben?
                                strID = dbReader("YABE_ID").ToString.Split("-")
                                strBild = getEiSoBildbyEisoID(strID(0))
                                If Not strBild Is Nothing Then
                                    strFilename = strBild.Split("/")
                                    strBildName = strFilename(strFilename.Length - 1)
                                    strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                                    strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                                    strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))

                                Else
                                    strBildName = Nothing
                                End If
                            End If
                        End If
                    End If

                    lvw.Text = dbReader("eBay_ID").ToString

                    If Not strBildName Is Nothing And My.Settings.lvw_bestellung_picture = True Then
                        If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildName) = True Then
                            Try

                                'Dim sourceImage As Object = CType(Bitmap.FromStream(sr), Bitmap)

                                '                                imgList.Images.Add(strID(0), sourceImage)

                                'Dim mapimage As Bitmap = Nothing
                                'Dim original As Image

                                'Using fs = New FileStream(Application.StartupPath & "\bilderexport\" & strBildName, FileMode.Open)
                                '    original = Image.FromStream(fs)
                                '    mapimage = New Bitmap(original)
                                '    fs.Close()
                                '    original.Dispose()
                                'End Using


                                'Dim bytes() As Byte
                                'Dim MS As System.IO.MemoryStream
                                'Dim ImageInStringFormat As String
                                'Dim NewImage As System.Drawing.Image
                                'Dim imgOrg As System.Drawing.Image

                                ''Dim image1 As Bitmap = CType(Image.FromFile(Application.StartupPath & "\bilderexport\" & strBildName, True), Bitmap)

                                'bytes = Convert.FromBase64String(ImageToBase64(mapimage))

                                'MS = New System.IO.MemoryStream(bytes)
                                'NewImage = System.Drawing.Image.FromStream(MS)

                                'imgList.Images.Add(strID(0), Bitmap.FromStream(MS))


                                'MessageBox.Show(frmMain.frmManage.bilder_history.Images(0).Size.ToString)
                                imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                lvw.ImageKey = strID(0)

                            Catch ex As Exception
                                frmMain.master_Message_label.Text = ex.Message
                            End Try

                        Else

                            strID = dbReader("YABE_ID").ToString.Split("-")
                            strBild = getEiSoBildbyEisoID(strID(0))

                            If strBild.Length > 0 Then

                                Application.DoEvents()
                                If My.Settings.domain_id = 43 Then
                                    strBild_ary = strBild.Split("/")
                                    strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                    strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                    Try
                                        My.Computer.Network.DownloadFile(strBild.Replace("http://", "https://"), Application.StartupPath & "\bilderexport\" & strBildName)
                                    Catch ex As Exception
                                        frmMain.master_Message_label.Text = ex.Message
                                    End Try

                                Else
                                    Try
                                        My.Computer.Network.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildName)
                                    Catch ex As Exception
                                        frmMain.master_Message_label.Text = ex.Message
                                    End Try

                                End If

                                ' Bildnamen speichern
                                Call setBildName(strID(0), strBildName, bIsEiSoID)
                                Try
                                    imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                    lvw.ImageKey = strID(0)
                                Catch ex As Exception
                                    frmMain.master_Message_label.Text = ex.Message
                                End Try

                            End If

                        End If
                    End If



                    If frmMain.frmManage.chkBestellungenVerkauft.Checked = True Then
                        lvw.SubItems.Add(dbReader("name").ToString)
                        lvw.SubItems.Add(dbReader("eBay_account").ToString)
                        lvw.SubItems.Add(dbReader("zipcode").ToString & " " & dbReader("city").ToString)
                        lvw.SubItems.Add(dbReader("auction_title").ToString)
                        lvw.SubItems.Add(dbReader("current_price").ToString)
                        lvw.SubItems.Add(dbReader("shippment").ToString.Replace(".", ","))
                        lvw.SubItems.Add(dbReader("status").ToString)
                        lvw.SubItems.Add(dbReader("isBewertung").ToString)
                        lvw.SubItems.Add(dbReader("email").ToString)
                        If IsDate(dbReader("auction_end").ToString) = True Then
                            lvw.SubItems.Add(Convert.ToDateTime(dbReader("auction_end").ToString).AddHours(1))
                        Else
                            lvw.SubItems.Add(dbReader("auction_end").ToString)
                        End If


                        lvw.SubItems.Add(dbReader("bids").ToString)

                        lvw.SubItems.Add(dbReader("finalfee").ToString)
                        lvw.SubItems.Add(dbReader("auction_type").ToString)
                        '# Farbwechsel einbauen 
                        If bIn = False Then
                            If iCount = 1 Then
                                lvw.BackColor = Color.WhiteSmoke
                            Else
                                lvw.BackColor = My.Settings.gui_live_color
                                iCount = 0
                            End If
                            iCount += 1
                        End If
                        lvw.SubItems.Add(dbReader("eBayBild").ToString)
                        lvw.SubItems.Add(dbReader("YABE_ID").ToString)
                        lvw.SubItems.Add(dbReader("paypal_sum").ToString.Replace(".", ","))
                        lvw.SubItems.Add(dbReader("country").ToString.Replace(".", ","))
                        lvw.SubItems.Add(dbReader("delcampe_userid").ToString)
                        lvw.SubItems.Add(dbReader("sprache").ToString)
                        lvw.SubItems.Add(dbReader("street").ToString)
                        lvw.SubItems.Add(dbReader("sprach_liste").ToString)
                        lvw.SubItems.Add(strBildName)
                        lvw.SubItems.Add(dbReader("menge").ToString)
                        lvw.SubItems.Add(dbReader("eiso_orderlist_id").ToString)
                        ' lvw.SubItems.Add(dbReader("order_created_at").ToString)
                    Else
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add(dbReader("auction_title").ToString)
                        lvw.SubItems.Add(dbReader("current_price").ToString)
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add(dbReader("status").ToString)
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                        If IsDate(dbReader("auction_end").ToString) = True Then
                            lvw.SubItems.Add(Convert.ToDateTime(dbReader("auction_end").ToString).AddHours(1))
                        Else
                            lvw.SubItems.Add(dbReader("auction_end").ToString)
                        End If


                        lvw.SubItems.Add(dbReader("bids").ToString)

                        lvw.SubItems.Add(dbReader("finalfee").ToString)
                        lvw.SubItems.Add(dbReader("auction_type").ToString)
                        lvw.SubItems.Add(dbReader("eBayBild").ToString)
                        lvw.SubItems.Add(dbReader("YABE_ID").ToString)
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add("")
                        lvw.SubItems.Add(strBildName)
                        lvw.SubItems.Add(dbReader("menge").ToString)
                        lvw.SubItems.Add(dbReader("eiso_orderlist_id").ToString)
                        '  lvw.SubItems.Add(dbReader("order_created_at").ToString)
                    End If



                    lvwdata.Items.Add(lvw)

                    Try
                        dblGesamtsumme += Convert.ToDouble(lvwdata.Items((nr - 1)).SubItems(5).Text)
                    Catch ex As Exception
                        ' JB BUG???
                    End Try


                    frmMain.master_Message_label.Text = frmMain.frmManage.cmbPlattform_bestellungen.Text & " - Nr. " & (nr - 1) & " - " & lvwdata.Items(nr - 1).SubItems(1).Text & " = " & lvwdata.Items(nr - 1).SubItems(5).Text & " EUR | Summe: " & dblGesamtsumme & " EUR"

                Case "lvwKunden", "lvwBestellungen_kunden"
                    lvw.Text = dbReader("name").ToString
                    Try
                        '
                        'lvw.SubItems.Add(dbReader("profil_mitglied").ToString)
                        lvw.SubItems.Add(dbReader("website_account").ToString)
                    Catch ex As Exception
                        lvw.SubItems.Add(dbReader("eBay_account").ToString)
                    End Try

                    lvw.SubItems.Add(dbReader("email").ToString)
                    lvw.SubItems.Add(dbReader("street").ToString)
                    lvw.SubItems.Add(dbReader("city").ToString)
                    lvw.SubItems.Add(dbReader("zipcode").ToString)
                    lvw.SubItems.Add(dbReader("country").ToString)


                    '# Nur aktiv, wenn Kundendetails angefordert werden 
                    If bkundendetail = True And My.Settings.chkEiSoArtikelverwaltung_kunden_details = True Then
                        Dim strKaufAnzahl As String
                        Dim strKäufe As String
                        Try
                            Dim strKunde_summary() As String = clsDatenbank_modul.getEiSoBestellungen_kunde_sumary(dbReader("email").ToString)

                            strKaufAnzahl = strKunde_summary(1)  ' clsDatenbank_modul.getEiSoBestellungen_kunde_summe(dbReader("email").ToString)
                            strKäufe = strKunde_summary(0) 'clsDatenbank_modul.getEiSoBestellungen_kunde_anzahl_artikel(dbReader("email").ToString)
                        Catch ex As Exception

                        End Try

                        lvw.SubItems.Add(strKaufAnzahl)
                        lvw.SubItems.Add(strKäufe)

                        If IsNumeric(strKaufAnzahl) = True And IsNumeric(strKäufe) = True Then
                            frmMain.master_Message_label.Text = nr & " " & lvwdata.Items.Count & " | Kunde: " & dbReader("name").ToString & " | Umsatz: " & strKäufe & " € | Artikel ges.: " & strKaufAnzahl & " € |  Pro Artikel: " & Math.Round((Convert.ToDouble(strKaufAnzahl) / Convert.ToInt16(strKäufe)), 2) & " €"
                        Else
                            frmMain.master_Message_label.Text = nr & " " & lvwdata.Items.Count & " | Kunde: " & dbReader("name").ToString
                        End If

                    Else
                        lvw.SubItems.Add("--")
                        lvw.SubItems.Add("--")
                        'frmMain.master_Message_label.Text = "Kunde: " & dbReader("name").ToString & " aus " & dbReader("city").ToString
                        frmMain.master_Message_label.Text = nr & " " & lvwdata.Items.Count & " | Kunde: " & dbReader("name").ToString
                    End If


                    Application.DoEvents()

                    lvw.SubItems.Add(dbReader("getNewsletter").ToString) ' Newsletterempfänger 

                    lvw.SubItems.Add(dbReader("adress_lastupdate").ToString) 'letzte Änderung 
                    lvw.SubItems.Add(dbReader("Type").ToString) 'Plattform
                    lvw.SubItems.Add(dbReader("sprach_liste").ToString) 'Plattform
                    lvw.SubItems.Add(dbReader("sprache").ToString) 'Plattform
                    lvw.SubItems.Add(dbReader("ID").ToString)
                    Try
                        lvw.SubItems.Add(dbReader("orderID").ToString)
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try

                    Try
                        lvw.SubItems.Add(dbReader("order_created_at").ToString)
                    Catch ex As Exception

                    End Try

                    Try
                        lvw.SubItems.Add(getEiSoOrderStatus2Text(dbReader("order_status_history_id").ToString))
                    Catch ex As Exception

                    End Try

                    Try
                        lvw.SubItems.Add(dbReader("total_sum_amount").ToString)
                    Catch ex As Exception

                    End Try

                    Try
                        lvw.SubItems.Add(dbReader("shippment_amount").ToString)
                    Catch ex As Exception

                    End Try

                    Try

                        lvw.SubItems.Add(dbReader("total_rabatt").ToString & " (" & dbReader("total_rabatt_prozent").ToString & "%)")
                    Catch ex As Exception

                    End Try


                    Try

                        lvw.SubItems.Add(getEiSoVersandartByID(dbReader("order_shippment_method_id").ToString))
                    Catch ex As Exception

                    End Try

                    Try
                        lvw.SubItems.Add(getEiSoVersandartByID(dbReader("verschickt_am").ToString))
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try

                    Try
                        lvw.SubItems.Add(getEiSoVersandartByID(dbReader("bezahlt_am").ToString))
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try
                    Try
                        lvw.SubItems.Add(getEiSoVersandartByID(dbReader("storniert_am").ToString))
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try
                    Try
                        lvw.SubItems.Add(getEiSoVersandartByID(dbReader("bewertet_am").ToString))
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try
                    Try
                        lvw.SubItems.Add(getEiSoVersandartByID(dbReader("abschlossen_am").ToString))
                    Catch ex As Exception
                        lvw.SubItems.Add("")
                    End Try

                    If bIn = False Then
                        If iCount = 1 Then
                            lvw.BackColor = Color.WhiteSmoke
                        Else
                            lvw.BackColor = My.Settings.gui_live_color
                            iCount = 0
                        End If
                        iCount += 1
                    End If
                    lvwdata.Items.Add(lvw)



                Case "lvwBewertungen"

                    lvw.Text = dbReader("eBay_ID").ToString
                    lvw.SubItems.Add(dbReader("ebay_account").ToString)
                    lvw.SubItems.Add(dbReader("points").ToString)
                    lvw.SubItems.Add(dbReader("type").ToString)
                    lvw.SubItems.Add(dbReader("comment").ToString)
                    lvw.SubItems.Add(dbReader("rolle").ToString)
                    lvw.SubItems.Add(dbReader("feedback_time").ToString)
                    If bIn = False Then
                        If iCount = 1 Then
                            lvw.BackColor = Color.WhiteSmoke
                        Else
                            lvw.BackColor = My.Settings.gui_live_color
                            iCount = 0
                        End If
                        iCount += 1
                    End If
                    lvwdata.Items.Add(lvw)

                Case "lvwBestellverlauf"

                    Dim strBildName As String = ""
                    Dim strID() As String
                    Dim strBild As String
                    Dim strBild_ary() As String

                    If dbReader("YABE_ID").ToString.Length > 0 Then
                        strID = dbReader("YABE_ID").ToString.Split("-")
                        strBild = getEiSoBildbyEisoID(strID(0))
                        If Not strBild Is Nothing Then
                            strFilename = strBild.Split("/")
                            strBildName = strFilename(strFilename.Length - 1)
                            strBildName = strBildName.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                            strBildName = strBildName.Replace("<", "").Replace(">", "").Replace("|", "")
                            strBildName = strBildName.Substring(0, Math.Min(strBildName.Length, 240))
                        Else

                        End If
                    Else
                        strBildName = ""
                    End If


                    lvw.Text = dbReader("eBay_ID").ToString & " | " & strBildName

                    If Not strBild Is Nothing Then
                        If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildName) = True Then
                            Try
                                imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                'MessageBox.Show(frmMain.frmManage.bilder_history.Images(0).Size.ToString)
                                lvw.ImageKey = strID(0)
                            Catch ex As Exception

                            End Try

                        Else
                            If strBild.Length > 0 Then
                                Try
                                    Application.DoEvents()
                                    If My.Settings.domain_id = 43 Then
                                        strBild_ary = strBild.Split("/")
                                        strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                        strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                        Try
                                            My.Computer.Network.DownloadFile(strBild.Replace("http://", "https://"), Application.StartupPath & "\bilderexport\" & strBildName)
                                        Catch ex As Exception

                                        End Try

                                    Else
                                        Try
                                            My.Computer.Network.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildName)
                                        Catch ex As Exception

                                        End Try

                                    End If


                                    Try
                                        imgList.Images.Add(strID(0), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildName))
                                        lvw.ImageKey = strID(0)
                                    Catch ex As Exception

                                    End Try
                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                End Try

                            End If

                        End If
                    End If

                    lvw.Text = dbReader("eBay_ID").ToString
                    lvw.SubItems.Add(dbReader("auction_title").ToString)
                    lvw.SubItems.Add(dbReader("current_price").ToString.Replace(".", ","))
                    lvw.SubItems.Add(dbReader("bids").ToString)
                    lvw.SubItems.Add(dbReader("status").ToString)
                    If Not dbReader("auction_end").ToString = "00.00.0000 00:00:00" Then
                        lvw.SubItems.Add(Convert.ToDateTime(dbReader("auction_end").ToString).AddHours(1))
                    Else
                        lvw.SubItems.Add("---")
                    End If

                    lvw.SubItems.Add(dbReader("auction_type").ToString)

                    dblSumme += Convert.ToDouble(dbReader("current_price").ToString)
                    If bIn = False Then
                        If iCount = 1 Then
                            lvw.BackColor = Color.WhiteSmoke
                        Else
                            lvw.BackColor = My.Settings.gui_live_color
                            iCount = 0
                        End If
                        iCount += 1
                    End If

                    lvw.SubItems.Add(dbReader("shippment").ToString.Replace(".", ","))
                    lvw.SubItems.Add(dbReader("paypal_sum").ToString.Replace(".", ","))
                    lvw.SubItems.Add(dbReader("eBay_account").ToString)
                    lvw.SubItems.Add(dbReader("email").ToString)
                    lvw.SubItems.Add(strBildName)
                    lvw.SubItems.Add(dbReader("menge").ToString)
                    '  lvw.SubItems.Add(dbReader("order_created_at").ToString)
                    lvwdata.Items.Add(lvw)
                '########################################
                '# Statistikbereich
                '########################################
                Case "lvwStatisticText"

                    '# Herkunfsländer 
                    If frmMain.frmManage.optStatHerkunftsland.Checked = True Then
                        lvw.Text = dbReader("name").ToString
                        lvw.SubItems.Add(dbReader("anzahl").ToString)
                        '# Umsatz 
                    ElseIf frmMain.frmManage.optStatUmsatz.Checked = True Then
                        lvw.Text = dbReader("jahr").ToString & " - " & dbReader("name").ToString
                        lvw.SubItems.Add(dbReader("anzahl").ToString)
                        '# Topkunden
                    ElseIf frmMain.frmManage.optTopKundenListe.Checked = True Then
                        lvw.Text = dbReader("name").ToString & " - " & dbReader("eBay_account").ToString
                        lvw.SubItems.Add(dbReader("summe").ToString)
                        '# Meiste Gebote 
                    ElseIf frmMain.frmManage.optMeistegebote.Checked = True Then
                        lvw.Text = dbReader("auction_title").ToString & " | " & dbReader("eBay_account").ToString
                        lvw.SubItems.Add(dbReader("bids").ToString)
                        '# Teuerster Artikel 
                    ElseIf frmMain.frmManage.optTeuersterArtikel.Checked = True Then
                        lvw.Text = dbReader("auction_title").ToString & " | " & dbReader("eBay_account").ToString
                        lvw.SubItems.Add(dbReader("current_price").ToString)
                        '# Häufigste Städte 
                    ElseIf frmMain.frmManage.optMeisteStaedte.Checked = True Then
                        lvw.Text = dbReader("city").ToString
                        lvw.SubItems.Add(dbReader("anzahl").ToString)
                    End If

                    If bIn = False Then
                        If iCount = 1 Then
                            lvw.BackColor = Color.WhiteSmoke
                        Else
                            lvw.BackColor = My.Settings.gui_live_color
                            iCount = 0
                        End If
                        iCount += 1
                    End If
                    lvwdata.Items.Add(lvw)

                '########################################
                '# Mailstatus 
                '########################################
                Case "lvMailStatus"

                    Static Dim iPlus As Integer = 0
                    iPlus += 1

                    lvw.Text = iPlus

                    '# Name: 
                    If Not dbReader("name").ToString = Nothing Then
                        lvw.SubItems.Add(dbReader("name").ToString)
                    Else
                        lvw.SubItems.Add("---") ' name
                    End If

                    ' If InStr(dbReader("email").ToString, "vcvc.yamasaki@nifty.ne.jp") Then
                    'Stop
                    'End If

                    lvw.SubItems.Add(dbReader("email").ToString) ' email


                    If Not dbReader("city").ToString = Nothing Then
                        lvw.SubItems.Add(dbReader("city").ToString)
                    Else
                        lvw.SubItems.Add("---") ' ort
                    End If


                    lvw.SubItems.Add("---") ' preis  aller einkäufe                
                    lvw.SubItems.Add("---") ' Anzahl                  


                    If dbReader("letzte_mail").ToString = "Y" Then
                        lvw.SubItems.Add("Ja")
                    Else
                        lvw.SubItems.Add("Nein")
                    End If

                    lvw.SubItems.Add(dbReader("CRC").ToString) ' CRC
                    lvw.SubItems.Add(dbReader("eMail_click_count").ToString) ' email klicked
                    lvw.SubItems.Add(dbReader("letzter_email_klick").ToString) ' verschickt



                    'If dbReader("sprache").ToString = "" Then
                    lvw.SubItems.Add(getFunc_EmailAdress_Translation(dbReader("email").ToString))
                    'Else
                    '    lvw.SubItems.Add(dbReader("sprache").ToString)
                    'End If


                    lvw.SubItems.Add(dbReader("ID").ToString) ' personal_id

                    If dbReader("isWebUser").ToString = "Y" Then
                        lvw.SubItems.Add("Ja") ' webuser Y / N
                    Else
                        lvw.SubItems.Add("Nein") ' webuser Y / N
                    End If

                    If Not dbReader("country").ToString = Nothing Then
                        lvw.SubItems.Add(dbReader("country").ToString)
                    Else
                        lvw.SubItems.Add("---") ' ort
                    End If

                    If Not dbReader("website_account").ToString = Nothing Then
                        lvw.SubItems.Add(dbReader("website_account").ToString)
                    Else
                        lvw.SubItems.Add("---") ' ort
                    End If

                    If Not dbReader("website_pwd").ToString = Nothing Then
                        lvw.SubItems.Add(dbReader("website_pwd").ToString)
                    Else
                        lvw.SubItems.Add("---") ' ort
                    End If

                    If Not dbReader("sprache").ToString = Nothing Then
                        lvw.SubItems.Add(dbReader("sprache").ToString)
                    Else
                        lvw.SubItems.Add("Deutsch") ' ort
                    End If

                    If bIn = False Then
                        If iCount = 1 Then
                            lvw.BackColor = Color.WhiteSmoke
                        Else
                            lvw.BackColor = My.Settings.gui_live_color
                            iCount = 0
                        End If
                        iCount += 1
                    End If
                    lvwdata.Items.Add(lvw)


                    frmMain.master_Message_label.Text = pgr_global_aktiv.Value & " / " & pgr_global_aktiv.Maximum & " - " & dbReader("name").ToString & " " & dbReader("email").ToString



            End Select

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getListviewData")
            Return False
        End Try

        Return True
    End Function

    Public Function getEiSoOrderStatus2Text(id As String, Optional strSprache As String = "_de") As String
        Try
            Dim strData As String = ""

            strQuery = "SELECT * FROM yabe_order_status  WHERE order_status_id='" & id & "'"
            Dim dbconnect2 As New MySql.Data.MySqlClient.MySqlConnection(strConnection_master_template)
            'dbconnect2 = dbConnect
            If dbconnect2.State = ConnectionState.Closed Then
                dbconnect2.Open()
            End If

            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbconnect2)
            Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            '# Daten abrufen 
            If readVorlage1.HasRows = True Then
                Dim icount As Integer = 0
                Dim strName As String = ""

                While readVorlage1.Read() = True
                    ' ReDim strData(icount)(1)
                    strData = readVorlage1("name" & strSprache).ToString
                    icount += 1
                End While
            End If
            readVorlage1.Close()
            dbconnect2.Close()
            Return strData
        Catch ex As Exception
            Call debug_message(ex, "getEiSoOrderStatus2Text")
        End Try
    End Function
    '#####################################################
    '# >> Alle ISO Codes abrufen - für Template Parser 
    '#####################################################
    Public Function getEiSoBildbyEisoID(strEisoID As String) As String
        Dim strData As String = ""
        Try
            '  dbConnect.Close()
            '   dbConnect.Open()

            strQuery = "SELECT * FROM tblGes  WHERE ID='" & strEisoID & "'"
            Dim dbconnect2 As New MySql.Data.MySqlClient.MySqlConnection(strConnection_master_template)
            'dbconnect2 = dbConnect
            If dbconnect2.State = ConnectionState.Closed Then
                dbconnect2.Open()
            End If

            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbconnect2)
            Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            '# Daten abrufen 
            If readVorlage1.HasRows = True Then
                Dim icount As Integer = 0
                Dim strName As String = ""

                While readVorlage1.Read() = True
                    ' ReDim strData(icount)(1)
                    strData = readVorlage1("Bild").ToString
                    icount += 1
                End While
            End If
            readVorlage1.Close()
            dbconnect2.Close()
            Return strData

        Catch ex As Exception
            Call debug_message(ex, "getEiSoBildbyEisoID")
            Return Nothing
        End Try

    End Function
    '#####################################################
    '# >> Alle ISO Codes abrufen - für Template Parser 
    '#####################################################
    Public Function getSprache_ISO_Ary() As String(,)
        Dim strData(10, 1) As String
        Try
            dbConnect.Close()
            dbConnect.Open()

            strQuery = "SELECT * FROM yabe_tbl_email_vorlage_sprachen WHERE visible='Y'"
            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            '# Daten abrufen 
            If readVorlage1.HasRows = True Then
                Dim icount As Integer = 0
                Dim strName As String = ""

                While readVorlage1.Read() = True
                    ' ReDim strData(icount)(1)
                    strData(icount, 0) = readVorlage1("ISO").ToString
                    strData(icount, 1) = readVorlage1("Name").ToString
                    icount += 1
                End While
            End If

            Return strData

        Catch ex As Exception
            Call debug_message(ex, "getSprache_ISO_Ary")
            Return Nothing
        End Try

    End Function

    '####################################################################################
    '# >> Lädt die Bezeichnungsfelder
    '####################################################################################
    Public Function getBeschreibung_Fieldliste(ByVal strISO_ary As String(,)) As String
        Try
            Dim strField As String = ""
            Dim strKomma As String = ","
            Dim iCount As Integer = 0

            '# Alle Felder holen 
            For iCount = 0 To strISO_ary.GetUpperBound(0) - 1
                If Not strISO_ary(iCount, 0) = Nothing Then

                    '# Prüfen ob letztes Element 
                    If strISO_ary(iCount + 1, 0) = Nothing Then
                        strKomma = ""
                    End If

                    '# Deutsch ohne _de
                    If strISO_ary(iCount, 0) = "de" Then
                        strField &= "Beschreibung" & strKomma
                    Else
                        strField &= "Beschreibung_" & strISO_ary(iCount, 0) & strKomma
                    End If

                End If
            Next

            Return strField

        Catch ex As Exception
            Call debug_message(ex, "getBeschreibung_Fieldliste")
            Return "-1"
        End Try
    End Function
    '#####################################################################################
    '# >> Beschreibung Alle vorhandenen Sprachen Laden 
    '#####################################################################################
    Public Function getCMS_Beschreibung_all(ByVal strISO_ary As String(,), ByVal strID As String) As String(,)
        Dim strData(10, 1) As String
        Dim iCount As Integer = 0
        Dim strFieldListe As String = ""
        Dim strDataList() As String

        '# Verfügbare Felder laden
        strFieldListe = getBeschreibung_Fieldliste(strISO_ary)

        '# Abrufen der Felder
        strQuery = "SELECT " & strFieldListe & " FROM tblGes WHERE ID='" & strID & "';"

        dbConnect.Close()
        dbConnect.Open()

        Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

        '# Daten abrufen 
        If readVorlage1.HasRows = True Then
            readVorlage1.Read()

            '# Geladene Sprachen bestimmen
            strDataList = strFieldListe.Split(",")
            For iCount = 0 To strDataList.Length - 1

                If strDataList(iCount) = "Beschreibung" Then
                    strData(iCount, 0) = strDataList(iCount) & "_de"
                Else
                    strData(iCount, 0) = strDataList(iCount)
                End If

                strData(iCount, 1) = readVorlage1(strDataList(iCount)).ToString.Replace("\'", "'").Replace(">", " ").Replace("<", " ").Replace("(", " ").Replace(")", " ").Replace("[", " ").Replace("]", " ").Replace("Propaganda - Karte :", "WW II ").Replace("Propaganda - ", "WW II ").Replace("NS ", "").Replace("<br>", "").Replace("&#39;", "").Replace("'", "")

            Next

        End If

        dbConnect.Close()

        Return strData
    End Function

    Public Function getCustomer_sprache(ByVal strEmail As String) As String
        Try

            dbConnect.Close()
            dbConnect.Open()



            '# SQL 
            strQuery = "SELECT * FROM yabe_personals_profile WHERE email='" & strEmail & "';"

            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            '# Daten abrufen 
            If readVorlage1.HasRows = True Then
                readVorlage1.Read()
                Return readVorlage1("sprache").ToString
            Else
                Return "-1"
            End If


        Catch ex As Exception
            Call debug_message(ex, "getCustomer_sprache")
            Return "-1"
        End Try
    End Function


    '################################################################
    '# >> Text holen Sprache holen 
    '################################################################
    Public Function getArtikeldatenbank_Beschreibung_Export(ByVal strID As String, ByRef strSprache As email_sprache) As String
        Try
            Dim strQuery As String = ""
            Dim strText As String = ""
            Dim strField As String = ""


            dbConnect.Close()
            dbConnect.Open()

            '# Sprachauswahl 
            Select Case strSprache
                Case email_sprache.de
                    strField = "Beschreibung"
                Case Else
                    strField = "Beschreibung_" & strSprache.ToString

            End Select

            '# SQL 
            strQuery = "SELECT " & strField & " FROM tblGes WHERE ID='" & strID & "';"

            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            '# Daten abrufen 
            If readVorlage1.HasRows = True Then
                readVorlage1.Read()
                strText = readVorlage1(strField).ToString.Replace("\'", "'").Replace(">", " ").Replace("<", " ").Replace("(", " ").Replace(")", " ").Replace("[", " ").Replace("]", " ")
                strText = strText.Replace("Propaganda - Karte :", "WW II ")
                strText = strText.Replace("Propaganda - ", "WW II ")
                strText = Trim(strText.Replace("NS ", ""))
                strText = Trim(strText.Replace("<br>", ""))
                strText = Trim(strText.Replace("&#39;", ""))
                strText = Trim(strText.Replace("'", ""))
                dbConnect.Close()
            End If

            dbConnect.Close()


            Return strText
        Catch ex As Exception
            Call debug_message(ex, "getArtikeldatenbank_Beschreibung_Export")
            Return "Keine Spalte gefunden..."
        End Try
    End Function

    '#############################################################
    '# >> Vorlage zurücksezten 
    '#############################################################
    Public Function setArtikeldatenbank_Beschreibung_empty(ByVal strID As String, ByVal strSprach As email_sprache) As Boolean
        Dim strQuery As String = ""
        Dim strField As String = ""
        Try

            Select Case strSprach
                Case email_sprache.eng
                    strField = "Beschreibung_eng"
                Case email_sprache.fr
                    strField = "Beschreibung_fr"
                Case email_sprache.cn
                    strField = "Beschreibung_cn"
                Case email_sprache.ru
                    strField = "Beschreibung_ru"
                Case email_sprache.sp
                    strField = "Beschreibung_sp"
            End Select

            strQuery = "UPDATE tblGes SET " & strField & "='' WHERE ID='" & strID & "'"

            dbConnect.Close()
            dbConnect.Open()

            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            Return True
        Catch ex As Exception

            Call debug_message(ex, "setTextNew")
            Return False

        End Try
    End Function

    '########################################################
    '# >> TEXT Editor -> Ruft den Übersetzungstext ab 
    '########################################################
    Public Function getTranslationText(ByVal strName As String, Optional ByVal strField As String = "") As String

        Dim strQuery As String = ""
        Dim str As String = ""
        Try

            'Call setChangeDB(datenbankzugriff.YABE)


            '# Magic Selektor 
            If IsNumeric(strName) = True Then
                strQuery = "SELECT * FROM yabe_tbl_email_vorlage WHERE ID='" & strName & "'"
            Else
                strQuery = "SELECT * FROM yabe_tbl_email_vorlage WHERE Bereich='" & strName & "'"
            End If

            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            Dim readVorlage1 As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            If readVorlage1.HasRows = True Then
                readVorlage1.Read()
                If strField.Length = 0 Then
                    str = readVorlage1("Text").ToString.Replace("\'", "'")
                Else
                    str = readVorlage1(strField).ToString.Replace("\'", "'")
                End If

                dbConnect.Close()
                Return str
            End If

            dbConnect.Close()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getTranslationText")
            Return "-1"
        End Try

        Return "-1"

    End Function

    '########################################################
    '# >> Übersetzungstext speichern
    '########################################################
    Public Function setTranslationText(ByVal strVorlage As String, ByVal strText As String, ByVal strSprache As String) As Boolean
        Dim strQuery As String = ""
        Dim strFieldMapping As String = ""
        Try


            dbConnect.Close()
            dbConnect.Open()

            '# SQL Injektion 
            strText = strText.Replace("'", "\'")

            '# UTF8 -> darf öäüß anzeigen 
            strText = strText.Replace("&Ouml;", "Ö")
            strText = strText.Replace("&Auml;", "Ä")
            strText = strText.Replace("&Uuml;", "Ü")

            strText = strText.Replace("&ouml;", "ö")
            strText = strText.Replace("&auml;", "ä")
            strText = strText.Replace("&uuml;", "ü")
            strText = strText.Replace("&amp;", "&")
            strText = strText.Replace("&quot;", """")
            strText = strText.Replace("&lt;", "<")
            strText = strText.Replace("&gt;", ">")
            strText = strText.Replace("&nbsp;", " ")

            If strSprache.Length > 0 Then

                '# Feldmapping holen 
                strFieldMapping = clsDatenbank_modul.getTranslate_l18n_mapping(strSprache)
            End If

            strQuery = "UPDATE yabe_tbl_email_vorlage set Text" & strFieldMapping & "='" & strText & "' WHERE Bereich='" & strVorlage & "'"
            Dim cmd_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_update.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception

            Call debug_message(ex, strQuery & vbCrLf & "setTranslationText")
            Return False

        End Try
    End Function

    '################################################################
    '# >>  Neue eMail Übersetzung feststellen 
    '################################################################
    Public Function getFunc_EmailAdress_Translation(ByVal strEMail As String) As String
        Try

            If strEMail.IndexOf(".de") > 0 Then
                Return ".de"
            ElseIf strEMail.IndexOf("@aol.com") > 0 Then
                Return ".all"
            ElseIf strEMail.IndexOf(".com") > 0 Then
                Return ".com"
            Else
                Return ".all"
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEmailTranslation")
            Return "-1"
        End Try
    End Function

    '###############################################################
    '# >> Newsletter CRC generieren
    '###############################################################
    Public Function setNewsletter_CRC(Optional ByVal strModus As String = "missing") As Boolean
        Dim strQuery As String = ""
        Dim strQuery_count As String = ""
        Dim dbConnect_newsletter As New MySql.Data.MySqlClient.MySqlConnection
        Try

            dbConnect_newsletter.ConnectionString = dbConnect.ConnectionString
            dbConnect_newsletter.Open()

            '# Modus auswählen 
            If strModus = "missing" Then
                strQuery = "SELECT * FROM yabe_personals_profile WHERE CRC = '----'  OR CRC = ''  OR CRC is Null"
                strQuery_count = "SELECT count(*) as anzahl FROM yabe_personals_profile WHERE CRC = '----' OR CRC = '' OR CRC is Null"
            ElseIf strModus = "all" Then
                strQuery = "SELECT * FROM yabe_personals_profile "
                strQuery_count = "SELECT count(*) anzahl FROM yabe_personals_profile "
            End If

            '# Anzahl der Daten abrufen für Progressbar
            Dim cmd_anzahl As New MySql.Data.MySqlClient.MySqlCommand(strQuery_count, dbConnect_newsletter)
            Dim dbAnzahl As MySql.Data.MySqlClient.MySqlDataReader = cmd_anzahl.ExecuteReader()
            dbAnzahl.Read()

            frmMain.frmManage.pgrMailstatusGesammt.Visible = True
            frmMain.frmManage.pgrMailstatusGesammt.Style = ProgressBarStyle.Continuous
            Dim iMax As Integer = dbAnzahl("anzahl")
            frmMain.frmManage.pgrMailstatusGesammt.Maximum = iMax

            dbConnect_newsletter.Close()
            dbConnect_newsletter.Open()
            '# Daten abrufen 
            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect_newsletter)
            Dim chkUpdate As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()
            Dim iCount As Integer = 0
            If chkUpdate.HasRows = True Then

                While Not chkUpdate.Read() = False

                    setNewsletterCRC_update(chkUpdate("ID").ToString, getNewsletter_MD5(chkUpdate("ID").ToString))
                    iCount += 1
                    frmMain.frmManage.pgrMailstatusGesammt.Value = iCount
                    frmMain.master_Message_label.Text = iCount & " / " & iMax & " - " & chkUpdate("email").ToString
                    Application.DoEvents()
                End While

            End If

            frmMain.frmManage.pgrMailstatusGesammt.Visible = False

            dbConnect_newsletter.Close()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setNewsletterCRC")
        End Try
    End Function

    '###################################################################
    '# >> Newsletter MD5
    '###################################################################
    Public Function getNewsletter_MD5(ByVal strString As String) As String
        Try

            Return MD5StringHash(Date.Now & strString)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getNewsletterMD5")
            Return "-1"
        End Try
    End Function

    Public Function MD5StringHash(ByVal strString As String) As String
        Dim MD5 As New MD5CryptoServiceProvider
        Dim Data As Byte()
        Dim Result As Byte()
        Dim Res As String = ""
        Dim Tmp As String = ""

        Data = Encoding.ASCII.GetBytes(strString)
        Result = MD5.ComputeHash(Data)
        For i As Integer = 0 To Result.Length - 1
            Tmp = Hex(Result(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Res += Tmp
        Next
        Return Res
    End Function

    '###################################################################
    '# >> Newsletter CRC setzen 
    '###################################################################
    Public Function setNewsletterCRC_update(ByVal id As Integer, ByVal CRC As String) As Boolean
        Dim strQuery As String = ""
        Dim dbCon As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
        Try
            dbCon.Open()

            strQuery = "UPDATE yabe_personals_profile SET CRC='" & CRC & "' WHERE ID=" & id
            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbCon)
            cmd_insert_update.ExecuteNonQuery() ' UPDATE

            dbCon.Close()
            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setNewsletterCRC")
            Return False
        End Try
    End Function

    Public Function getNewsletterGalerie() As String
        Dim strQuery As String = ""
        Dim strReplace As String = ""
        Dim counter As Integer
        Dim strPfad As String
        Dim str() As String

        Try

            'Call setChangeDB(datenbankzugriff.CMS)

            strQuery = "select * from tblGes where Bestellt=0 order by rand() limit 9"
            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            Dim chkUpdate As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            If chkUpdate.HasRows = True Then

                strReplace = "" '# Leer machen

                '# Table Header für die Galerie
                strReplace = strReplace & "<br><br><br><table bgcolor=""#CCCCCC"" width=""85%"" align=""center"" border=""0"" cellspacing=""3"" style=""border-width:2px;border-color:#B9B9B9; border-style:solid;""><tr><td background=" & My.Settings.shop_url & "/images/balken_gray.jpg><font size=2 face=Arial, Helvetica, sans-serif><b>Eine Vorschau auf Philafriend's Online Philatelie Versandhandel</b></font></td></tr><tr><td bgcolor=""#EAF0F4"" ><table width=""100%""  border=""0""><tr>"
                counter = 0

                While Not chkUpdate.Read() = False

                    str = chkUpdate("Bild").ToString.Split("/")
                    strPfad = My.Settings.shop_url & "/eBay/TN_" & str(UBound(str))

                    counter = counter + 1
                    If counter < 3 Then
                        strReplace = strReplace & "<td><div align=""center""><table width=""100%""  border=""0""><tr><td bgcolor=""#000000""><a href=""###LINK2USER###"" title=""" & chkUpdate("Beschreibung").ToString & """><center><img src= " & strPfad & " border=0></center></a></td></tr><tr><td><center>" & chkUpdate("Preis").ToString & " Euro</center></td></tr></table></div></td>"
                        '# ==3
                    Else
                        counter = 0
                        strReplace = strReplace & "<td><div align=""center""><table width=""100%""  border=""0""><tr><td bgcolor=""#000000""><a href=""###LINK2USER###"" title=""" & chkUpdate("Beschreibung").ToString & """><center><img src= " & strPfad & " border=0></center></a></td></tr><tr><td><center>" & chkUpdate("Preis").ToString & "Euro</center></td></tr></table></div></td></tr><tr>"
                    End If

                End While


                strReplace = strReplace & "</tr></table></td></tr></table>"
            End If

            'Call setChangeDB(datenbankzugriff.YABE)

            '
            dbConnect.Close()

            Return strReplace

        Catch ex As Exception
            'Call setChangeDB(datenbankzugriff.YABE)
            Call debug_message(ex, strQuery & vbCrLf & "getNewsletterGalerie")
            Return "-1"
        End Try

    End Function
    '###############################################################
    '# >> eMail Verschickt 
    '###############################################################
    Public Function setNewslettereMailSended(ByVal strEMail As String) As Boolean
        Dim strQuery As String = ""
        Try

            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_personals_profile set letzte_mail='Y' WHERE email='" & strEMail & "'"
            Dim cmd_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_update.ExecuteNonQuery()

            dbConnect.Close()
            Return True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "seteMailSended")
            Return False
        End Try

    End Function

    '###########################################################################
    '# >> Bestellten Artikel als bewertet makieren 
    '###########################################################################    
    Public Function seteBayFeedBack2Article(ByVal eBay_ID As String) As Boolean
        Dim strQuery As String = ""
        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_auction_list_history set isBewertung='Y' WHERE eBay_ID='" & eBay_ID & "'"
            Dim cmd_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_update.ExecuteNonQuery()
            dbConnect.Close()
            Return True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "seteBayFeedBack2Article")
            Return False
        End Try

    End Function

    '###########################################################
    '# >> Alle eBay Artikel als bewertet setzen
    '###########################################################
    Public Function seteBayBewertungen_bewertet(ByVal lvwData As ListView, ByVal pgr As ProgressBar) As Boolean
        Try
            Dim iCount As Integer = 0
            Dim streBayID As String
            pgr.Value = 0
            pgr.Maximum = lvwData.Items.Count - 1
            pgr.Visible = True

            For iCount = 0 To lvwData.Items.Count - 1

                streBayID = lvwData.Items(iCount).SubItems(2).Text
                pgr.Value = iCount
                dbConnect.Close()
                dbConnect.Open()
                strQuery = "UPDATE yabe_auction_feedback set bIsFeedback='Y' WHERE eBay_ID='" & streBayID & "'"
                Dim cmd_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
                cmd_update.ExecuteNonQuery()
                dbConnect.Close()


                dbConnect.Close()
                dbConnect.Open()
                strQuery = "UPDATE yabe_auction_list_history set isBewertung='Y' WHERE eBay_ID='" & streBayID & "'"
                Dim cmd_update2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
                cmd_update2.ExecuteNonQuery()
                dbConnect.Close()
                pgr.Value = iCount
                Application.DoEvents()
                frmMain.master_Message_label.Text = "Bei '" & iCount & "' von " & lvwData.Items.Count - 1
            Next

            pgr.Visible = False
            Return True
        Catch ex As Exception
            pgr.Visible = False
            Call debug_message(ex, strQuery & vbCrLf & "seteBayBewertungen_bewertet")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> set eBay Stats
    '###########################################################
    Public Function seteBayStats(ByVal iPositive As Integer, ByVal iNeutral As Integer, ByVal iNegative As Integer, ByVal eBayID As String) As Boolean
        Dim strInsert As String = ""
        Dim strQuery As String = ""
        Try


            '# UPDATE / INSERT 
            strQuery = "SELECT count(*) as anzahl FROM yabe_stats WHERE eBayID='" & eBayID & "'"
            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            'dbConnect.ChangeDatabase("db_u10097_01")
            Dim chkUpdate As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

            If chkUpdate.HasRows = True Then
                chkUpdate.Read()

                If chkUpdate("anzahl").ToString = "0" Then
                    '# INSERT 
                    strInsert = "INSERT INTO yabe_stats(positive,neutral,negative,eBayID) "
                    strInsert &= "Values( "
                    strInsert &= iPositive & ","
                    strInsert &= iNeutral & ","
                    strInsert &= iNegative & ","
                    strInsert &= "'" & eBayID & "'"
                    strInsert &= ")"
                Else
                    '# UPDATE 
                    strInsert = "UPDATE yabe_stats set positive = " & iPositive & ","
                    strInsert &= "neutral = " & iNeutral & ","
                    strInsert &= "negative = " & iNegative
                    strInsert &= " WHERE eBayID ='" & eBayID & "'"
                End If

            End If

            dbConnect.Close()
            dbConnect.Open()
            'dbConnect.ChangeDatabase("db_u10097_01")
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strInsert, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()

            'Call setChangeDB(datenbankzugriff.YABE)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "seteBayStats")
            Return False
        End Try

        Return True
    End Function

    '###########################################################
    '# >> Galerie bauen
    '###########################################################
    Public Function setWebHTMLGalerie(ByVal lbl As Label, Optional ByVal bGeboteOnly As Boolean = False) As Boolean
        Dim strQuery As String = ""
        Dim strQuery2 As String = ""
        Dim strInsert As String = ""
        Dim str() As String
        Dim strData As String = ""
        Dim frmStatusWindow As New frmWait4Something
        Dim strDatum() As String
        Dim strEnde As String = ""
        Dim strActive As String = "1"
        Dim strGeboteOnly As String
        Try

            If bGeboteOnly = True Then
                strGeboteOnly = " AND bids > 0"
            Else
                strGeboteOnly = ""
            End If

            '# ANZAHL zählen 
            Dim con_anzahl As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con_anzahl.Open()
            strQuery = "SELECT count(*) as anzahl FROM yabe_auction_list_live WHERE isGallery='N' " & strGeboteOnly
            Dim command_anzahl As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_anzahl)
            Dim dbReader_anzahl As MySql.Data.MySqlClient.MySqlDataReader = command_anzahl.ExecuteReader()

            If dbReader_anzahl.HasRows = True Then

                dbReader_anzahl.Read()
                '# Keinen geunfden
                If dbReader_anzahl("anzahl").ToString = "0" Then
                    Return False
                    Exit Function
                End If

                '# WAIT - Interval
                frmStatusWindow.iInervalMax = dbReader_anzahl("anzahl").ToString
                frmStatusWindow.bModus = frmWait4Something.modus.artikel
                frmStatusWindow.strTitle = ""
                frmStatusWindow.strMessage = "eBay Artikel ###now### von ###max###"
                frmStatusWindow.strTitle = "YABE - Wartepause... eBay HTML Galerie"
                frmStatusWindow.itmrInterval = 100

                '# Artikel welche noch nicht in der Galerie sind 
                Dim con_anzahl2 As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                con_anzahl2.Open()
                strQuery = "SELECT * FROM yabe_auction_list_live WHERE isGallery='N' " & strGeboteOnly & " ORDER BY auction_begin ASC"
                Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_anzahl2)

                dbReader = command.ExecuteReader()

                '# Gibt es einen Treffer
                If dbReader.HasRows = True Then

                    '# WAIT - Show
                    frmStatusWindow.Show(frmMain)
                    Dim icount As Integer = 0
                    While Not dbReader.Read() = False
                        icount += 1

                        Try


                            Application.DoEvents()
                            frmStatusWindow.iIntervalNow = icount



                            '# HTML Galerie Umsetzung 
                            '#---------------------------
                            '# eBay_ID = eBayID
                            '# current_price = aktuellerPreis
                            '# startprice = Preis
                            '# bids = Gebote
                            '# auction_title  = eBayBeschreibung
                            '# eBayBildURL = eBayBildURL

                            strData = dbReader("eBayBild").ToString
                            If Not strData = "-1" And strData.Length > 0 Then
                                str = strData.Split("/")
                                'strData = strData.Replace(str(str.Length - 1), "TN_" & str(str.Length - 1))
                                strData = strData.Replace("philafriend/", "")
                                strData = strData.Replace("Philafriend2/", "")
                                strData = strData.Replace("philafriend4/", "")
                                strData = strData.Replace("philafriend_3/", "")
                                strData = strData.Replace("philafriend_de/", "")
                                strData = strData.Replace("philafriend1/", "")
                            End If

                            '# UPDATE / INSERT                         
                            Dim con_insert_update As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                            con_insert_update.Open()
                            'con_insert_update.ChangeDatabase("db_u10097_01")

                            strQuery2 = "SELECT count(*) as anzahl FROM yabe_cubss_galerie WHERE eBayID='" & dbReader("eBay_ID").ToString & "'"
                            Dim cmd_insert_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery2, con_insert_update)

                            Dim chkUpdate As MySql.Data.MySqlClient.MySqlDataReader = cmd_insert_update.ExecuteReader()

                            If chkUpdate.HasRows = True Then
                                chkUpdate.Read()
                                '# UPDATE 
                                str = dbReader("auction_end").ToString.Split(" ")
                                strDatum = str(0).Split(".")
                                strEnde = strDatum(2) & "-" & strDatum(1) & "-" & strDatum(0)

                                '# INSERT 
                                If chkUpdate("anzahl").ToString = "0" Then

                                    '# eBay ausgelaufen + Gebote 
                                    '# >> Thumbnail löschen
                                    '# >> aus Datenbank löschen
                                    If dbReader("iseBayEnded").ToString = "Completed" And Convert.ToInt16(dbReader("bids").ToString) > 0 Then

                                        '# Nur wenn eigene Bilder verwendet werden
                                        If My.Settings.bUse_ownPictures = True Then
                                            '# Löschen vom Thumbnail 
                                            Call frmMain.frmManage.setDeletePictures(dbReader("eBayBild").ToString, False)
                                        End If

                                        '# Löschen vom Artikel aus DB 
                                        Call clsDatenbank_modul.getCMS_items_delete("DELETE FROM yabe_cubss_galerie WHERE eBayID=" & dbReader("eBay_ID").ToString)
                                    Else
                                        '# eBay Artikel beendet 
                                        If dbReader("iseBayEnded").ToString = "Completed" Then
                                            strActive = "2"

                                        Else
                                            strActive = "1"
                                            '# INSERT 
                                            strInsert = "INSERT INTO yabe_cubss_galerie(eBayID,aktuellerPreis,Preis, Gebote,eBayBeschreibung,eBayBildURL,Endatum,EndUhrzeit,ActiveOrder) "
                                            strInsert &= "Values( "
                                            strInsert &= "'" & dbReader("eBay_ID").ToString & "',"
                                            strInsert &= "'" & dbReader("current_price").ToString & "',"
                                            strInsert &= "'" & dbReader("startprice").ToString & "',"
                                            strInsert &= "'" & dbReader("bids").ToString & "',"
                                            strInsert &= "'" & dbReader("auction_title").ToString & "',"
                                            strInsert &= "'" & dbReader("eBayBild").ToString() & "',"
                                            strInsert &= "'" & strEnde & "',"
                                            strInsert &= "'" & str(1) & "',"
                                            strInsert &= "'" & strActive & "'"
                                            strInsert &= ")"

                                            '# Generiere Thumbnails

                                            '# Nur wenn eigene Bilder verwendet werden
                                            If My.Settings.bUse_ownPictures = True Then
                                                If getHTTPResponseMessage(My.Settings.shop_url + "/yabe_thumbs.php?picture=" + dbReader("eBayBild").ToString().Replace("""", ""), mgetUpdaterMessage.getShopThumbnail, False) = True Then
                                                    frmMain.master_Message_label.Text = "Erzeuge Thumbnail " + dbReader("eBayBild").ToString
                                                End If
                                            End If

                                            Dim con_insert_update2 As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                                            con_insert_update2.Open()
                                            'con_insert_update2.ChangeDatabase("db_u10097_01")

                                            Dim cmd_galerie_insert As New MySql.Data.MySqlClient.MySqlCommand(strInsert, con_insert_update2)
                                            cmd_galerie_insert.ExecuteNonQuery()
                                            con_insert_update2.Close()
                                            con_insert_update.Close()

                                        End If


                                    End If



                                    '# UPDATE 
                                ElseIf chkUpdate("anzahl").ToString = "1" Then


                                    '# eBay ausgelaufen + Gebote 
                                    '# >> Thumbnail löschen
                                    '# >> aus Datenbank löschen
                                    If dbReader("iseBayEnded").ToString = "Completed" And Convert.ToInt16(dbReader("bids").ToString) > 0 Then

                                        '# Nur wenn eigene Bilder verwendet werden
                                        If My.Settings.bUse_ownPictures = True Then
                                            '# Löschen vom Thumbnail 
                                            Call frmMain.frmManage.setDeletePictures(dbReader("eBayBild").ToString, False)
                                        End If

                                        '# Löschen vom Artikel aus DB 
                                        Call clsDatenbank_modul.getCMS_items_delete("DELETE FROM yabe_cubss_galerie WHERE eBayID=" & dbReader("eBay_ID").ToString)
                                    Else

                                        If dbReader("iseBayEnded").ToString = "Completed" Then
                                            strActive = "2"
                                            '# Löschen vom Artikel aus DB 
                                            Call clsDatenbank_modul.getCMS_items_delete("DELETE FROM yabe_cubss_galerie WHERE eBayID=" & dbReader("eBay_ID").ToString)

                                        Else
                                            strActive = "1"
                                            strInsert = "UPDATE `yabe_cubss_galerie` SET "
                                            strInsert &= "`aktuellerPreis`='" & dbReader("current_price").ToString & "', "
                                            strInsert &= "`Gebote`='" & dbReader("bids").ToString & "', "
                                            strInsert &= "`eBayBildURL`='" & dbReader("eBayBild").ToString & "', "
                                            strInsert &= "`Endatum`='" & strEnde & "', "
                                            strInsert &= "`EndUhrzeit`='" & str(1) & "', "
                                            strInsert &= "`ActiveOrder`='" & strActive & "', "
                                            strInsert &= "`eBayBeschreibung`='" & dbReader("auction_title").ToString & "' "
                                            strInsert &= "WHERE `eBayID`='" & dbReader("eBay_ID").ToString & "'"

                                            Dim con_insert_update2 As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                                            con_insert_update2.Open()
                                            'con_insert_update2.ChangeDatabase("db_u10097_01")

                                            Dim cmd_galerie_insert As New MySql.Data.MySqlClient.MySqlCommand(strInsert, con_insert_update2)
                                            cmd_galerie_insert.ExecuteNonQuery()
                                            con_insert_update2.Close()
                                            con_insert_update.Close()
                                        End If


                                    End If


                                Else
                                    MsgBox("Fehler mehrfach vorhanden?", MsgBoxStyle.Question)
                                End If


                            Else

                                '# FEHLER KEIEN DATEN 
                                MsgBox("Es gibt keine Daten...", MsgBoxStyle.Critical)

                            End If ' hat zeilen dbReader 


                        Catch ex As Exception
                            Call debug_message(ex, strQuery & vbCrLf & "setWebHTMLGalerie:" & strInsert)
                            frmStatusWindow.Dispose()
                        End Try

                    End While
                    con_anzahl2.Close()
                End If


            End If

            frmStatusWindow.Dispose() ' entladen des Fensters 
            Return True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setWebHTMLGalerie: <br> SQL:" & strQuery & "|<br> SQL:" & strInsert)
            Return False
        End Try
    End Function

    '################################################################################################
    '# >> getLanuage2GoogleCode
    '################################################################################################
    Public Function getLanuage2GoogleCode(ByVal strSprache As String) As String
        Try
            strQuery = "SELECT * From yabe_tbl_email_vorlage_sprachen WHERE Name= '" & strSprache & "'"

            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader
            dbReader.Read()

            If dbReader.HasRows = True Then
                Return dbReader("google_code").ToString
            End If

            Return True
        Catch ex As Exception
            Return "-1"
        End Try
    End Function

    '################################################################################################
    '# >> Ruft einen einzelnen Artikel AB (1 Feld) z.B. Translate 
    '################################################################################################
    Public Function getCMS_ShopItems(ByVal strField As String, ByVal strValue As String) As String
        Try
            Dim strData As String = ""
            strQuery = "SELECT * From tblGes WHERE ID= '" & strValue & "'"
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader
            dbReader.Read()
            If dbReader.HasRows = True Then

                strData = dbReader(strField).ToString

                dbConnect.Close()
                Return strData

            End If
            Return True
        Catch ex As Exception
            Call debug_message(ex, "getCMS_ShopItems")
            Return False
        End Try
    End Function
    Public Function setCMS_NewMenue_parrent(ByVal iMenue_id As Integer) As Integer

        strQuery = "SELECT * FROM tbl_menue WHERE ID='" & iMenue_id & "'"
        Dim iParrent As Integer = -1
        Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        dbConnect.Close()
        dbConnect.Open()
        dbReader = command_count.ExecuteReader

        If dbReader.HasRows = True Then

            While Not dbReader.Read() = False
                iParrent = dbReader("Parent").ToString
                dbConnect.Close()
                Return iParrent
            End While
        End If
    End Function
    '###########################################################
    '# >> Kategorien Speichern
    '###########################################################
    Public Function setCMS_NewMenue_Sub(ByVal strName As String, ByVal iMenue_id As Integer, Optional ByVal iMagento_id As Integer = -1) As Integer

        Try
            Dim strDatum As String = Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
            Dim iMenue_inserted_id As Integer = -1
            strQuery = "INSERT INTO `tbl_menue` (`Bezeichnung`, `Parent`,`Datum`,`Zugriffe`"

            If iMagento_id >= 0 Then
                strQuery &= ",`export_magento`"
            End If

            strQuery &= ") "
            strQuery &= "Values( "
            strQuery &= "'" & strName & "'," ' Name
            strQuery &= "'" & iMenue_id & "'," ' Parent
            strQuery &= "'" & strDatum & "'," ' Child3
            strQuery &= 0
            If iMagento_id >= 0 Then
                strQuery &= ",'" & iMagento_id & "'"
            End If
            strQuery &= " )"


            dbConnect.Close()
            dbConnect.Open()
            Dim command_kill As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command_kill.ExecuteNonQuery()
            iMenue_inserted_id = command_kill.LastInsertedId()
            dbConnect.Close()

            Return iMenue_inserted_id
        Catch ex As Exception
            Call debug_message(ex, "setCMS_NewMenue")
            Return -1
        End Try
    End Function

    '###########################################################
    '# >> Kategorien Einlesen
    '###########################################################
    Public Function getCMS_Menue(ByRef cms_menue As TreeView) As Boolean
        Try
            Dim iParent As Integer = 1
            Dim strBeschreibung() As String
            Dim strRootName As String = ""

            Dim iCount As Integer = 0
            Dim tvwNode As New TreeNode

            strQuery = "SELECT * FROM tbl_menue ORDER BY Parent ASC"
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader

            ReDim strBeschreibung(0)

            If dbReader.HasRows = True Then

                While Not dbReader.Read() = False

                    'dbReader("Beschreibung").ToString()

                    If iParent = dbReader("Parent").ToString() Then



                        '# Hauptkategorie bestimmen 
                        If iCount = 0 Then
                            strRootName = dbReader("Bezeichnung").ToString()
                            iCount += 1
                        Else
                            '# Unterkategorien bestimmen 
                            strBeschreibung(iCount - 1) = dbReader("Bezeichnung").ToString()
                            ReDim Preserve strBeschreibung(UBound(strBeschreibung) + 1)
                            iCount += 1
                        End If



                    Else

                        tvwNode = cms_menue.Nodes.Add(strRootName)
                        Dim i As Integer = 0

                        For i = 0 To strBeschreibung.Length - 1
                            tvwNode.Nodes.Add(iParent).Text = strBeschreibung(i)
                        Next


                        cms_menue.Nodes.Add(tvwNode)
                        ReDim strBeschreibung(0)
                        iCount = 0
                        'tvwNode.Nodes.Clear()
                        iParent = dbReader("Parent").ToString()

                    End If

                End While



            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "getCMS_Menue")
            Return False
        End Try
    End Function

    '#############################################
    '# >> Höchste Parrent ID bestimmen
    '#############################################
    Function getCMSMenue_highestChild2(ByVal iParrent As Integer) As Integer
        Try
            Dim iRes As Integer = 0
            strQuery = "SELECT max(`Child`) as Child FROM tbl_menue WHERE `Parent` =" & iParrent & " ORDER BY Parent"
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader

            If dbReader.HasRows = True Then
                dbReader.Read()
                iRes = dbReader("Child")
                dbConnect.Clone()
                Return iRes

            End If

        Catch ex As Exception

        End Try
    End Function

    '#############################################
    '# >> Höchste Parrent ID bestimmen
    '#############################################
    Function getCMSMenue_highestParent() As Integer
        Try
            Dim iRes As Integer = 0
            strQuery = "SELECT * FROM tbl_menue ORDER BY Parent DESC LIMIT 0,1"
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader

            If dbReader.HasRows = True Then
                dbReader.Read()
                iRes = dbReader("Parent")
                dbConnect.Clone()
                Return iRes

            End If

        Catch ex As Exception

        End Try
    End Function

    Function setCMS_menueItem_save(ByVal id As Integer, ByVal strZielsprache As String, ByVal strChange As String) As Boolean

        Try
            strQuery = "UPDATE `tbl_menue` SET Bezeichnung" & strZielsprache & "='" & strChange & "' WHERE ID=" & id

            dbConnect.Close()
            dbConnect.Open()
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_personal.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Call debug_message(ex, "setCMS_menueItem_save")
            Return False
        End Try

    End Function
    '###################################################
    '# >> Menüeintrag holen
    '###################################################
    Function getCMS_menuItem(ByVal id As Integer, ByVal strZielSprache As String) As String()
        Dim str(2) As String

        strQuery = "SELECT * FROM tbl_menue WHERE ID = " & id
        Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        dbConnect.Close()
        dbConnect.Open()
        dbReader = command_count.ExecuteReader

        If dbReader.HasRows = True Then
            dbReader.Read()
            str(0) = dbReader("Bezeichnung").ToString
            str(1) = dbReader("Bezeichnung" & strZielSprache).ToString
            dbConnect.Clone()
        End If

        Return str
    End Function

    '#############################################
    '# >> Parrent ID bestimmen durch ID bestimmen 
    '#############################################
    Function getCMSParent(ByVal id As Integer) As Integer
        Dim iRes As Integer = 0
        Try
            strQuery = "SELECT * FROM tbl_menue WHERE ID = " & id
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader

            If dbReader.HasRows = True Then
                dbReader.Read()
                iRes = dbReader("Parent")
                dbConnect.Clone()
                Return iRes

            End If

        Catch ex As Exception
            Call debug_message(ex, "getCMSParent")
            Return -1
        End Try
    End Function

    '#############################################
    '# >> Höchste Child ID bestimmen
    '#############################################
    Function getCMSMenue_highestChild(ByVal iParrent As Integer) As Integer
        Try
            Dim iRes As Integer = 0
            strQuery = "SELECT * FROM tbl_menue WHERE Parent = " & iParrent & " ORDER BY Child DESC LIMIT 0,1"
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader

            If dbReader.HasRows = True Then
                dbReader.Read()
                iRes = dbReader("Parent")
                dbConnect.Clone()
                Return iRes

            End If

        Catch ex As Exception
            Call debug_message(ex, "getCMSMenue_highestChild")
            Return -1
        End Try
    End Function

    '#######################################################################
    '# >> Vorlagen ID ermitteln 
    '#######################################################################
    Public Function getVorlagen_id(ByVal strName As String) As Integer
        Try

            Dim iID As Integer = 0

            strQuery = "SELECT * FROM yabe_tbl_email_vorlage WHERE Bereich ='" & strName & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then
                '# Lesen aus der Datenbank                 
                While Not dbReader.Read() = False
                    iID = dbReader("ID")
                End While
            End If

            Return iID
        Catch ex As Exception
            Call debug_message(ex, "getVorlagen_id")
            Return -1
        End Try
    End Function

    '#######################################################################
    '# >> Vorlagen laden 
    '#######################################################################
    Public Function getVorlagen_groupby(ByVal strGroup As String) As String()
        Try
            Dim str() As String
            ReDim str(0)
            strQuery = "SELECT * FROM yabe_tbl_email_vorlage WHERE yabe_function ='" & strGroup & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '# Lesen aus der Datenbank 
                Dim iCount As Integer = 0
                While Not dbReader.Read() = False
                    str(iCount) = dbReader("Bereich")
                    ReDim Preserve str(str.Length)
                    iCount += 1
                End While
            End If

            Return str
        Catch ex As Exception
            Call debug_message(ex, "getCMSMenue_highestChild")

        End Try
    End Function

    '###########################################################
    '# >> Alle alten Daten in die History übernehmen 
    '###########################################################
    Public Function setBestellungen_insert_alt() As String
        Dim strSQL As String = ""
        Dim strQuery As String = ""
        Dim frmStatusWindow As New frmWait4Something
        Try

            '# ---------------------------------
            '# >> Anzahl berechnen
            '# ---------------------------------
            strQuery = "SELECT count(*) as anzahl FROM yabe_auction_list_live WHERE isEbayEnded = 'Completed' AND eBay_account = '' OR isSend ='true'"
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader
            dbReader.Read()
            If dbReader.HasRows = True Then

                If dbReader("anzahl").ToString = "0" Then
                    ' MsgBox("Es gibt keine Daten zum aktuallisieren!", MsgBoxStyle.Information, "EiSo Bestellungen übernehmen / synchronisierern")
                    Return "-1"
                    Exit Function
                End If

                frmStatusWindow.iInervalMax = dbReader("anzahl").ToString
                frmStatusWindow.bModus = frmWait4Something.modus.artikel
                frmStatusWindow.strMessage = "EiSo Cockpit Artikel ###now### von ###max###"
                frmStatusWindow.strTitle = "EiSo - Bestellungen Synchronisieren"
                frmStatusWindow.itmrInterval = 100

            End If

            '# ---------------------------------
            '# >> BEENDET und KEIN GEBOTE
            '# ---------------------------------
            strQuery = "SELECT * FROM yabe_auction_list_live WHERE isEbayEnded = 'Completed' AND eBay_account = '' OR isSend ='true'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                frmStatusWindow.Show(frmMain.frmManage)

                '# Lesen aus der Datenbank 
                While Not dbReader.Read() = False

                    Application.DoEvents()
                    '# WAIT - Interval erhöhen
                    frmStatusWindow.iIntervalNow += 1
                    If frmStatusWindow.bStopMode = True Then
                        Return False
                        Exit Function
                    End If

                    If chkUpdate_Add(dbReader("eBay_ID").ToString, "yabe_auction_list_history") = "ADD" Then

                        strSQL = "INSERT INTO yabe_auction_list_history(eBay_ID,menge, eBay_account, email, auction_title,current_price, startprice,iseBayEnded,ListType,auction_end,auction_begin,watchcount,shippment,eBayBild,personal_id,bids,status,auction_type,paypal_sum,YABE_ID,bildname,bild_url,hitcounter,eiso_orderlist_id) "
                        strSQL &= "Values( "
                        strSQL &= "'" & dbReader("eBay_ID").ToString & "',"
                        strSQL &= "'" & dbReader("menge").ToString & "'," ' Account 
                        strSQL &= "'" & dbReader("eBay_account").ToString & "'," ' Account 
                        strSQL &= "'" & dbReader("email").ToString & "'," ' email 
                        strSQL &= "'" & dbReader("auction_title").ToString.Replace("'", "") & "',"

                        strSQL &= dbReader("current_price").ToString.Replace(",", ".") & ","

                        '# 
                        If dbReader("startprice").ToString = "" Then
                            strSQL &= "0,"
                        Else
                            strSQL &= dbReader("startprice").ToString.Replace(",", ".") & ","
                        End If


                        strSQL &= "'" & dbReader("iseBayEnded").ToString & "',"
                        strSQL &= "'" & dbReader("ListType").ToString & "',"
                        strSQL &= "'" & getMysqlTimestamp(dbReader("auction_end").ToString) & "',"
                        strSQL &= "'" & getMysqlTimestamp(dbReader("auction_begin").ToString) & "',"
                        strSQL &= dbReader("watchcount").ToString & ","
                        strSQL &= "'" & dbReader("shippment").ToString & "',"
                        strSQL &= "'" & dbReader("eBayBild").ToString & "',"

                        If Not dbReader("personal_id").ToString = Nothing Then
                            strSQL &= dbReader("personal_id").ToString & ","
                        Else
                            strSQL &= "0,"
                        End If
                        strSQL &= "'" & dbReader("bids").ToString & "',"
                        strSQL &= "'Bestellt',"
                        strSQL &= "'" & dbReader("auction_type").ToString & "',"
                        strSQL &= "'" & dbReader("paypal_sum").ToString.Replace(",", ".") & "',"

                        If IsNumeric(dbReader("YABE_ID")) = True Then
                            strSQL &= "'" & dbReader("YABE_ID").ToString & "',"
                        Else
                            strSQL &= "'" & dbReader("YABE_ID").ToString & "',"
                        End If


                        strSQL &= "'" & dbReader("bildname").ToString & "',"
                        strSQL &= "'" & dbReader("bild_url").ToString & "',"

                        If dbReader("hitcounter").ToString = "" Then
                            strSQL &= "0)"
                        Else
                            strSQL &= "'" & dbReader("hitcounter").ToString & "','" & dbReader("eiso_orderlist_id").ToString & "')"
                        End If

                        If My.Settings.shopste_lagerbestand_verwalten = True And Not dbReader("auction_type").ToString = "Shopste" Then
                            getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=set_shopste_item_ordered&domain_id=" & My.Settings.domain_id & "&item_id=" & dbReader("YABE_ID").ToString & "&menge=" & dbReader("menge").ToString, mgetUpdaterMessage.setShopsteItemAmount, True)
                        End If

                        Dim con_insert As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                        con_insert.Open()
                        Dim command_insert As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_insert)
                        command_insert.ExecuteNonQuery()
                        con_insert.Close()

                        Application.DoEvents()
                    End If

                End While

                '# ---------------------------------
                '# LÖSCHEN DER ÜBERTRAGENDEN DATEN
                '# ---------------------------------
                If frmStatusWindow.bStopMode = False Then
                    strQuery = "DELETE FROM yabe_auction_list_live WHERE isEbayEnded = 'Completed' AND eBay_account = '' OR isSend ='true'"
                    Dim con_insert_order_del As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)

                    con_insert_order_del.Close()
                    con_insert_order_del.Open()
                    Dim command_kill As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_insert_order_del)
                    command_kill.ExecuteNonQuery()
                    con_insert_order_del.Close()
                End If
            Else
                '# FEHLER BEIM ERFASSEN
                MessageBox.Show("Fehler beim einlesen seteBayHistory", "YABE - eBay History", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


            frmStatusWindow.Dispose()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "seteBayHistory")
            frmStatusWindow.Dispose()
            Return False
        End Try

        Return True
    End Function

    '#############################################################################################
    '# EiSo Order ID setzen
    '#############################################################################################
    Public Function setCockpitLiveEiSoOrderid(iorderid As Integer, strEmail As String) As Boolean
        Try

            If IsNumeric(iorderid) = True Then
                Dim strQuery As String = "UPDATE yabe_auction_list_live SET eiso_orderlist_id='" & iorderid & "' WHERE email='" & strEmail & "'"

                Dim con_insert As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                con_insert.Close()
                con_insert.Open()

                Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_insert)
                command_count.ExecuteNonQuery()
                con_insert.Close()


            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setCockpitLiveEiSoOrderid")
            Return False
        End Try
    End Function

    '#############################################################################################
    '# EiSo Order ID setzen
    '#############################################################################################
    Public Function getOrderListID(stremail As String) As String
        Try
            Dim iOderlistid As String = ""
            ' AND eBay_account = '' OR isSend ='true'
            strQuery = "SELECT * FROM yabe_auction_list_live WHERE isEbayEnded = 'Completed' AND email='" & stremail & "'"

            Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection
            dbConnect2.ConnectionString = dbConnect.ConnectionString

            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect2)


            dbConnect2.Close()
            dbConnect2.Open()

            Dim dbreader2 As MySql.Data.MySqlClient.MySqlDataReader
            dbreader2 = command_count.ExecuteReader

            While Not dbreader2.Read() = False

                If Not dbreader2("eiso_orderlist_id").ToString = "0" Then
                    iOderlistid = dbreader2("eiso_orderlist_id").ToString
                End If

            End While

            dbConnect2.Close()

            Return iOderlistid
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setCockpitLiveEiSoOrderid")
            Return "-1"
        End Try
    End Function

    '###########################################################
    '# >> Daten Synchronisieren mit order_ Tabellen
    '###########################################################
    Public Function setBestellungen_Orderlist_insert() As String
        Dim strSQL As String = ""
        Dim strQuery As String = ""
        Dim iInsertOrderListID As Integer
        Dim frmStatusWindow As New frmWait4Something
        Try

            '# ---------------------------------
            '# >> Anzahl berechnen
            '# ---------------------------------
            ' AND eBay_account = '' OR isSend ='true'
            strQuery = "SELECT count(*) as anzahl FROM yabe_auction_list_live WHERE isEbayEnded = 'Completed'"
            Dim command_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_count.ExecuteReader
            dbReader.Read()
            If dbReader.HasRows = True Then

                If dbReader("anzahl").ToString = "0" Then
                    '   MsgBox("Es gibt keine Daten zum aktuallisieren!", MsgBoxStyle.Information, "EiSo Bestellungen übernehmen / synchronisierern")
                    Return "-1"
                    Exit Function
                End If

                frmStatusWindow.iInervalMax = dbReader("anzahl").ToString
                frmStatusWindow.bModus = frmWait4Something.modus.artikel
                frmStatusWindow.strMessage = "EiSo Cockpit Artikel ###now### von ###max###"
                frmStatusWindow.strTitle = "EiSo - Bestellungen Synchronisieren"
                frmStatusWindow.itmrInterval = 100

            End If


            '# ---------------------------------
            '# >> BEENDET und KEIN GEBOTE
            '# ---------------------------------
            ' AND eBay_account = '' OR isSend ='true' 
            strQuery = "SELECT * FROM yabe_auction_list_live WHERE isEbayEnded = 'Completed' group by eBay_account ORDER BY eBay_account DESC"
            Dim command_init As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command_init.ExecuteReader

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                frmStatusWindow.Show(frmMain.frmManage)

                '# Lesen aus der Datenbank 
                While Not dbReader.Read() = False



                    '# ---------------------------------
                    '# >> BEENDET und KEIN GEBOTE
                    '# ---------------------------------

                    Application.DoEvents()
                    '# WAIT - Interval erhöhen
                    frmStatusWindow.iIntervalNow += 1
                    If frmStatusWindow.bStopMode = True Then
                        Return False
                        Exit Function
                    End If


                    Dim strKunde() As String = getEiSoIsCostumerAdressByEmailOrID(dbReader("email").ToString)
                    Dim strOrderDetails() As String = getEiSoOrderDetails(dbReader("email").ToString)

                    Dim strOrderListID As String = getOrderListID(dbReader("email").ToString)
                    '#########
                    '# Nur einfügen wenn keine Orderlist id gesetzt 
                    '#########
                    If (strOrderListID = "0" Or strOrderListID = "") Then
                        '# NEU 

                        Dim strStatus As String = ""
                        If My.Settings.eiso_gui_eiso_versandart_anzeigen = False Then
                            strStatus = "14"
                        Else
                            strStatus = "1"
                        End If

                        strSQL = "INSERT INTO yabe_order_list(yabe_personals_id,order_status_history_id, email, webside_language, plattform_text,plattform_id, shippment_amount,order_total,shippment_sum,paypal_total_sum,total_sum_amount) "
                        strSQL &= "Values( "
                        strSQL &= "'" & strKunde(6).ToString & "',"
                        strSQL &= "'" & strStatus & "'," ' status 1 -> bestellt 
                        strSQL &= "'" & dbReader("email").ToString & "'," ' Account 
                        strSQL &= "'DE'," ' sprache 
                        strSQL &= "'" & dbReader("auction_type").ToString & "',"
                        strSQL &= "'0'," ' muss noch erfasst werden
                        strSQL &= "'" & strOrderDetails(1) & "',"


                        '        strData(0) = dblOrderTotal
                        'strData(1) = dblShippment
                        'strData(2) = dblPayPalsum
                        'strData(3) = dblOrderTotal + dblShippment

                        strSQL &= "'" & strOrderDetails(0) & "','" & strOrderDetails(1) & "','" & strOrderDetails(2) & "','" & strOrderDetails(3) & "')"


                        Dim con_insert As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                        con_insert.Open()
                        Dim command_insert As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_insert)
                        iInsertOrderListID = command_insert.ExecuteNonQuery()
                        iInsertOrderListID = command_insert.LastInsertedId
                        con_insert.Close()


                    Else

                        strQuery = "UPDATE yabe_order_list SET shippment_amount='" & strOrderDetails(1).ToString.Replace(",", ".") & "',order_total='" & strOrderDetails(0).ToString.Replace(",", ".") & "',paypal_total_sum='" & strOrderDetails(2).ToString.Replace(",", ".") & "',total_sum_amount='" & strOrderDetails(3).ToString.Replace(",", ".") & "' WHERE orderID='" & strOrderListID & "'"

                        Dim con_insert2 As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                        con_insert2.Close()
                        con_insert2.Open()
                        Dim command_insert2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_insert2)
                        iInsertOrderListID = command_insert2.ExecuteNonQuery()
                        con_insert2.Close()

                        iInsertOrderListID = strOrderListID
                    End If

                    '####################################################
                    '# >> ORDER ID in Cockpit Ansicht setzen
                    '####################################################
                    If setCockpitLiveEiSoOrderid(iInsertOrderListID, dbReader("email").ToString) = False Then
                        MessageBox.Show("ERR:001: Fehler bei der EiSo Order ID übernahme..")
                    End If

                    Dim con_insert_select_live As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                    con_insert_select_live.Close()
                    con_insert_select_live.Open()

                    ' OR isSend ='true'
                    strQuery = "SELECT * FROM yabe_auction_list_live WHERE email='" & dbReader("email") & "' AND  isEbayEnded = 'Completed'"
                    Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_insert_select_live)

                    Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader = command.ExecuteReader

                    '# Gibt es einen Treffer
                    If dbReader2.HasRows = True Then


                        '# Lesen aus der Datenbank 
                        While Not dbReader2.Read() = False

                            Dim strStatus As String = ""
                            If My.Settings.eiso_gui_eiso_versandart_anzeigen = False Then
                                strStatus = "14"
                            Else
                                strStatus = "1"
                            End If

                            If chkUpdate_Add(dbReader2("eBay_ID").ToString, "yabe_order_item", "received_orderid") = "ADD" Then

                                strSQL = "INSERT INTO yabe_order_item(order_history_status_id,item_title, item_price, payment_method_name, order_shippment,order_shippment_method_id, auction_end,received_orderid,orderlist_id,menge,item_total_sum,eiso_itemdb_id) "
                                strSQL &= "Values( "
                                strSQL &= "'" & strStatus & "'," ' bestellt
                                strSQL &= "'" & dbReader2("auction_title").ToString.Replace("'", "''") & "'," '" ' Titel
                                strSQL &= "'" & dbReader2("current_price").ToString & "'," ' Preis
                                strSQL &= "'MIXED'," ' Bezahlart
                                strSQL &= "'" & dbReader2("shippment").ToString.Replace("'", "") & "'," ' Versand

                                strSQL &= "'0'," ' versand methode (id)

                                strSQL &= "'" & dbReader2("auction_end").ToString.Replace(",", ".") & "',"



                                strSQL &= "'" & dbReader2("eBay_ID").ToString & "','" & iInsertOrderListID & "','" & dbReader2("menge").ToString & "','" & (Convert.ToDouble(dbReader2("current_price")) * Convert.ToInt16(dbReader2("menge"))) & "','" & dbReader2("YABE_ID").ToString & "')"


                                Dim con_insert_order_item As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                                con_insert_order_item.Close()
                                con_insert_order_item.Open()
                                Dim command_insert_order_list As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_insert_order_item)
                                'command_insert_order_list.Parameters.Add(New SqlParameter("auction_title", dbReader2("auction_title").ToString))


                                command_insert_order_list.ExecuteNonQuery()
                                con_insert_order_item.Close()

                                Application.DoEvents()
                            Else
                                strQuery = "UPDATE yabe_order_item SET orderlist_id='" & iInsertOrderListID & "' WHERE received_orderid='" & dbReader2("eBay_ID").ToString & "'"

                                Dim con_insert_order_item As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                                con_insert_order_item.Close()
                                con_insert_order_item.Open()
                                Dim command_insert_order_list As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_insert_order_item)
                                command_insert_order_list.ExecuteNonQuery()
                                con_insert_order_item.Close()
                            End If

                        End While

                        con_insert_select_live.Close()



                    Else
                        '# FEHLER BEIM ERFASSEN
                        MessageBox.Show("Fehler beim synchronisieren des Cockpits mit den Bestellzungen", "EiSo Bestellungen übernehmen", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End While
            End If

            frmStatusWindow.Dispose()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setBestellungen_insert")
            frmStatusWindow.Dispose()
            Return False
        End Try

        Return True
    End Function


    '#######################################################################
    '# >> chkYABE_Orders
    '#######################################################################
    Public Function chkYABE_Orders(ByVal strEmail As String) As Boolean
        strQuery = "SELECT COUNT(*) as anzahl FROM yabe_auction_list_history WHERE email ='" & strEmail & "'"
        Dim con_db As New MySql.Data.MySqlClient.MySqlConnection
        con_db.ConnectionString = dbConnect.ConnectionString

        Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader

        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_db)
        con_db.Close()
        con_db.Open()
        dbReader2 = command.ExecuteReader()

        If dbReader2.HasRows = True Then
            dbReader2.Read()
            '# Prüfung ob Daten schon vorhanden sind 
            If Convert.ToInt16(dbReader2("anzahl").ToString) > 0 Then
                con_db.Close()
                Return True
            Else
                con_db.Close()
                Return False
            End If
        End If

    End Function

    '###########################################################
    '# >> Prüfung ob Benutzer vorhanden ist 
    '###########################################################
    Public Function chkYABE_Kunden_isUserStored(ByVal strEmail As String, ByVal strtabelle As datentabelle) As Boolean
        Dim strQuery As String = ""
        Dim strTabellennanme As String = ""
        Try

            Select Case strtabelle
                Case datentabelle.yabe_personals_profile
                    strTabellennanme = "yabe_personals_profile"
                Case datentabelle.yabe_personals_adress
                    strTabellennanme = "yabe_personals_adress"
            End Select

            strQuery = "SELECT COUNT(*) as anzahl FROM " & strTabellennanme & " WHERE email ='" & strEmail & "'"
            Dim con_db As New MySql.Data.MySqlClient.MySqlConnection
            con_db.ConnectionString = dbConnect.ConnectionString

            Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_db)
            con_db.Close()
            con_db.Open()
            dbReader2 = command.ExecuteReader()

            If dbReader2.HasRows = True Then
                dbReader2.Read()
                '# Prüfung ob Daten schon vorhanden sind 
                If Convert.ToInt16(dbReader2("anzahl").ToString) > 0 Then
                    con_db.Close()
                    Return True
                Else
                    con_db.Close()
                    Return False
                End If

            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "chkYABE_Kunden_isUserStored")
            Return False
        End Try
        Return True
    End Function

    Public Function setYABE_Kunde_newAdress(ByVal mModus As modus, ByVal strUsername As String, ByVal strEmail As String, Optional ByVal strAdditional As ArrayList = Nothing) As Boolean
        Dim strSQL As String = ""
        Dim bInsert As Boolean = True


    End Function

    '###############################################################
    '# >> Passwort generieren
    '###############################################################
    Public Function getRandomPwd(ByVal maxSize As Integer) As String
        Dim chars As Char() = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length - 1)))
        Next
        Return result.ToString()
    End Function

    Public Function chkGetUsername(ByVal strBaseUsername As String) As String

        Dim strSQL As String
        Dim iCount As Integer = 0
        Dim bExit As Boolean = False
        Dim con_getARtikel As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
        Dim strTempUsername As String

        strTempUsername = strBaseUsername

        While bExit = False

            strSQL = "SELECT * FROM yabe_personals_profile WHERE website_account='" & strTempUsername & "'"
            con_getARtikel.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_getARtikel)
            dbReader = command.ExecuteReader()

            If dbReader.HasRows = True Then
                con_getARtikel.Close()
                strTempUsername = strBaseUsername & iCount
                iCount += 1
            Else
                bExit = True
                strBaseUsername = strTempUsername
            End If

        End While

        Return strBaseUsername
    End Function

    Public Function setShopsteCatEiSoMenue(strShopsteCat As String, menueID As String)
        Dim strSQL As String = ""
        Try
            strSQL = "UPDATE `tbl_menue` SET "

            strSQL &= "`shopste_catid`='" & strShopsteCat & "' "


            strSQL &= " WHERE `ID`='" & menueID & "'"

            dbConnect.Close()
            dbConnect.Open()

            Dim cmd_galerie_insert As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            cmd_galerie_insert.ExecuteNonQuery()

            dbConnect.Close()

        Catch ex As Exception
            Call debug_message(ex, strSQL & vbCrLf & "setShopsteCatEiSoMenue")
            Return False
        End Try
    End Function

    Public Function setShopsteCatEiSoArtikel(strShopsteCat As String, eisoshopid As String)
        Dim strSQL As String = ""
        Try
            strSQL = "UPDATE `tblGes` SET "

            strSQL &= "`shopste_itemid`='" & strShopsteCat & "' "


            strSQL &= " WHERE `ID`='" & eisoshopid & "'"

            dbConnect.Close()
            dbConnect.Open()

            Dim cmd_galerie_insert As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            cmd_galerie_insert.ExecuteNonQuery()

            dbConnect.Close()

        Catch ex As Exception
            Call debug_message(ex, strSQL & vbCrLf & "setShopsteCatEiSoArtikel")
            Return False
        End Try
    End Function
    Public Function setYABE_Kunde_ProfileUpdate(strEmail As String, strUsername As String, strAdditional As ArrayList)
        Dim strSQL As String = ""
        Try
            strSQL = "UPDATE `yabe_personals_profile` SET "

            strSQL &= "`website_account`='" & strAdditional.Item(0).ToString & "' "
            strSQL &= ", website_pwd= '" & strAdditional.Item(1).ToString & "'," ' Delcampe User ID 


            strSQL &= " WHERE `email`='" & strEmail & "'"


            'If bInsert = True Then
            If strEmail.Length > 0 Then
                dbConnect.Close()
                dbConnect.Open()

                Dim cmd_galerie_insert As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
                cmd_galerie_insert.ExecuteNonQuery()

                dbConnect.Close()
            End If
        Catch ex As Exception
            Call debug_message(ex, strSQL & vbCrLf & "setYABE_Kunde_newProfile")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> Benutzerdaten in das Profil übernehmen 
    '###########################################################
    Public Function setYABE_Kunde_newProfile(ByVal mModus As modus, ByVal strUsername As String, ByVal strEmail As String, Optional ByVal strAdditional As ArrayList = Nothing) As Boolean
        Dim strSQL As String = ""
        Dim bInsert As Boolean = True
        Try

            Select Case mModus
                Case modus.insert

                    strSQL = "INSERT INTO `yabe_personals_profile` (`eBay_account`,`email`,`isWebUser`,`CRC`,`website_account`,`website_pwd`,delcampe_userid,sprache,sprach_liste,`PartnerID`,CRC)"
                    strSQL &= "Values( "
                    strSQL &= "'" & strUsername & "'," ' Accountname 
                    strSQL &= "'" & strEmail & "'," ' eMail 
                    strSQL &= "'N'," ' Webuser 
                    strSQL &= "'----'," ' CRC
                    Dim strUsername_split() As String = strUsername.Split("(")
                    strSQL &= "'" & chkGetUsername(strUsername_split(0).Trim) & "'," ' Webseiten Account
                    strSQL &= "'" & getRandomPwd(4) & "'," ' Webseiten Pwd 

                    '# Fehlerfall kein strAdditional übergeben 
                    Try
                        If strAdditional.Count > 0 Then
                            strSQL &= "'" & strAdditional.Item(0).ToString & "'," ' Delcampe User ID 
                            strSQL &= "'" & strAdditional.Item(1).ToString & "'," ' Muttersprache
                            strSQL &= "'" & strAdditional.Item(2).ToString & "'," ' Sprachliste
                        Else
                            strSQL &= "''," ' Delcampe User ID 
                            strSQL &= "''," ' Muttersprache
                            strSQL &= "''," ' Sprachliste
                        End If
                    Catch ex As Exception
                        '# Pflichtfelder ausfüllen wegen möglicher Verschiebung 
                        strSQL &= "''," ' Delcampe User ID 
                        strSQL &= "''," ' Muttersprache
                        strSQL &= "''," ' Sprachliste
                    End Try

                    strSQL &= "'',"
                    strSQL &= "'" & MD5StringHash(strUsername & strEmail & Date.Now) & "'"
                    strSQL &= ")"

                Case modus.update

                    strSQL = "UPDATE `yabe_personals_profile` SET "
                    If Not strEmail = "" Then
                        strSQL &= "`eBay_account`='" & strUsername & "' "
                        bInsert = False
                    End If

                    '# Fehlerfall kein strAdditional übergeben 
                    Try
                        If strAdditional.Count > 0 Then

                            strSQL &= ", delcampe_userid= '" & strAdditional.Item(0).ToString & "'," ' Delcampe User ID 
                            strSQL &= "sprache='" & strAdditional.Item(1).ToString & "'," ' Muttersprache
                            strSQL &= "sprach_liste='" & strAdditional.Item(2).ToString & "'" ' Sprachliste

                        End If
                    Catch ex As Exception

                    End Try





                    strSQL &= " WHERE `email`='" & strEmail & "'"

            End Select

            'If bInsert = True Then
            If strEmail.Length > 0 Then
                dbConnect.Close()
                dbConnect.Open()

                Dim cmd_galerie_insert As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
                cmd_galerie_insert.ExecuteNonQuery()

                dbConnect.Close()
            End If

            '    End If


        Catch ex As Exception
            Call debug_message(ex, strSQL & vbCrLf & "setYABE_Kunde_newProfile")
            Return False
        End Try

        Return True
    End Function
    '###########################################################
    '# >> Ermittelt die Anzahl der Käufe 
    '###########################################################
    Public Function getEiSoBestellungen_kunde_last_order(ByVal strEmail As String) As String()
        Dim strData(3) As String
        Dim strSQL As String = ""
        Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
        Try

            If strEmail.Length = 0 Then
                Return Nothing
                Exit Function
            End If

            strSQL = "SELECT * FROM yabe_auction_list_history WHERE email='" & strEmail & "' ORDER BY auction_end DESC"
            Dim con_getARtikel As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con_getARtikel.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_getARtikel)
            dbReader2 = command.ExecuteReader()

            If dbReader2.HasRows = True Then
                dbReader2.Read()
                strData(0) = dbReader2("auction_end").ToString
                strData(1) = dbReader2("auction_title").ToString
                strData(2) = dbReader2("current_price").ToString
                strData(3) = dbReader2("auction_type").ToString
            End If

            con_getARtikel.Close()
            Return strData

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEiSoBestellungen_kunde_last_order")
            Return Nothing
        End Try
    End Function

    '###########################################################
    '# >> Ermittelt die Anzahl der Käufe 
    '###########################################################
    Public Function getEiSoBestellungen_kunde_summe(ByVal strEmail As String) As String
        Dim strData As String = ""
        Dim strSQL As String = ""
        Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
        Try

            If strEmail.Length = 0 Then
                Return "-1"
                Exit Function
            End If

            strSQL = "SELECT sum(current_price) as summe FROM yabe_auction_list_history WHERE email='" & strEmail & "'"
            Dim con_getARtikel As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con_getARtikel.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_getARtikel)
            dbReader2 = command.ExecuteReader()

            If dbReader2.HasRows = True Then
                dbReader2.Read()
                strData = dbReader2("summe").ToString
            End If

            con_getARtikel.Close()
            Return strData

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEiSoBestellungen_kunde_summe")
            Return "-1"
        End Try
    End Function

    '###########################################################
    '# >> Ermittelt die Anzahl der Käufe + Summe 
    '###########################################################
    Public Function getEiSoBestellungen_kunde_sumary(ByVal strEmail As String) As String()
        Dim strData(1) As String
        Dim strSQL As String = ""
        Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader

        strData(0) = "-1"
        strData(1) = "-1"

        Try

            If strEmail.Length = 0 Then
                Return strData
                Exit Function
            End If

            strSQL = "SELECT count(orderID) as anzahl,sum(current_price) as summe FROM yabe_auction_list_history WHERE email='" & strEmail & "'"
            Dim con_getARtikel As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con_getARtikel.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_getARtikel)
            dbReader2 = command.ExecuteReader()

            If dbReader2.HasRows = True Then
                dbReader2.Read()
                strData(0) = dbReader2("anzahl").ToString
                strData(1) = dbReader2("summe").ToString
            End If

            con_getARtikel.Close()
            Return strData

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEiSoBestellungen_kunde_sumary")
            Return strData
        End Try
    End Function

    '###########################################################
    '# >> Ermittelt die Anzahl der Käufe 
    '###########################################################
    Public Function getEiSoBestellungen_kunde_anzahl_artikel(ByVal strEmail As String) As String
        Dim strData As String = ""
        Dim strSQL As String = ""
        Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
        Try

            If strEmail.Length = 0 Then
                Return "-1"
                Exit Function
            End If

            strSQL = "SELECT COUNT(*) as anzahl FROM yabe_auction_list_history WHERE email='" & strEmail & "'"
            Dim con_kaufanzahl As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con_kaufanzahl.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, con_kaufanzahl)
            dbReader2 = command.ExecuteReader()

            If dbReader2.HasRows = True Then
                dbReader2.Read()
                strData = dbReader2("anzahl").ToString
            End If

            con_kaufanzahl.Close()
            Return strData
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEiSoBestellungen_kunde_anzahl_artikel")
            Return "-1"
        End Try


    End Function

    '###########################################################
    '# >> Holt den letzten oder den ersten Eintrag 
    '###########################################################
    Public Function getFirstLastItem(ByVal bLast As Boolean) As String
        Dim strSQL As String
        Dim strData As String

        Try
            If bLast = True Then
                strSQL = "SELECT * FROM `yabe_auction_list_live` WHERE iseBayEnded='COMPLETED' AND bids > 0 AND NOT auction_end='0000-00-00 00:00:00' ORDER BY `auction_end` ASC LIMIT 0,1"
            Else
                strSQL = "SELECT * FROM `yabe_auction_list_live` WHERE iseBayEnded='COMPLETED' AND bids > 0 AND NOT auction_end='0000-00-00 00:00:00' ORDER BY `auction_end` DESC LIMIT 0,1"
            End If

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = command.ExecuteReader
            dbReader.Read()

            strData = dbReader("auction_end").ToString

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getFirstLast")
            Return "-1"
        End Try
        Return strData

    End Function
    '###########################################################
    '# >> Setzen der PersonalID zu den Artikeln 
    '###########################################################
    Public Function setPersonalID2Item_email(ByVal strEmail As String, ByVal iPersonal As Integer, Optional ByVal strTable As String = "yabe_auction_list_live") As Boolean
        Dim strSQL As String
        Try

            If strEmail.Length = 0 Then
                MsgBox("Es wurde keine Email übergeben", MsgBoxStyle.Critical)
                Exit Function
            End If


            strSQL = "UPDATE `" & strTable & "` SET personal_id='" & iPersonal & "' WHERE email='" & strEmail & "'"

            dbConnect.Close()
            dbConnect.Open()
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            cmd_personal.ExecuteNonQuery()

            dbConnect.Close()
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setPersonalID2Item")
            Return False
        End Try

        Return True
    End Function

    '###########################################################
    '# >> Setzen der PersonalID zu den Artikeln 
    '###########################################################
    Public Function setPersonalID2Item(ByVal streBayID As String, ByVal iPersonal As Integer, Optional ByVal strTable As String = "yabe_auction_list_live") As Boolean
        Dim strSQL As String
        Try

            If streBayID.Length = 0 Then
                MsgBox("Es wurde keiner eBay ID übergeben", MsgBoxStyle.Critical)
                Exit Function
            End If


            strSQL = "UPDATE `" & strTable & "` SET personal_id='" & iPersonal & "' WHERE eBay_ID=" & streBayID

            dbConnect.Close()
            dbConnect.Open()
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            cmd_personal.ExecuteNonQuery()

            dbConnect.Close()
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setPersonalID2Item")
            Return False
        End Try

        Return True
    End Function


    '###########################################################
    '# >> Benutzerdaten in das Profil übernehmen 
    '###########################################################
    Public Function setYABE_kunden_adress_ArrayList(ByVal mModus As modus, ByVal aryList As ArrayList) As Boolean
        Dim strSQL As String = ""
        Dim bCompanyName As Boolean = False
        Dim strCompanyFeld As String = ""
        Dim strTimeStamp As String = ""

        Try


            Select Case mModus
                Case modus.insert
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

                    '# Company
                    If Not aryList.Item(0).ToString = Nothing Then
                        bCompanyName = True
                        strCompanyFeld = ",`firmenname`"
                    Else
                        bCompanyName = False
                    End If

                    strSQL = "INSERT INTO `yabe_personals_adress` (`eBay_account`,`email`,`Type`,`name`,`street`,`zipcode`,`city`,`bundesland`,`country`,`telefon`,`handy`,`email_second`" & strCompanyFeld & ")"
                    strSQL &= "Values( "
                    strSQL &= "'" & aryList.Item(18).ToString & "'," ' Accountname 
                    strSQL &= "'" & aryList.Item(0).ToString & "'," ' eMail 
                    strSQL &= "'eBay'," ' Type
                    strSQL &= "'" & aryList.Item(12).ToString.Replace("'", "") & "'," ' Name
                    strSQL &= "'" & aryList.Item(15).ToString.Replace("'", " ").Replace(",", "") & "'," ' Straße 
                    strSQL &= "'" & aryList.Item(13).ToString & "'," ' Postleitzahl
                    strSQL &= "'" & aryList.Item(14).ToString.Replace("'", "") & "'," ' Stadt
                    strSQL &= "'" & aryList.Item(1).ToString.Replace("'", "") & "'," ' Bundesland
                    strSQL &= "'" & aryList.Item(16).ToString & "'," ' Land
                    strSQL &= "'" & aryList.Item(19).ToString & "'," ' Telefon
                    Try
                        strSQL &= "'" & aryList.Item(20).ToString & "'," ' Handy
                    Catch ex As Exception
                        strSQL &= "''," ' Handy
                    End Try


                    If bCompanyName = True Then
                        Try
                            strSQL &= "'" & aryList.Item(21).ToString.Replace("'", "") & "'," ' Firmenname
                        Catch ex As Exception
                            strSQL &= "''," ' Firmenname
                        End Try

                    End If

                    strSQL &= "'---'" ' 2. eMail

                    strSQL &= ")"

                Case modus.update

                    '# Name Vorhanden für die Adresse... eBay API Schutz vor leeren Adressen
                    If aryList.Item(12).ToString.Length > 0 Then
                        strTimeStamp = Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
                        strSQL = "UPDATE `yabe_personals_adress` SET "

                        If Not aryList.Item(0).ToString = "Invalid Request" Then
                            strSQL &= "`eBay_account`='" & aryList.Item(18).ToString & "', "
                        End If

                        strSQL &= "`street`='" & aryList.Item(15).ToString.Replace("'", " ").Replace(",", " ") & "',"
                        strSQL &= "`name`='" & aryList.Item(12).ToString.Replace("'", "") & "', "
                        strSQL &= "`zipcode`='" & aryList.Item(13).ToString & "', "
                        strSQL &= "`city`='" & aryList.Item(14).ToString.Replace("'", "") & "', "

                        '# Firmenenmae 
                        Try
                            If Not aryList.Item(21).ToString.Length > 2 Then
                                strSQL &= "`firmenname`='" & aryList.Item(21).ToString.Replace("'", "") & "',"
                            End If
                        Catch ex As Exception

                        End Try

                        Try
                            strSQL &= "`bundesland`='" & aryList.Item(22).ToString.Replace("'", "") & "',"
                        Catch ex As Exception

                        End Try


                        strSQL &= "`adress_lastupdate`='" & strTimeStamp & "'"

                        strSQL &= "WHERE `email`='" & aryList.Item(0).ToString & "'"
                    Else
                        frmMain.master_Message_label.Text = "Fehler Bei Adressenspeichern von '" & aryList.Item(0).ToString & "'"
                    End If

            End Select

            dbConnect.Close()

            If strSQL.Length > 0 Then
                dbConnect.Open()

                Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
                cmd_personal.ExecuteNonQuery()
                dbConnect.Close()
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, strSQL & vbCrLf & "setYABE_kunden_adress_ArrayList")
            Return False
        End Try


    End Function

    '###########################################################
    '# >> Update DB: Live / History 
    '###########################################################
    Public Function setYABE_item_update(ByVal strField As String, ByVal strValue As String, ByVal strID As String, ByVal strTabele As datentabelle) As Boolean
        Dim strTabelle As String = ""

        Try
            If strField.Length > 0 And strValue.Length > 0 Then

                Select Case strTabele
                    Case datentabelle.yabe_auction_list_history
                        strTabelle = datentabelle.yabe_auction_list_history.ToString
                    Case datentabelle.yabe_auction_list_live
                        strTabelle = datentabelle.yabe_auction_list_live.ToString
                End Select

                strQuery = "UPDATE " & strTabelle & " SET " & strField & "=" & strValue & " WHERE eBay_ID='" & strID & "'"

                dbConnect.Close()
                dbConnect.Open()
                Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
                cmd_personal.ExecuteNonQuery()

            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setYABE_item_update")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> eBay: Transaktion Objekt 2 Adresse 
    '###########################################################
    Public Function setYABE_kunden_adress_eBayTransaktion(ByVal mModus As modus, ByVal oGetSellerTransactionsCall As eBay.Service.Core.Soap.TransactionType) As Boolean
        Dim strSQL As String = ""
        Dim bCompanyName As Boolean = False
        Dim strCompanyFeld As String = ""
        Dim strTimeStamp As String = ""
        Dim strStreet As String = ""
        Try

            Select Case mModus
                Case modus.insert

                    If Not oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CompanyName = Nothing Then
                        bCompanyName = True
                        strCompanyFeld = ",`firmenname`"
                    Else
                        bCompanyName = False
                    End If

                    '# Straße ermitteln 
                    strStreet = oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Street1.Replace("'", " ").Replace(",", "")
                    If Not oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Street2 = Nothing Then
                        'zweites Straßenfeld gefüllt... 
                        strStreet &= " " & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Street2
                    End If

                    strSQL = "INSERT INTO `yabe_personals_adress` (`eBay_account`,`email`,`Type`,`name`,`street`,`zipcode`,`city`,`bundesland`,`country`,`telefon`,`handy`,`email_second`" & strCompanyFeld & ",country_code)"
                    strSQL &= "Values( "
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.UserID & "'," ' Accountname 
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.Email & "'," ' eMail 
                    strSQL &= "'eBay'," ' Type
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Name.Replace("'", "") & "'," ' Name
                    strSQL &= "'" & strStreet & "'," ' Straße 
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.PostalCode & "'," ' Postleitzahl
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CityName.Replace("'", "") & "'," ' Stadt
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.StateOrProvince.Replace("'", "") & "'," ' Bundesland
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CountryName & "'," ' Land
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Phone & "'," ' Telefon
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.PhoneAreaOrCityCode & "'," ' Handy

                    If bCompanyName = True Then
                        strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CompanyName.Replace("'", "") & "'," ' Firmenname
                    End If

                    strSQL &= "'---'," ' 2. eMail
                    strSQL &= "'" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Country & "'" ' 2. countrycode
                    strSQL &= ")"

                Case modus.update

                    strTimeStamp = Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second

                    '# Straße ermitteln 
                    strStreet = oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Street1.Replace("'", " ").Replace(",", " ")
                    If Not oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Street2 = Nothing Then
                        'zweites Straßenfeld gefüllt... 
                        strStreet &= " " & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Street2
                    End If

                    strSQL = "UPDATE `yabe_personals_adress` SET "

                    If Not oGetSellerTransactionsCall.Buyer.Email = "Invalid Request" Then
                        strSQL &= "`email`='" & oGetSellerTransactionsCall.Buyer.Email & "', "
                    End If

                    strSQL &= "`street`='" & strStreet & "',"
                    strSQL &= "`name`='" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Name.Replace("'", "") & "', "
                    strSQL &= "`zipcode`='" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.PostalCode & "', "
                    strSQL &= "`city`='" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CityName.Replace("'", "") & "', "
                    strSQL &= "`adress_lastupdate`='" & strTimeStamp & "', "
                    If Not oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CompanyName = Nothing Then
                        strSQL &= "`firmenname`='" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CompanyName.Replace("'", "")
                    End If

                    strSQL &= "`bundesland`='" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.StateOrProvince.Replace("'", "") & "',"
                    strSQL &= "`country`='" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.CountryName.Replace("'", "") & "',"
                    strSQL &= "`country_code`='" & oGetSellerTransactionsCall.Buyer.BuyerInfo.ShippingAddress.Country & "'"
                    strSQL &= "WHERE `eBay_account`='" & oGetSellerTransactionsCall.Buyer.UserID & "'"

            End Select

            dbConnect.Close()
            dbConnect.Open()
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect)
            cmd_personal.ExecuteNonQuery()

        Catch ex As Exception
            Call debug_message(ex, strSQL & vbCrLf & "setYABE_kunden_adress_eBayTransaktion" & strSQL)
            Return False
        End Try

        Return True
    End Function

    '###########################################################
    '# >> Galerie löschen
    '###########################################################
    Public Function setGalerie_delete(ByVal id As Integer) As Boolean
        Dim strQuery As String = ""
        Try

            Dim con_delete As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con_delete.Open()
            'con_delete.ChangeDatabase("db_u10097_01")
            strQuery = "DELETE FROM yabe_cubss_galerie WHERE ID=" & id
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_delete)
            cmd_personal.ExecuteNonQuery()
            con_delete.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & strQuery & vbCrLf & "getNewsletter")
            Return False
        End Try
    End Function


    '###########################################################
    '# >> SYNCHRONISIEREN
    '###########################################################
    Public Function setYABE_Kunde_Profil2Adress(ByVal profilID As Integer, ByVal strEmail As String) As Boolean
        Dim strQuery As String = ""

        Try

            Dim con_insert As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con_insert.Close()
            con_insert.Open()
            strQuery = "UPDATE yabe_personals_adress SET profil_id=" & profilID & " WHERE email='" & strEmail & "'"
            Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_insert)
            cmd_adress.ExecuteNonQuery()
            con_insert.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & strQuery & vbCrLf & "setProfilID2Adress")
            Return False
        End Try

    End Function

    '###########################################################
    '# >> YABE -> Hole Adress_id 
    '###########################################################
    Public Function getYABE_adress_id(ByVal strEmail As String) As String
        Dim strValue As String = ""
        Try
            strQuery = "SELECT * FROM yabe_personals_adress WHERE email='" & strEmail & "' ORDER BY adress_lastupdate DESC"
            Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = cmd_adress.ExecuteReader()

            If dbReader.HasRows = True Then
                dbReader.Read()
                strValue = dbReader("id").ToString
                Return strValue
            Else
                Return "-1"
            End If
        Catch ex As Exception
            dbConnect.Close()
            Call debug_message(ex, "getYABE_adress_id")
            Return "-2"
        End Try
    End Function

    '###########################################################
    '# >> YABE -> Hole Profil_id mit eMail  
    '###########################################################
    Public Function getYABE_profil_id(ByVal strEmail As String) As String
        Dim strValue As String = ""
        Try
            strQuery = "SELECT * FROM yabe_personals_profile WHERE email='" & strEmail & "' ORDER BY lastupdate DESC"
            Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = cmd_adress.ExecuteReader()

            If dbReader.HasRows = True Then
                dbReader.Read()
                strValue = dbReader("Id").ToString
                Return strValue
            Else
                Return "-1"
            End If
        Catch ex As Exception
            dbConnect.Close()
            Call debug_message(ex, "getYABE_profil_id")
            Return "-2"
        End Try
    End Function

    '###########################################################
    '# >> Letzten eBay Artikel abrufen 
    '###########################################################
    Public Function getLasteBayArtikel(ByVal strEMail As String) As String
        Dim strQuery As String = ""
        Dim strData As String = ""

        Try

            strQuery = "SELECT * FROM yabe_auction_list_history WHERE email='" & strEMail & "' ORDER BY lastupdate DESC LIMIT 0,1"
            Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = cmd_adress.ExecuteReader()

            If dbReader.HasRows = True Then
                dbReader.Read()
                strData = dbReader("eBay_ID").ToString
                Return strData
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & strQuery & vbCrLf & "getLasteBayArtikel")
            Return False
        End Try

    End Function

    '########################################################################
    '#>> setSyncOrders2Profil Bestellungen zum Profil mappen 
    '########################################################################
    Public Function setSyncOrders2Profil() As Boolean
        Try
            Dim strQuery As String

            '# Wartefenster erzeugen 
            Dim frmWait As New frmWait4Something
            frmWait.iInervalMax = -1
            frmWait.setWait4Somthing("Bestellungen synchronisieren", "Bitte warten..", 0)
            frmWait.Show()

            strQuery = "SELECT * FROM yabe_auction_list_history WHERE yabe_auction_list_history.personal_id = 0 AND bids > 0 ORDER BY email ASC"
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = cmd_personal.ExecuteReader

            '# Daten abholen 
            If dbReader.HasRows = True Then

                Dim iCount As Integer = 0
                While dbReader.Read


                    Application.DoEvents()

                    strQuery = "SELECT * FROM yabe_personals_profile WHERE email='" & dbReader("email").ToString & "'"
                    Dim con_select As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
                    con_select.Open()

                    Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_select)
                    Dim dbRead_adress As MySql.Data.MySqlClient.MySqlDataReader
                    dbRead_adress = cmd_adress.ExecuteReader()

                    iCount += 1
                    frmWait.lblMessage.Text = "Bei Nr.'" & iCount & " - " & dbReader("email").ToString & "'"

                    If dbRead_adress.HasRows = True Then
                        dbRead_adress.Read()
                        setOrder2Profil(dbRead_adress("ID").ToString, dbReader("email").ToString)
                    End If

                    con_select.Close()

                End While
            End If

            frmWait.Dispose()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setSyncOrders2Profil")
            Return False
        End Try
    End Function

    '##############################################################
    '# >> Synchronisieren von Bestellungen mit Profil_ID (alte)
    '##############################################################
    Public Function setOrder2Profil(ByVal strID As String, ByVal strEmail As String) As Boolean
        Try

            Dim strQuery As String
            Dim con_insert As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)

            con_insert.Open()
            strQuery = "UPDATE yabe_auction_list_history SET personal_id=" & strID & " WHERE email='" & strEmail & "'"

            Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_insert)
            cmd_adress.ExecuteNonQuery()
            con_insert.Close()


            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setOrder2Profil")
            Return False
        End Try
    End Function
    '###########################################################
    '# >> SYNCHRONISIEREN
    '###########################################################
    Public Function setSyncProfil2Adress() As Boolean

        Dim strQuery As String = ""
        Try

            '# Wartefenster erzeugen 
            Dim frmWait As New frmWait4Something
            frmWait.iInervalMax = -1
            frmWait.setWait4Somthing("Kunden Synchronisieren", "Bitte warten..", 0)
            frmWait.Show()

            strQuery = "SELECT * FROM yabe_personals_adress WHERE profil_id=0 ORDER BY email ASC"


            'strQuery = "SELECT * FROM yabe_personals_adress WHERE yabe_personals_adress.profil_id = 0 ORDER BY email ASC"

            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = cmd_personal.ExecuteReader

            '# Daten abholen 
            If dbReader.HasRows = True Then

                Dim iCount As Integer = 0
                Dim iCount_fehler As Integer = 0
                '# Alle abrufen 
                While dbReader.Read

                    '# Daten vom Kundenadresse abrufen

                    Dim con_select As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)

                    strQuery = "SELECT * FROM yabe_personals_profile WHERE email='" & dbReader("email").ToString & "'"
                    con_select.Open()

                    Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con_select)
                    Dim dbRead_adress As MySql.Data.MySqlClient.MySqlDataReader
                    dbRead_adress = cmd_adress.ExecuteReader()

                    iCount += 1

                    'If iCount Mod 10 = 0 Then
                    Application.DoEvents()
                    'End If

                    frmWait.lblMessage.Text = "Bei Nr.'" & iCount & " - " & dbReader("email").ToString & "'"

                    If dbRead_adress.HasRows = True Then
                        dbRead_adress.Read()
                        '# Aktuallisieren des Profils
                        setYABE_Kunde_Profil2Adress(dbRead_adress("ID").ToString, dbReader("email").ToString)
                    Else
                        iCount_fehler += 1
                    End If

                    con_select.Close()

                End While

                If iCount_fehler > 0 Then
                    MsgBox("Es konnten '" & iCount_fehler & "' Profile keiner Adresse zuordnet werden (z.B. alte Bestellungen)", MsgBoxStyle.Information)
                End If

            End If

            frmWait.Dispose()


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setSyncProfil2Adress")
            Return False
        End Try

    End Function

    '###########################################################
    '# >> Newsletter: Kunden löschen
    '###########################################################
    Public Function setKunden_deleteID(ByVal email As String, ByVal ID As String) As Boolean
        Dim strQuery As String = ""
        Try
            If dbConnect.State = ConnectionState.Closed Then
                dbConnect.Open()
            End If

            strQuery = "DELETE FROM yabe_personals_profile WHERE ID='" & ID & "'  AND email='" & email & "'"
            Dim cmd_profile As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_profile.ExecuteNonQuery()

            strQuery = "DELETE FROM yabe_personals_adress WHERE profil_id='" & ID & "' AND email='" & email & "'"
            dbConnect.Close()
            dbConnect.Open()
            Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_adress.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setKunden_deleteID")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> Newsletter: Kunden löschen
    '###########################################################
    Public Function setKunden_delete(ByVal email As String, ByVal eBay_account As String) As Boolean
        Dim strQuery As String = ""
        Try

            strQuery = "DELETE FROM yabe_personals_adress WHERE eBay_account='" & eBay_account & "' AND email='" & email & "'"
            dbConnect.Close()
            dbConnect.Open()
            Dim cmd_adress As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_adress.ExecuteNonQuery()

            strQuery = "DELETE FROM yabe_personals_profile WHERE eBay_account='" & eBay_account & "'  AND email='" & email & "'"
            Dim cmd_profile As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_profile.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setKunden_delete")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> Newsletter: Modus holen
    '###########################################################
    Public Function getNewsletter(ByVal streMail As String) As String
        Dim strQuery As String = ""

        Try

            strQuery = "SELECT * FROM yabe_personals_profile WHERE email='" & streMail & "'"
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            dbConnect.Close()
            dbConnect.Open()
            dbReader = cmd_personal.ExecuteReader()
            If dbReader.HasRows = True Then
                dbReader.Read()
                Return dbReader("getNewsletter").ToString
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getNewsletter")
            Return False
        End Try
        Return False
    End Function

    '###########################################################
    '# >> Newsletter: Ja / Nein 
    '###########################################################
    Public Function setNewsletter(ByVal streMail As String, ByVal bModus As String) As Boolean
        Dim strQuery As String = ""

        Try

            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_personals_profile set getNewsletter = '" & bModus & "' WHERE email='" & streMail & "'"
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_personal.ExecuteNonQuery()
            dbConnect.Close()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setNewsletter")
            Return False
        End Try

        Return True

    End Function

    '###########################################################
    '# >> Feedback: Benutzer Bewertung abgegeben
    '###########################################################
    Public Function setFeedbackUser(ByVal streBayID As String) As Boolean
        Dim strQuery As String = ""

        Try

            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_auction_feedback set bIsFeedback = 'Y' WHERE eBay_ID='" & streBayID & "'"
            Dim cmd_personal As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_personal.ExecuteNonQuery()
            dbConnect.Close()
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setFeedBackUser")
            Return False
        End Try

        Return True

    End Function

    '###############################################################################
    '# >> Anzahl für genauen Progressbar 
    '###############################################################################
    Public Function getSQLStatement2Countas(ByVal strSQL As String) As String
        Try
            Dim strData As String = ""

            strSQL = strSQL.Replace("SELECT * FROM", "SELECT count(*) as anzahl FROM")
            strSQL = strSQL.Replace("*,yabe_order_list.created_at as created_order FROM", "count(yabe_personals_profile.email) as anzahl ,yabe_order_list.created_at as created_order FROM")
            strSQL = strSQL.Replace("yabe_personals_profile.* FROM", "count(yabe_personals_profile.email) as anzahl FROM")
            Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection()
            dbConnect2.ConnectionString = dbConnect.ConnectionString
            dbConnect2.Close()
            Application.DoEvents()
            dbConnect2.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strSQL, dbConnect2)

            Application.DoEvents()

            Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
            dbReader2 = command.ExecuteReader

            '# Gibt es einen Treffer
            If dbReader2.HasRows = True Then
                dbReader2.Read()
                strData = dbReader2("anzahl")
                dbConnect2.Close()
                Return strData

            Else
                strData = -1
                dbConnect2.Close()
            End If

            Return strData

        Catch ex As Exception
            Call debug_message(ex, "")
            Return "-1"
        End Try

    End Function

    '###########################################################
    '# >> setProgressbarModus
    '###########################################################
    Public Function setProgressbarModus(ByRef pogrgressbar As ProgressBar, ByVal strQuery As String) As Boolean
        Try

            pgr_global_aktiv = pogrgressbar
            pogrgressbar.Value = 0
            pogrgressbar.Visible = True

            If My.Settings.yabe_progress_exakt_mode = True Then
                pogrgressbar.Maximum = getSQLStatement2Countas(strQuery)
                pogrgressbar.Style = ProgressBarStyle.Continuous
            Else
                pogrgressbar.Maximum = 100
                pogrgressbar.Style = ProgressBarStyle.Marquee

            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setProgressbarModus")
            Return False
        End Try
    End Function

    '###########################################################
    '# >> DATENABFRAGE: Holt daten aus DB 
    '###########################################################
    Public Function getListviewData(ByRef lvwData As ListView, ByVal strQuery As String, Optional imgList As ImageList = Nothing) As Boolean
        Try

            lvwData.BeginUpdate()
            lvwData.Items.Clear()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            '# JB
            command.CommandTimeout = 5000
            Dim bOut As Boolean = False
            dbConnect.Close()
            dbConnect.Open()
            Application.DoEvents()
            dbReader = command.ExecuteReader

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                '####################################
                '# Progressbar anzeige steuern
                '####################################
                Select Case lvwData.Name
                    Case "lvwEiSoCockpit"
                        Call setProgressbarModus(frmMain.frmManage.pgreBayLiveUpdate, strQuery)

                    Case "lvwBestellverwaltung_nach_artikel"
                        Call setProgressbarModus(frmMain.frmManage.pgreBayVerlaufUpdate, strQuery)

                    Case "lvMailStatus"
                        Call setProgressbarModus(frmMain.frmManage.pgrMailstatusGesammt, strQuery)

                    Case "lvwKunden"
                        Call setProgressbarModus(frmMain.frmManage.pgrKundenverlauf, strQuery)

                    Case "lvwBewertungen"
                        Call setProgressbarModus(frmMain.frmManage.pgrBewertungenUpdate, strQuery)

                    Case "lvwStatisticText"
                        Call setProgressbarModus(frmMain.frmManage.progStatistik, strQuery)
                        '  Case "lvwBestellungen_kunden"
                        '     Call setProgressbarModus(frmMain.frmManage.progStatistik, strQuery)
                    Case Else
                        bOut = True ' Es gibt keine Progressbar 
                End Select


                '# Lesen aus der Datenbank 
                Dim iCount As Integer = 0
                While Not dbReader.Read() = False

                    iCount += 1

                    Application.DoEvents()

                    '# Ermöglicht das Abbrechen von allen Einlesevorgängen 
                    If bStopReadIn = True Then
                        frmMain.master_Message_label.Text = "Einlesevorgang wurde vom Benutzer '" & My.Settings.yabe_username & "' abgebrochen!"
                        lvwData.EndUpdate()
                        Exit While
                    End If

                    '# Prüfung ob der Modus für die Exakte Anzeige aktiv ist  + ob das Listview eine Progressbar hat 
                    If My.Settings.yabe_progress_exakt_mode = True And bOut = False Then
                        If pgr_global_aktiv.Maximum > pgr_global_aktiv.Value + 1 Then
                            pgr_global_aktiv.Value += 1
                        End If

                    End If

                    '    If Not lvwData.Items(iCount - 1).Text = Nothing Then

                    '  End If


                    '#################################
                    '# Daten abholen...
                    '#################################
                    If getListviewData(lvwData, dbReader, iCount, imgList) = False Then
                        MsgBox("Die Daten wurden nicht eingelesen!")
                    End If


                End While

                If lvwData.Items.Count > 0 Then
                    lvwData.Items(0).Selected = True
                End If

                '############################################
                '# Progressbar anzeige steuern
                '# - Formatieren der Listviews 
                '############################################
                Select Case lvwData.Name
                    '# eBay aktuelle Verkaufsliste 
                    Case "lvwEiSoCockpit"
                        frmMain.frmManage.pgreBayLiveUpdate.Style = ProgressBarStyle.Continuous
                        frmMain.frmManage.pgreBayLiveUpdate.Visible = False
                        Application.DoEvents()
                        lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                    '# Ebay Verlauf / History 
                    Case "lvwWebArtikel"
                        'frmMain.frmManage.lvwWebArtikel
                        lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                    'lvwData.Columns(3).Width = 70


                    Case "lvwBestellverwaltung_nach_artikel"
                        frmMain.frmManage.pgreBayVerlaufUpdate.Style = ProgressBarStyle.Continuous
                        frmMain.frmManage.pgreBayVerlaufUpdate.Visible = False
                        lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

                    ' lvwData.Columns(0).Width = 0
                    Case "lvMailStatus"
                        frmMain.frmManage.pgrMailstatusGesammt.Style = ProgressBarStyle.Continuous
                        frmMain.frmManage.pgrMailstatusGesammt.Visible = False
                        lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

                    Case "lvwKunden"
                        frmMain.frmManage.pgrKundenverlauf.Style = ProgressBarStyle.Continuous
                        frmMain.frmManage.pgrKundenverlauf.Visible = False
                        'lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                        lvwData.Columns(2).Width = 220

                    Case "lvwBewertungen"
                        frmMain.frmManage.pgrBewertungenUpdate.Style = ProgressBarStyle.Continuous
                        frmMain.frmManage.pgrBewertungenUpdate.Visible = False
                        'lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

                    Case "lvwStatisticText"
                        frmMain.frmManage.progStatistik.Style = ProgressBarStyle.Continuous
                        frmMain.frmManage.progStatistik.Visible = False

                    Case Else

                        If lvwData.Items.Count = 0 Then
                            lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        Else
                            'lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                            lvwData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                        End If

                End Select

            End If

            dbConnect.Close()

            strOutPut = dblSumme

            lvwData.EndUpdate()

        Catch ex As Exception
            lvwData.EndUpdate()
            dbConnect.Close()
            Call debug_message(ex, strQuery & vbCrLf & "getListviewData")
            Return False
        End Try

        Return True
    End Function

    Public Function getCMS_Menue_hasChildren(ByVal bChildren As Boolean, ByVal iID As Integer) As Boolean
        Dim strData As String = ""

        If bChildren = True Then
            strData = "Y"
        Else
            strData = "N"
        End If

        strQuery = "UPDATE tbl_menue SET hasChildren='" & strData & "' WHERE ID='" & iID & "'"
        Dim con As New MySql.Data.MySqlClient.MySqlConnection
        con.ConnectionString = dbConnect.ConnectionString
        con.Open()
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con)
        command.ExecuteNonQuery()

    End Function

    '########################################################################
    '# >>
    '########################################################################
    Public Function getCMS_Menue_tree_ids(ByVal parrent_id As Integer, ByVal ilevel As Integer) As Boolean


        strQuery = " SELECT * FROM tbl_menue WHERE Parent=" & parrent_id & " ORDER BY OrderIndex ASC"
        Dim dbCon2 As New MySql.Data.MySqlClient.MySqlConnection
        dbCon2.ConnectionString = dbConnect.ConnectionString
        dbCon2.Close()
        dbCon2.Open()
        Dim command_menue As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbCon2)
        Dim dbReader_menue As MySql.Data.MySqlClient.MySqlDataReader
        dbReader_menue = command_menue.ExecuteReader


        '# Gibt es einen Treffer
        If dbReader_menue.HasRows = True Then
            While Not dbReader_menue.Read() = False

                Dim strSpace As String = ""
                strMenueIDs &= dbReader_menue("ID").ToString & ","

                If dbReader_menue("hasChildren").ToString = "Y" Then
                    Call getCMS_Menue_tree_ids(dbReader_menue("ID").ToString, ilevel + 1)
                End If

            End While
            dbCon2.Close()
        End If
        dbCon2.Close()
    End Function

    '########################################################################
    '# >>
    '########################################################################
    Public Function getCMS_Menue_tree_import_shopste(ByVal parrent_id As Integer, ByRef lvw As ListView, ByVal ilevel As Integer, iShopKat As Integer) As Boolean


        strQuery = " SELECT * FROM tbl_menue WHERE Parent=" & parrent_id & " ORDER BY OrderIndex ASC"
        Dim dbCon2 As New MySql.Data.MySqlClient.MySqlConnection
        dbCon2.ConnectionString = dbConnect.ConnectionString
        dbCon2.Close()
        dbCon2.Open()
        Dim command_menue As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbCon2)
        Dim dbReader_menue As MySql.Data.MySqlClient.MySqlDataReader
        dbReader_menue = command_menue.ExecuteReader
        Dim strData() As String
        '# Gibt es einen Treffer
        If dbReader_menue.HasRows = True Then
            While Not dbReader_menue.Read() = False

                Dim strSpace As String = ""
                '# Hauptkategorie anlegen  
                Dim i As Integer = 0
                If ilevel > 0 Then

                    For i = 0 To ilevel * 5
                        strSpace &= " "
                    Next
                End If

                Application.DoEvents()

                getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=chk_shopste_eiso_category&eiso_shop_catid=" & dbReader_menue("ID").ToString & "&domain_id=" & My.Settings.domain_id, mgetUpdaterMessage.setShopsteCategories, True)
                Dim strHTTDATA() As String = strHTTPDataStore.Split("~")
                If strHTTDATA(0) = "0" Then
                    getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=set_shopste_category&shop_cat_title=" & dbReader_menue("Bezeichnung").ToString & "&domain_id=" & My.Settings.domain_id & "&shop_cat_id=" & iShopKat & "&eiso_shop_catid=" & dbReader_menue("ID").ToString, mgetUpdaterMessage.setShopsteCategories, True)
                    strData = strHTTPDataStore.Split("~")
                    strHTTDATA(1) = strData(0)
                End If

                frmMain.master_Message_label.Text = dbReader_menue("Bezeichnung")

                If dbReader_menue("hasChildren").ToString = "Y" Then

                    Call getCMS_Menue_tree_import_shopste(dbReader_menue("ID").ToString, lvw, ilevel + 1, strHTTDATA(1))
                End If

            End While
            dbCon2.Close()
        End If
        dbCon2.Close()
    End Function

    '########################################################################
    '# >>
    '########################################################################
    Public Function getCMS_Menue_tree(ByVal parrent_id As Integer, ByRef lvw As ListView, ByVal ilevel As Integer, ByVal strISO As String, Optional bSetAnzahl As Boolean = False) As Boolean


        strQuery = " SELECT * FROM tbl_menue WHERE Parent=" & parrent_id & " ORDER BY OrderIndex ASC"
        Dim dbCon2 As New MySql.Data.MySqlClient.MySqlConnection
        dbCon2.ConnectionString = dbConnect.ConnectionString
        dbCon2.Close()
        dbCon2.Open()
        Dim command_menue As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbCon2)
        Dim dbReader_menue As MySql.Data.MySqlClient.MySqlDataReader
        dbReader_menue = command_menue.ExecuteReader

        '# Gibt es einen Treffer
        If dbReader_menue.HasRows = True Then
            While Not dbReader_menue.Read() = False

                Dim strSpace As String = ""
                '# Hauptkategorie anlegen  
                Dim i As Integer = 0
                If ilevel > 0 Then

                    For i = 0 To ilevel * 5
                        strSpace &= " "
                    Next
                End If


                If bSetAnzahl = True Then
                    Dim dbCon3 As New MySql.Data.MySqlClient.MySqlConnection
                    dbCon3.ConnectionString = dbConnect.ConnectionString
                    dbCon3.Close()
                    dbCon3.Open()
                    strQuery = "SELECT count(*) as anzahl FROM tblGes WHERE Kategorie_neo='" & dbReader_menue("ID").ToString & "'"
                    Dim command_item_count As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbCon3)
                    Dim dbReader_item_count As MySql.Data.MySqlClient.MySqlDataReader
                    dbReader_item_count = command_item_count.ExecuteReader
                    '# Gibt es einen Treffer
                    If dbReader_item_count.HasRows = True Then
                        While Not dbReader_item_count.Read() = False
                            Dim dbCon4 As New MySql.Data.MySqlClient.MySqlConnection
                            dbCon4.ConnectionString = dbConnect.ConnectionString
                            dbCon4.Close()
                            dbCon4.Open()
                            strQuery = "UPDATE tbl_menue SET artikel_anzahl='" & dbReader_item_count("anzahl").ToString & "' WHERE ID='" & dbReader_menue("ID").ToString & "'"
                            Dim command_item_count2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbCon4)
                            command_item_count2.ExecuteNonQuery()
                            dbCon4.Close()
                            dbCon4.Dispose()
                        End While
                    End If
                    dbCon3.Close()
                    dbCon3.Dispose()
                End If


                'Kategorie_neo


                Application.DoEvents()
                Dim lvwItem As New ListViewItem
                lvwItem.BackColor = Color.Gainsboro
                lvwItem.Text = dbReader_menue("ID").ToString
                lvwItem.SubItems.Add(strSpace & dbReader_menue("Bezeichnung" & strISO).ToString)
                lvwItem.SubItems.Add(FormatNumber(dbReader_menue("Zugriffe").ToString, 0, , , TriState.True))
                lvwItem.SubItems.Add(dbReader_menue("delcampe_id").ToString)
                lvwItem.SubItems.Add(dbReader_menue("export_magento").ToString)
                lvwItem.SubItems.Add(dbReader_menue("Parent").ToString)
                lvwItem.SubItems.Add(dbReader_menue("artikel_anzahl").ToString)
                lvwItem.SubItems.Add(dbReader_menue("shopste_catid").ToString)

                frmMain.master_Message_label.Text = dbReader_menue("Bezeichnung" & strISO)

                lvw.Items.Add(lvwItem)
                If dbReader_menue("hasChildren").ToString = "Y" Then
                    Call getCMS_Menue_tree(dbReader_menue("ID").ToString, lvw, ilevel + 1, strISO, bSetAnzahl)
                End If

            End While
            dbCon2.Close()
        End If
        dbCon2.Close()
    End Function
    '############################################################
    '# >> CMS Funktionalitäten 
    '############################################################
    Public Function getCMS_Menue(ByVal strQuery As String, ByRef lvw As ListView, ByVal strSprache As String, Optional ByVal bSetUpdateItemCounts As Boolean = False) As Boolean
        Try

            lvw.Items.Clear()
            dbConnect.Close()
            dbConnect.Open()
            lvw.BeginUpdate()
            '# ALLE KATEGORIEN ANZEIGEN
            Dim lvwItem1 As New ListViewItem
            lvwItem1.BackColor = Color.GhostWhite
            lvwItem1.Text = "-1"
            lvwItem1.SubItems.Add("-- Alle Kategorien --")
            lvwItem1.SubItems.Add("---")
            lvwItem1.SubItems.Add("")
            lvwItem1.SubItems.Add("")
            lvwItem1.SubItems.Add("-23")
            lvw.Items.Add(lvwItem1)


            '# ALLE IMPORTIEREN ANZEIGEN
            Dim lvwItem3 As New ListViewItem
            lvwItem3.BackColor = Color.Gainsboro
            lvwItem3.Text = "-2"
            lvwItem3.SubItems.Add("Importieren")
            lvwItem3.SubItems.Add("---")
            lvwItem3.SubItems.Add("")
            lvwItem3.SubItems.Add("")
            lvwItem3.SubItems.Add("-23")
            lvw.Items.Add(lvwItem3)
            Dim strISO As String = ""
            strISO = clsDatenbank_modul.getTranslate_l18n_mapping(strSprache)
            Call getCMS_Menue_tree(0, lvw, 0, strISO, bSetUpdateItemCounts)



            'Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection()
            'dbConnect2.ConnectionString = dbConnect.ConnectionString
            'Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            'dbReader = command.ExecuteReader

            ''# Gibt es einen Treffer
            'If dbReader.HasRows = True Then

            '    '# ALLE KATEGORIEN ANZEIGEN
            '    Dim lvwItem1 As New ListViewItem
            '    lvwItem1.BackColor = Color.GhostWhite
            '    lvwItem1.Text = "-1"
            '    lvwItem1.SubItems.Add("-- Alle Kategorien --")
            '    lvwItem1.SubItems.Add("---")
            '    lvwItem1.SubItems.Add("")
            '    lvwItem1.SubItems.Add("")
            '    lvwItem1.SubItems.Add("-23")
            '    lvw.Items.Add(lvwItem1)


            '    '# ALLE IMPORTIEREN ANZEIGEN
            '    Dim lvwItem3 As New ListViewItem
            '    lvwItem3.BackColor = Color.Gainsboro
            '    lvwItem3.Text = "-2"
            '    lvwItem3.SubItems.Add("Importieren")
            '    lvwItem3.SubItems.Add("---")
            '    lvwItem3.SubItems.Add("")
            '    lvwItem3.SubItems.Add("")
            '    lvwItem3.SubItems.Add("-23")
            '    lvw.Items.Add(lvwItem3)

            '    '# Sprache bestimmen
            '    Dim strISO As String = ""
            '    Dim strISO2 As String = ""
            '    strISO = clsDatenbank_modul.getTranslate_l18n_mapping(strSprache)

            '    Application.DoEvents()

            '    '# Lesen aus der Datenbank 
            '    While Not dbReader.Read() = False


            '        '# Hauptkategorie anlegen  
            '        If dbReader("Child").ToString = "0" Then
            '            Dim lvwItem As New ListViewItem
            '            lvwItem.BackColor = Color.Gainsboro
            '            lvwItem.Text = dbReader("ID").ToString
            '            lvwItem.SubItems.Add(dbReader("Bezeichnung" & strISO).ToString)
            '            lvwItem.SubItems.Add(FormatNumber(dbReader("Zugriffe").ToString, 0, , , TriState.True))
            '            lvwItem.SubItems.Add(dbReader("delcampe_id").ToString)
            '            lvwItem.SubItems.Add(dbReader("export_magento").ToString)
            '            lvwItem.SubItems.Add(dbReader("Parent").ToString)
            '            lvwItem.SubItems.Add(dbReader("artikel_anzahl").ToString)

            '            lvw.Items.Add(lvwItem)

            '        Else '# Unterkategorien 
            '            Application.DoEvents()
            '            frmMain.master_Message_label.Text = "Lade Kategorie: " & dbReader("Bezeichnung").ToString


            '            Dim lvwItem2 As New ListViewItem
            '            lvwItem2.BackColor = Color.WhiteSmoke
            '            lvwItem2.Text = dbReader("ID").ToString
            '            lvwItem2.SubItems.Add(" >> " & dbReader("Bezeichnung" & strISO).ToString)
            '            lvwItem2.SubItems.Add(FormatNumber(dbReader("Zugriffe").ToString, 0, , , TriState.True))
            '            lvwItem2.SubItems.Add(dbReader("delcampe_id").ToString)
            '            lvwItem2.SubItems.Add(dbReader("export_magento").ToString)
            '            lvwItem2.SubItems.Add("-1")
            '            lvwItem2.SubItems.Add(dbReader("artikel_anzahl").ToString)
            '            lvw.Items.Add(lvwItem2)

            '            If bSetUpdateItemCounts = True Then
            '                Dim iAnzahl As Integer = getCMS_MenueItem_anzahl(dbReader("ID").ToString)
            '                setCMSItem_count(dbReader("ID").ToString, iAnzahl)
            '            End If
            '        End If



            '    End While

            'End If

            lvw.EndUpdate()

        Catch ex As Exception
            lvw.EndUpdate()
            Call debug_message(ex, strQuery & vbCrLf & "getKategorieList")
            Return True
        End Try

        Return True
    End Function

    '################################################################
    '# >> Anzahl auslesen 
    '################################################################
    Public Function getCMS_MenueItem_anzahl(ByVal iID As Integer) As Integer
        Try

            strQuery = "SELECT count(*) as anzahl FROM tblGes WHERE Kategorie_neo='" & iID & "'"
            Dim con As New MySql.Data.MySqlClient.MySqlConnection
            con.ConnectionString = dbConnect.ConnectionString
            con.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            Dim iAnzahl As Integer = 0
            reader = command.ExecuteReader()
            If reader.HasRows = True Then

                While reader.Read = True
                    iAnzahl = reader("anzahl")

                End While
            End If
            con.Close()
            Return iAnzahl
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getMenue_anzahl")
        End Try
    End Function



    '################################################################
    '# >> Suchen und ersetzen 
    '################################################################
    Public Function getTranslateSearch_replace(ByVal strText As String, ByVal strSprache As String) As String
        Try


            dbConnect.Close()
            dbConnect.Open()
            'Call setChangeDB(datenbankzugriff.CMS)


            strQuery = "SELECT * FROM yabe_translate_search_replace WHERE sprache='" & strSprache & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then

                While reader.Read = True
                    strText = strText.Replace(reader("suche").ToString, reader("ersetze").ToString)
                End While

            End If

            dbConnect.Close()

            Return strText
        Catch ex As Exception
            Call debug_message(ex, "getTranslateSearch_replace")
            Return "-1"
        End Try
    End Function

    '################################################################
    '# >> setWebArtikel_update_replace
    '################################################################
    Public Function setWebArtikel_update_replace(ByVal strSprache As String, ByVal strWebID As String, ByVal strBeschreibungNeu As String) As Boolean
        Try
            Dim strISO As String = ""

            '# Sprachfeld ermitteln 
            strISO = clsDatenbank_modul.getTranslate_l18n_mapping(strSprache)

            strQuery = "UPDATE tblGes SET "
            strQuery &= "Beschreibung" & strISO & "='" & strBeschreibungNeu.Replace("'", "\'") & "'"
            strQuery &= "WHERE ID ='" & strWebID & "'"

            dbConnect.Close()
            dbConnect.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setWebArtikel_update_replace")
            Return False
        End Try
    End Function

    '#######################################################
    '# >> setWebArtikel
    '#######################################################
    Public Function setWebArtikel_übernahme(ByVal frm As frmCMS_Item2Shop, ByVal bUpdate As Boolean) As Boolean
        Dim strQuery As String = ""
        Dim strZiel As String = ""
        Dim strQuelle As String = ""
        Dim strTranslated_eng As String = ""
        Dim strTranslated_fr As String = ""
        Try

            '######################################
            '# >> UPDATE 
            '######################################
            If bUpdate = True Then



                '######################################
                '# >> INSERT 
                '######################################
            Else

                '# Default Übersetzung Holen 
                strTranslated_eng = getTranslateText(frm.txtQuelle.Text, "de", "en")
                Application.DoEvents()
                frm.message.Text = "Englisch: " & strTranslated_eng

                strTranslated_fr = getTranslateText(frm.txtQuelle.Text, "de", "fr")
                Application.DoEvents()
                frm.message.Text = "Französisch: " & strTranslated_eng

                strQuery = "INSERT INTO tblGes(Beschreibung,anzahl,Beschreibung_eng,Beschreibung_fr,Preis,Bild,Datum,Uhrzeit,Kategorie_neo) VALUES("


                strQuery &= "'" & frm.txtQuelle.Text & "',"
                strQuery &= "'" & frm.txtAnzahl.Text & "',"
                strQuery &= "'" & strTranslated_eng & "',"
                strQuery &= "'" & strTranslated_fr & "',"
                strQuery &= "'" & frm.txtPreis.Text.Replace(",", ".") & "',"
                strQuery &= "'" & frm.txtBildURL.Text & "',"
                strQuery &= "'" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "',"
                strQuery &= "'" & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "',"

                If frm.lvwMenue.SelectedItems.Count > 0 Then
                    If frm.lvwMenue.SelectedItems(0).Text > 0 Then
                        strQuery &= "'" & frm.lvwMenue.SelectedItems(0).Text & "') "
                    Else
                        MsgBox("Es wurde keine Kategorie ausgewählt", MsgBoxStyle.Critical)
                        Return False
                    End If
                Else
                    MsgBox("Es wurde keine Kategorie ausgewählt", MsgBoxStyle.Critical)
                    Return False
                End If

            End If

            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()
            Return True

        Catch ex As Exception

            Call debug_message(ex, strQuery & vbCrLf & "setWebArtikel_übernahme")
            Return False
        End Try
    End Function

    '#######################################################
    '# >> setWebArtikel
    '#######################################################
    Public Function setWebArtikel(ByVal frm As frmCMS_change_item, ByVal bUpdate As Boolean) As Boolean
        Dim strQuery As String = ""
        Dim strZiel As String = ""
        Dim strQuelle As String = ""

        Try

            '######################################
            '# >> UPDATE 
            '######################################
            If bUpdate = True Then

                Dim strISO As String = ""
                Dim strISO2 As String = ""
                strISO = clsDatenbank_modul.getTranslate_l18n_mapping(frm.cmbErstsprache.Text)
                strISO2 = clsDatenbank_modul.getTranslate_l18n_mapping(frm.cmbZweitSprache.Text)

                strQuery = "UPDATE tblGes set "

                strQuery &= "Beschreibung" & strISO & "='" & frm.txtQuelle.Text.Replace("'", "\'") & "',"
                strQuery &= "Beschreibung" & strISO2 & "='" & frm.txtZiel.Text.Replace("'", "\'") & "',"

                strQuery &= "Preis ='" & frm.txtPreis.Text & "',"
                strQuery &= "anzahl ='" & frm.txtAnzahl.Text & "',"
                strQuery &= "Datum ='" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "',"
                strQuery &= "Uhrzeit ='" & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "',"
                strQuery &= "Bestellt='" & frm.cmbItemStatus.SelectedIndex & "',"
                strQuery &= "Kategorie_neo  =" & frm.lvwMenue.SelectedItems(0).Text & ","
                'strQuery &= "Bild  ='" & My.Settings.shop_url & frm.txtBildURL.Text & "' "
                strQuery &= "Bild  ='" & frm.txtBildURL.Text & "' "
                strQuery &= "WHERE ID ='" & frm.lblID.Text & "' "

                '######################################
                '# >> INSERT 
                '######################################
            Else

                strQuery = "INSERT INTO tblGes(Beschreibung,Beschreibung_eng,Beschreibung_fr,Preis,anzahl,Bild,Datum,Uhrzeit,Bestellt,Kategorie_neo) VALUES("


                Dim strTranslated As String = getTranslateText(frm.txtQuelle.Text, "de", clsDatenbank_modul.getLanuage2GoogleCode("Englisch"))

                Select Case frm.cmbErstsprache.SelectedIndex
                    '# Deutsch -> Englisch
                    Case 0
                        strQuery &= "'" & frm.txtQuelle.Text.Replace("'", "\'") & "',"
                        '# Übersetzt ? 
                        If frm.txtZiel.Text.Length > 0 Then
                            strQuery &= "'" & frm.txtZiel.Text.Replace("'", "\'") & "',"
                        Else
                            strQuery &= "'" & getTranslateText(frm.txtQuelle.Text, "de", clsDatenbank_modul.getLanuage2GoogleCode("Englisch")) & "',"
                        End If

                        strQuery &= "'" & getTranslateText(frm.txtQuelle.Text, "de", clsDatenbank_modul.getLanuage2GoogleCode("Französisch")) & "',"
                    '# Deutsch -> Französisch
                    Case 1
                        strQuery &= "'" & frm.txtQuelle.Text.Replace("'", "\'") & "',"
                        strQuery &= "'" & getTranslateText(frm.txtQuelle.Text, "de", clsDatenbank_modul.getLanuage2GoogleCode("Englisch")) & "',"
                        If frm.txtZiel.Text.Length > 0 Then
                            strQuery &= "'" & frm.txtZiel.Text.Replace("'", "\'") & "',"
                        Else
                            strQuery &= "'" & getTranslateText(frm.txtQuelle.Text, "de", clsDatenbank_modul.getLanuage2GoogleCode("Französisch")) & "',"
                        End If

                    '# Englisch -> Französisch
                    Case 2
                        strQuery &= "'',"
                        strQuery &= "'" & frm.txtQuelle.Text.Replace("'", "\'") & "',"
                        If frm.txtZiel.Text.Length > 0 Then
                            strQuery &= "'" & frm.txtZiel.Text.Replace("'", "\'") & "',"
                        Else
                            strQuery &= "'" & getTranslateText(frm.txtQuelle.Text, "de", clsDatenbank_modul.getLanuage2GoogleCode("Französisch")) & "',"
                        End If


                End Select

                strQuery &= "'" & frm.txtPreis.Text.Replace(",", ".") & "',"
                strQuery &= "'" & frm.txtAnzahl.Text & "',"
                strQuery &= "'" & frm.txtBildURL.Text & "',"
                strQuery &= "'" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "',"
                strQuery &= "'" & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "',"
                strQuery &= "'" & frm.cmbItemStatus.SelectedIndex & "',"
                If frm.setKategorie > 0 Then
                    strQuery &= "'" & frm.setKategorie & "') "
                Else
                    MsgBox("Es wurde keine Kategorie ausgewählt", MsgBoxStyle.Critical)
                    Return False
                End If

            End If

            dbConnect.Close()
            dbConnect.Open()
            'dbConnect.ChangeDatabase("db_u10097_01")
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()
            Return True

        Catch ex As Exception

            Call debug_message(ex, strQuery & vbCrLf & "setWebArtikel")
            Return False
        End Try
    End Function

    '######################################################################
    '# >> Artikelstatus ändern 
    '######################################################################
    Public Function setWebartikelStatus(ByVal iStatus As Integer, ByVal iID As Integer) As Boolean
        Dim strQuery As String = ""
        Try

            dbConnect.Close()
            dbConnect.Open()

            strQuery = "UPDATE tblGes SET Bestellt='" & iStatus & "',Datum='" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "' WHERE ID=" & iID
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()
            dbConnect.Close()
            'Call setChangeDB(datenbankzugriff.YABE)

        Catch ex As Exception
            'Call setChangeDB(datenbankzugriff.YABE)
            Call debug_message(ex, strQuery & vbCrLf & "setWebartikelStatus")
            Return False
        End Try
        Return True
    End Function

    '###################################################################################################
    '# >> Umsätze ermitteln + Plattformen
    '###################################################################################################
    Public Function geteBayUmsatzMonth(ByRef lvwData As ListBox, ByVal plattform As String) As String
        Dim strQuery As String = ""
        Dim strPlattform As String = ""
        Try

            dbConnect.Close()
            dbConnect.Open()

            Select Case plattform
                Case "eBay"
                    strPlattform = " AND auction_type='" & plattform & "'"
                Case "Delcampe"
                    strPlattform = " AND auction_type='delcampe'"
                Case "Shopsysteme"
                    strPlattform = " AND auction_type='CMS'"
            End Select
            strQuery = "SELECT SUM(current_price)as summe,month(auction_end) as name, YEAR(auction_end) as jahr FROM yabe_auction_list_history WHERE status != 'Storniert' AND email != '---' AND email != '' " & strPlattform & " GROUP BY YEAR(auction_end), MONTH(auction_end) ORDER BY auction_end DESC LIMIT 0,12"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then

                While reader.Read()
                    'strSumme = reader("summe")
                    lvwData.Items.Add(reader("summe") & "|" & reader("name") & "|" & reader("jahr"))
                End While

                dbConnect.Close()
                'Return strSumme
            End If

            Return ""
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "geteBayUmsatzMonth")
            Return "-1"
        End Try

    End Function

    '###################################################################
    '# >> Löschen einer Bestellung
    '###################################################################
    Public Function setDeleteOrder(ByVal Id As String, ByVal email As String) As Boolean
        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "DELETE "
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setDeleteOrder" + strQuery)
            Return False
        End Try
    End Function

    '###################################################################
    '# >> SQL Anfrage auf dem CMS ausführen
    '###################################################################
    Public Function getCMS_Query(ByVal strQuery As String) As String
        Dim strData As String = ""
        Dim iAnzahl As Integer = 0
        Try

            dbConnect.Close()
            dbConnect.Open()

            'Call setChangeDB(datenbankzugriff.CMS)

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then
                reader.Read()
                strData = reader("anzahl")
                iAnzahl = Convert.ToInt16(strData)
            End If
            'Call setChangeDB(datenbankzugriff.YABE)
            dbConnect.Close()
            Return iAnzahl
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getCMS_Query")
            Return "-1"
        End Try

    End Function

    '###################################################################
    '# >> Kategorien holen 
    '###################################################################
    Public Function getCMS_catCount(ByVal iCat As Integer, Optional ByVal strWhere As String = "") As String
        Dim strQuery As String = ""
        Dim strData As String = ""
        Try

            dbConnect.Close()
            dbConnect.Open()
            'Call setChangeDB(datenbankzugriff.CMS)


            strQuery = "SELECT * FROM tbl_menue where ID=" & iCat & " " & strWhere
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then

                reader.Read()


                strData = reader("artikel_anzahl")
            End If

            'Call setChangeDB(datenbankzugriff.YABE)
            dbConnect.Close()

            Return strData
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getCMS_catCount")
            Return "-1"
        End Try

    End Function

    '##############################################################################
    '# >> Löschen einer Shop Kategorie 
    '##############################################################################
    Public Function setCMSMenue_delete(ByVal id As Integer) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()

            strQuery = "DELETE FROM tbl_menue WHERE ID=" & id

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setCMSMenue_delete")
            Return False
        End Try
    End Function

    '##############################################################################
    '# >> Kategorie Child bestimmen
    '##############################################################################
    Public Function getMenue_childID(ByVal iID As Integer) As Integer
        Try
            Dim strData As Integer

            dbConnect.Close()
            dbConnect.Open()

            strQuery = "SELECT Child FROM tbl_menue where ID=" & iID
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then

                reader.Read()


                strData = reader("Child")
                dbConnect.Close()
            End If

            Return strData
        Catch ex As Exception
            Call debug_message(ex, "getMenue_childID")
            Return False
        End Try
    End Function

    '##############################################################################
    '# >> Kategorie Update by Child 
    '##############################################################################
    Public Function setMenue_updateChild(ByVal iCat As Integer, ByVal iChildNow As Integer, ByVal strModus As String) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()

            Select Case strModus
                Case "runter"
                    iChildNow -= 1
                Case "hoch"
                    iChildNow += 1
            End Select

            strQuery = "UPDATE tbl_menue SET Child = " & iChildNow & "  WHERE `ID`=" & iCat

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()

        Catch ex As Exception
            Call debug_message(ex, "setMenue_updateChild")
            Return False
        End Try
    End Function

    '##############################################################################
    '# >> Kategorie - Parrent Child abfrage
    '##############################################################################
    Public Function getMenue_byParrentChild(ByVal iParrent As Integer, ByVal iChild As Integer) As Integer
        Try
            Dim strData As Integer

            dbConnect.Close()
            dbConnect.Open()

            strQuery = "SELECT ID FROM tbl_menue where Parent=" & iParrent & " AND Child=" & iChild
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then

                reader.Read()


                strData = reader("ID")
                dbConnect.Close()
            End If

            Return strData
        Catch ex As Exception
            Call debug_message(ex, "getMenue_byParrentChild")
            Return -1
        End Try
    End Function
    '##############################################################################
    '# >> Sortieren der Kategorien
    '##############################################################################
    Public Function setMenue_order(ByVal iId As Integer, ByVal strModus As String) As Boolean
        Try

            '# Parrent ID bestimmen 
            Dim iParrent As Integer = getCMSParent(iId)

            '# Höchster Child in Parrent 
            Dim iChild_highest As Integer = getCMSMenue_highestChild2(iParrent)

            Dim iChildNow As Integer = getMenue_childID(iId)

            '# Modus Bestimmen 
            Select Case strModus
                Case "runter"

                    If Not iChildNow = iChild_highest Then
                        Dim iCatNow = getMenue_byParrentChild(iParrent, iChildNow + 1)
                        setMenue_updateChild(iId, iChildNow, "hoch")

                        setMenue_updateChild(iCatNow, iChildNow + 1, "runter")
                    End If

                Case "hoch"

                    If Not iChildNow = 1 Then
                        Dim iCatNow As Integer = getMenue_byParrentChild(iParrent, iChildNow - 1)
                        setMenue_updateChild(iId, iChildNow, "runter")

                        setMenue_updateChild(iCatNow, iChildNow - 1, "hoch")
                    End If

            End Select

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setMenue_order")
            Return False
        End Try
    End Function

    Public Function setCMS_import_delete() As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()

            strQuery = "DELETE FROM tblGes WHERE Bestellt=3"


            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()
        Catch ex As Exception

        End Try
    End Function
    '##############################################################################
    '# >> Umbennen einer Shop Kategorie 
    '##############################################################################
    Public Function setCMSMenueName(ByVal strName As String, ByVal iIndex As Integer, ByVal strSprache As String) As Boolean
        Try
            dbConnect.Close()
            dbConnect.Open()


            strQuery = "UPDATE tbl_menue SET Bezeichnung" & strSprache & "='" & strName & "' WHERE ID=" & iIndex
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()
            Return True
        Catch ex As Exception
            Call debug_message(ex, "setCMSMenueName")
            Return False
        End Try
    End Function

    '###########################################################################
    '# >> Newsletter Modus zurücksetzen 
    '###########################################################################
    Public Function setNewsletter_reset() As Boolean
        Dim strQuery As String = ""

        Try

            strQuery = "UPDATE yabe_personals_profile SET letzte_mail='N'"
            dbConnect.Close()
            dbConnect.Open()

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command.ExecuteNonQuery()

            dbConnect.Close()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setNewsletter_reset")
            Return False
        End Try

    End Function

    '#######################################################
    '# >> Combobox der Sprache umwandeln zu Tabellen ID Feld
    '########################################################
    Public Function getComboMailtextTranslation2ID(ByVal strText As String) As Integer
        Dim i As Integer
        Try

            dbConnect.Close()
            dbConnect.Open()
            'Call setChangeDB(datenbankzugriff.CMS)


            strQuery = "SELECT * FROM yabe_tbl_email_vorlage WHERE Bereich='" & strText & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then
                reader.Read()
                i = reader("ID")
                dbConnect.Close()
                Return i
            Else
                dbConnect.Close()
                Return -1
            End If

        Catch ex As Exception
            Return -1
        End Try
    End Function

    '######################################################
    '# >> YABE Plattformen abrufen 
    '######################################################
    Public Function getPlattforms() As String()
        Dim strPlattforms() As String
        Try
            ReDim strPlattforms(10)

            strQuery = "SELECT * FROM yabe_plattforms ORDER BY Orderid ASC"
            Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            dbConnect2.Close()
            dbConnect2.Open()
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect2)
            Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
            dbReader2 = command2.ExecuteReader()

            If dbReader2.HasRows = True Then
                Dim iCount As Integer = 0
                While dbReader2.Read = True
                    'Application.DoEvents()
                    strPlattforms(iCount) = dbReader2("Name")
                    iCount += 1
                End While

            End If

            Return strPlattforms
        Catch ex As Exception
            Call debug_message(ex, "getPlattforms")
            Return strPlattforms
        End Try

    End Function
    '###########################################################################################
    '# >> Mapping für die Sprachtabelle holen  
    '###########################################################################################
    Public Function getTranslate_l18n_mapping(ByVal cmbSprache As String) As String
        Try
            Dim strFieldMapping As String = ""

            If Not cmbSprache = "Deutsch" Then
                strQuery = "SELECT * FROM yabe_tbl_email_vorlage_sprachen WHERE Name='" & cmbSprache & "'"
                Dim dbConnect2 As New MySql.Data.MySqlClient.MySqlConnection(clsDatenbank_modul.dbConnect.ConnectionString)
                dbConnect2.Close()
                dbConnect2.Open()
                Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect2)
                Dim dbReader2 As MySql.Data.MySqlClient.MySqlDataReader
                dbReader2 = command2.ExecuteReader()

                If dbReader2.HasRows = True Then
                    dbReader2.Read()
                    strFieldMapping = "_" & dbReader2("ISO")
                    dbConnect2.Close()
                End If
            End If

            Return strFieldMapping
        Catch ex As Exception
            Call debug_message(ex, "getTranslate_l18n_mapping")
            Return "-1"
        End Try
    End Function

    '################################################################################
    '# >>  Datengrid füllen
    '################################################################################
    Public Function setDataGrid(ByRef datagrid As DataGridView, ByVal strQuery As String, ByRef tblMisc As DataSet, ByRef da As MySql.Data.MySqlClient.MySqlDataAdapter) As Boolean
        Try
            ' Dim myData As New DataTable

            Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)

            tblMisc.Clear()

            dbConnect.Close()
            dbConnect.Open()


            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            da.SelectCommand = command2
            tblMisc.Clear()
            'datagrid.Columns.Clear()
            da.Fill(tblMisc, "Table1")


            ' write dataset contents to an xml file by calling WriteXml method
            ' Attach DataSet to DataGrid

            datagrid.DataSource = tblMisc.Tables(0)
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Catch ex As Exception

        End Try
    End Function
    '################################################################################
    '# >>  Sprachgruppen einlesen 
    '################################################################################
    Public Function getComboShopGroups(ByRef cmb As ComboBox) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()
            cmb.Items.Clear()

            strQuery = "SELECT distinct  `Bereich`  FROM tbl_misc_Texte"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()

            cmb.Items.Add("Alle")

            If reader.HasRows = True Then

                While Not reader.Read() = False
                    Dim cmbItem As New ComboBox
                    cmb.Items.Add(reader("Bereich").ToString)
                End While
                dbConnect.Close()
                Return True
            Else
                dbConnect.Close()
                Return -1
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, getComboShopGroups)
            Return False
        End Try
    End Function

    '################################################################################
    '# >>  Sprache 2 Combobox
    '################################################################################
    Public Function getComboVersandkosten(ByRef cmb As ComboBox) As Boolean
        Try
            dbConnect.Close()
            dbConnect.Open()
            cmb.Items.Clear()

            strQuery = "SELECT * FROM yabe_order_shippment_method"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then
                Application.DoEvents()
                While Not reader.Read() = False
                    Dim cmbItem As New ComboBox
                    'cmb.Items.Add(reader("name_de").ToString & " " & reader("price").ToString & "EUR")

                    cmb.Items.Add(New MyListItem(reader("name_de").ToString & " " & reader("price").ToString & "EUR", reader("order_shippment_method_id")))

                End While
                dbConnect.Close()
                Return True
            Else
                dbConnect.Close()
                Return -1
            End If

        Catch ex As Exception
            Call debug_message(ex, "getComboSprachen")
            Return -1
        End Try
    End Function


    '################################################################################
    '# >>  Sprache 2 Combobox
    '################################################################################
    Public Function getComboVersandkosten_preis(strShippmentID As String) As Double
        Try
            Dim dblPreis As Double = 0
            dbConnect.Close()
            dbConnect.Open()

            strQuery = "SELECT * FROM yabe_order_shippment_method WHERE order_shippment_method_id='" & strShippmentID & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then
                Application.DoEvents()
                While Not reader.Read() = False
                    dblPreis = Convert.ToDouble(reader("price").ToString)
                End While
                dbConnect.Close()
                '   Return True
            Else
                dbConnect.Close()
                Return 0
            End If
            Return dblPreis
        Catch ex As Exception
            Call debug_message(ex, "getComboSprachen")
            Return 0
        End Try
    End Function

    '################################################################################
    '# >>  Sprache 2 Combobox
    '################################################################################
    Public Function getComboSprachen(ByRef cmb As ComboBox) As Boolean
        Try
            dbConnect.Close()
            dbConnect.Open()
            cmb.Items.Clear()

            strQuery = "SELECT * FROM yabe_tbl_email_vorlage_sprachen"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then
                Application.DoEvents()
                While Not reader.Read() = False
                    Dim cmbItem As New ComboBox
                    cmb.Items.Add(reader("Name").ToString)
                End While
                dbConnect.Close()
                Return True
            Else
                dbConnect.Close()
                Return -1
            End If

        Catch ex As Exception
            Call debug_message(ex, "getComboSprachen")
            Return -1
        End Try
    End Function

    '################################################################################
    '# >>  Mailtext vorlage einfügen 
    '################################################################################
    Public Function getComboGroups(ByRef cmb As ComboBox) As Boolean
        Try
            dbConnect.Close()
            dbConnect.Open()
            cmb.Items.Clear()

            strQuery = "SELECT DISTINCT yabe_function FROM yabe_tbl_email_vorlage ORDER BY yabe_function ASC"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()
            If reader.HasRows = True Then

                While Not reader.Read() = False
                    cmb.Items.Add(reader("yabe_function"))
                End While
                dbConnect.Close()
                Return True
            Else
                dbConnect.Close()
                Return -1
            End If

        Catch ex As Exception
            Call debug_message(ex, "getComboGroups")
            Return -1
        End Try
    End Function


    '################################################################################
    '# >>  Mailtext -> Vorlage Neu 
    '################################################################################
    Public Function setTranslate_vorlage_neu(ByVal strName As String, ByVal strBereich As String) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()
            '# Löschen nach Kopieren 
            strQuery = "INSERT INTO `yabe_tbl_email_vorlage` (`Text`, `Bereich`, `yabe_function`) VALUES ('Neue Vorlage', '" & strName & "', '" & strBereich & "');"
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command2.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setTranslate_vorlage_renamme")
            Return False
        End Try
    End Function
    '################################################################################
    '# >>  Mailtext -> Vorlage Umbennen
    '################################################################################
    Public Function setCustomer_Login(ByVal strEmail As String, ByVal strUsername As String) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()
            Dim strUsername_split() As String
            strUsername_split = strUsername.Split("(")
            '# Löschen nach Kopieren 
            strQuery = "UPDATE `yabe_personals_profile` set website_account='" & chkGetUsername(strUsername_split(0).Trim) & "',website_pwd='" & getRandomPwd(4) & "' WHERE email='" & strEmail & "';"
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command2.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setCustomer_muttersprache")
            Return False
        End Try
    End Function

    '################################################################################
    '# >>  Muttersprache setzten 
    '################################################################################
    Public Function setCustomer_muttersprache(ByVal strID As String, ByVal strSprache As String) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()
            '# Löschen nach Kopieren 
            strQuery = "UPDATE `yabe_personals_profile` set sprache='" & strSprache & "' WHERE email='" & strID & "';"
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command2.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setCustomer_muttersprache")
            Return False
        End Try
    End Function

    '################################################################################
    '# >>  Mailtext -> Vorlage Umbennen
    '################################################################################
    Public Function setTranslate_vorlage_renamme(ByVal strBereich As String, ByVal strBereichOld As String) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()
            '# Löschen nach Kopieren 
            strQuery = "UPDATE `yabe_tbl_email_vorlage` set Bereich='" & strBereich & "' WHERE Bereich='" & strBereichOld & "';"
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command2.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setTranslate_vorlage_renamme")
            Return False
        End Try
    End Function

    '################################################################################
    '# >>  Mailtext vorlage einfügen 
    '################################################################################
    Public Function setTranslate_vorlage_delete(ByVal strBereich As String) As Boolean
        Try

            dbConnect.Close()
            dbConnect.Open()
            '# Löschen nach Kopieren 
            strQuery = "DELETE FROM `yabe_tbl_email_vorlage` WHERE Bereich='" & strBereich & "';"
            Dim command2 As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            command2.ExecuteNonQuery()

            dbConnect.Close()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setTranslate_vorlage_delete")
            Return False
        End Try
    End Function

    '################################################################################
    '# >>  Mailtext vorlage einfügen 
    '################################################################################
    Public Function getComboEmailTextBereiche(ByRef cmb As ComboBox, ByVal strFunction As String) As Boolean
        Try
            Dim strWh As String = ""

            dbConnect.Close()
            dbConnect.Open()
            cmb.Items.Clear()

            If strFunction.Length > 0 Then
                strWh = "WHERE yabe_function='" & strFunction & "'"
            End If

            strQuery = "SELECT * FROM yabe_tbl_email_vorlage " & strWh & ";"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()



            If reader.HasRows = True Then

                While Not reader.Read() = False
                    cmb.Items.Add(reader("Bereich"))
                End While
                dbConnect.Close()
                Return True
            Else
                dbConnect.Close()
                Return -1
            End If

        Catch ex As Exception
            Call debug_message(ex, "getComboEmailTextBereiche")
            Return -1
        End Try
    End Function

    '################################################################################################
    '# >>  Artikelanzahl speichern 
    '################################################################################################
    Public Function setCMSItem_count(ByVal iCat As Integer, ByVal iCount As Integer) As Boolean
        Try


            strQuery = "UPDATE tbl_menue SET artikel_anzahl=" & iCount & " WHERE ID=" & iCat
            Dim con As New MySql.Data.MySqlClient.MySqlConnection(dbConnect.ConnectionString)
            con.Open()
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, con)
            command.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            Call debug_message(ex, "setCMSItem_count")
            Return False
        End Try
    End Function

    Public Function getCustomer_data(ByVal lvw As ListView) As Boolean
        Try
            strQuery = "SELECT * FROM yabe_personals_profile LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id" & " ORDER BY yabe_personals_adress.adress_lastupdate DESC"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()


            If reader.HasRows = True Then

                While Not reader.Read() = False
                    Select Case lvw.Name
                        Case "lvwKunden_YabE"
                            Dim lvwItem As New ListViewItem

                            lvw.Items.Add(lvwItem)
                    End Select
                End While
            End If
        Catch ex As Exception
            Call debug_message(ex, "getCustomer_data")
            Return False
        End Try
    End Function

    Public Function getSimilarItems(ByVal strData As String, strFieldMapping As String) As String(,)
        Dim strProccedData(3, 4) As String
        Dim iCount As Integer = 0

        dbConnect.Close()
        dbConnect.Open()
        strData = strData.Replace("""", "")
        Select Case strFieldMapping
            Case "_eng"
                strQuery = "SELECT * FROM tblGes WHERE MATCH (Beschreibung" & strFieldMapping & ") AGAINST (""" & strData & """ IN NATURAL LANGUAGE MODE) AND Bestellt=0 LIMIT 0,4;"
            Case "_fr"
                strQuery = "SELECT * FROM tblGes WHERE MATCH (Beschreibung" & strFieldMapping & ") AGAINST (""" & strData & """ IN NATURAL LANGUAGE MODE) AND Bestellt=0 LIMIT 0,4;"
            Case Else
                strQuery = "SELECT * FROM tblGes WHERE MATCH (Beschreibung" & strFieldMapping & ") AGAINST (""" & strData & """ IN NATURAL LANGUAGE MODE) AND Bestellt=0 LIMIT 0,4;"
        End Select

        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        reader = command.ExecuteReader()

        If reader.HasRows = True Then

            While Not reader.Read() = False
                strProccedData(iCount, 0) = reader("Beschreibung")
                strProccedData(iCount, 1) = reader("Preis")
                strProccedData(iCount, 2) = reader("Bild")
                strProccedData(iCount, 3) = reader("ID")
                strProccedData(iCount, 4) = reader("Beschreibung_eng")
                iCount += 1
            End While
        End If

        Return strProccedData
    End Function
    '#################################################################
    '# Bewertet - CMS Artikel + Bewertungen
    '#################################################################
    Public Function setBewertet_CMS(ByVal strID As String) As Boolean
        Try
            dbConnect.Close()
            dbConnect.Open()
            strQuery = "UPDATE yabe_auction_feedback set bIsFeedback='Y' WHERE eBay_ID='" & strID & "'"
            Dim cmd_update As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            cmd_update.ExecuteNonQuery()
            dbConnect.Close()

        Catch ex As Exception
            Call debug_message(ex, "setBewertet_CMS")
            Return False
        End Try
    End Function
    Public Function getCustomerLastOrder(ByVal strEmail As String) As String
        Dim strArtikel As String

        dbConnect.Close()
        dbConnect.Open()

        strQuery = "SELECT * FROM yabe_auction_list_history WHERE email ='" & strEmail & "' OR eBay_account='" & strEmail & "' ORDER BY auction_end DESC LIMIT 0,10"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        reader = command.ExecuteReader()

        If reader.HasRows = True Then

            While Not reader.Read() = False
                strArtikel &= reader("auction_title").ToString 'jb & alle Artikel


            End While
        Else
            strArtikel = ""
            Return strArtikel
        End If

        dbConnect.Close()
        Return strArtikel
    End Function

    Public Function setPaypalStatus(ByVal lvw As ListView) As Boolean
        Try

            Dim strEmail As String = lvw.Items(0).SubItems(2).Text

            dbConnect.Close()
            dbConnect.Open()

            strQuery = "SELECT *,MONTH(auction_end) as monat FROM yabe_auction_list_history WHERE email ='" & strEmail & " ORDER BY auction_end DESC"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader
            reader = command.ExecuteReader()

            If reader.HasRows = True Then

                While Not reader.Read() = False

                End While
            Else

            End If

        Catch ex As Exception
            Call debug_message(ex, "setPaypalStatus")
            Return False
        End Try
    End Function

    Public Function getInvioce_Nr() As Integer

        dbConnect.Close()
        dbConnect.Open()
        Dim strData As Integer
        strQuery = "SELECT * FROM yabe_rechnung_nr WHERE id=1"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        reader = command.ExecuteReader()

        If reader.HasRows = True Then

            While Not reader.Read() = False
                strData = reader("value")

            End While
        Else

        End If

        Return strData
    End Function

    Public Function getInvioce_Nr_update(ByVal iNr As Double) As Boolean
        dbConnect.Close()
        dbConnect.Open()
        strQuery = "UPDATE yabe_rechnung_nr  SET value=" & Convert.ToInt16(iNr) & " WHERE id=1"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        command.ExecuteNonQuery()
    End Function

    Public Function chkCockpitItemBidCount(streBayID As String, strBidcount As String) As String

        Dim strData As Integer
        dbConnect.Open()
        strQuery = "SELECT * FROM yabe_auction_list_live WHERE bids=" & strBidcount & " AND eBay_ID='" & streBayID & "'"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        reader = command.ExecuteReader()

        If reader.HasRows = True Then

            While Not reader.Read() = False
                strData = reader("bids")
            End While
        Else
            strData = "-1"
        End If
        dbConnect.Close()
        Return strData
    End Function

    Public Function setCockpitItemUpdate(streBayID As String, strCurrentPrice As String, strWatchCount As String, strHitCount As String, strBidderName As String, strBidderEmail As String, strBidCount As String) As Boolean
        dbConnect.Close()
        dbConnect.Open()
        strQuery = "UPDATE yabe_auction_list_live  SET current_price=" & strCurrentPrice & ",watchcount='" & strWatchCount & "', hitcounter='" & strHitCount & "',eBay_account='" & strBidderName & "', email='" & strBidderEmail & "', bids=" & strBidCount & "  WHERE eBay_ID='" & streBayID & "'"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, dbConnect)
        command.ExecuteNonQuery()
        dbConnect.Close()

        Return True
    End Function
End Class
