Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "starup_wizardTest" und soll
'''alle starup_wizardTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class starup_wizardTest


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
    '''Ein Test für "starup_wizard-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub starup_wizardConstructorTest()
        Dim target As starup_wizard = New starup_wizard
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btneBay_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btneBay_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btneBay_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btneBayToken_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btneBayToken_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btneBayToken_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnEmail_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnEmail_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnEmail_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnLogin_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnLogin_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnLogin_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnNewUser_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnNewUser_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnNewUser_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSchließen_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnSchließen_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnSchließen_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnServer_anlegen_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnServer_anlegen_Click_1Test()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnServer_anlegen_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSMTPAnbieter_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbSMTPAnbieter_SelectedIndexChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbSMTPAnbieter_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getWMI_CPU"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getWMI_CPUTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getWMI_CPU
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getWMI_HDD_Serial"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getWMI_HDD_SerialTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getWMI_HDD_Serial
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getWMI_KeyCode"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getWMI_KeyCodeTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getWMI_KeyCode
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ProblemMeldenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ProblemMeldenToolStripMenuItem_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ProblemMeldenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewDB"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setNewDBTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim strKey As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewDB(strKey)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewDB_main"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setNewDB_mainTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        target.setNewDB_main()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewDB_User"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setNewDB_UserTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim strKey As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewDB_User(strKey)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewUser_yabe"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setNewUser_yabeTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim strkey As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strUser As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strPWD As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewUser_yabe(strkey, strUser, strPWD)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "starup_wizard_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub starup_wizard_LoadTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.starup_wizard_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TestToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TestToolStripMenuItem_ClickTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TestToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddEmail_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddEmail_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddEmail_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddLand_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddLand_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddLand_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddNachname_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddNachname_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddNachname_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddOrt_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddOrt_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddOrt_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddPLZ_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddPLZ_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddPLZ_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddStrasse_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddStrasse_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddStrasse_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddTelefon_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddTelefon_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddTelefon_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddVorname_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtAddVorname_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtAddVorname_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBay_pwd_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txteBay_pwd_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txteBay_pwd_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBay_user_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txteBay_user_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txteBay_user_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBayToken_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txteBayToken_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txteBayToken_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPasswort_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtPasswort_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtPasswort_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtUsername_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtUsername_TextChangedTest()
        Dim target As starup_wizard_Accessor = New starup_wizard_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtUsername_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ApplicationIDToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ApplicationIDToolStripMenuItemTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ApplicationIDToolStripMenuItem = expected
        actual = target.ApplicationIDToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btneBay"
    '''</summary>
    <TestMethod()> _
    Public Sub btneBayTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btneBay = expected
        actual = target.btneBay
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btneBayToken"
    '''</summary>
    <TestMethod()> _
    Public Sub btneBayTokenTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btneBayToken = expected
        actual = target.btneBayToken
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnEmail"
    '''</summary>
    <TestMethod()> _
    Public Sub btnEmailTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnEmail = expected
        actual = target.btnEmail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnLogin"
    '''</summary>
    <TestMethod()> _
    Public Sub btnLoginTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnLogin = expected
        actual = target.btnLogin
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnNewUser"
    '''</summary>
    <TestMethod()> _
    Public Sub btnNewUserTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnNewUser = expected
        actual = target.btnNewUser
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSchließen"
    '''</summary>
    <TestMethod()> _
    Public Sub btnSchließenTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnSchließen = expected
        actual = target.btnSchließen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnServer_anlegen"
    '''</summary>
    <TestMethod()> _
    Public Sub btnServer_anlegenTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnServer_anlegen = expected
        actual = target.btnServer_anlegen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSMTPAnbieter"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbSMTPAnbieterTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbSMTPAnbieter = expected
        actual = target.cmbSMTPAnbieter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label10"
    '''</summary>
    <TestMethod()> _
    Public Sub Label10Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label10 = expected
        actual = target.Label10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label11"
    '''</summary>
    <TestMethod()> _
    Public Sub Label11Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label11 = expected
        actual = target.Label11
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label12"
    '''</summary>
    <TestMethod()> _
    Public Sub Label12Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label12 = expected
        actual = target.Label12
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label13"
    '''</summary>
    <TestMethod()> _
    Public Sub Label13Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label13 = expected
        actual = target.Label13
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label14"
    '''</summary>
    <TestMethod()> _
    Public Sub Label14Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label14 = expected
        actual = target.Label14
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label15"
    '''</summary>
    <TestMethod()> _
    Public Sub Label15Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label15 = expected
        actual = target.Label15
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label16"
    '''</summary>
    <TestMethod()> _
    Public Sub Label16Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label16 = expected
        actual = target.Label16
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label17"
    '''</summary>
    <TestMethod()> _
    Public Sub Label17Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label17 = expected
        actual = target.Label17
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label18"
    '''</summary>
    <TestMethod()> _
    Public Sub Label18Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label18 = expected
        actual = target.Label18
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label19"
    '''</summary>
    <TestMethod()> _
    Public Sub Label19Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label19 = expected
        actual = target.Label19
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label2"
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label20"
    '''</summary>
    <TestMethod()> _
    Public Sub Label20Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label20 = expected
        actual = target.Label20
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label21"
    '''</summary>
    <TestMethod()> _
    Public Sub Label21Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label21 = expected
        actual = target.Label21
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label22"
    '''</summary>
    <TestMethod()> _
    Public Sub Label22Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label22 = expected
        actual = target.Label22
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label23"
    '''</summary>
    <TestMethod()> _
    Public Sub Label23Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label23 = expected
        actual = target.Label23
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label24"
    '''</summary>
    <TestMethod()> _
    Public Sub Label24Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label24 = expected
        actual = target.Label24
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label25"
    '''</summary>
    <TestMethod()> _
    Public Sub Label25Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label25 = expected
        actual = target.Label25
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label26"
    '''</summary>
    <TestMethod()> _
    Public Sub Label26Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label26 = expected
        actual = target.Label26
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label27"
    '''</summary>
    <TestMethod()> _
    Public Sub Label27Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label27 = expected
        actual = target.Label27
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label28"
    '''</summary>
    <TestMethod()> _
    Public Sub Label28Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label28 = expected
        actual = target.Label28
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label29"
    '''</summary>
    <TestMethod()> _
    Public Sub Label29Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label29 = expected
        actual = target.Label29
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label3"
    '''</summary>
    <TestMethod()> _
    Public Sub Label3Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label3 = expected
        actual = target.Label3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label30"
    '''</summary>
    <TestMethod()> _
    Public Sub Label30Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label30 = expected
        actual = target.Label30
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label31"
    '''</summary>
    <TestMethod()> _
    Public Sub Label31Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label31 = expected
        actual = target.Label31
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label32"
    '''</summary>
    <TestMethod()> _
    Public Sub Label32Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label32 = expected
        actual = target.Label32
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label4"
    '''</summary>
    <TestMethod()> _
    Public Sub Label4Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label4 = expected
        actual = target.Label4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label5"
    '''</summary>
    <TestMethod()> _
    Public Sub Label5Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label5 = expected
        actual = target.Label5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label50"
    '''</summary>
    <TestMethod()> _
    Public Sub Label50Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label50 = expected
        actual = target.Label50
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label57"
    '''</summary>
    <TestMethod()> _
    Public Sub Label57Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label57 = expected
        actual = target.Label57
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label6"
    '''</summary>
    <TestMethod()> _
    Public Sub Label6Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label6 = expected
        actual = target.Label6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label7"
    '''</summary>
    <TestMethod()> _
    Public Sub Label7Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label7 = expected
        actual = target.Label7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label8"
    '''</summary>
    <TestMethod()> _
    Public Sub Label8Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label8 = expected
        actual = target.Label8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label9"
    '''</summary>
    <TestMethod()> _
    Public Sub Label9Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label9 = expected
        actual = target.Label9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lstServerMessage"
    '''</summary>
    <TestMethod()> _
    Public Sub lstServerMessageTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As ListBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListBox
        target.lstServerMessage = expected
        actual = target.lstServerMessage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub MenuStrip1Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As MenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As MenuStrip
        target.MenuStrip1 = expected
        actual = target.MenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Panel1"
    '''</summary>
    <TestMethod()> _
    Public Sub Panel1Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Panel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ProblemMeldenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ProblemMeldenToolStripMenuItemTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ProblemMeldenToolStripMenuItem = expected
        actual = target.ProblemMeldenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TabControl1"
    '''</summary>
    <TestMethod()> _
    Public Sub TabControl1Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabControl
        target.TabControl1 = expected
        actual = target.TabControl1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tb_ebay"
    '''</summary>
    <TestMethod()> _
    Public Sub tb_ebayTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tb_ebay = expected
        actual = target.tb_ebay
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tb_mail"
    '''</summary>
    <TestMethod()> _
    Public Sub tb_mailTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tb_mail = expected
        actual = target.tb_mail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tb_schließen"
    '''</summary>
    <TestMethod()> _
    Public Sub tb_schließenTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tb_schließen = expected
        actual = target.tb_schließen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tb_server"
    '''</summary>
    <TestMethod()> _
    Public Sub tb_serverTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tb_server = expected
        actual = target.tb_server
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tb_user"
    '''</summary>
    <TestMethod()> _
    Public Sub tb_userTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.tb_user = expected
        actual = target.tb_user
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TestToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub TestToolStripMenuItemTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.TestToolStripMenuItem = expected
        actual = target.TestToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolTip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolTip1Test()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As ToolTip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolTip
        target.ToolTip1 = expected
        actual = target.ToolTip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddEmail"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddEmailTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddEmail = expected
        actual = target.txtAddEmail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddLand"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddLandTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddLand = expected
        actual = target.txtAddLand
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddNachname"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddNachnameTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddNachname = expected
        actual = target.txtAddNachname
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddOrt"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddOrtTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddOrt = expected
        actual = target.txtAddOrt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddPLZ"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddPLZTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddPLZ = expected
        actual = target.txtAddPLZ
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddShop"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddShopTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddShop = expected
        actual = target.txtAddShop
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddStrasse"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddStrasseTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddStrasse = expected
        actual = target.txtAddStrasse
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddTelefon"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddTelefonTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddTelefon = expected
        actual = target.txtAddTelefon
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAddVorname"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAddVornameTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAddVorname = expected
        actual = target.txtAddVorname
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBay_pwd"
    '''</summary>
    <TestMethod()> _
    Public Sub txteBay_pwdTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txteBay_pwd = expected
        actual = target.txteBay_pwd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBay_user"
    '''</summary>
    <TestMethod()> _
    Public Sub txteBay_userTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txteBay_user = expected
        actual = target.txteBay_user
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txteBayToken"
    '''</summary>
    <TestMethod()> _
    Public Sub txteBayTokenTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txteBayToken = expected
        actual = target.txteBayToken
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmail_pwd"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEmail_pwdTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEmail_pwd = expected
        actual = target.txtEmail_pwd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmail_User"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEmail_UserTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEmail_User = expected
        actual = target.txtEmail_User
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMYSQL_PWD"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMYSQL_PWDTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMYSQL_PWD = expected
        actual = target.txtMYSQL_PWD
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMYSQL_USER"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMYSQL_USERTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMYSQL_USER = expected
        actual = target.txtMYSQL_USER
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPasswort"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPasswortTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPasswort = expected
        actual = target.txtPasswort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPOP3Port"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPOP3PortTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPOP3Port = expected
        actual = target.txtPOP3Port
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtPOP3Server"
    '''</summary>
    <TestMethod()> _
    Public Sub txtPOP3ServerTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtPOP3Server = expected
        actual = target.txtPOP3Server
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSMTPPort"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSMTPPortTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSMTPPort = expected
        actual = target.txtSMTPPort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtSMTPServer"
    '''</summary>
    <TestMethod()> _
    Public Sub txtSMTPServerTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtSMTPServer = expected
        actual = target.txtSMTPServer
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtUsername"
    '''</summary>
    <TestMethod()> _
    Public Sub txtUsernameTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtUsername = expected
        actual = target.txtUsername
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "V054BetaToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub V054BetaToolStripMenuItemTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.V054BetaToolStripMenuItem = expected
        actual = target.V054BetaToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "yabe_dashboard_header"
    '''</summary>
    <TestMethod()> _
    Public Sub yabe_dashboard_headerTest()
        Dim target As starup_wizard = New starup_wizard ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.yabe_dashboard_header = expected
        actual = target.yabe_dashboard_header
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
