Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "FormAddOrderTest" und soll
'''alle FormAddOrderTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class FormAddOrderTest


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
    '''Ein Test für "FormAddOrder-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub FormAddOrderConstructorTest()
        Dim target As FormAddOrder = New FormAddOrder
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BtnAddOrder_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BtnAddOrder_ClickTest()
        Dim target As FormAddOrder_Accessor = New FormAddOrder_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BtnAddOrder_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "CboShipSvc_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CboShipSvc_SelectedIndexChangedTest()
        Dim target As FormAddOrder_Accessor = New FormAddOrder_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.CboShipSvc_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As FormAddOrder_Accessor = New FormAddOrder_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FrmAddOrder_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FrmAddOrder_LoadTest()
        Dim target As FormAddOrder_Accessor = New FormAddOrder_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FrmAddOrder_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As FormAddOrder_Accessor = New FormAddOrder_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lbleBayVersandkosten_LinkClicked"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lbleBayVersandkosten_LinkClickedTest()
        Dim target As FormAddOrder_Accessor = New FormAddOrder_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As LinkLabelLinkClickedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lbleBayVersandkosten_LinkClicked(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BtnAddOrder"
    '''</summary>
    <TestMethod()> _
    Public Sub BtnAddOrderTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.BtnAddOrder = expected
        actual = target.BtnAddOrder
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CboShipSvc"
    '''</summary>
    <TestMethod()> _
    Public Sub CboShipSvcTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.CboShipSvc = expected
        actual = target.CboShipSvc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colBeschreibung"
    '''</summary>
    <TestMethod()> _
    Public Sub colBeschreibungTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colBeschreibung = expected
        actual = target.colBeschreibung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "coleBayID"
    '''</summary>
    <TestMethod()> _
    Public Sub coleBayIDTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.coleBayID = expected
        actual = target.coleBayID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "colTransaktion"
    '''</summary>
    <TestMethod()> _
    Public Sub colTransaktionTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.colTransaktion = expected
        actual = target.colTransaktion
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GrpResult"
    '''</summary>
    <TestMethod()> _
    Public Sub GrpResultTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As GroupBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As GroupBox
        target.GrpResult = expected
        actual = target.GrpResult
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lbleBayVersandkosten"
    '''</summary>
    <TestMethod()> _
    Public Sub lbleBayVersandkostenTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As LinkLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As LinkLabel
        target.lbleBayVersandkosten = expected
        actual = target.lbleBayVersandkosten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblOrderId"
    '''</summary>
    <TestMethod()> _
    Public Sub LblOrderIdTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblOrderId = expected
        actual = target.LblOrderId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblPaymentInstructions"
    '''</summary>
    <TestMethod()> _
    Public Sub LblPaymentInstructionsTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblPaymentInstructions = expected
        actual = target.LblPaymentInstructions
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblShipCost"
    '''</summary>
    <TestMethod()> _
    Public Sub LblShipCostTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblShipCost = expected
        actual = target.LblShipCost
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblShipSvc"
    '''</summary>
    <TestMethod()> _
    Public Sub LblShipSvcTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblShipSvc = expected
        actual = target.LblShipSvc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LblTotal"
    '''</summary>
    <TestMethod()> _
    Public Sub LblTotalTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.LblTotal = expected
        actual = target.LblTotal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwIDs"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwIDsTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwIDs = expected
        actual = target.lvwIDs
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtOrderId"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtOrderIdTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtOrderId = expected
        actual = target.TxtOrderId
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtPaymentInstructions"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtPaymentInstructionsTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtPaymentInstructions = expected
        actual = target.TxtPaymentInstructions
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtShipCost"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtShipCostTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtShipCost = expected
        actual = target.TxtShipCost
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TxtTotal"
    '''</summary>
    <TestMethod()> _
    Public Sub TxtTotalTest()
        Dim target As FormAddOrder = New FormAddOrder ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.TxtTotal = expected
        actual = target.TxtTotal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
