Public Class frmBildvorschau
    Public strPfad As String = ""
    Private Sub frmBildvorschau_Leave(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PointToClient(MousePosition).X < Me.Size.Width AndAlso PointToClient(MousePosition).X > -1 AndAlso PointToClient(MousePosition).Y < Me.Size.Height AndAlso PointToClient(MousePosition).Y > -1 Then

            'Mouse is inside the form

        Else

            Me.Close()

        End If
    End Sub

    Private Sub frmBildvorschau_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If strPfad.Length > 0 Then

            If IO.File.Exists(strPfad) = True Then
                Try
                    PictureBox1.Image = Image.FromFile(strPfad)
                Catch ex As Exception

                End Try

                Dim pos_point As New Point
                pos_point = Windows.Forms.Cursor.Position


                pos_point.X -= 20
                pos_point.Y -= 40

                Me.Location = pos_point

            End If
        End If

    End Sub

    Private Sub frmBildvorschau_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.Close()
    End Sub
End Class