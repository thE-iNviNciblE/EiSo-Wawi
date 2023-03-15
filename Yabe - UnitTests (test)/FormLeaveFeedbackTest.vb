Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FormLeaveFeedbackTest" und soll
'''alle FormLeaveFeedbackTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FormLeaveFeedbackTest


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
    '''Ein Test für "FormLeaveFeedback-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FormLeaveFeedbackConstructorTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnBack_ClickTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnBack_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnExternalProfil_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnExternalProfil_ClickTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnExternalProfil_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnLeaveFeedback_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnLeaveFeedback_ClickTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnLeaveFeedback_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnVor_ClickTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnVor_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FormLeaveFeedback_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FormLeaveFeedback_KeyDownTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FormLeaveFeedback_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmLeaveFeedback_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmLeaveFeedback_LoadTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmLeaveFeedback_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFeedbackAbgeben_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtFeedbackAbgeben_KeyDownTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtFeedbackAbgeben_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFeedbackAbgeben_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtFeedbackAbgeben_TextChangedTest()
        Dim target As FormLeaveFeedback_Accessor = New FormLeaveFeedback_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtFeedbackAbgeben_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnBack"
    '''</summary>
    <TestMethod()> _
    Public Sub btnBackTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnBack = expected
        actual = target.btnBack
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnExternalProfil"
    '''</summary>
    <TestMethod()> _
    Public Sub btnExternalProfilTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnExternalProfil = expected
        actual = target.btnExternalProfil
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnLeaveFeedback"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnLeaveFeedbackTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnLeaveFeedback = expected
        actual = target.BtnLeaveFeedback
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnVor"
    '''</summary>
    <TestMethod()> _
    Public Sub btnVorTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnVor = expected
        actual = target.btnVor
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboType"
    '''</summary>
    <TestMethod()> _
    Public Sub CboTypeTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboType = expected
        actual = target.CboType
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GroupBox1"
    '''</summary>
    <TestMethod()> _
    Public Sub GroupBox1Test()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GroupBox1 = expected
        actual = target.GroupBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpResult"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpResultTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpResult = expected
        actual = target.GrpResult
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblComments"
    '''</summary>
    <TestMethod()> _
    Public Sub LblCommentsTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblComments = expected
        actual = target.LblComments
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblDuration"
    '''</summary>
    <TestMethod()> _
    Public Sub LblDurationTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblDuration = expected
        actual = target.LblDuration
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblItemIdTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblItemId = expected
        actual = target.LblItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub LblStatusTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblStatus = expected
        actual = target.LblStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblTransactionId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblTransactionIdTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblTransactionId = expected
        actual = target.LblTransactionId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblUserId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblUserIdTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblUserId = expected
        actual = target.LblUserId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PictureBox1"
    '''</summary>
    <TestMethod()> _
    Public Sub PictureBox1Test()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As PictureBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As PictureBox
        target.PictureBox1 = expected
        actual = target.PictureBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtComments"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtCommentsTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtComments = expected
        actual = target.TxtComments
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtFeedbackAbgeben"
    '''</summary>
    <TestMethod()> _
    Public Sub txtFeedbackAbgebenTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtFeedbackAbgeben = expected
        actual = target.txtFeedbackAbgeben
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtItemIdTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtItemId = expected
        actual = target.TxtItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtStatusTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtStatus = expected
        actual = target.TxtStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtTransactionId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtTransactionIdTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtTransactionId = expected
        actual = target.TxtTransactionId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtUserId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtUserIdTest()
        Dim target As FormLeaveFeedback = New FormLeaveFeedback ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtUserId = expected
        actual = target.TxtUserId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
