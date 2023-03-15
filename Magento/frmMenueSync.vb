Public Class frmMenueSync
    Dim mc As New clsMagentoAPI
    Private Sub frmMenueSync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
       

        '# Magento Kategorien holen 
        Call mc.getCategoryTree(lvwMagentoKategorie, False)
    End Sub

    

    Public Function getPreview(ByVal lvw1 As ListView, ByVal lvw2 As ListView) As Boolean

        Dim iLoop As Integer = 0
        Dim iLoop2 As Integer = 0
        Dim strName As String = ""
        Dim strName2 As String = ""
        Dim iStop As Integer = 0

        Dim bIsIn As Boolean = False

        iStop = lvw2.Items.Count - 1
        '# Menü durchlaufen
        For iLoop = 0 To lvw1.Items.Count - 1

            strName = lvw1.Items(iLoop).SubItems(1).Text ' Name 

            '# Magento Kategorien durchlaufen

            For iLoop2 = 0 To iStop

                strName2 = lvw2.Items(iLoop2).SubItems(1).Text

                If strName = strName2 Then
                    bIsIn = True
                    Exit For
                Else
                  
                End If

            Next

            If bIsIn = False Then
                Dim lvwitem As New ListViewItem
                lvwitem.Text = "0"
                lvwitem.BackColor = Color.PeachPuff
                lvwitem.SubItems.Add(strName)

                lvw2.Items.Add(lvwitem)
            End If

        Next

    End Function

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click

        If lvwMagentoKategorie.SelectedItems.Count > 0 Then
            lvwMagentoKategorie.SelectedItems(0).Remove()
        End If

    End Sub

    Private Sub btnImport2Magento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport2Magento.Click
         
         
        If MsgBox("Möchten Sie das komplette Menü in YabE importieren?" & vbCrLf & "ACHTUNG: Ist das Menü bereits synchronisiert, wird es verdoppelt, diese Funktion dient dem einmaligen Abgleich", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call mc.getCategoryTree(lvwMagentoKategorie, True)
        End If
    End Sub
End Class