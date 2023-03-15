Imports Microsoft.Office.Interop

Public Class clsOutlook

    Dim objOutlook As Outlook.Application

    ' Den aktuellen Arbeitsbereich von Outlook mit dem
    ' Namespaces festlegen
    Dim objNameSpace As Outlook.NameSpace


    ' Der MAPI-Folder legt den Ordner fest (z. B. Kontakte)
    Dim objMapiFolder As Outlook.MAPIFolder

    ' Items sind die einzelnen Einträge
    Dim objItems As Outlook.Items

    ' Zähler zum Füllen der Listboxen
    Dim zaehler As Integer

    ' Speicherung des Usernamens - vom Profil abhängig
    Dim AktUser As String

    Public Enum mOutlook
        alle = 0
        delcampe = 1
        eBay = 2
        delcampe_bezahlt = 3
        ebay_bezahlt = 4
        delcampe_bewertung = 5
    End Enum

    Private Enum mOutlookDefaultFolder
        olFolderDeletedItems = 3
        olFolderOutbox = 4
        olFolderSentItems = 5
        olFolderInbox = 6
        olFolderCalendar = 9

        olFolderContacts = 10

        olFolderJournal = 11

        olFolderNotes = 12

        olFolderTasks = 13

        olFolderDrafts = 16
    End Enum

    Public Enum enumPlattformModus
        verkauft = 0
        bewertung = 1
        delcampe_bezahlt = 2
        delcampe_bewertung = 3
    End Enum

    Public Sub FindContactEmailByName(ByVal firstName As String, _
    ByVal lastName As String)
        objOutlook = CreateObject("Outlook.Application")

        Dim outlookNameSpace As Outlook.NameSpace = objOutlook.GetNamespace("MAPI")
        Dim contactFolder As Outlook.MAPIFolder = _
            outlookNameSpace.GetDefaultFolder( _
            Outlook.OlDefaultFolders.olFolderContacts)

        Dim contactItems As Outlook.Items = contactFolder.Items

        Try
            Dim contact As Outlook.ContactItem = _
                CType(contactItems.Find(String.Format _
                ("[FirstName]='{0}' and [LastName]={1}", _
                firstName, lastName)), Outlook.ContactItem)

            If contact IsNot Nothing Then
                contact.Display()
            Else
                MsgBox("The contact information was not found.")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function SearchForEmail(ByVal partialAddress As String) As Boolean

        Dim contactMessage As String = String.Empty
        objOutlook = CreateObject("Outlook.Application")
        objNameSpace = objOutlook.GetNamespace("MAPI")
        Dim contacts As Outlook.MAPIFolder = objNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts)

        For Each foundContact As Outlook.ContactItem In contacts.Items
            If Not (foundContact.Email1Address Is Nothing) Then
                If foundContact.Email1Address.Contains(partialAddress) Then
                    Return True
                End If
            End If
        Next
        If contactMessage.Length > 0 Then
        Else
            contactMessage = "No Contacts were found."
        End If
        'MsgBox(contactMessage)
        Return False
    End Function

    '###########################################################
    '# >> Kontakte einlesen 
    '###########################################################
    Public Function getContacts(ByRef lvwOut As ListView) As Boolean

        Dim zaehler As Integer = 0

        Try
            ' Outlook initialisieren
            objOutlook = CreateObject("Outlook.Application")
            lvwOut.BeginUpdate()
            lvwOut.Items.Clear()
            ' Namespace initialisieren
            objNameSpace = objOutlook.GetNamespace("MAPI")

            ' Aktueller User in Outlook ermitteln
            'AktUser = objNameSpace.CurrentUser

            ' Ordner setzen, in unserem Fall Contacts
            objMapiFolder = objNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts)

            ' Items initialisieren
            objItems = objMapiFolder.Items

            ' Einträge nach dem Nachnamen sortieren lassen
            objItems.Sort("[Lastname]", False)

            ' Alle Items in die Listbox schreiben
            ' (Zuname & Vorname)
            For zaehler = 1 To objItems.Count
                ' lstKontakt.AddItem(objItems(zaehler).LastName & _
                '  ", " & objItems(zaehler).FirstName)            
                ' MsgBox(objItems(zaehler).LastName)
                Dim lvwItem As New ListViewItem

                lvwItem.Text = ""
                lvwItem.SubItems.Add(objItems(zaehler).FirstName & " " & objItems(zaehler).LastName)
                lvwItem.SubItems.Add(objItems(zaehler).MailingAddressStreet)
                lvwItem.SubItems.Add(objItems(zaehler).MailingAddressCity)
                lvwItem.SubItems.Add(objItems(zaehler).MailingAddressPostalCode)
                lvwItem.SubItems.Add(objItems(zaehler).MailingAddressCountry)
                lvwItem.SubItems.Add(objItems(zaehler).Email1Address)
                lvwOut.Items.Add(lvwItem)

            Next
            lvwOut.EndUpdate()
            Return True
        Catch ex As Exception
            Call debug_message(ex, "Outlook -> getContacts")
            Return False
        End Try
    End Function

    '#######################################################################################
    '# >> Neuen Kontakt hinzufügen 
    '#######################################################################################
    Public Function olAddContact(ByVal sLastName As String, _
  Optional ByVal sFirstName As String = "", _
  Optional ByVal sCompanyName As String = "", _
  Optional ByVal sPhoneNumber As String = "", _
  Optional ByVal sEMail As String = "", _
  Optional ByVal sWebPage As String = "", _
  Optional ByVal sStreet As String = "", _
  Optional ByVal sOrt As String = "", _
  Optional ByVal sPLZ As String = "", _
  Optional ByVal sCountry As String = "") As Boolean


        ' Neuen Outlook-Kontakt hinzufügen
        Dim oOutlook As Object    ' Outlook.Application
        Dim oNameSpace As Object  ' Outlook.NameSpace
        Dim oMAPIFolder As Object ' Outlook.MAPIFolder
        Dim oContact As Object    ' Outlook.ContactItem

        Const olFolderContacts = 10

        ' Fehlerbehandlung aktivieren
        On Error GoTo ErrHandler

        ' Outlook-Application-Objekt erstellen
        oOutlook = CreateObject("Outlook.Application")

        ' Namespace initialisieren
        oNameSpace = oOutlook.GetNamespace("MAPI")

        ' Kontakt-Ordner verwenden
        oMAPIFolder = oNameSpace.GetDefaultFolder(olFolderContacts)

        ' Objekt für neuen Eintrag erstellen
        oContact = oMAPIFolder.Items.Add
        With oContact
            ' Eigenschaften des Eintrag festlegen
            .LastName = Trim$(sLastName)
            .FirstName = Trim$(sFirstName)
            .CompanyName = Trim$(sCompanyName)
            .PrimaryTelephoneNumber = Trim$(sPhoneNumber)
            .Email1Address = Trim$(sEMail)
            .WebPage = Trim$(sWebPage)
            .MailingAddressStreet = sStreet
            .MailingAddressCity = sOrt
            .MailingAddressPostalCode = sPLZ
            .MailingAddressCountry = sCountry
            ' hier können natürlich noch weitere Eigenschaften
            ' für den neuen Kontakt festgelegt werden, wie z.B.
            ' HomeAddressStreet, HomeAddressCity, etc.
            ' (siehe hierzu VB-Objekt-Katalog - Outlook - ContactItem)
            ' ...

            ' Kontakt speichern
            .Save()
        End With
        olAddContact = True

