Friend Class comparebyFirstcolumn

    Implements IComparer
    Private _sortAscending As Boolean = True
    'Private sort_order As SortOrder
    Private columnnumber As Integer
    Private _isDate As Boolean = False

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare

        Dim returnvalue As Integer = 0

        Try


            If Not _isDate Then
                returnvalue = String.Compare(CType(x, ListViewItem).SubItems(columnnumber).Text, CType(y, ListViewItem).SubItems(columnnumber).Text)
            Else
                Dim xDate As DateTime = DateTime.Parse(CType(x, ListViewItem).SubItems(columnnumber).Text)
                Dim yDate As DateTime = DateTime.Parse(CType(y, ListViewItem).SubItems(columnnumber).Text)
                returnvalue = Date.Compare(xDate, yDate)
            End If
            If Not _sortAscending Then
                returnvalue = -1 * returnvalue
            End If
            Return returnvalue

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "Klasse: Compare")
            Exit Function
        End Try

    End Function

    Public Sub New(ByVal column As Integer, ByVal isDate As Boolean, ByVal sortascending As Boolean)
        columnnumber = column
        _isDate = isDate
        _sortAscending = sortascending
    End Sub

    Public Sub New(ByVal column As Integer)
        columnnumber = column
    End Sub
End Class

