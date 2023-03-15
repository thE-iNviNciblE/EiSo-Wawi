Imports System.Windows.Forms

Public Class frmSendMailWait

    Public Enum modus
        email = 0
    End Enum

    Public lngWaitTime As Long = 300000 ' 5 Minuten per Default 
    Public strMessage As String
    Public strmodus As modus


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

        If strmodus = modus.email Then
            frmMain.frmManage.chkDebug_email.Checked = False
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSendMailWait_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMessage.Text = "Wartezeit:" & ((lngWaitTime / 1000) / 60) & " Minuten"
        pgrWaitTime.Maximum = (lngWaitTime / 1000 / 60)
        tmrWait.Start()

    End Sub

    '###################################################
    '# >> Wartefenster 
    '###################################################
    Private Sub tmrWait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWait.Tick
        Try

            If pgrWaitTime.Value = pgrWaitTime.Maximum Then
                lblMessage.Text = "Beendet"

                tmrWait.Stop()
                frmMain.frmManage.clsMailing.bIsWating = False
                Me.Close()
            Else
                pgrWaitTime.Value += 1000
                lngWaitTime -= 1000

                lblMessage.Text = "Wartezeit:" & lngWaitTime & " Sekunden"
            End If

        Catch ex As Exception
            Call timer_stop()
            Call debug_message(ex, strQuery & vbCrLf & "tmrWait_Tick")
        End Try

    End Sub
    Private Sub timer_stop()
        tmrWait.Stop()
    End Sub
End Class
