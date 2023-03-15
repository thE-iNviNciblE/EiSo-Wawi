Public Class Lexware_finance_office
    Public Function setExport_artikel(ByVal sLine As String, ByVal lvw As ListViewItem) As String

        Dim QC As String = ";"
        Dim Q As String = ""
        Dim iCol_beschreibung As Integer = 4
        Dim iCol_preis As Integer = 5

        sLine = Q + lvw.SubItems(0).Text + QC ' Artikelnummer
        sLine &= Q & lvw.SubItems(iCol_beschreibung).Text & QC ' Bezeichnung
        sLine &= Q + "Stück" + QC ' Einheit
        sLine &= Q + "0,0" + QC ' Gewicht
        sLine &= Q + lvw.SubItems(0).Text + QC ' Matchcode
        sLine &= Q + lvw.SubItems(iCol_preis).Text + QC ' Preis pro Anzahl

        Return sLine
    End Function

    Public Function setExport_kunden(ByVal sLine As String, ByVal strEmail As String) As String

        Dim QC As String = ";"
        Dim Q As String = ""
        Dim strArry() As String

        My.Settings.yabe_finance_office_kundennummer += 1
        My.Settings.Save()
        sLine = Q & My.Settings.yabe_finance_office_kundennummer & QC ' Kontonummer

        '0 - Name
        '1 - Straße
        '2 - PLz  + ORT
        '3 - Land
        '4 - Land Code
        '5 - PLZ
        '6 - Stadt
        strArry = clsDatenbank_modul.getEiSoIsCostumerAdressByEmailOrID(strEmail)
        '"Kontonummer";"Kontobezeichnung";"Kundennummer";"Anrede";"Firma";"Name";"Vorname";"Zusatz";"Land";"Straße";"Postleitzahl";"Ort";"Ansprechpartner";"Telefon1";"Telefon2";"Telefax";"E-Mail";"Bankleitzahl";"Bankkonto";"BIC";"IBAN";"Bankbezeichnung";"Zahlungsziel";"Skonto %";"Skonto Ziel";"Einzugsermächtigung"
        sLine &= Q + strArry(0) + QC ' Kontobezeichnung (Name / Firma)
        sLine &= Q & My.Settings.yabe_finance_office_kundennummer & QC ' Kundennummer
        sLine &= Q + "Herr" + QC ' Anrede
        sLine &= Q + "" + QC ' Firma
        Dim Name() As String = strArry(0).Split(" ")
        sLine &= Q + Name(1) + QC ' Name
        sLine &= Q + Name(0) + QC ' Vorname
        sLine &= Q + "" + QC ' Zusatz
        sLine &= Q + strArry(3) + QC ' Land
        sLine &= Q + strArry(1) + QC ' Straße
        sLine &= Q + strArry(5) + QC ' PLZ
        sLine &= Q + strArry(6) + QC ' Ort
        sLine &= Q + "" + QC ' Ansprechpartner
        sLine &= Q + "" + QC ' Telefon1
        sLine &= Q + "" + QC ' Telefon2
        sLine &= Q + "" + QC ' Telefax
        sLine &= Q + strEmail + QC ' Email
        sLine &= Q + "" + QC ' BLZ
        sLine &= Q + "" + QC ' Bankonto
        sLine &= Q + "" + QC ' BIC
        sLine &= Q + "" + QC ' IBAN
        sLine &= Q + "" + QC ' Bankbezeichnung
        sLine &= Q + "" + QC ' Zahlungsziel
        sLine &= Q + "" + QC ' Skonto
        sLine &= Q + "" + QC ' Ziel
        sLine &= Q + "" + QC ' Einzugsermächtigung

        Return sLine
    End Function
End Class
