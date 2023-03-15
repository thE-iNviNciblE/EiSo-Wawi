Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsHiPerfTimerTest" und soll
'''alle clsHiPerfTimerTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsHiPerfTimerTest


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
    '''Ein Test für "clsHiPerfTimer-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsHiPerfTimerConstructorTest()
        Dim target As clsHiPerfTimer = New clsHiPerfTimer
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "QueryPerformanceCounter"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub QueryPerformanceCounterTest()
        Dim Cntr As Long = 0 ' TODO: Passenden Wert initialisieren
        Dim CntrExpected As Long = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = clsHiPerfTimer_Accessor.QueryPerformanceCounter(Cntr)
        Assert.AreEqual(CntrExpected, Cntr)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "QueryPerformanceFrequency"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub QueryPerformanceFrequencyTest()
        Dim F As Long = 0 ' TODO: Passenden Wert initialisieren
        Dim FExpected As Long = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = clsHiPerfTimer_Accessor.QueryPerformanceFrequency(F)
        Assert.AreEqual(FExpected, F)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StartStop"
    '''</summary>
    <TestMethod()> _
    Public Sub StartStopTest()
        Dim target As clsHiPerfTimer = New clsHiPerfTimer ' TODO: Passenden Wert initialisieren
        Dim expected As TimeSpan = New TimeSpan ' TODO: Passenden Wert initialisieren
        Dim actual As TimeSpan
        actual = target.StartStop
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Running"
    '''</summary>
    <TestMethod()> _
    Public Sub RunningTest()
        Dim target As clsHiPerfTimer = New clsHiPerfTimer ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.Running
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
