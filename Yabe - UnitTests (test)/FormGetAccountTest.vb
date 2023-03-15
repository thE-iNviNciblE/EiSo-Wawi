Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FormGetAccountTest" und soll
'''alle FormGetAccountTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FormGetAccountTest


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
    '''Ein Test für "FormGetAccount-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FormGetAccountConstructorTest()
        Dim target As FormGetAccount = New FormGetAccount
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetAccount_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnGetAccount_ClickTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnGetAccount_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FormGetAccount_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FormGetAccount_KeyDownTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FormGetAccount_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FormGetAccount_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FormGetAccount_LoadTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FormGetAccount_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OptInvoiceDate_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OptInvoiceDate_CheckedChangedTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OptInvoiceDate_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OptLastInvoice_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OptLastInvoice_CheckedChangedTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OptLastInvoice_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OptRange_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OptRange_CheckedChangedTest()
        Dim target As FormGetAccount_Accessor = New FormGetAccount_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OptRange_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnGetAccount"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnGetAccountTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnGetAccount = expected
        actual = target.BtnGetAccount
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmBalance"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmBalanceTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmBalance = expected
        actual = target.ClmBalance
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmDate"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmDateTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmDate = expected
        actual = target.ClmDate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmItemId"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmItemIdTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmItemId = expected
        actual = target.ClmItemId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmRef"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmRefTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmRef = expected
        actual = target.ClmRef
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "clmTitel"
    '''</summary>
    <TestMethod()> _
    Public Sub clmTitelTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.clmTitel = expected
        actual = target.clmTitel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ClmType"
    '''</summary>
    <TestMethod()> _
    Public Sub ClmTypeTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ClmType = expected
        actual = target.ClmType
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickFrom"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickFromTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickFrom = expected
        actual = target.DatePickFrom
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickInvoice"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickInvoiceTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickInvoice = expected
        actual = target.DatePickInvoice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DatePickTo"
    '''</summary>
    <TestMethod()> _
    Public Sub DatePickToTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DateTimePicker
        target.DatePickTo = expected
        actual = target.DatePickTo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpResults"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpResultsTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpResults = expected
        actual = target.GrpResults
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "label1"
    '''</summary>
    <TestMethod()> _
    Public Sub label1Test()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.label1 = expected
        actual = target.label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblAccBalance"
    '''</summary>
    <TestMethod()> _
    Public Sub LblAccBalanceTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblAccBalance = expected
        actual = target.LblAccBalance
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblAccState"
    '''</summary>
    <TestMethod()> _
    Public Sub LblAccStateTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblAccState = expected
        actual = target.LblAccState
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblEntries"
    '''</summary>
    <TestMethod()> _
    Public Sub LblEntriesTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblEntries = expected
        actual = target.LblEntries
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblPayMethod"
    '''</summary>
    <TestMethod()> _
    Public Sub LblPayMethodTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblPayMethod = expected
        actual = target.LblPayMethod
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LstAccountEntries"
    '''</summary>
    <TestMethod()> _
    Public Sub LstAccountEntriesTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.LstAccountEntries = expected
        actual = target.LstAccountEntries
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OptInvoiceDate"
    '''</summary>
    <TestMethod()> _
    Public Sub OptInvoiceDateTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.OptInvoiceDate = expected
        actual = target.OptInvoiceDate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OptLastInvoice"
    '''</summary>
    <TestMethod()> _
    Public Sub OptLastInvoiceTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.OptLastInvoice = expected
        actual = target.OptLastInvoice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OptRange"
    '''</summary>
    <TestMethod()> _
    Public Sub OptRangeTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.OptRange = expected
        actual = target.OptRange
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtAccBalance"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtAccBalanceTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtAccBalance = expected
        actual = target.TxtAccBalance
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtAccState"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtAccStateTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtAccState = expected
        actual = target.TxtAccState
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBezahltag"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBezahltagTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBezahltag = expected
        actual = target.txtBezahltag
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtPayMethod"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtPayMethodTest()
        Dim target As FormGetAccount = New FormGetAccount ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtPayMethod = expected
        actual = target.TxtPayMethod
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
