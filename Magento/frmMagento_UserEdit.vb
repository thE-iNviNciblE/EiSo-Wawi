Imports YabE.net.cubss
Public Class frmMagento_UserEdit
    Public lvwData As ListViewItem
    Private mc As New clsMagentoAPI
    Public bNew As Boolean = False
    Private Sub frmMagento_UserEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '# Laden der Daten vom selektierten Benutzer 
        Try
            txtAddVorname.Text = lvwData.SubItems(1).Text
            txtAddNachname.Text = lvwData.SubItems(9).Text
            txtAddStrasse.Text = lvwData.SubItems(5).Text
            txtAddOrt.Text = lvwData.SubItems(7).Text
            txtAddPLZ.Text = lvwData.SubItems(6).Text
            'txtAddLand.Text = lvwData.SubItems(3).Text
            txtAddTelefon.Text = lvwData.SubItems(10).Text
            txtAddEmail.Text = lvwData.SubItems(2).Text
            lblAdressID.Text = lvwData.SubItems(12).Text
            lblUserID.Text = lvwData.Text
        Catch ex As Exception

        End Try



        Application.DoEvents()
        'mc.getCountryList(cmbLand)
        cmbLand.Items.Add("DE")
        cmbLand.SelectedIndex = 0

        'mc.getRegionList(cmbRegion, cmbLand.Text)
        cmbRegion.Items.Add("Niedersachsen")
        cmbRegion.SelectedIndex = 0

    End Sub

    Private Sub btnSaveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUser.Click

        If mc.getLogin() = True Then


            If bNew = False Then
                '# Profil Daten aktualisieren 
                Dim data As New customerCustomerEntityToCreate
                data.firstname = txtAddVorname.Text
                data.lastname = txtAddNachname.Text
                data.email = txtAddEmail.Text
                mc.setCustomerData(lblUserID.Text, data)

                '# AdressDaten aktualisieren 
                Dim adressData As New customerAddressEntityCreate
                adressData.firstname = txtAddVorname.Text
                adressData.lastname = txtAddNachname.Text
                adressData.city = txtAddOrt.Text
                adressData.postcode = txtAddPLZ.Text
                'adressData.street = txtAddStrasse.Text

                mc.setCustomerAdressData(lblAdressID.Text, adressData)

            Else
                '# Profil Daten aktualisieren 
                Dim data As New customerCustomerEntityToCreate
                data.firstname = txtAddVorname.Text
                data.lastname = txtAddNachname.Text
                data.email = txtAddEmail.Text

                Dim customerID = mc.setCustomerData_new(data)
                lblUserID.Text = customerID

                '# AdressDaten aktualisieren 
                Dim adressData As New customerAddressEntityCreate
                adressData.firstname = txtAddVorname.Text
                adressData.lastname = txtAddNachname.Text
                adressData.city = txtAddOrt.Text
                adressData.postcode = txtAddPLZ.Text
                adressData.is_default_billing = True
                adressData.is_default_shipping = True
                adressData.telephone = txtAddTelefon.Text
                adressData.country_id = cmbLand.Text
                adressData.region = cmbRegion.Text
                'adressData.street = txtAddStrasse.Text


                lblAdressID.Text = mc.setCustomerAdressData_new(customerID, adressData)
            End If

        End If

    End Sub
End Class