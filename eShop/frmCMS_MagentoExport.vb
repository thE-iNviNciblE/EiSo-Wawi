Public Class frmCMS_MagentoExport
    Dim bLoading As Boolean = False
    Public aryAuktionData As New ArrayList
    Public bOK As Boolean = False

    Private Sub btnAbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrechen.Click

        Me.Close()
    End Sub

    '#####################################################
    '# >> Speichern der Daten für den CSV Export  
    '#####################################################
    Private Function setGUI2CSV() As Boolean
        Try
            '# 0 Storevie
            '# 1 Status
            '# 2 Sichtbarkeit
            '# 3 Steuerklasse
            '# 4 Menge
            '# 5 Shop Name 
            '# 6 Attributset
            aryAuktionData.Add(txtMagentoStoreview.Text)
            aryAuktionData.Add(txtMagentoStatus.Text)
            aryAuktionData.Add(txtSichtbarkeit.Text)
            aryAuktionData.Add(txtMagentoSteuerklasse.Text)
            aryAuktionData.Add(txtMenge.Text)
            aryAuktionData.Add(txtShopName.Text)
            aryAuktionData.Add(txtAttributset.Text)
        Catch ex As Exception

        End Try
    End Function

    Private Sub btnMagentoCSVExport_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagentoCSVExport_save.Click
        Call setGUI2CSV()
        bOK = True
        Me.Close()

    End Sub

    Private Sub frmCMS_MagentoExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bLoading = True
        txtMagentoStoreview.Text = My.Settings.yabe_gui_magento_export_storeview
        txtMagentoStatus.Text = My.Settings.yabe_gui_magento_export_status
        txtMagentoSteuerklasse.Text = My.Settings.yabe_gui_magento_export_steuerklasse
        txtSichtbarkeit.Text = My.Settings.yabe_gui_magento_export_sichtbarkeit
        txtAttributset.Text = My.Settings.yabe_gui_magento_export_attributset
        txtShopName.Text = My.Settings.yabe_gui_magento_export_shopname
        TextBox1.Text = My.Settings.yabe_gui_magento_export_status
        txtMenge.Text = My.Settings.yabe_gui_magento_export_menge

        bLoading = False
    End Sub

    Private Sub txtSichtbarkeit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSichtbarkeit.TextChanged
        If bLoading = False Then
            My.Settings.yabe_gui_magento_export_sichtbarkeit = txtSichtbarkeit.Text
        End If        
    End Sub

    Private Sub txtMagentoSteuerklasse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMagentoSteuerklasse.TextChanged
        If bLoading = False Then
            My.Settings.yabe_gui_magento_export_steuerklasse = txtMagentoSteuerklasse.Text
        End If        
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If bLoading = False Then
            My.Settings.yabe_gui_magento_export_status = txtMagentoStatus.Text
        End If
    End Sub

    Private Sub txtMagentoStoreview_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMagentoStoreview.TextChanged
        If bLoading = False Then
            My.Settings.yabe_gui_magento_export_storeview = txtMagentoStoreview.Text
        End If
    End Sub

    Private Sub txtShopName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShopName.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_gui_magento_export_shopname = txtShopName.Name
        End If
    End Sub

    Private Sub txtAttributset_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAttributset.TextChanged
        If bIsLoading = False Then
            My.Settings.yabe_gui_magento_export_attributset = txtAttributset.Text
        End If
    End Sub
End Class