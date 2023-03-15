Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsTimerTest" und soll
'''alle clsTimerTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsTimerTest


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
    '''Ein Test für "clsTimer-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsTimerConstructorTest()
        Dim target As clsTimer = New clsTimer
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "setInterval"
    '''</summary>
    <TestMethod()> _
    Public Sub setIntervalTest()
        Dim target As clsTimer = New clsTimer ' TODO: Passenden Wert initialisieren
        Dim tmrBewertung As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim tmrBewertungExpected As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim tmrLive As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim tmrLiveExpected As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim strModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lngInterval As Long = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setInterval(tmrBewertung, tmrLive, strModus, lngInterval)
        Assert.AreEqual(tmrBewertungExpected, tmrBewertung)
        Assert.AreEqual(tmrLiveExpected, tmrLive)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
