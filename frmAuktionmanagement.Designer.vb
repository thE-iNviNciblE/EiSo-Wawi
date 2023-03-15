<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAuktionmanagement
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuktionmanagement))
        Me.tabMenue = New System.Windows.Forms.TabControl()
        Me.menue_eBay_Live = New System.Windows.Forms.TabPage()
        Me.btnAuftrag_Versandkosten = New System.Windows.Forms.Button()
        Me.chkMitWebgalerie = New System.Windows.Forms.CheckBox()
        Me.btnQuickSync = New System.Windows.Forms.Button()
        Me.btnAuktionEinlesen = New System.Windows.Forms.Button()
        Me.chkGeboteOhne = New System.Windows.Forms.RadioButton()
        Me.chkeBayEnde = New System.Windows.Forms.CheckBox()
        Me.chkBuyItNow = New System.Windows.Forms.RadioButton()
        Me.chkGebote = New System.Windows.Forms.RadioButton()
        Me.chkLiveAlle = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbPlattform_Live = New System.Windows.Forms.ComboBox()
        Me.yabe_dashboard_header = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkEndTime = New System.Windows.Forms.CheckBox()
        Me.chkDebug_email = New System.Windows.Forms.CheckBox()
        Me.lblSeite = New System.Windows.Forms.Label()
        Me.lblVon = New System.Windows.Forms.Label()
        Me.lblBis = New System.Windows.Forms.Label()
        Me.dtpCockpit_bis = New System.Windows.Forms.DateTimePicker()
        Me.dtpCockpit_von = New System.Windows.Forms.DateTimePicker()
        Me.chkLiveZeitfilter = New System.Windows.Forms.CheckBox()
        Me.txtGetSellerListSeiteVon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnZurück = New System.Windows.Forms.Button()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.chkAutomatischerModus = New System.Windows.Forms.CheckBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.pgreBayLiveUpdate = New System.Windows.Forms.ProgressBar()
        Me.btnLiveStopp = New System.Windows.Forms.Button()
        Me.btnAuftrag_email_senden = New System.Windows.Forms.Button()
        Me.lvwEiSoCockpit = New System.Windows.Forms.ListView()
        Me.live_ebayID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_beschreibung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_endpreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_startpreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_gebote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_ebaymitglied = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_completed_status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_ListType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_auktionend = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_watchcounter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_auktionbeginn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_versandkosten = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_ebaybild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_lastupdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_hitcounter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_eBayFragen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_auktion_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_paypal_endsumme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_yabe_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_person_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_person_land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_verschickt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_menge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bild_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_stadt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.live_eiso_orderlist_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwLiveAnsicht = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnsichtAktuallisierenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersandkostenberechnungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailVorschauAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.SNYCEBayAPIDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutlookSyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYNCCockpitBestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator52 = New System.Windows.Forms.ToolStripSeparator()
        Me.YABEKundenverlaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator30 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmeBayLive_Detailansicht = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayBeschreibungErweiternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelBeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HöchstbietenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BietverlaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayCrossPromotionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayVerkaufseventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.LiveÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailExternesProgrammToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyEBayIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy_Beschreibung = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.IsSendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelKomplettLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BildLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bilder_history = New System.Windows.Forms.ImageList(Me.components)
        Me.menue_kunden = New System.Windows.Forms.TabPage()
        Me.chkKundenverwaltung_kunde_ab_gestern = New System.Windows.Forms.CheckBox()
        Me.chkShopLastLogin = New System.Windows.Forms.CheckBox()
        Me.chkKundenZeitfilter = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbPlattform_kunden = New System.Windows.Forms.ComboBox()
        Me.chkKundenHeute = New System.Windows.Forms.CheckBox()
        Me.lblKunden_Main_label = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KundenBis = New System.Windows.Forms.DateTimePicker()
        Me.KundenVon = New System.Windows.Forms.DateTimePicker()
        Me.pgrKundenverlauf = New System.Windows.Forms.ProgressBar()
        Me.chkKundenFullReport = New System.Windows.Forms.CheckBox()
        Me.btnAdressLabels = New System.Windows.Forms.Button()
        Me.btnKundenHolen = New System.Windows.Forms.Button()
        Me.imgAuktionsmanagement = New System.Windows.Forms.ImageList(Me.components)
        Me.lvwKunden = New System.Windows.Forms.ListView()
        Me.kd_nachname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_eBayName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_eMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_strasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_PLZ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_Ort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_Land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_käufe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_Artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_newsletter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_last = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_sprachenliste = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_muttersprache = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kd_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.order_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsKundenListview = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.YABEAnsichtAktuallisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopiereAlsAdressblockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator78 = New System.Windows.Forms.ToolStripSeparator()
        Me.BestellübersichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsletterDeaktivierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonensucheToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelefonummernSucheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleMapsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.KundenNeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KundenEditierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator55 = New System.Windows.Forms.ToolStripSeparator()
        Me.KundeLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator46 = New System.Windows.Forms.ToolStripSeparator()
        Me.SucheKundenbestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheKundenBewertungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator51 = New System.Windows.Forms.ToolStripSeparator()
        Me.EBayKundenInformationenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZuordnungArtikelKundeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailExternesProgrammToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.KopierenEmailToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenArtikelIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator77 = New System.Windows.Forms.ToolStripSeparator()
        Me.AusListeEntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menue_bestellverlauf = New System.Windows.Forms.TabPage()
        Me.btnBestellverwaltung_rechnung_erstellen = New System.Windows.Forms.Button()
        Me.tcBestellungen_visual = New System.Windows.Forms.TabControl()
        Me.listenansicht = New System.Windows.Forms.TabPage()
        Me.lvwBestellverwaltung_nach_artikel = New System.Windows.Forms.ListView()
        Me.eBayHistory_live = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_Account = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_ort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_preis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_versandkosten = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_bewertet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_eMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistory_verkaufsende = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistoryGebote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistory_Gebühr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistory_bild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistory_YABEID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistory_Paypal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistoryLand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistoryDelcampeID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistory_muttersprache = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistory_straße = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ebayHistory_sprachliste = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistoryBild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayHistoryMenge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eBayEiSoOrderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsEiSoBestellungen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnsichtAktuallisierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABERechnungsdruckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestellungsstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewertetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BezahltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschicktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.StorniertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ErinnerungSendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABEArtikelübernahmeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CockitSetztenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.YABEBestellverlaufProKundenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KundenverlaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator56 = New System.Windows.Forms.ToolStripSeparator()
        Me.WartelisteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestelltToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktivToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator57 = New System.Windows.Forms.ToolStripSeparator()
        Me.BildAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelBestelltToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelAktivierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelLöschenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopsteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelLöschenToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APILöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator58 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeutschSuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglischSuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator38 = New System.Windows.Forms.ToolStripSeparator()
        Me.YABEArtikelansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSAnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator42 = New System.Windows.Forms.ToolStripSeparator()
        Me.DelcampeArtikelansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelcampeVersandkostenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelcampeBewertungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.EBayArtikelansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayVersandkostenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayBewertungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.PersonensucheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelefonnummernSucheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleMapsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator37 = New System.Windows.Forms.ToolStripSeparator()
        Me.YABEAnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruppiertKeineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator49 = New System.Windows.Forms.ToolStripSeparator()
        Me.GruppiertBestellstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruppiertNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupiertVerkaufsendeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruppiertLandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruppiertMutterspracheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZuordnungArtikelKundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelcampeBestellsStatusAktuallisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivAktuallisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.SucheArtikelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheKundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheBewertungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucheBestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayAuktionArtikeldetialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BietverlaufToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyEBayIDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyEBayMitgliedsnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.EBayÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceOfficeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pgreBayVerlaufUpdate = New System.Windows.Forms.ProgressBar()
        Me.bestelliste = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lvwBestellungen_kunden = New System.Windows.Forms.ListView()
        Me.col_kuden_bestellliste_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_mitgliedsname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_strasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_ort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_plz = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_käufe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_artikelanzahl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_newsletter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_kd_änderung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_sprachliste = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_muttersprache = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_order_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_bestellt_am = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_bestellstatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_endsumme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_versandkosten = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_rabatt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kuden_bestellliste_versandart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kunden_bestellliste_verschickt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kunden_bestellliste_bezahlt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kunden_bestellliste_storniert = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kunden_bestellliste_bewertet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_kunden_bestellliste_abgeschlossen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsBestellungen_kunden = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnsichtAktuallisierenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZeigeAlleKundenbestellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator74 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem43 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem44 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem45 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem46 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem47 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem48 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator70 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem49 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator71 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem51 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator75 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem53 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem54 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem55 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator76 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem52 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator72 = New System.Windows.Forms.ToolStripSeparator()
        Me.BestellungErneutAbschickenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EiSoExportierenDerAnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KundeEditierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvwBestellungen_bestelliste_neu = New System.Windows.Forms.ListView()
        Me.colBestell_kund_artikel_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_user = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_ort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_beschreibung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_preis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_versand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_bestellstatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_bewertung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_verkaufsende = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_gebote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_gebühr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_plattform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_bild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_EID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_paypal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_colname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_email_sprache = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_straße = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_sprachliste = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_bild2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_menge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestell_kund_artikel_orderid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsBestellungen_bestellungen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator68 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem33 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator73 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem42 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem34 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem35 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem37 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem38 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem39 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator66 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator67 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem41 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator69 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator63 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator64 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator65 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem31 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkBestellungen_Alle = New System.Windows.Forms.RadioButton()
        Me.chkBestellungen_Komplett = New System.Windows.Forms.RadioButton()
        Me.chkBestellungenVerkauft = New System.Windows.Forms.CheckBox()
        Me.chkBestellungen_Storniert = New System.Windows.Forms.RadioButton()
        Me.chkBestellungen_KeineBewertung = New System.Windows.Forms.RadioButton()
        Me.chkBestellungen_Versand = New System.Windows.Forms.RadioButton()
        Me.chkBestellungen_bezahlt = New System.Windows.Forms.RadioButton()
        Me.chkBestellungen_verkauft = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbPlattform_bestellungen = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblLive_von = New System.Windows.Forms.Label()
        Me.lblLive_bis = New System.Windows.Forms.Label()
        Me.eBayHistoryBis = New System.Windows.Forms.DateTimePicker()
        Me.eBayHistoryVon = New System.Windows.Forms.DateTimePicker()
        Me.lblBestellungen_main = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkHistoryZeitfilter = New System.Windows.Forms.CheckBox()
        Me.btnBestellungAdd = New System.Windows.Forms.Button()
        Me.btneBayAdressenHolen = New System.Windows.Forms.Button()
        Me.btnBestellungen_abrufen = New System.Windows.Forms.Button()
        Me.menue_shopste = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.cmsShopsteKategorie = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NeueUnterkategorieShopAnlegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelektierteKategorieUmbennenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltmp = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lvwShopste = New System.Windows.Forms.ListView()
        Me.shopste_bild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.shopste_titel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.shopste_preis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.shopste_menge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SeitenID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ShopID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Artikelnummer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Aktiv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsShopsteArtikel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ArtikelÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelLöschenToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusverkauftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerkaufsbereitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MengeÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.menue_artikelverwaltung = New System.Windows.Forms.TabPage()
        Me.tab_verwaltung = New System.Windows.Forms.TabControl()
        Me.eshop_daten = New System.Windows.Forms.TabPage()
        Me.btnEiSoShop_artikel_neu = New System.Windows.Forms.Button()
        Me.chkArtikeldatenbankBilderladen = New System.Windows.Forms.CheckBox()
        Me.chkArtikeldatenbank_edit = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSprache_Artikeldatenbank = New System.Windows.Forms.ComboBox()
        Me.chkShopUpdateItemCount = New System.Windows.Forms.CheckBox()
        Me.optCMSToogleBoth = New System.Windows.Forms.RadioButton()
        Me.optCMSToogleKategorie = New System.Windows.Forms.RadioButton()
        Me.optCMSToogleArtikel = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbArtikelStatus = New System.Windows.Forms.ComboBox()
        Me.cms_splitcontainer = New System.Windows.Forms.SplitContainer()
        Me.lvwMenue = New System.Windows.Forms.ListView()
        Me.cms_kategorieID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_menueName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_clickcount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_kategorie_delcampe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_kategorie_magento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_hauptkategorie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_shopsteCat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_KategorieListe = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.YABEImportVonArtikelnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator40 = New System.Windows.Forms.ToolStripSeparator()
        Me.KategorieHauptkategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategorieNeueSubkategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeueKatGleicheEbeneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.UmbennenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategorieLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshKategorielisteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnzahlUpdatenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpracheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeutschToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglischToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FranzösichToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator48 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutomatischSpracheÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortierungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HochToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagentoKategorieIDZuweisenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopsteKategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportDelcampeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMagentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportStandardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenüÜbersetzungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HatUntekategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeineUnterkategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator59 = New System.Windows.Forms.ToolStripSeparator()
        Me.EiSoShopKategorienZuShopstecomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator62 = New System.Windows.Forms.ToolStripSeparator()
        Me.lvwWebArtikel = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Beschreibung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.magento_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.delcampe_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_datum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsBlidCounter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsAnzahl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eiso_bild_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsEiSoMenuID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsShopsteCat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsShopste_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdShopste_lagerbestand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsShopste_eingestellt_am = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_ArtikelVerwaltung = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NeuerArtikelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberarbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelLöschenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelSuchenUndErsetzenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EBayArtikelEinstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportStandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABEImportVonArtikelnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelAlleImportiertenLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator60 = New System.Windows.Forms.ToolStripSeparator()
        Me.AktuallisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebEBayBildAnsehenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleMarkierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator44 = New System.Windows.Forms.ToolStripSeparator()
        Me.MagentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelLöschenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelBestelltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelAktivToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator45 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktuellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestelltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AussortiertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelcampeListerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpracheZurücksetzenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FehlendeÜbersetzungenHolenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator43 = New System.Windows.Forms.ToolStripSeparator()
        Me.YABEWebtranslatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportDelcampeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EiSo2ShopsteArtikelImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ArtikelShopsteKategorieZuweisenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportierenToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolBilderprüfenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebSucheBeiGoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator61 = New System.Windows.Forms.ToolStripSeparator()
        Me.eshop_bestellungen = New System.Windows.Forms.TabPage()
        Me.btnGetCMSBestellungen = New System.Windows.Forms.Button()
        Me.lvwGetBestellungen = New System.Windows.Forms.ListView()
        Me.bestellungen_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bestellungen_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bestellung_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bestellung_bezahlmethode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bestellungen_endsumme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bestellungen_zeitpunkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bestellungen_woher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eshop_bilderprüfung = New System.Windows.Forms.TabPage()
        Me.btnPrüfeWebArtikel = New System.Windows.Forms.Button()
        Me.btnCheckPictures = New System.Windows.Forms.Button()
        Me.btnTools_eBayGalerie = New System.Windows.Forms.Button()
        Me.lvweBayGalerie = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmseBayGalerie_neu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EBayAnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menue_tbPaypal = New System.Windows.Forms.TabPage()
        Me.tabPaypal = New System.Windows.Forms.TabControl()
        Me.tab_paypal_api = New System.Windows.Forms.TabPage()
        Me.btnPaypalBestellstatus = New System.Windows.Forms.Button()
        Me.btnPaypal_abrufen = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lvwPaypal = New System.Windows.Forms.ListView()
        Me.colPaypalName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPaypalStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPaypaEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPaypalTimestamp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPaypalType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPaypalFee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPaypalGesamt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPaypalGrossAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsPaypal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYNCStatusBezahltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtPaypal = New System.Windows.Forms.DateTimePicker()
        Me.tab_paypal_schnellberechnung = New System.Windows.Forms.TabPage()
        Me.txtSumme = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtZwischensumme = New System.Windows.Forms.TextBox()
        Me.txtVersand = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEndsumme = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdRechnen = New System.Windows.Forms.Button()
        Me.menue_eBayBewertungen = New System.Windows.Forms.TabPage()
        Me.chkeBayBewertung_automatischRE = New System.Windows.Forms.CheckBox()
        Me.chkeBayBewertungen_allebewerted = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBewertung_bis = New System.Windows.Forms.Label()
        Me.lblBewertung_von = New System.Windows.Forms.Label()
        Me.dtp_BewertungBis = New System.Windows.Forms.DateTimePicker()
        Me.dtp_BewertungVon = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkBewertungZeitfilter = New System.Windows.Forms.CheckBox()
        Me.chkBewertung_janein = New System.Windows.Forms.CheckBox()
        Me.btnRefreshBewertungen = New System.Windows.Forms.Button()
        Me.lvwBewertungen = New System.Windows.Forms.ListView()
        Me.ClmUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmScore = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmItemId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmComment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmRole = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTransaktionID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmBeschreibung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmHitcounter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmWatchcount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmOrderStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmseBayBewertung = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnsichtAktuallisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestellübersichtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator54 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator36 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator53 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutobewertungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VarianteIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VarianteIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VarianteIIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BewertungsprofilinternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlsBewertetSetzenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BewertungsprofilÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBayArtikelÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator47 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBewertungen = New System.Windows.Forms.TextBox()
        Me.chkStartupRückbewertung = New System.Windows.Forms.CheckBox()
        Me.pgrBewertungenUpdate = New System.Windows.Forms.ProgressBar()
        Me.menue_Mailversand = New System.Windows.Forms.TabPage()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkNewsletterIseBay = New System.Windows.Forms.CheckBox()
        Me.chkNewsletterIsDelcampe = New System.Windows.Forms.CheckBox()
        Me.chkNewsletterIsWebuser = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lvMailStatus = New System.Windows.Forms.ListView()
        Me.mail_nr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_Ort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_preis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_anzahl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_verschickt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_crc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_clicked = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_last_clicked = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_sprache = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_webuser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_country = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_benutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_user_pwd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mail_muttersprache = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsNewsletter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator50 = New System.Windows.Forms.ToolStripSeparator()
        Me.BestellübersichtToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VorschauAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewsletterAnabmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersendetEinstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportierenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkNewsletter_testmodus = New System.Windows.Forms.CheckBox()
        Me.chkNurKlickt = New System.Windows.Forms.CheckBox()
        Me.chkNewsletterAlle = New System.Windows.Forms.CheckBox()
        Me.chkVerschickt = New System.Windows.Forms.CheckBox()
        Me.cmbTranslationBereichAuswählen = New System.Windows.Forms.ComboBox()
        Me.pgrMailstatusGesammt = New System.Windows.Forms.ProgressBar()
        Me.btnNewsletterReset = New System.Windows.Forms.Button()
        Me.btnAbschickenNewsletter = New System.Windows.Forms.Button()
        Me.btnMailVersandStart = New System.Windows.Forms.Button()
        Me.menue_Statistik = New System.Windows.Forms.TabPage()
        Me.tabStatistics = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.rbStatCurve = New System.Windows.Forms.RadioButton()
        Me.rbStatBalken = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbStatPlattform = New System.Windows.Forms.ComboBox()
        Me.ZedGraphControl1 = New ZedGraph.ZedGraphControl()
        Me.btnEinlesen = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.optMeisteStaedte = New System.Windows.Forms.RadioButton()
        Me.optTeuersterArtikel = New System.Windows.Forms.RadioButton()
        Me.optMeistegebote = New System.Windows.Forms.RadioButton()
        Me.optTopKundenListe = New System.Windows.Forms.RadioButton()
        Me.optStatHerkunftsland = New System.Windows.Forms.RadioButton()
        Me.optStatUmsatz = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progStatistik = New System.Windows.Forms.ProgressBar()
        Me.lvwStatisticText = New System.Windows.Forms.ListView()
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Anzahl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsStatistik_text = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator41 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menue_meineBay = New System.Windows.Forms.TabPage()
        Me.tbMeineBay = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnMeineBayÖffnen = New System.Windows.Forms.Button()
        Me.lvwEbayNachrichten = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmMessageId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmSender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmBody = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmseBayNachrichten = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EBayÖffnenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportierenToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatePickStartTo = New System.Windows.Forms.DateTimePicker()
        Me.BtnGetMemberMessages = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblTimeRange = New System.Windows.Forms.Label()
        Me.LblStartSep = New System.Windows.Forms.Label()
        Me.DatePickStartFrom = New System.Windows.Forms.DateTimePicker()
        Me.CboType = New System.Windows.Forms.ComboBox()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.CboStatus = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtAccBalance = New System.Windows.Forms.TextBox()
        Me.DatePickTo = New System.Windows.Forms.DateTimePicker()
        Me.TxtPayMethod = New System.Windows.Forms.TextBox()
        Me.DatePickFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblPayMethod = New System.Windows.Forms.Label()
        Me.DatePickInvoice = New System.Windows.Forms.DateTimePicker()
        Me.LblAccBalance = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtBezahltag = New System.Windows.Forms.TextBox()
        Me.OptRange = New System.Windows.Forms.RadioButton()
        Me.TxtAccState = New System.Windows.Forms.TextBox()
        Me.OptInvoiceDate = New System.Windows.Forms.RadioButton()
        Me.LblAccState = New System.Windows.Forms.Label()
        Me.OptLastInvoice = New System.Windows.Forms.RadioButton()
        Me.LblEntries = New System.Windows.Forms.Label()
        Me.BtnGetAccount = New System.Windows.Forms.Button()
        Me.lvwEbayRechnung = New System.Windows.Forms.ListView()
        Me.ClmRef = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTitel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmBalance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsRechnungen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EBayÖffnenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator39 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportierenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblKundenMessage = New System.Windows.Forms.Label()
        Me.txtSuchen = New System.Windows.Forms.TextBox()
        Me.cmsHomepageGalerie = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WebinterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrEMailWaitTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblLiveMessage = New System.Windows.Forms.Label()
        Me.ballonITips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.tmrEbayTime = New System.Windows.Forms.Timer(Me.components)
        Me.getThreadSearch = New System.ComponentModel.BackgroundWorker()
        Me.tmrEbayZeitWarten = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnSuchen = New System.Windows.Forms.Button()
        Me.chkEiSoArtikelverwaltung_kunden_details = New System.Windows.Forms.CheckBox()
        Me.tabMenue.SuspendLayout()
        Me.menue_eBay_Live.SuspendLayout()
        Me.lvwLiveAnsicht.SuspendLayout()
        Me.menue_kunden.SuspendLayout()
        Me.cmsKundenListview.SuspendLayout()
        Me.menue_bestellverlauf.SuspendLayout()
        Me.tcBestellungen_visual.SuspendLayout()
        Me.listenansicht.SuspendLayout()
        Me.cmsEiSoBestellungen.SuspendLayout()
        Me.bestelliste.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.cmsBestellungen_kunden.SuspendLayout()
        Me.cmsBestellungen_bestellungen.SuspendLayout()
        Me.menue_shopste.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.cmsShopsteKategorie.SuspendLayout()
        Me.cmsShopsteArtikel.SuspendLayout()
        Me.menue_artikelverwaltung.SuspendLayout()
        Me.tab_verwaltung.SuspendLayout()
        Me.eshop_daten.SuspendLayout()
        CType(Me.cms_splitcontainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_splitcontainer.Panel1.SuspendLayout()
        Me.cms_splitcontainer.Panel2.SuspendLayout()
        Me.cms_splitcontainer.SuspendLayout()
        Me.cms_KategorieListe.SuspendLayout()
        Me.cms_ArtikelVerwaltung.SuspendLayout()
        Me.eshop_bestellungen.SuspendLayout()
        Me.eshop_bilderprüfung.SuspendLayout()
        Me.cmseBayGalerie_neu.SuspendLayout()
        Me.menue_tbPaypal.SuspendLayout()
        Me.tabPaypal.SuspendLayout()
        Me.tab_paypal_api.SuspendLayout()
        Me.cmsPaypal.SuspendLayout()
        Me.tab_paypal_schnellberechnung.SuspendLayout()
        Me.menue_eBayBewertungen.SuspendLayout()
        Me.cmseBayBewertung.SuspendLayout()
        Me.menue_Mailversand.SuspendLayout()
        Me.cmsNewsletter.SuspendLayout()
        Me.menue_Statistik.SuspendLayout()
        Me.tabStatistics.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.cmsStatistik_text.SuspendLayout()
        Me.menue_meineBay.SuspendLayout()
        Me.tbMeineBay.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.cmseBayNachrichten.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.cmsRechnungen.SuspendLayout()
        Me.cmsHomepageGalerie.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMenue
        '
        Me.tabMenue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMenue.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMenue.Controls.Add(Me.menue_eBay_Live)
        Me.tabMenue.Controls.Add(Me.menue_kunden)
        Me.tabMenue.Controls.Add(Me.menue_bestellverlauf)
        Me.tabMenue.Controls.Add(Me.menue_shopste)
        Me.tabMenue.Controls.Add(Me.menue_artikelverwaltung)
        Me.tabMenue.Controls.Add(Me.menue_tbPaypal)
        Me.tabMenue.Controls.Add(Me.menue_eBayBewertungen)
        Me.tabMenue.Controls.Add(Me.menue_Mailversand)
        Me.tabMenue.Controls.Add(Me.menue_Statistik)
        Me.tabMenue.Controls.Add(Me.menue_meineBay)
        Me.tabMenue.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabMenue.HotTrack = True
        Me.tabMenue.ImageList = Me.imgAuktionsmanagement
        Me.tabMenue.ItemSize = New System.Drawing.Size(120, 28)
        Me.tabMenue.Location = New System.Drawing.Point(2, 12)
        Me.tabMenue.Multiline = True
        Me.tabMenue.Name = "tabMenue"
        Me.tabMenue.Padding = New System.Drawing.Point(6, 6)
        Me.tabMenue.SelectedIndex = 0
        Me.tabMenue.Size = New System.Drawing.Size(1158, 638)
        Me.tabMenue.TabIndex = 0
        '
        'menue_eBay_Live
        '
        Me.menue_eBay_Live.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menue_eBay_Live.Controls.Add(Me.btnAuftrag_Versandkosten)
        Me.menue_eBay_Live.Controls.Add(Me.chkMitWebgalerie)
        Me.menue_eBay_Live.Controls.Add(Me.btnQuickSync)
        Me.menue_eBay_Live.Controls.Add(Me.btnAuktionEinlesen)
        Me.menue_eBay_Live.Controls.Add(Me.chkGeboteOhne)
        Me.menue_eBay_Live.Controls.Add(Me.chkeBayEnde)
        Me.menue_eBay_Live.Controls.Add(Me.chkBuyItNow)
        Me.menue_eBay_Live.Controls.Add(Me.chkGebote)
        Me.menue_eBay_Live.Controls.Add(Me.chkLiveAlle)
        Me.menue_eBay_Live.Controls.Add(Me.Label9)
        Me.menue_eBay_Live.Controls.Add(Me.cmbPlattform_Live)
        Me.menue_eBay_Live.Controls.Add(Me.yabe_dashboard_header)
        Me.menue_eBay_Live.Controls.Add(Me.Label2)
        Me.menue_eBay_Live.Controls.Add(Me.chkEndTime)
        Me.menue_eBay_Live.Controls.Add(Me.chkDebug_email)
        Me.menue_eBay_Live.Controls.Add(Me.lblSeite)
        Me.menue_eBay_Live.Controls.Add(Me.lblVon)
        Me.menue_eBay_Live.Controls.Add(Me.lblBis)
        Me.menue_eBay_Live.Controls.Add(Me.dtpCockpit_bis)
        Me.menue_eBay_Live.Controls.Add(Me.dtpCockpit_von)
        Me.menue_eBay_Live.Controls.Add(Me.chkLiveZeitfilter)
        Me.menue_eBay_Live.Controls.Add(Me.txtGetSellerListSeiteVon)
        Me.menue_eBay_Live.Controls.Add(Me.Label8)
        Me.menue_eBay_Live.Controls.Add(Me.btnZurück)
        Me.menue_eBay_Live.Controls.Add(Me.btnVor)
        Me.menue_eBay_Live.Controls.Add(Me.chkAutomatischerModus)
        Me.menue_eBay_Live.Controls.Add(Me.Label30)
        Me.menue_eBay_Live.Controls.Add(Me.pgreBayLiveUpdate)
        Me.menue_eBay_Live.Controls.Add(Me.btnLiveStopp)
        Me.menue_eBay_Live.Controls.Add(Me.btnAuftrag_email_senden)
        Me.menue_eBay_Live.Controls.Add(Me.lvwEiSoCockpit)
        Me.menue_eBay_Live.ImageIndex = 12
        Me.menue_eBay_Live.Location = New System.Drawing.Point(4, 63)
        Me.menue_eBay_Live.Name = "menue_eBay_Live"
        Me.menue_eBay_Live.Size = New System.Drawing.Size(1150, 571)
        Me.menue_eBay_Live.TabIndex = 5
        Me.menue_eBay_Live.Text = "Aufträge"
        '
        'btnAuftrag_Versandkosten
        '
        Me.btnAuftrag_Versandkosten.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnAuftrag_Versandkosten.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuftrag_Versandkosten.Image = Global.YabE.My.Resources.Resources._19
        Me.btnAuftrag_Versandkosten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuftrag_Versandkosten.Location = New System.Drawing.Point(894, 97)
        Me.btnAuftrag_Versandkosten.Name = "btnAuftrag_Versandkosten"
        Me.btnAuftrag_Versandkosten.Size = New System.Drawing.Size(250, 25)
        Me.btnAuftrag_Versandkosten.TabIndex = 44
        Me.btnAuftrag_Versandkosten.Text = "Versandkosten verwalten..."
        Me.ballonITips.SetToolTip(Me.btnAuftrag_Versandkosten, resources.GetString("btnAuftrag_Versandkosten.ToolTip"))
        Me.btnAuftrag_Versandkosten.UseVisualStyleBackColor = False
        '
        'chkMitWebgalerie
        '
        Me.chkMitWebgalerie.AutoSize = True
        Me.chkMitWebgalerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMitWebgalerie.Location = New System.Drawing.Point(321, 56)
        Me.chkMitWebgalerie.Name = "chkMitWebgalerie"
        Me.chkMitWebgalerie.Size = New System.Drawing.Size(183, 17)
        Me.chkMitWebgalerie.TabIndex = 43
        Me.chkMitWebgalerie.Text = "eBay Webgalerie Update"
        Me.ballonITips.SetToolTip(Me.chkMitWebgalerie, "Wenn der Schalter an ist, wird bei eBay die Webgalerie generiert." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Diese Galerie " &
        "können Sie bei eBay Verlinken.")
        Me.chkMitWebgalerie.UseVisualStyleBackColor = True
        '
        'btnQuickSync
        '
        Me.btnQuickSync.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnQuickSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickSync.Image = Global.YabE.My.Resources.Resources.adressbuch
        Me.btnQuickSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuickSync.Location = New System.Drawing.Point(969, 101)
        Me.btnQuickSync.Name = "btnQuickSync"
        Me.btnQuickSync.Size = New System.Drawing.Size(178, 25)
        Me.btnQuickSync.TabIndex = 42
        Me.btnQuickSync.Text = "QuickSync"
        Me.ballonITips.SetToolTip(Me.btnQuickSync, "Für eBay führt eine sehr schnelle eBay Synchronisation durch.")
        Me.btnQuickSync.UseVisualStyleBackColor = False
        Me.btnQuickSync.Visible = False
        '
        'btnAuktionEinlesen
        '
        Me.btnAuktionEinlesen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnAuktionEinlesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuktionEinlesen.Image = Global.YabE.My.Resources.Resources.adressbuch
        Me.btnAuktionEinlesen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuktionEinlesen.Location = New System.Drawing.Point(542, 94)
        Me.btnAuktionEinlesen.Name = "btnAuktionEinlesen"
        Me.btnAuktionEinlesen.Size = New System.Drawing.Size(347, 25)
        Me.btnAuktionEinlesen.TabIndex = 11
        Me.btnAuktionEinlesen.Text = "eBay Auktionen einlesen"
        Me.ballonITips.SetToolTip(Me.btnAuktionEinlesen, resources.GetString("btnAuktionEinlesen.ToolTip"))
        Me.btnAuktionEinlesen.UseVisualStyleBackColor = False
        '
        'chkGeboteOhne
        '
        Me.chkGeboteOhne.AutoSize = True
        Me.chkGeboteOhne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGeboteOhne.Location = New System.Drawing.Point(782, 27)
        Me.chkGeboteOhne.Name = "chkGeboteOhne"
        Me.chkGeboteOhne.Size = New System.Drawing.Size(117, 17)
        Me.chkGeboteOhne.TabIndex = 41
        Me.chkGeboteOhne.TabStop = True
        Me.chkGeboteOhne.Text = "Nicht verkauft"
        Me.chkGeboteOhne.UseVisualStyleBackColor = True
        '
        'chkeBayEnde
        '
        Me.chkeBayEnde.AutoSize = True
        Me.chkeBayEnde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkeBayEnde.Location = New System.Drawing.Point(542, 56)
        Me.chkeBayEnde.Name = "chkeBayEnde"
        Me.chkeBayEnde.Size = New System.Drawing.Size(76, 17)
        Me.chkeBayEnde.TabIndex = 40
        Me.chkeBayEnde.Text = "Beendet"
        Me.ballonITips.SetToolTip(Me.chkeBayEnde, "Aktivieren Sie diesen Schalter um beendete Artikel anzuzeigen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In Kombination mi" &
        "t ""Verkauft"" erreichen Sie den Email-Versand Modus")
        Me.chkeBayEnde.UseVisualStyleBackColor = True
        '
        'chkBuyItNow
        '
        Me.chkBuyItNow.AutoSize = True
        Me.chkBuyItNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBuyItNow.Location = New System.Drawing.Point(969, 30)
        Me.chkBuyItNow.Name = "chkBuyItNow"
        Me.chkBuyItNow.Size = New System.Drawing.Size(159, 17)
        Me.chkBuyItNow.TabIndex = 39
        Me.chkBuyItNow.TabStop = True
        Me.chkBuyItNow.Text = "Sofortkauf (Auktion)"
        Me.chkBuyItNow.UseVisualStyleBackColor = True
        '
        'chkGebote
        '
        Me.chkGebote.AutoSize = True
        Me.chkGebote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGebote.Location = New System.Drawing.Point(642, 27)
        Me.chkGebote.Name = "chkGebote"
        Me.chkGebote.Size = New System.Drawing.Size(80, 17)
        Me.chkGebote.TabIndex = 38
        Me.chkGebote.TabStop = True
        Me.chkGebote.Text = "&Verkauft"
        Me.ballonITips.SetToolTip(Me.chkGebote, "Zeigt alle Verkauften Artikel an." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In Kombination mit ""Zahlungshinweise"" abschick" &
        "en erreichen Sie den Email-Versand.")
        Me.chkGebote.UseVisualStyleBackColor = True
        '
        'chkLiveAlle
        '
        Me.chkLiveAlle.AutoSize = True
        Me.chkLiveAlle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLiveAlle.Location = New System.Drawing.Point(542, 27)
        Me.chkLiveAlle.Name = "chkLiveAlle"
        Me.chkLiveAlle.Size = New System.Drawing.Size(49, 17)
        Me.chkLiveAlle.TabIndex = 36
        Me.chkLiveAlle.TabStop = True
        Me.chkLiveAlle.Text = "Alle"
        Me.ballonITips.SetToolTip(Me.chkLiveAlle, "Zeigt wirklich alle Artikel egal ob verkauft, nicht verkauft inkl. Sofortkauf Auk" &
        "tionen.")
        Me.chkLiveAlle.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(239, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Verkaufsplattform"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ballonITips.SetToolTip(Me.Label9, "Ändern Sie Ihre Plattform auswahl")
        '
        'cmbPlattform_Live
        '
        Me.cmbPlattform_Live.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbPlattform_Live.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlattform_Live.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlattform_Live.FormattingEnabled = True
        Me.cmbPlattform_Live.Location = New System.Drawing.Point(9, 53)
        Me.cmbPlattform_Live.Name = "cmbPlattform_Live"
        Me.cmbPlattform_Live.Size = New System.Drawing.Size(239, 21)
        Me.cmbPlattform_Live.TabIndex = 7
        Me.ballonITips.SetToolTip(Me.cmbPlattform_Live, resources.GetString("cmbPlattform_Live.ToolTip"))
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(10, 6)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(158, 23)
        Me.yabe_dashboard_header.TabIndex = 34
        Me.yabe_dashboard_header.Text = "EiSo Aufträge"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(539, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(605, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Auswahlkriterien für die Anzeige:"
        Me.ballonITips.SetToolTip(Me.Label2, "Die Kriterien verstehen sich als UND Verknüpfung")
        '
        'chkEndTime
        '
        Me.chkEndTime.AutoSize = True
        Me.chkEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEndTime.Location = New System.Drawing.Point(321, 10)
        Me.chkEndTime.Name = "chkEndTime"
        Me.chkEndTime.Size = New System.Drawing.Size(122, 17)
        Me.chkEndTime.TabIndex = 18
        Me.chkEndTime.Text = "Verkaufsdatum"
        Me.ballonITips.SetToolTip(Me.chkEndTime, "Hauptschalter um die eBay Verkaufsliste abzurufen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Einstelldatum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Auktionsen" &
        "de")
        Me.chkEndTime.UseVisualStyleBackColor = True
        '
        'chkDebug_email
        '
        Me.chkDebug_email.AutoSize = True
        Me.chkDebug_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDebug_email.Location = New System.Drawing.Point(642, 56)
        Me.chkDebug_email.Name = "chkDebug_email"
        Me.chkDebug_email.Size = New System.Drawing.Size(109, 17)
        Me.chkDebug_email.TabIndex = 3
        Me.chkDebug_email.Text = "Debug Modus"
        Me.chkDebug_email.UseVisualStyleBackColor = True
        Me.chkDebug_email.Visible = False
        '
        'lblSeite
        '
        Me.lblSeite.AutoSize = True
        Me.lblSeite.Location = New System.Drawing.Point(956, 80)
        Me.lblSeite.Name = "lblSeite"
        Me.lblSeite.Size = New System.Drawing.Size(0, 13)
        Me.lblSeite.TabIndex = 14
        Me.lblSeite.Visible = False
        '
        'lblVon
        '
        Me.lblVon.BackColor = System.Drawing.Color.Silver
        Me.lblVon.Location = New System.Drawing.Point(9, 83)
        Me.lblVon.Name = "lblVon"
        Me.lblVon.Size = New System.Drawing.Size(244, 13)
        Me.lblVon.TabIndex = 6
        Me.lblVon.Text = "Von - Einstelldatum"
        '
        'lblBis
        '
        Me.lblBis.BackColor = System.Drawing.Color.Silver
        Me.lblBis.Location = New System.Drawing.Point(262, 83)
        Me.lblBis.Name = "lblBis"
        Me.lblBis.Size = New System.Drawing.Size(242, 14)
        Me.lblBis.TabIndex = 7
        Me.lblBis.Text = "Bis - Einstelldatum"
        '
        'dtpCockpit_bis
        '
        Me.dtpCockpit_bis.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpCockpit_bis.Location = New System.Drawing.Point(262, 98)
        Me.dtpCockpit_bis.Name = "dtpCockpit_bis"
        Me.dtpCockpit_bis.Size = New System.Drawing.Size(242, 21)
        Me.dtpCockpit_bis.TabIndex = 9
        '
        'dtpCockpit_von
        '
        Me.dtpCockpit_von.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpCockpit_von.Location = New System.Drawing.Point(9, 99)
        Me.dtpCockpit_von.Name = "dtpCockpit_von"
        Me.dtpCockpit_von.Size = New System.Drawing.Size(244, 21)
        Me.dtpCockpit_von.TabIndex = 8
        '
        'chkLiveZeitfilter
        '
        Me.chkLiveZeitfilter.AutoSize = True
        Me.chkLiveZeitfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLiveZeitfilter.Location = New System.Drawing.Point(950, 56)
        Me.chkLiveZeitfilter.Name = "chkLiveZeitfilter"
        Me.chkLiveZeitfilter.Size = New System.Drawing.Size(97, 17)
        Me.chkLiveZeitfilter.TabIndex = 22
        Me.chkLiveZeitfilter.Text = "&Datumfilter"
        Me.ballonITips.SetToolTip(Me.chkLiveZeitfilter, "Filtert die Ansicht in dem eingestellten Zeitraum." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beachten Sie ""Verkaufsdatum""")
        Me.chkLiveZeitfilter.UseVisualStyleBackColor = True
        '
        'txtGetSellerListSeiteVon
        '
        Me.txtGetSellerListSeiteVon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGetSellerListSeiteVon.Location = New System.Drawing.Point(895, 100)
        Me.txtGetSellerListSeiteVon.Name = "txtGetSellerListSeiteVon"
        Me.txtGetSellerListSeiteVon.Size = New System.Drawing.Size(68, 21)
        Me.txtGetSellerListSeiteVon.TabIndex = 10
        Me.txtGetSellerListSeiteVon.Text = "0"
        Me.txtGetSellerListSeiteVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ballonITips.SetToolTip(Me.txtGetSellerListSeiteVon, "Definiert die Startseite beim Abruf der Verkaufsliste von eBay")
        Me.txtGetSellerListSeiteVon.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(892, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Startseite"
        Me.Label8.Visible = False
        '
        'btnZurück
        '
        Me.btnZurück.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZurück.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnZurück.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZurück.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZurück.Location = New System.Drawing.Point(1053, 52)
        Me.btnZurück.Name = "btnZurück"
        Me.btnZurück.Size = New System.Drawing.Size(40, 21)
        Me.btnZurück.TabIndex = 13
        Me.btnZurück.Text = "<<"
        Me.btnZurück.UseVisualStyleBackColor = False
        Me.btnZurück.Visible = False
        '
        'btnVor
        '
        Me.btnVor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVor.Location = New System.Drawing.Point(1099, 52)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(40, 21)
        Me.btnVor.TabIndex = 12
        Me.btnVor.Text = ">>"
        Me.btnVor.UseVisualStyleBackColor = False
        Me.btnVor.Visible = False
        '
        'chkAutomatischerModus
        '
        Me.chkAutomatischerModus.AutoSize = True
        Me.chkAutomatischerModus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAutomatischerModus.Location = New System.Drawing.Point(321, 33)
        Me.chkAutomatischerModus.Name = "chkAutomatischerModus"
        Me.chkAutomatischerModus.Size = New System.Drawing.Size(159, 17)
        Me.chkAutomatischerModus.TabIndex = 4
        Me.chkAutomatischerModus.Text = "Automatisch abrufen"
        Me.ballonITips.SetToolTip(Me.chkAutomatischerModus, "Aktiviert den Automatischen Modus (siehe Optionen für Zeiteinstellung)")
        Me.chkAutomatischerModus.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.BackColor = System.Drawing.Color.Silver
        Me.Label30.Location = New System.Drawing.Point(2, 81)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(1144, 16)
        Me.Label30.TabIndex = 7
        '
        'pgreBayLiveUpdate
        '
        Me.pgreBayLiveUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgreBayLiveUpdate.Location = New System.Drawing.Point(8, 127)
        Me.pgreBayLiveUpdate.Name = "pgreBayLiveUpdate"
        Me.pgreBayLiveUpdate.Size = New System.Drawing.Size(1138, 15)
        Me.pgreBayLiveUpdate.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgreBayLiveUpdate.TabIndex = 23
        Me.pgreBayLiveUpdate.Visible = False
        '
        'btnLiveStopp
        '
        Me.btnLiveStopp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLiveStopp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiveStopp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiveStopp.ImageIndex = 16
        Me.btnLiveStopp.Location = New System.Drawing.Point(541, 97)
        Me.btnLiveStopp.Name = "btnLiveStopp"
        Me.btnLiveStopp.Size = New System.Drawing.Size(347, 23)
        Me.btnLiveStopp.TabIndex = 27
        Me.btnLiveStopp.Text = "Stoppen - eBay abrufen"
        Me.btnLiveStopp.UseVisualStyleBackColor = False
        Me.btnLiveStopp.Visible = False
        '
        'btnAuftrag_email_senden
        '
        Me.btnAuftrag_email_senden.BackColor = System.Drawing.Color.MistyRose
        Me.btnAuftrag_email_senden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuftrag_email_senden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuftrag_email_senden.ImageIndex = 5
        Me.btnAuftrag_email_senden.Location = New System.Drawing.Point(541, 96)
        Me.btnAuftrag_email_senden.Name = "btnAuftrag_email_senden"
        Me.btnAuftrag_email_senden.Size = New System.Drawing.Size(348, 23)
        Me.btnAuftrag_email_senden.TabIndex = 10
        Me.btnAuftrag_email_senden.Text = "Auktionsende Emails abschicken"
        Me.ballonITips.SetToolTip(Me.btnAuftrag_email_senden, resources.GetString("btnAuftrag_email_senden.ToolTip"))
        Me.btnAuftrag_email_senden.UseVisualStyleBackColor = False
        Me.btnAuftrag_email_senden.Visible = False
        '
        'lvwEiSoCockpit
        '
        Me.lvwEiSoCockpit.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwEiSoCockpit.AllowColumnReorder = True
        Me.lvwEiSoCockpit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwEiSoCockpit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwEiSoCockpit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwEiSoCockpit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.live_ebayID, Me.live_beschreibung, Me.live_endpreis, Me.live_startpreis, Me.live_gebote, Me.live_ebaymitglied, Me.live_email, Me.live_completed_status, Me.live_ListType, Me.live_auktionend, Me.live_watchcounter, Me.live_auktionbeginn, Me.live_versandkosten, Me.live_ebaybild, Me.live_lastupdate, Me.live_hitcounter, Me.live_eBayFragen, Me.live_auktion_plattform, Me.live_paypal_endsumme, Me.live_yabe_id, Me.live_person_name, Me.live_person_land, Me.live_verschickt, Me.live_menge, Me.bild_name, Me.live_stadt, Me.live_eiso_orderlist_id})
        Me.lvwEiSoCockpit.ContextMenuStrip = Me.lvwLiveAnsicht
        Me.lvwEiSoCockpit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEiSoCockpit.FullRowSelect = True
        Me.lvwEiSoCockpit.GridLines = True
        Me.lvwEiSoCockpit.HideSelection = False
        Me.lvwEiSoCockpit.LargeImageList = Me.bilder_history
        Me.lvwEiSoCockpit.Location = New System.Drawing.Point(6, 148)
        Me.lvwEiSoCockpit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lvwEiSoCockpit.Name = "lvwEiSoCockpit"
        Me.lvwEiSoCockpit.ShowItemToolTips = True
        Me.lvwEiSoCockpit.Size = New System.Drawing.Size(1139, 418)
        Me.lvwEiSoCockpit.SmallImageList = Me.bilder_history
        Me.lvwEiSoCockpit.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwEiSoCockpit.TabIndex = 1
        Me.lvwEiSoCockpit.UseCompatibleStateImageBehavior = False
        Me.lvwEiSoCockpit.View = System.Windows.Forms.View.Details
        '
        'live_ebayID
        '
        Me.live_ebayID.Text = "Verkaufs-ID"
        Me.live_ebayID.Width = 0
        '
        'live_beschreibung
        '
        Me.live_beschreibung.DisplayIndex = 3
        Me.live_beschreibung.Text = "Beschreibung"
        Me.live_beschreibung.Width = 370
        '
        'live_endpreis
        '
        Me.live_endpreis.DisplayIndex = 9
        Me.live_endpreis.Text = "Ende"
        Me.live_endpreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.live_endpreis.Width = 41
        '
        'live_startpreis
        '
        Me.live_startpreis.DisplayIndex = 4
        Me.live_startpreis.Text = "Start"
        Me.live_startpreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.live_startpreis.Width = 41
        '
        'live_gebote
        '
        Me.live_gebote.DisplayIndex = 5
        Me.live_gebote.Text = "Bids"
        Me.live_gebote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.live_gebote.Width = 37
        '
        'live_ebaymitglied
        '
        Me.live_ebaymitglied.DisplayIndex = 12
        Me.live_ebaymitglied.Text = "Mitgliedsname"
        Me.live_ebaymitglied.Width = 150
        '
        'live_email
        '
        Me.live_email.DisplayIndex = 14
        Me.live_email.Text = "eMail"
        Me.live_email.Width = 149
        '
        'live_completed_status
        '
        Me.live_completed_status.DisplayIndex = 15
        Me.live_completed_status.Text = "Status"
        Me.live_completed_status.Width = 62
        '
        'live_ListType
        '
        Me.live_ListType.DisplayIndex = 16
        Me.live_ListType.Text = "Typ"
        Me.live_ListType.Width = 75
        '
        'live_auktionend
        '
        Me.live_auktionend.DisplayIndex = 17
        Me.live_auktionend.Text = "Auktionsende"
        Me.live_auktionend.Width = 150
        '
        'live_watchcounter
        '
        Me.live_watchcounter.DisplayIndex = 6
        Me.live_watchcounter.Text = "Beobachter"
        Me.live_watchcounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'live_auktionbeginn
        '
        Me.live_auktionbeginn.DisplayIndex = 18
        Me.live_auktionbeginn.Text = "Auktionsbeginn"
        Me.live_auktionbeginn.Width = 150
        '
        'live_versandkosten
        '
        Me.live_versandkosten.DisplayIndex = 19
        Me.live_versandkosten.Text = "Versand"
        Me.live_versandkosten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'live_ebaybild
        '
        Me.live_ebaybild.DisplayIndex = 20
        Me.live_ebaybild.Text = "eBay Bildpfad"
        Me.live_ebaybild.Width = 0
        '
        'live_lastupdate
        '
        Me.live_lastupdate.DisplayIndex = 21
        Me.live_lastupdate.Text = "Letztes Update"
        Me.live_lastupdate.Width = 97
        '
        'live_hitcounter
        '
        Me.live_hitcounter.DisplayIndex = 7
        Me.live_hitcounter.Text = "Counter"
        Me.live_hitcounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'live_eBayFragen
        '
        Me.live_eBayFragen.DisplayIndex = 8
        Me.live_eBayFragen.Text = "Fragen"
        Me.live_eBayFragen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.live_eBayFragen.Width = 120
        '
        'live_auktion_plattform
        '
        Me.live_auktion_plattform.DisplayIndex = 1
        Me.live_auktion_plattform.Text = "Plattform"
        Me.live_auktion_plattform.Width = 77
        '
        'live_paypal_endsumme
        '
        Me.live_paypal_endsumme.DisplayIndex = 22
        Me.live_paypal_endsumme.Text = "Paypal"
        Me.live_paypal_endsumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'live_yabe_id
        '
        Me.live_yabe_id.DisplayIndex = 23
        Me.live_yabe_id.Text = "YABE-ID"
        Me.live_yabe_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'live_person_name
        '
        Me.live_person_name.DisplayIndex = 10
        Me.live_person_name.Text = "Name"
        '
        'live_person_land
        '
        Me.live_person_land.DisplayIndex = 13
        Me.live_person_land.Text = "Land"
        '
        'live_verschickt
        '
        Me.live_verschickt.DisplayIndex = 24
        Me.live_verschickt.Text = "Send"
        '
        'live_menge
        '
        Me.live_menge.DisplayIndex = 2
        Me.live_menge.Text = "Menge"
        '
        'bild_name
        '
        Me.bild_name.DisplayIndex = 25
        Me.bild_name.Text = "Bildname"
        '
        'live_stadt
        '
        Me.live_stadt.DisplayIndex = 11
        Me.live_stadt.Text = "Stadt"
        Me.live_stadt.Width = 140
        '
        'live_eiso_orderlist_id
        '
        Me.live_eiso_orderlist_id.Text = "EiSo Order Id"
        '
        'lvwLiveAnsicht
        '
        Me.lvwLiveAnsicht.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsichtAktuallisierenToolStripMenuItem2, Me.VersandkostenberechnungToolStripMenuItem, Me.EMailVorschauAnzeigenToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripSeparator18, Me.SNYCEBayAPIDataToolStripMenuItem, Me.OutlookSyncToolStripMenuItem, Me.SYNCCockpitBestellungenToolStripMenuItem, Me.ToolStripSeparator52, Me.YABEKundenverlaufToolStripMenuItem, Me.ToolStripSeparator30, Me.tsmeBayLive_Detailansicht, Me.EBayBeschreibungErweiternToolStripMenuItem, Me.ArtikelBeendenToolStripMenuItem, Me.HöchstbietenderToolStripMenuItem, Me.BietverlaufToolStripMenuItem, Me.HöchstbietenderBewertungsprofilToolStripMenuItem1, Me.EBayCrossPromotionToolStripMenuItem, Me.EBayVerkaufseventsToolStripMenuItem, Me.ToolStripSeparator31, Me.LiveÖffnenToolStripMenuItem, Me.EMailExternesProgrammToolStripMenuItem, Me.ToolStripSeparator7, Me.CopyEBayIDToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.Copy_Beschreibung, Me.ToolStripSeparator3, Me.IsSendToolStripMenuItem, Me.EntfernenToolStripMenuItem, Me.ArtikelKomplettLöschenToolStripMenuItem, Me.ToolStripSeparator15, Me.ExportToolStripMenuItem, Me.BildLöschenToolStripMenuItem})
        Me.lvwLiveAnsicht.Name = "lvwLiveAnsicht"
        Me.lvwLiveAnsicht.Size = New System.Drawing.Size(414, 618)
        '
        'AnsichtAktuallisierenToolStripMenuItem2
        '
        Me.AnsichtAktuallisierenToolStripMenuItem2.Image = Global.YabE.My.Resources.Resources._24
        Me.AnsichtAktuallisierenToolStripMenuItem2.Name = "AnsichtAktuallisierenToolStripMenuItem2"
        Me.AnsichtAktuallisierenToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AnsichtAktuallisierenToolStripMenuItem2.Size = New System.Drawing.Size(413, 22)
        Me.AnsichtAktuallisierenToolStripMenuItem2.Text = "Ansicht -> aktuallisieren"
        '
        'VersandkostenberechnungToolStripMenuItem
        '
        Me.VersandkostenberechnungToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersandkostenberechnungToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.emailnewicon23
        Me.VersandkostenberechnungToolStripMenuItem.Name = "VersandkostenberechnungToolStripMenuItem"
        Me.VersandkostenberechnungToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VersandkostenberechnungToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.VersandkostenberechnungToolStripMenuItem.Text = "&Versandkostenberechnung..."
        Me.VersandkostenberechnungToolStripMenuItem.ToolTipText = "Ermöglicht die Versandkostensteuerung"
        '
        'EMailVorschauAnzeigenToolStripMenuItem
        '
        Me.EMailVorschauAnzeigenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.EMailVorschauAnzeigenToolStripMenuItem.Name = "EMailVorschauAnzeigenToolStripMenuItem"
        Me.EMailVorschauAnzeigenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.EMailVorschauAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.EMailVorschauAnzeigenToolStripMenuItem.Text = "Verkaufse&mail -> Vorschau anzeigen..."
        Me.EMailVorschauAnzeigenToolStripMenuItem.ToolTipText = "Zeigt eine HTML Vorschau im YABE Browser"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Image = Global.YabE.My.Resources.Resources.Desktop21
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(413, 22)
        Me.ToolStripMenuItem3.Text = "WebCenter -> Artikelansicht..."
        Me.ToolStripMenuItem3.ToolTipText = "Interner YABE Webbrowser"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(410, 6)
        '
        'SNYCEBayAPIDataToolStripMenuItem
        '
        Me.SNYCEBayAPIDataToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.SNYCEBayAPIDataToolStripMenuItem.Name = "SNYCEBayAPIDataToolStripMenuItem"
        Me.SNYCEBayAPIDataToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SNYCEBayAPIDataToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.SNYCEBayAPIDataToolStripMenuItem.Text = "eBay Daten abrufen"
        '
        'OutlookSyncToolStripMenuItem
        '
        Me.OutlookSyncToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.OutlookSyncToolStripMenuItem.Name = "OutlookSyncToolStripMenuItem"
        Me.OutlookSyncToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OutlookSyncToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.OutlookSyncToolStripMenuItem.Text = "Delcampe Outlook abrufen"
        '
        'SYNCCockpitBestellungenToolStripMenuItem
        '
        Me.SYNCCockpitBestellungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.SYNCCockpitBestellungenToolStripMenuItem.Name = "SYNCCockpitBestellungenToolStripMenuItem"
        Me.SYNCCockpitBestellungenToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.SYNCCockpitBestellungenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.SYNCCockpitBestellungenToolStripMenuItem.Text = "Cockpit mit Bestellungen synchronisieren"
        '
        'ToolStripSeparator52
        '
        Me.ToolStripSeparator52.Name = "ToolStripSeparator52"
        Me.ToolStripSeparator52.Size = New System.Drawing.Size(410, 6)
        '
        'YABEKundenverlaufToolStripMenuItem
        '
        Me.YABEKundenverlaufToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YABEKundenverlaufToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.YABEKundenverlaufToolStripMenuItem.Name = "YABEKundenverlaufToolStripMenuItem"
        Me.YABEKundenverlaufToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.YABEKundenverlaufToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.YABEKundenverlaufToolStripMenuItem.Text = "Kundenverlauf..."
        Me.YABEKundenverlaufToolStripMenuItem.ToolTipText = "Zeigt vom Kunden vorherige Bestellunge an "
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        Me.ToolStripSeparator30.Size = New System.Drawing.Size(410, 6)
        '
        'tsmeBayLive_Detailansicht
        '
        Me.tsmeBayLive_Detailansicht.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.tsmeBayLive_Detailansicht.Name = "tsmeBayLive_Detailansicht"
        Me.tsmeBayLive_Detailansicht.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmeBayLive_Detailansicht.Size = New System.Drawing.Size(413, 22)
        Me.tsmeBayLive_Detailansicht.Text = "Artikel&details..."
        Me.tsmeBayLive_Detailansicht.ToolTipText = "Zeigt erweiterte eBay Artikel Informationen an"
        '
        'EBayBeschreibungErweiternToolStripMenuItem
        '
        Me.EBayBeschreibungErweiternToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.tab_edit
        Me.EBayBeschreibungErweiternToolStripMenuItem.Name = "EBayBeschreibungErweiternToolStripMenuItem"
        Me.EBayBeschreibungErweiternToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.EBayBeschreibungErweiternToolStripMenuItem.Text = "Beschreibung erweitern..."
        Me.EBayBeschreibungErweiternToolStripMenuItem.ToolTipText = "Fügt einen Kommentar beim eBay Artikel hinzu"
        '
        'ArtikelBeendenToolStripMenuItem
        '
        Me.ArtikelBeendenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.ArtikelBeendenToolStripMenuItem.Name = "ArtikelBeendenToolStripMenuItem"
        Me.ArtikelBeendenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.ArtikelBeendenToolStripMenuItem.Text = "&eBay Artikel  -> beenden..."
        Me.ArtikelBeendenToolStripMenuItem.ToolTipText = "Beendet den makierten eBay Artikel"
        '
        'HöchstbietenderToolStripMenuItem
        '
        Me.HöchstbietenderToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HöchstbietenderToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_add
        Me.HöchstbietenderToolStripMenuItem.Name = "HöchstbietenderToolStripMenuItem"
        Me.HöchstbietenderToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HöchstbietenderToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.HöchstbietenderToolStripMenuItem.Text = " &Höchstbieter..."
        Me.HöchstbietenderToolStripMenuItem.ToolTipText = "Zeigt erweiterte Informationen zum Höchstbieter"
        '
        'BietverlaufToolStripMenuItem
        '
        Me.BietverlaufToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BietverlaufToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._31
        Me.BietverlaufToolStripMenuItem.Name = "BietverlaufToolStripMenuItem"
        Me.BietverlaufToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BietverlaufToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.BietverlaufToolStripMenuItem.Text = " &Bietverlauf..."
        Me.BietverlaufToolStripMenuItem.ToolTipText = "Öffnet den eBay Bietverlauf"
        '
        'HöchstbietenderBewertungsprofilToolStripMenuItem1
        '
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._30
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem1.Name = "HöchstbietenderBewertungsprofilToolStripMenuItem1"
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem1.Size = New System.Drawing.Size(413, 22)
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem1.Text = "Höchstbieter Bewertungsprofil"
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem1.ToolTipText = "Öffnet YABE Bewertungen und zeigt das Bewertungsprofil"
        '
        'EBayCrossPromotionToolStripMenuItem
        '
        Me.EBayCrossPromotionToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.time_go
        Me.EBayCrossPromotionToolStripMenuItem.Name = "EBayCrossPromotionToolStripMenuItem"
        Me.EBayCrossPromotionToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.EBayCrossPromotionToolStripMenuItem.Text = "CrossPromotion..."
        Me.EBayCrossPromotionToolStripMenuItem.ToolTipText = "Analysieren Sie Ihre eBay Cross Promotions"
        '
        'EBayVerkaufseventsToolStripMenuItem
        '
        Me.EBayVerkaufseventsToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._33
        Me.EBayVerkaufseventsToolStripMenuItem.Name = "EBayVerkaufseventsToolStripMenuItem"
        Me.EBayVerkaufseventsToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.EBayVerkaufseventsToolStripMenuItem.Text = "Käuferaktivitäten..."
        Me.EBayVerkaufseventsToolStripMenuItem.ToolTipText = "Kleine Schnelle Liste der Letzten Events"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(410, 6)
        '
        'LiveÖffnenToolStripMenuItem
        '
        Me.LiveÖffnenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.LiveÖffnenToolStripMenuItem.Name = "LiveÖffnenToolStripMenuItem"
        Me.LiveÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LiveÖffnenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.LiveÖffnenToolStripMenuItem.Text = "Web Link -> &Artikel öffnen"
        Me.LiveÖffnenToolStripMenuItem.ToolTipText = "Zeigt den entsprechenden in der Webansicht"
        '
        'EMailExternesProgrammToolStripMenuItem
        '
        Me.EMailExternesProgrammToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.email_go
        Me.EMailExternesProgrammToolStripMenuItem.Name = "EMailExternesProgrammToolStripMenuItem"
        Me.EMailExternesProgrammToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.EMailExternesProgrammToolStripMenuItem.Text = "Verkaufsemail -> externes Programm"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(410, 6)
        '
        'CopyEBayIDToolStripMenuItem
        '
        Me.CopyEBayIDToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.CopyEBayIDToolStripMenuItem.Name = "CopyEBayIDToolStripMenuItem"
        Me.CopyEBayIDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.CopyEBayIDToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.CopyEBayIDToolStripMenuItem.Text = "&Kopieren -> eBay Artikelnummer"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.KopierenToolStripMenuItem.Text = "&Kopieren ->  Email "
        '
        'Copy_Beschreibung
        '
        Me.Copy_Beschreibung.Image = Global.YabE.My.Resources.Resources.save
        Me.Copy_Beschreibung.Name = "Copy_Beschreibung"
        Me.Copy_Beschreibung.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.Copy_Beschreibung.Size = New System.Drawing.Size(413, 22)
        Me.Copy_Beschreibung.Text = "Kopieren -> eBay Beschreibung"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(410, 6)
        '
        'IsSendToolStripMenuItem
        '
        Me.IsSendToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.letter_open
        Me.IsSendToolStripMenuItem.Name = "IsSendToolStripMenuItem"
        Me.IsSendToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.IsSendToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.IsSendToolStripMenuItem.Text = "Artikel -> &verschickt makieren (wird nicht verschickt)"
        Me.IsSendToolStripMenuItem.ToolTipText = "Ist Vorraussetzung für die Übernahme zu den Bestellungen"
        '
        'EntfernenToolStripMenuItem
        '
        Me.EntfernenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.EntfernenToolStripMenuItem.Name = "EntfernenToolStripMenuItem"
        Me.EntfernenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.EntfernenToolStripMenuItem.Text = "Artikel -> entfernt makieren "
        Me.EntfernenToolStripMenuItem.ToolTipText = "Dieser Artikel wird als beendet Markiert damit er übernommen werden kann"
        Me.EntfernenToolStripMenuItem.Visible = False
        '
        'ArtikelKomplettLöschenToolStripMenuItem
        '
        Me.ArtikelKomplettLöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.ArtikelKomplettLöschenToolStripMenuItem.Name = "ArtikelKomplettLöschenToolStripMenuItem"
        Me.ArtikelKomplettLöschenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.ArtikelKomplettLöschenToolStripMenuItem.Text = "Artikel -> Komplett löschen"
        Me.ArtikelKomplettLöschenToolStripMenuItem.ToolTipText = "Löscht den Artikel unwiderruflich"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(410, 6)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.ExportToolStripMenuItem.Text = "&Übersicht exportieren..."
        Me.ExportToolStripMenuItem.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'BildLöschenToolStripMenuItem
        '
        Me.BildLöschenToolStripMenuItem.Name = "BildLöschenToolStripMenuItem"
        Me.BildLöschenToolStripMenuItem.Size = New System.Drawing.Size(413, 22)
        Me.BildLöschenToolStripMenuItem.Text = "Bild löschen"
        '
        'bilder_history
        '
        Me.bilder_history.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.bilder_history.ImageSize = New System.Drawing.Size(60, 60)
        Me.bilder_history.TransparentColor = System.Drawing.Color.Transparent
        '
        'menue_kunden
        '
        Me.menue_kunden.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menue_kunden.Controls.Add(Me.chkKundenverwaltung_kunde_ab_gestern)
        Me.menue_kunden.Controls.Add(Me.chkShopLastLogin)
        Me.menue_kunden.Controls.Add(Me.chkKundenZeitfilter)
        Me.menue_kunden.Controls.Add(Me.Label28)
        Me.menue_kunden.Controls.Add(Me.Label24)
        Me.menue_kunden.Controls.Add(Me.cmbPlattform_kunden)
        Me.menue_kunden.Controls.Add(Me.chkKundenHeute)
        Me.menue_kunden.Controls.Add(Me.lblKunden_Main_label)
        Me.menue_kunden.Controls.Add(Me.Label6)
        Me.menue_kunden.Controls.Add(Me.Label7)
        Me.menue_kunden.Controls.Add(Me.KundenBis)
        Me.menue_kunden.Controls.Add(Me.KundenVon)
        Me.menue_kunden.Controls.Add(Me.pgrKundenverlauf)
        Me.menue_kunden.Controls.Add(Me.chkKundenFullReport)
        Me.menue_kunden.Controls.Add(Me.btnAdressLabels)
        Me.menue_kunden.Controls.Add(Me.btnKundenHolen)
        Me.menue_kunden.Controls.Add(Me.lvwKunden)
        Me.menue_kunden.ImageIndex = 16
        Me.menue_kunden.Location = New System.Drawing.Point(4, 63)
        Me.menue_kunden.Name = "menue_kunden"
        Me.menue_kunden.Padding = New System.Windows.Forms.Padding(3)
        Me.menue_kunden.Size = New System.Drawing.Size(1150, 571)
        Me.menue_kunden.TabIndex = 1
        Me.menue_kunden.Text = "Kundenverwaltung"
        '
        'chkKundenverwaltung_kunde_ab_gestern
        '
        Me.chkKundenverwaltung_kunde_ab_gestern.AutoSize = True
        Me.chkKundenverwaltung_kunde_ab_gestern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKundenverwaltung_kunde_ab_gestern.Location = New System.Drawing.Point(592, 33)
        Me.chkKundenverwaltung_kunde_ab_gestern.Name = "chkKundenverwaltung_kunde_ab_gestern"
        Me.chkKundenverwaltung_kunde_ab_gestern.Size = New System.Drawing.Size(209, 17)
        Me.chkKundenverwaltung_kunde_ab_gestern.TabIndex = 46
        Me.chkKundenverwaltung_kunde_ab_gestern.Text = "&Kunden ab Gestern anzeigen"
        Me.ballonITips.SetToolTip(Me.chkKundenverwaltung_kunde_ab_gestern, "Zeigt nur heutige Ereigenisse an")
        Me.chkKundenverwaltung_kunde_ab_gestern.UseVisualStyleBackColor = True
        '
        'chkShopLastLogin
        '
        Me.chkShopLastLogin.AutoSize = True
        Me.chkShopLastLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShopLastLogin.Location = New System.Drawing.Point(348, 56)
        Me.chkShopLastLogin.Name = "chkShopLastLogin"
        Me.chkShopLastLogin.Size = New System.Drawing.Size(126, 17)
        Me.chkShopLastLogin.TabIndex = 45
        Me.chkShopLastLogin.Text = "&EiSo Shop Login"
        Me.ballonITips.SetToolTip(Me.chkShopLastLogin, "Shop Login Daten")
        Me.chkShopLastLogin.UseVisualStyleBackColor = True
        '
        'chkKundenZeitfilter
        '
        Me.chkKundenZeitfilter.AutoSize = True
        Me.chkKundenZeitfilter.BackColor = System.Drawing.Color.Gainsboro
        Me.chkKundenZeitfilter.Checked = True
        Me.chkKundenZeitfilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKundenZeitfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKundenZeitfilter.Location = New System.Drawing.Point(819, 56)
        Me.chkKundenZeitfilter.Name = "chkKundenZeitfilter"
        Me.chkKundenZeitfilter.Size = New System.Drawing.Size(97, 17)
        Me.chkKundenZeitfilter.TabIndex = 8
        Me.chkKundenZeitfilter.Text = "Datumfilter"
        Me.ballonITips.SetToolTip(Me.chkKundenZeitfilter, "Zeitfilter ")
        Me.chkKundenZeitfilter.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Silver
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label28.Location = New System.Drawing.Point(345, 12)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(643, 18)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Filter"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ballonITips.SetToolTip(Me.Label28, "Ändern Sie Ihre Plattform auswahl")
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Silver
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(239, 14)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Verkaufsplattform"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ballonITips.SetToolTip(Me.Label24, "Ändern Sie Ihre Plattform auswahl")
        '
        'cmbPlattform_kunden
        '
        Me.cmbPlattform_kunden.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbPlattform_kunden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlattform_kunden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlattform_kunden.FormattingEnabled = True
        Me.cmbPlattform_kunden.Location = New System.Drawing.Point(12, 55)
        Me.cmbPlattform_kunden.Name = "cmbPlattform_kunden"
        Me.cmbPlattform_kunden.Size = New System.Drawing.Size(239, 21)
        Me.cmbPlattform_kunden.TabIndex = 42
        '
        'chkKundenHeute
        '
        Me.chkKundenHeute.AutoSize = True
        Me.chkKundenHeute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKundenHeute.Location = New System.Drawing.Point(348, 29)
        Me.chkKundenHeute.Name = "chkKundenHeute"
        Me.chkKundenHeute.Size = New System.Drawing.Size(231, 17)
        Me.chkKundenHeute.TabIndex = 1
        Me.chkKundenHeute.Text = "&Nur Kunden von Heute anzeigen"
        Me.ballonITips.SetToolTip(Me.chkKundenHeute, "Zeigt nur heutige Ereigenisse an")
        Me.chkKundenHeute.UseVisualStyleBackColor = True
        '
        'lblKunden_Main_label
        '
        Me.lblKunden_Main_label.AutoSize = True
        Me.lblKunden_Main_label.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKunden_Main_label.Location = New System.Drawing.Point(10, 9)
        Me.lblKunden_Main_label.Name = "lblKunden_Main_label"
        Me.lblKunden_Main_label.Size = New System.Drawing.Size(286, 23)
        Me.lblKunden_Main_label.TabIndex = 37
        Me.lblKunden_Main_label.Text = "EiSo - Kundenverwaltung"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(259, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Bis - Adressupdate"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(2, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1148, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Von - Adressupdate"
        '
        'KundenBis
        '
        Me.KundenBis.Location = New System.Drawing.Point(259, 96)
        Me.KundenBis.Name = "KundenBis"
        Me.KundenBis.Size = New System.Drawing.Size(244, 21)
        Me.KundenBis.TabIndex = 7
        '
        'KundenVon
        '
        Me.KundenVon.Location = New System.Drawing.Point(4, 96)
        Me.KundenVon.Name = "KundenVon"
        Me.KundenVon.Size = New System.Drawing.Size(244, 21)
        Me.KundenVon.TabIndex = 6
        '
        'pgrKundenverlauf
        '
        Me.pgrKundenverlauf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgrKundenverlauf.Location = New System.Drawing.Point(8, 126)
        Me.pgrKundenverlauf.Name = "pgrKundenverlauf"
        Me.pgrKundenverlauf.Size = New System.Drawing.Size(1133, 14)
        Me.pgrKundenverlauf.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgrKundenverlauf.TabIndex = 36
        Me.pgrKundenverlauf.Visible = False
        '
        'chkKundenFullReport
        '
        Me.chkKundenFullReport.AutoSize = True
        Me.chkKundenFullReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKundenFullReport.Location = New System.Drawing.Point(521, 56)
        Me.chkKundenFullReport.Name = "chkKundenFullReport"
        Me.chkKundenFullReport.Size = New System.Drawing.Size(108, 17)
        Me.chkKundenFullReport.TabIndex = 0
        Me.chkKundenFullReport.Text = "Detailansicht"
        Me.ballonITips.SetToolTip(Me.chkKundenFullReport, "Zeigt zu den Kundendaten Anzahl Bestellung + Bestellsumme / Durchschnittsverkauf")
        Me.chkKundenFullReport.UseVisualStyleBackColor = True
        '
        'btnAdressLabels
        '
        Me.btnAdressLabels.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnAdressLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdressLabels.Image = CType(resources.GetObject("btnAdressLabels.Image"), System.Drawing.Image)
        Me.btnAdressLabels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdressLabels.Location = New System.Drawing.Point(726, 95)
        Me.btnAdressLabels.Name = "btnAdressLabels"
        Me.btnAdressLabels.Size = New System.Drawing.Size(262, 23)
        Me.btnAdressLabels.TabIndex = 10
        Me.btnAdressLabels.Text = "Adressetikettendruck"
        Me.ballonITips.SetToolTip(Me.btnAdressLabels, "Öffnet ein neues Fenster mit einer Vorschau auf die Adressen die gedruckt werden " &
        "können.")
        Me.btnAdressLabels.UseVisualStyleBackColor = False
        '
        'btnKundenHolen
        '
        Me.btnKundenHolen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnKundenHolen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKundenHolen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKundenHolen.ImageIndex = 19
        Me.btnKundenHolen.ImageList = Me.imgAuktionsmanagement
        Me.btnKundenHolen.Location = New System.Drawing.Point(512, 95)
        Me.btnKundenHolen.Name = "btnKundenHolen"
        Me.btnKundenHolen.Size = New System.Drawing.Size(208, 23)
        Me.btnKundenHolen.TabIndex = 9
        Me.btnKundenHolen.Text = "Kundendaten ab&rufen"
        Me.ballonITips.SetToolTip(Me.btnKundenHolen, "Ruft die Daten aus der EiSo Kundendaten ab.")
        Me.btnKundenHolen.UseVisualStyleBackColor = False
        '
        'imgAuktionsmanagement
        '
        Me.imgAuktionsmanagement.ImageStream = CType(resources.GetObject("imgAuktionsmanagement.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAuktionsmanagement.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAuktionsmanagement.Images.SetKeyName(0, "world_add.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(1, "email3.gif")
        Me.imgAuktionsmanagement.Images.SetKeyName(2, "search-16.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(3, "34.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(4, "35.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(5, "03.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(6, "money_add.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(7, "vcard.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(8, "action_check.ico")
        Me.imgAuktionsmanagement.Images.SetKeyName(9, "time.ico")
        Me.imgAuktionsmanagement.Images.SetKeyName(10, "user.ico")
        Me.imgAuktionsmanagement.Images.SetKeyName(11, "ebay.gif")
        Me.imgAuktionsmanagement.Images.SetKeyName(12, "application_home.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(13, "shopingcarback_16_hot.ico")
        Me.imgAuktionsmanagement.Images.SetKeyName(14, "paypal.ico")
        Me.imgAuktionsmanagement.Images.SetKeyName(15, "Sign - Dollar.ico")
        Me.imgAuktionsmanagement.Images.SetKeyName(16, "user.ico")
        Me.imgAuktionsmanagement.Images.SetKeyName(17, "cart_go.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(18, "cart_edit.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(19, "group_go.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(20, "accept.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(21, "printer.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(22, "report_edit.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(23, "script_add.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(24, "base.gif")
        Me.imgAuktionsmanagement.Images.SetKeyName(25, "magento_thumb.png")
        Me.imgAuktionsmanagement.Images.SetKeyName(26, "ebay.gif")
        '
        'lvwKunden
        '
        Me.lvwKunden.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwKunden.AllowColumnReorder = True
        Me.lvwKunden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwKunden.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwKunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwKunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kd_nachname, Me.kd_eBayName, Me.kd_eMail, Me.kd_strasse, Me.kd_PLZ, Me.kd_Ort, Me.kd_Land, Me.kd_käufe, Me.kd_Artikel, Me.kd_newsletter, Me.kd_last, Me.kd_plattform, Me.kd_sprachenliste, Me.kd_muttersprache, Me.kd_id, Me.order_id})
        Me.lvwKunden.ContextMenuStrip = Me.cmsKundenListview
        Me.lvwKunden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwKunden.FullRowSelect = True
        Me.lvwKunden.GridLines = True
        Me.lvwKunden.HideSelection = False
        Me.lvwKunden.Location = New System.Drawing.Point(6, 146)
        Me.lvwKunden.MultiSelect = False
        Me.lvwKunden.Name = "lvwKunden"
        Me.lvwKunden.ShowItemToolTips = True
        Me.lvwKunden.Size = New System.Drawing.Size(1138, 422)
        Me.lvwKunden.TabIndex = 0
        Me.lvwKunden.UseCompatibleStateImageBehavior = False
        Me.lvwKunden.View = System.Windows.Forms.View.Details
        '
        'kd_nachname
        '
        Me.kd_nachname.Text = "Name"
        Me.kd_nachname.Width = 116
        '
        'kd_eBayName
        '
        Me.kd_eBayName.Text = "Mitgliedsname"
        Me.kd_eBayName.Width = 150
        '
        'kd_eMail
        '
        Me.kd_eMail.Text = "Email"
        Me.kd_eMail.Width = 104
        '
        'kd_strasse
        '
        Me.kd_strasse.Text = "Strasse"
        Me.kd_strasse.Width = 100
        '
        'kd_PLZ
        '
        Me.kd_PLZ.Text = "Ort"
        Me.kd_PLZ.Width = 74
        '
        'kd_Ort
        '
        Me.kd_Ort.Text = "PLZ"
        Me.kd_Ort.Width = 103
        '
        'kd_Land
        '
        Me.kd_Land.Text = "Land"
        Me.kd_Land.Width = 172
        '
        'kd_käufe
        '
        Me.kd_käufe.Text = "Käufe"
        Me.kd_käufe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.kd_käufe.Width = 96
        '
        'kd_Artikel
        '
        Me.kd_Artikel.Text = "Artikel"
        Me.kd_Artikel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'kd_newsletter
        '
        Me.kd_newsletter.Text = "Newsletter"
        '
        'kd_last
        '
        Me.kd_last.Text = "Änderung"
        Me.kd_last.Width = 73
        '
        'kd_plattform
        '
        Me.kd_plattform.Text = "Plattform"
        Me.kd_plattform.Width = 72
        '
        'kd_sprachenliste
        '
        Me.kd_sprachenliste.Text = "Sprachenliste"
        '
        'kd_muttersprache
        '
        Me.kd_muttersprache.Text = "Muttersprache"
        '
        'kd_id
        '
        Me.kd_id.Text = "ID"
        '
        'cmsKundenListview
        '
        Me.cmsKundenListview.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YABEAnsichtAktuallisierenToolStripMenuItem, Me.KopiereAlsAdressblockToolStripMenuItem, Me.ToolStripSeparator78, Me.BestellübersichtToolStripMenuItem, Me.NewsletterDeaktivierenToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripSeparator27, Me.KundenNeuToolStripMenuItem, Me.KundenEditierenToolStripMenuItem, Me.ToolStripSeparator55, Me.KundeLöschenToolStripMenuItem, Me.ToolStripSeparator46, Me.SucheKundenbestellungenToolStripMenuItem, Me.SucheKundenBewertungenToolStripMenuItem, Me.ToolStripSeparator51, Me.EBayKundenInformationenToolStripMenuItem, Me.ToolStripSeparator2, Me.ZuordnungArtikelKundeToolStripMenuItem1, Me.EmailExternesProgrammToolStripMenuItem1, Me.ToolStripSeparator25, Me.KopierenEmailToolStripMenuItem1, Me.KopierenNameToolStripMenuItem, Me.KopierenArtikelIDToolStripMenuItem, Me.ToolStripSeparator11, Me.ExportierenToolStripMenuItem, Me.ToolStripSeparator77, Me.AusListeEntfernenToolStripMenuItem})
        Me.cmsKundenListview.Name = "cmsKundenListview"
        Me.cmsKundenListview.Size = New System.Drawing.Size(275, 454)
        '
        'YABEAnsichtAktuallisierenToolStripMenuItem
        '
        Me.YABEAnsichtAktuallisierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.YABEAnsichtAktuallisierenToolStripMenuItem.Name = "YABEAnsichtAktuallisierenToolStripMenuItem"
        Me.YABEAnsichtAktuallisierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.YABEAnsichtAktuallisierenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.YABEAnsichtAktuallisierenToolStripMenuItem.Text = "Ansicht -> aktuallisieren"
        '
        'KopiereAlsAdressblockToolStripMenuItem
        '
        Me.KopiereAlsAdressblockToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.speichern
        Me.KopiereAlsAdressblockToolStripMenuItem.Name = "KopiereAlsAdressblockToolStripMenuItem"
        Me.KopiereAlsAdressblockToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopiereAlsAdressblockToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.KopiereAlsAdressblockToolStripMenuItem.Text = "Kopiere als Adressblock"
        '
        'ToolStripSeparator78
        '
        Me.ToolStripSeparator78.Name = "ToolStripSeparator78"
        Me.ToolStripSeparator78.Size = New System.Drawing.Size(271, 6)
        '
        'BestellübersichtToolStripMenuItem
        '
        Me.BestellübersichtToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.BestellübersichtToolStripMenuItem.Name = "BestellübersichtToolStripMenuItem"
        Me.BestellübersichtToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.BestellübersichtToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.BestellübersichtToolStripMenuItem.Text = " &Bestellübersicht..."
        Me.BestellübersichtToolStripMenuItem.ToolTipText = "Zeigt vom Kunden vorherige Bestellunge an "
        '
        'NewsletterDeaktivierenToolStripMenuItem
        '
        Me.NewsletterDeaktivierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.disconnect
        Me.NewsletterDeaktivierenToolStripMenuItem.Name = "NewsletterDeaktivierenToolStripMenuItem"
        Me.NewsletterDeaktivierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewsletterDeaktivierenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.NewsletterDeaktivierenToolStripMenuItem.Text = "&Newsletter an/abmelden"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonensucheToolStripMenuItem1, Me.TelefonummernSucheToolStripMenuItem, Me.GoogleMapsToolStripMenuItem1})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Image = Global.YabE.My.Resources.Resources.Desktop21
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(274, 22)
        Me.ToolStripMenuItem2.Text = "Externe Web Kundendaten"
        Me.ToolStripMenuItem2.ToolTipText = "Interner YABE Webbrowser"
        '
        'PersonensucheToolStripMenuItem1
        '
        Me.PersonensucheToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonensucheToolStripMenuItem1.Name = "PersonensucheToolStripMenuItem1"
        Me.PersonensucheToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PersonensucheToolStripMenuItem1.Text = "Personensuche"
        '
        'TelefonummernSucheToolStripMenuItem
        '
        Me.TelefonummernSucheToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonummernSucheToolStripMenuItem.Name = "TelefonummernSucheToolStripMenuItem"
        Me.TelefonummernSucheToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TelefonummernSucheToolStripMenuItem.Text = "Telefonummern Suche"
        '
        'GoogleMapsToolStripMenuItem1
        '
        Me.GoogleMapsToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoogleMapsToolStripMenuItem1.Name = "GoogleMapsToolStripMenuItem1"
        Me.GoogleMapsToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GoogleMapsToolStripMenuItem1.Text = "Google -> Maps"
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(271, 6)
        '
        'KundenNeuToolStripMenuItem
        '
        Me.KundenNeuToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.KundenNeuToolStripMenuItem.Name = "KundenNeuToolStripMenuItem"
        Me.KundenNeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.KundenNeuToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.KundenNeuToolStripMenuItem.Text = "Kunden -> &neu "
        '
        'KundenEditierenToolStripMenuItem
        '
        Me.KundenEditierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_edit
        Me.KundenEditierenToolStripMenuItem.Name = "KundenEditierenToolStripMenuItem"
        Me.KundenEditierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.KundenEditierenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.KundenEditierenToolStripMenuItem.Text = "Kunden -> &editieren..."
        '
        'ToolStripSeparator55
        '
        Me.ToolStripSeparator55.Name = "ToolStripSeparator55"
        Me.ToolStripSeparator55.Size = New System.Drawing.Size(271, 6)
        '
        'KundeLöschenToolStripMenuItem
        '
        Me.KundeLöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.KundeLöschenToolStripMenuItem.Name = "KundeLöschenToolStripMenuItem"
        Me.KundeLöschenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.KundeLöschenToolStripMenuItem.Text = "Kunden -> &löschen"
        '
        'ToolStripSeparator46
        '
        Me.ToolStripSeparator46.Name = "ToolStripSeparator46"
        Me.ToolStripSeparator46.Size = New System.Drawing.Size(271, 6)
        '
        'SucheKundenbestellungenToolStripMenuItem
        '
        Me.SucheKundenbestellungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheKundenbestellungenToolStripMenuItem.Name = "SucheKundenbestellungenToolStripMenuItem"
        Me.SucheKundenbestellungenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.SucheKundenbestellungenToolStripMenuItem.Text = "Suche Kundenbestellungen"
        '
        'SucheKundenBewertungenToolStripMenuItem
        '
        Me.SucheKundenBewertungenToolStripMenuItem.Enabled = False
        Me.SucheKundenBewertungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheKundenBewertungenToolStripMenuItem.Name = "SucheKundenBewertungenToolStripMenuItem"
        Me.SucheKundenBewertungenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.SucheKundenBewertungenToolStripMenuItem.Text = "Suche Bewertungen"
        '
        'ToolStripSeparator51
        '
        Me.ToolStripSeparator51.Name = "ToolStripSeparator51"
        Me.ToolStripSeparator51.Size = New System.Drawing.Size(271, 6)
        '
        'EBayKundenInformationenToolStripMenuItem
        '
        Me.EBayKundenInformationenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_comment
        Me.EBayKundenInformationenToolStripMenuItem.Name = "EBayKundenInformationenToolStripMenuItem"
        Me.EBayKundenInformationenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.EBayKundenInformationenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.EBayKundenInformationenToolStripMenuItem.Text = "eBay ->  &Kundenübersicht..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(271, 6)
        '
        'ZuordnungArtikelKundeToolStripMenuItem1
        '
        Me.ZuordnungArtikelKundeToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._24
        Me.ZuordnungArtikelKundeToolStripMenuItem1.Name = "ZuordnungArtikelKundeToolStripMenuItem1"
        Me.ZuordnungArtikelKundeToolStripMenuItem1.Size = New System.Drawing.Size(274, 22)
        Me.ZuordnungArtikelKundeToolStripMenuItem1.Text = "SYNC -> Artikel => Kunde"
        '
        'EmailExternesProgrammToolStripMenuItem1
        '
        Me.EmailExternesProgrammToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.letter_open
        Me.EmailExternesProgrammToolStripMenuItem1.Name = "EmailExternesProgrammToolStripMenuItem1"
        Me.EmailExternesProgrammToolStripMenuItem1.Size = New System.Drawing.Size(274, 22)
        Me.EmailExternesProgrammToolStripMenuItem1.Text = "Email -> Externes Programm"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(271, 6)
        '
        'KopierenEmailToolStripMenuItem1
        '
        Me.KopierenEmailToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenEmailToolStripMenuItem1.Name = "KopierenEmailToolStripMenuItem1"
        Me.KopierenEmailToolStripMenuItem1.Size = New System.Drawing.Size(274, 22)
        Me.KopierenEmailToolStripMenuItem1.Text = "&Kopieren -> Email"
        '
        'KopierenNameToolStripMenuItem
        '
        Me.KopierenNameToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenNameToolStripMenuItem.Name = "KopierenNameToolStripMenuItem"
        Me.KopierenNameToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.KopierenNameToolStripMenuItem.Text = "&Kopieren -> Name"
        '
        'KopierenArtikelIDToolStripMenuItem
        '
        Me.KopierenArtikelIDToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenArtikelIDToolStripMenuItem.Name = "KopierenArtikelIDToolStripMenuItem"
        Me.KopierenArtikelIDToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.KopierenArtikelIDToolStripMenuItem.Text = "&Kopieren -> Artikel ID"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(271, 6)
        '
        'ExportierenToolStripMenuItem
        '
        Me.ExportierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportierenToolStripMenuItem.Name = "ExportierenToolStripMenuItem"
        Me.ExportierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportierenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.ExportierenToolStripMenuItem.Text = "EiSo -> &Exportieren der Ansicht"
        Me.ExportierenToolStripMenuItem.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'ToolStripSeparator77
        '
        Me.ToolStripSeparator77.Name = "ToolStripSeparator77"
        Me.ToolStripSeparator77.Size = New System.Drawing.Size(271, 6)
        '
        'AusListeEntfernenToolStripMenuItem
        '
        Me.AusListeEntfernenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.delete
        Me.AusListeEntfernenToolStripMenuItem.Name = "AusListeEntfernenToolStripMenuItem"
        Me.AusListeEntfernenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.AusListeEntfernenToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.AusListeEntfernenToolStripMenuItem.Text = "Aus Liste entfernen"
        '
        'menue_bestellverlauf
        '
        Me.menue_bestellverlauf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menue_bestellverlauf.Controls.Add(Me.chkEiSoArtikelverwaltung_kunden_details)
        Me.menue_bestellverlauf.Controls.Add(Me.btnBestellverwaltung_rechnung_erstellen)
        Me.menue_bestellverlauf.Controls.Add(Me.tcBestellungen_visual)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungen_Alle)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungen_Komplett)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungenVerkauft)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungen_Storniert)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungen_KeineBewertung)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungen_Versand)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungen_bezahlt)
        Me.menue_bestellverlauf.Controls.Add(Me.chkBestellungen_verkauft)
        Me.menue_bestellverlauf.Controls.Add(Me.Label17)
        Me.menue_bestellverlauf.Controls.Add(Me.cmbPlattform_bestellungen)
        Me.menue_bestellverlauf.Controls.Add(Me.Label11)
        Me.menue_bestellverlauf.Controls.Add(Me.lblLive_von)
        Me.menue_bestellverlauf.Controls.Add(Me.lblLive_bis)
        Me.menue_bestellverlauf.Controls.Add(Me.eBayHistoryBis)
        Me.menue_bestellverlauf.Controls.Add(Me.eBayHistoryVon)
        Me.menue_bestellverlauf.Controls.Add(Me.lblBestellungen_main)
        Me.menue_bestellverlauf.Controls.Add(Me.Label3)
        Me.menue_bestellverlauf.Controls.Add(Me.chkHistoryZeitfilter)
        Me.menue_bestellverlauf.Controls.Add(Me.btnBestellungAdd)
        Me.menue_bestellverlauf.Controls.Add(Me.btneBayAdressenHolen)
        Me.menue_bestellverlauf.Controls.Add(Me.btnBestellungen_abrufen)
        Me.menue_bestellverlauf.ImageIndex = 9
        Me.menue_bestellverlauf.Location = New System.Drawing.Point(4, 63)
        Me.menue_bestellverlauf.Name = "menue_bestellverlauf"
        Me.menue_bestellverlauf.Padding = New System.Windows.Forms.Padding(3)
        Me.menue_bestellverlauf.Size = New System.Drawing.Size(1150, 571)
        Me.menue_bestellverlauf.TabIndex = 0
        Me.menue_bestellverlauf.Text = "Bestellverwaltung"
        '
        'btnBestellverwaltung_rechnung_erstellen
        '
        Me.btnBestellverwaltung_rechnung_erstellen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBestellverwaltung_rechnung_erstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestellverwaltung_rechnung_erstellen.Image = Global.YabE.My.Resources.Resources.money_add
        Me.btnBestellverwaltung_rechnung_erstellen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestellverwaltung_rechnung_erstellen.Location = New System.Drawing.Point(733, 96)
        Me.btnBestellverwaltung_rechnung_erstellen.Name = "btnBestellverwaltung_rechnung_erstellen"
        Me.btnBestellverwaltung_rechnung_erstellen.Size = New System.Drawing.Size(222, 23)
        Me.btnBestellverwaltung_rechnung_erstellen.TabIndex = 52
        Me.btnBestellverwaltung_rechnung_erstellen.Text = "Rechnung erstellen..."
        Me.btnBestellverwaltung_rechnung_erstellen.UseVisualStyleBackColor = False
        '
        'tcBestellungen_visual
        '
        Me.tcBestellungen_visual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcBestellungen_visual.Controls.Add(Me.listenansicht)
        Me.tcBestellungen_visual.Controls.Add(Me.bestelliste)
        Me.tcBestellungen_visual.Location = New System.Drawing.Point(5, 134)
        Me.tcBestellungen_visual.Name = "tcBestellungen_visual"
        Me.tcBestellungen_visual.SelectedIndex = 0
        Me.tcBestellungen_visual.Size = New System.Drawing.Size(1142, 524)
        Me.tcBestellungen_visual.TabIndex = 51
        '
        'listenansicht
        '
        Me.listenansicht.Controls.Add(Me.lvwBestellverwaltung_nach_artikel)
        Me.listenansicht.Controls.Add(Me.pgreBayVerlaufUpdate)
        Me.listenansicht.Location = New System.Drawing.Point(4, 22)
        Me.listenansicht.Name = "listenansicht"
        Me.listenansicht.Padding = New System.Windows.Forms.Padding(3)
        Me.listenansicht.Size = New System.Drawing.Size(1134, 498)
        Me.listenansicht.TabIndex = 0
        Me.listenansicht.Text = "Bestellung nach Artikel"
        Me.listenansicht.UseVisualStyleBackColor = True
        '
        'lvwBestellverwaltung_nach_artikel
        '
        Me.lvwBestellverwaltung_nach_artikel.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBestellverwaltung_nach_artikel.AllowColumnReorder = True
        Me.lvwBestellverwaltung_nach_artikel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBestellverwaltung_nach_artikel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwBestellverwaltung_nach_artikel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBestellverwaltung_nach_artikel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.eBayHistory_live, Me.eBayHistory_name, Me.eBayHistory_Account, Me.eBayHistory_ort, Me.eBayHistory_title, Me.eBayHistory_preis, Me.eBayHistory_versandkosten, Me.eBayHistory_status, Me.eBayHistory_bewertet, Me.eBayHistory_eMail, Me.ebayHistory_verkaufsende, Me.eBayHistoryGebote, Me.ebayHistory_Gebühr, Me.eBayHistory_plattform, Me.eBayHistory_bild, Me.ebayHistory_YABEID, Me.ebayHistory_Paypal, Me.ebayHistoryLand, Me.ebayHistoryDelcampeID, Me.ebayHistory_muttersprache, Me.ebayHistory_straße, Me.ebayHistory_sprachliste, Me.eBayHistoryBild, Me.eBayHistoryMenge, Me.eBayEiSoOrderID})
        Me.lvwBestellverwaltung_nach_artikel.ContextMenuStrip = Me.cmsEiSoBestellungen
        Me.lvwBestellverwaltung_nach_artikel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBestellverwaltung_nach_artikel.FullRowSelect = True
        Me.lvwBestellverwaltung_nach_artikel.GridLines = True
        Me.lvwBestellverwaltung_nach_artikel.HideSelection = False
        Me.lvwBestellverwaltung_nach_artikel.LargeImageList = Me.bilder_history
        Me.lvwBestellverwaltung_nach_artikel.Location = New System.Drawing.Point(0, 54)
        Me.lvwBestellverwaltung_nach_artikel.Name = "lvwBestellverwaltung_nach_artikel"
        Me.lvwBestellverwaltung_nach_artikel.ShowItemToolTips = True
        Me.lvwBestellverwaltung_nach_artikel.Size = New System.Drawing.Size(1123, 365)
        Me.lvwBestellverwaltung_nach_artikel.SmallImageList = Me.bilder_history
        Me.lvwBestellverwaltung_nach_artikel.TabIndex = 12
        Me.lvwBestellverwaltung_nach_artikel.UseCompatibleStateImageBehavior = False
        Me.lvwBestellverwaltung_nach_artikel.View = System.Windows.Forms.View.Details
        Me.lvwBestellverwaltung_nach_artikel.VirtualListSize = 200
        '
        'eBayHistory_live
        '
        Me.eBayHistory_live.Text = "ID"
        Me.eBayHistory_live.Width = 0
        '
        'eBayHistory_name
        '
        Me.eBayHistory_name.Text = "Name"
        Me.eBayHistory_name.Width = 169
        '
        'eBayHistory_Account
        '
        Me.eBayHistory_Account.Text = "Benutzername"
        Me.eBayHistory_Account.Width = 105
        '
        'eBayHistory_ort
        '
        Me.eBayHistory_ort.Text = "Ort"
        Me.eBayHistory_ort.Width = 117
        '
        'eBayHistory_title
        '
        Me.eBayHistory_title.Text = "Beschreibung"
        Me.eBayHistory_title.Width = 367
        '
        'eBayHistory_preis
        '
        Me.eBayHistory_preis.Text = "Preis"
        Me.eBayHistory_preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.eBayHistory_preis.Width = 79
        '
        'eBayHistory_versandkosten
        '
        Me.eBayHistory_versandkosten.Text = "Versand"
        Me.eBayHistory_versandkosten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.eBayHistory_versandkosten.Width = 74
        '
        'eBayHistory_status
        '
        Me.eBayHistory_status.Text = "Bestellstatus"
        Me.eBayHistory_status.Width = 101
        '
        'eBayHistory_bewertet
        '
        Me.eBayHistory_bewertet.Text = "Bewertung"
        Me.eBayHistory_bewertet.Width = 76
        '
        'eBayHistory_eMail
        '
        Me.eBayHistory_eMail.Text = "eMail"
        '
        'ebayHistory_verkaufsende
        '
        Me.ebayHistory_verkaufsende.Text = "Verkaufsende"
        Me.ebayHistory_verkaufsende.Width = 96
        '
        'eBayHistoryGebote
        '
        Me.eBayHistoryGebote.Text = "Bids"
        Me.eBayHistoryGebote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ebayHistory_Gebühr
        '
        Me.ebayHistory_Gebühr.Text = "Gebühr"
        Me.ebayHistory_Gebühr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'eBayHistory_plattform
        '
        Me.eBayHistory_plattform.Text = "Plattform"
        Me.eBayHistory_plattform.Width = 70
        '
        'eBayHistory_bild
        '
        Me.eBayHistory_bild.Text = "Bild"
        '
        'ebayHistory_YABEID
        '
        Me.ebayHistory_YABEID.Text = "YABE ID"
        Me.ebayHistory_YABEID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ebayHistory_YABEID.Width = 0
        '
        'ebayHistory_Paypal
        '
        Me.ebayHistory_Paypal.Text = "Paypalsumme"
        Me.ebayHistory_Paypal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ebayHistory_Paypal.Width = 110
        '
        'ebayHistoryLand
        '
        Me.ebayHistoryLand.Text = "Land"
        Me.ebayHistoryLand.Width = 170
        '
        'ebayHistoryDelcampeID
        '
        Me.ebayHistoryDelcampeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ebayHistory_muttersprache
        '
        Me.ebayHistory_muttersprache.Text = "Muttersprache"
        '
        'ebayHistory_straße
        '
        Me.ebayHistory_straße.Text = "Straße"
        '
        'ebayHistory_sprachliste
        '
        Me.ebayHistory_sprachliste.Text = "Sprachliste"
        Me.ebayHistory_sprachliste.Width = 0
        '
        'eBayHistoryBild
        '
        Me.eBayHistoryBild.Text = "Bild"
        '
        'eBayHistoryMenge
        '
        Me.eBayHistoryMenge.Text = "Menge"
        '
        'eBayEiSoOrderID
        '
        Me.eBayEiSoOrderID.Text = "EiSoOrderID"
        '
        'cmsEiSoBestellungen
        '
        Me.cmsEiSoBestellungen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsichtAktuallisierenToolStripMenuItem1, Me.YABERechnungsdruckToolStripMenuItem, Me.BestellungsstatusToolStripMenuItem, Me.YABEArtikelübernahmeToolStripMenuItem, Me.CockitSetztenToolStripMenuItem, Me.ToolStripSeparator32, Me.YABEBestellverlaufProKundenToolStripMenuItem, Me.KundenverlaufToolStripMenuItem, Me.ShopToolStripMenuItem, Me.MagentoToolStripMenuItem1, Me.ShopsteToolStripMenuItem, Me.DToolStripMenuItem, Me.ToolStripSeparator38, Me.YABEArtikelansichtToolStripMenuItem, Me.ToolStripSeparator37, Me.YABEAnsichtToolStripMenuItem, Me.ToolStripSeparator29, Me.ZuordnungArtikelKundeToolStripMenuItem, Me.DelcampeBestellsStatusAktuallisierenToolStripMenuItem, Me.ToolStripSeparator12, Me.SucheArtikelToolStripMenuItem, Me.SucheKundeToolStripMenuItem, Me.SucheBewertungenToolStripMenuItem, Me.SucheBestellungenToolStripMenuItem, Me.ToolStripSeparator4, Me.HöchstbietenderBewertungsprofilToolStripMenuItem, Me.EBayAuktionArtikeldetialsToolStripMenuItem, Me.BietverlaufToolStripMenuItem1, Me.ToolStripSeparator10, Me.CopyEBayIDToolStripMenuItem1, Me.KopierenEmailToolStripMenuItem, Me.CopyEBayMitgliedsnameToolStripMenuItem, Me.ToolStripSeparator9, Me.LöschenToolStripMenuItem, Me.ToolStripSeparator8, Me.EBayÖffnenToolStripMenuItem, Me.ExportierenToolStripMenuItem1, Me.EBayStatusToolStripMenuItem})
        Me.cmsEiSoBestellungen.Name = "cmseBayHistory"
        Me.cmsEiSoBestellungen.Size = New System.Drawing.Size(311, 696)
        '
        'AnsichtAktuallisierenToolStripMenuItem1
        '
        Me.AnsichtAktuallisierenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._24
        Me.AnsichtAktuallisierenToolStripMenuItem1.Name = "AnsichtAktuallisierenToolStripMenuItem1"
        Me.AnsichtAktuallisierenToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AnsichtAktuallisierenToolStripMenuItem1.Size = New System.Drawing.Size(310, 22)
        Me.AnsichtAktuallisierenToolStripMenuItem1.Text = "Ansicht -> aktuallisieren"
        '
        'YABERechnungsdruckToolStripMenuItem
        '
        Me.YABERechnungsdruckToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YABERechnungsdruckToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.money_add
        Me.YABERechnungsdruckToolStripMenuItem.Name = "YABERechnungsdruckToolStripMenuItem"
        Me.YABERechnungsdruckToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.YABERechnungsdruckToolStripMenuItem.Text = "Rechnungsdruck..."
        Me.YABERechnungsdruckToolStripMenuItem.ToolTipText = "Ermöglicht einen Rechnungsdruck..."
        '
        'BestellungsstatusToolStripMenuItem
        '
        Me.BestellungsstatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BewertetToolStripMenuItem, Me.BezahltToolStripMenuItem, Me.VerschicktToolStripMenuItem, Me.CompleteToolStripMenuItem, Me.ToolStripSeparator28, Me.StorniertToolStripMenuItem, Me.ToolStripSeparator17, Me.ErinnerungSendenToolStripMenuItem})
        Me.BestellungsstatusToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.time_go
        Me.BestellungsstatusToolStripMenuItem.Name = "BestellungsstatusToolStripMenuItem"
        Me.BestellungsstatusToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.BestellungsstatusToolStripMenuItem.Text = "Artikel Bestellungsstatus"
        '
        'BewertetToolStripMenuItem
        '
        Me.BewertetToolStripMenuItem.Name = "BewertetToolStripMenuItem"
        Me.BewertetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.BewertetToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.BewertetToolStripMenuItem.Text = "&Bestellt"
        '
        'BezahltToolStripMenuItem
        '
        Me.BezahltToolStripMenuItem.Name = "BezahltToolStripMenuItem"
        Me.BezahltToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BezahltToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.BezahltToolStripMenuItem.Text = "&Bezahlt"
        '
        'VerschicktToolStripMenuItem
        '
        Me.VerschicktToolStripMenuItem.Name = "VerschicktToolStripMenuItem"
        Me.VerschicktToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.VerschicktToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.VerschicktToolStripMenuItem.Text = "&Verschickt"
        '
        'CompleteToolStripMenuItem
        '
        Me.CompleteToolStripMenuItem.Name = "CompleteToolStripMenuItem"
        Me.CompleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.CompleteToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CompleteToolStripMenuItem.Text = "&Komplett"
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(219, 6)
        '
        'StorniertToolStripMenuItem
        '
        Me.StorniertToolStripMenuItem.Name = "StorniertToolStripMenuItem"
        Me.StorniertToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.StorniertToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.StorniertToolStripMenuItem.Text = "&Storniert"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(219, 6)
        '
        'ErinnerungSendenToolStripMenuItem
        '
        Me.ErinnerungSendenToolStripMenuItem.Enabled = False
        Me.ErinnerungSendenToolStripMenuItem.Name = "ErinnerungSendenToolStripMenuItem"
        Me.ErinnerungSendenToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ErinnerungSendenToolStripMenuItem.Text = "Zahlungserinnerung senden"
        '
        'YABEArtikelübernahmeToolStripMenuItem
        '
        Me.YABEArtikelübernahmeToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_edit2
        Me.YABEArtikelübernahmeToolStripMenuItem.Name = "YABEArtikelübernahmeToolStripMenuItem"
        Me.YABEArtikelübernahmeToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.YABEArtikelübernahmeToolStripMenuItem.Text = "&Artikelübernahme..."
        '
        'CockitSetztenToolStripMenuItem
        '
        Me.CockitSetztenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.CockitSetztenToolStripMenuItem.Name = "CockitSetztenToolStripMenuItem"
        Me.CockitSetztenToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.CockitSetztenToolStripMenuItem.Text = "Artikel -> Cockit (zum erneuten Verschicken)"
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(307, 6)
        '
        'YABEBestellverlaufProKundenToolStripMenuItem
        '
        Me.YABEBestellverlaufProKundenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._33
        Me.YABEBestellverlaufProKundenToolStripMenuItem.Name = "YABEBestellverlaufProKundenToolStripMenuItem"
        Me.YABEBestellverlaufProKundenToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.YABEBestellverlaufProKundenToolStripMenuItem.Text = "Bestellverlauf pro Kunde..."
        '
        'KundenverlaufToolStripMenuItem
        '
        Me.KundenverlaufToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KundenverlaufToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.KundenverlaufToolStripMenuItem.Name = "KundenverlaufToolStripMenuItem"
        Me.KundenverlaufToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.KundenverlaufToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.KundenverlaufToolStripMenuItem.Text = "&Bestellübersicht..."
        Me.KundenverlaufToolStripMenuItem.ToolTipText = "Zeigt vom Kunden vorherige Bestellunge an "
        '
        'ShopToolStripMenuItem
        '
        Me.ShopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem1, Me.ToolStripSeparator56, Me.WartelisteToolStripMenuItem, Me.BestelltToolStripMenuItem1, Me.AktivToolStripMenuItem, Me.ToolStripSeparator57, Me.BildAnzeigenToolStripMenuItem})
        Me.ShopToolStripMenuItem.Name = "ShopToolStripMenuItem"
        Me.ShopToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.ShopToolStripMenuItem.Text = "Artikeldatenbank / Shop"
        '
        'LöschenToolStripMenuItem1
        '
        Me.LöschenToolStripMenuItem1.Name = "LöschenToolStripMenuItem1"
        Me.LöschenToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.LöschenToolStripMenuItem1.Text = "Löschen"
        '
        'ToolStripSeparator56
        '
        Me.ToolStripSeparator56.Name = "ToolStripSeparator56"
        Me.ToolStripSeparator56.Size = New System.Drawing.Size(178, 6)
        '
        'WartelisteToolStripMenuItem
        '
        Me.WartelisteToolStripMenuItem.Name = "WartelisteToolStripMenuItem"
        Me.WartelisteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.WartelisteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.WartelisteToolStripMenuItem.Text = "Warteliste"
        '
        'BestelltToolStripMenuItem1
        '
        Me.BestelltToolStripMenuItem1.Name = "BestelltToolStripMenuItem1"
        Me.BestelltToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.BestelltToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.BestelltToolStripMenuItem1.Text = "Bestellt"
        '
        'AktivToolStripMenuItem
        '
        Me.AktivToolStripMenuItem.Name = "AktivToolStripMenuItem"
        Me.AktivToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.AktivToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AktivToolStripMenuItem.Text = "Aktiv"
        '
        'ToolStripSeparator57
        '
        Me.ToolStripSeparator57.Name = "ToolStripSeparator57"
        Me.ToolStripSeparator57.Size = New System.Drawing.Size(178, 6)
        '
        'BildAnzeigenToolStripMenuItem
        '
        Me.BildAnzeigenToolStripMenuItem.Name = "BildAnzeigenToolStripMenuItem"
        Me.BildAnzeigenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BildAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.BildAnzeigenToolStripMenuItem.Text = "Bild anzeigen"
        '
        'MagentoToolStripMenuItem1
        '
        Me.MagentoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtikelBestelltToolStripMenuItem1, Me.ArtikelAktivierenToolStripMenuItem, Me.ArtikelLöschenToolStripMenuItem3})
        Me.MagentoToolStripMenuItem1.Name = "MagentoToolStripMenuItem1"
        Me.MagentoToolStripMenuItem1.Size = New System.Drawing.Size(310, 22)
        Me.MagentoToolStripMenuItem1.Text = "Magento"
        '
        'ArtikelBestelltToolStripMenuItem1
        '
        Me.ArtikelBestelltToolStripMenuItem1.Name = "ArtikelBestelltToolStripMenuItem1"
        Me.ArtikelBestelltToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ArtikelBestelltToolStripMenuItem1.Text = "Artikel bestellt"
        '
        'ArtikelAktivierenToolStripMenuItem
        '
        Me.ArtikelAktivierenToolStripMenuItem.Name = "ArtikelAktivierenToolStripMenuItem"
        Me.ArtikelAktivierenToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ArtikelAktivierenToolStripMenuItem.Text = "Artikel aktivieren"
        '
        'ArtikelLöschenToolStripMenuItem3
        '
        Me.ArtikelLöschenToolStripMenuItem3.Name = "ArtikelLöschenToolStripMenuItem3"
        Me.ArtikelLöschenToolStripMenuItem3.Size = New System.Drawing.Size(162, 22)
        Me.ArtikelLöschenToolStripMenuItem3.Text = "Artikel löschen"
        '
        'ShopsteToolStripMenuItem
        '
        Me.ShopsteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtikelLöschenToolStripMenuItem4})
        Me.ShopsteToolStripMenuItem.Name = "ShopsteToolStripMenuItem"
        Me.ShopsteToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.ShopsteToolStripMenuItem.Text = "Shopste "
        '
        'ArtikelLöschenToolStripMenuItem4
        '
        Me.ArtikelLöschenToolStripMenuItem4.Name = "ArtikelLöschenToolStripMenuItem4"
        Me.ArtikelLöschenToolStripMenuItem4.Size = New System.Drawing.Size(213, 22)
        Me.ArtikelLöschenToolStripMenuItem4.Text = "Lagerbestand auf 0 setzen!"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.APILöschenToolStripMenuItem, Me.ToolStripSeparator58, Me.DeutschSuchenToolStripMenuItem, Me.EnglischSuchenToolStripMenuItem})
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.DToolStripMenuItem.Text = "Delcampe "
        '
        'APILöschenToolStripMenuItem
        '
        Me.APILöschenToolStripMenuItem.Name = "APILöschenToolStripMenuItem"
        Me.APILöschenToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.APILöschenToolStripMenuItem.Text = "Artikel API Löschen"
        '
        'ToolStripSeparator58
        '
        Me.ToolStripSeparator58.Name = "ToolStripSeparator58"
        Me.ToolStripSeparator58.Size = New System.Drawing.Size(173, 6)
        '
        'DeutschSuchenToolStripMenuItem
        '
        Me.DeutschSuchenToolStripMenuItem.Name = "DeutschSuchenToolStripMenuItem"
        Me.DeutschSuchenToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeutschSuchenToolStripMenuItem.Text = "&Deutsch suchen"
        '
        'EnglischSuchenToolStripMenuItem
        '
        Me.EnglischSuchenToolStripMenuItem.Name = "EnglischSuchenToolStripMenuItem"
        Me.EnglischSuchenToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EnglischSuchenToolStripMenuItem.Text = "Englisch suchen"
        '
        'ToolStripSeparator38
        '
        Me.ToolStripSeparator38.Name = "ToolStripSeparator38"
        Me.ToolStripSeparator38.Size = New System.Drawing.Size(307, 6)
        '
        'YABEArtikelansichtToolStripMenuItem
        '
        Me.YABEArtikelansichtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMSAnsichtToolStripMenuItem, Me.ToolStripSeparator42, Me.DelcampeArtikelansichtToolStripMenuItem, Me.DelcampeVersandkostenToolStripMenuItem, Me.DelcampeBewertungenToolStripMenuItem, Me.ToolStripSeparator33, Me.EBayArtikelansichtToolStripMenuItem, Me.EBayVersandkostenToolStripMenuItem, Me.EBayBewertungenToolStripMenuItem, Me.ToolStripSeparator34, Me.PersonensucheToolStripMenuItem, Me.TelefonnummernSucheToolStripMenuItem, Me.GoogleMapsToolStripMenuItem})
        Me.YABEArtikelansichtToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YABEArtikelansichtToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop21
        Me.YABEArtikelansichtToolStripMenuItem.Name = "YABEArtikelansichtToolStripMenuItem"
        Me.YABEArtikelansichtToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.YABEArtikelansichtToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.YABEArtikelansichtToolStripMenuItem.Text = "WebCenter..."
        Me.YABEArtikelansichtToolStripMenuItem.ToolTipText = "Interner YABE Webbrowser"
        '
        'CMSAnsichtToolStripMenuItem
        '
        Me.CMSAnsichtToolStripMenuItem.Name = "CMSAnsichtToolStripMenuItem"
        Me.CMSAnsichtToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.CMSAnsichtToolStripMenuItem.Text = "CMS - > Ansicht"
        '
        'ToolStripSeparator42
        '
        Me.ToolStripSeparator42.Name = "ToolStripSeparator42"
        Me.ToolStripSeparator42.Size = New System.Drawing.Size(227, 6)
        '
        'DelcampeArtikelansichtToolStripMenuItem
        '
        Me.DelcampeArtikelansichtToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelcampeArtikelansichtToolStripMenuItem.Name = "DelcampeArtikelansichtToolStripMenuItem"
        Me.DelcampeArtikelansichtToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.DelcampeArtikelansichtToolStripMenuItem.Text = "Delcampe -> Artikelansicht"
        '
        'DelcampeVersandkostenToolStripMenuItem
        '
        Me.DelcampeVersandkostenToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelcampeVersandkostenToolStripMenuItem.Name = "DelcampeVersandkostenToolStripMenuItem"
        Me.DelcampeVersandkostenToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.DelcampeVersandkostenToolStripMenuItem.Text = "Delcampe -> Versandkosten"
        '
        'DelcampeBewertungenToolStripMenuItem
        '
        Me.DelcampeBewertungenToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelcampeBewertungenToolStripMenuItem.Name = "DelcampeBewertungenToolStripMenuItem"
        Me.DelcampeBewertungenToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.DelcampeBewertungenToolStripMenuItem.Text = "Delcampe -> Bewertungen"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(227, 6)
        '
        'EBayArtikelansichtToolStripMenuItem
        '
        Me.EBayArtikelansichtToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EBayArtikelansichtToolStripMenuItem.Name = "EBayArtikelansichtToolStripMenuItem"
        Me.EBayArtikelansichtToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.EBayArtikelansichtToolStripMenuItem.Text = "eBay -> Artikelansicht"
        '
        'EBayVersandkostenToolStripMenuItem
        '
        Me.EBayVersandkostenToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EBayVersandkostenToolStripMenuItem.Name = "EBayVersandkostenToolStripMenuItem"
        Me.EBayVersandkostenToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.EBayVersandkostenToolStripMenuItem.Text = "eBay -> Versandkosten"
        '
        'EBayBewertungenToolStripMenuItem
        '
        Me.EBayBewertungenToolStripMenuItem.Enabled = False
        Me.EBayBewertungenToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EBayBewertungenToolStripMenuItem.Name = "EBayBewertungenToolStripMenuItem"
        Me.EBayBewertungenToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.EBayBewertungenToolStripMenuItem.Text = "eBay -> Bewertungen"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(227, 6)
        '
        'PersonensucheToolStripMenuItem
        '
        Me.PersonensucheToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonensucheToolStripMenuItem.Name = "PersonensucheToolStripMenuItem"
        Me.PersonensucheToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PersonensucheToolStripMenuItem.Text = "Kunde -> Personensuche"
        '
        'TelefonnummernSucheToolStripMenuItem
        '
        Me.TelefonnummernSucheToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonnummernSucheToolStripMenuItem.Name = "TelefonnummernSucheToolStripMenuItem"
        Me.TelefonnummernSucheToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.TelefonnummernSucheToolStripMenuItem.Text = "Kunde -> Telefonnummernsuche"
        '
        'GoogleMapsToolStripMenuItem
        '
        Me.GoogleMapsToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoogleMapsToolStripMenuItem.Name = "GoogleMapsToolStripMenuItem"
        Me.GoogleMapsToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.GoogleMapsToolStripMenuItem.Text = "Kunde -> Google -> Maps"
        '
        'ToolStripSeparator37
        '
        Me.ToolStripSeparator37.Name = "ToolStripSeparator37"
        Me.ToolStripSeparator37.Size = New System.Drawing.Size(307, 6)
        '
        'YABEAnsichtToolStripMenuItem
        '
        Me.YABEAnsichtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GruppiertKeineToolStripMenuItem, Me.ToolStripSeparator49, Me.GruppiertBestellstatusToolStripMenuItem, Me.GruppiertNameToolStripMenuItem, Me.GroupiertVerkaufsendeToolStripMenuItem, Me.GruppiertLandToolStripMenuItem, Me.GruppiertMutterspracheToolStripMenuItem})
        Me.YABEAnsichtToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.verlauf
        Me.YABEAnsichtToolStripMenuItem.Name = "YABEAnsichtToolStripMenuItem"
        Me.YABEAnsichtToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.YABEAnsichtToolStripMenuItem.Text = "Gruppierung"
        '
        'GruppiertKeineToolStripMenuItem
        '
        Me.GruppiertKeineToolStripMenuItem.Name = "GruppiertKeineToolStripMenuItem"
        Me.GruppiertKeineToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GruppiertKeineToolStripMenuItem.Text = "Keine Gruppierung"
        '
        'ToolStripSeparator49
        '
        Me.ToolStripSeparator49.Name = "ToolStripSeparator49"
        Me.ToolStripSeparator49.Size = New System.Drawing.Size(217, 6)
        '
        'GruppiertBestellstatusToolStripMenuItem
        '
        Me.GruppiertBestellstatusToolStripMenuItem.Name = "GruppiertBestellstatusToolStripMenuItem"
        Me.GruppiertBestellstatusToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GruppiertBestellstatusToolStripMenuItem.Text = "Gruppiert -> Bestellstatus"
        '
        'GruppiertNameToolStripMenuItem
        '
        Me.GruppiertNameToolStripMenuItem.Name = "GruppiertNameToolStripMenuItem"
        Me.GruppiertNameToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GruppiertNameToolStripMenuItem.Text = "Gruppiert -> Name"
        '
        'GroupiertVerkaufsendeToolStripMenuItem
        '
        Me.GroupiertVerkaufsendeToolStripMenuItem.Name = "GroupiertVerkaufsendeToolStripMenuItem"
        Me.GroupiertVerkaufsendeToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GroupiertVerkaufsendeToolStripMenuItem.Text = "Gruppiert -> Verkaufsende"
        '
        'GruppiertLandToolStripMenuItem
        '
        Me.GruppiertLandToolStripMenuItem.Name = "GruppiertLandToolStripMenuItem"
        Me.GruppiertLandToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GruppiertLandToolStripMenuItem.Text = "Gruppiert -> Land"
        '
        'GruppiertMutterspracheToolStripMenuItem
        '
        Me.GruppiertMutterspracheToolStripMenuItem.Name = "GruppiertMutterspracheToolStripMenuItem"
        Me.GruppiertMutterspracheToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GruppiertMutterspracheToolStripMenuItem.Text = "Gruppiert -> Muttersprache"
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        Me.ToolStripSeparator29.Size = New System.Drawing.Size(307, 6)
        '
        'ZuordnungArtikelKundeToolStripMenuItem
        '
        Me.ZuordnungArtikelKundeToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.ZuordnungArtikelKundeToolStripMenuItem.Name = "ZuordnungArtikelKundeToolStripMenuItem"
        Me.ZuordnungArtikelKundeToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.ZuordnungArtikelKundeToolStripMenuItem.Text = "SYNC -> Artikel => Kunde"
        Me.ZuordnungArtikelKundeToolStripMenuItem.Visible = False
        '
        'DelcampeBestellsStatusAktuallisierenToolStripMenuItem
        '
        Me.DelcampeBestellsStatusAktuallisierenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivAktuallisierenToolStripMenuItem})
        Me.DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.time_go
        Me.DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Name = "DelcampeBestellsStatusAktuallisierenToolStripMenuItem"
        Me.DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.DelcampeBestellsStatusAktuallisierenToolStripMenuItem.Text = "SYNC -> Bestellstatus -> Delcampe"
        '
        'ArchivAktuallisierenToolStripMenuItem
        '
        Me.ArchivAktuallisierenToolStripMenuItem.Name = "ArchivAktuallisierenToolStripMenuItem"
        Me.ArchivAktuallisierenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArchivAktuallisierenToolStripMenuItem.Text = "&Archiv aktuallisieren"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(307, 6)
        '
        'SucheArtikelToolStripMenuItem
        '
        Me.SucheArtikelToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheArtikelToolStripMenuItem.Name = "SucheArtikelToolStripMenuItem"
        Me.SucheArtikelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SucheArtikelToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.SucheArtikelToolStripMenuItem.Text = "Suche -> &Artikeldatenbank"
        '
        'SucheKundeToolStripMenuItem
        '
        Me.SucheKundeToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheKundeToolStripMenuItem.Name = "SucheKundeToolStripMenuItem"
        Me.SucheKundeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.SucheKundeToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.SucheKundeToolStripMenuItem.Text = "Suche -> &Kunden"
        '
        'SucheBewertungenToolStripMenuItem
        '
        Me.SucheBewertungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheBewertungenToolStripMenuItem.Name = "SucheBewertungenToolStripMenuItem"
        Me.SucheBewertungenToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.SucheBewertungenToolStripMenuItem.Text = "Suche -> Bewertungen"
        '
        'SucheBestellungenToolStripMenuItem
        '
        Me.SucheBestellungenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.SucheBestellungenToolStripMenuItem.Name = "SucheBestellungenToolStripMenuItem"
        Me.SucheBestellungenToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.SucheBestellungenToolStripMenuItem.Text = "Suche -> Bestellungen"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(307, 6)
        '
        'HöchstbietenderBewertungsprofilToolStripMenuItem
        '
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_add
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem.Name = "HöchstbietenderBewertungsprofilToolStripMenuItem"
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.HöchstbietenderBewertungsprofilToolStripMenuItem.Text = "eBay Auktion -> &Höchstbietender..."
        '
        'EBayAuktionArtikeldetialsToolStripMenuItem
        '
        Me.EBayAuktionArtikeldetialsToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.EBayAuktionArtikeldetialsToolStripMenuItem.Name = "EBayAuktionArtikeldetialsToolStripMenuItem"
        Me.EBayAuktionArtikeldetialsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.EBayAuktionArtikeldetialsToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.EBayAuktionArtikeldetialsToolStripMenuItem.Text = "eBay Auktion -> &Artikeldetails..."
        '
        'BietverlaufToolStripMenuItem1
        '
        Me.BietverlaufToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._31
        Me.BietverlaufToolStripMenuItem1.Name = "BietverlaufToolStripMenuItem1"
        Me.BietverlaufToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BietverlaufToolStripMenuItem1.Size = New System.Drawing.Size(310, 22)
        Me.BietverlaufToolStripMenuItem1.Text = "eBay Auktion -> &Bietverlauf..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(307, 6)
        '
        'CopyEBayIDToolStripMenuItem1
        '
        Me.CopyEBayIDToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.save
        Me.CopyEBayIDToolStripMenuItem1.Name = "CopyEBayIDToolStripMenuItem1"
        Me.CopyEBayIDToolStripMenuItem1.Size = New System.Drawing.Size(310, 22)
        Me.CopyEBayIDToolStripMenuItem1.Text = "&Kopieren -> Artikel ID"
        '
        'KopierenEmailToolStripMenuItem
        '
        Me.KopierenEmailToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.KopierenEmailToolStripMenuItem.Name = "KopierenEmailToolStripMenuItem"
        Me.KopierenEmailToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenEmailToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.KopierenEmailToolStripMenuItem.Text = "&Kopieren -> Email"
        '
        'CopyEBayMitgliedsnameToolStripMenuItem
        '
        Me.CopyEBayMitgliedsnameToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.CopyEBayMitgliedsnameToolStripMenuItem.Name = "CopyEBayMitgliedsnameToolStripMenuItem"
        Me.CopyEBayMitgliedsnameToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.CopyEBayMitgliedsnameToolStripMenuItem.Text = "&Kopieren -> eBay Mitgliedsname"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(307, 6)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.LöschenToolStripMenuItem.Text = "Bestellung -> &löschen"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(307, 6)
        '
        'EBayÖffnenToolStripMenuItem
        '
        Me.EBayÖffnenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.film_link
        Me.EBayÖffnenToolStripMenuItem.Name = "EBayÖffnenToolStripMenuItem"
        Me.EBayÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.EBayÖffnenToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.EBayÖffnenToolStripMenuItem.Text = "Web Link -> &Artikel öffnen"
        '
        'ExportierenToolStripMenuItem1
        '
        Me.ExportierenToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinanceOfficeToolStripMenuItem})
        Me.ExportierenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportierenToolStripMenuItem1.Name = "ExportierenToolStripMenuItem1"
        Me.ExportierenToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportierenToolStripMenuItem1.Size = New System.Drawing.Size(310, 22)
        Me.ExportierenToolStripMenuItem1.Text = "&Übersicht exportieren..."
        '
        'FinanceOfficeToolStripMenuItem
        '
        Me.FinanceOfficeToolStripMenuItem.Name = "FinanceOfficeToolStripMenuItem"
        Me.FinanceOfficeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.FinanceOfficeToolStripMenuItem.Text = "Finance Office"
        '
        'EBayStatusToolStripMenuItem
        '
        Me.EBayStatusToolStripMenuItem.Name = "EBayStatusToolStripMenuItem"
        Me.EBayStatusToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.EBayStatusToolStripMenuItem.Text = "eBay Status"
        '
        'pgreBayVerlaufUpdate
        '
        Me.pgreBayVerlaufUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgreBayVerlaufUpdate.Location = New System.Drawing.Point(5, 9)
        Me.pgreBayVerlaufUpdate.Name = "pgreBayVerlaufUpdate"
        Me.pgreBayVerlaufUpdate.Size = New System.Drawing.Size(1118, 14)
        Me.pgreBayVerlaufUpdate.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgreBayVerlaufUpdate.TabIndex = 26
        Me.pgreBayVerlaufUpdate.Visible = False
        '
        'bestelliste
        '
        Me.bestelliste.Controls.Add(Me.SplitContainer2)
        Me.bestelliste.Location = New System.Drawing.Point(4, 22)
        Me.bestelliste.Name = "bestelliste"
        Me.bestelliste.Padding = New System.Windows.Forms.Padding(3)
        Me.bestelliste.Size = New System.Drawing.Size(1134, 498)
        Me.bestelliste.TabIndex = 1
        Me.bestelliste.Text = "Bestellungen nach Kunden"
        Me.bestelliste.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvwBestellungen_kunden)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lvwBestellungen_bestelliste_neu)
        Me.SplitContainer2.Size = New System.Drawing.Size(1128, 492)
        Me.SplitContainer2.SplitterDistance = 289
        Me.SplitContainer2.TabIndex = 0
        '
        'lvwBestellungen_kunden
        '
        Me.lvwBestellungen_kunden.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBestellungen_kunden.AllowColumnReorder = True
        Me.lvwBestellungen_kunden.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwBestellungen_kunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBestellungen_kunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_kuden_bestellliste_name, Me.col_kuden_bestellliste_mitgliedsname, Me.col_kuden_bestellliste_email, Me.col_kuden_bestellliste_strasse, Me.col_kuden_bestellliste_ort, Me.col_kuden_bestellliste_plz, Me.col_kuden_bestellliste_land, Me.col_kuden_bestellliste_käufe, Me.col_kuden_bestellliste_artikelanzahl, Me.col_kuden_bestellliste_newsletter, Me.col_kuden_bestellliste_kd_änderung, Me.col_kuden_bestellliste_plattform, Me.col_kuden_bestellliste_sprachliste, Me.col_kuden_bestellliste_muttersprache, Me.col_kuden_bestellliste_id, Me.col_kuden_bestellliste_order_id, Me.col_kuden_bestellliste_bestellt_am, Me.col_kuden_bestellliste_bestellstatus, Me.col_kuden_bestellliste_endsumme, Me.col_kuden_bestellliste_versandkosten, Me.col_kuden_bestellliste_rabatt, Me.col_kuden_bestellliste_versandart, Me.col_kunden_bestellliste_verschickt, Me.col_kunden_bestellliste_bezahlt, Me.col_kunden_bestellliste_storniert, Me.col_kunden_bestellliste_bewertet, Me.col_kunden_bestellliste_abgeschlossen})
        Me.lvwBestellungen_kunden.ContextMenuStrip = Me.cmsBestellungen_kunden
        Me.lvwBestellungen_kunden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwBestellungen_kunden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBestellungen_kunden.FullRowSelect = True
        Me.lvwBestellungen_kunden.GridLines = True
        Me.lvwBestellungen_kunden.HideSelection = False
        Me.lvwBestellungen_kunden.Location = New System.Drawing.Point(0, 0)
        Me.lvwBestellungen_kunden.MultiSelect = False
        Me.lvwBestellungen_kunden.Name = "lvwBestellungen_kunden"
        Me.lvwBestellungen_kunden.ShowItemToolTips = True
        Me.lvwBestellungen_kunden.Size = New System.Drawing.Size(1128, 289)
        Me.lvwBestellungen_kunden.TabIndex = 1
        Me.lvwBestellungen_kunden.UseCompatibleStateImageBehavior = False
        Me.lvwBestellungen_kunden.View = System.Windows.Forms.View.Details
        '
        'col_kuden_bestellliste_name
        '
        Me.col_kuden_bestellliste_name.DisplayIndex = 3
        Me.col_kuden_bestellliste_name.Text = "Name"
        Me.col_kuden_bestellliste_name.Width = 229
        '
        'col_kuden_bestellliste_mitgliedsname
        '
        Me.col_kuden_bestellliste_mitgliedsname.DisplayIndex = 4
        Me.col_kuden_bestellliste_mitgliedsname.Text = "Mitgliedsname"
        Me.col_kuden_bestellliste_mitgliedsname.Width = 150
        '
        'col_kuden_bestellliste_email
        '
        Me.col_kuden_bestellliste_email.DisplayIndex = 6
        Me.col_kuden_bestellliste_email.Text = "Email"
        Me.col_kuden_bestellliste_email.Width = 104
        '
        'col_kuden_bestellliste_strasse
        '
        Me.col_kuden_bestellliste_strasse.DisplayIndex = 14
        Me.col_kuden_bestellliste_strasse.Text = "Strasse"
        Me.col_kuden_bestellliste_strasse.Width = 100
        '
        'col_kuden_bestellliste_ort
        '
        Me.col_kuden_bestellliste_ort.DisplayIndex = 8
        Me.col_kuden_bestellliste_ort.Text = "Ort"
        Me.col_kuden_bestellliste_ort.Width = 74
        '
        'col_kuden_bestellliste_plz
        '
        Me.col_kuden_bestellliste_plz.DisplayIndex = 15
        Me.col_kuden_bestellliste_plz.Text = "PLZ"
        Me.col_kuden_bestellliste_plz.Width = 103
        '
        'col_kuden_bestellliste_land
        '
        Me.col_kuden_bestellliste_land.DisplayIndex = 7
        Me.col_kuden_bestellliste_land.Text = "Land"
        Me.col_kuden_bestellliste_land.Width = 172
        '
        'col_kuden_bestellliste_käufe
        '
        Me.col_kuden_bestellliste_käufe.DisplayIndex = 16
        Me.col_kuden_bestellliste_käufe.Text = "GS"
        Me.col_kuden_bestellliste_käufe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_kuden_bestellliste_käufe.Width = 96
        '
        'col_kuden_bestellliste_artikelanzahl
        '
        Me.col_kuden_bestellliste_artikelanzahl.DisplayIndex = 17
        Me.col_kuden_bestellliste_artikelanzahl.Text = "AA"
        Me.col_kuden_bestellliste_artikelanzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'col_kuden_bestellliste_newsletter
        '
        Me.col_kuden_bestellliste_newsletter.DisplayIndex = 18
        Me.col_kuden_bestellliste_newsletter.Text = "Newsletter"
        '
        'col_kuden_bestellliste_kd_änderung
        '
        Me.col_kuden_bestellliste_kd_änderung.DisplayIndex = 19
        Me.col_kuden_bestellliste_kd_änderung.Text = "K. Änderung"
        Me.col_kuden_bestellliste_kd_änderung.Width = 73
        '
        'col_kuden_bestellliste_plattform
        '
        Me.col_kuden_bestellliste_plattform.DisplayIndex = 2
        Me.col_kuden_bestellliste_plattform.Text = "Plattform"
        Me.col_kuden_bestellliste_plattform.Width = 72
        '
        'col_kuden_bestellliste_sprachliste
        '
        Me.col_kuden_bestellliste_sprachliste.DisplayIndex = 13
        Me.col_kuden_bestellliste_sprachliste.Text = "Sprachenliste"
        '
        'col_kuden_bestellliste_muttersprache
        '
        Me.col_kuden_bestellliste_muttersprache.DisplayIndex = 5
        Me.col_kuden_bestellliste_muttersprache.Text = "MSP"
        '
        'col_kuden_bestellliste_id
        '
        Me.col_kuden_bestellliste_id.DisplayIndex = 20
        Me.col_kuden_bestellliste_id.Text = "ID"
        '
        'col_kuden_bestellliste_order_id
        '
        Me.col_kuden_bestellliste_order_id.DisplayIndex = 21
        Me.col_kuden_bestellliste_order_id.Text = "OrderID"
        '
        'col_kuden_bestellliste_bestellt_am
        '
        Me.col_kuden_bestellliste_bestellt_am.DisplayIndex = 0
        Me.col_kuden_bestellliste_bestellt_am.Text = "Bestell erstellt am"
        '
        'col_kuden_bestellliste_bestellstatus
        '
        Me.col_kuden_bestellliste_bestellstatus.DisplayIndex = 12
        Me.col_kuden_bestellliste_bestellstatus.Text = "Bestellstatus"
        '
        'col_kuden_bestellliste_endsumme
        '
        Me.col_kuden_bestellliste_endsumme.DisplayIndex = 1
        Me.col_kuden_bestellliste_endsumme.Text = "VP"
        '
        'col_kuden_bestellliste_versandkosten
        '
        Me.col_kuden_bestellliste_versandkosten.DisplayIndex = 9
        Me.col_kuden_bestellliste_versandkosten.Text = "VK"
        '
        'col_kuden_bestellliste_rabatt
        '
        Me.col_kuden_bestellliste_rabatt.DisplayIndex = 10
        Me.col_kuden_bestellliste_rabatt.Text = "Rabatt"
        '
        'col_kuden_bestellliste_versandart
        '
        Me.col_kuden_bestellliste_versandart.DisplayIndex = 11
        Me.col_kuden_bestellliste_versandart.Text = "Versandart"
        '
        'col_kunden_bestellliste_verschickt
        '
        Me.col_kunden_bestellliste_verschickt.Text = "Verschickt"
        '
        'col_kunden_bestellliste_bezahlt
        '
        Me.col_kunden_bestellliste_bezahlt.Text = "Bezahlt"
        '
        'col_kunden_bestellliste_storniert
        '
        Me.col_kunden_bestellliste_storniert.Text = "Storniert"
        '
        'col_kunden_bestellliste_bewertet
        '
        Me.col_kunden_bestellliste_bewertet.Text = "Bewertet"
        Me.col_kunden_bestellliste_bewertet.Width = 0
        '
        'col_kunden_bestellliste_abgeschlossen
        '
        Me.col_kunden_bestellliste_abgeschlossen.Text = "Abgeschlossen"
        '
        'cmsBestellungen_kunden
        '
        Me.cmsBestellungen_kunden.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsichtAktuallisierenToolStripMenuItem3, Me.ZeigeAlleKundenbestellungenToolStripMenuItem, Me.ToolStripSeparator74, Me.ToolStripMenuItem43, Me.ToolStripMenuItem44, Me.ToolStripMenuItem51, Me.ToolStripSeparator72, Me.BestellungErneutAbschickenToolStripMenuItem, Me.EiSoExportierenDerAnsichtToolStripMenuItem, Me.KundeEditierenToolStripMenuItem})
        Me.cmsBestellungen_kunden.Name = "cmsBestellungen_kunden"
        Me.cmsBestellungen_kunden.Size = New System.Drawing.Size(290, 192)
        '
        'AnsichtAktuallisierenToolStripMenuItem3
        '
        Me.AnsichtAktuallisierenToolStripMenuItem3.Name = "AnsichtAktuallisierenToolStripMenuItem3"
        Me.AnsichtAktuallisierenToolStripMenuItem3.Size = New System.Drawing.Size(289, 22)
        Me.AnsichtAktuallisierenToolStripMenuItem3.Text = "Ansicht aktuallisieren..."
        '
        'ZeigeAlleKundenbestellungenToolStripMenuItem
        '
        Me.ZeigeAlleKundenbestellungenToolStripMenuItem.Name = "ZeigeAlleKundenbestellungenToolStripMenuItem"
        Me.ZeigeAlleKundenbestellungenToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ZeigeAlleKundenbestellungenToolStripMenuItem.Text = "Zeige alle Kundenbestellungen..."
        '
        'ToolStripSeparator74
        '
        Me.ToolStripSeparator74.Name = "ToolStripSeparator74"
        Me.ToolStripSeparator74.Size = New System.Drawing.Size(286, 6)
        '
        'ToolStripMenuItem43
        '
        Me.ToolStripMenuItem43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem43.Image = Global.YabE.My.Resources.Resources.money_add
        Me.ToolStripMenuItem43.Name = "ToolStripMenuItem43"
        Me.ToolStripMenuItem43.Size = New System.Drawing.Size(289, 22)
        Me.ToolStripMenuItem43.Text = "Rechnungsdruck..."
        Me.ToolStripMenuItem43.ToolTipText = "Ermöglicht einen Rechnungsdruck..."
        '
        'ToolStripMenuItem44
        '
        Me.ToolStripMenuItem44.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem45, Me.ToolStripMenuItem46, Me.ToolStripMenuItem47, Me.ToolStripMenuItem48, Me.ToolStripSeparator70, Me.ToolStripMenuItem49, Me.ToolStripSeparator71, Me.ToolStripMenuItem50})
        Me.ToolStripMenuItem44.Image = Global.YabE.My.Resources.Resources.time_go
        Me.ToolStripMenuItem44.Name = "ToolStripMenuItem44"
        Me.ToolStripMenuItem44.Size = New System.Drawing.Size(289, 22)
        Me.ToolStripMenuItem44.Text = "Bestellungsstatus ändern"
        '
        'ToolStripMenuItem45
        '
        Me.ToolStripMenuItem45.Name = "ToolStripMenuItem45"
        Me.ToolStripMenuItem45.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem45.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem45.Text = "&Bestellt"
        '
        'ToolStripMenuItem46
        '
        Me.ToolStripMenuItem46.Name = "ToolStripMenuItem46"
        Me.ToolStripMenuItem46.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem46.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem46.Text = "&Bezahlt"
        '
        'ToolStripMenuItem47
        '
        Me.ToolStripMenuItem47.Name = "ToolStripMenuItem47"
        Me.ToolStripMenuItem47.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem47.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem47.Text = "&Verschickt"
        '
        'ToolStripMenuItem48
        '
        Me.ToolStripMenuItem48.Name = "ToolStripMenuItem48"
        Me.ToolStripMenuItem48.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem48.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem48.Text = "&Komplett"
        '
        'ToolStripSeparator70
        '
        Me.ToolStripSeparator70.Name = "ToolStripSeparator70"
        Me.ToolStripSeparator70.Size = New System.Drawing.Size(219, 6)
        '
        'ToolStripMenuItem49
        '
        Me.ToolStripMenuItem49.Name = "ToolStripMenuItem49"
        Me.ToolStripMenuItem49.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem49.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem49.Text = "&Storniert"
        '
        'ToolStripSeparator71
        '
        Me.ToolStripSeparator71.Name = "ToolStripSeparator71"
        Me.ToolStripSeparator71.Size = New System.Drawing.Size(219, 6)
        '
        'ToolStripMenuItem50
        '
        Me.ToolStripMenuItem50.Enabled = False
        Me.ToolStripMenuItem50.Name = "ToolStripMenuItem50"
        Me.ToolStripMenuItem50.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem50.Text = "Zahlungserinnerung senden"
        '
        'ToolStripMenuItem51
        '
        Me.ToolStripMenuItem51.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator75, Me.ToolStripMenuItem53, Me.ToolStripMenuItem54, Me.ToolStripMenuItem55, Me.ToolStripSeparator76, Me.ToolStripMenuItem52})
        Me.ToolStripMenuItem51.Name = "ToolStripMenuItem51"
        Me.ToolStripMenuItem51.Size = New System.Drawing.Size(289, 22)
        Me.ToolStripMenuItem51.Text = "EiSo Shop / Artikeldatenbank"
        '
        'ToolStripSeparator75
        '
        Me.ToolStripSeparator75.Name = "ToolStripSeparator75"
        Me.ToolStripSeparator75.Size = New System.Drawing.Size(340, 6)
        '
        'ToolStripMenuItem53
        '
        Me.ToolStripMenuItem53.Name = "ToolStripMenuItem53"
        Me.ToolStripMenuItem53.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem53.Size = New System.Drawing.Size(343, 22)
        Me.ToolStripMenuItem53.Text = "EiSo Shop - Status: Warteliste"
        '
        'ToolStripMenuItem54
        '
        Me.ToolStripMenuItem54.Name = "ToolStripMenuItem54"
        Me.ToolStripMenuItem54.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem54.Size = New System.Drawing.Size(343, 22)
        Me.ToolStripMenuItem54.Text = "EiSo Shop - Status: Bestellt"
        '
        'ToolStripMenuItem55
        '
        Me.ToolStripMenuItem55.Name = "ToolStripMenuItem55"
        Me.ToolStripMenuItem55.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem55.Size = New System.Drawing.Size(343, 22)
        Me.ToolStripMenuItem55.Text = "EiSo Shop - Status: Aktiv"
        '
        'ToolStripSeparator76
        '
        Me.ToolStripSeparator76.Name = "ToolStripSeparator76"
        Me.ToolStripSeparator76.Size = New System.Drawing.Size(340, 6)
        '
        'ToolStripMenuItem52
        '
        Me.ToolStripMenuItem52.Name = "ToolStripMenuItem52"
        Me.ToolStripMenuItem52.Size = New System.Drawing.Size(343, 22)
        Me.ToolStripMenuItem52.Text = "Alle Bestellten Artikel aus Artikeldatenbank löschen"
        '
        'ToolStripSeparator72
        '
        Me.ToolStripSeparator72.Name = "ToolStripSeparator72"
        Me.ToolStripSeparator72.Size = New System.Drawing.Size(286, 6)
        '
        'BestellungErneutAbschickenToolStripMenuItem
        '
        Me.BestellungErneutAbschickenToolStripMenuItem.Name = "BestellungErneutAbschickenToolStripMenuItem"
        Me.BestellungErneutAbschickenToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.BestellungErneutAbschickenToolStripMenuItem.Text = "Bestellung erneut abschicken (Cockpit)..."
        Me.BestellungErneutAbschickenToolStripMenuItem.ToolTipText = "Fügt Ihre Bestellung wieder ins Cockpit (Aufträge)"
        '
        'EiSoExportierenDerAnsichtToolStripMenuItem
        '
        Me.EiSoExportierenDerAnsichtToolStripMenuItem.Name = "EiSoExportierenDerAnsichtToolStripMenuItem"
        Me.EiSoExportierenDerAnsichtToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.EiSoExportierenDerAnsichtToolStripMenuItem.Text = "EiSo -> Liste als CSV exportieren..."
        '
        'KundeEditierenToolStripMenuItem
        '
        Me.KundeEditierenToolStripMenuItem.Name = "KundeEditierenToolStripMenuItem"
        Me.KundeEditierenToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.KundeEditierenToolStripMenuItem.Text = "Kunde editieren..."
        '
        'lvwBestellungen_bestelliste_neu
        '
        Me.lvwBestellungen_bestelliste_neu.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBestellungen_bestelliste_neu.AllowColumnReorder = True
        Me.lvwBestellungen_bestelliste_neu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBestellungen_bestelliste_neu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwBestellungen_bestelliste_neu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBestellungen_bestelliste_neu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBestell_kund_artikel_id, Me.colBestell_kund_artikel_name, Me.colBestell_kund_artikel_user, Me.colBestell_kund_artikel_ort, Me.colBestell_kund_artikel_beschreibung, Me.colBestell_kund_artikel_preis, Me.colBestell_kund_artikel_versand, Me.colBestell_kund_artikel_bestellstatus, Me.colBestell_kund_artikel_bewertung, Me.colBestell_kund_artikel_email, Me.colBestell_kund_artikel_verkaufsende, Me.colBestell_kund_artikel_gebote, Me.colBestell_kund_artikel_gebühr, Me.colBestell_kund_artikel_plattform, Me.colBestell_kund_artikel_bild, Me.colBestell_kund_artikel_EID, Me.colBestell_kund_artikel_paypal, Me.colBestell_kund_artikel_land, Me.colBestell_kund_artikel_colname, Me.colBestell_kund_artikel_email_sprache, Me.colBestell_kund_artikel_straße, Me.colBestell_kund_artikel_sprachliste, Me.colBestell_kund_artikel_bild2, Me.colBestell_kund_artikel_menge, Me.colBestell_kund_artikel_orderid})
        Me.lvwBestellungen_bestelliste_neu.ContextMenuStrip = Me.cmsBestellungen_bestellungen
        Me.lvwBestellungen_bestelliste_neu.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBestellungen_bestelliste_neu.FullRowSelect = True
        Me.lvwBestellungen_bestelliste_neu.GridLines = True
        Me.lvwBestellungen_bestelliste_neu.HideSelection = False
        Me.lvwBestellungen_bestelliste_neu.LargeImageList = Me.bilder_history
        Me.lvwBestellungen_bestelliste_neu.Location = New System.Drawing.Point(0, 5)
        Me.lvwBestellungen_bestelliste_neu.Name = "lvwBestellungen_bestelliste_neu"
        Me.lvwBestellungen_bestelliste_neu.ShowItemToolTips = True
        Me.lvwBestellungen_bestelliste_neu.Size = New System.Drawing.Size(1125, 114)
        Me.lvwBestellungen_bestelliste_neu.SmallImageList = Me.bilder_history
        Me.lvwBestellungen_bestelliste_neu.TabIndex = 13
        Me.lvwBestellungen_bestelliste_neu.UseCompatibleStateImageBehavior = False
        Me.lvwBestellungen_bestelliste_neu.View = System.Windows.Forms.View.Details
        Me.lvwBestellungen_bestelliste_neu.VirtualListSize = 200
        '
        'colBestell_kund_artikel_id
        '
        Me.colBestell_kund_artikel_id.Text = "ID"
        Me.colBestell_kund_artikel_id.Width = 0
        '
        'colBestell_kund_artikel_name
        '
        Me.colBestell_kund_artikel_name.Text = "Name"
        Me.colBestell_kund_artikel_name.Width = 0
        '
        'colBestell_kund_artikel_user
        '
        Me.colBestell_kund_artikel_user.Text = "Benutzername"
        Me.colBestell_kund_artikel_user.Width = 105
        '
        'colBestell_kund_artikel_ort
        '
        Me.colBestell_kund_artikel_ort.Text = "Ort"
        Me.colBestell_kund_artikel_ort.Width = 0
        '
        'colBestell_kund_artikel_beschreibung
        '
        Me.colBestell_kund_artikel_beschreibung.Text = "Beschreibung"
        Me.colBestell_kund_artikel_beschreibung.Width = 284
        '
        'colBestell_kund_artikel_preis
        '
        Me.colBestell_kund_artikel_preis.Text = "VP"
        Me.colBestell_kund_artikel_preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colBestell_kund_artikel_preis.Width = 43
        '
        'colBestell_kund_artikel_versand
        '
        Me.colBestell_kund_artikel_versand.Text = "VK"
        Me.colBestell_kund_artikel_versand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colBestell_kund_artikel_versand.Width = 74
        '
        'colBestell_kund_artikel_bestellstatus
        '
        Me.colBestell_kund_artikel_bestellstatus.Text = "Bestellstatus"
        Me.colBestell_kund_artikel_bestellstatus.Width = 101
        '
        'colBestell_kund_artikel_bewertung
        '
        Me.colBestell_kund_artikel_bewertung.Text = "Bewertung"
        Me.colBestell_kund_artikel_bewertung.Width = 0
        '
        'colBestell_kund_artikel_email
        '
        Me.colBestell_kund_artikel_email.Text = "eMail"
        Me.colBestell_kund_artikel_email.Width = 0
        '
        'colBestell_kund_artikel_verkaufsende
        '
        Me.colBestell_kund_artikel_verkaufsende.Text = "Verkaufsende"
        Me.colBestell_kund_artikel_verkaufsende.Width = 96
        '
        'colBestell_kund_artikel_gebote
        '
        Me.colBestell_kund_artikel_gebote.Text = "GB"
        Me.colBestell_kund_artikel_gebote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colBestell_kund_artikel_gebühr
        '
        Me.colBestell_kund_artikel_gebühr.Text = "Gebühr"
        Me.colBestell_kund_artikel_gebühr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colBestell_kund_artikel_plattform
        '
        Me.colBestell_kund_artikel_plattform.Text = "Plattform"
        Me.colBestell_kund_artikel_plattform.Width = 70
        '
        'colBestell_kund_artikel_bild
        '
        Me.colBestell_kund_artikel_bild.Text = "Bild"
        '
        'colBestell_kund_artikel_EID
        '
        Me.colBestell_kund_artikel_EID.Text = "EiSo ID"
        Me.colBestell_kund_artikel_EID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colBestell_kund_artikel_paypal
        '
        Me.colBestell_kund_artikel_paypal.Text = "Paypalsumme"
        Me.colBestell_kund_artikel_paypal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colBestell_kund_artikel_paypal.Width = 0
        '
        'colBestell_kund_artikel_land
        '
        Me.colBestell_kund_artikel_land.Text = "Land"
        Me.colBestell_kund_artikel_land.Width = 0
        '
        'colBestell_kund_artikel_colname
        '
        Me.colBestell_kund_artikel_colname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colBestell_kund_artikel_email_sprache
        '
        Me.colBestell_kund_artikel_email_sprache.Text = "MSP"
        '
        'colBestell_kund_artikel_straße
        '
        Me.colBestell_kund_artikel_straße.Text = "Straße"
        Me.colBestell_kund_artikel_straße.Width = 0
        '
        'colBestell_kund_artikel_sprachliste
        '
        Me.colBestell_kund_artikel_sprachliste.Text = "Sprachliste"
        '
        'colBestell_kund_artikel_bild2
        '
        Me.colBestell_kund_artikel_bild2.Text = "Bild"
        '
        'colBestell_kund_artikel_menge
        '
        Me.colBestell_kund_artikel_menge.Text = "M"
        '
        'colBestell_kund_artikel_orderid
        '
        Me.colBestell_kund_artikel_orderid.Text = "Order ID"
        '
        'cmsBestellungen_bestellungen
        '
        Me.cmsBestellungen_bestellungen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator68, Me.ToolStripMenuItem33, Me.ToolStripSeparator73, Me.ToolStripMenuItem42, Me.ToolStripMenuItem34, Me.ToolStripMenuItem35, Me.ToolStripSeparator69, Me.ToolStripMenuItem19, Me.ToolStripMenuItem25, Me.ToolStripMenuItem29})
        Me.cmsBestellungen_bestellungen.Name = "cmsBestellungen_bestellungen"
        Me.cmsBestellungen_bestellungen.Size = New System.Drawing.Size(296, 176)
        '
        'ToolStripSeparator68
        '
        Me.ToolStripSeparator68.Name = "ToolStripSeparator68"
        Me.ToolStripSeparator68.Size = New System.Drawing.Size(292, 6)
        '
        'ToolStripMenuItem33
        '
        Me.ToolStripMenuItem33.Name = "ToolStripMenuItem33"
        Me.ToolStripMenuItem33.Size = New System.Drawing.Size(295, 22)
        Me.ToolStripMenuItem33.Text = "Bestellung erneut verschicken (Cockpit) ..."
        '
        'ToolStripSeparator73
        '
        Me.ToolStripSeparator73.Name = "ToolStripSeparator73"
        Me.ToolStripSeparator73.Size = New System.Drawing.Size(292, 6)
        '
        'ToolStripMenuItem42
        '
        Me.ToolStripMenuItem42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem42.Image = Global.YabE.My.Resources.Resources.money_add
        Me.ToolStripMenuItem42.Name = "ToolStripMenuItem42"
        Me.ToolStripMenuItem42.Size = New System.Drawing.Size(295, 22)
        Me.ToolStripMenuItem42.Text = "Rechnungsdruck..."
        Me.ToolStripMenuItem42.ToolTipText = "Ermöglicht einen Rechnungsdruck..."
        '
        'ToolStripMenuItem34
        '
        Me.ToolStripMenuItem34.Image = Global.YabE.My.Resources.Resources.user_edit2
        Me.ToolStripMenuItem34.Name = "ToolStripMenuItem34"
        Me.ToolStripMenuItem34.Size = New System.Drawing.Size(295, 22)
        Me.ToolStripMenuItem34.Text = "&Artikelübernahme..."
        '
        'ToolStripMenuItem35
        '
        Me.ToolStripMenuItem35.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem36, Me.ToolStripMenuItem37, Me.ToolStripMenuItem38, Me.ToolStripMenuItem39, Me.ToolStripSeparator66, Me.ToolStripMenuItem40, Me.ToolStripSeparator67, Me.ToolStripMenuItem41})
        Me.ToolStripMenuItem35.Image = Global.YabE.My.Resources.Resources.time_go
        Me.ToolStripMenuItem35.Name = "ToolStripMenuItem35"
        Me.ToolStripMenuItem35.Size = New System.Drawing.Size(295, 22)
        Me.ToolStripMenuItem35.Text = "Artikel Bestellungsstatus"
        '
        'ToolStripMenuItem36
        '
        Me.ToolStripMenuItem36.Name = "ToolStripMenuItem36"
        Me.ToolStripMenuItem36.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem36.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem36.Text = "Status: &Bestellt"
        '
        'ToolStripMenuItem37
        '
        Me.ToolStripMenuItem37.Name = "ToolStripMenuItem37"
        Me.ToolStripMenuItem37.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem37.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem37.Text = "Status: &Bezahlt"
        '
        'ToolStripMenuItem38
        '
        Me.ToolStripMenuItem38.Name = "ToolStripMenuItem38"
        Me.ToolStripMenuItem38.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem38.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem38.Text = "Status: &Verschickt"
        '
        'ToolStripMenuItem39
        '
        Me.ToolStripMenuItem39.Name = "ToolStripMenuItem39"
        Me.ToolStripMenuItem39.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem39.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem39.Text = "Status: &Komplett"
        '
        'ToolStripSeparator66
        '
        Me.ToolStripSeparator66.Name = "ToolStripSeparator66"
        Me.ToolStripSeparator66.Size = New System.Drawing.Size(219, 6)
        '
        'ToolStripMenuItem40
        '
        Me.ToolStripMenuItem40.Name = "ToolStripMenuItem40"
        Me.ToolStripMenuItem40.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem40.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem40.Text = "Status: &Storniert"
        '
        'ToolStripSeparator67
        '
        Me.ToolStripSeparator67.Name = "ToolStripSeparator67"
        Me.ToolStripSeparator67.Size = New System.Drawing.Size(219, 6)
        '
        'ToolStripMenuItem41
        '
        Me.ToolStripMenuItem41.Enabled = False
        Me.ToolStripMenuItem41.Name = "ToolStripMenuItem41"
        Me.ToolStripMenuItem41.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem41.Text = "Zahlungserinnerung senden"
        '
        'ToolStripSeparator69
        '
        Me.ToolStripSeparator69.Name = "ToolStripSeparator69"
        Me.ToolStripSeparator69.Size = New System.Drawing.Size(292, 6)
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem20, Me.ToolStripSeparator63, Me.ToolStripMenuItem21, Me.ToolStripMenuItem22, Me.ToolStripMenuItem23, Me.ToolStripSeparator64, Me.ToolStripMenuItem24})
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(295, 22)
        Me.ToolStripMenuItem19.Text = "EiSo Shop / Artikeldatenbank"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem20.Text = "Markierte Artikel aus EiSo Shop löschen..."
        '
        'ToolStripSeparator63
        '
        Me.ToolStripSeparator63.Name = "ToolStripSeparator63"
        Me.ToolStripSeparator63.Size = New System.Drawing.Size(287, 6)
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem21.Text = "EiSo Shop - Status: Warteliste"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem22.Text = "EiSo Shop - Status: Bestellt"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem23.Text = "EiSo Shop - Status: Aktiv"
        '
        'ToolStripSeparator64
        '
        Me.ToolStripSeparator64.Name = "ToolStripSeparator64"
        Me.ToolStripSeparator64.Size = New System.Drawing.Size(287, 6)
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem24.Text = "Bild anzeigen"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem26, Me.ToolStripSeparator65, Me.ToolStripMenuItem27, Me.ToolStripMenuItem28})
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(295, 22)
        Me.ToolStripMenuItem25.Text = "Delcampe "
        Me.ToolStripMenuItem25.Visible = False
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem26.Text = "Artikel API Löschen"
        '
        'ToolStripSeparator65
        '
        Me.ToolStripSeparator65.Name = "ToolStripSeparator65"
        Me.ToolStripSeparator65.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem27.Text = "&Deutsch suchen"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem28.Text = "Englisch suchen"
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem30, Me.ToolStripMenuItem31, Me.ToolStripMenuItem32})
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(295, 22)
        Me.ToolStripMenuItem29.Text = "Magento"
        Me.ToolStripMenuItem29.Visible = False
        '
        'ToolStripMenuItem30
        '
        Me.ToolStripMenuItem30.Name = "ToolStripMenuItem30"
        Me.ToolStripMenuItem30.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripMenuItem30.Text = "Artikel bestellt"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripMenuItem31.Text = "Artikel aktivieren"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripMenuItem32.Text = "Artikel löschen"
        '
        'chkBestellungen_Alle
        '
        Me.chkBestellungen_Alle.AutoSize = True
        Me.chkBestellungen_Alle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungen_Alle.Location = New System.Drawing.Point(220, 57)
        Me.chkBestellungen_Alle.Name = "chkBestellungen_Alle"
        Me.chkBestellungen_Alle.Size = New System.Drawing.Size(49, 17)
        Me.chkBestellungen_Alle.TabIndex = 49
        Me.chkBestellungen_Alle.Text = "&Alle"
        Me.chkBestellungen_Alle.UseVisualStyleBackColor = True
        '
        'chkBestellungen_Komplett
        '
        Me.chkBestellungen_Komplett.AutoSize = True
        Me.chkBestellungen_Komplett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungen_Komplett.Location = New System.Drawing.Point(547, 57)
        Me.chkBestellungen_Komplett.Name = "chkBestellungen_Komplett"
        Me.chkBestellungen_Komplett.Size = New System.Drawing.Size(110, 17)
        Me.chkBestellungen_Komplett.TabIndex = 48
        Me.chkBestellungen_Komplett.Text = "&Komplett  (0)"
        Me.chkBestellungen_Komplett.UseVisualStyleBackColor = True
        '
        'chkBestellungenVerkauft
        '
        Me.chkBestellungenVerkauft.AutoSize = True
        Me.chkBestellungenVerkauft.Checked = True
        Me.chkBestellungenVerkauft.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBestellungenVerkauft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungenVerkauft.Location = New System.Drawing.Point(220, 38)
        Me.chkBestellungenVerkauft.Name = "chkBestellungenVerkauft"
        Me.chkBestellungenVerkauft.Size = New System.Drawing.Size(79, 17)
        Me.chkBestellungenVerkauft.TabIndex = 47
        Me.chkBestellungenVerkauft.Text = "Verkauft"
        Me.chkBestellungenVerkauft.UseVisualStyleBackColor = True
        '
        'chkBestellungen_Storniert
        '
        Me.chkBestellungen_Storniert.AutoSize = True
        Me.chkBestellungen_Storniert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungen_Storniert.Location = New System.Drawing.Point(710, 57)
        Me.chkBestellungen_Storniert.Name = "chkBestellungen_Storniert"
        Me.chkBestellungen_Storniert.Size = New System.Drawing.Size(110, 17)
        Me.chkBestellungen_Storniert.TabIndex = 46
        Me.chkBestellungen_Storniert.Text = "&Storniert  (0)"
        Me.chkBestellungen_Storniert.UseVisualStyleBackColor = True
        '
        'chkBestellungen_KeineBewertung
        '
        Me.chkBestellungen_KeineBewertung.AutoSize = True
        Me.chkBestellungen_KeineBewertung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungen_KeineBewertung.Location = New System.Drawing.Point(710, 34)
        Me.chkBestellungen_KeineBewertung.Name = "chkBestellungen_KeineBewertung"
        Me.chkBestellungen_KeineBewertung.Size = New System.Drawing.Size(152, 17)
        Me.chkBestellungen_KeineBewertung.TabIndex = 45
        Me.chkBestellungen_KeineBewertung.Text = "&Rückbewertung  (0)"
        Me.chkBestellungen_KeineBewertung.UseVisualStyleBackColor = True
        '
        'chkBestellungen_Versand
        '
        Me.chkBestellungen_Versand.AutoSize = True
        Me.chkBestellungen_Versand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungen_Versand.Location = New System.Drawing.Point(547, 38)
        Me.chkBestellungen_Versand.Name = "chkBestellungen_Versand"
        Me.chkBestellungen_Versand.Size = New System.Drawing.Size(120, 17)
        Me.chkBestellungen_Versand.TabIndex = 44
        Me.chkBestellungen_Versand.Text = "&Verschickt  (0)"
        Me.chkBestellungen_Versand.UseVisualStyleBackColor = True
        '
        'chkBestellungen_bezahlt
        '
        Me.chkBestellungen_bezahlt.AutoSize = True
        Me.chkBestellungen_bezahlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungen_bezahlt.Location = New System.Drawing.Point(387, 57)
        Me.chkBestellungen_bezahlt.Name = "chkBestellungen_bezahlt"
        Me.chkBestellungen_bezahlt.Size = New System.Drawing.Size(100, 17)
        Me.chkBestellungen_bezahlt.TabIndex = 43
        Me.chkBestellungen_bezahlt.Text = "&Bezahlt  (0)"
        Me.chkBestellungen_bezahlt.UseVisualStyleBackColor = True
        '
        'chkBestellungen_verkauft
        '
        Me.chkBestellungen_verkauft.AutoSize = True
        Me.chkBestellungen_verkauft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBestellungen_verkauft.Location = New System.Drawing.Point(387, 38)
        Me.chkBestellungen_verkauft.Name = "chkBestellungen_verkauft"
        Me.chkBestellungen_verkauft.Size = New System.Drawing.Size(97, 17)
        Me.chkBestellungen_verkauft.TabIndex = 42
        Me.chkBestellungen_verkauft.Text = "&Bestellt (0)"
        Me.chkBestellungen_verkauft.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Silver
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(196, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Verkaufsplattform"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ballonITips.SetToolTip(Me.Label17, "Ändern Sie Ihre Plattform auswahl")
        '
        'cmbPlattform_bestellungen
        '
        Me.cmbPlattform_bestellungen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbPlattform_bestellungen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlattform_bestellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlattform_bestellungen.FormattingEnabled = True
        Me.cmbPlattform_bestellungen.Location = New System.Drawing.Point(11, 53)
        Me.cmbPlattform_bestellungen.Name = "cmbPlattform_bestellungen"
        Me.cmbPlattform_bestellungen.Size = New System.Drawing.Size(196, 21)
        Me.cmbPlattform_bestellungen.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(217, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(662, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Auswahlkriterien für die Anzeige:"
        Me.ballonITips.SetToolTip(Me.Label11, "Die Kriterien verstehen sich als UND Verknüpfung")
        '
        'lblLive_von
        '
        Me.lblLive_von.BackColor = System.Drawing.Color.Silver
        Me.lblLive_von.Location = New System.Drawing.Point(259, 81)
        Me.lblLive_von.Name = "lblLive_von"
        Me.lblLive_von.Size = New System.Drawing.Size(259, 13)
        Me.lblLive_von.TabIndex = 11
        Me.lblLive_von.Text = "Bis - Verkaufsdatum"
        '
        'lblLive_bis
        '
        Me.lblLive_bis.BackColor = System.Drawing.Color.Silver
        Me.lblLive_bis.Location = New System.Drawing.Point(2, 81)
        Me.lblLive_bis.Name = "lblLive_bis"
        Me.lblLive_bis.Size = New System.Drawing.Size(1142, 13)
        Me.lblLive_bis.TabIndex = 10
        Me.lblLive_bis.Text = "Von - Verkaufsdatum"
        '
        'eBayHistoryBis
        '
        Me.eBayHistoryBis.Location = New System.Drawing.Point(262, 96)
        Me.eBayHistoryBis.Name = "eBayHistoryBis"
        Me.eBayHistoryBis.Size = New System.Drawing.Size(244, 21)
        Me.eBayHistoryBis.TabIndex = 10
        '
        'eBayHistoryVon
        '
        Me.eBayHistoryVon.Location = New System.Drawing.Point(9, 96)
        Me.eBayHistoryVon.Name = "eBayHistoryVon"
        Me.eBayHistoryVon.Size = New System.Drawing.Size(244, 21)
        Me.eBayHistoryVon.TabIndex = 9
        '
        'lblBestellungen_main
        '
        Me.lblBestellungen_main.AutoSize = True
        Me.lblBestellungen_main.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestellungen_main.Location = New System.Drawing.Point(10, 9)
        Me.lblBestellungen_main.Name = "lblBestellungen_main"
        Me.lblBestellungen_main.Size = New System.Drawing.Size(201, 23)
        Me.lblBestellungen_main.TabIndex = 38
        Me.lblBestellungen_main.Text = "Alle Bestellungen"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(288, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1142, 14)
        Me.Label3.TabIndex = 28
        '
        'chkHistoryZeitfilter
        '
        Me.chkHistoryZeitfilter.AutoSize = True
        Me.chkHistoryZeitfilter.Checked = True
        Me.chkHistoryZeitfilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHistoryZeitfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHistoryZeitfilter.Location = New System.Drawing.Point(1035, 61)
        Me.chkHistoryZeitfilter.Name = "chkHistoryZeitfilter"
        Me.chkHistoryZeitfilter.Size = New System.Drawing.Size(97, 17)
        Me.chkHistoryZeitfilter.TabIndex = 24
        Me.chkHistoryZeitfilter.Text = "Datumfilter"
        Me.chkHistoryZeitfilter.UseVisualStyleBackColor = True
        '
        'btnBestellungAdd
        '
        Me.btnBestellungAdd.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBestellungAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestellungAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestellungAdd.ImageIndex = 0
        Me.btnBestellungAdd.ImageList = Me.imgAuktionsmanagement
        Me.btnBestellungAdd.Location = New System.Drawing.Point(961, 97)
        Me.btnBestellungAdd.Name = "btnBestellungAdd"
        Me.btnBestellungAdd.Size = New System.Drawing.Size(171, 23)
        Me.btnBestellungAdd.TabIndex = 50
        Me.btnBestellungAdd.Text = "Bestellung..."
        Me.btnBestellungAdd.UseVisualStyleBackColor = False
        Me.btnBestellungAdd.Visible = False
        '
        'btneBayAdressenHolen
        '
        Me.btneBayAdressenHolen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btneBayAdressenHolen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneBayAdressenHolen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneBayAdressenHolen.ImageIndex = 0
        Me.btneBayAdressenHolen.ImageList = Me.imgAuktionsmanagement
        Me.btneBayAdressenHolen.Location = New System.Drawing.Point(733, 97)
        Me.btneBayAdressenHolen.Name = "btneBayAdressenHolen"
        Me.btneBayAdressenHolen.Size = New System.Drawing.Size(222, 23)
        Me.btneBayAdressenHolen.TabIndex = 12
        Me.btneBayAdressenHolen.Text = "eBay Adressen holen"
        Me.ballonITips.SetToolTip(Me.btneBayAdressenHolen, "eBay Transaktionabgleich erneut starten")
        Me.btneBayAdressenHolen.UseVisualStyleBackColor = False
        '
        'btnBestellungen_abrufen
        '
        Me.btnBestellungen_abrufen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBestellungen_abrufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestellungen_abrufen.Image = Global.YabE.My.Resources.Resources._24
        Me.btnBestellungen_abrufen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestellungen_abrufen.Location = New System.Drawing.Point(512, 97)
        Me.btnBestellungen_abrufen.Name = "btnBestellungen_abrufen"
        Me.btnBestellungen_abrufen.Size = New System.Drawing.Size(215, 23)
        Me.btnBestellungen_abrufen.TabIndex = 11
        Me.btnBestellungen_abrufen.Text = "Bestellungen ab&rufen"
        Me.ballonITips.SetToolTip(Me.btnBestellungen_abrufen, "Mit der rechten Maustaste auf einen Artikel erreichen Sie diverse Möglichkeiten z" &
        ".B." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ Artikelstatus " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - EiSo Shop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Shopste Subshop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ Delcampe Funktion" &
        "en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ eBay Funktionen")
        Me.btnBestellungen_abrufen.UseVisualStyleBackColor = False
        '
        'menue_shopste
        '
        Me.menue_shopste.Controls.Add(Me.SplitContainer1)
        Me.menue_shopste.Location = New System.Drawing.Point(4, 63)
        Me.menue_shopste.Name = "menue_shopste"
        Me.menue_shopste.Padding = New System.Windows.Forms.Padding(3)
        Me.menue_shopste.Size = New System.Drawing.Size(1150, 571)
        Me.menue_shopste.TabIndex = 12
        Me.menue_shopste.Text = "Shopste Artikeldatenbank"
        Me.menue_shopste.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbltmp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label33)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvwShopste)
        Me.SplitContainer1.Size = New System.Drawing.Size(1144, 565)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.ContextMenuStrip = Me.cmsShopsteKategorie
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(254, 565)
        Me.TreeView1.TabIndex = 1
        '
        'cmsShopsteKategorie
        '
        Me.cmsShopsteKategorie.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeueUnterkategorieShopAnlegenToolStripMenuItem, Me.SelektierteKategorieUmbennenToolStripMenuItem})
        Me.cmsShopsteKategorie.Name = "cmsShopsteKategorie"
        Me.cmsShopsteKategorie.Size = New System.Drawing.Size(270, 48)
        '
        'NeueUnterkategorieShopAnlegenToolStripMenuItem
        '
        Me.NeueUnterkategorieShopAnlegenToolStripMenuItem.Name = "NeueUnterkategorieShopAnlegenToolStripMenuItem"
        Me.NeueUnterkategorieShopAnlegenToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.NeueUnterkategorieShopAnlegenToolStripMenuItem.Text = "Neue Unterkategorie-Shop anlegen..."
        '
        'SelektierteKategorieUmbennenToolStripMenuItem
        '
        Me.SelektierteKategorieUmbennenToolStripMenuItem.Name = "SelektierteKategorieUmbennenToolStripMenuItem"
        Me.SelektierteKategorieUmbennenToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.SelektierteKategorieUmbennenToolStripMenuItem.Text = "Selektierte Kategorie umbennen..."
        '
        'lbltmp
        '
        Me.lbltmp.AutoSize = True
        Me.lbltmp.Location = New System.Drawing.Point(215, 22)
        Me.lbltmp.Name = "lbltmp"
        Me.lbltmp.Size = New System.Drawing.Size(0, 13)
        Me.lbltmp.TabIndex = 2
        Me.lbltmp.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(9, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(155, 18)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Kategorie Artikel"
        '
        'lvwShopste
        '
        Me.lvwShopste.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwShopste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwShopste.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.shopste_bild, Me.shopste_titel, Me.shopste_preis, Me.shopste_menge, Me.SeitenID, Me.ShopID, Me.Artikelnummer, Me.Aktiv})
        Me.lvwShopste.ContextMenuStrip = Me.cmsShopsteArtikel
        Me.lvwShopste.FullRowSelect = True
        Me.lvwShopste.GridLines = True
        Me.lvwShopste.HideSelection = False
        Me.lvwShopste.Location = New System.Drawing.Point(12, 42)
        Me.lvwShopste.Name = "lvwShopste"
        Me.lvwShopste.Size = New System.Drawing.Size(871, 520)
        Me.lvwShopste.SmallImageList = Me.ImageList1
        Me.lvwShopste.TabIndex = 0
        Me.lvwShopste.UseCompatibleStateImageBehavior = False
        Me.lvwShopste.View = System.Windows.Forms.View.Details
        '
        'shopste_bild
        '
        Me.shopste_bild.Text = "Bild"
        '
        'shopste_titel
        '
        Me.shopste_titel.Text = "Titel"
        Me.shopste_titel.Width = 240
        '
        'shopste_preis
        '
        Me.shopste_preis.Text = "Preis"
        '
        'shopste_menge
        '
        Me.shopste_menge.Text = "Menge"
        '
        'SeitenID
        '
        Me.SeitenID.Text = "SeitenID"
        Me.SeitenID.Width = 93
        '
        'ShopID
        '
        Me.ShopID.Text = "Shop Artikel ID"
        Me.ShopID.Width = 119
        '
        'Artikelnummer
        '
        Me.Artikelnummer.Text = "Artikelnummer"
        Me.Artikelnummer.Width = 120
        '
        'Aktiv
        '
        Me.Aktiv.Text = "Artikelstatus"
        Me.Aktiv.Width = 108
        '
        'cmsShopsteArtikel
        '
        Me.cmsShopsteArtikel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtikelÖffnenToolStripMenuItem, Me.ArtikelLöschenToolStripMenuItem5, Me.StatusToolStripMenuItem1, Me.MengeÄndernToolStripMenuItem})
        Me.cmsShopsteArtikel.Name = "cmsShopsteArtikel"
        Me.cmsShopsteArtikel.Size = New System.Drawing.Size(161, 92)
        '
        'ArtikelÖffnenToolStripMenuItem
        '
        Me.ArtikelÖffnenToolStripMenuItem.Name = "ArtikelÖffnenToolStripMenuItem"
        Me.ArtikelÖffnenToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ArtikelÖffnenToolStripMenuItem.Text = "Artikel öffnen"
        '
        'ArtikelLöschenToolStripMenuItem5
        '
        Me.ArtikelLöschenToolStripMenuItem5.Name = "ArtikelLöschenToolStripMenuItem5"
        Me.ArtikelLöschenToolStripMenuItem5.Size = New System.Drawing.Size(160, 22)
        Me.ArtikelLöschenToolStripMenuItem5.Text = "Artikel löschen"
        '
        'StatusToolStripMenuItem1
        '
        Me.StatusToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusverkauftToolStripMenuItem, Me.VerkaufsbereitToolStripMenuItem})
        Me.StatusToolStripMenuItem1.Name = "StatusToolStripMenuItem1"
        Me.StatusToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.StatusToolStripMenuItem1.Text = "Status"
        '
        'AusverkauftToolStripMenuItem
        '
        Me.AusverkauftToolStripMenuItem.Name = "AusverkauftToolStripMenuItem"
        Me.AusverkauftToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AusverkauftToolStripMenuItem.Text = "Ausverkauft"
        '
        'VerkaufsbereitToolStripMenuItem
        '
        Me.VerkaufsbereitToolStripMenuItem.Name = "VerkaufsbereitToolStripMenuItem"
        Me.VerkaufsbereitToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.VerkaufsbereitToolStripMenuItem.Text = "Verkaufsbereit"
        '
        'MengeÄndernToolStripMenuItem
        '
        Me.MengeÄndernToolStripMenuItem.Name = "MengeÄndernToolStripMenuItem"
        Me.MengeÄndernToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MengeÄndernToolStripMenuItem.Text = "Menge ändern..."
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'menue_artikelverwaltung
        '
        Me.menue_artikelverwaltung.Controls.Add(Me.tab_verwaltung)
        Me.menue_artikelverwaltung.ImageIndex = 17
        Me.menue_artikelverwaltung.Location = New System.Drawing.Point(4, 63)
        Me.menue_artikelverwaltung.Name = "menue_artikelverwaltung"
        Me.menue_artikelverwaltung.Padding = New System.Windows.Forms.Padding(3)
        Me.menue_artikelverwaltung.Size = New System.Drawing.Size(1150, 571)
        Me.menue_artikelverwaltung.TabIndex = 11
        Me.menue_artikelverwaltung.Text = "EiSo Shop Artikelverwaltung"
        Me.menue_artikelverwaltung.UseVisualStyleBackColor = True
        '
        'tab_verwaltung
        '
        Me.tab_verwaltung.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tab_verwaltung.Controls.Add(Me.eshop_daten)
        Me.tab_verwaltung.Controls.Add(Me.eshop_bestellungen)
        Me.tab_verwaltung.Controls.Add(Me.eshop_bilderprüfung)
        Me.tab_verwaltung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_verwaltung.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tab_verwaltung.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_verwaltung.ImageList = Me.imgAuktionsmanagement
        Me.tab_verwaltung.Location = New System.Drawing.Point(3, 3)
        Me.tab_verwaltung.Multiline = True
        Me.tab_verwaltung.Name = "tab_verwaltung"
        Me.tab_verwaltung.SelectedIndex = 0
        Me.tab_verwaltung.Size = New System.Drawing.Size(1144, 565)
        Me.tab_verwaltung.TabIndex = 22
        '
        'eshop_daten
        '
        Me.eshop_daten.BackColor = System.Drawing.Color.WhiteSmoke
        Me.eshop_daten.Controls.Add(Me.btnEiSoShop_artikel_neu)
        Me.eshop_daten.Controls.Add(Me.chkArtikeldatenbankBilderladen)
        Me.eshop_daten.Controls.Add(Me.chkArtikeldatenbank_edit)
        Me.eshop_daten.Controls.Add(Me.Label19)
        Me.eshop_daten.Controls.Add(Me.Label10)
        Me.eshop_daten.Controls.Add(Me.cmbSprache_Artikeldatenbank)
        Me.eshop_daten.Controls.Add(Me.chkShopUpdateItemCount)
        Me.eshop_daten.Controls.Add(Me.optCMSToogleBoth)
        Me.eshop_daten.Controls.Add(Me.optCMSToogleKategorie)
        Me.eshop_daten.Controls.Add(Me.optCMSToogleArtikel)
        Me.eshop_daten.Controls.Add(Me.Label23)
        Me.eshop_daten.Controls.Add(Me.cmbArtikelStatus)
        Me.eshop_daten.Controls.Add(Me.cms_splitcontainer)
        Me.eshop_daten.ImageIndex = 17
        Me.eshop_daten.Location = New System.Drawing.Point(4, 26)
        Me.eshop_daten.Name = "eshop_daten"
        Me.eshop_daten.Padding = New System.Windows.Forms.Padding(3)
        Me.eshop_daten.Size = New System.Drawing.Size(1136, 535)
        Me.eshop_daten.TabIndex = 0
        Me.eshop_daten.Text = "EiSo - Artikelverwaltung"
        '
        'btnEiSoShop_artikel_neu
        '
        Me.btnEiSoShop_artikel_neu.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnEiSoShop_artikel_neu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEiSoShop_artikel_neu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEiSoShop_artikel_neu.Image = Global.YabE.My.Resources.Resources._03
        Me.btnEiSoShop_artikel_neu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEiSoShop_artikel_neu.Location = New System.Drawing.Point(979, 29)
        Me.btnEiSoShop_artikel_neu.Name = "btnEiSoShop_artikel_neu"
        Me.btnEiSoShop_artikel_neu.Size = New System.Drawing.Size(154, 23)
        Me.btnEiSoShop_artikel_neu.TabIndex = 45
        Me.btnEiSoShop_artikel_neu.Text = "Neuer Artikel..."
        Me.btnEiSoShop_artikel_neu.UseVisualStyleBackColor = False
        '
        'chkArtikeldatenbankBilderladen
        '
        Me.chkArtikeldatenbankBilderladen.AutoSize = True
        Me.chkArtikeldatenbankBilderladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkArtikeldatenbankBilderladen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArtikeldatenbankBilderladen.Location = New System.Drawing.Point(974, 12)
        Me.chkArtikeldatenbankBilderladen.Name = "chkArtikeldatenbankBilderladen"
        Me.chkArtikeldatenbankBilderladen.Size = New System.Drawing.Size(156, 17)
        Me.chkArtikeldatenbankBilderladen.TabIndex = 44
        Me.chkArtikeldatenbankBilderladen.Text = "&Lade Vorschaubilder"
        Me.ballonITips.SetToolTip(Me.chkArtikeldatenbankBilderladen, "Aktiv öffnet Doppelklick Artikel bearbeiten anstatt Webansicht")
        Me.chkArtikeldatenbankBilderladen.UseVisualStyleBackColor = True
        '
        'chkArtikeldatenbank_edit
        '
        Me.chkArtikeldatenbank_edit.AutoSize = True
        Me.chkArtikeldatenbank_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkArtikeldatenbank_edit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArtikeldatenbank_edit.Location = New System.Drawing.Point(792, 12)
        Me.chkArtikeldatenbank_edit.Name = "chkArtikeldatenbank_edit"
        Me.chkArtikeldatenbank_edit.Size = New System.Drawing.Size(201, 17)
        Me.chkArtikeldatenbank_edit.TabIndex = 43
        Me.chkArtikeldatenbank_edit.Text = "&Editiermodus (Doppelklick)"
        Me.ballonITips.SetToolTip(Me.chkArtikeldatenbank_edit, "Aktiv öffnet Doppelklick Artikel bearbeiten anstatt Webansicht")
        Me.chkArtikeldatenbank_edit.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(335, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(219, 17)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Sprache auwählen"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ballonITips.SetToolTip(Me.Label19, "Ändert die Bassissprache (Beschreibung)")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(321, 23)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "EiSo Shop Artikelverwaltung"
        '
        'cmbSprache_Artikeldatenbank
        '
        Me.cmbSprache_Artikeldatenbank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSprache_Artikeldatenbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprache_Artikeldatenbank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprache_Artikeldatenbank.FormattingEnabled = True
        Me.cmbSprache_Artikeldatenbank.Location = New System.Drawing.Point(336, 31)
        Me.cmbSprache_Artikeldatenbank.Name = "cmbSprache_Artikeldatenbank"
        Me.cmbSprache_Artikeldatenbank.Size = New System.Drawing.Size(219, 21)
        Me.cmbSprache_Artikeldatenbank.TabIndex = 30
        '
        'chkShopUpdateItemCount
        '
        Me.chkShopUpdateItemCount.AutoSize = True
        Me.chkShopUpdateItemCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShopUpdateItemCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShopUpdateItemCount.Location = New System.Drawing.Point(792, 33)
        Me.chkShopUpdateItemCount.Name = "chkShopUpdateItemCount"
        Me.chkShopUpdateItemCount.Size = New System.Drawing.Size(188, 17)
        Me.chkShopUpdateItemCount.TabIndex = 29
        Me.chkShopUpdateItemCount.Text = "&Update Kategorie Anzahl "
        Me.ballonITips.SetToolTip(Me.chkShopUpdateItemCount, "Aktuallisiert beim Kategoriewechsel die Anzahl in der Kategorie")
        Me.chkShopUpdateItemCount.UseVisualStyleBackColor = True
        Me.chkShopUpdateItemCount.Visible = False
        '
        'optCMSToogleBoth
        '
        Me.optCMSToogleBoth.AutoSize = True
        Me.optCMSToogleBoth.Checked = True
        Me.optCMSToogleBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optCMSToogleBoth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCMSToogleBoth.Location = New System.Drawing.Point(235, 38)
        Me.optCMSToogleBoth.Name = "optCMSToogleBoth"
        Me.optCMSToogleBoth.Size = New System.Drawing.Size(67, 17)
        Me.optCMSToogleBoth.TabIndex = 28
        Me.optCMSToogleBoth.TabStop = True
        Me.optCMSToogleBoth.Text = "&Beides"
        Me.optCMSToogleBoth.UseVisualStyleBackColor = True
        '
        'optCMSToogleKategorie
        '
        Me.optCMSToogleKategorie.AutoSize = True
        Me.optCMSToogleKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optCMSToogleKategorie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCMSToogleKategorie.Location = New System.Drawing.Point(115, 38)
        Me.optCMSToogleKategorie.Name = "optCMSToogleKategorie"
        Me.optCMSToogleKategorie.Size = New System.Drawing.Size(114, 17)
        Me.optCMSToogleKategorie.TabIndex = 27
        Me.optCMSToogleKategorie.Text = "Nur &Kategorie"
        Me.optCMSToogleKategorie.UseVisualStyleBackColor = True
        '
        'optCMSToogleArtikel
        '
        Me.optCMSToogleArtikel.AutoSize = True
        Me.optCMSToogleArtikel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optCMSToogleArtikel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCMSToogleArtikel.Location = New System.Drawing.Point(14, 38)
        Me.optCMSToogleArtikel.Name = "optCMSToogleArtikel"
        Me.optCMSToogleArtikel.Size = New System.Drawing.Size(95, 17)
        Me.optCMSToogleArtikel.TabIndex = 26
        Me.optCMSToogleArtikel.Text = "Nur &Artikel"
        Me.optCMSToogleArtikel.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Silver
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(570, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(216, 17)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Zusätzliche Ansichten"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ballonITips.SetToolTip(Me.Label23, "Zeigen Sie sich nach Bestellstatus")
        '
        'cmbArtikelStatus
        '
        Me.cmbArtikelStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbArtikelStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArtikelStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbArtikelStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArtikelStatus.FormattingEnabled = True
        Me.cmbArtikelStatus.Items.AddRange(New Object() {"Kategorie", "Bestellt", "Warteliste", "Delcampe Lister Import", "Offne Übersetzungen", "Die neusten Artikel"})
        Me.cmbArtikelStatus.Location = New System.Drawing.Point(570, 32)
        Me.cmbArtikelStatus.Name = "cmbArtikelStatus"
        Me.cmbArtikelStatus.Size = New System.Drawing.Size(216, 21)
        Me.cmbArtikelStatus.TabIndex = 20
        '
        'cms_splitcontainer
        '
        Me.cms_splitcontainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cms_splitcontainer.Location = New System.Drawing.Point(6, 61)
        Me.cms_splitcontainer.Name = "cms_splitcontainer"
        '
        'cms_splitcontainer.Panel1
        '
        Me.cms_splitcontainer.Panel1.Controls.Add(Me.lvwMenue)
        '
        'cms_splitcontainer.Panel2
        '
        Me.cms_splitcontainer.Panel2.Controls.Add(Me.lvwWebArtikel)
        Me.cms_splitcontainer.Size = New System.Drawing.Size(1124, 470)
        Me.cms_splitcontainer.SplitterDistance = 328
        Me.cms_splitcontainer.TabIndex = 25
        '
        'lvwMenue
        '
        Me.lvwMenue.AllowColumnReorder = True
        Me.lvwMenue.AllowDrop = True
        Me.lvwMenue.BackColor = System.Drawing.Color.White
        Me.lvwMenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMenue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cms_kategorieID, Me.cms_menueName, Me.cms_clickcount, Me.cms_kategorie_delcampe, Me.cms_kategorie_magento, Me.cms_hauptkategorie, Me.cms_artikel, Me.cms_shopsteCat})
        Me.lvwMenue.ContextMenuStrip = Me.cms_KategorieListe
        Me.lvwMenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwMenue.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMenue.FullRowSelect = True
        Me.lvwMenue.GridLines = True
        Me.lvwMenue.HideSelection = False
        Me.lvwMenue.Location = New System.Drawing.Point(0, 0)
        Me.lvwMenue.Name = "lvwMenue"
        Me.lvwMenue.ShowItemToolTips = True
        Me.lvwMenue.Size = New System.Drawing.Size(328, 470)
        Me.lvwMenue.TabIndex = 18
        Me.lvwMenue.UseCompatibleStateImageBehavior = False
        Me.lvwMenue.View = System.Windows.Forms.View.Details
        '
        'cms_kategorieID
        '
        Me.cms_kategorieID.DisplayIndex = 3
        Me.cms_kategorieID.Width = 0
        '
        'cms_menueName
        '
        Me.cms_menueName.DisplayIndex = 0
        Me.cms_menueName.Text = "Name"
        Me.cms_menueName.Width = 250
        '
        'cms_clickcount
        '
        Me.cms_clickcount.Text = "Zugriffe"
        Me.cms_clickcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cms_clickcount.Width = 73
        '
        'cms_kategorie_delcampe
        '
        Me.cms_kategorie_delcampe.DisplayIndex = 4
        Me.cms_kategorie_delcampe.Text = "DelcampeID"
        Me.cms_kategorie_delcampe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cms_kategorie_magento
        '
        Me.cms_kategorie_magento.DisplayIndex = 5
        Me.cms_kategorie_magento.Text = "MagentoID"
        Me.cms_kategorie_magento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cms_hauptkategorie
        '
        Me.cms_hauptkategorie.DisplayIndex = 6
        Me.cms_hauptkategorie.Text = "Hauptkategorie"
        Me.cms_hauptkategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cms_hauptkategorie.Width = 0
        '
        'cms_artikel
        '
        Me.cms_artikel.DisplayIndex = 1
        Me.cms_artikel.Text = "Artikel"
        Me.cms_artikel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cms_shopsteCat
        '
        Me.cms_shopsteCat.Text = "Shopste Cat"
        '
        'cms_KategorieListe
        '
        Me.cms_KategorieListe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YABEImportVonArtikelnToolStripMenuItem1, Me.ToolStripMenuItem15, Me.ToolStripSeparator40, Me.KategorieHauptkategorieToolStripMenuItem, Me.KategorieNeueSubkategorieToolStripMenuItem, Me.NeueKatGleicheEbeneToolStripMenuItem, Me.ToolStripSeparator24, Me.UmbennenToolStripMenuItem, Me.KategorieLöschenToolStripMenuItem, Me.ToolStripSeparator20, Me.RefreshKategorielisteToolStripMenuItem, Me.SpracheToolStripMenuItem, Me.SortierungToolStripMenuItem, Me.ToolStripSeparator19, Me.DelcampeKategorieIDZuweisenToolStripMenuItem, Me.MagentoKategorieIDZuweisenToolStripMenuItem, Me.ShopsteKategorieToolStripMenuItem, Me.ToolStripSeparator26, Me.ExportDelcampeToolStripMenuItem1, Me.ExportMagentoToolStripMenuItem, Me.ExportStandardToolStripMenuItem1, Me.MenüÜbersetzungToolStripMenuItem, Me.MenüToolStripMenuItem, Me.ToolStripSeparator59, Me.EiSoShopKategorienZuShopstecomToolStripMenuItem, Me.ToolStripSeparator62})
        Me.cms_KategorieListe.Name = "cmsMenueListe"
        Me.cms_KategorieListe.Size = New System.Drawing.Size(404, 464)
        '
        'YABEImportVonArtikelnToolStripMenuItem1
        '
        Me.YABEImportVonArtikelnToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._19
        Me.YABEImportVonArtikelnToolStripMenuItem1.Name = "YABEImportVonArtikelnToolStripMenuItem1"
        Me.YABEImportVonArtikelnToolStripMenuItem1.Size = New System.Drawing.Size(403, 22)
        Me.YABEImportVonArtikelnToolStripMenuItem1.Text = "YABE -> Import von Artikeln..."
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Image = Global.YabE.My.Resources.Resources._03
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(403, 22)
        Me.ToolStripMenuItem15.Text = "Artikel -> &Neu anlegen..."
        '
        'ToolStripSeparator40
        '
        Me.ToolStripSeparator40.Name = "ToolStripSeparator40"
        Me.ToolStripSeparator40.Size = New System.Drawing.Size(400, 6)
        '
        'KategorieHauptkategorieToolStripMenuItem
        '
        Me.KategorieHauptkategorieToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.KategorieHauptkategorieToolStripMenuItem.Name = "KategorieHauptkategorieToolStripMenuItem"
        Me.KategorieHauptkategorieToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.KategorieHauptkategorieToolStripMenuItem.Text = "Neue Hauptkategorie"
        '
        'KategorieNeueSubkategorieToolStripMenuItem
        '
        Me.KategorieNeueSubkategorieToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.KategorieNeueSubkategorieToolStripMenuItem.Name = "KategorieNeueSubkategorieToolStripMenuItem"
        Me.KategorieNeueSubkategorieToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.KategorieNeueSubkategorieToolStripMenuItem.Text = "Neue Unterkategorie"
        '
        'NeueKatGleicheEbeneToolStripMenuItem
        '
        Me.NeueKatGleicheEbeneToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.NeueKatGleicheEbeneToolStripMenuItem.Name = "NeueKatGleicheEbeneToolStripMenuItem"
        Me.NeueKatGleicheEbeneToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.NeueKatGleicheEbeneToolStripMenuItem.Text = "Neue Kategorie gleiche Ebene"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(400, 6)
        '
        'UmbennenToolStripMenuItem
        '
        Me.UmbennenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_edit1
        Me.UmbennenToolStripMenuItem.Name = "UmbennenToolStripMenuItem"
        Me.UmbennenToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.UmbennenToolStripMenuItem.Text = "Kateogrie -> &umbenennen..."
        '
        'KategorieLöschenToolStripMenuItem
        '
        Me.KategorieLöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.KategorieLöschenToolStripMenuItem.Name = "KategorieLöschenToolStripMenuItem"
        Me.KategorieLöschenToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.KategorieLöschenToolStripMenuItem.Text = "Kateogrie -> &löschen"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(400, 6)
        '
        'RefreshKategorielisteToolStripMenuItem
        '
        Me.RefreshKategorielisteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnzahlUpdatenToolStripMenuItem})
        Me.RefreshKategorielisteToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.RefreshKategorielisteToolStripMenuItem.Name = "RefreshKategorielisteToolStripMenuItem"
        Me.RefreshKategorielisteToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.RefreshKategorielisteToolStripMenuItem.Text = "&Menü -> aktualisieren"
        '
        'AnzahlUpdatenToolStripMenuItem
        '
        Me.AnzahlUpdatenToolStripMenuItem.Name = "AnzahlUpdatenToolStripMenuItem"
        Me.AnzahlUpdatenToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AnzahlUpdatenToolStripMenuItem.Text = "Artikelanzahl erneuern"
        '
        'SpracheToolStripMenuItem
        '
        Me.SpracheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeutschToolStripMenuItem, Me.EnglischToolStripMenuItem, Me.FranzösichToolStripMenuItem, Me.ToolStripSeparator48, Me.AutomatischSpracheÄndernToolStripMenuItem})
        Me.SpracheToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.SpracheToolStripMenuItem.Name = "SpracheToolStripMenuItem"
        Me.SpracheToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.SpracheToolStripMenuItem.Text = "Menü&sprache"
        '
        'DeutschToolStripMenuItem
        '
        Me.DeutschToolStripMenuItem.Name = "DeutschToolStripMenuItem"
        Me.DeutschToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.DeutschToolStripMenuItem.Text = "&Deutsch"
        '
        'EnglischToolStripMenuItem
        '
        Me.EnglischToolStripMenuItem.Name = "EnglischToolStripMenuItem"
        Me.EnglischToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.EnglischToolStripMenuItem.Text = "&Englisch"
        '
        'FranzösichToolStripMenuItem
        '
        Me.FranzösichToolStripMenuItem.Name = "FranzösichToolStripMenuItem"
        Me.FranzösichToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.FranzösichToolStripMenuItem.Text = "Französich"
        '
        'ToolStripSeparator48
        '
        Me.ToolStripSeparator48.Name = "ToolStripSeparator48"
        Me.ToolStripSeparator48.Size = New System.Drawing.Size(224, 6)
        '
        'AutomatischSpracheÄndernToolStripMenuItem
        '
        Me.AutomatischSpracheÄndernToolStripMenuItem.Name = "AutomatischSpracheÄndernToolStripMenuItem"
        Me.AutomatischSpracheÄndernToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AutomatischSpracheÄndernToolStripMenuItem.Text = "Automatisch Sprache ändern"
        '
        'SortierungToolStripMenuItem
        '
        Me.SortierungToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HochToolStripMenuItem, Me.RunterToolStripMenuItem})
        Me.SortierungToolStripMenuItem.Name = "SortierungToolStripMenuItem"
        Me.SortierungToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.SortierungToolStripMenuItem.Text = "Sortierung "
        '
        'HochToolStripMenuItem
        '
        Me.HochToolStripMenuItem.Name = "HochToolStripMenuItem"
        Me.HochToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.HochToolStripMenuItem.Text = "Hoch"
        '
        'RunterToolStripMenuItem
        '
        Me.RunterToolStripMenuItem.Name = "RunterToolStripMenuItem"
        Me.RunterToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.RunterToolStripMenuItem.Text = "Runter"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(400, 6)
        '
        'DelcampeKategorieIDZuweisenToolStripMenuItem
        '
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem.Name = "DelcampeKategorieIDZuweisenToolStripMenuItem"
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem.Text = "Zuordnung -> Delcampe"
        '
        'MagentoKategorieIDZuweisenToolStripMenuItem
        '
        Me.MagentoKategorieIDZuweisenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.MagentoKategorieIDZuweisenToolStripMenuItem.Name = "MagentoKategorieIDZuweisenToolStripMenuItem"
        Me.MagentoKategorieIDZuweisenToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.MagentoKategorieIDZuweisenToolStripMenuItem.Text = "Zuordnung -> Magento"
        '
        'ShopsteKategorieToolStripMenuItem
        '
        Me.ShopsteKategorieToolStripMenuItem.Name = "ShopsteKategorieToolStripMenuItem"
        Me.ShopsteKategorieToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.ShopsteKategorieToolStripMenuItem.Text = "Zuordnung -> Shopste Kategorie..."
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(400, 6)
        '
        'ExportDelcampeToolStripMenuItem1
        '
        Me.ExportDelcampeToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportDelcampeToolStripMenuItem1.Name = "ExportDelcampeToolStripMenuItem1"
        Me.ExportDelcampeToolStripMenuItem1.Size = New System.Drawing.Size(403, 22)
        Me.ExportDelcampeToolStripMenuItem1.Text = "Export -> Delcampe..."
        '
        'ExportMagentoToolStripMenuItem
        '
        Me.ExportMagentoToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportMagentoToolStripMenuItem.Name = "ExportMagentoToolStripMenuItem"
        Me.ExportMagentoToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.ExportMagentoToolStripMenuItem.Text = "Export -> Magento..."
        '
        'ExportStandardToolStripMenuItem1
        '
        Me.ExportStandardToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportStandardToolStripMenuItem1.Name = "ExportStandardToolStripMenuItem1"
        Me.ExportStandardToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportStandardToolStripMenuItem1.Size = New System.Drawing.Size(403, 22)
        Me.ExportStandardToolStripMenuItem1.Text = "Export -> Standard..."
        '
        'MenüÜbersetzungToolStripMenuItem
        '
        Me.MenüÜbersetzungToolStripMenuItem.Name = "MenüÜbersetzungToolStripMenuItem"
        Me.MenüÜbersetzungToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.MenüÜbersetzungToolStripMenuItem.Text = "Übersetzung -> Menü"
        '
        'MenüToolStripMenuItem
        '
        Me.MenüToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HatUntekategorieToolStripMenuItem, Me.KeineUnterkategorieToolStripMenuItem})
        Me.MenüToolStripMenuItem.Name = "MenüToolStripMenuItem"
        Me.MenüToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.MenüToolStripMenuItem.Text = "Menü Baum"
        '
        'HatUntekategorieToolStripMenuItem
        '
        Me.HatUntekategorieToolStripMenuItem.Name = "HatUntekategorieToolStripMenuItem"
        Me.HatUntekategorieToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.HatUntekategorieToolStripMenuItem.Text = "Hat Untekategorie"
        '
        'KeineUnterkategorieToolStripMenuItem
        '
        Me.KeineUnterkategorieToolStripMenuItem.Name = "KeineUnterkategorieToolStripMenuItem"
        Me.KeineUnterkategorieToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.KeineUnterkategorieToolStripMenuItem.Text = "Keine Unterkategorie"
        '
        'ToolStripSeparator59
        '
        Me.ToolStripSeparator59.Name = "ToolStripSeparator59"
        Me.ToolStripSeparator59.Size = New System.Drawing.Size(400, 6)
        '
        'EiSoShopKategorienZuShopstecomToolStripMenuItem
        '
        Me.EiSoShopKategorienZuShopstecomToolStripMenuItem.Name = "EiSoShopKategorienZuShopstecomToolStripMenuItem"
        Me.EiSoShopKategorienZuShopstecomToolStripMenuItem.Size = New System.Drawing.Size(403, 22)
        Me.EiSoShopKategorienZuShopstecomToolStripMenuItem.Text = "SYNC -> EiSo Shop Kategorien zu Shopste Subshop generieren"
        '
        'ToolStripSeparator62
        '
        Me.ToolStripSeparator62.Name = "ToolStripSeparator62"
        Me.ToolStripSeparator62.Size = New System.Drawing.Size(400, 6)
        '
        'lvwWebArtikel
        '
        Me.lvwWebArtikel.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwWebArtikel.AllowColumnReorder = True
        Me.lvwWebArtikel.AllowDrop = True
        Me.lvwWebArtikel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwWebArtikel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwWebArtikel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Beschreibung, Me.Preis, Me.Bild, Me.magento_id, Me.delcampe_id, Me.cms_datum, Me.cmsBlidCounter, Me.cmsStatus, Me.cmsAnzahl, Me.eiso_bild_name, Me.cmsEiSoMenuID, Me.cmsShopsteCat, Me.cmsShopste_id, Me.cmdShopste_lagerbestand, Me.cmsShopste_eingestellt_am})
        Me.lvwWebArtikel.ContextMenuStrip = Me.cms_ArtikelVerwaltung
        Me.lvwWebArtikel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwWebArtikel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwWebArtikel.FullRowSelect = True
        Me.lvwWebArtikel.GridLines = True
        Me.lvwWebArtikel.HideSelection = False
        Me.lvwWebArtikel.LargeImageList = Me.bilder_history
        Me.lvwWebArtikel.Location = New System.Drawing.Point(0, 0)
        Me.lvwWebArtikel.Name = "lvwWebArtikel"
        Me.lvwWebArtikel.ShowItemToolTips = True
        Me.lvwWebArtikel.Size = New System.Drawing.Size(792, 470)
        Me.lvwWebArtikel.SmallImageList = Me.bilder_history
        Me.lvwWebArtikel.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwWebArtikel.TabIndex = 13
        Me.lvwWebArtikel.UseCompatibleStateImageBehavior = False
        Me.lvwWebArtikel.View = System.Windows.Forms.View.Details
        Me.lvwWebArtikel.VirtualListSize = 5000
        '
        'ID
        '
        Me.ID.Text = "WebID"
        '
        'Beschreibung
        '
        Me.Beschreibung.DisplayIndex = 6
        Me.Beschreibung.Text = "Beschreibung"
        Me.Beschreibung.Width = 475
        '
        'Preis
        '
        Me.Preis.DisplayIndex = 7
        Me.Preis.Text = "Preis"
        Me.Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Preis.Width = 51
        '
        'Bild
        '
        Me.Bild.DisplayIndex = 9
        Me.Bild.Text = "Bild"
        Me.Bild.Width = 0
        '
        'magento_id
        '
        Me.magento_id.DisplayIndex = 10
        Me.magento_id.Text = "MagentoID"
        Me.magento_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.magento_id.Width = 78
        '
        'delcampe_id
        '
        Me.delcampe_id.DisplayIndex = 2
        Me.delcampe_id.Text = "DelcampeID"
        Me.delcampe_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.delcampe_id.Width = 50
        '
        'cms_datum
        '
        Me.cms_datum.DisplayIndex = 8
        Me.cms_datum.Text = "Datum"
        Me.cms_datum.Width = 82
        '
        'cmsBlidCounter
        '
        Me.cmsBlidCounter.DisplayIndex = 3
        Me.cmsBlidCounter.Text = "Counter"
        Me.cmsBlidCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmsStatus
        '
        Me.cmsStatus.DisplayIndex = 5
        Me.cmsStatus.Text = "Status"
        Me.cmsStatus.Width = 49
        '
        'cmsAnzahl
        '
        Me.cmsAnzahl.DisplayIndex = 1
        Me.cmsAnzahl.Text = "Anzahl"
        '
        'eiso_bild_name
        '
        Me.eiso_bild_name.DisplayIndex = 11
        Me.eiso_bild_name.Text = "Bild"
        Me.eiso_bild_name.Width = 120
        '
        'cmsEiSoMenuID
        '
        Me.cmsEiSoMenuID.DisplayIndex = 12
        Me.cmsEiSoMenuID.Text = "Menü ID"
        '
        'cmsShopsteCat
        '
        Me.cmsShopsteCat.DisplayIndex = 13
        Me.cmsShopsteCat.Text = "ShopsteCat"
        '
        'cmsShopste_id
        '
        Me.cmsShopste_id.DisplayIndex = 14
        Me.cmsShopste_id.Text = "SID"
        '
        'cmdShopste_lagerbestand
        '
        Me.cmdShopste_lagerbestand.DisplayIndex = 15
        Me.cmdShopste_lagerbestand.Text = "SLager"
        '
        'cmsShopste_eingestellt_am
        '
        Me.cmsShopste_eingestellt_am.DisplayIndex = 4
        Me.cmsShopste_eingestellt_am.Text = "SEingestellt"
        '
        'cms_ArtikelVerwaltung
        '
        Me.cms_ArtikelVerwaltung.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuerArtikelToolStripMenuItem, Me.ÜberarbeitenToolStripMenuItem, Me.ArtikelLöschenToolStripMenuItem1, Me.ArtikelSuchenUndErsetzenToolStripMenuItem, Me.ToolStripSeparator6, Me.EBayArtikelEinstellenToolStripMenuItem, Me.ExportStandardToolStripMenuItem, Me.YABEImportVonArtikelnToolStripMenuItem, Me.ArtikelAlleImportiertenLöschenToolStripMenuItem, Me.ToolStripSeparator60, Me.AktuallisierenToolStripMenuItem, Me.WebEBayBildAnsehenToolStripMenuItem, Me.AlleMarkierenToolStripMenuItem, Me.ToolStripTextBox1, Me.ToolStripSeparator44, Me.MagentoToolStripMenuItem, Me.ToolStripSeparator45, Me.StatusToolStripMenuItem, Me.SpracheZurücksetzenToolStripMenuItem, Me.ToolStripSeparator22, Me.ExportDelcampeToolStripMenuItem, Me.EiSo2ShopsteArtikelImportToolStripMenuItem, Me.SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem, Me.ToolStripSeparator21, Me.ArtikelShopsteKategorieZuweisenToolStripMenuItem, Me.DelcampeKategorieIDZuweisenToolStripMenuItem1, Me.MagentoKategorieIDZuweisenToolStripMenuItem1, Me.ToolStripSeparator14, Me.ExportierenToolStripMenuItem5, Me.ToolStripSeparator23, Me.ToolBilderprüfenToolStripMenuItem, Me.WebSucheBeiGoogleToolStripMenuItem, Me.ToolStripSeparator61})
        Me.cms_ArtikelVerwaltung.Name = "cmsBilderPrüfung"
        Me.cms_ArtikelVerwaltung.Size = New System.Drawing.Size(400, 589)
        '
        'NeuerArtikelToolStripMenuItem
        '
        Me.NeuerArtikelToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.NeuerArtikelToolStripMenuItem.Name = "NeuerArtikelToolStripMenuItem"
        Me.NeuerArtikelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuerArtikelToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.NeuerArtikelToolStripMenuItem.Text = "Artikel -> &Neu..."
        '
        'ÜberarbeitenToolStripMenuItem
        '
        Me.ÜberarbeitenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.tab_edit
        Me.ÜberarbeitenToolStripMenuItem.Name = "ÜberarbeitenToolStripMenuItem"
        Me.ÜberarbeitenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ÜberarbeitenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.ÜberarbeitenToolStripMenuItem.Text = "Artikel -> &Editieren..."
        '
        'ArtikelLöschenToolStripMenuItem1
        '
        Me.ArtikelLöschenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.ArtikelLöschenToolStripMenuItem1.Name = "ArtikelLöschenToolStripMenuItem1"
        Me.ArtikelLöschenToolStripMenuItem1.Size = New System.Drawing.Size(399, 22)
        Me.ArtikelLöschenToolStripMenuItem1.Text = "Artikel -> Löschen"
        '
        'ArtikelSuchenUndErsetzenToolStripMenuItem
        '
        Me.ArtikelSuchenUndErsetzenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._19
        Me.ArtikelSuchenUndErsetzenToolStripMenuItem.Name = "ArtikelSuchenUndErsetzenToolStripMenuItem"
        Me.ArtikelSuchenUndErsetzenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.ArtikelSuchenUndErsetzenToolStripMenuItem.Text = "Artikel -> Suchen und ersetzen..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(396, 6)
        '
        'EBayArtikelEinstellenToolStripMenuItem
        '
        Me.EBayArtikelEinstellenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.icon_ebay
        Me.EBayArtikelEinstellenToolStripMenuItem.Name = "EBayArtikelEinstellenToolStripMenuItem"
        Me.EBayArtikelEinstellenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.EBayArtikelEinstellenToolStripMenuItem.Text = "eBay -> Artikel einstellen..."
        '
        'ExportStandardToolStripMenuItem
        '
        Me.ExportStandardToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportStandardToolStripMenuItem.Name = "ExportStandardToolStripMenuItem"
        Me.ExportStandardToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportStandardToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.ExportStandardToolStripMenuItem.Text = "Export -> &Delcampe Lister..."
        Me.ExportStandardToolStripMenuItem.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'YABEImportVonArtikelnToolStripMenuItem
        '
        Me.YABEImportVonArtikelnToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.time_go
        Me.YABEImportVonArtikelnToolStripMenuItem.Name = "YABEImportVonArtikelnToolStripMenuItem"
        Me.YABEImportVonArtikelnToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.YABEImportVonArtikelnToolStripMenuItem.Text = "YABE -> Import von Artikeln..."
        '
        'ArtikelAlleImportiertenLöschenToolStripMenuItem
        '
        Me.ArtikelAlleImportiertenLöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.delete
        Me.ArtikelAlleImportiertenLöschenToolStripMenuItem.Name = "ArtikelAlleImportiertenLöschenToolStripMenuItem"
        Me.ArtikelAlleImportiertenLöschenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.ArtikelAlleImportiertenLöschenToolStripMenuItem.Text = "Artikel -> Alle importierten löschen"
        '
        'ToolStripSeparator60
        '
        Me.ToolStripSeparator60.Name = "ToolStripSeparator60"
        Me.ToolStripSeparator60.Size = New System.Drawing.Size(396, 6)
        '
        'AktuallisierenToolStripMenuItem
        '
        Me.AktuallisierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.AktuallisierenToolStripMenuItem.Name = "AktuallisierenToolStripMenuItem"
        Me.AktuallisierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AktuallisierenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.AktuallisierenToolStripMenuItem.Text = "Artikelliste -> &Aktuallisieren"
        '
        'WebEBayBildAnsehenToolStripMenuItem
        '
        Me.WebEBayBildAnsehenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop21
        Me.WebEBayBildAnsehenToolStripMenuItem.Name = "WebEBayBildAnsehenToolStripMenuItem"
        Me.WebEBayBildAnsehenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.WebEBayBildAnsehenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.WebEBayBildAnsehenToolStripMenuItem.Text = "Artikel -> &Vorschau anzeigen"
        '
        'AlleMarkierenToolStripMenuItem
        '
        Me.AlleMarkierenToolStripMenuItem.Name = "AlleMarkierenToolStripMenuItem"
        Me.AlleMarkierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AlleMarkierenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.AlleMarkierenToolStripMenuItem.Text = "Alle Artikel Markieren"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(250, 23)
        Me.ToolStripTextBox1.ToolTipText = "Bitte Suchbegriff eintragen und Leertaste oder Enter drücken"
        '
        'ToolStripSeparator44
        '
        Me.ToolStripSeparator44.Name = "ToolStripSeparator44"
        Me.ToolStripSeparator44.Size = New System.Drawing.Size(396, 6)
        '
        'MagentoToolStripMenuItem
        '
        Me.MagentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtikelHinzufügenToolStripMenuItem, Me.ArtikelLöschenToolStripMenuItem2, Me.ArtikelBestelltToolStripMenuItem, Me.ArtikelAktivToolStripMenuItem})
        Me.MagentoToolStripMenuItem.Name = "MagentoToolStripMenuItem"
        Me.MagentoToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.MagentoToolStripMenuItem.Text = "Magento Status"
        '
        'ArtikelHinzufügenToolStripMenuItem
        '
        Me.ArtikelHinzufügenToolStripMenuItem.Name = "ArtikelHinzufügenToolStripMenuItem"
        Me.ArtikelHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ArtikelHinzufügenToolStripMenuItem.Text = "Artikel hinzufügen"
        '
        'ArtikelLöschenToolStripMenuItem2
        '
        Me.ArtikelLöschenToolStripMenuItem2.Name = "ArtikelLöschenToolStripMenuItem2"
        Me.ArtikelLöschenToolStripMenuItem2.Size = New System.Drawing.Size(171, 22)
        Me.ArtikelLöschenToolStripMenuItem2.Text = "Artikel löschen"
        '
        'ArtikelBestelltToolStripMenuItem
        '
        Me.ArtikelBestelltToolStripMenuItem.Name = "ArtikelBestelltToolStripMenuItem"
        Me.ArtikelBestelltToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ArtikelBestelltToolStripMenuItem.Text = "Artikel bestellt"
        '
        'ArtikelAktivToolStripMenuItem
        '
        Me.ArtikelAktivToolStripMenuItem.Name = "ArtikelAktivToolStripMenuItem"
        Me.ArtikelAktivToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ArtikelAktivToolStripMenuItem.Text = "Artikel aktivieren"
        '
        'ToolStripSeparator45
        '
        Me.ToolStripSeparator45.Name = "ToolStripSeparator45"
        Me.ToolStripSeparator45.Size = New System.Drawing.Size(396, 6)
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AktuellToolStripMenuItem, Me.BestelltToolStripMenuItem, Me.AussortiertToolStripMenuItem, Me.DelcampeListerToolStripMenuItem})
        Me.StatusToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.StatusToolStripMenuItem.Text = "Artikel -> &Status ändern"
        '
        'AktuellToolStripMenuItem
        '
        Me.AktuellToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.AktuellToolStripMenuItem.Name = "AktuellToolStripMenuItem"
        Me.AktuellToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.AktuellToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AktuellToolStripMenuItem.Text = "&Aktuell"
        '
        'BestelltToolStripMenuItem
        '
        Me.BestelltToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.BestelltToolStripMenuItem.Name = "BestelltToolStripMenuItem"
        Me.BestelltToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BestelltToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.BestelltToolStripMenuItem.Text = "&Bestellt"
        '
        'AussortiertToolStripMenuItem
        '
        Me.AussortiertToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.AussortiertToolStripMenuItem.Name = "AussortiertToolStripMenuItem"
        Me.AussortiertToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.AussortiertToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AussortiertToolStripMenuItem.Text = "Aussortiert"
        '
        'DelcampeListerToolStripMenuItem
        '
        Me.DelcampeListerToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.save
        Me.DelcampeListerToolStripMenuItem.Name = "DelcampeListerToolStripMenuItem"
        Me.DelcampeListerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.DelcampeListerToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DelcampeListerToolStripMenuItem.Text = "Delcampe Lister"
        '
        'SpracheZurücksetzenToolStripMenuItem
        '
        Me.SpracheZurücksetzenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FehlendeÜbersetzungenHolenToolStripMenuItem, Me.ToolStripSeparator43, Me.YABEWebtranslatorToolStripMenuItem})
        Me.SpracheZurücksetzenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.SpracheZurücksetzenToolStripMenuItem.Name = "SpracheZurücksetzenToolStripMenuItem"
        Me.SpracheZurücksetzenToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.SpracheZurücksetzenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.SpracheZurücksetzenToolStripMenuItem.Text = "&Übersetzung -> Sprache zurücksetzen"
        '
        'FehlendeÜbersetzungenHolenToolStripMenuItem
        '
        Me.FehlendeÜbersetzungenHolenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop21
        Me.FehlendeÜbersetzungenHolenToolStripMenuItem.Name = "FehlendeÜbersetzungenHolenToolStripMenuItem"
        Me.FehlendeÜbersetzungenHolenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.FehlendeÜbersetzungenHolenToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.FehlendeÜbersetzungenHolenToolStripMenuItem.Text = "Übersetzung -> fehlende  Übersetzungen holen"
        '
        'ToolStripSeparator43
        '
        Me.ToolStripSeparator43.Name = "ToolStripSeparator43"
        Me.ToolStripSeparator43.Size = New System.Drawing.Size(363, 6)
        Me.ToolStripSeparator43.Visible = False
        '
        'YABEWebtranslatorToolStripMenuItem
        '
        Me.YABEWebtranslatorToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.YABEWebtranslatorToolStripMenuItem.Name = "YABEWebtranslatorToolStripMenuItem"
        Me.YABEWebtranslatorToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.YABEWebtranslatorToolStripMenuItem.Text = "&Übersetzung -> Server Webtranslator"
        Me.YABEWebtranslatorToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(396, 6)
        '
        'ExportDelcampeToolStripMenuItem
        '
        Me.ExportDelcampeToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportDelcampeToolStripMenuItem.Name = "ExportDelcampeToolStripMenuItem"
        Me.ExportDelcampeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ExportDelcampeToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.ExportDelcampeToolStripMenuItem.Text = "Export -> &Delcampe Lister..."
        Me.ExportDelcampeToolStripMenuItem.ToolTipText = "Exportiert die Daten im Delcampe Format..."
        '
        'EiSo2ShopsteArtikelImportToolStripMenuItem
        '
        Me.EiSo2ShopsteArtikelImportToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.EiSo2ShopsteArtikelImportToolStripMenuItem.Name = "EiSo2ShopsteArtikelImportToolStripMenuItem"
        Me.EiSo2ShopsteArtikelImportToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.EiSo2ShopsteArtikelImportToolStripMenuItem.Text = "SYNC -> Shopste Subshop -> Artikel übertragen..."
        '
        'SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem
        '
        Me.SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem.Name = "SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem"
        Me.SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem.Text = "SYNC -> Shopste.com -> Martplatz Artikel einstellen"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(396, 6)
        '
        'ArtikelShopsteKategorieZuweisenToolStripMenuItem
        '
        Me.ArtikelShopsteKategorieZuweisenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.ArtikelShopsteKategorieZuweisenToolStripMenuItem.Name = "ArtikelShopsteKategorieZuweisenToolStripMenuItem"
        Me.ArtikelShopsteKategorieZuweisenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.ArtikelShopsteKategorieZuweisenToolStripMenuItem.Text = "Zuordnung -> Shopste Marktplatz Kategorie..."
        '
        'DelcampeKategorieIDZuweisenToolStripMenuItem1
        '
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._03
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Name = "DelcampeKategorieIDZuweisenToolStripMenuItem1"
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Size = New System.Drawing.Size(399, 22)
        Me.DelcampeKategorieIDZuweisenToolStripMenuItem1.Text = "Zuordnung -> Delcampe Artikel ID..."
        '
        'MagentoKategorieIDZuweisenToolStripMenuItem1
        '
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._03
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Name = "MagentoKategorieIDZuweisenToolStripMenuItem1"
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Size = New System.Drawing.Size(399, 22)
        Me.MagentoKategorieIDZuweisenToolStripMenuItem1.Text = "Zuordnung -> Magento -> Kategorie Artikel ID..."
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(396, 6)
        '
        'ExportierenToolStripMenuItem5
        '
        Me.ExportierenToolStripMenuItem5.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportierenToolStripMenuItem5.Name = "ExportierenToolStripMenuItem5"
        Me.ExportierenToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ExportierenToolStripMenuItem5.Size = New System.Drawing.Size(399, 22)
        Me.ExportierenToolStripMenuItem5.Text = "Export -> &Magento..."
        Me.ExportierenToolStripMenuItem5.ToolTipText = "Exportiert die Daten im Magento *.CSV Format"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(396, 6)
        '
        'ToolBilderprüfenToolStripMenuItem
        '
        Me.ToolBilderprüfenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.options
        Me.ToolBilderprüfenToolStripMenuItem.Name = "ToolBilderprüfenToolStripMenuItem"
        Me.ToolBilderprüfenToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.ToolBilderprüfenToolStripMenuItem.Text = "Tool -> &Bilderprüfen (Selbstprüfung)"
        Me.ToolBilderprüfenToolStripMenuItem.ToolTipText = "Überprüft ob die Bilder noch existieren"
        '
        'WebSucheBeiGoogleToolStripMenuItem
        '
        Me.WebSucheBeiGoogleToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.WebSucheBeiGoogleToolStripMenuItem.Name = "WebSucheBeiGoogleToolStripMenuItem"
        Me.WebSucheBeiGoogleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.WebSucheBeiGoogleToolStripMenuItem.Size = New System.Drawing.Size(399, 22)
        Me.WebSucheBeiGoogleToolStripMenuItem.Text = "Web -> Suche bei Google "
        Me.WebSucheBeiGoogleToolStripMenuItem.ToolTipText = "Sucht nach der Artikelbeschreibung bei Google"
        '
        'ToolStripSeparator61
        '
        Me.ToolStripSeparator61.Name = "ToolStripSeparator61"
        Me.ToolStripSeparator61.Size = New System.Drawing.Size(396, 6)
        '
        'eshop_bestellungen
        '
        Me.eshop_bestellungen.BackColor = System.Drawing.Color.Gainsboro
        Me.eshop_bestellungen.Controls.Add(Me.btnGetCMSBestellungen)
        Me.eshop_bestellungen.Controls.Add(Me.lvwGetBestellungen)
        Me.eshop_bestellungen.ImageIndex = 18
        Me.eshop_bestellungen.Location = New System.Drawing.Point(4, 26)
        Me.eshop_bestellungen.Name = "eshop_bestellungen"
        Me.eshop_bestellungen.Padding = New System.Windows.Forms.Padding(3)
        Me.eshop_bestellungen.Size = New System.Drawing.Size(1136, 535)
        Me.eshop_bestellungen.TabIndex = 1
        Me.eshop_bestellungen.Text = "EiSo - Bestellungen"
        Me.eshop_bestellungen.UseVisualStyleBackColor = True
        '
        'btnGetCMSBestellungen
        '
        Me.btnGetCMSBestellungen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGetCMSBestellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetCMSBestellungen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCMSBestellungen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetCMSBestellungen.ImageIndex = 17
        Me.btnGetCMSBestellungen.ImageList = Me.imgAuktionsmanagement
        Me.btnGetCMSBestellungen.Location = New System.Drawing.Point(6, 6)
        Me.btnGetCMSBestellungen.Name = "btnGetCMSBestellungen"
        Me.btnGetCMSBestellungen.Size = New System.Drawing.Size(324, 23)
        Me.btnGetCMSBestellungen.TabIndex = 16
        Me.btnGetCMSBestellungen.Text = "&Bestellungen abrufen"
        Me.btnGetCMSBestellungen.UseVisualStyleBackColor = False
        '
        'lvwGetBestellungen
        '
        Me.lvwGetBestellungen.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwGetBestellungen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwGetBestellungen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwGetBestellungen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwGetBestellungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.bestellungen_id, Me.bestellungen_name, Me.bestellung_artikel, Me.bestellung_bezahlmethode, Me.bestellungen_endsumme, Me.bestellungen_zeitpunkt, Me.bestellungen_woher})
        Me.lvwGetBestellungen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwGetBestellungen.FullRowSelect = True
        Me.lvwGetBestellungen.GridLines = True
        Me.lvwGetBestellungen.HideSelection = False
        Me.lvwGetBestellungen.Location = New System.Drawing.Point(6, 35)
        Me.lvwGetBestellungen.Name = "lvwGetBestellungen"
        Me.lvwGetBestellungen.Size = New System.Drawing.Size(1114, 494)
        Me.lvwGetBestellungen.TabIndex = 14
        Me.lvwGetBestellungen.UseCompatibleStateImageBehavior = False
        Me.lvwGetBestellungen.View = System.Windows.Forms.View.Details
        '
        'bestellungen_id
        '
        Me.bestellungen_id.Text = "ID"
        '
        'bestellungen_name
        '
        Me.bestellungen_name.Text = "Name"
        Me.bestellungen_name.Width = 153
        '
        'bestellung_artikel
        '
        Me.bestellung_artikel.Text = "Artikel"
        Me.bestellung_artikel.Width = 260
        '
        'bestellung_bezahlmethode
        '
        Me.bestellung_bezahlmethode.Text = "Bezahlmethode"
        Me.bestellung_bezahlmethode.Width = 147
        '
        'bestellungen_endsumme
        '
        Me.bestellungen_endsumme.Text = "Endsumme"
        Me.bestellungen_endsumme.Width = 137
        '
        'bestellungen_zeitpunkt
        '
        Me.bestellungen_zeitpunkt.Text = "Zeitpunkt"
        Me.bestellungen_zeitpunkt.Width = 124
        '
        'bestellungen_woher
        '
        Me.bestellungen_woher.Text = "Woher gekommen"
        Me.bestellungen_woher.Width = 136
        '
        'eshop_bilderprüfung
        '
        Me.eshop_bilderprüfung.BackColor = System.Drawing.Color.Gainsboro
        Me.eshop_bilderprüfung.Controls.Add(Me.btnPrüfeWebArtikel)
        Me.eshop_bilderprüfung.Controls.Add(Me.btnCheckPictures)
        Me.eshop_bilderprüfung.Controls.Add(Me.btnTools_eBayGalerie)
        Me.eshop_bilderprüfung.Controls.Add(Me.lvweBayGalerie)
        Me.eshop_bilderprüfung.ImageIndex = 20
        Me.eshop_bilderprüfung.Location = New System.Drawing.Point(4, 26)
        Me.eshop_bilderprüfung.Name = "eshop_bilderprüfung"
        Me.eshop_bilderprüfung.Padding = New System.Windows.Forms.Padding(3)
        Me.eshop_bilderprüfung.Size = New System.Drawing.Size(1136, 535)
        Me.eshop_bilderprüfung.TabIndex = 13
        Me.eshop_bilderprüfung.Text = "EiSo - Prüfungen"
        Me.eshop_bilderprüfung.UseVisualStyleBackColor = True
        '
        'btnPrüfeWebArtikel
        '
        Me.btnPrüfeWebArtikel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrüfeWebArtikel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrüfeWebArtikel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrüfeWebArtikel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrüfeWebArtikel.ImageIndex = 0
        Me.btnPrüfeWebArtikel.ImageList = Me.imgAuktionsmanagement
        Me.btnPrüfeWebArtikel.Location = New System.Drawing.Point(537, 4)
        Me.btnPrüfeWebArtikel.Name = "btnPrüfeWebArtikel"
        Me.btnPrüfeWebArtikel.Size = New System.Drawing.Size(252, 23)
        Me.btnPrüfeWebArtikel.TabIndex = 15
        Me.btnPrüfeWebArtikel.Text = "Prüfe vom Artikelverwaltung"
        Me.btnPrüfeWebArtikel.UseVisualStyleBackColor = False
        Me.btnPrüfeWebArtikel.Visible = False
        '
        'btnCheckPictures
        '
        Me.btnCheckPictures.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCheckPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckPictures.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckPictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckPictures.ImageIndex = 0
        Me.btnCheckPictures.ImageList = Me.imgAuktionsmanagement
        Me.btnCheckPictures.Location = New System.Drawing.Point(279, 6)
        Me.btnCheckPictures.Name = "btnCheckPictures"
        Me.btnCheckPictures.Size = New System.Drawing.Size(252, 23)
        Me.btnCheckPictures.TabIndex = 14
        Me.btnCheckPictures.Text = "eBay Galerie Bilder prüfen"
        Me.btnCheckPictures.UseVisualStyleBackColor = False
        '
        'btnTools_eBayGalerie
        '
        Me.btnTools_eBayGalerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTools_eBayGalerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTools_eBayGalerie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTools_eBayGalerie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools_eBayGalerie.ImageIndex = 0
        Me.btnTools_eBayGalerie.ImageList = Me.imgAuktionsmanagement
        Me.btnTools_eBayGalerie.Location = New System.Drawing.Point(18, 6)
        Me.btnTools_eBayGalerie.Name = "btnTools_eBayGalerie"
        Me.btnTools_eBayGalerie.Size = New System.Drawing.Size(255, 23)
        Me.btnTools_eBayGalerie.TabIndex = 13
        Me.btnTools_eBayGalerie.Text = "eBay Galerie abrufen"
        Me.btnTools_eBayGalerie.UseVisualStyleBackColor = False
        '
        'lvweBayGalerie
        '
        Me.lvweBayGalerie.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvweBayGalerie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvweBayGalerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvweBayGalerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvweBayGalerie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvweBayGalerie.ContextMenuStrip = Me.cmseBayGalerie_neu
        Me.lvweBayGalerie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvweBayGalerie.FullRowSelect = True
        Me.lvweBayGalerie.GridLines = True
        Me.lvweBayGalerie.HideSelection = False
        Me.lvweBayGalerie.Location = New System.Drawing.Point(6, 35)
        Me.lvweBayGalerie.Name = "lvweBayGalerie"
        Me.lvweBayGalerie.Size = New System.Drawing.Size(1112, 497)
        Me.lvweBayGalerie.TabIndex = 12
        Me.lvweBayGalerie.UseCompatibleStateImageBehavior = False
        Me.lvweBayGalerie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "WebID"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Beschreibung"
        Me.ColumnHeader12.Width = 555
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Preis"
        Me.ColumnHeader13.Width = 112
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Bild"
        Me.ColumnHeader14.Width = 170
        '
        'cmseBayGalerie_neu
        '
        Me.cmseBayGalerie_neu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EBayAnsichtToolStripMenuItem, Me.ArtikelLöschenToolStripMenuItem})
        Me.cmseBayGalerie_neu.Name = "ContextMenuStrip1"
        Me.cmseBayGalerie_neu.Size = New System.Drawing.Size(153, 48)
        '
        'EBayAnsichtToolStripMenuItem
        '
        Me.EBayAnsichtToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.EBayAnsichtToolStripMenuItem.Name = "EBayAnsichtToolStripMenuItem"
        Me.EBayAnsichtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EBayAnsichtToolStripMenuItem.Text = "&eBay Ansicht"
        '
        'ArtikelLöschenToolStripMenuItem
        '
        Me.ArtikelLöschenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.action_delete
        Me.ArtikelLöschenToolStripMenuItem.Name = "ArtikelLöschenToolStripMenuItem"
        Me.ArtikelLöschenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ArtikelLöschenToolStripMenuItem.Text = "&Artikel löschen"
        '
        'menue_tbPaypal
        '
        Me.menue_tbPaypal.Controls.Add(Me.tabPaypal)
        Me.menue_tbPaypal.ImageIndex = 15
        Me.menue_tbPaypal.Location = New System.Drawing.Point(4, 63)
        Me.menue_tbPaypal.Name = "menue_tbPaypal"
        Me.menue_tbPaypal.Padding = New System.Windows.Forms.Padding(3)
        Me.menue_tbPaypal.Size = New System.Drawing.Size(1150, 571)
        Me.menue_tbPaypal.TabIndex = 9
        Me.menue_tbPaypal.Text = "Paypal API"
        Me.menue_tbPaypal.UseVisualStyleBackColor = True
        '
        'tabPaypal
        '
        Me.tabPaypal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabPaypal.Controls.Add(Me.tab_paypal_api)
        Me.tabPaypal.Controls.Add(Me.tab_paypal_schnellberechnung)
        Me.tabPaypal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPaypal.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabPaypal.Location = New System.Drawing.Point(3, 3)
        Me.tabPaypal.Name = "tabPaypal"
        Me.tabPaypal.SelectedIndex = 0
        Me.tabPaypal.Size = New System.Drawing.Size(1144, 565)
        Me.tabPaypal.TabIndex = 20
        '
        'tab_paypal_api
        '
        Me.tab_paypal_api.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tab_paypal_api.Controls.Add(Me.btnPaypalBestellstatus)
        Me.tab_paypal_api.Controls.Add(Me.btnPaypal_abrufen)
        Me.tab_paypal_api.Controls.Add(Me.Label31)
        Me.tab_paypal_api.Controls.Add(Me.Label29)
        Me.tab_paypal_api.Controls.Add(Me.lvwPaypal)
        Me.tab_paypal_api.Controls.Add(Me.dtPaypal)
        Me.tab_paypal_api.ImageKey = "PayPal.gif"
        Me.tab_paypal_api.Location = New System.Drawing.Point(4, 25)
        Me.tab_paypal_api.Name = "tab_paypal_api"
        Me.tab_paypal_api.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_paypal_api.Size = New System.Drawing.Size(1136, 536)
        Me.tab_paypal_api.TabIndex = 1
        Me.tab_paypal_api.Text = "Paypal Account"
        '
        'btnPaypalBestellstatus
        '
        Me.btnPaypalBestellstatus.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnPaypalBestellstatus.Enabled = False
        Me.btnPaypalBestellstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaypalBestellstatus.Image = Global.YabE.My.Resources.Resources._03
        Me.btnPaypalBestellstatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaypalBestellstatus.Location = New System.Drawing.Point(588, 75)
        Me.btnPaypalBestellstatus.Name = "btnPaypalBestellstatus"
        Me.btnPaypalBestellstatus.Size = New System.Drawing.Size(183, 23)
        Me.btnPaypalBestellstatus.TabIndex = 42
        Me.btnPaypalBestellstatus.Text = "&Bestellstatus"
        Me.btnPaypalBestellstatus.UseVisualStyleBackColor = False
        '
        'btnPaypal_abrufen
        '
        Me.btnPaypal_abrufen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnPaypal_abrufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaypal_abrufen.Image = Global.YabE.My.Resources.Resources._24
        Me.btnPaypal_abrufen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaypal_abrufen.Location = New System.Drawing.Point(312, 75)
        Me.btnPaypal_abrufen.Name = "btnPaypal_abrufen"
        Me.btnPaypal_abrufen.Size = New System.Drawing.Size(270, 23)
        Me.btnPaypal_abrufen.TabIndex = 41
        Me.btnPaypal_abrufen.Text = "&Paypal Transaktionen abrufen"
        Me.btnPaypal_abrufen.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Silver
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(15, 59)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(275, 13)
        Me.Label31.TabIndex = 40
        Me.Label31.Text = "Beginn bei Datum "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(14, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(285, 23)
        Me.Label29.TabIndex = 39
        Me.Label29.Text = "EiSo - Paypal Verwaltung"
        '
        'lvwPaypal
        '
        Me.lvwPaypal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwPaypal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwPaypal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPaypalName, Me.colPaypalStatus, Me.colPaypaEmail, Me.colPaypalTimestamp, Me.colPaypalType, Me.colPaypalFee, Me.colPaypalGesamt, Me.colPaypalGrossAmount})
        Me.lvwPaypal.ContextMenuStrip = Me.cmsPaypal
        Me.lvwPaypal.FullRowSelect = True
        Me.lvwPaypal.GridLines = True
        Me.lvwPaypal.HideSelection = False
        Me.lvwPaypal.Location = New System.Drawing.Point(18, 119)
        Me.lvwPaypal.Name = "lvwPaypal"
        Me.lvwPaypal.Size = New System.Drawing.Size(1097, 429)
        Me.lvwPaypal.TabIndex = 10
        Me.lvwPaypal.UseCompatibleStateImageBehavior = False
        Me.lvwPaypal.View = System.Windows.Forms.View.Details
        '
        'colPaypalName
        '
        Me.colPaypalName.DisplayIndex = 1
        Me.colPaypalName.Text = "Name"
        Me.colPaypalName.Width = 252
        '
        'colPaypalStatus
        '
        Me.colPaypalStatus.DisplayIndex = 3
        Me.colPaypalStatus.Text = "Status"
        Me.colPaypalStatus.Width = 126
        '
        'colPaypaEmail
        '
        Me.colPaypaEmail.DisplayIndex = 4
        Me.colPaypaEmail.Text = "Email"
        Me.colPaypaEmail.Width = 75
        '
        'colPaypalTimestamp
        '
        Me.colPaypalTimestamp.DisplayIndex = 0
        Me.colPaypalTimestamp.Text = "Datum"
        Me.colPaypalTimestamp.Width = 96
        '
        'colPaypalType
        '
        Me.colPaypalType.DisplayIndex = 2
        Me.colPaypalType.Text = "Type"
        Me.colPaypalType.Width = 132
        '
        'colPaypalFee
        '
        Me.colPaypalFee.DisplayIndex = 6
        Me.colPaypalFee.Text = "Gebühr"
        Me.colPaypalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPaypalFee.Width = 90
        '
        'colPaypalGesamt
        '
        Me.colPaypalGesamt.DisplayIndex = 7
        Me.colPaypalGesamt.Text = "Eingegangen"
        Me.colPaypalGesamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPaypalGesamt.Width = 111
        '
        'colPaypalGrossAmount
        '
        Me.colPaypalGrossAmount.DisplayIndex = 5
        Me.colPaypalGrossAmount.Text = "Endbetrag"
        Me.colPaypalGrossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPaypalGrossAmount.Width = 132
        '
        'cmsPaypal
        '
        Me.cmsPaypal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem18, Me.ToolStripMenuItem17, Me.SYNCStatusBezahltToolStripMenuItem})
        Me.cmsPaypal.Name = "cmsPaypal"
        Me.cmsPaypal.Size = New System.Drawing.Size(219, 70)
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem18.Image = Global.YabE.My.Resources.Resources._19
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(218, 22)
        Me.ToolStripMenuItem18.Text = "&Kundenverlauf"
        Me.ToolStripMenuItem18.ToolTipText = "Zeigt vom Kunden vorherige Bestellunge an "
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Image = Global.YabE.My.Resources.Resources.search2
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(218, 22)
        Me.ToolStripMenuItem17.Text = "Suche Kundenbestellungen"
        '
        'SYNCStatusBezahltToolStripMenuItem
        '
        Me.SYNCStatusBezahltToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._03
        Me.SYNCStatusBezahltToolStripMenuItem.Name = "SYNCStatusBezahltToolStripMenuItem"
        Me.SYNCStatusBezahltToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.SYNCStatusBezahltToolStripMenuItem.Text = "&SYNC -> Status ändern"
        '
        'dtPaypal
        '
        Me.dtPaypal.Location = New System.Drawing.Point(18, 75)
        Me.dtPaypal.Name = "dtPaypal"
        Me.dtPaypal.Size = New System.Drawing.Size(272, 21)
        Me.dtPaypal.TabIndex = 9
        '
        'tab_paypal_schnellberechnung
        '
        Me.tab_paypal_schnellberechnung.BackColor = System.Drawing.Color.Gainsboro
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.txtSumme)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.Label16)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.txtZwischensumme)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.txtVersand)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.Label15)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.txtEndsumme)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.Label14)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.Label13)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.Label12)
        Me.tab_paypal_schnellberechnung.Controls.Add(Me.cmdRechnen)
        Me.tab_paypal_schnellberechnung.ImageKey = "PayPal.gif"
        Me.tab_paypal_schnellberechnung.Location = New System.Drawing.Point(4, 25)
        Me.tab_paypal_schnellberechnung.Name = "tab_paypal_schnellberechnung"
        Me.tab_paypal_schnellberechnung.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_paypal_schnellberechnung.Size = New System.Drawing.Size(1136, 536)
        Me.tab_paypal_schnellberechnung.TabIndex = 0
        Me.tab_paypal_schnellberechnung.Text = "Schnellberechnung"
        Me.tab_paypal_schnellberechnung.UseVisualStyleBackColor = True
        '
        'txtSumme
        '
        Me.txtSumme.AcceptsReturn = True
        Me.txtSumme.BackColor = System.Drawing.SystemColors.Window
        Me.txtSumme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSumme.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSumme.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSumme.Location = New System.Drawing.Point(92, 15)
        Me.txtSumme.MaxLength = 0
        Me.txtSumme.Name = "txtSumme"
        Me.txtSumme.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSumme.Size = New System.Drawing.Size(175, 21)
        Me.txtSumme.TabIndex = 10
        Me.txtSumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Gainsboro
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(26, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(89, 17)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Betrag:"
        '
        'txtZwischensumme
        '
        Me.txtZwischensumme.AcceptsReturn = True
        Me.txtZwischensumme.BackColor = System.Drawing.SystemColors.Window
        Me.txtZwischensumme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZwischensumme.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZwischensumme.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZwischensumme.Location = New System.Drawing.Point(92, 75)
        Me.txtZwischensumme.MaxLength = 0
        Me.txtZwischensumme.Name = "txtZwischensumme"
        Me.txtZwischensumme.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZwischensumme.Size = New System.Drawing.Size(177, 21)
        Me.txtZwischensumme.TabIndex = 18
        Me.txtZwischensumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVersand
        '
        Me.txtVersand.AcceptsReturn = True
        Me.txtVersand.BackColor = System.Drawing.SystemColors.Window
        Me.txtVersand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVersand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVersand.Location = New System.Drawing.Point(92, 43)
        Me.txtVersand.MaxLength = 0
        Me.txtVersand.Name = "txtVersand"
        Me.txtVersand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVersand.Size = New System.Drawing.Size(177, 21)
        Me.txtVersand.TabIndex = 11
        Me.txtVersand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gainsboro
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(18, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(89, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Versand:"
        '
        'txtEndsumme
        '
        Me.txtEndsumme.AcceptsReturn = True
        Me.txtEndsumme.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndsumme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndsumme.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndsumme.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndsumme.Location = New System.Drawing.Point(92, 99)
        Me.txtEndsumme.MaxLength = 0
        Me.txtEndsumme.Name = "txtEndsumme"
        Me.txtEndsumme.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndsumme.Size = New System.Drawing.Size(177, 21)
        Me.txtEndsumme.TabIndex = 12
        Me.txtEndsumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Gainsboro
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(2, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(105, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Endsumme:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(32, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(317, 18)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Link ist in der Zwischenablage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(24, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "zw Erg:"
        '
        'cmdRechnen
        '
        Me.cmdRechnen.BackColor = System.Drawing.Color.NavajoWhite
        Me.cmdRechnen.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRechnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRechnen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRechnen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRechnen.ImageIndex = 0
        Me.cmdRechnen.ImageList = Me.imgAuktionsmanagement
        Me.cmdRechnen.Location = New System.Drawing.Point(92, 155)
        Me.cmdRechnen.Name = "cmdRechnen"
        Me.cmdRechnen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRechnen.Size = New System.Drawing.Size(199, 25)
        Me.cmdRechnen.TabIndex = 13
        Me.cmdRechnen.Text = "&Gebühren berechnen"
        Me.cmdRechnen.UseVisualStyleBackColor = False
        '
        'menue_eBayBewertungen
        '
        Me.menue_eBayBewertungen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menue_eBayBewertungen.Controls.Add(Me.chkeBayBewertung_automatischRE)
        Me.menue_eBayBewertungen.Controls.Add(Me.chkeBayBewertungen_allebewerted)
        Me.menue_eBayBewertungen.Controls.Add(Me.Label20)
        Me.menue_eBayBewertungen.Controls.Add(Me.Label4)
        Me.menue_eBayBewertungen.Controls.Add(Me.lblBewertung_bis)
        Me.menue_eBayBewertungen.Controls.Add(Me.lblBewertung_von)
        Me.menue_eBayBewertungen.Controls.Add(Me.dtp_BewertungBis)
        Me.menue_eBayBewertungen.Controls.Add(Me.dtp_BewertungVon)
        Me.menue_eBayBewertungen.Controls.Add(Me.Label18)
        Me.menue_eBayBewertungen.Controls.Add(Me.chkBewertungZeitfilter)
        Me.menue_eBayBewertungen.Controls.Add(Me.chkBewertung_janein)
        Me.menue_eBayBewertungen.Controls.Add(Me.btnRefreshBewertungen)
        Me.menue_eBayBewertungen.Controls.Add(Me.lvwBewertungen)
        Me.menue_eBayBewertungen.Controls.Add(Me.txtBewertungen)
        Me.menue_eBayBewertungen.Controls.Add(Me.chkStartupRückbewertung)
        Me.menue_eBayBewertungen.Controls.Add(Me.pgrBewertungenUpdate)
        Me.menue_eBayBewertungen.ImageIndex = 4
        Me.menue_eBayBewertungen.Location = New System.Drawing.Point(4, 63)
        Me.menue_eBayBewertungen.Name = "menue_eBayBewertungen"
        Me.menue_eBayBewertungen.Size = New System.Drawing.Size(1150, 571)
        Me.menue_eBayBewertungen.TabIndex = 7
        Me.menue_eBayBewertungen.Text = "eBay Bewertungen"
        '
        'chkeBayBewertung_automatischRE
        '
        Me.chkeBayBewertung_automatischRE.AutoSize = True
        Me.chkeBayBewertung_automatischRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkeBayBewertung_automatischRE.Location = New System.Drawing.Point(285, 59)
        Me.chkeBayBewertung_automatischRE.Name = "chkeBayBewertung_automatischRE"
        Me.chkeBayBewertung_automatischRE.Size = New System.Drawing.Size(198, 17)
        Me.chkeBayBewertung_automatischRE.TabIndex = 41
        Me.chkeBayBewertung_automatischRE.Text = "Automatisch rückbewerten"
        Me.ballonITips.SetToolTip(Me.chkeBayBewertung_automatischRE, "Bewerted positive Bewertungen, beim abruf zurück")
        Me.chkeBayBewertung_automatischRE.UseVisualStyleBackColor = True
        '
        'chkeBayBewertungen_allebewerted
        '
        Me.chkeBayBewertungen_allebewerted.AutoSize = True
        Me.chkeBayBewertungen_allebewerted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkeBayBewertungen_allebewerted.Location = New System.Drawing.Point(553, 59)
        Me.chkeBayBewertungen_allebewerted.Name = "chkeBayBewertungen_allebewerted"
        Me.chkeBayBewertungen_allebewerted.Size = New System.Drawing.Size(212, 17)
        Me.chkeBayBewertungen_allebewerted.TabIndex = 40
        Me.chkeBayBewertungen_allebewerted.Text = "&Alle als Bewertet markieren?"
        Me.ballonITips.SetToolTip(Me.chkeBayBewertungen_allebewerted, "Falls Sie bei eBay Bewertet haben, können Sie alle auf einmal als bewerted einste" &
        "llen")
        Me.chkeBayBewertungen_allebewerted.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(225, 23)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "EiSo - Bewertungen"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(550, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Automatischer Modus"
        Me.ballonITips.SetToolTip(Me.Label4, "Start dem Automatischen Modus für eBay Bewertungen")
        '
        'lblBewertung_bis
        '
        Me.lblBewertung_bis.BackColor = System.Drawing.Color.Silver
        Me.lblBewertung_bis.Location = New System.Drawing.Point(259, 81)
        Me.lblBewertung_bis.Name = "lblBewertung_bis"
        Me.lblBewertung_bis.Size = New System.Drawing.Size(249, 13)
        Me.lblBewertung_bis.TabIndex = 24
        Me.lblBewertung_bis.Text = "Bis - Bewertungsdatum"
        '
        'lblBewertung_von
        '
        Me.lblBewertung_von.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBewertung_von.BackColor = System.Drawing.Color.Silver
        Me.lblBewertung_von.Location = New System.Drawing.Point(2, 81)
        Me.lblBewertung_von.Name = "lblBewertung_von"
        Me.lblBewertung_von.Size = New System.Drawing.Size(1135, 13)
        Me.lblBewertung_von.TabIndex = 23
        Me.lblBewertung_von.Text = "Von - Bewertungsdatum"
        '
        'dtp_BewertungBis
        '
        Me.dtp_BewertungBis.Location = New System.Drawing.Point(262, 100)
        Me.dtp_BewertungBis.Name = "dtp_BewertungBis"
        Me.dtp_BewertungBis.Size = New System.Drawing.Size(244, 21)
        Me.dtp_BewertungBis.TabIndex = 21
        '
        'dtp_BewertungVon
        '
        Me.dtp_BewertungVon.Location = New System.Drawing.Point(9, 101)
        Me.dtp_BewertungVon.Name = "dtp_BewertungVon"
        Me.dtp_BewertungVon.Size = New System.Drawing.Size(244, 21)
        Me.dtp_BewertungVon.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Silver
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(282, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(247, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Suchkritieren"
        '
        'chkBewertungZeitfilter
        '
        Me.chkBewertungZeitfilter.AutoSize = True
        Me.chkBewertungZeitfilter.Checked = True
        Me.chkBewertungZeitfilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBewertungZeitfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBewertungZeitfilter.Location = New System.Drawing.Point(14, 61)
        Me.chkBewertungZeitfilter.Name = "chkBewertungZeitfilter"
        Me.chkBewertungZeitfilter.Size = New System.Drawing.Size(97, 17)
        Me.chkBewertungZeitfilter.TabIndex = 25
        Me.chkBewertungZeitfilter.Text = "Datumfilter"
        Me.chkBewertungZeitfilter.UseVisualStyleBackColor = True
        '
        'chkBewertung_janein
        '
        Me.chkBewertung_janein.AutoSize = True
        Me.chkBewertung_janein.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBewertung_janein.Location = New System.Drawing.Point(285, 36)
        Me.chkBewertung_janein.Name = "chkBewertung_janein"
        Me.chkBewertung_janein.Size = New System.Drawing.Size(244, 17)
        Me.chkBewertung_janein.TabIndex = 19
        Me.chkBewertung_janein.Text = "Nur offene Bewertungen anzeigen"
        Me.chkBewertung_janein.UseVisualStyleBackColor = True
        '
        'btnRefreshBewertungen
        '
        Me.btnRefreshBewertungen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnRefreshBewertungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshBewertungen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefreshBewertungen.ImageIndex = 0
        Me.btnRefreshBewertungen.ImageList = Me.imgAuktionsmanagement
        Me.btnRefreshBewertungen.Location = New System.Drawing.Point(512, 97)
        Me.btnRefreshBewertungen.Name = "btnRefreshBewertungen"
        Me.btnRefreshBewertungen.Size = New System.Drawing.Size(228, 23)
        Me.btnRefreshBewertungen.TabIndex = 18
        Me.btnRefreshBewertungen.Text = "&eBay Bewertungen ab&rufen"
        Me.btnRefreshBewertungen.UseVisualStyleBackColor = False
        '
        'lvwBewertungen
        '
        Me.lvwBewertungen.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwBewertungen.AllowColumnReorder = True
        Me.lvwBewertungen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBewertungen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwBewertungen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBewertungen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmUser, Me.ClmScore, Me.ClmItemId, Me.ClmType, Me.ClmComment, Me.ClmRole, Me.ClmTime, Me.clmTransaktionID, Me.clmBeschreibung, Me.clmPreis, Me.clmEmail, Me.clmHitcounter, Me.clmWatchcount, Me.clmOrderStatus})
        Me.lvwBewertungen.ContextMenuStrip = Me.cmseBayBewertung
        Me.lvwBewertungen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBewertungen.FullRowSelect = True
        Me.lvwBewertungen.GridLines = True
        Me.lvwBewertungen.HideSelection = False
        Me.lvwBewertungen.LabelEdit = True
        Me.lvwBewertungen.Location = New System.Drawing.Point(6, 148)
        Me.lvwBewertungen.Name = "lvwBewertungen"
        Me.lvwBewertungen.ShowItemToolTips = True
        Me.lvwBewertungen.Size = New System.Drawing.Size(1137, 560)
        Me.lvwBewertungen.TabIndex = 14
        Me.lvwBewertungen.UseCompatibleStateImageBehavior = False
        Me.lvwBewertungen.View = System.Windows.Forms.View.Details
        '
        'ClmUser
        '
        Me.ClmUser.DisplayIndex = 3
        Me.ClmUser.Text = "Mitglied"
        Me.ClmUser.Width = 149
        '
        'ClmScore
        '
        Me.ClmScore.DisplayIndex = 4
        Me.ClmScore.Text = "Punkte"
        Me.ClmScore.Width = 105
        '
        'ClmItemId
        '
        Me.ClmItemId.DisplayIndex = 6
        Me.ClmItemId.Text = "eBay ID"
        Me.ClmItemId.Width = 0
        '
        'ClmType
        '
        Me.ClmType.DisplayIndex = 7
        Me.ClmType.Text = "Type"
        '
        'ClmComment
        '
        Me.ClmComment.DisplayIndex = 5
        Me.ClmComment.Text = "Kommentar"
        Me.ClmComment.Width = 330
        '
        'ClmRole
        '
        Me.ClmRole.DisplayIndex = 8
        Me.ClmRole.Text = "Role"
        Me.ClmRole.Width = 61
        '
        'ClmTime
        '
        Me.ClmTime.DisplayIndex = 0
        Me.ClmTime.Text = "Zeit"
        Me.ClmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ClmTime.Width = 146
        '
        'clmTransaktionID
        '
        Me.clmTransaktionID.DisplayIndex = 9
        Me.clmTransaktionID.Text = "TransaktionID"
        Me.clmTransaktionID.Width = 80
        '
        'clmBeschreibung
        '
        Me.clmBeschreibung.DisplayIndex = 1
        Me.clmBeschreibung.Text = "Artikelbeschreibung"
        Me.clmBeschreibung.Width = 180
        '
        'clmPreis
        '
        Me.clmPreis.DisplayIndex = 10
        Me.clmPreis.Text = "Preis"
        Me.clmPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clmEmail
        '
        Me.clmEmail.DisplayIndex = 11
        Me.clmEmail.Text = "Email"
        '
        'clmHitcounter
        '
        Me.clmHitcounter.DisplayIndex = 12
        Me.clmHitcounter.Text = "Besucher"
        Me.clmHitcounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clmWatchcount
        '
        Me.clmWatchcount.DisplayIndex = 13
        Me.clmWatchcount.Text = "Beobachter"
        Me.clmWatchcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clmOrderStatus
        '
        Me.clmOrderStatus.DisplayIndex = 2
        Me.clmOrderStatus.Text = "Status"
        Me.clmOrderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmseBayBewertung
        '
        Me.cmseBayBewertung.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsichtAktuallisierenToolStripMenuItem, Me.BestellübersichtToolStripMenuItem1, Me.ToolStripSeparator54, Me.ToolStripMenuItem4, Me.ToolStripMenuItem1, Me.ToolStripSeparator53, Me.ÖffnenToolStripMenuItem, Me.AutobewertungToolStripMenuItem, Me.ToolStripSeparator1, Me.BewertungsprofilinternToolStripMenuItem, Me.AlsBewertetSetzenToolStripMenuItem, Me.ToolStripSeparator5, Me.BewertungsprofilÖffnenToolStripMenuItem, Me.EBayArtikelÖffnenToolStripMenuItem, Me.ToolStripSeparator47, Me.ToolStripMenuItem16})
        Me.cmseBayBewertung.Name = "ContextMenuStrip1"
        Me.cmseBayBewertung.Size = New System.Drawing.Size(240, 276)
        '
        'AnsichtAktuallisierenToolStripMenuItem
        '
        Me.AnsichtAktuallisierenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources._24
        Me.AnsichtAktuallisierenToolStripMenuItem.Name = "AnsichtAktuallisierenToolStripMenuItem"
        Me.AnsichtAktuallisierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AnsichtAktuallisierenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AnsichtAktuallisierenToolStripMenuItem.Text = "Ansicht -> aktuallisieren"
        '
        'BestellübersichtToolStripMenuItem1
        '
        Me.BestellübersichtToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources._19
        Me.BestellübersichtToolStripMenuItem1.Name = "BestellübersichtToolStripMenuItem1"
        Me.BestellübersichtToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.BestellübersichtToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.BestellübersichtToolStripMenuItem1.Text = "Bestellübersicht"
        '
        'ToolStripSeparator54
        '
        Me.ToolStripSeparator54.Name = "ToolStripSeparator54"
        Me.ToolStripSeparator54.Size = New System.Drawing.Size(236, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripSeparator35, Me.ToolStripMenuItem9, Me.ToolStripSeparator36, Me.ToolStripMenuItem10})
        Me.ToolStripMenuItem4.Image = Global.YabE.My.Resources.Resources.time_go
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(239, 22)
        Me.ToolStripMenuItem4.Text = " Bestellungsstatus"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem5.Text = "&Bestellt"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem6.Text = "&Bezahlt"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem7.Text = "&Verschickt"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem8.Text = "&Komplett"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(219, 6)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem9.Text = "&Storniert"
        '
        'ToolStripSeparator36
        '
        Me.ToolStripSeparator36.Name = "ToolStripSeparator36"
        Me.ToolStripSeparator36.Size = New System.Drawing.Size(219, 6)
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Enabled = False
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem10.Text = "Zahlungserinnerung senden"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.Desktop21
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.ToolStripMenuItem1.Text = " WebCenter"
        '
        'ToolStripSeparator53
        '
        Me.ToolStripSeparator53.Name = "ToolStripSeparator53"
        Me.ToolStripSeparator53.Size = New System.Drawing.Size(236, 6)
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.user_edit
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ÖffnenToolStripMenuItem.Text = "&Bewertung abgeben"
        '
        'AutobewertungToolStripMenuItem
        '
        Me.AutobewertungToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarianteIToolStripMenuItem, Me.VarianteIIToolStripMenuItem, Me.VarianteIIIToolStripMenuItem})
        Me.AutobewertungToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.world_edit
        Me.AutobewertungToolStripMenuItem.Name = "AutobewertungToolStripMenuItem"
        Me.AutobewertungToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AutobewertungToolStripMenuItem.Text = "Bewertungsvarianten (Auto)"
        '
        'VarianteIToolStripMenuItem
        '
        Me.VarianteIToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.world_edit
        Me.VarianteIToolStripMenuItem.Name = "VarianteIToolStripMenuItem"
        Me.VarianteIToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.VarianteIToolStripMenuItem.Text = "Variante I "
        '
        'VarianteIIToolStripMenuItem
        '
        Me.VarianteIIToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.world_edit
        Me.VarianteIIToolStripMenuItem.Name = "VarianteIIToolStripMenuItem"
        Me.VarianteIIToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.VarianteIIToolStripMenuItem.Text = "Variante II "
        '
        'VarianteIIIToolStripMenuItem
        '
        Me.VarianteIIIToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.world_edit
        Me.VarianteIIIToolStripMenuItem.Name = "VarianteIIIToolStripMenuItem"
        Me.VarianteIIIToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.VarianteIIIToolStripMenuItem.Text = "Variante III"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(236, 6)
        '
        'BewertungsprofilinternToolStripMenuItem
        '
        Me.BewertungsprofilinternToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.search2
        Me.BewertungsprofilinternToolStripMenuItem.Name = "BewertungsprofilinternToolStripMenuItem"
        Me.BewertungsprofilinternToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.BewertungsprofilinternToolStripMenuItem.Text = "eBay -> Bewertungsprofil von"
        '
        'AlsBewertetSetzenToolStripMenuItem
        '
        Me.AlsBewertetSetzenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.wand
        Me.AlsBewertetSetzenToolStripMenuItem.Name = "AlsBewertetSetzenToolStripMenuItem"
        Me.AlsBewertetSetzenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AlsBewertetSetzenToolStripMenuItem.Text = "eBay -> &Als bewertet markieren"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(236, 6)
        '
        'BewertungsprofilÖffnenToolStripMenuItem
        '
        Me.BewertungsprofilÖffnenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.film_link
        Me.BewertungsprofilÖffnenToolStripMenuItem.Name = "BewertungsprofilÖffnenToolStripMenuItem"
        Me.BewertungsprofilÖffnenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.BewertungsprofilÖffnenToolStripMenuItem.Text = "&Bewertungsprofil extern"
        '
        'EBayArtikelÖffnenToolStripMenuItem
        '
        Me.EBayArtikelÖffnenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.film_link
        Me.EBayArtikelÖffnenToolStripMenuItem.Name = "EBayArtikelÖffnenToolStripMenuItem"
        Me.EBayArtikelÖffnenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.EBayArtikelÖffnenToolStripMenuItem.Text = "eBay Artikel öffnen"
        '
        'ToolStripSeparator47
        '
        Me.ToolStripSeparator47.Name = "ToolStripSeparator47"
        Me.ToolStripSeparator47.Size = New System.Drawing.Size(236, 6)
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(239, 22)
        Me.ToolStripMenuItem16.Text = "&Übersicht exportieren..."
        Me.ToolStripMenuItem16.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'txtBewertungen
        '
        Me.txtBewertungen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBewertungen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBewertungen.Location = New System.Drawing.Point(746, 97)
        Me.txtBewertungen.Multiline = True
        Me.txtBewertungen.Name = "txtBewertungen"
        Me.txtBewertungen.Size = New System.Drawing.Size(194, 23)
        Me.txtBewertungen.TabIndex = 12
        '
        'chkStartupRückbewertung
        '
        Me.chkStartupRückbewertung.AutoSize = True
        Me.chkStartupRückbewertung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkStartupRückbewertung.Location = New System.Drawing.Point(553, 36)
        Me.chkStartupRückbewertung.Name = "chkStartupRückbewertung"
        Me.chkStartupRückbewertung.Size = New System.Drawing.Size(221, 17)
        Me.chkStartupRückbewertung.TabIndex = 11
        Me.chkStartupRückbewertung.Text = "Rückbewertungsystem starten"
        Me.ballonITips.SetToolTip(Me.chkStartupRückbewertung, "Aktiviert den automatischen Modus für das Abrufen der Bewertungen (siehe Optionen" &
        " für Zeitdauer)")
        Me.chkStartupRückbewertung.UseVisualStyleBackColor = True
        '
        'pgrBewertungenUpdate
        '
        Me.pgrBewertungenUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgrBewertungenUpdate.Location = New System.Drawing.Point(8, 128)
        Me.pgrBewertungenUpdate.Name = "pgrBewertungenUpdate"
        Me.pgrBewertungenUpdate.Size = New System.Drawing.Size(1137, 14)
        Me.pgrBewertungenUpdate.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgrBewertungenUpdate.TabIndex = 9
        Me.pgrBewertungenUpdate.Visible = False
        '
        'menue_Mailversand
        '
        Me.menue_Mailversand.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menue_Mailversand.Controls.Add(Me.Label32)
        Me.menue_Mailversand.Controls.Add(Me.chkNewsletterIseBay)
        Me.menue_Mailversand.Controls.Add(Me.chkNewsletterIsDelcampe)
        Me.menue_Mailversand.Controls.Add(Me.chkNewsletterIsWebuser)
        Me.menue_Mailversand.Controls.Add(Me.Label25)
        Me.menue_Mailversand.Controls.Add(Me.Label21)
        Me.menue_Mailversand.Controls.Add(Me.Label5)
        Me.menue_Mailversand.Controls.Add(Me.btnEdit)
        Me.menue_Mailversand.Controls.Add(Me.lvMailStatus)
        Me.menue_Mailversand.Controls.Add(Me.chkNewsletter_testmodus)
        Me.menue_Mailversand.Controls.Add(Me.chkNurKlickt)
        Me.menue_Mailversand.Controls.Add(Me.chkNewsletterAlle)
        Me.menue_Mailversand.Controls.Add(Me.chkVerschickt)
        Me.menue_Mailversand.Controls.Add(Me.cmbTranslationBereichAuswählen)
        Me.menue_Mailversand.Controls.Add(Me.pgrMailstatusGesammt)
        Me.menue_Mailversand.Controls.Add(Me.btnNewsletterReset)
        Me.menue_Mailversand.Controls.Add(Me.btnAbschickenNewsletter)
        Me.menue_Mailversand.Controls.Add(Me.btnMailVersandStart)
        Me.menue_Mailversand.ImageIndex = 5
        Me.menue_Mailversand.Location = New System.Drawing.Point(4, 63)
        Me.menue_Mailversand.Name = "menue_Mailversand"
        Me.menue_Mailversand.Size = New System.Drawing.Size(1150, 571)
        Me.menue_Mailversand.TabIndex = 2
        Me.menue_Mailversand.Text = "Newsletterverwaltung"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Silver
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(664, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(123, 13)
        Me.Label32.TabIndex = 45
        Me.Label32.Text = "Plattform"
        '
        'chkNewsletterIseBay
        '
        Me.chkNewsletterIseBay.AutoSize = True
        Me.chkNewsletterIseBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNewsletterIseBay.Location = New System.Drawing.Point(821, 38)
        Me.chkNewsletterIseBay.Name = "chkNewsletterIseBay"
        Me.chkNewsletterIseBay.Size = New System.Drawing.Size(55, 17)
        Me.chkNewsletterIseBay.TabIndex = 44
        Me.chkNewsletterIseBay.Text = "&eBay"
        Me.ballonITips.SetToolTip(Me.chkNewsletterIseBay, "Zeigt alle Kunden an, welche bereits bestellt haben")
        Me.chkNewsletterIseBay.UseVisualStyleBackColor = True
        '
        'chkNewsletterIsDelcampe
        '
        Me.chkNewsletterIsDelcampe.AutoSize = True
        Me.chkNewsletterIsDelcampe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNewsletterIsDelcampe.Location = New System.Drawing.Point(728, 37)
        Me.chkNewsletterIsDelcampe.Name = "chkNewsletterIsDelcampe"
        Me.chkNewsletterIsDelcampe.Size = New System.Drawing.Size(87, 17)
        Me.chkNewsletterIsDelcampe.TabIndex = 43
        Me.chkNewsletterIsDelcampe.Text = "&Delcampe"
        Me.ballonITips.SetToolTip(Me.chkNewsletterIsDelcampe, "Zeigt alle Kunden an, welche bereits bestellt haben")
        Me.chkNewsletterIsDelcampe.UseVisualStyleBackColor = True
        '
        'chkNewsletterIsWebuser
        '
        Me.chkNewsletterIsWebuser.AutoSize = True
        Me.chkNewsletterIsWebuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNewsletterIsWebuser.Location = New System.Drawing.Point(667, 37)
        Me.chkNewsletterIsWebuser.Name = "chkNewsletterIsWebuser"
        Me.chkNewsletterIsWebuser.Size = New System.Drawing.Size(55, 17)
        Me.chkNewsletterIsWebuser.TabIndex = 42
        Me.chkNewsletterIsWebuser.Text = "&Shop"
        Me.ballonITips.SetToolTip(Me.chkNewsletterIsWebuser, "Zeigt alle Kunden an, welche bereits bestellt haben")
        Me.chkNewsletterIsWebuser.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.Color.Silver
        Me.Label25.Location = New System.Drawing.Point(3, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(1151, 13)
        Me.Label25.TabIndex = 41
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(199, 23)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "EiSo - Newsletter"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(277, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(830, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Suchkritieren"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.ImageIndex = 22
        Me.btnEdit.ImageList = Me.imgAuktionsmanagement
        Me.btnEdit.Location = New System.Drawing.Point(932, 78)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(175, 23)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "&Mailtext ändern"
        Me.ballonITips.SetToolTip(Me.btnEdit, "Ändern Sie Ihren Newsletter Text oder andere Texte")
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lvMailStatus
        '
        Me.lvMailStatus.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvMailStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMailStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvMailStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvMailStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mail_nr, Me.mail_name, Me.mail_email, Me.mail_Ort, Me.mail_preis, Me.mail_anzahl, Me.mail_verschickt, Me.mail_crc, Me.mail_clicked, Me.mail_last_clicked, Me.mail_sprache, Me.mail_id, Me.mail_webuser, Me.mail_country, Me.mail_benutzername, Me.mail_user_pwd, Me.mail_muttersprache})
        Me.lvMailStatus.ContextMenuStrip = Me.cmsNewsletter
        Me.lvMailStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMailStatus.FullRowSelect = True
        Me.lvMailStatus.GridLines = True
        Me.lvMailStatus.HideSelection = False
        Me.lvMailStatus.Location = New System.Drawing.Point(6, 127)
        Me.lvMailStatus.MultiSelect = False
        Me.lvMailStatus.Name = "lvMailStatus"
        Me.lvMailStatus.Size = New System.Drawing.Size(1141, 519)
        Me.lvMailStatus.TabIndex = 0
        Me.lvMailStatus.UseCompatibleStateImageBehavior = False
        Me.lvMailStatus.View = System.Windows.Forms.View.Details
        '
        'mail_nr
        '
        Me.mail_nr.Text = "Nr."
        Me.mail_nr.Width = 40
        '
        'mail_name
        '
        Me.mail_name.Text = "Name"
        Me.mail_name.Width = 150
        '
        'mail_email
        '
        Me.mail_email.DisplayIndex = 5
        Me.mail_email.Text = "eMail"
        '
        'mail_Ort
        '
        Me.mail_Ort.DisplayIndex = 6
        Me.mail_Ort.Text = "Ort"
        '
        'mail_preis
        '
        Me.mail_preis.DisplayIndex = 7
        Me.mail_preis.Text = "Preis"
        Me.mail_preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mail_anzahl
        '
        Me.mail_anzahl.DisplayIndex = 8
        Me.mail_anzahl.Text = "Anzahl"
        Me.mail_anzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mail_verschickt
        '
        Me.mail_verschickt.DisplayIndex = 9
        Me.mail_verschickt.Text = "Verschickt"
        Me.mail_verschickt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mail_verschickt.Width = 95
        '
        'mail_crc
        '
        Me.mail_crc.DisplayIndex = 10
        Me.mail_crc.Text = "CRC"
        Me.mail_crc.Width = 0
        '
        'mail_clicked
        '
        Me.mail_clicked.DisplayIndex = 3
        Me.mail_clicked.Text = "eMail Klicked"
        Me.mail_clicked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mail_clicked.Width = 102
        '
        'mail_last_clicked
        '
        Me.mail_last_clicked.DisplayIndex = 4
        Me.mail_last_clicked.Text = "Letzter Klick"
        Me.mail_last_clicked.Width = 103
        '
        'mail_sprache
        '
        Me.mail_sprache.DisplayIndex = 11
        Me.mail_sprache.Text = "Übersetzung"
        Me.mail_sprache.Width = 103
        '
        'mail_id
        '
        Me.mail_id.DisplayIndex = 12
        Me.mail_id.Text = ""
        Me.mail_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mail_id.Width = 0
        '
        'mail_webuser
        '
        Me.mail_webuser.DisplayIndex = 13
        Me.mail_webuser.Text = "Webseite"
        Me.mail_webuser.Width = 70
        '
        'mail_country
        '
        Me.mail_country.DisplayIndex = 2
        Me.mail_country.Text = "Land"
        Me.mail_country.Width = 109
        '
        'mail_benutzername
        '
        Me.mail_benutzername.Text = "Benutzername"
        '
        'mail_user_pwd
        '
        Me.mail_user_pwd.Text = "Passwort"
        Me.mail_user_pwd.Width = 70
        '
        'mail_muttersprache
        '
        Me.mail_muttersprache.Text = "Muttersprache(EiSo)"
        '
        'cmsNewsletter
        '
        Me.cmsNewsletter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem11, Me.ToolStripSeparator50, Me.BestellübersichtToolStripMenuItem2, Me.VorschauAnzeigenToolStripMenuItem, Me.ToolStripSeparator13, Me.NewsletterAnabmeldenToolStripMenuItem, Me.VersendetEinstellenToolStripMenuItem, Me.ToolStripSeparator16, Me.ExportierenToolStripMenuItem2})
        Me.cmsNewsletter.Name = "cmsNewsletter"
        Me.cmsNewsletter.Size = New System.Drawing.Size(242, 154)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Image = Global.YabE.My.Resources.Resources._24
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(241, 22)
        Me.ToolStripMenuItem11.Text = "Ansicht -> aktuallisieren"
        '
        'ToolStripSeparator50
        '
        Me.ToolStripSeparator50.Name = "ToolStripSeparator50"
        Me.ToolStripSeparator50.Size = New System.Drawing.Size(238, 6)
        '
        'BestellübersichtToolStripMenuItem2
        '
        Me.BestellübersichtToolStripMenuItem2.Image = Global.YabE.My.Resources.Resources._19
        Me.BestellübersichtToolStripMenuItem2.Name = "BestellübersichtToolStripMenuItem2"
        Me.BestellübersichtToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.BestellübersichtToolStripMenuItem2.Size = New System.Drawing.Size(241, 22)
        Me.BestellübersichtToolStripMenuItem2.Text = " &Bestellübersicht..."
        '
        'VorschauAnzeigenToolStripMenuItem
        '
        Me.VorschauAnzeigenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.Desktop2
        Me.VorschauAnzeigenToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VorschauAnzeigenToolStripMenuItem.Name = "VorschauAnzeigenToolStripMenuItem"
        Me.VorschauAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.VorschauAnzeigenToolStripMenuItem.Text = "&Vorschau anzeigen..."
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(238, 6)
        '
        'NewsletterAnabmeldenToolStripMenuItem
        '
        Me.NewsletterAnabmeldenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.disconnect
        Me.NewsletterAnabmeldenToolStripMenuItem.Name = "NewsletterAnabmeldenToolStripMenuItem"
        Me.NewsletterAnabmeldenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.NewsletterAnabmeldenToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.NewsletterAnabmeldenToolStripMenuItem.Text = "&Newsletter an/abmelden"
        '
        'VersendetEinstellenToolStripMenuItem
        '
        Me.VersendetEinstellenToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.letter_open
        Me.VersendetEinstellenToolStripMenuItem.Name = "VersendetEinstellenToolStripMenuItem"
        Me.VersendetEinstellenToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.VersendetEinstellenToolStripMenuItem.Text = "&Versendet einstellen"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(238, 6)
        '
        'ExportierenToolStripMenuItem2
        '
        Me.ExportierenToolStripMenuItem2.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportierenToolStripMenuItem2.Name = "ExportierenToolStripMenuItem2"
        Me.ExportierenToolStripMenuItem2.Size = New System.Drawing.Size(241, 22)
        Me.ExportierenToolStripMenuItem2.Text = "&Übersicht exportieren..."
        Me.ExportierenToolStripMenuItem2.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'chkNewsletter_testmodus
        '
        Me.chkNewsletter_testmodus.AutoSize = True
        Me.chkNewsletter_testmodus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNewsletter_testmodus.Location = New System.Drawing.Point(14, 38)
        Me.chkNewsletter_testmodus.Name = "chkNewsletter_testmodus"
        Me.chkNewsletter_testmodus.Size = New System.Drawing.Size(168, 17)
        Me.chkNewsletter_testmodus.TabIndex = 34
        Me.chkNewsletter_testmodus.Text = "Newsletter Testmodus"
        Me.ballonITips.SetToolTip(Me.chkNewsletter_testmodus, "Aktiviert einen Selbsttest -> eMail an sich selbst")
        Me.chkNewsletter_testmodus.UseVisualStyleBackColor = True
        '
        'chkNurKlickt
        '
        Me.chkNurKlickt.AutoSize = True
        Me.chkNurKlickt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNurKlickt.Location = New System.Drawing.Point(508, 37)
        Me.chkNurKlickt.Name = "chkNurKlickt"
        Me.chkNurKlickt.Size = New System.Drawing.Size(61, 17)
        Me.chkNurKlickt.TabIndex = 33
        Me.chkNurKlickt.Text = "&Klicks"
        Me.ballonITips.SetToolTip(Me.chkNurKlickt, "Zeigt Kunden mit Newsletter Beteiligung")
        Me.chkNurKlickt.UseVisualStyleBackColor = True
        '
        'chkNewsletterAlle
        '
        Me.chkNewsletterAlle.AutoSize = True
        Me.chkNewsletterAlle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNewsletterAlle.Location = New System.Drawing.Point(280, 37)
        Me.chkNewsletterAlle.Name = "chkNewsletterAlle"
        Me.chkNewsletterAlle.Size = New System.Drawing.Size(111, 17)
        Me.chkNewsletterAlle.TabIndex = 31
        Me.chkNewsletterAlle.Text = "&Alle anzeigen"
        Me.chkNewsletterAlle.UseVisualStyleBackColor = True
        '
        'chkVerschickt
        '
        Me.chkVerschickt.AutoSize = True
        Me.chkVerschickt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVerschickt.Location = New System.Drawing.Point(411, 37)
        Me.chkVerschickt.Name = "chkVerschickt"
        Me.chkVerschickt.Size = New System.Drawing.Size(91, 17)
        Me.chkVerschickt.TabIndex = 28
        Me.chkVerschickt.Text = "&verschickt"
        Me.ballonITips.SetToolTip(Me.chkVerschickt, "Schalter verschickt / nicht verschickt")
        Me.chkVerschickt.UseVisualStyleBackColor = True
        '
        'cmbTranslationBereichAuswählen
        '
        Me.cmbTranslationBereichAuswählen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbTranslationBereichAuswählen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTranslationBereichAuswählen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTranslationBereichAuswählen.FormattingEnabled = True
        Me.cmbTranslationBereichAuswählen.Location = New System.Drawing.Point(667, 77)
        Me.cmbTranslationBereichAuswählen.Name = "cmbTranslationBereichAuswählen"
        Me.cmbTranslationBereichAuswählen.Size = New System.Drawing.Size(258, 21)
        Me.cmbTranslationBereichAuswählen.TabIndex = 10
        '
        'pgrMailstatusGesammt
        '
        Me.pgrMailstatusGesammt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgrMailstatusGesammt.Location = New System.Drawing.Point(7, 107)
        Me.pgrMailstatusGesammt.Name = "pgrMailstatusGesammt"
        Me.pgrMailstatusGesammt.Size = New System.Drawing.Size(1140, 14)
        Me.pgrMailstatusGesammt.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgrMailstatusGesammt.TabIndex = 2
        Me.pgrMailstatusGesammt.Visible = False
        '
        'btnNewsletterReset
        '
        Me.btnNewsletterReset.BackColor = System.Drawing.Color.Linen
        Me.btnNewsletterReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewsletterReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewsletterReset.ImageIndex = 9
        Me.btnNewsletterReset.ImageList = Me.imgAuktionsmanagement
        Me.btnNewsletterReset.Location = New System.Drawing.Point(7, 78)
        Me.btnNewsletterReset.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNewsletterReset.Name = "btnNewsletterReset"
        Me.btnNewsletterReset.Size = New System.Drawing.Size(211, 23)
        Me.btnNewsletterReset.TabIndex = 30
        Me.btnNewsletterReset.Text = "&Neuen Newsletter starten"
        Me.ballonITips.SetToolTip(Me.btnNewsletterReset, "Neue Aktion bedeutet,  YABE vergisst das wer schon eine Email bekommen hat. ")
        Me.btnNewsletterReset.UseVisualStyleBackColor = False
        '
        'btnAbschickenNewsletter
        '
        Me.btnAbschickenNewsletter.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnAbschickenNewsletter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbschickenNewsletter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbschickenNewsletter.ImageIndex = 5
        Me.btnAbschickenNewsletter.ImageList = Me.imgAuktionsmanagement
        Me.btnAbschickenNewsletter.Location = New System.Drawing.Point(428, 77)
        Me.btnAbschickenNewsletter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAbschickenNewsletter.Name = "btnAbschickenNewsletter"
        Me.btnAbschickenNewsletter.Size = New System.Drawing.Size(232, 23)
        Me.btnAbschickenNewsletter.TabIndex = 9
        Me.btnAbschickenNewsletter.Text = "&Newsletter Versand starten"
        Me.ballonITips.SetToolTip(Me.btnAbschickenNewsletter, "Startet den Newsletterversand")
        Me.btnAbschickenNewsletter.UseVisualStyleBackColor = False
        '
        'btnMailVersandStart
        '
        Me.btnMailVersandStart.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnMailVersandStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMailVersandStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMailVersandStart.ImageIndex = 0
        Me.btnMailVersandStart.ImageList = Me.imgAuktionsmanagement
        Me.btnMailVersandStart.Location = New System.Drawing.Point(225, 77)
        Me.btnMailVersandStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMailVersandStart.Name = "btnMailVersandStart"
        Me.btnMailVersandStart.Size = New System.Drawing.Size(195, 23)
        Me.btnMailVersandStart.TabIndex = 8
        Me.btnMailVersandStart.Text = "Newletterdaten &holen"
        Me.ballonITips.SetToolTip(Me.btnMailVersandStart, "Ruft die Newsletter Daten ab")
        Me.btnMailVersandStart.UseVisualStyleBackColor = False
        '
        'menue_Statistik
        '
        Me.menue_Statistik.Controls.Add(Me.tabStatistics)
        Me.menue_Statistik.ImageIndex = 3
        Me.menue_Statistik.Location = New System.Drawing.Point(4, 63)
        Me.menue_Statistik.Name = "menue_Statistik"
        Me.menue_Statistik.Size = New System.Drawing.Size(1150, 571)
        Me.menue_Statistik.TabIndex = 6
        Me.menue_Statistik.Text = "EiSo Statistik"
        Me.menue_Statistik.UseVisualStyleBackColor = True
        '
        'tabStatistics
        '
        Me.tabStatistics.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabStatistics.Controls.Add(Me.TabPage6)
        Me.tabStatistics.Controls.Add(Me.TabPage5)
        Me.tabStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabStatistics.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabStatistics.ImageList = Me.imgAuktionsmanagement
        Me.tabStatistics.Location = New System.Drawing.Point(0, 0)
        Me.tabStatistics.Name = "tabStatistics"
        Me.tabStatistics.SelectedIndex = 0
        Me.tabStatistics.Size = New System.Drawing.Size(1150, 571)
        Me.tabStatistics.TabIndex = 4
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage6.Controls.Add(Me.rbStatCurve)
        Me.TabPage6.Controls.Add(Me.rbStatBalken)
        Me.TabPage6.Controls.Add(Me.ListBox1)
        Me.TabPage6.Controls.Add(Me.Label22)
        Me.TabPage6.Controls.Add(Me.cmbStatPlattform)
        Me.TabPage6.Controls.Add(Me.ZedGraphControl1)
        Me.TabPage6.Controls.Add(Me.btnEinlesen)
        Me.TabPage6.ImageIndex = 3
        Me.TabPage6.Location = New System.Drawing.Point(4, 26)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1142, 541)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Grafisch"
        '
        'rbStatCurve
        '
        Me.rbStatCurve.AutoSize = True
        Me.rbStatCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStatCurve.Location = New System.Drawing.Point(752, 19)
        Me.rbStatCurve.Name = "rbStatCurve"
        Me.rbStatCurve.Size = New System.Drawing.Size(62, 17)
        Me.rbStatCurve.TabIndex = 43
        Me.rbStatCurve.Text = "Kurve"
        Me.rbStatCurve.UseVisualStyleBackColor = True
        '
        'rbStatBalken
        '
        Me.rbStatBalken.AutoSize = True
        Me.rbStatBalken.Checked = True
        Me.rbStatBalken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStatBalken.Location = New System.Drawing.Point(678, 19)
        Me.rbStatBalken.Name = "rbStatBalken"
        Me.rbStatBalken.Size = New System.Drawing.Size(68, 17)
        Me.rbStatBalken.TabIndex = 42
        Me.rbStatBalken.TabStop = True
        Me.rbStatBalken.Text = "Balken"
        Me.rbStatBalken.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(825, 75)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(317, 41)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(172, 23)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "EiSo - Statistik"
        '
        'cmbStatPlattform
        '
        Me.cmbStatPlattform.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbStatPlattform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatPlattform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatPlattform.FormattingEnabled = True
        Me.cmbStatPlattform.Items.AddRange(New Object() {"Alle", "eBay", "Delcampe", "Shopsysteme"})
        Me.cmbStatPlattform.Location = New System.Drawing.Point(194, 20)
        Me.cmbStatPlattform.Name = "cmbStatPlattform"
        Me.cmbStatPlattform.Size = New System.Drawing.Size(239, 21)
        Me.cmbStatPlattform.TabIndex = 36
        '
        'ZedGraphControl1
        '
        Me.ZedGraphControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZedGraphControl1.EditModifierKeys = System.Windows.Forms.Keys.None
        Me.ZedGraphControl1.IsAntiAlias = True
        Me.ZedGraphControl1.IsShowPointValues = True
        Me.ZedGraphControl1.Location = New System.Drawing.Point(11, 47)
        Me.ZedGraphControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ZedGraphControl1.Name = "ZedGraphControl1"
        Me.ZedGraphControl1.ScrollGrace = 0R
        Me.ZedGraphControl1.ScrollMaxX = 0R
        Me.ZedGraphControl1.ScrollMaxY = 0R
        Me.ZedGraphControl1.ScrollMaxY2 = 0R
        Me.ZedGraphControl1.ScrollMinX = 0R
        Me.ZedGraphControl1.ScrollMinY = 0R
        Me.ZedGraphControl1.ScrollMinY2 = 0R
        Me.ZedGraphControl1.Size = New System.Drawing.Size(1131, 506)
        Me.ZedGraphControl1.TabIndex = 0
        '
        'btnEinlesen
        '
        Me.btnEinlesen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnEinlesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEinlesen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEinlesen.ImageIndex = 0
        Me.btnEinlesen.ImageList = Me.imgAuktionsmanagement
        Me.btnEinlesen.Location = New System.Drawing.Point(439, 16)
        Me.btnEinlesen.Name = "btnEinlesen"
        Me.btnEinlesen.Size = New System.Drawing.Size(222, 23)
        Me.btnEinlesen.TabIndex = 2
        Me.btnEinlesen.Text = "&Umsätze einlesen"
        Me.btnEinlesen.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage5.Controls.Add(Me.optMeisteStaedte)
        Me.TabPage5.Controls.Add(Me.optTeuersterArtikel)
        Me.TabPage5.Controls.Add(Me.optMeistegebote)
        Me.TabPage5.Controls.Add(Me.optTopKundenListe)
        Me.TabPage5.Controls.Add(Me.optStatHerkunftsland)
        Me.TabPage5.Controls.Add(Me.optStatUmsatz)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.progStatistik)
        Me.TabPage5.Controls.Add(Me.lvwStatisticText)
        Me.TabPage5.ImageIndex = 19
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1142, 541)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Text"
        '
        'optMeisteStaedte
        '
        Me.optMeisteStaedte.AutoSize = True
        Me.optMeisteStaedte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optMeisteStaedte.Location = New System.Drawing.Point(608, 28)
        Me.optMeisteStaedte.Name = "optMeisteStaedte"
        Me.optMeisteStaedte.Size = New System.Drawing.Size(120, 17)
        Me.optMeisteStaedte.TabIndex = 35
        Me.optMeisteStaedte.Text = "&Häufige Städte"
        Me.optMeisteStaedte.UseVisualStyleBackColor = True
        '
        'optTeuersterArtikel
        '
        Me.optTeuersterArtikel.AutoSize = True
        Me.optTeuersterArtikel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTeuersterArtikel.Location = New System.Drawing.Point(466, 28)
        Me.optTeuersterArtikel.Name = "optTeuersterArtikel"
        Me.optTeuersterArtikel.Size = New System.Drawing.Size(130, 17)
        Me.optTeuersterArtikel.TabIndex = 34
        Me.optTeuersterArtikel.Text = "&Teuerste Artikel"
        Me.optTeuersterArtikel.UseVisualStyleBackColor = True
        '
        'optMeistegebote
        '
        Me.optMeistegebote.AutoSize = True
        Me.optMeistegebote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optMeistegebote.Location = New System.Drawing.Point(344, 28)
        Me.optMeistegebote.Name = "optMeistegebote"
        Me.optMeistegebote.Size = New System.Drawing.Size(116, 17)
        Me.optMeistegebote.TabIndex = 33
        Me.optMeistegebote.Text = "&Meiste Gebote"
        Me.optMeistegebote.UseVisualStyleBackColor = True
        '
        'optTopKundenListe
        '
        Me.optTopKundenListe.AutoSize = True
        Me.optTopKundenListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTopKundenListe.Location = New System.Drawing.Point(242, 28)
        Me.optTopKundenListe.Name = "optTopKundenListe"
        Me.optTopKundenListe.Size = New System.Drawing.Size(96, 17)
        Me.optTopKundenListe.TabIndex = 32
        Me.optTopKundenListe.Text = "&Topkunden"
        Me.optTopKundenListe.UseVisualStyleBackColor = True
        '
        'optStatHerkunftsland
        '
        Me.optStatHerkunftsland.AutoSize = True
        Me.optStatHerkunftsland.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optStatHerkunftsland.Location = New System.Drawing.Point(120, 28)
        Me.optStatHerkunftsland.Name = "optStatHerkunftsland"
        Me.optStatHerkunftsland.Size = New System.Drawing.Size(116, 17)
        Me.optStatHerkunftsland.TabIndex = 31
        Me.optStatHerkunftsland.Text = "&Herkunftsland"
        Me.optStatHerkunftsland.UseVisualStyleBackColor = True
        '
        'optStatUmsatz
        '
        Me.optStatUmsatz.AutoSize = True
        Me.optStatUmsatz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optStatUmsatz.Location = New System.Drawing.Point(42, 28)
        Me.optStatUmsatz.Name = "optStatUmsatz"
        Me.optStatUmsatz.Size = New System.Drawing.Size(72, 17)
        Me.optStatUmsatz.TabIndex = 30
        Me.optStatUmsatz.Text = "&Umsatz"
        Me.optStatUmsatz.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Statistiken abrufen:"
        '
        'progStatistik
        '
        Me.progStatistik.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progStatistik.Location = New System.Drawing.Point(5, 57)
        Me.progStatistik.Name = "progStatistik"
        Me.progStatistik.Size = New System.Drawing.Size(1132, 14)
        Me.progStatistik.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progStatistik.TabIndex = 27
        Me.progStatistik.Visible = False
        '
        'lvwStatisticText
        '
        Me.lvwStatisticText.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwStatisticText.AllowColumnReorder = True
        Me.lvwStatisticText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwStatisticText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwStatisticText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwStatisticText.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Name, Me.Anzahl})
        Me.lvwStatisticText.ContextMenuStrip = Me.cmsStatistik_text
        Me.lvwStatisticText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwStatisticText.FullRowSelect = True
        Me.lvwStatisticText.GridLines = True
        Me.lvwStatisticText.HideSelection = False
        Me.lvwStatisticText.Location = New System.Drawing.Point(6, 77)
        Me.lvwStatisticText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lvwStatisticText.MultiSelect = False
        Me.lvwStatisticText.Name = "lvwStatisticText"
        Me.lvwStatisticText.Size = New System.Drawing.Size(1131, 478)
        Me.lvwStatisticText.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwStatisticText.TabIndex = 26
        Me.lvwStatisticText.UseCompatibleStateImageBehavior = False
        Me.lvwStatisticText.View = System.Windows.Forms.View.Details
        '
        'Name
        '
        Me.Name.Text = "Name"
        '
        'Anzahl
        '
        Me.Anzahl.Text = "Anzahl"
        '
        'cmsStatistik_text
        '
        Me.cmsStatistik_text.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ÄndernToolStripMenuItem, Me.ToolStripSeparator41, Me.ToolStripMenuItem12})
        Me.cmsStatistik_text.Name = "cmsStatistik_text"
        Me.cmsStatistik_text.Size = New System.Drawing.Size(280, 98)
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Image = Global.YabE.My.Resources.Resources.search2
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(279, 22)
        Me.ToolStripMenuItem13.Text = "Suche -> &Kunden"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem14.Image = Global.YabE.My.Resources.Resources._19
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(279, 22)
        Me.ToolStripMenuItem14.Text = "&Kundenverlauf..."
        Me.ToolStripMenuItem14.ToolTipText = "Zeigt vom Kunden vorherige Bestellunge an "
        '
        'ÄndernToolStripMenuItem
        '
        Me.ÄndernToolStripMenuItem.Name = "ÄndernToolStripMenuItem"
        Me.ÄndernToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
        Me.ÄndernToolStripMenuItem.Text = "&Suchen und Ersetzen Ändern..."
        '
        'ToolStripSeparator41
        '
        Me.ToolStripSeparator41.Name = "ToolStripSeparator41"
        Me.ToolStripSeparator41.Size = New System.Drawing.Size(276, 6)
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(279, 22)
        Me.ToolStripMenuItem12.Text = "YABE -> &Exportieren der Ansicht"
        Me.ToolStripMenuItem12.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'menue_meineBay
        '
        Me.menue_meineBay.Controls.Add(Me.tbMeineBay)
        Me.menue_meineBay.ImageIndex = 11
        Me.menue_meineBay.Location = New System.Drawing.Point(4, 63)
        Me.menue_meineBay.Name = "menue_meineBay"
        Me.menue_meineBay.Size = New System.Drawing.Size(1150, 571)
        Me.menue_meineBay.TabIndex = 10
        Me.menue_meineBay.Text = "Mein eBay"
        Me.menue_meineBay.UseVisualStyleBackColor = True
        '
        'tbMeineBay
        '
        Me.tbMeineBay.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbMeineBay.Controls.Add(Me.TabPage1)
        Me.tbMeineBay.Controls.Add(Me.TabPage2)
        Me.tbMeineBay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMeineBay.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tbMeineBay.ImageList = Me.imgAuktionsmanagement
        Me.tbMeineBay.Location = New System.Drawing.Point(0, 0)
        Me.tbMeineBay.Name = "tbMeineBay"
        Me.tbMeineBay.SelectedIndex = 0
        Me.tbMeineBay.Size = New System.Drawing.Size(1150, 571)
        Me.tbMeineBay.TabIndex = 95
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.btnMeineBayÖffnen)
        Me.TabPage1.Controls.Add(Me.lvwEbayNachrichten)
        Me.TabPage1.Controls.Add(Me.DatePickStartTo)
        Me.TabPage1.Controls.Add(Me.BtnGetMemberMessages)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.LblTimeRange)
        Me.TabPage1.Controls.Add(Me.LblStartSep)
        Me.TabPage1.Controls.Add(Me.DatePickStartFrom)
        Me.TabPage1.Controls.Add(Me.CboType)
        Me.TabPage1.Controls.Add(Me.LblType)
        Me.TabPage1.Controls.Add(Me.LblStatus)
        Me.TabPage1.Controls.Add(Me.CboStatus)
        Me.TabPage1.ImageIndex = 5
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1142, 541)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Meine eBay Nachrichten"
        '
        'btnMeineBayÖffnen
        '
        Me.btnMeineBayÖffnen.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnMeineBayÖffnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeineBayÖffnen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMeineBayÖffnen.ImageKey = "accept.png"
        Me.btnMeineBayÖffnen.ImageList = Me.imgAuktionsmanagement
        Me.btnMeineBayÖffnen.Location = New System.Drawing.Point(455, 74)
        Me.btnMeineBayÖffnen.Name = "btnMeineBayÖffnen"
        Me.btnMeineBayÖffnen.Size = New System.Drawing.Size(243, 23)
        Me.btnMeineBayÖffnen.TabIndex = 95
        Me.btnMeineBayÖffnen.Text = "&Mein eBay öffnen"
        Me.btnMeineBayÖffnen.UseVisualStyleBackColor = False
        '
        'lvwEbayNachrichten
        '
        Me.lvwEbayNachrichten.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwEbayNachrichten.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwEbayNachrichten.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvwEbayNachrichten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwEbayNachrichten.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ClmMessageId, Me.ClmStatus, Me.ColumnHeader16, Me.ClmSender, Me.ClmBody})
        Me.lvwEbayNachrichten.ContextMenuStrip = Me.cmseBayNachrichten
        Me.lvwEbayNachrichten.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEbayNachrichten.FullRowSelect = True
        Me.lvwEbayNachrichten.GridLines = True
        Me.lvwEbayNachrichten.HideSelection = False
        Me.lvwEbayNachrichten.Location = New System.Drawing.Point(6, 103)
        Me.lvwEbayNachrichten.MultiSelect = False
        Me.lvwEbayNachrichten.Name = "lvwEbayNachrichten"
        Me.lvwEbayNachrichten.Size = New System.Drawing.Size(1130, 452)
        Me.lvwEbayNachrichten.TabIndex = 4
        Me.lvwEbayNachrichten.UseCompatibleStateImageBehavior = False
        Me.lvwEbayNachrichten.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "eBayID"
        Me.ColumnHeader15.Width = 101
        '
        'ClmMessageId
        '
        Me.ClmMessageId.Text = "MID"
        Me.ClmMessageId.Width = 130
        '
        'ClmStatus
        '
        Me.ClmStatus.Text = "Status"
        Me.ClmStatus.Width = 116
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Fragetyp"
        Me.ColumnHeader16.Width = 133
        '
        'ClmSender
        '
        Me.ClmSender.Text = "Sender"
        Me.ClmSender.Width = 191
        '
        'ClmBody
        '
        Me.ClmBody.Text = "Frage"
        Me.ClmBody.Width = 429
        '
        'cmseBayNachrichten
        '
        Me.cmseBayNachrichten.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EBayÖffnenToolStripMenuItem1, Me.ExportierenToolStripMenuItem4})
        Me.cmseBayNachrichten.Name = "cmseBayNachrichten"
        Me.cmseBayNachrichten.Size = New System.Drawing.Size(233, 48)
        '
        'EBayÖffnenToolStripMenuItem1
        '
        Me.EBayÖffnenToolStripMenuItem1.Image = Global.YabE.My.Resources.Resources.firefox_button
        Me.EBayÖffnenToolStripMenuItem1.Name = "EBayÖffnenToolStripMenuItem1"
        Me.EBayÖffnenToolStripMenuItem1.Size = New System.Drawing.Size(232, 22)
        Me.EBayÖffnenToolStripMenuItem1.Text = "&eBayArtikel öffnen"
        '
        'ExportierenToolStripMenuItem4
        '
        Me.ExportierenToolStripMenuItem4.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportierenToolStripMenuItem4.Name = "ExportierenToolStripMenuItem4"
        Me.ExportierenToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportierenToolStripMenuItem4.Size = New System.Drawing.Size(232, 22)
        Me.ExportierenToolStripMenuItem4.Text = "&Übersicht exportieren..."
        Me.ExportierenToolStripMenuItem4.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'DatePickStartTo
        '
        Me.DatePickStartTo.CalendarMonthBackground = System.Drawing.Color.Gainsboro
        Me.DatePickStartTo.CustomFormat = ""
        Me.DatePickStartTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickStartTo.Location = New System.Drawing.Point(454, 48)
        Me.DatePickStartTo.Name = "DatePickStartTo"
        Me.DatePickStartTo.Size = New System.Drawing.Size(244, 20)
        Me.DatePickStartTo.TabIndex = 85
        '
        'BtnGetMemberMessages
        '
        Me.BtnGetMemberMessages.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetMemberMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetMemberMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetMemberMessages.ImageKey = "accept.png"
        Me.BtnGetMemberMessages.Location = New System.Drawing.Point(101, 74)
        Me.BtnGetMemberMessages.Name = "BtnGetMemberMessages"
        Me.BtnGetMemberMessages.Size = New System.Drawing.Size(243, 23)
        Me.BtnGetMemberMessages.TabIndex = 81
        Me.BtnGetMemberMessages.Text = "&eBay Nachrichten abrufen"
        Me.BtnGetMemberMessages.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(418, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 16)
        Me.Label26.TabIndex = 93
        Me.Label26.Text = "Bis"
        '
        'LblTimeRange
        '
        Me.LblTimeRange.Location = New System.Drawing.Point(14, 53)
        Me.LblTimeRange.Name = "LblTimeRange"
        Me.LblTimeRange.Size = New System.Drawing.Size(64, 16)
        Me.LblTimeRange.TabIndex = 94
        Me.LblTimeRange.Text = "Zeitfilter:"
        '
        'LblStartSep
        '
        Me.LblStartSep.Location = New System.Drawing.Point(409, 48)
        Me.LblStartSep.Name = "LblStartSep"
        Me.LblStartSep.Size = New System.Drawing.Size(16, 23)
        Me.LblStartSep.TabIndex = 83
        Me.LblStartSep.Text = " - "
        '
        'DatePickStartFrom
        '
        Me.DatePickStartFrom.CalendarMonthBackground = System.Drawing.Color.Gainsboro
        Me.DatePickStartFrom.CustomFormat = ""
        Me.DatePickStartFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickStartFrom.Location = New System.Drawing.Point(100, 48)
        Me.DatePickStartFrom.Name = "DatePickStartFrom"
        Me.DatePickStartFrom.Size = New System.Drawing.Size(244, 20)
        Me.DatePickStartFrom.TabIndex = 84
        '
        'CboType
        '
        Me.CboType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboType.Location = New System.Drawing.Point(455, 14)
        Me.CboType.Name = "CboType"
        Me.CboType.Size = New System.Drawing.Size(243, 21)
        Me.CboType.TabIndex = 91
        '
        'LblType
        '
        Me.LblType.Location = New System.Drawing.Point(402, 14)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(80, 18)
        Me.LblType.TabIndex = 90
        Me.LblType.Text = "Type:"
        '
        'LblStatus
        '
        Me.LblStatus.Location = New System.Drawing.Point(18, 14)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(80, 18)
        Me.LblStatus.TabIndex = 88
        Me.LblStatus.Text = "Status:"
        '
        'CboStatus
        '
        Me.CboStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboStatus.Location = New System.Drawing.Point(101, 14)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(243, 21)
        Me.CboStatus.TabIndex = 89
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.TxtAccBalance)
        Me.TabPage2.Controls.Add(Me.DatePickTo)
        Me.TabPage2.Controls.Add(Me.TxtPayMethod)
        Me.TabPage2.Controls.Add(Me.DatePickFrom)
        Me.TabPage2.Controls.Add(Me.LblPayMethod)
        Me.TabPage2.Controls.Add(Me.DatePickInvoice)
        Me.TabPage2.Controls.Add(Me.LblAccBalance)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.txtBezahltag)
        Me.TabPage2.Controls.Add(Me.OptRange)
        Me.TabPage2.Controls.Add(Me.TxtAccState)
        Me.TabPage2.Controls.Add(Me.OptInvoiceDate)
        Me.TabPage2.Controls.Add(Me.LblAccState)
        Me.TabPage2.Controls.Add(Me.OptLastInvoice)
        Me.TabPage2.Controls.Add(Me.LblEntries)
        Me.TabPage2.Controls.Add(Me.BtnGetAccount)
        Me.TabPage2.Controls.Add(Me.lvwEbayRechnung)
        Me.TabPage2.ImageIndex = 15
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1142, 541)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Meine eBay Rechnungen"
        '
        'TxtAccBalance
        '
        Me.TxtAccBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtAccBalance.BackColor = System.Drawing.Color.White
        Me.TxtAccBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAccBalance.Location = New System.Drawing.Point(851, 526)
        Me.TxtAccBalance.Name = "TxtAccBalance"
        Me.TxtAccBalance.ReadOnly = True
        Me.TxtAccBalance.Size = New System.Drawing.Size(165, 14)
        Me.TxtAccBalance.TabIndex = 18
        '
        'DatePickTo
        '
        Me.DatePickTo.CustomFormat = ""
        Me.DatePickTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickTo.Location = New System.Drawing.Point(576, 50)
        Me.DatePickTo.Name = "DatePickTo"
        Me.DatePickTo.Size = New System.Drawing.Size(187, 20)
        Me.DatePickTo.TabIndex = 66
        '
        'TxtPayMethod
        '
        Me.TxtPayMethod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtPayMethod.BackColor = System.Drawing.Color.White
        Me.TxtPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPayMethod.Location = New System.Drawing.Point(373, 526)
        Me.TxtPayMethod.Name = "TxtPayMethod"
        Me.TxtPayMethod.ReadOnly = True
        Me.TxtPayMethod.Size = New System.Drawing.Size(165, 14)
        Me.TxtPayMethod.TabIndex = 19
        '
        'DatePickFrom
        '
        Me.DatePickFrom.CustomFormat = ""
        Me.DatePickFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickFrom.Location = New System.Drawing.Point(354, 49)
        Me.DatePickFrom.Name = "DatePickFrom"
        Me.DatePickFrom.Size = New System.Drawing.Size(193, 20)
        Me.DatePickFrom.TabIndex = 65
        '
        'LblPayMethod
        '
        Me.LblPayMethod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPayMethod.Location = New System.Drawing.Point(272, 526)
        Me.LblPayMethod.Name = "LblPayMethod"
        Me.LblPayMethod.Size = New System.Drawing.Size(127, 23)
        Me.LblPayMethod.TabIndex = 21
        Me.LblPayMethod.Text = "Bezahlmethode"
        '
        'DatePickInvoice
        '
        Me.DatePickInvoice.CustomFormat = ""
        Me.DatePickInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickInvoice.Location = New System.Drawing.Point(354, 17)
        Me.DatePickInvoice.Name = "DatePickInvoice"
        Me.DatePickInvoice.Size = New System.Drawing.Size(193, 20)
        Me.DatePickInvoice.TabIndex = 64
        '
        'LblAccBalance
        '
        Me.LblAccBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblAccBalance.Location = New System.Drawing.Point(760, 528)
        Me.LblAccBalance.Name = "LblAccBalance"
        Me.LblAccBalance.Size = New System.Drawing.Size(96, 23)
        Me.LblAccBalance.TabIndex = 20
        Me.LblAccBalance.Text = "Kontostand"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(783, 49)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(16, 23)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = " - "
        '
        'txtBezahltag
        '
        Me.txtBezahltag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBezahltag.BackColor = System.Drawing.Color.White
        Me.txtBezahltag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBezahltag.Location = New System.Drawing.Point(97, 528)
        Me.txtBezahltag.Name = "txtBezahltag"
        Me.txtBezahltag.ReadOnly = True
        Me.txtBezahltag.Size = New System.Drawing.Size(159, 14)
        Me.txtBezahltag.TabIndex = 17
        '
        'OptRange
        '
        Me.OptRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptRange.Location = New System.Drawing.Point(210, 48)
        Me.OptRange.Name = "OptRange"
        Me.OptRange.Size = New System.Drawing.Size(128, 24)
        Me.OptRange.TabIndex = 62
        Me.OptRange.Text = "Zwischen"
        '
        'TxtAccState
        '
        Me.TxtAccState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtAccState.BackColor = System.Drawing.Color.White
        Me.TxtAccState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAccState.Location = New System.Drawing.Point(621, 526)
        Me.TxtAccState.Name = "TxtAccState"
        Me.TxtAccState.ReadOnly = True
        Me.TxtAccState.Size = New System.Drawing.Size(122, 14)
        Me.TxtAccState.TabIndex = 17
        '
        'OptInvoiceDate
        '
        Me.OptInvoiceDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptInvoiceDate.Location = New System.Drawing.Point(210, 18)
        Me.OptInvoiceDate.Name = "OptInvoiceDate"
        Me.OptInvoiceDate.Size = New System.Drawing.Size(150, 24)
        Me.OptInvoiceDate.TabIndex = 61
        Me.OptInvoiceDate.Text = "Rechnungsdatum"
        '
        'LblAccState
        '
        Me.LblAccState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblAccState.Location = New System.Drawing.Point(564, 528)
        Me.LblAccState.Name = "LblAccState"
        Me.LblAccState.Size = New System.Drawing.Size(51, 23)
        Me.LblAccState.TabIndex = 16
        Me.LblAccState.Text = "Status"
        '
        'OptLastInvoice
        '
        Me.OptLastInvoice.Checked = True
        Me.OptLastInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptLastInvoice.Location = New System.Drawing.Point(31, 18)
        Me.OptLastInvoice.Name = "OptLastInvoice"
        Me.OptLastInvoice.Size = New System.Drawing.Size(186, 24)
        Me.OptLastInvoice.TabIndex = 60
        Me.OptLastInvoice.TabStop = True
        Me.OptLastInvoice.Text = "Seitdem letzten Einzug"
        '
        'LblEntries
        '
        Me.LblEntries.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblEntries.Location = New System.Drawing.Point(19, 528)
        Me.LblEntries.Name = "LblEntries"
        Me.LblEntries.Size = New System.Drawing.Size(91, 23)
        Me.LblEntries.TabIndex = 14
        Me.LblEntries.Text = "Bezahltag"
        '
        'BtnGetAccount
        '
        Me.BtnGetAccount.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetAccount.Image = Global.YabE.My.Resources.Resources._24
        Me.BtnGetAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetAccount.Location = New System.Drawing.Point(576, 18)
        Me.BtnGetAccount.Name = "BtnGetAccount"
        Me.BtnGetAccount.Size = New System.Drawing.Size(281, 26)
        Me.BtnGetAccount.TabIndex = 59
        Me.BtnGetAccount.Text = "    Rechnung anzeigen"
        Me.BtnGetAccount.UseVisualStyleBackColor = False
        '
        'lvwEbayRechnung
        '
        Me.lvwEbayRechnung.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwEbayRechnung.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwEbayRechnung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwEbayRechnung.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmRef, Me.clmTitel, Me.ColumnHeader17, Me.ColumnHeader18, Me.ClmBalance, Me.ClmDate})
        Me.lvwEbayRechnung.ContextMenuStrip = Me.cmsRechnungen
        Me.lvwEbayRechnung.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEbayRechnung.FullRowSelect = True
        Me.lvwEbayRechnung.GridLines = True
        Me.lvwEbayRechnung.HideSelection = False
        Me.lvwEbayRechnung.Location = New System.Drawing.Point(22, 78)
        Me.lvwEbayRechnung.MultiSelect = False
        Me.lvwEbayRechnung.Name = "lvwEbayRechnung"
        Me.lvwEbayRechnung.Size = New System.Drawing.Size(1114, 432)
        Me.lvwEbayRechnung.TabIndex = 15
        Me.lvwEbayRechnung.UseCompatibleStateImageBehavior = False
        Me.lvwEbayRechnung.View = System.Windows.Forms.View.Details
        '
        'ClmRef
        '
        Me.ClmRef.Text = "Referenz"
        Me.ClmRef.Width = 0
        '
        'clmTitel
        '
        Me.clmTitel.Text = "Titel"
        Me.clmTitel.Width = 422
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Type"
        Me.ColumnHeader17.Width = 159
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "eBayID"
        Me.ColumnHeader18.Width = 122
        '
        'ClmBalance
        '
        Me.ClmBalance.Text = "Saldo"
        Me.ClmBalance.Width = 125
        '
        'ClmDate
        '
        Me.ClmDate.Text = "Datum"
        Me.ClmDate.Width = 161
        '
        'cmsRechnungen
        '
        Me.cmsRechnungen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EBayÖffnenToolStripMenuItem2, Me.ToolStripSeparator39, Me.ExportierenToolStripMenuItem3})
        Me.cmsRechnungen.Name = "cmsRechnungen"
        Me.cmsRechnungen.Size = New System.Drawing.Size(233, 54)
        '
        'EBayÖffnenToolStripMenuItem2
        '
        Me.EBayÖffnenToolStripMenuItem2.Image = Global.YabE.My.Resources.Resources.firefox_button
        Me.EBayÖffnenToolStripMenuItem2.Name = "EBayÖffnenToolStripMenuItem2"
        Me.EBayÖffnenToolStripMenuItem2.Size = New System.Drawing.Size(232, 22)
        Me.EBayÖffnenToolStripMenuItem2.Text = "&eBay Artikel öffnen"
        '
        'ToolStripSeparator39
        '
        Me.ToolStripSeparator39.Name = "ToolStripSeparator39"
        Me.ToolStripSeparator39.Size = New System.Drawing.Size(229, 6)
        '
        'ExportierenToolStripMenuItem3
        '
        Me.ExportierenToolStripMenuItem3.Image = Global.YabE.My.Resources.Resources.folder_files
        Me.ExportierenToolStripMenuItem3.Name = "ExportierenToolStripMenuItem3"
        Me.ExportierenToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExportierenToolStripMenuItem3.Size = New System.Drawing.Size(232, 22)
        Me.ExportierenToolStripMenuItem3.Text = "&Übersicht exportieren..."
        Me.ExportierenToolStripMenuItem3.ToolTipText = "Export die Ansicht als *.CSV"
        '
        'lblKundenMessage
        '
        Me.lblKundenMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblKundenMessage.AutoSize = True
        Me.lblKundenMessage.Location = New System.Drawing.Point(846, 667)
        Me.lblKundenMessage.Name = "lblKundenMessage"
        Me.lblKundenMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblKundenMessage.TabIndex = 18
        '
        'txtSuchen
        '
        Me.txtSuchen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSuchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuchen.ForeColor = System.Drawing.Color.DimGray
        Me.txtSuchen.Location = New System.Drawing.Point(13, 667)
        Me.txtSuchen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSuchen.Name = "txtSuchen"
        Me.txtSuchen.Size = New System.Drawing.Size(387, 21)
        Me.txtSuchen.TabIndex = 2
        Me.txtSuchen.Text = "Suchbegriff..."
        '
        'cmsHomepageGalerie
        '
        Me.cmsHomepageGalerie.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebinterfaceToolStripMenuItem})
        Me.cmsHomepageGalerie.Name = "cmsHomepageGalerie"
        Me.cmsHomepageGalerie.Size = New System.Drawing.Size(145, 26)
        '
        'WebinterfaceToolStripMenuItem
        '
        Me.WebinterfaceToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.firefox_button
        Me.WebinterfaceToolStripMenuItem.Name = "WebinterfaceToolStripMenuItem"
        Me.WebinterfaceToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.WebinterfaceToolStripMenuItem.Text = "&Webinterface"
        '
        'tmrEMailWaitTime
        '
        '
        'lblLiveMessage
        '
        Me.lblLiveMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblLiveMessage.AutoSize = True
        Me.lblLiveMessage.Location = New System.Drawing.Point(595, 670)
        Me.lblLiveMessage.Name = "lblLiveMessage"
        Me.lblLiveMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblLiveMessage.TabIndex = 21
        Me.lblLiveMessage.Visible = False
        '
        'ballonITips
        '
        Me.ballonITips.AutomaticDelay = 0
        Me.ballonITips.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ballonITips.IsBalloon = True
        Me.ballonITips.OwnerDraw = True
        Me.ballonITips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ballonITips.ToolTipTitle = "EiSo Hilfe"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 12
        Me.btnRefresh.Location = New System.Drawing.Point(18, 28)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(106, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "  &Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'tmrEbayTime
        '
        Me.tmrEbayTime.Interval = 1000
        '
        'getThreadSearch
        '
        Me.getThreadSearch.WorkerReportsProgress = True
        Me.getThreadSearch.WorkerSupportsCancellation = True
        '
        'tmrEbayZeitWarten
        '
        Me.tmrEbayZeitWarten.Interval = 3000
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbbrechen.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.btnAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbbrechen.Location = New System.Drawing.Point(601, 665)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(175, 23)
        Me.btnAbbrechen.TabIndex = 22
        Me.btnAbbrechen.Text = "&Stoppen"
        Me.btnAbbrechen.UseVisualStyleBackColor = False
        '
        'btnSuchen
        '
        Me.btnSuchen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSuchen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuchen.ImageIndex = 2
        Me.btnSuchen.ImageList = Me.imgAuktionsmanagement
        Me.btnSuchen.Location = New System.Drawing.Point(408, 665)
        Me.btnSuchen.Name = "btnSuchen"
        Me.btnSuchen.Size = New System.Drawing.Size(175, 23)
        Me.btnSuchen.TabIndex = 8
        Me.btnSuchen.Text = "Suche starten"
        Me.btnSuchen.UseVisualStyleBackColor = False
        '
        'chkEiSoArtikelverwaltung_kunden_details
        '
        Me.chkEiSoArtikelverwaltung_kunden_details.AutoSize = True
        Me.chkEiSoArtikelverwaltung_kunden_details.Checked = True
        Me.chkEiSoArtikelverwaltung_kunden_details.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEiSoArtikelverwaltung_kunden_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEiSoArtikelverwaltung_kunden_details.Location = New System.Drawing.Point(884, 61)
        Me.chkEiSoArtikelverwaltung_kunden_details.Name = "chkEiSoArtikelverwaltung_kunden_details"
        Me.chkEiSoArtikelverwaltung_kunden_details.Size = New System.Drawing.Size(120, 17)
        Me.chkEiSoArtikelverwaltung_kunden_details.TabIndex = 53
        Me.chkEiSoArtikelverwaltung_kunden_details.Text = "Kunden Details"
        Me.chkEiSoArtikelverwaltung_kunden_details.UseVisualStyleBackColor = True
        '
        'frmAuktionmanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1162, 690)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.lblKundenMessage)
        Me.Controls.Add(Me.txtSuchen)
        Me.Controls.Add(Me.btnSuchen)
        Me.Controls.Add(Me.lblLiveMessage)
        Me.Controls.Add(Me.tabMenue)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        '  Me.Name = "frmAuktionmanagement"
        Me.ShowInTaskbar = False
        Me.Text = "EiSo Verkaufsabwicklung"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabMenue.ResumeLayout(False)
        Me.menue_eBay_Live.ResumeLayout(False)
        Me.menue_eBay_Live.PerformLayout()
        Me.lvwLiveAnsicht.ResumeLayout(False)
        Me.menue_kunden.ResumeLayout(False)
        Me.menue_kunden.PerformLayout()
        Me.cmsKundenListview.ResumeLayout(False)
        Me.menue_bestellverlauf.ResumeLayout(False)
        Me.menue_bestellverlauf.PerformLayout()
        Me.tcBestellungen_visual.ResumeLayout(False)
        Me.listenansicht.ResumeLayout(False)
        Me.cmsEiSoBestellungen.ResumeLayout(False)
        Me.bestelliste.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.cmsBestellungen_kunden.ResumeLayout(False)
        Me.cmsBestellungen_bestellungen.ResumeLayout(False)
        Me.menue_shopste.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.cmsShopsteKategorie.ResumeLayout(False)
        Me.cmsShopsteArtikel.ResumeLayout(False)
        Me.menue_artikelverwaltung.ResumeLayout(False)
        Me.tab_verwaltung.ResumeLayout(False)
        Me.eshop_daten.ResumeLayout(False)
        Me.eshop_daten.PerformLayout()
        Me.cms_splitcontainer.Panel1.ResumeLayout(False)
        Me.cms_splitcontainer.Panel2.ResumeLayout(False)
        CType(Me.cms_splitcontainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_splitcontainer.ResumeLayout(False)
        Me.cms_KategorieListe.ResumeLayout(False)
        Me.cms_ArtikelVerwaltung.ResumeLayout(False)
        Me.cms_ArtikelVerwaltung.PerformLayout()
        Me.eshop_bestellungen.ResumeLayout(False)
        Me.eshop_bilderprüfung.ResumeLayout(False)
        Me.cmseBayGalerie_neu.ResumeLayout(False)
        Me.menue_tbPaypal.ResumeLayout(False)
        Me.tabPaypal.ResumeLayout(False)
        Me.tab_paypal_api.ResumeLayout(False)
        Me.tab_paypal_api.PerformLayout()
        Me.cmsPaypal.ResumeLayout(False)
        Me.tab_paypal_schnellberechnung.ResumeLayout(False)
        Me.tab_paypal_schnellberechnung.PerformLayout()
        Me.menue_eBayBewertungen.ResumeLayout(False)
        Me.menue_eBayBewertungen.PerformLayout()
        Me.cmseBayBewertung.ResumeLayout(False)
        Me.menue_Mailversand.ResumeLayout(False)
        Me.menue_Mailversand.PerformLayout()
        Me.cmsNewsletter.ResumeLayout(False)
        Me.menue_Statistik.ResumeLayout(False)
        Me.tabStatistics.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.cmsStatistik_text.ResumeLayout(False)
        Me.menue_meineBay.ResumeLayout(False)
        Me.tbMeineBay.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.cmseBayNachrichten.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.cmsRechnungen.ResumeLayout(False)
        Me.cmsHomepageGalerie.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menue_bestellverlauf As System.Windows.Forms.TabPage
    Friend WithEvents menue_kunden As System.Windows.Forms.TabPage
    Friend WithEvents lvwKunden As System.Windows.Forms.ListView
    Friend WithEvents kd_nachname As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_strasse As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_PLZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_Ort As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_Land As System.Windows.Forms.ColumnHeader
    Friend WithEvents menue_Mailversand As System.Windows.Forms.TabPage
    Friend WithEvents kd_eMail As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_käufe As System.Windows.Forms.ColumnHeader
    Friend WithEvents menue_eBay_Live As System.Windows.Forms.TabPage
    Friend WithEvents menue_Statistik As System.Windows.Forms.TabPage
    Friend WithEvents menue_eBayBewertungen As System.Windows.Forms.TabPage
    Friend WithEvents lvwEiSoCockpit As System.Windows.Forms.ListView
    Friend WithEvents live_ebayID As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_beschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_endpreis As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_startpreis As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_gebote As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_ebaymitglied As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_completed_status As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvMailStatus As System.Windows.Forms.ListView
    Friend WithEvents mail_nr As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_Ort As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_anzahl As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_verschickt As System.Windows.Forms.ColumnHeader
    'Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pgrMailstatusGesammt As System.Windows.Forms.ProgressBar
    Friend WithEvents btnMailVersandStart As System.Windows.Forms.Button
    Friend WithEvents pgrBewertungenUpdate As System.Windows.Forms.ProgressBar
    Friend WithEvents chkAutomatischerModus As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartupRückbewertung As System.Windows.Forms.CheckBox
    Friend WithEvents lblVon As System.Windows.Forms.Label
    Friend WithEvents dtpCockpit_von As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBis As System.Windows.Forms.Label
    Friend WithEvents dtpCockpit_bis As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvwLiveAnsicht As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClmUser As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmScore As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmItemId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmComment As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmRole As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmseBayBewertung As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutobewertungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VarianteIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VarianteIIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VarianteIIIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiveÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmeBayLive_Detailansicht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAuktionEinlesen As System.Windows.Forms.Button
    Friend WithEvents btnRefreshBewertungen As System.Windows.Forms.Button
    Friend WithEvents txtSuchen As System.Windows.Forms.TextBox
    Friend WithEvents btnSuchen As System.Windows.Forms.Button
    Friend WithEvents BietverlaufToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HöchstbietenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents tabMenue As System.Windows.Forms.TabControl
    Friend WithEvents CopyEBayIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelBeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copy_Beschreibung As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents txtBewertungen As System.Windows.Forms.TextBox
    Friend WithEvents live_email As System.Windows.Forms.ColumnHeader
    Friend WithEvents EMailExternesProgrammToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAuftrag_email_senden As System.Windows.Forms.Button
    Friend WithEvents live_ListType As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnZurück As System.Windows.Forms.Button
    Friend WithEvents lblSeite As System.Windows.Forms.Label
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntfernenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents live_auktionend As System.Windows.Forms.ColumnHeader
    Friend WithEvents IsSendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkEndTime As System.Windows.Forms.CheckBox
    Friend WithEvents live_watchcounter As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_auktionbeginn As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_versandkosten As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_ebaybild As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_ArtikelVerwaltung As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnKundenHolen As System.Windows.Forms.Button
    Friend WithEvents kd_eBayName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsKundenListview As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BestellübersichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KundenBis As System.Windows.Forms.DateTimePicker
    Friend WithEvents KundenVon As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdressLabels As System.Windows.Forms.Button
    Friend WithEvents cmsHomepageGalerie As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WebinterfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblLive_von As System.Windows.Forms.Label
    Friend WithEvents lblLive_bis As System.Windows.Forms.Label
    Friend WithEvents eBayHistoryBis As System.Windows.Forms.DateTimePicker
    Friend WithEvents eBayHistoryVon As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBestellungen_abrufen As System.Windows.Forms.Button
    Friend WithEvents cmsEiSoBestellungen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lvwBestellverwaltung_nach_artikel As System.Windows.Forms.ListView
    Friend WithEvents eBayHistory_live As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayHistory_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayHistory_ort As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayHistory_title As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayHistory_preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayHistory_versandkosten As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayHistory_status As System.Windows.Forms.ColumnHeader
    Friend WithEvents eBayHistory_bewertet As System.Windows.Forms.ColumnHeader
    Friend WithEvents EBayÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyEBayIDToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eBayHistory_Account As System.Windows.Forms.ColumnHeader
    Friend WithEvents CopyEBayMitgliedsnameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menue_tbPaypal As System.Windows.Forms.TabPage
    Public WithEvents txtZwischensumme As System.Windows.Forms.TextBox
    Public WithEvents txtVersand As System.Windows.Forms.TextBox
    Public WithEvents cmdRechnen As System.Windows.Forms.Button
    Public WithEvents txtEndsumme As System.Windows.Forms.TextBox
    Public WithEvents txtSumme As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents clmTransaktionID As System.Windows.Forms.ColumnHeader
    Friend WithEvents BewertungsprofilÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BewertungsprofilinternToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EBayArtikelÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkBewertung_janein As System.Windows.Forms.CheckBox
    Friend WithEvents AlsBewertetSetzenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblKundenMessage As System.Windows.Forms.Label
    Friend WithEvents kd_Artikel As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_last As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents lblBewertung_bis As System.Windows.Forms.Label
    Friend WithEvents lblBewertung_von As System.Windows.Forms.Label
    Friend WithEvents dtp_BewertungBis As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_BewertungVon As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkLiveZeitfilter As System.Windows.Forms.CheckBox
    Friend WithEvents chkKundenZeitfilter As System.Windows.Forms.CheckBox
    Friend WithEvents chkHistoryZeitfilter As System.Windows.Forms.CheckBox
    Friend WithEvents chkBewertungZeitfilter As System.Windows.Forms.CheckBox
    Friend WithEvents BietverlaufToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menue_meineBay As System.Windows.Forms.TabPage
    Friend WithEvents menue_artikelverwaltung As System.Windows.Forms.TabPage
    Friend WithEvents lvwWebArtikel As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Beschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents Bild As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ÜberarbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuerArtikelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvwMenue As System.Windows.Forms.ListView
    Friend WithEvents cms_kategorieID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_menueName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_clickcount As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AktuellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestelltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AussortiertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tmrEMailWaitTime As System.Windows.Forms.Timer
    Friend WithEvents mail_crc As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_clicked As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_last_clicked As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAbschickenNewsletter As System.Windows.Forms.Button
    Friend WithEvents mail_sprache As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents cmsNewsletter As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VersendetEinstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mail_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkVerschickt As System.Windows.Forms.CheckBox
    Friend WithEvents mail_webuser As System.Windows.Forms.ColumnHeader
    Friend WithEvents VorschauAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsletterDeaktivierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmseBayGalerie_neu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EBayAnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblTimeRange As System.Windows.Forms.Label
    Friend WithEvents CboType As System.Windows.Forms.ComboBox
    Friend WithEvents LblType As System.Windows.Forms.Label
    Friend WithEvents CboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents DatePickStartTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatePickStartFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblStartSep As System.Windows.Forms.Label
    Friend WithEvents lvwEbayNachrichten As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmMessageId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmSender As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmBody As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnGetMemberMessages As System.Windows.Forms.Button
    Friend WithEvents tbMeineBay As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DatePickTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatePickFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatePickInvoice As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents OptRange As System.Windows.Forms.RadioButton
    Friend WithEvents OptInvoiceDate As System.Windows.Forms.RadioButton
    Friend WithEvents OptLastInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents BtnGetAccount As System.Windows.Forms.Button
    Friend WithEvents LblPayMethod As System.Windows.Forms.Label
    Friend WithEvents LblAccBalance As System.Windows.Forms.Label
    Friend WithEvents TxtPayMethod As System.Windows.Forms.TextBox
    Friend WithEvents TxtAccBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtBezahltag As System.Windows.Forms.TextBox
    Friend WithEvents TxtAccState As System.Windows.Forms.TextBox
    Friend WithEvents LblAccState As System.Windows.Forms.Label
    Friend WithEvents LblEntries As System.Windows.Forms.Label
    Friend WithEvents lvwEbayRechnung As System.Windows.Forms.ListView
    Friend WithEvents ClmRef As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmTitel As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmBalance As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmseBayNachrichten As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EBayÖffnenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRechnungen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EBayÖffnenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KundeLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayKundenInformationenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kd_newsletter As System.Windows.Forms.ColumnHeader
    Friend WithEvents BestellübersichtToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eBayHistory_eMail As System.Windows.Forms.ColumnHeader
    Friend WithEvents KundenverlaufToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkKundenFullReport As System.Windows.Forms.CheckBox
    Friend WithEvents ebayHistory_verkaufsende As System.Windows.Forms.ColumnHeader
    Friend WithEvents pgreBayLiveUpdate As System.Windows.Forms.ProgressBar
    Friend WithEvents ZedGraphControl1 As ZedGraph.ZedGraphControl
    Friend WithEvents btnEinlesen As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents tab_verwaltung As System.Windows.Forms.TabControl
    Friend WithEvents eshop_daten As System.Windows.Forms.TabPage
    Friend WithEvents eshop_bestellungen As System.Windows.Forms.TabPage
    Friend WithEvents btnGetCMSBestellungen As System.Windows.Forms.Button
    Friend WithEvents lvwGetBestellungen As System.Windows.Forms.ListView
    Friend WithEvents bestellungen_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents bestellungen_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents bestellung_artikel As System.Windows.Forms.ColumnHeader
    Friend WithEvents bestellung_bezahlmethode As System.Windows.Forms.ColumnHeader
    Friend WithEvents bestellungen_endsumme As System.Windows.Forms.ColumnHeader
    Friend WithEvents bestellungen_zeitpunkt As System.Windows.Forms.ColumnHeader
    Friend WithEvents bestellungen_woher As System.Windows.Forms.ColumnHeader
    Friend WithEvents HöchstbietenderBewertungsprofilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HöchstbietenderBewertungsprofilToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblLiveMessage As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGetSellerListSeiteVon As System.Windows.Forms.TextBox
    Friend WithEvents ballonITips As System.Windows.Forms.ToolTip
    Friend WithEvents btnLiveStopp As System.Windows.Forms.Button
    Friend WithEvents live_lastupdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents BestellübersichtToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pgreBayVerlaufUpdate As System.Windows.Forms.ProgressBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnNewsletterReset As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mail_country As System.Windows.Forms.ColumnHeader
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkNewsletterAlle As System.Windows.Forms.CheckBox
    Friend WithEvents ExportierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportierenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eshop_bilderprüfung As System.Windows.Forms.TabPage
    Friend WithEvents btnCheckPictures As System.Windows.Forms.Button
    Friend WithEvents btnTools_eBayGalerie As System.Windows.Forms.Button
    Friend WithEvents lvweBayGalerie As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabStatistics As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents progStatistik As System.Windows.Forms.ProgressBar
    Friend WithEvents lvwStatisticText As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Anzahl As System.Windows.Forms.ColumnHeader
    Friend WithEvents optStatUmsatz As System.Windows.Forms.RadioButton
    Friend WithEvents optStatHerkunftsland As System.Windows.Forms.RadioButton
    Friend WithEvents ExportierenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportierenToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mail_benutzername As System.Windows.Forms.ColumnHeader
    Friend WithEvents mail_user_pwd As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabPaypal As System.Windows.Forms.TabControl
    Friend WithEvents tab_paypal_schnellberechnung As System.Windows.Forms.TabPage
    Friend WithEvents tab_paypal_api As System.Windows.Forms.TabPage
    Friend WithEvents chkNurKlickt As System.Windows.Forms.CheckBox
    Friend WithEvents chkNewsletter_testmodus As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportierenToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayVerkaufseventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrEbayTime As System.Windows.Forms.Timer
    Friend WithEvents EBayBeschreibungErweiternToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEKundenverlaufToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayCrossPromotionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsletterAnabmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailVorschauAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgAuktionsmanagement As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents eBayHistoryGebote As System.Windows.Forms.ColumnHeader
    Friend WithEvents pgrKundenverlauf As System.Windows.Forms.ProgressBar
    Public WithEvents getThreadSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents VersandkostenberechnungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents live_hitcounter As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_eBayFragen As System.Windows.Forms.ColumnHeader
    Friend WithEvents optTopKundenListe As System.Windows.Forms.RadioButton
    Friend WithEvents optMeistegebote As System.Windows.Forms.RadioButton
    Friend WithEvents optTeuersterArtikel As System.Windows.Forms.RadioButton
    Friend WithEvents optMeisteStaedte As System.Windows.Forms.RadioButton
    Friend WithEvents btneBayAdressenHolen As System.Windows.Forms.Button
    Friend WithEvents tmrEbayZeitWarten As System.Windows.Forms.Timer
    Friend WithEvents ebayHistory_Gebühr As System.Windows.Forms.ColumnHeader
    Friend WithEvents magento_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkDebug_email As System.Windows.Forms.CheckBox
    Friend WithEvents ExportDelcampeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportStandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_KategorieListe As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelcampeKategorieIDZuweisenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoKategorieIDZuweisenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delcampe_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_kategorie_delcampe As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnMeineBayÖffnen As System.Windows.Forms.Button
    Friend WithEvents cms_splitcontainer As System.Windows.Forms.SplitContainer
    Friend WithEvents cms_kategorie_magento As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_hauptkategorie As System.Windows.Forms.ColumnHeader
    Friend WithEvents optCMSToogleKategorie As System.Windows.Forms.RadioButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents optCMSToogleBoth As System.Windows.Forms.RadioButton
    Friend WithEvents optCMSToogleArtikel As System.Windows.Forms.RadioButton
    Friend WithEvents RefreshKategorielisteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WebEBayBildAnsehenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelLöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportDelcampeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMagentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportStandardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmbennenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBilderprüfenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrüfeWebArtikel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbArtikelStatus As System.Windows.Forms.ComboBox
    Friend WithEvents live_auktion_plattform As System.Windows.Forms.ColumnHeader
    Friend WithEvents DelcampeKategorieIDZuweisenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoKategorieIDZuweisenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eBayHistory_plattform As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AktuallisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_datum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsBlidCounter As System.Windows.Forms.ColumnHeader
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
    Friend WithEvents lblKunden_Main_label As System.Windows.Forms.Label
    Friend WithEvents lblBestellungen_main As System.Windows.Forms.Label
    Friend WithEvents chkKundenHeute As System.Windows.Forms.CheckBox
    Friend WithEvents clmBeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents AnsichtAktuallisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnsichtAktuallisierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnsichtAktuallisierenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZuordnungArtikelKundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZuordnungArtikelKundeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelKomplettLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbPlattform_Live As System.Windows.Forms.ComboBox
    Friend WithEvents AlleMarkierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbStatPlattform As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbTranslationBereichAuswählen As System.Windows.Forms.ComboBox
    Friend WithEvents SucheArtikelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheKundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheBestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BestellungsstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BezahltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschicktToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BewertetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEArtikelübernahmeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_artikel As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkShopUpdateItemCount As System.Windows.Forms.CheckBox
    Friend WithEvents eBayHistory_bild As System.Windows.Forms.ColumnHeader
    Friend WithEvents EBayAuktionArtikeldetialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents live_paypal_endsumme As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KundenEditierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KundenNeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEAnsichtAktuallisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucheKundenbestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents YABEArtikelansichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kd_plattform As System.Windows.Forms.ColumnHeader
    Friend WithEvents ebayHistory_YABEID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StorniertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABERechnungsdruckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ebayHistory_Paypal As System.Windows.Forms.ColumnHeader
    Friend WithEvents EmailExternesProgrammToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErinnerungSendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ebayHistoryLand As System.Windows.Forms.ColumnHeader
    Friend WithEvents KopierenEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents live_yabe_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents OutlookSyncToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYNCCockpitBestellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SNYCEBayAPIDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ebayHistoryDelcampeID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ebayHistory_muttersprache As System.Windows.Forms.ColumnHeader
    Friend WithEvents YABEBestellverlaufProKundenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator29 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ebayHistory_straße As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_person_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents live_person_land As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator30 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents clmPreis As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmHitcounter As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmWatchcount As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmOrderStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SucheKundenBewertungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents kd_sprachenliste As System.Windows.Forms.ColumnHeader
    Friend WithEvents kd_muttersprache As System.Windows.Forms.ColumnHeader
    Friend WithEvents WebSucheBeiGoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelcampeArtikelansichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelcampeVersandkostenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelcampeBewertungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EBayArtikelansichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayVersandkostenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EBayBewertungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PersonensucheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TelefonnummernSucheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleMapsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonensucheToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TelefonummernSucheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleMapsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator36 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenEmailToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenArtikelIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEAnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruppiertNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupiertVerkaufsendeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruppiertLandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruppiertMutterspracheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruppiertBestellstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvwBewertungen As System.Windows.Forms.ListView
    Friend WithEvents DelcampeBestellsStatusAktuallisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivAktuallisierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents live_verschickt As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator37 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator39 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ebayHistory_sprachliste As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsStatistik_text As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator41 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SpracheZurücksetzenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEWebtranslatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSAnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator42 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbPlattform_bestellungen As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmbPlattform_kunden As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSprache_Artikeldatenbank As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chkArtikeldatenbank_edit As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents ArtikelSuchenUndErsetzenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FehlendeÜbersetzungenHolenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator43 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents KategorieHauptkategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategorieNeueSubkategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkBuyItNow As System.Windows.Forms.RadioButton
    Friend WithEvents chkGebote As System.Windows.Forms.RadioButton
    Friend WithEvents chkLiveAlle As System.Windows.Forms.RadioButton
    Friend WithEvents chkeBayEnde As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeboteOhne As System.Windows.Forms.RadioButton
    Friend WithEvents chkBestellungen_verkauft As System.Windows.Forms.RadioButton
    Friend WithEvents chkBestellungen_Storniert As System.Windows.Forms.RadioButton
    Friend WithEvents chkBestellungen_KeineBewertung As System.Windows.Forms.RadioButton
    Friend WithEvents chkBestellungen_Versand As System.Windows.Forms.RadioButton
    Friend WithEvents chkBestellungen_bezahlt As System.Windows.Forms.RadioButton
    Friend WithEvents chkBestellungenVerkauft As System.Windows.Forms.CheckBox
    Friend WithEvents chkBestellungen_Komplett As System.Windows.Forms.RadioButton
    Friend WithEvents chkBestellungen_Alle As System.Windows.Forms.RadioButton
    Friend WithEvents YABEImportVonArtikelnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YABEImportVonArtikelnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategorieLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelAlleImportiertenLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator44 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator45 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator47 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpracheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeutschToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglischToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FranzösichToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator48 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AutomatischSpracheÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenüÜbersetzungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BildLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruppiertKeineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator49 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator50 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator51 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator53 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator52 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkNewsletterIsWebuser As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lvwPaypal As System.Windows.Forms.ListView
    Friend WithEvents colPaypalName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPaypalStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPaypaEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtPaypal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnPaypal_abrufen As System.Windows.Forms.Button
    Friend WithEvents colPaypalTimestamp As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPaypalType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPaypalFee As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPaypalGesamt As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator38 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator54 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents colPaypalGrossAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsPaypal As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator55 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator46 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkNewsletterIseBay As System.Windows.Forms.CheckBox
    Friend WithEvents chkNewsletterIsDelcampe As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents SucheBewertungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SortierungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HochToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkeBayBewertungen_allebewerted As System.Windows.Forms.CheckBox
    Friend WithEvents chkeBayBewertung_automatischRE As System.Windows.Forms.CheckBox
    Friend WithEvents AnzahlUpdatenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYNCStatusBezahltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPaypalBestellstatus As System.Windows.Forms.Button
    Friend WithEvents EBayStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelLöschenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelBestelltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelAktivToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelLöschenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelBestelltToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelAktivierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeutschSuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglischSuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator56 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WartelisteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestelltToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AktivToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator57 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BildAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenüToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HatUntekategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeineUnterkategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeueKatGleicheEbeneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceOfficeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rbStatCurve As System.Windows.Forms.RadioButton
    Friend WithEvents rbStatBalken As System.Windows.Forms.RadioButton
    Friend WithEvents APILöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelcampeListerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkShopLastLogin As System.Windows.Forms.CheckBox
    Friend WithEvents btnQuickSync As System.Windows.Forms.Button
    Friend WithEvents chkMitWebgalerie As System.Windows.Forms.CheckBox
    Friend WithEvents cmsAnzahl As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator58 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBestellungAdd As System.Windows.Forms.Button
    Friend WithEvents kd_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator59 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShopsteKategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menue_shopste As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents lvwShopste As System.Windows.Forms.ListView
    Friend WithEvents shopste_bild As System.Windows.Forms.ColumnHeader
    Friend WithEvents shopste_titel As System.Windows.Forms.ColumnHeader
    Friend WithEvents shopste_preis As System.Windows.Forms.ColumnHeader
    Friend WithEvents shopste_menge As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents EiSoShopKategorienZuShopstecomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsShopsteArtikel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ArtikelÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EiSo2ShopsteArtikelImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CockitSetztenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents live_menge As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShopsteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtikelLöschenToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eBayHistoryBild As System.Windows.Forms.ColumnHeader
    Public WithEvents bilder_history As System.Windows.Forms.ImageList
    Friend WithEvents bild_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents eiso_bild_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsEiSoMenuID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ArtikelLöschenToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusverkauftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerkaufsbereitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MengeÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeitenID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShopID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Artikelnummer As System.Windows.Forms.ColumnHeader
    Friend WithEvents Aktiv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_shopsteCat As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsShopsteCat As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator60 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ArtikelShopsteKategorieZuweisenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYNCShopstecomKategorieArtikelEinstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator62 As ToolStripSeparator
    Friend WithEvents cmsShopsteKategorie As ContextMenuStrip
    Friend WithEvents NeueUnterkategorieShopAnlegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbltmp As Label
    Friend WithEvents SelektierteKategorieUmbennenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents eBayHistoryMenge As ColumnHeader
    Friend WithEvents mail_muttersprache As ColumnHeader
    Friend WithEvents ToolStripSeparator40 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator61 As ToolStripSeparator
    Friend WithEvents EBayArtikelEinstellenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents live_stadt As ColumnHeader
    Friend WithEvents live_eiso_orderlist_id As ColumnHeader
    Friend WithEvents tcBestellungen_visual As TabControl
    Friend WithEvents listenansicht As TabPage
    Friend WithEvents bestelliste As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lvwBestellungen_bestelliste_neu As ListView
    Friend WithEvents colBestell_kund_artikel_id As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_name As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_user As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_ort As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_beschreibung As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_preis As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_versand As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_bestellstatus As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_bewertung As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_email As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_verkaufsende As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_gebote As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_gebühr As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_plattform As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_bild As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_EID As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_paypal As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_land As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_colname As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_email_sprache As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_straße As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_sprachliste As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_bild2 As ColumnHeader
    Friend WithEvents colBestell_kund_artikel_menge As ColumnHeader
    Friend WithEvents lvwBestellungen_kunden As ListView
    Friend WithEvents col_kuden_bestellliste_name As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_mitgliedsname As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_email As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_strasse As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_ort As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_plz As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_land As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_käufe As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_artikelanzahl As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_newsletter As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_kd_änderung As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_plattform As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_sprachliste As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_muttersprache As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_id As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_order_id As ColumnHeader
    Friend WithEvents order_id As ColumnHeader
    Friend WithEvents eBayEiSoOrderID As ColumnHeader
    Friend WithEvents cmsBestellungen_bestellungen As ContextMenuStrip
    Friend WithEvents cmsBestellungen_kunden As ContextMenuStrip
    Friend WithEvents ZeigeAlleKundenbestellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EiSoExportierenDerAnsichtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator68 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem42 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem34 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem35 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem36 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem37 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem38 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem39 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator66 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem40 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator67 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem41 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator69 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem19 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator63 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem21 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator64 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem24 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator65 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem27 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem29 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem30 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem31 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem32 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem33 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem43 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem44 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem45 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem46 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem47 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem48 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator70 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem49 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator71 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem50 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator72 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator73 As ToolStripSeparator
    Friend WithEvents AnsichtAktuallisierenToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator74 As ToolStripSeparator
    Friend WithEvents colBestell_kund_artikel_orderid As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_bestellt_am As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_bestellstatus As ColumnHeader
    Friend WithEvents ToolStripMenuItem51 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem52 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator75 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem53 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem54 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem55 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator76 As ToolStripSeparator
    Friend WithEvents col_kuden_bestellliste_endsumme As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_versandkosten As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_rabatt As ColumnHeader
    Friend WithEvents col_kuden_bestellliste_versandart As ColumnHeader
    Friend WithEvents KundeEditierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestellungErneutAbschickenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkArtikeldatenbankBilderladen As CheckBox
    Friend WithEvents chkKundenverwaltung_kunde_ab_gestern As CheckBox
    Friend WithEvents ToolStripSeparator77 As ToolStripSeparator
    Friend WithEvents AusListeEntfernenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopiereAlsAdressblockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator78 As ToolStripSeparator
    Friend WithEvents btnAuftrag_Versandkosten As Button
    Friend WithEvents btnBestellverwaltung_rechnung_erstellen As Button
    Friend WithEvents col_kunden_bestellliste_verschickt As ColumnHeader
    Friend WithEvents col_kunden_bestellliste_bezahlt As ColumnHeader
    Friend WithEvents col_kunden_bestellliste_storniert As ColumnHeader
    Friend WithEvents col_kunden_bestellliste_bewertet As ColumnHeader
    Friend WithEvents col_kunden_bestellliste_abgeschlossen As ColumnHeader
    Friend WithEvents btnEiSoShop_artikel_neu As Button
    Friend WithEvents cmsShopste_id As ColumnHeader
    Friend WithEvents cmdShopste_lagerbestand As ColumnHeader
    Friend WithEvents cmsShopste_eingestellt_am As ColumnHeader
    Friend WithEvents chkEiSoArtikelverwaltung_kunden_details As CheckBox
End Class
