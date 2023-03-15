Imports System.Windows.Forms

Public Class frmPopup
    Dim cOpacity As Double '# Durchl‰ssigkeit
    Public strNachricht As String = "Testnachricht" '# Echte Nachricht 
    Dim iDauer As Integer
    Dim cOpactiy_min As Double = 0.2 '# Minimalwert (bis zum schlieﬂen)
    Dim cOpactiy_dec As Double = 0.08 '# Abziehen bei jedem Timer Tick


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Call MP3_Stop("popupsound")
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Call MP3_Stop("popupsound")
        Me.Close()
    End Sub

    Private Sub tmrClosedown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClosedown.Tick

        cOpacity -= cOpactiy_dec
        Me.Opacity = cOpacity

        If cOpacity <= cOpactiy_min Then
            Call MP3_Stop("popupsound")
            Me.Close()
        End If

    End Sub

    Private Sub frmPopup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Call MP3_Stop("popupsound")
        Me.Close()
    End Sub

    Private Sub frmPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DesktopSize As System.Drawing.Rectangle
        cOpacity = Me.Opacity
        Me.lblNachricht.Text = Me.strNachricht
        DesktopSize = My.Computer.Screen.WorkingArea
        'MsgBox(My.Computer.Screen.Bounds.ToString)
        Me.SetDesktopLocation(DesktopSize.Width - Me.Width, DesktopSize.Height - Me.Height)
    End Sub

    Private Sub frmPopup_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        Me.BackColor = Color.Aquamarine
    End Sub

    Private Sub frmPopup_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackColor = Color.WhiteSmoke
    End Sub
End Class
