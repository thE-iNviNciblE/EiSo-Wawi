Public Class clsHotKey
    Implements IMessageFilter

    Private Declare Function RegisterHotKey Lib "user32" ( _
        ByVal Hwnd As IntPtr, _
        ByVal ID As Integer, _
        ByVal Modifiers As Integer, _
        ByVal Key As Integer) _
    As Integer

    Private Declare Function UnregisterHotKey Lib "user32" ( _
        ByVal Hwnd As IntPtr, _
        ByVal ID As Integer) _
    As Integer

    Private Declare Function GlobalAddAtom Lib "kernel32" Alias "GlobalAddAtomA" ( _
        ByVal IDString As String) _
    As Short

    Private Declare Function GlobalDeleteAtom Lib "kernel32" ( _
        ByVal Atom As Short) _
    As Short

    Public Class HotKeyObject
        Private mHotKey As Keys
        Private mModifier As MODKEY
        Private mHotKeyID As String
        Private mAtomID As Short

        Public Property HotKey() As Keys
            Get
                Return mHotKey
            End Get
            Set(ByVal value As Keys)
                mHotKey = value
            End Set
        End Property

        Public Property Modifier() As MODKEY
            Get
                Return mModifier
            End Get
            Set(ByVal value As MODKEY)
                mModifier = value
            End Set
        End Property

        Public Property HotKeyID() As String
            Get
                Return mHotKeyID
            End Get
            Set(ByVal value As String)
                mHotKeyID = value
            End Set
        End Property

        Public Property AtomID() As Short
            Get
                Return mAtomID
            End Get
            Set(ByVal value As Short)
                mAtomID = value
            End Set
        End Property

        Sub New(ByVal NewHotKey As Keys, ByVal NewModifier As MODKEY, ByVal NewHotKeyID As String)
            mHotKey = NewHotKey
            mModifier = NewModifier
            mHotKeyID = NewHotKeyID
        End Sub
    End Class

    Private mForm As Form
    Private Const WM_HOTKEY As Integer = &H312
    Private mHotKeyList As New System.Collections.Generic.Dictionary(Of Short, HotKeyObject)
    Private mHotKeyIDList As New System.Collections.Generic.Dictionary(Of String, Short)

    ''' <summary>
    ''' Diesem Event wird immer die zugewiesene HotKeyID übergeben wenn eine HotKey Kombination gedrückt wurde.
    ''' </summary>
    Public Event HotKeyPressed(ByVal HotKeyID As String)

    Public Enum MODKEY As Integer
        MOD_ALT = 1
        MOD_CONTROL = 2
        MOD_SHIFT = 4
        MOD_WIN = 8
    End Enum

    Sub New(ByVal OwnerForm As Form)
        mForm = OwnerForm
        Application.AddMessageFilter(Me)
    End Sub

    ''' <summary>
    ''' Diese Funktion fügt einen Hotkey hinzu und registriert ihn auch sofort
    ''' </summary>
    ''' <param name="KeyCode">Den KeyCode für die Taste</param>
    ''' <param name="Modifiers">Die Zusatztasten wie z.B. Strg oder Alt, diese können auch mit OR kombiniert werden</param>
    ''' <param name="HotKeyID">Die ID die der Hotkey bekommen soll um diesen zu identifizieren</param>
    Public Sub AddHotKey(ByVal KeyCode As Keys, ByVal Modifiers As MODKEY, ByVal HotKeyID As String)
        If mHotKeyIDList.ContainsKey(HotKeyID) = True Then Exit Sub
        Dim ID As Short = GlobalAddAtom(HotKeyID)
        mHotKeyIDList.Add(HotKeyID, ID)
        mHotKeyList.Add(ID, New HotKeyObject(KeyCode, Modifiers, HotKeyID))
        RegisterHotKey(mForm.Handle, ID, mHotKeyList(ID).Modifier, mHotKeyList(ID).HotKey)
    End Sub

    ''' <summary>
    ''' Diese Funktion entfernt einen Hotkey und deregistriert ihn auch sofort
    ''' </summary>
    ''' <param name="HotKeyID">Gibt die HotkeyID an welche entfernt werden soll</param>
    Public Sub RemoveHotKey(ByVal HotKeyID As String)
        If mHotKeyIDList.ContainsKey(HotKeyID) = False Then Exit Sub
        Dim ID As Short = mHotKeyIDList(HotKeyID)
        mHotKeyIDList.Remove(HotKeyID)
        mHotKeyList.Remove(ID)
        UnregisterHotKey(mForm.Handle, CInt(ID))
        GlobalDeleteAtom(ID)
    End Sub

    Private Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage
         If m.Msg = WM_HOTKEY Then
            RaiseEvent HotKeyPressed(mHotKeyList(CShort(m.WParam)).HotKeyID)
        End If
    End Function
End Class
