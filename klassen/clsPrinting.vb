Imports YabE.CPrintReportString

Public Class clsPrinting
    Public Sub PrintOrPreviewListView(ByVal Preview As PrintPreview, ByVal ListView1 As ListView)
        ' create a strongly type collection of
        ' printstructure(columns)
        Dim ps As PrintStructureListView
        Dim col As New PrintListViewCollection
        Dim lvwNames() As String

        ReDim lvwNames(ListView1.Columns.Count)
        Dim iCount As Integer

        For iCount = 0 To lvwNames.Length - 2
            lvwNames(iCount) = ListView1.Columns(iCount).Text
        Next

        ' print column 0 of grid
        ps = New PrintStructureListView
        ps.Column = 0
        ps.NumberDataColumnChars = 5
        ps.Alignment = Align.Center
        ps.PrintColumnWidth = 7
        col.Add(ps)

        ' print column 1 of grid
        ps = New PrintStructureListView
        ps.Column = 1
        ps.NumberDataColumnChars = 15
        ps.Alignment = Align.Left
        ps.PrintColumnWidth = 18
        col.Add(ps)

        ' print column 5 of grid
        ps = New PrintStructureListView
        ps.Column = 2
        ps.NumberDataColumnChars = 20
        ps.Alignment = Align.Left
        ps.PrintColumnWidth = 22
        col.Add(ps)

        ps = New PrintStructureListView
        ps.Column = 3
        ps.NumberDataColumnChars = 25
        ps.Alignment = Align.Left
        ps.PrintColumnWidth = 27
        col.Add(ps)

        ps = New PrintStructureListView
        ps.Column = 4
        ps.NumberDataColumnChars = 10
        ps.Alignment = Align.Right
        ps.PrintColumnWidth = 12
        col.Add(ps)

        ' set up print options
        Dim po As New PrintOptions
        po.CharsPerLine = CharsPerLine.CPL80
        po.ColHdr1 = lvwNames(0).PadRight(7) & _
                     lvwNames(1).PadRight(18) & _
                     lvwNames(2).PadRight(22) & _
                     lvwNames(3).PadRight(27) & _
                     lvwNames(4).PadRight(12)
        po.Portrait = PrintOrientation.Portrait
        po.Title = "YABE - Ausdruck"
        po.PrintOrPreview = Preview
        po.SubTitle = "Ausdruck..."
        po.Boxed = True
        po.LeftMarginExtender = MarginExtender.OneHalfInch
        po.RightMarginExtender = MarginExtender.OneHalfInch
        po.TopMarginExtender = MarginExtender.OneHalfInch
        po.BottomMarginExtender = MarginExtender.OneHalfInch


        ' print the grid
        Dim pg As New CPrintGrid
        pg.PrintGrid(ListView1, col, po)

    End Sub


    Public Sub PrintOrPreviewGrid(ByVal Preview As PrintPreview)
        ' create a strongly type collection of
        ' PrintStructureDataGrid(columns)
        Dim ps As PrintStructureDataGrid
        Dim col As New PrintGridCollection
        ' print column 0 of grid
        ps = New PrintStructureDataGrid
        ps.Column = 0
        ps.Format = FormatString.Boolean
        ps.NumberDataColumnChars = 5
        ps.Alignment = Align.Center
        ps.PrintColumnWidth = 7
        col.Add(ps)

        ' print column 1 of grid
        ps = New PrintStructureDataGrid
        ps.Column = 1
        ps.Format = FormatString.Default
        ps.NumberDataColumnChars = 15
        ps.Alignment = Align.Left
        ps.PrintColumnWidth = 18
        col.Add(ps)

        ' print column 5 of grid
        ps = New PrintStructureDataGrid
        ps.Column = 2
        ps.Format = FormatString.DateTime
        ps.NumberDataColumnChars = 23
        ps.Alignment = Align.Left
        ps.PrintColumnWidth = 25
        col.Add(ps)

        ps = New PrintStructureDataGrid
        ps.Column = 5
        ps.Format = FormatString.Currency
        ps.NumberDataColumnChars = 10
        ps.Alignment = Align.Right
        ps.PrintColumnWidth = 12
        col.Add(ps)

        ' set up print options
        Dim po As New PrintOptions
        po.CharsPerLine = CharsPerLine.CPL80
        po.ColHdr1 = "Col 0".PadRight(7) & _
                     "Column 1".PadRight(18) & _
                     "Column 3".PadRight(25) & _
                     "Column 5".PadRight(12)
        po.Portrait = PrintOrientation.Portrait
        po.Title = "My Grid Report"
        po.PrintOrPreview = Preview
        po.SubTitle = "This Report is Grid Columns 0,1,2,5"
        po.Boxed = True
        po.LeftMarginExtender = MarginExtender.OneHalfInch
        po.RightMarginExtender = MarginExtender.OneHalfInch
        po.TopMarginExtender = MarginExtender.OneHalfInch
        po.BottomMarginExtender = MarginExtender.OneHalfInch

        ' print the grid
        Dim pg As New CPrintGrid
        '  Dim dv As DataView = pg.GetDataSource(Me, DataGrid1)
        '   pg.PrintGrid(dt, col, po)

    End Sub
End Class
