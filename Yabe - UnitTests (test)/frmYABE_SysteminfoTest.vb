Imports System

Imports System.DirectoryServices

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmYABE_SysteminfoTest" und soll
'''alle frmYABE_SysteminfoTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmYABE_SysteminfoTest


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
    '''Ein Test für "frmYABE_Systeminfo-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmYABE_SysteminfoConstructorTest()
        Dim target As frmYABE_Systeminfo = New frmYABE_Systeminfo
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmYABE_Systeminfo_Accessor = New frmYABE_Systeminfo_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmSysteminfo_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmSysteminfo_KeyDownTest()
        Dim target As frmYABE_Systeminfo_Accessor = New frmYABE_Systeminfo_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmSysteminfo_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmSysteminfo_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmSysteminfo_LoadTest()
        Dim target As frmYABE_Systeminfo_Accessor = New frmYABE_Systeminfo_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmSysteminfo_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmYABE_Systeminfo_Accessor = New frmYABE_Systeminfo_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DirectorySearcher1"
    '''</summary>
    <TestMethod()> _
    Public Sub DirectorySearcher1Test()
        Dim target As frmYABE_Systeminfo = New frmYABE_Systeminfo ' TODO: Passenden Wert initialisieren
        Dim expected As DirectorySearcher = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DirectorySearcher
        target.DirectorySearcher1 = expected
        actual = target.DirectorySearcher1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtInfo"
    '''</summary>
    <TestMethod()> _
    Public Sub txtInfoTest()
        Dim target As frmYABE_Systeminfo = New frmYABE_Systeminfo ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtInfo = expected
        actual = target.txtInfo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
