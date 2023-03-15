Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
'Imports System.Web.Mail

Module modBasicFunctions

    Public bCrashReport As Boolean = False
    Public gbl_privoxy_pid As Integer = 0
    Public gbl_tor_pid As Integer = 0
    Public bAbbruch As Boolean = False
    Public iCharsLeft As Double = 0
    Public iCharsUsed As Double = 0
    Public iCharsBuyed As Double = 0
    Public iCharsProzent As Double = 0
    Public strKeyCrypt As String = "EPpm3uphVb2ZkG8E3H8HOIb0nsz8fiC6QiPwZn5WQnzkKKLPn95H7frXy6ElwMOy0jco0r94BK+wRv1RiMqdeeaErh5KDL77QF8KY7OwY0M="
    Public strKey As String = ""
    Public TripleDes As New TripleDESCryptoServiceProvider


    Public Enum bPlattform
        eBay = 0
        delcampe = 1
    End Enum
    Public Enum selectModus
        ganz = 0
        part = 1
    End Enum

    Public Enum optionGUI_Tab_ID
        personal = 0
        allgemein = 1
        eiso_allgemein = 2
        eBay = 3
        paypal = 4
        delcampe = 5
        eiso_shop = 6
        popup = 7
        email_server = 8
        magento = 8
        datenbank_server = 9
        rechnungsdruck = 10
        shopste = 11
    End Enum
    Public bFormLoaded As Boolean = False
    ' zunächst die benötigte API-Deklaration
    Private Declare Function mciSendString Lib "winmm.dll" _
      Alias "mciSendStringA" (
      ByVal lpszCommand As String,
      ByVal lpszReturnString As String,
      ByVal cchReturnLength As Integer,
      ByVal hwndCallback As Integer) As Integer
    Public bAutoModus_Delcampe As Boolean = False

    Public strVersionString As String = "2.1.7"
    Public bIsLoading As Boolean = True
    Public pgrUpdater_global As ProgressBar
    Public strQuery As String
    Public strHTTPDataStore As String

    '###################################
    '# >> Klassendeklaration 
    '###################################
    Public clseBayAPI As New clseAPI_eBay
    Public clsTimer As New clsTimer
    Public clsDatenbank_modul As New clsDatenbank
    Public clsStopuhr As New clsHiPerfTimer
    Public WithEvents clsUpdateDownloader As WebFileDownloader
    Public strPathUpdater As String
    '##################################
    '# >> Globale Vars 
    '##################################

    Public strLogDatei As String = ""
    Public strIniFile As String = ""
    Public bIsRefreshing_live As Boolean = False
    Public bIsRefreshing_bewertungen As Boolean = False
    Public strDateBis As String = ""
    Public strDateVon As String = ""

    Public lvweBayLive As ListView
    Public lvweBayBewertung As ListView

    Public strConnection_master_template As String = "" 'Datenbankverbindung

    Public iGeboteNeu_Anzahl As Integer = 0
    Public iGebote_
    Public iBewertungenNeu_Anzahl As Integer = 0
    Public iBewertungenAbgeben_Anzahl As Integer = 0

    Public frm As New Form
    '########
    '# >> Updater
    '########
    Public strServerInfo() As String
    '#############################################
    '# INI Strukturen
    '#############################################

    '# INI: - eBaydaten
    Public Structure eBayStruct
        Dim strDevName As String
        Dim strAppName As String
        Dim strAppCert As String
        Dim strUserName As String
        Dim strUserPassword As String
        Dim streBayToken As String
        Dim strSoapApiServerUrl As String
        Dim strSignInUrl As String
        Dim strEpsServerUrl As String
        Dim strVersion As String
        Dim strTimeOut As String
        Dim strLogFileName As String
    End Structure

    Public Enum mgetUpdaterMessage
        getNewVersion = 0
        getNewDB = 1
        getNewUser = 2
        getNewYabe_User = 3
        getNewEbay_User = 4
        getShopThumbnail = 5
        setShopDeletePictures = 6
        setShopUserData = 7
        getYABEConfig = 8
        setFTPFOLDER = 9
        setMenue = 10
        setSYM_LINK = 11
        setDelcampe_delete_auction = 12
        setDelcampe_API_add = 13
        getShopsteCategory = 14
        getShopsteShopCategory = 15
        getShopsteCategoryItems = 16
        setShopsteCategories = 17
        chkShopsteEiSoKat = 18
        getEiSo2ShopsteKat = 19
        setShopsteItemAmount = 20
        getShopstePageURL = 21
        getEiSoPassword = 22
        setEiSoPasswordNeu = 23
        setDebugMessage2HTTPServer = 24
        getÜbersetzungGesammtSumme = 25
        setBuyChars = 26
    End Enum


    '# INI: - Allgemeine Einstellungen
    Public Structure startup
        Dim strSplashScreenDauer As String
        Dim strStartModul As String
        Dim lngLiveInterval As String
        Dim lngBewertungInterval As Long
        Dim bÜberwachendesAuktionsendes As Boolean
        Dim bPopUpsAnzeigen As Boolean
        Dim beBayZeit As Boolean
        Dim beBayZückbewertungsystem As Boolean
        Dim lngeBayLiveRefresh As String
    End Structure

    '# INI: - Serverdaten
    Public Structure serverdaten
        Dim strmySQL_server As String
        Dim strmySQL_user As String
        Dim strmySQL_pwd As String
        Dim strSMTP_server As String
        Dim strSMTP_user As String
        Dim strSMTP_pwd As String
        Dim strPOP3_server As String
        Dim bPOP3BeforeSMTP As Boolean
        Dim bMail_reconect As Boolean
    End Structure

    '# INI: - Popup Einstellungen
    Public Structure popup
        Dim lngAnzeigeDauer As String
        Dim bSoundEffekt As Boolean
        Dim strSoundpath As String
    End Structure

    '############################################
    '# >> Stellt die INI Struktur zur Verfügung 
    '############################################
    Public strINI_eBay As eBayStruct
    Public strINI_statup As startup
    Public strINI_serverdaten As serverdaten
    Public strINI_popup As popup

    Public strDebugModus As String = "MSG_OWN_BOX" ' MSG = msgbox / LOG = Datei 
    Public strPlattforms() As String

    Public Enum lvwBlättern_modus
        vor = 1
        back = -1
    End Enum
    Public Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
        System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Public Function DecryptData(
    ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms,
        TripleDes.CreateDecryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function

    Public Function setShopsteConfig(domain_id As String, config_name As String, config_value As String) As String

        Dim Request1 As HttpWebRequest = CType(WebRequest.Create(My.Settings.SHOPSTE_API_URL), HttpWebRequest)
        Request1.Method = "POST"
        Request1.ContentType = "application/x-www-form-urlencoded"
        Dim Post1 As String = "modus=setDomainSetting&domain_id=" & domain_id & "&config_name=" & config_name & "&config_value=" & config_value
        Dim byteArray1() As Byte = Encoding.UTF8.GetBytes(Post1)
        Request1.ContentLength = byteArray1.Length
        Dim DataStream1 As Stream = Request1.GetRequestStream()
        DataStream1.Write(byteArray1, 0, byteArray1.Length)
        DataStream1.Close()
        Dim Response1 As HttpWebResponse = Request1.GetResponse()
        DataStream1 = Response1.GetResponseStream()
        Dim reader1 As New StreamReader(DataStream1)
        Dim ServerResponse1 As String = reader1.ReadToEnd()

        Return ServerResponse1

    End Function

    '########################################################################
    '# >> Google Translate API - Texte übersetzen 
    '########################################################################
    Public Function getTranslateText(ByVal TextToTranslate As String, ByVal lngInput As String, ByVal lngOutput As String) As String
        Dim result As String
        Try

            If TextToTranslate.Length = 0 Then
                Return ""
                Exit Function
            End If

            If iCharsLeft <= 0 Then
                MessageBox.Show("Ihre gekauften Zeichen sind verbraucht " & iCharsUsed & " / " & iCharsBuyed & " (" & iCharsLeft & ") (siehe unten in der Statuszeile)", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim frmBuyChars As New frmBuyChars
                frmBuyChars.Show()
                bAbbruch = True
                Return ""
                Exit Function
            End If


            '# Eingangssprache berücksichtigen 
            TextToTranslate = clsDatenbank_modul.getTranslateSearch_replace(TextToTranslate, lngInput)


            Dim url As String = ""

            If My.Settings.bDEVMODE = "FORK" Then
                url = [String].Format("https://www.googleapis.com/language/translate/v2?key=" & strKey & "&q=" & System.Uri.EscapeDataString(TextToTranslate) & "&source=" & lngInput & "&target=" & lngOutput)
                'frmMain.Text &= " mit Google Translate API"
            ElseIf My.Settings.bDEVMODE = "qW1YY<>"
                url = [String].Format("http://www.google.de/translate_t?hl=de&ie=UTF8&text={0}&langpair={1}|{2}", System.Uri.EscapeDataString(TextToTranslate), lngInput, lngOutput)
                'frmMain.Text &= " DEV-MODE"
            End If

            Dim webClient As New System.Net.WebClient()

            Dim iLänge As Integer = 0
            '  webClient.Encoding = System.Text.Encoding.ASCII
            'webClient.Encoding = System.Text.Encoding.Unicode
            ' webClient.Encoding = System.Text.Encoding.GetEncoding(1251)
            If My.Settings.translate_tor_privoxy = True Then
                Dim str2() As String = My.Settings.translate_proxy.Split(":")
                Dim pr As New System.Net.WebProxy(str2(0), Convert.ToInt16(str2(1)))
                webClient.Proxy = pr
            End If

            ' msgMaster.Text = url
            Application.DoEvents()
            result = webClient.DownloadString(url)


            If My.Settings.bDEVMODE = "FORK" Then
                Dim root
                Dim translation
                Dim pair
                Dim [object] = JsonConvert.DeserializeObject(Of JObject)(result)
                For Each root In [object]("data")
                    For Each translation In root
                        For Each pair In translation
                            'result = pair("translatedText")
                            Dim bytes As Byte() = Encoding.Default.GetBytes(pair("translatedText").ToString)
                            result = Encoding.UTF8.GetString(bytes)
                            ' Console.WriteLine("Translated Text = {0}", pair("translatedText"))
                        Next
                    Next
                Next


                'result = Mid(result, 1, iLänge)

                ' result = Mid(result, result.IndexOf("<span title"), result.IndexOf("'#fff'"">"))
                'result = clsDatenbank_modul.getTranslateSearch_replace(result.Trim, lngOutput)
            ElseIf My.Settings.bDEVMODE = "qW1YY<>"
                Dim match As String = "id=result_box"
                Dim i As Integer = result.IndexOf(match) + 1
                Dim f As Integer = result.IndexOf(match) + 1
                Dim iStart As Integer = 0
                Dim iEnde As Integer = 0
                Dim iLängeLen As Integer = 0
                Dim bExit As Boolean = False
                Dim str() As String

                '##################################
                '# ANFANG und ENDE bestimmen
                '##################################
                result = Mid(result, i, f)
                result = Mid(result, result.IndexOf(">") + 2, Len(result))

                'iStart = result.IndexOf("</div><div id=""translit")

                iStart = result.IndexOf("</div></div><div id=gt-res-tools")
                result = Strings.Left(result, iStart)

                bExit = False
                Dim iCount As Integer = 0
                ReDim str(0)
                iStart = 0
                iEnde = 0

                '########################################
                '# Google Translate 
                '# - Maus Hover Parser 
                '########################################
                While bExit = False

                    ' iLängeGes = result.IndexOf("<span title", iLänge + 1)                
                    iStart = result.IndexOf("'#fff'"">", iStart + 1) ' iStart = result.IndexOf("'#fff'"">", iStart + 1)
                    iEnde = result.IndexOf("</span>", iEnde + 2)

                    If iStart >= 0 Then
                        str(iCount) = Mid(result, iStart, iEnde - (iStart - 1)).Replace("='#fff'"">", "").Replace("</span", "")
                        ReDim Preserve str(UBound(str) + 1)
                        iCount += 1
                    Else
                        bExit = True
                    End If

                End While

                '# String wieder zusammenbauen 
                result = ""
                For iCount = 0 To str.Length - 1
                    result &= str(iCount) & " "
                Next

            End If
            'result = Mid(result, 1, iLänge)

            Call getHTTPResponseMessage("https://api.bludau-media.de/SafeSandy/jtl-translator.php?auth_key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&zeichen=" & TextToTranslate.Length & "&modus=update_anzahl", mgetUpdaterMessage.getÜbersetzungGesammtSumme, False)

            iCharsUsed += TextToTranslate.Length
            iCharsLeft = iCharsBuyed - iCharsUsed
            iCharsProzent = (iCharsUsed / iCharsBuyed) * 100
            frmMain.tssLizenzstatus.Text = "Lizenzstatus: Gekauft | verbraucht: " & iCharsUsed & " von " & iCharsBuyed & " | " & Math.Round(iCharsProzent, 2) & "% ( " & iCharsLeft & " noch offen)"
            If iCharsLeft <= 0 Then
                MessageBox.Show("Ihre gekauften Zeichen sind verbraucht " & iCharsUsed & " / " & iCharsBuyed & " (siehe unten in der Statuszeile)", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim frmBuyChars As New frmBuyChars
                frmBuyChars.Show()
                bAbbruch = True
                Exit Function
            End If

            ' result = Mid(result, result.IndexOf("<span title"), result.IndexOf("'#fff'"">"))
            result = clsDatenbank_modul.getTranslateSearch_replace(result.Trim, lngOutput)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bAbbruch = True
            result = String.Empty

        End Try
        Return result

    End Function

    Public Function URLEncode(ByVal StringToEncode As String, Optional ByVal _
  UsePlusRatherThanHexForSpace As Boolean = False) As String

        Dim TempAns As String = ""
        Dim CurChr As Integer

        CurChr = 1
        Do Until CurChr - 1 = Len(StringToEncode)
            Select Case Asc(Mid$(StringToEncode, CurChr, 1))
                Case 48 To 57, 65 To 90, 97 To 122
                    TempAns = TempAns & Mid$(StringToEncode, CurChr, 1)
                Case 32
                    If UsePlusRatherThanHexForSpace = True Then
                        TempAns = TempAns & "+"
                    Else
                        TempAns = TempAns & "%" & Hex(32)
                    End If
                Case Else
                    TempAns = TempAns & "%" & Hex(Asc(Mid$(StringToEncode,
                      CurChr, 1)))
            End Select
            CurChr = CurChr + 1
        Loop
        URLEncode = TempAns
    End Function

    ' Entschlüsseln von mit URLEncode
    ' verschlüsselten Zeichenketten
    Public Function URLDecode(ByVal StringToDecode As String) As String
        Dim TempAns As String = ""
        Dim CurChr As Integer

        CurChr = 1
        Do Until CurChr - 1 = Len(StringToDecode)
            Select Case Mid$(StringToDecode, CurChr, 1)
                Case "+"
                    TempAns = TempAns & " "
                Case "%"
                    TempAns = TempAns & Chr(Val("&h" &
                      Mid$(StringToDecode, CurChr + 1, 2)))
                    CurChr = CurChr + 2
                Case Else
                    TempAns = TempAns & Mid$(StringToDecode, CurChr, 1)
            End Select
            CurChr = CurChr + 1
        Loop
        URLDecode = TempAns
    End Function

    '#############################################################################
    '# >> Globales Blättern für viele Forms (zurück)
    '#############################################################################
    Public Function setLvwView_blättern(ByVal mModus As lvwBlättern_modus, ByRef lvw As ListView, ByVal btnVor As Button, ByRef btnBack As Button, ByRef txtID As TextBox) As Boolean
        Dim iAnzahl As Integer = 0
        Try

            Select Case mModus
                '# VOR Blättern
                Case lvwBlättern_modus.vor

                    iAnzahl = lvw.SelectedItems(0).Index
                    'lvw.Items(iAnzahl).Selected = False 
                    ' lvw.Items(iAnzahl).Selected = False
                    iAnzahl += 1
                    btnBack.Enabled = True

                    If iAnzahl = lvw.Items.Count - 1 Then
                        btnVor.Enabled = False
                    Else
                        lvw.Items(iAnzahl - 1).Selected = False
                    End If

                    lvw.Items(iAnzahl).Selected = True
                    lvw.Items(iAnzahl).EnsureVisible()

                    Try
                        txtID.Text = lvw.SelectedItems(0).Text
                    Catch ex As Exception

                    End Try




                '# ZURÜCK BLättern 
                Case lvwBlättern_modus.back

                    iAnzahl = lvw.SelectedItems(0).Index
                    'lvw.Items(iAnzahl).Selected = False

                    btnVor.Enabled = True
                    'lvw.Items(iAnzahl).Selected = False
                    iAnzahl -= 1

                    If iAnzahl = 0 Then
                        btnBack.Enabled = False
                    Else
                        lvw.Items(iAnzahl + 1).Selected = False
                    End If

                    lvw.Items(iAnzahl).Selected = True
                    lvw.Items(iAnzahl).EnsureVisible()

                    Try
                        txtID.Text = lvw.SelectedItems(0).Text
                    Catch ex As Exception

                    End Try




            End Select



            Return True

        Catch ex As Exception
            Call debug_message(ex, "")
            Return False
        End Try
    End Function


    ' MP3-Datei abspielen
    Public Function MP3_Play(ByVal sFile As String, ByVal sAlias As String) As Boolean

        ' MCI öffnen
        If mciSendString("open " & Chr(34) & sFile & Chr(34) &
            " type MPEGVideo alias " & sAlias, 0, 0, 0) = 0 Then

            ' MP3 abspielen
            If mciSendString("play " & sAlias & " from 0", 0, 0, 0) = 0 Then
                Return (True)
            End If
        End If
    End Function

    ' Wiedergabe stoppen und MCI schließen
    Public Sub MP3_Stop(ByVal sAlias As String)
        mciSendString("stop " & sAlias, 0, 0, 0)
        mciSendString("close " & sAlias, 0, 0, 0)

    End Sub

    ''' <summary>
    ''' >> Zeigt ein Popup an 
    ''' </summary>
    ''' <param name="strNachricht"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function printPopup(ByVal strNachricht As String) As Boolean
        Try
            Dim frmPopup As New frmPopup
            'frmPopup.TransparencyKey = Color.White
            frmPopup.TopMost = True
            frmPopup.Show()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "printPopup")
            Return False
        End Try
    End Function

    Public Sub CreateMyOpaqueForm()
        ' Create a new form.
        Dim form2 As New Form()
        ' Set the text displayed in the caption.
        form2.Text = "My Form"
        form2.TopMost = True
        'form2.MdiParent = frmMain
        ' Set the opacity to 75%.
        form2.Opacity = 0.75
        ' Size the form to be 300 pixels in height and width.
        form2.Size = New Size(300, 300)
        ' Display the form in the center of the screen.
        form2.StartPosition = FormStartPosition.CenterScreen

        ' Display the form as a modal dialog box.
        form2.ShowDialog()
    End Sub

    '##########################################
    '# >> Ping Prüfung vornehmen 
    '##########################################
    Public Function chkPing(Optional ByVal strHost As String = "bludau-media.de") As Boolean

        If My.Computer.Network.IsAvailable = True Then
            If My.Computer.Network.Ping(strHost) = False Then
                frmMain.master_Message_label.Text = "ACHTUNG: Keine Internetverbindung zum Server gefunden!!!"
                Return False
            Else
                Return True
            End If
        Else
            frmMain.master_Message_label.Text = "ACHTUNG: Keine aktive Netzwerkverbindung gefunden!!!"
        End If

    End Function

    '##########################################
    '# >> Setzte Stopuhr 
    '##########################################
    Public Function setStopuhr(ByVal bModus As Boolean) As String
        Try
            If bModus = True Then
                clsStopuhr.StartStop()
            Else
                Return clsStopuhr.StartStop.Seconds
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setStopuhr")
            Return "-1"
        End Try

        Return "1"
    End Function

    '##########################################
    '# >> Entschlüsseln einer Datei
    '##########################################
    Public Function setDecrypt_file(ByVal strFile As String, ByVal strKey As String, ByVal bSetUpdate As Boolean) As String
        Try
            Dim rd As New RijndaelManaged
            Dim rijndaelIvLength As Integer = 16
            Dim md5 As New MD5CryptoServiceProvider
            Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(strKey))
            Dim encdata() As Byte
            Dim strPfad As String = ""
            Dim strData1 As String = ""
            md5.Clear()

            If File.Exists(strFile) = True Then
                strPfad = strFile
                strData1 = My.Computer.FileSystem.ReadAllText(strFile)
                encdata = Convert.FromBase64String(strData1)
            Else
                encdata = Convert.FromBase64String(strFile)
            End If

            Dim ms As New MemoryStream(encdata)
            Dim iv(15) As Byte

            ms.Read(iv, 0, rijndaelIvLength)
            rd.IV = iv
            rd.Key = key

            Dim cs As New CryptoStream(ms, rd.CreateDecryptor, CryptoStreamMode.Read)

            Dim data(ms.Length - rijndaelIvLength) As Byte
            Dim i As Integer = cs.Read(data, 0, data.Length)
            Dim strData As String = (System.Text.Encoding.UTF8.GetString(data, 0, i))

            If bSetUpdate = True Then
                If File.Exists(strPfad) = True Then
                    My.Computer.FileSystem.WriteAllText(strPfad, strData, False, Encoding.BigEndianUnicode)
                End If
            End If

            cs.Close()
            rd.Clear()

            Return strFile

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setDecrypt_file")
            Return "-1"
        End Try

    End Function

    '##########################################
    '# >> Verschlüsselt eine Datei
    '##########################################
    Public Function setEncrypt_file(ByVal strFile As String, ByVal strKey As String, ByVal bSetUpdate As Boolean) As String
        Dim strData As String = ""
        Dim strpfad As String = ""
        Try

            If File.Exists(strFile) = True Then
                strpfad = strFile
                strData = My.Computer.FileSystem.ReadAllText(strFile)
            Else
                strData = strFile
            End If

            Dim rd As New RijndaelManaged

            Dim md5 As New MD5CryptoServiceProvider
            Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(strKey))

            md5.Clear()
            rd.Key = key
            rd.GenerateIV()

            Dim iv() As Byte = rd.IV
            Dim ms As New IO.MemoryStream

            ms.Write(iv, 0, iv.Length)

            Dim cs As New CryptoStream(ms, rd.CreateEncryptor, CryptoStreamMode.Write)
            Dim data() As Byte = System.Text.Encoding.UTF8.GetBytes(strData)

            cs.Write(data, 0, data.Length)
            cs.FlushFinalBlock()

            Dim encdata() As Byte = ms.ToArray()
            strData = Convert.ToBase64String(encdata)

            If bSetUpdate = True Then
                If File.Exists(strFile) = True Then
                    My.Computer.FileSystem.WriteAllText(strpfad, strData, False, Encoding.BigEndianUnicode)
                End If
            End If

            cs.Close()
            rd.Clear()
            Return strData

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setEncrypt_file")
            Return "-1"
        End Try

    End Function

    '#############################################
    '# >> Schreibt eine XML Datei 
    '#############################################
    Public Sub XMLWriter_INI(ByVal strFile As String)

        ' Auswahl einer Kodierungsart für die Zeichenablage 
        Dim enc As New System.Text.UnicodeEncoding

        ' XmlTextWriter-Objekt für unsere Ausgabedatei erzeugen: 
        Dim XMLobj As Xml.XmlTextWriter = New Xml.XmlTextWriter(strFile, enc)

        With XMLobj

            ' Formatierung: 4er-Einzüge verwenden 
            .Formatting = Xml.Formatting.Indented
            .Indentation = 4

            '# Schreibt default Header 
            .WriteStartDocument()

            '# Hauptnode 
            .WriteStartElement("Config")

            .WriteStartElement("eBayData") 'Unterpunkt von <config>
            .WriteAttributeString("DevName", "F1CNFV5K1I71REJ3B5IH2DM4621CDK")
            .WriteAttributeString("AppName", "PlaneteB-d64f-4a42-9012-98fdec2bb3a6")
            .WriteAttributeString("AppCert", "08b7110c-a798-417b-8157-1c4937f5187a")
            .WriteAttributeString("UserName", "")
            .WriteAttributeString("UserPassword", "")
            .WriteAttributeString("eBayToken", "")
            .WriteAttributeString("SoapApiServerUrl", "https://api.ebay.com/wsapi")
            .WriteAttributeString("SignInUrl", "https://signin.ebay.com/ws/eBayISAPI.dll?SignIn")
            .WriteAttributeString("EpsServerUrl", "http://msa-e1.ebay.com/ws/eBayISAPI.dll?EpsBasicApp")
            .WriteAttributeString("Version", "523")
            .WriteAttributeString("TimeOut", "60000")
            .WriteAttributeString("LogFileName", "Log.txt")
            .WriteEndElement() '# eBayData

            .WriteStartElement("Startup") 'Unterpunkt von <config>
            .WriteAttributeString("Splashscreen", "")
            .WriteAttributeString("Startmodul", "")
            .WriteAttributeString("Interval", "60000") 'angabe in Millisekunden
            .WriteAttributeString("beBayLiveAuktionsende", "false")
            .WriteAttributeString("bPopupshow", strINI_statup.bPopUpsAnzeigen)
            .WriteAttributeString("beBayZeit", strINI_statup.beBayZeit)
            .WriteAttributeString("beBayBewertung_auto", strINI_statup.beBayZückbewertungsystem)
            .WriteAttributeString("beBayLive_auto", strINI_statup.bÜberwachendesAuktionsendes)
            .WriteEndElement() '# Startup

            .WriteStartElement("serverdaten") 'Unterpunkt von <config>
            .WriteAttributeString("mySQL_server", "")
            .WriteAttributeString("mySQL_user", "")
            .WriteAttributeString("mySQL_pwd", "")
            .WriteAttributeString("SMTP_server", "")
            .WriteAttributeString("SMTP_user", "")
            .WriteAttributeString("SMTP_pwd", "")
            .WriteAttributeString("POP3_server", "")
            .WriteAttributeString("bPOP3_before", "true")
            .WriteAttributeString("bMail_reconnect", "false")
            .WriteEndElement() '# End config 

            .WriteStartElement("popup") 'Unterpunkt von <config>
            .WriteAttributeString("lngAnzeige", "6000")
            .WriteAttributeString("bSoundeffekt", "true")
            .WriteAttributeString("bSoundPath", "")
            .WriteEndElement() '# End config 

            ' ... und schließen das XML-Dokument (und die Datei) 
            .Close() ' Document 

        End With
    End Sub

    '###################################################
    '# >> XML Schreiben
    '###################################################
    Public Function setXML_write() As Boolean

        Try
            '# INI Schreiben
            Call XMLWriter_INI(strIniFile)
            '# INI Verschlüsseln
            Call setEncrypt_file(strIniFile, "myDoom", True)
            Return True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setXML_write")
            Return False
        End Try
    End Function

    '################################################
    '# >> Verwaltet die Fehlermeldungen 
    '################################################
    Public Function debug_message(ByVal strMessage As Exception, Optional ByVal strFunktion As String = "") As Boolean
        Dim strFileName As String
        Static iCount_err As Integer = 0


        Dim st As New StackTrace(True)
        st = New StackTrace(strMessage, True)
        Dim sf As StackFrame = st.GetFrame(st.FrameCount - 1)


        Select Case strDebugModus

            '# Nur Nachricht 
            Case "MSG"
                If strMessage.InnerException IsNot Nothing Then
                    MsgBox(strMessage.Message & vbCrLf & vbCrLf & strMessage.InnerException.Message, MsgBoxStyle.Critical)
                Else
                    MsgBox(strMessage, MsgBoxStyle.Critical)
                End If

            '# Nur Log 
            Case "LOG"
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\LOG\" & Date.Today & ".txt", strMessage.Message, True)
            '# NAchricht und Log 
            Case "MSG_LOG"
                '# Schreibt Logdatei 
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\LOG\" & Date.Today, "---------" & vbCrLf & Now & " >> " & strFunktion & vbCrLf & "---------" & vbCrLf & strMessage.Message & vbCrLf, True)
                MsgBox(strMessage, MsgBoxStyle.Critical)
            Case "MSG_OWN_BOX"
                iCount_err += 1

                strFileName = Application.StartupPath & "\LOG\" & Date.Today & ".txt"

                Dim clsDebug As New clsEmail

                If My.Settings.email_pwd.Length > 0 Then
                    clsDebug.setSendDebugReport("EiSo " & strVersionString & " / " & My.Settings.yabe_username & " - Fehlerbericht: Nr." & My.Settings.developer_crashcount, strFileName)
                End If


                If strMessage.InnerException IsNot Nothing Then
                    My.Computer.FileSystem.WriteAllText(strFileName, "---------" & vbCrLf & Now & " >> " & strFunktion & vbCrLf & "---------" & vbCrLf & strMessage.Message & vbCrLf & "Inner Exception:" & strMessage.InnerException.Message & vbCrLf & "Stacktrace:" & sf.GetFileName & vbCrLf & " - " & sf.GetFileLineNumber() & " <br>Quelle: " & strMessage.Source, True)
                Else
                    My.Computer.FileSystem.WriteAllText(strFileName, "---------" & vbCrLf & Now & " >> " & strFunktion & vbCrLf & "---------" & vbCrLf & strMessage.Message & vbCrLf & "Stacktrace:" & sf.GetFileLineNumber() & vbCrLf & "Quelle: " & strMessage.Source, True)
                End If

                frmMain.master_Message_label.Text &= " Fehlerbericht wurde " & My.Settings.developer_email & " zugeschickt"
                If iCount_err >= 1 Then

                    If strMessage.InnerException IsNot Nothing Then

                        setBludauMediaLogbuch(">> FEHLER >> Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & strMessage.InnerException.Message & vbCrLf & vbCrLf & "Zeile:" & sf.GetFileLineNumber() & " - " & sf.GetFileName & vbCrLf, "BUGREPORT")

                        Dim frmFehlerreport As New frmFehlerreport
                        frmFehlerreport.strMessage = "Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & strMessage.InnerException.Message & vbCrLf & vbCrLf & "Zeile:" & sf.GetFileLineNumber() & " -  " & sf.GetFileName & vbCrLf & "Wurde erfolgreich per eMail von den EiSo Entwickler (" & My.Settings.developer_email & ") geschickt."
                        frmFehlerreport.ShowDialog(frmMain)


                    Else

                        setBludauMediaLogbuch("Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & "Zeile:" & st.GetFrame(0).GetFileLineNumber().ToString & " - " & st.GetFrame(0).GetFileName & vbCrLf, "BUGREPORT")

                        Dim frmFehlerreport As New frmFehlerreport
                        frmFehlerreport.strMessage = "Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & "Zeile:" & st.GetFrame(0).GetFileName & " - " & st.GetFrame(0).GetFileLineNumber().ToString & vbCrLf & vbCrLf & "Wurde erfolgreich per eMail von den EiSo Entwickler (" & My.Settings.developer_email & ") geschickt."
                        frmFehlerreport.ShowDialog(frmMain)




                    End If


                ElseIf MsgBox("Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & "Wurde erfolgreich per eMail an den EiSo Entwickler (" & My.Settings.developer_email & ") geschickt.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, strFunktion) = MsgBoxResult.Ok Then

                End If


            Case "MSG_LOG_FTP"

                Dim strData As String = "Systemname: " & My.Computer.Name & vbCrLf

                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\LOG\BenutzerSystem.txt", strData, False)

                '###############################
                '# >> Datensicherungsmodul 
                '###############################



                strFileName = Application.StartupPath & "\LOG\" & Date.Today & ".txt"
                If strMessage.InnerException IsNot Nothing Then
                    My.Computer.FileSystem.WriteAllText(strFileName, "---------" & vbCrLf & Now & " >> " & strFunktion & vbCrLf & "---------" & vbCrLf & strMessage.Message & vbCrLf & "Inner Exception:" & strMessage.InnerException.Message & vbCrLf & "Stacktrace:" & sf.GetFileName & vbCrLf & " - " & sf.GetFileLineNumber() & " <br>Quelle: " & strMessage.Source, True)
                Else
                    My.Computer.FileSystem.WriteAllText(strFileName, "---------" & vbCrLf & Now & " >> " & strFunktion & vbCrLf & "---------" & vbCrLf & strMessage.Message & vbCrLf & "Stacktrace:" & sf.GetFileLineNumber() & vbCrLf & "Quelle: " & strMessage.Source, True)
                End If


                '# Dateinamen festlegen 
                'Dim strFileName As String = "backup_" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & " " & Date.Now.Hour & "_" & Date.Now.Minute & "_" & Date.Now.Second & ".zip"

                ''# Datensicherung vorbereiten
                'Call clsDatensicherung.setZIPFile_output(Application.StartupPath & "\BACKUP\" & strFileName)

                ''# Neu anlegen oder erweitern (ZIP-Instanz anlegen)
                'Call clsDatensicherung.setZIP_NewOrAdd()

                ''# Erzeugen des ZIP Files 
                'clsDatensicherung.setZIPFile(Application.StartupPath & "\LOG\", True)

                ''# Beenden der Datensicherung
                'Call clsDatensicherung.setZIPFile_end()

                ''###############################
                ''# FTP einrichten 
                ''###############################
                'clsFTP.Hostname = "85.25.53.184"
                'clsFTP.Username = "wed"
                'clsFTP.Password = "bugtraqing"
                'Call clsFTP.Upload(Application.StartupPath & "\BACKUP\" & strFileName)

                Dim clsDebug As New clsEmail
                My.Settings.developer_crashcount = My.Settings.developer_crashcount + 1
                My.Settings.Save()


                If My.Settings.email_pwd.Length > 0 Then
                    clsDebug.setSendDebugReport("EiSo " & strVersionString & " / " & My.Settings.yabe_username & " - Fehlerbericht: Nr." & My.Settings.developer_crashcount, strFileName)
                End If


                iCount_err += 1
                frmMain.master_Message_label.Text &= " Fehlerbericht wurde " & My.Settings.developer_email & " zugeschickt"
                If iCount_err >= 1 Then

                    If strMessage.InnerException IsNot Nothing Then

                        setBludauMediaLogbuch(">> FEHLER >> Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & strMessage.InnerException.Message & vbCrLf & vbCrLf & "Zeile:" & sf.GetFileLineNumber() & " - " & sf.GetFileName & vbCrLf, "BUGREPORT")


                        If MsgBox("Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & strMessage.InnerException.Message & vbCrLf & vbCrLf & "Zeile:" & sf.GetFileLineNumber() & " -  " & sf.GetFileName & vbCrLf & "Wurde erfolgreich per eMail von den EiSo Entwickler (" & My.Settings.developer_email & ") geschickt." & vbCrLf & vbCrLf & " Möchten Sie EiSo beenden und neustarten?" & vbCrLf & vbCrLf & "NEIN: Versucht das Programm weiter fortzuführen", MsgBoxStyle.Information + MsgBoxStyle.YesNo, strFunktion) = MsgBoxResult.Yes Then
                            bCrashReport = True
                            frmMain.Close()
                            '# Vorhher 
                            ' end 
                        End If
                    Else

                        setBludauMediaLogbuch("Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & "Zeile:" & st.GetFrame(0).GetFileLineNumber().ToString & " - " & st.GetFrame(0).GetFileName & vbCrLf, "BUGREPORT")

                        If MsgBox("Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & "Zeile:" & st.GetFrame(0).GetFileName & " - " & st.GetFrame(0).GetFileLineNumber().ToString & vbCrLf & vbCrLf & "Wurde erfolgreich per eMail von den EiSo Entwickler (" & My.Settings.developer_email & ") geschickt." & vbCrLf & vbCrLf & " Möchten Sie EiSo beenden und neustarten?" & vbCrLf & vbCrLf & "NEIN: Versucht das Programm weiter fortzuführen", MsgBoxStyle.Information + MsgBoxStyle.YesNo, strFunktion) = MsgBoxResult.Yes Then
                            bCrashReport = True
                            frmMain.Close()
                            '# Vorhher 
                            ' end 
                        End If
                    End If


                ElseIf MsgBox("Fehlerbericht Nr." & iCount_err & ": " & vbCrLf & "- " & strMessage.Message & vbCrLf & vbCrLf & "Wurde erfolgreich per eMail an den EiSo Entwickler (" & My.Settings.developer_email & ") geschickt.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, strFunktion) = MsgBoxResult.Ok Then

                End If

        End Select

        Return True
    End Function

    Public Function setCalcPaypal(ByVal strUmsatz As String, ByVal strVersand As String) As Double
        Dim ges, ges2 As Double

        If IsNumeric(strVersand) = True Then

            '# mehr als 20 Euro
            strUmsatz = strUmsatz.Replace(".", ",")
            If Convert.ToDouble(strUmsatz) > 20 Then

                ges = Val(strUmsatz.Replace(",", ".")) + Val(strVersand.Replace(",", "."))
                If ges > 0 Then
                    ges2 = ges + ((ges / 100) * My.Settings.yabe_func_paypal_21_prozent) - My.Settings.yabe_func_paypal_21_transaktion
                Else
                    ges2 = 0
                End If

            Else
                ges = Val(strUmsatz.Replace(",", ".")) + Val(strVersand.Replace(",", "."))
                If ges > 0 Then
                    ges2 = ges + ((ges / 100) * My.Settings.yabe_func_paypal_20_prozent) + My.Settings.yabe_func_paypal_20_transaktion
                Else
                    ges2 = 0
                End If

                'ges2 = ges + ((ges / 100) * 4.5) + 0.35

            End If
        End If


        Return Math.Round(ges2, 2)

    End Function


    '#############################################
    '# >> INI Pfad Speichern 
    '#############################################
    Public Function setINI(ByVal strFile As String) As Boolean

        strIniFile = strFile
        Return True
    End Function
    Public Function getWMI() As String
        Dim colDisks As Object
        Dim objDisk As Object
        Dim objWMIService As Object
        Dim strComputer As String
        Dim colItems As Object
        Dim objItem As Object
        Dim strMessage As String = ""
        Try

            colDisks = GetObject(
                "Winmgmts:").ExecQuery("Select * from Win32_LogicalDisk")
            strMessage = "<h2>Verfügbare Laufwerke</h2>"
            For Each objDisk In colDisks
                Application.DoEvents()
                Select Case objDisk.DriveType
                    Case 1
                        strMessage &= "Kein Hauptverzeichnis. " _
                            & "Laufwerkstyp konnte nicht bestimmt werden "
                    Case 2
                        strMessage &= "<strong>Bezeichnung:</strong>" & objDisk.Caption & " - " & objDisk.VolumeName & " - Typ: Wechseldatenträger" & vbCrLf
                        strMessage &= "<strong>Seriennummer:</strong>" & objDisk.VolumeSerialNumber & vbCrLf
                        strMessage &= "<strong>Dateisystem:</strong>" & objDisk.FileSystem & vbCrLf
                    Case 3
                        strMessage &= "<strong>Bezeichnung:</strong>" & objDisk.Caption & " - " & objDisk.VolumeName & " - Typ: Festplatte" & vbCrLf
                        strMessage &= "<strong>Seriennummer:</strong>" & objDisk.VolumeSerialNumber & vbCrLf
                        strMessage &= "<strong>Dateisystem:</strong>" & objDisk.FileSystem & vbCrLf
                    Case 4

                        strMessage &= "<strong>Bezeichnung:</strong>" & objDisk.Caption & " - " & objDisk.VolumeName & " - Typ: Netzlaufwerk" & vbCrLf
                        strMessage &= "<strong>Seriennummer:</strong>" & objDisk.VolumeSerialNumber & vbCrLf
                        strMessage &= "<strong>Dateisystem:</strong>" & objDisk.FileSystem & vbCrLf

                    Case 5
                        strMessage &= "<strong>Bezeichnung:</strong>" & objDisk.Caption & " - " & objDisk.VolumeName & " - Typ: CD-ROM" & vbCrLf
                        strMessage &= "<strong>Seriennummer:</strong>" & objDisk.VolumeSerialNumber & vbCrLf
                        strMessage &= "<strong>Dateisystem:</strong>" & objDisk.FileSystem & vbCrLf
                    Case 6
                        strMessage &= "<strong>Bezeichnung:</strong>" & objDisk.Caption & " - " & objDisk.VolumeName & " - Typ: RAM Laufwerk" & vbCrLf
                        strMessage &= "<strong>Seriennummer:</strong>" & objDisk.VolumeSerialNumber & vbCrLf
                        strMessage &= "<strong>Dateisystem:</strong>" & objDisk.FileSystem & vbCrLf

                    Case Else
                        strMessage &= "Laufwerk konnte nicht ermittelt werden." & vbCrLf
                End Select
                strMessage &= "<hr>" & vbCrLf
            Next

            strMessage &= vbCrLf
            strMessage &= "<h2>Gerätemanager</h2>"

            strComputer = "."
            objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
            colItems = objWMIService.ExecQuery("Select * from Win32_PnPEntity")
            For Each objItem In colItems
                Application.DoEvents()
                strMessage &= "<strong>Name: </strong>" & objItem.Name & vbCrLf
                strMessage &= "<strong>Hersteller:</strong> " & objItem.Manufacturer & vbCrLf
                strMessage &= "<strong>Beschreibung:</strong> " & objItem.Description & vbCrLf
                'strMessage &= "Class GUID: " & objItem.ClassGuid & vbCrLf                
                'strMessage &= "Geräte ID: " & objItem.DeviceID & vbCrLf                                
                'strMessage &= "PNP Device ID: " & objItem.PNPDeviceID & vbCrLf
                'strMessage &= "Service: " & objItem.Service & vbCrLf
                strMessage &= "<hr>" & vbCrLf
            Next

            strMessage &= "<h2>Prozessor</h2>"

            strComputer = "."
            objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
            colItems = objWMIService.ExecQuery("Select * from Win32_Processor")
            For Each objItem In colItems
                Application.DoEvents()
                strMessage &= "<strong>Prozessor ID: </strong>" & objItem.ProcessorId & vbCrLf
                strMessage &= "<strong>Geschwindigkeit: </strong>" & objItem.MaxClockSpeed & " Mhz" & vbCrLf
                strMessage &= "<strong>BUS-System: </strong>" & objItem.DataWidth & " Bit" & vbCrLf
                strMessage &= "<strong>Datum: </strong>" & objItem.InstallDate & vbCrLf
            Next

            strMessage &= "<h2>BIOS</h2>"

            strComputer = "."
            objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & strComputer & "\root\CIMV2")
            colItems = objWMIService.ExecQuery("Select * from Win32_BIOS")
            For Each objItem In colItems
                strMessage &= "<strong>BIOS Name: </strong>" & objItem.Name & vbCrLf
                strMessage &= "<strong>Hersteller: </strong>" & objItem.Manufacturer & vbCrLf
            Next

            '# Bildschirmauflösung ermitteln 


            Return strMessage

        Catch ex As Exception
            Call debug_message(ex, "getWMI")
            Return "-1"
        End Try
    End Function
    '#############################################
    '# >> XML Reader liest eine XML Datei 
    '#############################################
    Public Sub XMLReader_INI(ByVal strFile As String, Optional ByVal strModus As String = "INISET")

        ' Wir benötigen einen XmlReader für das Auslesen der XML-Datei 
        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(strFile)

        ' Es folgt das Auslesen der XML-Datei 
        With XMLReader

            Do While .Read ' Es sind noch Daten vorhanden 

                ' Welche Art von Daten liegt an? 
                Select Case .NodeType

                    ' Ein Element 
                    Case Xml.XmlNodeType.Element

                        Console.WriteLine("Es folgt ein Element vom Typ " & .Name)

                        ' Alle Attribute (Name-Wert-Paare) abarbeiten 
                        If .AttributeCount > 0 Then
                            ' Es sind noch weitere Attribute vorhanden 
                            While .MoveToNextAttribute ' nächstes 

                                '# Übergibt werte an die eigentliche Konfiguration
                                If strModus = "INISET" Then

                                    Call getINI_Config(.Name, .Value)

                                ElseIf strModus = "INISTRUCTURE" Then

                                    Call getINI_Structure(.Name, .Value)

                                Else

                                End If

                            End While

                        End If

                    ' Ein Text 
                    Case Xml.XmlNodeType.Text
                        Console.WriteLine("Es folgt ein Text: " & .Value)

                    ' Ein Kommentar 
                    Case Xml.XmlNodeType.Comment
                        Console.WriteLine("Es folgt ein Kommentar: " & .Value)

                End Select

            Loop  ' Weiter nach Daten schauen 

            .Close()  ' XMLTextReader schließen 

        End With

    End Sub

    '#############################################
    '# >> Setzt die INI Config um 
    '#############################################
    Public Function getINI_Config(ByVal strFeldname As String, ByVal strFeldwert As String) As Boolean

        Try
            '# Auswahl der Configuration
            Select Case strFeldname
                Case "DevName"
                    strINI_eBay.strDevName = strFeldwert
                Case "AppName"
                    strINI_eBay.strAppName = strFeldwert
                Case "AppCert"
                    strINI_eBay.strAppCert = strFeldwert
                Case "UserName"
                    strINI_eBay.strUserName = strFeldwert
                Case "UserPassword"
                    strINI_eBay.strUserPassword = strFeldwert
                Case "eBayToken"
                    strINI_eBay.streBayToken = strFeldwert
                Case "SoapApiServerUrl"
                    strINI_eBay.strSoapApiServerUrl = strFeldwert
                Case "SignInUrl"
                    strINI_eBay.strSignInUrl = strFeldwert
                Case "EpsServerUrl"
                    strINI_eBay.strEpsServerUrl = strFeldwert
                Case "Version"
                    strINI_eBay.strVersion = strFeldwert
                Case "TimeOut"
                    strINI_eBay.strTimeOut = strFeldwert
                Case "LogFileName"
                    strINI_eBay.strLogFileName = strFeldwert
                '# POPUPS
                Case "bPopupshow"
                    strINI_statup.bPopUpsAnzeigen = strFeldwert
                Case "beBayZeit"
                    strINI_statup.beBayZeit = strFeldwert
                Case "beBayBewertung_auto"
                    strINI_statup.beBayZückbewertungsystem = strFeldwert
                Case "beBayLive_auto"
                    strINI_statup.lngeBayLiveRefresh = strFeldwert
                Case "beBayLiveAuktionsende"
                    strINI_statup.bÜberwachendesAuktionsendes = strFeldwert
                Case "beBayLive_auto"
                    strINI_statup.lngeBayLiveRefresh = strFeldwert
                '# Serverdaten
                Case "mySQL_server"
                    strINI_serverdaten.strmySQL_server = strFeldwert
                Case "mySQL_user"
                    strINI_serverdaten.strmySQL_user = strFeldwert
                Case "mySQL_pwd"
                    strINI_serverdaten.strmySQL_pwd = strFeldwert
                Case "SMTP_server"
                    strINI_serverdaten.strSMTP_server = strFeldwert
                Case "SMTP_user"
                    strINI_serverdaten.strSMTP_user = strFeldwert
                Case "SMTP_pwd"
                    strINI_serverdaten.strSMTP_pwd = strFeldwert
                Case "POP3_server"
                    strINI_serverdaten.strPOP3_server = strFeldwert
                Case "bPOP3_before"
                    strINI_serverdaten.bPOP3BeforeSMTP = strFeldwert
                Case "bMail_reconnect"
                    strINI_serverdaten.bMail_reconect = strFeldwert

                '# POPUP Einstellungen
                Case "lngAnzeige"
                    strINI_popup.lngAnzeigeDauer = strFeldwert
                Case "bSoundeffekt"
                    strINI_popup.bSoundEffekt = strFeldwert
                Case "bSoundPath"
                    strINI_popup.strSoundpath = strFeldwert

            End Select

        Catch ex As Exception
            Call debug_message(ex)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    '#############################################
    '# >> Speichert die XML - INI in Structure
    '#############################################
    Public Function getINI_Structure(ByVal strFeldname As String, ByVal strFeldwert As String) As Boolean

        Try

            '# Selektiert den INI Wert, damit er richtig zugeordnet werden kann
            Select Case strFeldname

                Case "Splashscreen"
                    strFeldwert = strFeldwert.Replace("Sekunden", "")
                    strFeldwert = strFeldwert.Replace("Sekunde", "")
                    strINI_statup.strStartModul = strFeldwert
                Case "Startmodul"
                    strINI_statup.strStartModul = strFeldwert
                Case "Interval_live"
                    strINI_statup.lngLiveInterval = strFeldwert
                Case "Interval_bwertungen"
                    strINI_statup.lngBewertungInterval = strFeldwert
            End Select

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getINI_Sturcture")
            Return False
        End Try

        Return True
    End Function

    '#############################################
    '# >> Anzeigen von Popup Fenster
    '#############################################
    Public Function getPopUp(ByVal strMessage As String) As Boolean

        Try

            '# Sound abspielen
            If My.Settings.popup_soundfile_an = True Then
                '# Existiert Datei 
                If My.Computer.FileSystem.FileExists(My.Settings.popup_soundfile) = True Then
                    Call MP3_Play(My.Settings.popup_soundfile, "popupsound") ' file abspielen
                End If
            End If

            Dim frmDialog As New frmPopup
            frmDialog.strNachricht = strMessage
            frmDialog.BackColor = Color.WhiteSmoke

            If My.Settings.popup_dauer = "" Then
                My.Settings.popup_dauer = "1"
            End If

            frmDialog.tmrClosedown.Interval = 200 'My.Settings.popup_dauer * 1000
            frmDialog.tmrClosedown.Enabled = True
            frmDialog.Opacity = 0.8
            frmDialog.TopMost = True
            Application.DoEvents()
            frmDialog.Show()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getPopUp")
            Return False
        End Try
        Return True
    End Function



    '#################################################################################################
    '# >> UPDATER: Programm Updates durch Server Verteilen 
    '#################################################################################################
    Public Function setUpdateCheck(ByVal pgrUpdate As ProgressBar, ByVal lblUpdater As Label) As Boolean

        Dim strMessage As String
        Dim iAPPID As Integer = 2  ' YABE UPDATE ID 

        'PRÜFEN ob Datei existiert
        If Not IO.Directory.Exists(strPathUpdater) Then
            ' MessageBox.Show("Kein gültiges Verzeichnis", "Fehler beim Aktualisieren", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Return
        End If

        pgrUpdater_global = pgrUpdate
        'strMessage = "https://api.bludau-media.de/SafeSandy/Update.php?programID=2" & strVersionString
        strMessage = "https://api.bludau-media.de/SafeSandy/Download.php?version==" & strVersionString & "&name=EiSo%20Auktionsabwicklung&key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&programID=2&versionsnummer=" & strVersionString

        If getHTTPResponseMessage(strMessage, mgetUpdaterMessage.getNewVersion, True) = True Then

            'Download starten 
            Try
                pgrUpdate.Visible = True
                lblUpdater.Visible = True

                clsUpdateDownloader = New WebFileDownloader
                'txtDownloadTo.Text.TrimEnd("\"c) 
                Application.DoEvents()
                strServerInfo(1) = strServerInfo(1).Replace("br/>URL=", "")
                clsUpdateDownloader.DownloadFileWithProgress(strServerInfo(1), strPathUpdater & GetFileNameFromURL(strServerInfo(1)))
                pgrUpdate.Visible = False
                lblUpdater.Visible = False

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

        End If

    End Function

    Public Function setBludauMediaLogbuch(strMessage As String, strType As String)

        '# Request erzeugen 
        'MsgBox(strURL)
        Try

            ServicePointManager.ServerCertificateValidationCallback =
            New System.Net.Security.RemoteCertificateValidationCallback(AddressOf frmAuktionmanagement.customCertValidation)

            Dim strURL As String = "https://api.bludau-media.de/SafeSandy/setMessage.php"
            strURL = strURL & "?auth_key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&modus=" & strType & "&message=" & System.Uri.EscapeDataString(strMessage)

            Dim request As WebRequest = WebRequest.Create(strURL)

            '# Server - Login 
            request.Credentials = CredentialCache.DefaultCredentials

            '# Server - Antwort 
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            '# Status anzeigen 
            Console.WriteLine(response.StatusDescription)

            '# Hole den Stream 
            Dim dataStream As Stream = response.GetResponseStream()

            '# Benutzerstream Reader zum einlesen 
            Dim reader As New StreamReader(dataStream)

            '# Alles einlesen 
            Dim responseFromServer As String = reader.ReadToEnd()


            strServerInfo = responseFromServer.Split("<br>")

            If strServerInfo.Length > 0 Then
                If strServerInfo(0).IndexOf("ERR:") >= 0 Then

                    If Not strServerInfo(0) = "ERR: Konnte Ordner eBay/TN_--- nicht finden" Then
                        MsgBox(strServerInfo(0).Replace("ERR:", "").Replace("br>", ""), MsgBoxStyle.Critical)
                    End If

                    Return False
                    Exit Function
                End If
            End If


            Return True
        Catch ex As Exception
            debug_message(ex, "setBludauMediaLogbuch")
            Return False
        End Try

    End Function


    '#################################################################################################
    '# >> UPDATER: Nachricht abgreifen 
    '#################################################################################################
    Public Function getHTTPResponseMessage(ByVal strURL As String, ByVal mModus As mgetUpdaterMessage, ByVal bMessage As Boolean) As Boolean
        Dim strData As String = ""
        Try


            '# Request erzeugen 
            'MsgBox(strURL)

            ServicePointManager.ServerCertificateValidationCallback =
            New System.Net.Security.RemoteCertificateValidationCallback(AddressOf frmAuktionmanagement.customCertValidation)

            Dim request As WebRequest = WebRequest.Create(strURL)

            '# Server - Login 
            request.Credentials = CredentialCache.DefaultCredentials

            '# Server - Antwort 
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            '# Status anzeigen 
            Console.WriteLine(response.StatusDescription)

            '# Hole den Stream 
            Dim dataStream As Stream = response.GetResponseStream()

            '# Benutzerstream Reader zum einlesen 
            Dim reader As New StreamReader(dataStream)

            '# Alles einlesen 
            Dim responseFromServer As String = reader.ReadToEnd()


            strServerInfo = responseFromServer.Split("<br>")

            If strServerInfo.Length > 0 Then
                If strServerInfo(0).IndexOf("ERR:") >= 0 Then

                    If Not strServerInfo(0) = "ERR: Konnte Ordner eBay/TN_--- nicht finden" Then
                        MsgBox(strServerInfo(0).Replace("ERR:", "").Replace("br>", ""), MsgBoxStyle.Critical)
                    End If

                    Return False
                    Exit Function
                End If
            End If


            '# Welcher Modus 
            Select Case mModus
                Case mgetUpdaterMessage.getÜbersetzungGesammtSumme
                    frmMain.master_Message_label.Text = strServerInfo(0)
                Case mgetUpdaterMessage.setDebugMessage2HTTPServer
                    If strServerInfo(0).Contains("Debug Nachricht gesendet") = True Then
                        frmMain.master_Message_label.Text = "Fehlerprotokoll übertragen"
                    Else
                        frmMain.master_Message_label.Text = strServerInfo(0)
                    End If
                    frmMain.master_Message_label.Text = strServerInfo(0)
                Case mgetUpdaterMessage.setEiSoPasswordNeu
                    frmMain.master_Message_label.Text = strServerInfo(0)
                Case mgetUpdaterMessage.getEiSoPassword
                    frmMain.master_Message_label.Text = strServerInfo(0)
                Case mgetUpdaterMessage.setDelcampe_API_add

                    frmMain.master_Message_label.Text = strServerInfo(5)

                Case mgetUpdaterMessage.setDelcampe_delete_auction
                    If bAutoModus_Delcampe = False Then
                        MsgBox(strServerInfo(0), MsgBoxStyle.Information)
                    Else
                        frmMain.master_Message_label.Text = strServerInfo(0)
                    End If

                Case mgetUpdaterMessage.setSYM_LINK
                    If bMessage = True Then
                        MsgBox(strServerInfo(0), MsgBoxStyle.Information)

                    End If
                Case mgetUpdaterMessage.getShopsteCategory

                    My.Computer.FileSystem.WriteAllText("shopste-kategorie.dat", responseFromServer, False)

                Case mgetUpdaterMessage.getShopsteShopCategory

                    My.Computer.FileSystem.WriteAllText("shopste-subshop.dat", responseFromServer, False)

                Case mgetUpdaterMessage.getShopsteCategoryItems

                    My.Computer.FileSystem.WriteAllText("shopste-kategorie-items.dat", responseFromServer, False)
                Case mgetUpdaterMessage.getEiSo2ShopsteKat
                    strHTTPDataStore = strServerInfo(0).ToString
                Case mgetUpdaterMessage.setShopsteItemAmount

                    strHTTPDataStore = strServerInfo(0).ToString

                Case mgetUpdaterMessage.setShopsteCategories

                    strHTTPDataStore = strServerInfo(0).ToString
                    If strServerInfo.Length - 1 > 0 Then
                        MessageBox.Show(strServerInfo(0).ToString)
                    End If
                Case mgetUpdaterMessage.chkShopsteEiSoKat
                    strHTTPDataStore = strServerInfo(0).ToString
                Case mgetUpdaterMessage.getShopstePageURL
                    strHTTPDataStore = strServerInfo(0).ToString
                Case mgetUpdaterMessage.getYABEConfig

                    If Not strServerInfo(0) = "Nicht eingeloggt" Then

                        If strServerInfo(31).Replace("br>", "") = "INTERN" Then
                            My.Settings.user_vorname = strServerInfo(0).Replace("br>", "")
                            My.Settings.user_nachname = strServerInfo(1).Replace("br>", "")
                            My.Settings.user_strasse = strServerInfo(2).Replace("br>", "")
                            My.Settings.user_ort = strServerInfo(3).Replace("br>", "")
                            My.Settings.user_plz = strServerInfo(4).Replace("br>", "")
                            My.Settings.user_land = strServerInfo(5).Replace("br>", "")
                            My.Settings.user_email = strServerInfo(6).Replace("br>", "")
                            My.Settings.bank_name = strServerInfo(7).Replace("br>", "")
                            My.Settings.bank_nr = strServerInfo(8).Replace("br>", "")
                            My.Settings.bank_IBAN = strServerInfo(9).Replace("br>", "")
                            My.Settings.bank_BIC = strServerInfo(10).Replace("br>", "")
                            My.Settings.user_USTID = strServerInfo(11).Replace("br>", "")
                            My.Settings.email_absende_name = strServerInfo(12).Replace("br>", "")
                            My.Settings.bank_leitzahl = strServerInfo(13).Replace("br>", "")
                            My.Settings.yabe_keycode = strServerInfo(14).Replace("br>", "")
                            My.Settings.email_smtp = strServerInfo(18).Replace("br>", "")
                            My.Settings.email_pop3 = strServerInfo(19).Replace("br>", "")
                            My.Settings.email_username = strServerInfo(20).Replace("br>", "")
                            My.Settings.email_pwd = strServerInfo(21).Replace("br>", "")
                            My.Settings.email_versand_username = strServerInfo(20).Replace("br>", "")
                            My.Settings.shop_url = strServerInfo(22).Replace("br>", "")
                            My.Settings.ftp_server = strServerInfo(22).Replace("br>", "")
                            My.Settings.ftp_username = strServerInfo(23).Replace("br>", "")
                            My.Settings.ftp_pwd = strServerInfo(24).Replace("br>", "")
                            My.Settings.ftp_hochladepfad = strServerInfo(25).Replace("br>", "")



                            ' neu 2015-08-23
                            My.Settings.delcampe_api_token = strServerInfo(27).Replace("br>", "")
                            My.Settings.eiso_shopname = strServerInfo(28).Replace("br>", "")
                            My.Settings.user_firmenname = strServerInfo(28).Replace("br>", "")
                            My.Settings.EISO_SERVER = strServerInfo(29).Replace("br>", "")
                            My.Settings.user_firmenname = strServerInfo(30).Replace("br>", "") 'da...

                            My.Settings.datenbank_username = strServerInfo(15).Replace("br>", "")
                            My.Settings.datenbank_pwd = strServerInfo(16).Replace("br>", "")
                            My.Settings.EISO_PREFIX = strServerInfo(32).Replace("br>", "") 'da...
                            My.Settings.datenbank_db = My.Settings.EISO_PREFIX & strServerInfo(14).Replace("br>", "")
                            My.Settings.datenbank_server = My.Settings.EISO_SERVER

                            '# DEFAULT Verzeichnis verboten 
                            If My.Settings.ftp_hochladepfad = "/eBay/" Or My.Settings.ftp_hochladepfad.Length = 0 Then
                                '# Ordner erzeugen
                                If getHTTPResponseMessage("http://api.bludau-media.de/EiSo/ftp.php?mod=FTP_FOLDER&usr=" & My.Settings.yabe_username, mgetUpdaterMessage.setFTPFOLDER, True) = False Then

                                Else
                                    My.Settings.ftp_hochladepfad = "/httpdocs/eBay/" & My.Settings.yabe_username
                                End If
                            End If
                        Else
                            '#
                            '# EXTERN
                            '#
                            My.Settings.datenbank_username = strServerInfo(15).Replace("br>", "")
                            My.Settings.datenbank_pwd = strServerInfo(16).Replace("br>", "")
                            My.Settings.EISO_PREFIX = strServerInfo(32).Replace("br>", "") 'da...
                            My.Settings.datenbank_db = My.Settings.EISO_PREFIX & strServerInfo(14).Replace("br>", "")
                            My.Settings.EISO_SERVER = strServerInfo(29).Replace("br>", "")
                            My.Settings.datenbank_server = My.Settings.EISO_SERVER
                        End If

                        My.Settings.Save()

                    Else
                        ' MsgBox("Sie wurden nicht eingeloggt als '" & My.Settings.yabe_username & "'", MsgBoxStyle.Exclamation)
                        frmMain.master_Message_label.Text = "Nicht eingeloggt"
                        Return False
                    End If
                '# FTP ORDNER ANLEGEN 
                Case mgetUpdaterMessage.setFTPFOLDER

                    If Not strServerInfo(0).Length = 0 Then
                        ' MsgBox(strServerInfo(0), MsgBoxStyle.Information)
                    End If
                '# SHOP MENÜ ERZEUGEN 
                Case mgetUpdaterMessage.setMenue
                    frmMain.master_Message_label.Text = strServerInfo(0)
                Case mgetUpdaterMessage.setShopUserData
                    If bMessage = True Then
                        '  MsgBox(strServerInfo(0), MsgBoxStyle.Information)

                    End If
                '# Löschen von Bildern 
                Case mgetUpdaterMessage.setShopDeletePictures

                    If bMessage = True Then
                        MsgBox(strServerInfo(0) + vbCrLf + strServerInfo(1), MsgBoxStyle.Information)
                    End If
                '# Thumbnails erzeugen 
                Case mgetUpdaterMessage.getShopThumbnail

                    If bMessage = True Then
                        MsgBox(strServerInfo(0), MsgBoxStyle.Information)
                    End If


                Case mgetUpdaterMessage.getNewVersion

                    If strServerInfo.Length >= 2 Then
                        strServerInfo(1) = strServerInfo(1).Replace("br>", "")
                        strServerInfo(1) = strServerInfo(1).Replace("URL:", "")
                    End If

                    If strServerInfo.Length >= 3 Then
                        strServerInfo(2) = strServerInfo(2).Replace("br>", "")
                        strServerInfo(2) = strServerInfo(2).Replace("ZEITPUNKT:", "")
                    End If

                    If strServerInfo.Length >= 4 Then
                        strServerInfo(3) = strServerInfo(3).Replace("br>", "")
                        strServerInfo(3) = strServerInfo(3).Replace("VERSION:", "")
                    End If

                    If strServerInfo.Length >= 5 Then
                        strServerInfo(4) = strServerInfo(4).Replace("br>", "")
                        strServerInfo(4) = strServerInfo(4).Replace("COMMENT:", "")
                    End If

                    If strServerInfo.Length > 0 Then

                        Select Case strServerInfo(0)
                            Case "NEUSTE_VERSION_VORHANDEN"
                                'clsUpdateDownloader.chkUpdateModus = WebFileDownloader.chkModus.ok
                                frmMain.master_Message_label.Text = "Neuste Version vorhanden: " & Date.Now
                                Return False
                                Exit Function
                            Case "FEHLER:Kein_Versionsstring"
                                'clsUpdateDownloader.chkUpdateModus = WebFileDownloader.chkModus.fehler
                                frmMain.master_Message_label.Text = "Fehler kein Versionsstring gefunden, bitte manuell von https://bludau-media.de/ herunterladen.."
                                Return False
                                Exit Function
                            Case "DOWNLOAD_NOW"
                                'clsUpdateDownloader.chkUpdateModus = WebFileDownloader.chkModus.update
                                frmMain.master_Message_label.Text = "Neues Update vom " & strServerInfo(2) & " | Version: " & strServerInfo(3) & " : " & Date.Now
                                Return True
                        End Select

                    End If

                    '# Anzeigen des Inhalts 
                    Console.WriteLine(responseFromServer)
                Case mgetUpdaterMessage.getNewDB

                    If strServerInfo(0) = "ALLES_OK" Then
                        frmMain.master_Message_label.Text = "Datenbank wurde angelegt"
                    End If

                Case mgetUpdaterMessage.getNewYabe_User

                    Dim str() As String
                    Dim str2() As String
                    str = strServerInfo(0).Split(":")
                    str2 = strServerInfo(1).Split(":")

                    If str(1) = str2(1) Then
                        'MsgBox(str(1), MsgBoxStyle.Information)
                        frmMain.master_Message_label.Text = str(1)
                    Else
                        frmMain.master_Message_label.Text = "Benutzer:" & str(1) & vbCrLf & "Lokal:" & str2(1)
                    End If


                Case mgetUpdaterMessage.getNewUser
                    Dim str() As String
                    '# Benutzer bereits angelegt 
                    If strServerInfo(0).Contains("Duplicate entry") Then

                    Else
                        My.Settings.datenbank_username = strServerInfo(0)

                        My.Settings.datenbank_db = strServerInfo(2).Replace("br>", "")

                        My.Settings.datenbank_pwd = strServerInfo(1).Replace("br>", "")
                    End If


                    My.Settings.Save()



                Case mgetUpdaterMessage.getNewEbay_User


                    MsgBox(strServerInfo(0))

            End Select


            '# Alle Resourcen schließen 
            reader.Close()
            dataStream.Close()
            response.Close()
            Return True
        Catch ex As Exception

            setBludauMediaLogbuch(">> FEHLER >> MELDUNG: " & ex.Message, "BUGREPORT")

            If ex.Message.Contains("Der Remoteserver hat einen Fehler zurückgegeben: (500) Interner Serverfehler.") = True Then
                MessageBox.Show("Es gibt einen Serverfehler bei '" & My.Settings.EISO_SERVER & "' die API Schnittstelle ist derzeit offline, bitte versuchen Sie es in ein paar Minuten erneut", "500 Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call debug_message(ex, strQuery & vbCrLf & "getHTTPResponseMessage")
            End If

            Return False
        End Try
        Return strData
    End Function

    '#################################################################################################
    '# >> UPDATER: Dateigröße 
    '#################################################################################################
    Public Sub _Downloader_FileDownloadSizeObtained(ByVal iFileSize As Long) Handles clsUpdateDownloader.FileDownloadSizeObtained
        pgrUpdater_global.Value = 0
        pgrUpdater_global.Maximum = Convert.ToInt32(iFileSize)
    End Sub

    '#################################################################################################
    '# >> UPDATER: Download beendet 
    '#################################################################################################
    Public Sub _Downloader_FileDownloadComplete() Handles clsUpdateDownloader.FileDownloadComplete
        Dim strMessage As String

        Try
            pgrUpdater_global.Value = pgrUpdater_global.Maximum

            strMessage = setBR(strServerInfo(4))
        Catch ex As Exception

        End Try





        'If MessageBox.Show("Update erfolgreich durchgeführt" & vbCrLf & "Jetzt Update " & strServerInfo(3) & " installieren?" & vbCrLf & strMessage, "Updater...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = Application.StartupPath & "\Updater" & GetFileNameFromURL(strServerInfo(1))
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()

        Application.Exit()

        ' End If
    End Sub


    '#####################################################################
    '# Ausgeben des Namens von einer URL 
    '#####################################################################
    Public Function GetFileNameFromURL(ByVal URL As String) As String
        If URL.IndexOf("/"c) = -1 Then Return String.Empty

        Return "\" & URL.Substring(URL.LastIndexOf("/"c) + 1)
    End Function

    Public Function setBR(ByVal strData As String) As String
        Try

            strData = vbCrLf & strData.Replace("|br|", vbCrLf)
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setBR")
            Return "-1"
        End Try

        Return strData
    End Function

    '#################################################################################################
    '# >> UPDATER: Wieviel wurder heruntergeladen 
    '#################################################################################################
    Private Sub _Downloader_AmountDownloadedChanged(ByVal iNewProgress As Long) Handles clsUpdateDownloader.AmountDownloadedChanged
        pgrUpdater_global.Value = Convert.ToInt32(iNewProgress)
        ' lblUpdater.Text = WebFileDownloader.FormatFileSize(iNewProgress) & " von " & WebFileDownloader.FormatFileSize(pgrUpdater_global.Maximum) & " downloaded"
        Application.DoEvents()
    End Sub

    '######################################################
    '# >> Verknüpfung erzeugen
    '######################################################

    '  Public Function CreateShortcut(ByVal sLinkFile As String, _
    'ByVal sTargetFile As String, _
    'Optional ByVal sArguments As String = "", _
    'Optional ByVal sDescription As String = "", _
    'Optional ByVal sWorkingDir As String = "") As Boolean

    '      Try
    '          Dim oShell As New Shell32.Shell
    '          Dim oFolder As Shell32.Folder
    '          Dim oLink As Shell32.ShellLinkObject

    '          ' Ordner und Dateinamen extrahieren
    '          Dim sPath As String = sLinkFile.Substring(0, sLinkFile.LastIndexOf("\"))
    '          Dim sFile As String = sLinkFile.Substring(sLinkFile.LastIndexOf("\") + 1)

    '          ' Wichtig! Link-Datei erstellen (0 Bytes)
    '          Dim F As Short = FreeFile()
    '          FileOpen(F, sLinkFile, OpenMode.Output)
    '          FileClose(F)

    '          oFolder = oShell.NameSpace(sPath)
    '          oLink = oFolder.Items.Item(sFile).GetLink

    '          ' Eigenschaften der Verknüpfung
    '          With oLink
    '              If sArguments.Length > 0 Then .Arguments = sArguments
    '              If sDescription.Length > 0 Then .Description = sDescription
    '              If sWorkingDir.Length > 0 Then .WorkingDirectory = sWorkingDir
    '              .Path = sTargetFile

    '              ' Verknüpfung speichern
    '              .Save()
    '          End With

    '          ' Objekte zerstören
    '          oLink = Nothing
    '          oFolder = Nothing
    '          oShell = Nothing

    '          Return True

    '      Catch ex As Exception
    '          ' Fehler! ggf. Link-Datei löschen, falls bereit erstellt
    '          If System.IO.File.Exists(sLinkFile) Then Kill(sLinkFile)
    '          Return False
    '      End Try
    '  End Function

    '######################################################
    '# >> Anwendung bereits gestartet
    '######################################################
    Public Function AppPrevInstance(Optional ByVal bShowMsg As Boolean = True,
      Optional ByVal bAppActivate As Boolean = True) As Boolean

        ' Anzahl der gestarteten Prozesse der eigenen Anwendung
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
            ' Hinweis anzeigen
            If bShowMsg Then MsgBox("Anwendung wird bereits ausgeführt!")

            ' Erst-Anwendung aktivieren
            If bAppActivate Then
                AppActivate(Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)(0).Id)
            End If

            Return True
        End If
    End Function

    '##########################################
    '# >> Magento Beschreibung erstellen 
    '##########################################
    Public Function setBeschreibungsLänge(ByVal strData As String, ByVal iWords As Integer) As String
        Dim str() As String
        Dim strData_words As String = ""
        Dim iCount As Integer = 0
        Try


            str = strData.Split(" ")
            For iCount = 0 To str.Length - 1

                If str(iCount) = "!" Or str(iCount) = "," Or str(iCount) = "." Then

                Else
                    strData_words &= str(iCount) & " "
                End If



                If iCount >= iWords And strData_words.Length > 60 Then
                    Exit For
                End If

            Next iCount


            Return strData_words
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "-1"
        End Try
    End Function


    Public Function ListviewToCSV(ByVal oLV As ListView, ByVal sFile As String, ByVal bIncludeHidden As Boolean, Optional ByVal strCat As frmAuktionmanagement.export_targets = frmAuktionmanagement.export_targets.standard, Optional ByVal mModus As selectModus = selectModus.ganz, Optional ByVal aryAuktion As ArrayList = Nothing) As Boolean
        Try
            Dim i As Integer
            Dim oItem As ListViewItem
            Dim sData As String = ""
            Dim sLine As String = ""
            Dim Q As String = Chr(34)
            Dim QC As String = Chr(34) + ";"
            Dim iCount As Integer = 0
            Dim iCount_anzahl As Integer = 0
            Dim strBild As String = ""
            Dim strBild_TN As String = ""
            Dim strBeschreibung_tmp As String = ""

            oLV.BeginUpdate()

            Select Case oLV.Name

                Case "lvwWebArtikel"

                    '#####################################################
                    '# >> Auswahl der Export Plattform
                    '#####################################################
                    Select Case strCat


                        '# >>  Export -> Delcampe Artikel 
                        Case frmAuktionmanagement.export_targets.delcampe

                            '# Trennzeichen für Delcampe ändern 
                            QC = ";"
                            Q = ""


                            sLine = Q + "DELCAMPE LISTER CSV FILE VERSION 1.1" + QC

                            sData += DropChar(sLine, 1) + vbNewLine


                            sLine = Q + "country" + QC
                            sLine += Q + "id_site" + QC
                            sLine += Q + "id_category" + QC
                            sLine += Q + "title" + QC
                            sLine += Q + "personal_reference" + QC
                            sLine += Q + "description" + QC
                            sLine += Q + "img1" + QC
                            sLine += Q + "img2" + QC
                            sLine += Q + "img3" + QC
                            sLine += Q + "currency" + QC ' Listview
                            sLine += Q + "price_starting" + QC ' Listview
                            sLine += Q + "price_increment" + QC ' Listview
                            sLine += Q + "net_price" + QC
                            sLine += Q + "reserve_price" + QC
                            sLine += Q + "duration" + QC
                            sLine += Q + "renew" + QC
                            sLine += Q + "end_time" + QC
                            sLine += Q + "prefered_end_day" + QC
                            sLine += Q + "user_note" + QC
                            sLine += Q + "date_sent" + QC ' Hauptbild einfügen 
                            sLine += Q + "to_send" + QC ' Thumbnail
                            sLine += Q + "option_lastminutebidding" + QC
                            sLine += Q + "option_private_auction" + QC
                            sLine += Q + "option_subtitle" + QC
                            sLine += Q + "subtitle" + QC
                            sLine += Q + "option_boldtitle" + QC
                            sLine += Q + "option_highlight" + QC
                            sLine += Q + "option_coloredborder" + QC
                            sLine += Q + "option_toplisting" + QC
                            sLine += Q + "option_topcategory" + QC

                            sLine += Q + "option_topmain" + QC
                            sLine += Q + "option_keepoptionsonrenewal" + QC

                            sData += DropChar(sLine, 1) + vbNewLine

                            '# >> Delcampe Vorlage holen                            
                            Dim strSprache() As String = aryAuktion.Item(13).ToString().Split("_")

                            If strSprache(1) = "de" Then
                                strSprache(1) = strSprache(1).Replace("de", "")
                            Else
                                strSprache(1) = "_" & strSprache(1).ToString
                            End If

                            Dim strBeschreibung As String = clsDatenbank_modul.getTranslationText(strSprache(0), "Text" & strSprache(1)).Replace("&gt;", ">")

                            If IO.Directory.Exists(My.Settings.yabe_delcampe_bilder) = False Then
                                MsgBox("Bitte die Optionen aufrufen und ein gültiges Verzeichnis im Tab 'Delcampe' auswählen" & vbCrLf & "Abbruch des Export, weil keine Bilder auf der Festplatte gefunden wurden", MsgBoxStyle.Exclamation)
                                Return False
                                Exit Function
                            End If


                            Dim Delcampe As New clsDelcampe
                            '# Verfügbare Sprachen laden
                            frmMain.master_Message_label.Text = "Lade mögliche Sprachen..."
                            Delcampe.strISO_ary = clsDatenbank_modul.getSprache_ISO_Ary()

                            iCount_anzahl = oLV.SelectedItems.Count
                            frmMain.master_verlauf.Value = 0
                            frmMain.master_verlauf.Visible = True
                            frmMain.master_verlauf.Maximum = iCount_anzahl

                            Select Case mModus
                                Case selectModus.ganz
                                    '################################################################
                                    '# >> Artikel aus dem Listview holen 
                                    '################################################################                                    
                                    For Each oItem In oLV.Items



                                        iCount += 1
                                        If iCount Mod 2 = 0 Then
                                            Application.DoEvents()
                                            frmMain.master_verlauf.Value = iCount
                                            frmMain.master_Message_label.Text = iCount & " / " & iCount_anzahl & "  - " & oItem.SubItems(1).Text
                                        End If

                                        '# Filte Delcampe ID 1 und -1 
                                        If Not oItem.SubItems(5).Text = "1" And Not oItem.SubItems(5).Text = "-1" Then
                                            frmMain.master_Message_label.Text = iCount & " / " & iCount_anzahl & "  - " & oItem.SubItems(1).Text

                                            sLine = Delcampe.getCSVExport_Repeat(oLV, sFile, bIncludeHidden, sLine, strSprache, strBeschreibung, oItem, YabE.selectModus.part, aryAuktion)

                                            sData += DropChar(sLine, 1) + vbNewLine
                                        End If

                                    Next

                                Case selectModus.part

                                    '################################################################
                                    '# >> Artikel aus dem Listview holen 
                                    '################################################################                                                              
                                    For Each oItem In oLV.SelectedItems

                                        iCount += 1
                                        If iCount Mod 2 = 0 Then
                                            Application.DoEvents()
                                            frmMain.master_verlauf.Value = iCount
                                            frmMain.master_Message_label.Text = iCount & " / " & iCount_anzahl & "  - " & oItem.SubItems(1).Text
                                        End If


                                        '# Filte Delcampe ID 1 und -1 
                                        If Not oItem.SubItems(5).Text = "1" And Not oItem.SubItems(5).Text = "-1" Then


                                            sLine = Delcampe.getCSVExport_Repeat(oLV, sFile, bIncludeHidden, sLine, strSprache, strBeschreibung, oItem, YabE.selectModus.part, aryAuktion)

                                            sData += DropChar(sLine, 1) + vbNewLine
                                        End If

                                    Next

                            End Select

                            frmMain.master_verlauf.Visible = False

                        '################################################
                        '# >>  Export  -> Magento Artikel 
                        '################################################
                        Case frmAuktionmanagement.export_targets.magento
                            sLine += Q + "sku" + QC
                            sLine += Q + "store" + QC
                            sLine += Q + "websites" + QC
                            sLine += Q + "attribute_set" + QC
                            sLine += Q + "type" + QC
                            sLine += Q + "category_ids" + QC
                            sLine += Q + "has_options" + QC
                            sLine += Q + "name" + QC ' Listview
                            sLine += Q + "price" + QC ' Listview
                            sLine += Q + "description" + QC ' Listview
                            sLine += Q + "short_description" + QC
                            sLine += Q + "weight" + QC
                            sLine += Q + "status" + QC
                            sLine += Q + "visibility" + QC
                            sLine += Q + "tax_class_id" + QC
                            sLine += Q + "qty" + QC
                            sLine += Q + "min_qty" + QC
                            sLine += Q + "image" + QC ' Hauptbild einfügen 
                            sLine += Q + "small_image" + QC ' Thumbnail
                            sLine += Q + "thumbnail" + QC


                            sData += DropChar(sLine, 1) + vbNewLine
                            Dim magento_export As New clsMagentoAPI

                            Select Case mModus
                                Case selectModus.ganz
                                    For Each oItem In oLV.Items

                                        sLine = magento_export.setCSVExporter(oItem, aryAuktion)
                                        sData += DropChar(sLine, 1) + vbNewLine

                                    Next
                                Case selectModus.part
                                    For Each oItem In oLV.SelectedItems

                                        sLine = magento_export.setCSVExporter(oItem)
                                        sData += DropChar(sLine, 1) + vbNewLine

                                    Next
                            End Select

                        '###############################################
                        '# >> STANDARD EXPORT 
                        '###############################################
                        Case frmAuktionmanagement.export_targets.standard

                            sLine = Q + "ID" + QC


                            'Header erzeugen
                            For i = 0 To oLV.Columns.Count - 1
                                'Versteckt => Breite größer als 0 
                                If bIncludeHidden Or oLV.Columns(i).Width > 0 Then
                                    'Alle Leerzeichen entfernen
                                    sLine += Q + Replace(oLV.Columns(i).Text, " ", "") + QC
                                End If
                            Next


                            sData += DropChar(sLine, 1) + vbNewLine

                            Select Case mModus
                                Case selectModus.ganz

                                    For Each oItem In oLV.Items
                                        sLine = IIf(IsNumeric(oItem.Tag), oItem.Tag + ";", Q + oItem.Tag + QC)
                                        For i = 0 To oItem.SubItems.Count - 1
                                            If bIncludeHidden Or oLV.Columns(i).Width > 0 Then
                                                'wrap the nonnumeric fields in quotes
                                                sLine += IIf(IsNumeric(oItem.SubItems(i).Text), oItem.SubItems(i).Text + ";", Q + oItem.SubItems(i).Text + QC)
                                            End If
                                        Next
                                        sData += DropChar(sLine, 1) + vbNewLine
                                    Next

                                Case selectModus.part

                                    For Each oItem In oLV.SelectedItems
                                        sLine = IIf(IsNumeric(oItem.Tag), oItem.Tag + ";", Q + oItem.Tag + QC)
                                        For i = 0 To oItem.SubItems.Count - 1
                                            If bIncludeHidden Or oLV.Columns(i).Width > 0 Then
                                                'wrap the nonnumeric fields in quotes
                                                sLine += IIf(IsNumeric(oItem.SubItems(i).Text), oItem.SubItems(i).Text + ";", Q + oItem.SubItems(i).Text + QC)
                                            End If
                                        Next
                                        sData += DropChar(sLine, 1) + vbNewLine
                                    Next

                            End Select



                    End Select



                '################################################
                '# >>  Standard Export eines Listviews 
                '################################################

                Case Else

                    sLine = Q + "ID" + QC


                    'Header erzeugen
                    For i = 0 To oLV.Columns.Count - 1
                        'Versteckt => Breite größer als 0 
                        If bIncludeHidden Or oLV.Columns(i).Width > 0 Then
                            'Alle Leerzeichen entfernen
                            sLine += Q + Replace(oLV.Columns(i).Text, " ", "") + QC
                        End If
                    Next


                    sData += DropChar(sLine, 1) + vbNewLine

                    For Each oItem In oLV.Items
                        sLine = IIf(IsNumeric(oItem.Tag), oItem.Tag + ";", Q + oItem.Tag + QC)
                        For i = 0 To oItem.SubItems.Count - 1
                            If bIncludeHidden Or oLV.Columns(i).Width > 0 Then
                                'wrap the nonnumeric fields in quotes
                                sLine += IIf(IsNumeric(oItem.SubItems(i).Text), oItem.SubItems(i).Text + ";", Q + oItem.SubItems(i).Text + QC)
                            End If
                        Next
                        sData += DropChar(sLine, 1) + vbNewLine
                    Next

            End Select



            'Delete any existing file of the same name
            Dim oFI As New IO.FileInfo(sFile)
            If oFI.Exists Then
                oFI.Delete()
            End If
            Dim oFS As New IO.FileStream(sFile, IO.FileMode.CreateNew, IO.FileAccess.Write)
            Dim oSW As New IO.StreamWriter(oFS, Encoding.UTF8)
            oSW.Write(sData)
            oSW.Flush()
            oSW.Close()
            oFS.Close()
            oLV.EndUpdate()
            Return True
        Catch Exc As Exception
            oLV.EndUpdate()
            Return Exc.Message
        End Try
    End Function

    Public Function DropChar(ByVal sText As String, Optional ByVal iCharToDrop As Integer = 1) As String
        Try
            Dim sTemp As String
            sTemp = Trim(LTrim(sText))
            sTemp = Left(sTemp, sTemp.Length - iCharToDrop)
            Return sTemp
        Catch Exc As Exception
            Throw Exc
        End Try
    End Function

    '# Verschlüsseln von DATEN 
    Public Function Encrypt(ByVal plainText As String) As String
        ' Declare a UTF8Encoding object so we may use the GetByte
        ' method to transform the plainText into a Byte array.
        Dim utf8encoder As UTF8Encoding = New UTF8Encoding()
        Dim bytValue() As Byte
        Dim gstrHash As String
        Dim inputInBytes() As Byte = utf8encoder.GetBytes(plainText)

        ' Create a new TripleDES service provider
        Dim tdesProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()

        ' The ICryptTransform interface uses the TripleDES
        ' crypt provider along with encryption key and init vector
        ' information
        bytValue = System.Text.Encoding.UTF8.GetBytes(plainText)
        Dim cryptoTransform As ICryptoTransform = tdesProvider.CreateEncryptor(bytValue, bytValue)

        ' All cryptographic functions need a stream to output the
        ' encrypted information. Here we declare a memory stream
        ' for this purpose.
        Dim encryptedStream As MemoryStream = New MemoryStream()
        Dim cryptStream As CryptoStream = New CryptoStream(encryptedStream, cryptoTransform, CryptoStreamMode.Write)

        ' Write the encrypted information to the stream. Flush the information
        ' when done to ensure everything is out of the buffer.
        cryptStream.Write(inputInBytes, 0, inputInBytes.Length)
        cryptStream.FlushFinalBlock()
        encryptedStream.Position = 0

        ' Read the stream back into a Byte array and return it to the calling
        ' method.
        Dim result(encryptedStream.Length - 1) As Byte
        encryptedStream.Read(result, 0, encryptedStream.Length)
        cryptStream.Close()

        gstrHash = Convert.ToBase64String(result)
        Return gstrHash
    End Function

    Public Function HttpUploadFile(
     ByVal uri As String,
     ByVal filePath As String,
     ByVal fileParameterName As String,
     ByVal contentType As String,
     ByVal otherParameters As Specialized.NameValueCollection) As String

        Dim boundary As String = "---------------------------" & DateTime.Now.Ticks.ToString("x")
        Dim newLine As String = System.Environment.NewLine
        Dim boundaryBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(newLine & "--" & boundary & newLine)
        Dim request As HttpWebRequest = WebRequest.Create(uri)
        Dim strReturn As String = "-1"

        request.ContentType = "multipart/form-data; boundary=" & boundary
        request.Method = "POST"
        request.KeepAlive = True
        request.Credentials = CredentialCache.DefaultCredentials

        Using requestStream As IO.Stream = request.GetRequestStream()

            Dim formDataTemplate As String = "Content-Disposition: form-data; name=""{0}""{1}{1}{2}"

            For Each key As String In otherParameters.Keys

                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length)
                Dim formItem As String = String.Format(formDataTemplate, key, newLine, otherParameters(key))
                Dim formItemBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(formItem)
                requestStream.Write(formItemBytes, 0, formItemBytes.Length)

            Next key

            requestStream.Write(boundaryBytes, 0, boundaryBytes.Length)

            Dim headerTemplate As String = "Content-Disposition: form-data; name=""{0}""; filename=""{1}""{2}Content-Type: {3}{2}{2}"
            Dim header As String = String.Format(headerTemplate, fileParameterName, filePath, newLine, contentType)
            Dim headerBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(header)
            requestStream.Write(headerBytes, 0, headerBytes.Length)

            Using fileStream As New IO.FileStream(filePath, IO.FileMode.Open, IO.FileAccess.Read)

                Dim buffer(4096) As Byte
                Dim bytesRead As Int32 = fileStream.Read(buffer, 0, buffer.Length)

                Do While (bytesRead > 0)

                    requestStream.Write(buffer, 0, bytesRead)
                    bytesRead = fileStream.Read(buffer, 0, buffer.Length)

                Loop

            End Using

            Dim trailer As Byte() = System.Text.Encoding.ASCII.GetBytes(newLine & "--" + boundary + "--" & newLine)
            requestStream.Write(trailer, 0, trailer.Length)

        End Using

        Dim response As WebResponse = Nothing

        Try

            response = request.GetResponse()

            Using responseStream As IO.Stream = response.GetResponseStream()

                Using responseReader As New IO.StreamReader(responseStream)

                    Dim responseText = responseReader.ReadToEnd()
                    strReturn = responseText
                    Diagnostics.Debug.Write(responseText)

                End Using

            End Using

        Catch exception As WebException

            response = exception.Response

            If (response IsNot Nothing) Then

                Using reader As New IO.StreamReader(response.GetResponseStream())

                    Dim responseText = reader.ReadToEnd()
                    strReturn = responseText
                    Diagnostics.Debug.Write(responseText)

                End Using

                response.Close()

            End If

        Finally

            request = Nothing

        End Try

        Return strReturn

    End Function

    Function TorStarup() As Boolean
        Dim p = New Process()
        Dim bStarted As Boolean = False
        p.StartInfo.FileName = Application.StartupPath & "\Tor\tor.exe"
        p.StartInfo.Arguments = " -f .\torrc-defaults -controlport 9051 -hashedcontrolpassword 16:6C5A0892C58419E160285695991BEDD067449F845E14735A6FBAB0829B"
        p.StartInfo.WorkingDirectory = Application.StartupPath & "\Tor\"
        bStarted = p.Start()
        Try
            gbl_tor_pid = p.Id
            bStarted = True
        Catch ex As Exception
            bStarted = False
        End Try
        Return bStarted
    End Function

    Function PrivoxyStarup() As Boolean
        Dim p = New Process()
        Dim bStarted As Boolean = False
        p.StartInfo.FileName = Application.StartupPath & "\Privoxy\privoxyStart.bat"
        p.StartInfo.WorkingDirectory = Application.StartupPath & "\Privoxy\"
        ' p.StartInfo.Arguments = " config.txt"
        bStarted = p.Start()
        Try
            gbl_privoxy_pid = p.Id
            bStarted = True
        Catch ex As Exception
            bStarted = False
        End Try
        Return bStarted
    End Function
    Function setKillbyPID(pid As Integer) As Boolean
        Try
            Dim aProcess As System.Diagnostics.Process
            aProcess = System.Diagnostics.Process.GetProcessById(pid)
            aProcess.Kill()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function
    '#######################################################
    '# Prozess suchen
    '#######################################################
    Function getProzessIDbySearch(strProzessName As String) As Integer

        Dim arrProcList() As Process
        Dim STATUS As Integer
        STATUS = 0
        arrProcList = Process.GetProcesses
        Dim PID As Integer = 0
        For i As Integer = 0 To arrProcList.Length - 1
            If STATUS = 0 Then
                If arrProcList(i).ProcessName = strProzessName Then
                    STATUS = 1
                    PID = arrProcList(i).Id
                End If
            Else
                'lblRunning.Text = "Running!"
                'lblRunning.ForeColor = Color.Red
            End If
        Next

        If STATUS = 1 Then
            Return PID
        Else
            If STATUS = 0 Then
                Return -1
            End If
        End If

    End Function
    Public Function getMonthStart(GivenDate As DateTime) As DateTime
        Dim MonthStart As DateTime = New DateTime()
        MonthStart = GivenDate.AddDays(-GivenDate.Day + 1)
        Return MonthStart
    End Function

    Public Function getMonthEnd(givenDate As DateTime) As DateTime
        Dim MonthEnd As DateTime = New DateTime()
        MonthEnd = givenDate.AddDays(32)
        MonthEnd = MonthEnd.AddDays(-MonthEnd.Day)
        Return MonthEnd
    End Function

End Module
