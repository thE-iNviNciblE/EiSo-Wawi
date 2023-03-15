Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmWait4SomethingTest" und soll
'''alle frmWait4SomethingTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmWait4SomethingTest


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
    '''Ein Test für "frmWait4Something-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmWait4SomethingConstructorTest()
        Dim target As frmWait4Something = New frmWait4Something
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "Cancel_Button_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Cancel_Button_ClickTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Cancel_Button_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWait4Something_Disposed"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWait4Something_DisposedTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWait4Something_Disposed(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWait4Something_Leave"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWait4Something_LeaveTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWait4Something_Leave(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmWait4Something_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmWait4Something_LoadTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmWait4Something_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "laden"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ladenTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        target.laden()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setCloseWindow"
    '''</summary>
    <TestMethod()> _
    Public Sub setCloseWindowTest()
        Dim target As frmWait4Something = New frmWait4Something ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCloseWindow
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDoEvents"
    '''</summary>
    <TestMethod()> _
    Public Sub setDoEventsTest()
        Dim target As frmWait4Something = New frmWait4Something ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setDoEvents
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setUpdateMessageLabel"
    '''</summary>
    <TestMethod()> _
    Public Sub setUpdateMessageLabelTest()
        Dim target As frmWait4Something = New frmWait4Something ' TODO: Passenden Wert initialisieren
        Dim strMessage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setUpdateMessageLabel(strMessage)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setVonBisLabel"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setVonBisLabelTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        Dim strMessage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setVonBisLabel(strMessage)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWait4Somthing"
    '''</summary>
    <TestMethod()> _
    Public Sub setWait4SomthingTest()
        Dim target As frmWait4Something = New frmWait4Something ' TODO: Passenden Wert initialisieren
        Dim strWindowTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strNachricht As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iMaximalwert As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iIntervalNow1 As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iWateZeit As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWait4Somthing(strWindowTitle, strNachricht, iMaximalwert, iIntervalNow1, iWateZeit)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrCheckStatus_Tick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub tmrCheckStatus_TickTest()
        Dim target As frmWait4Something_Accessor = New frmWait4Something_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.tmrCheckStatus_Tick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lblMessage"
    '''</summary>
    <TestMethod()> _
    Public Sub lblMessageTest()
        Dim target As frmWait4Something = New frmWait4Something ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblMessage = expected
        actual = target.lblMessage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "pgrWait4Something"
    '''</summary>
    <TestMethod()> _
    Public Sub pgrWait4SomethingTest()
        Dim target As frmWait4Something = New frmWait4Something ' TODO: Passenden Wert initialisieren
        Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ProgressBar
        target.pgrWait4Something = expected
        actual = target.pgrWait4Something
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrCheckStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub tmrCheckStatusTest()
        Dim target As frmWait4Something = New frmWait4Something ' TODO: Passenden Wert initialisieren
        Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Timer
        target.tmrCheckStatus = expected
        actual = target.tmrCheckStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
