Imports System.Xml
Imports Google.GData.Client
Imports Google.GData.GoogleBase

Public Class frmGoogleBaseManager

    Dim batchFeed As GBaseFeed
    Dim entryArray As New ArrayList

    Private Sub GetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetData.Click

        Dim service As GBaseService = New GBaseService(Me.Text, AppKey.Text)
        Dim query As GBaseQuery = New GBaseQuery(Me.BaseUri.Text)

        If (Username.Text.Length > 0) Then
            service.setUserCredentials(Me.Username.Text, Me.Password.Text)
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim feed As GBaseFeed = service.Query(query)

        Dim table As DataTable = CreateDataTable()

        Dim source As New DataSet("source")
        ' Adds two DataTable objects, Suppliers and Products.


        Me.batchFeed = feed

        source.Tables.Add(table)

        Dim i As Integer
        Dim goOn As Boolean
        goOn = True
        i = 0

        While goOn
            ' fill the table
            For Each entry As GBaseEntry In feed.Entries
                Dim row As DataRow

                row = table.NewRow()

                row("id") = entry.Id.Uri.ToString()
                row("Title") = entry.Title.Text
                row("Content") = entry.Content.Content
                row("Author") = entry.Authors.Item(0).Name
                row("ItemType") = entry.GBaseAttributes.ItemType
                table.Rows.Add(row)
                Me.entryArray.Add(entry)
                i = i + 1
            Next

            Me.ItemCount.Text = "Augenblicklich: " + i.ToString() + " Artikel"
            Application.DoEvents()

            If goOn = True Or Nothing Is feed.NextChunk() Then
                goOn = False
            Else
                query.Uri = New Uri(feed.NextChunk())
                feed = service.Query(query)
            End If

        End While



        Me.ItemCount.Text = "Gesammt: " + i.ToString() + " Artikel"

        table.AcceptChanges()


        Me.BaseGrid.DataSource = table
        Me.BaseGrid.Text = i.ToString()


        Me.Cursor = Cursors.Default
        Me.PostData.Enabled = True
    End Sub

    Private Sub PostData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostData.Click
        ' we need to walk over the datatable and get the changed/new lines
        Dim table As DataTable = Me.BaseGrid.DataSource

        Dim i As Integer
        i = 0

        Dim service As GBaseService = New GBaseService(Me.Text, AppKey.Text)
        If (Username.Text.Length > 0) Then
            service.setUserCredentials(Me.Username.Text, Me.Password.Text)
        End If

        Dim batchFeed As AtomFeed = New AtomFeed(Me.batchFeed)

        batchFeed.BatchData = New GDataBatchFeedData
        batchFeed.BatchData.Type = GDataBatchOperationType.update

        Dim counter As Integer

        For Each row As DataRow In table.Rows
            If row.RowState <> DataRowState.Unchanged Then
                i = i + 1
                Me.ItemCount.Text = "Geänderte: " + i.ToString() + " Artikel"
                Application.DoEvents()

                Dim entry As GBaseEntry
                Dim author As AtomPerson

                If row.RowState = DataRowState.Added Then
                    entry = New GBaseEntry
                    author = New AtomPerson
                    entry.Authors.Add(author)
                Else
                    entry = Me.entryArray.Item(counter)
                    author = entry.Authors.Item(0)
                End If
                entry.BatchData = New GDataBatchEntryData
                entry.BatchData.Id = i.ToString()
                If row.RowState <> DataRowState.Deleted Then
                    author.Name = row("Author")
                    entry.Title.Text = row("Title")
                    entry.Content.Content = row("Content")
                    entry.GBaseAttributes.ItemType = row("ItemType")
                End If
                If row.RowState = DataRowState.Added Then
                    entry.BatchData.Type = GDataBatchOperationType.insert
                ElseIf row.RowState = DataRowState.Deleted Then
                    entry.BatchData.Type = GDataBatchOperationType.delete
                ElseIf row.RowState = DataRowState.Modified Then
                    entry.BatchData.Type = GDataBatchOperationType.update
                End If
                batchFeed.Entries.Add(entry)
            End If
            counter = counter + 1
        Next

        If i > 0 Then
            ' upload
            Dim returnFeed As GBaseFeed = service.Batch(batchFeed, New Uri(Me.batchFeed.Batch))


            For Each entry As GBaseEntry In returnFeed.Entries
                If entry.BatchData.Status.Code > 300 Then
                    Me.ItemCount.Text = "Fehler aufgetreten"
                    Application.DoEvents()
                    Exit Sub
                End If
            Next

            Call Me.GetData_Click(Nothing, Nothing)
        End If

    End Sub



    Private Function CreateDataTable() As DataTable
        ' Create a new DataTable.
        Dim myDataTable As DataTable = New DataTable("GBaseTable")
        ' Declare variables for DataColumn and DataRow objects.
        Dim myDataColumn As DataColumn
        ' Create new DataColumn, set DataType, ColumnName and add to DataTable.    
        myDataColumn = New DataColumn
        myDataColumn.DataType = System.Type.GetType("System.String")
        myDataColumn.ColumnName = "Id"
        myDataColumn.ReadOnly = True
        myDataColumn.Unique = True

        ' Add the Column to the DataColumnCollection.
        myDataTable.Columns.Add(myDataColumn)

        ' Create title column.
        myDataColumn = New DataColumn
        myDataColumn.DataType = System.Type.GetType("System.String")
        myDataColumn.ColumnName = "Title"
        myDataColumn.AutoIncrement = False
        myDataColumn.ReadOnly = False
        myDataColumn.Unique = False
        ' Add the column to the table.
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn
        myDataColumn.DataType = System.Type.GetType("System.String")
        myDataColumn.ColumnName = "Author"
        myDataColumn.AutoIncrement = False
        myDataColumn.ReadOnly = False
        myDataColumn.Unique = False
        ' Add the column to the table.
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn
        myDataColumn.DataType = System.Type.GetType("System.String")
        myDataColumn.ColumnName = "Content"
        myDataColumn.AutoIncrement = False
        myDataColumn.ReadOnly = False
        myDataColumn.Unique = False
        ' Add the column to the table.
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn
        myDataColumn.DataType = System.Type.GetType("System.String")
        myDataColumn.ColumnName = "ItemType"
        myDataColumn.AutoIncrement = False
        myDataColumn.ReadOnly = False
        myDataColumn.Unique = False
        ' Add the column to the table.
        myDataTable.Columns.Add(myDataColumn)

        Return myDataTable
    End Function

    Private Sub Username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.TextChanged
        VerifyButtons()
    End Sub

    Private Sub Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged
        VerifyButtons()
    End Sub

    Private Sub AppKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppKey.TextChanged
        VerifyButtons()
    End Sub

    Private Sub BaseUri_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseUri.TextChanged
        VerifyButtons()
    End Sub

    Private Sub VerifyButtons()
        If Me.BaseUri.Text.Length > 0 And Me.Username.Text.Length > 0 And Me.Password.Text.Length > 0 And Me.AppKey.Text.Length > 0 Then
            Me.GetData.Enabled = True
            If Not (Me.batchFeed Is Nothing) Then
                Me.PostData.Enabled = True
            End If
        Else
            Me.GetData.Enabled = False
            Me.PostData.Enabled = False
        End If
    End Sub
End Class