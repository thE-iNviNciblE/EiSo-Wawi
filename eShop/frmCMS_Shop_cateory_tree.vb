Public Class frmCMS_Shop_cateory_tree

    Private Sub NeueHauptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeueHauptToolStripMenuItem.Click
        Dim strNodeName As String = InputBox("Bitte neuen Kategorienamen eingeben", "eShop Kategorienamen")

        If Not strNodeName = "-1" Then

            Dim RootNode As New TreeNode(strNodeName)
            TreeViewCategory.Nodes.Add(RootNode)

            ' Fill(RootNode)

            TreeViewCategory.Nodes(0).Expand()

        End If
    End Sub


    Private Sub UnterkategorieAnlegenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnterkategorieAnlegenToolStripMenuItem.Click
        Dim strNodeName As String = InputBox("Bitte neuen Unterkategorienamen eingeben", "eShop Kategorienamen")
        If Not strNodeName = "-1" Then
            Dim tvwNode As New TreeNode
            tvwNode = TreeViewCategory.SelectedNode
            tvwNode.Nodes.Add(strNodeName)
            'TreeViewCategory.Nodes.Add(tvwNode)
        End If
    End Sub

    Private Sub TreeViewCategory_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewCategory.NodeMouseDoubleClick

    End Sub



    Private Sub btnExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandAll.Click
        TreeViewCategory.ExpandAll()
    End Sub

    Private Sub KategorieLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategorieLöschenToolStripMenuItem.Click
        Dim tvwNode As TreeNode
        tvwNode = TreeViewCategory.SelectedNode


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If Me.TreeViewCategory.SelectedNode.FullPath.IndexOf("\") = -1 Then
        'MsgBox(TreeViewCategory.SelectedNode.FullPath)
        ' End If

        '# Hauptkategorie anzeigen
        'If TreeViewCategory.Nodes.Count > 0 Then
        '    Dim nodeEnumerator As IEnumerator = TreeViewCategory.Nodes.GetEnumerator()
        '    While nodeEnumerator.MoveNext()

        '        TextBox1.Text &= (CType(nodeEnumerator.Current, TreeNode)).Text & "<br>"

        '    End While

        'End If

        '  Call CallRecursive(TreeViewCategory)


    End Sub

    'Private Sub PrintRecursive(ByVal vn As TreeNode, ByVal iParent As Integer, ByVal iChild As Integer)

    '    MessageBox.Show("Parent: " & iParent & " Child: " & iChild & " - " & n.Text)

    '    Call clsDatenbank_modul.setCMS_NewMenue(vn, iParent, iChild, 0, 0)

    '    Dim aNode As TreeNode

    '    For Each aNode In n.Nodes
    '        iChild += 1
    '        PrintRecursive(aNode, iParent, iChild)
    '    Next

    'End Sub

    'Private Sub CallRecursive(ByVal aTreeView As TreeView)
    '    Dim n As TreeNode
    '    Dim iParent As Integer = 0
    '    Dim iChild As Integer = 0

    '    For Each n In aTreeView.Nodes
    '        iParent += 1
    '        PrintRecursive(n, iParent, iChild)
    '    Next

    'End Sub

    Private Sub frmShop_cateory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call clsDatenbank_modul.getCMS_Menue(TreeViewCategory)
    End Sub
End Class