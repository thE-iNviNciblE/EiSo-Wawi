Public Class frmShopsteKategorieMapping
    Public tvShopste As New TreeView
    Public iMenue As String = 0
    Public iEiSoShopId As String = 0
    Public lvwItems As ListView

    Dim DataTable1 As New DataTable

    Private Sub frmShopsteKategorieMapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call load(True)
        FillTestTable()
        CreateTree(1194)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call load()
    End Sub

    Private Sub load(Optional bReload As Boolean = False)
        Dim i As Integer = 0
        Try
            ' tvShopste = TreeView1
            If bReload = True Then
                Call getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=get_shopste_category", mgetUpdaterMessage.getShopsteCategory, True)
            End If

            TreeView1.Nodes.Clear()
            ' TreeView1 = tvShopste
            Dim treenode As TreeNode
            Dim strContent As String = My.Computer.FileSystem.ReadAllText("shopste-kategorie.dat")

            If strContent.Length > 0 Then

                Dim strLine() As String = strContent.Split("<br>")

                'Creating the root node
                'Dim root = New TreeNode("Shopste Kategorien")

                '  frmShopsteKategorieMapping.tvShopste()
                ' TreeView1.Nodes.Add(root)
                '    Dim itmp As Integer = 0
                '    Dim currentLevel As Integer
                '    Dim lastLevel As Integer
                '    Dim lastNode = New TreeNode()

                For i = 0 To strLine.Length - 1
                    Dim strData() As String = strLine(i).Split("|")
                    If i = 91 Then
                        Stop
                    End If

                    Dim newNode As New TreeNode(strData(3))
                    '        'newNode.Parent = 0
                    newNode.Tag = strData(0).Replace("br>", "")

                    '        'If i = 0 Then
                    '        '    TreeView1.Nodes.Add(treenode)
                    '        'End If


                    '        'currentLevel = strData(2)
                    '        'If lastLevel = currentLevel Then

                    '        'Else
                    '        '    lastLevel = currentLevel
                    '        'End If


                    '        'Dim newNode = New TreeNode(strData(3))

                    '        If i = 0 Then
                    '            TreeView1.Nodes.Add(newNode)
                    '        Else

                    '            currentLevel = strData(2)
                    '            Dim strData2() As String = strLine(i - 1).Split("|")
                    '            lastLevel = strData2(2)

                    '            If currentLevel < lastLevel Then

                    '                If currentLevel = 1 Then
                    '                    TreeView1.Nodes.Add(newNode)
                    '                Else

                    '                    Dim currentNode As TreeNode = lastNode.Parent
                    '                    Dim to2 As Integer = lastLevel - currentLevel
                    '                    'to2 = 10
                    '                    Try
                    '                        For j As Integer = 0 To to2
                    '                            currentNode = currentNode.Parent
                    '                        Next j


                    '                        currentNode.Nodes.Add(newNode)
                    '                    Catch ex As Exception

                    '                    End Try


                    '                End If

                    '            ElseIf currentLevel = lastLevel Then

                    '                If lastLevel = 1 Then
                    '                    TreeView1.Nodes.Add(newNode)
                    '                Else
                    '                    Try
                    '                        lastNode.Parent.Nodes.Add(newNode)
                    '                    Catch ex As Exception

                    '                    End Try

                    '                End If
                    '            Else

                    '                lastNode.Nodes.Add(newNode)

                    '            End If

                    '        End If

                    '        lastNode = newNode
                    '    Next

                    '    '   End If
                    'End If



                    Select Case strData(2)
                        Case "0"
                            'Creating the root node
                            'Dim root = treenode

                            '  frmShopsteKategorieMapping.tvShopste()
                            TreeView1.Nodes.Add(newNode)
                        Case "1"

                            TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Add(newNode)
                        Case "2"
                            TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes(TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Count - 1).Nodes.Add(newNode)
                        Case "3"
                            ' TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes(TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Count - 1).Nodes(TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Count - 1).Nodes.Add(treenode)
                            'TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes(TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Count - 1).Nodes(TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes(TreeView1.Nodes.Count - 1).Nodes.Count - 1).Nodes.Add(treenode)
                            TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes(TreeView1.Nodes.Count - 1).Nodes(TreeView1.Nodes.Count - 1).Nodes.Add(newNode)
                    End Select


                    'Creating child nodes under the first child
                    'For loopindex As Integer = 1 To 4
                    'TreeView1.Nodes(0).Nodes(0).Nodes.Add(New  _
                    '    TreeNode("Sub Project" & Str(loopindex)))
                    'Next loopindex
                    ' creating child nodes under the root
                    'TreeView1.Nodes(0).Nodes.Add(New TreeNode("Project 6"))
                    'creating child nodes under the created child node
                    'For loopindex As Integer = 1 To 3
                    'TreeView1.Nodes(0).Nodes(1).Nodes.Add(New  _
                    '   TreeNode("Project File" & Str(loopindex)))
                    'Next loopindex


                Next i
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub FillTestTable()
        DataTable1.Columns.Add("ID", GetType(Integer))
        DataTable1.Columns.Add("NAME", GetType(String))
        DataTable1.Columns.Add("PARENT2", GetType(Integer))
        DataTable1.Columns.Add("LEVEL", GetType(Integer))

        Call getHTTPResponseMessage(My.Settings.SHOPSTE_API_URL & "?modus=get_shopste_category", mgetUpdaterMessage.getShopsteCategory, True)

        TreeView1.Nodes.Clear()
        ' TreeView1 = tvShopste
        Dim treenode As TreeNode
        Dim strContent As String = My.Computer.FileSystem.ReadAllText("shopste-kategorie.dat")
        Dim i As Integer = 0
        Try


            If strContent.Length > 0 Then

                Dim strLine() As String = strContent.Split("<br>")


                For i = 0 To strLine.Length - 2
                    Dim strData() As String = strLine(i).Split("|")

                    '  If strData(4) = 0 Then
                    '      strData(4) = ""
                    '  End If

                    DataTable1.Rows.Add(strData(0).Replace("br>", ""), strData(3), strData(4), strData(2))
                Next i
            End If
            'DataTable1.Rows.Add(1, "Patrick")


            'Dim i As Integer

            'For i = 0 To DataTable1.Rows.Count - 1
            '    Dim ID1 As String = DataTable1.Rows(i).Item("ID").ToString
            '    DataTable1.Rows(i).Item("LEVEL") = FindLevel(ID1, 0)
            'Next
        Catch ex As Exception
            MessageBox.Show("Fehler:" + ex.Message)
        End Try
    End Sub
    Private Sub CreateTree(parent As Integer)

        '        Dim MaxLevel1 As Integer = CInt(DataTable1.Compute("MAX(LEVEL)", ""))

        Dim i, j As Integer

        Try

            Dim Rows1() As DataRow = DataTable1.Select("PARENT2 = '" & parent & "'")

            Dim treen As New TreeNode
            For j = 0 To Rows1.Length - 1
                Dim ID1 As String = Rows1(j).Item("ID").ToString
                Dim Name1 As String = Rows1(j).Item("NAME").ToString
                Dim Parent1 As String = Rows1(j).Item("PARENT2").ToString
                Dim level As Integer = Rows1(j).Item("Level").ToString

                If level = 1 Then
                    'TreeView1.Nodes.Add(ID1, Name1)
                    'treen.Tag = ID1
                    'treen.Text = Name1

                    TreeView1.Nodes.Add(ID1, Name1)

                    CreateTree(Rows1(j).Item("ID").ToString)
                Else

                    Dim TreeNodes1() As TreeNode = TreeView1.Nodes.Find(Parent1, True)

                    If TreeNodes1.Length > 0 Then
                        TreeNodes1(0).Nodes.Add(ID1, Name1)
                        '  Node1.ChildNodes.Add(New TreeNode(Name1, ID1))

                    End If
                    CreateTree(Rows1(j).Item("ID").ToString)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '   
    End Sub

    Private Sub CreateTree2()
        Dim MaxLevel1 As Integer = CInt(DataTable1.Compute("MAX(LEVEL)", ""))

        Dim i, j As Integer
        Dim treen As New TreeNode
        For i = 0 To MaxLevel1
            Dim Rows1() As DataRow = DataTable1.Select("LEVEL = " & i)

            For j = 0 To Rows1.Length - 1
                Dim ID1 As String = Rows1(j).Item("ID").ToString
                Dim Name1 As String = Rows1(j).Item("NAME").ToString
                Dim Parent1 As String = Rows1(j).Item("PARENT").ToString

                If Parent1 = "0" Then

                    ' treen.Tag = ID1
                    '  treen.Text = Name1
                    TreeView1.Nodes.Add(ID1, Name1)

                Else
                    Dim TreeNodes1() As TreeNode = TreeView1.Nodes.Find(Parent1, True)

                    If TreeNodes1.Length >= 0 Then

                        '  treen.Tag = ID1
                        '  treen.Text = Name1

                        TreeNodes1(0).Nodes.Add(ID1, Name1)
                        '  Node1.ChildNodes.Add(New TreeNode(Name1, ID1))

                    End If
                End If
            Next
        Next
    End Sub

    'Private Function FindLevel(ByVal ID As String, ByRef Level As Integer) As Integer
    '    Dim i As Integer

    '    For i = 0 To DataTable1.Rows.Count - 1
    '        Dim ID1 As String = DataTable1.Rows(i).Item("ID").ToString
    '        Dim Parent1 As String = DataTable1.Rows(i).Item("PARENT").ToString

    '        If ID = ID1 Then
    '            If Parent1 = "0" Then
    '                Return Level
    '            Else
    '                Level += 1
    '                FindLevel(Parent1, Level)
    '            End If
    '        End If
    '    Next

    '    Return Level
    'End Function

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        txtShopsteID.Text = e.Node.Name
        Label2.Text = e.Node.Text
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        btnSpeichern.Enabled = False
        If Not iMenue = 0 Then
            clsDatenbank_modul.setShopsteCatEiSoMenue(txtShopsteID.Text, iMenue)
        Else
            Dim i As Integer

            For i = 0 To lvwItems.SelectedItems.Count - 1
                clsDatenbank_modul.setShopsteCatEiSoArtikel(txtShopsteID.Text, lvwItems.SelectedItems(i).SubItems(0).Text)
            Next

        End If
        btnSpeichern.Enabled = True

    End Sub
End Class