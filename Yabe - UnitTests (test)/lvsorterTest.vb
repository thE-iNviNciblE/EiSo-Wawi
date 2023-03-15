Imports System.Collections

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "lvsorterTest" und soll
'''alle lvsorterTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class lvsorterTest


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
    '''Ein Test für "lvsorter`1-Konstruktor"
    '''</summary>
    Public Sub lvsorterConstructorTestHelper(Of T As IComparable)()
        Dim column As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim target As lvsorter(Of T) = New lvsorter(Of T)(column)
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    <TestMethod()> _
    Public Sub lvsorterConstructorTest()
        lvsorterConstructorTestHelper(Of GenericParameterHelper)()
    End Sub

    '''<summary>
    '''Ein Test für "Compare"
    '''</summary>
    Public Sub CompareTestHelper(Of T As IComparable)()
        Dim column As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim target As IComparer = New lvsorter(Of T)(column) ' TODO: Passenden Wert initialisieren
        Dim x As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim y As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.Compare(x, y)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    <TestMethod()> _
    Public Sub CompareTest()
        CompareTestHelper(Of GenericParameterHelper)()
    End Sub
End Class
