Imports System.IO
Imports System.Net

Public Class frmCMS_change_item

    Public bIsNew As Boolean = False
    Public setKategorie As Integer
    Public bIsLoading As Boolean = True
    Private iChanges As Integer = 0
    Public strLastFilePath As String = ""
    Private Sub frmCMS_change_item_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.yabe_gui_shop_location = Me.Location
        My.Settings.Save()

        If iChanges > 0 Then
 
            frmMain.frmManage.setShopLVW_refresh()

            If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count = 0 Then
                Try
                    frmMain.frmManage.lvwWebArtikel.Items(0).Selected = True
                Catch ex As Exception

                End Try

            End If
        End If

    End Sub


    Private Sub frmCMS_change_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strKAT As String = ""
        Try


            Call frmMain.frmManage.getShopMenue(lvwMenue)

            clsDatenbank_modul.getComboSprachen(cmbErstsprache)
            cmbErstsprache.SelectedIndex = 0

            clsDatenbank_modul.getComboSprachen(cmbZweitSprache)

            '# zweite Sprache Deutsch => English einstellen
            If frmMain.frmManage.cmbSprache_Artikeldatenbank.SelectedIndex = 0 Then
                cmbZweitSprache.SelectedIndex = 1
            Else
                cmbZweitSprache.SelectedIndex = frmMain.frmManage.cmbSprache_Artikeldatenbank.SelectedIndex
            End If


            If bIsNew = True Then
                btnItemAdd.PerformClick()
            Else
                If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count > 0 Then
                    Dim iID As Integer = 0
                    iID = frmMain.frmManage.lvwWebArtikel.SelectedItems(0).SubItems(0).Text
                    Call clsDatenbank_modul.getWebArtikel2GUI("SELECT * FROM tblGes WHERE ID='" & iID & "' ORDER BY Beschreibung ASC", Me)

                    If Not lblCat.Text = "" Then
                        Call setLVWSelection(lblCat.Text)
                    End If

                    wbrMain.Navigate(txtBildURL.Text)
                End If
            End If


            bIsLoading = False
        Catch ex As Exception
            bIsLoading = False
            Call debug_message(ex, strQuery & vbCrLf & "frmCMS_change_item_Load")
        End Try
    End Sub

    Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemSave.Click

        If lvwMenue.SelectedItems.Count = 0 Then
            MsgBox("Bitte eine Menükategorie auswählen", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtPreis.Text.Length = 0 Then
            MsgBox("Bitte einen Preis eintragen", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtBildURL.Text.Length = 0 Then
            If MsgBox("Möchten Sie Ohne Produktbilder forfahren?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        '############################################
        '# >> Aktuallisieren 
        '############################################
        If btnItemSave.Text = "&Aktuallisieren" Then

            If MsgBox("Möchten Sie wirklich den vorhandenen Artikel '" & txtQuelle.Text & "' aktuallisieren?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If clsDatenbank_modul.setWebArtikel(Me, True) = True Then

                    frmMain.frmManage.lvwWebArtikel.SelectedItems(0).SubItems(3).Text = txtBildURL.Text
                    '    Call setThumbnail("/")

                    wbrMain.Navigate(My.Settings.shop_url & "/suchen_Webseite_ID.php?txtIDSuchen=" & lblID.Text & "&KEY=" & My.Settings.yabe_keycode)
                    iChanges += 1
                    'MsgBox("Die Artikel aktuallisierung wurde erfolgreich durchgeführt", MsgBoxStyle.Information)
                Else
                    MsgBox("Der Artikel nicht erfolgreich gespeichert!", MsgBoxStyle.Critical)
                End If
            End If

            btnFTPUpload.Enabled = False
            '############################################
            '# >> Neu anlegen 
            '############################################
        Else

            If MsgBox("Möchten Sie wirklich einen Neuen Artikel '" & txtQuelle.Text & "' hinzufügen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If clsDatenbank_modul.setWebArtikel(Me, False) = True Then

                    If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count > 0 Then
                        frmMain.frmManage.lvwWebArtikel.SelectedItems(0).SubItems(3).Text = txtBildURL.Text
                    End If

                    '   Call setThumbnail("/")

                    MsgBox("Der neue Artikel wurde erfolgreich gespeichert", MsgBoxStyle.Information)
                    iChanges += 1
                Else
                    MsgBox("Die Daten wurden nicht gespeichert!", MsgBoxStyle.Critical)
                End If
            End If

            btnItemSave.Text = "&Aktuallisieren"
            btnItemDelete.Enabled = True
            btnItemAdd.Enabled = True

        End If

        txtBildURL.Text = strLastFilePath


    End Sub

    Private Sub cmbSprachauswahl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbErstsprache.SelectedIndexChanged

        If lblID.Text.Length > 0 And IsNumeric(lblID.Text) Then
            Call clsDatenbank_modul.getWebArtikel2GUI("SELECT * FROM tblGes WHERE ID='" & lblID.Text & "'", Me)
            'lblQuellsprache.Text = cmbErstsprache.Text
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemAdd.Click
        wbrMain.Navigate("about:blank")
        'txtBildURL.Text = ""
        'txtPreis.Text = ""
        'txtQuelle.Text = ""
        txtZiel.Text = ""
        TextBox1.Text = ""
        btnItemSave.Text = "Neuer Artikel"
        lblID.Text = ""
        btnItemDelete.Enabled = False
        btnItemAdd.Enabled = False
        btnFTPUpload.Enabled = False
        cmbItemStatus.SelectedIndex = 0
    End Sub

    Private Sub btnZurück_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZurück.Click
        Dim iAnzahl As Integer = 0
        Dim iid As Integer = 0
        If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count > 0 Then
            btnItemDelete.Enabled = True
            btnItemSave.Enabled = True
            Call setLvwView_blättern(lvwBlättern_modus.back, frmMain.frmManage.lvwWebArtikel, btnVor, btnZurück, Nothing)
            iid = frmMain.frmManage.lvwWebArtikel.SelectedItems(0).Text
            Call clsDatenbank_modul.getWebArtikel2GUI("SELECT * FROM tblGes WHERE ID='" & iid & "' ORDER BY Beschreibung ASC", Me)
            Call setLVWSelection(iid)
            wbrMain.Navigate(txtBildURL.Text)
            btnItemSave.Text = "&Aktuallisieren"
            btnItemDelete.Enabled = True
            btnItemAdd.Enabled = True
            btnFTPUpload.Enabled = False
        End If

    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0
        Dim iid As Integer = 0
        If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count > 0 Then

            Call setLvwView_blättern(lvwBlättern_modus.vor, frmMain.frmManage.lvwWebArtikel, btnVor, btnZurück, Nothing)

            If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count > 0 Then
                btnItemDelete.Enabled = True
                btnItemSave.Enabled = True
                iid = frmMain.frmManage.lvwWebArtikel.SelectedItems(0).Text
                Call clsDatenbank_modul.getWebArtikel2GUI("SELECT * FROM tblGes WHERE ID='" & iid & "' ORDER BY Beschreibung ASC", Me)
                Call setLVWSelection(iid)
                wbrMain.Navigate(txtBildURL.Text)
                btnItemSave.Text = "&Aktuallisieren"
                btnItemDelete.Enabled = True
                btnItemAdd.Enabled = True
                btnFTPUpload.Enabled = False
            Else
                btnVor.Enabled = False
            End If

 
        End If
    End Sub

    Private Sub btnFrmWebansicht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmCMS_change_item_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub frmCMS_change_item_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        My.Settings.yabe_gui_shop_change_windows_size = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub WebansichtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebansichtToolStripMenuItem.Click

        If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count > 0 Then



            If frmMain.frmManage.lvwWebArtikel.SelectedItems.Count > 0 Then
                Dim frmWeb As New frmYABE_WebBrowser
                frmWeb.lvwDataView = frmMain.frmManage.lvwWebArtikel
                frmWeb.webMain.Navigate(frmMain.frmManage.lvwWebArtikel.SelectedItems(0).SubItems(3).Text)
                frmWeb.Show()
            End If


        End If
    End Sub

    '######################################################
    '# >> Google Übersetzung starten
    '######################################################
    Private Sub getGoogleTranslate()
        Dim strTranslated As String = ""
        Dim strGoogleSprache As String = clsDatenbank_modul.getLanuage2GoogleCode(cmbZweitSprache.Text)
        btnItemSave.Enabled = False
        btnItemDelete.Enabled = False
        btnItemAdd.Enabled = False
        btnZurück.Enabled = False
        btnVor.Enabled = False
        txtZiel.Enabled = False

        mainLabel.Text = "Übersetze Artikel..."
        Application.DoEvents()
        strTranslated = getTranslateText(txtQuelle.Text, "de", strGoogleSprache)        

        '# Anhängen 
        If ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Checked = False Then
            txtZiel.Text = strTranslated
        Else
            txtZiel.Text &= vbCrLf & strTranslated
        End If
        txtZiel.Enabled = True
        btnItemSave.Enabled = True
        btnItemDelete.Enabled = True
        btnItemAdd.Enabled = True
        btnZurück.Enabled = True
        btnVor.Enabled = True
    End Sub

    Private Sub ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÜbersetzeErsteSpracheZweiteSpracheToolStripMenuItem.Click

        Call getGoogleTranslate()

    End Sub

    Private Sub cmbZweitSprache_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbZweitSprache.SelectedIndexChanged

        If lblID.Text.Length > 0 And IsNumeric(lblID.Text) Then
            'lblZielsprache.Text = cmbZweitSprache.Text
            txtZiel.Enabled = False
            Call clsDatenbank_modul.getWebArtikel2GUI("SELECT * FROM tblGes WHERE ID='" & lblID.Text & "'", Me)
            txtZiel.Enabled = True
        End If

    End Sub

    Private Sub ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Click
        If ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Checked = False Then
            ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Checked = True
        Else
            ZweiteSpracheÜbersetzungstextAnhängenToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub btnBildauswahl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBildauswahl.Click
        btnBildauswahl.Enabled = False

        OpenFileDialog1.ValidateNames = True
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Title = "YABE - Bildupload"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtBildURL.Text = OpenFileDialog1.FileName
            wbrMain.Navigate("file://" & txtBildURL.Text)
            btnFTPUpload.Enabled = True
        End If
        strLastFilePath = txtBildURL.Text

        btnBildauswahl.Enabled = True
    End Sub

    Private Sub btnFTPUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFTPUpload.Click
        Dim strLokalFile As String = ""

        If IO.File.Exists(txtBildURL.Text) = True Then
            btnFTPUpload.Enabled = False
            mainLabel.Text = "Beginne FTP Upload..."
            ToolStripProgressBar1.Visible = True


            If My.Settings.eiso_shop_ftp_aktiv = False Then
                Dim nvc As New Specialized.NameValueCollection
                nvc.Add("modus", "system_upload_file")
                nvc.Add("KEY", gbl_KeyCode)
                nvc.Add("benutzername", My.Settings.yabe_username)
                nvc.Add("pwd", My.Settings.yabe_pwd)
                ' nvc.Add("picture_name", lvwWebArtikel.Items(iCount).SubItems(3).Text.Replace(" ", "_").Replace(">", "-").Replace("/", "").Replace("\", "").Replace("!", ""))
                Dim strBildName() As String = txtBildURL.Text.Split("\")
                nvc.Add("picture_name", strBildName(strBildName.Length - 1))

                Dim strBild As String
                Dim strBildFixed As String = strBildName(strBildName.Length - 1).Replace("\", "-").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "").Replace("<", "").Replace(">", "").Replace("|", "")
                'MessageBox.Show(Application.StartupPath)


                Try
                    '# Ist Bild von der Festplatte selektiert?
                    If txtBildURL.Text.Contains(":\") = True Then

                        If strBildFixed.Length > 240 Then
                            strBildFixed = strBildFixed.Substring(0, 240)
                        End If

                        '# Externe Bilder - HTTP Link
                        Dim client As New WebClient()
                        client.DownloadFile(txtBildURL.Text, Application.StartupPath & "\bilderexport\" & strBildFixed)
                        strLokalFile = Application.StartupPath & "\bilderexport\" & strBildFixed

                    End If

                Catch ex As Exception
                    strLokalFile = "error"
                End Try


                'HttpUploadFile("http://shopste.com/api.php", "C:\Users\jbludau\Desktop\gelb_katze.jpg", "system_upload", "image/jpeg", nvc)
                'MessageBox.Show(ListView1.Items(icount).SubItems(3).Text)
                'lvwWebArtikel.Items(iCount).Selected = True
                frmMain.master_Message_label.Text = strBildName(strBildName.Length - 1) & " - Lade Bild hoch..."

                If strLokalFile = "" Then
                    strLokalFile = txtBildURL.Text
                End If

                '# Kein Fehler beim Verarbeiten
                If Not strLokalFile = "error" Then
                    txtBildURL.Text = HttpUploadFile(My.Settings.shop_url & "api.php", strLokalFile, "system_upload", "image/jpeg", nvc)
                End If
            Else

                '# FTP Upload
                Call setFileUpload()

                '# Bild verkleinern
                Call setThumbnail()
            End If



            'wbrMain.Navigate(txtBildURL.Text)

            mainLabel.Text = "Bilder Upload abgeschlossen"
            ToolStripProgressBar1.Visible = False
            btnFTPUpload.Enabled = True
        Else
            MsgBox("Bitte eine gültige Datei zum Hochladen auswählen", MsgBoxStyle.Exclamation)
        End If

    End Sub

    '#######################################################
    '# >> HTTP -> erzeugt Bild 
    '#######################################################
    Public Function setThumbnail(Optional ByVal strSplitter As String = "\") As Boolean
        Try
            Dim str() As String
            str = txtBildURL.Text.Split(strSplitter)
            Dim strFilename As String = str(str.Length - 1)
            txtBildURL.Text = My.Settings.shop_url_bilder + My.Settings.yabe_username + "/" + strFilename
            getHTTPResponseMessage(My.Settings.shop_url_bilder + "/yabe_thumbs.php?picture=" + txtBildURL.Text + "&usr=" & My.Settings.yabe_username, mgetUpdaterMessage.getShopThumbnail, True)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '#######################################################
    '# >> FTP Upload -> Lädt das Bild hoch 
    '#######################################################
    Public Function setFileUpload() As Boolean
        Dim status As Boolean = False
        'Dim myURI As String = "ftp://" + My.Settings.ftp_server & "/httpdocs/"

        Dim str() As String = txtBildURL.Text.Split("\")

        Dim info As New FileInfo(txtBildURL.Text)
        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Maximum = info.Length

        Dim myURI As String = "ftp://" & My.Settings.ftp_server & "/" & My.Settings.ftp_hochladepfad & "/" & str(str.Length - 1)

        Dim requestStream As Stream = Nothing
        Dim fileStream As FileStream = Nothing
        Dim uploadResponse As FtpWebResponse = Nothing
        Dim ftpwr As FtpWebRequest = FtpWebRequest.Create(myURI)
        ftpwr.Method = WebRequestMethods.Ftp.UploadFile
        ftpwr.Credentials = New NetworkCredential(My.Settings.ftp_username, My.Settings.ftp_pwd)
        ftpwr.Proxy = Nothing

        ' MsgBox(ftpwr.GetResponse())
        Try
            requestStream = ftpwr.GetRequestStream()
        Catch ex As Exception

        End Try

        fileStream = File.Open(txtBildURL.Text, FileMode.Open)

        Dim buffer(1024) As Byte
        Dim bytesRead As Integer
        Dim iCount As Integer = 0

        While True
            iCount += 1
            bytesRead = fileStream.Read(buffer, 0, buffer.Length)
            If bytesRead = 0 Then
                Exit While
            End If

            Try
                ToolStripProgressBar1.Value = iCount * 1024
                Application.DoEvents()
            Catch ex As Exception

            End Try


            requestStream.Write(buffer, 0, bytesRead)
        End While

        requestStream.Close()

        uploadResponse = ftpwr.GetResponse()

        Return True

    End Function

    Private Sub cmbItemStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemStatus.SelectedIndexChanged

        If IsNumeric(lblID.Text) = True And bIsLoading = False Then
            Select Case cmbItemStatus.Text
                Case "Aktuell"
                    Call clsDatenbank_modul.setWebartikelStatus(0, lblID.Text)
                    mainLabel.Text = "Artikelstatus für '" + lblID.Text + "' auf aktuell geändert"
                Case "Bestellt"
                    Call clsDatenbank_modul.setWebartikelStatus(1, lblID.Text)
                    mainLabel.Text = "Artikelstatus für '" + lblID.Text + "' auf bestellt geändert"
                Case "Warteliste"
                    Call clsDatenbank_modul.setWebartikelStatus(2, lblID.Text)
                    mainLabel.Text = "Artikelstatus für '" + lblID.Text + "' auf Warteliste geändert"
                Case "Importiert"
                    Call clsDatenbank_modul.setWebartikelStatus(3, lblID.Text)
                    mainLabel.Text = "Artikelstatus für '" + lblID.Text + "' auf Importiert geändert"
            End Select

        End If

    End Sub

    Private Sub btnItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemDelete.Click
        btnItemDelete.Enabled = False
        btnItemSave.Enabled = False
        Call frmMain.frmManage.setShopDeleteItem()
    End Sub


    Private Sub lvwMenue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMenue.SelectedIndexChanged

        If lvwMenue.SelectedItems.Count > 0 Then
            ToolStripStatusLabel1.Text = "Kategorie: " & lvwMenue.SelectedItems(0).SubItems(1).Text
            setKategorie = lvwMenue.SelectedItems(0).Text
        End If

    End Sub

    '######################################################################
    '# >> Selektion für Listview Laden 
    '######################################################################
    Private Function setLVWSelection(ByVal iID As Integer) As Boolean
        Dim iCount As Integer = 0
        For iCount = 0 To lvwMenue.Items.Count - 1
            If iID = lvwMenue.Items(iCount).Text Then

                lvwMenue.Items(iCount).Selected = True
                Application.DoEvents()
                lvwMenue.Items(iCount).EnsureVisible()
                Exit For
            End If
        Next
    End Function

    Private Sub lvwMenue_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMenue.MouseEnter

    End Sub

    Private Sub txtQuelle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuelle.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call getGoogleTranslate()
        End If
    End Sub

    Private Sub txtZiel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZiel.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call getGoogleTranslate()
        End If
    End Sub
End Class