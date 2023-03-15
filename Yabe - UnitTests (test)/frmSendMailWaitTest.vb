Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmSendMailWaitTest" und soll
'''alle frmSendMailWaitTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmSendMailWaitTest


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
    '''Ein Test für "frmSendMailWait-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmSendMailWaitConstructorTest()
        Dim target As frmSendMailWait = New frmSendMailWait
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "Cancel_Button_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Cancel_Button_ClickTest()
        Dim target As frmSendMailWait_Accessor = New frmSendMailWait_Accessor ' TODO: Passenden Wert initialisieren
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
        Dim target As frmSendMailWait_Accessor = New frmSendMailWait_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmSendMailWait_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmSendMailWait_LoadTest()
        Dim target As frmSendMailWait_Accessor = New frmSendMailWait_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmSendMailWait_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmSendMailWait_Accessor = New frmSendMailWait_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OK_Button_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OK_Button_ClickTest()
        Dim target As frmSendMailWait_Accessor = New frmSendMailWait_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OK_Button_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrWait_Tick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub tmrWait_TickTest()
        Dim target As frmSendMailWait_Accessor = New frmSendMailWait_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.tmrWait_Tick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Cancel_Button"
    '''</summary>
    <TestMethod()> _
    Public Sub Cancel_ButtonTest()
        Dim target As frmSendMailWait = New frmSendMailWait ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.Cancel_Button = expected
        actual = target.Cancel_Button
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblMessage"
    '''</summary>
    <TestMethod()> _
    Public Sub lblMessageTest()
        Dim target As frmSendMailWait = New frmSendMailWait ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblMessage = expected
        actual = target.lblMessage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OK_Button"
    '''</summary>
    <TestMethod()> _
    Public Sub OK_ButtonTest()
        Dim target As frmSendMailWait = New frmSendMailWait ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.OK_Button = expected
        actual = target.OK_Button
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "pgrWaitTime"
    '''</summary>
    <TestMethod()> _
    Public Sub pgrWaitTimeTest()
        Dim target As frmSendMailWait = New frmSendMailWait ' TODO: Passenden Wert initialisieren
        Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ProgressBar
        target.pgrWaitTime = expected
        actual = target.pgrWaitTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TableLayoutPanel1"
    '''</summary>
    <TestMethod()> _
    Public Sub TableLayoutPanel1Test()
        Dim target As frmSendMailWait = New frmSendMailWait ' TODO: Passenden Wert initialisieren
        Dim expected As TableLayoutPanel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TableLayoutPanel
        target.TableLayoutPanel1 = expected
        actual = target.TableLayoutPanel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrWait"
    '''</summary>
    <TestMethod()> _
    Public Sub tmrWaitTest()
        Dim target As frmSendMailWait = New frmSendMailWait ' TODO: Passenden Wert initialisieren
        Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Timer
        target.tmrWait = expected
        actual = target.tmrWait
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLastMessage"
    '''</summary>
    <TestMethod()> _
    Public Sub txtLastMessageTest()
        Dim target As frmSendMailWait = New frmSendMailWait ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtLastMessage = expected
        actual = target.txtLastMessage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
