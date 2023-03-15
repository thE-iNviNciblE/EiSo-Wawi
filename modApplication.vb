Imports JTLRechnung.lvwSorter
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.NetworkInformation

Module modApplication
    Public WithEvents clsUpdateDownloader2 As WebFileDownloader
    Public pgrUpdater_global As ProgressBar
    Public strServerInfo() As String
    Public strVersionsNummer As String = "2.1.7"
    Public iUpdateNummer As Integer = 2
    Public bExitProgramm As Boolean = False
    Public bRegistered As Boolean = False
    Public Enum mgetUpdaterMessage_updater
        getNewVersion = 0
        sendAuthCode = 1
        getAuthCode = 2
        getIstBuyed = 3
        getProgramUpdateCheck = 4
    End Enum

    Private col As Integer

    Public des As New cTripleDES("fGE1NXdvcnFEcjB3U1NAUDIxMDlqdWh0", "N2EhIVdvcj8=")

    Public gbl_KeyCode As String

    Public Function Base64Encode(plainText As String) As String

        Dim plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)

        Return System.Convert.ToBase64String(plainTextBytes)
    End Function

    Public Function Base64Decode(base64EncodedData As String) As String
        Dim base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData)
        Return System.Text.Encoding.UTF8.GetString(base64EncodedBytes)
    End Function

    Public Function settings_crypt(bEncrypt As Boolean, strData As String) As String

        Dim strReturn As String = ""

        If strData.Length > 0 Then


            If bEncrypt = True Then
                'MessageBox.Show(des.Encrypt(strData))
                Try
                    'strReturn = des.Encrypt(Base64Encode(strData))
                    strReturn = des.Encrypt2(strData)
                Catch ex As Exception
                    frmMain.master_Message_label.Text = ex.Message
                End Try

            Else
                ' MessageBox.Show(des.Decrypt(strData))
                Try
                    '  MessageBox.Show(Base64Decode(des.Decrypt(strData)))
                    strReturn = des.Decrypt2(strData)
                Catch ex As Exception
                    frmMain.master_Message_label.Text = ex.Message
                End Try

            End If
        End If
        ' for the example, define a variable with the encrypted value
        'Private ReadOnly encryptedData As String = "++XIiGymvbg="

        ' now, decrypt the data
        'Private decryptedData As String = 

        ' the value of decryptedData should be "test",
        ' but for our example purposes, let's re-encrypt it
        'Private newEncryptedData As String = des.Encrypt(decryptedData)
        Return strReturn
    End Function



    '######################################################
    '# >> Schlüssel berechnen 
    '######################################################
    Public Function getWMI_KeyCode() As String
        Dim strHDD As String = ""
        Dim strCPU As String = ""
        Dim strKeyCode As String = ""
        Try

            strHDD = getWMI_HDD_Serial()
            If strHDD = "-1" Or strHDD = "" Then
                MsgBox("Fehler beim Empfangen der HDD Serial", MsgBoxStyle.Critical)
                Exit Function
            End If

            Dim strMAC As String = getMacAddress() & "AAAA"

            ''PC ID 
            'strCPU = getWMI_CPU()
            'If strCPU = "-1" Or strCPU = "" Then
            '    MsgBox("Fehler beim empfangen der MAC Addresse", MsgBoxStyle.Critical)
            '    Exit Function
            'End If

            Dim strProg As String = "EiSo Auktionsabwicklung"
            strKeyCode = Encrypt_updater(strHDD & strMAC)

            strKeyCode = strKeyCode.Replace("+", "")
            strKeyCode = strKeyCode.Replace("=", "")
            'strKeyCode = strKeyCode.Substring(0, 7)

            Return strKeyCode
        Catch ex As Exception
            MessageBox.Show("Kann WMI Daten für Schlüsselgenerierung nicht erzeugen!" & vbCrLf & ex.Message, "getWMI_KeyCode", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "-1"
        End Try
    End Function

    '##############################################################
    '# >> Encrypt
    '# Verschlüsseln von DATEN 
    '##############################################################
    Public Function Encrypt_updater(ByVal plainText As String) As String
        ' Declare a UTF8Encoding object so we may use the GetByte
        ' method to transform the plainText into a Byte array.
        Dim utf8encoder As UTF8Encoding = New UTF8Encoding()
        Dim bytValue() As Byte
        Dim gstrHash As String
        Dim inputInBytes() As Byte = utf8encoder.GetBytes(plainText & "EiSo Auktionsabwicklung")

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

    Public Function getMacAddress() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                    'Exclude Tunnels, Loopbacks and PPP
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For ' Got a mac so exit for
                        End If

                End Select
            Next adapter

            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    '# WMI MAC 
    Private Function getWMI_CPU() As String
        Dim strCPU As String = ""
        Dim objWMIService As Object
        Dim colItems As Object
        Dim objItem As Object
        Dim strComputer As String = "."

        Try

            objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
            colItems = objWMIService.ExecQuery("Select * from Win32_Processor")

            For Each objItem In colItems
                Application.DoEvents()
                'lstServerMessage.Items.Add("-- HDD INFO --")
                'lstServerMessage.Items.Add("Prozessor ID:" & objItem.ProcessorId)
                strCPU = objItem.ProcessorId
                'lstServerMessage.Items.Add("Geschwindigkeit:" & objItem.MaxClockSpeed & " Mhz")
                'lstServerMessage.Items.Add("BUS-System:" & objItem.DataWidth & " Bit")
                'lstServerMessage.Items.Add("Datum:" & objItem.InstallDate)
                'lstServerMessage.Items.Add("-- ENDE --")
                'lstServerMessage.Items.Add("")
            Next

            Return strCPU
        Catch ex As Exception
            Return "-1"
        End Try
    End Function

    '#  WMI HDD Serial 
    Private Function getWMI_HDD_Serial() As String
        Dim strHDD As String = ""
        Dim colDisks As Object
        Dim objDisk As Object

        Try
            colDisks = GetObject( _
               "Winmgmts:").ExecQuery("Select * from Win32_LogicalDisk")

            For Each objDisk In colDisks
                Application.DoEvents()
                Select Case objDisk.DriveType

                    Case 3
                        'lstServerMessage.Items.Add("-- HDD INFO --")
                        'lstServerMessage.Items.Add("Bezeichnung: " & objDisk.Caption & " - " & objDisk.VolumeName & " - Typ: Festplatte")
                        'lstServerMessage.Items.Add("Seriennummer: " & objDisk.VolumeSerialNumber)
                        'lstServerMessage.Items.Add("Dateisystem: " & objDisk.FileSystem)
                        'lstServerMessage.Items.Add("-- ENDE --")
                        'lstServerMessage.Items.Add("")
                        strHDD = objDisk.VolumeSerialNumber
                        Exit For
                End Select
            Next

            Return strHDD
        Catch ex As Exception

            Return "-1"
        End Try
    End Function

    '######################################################################
    '# >> Spaltenansicht speichern
    '######################################################################
    Public Function setLVWColumOrder(ByVal lvwData As ListView) As Boolean
        Try
            Dim iCount As Integer = 0
            Dim strData As String = ""
            For iCount = 0 To lvwData.Columns.Count - 1
                strData &= iCount & "-" & lvwData.Columns(iCount).DisplayIndex & "-" & lvwData.Columns(iCount).Width & vbCrLf
            Next

            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/colums_" & lvwData.Name & ".dat", strData, False)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Speichern der Spalten", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '######################################################################
    '# >> Spaltenansicht laden 
    '######################################################################
    Public Function getLVWColumOrder(ByVal lvwData As ListView) As Boolean
        Try
            Dim strFilename As String = Application.StartupPath & "/colums_" & lvwData.Name & ".dat"

            If IO.File.Exists(strFilename) = True Then
                Dim strData As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/colums_" & lvwData.Name & ".dat")
                Dim strZeilen() As String = strData.Split(vbCrLf)
                Dim iCount As Integer = 0

                For iCount = 0 To strZeilen.Length - 2
                    Dim strZeilen_sub() As String = strZeilen(iCount).Split("-")
                    lvwData.Columns(iCount).DisplayIndex = strZeilen_sub(1)
                    lvwData.Columns(iCount).Width = strZeilen_sub(2)
                Next
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Laden der Spalten", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '#################################################################
    '# >> Sortieren 
    '#################################################################
    Public Function setSort(ByRef listview1 As ListView, ByVal e As  _
      System.Windows.Forms.ColumnClickEventArgs) As Boolean
        Try

            If col = e.Column Then
                If listview1.Sorting = SortOrder.Descending Then
                    listview1.Sorting = SortOrder.Ascending
                Else
                    listview1.Sorting = SortOrder.Descending
                End If
            Else
                listview1.Sorting = SortOrder.Ascending
            End If

            col = e.Column

            '################################
            '# >> Kundenauswahl: Alle Kunden
            '################################
            Select Case listview1.Name
                Case "lvwKunde"
                    Select Case col
                        Case 5
                            listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        Case Else
                            listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                    End Select
                    Call repaint(listview1)
            End Select
            '#############################
            '# >> Hauptform: Alle Artikel 
            '#############################
            Select Case listview1.Name
                Case "lvwArtikel_alle"
                    Select Case col
                        Case 3
                            'MessageBox.Show(e.Column.GetType.ToString)
                            listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                        Case 4
                            listview1.ListViewItemSorter = New lvsorter(Of Decimal)(e.Column)
                        Case 5
                            listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                        Case 6
                            listview1.ListViewItemSorter = New lvsorter(Of Decimal)(e.Column)
                        Case 7
                            listview1.ListViewItemSorter = New lvsorter(Of Decimal)(e.Column)
                        Case 8
                            listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                        Case 9
                            listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                        Case Else
                            listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                    End Select
                    Call repaint(listview1)
            End Select
            '####################################
            '# >> Hauptform: Kategorien anzeigen 
            '####################################
            Select Case listview1.Name
                Case "lvwArtikel_kategorien"
                    Select Case col
                        Case 5
                            listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        Case Else
                            listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                    End Select
                    Call repaint(listview1)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Sortieren", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Sub repaint(ByVal listview1 As ListView)
        '# Neu einfärben
        Dim i As Integer = 0
        For i = 0 To listview1.Items.Count - 1

            If i Mod 2 = 0 Then
                listview1.Items(i).BackColor = Color.White
            Else
                listview1.Items(i).BackColor = Color.WhiteSmoke
            End If


        Next
    End Sub


    ''#####################################################################
    ''# Ausgeben des Namens von einer URL 
    ''#####################################################################
    'Public Function GetFileNameFromURL(ByVal URL As String) As String
    '    If URL.IndexOf("/"c) = -1 Then Return String.Empty

    '    Return "\" & URL.Substring(URL.LastIndexOf("/"c) + 1)
    'End Function

    '#################################################################################################
    '# >> UPDATER: Programm Updates durch Server Verteilen 
    '#################################################################################################
    Public Function setUpdateCheck_updater(ByVal pgrUpdate As ProgressBar, ByVal lblUpdater As Label) As Boolean

        Dim strMessage As String
        Dim iAPPID As Integer = 2  ' YABE UPDATE ID 

        'PRÜFEN ob Datei existiert
        If Not IO.Directory.Exists(Application.StartupPath & "\Updater\") Then
            ' MessageBox.Show("Kein gültiges Verzeichnis", "Fehler beim Aktualisieren", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Return
        End If

        pgrUpdater_global = pgrUpdate
        strMessage = "https://api.bludau-media.de/SafeSandy/Download.php?version=" & strVersionsNummer & "&name=EiSo%20Auktionsabwicklung&key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&programID=2&versionsnummer=" & strVersionsNummer

        Dim strServerInfo() As String = getHTTPResponseMessage_updater(strMessage, mgetUpdaterMessage_updater.getNewVersion, True)

        'Download starten 
        Try
            pgrUpdate.Visible = True
            lblUpdater.Visible = True

            clsUpdateDownloader = New WebFileDownloader
            'txtDownloadTo.Text.TrimEnd("\"c) 
            Application.DoEvents()
            clsUpdateDownloader.DownloadFileWithProgress(strServerInfo(1).ToString.Replace("br/>URL=", ""), Application.StartupPath & "\Updater\" & GetFileNameFromURL(strServerInfo(1).ToString.Replace("br/>URL=", "")))
            pgrUpdate.Visible = False
            lblUpdater.Visible = False

            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try



    End Function
    '#################################################################################################
    '# >> UPDATER: Dateigröße 
    '#################################################################################################
    Public Sub _Downloader_FileDownloadSizeObtained(ByVal iFileSize As Long) Handles clsUpdateDownloader2.FileDownloadSizeObtained
        pgrUpdater_global.Value = 0
        pgrUpdater_global.Maximum = Convert.ToInt32(iFileSize)
    End Sub
    'Public Function setBR(ByVal strData As String) As String
    '    Try

    '        strData = vbCrLf & strData.Replace("|br|", vbCrLf)
    '    Catch ex As Exception
    '        'Call debug_message(ex, strQuery & vbCrLf & "setBR")
    '        Return "-1"
    '    End Try

    '    Return strData
    'End Function
    '#################################################################################################
    '# >> UPDATER: Wieviel wurder heruntergeladen 
    '#################################################################################################
    Private Sub _Downloader_AmountDownloadedChanged(ByVal iNewProgress As Long) Handles clsUpdateDownloader2.AmountDownloadedChanged
        pgrUpdater_global.Value = Convert.ToInt32(iNewProgress)
        'lblUpdater.Text = WebFileDownloader.FormatFileSize(iNewProgress) & " von " & WebFileDownloader.FormatFileSize(pgrUpdater_global.Maximum) & " downloaded"
        Application.DoEvents()
    End Sub

    '#################################################################################################
    '# >> UPDATER: Download beendet 
    '#################################################################################################
    Public Sub _Downloader_FileDownloadComplete() Handles clsUpdateDownloader2.FileDownloadComplete
        Dim strMessage As String

        Try
            pgrUpdater_global.Value = pgrUpdater_global.Maximum
            Application.DoEvents()
            strMessage = setBR(strServerInfo(4))
        Catch ex As Exception

        End Try


        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = Application.StartupPath & "\Updater" & GetFileNameFromURL(strServerInfo(1))
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
        Application.Exit()



    End Sub

    '#################################################################################################
    '# >> UPDATER: Nachricht abgreifen 
    '#################################################################################################
    Public Function getHTTPResponseMessage_updater(ByVal strURL As String, ByVal mModus As mgetUpdaterMessage, ByVal bMessage As Boolean) As String()
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


            strServerInfo = responseFromServer.Split("<br/>")




            '# Welcher Modus 
            Select Case mModus

                Case mgetUpdaterMessage_updater.getNewVersion

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

                                Exit Function
                            Case "FEHLER:Kein_Versionsstring"
                                'clsUpdateDownloader.chkUpdateModus = WebFileDownloader.chkModus.fehler
                                frmMain.master_Message_label.Text = "Fehler kein Versionsstring gefunden, bitte manuell von http://bludau-media.de herunterladen.."

                                Exit Function
                            Case "DOWNLOAD_NOW"
                                'clsUpdateDownloader.chkUpdateModus = WebFileDownloader.chkModus.update
                                frmMain.master_Message_label.Text = "Neues Update vom " & strServerInfo(2) & " | Version: " & strServerInfo(3) & " : " & Date.Now

                        End Select

                    End If
                Case mgetUpdaterMessage_updater.sendAuthCode
                    Return strServerInfo
                    '############################################################
                    '# ABRUFEN DES AUTHCODES + DEMOENDE DATUM 
                    '############################################################
                Case mgetUpdaterMessage_updater.getAuthCode

                    Return strServerInfo


                Case mgetUpdaterMessage_updater.getIstBuyed
                    Return strServerInfo
                Case mgetUpdaterMessage_updater.getProgramUpdateCheck
                    Return strServerInfo

            End Select


            '# Alle Resourcen schließen 
            reader.Close()
            dataStream.Close()
            response.Close()
            Return strServerInfo
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "getHTTPResponseMessage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim str(0) As String
            str(0) = "ERR:" & ex.Message.ToString

            Return str
        End Try

    End Function

    Public Function getDateTimeVar(strmySQLDatum As String) As DateTime
        Try
            Dim strDatumSplit() As String = strmySQLDatum.Split(" ")
            Dim strDatumReal() As String = strDatumSplit(0).Split("-")

            Return strDatumReal(2) & "." & strDatumReal(1) & "." & strDatumReal(0) & " " & strDatumSplit(1)
        Catch ex As Exception

        End Try
    End Function

End Module
