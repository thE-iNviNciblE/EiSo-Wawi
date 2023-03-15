Public Class clsHiPerfTimer
    Private Declare Function QueryPerformanceFrequency _
        Lib "kernel32" (ByRef F As Long) As Integer

    Private Declare Function QueryPerformanceCounter _
        Lib "kernel32" (ByRef Cntr As Long) As Integer

    Private Const mClassName As String = _
                  "clsHiPerfTimer"

    Private mFreq As Long
    Private mRunning As Boolean
    Private mStartValue As Long
    Private mStopValue As Long

    Public ReadOnly Property Running() As Boolean
        Get
            Running = mRunning
        End Get
    End Property


    Public Sub New()
        Dim Ret As Integer = QueryPerformanceFrequency(mFreq)
        If Ret = 0 Then
            Throw New Exception(mClassName & "_New" & _
                          ControlChars.CrLf & _
                          "High performance counter not available!")
        End If
    End Sub

    Public Function StartStop() As TimeSpan
        Dim Duration As TimeSpan
        If mRunning Then
            QueryPerformanceCounter(mStopValue)
            Duration = TimeSpan.FromSeconds((mStopValue - mStartValue) / mFreq)
        Else
            QueryPerformanceCounter(mStartValue)
            Duration = New TimeSpan(0)
        End If
        mRunning = Not mRunning
        Return Duration
    End Function
End Class
