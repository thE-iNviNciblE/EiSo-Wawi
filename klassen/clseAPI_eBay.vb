Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util

Public Class clseAPI_eBay

    Public Context As ApiContext
    Public von As DateTimePicker
    Public bis As DateTimePicker
    Public iGlobalSeite As Short
    Public iProSeite As Integer
    Public strUserID As String
    Public lvw As ListView
    Public frmWait As New frmWait4Something

    Public iCount_insert As Integer = 0
    Public iCount_update As Integer = 0

    Private Enum datenmodus
        live = 0
        history = 1
    End Enum

    Public Enum strBildModus
        normal = 1
        alt = 2
        nochälter = 3
        yabe = 4
        ebay_neu = 5
    End Enum

    Public Function setSessionID()
        Dim gsc As GetSessionIDCall = New GetSessionIDCall(Context)


        'the rule name can be retrived from the app.config file, otherwise the user must input it himself.
        'Context.RuName = "YabE"
        Dim sessionID As String = gsc.GetSessionID("auth_tool_sdk_2b6b54516b704cef9b66447741d6689e")
        MsgBox(sessionID)
    End Function


    '#######################################################
    '# >> eBay Benutzerdaten abrufen 
    '#               
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
    '#######################################################
    Public Function geteBayUser(ByVal streBayID As String, ByVal strEbayUser As String) As ArrayList
        Dim aryKunde As New ArrayList
        Try

            Dim ApiCall As GetUserCall = New GetUserCall(Context)
            ApiCall.Site = SiteCodeType.Germany
            ApiCall.DetailLevelList = New DetailLevelCodeTypeCollection(New DetailLevelCodeType() {DetailLevelCodeType.ReturnAll})

            '# Mit Bewertungen übergeben 
            If strEbayUser.IndexOf(" ") > 0 Then
                Dim str() As String
                str = strEbayUser.Split(" ")
                ApiCall.UserID = str(0)
            Else
                ' ohne Bewertungen 
                ApiCall.UserID = strEbayUser
            End If

            If Not ApiCall.UserID = "1" Then

                ApiCall.ItemID = streBayID

                Dim user As UserType = ApiCall.GetUser()


                aryKunde.Add(user.UserID)

                Dim strTemp As String = ""

                '# Landesname 
                Try
                    strTemp = user.RegistrationAddress.CountryName.ToString
                    aryKunde.Add(strTemp)
                Catch ex As Exception
                    strTemp = ""
                    aryKunde.Add(strTemp)
                End Try

                '# Name 
                Try
                    strTemp = user.RegistrationAddress.Name.ToString
                    aryKunde.Add(strTemp)
                Catch ex As Exception
                    strTemp = ""
                    aryKunde.Add(strTemp)
                End Try

                '# eMail 
                Try
                    strTemp = user.Email
                    aryKunde.Add(strTemp)
                Catch ex As Exception
                    strTemp = ""
                    aryKunde.Add(strTemp)
                End Try

                '# Straße
                Try
                    strTemp = user.RegistrationAddress.Street
                    aryKunde.Add(strTemp)
                Catch ex As Exception
                    strTemp = ""
                    aryKunde.Add(strTemp)
                End Try

                '# PLZ
                Try
                    strTemp = user.RegistrationAddress.PostalCode
                    aryKunde.Add(strTemp)
                Catch ex As Exception
                    strTemp = ""
                    aryKunde.Add(strTemp)
                End Try

                '# Ort
                Try
                    strTemp = user.RegistrationAddress.CityName
                    aryKunde.Add(strTemp)
                Catch ex As Exception
                    strTemp = ""
                    aryKunde.Add(strTemp)
                End Try
            End If

            Return aryKunde
        Catch ex As Exception
            Call debug_message(ex, "geteBayUser")
            Return aryKunde
        End Try
    End Function

    '##################################################################
    '# >> Stellt die API Calls richtig ein 
    '# 
    '# Beschreibung: Fragt die eBay Verkäuferliste ab.
    '##################################################################
    Public Function setAPIContext() As ApiContext

        Context = New ApiContext()

        '########################################
        '# >> Produktiv / Sandbox 
        '########################################
        If My.Settings.ebay_sandbox = False Then
            Context.ApiCredential.ApiAccount.Developer = My.Settings.Production_devname
            Context.ApiCredential.ApiAccount.Application = My.Settings.Production_APPID
            Context.ApiCredential.ApiAccount.Certificate = My.Settings.Production_CERTID
            Context.ApiCredential.eBayToken = My.Settings.Production_ebaytoken
        Else
            Context.ApiCredential.ApiAccount.Developer = My.Settings.Sandbox_devname
            Context.ApiCredential.ApiAccount.Application = My.Settings.Sandbox_APPID
            Context.ApiCredential.ApiAccount.Certificate = My.Settings.Sandbox_CERTID
            Context.ApiCredential.eBayToken = My.Settings.Production_ebaytoken
        End If

        Context.ApiCredential.eBayAccount.UserName = My.Settings.ebay_username
        Context.ApiCredential.eBayAccount.Password = My.Settings.ebay_pwd


        If My.Settings.ebay_sandbox = False Then
            Context.SoapApiServerUrl = My.Settings.Production_SoapApiServerUrl
            Context.EPSServerUrl = "https://api.ebay.com/ws/api.dll"
        Else
            Context.SoapApiServerUrl = "https://api.sandbox.ebay.com/wsapi"
            Context.EPSServerUrl = "https://api.sandbox.ebay.com/ws/api.dll"
        End If

        'Context.SignInUrl = My.Settings.Production_SignInUrl
        'Context.EPSServerUrl = My.Settings.Production_EpsServerUrl
        Context.Version = My.Settings.Production_Version
        Context.Site = eBay.Service.Core.Soap.SiteCodeType.Germany
        Context.ErrorLanguage = ErrorLanguageCodeType.de_DE ' deutsche Fehlermeldungen

        ' set the CallRetry properties
        Dim oCallRetry As CallRetry = New CallRetry
        ' set the delay between each retry to 1 millisecond
        oCallRetry.DelayTime = 1000
        ' set the maximum number of retries
        oCallRetry.MaximumRetries = 10
        ' set the error codes on which to retry
        Dim oErrorCodes As StringCollection = New StringCollection
        oErrorCodes.Add("10007")
        oErrorCodes.Add("2")
        oErrorCodes.Add("251")
        oCallRetry.TriggerErrorCodes = oErrorCodes
        ' set the exception types on which to retry
        Dim oExceptions As TypeCollection = New TypeCollection
        oExceptions.Add(GetType(System.Net.ProtocolViolationException))
        ' the "Client found response content type of 'text/plain'" exception is of type SdkException, so let's add that to the list
        oExceptions.Add(GetType(SdkException))
        oCallRetry.TriggerExceptions = oExceptions

        ' set CallRetry back to ApiContext
        Context.CallRetry = oCallRetry

        ' MsgBox(strINI_eBay.strLogFileName)
        Context.ApiLogManager = New ApiLogManager()
        Context.ApiLogManager.ApiLoggerList.Add(New FileLogger(Application.StartupPath & "\LOG\API_XML_Export.txt", True, True, True))
        Context.ApiLogManager.EnableLogging = My.Settings.eBay_APILog   ' globale Var (Konfig)
        Context.Site = eBay.Service.Core.Soap.SiteCodeType.Germany
        Context.Timeout = 240000 'Convert.ToInt32(strINI_eBay.strTimeOut)

        Return Context

    End Function

    '################################################
    '# >> eBay Zeit holen 
    '################################################
    Public Function geteBayTime()

        Dim apicall As GeteBayOfficialTimeCall = New GeteBayOfficialTimeCall(Context)
        Return apicall.GeteBayOfficialTime()

    End Function

    Sub New(Optional ByVal test As String = "")

    End Sub

    '##################################################################
    '# >> eBay Rechnungen 
    '##################################################################
    Public Function geteBayRechnungen() As Boolean

        Try
            frmMain.frmManage.lvwEbayRechnung.BeginUpdate()
            frmMain.frmManage.lvwEbayRechnung.Items.Clear()
            frmMain.frmManage.TxtAccBalance.Text = ""
            frmMain.frmManage.TxtAccState.Text = ""
            frmMain.frmManage.TxtPayMethod.Text = ""

            Context = clseBayAPI.setAPIContext()

            Application.DoEvents()

            Dim apicall As GetAccountCall = New GetAccountCall(Context)
            Dim seltype As AccountHistorySelectionCodeType = AccountHistorySelectionCodeType.CustomCode

            If frmMain.frmManage.OptLastInvoice.Checked = True Then
                seltype = AccountHistorySelectionCodeType.LastInvoice
            ElseIf frmMain.frmManage.OptInvoiceDate.Checked = True Then
                seltype = AccountHistorySelectionCodeType.SpecifiedInvoice
                apicall.InvoiceDate = frmMain.frmManage.DatePickInvoice.Value
            ElseIf frmMain.frmManage.OptRange.Checked = True Then
                seltype = AccountHistorySelectionCodeType.BetweenSpecifiedDates
                apicall.StartTimeFilter = New TimeFilter(frmMain.frmManage.DatePickFrom.Value, frmMain.frmManage.DatePickTo.Value)
            End If

            Dim entrylist As AccountEntryTypeCollection = apicall.GetAccount(seltype)
            If Not apicall.AccountSummary Is Nothing Then
                frmMain.frmManage.TxtAccBalance.Text = apicall.AccountSummary.CurrentBalance.Value.ToString()
                frmMain.frmManage.TxtAccState.Text = apicall.AccountSummary.AccountState.ToString()
                frmMain.frmManage.TxtPayMethod.Text = apicall.AccountSummary.PaymentMethod.ToString()
                frmMain.frmManage.txtBezahltag.Text = apicall.AccountSummary.LastPaymentDate.ToString

            End If

            If Not entrylist Is Nothing Then

                Dim entry As AccountEntryType

                For Each entry In entrylist

                    Application.DoEvents()
                    frmMain.master_Message_label.Text = "Lade Daten von: " & entry.Title.ToString

                    Dim listparams(7) As String
                    listparams(0) = entry.RefNumber
                    listparams(1) = entry.Title.ToString 'entry.Balance.Value.ToString()
                    listparams(2) = entry.AccountDetailsEntryType.ToString()
                    listparams(3) = entry.ItemID
                    listparams(4) = entry.Balance.Value
                    listparams(5) = entry.Date.ToString()

                    Dim vi As ListViewItem = New ListViewItem(listparams)

                    frmMain.frmManage.lvwEbayRechnung.Items.Add(vi)

                Next entry
            End If
            frmMain.frmManage.lvwEbayRechnung.EndUpdate()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            frmMain.frmManage.lvwEbayRechnung.EndUpdate()
            Return False
        End Try

    End Function

    '##################################################################
    '# >> eBay Nachrichten 
    '##################################################################
    Public Function geteBayMessages() As Boolean
        Try

            frmMain.frmManage.lvwEbayNachrichten.Items.Clear()

            Context = clseBayAPI.setAPIContext
            Application.DoEvents()
            Dim apicall As GetMemberMessagesCall = New GetMemberMessagesCall(Context)
            apicall.DisplayToPublic = False
            Dim messages As MemberMessageExchangeTypeCollection

            'If frmMain.frmManage.TxtItemId.Text <> String.Empty Then
            '    Application.DoEvents()
            '    messages = apicall.GetMemberMessages(frmMain.frmManage.TxtItemId.Text, [Enum].Parse(GetType(MessageTypeCodeType), frmMain.frmManage.CboType.SelectedItem.ToString()), [Enum].Parse(GetType(MessageStatusTypeCodeType), frmMain.frmManage.CboStatus.SelectedItem.ToString()))
            'Else
            Dim fltr As TimeFilter = New TimeFilter()

            fltr.TimeFrom = frmMain.frmManage.DatePickStartFrom.Value
            fltr.TimeTo = frmMain.frmManage.DatePickStartTo.Value

            Application.DoEvents()
            messages = apicall.GetMemberMessages(fltr, [Enum].Parse(GetType(MessageTypeCodeType), frmMain.frmManage.CboType.SelectedItem.ToString()), [Enum].Parse(GetType(MessageStatusTypeCodeType), frmMain.frmManage.CboStatus.SelectedItem.ToString()))
            '  End If

            Dim msg As MemberMessageExchangeType
            For Each msg In messages

                Dim listparams(6) As String
                If Not msg.Item Is Nothing Then
                    listparams(0) = msg.Item.ItemID
                Else
                    listparams(0) = ""
                End If

                listparams(1) = msg.Question.MessageID
                listparams(2) = msg.MessageStatus.ToString()
                listparams(3) = msg.Question.QuestionType.ToString()
                listparams(4) = msg.Question.SenderID
                listparams(5) = msg.Question.Body


                Dim vi As ListViewItem = New ListViewItem(listparams)

                frmMain.frmManage.lvwEbayNachrichten.Items.Add(vi)

            Next msg


        Catch ex As Exception
            MsgBox(ex)

        End Try

    End Function

    '##################################################################
    '# >> Sucht das Bild in der Beschreibung  
    '# 
    '# Beschreibung: Fragt die eBay Verkäuferliste ab.
    '##################################################################
    Public Function geteBayPicture(ByVal strBeschreibung As String, ByVal strModus As strBildModus) As String
        Dim iBeginn As Integer
        Dim iEnde As Integer
        Dim strBeginn As String = ""
        Dim strEnde As String = ""
        Dim strBild As String = ""
        Try


            Select Case strModus

                '# Normaler Neuer Modus 
                Case strBildModus.normal

                    strBeginn = "<DIV align=center><FONT face=""Verdana, Verdana, Arial, Helvetica, sans-serif"" size=2><img border=0 src="""
                    strEnde = """align=middle> </FONT>"

                    '# Alter Modus 
                Case strBildModus.alt
                    strBeginn = "<img border=0 src="""
                    strEnde = """align=middle>"

                Case strBildModus.nochälter
                    '<IMG src="http://www.philafriend1.de/eBay/DD6092.JPG" align=middle border=0>
                    strBeginn = "<IMG src="""
                    strEnde = """ align=middle border=0>"

                Case strBildModus.ebay_neu

                    strBeginn = "<img src="""
                    strEnde = """ align=""middle"" border=""0"">"

                Case strBildModus.yabe
                    strBeginn = "<!-- YABE -->"
                    strEnde = "<!-- END  YABE -->"

                    iBeginn = strBeschreibung.IndexOf(strBeginn)

                    If iBeginn = -1 Then
                        Return "-1"
                    End If

                    iEnde = strBeschreibung.IndexOf(strEnde, iBeginn)

                    strBild = strBeschreibung.Substring(iBeginn + strBeginn.Length, iEnde - (iBeginn + strBeginn.Length)).Trim
                    If iEnde = -1 Then
                        Return "-1"
                    End If

                    If strBild.IndexOf("miEEle") > -1 Then
                        strBeginn = "<IMG src="""
                        strEnde = """ align=miEEle border=0>"

                    Else
                        strBeginn = "<IMG border=0 align=middle src="""
                        strEnde = """>"

                    End If


                    iBeginn = strBeschreibung.IndexOf(strBeginn)
                    If iBeginn = -1 Then
                        strBeginn = "<img src="""
                        strEnde = " align=middle border=0>"
                        iBeginn = strBeschreibung.IndexOf(strBeginn)
                    End If

                    iEnde = strBeschreibung.IndexOf(strEnde, iBeginn)
                    If iEnde = -1 Then
                        strEnde = " align=""middle"" border=""0"">"
                        iEnde = strBeschreibung.IndexOf(strEnde, iBeginn)
                    End If

                    strBild = strBeschreibung.Substring(iBeginn + strBeginn.Length, iEnde - (iBeginn + strBeginn.Length))
                    strBild = strBild.Replace("""", "").Trim
            End Select

            iBeginn = strBeschreibung.IndexOf(strBeginn)

            If iBeginn = -1 Then
                Return "-1"
            End If

            iEnde = strBeschreibung.IndexOf(strEnde, iBeginn)

            If iEnde = -1 Then
                Return "-1"
            End If

            strBild = strBeschreibung.Substring(iBeginn + strBeginn.Length, iEnde - (iBeginn + strBeginn.Length))
            strBild = strBild.Replace("""", "").Trim

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getPicture" & "<br>" & strBeschreibung)
            Return "-1"
        End Try

        Return strBild
    End Function

    '##################################################################
    '# >> wait4something 
    '# 
    '# Beschreibung: Warte Dialog
    '##################################################################
    Public Function wait4something(ByVal bMode As Boolean) As Boolean

        Try
            If bMode = True Then
                Application.DoEvents()
                frmWait.Show(frmMain)
                Application.DoEvents()
            Else
                frmWait.Dispose()
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "wait4something")
            Return False
        End Try

        Return True
    End Function

    '##################################################################
    '# >> getSellerList 
    '# 
    '# Beschreibung: Fragt die eBay Verkäuferliste ab.
    '##################################################################
    'Public Function getSellerList(ByRef lvw As Object, ByVal von As Object, ByVal bis As Object, ByVal strUserID As Object) As Boolean

    Function geteBaySellerList(ByRef iCallPageTotal As Integer, ByVal bEndTime As Boolean, Optional ByVal bGeboteOnly As Boolean = False) As Boolean
        Dim streBayBild As String = ""
        Try

            Dim apicall As GetSellerListCall = New GetSellerListCall(Context)
            Dim shippment() As eBay.Service.Core.Soap.ShippingServiceOptionsType
            Dim strName As String = ""
            Dim iProseite2 As Integer
            Dim bIn As Boolean = False
            Dim eMail As String
            Dim strUsername As String
            Dim iCount As Integer = 0
            Dim strEmail_aktiv As String = ""
            'apicall.EnableCompression = True
            apicall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll)
            apicall.IncludeWatchCount = True

            If iProSeite = 0 Then
                iProSeite = My.Settings.APP_API_länge
            End If

            'Blättern aktivieren
            apicall.Pagination = New PaginationType()

            '# API SEITENZAHL einstellen 
            apicall.Pagination.EntriesPerPage = iProSeite


            'If iGlobalSeite = 1 Then
            '    wait4something(True)
            'End If

            If iGlobalSeite = 0 Then
                apicall.Pagination.PageNumber = 1

            Else
                apicall.Pagination.PageNumber = iGlobalSeite
            End If

            If My.Settings.ebay_username.Length > 0 Then
                apicall.UserID = My.Settings.ebay_username.ToString
            End If

            'MsgBox(von.Text & " " & bis.Text)
            If bEndTime = True Then
                apicall.EndTimeFilter = New TimeFilter(von.Value, bis.Value)
            Else
                apicall.StartTimeFilter = New TimeFilter(von.Value, bis.Value)
            End If

            lvw.Items.Clear()

            '#################################
            '# >> Wartefenster 
            '#################################
            Dim frm As New frmWait4Something
            frm.iWatPerTick = 100

            If frmMain.frmManage.iPage.iPageAnzahlNow = 0 Then
                iProseite2 = 0
            Else
                iProseite2 = iProSeite
            End If

            '# >> Wartefenster anzeigen 
            frm.setWait4Somthing("eBay Verkaufsliste synchronisieren", "eBay Verkaufsliste synchronisieren" & vbCrLf + "SEITE: " & frmMain.frmManage.iPage.iPageNow & " von " & frmMain.frmManage.iPage.iPageGes & " bei Artikel " & (iCallPageTotal * iProSeite) - iProSeite & " bis " & iCallPageTotal * iProSeite, 1)
            frm.bModus = frmWait4Something.modus.artikel
            frm.Show(frmMain)
            'frm.Show()

            Application.DoEvents()
            Dim sellerlist As ItemTypeCollection
            Try
                frm.lblBitteWarten.Text = "eBay Anmeldung läuft... bitte warten..."
                sellerlist = apicall.GetSellerList()
                frm.lblBitteWarten.Text = "eBay Verkaufsliste wird abgerufen..."
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Function
            End Try

            Dim item As ItemType



            If iGlobalSeite = 1 Then
                'wait4something(False)
            End If

            If iCallPageTotal = apicall.PaginationResult.TotalNumberOfPages Then
                iGlobalSeite = -1
            Else
                frmMain.frmManage.iPage.iPageGes = apicall.PaginationResult.TotalNumberOfPages.ToString
            End If


            '#########################################
            '# Liste der eBay Artikel holen
            '#########################################
            'lvw.BeginUpdate()
            Dim iMax As Integer = sellerlist.Count
            frm.pgrWait4Something.Maximum = iMax

            '# Progressbar vorbereiten 
            frmMain.frmManage.pgreBayLiveUpdate.Maximum = iMax + 2
            frmMain.frmManage.pgreBayLiveUpdate.Value = 0
            frmMain.frmManage.pgreBayLiveUpdate.Minimum = 0
            iCount = -1

            '# Für Versandkosten
            Dim strCountryCode As String

            For Each item In sellerlist

                '# Gab zumindest einen Artikel 
                bIn = True

                Application.DoEvents()
                iCount += 1
                ' Application.DoEvents()
                frm.iIntervalNow = iCount


                frmMain.master_Message_label.Text = "Bei Artikel '" & item.Title & "' Preis: " & item.SellingStatus.CurrentPrice.Value.ToString() & " " & iCount + 1 & " von " & iMax
                frmMain.frmManage.pgreBayLiveUpdate.Value = iCount

                '# Nur Gebote berücksichtigen 
                If bGeboteOnly = True Then
                    If item.SellingStatus.BidCount = 0 Then
                        Continue For
                    End If
                End If
                Dim bIsStored As Boolean
                bIsStored = clsDatenbank_modul.getIseBayIDStored(item.ItemID.ToString)

                '# Prüfung ob der Artikel in der eBay History bereits übertragen 
                If bIsStored = False Then

                    '# Gibt es ein Gebot 
                    If item.SellingStatus.BidCount > 0 Then

                        strEmail_aktiv = clsDatenbank_modul.geteBayLive_email(item.ItemID.ToString)

                        eMail = item.SellingStatus.HighBidder.Email

                        If Not eMail = strEmail_aktiv Then

                            If eMail = "Invalid Request" Then
                                'Stop
                                Continue For
                            End If

                            strUsername = item.SellingStatus.HighBidder.UserID

                            '#'#######################################################
                            '# Adressdaten holen
                            '#######################################################
                            Dim kunde As New ArrayList
                            'kunde = clseBayAPI.geteBayUserDetails(item.ItemID, item.SellingStatus.HighBidder.UserID)
                            ' 1 - Email
                            kunde.Add(eMail)
                            ' 2 - Feedback Score
                            kunde.Add(item.SellingStatus.HighBidder.FeedbackScore.ToString)
                            ' 3 - RegDate
                            kunde.Add(item.SellingStatus.HighBidder.RegistrationDate.ToString)
                            ' 4 - Seller Level 
                            kunde.Add("")
                            ' 5 - Site (de / en) 
                            kunde.Add(item.SellingStatus.HighBidder.Site.ToString)
                            ' 6 - Positiv % 
                            kunde.Add(item.SellingStatus.HighBidder.FeedbackScore.ToString)
                            ' 7 - Store URL 
                            kunde.Add("")
                            ' 8 - Neuer Benutzer ? 
                            kunde.Add("")
                            ' 9 - Verified Account
                            kunde.Add("")
                            ' 10- Letzte Änderung 
                            kunde.Add("")
                            ' 11- Paypal Status 
                            kunde.Add("")
                            ' 12- Paypal bestätigt
                            kunde.Add("")

                            '# Anschrift 
                            ' 13 - Name 
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.Name.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            ' 14 - PLZ
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.PostalCode.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            ' 15 - Ort
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.CityName.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            ' 16 - Straße
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.Street.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            ' 17 - Land
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.CountryName.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            ' 18 - star
                            kunde.Add("")
                            ' 19 - Account Name 
                            kunde.Add(item.SellingStatus.HighBidder.UserID.ToString)
                            ' - 
                            ' 20 - Telefon
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.Phone.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            ' 21 - Handy 
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.CompanyName)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try


                            ' 22 - Company
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.CompanyName.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            ' 23 - Bundesland
                            Try
                                kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.StateOrProvince.ToString)
                            Catch ex As Exception
                                kunde.Add("")
                            End Try

                            'Try
                            '    kunde.Add(item.SellingStatus.HighBidder.RegistrationAddress.Country)
                            'Catch ex As Exception

                            'End Try

                            '#######################################
                            '# >> Profil vorhanden
                            '#######################################
                            If clsDatenbank_modul.chkYABE_Kunden_isUserStored(eMail, clsDatenbank.datentabelle.yabe_personals_profile) = False Then

                                '# Profil anlegen
                                Call clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.insert, strUsername, eMail)


                            Else ' vorhanden 

                                '# Profil updaten 
                                Call clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.update, strUsername, eMail)

                            End If

                            '#################################################
                            '# >> Adresse vorhanden
                            '#################################################
                            If clsDatenbank_modul.chkYABE_Kunden_isUserStored(eMail, clsDatenbank.datentabelle.yabe_personals_adress) = False Then

                                Call clsDatenbank_modul.setYABE_kunden_adress_ArrayList(clsDatenbank.modus.insert, kunde)

                            Else
                                Call clsDatenbank_modul.setYABE_kunden_adress_ArrayList(clsDatenbank.modus.update, kunde)
                            End If

                            '#################################
                            '# >> ProfilID Mappen 
                            '#################################
                            Dim strProfile_id As String = clsDatenbank_modul.getYABE_profil_id(kunde.Item(0).ToString)
                            If IsNumeric(strProfile_id) = True Then
                                '# Profil ID einfügen in Profil Tabelle 
                                Call clsDatenbank_modul.setYABE_Kunde_Profil2Adress(strProfile_id, kunde.Item(0).ToString)
                            End If


                            '########################################
                            '# Adressen ID für Liveliste holen
                            '########################################
                            Dim adress_id As String = clsDatenbank_modul.getYABE_adress_id(kunde.Item(0).ToString)

                            '# Profil_id einfügen in Live Liste 
                            If Not adress_id = "-1" Then
                                Call clsDatenbank_modul.setYABE_item_update("personal_id", adress_id, item.ItemID, clsDatenbank.datentabelle.yabe_auction_list_live)
                            End If
                        End If

                    End If ' Gebote 

                    '########################################
                    '# >> Daten in Listview eintragen
                    '########################################
                    Dim listparams As New ListViewItem

                    'frmWait.setDoEvents()


                    With listparams


                        .Text = item.ItemID.ToString
                        .SubItems.Add("live_beschreibung").Text = item.Title.Replace("'", "")
                        .SubItems.Add("live_aktuellerPreis").Text = item.SellingStatus.CurrentPrice.Value.ToString()
                        .SubItems.Add("live_startpreis").Text = item.StartPrice.Value
                        .SubItems.Add("live_gebote").Text = item.SellingStatus.BidCount.ToString()


                        Try

                            'If item.Title = "11746 DR Dienst ZU Württemberg Hall > Crailsheim 1920" Then
                            'Stop
                            'End If

                            If Convert.ToInt16(item.SellingStatus.BidCount.ToString) > 0 Or item.ListingType.ToString = "FixedPriceItem" And Not item.SellingStatus.QuantitySold.ToString = "0" Then


                                .SubItems.Add("live_ebaymitglied").Text = item.SellingStatus.HighBidder.UserID.ToString & " (" & item.SellingStatus.HighBidder.FeedbackScore.ToString & ")"

                                '# Keine gültige eMail Adresse
                                If Not item.SellingStatus.HighBidder.Email.ToString = "Invalid Request" Then
                                    .SubItems.Add("live_email").Text = item.SellingStatus.HighBidder.Email.ToString
                                Else
                                    .SubItems.Add("live_email").Text = "ERR_zu_alt"
                                End If


                            Else
                                .SubItems.Add("live_ebaymitglied").Text = ""
                                .SubItems.Add("live_email").Text = ""
                            End If

                            Dim strTyp As String = item.ListingType.ToString

                            strTyp = strTyp.Replace("Chinese", "Auktion")

                            .SubItems.Add("live_beendet").Text = item.SellingStatus.ListingStatus.ToString
                            .SubItems.Add("live_ListType").Text = strTyp
                            .SubItems.Add("auction_date").Text = item.ListingDetails.EndTime.ToString
                            .SubItems.Add("live_watch").Text = item.WatchCount.ToString
                            .SubItems.Add("live_anfang").Text = item.ListingDetails.StartTime
                            .SubItems.Add("live_endgebühr").Text = "" 'item.SellingStatus.FinalValueFee.Value.ToString

                            Try
                                strCountryCode = item.SellingStatus.HighBidder.RegistrationAddress.CountryName
                            Catch ex As Exception
                                strCountryCode = ""
                            End Try

                            If strCountryCode = "Deutschland" Or strCountryCode = "" Then

                                shippment = item.ShippingDetails.ShippingServiceOptions.ToArray()
                                Try

                                    If shippment.Length > 0 Then
                                        .SubItems.Add("live_versandkosten").Text = shippment(0).ShippingServiceCost.Value.ToString  '"---" 'item.ShippingDetails.DefaultShippingCost.Value 
                                    Else
                                        .SubItems.Add("live_versandkosten").Text = 0
                                    End If
                                Catch ex As Exception
                                    .SubItems.Add("live_versandkosten").Text = 0
                                End Try

                            Else

                                Dim shippment2() As eBay.Service.Core.Soap.InternationalShippingServiceOptionsType
                                shippment2 = item.ShippingDetails.InternationalShippingServiceOption.ToArray

                                If shippment2.Length > 0 Then
                                    .SubItems.Add("live_versandkosten").Text = shippment2(0).ShippingServiceCost.Value
                                    'MsgBox(shippment(0).ShippingServiceCost.Value)
                                Else
                                    .SubItems.Add("live_versandkosten").Text = 0
                                End If


                            End If


                            '########################################
                            '# Bild aus der Beschreibung holen 
                            '########################################
                            If My.Settings.bUse_ownPictures = True Then


                                ' If bIsStored = False Then

                                streBayBild = geteBayPicture(item.Description, strBildModus.yabe)

                                If streBayBild = "-1" Then
                                    streBayBild = geteBayPicture(item.Description, strBildModus.normal)
                                    If streBayBild = "-1" Then
                                        streBayBild = geteBayPicture(item.Description, strBildModus.alt)
                                        If streBayBild = "-1" Then
                                            streBayBild = geteBayPicture(item.Description, strBildModus.ebay_neu)
                                            If streBayBild = "-1" Then
                                                streBayBild = geteBayPicture(item.Description, strBildModus.nochälter)

                                            End If

                                        End If
                                    End If
                                End If
                                'End If


                            Else

                                '# Pixi Bilder
                                If item.PictureDetails.PictureURL.Count > 0 Then
                                    streBayBild = item.PictureDetails.PictureURL(0).ToString
                                End If

                            End If

                .SubItems.Add("live_eBayBild").Text = streBayBild
                .SubItems.Add(item.HitCount.ToString)
                .SubItems.Add(16).Text = item.TotalQuestionCount.ToString
                .SubItems.Add("live_eBayBild").Text = streBayBild

                        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "geteBaySellerList - Inner")
        End Try

                        'Dim vi As ListViewItem = New ListViewItem(listparams)
                    End With

                    lvw.Items.Add(listparams)
                    lvw.Items(lvw.Items.Count - 1).EnsureVisible()

                End If
            Next item

            ' MsgBox(setStopuhr(False))

            'lvw.Enabled = True
            'lvw.EndUpdate()
            frm.Close() ' Wartefenster schließen
            Return bIn

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getSellerList")
            bIsRefreshing_live = False
            Return False
        End Try


    End Function

    '#################################################################################
    '# >> EXPORT: Transaktions 
    '#################################################################################
    Private Function expSellerTransaktions(ByVal oTransaction As eBay.Service.Core.Soap.TransactionType) As Boolean
        Try
            setTextbox("-------------------------")
            setTextbox("Artikel ID          : " & oTransaction.Item.ItemID)
            setTextbox("---------------------------")
            setTextbox("Käuferdaten         :  " & oTransaction.Buyer.UserID & "(" & oTransaction.Buyer.Email & ") " & oTransaction.Buyer.FeedbackScore)
            setTextbox("---------------------------")
            setTextbox("Name                : " & oTransaction.Buyer.BuyerInfo.ShippingAddress.Name)
            setTextbox("Strasse             : " & oTransaction.Buyer.BuyerInfo.ShippingAddress.Street1)
            setTextbox("Ort                 : " & oTransaction.Buyer.BuyerInfo.ShippingAddress.PostalCode & " " & oTransaction.Buyer.BuyerInfo.ShippingAddress.CityName)
            setTextbox("Bundesland          : " & oTransaction.Buyer.BuyerInfo.ShippingAddress.StateOrProvince)
            setTextbox("LAND-CODE           : " & oTransaction.Buyer.BuyerInfo.ShippingAddress.CountryName)
            setTextbox("Telefon             : " & oTransaction.Buyer.BuyerInfo.ShippingAddress.Phone)
            setTextbox("Firmenname          : " & oTransaction.Buyer.BuyerInfo.ShippingAddress.CompanyName)
            setTextbox("---------------------------")

            If (oTransaction.QuantityPurchasedSpecified = True) Then
                setTextbox("Menge           : " & oTransaction.QuantityPurchased.ToString())
            End If

            If Not (oTransaction.AmountPaid Is Nothing) Then
                setTextbox("Betrag gezahlt  :  " & oTransaction.AmountPaid.currencyID.ToString() & " " & oTransaction.AmountPaid.Value.ToString())
            End If

            If Not (oTransaction.ShippingServiceSelected Is Nothing) Then
                setTextbox("Versand Art     : " & oTransaction.ShippingServiceSelected.ShippingService.ToString())
                setTextbox("Versandkosten   : " & oTransaction.ShippingServiceSelected.ShippingServiceCost.currencyID.ToString() & " " & oTransaction.ShippingServiceSelected.ShippingServiceCost.Value.ToString())
            End If

            If (oTransaction.CreatedDateSpecified = True) Then
                setTextbox("Transaktion vom : " & oTransaction.CreatedDate.ToLongDateString() & " at " & oTransaction.CreatedDate.ToLongTimeString())
            End If

            If (oTransaction.Status.LastTimeModifiedSpecified = True) Then
                setTextbox("Transaktion verändert: " & oTransaction.Status.LastTimeModified.ToLongDateString() & " at " & oTransaction.Status.LastTimeModified.ToLongTimeString())
            End If

            If (oTransaction.Status.PaymentMethodUsedSpecified = True) Then
                setTextbox("Bezahlmethode   : " & oTransaction.Status.PaymentMethodUsed.ToString())
            End If

            If (oTransaction.PaidTimeSpecified = True) Then
                setTextbox("Bezahlt am      : " & oTransaction.PaidTime.ToLongDateString() & " at " & oTransaction.PaidTime.ToLongTimeString())
            End If

            If (oTransaction.ShippedTimeSpecified = True) Then
                setTextbox("Verschickt am   : " & oTransaction.ShippedTime.ToLongDateString() & " at " & oTransaction.ShippedTime.ToLongTimeString())
            End If

            If Not (oTransaction.FinalValueFee Is Nothing) Then
                setTextbox("Endgebühren eBay : " & oTransaction.FinalValueFee.currencyID.ToString() & " " & oTransaction.FinalValueFee.Value.ToString())
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "expSellerTransaktions")
            Return False
        End Try

        Return True
    End Function

    Public Function setCompleteSale(ByVal strItemID As String, ByVal strStatus As String) As Boolean
        Try
            Dim setComplateSale As New CompleteSaleCall(Context)
            'setComplateSale.CompleteSale
            Dim Request As New CompleteSaleRequestType
            Request.ItemID = strItemID
            Request.TransactionID = 0

            Select Case strStatus
                Case "bestellt"
                    Request.Paid = False
                    Request.PaidSpecified = True
                    Request.Shipped = False
                    Request.ShippedSpecified = True
                Case "bezahlt"
                    Request.Paid = True
                    Request.PaidSpecified = True
                    Request.Shipped = False
                    Request.ShippedSpecified = True
                Case "verschickt"
                    Request.Paid = True
                    Request.PaidSpecified = True
                    Request.Shipped = True
                    Request.ShippedSpecified = True
                Case "komplett"
                    Request.Paid = True
                    Request.PaidSpecified = True
                    Request.Shipped = True
                    Request.ShippedSpecified = True
                Case "storniert"
                    Request.Paid = False
                    Request.PaidSpecified = True
                    Request.Shipped = False
                    Request.ShippedSpecified = True
            End Select

            setComplateSale.ExecuteRequest(Request)
            Return True

        Catch ex As Exception
            frmMain.StatusStrip1.Text = ex.Message
            Return False
        End Try
    End Function

    '#################################################################################
    '# >> Transaktionen abrufen 
    '#################################################################################
    Public Function getSellerTransaktions(ByVal bExport2Text As Boolean, ByVal iVon() As String, ByVal iBis() As String) As Boolean

        Dim oGetSellerTransactionsCall As GetSellerTransactionsCall = New GetSellerTransactionsCall(Context)
        Dim iPersonal As Integer = 0
        Dim iCounter As Integer = 0

        ' Version mitteilen 
        oGetSellerTransactionsCall.Version = Context.Version

        ' Seite des Aufrufs einstellen 
        oGetSellerTransactionsCall.Site = Context.Site

        ' enable the compression feature
        ' oGetSellerTransactionsCall.EnableCompression = True

        ' Weitere Details -> HTTP 
        'http://developer.ebay.com/DevZone/SOAP/docs/Reference/eBay/io_GetSellerTransactions.html#DetailLevels
        oGetSellerTransactionsCall.DetailLevelList = New DetailLevelCodeTypeCollection(New DetailLevelCodeType() {DetailLevelCodeType.ReturnAll})

        ' Zeitraum         

        oGetSellerTransactionsCall.ModTimeFilter = New TimeFilter(New DateTime(iVon(2), iVon(1), iVon(0), 0, 0, 0), New DateTime(iBis(2), iBis(1), iBis(0), 0, 0, 0))

        ' include final value fees
        oGetSellerTransactionsCall.IncludeFinalValueFee = True
        oGetSellerTransactionsCall.IncludeContainingOrder = True
        oGetSellerTransactionsCall.Pagination = New PaginationType
        oGetSellerTransactionsCall.Pagination.EntriesPerPage = 200
        oGetSellerTransactionsCall.Pagination.EntriesPerPageSpecified = True
        oGetSellerTransactionsCall.Pagination.PageNumber = 1
        oGetSellerTransactionsCall.Pagination.PageNumberSpecified = True

        Try

            Dim frm As New frmWait4Something
            frm.setWait4Somthing("eBay Transaktionen abrufen", "eBay Transaktionen abrufen", 0)
            frm.Show()
            oGetSellerTransactionsCall.GetSellerTransactions(oGetSellerTransactionsCall.ModTimeFilter)

            For Each oTransaction As TransactionType In oGetSellerTransactionsCall.TransactionList

                iCounter += 1
                Application.DoEvents()


                If Not oTransaction.Buyer.Email = "Invalid Request" Then
                    '##########################
                    '# >> Profil SPEICHERN 
                    '##########################
                    If clsDatenbank_modul.chkYABE_Kunden_isUserStored(oTransaction.Buyer.Email, clsDatenbank.datentabelle.yabe_personals_profile) = False Then
                        clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.insert, oTransaction.Buyer.UserID.ToString, oTransaction.Buyer.Email)

                    Else ' vorhanden 
                        clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.update, oTransaction.Buyer.UserID.ToString, oTransaction.Buyer.Email)
                    End If

                    '##########################
                    '# >> ADRESSEN SPEICHERN 
                    '##########################

                    If clsDatenbank_modul.chkYABE_Kunden_isUserStored(oTransaction.Buyer.Email, clsDatenbank.datentabelle.yabe_personals_adress) = False Then
                        clsDatenbank_modul.setYABE_kunden_adress_eBayTransaktion(clsDatenbank.modus.insert, oTransaction)
                    Else
                        clsDatenbank_modul.setYABE_kunden_adress_eBayTransaktion(clsDatenbank.modus.update, oTransaction)
                    End If

                    '#################################
                    '# >> Persönlice ID zuordnen 
                    '#################################
                    iPersonal = clsDatenbank_modul.getPersonalID(oTransaction.Buyer.Email)
                    If Not iPersonal = -1 Then
                        If clsDatenbank_modul.setPersonalID2Item(oTransaction.Item.ItemID, iPersonal) = False Then
                            MsgBox("Fehler beim Übertragen der eBay ID auf den Artikel", MsgBoxStyle.Critical)
                        End If
                    End If
                End If

                '#################################
                '# >> Artikelstatus setzten 
                '#################################
                If clsDatenbank_modul.seteBayTransaktionData(oTransaction) = False Then
                    MessageBox.Show("Es ist ein Fehler beim Update von eBay ID '" & oTransaction.Item.ItemID & "' aufgetreten!", "Fehler beim Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                frm.setUpdateMessageLabel("Transaktion:" & iCounter + 1 & " - '" & oTransaction.Buyer.BuyerInfo.ShippingAddress.Name & "'")

            Next

            '#########################################
            '# EXPORT als Textdatei DURCHFÜHREN 
            '#########################################
            If bExport2Text = True Then

                Dim i As Integer = 0
                setTextbox("---------------------------")
                setTextbox("BEGIN: " & Date.Now)
                setTextbox("---------------------------")

                For Each oTransaction As TransactionType In oGetSellerTransactionsCall.TransactionList
                    Call expSellerTransaktions(oTransaction)
                Next

                setTextbox("---------------------------")
                setTextbox("ENDE: " & Date.Now)
                setTextbox("---------------------------")

            End If

            frm.Dispose()
            MsgBox("Alle " & iCounter & " Kundendaten wurden eingesammelt", MsgBoxStyle.Information + MsgBoxStyle.SystemModal)

        Catch oApiEx As ApiException
            MsgBox(oApiEx.Message.ToString)
        Catch oSdkEx As SdkException
            MsgBox(oSdkEx.Message.ToString)
        Catch oEx As Exception
            MsgBox(oEx.Message.ToString)
        End Try

    End Function

    Public Function setTextbox(ByVal str As String) As Boolean
        My.Computer.FileSystem.WriteAllText("ebayDat.txt", str & vbCrLf, True)
        Return True
    End Function

    '##################################################################
    '# >> getSellerList 
    '# 
    '# Beschreibung: Fragt die eBay Verkäuferliste ab.
    '##################################################################
    Public Function getFeedBackList(ByRef lvw As ListView, ByVal strUserID As String, ByVal lblMessageMaster As ToolStripStatusLabel) As Boolean

        Try

            lvw.BeginUpdate()
            lvw.Items.Clear()
            '  Application.DoEvents()

            Dim apicall As GetFeedbackCall = New GetFeedbackCall(Context)
            apicall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll)
            apicall.Site = SiteCodeType.Germany
            apicall.Pagination = New PaginationType
            apicall.Pagination.EntriesPerPage = 200
            apicall.Pagination.EntriesPerPageSpecified = True
            apicall.Pagination.PageNumber = 1
            apicall.Pagination.PageNumberSpecified = True


            Dim feedbacks As FeedbackDetailTypeCollection = apicall.GetFeedback(strUserID)


            If Not apicall.FeedbackSummary Is Nothing Then

                lblMessageMaster.Text = "Positiv: " & apicall.FeedbackSummary.UniquePositiveFeedbackCount.ToString() & " " & apicall.FeedbackSummary.UniqueNegativeFeedbackCount.ToString() & " Punktzahl:" & apicall.FeedbackScore.ToString()

                If strUserID = My.Settings.ebay_username.ToString Then
                    Call clsDatenbank_modul.seteBayStats(apicall.FeedbackSummary.UniquePositiveFeedbackCount.ToString(), apicall.FeedbackSummary.UniqueNegativeFeedbackCount.ToString, apicall.FeedbackSummary.UniqueNeutralFeedbackCount, strUserID)
                End If


            End If

            Dim feedback As FeedbackDetailType
            Dim iCount As Integer = 0
            For Each feedback In feedbacks
                Dim listparams(8) As String
                iCount += 1
                Try

                    listparams(0) = feedback.CommentingUser

                    listparams(1) = feedback.CommentingUserScore.ToString()

                    listparams(2) = feedback.ItemID

                    listparams(3) = feedback.CommentType.ToString()

                    listparams(4) = feedback.CommentText

                    listparams(5) = feedback.Role.ToString()

                    listparams(6) = feedback.CommentTime.ToString()

                    listparams(7) = feedback.FeedbackID.ToString

                    Try
                        listparams(8) = feedback.ItemTitle.ToString
                        listparams(9) = feedback.ItemPrice.Value
                    Catch ex As Exception
                        listparams(8) = "-1"
                        listparams(9) = "-1"
                    End Try

                Catch ex As Exception
                    'Stop
                End Try

                Dim vi As ListViewItem = New ListViewItem(listparams)

                Application.DoEvents()
                'lvw.EnsureVisible(lvw.Items(lvw.Items.Count - 1).Index)
                frmMain.master_Message_label.Text = "Bei Artikel " & iCount
                lvw.Items.Add(vi)
            Next feedback

            lvw.EndUpdate()

            Return True
        Catch ex As Exception
            lvw.EndUpdate()
            Call debug_message(ex, "getFeedBackList")
            Return False

        End Try

        Return True
    End Function

    Public Function seteBayOrder(frm As frmBestellung_Versandkosten) As Boolean
        Try
            Dim apicall As eBay.Service.Call.AddOrderCall = New eBay.Service.Call.AddOrderCall(Context)
            Dim iCount As Integer = 0

            Dim order As OrderType = New OrderType()
            order.TransactionArray = New TransactionTypeCollection()
            order.ShippingDetails = New ShippingDetailsType()
            order.PaymentMethods = New BuyerPaymentMethodCodeTypeCollection()

            For iCount = 0 To frm.lvwArtikelListe.SelectedItems.Count - 1
                Dim tr1 As TransactionType = New TransactionType()

                tr1.Item = New ItemType()

                tr1.Item.ItemID = frm.lvwArtikelListe.SelectedItems(iCount).SubItems(0).Text

                tr1.TransactionID = "0"

                order.TransactionArray.Add(tr1)
            Next

            'clsDatenbank_modul
            Dim strZahlungshinweis As String = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_ebay_zahlhinweise)
            strZahlungshinweis = strZahlungshinweis.Replace("###NAME###", frm.txtBenutzername.Text)
            strZahlungshinweis = strZahlungshinweis.Replace("###ENDSUMME###", frm.txtEndbetrag.Text)
            strZahlungshinweis = strZahlungshinweis.Replace("###VERSANDKOSTEN###", frm.txtVersandkosten.Text)
            strZahlungshinweis = strZahlungshinweis.Replace("###ENDSUMME_PAYPAL###", frm.txtMitPaypal.Text)
            strZahlungshinweis = strZahlungshinweis.Replace("###LAND###", frm.txtLand.Text)
            strZahlungshinweis = strZahlungshinweis.Replace("###ORT###", frm.txtOrt.Text)
            strZahlungshinweis = strZahlungshinweis.Replace("###EMAIL###", frm.txtEmail.Text)
            strZahlungshinweis = strZahlungshinweis.Replace("###STRASSE###", frm.txtAnschrift.Text)

            order.ShippingDetails.PaymentInstructions = strZahlungshinweis

            Dim shpopt As ShippingServiceOptionsType = New ShippingServiceOptionsType()

            shpopt.ShippingService = frm.cmbeBayVersandart.SelectedItem.ToString()

            shpopt.ShippingServicePriority = 1


            order.ShippingDetails.ShippingServiceOptions = New ShippingServiceOptionsTypeCollection()

            shpopt.ShippingServiceCost = New AmountType()

            shpopt.ShippingServiceCost.currencyID = CurrencyUtility.GetDefaultCurrencyCodeType(Context.Site)

            If frm.txtVersandkosten.Text.Length > 0 Then
                shpopt.ShippingServiceCost.Value = Convert.ToDouble(frm.txtVersandkosten.Text)
            End If

            order.ShippingDetails.ShippingServiceOptions.Add(shpopt)



            order.Total = New AmountType()
            order.Total.currencyID = CurrencyUtility.GetDefaultCurrencyCodeType(Context.Site)
            If frm.txtEndbetrag.Text.Length > 0 Then
                order.Total.Value = Convert.ToDouble(frm.txtEndbetrag.Text)
            End If

            order.CreatingUserRole = TradingRoleCodeType.Seller ' [Enum].Parse(GetType(TradingRoleCodeType), CboRole.SelectedItem.ToString())

            If My.Settings.yabe_paypal_emailusername.Length > 0 Then
                frm.ToolStripStatusLabel1.Text = "Mit Paypal"
                order.PaymentMethods.Add(BuyerPaymentMethodCodeType.PayPal)
            End If

            order.PaymentMethods.Add(BuyerPaymentMethodCodeType.StandardPayment)
            order.PaymentMethods.Add(BuyerPaymentMethodCodeType.PaymentSeeDescription)

            Dim orderid As String = apicall.AddOrder(order)

            frm.txtOrderID.Text = orderid
            frm.ToolStripStatusLabel1.Text = frm.lvwArtikelListe.SelectedItems.Count - 1 & "Artikel als Rechnung " & frm.txtEndbetrag.Text & " verschickt (" & orderid & ")"

            Return True
        Catch ex As Exception
            Call debug_message(ex, "seteBayOrder")
            Return False
        End Try
    End Function

    '####################################################################################
    '# >> Invoice abschicken
    '####################################################################################
    Public Function setSendInvoice(frm As frmBestellung_Versandkosten) As Boolean
        Try
            Dim apicall As SendInvoiceCall = New SendInvoiceCall(Context)

            apicall.ItemID = frm.lvwArtikelListe.Items(0).SubItems(0).Text
            If frm.txtOrderID.Text.Length > 0 Then
                apicall.OrderID = frm.txtOrderID.Text
            End If

            apicall.TransactionID = ""
            Dim versand As New eBay.Service.Core.Soap.ShippingServiceOptionsTypeCollection
            Dim shipoptions As New eBay.Service.Core.Soap.ShippingServiceOptionsType

            Dim ship As New ShippingServiceDetailsType
            shipoptions.ShippingService = frm.cmbeBayVersandart.Text

            Dim amount As New eBay.Service.Core.Soap.AmountType
            amount.currencyID = CurrencyCodeType.EUR
            amount.Value = frm.txtVersandkosten.Text
            shipoptions.ShippingServiceCost = amount

            versand.Add(shipoptions)

            apicall.ShippingServiceOptionsList = versand

            ' apicall.SendInvoice(
            apicall.Execute()

            Return (True)
        Catch ex As Exception
            Call debug_message(ex, "setSendInvoice")
            Return False
        End Try
    End Function

    '###############################################################################
    '# >> BieterListe abrufne 
    '###############################################################################
    Public Function geteBayBidderList(ByVal lvw As ListView, ByVal strItemID As String, ByVal strModus As String, Optional ByVal bInsertLVW As Boolean = True) As Boolean
        Try

            Dim apicall As GetAllBiddersCall = New GetAllBiddersCall(Context)

            Dim bids As OfferTypeCollection = apicall.GetAllBidders(strItemID, [Enum].Parse(GetType(GetAllBiddersModeCodeType), strModus))

            Dim offer As OfferType

            For Each offer In bids



                '# Abrufen der Zusatz informationen über den Benutzer 
                Dim kunde As New ArrayList
                kunde = clseBayAPI.geteBayUser(strItemID, offer.User.UserID)

                If kunde.Item(3).ToString = "Invalid Request" Then
                    ' Continue For

                Else
                    '# Profileintrag in DB setztebn 
                    If clsDatenbank_modul.chkYABE_Kunden_isUserStored(offer.User.Email, clsDatenbank.datentabelle.yabe_personals_profile) = False Then
                        clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.insert, offer.User.UserID, kunde.Item(3).ToString)
                        iCount_insert += 1

                    Else ' vorhanden 


                        clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.update, offer.User.UserID, kunde.Item(3).ToString)
                        iCount_update += 1



                    End If
                End If



                If bInsertLVW = True Then

                    Dim listparams(7) As String

                    listparams(0) = offer.Action.ToString()
                    listparams(1) = offer.User.UserID
                    listparams(2) = offer.Currency.ToString()
                    listparams(3) = offer.MaxBid.Value.ToString()
                    listparams(4) = offer.Quantity.ToString()
                    listparams(5) = offer.TimeBid.ToString()
                    listparams(6) = kunde.Item(3).ToString
                    '# Anschrift 
                    ' 13 - Name 
                    ' 14 - PLZ
                    ' 15 - Ort
                    ' 16 - Straße
                    ' 17 - Land
                    ' 18 - star
                    ' 19 - Account Name 
                    listparams(7) = kunde.Item(2).ToString & " / " & kunde.Item(6).ToString & " / " & kunde.Item(1).ToString
                    

                    Dim vi As ListViewItem = New ListViewItem(listparams)

                    lvw.Items.Add(vi)
                End If

            Next offer

            Return True
        Catch ex As Exception
            Call debug_message(ex, "geteBayBidderList")
            Return False
        End Try

    End Function

    '#########################################################################
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
    'geteBayUserDetails(ByVal strItem As String, ByVal strUserID As String) As ArrayList
    '#########################################################################
    Public Function geteBayUserDetails(ByVal strItem As String, ByVal strUserID As String) As ArrayList

        Dim aryList As New ArrayList

        Try


            Dim ApiCall As GetUserCall = New GetUserCall(Context)
            ApiCall.Site = SiteCodeType.Germany
            ApiCall.DetailLevelList = New DetailLevelCodeTypeCollection(New DetailLevelCodeType() {DetailLevelCodeType.ReturnAll})

            If strUserID.Length > 0 Then
                ApiCall.UserID = strUserID
            End If

            If strItem.Length > 0 Then
                ApiCall.ItemID = strItem
            End If

            Dim user As UserType = ApiCall.GetUser()

            '# WERTE ZUWEISUNG 
            aryList.Add(user.Email.ToString())
            aryList.Add(user.FeedbackScore.ToString())
            aryList.Add(user.RegistrationDate.ToString())
            aryList.Add(user.SellerInfo.SellerLevel.ToString())

            aryList.Add(user.Site.ToString())
            Try
                aryList.Add(user.PositiveFeedbackPercent.ToString)
            Catch ex As Exception
                aryList.Add("-1")
            End Try

            Try
                '# Nur anzeigen, wenn URL da ist 
                If user.SellerInfo.StoreURL.Length > 0 Then
                    aryList.Add(user.SellerInfo.StoreURL.ToString)
                End If
            Catch ex As Exception
                aryList.Add("-1")
            End Try


            aryList.Add(user.NewUser.ToString())
            aryList.Add(user.IDVerified.ToString())
            aryList.Add(user.UserIDLastChanged.ToString())
            aryList.Add(user.PayPalAccountStatus.ToString)
            aryList.Add(user.PayPalAccountLevel.ToString)

            '# Name
            Try
                aryList.Add(user.RegistrationAddress.Name)
                aryList.Add(user.RegistrationAddress.PostalCode)
                aryList.Add(user.RegistrationAddress.CityName)
                aryList.Add(user.RegistrationAddress.Street)
                aryList.Add(user.RegistrationAddress.CountryName)

            Catch ex As Exception
                aryList.Add("-1")
                aryList.Add("-1")
                aryList.Add("-1")
                aryList.Add("-1")
            End Try

            ' Stern     
            ' 19 - Account Name 
            ' - 
            ' 20 - Telefon
            ' 21 - Handy 
            ' 22 - Company
            ' 23 - Bundesland
            aryList.Add("-1")

            ' 19 - Account Name 
            Try
                aryList.Add(user.UserID)
            Catch ex As Exception
                aryList.Add("-1")
            End Try

            ' - 
            ' 20 - Telefon
            Try
                aryList.Add(user.RegistrationAddress.Phone)
            Catch ex As Exception
                aryList.Add("-1")
            End Try

            ' 21 - Handy 
            Try
                aryList.Add(user.RegistrationAddress.Phone2)
            Catch ex As Exception
                aryList.Add("-1")
            End Try

            ' 22 - Company
            Try
                aryList.Add(user.RegistrationAddress.CompanyName) ' Cubss wenn ihr so nervt ;)
            Catch ex As Exception
                aryList.Add("-1")
            End Try

            ' 23 - Bundesland
            Try
                aryList.Add(user.RegistrationAddress.StateOrProvince)
            Catch ex As Exception
                aryList.Add("-1")
            End Try


            Return aryList
        Catch ex As Exception
            Call debug_message(ex, "YABE eBay API -> geteBayUserDetails")
            Return Nothing
        End Try

    End Function

    '############################################################################################
    '# >> Internationale Versandkosten 
    '############################################################################################
    Public Function getShippment(ByVal itemId As String, ByVal strMenge As String, ByVal ZIP As String, ByVal bInternational As CountryCodeType) As String()
        Dim shippmentItem As ShippingDetailsType
        Dim strVersand(1) As String
        Try
            Context = clseBayAPI.setAPIContext()

            Dim Apicall As GetItemShippingCall = New GetItemShippingCall(Context)
            Apicall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll)

            If bInternational = CountryCodeType.DE Then
                shippmentItem = Apicall.GetItemShipping(itemId, ZIP, bInternational)


                Dim shippment2() As eBay.Service.Core.Soap.ShippingServiceOptionsType
                shippment2 = shippmentItem.ShippingServiceOptions.ToArray


                If shippment2.Length > 0 Then
                    strVersand(0) = shippment2(0).ShippingService
                    strVersand(1) = shippment2(0).ShippingServiceCost.Value
                    Return strVersand
                    'MsgBox(shippment(0).ShippingServiceCost.Value)
                Else
                    strVersand(0) = ""
                    strVersand(1) = ""
                    Return strVersand
                End If

            Else

                shippmentItem = Apicall.GetItemShipping(itemId, ZIP, bInternational)

                Dim shippment() As eBay.Service.Core.Soap.InternationalShippingServiceOptionsType
                shippment = shippmentItem.InternationalShippingServiceOption.ToArray

                If shippment.Length > 0 Then
                    strVersand(0) = shippment(0).ShippingService
                    strVersand(1) = shippment(0).ShippingServiceCost.Value

                    Return strVersand
                    'MsgBox(shippment(0).ShippingServiceCost.Value)
                Else
                    strVersand(0) = ""
                    strVersand(1) = ""
                    Return strVersand
                End If
            End If

            'shippmentItem.ShippingServiceOptions.ShippingServiceCost()

            Return strVersand
        Catch ex As Exception
            MsgBox(ex.Message)
            strVersand(0) = ""
            strVersand(1) = ""
            Return strVersand
        End Try
    End Function

    Public Function getItemInfo(ByVal ieBayID As String) As ItemType

        Dim fetchedItem As New ItemType

        Context = clseBayAPI.setAPIContext()
        Dim Apicall As GetItemCall = New GetItemCall(Context)
        Apicall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll)
        fetchedItem = Apicall.GetItem(ieBayID)
        frmMain.master_Message_label.Text = fetchedItem.Title
        Return fetchedItem
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    '#############################################    
    '# FUNKTIONIERT NOCH NICH RICHTIG
    '# - TEST
    '#############################################
    Public Function geteBayBewertungen_open() As Boolean
        Try
            Context = setAPIContext()
            Dim Apicall As New GetItemsAwaitingFeedbackCall(Context)
            Dim pagenation As New eBay.Service.Core.Soap.PaginationType
            Dim page As New eBay.Service.Core.Soap.PaginatedTransactionArrayType

            pagenation.EntriesPerPage = 100
            pagenation.PageNumber = 1
            page = Apicall.GetItemsAwaitingFeedback(ItemSortTypeCodeType.BuyerUserID, pagenation)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    '###################################################
    '# >> BESTELLUNGEN BEI eBAY ÄNDERN
    '# - TEST 
    '###################################################
    Public Function seteBayOrderStatus() As Boolean
        Try
            Context = setAPIContext()
            Dim Apicall As New ReviseCheckoutStatusCall(setAPIContext)
            'Apicall.ReviseCheckoutStatus(12, 12, )
            ' ReviseCheckoutStatus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    '###################################################
    '# >> BESTELLUNGEN BEI eBAY ÄNDERN
    '# - TEST 
    '###################################################
    Public Function setOrderInvoice(ByVal itemID As String, ByVal transaktionID As String, ByVal versandkosten As Double) As Boolean
        Try
            Context = setAPIContext()
            Dim Apicall As New SendInvoiceCall(setAPIContext)
            Dim versand As New eBay.Service.Core.Soap.ShippingServiceOptionsType
            Dim versand_col As New eBay.Service.Core.Soap.ShippingServiceOptionsTypeCollection
            Dim amount As New AmountType
            amount.currencyID = CurrencyCodeType.EUR
            amount.Value = versandkosten
            versand.ShippingServiceCost = amount
            versand_col.Add(versand)

            Apicall.SendInvoice(itemID, transaktionID, versand_col)
            MsgBox(Apicall.ResponseTime)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    '##################################################################################################
    '# >> eBay Bestellung erzeugen 
    '##################################################################################################
    Public Function setNewOrder(ByVal strAryeBayID() As String, ByVal strAryTransaktionID() As String, ByVal strVersandkosten As String, ByVal strKostenTotal As String, ByVal strPaymentText As String, ByVal strVersandServiceName As String) As String
        Try


            Context = clseBayAPI.setAPIContext()
            Dim apicall As AddOrderCall = New AddOrderCall(Context)

            Dim order As OrderType = New OrderType()
            order.TransactionArray = New TransactionTypeCollection()
            order.ShippingDetails = New ShippingDetailsType()
            order.PaymentMethods = New BuyerPaymentMethodCodeTypeCollection()

            '# Alle Artikelnummern zur Bestellung hinzufügen 
            For iCount As Integer = 0 To strAryeBayID.Length - 1

                Dim tr1 As TransactionType = New TransactionType()
                tr1.Item = New ItemType()

                tr1.Item.ItemID = strAryeBayID(iCount)
                tr1.TransactionID = strAryTransaktionID(iCount)
                ' hinzufügen zur Order 
                order.TransactionArray.Add(tr1)
            Next


            order.ShippingDetails.PaymentInstructions = strPaymentText

            Dim shpopt As ShippingServiceOptionsType = New ShippingServiceOptionsType()

            shpopt.ShippingService = strVersandServiceName

            shpopt.ShippingServicePriority = 1


            order.ShippingDetails.ShippingServiceOptions = New ShippingServiceOptionsTypeCollection()

            shpopt.ShippingServiceCost = New AmountType()

            shpopt.ShippingServiceCost.currencyID = CurrencyUtility.GetDefaultCurrencyCodeType(Context.Site)

            If strVersandkosten.Length > 0 Then
                shpopt.ShippingServiceCost.Value = Convert.ToDouble(strVersandkosten)
            End If

            order.ShippingDetails.ShippingServiceOptions.Add(shpopt)



            order.Total = New AmountType()
            order.Total.currencyID = CurrencyUtility.GetDefaultCurrencyCodeType(Context.Site)
            If strKostenTotal.Length > 0 Then
                order.Total.Value = Convert.ToDouble(strKostenTotal)
            End If



            order.CreatingUserRole = TradingRoleCodeType.Seller  ' [Enum].Parse(GetType(TradingRoleCodeType), CboRole.SelectedItem.ToString())


            order.PaymentMethods.Add(BuyerPaymentMethodCodeType.PaymentSeeDescription)

            Dim orderid As String = apicall.AddOrder(order)

            Return orderid


        Catch ex As Exception
            MsgBox(ex.Message)
            Return "-1"
        End Try
    End Function
    '###########################################################
    '# >> Feedback abgeben
    '###########################################################
    Public Function seteBayLeaveFeedback(ByVal strID As String, ByVal strComment As String, ByVal strTransaktionID As String, ByVal strUserID As String) As Boolean
        Try
            Context = clseBayAPI.setAPIContext()

            Dim apicall As LeaveFeedbackCall = New LeaveFeedbackCall(Context)            
            apicall.LeaveFeedback(strID, strComment, CommentTypeCodeType.Positive, "0", strUserID)

            '# Bewertet einstellen
            clsDatenbank_modul.setBewertet_CMS(strID)
 

            Return True
        Catch ex As Exception
            If ex.Message.Contains("Sie haben bereits eine Bewertung abgegeben.") = True Then
                '# Bewertet einstellen
                clsDatenbank_modul.setBewertet_CMS(strID)
                Return False
            Else
                MsgBox(ex.Message)
                Return False
            End If

        End Try
    End Function

    Public Function getSellerEvents(lvwCockpit As ListView, dtVon As Date, dtbis As Date) As Boolean
        Try
            Context = clseBayAPI.setAPIContext()


            Dim ApiCall As GetSellerEventsCall = New GetSellerEventsCall(Context)

            'ApiCall.DetailLevelList
            ApiCall.DetailLevelList = New DetailLevelCodeTypeCollection(New DetailLevelCodeType() {DetailLevelCodeType.ReturnAll})

            ApiCall.UserID = My.Settings.ebay_username


            'ApiCall.IncludeNewItem = True 'ChkIncludeNew.Checked
            ApiCall.IncludeWatchCount = True

            'If OptModTime.Checked Then
            ApiCall.ModTimeFilter = New TimeFilter(Date.Now.AddDays(-3), Date.Now)
            'ElseIf OptStartTime.Checked Then
            '    ApiCall.StartTimeFilter = New TimeFilter(DatePickStartFrom.Value, DatePickStartTo.Value)
            'ElseIf OptEndTime.Checked Then
            '    ApiCall.EndTimeFilter = New TimeFilter(DatePickEndFrom.Value, DatePickEndTo.Value)
            'End If

            ApiCall.Execute()

            Dim evt As ItemType

            For Each evt In ApiCall.ItemEventList
                Dim listparams(22) As String

                listparams(0) = evt.ItemID
                listparams(1) = evt.Title
                listparams(2) = evt.SellingStatus.CurrentPrice.Value.ToString()
                Try
                    listparams(3) = evt.StartPrice.Value     ' "" 'Startpreis evt.SellingStatus.QuantitySold.ToString()
                Catch ex As Exception

                End Try


                'MsgBox(evt.SellingStatus.HighBidder.Email)

                '# -1 = Update
                If clsDatenbank_modul.chkCockpitItemBidCount(evt.ItemID, evt.SellingStatus.BidCount.ToString()) = "-1" Then
                    Try
                        clsDatenbank_modul.setCockpitItemUpdate(evt.ItemID, evt.SellingStatus.CurrentPrice.Value.ToString(), evt.WatchCount, evt.HitCount, evt.SellingStatus.HighBidder.UserID, evt.SellingStatus.HighBidder.Email, evt.SellingStatus.BidCount.ToString())

                        '# Abrufen der Zusatz informationen über den Benutzer 
                        Dim kunde As New ArrayList
                        kunde = clseBayAPI.geteBayUser(evt.ItemID, evt.SellingStatus.BidCount.ToString())

                        If kunde.Item(3).ToString = "Invalid Request" Then
                            ' Continue For

                        Else
                            '# Profileintrag in DB setztebn 
                            If clsDatenbank_modul.chkYABE_Kunden_isUserStored(evt.SellingStatus.HighBidder.Email, clsDatenbank.datentabelle.yabe_personals_profile) = False Then
                                clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.insert, evt.SellingStatus.BidCount.ToString(), kunde.Item(3).ToString)
                                iCount_insert += 1

                            Else ' vorhanden 


                                clsDatenbank_modul.setYABE_Kunde_newProfile(clsDatenbank.modus.update, evt.SellingStatus.BidCount.ToString(), kunde.Item(3).ToString)
                                iCount_update += 1



                            End If
                        End If
                    Catch ex As Exception

                    End Try
                  
                End If

                listparams(4) = evt.SellingStatus.BidCount.ToString()
                Try
                    listparams(5) = evt.SellingStatus.HighBidder.UserID  '"" 'Email evt.SellingStatus.ListingStatus.ToString()
                Catch ex As Exception

                End Try

                listparams(6) = ""
                listparams(7) = evt.SellingStatus.ListingStatus.ToString()
                listparams(8) = evt.ListingType    'Listtype
                listparams(9) = evt.ListingDetails.EndTime   'Starttime
                listparams(10) = evt.WatchCount
                listparams(11) = evt.ListingDetails.StartTime  'Endtime

                Try
                    listparams(6) = evt.SellingStatus.HighBidder.Email
                Catch ex As Exception

                End Try

                listparams(15) = evt.HitCount
                listparams(17) = "eBay"



                Dim vi As ListViewItem = New ListViewItem(listparams)

                lvwCockpit.Items.Add(vi)

            Next evt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


End Class
