Imports System.Net
Imports System.IO

Public Class frmOutlook_sync_duplicate
    Public strReferenz As String = ""
    Public bLoadTextSearch As Boolean = False
    Public strSprache As String = "DE"
    Public bResult As Boolean = False
    Public bshowMessage As Boolean = True
    Public bUnsichtbar As Boolean = False

    Private Sub frmOutlook_sync_duplicate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If bUnsichtbar = False Then
            chkSichtbar.Checked = My.Settings.yabe_delcampe_gui_sichtbar
            bLoadTextSearch = chkSichtbar.Checked
        Else
            chkSichtbar.Checked = False
            bLoadTextSearch = chkSichtbar.Checked
        End If

        Call getLoad_search()

    End Sub

    '########################################################
    '# >> Suchen ausführen 
    '########################################################
    Public Function getLoad_search() As Boolean

        Dim strText As String

        If txtSuche.Text.Length > 0 Then
            strText = txtSuche.Text
            strText = strText.Replace(" ", "+")
            If Not strSprache = "DE" Then

                strText = clsDatenbank_modul.getCMS_ShopItems("Beschreibung_eng", strReferenz)
                If strText.Length > 81 Then
                    strText = strText.Substring(0, 81)
                End If

                txtSuche.Text = strText
            End If

        Else
            If strSprache = "DE" Then
                strText = clsDatenbank_modul.getCMS_ShopItems("Beschreibung", strReferenz)
                If strText.Length > 81 Then
                    strText = strText.Substring(0, 81)
                End If
                txtSuche.Text = strText
            Else
                strText = clsDatenbank_modul.getCMS_ShopItems("Beschreibung_eng", strReferenz)
                If strText.Length > 81 Then
                    strText = strText.Substring(0, 81)
                End If
                txtSuche.Text = strText
            End If

            strText = strText.Replace(" ", "+")

        End If

        If bLoadTextSearch = True Then
            WebBrowser1.Navigate("http://www.delcampe.net/list.php?language=G&searchString=" & strText & "&searchMode=all&searchTldCountry=net&cat=0&searchInDescription=N")

        Else

            '################################################
            '# >> Delcampe Suchen ausführen 
            '################################################
            Dim request As WebRequest = WebRequest.Create("http://www.delcampe.net/list.php?language=G&searchString=" & strText & "&searchMode=all&searchTldCountry=net&cat=0&searchInDescription=N")

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
            Dim iBeginn As Integer = 0
            Dim iEnde As Integer = 0
            Dim iBeginn_url As Integer = 0
            Dim iEnde_url As Integer = 0
            Dim strData_anbieter As String = ""
            Dim strData_url As String = ""
            Dim bNext As Boolean = True
            Dim iCount As Integer = 0
            Dim strItemID As String
            '# Alle Suchtreffer durchlaufen 
            While bNext = True

                iCount += 1
                '# Anbieter suchen 
                iBeginn = responseFromServer.IndexOf("Anbieter:", iBeginn)

                If iBeginn = -1 Then
                    bNext = False
                    Exit While
                End If

                iEnde = responseFromServer.IndexOf("[", iBeginn)
                strData_anbieter = responseFromServer.Substring(iBeginn, iEnde - iBeginn)
                iBeginn += 10
                strData_anbieter = strData_anbieter.Replace("Anbieter: ", "").Trim

                '# Anbieter Delcampe User 
                If strData_anbieter.ToUpper = My.Settings.delcampe_username.ToUpper Then

                    iBeginn_url = responseFromServer.IndexOf("<div style=""padding:5px;text-align:center;"">", iBeginn_url)
                    iBeginn_url += 44
                    iEnde_url = responseFromServer.IndexOf("</div>", iBeginn_url)
                    strData_url = responseFromServer.Substring(iBeginn_url, iEnde_url - iBeginn_url)

                    Dim iBeginn_url2 As Integer = strData_url.IndexOf("<a href=""")
                    iBeginn_url2 += 9
                    Dim iEnde_url2 As Integer = strData_url.IndexOf("""", iBeginn_url2)
                    strData_url = strData_url.Substring(iBeginn_url2, iEnde_url2 - iBeginn_url2)
                    Application.DoEvents()

                    ToolStripStatusLabel1.Text = iCount & " / " & strData_url

                    If getItem_sku(strData_url) = True Then

                        If bshowMessage = True Then
                            MsgBox("Artikel zum löschen wird geöffnet", MsgBoxStyle.Information)
                        End If
                        bResult = True
                        Dim ExterneAnwendung As New System.Diagnostics.Process()
                        Dim str2() As String = strData_url.Split(",")
                        Try
                            strItemID = str2(1)
                        Catch ex As Exception
                            Exit While
                        End Try
                        ExterneAnwendung.StartInfo.FileName = "http://briefmarken.delcampe.de/modify.php?language=G&id_enchere=" & strItemID & "&action=close"
                        'ExterneAnwendung.StartInfo.FileName = "http://briefmarken.delcampe.de/" & strData_url
                        ExterneAnwendung.Start()
                        Me.Close()
                        Exit While
                    Else
                        bResult = False
                    End If

                    Dim str() As String = strData_url.Split(",")
                    Try
                        strItemID = str(1)
                    Catch ex As Exception
                        Exit While
                    End Try

                    'MsgBox(strItemID)
                    ' WebBrowser1.Navigate("http://briefmarken.delcampe.de/modify.php?language=G&id_enchere=" & strItemID & "action=close")

                End If
            End While
          
            If bUnsichtbar = True Then
                Me.Close()
            End If

        End If
      
    End Function

    '##############################################################
    '# >> Persönliche Referenz Suchen
    '##############################################################
    Public Function getItem_sku(ByVal strURL As String) As Boolean
        Try

            '################################################
            '# >> Delcampe Artikel öffnen
            '################################################
            Dim request As WebRequest = WebRequest.Create("http://briefmarken.delcampe.de/" & strURL)

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
            Dim iBeginn As Integer = 0
            Dim iEnde As Integer = 0
            Dim strBild As String = ""

            strBild = clsDatenbank_modul.getCMS_ShopItems("Bild", strReferenz)
            If Not responseFromServer.IndexOf(strBild) = -1 Then
                Return True
            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "getItem_sku")
            Return False
        End Try
    End Function

    Private Sub txtSuche_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSuche.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getLoad_search()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        '# TO CHANGE JB
        If WebBrowser1.DocumentText.IndexOf("Sie sind nicht befugt, die Seite anzuzeigen") > -1 Then
            ' WebBrowser1.Document.GetElementById("autologin").InnerText = "checked"
            WebBrowser1.Document.GetElementById("nickname").InnerText = My.Settings.delcampe_username
            WebBrowser1.Document.GetElementById("password").InnerText = My.Settings.delcampe_pwd
            WebBrowser1.Document.GetElementById("password").Focus()
            SendKeys.Send("{ENTER]")
        End If
    End Sub

    Private Sub txtSuche_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuche.TextChanged
        txtSuche.Text = txtSuche.Text.Replace(">", "-")
        txtSuche.Text = txtSuche.Text.Replace("&gt;", "-")
        txtSuche.Text = txtSuche.Text.Replace("<", "-")
        txtSuche.Text = txtSuche.Text.Replace("Propaganda - Karte :", "WW II ")
        txtSuche.Text = txtSuche.Text.Replace("Propaganda - ", "WW II ")
        txtSuche.Text = Trim(txtSuche.Text.Replace("NS ", ""))
        txtSuche.Text = Trim(txtSuche.Text.Replace("<br>", ""))
        txtSuche.Text = Trim(txtSuche.Text.Replace("&#39;", ""))
        txtSuche.Text = Trim(txtSuche.Text.Replace("&quot;", """"))
        txtSuche.Text = Trim(txtSuche.Text.Replace("'", ""))
    End Sub

    Private Sub chkSichtbar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSichtbar.CheckedChanged
        bLoadTextSearch = chkSichtbar.Checked
        My.Settings.yabe_delcampe_gui_sichtbar = chkSichtbar.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuchen.Click
        Call getLoad_search()
    End Sub
End Class