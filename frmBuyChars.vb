Public Class frmBuyChars
    Dim dblMillionChars As Double = 0
    Dim dblendsumme As Double = 0
    Private Sub frmBuyChars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFirma.Text = My.Settings.anmeldung_firma
        txtVorname.Text = My.Settings.anmeldung_vorname
        txtNachname.Text = My.Settings.anmeldung_nachname
        txtStraße.Text = My.Settings.anmeldung_strasse
        txtPLZ.Text = My.Settings.anmeldung_postleitzahl
        txtStadt.Text = My.Settings.anmeldung_stadt
        txtEmail.Text = My.Settings.anmeldung_email
        txtHandy.Text = My.Settings.anmeldung_handy
        txtTelefon.Text = My.Settings.anmeldung_telefon
        txtLand.Text = My.Settings.anmeldung_land
    End Sub

    Private Sub txtBuyCharsInMillion_TextChanged(sender As Object, e As EventArgs) Handles txtBuyCharsInMillion.TextChanged
        If IsNumeric(txtBuyCharsInMillion.Text) = False Then
            btnBestellen.Enabled = False
        Else
            btnBestellen.Enabled = True
            dblMillionChars = Convert.ToDouble(txtBuyCharsInMillion.Text)

            If dblMillionChars < 1 Then
                lblEndsumme.Text = (dblMillionChars * 60) & " EUR"
                dblendsumme = (dblMillionChars * 60)
            Else
                lblEndsumme.Text = (dblMillionChars * 40) & " EUR"
                dblendsumme = (dblMillionChars * 40)
            End If

        End If
    End Sub

    Private Sub btnBestellen_Click(sender As Object, e As EventArgs) Handles btnBestellen.Click
        If txtEmail.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie eine Emailadresse ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmail.Focus()
            Exit Sub
        End If

        If txtVorname.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie einen Vornamen ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVorname.Focus()
            Exit Sub
        End If
        If txtNachname.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie einen Nachnamen ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNachname.Focus()
            Exit Sub
        End If
        If txtLand.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie ein Land ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLand.Focus()
            Exit Sub
        End If
        If txtStraße.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie eine Straße ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStraße.Focus()
            Exit Sub
        End If
        If txtPLZ.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie eine Postleitzahl ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPLZ.Focus()
            Exit Sub
        End If
        If txtStadt.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie eine Stadt ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStadt.Focus()
            Exit Sub
        End If
        If txtTelefon.Text.Length = 0 Then
            MessageBox.Show("Bitte geben Sie eine Telefonnummer ein!", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTelefon.Focus()
            Exit Sub
        End If

        If chkAGB.Checked = False Then
            MessageBox.Show("Bitte AGB lesen und gegebenfalls akzeptieren", "Fehler bei der Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        btnBestellen.Enabled = False

        getHTTPResponseMessage("https://api.bludau-media.de/SafeSandy/jtl-translator-buy-chars.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&mio=" & System.Uri.EscapeDataString(dblMillionChars) & "&versionsnummer=" & System.Uri.EscapeDataString(strVersionsNummer) & "&endsumme=" & System.Uri.EscapeDataString(dblendsumme) & "&firma=" & System.Uri.EscapeDataString(txtFirma.Text) & "&vorname=" & System.Uri.EscapeDataString(txtVorname.Text) & "&nachname=" & System.Uri.EscapeDataString(txtNachname.Text) & "&strasse=" & System.Uri.EscapeDataString(txtStraße.Text) & "&plz=" & System.Uri.EscapeDataString(txtPLZ.Text) & "&stadt=" & System.Uri.EscapeDataString(txtStadt.Text) & "&land=" & System.Uri.EscapeDataString(txtLand.Text) & "&programID=2&email=" & System.Uri.EscapeDataString(txtEmail.Text) & "&telefon=" & System.Uri.EscapeDataString(txtTelefon.Text) & "&handy=" & System.Uri.EscapeDataString(txtHandy.Text), mgetUpdaterMessage.setBuyChars, True)

        MessageBox.Show("Ihre Bestellung wurde ausgeführt, Sie erhalten eine Bestätigung an Ihre Emailadresse " & txtEmail.Text)
        txtBuyCharsInMillion.Text = "0,0"
        btnBestellen.Enabled = True
    End Sub
End Class