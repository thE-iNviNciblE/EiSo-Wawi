Public Class frmYABE_Kundenverwaltung

    Public lvwDataInput As ListView
    Public bInsert As Boolean = False
    Public strLoadEmail As String = ""
    Public bNoNext As Boolean = False

    '# Daten laden vom Listview 
    Private Function getFormData() As Boolean
        Dim strUserData As ArrayList
        Try

            'Select Case lvwDataInput.Name
            '    Case "lvwKunden"
            '        If lvwDataInput.SelectedItems.Count > 0 Then
            '            txtName.Text = lvwDataInput.SelectedItems(0).Text
            '            txtStraße.Text = lvwDataInput.SelectedItems(0).SubItems(3).Text
            '            txtPLZ.Text = lvwDataInput.SelectedItems(0).SubItems(4).Text
            '            txtStadt.Text = lvwDataInput.SelectedItems(0).SubItems(5).Text
            '            txtLand.Text = lvwDataInput.SelectedItems(0).SubItems(6).Text
            '            txtEmail.Text = lvwDataInput.SelectedItems(0).SubItems(2).Text
            '            strLoadEmail = txtEmail.Text '# Orginal Email speichern 

            '            TxtUserId.Text = lvwDataInput.SelectedItems(0).SubItems(1).Text ' nicht gespeichert 
            '            TextBox1.Text = lvwDataInput.SelectedItems(0).SubItems(10).Text ' nicht gespeichert 

            '        End If

            '    Case Else

            '# Kundendaten abrufen 
            If strLoadEmail.Length > 0 Then
                strUserData = clsDatenbank_modul.getYABEUserData(strLoadEmail)
                ' Benutzerdaten gefunden
                If strUserData.Count <> 0 Then
                    '# 
                    txtName.Text = strUserData.Item(0).ToString
                    txtStraße.Text = strUserData.Item(1).ToString
                    txtPLZ.Text = strUserData.Item(3).ToString
                    txtStadt.Text = strUserData.Item(2).ToString
                    txtLand.Text = strUserData.Item(5).ToString
                    TextBox1.Text = strUserData.Item(4).ToString
                    TxtUserId.Text = strUserData.Item(6).ToString

                    If strUserData.Item(6).ToString.Length > 0 Then
                        chkKunde_ebay.Checked = True
                    Else
                        chkKunde_ebay.Checked = False
                    End If

                    txtEmail.Text = strUserData.Item(10).ToString

                    If strUserData.Item(11).ToString = "Y" Then
                        chkKunde_Shop.Checked = True
                    Else
                        chkKunde_Shop.Checked = False
                    End If

                    If strUserData.Item(12).ToString.Length > 0 Then
                        chkKundeDelcampe.Checked = True
                    Else
                        chkKundeDelcampe.Checked = False
                    End If
                    txtShopUserName.Text = strUserData.Item(13)
                    txtShopPasswort.Text = strUserData.Item(14)

                Else
                    MsgBox("Probleme beim Empfangen der Benutzerdaten für '" & strLoadEmail & "'", MsgBoxStyle.Information)
                End If '# Gibt es Userdaten 

            End If '# Gibt es eine Email 

            '  End Select

        Catch ex As Exception
            'Call debug_message(ex,"getFormData")
            Return False
        End Try
    End Function

    Private Function setLookGUI(ByVal bModus As Boolean) As Boolean

        btnBack.Enabled = bModus
        btnKundenSave.Enabled = bModus
        btnNeu.Enabled = bModus
        btnVor.Enabled = bModus
        txtName.Enabled = bModus
        txtStraße.Enabled = bModus
        txtPLZ.Enabled = bModus
        txtLand.Enabled = bModus
        TxtUserId.Enabled = bModus
        TextBox1.Enabled = bModus
        cmbSprachenVorlage.Enabled = bModus

    End Function

    Private Sub btnKundenSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKundenSave.Click
        Dim aryList As New ArrayList
        Dim aryListProfile As New ArrayList

        Call setLookGUI(False)

        '# Nur wenn Email vorhanden 
        If txtEmail.Text.Length > 0 Then

            '# Gültige Email vorhanden
            If txtEmail.Text.Contains("@") = False Then
                MsgBox("Die eingegebene Emailadresse '" & txtEmail.Text & "' ist nicht gültig", MsgBoxStyle.Critical)
                Call setLookGUI(False)
                Application.DoEvents()
                txtEmail.Focus()
                Exit Sub
            End If

            aryList.Add(txtName.Text) ' Name
            aryList.Add(txtStraße.Text) ' Straße


            aryList.Add(txtStadt.Text) ' Ort
            aryList.Add(txtPLZ.Text) ' PLZ

            aryList.Add(txtLand.Text) ' Land
            aryList.Add(TxtUserId.Text) ' Delcampe ID


            aryListProfile.Add(txtShopUserName.Text) ' Shop Username
            aryListProfile.Add(txtShopPasswort.Text) ' Shop Passwort

            '            If clsDatenbank_modul.setYABE_Kunde_ProfileUpdate(txtEmail.Text, TxtUserId.Text, aryListProfile) = False Then
            'MessageBox.Show("Fehler beim Profilupdate!", "Update Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

            '# Profildaten speichern
            clsDatenbank_modul.setCustomer_muttersprache(txtEmail.Text, cmbSprachenVorlage.Text)

            '# Email Adresse wurde nicht geändert 
            If strLoadEmail = txtEmail.Text Then
                clsDatenbank_modul.setYABE_Kunden_adress_update(aryList, txtEmail.Text, bInsert)
            Else
                If MsgBox("Möchten Sie wirklich die Emailadresse des Kunden verändern?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    '# Änderung der Email Adresse 
                    If clsDatenbank_modul.setYABE_Kunden_email_updater(txtEmail.Text, strLoadEmail) Then
                        clsDatenbank_modul.setYABE_Kunden_adress_update(aryList, txtEmail.Text, bInsert)
                    Else
                        MsgBox("Es gab Probleme beim ändern der Emailadresse!", MsgBoxStyle.Exclamation, "ERR: 001 - Email Adresse ändern")
                    End If

                End If

            End If

            'Refresh im Hintergrund 
            Call frmMain.frmManage.getLvwData(lvwDataInput)

        End If

        Call setLookGUI(True)
        Me.Close()

    End Sub

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click

        btnNeu.Enabled = False
        txtEmail.Enabled = True
        txtEmail.Text = ""
        txtLand.Text = ""
        txtName.Text = ""
        txtPLZ.Text = ""
        txtStraße.Text = ""
        TxtUserId.Text = ""
        TextBox1.Text = ""
        bInsert = True

    End Sub

    Private Sub frmYABEKunden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '# Daten Laden
        Call getFormData()

        Call clsDatenbank_modul.getComboSprachen(cmbSprachenVorlage)

        Dim strSprache As String = clsDatenbank_modul.getCustomer_sprache(txtEmail.Text)

        If strSprache = "Deutsch" Then
            cmbSprachenVorlage.SelectedIndex = 0
        ElseIf strSprache = "Englisch" Then
            cmbSprachenVorlage.SelectedIndex = 1
        ElseIf strSprache = "Französisch" Then
            cmbSprachenVorlage.SelectedIndex = 2
        ElseIf strSprache = "Spanisch" Then
            cmbSprachenVorlage.SelectedIndex = 3
        ElseIf strSprache = "Russisch" Then
            cmbSprachenVorlage.SelectedIndex = 4
        ElseIf strSprache = "Chinesisch" Then
            cmbSprachenVorlage.SelectedIndex = 5
        End If

        '# Neuen Kunden anlegen
        If bInsert = True Then
            btnNeu.PerformClick()
            bNoNext = True ' Buttons vor und zurück wegmachen
        End If

        '# Kein Blättern anzeigen 
        If bNoNext = True Then
            btnBack.Visible = False
            btnVor.Visible = False
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then

            btnNeu.Enabled = True
            txtEmail.Enabled = False
            bInsert = False

            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False
            iAnzahl -= 1
            btnVor.Enabled = True

            If iAnzahl = 0 Then
                btnBack.Enabled = False
            Else
                btnBack.Enabled = True
            End If

            lvwDataInput.Items(iAnzahl).Selected = True
            lvwDataInput.Items(iAnzahl).EnsureVisible()

            Call getFormData()
            Dim strSprache As String = clsDatenbank_modul.getCustomer_sprache(txtEmail.Text)

            If strSprache = "Deutsch" Then
                cmbSprachenVorlage.SelectedIndex = 0
            ElseIf strSprache = "Englisch" Then
                cmbSprachenVorlage.SelectedIndex = 1
            ElseIf strSprache = "Französisch" Then
                cmbSprachenVorlage.SelectedIndex = 2
            ElseIf strSprache = "Spanisch" Then
                cmbSprachenVorlage.SelectedIndex = 3
            ElseIf strSprache = "Russisch" Then
                cmbSprachenVorlage.SelectedIndex = 4
            ElseIf strSprache = "Chinesisch" Then
                cmbSprachenVorlage.SelectedIndex = 5
            End If
        End If

    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then

            btnNeu.Enabled = True
            txtEmail.Enabled = False
            bInsert = False

            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False

            iAnzahl += 1
            btnVor.Enabled = True

            If iAnzahl = lvwDataInput.Items.Count Then
                btnVor.Enabled = False
            Else
                btnVor.Enabled = True
            End If

            lvwDataInput.Items(iAnzahl).Selected = True
            lvwDataInput.Items(iAnzahl).EnsureVisible()

            Call getFormData()

            Dim strSprache As String = clsDatenbank_modul.getCustomer_sprache(txtEmail.Text)

            If strSprache = "Deutsch" Then
                cmbSprachenVorlage.SelectedIndex = 0
            ElseIf strSprache = "Englisch" Then
                cmbSprachenVorlage.SelectedIndex = 1
            ElseIf strSprache = "Französisch" Then
                cmbSprachenVorlage.SelectedIndex = 2
            ElseIf strSprache = "Spanisch" Then
                cmbSprachenVorlage.SelectedIndex = 3
            ElseIf strSprache = "Russisch" Then
                cmbSprachenVorlage.SelectedIndex = 4
            ElseIf strSprache = "Chinesisch" Then
                cmbSprachenVorlage.SelectedIndex = 5
            End If
        End If

    End Sub

    Private Sub frmYABEKunden_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

        If Not txtEmail.Text = strLoadEmail Then
            txtEmail.BackColor = Color.Coral
        Else
            txtEmail.BackColor = Color.WhiteSmoke
        End If

    End Sub
End Class