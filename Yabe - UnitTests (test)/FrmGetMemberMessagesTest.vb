Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FrmGetMemberMessagesTest" und soll
'''alle FrmGetMemberMessagesTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FrmGetMemberMessagesTest


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
    '''Ein Test für "FrmGetMemberMessages-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FrmGetMemberMessagesConstructorTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetMemberMessages_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnGetMemberMessages_ClickTest()
        Dim target As FrmGetMemberMessages_Accessor = New FrmGetMemberMessages_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnGetMemberMessages_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FrmGetMemberMessages_Accessor = New FrmGetMemberMessages_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmGetMemberMessages_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmGetMemberMessages_LoadTest()
        Dim target As FrmGetMemberMessages_Accessor = New FrmGetMemberMessages_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmGetMemberMessages_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FrmGetMemberMessages_Accessor = New FrmGetMemberMessages_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetMemberMessages"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnGetMemberMessagesTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnGetMemberMessages = expected
        actual = target.BtnGetMemberMessages
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub CboStatusTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboStatus = expected
        actual = target.CboStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboType"
    '''</summary>
    <TestMethod()> _
    Public Sub CboTypeTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboType = expected
        actual = target.CboType
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ChkPublic"
    '''</summary>
    <TestMethod()> _
    Public Sub ChkPublicTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.ChkPublic = expected
        actual = target.ChkPublic
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ChkStartFrom"
    '''</summary>
    <TestMethod()> _
    Public Sub ChkStartFromTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.ChkStartFrom = expected
        actual = target.ChkStartFrom
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ChkStartTo"
    '''</summary>
    <TestMethod()> _
    Public Sub ChkStartToTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.ChkStartTo = expected
        actual = target.ChkStartTo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmBody"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmBodyTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmBody = expected
        actual = target.ClmBody
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmItemIdTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmItemId = expected
        actual = target.ClmItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmMessageId"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmMessageIdTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmMessageId = expected
        actual = target.ClmMessageId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmSender"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmSenderTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmSender = expected
        actual = target.ClmSender
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmStatusTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmStatus = expected
        actual = target.ClmStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmType"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmTypeTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmType = expected
        actual = target.ClmType
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickStartFrom"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickStartFromTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickStartFrom = expected
        actual = target.DatePickStartFrom
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickStartTo"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickStartToTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickStartTo = expected
        actual = target.DatePickStartTo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpResult"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpResultTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblItemIdTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblItemId = expected
        actual = target.LblItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblMessages"
    '''</summary>
    <TestMethod()> _
    Public Sub LblMessagesTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblMessages = expected
        actual = target.LblMessages
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblStartSep"
    '''</summary>
    <TestMethod()> _
    Public Sub LblStartSepTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblStartSep = expected
        actual = target.LblStartSep
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub LblStatusTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblStatus = expected
        actual = target.LblStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblTimeRange"
    '''</summary>
    <TestMethod()> _
    Public Sub LblTimeRangeTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblTimeRange = expected
        actual = target.LblTimeRange
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblType"
    '''</summary>
    <TestMethod()> _
    Public Sub LblTypeTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblType = expected
        actual = target.LblType
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LstMessages"
    '''</summary>
    <TestMethod()> _
    Public Sub LstMessagesTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.LstMessages = expected
        actual = target.LstMessages
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtItemIdTest()
        Dim target As FrmGetMemberMessages = New FrmGetMemberMessages ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtItemId = expected
        actual = target.TxtItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
