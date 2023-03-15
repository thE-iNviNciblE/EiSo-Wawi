Public Class frmOutlook_message_read

    Public lvwDataInput As ListView

    Private Sub txtOutlookEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOutlookEmail.KeyDown
        If e.KeyCode = Keys.Execute Then
            Me.Close()
        End If
    End Sub

    Private Sub txtOutlookEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOutlookEmail.KeyPress

    End Sub

    Private Sub frmOutlook_message_read_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Function getFormData() As Boolean
        Try

            Select Case lvwDataInput.Name
                Case "lvwOutlook_items"
                    If lvwDataInput.SelectedItems.Count > 0 Then
                        If lvwDataInput.SelectedItems(0).SubItems(4).Text.Length > 10 Then
                            lblTitel.Text = lvwDataInput.SelectedItems(0).SubItems(3).Text
                            txtOutlookEmail.Text = lvwDataInput.SelectedItems(0).SubItems(4).Text

                        End If
                    End If


            End Select


            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then
 
            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False

            iAnzahl += 1
            btnVor.Enabled = True

            If iAnzahl = lvwDataInput.Items.Count Then
                btnVor.Enabled = False
            Else
                btnVor.Enabled = True
            End If

            Try
                lvwDataInput.Items(iAnzahl).Selected = True
                lvwDataInput.Items(iAnzahl).EnsureVisible()
            Catch ex As Exception
                lvwDataInput.Items(iAnzahl - 1).Selected = True
                btnVor.Enabled = False
            End Try


            Call getFormData()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0

        If lvwDataInput.SelectedItems.Count > 0 Then


            iAnzahl = lvwDataInput.SelectedItems(0).Index
            lvwDataInput.Items(iAnzahl).Selected = False
            iAnzahl -= 1
            btnBack.Enabled = True

            If iAnzahl = 0 Then
                btnVor.Enabled = False
                Exit Sub
            Else
                btnVor.Enabled = True
            End If


            Try
                lvwDataInput.Items(iAnzahl).Selected = True
                lvwDataInput.Items(iAnzahl).EnsureVisible()
            Catch ex As Exception
                btnVor.Enabled = False
                lvwDataInput.Items(iAnzahl + 1).Selected = True
            End Try

            Call getFormData()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class