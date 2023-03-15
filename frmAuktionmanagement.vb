'############################################################################
'#    ------------------------------------------------
'#      >> YABE eBay - Yet another Bay Editor 
'#    ------------------------------------------------
'#
'# LEGENDE: 
'# ========================================================================================================================
'#   FIX: Fehler wurde gefunden und behoben
'#   NEU: Neues Feature wurde eingebaut
'#   IMP: Verbesserung der z.B. Fehlererkennung,Grafischen Oberfläche
'#   CHG: CHANGE - Tiefergreifende Änderung in einen Funktionsablauf
'#
'# YABE: 13.12.2007: FIX: 5 / NEU: 2 / IMP: 4 / CHG: 0 
'# ========================================================================================================================
'#          - FIX: API - Blättern Überlauf Fehler gefunden (Sub => Function)
'#          - FIX: API - letzte Seite wurde nicht eingelesen 
'#          - FIX: HMTL GALERIE - GUI improvement Übertragung nun sichtbar im Label vorerst
'#          - FIX: HMTL GALERIE - Message Box wenn fertig
'#          - FIX: HMTL GALERIE - Update / Insert Erkennung -> sonst bei jedem Durchlauf verdoppelt
'#          - NEU: Wartedialog frmwait4something (FORM)
'#          - FIX: Bilderanalyse 3ter Fall hinzugefügt Erkennung jetzt bei ~ 90%
'#          - NEU: Multifunktionaler Wartebildschirm mit Globalen Parametern und Template Funktion (für Mehrfacheinsatz)
'#          - IMP: Suchen Fragt jetzt nach ob alle Datensätze abgerufen werden sollen bei keiner Eingabe 
'#          - IMP: Main Form Status Bar bekommt nun werte
'#          - IMP: Ping Prüfung ob Internet Verbindung besteht
'#          - IMP: Doppelklick öffnet Browser mit eBay Artikel
'# 
'# YABE: 16.12.2007: FIX: 4 / NEU: 3 / IMP: 5 / CHG: 1
'# ========================================================================================================================
'#          - NEU-Feature: eBay History  Synchronisierung
'#          - CHG        : Status und Wartedialog
'#          - FIX        : Abbrechen möglich, durch schließen des Wartefensters
'#          - FIX        : Update / Add Prüfung! -> sonst Fehler
'#          - IMP        : Homepage Galerie / eMail Versenden Tooltip Info
'#          - IMP        : Keine eBay Galerie Artikel -> richtige Meldung
'#          - IMP        : frmWait4SomeThing - Abbruch Flag für Aufrufer
'#          - NEU-Feature: eBay History - Ansicht Listview
'#          - NEU        : Copy ID / Copy Accountname 
'#          - FIX        : Nutzerdatenerfassung - Französische Sonderzeichen 
'#          - FIX        : Nutzerdatenerfassung - Doppelte Aktualisierung 
'#          - IMP        : Kundenliste sortierbar
'#          - IMP        : eBay History Liste sortierbar
'#
'# MISC: 17.12.2007: FIX: 2 / NEU: 0 / IMP: 0 / CHG: 2 / CHK: 2 
'# ========================================================================================================================
'#          - CHK        : Virus befall - Philafriend ?
'#          - CHK        : Turbo Lister DHTML editor BUG
'#          - FIX        : WinDaSi1 - Server bugfixing  -> funktioniert wieder :-)
'#          - FIX        : Server verzeichnis entmüllt (alte Umfragen und zig anderes unnögtiges Zeug - nicht alte Webseite)
'#          - CHG        : Programmiertes Zeug aus dem HTdocs ordner auf Desktop verschoben
'#          - CHG        : Taskplaner angepasst auf neuen Ort
'#          - TEST       : Sawmil - Log Analyse für Server -> RDP Zugriffe überwachen! - interessant für apache etc, kann system events nich überwachen :-(
'#          - TEST       : Webmin - Konfig über HTTP möglich + Logfile -> windows gibt nur fehler...
'#
'# MISC: 18.12.2007: NEU: 2 
'# ========================================================================================================================
'#          - NEU        : Eventwatcher: Diverse Erweiterungen
'#          - NEU        : Apache Relunch: erweitert um Speicherauslastung und Prozessmonitoring (beides mehrere Stunden)
'#
'# MISC: 19.12.2007: CHG: 1 / NEU: 5
'# ========================================================================================================================
'#          - CHG        : Apache Relunch eMail Betreff mehr Output (Prozesse + Auslastung des Speichers)
'#          - NEU        : FTP Server - C:\Backup Zugriff (manuell)
'#          - NEU        : LOKAL: Backup einrichten + Miranda Smily + UFT8 (2std !! - ineffizient!)
'#          - NEU        : DOC: Zeitplaner von Philafriend 
'#          - NEU        : TO-DO
'#          - NEU        : Future Plans 
'#
'# TO-DOs: @YABE 
'# ==============
'# 19.12.2007:
'# ------------
'#  >> Drucken der Listbox (Crystal Report)
'#  >> Automatischen Modus neu testen wegen Umstellungen
'#  >> PHP: Thumbnail Generator für eBay Galerie NEU bauen (image magick)
'#  >> eMail: Auktionsemail Personalisiert
'#  >> eMail: Newsletter Coustomize Import  - Migrate Old eMail Adresses mit neuer Kundenstamm tabelle (Newsletter)
'#  >> eMail: GMX Umgehen mit Warnung + Debug FrmWait4Something
'#  >> Feedback: Speichern in Datenbank
'#  >> MENU: Listviews "Kunden" ; "eBay History"
'#  >> API: Stand ~ 30% der API Implementiert (teilweise nicht komplett funktional) 
'#
'# FUTURE-MILESTONES (19.12.2007):
'# =======================================
'#  >> YABE: Bestellungen mirgieren in neues Kundensystem!
'#  >> YABE-LISTER: Implementierung eines Turbo-Listers für YABE (eigenes GUI Fenster)
'#  >> YABE-PAYPAL: Support von Paypal Zahlungen (Eingang von Zahlungen) 
'#  >> WEB:  
'#  >> WEB: Homepage bestellungen umstellen auf YABE (Verwaltung) 
'############################################################################
Imports ZedGraph
Imports System.Net
Imports System.Web
Imports System.Threading
Imports System.IO
Imports System.Globalization
Imports System.ComponentModel
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security

Public Class frmAuktionmanagement
    Private trd As Thread
    ' Determine whether Windows XP or a later
    ' operating system is present.
    Private isRunningXPOrLater As Boolean =
        OSFeature.Feature.IsPresent(OSFeature.Themes)

    ' Declare a Hashtable array in which to store the groups.
    Private groupTables() As Hashtable

    Public Enum bPlattform
        eBay = 0
        delcampe = 1
    End Enum
    Public Enum selectModus
        ganz = 0
        part = 1
    End Enum
    Public Context As eBay.Service.Core.Sdk.ApiContext 'eBay API Context
    Public app_eBayTime As Date
    Public lvwMenueSprache As String = "Deutsch"
    Private col As Integer
    Public setLVWUpdate As Boolean = True

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
        Dim eBayBild As Integer
    End Structure

    Public Structure StatusBarCache
        Dim cockpit As String
        Dim kunden As String
        Dim bestellungen As String
        Dim artikeldatenbank As String
        Dim bewertungen As String
        Dim statistik As String
        Dim newsletter As String
    End Structure

    Public Enum tab_gui_radio
        live = 0
        bestellungen = 1
    End Enum

    '# Export Enum erzeugen 
    Public Enum export_targets
        standard = 0
        magento = 1
        delcampe = 2
    End Enum



    '# Listview Resize Modus 
    Public Enum setResizeModus
        live_list = 0
        tools = 1
        kunden = 2
        ebay_history = 3
    End Enum

    Public Enum eBlatt
        vor = 0
        zurück = 1
    End Enum

    Public Structure mod_blättern
        Dim iPageNow As Integer
        Dim iPageGes As Integer
        Dim iPageNext As Integer
        Dim iPageAnzahlNow As Integer
    End Structure

    Public cache_statusbar As New StatusBarCache
    Public iPage As mod_blättern
    Public strTempVar() As String
    Public getEbayList As New getlvwEbayLive ' liveview zuordnung +schwachsinn+ ;-)
    Public bLivstviewAsc() As Boolean
    Public bLivstviewAsc_eBayLive() As Boolean
    Public bLivstviewAsc_Kundenliste() As Boolean
    Public bLivstviewAsc_newsletter() As Boolean
    Public iCountEmailWeiter_bestellpositionen As Integer = 0
    Public iOnline As Integer = 0
    Public iArtikel As Integer = 0
    Public iCallPageTotal As Integer = 0
    Public bStoppLiveRefresh As Boolean = False
    Public dblSumme As Double
    Public bIsLoading As Boolean = True
    Public bIsPreviewNewsletter As Boolean = False
    Public bGUISuchen As Boolean = False

    '# Klassen Deklarieren 
    Public clsMailing As New clsEmail
    Public clsExport As New clsExport

    '# Virtual Listview 
    Public Zahl As Integer
    Private EinPaarZahlen As New List(Of Zahlen)

    '# Deklarieren der Klasse in einer Form
    Public WithEvents HotKey As New clsHotKey(frm)

    Private Structure Zahlen
        Public Zahl As Integer
        Public Wurzel As Double
        Public Log10 As Double
        Public Sub New(ByVal Zahl As Integer)

            Me.Zahl = 0
            Me.Wurzel = 0
            Me.Log10 = 0

        End Sub
    End Structure
    ' Sorts ListViewGroup objects by header value.
    Private Class ListViewGroupSorter
        Implements IComparer

        Private order As SortOrder

        ' Stores the sort order.
        Public Sub New(ByVal theOrder As SortOrder)
            order = theOrder
        End Sub 'New

        ' Compares the groups by header value, using the saved sort
        ' order to return the correct value.
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements IComparer.Compare
            Dim result As Integer = String.Compare(
                CType(x, ListViewGroup).Header,
                CType(y, ListViewGroup).Header)
            If order = SortOrder.Ascending Then
                Return result
            Else
                Return -result
            End If
        End Function 'Compare
    End Class 'ListViewGroupSorter 

    ' Sets myListView to the groups created for the specified column.
    Private Sub SetGroups(ByRef lvw As ListView, ByVal column As Integer)
        ' Remove the current groups.
        lvw.Groups.Clear()

        ' Retrieve the hash table corresponding to the column.
        Dim groups As Hashtable = CType(groupTables(column), Hashtable)

        ' Copy the groups for the column to an array.
        Dim groupsArray(groups.Count - 1) As ListViewGroup
        groups.Values.CopyTo(groupsArray, 0)

        ' Sort the groups and add them to myListView.
        Array.Sort(groupsArray, New ListViewGroupSorter(lvw.Sorting))
        lvw.Groups.AddRange(groupsArray)

        ' Iterate through the items in myListView, assigning each 
        ' one to the appropriate group.
        Dim item As ListViewItem
        For Each item In lvw.Items
            ' Retrieve the subitem text corresponding to the column.
            Dim subItemText As String = item.SubItems(column).Text

            ' For the Title column, use only the first letter.
            If column = 0 Then
                subItemText = subItemText.Substring(0, 1)
            End If

            ' Assign the item to the matching group.
            item.Group = CType(groups(subItemText), ListViewGroup)
        Next item

    End Sub 'SetGroups

    ' Creates a Hashtable object with one entry for each unique
    ' subitem value (or initial letter for the parent item)
    ' in the specified column.
    Private Function CreateGroupsTable(ByRef lvw As ListView, ByVal column As Integer) As Hashtable
        ' Create a Hashtable object.
        Dim groups As New Hashtable()

        ' Iterate through the items in myListView.
        Dim item As ListViewItem
        For Each item In lvw.Items
            ' Retrieve the text value for the column.
            Dim subItemText As String = item.SubItems(column).Text

            ' Use the initial letter instead if it is the first column.
            If column = 0 Then
                subItemText = subItemText.Substring(0, 1)
            End If

            ' If the groups table does not already contain a group
            ' for the subItemText value, add a new group using the 
            ' subItemText value for the group header and Hashtable key.
            If Not groups.Contains(subItemText) Then
                groups.Add(subItemText, New ListViewGroup(subItemText,
                    HorizontalAlignment.Left))
            End If
        Next item

        ' Return the Hashtable object.
        Return groups
    End Function 'CreateGroupsTable


    'Eingang des Hotkey-Events abfragen
    Private Sub ReceiveHotKey(ByVal HotKeyID As String) Handles HotKey.HotKeyPressed

        If HotKeyID = "ID1" Then
            'MsgBox("OK", MsgBoxStyle.SystemModal)
            Dim frmYABE_Center_Events As New frmYABE_Center_Events
            frmYABE_Center_Events.ShowDialog()
            'Call setBigWindow()

        End If

    End Sub

    Private Sub setVirutalMode()

        ' Generiert ein paar Zahlen, welche im ListView-Control angezeigt werden
        For i As Integer = 1 To 1000000
            EinPaarZahlen.Add(New Zahlen(i))
        Next i

        ' Virtual-Mode anschalten
        lvwEiSoCockpit.VirtualMode = True

        ' Das ListView erwartet in der Eigenschaft die Anzahl der Elemente, die es
        '  anzeigen soll
        lvwEiSoCockpit.VirtualListSize = EinPaarZahlen.Count
    End Sub


    '###################################
    '# >> Lädt die Form_Load Parameter
    '###################################
    Private Sub parameter_laden()
        Try

            'settings_crypt

            'If clsDatenbank_modul.chkLogin(My.Settings.yabe_username, My.Settings.yabe_pwd) = False Then
            If clsDatenbank_modul.chkLogin(My.Settings.yabe_username.Replace("'", "''"), My.Settings.yabe_pwd.Replace("'", "''")) = False Then
                'MsgBox("Die Login Daten für den Benutzer '" & My.Settings.yabe_username & "' stimmen nicht!" & vbCrLf & "Bitte Programm neustarten, bei anhaltenden Problemen bitte mit der Supportabteilung kontakt@cubss.net aufnehmen" & vbCrLf & "Beim nächsten Programmstart wird der Registrierungs Wizard erscheinen, bitte benutzen Sie EiSo Login!", MsgBoxStyle.Critical)
                Dim frmEiSoLogin As New frmEiSoLogin
                frmEiSoLogin.strMessage = "Die Login Daten für den Benutzer '" & My.Settings.yabe_username & "' stimmen nicht!" & vbCrLf & "Bitte Programm neustarten, bei anhaltenden Problemen bitte mit der Supportabteilung jbludau@bludau-media.net aufnehmen" & vbCrLf & "Beim nächsten Programmstart wird der Registrierungs Wizard erscheinen, bitte benutzen Sie EiSo Login!"
                frmEiSoLogin.ShowDialog()

                My.Settings.startup_setup = True
                My.Settings.Save()
                End

                Exit Sub
            End If




            Select Case My.Settings.yabe_accesslevel
                Case 200
                    tabMenue.TabPages.Remove(menue_artikelverwaltung)
                    tabMenue.TabPages.Remove(menue_Mailversand)
                    tabMenue.TabPages.Remove(menue_meineBay)
                    tabMenue.TabPages.Remove(menue_tbPaypal)
                    tabMenue.TabPages.Remove(menue_Statistik)
                    '# GUI LINKS 
                    frmMain.AdminpanelToolStripMenuItem.Visible = False
                    frmMain.DelcampeListerCSVImportToolStripMenuItem.Visible = False
                    frmMain.YABEShopImporterToolStripMenuItem.Visible = False
                    frmMain.ToolStripSeparator8.Visible = False
                    frmMain.ShopGoogleBaseToolStripMenuItem.Visible = False
                    frmMain.YABEShopÜbersetzungenToolStripMenuItem.Visible = False
                    '# Bestellungen
                    ShopToolStripMenuItem.Visible = False
                    DToolStripMenuItem.Visible = False
                    MagentoToolStripMenuItem1.Visible = False
                    DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Visible = False
                    YABEArtikelübernahmeToolStripMenuItem.Visible = False

                Case 201
                    tabMenue.TabPages.Remove(menue_artikelverwaltung)
                    tabMenue.TabPages.Remove(menue_meineBay)
                    tabMenue.TabPages.Remove(menue_tbPaypal)
                    tabMenue.TabPages.Remove(menue_Statistik)
                Case 202
                    tabMenue.TabPages.Remove(menue_artikelverwaltung)
                    tabMenue.TabPages.Remove(menue_meineBay)
                    tabMenue.TabPages.Remove(menue_tbPaypal)
                Case 203
                    tabMenue.TabPages.Remove(menue_meineBay)
                    tabMenue.TabPages.Remove(menue_tbPaypal)
            End Select

            SetRadioButton(tab_gui_radio.live)

            SetRadioButton(tab_gui_radio.bestellungen)

            chkKundenFullReport.Checked = My.Settings.eiso_gui_kunde_detailreport
            tcBestellungen_visual.SelectedIndex = My.Settings.eiso_gui_bestellung_subtab_index

            bIsLoading = True
            chkEndTime.Checked = My.Settings.gui_live_auktionsende
            chkeBayEnde.Checked = My.Settings.gui_live_beendet
            chkLiveZeitfilter.Checked = My.Settings.gui_live_datumfilter
            chkGebote.Checked = My.Settings.gui_live_gebote
            chkBuyItNow.Checked = My.Settings.gui_live_sofortkauf
            '   chkLiveAlle.Checked = My.Settings.gui_live_alle
            chkMitWebgalerie.Checked = My.Settings.yabe_cockpit_mitwebgalerie
            Application.DoEvents()
            GruppiertBestellstatusToolStripMenuItem.Checked = My.Settings.yabe_gui_bestellverwaltung_groupby_bestellstatus
            GruppiertNameToolStripMenuItem.Checked = My.Settings.yabe_gui_bestellverwaltung_groupby_name
            GroupiertVerkaufsendeToolStripMenuItem.Checked = My.Settings.yabe_gui_bestellverwaltung_groupby_verkaufsende
            GruppiertLandToolStripMenuItem.Checked = My.Settings.yabe_gui_bestellverwaltung_groupby_land
            GruppiertKeineToolStripMenuItem.Checked = My.Settings.yabe_gui_bestellverwaltung_groupby_KeineGruppierung
            AutomatischSpracheÄndernToolStripMenuItem.Checked = My.Settings.gui_artikel_menuesprache
            chkeBayEnde.Checked = My.Settings.eiso_gui_cockpit_beendet

            chkShopUpdateItemCount.Checked = My.Settings.yabe_gui_cms_update

            '# Mapping Livelist installieren 
            getEbayList.ID = 0
            getEbayList.beschreibung = 1
            getEbayList.preisJetzt = 2
            getEbayList.preisStart = 3
            getEbayList.gebote = 4
            getEbayList.mitgliedsname = 5
            getEbayList.email = 6
            getEbayList.zeitpunkt = 7
            getEbayList.eBayAuktionType = 8
            getEbayList.eBayWatchCount = 9
            getEbayList.eBayEnde = 10
            getEbayList.ebayAnfang = 11
            getEbayList.eBayGebühr = 12
            getEbayList.ebayVersandkosten = 13

            chkEiSoArtikelverwaltung_kunden_details.Checked = My.Settings.chkEiSoArtikelverwaltung_kunden_details

            '# DISPLAY ORDER LADEN 
            If My.Settings.gui_lvw_bUse_Reorder_setting = True Then
                Call setLVW_Colum_ReOrder(lvwBewertungen)
                Call setLVW_Colum_ReOrder(lvwKunden)
                Call setLVW_Colum_ReOrder(lvwBestellverwaltung_nach_artikel)
                Call setLVW_Colum_ReOrder(lvwEiSoCockpit)
                Call setLVW_Colum_ReOrder(lvwWebArtikel)
                Call setLVW_Colum_ReOrder(lvMailStatus)
                Call setLVW_Colum_ReOrder(lvwBestellungen_bestelliste_neu)
                Call setLVW_Colum_ReOrder(lvwBestellungen_kunden)
            End If

            If My.Settings.yabe_lvw_hottracking = True Then
                lvwBewertungen.HotTracking = True
                lvwKunden.HotTracking = True
                lvwBestellverwaltung_nach_artikel.HotTracking = True
                lvwEiSoCockpit.HotTracking = True
                lvMailStatus.HotTracking = True
            Else
                lvwBewertungen.HotTracking = False
                lvwKunden.HotTracking = False
                lvwBestellverwaltung_nach_artikel.HotTracking = False

                lvwEiSoCockpit.HotTracking = False
                lvMailStatus.HotTracking = False
            End If

            'Call setVirutalMode()
            'bIsLoading = True
            tabMenue.SelectedIndex = My.Settings("lastTab").ToString

            txtGetSellerListSeiteVon.Text = My.Settings.api_getSellerList_page
            chkDebug_email.Text = "Testlauf an " & My.Settings.email_username

            '# Setzt den INI Pfad 
            'Call setINI(Application.StartupPath & "\yabe1.xml")

            ''# INI Entschlüsseln
            ''Call setEncrypt_file(strIniFile, "myDoom", True)
            ''Call setDecrypt_file(strIniFile, "myDoom", True)
            ''# Liest die INI Parameter
            'Call XMLReader_INI(strIniFile, "INISET")
            '# INI Verschlüsseln
            'Call setEncrypt_file(strIniFile, "myDoom", True)


            '# eBay API Einstellen
            Application.DoEvents()
            Call clseBayAPI.setAPIContext()

            Call clsMailing.setConfig(lvwEiSoCockpit, chkDebug_email.Checked)

            If chkPing() = False Then
                MsgBox("Es wurde keine Internet Verbindung mit dem " & My.Settings.datenbank_server & " Server aufgebaut" & vbCrLf & "Bitte das Programm neustarten", MsgBoxStyle.Information)
                Exit Sub
            End If

            'Registrieren der Hotkeys
            Application.DoEvents()
            HotKey.AddHotKey(Keys.F11, clsHotKey.MODKEY.MOD_WIN, "ID1")

            '# Konfiguration der datetimepicker
            If chkEndTime.Checked = True Then
                dtpCockpit_von.Value = Date.Now.AddDays(-1)
                dtpCockpit_bis.Value = Date.Now.AddDays(My.Settings.gui_dauer_cockpit)
            Else
                If My.Settings.lvw_live_monatsweise = True Then
                    dtpCockpit_von.Value = getMonthStart(Date.Now)
                    dtpCockpit_bis.Value = getMonthEnd(Date.Now)

                Else
                    dtpCockpit_von.Value = Date.Now.AddDays(-My.Settings.gui_dauer_cockpit)
                    dtpCockpit_bis.Value = Date.Now.AddDays(1)

                End If
            End If

            '# Paypal 1 Woche zurück
            dtPaypal.Value = Date.Now.AddDays(-10)
            If My.Settings.lvw_kunden_monatsweise = True Then
                KundenVon.Value = getMonthStart(Date.Now)
                KundenBis.Value = getMonthEnd(Date.Now)
            Else
                KundenVon.Value = Date.Now.AddDays(-My.Settings.gui_dauer_kunden)
                KundenBis.Value = Date.Now.AddDays(1)
            End If


            If My.Settings.lvw_bewertung_monatsweise = True Then
                dtp_BewertungVon.Value = getMonthStart(Date.Now)
                dtp_BewertungBis.Value = getMonthEnd(Date.Now)
            Else
                dtp_BewertungVon.Value = Date.Now.AddDays(-My.Settings.gui_dauer_bewertungen)
                dtp_BewertungBis.Value = Date.Now.AddDays(1)
            End If


            If My.Settings.lvw_bestellung_monatsweise = True Then
                eBayHistoryVon.Value = getMonthStart(Date.Now)
                eBayHistoryBis.Value = getMonthEnd(Date.Now)
            Else
                eBayHistoryVon.Value = Date.Now.AddDays(-My.Settings.gui_dauer_bestellungen)
                eBayHistoryBis.Value = Date.Now.AddDays(1)
            End If


            chkBewertung_janein.Checked = True
            cmbArtikelStatus.SelectedIndex = 0

            '# My Setting 
            chkArtikeldatenbank_edit.Checked = My.Settings.gui_webartikel_editmodus
            chkKundenHeute.Checked = My.Settings.gui_kunden_heute
            chkKundenverwaltung_kunde_ab_gestern.Checked = My.Settings.gui_kunden_gestern_ab
            bIsLoading = False




            Dim now As DateTime = DateTime.Now
            DatePickStartTo.Value = now
            DatePickStartFrom.Value = now.AddDays(-6)

            Dim types As Type = GetType(eBay.Service.Core.Soap.MessageTypeCodeType)
            Dim typ As String

            For Each typ In [Enum].GetNames(types)
                If typ <> "CustomCode" Then
                    CboType.Items.Add(typ)
                End If
            Next typ
            CboType.SelectedIndex = 0


            OptRange.Checked = True

            Dim statie As Type = GetType(eBay.Service.Core.Soap.MessageStatusTypeCodeType)
            Dim stat As String

            For Each stat In [Enum].GetNames(statie)
                If stat <> "CustomCode" Then
                    CboStatus.Items.Add(stat)
                End If

            Next stat
            CboStatus.SelectedIndex = 0

            txtBewertungen.Text = My.Settings.ebay_username
            chkeBayBewertung_automatischRE.Checked = My.Settings.yabe_gui_bewerten_chkRückbewertung

            ' eBay Zeit aktuallisieren (nach 3 sek)
            If My.Settings.app_eBayZeit_startup = True Then
                tmrEbayZeitWarten.Enabled = True
            End If

            Me.KeyPreview = True
            Me.WindowState = FormWindowState.Maximized

            '# Delcampe Bestellstatus automatisch holen
            If My.Settings.yabe_startup_delcampe_bestellungen = True Then
                Dim frmWeb As New frmYABE_WebBrowser
                frmWeb.strURL = "http://delcampe.de/status.php?language=G&page=05&noarchive=Y#StatusContent"
                Application.DoEvents()
                frmWeb.ShowInTaskbar = False
                frmWeb.Visible = False
                frmWeb.Show()

            End If

            '# eBay Automatisch Synchronisieren 
            If My.Settings.yabe_startup_ebay_sync = True Then
                If chkEndTime.Checked = True Then
                    Call geteBaySellerList(True)
                Else
                    Call geteBaySellerList(False)
                End If
            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "parameter_laden")
            bIsLoading = False
        End Try

    End Sub


    '##################################################
    '# >> Spalten Resize durchführen 
    '##################################################
    Public Function setLVWResizeModus(ByVal lvw As ListView, ByVal mModus As setResizeModus) As Boolean
        Try

            Select Case mModus
                Case setResizeModus.live_list
                    lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                'lvw.Columns(0).Width = 0

                Case setResizeModus.ebay_history
                    lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                Case setResizeModus.tools
                    lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            End Select
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setLVWResizeModus")
            Return False
        End Try
        Return True
    End Function


    '################################################################
    '#  >> Sortieren durch F- TASTEN
    '################################################################
    Public Function setSortModus(ByVal e As System.Windows.Forms.KeyEventArgs, ByVal lvw As ListView) As Boolean
        Try

            'If e.KeyCode = Keys.F1 Then

            '    Dim iColumn As Integer = 0
            '    iColumn = 0

            '    If bLivstviewAsc(iColumn) = False Then
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
            '        bLivstviewAsc(iColumn) = True
            '    Else
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
            '        bLivstviewAsc(iColumn) = False
            '    End If
            '    lvw.SelectedItems.Clear()
            '    lvw.Items(0).Selected = True
            '    lvw.Items(0).EnsureVisible()
            'End If

            'If e.KeyCode = Keys.F2 Then

            '    Dim iColumn As Integer = 0
            '    iColumn = 1

            '    If bLivstviewAsc(iColumn) = False Then
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
            '        bLivstviewAsc(iColumn) = True
            '    Else
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
            '        bLivstviewAsc(iColumn) = False
            '    End If

            '    lvw.SelectedItems.Clear()
            '    lvw.Items(0).Selected = True
            '    lvw.Items(0).EnsureVisible()
            'End If


            'If e.KeyCode = Keys.F3 Then

            '    Dim iColumn As Integer = 0
            '    iColumn = 2

            '    If bLivstviewAsc(iColumn) = False Then
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
            '        bLivstviewAsc(iColumn) = True
            '    Else
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
            '        bLivstviewAsc(iColumn) = False
            '    End If

            '    lvw.SelectedItems.Clear()
            '    lvw.Items(0).Selected = True
            '    lvw.Items(0).EnsureVisible()
            'End If

            'If e.KeyCode = Keys.F4 Then

            '    Dim iColumn As Integer = 0
            '    iColumn = 3

            '    If bLivstviewAsc(iColumn) = False Then
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
            '        bLivstviewAsc(iColumn) = True
            '    Else
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
            '        bLivstviewAsc(iColumn) = False
            '    End If

            '    lvw.SelectedItems.Clear()
            '    lvw.Items(0).Selected = True
            '    lvw.Items(0).EnsureVisible()
            'End If

            'If e.KeyCode = Keys.F4 Then

            '    Dim iColumn As Integer = 0
            '    iColumn = 4

            '    If bLivstviewAsc(iColumn) = False Then
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
            '        bLivstviewAsc(iColumn) = True
            '    Else
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
            '        bLivstviewAsc(iColumn) = False
            '    End If

            '    lvw.SelectedItems.Clear()
            '    lvw.Items(0).Selected = True
            '    lvw.Items(0).EnsureVisible()
            'End If

            'If e.KeyCode = Keys.F5 Then

            '    Dim iColumn As Integer = 0
            '    iColumn = 5

            '    If bLivstviewAsc(iColumn) = False Then
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
            '        bLivstviewAsc(iColumn) = True
            '    Else
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
            '        bLivstviewAsc(iColumn) = False
            '    End If

            '    lvw.SelectedItems.Clear()
            '    lvw.Items(0).Selected = True
            '    lvw.Items(0).EnsureVisible()
            'End If

            'If e.KeyCode = Keys.F5 Then

            '    Dim iColumn As Integer = 0
            '    iColumn = 6

            '    If bLivstviewAsc(iColumn) = False Then
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
            '        bLivstviewAsc(iColumn) = True
            '    Else
            '        lvw.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
            '        bLivstviewAsc(iColumn) = False
            '    End If

            '    lvw.SelectedItems.Clear()
            '    lvw.Items(0).Selected = True
            '    lvw.Items(0).EnsureVisible()
            'End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setSortModus")
            Return False
        End Try

        Return True

    End Function

    Private Sub frmAuktionmanagement_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed

        '# Form 1 Beeinflussen 

        frmMain.AuktionsmanagerToolStripMenuItem.Enabled = True
        frmMain.setAuktionManagerTools(False) ' Toolbar deaktivieren


    End Sub

    '##################################################
    '# >> KEYDOWN: FROM 
    '##################################################
    Private Sub frmAuktionmanagement_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'Call setSortModus(e, lvweBayLiveList)

    End Sub

    Public Function frmLoad(ByVal lngWaitTime As Long, ByVal strMessage As String) As Boolean
        Try

            Dim frmWait As New frmSendMailWait

            frmWait.lngWaitTime = lngWaitTime * 1000 * 60
            frmWait.txtLastMessage.Text = strMessage
            frmWait.ShowDialog(Me)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "frmLoad")
            Return False
        End Try
    End Function

    Private Sub frmAuktionmanagement_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        clsDatenbank_modul.dbConnect.Close()
    End Sub

    '###################################################################
    '# >> Get Counts für Checkboxen 
    '###################################################################
    Public Function getRadioOptions_counts(ByVal strName As String, Optional ByVal bSenderIsComboBox As Boolean = False) As Boolean

        Dim strPlattform As String = ""
        Dim strZeit As String = ""

        Try
            Select Case strName
                Case "lvwEiSoCockpit"


                    Dim str() As String = cmbPlattform_Live.Text.Split(" ")

                    Select Case str(0)
                        Case "Alle"



                        Case "eBay"

                            strPlattform = " AND yabe_auction_list_live.auction_type ='eBay'"

                        Case "Delcampe"
                            strPlattform = " AND yabe_auction_list_live.auction_type ='Delcampe'"
                        Case "Shopsysteme"

                            strPlattform = " AND yabe_auction_list_live.auction_type ='CMS'"
                        Case "Magento"
                            strPlattform = " AND yabe_auction_list_live.auction_type ='Magento'"
                        Case "Shopste"
                            strPlattform = " AND yabe_auction_list_live.auction_type ='Shopste'"
                    End Select

                    If chkLiveZeitfilter.Checked = True Then
                        Dim strDatumVon As String = getDateFromTimepicker(dtpCockpit_von.Value.ToString, True)
                        Dim strDatumBis As String = getDateFromTimepicker(dtpCockpit_bis.Value.ToString, False)

                        If chkEndTime.Checked = True Then
                            strZeit = " AND auction_end >= '" & strDatumVon & "' AND auction_end <= '" & strDatumBis & "'"
                        Else
                            strZeit = " AND auction_begin >= '" & strDatumVon & "' AND auction_begin <= '" & strDatumBis & "'"
                        End If

                    End If

                    If strPlattform.ToString.Length > 0 Then
                        iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_live, "WHERE " + strPlattform.Replace(" AND ", ""))
                    Else
                        iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_live, "")
                    End If

                    chkLiveAlle.Text = "&Alle (" & iOnline & ")"
                    Application.DoEvents()
                    If iOnline = 0 Then
                        chkLiveAlle.Enabled = False
                    Else
                        chkLiveAlle.Enabled = True
                    End If

                    Dim strEnde As String
                    If chkeBayEnde.Checked = True Then
                        strEnde = " AND iseBayEnded='Completed'"
                    Else
                        strEnde = " AND iseBayEnded='Active'"
                    End If



                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_live, " WHERE bids > 0 " & strEnde + strPlattform & strZeit)
                    If str(0) = "eBay" Or str(0) = "Delcampe" Then
                        chkGebote.Text = "&Mit Gebote (" & iOnline & ")"
                    Else
                        chkGebote.Text = "&Verkauft (" & iOnline & ")"
                    End If

                    Application.DoEvents()

                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_live, " WHERE bids = 0" & strEnde + strPlattform & strZeit)

                    If str(0) = "eBay" Or str(0) = "Delcampe" Then
                        chkGeboteOhne.Text = "&Ohne Gebote (" & iOnline & ")"
                    Else
                        chkGeboteOhne.Text = "&Nicht verkauft (" & iOnline & ")"
                    End If


                    Application.DoEvents()
                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_live, " WHERE iseBayEnded = 'Completed'" + strPlattform & strZeit)

                    If str(0) = "Alle" Then
                        chkeBayEnde.Text = "&Plattformübergreifend Zahlungshinweise abschicken (" & iOnline & ")"
                    Else
                        chkeBayEnde.Text = "&" & str(0) & " Zahlungshinweise abschicken (" & iOnline & ")"
                    End If


                    If bSenderIsComboBox = False Then
                        Dim iSel As Integer = cmbPlattform_Live.SelectedIndex
                        'Application.DoEvents()
                        Call getPlattforms(cmbPlattform_Live, clsDatenbank.datentabelle.yabe_auction_list_live, strZeit)
                        bIsLoading = True
                        cmbPlattform_Live.SelectedIndex = iSel
                    End If


                    bIsLoading = False
                Case "lvwBestellverwaltung_nach_artikel"


                    If chkHistoryZeitfilter.Checked = True Then
                        Dim strDatumVon As String = getDateFromTimepicker(eBayHistoryVon.Value.ToString, True)
                        Dim strDatumBis As String = getDateFromTimepicker(eBayHistoryBis.Value.ToString, False)
                        strZeit = " AND auction_begin >= '" & strDatumVon & "' AND auction_end <= '" & strDatumBis & "'"
                    End If

                    Dim str() As String = cmbPlattform_bestellungen.Text.Split(" ")

                    Select Case str(0)
                        Case "Alle"

                        Case "eBay"

                            strPlattform = " AND yabe_auction_list_history.auction_type ='eBay'"

                        Case "Delcampe"
                            strPlattform = " AND yabe_auction_list_history.auction_type ='Delcampe'"
                        Case "Shopsysteme"

                            strPlattform = " AND yabe_auction_list_history.auction_type ='CMS'"
                        Case "Magento"
                            strPlattform = " AND yabe_auction_list_history.auction_type ='Magento'"
                        Case "Shopste"
                            strPlattform = " AND yabe_auction_list_history.auction_type ='Shopste'"
                    End Select

                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_history, " WHERE status='bestellt'" + strPlattform & strZeit)
                    chkBestellungen_verkauft.Text = "&Bestellt (" & iOnline & ")"
                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_history, " WHERE status='Bezahlt'" + strPlattform & strZeit)
                    chkBestellungen_bezahlt.Text = "&Bezahlt (" & iOnline & ")"
                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_history, " WHERE status='Verschickt'" + strPlattform & strZeit)
                    chkBestellungen_Versand.Text = "&Verschickt (" & iOnline & ")"
                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_history, " WHERE isBewertung='Y'" + strPlattform & strZeit)
                    chkBestellungen_KeineBewertung.Text = "&Rückbewertung (" & iOnline & ")"
                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_history, " WHERE status='Storniert'" + strPlattform & strZeit)
                    chkBestellungen_Storniert.Text = "&Storniert (" & iOnline & ")"

                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_history, " WHERE status='Komplett'" + strPlattform & strZeit)
                    chkBestellungen_Komplett.Text = "&Komplett (" & iOnline & ")"

                    Dim iSel As Integer = cmbPlattform_bestellungen.SelectedIndex
                    Call getPlattforms(cmbPlattform_bestellungen, clsDatenbank.datentabelle.yabe_auction_list_history, strZeit)
                    bIsLoading = True
                    cmbPlattform_bestellungen.SelectedIndex = iSel
                    bIsLoading = False
                Case "lvwKunden"

                    If chkKundenZeitfilter.Checked = True Then
                        Dim strDatumVon As String = getDateFromTimepicker(KundenVon.Value.ToString, True)
                        Dim strDatumBis As String = getDateFromTimepicker(KundenBis.Value.ToString, False)
                        strZeit = " AND created_order >= '" & strDatumVon & "' AND created_order <= '" & strDatumBis & "'"
                    End If

                    Dim iSel As Integer = cmbPlattform_kunden.SelectedIndex
                    Call getPlattforms(cmbPlattform_kunden, clsDatenbank.datentabelle.yabe_personals_adress, strZeit)
                    bIsLoading = True
                    cmbPlattform_kunden.SelectedIndex = iSel
                    bIsLoading = False
                Case "lvwMenue_aktuelle"
                    iOnline = clsDatenbank_modul.getQueryCount(clsDatenbank.datentabelle.yabe_auction_list_history, " WHERE isBewertung='Y'")

            End Select


            Return True
        Catch ex As Exception
            Call debug_message(ex, "getRadioOptions_counts")
            Return False
        End Try
    End Function

    '##################################################
    '# >> getPlattforms
    '##################################################
    Public Function getPlattforms(ByRef cmbCombo As ComboBox, ByVal strTabelle As clsDatenbank.datentabelle, ByVal strTime As String) As Boolean
        Dim strWhere As String = ""
        Try
            Select Case strTabelle
                Case clsDatenbank.datentabelle.yabe_auction_list_history
                    strWhere = "auction_type"
                Case clsDatenbank.datentabelle.yabe_personals_adress
                    strWhere = "Type"
                Case clsDatenbank.datentabelle.yabe_auction_list_live
                    strWhere = "auction_type"
            End Select

            cmbCombo.Items.Clear()

            If strTabelle = clsDatenbank.datentabelle.yabe_auction_list_live Then
                iOnline = clsDatenbank_modul.getQueryCount(strTabelle, "")
                cmbCombo.Items.Add("Alle (" & iOnline & ")")
            Else
                iOnline = clsDatenbank_modul.getQueryCount(strTabelle, "WHERE 1=1 " & strTime)
                cmbCombo.Items.Add("Alle (" & iOnline & ")")
            End If


            iOnline = clsDatenbank_modul.getQueryCount(strTabelle, "WHERE " & strWhere & "='eBay'" & strTime)
            cmbCombo.Items.Add("eBay (" & iOnline & ")")

            iOnline = clsDatenbank_modul.getQueryCount(strTabelle, "WHERE " & strWhere & "='Delcampe'" & strTime)
            cmbCombo.Items.Add("Delcampe (" & iOnline & ")")

            iOnline = clsDatenbank_modul.getQueryCount(strTabelle, "WHERE " & strWhere & "='CMS'" & strTime)
            cmbCombo.Items.Add("Shopsysteme (" & iOnline & ")")

            iOnline = clsDatenbank_modul.getQueryCount(strTabelle, "WHERE " & strWhere & "='Shopste'" & strTime)
            cmbCombo.Items.Add("Shopste (" & iOnline & ")")

            If My.Settings.yabe_magento_aktiv = True Then
                iOnline = clsDatenbank_modul.getQueryCount(strTabelle, "WHERE " & strWhere & "='Magento'" & strTime)
                cmbCombo.Items.Add("Magento (" & iOnline & ")")
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "getPlattforms")
            Return False
        End Try
    End Function

    '##################################################################
    '# >> Combobox mit Plattformen füllen 
    '##################################################################
    Public Function setPlattforms2Combo(ByRef cmb As ComboBox) As Boolean
        Try
            Dim iCount As Integer = 0
            Dim iSelTmp As Integer = 0

            iSelTmp = cmb.SelectedIndex
            cmb.Items.Clear()

            '# Alle Plattformen durchgeben 
            '# J.B. Fix 
            For iCount = 0 To 6
                Try
                    If Not strPlattforms(iCount).ToString = "" Then
                        cmb.Items.Add(strPlattforms(iCount))
                    End If
                Catch ex As Exception
                    Exit For
                End Try

            Next

            ' zurücksetzten auf alten Eintrag 
            Try
                bIsLoading = True
                If iSelTmp = -1 Then
                    cmb.SelectedIndex = 0
                Else
                    cmb.SelectedIndex = iSelTmp
                End If

            Catch ex As Exception

            End Try


            Return True
        Catch ex As Exception
            Call debug_message(ex, "setPlattforms2Combo")
            Return False
        End Try
    End Function
    '##################################################
    '# >> Formular wird geladen 
    '##################################################
    Private Sub frmAuktionmanagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bIsLoading = True
        Try


            chkArtikeldatenbankBilderladen.Checked = My.Settings.gui_eiso_lade_bilder

            '# Lädt Standard parameter
            Application.DoEvents()

            '# DEBUG
            If My.Settings.yabe_bestellstatus_debug = True Then
                btnAuftrag_email_senden.Text = "Auktionsende abschicken (Debug)"
            End If

            Call parameter_laden()
            bIsLoading = True
            strPlattforms = clsDatenbank_modul.getPlattforms()
            '# Nix machen beim SelectIndex Change 

            Call setPlattforms2Combo(cmbPlattform_Live)


            Call setPlattforms2Combo(cmbPlattform_kunden)
            cmbPlattform_kunden.SelectedIndex = My.Settings.yabe_plattform_kunden

            Call setPlattforms2Combo(cmbPlattform_bestellungen)
            cmbPlattform_bestellungen.SelectedIndex = My.Settings.yabe_plattform_bestellungen

            '# Alles weiterlaufen lassen 
            bIsLoading = False

            'Dim iSel As Integer = cmbPlattform_Live.SelectedIndex
            'bIsLoading = True
            'Call getPlattforms(cmbPlattform_Live, clsDatenbank.datentabelle.yabe_auction_list_live, "")
            'cmbPlattform_Live.SelectedIndex = iSel
            'bIsLoading = False

            Application.DoEvents()

            '# Auslösen vom Tabwechsel -> AKTION
            Call getInitLoadTabChange(tabMenue)


            iPage.iPageNext = My.Settings.APP_API_länge
            iPage.iPageGes = Math.Round(iOnline / iPage.iPageNext)
            iPage.iPageGes += 1
            iPage.iPageNow = 1

            bIsLoading = False 'ladeflag hilfe doppeltes ausführen von Methoden zu verhindern! 

            'frmMain.tool_ebayMessage.Text = "YABE " & strVersionString & " wurde vom Benutzer " & My.Settings.yabe_username & " am " & Date.Now & " gestartet"

            '# Prüfen ob ein Update herruntergeladen werden muss
            strPathUpdater = Application.StartupPath & "\Updater"
            ''If My.Settings.app_autoupdate = True Then

            ''    Call setUpdateCheck(pgreBayLiveUpdate, LblAccBalance)
            ''End If

            '# Redim des Sortierhändler
            ReDim bLivstviewAsc(19)
            ReDim bLivstviewAsc_eBayLive(19)
            ReDim bLivstviewAsc_Kundenliste(19)
            ReDim bLivstviewAsc_newsletter(19)

            ' bIsLoading = False
            cmbPlattform_Live.SelectedIndex = My.Settings.yabe_plattform_cockpit
            'bIsLoading = True

            If cmbPlattform_Live.Text.Contains("eBay") Then
                txtGetSellerListSeiteVon.Visible = True
                Label8.Visible = True
                btnQuickSync.Visible = True
            ElseIf cmbPlattform_Live.Text.Contains("Alle") Then
                btnQuickSync.Visible = False
                txtGetSellerListSeiteVon.Visible = False
                chkMitWebgalerie.Visible = False
            End If

            bFormLoaded = True

            My.Settings.sys_first_start = True
            My.Settings.Save()
            tmrEbayTime.Enabled = True

        Catch ex As Exception
            debug_message(ex, "frmAuktionsmanagement")
        End Try

    End Sub


    '##################################################################################################
    '# >> Starten Daten reinladen 
    '##################################################################################################
    Private Function getInitLoadTabChange(ByVal sender As System.Object) As Boolean
        Try

            Dim tb As TabControl = DirectCast(sender, TabControl)

            Select Case tb.SelectedTab.Name

                Case "menue_eBay_Live"
                    '# LIVE - ANSICHT
                    txtSuchen.Visible = True
                    btnSuchen.Visible = True

                    If lvwEiSoCockpit.Items.Count = 0 Then
                        Call getLvwData(lvwEiSoCockpit)
                        Call getRadioOptions_counts("lvweBayLiveList")
                        Call setAktionButton()
                    Else
                        If My.Settings.yabe_lvw_data_tab_reload = True Then
                            Call getLvwData(lvwEiSoCockpit)

                        Else
                            frmMain.master_Message_label.Text = cache_statusbar.cockpit
                        End If

                    End If

                    lvwEiSoCockpit.Focus()

                Case "menue_bestellverlauf"
                    '# Bestell - ANSICHT 
                    txtSuchen.Visible = True
                    btnSuchen.Visible = True


                    If lvwBestellverwaltung_nach_artikel.Items.Count = 0 Then

                        If bGUISuchen = False Then
                            bIsLoading = True

                            If tcBestellungen_visual.SelectedIndex = 0 Then
                                Call getLvwData(lvwBestellverwaltung_nach_artikel)
                                lvwBestellverwaltung_nach_artikel.Focus()
                            Else
                                'setLVWUpdate = False
                                Call getLvwData(lvwBestellungen_kunden)
                                lvwBestellungen_kunden.Focus()
                                'setLVWUpdate = true
                            End If
                            'Call getLvwData(lvweBayHistory)
                            bIsLoading = False
                        End If

                    Else
                        If My.Settings.yabe_lvw_data_tab_reload = True Then
                            Call getLvwData(lvwBestellverwaltung_nach_artikel)
                        Else
                            frmMain.master_Message_label.Text = cache_statusbar.bestellungen

                        End If

                    End If



                Case "menue_kunden"
                    '# Kunden - ANSICHT 
                    txtSuchen.Visible = True
                    btnSuchen.Visible = True

                    If lvwKunden.Items.Count = 0 Then
                        If bGUISuchen = False Then
                            Call getLvwData(lvwKunden)
                        End If
                    Else
                        If My.Settings.yabe_lvw_data_tab_reload = True Then
                            Call getLvwData(lvwKunden)
                        Else
                            frmMain.master_Message_label.Text = cache_statusbar.kunden
                        End If

                    End If

                    lvwKunden.Focus()

                Case "menue_eBayBewertungen"
                    txtSuchen.Visible = True
                    btnSuchen.Visible = True

                    If lvwBewertungen.Items.Count = 0 Then
                        Call getLvwData(lvwBewertungen)
                    Else
                        If My.Settings.yabe_lvw_data_tab_reload = True Then
                            Call getLvwData(lvwBewertungen)
                        Else
                            frmMain.master_Message_label.Text = cache_statusbar.bewertungen
                        End If

                    End If

                    lvwBewertungen.Focus()

                Case "menue_meineBay"
                    txtSuchen.Visible = False
                    btnSuchen.Visible = False

                Case "menue_artikelverwaltung"

                    txtSuchen.Visible = True
                    btnSuchen.Visible = True


                    If lvwMenue.Items.Count = 0 Then

                        Application.DoEvents()
                        If clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", lvwMenue, cmbSprache_Artikeldatenbank.Text) = False Then
                            MsgBox("Fehler beim abrufen der Kategorieliste", MsgBoxStyle.Critical)
                        End If

                        Try
                            lvwMenue.Items(My.Settings.cubss_shop_lastselection).Selected = True
                        Catch ex As Exception

                        End Try
                        'Call setPlattforms2Combo(cmbSprache_Artikeldatenbank)
                        clsDatenbank_modul.getComboSprachen(cmbSprache_Artikeldatenbank)
                        Try
                            bIsLoading = True
                            cmbSprache_Artikeldatenbank.SelectedIndex = 0
                            bIsLoading = False
                        Catch ex As Exception

                        End Try

                    Else
                        If cmbSprache_Artikeldatenbank.Items.Count = 0 Then
                            clsDatenbank_modul.getComboSprachen(cmbSprache_Artikeldatenbank)
                            cmbSprache_Artikeldatenbank.SelectedIndex = 0
                        End If

                    End If
                    frmMain.master_Message_label.Text = cache_statusbar.artikeldatenbank

                    lvwWebArtikel.Focus()

                    Try
                        Dim iLast As Integer = My.Settings.cubss_shop_lastselection
                        lvwWebArtikel.Items(iLast).Selected = True
                    Catch ex As Exception

                    End Try


                Case "CMSebayGalerie"
                    txtSuchen.Visible = False
                    btnSuchen.Visible = False

                Case "menue_tbPaypal"
                    txtSuchen.Visible = False
                    btnSuchen.Visible = False

                Case "menue_Mailversand"
                    txtSuchen.Visible = True
                    btnSuchen.Visible = True

                    If My.Settings.yabe_lvw_data_tab_reload = True Then
                    Else

                    End If
                    frmMain.master_Message_label.Text = cache_statusbar.newsletter

                    '# J.B
                    '# Newslettertexte vorbereiten 
                    clsDatenbank_modul.getComboGroups(cmbTranslationBereichAuswählen)
                    cmbTranslationBereichAuswählen.SelectedIndex = 0

                    lvMailStatus.Focus()
                Case "menue_Statistik"
                    txtSuchen.Visible = False
                    btnSuchen.Visible = False
                    frmMain.master_Message_label.Text = cache_statusbar.statistik

                Case "menue_shopste"
                    ' tvShopste = TreeView1
                    If My.Settings.domain_id.Length = 0 Then
                        Dim frmShopsteLogin As New LoginForm1
                        frmShopsteLogin.Show()
                    End If

                    '# Nur Login wenn kein Benutzername gesetzt ist
                    If My.Settings.benutzername.Length > 0 Then

                        Dim dtSubShopCat As DataTable = FillTestTableSubShopCat()
                        CreateTree(0, dtSubShopCat)

                        'Call getHTTPResponseMessage("http://shopste.com/api.php?modus=get_shopste_category&domain_id=" & My.Settings.domain_id, mgetUpdaterMessage.getShopsteShopCategory, True)

                        'TreeView1.Nodes.Clear()
                        '' TreeView1 = tvShopste
                        'Dim treenode As TreeNode
                        'Dim strContent As String = My.Computer.FileSystem.ReadAllText("shopste-subshop.dat")
                        'Dim i As Integer = 0

                        'If strContent.Length > 0 Then




                        '    'Dim strLine() As String = strContent.Split("<br>")

                        '    ''Creating the root node
                        '    ''Dim root = New TreeNode("Shopste Kategorien")

                        '    ''  frmShopsteKategorieMapping.tvShopste()
                        '    '' TreeView1.Nodes.Add(root)
                        '    'Dim itmp As Integer = 0
                        '    'For i = 0 To strLine.Length - 2
                        '    '    Dim strData() As String = strLine(i).Split("|")
                        '    '    ' If i = 93 Then
                        '    '    '      Stop
                        '    '    'End If
                        '    '    treenode = New TreeNode(strData(3))
                        '    '    treenode.Tag = strData(0).Replace("br>", "")

                        '    '    Select Case strData(2)
                        '    '        Case "0"
                        '    '            'Creating the root node
                        '    '            'Dim root = treenode

                        '    '            '  frmShopsteKategorieMapping.tvShopste()
                        '    '            TreeView1.Nodes.Add(treenode)
                        '    '        Case "1"

                        '    '            TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Add(treenode)
                        '    '        Case "2"
                        '    '            TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes(TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Count - 1).Nodes.Add(treenode)
                        '    '    End Select


                        '    '    'Creating child nodes under the first child
                        '    '    'For loopindex As Integer = 1 To 4
                        '    '    'TreeView1.Nodes(0).Nodes(0).Nodes.Add(New  _
                        '    '    '    TreeNode("Sub Project" & Str(loopindex)))
                        '    '    'Next loopindex
                        '    '    ' creating child nodes under the root
                        '    '    'TreeView1.Nodes(0).Nodes.Add(New TreeNode("Project 6"))
                        '    '    'creating child nodes under the created child node
                        '    '    'For loopindex As Integer = 1 To 3
                        '    '    'TreeView1.Nodes(0).Nodes(1).Nodes.Add(New  _
                        '    '    '   TreeNode("Project File" & Str(loopindex)))
                        '    '    'Next loopindex

                        '    'Next

                        'End If
                        TreeView1.ExpandAll()
                    End If
            End Select

            My.Settings("lastTab") = tabMenue.SelectedIndex
            My.Settings.Save()

            Return True
        Catch ex As Exception
            Call debug_message(ex, "")
            Return False
        End Try
    End Function
    Private Sub CreateTree(parent As Integer, dt As DataTable)

        '        Dim MaxLevel1 As Integer = CInt(DataTable1.Compute("MAX(LEVEL)", ""))

        Dim i, j As Integer

        Try

            Dim Rows1() As DataRow = dt.Select("PARENT2 = '" & parent & "'")

            Dim treen As New TreeNode
            For j = 0 To Rows1.Length - 1
                Dim ID1 As String = Rows1(j).Item("ID").ToString
                Dim Name1 As String = Rows1(j).Item("NAME").ToString
                Dim Parent1 As String = Rows1(j).Item("PARENT2").ToString
                Dim level As Integer = Rows1(j).Item("Level").ToString

                If level = 1 Then
                    'TreeView1.Nodes.Add(ID1, Name1)
                    'treen.Tag = ID1
                    'treen.Text = Name1

                    TreeView1.Nodes.Add(ID1, Name1)

                    CreateTree(Rows1(j).Item("ID").ToString, dt)
                Else

                    Dim TreeNodes1() As TreeNode = TreeView1.Nodes.Find(Parent1, True)

                    If TreeNodes1.Length > 0 Then
                        TreeNodes1(0).Nodes.Add(ID1, Name1)
                        '  Node1.ChildNodes.Add(New TreeNode(Name1, ID1))

                    End If
                    CreateTree(Rows1(j).Item("ID").ToString, dt)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '   
    End Sub

    Private Function FillTestTableSubShopCat() As DataTable

        Dim DataTable1 As New DataTable

        DataTable1.Columns.Add("ID", GetType(Integer))
        DataTable1.Columns.Add("NAME", GetType(String))
        DataTable1.Columns.Add("PARENT2", GetType(Integer))
        DataTable1.Columns.Add("LEVEL", GetType(Integer))

        Call getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=get_shopste_category&domain_id=" & My.Settings.domain_id, mgetUpdaterMessage.getShopsteCategory, True)

        TreeView1.Nodes.Clear()
        ' TreeView1 = tvShopste
        Dim treenode As New TreeNode
        Dim strContent As String = My.Computer.FileSystem.ReadAllText("shopste-kategorie.dat")
        Dim i As Integer = 0
        Try


            If strContent.Length > 0 Then

                Dim strLine() As String = strContent.Split("<br>")


                For i = 0 To strLine.Length - 2
                    Dim strData() As String = strLine(i).Split("|")

                    '  If strData(4) = 0 Then
                    '      strData(4) = ""
                    '  End If

                    DataTable1.Rows.Add(strData(0).Replace("br>", ""), strData(3), strData(4), strData(2))
                Next i
            End If
            'DataTable1.Rows.Add(1, "Patrick")


            'Dim i As Integer

            'For i = 0 To DataTable1.Rows.Count - 1
            '    Dim ID1 As String = DataTable1.Rows(i).Item("ID").ToString
            '    DataTable1.Rows(i).Item("LEVEL") = FindLevel(ID1, 0)
            'Next
            Return DataTable1
        Catch ex As Exception
            MessageBox.Show("Fehler:" + ex.Message)
        End Try
    End Function

    '####################################################
    '# >> TAB - INDEX CHANGED 
    '####################################################
    Private Sub tabMenue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabMenue.SelectedIndexChanged
        If bIsLoading = False Then
            getInitLoadTabChange(sender)
        End If
    End Sub

    '####################################################################
    '# >> Öffnen der Liveansicht -> Browser 
    '####################################################################
    Private Sub LiveÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiveÖffnenToolStripMenuItem.Click

        Try

            '# 
            If lvwEiSoCockpit.SelectedItems.Count > 0 Then

                Dim frmYABE_WebBrowser As New frmYABE_WebBrowser

                Select Case lvwEiSoCockpit.SelectedItems(0).SubItems(17).Text
                    Case "eBay"

                        frmYABE_WebBrowser.strURL = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwEiSoCockpit.SelectedItems(0).Text

                    Case "delcampe"
                        frmYABE_WebBrowser.strURL = "http://delcampe.de/page/item/id," & lvwEiSoCockpit.SelectedItems(0).Text & ",language,G.html"
                End Select

                frmYABE_WebBrowser.lvwDataView = lvwEiSoCockpit
                frmYABE_WebBrowser.Show()

            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "LiveÖffnenToolStrip")
        End Try
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click

        Call setBewertungForm()

    End Sub
    '#################################################################
    '# >> Sortieren 
    '#################################################################
    Public Function setSort(ByRef listview1 As ListView, ByVal e As _
      System.Windows.Forms.ColumnClickEventArgs) As Boolean
        Try
            If bIsLoading = False Then

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

                '###########################
                '# >> Listviewnamen ermitteln 
                '###########################
                Select Case listview1.Name
                    Case "lvwEbayRechnung"
                        Select Case col
                            Case 5
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                        Call repaint(listview1)

                    Case "lvwEbayNachrichten"
                        Select Case col
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                        Call repaint(listview1)

                    Case "lvwPaypal"
                        Select Case col
                            Case 2
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 3
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                            Case 5
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                        Call repaint(listview1)

                    Case "lvwArtikelListe"
                        Select Case col
                            Case 2
                                listview1.ListViewItemSorter = New lvsorter(Of Decimal)(e.Column)
                            Case 4, 5, 9, 11
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 6
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select

                    Case "lvwKundenliste"
                        Select Case col
                            Case 1
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case 2
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select

                    Case "lvwMultiSelect"

                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(
             e.Column)
                            Case 1
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                            Case 2
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(
             e.Column)
                            Case 3
                                listview1.ListViewItemSorter = New lvsorter(Of String)(
             e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select
                        Call repaint(listview1)
                    Case "lvwWebArtikel"
                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(
      e.Column)
                            Case 2
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 5
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                                Call setLVWGroups(listview1, col)
                            Case 6
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)

                            Case 7
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                                Call setLVWGroups(listview1, col)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True And Not col = 1 Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select

                        Call repaint(listview1)

                    Case "lvwEiSoCockpit"

                        Select Case col

                            Case 2
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 4
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case 10
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case 15
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case 12
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 3
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 9
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(
      e.Column)
                            Case 11
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(
      e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True And Not col = 1 Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select
                    Case "lvwBestellverwaltung_nach_artikel"
                        Select Case col
                            Case 5
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 6
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 10
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True And Not col = 4 Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select
                    Case "lvwBestellungen_kunden"
                        Select Case col
                            Case 7, 8, 18, 19, 20
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 10, 16
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                    Case "lvwBestellungen_bestelliste_neu"
                        Select Case col
                            Case 5
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 6
                                listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                            Case 10
                                listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True And Not col = 4 Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select
                    Case "lvMailStatus"
                        Select Case col
                            Case 8
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case 9
                                listview1.ListViewItemSorter = New lvsorter(Of DateTime)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select

                        Call repaint(listview1)

                    Case "lvwKunden"
                        Select Case col
                            Case 7
                                Try
                                    listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                                Catch ex As Exception

                                End Try

                            Case 8
                                Try
                                    listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                                Catch ex As Exception

                                End Try

                            Case 10
                                Try
                                    listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                                Catch ex As Exception

                                End Try
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True Then
                                    Call setLVWGroups(listview1, col)
                                End If

                        End Select
                    Case "lvwStatisticText"
                        Select Case col
                            Case 1

                                If optTopKundenListe.Checked = True Or optTeuersterArtikel.Checked = True Then
                                    listview1.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                                Else
                                    listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                                End If

                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                        Call repaint(listview1)

                    '# Outlook eingelesene Elemente Sortieren 
                    Case "lvwOutlook_items"
                        Select Case col
                            Case 5

                                Try
                                    listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                                Catch ex As Exception

                                End Try

                            Case Else

                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True Then
                                    Call setLVWGroups(listview1, col)
                                End If
                        End Select

                        Call repaint(listview1)

                    '# YABE -> Kundenbestellverlauf 
                    Case "lvwBestellverlauf"
                        Select Case col
                            Case 5

                                Try
                                    listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                                Catch ex As Exception

                                End Try

                            Case Else

                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True Then
                                    Call setLVWGroups(listview1, col)
                                End If
                        End Select
                    Case "lvwBewertungen"
                        Select Case col
                            Case 1, 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case 6

                                Try
                                    listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                                Catch ex As Exception

                                End Try

                            Case Else

                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                                ' Dynamische Listview Groups 
                                If My.Settings.gui_allow_groupBy = True And Not col = 8 Then
                                    Call setLVWGroups(listview1, col)
                                End If
                        End Select

                        Call repaint(listview1)
                    Case "lvwShopste"

                        Select Case col
                            Case 2
                                listview1.ListViewItemSorter = New lvsorter(Of Decimal)(e.Column)
                            Case 3, 4, 5
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case 6

                                Try
                                    listview1.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                                Catch ex As Exception

                                End Try

                            Case Else

                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)

                        End Select
                End Select
            End If



            Return True
        Catch ex As Exception
            Call debug_message(ex, "setSort - Listview Sortiert")
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
    Private Sub lvweBayLiveList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwEiSoCockpit.ColumnClick

        Try
            Call setSort(lvwEiSoCockpit, e)
            'Call setStatusMessage(lvweBayLiveList)
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvweBayLiveList_ColumnClick")
        End Try
    End Sub

    Private Sub lvweBayLiveList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwEiSoCockpit.DoubleClick

        '# 
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            '    Dim ExterneAnwendung As New System.Diagnostics.Process()
            '   ExterneAnwendung.StartInfo.FileName = lvwWebArtikel.SelectedItems(0).SubItems(3).Text
            '  ExterneAnwendung.Start()
            Dim frmWeb As New frmYABE_WebBrowser
            frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel

            If IsNumeric(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(15).Text) = True Then
                frmWeb.webMain.Navigate(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(15).Text)
            Else
                frmWeb.webMain.Navigate(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(3).Text)
            End If

            frmWeb.Show(Me)

        End If

    End Sub

    '#################################################
    '# >> Bewertungsformular laden
    '#################################################
    Private Sub setBewertungForm()

        If lvwBewertungen.SelectedItems.Count > 0 Then
            Dim frmManualBewertung As New FormLeaveFeedback
            frmManualBewertung.TxtItemId.Text = lvwBewertungen.SelectedItems(0).SubItems(2).Text
            frmManualBewertung.TxtComments.Text = lvwBewertungen.SelectedItems(0).SubItems(4).Text
            frmManualBewertung.TxtUserId.Text = lvwBewertungen.SelectedItems(0).Text
            frmManualBewertung.ShowInTaskbar = False
            frmManualBewertung.ShowDialog(Me)
        End If


    End Sub
    '#################################################
    '# >> CHECKBOX: Automatischer Modus
    '#################################################
    Private Sub chkAutomatischerModus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutomatischerModus.CheckedChanged

        If chkAutomatischerModus.Checked = True Then
            frmMain.tmrLiveAnsicht.Interval = (My.Settings.app_AutoLiveListeDauer * 60000)

            iGeboteNeu_Anzahl = 0
            lvweBayLive = lvwEiSoCockpit
            bIsRefreshing_live = False
            frmMain.tmrLiveAnsicht.Enabled = True

            tmrEMailWaitTime.Interval = 1000
            tmrEMailWaitTime.Tag = My.Settings.app_AutoLiveListeDauer * 60000
            tmrEMailWaitTime.Enabled = True

            Call getPopUp("eBay Verkäuferliste holen" & vbCrLf & "automatischer Modus gestartet")
        Else
            frmMain.tmrLiveAnsicht.Enabled = False
            tmrEMailWaitTime.Enabled = False
            tmrEMailWaitTime.Interval = 100
            Call getPopUp("eBay Verkäuferliste holen " & vbCrLf & "automatischer Modus deaktiviert")
        End If

    End Sub

    Private Sub DateTimePickerVon_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpCockpit_von.LostFocus
        strDateVon = dtpCockpit_von.Text

        If bIsLoading = False Then
            bIsLoading = True
            chkLiveZeitfilter.Checked = True
            bIsLoading = False
        End If
    End Sub

    Private Sub DatePickerBis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpCockpit_bis.LostFocus
        strDateBis = dtpCockpit_bis.Text

        If bIsLoading = False Then
            bIsLoading = True
            chkLiveZeitfilter.Checked = True
            bIsLoading = False
        End If
    End Sub


    '#########################################################
    '# >> Öffnen der Artikel Detailansicht 
    '#########################################################
    Private Sub tsmeBayLive_Detailansicht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmeBayLive_Detailansicht.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim frmDetail As New FormGetItem
            frmDetail.lvwDataInput = lvwEiSoCockpit
            frmDetail.txteBayID.Text = lvwEiSoCockpit.SelectedItems(0).Text
            frmDetail.ShowDialog()
        End If

    End Sub

    '#########################################################
    '# >> Ruft die eBay Liste ab
    '#########################################################
    Public Function getSellereBayList(Optional ByVal iSeite As Integer = 0, Optional ByVal bGeboteOnly As Boolean = False) As Boolean
        Try
            '# Aktuallisierung läuft schon
            If bIsRefreshing_live = False Then

                bIsRefreshing_live = True

                '# Abrufen der Verkäuferliste             
                clseBayAPI.bis = dtpCockpit_bis
                clseBayAPI.von = dtpCockpit_von
                clseBayAPI.lvw = lvwEiSoCockpit
                clseBayAPI.strUserID = My.Settings.ebay_username
                clseBayAPI.iGlobalSeite = iSeite
                clseBayAPI.iProSeite = iPage.iPageNext

                If clseBayAPI.geteBaySellerList(iSeite, chkEndTime.Checked, bGeboteOnly) = False Then
                    bIsRefreshing_live = False
                    Return False
                    Exit Function
                End If

                'Dim t As New System.Threading.Thread(AddressOf clseBayAPI.getSellerList)
                't.Start()

                Application.DoEvents()

                '###############################
                '# >> Listenansicht aktuallisieren
                '###############################
                If clsDatenbank_modul.setListviewData_save(lvwEiSoCockpit, Me, pgreBayLiveUpdate) = False Then
                    MsgBox("Fehler beim abspeichern der Daten von aus der Anzeige", MsgBoxStyle.Exclamation)
                End If

                bIsRefreshing_live = False

            End If

            Return True

        Catch ex As Exception
            bIsRefreshing_live = False
            Call debug_message(ex, strQuery & vbCrLf & "btnRefresh - Liveansicht")
            Return False
        End Try

    End Function

    '#########################################################
    '# >> Ansicht sperren 
    '#########################################################
    Public Function setCockpit_EnableDisable(ByVal bModus As Boolean) As Boolean

        chkGebote.Enabled = bModus
        chkBuyItNow.Enabled = bModus
        chkeBayEnde.Enabled = bModus
        chkAutomatischerModus.Enabled = bModus
        btnSuchen.Enabled = bModus
        txtSuchen.Enabled = bModus
        dtpCockpit_von.Enabled = bModus
        dtpCockpit_bis.Enabled = bModus
        btnVor.Enabled = bModus
        btnZurück.Enabled = bModus
        btnAuftrag_email_senden.Enabled = bModus
        chkEndTime.Enabled = bModus
        chkDebug_email.Enabled = bModus
        cmbPlattform_Live.Enabled = bModus
        chkLiveAlle.Enabled = bModus
        chkGeboteOhne.Enabled = bModus
        chkLiveZeitfilter.Enabled = bModus
        chkMitWebgalerie.Enabled = bModus
        btnQuickSync.Enabled = bModus

    End Function

    '###########################################################
    '# >> eBay Daten holen 
    '###########################################################
    Public Function getEbayData(ByVal bGeboteOnly As Boolean) As Boolean

        Dim iSeite As Integer
        Try

            'Auktionsanfang einlesen
            If bStoppLiveRefresh = False Then

                frmMain.master_Message_label.Text = Date.Now & " - eBay Verkäuferliste einlesen wurde gestartet"

                bStoppLiveRefresh = False
                lvwEiSoCockpit.Items.Clear()

                Call setCockpit_EnableDisable(False)
                iPage.iPageNow = 1
                iPage.iPageGes = 0
                iPage.iPageAnzahlNow = clseBayAPI.iProSeite

                pgreBayLiveUpdate.Visible = True

                '# Fortsetzten bei Seite aus Textbox 
                iSeite = txtGetSellerListSeiteVon.Text
                '# Seitenzähler aktualisieren 
                iPage.iPageAnzahlNow = iSeite

                '#########################################
                '# >> Anzahl der Seiten beim blättern 
                '#########################################
                While Not clseBayAPI.iGlobalSeite = -1

                    Application.DoEvents()

                    frmMain.master_Message_label.Text = "Aktuell bei Seite: " & iPage.iPageAnzahlNow & " bis Seite: " & iPage.iPageNow & "  - " & iPage.iPageGes & " Zeit: " & Date.Now

                    iSeite += 1
                    pgreBayLiveUpdate.Value = 0

                    '############################
                    '# EBAY API CALL 
                    '############################
                    If getSellereBayList(iSeite, bGeboteOnly) = False Then

                        'If iSeite = 0 Then
                        Return False
                        Exit While
                        'Else
                        '   Continue While
                        'End If

                    End If


                    'Call setPage(eBlatt.vor)
                    iPage.iPageNow = iSeite
                    If iSeite > iPage.iPageGes And Not iPage.iPageGes = 0 Then
                        If MsgBox("Fehler Seitenzahl überschritten ! unmöglich ;-) ?" & vbCrLf & "Abruch?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Seitenzahl überschritten") = MsgBoxResult.Yes Then
                            Exit While
                        End If
                    End If

                    Application.DoEvents()
                    My.Settings.api_getSellerList_page = iSeite
                    txtGetSellerListSeiteVon.Text = iSeite
                    My.Settings.Save()
                    iPage.iPageAnzahlNow += clseBayAPI.iProSeite

                    If bStoppLiveRefresh = True Then
                        Exit While
                    End If

                End While


                Call setCockpit_EnableDisable(True)

            Else
                '# STOPP
                bStoppLiveRefresh = True
                frmMain.master_Message_label.Text = Date.Now & ": eBay Verkäuferliste wurde gestoppt"

            End If

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEbayData")
            Return False
        End Try

        Return True
    End Function

    '#############################################################
    '# >> Holen der eBAy Liste 
    '#############################################################
    Public Function geteBaySellerList(ByVal bEnde As Boolean, Optional ByVal bAutoModus As Boolean = False) As Boolean
        'Dim strModus As String
        Dim bGeboteOnly As Boolean = False

        Try

            bStoppLiveRefresh = False

            txtGetSellerListSeiteVon.Enabled = False
            ' Automatischer Modus 
            If chkAutomatischerModus.Checked = False Then


                '# Nicht bei 0 beginnen - Abfrage 
                If Convert.ToInt16(txtGetSellerListSeiteVon.Text) > 0 Then

                    If MsgBox("Möchten Sie fortfahren bei eBay Verkäuferliste mit Seite " & txtGetSellerListSeiteVon.Text & " fortfahren ?" & vbCrLf & "NEIN: eBay Verkäuferliste bei bei Seite 1 einlesen", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "eBay Verkaufsliste einlesen") = MsgBoxResult.No Then

                        'txtGetSellerListSeiteVon.Enabled = True
                        txtGetSellerListSeiteVon.Text = "0" ' Am Anfang beginnen 
                    End If

                End If

            Else
                txtGetSellerListSeiteVon.Text = "0" ' Am Anfang beginnen 
            End If


            '############################################
            '# >> Automatischer Modus aktiv ?
            '############################################
            If chkAutomatischerModus.Checked = False Then

                If chkGebote.Visible = True And chkGebote.Checked = True Then
                    bGeboteOnly = True
                Else
                    bGeboteOnly = False
                End If


            Else

                bGeboteOnly = True
            End If


            '# Neuladen der verworfenen Wait4Somethink komponente
            Dim frmWait_re As New frmWait4Something
            clseBayAPI.frmWait = frmWait_re
            clseBayAPI.iGlobalSeite = 0

            btnRefresh.Visible = False
            btnAuktionEinlesen.Visible = False
            btnLiveStopp.Visible = True

            If bEnde = True Then

                '# eBay Daten speichern -> Galerie  
                If getEbayData(bGeboteOnly) = False Then
                    If bAutoModus = False Then
                        MsgBox("Es wurden keine eBay Artikel im Zeitraum gefunden!", MsgBoxStyle.Exclamation)
                    Else
                        getPopUp(Date.Now & ": Es wurden keine eBay Artikel im Zeitraum gefunden")
                    End If


                    Call setCockpit_EnableDisable(True)


                    txtGetSellerListSeiteVon.Text = 0 ' fertig 
                    txtGetSellerListSeiteVon.Enabled = True

                    ' eBay Ende Checkbox 
                    If chkeBayEnde.Checked = False Then
                        btnAuftrag_email_senden.Visible = False
                    Else
                        If chkGebote.Checked = True Then
                            If lvwEiSoCockpit.Items.Count > 0 Then
                                btnAuftrag_email_senden.Visible = True
                            Else
                                btnAuktionEinlesen.Visible = True
                            End If

                        End If

                    End If
                    Exit Function
                End If
                '# Kein ENDE 
            Else

                '####################################################
                '# >> Ebay Datenabruf vorbereiten 
                '####################################################
                If getEbayData(bGeboteOnly) = False Then
                    If bAutoModus = False Then
                        MsgBox("Es wurden keine eBay Artikel im Zeitraum gefunden!", MsgBoxStyle.Exclamation, "Keine eBay Artikel im Zeitraum gefunden")
                    Else
                        getPopUp(Date.Now & ": Es wurden keine eBay Artikel im Zeitraum gefunden")
                    End If

                    bStoppLiveRefresh = True
                    btnAuktionEinlesen.Enabled = True
                    btnAuktionEinlesen.Visible = True
                    btnRefresh.Visible = True
                    btnSuchen.Enabled = True
                    txtSuchen.Enabled = True
                    chkLiveZeitfilter.Enabled = True
                    btnLiveStopp.Visible = False

                    btnAuktionEinlesen.Visible = True

                    txtGetSellerListSeiteVon.Enabled = True
                    btnSuchen.Enabled = True
                    txtSuchen.Enabled = True
                    btnRefresh.Visible = True
                    chkLiveZeitfilter.Enabled = True

                    txtGetSellerListSeiteVon.Text = 0 ' fertig 
                    txtGetSellerListSeiteVon.Enabled = True
                    ' eBay Ende Checkbox 
                    If chkeBayEnde.Checked = False Then
                        btnAuftrag_email_senden.Visible = False
                    Else
                        If chkGebote.Checked = True Then
                            If lvwEiSoCockpit.Items.Count > 0 Then
                                btnAuftrag_email_senden.Visible = True
                            Else
                                btnAuktionEinlesen.Visible = True
                            End If

                        End If

                    End If

                    Exit Function
                End If
            End If

            '# Kontrolls anzeigen
            btnLiveStopp.Visible = False
            btnAuktionEinlesen.Visible = True

            '####################################
            '# >> eBay Galerie Aktuallisieren
            '####################################
            If bStoppLiveRefresh = False Then

                '# Automatischer Modus 
                If chkAutomatischerModus.Checked = False Then
                    If iGeboteNeu_Anzahl > 0 Then
                        ' Nur gebote 
                        If My.Settings.yabe_cockpit_mitwebgalerie = True Then
                            setBludauMediaLogbuch(">> eBay Auktionsdaten für Webgalerie eingelesen...", "EBAY_WEBGALLERIE")
                            Call setEBayGalerieData(bGeboteOnly)
                        End If
                    End If

                Else

                    If iGeboteNeu_Anzahl > 0 Then
                        ' Nur Gebote Synchronisieren
                        If My.Settings.yabe_cockpit_mitwebgalerie = True Then
                            setBludauMediaLogbuch(">> eBay Auktionsdaten für Webgalerie eingelesen...", "EBAY_WEBGALLERIE")
                            Call setEBayGalerieData(True)
                        End If

                    End If


                End If

            End If

            bStoppLiveRefresh = True
            btnAuktionEinlesen.Enabled = True
            btnAuktionEinlesen.Visible = True
            btnRefresh.Visible = True
            btnSuchen.Enabled = True
            txtSuchen.Enabled = True
            chkLiveZeitfilter.Enabled = True

            txtGetSellerListSeiteVon.Text = 0 ' fertig 
            My.Settings.api_getSellerList_page = 0
            My.Settings.Save()
            txtGetSellerListSeiteVon.Enabled = True

            '# Listview neu aufbauen 
            Call getLvwData(lvwEiSoCockpit)

            Return True

        Catch ex As Exception
            '# Zurückstellen der GUI im Fehlerfall

            btnAuktionEinlesen.Enabled = True
            btnAuktionEinlesen.Visible = True

            txtGetSellerListSeiteVon.Enabled = True
            btnSuchen.Enabled = True
            txtSuchen.Enabled = True
            btnRefresh.Visible = True
            chkLiveZeitfilter.Enabled = True
            Call debug_message(ex, strQuery & vbCrLf & "btnGeteBayList")

            Return False
        End Try

    End Function
    '#########################################################
    '# >> Anzeigen der eBay Artikel Liste (Refresh)
    '#########################################################
    Private Sub btnRefresh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuktionEinlesen.Click

        Try

            btnAuktionEinlesen.Enabled = False
            '# Alle
            '# eBay
            '# Delcampe
            '# Shopsysteme

            setBludauMediaLogbuch(">> COCKPIT >> ARTIKEL EINLESEN GESTARTET...", "COCKPIT")

            Dim str() As String = cmbPlattform_Live.Text.Split(" ")
            Select Case str(0)
                Case "Alle"

                    'If chkEndTime.Checked = True Then
                    '    Call geteBaySellerList(True)
                    '    bStoppLiveRefresh = False
                    'Else
                    '    Call geteBaySellerList(False)
                    '    bStoppLiveRefresh = False
                    'End If
                    bIsLoading = True
                    Call getLvwData(lvwEiSoCockpit)
                    Call getRadioOptions_counts("lvweBayLiveList")
                    bIsLoading = False
                Case "eBay"

                    If chkEndTime.Checked = True Then
                        Call geteBaySellerList(True)
                        bStoppLiveRefresh = False
                    Else
                        Call geteBaySellerList(False)
                        bStoppLiveRefresh = False
                    End If

                Case "Delcampe"
                    Dim frmOutlook As New frmOutlook_sync
                    frmOutlook.bAutoMode = True
                    frmOutlook.Show()

                Case "Shopsysteme"
                    Dim frmWeb As New frmYABE_WebBrowser
                    frmWeb.strURL = My.Settings.shop_url & "/ACP/adminpanel.php"
                    frmWeb.Show()
                Case "Magento"
                    Dim frmMagento As New frmMagentoManger
                    frmMagento.ShowOnStartup = frmMagentoManger.bShowOnStartup.bestellungen
                    frmMagento.Show()
                Case "Shopste"
                    Dim frmWeb As New frmYABE_WebBrowser
                    frmWeb.strURL = "http://shopste.com"
                    frmWeb.Show()
            End Select


            Dim strZeit As String = ""
            If chkLiveZeitfilter.Checked = True Then
                Dim strDatumVon As String = getDateFromTimepicker(dtpCockpit_von.Value.ToString, True)
                Dim strDatumBis As String = getDateFromTimepicker(dtpCockpit_bis.Value.ToString, False)
                strZeit = " AND auction_begin >= '" & strDatumVon & "' AND auction_end <= '" & strDatumBis & "'"
            End If

            'Dim iSel As Integer = cmbPlattform_Live.SelectedIndex
            'bIsLoading = True
            'Call getPlattforms(cmbPlattform_Live, clsDatenbank.datentabelle.yabe_auction_list_live, strZeit)
            'cmbPlattform_Live.SelectedIndex = iSel
            'bIsLoading = False

            '# Zähler für Checkboxen 
            Call getRadioOptions_counts(lvwEiSoCockpit.Name)

            setBludauMediaLogbuch(">> COCKPIT >> ARTIKEL FÜR" & str(0) & lvwEiSoCockpit.Items.Count & " eingelesen | " & frmMain.master_Message_label.Text, "COCKPIT")


            btnAuktionEinlesen.Enabled = True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "btnRefresh2 - LiveAnsicht")
        End Try

    End Sub

    '####################################################################
    '# >> Fügt einen TabIndexWechsler hinzu 
    '####################################################################
    Public Function setTabIndex(ByVal index As Integer) As Boolean
        Try

            Me.tabMenue.SelectedIndex = index

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setTabIndex")
            Return False
        End Try

        Return True
    End Function

    '####################################################################
    '# >> Bewertungen holen 
    '####################################################################
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshBewertungen.Click

        If bIsLoading = False Then
            setLookForm(lvwBewertungen, False)
            bIsLoading = True

            pgrBewertungenUpdate.Visible = True
            pgrBewertungenUpdate.Value = 0

            '# Bewertungen abrufen 
            If txtBewertungen.Text.Length > 0 Then
                Call clseBayAPI.getFeedBackList(lvwBewertungen, txtBewertungen.Text, frmMain.tool_ebayMessage)
            End If

            If txtBewertungen.Text = My.Settings.ebay_username Then
                If clsDatenbank_modul.setListviewData_save(lvwBewertungen, Me, pgrBewertungenUpdate) = False Then
                    MsgBox("Fehler beim abspeichern der Daten von aus der Anzeige", MsgBoxStyle.Exclamation)
                End If
            End If

            setLookForm(lvwBewertungen, True)
            lvwBewertungen.EndUpdate()

            Call getLvwData(lvwBewertungen)

            bIsLoading = False
        End If

    End Sub

    '##########################################
    '# >> Datum ermitteln 
    '##########################################
    Function getDateFromTimepicker(ByVal strDatum As String, ByVal bBegin As Boolean) As String
        Dim str() As String
        Dim strTime As String
        Try

            If bBegin = True Then
                strTime = " 00:00:00"
            Else
                strTime = " 23:59:59"
            End If

            str = strDatum.ToString.Split(" ")
            ' DATUM 2 Felder, 3 sind möglich mit Wochentag als Text
            If str.Length = 2 Then
                str = str(0).Split(".")
                strDatum = str(2) & "-" & str(1) & "-" & str(0) & strTime
            End If


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getDateFromTimepicker")
            Return "-1"
        End Try

        Return strDatum
    End Function

    '##########################################
    '# >> CHECKBOX: Nur Gebote anzeigen lassen
    '##########################################
    Public Function getSQLQuery_Options(ByVal lvw As ListView, Optional ByVal bSuche As Boolean = False) As String
        Dim strLabel As String = ""
        Dim strModus As String = ""
        Dim strQuery As String = ""


        Dim strDatumVon As String = ""
        Dim strDatumBis As String = ""
        Try
            Select Case lvw.Name

                '#####################################
                '# >> eBay Live Liste 
                '#####################################
                Case "lvwEiSoCockpit"

                    Dim str() As String = cmbPlattform_Live.Text.Split(" ")

                    Select Case str(0)
                        Case "Alle"

                        Case "eBay"

                            strQuery = " yabe_auction_list_live.auction_type ='eBay'"

                        Case "Delcampe"
                            strQuery = " yabe_auction_list_live.auction_type ='Delcampe'"
                        Case "Shopsysteme"

                            strQuery = " yabe_auction_list_live.auction_type ='CMS'"
                        Case "Magento"
                            strQuery = " yabe_auction_list_live.auction_type ='Magento'"
                        Case "Shopste"
                            strQuery = " yabe_auction_list_live.auction_type ='Shopste'"

                    End Select

                    '# ALLE Anzeigen - beendet ja nein 
                    If chkLiveAlle.Checked = True Then
                        '# Beendet bei eBay 
                        If chkeBayEnde.Checked = True Then
                            strModus = "Completed"

                            If Not strQuery.Length = 0 Then
                                strQuery &= " AND "
                            End If

                            strQuery &= " yabe_auction_list_live.iseBayEnded = '" & strModus & "'"

                            If chkGebote.Checked = True Then
                                strQuery &= "AND yabe_auction_list_live.eBay_account != '' AND isDeleted='false'"
                            End If

                        Else
                            If Not strQuery.Length = 0 Then
                                strQuery &= " AND "
                            End If
                            strModus = "Active"
                            strQuery &= " yabe_auction_list_live.iseBayEnded = '" & strModus & "'"

                        End If
                    Else
                        '# Gebote beachten 
                        If chkGebote.Checked = True Then
                            If Not strQuery.Length = 0 Then
                                strQuery &= " AND "
                            End If
                            strQuery &= " yabe_auction_list_live.bids <> 0"
                        End If

                        If chkGeboteOhne.Checked = True Then
                            If Not strQuery.Length = 0 Then
                                strQuery &= " AND "
                            End If
                            strQuery &= " yabe_auction_list_live.bids = 0"
                        End If

                        '# Sofortkauf 
                        If chkBuyItNow.Checked = True Then

                            If strQuery.Length > 0 Then
                                strQuery &= " AND yabe_auction_list_live.ListType = 'FixedPrice'"
                            Else
                                strQuery &= " yabe_auction_list_live.ListType = 'FixedPrice'"
                            End If

                        Else

                        End If


                        '# Beendet bei eBay 
                        If chkeBayEnde.Checked = True Then
                            strModus = "Completed"

                            If strQuery.Length > 0 Then
                                strQuery &= " AND yabe_auction_list_live.iseBayEnded = '" & strModus & "'"
                            Else
                                strQuery &= " yabe_auction_list_live.iseBayEnded = '" & strModus & "'"
                            End If

                            If chkGebote.Checked = True Then
                                strQuery &= "AND yabe_auction_list_live.eBay_account != '' AND isDeleted='false'"
                            End If
                        Else
                            strModus = "Active"
                            If strQuery.Length > 0 Then
                                strQuery &= " AND yabe_auction_list_live.iseBayEnded = '" & strModus & "'"
                            Else
                                strQuery &= " yabe_auction_list_live.iseBayEnded = '" & strModus & "'"
                            End If


                        End If

                        '# speichern der Oberlfäche in den Settings
                        My.Settings.gui_live_auktionsende = chkEndTime.Checked
                        My.Settings.gui_live_beendet = chkeBayEnde.Checked

                        My.Settings.gui_live_datumfilter = chkLiveZeitfilter.Checked
                        My.Settings.gui_live_gebote = chkGebote.Checked
                        My.Settings.gui_live_sofortkauf = chkBuyItNow.Checked
                        My.Settings.Save()



                    End If

                    '# Zeitfilter aktiv 
                    If chkLiveZeitfilter.Checked = True Then

                        strDatumVon = getDateFromTimepicker(dtpCockpit_von.Value.ToString, True)
                        strDatumBis = getDateFromTimepicker(dtpCockpit_bis.Value.ToString, False)
                        If chkEndTime.Checked = True Then
                            strLabel = "auction_end"
                        Else
                            strLabel = "auction_begin"
                        End If

                        If strQuery.Length > 0 Then
                            strQuery &= " AND "
                        End If

                        strQuery &= strLabel & " >= '" & strDatumVon & "' AND " & strLabel & " <= '" & strDatumBis & "'"
                    End If


                '#####################################
                '# >> YABE Kunden 
                '#####################################
                Case "lvwBestellungen_kunden"

                    ''# Gebote beachten 
                    'If chkBestellungenVerkauft.Checked = True Then
                    '    strQuery = " yabe_auction_list_history.bids > 0"

                    'Else
                    '    strQuery = " yabe_auction_list_history.bids = 0"

                    'End If



                    Dim strAnd As String = ""
                    If cmbPlattform_bestellungen.Text.Contains("Alle") Then
                        strAnd = " "
                    Else
                        strAnd = " AND "

                    End If


                    '# Auswahl welche Kunden angezeigt werden sollen
                    If cmbPlattform_bestellungen.Text.Contains("eBay") Then
                        strQuery &= "  yabe_personals_adress.Type ='eBay'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopsysteme") Then
                        strQuery &= "  yabe_personals_adress.Type ='CMS'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Delcampe") Then
                        strQuery &= "  yabe_personals_adress.Type ='Delcampe'"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Magento") Then
                        strQuery &= "  yabe_personals_adress.Type ='Magento'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopste") Then
                        strQuery &= "  yabe_personals_adress.Type ='Shopste'"
                    End If

                    If chkBestellungen_Alle.Checked = False Then
                        If chkBestellungen_verkauft.Checked = True Then
                            strQuery &= strAnd & " yabe_order_list.order_status_history_id = '14'"
                        End If

                        If chkBestellungen_Komplett.Checked = True Then
                            strQuery &= strAnd & " yabe_order_list.order_status_history_id = '10'"
                        End If

                        '# Gelöscht 
                        If chkBestellungen_Storniert.Checked = True Then
                            strQuery &= strAnd & " yabe_order_list.order_status_history_id = '11'"

                        End If

                        If chkBestellungen_Versand.Checked = True Then
                            strQuery &= strAnd & " yabe_order_list.order_status_history_id = '9'"
                        End If


                        If chkBestellungen_bezahlt.Checked = True Then
                            strQuery &= strAnd & " yabe_order_list.order_status_history_id = '8'"
                        End If

                        '# Bewertung
                        If chkBestellungen_KeineBewertung.Checked = True Then
                            strQuery = strAnd & " yabe_order_list.order_status_history_id = '12'"
                        End If
                    End If

                    '# Zeitfilter aktiv 
                    If chkHistoryZeitfilter.Checked = True Then

                        strDatumVon = getDateFromTimepicker(eBayHistoryVon.Value.ToString, True)
                        strDatumBis = getDateFromTimepicker(eBayHistoryBis.Value.ToString, False)
                        'yabe_personals_adress.adress_lastupdate
                        If cmbPlattform_bestellungen.Text.Contains("Alle") Then

                            If strQuery.Length > 0 Then
                                strAnd = " AND "
                            End If

                            strQuery &= strAnd & " yabe_order_list.created_at >= '" & strDatumVon & "' AND yabe_order_list.created_at <= '" & strDatumBis & "'"
                        Else

                            If strQuery.Length > 0 Then
                                strAnd = " AND "
                            End If

                            strQuery &= strAnd & " yabe_order_list.created_at >= '" & strDatumVon & "' AND yabe_order_list.created_at <= '" & strDatumBis & "'"
                        End If

                    End If

                '  strQuery &= " AND yabe_order_list.orderID  = ' = '" & lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text & "'"

                Case "lvwKunden"

                    '# Auswahl welche Kunden angezeigt werden sollen
                    If cmbPlattform_kunden.Text.Contains("eBay") Then
                        strQuery &= " yabe_personals_adress.Type ='eBay'"

                    ElseIf cmbPlattform_kunden.Text.Contains("Shopsysteme") Then
                        strQuery &= " yabe_personals_adress.Type ='CMS'"

                    ElseIf cmbPlattform_kunden.Text.Contains("Delcampe") Then
                        strQuery &= " yabe_personals_adress.Type ='Delcampe'"
                    ElseIf cmbPlattform_kunden.Text.Contains("Magento") Then
                        strQuery &= " yabe_personals_adress.Type ='Magento'"
                    ElseIf cmbPlattform_kunden.Text.Contains("Shopste") Then
                        strQuery &= " yabe_personals_adress.Type ='Shopste'"
                    End If

                    '# Zeitfilter aktiv 
                    If chkKundenZeitfilter.Checked = True Then

                        strDatumVon = getDateFromTimepicker(KundenVon.Value.ToString, True)
                        strDatumBis = getDateFromTimepicker(KundenBis.Value.ToString, False)

                        If strQuery.Length = 0 Then
                            strQuery &= " yabe_order_list.created_at >= '" & strDatumVon & "'"
                        Else
                            strQuery &= " AND (yabe_order_list.created_at >= '" & strDatumVon & "' yabe_order_list.created_at <= '" & strDatumBis & "')"
                        End If

                    End If



                '#####################################
                '# >> eBay Bewertungen 
                '#####################################
                Case "lvwBewertungen"

                    If chkBewertung_janein.Checked = True Then
                        strQuery &= " bIsFeedback = 'N'"
                    Else
                        strQuery &= " bIsFeedback = 'Y'"
                    End If

                    '# Zeitfilter aktiv 
                    If chkBewertungZeitfilter.Checked = True Then

                        strDatumVon = getDateFromTimepicker(dtp_BewertungVon.Value.ToString, True)
                        strDatumBis = getDateFromTimepicker(dtp_BewertungBis.Value.ToString, False)

                        If strQuery.Length = 0 Then
                            strQuery &= " feedback_time >= '" & strDatumVon & "'"
                        Else
                            strQuery &= " AND feedback_time >= '" & strDatumVon & "' AND feedback_time <= '" & strDatumBis & "'"
                        End If

                    End If


                Case "lvwBestellungen_bestelliste"


                    '# Gebote beachten 
                    If chkBestellungenVerkauft.Checked = True Then
                        strQuery = " yabe_auction_list_history.bids > 0"

                    Else
                        strQuery = " yabe_auction_list_history.bids = 0"

                    End If

                    If chkBestellungen_Alle.Checked = False Then
                        If chkBestellungen_verkauft.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Bestellt'"
                        End If

                        If chkBestellungen_Komplett.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Komplett'"
                        End If

                        '# Gelöscht 
                        If chkBestellungen_Storniert.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Storniert'"

                        End If

                        If chkBestellungen_Versand.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Verschickt'"
                        End If


                        If chkBestellungen_bezahlt.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Bezahlt'"
                        End If

                        '# Bewertung
                        If chkBestellungen_KeineBewertung.Checked = True Then
                            strQuery = " AND yabe_auction_list_history.isBewertung = 'Y'"
                        End If
                    End If


                    '# Auswahl welche Kunden angezeigt werden sollen
                    If cmbPlattform_bestellungen.Text.Contains("eBay") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='eBay'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopsysteme") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='CMS'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Delcampe") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='Delcampe'"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Magento") Then
                        strQuery = " AND yabe_auction_list_history.auction_type ='Magento'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopste") Then
                        strQuery = " AND yabe_auction_list_history.auction_type ='Shopste'"
                    End If

                    '# Zeitfilter aktiv 
                    If chkHistoryZeitfilter.Checked = True Then

                        strDatumVon = getDateFromTimepicker(eBayHistoryVon.Value.ToString, True)
                        strDatumBis = getDateFromTimepicker(eBayHistoryBis.Value.ToString, False)

                        strQuery &= " AND yabe_auction_list_history.auction_begin >= '" & strDatumVon & "' AND yabe_auction_list_history.auction_end <= '" & strDatumBis & "'"
                        ' strQuery &= " AND yabe_auction_list_history.auction_end < '" & strDatumBis & "'"
                    End If

                    If strQuery.Contains("AND") = True Then
                        strQuery = " AND yabe_order_list.orderID='" & lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text & "'"
                    Else
                        strQuery = " yabe_order_list.orderID='" & lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text & "'"
                    End If


                '#####################################
                '# >> eBay History 
                '#####################################
                Case "lvwBestellverwaltung_nach_artikel"


                    '# Gebote beachten 
                    If chkBestellungenVerkauft.Checked = True Then
                        strQuery = " yabe_auction_list_history.bids > 0"

                    Else
                        strQuery = " yabe_auction_list_history.bids = 0"

                    End If

                    If chkBestellungen_Alle.Checked = False Then
                        If chkBestellungen_verkauft.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Bestellt'"
                        End If

                        If chkBestellungen_Komplett.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Komplett'"
                        End If

                        '# Gelöscht 
                        If chkBestellungen_Storniert.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Storniert'"

                        End If

                        If chkBestellungen_Versand.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Verschickt'"
                        End If


                        If chkBestellungen_bezahlt.Checked = True Then
                            strQuery &= " AND yabe_auction_list_history.status = 'Bezahlt'"
                        End If

                        '# Bewertung
                        If chkBestellungen_KeineBewertung.Checked = True Then
                            strQuery = " AND yabe_auction_list_history.isBewertung = 'Y'"
                        End If
                    End If


                    '# Auswahl welche Kunden angezeigt werden sollen
                    If cmbPlattform_bestellungen.Text.Contains("eBay") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='eBay'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopsysteme") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='CMS'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Delcampe") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='Delcampe'"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Magento") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='Magento'"

                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopste") Then
                        strQuery &= " AND yabe_auction_list_history.auction_type ='Shopste'"
                    End If

                    '# Zeitfilter aktiv 
                    If chkHistoryZeitfilter.Checked = True Then

                        strDatumVon = getDateFromTimepicker(eBayHistoryVon.Value.ToString, True)
                        strDatumBis = getDateFromTimepicker(eBayHistoryBis.Value.ToString, False)

                        strQuery &= " AND yabe_auction_list_history.auction_begin >= '" & strDatumVon & "' AND yabe_auction_list_history.auction_end <= '" & strDatumBis & "'"
                        ' strQuery &= " AND yabe_auction_list_history.auction_end < '" & strDatumBis & "'"
                    End If


                Case "lvMailStatus"

                    strQuery &= " yabe_personals_profile.getNewsletter ='Y'"

                    If chkNewsletterAlle.Checked = False Then


                        If chkVerschickt.Checked = True Then
                            strQuery &= " AND yabe_personals_profile.letzte_mail='Y'"
                        Else
                            strQuery &= " AND yabe_personals_profile.letzte_mail='N'"
                        End If

                        If chkNewsletterIsWebuser.Checked = True Then
                            strQuery &= " AND yabe_personals_profile.isWebUser='Y'"
                        End If

                        If chkNewsletterIsDelcampe.Checked = True Then
                            strQuery &= " AND Not yabe_personals_profile.delcampe_userid =''"
                        End If

                        If chkNurKlickt.Checked = True Then
                            strQuery &= " AND yabe_personals_profile.eMail_click_count > 0"
                        End If
                    Else
                        If chkVerschickt.Checked = True Then
                            strQuery &= " AND yabe_personals_profile.letzte_mail='Y'"
                        Else
                            strQuery &= " AND yabe_personals_profile.letzte_mail='N'"
                        End If

                    End If

            End Select

            Return strQuery

        Catch ex As Exception
            debug_message(ex, "getSQLQuery_Options")
            strQuery = "-1"
            Return strQuery
        End Try



    End Function

    '##########################################
    '# >> Listview refresh
    '##########################################
    Function getLvwData(ByVal lvw As ListView, Optional ByVal bSuchen As Boolean = False) As Boolean
        Dim strQuery As String = ""
        Dim strSQLOption As String = ""
        Dim strTableName As String = ""
        Try

            '#########################################
            '# >> Sperren der Oberlfäche
            '#########################################
            Call setLookForm(lvw, False)

            '##########################################
            '# Generiert den SQL Code 
            '##########################################
            strSQLOption = getSQLQuery_Options(lvw, bSuchen)

            Select Case lvw.Name
                '#########################
                '# >> eBay Live List 
                '#########################
                Case "lvwEiSoCockpit"

                    strTableName = "yabe_auction_list_live"

                    If strSQLOption.Length > 0 Then
                        If chkLiveAlle.Checked = True Or chkGeboteOhne.Checked = True Then
                            strQuery = "SELECT * FROM yabe_auction_list_live WHERE " & strSQLOption
                        Else

                            strQuery = "SELECT yabe_auction_list_live.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_live LEFT JOIN yabe_personals_adress  ON yabe_personals_adress.ID = yabe_auction_list_live.personal_id   LEFT JOIN yabe_personals_profile ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id  WHERE " & strSQLOption
                        End If

                    Else
                        If chkLiveAlle.Checked = True Or chkGeboteOhne.Checked = True Then
                            'strQuery = "SELECT * FROM yabe_auction_list_live "

                            strQuery = "SELECT yabe_auction_list_live.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_live LEFT JOIN yabe_personals_adress  ON yabe_personals_adress.ID = yabe_auction_list_live.personal_id  LEFT JOIN yabe_personals_profile ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id"
                        Else

                            strQuery = "SELECT yabe_auction_list_live.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_live LEFT JOIN yabe_personals_adress  ON yabe_personals_adress.ID = yabe_auction_list_live.personal_id  LEFT JOIN yabe_personals_profile ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id"
                        End If
                    End If

                    '#########################
                    '# >> Suchen 
                    '#########################
                    If bSuchen = True Then
                        If IsNumeric(txtSuchen.Text) = True Then

                            strQuery = "SELECT yabe_auction_list_history.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_live LEFT JOIN yabe_personals_adress  ON yabe_auction_list_live.personal_id = yabe_personals_adress.id JOIN yabe_personals_profile ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_auction_list_live.eBay_ID like '%" & txtSuchen.Text & "%' OR yabe_auction_list_live.auction_title LIKE '%" & txtSuchen.Text & "%' ORDER BY yabe_auction_list_live.email DESC, yabe_auction_list_live.auction_title ASC"


                        Else
                            strQuery = "SELECT yabe_auction_list_live.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_live LEFT JOIN yabe_personals_adress  ON yabe_personals_adress.ID = yabe_auction_list_live.personal_id  JOIN yabe_personals_profile ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_personals_adress.name like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.ebay_account like '%" & txtSuchen.Text & "%'  OR yabe_personals_adress.email like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.city like '%" & txtSuchen.Text & "%' OR yabe_auction_list_live.eBay_account LIKE '%" & txtSuchen.Text & "%' OR yabe_personals_adress.country LIKE '%" & txtSuchen.Text & "%' OR yabe_auction_list_live.auction_title LIKE '%" & txtSuchen.Text & "%' ORDER BY  yabe_auction_list_live.auction_end DESC, yabe_personals_adress.name ASC"
                        End If
                    Else
                        '# Sortierung einfügen
                        strQuery &= " ORDER BY yabe_auction_list_live.email ASC, yabe_auction_list_live.auction_title ASC"
                    End If

                    Application.DoEvents()
                    clsDatenbank_modul.dblGesamtsumme = 0
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)
                    Application.DoEvents()

                    '# Beendet und verschicken
                    If lvwEiSoCockpit.Items.Count > 0 Then

                        If chkGebote.Checked = True And chkeBayEnde.Checked = True Then
                            btnAuktionEinlesen.Visible = False
                            btnAuftrag_email_senden.Visible = True
                            btnAuftrag_Versandkosten.Visible = True

                        End If
                    Else
                        btnAuktionEinlesen.Visible = True
                        btnAuftrag_email_senden.Visible = False
                        btnAuftrag_Versandkosten.Visible = False
                    End If

                    Call setStatusMessage(lvw)
                    lvw.Columns(0).Width = 120
                    If lvw.Items.Count > 0 Then
                        lvw.Items(0).Selected = True
                    End If

                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "COCKPIT")

                Case "lvwBestellungen_bestelliste_neu"

                    strTableName = "yabe_order_list"

                    '# Verkaufte Artikel -> mit profildaten und Adresse
                    If chkBestellungenVerkauft.Checked = True Then
                        strQuery = "SELECT * FROM yabe_order_list LEFT JOIN yabe_auction_list_history ON yabe_order_list.orderID = yabe_auction_list_history.eiso_orderlist_id LEFT JOIN yabe_personals_profile ON yabe_personals_profile.ID = yabe_order_list.yabe_personals_id LEFT JOIN yabe_personals_adress ON yabe_personals_adress.profil_id = yabe_order_list.yabe_personals_id WHERE " & strSQLOption & ""

                        If strSQLOption.Length = 0 Then
                            strQuery &= "  yabe_order_list.orderID='" & lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text & "'"

                        End If
                        '# Sortierung einfügen
                        strQuery &= " ORDER BY yabe_auction_list_history.auction_end DESC, yabe_personals_adress.name ASC"
                    Else
                        strQuery = "SELECT * FROM yabe_auction_list_history  WHERE " & strSQLOption & " ORDER BY yabe_auction_list_history.auction_end DESC"
                    End If


                    If cmbPlattform_bestellungen.Text.Contains("Alle") Then
                        lblBestellungen_main.Text = "Alle Bestellungen"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Delcampe") Then
                        lblBestellungen_main.Text = "Delcampe Bestellungen"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("eBay") Then
                        lblBestellungen_main.Text = "eBay Bestellungen"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopsysteme") Then
                        lblBestellungen_main.Text = "Shop Bestellungen"
                    End If


                    '#########################
                    '# >> Suchen 
                    '#########################
                    If bSuchen = True Then
                        If IsNumeric(txtSuchen.Text) = True Then

                            strQuery = "SELECT * FROM yabe_order_list LEFT JOIN yabe_auction_list_history ON yabe_order_list.orderID = yabe_auction_list_history.eiso_orderlist_id LEFT JOIN yabe_personals_profile ON yabe_personals_profile.ID = yabe_order_list.yabe_personals_id LEFT JOIN yabe_personals_adress ON yabe_personals_adress.profil_id = yabe_order_list.yabe_personals_id WHERE yabe_auction_list_history.eBay_ID like '%" & txtSuchen.Text & "%' OR yabe_auction_list_history.auction_title LIKE '%" & txtSuchen.Text & "%' ORDER BY yabe_auction_list_history.email DESC, yabe_auction_list_history.auction_title ASC"

                        Else
                            '# Name 
                            '# eMail
                            '# Adresse
                            '# Artikelbeschreibung
                            '# eBay Name 
                            strQuery = "SELECT * FROM yabe_order_list LEFT JOIN yabe_auction_list_history ON yabe_order_list.orderID = yabe_auction_list_history.eiso_orderlist_id LEFT JOIN yabe_personals_profile ON yabe_personals_profile.ID = yabe_order_list.yabe_personals_id LEFT JOIN yabe_personals_adress ON yabe_personals_adress.profil_id = yabe_order_list.yabe_personals_id WHERE yabe_personals_adress.name like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.ebay_account like '%" & txtSuchen.Text & "%'  OR yabe_personals_adress.email like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.city like '%" & txtSuchen.Text & "%' OR yabe_auction_list_history.eBay_account LIKE '%" & txtSuchen.Text & "%' OR yabe_personals_adress.country LIKE '%" & txtSuchen.Text & "%' OR yabe_auction_list_history.auction_title LIKE '%" & txtSuchen.Text & "%' ORDER BY  yabe_auction_list_history.auction_end DESC, yabe_personals_adress.name ASC "
                        End If  'numeric 
                    Else

                    End If


                    Application.DoEvents()
                    clsDatenbank_modul.dblGesamtsumme = 0
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)

                    If setLVWUpdate = True Then
                        Call setStatusMessage(lvw)
                    End If

                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "BESTELLUNGEN-DETAIL")

                '#########################
                '# >> eBay History 
                '#########################
                Case "lvwBestellverwaltung_nach_artikel"

                    strTableName = "yabe_auction_list_history"

                    '# Verkaufte Artikel -> mit profildaten und Adresse
                    If chkBestellungenVerkauft.Checked = True Then
                        strQuery = "SELECT yabe_auction_list_history.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_history LEFT JOIN yabe_personals_adress  ON yabe_personals_adress.ID = yabe_auction_list_history.personal_id  JOIN yabe_personals_profile ON  yabe_personals_profile.id = yabe_personals_adress.profil_id WHERE " & strSQLOption & ""
                        '# Sortierung einfügen
                        strQuery &= " ORDER BY yabe_auction_list_history.auction_end DESC, yabe_personals_adress.name ASC"
                    Else
                        strQuery = "SELECT * FROM yabe_auction_list_history  WHERE " & strSQLOption & " ORDER BY yabe_auction_list_history.auction_end DESC"
                    End If


                    If cmbPlattform_bestellungen.Text.Contains("Alle") Then
                        lblBestellungen_main.Text = "Alle Bestellungen"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Delcampe") Then
                        lblBestellungen_main.Text = "Delcampe Bestellungen"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("eBay") Then
                        lblBestellungen_main.Text = "eBay Bestellungen"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopsysteme") Then
                        lblBestellungen_main.Text = "Shop Bestellungen"
                    End If


                    '#########################
                    '# >> Suchen 
                    '#########################
                    If bSuchen = True Then
                        If IsNumeric(txtSuchen.Text) = True Then

                            strQuery = "SELECT yabe_auction_list_history.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_history LEFT JOIN yabe_personals_adress  ON yabe_auction_list_history.personal_id = yabe_personals_adress.id JOIN yabe_personals_profile ON  yabe_personals_profile.id = yabe_personals_adress.profil_id WHERE yabe_auction_list_history.eBay_ID like '%" & txtSuchen.Text & "%' OR yabe_auction_list_history.auction_title LIKE '%" & txtSuchen.Text & "%' ORDER BY yabe_auction_list_history.email DESC, yabe_auction_list_history.auction_title ASC"

                        Else
                            '# Name 
                            '# eMail
                            '# Adresse
                            '# Artikelbeschreibung
                            '# eBay Name 
                            strQuery = "SELECT yabe_auction_list_history.*,yabe_personals_adress.*,yabe_personals_profile.* FROM yabe_auction_list_history LEFT JOIN yabe_personals_adress  ON yabe_personals_adress.ID = yabe_auction_list_history.personal_id JOIN yabe_personals_profile ON  yabe_personals_profile.id = yabe_personals_adress.profil_id WHERE yabe_personals_adress.name like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.ebay_account like '%" & txtSuchen.Text & "%'  OR yabe_personals_adress.email like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.city like '%" & txtSuchen.Text & "%' OR yabe_auction_list_history.eBay_account LIKE '%" & txtSuchen.Text & "%' OR yabe_personals_adress.country LIKE '%" & txtSuchen.Text & "%' OR yabe_auction_list_history.auction_title LIKE '%" & txtSuchen.Text & "%' ORDER BY  yabe_auction_list_history.auction_end DESC, yabe_personals_adress.name ASC "
                        End If  'numeric 
                    Else

                    End If


                    Application.DoEvents()
                    clsDatenbank_modul.dblGesamtsumme = 0
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)
                    Call setStatusMessage(lvw)
                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "BESTELLUNGEN")

                'Dim zz As Integer = 0
                'For zz = 0 To lvw.Items.Count
                '    lvwBestellungen_bestelliste.Items.Add(lvw.Items(zz).Clone)
                'Next



                '#########################
                '# >> eBay Bewertungen 
                '#########################
                Case "lvwBewertungen"

                    btnRefreshBewertungen.Enabled = False
                    chkStartupRückbewertung.Enabled = False
                    chkBewertung_janein.Enabled = False
                    txtBewertungen.Enabled = False
                    chkBewertungZeitfilter.Enabled = False
                    dtp_BewertungBis.Enabled = False
                    dtp_BewertungVon.Enabled = False


                    strTableName = "yabe_auction_feedback"
                    If strSQLOption.Length = 0 Then
                        strQuery = "SELECT * FROM yabe_auction_feedback JOIN yabe_auction_list_history ON yabe_auction_list_history.eBay_ID = yabe_auction_feedback.eBay_ID ORDER BY feedback_time DESC"
                    Else
                        strQuery = "SELECT * FROM yabe_auction_feedback JOIN yabe_auction_list_history ON yabe_auction_list_history.eBay_ID = yabe_auction_feedback.eBay_ID  WHERE" & strSQLOption & " ORDER BY feedback_time DESC"
                    End If

                    '#########################
                    '# >> Suchen 
                    '#########################
                    If bSuchen = True Then
                        If IsNumeric(txtSuchen.Text) = True Then

                            strQuery = "SELECT * FROM yabe_auction_feedback JOIN yabe_auction_list_history ON yabe_auction_list_history.eBay_ID = yabe_auction_feedback.eBay_ID WHERE yabe_auction_feedback.eBay_ID like '%" & txtSuchen.Text & "%' ORDER BY feedback_time DESC"

                        Else
                            strQuery = "SELECT * FROM yabe_auction_feedback JOIN yabe_auction_list_history ON yabe_auction_list_history.eBay_ID = yabe_auction_feedback.eBay_ID  WHERE comment like '%" & txtSuchen.Text & "%' OR yabe_auction_list_history.ebay_account like '%" & txtSuchen.Text & "%' OR email LIKE '%" & txtSuchen.Text & "%' ORDER BY feedback_time DESC"
                        End If
                    End If

                    Application.DoEvents()
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)
                    Call setStatusMessage(lvw)

                    btnRefreshBewertungen.Enabled = True
                    chkStartupRückbewertung.Enabled = True
                    chkBewertung_janein.Enabled = True
                    txtBewertungen.Enabled = True
                    chkBewertungZeitfilter.Enabled = True
                    dtp_BewertungBis.Enabled = True
                    dtp_BewertungVon.Enabled = True
                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "BEWERTUNGEN")

                '#########################
                '# >> YABE Kunden  
                '#########################
                Case "lvwBestellungen_kunden"

                    strTableName = "yabe_order_list"

                    If cmbPlattform_bestellungen.Text.Contains("Alle") Then
                        lblKunden_Main_label.Text = "Alle Kunden"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Delcampe") Then
                        lblKunden_Main_label.Text = "Kunden Delcampe"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("eBay") Then
                        lblKunden_Main_label.Text = "Kunden eBay"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopsysteme") Then
                        lblKunden_Main_label.Text = "Kunden Eiso Shop"
                    ElseIf cmbPlattform_bestellungen.Text.Contains("Shopste") Then
                        lblKunden_Main_label.Text = "Kunden Shopste"
                    End If

                    chkKundenFullReport.Enabled = False
                    KundenVon.Enabled = False
                    KundenBis.Enabled = False
                    chkKundenZeitfilter.Enabled = False
                    btnAdressLabels.Enabled = False

                    If strSQLOption.Length = 0 Then
                        strQuery = "SELECT *,yabe_order_list.created_at as order_created_at,yabe_personals_profile.eBay_account as profil_mitglied  FROM " & strTableName & " LEFT JOIN yabe_personals_profile ON  yabe_personals_profile.ID = yabe_order_list.yabe_personals_id LEFT JOIN yabe_personals_adress ON yabe_personals_profile.ID = yabe_personals_adress.profil_id ORDER BY yabe_order_list.created_at DESC"
                    Else
                        strQuery = "SELECT *,yabe_order_list.created_at as order_created_at,yabe_personals_profile.eBay_account as profil_mitglied  FROM " & strTableName & " LEFT JOIN yabe_personals_profile ON  yabe_personals_profile.ID = yabe_order_list.yabe_personals_id LEFT JOIN yabe_personals_adress ON yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE " & strSQLOption & " ORDER BY yabe_order_list.created_at DESC"
                    End If
                    'strQuery = "SELECT * FROM " & strTableName & "  WHERE " & strSQLOption


                    '#########################
                    '# >> Suchen 
                    '#########################
                    If bSuchen = True Then
                        If IsNumeric(txtSuchen.Text) = True Then

                            strQuery = "SELECT * FROM " & strTableName & ",yabe_order_list.created_at as order_created_at,yabe_personals_profile.eBay_account as profil_mitglied LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_personals_adress.ID like '%" & txtSuchen.Text & "%' ORDER BY yabe_personals_adress.adress_lastupdate DESC"

                        Else
                            strQuery = "SELECT * FROM " & strTableName & ",yabe_order_list.created_at as order_created_at,yabe_personals_profile.eBay_account as profil_mitglied LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_personals_adress.name like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.ebay_account like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.city like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.country LIKE '%" & txtSuchen.Text & "%' OR yabe_personals_adress.email like '%" & txtSuchen.Text & "%' ORDER BY yabe_order_list.created_at DESC"
                        End If
                    End If

                    If chkShopLastLogin.Checked = True Then
                        strQuery = "SELECT * FROM " & strTableName & ",yabe_order_list.created_at as order_created_at,yabe_personals_profile.eBay_account as profil_mitglied LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id ORDER BY yabe_personals_profile.webseite_lastlogin DESC LIMIT 0,100"
                    End If

                    Application.DoEvents()
                    clsDatenbank_modul.dblGesamtsumme = 0
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)
                    Call setStatusMessage(lvw)


                    chkKundenFullReport.Enabled = True
                    KundenVon.Enabled = True
                    KundenBis.Enabled = True
                    chkKundenZeitfilter.Enabled = True
                    btnAdressLabels.Enabled = True

                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "KUNDEN-LISTVIEW")

                '#########################
                '# >> YABE Kunden  
                '#########################
                Case "lvwKunden"

                    strTableName = "yabe_personals_profile"

                    If cmbPlattform_kunden.Text.Contains("Alle") Then
                        lblKunden_Main_label.Text = "Alle Kunden"
                    ElseIf cmbPlattform_kunden.Text.Contains("Delcampe") Then
                        lblKunden_Main_label.Text = "Kunden Delcampe"
                    ElseIf cmbPlattform_kunden.Text.Contains("eBay") Then
                        lblKunden_Main_label.Text = "Kunden eBay"
                    ElseIf cmbPlattform_kunden.Text.Contains("Shopsysteme") Then
                        lblKunden_Main_label.Text = "Kunden Eiso Shop"
                    ElseIf cmbPlattform_kunden.Text.Contains("Shopste") Then
                        lblKunden_Main_label.Text = "Kunden Shopste"
                    End If

                    chkKundenFullReport.Enabled = False
                    KundenVon.Enabled = False
                    KundenBis.Enabled = False
                    chkKundenZeitfilter.Enabled = False
                    btnAdressLabels.Enabled = False

                    If strSQLOption.Length = 0 Then
                        strQuery = "SELECT *,yabe_order_list.created_at as created_order FROM " & strTableName & " LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id" & " LEFT JOIN yabe_order_list  ON yabe_personals_profile.ID = yabe_order_list.yabe_personals_id ORDER BY  yabe_order_list.created_at DESC"
                    Else
                        strQuery = "SELECT *,yabe_order_list.created_at as created_order FROM " & strTableName & " LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id" & "  LEFT JOIN yabe_order_list  ON yabe_personals_profile.ID = yabe_order_list.yabe_personals_id WHERE " & strSQLOption & " ORDER BY   yabe_order_list.created_at  DESC"
                    End If
                    'strQuery = "SELECT * FROM " & strTableName & "  WHERE " & strSQLOption


                    '#########################
                    '# >> Suchen 
                    '#########################
                    If bSuchen = True Then
                        If IsNumeric(txtSuchen.Text) = True Then

                            strQuery = "SELECT * FROM " & strTableName & " LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_personals_adress.ID like '%" & txtSuchen.Text & "%' ORDER BY yabe_personals_adress.adress_lastupdate DESC"

                        Else
                            strQuery = "SELECT * FROM " & strTableName & " LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_personals_adress.name like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.ebay_account like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.city like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.country LIKE '%" & txtSuchen.Text & "%' OR yabe_personals_adress.email like '%" & txtSuchen.Text & "%' ORDER BY yabe_personals_adress.adress_lastupdate DESC"
                        End If
                    End If

                    If chkShopLastLogin.Checked = True Then
                        strQuery = "SELECT * FROM " & strTableName & " LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id ORDER BY yabe_personals_profile.webseite_lastlogin DESC LIMIT 0,100"
                    End If

                    Application.DoEvents()
                    clsDatenbank_modul.dblGesamtsumme = 0
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)
                    Call setStatusMessage(lvw)


                    chkKundenFullReport.Enabled = True
                    KundenVon.Enabled = True
                    KundenBis.Enabled = True
                    chkKundenZeitfilter.Enabled = True
                    btnAdressLabels.Enabled = True

                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "KUNDEN")
                '###########################
                '# >> Email Status
                '###########################
                Case "lvMailStatus"

                    strTableName = "yabe_personals_profile"

                    chkNewsletterAlle.Enabled = False
                    chkNewsletterIsWebuser.Enabled = False
                    chkVerschickt.Enabled = False
                    chkNurKlickt.Enabled = False
                    btnAbschickenNewsletter.Enabled = False
                    btnMailVersandStart.Enabled = False
                    btnEdit.Enabled = False
                    cmbTranslationBereichAuswählen.Enabled = False
                    btnNewsletterReset.Enabled = False

                    If strSQLOption.Length = 0 Then
                        'strQuery = "SELECT * FROM " & strTableName
                        strQuery = "SELECT * FROM yabe_personals_profile LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id ORDER BY letzter_email_klick DESC"
                    Else
                        If My.Settings.chkNewsletterLIMIT = True Then
                            strQuery = "SELECT * FROM yabe_personals_profile LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE " & strSQLOption & " ORDER BY letzter_email_klick DESC LIMIT 0,1000"
                        Else
                            strQuery = "SELECT * FROM yabe_personals_profile LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE " & strSQLOption & " ORDER BY letzter_email_klick DESC"
                        End If

                    End If

                    If bSuchen = True Then
                        If IsNumeric(txtSuchen.Text) = True Then

                            strQuery = "SELECT * FROM " & strTableName & " LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_personals_adress.ID like '%" & txtSuchen.Text & "%' ORDER BY letzter_email_klick DESC"

                        Else
                            strQuery = "SELECT * FROM " & strTableName & " LEFT JOIN yabe_personals_adress ON  yabe_personals_profile.ID = yabe_personals_adress.profil_id WHERE yabe_personals_adress.name like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.ebay_account like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.city like '%" & txtSuchen.Text & "%' OR yabe_personals_adress.email like '%" & txtSuchen.Text & "%' ORDER BY letzter_email_klick DESC"
                        End If
                    End If

                    Application.DoEvents()
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)
                    ' MsgBox(frmMain.master_Message_label.Text)

                    Call setStatusMessage(lvw)

                    chkNewsletterAlle.Enabled = True
                    chkNewsletterIsWebuser.Enabled = True
                    chkVerschickt.Enabled = True
                    chkNurKlickt.Enabled = True
                    btnAbschickenNewsletter.Enabled = True
                    btnMailVersandStart.Enabled = True
                    btnEdit.Enabled = True
                    cmbTranslationBereichAuswählen.Enabled = True
                    btnNewsletterReset.Enabled = True
                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "NEWSLETTER")

                '##########################################################
                '# >> Artikelverwaltung 
                '##########################################################
                Case "lvwWebArtikel"
                    If bSuchen = True Then

                        strQuery = "SELECT * FROM tblGes WHERE ID LIKE '%" & txtSuchen.Text & "%' OR  Beschreibung LIKE '%" & txtSuchen.Text & "%' OR  Bild LIKE '%" & txtSuchen.Text & "%' OR Beschreibung_eng LIKE '%" & txtSuchen.Text & "%' OR Beschreibung_fr LIKE '%" & txtSuchen.Text & "%' OR Beschreibung_sp LIKE '%" & txtSuchen.Text & "%'"

                    End If

                    Application.DoEvents()
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)
                    Call setStatusMessage(lvw)
                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "ARTIKELDATENBANK")
                Case "lvwStatisticText"

                    '# Herkunftsländer
                    If optStatHerkunftsland.Checked = True Then
                        strQuery = "SELECT count(*) as anzahl,country as name FROM yabe_personals_adress group by country ORDER BY anzahl DESC"
                        '# Umsatz 
                    ElseIf optStatUmsatz.Checked = True Then

                        strQuery = "SELECT sum(current_price)as anzahl,month(auction_end) as name, YEAR(auction_end) as jahr FROM yabe_auction_list_history WHERE email != '---' AND email != ''  group by YEAR(auction_end), MONTH(auction_end)"

                        '# Topkundenliste
                    ElseIf optTopKundenListe.Checked = True Then
                        strQuery = "SELECT *,sum(current_price) as summe FROM yabe_auction_list_history JOIN yabe_personals_adress ON yabe_personals_adress.email = yabe_auction_list_history.email  WHERE yabe_auction_list_history.email != '' AND yabe_auction_list_history.email !='---' group by yabe_auction_list_history.email order by summe DESC "

                        '# Meiste Gebote 
                    ElseIf optMeistegebote.Checked = True Then
                        strQuery = "SELECT * FROM yabe_auction_list_history WHERE email !='' AND email !='---' ORDER BY bids DESC LIMIT 0,100"

                        '# Teuerster Artikel 
                    ElseIf optTeuersterArtikel.Checked = True Then
                        strQuery = "SELECT * FROM yabe_auction_list_history WHERE email !='' AND email !='---' ORDER BY current_price DESC LIMIT 0,100"

                        '# Häufige Städte 
                    ElseIf optMeisteStaedte.Checked = True Then
                        strQuery = "SELECT city,count(*) as anzahl FROM yabe_personals_adress group by city ORDER BY anzahl DESC LIMIT 0,50"
                    End If

                    Application.DoEvents()
                    '# SQL Query übergeben -> Daten abrufen und anzeigen 
                    Call clsDatenbank_modul.getListviewData(lvw, strQuery, bilder_history)

                    Application.DoEvents()
                    '# Listview aktuallisieren 
                    Call setStatusMessage(lvw)

                    setBludauMediaLogbuch(">> READ >>" & frmMain.master_Message_label.Text, "STATISTIK")

            End Select

            '#########################################
            '# >> Sperren der Oberlfäche
            '#########################################
            Call setLookForm(lvw, True)
            Return True

        Catch ex As Exception
            debug_message(ex, "getDataLvw" & strQuery)
            Call setLookForm(lvw, True)
            Return False
        End Try
    End Function

    '######################################################################
    '# >> InfoLeiste von Yabe steuern 
    '######################################################################
    Private Function setAddToInfoBar(ByVal strDaten As String, Optional ByVal bClean As Boolean = False) As Boolean
        Try

            If bClean = True Then
                frmMain.master_Message_label.Text = ""
            End If

            frmMain.master_Message_label.Text &= strDaten
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '###################################################################
    '# >> Statusmeldung ausgeben
    '###################################################################
    Function setStatusMessage(ByVal lvw As ListView, Optional ByVal bPart As Boolean = False) As String
        Dim i As Integer
        Dim dblGesPreis As Double
        Dim dblGebote As Double
        Dim dblMitGebotPreis As Double
        Dim strMitGebotePreis As String = ""
        Dim strEinstellsumme As String = ""
        Dim iVerkäufe As Integer = 0
        Dim iCount As Integer = 1
        Dim iCount_kauefer_ary As Integer = 0
        Dim bIn As Boolean = False
        Dim strTrenn As String = My.Settings.yabe_trennzeichen
        Try
            '# JB
            lvw.BeginUpdate()

            Select Case lvw.Name
                Case ""
                    '######################################################################
                    '# >> YABE -> Statistik
                    '######################################################################
                Case "lvwStatisticText"

                    If frmMain.frmManage.optTopKundenListe.Checked = True Then
                        frmMain.master_Message_label.Text = strTrenn & " Top-Kunden: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True)
                    ElseIf frmMain.frmManage.optStatHerkunftsland.Checked = True Then
                        frmMain.master_Message_label.Text = strTrenn & " Herkunfsländer: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True)
                    End If

                    cache_statusbar.statistik = frmMain.master_Message_label.Text

                '######################################################################
                '# >> YABE -> Newsletter 
                '######################################################################
                Case "lvMailStatus"

                    Dim dbKlicks As Integer = 0
                    For i = 0 To lvw.Items.Count - 1
                        If IsNumeric(lvw.Items(i).SubItems(8).Text) = True Then
                            dbKlicks += lvw.Items(i).SubItems(8).Text
                        End If
                    Next

                    Dim iProPerson As Double
                    iProPerson = dbKlicks / lvw.Items.Count

                    frmMain.master_Message_label.Text = strTrenn & " Newsletterteilnehmer: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True) & " mit " & FormatNumber(dbKlicks, 0, , , Microsoft.VisualBasic.TriState.True) & strTrenn & "Pro Kunde: " & Math.Round(iProPerson, 3)

                    cache_statusbar.newsletter = frmMain.master_Message_label.Text
                '######################################################################
                '# >> YABE -> Kunden
                '######################################################################

                Case "lvwBestellungen_kunden"
                    Dim iDeutsch As Integer = 0
                    Dim iNewsletter As Integer = 0
                    Dim iAndere As Integer = 0
                    Dim iEnglisch As Integer = 0
                    Dim iFranzösisch As Integer = 0
                    Dim iSpanisch As Integer = 0
                    Dim dblEndsumme As Double = 0
                    Dim dblVersandkosten As Double = 0

                    '# Spalten ausbleden -> Kein Full-Report
                    If Not chkKundenFullReport.Checked = True Then
                        'lvw.Columns(7).Width = 0
                        'lvw.Columns(8).Width = 0
                    End If


                    For i = 0 To lvw.Items.Count - 1


                        dblEndsumme += Convert.ToDouble(lvw.Items(i).SubItems(18).Text)
                        dblVersandkosten += Convert.ToDouble(lvw.Items(i).SubItems(19).Text)

                        Application.DoEvents()
                        '  If lvw.Items(i).SubItems(12).Text.Length > 0 Then
                        Select Case lvw.Items(i).SubItems(13).Text
                            Case "Deutsch"
                                iDeutsch += 1
                            Case "Englisch"
                                iEnglisch += 1
                            Case "Spanisch"
                                iSpanisch += 1
                            Case "Französisch"
                                iFranzösisch += 1
                            Case Else
                                iAndere += 1
                        End Select
                        '  End If

                        Select Case lvw.Items(i).SubItems(17).Text
                            Case "verschickt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_verschickt
                            Case "storniert"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_storniert
                            Case "bezahlt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bezahlt
                            Case "komplett"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_komplett
                            Case "nicht gesetzt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bestellt
                        End Select

                        ' Einfärben Newsletter Anmeldung
                        If lvw.Items(i).SubItems(9).Text = "Y" Then

                            iNewsletter += 1
                            bIn = True
                        Else
                            bIn = False
                        End If


                        '# Einfärben der Restlichen Einträge
                        If iCount = 1 Then
                            If bIn = False Then
                                '  lvw.Items(i).BackColor = Color.WhiteSmoke
                                iCount = 0
                            End If
                        Else
                            If bIn = False Then
                                ' lvw.Items(i).BackColor = My.Settings.gui_live_color
                                iCount = 1
                            End If
                        End If
                    Next i

                    '# Spalten Ausblenden
                    'lvw.Columns(9).Width = 0
                    'lvw.Columns(2).Width = 0

                    Dim dblNewsletter As Double = iNewsletter / lvw.Items.Count * 100
                    dblNewsletter = Math.Round(dblNewsletter, 2)


                    Dim dblProzentDE As Double = (iDeutsch / Convert.ToInt16(lvw.Items.Count)) * 100
                    Dim dblProzentEN As Double = (iEnglisch / Convert.ToInt16(lvw.Items.Count)) * 100
                    Dim dblProzentFR As Double = (iFranzösisch / Convert.ToInt16(lvw.Items.Count)) * 100
                    Dim dblProzentSP As Double = (iFranzösisch / Convert.ToInt16(lvw.Items.Count)) * 100
                    Dim dblProzentAndere As Double = (iAndere / Convert.ToInt16(lvw.Items.Count)) * 100


                    Call setAddToInfoBar(strTrenn & " Kunden: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True) & strTrenn & " Bestellsumme: " & FormatNumber(dblEndsumme, 0, , , Microsoft.VisualBasic.TriState.True) & " € (" & Math.Round(dblEndsumme / lvw.Items.Count, 2) & "€ pro Kauf) " & strTrenn & " Versandkosten: " & FormatNumber(dblVersandkosten, 0, , , Microsoft.VisualBasic.TriState.True) & " € (pro Verkauf " & Math.Round(dblVersandkosten / lvw.Items.Count, 2) & " €)" & strTrenn & " Newsletter: ", True)
                    Call setAddToInfoBar(iNewsletter & " (" & dblNewsletter & "%)")
                    Call setAddToInfoBar(strTrenn & " Deutsch: " & iDeutsch & " (" & Math.Round(dblProzentDE, 2) & "%) " & strTrenn & " Englisch: " & iEnglisch & " (" & Math.Round(dblProzentEN, 2) & "%) " & strTrenn & strTrenn & " Französisch: " & iFranzösisch & " (" & Math.Round(dblProzentFR, 2) & "%) " & strTrenn & strTrenn & " Spanisch: " & iSpanisch & " (" & Math.Round(dblProzentSP, 2) & "%) " & strTrenn & strTrenn & " Andere: " & iAndere & " (" & Math.Round(dblProzentAndere, 2) & "%)" & strTrenn)

                    cache_statusbar.kunden = frmMain.master_Message_label.Text

                    Call getRadioOptions_counts(lvw.Name)

                Case "lvwKunden"
                    Dim iDeutsch As Integer = 0
                    Dim iNewsletter As Integer = 0
                    Dim iAndere As Integer = 0
                    Dim iEnglisch As Integer = 0
                    Dim iFranzösisch As Integer = 0
                    Dim iSpanisch As Integer = 0


                    '# Spalten ausbleden -> Kein Full-Report
                    If Not chkKundenFullReport.Checked = True Then
                        'lvw.Columns(7).Width = 0
                        'lvw.Columns(8).Width = 0
                    End If


                    For i = 0 To lvw.Items.Count - 1

                        Application.DoEvents()
                        '  If lvw.Items(i).SubItems(12).Text.Length > 0 Then
                        Select Case lvw.Items(i).SubItems(13).Text
                            Case "Deutsch"
                                iDeutsch += 1
                            Case "Englisch"
                                iEnglisch += 1
                            Case "Spanisch"
                                iSpanisch += 1
                            Case "Französisch"
                                iFranzösisch += 1
                            Case Else
                                iAndere += 1
                        End Select
                        '  End If

                        ' Einfärben Newsletter Anmeldung
                        If lvw.Items(i).SubItems(9).Text = "Y" Then
                            lvw.Items(i).BackColor = My.Settings.gui_live_topbuyer
                            iNewsletter += 1
                            bIn = True
                        Else
                            bIn = False
                        End If


                        '# Einfärben der Restlichen Einträge
                        If iCount = 1 Then
                            If bIn = False Then
                                lvw.Items(i).BackColor = Color.WhiteSmoke
                                iCount = 0
                            End If
                        Else
                            If bIn = False Then
                                lvw.Items(i).BackColor = My.Settings.gui_live_color
                                iCount = 1
                            End If
                        End If
                    Next i

                    '# Spalten Ausblenden
                    'lvw.Columns(9).Width = 0
                    'lvw.Columns(2).Width = 0

                    Dim dblNewsletter As Double = iNewsletter / lvw.Items.Count * 100
                    dblNewsletter = Math.Round(dblNewsletter, 2)

                    Dim dblProzentDE As Double = Math.Round((iDeutsch / Convert.ToInt16(lvw.Items.Count)) * 100, 2)
                    Dim dblProzentEN As Double = Math.Round((iEnglisch / Convert.ToInt16(lvw.Items.Count)) * 100, 2)
                    Dim dblProzentFR As Double = Math.Round((iFranzösisch / Convert.ToInt16(lvw.Items.Count)) * 100, 2)
                    Dim dblProzentSP As Double = Math.Round((iFranzösisch / Convert.ToInt16(lvw.Items.Count)) * 100, 2)
                    Dim dblProzentAndere As Double = Math.Round((iAndere / Convert.ToInt16(lvw.Items.Count)) * 100, 2)


                    Call setAddToInfoBar(strTrenn & " Kunden: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True) & " " & strTrenn & " Newsletter: ", True)
                    Call setAddToInfoBar(iNewsletter & " (" & Math.Round(dblNewsletter, 2) & "%)")
                    Call setAddToInfoBar(strTrenn & " Deutsch: " & iDeutsch & " - " & dblProzentDE & "%" & strTrenn & " Englisch: " & iEnglisch & " - " &
                  dblProzentEN & "%" & strTrenn & strTrenn & " Französisch: " & iFranzösisch & " - " & dblProzentFR & "%" & strTrenn & strTrenn & " Spanisch: " & iSpanisch & " - " & dblProzentSP & "%" & strTrenn & strTrenn & " Andere: " & iAndere & " - " & dblProzentAndere & "%" & strTrenn)

                    cache_statusbar.kunden = frmMain.master_Message_label.Text

                    Call getRadioOptions_counts(lvw.Name)

                '######################################################################
                '# >> YABE -> Bewerungen
                '######################################################################
                Case "lvwBewertungen"

                    For i = 0 To lvw.Items.Count - 1
                        '# Auf Bestellstatus reagieren
                        Select Case lvw.Items(i).SubItems(13).Text
                            Case "Bezahlt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bezahlt
                            Case "Bestellt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bestellt
                            Case "Verschickt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_verschickt
                            Case "Komplett"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_komplett
                            Case "Storniert"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_storniert
                        End Select

                    Next

                    frmMain.master_Message_label.Text = My.Settings.yabe_trennzeichen & "Bewertungen: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True) & " gefunden"
                    cache_statusbar.bewertungen = frmMain.master_Message_label.Text
                '######################################################################
                '# >> YABE -> Bestellungen 
                '######################################################################
                Case "lvwBestellverwaltung_nach_artikel", "lvwBestellungen_bestelliste_neu"

                    Dim dblKosten As Double = 0
                    Dim dblVersand As Double = 0

                    Dim bMuttersprache As Boolean = False
                    Dim kauefer() As String

                    Dim bKauefer_neu As Boolean = False
                    Dim iKauefer As Integer = 0
                    ReDim kauefer(lvw.Items.Count)

                    For i = 0 To lvw.Items.Count - 1
                        dblGesPreis += Convert.ToDouble(lvw.Items(i).SubItems(5).Text.Replace(".", ","))

                        'Application.DoEvents()

                        '# Verkaufte Artikel
                        If Convert.ToInt16(lvw.Items(i).SubItems(11).Text) > 0 And Not lvw.Items(i).SubItems(7).Text = "Storniert" Then
                            dblGebote += lvw.Items(i).SubItems(11).Text
                            iVerkäufe += 1
                            dblMitGebotPreis += lvw.Items(i).SubItems(5).Text.Replace(".", ",")
                            '                           If i = 2039 Then
                            '                                Stop
                            'End If

                            If Not lvw.Items(i).SubItems(19).Text = "" Then
                                bMuttersprache = True
                            End If


                            iCount += 1
                            If lvw.Items(i).SubItems(15).Text.Length > 0 Then
                                lvw.Items(i).BackColor = My.Settings.gui_live_topbuyer
                            End If


                            '# Auf Bestellstatus reagieren
                            Select Case lvw.Items(i).SubItems(7).Text.ToLower
                                Case "bezahlt"
                                    lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bezahlt
                                Case "bestellt"
                                    lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bestellt
                                Case "verschickt"
                                    lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_verschickt
                                Case "komplett"
                                    lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_komplett
                                Case "storniert"
                                    lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_storniert
                            End Select


                            If IsNumeric(lvw.Items(i).SubItems(6).Text) = True Then
                                dblVersand += lvw.Items(i).SubItems(6).Text.Replace(".", ",")
                            End If

                            bKauefer_neu = False

                            For iKauefer = 0 To kauefer.Length - 1
                                If kauefer(iKauefer) = lvw.Items(i).SubItems(2).Text Then
                                    bKauefer_neu = True
                                    Exit For
                                End If

                            Next
                            If bKauefer_neu = False Then
                                kauefer(iCount_kauefer_ary) = lvw.Items(i).SubItems(2).Text
                                iCount_kauefer_ary += 1
                            End If



                            If IsNumeric(lvw.Items(i).SubItems(12).Text) = True Then
                                dblKosten += lvw.Items(i).SubItems(12).Text.Replace(".", ",")
                            End If
                        Else
                            If lvw.Items(i).SubItems(7).Text = "Storniert" Then
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_storniert
                            End If
                        End If

                    Next


                    If lvw.Columns(4).Width > 150 Then
                        lvw.Columns(4).Width = 170
                    End If


                    If bMuttersprache = False Then
                        lvw.Columns(19).Width = 0
                    End If

                    'lvw.Columns(3).Width = 0 ' Ort
                    'lvw.Columns(9).Width = 0 ' email 
                    'lvw.Columns(8).Width = 0 ' bewertet 
                    lvw.Columns(14).Width = 60 ' bild 
                    'lvw.Columns(20).Width = 0 ' Straße 
                    'lvw.Columns(21).Width = 0 ' Sprachliste

                    '# Keine Gebote 
                    If chkLiveAlle.Checked = False Then
                        'lvw.Columns(2).Width = 0 ' Gebühr
                        lvw.Columns(1).Width = 60
                        'lvw.Columns(6).Width = 0
                        'lvw.Columns(16).Width = 0
                        lvw.Columns(15).Width = 60
                        'lvw.Columns(12).Width = 0
                        'lvw.Columns(11).Width = 0
                        'lvw.Columns(17).Width = 0

                    End If


                    Call getRadioOptions_counts(lvw.Name)

                    lvw.Columns(15).Width = 100 ' YABE ID 
                    lvw.Columns(18).Width = 60 ' Delcampe User ID 

                    chkBestellungen_bezahlt.Enabled = chkBestellungen_verkauft.Checked
                    chkBestellungen_Versand.Enabled = chkBestellungen_verkauft.Checked
                    chkBestellungen_KeineBewertung.Enabled = chkBestellungen_verkauft.Checked
                    chkBestellungen_Storniert.Enabled = chkBestellungen_verkauft.Checked

                    '  kauefer = DestinctArray(Of String)(kauefer)


                    Dim dblBesucher_abs As Double = 0
                    Dim dblBeobachter_abs As Double = 0
                    Dim dblGebote_abs As Double = 0
                    Dim dblEinstellsumme_abs As Double = 0
                    Dim dblVerkaufssumme_abs As Double = 0
                    Dim dblkäufer_abs As Double = 0

                    iCount_kauefer_ary += 1 ' weil bei 0 start
                    '# Werte errechnen 
                    dblGebote_abs = Math.Round(dblGebote / iVerkäufe, 2)

                    dblEinstellsumme_abs = Math.Round(dblGesPreis / lvw.Items.Count, 2)
                    dblVerkaufssumme_abs = Math.Round(dblMitGebotPreis / iVerkäufe, 2)
                    dblkäufer_abs = Math.Round(dblMitGebotPreis / iCount_kauefer_ary, 2)


                    strMitGebotePreis = strTrenn & " Umsatz: " & FormatNumber(dblMitGebotPreis, 2, , , Microsoft.VisualBasic.TriState.True) & " €  (" & dblVerkaufssumme_abs & " € pro Artikel) " & strTrenn & " Gebote: " & FormatNumber(dblGebote, 0, , , Microsoft.VisualBasic.TriState.True) & " (" & dblGebote_abs & ") " & strTrenn & " Verkäufe: " & iVerkäufe & strTrenn & " Käufer: " & iCount_kauefer_ary - 1 & " (" & dblkäufer_abs & " € pro Kauf)"

                    If dblMitGebotPreis = dblGesPreis Then
                        strEinstellsumme = ""
                    Else
                        strEinstellsumme = strTrenn & " Einstellsumme: " & FormatNumber(dblGesPreis, 2, , , Microsoft.VisualBasic.TriState.True) & " €"
                    End If

                    Call setAddToInfoBar(strTrenn & " Artikel: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True) & strEinstellsumme & " " & strMitGebotePreis & strTrenn & " Gebühren: " & FormatNumber(dblKosten, 2, , , Microsoft.VisualBasic.TriState.True) & " € " & strTrenn & " Versandkosten: " & dblVersand & " €", True)


                    cache_statusbar.bestellungen = frmMain.master_Message_label.Text

                    '#############################################################
                    '# >> Gruppierte Ansicht 
                    '#############################################################
                    If GruppiertNameToolStripMenuItem.Checked = True Then
                        Call setLVWGroups(lvw, 2) ' Mitgliedsname 
                    ElseIf GroupiertVerkaufsendeToolStripMenuItem.Checked = True Then
                        Call setLVWGroups(lvw, 10) ' Verkaufsdatum
                    ElseIf GruppiertLandToolStripMenuItem.Checked = True Then
                        Call setLVWGroups(lvw, 17) ' Nach Land
                    ElseIf GruppiertMutterspracheToolStripMenuItem.Checked = True Then
                        Call setLVWGroups(lvw, 19) ' Nach Sprachen 
                    ElseIf GruppiertBestellstatusToolStripMenuItem.Checked = True Then
                        Call setLVWGroups(lvw, 7) ' Nach Preis (5) => BEstellstatus
                    End If


                '######################################################################
                '# >> YABE -> Webartikel 
                '######################################################################
                Case "lvwWebArtikel"


                    Dim iBesucher As Integer = 0

                    For i = 0 To lvw.Items.Count - 1
                        dblGesPreis += Convert.ToDouble(lvw.Items(i).SubItems(2).Text.Replace(".", ","))
                        iBesucher += Convert.ToDouble(lvw.Items(i).SubItems(7).Text.Replace(".", ","))

                        ' Application.DoEvents()
                        '# Einfärben der Restlichen Einträge
                        If iCount = 1 Then
                            If bIn = False Then
                                lvw.Items(i).BackColor = Color.WhiteSmoke
                                iCount = 0
                            End If
                        Else
                            If bIn = False Then
                                lvw.Items(i).BackColor = My.Settings.gui_live_color
                                iCount = 1
                            End If
                        End If

                        Select Case lvw.Items(i).SubItems(8).Text
                            Case "Warteliste"
                                lvw.Items(i).BackColor = My.Settings.gui_color_artikel_warteliste
                            Case "Bestellt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_artikel_vorbestellt
                        End Select

                    Next

                    strMitGebotePreis = strTrenn & " Warenwert: " & FormatNumber(dblGesPreis, 2, , , Microsoft.VisualBasic.TriState.True) & " € " & strTrenn & " Artikel: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True) & strTrenn & " Artikel Großansicht: " & FormatNumber(iBesucher, 0, , , Microsoft.VisualBasic.TriState.True)
                    frmMain.master_Message_label.Text = strMitGebotePreis

                    cache_statusbar.artikeldatenbank = frmMain.master_Message_label.Text

                '###############################################
                '# >> YABE Cockpit Listview
                '###############################################
                Case "lvwEiSoCockpit"

                    Dim iBesucher As Integer = 0
                    Dim kauefer() As String
                    Dim bFragen As Boolean = False
                    Dim iBeobachter As Integer = 0
                    ReDim kauefer(lvw.Items.Count)
                    Dim bKauefer_neu As Boolean = False
                    Dim iKauefer As Integer = 0

                    'lvw.BeginUpdate()
                    '# Alle Artikel durchlaufen 
                    For i = 0 To lvw.Items.Count - 1

                        ' DAUERKUNDE: -> Einfärben der Ergebnisse 
                        If My.Settings.gui_live_colormod = True Then

                            Dim str() As String = lvw.Items(i).SubItems(5).Text.Split(" ")

                            If str.Length > 1 Then
                                'Application.DoEvents()
                                If clsDatenbank_modul.chkYABE_Orders(lvw.Items(i).SubItems(6).Text) = True Then
                                    lvw.Items(i).BackColor = My.Settings.gui_live_topbuyer
                                    bIn = True
                                Else
                                    bIn = False
                                End If
                            End If

                        End If

                        kauefer(i) = lvw.Items(i).SubItems(3).Text
                        dblGesPreis += Convert.ToDouble(lvw.Items(i).SubItems(3).Text.Replace(".", ","))
                        iBesucher += Convert.ToInt16(lvw.Items(i).SubItems(15).Text)

                        '# Verkaufte Artikel
                        If Convert.ToInt16(lvw.Items(i).SubItems(4).Text) > 0 Then
                            dblGebote += lvw.Items(i).SubItems(4).Text
                            iVerkäufe += 1
                            dblMitGebotPreis += lvw.Items(i).SubItems(2).Text.Replace(".", ",")
                        End If

                        If IsNumeric(lvw.Items(i).SubItems(10).Text) = True Then
                            iBeobachter += lvw.Items(i).SubItems(10).Text
                        End If

                        If Not lvw.Items(i).SubItems(16).Text = "" And Not lvw.Items(i).SubItems(16).Text = "0" Then
                            bFragen = True
                        End If

                        bKauefer_neu = False

                        For iKauefer = 0 To kauefer.Length - 1
                            If kauefer(iKauefer) = lvw.Items(i).SubItems(5).Text Then
                                bKauefer_neu = True
                                Exit For
                            End If

                        Next
                        If bKauefer_neu = False Then
                            kauefer(iCount_kauefer_ary) = lvw.Items(i).SubItems(5).Text
                            iCount_kauefer_ary += 1
                        End If



                    Next ' end for 

                    'lvw.EndUpdate()



                    '# LVW: Ausblenden 
                    lvw.Columns(0).Width = 0 ' Auktion ID 
                    lvw.Columns(14).Width = 0 ' Hitcounter
                    lvw.Columns(13).Width = 0 ' eBay Bild 

                    '# LVW: Breite setzen 
                    lvw.Columns(2).Width = 70
                    lvw.Columns(3).Width = 70
                    lvw.Columns(4).Width = 55
                    lvw.Columns(7).Width = 62


                    '# Alle nicht bebotenen Artikel
                    If lvw.Columns(5).Width < 15 Then
                        lvw.Columns(5).Width = 0
                        lvw.Columns(6).Width = 0
                        lvw.Columns(18).Width = 0
                        lvw.Columns(12).Width = 0
                        lvw.Columns(2).Width = 0
                        lvw.Columns(5).Width = 0
                        lvw.Columns(6).Width = 0
                        lvw.Columns(4).Width = 0
                        lvw.Columns(18).Width = 0 ' Paypal
                    End If

                    If Not lvw.Columns(20).Width > 12 Then
                        lvw.Columns(20).Width = 0 ' Name
                        lvw.Columns(21).Width = 0 ' Land
                        lvw.Columns(18).Width = 0 ' Paypal
                    End If

                    If bFragen = False Then
                        lvw.Columns(16).Width = 0
                    End If

                    If Not cmbPlattform_Live.Text = "Alle" Then
                        lvw.Columns(17).Width = 0
                    End If

                    lvw.Columns(19).Width = 0
                    '# Array von doppelten löschen

                    kauefer = DestinctArray(Of String)(kauefer)


                    Dim dblBesucher_abs As Double = 0
                    Dim dblBeobachter_abs As Double = 0
                    Dim dblGebote_abs As Double = 0
                    Dim dblEinstellsumme_abs As Double = 0
                    Dim dblVerkaufssumme_abs As Double = 0
                    Dim dblkäufer_abs As Double = 0

                    '# Werte errechnen 
                    dblGebote_abs = Math.Round(dblGebote / iVerkäufe, 2)
                    dblBesucher_abs = Math.Round(iBesucher / lvw.Items.Count, 2)
                    dblBeobachter_abs = Math.Round(iBeobachter / lvw.Items.Count, 2)
                    dblEinstellsumme_abs = Math.Round(dblGesPreis / lvw.Items.Count, 2)
                    dblVerkaufssumme_abs = Math.Round(dblMitGebotPreis / iVerkäufe, 2)
                    dblkäufer_abs = Math.Round(dblMitGebotPreis / iCount_kauefer_ary + 1, 2)

                    iCount_kauefer_ary += 1

                    '# Ausgabe Formatieren ensprechend der Optionen 
                    If dblGebote > 0 Then
                        strMitGebotePreis = strTrenn & " Umsatz: " & FormatNumber(dblMitGebotPreis, 2, , , Microsoft.VisualBasic.TriState.True) & " € (" & dblVerkaufssumme_abs & "€ pro Artikel) " & strTrenn & " Gebote: " & FormatNumber(dblGebote, 0, , , Microsoft.VisualBasic.TriState.True) & " (" & dblGebote_abs & ") " & strTrenn & " Verkäufe: " & iVerkäufe & strTrenn & " Käufer: " & iCount_kauefer_ary - 1 & " (" & dblkäufer_abs & " € pro Kauf)"
                    End If

                    If dblMitGebotPreis = dblGesPreis Then
                        strEinstellsumme = ""
                    Else
                        strEinstellsumme = strTrenn & " Einstellsumme: " & FormatNumber(dblGesPreis, 2, , , Microsoft.VisualBasic.TriState.True) & " € (" & dblEinstellsumme_abs & " € pro Artikel)"
                    End If

                    frmMain.master_Message_label.Text = strTrenn & " Bestellpositionen: " & FormatNumber(lvw.Items.Count, 0, , , Microsoft.VisualBasic.TriState.True) & strTrenn & " Besucher: " & iBesucher & " (" & dblBesucher_abs & ") " & strTrenn & " Beobachter: " & iBeobachter & " (" & dblBeobachter_abs & ") " & strEinstellsumme & " " & strMitGebotePreis

                    cache_statusbar.cockpit = frmMain.master_Message_label.Text

                '######################################################################
                '# >> YABE -> Kundenübersicht -> Bestellverlauf
                '######################################################################
                Case "lvwBestellverlauf"
                    Dim dblKosten As Double = 0
                    Dim dblVersand As Double = 0
                    Dim kauefer() As String

                    ReDim kauefer(lvw.Items.Count)

                    For i = 0 To lvw.Items.Count - 1


                        '# Auf Bestellstatus reagieren
                        Select Case lvw.Items(i).SubItems(4).Text
                            Case "Bezahlt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bezahlt
                            Case "Bestellt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bestellt
                            Case "Verschickt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_verschickt
                            Case "Komplett"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_komplett
                            Case "Storniert"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_storniert
                        End Select

                    Next

                    ' ersten makieren  - farbe ist weg
                    'If lvw.Items.Count > 0 Then
                    '    lvw.Items(0).Selected = True
                    'End If


                    lvw.Columns(9).Width = 0
                    lvw.Columns(10).Width = 0
                    lvw.Columns(0).Width = 0

                Case "lvwArtikelListe"


                    lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

                    For i = 0 To lvw.Items.Count - 1


                        '# Auf Bestellstatus reagieren
                        Select Case lvw.Items(i).SubItems(6).Text
                            Case "Bezahlt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bezahlt
                            Case "Bestellt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_bestellt
                            Case "Verschickt"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_verschickt
                            Case "Komplett"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_komplett
                            Case "Storniert"
                                lvw.Items(i).BackColor = My.Settings.gui_color_bestellungen_storniert
                        End Select

                    Next

            End Select

            lvw.EndUpdate()

            Return "1"
        Catch ex As Exception
            'Call debug_message(ex, strQuery & vbCrLf & "setStatusMessage")
            lvw.EndUpdate()
            Return "-1"
        End Try

    End Function

    Public Function setLVWGroups(ByRef lvw As ListView, ByVal iColum As Byte) As Boolean

        Try
            If isRunningXPOrLater Then
                ' Create the groupsTable array and populate it with one 
                ' hash table for each column.
                groupTables = New Hashtable(lvw.Columns.Count) {}
                Dim column As Integer
                For column = 0 To lvw.Columns.Count - 1
                    ' Create a hash table containing all the groups 
                    ' needed for a single column.
                    Try
                        groupTables(column) = CreateGroupsTable(lvw, column)
                    Catch ex As Exception

                    End Try

                Next column

                ' Start with the groups created for the Title column.
                SetGroups(lvw, iColum)
            End If

            Return True

        Catch ex As Exception

            Return False
        End Try

    End Function

    '#######################################
    '# >> CONTEXT: Höchstbietende
    '#######################################
    Private Sub BietverlaufToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BietverlaufToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim frmVerlauf As New FrmGetAllBidders
            frmVerlauf.lvwDataInput = lvwEiSoCockpit
            frmVerlauf.TxtItemId.Text = lvwEiSoCockpit.SelectedItems(0).Text
            frmVerlauf.ShowDialog()
        End If

    End Sub

    Private Sub setOpenHoechstbieter()
        Dim str() As String

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim frmHöchstbietender As New FrmGetUser

            frmHöchstbietender.TxtItemId.Text = lvwEiSoCockpit.SelectedItems(0).Text
            str = lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text.Split(" ")
            frmHöchstbietender.TxtUserId.Text = str(0)
            frmHöchstbietender.Show()
        End If

    End Sub
    '#######################################
    '# >> CONTEXT: Höchstbietender Info
    '#######################################
    Private Sub HöchstbietenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HöchstbietenderToolStripMenuItem.Click


        Call setOpenHoechstbieter()

    End Sub

    '#######################################
    '# >> LISTVIEW eBayLive: Doppelklick
    '#######################################
    Private Sub lvweBayLiveList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwEiSoCockpit.MouseDoubleClick

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then

            Select Case lvwEiSoCockpit.SelectedItems(0).SubItems(17).Text
                Case "eBay"

                    Select Case lvwEiSoCockpit.SelectedItems(0).SubItems(7).Text
                        Case "Completed"
                            Dim frmVersand As New frmBestellung_Versandkosten
                            frmVersand.mModusSelect = frmBestellung_Versandkosten.mModus.live
                            frmVersand.lvwDataInput = lvwEiSoCockpit
                            frmVersand.Show()
                        Case Else
                            If lvwEiSoCockpit.SelectedItems(0).SubItems(4).Text > 1 Then
                                '# Lädt die Übersicht der Gebote bei mehr als 1 Gebot 
                                Dim frmBidderList As New FrmGetHighBidders
                                frmBidderList.lvwDataInput = lvwEiSoCockpit
                                frmBidderList.TxtItemId.Text = lvwEiSoCockpit.SelectedItems(0).Text
                                frmBidderList.Show()
                            ElseIf lvwEiSoCockpit.SelectedItems(0).SubItems(4).Text = 1 Then

                                '# Einzelansicht des Höchstbietenden (bei nur einem Gebot) 
                                Call setOpenHoechstbieter()
                            ElseIf lvwEiSoCockpit.SelectedItems(0).SubItems(4).Text = 0 Then
                                Dim frmDetails As New FormGetItem
                                frmDetails.lvwDataInput = lvwEiSoCockpit
                                frmDetails.txteBayID.Text = lvwEiSoCockpit.SelectedItems(0).Text
                                frmDetails.Show()

                            End If

                    End Select


                Case "delcampe"

                    Select Case lvwEiSoCockpit.SelectedItems(0).SubItems(7).Text
                        Case "Completed"
                            Dim frmVersand As New frmBestellung_Versandkosten
                            frmVersand.mModusSelect = frmBestellung_Versandkosten.mModus.live
                            frmVersand.lvwDataInput = lvwEiSoCockpit
                            frmVersand.Show()
                        Case Else
                            Dim frmWeb As New frmYABE_WebBrowser

                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview

                            frmWeb.lvwDataView = lvwEiSoCockpit
                            frmWeb.Show(Me)
                    End Select

            End Select

        End If
    End Sub

    Public Function getSuchen() As Boolean
        Try
            'Call chkPing()

            btnSuchen.Enabled = False
            lvwEiSoCockpit.Enabled = False

            txtSuchen.Text = txtSuchen.Text.Replace("'", "")
            If txtSuchen.Text.Length = 0 Then
                If MessageBox.Show("Wollen Sie wirklich alle verfügbaren Datensätze anzeigen lassen?", "Alle verfügbaren Datensätze abrufen?" & vbNewLine & vbNewLine & "Dies kann unter Umständen etwas länger dauern!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    btnSuchen.Enabled = True
                    lvwEiSoCockpit.Enabled = True
                    Exit Function
                End If
            End If

            Call setStopuhr(True)

            Select Case tabMenue.SelectedTab.Name

                Case "menue_eBay_Live"
                    Call getLvwData(lvwEiSoCockpit, True)
                'Call setStatusMessage(lvweBayLiveList)
                Case "menue_bestellverlauf"
                    Call getLvwData(lvwBestellverwaltung_nach_artikel, True)
                'Call setStatusMessage(lvweBayHistory)
                Case "menue_kunden"
                    Call getLvwData(lvwKunden, True)
                ' Call setStatusMessage(lvwKunden)

                Case "menue_eBayBewertungen"
                    Call getLvwData(lvwBewertungen, True)
                'Call setStatusMessage(lvwBewertungen)
                Case "meineBay"

                Case "menue_artikelverwaltung"
                    Call getLvwData(lvwWebArtikel, True)
                ' Call setStatusMessage(lvwWebArtikel)
                Case "CMSebayGalerie"

                Case "tbPaypal"

                Case "menue_Mailversand"
                    Call getLvwData(lvMailStatus, True)
                ' Call setStatusMessage(lvMailStatus)
                Case "menue_shopste"
                    Call getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=get_category_item&domain_id=" & My.Settings.domain_id & " &shop_cat_id=0&suche=" & txtSuchen.Text, mgetUpdaterMessage.getShopsteCategoryItems, True)

                    Dim strContent As String = My.Computer.FileSystem.ReadAllText("shopste-kategorie-items.dat")
                    Dim i As Integer = 0

                    Dim strLines() As String = strContent.Split("<br>")
                    lvwShopste.Items.Clear()
                    ImageList1.Images.Clear()
                    Dim strErrorMessage As String = ""
                    For i = 0 To strLines.Length - 3

                        Dim strData() As String = strLines(i).Split("~")
                        Dim lvwItem As New ListViewItem
                        Dim strFilename() As String = strData(0).Split("/")
                        Dim strBildname As String
                        strBildname = strFilename(strFilename.Length - 1)
                        strBildname = strBildname.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                        strBildname = strBildname.Replace("<", "").Replace(">", "").Replace("|", "").Replace("ß", "")
                        strBildname = strBildname.Substring(0, Math.Min(strBildname.Length, 240))
                        'My.Computer.Network.DownloadFile("http://shopste.com" & strData(0).Replace("br>", "").Replace("/orginal/", "/kategorie/"), Application.StartupPath & "\bilderexport\" & strFilename(strFilename.Length - 1).Replace(":", ""))

                        If Not strBildname = "br>" Then
                            If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildname) = True Then
                                ImageList1.Images.Add(strData(4), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildname))
                                lvwItem.ImageKey = strData(4)
                            Else
                                If Not strData(0).Length = 0 Then
                                    Try
                                        My.Computer.Network.DownloadFile("http://shopste.com" & strData(0).Replace("br>", "").Replace("/orginal/", "/kategorie/"), Application.StartupPath & "\bilderexport\" & strBildname)


                                        ImageList1.Images.Add(strData(4), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildname))
                                        lvwItem.ImageKey = strData(4)
                                    Catch ex As Exception
                                        strErrorMessage = ex.Message
                                    End Try

                                End If

                            End If
                        End If


                        lvwItem.Text = "" 'strData(0)
                        lvwItem.SubItems.Add(strData(1))
                        lvwItem.SubItems.Add(strData(2))
                        lvwItem.SubItems.Add(strData(3))
                        lvwItem.SubItems.Add(strData(5))
                        lvwItem.SubItems.Add(strData(6))
                        lvwItem.SubItems.Add(strData(4))
                        If (strData(7) = "Y") Then
                            lvwItem.SubItems.Add("Aktiv")
                        Else
                            lvwItem.SubItems.Add("Inaktiv")
                        End If

                        lvwShopste.Items.Add(lvwItem)


                    Next
                    If strErrorMessage.Length > 0 Then
                        MessageBox.Show(strErrorMessage)
                    End If
                Case "Statistik"

            End Select

            btnSuchen.Enabled = True

            lvwEiSoCockpit.Enabled = True
            Return True
        Catch ex As Exception
            Call debug_message(ex, "getSuchen")
            Return False
        End Try
    End Function

    '################################################################
    '# >> Suchen in der Datenbank
    '################################################################
    Private Sub btnSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuchen.Click

        ' getThreadSearch.RunWorkerAsync()
        Call getSuchen()

    End Sub

    Private Sub txtSuchen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuchen.Click
        'txtSuchen.SelectAll()
    End Sub

    Private Sub txtSuchen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuchen.GotFocus
        If txtSuchen.Text = "Suchbegriff..." Then
            txtSuchen.Text = ""
        End If
    End Sub

    '##############################################
    '# >> Context: Copy eBay Beschreibung 
    '##############################################
    Private Sub txtSuchen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSuchen.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnSuchen.PerformClick()
        End If

    End Sub

    '##############################################
    '# >> Context: ebayID 
    '##############################################
    Private Sub CopyEBayIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyEBayIDToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwEiSoCockpit.SelectedItems(0).Text)
        End If

    End Sub

    '##############################################
    '# >> Context: Beenden des Programms 
    '##############################################
    Private Sub ArtikelBeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelBeendenToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim frmArtikelBeeden As New FrmEndItem
            frmArtikelBeeden.TxtItemId.Text = lvwEiSoCockpit.SelectedItems(0).Text
            frmArtikelBeeden.ShowDialog()
        End If

    End Sub

    '##############################################
    '# >> Context: Copy eBay Beschreibung 
    '##############################################
    Private Sub Copy_Beschreibung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_Beschreibung.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwEiSoCockpit.SelectedItems(0).SubItems(1).Text)
        End If

    End Sub

    Private Sub txtSuchen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuchen.LostFocus
        If txtSuchen.Text = "" Then
            txtSuchen.Text = "Suchbegriff..."
        End If
    End Sub


    '##############################################
    '# >> LIVE: Bewertungen
    '##############################################
    Private Sub chkStartupRückbewertung_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartupRückbewertung.CheckedChanged

        If chkStartupRückbewertung.Checked = True Then

            frmMain.tmrLiveAnsicht.Interval = 60000
            lvweBayBewertung = lvwBewertungen
            frmMain.tmrBewertungen.Enabled = True
            iBewertungenNeu_Anzahl = 0

            '# Bewertungen abrufen 
            'If strINI_eBay.strUserName.Length > 0 Then
            '    Call clseBayAPI.getFeedBackList(lvwBewertungen, strINI_eBay.strUserName, lblBewertungenPositiv, lblBewertungenNegativ, lblBewertungenPunkte)
            'End If

            Call getPopUp("Automatische Bewertungserfassung aktiviert")
        Else
            frmMain.tmrBewertungen.Enabled = False
            Call getPopUp("Automatische Bewertungserfassung deaktiviert")
        End If

    End Sub


    Private Sub lvwBewertungen_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwBewertungen.ColumnClick
        Call setSort(lvwBewertungen, e)
    End Sub

    '###########################################################################
    '# >> getSellerTransaction
    '###########################################################################
    Public Function getSellerTransaction(ByVal DateTimePickerVon As DateTimePicker, ByVal DatePickerBis As DateTimePicker) As Boolean
        Try

            Dim strVon() As String
            Dim strBis() As String
            Dim strtmp() As String



            '#################################
            '# >> Transaktionen holen 
            '#################################
            frmMain.master_Message_label.Text = Date.Now & ": Abrufen der Adressdaten von eBay"

            '# >> Abrufen Transaktionen holen
            strtmp = DateTimePickerVon.Value.ToString.Split(" ")
            strVon = strtmp(0).ToString.Split(".")
            strtmp = DatePickerBis.Value.ToString.Split(" ")
            strBis = strtmp(0).ToString.Split(".")

            If clseBayAPI.getSellerTransaktions(False, strVon, strBis) = True Then

            End If


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getSellerTransaction")
            Return False
        End Try

        Return True

    End Function

    '###########################################################################
    '# >> Bestellungen einelsen
    '###########################################################################
    Function setBestellungen(strModus As String) As Boolean
        Try

            frmMain.master_Message_label.Text = Date.Now & ": Übertragen der ausgelaufenden eBay Artikel wurde gestartet"


            Select Case strModus
                Case "neu"
                    '# NEU: Insert von Cockpit Daten in die Bestell-History
                    Select Case clsDatenbank_modul.setBestellungen_Orderlist_insert()
                        Case "true"
                            If chkAutomatischerModus.Checked = False Then
                                tabMenue.SelectedIndex = 2
                                Call getLvwData(lvwEiSoCockpit)
                                Call setStatusMessage(lvwEiSoCockpit)
                                Call getLvwData(lvwBestellverwaltung_nach_artikel)
                                Call setStatusMessage(lvwBestellverwaltung_nach_artikel)

                                MessageBox.Show("Alle Artikel wurden erfolgreich zu den Bestellungen synchronisiert", "EiSo Bestellungen Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                            End If
                        Case "false"

                            MessageBox.Show("Das synchronisieren mit der EiSo Bestellungen  wurde unterbrochen", "EiSo Bestellungen Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                        Case "-1"
                            If chkAutomatischerModus.Checked = False Then
                                MessageBox.Show("Es gab keine YABE Artikel für die Synchronisation mit den Bestellungen", "EiSo Bestellungen  Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                    End Select
                Case "alt"
                    '# Insert von Cockpit Daten in die Bestell-History (alt)
                    Select Case clsDatenbank_modul.setBestellungen_insert_alt()
                        Case "true"
                            If chkAutomatischerModus.Checked = False Then
                                tabMenue.SelectedIndex = 2
                                Call getLvwData(lvwEiSoCockpit)
                                Call setStatusMessage(lvwEiSoCockpit)
                                Call getLvwData(lvwBestellverwaltung_nach_artikel)
                                Call setStatusMessage(lvwBestellverwaltung_nach_artikel)

                                MessageBox.Show("Alle Artikel wurden erfolgreich zu den Bestellungen synchronisiert", "EiSo Bestellungen Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                            End If
                        Case "false"

                            MessageBox.Show("Das synchronisieren mit der EiSo Bestellungen  wurde unterbrochen", "EiSo Bestellungen Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                        Case "-1"
                            If chkAutomatischerModus.Checked = False Then
                                MessageBox.Show("Es gab keine YABE Artikel für die Synchronisation mit den Bestellungen", "EiSo Bestellungen  Synchronize", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                    End Select
            End Select





        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "seteBayHistory")
            Return False
        End Try

        Return True
    End Function

    '###########################################################################
    '# >> Transaktionen einlesen
    '###########################################################################
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MsgBox("Möchten Sie einen Abgleich ihrer Daten vom " & dtpCockpit_von.Text & " - " & dtpCockpit_bis.Text & " durchführen ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            '# Verkaufstransaktionen
            Call getSellerTransaction(dtpCockpit_von, dtpCockpit_bis)

            '# Live Artikel in die History übertragen
            Call setBestellungen("neu")
            Call setBestellungen("alt")

        End If

    End Sub


    Private Sub EMailExternesProgrammToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailExternesProgrammToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()

            ExterneAnwendung.StartInfo.FileName = "mailto:" & lvwEiSoCockpit.SelectedItems(0).SubItems(getEbayList.email).Text & "?subject=" & "Philafriend %20Auktion%20-%20" & lvwEiSoCockpit.SelectedItems(0).SubItems(getEbayList.beschreibung).Text & "&body=<strong>Hallo " & lvwEiSoCockpit.SelectedItems(0).SubItems(getEbayList.mitgliedsname).Text & "," & "</strong><br><br>Beüglich Artikel: " & lvwEiSoCockpit.SelectedItems(0).SubItems(getEbayList.beschreibung).Text & "<br>Preis: " & lvwEiSoCockpit.SelectedItems(0).SubItems(getEbayList.preisJetzt).Text & " Euro<br><br><br><br>MfG Philafriend1 - Auktion"

            ExterneAnwendung.Start()
        End If

    End Sub

    '########################################################
    '# >> Verschickt Manuell Auktionsmails 
    '# 6441
    '########################################################
    Public Function setSendMail(Optional ByVal bPreview As Boolean = False) As Boolean
        Try
            Dim strContent As String = ""
            Dim strContent_tmp As String = ""
            Dim strGetArtikel As String = ""
            Dim strGetGespreis As Double = 0
            Dim iCounteMailWeiter As Integer = 0
            Dim iCount2 As Integer = 0
            Dim strEmailTmp As String = ""
            Dim iColumn As Integer = 0
            Dim iNext As Integer = 0
            Dim strVersandkosten As Double = 0
            Dim strGetGespreis2 As String = ""
            Dim dblGesPrice As Double = 0
            Dim strMember As String = ""
            Dim strKundenDetails() As String
            Dim strKundenDetails_msg As String

            Dim iBeginn As Integer = 0 'beginn der For-Schleife 

            Dim iAnzahl As Integer = 0
            Dim strTemp As String = ""
            Dim strQuery As String = 0
            Dim eBayID() As String
            Dim dblVersandaktuell As Double
            Dim strPaypal As Double = 0
            Dim dblPayPal As Double = 0
            Dim strPaypal_link As String = ""
            Dim iCount_similar As Integer = 0
            Dim strMasterItem As String = "" ' für Ähnlche Artikel
            Dim strFieldMapping As String
            Dim strBetreff As String = ""
            Dim strPlattform As String = ""
            Dim strEmail As String = ""
            '# Sortieren der Listview Spalten
            iColumn = getEbayList.email

            If bLivstviewAsc(iColumn) = False Then
                lvwEiSoCockpit.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, False)
                bLivstviewAsc(iColumn) = True
            Else
                lvwEiSoCockpit.ListViewItemSorter = New comparebyFirstcolumn(iColumn, False, True)
                bLivstviewAsc(iColumn) = False
            End If

            '# Init der Klasse 
            iCountEmailWeiter_bestellpositionen = iArtikel

            If iCountEmailWeiter_bestellpositionen = 0 Then
                iCountEmailWeiter_bestellpositionen = lvwEiSoCockpit.Items.Count - 1
            End If



            '# Vorschaumodus aktiv 
            If bPreview = True Then

                '# Selektierter Eintrag vorhanden 
                '`# JB FIX
                'If lvweBayLiveList.SelectedItems.Count > 0 Then
                '    iBeginn = lvweBayLiveList.SelectedItems(0).Index 'setzen auf Beginn der For-SChleife 
                '    'iGebote = iBeginn + 1 ' einen Höher als der Beginn 
                'Else
                '    Exit Function
                'End If

            End If


            '#####################################################
            '# Durchlaufen aller Ausgelaufenen Artikel
            '#####################################################  
            clsMailing.lvwReadIn = lvwEiSoCockpit
            clsMailing.bDebug_mail = My.Settings.email_testmodus_only

            For iCounteMailWeiter = iBeginn To iCountEmailWeiter_bestellpositionen

                '# Template laden
                'strContent = clsMailing.getEMailTemplate(Application.StartupPath & "\vorlagen\mailtext.htm")
                strFieldMapping = clsDatenbank_modul.getTranslate_l18n_mapping(clsDatenbank_modul.getCustomer_sprache(lvwEiSoCockpit.SelectedItems(iCounteMailWeiter).SubItems(getEbayList.email).Text))

                '# ->> Daten für Replace holen 
                Select Case lvwEiSoCockpit.Items(iCount2).SubItems(17).Text.ToUpper
                    Case "EBAY"

                        strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_ebay, "Text" & strFieldMapping)
                        strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_betreff_ebay, "Text" & strFieldMapping)
                        strPlattform = "eBay"
                    Case "DELCAMPE"

                        strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_delcampe, "Text" & strFieldMapping)
                        strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_betreff_delcampe, "Text" & strFieldMapping)
                        strPlattform = "Delcampe"
                    Case "CMS"

                        strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_shop, "Text" & strFieldMapping)
                        strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_betreff_shop, "Text" & strFieldMapping)
                        strPlattform = "Shop"
                    Case "MAGENTO"
                        strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_magento, "Text" & strFieldMapping)
                        strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_betreff_magento, "Text" & strFieldMapping)
                        strPlattform = "Magento"
                    Case "SHOPSTE"
                        strContent = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_shopste, "Text" & strFieldMapping)
                        strBetreff = clsDatenbank_modul.getTranslationText(My.Settings.yabe_vorlage_auktionsende_betreff_shopste, "Text" & strFieldMapping)
                        strPlattform = "Shopste"
                End Select

                ReDim eBayID(lvwEiSoCockpit.Items.Count)

                If clsMailing.bIsWating = False Then

                    strVersandkosten = 0
                    strPaypal = 0
                    dblPayPal = 0
                    tmrEMailWaitTime.Enabled = False ' wird in der eMail Klasse aktiviert 
                    iNext = 1

                    For iCount2 = iCounteMailWeiter To iCountEmailWeiter_bestellpositionen

                        If iCount2 = iCountEmailWeiter_bestellpositionen Then '- 1 Then
                            iNext = 0
                        End If

                        'Try
                        '    Dim strData_next_email As String = lvwEiSoCockpit.Items(iCounteMailWeiter + iNext).SubItems(getEbayList.email).Text.ToLower
                        'Catch ex As Exception
                        '    Exit For
                        'End Try

                        dblVersandaktuell = Convert.ToDouble(lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(12).Text.Replace(".", ","))
                        dblPayPal = Convert.ToDouble(lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(18).Text.Replace(".", ","))

                        ' Ist es noch der gleiche Käufer?
                        If lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.email).Text.ToLower = lvwEiSoCockpit.Items(iCounteMailWeiter + iNext).SubItems(getEbayList.email).Text.ToLower Then

                            Try
                                lvwEiSoCockpit.Items(iCount2).Selected = True
                            Catch ex As Exception

                            End Try

                            lvwEiSoCockpit.EnsureVisible(iCount2)
                            Application.DoEvents()

                            '# ->> Daten für Replace holen 
                            Select Case lvwEiSoCockpit.Items(iCount2).SubItems(17).Text
                                Case "eBay"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.eBay, strFieldMapping)

                                Case "delcampe"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.delcampe, strFieldMapping)
                                Case "CMS"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.shopsystem, strFieldMapping)
                                Case "Magento"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.magento, strFieldMapping)
                                Case "Shopste"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.shopste, strFieldMapping)
                            End Select

                            strMasterItem &= lvwEiSoCockpit.Items(iCount2).SubItems(1).Text
                            ' Mitgliedsname holen 
                            strMember = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.mitgliedsname).Text
                            strEmail = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.email).Text

                            eBayID(iCount2) = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.ID).Text

                            '# Versandkosten bestimmen
                            If strVersandkosten < dblVersandaktuell Then
                                strVersandkosten = dblVersandaktuell
                            End If

                            '# Paypal Gesummtsumme finden 
                            If strPaypal < dblPayPal Then
                                strPaypal = dblPayPal
                            End If

                            ' eMail Empfänger holen 
                            clsMailing.strEmail_empfänger_email = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.email).Text


                            ' Sicherung der alten Content variablen
                            strContent_tmp = strContent

                            ' Gesamtpreis 
                            strGetGespreis += Convert.ToDouble(lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.preisJetzt).Text.Replace(".", ","))
                            lvwEiSoCockpit.Items(iCount2).BackColor = Color.Indigo

                            If Not iNext = 0 Then
                                iCounteMailWeiter += 1
                            End If

                            strMasterItem &= lvwEiSoCockpit.Items(iCount2).SubItems(getEbayList.beschreibung).Text

                            '################################################################
                            '#
                            '#################################################################
                        Else

                            lvwEiSoCockpit.EnsureVisible(iCounteMailWeiter)

                            Try
                                lvwEiSoCockpit.Items(iCount2).Selected = True
                            Catch ex As Exception

                            End Try

                            Application.DoEvents()

                            eBayID(iCount2) = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.ID).Text

                            '# Versandkosten bestimmen
                            If strVersandkosten < dblVersandaktuell Then
                                strVersandkosten = dblVersandaktuell
                            End If

                            '# Paypal Gesummtsumme finden 
                            If strPaypal < dblPayPal Then
                                strPaypal = dblPayPal
                            End If

                            ' Mitgliedsname holen 
                            strMember = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.mitgliedsname).Text
                            strEmail = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.email).Text

                            ' eMail Empfänger holen 
                            clsMailing.strEmail_empfänger_email = lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.email).Text

                            '# ->> Daten für Replace holen 
                            Select Case lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(17).Text
                                Case "eBay"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.eBay, strFieldMapping)
                                Case "delcampe"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.delcampe, strFieldMapping)
                                Case "Magento"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.magento, strFieldMapping)
                                Case "CMS"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.shopsystem, strFieldMapping)
                                Case "Shopste"
                                    strGetArtikel &= clsMailing.getTemplateVars(strGetArtikel, "GetArtikel", iCounteMailWeiter, clsEmail.bPlattform.shopste, strFieldMapping)
                            End Select


                            ' Sicherung der alten Content variablen
                            strContent_tmp = strContent

                            ' Gesamtpreis 
                            strGetGespreis += Convert.ToDouble(lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(getEbayList.preisJetzt).Text.Replace(".", ","))

                            'strVersandkosten = 0 'zurücksetzen der Versandkosten
                            strMasterItem &= lvwEiSoCockpit.Items(iCount2).SubItems(1).Text
                            Exit For

                        End If

                    Next iCount2 '# ENDE ARTIKEL ZUSAMMENSUCHEN

                    '# Endpreis 
                    dblGesPrice = strVersandkosten + strGetGespreis
                    ' Gesamtpreis festlegen
                    strGetGespreis2 = strGetGespreis
                    strGetGespreis2 = strGetGespreis2.Replace(".", ",")

                    ' Neu initalisieren 
                    ReDim strKundenDetails(10)


                    'Dim iZwischen As Integer = 0

                    'If iCount = 0 Then
                    '    iZwischen = 0
                    'Else
                    '    iZwischen = 1
                    'End If

                    '# Kundenprofil abrufen 
                    '#strKundenDetails = clsDatenbank_modul.getEiSoIsCostumerAdressByEmailOrID(lvwEiSoCockpit.Items(iCount - iZwischen).SubItems(6).Text)
                    strKundenDetails = clsDatenbank_modul.getEiSoIsCostumerAdressByEmailOrID(lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(6).Text)
                    'strKundenDetails = clsDatenbank_modul.getMemberAdress(strMember)

                    '# Template Nachricht 
                    strKundenDetails_msg = strKundenDetails(0) & "<br>" & strKundenDetails(1) & "<br>" & strKundenDetails(2) & "<br>" & strKundenDetails(3)
                    strContent_tmp = strContent_tmp.Replace("###KUNDE_NAME###", strKundenDetails(0))
                    strContent_tmp = strContent_tmp.Replace("###KUNDE_STRASSE###", strKundenDetails(1))
                    strContent_tmp = strContent_tmp.Replace("###KUNDE_ORT###", strKundenDetails(2))
                    strContent_tmp = strContent_tmp.Replace("###KUNDE_LAND###", strKundenDetails(3))

                    '################################
                    '# >> Umwandlung durchführen
                    '#################################
                    Dim dblGesPreis2 As Double = Convert.ToDouble(strGetGespreis2)

                    'Str(0) = dbReader("shippment_amount").ToString
                    'Str(1) = dbReader("order_total").ToString
                    'Str(2) = dbReader("paypal_total_sum").ToString
                    'Str(3) = dbReader("total_sum_amount").ToString
                    'Str(4) = dbReader("total_rabatt").ToString
                    'Str(5) = dbReader("total_rabatt_prozent").ToString
                    ' 6 = Kommentar
                    ' 7 = Versandart
                    ' Dim strOrderListData() As String = clsDatenbank_modul.getOrderListDetails(lvwEiSoCockpit.Items(iCount - iZwischen).SubItems(26).Text)

                    Dim strOrderListData() As String = clsDatenbank_modul.getOrderListDetails(lvwEiSoCockpit.Items(iCounteMailWeiter).SubItems(26).Text)

                    Dim strRabatt As String = ""
                    If Convert.ToDouble(strOrderListData(5)) > 0 Then
                        strRabatt = "<tr><td colspan=""5"" align=""right"" style=""border-top-color: rgb(185, 185, 185); border-top-width: 2px; border-top-style: solid;"">Rabatt " & strOrderListData(5) & "%:</td><td style=""border-top-color: rgb(185, 185, 185); border-top-width: 2px; border-top-style: solid;"" colspan=""2"">" & strOrderListData(4) & " Euro</td></tr>"
                        strRabatt &= "<tr><td colspan=""5"" align=""right"" style=""border-top-color: rgb(185, 185, 185); border-top-width: 2px; border-top-style: solid;"">Zwischensumme:</td><td style=""border-top-color: rgb(185, 185, 185); border-top-width: 2px; border-top-style: solid;"" colspan=""2"">" & (Convert.ToDouble(strOrderListData(1)) - Convert.ToDouble(strOrderListData(4))) & " Euro</td></tr>"
                    Else
                        strRabatt = ""
                    End If


                    strContent_tmp = strContent_tmp.Replace("###RABATT###", strRabatt)

                    strContent_tmp = strContent_tmp.Replace("###gesPreis###", strOrderListData(1))
                    'strContent_tmp = strContent_tmp.Replace("<###Endsumme###>", dblGesPrice.ToString("C", CultureInfo.CurrentCulture))
                    strContent_tmp = strContent_tmp.Replace("###Endsumme###", strOrderListData(3))

                    strContent_tmp = strContent_tmp.Replace("###ARTIKEL###", strGetArtikel)
                    strContent_tmp = strContent_tmp.Replace("###Kunden###", strKundenDetails_msg)
                    strContent_tmp = strContent_tmp.Replace("###Versandkosten###", strOrderListData(0))
                    'strContent_tmp = strContent_tmp.Replace("<###Versandkosten###>", strVersandkosten.ToString("C", CultureInfo.CurrentCulture))
                    strContent_tmp = strContent_tmp.Replace("###member###", strMember)
                    strContent_tmp = strContent_tmp.Replace("###EBAY_USER###", My.Settings.ebay_username)
                    strContent_tmp = strContent_tmp.Replace("###ANMELDUNG_NAME###", My.Settings.anmeldung_vorname & " " & My.Settings.anmeldung_nachname)
                    strContent_tmp = strContent_tmp.Replace("###ANMELDUNG_STRASSE###", My.Settings.anmeldung_strasse)
                    strContent_tmp = strContent_tmp.Replace("###ANMELDUNG_PLZ###", My.Settings.anmeldung_postleitzahl)
                    strContent_tmp = strContent_tmp.Replace("###ANMELDUNG_STADT###", My.Settings.anmeldung_stadt)
                    strContent_tmp = strContent_tmp.Replace("###ANMELDUNG_EMAIL###", My.Settings.anmeldung_email)
                    strContent_tmp = strContent_tmp.Replace("###ANMELDUNG_USTNR###", My.Settings.user_USTID)
                    strContent_tmp = strContent_tmp.Replace("###BANK_NAME###", My.Settings.bank_name)
                    strContent_tmp = strContent_tmp.Replace("###BANK_KONTONR###", My.Settings.bank_nr)
                    strContent_tmp = strContent_tmp.Replace("###BANK_BLZ###", My.Settings.bank_leitzahl)
                    strContent_tmp = strContent_tmp.Replace("###BANK_IBAN###", My.Settings.bank_IBAN)
                    strContent_tmp = strContent_tmp.Replace("###BANK_BIC###", My.Settings.bank_BIC)
                    strContent_tmp = strContent_tmp.Replace("###PLATTFORM###", strPlattform)
                    strContent_tmp = strContent_tmp.Replace("###KOMMENTAR###", strOrderListData(6))
                    strContent_tmp = strContent_tmp.Replace("###VERSANDART###", strOrderListData(7))



                    If strContent_tmp.Contains("###SHOP_LOGIN###") Then
                        Dim strLogin As String()
                        strLogin = clsDatenbank_modul.getMemberProfil_by_email(strEmail)

                        '# Kein Login gefunden
                        If strLogin(0) = "" Or strLogin(0) = "----" And My.Settings.eiso_shop_user_generate = True Then
                            clsDatenbank_modul.setCustomer_Login(strEmail, strMember)
                            strLogin = clsDatenbank_modul.getMemberProfil_by_email(strEmail)
                        End If

                        If Not strLogin(0) = "" Then
                            Select Case strFieldMapping
                                Case "_eng"
                                    strContent_tmp = strContent_tmp.Replace("###SHOP_LOGIN###", "<strong>Username:</strong> " & strLogin(0) & "<br/><strong>Password:</strong> " & strLogin(1) & "<br/><br/><a href=""" & My.Settings.shop_url & "/kd_login.php?sprache=eng&username=" & strLogin(0) & "&crc=" & strLogin(2) & """>Vist the shop user login</a>")
                                Case Else
                                    strContent_tmp = strContent_tmp.Replace("###SHOP_LOGIN###", "<strong>Benutzername:</strong> " & strLogin(0) & "<br/><strong>Passwort:</strong> " & strLogin(1) & "<br/><br/><a href=""" & My.Settings.shop_url & "/kd_login.php?sprache=&username=" & strLogin(0) & "&crc=" & strLogin(2) & """>Online Shop jetzt besuchen und automatisch anmelden</a>")
                            End Select

                        Else
                            strContent_tmp = strContent_tmp.Replace("###SHOP_LOGIN###", "")
                        End If

                    End If

                    '###########################################
                    '# >> Ähnliche Artikel finden 
                    '###########################################
                    If strContent_tmp.Contains("###Ähnlich###") Or strContent_tmp.Contains("###Ähnlich_eng###") Then


                        Dim str(,) As String
                        Dim strSimilar As String = ""
                        Dim strSimilar_eng As String = ""
                        Dim strBild_parts() As String
                        Dim iPart As Integer = 0
                        str = clsDatenbank_modul.getSimilarItems(strMasterItem, strFieldMapping)
                        strMasterItem = ""
                        strSimilar &= "<table width=100% align=""center""><tr>"
                        strSimilar_eng &= "<table width=100% align=""center""><tr>"
                        For iCount_similar = 0 To str.GetUpperBound(0)

                            ' MsgBox("Beschreibung: " & str(iCount, 0) & vbCrLf & "Preis: " & str(iCount, 1) & vbCrLf & "Bild: " & str(iCount, 2) & vbCrLf & "ID: " & str(iCount, 3), MsgBoxStyle.Information)
                            If Not str(iCount_similar, 2) = Nothing Then
                                '# TN Bild generieren 
                                strBild_parts = str(iCount_similar, 2).Split("/")
                                str(iCount_similar, 2) = str(iCount_similar, 2).Replace(strBild_parts(strBild_parts.Length - 1), "TN_" & strBild_parts(strBild_parts.Length - 1))

                                If iPart = 2 Then
                                    strSimilar &= "</tr><tr>"
                                    strSimilar_eng &= "</tr><tr>"
                                End If


                                strSimilar &= "<td>"
                                strSimilar_eng &= "<td>"

                                strSimilar &= "<img src=""" & str(iCount_similar, 2) & """ border=""0""><br/>"
                                strSimilar_eng &= "<img src=""" & str(iCount_similar, 2) & """ border=""0""><br/>"

                                strSimilar &= "Preis: " & str(iCount_similar, 1) & " Euro<br/>"
                                strSimilar_eng &= "Price: " & str(iCount_similar, 1) & " Euro<br/>"

                                strSimilar &= "<a href=""" & My.Settings.shop_url & "/suchen_Webseite.php?q=" & str(iCount_similar, 3) & "&id=on&sprache="">"
                                strSimilar_eng &= "<a href=""" & My.Settings.shop_url & "/suchen_Webseite.php?q=" & str(iCount_similar, 3) & "&id=on&sprache=_eng"">"
                                strSimilar &= str(iCount_similar, 0)
                                strSimilar_eng &= str(iCount_similar, 4)

                                strSimilar &= "</a>"
                                strSimilar_eng &= "</a>"
                                strSimilar &= "</td>"
                                strSimilar_eng &= "</td>"

                                If iPart = 2 Then
                                    'strSimilar &= "</tr>"
                                    iPart = 0
                                Else
                                    iPart += 1
                                End If

                            End If

                        Next

                        If Not iPart = 2 Then
                            strSimilar &= "</tr>"
                            strSimilar_eng &= "</tr>"
                        End If

                        strSimilar &= "</table>"
                        strSimilar_eng &= "</table>"

                        strContent_tmp = strContent_tmp.Replace("###Ähnlich###", strSimilar)
                        strContent_tmp = strContent_tmp.Replace("###Ähnlich_eng###", strSimilar_eng)
                    End If '# Ende Ähnliche Artikel Anzeigen (Template Prüfung)


                    If strPaypal > 0 And My.Settings.yabe_paypal_emailusername.Length > 0 Then
                        Dim strReplace As String

                        Try
                            strPaypal_link = strOrderListData(2)
                        Catch ex As Exception
                            strPaypal_link = strPaypal
                        End Try

                        If strPaypal_link = Nothing Then
                            strPaypal_link = strPaypal
                        End If

                        strPaypal_link = strPaypal_link.Replace(",", ".")

                        strReplace = "<TR><TD style=""BORDER-TOP: rgb(185,185,185) 2px solid"" align=""right"" colspan=""5"">Mit Paypal:</TD>"
                        strReplace &= "<TD style=""BORDER-TOP: rgb(185,185,185) 2px solid"" colSpan=""2""><###PAYPAL###></TD></TR>"
                        strReplace = strReplace.Replace("###PAYPAL###", "<a href=""https://www.paypal.com/xclick/business=" & My.Settings.yabe_paypal_emailusername & "&item_name=" & My.Settings.yabe_paypal_item_name & "+&no_shipping=2&no_note=0&tax=0&currency_code=EUR&amount=" & strPaypal_link & """>Bezahlung von " & strOrderListData(2) & " Euro an " & My.Settings.eiso_shopname & "</a>")
                        strContent_tmp = strContent_tmp.Replace("###PAYPAL_DE###", strReplace)

                        strReplace = "<TR><TD style=""BORDER-TOP: rgb(185,185,185) 2px solid"" align=""right""  colspan=""5"">With Paypal:</TD>"
                        strReplace &= "<TD style=""BORDER-TOP: rgb(185,185,185) 2px solid"" colSpan=""2""><###PAYPAL###></TD></TR>"
                        strReplace = strReplace.Replace("###PAYPAL###", "<a href=""https://www.paypal.com/xclick/business=" & My.Settings.yabe_paypal_emailusername & "&item_name=" & My.Settings.yabe_paypal_item_name & "+&no_shipping=2&no_note=0&tax=0&currency_code=EUR&amount=" & strPaypal_link & """>Payment amount " & strOrderListData(2) & " Euro (" & My.Settings.eiso_shopname & ")</a>")
                        strContent_tmp = strContent_tmp.Replace("###PAYPAL_DE###", strReplace)
                        strContent_tmp = strContent_tmp.Replace("###PAYPAL_EN###", strReplace)
                    Else
                        strContent_tmp = strContent_tmp.Replace("###PAYPAL_DE###", "")
                        strContent_tmp = strContent_tmp.Replace("###PAYPAL_EN###", "")
                    End If


                    strContent_tmp = strContent_tmp.Replace("###Kunden_name###", strKundenDetails(0))
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_NAME###", My.Settings.user_vorname & " " & My.Settings.user_nachname)
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_EBAYNAME###", My.Settings.ebay_username)
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_EISOUSER###", My.Settings.yabe_username)
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_EMAIL###", My.Settings.user_email)
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_ORT###", My.Settings.user_ort)
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_PLZ###", My.Settings.user_plz)
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_STRASSE###", My.Settings.user_strasse)
                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_SHOPNAME###", My.Settings.eiso_shopname)
                    strContent_tmp = strContent_tmp.Replace("###SHOP_URL###", My.Settings.shop_url)

                    strContent_tmp = strContent_tmp.Replace("###VERKÄUFER_FIRMA###", My.Settings.user_firmenname)
                    ' Zurücksetzten 

                    Application.DoEvents()

                    If bPreview = False Then
                        '# ->> eMail senden 
                        '# 
                        Dim strBetreffTMP As String = strBetreff

                        If IsNumeric(strMember) = True Then
                            strMember = strKundenDetails(0) & " (" & strMember & ")"
                        End If
                        strBetreffTMP = strBetreffTMP.Replace("###VERKÄUFER_SHOPNAME###", My.Settings.eiso_shopname)
                        strBetreffTMP = strBetreffTMP.Replace("###VERKÄUFER_FIRMA###", My.Settings.user_firmenname)
                        strBetreffTMP = strBetreffTMP.Replace("###KUNDEN_MEMBER###", strMember)
                        strBetreffTMP = strBetreffTMP.Replace("###PLATTFORM###", strPlattform)

                        setBludauMediaLogbuch(">> COCKPIT >> " & clsMailing.strEmail_empfänger_email & " - EMAIL FÜR " & strKundenDetails(0) & " - " & strEmail & " von " & My.Settings.eiso_shopname & " zu zahlen: " & strGetGespreis & "€ + " & strVersandkosten & "EUR = " & (strGetGespreis + strVersandkosten) & " / " & strPaypal & " WIRD VERSCHICKT...", "EMAIL_SEND_AUKTIONS_ENDE")


                        If clsMailing.setSendMail(strContent_tmp, strBetreffTMP) = False Then
                            MsgBox("Fehler beim verschicken der eMail zum Mitglied:  " & strMember, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, "eMail Senden Fehler")
                            Exit Function
                        Else

                            '# Nur wenn kein Debug Modus einfügen 
                            'If clsMailing.bDebug_mail = False Then
                            clsDatenbank_modul.setUpdateIsSend(strEmail)

                            'lvweBayLiveList.Items(iCount).BackColor = Color.Indigo
                            ' End If

                        End If
                    Else

                        '####################################
                        '# >> Vorschau generieren 
                        '####################################
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\vorlagen\preview.html", strContent_tmp, False)
                        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
                            Dim ExterneAnwendung As New System.Diagnostics.Process()
                            '  MsgBox("file://" & Application.StartupPath.Replace("\", "/") & "/vorlagen/preview.html")
                            'ExterneAnwendung.StartInfo.FileName = "file://" & Application.StartupPath.Replace("\", "/") & "/vorlagen/preview.html"
                            'ExterneAnwendung.Start()
                            Dim frmweb As New frmYABE_WebBrowser
                            frmweb.strURL = "file://" & Application.StartupPath.Replace("\", "/") & "/vorlagen/preview.html"
                            frmweb.Show()
                        End If

                        Exit For

                    End If

                    strGetArtikel = ""
                    strGetGespreis = 0

                Else
                    iCounteMailWeiter -= 2 ' einen Abziehen wegen Fehler 
                    frmMain.tool_ebayMessage.Text = "Wartezeit: " & clsMailing.iIsWatingTime
                End If

            Next iCounteMailWeiter

            ' Refresh nach abschicken
            Call getLvwData(lvwEiSoCockpit)
            Call setStatusMessage(lvwEiSoCockpit)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setSendMail")
            Return False
            '# Nur wenn keine Vorschau aktiv ist 
            If bPreview = False Then
                Dim frm As New frmSendMailWait
                frm.ShowDialog()
            End If

        End Try

        Return True
    End Function

    '########################################################
    '# >> Verschickt Manuell Auktionsmails 
    '# 6441
    '########################################################
    Private Sub btnSendEMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuftrag_email_senden.Click



        If lvwEiSoCockpit.Items.Count = 0 Then
            MsgBox("Es gibt keine ausgelaufenen Auktionen zum verschicken!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnAuftrag_email_senden.Enabled = False
            Exit Sub
        End If

        If My.Settings.email_username.Length = 0 Then
            MsgBox("Bitte Email Server Benutzernamen eintragen" & vbCrLf & "EiSo Werkzeuge -> EiSo Einstellungen -> Email Versand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If My.Settings.email_versand_username.Length = 0 Then
            MsgBox("Bitte Email Server Benutzernamen eintragen" & vbCrLf & "EiSo Werkzeuge -> EiSo Einstellungen -> Email Versand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        lvwEiSoCockpit.Enabled = False

        setBludauMediaLogbuch(">> COCKPIT >> PLATTFORM " & cmbPlattform_Live.Text & " Artikel zu verschicken: " & lvwEiSoCockpit.Items.Count & "x...", "COCKPIT")


        btnAuktionEinlesen.Enabled = False
        btnAuftrag_email_senden.Enabled = False
        btnSuchen.Enabled = False
        txtSuchen.Enabled = False



        Call setCockpit_EnableDisable(False)
        frmMain.master_Message_label.Text = Date.Now & ": eMail Auktionsendeversandt wurde gestartet"

        '# AKTION abhängig von der Platform
        Select Case cmbPlattform_Live.Text
            Case "eBay"
                If MsgBox("Möchten Sie die Adressendaten von eBay API holen?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '# Verkaufstransaktionen
                    setBludauMediaLogbuch(">> COCKPIT >> PLATTFORM " & cmbPlattform_Live.Text & " eBay Transaktionen abholen: " & lvwEiSoCockpit.Items.Count & "x...", "COCKPIT")
                    Call getSellerTransaction(dtpCockpit_von, dtpCockpit_bis)
                End If
        End Select


        Select Case cmbPlattform_Live.Text
            Case "eBay"
                Call setBestellungen("neu")
            Case Else
                Call setBestellungen("neu")
        End Select

        '# eMail verschicken
        If Not setSendMail() = True Then
            MsgBox("Fehler beim Email Versand! - Kein Löschen der Cockpit Liste", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, "EiSo - Email Versand")
        End If



        '# Immer Synchronisieren auch bei Fehler!
        '# AKTION abhängig von der Platform
        Select Case cmbPlattform_Live.Text
            Case "eBay"
                Call setBestellungen("alt")
            Case Else
                Call setBestellungen("alt")
        End Select

        '# Bestellliste aktuallisieren
        Dim tb As TabControl = DirectCast(tcBestellungen_visual, TabControl)

        If tb.SelectedIndex = 0 Then
            frmMain.master_Message_label.Text = Date.Now & ": Bestellverwaltung nach Artikeln werden aktuallisiert"
            Call getLvwData(lvwBestellverwaltung_nach_artikel)
        Else
            '# Neue Bestellungen liste
            frmMain.master_Message_label.Text = Date.Now & ": Bestellverwaltung nach Kunden wird aktuallisiert"
            Call getLvwData(lvwBestellungen_kunden)
        End If




        frmMain.master_Message_label.Text = Date.Now & ": Auktionsende Email's verschicken wurde abgeschlossen"

        Call setCockpit_EnableDisable(True)

        If chkAutomatischerModus.Checked = False Then
            MsgBox("Auktionsemails:  " & lvwEiSoCockpit.Items.Count & " Stk. wurden erfolgreich verschickt.", MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "eMail versendet")
        End If

        '# Ansicht neuladen 
        Call getLvwData(lvwEiSoCockpit)

        '# Anzahl Neueinlesen
        Call getRadioOptions_counts(lvwEiSoCockpit.Name)

        setBludauMediaLogbuch(">> COCKPIT >> " & cmbPlattform_Live.Text & " VERSCHICKT " & lvwEiSoCockpit.Items.Count & " ARTIKEL....", "COCKPIT")

        btnAuftrag_email_senden.Enabled = True
        btnAuktionEinlesen.Enabled = True
        btnSuchen.Enabled = True
        txtSuchen.Enabled = True
        lvwEiSoCockpit.Enabled = True

    End Sub

    '#########################################################
    '# >> Rechnung laden 
    '#########################################################
    Private Sub btnRechnungansehen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frmRechnung As New FormGetAccount
        frmRechnung.Show()

    End Sub
    '#########################################################
    '# >> FORM: Nachrichtencenter
    '#########################################################
    Private Sub btnNachrichtenzenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frmNAchrichten As New FrmGetMemberMessages
        frmNAchrichten.Show()
    End Sub


    '###########################################################
    '# >> FUNC: Blättern 
    '###########################################################
    Public Function setPage(ByVal modus As eBlatt) As Boolean
        Dim iFrom As Integer = 0
        Dim iTo As Integer = 0

        Try

            Dim strTemp As String = ""
            Dim strQuery As String = ""

            ' SQL - String holen 
            strTemp = getSQLQuery_Options(lvwEiSoCockpit)

            If modus = eBlatt.zurück Then

                If iPage.iPageNow > 0 Then
                    iPage.iPageNow -= 1
                Else
                    btnZurück.BackColor = Color.Coral
                    btnZurück.Enabled = False
                End If

            Else
                btnZurück.Enabled = True
                btnZurück.BackColor = Color.WhiteSmoke
                iPage.iPageNow += 1
            End If

            iFrom = iPage.iPageNext * iPage.iPageNow

            strQuery = "SELECT * FROM yabe_auction_list_live where " & strTemp & " LIMIT " & iFrom & "," & iPage.iPageNext
            clsDatenbank_modul.getListviewData(lvwEiSoCockpit, strQuery, bilder_history)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setPage")
            Return False
        End Try

        Return True
    End Function

    '###########################################################
    '# >> DESIGN: Vorwärts 
    '###########################################################
    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click

        lvwEiSoCockpit.Items.Clear()
        Call setPage(eBlatt.vor)
        'Call setInfoPanel(False)
        lblSeite.Text = "Seite: " & iPage.iPageNow & " / " & iPage.iPageGes & " (" & iPage.iPageNext & ")"

    End Sub

    '#####################################################################
    '# >> Exportieren
    '#####################################################################
    Public Function export(ByVal lvw As ListView, Optional ByVal strCat As export_targets = export_targets.standard, Optional ByVal mModus As selectModus = selectModus.ganz) As Boolean

        Dim bMagento As Boolean = False
        Dim bDelcampe As Boolean = False
        Dim bOK As Boolean = False
        Dim bAbort As Boolean = True
        Dim Datum_start As Date = Date.Now

        Try

            If lvw.Items.Count = 0 Then
                Return False
            End If

            Dim strPfad As String
            Dim strNamePart As String = ""
            Dim bExportScreen As Boolean = False

            If System.IO.Directory.Exists(My.Settings.eiso_csv_export) = False Then
                MsgBox("Bitte ändern Sie Ihr Export Verzeichnis in den YABE - Optionen 'STRG + O'", MsgBoxStyle.Exclamation)
                '   Dim frmOption As New frmOptions
                'frmOption.MdiParent = Me
                '  frmOption.Show()

                Exit Function
            End If


            '# ANHAND DER LISTVIEW NAMEN FESTLEGEN 
            Select Case lvw.Name
                Case "lvwBewertungen"
                    strNamePart = "Bewertung - "
                Case "lvweBayGalerie"
                    strNamePart = "Galerie - "
                Case "lvwBestellverwaltung_nach_artikel"
                    strNamePart = "eBay Verlauf - "
                Case "lvweBayLive"
                    strNamePart = "eBay Live Liste - "
                Case "lvwEbayNachrichten"
                    strNamePart = "Nachrichten - "
                Case "lvwEbayRechnung"
                    strNamePart = "Rechnung - "
                Case "lvwGetBestellungen"
                    strNamePart = "Bestellung - "
                Case "lvwKunden"
                    strNamePart = "Kunden - "
                Case "lvwOutlook_items"
                    strNamePart = "Outlook Sync - "
                Case "lvwWebArtikel"

                    '# Exportnamen ermitteln 
                    Select Case strCat
                        Case export_targets.delcampe
                            strNamePart = "Delcampe - " & lvwMenue.SelectedItems(0).SubItems(1).Text
                            bDelcampe = True
                            strNamePart = getCleanFilename(strNamePart)

                        Case export_targets.magento
                            strNamePart = "MagentoExport - " & lvwMenue.SelectedItems(0).SubItems(1).Text
                            bMagento = True
                            strNamePart = getCleanFilename(strNamePart)
                        Case export_targets.standard

                    End Select


            End Select

            Dim strFilename As String = strNamePart & Date.Now.ToString.Replace(".", "_").Replace(":", "_") & ".csv"
            strPfad = My.Settings.eiso_csv_export & "\" & strFilename


            '# WEB ARTIKEL 
            If lvw.Name = "lvwWebArtikel" Then

                '# Export Bildschirm anzeigen
                If bDelcampe = True Then

                    Dim frmYABEExport As New frmDelcampe_export
                    frmYABEExport.bIsloading = True
                    frmYABEExport.lvwData_multiselect = lvw
                    frmYABEExport.ShowDialog(Me)
                    bAbort = frmYABEExport.bAbort

                    If bAbort = False Then


                        If ListviewToCSV(lvw, strPfad, False, strCat, mModus, frmYABEExport.aryAuktionData) = True Then
                            bOK = True
                        End If

                    End If
                    '# Ohne Export Screen derzeit Magento 
                ElseIf bMagento = True Then

                    Dim frmYABEExport As New frmCMS_MagentoExport
                    frmYABEExport.ShowDialog(Me)
                    bAbort = frmYABEExport.bOK

                    If bAbort = True Then
                        If ListviewToCSV(lvw, strPfad, False, strCat, mModus, frmYABEExport.aryAuktionData) = True Then
                            bOK = True
                        End If

                    End If

                Else

                    If ListviewToCSV(lvw, strPfad, False, strCat, mModus) = True Then
                        bOK = True
                    End If

                End If


            Else
                Call ListviewToCSV(lvw, strPfad, False, strCat)
            End If

            If bOK = True Then
                Dim Min As Long = Microsoft.VisualBasic.DateDiff(DateInterval.Second, Datum_start, Date.Now)
                Dim Std As Double = Min / 60
                'Min = Min Mod Std

                If MsgBox("Die exportierte Datei '" & strPfad & "' öffnen?" & vbCrLf & "Exportdauer: " & Math.Round(Std, 2) & "Minuten", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

                    Dim ExterneAnwendung As New System.Diagnostics.Process()
                    ExterneAnwendung.StartInfo.FileName = strPfad
                    ExterneAnwendung.Start()

                End If

            End If


            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "export")
            Return False
        End Try
    End Function
    Public Function getCleanFilename(ByVal strName As String) As String

        Try
            strName = strName.Replace(":", "")
            strName = strName.Replace("<", "")
            strName = strName.Replace(">", "")
            strName = strName.Replace("/", "")
            strName = strName.Replace("\", "")
            strName = strName.Replace("?", "")
            strName = strName.Replace("*", "")

            Return strName

        Catch ex As Exception
            Return strName
        End Try

    End Function

    '#####################################################################
    '# >> MNU: Exportieren
    '#####################################################################
    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count >= 2 Then
            Call export(lvwEiSoCockpit, export_targets.standard, selectModus.part)
        Else
            Call export(lvwEiSoCockpit, export_targets.standard, selectModus.ganz)
        End If


    End Sub


    '#####################################################################
    '# >> MNU: Artikel löschen
    '#####################################################################
    Private Sub EntfernenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntfernenToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            If Not lvwEiSoCockpit.SelectedItems(0).Text = "" Then

                If MessageBox.Show("Wollen Sie den Artikel: " & lvwEiSoCockpit.SelectedItems(0).SubItems(1).Text & " wirklich als gelöscht makieren?", "Artikel als gelöscht makieren", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    clsDatenbank_modul.setDeleted(lvwEiSoCockpit.SelectedItems(0).Text)
                    lvwEiSoCockpit.SelectedItems(0).Remove()
                Else
                    ' nix
                End If
            End If

        End If

    End Sub

    '#####################################################################
    '# >> CHK: Sind Artikel versendet 
    '#####################################################################
    Private Sub chkIsGesendet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If bIsLoading = False Then

            '# Sofortkaufe haben keine Gebote 
            chkGebote.Checked = True
            chkeBayEnde.Checked = True

            Call getLvwData(lvwEiSoCockpit)

        End If

    End Sub


    '#####################################################################
    '# >> CHK: gelöschte Artikel anzeigen
    '#####################################################################
    Private Sub chkDeleted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwEiSoCockpit)
            bIsLoading = False
        End If
    End Sub

    '#####################################################################
    '# >> MNU: Ist Verschickt
    '#####################################################################
    Private Sub IsSendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsSendToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            If Not lvwEiSoCockpit.SelectedItems(0).Text = "" Then

                If lvwEiSoCockpit.SelectedItems.Count = 0 Then
                    If MessageBox.Show("Wollen Sie den eBay Artikel: " & lvwEiSoCockpit.SelectedItems(0).SubItems(1).Text & " wirklich als versendet markieren?", "Artikel versendet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        '# Artikel als verschickt makieren 
                        clsDatenbank_modul.seteMail_send(lvwEiSoCockpit.SelectedItems(0).Text)
                        lvwEiSoCockpit.SelectedItems(0).Remove()
                    End If
                Else

                    Dim iCount As Integer
                    For iCount = 0 To lvwEiSoCockpit.SelectedItems.Count - 1
                        '# Artikel als verschickt makieren 
                        clsDatenbank_modul.seteMail_send(lvwEiSoCockpit.SelectedItems(0).Text)
                        lvwEiSoCockpit.SelectedItems(0).Remove()
                    Next

                End If

            End If

        End If

    End Sub

    '#####################################################################
    '# >> CHK: Ausgelaufende Artikel
    '#####################################################################
    Private Sub chkEndTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEndTime.CheckedChanged

        If bIsLoading = False Then
            chkEndTime.Enabled = False

            bIsLoading = True
            If chkEndTime.Checked = True Then
                lblVon.Text = "Von - Auktionsende Datum"
                lblBis.Text = "Bis - Auktionsende Datum"
            Else
                lblVon.Text = "Von - Einstelldatum Datum"
                lblBis.Text = "Bis - Einstelldatum Datum"
            End If

            If chkEndTime.Checked = True Then
                dtpCockpit_von.Value = Date.Now.AddDays(-1)
                dtpCockpit_bis.Value = Date.Now.AddDays(My.Settings.gui_dauer_cockpit)
            Else
                dtpCockpit_von.Value = Date.Now.AddDays(-My.Settings.gui_dauer_cockpit)
                dtpCockpit_bis.Value = Date.Now.AddDays(1)
            End If

            Call getLvwData(lvwEiSoCockpit)
            chkEndTime.Enabled = True
            bIsLoading = False
        End If
    End Sub
    '#####################################################################
    '# >> eBay HOMEPAGE Galerie generieren
    '#####################################################################
    Public Function setEBayGalerieData(Optional ByVal bGeboteOnly As Boolean = False) As Boolean
        Try

            Call setCockpit_EnableDisable(False)

            frmMain.StatusStrip1.Items(1).Text = Date.Now & ": Beginne eBay HTML Galerie Update"

            If clsDatenbank_modul.setWebHTMLGalerie(lblLiveMessage, bGeboteOnly) = True Then
                Call setCockpit_EnableDisable(True)
            Else
                Call setCockpit_EnableDisable(True)
                MessageBox.Show("Es gibt keine eBay Artikel für die Aktuallisierung", "YABE - HTML Galerie", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getEbayData")
            Return False
        End Try

        Return True

    End Function

    '#####################################################################
    '# >> MNU: eBay Link öffnen
    '#####################################################################
    Private Sub EBayLiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '# 
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwWebArtikel.SelectedItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
            ExterneAnwendung.Start()
        End If

    End Sub

    Private Sub btnAdressLabels_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdressLabels.Click

        '# Abstand von -> bis Heute bestimmen 
        Dim startTime As Date = Now
        Dim runLength As Global.System.TimeSpan = Now.Subtract(KundenVon.Value)
        Dim days As Integer = runLength.Days
        frmMain.master_Message_label.Text = "Ausgewählter Zeitraum des Exports vom " & KundenVon.Text & "  -  " & KundenBis.Text
        If days > 15 Then

            If MsgBox("Wollen Sie wirklich die Adressen der letzten " & days & " Tage anzeigen lassen?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                btnAdressLabels.Enabled = True
                Exit Sub
            End If
        End If

        Dim strPlattform As String = ""
        If cmbPlattform_kunden.Text = "Alle" Then
            strPlattform = ""
        ElseIf cmbPlattform_kunden.Text = "Delcampe" Then
            strPlattform = "delcampe"
        ElseIf cmbPlattform_kunden.Text = "eBay" Then
            strPlattform = "eBay"
        ElseIf cmbPlattform_kunden.Text = "Shopsysteme" Then
            strPlattform = "CMS"
        End If

        If clsExport.ExpAdress2HTML(Application.StartupPath & "\vorlagen\adress2HTML.html", KundenVon.Value, strPlattform) = False Then
            MessageBox.Show("Fehler beim abspeichern der Adresslabels")
        End If

    End Sub

    '#####################################################
    '# >> Kunden Abrufen 
    '#####################################################
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKundenHolen.Click


        bIsLoading = True
        Call getLvwData(lvwKunden)

        bIsLoading = False


    End Sub

    '#####################################################
    '# >> Bestellveraluf 
    '#####################################################
    Public Function getOrderHistory(ByVal lvw As ListView, ByVal streMail As String) As Boolean

        Try

            Dim frmBestellen As New frmKunde_bestellverlauf
            frmBestellen.stremail = streMail
            frmBestellen.lvwDataInput = lvw
            frmBestellen.Show()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getOrderHistory")
            Return False
        End Try

        Return True
    End Function

    Private Sub BestellübersichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestellübersichtToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwKunden, lvwKunden.SelectedItems(0).SubItems(2).Text)
        End If
    End Sub

    Private Sub WebinterfaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebinterfaceToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = My.Settings.shop_url & "/ACP/adminpanel.php"
        ExterneAnwendung.Start()

    End Sub

    '#######################################################################
    '# >> eBay Daten holen 
    '#######################################################################
    Private Sub btneBayLiveRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestellungen_abrufen.Click
        Dim strQuery As String = ""

        If bIsLoading = False Then
            If cmbPlattform_bestellungen.Text.Contains("Alle") Then
                lblBestellungen_main.Text = "Alle Bestellungen"
                btneBayAdressenHolen.Visible = False
            ElseIf cmbPlattform_bestellungen.Text.Contains("eBay") Then
                lblBestellungen_main.Text = "Bestellungen eBay"
                btneBayAdressenHolen.Visible = True

            ElseIf cmbPlattform_bestellungen.Text.Contains("Delcampe") Then
                lblBestellungen_main.Text = "Bestellungen Delcampe"
                btneBayAdressenHolen.Visible = False
            ElseIf cmbPlattform_bestellungen.Text.Contains("Shop") Then
                lblBestellungen_main.Text = "Bestellungen Shop"
                btneBayAdressenHolen.Visible = False
            ElseIf cmbPlattform_bestellungen.Text.Contains("Magento") Then
                lblBestellungen_main.Text = "Bestellungen Magento"
                btneBayAdressenHolen.Visible = False
            ElseIf cmbPlattform_bestellungen.Text.Contains("Shopste") Then
                lblBestellungen_main.Text = "Bestellungen Shopste"
                btneBayAdressenHolen.Visible = False
            End If

            bIsLoading = True
            btnBestellungen_abrufen.Enabled = False

            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If



            '     lvwBestellungen_bestelliste_neu = lvweBayHistory
            setBludauMediaLogbuch(">> BESTELLUNGEN >> Artikel eingelesen: " & frmMain.master_Message_label.Text, "BESTELLUNGEN")

            btnBestellungen_abrufen.Enabled = True
            bIsLoading = False

        End If

    End Sub

    Private Sub EBayÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayÖffnenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

            Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text
                Case "eBay"
                    Dim ExterneAnwendung As New System.Diagnostics.Process()
                    ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
                    ExterneAnwendung.Start()

                Case "delcampe"
                    Dim ExterneAnwendung As New System.Diagnostics.Process()
                    ExterneAnwendung.StartInfo.FileName = "http://delcampe.de/page/item/id," & lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text & ",language,G.html"
                    ExterneAnwendung.Start()

            End Select
        End If


    End Sub

    Private Sub CopyEBayIDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyEBayIDToolStripMenuItem1.Click

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text)
        End If

    End Sub

    Private Sub CopyEBayMitgliedsnameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyEBayMitgliedsnameToolStripMenuItem.Click

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(2).Text)
        End If

    End Sub

    '#######################################################################
    '# >> eBay History Sortieren 
    '#######################################################################
    Private Sub lvweBayHistory_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwBestellverwaltung_nach_artikel.ColumnClick

        Call setSort(lvwBestellverwaltung_nach_artikel, e)
        'Call setStatusMessage(lvweBayHistory)
    End Sub

    '#######################################################################
    '# >> KUNDENLISTE Sortieren 
    '#######################################################################
    Private Sub lvwKunden_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwKunden.ColumnClick
        Call setSort(lvwKunden, e)
        Call setStatusMessage(lvwKunden)
    End Sub

    Private Sub cmdRechnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRechnen.Click
        Dim Ges2 As Double
        Dim dummy As String

        If txtVersand.Text = "" Then
            txtVersand.Focus()
            MsgBox("Sie haben keine Versandsumme eingetragen", vbCritical + vbSystemModal, "keine Versandsumme")
            Exit Sub
        End If

        If txtSumme.Text = "" Then
            txtSumme.Focus()
            MsgBox("Keine Summe eingetragen", vbCritical + vbSystemModal, "keine Summe eingetragen")
            Exit Sub
        End If

        txtSumme.Text = Replace(txtSumme.Text, ",", ".")
        txtVersand.Text = Replace(txtVersand.Text, ",", ".")

        Ges2 = setCalcPaypal(txtSumme.Text, txtVersand.Text)

        txtEndsumme.Text = Ges2
        txtEndsumme.Text = Math.Round(Convert.ToDouble(txtEndsumme.Text), 2)
        txtEndsumme.Text = Replace(txtEndsumme.Text, ",", ".")
        txtZwischensumme.Text = Val(txtEndsumme.Text) - Val(txtSumme.Text)
        dummy = "Hello, " + vbCrLf + "The total sum includes the whole costs !!! " + vbCrLf + vbCrLf + " PayPal payment details click the bottom listed link ! " + vbCrLf + vbCrLf + " https://www.paypal.com/xclick/business=philafriend@gmx.de&item_name=philafriend.de.vu+&no_shipping=1&no_note=1&tax=0&currency_code=EUR&amount=" + txtEndsumme.Text + vbCrLf + vbCrLf + "Total sum: " + txtEndsumme.Text + " Euro"

        '# In die zwischenablage kopieren
        Clipboard.Clear()
        Clipboard.SetText(dummy)
    End Sub

    Private Sub txtSumme_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtSumme.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        '# Enter
        If KeyCode = 13 Then
            '# Rechnen anwerfen
            Call cmdRechnen_Click(cmdRechnen, New System.EventArgs())
        End If

    End Sub

    Private Sub txtVersand_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVersand.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        '# Enter
        If KeyCode = 13 Then
            '# Rechnen anwerfen
            Call cmdRechnen_Click(cmdRechnen, New System.EventArgs())
        End If
    End Sub

    Private Sub PaypalBerechnungToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then

            txtSumme.Text = clsDatenbank_modul.getTotalSum(lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text)

            'txtSumme.Text = lvweBayLiveList.SelectedItems(0).SubItems(2).Text
            txtVersand.Text = lvwEiSoCockpit.SelectedItems(0).SubItems(12).Text
            cmdRechnen.PerformClick()
            tabMenue.SelectedIndex = 7
        End If

    End Sub

    '#######################################################
    '# CON: Bewertungsprofil von Person XY extern
    '#######################################################
    Private Sub BewertungsprofilÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BewertungsprofilÖffnenToolStripMenuItem.Click
        If lvwBewertungen.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://feedback.ebay.de/ws/eBayISAPI.dll?ViewFeedback2&userid=" & lvwBewertungen.SelectedItems(0).SubItems(1).Text
            ExterneAnwendung.Start()
        End If
    End Sub

    '#######################################################
    '# CON: Bewertungsprofil von Person XY intern
    '#######################################################
    Private Sub BewertungsprofilinternToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BewertungsprofilinternToolStripMenuItem.Click
        If lvwBewertungen.SelectedItems.Count > 0 Then
            txtBewertungen.Text = lvwBewertungen.SelectedItems(0).SubItems(0).Text
            btnRefreshBewertungen.PerformClick()
        End If
    End Sub

    Private Sub EBayArtikelÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayArtikelÖffnenToolStripMenuItem.Click

        If lvwBewertungen.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwBewertungen.SelectedItems(0).SubItems(2).Text
            ExterneAnwendung.Start()
        End If

    End Sub

    Private Sub chkBewertung_janein_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBewertung_janein.CheckedChanged

        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwBewertungen)
            bIsLoading = False
        End If
    End Sub

    Private Sub AlsBewertetSetzenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlsBewertetSetzenToolStripMenuItem.Click

        If Not lvwBewertungen.SelectedItems(0).Text = "" Then

            If MessageBox.Show("Wollen Sie den eBay Artikel:" & lvwBewertungen.SelectedItems(0).SubItems(2).Text & " wirklich zu den Bewerteten übernehmen ?", "Bewertung abgeben", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                '# Mitglied als bewertet makieren 
                If clsDatenbank_modul.setFeedbackBewerted(lvwBewertungen.SelectedItems(0).Text) = True Then
                    lvwBewertungen.SelectedItems(0).Remove()
                End If



            Else
                ' nix
            End If
        End If

    End Sub

    Private Sub lvwKunden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwKunden.KeyDown
        If e.Control = True And e.KeyCode = Keys.P Then
            Dim clsPrint As New clsPrinting
            clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, lvwKunden)
        End If
    End Sub


    Private Sub lvweBayHistory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwBestellverwaltung_nach_artikel.KeyDown

        '# Drucken aufrufen 
        If e.Control = True And e.KeyCode = Keys.P Then
            Dim clsPrint As New clsPrinting
            clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, lvwBestellverwaltung_nach_artikel)
        End If

        '# Vorwärts blättern 
        If e.KeyCode = Keys.Space Then

            Call setLVW_select_vorward(lvwBestellverwaltung_nach_artikel)
        End If

    End Sub

    Private Sub lvwBewertungen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwBewertungen.KeyDown
        If e.Control = True And e.KeyCode = Keys.P Then
            Dim clsPrint As New clsPrinting
            clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, lvwBewertungen)
        End If
    End Sub




    Private Sub chkEbayLive_Gebote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwBestellverwaltung_nach_artikel)
            bIsLoading = False
        End If

    End Sub

    Private Sub PaypalBerechnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim str() As String
        'str = lvweBayHistory.SelectedItems(0).SubItems(2).Text.Split(" ")
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            txtSumme.Text = clsDatenbank_modul.getTotalSum(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(2).Text, "yabe_auction_list_history")
            'txtSumme.Text = lvweBayLiveList.SelectedItems(0).SubItems(2).Text
            txtVersand.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(6).Text
            cmdRechnen.PerformClick()
            tabMenue.SelectedIndex = 9
        End If

    End Sub

    Private Sub BietverlaufToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BietverlaufToolStripMenuItem1.Click


        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmVerlauf As New FrmGetAllBidders
            frmVerlauf.lvwDataInput = lvwBestellverwaltung_nach_artikel
            frmVerlauf.TxtItemId.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text
            frmVerlauf.Show()
        End If

    End Sub

    Private Sub chkBewertungZeitfilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBewertungZeitfilter.CheckedChanged

        If bIsLoading = False Then
            Call getLvwData(lvwBewertungen)
            dtp_BewertungBis.Enabled = chkBewertungZeitfilter.Checked
            dtp_BewertungVon.Enabled = chkBewertungZeitfilter.Checked
        End If


    End Sub

    Private Sub chkHistoryZeitfilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHistoryZeitfilter.CheckedChanged

        If bIsLoading = False Then
            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If

            'Call getLvwData(lvweBayHistory)

            eBayHistoryVon.Enabled = chkHistoryZeitfilter.Checked
            eBayHistoryBis.Enabled = chkHistoryZeitfilter.Checked
        End If

    End Sub

    Private Sub chkKundenZeitfilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKundenZeitfilter.CheckedChanged



        If bIsLoading = False Then
            Call getLvwData(lvwKunden)
            setStatusMessage(lvwKunden)
            chkKundenZeitfilter.Enabled = True
            KundenVon.Enabled = chkKundenZeitfilter.Checked
            KundenBis.Enabled = chkKundenZeitfilter.Checked
        End If



    End Sub

    Private Sub chkLiveZeitfilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLiveZeitfilter.CheckedChanged
        If bIsLoading = False Then

            chkEndTime.Enabled = chkLiveZeitfilter.Checked

            Call getLvwData(lvwEiSoCockpit)
            dtpCockpit_bis.Enabled = chkLiveZeitfilter.Checked
            dtpCockpit_von.Enabled = chkLiveZeitfilter.Checked
        End If

    End Sub

    Private Sub dtp_BewertungVon_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_BewertungVon.LostFocus
        If bIsLoading = False Then
            Call getLvwData(lvwBewertungen)
            dtp_BewertungVon.Focus()
        End If

    End Sub

    Private Sub eBayHistoryBis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles eBayHistoryBis.LostFocus
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwBestellverwaltung_nach_artikel)
            bIsLoading = False
        End If
    End Sub

    Private Sub dtp_BewertungBis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_BewertungBis.LostFocus
        If bIsLoading = False Then
            Call getLvwData(lvwBewertungen)
            dtp_BewertungBis.Focus()
        End If
    End Sub


    Private Sub btnCheckPictures_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clsDatenbank_modul.chkCMS_picture_check(lvweBayGalerie, LblStatus)
    End Sub

    Private Sub btnTools_CMSArtikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGoogleBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCheckPictures_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnCheckPictures.Enabled = False

        clsDatenbank_modul.chkCMS_picture_check(lvweBayGalerie, LblStatus)

        btnCheckPictures.Enabled = True
    End Sub

    Private Sub ÜberarbeitenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÜberarbeitenToolStripMenuItem.Click


        If lvwMenue.SelectedItems.Count > 0 Then
            Dim frmCMSChange As New frmCMS_change_item
            frmCMSChange.setKategorie = lvwMenue.SelectedItems(0).SubItems(0).Text
            frmCMSChange.Show()
        Else
            MsgBox("Es wurde auf der rechten Seite keine Kategorie ausgewählt", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub NeuerArtikelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuerArtikelToolStripMenuItem.Click

        If lvwMenue.SelectedItems.Count > 0 Then
            Dim frmCMSChange As New frmCMS_change_item
            frmCMSChange.bIsNew = True
            frmCMSChange.setKategorie = lvwMenue.SelectedItems(0).SubItems(0).Text
            frmCMSChange.Show()
        Else
            MsgBox("Es wurde auf der rechten Seite keine Kategorie ausgewählt", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub lvwMenue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvwMenue.KeyPress
        Dim cWechsel As Char = "w"

        If e.KeyChar = cWechsel Then
            setChangeArtikelDatenbank_view()
        End If

    End Sub

    Private Sub lvwMenue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMenue.SelectedIndexChanged
        Try
            If lvwMenue.SelectedItems.Count > 0 Then
                bIsLoading = True
                lvwMenue.Enabled = False
                cmbArtikelStatus.SelectedIndex = 0
                'trd = New Thread(AddressOf setShopLVW_refresh)
                'trd.IsBackground = True
                'trd.Start()
                Call setShopLVW_refresh()
                lvwMenue.Enabled = True
                bIsLoading = False
            End If


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvwMeue_selectIndexChanged")
        End Try
    End Sub

    Private Function setcmbArtikelStatus_data() As Boolean
        Try
            Dim iId As Integer = 0
            If bIsLoading = False Then
                If lvwMenue.SelectedItems.Count > 0 Then
                    Dim iSel As Integer = -1

                    lvwMenue.Enabled = False
                    cmbSprache_Artikeldatenbank.Enabled = False
                    cmbArtikelStatus.Enabled = False




                    '# Liste löschen 
                    lvwWebArtikel.Items.Clear()

                    '# Status auswerten 
                    Select Case cmbArtikelStatus.Text
                        Case "Jeder Status"
                            iId = lvwMenue.SelectedItems(0).Text
                            Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Kategorie_neo='" & iId & "' ORDER BY Beschreibung ASC", lvwWebArtikel, lvwMenue, , , , , bilder_history)
                        Case "Bestellt"
                            Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Bestellt='1' ORDER BY Beschreibung ASC", lvwWebArtikel, lvwMenue, , , , , bilder_history)
                        Case "Warteliste"

                            Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Bestellt='2' ORDER BY Beschreibung ASC", lvwWebArtikel, lvwMenue, , , , , bilder_history)
                        Case "Offne Übersetzungen"


                            If frmMain.frmManage.cmbSprache_Artikeldatenbank.Text.Contains("Deutsch") Then

                            Else
                                Dim strISO As String = ""
                                Dim strColum As String = ""

                                strISO = clsDatenbank_modul.getTranslate_l18n_mapping(cmbSprache_Artikeldatenbank.Text)
                                Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Beschreibung" + strISO + " is NULL or Beschreibung" + strISO + "='" + strISO + "'", lvwWebArtikel, lvwMenue, , , , , bilder_history)

                            End If
                        Case "Delcampe Lister Import"
                            Call clsDatenbank_modul.getEiSoItems("SELECT tblGes.*, tbl_menue.export_magento as magento_menue, tbl_menue.delcampe_id as delcampe_menue_id,tbl_menue.Bezeichnung,tbl_menue.shopste_catid as shopste_catid  FROM tblGes LEFT JOIN tbl_menue ON tblGes.Kategorie_neo = tbl_menue.ID WHERE Bestellt='3' ORDER BY Datum DESC", lvwWebArtikel, lvwMenue, , , , , bilder_history)

                        Case "Die neusten Artikel"

                            Dim iLimit As Integer = My.Settings.artikeldatenbank_neuste
                            Call clsDatenbank_modul.getEiSoItems("SELECT tblGes.*, tbl_menue.export_magento as magento_menue, tbl_menue.delcampe_id as delcampe_menue_id,tbl_menue.Bezeichnung,tbl_menue.shopste_catid as shopste_menue_catid  FROM tblGes LEFT JOIN tbl_menue ON tblGes.Kategorie_neo = tbl_menue.ID WHERE Bestellt != '3' ORDER BY Datum DESC LIMIT 0," & iLimit, lvwWebArtikel, lvwMenue, -2, , , , bilder_history)

                    End Select

                    '# Status neu laden + färben 
                    Call setStatusMessage(lvwWebArtikel)


                    lvwWebArtikel.Focus()

                    lvwMenue.Enabled = True
                    cmbArtikelStatus.Enabled = True
                    cmbSprache_Artikeldatenbank.Enabled = True

                End If ' selektierter eintrag 
            End If
        Catch ex As Exception
            Call debug_message(ex, "setArtikelStatus")
        End Try
    End Function

    Private Sub cmbArtikelStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArtikelStatus.SelectedIndexChanged


        Call setcmbArtikelStatus_data()

    End Sub

    Private Sub AktuellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktuellToolStripMenuItem.Click
        '# 0
        If lvwWebArtikel.SelectedItems.Count > 0 Then

            Dim i As Integer = 0
            For i = 0 To lvwWebArtikel.SelectedItems.Count - 1
                Call clsDatenbank_modul.setWebartikelStatus(0, lvwWebArtikel.SelectedItems(i).SubItems(0).Text)
            Next

            MsgBox("Artikel wurde erfolgreich aktiviert", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestelltToolStripMenuItem.Click
        '# 1
        If lvwWebArtikel.SelectedItems.Count > 0 Then

            Dim i As Integer = 0
            For i = 0 To lvwWebArtikel.SelectedItems.Count - 1
                Call clsDatenbank_modul.setWebartikelStatus(1, lvwWebArtikel.SelectedItems(i).SubItems(0).Text)
            Next

            MsgBox("Artikel wurde erfolgreich als bestellt markiert", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub AussortiertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AussortiertToolStripMenuItem.Click
        '# 2
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To lvwWebArtikel.SelectedItems.Count - 1
                Call clsDatenbank_modul.setWebartikelStatus(2, lvwWebArtikel.SelectedItems(i).SubItems(0).Text)
            Next

            MsgBox("Artikel wurde erfolgreich als Vorrat markiert", MsgBoxStyle.Information)
        End If
    End Sub



    Private Sub tmrEMailWaitTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEMailWaitTime.Tick
        Static iCount As Long = Convert.ToInt64(My.Settings.app_AutoLiveListeDauer) * 60

        clsMailing.bIsWating = False
        clsMailing.iIsWatingTime = 0
        iCount -= 1

        If iCount < 0 Then
            iCount = Convert.ToInt64(My.Settings.app_AutoLiveListeDauer) * 60
        End If

        frmMain.master_Message_label.Text = "Noch " & iCount & " Sekunden"


    End Sub

    '####################################################
    '# >> Einlesen der entsprechenden eMail Leute 
    '####################################################
    Private Sub btnMailVersandStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailVersandStart.Click

        btnMailVersandStart.Enabled = False

        lvMailStatus.Items.Clear()
        Call getLvwData(lvMailStatus, False)


        If lvMailStatus.Items.Count > 0 Then
            btnAbschickenNewsletter.Enabled = True
        End If

        frmMain.master_Message_label.Text = lvMailStatus.Items.Count - 1 & "' Datensätze gefunden"

        btnMailVersandStart.Enabled = True
    End Sub

    '############################################################
    '# >> EMAIL - Vorlage -> Linktext 
    '############################################################
    Public Function getVorlage_linktext(ByVal modus As String) As String
        Try
            '# Linkliste DEUTSCH von Philafriend1.d 
            Dim strLinkText As String = ""
            Select Case modus
                Case "DE"
                    strLinkText = clsDatenbank_modul.getTranslationText(10)
                Case "EN"
                    strLinkText = clsDatenbank_modul.getTranslationText(11)
            End Select

            strLinkText = strLinkText.Replace("!!pro!!", clsDatenbank_modul.getCMS_catCount(49)) 'propaganda
            strLinkText = strLinkText.Replace("!!ans!!", clsDatenbank_modul.getCMS_catCount(65)) '
            strLinkText = strLinkText.Replace("!!1wel!!", clsDatenbank_modul.getCMS_catCount(78)) '
            strLinkText = strLinkText.Replace("!!brd!!", clsDatenbank_modul.getCMS_catCount(15)) '
            strLinkText = strLinkText.Replace("!!ddr!!", clsDatenbank_modul.getCMS_catCount(24)) '
            strLinkText = strLinkText.Replace("!!aus!!", clsDatenbank_modul.getCMS_catCount(86)) '
            strLinkText = strLinkText.Replace("!!eur!!", clsDatenbank_modul.getCMS_catCount(28)) '
            strLinkText = strLinkText.Replace("!!sbz!!", clsDatenbank_modul.getCMS_catCount(96)) '
            strLinkText = strLinkText.Replace("!!pap!!", clsDatenbank_modul.getCMS_catCount(103)) '
            strLinkText = strLinkText.Replace("!!sam!!", clsDatenbank_modul.getCMS_catCount(107)) '
            strLinkText = strLinkText.Replace("!!deu72!!", clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl from tbl_Listen  where Bereich =1")) '
            strLinkText = strLinkText.Replace("!!bi!!", clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl from tbl_Listen  where Bereich =3")) '
            strLinkText = strLinkText.Replace("!!alt!!", clsDatenbank_modul.getCMS_catCount(74)) '
            strLinkText = strLinkText.Replace("!!ber!!", clsDatenbank_modul.getCMS_catCount(20)) '
            strLinkText = strLinkText.Replace("!!2wel!!", clsDatenbank_modul.getCMS_catCount(79)) '
            strLinkText = strLinkText.Replace("!!dan!!", clsDatenbank_modul.getCMS_catCount(80)) '
            strLinkText = strLinkText.Replace("!!deu!!", clsDatenbank_modul.getCMS_catCount(1)) '
            strLinkText = strLinkText.Replace("!!zon!!", clsDatenbank_modul.getCMS_catCount(10)) '
            strLinkText = strLinkText.Replace("!!mot!!", clsDatenbank_modul.getCMS_catCount(90)) '
            strLinkText = strLinkText.Replace("!!sch!!", clsDatenbank_modul.getCMS_catCount(100)) '
            strLinkText = strLinkText.Replace("!!über!!", clsDatenbank_modul.getCMS_catCount(38)) '
            strLinkText = strLinkText.Replace("!!deu24!!", clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl from tbl_Listen  where Bereich =2")) '
            strLinkText = strLinkText.Replace("!!ddr!!", clsDatenbank_modul.getCMS_catCount(8)) '

            strLinkText = strLinkText.Replace("!!lsbz!!", clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl from tbl_Listen  where Bereich =5")) '
            strLinkText = strLinkText.Replace("!!lddr!!", clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl from tbl_Listen  where Bereich =6")) '
            strLinkText = strLinkText.Replace("!!lber!!", clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl from tbl_Listen  where Bereich =4")) '

            Return strLinkText

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getVorlage_linktext")
            Return "-1"
        End Try

    End Function

    Private Function setStartNewsletter() As Boolean
        Dim i As Integer
        Dim strEmail As String = ""
        Dim strSprache As String = ""
        Dim strText As String = ""
        Dim strBetreff As String = ""
        Dim strCRC As String = ""
        Dim strBereich As String = ""
        Dim strLinkText_DE As String = ""
        Dim strLinkText_EN As String = ""
        Dim bTestmodus As Boolean = False

        If lvMailStatus.Items.Count = 0 Then
            MsgBox("Es gibt keine Daten zum verschicken!", MsgBoxStyle.Information)
            Exit Function
        End If

        btnAbschickenNewsletter.Enabled = False
        btnMailVersandStart.Enabled = False
        btnMailVersandStart.Enabled = False
        pgrMailstatusGesammt.Maximum = lvMailStatus.Items.Count - 1
        pgrMailstatusGesammt.Value = 0

        '# EMAIL Vorlage vorbereiten
        frmMain.master_Message_label.Text = "Lade Deutsche Vorlage...."
        strLinkText_DE = getVorlage_linktext("DE")

        frmMain.master_Message_label.Text = "Lade Englische Vorlage...."
        strLinkText_EN = getVorlage_linktext("EN")

        frmMain.master_Message_label.Text = "Bereite Newsletter vor..."
        '# Listenanzahl und Gesammtsumme ermitteln 
        Dim iListe As Integer = clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl from tbl_Listen")
        Dim iGes As Integer = 0
        iGes = iListe
        iGes += clsDatenbank_modul.getCMS_Query("SELECT count(*) as anzahl FROM tblGes")

        Dim strName As String = ""
        Dim strUser As String = ""
        Dim strPwd As String = ""

        '# Betreff - DE 
        frmMain.master_Message_label.Text = "Lade Betreff Deutsch"
        Application.DoEvents()
        Dim getTranslationText_9 As String = clsDatenbank_modul.getTranslationText("9")

        '# Betreff - Eng
        frmMain.master_Message_label.Text = "Lade Betreff Englisch"
        Application.DoEvents()
        Dim getTranslationText_8 As String = clsDatenbank_modul.getTranslationText("8")

        '# Text -DE 
        frmMain.master_Message_label.Text = "Lade Text Deutsch"
        Application.DoEvents()
        Dim getTranslationText_4 As String = clsDatenbank_modul.getTranslationText("4")

        '# Text - ENG
        frmMain.master_Message_label.Text = "Lade Text Englisch"
        Application.DoEvents()
        Dim getTranslationText_5 As String = clsDatenbank_modul.getTranslationText("5")
        Application.DoEvents()
        Dim getTranslationText_2 As String = clsDatenbank_modul.getTranslationText("2")
        Application.DoEvents()
        Dim getTranslationText_1 As String = clsDatenbank_modul.getTranslationText("1")

        '# Testmodus 
        If chkNewsletter_testmodus.Checked = True Then
            If MsgBox("Sie befinden sich im Testmodus alle eMails werden NUR '" & My.Settings.email_username & "' geschickt!" & vbCrLf & "Möchten Sie fortfahren?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                bTestmodus = True
            Else
                btnAbschickenNewsletter.Enabled = True
                btnMailVersandStart.Enabled = True
                btnMailVersandStart.Enabled = True

                Exit Function
            End If

        End If

        '###################################################
        '# Alle Elemtente der For-Schleife durchlaufen 
        '###################################################
        Dim iGesLvw As Integer = 0
        iGesLvw = lvMailStatus.Items.Count - 1
        Dim ipro As Integer = clsDatenbank_modul.getCMS_catCount(49)
        Dim MutterSprache As String = ""
        For i = 0 To lvMailStatus.Items.Count - 1

            Application.DoEvents()
            '# Prüfung ob bereits verschickt! 
            If lvMailStatus.Items(i).SubItems(6).Text = "Nein" Then
                If clsMailing.bIsWating = False Then

                    '# Vorschau aktiv

                    If bIsPreviewNewsletter = True Then
                        strEmail = lvMailStatus.SelectedItems(0).SubItems(2).Text
                        strSprache = lvMailStatus.SelectedItems(0).SubItems(10).Text
                        strCRC = lvMailStatus.SelectedItems(0).SubItems(7).Text
                        If lvMailStatus.SelectedItems(0).SubItems(1).Text = "---" Then
                            strName = "Philatelie Freund,"
                        Else
                            strName = lvMailStatus.SelectedItems(0).SubItems(1).Text
                        End If
                        strUser = lvMailStatus.SelectedItems(0).SubItems(14).Text
                        strPwd = lvMailStatus.SelectedItems(0).SubItems(15).Text
                        MutterSprache = lvMailStatus.Items(i).SubItems(16).Text
                    Else
                        strEmail = lvMailStatus.Items(i).SubItems(2).Text
                        strSprache = lvMailStatus.Items(i).SubItems(10).Text
                        strCRC = lvMailStatus.Items(i).SubItems(7).Text
                        If lvMailStatus.Items(i).SubItems(1).Text = "---" Then
                            strName = "Philatelie Freund,"
                        Else
                            strName = lvMailStatus.Items(i).SubItems(1).Text
                        End If
                        strUser = lvMailStatus.Items(i).SubItems(14).Text
                        strPwd = lvMailStatus.Items(i).SubItems(15).Text
                        MutterSprache = lvMailStatus.Items(i).SubItems(16).Text
                    End If

                    '# Email Sprache auswählen 
                    Select Case strSprache
                        Case ".de"
                            strBetreff = getTranslationText_9
                            strText = getTranslationText_4

                            '# Replacements 
                            strBereich = getTranslationText_1
                            strBereich = strBereich.Replace(vbCrLf, "<br>")
                            strText = strText.Replace("!!!TEXT!!!", strBereich)
                            strText = strText.Replace("!!!Abmelden!!!", "<a href=" & My.Settings.shop_url & "/eMail/admin_massmail_remove.php?eMail=" & strEmail & "&CRC=" & strCRC & ">Abmelden vom Newsletter</a>")

                        Case ".com"
                            strText = getTranslationText_5
                            strBetreff = getTranslationText_8

                            '# Replacements 
                            strBereich = getTranslationText_2
                            strBereich = strBereich.Replace(vbCrLf, "<br>")
                            strText = strText.Replace("!!!TEXT_ENG!!!", strBereich)

                            strText = strText.Replace("!!!remove!!!", "<a href=" & My.Settings.shop_url & "/eMail/admin_massmail_remove.php?eMail=" & strEmail & "&CRC=" & strCRC & ">Remove me from this Newsletter</a>")

                        Case ".all"
                            strBetreff = getTranslationText_9

                            strText = getTranslationText_4
                            strText = strText & getTranslationText_5

                            '# Replacements 
                            strBereich = getTranslationText_1
                            strBereich = strBereich.Replace(vbCrLf, "<br>")
                            strText = strText.Replace("!!!TEXT!!!", strBereich)

                            strBereich = getTranslationText_2
                            strBereich = strBereich.Replace(vbCrLf, "<br>")
                            strText = strText.Replace("!!!TEXT_ENG!!!", strBereich)

                            strText = strText.Replace("!!!remove!!!", "<a href=" & My.Settings.shop_url & "/eMail/admin_massmail_remove.php?eMail=" & strEmail & "&CRC=" & strCRC & ">Remove me from this Newsletter</a>")
                            strText = strText.Replace("!!!Abmelden!!!", "<a href=" & My.Settings.shop_url & "/eMail/admin_massmail_remove.php?eMail=" & strEmail & "&CRC=" & strCRC & ">Abmelden vom Newsletter</a>")

                    End Select

                    '# Linkbereich einsetzen (statisch)
                    strText = strText.Replace("!!!LINKLISTE_DE!!!", strLinkText_DE)
                    strText = strText.Replace("!!!LINKLISTE_EN!!!", strLinkText_EN)

                    strText = strText.Replace("!!ANSCHRIFT!!", "")

                    strText = strText.Replace("!!list!!", iListe) '
                    strText = strText.Replace("!!ges!!", iGes) '
                    strText = strText.Replace("!!pro!!", ipro) '


                    '# Alte Gallerie löschen
                    ' strText = strText.Replace("!!!GALERIE!!!", clsDatenbank_modul.getNewsletterGalerie())

                    '###########################################
                    '# >> Ähnliche Artikel finden 
                    '###########################################
                    Dim str(,) As String
                    Dim strSimilar As String = ""
                    Dim strSimilar_eng As String = ""
                    Dim strBild_parts() As String
                    Dim iPart As Integer = 0
                    Dim iCount_similar As Integer = 0
                    Dim strMasterItem As String = ""

                    '# Letzte Käufe bestimmen 
                    strMasterItem = clsDatenbank_modul.getCustomerLastOrder(strEmail)

                    '# Gibt es überhaupt einen Kauf 
                    If strMasterItem.Length > 0 Then
                        strMasterItem = strMasterItem.Replace("'", "").Replace("""", "")

                        Dim strFieldMapping As String = ""
                        Select Case MutterSprache
                            Case "Deutsch"
                                strFieldMapping = ""
                            Case "Englisch"
                                strFieldMapping = "_eng"
                            Case "Französisch"
                                strFieldMapping = "_fr"
                            Case Else
                                strFieldMapping = ""
                        End Select

                        str = clsDatenbank_modul.getSimilarItems(strMasterItem, strFieldMapping)
                        strSimilar &= "<table width=100% align=""center""><tr>"
                        strSimilar_eng &= "<table width=100% align=""center""><tr>"
                        For iCount_similar = 0 To str.GetUpperBound(0)

                            frmMain.master_Message_label.Text = "Vorgeschlagene Artikel Nr. " & iCount_similar + 1

                            '# TN Bild generieren 
                            If str(iCount_similar, 2) = Nothing Then
                                Exit For
                            End If

                            strBild_parts = str(iCount_similar, 2).Split("/")
                            str(iCount_similar, 2) = str(iCount_similar, 2).Replace(strBild_parts(strBild_parts.Length - 1), "TN_" & strBild_parts(strBild_parts.Length - 1))

                            If iPart = 2 Then
                                strSimilar &= "</tr><tr>"
                                strSimilar_eng &= "</tr><tr>"
                            End If


                            strSimilar &= "<td>"
                            strSimilar_eng &= "<td>"

                            strSimilar &= "<img src=""" & str(iCount_similar, 2) & """ border=""0""><br/>"
                            strSimilar_eng &= "<img src=""" & str(iCount_similar, 2) & """ border=""0""><br/>"

                            strSimilar &= "Preis: " & str(iCount_similar, 1) & " Euro<br/>"
                            strSimilar_eng &= "Price: " & str(iCount_similar, 1) & " Euro<br/>"

                            strSimilar &= "<a href=""" & My.Settings.shop_url & "/suchen_Webseite.php?q=" & str(iCount_similar, 3) & "&id=on&sprache="">"
                            strSimilar_eng &= "<a href=""" & My.Settings.shop_url & "/suchen_Webseite.php?q=" & str(iCount_similar, 3) & "&id=on&sprache="">"
                            strSimilar &= str(iCount_similar, 0)
                            strSimilar_eng &= str(iCount_similar, 4)

                            strSimilar &= "</a>"
                            strSimilar_eng &= "</a>"
                            strSimilar &= "</td>"
                            strSimilar_eng &= "</td>"

                            If iPart = 2 Then
                                'strSimilar &= "</tr>"
                                iPart = 0
                            Else
                                iPart += 1
                            End If

                        Next

                        If Not iPart = 2 Then
                            strSimilar &= "</tr>"
                            strSimilar_eng &= "</tr>"
                        End If

                        strSimilar &= "</table>"
                        strSimilar_eng &= "</table>"

                    End If

                    strText = strText.Replace("###Ähnlich###", strSimilar)
                    strText = strText.Replace("###Ähnlich_eng###", strSimilar_eng)


                    If Not strUser = "---" Then
                        strText = strText.Replace("!!!PWD_HEAD!!!", "Kennwort")
                        strText = strText.Replace("!!!KDCENTER_HEAD!!!", "Kunden Center")
                        strText = strText.Replace("!!USER!!", strUser)
                        strText = strText.Replace("!!PWD!!", strPwd)
                    Else
                        strText = strText.Replace("!!!PWD_HEAD!!!", "")
                        strText = strText.Replace("!!!KDCENTER_HEAD!!!", "")
                        strText = strText.Replace("!!PWD!!", "")
                        strText = strText.Replace("!!USER!!", "")
                    End If

                    strText = strText.Replace("!!KDCENTER!!", "")

                    '############################
                    '# !!NAME!! -> Namen ausgeben
                    '############################

                    strText = strText.Replace("!!NAME!!", strName)

                    '# ID setzen
                    strText = strText.Replace(" !!ID!!", lvMailStatus.Items(i).SubItems(11).Text)

                    '# USERLINK Erzeugen
                    strText = strText.Replace("###LINK2USER###", My.Settings.shop_url & "/index.php?&UID=" & lvMailStatus.Items(i).SubItems(11).Text)

                    strBetreff = strBetreff.Replace("###COUNT###", i + 1)

                    clsMailing.strEmail_empfänger_email = lvMailStatus.Items(i).SubItems(2).Text


                    '# Newslettervorschau aktiv?
                    '# -> JA -> Vorschau Browser
                    '# -> NEIN -> versenden
                    If bIsPreviewNewsletter = False Then

                        '####################################
                        '# Abschicken der eMail 
                        '####################################
                        If clsMailing.setSendNewsletter(strText, strBetreff, bTestmodus) = False Then

                            'Ein Fehler bei der 0ten Email würde einen Fehler auslösen 
                            If i >= 1 Then
                                i -= 1
                            End If

                            lvMailStatus.Items(i).Selected = True
                            lvMailStatus.EnsureVisible(i)
                            frmMain.master_Message_label.Text = "!! ACHTUNG: Fehler bei " & strEmail & " | " & i + 1 & " von " & iGesLvw

                        Else

                            If clsDatenbank_modul.setNewslettereMailSended(strEmail) = True Then
                                lvMailStatus.Items(i).SubItems(6).Text = "Ja"
                            End If

                            lvMailStatus.Items(i).Selected = True
                            lvMailStatus.EnsureVisible(i)
                            frmMain.master_Message_label.Text = "Bei " & strEmail & " | " & i + 1 & " von " & iGesLvw

                            pgrMailstatusGesammt.Value = i
                        End If

                    Else
                        '####################################
                        '# >> Vorschau generieren 
                        '####################################
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\vorlagen\preview.html", strText, False)
                        If lvMailStatus.SelectedItems.Count > 0 Then
                            'Dim ExterneAnwendung As New System.Diagnostics.Process()
                            '  MsgBox("file://" & Application.StartupPath.Replace("\", "/") & "/vorlagen/preview.html")
                            'ExterneAnwendung.StartInfo.FileName = "file://" & Application.StartupPath.Replace("\", "/") & "/vorlagen/preview.html"
                            'ExterneAnwendung.Start()
                            Dim frmWeb As New frmYABE_WebBrowser
                            frmWeb.strURL = Application.StartupPath & "\vorlagen\preview.html"
                            frmWeb.Show()
                        End If

                        Exit For

                    End If

                    ' MsgBox(strEmail & " - Sprache:" & strSprache & " TExt:" & strText)
                Else
                    i -= 1
                End If

            End If ' Ist Verschickt    

        Next

        btnAbschickenNewsletter.Enabled = True
        btnMailVersandStart.Enabled = True
        btnMailVersandStart.Enabled = True
    End Function

    '############################################################
    '# >> Sprachoption auswählen 
    '############################################################
    Private Sub btnAbschickenNewsletter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbschickenNewsletter.Click

        setBludauMediaLogbuch(">> NEWSLETTER >> Newsletter starten..." & frmMain.master_Message_label.Text, "NEWSLETTER")
        Call setStartNewsletter()
        setBludauMediaLogbuch(">> NEWSLETTER >> Newsletter beendet" & frmMain.master_Message_label.Text, "NEWSLETTER")

    End Sub


    '####################################################
    '# >> Translate Editor 
    '####################################################
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        Dim frmEditor As New frmYABE_Vorlageneditor
        frmEditor.StartPosition = FormStartPosition.CenterParent
        frmEditor.iCMBIndex = cmbTranslationBereichAuswählen.Text
        frmEditor.ShowDialog()
        btnEdit.Enabled = True
    End Sub

    '####################################################
    '# >> Zu verschickten eMail Übertragen 
    '####################################################
    Private Sub VersendetEinstellenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersendetEinstellenToolStripMenuItem.Click
        Dim strEmail As String = ""

        If lvMailStatus.SelectedItems.Count > 0 Then
            strEmail = lvMailStatus.SelectedItems(0).SubItems(2).Text

            clsDatenbank_modul.setNewslettereMailSended(strEmail)
            lvMailStatus.SelectedItems(0).Remove()

            MsgBox("Benutzer '" & strEmail & "' wurde erfolgreich zu den versendeten übertragen", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub chkVerschickt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerschickt.CheckedChanged

        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvMailStatus, False)

            If chkVerschickt.Checked = False Then
                btnAbschickenNewsletter.Enabled = True
            Else
                btnAbschickenNewsletter.Enabled = False
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub chkNewsletterIsWebuser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvMailStatus, False)
            bIsLoading = False
        End If
    End Sub

    Private Sub Mailversand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menue_Mailversand.Click

    End Sub

    Private Sub VorschauAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VorschauAnzeigenToolStripMenuItem.Click
        bIsPreviewNewsletter = True
        btnAbschickenNewsletter.PerformClick()
    End Sub


    Private Sub NewsletterDeaktivierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsletterDeaktivierenToolStripMenuItem.Click
        Dim stremail As String

        If lvwKunden.SelectedItems.Count > 0 Then

            stremail = lvwKunden.SelectedItems(0).SubItems(2).Text

            If clsDatenbank_modul.getNewsletter(stremail) = "Y" Then

                If MsgBox(lvwKunden.SelectedItems(0).SubItems(2).Text & " - Newsletter manuel 'abmelden' ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call clsDatenbank_modul.setNewsletter(stremail, "N")
                End If

            Else

                If MsgBox(lvwKunden.SelectedItems(0).SubItems(2).Text & " - Newsletter manuel 'anmelden' ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call clsDatenbank_modul.setNewsletter(stremail, "Y")
                End If

            End If

        End If

    End Sub

    Private Sub KundenBis_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KundenBis.ValueChanged

    End Sub

    Private Sub ArtikelLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelLöschenToolStripMenuItem.Click
        Dim id As Integer

        If lvweBayGalerie.SelectedItems.Count > 0 Then
            If MsgBox("Möchten Sie den Artikel '" & lvweBayGalerie.SelectedItems(0).SubItems(1).Text & "' löschen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                id = lvweBayGalerie.SelectedItems(0).SubItems(0).Text
                If clsDatenbank_modul.setGalerie_delete(id) = True Then
                    MsgBox("Der Artikel '" & lvweBayGalerie.SelectedItems(0).SubItems(1).Text & "' wurde gelöscht")
                    lvweBayGalerie.SelectedItems(0).Remove()
                End If
            End If
        End If
    End Sub

    Private Sub btnNachrichtenzenter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnGetMemberMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetMemberMessages.Click

        BtnGetMemberMessages.Enabled = False

        clseBayAPI.geteBayMessages()
        BtnGetMemberMessages.Enabled = True
    End Sub

    Private Sub BtnGetAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetAccount.Click
        BtnGetAccount.Enabled = False
        clseBayAPI.geteBayRechnungen()
        BtnGetAccount.Enabled = True
    End Sub

    Private Sub OptLastInvoice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptLastInvoice.CheckedChanged
        Dim sel As Boolean = OptLastInvoice.Checked
        If sel = True Then
            DatePickInvoice.Enabled = False
            DatePickFrom.Enabled = False
            DatePickTo.Enabled = False
        End If
    End Sub

    Private Sub OptInvoiceDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptInvoiceDate.CheckedChanged
        Dim sel As Boolean = OptInvoiceDate.Checked
        If sel = True Then
            DatePickInvoice.Enabled = True
            DatePickFrom.Enabled = False
            DatePickTo.Enabled = False
        End If
    End Sub

    Private Sub OptRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptRange.CheckedChanged
        Dim sel As Boolean = OptRange.Checked
        If sel = True Then
            DatePickInvoice.Enabled = False
            DatePickFrom.Enabled = True
            DatePickTo.Enabled = True
        End If
    End Sub

    Private Sub EBayÖffnenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayÖffnenToolStripMenuItem1.Click
        If lvwEbayNachrichten.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwEbayNachrichten.SelectedItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
            ExterneAnwendung.Start()
        End If
    End Sub


    Private Sub EBayÖffnenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayÖffnenToolStripMenuItem2.Click
        If lvwEbayRechnung.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwEbayRechnung.SelectedItems(0).SubItems(3).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
            ExterneAnwendung.Start()
        End If
    End Sub

    Private Sub KundeLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KundeLöschenToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            If MsgBox("Möchten Sie den Kunden '" & lvwKunden.SelectedItems(0).SubItems(0).Text & "' auch bekannt als '" & lvwKunden.SelectedItems(0).SubItems(1).Text & "' wirklich Unwiderruflich löschen (Profil + Adresse) ID: " & lvwKunden.SelectedItems(0).SubItems(14).Text & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If lvwKunden.SelectedItems(0).SubItems(14).Text.Length > 0 Then
                    'clsDatenbank_modul.setKunden_delete(lvwKunden.SelectedItems(0).SubItems(2).Text, lvwKunden.SelectedItems(0).SubItems(1).Text)
                    clsDatenbank_modul.setKunden_deleteID(lvwKunden.SelectedItems(0).SubItems(2).Text, lvwKunden.SelectedItems(0).SubItems(14).Text)
                    lvwKunden.SelectedItems(0).Remove()
                Else
                    MessageBox.Show("Keine Profil ID gefunden", "Fehler löschen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If

    End Sub
    '##############################################
    '# >> Synchronisieren der Datenbank 
    '##############################################
    Public Function setDBSync() As Boolean
        Try
            Call clsDatenbank_modul.setSyncProfil2Adress()
            MsgBox("eBay Kunden Synchronisation ist abgeschlossen", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setDBSync")
            Return False
        End Try
    End Function
    Private Sub EBayKundenInformationenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayKundenInformationenToolStripMenuItem.Click

        If lvwKunden.SelectedItems.Count > 0 Then
            Dim frmHöchstbietender As New FrmGetUser
            frmHöchstbietender.TxtItemId.Text = clsDatenbank_modul.getLasteBayArtikel(lvwKunden.SelectedItems(0).SubItems(2).Text)
            frmHöchstbietender.TxtUserId.Text = lvwKunden.SelectedItems(0).SubItems(1).Text
            frmHöchstbietender.ShowDialog()
        End If

    End Sub

    Private Sub BestellübersichtToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestellübersichtToolStripMenuItem1.Click
        If lvwBewertungen.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwBewertungen, lvwBewertungen.SelectedItems(0).SubItems(10).Text)
        End If
    End Sub

    Private Sub KundenverlaufToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwEiSoCockpit, lvwEiSoCockpit.SelectedItems(0).SubItems(6).Text)
        End If
    End Sub

    Private Sub KundenverlaufToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KundenverlaufToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwBestellverwaltung_nach_artikel, lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(9).Text)
        End If
    End Sub

    Public Sub chkKundenFullReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKundenFullReport.CheckedChanged


        clsDatenbank_modul.bkundendetail = chkKundenFullReport.Checked
        My.Settings.eiso_gui_kunde_detailreport = chkKundenFullReport.Checked


    End Sub

    Private Sub Live_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menue_eBay_Live.Click

    End Sub

    Private Sub btnAuktionsende_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EBayAnsichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayAnsichtToolStripMenuItem.Click

    End Sub

    Private Sub chkLiveVerschickt_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If bIsLoading = False Then

            Call getLvwData(lvwEiSoCockpit)

        End If

    End Sub

    Private Function getCreate_Graph_Month(ByVal strMonth As Byte) As String

        Select Case strMonth
            Case 1
                Return "Januar"
            Case 2
                Return "Febuar"
            Case 3
                Return "März"
            Case 4
                Return "April"
            Case 5
                Return "Mai"
            Case 6
                Return "Juni"
            Case 7
                Return "Juli"
            Case 8
                Return "August"
            Case 9
                Return "September"
            Case 10
                Return "Oktober"
            Case 11
                Return "November"
            Case 12
                Return "Dezember"
        End Select
        Return "-1"
    End Function



    Private Sub CreateGraph(ByVal zgc As ZedGraphControl)

        Dim myPane As GraphPane = zgc.GraphPane
        myPane.Title.Text = cmbStatPlattform.Text & "- Umsätze"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Euro"
        myPane.GraphObjList.Clear()
        If rbStatCurve.Checked = False Then


            Dim list As New PointPairList()
            Dim rand As New Random()

            Dim i As Integer
            Dim str() As String

            For i = 0 To ListBox1.Items.Count - 2
                str = ListBox1.Items.Item(i).ToString.Split("|")
                'Dim x As Double = CDbl(i) + 1
                'Dim y As Double = rand.NextDouble() * 1000
                'Dim z As Double = i / 4.0
                list.Add(i, Val(str(0)), 0, str(0) & "€" & " - " & str(1) & "." & str(2))
            Next i

            Dim myCurve As BarItem = myPane.AddBar(cmbStatPlattform.Text & "- Umsätze", list, Color.Blue)
            Dim colors As Color() = {Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple}
            myCurve.Bar.Fill = New Fill(colors)
            myCurve.Bar.Fill.Type = FillType.GradientByZ

            myCurve.Bar.Fill.RangeMin = 0
            myCurve.Bar.Fill.RangeMax = 4

            myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(220, 220, 255), 45)
            myPane.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 225), 45)
            ' Tell ZedGraph to calculate the axis ranges
            zgc.AxisChange()


            'Dim myPane As GraphPane = zgc.GraphPane

        Else
            ' Set the titles and axis labels
            myPane.Title.Text = cmbStatPlattform.Text & "- Umsätze"
            myPane.XAxis.Title.Text = "Monat"
            myPane.YAxis.Title.Text = "Euro"

            ' Make up some data points from the Sine function
            Dim list2 = New PointPairList()
            myPane.GraphObjList.Clear()

            Dim x As Long ', y As Integer
            Dim str2() As String
            For x = 0 To ListBox1.Items.Count - 2
                str2 = ListBox1.Items.Item(x).ToString.Split("|")

                list2.Add(x, Val(str2(0)))
                'list2.Add(x, Val(Str(0)), 0, Str(0) & "€" & " - " & Str(1) & "." & Str(2))
            Next x

            ' erstellt eine blaue kurve und legt die Legende "PBX Performance" an.
            Dim myCurve2 As LineItem = myPane.AddCurve(cmbStatPlattform.Text & " - Umsätze", list2, Color.Blue, SymbolType.Diamond)


            ' füllt die area unter der blauen linie mit rot-weiss auf.
            myCurve2.Line.Fill = New Fill(Color.White, Color.Red, 45.0F)

            'malt die datenpunkte weiss aus
            myCurve2.Symbol.Fill = New Fill(Color.White)



            Const offset As Double = 1.0

            For x = 0 To ListBox1.Items.Count - 2
                Dim pt As New PointPair(myCurve2.Points(x))
                Dim text As New TextObj(pt.Y.ToString("f2"), pt.X, pt.Y + offset, CoordType.AxisXYScale, AlignH.Left, AlignV.Center)
                text.ZOrder = ZOrder.A_InFront
                text.FontSpec.Border.IsVisible = False
                text.FontSpec.Fill.IsVisible = False
                text.FontSpec.Angle = 90

                myPane.GraphObjList.Add(text)
            Next


            myPane.YAxis.Scale.MaxGrace = 0.2

            'hintergrundfarbe()
            myPane.Chart.Fill = New Fill(Color.White, Color.LightGoldenrodYellow, 45.0F)

            'hintergrundfarbe()
            myPane.Fill = New Fill(Color.White, Color.FromArgb(220, 220, 255), 45.0F)


            'Calculate the Axis Scale Ranges
            zgc.AxisChange()
            zgc.Refresh()
        End If
    End Sub

    Private Sub btnEinlesen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEinlesen.Click
        btnEinlesen.Enabled = False
        'ListBox1.Visible = True
        ListBox1.Items.Clear()
        ListBox1.Items.Add(clsDatenbank_modul.geteBayUmsatzMonth(ListBox1, cmbStatPlattform.Text)) ' Umsätze werden in die Box geschrieben

        ZedGraphControl1.GraphPane.CurveList.Clear()


        Call CreateGraph(ZedGraphControl1)

        ZedGraphControl1.Refresh()
        btnEinlesen.Enabled = True
    End Sub

    Private Sub btnGetCMSBestellungen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCMSBestellungen.Click
        btnGetCMSBestellungen.Enabled = False
        Call clsDatenbank_modul.getWebBestellungen("SELECT * FROM tbl_bestellungen ORDER BY date DESC LIMIT 0,50", lvwGetBestellungen)
        btnGetCMSBestellungen.Enabled = True
    End Sub

    Private Sub HöchstbietenderBewertungsprofilToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HöchstbietenderBewertungsprofilToolStripMenuItem1.Click
        Dim str() As String
        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            str = lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text.Split(" ")
            txtBewertungen.Text = str(0)
            btnRefreshBewertungen.PerformClick()
        End If

    End Sub

    Private Sub lnlInfopanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAuktionsende_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblBis.Text = "Bis - Auktionsende Datum"
        lblVon.Text = "Von - Auktionsende Datum"

        bIsLoading = True

        chkeBayEnde.Checked = True
        chkLiveAlle.Checked = False
        chkBuyItNow.Visible = False
        chkGebote.Visible = False
        chkEndTime.Checked = True


        Call getLvwData(lvwEiSoCockpit)
        bIsLoading = False


    End Sub

    Private Sub btnAuktionsende_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkEndTime.Checked = True Then
            lblVon.Text = "Von - Auktionsende Datum"
            lblBis.Text = "Bis - Auktionsende Datum"
        Else
            lblVon.Text = "Von - Einstelldatum Datum"
            lblBis.Text = "Bis - Einstelldatum Datum"
        End If
    End Sub


    Private Sub btnRefresh2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuktionEinlesen.MouseLeave
        If chkEndTime.Checked = True Then
            lblVon.Text = "Von - Auktionsende Datum"
            lblBis.Text = "Bis - Auktionsende Datum"
        Else
            lblVon.Text = "Von - Einstelldatum Datum"
            lblBis.Text = "Bis - Einstelldatum Datum"
        End If
    End Sub


    Private Sub DateTimePickerVon_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpCockpit_von.KeyDown
        ' Laden aktiv? 
        If bIsLoading = False Then
            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwEiSoCockpit)
                dtpCockpit_von.Focus()
            End If

        End If
    End Sub


    Private Sub txtGetSellerListSeiteVon_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGetSellerListSeiteVon.Leave
        My.Settings.api_getSellerList_page = txtGetSellerListSeiteVon.Text
        My.Settings.Save()
    End Sub


    Private Sub btnLiveStopp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiveStopp.Click

        btnLiveStopp.Enabled = False
        bStoppLiveRefresh = True
        btnAuktionEinlesen.Visible = True
        btnRefresh.Visible = True
    End Sub

    Private Sub txtGetSellerListSeiteVon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGetSellerListSeiteVon.TextChanged

        If bIsLoading = False Then
            If Not txtGetSellerListSeiteVon.Text = "0" Then
                txtGetSellerListSeiteVon.BackColor = Color.LightBlue
            Else
                txtGetSellerListSeiteVon.BackColor = Color.WhiteSmoke
            End If
        End If


    End Sub

    Private Sub DateTimePickerVon_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCockpit_von.ValueChanged

    End Sub

    Private Sub DatePickerBis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpCockpit_bis.KeyDown
        If bIsLoading = False Then
            bIsLoading = True

            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwEiSoCockpit)
                dtpCockpit_bis.Focus()
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub BestellübersichtToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestellübersichtToolStripMenuItem2.Click

        If lvMailStatus.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvMailStatus, lvMailStatus.SelectedItems(0).SubItems(2).Text)
        End If
    End Sub

    Private Sub lblVon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVon.Click

    End Sub


    Private Sub btnNewsletterReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewsletterReset.Click
        Try

            btnNewsletterReset.Enabled = False
            If MsgBox("Möchten sie einen neuen Newsletterlauf starten?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                btnNewsletterReset.Enabled = True
                Exit Sub
            End If


            If clsDatenbank_modul.setNewsletter_reset() = True Then

                MsgBox("Die Daten für den Newsletter wurden zurückgesetzt", MsgBoxStyle.Information)

            End If

            btnNewsletterReset.Enabled = True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "btnNewsletterReset")
        End Try

    End Sub

    Private Sub lvMailStatus_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvMailStatus.ColumnClick

        Try
            Call setSort(lvMailStatus, e)
            Call setStatusMessage(lvMailStatus)
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvweBayLiveList_ColumnClick")
        End Try
    End Sub

    Private Sub pgrMailstatusGesammt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pgrMailstatusGesammt.Click

    End Sub

    Private Sub KopierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Try
                Clipboard.SetText(lvwEiSoCockpit.SelectedItems(0).SubItems(6).Text)
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub chkNewsletterAlle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNewsletterAlle.CheckedChanged

        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvMailStatus, False)
            bIsLoading = False
        End If

    End Sub

    '############################################################
    '# >> CRC Check Button
    '############################################################
    Private Sub btnNewsletterCRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ExportierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportierenToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count >= 2 Then
            Call export(lvwKunden, export_targets.standard, selectModus.part)
        Else
            Call export(lvwKunden, export_targets.standard, selectModus.ganz)
        End If

    End Sub

    Private Sub ExportierenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportierenToolStripMenuItem1.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count >= 2 Then
            Call export(lvwBestellverwaltung_nach_artikel, export_targets.standard, selectModus.part)
        Else
            Call export(lvwBestellverwaltung_nach_artikel, export_targets.standard, selectModus.ganz)
        End If

    End Sub

    Private Sub ExportierenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportierenToolStripMenuItem2.Click
        If lvMailStatus.SelectedItems.Count >= 2 Then
            Call export(lvMailStatus, export_targets.standard, selectModus.part)
        Else
            Call export(lvMailStatus, export_targets.standard, selectModus.ganz)
        End If
    End Sub

    Private Sub btnTools_eBayGalerie_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTools_eBayGalerie.Click

        btnPrüfeWebArtikel.Enabled = False
        btnCheckPictures.Enabled = False
        btnTools_eBayGalerie.Enabled = False

        If clsDatenbank_modul.getEBayArtikelGalerie(lvweBayGalerie) = True Then
            MsgBox("Daten wurden eingelesen", MsgBoxStyle.Information)
        End If

        btnPrüfeWebArtikel.Enabled = True
        btnCheckPictures.Enabled = True
        btnTools_eBayGalerie.Enabled = True
    End Sub

    Private Sub btnCheckPictures_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckPictures.Click
        btnPrüfeWebArtikel.Enabled = False
        btnCheckPictures.Enabled = False
        btnTools_eBayGalerie.Enabled = False
        clsDatenbank_modul.chkCMS_picture_check(lvweBayGalerie, LblStatus)
        btnPrüfeWebArtikel.Enabled = True
        btnCheckPictures.Enabled = True
        btnTools_eBayGalerie.Enabled = True
    End Sub


    Private Sub lvwStatisticText_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwStatisticText.ColumnClick
        Call setSort(lvwStatisticText, e)
        Call setStatusMessage(lvwStatisticText)
    End Sub



    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStatUmsatz.CheckedChanged
        If bIsLoading = False Then

            If optStatUmsatz.Checked = True Then
                Call getLvwData(lvwStatisticText, False)
            End If

        End If
    End Sub

    Private Sub optStatHerkunftsland_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optStatHerkunftsland.CheckedChanged
        If bIsLoading = False Then

            If optStatHerkunftsland.Checked = True Then
                Call getLvwData(lvwStatisticText, False)
            End If

            'bIsLoading = False
        End If
    End Sub

    Private Sub ExportierenToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportierenToolStripMenuItem3.Click
        If lvwEbayNachrichten.SelectedItems.Count >= 2 Then
            Call export(lvwEbayRechnung, export_targets.standard, selectModus.part)
        Else
            Call export(lvwEbayRechnung, export_targets.standard, selectModus.ganz)
        End If

    End Sub

    Private Sub ExportierenToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportierenToolStripMenuItem4.Click
        If lvwEbayNachrichten.SelectedItems.Count >= 2 Then
            Call export(lvwEbayNachrichten, export_targets.standard, selectModus.part)
        Else
            Call export(lvwEbayNachrichten, export_targets.standard, selectModus.ganz)
        End If

    End Sub

    Private Sub chkNurKlickt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNurKlickt.CheckedChanged
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvMailStatus, False)
            bIsLoading = False
        End If
    End Sub

    Private Sub chkNewsletter_testmodus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNewsletter_testmodus.CheckedChanged

    End Sub

    Private Sub ExportierenToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportierenToolStripMenuItem5.Click

        If lvwWebArtikel.SelectedItems.Count >= 2 Then
            Call export(lvwWebArtikel, export_targets.magento, selectModus.part)
        Else
            Call export(lvwWebArtikel, export_targets.magento, selectModus.ganz)
        End If

    End Sub

    Private Sub EBayVerkaufseventsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayVerkaufseventsToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim str() As String
            Dim frmServerEvents As New FrmGetSellerEvents
            str = lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text.Split(" ")
            frmServerEvents.txtUserID.Text = str(0)
            frmServerEvents.BtnGetSellerEvents.PerformClick()
            frmServerEvents.ShowDialog()

        End If

    End Sub

    '########################################################
    '# >> Aktuallisieren der Ebay Zeit 
    '########################################################
    Private Sub tmrEbayTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEbayTime.Tick

        If My.Settings.ebay_username.ToString.Length > 0 Then
            app_eBayTime = app_eBayTime.AddSeconds("1")
            frmMain.toolDown_eBayTime.Text = app_eBayTime
        Else
            frmMain.toolDown_eBayTime.Text = Date.Now
        End If


    End Sub

    '########################################################
    '# >> Beschreibungstext erweitern
    '########################################################
    Private Sub EBayBeschreibungErweiternToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayBeschreibungErweiternToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then

            Dim frmAddDescription As New FrmAddToItemDescription
            frmAddDescription.webBrowser.Navigate(lvwEiSoCockpit.SelectedItems(0).SubItems(13).Text)
            frmAddDescription.TxtItemId.Text = lvwEiSoCockpit.SelectedItems(0).Text ' Artikel ID setzten 
            frmAddDescription.ShowDialog()

        End If
    End Sub

    Private Sub YABEKundenverlaufToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEKundenverlaufToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwEiSoCockpit, lvwEiSoCockpit.SelectedItems(0).SubItems(6).Text)
        End If
    End Sub

    Private Sub EBayCrossPromotionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayCrossPromotionToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim frmCrossPromotion As New FrmGetCrossPromotions
            frmCrossPromotion.lvwDataInput = lvwEiSoCockpit
            frmCrossPromotion.TxtItemId.Text = lvwEiSoCockpit.SelectedItems(0).Text ' Artikel ID 
            frmCrossPromotion.BtnGetCrossPromotions.PerformClick()
            frmCrossPromotion.Show()
        End If

    End Sub



    Private Sub NewsletterAnabmeldenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsletterAnabmeldenToolStripMenuItem.Click
        Dim stremail As String

        If lvMailStatus.SelectedItems.Count > 0 Then

            stremail = lvMailStatus.SelectedItems(0).SubItems(2).Text

            If clsDatenbank_modul.getNewsletter(stremail) = "Y" Then

                If MsgBox(lvMailStatus.SelectedItems(0).SubItems(2).Text & " - Newsletter manuel 'abmelden' ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call clsDatenbank_modul.setNewsletter(stremail, "N")
                End If

            Else

                If MsgBox(lvMailStatus.SelectedItems(0).SubItems(2).Text & " - Newsletter manuel 'anmelden' ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call clsDatenbank_modul.setNewsletter(stremail, "Y")
                End If

            End If

        End If
    End Sub

    Private Sub lvweBayLiveList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwEiSoCockpit.KeyDown

        If e.Control = True And e.KeyCode = Keys.P Then
            Dim clsPrint As New clsPrinting
            clsPrint.PrintOrPreviewListView(CPrintReportString.PrintPreview.Preview, lvwEiSoCockpit)
        End If

    End Sub

    Private Sub EMailVorschauAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailVorschauAnzeigenToolStripMenuItem.Click
        setSendMail(True)

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles getThreadSearch.DoWork

    End Sub

    Private Sub VersandkostenberechnungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersandkostenberechnungToolStripMenuItem.Click


        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim frmVersand As New frmBestellung_Versandkosten
            frmVersand.mModusSelect = frmBestellung_Versandkosten.mModus.live
            frmVersand.lvwDataInput = lvwEiSoCockpit
            frmVersand.Show()
        End If


    End Sub

    '#####################################################
    '# >> Daten aktualliseren 
    '#####################################################
    Public Function setColorToTxt(ByRef txt As TextBox, ByVal strStatus As String) As Boolean
        Try

            Select Case strStatus
                Case "Bezahlt"
                    txt.BackColor = My.Settings.gui_color_bestellungen_bezahlt
                Case "Verschickt"
                    txt.BackColor = My.Settings.gui_color_bestellungen_verschickt
                Case "Bestellt"
                    txt.BackColor = My.Settings.gui_color_bestellungen_bestellt
                Case "Komplett"
                    txt.BackColor = My.Settings.gui_color_bestellungen_komplett
                Case "Storniert"
                    txt.BackColor = My.Settings.gui_color_bestellungen_storniert
            End Select

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setColorToTxt")
            Return False
        End Try
    End Function

    Private Sub lvwLiveAnsicht_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lvwLiveAnsicht.Opening
        '##################################################
        '# >> contextmenü enabled / disable
        '##################################################
        If lvwEiSoCockpit.SelectedItems.Count > 0 Then


            If lvwEiSoCockpit.SelectedItems(0).SubItems(20).Text.Length > 2 Then
                YABEKundenverlaufToolStripMenuItem.Text = "&YABE -> Kundenprofil: '" & lvwEiSoCockpit.SelectedItems(0).SubItems(20).Text & "'"
            Else
                YABEKundenverlaufToolStripMenuItem.Text = "&YABE -> Kundenprofil: '" & lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text & "'"
            End If




            Select Case lvwEiSoCockpit.SelectedItems(0).SubItems(17).Text
                Case "eBay"

                    '# Immer an 
                    EBayVerkaufseventsToolStripMenuItem.Visible = True
                    tsmeBayLive_Detailansicht.Visible = True
                    EBayVerkaufseventsToolStripMenuItem.Visible = True
                    EBayBeschreibungErweiternToolStripMenuItem.Visible = True
                    ArtikelBeendenToolStripMenuItem.Visible = True
                    EBayCrossPromotionToolStripMenuItem.Visible = True
                    ToolStripSeparator15.Visible = True

                    If lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text = "---" Or lvwEiSoCockpit.SelectedItems(0).SubItems(5).Text = "" Then

                        HöchstbietenderToolStripMenuItem.Visible = False
                        BietverlaufToolStripMenuItem.Visible = False
                        EMailExternesProgrammToolStripMenuItem.Visible = False
                        EMailExternesProgrammToolStripMenuItem.Visible = False
                        YABEKundenverlaufToolStripMenuItem.Visible = False
                        VersandkostenberechnungToolStripMenuItem.Visible = False
                        EBayVerkaufseventsToolStripMenuItem.Visible = False
                        EMailVorschauAnzeigenToolStripMenuItem.Visible = False
                        HöchstbietenderBewertungsprofilToolStripMenuItem1.Visible = False
                        HöchstbietenderToolStripMenuItem.Visible = False
                        BietverlaufToolStripMenuItem.Visible = False

                        If lvwEiSoCockpit.SelectedItems(0).SubItems(7).Text = "Active" Then
                            VersandkostenberechnungToolStripMenuItem.Visible = False
                            IsSendToolStripMenuItem.Visible = False
                            ArtikelBeendenToolStripMenuItem.Visible = True
                            EMailVorschauAnzeigenToolStripMenuItem.Visible = False
                            EMailExternesProgrammToolStripMenuItem.Visible = False
                        Else
                            VersandkostenberechnungToolStripMenuItem.Visible = True
                            IsSendToolStripMenuItem.Visible = True
                            ArtikelBeendenToolStripMenuItem.Visible = False
                            ArtikelBeendenToolStripMenuItem.Visible = False
                            EMailVorschauAnzeigenToolStripMenuItem.Visible = True
                            EMailExternesProgrammToolStripMenuItem.Visible = True
                        End If



                    Else

                        YABEKundenverlaufToolStripMenuItem.Visible = True
                        HöchstbietenderToolStripMenuItem.Visible = True
                        EMailExternesProgrammToolStripMenuItem.Visible = True
                        BietverlaufToolStripMenuItem.Visible = True
                        ArtikelBeendenToolStripMenuItem.Visible = True
                        EMailExternesProgrammToolStripMenuItem.Visible = True
                        VersandkostenberechnungToolStripMenuItem.Visible = True
                        EBayVerkaufseventsToolStripMenuItem.Visible = True
                        EMailVorschauAnzeigenToolStripMenuItem.Visible = True

                        If lvwEiSoCockpit.SelectedItems(0).SubItems(7).Text = "Active" Then
                            ' VersandkostenberechnungToolStripMenuItem.Visible = False
                            IsSendToolStripMenuItem.Visible = False
                            EMailVorschauAnzeigenToolStripMenuItem.Visible = False
                            EMailExternesProgrammToolStripMenuItem.Visible = False
                        Else
                            VersandkostenberechnungToolStripMenuItem.Visible = True
                            IsSendToolStripMenuItem.Visible = True
                            ArtikelBeendenToolStripMenuItem.Visible = False
                            EMailVorschauAnzeigenToolStripMenuItem.Visible = True
                            EMailExternesProgrammToolStripMenuItem.Visible = True
                        End If

                    End If


                Case Else

                    EBayVerkaufseventsToolStripMenuItem.Visible = False
                    tsmeBayLive_Detailansicht.Visible = False
                    HöchstbietenderToolStripMenuItem.Visible = False
                    EBayBeschreibungErweiternToolStripMenuItem.Visible = False
                    ArtikelBeendenToolStripMenuItem.Visible = False
                    EBayCrossPromotionToolStripMenuItem.Visible = False
                    HöchstbietenderBewertungsprofilToolStripMenuItem1.Visible = False
                    BietverlaufToolStripMenuItem.Visible = False

                    ToolStripSeparator15.Visible = False
                    If lvwEiSoCockpit.SelectedItems(0).SubItems(7).Text = "Active" Then
                        VersandkostenberechnungToolStripMenuItem.Visible = False
                        IsSendToolStripMenuItem.Visible = False
                        EMailVorschauAnzeigenToolStripMenuItem.Visible = False
                        EMailVorschauAnzeigenToolStripMenuItem.Visible = False
                        EMailExternesProgrammToolStripMenuItem.Visible = False
                    Else
                        VersandkostenberechnungToolStripMenuItem.Visible = True
                        EMailVorschauAnzeigenToolStripMenuItem.Visible = True
                        IsSendToolStripMenuItem.Visible = True
                        EMailVorschauAnzeigenToolStripMenuItem.Visible = True
                        EMailExternesProgrammToolStripMenuItem.Visible = True
                    End If

            End Select

        Else
            HöchstbietenderToolStripMenuItem.Visible = False
            BietverlaufToolStripMenuItem.Visible = False
            EMailExternesProgrammToolStripMenuItem.Visible = False
            ArtikelBeendenToolStripMenuItem.Visible = False
            IsSendToolStripMenuItem.Visible = False
            YABEKundenverlaufToolStripMenuItem.Visible = False
            VersandkostenberechnungToolStripMenuItem.Visible = False
            IsSendToolStripMenuItem.Visible = False
            EBayVerkaufseventsToolStripMenuItem.Visible = False
            EMailVorschauAnzeigenToolStripMenuItem.Visible = False

            '  lvwLiveAnsicht.Dispose()
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub optTopKundenListe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTopKundenListe.CheckedChanged

        If bIsLoading = False Then

            If optTopKundenListe.Checked = True Then
                Call getLvwData(lvwStatisticText, False)
            End If

        End If

    End Sub

    Private Sub optMeistegebote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMeistegebote.CheckedChanged
        If bIsLoading = False Then

            If optMeistegebote.Checked = True Then
                Call getLvwData(lvwStatisticText, False)
            End If
        End If

    End Sub

    Private Sub optTeuersterArtikel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTeuersterArtikel.CheckedChanged
        If bIsLoading = False Then

            If optTeuersterArtikel.Checked = True Then
                Call getLvwData(lvwStatisticText, False)
            End If

        End If

    End Sub

    Private Sub optMeisteStaedte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMeisteStaedte.CheckedChanged
        If bIsLoading = False Then

            If optMeisteStaedte.Checked = True Then
                Call getLvwData(lvwStatisticText, False)
            End If

        End If
    End Sub

    Private Sub tmrEbayZeitWarten_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEbayZeitWarten.Tick
        app_eBayTime = Convert.ToDateTime(clseBayAPI.geteBayTime()).AddHours(1)
        tmrEbayTime.Enabled = True
        tmrEbayZeitWarten.Enabled = False
    End Sub

    Private Sub btnVerlaufStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneBayAdressenHolen.Click


        If Not (MsgBox("Möchten Sie die Transaktiondaten von eBay vom " & eBayHistoryVon.Text & " bis zum " & eBayHistoryBis.Text & " holen ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Zeitraum in Ordnung") = MsgBoxResult.Yes) Then
            Exit Sub
        Else
            Call getSellerTransaction(eBayHistoryVon, eBayHistoryBis)
            btnBestellungen_abrufen.PerformClick()
        End If
    End Sub

    Private Sub eBayGeschichte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menue_bestellverlauf.Click

    End Sub

    Private Sub HöchstbietenderBewertungsprofilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HöchstbietenderBewertungsprofilToolStripMenuItem.Click
        Dim str() As String

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmHöchstbietender As New FrmGetUser
            frmHöchstbietender.TxtItemId.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text
            str = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(2).Text.Split(" ")
            frmHöchstbietender.TxtUserId.Text = str(0)
            frmHöchstbietender.ShowDialog()
        End If

    End Sub


    Private Sub chkDebug_email_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDebug_email.CheckedChanged

        If Me.bIsLoading = False Then
            frmMain.setChangeDebugModus()
        End If

    End Sub


    Private Sub ExportDelcampeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportDelcampeToolStripMenuItem.Click

        'If lvwWebArtikel.SelectedItems.Count >= 2 Then
        Call export(lvwWebArtikel, export_targets.delcampe, selectModus.part)
        'Else
        'Call export(lvwWebArtikel, export_targets.delcampe, selectModus.ganz)
        'End If

    End Sub

    Private Sub ExportStandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportStandardToolStripMenuItem.Click

        If lvwWebArtikel.SelectedItems.Count >= 2 Then
            Call export(lvwWebArtikel, export_targets.standard, selectModus.part)
        Else
            Call export(lvwWebArtikel, export_targets.standard, selectModus.ganz)
        End If

    End Sub

    Private Sub DelcampeKategorieIDZuweisenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeKategorieIDZuweisenToolStripMenuItem.Click

        If lvwMenue.SelectedItems.Count > 0 Then
            Dim frmDialog As New frmDelcampeIDZuweisung
            frmDialog.bModus_select = frmDelcampeIDZuweisung.bModus.delcampe
            frmDialog.iCMSMenueID = lvwMenue.SelectedItems(0).Text
            frmDialog.strKategorieName = lvwMenue.SelectedItems(0).SubItems(1).Text
            frmDialog.txtDelcampeID.Text = lvwMenue.SelectedItems(0).SubItems(3).Text
            frmDialog.Show(Me)
        Else
            MessageBox.Show("Bitte eine Kategorie auswählen im Menü links")
        End If


    End Sub

    Private Sub lvwWebArtikel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvwWebArtikel.KeyPress
        Dim cWechsel As Char = "w"
        If e.KeyChar = cWechsel Then
            setChangeArtikelDatenbank_view()
        End If
    End Sub

    Private Sub lvwWebArtikel_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwWebArtikel.MouseDoubleClick
        '# 
        If lvwWebArtikel.SelectedItems.Count > 0 Then

            If chkArtikeldatenbank_edit.Checked = False Then
                Dim frmWeb As New frmYABE_WebBrowser
                frmWeb.lvwDataView = lvwWebArtikel
                frmWeb.Show(Me)
            Else
                Dim frmCMSChange As New frmCMS_change_item

                If Not IsNumeric(lvwWebArtikel.SelectedItems(0).Text) = True Then
                    frmCMSChange.bIsNew = True
                End If
                If lvwMenue.SelectedItems.Count > 0 Then
                    frmCMSChange.setKategorie = lvwMenue.SelectedItems(0).SubItems(0).Text
                End If

                frmCMSChange.Show()
            End If

        End If

    End Sub

    Private Sub lvweBayHistory_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwBestellverwaltung_nach_artikel.DoubleClick

    End Sub

    Private Sub lvwBewertungen_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwBewertungen.MouseDoubleClick
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwBestellverwaltung_nach_artikel, "")
        End If
    End Sub

    Private Sub lvwKunden_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwKunden.MouseDoubleClick
        If lvwKunden.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwKunden, lvwKunden.SelectedItems(0).SubItems(2).Text)
        End If
    End Sub

    Private Sub lvMailStatus_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvMailStatus.MouseDoubleClick
        If lvMailStatus.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvMailStatus, lvMailStatus.SelectedItems(0).SubItems(2).Text)
        End If
    End Sub

    Private Sub btnMeineBayÖffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeineBayÖffnen.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = "http://my.ebay.de/ws/eBayISAPI.dll?MyEbayBeta&gbh=1&MyEbay=&guest=1"
        ExterneAnwendung.Start()
    End Sub

    Private Sub chkCMSEnglisch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lvwMenue.SelectedItems.Count > 0 And bIsLoading = False Then

            Dim iId As Integer = 0
            bIsLoading = True

            iId = lvwMenue.SelectedItems(0).SubItems(0).Text

            Dim iDelcampeID As Integer = lvwMenue.SelectedItems(0).SubItems(3).Text

            lvwWebArtikel.Items.Clear()
            Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Kategorie_neo='" & iId & "' AND bestellt=0 ORDER BY Beschreibung ASC", lvwWebArtikel, lvwMenue, iDelcampeID, , , , bilder_history)
            bIsLoading = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If lvwMenue.SelectedItems.Count > 0 And bIsLoading = False Then
            Dim iId As Integer = 0
            bIsLoading = True

            iId = lvwMenue.SelectedItems(0).SubItems(0).Text
            Dim iDelcampeID As Integer = lvwMenue.SelectedItems(0).SubItems(3).Text

            lvwWebArtikel.Items.Clear()
            Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Kategorie_neo='" & iId & "' AND bestellt=0 ORDER BY Beschreibung ASC", lvwWebArtikel, lvwMenue, iDelcampeID, , , , bilder_history)
            bIsLoading = False

        End If
    End Sub

    Private Sub optCMSToogleKategorie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCMSToogleKategorie.CheckedChanged

        If optCMSToogleKategorie.Checked = True Then
            cms_splitcontainer.Panel1Collapsed = False
            cms_splitcontainer.Panel2Collapsed = True
            lvwWebArtikel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End If

    End Sub

    Private Sub optCMSToogleBoth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCMSToogleBoth.CheckedChanged

        If bIsLoading = False Then
            If optCMSToogleBoth.Checked = True Then
                cms_splitcontainer.Panel1Collapsed = False
                cms_splitcontainer.Panel2Collapsed = False
                lvwWebArtikel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                lvwMenue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            End If

        End If

    End Sub

    Private Sub optCMSToogleArtikel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCMSToogleArtikel.CheckedChanged
        If optCMSToogleArtikel.Checked = True Then
            cms_splitcontainer.Panel1Collapsed = True
            cms_splitcontainer.Panel2Collapsed = False
            lvwMenue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End If
    End Sub

    Private Sub setRefreshMenueList(Optional ByVal bSetArtikelAnzahl As Boolean = False)
        Dim index As Integer = -1
        Try
            lvwMenue.Enabled = False

            If lvwMenue.Items.Count > 0 Then
                index = lvwMenue.SelectedItems(0).Index
            End If

            clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", lvwMenue, cmbSprache_Artikeldatenbank.Text, bSetArtikelAnzahl)

            If index > -1 Then
                lvwMenue.Items(index).Selected = True
                lvwMenue.Items(index).EnsureVisible()
            End If

            lvwMenue.Enabled = True
        Catch ex As Exception
            lvwMenue.Enabled = True
        End Try
    End Sub
    Private Sub RefreshKategorielisteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshKategorielisteToolStripMenuItem.Click
        Call setRefreshMenueList()

        Try
            lvwMenue.SelectedItems(0).EnsureVisible()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebEBayBildAnsehenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebEBayBildAnsehenToolStripMenuItem.Click

        '# 
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim frmWeb As New frmYABE_WebBrowser
            frmWeb.lvwDataView = lvwWebArtikel
            frmWeb.webMain.Navigate(lvwWebArtikel.SelectedItems(0).SubItems(3).Text)
            frmWeb.Show()
        End If

    End Sub

    '########################################################
    '# >> Artikel und Bilder löschen 
    '########################################################
    Public Function setShopDeleteItem() As Boolean
        Try
            Dim strArtikel As String = ""
            If lvwWebArtikel.SelectedItems.Count > 0 Then
                strArtikel = lvwWebArtikel.SelectedItems(0).SubItems(1).Text
                If MsgBox("Möchten Sie wirklich den Artikel '" & strArtikel & "' und seine Bilder löschen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    If setDeletePictures(lvwWebArtikel.SelectedItems(0).SubItems(3).Text, True) = True Then
                        If clsDatenbank_modul.getCMS_items_delete("DELETE FROM tblGes WHERE ID=" & lvwWebArtikel.SelectedItems(0).Text) = True Then
                            lvwWebArtikel.SelectedItems(0).Remove()
                        Else
                            MsgBox("Probleme beim Löschen des Artikels auf dem Server", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Probleme beim Löschen der Bilder auf dem Server", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            Call debug_message(ex, "setShopDeleteItem")
            Return False
        End Try
    End Function


    Private Sub ArtikelLöschenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelLöschenToolStripMenuItem1.Click
        Call setShopDeleteItem()
    End Sub

    '############################################################
    '# >> Bilder löschen 
    '############################################################
    Public Function setDeletePictures(ByVal strBild As String, ByVal bMessage As Boolean) As Boolean
        Try
            Call getHTTPResponseMessage(My.Settings.shop_url + "/yabe_picture_delete.php?picture=" + strBild & "&usr=" & My.Settings.yabe_username, mgetUpdaterMessage.setShopDeletePictures, bMessage)
            frmMain.master_Message_label.Text = "Lösche Bilder '" & strBild & "'"
            Return True
        Catch ex As Exception
            Call debug_message(ex, "setDeletePictures")
            Return True
        End Try
    End Function



    Private Sub WebDelcampeAnsichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            ExterneAnwendung.StartInfo.FileName = "http://delcampe.de/page/item/id,0063943005,language,G.html"
            ExterneAnwendung.Start()
        End If
    End Sub

    Private Sub ExportDelcampeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportDelcampeToolStripMenuItem1.Click
        Call export(lvwWebArtikel, export_targets.delcampe)
    End Sub

    Private Sub ExportMagentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportMagentoToolStripMenuItem.Click
        Call export(lvwWebArtikel, export_targets.magento)
    End Sub

    Private Sub ExportStandardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportStandardToolStripMenuItem1.Click
        Call export(lvwWebArtikel, export_targets.standard)
    End Sub

    Private Sub UmbennenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbennenToolStripMenuItem.Click

        If lvwMenue.SelectedItems.Count > 0 Then

            Dim strData As String = InputBox("Bitte neuen Kategorienamen eingeben für '" & lvwMenue.SelectedItems(0).SubItems(1).Text.Replace(">> ", "") & "' eingeben", "Kategorie umbenennen", lvwMenue.SelectedItems(0).SubItems(1).Text.Replace(">> ", ""))

            If Not strData Is "" Then
                If Not strData = lvwMenue.SelectedItems(0).SubItems(1).Text Then
                    Dim strSprache As String = clsDatenbank_modul.getTranslate_l18n_mapping(lvwMenueSprache)

                    If clsDatenbank_modul.setCMSMenueName(strData, lvwMenue.SelectedItems(0).Text, strSprache) = True Then
                        lvwMenue.SelectedItems(0).Text = strData

                        '# MENÜ NEU GENERIEREN
                        Dim strShopURL As String
                        If My.Settings.shop_eiso_shopaktiv = True Then
                            strShopURL = My.Settings.shop_url_eiso
                        Else
                            strShopURL = My.Settings.shop_url
                        End If
                        If getHTTPResponseMessage(strShopURL & "/yabe_menue_gen.php?mod=ADD_ALL&KEY=" & My.Settings.yabe_keycode & "&sprache=" & strSprache & "&usr=" & My.Settings.yabe_username, mgetUpdaterMessage.setMenue, False) = False Then
                            MsgBox("Es gab einen Fehler beim Erzeugen des Shop Menüs", MsgBoxStyle.Exclamation)
                        Else
                            Call setRefreshMenueList()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub MagentoKategorieIDZuweisenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentoKategorieIDZuweisenToolStripMenuItem.Click
        If lvwMenue.SelectedItems.Count > 0 Then
            Dim frmDialog As New frmDelcampeIDZuweisung
            frmDialog.bModus_select = frmDelcampeIDZuweisung.bModus.magento
            frmDialog.iCMSMenueID = lvwMenue.SelectedItems(0).Text
            frmDialog.strKategorieName = lvwMenue.SelectedItems(0).SubItems(1).Text
            frmDialog.txtDelcampeID.Text = lvwMenue.SelectedItems(0).SubItems(4).Text
            frmDialog.Show(Me)
        Else
            MessageBox.Show("Bitte eine Kategorie auswählen im Menü links")
        End If
    End Sub

    Private Sub btnPrüfeWebArtikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrüfeWebArtikel.Click
        btnPrüfeWebArtikel.Enabled = False
        btnCheckPictures.Enabled = False
        btnTools_eBayGalerie.Enabled = False
        clsDatenbank_modul.chkCMS_picture_check(lvwWebArtikel, LblStatus, lvweBayGalerie)
        btnPrüfeWebArtikel.Enabled = True
        btnCheckPictures.Enabled = True
        btnTools_eBayGalerie.Enabled = True
    End Sub

    Private Sub ToolBilderprüfenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBilderprüfenToolStripMenuItem.Click
        tab_verwaltung.SelectedIndex = 2
        btnPrüfeWebArtikel.PerformClick()

    End Sub




    Private Sub frmAuktionmanagement_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ' WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DelcampeKategorieIDZuweisenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeKategorieIDZuweisenToolStripMenuItem1.Click

        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim frmDialog As New frmDelcampeIDZuweisung
            frmDialog.bModus_select = frmDelcampeIDZuweisung.bModus.delcampe
            frmDialog.bMulti_select = frmDelcampeIDZuweisung.bMultiSelect.multiselect
            frmDialog.iCMSMenueID = lvwWebArtikel.SelectedItems(0).Text
            'frmDialog.strKategorieName = lvwMenue.SelectedItems(0).SubItems(1).Text
            frmDialog.lvwData_multiselect = lvwWebArtikel
            frmDialog.txtDelcampeID.Text = lvwWebArtikel.SelectedItems(0).SubItems(5).Text
            frmDialog.Show(Me)
        Else
            MessageBox.Show("Bitte eine Kategorie auswählen im Kategorie links", "YABE Kategorie auswählen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub lvwWebArtikel_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwWebArtikel.ColumnClick
        Try
            Call setSort(lvwWebArtikel, e)
            Call setStatusMessage(lvwWebArtikel)
        Catch ex As Exception
            MessageBox.Show("Bitte eine Kategorie auswählen im Kategorie links", "YABE Kategorie auswählen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Public Function setShopLVW_refresh() As Boolean

        Dim iDelcampeID As Integer = -2
        Dim iSel As Integer = -1
        Dim strHauptkategorie As String = ""
        Dim iId As Integer = 0
        Try


            Try
                iSel = lvwWebArtikel.SelectedItems(0).Index
            Catch ex As Exception

            End Try

            iId = lvwMenue.SelectedItems(0).SubItems(0).Text

            If Not cmbArtikelStatus.Text = "Kategorie" Then
                '# Sprachwechsel
                Call setcmbArtikelStatus_data()
            Else
                '# Menü Aktionen 
                lvwWebArtikel.Items.Clear()
                '# ALLE KATEGORIEN 
                If iId = -1 Then

                    If MsgBox("Möchten Sie wirklich alle Artikel anzeigen lassen?" + vbCrLf + "Dies kann unter Umständen sehr lange dauern", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        Call clsDatenbank_modul.getEiSoItems("SELECT  tbl_menue.delcampe_id as delcampe_menue_id,tbl_menue.export_magento as magento_menue_id ,tblGes.*  FROM tbl_menue LEFT JOIN tblGes ON tbl_menue.iD = tblGes.Kategorie_neo WHERE  tblGes.Bestellt = 0", lvwWebArtikel, lvwMenue, iDelcampeID, -3, , , bilder_history)
                        Call setStatusMessage(lvwWebArtikel)
                        cmbArtikelStatus.SelectedIndex = 0
                    End If
                    '# IMPORTER
                ElseIf iId = -2 Then
                    Call clsDatenbank_modul.getEiSoItems("SELECT  * FROM tbl_menue RIGHT JOIN tblGes ON tbl_menue.iD = tblGes.Kategorie_neo WHERE  tblGes.Bestellt = 3 AND Kategorie_neo is Null", lvwWebArtikel, lvwMenue, iDelcampeID, -2, , , bilder_history)
                    Call setStatusMessage(lvwWebArtikel)
                    'cmbArtikelStatus.SelectedIndex = 0
                Else


                    Try
                        iDelcampeID = lvwMenue.SelectedItems(0).SubItems(3).Text
                        strHauptkategorie = lvwMenue.SelectedItems(0).SubItems(5).Text


                    Catch ex As Exception
                        strHauptkategorie = -9
                    End Try


                    lvwWebArtikel.Items.Clear()
                    Call clsDatenbank_modul.getEiSoItems("SELECT * FROM tblGes WHERE Kategorie_neo='" & iId & "' AND bestellt=0 ORDER BY Datum DESC", lvwWebArtikel, lvwMenue, iDelcampeID, strHauptkategorie, lvwMenue.SelectedItems(0).SubItems(4).Text, lvwMenue.SelectedItems(0).SubItems(7).Text, bilder_history)
                    lvwWebArtikel.Focus()
                    Call setStatusMessage(lvwWebArtikel)

                    ' cmbArtikelStatus.SelectedIndex = 0


                    If chkShopUpdateItemCount.Checked = True Then
                        If lvwMenue.SelectedItems.Count > 0 Then
                            Call clsDatenbank_modul.setCMSItem_count(lvwMenue.SelectedItems(0).Text, lvwWebArtikel.Items.Count)
                        End If
                    End If

                End If

                If iSel > 0 Then
                    lvwWebArtikel.Items(iSel).Selected = True
                    lvwWebArtikel.Items(iSel).EnsureVisible()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Bitte eine Kategorie auswählen im Kategorie links", "YABE Kategorie auswählen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Sub AktuallisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktuallisierenToolStripMenuItem.Click

        Call setShopLVW_refresh()


    End Sub

    Private Sub cmseBayHistory_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsEiSoBestellungen.Opening

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

            KundenverlaufToolStripMenuItem.Text = "&YABE -> Kundenverlauf: '" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(1).Text

            If lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(9).Text = "" Then
                HöchstbietenderBewertungsprofilToolStripMenuItem.Visible = False
                BietverlaufToolStripMenuItem1.Visible = False
                ToolStripSeparator10.Visible = False

                SucheBestellungenToolStripMenuItem.Visible = False
                SucheKundeToolStripMenuItem.Visible = False
                SucheArtikelToolStripMenuItem.Visible = False
                KundenverlaufToolStripMenuItem.Visible = False
                BestellungsstatusToolStripMenuItem.Visible = False
                YABEArtikelansichtToolStripMenuItem.Visible = True
                ToolStripSeparator12.Visible = False
                ZuordnungArtikelKundeToolStripMenuItem.Visible = False
                EBayAuktionArtikeldetialsToolStripMenuItem.Visible = False
                YABEArtikelübernahmeToolStripMenuItem.Visible = True
                YABERechnungsdruckToolStripMenuItem.Visible = False
                YABEBestellverlaufProKundenToolStripMenuItem.Visible = False
            Else

                YABEBestellverlaufProKundenToolStripMenuItem.Visible = True
                YABERechnungsdruckToolStripMenuItem.Visible = True
                SucheBestellungenToolStripMenuItem.Visible = True
                SucheKundeToolStripMenuItem.Visible = True
                SucheArtikelToolStripMenuItem.Visible = True
                KundenverlaufToolStripMenuItem.Visible = True
                BestellungsstatusToolStripMenuItem.Visible = True
                ToolStripSeparator12.Visible = True
                ZuordnungArtikelKundeToolStripMenuItem.Visible = True
                YABEArtikelübernahmeToolStripMenuItem.Visible = True
                YABEArtikelansichtToolStripMenuItem.Visible = True

                Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text
                    Case "eBay"
                        HöchstbietenderBewertungsprofilToolStripMenuItem.Visible = True
                        BietverlaufToolStripMenuItem1.Visible = True

                        ToolStripSeparator10.Visible = True
                        ToolStripSeparator34.Visible = True

                        ' delcampe 
                        ToolStripSeparator33.Visible = False
                        DelcampeArtikelansichtToolStripMenuItem.Visible = False
                        DelcampeVersandkostenToolStripMenuItem.Visible = False
                        DelcampeBewertungenToolStripMenuItem.Visible = False

                        ' eBay 
                        EBayAuktionArtikeldetialsToolStripMenuItem.Visible = True
                        EBayBewertungenToolStripMenuItem.Visible = True
                        EBayVersandkostenToolStripMenuItem.Visible = True
                        EBayArtikelansichtToolStripMenuItem.Visible = True
                        DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Visible = False

                        MagentoToolStripMenuItem1.Visible = False
                        DToolStripMenuItem.Visible = False
                        ShopToolStripMenuItem.Visible = False
                    Case "delcampe"
                        HöchstbietenderBewertungsprofilToolStripMenuItem.Visible = False
                        BietverlaufToolStripMenuItem1.Visible = False

                        ToolStripSeparator10.Visible = False
                        ToolStripSeparator33.Visible = False

                        ' Delcampe (web)
                        DelcampeArtikelansichtToolStripMenuItem.Visible = True
                        DelcampeVersandkostenToolStripMenuItem.Visible = True
                        DelcampeBewertungenToolStripMenuItem.Visible = True

                        ' eBay 
                        EBayAuktionArtikeldetialsToolStripMenuItem.Visible = False
                        EBayAuktionArtikeldetialsToolStripMenuItem.Visible = False
                        EBayBewertungenToolStripMenuItem.Visible = False
                        EBayVersandkostenToolStripMenuItem.Visible = False
                        EBayArtikelansichtToolStripMenuItem.Visible = False

                        If My.Settings.yabe_magento_aktiv = True Then
                            MagentoToolStripMenuItem1.Visible = True
                        Else
                            MagentoToolStripMenuItem1.Visible = False
                        End If

                        DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Visible = True
                        DToolStripMenuItem.Visible = True
                        ShopToolStripMenuItem.Visible = True
                    Case Else
                        HöchstbietenderBewertungsprofilToolStripMenuItem.Visible = False
                        BietverlaufToolStripMenuItem1.Visible = False

                        ' eBay
                        EBayAuktionArtikeldetialsToolStripMenuItem.Visible = False
                        EBayAuktionArtikeldetialsToolStripMenuItem.Visible = False
                        EBayBewertungenToolStripMenuItem.Visible = False
                        EBayVersandkostenToolStripMenuItem.Visible = False
                        EBayArtikelansichtToolStripMenuItem.Visible = False

                        ' Delcampe 
                        DelcampeArtikelansichtToolStripMenuItem.Visible = False
                        DelcampeVersandkostenToolStripMenuItem.Visible = False
                        DelcampeBewertungenToolStripMenuItem.Visible = False
                        YABEArtikelübernahmeToolStripMenuItem.Visible = True
                        DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Visible = False
                        ToolStripSeparator34.Visible = False
                        ToolStripSeparator33.Visible = False
                        ToolStripSeparator10.Visible = False

                        If My.Settings.yabe_magento_aktiv = True Then
                            MagentoToolStripMenuItem1.Visible = True
                        Else
                            MagentoToolStripMenuItem1.Visible = False
                        End If

                        DToolStripMenuItem.Visible = True
                        ShopToolStripMenuItem.Visible = True
                End Select

            End If

        End If

    End Sub

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            If Not lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text = "" Then

                Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text
                    Case "CMS"

                        If MessageBox.Show("Wollen Sie die '" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text & "' Bestellung vom Kunden '" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(1).Text & vbCrLf & "Artikel: '" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(4).Text & "' wirklich unwiderruflich löschen?", "Bestellung löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            If clsDatenbank_modul.setDeleteReal(lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text, "yabe_auction_list_history") = True Then
                                lvwBestellverwaltung_nach_artikel.SelectedItems(0).Remove()
                            End If

                        End If
                    Case Else
                        If MessageBox.Show("Wollen Sie die '" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text & "' Bestellung vom Kunden '" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(1).Text & vbCrLf & "Artikel: '" & lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(4).Text & "' wirklich unwiderruflich löschen?", "Bestellung löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            If clsDatenbank_modul.setDeleteReal(lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text, "yabe_auction_list_history") = True Then
                                lvwBestellverwaltung_nach_artikel.SelectedItems(0).Remove()
                            End If

                        Else
                            ' nix
                        End If
                End Select

            End If


        End If

    End Sub

    Private Sub chkKundenHeute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKundenHeute.CheckedChanged

        If bIsLoading = False Then
            If chkKundenHeute.Checked = True Then
                KundenVon.Value = Date.Now
                bIsLoading = True
                Call getLvwData(lvwKunden)

                bIsLoading = False

                My.Settings.gui_kunden_heute = chkKundenHeute.Checked
                My.Settings.Save()

            Else
                KundenVon.Value = Date.Now.AddDays(-My.Settings.gui_dauer_kunden)
                KundenBis.Value = Date.Now.AddDays(1)
                My.Settings.gui_kunden_heute = chkKundenHeute.Checked
                My.Settings.Save()
                Call getLvwData(lvwKunden)
            End If
        Else
            If chkKundenHeute.Checked = True Then
                KundenVon.Value = Date.Now
                My.Settings.gui_kunden_heute = chkKundenHeute.Checked
                My.Settings.Save()
            Else
                KundenVon.Value = Date.Now.AddDays(-My.Settings.gui_dauer_kunden)
                KundenBis.Value = Date.Now.AddDays(1)
                My.Settings.gui_kunden_heute = chkKundenHeute.Checked
                My.Settings.Save()
            End If
            My.Settings.gui_kunden_heute = chkKundenHeute.Checked
            My.Settings.Save()
        End If

    End Sub


    ' Diese Funktion stammt aus dem Tipp:
    ' Doppelte Werte bei Ausgabe eines Arrays unterdrücken
    Private Function DestinctArray(Of T)(ByVal arr() As T) As T()
        Dim tList As New List(Of T)
        For Each i As T In arr
            If Not tList.Contains(i) Then
                tList.Add(i)
            End If
        Next
        Return tList.ToArray
    End Function

    Private Sub chkBestellungVersand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwBestellverwaltung_nach_artikel)
            bIsLoading = False
        End If
    End Sub

    Private Sub AnsichtAktuallisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnsichtAktuallisierenToolStripMenuItem.Click
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwBewertungen)
            bIsLoading = False
        End If
    End Sub

    Private Sub AnsichtAktuallisierenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnsichtAktuallisierenToolStripMenuItem1.Click
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwBestellverwaltung_nach_artikel)
            bIsLoading = False
        End If
    End Sub



    Private Sub ZuordnungArtikelKundeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZuordnungArtikelKundeToolStripMenuItem1.Click

    End Sub

    '#######################################################################
    '# >> Sperren der Oberfläche beim Update 
    '#######################################################################
    Private Function setLookForm(ByVal lvw As ListView, ByVal bModus As Boolean) As Boolean
        Try
            ' Global Suchen aktiv - inaktiv
            txtSuchen.Enabled = bModus
            btnSuchen.Enabled = bModus

            Select Case lvw.Name
                Case "lvwEiSoCockpit"

                    chkLiveAlle.Enabled = bModus
                    chkGebote.Enabled = bModus
                    chkeBayEnde.Enabled = bModus
                    chkBuyItNow.Enabled = bModus
                    chkLiveZeitfilter.Enabled = bModus
                    chkEndTime.Enabled = bModus
                    chkAutomatischerModus.Enabled = bModus
                    dtpCockpit_von.Enabled = bModus
                    dtpCockpit_bis.Enabled = bModus
                    txtGetSellerListSeiteVon.Enabled = bModus
                    btnAuktionEinlesen.Enabled = bModus
                    chkGeboteOhne.Enabled = bModus
                    btnQuickSync.Enabled = bModus
                    chkMitWebgalerie.Enabled = bModus

                Case "lvwKunden"
                    btnKundenHolen.Enabled = bModus
                    btnAdressLabels.Enabled = bModus
                    KundenVon.Enabled = bModus
                    KundenBis.Enabled = bModus
                    chkKundenFullReport.Enabled = bModus
                    chkKundenHeute.Enabled = bModus
                    cmbPlattform_kunden.Enabled = bModus
                    chkKundenZeitfilter.Enabled = bModus
                    chkShopLastLogin.Enabled = bModus
                Case "lvwBewertungen"
                    chkBewertung_janein.Enabled = bModus
                    chkStartupRückbewertung.Enabled = bModus
                    chkBewertungZeitfilter.Enabled = bModus
                    dtp_BewertungVon.Enabled = bModus
                    dtp_BewertungBis.Enabled = bModus
                    txtBewertungen.Enabled = bModus
                    btnRefreshBewertungen.Enabled = bModus
                    txtBewertungen.Enabled = bModus
                    chkeBayBewertung_automatischRE.Enabled = bModus
                    chkeBayBewertungen_allebewerted.Enabled = bModus

                Case "lvMailStatus"
                    chkNewsletterAlle.Enabled = bModus
                    chkNewsletterIsWebuser.Enabled = bModus
                    chkVerschickt.Enabled = bModus
                    btnMailVersandStart.Enabled = bModus
                    btnAbschickenNewsletter.Enabled = bModus
                    'btnNewsletterCRC.Enabled = bModus
                    btnNewsletterReset.Enabled = bModus
                    btnEdit.Enabled = bModus
                    cmbTranslationBereichAuswählen.Enabled = bModus
                    chkNewsletter_testmodus.Enabled = bModus
                    chkNewsletterIsDelcampe.Enabled = bModus
                    chkNewsletterIseBay.Enabled = bModus

                Case "lvwBestellverwaltung_nach_artikel"
                    chkHistoryZeitfilter.Enabled = bModus
                    cmbPlattform_bestellungen.Enabled = bModus
                    chkBestellungen_verkauft.Enabled = bModus
                    chkBestellungen_bezahlt.Enabled = bModus
                    chkBestellungen_Versand.Enabled = bModus
                    chkBestellungen_KeineBewertung.Enabled = bModus
                    btneBayAdressenHolen.Enabled = bModus
                    btnBestellungen_abrufen.Enabled = bModus
                    chkBestellungen_bezahlt.Enabled = bModus
                    btnBestellungAdd.Enabled = bModus
                    chkBestellungenVerkauft.Enabled = bModus
                    chkBestellungen_Alle.Enabled = bModus
                    chkBestellungen_Komplett.Enabled = bModus
                    chkBestellungen_Storniert.Enabled = bModus
                    eBayHistoryVon.Enabled = bModus
                    eBayHistoryBis.Enabled = bModus


                Case "lvwStatisticText"
                    optStatHerkunftsland.Enabled = bModus
                    optStatUmsatz.Enabled = bModus
                    optTopKundenListe.Enabled = bModus
                    optMeistegebote.Enabled = bModus
                    optTeuersterArtikel.Enabled = bModus
                    optMeisteStaedte.Enabled = bModus
            End Select
        Catch ex As Exception
            Call debug_message(ex)
        End Try

    End Function
    '#############################################################
    '# >> Artikel zuordnen
    '#############################################################
    Private Sub ZuordnungArtikelKundeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZuordnungArtikelKundeToolStripMenuItem.Click
        Dim iPersonal As Integer = 0
        Dim iCount As Integer = 0
        Try
            If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

                For iCount = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1

                    iPersonal = clsDatenbank_modul.getPersonalID(lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(9).Text)
                    If Not iPersonal = -1 Then
                        If clsDatenbank_modul.setPersonalID2Item(lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(0).Text, iPersonal, "yabe_auction_list_history") = False Then
                            MsgBox("Zuordnung -> Artikel zum Kunden fehlgeschlafen" & vbCrLf & "Artikel: " & lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(10).Text, MsgBoxStyle.Critical)
                        Else
                            lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).BackColor = Color.Azure
                        End If
                    End If

                Next

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ArtikelKomplettLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelKomplettLöschenToolStripMenuItem.Click
        Dim iloop As Integer
        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            For iloop = 0 To lvwEiSoCockpit.SelectedItems.Count - 1
                If Not lvwEiSoCockpit.SelectedItems(iloop).Text = "" Then

                    If MessageBox.Show("Wollen Sie den Artikel: " & lvwEiSoCockpit.SelectedItems(iloop).SubItems(1).Text & " wirklich löschen?", "Artikel löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        clsDatenbank_modul.setDeleteReal(lvwEiSoCockpit.SelectedItems(iloop).Text)
                        lvwEiSoCockpit.SelectedItems(iloop).Remove()
                    Else
                        ' nix
                    End If
                End If

            Next
        End If

    End Sub

    Private Sub setAktionButton()
        Dim str() As String = cmbPlattform_Live.Text.Split(" ")

        Select Case str(0)
            Case "Alle"

                btnAuktionEinlesen.Text = "&Alle vorhandenen Artikel anzeigen"

            Case "eBay"

                btnAuktionEinlesen.Text = "&eBay Auktion einlesen"

            Case "Delcampe"
                btnAuktionEinlesen.Text = "&Delcampe eMails einlesen"
            Case "Shopsysteme"
                btnAuktionEinlesen.Text = "&Adminpanel öffnen"
            Case "Magento"
                btnAuktionEinlesen.Text = "&Magento einlesen"
            Case "Shopste"
                btnAuktionEinlesen.Text = "&Shopste öffnen"
        End Select
    End Sub

    Private Sub cmbLivePlattform_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlattform_Live.SelectedIndexChanged

        cmbPlattform_Live.Enabled = False
        If bIsLoading = False Then
            bIsLoading = True
            '# Alle
            '# eBay
            '# Delcampe
            '# Shopsysteme                    

            Call setAktionButton()

            If cmbPlattform_Live.Text.Contains("Alle") Then
                yabe_dashboard_header.Text = "Cockpit Alle"
                txtGetSellerListSeiteVon.Visible = False
                Label8.Visible = False
                chkAutomatischerModus.Visible = False
                btnQuickSync.Visible = False
                chkBuyItNow.Visible = False
                chkMitWebgalerie.Visible = False
            ElseIf cmbPlattform_Live.Text.Contains("Shopste") Then
                yabe_dashboard_header.Text = "Cockpit Shopste"
                txtGetSellerListSeiteVon.Visible = False
                Label8.Visible = False
                chkAutomatischerModus.Visible = False
                btnQuickSync.Visible = False
                chkBuyItNow.Visible = False
                chkMitWebgalerie.Visible = False
            ElseIf cmbPlattform_Live.Text.Contains("eBay") Then
                yabe_dashboard_header.Text = "Cockpit eBay"
                txtGetSellerListSeiteVon.Visible = True
                btnQuickSync.Visible = True
                Label8.Visible = True
                chkAutomatischerModus.Visible = True
                chkBuyItNow.Visible = True
                chkMitWebgalerie.Visible = True
            ElseIf cmbPlattform_Live.Text.Contains("Delcampe") Then
                yabe_dashboard_header.Text = "Cockpit Delcampe"
                txtGetSellerListSeiteVon.Visible = False
                Label8.Visible = False
                chkAutomatischerModus.Visible = False
                btnQuickSync.Visible = False
                chkBuyItNow.Visible = True
                chkMitWebgalerie.Visible = False
            ElseIf cmbPlattform_Live.Text.Contains("Shop") Then
                yabe_dashboard_header.Text = "Cockpit Shop"
                txtGetSellerListSeiteVon.Visible = False
                Label8.Visible = False
                chkAutomatischerModus.Visible = False
                btnQuickSync.Visible = False
                chkBuyItNow.Visible = False
                chkMitWebgalerie.Visible = False
            ElseIf cmbPlattform_Live.Text.Contains("Magento") Then
                yabe_dashboard_header.Text = "Cockpit Magento"
                txtGetSellerListSeiteVon.Visible = False
                Label8.Visible = False
                chkAutomatischerModus.Visible = False
                btnQuickSync.Visible = False
                chkBuyItNow.Visible = False
                chkMitWebgalerie.Visible = False

            End If

            Application.DoEvents()
            Call getRadioOptions_counts(lvwEiSoCockpit.Name, True)

            Call getLvwData(lvwEiSoCockpit)
            bIsLoading = False
            My.Settings.yabe_plattform_cockpit = cmbPlattform_Live.SelectedIndex
            My.Settings.Save()

        End If
        cmbPlattform_Live.Enabled = True
    End Sub

    '############################################################################
    '# >> Leertaste Vorwärts 
    '############################################################################
    Private Function setLVW_select_vorward(ByRef lvwData As ListView) As Boolean

        Try
            If lvwData.SelectedItems.Count > 0 Then
                Dim iIndex As Integer = lvwData.SelectedItems(0).Index
                lvwData.Items(iIndex - 1).Selected = False
                iIndex += 1
                '   lvwData.Items(iIndex).Selected = True
            End If

        Catch ex As Exception

        End Try

    End Function

    '############################################################################
    '# >> Listview alle Selektieren 
    '############################################################################
    Private Function setLVW_select_all(ByRef lvwData As ListView) As Boolean
        Try
            Dim i As Integer = 0

            If lvwData.Items.Count > 0 Then
                For i = 0 To lvwData.Items.Count - 1
                    lvwData.Items(i).Selected = True
                Next
            End If

            Return True

        Catch ex As Exception
            Call debug_message(ex, "setLVW_select_all")
            Return False
        End Try
    End Function
    Private Sub AlleMarkierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlleMarkierenToolStripMenuItem.Click
        setLVW_select_all(lvwWebArtikel)
    End Sub

    Private Sub AnsichtAktuallisierenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnsichtAktuallisierenToolStripMenuItem2.Click
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwEiSoCockpit)
            Call getRadioOptions_counts("lvweBayLiveList")
            bIsLoading = False
        End If
    End Sub

    Private Sub SucheArtikelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheArtikelToolStripMenuItem.Click

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

            If IsNumeric(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(15).Text) = True Then
                txtSuchen.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(15).Text
            Else
                txtSuchen.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(4).Text
            End If
            bGUISuchen = True
            tabMenue.SelectedIndex = 4
            bGUISuchen = False
            btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub SucheKundeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheKundeToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            txtSuchen.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(1).Text
            bGUISuchen = True
            tabMenue.SelectedIndex = 1
            bGUISuchen = False
            btnSuchen.PerformClick()

        End If
    End Sub

    Private Sub SucheBestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheBestellungenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            txtSuchen.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(1).Text
            bGUISuchen = True
            tabMenue.SelectedIndex = 2
            bGUISuchen = False
            btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub YABEArtikelübernahmeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEArtikelübernahmeToolStripMenuItem.Click

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmYABEAdd As New frmCMS_Item2Shop

            frmYABEAdd.lvwData = lvwBestellverwaltung_nach_artikel

            frmYABEAdd.Show()
        End If

    End Sub

    Private Sub EBayAuktionArtikeldetialsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayAuktionArtikeldetialsToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmeBayDetail As New FormGetItem
            frmeBayDetail.lvwDataInput = lvwBestellverwaltung_nach_artikel
            frmeBayDetail.txteBayID.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text
            frmeBayDetail.Show()
            ' frmeBayDetail.BtnListItem.PerformClick()
        End If
    End Sub

    Private Sub YABEAnsichtAktuallisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEAnsichtAktuallisierenToolStripMenuItem.Click
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwKunden)
            bIsLoading = False
        End If
    End Sub

    Private Sub KundenNeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KundenNeuToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then

            Dim frmKundenEdit As New frmYABE_Kundenverwaltung
            frmKundenEdit.lvwDataInput = lvwKunden
            frmKundenEdit.bInsert = True
            frmKundenEdit.Show()
        End If
    End Sub

    Private Sub SucheKundenbestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheKundenbestellungenToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            bIsLoading = True
            txtSuchen.Text = lvwKunden.SelectedItems(0).SubItems(2).Text
            tabMenue.SelectedIndex = 2
            bIsLoading = False
            btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub txtSuchen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuchen.TextChanged

    End Sub

    Private Sub YABEArtikelansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEArtikelansichtToolStripMenuItem.Click
        '# 
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmWeb As New frmYABE_WebBrowser

            '# Welche Plattform 
            Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text

                Case "eBay"
                    ' Bestellungen Status auswerten 
                    Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(7).Text
                        Case "Bestellt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                        Case "Verschickt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                    End Select


                Case "delcampe"

                    ' Bestellungen Status auswerten 
                    Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(7).Text
                        Case "Bestellt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_versand
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                        Case "Verschickt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                    End Select

                    ' Andere Plattform 
                Case Else

            End Select

            frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
            frmWeb.Show(Me)

        End If

    End Sub

    Private Sub KundenEditierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KundenEditierenToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then

            Dim frmKundenEdit As New frmYABE_Kundenverwaltung
            frmKundenEdit.lvwDataInput = lvwKunden
            frmKundenEdit.strLoadEmail = lvwKunden.SelectedItems(0).SubItems(2).Text
            frmKundenEdit.Show()
        End If
    End Sub

    Private Sub BezahltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BezahltToolStripMenuItem.Click
        Call setStatus_new(lvwBestellverwaltung_nach_artikel, clsDatenbank.yabe_bestellstatus.bezahlt)
    End Sub

    Private Sub VerschicktToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerschicktToolStripMenuItem.Click
        Call setStatus_new(lvwBestellverwaltung_nach_artikel, clsDatenbank.yabe_bestellstatus.verschickt)
    End Sub

    '#################################################################################
    '# >> Artikelstatus ändern von eBay Live und Versandkostentabelle 
    '#################################################################################
    Public Function setStatus_new(ByRef lvwData As ListView, ByVal mBestellStatus As clsDatenbank.yabe_bestellstatus) As Boolean
        Dim iResetColumCaption As Byte = 0 ' statusfeld 
        Dim iResetPlattformCode As Byte = 0 ' Plattform
        Dim iResetArtikelID As Byte = 0 ' Feld für Artikelid 

        Dim bout As Boolean = False
        Dim bSendMail As Boolean = True
        Dim bWebShopLöschen As Boolean = False

        Try

            If lvwData.SelectedItems.Count > 0 Then

                If My.Settings.eiso_bestellstatus_window = True Then
                    '# Namen auswerten für Zurückschreiben 
                    Select Case lvwData.Name
                        Case "lvwEiSoCockpit"
                            iResetColumCaption = 7
                            iResetPlattformCode = 17
                        Case "lvwBestellverwaltung_nach_artikel"
                            iResetColumCaption = 7
                            iResetPlattformCode = 13
                        'Call clsDatenbank_modul.setEiSoOrder_status_orderlist(lvwData.SelectedItems(0).SubItems(24).Text, mBestellStatus)
                        Case "lvwArtikelListe" ' Versandkostenanzeige 
                            iResetColumCaption = 6
                            iResetPlattformCode = 5
                            bout = False
                        Case "lvwBewertungen"
                            iResetColumCaption = 13
                            iResetPlattformCode = 255
                            iResetArtikelID = 2
                            bout = True
                        Case "lvwBestellverlauf"
                            iResetColumCaption = 4
                            iResetPlattformCode = 6
                        'bout = True
                        Case "lvwBestellungen_bestelliste_neu"
                            iResetColumCaption = 7
                            iResetPlattformCode = 13
                            'Call clsDatenbank_modul.setEiSoOrder_status_orderlist(lvwData.SelectedItems(0).SubItems(24).Text, mBestellStatus)

                    End Select

                    Dim frmBestellstatus As New frmBestellstatus
                    frmBestellstatus.lvw = lvwData
                    frmBestellstatus.lvw_kunden = lvwBestellungen_kunden

                    frmBestellstatus.strStatus = mBestellStatus.ToString
                    frmBestellstatus.ShowDialog(Me)
                    bSendMail = frmBestellstatus.bSendMail
                    If frmBestellstatus.bOK = False Then
                        Exit Function
                    End If

                End If

                Dim iCount As Integer = 0

                '# Namen auswerten für Zurückschreiben 
                Select Case lvwData.Name
                    Case "lvwEiSoCockpit"
                        iResetColumCaption = 7
                        iResetPlattformCode = 17
                    Case "lvwBestellverwaltung_nach_artikel"
                        iResetColumCaption = 7
                        iResetPlattformCode = 13
                        Call clsDatenbank_modul.setEiSoOrder_status_orderlist(lvwData.SelectedItems(0).SubItems(24).Text, mBestellStatus)
                    Case "lvwArtikelListe" ' Versandkostenanzeige 
                        iResetColumCaption = 6
                        iResetPlattformCode = 5
                        bout = False
                    Case "lvwBewertungen"
                        iResetColumCaption = 13
                        iResetPlattformCode = 255
                        iResetArtikelID = 2
                        bout = True
                    Case "lvwBestellverlauf"
                        iResetColumCaption = 4
                        iResetPlattformCode = 6
                    'bout = True
                    Case "lvwBestellungen_bestelliste_neu"
                        iResetColumCaption = 7
                        iResetPlattformCode = 13
                        Call clsDatenbank_modul.setEiSoOrder_status_orderlist(lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text, mBestellStatus)

                End Select



                '# Alle selektierten Einträge berücksichtigen 
                Dim bError As Boolean = False



                For iCount = 0 To lvwData.SelectedItems.Count - 1


                    Application.DoEvents()
                    frmMain.master_Message_label.Text = iCount & " / " & lvwData.SelectedItems.Count & " - " & lvwData.SelectedItems(iCount).Text

                    If lvwData.SelectedItems(iCount).SubItems(iResetPlattformCode).Text = "eBay" Then
                        If Not clseBayAPI.setCompleteSale(lvwData.SelectedItems(iCount).SubItems(iResetArtikelID).Text, mBestellStatus.ToString) Then
                            bError = True
                        Else
                            bError = False
                        End If
                    End If

                    '# Order Status übertragen 
                    ' If bError = False Then                    

                    Call clsDatenbank_modul.setEiSoOrder_status(lvwData.SelectedItems(iCount).Text, mBestellStatus)

                    '# Auf Bestellstatus reagieren
                    Select Case mBestellStatus
                        Case clsDatenbank.yabe_bestellstatus.bezahlt
                            lvwData.SelectedItems(iCount).BackColor = My.Settings.gui_color_bestellungen_bezahlt
                            lvwData.SelectedItems(iCount).SubItems(iResetColumCaption).Text = "Bezahlt"
                            Select Case lvwData.Name
                                Case "lvwBestellungen_bestelliste_neu"
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text)
                                Case Else
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwData.SelectedItems(0).SubItems(24).Text)
                            End Select
                        Case clsDatenbank.yabe_bestellstatus.bestellt
                            lvwData.SelectedItems(iCount).BackColor = My.Settings.gui_color_bestellungen_bestellt
                            lvwData.SelectedItems(iCount).SubItems(iResetColumCaption).Text = "Bestellt"

                        Case clsDatenbank.yabe_bestellstatus.verschickt
                            lvwData.SelectedItems(iCount).BackColor = My.Settings.gui_color_bestellungen_verschickt
                            lvwData.SelectedItems(iCount).SubItems(iResetColumCaption).Text = "Verschickt"
                            Select Case lvwData.Name
                                Case "lvwBestellungen_bestelliste_neu"
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text)
                                Case Else
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwData.SelectedItems(0).SubItems(24).Text)
                            End Select


                        Case clsDatenbank.yabe_bestellstatus.komplett
                            lvwData.SelectedItems(iCount).BackColor = My.Settings.gui_color_bestellungen_komplett
                            lvwData.SelectedItems(iCount).SubItems(iResetColumCaption).Text = "Komplett"
                            Select Case lvwData.Name
                                Case "lvwBestellungen_bestelliste_neu"
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text)
                                Case Else
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwData.SelectedItems(0).SubItems(24).Text)
                            End Select
                        Case clsDatenbank.yabe_bestellstatus.storniert
                            lvwData.SelectedItems(iCount).BackColor = My.Settings.gui_color_bestellungen_storniert
                            lvwData.SelectedItems(iCount).SubItems(iResetColumCaption).Text = "Storniert"
                            Select Case lvwData.Name
                                Case "lvwBestellungen_bestelliste_neu"
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text)
                                Case Else
                                    Call clsDatenbank_modul.setDB_status_date(clsDatenbank.status_date.verschickt, lvwData.SelectedItems(0).SubItems(24).Text)
                            End Select
                    End Select

                    ' End If

                Next iCount

                clsMailing.lvwReadIn = lvwData
                clsMailing.bDebug_mail = My.Settings.email_testmodus_only

                '# jb fix
                If bout = False And Not mBestellStatus = clsDatenbank.yabe_bestellstatus.uebernommen And bSendMail = True Then
                    '# VersandStatus Email verschicken
                    Dim Plattform() As String = lvwData.SelectedItems(0).SubItems(iResetPlattformCode).Text.Split("-")
                    Select Case Plattform(0).Trim
                        Case "delcampe"
                            If My.Settings.yabe_pl_delcampe_sendmail = True Then
                                Call clsMailing.setSendMail_bestellstatus(lvwData.SelectedItems(0).SubItems(iResetColumCaption).Text, lvwData, clsEmail.bPlattform.delcampe)
                            End If
                        Case "eBay"
                            If My.Settings.yabe_pl_ebay_sendmail = True Then
                                Call clsMailing.setSendMail_bestellstatus(lvwData.SelectedItems(0).SubItems(iResetColumCaption).Text, lvwData, clsEmail.bPlattform.eBay)
                            End If
                        Case "CMS"
                            If My.Settings.yabe_pl_shop_sendmail = True Then
                                Call clsMailing.setSendMail_bestellstatus(lvwData.SelectedItems(0).SubItems(iResetColumCaption).Text, lvwData, clsEmail.bPlattform.shopsystem)
                            End If
                        Case "Magento"
                            If My.Settings.yabe_pl_magento_sendmail = True Then
                                Call clsMailing.setSendMail_bestellstatus(lvwData.SelectedItems(0).SubItems(iResetColumCaption).Text, lvwData, clsEmail.bPlattform.magento)
                            End If
                        Case "Shopste"
                            If My.Settings.yabe_pl_shopste_sendmail = True Then
                                Call clsMailing.setSendMail_bestellstatus(lvwData.SelectedItems(0).SubItems(iResetColumCaption).Text, lvwData, clsEmail.bPlattform.shopste)
                            End If
                    End Select
                End If

                Call setLVWEiSoOrder_recalc(lvwData)
            End If

            Return True
        Catch ex As Exception
            debug_message(ex, "setSelectedMark")
            Return False
        End Try
    End Function

    Private Sub BewertetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BewertetToolStripMenuItem.Click
        Call setStatus_new(lvwBestellverwaltung_nach_artikel, clsDatenbank.yabe_bestellstatus.bestellt)
    End Sub

    Private Sub CompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteToolStripMenuItem.Click
        Call setStatus_new(lvwBestellverwaltung_nach_artikel, clsDatenbank.yabe_bestellstatus.komplett)
    End Sub

    Private Sub StorniertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StorniertToolStripMenuItem.Click
        Call setStatus_new(lvwBestellverwaltung_nach_artikel, clsDatenbank.yabe_bestellstatus.storniert)
    End Sub

    Private Sub YABERechnungsdruckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABERechnungsdruckToolStripMenuItem.Click

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

            Dim frmYABE_Rechnungsdruck As New frmYABE_Rechnungsdruck
            frmYABE_Rechnungsdruck.lvwDataInput = lvwBestellverwaltung_nach_artikel
            frmYABE_Rechnungsdruck.Show(Me)

        End If
    End Sub

    Private Sub EmailExternesProgrammToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailExternesProgrammToolStripMenuItem1.Click

        If lvwKunden.SelectedItems.Count > 0 Then
            Dim ExterneAnwendung As New System.Diagnostics.Process()
            Dim strCommandline As String = ""

            strCommandline = "mailto:" & lvwKunden.SelectedItems(0).SubItems(2).Text & "?subject=" & "Philafriend %20Auktion%20-%20" & lvwKunden.SelectedItems(0).SubItems(4).Text & "&body=<strong>Hallo " & lvwKunden.SelectedItems(0).Text & "," & "</strong><br><br><br>MfG Philafriend - Auktion"

            ExterneAnwendung.StartInfo.FileName = strCommandline

            ExterneAnwendung.Start()
        End If

    End Sub

    Private Sub KopierenEmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenEmailToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(9).Text)
        End If
    End Sub

    Private Sub OutlookSyncToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutlookSyncToolStripMenuItem.Click
        Dim frmOutlook As New frmOutlook_sync
        frmOutlook.Show()

    End Sub

    Private Sub SYNCCockpitBestellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYNCCockpitBestellungenToolStripMenuItem.Click
        '# -1 => Keine Daten zum akuallisieren
        If Not clsDatenbank_modul.setBestellungen_insert_alt() = "-1" Then

            '# Live Liste
            Call getLvwData(lvwEiSoCockpit)

            '# Bestellungen aktualliseren 
            Call getLvwData(lvwBestellverwaltung_nach_artikel)

            Call getRadioOptions_counts("lvweBayLiveList")

            'MsgBox("Die Artikel wurden erfolgreich in die YABE Bestellungen übertragen", MsgBoxStyle.Information, "YABE Daten Synchronisieren")
        End If
    End Sub

    Private Sub lvweBayLiveList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwEiSoCockpit.SelectedIndexChanged

    End Sub



    Private Sub lvweBayHistory_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwBestellverwaltung_nach_artikel.MouseDoubleClick
        '# 
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

            Dim frmWeb As New frmYABE_WebBrowser
            frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel

            Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text
                Case "eBay"
                    frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_versandkosten
                Case "delcampe"
                    Select Case lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(7).Text
                        Case "Bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                        Case "Verschickt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_bewerten
                        Case Else
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_versand
                    End Select

            End Select

            frmWeb.Show(Me)

        End If
    End Sub

    Private Sub SNYCEBayAPIDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SNYCEBayAPIDataToolStripMenuItem.Click
        If chkEndTime.Checked = True Then
            Call geteBaySellerList(True)
        Else
            Call geteBaySellerList(True)
        End If
    End Sub

    Private Sub YABEBestellverlaufProKundenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEBestellverlaufProKundenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmVersand As New frmBestellung_Versandkosten
            frmVersand.lvwDataInput = lvwBestellverwaltung_nach_artikel

            frmVersand.mModusSelect = frmBestellung_Versandkosten.mModus.history
            frmVersand.Show()
        End If
    End Sub

    Private Sub cmseBayBewertung_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmseBayBewertung.Opening

        If lvwBewertungen.SelectedItems.Count > 0 Then
            BewertungsprofilinternToolStripMenuItem.Text = "eBay -> Bewertungsprofil von '" & lvwBewertungen.SelectedItems(0).Text & "' suchen"
        End If

    End Sub

    Private Sub cmsKundenListview_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsKundenListview.Opening

        If lvwKunden.SelectedItems.Count > 0 Then
            BestellübersichtToolStripMenuItem.Text = "&YABE -> Kundenprofil: '" & lvwKunden.SelectedItems(0).Text & "'"
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        '# 
        If lvwBewertungen.SelectedItems.Count > 0 Then
            Dim frmWeb As New frmYABE_WebBrowser
            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
            frmWeb.lvwDataView = lvwBewertungen
            frmWeb.Show(Me)

        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        '# 
        If lvwKunden.SelectedItems.Count > 0 Then
            Dim frmWeb As New frmYABE_WebBrowser
            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.yabe_personensuche_yasni
            frmWeb.lvwDataView = lvwKunden
            frmWeb.Show(Me)

        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            Dim frmWeb As New frmYABE_WebBrowser


            Select Case lvwEiSoCockpit.SelectedItems(0).SubItems(17).Text
                Case "eBay"
                    frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
                Case "delcampe"
                    frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
            End Select



            frmWeb.lvwDataView = lvwEiSoCockpit
            frmWeb.Show(Me)
        End If

    End Sub

    Private Sub WebSucheBeiGoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebSucheBeiGoogleToolStripMenuItem.Click
        '# 
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim frmWeb As New frmYABE_WebBrowser
            frmWeb.lvwDataView = lvwWebArtikel
            frmWeb.strURL = "http://www.google.de/?q=" & lvwWebArtikel.SelectedItems(0).SubItems(1).Text.Replace(" ", "+")
            frmWeb.Show(Me)
        End If
    End Sub

    Private Sub DelcampeArtikelansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeArtikelansichtToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
        frmWeb.Show(Me)
    End Sub

    Private Sub DelcampeVersandkostenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeVersandkostenToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_versand
        frmWeb.Show(Me)
    End Sub

    Private Sub DelcampeBewertungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeBewertungenToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_bewerten
        frmWeb.Show(Me)
    End Sub

    Private Sub EBayArtikelansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayArtikelansichtToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_artikelview
        frmWeb.Show(Me)
    End Sub

    Private Sub EBayVersandkostenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayVersandkostenToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_versandkosten
        frmWeb.Show(Me)
    End Sub

    Private Sub EBayBewertungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayBewertungenToolStripMenuItem.Click


    End Sub

    Private Sub PersonensucheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonensucheToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.yabe_personensuche_yasni
        frmWeb.Show(Me)
    End Sub

    Private Sub TelefonnummernSucheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelefonnummernSucheToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.yabe_dasoertliche
        frmWeb.Show(Me)
    End Sub

    Private Sub GoogleMapsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleMapsToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.yabe_google_maps
        frmWeb.Show(Me)
    End Sub

    Private Sub PersonensucheToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonensucheToolStripMenuItem1.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwKunden
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.yabe_personensuche_yasni
        frmWeb.Show(Me)
    End Sub

    Private Sub TelefonummernSucheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelefonummernSucheToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwKunden
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.yabe_dasoertliche
        frmWeb.Show(Me)
    End Sub

    Private Sub GoogleMapsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleMapsToolStripMenuItem1.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwKunden
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.yabe_google_maps
        frmWeb.Show(Me)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Call setStatus_new(lvwBewertungen, clsDatenbank.yabe_bestellstatus.bestellt)
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Call setStatus_new(lvwBewertungen, clsDatenbank.yabe_bestellstatus.bezahlt)
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Call setStatus_new(lvwBewertungen, clsDatenbank.yabe_bestellstatus.verschickt)
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Call setStatus_new(lvwBewertungen, clsDatenbank.yabe_bestellstatus.komplett)
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Call setStatus_new(lvwBewertungen, clsDatenbank.yabe_bestellstatus.storniert)
    End Sub

    Private Sub KopierenEmailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenEmailToolStripMenuItem1.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwKunden.SelectedItems(0).SubItems(2).Text)
        End If
    End Sub

    Private Sub KopierenNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenNameToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwKunden.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub

    Private Sub KopierenArtikelIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenArtikelIDToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            Clipboard.SetText(lvwKunden.SelectedItems(0).Text)
        End If
    End Sub


    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click

    End Sub

    Private Sub GruppiertNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruppiertNameToolStripMenuItem.Click

        If GruppiertNameToolStripMenuItem.Checked = False Then
            GruppiertNameToolStripMenuItem.Checked = True
            GroupiertVerkaufsendeToolStripMenuItem.Checked = False
            GruppiertLandToolStripMenuItem.Checked = False
            GruppiertBestellstatusToolStripMenuItem.Checked = False
            GruppiertMutterspracheToolStripMenuItem.Checked = False
        Else
            GruppiertNameToolStripMenuItem.Checked = False
        End If
        My.Settings.yabe_gui_bestellverwaltung_groupby_name = GruppiertNameToolStripMenuItem.Checked
        My.Settings.Save()

        Call setStatusMessage(lvwBestellverwaltung_nach_artikel)
    End Sub

    Private Sub GroupiertVerkaufsendeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupiertVerkaufsendeToolStripMenuItem.Click
        If GroupiertVerkaufsendeToolStripMenuItem.Checked = False Then
            GroupiertVerkaufsendeToolStripMenuItem.Checked = True
            GruppiertNameToolStripMenuItem.Checked = False
            GruppiertLandToolStripMenuItem.Checked = False
            GruppiertBestellstatusToolStripMenuItem.Checked = False
            GruppiertMutterspracheToolStripMenuItem.Checked = False
        Else
            GroupiertVerkaufsendeToolStripMenuItem.Checked = False
        End If

        My.Settings.yabe_gui_bestellverwaltung_groupby_verkaufsende = GroupiertVerkaufsendeToolStripMenuItem.Checked
        My.Settings.Save()

        Call setStatusMessage(lvwBestellverwaltung_nach_artikel)
    End Sub

    Private Sub GruppiertLandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruppiertLandToolStripMenuItem.Click

        If GruppiertLandToolStripMenuItem.Checked = False Then
            GruppiertLandToolStripMenuItem.Checked = True
            GruppiertNameToolStripMenuItem.Checked = False
            GroupiertVerkaufsendeToolStripMenuItem.Checked = False
            GruppiertBestellstatusToolStripMenuItem.Checked = False
            GruppiertMutterspracheToolStripMenuItem.Checked = False
        Else
            GruppiertLandToolStripMenuItem.Checked = False
        End If

        My.Settings.yabe_gui_bestellverwaltung_groupby_land = GruppiertLandToolStripMenuItem.Checked
        My.Settings.Save()

        Call setStatusMessage(lvwBestellverwaltung_nach_artikel)
    End Sub


    Private Sub GruppiertMutterspracheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruppiertMutterspracheToolStripMenuItem.Click

        If GruppiertMutterspracheToolStripMenuItem.Checked = False Then
            GruppiertMutterspracheToolStripMenuItem.Checked = True
            GruppiertLandToolStripMenuItem.Checked = False
            GruppiertNameToolStripMenuItem.Checked = False
            GroupiertVerkaufsendeToolStripMenuItem.Checked = False
            GruppiertBestellstatusToolStripMenuItem.Checked = False
        Else
            GruppiertMutterspracheToolStripMenuItem.Checked = False
        End If

        My.Settings.yabe_gui_bestellverwaltung_groupby_muttersprache = GruppiertMutterspracheToolStripMenuItem.Checked
        My.Settings.Save()

        Call setStatusMessage(lvwBestellverwaltung_nach_artikel)

    End Sub

    Private Sub GruppiertBestellstatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruppiertBestellstatusToolStripMenuItem.Click

        If GruppiertBestellstatusToolStripMenuItem.Checked = False Then
            GruppiertMutterspracheToolStripMenuItem.Checked = False
            GruppiertLandToolStripMenuItem.Checked = False
            GruppiertNameToolStripMenuItem.Checked = False
            GroupiertVerkaufsendeToolStripMenuItem.Checked = False
            GruppiertBestellstatusToolStripMenuItem.Checked = True
        Else
            GruppiertBestellstatusToolStripMenuItem.Checked = False
        End If

        My.Settings.yabe_gui_bestellverwaltung_groupby_bestellstatus = GruppiertBestellstatusToolStripMenuItem.Checked
        My.Settings.Save()

        Call setStatusMessage(lvwBestellverwaltung_nach_artikel)

    End Sub

    Private Sub lvwBewertungen_ColumnReordered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles lvwBewertungen.ColumnReordered

        Call getLVW_Colum_ReOrder(lvwBewertungen)

    End Sub

    '############################################################################################
    '# >> LVW: Display Index setzten für alle Listviews 
    '############################################################################################
    Public Function setLVW_Colum_ReOrder(ByVal lvw As ListView) As Boolean
        Dim iCount As Integer = 0
        Dim str() As String
        ReDim str(0)
        Try

            '# Anhand des Namens Settings auslesen 
            Select Case lvw.Name
                Case "lvwBewertungen"
                    str = My.Settings.gui_lvw_bewertungen_columorder.ToString.Split(",")
                Case "lvwKunden"
                    str = My.Settings.gui_lvw_kunden_columorder.ToString.Split(",")
                Case "lvwBestellverwaltung_nach_artikel"
                    str = My.Settings.gui_lvw_bestellungen_columorder.ToString.Split(",")
                Case "lvwEiSoCockpit"
                    str = My.Settings.gui_lvw_cockpit_columorder.ToString.Split(",")
                Case "lvwWebArtikel"
                    str = My.Settings.gui_lvw_artikelliste_reorder.ToString.Split(",")
                Case "lvMailStatus"
                    str = My.Settings.gui_lvw_newsletter_reorder.ToString.Split(",")
                Case "lvwBestellungen_bestelliste_neu"
                    str = My.Settings.gui_lvw_bestellliste_artikel_reorder.ToString.Split(",")
                Case "lvwBestellungen_kunden"
                    str = My.Settings.gui_lvw_bestellliste_kunden_reorder.ToString.Split(",")
            End Select

            '# Neu setzten der Anzeige 
            For iCount = 0 To str.Length - 1

                If IsNumeric(str(iCount)) = True Then
                    lvw.Columns(iCount).DisplayIndex = str(iCount)
                End If

            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '###########################################################################################
    '# >> Ermöglicht einfach das Speichern 
    '###########################################################################################
    Public Function getLVW_Colum_ReOrder(ByVal lvw As ListView) As Boolean
        Dim iCount As Integer = 0
        Dim strDisplayIndex As String = ""
        Try

            For iCount = 0 To lvw.Columns.Count - 1

                If Not iCount = lvw.Columns.Count - 1 Then
                    strDisplayIndex &= lvw.Columns(iCount).DisplayIndex & ","
                Else
                    strDisplayIndex &= lvw.Columns(iCount).DisplayIndex
                End If

            Next

            Select Case lvw.Name
                Case "lvwBewertungen"
                    My.Settings.gui_lvw_bewertungen_columorder = strDisplayIndex
                    My.Settings.Save()
                Case "lvwKunden"
                    My.Settings.gui_lvw_kunden_columorder = strDisplayIndex
                    My.Settings.Save()
                Case "lvwBestellverwaltung_nach_artikel"
                    My.Settings.gui_lvw_bestellungen_columorder = strDisplayIndex
                    My.Settings.Save()
                Case "lvwEiSoCockpit"
                    My.Settings.gui_lvw_cockpit_columorder = strDisplayIndex
                    My.Settings.Save()
                Case "lvMailStatus"
                    My.Settings.gui_lvw_newsletter_reorder = strDisplayIndex
                    My.Settings.Save()
                Case "lvwWebArtikel"
                    My.Settings.gui_lvw_artikelliste_reorder = strDisplayIndex
                    My.Settings.Save()
                Case "lvwBestellungen_kunden"
                    My.Settings.gui_lvw_bestellliste_kunden_reorder = strDisplayIndex
                    My.Settings.Save()
                Case "lvwBestellungen_bestelliste_neu"
                    My.Settings.gui_lvw_bestellliste_artikel_reorder = strDisplayIndex
                    My.Settings.Save()
            End Select

            Return False
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Private Sub lvweBayHistory_ColumnReordered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles lvwBestellverwaltung_nach_artikel.ColumnReordered
        Call getLVW_Colum_ReOrder(lvwBestellverwaltung_nach_artikel)
    End Sub

    Private Sub lvwKunden_ColumnReordered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles lvwKunden.ColumnReordered
        Call getLVW_Colum_ReOrder(lvwKunden)
    End Sub

    Private Sub lvweBayLiveList_ColumnReordered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles lvwEiSoCockpit.ColumnReordered
        Call getLVW_Colum_ReOrder(lvwEiSoCockpit)
    End Sub




    Private Sub lvwMenue_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwMenue.DragEnter

        ' Check for the custom DataFormat ListViewItem array. 
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.Copy

        End If

    End Sub

    Private Sub lvwMenue_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwMenue.DragDrop
        Dim i As Integer
        Dim bIn As Boolean = False
        'Dim myItems As Object = CType(e.Data.GetData(GetType(System.String)), System.Object)
        'Dim myItems() As ListViewItem = e.Data.GetData(, True)

        '  If e.Data.GetDataPresent(GetType(ListViewItem())) Then
        'Dim myType As Type = GetType(DataColumn)

        'If e.Data.GetDataPresent(DataFormats.FileDrop) Then
        '    Dim MyFiles() As String
        '    Dim str As String
        '    ' Assign the files to an array.
        '    MyFiles = e.Data.GetData(DataFormats.FileDrop)
        '    ' Loop through the array and add the files to the list.
        '    For i = 0 To MyFiles.Length - 1
        '        str &= MyFiles(i)
        '    Next
        '    MsgBox(str)
        '    bIn = True
        '    Exit Sub
        'ElseIf e.Data.GetDataPresent(DataFormats.Serializable) Then
        '    MsgBox("Stringformat")
        '    bIn = True
        'ElseIf e.Data.GetDataPresent(DataFormats.Dif) Then
        '    MsgBox("DIF")
        '    bIn = True
        'ElseIf e.Data.GetDataPresent(DataFormats.EnhancedMetafile) Then
        '    MsgBox("Metafile")
        '    bIn = True
        'End If



        If e.Data.GetDataPresent(GetType(ListViewItem())) Then
            Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")


            Dim myItem As ListViewItem
            ' Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")

            For Each myItem In myItems
                ' Add the item to the target list. 
                'MsgBox(sender.Items.Add(myItems(i).SubItems(1).Text))

                ' Remove the item from the source list. 
                If sender Is lvwMenue Then
                    lvwWebArtikel.Items.Remove(lvwWebArtikel.SelectedItems.Item(0))
                Else
                    'ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
                End If
                i = i + 1
            Next
        End If



    End Sub

    Private Sub lvwWebArtikel_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lvwWebArtikel.ItemDrag, lvwMenue.ItemDrag
        Dim myItem As ListViewItem
        Dim myItems(sender.SelectedItems.Count - 1) As ListViewItem
        Dim i As Integer = 0
        ' Loop though the SelectedItems collection for the source. 
        For Each myItem In sender.SelectedItems
            ' Add the ListViewItem to the array of ListViewItems. 
            myItems(i) = myItem
            i = i + 1
        Next
        ' Create a DataObject containg the array of ListViewItems. 
        sender.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem()", myItems), DragDropEffects.Move)

    End Sub

    Private Sub DelcampeBestellsStatusAktuallisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.strURL = "http://delcampe.de/status.php?language=G&page=05&noarchive=Y#StatusContent"
        frmWeb.Show()
    End Sub

    Private Sub ArchivAktuallisierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivAktuallisierenToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.strURL = "http://delcampe.de/status.php?language=G&page=05&noarchive=N&p=all&rs_count=176#StatusContent"
        frmWeb.Show()

    End Sub

    Private Sub eshop_daten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eshop_daten.Click

    End Sub

    Private Function setChangeArtikelDatenbank_view() As Boolean
        Try
            If optCMSToogleKategorie.Checked = True Then
                optCMSToogleBoth.Checked = True
            End If
            If optCMSToogleArtikel.Checked = True Then
                optCMSToogleKategorie.Checked = True
            End If

            If optCMSToogleBoth.Checked = True Then
                optCMSToogleArtikel.Checked = True
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub lvwWebArtikel_ColumnReordered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles lvwWebArtikel.ColumnReordered
        Call getLVW_Colum_ReOrder(lvwWebArtikel)
    End Sub

    Private Sub lvMailStatus_ColumnReordered(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles lvMailStatus.ColumnReordered
        Call getLVW_Colum_ReOrder(lvMailStatus)
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        If lvwStatisticText.SelectedItems.Count >= 2 Then
            Call export(lvwStatisticText, export_targets.standard, selectModus.part)
        Else
            Call export(lvwStatisticText, export_targets.standard, selectModus.ganz)
        End If

    End Sub

    Private Sub SpracheZurücksetzenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpracheZurücksetzenToolStripMenuItem.Click
        Dim iCount As Integer = 0
        Dim strSprache As clsDatenbank.email_sprache

        Try
            Application.DoEvents()
            SpracheZurücksetzenToolStripMenuItem.Enabled = False



            '# >> Sprachauswahl 
            Select Case cmbSprache_Artikeldatenbank.Text
                Case "Deutsch"
                    strSprache = clsDatenbank.email_sprache.de
                Case "Englisch"
                    strSprache = clsDatenbank.email_sprache.eng
                Case "Französisch"
                    strSprache = clsDatenbank.email_sprache.fr
                Case "Russisch"
                    strSprache = clsDatenbank.email_sprache.ru
                Case "Spanisch"
                    strSprache = clsDatenbank.email_sprache.sp
                Case "Chinesisch"
                    strSprache = clsDatenbank.email_sprache.cn
            End Select

            '# Zurücksetzten von Artikelsprache für selektierte Artikel
            For iCount = 0 To lvwWebArtikel.SelectedItems.Count - 1
                '# Leeren der Datenbank 
                Application.DoEvents()
                clsDatenbank_modul.setArtikeldatenbank_Beschreibung_empty(lvwWebArtikel.SelectedItems(iCount).Text, strSprache)
                lvwWebArtikel.SelectedItems(iCount).SubItems(1).Text = ""
                lvwWebArtikel.SelectedItems(iCount).EnsureVisible()
                frmMain.master_Message_label.Text = iCount + 1 & " / " & lvwWebArtikel.SelectedItems.Count - 1
            Next

            'Dim iDelcampeID As Integer = lvwMenue.SelectedItems(0).SubItems(3).Text
            'Dim strHauptkategorie As String = lvwMenue.SelectedItems(0).SubItems(5).Text
            'Dim iId As Integer = 0
            'iId = lvwMenue.SelectedItems(0).SubItems(0).Text

            'lvwWebArtikel.Items.Clear()
            'Call clsDatenbank_modul.getCMS_items("SELECT * FROM tblGes WHERE Kategorie_neo='" & iId & "' AND bestellt=0 ORDER BY Beschreibung ASC", lvwWebArtikel, iDelcampeID, strHauptkategorie)
            'Call setStatusMessage(lvwWebArtikel)
            SpracheZurücksetzenToolStripMenuItem.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub YABEWebtranslatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEWebtranslatorToolStripMenuItem.Click

        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwWebArtikel

        frmWeb.strURL = My.Settings.shop_url & "/ACP/admin_translation_tool.php?sprache=" & cmbSprache_Artikeldatenbank.Text & "&optModul=tblGes&yb_user=" & My.Settings.yabe_username & "&level=" & My.Settings.yabe_accesslevel

        frmWeb.Show()

    End Sub


    Private Sub tabMenue_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tabMenue.DrawItem
        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tabMenue.TabPages(e.Index)
        Dim ItemRect As Rectangle = tabMenue.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.DarkGray)
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.Gainsboro
            TextBrush.Color = Color.Black
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If tabMenue.Alignment = TabAlignment.Left Or tabMenue.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tabMenue.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()


    End Sub

    Private Sub CMSAnsichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMSAnsichtToolStripMenuItem.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.lvwDataView = lvwBestellverwaltung_nach_artikel
        frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.shop_einzelview
        frmWeb.Show()
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown


        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter And ToolStripTextBox1.Text.Length > 0 Then

            Dim iCount As Integer = 0
            Dim iDel As Integer = 0
            Dim str As String = ""

            lvwWebArtikel.BeginUpdate()
            iDel = lvwWebArtikel.Items.Count - 1
            Dim strID As String = ""
            For iCount = 0 To iDel

                Try
                    strID = lvwWebArtikel.Items(iCount).SubItems(1).Text
                Catch ex As Exception
                    strID = ""
                End Try

                If strID.Length > 0 Then
                    If Not strID.Contains(ToolStripTextBox1.Text) = True Then
                        lvwWebArtikel.Items(iCount).Remove()
                        iCount = 0
                    End If

                End If

            Next

            lvwWebArtikel.EndUpdate()

            Call setStatusMessage(lvwWebArtikel)

        End If
    End Sub

    Private Sub cmbPlattform_bestellungen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlattform_bestellungen.SelectedIndexChanged
        If bIsLoading = False Then

            My.Settings.yabe_plattform_bestellungen = cmbPlattform_bestellungen.SelectedIndex
            My.Settings.Save()
            btnBestellungen_abrufen.PerformClick()

        End If

        If cmbPlattform_bestellungen.Text.Contains("eBay") Then
            btneBayAdressenHolen.Visible = True
        Else
            btneBayAdressenHolen.Visible = False
        End If

    End Sub

    Private Sub cmbPlattform_kunden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlattform_kunden.SelectedIndexChanged
        If bIsLoading = False Then
            btnKundenHolen.PerformClick()
        End If

        My.Settings.yabe_plattform_kunden = cmbPlattform_kunden.SelectedIndex
        My.Settings.Save()

    End Sub

    Private Sub cmbSprache_Artikeldatenbank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSprache_Artikeldatenbank.SelectedIndexChanged
        If bIsLoading = False Then
            Try
                bIsLoading = True

                Dim iSel As Integer = -1
                Dim iId As Integer = 0
                If lvwMenue.SelectedItems.Count > 0 Then
                    iId = lvwMenue.SelectedItems(0).SubItems(0).Text
                Else
                    lvwMenue.Items(3).Selected = True
                    iId = lvwMenue.SelectedItems(0).SubItems(0).Text
                End If
                bIsLoading = False

                Call setShopLVW_refresh()
                If iSel > 0 Then
                    lvwWebArtikel.Items(iSel).Selected = True
                    lvwWebArtikel.Items(iSel).EnsureVisible()
                End If

                lvwWebArtikel.Focus()
                Call setStatusMessage(lvwWebArtikel)

                If AutomatischSpracheÄndernToolStripMenuItem.Checked = True Then
                    lvwMenueSprache = cmbSprache_Artikeldatenbank.Text
                    clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue group by Parent", lvwMenue, cmbSprache_Artikeldatenbank.Text)
                End If

            Catch ex As Exception
                cmbSprache_Artikeldatenbank.Enabled = True
                cmbArtikelStatus.Enabled = True
                lvwMenue.Enabled = True
                Call debug_message(ex, "lvwMenue_wechsel")
            End Try
        End If

    End Sub

    Private Sub menue_kunden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menue_kunden.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub DatePickStartTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatePickStartTo.ValueChanged

    End Sub

    Private Sub tabPaypal_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tabPaypal.DrawItem
        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tabPaypal.TabPages(e.Index)
        Dim ItemRect As Rectangle = tabPaypal.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.DarkGray)
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.Gainsboro
            TextBrush.Color = Color.Black
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If tabPaypal.Alignment = TabAlignment.Left Or tabPaypal.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tabPaypal.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()

    End Sub

    Private Sub tab_verwaltung_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tab_verwaltung.DrawItem
        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tab_verwaltung.TabPages(e.Index)
        Dim ItemRect As Rectangle = tab_verwaltung.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.DarkGray)
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.Gainsboro
            TextBrush.Color = Color.Black
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If tab_verwaltung.Alignment = TabAlignment.Left Or tab_verwaltung.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tab_verwaltung.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()
    End Sub

    Private Sub tabStatistics_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tabStatistics.DrawItem


        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tabStatistics.TabPages(e.Index)
        Dim ItemRect As Rectangle = tabStatistics.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.DarkGray)
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.Gainsboro
            TextBrush.Color = Color.Black
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If tabStatistics.Alignment = TabAlignment.Left Or tabStatistics.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tabStatistics.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()

    End Sub

    Private Sub tbMeineBay_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tbMeineBay.DrawItem
        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tbMeineBay.TabPages(e.Index)
        Dim ItemRect As Rectangle = tbMeineBay.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.DarkGray)
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.Gainsboro
            TextBrush.Color = Color.Black
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If tbMeineBay.Alignment = TabAlignment.Left Or tbMeineBay.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tbMeineBay.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()
    End Sub

    Private Sub lvwWebArtikel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwWebArtikel.SelectedIndexChanged

    End Sub

    Private Sub cms_ArtikelVerwaltung_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cms_ArtikelVerwaltung.Opening

        If cmbSprache_Artikeldatenbank.SelectedIndex = 0 Then
            SpracheZurücksetzenToolStripMenuItem.Visible = False
        Else
            SpracheZurücksetzenToolStripMenuItem.Visible = True
        End If

        '# Importieren im Menü angeklickt
        If lvwMenue.SelectedItems.Count > 0 Then
            If lvwMenue.SelectedItems(0).SubItems(1).Text = "Importieren" And cmbArtikelStatus.Text = "Kategorie" Then
                YABEImportVonArtikelnToolStripMenuItem.Visible = True
                ArtikelAlleImportiertenLöschenToolStripMenuItem.Visible = True
                ToolStripSeparator44.Visible = True
            Else
                YABEImportVonArtikelnToolStripMenuItem.Visible = False
                ArtikelAlleImportiertenLöschenToolStripMenuItem.Visible = False
                ToolStripSeparator44.Visible = False
            End If
        Else
            If Not cmbArtikelStatus.Text = "Kategorie" Then
                YABEImportVonArtikelnToolStripMenuItem.Visible = False
                ArtikelAlleImportiertenLöschenToolStripMenuItem.Visible = False
                ToolStripSeparator44.Visible = False
            End If
        End If

        If My.Settings.yabe_magento_aktiv = True Then
            MagentoToolStripMenuItem.Visible = True
        Else
            MagentoToolStripMenuItem.Visible = False
        End If


        SpracheZurücksetzenToolStripMenuItem.Text = "Sprache '" & cmbSprache_Artikeldatenbank.Text & "' -> zurücksetzen (" & lvwWebArtikel.SelectedItems.Count & ")"
        ArtikelSuchenUndErsetzenToolStripMenuItem.Text = "Artikel -> (" & lvwWebArtikel.SelectedItems.Count & ") Suchen und ersetzen..."
        If My.Settings.yabe_magento_aktiv = False Then
            MagentoToolStripMenuItem.Visible = False
        Else
            MagentoToolStripMenuItem.Visible = True
        End If

    End Sub

    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        btnAbbrechen.Enabled = False

        If btnAbbrechen.Text = "&Stoppen" Then
            clsDatenbank_modul.bStopReadIn = True
            btnAbbrechen.Text = "&Sperre aufheben"
        Else
            clsDatenbank_modul.bStopReadIn = False
            btnAbbrechen.Text = "&Stoppen"
        End If

        btnAbbrechen.Enabled = True

    End Sub

    Private Sub chkArtikeldatenbank_edit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArtikeldatenbank_edit.CheckedChanged
        My.Settings.gui_webartikel_editmodus = chkArtikeldatenbank_edit.Checked
        My.Settings.Save()
    End Sub



    Private Sub ArtikelSuchenUndErsetzenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelSuchenUndErsetzenToolStripMenuItem.Click
        Dim frmSuchenundErsetzten As New frmCMS_search_replace
        frmSuchenundErsetzten.lvwData_multiselect = lvwWebArtikel
        frmSuchenundErsetzten.Show(Me)
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub
    '##################################################
    '# >> Google Übersetzung holen
    '##################################################
    Public Function getGoogleTranslate(ByVal strText As String, ByVal strGoogleZielsprache As String) As String
        Dim strTranslated As String = ""

        strTranslated = getTranslateText(strText, "de", strGoogleZielsprache)
        Return strTranslated
    End Function

    '###########################################################################################
    '## >> fehlende Übersetzungen holen 
    '###########################################################################################
    Private Function getMissingTranslations(ByRef lvwData As ListView) As Boolean
        Try
            Dim iCol_beschreibung As Integer = 1
            Dim iCount As Integer = 0
            Dim strDE As String = ""
            Dim strTranslated As String = ""
            Dim strGoogleSprache As String = clsDatenbank_modul.getLanuage2GoogleCode(cmbSprache_Artikeldatenbank.Text)
            Dim iTranslated As Integer = 0


            setBludauMediaLogbuch(">> ÜBERSETZTE INS" & strGoogleSprache & ": " & lvwData.Items.Count & "Artikel...." & frmMain.master_Message_label.Text, "ARTIKELDATENBANK")

            '# Alle Elemente durchgehen 
            For iCount = 0 To lvwData.Items.Count - 1

                If bAbbruch = True Then
                    Exit For
                End If

                '# Kein Text gefunden übersetzen 
                If lvwData.Items(iCount).SubItems(iCol_beschreibung).Text = "" Then

                    iTranslated += 1
                    strDE = clsDatenbank_modul.getCMS_ShopItems("Beschreibung", lvwData.Items(iCount).Text)
                    strTranslated = getTranslateText(strDE, "de", strGoogleSprache)
                    If strTranslated.Length > 0 Then
                        strTranslated = strTranslated.Trim()
                        '# Filter für Fremdzeichen 
                        strTranslated = strTranslated.Replace("&gt;", " >")
                        strTranslated = strTranslated.Replace("&lt;", " <")
                        strTranslated = strTranslated.Replace("&#39;", "'")
                        strTranslated = strTranslated.Replace("<br>", "'")
                        strTranslated = strTranslated.Replace("&quot;", """")

                        '# Speichern der Änderung
                        If clsDatenbank_modul.setWebArtikel_update_replace(cmbSprache_Artikeldatenbank.Text, lvwData.Items(iCount).Text, strTranslated) = False Then
                            MsgBox("Es gab ein Problem mit dem Speichern von dem übersetzen Text")
                            Continue For
                        End If

                        lvwData.Items(iCount).SubItems(iCol_beschreibung).Text = strTranslated
                    End If

                    '# Stautsmeldung 
                    Application.DoEvents()
                    lvwData.Items(iCount).EnsureVisible()
                    frmMain.master_Message_label.Text = "Übersetzte: " & iTranslated & "(" & iCount & ") / " & lvwData.Items.Count - 1 & "   - " & strTranslated


                End If

            Next

            setBludauMediaLogbuch(">> ÜBERSETZTEN BEENDET " & lvwData.Items.Count & "Artikel übersetzt ins " & strGoogleSprache, "ARTIKELDATENBANK")


            bAbbruch = False

            Return True
        Catch ex As Exception
            Call debug_message(ex, "getMissingTranslations")
            Return False
        End Try
    End Function
    Private Sub FehlendeÜbersetzungenHolenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FehlendeÜbersetzungenHolenToolStripMenuItem.Click

        If My.Settings.translate_tor_privoxy = True Then
            If gbl_tor_pid = 0 Then
                TorStarup()
            End If
            If gbl_privoxy_pid = 0 Then
                PrivoxyStarup()
            End If
        End If

        Call getMissingTranslations(lvwWebArtikel)
        SpracheZurücksetzenToolStripMenuItem.Enabled = True
    End Sub




    Private Sub KategorieHauptkategorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategorieHauptkategorieToolStripMenuItem.Click
        Dim strRes As String = InputBox("Bitte den Hauptkategorienamen eingeben", "Shop Menü anlegen", "")

        If Not strRes.Length = 0 Then
            Dim iParent As Integer = clsDatenbank_modul.getCMSMenue_highestParent()
            iParent += 1
            Call clsDatenbank_modul.setCMS_NewMenue_Sub(strRes, 0)

            '# MENÜ NEU GENERIEREN
            Dim strShopURL As String
            If My.Settings.shop_eiso_shopaktiv = True Then
                strShopURL = My.Settings.shop_url_eiso
            Else
                strShopURL = My.Settings.shop_url
            End If

            If getHTTPResponseMessage(strShopURL & "/yabe_menue_gen.php?mod=ADD_ALL&usr=" & My.Settings.yabe_username & "&KEY=" & My.Settings.yabe_keycode & "&sprache=_de", mgetUpdaterMessage.setMenue, True) = False Then
                MsgBox("Es gab einen Fehler beim Erzeugen des Shop Menüs", MsgBoxStyle.Exclamation)
            Else

            End If

            Call setRefreshMenueList()

            MsgBox("Neue Shop Hauptkategorie wurde erfolgreich angelegt", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub KategorieNeueSubkategorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategorieNeueSubkategorieToolStripMenuItem.Click

        If My.Settings.shop_eiso_shopaktiv = False Then
            MessageBox.Show("Bitte aktivieren Sie die EiSo Shop Funktion in den EiSo Werkzeuge -> EiSo Einstellungen -> EiSo")
            My.Settings.gui_options_last_tab = optionGUI_Tab_ID.eiso_shop
            Exit Sub
        End If

        Dim strRes As String = InputBox("Bitte neuen Subkategorienamen eingeben", "Shop Menü anlegen")
        If strRes.Length > 0 Then



            Dim iId As Integer = 0
            iId = lvwMenue.SelectedItems(0).SubItems(0).Text

            '# Parrent ID bestimmen 
            'Dim iParrent As Integer = clsDatenbank_modul.getCMSParent(iId)

            '# Höchster Child in Parrent 
            'Dim iChild As Integer = clsDatenbank_modul.getCMSMenue_highestChild2(iParrent)
            'iChild += 1

            '# Neues Menü anlegen
            Call clsDatenbank_modul.setCMS_NewMenue_Sub(strRes, iId)
            Call clsDatenbank_modul.getCMS_Menue_hasChildren(True, iId)

            '# MENÜ NEU GENERIEREN
            Dim strShopURL As String
            If My.Settings.shop_eiso_shopaktiv = True Then
                strShopURL = My.Settings.shop_url_eiso
            Else
                strShopURL = My.Settings.shop_url
            End If

            '# MENÜ NEU GENERIEREN [Server]
            If getHTTPResponseMessage(strShopURL & "/yabe_menue_gen.php?mod=ADD_ALL&usr=" & My.Settings.yabe_username & "&KEY=" & My.Settings.yabe_keycode & "&sprache=_de", mgetUpdaterMessage.setMenue, True) = False Then
                MsgBox("Es gab einen Fehler beim Erzeugen des Shop Menüs", MsgBoxStyle.Exclamation)
            Else

            End If

            Call setRefreshMenueList()
        End If
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        If lvwMenue.SelectedItems.Count > 0 Then
            Dim frmCMSChange As New frmCMS_change_item
            frmCMSChange.bIsNew = True
            frmCMSChange.setKategorie = lvwMenue.SelectedItems(0).SubItems(0).Text
            frmCMSChange.Show()
        Else
            MsgBox("Es wurde auf der rechten Seite keine Kategorie ausgewählt", MsgBoxStyle.Information)
        End If
    End Sub

    Function SaveRadioButton(optElement As RadioButton, tab_mode As tab_gui_radio)

        Select Case tab_mode
            Case tab_gui_radio.live
                Select Case optElement.Name
                    Case "chkLiveAlle"
                        My.Settings.eiso_gui_radio_cockpitlast_mode = 1
                    Case "chkGebote"
                        My.Settings.eiso_gui_radio_cockpitlast_mode = 2
                    Case "chkGeboteOhne"
                        My.Settings.eiso_gui_radio_cockpitlast_mode = 3
                    Case "chkBuyItNow"
                        My.Settings.eiso_gui_radio_cockpitlast_mode = 4
                End Select
            Case tab_gui_radio.bestellungen
                Select Case optElement.Name
                    Case "chkBestellungen_verkauft"
                        My.Settings.eiso_gui_radio_bestellungen_last_mode = 1
                    Case "chkBestellungen_Versand"
                        My.Settings.eiso_gui_radio_bestellungen_last_mode = 2
                    Case "chkBestellungen_KeineBewertung"
                        My.Settings.eiso_gui_radio_bestellungen_last_mode = 3
                    Case "chkBuyItNow"
                        My.Settings.eiso_gui_radio_bestellungen_last_mode = 4
                    Case "chkBestellungen_bezahlt"
                        My.Settings.eiso_gui_radio_bestellungen_last_mode = 5
                    Case "chkBestellungen_Komplett"
                        My.Settings.eiso_gui_radio_bestellungen_last_mode = 6
                    Case "chkBestellungen_Storniert"
                        My.Settings.eiso_gui_radio_bestellungen_last_mode = 7
                End Select
        End Select

    End Function

    Function SetRadioButton(tab_mode As tab_gui_radio)

        Select Case tab_mode
            Case tab_gui_radio.live
                Select Case My.Settings.eiso_gui_radio_cockpitlast_mode
                    Case "1"
                        chkLiveAlle.Checked = True
                    Case "2"
                        chkGebote.Checked = True
                    Case "3"
                        chkGeboteOhne.Checked = True
                    Case "4"
                        chkBuyItNow.Checked = True
                End Select
            Case tab_gui_radio.bestellungen
                Select Case My.Settings.eiso_gui_radio_bestellungen_last_mode
                    Case "1"
                        chkBestellungen_verkauft.Checked = True
                    Case "2"
                        chkBestellungen_Versand.Checked = True
                    Case "3"
                        chkBestellungen_KeineBewertung.Checked = True
                    Case "4"
                        chkBuyItNow.Checked = True
                    Case "5"
                        chkBestellungen_bezahlt.Checked = True
                    Case "6"
                        chkBestellungen_Komplett.Checked = True
                    Case "7"
                        chkBestellungen_Storniert.Checked = True
                End Select
        End Select

    End Function

    Private Sub chkLiveAlle_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLiveAlle.CheckedChanged
        If bIsLoading = False And chkLiveAlle.Checked = True Then

            bIsLoading = True

            My.Settings.gui_live_alle = chkLiveAlle.Checked
            My.Settings.Save()

            Call getLvwData(lvwEiSoCockpit)

            Call SaveRadioButton(chkLiveAlle, tab_gui_radio.live)

            bIsLoading = False
        End If
    End Sub

    Private Sub chkGebote_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGebote.CheckedChanged
        If bIsLoading = False And chkGebote.Checked = True Then

            bIsLoading = True

            Call getLvwData(lvwEiSoCockpit)
            'Call setStatusMessage(lvweBayLiveList)
            Call SaveRadioButton(chkGebote, tab_gui_radio.live)

            bIsLoading = False
        End If
    End Sub

    Private Sub chkBuyItNow_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBuyItNow.CheckedChanged
        If bIsLoading = False And chkBuyItNow.Checked = True Then
            bIsLoading = True

            Call getLvwData(lvwEiSoCockpit)
            Call SaveRadioButton(chkBuyItNow, tab_gui_radio.live)
            bIsLoading = False
        End If
    End Sub

    Private Sub chkeBayEnde_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If bIsLoading = False Then

                bIsLoading = True

                Call getLvwData(lvwEiSoCockpit)
                'Call setStatusMessage(lvweBayLiveList)

                If chkeBayEnde.Checked = True Then
                    '# Prüfen ob es verschickbare Artikel gibt 
                    If lvwEiSoCockpit.Items.Count = 0 Then
                        btnAuktionEinlesen.Visible = True

                        btnAuftrag_email_senden.Visible = False
                        frmMain.master_Message_label.Text = "Es wurden keine eBay Artikel zum verschicken gefunden!"
                    Else
                        btnAuftrag_email_senden.Visible = True
                        btnAuftrag_email_senden.Enabled = True
                        chkDebug_email.Visible = True

                        btnAuktionEinlesen.Visible = False
                        frmMain.master_Message_label.Text = "Es gibt '" & lvwEiSoCockpit.Items.Count & "' eBay Artikel zum verschicken gefunden!"
                    End If

                End If

                bIsLoading = False

            End If


        Catch ex As Exception
            bIsLoading = False
        End Try
    End Sub

    Private Sub chkeBayEnde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeBayEnde.CheckedChanged
        If bIsLoading = False Then
            bIsLoading = True

            Call getLvwData(lvwEiSoCockpit)
            Call getRadioOptions_counts("lvweBayLiveList")
            bIsLoading = False
            My.Settings.eiso_gui_cockpit_beendet = chkeBayEnde.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGeboteOhne.CheckedChanged

        If bIsLoading = False And chkGeboteOhne.Checked = True Then

            bIsLoading = True

            Call getLvwData(lvwEiSoCockpit)
            'Call setStatusMessage(lvweBayLiveList)

            Call SaveRadioButton(chkGeboteOhne, tab_gui_radio.live)
            bIsLoading = False
        End If

    End Sub


    Private Sub chkBestellungen_verkauft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungen_verkauft.CheckedChanged

        If chkBestellungen_verkauft.Checked = True And bIsLoading = False Then
            bIsLoading = True

            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If

            'Call getLvwData(lvweBayHistory)
            Call SaveRadioButton(chkBestellungen_verkauft, tab_gui_radio.bestellungen)
            bIsLoading = False
        End If

    End Sub

    Private Sub chkBestellungen_bezahlt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungen_bezahlt.CheckedChanged
        If chkBestellungen_bezahlt.Checked = True And bIsLoading = False Then
            bIsLoading = True
            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If
            'Call getLvwData(lvweBayHistory)
            Call SaveRadioButton(chkBestellungen_bezahlt, tab_gui_radio.bestellungen)
            bIsLoading = False
        End If
    End Sub

    Private Sub chkBestellungen_Versand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungen_Versand.CheckedChanged
        If chkBestellungen_Versand.Checked = True And bIsLoading = False Then
            bIsLoading = True
            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If
            '    Call getLvwData(lvweBayHistory)
            bIsLoading = False
        End If
    End Sub

    Private Sub chkBestellungen_KeineBewertung_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungen_KeineBewertung.CheckedChanged
        If chkBestellungen_KeineBewertung.Checked = True And bIsLoading = False Then
            bIsLoading = True
            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If
            'Call getLvwData(lvweBayHistory)
            Call SaveRadioButton(chkBestellungen_KeineBewertung, tab_gui_radio.bestellungen)
            bIsLoading = False
        End If
    End Sub

    Private Sub chkBestellungen_Storniert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungen_Storniert.CheckedChanged
        If chkBestellungen_Storniert.Checked = True And bIsLoading = False Then
            bIsLoading = True
            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If
            'Call getLvwData(lvweBayHistory)
            Call SaveRadioButton(chkBestellungen_Storniert, tab_gui_radio.bestellungen)
            bIsLoading = False
        End If
    End Sub

    Private Sub chkBestellungen_Komplett_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungen_Komplett.CheckedChanged
        If chkBestellungen_Komplett.Checked = True And bIsLoading = False Then
            bIsLoading = True
            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If
            'Call getLvwData(lvweBayHistory)
            Call SaveRadioButton(chkBestellungen_Komplett, tab_gui_radio.bestellungen)
            bIsLoading = False
        End If
    End Sub
    Private Sub bOptionsDisable(ByVal lvw As ListView, ByVal bModus As Boolean)

        Select Case lvw.Name
            Case "lvwBestellverwaltung_nach_artikel"
                chkBestellungen_Alle.Enabled = bModus
                chkBestellungen_verkauft.Enabled = bModus
                chkBestellungen_bezahlt.Enabled = bModus
                chkBestellungen_Versand.Enabled = bModus
                chkBestellungen_Komplett.Enabled = bModus
                chkBestellungen_KeineBewertung.Enabled = bModus
                chkBestellungen_Storniert.Enabled = bModus

                If bModus = False Then
                    chkBestellungen_Alle.Text = "&Alle"
                    chkBestellungen_verkauft.Text = "&Bestellt (0)"
                    chkBestellungen_bezahlt.Text = "&Bezahlt  (0)"
                    chkBestellungen_Versand.Text = "&Verschickt  (0)"
                    chkBestellungen_Komplett.Text = "&Komplett  (0)"
                    chkBestellungen_KeineBewertung.Text = "&Rückbewertung  (0)"
                    chkBestellungen_Storniert.Text = "&Storniert  (0)"
                End If

        End Select

    End Sub
    Private Sub chkBestellungenVerkauft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungenVerkauft.CheckedChanged
        If bIsLoading = False Then
            bIsLoading = True

            If chkBestellungenVerkauft.Checked = False Then
                chkBestellungen_verkauft.Checked = True
            End If

            Call getLvwData(lvwBestellverwaltung_nach_artikel)

            If chkBestellungenVerkauft.Checked = True Then
                Call bOptionsDisable(lvwBestellverwaltung_nach_artikel, True)
            Else
                Call bOptionsDisable(lvwBestellverwaltung_nach_artikel, False)
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub chkBestellungen_Alle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestellungen_Alle.CheckedChanged

        If chkBestellungen_Alle.Checked = True And bIsLoading = False Then
            bIsLoading = True
            If tcBestellungen_visual.SelectedIndex = 0 Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
            Else
                Call getLvwData(lvwBestellungen_kunden)
            End If

            'Call getLvwData(lvweBayHistory)
            Call SaveRadioButton(chkBestellungen_Alle, tab_gui_radio.bestellungen)

            bIsLoading = False
        End If
    End Sub



    Private Sub YABEImportVonArtikelnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEImportVonArtikelnToolStripMenuItem.Click
        Dim frmImport As New frmCMS_ShopImporter
        frmImport.ShowDialog(Me)
    End Sub

    Private Sub cms_KategorieListe_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cms_KategorieListe.Opening
        '# Importieren im Menü angeklickt
        If lvwMenue.SelectedItems.Count > 0 Then
            If lvwMenue.SelectedItems(0).SubItems(1).Text = "Importieren" Then
                YABEImportVonArtikelnToolStripMenuItem1.Visible = True
            Else
                YABEImportVonArtikelnToolStripMenuItem1.Visible = False
            End If

        End If
    End Sub

    Private Sub YABEImportVonArtikelnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YABEImportVonArtikelnToolStripMenuItem1.Click
        Dim frmImport As New frmCMS_ShopImporter
        frmImport.ShowDialog(Me)
    End Sub



    '############################################################
    '# >> Shop Menü Clonen (schneller) 
    '############################################################
    Public Function getShopMenue(ByRef lvw As ListView) As Boolean
        Try
            Dim isel As Integer = 0
            If lvwMenue.SelectedItems.Count > 0 Then
                isel = lvwMenue.SelectedItems(0).Index
            End If

            If lvwMenue.Items.Count > 0 Then
                Dim iCount As Integer = 0
                '# Alle Anzeigen 
                '# Importieren 
                '# weglassen deshalb bei iCount = 2 
                For iCount = 2 To lvwMenue.Items.Count - 1
                    Dim lvwItem As New ListViewItem
                    lvwItem = lvwMenue.Items(iCount).Clone
                    lvw.Items.Add(lvwItem)
                Next
                If isel > 1 Then
                    lvw.Items(isel - 2).Selected = True
                    lvw.Items(isel - 2).EnsureVisible()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub lvwWebArtikel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwWebArtikel.MouseHover
        Application.DoEvents()
        lvwWebArtikel.Focus()
    End Sub

    Private Sub lvwMenue_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwMenue.MouseHover
        Application.DoEvents()
        lvwMenue.Focus()
    End Sub

    Private Sub KategorieLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategorieLöschenToolStripMenuItem.Click
        If lvwMenue.SelectedItems.Count > 0 Then

            If MsgBox("Möchten Sie die Kategorie '" & lvwMenue.SelectedItems(0).SubItems(1).Text & "' wirklich löschen?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                clsDatenbank_modul.setCMSMenue_delete(lvwMenue.SelectedItems(0).Text)
                lvwMenue.SelectedItems(0).Remove()
            End If

        End If
    End Sub

    Private Sub ArtikelAlleImportiertenLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelAlleImportiertenLöschenToolStripMenuItem.Click
        If MsgBox("Möchten Sie die alle importierten Artikel wirklich löschen?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            clsDatenbank_modul.setCMS_import_delete()
            lvwWebArtikel.Clear()
        End If
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        Call export(lvweBayBewertung)
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DeutschToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeutschToolStripMenuItem.Click
        clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", lvwMenue, "Deutsch")
        lvwMenueSprache = "Deutsch"
    End Sub

    Private Sub EnglischToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglischToolStripMenuItem.Click
        clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", lvwMenue, "Englisch")
        lvwMenueSprache = "Englisch"
    End Sub

    Private Sub FranzösichToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FranzösichToolStripMenuItem.Click
        clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", lvwMenue, "Französisch")
        lvwMenueSprache = "Französisch"
    End Sub

    Private Sub AutomatischSpracheÄndernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomatischSpracheÄndernToolStripMenuItem.Click
        If AutomatischSpracheÄndernToolStripMenuItem.Checked = False Then
            AutomatischSpracheÄndernToolStripMenuItem.Checked = True
        Else
            AutomatischSpracheÄndernToolStripMenuItem.Checked = False
        End If
        My.Settings.gui_artikel_menuesprache = AutomatischSpracheÄndernToolStripMenuItem.Checked
        My.Settings.Save()
    End Sub

    Private Sub MenüÜbersetzungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenüÜbersetzungToolStripMenuItem.Click
        Dim frmTranslate As New frmCMS_translate_menue
        frmTranslate.ShowDialog(Me)
    End Sub

    Private Sub BildLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BildLöschenToolStripMenuItem.Click

        If lvwEiSoCockpit.SelectedItems.Count > 0 Then
            setDeletePictures(lvwEiSoCockpit.SelectedItems(0).SubItems(13).Text, True)
        End If

    End Sub

    Private Sub MagentoKategorieIDZuweisenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentoKategorieIDZuweisenToolStripMenuItem1.Click

        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim frmDialog As New frmDelcampeIDZuweisung
            frmDialog.bModus_select = frmDelcampeIDZuweisung.bModus.magento
            frmDialog.bMulti_select = frmDelcampeIDZuweisung.bMultiSelect.multiselect
            frmDialog.iCMSMenueID = lvwWebArtikel.SelectedItems(0).Text
            'frmDialog.strKategorieName = lvwMenue.SelectedItems(0).SubItems(1).Text
            frmDialog.lvwData_multiselect = lvwWebArtikel
            frmDialog.txtDelcampeID.Text = lvwWebArtikel.SelectedItems(0).SubItems(5).Text
            frmDialog.Show(Me)
        Else
            MessageBox.Show("Bitte eine Kategorie auswählen im Kategorie links", "YABE Kategorie auswählen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnGoogleBase_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GruppiertKeineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruppiertKeineToolStripMenuItem.Click
        My.Settings.yabe_gui_bestellverwaltung_groupby_KeineGruppierung = GruppiertKeineToolStripMenuItem.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnPaypal_abrufen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaypal_abrufen.Click
        Dim paypal As New clsPaypal


        '# Paypal Daten abrufen 
        If My.Settings.APP_paypal_username.Length = 0 Then
            MsgBox("Bitte unter den Einstellungen -> Paypal API Verbindung herstellen", MsgBoxStyle.Information)
            'Dim frmOption As New frmOptions
            'frmOption.ShowDialog()
            Exit Sub
        End If

        btnPaypal_abrufen.Enabled = False
        paypal.API_Username = My.Settings.APP_paypal_username
        paypal.API_Signature = My.Settings.APP_paypal_signature
        paypal.API_Passwort = My.Settings.APP_paypal_pwd
        lvwPaypal.Items.Clear()
        paypal.getTransaktions(lvwPaypal, dtPaypal)
        btnPaypal_abrufen.Enabled = True

        If lvwPaypal.Items.Count > 0 Then
            lvwPaypal.Items(0).Selected = True
        End If
    End Sub

    Private Sub lvwPaypal_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwPaypal.ColumnClick
        Call setSort(lvwPaypal, e)
    End Sub

    Private Sub lvwEbayNachrichten_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwEbayNachrichten.ColumnClick
        Call setSort(lvwEbayNachrichten, e)
    End Sub

    Private Sub lvwEbayRechnung_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwEbayRechnung.ColumnClick
        Call setSort(lvwEbayRechnung, e)
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        If lvwPaypal.SelectedItems.Count > 0 Then
            txtSuchen.Text = lvwPaypal.SelectedItems(0).Text
            bGUISuchen = True
            tabMenue.SelectedIndex = 2
            bGUISuchen = False
            btnSuchen.PerformClick()
        End If

    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        If lvwPaypal.SelectedItems.Count > 0 Then
            Call getOrderHistory(lvwPaypal, lvwPaypal.SelectedItems(0).SubItems(2).Text)
        End If
    End Sub

    Private Sub SucheBewertungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucheBewertungenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            txtSuchen.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(1).Text
            bGUISuchen = True
            tabMenue.SelectedIndex = 3
            bGUISuchen = False
            btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub HochToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HochToolStripMenuItem.Click
        If lvwMenue.SelectedItems.Count > 0 Then
            clsDatenbank_modul.setMenue_order(lvwMenue.SelectedItems(0).Text, "hoch")
        End If

    End Sub

    Private Sub RunterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunterToolStripMenuItem.Click

        If lvwMenue.SelectedItems.Count > 0 Then
            clsDatenbank_modul.setMenue_order(lvwMenue.SelectedItems(0).Text, "runter")
        End If

    End Sub

    Private Sub chkShopUpdateItemCount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShopUpdateItemCount.CheckedChanged
        My.Settings.yabe_gui_cms_update = chkShopUpdateItemCount.Checked
        My.Settings.Save()
    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clseBayAPI.setSessionID()
    End Sub

    Private Sub chkeBayBewertungen_allebewerted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeBayBewertungen_allebewerted.CheckedChanged
        chkeBayBewertungen_allebewerted.Enabled = False

        If MsgBox("Möchten Sie alle offnen Bewertungen, als Bewertet setzten" & vbCrLf & vbCrLf & "Sie haben bereits alle bei eBay Bewertet", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clsDatenbank_modul.seteBayBewertungen_bewertet(lvwBewertungen, pgrBewertungenUpdate)
        End If

        chkeBayBewertungen_allebewerted.Checked = False
        chkeBayBewertungen_allebewerted.Enabled = True
    End Sub

    Private Sub chkeBayBewertung_automatischRE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeBayBewertung_automatischRE.CheckedChanged
        My.Settings.yabe_gui_bewerten_chkRückbewertung = chkeBayBewertung_automatischRE.Checked
        My.Settings.Save()
    End Sub

    Private Sub AnzahlUpdatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnzahlUpdatenToolStripMenuItem.Click
        setRefreshMenueList(True)
    End Sub

    Private Sub KundenVon_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KundenVon.KeyDown
        If bIsLoading = False Then
            bIsLoading = True

            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwKunden)
                KundenVon.Focus()
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub KundenBis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KundenBis.KeyDown
        If bIsLoading = False Then
            bIsLoading = True

            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwKunden)
                KundenBis.Focus()
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub eBayHistoryBis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles eBayHistoryBis.KeyDown
        If bIsLoading = False Then
            bIsLoading = True

            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
                eBayHistoryBis.Focus()
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub eBayHistoryVon_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles eBayHistoryVon.KeyDown
        If bIsLoading = False Then
            bIsLoading = True

            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwBestellverwaltung_nach_artikel)
                eBayHistoryVon.Focus()
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub dtp_BewertungVon_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_BewertungVon.KeyDown
        If bIsLoading = False Then
            bIsLoading = True

            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwBewertungen)
                dtp_BewertungVon.Focus()
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub dtp_BewertungBis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_BewertungBis.KeyDown
        If bIsLoading = False Then
            bIsLoading = True

            '# Enter gedrückt 
            If e.KeyCode = Keys.Enter Then
                Call getLvwData(lvwBewertungen)
                dtp_BewertungBis.Focus()
            End If

            bIsLoading = False
        End If
    End Sub

    Private Sub dtp_BewertungBis_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_BewertungBis.ValueChanged

    End Sub

    Private Sub dtp_BewertungVon_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_BewertungVon.ValueChanged

    End Sub

    Private Sub SYNCStatusBezahltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYNCStatusBezahltToolStripMenuItem.Click

        If lvwPaypal.SelectedItems.Count > 0 Then
            Dim frmPaypal As New frmPaypal_status
            frmPaypal.lvwDataInput = lvwPaypal
            frmPaypal.Show()
        End If

    End Sub

    Private Sub btnPaypalBestellstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaypalBestellstatus.Click

        If lvwPaypal.SelectedItems.Count > 0 Then
            Dim frmPaypal As New frmPaypal_status
            frmPaypal.lvwDataInput = lvwPaypal
            frmPaypal.Show()
        End If

    End Sub

    Private Sub lvwPaypal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwPaypal.SelectedIndexChanged
        If lvwPaypal.SelectedItems.Count > 0 Then
            btnPaypalBestellstatus.Enabled = True
        End If
    End Sub

    Private Sub EBayStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayStatusToolStripMenuItem.Click
        clseBayAPI.setCompleteSale(lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text, "bestellt")
    End Sub

    Private Sub ArtikelHinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelHinzufügenToolStripMenuItem.Click
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwWebArtikel.SelectedItems.Count - 1

                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwWebArtikel.SelectedItems.Count - 1 & " " & lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text

                Dim arryList As New ArrayList
                arryList.Add("0.0") ' Gewicht
                arryList.Add("1") ' Steuerklasse 
                arryList.Add(lvwWebArtikel.SelectedItems(iloop).SubItems(2).Text) ' Preis
                arryList.Add(lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text) ' Kurzbeschreibung
                arryList.Add(lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text) ' Lange Beschreibung

                If lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text.Length > 40 Then
                    arryList.Add(lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text.Substring(0, 40)) ' Name
                End If

                arryList.Add("1") ' Status (Aktiv)
                arryList.Add("4") ' Sichtbarkeit (4 = Katalog, Suche)
                arryList.Add(lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text) ' URL KEY 
                arryList.Add(24) ' Atributset
                arryList.Add(lvwWebArtikel.SelectedItems(iloop).SubItems(0).Text) ' 10. SKU 
                arryList.Add(lvwWebArtikel.SelectedItems(iloop).SubItems(4).Text) ' Kategorien
                Application.DoEvents()
                If Not mc.setItemNew(arryList) = -1 Then
                    '# Bild hochladen
                    frmMain.master_Message_label.Text = "Lade Bild hoch..."
                    Application.DoEvents()
                    Call mc.setNewImage(lvwWebArtikel.SelectedItems(iloop).SubItems(0).Text, lvwWebArtikel.SelectedItems(iloop).SubItems(3).Text)
                End If

            Next

            MsgBox("Der Artikel wurde neu hinzugefügt", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ArtikelLöschenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelLöschenToolStripMenuItem2.Click
        If lvwWebArtikel.SelectedItems.Count > 0 Then

            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwWebArtikel.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwWebArtikel.SelectedItems.Count - 1 & " " & lvwWebArtikel.SelectedItems(0).SubItems(1).Text
                Application.DoEvents()

                mc.setItem_delete(lvwWebArtikel.SelectedItems(iloop).Text)
            Next


            MsgBox("Der Artikel wurde gelöscht", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub ArtikelBestelltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelBestelltToolStripMenuItem.Click
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwWebArtikel.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwWebArtikel.SelectedItems.Count - 1 & " " & lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()
                Call mc.setItem_update_disable(lvwWebArtikel.SelectedItems(iloop).SubItems(0).Text, "2")
            Next


            MsgBox("Der Artikel wurde auf bestellt gestellt", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ArtikelAktivToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelAktivToolStripMenuItem.Click
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwWebArtikel.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwWebArtikel.SelectedItems.Count - 1 & " " & lvwWebArtikel.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()
                Call mc.setItem_update_disable(lvwWebArtikel.SelectedItems(iloop).SubItems(0).Text, "1")
            Next


            MsgBox("Der Artikel wurde wieder aktiviert", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ArtikelLöschenToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelLöschenToolStripMenuItem3.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then


            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1 & " " & lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()
                If lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "CMS" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(0).Text
                    Dim str() As String = strSKU.Split("-")
                    Call mc.setItem_delete(str(0))
                ElseIf lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "delcampe" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(15).Text
                    Dim strYABEID() As String = strSKU.Split("-")
                    Call mc.setItem_delete(strYABEID(0))
                ElseIf lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "Magento" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(15).Text
                    Dim strYABEID() As String = strSKU.Split("-")
                    Call mc.setItem_delete(strYABEID(0))
                End If

            Next

            MsgBox("Artikel wurden gelöscht", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ArtikelBestelltToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelBestelltToolStripMenuItem1.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then


            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1 & " " & lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()
                If lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "CMS" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(0).Text
                    Dim str() As String = strSKU.Split("-")
                    Call mc.setItem_update_disable(str(0), "2")
                ElseIf lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "delcampe" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(15).Text
                    Dim strYABEID() As String = strSKU.Split("-")
                    Call mc.setItem_update_disable(strYABEID(0), "2")
                ElseIf lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "Magento" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(15).Text
                    Dim strYABEID() As String = strSKU.Split("-")
                    Call mc.setItem_update_disable(strYABEID(0), "2")
                End If

            Next

            MsgBox("Artikel wurden auf bestellt gestellt", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ArtikelAktivierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtikelAktivierenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then


            Dim iloop As Integer = 0
            Dim mc As New clsMagentoAPI
            mc.getLogin()

            For iloop = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1
                frmMain.master_Message_label.Text = iloop + 1 & " / " & lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1 & " " & lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(1).Text
                Application.DoEvents()
                If lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "CMS" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(0).Text
                    Dim str() As String = strSKU.Split("-")
                    Call mc.setItem_update_disable(str(0), "1")
                ElseIf lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "delcampe" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(15).Text
                    Dim strYABEID() As String = strSKU.Split("-")
                    Call mc.setItem_update_disable(strYABEID(0), "1")
                ElseIf lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(13).Text = "Magento" Then
                    Dim strSKU As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iloop).SubItems(15).Text
                    Dim strYABEID() As String = strSKU.Split("-")
                    Call mc.setItem_update_disable(strYABEID(0), "1")
                End If

            Next
            MsgBox("Artikel wurden wieder aktiviert ", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ArtikelHinzufügenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DeutschSuchenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeutschSuchenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmDelcampe As New frmOutlook_sync_duplicate
            Dim strText As String = ""

            frmDelcampe.bLoadTextSearch = True
            frmDelcampe.strSprache = "DE"

            If lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text = "CMS" Then
                Dim str() As String = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(0).Text.Split("-")
                frmDelcampe.strReferenz = str(0)
            Else
                frmDelcampe.strReferenz = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(15).Text
            End If

            strText = clsDatenbank_modul.getCMS_ShopItems("Beschreibung", frmDelcampe.strReferenz)

            If strText.Length > 81 Then
                strText = strText.Substring(0, 81)
            End If

            frmDelcampe.txtSuche.Text = strText

            'frmDelcampe.txtSuche.Text = lvweBayHistory.SelectedItems(0).SubItems(4).Text
            frmDelcampe.Show()
        End If

    End Sub

    Private Sub EnglischSuchenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglischSuchenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim strText As String = ""
            Dim frmDelcampe As New frmOutlook_sync_duplicate
            frmDelcampe.bLoadTextSearch = True

            If lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text = "CMS" Then
                Dim str() As String = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(0).Text.Split("-")
                frmDelcampe.strReferenz = str(0)
            Else
                frmDelcampe.strReferenz = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(15).Text
            End If

            frmDelcampe.strSprache = ""
            strText = clsDatenbank_modul.getCMS_ShopItems("Beschreibung", frmDelcampe.strReferenz)

            If strText.Length > 81 Then
                strText = strText.Substring(0, 81)
            End If

            frmDelcampe.txtSuche.Text = strText
            ' frmDelcampe.txtSuche.Text = lvweBayHistory.SelectedItems(0).SubItems(4).Text
            frmDelcampe.Show()
        End If
    End Sub

    Private Sub LöschenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem1.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then


            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text.Split("-")

                Dim strBild As String = clsDatenbank_modul.getCMS_ShopItems("Bild", strYABEID(0))

                If setDeletePictures(strBild, True) = True Then
                    If clsDatenbank_modul.getCMS_items_delete("DELETE FROM tblGes WHERE ID=" & strYABEID(0)) = True Then
                        frmMain.master_Message_label.Text = lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(14).Text & " / " & lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text
                    Else
                        MsgBox("Probleme beim Löschen des Artikels mit ID: '" & lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text & "'  auf dem Server", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Probleme beim Löschen des Bildes Artikels mit ID: '" & lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text & "' auf dem Server", MsgBoxStyle.Exclamation)
                End If

            Next

            MsgBox("Artikel gelöscht", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub WartelisteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WartelisteToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(2, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'Warteliste' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub BestelltToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestelltToolStripMenuItem1.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(1, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'bestellt' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub AktivToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktivToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(0, strYABEID(0))
            Next

        End If
        MsgBox("Artikel auf 'aktiv' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub BildAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BildAnzeigenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim frmPicture As New frmShowPicture
            frmPicture.strYABE_ID = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(15).Text
            frmPicture.Show()
        End If

    End Sub

    Private Sub HatUntekategorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HatUntekategorieToolStripMenuItem.Click
        clsDatenbank_modul.getCMS_Menue_hasChildren(True, lvwMenue.SelectedItems(0).Text)
    End Sub

    Private Sub KeineUnterkategorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeineUnterkategorieToolStripMenuItem.Click
        clsDatenbank_modul.getCMS_Menue_hasChildren(False, lvwMenue.SelectedItems(0).Text)
    End Sub

    Private Sub NeueKatGleicheEbeneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeueKatGleicheEbeneToolStripMenuItem.Click
        Dim strRes As String = InputBox("Bitte neuen Subkategorienamen eingeben", "Shop Menü anlegen")
        If strRes.Length > 0 Then



            Dim iId As Integer = 0
            iId = lvwMenue.SelectedItems(0).SubItems(0).Text

            Dim iParrent As Integer = clsDatenbank_modul.setCMS_NewMenue_parrent(iId)
            '# Neues Menü anlegen
            Call clsDatenbank_modul.setCMS_NewMenue_Sub(strRes, iParrent)


            '# MENÜ NEU GENERIEREN [Server]
            Dim strShopURL As String
            If My.Settings.shop_eiso_shopaktiv = True Then
                strShopURL = My.Settings.shop_url_eiso
            Else
                strShopURL = My.Settings.shop_url
            End If

            If getHTTPResponseMessage(strShopURL & "/yabe_menue_gen.php?mod=ADD_ALL&usr=" & My.Settings.yabe_username & "&KEY=" & My.Settings.yabe_keycode & "&sprache=_de", mgetUpdaterMessage.setMenue, True) = False Then
                MsgBox("Es gab einen Fehler beim Erzeugen des Shop Menüs", MsgBoxStyle.Exclamation)
            Else
            End If
            Call setRefreshMenueList()

        End If
    End Sub

    Private Sub FinanceOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinanceOfficeToolStripMenuItem.Click

        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            Dim clsFinanceOffice As New Lexware_finance_office
            Dim iLoop As Integer = 0
            Dim sLine As String
            Dim strEmails As String = ""
            Dim sFile_kunden As String = My.Settings.yabe_finance_office_export & "\finance-office-kunden " & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & ".txt"
            Dim sFile_artikel As String = My.Settings.yabe_finance_office_export & "\finance-office-artikel " & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & ".txt"

            If Not IO.Directory.Exists(My.Settings.yabe_finance_office_export) Then
                MsgBox("Das Finance Office Export-Verzeichnis wurde unter 'Einstellungen -> Rechnungen' nicht ausgewählt")
                Exit Sub
            End If

            '##########################################################
            '# >> Kunden einlesen 
            '##########################################################
            sLine = "Kontonummer;Kontobezeichnung;Kundennummer;Anrede;Firma;Name;Vorname;Zusatz;Land;Straße;Postleitzahl;Ort;Ansprechpartner;Telefon1;Telefon2;Telefax;E-Mail;Bankleitzahl;Bankkonto;BIC;IBAN;Bankbezeichnung;Zahlungsziel;Skonto %;Skonto Ziel;Einzugsermächtigung"
            sLine &= vbCrLf

            For iLoop = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1

                If strEmails.IndexOf(lvwBestellverwaltung_nach_artikel.SelectedItems(iLoop).SubItems(9).Text) = -1 Then
                    strEmails &= lvwBestellverwaltung_nach_artikel.SelectedItems(iLoop).SubItems(9).Text & ", "
                    sLine &= clsFinanceOffice.setExport_kunden(sLine, lvwBestellverwaltung_nach_artikel.SelectedItems(iLoop).SubItems(9).Text)
                    sLine &= vbCrLf
                End If

            Next

            'Existierende Datei löschen
            Dim oFI As New IO.FileInfo(sFile_kunden)
            If oFI.Exists Then
                oFI.Delete()
            End If
            Dim oFS As New IO.FileStream(sFile_kunden, IO.FileMode.CreateNew, IO.FileAccess.Write)
            Dim oSW As New IO.StreamWriter(oFS, System.Text.Encoding.Default)
            oSW.Write(sLine)
            oSW.Flush()
            oSW.Close()
            oFS.Close()



            '##########################################################
            '# >> Artikel einlesen 
            '##########################################################
            sLine = "Artikelnummer;Bezeichnung;Einheit;Gewicht;Matchcode;Preis pro Anzahl"
            sLine &= vbCrLf
            For iLoop = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1


                sLine &= clsFinanceOffice.setExport_artikel(sLine, lvwBestellverwaltung_nach_artikel.SelectedItems(iLoop))
                sLine &= vbCrLf


            Next

            'Existierende Datei löschen
            Dim oFI2 As New IO.FileInfo(sFile_artikel)
            If oFI2.Exists Then
                oFI2.Delete()
            End If
            Dim oFS2 As New IO.FileStream(sFile_artikel, IO.FileMode.CreateNew, IO.FileAccess.Write)
            Dim oSW2 As New IO.StreamWriter(oFS2, System.Text.Encoding.Default)
            oSW2.Write(sLine)
            oSW2.Flush()
            oSW2.Close()
            oFS2.Close()
        End If
    End Sub

    Private Sub APILöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APILöschenToolStripMenuItem.Click
        If lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text = "CMS" Or lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text = "delcampe" Or lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text = "Magento" Or lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(13).Text = "Shopste" Then

            Dim iCount As Integer = 0
            For iCount = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1


                Dim str() As String = lvwBestellverwaltung_nach_artikel.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Dim strPath As String = My.Settings.ServerDatenaustausch_url_delcampe & "?ref_id=" & str(0) & "-Deutsch"

                If getHTTPResponseMessage(strPath, mgetUpdaterMessage.setDelcampe_delete_auction, True) = True Then

                End If

                frmMain.master_Message_label.Text = "Bei " & (iCount + 1) & " | " & lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1

                If My.Settings.delcampe_DE_EN_DELETE = True Then
                    strPath = My.Settings.ServerDatenaustausch_url_delcampe & "?ref_id=" & str(0) & "-Englisch"

                    If getHTTPResponseMessage(strPath, mgetUpdaterMessage.setDelcampe_delete_auction, True) = True Then

                    End If
                End If
            Next

        End If

    End Sub

    Private Sub DelcampeListerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelcampeListerToolStripMenuItem.Click
        '# 3
        If lvwWebArtikel.SelectedItems.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To lvwWebArtikel.SelectedItems.Count - 1
                Call clsDatenbank_modul.setWebartikelStatus(3, lvwWebArtikel.SelectedItems(i).SubItems(0).Text)
            Next

            MsgBox("Artikel wurde erfolgreich als Vorrat markiert", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click_3(sender As System.Object, e As System.EventArgs) Handles btnQuickSync.Click
        Try

            btnQuickSync.Enabled = False
            lvwEiSoCockpit.Items.Clear()

            setBludauMediaLogbuch(">> COCKPIT >> eBay QUICK SYNC für Mitglied " & My.Settings.ebay_username & "...", "COCKPIT")

            clseBayAPI.getSellerEvents(lvwEiSoCockpit, dtpCockpit_von.Value, dtpCockpit_bis.Value)

            '# Zähler für Checkboxen 
            'Call getRadioOptions_counts(lvweBayLiveList.Name)
            Call setStatusMessage(lvwEiSoCockpit)

            setBludauMediaLogbuch(">> COCKPIT >> eBay QUICK SYNC beendet für Mitglied " & My.Settings.ebay_username, "COCKPIT")

            btnQuickSync.Enabled = True
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "btnGetSellerEvents")
            btnQuickSync.Enabled = True
        End Try
    End Sub

    Private Sub chkMitWebgalerie_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMitWebgalerie.CheckedChanged
        My.Settings.yabe_cockpit_mitwebgalerie = chkMitWebgalerie.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnBestellungAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnBestellungAdd.Click

    End Sub

    Private Sub ShopsteKategorieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopsteKategorieToolStripMenuItem.Click
        Dim frmShopsteKat As New frmShopsteKategorieMapping
        frmShopsteKat.iMenue = lvwMenue.SelectedItems(0).SubItems(0).Text
        frmShopsteKat.Show()
    End Sub

    Private Sub TreeView1_ClientSizeChanged(sender As Object, e As EventArgs) Handles TreeView1.ClientSizeChanged

    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Try

            lbltmp.Text = e.Node.Name
            Call getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=get_category_item&domain_id=" & My.Settings.domain_id & " &shop_cat_id=" & e.Node.Name, mgetUpdaterMessage.getShopsteCategoryItems, True)

            Dim strContent As String = My.Computer.FileSystem.ReadAllText("shopste-kategorie-items.dat")
            Dim i As Integer = 0

            Dim strLines() As String = strContent.Split("<br>")
            lvwShopste.Items.Clear()
            ImageList1.Images.Clear()
            Dim strErrorMessage As String = ""
            For i = 0 To strLines.Length - 3

                Dim strData() As String = strLines(i).Split("~")
                Dim lvwItem As New ListViewItem
                Dim strFilename() As String = strData(0).Split("/")
                Dim strBildname As String
                strBildname = strFilename(strFilename.Length - 1)
                strBildname = strBildname.Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "")
                strBildname = strBildname.Replace("<", "").Replace(">", "").Replace("|", "").Replace("ß", "")
                strBildname = strBildname.Substring(0, Math.Min(strBildname.Length, 240))
                'My.Computer.Network.DownloadFile("http://shopste.com" & strData(0).Replace("br>", "").Replace("/orginal/", "/kategorie/"), Application.StartupPath & "\bilderexport\" & strFilename(strFilename.Length - 1).Replace(":", ""))

                If Not strBildname = "br>" Then
                    If IO.File.Exists(Application.StartupPath & "\bilderexport\" & strBildname) = True Then
                        ImageList1.Images.Add(strData(4), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildname))
                        lvwItem.ImageKey = strData(4)
                    Else
                        If Not strData(0).Length = 0 Then
                            Try
                                My.Computer.Network.DownloadFile("http://shopste.com" & strData(0).Replace("br>", "").Replace("/orginal/", "/kategorie/"), Application.StartupPath & "\bilderexport\" & strBildname)


                                ImageList1.Images.Add(strData(4), Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & strBildname))
                                lvwItem.ImageKey = strData(4)
                            Catch ex As Exception
                                strErrorMessage = ex.Message
                            End Try

                        End If

                    End If
                End If


                lvwItem.Text = "" 'strData(0)
                lvwItem.SubItems.Add(strData(1))
                lvwItem.SubItems.Add(strData(2))
                lvwItem.SubItems.Add(strData(3))
                lvwItem.SubItems.Add(strData(5))
                lvwItem.SubItems.Add(strData(6))
                lvwItem.SubItems.Add(strData(4))
                If (strData(7) = "Y") Then
                    lvwItem.SubItems.Add("Aktiv")
                Else
                    lvwItem.SubItems.Add("Inaktiv")
                End If

                lvwShopste.Items.Add(lvwItem)


            Next
            If strErrorMessage.Length > 0 Then
                MessageBox.Show(strErrorMessage)
            End If
            'txtShopsteID.Text = e.Node.Tag
            Label33.Text = e.Node.Text
        Catch ex As Exception
            Call debug_message(ex, "NodeMouseClick")
        End Try

    End Sub

    Private Sub EiSoShopKategorienZuShopstecomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EiSoShopKategorienZuShopstecomToolStripMenuItem.Click
        If My.Settings.shopste_main_kategorie.Length > 0 Then
            clsDatenbank_modul.getCMS_Menue_tree_import_shopste(0, lvwShopste, 0, My.Settings.shopste_main_kategorie)
        Else
            MessageBox.Show("Bitte erst Tab Shopste.com öffnen und sich anmelden", "Shopste-Daten", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub EiSo2ShopsteArtikelImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EiSo2ShopsteArtikelImportToolStripMenuItem.Click
        Dim strLokalFile As String
        Dim strLast As String
        Dim strImportError As String = ""
        Dim iCount As Integer = 0
        Dim strBeschreibung As String = ""

        If lvwMenue.SelectedItems(0).Text.Length = 0 Then
            MessageBox.Show("Bitte EiSo Shop Menü auswählen", "Artikelauswahl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If lvwWebArtikel.SelectedItems.Count = 0 Then
            MessageBox.Show("Bitte Artikel auswählen um diese nach Shopste.com zu übertragen STRG + Artikelklick oder STRG + A", "Artikelauswahl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If




        For iCount = 0 To lvwWebArtikel.SelectedItems.Count - 1

            getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=get_shopste_kategorie_by_eisocatid&eiso_cat_id=" & lvwWebArtikel.SelectedItems(iCount).SubItems(11).Text & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort, mgetUpdaterMessage.getEiSo2ShopsteKat, False)

            If Not IsNumeric(strHTTPDataStore) = True Then
                MessageBox.Show("Es wurde keine gültige Shopste.com Kategorie gefunden.", "ungültige Kategorie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Continue For
            End If

            ' lvwWebArtikel.Items(iCount).Selected = True
            ' Application.DoEvents()

            Dim Request As HttpWebRequest = CType(WebRequest.Create(My.Settings.SHOPSTE_API_URL), HttpWebRequest)
            Request.Method = "POST"
            Request.ContentType = "application/x-www-form-urlencoded"
            frmMain.master_Message_label.Text = iCount & " | " & lvwWebArtikel.SelectedItems.Count - 1 & " - Bereite einfügen vor..."
            Application.DoEvents()
            'MessageBox.Show(System.Net.WebUtility.HtmlEncode(ListView1.SelectedItems(0).SubItems(0).Text))
            'System.Net.WebUtility.HtmlEncode
            ' Dim strBeschreibung As String
            ' If chkImportKeineHTMLBeschreibung.Checked = False Then
            strBeschreibung = HttpUtility.UrlEncode(HttpUtility.HtmlEncode(lvwWebArtikel.SelectedItems(iCount).SubItems(1).Text))
            ' Else
            ' strBeschreibung = HttpUtility.UrlEncode(lvwWebArtikel.SelectedItems(0).SubItems(0).Text)
            ' End If

            '# Letztes zu importierendes Produkt?
            If iCount = lvwWebArtikel.SelectedItems.Count - 1 Then
                strLast = "true"
            Else
                strLast = "false"
            End If


            Dim Post As String = "modus=system_shop_item_add&domain_id=" & My.Settings.domain_id & "&shop_item_beschreibung=" & strBeschreibung & "&shop_item_menge=" & lvwWebArtikel.SelectedItems(iCount).SubItems(9).Text & "&shop_item_price=" & lvwWebArtikel.SelectedItems(iCount).SubItems(2).Text.Replace(",", ".") & "&shop_item_name=" & HttpUtility.UrlEncode(lvwWebArtikel.SelectedItems(iCount).SubItems(1).Text) & "&shop_item_duration=15&shop_item_mwst=19&shop_item_artikelnummer=" & lvwWebArtikel.SelectedItems(iCount).SubItems(0).Text & "&bLastItem=" & strLast & "&user=" & My.Settings.benutzername & "&subshop_cat=" & strHTTPDataStore & "&shopste_cat=" & lvwWebArtikel.SelectedItems(iCount).SubItems(12).Text & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort

            ' Clipboard.SetText(WebUtility.HtmlEncode(ListView1.SelectedItems(0).SubItems(5).Text))

            'Dim postQuery As Byte() = System.Text.Encoding.ASCII.GetBytes("Post 

            Dim byteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(Post)
            Request.ContentLength = byteArray.Length
            Dim DataStream As System.IO.Stream = Request.GetRequestStream()
            DataStream.Write(byteArray, 0, byteArray.Length)
            DataStream.Close()
            Dim Response As HttpWebResponse = Request.GetResponse()
            DataStream = Response.GetResponseStream()
            Dim reader As New System.IO.StreamReader(DataStream)
            Dim ServerResponse As String = reader.ReadToEnd()
            reader.Close()
            DataStream.Close()
            Response.Close()



            If InStr(ServerResponse, "shopid") Then
                Dim str() As String = ServerResponse.Split(":")
                Dim shopid_picture As String = str(1)


                clsDatenbank_modul.setEiSoArtikelverwaltung_shopste_summary(lvwWebArtikel.SelectedItems(0).Text, str(1), lvwWebArtikel.SelectedItems(iCount).SubItems(9).Text)

                frmMain.master_Message_label.Text = iCount & " | " & lvwWebArtikel.SelectedItems.Count - 1 & " - Shop ID:" & ServerResponse

                Dim strFileName() As String = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text.Split("/")

                Dim nvc As New Specialized.NameValueCollection
                nvc.Add("modus", "system_upload_file")
                nvc.Add("domain_id", My.Settings.domain_id)
                nvc.Add("benutzername", My.Settings.benutzername)
                nvc.Add("domain_pfad", My.Settings.domain_name)
                nvc.Add("shop_id", shopid_picture)
                ' nvc.Add("picture_name", lvwWebArtikel.Items(iCount).SubItems(3).Text.Replace(" ", "_").Replace(">", "-").Replace("/", "").Replace("\", "").Replace("!", ""))
                Dim strBildName As String = lvwWebArtikel.SelectedItems(iCount).SubItems(1).Text.Replace(" ", "_").Replace(">", "-").Replace("/", "").Replace("\", "").Replace("!", "").Replace("*", "").Replace("<", "-") & ".jpg"
                nvc.Add("picture_name", strBildName)

                '# Externe Bilder - HTTP Link
                If Not lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text.LastIndexOf("http://") = -1 Then

                    Dim client As New WebClient()

                    Dim strBild As String
                    Dim strBild_ary() As String
                    Dim strBildFixed As String = strFileName(strFileName.Length - 1).Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "").Replace("<", "").Replace(">", "").Replace("|", "")
                    'MessageBox.Show(Application.StartupPath)
                    ' Dim strPath As String = IO.Path.GetDirectoryName(Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
                    ' MessageBox.Show(Application.StartupPath)
                    If My.Settings.domain_id = 43 Then
                        strBild_ary = strBildName.Split("/")
                        If strBild_ary.Length = 1 Then
                            strBild = "https://philafriend.de/eBay/TN_" & strBildFixed
                        Else
                            strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                            strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                            strBild = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text.Replace("http://", "https://")
                            strBild_ary = strBild.Split("/")
                            strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))

                        End If

                    Else
                        strBild = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text
                    End If

                    Try

                        If strBildFixed.Length > 240 Then
                            strBildFixed = strBildFixed.Substring(0, 240)
                        End If
                        client.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildFixed)
                        strLokalFile = Application.StartupPath & "\bilderexport\" & strBildFixed
                    Catch ex As Exception
                        strLokalFile = "error"
                        strImportError &= lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text & vbCrLf
                    End Try


                Else
                    strLokalFile = ""
                End If

                'HttpUploadFile("http://shopste.com/api.php", "C:\Users\jbludau\Desktop\gelb_katze.jpg", "system_upload", "image/jpeg", nvc)
                'MessageBox.Show(ListView1.Items(icount).SubItems(3).Text)
                'lvwWebArtikel.Items(iCount).Selected = True
                frmMain.master_Message_label.Text = iCount & " | " & lvwWebArtikel.SelectedItems.Count - 1 & " - Lade Bild hoch..."

                If strLokalFile = "" Then
                    strLokalFile = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text
                End If

                '# Kein Fehler beim Verarbeiten
                If Not strLokalFile = "error" Then
                    HttpUploadFile(My.Settings.SHOPSTE_API_URL, strLokalFile, "system_upload", "image/jpeg", nvc)
                End If

                My.Settings.Save()


            Else
                If MessageBox.Show("Artikel '" & lvwWebArtikel.SelectedItems(0).SubItems(0).Text & "' nicht korrekt eingestellt." + vbCrLf + "Wird Artikel wird fehlen, führe fort...?", "API Import", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.No Then
                    Exit For
                End If
            End If
            lvwWebArtikel.EnsureVisible(iCount)
            Application.DoEvents()


        Next

        frmMain.master_Message_label.Text = "Alle Aufgaben abgeschlossen"

        If (strImportError.Length > 0) Then
            MessageBox.Show("Es sind Fehler aufgetreten bei:" & vbCrLf & vbCrLf & strImportError)
        Else
            MessageBox.Show("Alle Produkte wurden importiert", "Import fertig", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CockitSetztenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CockitSetztenToolStripMenuItem.Click
        Try
            If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

                '  If MsgBox("Möchten Sie den Artikel '" & lvweBayHistory.SelectedItems(0).SubItems(1).Text & "' wirklich zurück in die EiSo Cockpit Ansicht aufnehmen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sync - History => Cockpit") = MsgBoxResult.Yes Then

                Dim iCount As Integer
                For iCount = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1

                    '#########################################
                    '# Holt Makierten Artikel zurück 
                    '#########################################
                    If clsDatenbank_modul.setSYNC_History_live(lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(0).Text) = True Then
                        'lvwArtikelListe.SelectedItems(0).Remove()
                        lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(7).Text = lvwBestellverwaltung_nach_artikel.SelectedItems(0).SubItems(7).Text.Replace("history", "live")

                        Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)
                        Call frmMain.frmManage.getRadioOptions_counts("lvweBayLiveList")

                    End If

                    lvwBestellverwaltung_nach_artikel.SelectedItems(0).Remove()

                Next

                '  End If ' Frage 



            End If ' Prüfung mehr als 0 

        Catch ex As Exception
            debug_message(ex)
        End Try
    End Sub

    Private Sub ShopsteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopsteToolStripMenuItem.Click

    End Sub

    Private Sub ArtikelLöschenToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ArtikelLöschenToolStripMenuItem4.Click
        Dim i As Integer = 0
        Dim str(lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1) As String
        Dim strMessage As String = ""
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then

            ' Mehrfachlöschen ermöglichen
            For i = 0 To lvwBestellverwaltung_nach_artikel.SelectedItems.Count - 1

                If My.Settings.shopste_lagerbestand_verwalten = True And Not lvwBestellverwaltung_nach_artikel.SelectedItems(i).SubItems(13).Text = "Shopste" Then
                    getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=set_shopste_item_ordered&domain_id=" & My.Settings.domain_id & "&item_id=" & lvwBestellverwaltung_nach_artikel.SelectedItems(i).SubItems(15).Text & "&SetMenge=0" & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort, mgetUpdaterMessage.setShopsteItemAmount, True)
                End If

                str(i) = strHTTPDataStore
            Next i

        End If

        For i = 0 To str.Length - 1

            If Not strHTTPDataStore = "OK" Then
                strMessage = "NICHT GEFUNDEN: " + lvwBestellverwaltung_nach_artikel.SelectedItems(i).SubItems(15).Text & vbCrLf
            Else
                strMessage = "GEFUNDEN: " + lvwBestellverwaltung_nach_artikel.SelectedItems(i).SubItems(15).Text & vbCrLf
            End If

        Next

        MessageBox.Show(strMessage, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub ArtikelÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtikelÖffnenToolStripMenuItem.Click
        '#http://shopste.com/api.php?modus=shopste_pathid2url&domain_id=6&page_id=120
        getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=shopste_pathid2url&domain_id=" & My.Settings.domain_id & "&page_id=" & lvwShopste.SelectedItems(0).SubItems(4).Text, mgetUpdaterMessage.getShopstePageURL, True)
        Process.Start(strHTTPDataStore)
    End Sub

    Private Sub ArtikelLöschenToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ArtikelLöschenToolStripMenuItem5.Click
        If (MessageBox.Show("Möchten Sie Artikel '" & lvwShopste.SelectedItems(0).SubItems(1).Text & " ' wirklich löschen?", "Shopste Artikel löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            '# Löschen abschicken
            getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=shopste_shop_item_delete&domain_id=" & My.Settings.domain_id & "&shop_item_id=" & lvwShopste.SelectedItems(0).SubItems(5).Text & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort, mgetUpdaterMessage.getShopstePageURL, True)
            MessageBox.Show(strHTTPDataStore, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub VerkaufsbereitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerkaufsbereitToolStripMenuItem.Click
        getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=set_shopste_item_activator&domain_id=" & My.Settings.domain_id & "&shop_item_id=" & lvwShopste.SelectedItems(0).SubItems(5).Text & "&enabled=N" & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort, mgetUpdaterMessage.getShopstePageURL, True)

        MessageBox.Show(strHTTPDataStore, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AusverkauftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusverkauftToolStripMenuItem.Click
        getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=set_shopste_item_activator&domain_id=" & My.Settings.domain_id & "&shop_item_id=" & lvwShopste.SelectedItems(0).SubItems(5).Text & "&enabled=Y" & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort, mgetUpdaterMessage.getShopstePageURL, True)

        MessageBox.Show(strHTTPDataStore, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MengeÄndernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MengeÄndernToolStripMenuItem.Click
        Dim strInput As String = InputBox("Bitte neue Gesamtmenge eingeben:", "Menge ändern")

        If IsNumeric(strInput) = True Then
            getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=set_shopste_item_ordered_byID&domain_id=" & My.Settings.domain_id & "&shop_item_id=" & lvwShopste.SelectedItems(0).SubItems(5).Text & "&SetMenge=" & strInput & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort, mgetUpdaterMessage.getShopstePageURL, True)

            MessageBox.Show(strHTTPDataStore, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub lvwShopste_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwShopste.ColumnClick
        Call setSort(lvwShopste, e)
    End Sub

    Private Sub ArtikelShopsteKategorieZuweisenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtikelShopsteKategorieZuweisenToolStripMenuItem.Click
        Dim frmShopsteKat As New frmShopsteKategorieMapping
        frmShopsteKat.iEiSoShopId = lvwWebArtikel.SelectedItems(0).SubItems(0).Text
        frmShopsteKat.lvwItems = lvwWebArtikel
        frmShopsteKat.Show()
    End Sub

    Private Sub SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem.Click
        Dim strLokalFile As String
        Dim strLast As String
        Dim strImportError As String = ""
        Dim iCount As Integer = 0
        Dim strBeschreibung As String = ""

        If lvwMenue.SelectedItems(0).Text.Length = 0 Then
            MessageBox.Show("Bitte EiSo Shop Menü auswählen")
        End If

        If lvwWebArtikel.SelectedItems.Count = 0 Then
            MessageBox.Show("Bitte Artikel auswählen um diese nach Shopste.com zu übertragen STRG + Artikelklick oder STRG + A", "Artikelauswahl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If




        For iCount = 0 To lvwWebArtikel.SelectedItems.Count - 1

            If Not lvwWebArtikel.SelectedItems(iCount).SubItems(12).Text = "" Then

                getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=get_shopste_kategorie_by_eisocatid&eiso_cat_id=" & lvwWebArtikel.SelectedItems(iCount).SubItems(11).Text & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort, mgetUpdaterMessage.getEiSo2ShopsteKat, False)

                If Not IsNumeric(strHTTPDataStore) = True Then
                    MessageBox.Show("Es wurde keine gültige Shopste.com Kategorie gefunden.", "ungültige Kategorie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Continue For
                End If

                lvwWebArtikel.Items(iCount).Selected = True
                Application.DoEvents()

                Dim Request As HttpWebRequest = CType(WebRequest.Create(My.Settings.SHOPSTE_API_URL), HttpWebRequest)
                Request.Method = "POST"
                Request.ContentType = "application/x-www-form-urlencoded"
                frmMain.master_Message_label.Text = iCount & " | " & lvwWebArtikel.SelectedItems.Count - 1 & " - Bereite einfügen vor..."
                Application.DoEvents()
                'MessageBox.Show(System.Net.WebUtility.HtmlEncode(ListView1.SelectedItems(0).SubItems(0).Text))
                'System.Net.WebUtility.HtmlEncode
                ' Dim strBeschreibung As String
                ' If chkImportKeineHTMLBeschreibung.Checked = False Then
                strBeschreibung = HttpUtility.UrlEncode(HttpUtility.HtmlEncode(lvwWebArtikel.SelectedItems(iCount).SubItems(1).Text))
                ' Else
                ' strBeschreibung = HttpUtility.UrlEncode(lvwWebArtikel.SelectedItems(0).SubItems(0).Text)
                ' End If

                '# Letztes zu importierendes Produkt?
                If iCount = lvwWebArtikel.SelectedItems.Count - 1 Then
                    strLast = "true"
                Else
                    strLast = "false"
                End If


                Dim Post As String = "modus=system_shop_item_add_shopste_only&domain_id=" & My.Settings.domain_id & "&shop_item_beschreibung=" & strBeschreibung & "&shop_item_menge=" & lvwWebArtikel.SelectedItems(iCount).SubItems(9).Text & "&shop_item_price=" & lvwWebArtikel.SelectedItems(iCount).SubItems(2).Text.Replace(",", ".") & "&shop_item_name=" & HttpUtility.UrlEncode(lvwWebArtikel.SelectedItems(iCount).SubItems(1).Text) & "&shop_item_duration=15&shop_item_mwst=19&shop_item_artikelnummer=" & lvwWebArtikel.SelectedItems(iCount).SubItems(0).Text & "&bLastItem=" & strLast & "&user=" & My.Settings.benutzername & "&subshop_cat=" & strHTTPDataStore & "&shopste_cat=" & lvwWebArtikel.SelectedItems(iCount).SubItems(12).Text & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort

                ' Clipboard.SetText(WebUtility.HtmlEncode(ListView1.SelectedItems(0).SubItems(5).Text))

                'Dim postQuery As Byte() = System.Text.Encoding.ASCII.GetBytes("Post 

                Dim byteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(Post)
                Request.ContentLength = byteArray.Length
                Dim DataStream As System.IO.Stream = Request.GetRequestStream()
                DataStream.Write(byteArray, 0, byteArray.Length)
                DataStream.Close()
                Dim Response As HttpWebResponse = Request.GetResponse()
                DataStream = Response.GetResponseStream()
                Dim reader As New System.IO.StreamReader(DataStream)
                Dim ServerResponse As String = reader.ReadToEnd()
                reader.Close()
                DataStream.Close()
                Response.Close()

                If InStr(ServerResponse, "shopid") Then
                    Dim str() As String = ServerResponse.Split(":")
                    Dim shopid_picture As String = str(1)

                    frmMain.master_Message_label.Text = iCount & " | " & lvwWebArtikel.SelectedItems.Count - 1 & " - Shop ID:" & shopid_picture

                    Dim strFileName() As String = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text.Split("/")

                    Dim nvc As New Specialized.NameValueCollection
                    nvc.Add("modus", "system_upload_file")
                    nvc.Add("domain_id", My.Settings.domain_id)
                    nvc.Add("benutzername", My.Settings.benutzername)
                    nvc.Add("domain_pfad", My.Settings.domain_name)
                    nvc.Add("shop_id", shopid_picture)
                    ' nvc.Add("picture_name", lvwWebArtikel.Items(iCount).SubItems(3).Text.Replace(" ", "_").Replace(">", "-").Replace("/", "").Replace("\", "").Replace("!", ""))
                    Dim strBildName As String = lvwWebArtikel.SelectedItems(iCount).SubItems(1).Text.Replace(" ", "_").Replace(">", "-").Replace("/", "").Replace("\", "").Replace("!", "").Replace("*", "").Replace("<", "-") & ".jpg"
                    nvc.Add("picture_name", strBildName)

                    '# Externe Bilder - HTTP Link
                    If Not lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text.LastIndexOf("http://") = -1 Then

                        Dim client As New WebClient()

                        Dim strBild As String
                        Dim strBild_ary() As String
                        Dim strBildFixed As String = strFileName(strFileName.Length - 1).Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "").Replace("<", "").Replace(">", "").Replace("|", "")
                        'MessageBox.Show(Application.StartupPath)
                        ' Dim strPath As String = IO.Path.GetDirectoryName(Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
                        ' MessageBox.Show(Application.StartupPath)
                        If My.Settings.domain_id = 43 Then
                            strBild_ary = strBildName.Split("/")
                            If strBild_ary.Length = 1 Then
                                strBild = "https://philafriend.de/eBay/TN_" & strBildFixed
                            Else
                                strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))
                                strBild = "https://philafriend.de/eBay/TN_" & strBild_ary(strBild_ary.Length - 1)
                                strBild = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text.Replace("http://", "https://")
                                strBild_ary = strBild.Split("/")
                                strBild = strBild.Replace(strBild_ary(strBild_ary.Length - 1), "TN_" + strBild_ary(strBild_ary.Length - 1))

                            End If

                        Else
                            strBild = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text
                        End If

                        Try

                            If strBildFixed.Length > 240 Then
                                strBildFixed = strBildFixed.Substring(0, 240)
                            End If
                            client.DownloadFile(strBild, Application.StartupPath & "\bilderexport\" & strBildFixed)
                            strLokalFile = Application.StartupPath & "\bilderexport\" & strBildFixed
                        Catch ex As Exception
                            strLokalFile = "error"
                            strImportError &= lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text & vbCrLf
                        End Try


                    Else
                        strLokalFile = ""
                    End If

                    'HttpUploadFile("http://shopste.com/api.php", "C:\Users\jbludau\Desktop\gelb_katze.jpg", "system_upload", "image/jpeg", nvc)
                    'MessageBox.Show(ListView1.Items(icount).SubItems(3).Text)
                    'lvwWebArtikel.Items(iCount).Selected = True
                    frmMain.master_Message_label.Text = iCount & " | " & lvwWebArtikel.SelectedItems.Count - 1 & " - Lade Bild hoch..."

                    If strLokalFile = "" Then
                        strLokalFile = lvwWebArtikel.SelectedItems(iCount).SubItems(3).Text
                    End If

                    '# Kein Fehler beim Verarbeiten
                    If Not strLokalFile = "error" Then
                        HttpUploadFile(My.Settings.SHOPSTE_API_URL, strLokalFile, "system_upload", "image/jpeg", nvc)
                    End If

                    My.Settings.Save()


                Else
                    If MessageBox.Show("Artikel '" & lvwWebArtikel.SelectedItems(0).SubItems(0).Text & "' nicht korrekt eingestellt." + vbCrLf + "Wird Artikel wird fehlen, führe fort...?", "API Import", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.No Then
                        Exit For
                    End If
                End If
                lvwWebArtikel.EnsureVisible(iCount)
                Application.DoEvents()
            End If



        Next

        frmMain.master_Message_label.Text = "Alle Aufgaben abgeschlossen"

        If (strImportError.Length > 0) Then
            MessageBox.Show("Es sind Fehler aufgetreten bei:" & vbCrLf & vbCrLf & strImportError)
        Else
            MessageBox.Show("Alle Produkte wurden importiert", "Import fertig", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub NeueUnterkategorieShopAnlegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeueUnterkategorieShopAnlegenToolStripMenuItem.Click

        If lbltmp.Text.Length > 0 Then


            Dim strInput As String = InputBox("Bitte Unterkategorie-Namen eingeben", "Sub-Shop Unterkategorie anlegen.")
            If strInput.Length > 0 Then
                'MessageBox.Show(strInput & " " & Label1.Text)


                Dim Request As HttpWebRequest = CType(WebRequest.Create(My.Settings.server_api_url & "api.php"), HttpWebRequest)
                Request.Method = "POST"
                Request.ContentType = "application/x-www-form-urlencoded"
                'msgMessage.Text = icount & " | " & ListView1.Items.Count - 1 & " - Bereite einfügen vor..."


                Application.DoEvents()

                Dim Post As String = "modus=system_category_add&domain_id=" & My.Settings.domain_id & "&shop_cat_title=" & strInput & "&shop_cat_position=0&shop_cat_id=" & lbltmp.Text & "&page_layout=col2-left-layout&subtyp=new" & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort

                ' Clipboard.SetText(WebUtility.HtmlEncode(ListView1.SelectedItems(0).SubItems(5).Text))

                'Dim postQuery As Byte() = System.Text.Encoding.ASCII.GetBytes("Post 

                Dim byteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(Post)
                Request.ContentLength = byteArray.Length
                Dim DataStream As Stream = Request.GetRequestStream()
                DataStream.Write(byteArray, 0, byteArray.Length)
                DataStream.Close()
                Dim Response As HttpWebResponse = Request.GetResponse()
                DataStream = Response.GetResponseStream()
                Dim reader As New StreamReader(DataStream)
                Dim ServerResponse As String = reader.ReadToEnd()
                reader.Close()
                DataStream.Close()
                Response.Close()
                ' msgMessage.Text = ServerResponse
                If InStr(ServerResponse, "shopid") Then

                End If

                Dim dtSubShopCat As DataTable = FillTestTableSubShopCat()
                CreateTree(0, dtSubShopCat)
                TreeView1.ExpandAll()
            End If

        Else
            MessageBox.Show("Sie haben keine Kategorie ausgewählt")
        End If
    End Sub

    Private Sub SelektierteKategorieUmbennenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelektierteKategorieUmbennenToolStripMenuItem.Click
        If lbltmp.Text.Length > 0 Then


            Dim strInput As String = InputBox("Bitte Unterkategorie-Namen eingeben", "Sub-Shop Unterkategorie anlegen.")
            If strInput.Length > 0 Then
                'MessageBox.Show(strInput & " " & Label1.Text)


                Dim Request As HttpWebRequest = CType(WebRequest.Create(My.Settings.server_api_url & "api.php"), HttpWebRequest)
                Request.Method = "POST"
                Request.ContentType = "application/x-www-form-urlencoded"
                'msgMessage.Text = icount & " | " & ListView1.Items.Count - 1 & " - Bereite einfügen vor..."


                Application.DoEvents()

                Dim Post As String = "modus=system_category_add&domain_id=" & My.Settings.domain_id & "&shop_cat_title=" & strInput & "&shop_cat_position=0&shop_cat_id=" & Label1.Text & "&page_layout=col2-left-layout&subtyp=rename" & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort & "&txtUsername=" & My.Settings.benutzername & "&txtPasswort=" & My.Settings.passwort

                ' Clipboard.SetText(WebUtility.HtmlEncode(ListView1.SelectedItems(0).SubItems(5).Text))

                'Dim postQuery As Byte() = System.Text.Encoding.ASCII.GetBytes("Post 

                Dim byteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(Post)
                Request.ContentLength = byteArray.Length
                Dim DataStream As Stream = Request.GetRequestStream()
                DataStream.Write(byteArray, 0, byteArray.Length)
                DataStream.Close()
                Dim Response As HttpWebResponse = Request.GetResponse()
                DataStream = Response.GetResponseStream()
                Dim reader As New StreamReader(DataStream)
                Dim ServerResponse As String = reader.ReadToEnd()
                reader.Close()
                DataStream.Close()
                Response.Close()
                ' msgMessage.Text = ServerResponse
                If InStr(ServerResponse, "shopid") Then

                End If

                Dim dtSubShopCat As DataTable = FillTestTableSubShopCat()
                CreateTree(0, dtSubShopCat)
                TreeView1.ExpandAll()
            End If
        End If
    End Sub

    Private Sub EBayArtikelEinstellenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EBayArtikelEinstellenToolStripMenuItem.Click
        Dim frmeBayItemAdd As New FormAddItem
        frmeBayItemAdd.lvwWebArtikel = lvwWebArtikel
        frmeBayItemAdd.ShowDialog(Me)
    End Sub

    Private Sub frmAuktionmanagement_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        '# Privoxy und Tor beenden...
        If My.Settings.translate_tor_privoxy = True Then
            Dim tor_pid As Integer = getProzessIDbySearch("tor")
            If Not tor_pid = -1 Then
                setKillbyPID(tor_pid)
            End If

            Dim privoxy_pid As Integer = getProzessIDbySearch("privoxy")
            If Not privoxy_pid = -1 Then
                setKillbyPID(privoxy_pid)
            End If

        End If
    End Sub
    Public Shared Function customCertValidation(ByVal sender As Object,
                                            ByVal cert As X509Certificate,
                                            ByVal chain As X509Chain,
                                            ByVal errors As SslPolicyErrors) As Boolean
        Return True
    End Function

    Private Sub lvwWebArtikel_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub tcBestellungen_visual_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcBestellungen_visual.SelectedIndexChanged

        Select Case tcBestellungen_visual.SelectedIndex
            Case 0
                If lvwBestellverwaltung_nach_artikel.Items.Count = 0 Then
                    btnBestellungen_abrufen.PerformClick()
                End If
            Case 1
                If lvwBestellungen_kunden.Items.Count = 0 Then
                    btnBestellungen_abrufen.PerformClick()
                End If
        End Select

        My.Settings.eiso_gui_bestellung_subtab_index = tcBestellungen_visual.SelectedIndex
        My.Settings.Save()

    End Sub

    Private Sub lvwBestellungen_kunden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwBestellungen_kunden.SelectedIndexChanged
        Try
            If lvwBestellungen_kunden.SelectedItems.Count > 0 Then
                If IsNumeric(lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text) = True Then
                    setLVWUpdate = False
                    Call getLvwData(lvwBestellungen_bestelliste_neu)
                    setLVWUpdate = True
                End If

            End If

        Catch ex As Exception
            debug_message(ex)

        End Try
    End Sub

    Private Sub lvwBestellungen_bestelliste_neu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwBestellungen_bestelliste_neu.SelectedIndexChanged

    End Sub

    Private Sub ToolStripMenuItem43_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem43.Click

        If lvwBestellungen_bestelliste_neu.Items.Count > 0 Then
            setLVWSelectAll(lvwBestellungen_bestelliste_neu)
            Dim frmYABE_Rechnungsdruck As New frmYABE_Rechnungsdruck
            frmYABE_Rechnungsdruck.lvwDataInput = lvwBestellungen_bestelliste_neu
            frmYABE_Rechnungsdruck.Show(Me)

        End If
    End Sub
    Public Function setLVWSelectAll(lvw As ListView) As Boolean
        Try
            Dim i As Integer = 0
            For i = 0 To lvw.Items.Count - 1
                lvw.Items(i).Selected = True
            Next
            Application.DoEvents()
        Catch ex As Exception
            debug_message(ex, "setLVWSelectAll")
            Return False
        End Try

    End Function

    Private Sub ToolStripMenuItem36_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem36.Click
        'Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.bestellt)
    End Sub

    Private Sub ToolStripMenuItem37_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem37.Click
        'Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.bezahlt)
    End Sub

    Private Sub ToolStripMenuItem38_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem38.Click
        'Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.verschickt)
    End Sub

    Private Sub ToolStripMenuItem39_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem39.Click
        'Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.komplett)
    End Sub

    Private Sub ToolStripMenuItem40_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem40.Click
        'Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.storniert)
        '  Call setLVWEiSoOrder_recalc(lvwBestellungen_bestelliste_neu)
    End Sub

    Private Sub ToolStripMenuItem45_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem45.Click
        Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.bestellt)
    End Sub

    Private Sub ToolStripMenuItem46_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem46.Click
        Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.bezahlt)
    End Sub

    Private Sub ToolStripMenuItem47_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem47.Click
        Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.verschickt)
    End Sub

    Private Sub ToolStripMenuItem48_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem48.Click
        Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.komplett)
    End Sub

    '########################################
    '# EiSo Order Gesammt neu berechnen 
    '########################################
    Public Function setLVWEiSoOrder_recalc(lvw As ListView) As Boolean
        Try
            Dim i As Integer = 0
            Dim dblEndsumme As Double = 0
            Dim dblEndsumme_rabatt As Double = 0
            Dim dblEndsumme_rabatt_eur As Double = 0

            Select Case lvw.Name
                Case "lvwBestellungen_bestelliste_neu"

                    'Str(0) = dbReader("shippment_amount").ToString
                    'Str(1) = dbReader("order_total").ToString
                    'Str(2) = dbReader("paypal_total_sum").ToString
                    'Str(3) = dbReader("total_sum_amount").ToString
                    'Str(4) = dbReader("total_rabatt").ToString
                    'Str(5) = dbReader("total_rabatt_prozent").ToString
                    ' 6 = Kommentar
                    ' 7 = Versandart
                    Dim strOrderData() As String = clsDatenbank_modul.getOrderListDetails(lvw.SelectedItems(0).SubItems(24).Text)
                    For i = 0 To lvw.Items.Count - 1

                        If Not lvw.Items(i).SubItems(7).Text = "Storniert" Then
                            If IsNumeric(lvw.Items(i).SubItems(6).Text) = True Then
                                dblEndsumme += Convert.ToDouble(lvw.Items(i).SubItems(6).Text)
                            End If

                        End If

                    Next
                    If strOrderData(5) > 0 Then
                        dblEndsumme_rabatt_eur = (dblEndsumme / 100) * strOrderData(5)
                        dblEndsumme_rabatt = dblEndsumme_rabatt - dblEndsumme_rabatt_eur
                    End If

                    strOrderData(4) = setCalcPaypal(dblEndsumme, strOrderData(0))
                    If Convert.ToDouble(dblEndsumme_rabatt_eur) > 0 Then
                        strOrderData(4) = setCalcPaypal(dblEndsumme_rabatt, strOrderData(0))
                    End If

                    'clsDatenbank_modul.setEiSoOrderTable(lvwArtikelListe.SelectedItems(0).SubItems(12).Text, txtVersandkosten.Text, txtUmsatz.Text, txtRabattPaypal.Text, txtRabattEndsumme.Text, txtRabatt.Text, txtRabattEUR.Text, oItem.Value)
                    clsDatenbank_modul.setEiSoOrderTable(lvwBestellungen_kunden.SelectedItems(0).SubItems(15).Text, strOrderData(0), dblEndsumme, strOrderData(4), dblEndsumme_rabatt, strOrderData(5), dblEndsumme_rabatt_eur, strOrderData(7))

            End Select





            Return True
        Catch ex As Exception
            debug_message(ex, "setLVWEiSoOrder_recalc")
            Return False
        End Try

    End Function
    Private Sub ToolStripMenuItem49_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem49.Click
        Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Call setStatus_new(lvwBestellungen_bestelliste_neu, clsDatenbank.yabe_bestellstatus.storniert)
        '   Call setLVWEiSoOrder_recalc(lvwBestellungen_bestelliste_neu)
    End Sub

    Private Sub ZeigeAlleKundenbestellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZeigeAlleKundenbestellungenToolStripMenuItem.Click
        If lvwBestellungen_bestelliste_neu.Items.Count > 0 Then
            Call getOrderHistory(lvwBestellungen_bestelliste_neu, lvwBestellungen_bestelliste_neu.Items(0).SubItems(9).Text)
        End If
    End Sub

    Private Sub EiSoExportierenDerAnsichtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EiSoExportierenDerAnsichtToolStripMenuItem.Click
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count >= 2 Then
            Call export(lvwBestellungen_bestelliste_neu, export_targets.standard, selectModus.part)
        Else
            Call export(lvwBestellungen_bestelliste_neu, export_targets.standard, selectModus.ganz)
        End If

    End Sub

    Private Sub ToolStripMenuItem42_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem42.Click

        If lvwBestellungen_bestelliste_neu.Items.Count > 0 Then

            Dim frmYABE_Rechnungsdruck As New frmYABE_Rechnungsdruck
            frmYABE_Rechnungsdruck.lvwDataInput = lvwBestellungen_bestelliste_neu
            frmYABE_Rechnungsdruck.Show(Me)

        End If
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then


            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")

                Dim strBild As String = clsDatenbank_modul.getCMS_ShopItems("Bild", strYABEID(0))

                If setDeletePictures(strBild, True) = True Then
                    If clsDatenbank_modul.getCMS_items_delete("DELETE FROM tblGes WHERE ID=" & strYABEID(0)) = True Then
                        frmMain.master_Message_label.Text = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(14).Text & " / " & lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text
                    Else
                        MsgBox("Probleme beim Löschen des Artikels mit ID: '" & lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text & "'  auf dem Server", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Probleme beim Löschen des Bildes Artikels mit ID: '" & lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text & "' auf dem Server", MsgBoxStyle.Exclamation)
                End If

            Next

            MsgBox("Artikel gelöscht", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(2, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'Warteliste' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(1, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'bestellt' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(0, strYABEID(0))
            Next

        End If
        MsgBox("Artikel auf 'aktiv' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then
            Dim frmPicture As New frmShowPicture
            frmPicture.strYABE_ID = lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(15).Text
            frmPicture.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem33_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem33.Click
        Try
            If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then

                '  If MsgBox("Möchten Sie den Artikel '" & lvweBayHistory.SelectedItems(0).SubItems(1).Text & "' wirklich zurück in die EiSo Cockpit Ansicht aufnehmen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sync - History => Cockpit") = MsgBoxResult.Yes Then

                Dim iCount As Integer
                For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1

                    '#########################################
                    '# Holt Makierten Artikel zurück 
                    '#########################################
                    If clsDatenbank_modul.setSYNC_History_live(lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(0).Text) = True Then
                        'lvwArtikelListe.SelectedItems(0).Remove()
                        lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(7).Text = lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(7).Text.Replace("history", "live")

                        Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)
                        Call frmMain.frmManage.getRadioOptions_counts("lvweBayLiveList")

                    End If

                    lvwBestellungen_bestelliste_neu.SelectedItems(0).Remove()

                Next

                '  End If ' Frage 



            End If ' Prüfung mehr als 0 

        Catch ex As Exception
            debug_message(ex)
        End Try
    End Sub

    Private Sub AnsichtAktuallisierenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AnsichtAktuallisierenToolStripMenuItem3.Click
        If bIsLoading = False Then
            bIsLoading = True
            Call getLvwData(lvwBestellungen_kunden)
            bIsLoading = False
        End If
    End Sub

    Private Sub eBayHistoryVon_ValueChanged(sender As Object, e As EventArgs) Handles eBayHistoryVon.ValueChanged

    End Sub

    Private Sub eBayHistoryBis_ValueChanged(sender As Object, e As EventArgs) Handles eBayHistoryBis.ValueChanged

    End Sub

    Private Sub lvweBayHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwBestellverwaltung_nach_artikel.SelectedIndexChanged

    End Sub

    Private Sub lvwBestellungen_kunden_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwBestellungen_kunden.MouseDoubleClick
        '# 
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then

            Dim frmWeb As New frmYABE_WebBrowser
            frmWeb.lvwDataView = lvwBestellungen_bestelliste_neu

            Select Case lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(13).Text
                Case "eBay"
                    frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.ebay_versandkosten
                Case "delcampe"
                    Select Case lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(7).Text
                        Case "bezahlt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_artikelview
                        Case "verschickt"
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_bewerten
                        Case Else
                            frmWeb.mWebLinkCollectionStatus = frmYABE_WebBrowser.mWebLinksCol.delcampe_versand
                    End Select

            End Select

            frmWeb.Show(Me)

        End If
    End Sub

    Private Sub ToolStripMenuItem52_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem52.Click

        Call setLVW_select_all(lvwBestellungen_bestelliste_neu)

        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then


            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")

                Dim strBild As String = clsDatenbank_modul.getCMS_ShopItems("Bild", strYABEID(0))

                If setDeletePictures(strBild, True) = True Then
                    If clsDatenbank_modul.getCMS_items_delete("DELETE FROM tblGes WHERE ID=" & strYABEID(0)) = True Then
                        frmMain.master_Message_label.Text = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(14).Text & " / " & lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text
                    Else
                        MsgBox("Probleme beim Löschen des Artikels mit ID: '" & lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text & "'  auf dem Server", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Probleme beim Löschen des Bildes Artikels mit ID: '" & lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text & "' auf dem Server", MsgBoxStyle.Exclamation)
                End If

            Next

            MsgBox("Artikel gelöscht", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem53_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem53.Click
        Call setLVW_select_all(lvwBestellungen_bestelliste_neu)
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(2, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'Warteliste' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub ToolStripMenuItem54_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem54.Click
        Call setLVW_select_all(lvwBestellungen_bestelliste_neu)
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(1, strYABEID(0))
            Next
        End If
        MsgBox("Artikel auf 'bestellt' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub ToolStripMenuItem55_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem55.Click
        Call setLVW_select_all(lvwBestellungen_bestelliste_neu)
        If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then
            Dim iCount As Integer = 0

            For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1
                Dim strYABEID() As String = lvwBestellungen_bestelliste_neu.SelectedItems(iCount).SubItems(15).Text.Split("-")
                Call clsDatenbank_modul.setWebartikelStatus(0, strYABEID(0))
            Next

        End If
        MsgBox("Artikel auf 'aktiv' gesetzt", MsgBoxStyle.Information)
    End Sub

    Private Sub KundeEditierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KundeEditierenToolStripMenuItem.Click
        If lvwBestellungen_kunden.SelectedItems.Count > 0 Then

            Dim frmKundenEdit As New frmYABE_Kundenverwaltung
            frmKundenEdit.lvwDataInput = lvwBestellungen_kunden
            frmKundenEdit.strLoadEmail = lvwBestellungen_kunden.SelectedItems(0).SubItems(2).Text
            frmKundenEdit.Show()
        End If
    End Sub

    Private Sub lvwBestellungen_kunden_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwBestellungen_kunden.ColumnClick
        Call setSort(lvwBestellungen_kunden, e)
    End Sub

    Private Sub lvwBestellungen_bestelliste_neu_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwBestellungen_bestelliste_neu.ColumnClick
        Call setSort(lvwBestellungen_bestelliste_neu, e)
    End Sub

    Private Sub lvwBestellungen_kunden_ColumnReordered(sender As Object, e As ColumnReorderedEventArgs) Handles lvwBestellungen_kunden.ColumnReordered
        Call getLVW_Colum_ReOrder(lvwBestellungen_kunden)
    End Sub

    Private Sub BestellungErneutAbschickenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestellungErneutAbschickenToolStripMenuItem.Click
        Call setLVWSelectAll(lvwBestellungen_bestelliste_neu)
        Try
            If lvwBestellungen_bestelliste_neu.SelectedItems.Count > 0 Then

                '  If MsgBox("Möchten Sie den Artikel '" & lvweBayHistory.SelectedItems(0).SubItems(1).Text & "' wirklich zurück in die EiSo Cockpit Ansicht aufnehmen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sync - History => Cockpit") = MsgBoxResult.Yes Then

                Dim iCount As Integer
                For iCount = 0 To lvwBestellungen_bestelliste_neu.SelectedItems.Count - 1

                    '#########################################
                    '# Holt Makierten Artikel zurück 
                    '#########################################
                    If clsDatenbank_modul.setSYNC_History_live(lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(0).Text) = True Then
                        'lvwArtikelListe.SelectedItems(0).Remove()
                        lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(7).Text = lvwBestellungen_bestelliste_neu.SelectedItems(0).SubItems(7).Text.Replace("history", "live")

                        Call frmMain.frmManage.getLvwData(frmMain.frmManage.lvwEiSoCockpit)
                        Call frmMain.frmManage.getRadioOptions_counts("lvweBayLiveList")

                    End If

                    lvwBestellungen_bestelliste_neu.SelectedItems(0).Remove()

                Next

                '  End If ' Frage 



            End If ' Prüfung mehr als 0 

        Catch ex As Exception
            debug_message(ex)
        End Try
    End Sub

    Private Sub chkArtikeldatenbankBilderladen_CheckedChanged(sender As Object, e As EventArgs) Handles chkArtikeldatenbankBilderladen.CheckedChanged
        My.Settings.gui_eiso_lade_bilder = chkArtikeldatenbankBilderladen.Checked
        My.Settings.lvw_eiso_shop_picture = chkArtikeldatenbankBilderladen.Checked
        My.Settings.Save()
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub chkKundenverwaltung_kunde_ab_gestern_CheckedChanged(sender As Object, e As EventArgs) Handles chkKundenverwaltung_kunde_ab_gestern.CheckedChanged

        If bIsLoading = False Then
            If chkKundenverwaltung_kunde_ab_gestern.Checked = True Then
                KundenVon.Value = Date.Now.AddDays(-1)
                bIsLoading = True
                Call getLvwData(lvwKunden)

                bIsLoading = False

                My.Settings.gui_kunden_gestern_ab = chkKundenverwaltung_kunde_ab_gestern.Checked
                My.Settings.Save()
            Else
                KundenVon.Value = Date.Now.AddDays(-My.Settings.gui_dauer_kunden)
                KundenBis.Value = Date.Now.AddDays(1)
                My.Settings.gui_kunden_gestern_ab = chkKundenverwaltung_kunde_ab_gestern.Checked
                My.Settings.Save()
                Call getLvwData(lvwKunden)
            End If
        Else
            If chkKundenverwaltung_kunde_ab_gestern.Checked = True Then
                KundenVon.Value = Date.Now
                My.Settings.gui_kunden_gestern_ab = chkKundenverwaltung_kunde_ab_gestern.Checked
                My.Settings.Save()
            Else
                KundenVon.Value = Date.Now.AddDays(-My.Settings.gui_dauer_kunden)
                KundenBis.Value = Date.Now.AddDays(1)
                My.Settings.gui_kunden_gestern_ab = chkKundenverwaltung_kunde_ab_gestern.Checked
                My.Settings.Save()
            End If
            My.Settings.gui_kunden_gestern_ab = chkKundenverwaltung_kunde_ab_gestern.Checked
            My.Settings.Save()
        End If

    End Sub

    Private Sub AusListeEntfernenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusListeEntfernenToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To lvwKunden.SelectedItems.Count - 1
                lvwKunden.SelectedItems(i).Remove()
            Next

        End If
    End Sub

    Private Sub KopiereAlsAdressblockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopiereAlsAdressblockToolStripMenuItem.Click
        If lvwKunden.SelectedItems.Count > 0 Then
            Dim strClipboard As String
            strClipboard = lvwKunden.SelectedItems(0).SubItems(0).Text & vbCrLf & lvwKunden.SelectedItems(0).SubItems(5).Text & " " & lvwKunden.SelectedItems(0).SubItems(4).Text & vbCrLf & lvwKunden.SelectedItems(0).SubItems(6).Text

            Clipboard.SetText(strClipboard)
        End If

    End Sub

    Private Sub btnAuftrag_Versandkosten_Click(sender As Object, e As EventArgs) Handles btnAuftrag_Versandkosten.Click

        If lvwEiSoCockpit.Items.Count > 0 Then
            lvwEiSoCockpit.Items(0).Selected = True

            Dim frmVersandkosten As New frmBestellung_Versandkosten
            frmVersandkosten.mModusSelect = frmBestellung_Versandkosten.mModus.live
            frmVersandkosten.lvwDataInput = lvwEiSoCockpit
            frmVersandkosten.ShowDialog(Me)
        End If

    End Sub

    Private Sub btnBestellverwaltung_rechnung_erstellen_Click(sender As Object, e As EventArgs) Handles btnBestellverwaltung_rechnung_erstellen.Click

        btnBestellverwaltung_rechnung_erstellen.Enabled = False
        If lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Or lvwBestellungen_bestelliste_neu.Items.Count > 0 Then

            Dim frmYABE_Rechnungsdruck As New frmYABE_Rechnungsdruck
            If tcBestellungen_visual.SelectedIndex = 1 Then
                Dim i As Integer = 0
                For i = 0 To lvwBestellungen_bestelliste_neu.Items.Count - 1
                    lvwBestellungen_bestelliste_neu.Items(i).Selected = True
                Next

                frmYABE_Rechnungsdruck.lvwDataInput = lvwBestellungen_bestelliste_neu
            Else
                frmYABE_Rechnungsdruck.lvwDataInput = lvwBestellverwaltung_nach_artikel
            End If

            frmYABE_Rechnungsdruck.Show(Me)

        End If
        btnBestellverwaltung_rechnung_erstellen.Enabled = True

    End Sub

    Private Sub lvwBestellverwaltung_nach_artikel_MouseHover(sender As Object, e As EventArgs) Handles lvwBestellverwaltung_nach_artikel.MouseHover


    End Sub

    Private Sub lvwBestellverwaltung_nach_artikel_ItemMouseHover(sender As Object, e As ListViewItemMouseHoverEventArgs) Handles lvwBestellverwaltung_nach_artikel.ItemMouseHover

        If e.Item.SubItems(22).Text.Length > 0 And My.Settings.chkBildvorschau_bestellung = True Then
            If IO.File.Exists(Application.StartupPath & "\bilderexport\" & e.Item.SubItems(22).Text) = True Then
                Dim frmPic As New frmBildvorschau
                frmPic.strPfad = Application.StartupPath & "\bilderexport\" & e.Item.SubItems(22).Text
                frmPic.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub lvwBestellungen_bestelliste_neu_ItemMouseHover(sender As Object, e As ListViewItemMouseHoverEventArgs) Handles lvwBestellungen_bestelliste_neu.ItemMouseHover

        If e.Item.SubItems(22).Text.Length > 0 And My.Settings.chkBildvorschau_bestellung = True Then
            If IO.File.Exists(Application.StartupPath & "\bilderexport\" & e.Item.SubItems(22).Text) = True Then
                Dim frmPic As New frmBildvorschau
                frmPic.strPfad = Application.StartupPath & "\bilderexport\" & e.Item.SubItems(22).Text
                frmPic.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub lvwWebArtikel_ItemMouseHover(sender As Object, e As ListViewItemMouseHoverEventArgs) Handles lvwWebArtikel.ItemMouseHover
        If e.Item.SubItems(10).Text.Length > 0 And My.Settings.chkBildvorschau_eiso_artikeldatenbank = True And chkArtikeldatenbankBilderladen.Checked = True Then
            If IO.File.Exists(Application.StartupPath & "\bilderexport\" & e.Item.SubItems(10).Text) = True Then
                Dim frmPic As New frmBildvorschau
                frmPic.strPfad = Application.StartupPath & "\bilderexport\" & e.Item.SubItems(10).Text
                frmPic.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub lvwEiSoCockpit_ItemMouseHover(sender As Object, e As ListViewItemMouseHoverEventArgs) Handles lvwEiSoCockpit.ItemMouseHover
        If e.Item.SubItems(13).Text.Length > 0 And My.Settings.chkBildvorschau = True Then
            If IO.File.Exists(Application.StartupPath & "\bilderexport\" & e.Item.SubItems(13).Text) = True Then
                Dim frmPic As New frmBildvorschau
                frmPic.strPfad = Application.StartupPath & "\bilderexport\" & e.Item.SubItems(13).Text
                frmPic.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnEiSoShop_artikel_neu_Click(sender As Object, e As EventArgs) Handles btnEiSoShop_artikel_neu.Click
        Dim frmNewEiSoShop_artikel As New frmCMS_change_item
        frmNewEiSoShop_artikel.bIsNew = True
        frmNewEiSoShop_artikel.ShowDialog(Me)
    End Sub

    Private Sub chkEiSoArtikelverwaltung_kunden_details_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoArtikelverwaltung_kunden_details.CheckedChanged
        My.Settings.chkEiSoArtikelverwaltung_kunden_details = chkEiSoArtikelverwaltung_kunden_details.Checked
        My.Settings.Save()
    End Sub
End Class