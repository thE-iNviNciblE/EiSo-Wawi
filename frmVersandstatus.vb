Public Class frmVersandstatus

    Public lvwData As ListView
    Public strEmail As String

    Private Sub frmVersandstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim strKundenDetails() As String

        '# Sprachen holen
        If frmMain.frmManage.cmbSprache_Artikeldatenbank.Items.Count - 1 = 0 Then
            clsDatenbank_modul.getComboSprachen(cmbSprache_Versandstatus)
        Else
clsDatenbank_modul.getComboSprachen(cmbSprache_Versandstatus)
        End If        

        '# Kundenprofil abrufen 
        ReDim strKundenDetails(10)
        strKundenDetails = clsDatenbank_modul.getMemberAdress_email(strEmail)

        If strKundenDetails.Length >= 2 Then
            txtLand.Text = strKundenDetails(3)
            txtAnschrift.Text = strKundenDetails(0) & " / " & strKundenDetails(1)
        End If

        If txtLand.Text.ToUpper.IndexOf("DEUTSCHLAND") = -1 Then
            cmbSprache_Versandstatus.SelectedIndex = 1
        Else
            cmbSprache_Versandstatus.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnVersandstatusAbschicken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVersandstatusAbschicken.Click
        Me.Close()
    End Sub
End Class