Imports System.IO
Imports System.Net

Public Class frmCMS_Item2Shop

    Public lvwData As ListView
    Dim bUpload As Boolean = False


    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
        If MsgBox("Möchten Sie wirklich einen Neuen Artikel '" & txtQuelle.Text & "' hinzufügen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            btnNeu.Enabled = False
            If clsDatenbank_modul.setWebArtikel_übernahme(Me, False) = True Then

                '# Rücksetzen der Farbe

                LinkLabel2.ForeColor = Color.Blue


                If setThumbnail() = True Then
                    MsgBox("Der neue Artikel wurde erfolgreich gespeichert", MsgBoxStyle.Information)
                    Call frmMain.frmManage.setStatus_new(lvwData, clsDatenbank.yabe_bestellstatus.uebernommen)
                Else
                    MsgBox("Probleme beim erzeugen des Thumbnails" & vbCrLf & "Artikel übernommen", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("Die Daten wurden nicht gespeichert!", MsgBoxStyle.Critical)
                btnNeu.Enabled = True
            End If

        End If

    End Sub

    '#######################################################
    '# >> HTTP -> erzeugt Bild 
    '#######################################################
    Public Function setThumbnail() As Boolean
        Try
            Dim str() As String

            If bUpload = True Then
                str = txtBildURL.Text.Split("\")
            Else
                str = txtBildURL.Text.Split("/")
            End If

            Dim strFilename As String = str(str.Length - 1)
            txtBildURL.Text = My.Settings.shop_url_bilder + strFilename
            getHTTPResponseMessage(My.Settings.shop_url_bilder + "/yabe_thumbs.php?picture=" + My.Settings.shop_url_bilder + strFilename, mgetUpdaterMessage.getShopThumbnail, True)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frmItem2Shop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lvwData.Enabled = False
        If clsDatenbank_modul.getCMS_Menue("SELECT * from tbl_menue  ORDER BY Parent ASC, Child ASC", lvwMenue, frmMain.frmManage.cmbSprache_Artikeldatenbank.Text) = False Then
            MsgBox("Fehler beim abrufen der Kategorieliste", MsgBoxStyle.Critical)
        End If
        lvwData.Enabled = True
        getData()

        If lvwData.SelectedItems(0).SubItems(13).Text = "eBay" Then
            Call geteBayBeschreibung()
        End If
    End Sub

    Private Sub btnZurück_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZurück.Click
        If lvwData.SelectedItems.Count > 0 Then
            Call setLvwView_blättern(lvwBlättern_modus.back, lvwData, btnVor, btnZurück, TextBox1)
            btnNeu.Enabled = True
            Call getData()
            Application.DoEvents()

            If lvwData.SelectedItems(0).SubItems(13).Text = "eBay" Then
                Call geteBayBeschreibung()
            End If

        End If
    End Sub

    Private Sub getData()
        txtQuelle.Text = lvwData.SelectedItems(0).SubItems(4).Text
        txtPreis.Text = lvwData.SelectedItems(0).SubItems(5).Text
        txtBildURL.Text = lvwData.SelectedItems(0).SubItems(14).Text

        '# eBay Bild gefunden -> FTP Upload aktivieren
        If txtBildURL.Text.IndexOf("ebayimg.com") > 0 Then
            btnBildauswahl.Enabled = True
            btnFTPUpload.Enabled = True
        Else
            btnFTPUpload.Enabled = False
            btnBildauswahl.Enabled = False
        End If

        chkStatus.Text = "Status: " & lvwData.SelectedItems(0).SubItems(7).Text

        If lvwData.SelectedItems(0).SubItems(7).Text = "Übernommen" Then
            txtQuelle.BackColor = Color.Beige
            btnNeu.Enabled = False
        Else
            txtQuelle.BackColor = Color.WhiteSmoke
        End If

        Select Case lvwData.SelectedItems(0).SubItems(13).Text
            Case "eBay"
                lbleBayBeschreibung.Visible = True
                LinkLabel1.Visible = True
                LinkLabel2.Visible = True
            Case "delcampe"
                lbleBayBeschreibung.Visible = False
                LinkLabel1.Visible = False
                LinkLabel2.Visible = False
            Case "CMS"
                lbleBayBeschreibung.Visible = False
                LinkLabel1.Visible = False
                LinkLabel2.Visible = False
        End Select

        WebBrowser1.Navigate(txtBildURL.Text)
    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click

        If lvwData.SelectedItems.Count > 0 Then
            Call setLvwView_blättern(lvwBlättern_modus.vor, lvwData, btnVor, btnZurück, TextBox1)
            btnNeu.Enabled = True
            Call getData()
            Application.DoEvents()

            If lvwData.SelectedItems(0).SubItems(13).Text = "eBay" Then
                Call geteBayBeschreibung()
            End If

        End If

    End Sub

    Private Sub lvwMenue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMenue.SelectedIndexChanged
        If lvwMenue.SelectedItems.Count > 0 Then
            lblKategorie.Text = lvwMenue.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = "http://cgi.ebay.de/ws/eBayISAPI.dll?ViewItem&rd=1&item=" & lvwData.SelectedItems(0).Text & "&ssPageName=STRK:MEWA:IT&ih=018"
        ExterneAnwendung.Start()

    End Sub

    Private Sub btnBildauswahl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBildauswahl.Click
        btnBildauswahl.Enabled = False

        OpenFileDialog1.ValidateNames = True
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Title = "EiSo - Bildupload"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtBildURL.Text = OpenFileDialog1.FileName
        End If

        btnBildauswahl.Enabled = True
    End Sub

    Private Sub btnFTPUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFTPUpload.Click
        btnFTPUpload.Enabled = False
        ToolStripStatusLabel1.Text = "Beginne FTP Upload..."
        ToolStripProgressBar1.Visible = True

        '# FTP Upload
        bUpload = True
        Call setFileUpload()

        '# Bild verkleinern
        Call setThumbnail()
        bUpload = False

        ToolStripStatusLabel1.Text = "FTP Upload abgeschlossen"
        ToolStripProgressBar1.Visible = False
        btnFTPUpload.Enabled = True
    End Sub

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

        Dim myURI As String = "ftp://" & My.Settings.ftp_server & My.Settings.ftp_hochladepfad & "/" & str(str.Length - 1)

        Dim requestStream As Stream = Nothing
        Dim fileStream As FileStream = Nothing
        Dim uploadResponse As FtpWebResponse = Nothing
        Dim ftpwr As FtpWebRequest = FtpWebRequest.Create(myURI)
        ftpwr.Method = WebRequestMethods.Ftp.UploadFile
        ftpwr.Credentials = New NetworkCredential(My.Settings.ftp_username, My.Settings.ftp_pwd)
        ftpwr.Proxy = Nothing

        ' MsgBox(ftpwr.GetResponse())
        requestStream = ftpwr.GetRequestStream()
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

    Private Sub geteBayBeschreibung()
        If frmMain.frmManage.lvwBestellverwaltung_nach_artikel.SelectedItems.Count > 0 Then
            lbleBayBeschreibung.Enabled = False
            txtQuelle.Enabled = False

            Dim clseBay As New clseAPI_eBay
            Dim fetchedItem As New eBay.Service.Core.Soap.ItemType
            Dim str() As String
            Dim strBeschreibung As String
            Application.DoEvents()
            fetchedItem = clseBay.getItemInfo(frmMain.frmManage.lvwBestellverwaltung_nach_artikel.SelectedItems(0).Text)
            lbleBayKategorie.Text = fetchedItem.PrimaryCategory.CategoryID

            str = txtQuelle.Text.Split(" ")

            strBeschreibung = getEbayLangeBeschreibung(fetchedItem.Description)

            '# Führende ID mit in der neuen Beschreibung übernehmen
            If IsNumeric(str(0)) Then
                strBeschreibung = str(0) & " " & strBeschreibung
            End If
            txtQuelle.Text = strBeschreibung
            txtQuelle.Enabled = True
            Application.DoEvents()

            Call selectMenue(False)

            lbleBayBeschreibung.Enabled = True
        End If
    End Sub

    Private Sub lbleBayBeschreibung_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbleBayBeschreibung.LinkClicked

        Call geteBayBeschreibung()

    End Sub

    Private Function getEbayLangeBeschreibung(ByVal strBeschreibung As String) As String
        Dim strBeginn As String
        Dim strEnde As String
        Dim iBeginn As Integer
        Dim iEnde As Integer
        Dim strExlBeschreibung As String

        strBeginn = "<!-- START_YABE_BESCHREIBUNG -->"
        strEnde = "<!-- END_YABE_BESCHREIBUNG -->"

        iBeginn = strBeschreibung.IndexOf(strBeginn)

        If iBeginn = -1 Then
            Return "-1"
        End If

        iEnde = strBeschreibung.IndexOf(strEnde, iBeginn)

        strExlBeschreibung = strBeschreibung.Substring(iBeginn + strBeginn.Length, iEnde - (iBeginn + strBeginn.Length)).Trim

        Return strExlBeschreibung
    End Function

    Private Sub selectMenue(ByVal bAddNew As Boolean)
        Dim iMenueID As Integer
        ' MsgBox(lvwMenue.SelectedItems(0).Text)
        If IsNumeric(lbleBayKategorie.Text) = True Then
            iMenueID = clsDatenbank_modul.chkeBayID(lbleBayKategorie.Text)
            If iMenueID = -1 Then
                ' Gibt Kategorie noch nicht 
                If bAddNew = False Then
                    LinkLabel2.LinkColor = Color.Red
                    message.Text = "Keine eBay Kategorie Verbindung gefunden"
                Else
                    clsDatenbank_modul.seteBayID2Menue(lbleBayKategorie.Text, lvwMenue.SelectedItems(0).Text, "")
                    message.Text = "Neue Kategorie Verbindung angelegt"
                End If

            Else
                '# Selektierten Eintrag löschen
                If lvwMenue.SelectedItems.Count > 0 Then
                    lvwMenue.SelectedItems(0).Selected = False
                End If

                ' Auswählen des Eintrags in der GUI
                For icount As Integer = 0 To lvwMenue.Items.Count - 1
                    If lvwMenue.Items(icount).Text = iMenueID Then
                        lvwMenue.Items(icount).Selected = True
                        lvwMenue.Items(icount).EnsureVisible()
                        ' MsgBox(lvwMenue.SelectedItems(0).Text)
                        message.Text = "Automatische Kategorieauswahl " & lvwMenue.Items(icount).SubItems(1).Text
                        Application.DoEvents()
                        Exit For
                    End If
                Next
            End If

        End If
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        selectMenue(True)
        LinkLabel2.LinkColor = Color.Blue

    End Sub
End Class