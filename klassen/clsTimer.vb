'##############################################################
'# >> Klasse zum Steuern der Zeitabläufe 
'#
'#
'#
'##############################################################
Public Class clsTimer

    Public Structure timeModus
        Dim lngLive As Long
        Dim bLiveEnabled As Boolean
        Dim lngBewertung As Long
        Dim bBewertung As Boolean
    End Structure

    Public strINI_TimeModus As timeModus

    '################################################################
    '# >> Setzt Intervale auf den Zeitplan 
    '################################################################
    Public Function setInterval(ByRef tmrBewertung As Timer, ByRef tmrLive As Timer, ByVal strModus As String, ByVal lngInterval As Long) As Boolean
        Try

            Select Case strModus

                Case "Bewertung"
                    strINI_TimeModus.lngBewertung = lngInterval
                    tmrBewertung.Interval = strINI_TimeModus.lngBewertung

                    If strINI_TimeModus.bBewertung = False Then
                        tmrBewertung.Enabled = True
                        strINI_TimeModus.bBewertung = True
                    Else
                        tmrBewertung.Enabled = False
                        strINI_TimeModus.bBewertung = False
                    End If

                Case "Liveansicht"
                    strINI_TimeModus.lngLive = lngInterval
                    tmrLive.Interval = strINI_TimeModus.lngLive

                    If strINI_TimeModus.bLiveEnabled = False Then
                        tmrLive.Enabled = True
                        strINI_TimeModus.bLiveEnabled = True
                    Else
                        tmrLive.Enabled = False
                        strINI_TimeModus.bLiveEnabled = False
                    End If
            End Select

        Catch ex As Exception
            Call debug_message(ex, strQuery & vbCrLf & "setInterval")
            Return False
        End Try

        Return True
    End Function

End Class
