Imports Microsoft.Office.Interop

Public Class clsExport
    '##############################################
    '# >> Export der Adress-Daten zu Excell 
    '##############################################
    'Public Function expAdress2Excel(ByVal strFilename As String) As Boolean
    '    Dim myExcel As New Excel.Application
    '    Dim myWorkBooks As Microsoft.Office.Interop.Excel.Workbooks
    '    Dim myWorkBook As Excel.Workbook
    '    Dim myWorkSheet As Excel.Worksheet
    '    Dim xlsFileName As String = strFilename
    '    Try

    '        'myExcel = New Excel.Application
    '        If myExcel Is Nothing Then
    '            MessageBox.Show("Kann Excell nicht laden")
    '            Exit Function
    '        End If

    '        myWorkBooks = myExcel.Workbooks

    '        'Öffnet eine Excel Datei 
    '        myWorkBook = myWorkBooks.Open(xlsFileName)

    '        'Holt das erste Excel Sheet 
    '        myWorkSheet = myWorkBook.Sheets.Item(1)

    '        'Löscht alle Inhalte der ersten Zeile 
    '        Dim myCell As Object = myWorkSheet.Range("A1", System.Reflection.Missing.Value)

    '        myCell.Value2 = "Hallo WELT"

    '        'Anzeigen des Excel Sheets
    '        myExcel.Visible = True

    '    Catch ex As Exception
    '        Call debug_message(ex, strQuery & vbCrLf & "expAdress2Excel")
    '        Return False
    '    End Try

    '    Return True
    'End Function

    '##############################################
    '# >> Export der Adress-Daten zu HTML 
    '##############################################
    Public Function ExpAdress2HTML(ByVal strFileName As String, ByVal strVon As String, ByVal strPlattform As String) As Boolean
        Dim strQuery As String = ""
        Dim dbReader As MySql.Data.MySqlClient.MySqlDataReader
        Dim strNewFile As String = ""
        Dim Insert As String = ""
        Dim iCount As Integer = 0
        Dim str() As String
        Dim strDatumSelect As String
        Dim strPlattform_query As String = ""
        Try
            Dim strData As String = My.Computer.FileSystem.ReadAllText(strFileName)

            Select Case strPlattform
                Case "eBay"
                    strPlattform_query = " AND Type='" & strPlattform & "'"
                Case "Delcampe"
                    strPlattform_query = " AND Type='" & strPlattform & "'"
                Case "CMS"
                    strPlattform_query = " AND Type='" & strPlattform & "'"
                Case Else
                    If strPlattform.Length > 0 Then
                        strPlattform_query = " AND Type='" & strPlattform & "'"
                    End If

            End Select

            str = strVon.Split(" ")
            str = str(0).Split(".")
            strDatumSelect = str(2) & "-" & str(1) & "-" & str(0) & " 00:00:00"

            '# Artikel welche noch nicht in der Galerie sind 
            clsDatenbank_modul.dbConnect.Close()
            clsDatenbank_modul.dbConnect.Open()
            strQuery = "SELECT * FROM yabe_personals_adress  LEFT JOIN yabe_personals_profile ON yabe_personals_profile.ID = yabe_personals_adress.profil_id LEFT JOIN yabe_order_list ON yabe_order_list.yabe_personals_id = yabe_personals_profile.ID  WHERE yabe_order_list.created_at > '" & strDatumSelect & "' " & strPlattform_query & " ORDER BY name"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(strQuery, clsDatenbank_modul.dbConnect)
            dbReader = command.ExecuteReader()

            '# Gibt es einen Treffer
            If dbReader.HasRows = True Then

                While Not dbReader.Read() = False

                    iCount += 1
                    Select Case iCount
                        Case 1
                            Insert &= "<tr>"
                            Insert &= "<td><strong>"
                            Insert &= dbReader("name").ToString & "<br>"
                            Insert &= dbReader("street").ToString & "<br>"
                            Insert &= dbReader("zipcode").ToString & " " & dbReader("city").ToString & "<br>"
                            Insert &= dbReader("country").ToString & "<br>"
                            Insert &= "</strong></td>"
                        Case 2
                            Insert &= "<td><strong>"
                            Insert &= dbReader("name").ToString & "<br>"
                            Insert &= dbReader("street").ToString & "<br>"
                            Insert &= dbReader("zipcode").ToString & " " & dbReader("city").ToString & "<br>"
                            Insert &= dbReader("country").ToString & "<br>"
                            Insert &= "</strong></td></tr>"

                            iCount = 0
                    End Select

                End While

                '# Ersetzen der Daten aus der Vorlage 
                strData = strData.Replace("<###REPLACE###>", Insert)

                '# Zurückschreiben der Daten 
                strNewFile = Application.StartupPath & "\export\" & Date.Today & ".html"
                My.Computer.FileSystem.WriteAllText(strNewFile, strData, False)

                Dim frmWebbowser As New frmYABE_WebBrowser
                frmWebbowser.strURL = strNewFile
                frmWebbowser.Show()


                'Dim ExterneAnwendung As New System.Diagnostics.Process()
                'ExterneAnwendung.StartInfo.FileName = strNewFile
                'ExterneAnwendung.Start()

            Else
                MsgBox("Es gibt keine Kundendaten zum ausdrucken", MsgBoxStyle.Information, "EiSo Adressen drucken")

            End If


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "ExpAdress2HTML")
            Return False
        End Try

        Return True
    End Function

End Class