ErrHandler:
        If Err.Number <> 0 Then
            MsgBox("Fehler beim Erstellen des Outlook-Kontakts." & vbCrLf & _
              CStr(Err.Number) & " " & Err.Description, vbExclamation + vbOKOnly)

            olAddContact = False
        End If

        ' Objekte wieder freigeben
        oContact = Nothing
        oMAPIFolder = Nothing
        oNameSpace = Nothing
        oOutlook = Nothing
    End Function

    '##########################################################
    '# >> Newsletter Mailerdeamons einlesen 
    '##########################################################
    Public Function getNewsletter_deamons(ByVal strFolderName As String, ByVal lvw As ListView) As Boolean
        Dim strStatus As String
        strStatus = "Variablen-Definition"
        Dim oOutlook As Object       ' Outlook Object
        Dim oNamespace As Object     ' Namespace Object
        Dim oFolder As Object        ' MapiFolder Object
        Dim oMail As Object          ' Mail Object

        'Dim oDestFolder As Object    ' ZielFolder für Outlook Mail
        Dim i As Integer
        Dim j As Integer
        Dim blnSaveAtt As Boolean




        ' Outlook-Konstanten
        strStatus = "Konstanten-Definition"



        ' Outlook-Objekt erstellen
        strStatus = "Objekt fuer Outlook erstellen"
        oOutlook = CreateObject("Outlook.Application")

        ' Namespace: MAPI
        strStatus = "Typ ist MAPI"
        oNamespace = oOutlook.GetNamespace("MAPI")

        ' Outlook-Ordner: "Neue Nachrichten"
        strStatus = "Posteingang fuer neue Nachrichten"

        '# Bei Übergabe Verzeichnis auswählen 
        '# Bei Übergabe Verzeichnis auswählen 
        oFolder = oNamespace.GetDefaultFolder(6)

        If strFolderName.Length > 0 Then

            Dim oFolders As Outlook.Folders = oFolder.Folders
            oFolder = oFolders.Item(strFolderName)


        End If



        ' Alle Mails durchlaufen
        strStatus = "Alle Mails durchlaufen"
        i = 1
        j = oFolder.Items.Count


        '# alle Emails abholen
        Dim str() As String
        Do While j > 0

            'End If
            Application.DoEvents()

            blnSaveAtt = False
            oMail = oFolder.Items(j)

            'MsgBox(oMail.ReceivedTime.ToString)
            Try
                str = oMail.ReceivedTime.ToString.Split(" ")
 
                Dim strEmail As String = oMail.Body

                Dim iPosAnfang As Integer = strEmail.IndexOf("<")
                Dim iPosEnde As Integer = strEmail.IndexOf(">")

                strEmail = strEmail.Substring(iPosAnfang, iPosEnde - iPosAnfang)
                strEmail = strEmail.Replace("<", "")

                Dim strGrund As String = oMail.Body
                strGrund = strGrund.Substring(iPosEnde, Len(oMail.Body) - iPosEnde)

                Dim lvwItem As New ListViewItem
                lvwItem.Text = strEmail
                lvwItem.SubItems.Add(strGrund)

                lvw.Items.Add(lvwItem)

                frmMain.master_Message_label.Text = j & " / " & oFolder.Items.Count & " YABE Outlook Sync - " & oMail.ReceivedTime

            Catch ex As Exception
                frmMain.master_Message_label.Text = "skipped"
            End Try


            j = j - 1
        Loop
    End Function
    '##############################################################################################
    '# >> eMails Filtern -> Anhänge 
    '##############################################################################################
    Public Function email_filter(ByRef lvwOut As ListView, ByVal bModus As mOutlook, Optional ByVal strFolderName As String = "", Optional ByVal dbBeginn As Date = Nothing, Optional ByRef frm As frmOutlook_sync = Nothing) As Boolean

        Dim strStatus As String
        strStatus = "Variablen-Definition"
        Dim oOutlook As Object       ' Outlook Object
        Dim oNamespace As Object     ' Namespace Object
        Dim oFolder As Object        ' MapiFolder Object
        Dim oMail As Object          ' Mail Object
        Dim oAnhang As Object        ' Attachment Object
        'Dim oDestFolder As Object    ' ZielFolder für Outlook Mail
        Dim i As Integer
        Dim j As Integer
        Dim blnSaveAtt As Boolean
        'Dim olFolderInbox
        Dim olDefaultFolders As New mOutlookDefaultFolder
        Const olFolderDeletedItems = 3
        Const olFolderOutbox = 4
        Const olFolderSentItems = 5
        Const olFolderInbox = 6
        Const olFolderCalendar = 9
        Const olFolderContacts = 10
        Const olFolderJournal = 11
        Const olFolderNotes = 12
        Const olFolderTasks = 13
        Const olFolderDrafts = 16
        Dim myItems As Outlook.Items
        Dim myItem As Outlook.MailItem
        Dim bNoDate As Boolean = False
        Dim Date1 As Date
        Try
            If dbBeginn = Nothing Then
                bNoDate = True
            Else
                bNoDate = False
                Date1 = dbBeginn.AddDays(-1)
            End If


            If strFolderName = "5" Then
                'olFolderInbox = 5
            End If

            ' Outlook-Konstanten
            strStatus = "Konstanten-Definition"


            lvwOut.Items.Clear()
            lvwOut.BeginUpdate()

            ' Outlook-Objekt erstellen
            strStatus = "Objekt fuer Outlook erstellen"
            oOutlook = CreateObject("Outlook.Application")


            'oOutlook = oOutlook.Item("All Accounts")
            ' Send and receive.
            'oOutlook.Start()

            '# Profile auswählen 
            'oOutlook.Logon("YourValidProfile", Missing.Value, False, True)


            ' Get unread e-mail messages.
            'oItems = oItems.Restrict("[Unread] = true")


            ' Namespace: MAPI
            strStatus = "Typ ist MAPI"
            oNamespace = oOutlook.GetNamespace("MAPI")

            ' Outlook-Ordner: "Neue Nachrichten"
            strStatus = "Posteingang fuer neue Nachrichten"

            If IsNumeric(strFolderName) = True Then

                Select Case strFolderName
                    Case 3
                        oFolder = oNamespace.GetDefaultFolder(olFolderDeletedItems)

                    Case 4
                        oFolder = oNamespace.GetDefaultFolder(olFolderOutbox)
                    Case 5
                        oFolder = oNamespace.GetDefaultFolder(olFolderSentItems)
                    Case 6
                        oFolder = oNamespace.GetDefaultFolder(olFolderInbox)

                    Case 9
                        oFolder = oNamespace.GetDefaultFolder(olFolderCalendar)

                    Case 10
                        oFolder = oNamespace.GetDefaultFolder(olFolderContacts)

                    Case 11
                        oFolder = oNamespace.GetDefaultFolder(olFolderJournal)

                    Case 12
                        oFolder = oNamespace.GetDefaultFolder(olFolderNotes)
                    Case 13
                        oFolder = oNamespace.GetDefaultFolder(olFolderTasks)

                    Case 16
                        oFolder = oNamespace.GetDefaultFolder(olFolderDrafts)

                    Case Else
                        oFolder = oNamespace.GetDefaultFolder(olFolderInbox)
                End Select

                strFolderName = ""
            Else
                oFolder = oNamespace.GetDefaultFolder(olFolderInbox)
            End If




            '# Bei Übergabe Verzeichnis auswählen 
            If strFolderName.Length > 0 Then

                Dim oFolders As Outlook.Folders = oFolder.Folders
                oFolder = oFolders.Item(strFolderName)


            End If



            ' Alle Mails durchlaufen
            strStatus = "Alle Mails durchlaufen"
            i = 1
            j = oFolder.Items.Count
            frm.ToolStripProgressBar1.Maximum = j
            frm.ToolStripProgressBar1.Value = 0

            myItems = oFolder.Items
            myItems.Sort("[ReceivedTime]", True)
            Dim str() As String

            For Each myItem In myItems
                'MsgBox(myItem.ReceivedTime)
                'If Not oMail.ReceivedTime.ToString.Contains(dbBeginn) Then
                frm.ToolStripProgressBar1.Value += 1

                'End If
                Application.DoEvents()

                blnSaveAtt = False
                oMail = oFolder.Items(j)

                'MsgBox(oMail.ReceivedTime.ToString)
                Try
                    str = myItem.ReceivedTime.ToString.Split(" ")
                    '# 
                    If bNoDate = False Then
                        Dim date2 As Date = CDate(myItem.ReceivedTime.ToString)  'str(0) & " 00:00:00"
                        If date2 <= Date1.Date Then
                            Exit For
                        End If

                    End If

                    '  If Not dbBeginn.Date = "#12:00:00 AM#" Then
                    '   If dbBeginn.Date.ToString.Replace("#", "").Replace("/", ".") = str(0) & " 00:00:00" Then
                    '       Call getOutlook2Yabe_items(lvwOut, myItem, bModus)
                    '   End If
                    ' Else
                    Call getOutlook2Yabe_items(lvwOut, myItem, bModus)
                    'End If
                    frmMain.master_Message_label.Text = j & " / " & oFolder.Items.Count & " YABE Outlook Sync - " & oMail.ReceivedTime & "- " & oMail.Subject

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    frmMain.master_Message_label.Text = "skipped"
                End Try


                j = j - 1
            Next

            '# alle Emails abholen

            'Do While j > 0

            '    'If Not oMail.ReceivedTime.ToString.Contains(dbBeginn) Then
            '    frm.ToolStripProgressBar1.Value += 1

            '    'End If
            '    Application.DoEvents()

            '    blnSaveAtt = False
            '    oMail = oFolder.Items(j)

            '    'MsgBox(oMail.ReceivedTime.ToString)
            '    Try
            '        str = oMail.ReceivedTime.ToString.Split(" ")
            '        '# 

            '        If Not dbBeginn.Date = "#12:00:00 AM#" Then
            '            If dbBeginn.Date.ToString.Replace("#", "").Replace("/", ".") = str(0) & " 00:00:00" Then
            '                Call setOutlook2Yabe_items(lvwOut, oMail, bModus)
            '            End If
            '        Else
            '            Call setOutlook2Yabe_items(lvwOut, oMail, bModus)
            '        End If
            '        frmMain.master_Message_label.Text = j & " / " & oFolder.Items.Count & " YABE Outlook Sync - " & oMail.ReceivedTime

            '    Catch ex As Exception
            '        frmMain.master_Message_label.Text = "skipped"
            '    End Try


            '    j = j - 1
            'Loop

            lvwOut.EndUpdate()


            '# Spalten an Inhalt anpassen 
            lvwOut.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            lvwOut.Columns(3).Width = 0 ' Betreff
            lvwOut.Columns(4).Width = 0 ' Inhalt 


            ' Objekte zerstören
            strStatus = "Mailobjekte zerstören"
            oMail = Nothing
            oAnhang = Nothing
            oFolder = Nothing
            oNamespace = Nothing
            oOutlook = Nothing
            Exit Function

        Catch ex As Exception
            lvwOut.EndUpdate()
            Call debug_message(ex, "Outlook -> email_filter")
        End Try
    End Function

    '###################################################
    '# >> Items einfügen 
    '###################################################
    Public Function getOutlook2Yabe_items(ByRef lvwOut As ListView, ByVal oMail As Object, ByVal bModus As mOutlook) As Boolean
        Dim lvwItem As New ListViewItem
        Dim strSubject As String = oMail.Subject
        Dim strEmail As String = oMail.SenderEmailAddress
        Dim bDelcampe As Boolean = False
        Dim beBay As Boolean = False
        bDelcampe = False
        beBay = False
        If strSubject.IndexOf("[D*] Artikel verkauft") > -1 Or strSubject.IndexOf("[D*] Verkaufter Artikel") > -1 Or strSubject.IndexOf("[D*] Bewertung") > -1 Or strSubject.IndexOf("[D*] Artikel bezahlt") > -1 Then

            If strSubject.IndexOf("Re:") = -1 And strSubject.IndexOf("RE:") = -1 And strSubject.IndexOf("AW:") = -1 Then
                lvwItem.SubItems.Add("Delcampe")
                strSubject = strSubject
                bDelcampe = True
            Else
                bDelcampe = False
            End If

        ElseIf strEmail.IndexOf("eBay@ebay.de") > -1 Then

            lvwItem.SubItems.Add("eBay")
            beBay = True

        Else
            lvwItem.SubItems.Add("Unbekannt")
        End If

        lvwItem.SubItems.Add(oMail.SenderEmailAddress)
        lvwItem.SubItems.Add(strSubject)
        lvwItem.SubItems.Add(oMail.Body)

        Try
            lvwItem.SubItems.Add(oMail.ReceivedTime)
        Catch ex As Exception

        End Try


        Select Case bModus
            Case mOutlook.alle
                lvwOut.Items.Add(lvwItem)
            Case mOutlook.delcampe

                '# IST EMAIL DELCAMPE 
                If bDelcampe = True Then

                    ' BEWERTUNG 
                    If strSubject.IndexOf("[D*] Bewertung") > -1 Then
                        Call getEMAIL_text_delcampe(oMail.Body, lvwItem, enumPlattformModus.bewertung)
                    ElseIf strSubject.IndexOf("[D*] Artikel bezahlt") > -1 Then
                        Call getEMAIL_text_delcampe(oMail.Body, lvwItem, enumPlattformModus.delcampe_bezahlt)
                    ElseIf strSubject.IndexOf("[D*] Artikel verkauft") > -1 Or strSubject.IndexOf("[D*] Verkaufter Artikel") > -1 Then

                        Call getEMAIL_text_delcampe(oMail.Body, lvwItem, enumPlattformModus.verkauft)
                    End If


                    If lvwItem.Text = "" Then
                        ' Eintrag in Listview setzen 
                        lvwOut.Items.Add(lvwItem)
                    End If

                End If

            Case mOutlook.eBay
                If beBay = True Then
                    lvwOut.Items.Add(lvwItem)
                End If
        End Select
    End Function

    '################################################################
    '# >> Delcampe Mailtext Analyser 
    '################################################################
    Public Function getEMAIL_text_delcampe(ByVal strText As String, ByRef lvwItem As ListViewItem, ByVal strModus As enumPlattformModus) As Boolean
        Try

            Dim strLines() As String
            Dim i As Integer = 0
            Dim bItemID As Boolean = False

            Dim strTitle As String = ""
            Dim strSKU As String = ""
            Dim strDelCampeNickname As String = ""
            Dim strPreis As String = ""
            Dim strReferenzNr As String = ""
            Dim bAdress As Boolean = False ' Mit / ohne Adresse
            Dim strDelcampeID As String = ""
            Dim strSprache_liste As String = ""
            Dim strSprache_mutter As String = ""
            Dim strSplit() As String
            Dim strReferenzNr_del As String
            Dim strLänderkennung As String = ""
            strLines = strText.Split(vbCrLf)
            Dim strPLZStadt() As String
            Dim bLinesMinus As Boolean = False
            Dim strCity As String
            Dim iLoop As Integer = 0
            Dim bIN As Boolean = False
            Dim strPLZ As String

            '# Modus auswählen 
            Select Case strModus


                '###################################################
                '# >> Delcampe Bewertung 
                '###################################################
                Case enumPlattformModus.bewertung



                    Dim strID As String = ""
                    Dim strName As String = ""
                    Dim strKommentar As String = ""

                    For i = 0 To strLines.Length - 1



                        '# Suche nach Adresse 
                        If strLines(i).IndexOf("(#") > -1 Then

                            strSplit = strLines(i).Split(" ")

                            If strSplit.Length > 0 Then
                                strID = strSplit(strSplit.Length - 1).Replace("(#", "").Replace(")", "")

                                'lvwItem.SubItems.Add(strSplit(1).Replace("(#", "").Replace(")", "").Trim) ' SKU                                
                                bAdress = True
                            End If
                        ElseIf strLines(i).IndexOf("Von:") > -1 Then
                            strSplit = strLines(i).Split(" ")
                            strName = strSplit(strSplit.Length - 1)
                        ElseIf strLines(i).IndexOf("Kommentar:") > -1 Then

                            strKommentar = strLines(i).Replace("Kommentar:", "")
                        End If


                    Next

                    lvwItem.SubItems.Add(strName) ' ID 
                    lvwItem.SubItems.Add("") ' Auktionservice 
                    lvwItem.SubItems.Add("") ' Auktionservice 
                    lvwItem.SubItems.Add("") ' Auktionservice 
                    lvwItem.SubItems.Add(strKommentar) ' Auktionservice 
                    lvwItem.SubItems.Add(strID) ' Auktionservice 
                    lvwItem.SubItems.Add("") ' PLZ + Ort 
                    lvwItem.SubItems.Add("") ' Land


                    If bAdress = False Then
                        lvwItem.SubItems.Add("") ' Artikel
                        lvwItem.SubItems.Add("") ' Artikel-SKU
                        lvwItem.SubItems.Add("") ' Nickname
                        lvwItem.SubItems.Add("") ' Preis
                    End If


                    lvwItem.SubItems.Add("") ' YABE ID 
                    lvwItem.SubItems.Add("") ' Delcampe USER ID 
                    lvwItem.SubItems.Add("") '# Muttersprache
                    lvwItem.SubItems.Add("") '# Liste der Sprachen

                    lvwItem.SubItems.Add("bewertung") '# Plattformmodus

                Case enumPlattformModus.delcampe_bezahlt
                    Dim strID As String = ""
                    Dim strName As String = ""
                    Dim strKommentar As String = ""

                    For i = 0 To strLines.Length - 1



                        '# Suche nach Adresse 
                        If strLines(i).IndexOf("Der Käufer ") > -1 Then

                            strSplit = strLines(i).Split(",")
                            strSplit = strSplit(1).Split("(")
                            If strSplit.Length > 0 Then
                                strName = strSplit(0).Trim

                                'lvwItem.SubItems.Add(strSplit(1).Replace("(#", "").Replace(")", "").Trim) ' SKU                                
                                bAdress = True
                            End If

                        ElseIf strLines(i).IndexOf("#") > -1 Then

                            strSplit = strLines(i).Split(" ")
                            If Not strSplit(0) = "  #" Then
                                strID = strSplit(0).Replace("#", "").Trim
                            End If
 
                        End If


                    Next

                    lvwItem.SubItems.Add(strName) ' ID 
                    lvwItem.SubItems.Add("") ' Auktionservice 
                    lvwItem.SubItems.Add("") ' Auktionservice 
                    lvwItem.SubItems.Add("") ' Auktionservice 
                    lvwItem.SubItems.Add(strKommentar) ' Auktionservice 
                    lvwItem.SubItems.Add(strID) ' Auktionservice 
                    lvwItem.SubItems.Add("") ' PLZ + Ort 
                    lvwItem.SubItems.Add("") ' Land


                    If bAdress = False Then
                        lvwItem.SubItems.Add("") ' Artikel
                        lvwItem.SubItems.Add("") ' Artikel-SKU
                        lvwItem.SubItems.Add("") ' Nickname
                        lvwItem.SubItems.Add("") ' Preis
                    End If


                    lvwItem.SubItems.Add("") ' YABE ID 
                    lvwItem.SubItems.Add("") ' Delcampe USER ID 
                    lvwItem.SubItems.Add("") '# Muttersprache
                    lvwItem.SubItems.Add("") '# Liste der Sprachen

                    lvwItem.SubItems.Add("bezahlt") '# Plattformmodus

                    '###################################################
                    '# >> Delcampe Verkauf 
                    '###################################################
                Case enumPlattformModus.verkauft
                    Dim strLand As String = ""

                    For i = 0 To strLines.Length - 1

                        '# Suche nach Adresse 
                        If (strLines(i).IndexOf("Straße:") > -1 Or strLines(i).IndexOf("Adresse : ") > -1 Or strLines(i).IndexOf("Telephone:") > -1) And strLines(i).IndexOf("http://www.delcampe.de") = -1 Then

                            lvwItem.SubItems.Add(strLines(i + 1).Trim) ' Name 


                            If strLines(i + 2).IndexOf("< br />") > 0 Then

                                Dim strTmpSplit() As String = strLines(i + 2).Split("< br />")
                                bLinesMinus = True
                                If strTmpSplit.Length > 0 Then
                                    lvwItem.SubItems.Add(strTmpSplit(0)) ' Straße 
                                End If
                                bLinesMinus = False
                                strTmpSplit(1) = strTmpSplit(1).Replace("br />", "")
                                Dim strPLZ_CITY() As String = strTmpSplit(1).Trim.Split(" ")


                                For iLoop = 0 To strPLZ_CITY.Length - 1
                                    If strPLZ_CITY(iLoop).IndexOf("-") >= 0 Or bIN = True Then

                                        If bIN = True Then
                                            strPLZ &= " " & strPLZ_CITY(iLoop)
                                        Else
                                            strPLZ &= strPLZ_CITY(iLoop)
                                        End If

                                        If iLoop > 0 Then
                                            bIN = True
                                        End If


                                    End If

                                Next

                                strCity = strTmpSplit(1).Replace(" br />", "")
                                If Not strPLZ = "" Then
                                    strCity = strCity.Replace(strPLZ, "").Trim
                                End If
                            Else
                                lvwItem.SubItems.Add(strLines(i + 2).Trim) ' Straße 
                                bLinesMinus = False
                                Dim strPLZ_CITY() As String = strLines(i + 3).Trim.Split(" ")


                                For iLoop = 0 To strPLZ_CITY.Length - 1
                                    If strPLZ_CITY(iLoop).IndexOf("-") >= 0 Or bIN = True Then

                                        If bIN = True Then
                                            strPLZ &= " " & strPLZ_CITY(iLoop)
                                        Else
                                            strPLZ &= strPLZ_CITY(iLoop)
                                        End If

                                        If iLoop > 0 Then
                                            bIN = True
                                        End If


                                    End If

                                Next

                                strCity = strLines(i + 3).Trim
                                If Not strPLZ = "" Then
                                    strCity = strCity.Replace(strPLZ, "").Trim
                                End If

                                'If strPLZ_CITY.Length = 1 Then
                                '    strLänderkennung = ""
                                '    strPLZStadt = strPLZ_CITY(0).Split(" ")
                                'Else
                                '    strLänderkennung = strPLZ_CITY(0)
                                '    strPLZStadt = strPLZ_CITY(1).Split(" ")
                                'End If

                        End If

                            'Dim strPLZ_CITY() As String = strLines(i + 3).Trim.Split(" ")
                            'Dim iLoop As Integer = 0
                            'Dim strCity As String = ""
                            'Dim strPLZ As String = ""
                            'Dim bIN As Boolean = False
                            'For iLoop = 0 To strPLZ_CITY.Length - 1
                            '    If strPLZ_CITY(iLoop).IndexOf("-") >= 0 Or bIN = True Then

                            '        If bIN = True Then
                            '            strPLZ &= " " & strPLZ_CITY(iLoop)
                            '        Else
                            '            strPLZ &= strPLZ_CITY(iLoop)
                            '        End If

                            '        If iLoop > 0 Then
                            '            bIN = True
                            '        End If


                            '    End If

                            'Next

                            'strCity = strLines(i + 3).Trim
                            'If Not strPLZ = "" Then
                            '    strCity = strCity.Replace(strPLZ, "").Trim
                            'End If


                            lvwItem.SubItems.Add(strCity) ' Ort 
                            lvwItem.SubItems.Add(strPLZ)
                            If bLinesMinus = True Then
                                strLand = strLines(i + 3).Trim
                            Else
                                strLand = strLines(i + 4).Trim
                            End If

                            'If strLänderkennung.Length = 0 Then
                            '    lvwItem.SubItems.Add(strPLZStadt) ' PLZ Land
                            'Else
                            '    lvwItem.SubItems.Add(strLänderkennung & "-" & strPLZStadt(0)) ' PLZ Land
                            'End If

                            bAdress = True
                        End If

                        '# Titel 
                        If strLines(i).IndexOf("Titel:") > -1 Then
                            Dim iTemp As Integer = 0

                            For iTemp = i To strLines.Length - 1

                                If Not strLines(iTemp).IndexOf("Preis:") > -1 Then
                                    strTitle &= strLines(iTemp).Replace("Titel:", "").Trim ' Name 
                                Else
                                    Dim str() As String = strLines(iTemp).Split(" ")
                                    strPreis = str(5).Trim
                                    Exit For
                                End If

                            Next
                        End If

                        If strLines(i).IndexOf("Titel :") > -1 Then
                            Dim iTemp As Integer = 0

                            For iTemp = i To strLines.Length - 1

                                If Not strLines(iTemp).IndexOf("Referenz:") > -1 Then
                                    strTitle &= strLines(iTemp).Replace("Titel :", "").Trim ' Name 

                                Else
                                    strReferenzNr = strLines(iTemp).Replace("Referenz: ", "").Trim

                                    If My.Settings.yabe_delcampek_auction_end = True Then
                                        Dim strSplit_ref() As String = strReferenzNr.Split("-")

                                        If strSplit_ref(1) = "Deutsch" Then
                                            strReferenzNr_del = strSplit_ref(0) & "-" & "Englisch"
                                        ElseIf strSplit_ref(1) = "Englisch" Then
                                            strReferenzNr_del = strSplit_ref(0) & "-" & "Deutsch"
                                        End If

                                        Dim strPath As String = "http://api.bludau-media.de/delcampe/auction_end.php?ref_id=" & strReferenzNr_del

                                        'MsgBox(strReferenzNr_del)
                                        bAutoModus_Delcampe = True
                                        If getHTTPResponseMessage(strPath, mgetUpdaterMessage.setDelcampe_delete_auction, True) = True Then
                                            bAutoModus_Delcampe = False
                                        End If

                                    End If

                                    Dim str() As String = strLines(iTemp + 1).Split(" ")
                                    strPreis = str(2).Trim
                                    Exit For
                                End If

                            Next
                        End If

                        '# Artikel-ID
                        If strLines(i).IndexOf("#:") > -1 Then

                            If bItemID = False Then
                                strSKU &= strLines(i).Replace("#:", "").Trim ' Artikelid
                                bItemID = True
                            Else
                                strDelcampeID = strLines(i).Replace("#:", "").Trim ' Artikelid
                            End If

                        End If

                        If strLines(i).IndexOf("# :") > -1 Then

                            If bItemID = False Then
                                strSKU &= strLines(i).Replace("# :", "").Trim ' Artikelid
                                bItemID = True
                            Else
                                strDelcampeID = strLines(i).Replace("# :", "").Trim ' Artikelid
                            End If

                        End If


                        '# Nickname
                        If strLines(i).IndexOf("Login:") > -1 Then
                            strDelCampeNickname &= strLines(i).Replace("Login:", "").Trim ' Artikelid
                            Dim str() As String = strDelCampeNickname.Split(" [")
                            strDelCampeNickname = str(0)
                        End If
                        If strLines(i).IndexOf("Login :") > -1 Then
                            strDelCampeNickname &= strLines(i).Replace("Login :", "").Trim ' Artikelid
                            Dim str() As String = strDelCampeNickname.Split(" [")
                            strDelCampeNickname = str(0)
                        End If
                        '#--------------------------
                        If strLines(i).IndexOf("Persönliche Referenz:") > -1 Then
                            strReferenzNr &= strLines(i).Replace("Persönliche Referenz:", "").Trim ' Artikelid

                            'If My.Settings.yabe_delcampe_auction_end = True Then
                            '    Dim strSplit_ref() As String = strReferenzNr.Split("-")

                            '    If strSplit_ref(1) = "Deutsch" Then
                            '        strReferenzNr_del = strSplit_ref(0) & "-" & "Englisch"
                            '    ElseIf strSplit_ref(1) = "Englisch" Then
                            '        strReferenzNr_del = strSplit_ref(0) & "-" & "Deutsch"
                            '    End If

                            '    Dim strPath As String = "http://api.bludau-media.de/delcampe/auction_end.php?ref_id=" & strReferenzNr_del

                            '    MsgBox(strReferenzNr_del)

                            '    If getHTTPResponseMessage(strPath, mgetUpdaterMessage.setDelcampe_delete_auction, True) = True Then

                            '    End If

                            'End If

                        End If


                        '#-----------------------------------------
                        If strLines(i).IndexOf("Sprachen:") > -1 Then


                            strSplit = strLines(i).Replace("Sprachen:", "").Trim.Split("(vorgezogene Sprache:")

                            strSprache_mutter = strSplit(1).Replace("vorgezogene Sprache:", "").Replace(")", "").Trim
                            strSprache_liste = strSplit(0).Trim



                        End If
                        If strLines(i).IndexOf("Sprachen :") > -1 Then

                            ' Dim iTemp As Integer = 0

                            '  For iTemp = i To strLines.Length - 1

                            strSplit = strLines(i).Replace("Sprachen :", "").Trim.Split("(vorgezogene Sprache:")

                            strSprache_mutter = strSplit(1).Replace("vorgezogene Sprache: ", "").Replace(")", "").Trim
                            strSprache_liste = strSplit(0).Trim

                            'If strLines(iTemp).IndexOf(")") > -1 Then
                            '    strSprache_mutter &= strLines(iTemp).Replace(")", "").Trim
                            '    Exit For
                            'Else
                            '    strSplit = strLines(iTemp).Replace("Sprachen:", "").Trim.Split("(Muttersprache:")  ' Sprachliste
                            '    strSprache_liste = strSplit(0)

                            '    If strSplit.Length > 1 Then
                            '        strSprache_mutter = strSplit(1).Replace("Muttersprache:", "")
                            '    End If

                            'End If

                            'Next


                        End If

                    Next i

                    If bAdress = False Then
                        lvwItem.SubItems.Add("") ' Name 
                        lvwItem.SubItems.Add("") ' Straße 
                        lvwItem.SubItems.Add("") ' PLZ + Ort 
                        lvwItem.SubItems.Add("") ' Land
                    End If

                    lvwItem.SubItems.Add(strTitle) ' Artikel
                    lvwItem.SubItems.Add(strSKU) ' Artikel-SKU
                    lvwItem.SubItems.Add(strDelCampeNickname) ' Nickname
                    lvwItem.SubItems.Add(strPreis) ' Preis
                    lvwItem.SubItems.Add(strReferenzNr) ' YABE ID 
                    lvwItem.SubItems.Add(strDelcampeID) ' Delcampe USER ID 
                    lvwItem.SubItems.Add(strSprache_mutter) '# Muttersprache
                    lvwItem.SubItems.Add(strSprache_liste) '# Liste der Sprachen

                    lvwItem.SubItems.Add("verkauft") '# Plattformmodus
                    lvwItem.SubItems.Add(strLand)
            End Select

       


            ' 6 -- > 7
            '  MsgBox(lvwItem.SubItems.Count)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    '######################################################################
    '# >> eMails abrufen 
    '######################################################################
    Public Function getOutlook_emails() As Boolean
        Try


        Catch ex As Exception
            Call debug_message(ex, "getOutlook_emails")
            Return False
        End Try
    End Function
End Class
