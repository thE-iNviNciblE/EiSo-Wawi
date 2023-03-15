Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsHotKeyTest" und soll
'''alle clsHotKeyTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsHotKeyTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Ruft den Testkontext auf, der Informationen
    '''über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Zusätzliche Testattribute"
    '
    'Sie können beim Verfassen Ihrer Tests die folgenden zusätzlichen Attribute verwenden:
    '
    'Mit ClassInitialize führen Sie Code aus, bevor Sie den ersten Test in der Klasse ausführen.
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Mit ClassCleanup führen Sie Code aus, nachdem alle Tests in einer Klasse ausgeführt wurden.
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen.
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''Ein Test für "clsHotKey-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsHotKeyConstructorTest()
        Dim OwnerForm As Form = Nothing ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey = New clsHotKey(OwnerForm)
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "AddHotKey"
    '''</summary>
    <TestMethod()> _
    Public Sub AddHotKeyTest()
        Dim OwnerForm As Form = Nothing ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey = New clsHotKey(OwnerForm) ' TODO: Passenden Wert initialisieren
        Dim KeyCode As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim Modifiers As clsHotKey.MODKEY = New clsHotKey.MODKEY ' TODO: Passenden Wert initialisieren
        Dim HotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.AddHotKey(KeyCode, Modifiers, HotKeyID)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "GlobalAddAtom"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub GlobalAddAtomTest()
        Dim IDString As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim IDStringExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Short = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Short
        actual = clsHotKey_Accessor.GlobalAddAtom(IDString)
        Assert.AreEqual(IDStringExpected, IDString)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GlobalDeleteAtom"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub GlobalDeleteAtomTest()
        Dim Atom As Short = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Short = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Short
        actual = clsHotKey_Accessor.GlobalDeleteAtom(Atom)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PreFilterMessage"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub PreFilterMessageTest()
        Dim OwnerForm As Form = Nothing ' TODO: Passenden Wert initialisieren
        Dim target As IMessageFilter = New clsHotKey(OwnerForm) ' TODO: Passenden Wert initialisieren
        Dim m As Message = New Message ' TODO: Passenden Wert initialisieren
        Dim mExpected As Message = New Message ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.PreFilterMessage(m)
        Assert.AreEqual(mExpected, m)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "RegisterHotKey"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub RegisterHotKeyTest()
        Dim Hwnd As IntPtr = New IntPtr ' TODO: Passenden Wert initialisieren
        Dim ID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim Modifiers As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim Key As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = clsHotKey_Accessor.RegisterHotKey(Hwnd, ID, Modifiers, Key)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "RemoveHotKey"
    '''</summary>
    <TestMethod()> _
    Public Sub RemoveHotKeyTest()
        Dim OwnerForm As Form = Nothing ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey = New clsHotKey(OwnerForm) ' TODO: Passenden Wert initialisieren
        Dim HotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.RemoveHotKey(HotKeyID)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "UnregisterHotKey"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub UnregisterHotKeyTest()
        Dim Hwnd As IntPtr = New IntPtr ' TODO: Passenden Wert initialisieren
        Dim ID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = clsHotKey_Accessor.UnregisterHotKey(Hwnd, ID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
