Imports System.Windows.Forms

Public Class frmWait4Something

    Public Enum modus
        endlos = 0
        artikel = 1
    End Enum

    Public bModus As modus = modus.artikel
    Public iInervalMax As Integer = 0
    Public iIntervalNow As Integer = 0
    Public strTitle As String
    Public strMessage As String = "kurze Wartepause dann geht es weiter"
    Public itmrInterval As Integer = "0"
    Public iWatPerTick As Integer = 1000
    Public bStopMode As Boolean = False
 
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmWait4Something_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not pgrWait4Something.Value = iInervalMax Then
            bStopMode = True
        End If
    End Sub

    '#####################################################
    '# >> POPUP erzeugen 
    '#####################################################
    Public Function setWait4Somthing(ByVal strWindowTitle As String, ByVal strNachricht As String, ByVal iMaximalwert As Integer, Optional ByVal iIntervalNow1 As Integer = 1, Optional ByVal iWateZeit As Integer = 1000) As Boolean
        Try
            If iMaximalwert = 0 Then
                bModus = modus.endlos
            End If

            iInervalMax = iMaximalwert
            strTitle = strWindowTitle
            strMessage = strNachricht
            iIntervalNow = iIntervalNow1
            iWatPerTick = iWateZeit

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setWait4Somthing")
            Return False
        End Try
    End Function

    Private Sub frmWait4Something_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        tmrCheckStatus.Enabled = False
    End Sub


    Private Sub laden()
        Try
            '# Artikel Modus
            lblMessage.Text = ""
            Application.DoEvents()

            If bModus = modus.artikel Then

                pgrWait4Something.Maximum = iInervalMax
                pgrWait4Something.Style = ProgressBarStyle.Continuous

                tmrCheckStatus.Interval = iWatPerTick
                tmrCheckStatus.Enabled = True
                lblMessage.Text = strMessage
                lblBitteWarten.Visible = True
                Me.Text = strTitle

                If Not itmrInterval = 0 Then
                    tmrCheckStatus.Interval = itmrInterval
                End If
            Else
                pgrWait4Something.Maximum = iInervalMax
                pgrWait4Something.Style = ProgressBarStyle.Marquee
                Application.DoEvents()
                tmrCheckStatus.Interval = iWatPerTick
                tmrCheckStatus.Enabled = True
                lblMessage.Text = strMessage

            End If


        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "frmWait4Something Load")
        End Try
    End Sub
    '#########################################
    '# >> FORM LADEN 
    '#########################################
    Private Sub frmWait4Something_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        laden()
    End Sub

    '##############################
    '# >> Fenster schließen 
    '##############################
    Public Function setCloseWindow() As Boolean
        Me.Close()
    End Function

    '#########################################
    '# >> Template erzeugen  
    '#########################################
    Private Function setVonBisLabel(ByVal strMessage As String) As String
        Dim marker_now As String = "###now###"
        Dim marker_max As String = "###max###"
        Try

            strMessage = strMessage.Replace(marker_now, iIntervalNow)
            strMessage = strMessage.Replace(marker_max, iInervalMax)

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setVonBisLabel")
            Return "-1"
        End Try

        Return strMessage
    End Function

    '# Update Message setzten 
    Public Function setUpdateMessageLabel(ByVal strMessage As String) As Boolean

        lblMessage.Text = strMessage

    End Function
    Public Function setMessage(strMessage As String) As Boolean
        lblBitteWarten.Text = strMessage
    End Function
    '#########################################
    '# >> TIMER ÜBERWACHTUNG 
    '#########################################
    Private Sub tmrCheckStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckStatus.Tick

        If bModus = modus.artikel Then
            '# Globalen Status abfragen            
            pgrWait4Something.Value = iIntervalNow
            Me.lblMessage.Text = setVonBisLabel(strMessage)
            Application.DoEvents()

            '# Prüfen ob Globaler Status mit dem Globalen Ende übereinstimmt 
            If pgrWait4Something.Value = iInervalMax Then
                tmrCheckStatus.Enabled = False
                Me.Dispose(True) ' schließen
            End If
        Else
            Application.DoEvents()
        End If
    End Sub

    Public Function setDoEvents() As Boolean
        'Application.DoEvents()
    End Function
 
End Class
