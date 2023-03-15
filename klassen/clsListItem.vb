﻿Public Class MyListItem
    Private mText As String
    Private mValue As String

    Public Sub New(ByVal pText As String, ByVal pValue As String)
        mText = pText
        mValue = pValue
    End Sub

    Public ReadOnly Property Text() As String
        Get
            Return mText
        End Get
    End Property

    Public ReadOnly Property Value() As String
        Get
            Return mValue
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return mText
    End Function
End Class