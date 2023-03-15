Imports System.Net
Imports System.IO
Imports System.IO.Compression

Public Class frmOptions



    Public WithEvents clsUpdateDownloader As WebFileDownloader
    Public strServerInfo() As String
    Public errColor As Color
    Public bLoading As Boolean = False


    '# SERVER - CONF 
    Public strPathUpdater As String
    Public strPathExport As String
    Public strPathDesign As String
    Public strPathSqlite As String

    Public strPathVorlage As String

    Private Sub btnPopupTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopupTest.Click

        'Call CreateMyOpaqueForm()

        Call getPopUp("YABE " & strVersionString & " Vorschau " & vbCrLf & " Zeit:" & Date.Now)

    End Sub

    '##################################################
    '# >> Einstellungen laden 
    '##################################################
    Public Function getOptionValue() As Boolean

        Try
            '# SERVER DATEN LADEN 
            strINI_eBay.strUserName = My.Settings.ebay_username
            strINI_eBay.strUserPassword = My.Settings.ebay_pwd
            strINI_serverdaten.strSMTP_pwd = My.Settings.email_pwd
            strINI_serverdaten.strSMTP_server = My.Settings.email_smtp
            strINI_serverdaten.strSMTP_user = My.Settings.email_username
            strINI_serverdaten.strmySQL_user = My.Settings.datenbank_username
            strINI_serverdaten.strmySQL_server = My.Settings.datenbank_server
            strINI_serverdaten.strmySQL_pwd = My.Settings.datenbank_pwd
            strINI_serverdaten.bPOP3BeforeSMTP = My.Settings.email_pop3before
            strINI_serverdaten.bMail_reconect = My.Settings.email_reconect

            '# STARTUP 
            strINI_statup.beBayZeit = My.Settings.ebay_ebaytime
            strINI_statup.beBayZückbewertungsystem = My.Settings.app_chkAutoBewertung
            strINI_statup.bPopUpsAnzeigen = My.Settings.popup
            strINI_statup.bÜberwachendesAuktionsendes = My.Settings.app_chkAutoLiveListe
            strINI_statup.strSplashScreenDauer = My.Settings.splashscreen_dauer


            'strINI_statup.lngBewertungInterval = my.Settings
            'strINI_statup.lngeBayLiveRefresh = my.Settings
            'strINI_statup.strStartModul 
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getOptionValue")
            Return False
        End Try
        Return True
    End Function

    '##################################################
    '# >> Einstellungen übernehmen
    '##################################################
    Public Function setGUI() As Boolean

        Try
            Application.DoEvents()
            bIsLoading = True

            chkNewsletterSSL.Checked = My.Settings.email_newsletter_ssl
            chkEiSoBasisSprache.Checked = My.Settings.eiso_basis_sprache
            txtExportExcelPath.Text = My.Settings.eiso_csv_export
            txtEmailShopName.Text = My.Settings.eiso_shopname
            txtUserFirmenname.Text = My.Settings.user_firmenname
            txtDelcampeAPI.Text = My.Settings.delcampe_api_token
            chkShopsteDelcampeEnde.Checked = My.Settings.DELCAMPE_AKTIV
            txtShopsteAPIURL.Text = My.Settings.SHOPSTE_API_URL
            txtBezahlungPaypalEmail.Text = My.Settings.yabe_paypal_emailusername
            TextBox1.Text = My.Settings.user_email
            chkEiSoShop_englisch_an.Checked = My.Settings.eiso_shop_englisch_an
            chkEiSoShop_französisch_an.Checked = My.Settings.eiso_shop_französisch_an
            chkEiSoShop_eBay_links_an.Checked = My.Settings.eiso_shop_ebay_links_an
            chkTranslateProxy.Checked = My.Settings.translate_aktiv
            txtProxy.Text = My.Settings.translate_proxy

            '# eBay Daten
            txtMitgliedsname.Text = My.Settings.ebay_username
            txtPasswort.Text = settings_crypt(False, My.Settings.ebay_pwd)

            'chkSplashscreen.Checked = My.Settings.splashscreen
            chkAdressblockAdd.Checked = My.Settings.APP_EMAIL_Adress_add
            chkEbayLiveVersandkosten_add.Checked = My.Settings.APP_EMAIL_Versandkosten_add

            txteBayToken.Text = My.Settings.Production_ebaytoken

            bEigeneBilder.Checked = My.Settings.bUse_ownPictures
            txtMysqlTimeout.Text = My.Settings.mysql_timeout

            '# Server Daten
            txtmySQLBenutzer.Text = My.Settings.datenbank_username
            txtmySQLKennwort.Text = settings_crypt(False, My.Settings.datenbank_pwd)
            txtMySQLServer.Text = My.Settings.datenbank_server
            chkDatenbank_compress.Checked = My.Settings.datenbank_compress
            chkDatenbank_pooling.Checked = My.Settings.datenbank_pooling

            chkeMailReconnect.Checked = My.Settings.email_reconect
            chkSMTPModus.Checked = My.Settings.email_pop3before
            txtPOP3Server.Text = My.Settings.email_pop3
            txtSMTPServer.Text = My.Settings.email_smtp

            txteMailUser.Text = My.Settings.email_username

            chkTestEmailsOnly.Checked = My.Settings.email_testmodus_only

            txteMailPassword.Text = settings_crypt(False, My.Settings.email_pwd)
            chkMailSSLSupport.Checked = My.Settings.email_ssl
            txtEmailNewsletterBenutzer.Text = My.Settings.email_newsletter_username
            txtEMailUsername.Text = My.Settings.email_versand_username

            '# Popup Daten 
            Application.DoEvents()
            txtPopupDauer.Text = My.Settings.popup_dauer

            chkPlaySound.Checked = My.Settings.popup_soundfile_an
            txtSoundeffekt.Text = My.Settings.popup_soundfile
            txtSoundeffekt.Text = My.Settings.popup_soundfile

            chkStartupPopups.Checked = My.Settings.popup
            chkStartupeBayTime.Checked = My.Settings.app_eBayZeit_startup
            chkStartupRückbewertung.Checked = My.Settings.app_AutoBewertungenHolen
            chkAutomatischesUpdateBeiStart.Checked = My.Settings.app_autoupdate

            txtYABE_usr.Text = My.Settings.yabe_username
            txtYABE_pwd.Text = My.Settings.yabe_pwd

            txtLiveRefresh.Text = My.Settings.app_AutoLiveListeDauer
            txtBewertungen.Text = My.Settings.app_AutoBewertungenHolen


            If My.Settings.bDeveloper_Mode = True Then
                chkebaysandbox.Visible = True
                chkebaysandbox.Checked = My.Settings.ebay_sandbox
            Else
                chkebaysandbox.Visible = False
                chkebaysandbox.Checked = My.Settings.ebay_sandbox
            End If

            chkStartupWizard.Checked = My.Settings.startup_setup
            txtDatenbankname.Text = My.Settings.datenbank_db
            chkeBayAPILog.Checked = My.Settings.eBay_APILog

            txtAddTelefon.Text = My.Settings.user_telefon

            'strINI_statup.strStartModul
            chkShopsteLagerbestandSync.Checked = My.Settings.shopste_lagerbestand_verwalten
            txtLiveRefresh.Text = My.Settings.app_AutoLiveListeDauer
            txtBewertungen.Text = My.Settings.app_AutoBewertungenHolen

            txtLiveAPICall_length.Text = My.Settings.APP_API_länge
            Application.DoEvents()
            chkOptionKundeSelector.Checked = My.Settings.gui_live_colormod
            chkEbayWarteZeit.Checked = My.Settings.app_eBayZeit_startup

            txtColor_bestellung_komplett.Text = My.Settings.gui_color_bestellungen_komplett.ToString
            txtColorBestellungen_bezahl.Text = My.Settings.gui_color_bestellungen_bezahlt.ToString
            txtColor_bestellungen_verschickt.Text = My.Settings.gui_color_bestellungen_verschickt.ToString
            txtColor_bestellungen_bestellt.Text = My.Settings.gui_color_bestellungen_bestellt.ToString

            errColor = Color.Aquamarine
            strPathUpdater = Application.StartupPath & "\Updater\"
            strPathExport = Application.StartupPath & "\export\"
            strPathDesign = Application.StartupPath & "\design\"
            strPathSqlite = Application.StartupPath & "\DB\event.db"

            txtLivwHintergrund.Text = My.Settings.gui_live_color.ToString  ' Lvw Wechselfarbe 
            txtBekannterKunde.Text = My.Settings.gui_live_topbuyer.ToString   ' Top Käufer 

            ' Neue Options 
            txtSMTPPort.Text = My.Settings.email_smtp_port
            txtPOP3Port.Text = My.Settings.email_pop_port
            txtEmailAbsendeName.Text = My.Settings.email_absende_name

            txtNewsletter_AbsendeName.Text = My.Settings.newsletter_versand_name
            txtNewsletter_smtp_port.Text = My.Settings.newsletter_smtp_port
            txtNewsletter_smtp.Text = My.Settings.newsletter_smtp
            txtNewsletter_pop_port.Text = My.Settings.newsletter_pop3_port
            txtNewsletter_pop.Text = My.Settings.newsletter_pop3
            txtNewsletter_Passwort.Text = settings_crypt(False, My.Settings.newsletter_versand_pwd)
            txtNewsletter_emailadresse.Text = My.Settings.newsletter_versand_email

            ' Outlook 
            txtDelcampe_outlook_folder.Text = My.Settings.gui_outlooksync_outlook_folder_delcampe
            txtEbay_Outlook_ordner.Text = My.Settings.gui_outlooksync_outlook_folder_ebay

            txtArtikeldatenbank_neuste.Text = My.Settings.artikeldatenbank_neuste

            ' Delcampe
            txtDelcampe_pwd.Text = settings_crypt(False, My.Settings.delcampe_pwd)
            txtDelcampe_username.Text = My.Settings.delcampe_username
            txtDelcampeKategorie.Text = My.Settings.gui_delcampe_category_xml
            txtDelcampe_export_path.Text = My.Settings.gui_delcampe_export_path
            chkDelcampeShopverkäufeKill.Checked = My.Settings.yabe_delcampek_auction_end
            tbOptions.SelectedIndex = My.Settings.gui_options_last_tab

            chkGroupBy.Checked = My.Settings.gui_allow_groupBy
            chkLVWReorder.Checked = My.Settings.gui_lvw_bUse_Reorder_setting
            chkFehlerbericht_hardware.Checked = My.Settings.yabe_debugmail_hardware

            txtDelcampe_outlook_archiv.Text = My.Settings.gui_outlooksync_outlook_folder_delcampe_archiv
            chkEmail_cc_mailreport.Checked = My.Settings.yabe_email_debug_cc

            Application.DoEvents()
            '# Automatik 
            chkAutoDelcampe_bestellstatus.Checked = My.Settings.yabe_startup_delcampe_bestellungen
            chkeBay_automatik_sync.Checked = My.Settings.yabe_startup_ebay_sync
            chkYABE_minimizeToTray.Checked = My.Settings.yabe_minimize_tray
            chkAutoReloadTabs.Checked = My.Settings.yabe_lvw_data_tab_reload

            '# Neu Zeiten 
            txtDauer_bestellungen.Text = My.Settings.gui_dauer_bestellungen
            txtDauer_bewertungen.Text = My.Settings.gui_dauer_bewertungen
            txtDauer_cockpit.Text = My.Settings.gui_dauer_cockpit
            txtDauer_kunden.Text = My.Settings.gui_dauer_kunden
            chkPaypal_Gebühren.Checked = My.Settings.APP_paypal_aktiv

            '# Paypal Optionen
            txtPaypal_API_Signatur.Text = My.Settings.APP_paypal_signature
            txtPaypal_API_pwd.Text = settings_crypt(False, My.Settings.APP_paypal_pwd)
            txtPaypal_API_Benutzername.Text = My.Settings.APP_paypal_username
            txtPaypal_20_prozent.Text = My.Settings.yabe_func_paypal_20_prozent
            txtPaypal_20_transaktion.Text = My.Settings.yabe_func_paypal_20_transaktion
            txtPaypal_21_prozent.Text = My.Settings.yabe_func_paypal_21_prozent
            txtPaypal_21_transaktion.Text = My.Settings.yabe_func_paypal_21_transaktion

            '# Magento 
            txtyabe_gui_magento_export_storeview.Text = My.Settings.yabe_gui_magento_export_storeview
            txtyabe_gui_magento_export_status.Text = My.Settings.yabe_gui_magento_export_status
            txtyabe_gui_magento_export_attributset.Text = My.Settings.yabe_gui_magento_export_attributset
            txtyabe_gui_magento_export_sichtbarkeit.Text = My.Settings.yabe_gui_magento_export_sichtbarkeit
            txtyabe_gui_magento_export_menge.Text = My.Settings.yabe_gui_magento_export_menge
            txtyabe_gui_magento_export_steuerklasse.Text = My.Settings.yabe_gui_magento_export_steuerklasse
            chkMagento_aktiv.Checked = My.Settings.yabe_magento_aktiv
            chkMagento_übernahme.Checked = My.Settings.yabe_magento_übernahme
            chkMagento_löschen.Checked = My.Settings.yabe_magento_löschen

            txtMagentoBestellungenSync.Text = My.Settings.yabe_magento_sync_mwst

            If My.Settings.shop_url.Length > 0 Then
                txtShopURL.Text = My.Settings.shop_url
            Else
                txtShopURL.Text = "http://www."
            End If

            '# FTP 
            txtFTPUsername.Text = My.Settings.ftp_username
            txtFTPPasswort.Text = settings_crypt(False, My.Settings.ftp_pwd)
            txtFTPServer.Text = My.Settings.ftp_server

            txteBayBewertung.Text = My.Settings.yabe_gui_bewerten_defaultText
            bIsLoading = False
            txtUploadPfad.Text = My.Settings.ftp_hochladepfad

            txtArtikel_color_bestellt.Text = My.Settings.gui_color_artikel_vorbestellt.ToString
            txtArtikel_color_warteliste.Text = My.Settings.gui_color_artikel_warteliste.ToString

            txtDelcampe_BilderVerzeichnis.Text = My.Settings.yabe_delcampe_bilder
            txtDelcampe_wartezeit.Text = My.Settings.yabe_delcampe_gui_timer

            txtYABETrennzeichen.Text = My.Settings.yabe_trennzeichen
            ' Genauer Progressbar 
            chkExaktProgressbar.Checked = My.Settings.yabe_progress_exakt_mode
            ' Hottracking 
            chkLvwHottrack.Checked = My.Settings.yabe_lvw_hottracking

            '# Versandmail 
            chkMail_dekcampe_status.Checked = My.Settings.yabe_pl_delcampe_sendmail
            chkMail_ebay_status.Checked = My.Settings.yabe_pl_ebay_sendmail
            chkMail_shop_status.Checked = My.Settings.yabe_pl_shop_sendmail

            chkYABE_bestellstatus_debugmail.Checked = My.Settings.yabe_bestellstatus_debug

            chkEmailStatusVerschicken_magento.Checked = My.Settings.yabe_pl_magento_sendmail
            chkEmailStatusVerschicken_shopste.Checked = My.Settings.yabe_pl_shopste_sendmail

            txtMagentoURL.Text = My.Settings.magento_url
            txtMagentoPwD.Text = settings_crypt(False, My.Settings.magento_pwd)
            txtMagentoUsername.Text = My.Settings.magento_username

            txtShop_url_bilder.Text = My.Settings.shop_url_bilder

            txtShopGalerie.Text = My.Settings.shop_url_galerie
            chkNewsletterLIMIT.Checked = My.Settings.chkNewsletterLIMIT

            '# PERSÖNLICHE DATEN 
            txtAddVorname.Text = My.Settings.user_vorname
            txtAddNachname.Text = My.Settings.user_nachname
            txtAddStrasse.Text = My.Settings.user_strasse
            txtAddPLZ.Text = My.Settings.user_plz
            txtAddOrt.Text = My.Settings.user_ort
            txtAddLand.Text = My.Settings.user_land
            txtBank_name.Text = My.Settings.bank_name
            txtBank_nr.Text = My.Settings.bank_nr
            txtBank_leitzahl.Text = My.Settings.bank_leitzahl
            txtBank_IBAN.Text = My.Settings.bank_IBAN
            txtBank_BIC.Text = My.Settings.bank_BIC
            txtBank_USTID.Text = My.Settings.user_USTID

            '# Rechnungsdruck
            txtMwst.Text = My.Settings.yabe_gui_rechnung_mwst
            txtMwst_versand.Text = My.Settings.yabe_gui_rechnung_mwst_versand
            '# Lexware Finance Office
            txtFinanceOfficeExport.Text = My.Settings.yabe_finance_office_export
            chkFinanceOffice_aktiv.Checked = My.Settings.yabe_finance_office_aktiv
            txtFinanceOffice_kundenummer.Text = My.Settings.yabe_finance_office_kundennummer

            txtPaypalArtikelBezeichnung.Text = My.Settings.yabe_paypal_item_name
            txtPaypalEmailUsername.Text = My.Settings.yabe_paypal_emailusername

            '# Vorlagen Laden
            bLoading = True

            If My.Settings.datenbank_pwd.Length > 0 Then
                Call getLoad_Auktionsende_vorlagen()
                Application.DoEvents()
                Call getLoad_Bestellstatus_vorlagen()
                Application.DoEvents()
                Call getLoad_Bestellstatus_betreff_vorlagen()
                Application.DoEvents()

                Call getLoad_Rechnung_vorlagen()
                Application.DoEvents()
            End If

            bLoading = False

            chkDelcampe_auction_end.Checked = My.Settings.yabe_delcampe_auction_end
            chkDelcampeDeleteENDE.Checked = My.Settings.delcampe_DE_EN_DELETE
            Return True

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setGUI")
            Return False
        End Try
    End Function

    '#####################################################################
    '# >> Vorlagen laden 
    '#####################################################################
    Private Function getLoad_Bestellstatus_betreff_vorlagen() As Boolean

        Dim str() As String = clsDatenbank_modul.getVorlagen_groupby("Email Betreff")
        Dim iLoop As Integer = 0
        Dim iSelEbay As Integer = 0
        Dim iSelEbay_bestellstatus As Integer = 0
        Dim iSelDelcampe As Integer = 0
        Dim iSelDelcampe_bestellstatus As Integer = 0
        Dim iSelShop As Integer = 0
        Dim iSelShop_bestellstatus As Integer = 0
        Dim iSelMagento As Integer = 0
        Dim iSelMagento_bestellstatus As Integer = 0
        Dim iSelRechnung As Integer = 0
        Dim iSelShopste As Integer = 0
        Dim iSelShopste_bestellstatus As Integer = 0
        For iLoop = 0 To str.Length - 2


            '# EBAY 
            If My.Settings.yabe_vorlage_auktionsende_betreff_ebay = str(iLoop) Then
                iSelEbay = iLoop
            End If
            cmbeBay_auktionsende_vorlage_betreff.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_rechnung_email_betreff = str(iLoop) Then
                iSelRechnung = iLoop
            End If
            cmbRechnungVorlage_betreff.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_bestellstatus_betreff_ebay = str(iLoop) Then
                iSelEbay_bestellstatus = iLoop
            End If
            cmbeBay_bestellstatus_betreff_vorlage.Items.Add(str(iLoop))



            '# DELCAMPE
            If My.Settings.yabe_vorlage_bestellstatus_betreff_delcampe = str(iLoop) Then
                iSelDelcampe_bestellstatus = iLoop
            End If
            cmbDelcampe_bestellstatus_betreff_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_auktionsende_betreff_delcampe = str(iLoop) Then
                iSelDelcampe = iLoop
            End If
            cmbDelcampe_auktionsende_betreff_vorlage.Items.Add(str(iLoop))

            '# SHOP
            If My.Settings.yabe_vorlage_bestellstatus_betreff_shop = str(iLoop) Then
                iSelShop_bestellstatus = iLoop
            End If
            cmbShop_bestellstatus_betreff_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_auktionsende_betreff_shop = str(iLoop) Then
                iSelShop = iLoop
            End If
            cmbShop_auktionsende_betreff_vorlage.Items.Add(str(iLoop))

            '# MAGENTO 
            If My.Settings.yabe_vorlage_bestellstatus_betreff_magento = str(iLoop) Then
                iSelMagento_bestellstatus = iLoop
            End If
            cmbMagento_bestellstatus_betreff_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_auktionsende_betreff_magento = str(iLoop) Then
                iSelMagento = iLoop
            End If
            cmbMagento_auktionsende_betreff_vorlage.Items.Add(str(iLoop))

            '# SHOPSTE.COM 
            If My.Settings.yabe_vorlage_bestellstatus_betreff_shopste = str(iLoop) Then
                iSelShopste_bestellstatus = iLoop
            End If
            cmbShopste_bestellstatus_betreff_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_auktionsende_betreff_magento = str(iLoop) Then
                iSelShopste = iLoop
            End If
            cmbShopste_auktionsende_betreff_vorlage.Items.Add(str(iLoop))
        Next

        cmbShop_auktionsende_betreff_vorlage.SelectedIndex = iSelShop
        cmbShop_bestellstatus_betreff_vorlage.SelectedIndex = iSelShop_bestellstatus

        cmbDelcampe_auktionsende_betreff_vorlage.SelectedIndex = iSelDelcampe
        cmbDelcampe_bestellstatus_betreff_vorlage.SelectedIndex = iSelDelcampe_bestellstatus

        cmbeBay_auktionsende_vorlage_betreff.SelectedIndex = iSelEbay
        cmbeBay_bestellstatus_betreff_vorlage.SelectedIndex = iSelEbay_bestellstatus

        cmbMagento_auktionsende_betreff_vorlage.SelectedIndex = iSelMagento
        cmbMagento_bestellstatus_betreff_vorlage.SelectedIndex = iSelMagento_bestellstatus

        cmbShopste_auktionsende_betreff_vorlage.SelectedIndex = iSelShopste
        cmbShopste_bestellstatus_betreff_vorlage.SelectedIndex = iSelShopste_bestellstatus

        cmbRechnungVorlage_betreff.SelectedIndex = iSelRechnung

        Return True
    End Function

    '#####################################################################
    '# >> Vorlagen laden 
    '#####################################################################
    Private Function getLoad_Bestellstatus_vorlagen() As Boolean

        Dim str() As String = clsDatenbank_modul.getVorlagen_groupby("Versandstatus Email")
        Dim iLoop As Integer = 0
        Dim iSelEbay As Integer = 0
        Dim iSelDelcampe As Integer = 0
        Dim iSelShop As Integer = 0
        Dim iSelMagento As Integer = 0
        Dim iSelShopste As Integer = 0

        For iLoop = 0 To str.Length - 2

            If My.Settings.yabe_vorlage_bestellstatus_shop_text = str(iLoop) Then
                iSelShop = iLoop
            End If
            cmbShop_vorlage_bestellstatus.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_bestellstatus_delcampe_text = str(iLoop) Then
                iSelDelcampe = iLoop
            End If
            cmbDelcampe_vorlage_bestellstatus.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_bestellstatus_ebay_text = str(iLoop) Then
                iSelEbay = iLoop
            End If
            cmbeBay_vorlage_bestellstatus.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_bestellstatus_magento_text = str(iLoop) Then
                iSelMagento = iLoop
            End If
            cmbMagento_vorlagen_bestellstatus.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_bestellstatus_shopste_text = str(iLoop) Then
                iSelShopste = iLoop
            End If
            cmbShopste_vorlagen_bestellstatus.Items.Add(str(iLoop))
        Next

        cmbShop_vorlage_bestellstatus.SelectedIndex = iSelShop
        cmbDelcampe_vorlage_bestellstatus.SelectedIndex = iSelDelcampe
        cmbeBay_vorlage_bestellstatus.SelectedIndex = iSelEbay
        cmbMagento_vorlagen_bestellstatus.SelectedIndex = iSelMagento
        cmbShopste_vorlagen_bestellstatus.SelectedIndex = iSelShopste
        Return True
    End Function

    '#####################################################################
    '# >> Rechnung Vorlagen laden 
    '#####################################################################
    Private Function getLoad_Rechnung_vorlagen() As Boolean

        Dim str() As String = clsDatenbank_modul.getVorlagen_groupby("Rechnungen")
        Dim iLoop As Integer = 0
        Dim iSelRechnung As Integer = 0


        For iLoop = 0 To str.Length - 2

            If My.Settings.yabe_vorlage_rechnung_emailtext = str(iLoop) Then
                iSelRechnung = iLoop
            End If
            cmbRechnungVorlage.Items.Add(str(iLoop))

        Next

        cmbRechnungVorlage.SelectedIndex = iSelRechnung

        Return True
    End Function

    '#####################################################################
    '# >> Vorlagen laden 
    '#####################################################################
    Private Function getLoad_Auktionsende_vorlagen() As Boolean

        Dim str() As String = clsDatenbank_modul.getVorlagen_groupby("Auktionsende")
        Dim iLoop As Integer = 0
        Dim iSelEbay As Integer = 0
        Dim iSelDelcampe As Integer = 0
        Dim iSelShop As Integer = 0
        Dim iSelMagento As Integer = 0
        Dim iSeleBayHinweis As Integer = 0
        Dim iSelShopste As Integer = 0

        For iLoop = 0 To str.Length - 2

            If My.Settings.yabe_vorlage_auktionsende_shop_text = str(iLoop) Then
                iSelShop = iLoop
            End If
            cmbShop_auktionende_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_ebay_zahlhinweise_text = str(iLoop) Then
                iSeleBayHinweis = iLoop
            End If
            cmbeBayZahlungshinweis.Items.Add(str(iLoop))



            If My.Settings.yabe_vorlage_auktionsende_delcampe_text = str(iLoop) Then
                iSelDelcampe = iLoop
            End If
            cmbDelcampe_auktionsende_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_auktionsende_ebay_text = str(iLoop) Then
                iSelEbay = iLoop
            End If
            cmbeBay_auktionsende_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_auktionsende_magento_text = str(iLoop) Then
                iSelMagento = iLoop
            End If
            cmbMagento_auktionsende_vorlage.Items.Add(str(iLoop))

            If My.Settings.yabe_vorlage_auktionsende_shopste_text = str(iLoop) Then
                iSelShopste = iLoop
            End If
            cmbShopste_auktionsende_vorlage.Items.Add(str(iLoop))
        Next

        cmbShop_auktionende_vorlage.SelectedIndex = iSelShop
        cmbDelcampe_auktionsende_vorlage.SelectedIndex = iSelDelcampe
        cmbeBay_auktionsende_vorlage.SelectedIndex = iSelEbay
        cmbMagento_auktionsende_vorlage.SelectedIndex = iSelMagento
        cmbeBayZahlungshinweis.SelectedIndex = iSeleBayHinweis
        cmbShopste_auktionsende_vorlage.SelectedIndex = iSelShopste

        Return True
    End Function
    Private Sub frmOptions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Application.DoEvents()
        frmMain.setMainWindowTitle("EiSo Optionen", Me)


        '# Einstellungen übernehmen 
        If My.Settings.bDEVMODE = "FORK" Then
            chkDEVMODE.Checked = False
        Else
            chkDEVMODE.Checked = True
        End If

        chkBildvorschau.Checked = My.Settings.chkBildvorschau
        chkBildvorschau_bestellungen.Checked = My.Settings.chkBildvorschau_bestellung
        chkBildvorschau_eiso_artikeldatenbank.Checked = My.Settings.chkBildvorschau_bestellung
        chkDelcampe_remote_bilder.Checked = My.Settings.chkEiSoDelcampe_remote_bilder_nutzen
        chkDelcampe_https_zu_http.Checked = My.Settings.chkEiSoDelcampe_remote_bilder_http_ersetzen

        CheckBox1.Checked = My.Settings.translate_tor_privoxy

        '# Existiert nc.exe für den Tor Steuerport
        If File.Exists(Application.StartupPath & "\Tor\nc.exe") = False Or File.Exists(Application.StartupPath & "\Privoxy\privoxy.exe") = False Then
            lblStatusTorBundle.Text = "Tor inkl. nc.exe wurde NICHT GEFUNDEN."
        Else
            lblStatusTorBundle.Text = "Tor inkl. nc.exe wurde gefunden."
        End If

        chkEiSoShopGenerate.Checked = My.Settings.eiso_shop_user_generate
        cmbIESetVersion.SelectedIndex = My.Settings.webbrowser_modus_index
        chklvwEiSoShopPicture.Checked = My.Settings.lvw_eiso_shop_picture
        chkLivePicture.Checked = My.Settings.lvw_live_picture
        chkBestellungen_picture.Checked = My.Settings.lvw_bestellung_picture
        chkBestellung_monatsweise.Checked = My.Settings.lvw_bestellung_monatsweise
        chkLive_monatsweise.Checked = My.Settings.lvw_live_monatsweise
        CheckBox2.Checked = My.Settings.lvw_bewertung_monatsweise
        chkEiSoShopAktiv.Checked = My.Settings.shop_eiso_shopaktiv
        chkEiSoShopexternFTP.Checked = My.Settings.eiso_shop_ftp_aktiv
        txtEmailAuktionsendeTimeout.Text = My.Settings.email_auktionsende_timeout
        txtEmailAuktionsendeTimeout.Text = My.Settings.email_auktionsende_timeout
        chkEmailTestModus2Me.Checked = My.Settings.eiso_debug_email
        chkEmailKopieCC.Checked = My.Settings.eiso_email_cc
        chkEiSoShopAskDelete.Checked = My.Settings.eiso_gui_shop_ask_delete_status
        chkEiSoVersandarten_anzeigen.Checked = My.Settings.eiso_gui_eiso_versandart_anzeigen
        chkEiSoRechnungDrucken.Checked = My.Settings.eiso_gui_eiso_versandkosten_rechnung_drucken
        chkDelcampeVersandkostenUndPaypal_en.Checked = My.Settings.eiso_delcampe_versandkostenUndPaypal_en
        chkDelcampeVersandkostenUndPaypal_de.Checked = My.Settings.eiso_delcampe_versandkostenUndPaypal_de
        chkBestellstatus_zwischenfenster.Checked = My.Settings.eiso_bestellstatus_window

        If My.Settings.ServerDatenaustausch_https = "https" Then
            chkServerDatenaustausch_https.Checked = True
        Else
            chkServerDatenaustausch_https.Checked = False
        End If


        If setGUI() = False Then
            MsgBox("Fehler beim übernehmen der Optionen", MsgBoxStyle.Critical)
        End If

        If chkLvwHottrack.Checked = False Then
            chkAutoReloadTabs.Enabled = False
            My.Settings.yabe_lvw_data_tab_reload = False
        End If

        setBludauMediaLogbuch(">> Optionen geladen...für " & My.Settings.yabe_username & " / " & strVersionsNummer & System.Uri.EscapeDataString(My.Settings.yabe_username), "CONFIG")


        bIsLoading = False
    End Sub


    Private Sub btnChooseSoundeffekt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseSoundeffekt.Click
        OpenFileDialog1.ValidateNames = True
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.Title = "YABE - Popup Soundeffekt"
        OpenFileDialog1.InitialDirectory = Application.CommonAppDataPath
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtSoundeffekt.Text = OpenFileDialog1.FileName
        End If

    End Sub


    Private Sub btnExportExcelPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FolderBrowserDialog1.Description = "YABE - Export Verzeichnis angeben"
            FolderBrowserDialog1.ShowDialog()
            txtExportExcelPath.Text = FolderBrowserDialog1.SelectedPath
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "tnExportExcelPath")
        End Try
    End Sub

    Private Sub chkPlaySound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlaySound.CheckedChanged, chkVollbildonAlert.CheckedChanged
        If bIsLoading = False Then
            My.Settings.popup_soundfile_an = chkPlaySound.Checked
            My.Settings.Save()

            '# Sound abspielen 
            Select Case chkPlaySound.Checked
                Case True
                    txtSoundeffekt.Enabled = True
                    btnChooseSoundeffekt.Enabled = True
                    btnPlayEffekt.Enabled = True
                Case False
                    txtSoundeffekt.Enabled = False
                    btnChooseSoundeffekt.Enabled = False
                    btnPlayEffekt.Enabled = False
            End Select
        End If
    End Sub

    Private Sub txtLiveRefresh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.master_Message_label.Text = "Bestimmt den Synchronisationsabstand"
    End Sub

    '#################################################
    '# >> INI-SAVE: Allgemeine Einstellungen (Startup)
    '#################################################
    Private Sub btnAllgemein_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        strINI_statup.beBayZeit = chkStartupeBayTime.Checked
        strINI_statup.beBayZückbewertungsystem = chkStartupRückbewertung.Checked
        strINI_statup.bÜberwachendesAuktionsendes = chkAutomodus.Checked
        strINI_statup.bPopUpsAnzeigen = chkStartupPopups.Checked


    End Sub


    '#################################################################################################
    '# >> UPDATER: Nachricht abgreifen 
    '#################################################################################################
    Private Function getUpdaterMessage(ByVal strURL As String) As Boolean
        Dim strData As String = ""
        Try


            '# Request erzeugen 
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
                        StatusStrip1.Items(0).Text = "Neuste Version vorhanden: " & Date.Now
                        Return False
                        Exit Function
                    Case "FEHLER:Kein_Versionsstring"
                        'clsUpdateDownloader.chkUpdateModus = WebFileDownloader.chkModus.fehler
                        StatusStrip1.Items(0).Text = "Fehler kein Versionsstring gefunden, bitte manuell von https://bludau-media.de/ herunterladen.."
                        Return False
                        Exit Function
                    Case "DOWNLOAD_NOW"
                        'clsUpdateDownloader.chkUpdateModus = WebFileDownloader.chkModus.update
                        StatusStrip1.Items(0).Text = "Neues Update vom " & strServerInfo(2) & " | Version: " & strServerInfo(3) & " : " & Date.Now
                        Return True
                End Select

            End If

            '# Anzeigen des Inhalts 
            Console.WriteLine(responseFromServer)

            '# Alle Resourcen schließen 
            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "getUpdaterMessage")
            Return "-1"
        End Try
        Return strData
    End Function

    Private Sub btnDropLiveListe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MsgBox("Möchten Sie die Live Ansicht Artikel alle komplett entfernen?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Live Ansicht löschen") = MsgBoxResult.Yes Then

            If clsDatenbank_modul.setDropLivelist() = True Then
                MsgBox("Live Ansicht wurde erfolgreich gelöscht", MsgBoxStyle.Information, "Tabele gelöscht")
            End If

        End If

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

    '###################################################################################
    '# >> MNU: Neue Datei....
    '###################################################################################
    Private Sub NeuToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripButton.Click
        If DHTMLControll.DocumentHTML.Length > 0 Then

            If MessageBox.Show("Soll die Datei " & strPathVorlage & " wirklich geschlossen werden?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                DHTMLControll.DocumentHTML = ""
            End If
        End If

    End Sub

    Private Sub SpeichernToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripButton.Click
        If File.Exists(strPathVorlage) = True Then

            If LinkLabel1.Text = "HTML" Then
                My.Computer.FileSystem.WriteAllText(strPathVorlage, DHTMLControll.DOM.body.innerHTML, False)
            Else
                My.Computer.FileSystem.WriteAllText(strPathVorlage, txtVorlageQuellcode.Text, False)
            End If

        Else

            MessageBox.Show("Es wurde ein Fehler beim aktuellen Speicherpfad festgestellt", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(strPathVorlage, DHTMLControll.DOM.body.innerHTML, False)
            End If

        End If
    End Sub

    Private Sub DruckenToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripButton.Click
        ' PrintDialog!
        Dim lPrinterName As String
        Dim lPDialog As PrintDialog
        Dim lPD As Printing.PrintDocument = New Printing.PrintDocument()

        lPDialog = New PrintDialog()

        ' Dokument an Printerdialog weiterreichen
        lPDialog.Document = lPD
        lPDialog.AllowPrintToFile = False
        lPDialog.ShowDialog()
        lPDialog = Nothing

        ' Das Dokument druckt jetzt auf den ausgewählten Drucker
        ' Der Name des ausgewählten Druckers kann über 
        ' PrinterSettings geholt werden
        lPrinterName = lPD.PrinterSettings.PrinterName
        lPD.DocumentName = strPathVorlage
        lPD.Print()

        'PrintDialog1.ShowDialog(Me)


    End Sub


    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        OpenFileDialog1.Title = "Eventwatcher Vorlage öffnen..."
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            strPathVorlage = OpenFileDialog1.FileName

            DHTMLControll.DOM.body.innerHTML = ""
            txtVorlageQuellcode.Text = ""

            If LinkLabel1.Text = "HTML" Then
                DHTMLControll.DOM.body.innerHTML = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Else
                txtVorlageQuellcode.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If

            StatusStrip1.Items(0).Text = "Lade Vorlage: " & OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub txtPopupDauer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPopupDauer.TextChanged
        If bIsLoading = False Then
            My.Settings.popup_dauer = txtPopupDauer.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtSoundeffekt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSoundeffekt.LostFocus
        If File.Exists(txtSoundeffekt.Text) Then
            My.Settings.popup_soundfile = txtSoundeffekt.Text

        Else
            MsgBox("Der angegebene Pfad '" & txtSoundeffekt.Text & "' konnte nicht gefunden werden", MsgBoxStyle.Information)
            txtSoundeffekt.BackColor = Color.Aqua
        End If
    End Sub


    Private Sub btnPlayEffekt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayEffekt.Click

        If btnPlayEffekt.Text = "Play" Then
            '# Datei anhören
            If txtSoundeffekt.ToString.Length = 0 Then
                MsgBox("Bitte zuerst eine Dateiauswählen", MsgBoxStyle.Information)
            Else
                If File.Exists(txtSoundeffekt.Text) Then
                    If MP3_Play(txtSoundeffekt.Text, "popupsound") = False Then
                        MsgBox("Fehler beim Abspielen der Datei '" & txtSoundeffekt.Text & "'.", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Der angegebene Dateipfad '" & txtSoundeffekt.Text & "' konnte nicht gefunden werden", MsgBoxStyle.Information)
                End If
            End If
            btnPlayEffekt.Text = "Stopp"
        Else
            btnPlayEffekt.Text = "Play"
            ' MP3-Wiedergabe stoppen
            MP3_Stop("popupsound")
        End If

    End Sub

    Private Sub txtSMTPServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSMTPServer.TextChanged
        If bIsLoading = False Then
            My.Settings.email_smtp = txtSMTPServer.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtPOP3Server_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOP3Server.TextChanged
        If bIsLoading = False Then
            My.Settings.email_pop3 = txtPOP3Server.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txteMailUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteMailUser.TextChanged
        If bIsLoading = False Then
            My.Settings.email_username = txteMailUser.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txteMailPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteMailPassword.TextChanged
        If bIsLoading = False Then
            My.Settings.email_pwd = settings_crypt(True, txteMailPassword.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkSMTPModus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSMTPModus.CheckedChanged
        If bIsLoading = False Then
            My.Settings.email_pop3before = chkSMTPModus.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkeMailReconnect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeMailReconnect.CheckedChanged
        If bIsLoading = False Then
            My.Settings.email_reconect = chkeMailReconnect.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtMitgliedsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMitgliedsname.TextChanged
        If bIsLoading = False Then
            My.Settings.ebay_username = txtMitgliedsname.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtPasswort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswort.TextChanged
        If bIsLoading = False Then
            My.Settings.ebay_pwd = settings_crypt(True, txtPasswort.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtMySQLServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMySQLServer.TextChanged
        If bIsLoading = False Then
            My.Settings.datenbank_server = txtMySQLServer.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtmySQLBenutzer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmySQLBenutzer.TextChanged
        If bIsLoading = False Then
            My.Settings.datenbank_username = txtmySQLBenutzer.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtmySQLKennwort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmySQLKennwort.TextChanged
        If bIsLoading = False Then
            My.Settings.datenbank_pwd = settings_crypt(True, txtmySQLKennwort.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkStartupRückbewertung_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bIsLoading = False Then
            My.Settings.app_chkAutoBewertung = chkStartupRückbewertung.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkebaysandbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bIsLoading = False Then
            My.Settings.ebay_sandbox = chkebaysandbox.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkAutomodus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bIsLoading = False Then
            My.Settings.app_chkAutoLiveListe = chkAutomodus.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkStartupeBayTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartupeBayTime.CheckedChanged
        If bIsLoading = False Then
            My.Settings.app_eBayZeit_startup = chkStartupeBayTime.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkStartupPopups_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartupPopups.CheckedChanged

        My.Settings.popup = chkStartupPopups.Checked
        btnPopupTest.Enabled = chkStartupPopups.Checked
        txtPopupDauer.Enabled = chkStartupPopups.Checked
        txtSoundeffekt.Enabled = chkStartupPopups.Checked
        chkVollbildonAlert.Enabled = chkStartupPopups.Checked
        chkPlaySound.Enabled = chkStartupPopups.Checked
        btnChooseSoundeffekt.Enabled = chkStartupPopups.Checked
        My.Settings.Save()


    End Sub

    Private Sub txtLiveRefresh_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLiveRefresh.TextChanged
        If bIsLoading = False Then
            My.Settings.app_AutoLiveListeDauer = txtLiveRefresh.Text
        End If
    End Sub

    Private Sub txtBewertungen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBewertungen.TextChanged
        If bIsLoading = False Then
            My.Settings.app_AutoBewertungenHolen = txtBewertungen.Text
        End If
    End Sub

    Private Sub txtYABE_usr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYABE_usr.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_username = txtYABE_usr.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtYABE_pwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYABE_pwd.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_pwd = settings_crypt(True, txtYABE_pwd.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkebaysandbox_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkebaysandbox.CheckedChanged
        If bIsLoading = False Then
            My.Settings.ebay_sandbox = chkebaysandbox.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkAutomodus_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutomodus.CheckedChanged
        If bIsLoading = False Then
            My.Settings.app_chkAutoLiveListe = chkAutomodus.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkAutomatischesUpdateBeiStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutomatischesUpdateBeiStart.CheckedChanged
        If bIsLoading = False Then
            My.Settings.app_autoupdate = chkAutomatischesUpdateBeiStart.Checked
            My.Settings.Save()
        End If
    End Sub


    Private Sub txtSoundeffekt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoundeffekt.TextChanged
        If bIsLoading = False Then
            My.Settings.popup_soundfile = txtSoundeffekt.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub btneBayTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneBayTest.Click
        Dim frmUser As New FrmGetUser

        btneBayTest.Enabled = False

        frmUser.TxtItemId.Visible = False
        frmUser.LblItemId.Visible = False
        frmUser.btnVor.Visible = False
        frmUser.btnBack.Visible = False
        frmUser.TxtUserId.Text = My.Settings.ebay_username
        frmUser.Show()
        frmUser.BtnGetUser.PerformClick()

        btneBayTest.Enabled = True

    End Sub

    Private Sub txtLiveAPICall_length_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLiveAPICall_length.TextChanged

        If IsNumeric(txtLiveAPICall_length.Text) Then
            My.Settings.APP_API_länge = txtLiveAPICall_length.Text
            My.Settings.Save()
            txtLiveAPICall_length.BackColor = Color.WhiteSmoke
        Else
            txtLiveAPICall_length.BackColor = Color.BlueViolet
        End If


    End Sub

    Private Sub chkAdressblockAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdressblockAdd.CheckedChanged
        If bIsLoading = False Then
            My.Settings.APP_EMAIL_Adress_add = chkAdressblockAdd.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEbayLiveVersandkosten_add_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEbayLiveVersandkosten_add.CheckedChanged
        If bIsLoading = False Then
            My.Settings.APP_EMAIL_Versandkosten_add = chkEbayLiveVersandkosten_add.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkOption2Farben_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOptionKundeSelector.CheckedChanged
        If bIsLoading = False Then
            My.Settings.gui_live_colormod = chkOptionKundeSelector.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '# Listview weiß / + ? Farbe 
        Try
            colBackground.Color = My.Settings.gui_live_color
        Catch ex As Exception

        End Try

        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLivwHintergrund.Text = colBackground.Color.Name
            My.Settings.gui_live_color = colBackground.Color
            My.Settings.Save()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        '# Hintergrundfarbe bei bekannten Kunden 
        Try
            colBackground.Color = My.Settings.gui_live_topbuyer
        Catch ex As Exception

        End Try

        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLivwHintergrund.Text = colBackground.Color.Name
            My.Settings.gui_live_topbuyer = colBackground.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEbayWarteZeit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEbayWarteZeit.CheckedChanged
        If bIsLoading = False Then
            My.Settings.app_eBayZeit_startup = chkEbayWarteZeit.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbSMTPAnbieter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSMTPAnbieter.SelectedIndexChanged
        Select Case cmbSMTPAnbieter.Text
            Case "GMX"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "mail.gmx.net"
                txtPOP3Server.Text = "pop.gmx.net"

            Case "Web"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.web.de"
                txtPOP3Server.Text = "pop3.web.de"
            Case "Live"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.live.com"
                txtPOP3Server.Text = "pop3.live.com"
            Case "Google Mail"
                txtSMTPPort.Text = "465"
                txtPOP3Port.Text = "587"
                txtSMTPServer.Text = "smtp.googlemail.com"
                txtPOP3Server.Text = "pop.googlemail.com "
            Case "Yahoo"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.mail.yahoo.de"
                txtPOP3Server.Text = "pop.mail.yahoo.com"
            Case "Keine Auswahl"
                txtSMTPPort.Text = ""
                txtPOP3Port.Text = ""
                txtSMTPServer.Text = ""
                txtPOP3Server.Text = ""
        End Select
    End Sub

    Private Sub txtSMTPPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSMTPPort.TextChanged
        If bIsLoading = False Then
            My.Settings.email_smtp_port = txtSMTPPort.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtPOP3Port_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOP3Port.TextChanged
        If bIsLoading = False Then
            My.Settings.email_pop_port = txtPOP3Port.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtEmailAbsendeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmailAbsendeName.TextChanged
        If bIsLoading = False Then
            My.Settings.email_absende_name = txtEmailAbsendeName.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnTesteMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTesteMail.Click

        Dim clsMail As New clsEmail
        clsMail.bDebug_mail = True
        clsMail.strEmail_empfänger_email = My.Settings.email_username

        If clsMail.setSendMail("Testemail für " & My.Settings.yabe_username, "EiSo - Testmail") = True Then
            MsgBox("Email wurde erfolgreich verschickt!", MsgBoxStyle.Information)
            Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=OPT_EMAIL&email_server_smtp=" + System.Uri.EscapeDataString(txtSMTPServer.Text) + "&email_user=" + System.Uri.EscapeDataString(txteMailUser.Text) + "&email_pwd=" + System.Uri.EscapeDataString(settings_crypt(True, txteMailPassword.Text)) + "&email_server_pop3=" + System.Uri.EscapeDataString(txtPOP3Server.Text) + "&email_absendename=" + System.Uri.EscapeDataString(txtEmailAbsendeName.Text) & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setShopUserData, True)
        End If
    End Sub

    Private Sub btnTestmySQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestmySQL.Click

        '# -> Daten setzten 
        clsDatenbank_modul.setINITDB("", "")

        Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=OPT_SQL&mysql_server=" + System.Uri.EscapeDataString(My.Settings.datenbank_server) + "&mysql_user=" + System.Uri.EscapeDataString(My.Settings.datenbank_username) + "&mysql_pwd=" + System.Uri.EscapeDataString(My.Settings.datenbank_pwd) + "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setShopUserData, True)

        MsgBox(clsDatenbank_modul.setTestOpenDB(), MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
    End Sub

    Private Sub btnDelcampeXMLCatOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelcampeXMLCatOpenFile.Click

        FolderBrowserDialog1.Description = "Bitte Delcampe Lister Config Ordner auswählen"
        FolderBrowserDialog1.SelectedPath = "C:\"

        '# OK gedrück 
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDelcampeKategorie.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.gui_delcampe_category_xml = txtDelcampeKategorie.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '# Bestellung -> Bezahlt 
        Try
            colBackground.Color = My.Settings.gui_color_bestellungen_bezahlt
        Catch ex As Exception

        End Try

        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtColorBestellungen_bezahl.Text = colBackground.Color.Name
            My.Settings.gui_color_bestellungen_bezahlt = colBackground.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '# Bestellung -> Verschickt
        Try
            colBackground.Color = My.Settings.gui_color_bestellungen_verschickt
        Catch ex As Exception

        End Try
        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtColor_bestellungen_verschickt.Text = colBackground.Color.Name
            My.Settings.gui_color_bestellungen_verschickt = colBackground.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnColorKomplette_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorKomplette.Click

        '# Bestellung -> Komplett
        Try
            colBackground.Color = My.Settings.gui_color_bestellungen_komplett
        Catch ex As Exception

        End Try
        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtColor_bestellung_komplett.Text = colBackground.Color.Name
            My.Settings.gui_color_bestellungen_komplett = colBackground.Color
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnBestellungen_bestellt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestellungen_bestellt.Click

        '# Bestellung -> Bestellt
        Try
            colBackground.Color = My.Settings.gui_color_bestellungen_bestellt
        Catch ex As Exception

        End Try
        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtColor_bestellungen_bestellt.Text = colBackground.Color.Name
            My.Settings.gui_color_bestellungen_bestellt = colBackground.Color
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtDelcampe_outlook_folder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampe_outlook_folder.TextChanged
        If bIsLoading = False Then
            My.Settings.gui_outlooksync_outlook_folder_delcampe = txtDelcampe_outlook_folder.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtEbay_Outlook_ordner_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEbay_Outlook_ordner.TextChanged
        If bIsLoading = False Then
            My.Settings.gui_outlooksync_outlook_folder_ebay = txtEbay_Outlook_ordner.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnDelcampe_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelcampe_login.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "http://www.delcampe.de/status.php?language=G&retour=%2Fmember.php%3Fid_member%3D00359070%26language%3DG"
        frmWeb.Show(Me)
    End Sub

    Private Sub txtDelcampe_pwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampe_pwd.TextChanged
        If bIsLoading = False Then
            My.Settings.delcampe_pwd = settings_crypt(True, txtDelcampe_pwd.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtDelcampe_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampe_username.TextChanged
        If bIsLoading = False Then
            My.Settings.delcampe_username = txtDelcampe_username.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub tbOptions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbOptions.SelectedIndexChanged
        My.Settings.gui_options_last_tab = tbOptions.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub btnDelcampeExportPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelcampeExportPath.Click

        FolderBrowserDialog1.Description = "YABE - Export Verzeichnis angeben"

        '# OK gedrückt 
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDelcampe_export_path.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.gui_delcampe_export_path = txtDelcampe_export_path.Text
            My.Settings.Save()
        End If

    End Sub


    Private Sub txtDelcampe_export_path_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampe_export_path.TextChanged
        If bIsLoading = False Then
            My.Settings.gui_delcampe_export_path = txtDelcampe_export_path.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtDelcampeKategorie_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDelcampeKategorie.LostFocus
        If bIsLoading = False Then
            If Not IO.File.Exists(My.Settings.gui_delcampe_category_xml & "\sites.xml") = True Then
                My.Settings.gui_delcampe_category_xml = ""
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub txtDelcampeKategorie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampeKategorie.TextChanged
        If bIsLoading = False Then
            My.Settings.gui_delcampe_category_xml = txtDelcampeKategorie.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnDropLiveListe_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkGroupBy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupBy.CheckedChanged
        If bIsLoading = False Then
            My.Settings.gui_allow_groupBy = chkGroupBy.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkLVWReorder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLVWReorder.CheckedChanged
        If bIsLoading = False Then
            My.Settings.gui_lvw_bUse_Reorder_setting = chkLVWReorder.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkFehlerbericht_hardware_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFehlerbericht_hardware.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_debugmail_hardware = chkFehlerbericht_hardware.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtDelcampe_outlook_archiv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampe_outlook_archiv.TextChanged
        If bIsLoading = False Then
            My.Settings.gui_outlooksync_outlook_folder_delcampe_archiv = txtDelcampe_outlook_archiv.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txteBayOutllook_archiv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteBayOutllook_archiv.TextChanged
        If bIsLoading = False Then
            My.Settings.gui_outlooksync_outlook_folder_ebay_archiv = txteBayOutllook_archiv.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEmail_cc_mailreport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmail_cc_mailreport.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_email_debug_cc = chkEmail_cc_mailreport.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnDropLiveListe_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDropLiveListe.Click

    End Sub

    Private Sub chkAutoDelcampe_bestellstatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoDelcampe_bestellstatus.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_startup_delcampe_bestellungen = chkAutoDelcampe_bestellstatus.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkeBay_automatik_sync_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeBay_automatik_sync.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_startup_ebay_sync = chkeBay_automatik_sync.Checked
            My.Settings.Save()
        End If

    End Sub

    Private Sub chkYABE_minimizeToTray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYABE_minimizeToTray.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_minimize_tray = chkYABE_minimizeToTray.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtDauer_cockpit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDauer_cockpit.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtDauer_cockpit.Text) = True Then
                My.Settings.gui_dauer_cockpit = txtDauer_cockpit.Text
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub txtDauer_bestellungen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDauer_bestellungen.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtDauer_bestellungen.Text) = True Then
                My.Settings.gui_dauer_bestellungen = txtDauer_bestellungen.Text
                My.Settings.Save()
            End If
        End If

    End Sub

    Private Sub txtDauer_kunden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDauer_kunden.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtDauer_kunden.Text) = True Then
                My.Settings.gui_dauer_kunden = txtDauer_kunden.Text
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub txtDauer_bewertungen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDauer_bewertungen.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtDauer_bewertungen.Text) = True Then
                My.Settings.gui_dauer_bewertungen = txtDauer_bewertungen.Text
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelcampeLokaleBilder.Click
        FolderBrowserDialog1.Description = "YABE - Lokales Bilderverzeichnis auswählen..."

        '# OK gedrückt 
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDelcampe_BilderVerzeichnis.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.yabe_delcampe_bilder = txtDelcampe_BilderVerzeichnis.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkAutoReloadTabs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoReloadTabs.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_lvw_data_tab_reload = chkAutoReloadTabs.Checked
            My.Settings.Save()
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShopURL.TextChanged
        If bIsLoading = False Then
            My.Settings.shop_url = txtShopURL.Text
            My.Settings.Save()
        End If

    End Sub



    Private Sub tbOptions_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tbOptions.DrawItem
        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tbOptions.TabPages(e.Index)
        Dim ItemRect As Rectangle = tbOptions.GetTabRect(e.Index)
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
        If tbOptions.Alignment = TabAlignment.Left Or tbOptions.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tbOptions.Alignment = TabAlignment.Left Then RotateAngle = 270
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

    Private Sub txtUploadPfad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUploadPfad.TextChanged
        If bIsLoading = False Then
            My.Settings.ftp_hochladepfad = txtUploadPfad.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtFTPUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFTPUsername.TextChanged
        If bIsLoading = False Then
            My.Settings.ftp_username = txtFTPUsername.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtFTPPasswort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFTPPasswort.TextChanged
        If bIsLoading = False Then
            My.Settings.ftp_pwd = settings_crypt(True, txtFTPPasswort.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnArtikel_color_bestellt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArtikel_color_bestellt.Click

        '# Bestellung -> Bestellt
        Try
            colBackground.Color = My.Settings.gui_color_artikel_vorbestellt
        Catch ex As Exception

        End Try
        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtArtikel_color_bestellt.Text = colBackground.Color.Name
            My.Settings.gui_color_artikel_vorbestellt = colBackground.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnArtikel_color_warteliste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArtikel_color_warteliste.Click

        '# Bestellung -> Bestellt
        Try
            colBackground.Color = My.Settings.gui_color_artikel_warteliste
        Catch ex As Exception

        End Try
        If colBackground.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtArtikel_color_warteliste.Text = colBackground.Color.Name
            My.Settings.gui_color_artikel_warteliste = colBackground.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtYABETrennzeichen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYABETrennzeichen.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_trennzeichen = txtYABETrennzeichen.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkExaktProgressbar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExaktProgressbar.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_progress_exakt_mode = chkExaktProgressbar.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkLvwHottrack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLvwHottrack.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_lvw_hottracking = chkLvwHottrack.Checked
            My.Settings.Save()

            If chkLvwHottrack.Checked = False Then
                chkAutoReloadTabs.Enabled = False
                My.Settings.yabe_lvw_data_tab_reload = False
            Else
                chkAutoReloadTabs.Enabled = True
                If chkAutoReloadTabs.Checked = True Then
                    My.Settings.yabe_lvw_data_tab_reload = True
                End If

            End If

        End If
    End Sub

    Private Sub eBayDaten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tp_eBayDaten.Click

    End Sub

    Private Sub chkMail_shop_status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMail_shop_status.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_pl_shop_sendmail = chkMail_shop_status.Checked
            My.Settings.Save()
        End If


        cmbShop_auktionende_vorlage.Enabled = chkMail_shop_status.Checked
        cmbShop_auktionsende_betreff_vorlage.Enabled = chkMail_shop_status.Checked
        cmbShop_vorlage_bestellstatus.Enabled = chkMail_shop_status.Checked
        cmbShop_bestellstatus_betreff_vorlage.Enabled = chkMail_shop_status.Checked

    End Sub

    Private Sub chkMail_dekcampe_status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMail_dekcampe_status.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_pl_delcampe_sendmail = chkMail_dekcampe_status.Checked
            My.Settings.Save()
        End If

        cmbDelcampe_auktionsende_vorlage.Enabled = chkMail_dekcampe_status.Checked
        cmbDelcampe_auktionsende_betreff_vorlage.Enabled = chkMail_dekcampe_status.Checked
        cmbDelcampe_vorlage_bestellstatus.Enabled = chkMail_dekcampe_status.Checked
        cmbDelcampe_bestellstatus_betreff_vorlage.Enabled = chkMail_dekcampe_status.Checked

    End Sub

    Private Sub chkMail_ebay_status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMail_ebay_status.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_pl_ebay_sendmail = chkMail_ebay_status.Checked
            My.Settings.Save()
        End If

        cmbeBay_auktionsende_vorlage.Enabled = chkMail_ebay_status.Checked
        cmbeBay_auktionsende_vorlage_betreff.Enabled = chkMail_ebay_status.Checked
        cmbeBay_vorlage_bestellstatus.Enabled = chkMail_ebay_status.Checked
        cmbeBay_bestellstatus_betreff_vorlage.Enabled = chkMail_ebay_status.Checked

    End Sub

    Private Sub chkYABE_bestellstatus_debugmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYABE_bestellstatus_debugmail.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_bestellstatus_debug = chkYABE_bestellstatus_debugmail.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtMagentoURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMagentoURL.TextChanged
        If bIsLoading = False Then
            My.Settings.magento_url = txtMagentoURL.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtMagentoUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMagentoUsername.TextChanged
        If bIsLoading = False Then
            My.Settings.magento_username = txtMagentoUsername.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtMagentoPwD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMagentoPwD.TextChanged
        If bIsLoading = False Then
            My.Settings.magento_pwd = txtMagentoPwD.Text
            My.Settings.Save()
        End If
    End Sub
    '##############################
    '# >> MAGENTO LOGIN TEST 
    '##############################
    Private Sub btnMagentoLoginTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagentoLoginTest.Click

        Dim mc As New clsMagentoAPI
        If mc.getLogin() = True Then
            MsgBox("Login als '" & My.Settings.magento_username & "' war erfolgreich!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Else
            MsgBox("FEHLER: Login als '" & My.Settings.magento_username & "' fehlgeschlagen!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txteBayToken_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteBayToken.TextChanged
        If bIsLoading = False Then
            My.Settings.Production_ebaytoken = txteBayToken.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub bEigeneBilder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEigeneBilder.CheckedChanged
        If bIsLoading = False Then
            My.Settings.bUse_ownPictures = bEigeneBilder.Checked
            My.Settings.Save()
        End If

    End Sub

    Private Sub Yabe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tp_Yabe.Click

    End Sub

    Private Sub txtShop_url_bilder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShop_url_bilder.TextChanged
        If bIsLoading = False Then
            My.Settings.shop_url_bilder = txtShop_url_bilder.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtShopGalerie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShopGalerie.TextChanged
        If bIsLoading = False Then
            My.Settings.shop_url_galerie = txtShopGalerie.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtDatenbankname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatenbankname.TextChanged
        If bIsLoading = False Then
            My.Settings.datenbank_db = txtDatenbankname.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkeBayAPILog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeBayAPILog.CheckedChanged
        If bIsLoading = False Then
            My.Settings.eBay_APILog = chkeBayAPILog.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtFTPServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFTPServer.TextChanged
        If bIsLoading = False Then
            My.Settings.ftp_server = txtFTPServer.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtAddVorname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddVorname.TextChanged
        If bIsLoading = False Then
            My.Settings.user_vorname = txtAddVorname.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtAddNachname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddNachname.TextChanged
        If bIsLoading = False Then
            My.Settings.user_nachname = txtAddNachname.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtAddStrasse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddStrasse.TextChanged
        If bIsLoading = False Then
            My.Settings.user_strasse = txtAddStrasse.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtAddPLZ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddPLZ.TextChanged
        If bIsLoading = False Then
            My.Settings.user_plz = txtAddPLZ.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtAddOrt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddOrt.TextChanged
        If bIsLoading = False Then
            My.Settings.user_ort = txtAddOrt.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtAddLand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddLand.TextChanged
        If bIsLoading = False Then
            My.Settings.user_land = txtAddLand.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtBank_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank_name.TextChanged
        If bIsLoading = False Then
            My.Settings.bank_name = txtBank_name.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtBank_nr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank_nr.TextChanged
        If bIsLoading = False Then
            My.Settings.bank_nr = txtBank_nr.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtBank_leitzahl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank_leitzahl.TextChanged
        If bIsLoading = False Then
            My.Settings.bank_leitzahl = txtBank_leitzahl.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtBank_IBAN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank_IBAN.TextChanged
        If bIsLoading = False Then
            My.Settings.bank_IBAN = txtBank_IBAN.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtBank_BIC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank_BIC.TextChanged
        If bIsLoading = False Then
            My.Settings.bank_BIC = txtBank_BIC.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtBank_USTID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank_USTID.TextChanged
        If bIsLoading = False Then
            My.Settings.user_USTID = txtBank_USTID.Text
            My.Settings.Save()
        End If
    End Sub
    '#
    '# >> EiSo Shop Settings speichern
    '# 
    Private Sub setUpdateEiSoShop()
        Dim eiso_shop_englisch_an As String = "N"
        Dim shop_französisch_an As String = "N"
        Dim eiso_shop_ebay_links_an As String = "N"

        If My.Settings.eiso_shop_englisch_an = True Then
            eiso_shop_englisch_an = "Y"
        End If

        If My.Settings.eiso_shop_französisch_an = True Then
            shop_französisch_an = "Y"
        End If

        If My.Settings.eiso_shop_ebay_links_an = True Then
            eiso_shop_ebay_links_an = "N"
        End If

        Call getHTTPResponseMessage(My.Settings.ServerDatenaustausch_https & "://" & My.Settings.ServerDatenaustausch_url & "?mod=OPT_USER&user_vorname=" + System.Uri.EscapeDataString(txtAddVorname.Text) + "&user_nachname=" + System.Uri.EscapeDataString(txtAddNachname.Text) + "&user_strasse=" + System.Uri.EscapeDataString(txtAddStrasse.Text) + "&user_plz=" + System.Uri.EscapeDataString(txtAddPLZ.Text) + "&user_ort=" + System.Uri.EscapeDataString(txtAddOrt.Text) + "&user_land=" + System.Uri.EscapeDataString(txtAddLand.Text) + "&user_bankname=" + System.Uri.EscapeDataString(txtBank_name.Text) & "&user_kontonummer=" + System.Uri.EscapeDataString(txtBank_nr.Text) + "&user_bank_bic=" + System.Uri.EscapeDataString(txtBank_BIC.Text) + "&user_bank_iban=" + System.Uri.EscapeDataString(txtBank_IBAN.Text) + "&user_ustid=" + System.Uri.EscapeDataString(txtBank_USTID.Text) + "&user_telefon=" + System.Uri.EscapeDataString(txtAddTelefon.Text) + "&user_bank_leitzahl=" + System.Uri.EscapeDataString(txtBank_leitzahl.Text) & "&user_firma=" + System.Uri.EscapeDataString(txtUserFirmenname.Text) & "&user_shopname=" + System.Uri.EscapeDataString(txtEmailShopName.Text) & "&delcampe_api_token=" + txtDelcampeAPI.Text & "&ebay_links_an=N&shop_englisch_an=" & eiso_shop_englisch_an & "&shop_französisch_an=" & shop_französisch_an & "&eiso_shop_ebay_links_an=" & eiso_shop_ebay_links_an & "&KEY=" & My.Settings.yabe_keycode, mgetUpdaterMessage.setShopUserData, True)

    End Sub
    Private Sub btnPersonal_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonal_Save.Click
        btnPersonal_Save.Enabled = False
        Call setUpdateEiSoShop()
        btnPersonal_Save.Enabled = True

    End Sub

    Private Sub chkDatenbank_compress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatenbank_compress.CheckedChanged
        If bIsLoading = False Then
            My.Settings.datenbank_compress = chkDatenbank_compress.Checked
            My.Settings.Save()
        End If

    End Sub

    Private Sub chkDatenbank_pooling_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatenbank_pooling.CheckedChanged
        If bIsLoading = False Then
            My.Settings.datenbank_pooling = chkDatenbank_pooling.Checked
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnFTPLoginTesten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFTPLoginTesten.Click

        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & " \ FTP_test.txt", "Hochlade Testdatei", False)

            My.Computer.Network.UploadFile(Application.StartupPath & "\FTP_test.txt", "ftp:  //" + My.Settings.ftp_server & My.Settings.ftp_hochladepfad & "ftp_file_test.txt", My.Settings.ftp_username, My.Settings.ftp_pwd, True, 10)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'MsgBox(ftpwr.GetResponse())
    End Sub

    Private Sub btnAdminPanelLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminPanelLogin.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = My.Settings.shop_url & "/ACP/adminpanel.php"
        frmWeb.Show(Me)
    End Sub

    Private Sub txtAddTelefon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddTelefon.TextChanged
        If bIsLoading = False Then
            My.Settings.user_telefon = txtAddTelefon.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnExportExcelPath_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcelPath.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtExportExcelPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub chkStartupWizard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartupWizard.CheckedChanged
        If bIsLoading = False Then
            My.Settings.startup_setup = chkStartupWizard.Checked
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtPaypal_API_Benutzername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypal_API_Benutzername.TextChanged
        If bIsLoading = False Then
            My.Settings.APP_paypal_username = txtPaypal_API_Benutzername.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtPaypal_API_pwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypal_API_pwd.TextChanged
        If bIsLoading = False Then
            My.Settings.APP_paypal_pwd = settings_crypt(True, txtPaypal_API_pwd.Text)
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtPaypal_API_Signatur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypal_API_Signatur.TextChanged
        If bIsLoading = False Then
            My.Settings.APP_paypal_signature = txtPaypal_API_Signatur.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypal_20_prozent.TextChanged

        If IsNumeric(txtPaypal_20_prozent.Text) = True Then
            My.Settings.yabe_func_paypal_20_prozent = txtPaypal_20_prozent.Text
            My.Settings.Save()
            txtPaypal_20_prozent.BackColor = Color.White
        Else
            txtPaypal_20_prozent.BackColor = Color.Coral
        End If

    End Sub

    Private Sub chkPaypal_Gebühren_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaypal_Gebühren.CheckedChanged

        If bIsLoading = False Then
            My.Settings.APP_paypal_aktiv = chkPaypal_Gebühren.Checked
            My.Settings.Save()
        End If

        If chkPaypal_Gebühren.Checked = True Then
            txtPaypal_20_prozent.Enabled = True
            txtPaypal_20_transaktion.Enabled = True
            txtPaypal_21_prozent.Enabled = True
            txtPaypal_21_transaktion.Enabled = True
        Else
            txtPaypal_20_prozent.Enabled = False
            txtPaypal_20_transaktion.Enabled = False
            txtPaypal_21_prozent.Enabled = False
            txtPaypal_21_transaktion.Enabled = False
        End If

    End Sub

    Private Sub txtPaypal_20_transaktion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypal_20_transaktion.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtPaypal_20_transaktion.Text) = True Then
                My.Settings.yabe_func_paypal_20_transaktion = txtPaypal_20_transaktion.Text
                My.Settings.Save()
                txtPaypal_20_transaktion.BackColor = Color.White
            Else
                txtPaypal_20_transaktion.BackColor = Color.Coral
            End If

        End If

    End Sub

    Private Sub txtPaypal_21_prozent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypal_21_prozent.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtPaypal_21_prozent.Text) = True Then
                My.Settings.yabe_func_paypal_21_prozent = txtPaypal_21_prozent.Text
                My.Settings.Save()
                txtPaypal_21_prozent.BackColor = Color.White
            Else
                txtPaypal_21_prozent.BackColor = Color.Coral
            End If
        End If


    End Sub

    Private Sub txtPaypal_21_transaktion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypal_21_transaktion.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtPaypal_21_transaktion.Text) = True Then
                My.Settings.yabe_func_paypal_21_transaktion = txtPaypal_21_transaktion.Text
                My.Settings.Save()
                txtPaypal_21_transaktion.BackColor = Color.White
            Else
                txtPaypal_21_transaktion.BackColor = Color.Coral
            End If

        End If
    End Sub

    Private Sub txtNewsletter_emailadresse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewsletter_emailadresse.TextChanged
        If bIsLoading = False Then
            My.Settings.newsletter_versand_email = txtNewsletter_emailadresse.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtNewsletter_Passwort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewsletter_Passwort.TextChanged
        If bIsLoading = False Then
            My.Settings.newsletter_versand_pwd = settings_crypt(True, txtNewsletter_Passwort.Text)
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtNewsletter_AbsendeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewsletter_AbsendeName.TextChanged
        If bIsLoading = False Then
            My.Settings.newsletter_versand_name = txtNewsletter_AbsendeName.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtNewsletter_pop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewsletter_pop.TextChanged
        If bIsLoading = False Then
            My.Settings.newsletter_pop3 = txtNewsletter_pop.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtNewsletter_pop_port_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewsletter_pop_port.TextChanged
        If bIsLoading = False Then
            My.Settings.newsletter_pop3_port = txtNewsletter_pop_port.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtNewsletter_smtp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewsletter_smtp.TextChanged
        If bIsLoading = False Then
            My.Settings.newsletter_smtp = txtNewsletter_smtp.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtNewsletter_smtp_port_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewsletter_smtp_port.TextChanged

        If bIsLoading = False Then
            My.Settings.newsletter_smtp_port = txtNewsletter_smtp_port.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub tp_emaildaten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tp_emaildaten.Click

    End Sub

    Private Sub Label160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label160.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyabe_gui_magento_export_steuerklasse.TextChanged
        My.Settings.yabe_gui_magento_export_steuerklasse = txtyabe_gui_magento_export_steuerklasse.Text
        My.Settings.Save()
    End Sub

    Private Sub txtyabe_gui_magento_export_menge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyabe_gui_magento_export_menge.TextChanged
        My.Settings.yabe_gui_magento_export_menge = txtyabe_gui_magento_export_menge.Text
        My.Settings.Save()
    End Sub

    Private Sub txtyabe_gui_magento_export_sichtbarkeit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyabe_gui_magento_export_sichtbarkeit.TextChanged
        My.Settings.yabe_gui_magento_export_sichtbarkeit = txtyabe_gui_magento_export_sichtbarkeit.Text
        My.Settings.Save()
    End Sub

    Private Sub txtyabe_gui_magento_export_storeview_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyabe_gui_magento_export_storeview.TextChanged
        My.Settings.yabe_gui_magento_export_storeview = txtyabe_gui_magento_export_storeview.Text
        My.Settings.Save()
    End Sub

    Private Sub txtyabe_gui_magento_export_status_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyabe_gui_magento_export_status.TextChanged
        My.Settings.yabe_gui_magento_export_status = txtyabe_gui_magento_export_status.Text
        My.Settings.Save()
    End Sub

    Private Sub txtyabe_gui_magento_export_attributset_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyabe_gui_magento_export_attributset.TextChanged
        My.Settings.yabe_gui_magento_export_attributset = txtyabe_gui_magento_export_attributset.Text
        My.Settings.Save()
    End Sub

    Private Sub txteBayBewertung_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteBayBewertung.TextChanged
        My.Settings.yabe_gui_bewerten_defaultText = txteBayBewertung.Text
        My.Settings.Save()
    End Sub

    Private Sub txtMwst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMwst.TextChanged
        My.Settings.yabe_gui_rechnung_mwst = txtMwst.Text
        My.Settings.Save()
    End Sub

    Private Sub txtMwst_versand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMwst_versand.TextChanged
        My.Settings.yabe_gui_rechnung_mwst_versand = txtMwst_versand.Text
        My.Settings.Save()
    End Sub

    Private Sub chkMagento_aktiv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMagento_aktiv.CheckedChanged

        If chkMagento_aktiv.Checked = False Then
            chkMagento_übernahme.Enabled = False
            chkMagento_löschen.Enabled = False
        Else
            chkMagento_übernahme.Enabled = True
            chkMagento_löschen.Enabled = True
        End If

        My.Settings.yabe_magento_aktiv = chkMagento_aktiv.Checked
        My.Settings.Save()

    End Sub

    Private Sub chkMagento_übernahme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMagento_übernahme.CheckedChanged
        My.Settings.yabe_magento_übernahme = chkMagento_übernahme.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkMagento_löschen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMagento_löschen.CheckedChanged
        My.Settings.yabe_magento_löschen = chkMagento_löschen.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtDelcampe_wartezeit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelcampe_wartezeit.TextChanged

        If IsNumeric(txtDelcampe_wartezeit.Text) = True Then
            My.Settings.yabe_delcampe_gui_timer = txtDelcampe_wartezeit.Text
            txtDelcampe_wartezeit.BackColor = Color.White
        Else
            txtDelcampe_wartezeit.BackColor = Color.Beige
        End If

    End Sub

    Private Sub cmbShop_auktionende_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShop_auktionende_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_shop_text = cmbShop_auktionende_vorlage.Text
            My.Settings.yabe_vorlage_auktionsende_shop = clsDatenbank_modul.getVorlagen_id(cmbShop_auktionende_vorlage.Text)
            My.Settings.Save()
        End If

    End Sub

    Private Sub cmbMagento_auktionsende_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagento_auktionsende_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_magento_text = cmbMagento_auktionsende_vorlage.Text
            My.Settings.yabe_vorlage_auktionsende_magento = clsDatenbank_modul.getVorlagen_id(cmbMagento_auktionsende_vorlage.Text)
            My.Settings.Save()
        End If

    End Sub

    Private Sub cmbDelcampe_auktionsende_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelcampe_auktionsende_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_delcampe_text = cmbDelcampe_auktionsende_vorlage.Text
            My.Settings.yabe_vorlage_auktionsende_delcampe = clsDatenbank_modul.getVorlagen_id(cmbDelcampe_auktionsende_vorlage.Text)
            My.Settings.Save()
        End If


    End Sub

    Private Sub cmbeBay_auktionsende_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeBay_auktionsende_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_ebay_text = cmbeBay_auktionsende_vorlage.Text
            My.Settings.yabe_vorlage_auktionsende_ebay = clsDatenbank_modul.getVorlagen_id(cmbeBay_auktionsende_vorlage.Text)
            My.Settings.Save()
        End If


    End Sub

    Private Sub cmbeBay_vorlage_bestellstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeBay_vorlage_bestellstatus.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_ebay_text = cmbeBay_vorlage_bestellstatus.Text
            My.Settings.yabe_vorlage_bestellstatus_ebay = clsDatenbank_modul.getVorlagen_id(cmbeBay_vorlage_bestellstatus.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbDelcampe_vorlage_bestellstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelcampe_vorlage_bestellstatus.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_delcampe_text = cmbDelcampe_vorlage_bestellstatus.Text
            My.Settings.yabe_vorlage_bestellstatus_delcampe = clsDatenbank_modul.getVorlagen_id(cmbDelcampe_vorlage_bestellstatus.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbShop_vorlage_bestellstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShop_vorlage_bestellstatus.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_shop_text = cmbShop_vorlage_bestellstatus.Text
            My.Settings.yabe_vorlage_bestellstatus_shop = clsDatenbank_modul.getVorlagen_id(cmbShop_vorlage_bestellstatus.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbMagento_vorlagen_bestellstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagento_vorlagen_bestellstatus.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_magento_text = cmbMagento_vorlagen_bestellstatus.Text
            My.Settings.yabe_vorlage_bestellstatus_magento = clsDatenbank_modul.getVorlagen_id(cmbMagento_vorlagen_bestellstatus.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbeBay_vorlage_betreff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeBay_auktionsende_vorlage_betreff.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_betreff_ebay = cmbeBay_auktionsende_vorlage_betreff.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbeBay_bestellstatus_betreff_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeBay_bestellstatus_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_betreff_ebay = cmbeBay_bestellstatus_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbDelcampe_auktionsende_betreff_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelcampe_auktionsende_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_betreff_delcampe = cmbDelcampe_auktionsende_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbDelcampe_bestellstatus_betreff_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDelcampe_bestellstatus_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_betreff_delcampe = cmbDelcampe_bestellstatus_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbShop_auktionsende_betreff_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShop_auktionsende_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_betreff_shop = cmbShop_auktionsende_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbShop_bestellstatus_betreff_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShop_bestellstatus_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_betreff_shop = cmbShop_bestellstatus_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbMagento_auktionsende_betreff_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagento_auktionsende_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_betreff_magento = cmbMagento_auktionsende_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbMagento_bestellstatus_betreff_vorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagento_bestellstatus_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_betreff_magento = cmbMagento_bestellstatus_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtMagentoBestellungenSync_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMagentoBestellungenSync.TextChanged
        If IsNumeric(txtMagentoBestellungenSync.Text) Then
            My.Settings.yabe_magento_sync_mwst = txtMagentoBestellungenSync.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbRechnungVorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRechnungVorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_rechnung_emailtext = cmbRechnungVorlage.Text
            'My.Settings.yabe_vorlage_auktionsende_magento = clsDatenbank_modul.getVorlagen_id(cmbMagento_auktionsende_vorlage.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbRechnungVorlage_betreff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRechnungVorlage_betreff.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_rechnung_email_betreff = cmbRechnungVorlage_betreff.Text
            'My.Settings.yabe_vorlage_auktionsende_magento = clsDatenbank_modul.getVorlagen_id(cmbMagento_auktionsende_vorlage.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEmailStatusVerschicken_magento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmailStatusVerschicken_magento.CheckedChanged
        If bLoading = False Then
            My.Settings.yabe_pl_magento_sendmail = chkEmailStatusVerschicken_magento.Checked
            My.Settings.Save()
        End If

        cmbMagento_auktionsende_vorlage.Enabled = chkEmailStatusVerschicken_magento.Checked
        cmbMagento_auktionsende_betreff_vorlage.Enabled = chkEmailStatusVerschicken_magento.Checked
        cmbMagento_vorlagen_bestellstatus.Enabled = chkEmailStatusVerschicken_magento.Checked
        cmbMagento_bestellstatus_betreff_vorlage.Enabled = chkEmailStatusVerschicken_magento.Checked

    End Sub

    Private Sub btnFinanceOffice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceOffice.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFinanceOfficeExport.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.yabe_finance_office_export = txtFinanceOfficeExport.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtFinanceOffice_kundenummer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinanceOffice_kundenummer.TextChanged
        If bLoading = False Then

            If IsNumeric(txtFinanceOffice_kundenummer.Text) Then
                My.Settings.yabe_finance_office_kundennummer = txtFinanceOffice_kundenummer.Text
                txtFinanceOffice_kundenummer.BackColor = Color.White
            Else
                txtFinanceOffice_kundenummer.BackColor = Color.Coral
            End If

        End If
    End Sub

    Private Sub chkFinanceOffice_aktiv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFinanceOffice_aktiv.CheckedChanged
        If bIsLoading = False Then
            My.Settings.yabe_finance_office_aktiv = chkFinanceOffice_aktiv.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtFinanceOfficeExport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinanceOfficeExport.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_finance_office_export = txtFinanceOfficeExport.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkDelcampe_auction_end_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelcampe_auction_end.CheckedChanged
        If bIsLoading = False Then

        End If
        My.Settings.yabe_delcampe_auction_end = chkDelcampe_auction_end.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtPaypalArtikelBezeichnung_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypalArtikelBezeichnung.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_paypal_item_name = txtPaypalArtikelBezeichnung.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtPaypalEmailUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaypalEmailUsername.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_paypal_emailusername = txtPaypalEmailUsername.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub chkDelcampeShopverkäufeKill_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDelcampeShopverkäufeKill.CheckedChanged
        My.Settings.yabe_delcampek_auction_end = chkDelcampeShopverkäufeKill.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkMailSSLSupport_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMailSSLSupport.CheckedChanged
        My.Settings.email_ssl = chkMailSSLSupport.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtMysqlTimeout_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMysqlTimeout.TextChanged

        If IsNumeric(txtMysqlTimeout.Text) = True Then
            My.Settings.mysql_timeout = txtMysqlTimeout.Text
        Else
            My.Settings.mysql_timeout = 500
        End If


        My.Settings.Save()
    End Sub

    Private Sub chkNewsletterSSL_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNewsletterSSL.CheckedChanged
        My.Settings.email_newsletter_ssl = chkNewsletterSSL.Checked
        My.Settings.Save()

    End Sub

    Private Sub btnNewsletterEmailTest_Click(sender As System.Object, e As System.EventArgs) Handles btnNewsletterEmailTest.Click

        Dim clsMail As New clsEmail
        clsMail.bDebug_mail = True
        clsMail.strEmail_empfänger_email = My.Settings.email_username

        If clsMail.setSendNewsletter("Testemail für " & My.Settings.yabe_username, "EiSo Newsleter - Testmail") = True Then
            MsgBox("Email wurde erfolgreich verschickt!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtEmailBenutzer_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmailNewsletterBenutzer.TextChanged
        My.Settings.email_newsletter_username = txtEmailNewsletterBenutzer.Text
        My.Settings.Save()
    End Sub

    Private Sub txtEMailUsername_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEMailUsername.TextChanged
        My.Settings.email_versand_username = txtEMailUsername.Text
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampeDeleteENDE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDelcampeDeleteENDE.CheckedChanged
        If bIsLoading = False Then
            My.Settings.delcampe_DE_EN_DELETE = chkDelcampeDeleteENDE.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkStartupRückbewertung_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles chkStartupRückbewertung.CheckedChanged

    End Sub

    Private Sub btneBayGetToken_Click(sender As System.Object, e As System.EventArgs) Handles btneBayGetToken.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "https://signin.ebay.de/ws/eBayISAPI.dll?SignIn&runame=auth_tool_sdk_2b6b54516b704cef9b66447741d6689e&ruparams=params|Production-auth_tool_sdk_2b6b54516b704cef9b66447741d6689e-true-5045"
        frmWeb.Show()
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles btneBaySandbox.Click
        Dim frmWeb As New frmYABE_WebBrowser
        frmWeb.strURL = "https://signin.sandbox.ebay.com/ws/eBayISAPI.dll?SignIn&runame=auth_tool_sdk_11c3666f3d354678b6a1c5ebd50394fa&ruparams=params|Sandbox-auth_tool_sdk_11c3666f3d354678b6a1c5ebd50394fa-true-5049&hc=1&hm=vo.sk73%283350036"
        frmWeb.Show()
    End Sub

    Private Sub cmbeBayZahlungshinweis_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbeBayZahlungshinweis.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_ebay_zahlhinweise_text = cmbeBayZahlungshinweis.Text
            My.Settings.yabe_vorlage_ebay_zahlhinweise = clsDatenbank_modul.getVorlagen_id(cmbeBayZahlungshinweis.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkNewsletterLIMIT_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNewsletterLIMIT.CheckedChanged
        If bIsLoading = False Then
            My.Settings.chkNewsletterLIMIT = chkNewsletterLIMIT.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtArtikeldatenbank_neuste_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtArtikeldatenbank_neuste.TextChanged
        If bIsLoading = False Then
            If IsNumeric(txtArtikeldatenbank_neuste.Text) = True Then
                My.Settings.artikeldatenbank_neuste = txtArtikeldatenbank_neuste.Text
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub btnShopsteLogin_Click(sender As Object, e As EventArgs) Handles btnShopsteLogin.Click
        Dim frmShopsteLogin As New LoginForm1
        frmShopsteLogin.Show()
    End Sub

    Private Sub cmbShopste_auktionsende_vorlage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShopste_auktionsende_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_shopste_text = cmbShopste_auktionsende_vorlage.Text
            My.Settings.yabe_vorlage_auktionsende_shopste = clsDatenbank_modul.getVorlagen_id(cmbShopste_auktionsende_vorlage.Text)
            My.Settings.Save()
        End If

    End Sub

    Private Sub cmbShopste_auktionsende_betreff_vorlage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShopste_auktionsende_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_auktionsende_betreff_shopste = cmbShopste_auktionsende_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbShopste_vorlagen_bestellstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShopste_vorlagen_bestellstatus.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_shopste_text = cmbShopste_vorlagen_bestellstatus.Text
            My.Settings.yabe_vorlage_bestellstatus_shopste = clsDatenbank_modul.getVorlagen_id(cmbShopste_vorlagen_bestellstatus.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbShopste_bestellstatus_betreff_vorlage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShopste_bestellstatus_betreff_vorlage.SelectedIndexChanged
        If bLoading = False Then
            My.Settings.yabe_vorlage_bestellstatus_betreff_shopste = cmbShopste_bestellstatus_betreff_vorlage.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEmailStatusVerschicken_shopste_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmailStatusVerschicken_shopste.CheckedChanged
        If bLoading = False Then
            My.Settings.yabe_pl_shopste_sendmail = chkEmailStatusVerschicken_shopste.Checked
            My.Settings.Save()
        End If

        cmbShopste_auktionsende_vorlage.Enabled = chkEmailStatusVerschicken_shopste.Checked
        cmbShopste_auktionsende_betreff_vorlage.Enabled = chkEmailStatusVerschicken_shopste.Checked
        cmbShopste_vorlagen_bestellstatus.Enabled = chkEmailStatusVerschicken_shopste.Checked
        cmbShopste_bestellstatus_betreff_vorlage.Enabled = chkEmailStatusVerschicken_shopste.Checked
    End Sub

    Private Sub chkShopsteLagerbestandSync_CheckedChanged(sender As Object, e As EventArgs) Handles chkShopsteLagerbestandSync.CheckedChanged
        If bIsLoading = False Then
            My.Settings.shopste_lagerbestand_verwalten = chkShopsteLagerbestandSync.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkTestEmailsOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkTestEmailsOnly.CheckedChanged
        If bLoading = False Then
            My.Settings.email_testmodus_only = chkTestEmailsOnly.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEiSoBasisSprache_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoBasisSprache.CheckedChanged
        My.Settings.eiso_basis_sprache = chkEiSoBasisSprache.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtExportExcelPath_TextChanged(sender As Object, e As EventArgs) Handles txtExportExcelPath.TextChanged
        If System.IO.Directory.Exists(txtExportExcelPath.Text) = True Then
            My.Settings.eiso_csv_export = txtExportExcelPath.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtEmailShopName_TextChanged(sender As Object, e As EventArgs) Handles txtEmailShopName.TextChanged
        If bLoading = False Then
            My.Settings.eiso_shopname = txtEmailShopName.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtUserFirmenname_TextChanged(sender As Object, e As EventArgs) Handles txtUserFirmenname.TextChanged
        If bLoading = False Then
            My.Settings.user_firmenname = txtUserFirmenname.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtDelcampeAPI_TextChanged(sender As Object, e As EventArgs) Handles txtDelcampeAPI.TextChanged
        If bLoading = False Then
            My.Settings.delcampe_api_token = txtDelcampeAPI.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub chkShopsteDelcampeEnde_CheckedChanged(sender As Object, e As EventArgs) Handles chkShopsteDelcampeEnde.CheckedChanged
        If bLoading = False Then
            My.Settings.DELCAMPE_AKTIV = chkShopsteDelcampeEnde.Checked
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtShopsteAPIURL_TextChanged(sender As Object, e As EventArgs) Handles txtShopsteAPIURL.TextChanged
        If bLoading = False Then
            My.Settings.SHOPSTE_API_URL = txtShopsteAPIURL.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub txtBezahlungPaypalEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBezahlungPaypalEmail.TextChanged

        txtPaypalEmailUsername.Text = txtBezahlungPaypalEmail.Text
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If bLoading = False Then
            My.Settings.user_email = TextBox1.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub tp_personal_Click(sender As Object, e As EventArgs) Handles tp_personal.Click

    End Sub

    Private Sub chkEiSoShop_englisch_an_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoShop_englisch_an.CheckedChanged
        If bLoading = False Then
            My.Settings.eiso_shop_englisch_an = chkEiSoShop_englisch_an.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEiSoShop_französisch_an_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoShop_französisch_an.CheckedChanged
        If bLoading = False Then
            My.Settings.eiso_shop_französisch_an = chkEiSoShop_französisch_an.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEiSoShop_eBay_links_an_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoShop_eBay_links_an.CheckedChanged
        If bLoading = False Then
            My.Settings.eiso_shop_ebay_links_an = chkEiSoShop_eBay_links_an.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try

            Process.Start("https://developer.ebay.com/DevZone/sandboxuser/default.aspx")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://www.sandbox.ebay.de/")
    End Sub

    Private Sub cmbIESetVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIESetVersion.SelectedIndexChanged
        Select Case cmbIESetVersion.SelectedIndex
            Case 0
                SetBrowserEmulationVersion(BrowserEmulationVersion.Version7)
            Case 1
                SetBrowserEmulationVersion(BrowserEmulationVersion.Version8)
            Case 2
                SetBrowserEmulationVersion(BrowserEmulationVersion.Version9)
            Case 3
                SetBrowserEmulationVersion(BrowserEmulationVersion.Version10)
            Case 4
                SetBrowserEmulationVersion(BrowserEmulationVersion.Version11)
        End Select
        My.Settings.webbrowser_modus_index = cmbIESetVersion.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub chkTranslateProxy_CheckedChanged(sender As Object, e As EventArgs) Handles chkTranslateProxy.CheckedChanged
        My.Settings.translate_aktiv = chkTranslateProxy.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtProxy_TextChanged(sender As Object, e As EventArgs) Handles txtProxy.TextChanged
        My.Settings.translate_proxy = txtProxy.Text
        My.Settings.Save()
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        Call getTranslateText("Hallo Welt", "de", "en")
        MessageBox.Show("Proxy '" & txtProxy.Text & "' scheint zu funktionieren")
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.translate_tor_privoxy = CheckBox1.Checked
        My.Settings.Save()
        If CheckBox1.Checked = True Then
            If File.Exists(Application.StartupPath & "\Tor\nc.exe") = False Or File.Exists(Application.StartupPath & "\Privoxy\privoxy.exe") = False Then
                If MessageBox.Show("Sie müssen die nc.exe aus dem erweiterten Tor Bundle zuerst herrunterladen." + vbCrLf + "Möchten Sie das jetzt tun?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    clsUpdateDownloader = New WebFileDownloader
                    lblStatusTorBundle.Text = "Tor Bundle wird herruntergeladen..............."
                    clsUpdateDownloader.DownloadFileWithProgress("https://downloads.bludau-media.de/EiSo/nachgeladen/nc.exe", Application.StartupPath & "\Tor\nc.exe")

                    clsUpdateDownloader.DownloadFileWithProgress("https://downloads.bludau-media.de/EiSo/nachgeladen/Privoxy.zip", Application.StartupPath & "\Privoxy.zip")

                    Dim sc As New Shell32.Shell()
                    'Create directory in which you will unzip your files .
                    IO.Directory.CreateDirectory(Application.StartupPath & "\Privoxy")
                    'Declare the folder where the files will be extracted
                    Dim output As Shell32.Folder = sc.NameSpace(Application.StartupPath & "\")
                    'Declare your input zip file as folder  .
                    Dim input As Shell32.Folder = sc.NameSpace(Application.StartupPath & "\Privoxy.zip")
                    'Extract the files from the zip file using the CopyHere command .
                    output.CopyHere(input.Items, 4)

                    lblStatusTorBundle.Text = "Tor Bundle wurde herruntergeladen!"
                End If
                Exit Sub
            End If
        End If
        If CheckBox1.Checked = True Then

            If gbl_tor_pid = 0 Then
                TorStarup()
            End If
            If gbl_privoxy_pid = 0 Then
                PrivoxyStarup()
            End If

            txtProxy.Text = "localhost:8118"
        End If
    End Sub

    Private Sub chkEiSoShopGenerate_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoShopGenerate.CheckedChanged
        My.Settings.eiso_shop_user_generate = chkEiSoShopGenerate.Checked
        My.Settings.Save()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkServerDatenaustausch_https_CheckedChanged(sender As Object, e As EventArgs) Handles chkServerDatenaustausch_https.CheckedChanged
        Select Case chkServerDatenaustausch_https.Checked
            Case True
                My.Settings.ServerDatenaustausch_https = "https"
            Case False
                My.Settings.ServerDatenaustausch_https = "http"
        End Select

        My.Settings.Save()
    End Sub

    Private Sub chklvwEiSoShopPicture_CheckedChanged(sender As Object, e As EventArgs)
        My.Settings.lvw_eiso_shop_picture = chklvwEiSoShopPicture.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkLivePicture_CheckedChanged(sender As Object, e As EventArgs) Handles chkLivePicture.CheckedChanged
        My.Settings.lvw_live_picture = chkLivePicture.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkBestellungen_picture_CheckedChanged(sender As Object, e As EventArgs) Handles chkBestellungen_picture.CheckedChanged
        My.Settings.lvw_bestellung_picture = chkBestellungen_picture.Checked
        My.Settings.Save()
    End Sub

    Private Sub chklvwEiSoShopPicture_CheckedChanged_1(sender As Object, e As EventArgs) Handles chklvwEiSoShopPicture.CheckedChanged
        My.Settings.lvw_eiso_shop_picture = chklvwEiSoShopPicture.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkBestellung_monatsweise_CheckedChanged(sender As Object, e As EventArgs) Handles chkBestellung_monatsweise.CheckedChanged
        My.Settings.lvw_bestellung_monatsweise = chkBestellung_monatsweise.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkLive_monatsweise_CheckedChanged(sender As Object, e As EventArgs) Handles chkLive_monatsweise.CheckedChanged
        My.Settings.lvw_live_monatsweise = chkLive_monatsweise.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkKunden_monatsweise_CheckedChanged(sender As Object, e As EventArgs) Handles chkKunden_monatsweise.CheckedChanged
        My.Settings.lvw_kunden_monatsweise = chkKunden_monatsweise.Checked
        My.Settings.Save()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Settings.lvw_bewertung_monatsweise = CheckBox2.Checked
        My.Settings.Save()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub chkEiSoShopAktiv_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoShopAktiv.CheckedChanged
        My.Settings.shop_eiso_shopaktiv = chkEiSoShopAktiv.Checked

        If chkEiSoShopAktiv.Checked = False Then
            chkEiSoShop_englisch_an.Enabled = False
            chkEiSoShop_französisch_an.Enabled = False
            chkEiSoShop_eBay_links_an.Enabled = False
            txtShopURL.Enabled = False
            txtShopGalerie.Enabled = False
            txtShop_url_bilder.Enabled = False
        Else
            chkEiSoShop_englisch_an.Enabled = True
            chkEiSoShop_französisch_an.Enabled = True
            chkEiSoShop_eBay_links_an.Enabled = True
            txtShopURL.Enabled = True
            txtShopGalerie.Enabled = True
            txtShop_url_bilder.Enabled = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub chkEiSoShopexternFTP_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoShopexternFTP.CheckedChanged
        My.Settings.eiso_shop_ftp_aktiv = chkEiSoShopexternFTP.Checked

        If chkEiSoShopexternFTP.Checked = False Then
            txtFTPServer.Enabled = False
            txtFTPUsername.Enabled = False
            txtFTPPasswort.Enabled = False
            txtUploadPfad.Enabled = False
        Else
            txtFTPServer.Enabled = True
            txtFTPUsername.Enabled = True
            txtFTPPasswort.Enabled = True
            txtUploadPfad.Enabled = True
        End If
    End Sub

    Private Sub txtEmailNewsletterTimeout_TextChanged(sender As Object, e As EventArgs) Handles txtEmailNewsletterTimeout.TextChanged

        If IsNumeric(txtEmailNewsletterTimeout.Text) = True Then
            My.Settings.email_newsletter_timeout = txtEmailNewsletterTimeout.Text
            My.Settings.Save()
        End If


    End Sub

    Private Sub txtEmailAuktionsendeTimeout_TextChanged(sender As Object, e As EventArgs) Handles txtEmailAuktionsendeTimeout.TextChanged
        If IsNumeric(txtEmailAuktionsendeTimeout.Text) = True Then
            My.Settings.email_auktionsende_timeout = txtEmailAuktionsendeTimeout.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub chkEmailKopieEntwickler_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmailKopieEntwickler.CheckedChanged

    End Sub

    Private Sub chkEmailTestModus2Me_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmailTestModus2Me.CheckedChanged
        My.Settings.eiso_debug_email = chkEmailTestModus2Me.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkEmailKopieCC_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmailKopieCC.CheckedChanged
        My.Settings.eiso_email_cc = chkEmailKopieCC.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkEiSoShopAskDelete_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoShopAskDelete.CheckedChanged
        My.Settings.eiso_gui_shop_ask_delete_status = chkEiSoShopAskDelete.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkEiSoVersandarten_anzeigen_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoVersandarten_anzeigen.CheckedChanged
        My.Settings.eiso_gui_eiso_versandart_anzeigen = chkEiSoVersandarten_anzeigen.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkEiSoRechnungDrucken_CheckedChanged(sender As Object, e As EventArgs) Handles chkEiSoRechnungDrucken.CheckedChanged
        My.Settings.eiso_gui_eiso_versandkosten_rechnung_drucken = chkEiSoRechnungDrucken.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampeVersandkostenUndPaypal_de_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelcampeVersandkostenUndPaypal_de.CheckedChanged
        My.Settings.eiso_delcampe_versandkostenUndPaypal_de = chkDelcampeVersandkostenUndPaypal_de.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampeVersandkostenUndPaypal_en_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelcampeVersandkostenUndPaypal_en.CheckedChanged
        My.Settings.eiso_delcampe_versandkostenUndPaypal_en = chkDelcampeVersandkostenUndPaypal_en.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkBestellstatus_zwischenfenster_CheckedChanged(sender As Object, e As EventArgs) Handles chkBestellstatus_zwischenfenster.CheckedChanged
        My.Settings.eiso_bestellstatus_window = chkBestellstatus_zwischenfenster.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnBuyChars_Click(sender As Object, e As EventArgs) Handles btnBuyChars.Click
        Dim frmBuy As New frmBuyChars
        frmBuy.Show(Me)
    End Sub

    Private Sub chkDEVMODE_CheckedChanged(sender As Object, e As EventArgs) Handles chkDEVMODE.CheckedChanged


        If chkDEVMODE.Checked = True Then
            My.Settings.bDEVMODE = "qW1YY<>"
        Else
            My.Settings.bDEVMODE = "FORK"
        End If


    End Sub

    Private Sub btnTorDownloadBundle_Click(sender As Object, e As EventArgs) Handles btnTorDownloadBundle.Click
        If File.Exists(Application.StartupPath & "\Tor\nc.exe") = False Or File.Exists(Application.StartupPath & "\Privoxy\privoxy.exe") = False Then

            clsUpdateDownloader = New WebFileDownloader
            lblStatusTorBundle.Text = "Tor Bundle wird herruntergeladen..............."
            clsUpdateDownloader.DownloadFileWithProgress("https://downloads.bludau-media.de/EiSo/nachgeladen/nc.exe", Application.StartupPath & "\Tor\nc.exe")

            clsUpdateDownloader.DownloadFileWithProgress("https://downloads.bludau-media.de/EiSo/nachgeladen/Privoxy.zip", Application.StartupPath & "\Privoxy.zip")

            Dim sc As New Shell32.Shell()
            'Create directory in which you will unzip your files .
            IO.Directory.CreateDirectory(Application.StartupPath & "\Privoxy")
            'Declare the folder where the files will be extracted
            Dim output As Shell32.Folder = sc.NameSpace(Application.StartupPath & "\")
            'Declare your input zip file as folder  .
            Dim input As Shell32.Folder = sc.NameSpace(Application.StartupPath & "\Privoxy.zip")
            'Extract the files from the zip file using the CopyHere command .
            output.CopyHere(input.Items, 4)


            lblStatusTorBundle.Text = "Tor Bundle wurde herruntergeladen!"

        End If
    End Sub

    Private Sub chkBildvorschau_CheckedChanged(sender As Object, e As EventArgs) Handles chkBildvorschau.CheckedChanged
        My.Settings.chkBildvorschau = chkBildvorschau.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkBildvorschau_eiso_artikeldatenbank_CheckedChanged(sender As Object, e As EventArgs) Handles chkBildvorschau_eiso_artikeldatenbank.CheckedChanged
        My.Settings.chkBildvorschau_eiso_artikeldatenbank = chkBildvorschau_eiso_artikeldatenbank.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkBildvorschau_bestellungen_CheckedChanged(sender As Object, e As EventArgs) Handles chkBildvorschau_bestellungen.CheckedChanged
        My.Settings.chkBildvorschau_bestellung = chkBildvorschau_bestellungen.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampe_remote_bilder_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelcampe_remote_bilder.CheckedChanged
        My.Settings.chkEiSoDelcampe_remote_bilder_nutzen = chkDelcampe_remote_bilder.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDelcampe_https_zu_http_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelcampe_https_zu_http.CheckedChanged
        My.Settings.chkEiSoDelcampe_remote_bilder_http_ersetzen = chkDelcampe_https_zu_http.Checked
        My.Settings.Save()
    End Sub
End Class