Imports System.Xml

Public Class frmDelcampe_Category_editor

    Dim xml_node_master As XmlNode ' Load Base Resource 
    Public strAray() As String ' Array für Knotenanalyse
    Public iID As Integer
    Public strSelectedCat As String '# Selektierte Kategorie ID übergeben bei Form Close 
    Private col As Integer

    ' Add the children of this XML node 
    ' to this child nodes collection.
    Private Sub AddTreeViewChildNodes(ByVal parent_nodes As  _
        TreeNodeCollection, ByVal xml_node As XmlNode)

        For Each child_node As XmlNode In xml_node.ChildNodes
            ' Make the new TreeView node.
            Dim new_node As TreeNode = _
                parent_nodes.Add(child_node.Value)

            Application.DoEvents()
            ' Recursively make this node's descendants.
            AddTreeViewChildNodes(new_node.Nodes, child_node)

            Application.DoEvents()

            ' If this is a leaf node, make sure it's visible.
            If new_node.Nodes.Count = 0 Then _
                new_node.EnsureVisible()
        Next child_node
    End Sub

    Public Function getDelcampeXML_sites(ByVal xml_node As XmlNode, ByVal strName As String) As Boolean
        Try


            For Each child_node As XmlNode In xml_node.ChildNodes

                Try
                    If child_node.Name = "#text" Then

                    Else
                        strName = child_node.Name
                    End If


                Catch ex As Exception

                End Try


                If Not child_node.Value = Nothing Then

                    If strName = "G" Then
                        lstDelcampeXML_main.Items.Add(child_node.Value)
                    End If

                End If

                If child_node.HasChildNodes = True Then

                    getDelcampeXML_sites(child_node, strName)

                End If


                Application.DoEvents()
                ' Recursively make this node's descendants.
                'AddTreeViewChildNodes(new_node.Nodes, child_node)

            Next child_node

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '#########################################################
    '# >> Hole Absoluten Namen 
    '#########################################################
    Private Function getKategorieName() As String
        Try
            Dim strName As String

            If lvwMain_2.Visible = True And lvwMain_2.SelectedItems.Count > 0 Then
                strName = lvwMain.SelectedItems(0).SubItems(1).Text & " > " & lvwMain_2.SelectedItems(0).SubItems(1).Text
            Else
                strName = lvwMain.SelectedItems(0).SubItems(1).Text
            End If

            If lvwMain_3.Visible = True And lvwMain_3.SelectedItems.Count > 0 Then
                strName &= " > " & lvwMain_3.SelectedItems(0).SubItems(1).Text
            End If

            If lvwMain_4.Visible = True And lvwMain_4.SelectedItems.Count > 0 Then
                strName &= " > " & lvwMain_4.SelectedItems(0).SubItems(1).Text
            End If

            If lvwMain_5.Visible = True And lvwMain_5.SelectedItems.Count > 0 Then
                strName &= " > " & lvwMain_5.SelectedItems(0).SubItems(1).Text
            End If

            If lvwMain_6.Visible = True And lvwMain_6.SelectedItems.Count > 0 Then
                strName &= " > " & lvwMain_6.SelectedItems(0).SubItems(1).Text
            End If


            Return strName
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "-1"
        End Try
    End Function

    '##########################################################
    '# >> Kategorie XML einlesen 
    '##########################################################
    Public Function getDelcampeXML_category(ByVal xml_node As XmlNode, ByRef lvw As ListView, ByVal strName As String, ByVal strCategoryID As String, Optional ByVal bSuchen As Boolean = False) As Boolean
        Try

            For Each child_node As XmlNode In xml_node.ChildNodes

                Try
                    If child_node.Name = "#text" Then

                    Else
                        strName = child_node.Name
                    End If


                Catch ex As Exception

                End Try


                '# Prüfung ob Wert gültig 
                If Not child_node.Value = Nothing Then


                    '##################################################
                    '# >> Array
                    '# 0 = Kategorie ID 
                    '# 1 = Bereich Briefmarken, Münzen (Combobox)
                    '##################################################

                    Select Case child_node.ParentNode.LocalName
                        Case "id_category"
                            strAray(0) = child_node.Value
                        Case "id_site"

                            strAray(1) = child_node.Value

                        Case "G"
                            strAray(2) = child_node.Value
                        Case "id_parent"

                            If strCategoryID = child_node.Value Then
                                Dim lvwItem As New ListViewItem
                                lvwItem.Text = strAray(0)

                                '# Namen + ">" ausgeben 
                                If bSuchen = True Then
                                    lvwItem.SubItems.Add(strAray(2) & " > ")
                                Else
                                    lvwItem.SubItems.Add(strAray(2).Trim)
                                End If


                                lvwItem.SubItems.Add(child_node.Value)
                                lvw.Items.Add(lvwItem)
                            Else
                                'Exit For
                            End If

                    End Select

                    'End If

                End If

                If child_node.HasChildNodes = True Then

                    getDelcampeXML_category(child_node, lvw, strName, strCategoryID)

                End If


                Application.DoEvents()
                ' Recursively make this node's descendants.
                'AddTreeViewChildNodes(new_node.Nodes, child_node)

            Next child_node

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '###################################################
    '# >> Suchen und selektieren 
    '###################################################
    Private Function setLVW_search_select(ByRef lvw As ListView, ByVal iid As String) As Boolean
        Try
            Dim iCount As Integer = 0

            For iCount = 0 To lvw.Items.Count - 1

                If iid = lvw.Items(iCount).SubItems(0).Text Then
                    lvw.Items(iCount).Selected = True
                    lvw.Items(iCount).EnsureVisible()
                    Exit For
                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function setComboBoxIndex(ByVal iid As Integer) As Boolean
        Try
            Select Case iid
                Case "-1"

            End Select
        Catch ex As Exception

        End Try
    End Function

    '##########################################################################
    '# >> Delcampe Kategorie Suche -> Anzeige steuern 
    '##########################################################################
    Public Function getDelcampeXML_search_id() As Boolean
        Try
            Dim bAbort As Boolean = False
            Dim iBereiche As Integer = 1
            Dim strIDs() As String
            iID = txtSearchID.Text

            ReDim strIDs(0)
            lblBereich.Text = ""
            strIDs(0) = iID

            '# Alle Bereiche durchsuchen
            While bAbort = False
                getDelcampeXML_category_find(xml_node_master)

                If iID < 0 Then
                    bAbort = True
                    ReDim Preserve strIDs(UBound(strIDs) + 1) ' Array vergrößern 
                    strIDs(iBereiche) = iID
                Else
                    ReDim Preserve strIDs(UBound(strIDs) + 1) ' Array vergrößern 
                    strIDs(iBereiche) = iID
                    iBereiche += 1
                End If
            End While

            '# Alle Bereiche Laden + Selektieren 
            Dim iCount As Integer = 0

            '# Bereiche vorbereiten 
            Select Case strIDs.Length
                Case 1
                    lvwMain.Visible = True
                    lvwMain.Items.Clear()
                Case 2
                    lvwMain.Visible = True
                    lvwMain.Items.Clear()
                    lvwMain_2.Visible = True
                    lvwMain_2.Items.Clear()
                    lvwMain_3.Visible = True
                    lvwMain_3.Items.Clear()
                Case 3
                    lvwMain.Visible = True
                    lvwMain.Items.Clear()
                    lvwMain_2.Visible = True
                    lvwMain_2.Items.Clear()
                    lvwMain_3.Visible = True
                    lvwMain_3.Items.Clear()
                    lvwMain_4.Visible = True
                    lvwMain_4.Items.Clear()
                Case 4
                    lvwMain.Visible = True
                    lvwMain.Items.Clear()
                    lvwMain_2.Visible = True
                    lvwMain_2.Items.Clear()
                    lvwMain_3.Visible = True
                    lvwMain_3.Items.Clear()
                    lvwMain_4.Visible = True
                    lvwMain_4.Items.Clear()
                    lvwMain_5.Visible = True
                    lvwMain_5.Items.Clear()
                Case 5
                    lvwMain.Visible = True
                    lvwMain.Items.Clear()
                    lvwMain_2.Visible = True
                    lvwMain_2.Items.Clear()
                    lvwMain_3.Visible = True
                    lvwMain_3.Items.Clear()
                    lvwMain_4.Visible = True
                    lvwMain_4.Items.Clear()
                    lvwMain_5.Visible = True
                    lvwMain_5.Items.Clear()
                    lvwMain_6.Visible = True
                    lvwMain_6.Items.Clear()
                Case 6

            End Select

            Dim iCount2 As Integer = 0

            lvwMain.BeginUpdate()
            getDelcampeXML_base_category(strIDs(strIDs.Length - 1))
            'getDelcampeXML_category(xml_node_master, lvwMain, "", strIDs(strIDs.Length - 1), True)
            lvwMain.EndUpdate()
            Dim iLength_now As Integer = strIDs.Length - 2
            For iCount = 0 To strIDs.Length - 2

                Select Case iCount
                    Case 0
                        setLVW_search_select(lvwMain, strIDs(iLength_now))
                        iLength_now -= 1
                    Case 1
                        setLVW_search_select(lvwMain_2, strIDs(iLength_now))
                        iLength_now -= 1
                    Case 2
                        setLVW_search_select(lvwMain_3, strIDs(iLength_now))
                        iLength_now -= 1
                    Case 3
                        setLVW_search_select(lvwMain_4, strIDs(iLength_now))
                        iLength_now -= 1
                    Case 4
                        setLVW_search_select(lvwMain_5, strIDs(iLength_now))
                        iLength_now -= 1
                    Case 5
                        setLVW_search_select(lvwMain_6, strIDs(iLength_now))
                        iLength_now -= 1
                End Select

            Next

            'For iCount = strIDs.Length - 1 To 0 Step -1

            '    Select Case iCount
            '        Case 0
            '            getDelcampeXML_category(xml_node_master, lvwMain, "", strIDs(iCount2))
            '            iCount2 += 1
            '        Case 1
            '            getDelcampeXML_category(xml_node_master, lvwMain_2, "", strIDs(iCount2))
            '            iCount2 += 1
            '        Case 2
            '            getDelcampeXML_category(xml_node_master, lvwMain_3, "", strIDs(iCount2))
            '            iCount2 += 1
            '        Case 3
            '            getDelcampeXML_category(xml_node_master, lvwMain_4, "", strIDs(iCount2))
            '            iCount2 += 1
            '        Case 4
            '            getDelcampeXML_category(xml_node_master, lvwMain_5, "", strIDs(iCount2))
            '            iCount2 += 1
            '        Case 5
            '            getDelcampeXML_category(xml_node_master, lvwMain_6, "", strIDs(iCount2))                    
            '            iCount2 += 1
            '    End Select

            'Next


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> Kategorie XML einlesen 
    '##########################################################
    Public Function getDelcampeXML_category_find(ByVal xml_node As XmlNode) As Boolean
        Try

            For Each child_node As XmlNode In xml_node.ChildNodes



                '# Prüfung ob Wert gültig 
                If Not child_node.Value = Nothing Then


                    '##################################################
                    '# >> Array
                    '# 0 = Kategorie ID 
                    '# 1 = Bereich Briefmarken, Münzen (Combobox)
                    '##################################################

                    Select Case child_node.ParentNode.LocalName
                        Case "id_category"

                            If child_node.Value = iID Then
                                strAray(0) = child_node.Value

                            Else
                                Exit For
                            End If

                        Case "id_site"

                            strAray(1) = child_node.Value

                        Case "G"
                            strAray(2) = child_node.Value
                        Case "id_parent"

                            If strAray(0) = iID Then
                                ' MsgBox(strAray(0) & " - " & child_node.Value)    
                                iID = child_node.Value
                                lblBereich.Text &= strAray(2) & " > "
                                Return True
                                '  Exit For
                            End If

                    End Select

                    'End If

                End If

                If child_node.HasChildNodes = True Then

                    getDelcampeXML_category_find(child_node)

                End If


                Application.DoEvents()
                ' Recursively make this node's descendants.
                'AddTreeViewChildNodes(new_node.Nodes, child_node)

            Next child_node

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '#################################################################
    '# >> Holen der Basis KAtegorien 
    '#################################################################
    Private Function getDelcampeXML_base_category(Optional ByVal iMinus_selected As Integer = -100) As Boolean
        Try



            'Unsichtbar machen von 
            lvwMain_2.Visible = False
            lvwMain_3.Visible = False
            lvwMain_4.Visible = False
            lvwMain_5.Visible = False
            lvwMain_6.Visible = False

            lvwMain.Items.Clear()
            lvwMain.BeginUpdate()

            If iMinus_selected = -100 Then
                Dim i As Integer = 0
                Dim iMinus As Integer = 0
                For i = 0 To lstDelcampeXML_main.SelectedIndex
                    iMinus -= 1
                Next

                getDelcampeXML_category(xml_node_master, lvwMain, "", iMinus)

                lvwMain.Sorting = SortOrder.Ascending
                lvwMain.ListViewItemSorter = New lvsorter(Of String)(1)

            Else
                ' Negativen Index umdrehen 
                Dim index As Integer = -2
                Dim i As Integer = 0
                For i = iMinus_selected To 0
                    index += 1
                Next

                ' Gleiche Kategorie schon selektiert 
                If Not index = lstDelcampeXML_main.SelectedIndex Then
                    lstDelcampeXML_main.SelectedIndex = index
                Else
                    getDelcampeXML_category(xml_node_master, lvwMain, "", iMinus_selected)

                    lvwMain.Sorting = SortOrder.Ascending
                    lvwMain.ListViewItemSorter = New lvsorter(Of String)(1)
                End If


            End If




            '# Hole Absoluten Namen
            lblBereich.Text = ""

            lvwMain.EndUpdate()
            lvwMain.Enabled = True

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frmDelcampe_Category_editor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        strSelectedCat = txtSearchID.Text
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '###################################
        '# >> Delcampe Kategorien laden 
        '###################################
        Dim xml_node As XmlNode
        Dim xml_doc As New XmlDocument
        ReDim strAray(3)


        Try
            '# Gibt es einen Delcampe Pfad zum Laden? 

            If My.Settings.gui_delcampe_category_xml.Length > 0 And IO.File.Exists(My.Settings.gui_delcampe_category_xml & "/sites.xml") = True Then
                xml_doc.Load(My.Settings.gui_delcampe_category_xml & "\sites.xml")
                xml_node = xml_doc.DocumentElement
                getDelcampeXML_sites(xml_node, "")



                '######################################
                '# >> Kategorien laden...
                '######################################
                lvwMain.Enabled = False
                xml_doc.Load(My.Settings.gui_delcampe_category_xml & "\categories.xml")
                xml_node = xml_doc.DocumentElement
                xml_node_master = xml_node

                lstDelcampeXML_main.SelectedIndex = 0
            Else
                MsgBox("Bitte rufen Sie die Einstellungen unter im oberen Menü Werkzeuge auf" & vbCrLf & "Bitte wechseln Sie auf den Delcampe Tab")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub lstDelcampeXML_main_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDelcampeXML_main.SelectedIndexChanged

        getDelcampeXML_base_category()

    End Sub

    Private Sub lvwMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMain.SelectedIndexChanged


        If lvwMain.SelectedItems.Count > 0 Then
            lvwMain_2.Enabled = False

            'Unsichtbar machen von 
            lvwMain_3.Visible = False
            lvwMain_4.Visible = False
            lvwMain_5.Visible = False
            lvwMain_6.Visible = False

            lvwMain_2.Visible = True

            lvwMain_2.Items.Clear()
            lvwMain_2.BeginUpdate()
            getDelcampeXML_category(xml_node_master, lvwMain_2, "", lvwMain.SelectedItems(0).Text)
            lvwMain_2.EndUpdate()

            lvwMain_2.Sorting = SortOrder.Ascending
            lvwMain_2.ListViewItemSorter = New lvsorter(Of String)(1)

            '# Hole Absoluten Namen
            lblBereich.Text = getKategorieName()
            txtSearchID.Text = lvwMain.SelectedItems(0).Text

            lvwMain_2.Enabled = True

        End If
    End Sub

    Private Sub lvwMain_2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMain_2.SelectedIndexChanged


        If lvwMain_2.SelectedItems.Count > 0 Then
            ' Load the XML document.
            Dim xml_doc As New XmlDocument
            lvwMain_3.Enabled = False

            'Unsichtbar machen von 
            lvwMain_4.Visible = False
            lvwMain_5.Visible = False
            lvwMain_6.Visible = False

            lvwMain_3.Visible = True

            lvwMain_3.Items.Clear()
            lvwMain_3.BeginUpdate()
            getDelcampeXML_category(xml_node_master, lvwMain_3, "", lvwMain_2.SelectedItems(0).Text)
            lvwMain_3.EndUpdate()

            lvwMain_3.Sorting = SortOrder.Ascending
            lvwMain_3.ListViewItemSorter = New lvsorter(Of String)(1)

            '# Hole Absoluten Namen
            lblBereich.Text = getKategorieName()
            txtSearchID.Text = lvwMain_2.SelectedItems(0).Text

            lvwMain_3.Enabled = True

        End If
    End Sub

    Private Sub lvwMain_3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMain_3.SelectedIndexChanged

        If lvwMain_3.SelectedItems.Count > 0 Then
            ' Load the XML document.
            Dim xml_doc As New XmlDocument
            lvwMain_4.Enabled = False

            lvwMain_5.Visible = False
            lvwMain_6.Visible = False

            lvwMain_4.Visible = True

            lvwMain_4.Items.Clear()
            lvwMain_4.BeginUpdate()
            getDelcampeXML_category(xml_node_master, lvwMain_4, "", lvwMain_3.SelectedItems(0).Text)
            lvwMain_4.EndUpdate()

            lvwMain_4.Sorting = SortOrder.Ascending
            lvwMain_4.ListViewItemSorter = New lvsorter(Of String)(1)

            '# Hole Absoluten Namen
            lblBereich.Text = getKategorieName()
            txtSearchID.Text = lvwMain_3.SelectedItems(0).Text

            lvwMain_4.Enabled = True

        End If
    End Sub

    Private Sub lvwMain_5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMain_5.SelectedIndexChanged


        If lvwMain_5.SelectedItems.Count > 0 Then
            ' Load the XML document.
            Dim xml_doc As New XmlDocument
            lvwMain_6.Enabled = False



            lvwMain_6.Visible = True

            lvwMain_6.Items.Clear()
            lvwMain_6.BeginUpdate()
            getDelcampeXML_category(xml_node_master, lvwMain_6, "", lvwMain_5.SelectedItems(0).Text)
            lvwMain_6.EndUpdate()

            lvwMain_6.Sorting = SortOrder.Ascending
            lvwMain_6.ListViewItemSorter = New lvsorter(Of String)(1)

            '# Hole Absoluten Namen
            lblBereich.Text = getKategorieName()
            txtSearchID.Text = lvwMain_5.SelectedItems(0).Text

            lvwMain_6.Enabled = True

        End If

    End Sub

    Private Sub lvwMain_4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMain_4.SelectedIndexChanged


        If lvwMain_4.SelectedItems.Count > 0 Then
            ' Load the XML document.
            Dim xml_doc As New XmlDocument
            lvwMain_5.Enabled = False


            lvwMain_6.Visible = False

            lvwMain_5.Visible = True

            lvwMain_5.Items.Clear()
            lvwMain_5.BeginUpdate()
            getDelcampeXML_category(xml_node_master, lvwMain_5, "", lvwMain_4.SelectedItems(0).Text)
            lvwMain_5.EndUpdate()

            lvwMain_5.Sorting = SortOrder.Ascending
            lvwMain_5.ListViewItemSorter = New lvsorter(Of String)(1)

            '# Hole Absoluten Namen
            lblBereich.Text = getKategorieName()
            txtSearchID.Text = lvwMain_4.SelectedItems(0).Text

            lvwMain_5.Enabled = True

        End If
    End Sub

    Private Sub lvwMain_6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMain_6.SelectedIndexChanged

        '# Hole Absoluten Namen
        lblBereich.Text = getKategorieName()
        txtSearchID.Text = lvwMain_6.SelectedItems(0).Text

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSuchen.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchID.TextChanged
        If txtSearchID.Text.Length > 0 Then
            Clipboard.SetText(txtSearchID.Text)
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuchen.Click
        Call getDelcampeXML_search_id()
    End Sub

    Private Sub txtSearchID_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchID.DoubleClick
        Me.Close()
    End Sub

    Private Sub lvwMain_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMain.ColumnClick
        Try
            Call setSort(lvwMain, e)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvweBayLiveList_ColumnClick")
        End Try
    End Sub

    '#################################################################
    '# >> Sortieren 
    '#################################################################
    Public Function setSort(ByRef listview1 As ListView, ByVal e As  _
      System.Windows.Forms.ColumnClickEventArgs) As Boolean
        Try
            If bIsLoading = False Then

                If col = e.Column Then
                    If listview1.Sorting = SortOrder.Descending Then
                        listview1.Sorting = SortOrder.Ascending
                    Else
                        listview1.Sorting = SortOrder.Descending
                    End If
                Else
                    listview1.Sorting = SortOrder.Ascending
                End If

                col = e.Column

                '###########################
                '# >> Listviewnamen ermitteln 
                '###########################
                Select Case listview1.Name
                    Case "lvwMain"
                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                    Case "lvwMain_2"
                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                    Case "lvwMain_3"
                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                    Case "lvwMain_4"
                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                    Case "lvwMain_5"
                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                    Case "lvwMain_6"
                        Select Case col
                            Case 0
                                listview1.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                            Case Else
                                listview1.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                        End Select
                End Select
            End If

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setSort - Listview Sortiert")
            Return False
        End Try
    End Function

    Private Sub lvwMain_2_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMain_2.ColumnClick
        Try
            Call setSort(lvwMain_2, e)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvwMain_2_ColumnClick")
        End Try
    End Sub

    Private Sub lvwMain_3_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMain_3.ColumnClick
        Try
            Call setSort(lvwMain_3, e)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvwMain_3_ColumnClick")
        End Try
    End Sub

    Private Sub lvwMain_4_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMain_4.ColumnClick
        Try
            Call setSort(lvwMain_4, e)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvwMain_4_ColumnClick")
        End Try
    End Sub

    Private Sub lvwMain_5_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMain_5.ColumnClick
        Try
            Call setSort(lvwMain_5, e)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvwMain_5_ColumnClick")
        End Try
    End Sub

    Private Sub lvwMain_6_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMain_6.ColumnClick
        Try
            Call setSort(lvwMain_6, e)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "lvwMain_6_ColumnClick")
        End Try
    End Sub
End Class
