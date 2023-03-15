Imports System.IO
Imports Microsoft.VisualBasic.FileIO


Public Class clsImporter
    Public strFile As String
    Public strDelimiter As String = ";"
    Public pgrBar As ProgressBar

    Enum Importmodus
        ebay = 0
        delcampe = 1
    End Enum

    '######################################################################
    '# >> CSV Parser - Selektor 
    '######################################################################
    Public Function getImportFile(ByRef lvw As ListView, ByVal modus As Importmodus) As Boolean

        '# UMWANDELN IN UTF8 
        Dim strData As String = My.Computer.FileSystem.ReadAllText(strFile)
        Dim strLines() As String = strData.Split(vbCrLf)

        lvw.BeginUpdate()
        pgrBar.Maximum = strLines.Length
        pgrBar.Value = 0

        '  Dim sw As New StreamWriter(strFile, False, System.Text.Encoding.ASCII)
        '  sw.Write(strData)
        '  sw.Close()


        lvw.Items.Clear()
        pgrBar.Visible = True
        getCSVParser(lvw, modus)
        pgrBar.Visible = False
        lvw.EndUpdate()

    End Function

    Public Function getDelcampeCSV(ByRef lvw As ListView, ByVal strROW() As String) As Boolean

        '# Neues Listview Objekt 
        Dim lvwItem As New ListViewItem

        '# LISTVIEW AUFBAU 
        '# Beschreibung
        '# Preis
        '# Bild
        '# Status
        If strROW.Length > 1 And Not strROW(0) = "country" Then
            lvwItem.Text = strROW(8)
            lvwItem.SubItems.Add(strROW(12))
            lvwItem.SubItems.Add(strROW(10))
            lvwItem.SubItems.Add("Importiert")
            lvw.Items.Add(lvwItem)
            lvw.Items(lvw.Items.Count - 1).EnsureVisible()
            Application.DoEvents()
        End If

        Return True
    End Function

    '###################################################################
    '# >> Turbo Lister Importer 
    '###################################################################
    Public Function geteBayCSV(ByRef lvw As ListView, ByVal strROW() As String) As Boolean

        '# Neues Listview Objekt 
        Dim lvwItem As New ListViewItem

        '# LISTVIEW AUFBAU 
        '# Beschreibung
        '# Preis
        '# Bild
        '# Status
        If strROW.Length > 1 And Not strROW(0) = "Site" Then
            lvwItem.Text = strROW(3)
            lvwItem.SubItems.Add(strROW(15))

            '# Bild Holen
            '# >> Externe Bilder verwendet 
            If strROW(11) = "~" Then
                lvwItem.SubItems.Add(clseBayAPI.geteBayPicture(strROW(6), clseBayAPI.strBildModus.yabe))
            Else
                '# Bild gefunden 
                lvwItem.SubItems.Add(strROW(11))
            End If

            lvwItem.SubItems.Add("Importiert")
            lvw.Items.Add(lvwItem)
            lvw.Items(lvw.Items.Count - 1).EnsureVisible()
            Application.DoEvents()
        End If




        Return True
    End Function

    '######################################################################
    '# >> CSV Parser 
    '######################################################################
    Private Function getCSVParser(ByRef lvw As ListView, ByVal modus As Importmodus) As Boolean


        Using MyReader As New TextFieldParser(strFile, System.Text.Encoding.Default, True)

            MyReader.TextFieldType = FieldType.Delimited
            MyReader.Delimiters = New String() {strDelimiter}
            Dim currentRow As String()
            Dim iCount As Integer = 0
            'Loop through all of the fields in the file. 
            'If any lines are corrupt, report an error and continue parsing. 
            While Not MyReader.EndOfData
                Try
                    If Not iCount = 0 Then
                        currentRow = MyReader.ReadFields()
                        Select Case modus
                            Case Importmodus.ebay
                                Call geteBayCSV(lvw, currentRow)
                            Case Importmodus.delcampe
                                Call getDelcampeCSV(lvw, currentRow)
                        End Select

                    End If
                    ' Include code here to handle the row.
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & _
                    " is invalid.  Skipping")
                End Try
                iCount += 1
                Try
                    pgrBar.Value = iCount
                Catch ex As Exception

                End Try

            End While
        End Using


    End Function

End Class
