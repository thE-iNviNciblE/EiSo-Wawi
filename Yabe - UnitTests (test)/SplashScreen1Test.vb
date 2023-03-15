Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "SplashScreen1Test" und soll
'''alle SplashScreen1Test Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class SplashScreen1Test


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
    '''Ein Test für "SplashScreen1-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub SplashScreen1ConstructorTest()
        Dim target As SplashScreen1 = New SplashScreen1
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As SplashScreen1_Accessor = New SplashScreen1_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As SplashScreen1_Accessor = New SplashScreen1_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MainLayoutPanel_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MainLayoutPanel_ClickTest()
        Dim target As SplashScreen1_Accessor = New SplashScreen1_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MainLayoutPanel_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MainLayoutPanel_Paint"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MainLayoutPanel_PaintTest()
        Dim target As SplashScreen1_Accessor = New SplashScreen1_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As PaintEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MainLayoutPanel_Paint(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SplashScreen1_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SplashScreen1_LoadTest()
        Dim target As SplashScreen1_Accessor = New SplashScreen1_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SplashScreen1_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrCloseDown_Tick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub tmrCloseDown_TickTest()
        Dim target As SplashScreen1_Accessor = New SplashScreen1_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.tmrCloseDown_Tick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MainLayoutPanel"
    '''</summary>
    <TestMethod()> _
    Public Sub MainLayoutPanelTest()
        Dim target As SplashScreen1 = New SplashScreen1 ' TODO: Passenden Wert initialisieren
        Dim expected As TableLayoutPanel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TableLayoutPanel
        target.MainLayoutPanel = expected
        actual = target.MainLayoutPanel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrCloseDown"
    '''</summary>
    <TestMethod()> _
    Public Sub tmrCloseDownTest()
        Dim target As SplashScreen1 = New SplashScreen1 ' TODO: Passenden Wert initialisieren
        Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Timer
        target.tmrCloseDown = expected
        actual = target.tmrCloseDown
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
