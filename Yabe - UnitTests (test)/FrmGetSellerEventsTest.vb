Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FrmGetSellerEventsTest" und soll
'''alle FrmGetSellerEventsTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FrmGetSellerEventsTest


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
    '''Ein Test für "FrmGetSellerEvents-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FrmGetSellerEventsConstructorTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetSellerEvents_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnGetSellerEvents_ClickTest()
        Dim target As FrmGetSellerEvents_Accessor = New FrmGetSellerEvents_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnGetSellerEvents_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FrmGetSellerEvents_Accessor = New FrmGetSellerEvents_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmGetSellerList_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmGetSellerList_LoadTest()
        Dim target As FrmGetSellerEvents_Accessor = New FrmGetSellerEvents_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmGetSellerList_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FrmGetSellerEvents_Accessor = New FrmGetSellerEvents_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OptEndTime_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OptEndTime_CheckedChangedTest()
        Dim target As FrmGetSellerEvents_Accessor = New FrmGetSellerEvents_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OptEndTime_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OptModTime_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OptModTime_CheckedChangedTest()
        Dim target As FrmGetSellerEvents_Accessor = New FrmGetSellerEvents_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OptModTime_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OptStartTime_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OptStartTime_CheckedChangedTest()
        Dim target As FrmGetSellerEvents_Accessor = New FrmGetSellerEvents_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OptStartTime_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetSellerEvents"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnGetSellerEventsTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnGetSellerEvents = expected
        actual = target.BtnGetSellerEvents
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ChkIncludeNew"
    '''</summary>
    <TestMethod()> _
    Public Sub ChkIncludeNewTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.ChkIncludeNew = expected
        actual = target.ChkIncludeNew
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmBids"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmBidsTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmBids = expected
        actual = target.ClmBids
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmItemIdTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmItemId = expected
        actual = target.ClmItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmPrice"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmPriceTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmPrice = expected
        actual = target.ClmPrice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmSold"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmSoldTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmSold = expected
        actual = target.ClmSold
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmStatusTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmStatus = expected
        actual = target.ClmStatus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmTitleTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmTitle = expected
        actual = target.ClmTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickEndFrom"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickEndFromTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickEndFrom = expected
        actual = target.DatePickEndFrom
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickEndTo"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickEndToTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickEndTo = expected
        actual = target.DatePickEndTo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickModFrom"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickModFromTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickModFrom = expected
        actual = target.DatePickModFrom
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickModTo"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickModToTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickModTo = expected
        actual = target.DatePickModTo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickStartFrom"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickStartFromTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
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
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpResult = expected
        actual = target.GrpResult
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblEndSep"
    '''</summary>
    <TestMethod()> _
    Public Sub LblEndSepTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblEndSep = expected
        actual = target.LblEndSep
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblModSep"
    '''</summary>
    <TestMethod()> _
    Public Sub LblModSepTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblModSep = expected
        actual = target.LblModSep
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblStartSep"
    '''</summary>
    <TestMethod()> _
    Public Sub LblStartSepTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblStartSep = expected
        actual = target.LblStartSep
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblUserId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblUserIdTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblUserId = expected
        actual = target.LblUserId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LstEvents"
    '''</summary>
    <TestMethod()> _
    Public Sub LstEventsTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.LstEvents = expected
        actual = target.LstEvents
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OptEndTime"
    '''</summary>
    <TestMethod()> _
    Public Sub OptEndTimeTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.OptEndTime = expected
        actual = target.OptEndTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OptModTime"
    '''</summary>
    <TestMethod()> _
    Public Sub OptModTimeTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.OptModTime = expected
        actual = target.OptModTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OptStartTime"
    '''</summary>
    <TestMethod()> _
    Public Sub OptStartTimeTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.OptStartTime = expected
        actual = target.OptStartTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtUserID"
    '''</summary>
    <TestMethod()> _
    Public Sub txtUserIDTest()
        Dim target As FrmGetSellerEvents = New FrmGetSellerEvents ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtUserID = expected
        actual = target.txtUserID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
