Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsHotKey_HotKeyObjectTest" und soll
'''alle clsHotKey_HotKeyObjectTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsHotKey_HotKeyObjectTest


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
    '''Ein Test für "HotKeyObject-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsHotKey_HotKeyObjectConstructorTest()
        Dim NewHotKey As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim NewModifier As clsHotKey.MODKEY = New clsHotKey.MODKEY ' TODO: Passenden Wert initialisieren
        Dim NewHotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey.HotKeyObject = New clsHotKey.HotKeyObject(NewHotKey, NewModifier, NewHotKeyID)
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "AtomID"
    '''</summary>
    <TestMethod()> _
    Public Sub AtomIDTest()
        Dim NewHotKey As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim NewModifier As clsHotKey.MODKEY = New clsHotKey.MODKEY ' TODO: Passenden Wert initialisieren
        Dim NewHotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey.HotKeyObject = New clsHotKey.HotKeyObject(NewHotKey, NewModifier, NewHotKeyID) ' TODO: Passenden Wert initialisieren
        Dim expected As Short = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Short
        target.AtomID = expected
        actual = target.AtomID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "HotKey"
    '''</summary>
    <TestMethod()> _
    Public Sub HotKeyTest()
        Dim NewHotKey As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim NewModifier As clsHotKey.MODKEY = New clsHotKey.MODKEY ' TODO: Passenden Wert initialisieren
        Dim NewHotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey.HotKeyObject = New clsHotKey.HotKeyObject(NewHotKey, NewModifier, NewHotKeyID) ' TODO: Passenden Wert initialisieren
        Dim expected As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim actual As Keys
        target.HotKey = expected
        actual = target.HotKey
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "HotKeyID"
    '''</summary>
    <TestMethod()> _
    Public Sub HotKeyIDTest()
        Dim NewHotKey As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim NewModifier As clsHotKey.MODKEY = New clsHotKey.MODKEY ' TODO: Passenden Wert initialisieren
        Dim NewHotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey.HotKeyObject = New clsHotKey.HotKeyObject(NewHotKey, NewModifier, NewHotKeyID) ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.HotKeyID = expected
        actual = target.HotKeyID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Modifier"
    '''</summary>
    <TestMethod()> _
    Public Sub ModifierTest()
        Dim NewHotKey As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim NewModifier As clsHotKey.MODKEY = New clsHotKey.MODKEY ' TODO: Passenden Wert initialisieren
        Dim NewHotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim target As clsHotKey.HotKeyObject = New clsHotKey.HotKeyObject(NewHotKey, NewModifier, NewHotKeyID) ' TODO: Passenden Wert initialisieren
        Dim expected As clsHotKey.MODKEY = New clsHotKey.MODKEY ' TODO: Passenden Wert initialisieren
        Dim actual As clsHotKey.MODKEY
        target.Modifier = expected
        actual = target.Modifier
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
