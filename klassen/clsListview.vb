Public Class clsListview

    Public strNext As String
    Public strBack As String
    Public btnBack As Button
    Public btnNext As Button
    Public lvw As ListView
    Public iAnzahl As Integer = 0


    '###############################################
    '# >> Listview Back 
    '###############################################
    Public Function setListviewBack() As Boolean
        Try
            iAnzahl -= 1
        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setListviewBack")
            Return False
        End Try

        Return True
    End Function

    '###############################################
    '# >> Listview Algorithmus
    '###############################################
    Public Function setListview() As Boolean
        'Try

        '    If frmManage.lvw.SelectedItems.Count > 0 Then

        '        iAnzahl = frmManage.lvw.SelectedItems(0).Index
        '        iAnzahl += 1
        '        btnBack.Enabled = True

        '        If iAnzahl = frmMain.frmManage.lvw.Items.Count - 1 Then
        '            btnNext.Enabled = False
        '        End If

        '        frmMain.frmManage.lvw.Items(iAnzahl).Selected = True
        '        frmMain.frmManage.lvw.Items(iAnzahl).EnsureVisible()



        '        strNext = frmMain.frmManage.lvw.SelectedItems(0).SubItems(2).Text


        '    End If

        'Catch ex As Exception
        '    Call debug_message(ex,strQuery & vbcrlf & "setListview")
        '    Return False
        'End Try

    End Function

    '###############################################
    '# >> Listview Vorstellen
    '###############################################
    Public Function SetListviewVor() As Boolean
        iAnzahl += 1
    End Function

End Class
