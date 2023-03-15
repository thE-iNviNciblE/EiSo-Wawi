'##################################################################################################
'# >> Hauptformular
'#
'# Datum: 09.09.07
'#       - Formulardesign
'#
'# Datum: 10.09.07
'#       - Formulardesign
'# Datum: bis 15.10.2007
'#       - eBay API Calls 
'#           >> getSellerList
'#           >> getFeedbackList
'#           >> leaveFeedback
'#           >> getItem
'# 
'#
'##################################################################################################
Imports System
Imports System.Reflection
Imports System.Globalization
Imports System.Configuration.ConfigurationSettings
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util
Imports System.Net.NetworkInformation
Imports System.ComponentModel

Public Class frmMain


    'Public frmManage As New frmAuktionmanagement 
    Public frmManage As New frmAuktionmanagement
    Public Context As ApiContext
    Public bIsLoading As Boolean = False


    Public Function setLoadOptionForm() As Boolean
        Dim frmOption As New frmOptions
        frmOption.Show()
        Return True
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
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gbl_KeyCode = getWMI_KeyCode()
        strPathUpdater = Application.StartupPath & "\Updater"


        Dim key = "ydgjLMjRj39hZPde451b"
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)

        ' strKeyCrypt = settings_crypt(True, strKeyCrypt)

        'strKey = DecryptData(strKeyCrypt)
        strKey = "AIzaSyDOrJ1t7xVawckFvy6_NNZ4SaD8JzdZn_8"


        '    If My.Settings.bInitCrypt = False Then
        'My.Settings.ebay_pwd = settings_crypt(True, My.Settings.ebay_pwd)
        ' My.Settings.datenbank_pwd = settings_crypt(True, My.Settings.datenbank_pwd)
        'My.Settings.email_pwd = settings_crypt(True, My.Settings.email_pwd)
        'My.Settings.newsletter_versand_pwd = settings_crypt(True, My.Settings.newsletter_versand_pwd)
        'My.Settings.delcampe_pwd = settings_crypt(True, My.Settings.delcampe_pwd)
        'My.Settings.APP_paypal_pwd = settings_crypt(True, My.Settings.APP_paypal_pwd)
        'My.Settings.ftp_pwd = settings_crypt(True, My.Settings.ftp_pwd)
        'My.Settings.magento_pwd = settings_crypt(True, My.Settings.magento_pwd)
        'My.Settings.bInitCrypt = True
        ' MessageBox.Show("Passw�rter jetzt verschl�sselt" & My.Settings.datenbank_pwd)
        '  My.Settings.Save()
        ' End If

        '# -> Daten setzten 
        clsDatenbank_modul.setINITDB("", "")







        Dim strServerInfo() As String = getHTTPResponseMessage_updater(My.Settings.ServerDatenaustausch_https & "://api.bludau-media.de/SafeSandy/IsRegistered.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&versionsnummer=" & strVersionsNummer, mgetUpdaterMessage_updater.getIstBuyed, True)

        Try


            If Not strServerInfo Is Nothing Then

                iCharsUsed = Convert.ToDouble(strServerInfo(1).Replace("br/>", ""))
                iCharsBuyed = Convert.ToDouble(strServerInfo(2).Replace("br/>", ""))
                iCharsLeft = iCharsBuyed - iCharsUsed

                If Not iCharsUsed = 0 Then
                    iCharsProzent = Math.Round(((iCharsUsed / iCharsBuyed) * 100))
                Else
                    iCharsProzent = 0
                End If



                Me.tssLizenzstatus.Text = "Lizenzstatus: " & strServerInfo(0) & " | Zeichen verbraucht: " & iCharsUsed & " von " & iCharsBuyed & " gekauften Zeichen | " & iCharsProzent & "%"

                If Not strServerInfo(0) = "GEKAUFT" Then
                    Dim frmRegisterEiSo As New frmDemoVersion
                    frmRegisterEiSo.ShowDialog()
                End If

            Else
                Dim frmRegisterEiSo As New frmDemoVersion
                frmRegisterEiSo.ShowDialog()
            End If
        Catch ex As Exception
            debug_message(ex, "frmMain_load_form")
            Dim frmRegisterEiSo As New frmDemoVersion
            frmRegisterEiSo.ShowDialog()
        End Try


        If My.Settings.app_autoupdate = True Then

            Dim strServerInfo1() As String = getHTTPResponseMessage_updater(My.Settings.ServerDatenaustausch_https & "://api.bludau-media.de/SafeSandy/Update.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&programID=2&versionsnummer=" & strVersionsNummer & "&KeinUpdate=1", mgetUpdaterMessage_updater.getProgramUpdateCheck, True)

            If Not strServerInfo1(0) = "VERSION_AKTUELL" Then
                setBludauMediaLogbuch(">> STARTUP: Updater Dialog Version NICHT aktuell: " & strVersionsNummer & System.Uri.EscapeDataString(My.Settings.yabe_username), "START")

                Dim frmUpdater As New frmUpdater
                frmUpdater.ShowDialog()
            End If
        End If

        '###############################
        '# Start funktion 
        '###############################
        If My.Settings.startup_setup = True Then
            Dim frmStartup As New starup_wizard
            setBludauMediaLogbuch(">> STARTUP >> Erster Registrierungs / Anmeldebildschirm " & strVersionsNummer & System.Uri.EscapeDataString(My.Settings.yabe_username), "START")

            frmStartup.ShowDialog(Me)
            Exit Sub
        End If

        '# Mehrfachstarten der Anwendung verhindern
        'If AppPrevInstance(True, True) = True Then
        '    Application.Exit()
        '    Me.Close()
        'End If
        'Dim strConnectionString As String = ""


        '######################################################
        '# >> Datenbankpfad setzen
        '######################################################
        If Not IsBrowserEmulationSet() Then
            SetBrowserEmulationVersion()
        End If





        '        frmMainWindows = Me
        'Dim mc_api As New clsMagentoAPI
        'mc_api.getLogin()

        Dim strAdd As String = ""

        If My.Settings.bDEVMODE = "FORK" Then
            strAdd = " - powered by Google Translate API"
        Else
            strAdd = " - DEV-MODE"
        End If

        Me.Text = "EiSo Verkaufsabwicklung v." & strVersionString & strAdd
        'Call chkPing()
        'MessageBox.Show(GetInternetExplorerMajorVersion())




        Application.DoEvents()
        Call laden_auktionsmanagement()
        AuktionsmanagerToolStripMenuItem.Enabled = False
        'setAuktionManagerTools(True) ' Toolbar deaktivieren


        If My.Settings.splashscreen = True Then
            Dim frm As New SplashScreen1
            frm.tmrCloseDown.Interval = My.Settings.splashscreen_dauer & 1000
            frm.ShowDialog(Me)
        End If

    End Sub
    '###################################################################
    '# >> Fenstertitel anzeigen 
    '###################################################################
    Public Function setMainWindowTitle(ByVal strFormularName As String, ByVal frmForm As Form) As Boolean
        Try
            Dim strAdd As String = ""

            If My.Settings.bDEVMODE = "FORK" Then
                strAdd = " powered by Google Translate API"
            Else
                strAdd = " DEV-MODE"
            End If

            If strFormularName.Length > 0 Then
                frmForm.Text = "EiSo Auktionsabwicklung - " & strFormularName & " - v." & strVersionsNummer & strAdd
            Else
                frmForm.Text = "EiSo Auktionsabwicklung v." & strVersionsNummer & strAdd
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "setMainWindowTitle", MessageBoxButtons.OK)
            Return False
        End Try
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message,
                                           ByVal keyData As Keys) As Boolean
        If TypeOf ActiveControl Is TabControl Then
            If CBool(keyData And Keys.Control Or Keys.Tab) Then
                Return True
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ''' <summary>+
    ''' >> Laden vom Auktionsmanagement
    ''' </summary>
    ''' <remarks></remarks>
    Public Function laden_auktionsmanagement() As Boolean
        Try
            Me.WindowState = FormWindowState.Maximized

            'Dim frmManage As New frmAuktionmanagement
            frmManage.MdiParent = Me
            frmManage.Show()

            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "laden_auktionsmanagement")
        End Try
    End Function


    Private Sub OptionenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionenToolStripMenuItem.Click
        '# Optionen Fromular �ffnen
        Dim frmOption As New frmOptions
        frmOption.MdiParent = Me
        'frmOption.WindowState = FormWindowState.Normal
        frmOption.ShowInTaskbar = True
        frmOption.StartPosition = FormStartPosition.CenterParent
        frmOption.Show()

    End Sub

    '#########################################################################
    '# >> Enable / Disable Toolbar
    '#########################################################################
    Public Function setAuktionManagerTools(ByVal bModus As Boolean) As Boolean

        Try
            FunktionenToolStripMenuItem.Visible = bModus

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setAuktionManagerTools")
            Return False
        End Try
        Return True
    End Function


    Private Sub AuktionsmanagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuktionsmanagerToolStripMenuItem.Click
        Dim frm As New frmAuktionmanagement
        frmManage = frm
        frmManage.MdiParent = Me
        frmManage.WindowState = FormWindowState.Maximized
        frmManage.Show()
        AuktionsmanagerToolStripMenuItem.Enabled = False

        Call setAuktionManagerTools(True)


    End Sub


    Private Sub LivemodusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivemodusToolStripMenuItem.Click
        frmManage.setTabIndex(0)
    End Sub

    '##############################################################
    '# >> TIMER:  Live Counter 
    '##############################################################
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLiveAnsicht.Tick

        '# Aktuallisierung l�uft schon
        If bIsRefreshing_live = False Then

            Call clseBayAPI.setAPIContext()

            '# Ebay Liste abrufen aus frmAuktionsmanagement - Als Auktionsende 
            frmManage.tmrEMailWaitTime.Enabled = False

            Call frmManage.geteBaySellerList(True, True)

            Call clsDatenbank_modul.setListviewData_save(frmAuktionmanagement.lvwEiSoCockpit, frmManage, frmManage.pgreBayLiveUpdate)


            Call getPopUp(Date.Now & " Aktuallisierung " & vbCrLf & vbCrLf & ">> Neue Gebote: " & iGeboteNeu_Anzahl & vbCrLf & ">> Einnahme: xxx Euro")

            iGeboteNeu_Anzahl = 0
            frmManage.tmrEMailWaitTime.Enabled = True
            bIsRefreshing_live = False
        End If

    End Sub

    Private Sub frmMain_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'If My.Settings.yabe_minimize_tray = True Then
        '    If WindowState = FormWindowState.Minimized Then
        '        ShowInTaskbar = False
        '    Else
        '        ShowInTaskbar = True
        '    End If
        'End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = True
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    '########################################
    '# >> �ffnen 
    '########################################
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = True
            WindowState = FormWindowState.Maximized

        End If
    End Sub

    '########################################
    '# >> Beenden 
    '########################################
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

        Dim frmOptions As New frmOptions
        frmOptions.WindowState = FormWindowState.Maximized
        frmOptions.Show()

    End Sub
    '########################################
    '# >> MENU: Info 
    '########################################
    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click

        Dim frmSplashScreen As New SplashScreen1
        Try
            frmSplashScreen.StartPosition = FormStartPosition.CenterParent
            frmSplashScreen.tmrCloseDown.Interval = My.Settings.splashscreen_dauer * 1000
            frmSplashScreen.ShowDialog()
        Catch ex As Exception

        End Try


    End Sub

    '########################################
    '# >> MENU: Beenden 
    '########################################
    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    '#########################################
    '# >> AUTO: Bewertung 
    '#########################################
    Public Function setAutoBewertung() As Boolean

        Dim i As Integer = 0
        Dim strTargerUser As String = ""
        Dim streBayID As String = ""

        Context = clseBayAPI.setAPIContext()

        Dim s As Type = GetType(CommentTypeCodeType)
        Dim apicall As LeaveFeedbackCall = New LeaveFeedbackCall(Context)
        Dim type As CommentTypeCodeType = [Enum].Parse(GetType(CommentTypeCodeType), "Positive")


        For i = 0 To frmManage.lvwBewertungen.Items.Count - 1

            strTargerUser = frmManage.lvwBewertungen.Items(i).Text
            streBayID = frmManage.lvwBewertungen.Items(i).SubItems(2).Text

            If frmManage.lvwBewertungen.Items(i).SubItems(3).Text = "Positive" Then
                Try
                    apicall.LeaveFeedback(streBayID, "Ok gerne wieder :-)", CommentTypeCodeType.Positive, "0", strTargerUser)



                    '# Bewertung erfolgreich 
                    If apicall.ApiResponse.Ack.ToString = "Success" Then
                        '# -OPTION-
                        iBewertungenNeu_Anzahl += 1
                        clsDatenbank_modul.setFeedbackUser(streBayID)
                    End If

                Catch ex As Exception

                    If ex.Message.ToString = "Sie haben f�r dieses Mitglied keine Bewertung abgegeben. F�r diese Transaktion haben Sie bereits eine Bewertung abgegeben." Then
                        clsDatenbank_modul.setFeedbackUser(streBayID)
                        StatusStrip1.Items(0).Text = "Der Benutzer " & strTargerUser & " wurde bereits bewerted!"
                        iBewertungenAbgeben_Anzahl += 1
                        frmManage.lvwBewertungen.Items(i).Remove()
                    Else
                        Call debug_message(ex, strQuery & vbCrLf & "btnLeaveFeedback")
                    End If

                End Try


            End If


        Next



        Return True

    End Function

    '#########################################
    '# >> TIMER: Livebewertungen
    '#########################################
    Private Sub tmrBewertungen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBewertungen.Tick

        '# Aktuallisierung l�uft schon
        If bIsRefreshing_bewertungen = False Then


            'bIsRefreshing_bewertungen = True
            Call clseBayAPI.setAPIContext()


            If My.Settings.ebay_username.Length > 0 Then

                ''# Bewertungen abrufen 
                Call clseBayAPI.getFeedBackList(lvweBayBewertung, My.Settings.ebay_username, Me.tool_ebayMessage)

                '# Bewertung in Datenbank speichern 
                If frmManage.txtBewertungen.Text = My.Settings.ebay_username Then
                    If clsDatenbank_modul.setListviewData_save(frmManage.lvwBewertungen, frmManage, frmManage.pgrBewertungenUpdate) = False Then
                        MsgBox("Fehler beim abspeichern der Daten von aus der Anzeige", MsgBoxStyle.Exclamation)
                    End If
                End If

                frmManage.chkBewertung_janein.Checked = False
                frmManage.chkBewertung_janein.Checked = True

                '# Automatisches Bewerten aktiviern
                Call setAutoBewertung()

                StatusStrip1.Items(0).Text = Date.Now & ": Bewertungen wurden geholt / NEU: " & iBewertungenNeu_Anzahl & " / Bereits abgegeben: " & iBewertungenAbgeben_Anzahl

                Call getPopUp("Aktuallisierung vom " & Date.Now & vbCrLf & vbCrLf & "Neue Bewertungen: " & iBewertungenNeu_Anzahl & vbCrLf & "Abgebene: " & iBewertungenAbgeben_Anzahl)

                iBewertungenNeu_Anzahl = 0
                iBewertungenAbgeben_Anzahl = 0

            End If

            ''Call clsDatenbank_modul.setData(frmAuktionmanagement.lvweBayLiveList)


            bIsRefreshing_bewertungen = False
        End If

    End Sub

    Private Sub StatistikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatistikToolStripMenuItem.Click
        frmManage.setTabIndex(8)
    End Sub

    Private Sub BewertungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BewertungenToolStripMenuItem.Click
        frmManage.setTabIndex(3)
    End Sub


    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmManage.setTabIndex(5)
        MsgBox("Noch nicht eingebaut ;-")
    End Sub

    Private Sub KundendatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KundendatenToolStripMenuItem.Click
        frmManage.setTabIndex(1)
    End Sub

    Private Sub EBayDatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayDatenToolStripMenuItem.Click
        frmManage.setTabIndex(2)
    End Sub


    Private Sub NewsletterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsletterToolStripMenuItem.Click
        frmManage.setTabIndex(5)
    End Sub


    '############################################
    '# >> Setzt Windows auf Vollbild (wenn Tray)
    '############################################
    Private Sub setBigWindow()
        If WindowState = FormWindowState.Minimized Then
            WindowState = FormWindowState.Maximized
            ShowInTaskbar = True
        End If
    End Sub

    Private Sub LivemodusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivemodusToolStripMenuItem1.Click

        Call setBigWindow()
        frmManage.setTabIndex(0)

    End Sub

    Private Sub EBayHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayHistoryToolStripMenuItem.Click
        Call setBigWindow()
        frmManage.setTabIndex(2)
    End Sub

    Private Sub KundendatenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KundendatenToolStripMenuItem1.Click
        Call setBigWindow()
        frmManage.setTabIndex(1)
    End Sub


    Private Sub StatistikToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatistikToolStripMenuItem1.Click
        Call setBigWindow()
        frmManage.setTabIndex(8)
    End Sub

    Private Sub BewertungenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BewertungenToolStripMenuItem1.Click
        Call setBigWindow()
        frmManage.setTabIndex(3)
    End Sub

    Private Sub EBayCentralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayCentralToolStripMenuItem.Click

        Dim frm As New frmYABE_Center_Events
        frm.Show()

    End Sub

    Private Sub AdminpanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminpanelToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = My.Settings.shop_url & "/ACP/adminpanel.php"
        frmWeb.Show()

    End Sub


    Private Sub BestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestellungenToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = My.Settings.shop_url & "/ACP/admin_Bestellungen.php"
        frmWeb.Show()

    End Sub

    Private Sub WebseiteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebseiteToolStripMenuItem1.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "https://bludau-media.de"
        frmWeb.Show()

    End Sub

    Private Sub InhaltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InhaltToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "https://bludau-media.de"
        frmWeb.Show()

    End Sub

    Private Sub BewertungenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmManage.setTabIndex(2)
    End Sub

    Private Sub EBayVerlaufToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmManage.setTabIndex(1)
    End Sub

    Private Sub KundendatenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmManage.setTabIndex(6)
    End Sub


    Public Sub EBayLiveListeHolenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayLiveListeHolenToolStripMenuItem.Click
        If EBayLiveListeHolenToolStripMenuItem.Checked = True Then
            EBayLiveListeHolenToolStripMenuItem.Checked = False
            frmManage.chkAutomatischerModus.Checked = False
        Else
            frmManage.chkAutomatischerModus.Checked = False
            frmManage.chkAutomatischerModus.Checked = True
            EBayLiveListeHolenToolStripMenuItem.Checked = True
        End If
    End Sub

    Public Sub EBayBewertungenHolenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayBewertungenHolenToolStripMenuItem.Click
        If EBayBewertungenHolenToolStripMenuItem.Checked = True Then
            EBayBewertungenHolenToolStripMenuItem.Checked = False
            frmManage.chkStartupR�ckbewertung.Checked = False
        Else
            frmManage.chkAutomatischerModus.Checked = False
            frmManage.chkStartupR�ckbewertung.Checked = True
            EBayBewertungenHolenToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub SynchronisierenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynchronisierenToolStripMenuItem1.Click

        If Not (MsgBox("M�chten Sie die Transaktiondaten von eBay vom " & frmManage.dtpCockpit_von.Text & " bis zum " & frmManage.dtpCockpit_bis.Text & " holen ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "eBay Kundenadressen holen") = MsgBoxResult.Yes) Then
            Exit Sub
        Else

            If Me.frmManage.tabMenue.SelectedIndex = 0 Then
                frmManage.getSellerTransaction(frmManage.dtpCockpit_von, frmManage.dtpCockpit_bis)
            Else
                frmManage.getSellerTransaction(frmManage.dtpCockpit_von, frmManage.dtpCockpit_bis)
            End If


        End If



    End Sub

    Private Sub EBayGalerieToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayGalerieToolStripMenuItem1.Click

        '####################################
        '# >> eBay Galerie Aktuallisieren
        '####################################
        If MsgBox("JA : M�chten Sie nur die Gebote aktuallisieren? " & vbCrLf & vbCrLf & "NEIN: Komplette Galerie aktuallisieren?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Call frmManage.setEBayGalerieData(True)
        Else
            Call frmManage.setEBayGalerieData(False)
        End If

    End Sub

    Private Sub EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem.Click

        If frmManage.lvwEiSoCockpit.Items.Count > 0 Then


            If MsgBox("M�chten Sie die ausgelaufenen YABE Artikel in die 'YABE Bestellungen' synchronisieren?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                '# -1 => Keine Daten zum akuallisieren
                If Not clsDatenbank_modul.setBestellungen_insert_alt() = "-1" Then

                    '# Live Liste
                    Call frmManage.getLvwData(frmManage.lvwEiSoCockpit)

                    '# Bestellungen aktualliseren 
                    Call frmManage.getLvwData(frmManage.lvwBestellverwaltung_nach_artikel)


                    MsgBox("Die Artikel wurden erfolgreich in die YABE Bestellungen �bertragen", MsgBoxStyle.Information, "YABE Daten Synchronisieren")
                End If

            End If
        Else
            MsgBox("Es gibt keine Daten f�r die �bernahme - YABE Artikeln => YABE Bestellungen", MsgBoxStyle.Information, "YABE Daten Synchronisieren")
        End If
    End Sub

    Private Sub ProfildatenMitKundendatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfildatenMitKundendatenToolStripMenuItem.Click
        If MsgBox("M�chten Sie die Artikel mit den Kundendaten neu Synchronisieren lassen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call frmManage.setDBSync()
        End If
    End Sub



    Private Sub EmailVerschickenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailVerschickenToolStripMenuItem.Click
        frmManage.btnAuftrag_email_senden.PerformClick()
    End Sub

    '# Ebay Verkaufsevents �ffnen
    Private Sub VerkaufseventsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerkaufseventsToolStripMenuItem.Click

        '# Anzeigen der Verkaufsevents 
        Dim frmServerEvents As New FrmGetSellerEvents
        frmServerEvents.Show()

    End Sub

    '# Ebay Suche �ffnen 
    Private Sub EBaySucheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frmEbaySuche As New FormGetSearchResults
        frmEbaySuche.Show()

    End Sub

    '# Empfohlene Kategorien
    Private Sub EBayEmpholeneKategorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayEmpholeneKategorieToolStripMenuItem.Click
        Dim frmEbayKategorie As New FormGetSuggestedCategories
        frmEbayKategorie.Show()
    End Sub

    '# Ebay Abmahnungen
    Private Sub EBayAbmahnungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayAbmahnungenToolStripMenuItem.Click
        Dim frmEbayDispute As New FormGetUserDisputes
        frmEbayDispute.Show()
    End Sub

    Private Sub toolDown_eBayTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDown_eBayTime.Click
        ' Ebay Zeit abrufen 
        If My.Settings.ebay_username.ToString.Length > 0 Then
            frmManage.app_eBayTime = Convert.ToDateTime(clseBayAPI.geteBayTime()).AddHours(1)
            frmManage.tmrEbayTime.Enabled = True

        End If



    End Sub

    Private Sub BestellungenMitKundenSynchronisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestellungenMitKundenSynchronisierenToolStripMenuItem.Click

        If MsgBox("M�chten Sie offene Bestellungen jetzt einem Kunden zuweisen?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.MsgBoxSetForeground) = MsgBoxResult.Yes Then

            '# Bestellungen synchronisieren mit Kunden 
            If clsDatenbank_modul.setSyncOrders2Profil() = True Then

                '# Bestellungen aktualliseren 
                Call frmManage.getLvwData(frmManage.lvwBestellverwaltung_nach_artikel)

                MsgBox("Die YABE Bestellungen wurden Bestellungen erfolgreich dem Kunden zugeordnet!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "YABE -> Bestellungen zum Kunden zuordnen")
            End If

        End If

    End Sub

    Private Sub FehlerMeldenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FehlerMeldenToolStripMenuItem.Click
        Dim bug As New frmYABE_Bug2Mantis
        bug.txtTitel.Text = ""
        bug.Show()
    End Sub

    Private Sub ExportVerzeichnis�ffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportVerzeichnis�ffnenToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = Application.StartupPath & "\export"
        ExterneAnwendung.Start()

    End Sub

    Public Function setChangeDebugModus() As Boolean

        If bIsLoading = False Then

            bIsLoading = True
            If DebugmodusAktivierenToolStripMenuItem.Text = "Auktionsende -> Debugmodus aktivieren" Then
                frmManage.clsMailing.bDebug_mail = True
                frmManage.chkDebug_email.Checked = True
                Call getPopUp("Debugmodus wurde aktiviert!")
                DebugmodusAktivierenToolStripMenuItem.Text = "Auktionsende -> Debugmodus deaktivieren"
                Me.frmManage.btnAuftrag_email_senden.Text = "TESTMODUS Emails abschicken"
            Else
                frmManage.clsMailing.bDebug_mail = False
                frmManage.chkDebug_email.Checked = False
                Call getPopUp("Debugmodus wurde deaktiviert!")
                DebugmodusAktivierenToolStripMenuItem.Text = "Auktionsende -> Debugmodus aktivieren"
                Me.frmManage.btnAuftrag_email_senden.Text = "Auktionsende Emails abschicken"
            End If
            bIsLoading = False

        End If

        Return True
    End Function

    Private Sub DebugmodusAktivierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugmodusAktivierenToolStripMenuItem.Click

        Call setChangeDebugModus()
    End Sub

    Private Sub MailtextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailtextToolStripMenuItem.Click
        Dim frmEditor As New frmYABE_Vorlageneditor
        frmEditor.iLoad = clsDatenbank_modul.getComboMailtextTranslation2ID(frmManage.cmbTranslationBereichAusw�hlen.Text)
        frmEditor.StartPosition = FormStartPosition.CenterParent
        frmEditor.Show()
    End Sub

    Private Sub YabeArtikeldatenbankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YabeArtikeldatenbankToolStripMenuItem.Click
        frmManage.setTabIndex(4)
    End Sub

    Private Sub SyncToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SyncToolStripMenuItem.Click
        frmManage.tabMenue.SelectedIndex = 0
        frmManage.btnAuktionEinlesen.PerformClick()
    End Sub

    Private Sub YabeArtikeldatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YabeArtikeldatenToolStripMenuItem.Click
        frmManage.setTabIndex(4)
    End Sub

    Private Sub SyncOutlookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SyncOutlookToolStripMenuItem.Click
        Dim frmOutlook As New frmOutlook_sync
        frmOutlook.Show()

    End Sub

    Private Sub OutlookSynchronisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutlookSynchronisierenToolStripMenuItem.Click
        Dim frmOutlook As New frmOutlook_sync
        frmOutlook.Show()

    End Sub

    Private Sub YABECockpitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABECockpitToolStripMenuItem.Click
        frmManage.setTabIndex(0)
    End Sub

    Private Sub StartseiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartseiteToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = My.Settings.shop_url
        frmWeb.Show()

    End Sub

    Private Sub EBayGalerieAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayGalerieAnzeigenToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "http://galerie.briefmarken-karten-philatelie.de"
        frmWeb.Show()
    End Sub


    Private Sub ShopCounter�ffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopCounter�ffnenToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = My.Settings.shop_url & "/Counter/stats/index.php"
        frmWeb.Show()

    End Sub


    Private Sub EBayNewsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayNewsToolStripMenuItem1.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "http://news.ebay.de/globalnews/news/show"
        frmWeb.Show()

    End Sub

    Private Sub EBayHilfeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayHilfeToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "http://pages.ebay.de/help/index.html?ssPageName=h:h:help:DE"
        frmWeb.Show()

    End Sub

    Private Sub RechnerinfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechnerinfoToolStripMenuItem.Click
        Dim frmSysinfo As New frmYABE_Systeminfo
        frmSysinfo.Show()
    End Sub

    Private Sub YABEAnalyserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEAnalyserToolStripMenuItem.Click
        Dim frmYabeEbayanalyser As New FormGetItemRecommendations
        frmYabeEbayanalyser.Show()
    End Sub

    Private Sub YABEArtikelEinstellenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEArtikelEinstellenToolStripMenuItem.Click
        Dim frmEBayAddItem As New FormAddItem
        frmEBayAddItem.Show()
    End Sub

    Private Sub EBaySucheToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBaySucheToolStripMenuItem.Click
        Dim frmGetSearch As New FormGetSearchResults
        frmGetSearch.Show()
    End Sub

    Private Sub YABEVersandkostenMitteilenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEVersandkostenMitteilenToolStripMenuItem.Click
        Dim frmOrder As New FormAddOrder
        frmOrder.Show()
    End Sub

    Private Sub MeinEBayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeinEBayToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "http://my.ebay.de/ws/eBayISAPI.dll?MyEbay"
        frmWeb.Show()

    End Sub

    Private Sub MeinDelcampeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeinDelcampeToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "http://delcampe.de/status.php?language=G&page=05&noarchive=Y#StatusContent"
        frmWeb.Show()

    End Sub

    Private Sub tool_ebayMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_ebayMessage.Click
        Me.StatusStrip1.Items(1).Text = ""
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        If bCrashReport = True Then
            Shell(Application.StartupPath & "/YABE.exe", AppWinStyle.MaximizedFocus, False)
        End If

    End Sub

    Private Sub DruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripMenuItem.Click

        Select Case frmManage.tabMenue.SelectedIndex
            Case 0
                Dim clsPrint As New clsPrinting
                clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, frmManage.lvwEiSoCockpit)
            Case 1
                Dim clsPrint As New clsPrinting
                clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, frmManage.lvwKunden)
            Case 2
                Dim clsPrint As New clsPrinting
                clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, frmManage.lvwBestellverwaltung_nach_artikel)
            Case 3
                Dim clsPrint As New clsPrinting
                clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, frmManage.lvwBewertungen)
            Case 4
                Dim clsPrint As New clsPrinting
                clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, frmManage.lvMailStatus)

        End Select

    End Sub

    Private Sub YABEStartupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEStartupToolStripMenuItem.Click
        Dim frmWiz As New starup_wizard
        frmWiz.ShowDialog(Me)
    End Sub

    Private Sub CubssEBayGalerieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CubssEBayGalerieToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        If My.Settings.shop_url_galerie.ToString.Length = 0 Then
            frmWeb.strURL = "http://ebay-galerie.cubss.net/?KEY=" & My.Settings.yabe_keycode
        Else
            frmWeb.strURL = My.Settings.shop_url_galerie.ToString
        End If

        frmWeb.Show()
    End Sub

    Private Sub EBayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        If My.Settings.shop_url_galerie.ToString.Length = 0 Then
            frmWeb.strURL = "http://ebay-galerie.cubss.net/?KEY=" & My.Settings.yabe_keycode
        Else
            frmWeb.strURL = My.Settings.shop_url_galerie.ToString
        End If

        frmWeb.Show()

    End Sub

    Private Sub YABEShop�bersetzungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEShop�bersetzungenToolStripMenuItem.Click
        Dim frmShop�bersetzungen As New frmCMS_translate_shop
        frmShop�bersetzungen.Show()
    End Sub

    Private Sub YABEShopImporterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEShopImporterToolStripMenuItem.Click
        Dim frmImporter As New frmCMS_ShopImporter
        frmImporter.mModus = frmCMS_ShopImporter.modus.ebay
        frmImporter.Show()
    End Sub

    Private Sub MagentoCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentoCenterToolStripMenuItem.Click
        Dim frmMagentoManger As New frmMagentoManger
        frmMagentoManger.Show()
    End Sub

    Private Sub ShopGoogleBaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopGoogleBaseToolStripMenuItem.Click
        Dim frmGoogle As New frmGoogleBaseManager
        frmGoogle.Show(Me)
    End Sub

    Private Sub DelcampeListerCSVImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeListerCSVImportToolStripMenuItem.Click
        Dim frmImporter As New frmCMS_ShopImporter
        frmImporter.mModus = frmCMS_ShopImporter.modus.delcampe
        frmImporter.Show()
    End Sub

    Private Sub EiSoUpdaterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EiSoUpdaterToolStripMenuItem.Click
        Dim frmUpdater As New frmUpdater
        frmUpdater.Show()
    End Sub

    Private Sub EiSoBenutzerWechselnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EiSoBenutzerWechselnToolStripMenuItem.Click
        Dim frmEiSoLogin As New frmEiSoLogin
        frmEiSoLogin.Show()
    End Sub

    Private Sub NewsletterAbmeldeCRCGenerierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewsletterAbmeldeCRCGenerierenToolStripMenuItem.Click
        If MsgBox("Fehlende Pr�fsummen beim Newsletterabmelden" & vbCrLf & "Ja: generiert nur fehlende" & vbCrLf & "Nein: Alle neu generieren?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clsDatenbank_modul.setNewsletter_CRC()
        Else
            clsDatenbank_modul.setNewsletter_CRC("all")
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        setBludauMediaLogbuch(">> LOGOUT >> " & My.Settings.yabe_username & " / " & strVersionsNummer & System.Uri.EscapeDataString(My.Settings.yabe_username), "LOGOUT")
    End Sub

    Private Sub ShopsteLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopsteLoginToolStripMenuItem.Click
        Dim frmShopsteLogin As New LoginForm1
        frmShopsteLogin.ShowDialog(Me)
    End Sub

    Private Sub EiSoVersandkostenEditierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EiSoVersandkostenEditierenToolStripMenuItem.Click
        Dim frmEiSoVersandarten As New frmEiSoVersandkosten
        frmEiSoVersandkosten.Show()
    End Sub

    Private Sub EiSoLizenzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EiSoLizenzToolStripMenuItem.Click
        Dim frmDemo As New frmDemoVersion
        frmDemo.Show()
    End Sub

    Private Sub LOGVerzeichnis�ffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGVerzeichnis�ffnenToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = Application.StartupPath & "\LOG"
        ExterneAnwendung.Start()

    End Sub

    Private Sub Bilderverzeichnis�ffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Bilderverzeichnis�ffnenToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = Application.StartupPath & "\bilderexport"
        ExterneAnwendung.Start()

    End Sub
End Class
