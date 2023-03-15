Imports System.Text

Imports System.Data

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "CPrintReportString_CPrintGridTest" und soll
'''alle CPrintReportString_CPrintGridTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class CPrintReportString_CPrintGridTest


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
    '''Ein Test für "CPrintGrid-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub CPrintReportString_CPrintGridConstructorTest()
        Dim target As CPrintReportString.CPrintGrid = New CPrintReportString.CPrintGrid
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "AlignAndPad"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub AlignAndPadTest()
        Dim target As CPrintReportString_Accessor.CPrintGrid = New CPrintReportString_Accessor.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim pcChars As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim pcWidth As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim Alignment As CPrintReportString.Align = New CPrintReportString.Align ' TODO: Passenden Wert initialisieren
        Dim sb As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim sbExpected As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim s As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.AlignAndPad(pcChars, pcWidth, Alignment, sb, s)
        Assert.AreEqual(sbExpected, sb)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "CallPrintPreview"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CallPrintPreviewTest()
        Dim target As CPrintReportString_Accessor.CPrintGrid = New CPrintReportString_Accessor.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim sb As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim sbExpected As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPO As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPOExpected As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        target.CallPrintPreview(sb, colPO)
        Assert.AreEqual(sbExpected, sb)
        Assert.AreEqual(colPOExpected, colPO)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FormatColumn"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FormatColumnTest1()
        Dim target As CPrintReportString_Accessor.CPrintGrid = New CPrintReportString_Accessor.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim sb As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim sbExpected As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim dr As DataRow = Nothing ' TODO: Passenden Wert initialisieren
        Dim ps As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        Dim psExpected As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        target.FormatColumn(sb, dr, ps)
        Assert.AreEqual(sbExpected, sb)
        Assert.AreEqual(psExpected, ps)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FormatColumn"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FormatColumnTest()
        Dim target As CPrintReportString_Accessor.CPrintGrid = New CPrintReportString_Accessor.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim sb As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim sbExpected As StringBuilder = Nothing ' TODO: Passenden Wert initialisieren
        Dim item As ListViewItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim itemExpected As ListViewItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim ps As CPrintReportString.PrintStructureListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim psExpected As CPrintReportString.PrintStructureListView = Nothing ' TODO: Passenden Wert initialisieren
        target.FormatColumn(sb, item, ps)
        Assert.AreEqual(sbExpected, sb)
        Assert.AreEqual(itemExpected, item)
        Assert.AreEqual(psExpected, ps)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "GetDataSource"
    '''</summary>
    <TestMethod()> _
    Public Sub GetDataSourceTest()
        Dim target As CPrintReportString.CPrintGrid = New CPrintReportString.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim frm As Form = Nothing ' TODO: Passenden Wert initialisieren
        Dim frmExpected As Form = Nothing ' TODO: Passenden Wert initialisieren
        Dim dg As DataGrid = Nothing ' TODO: Passenden Wert initialisieren
        Dim dgExpected As DataGrid = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As DataView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DataView
        actual = target.GetDataSource(frm, dg)
        Assert.AreEqual(frmExpected, frm)
        Assert.AreEqual(dgExpected, dg)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PadCenter"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub PadCenterTest()
        Dim target As CPrintReportString_Accessor.CPrintGrid = New CPrintReportString_Accessor.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim s As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim n As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.PadCenter(s, n)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintGrid"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintGridTest2()
        Dim target As CPrintReportString.CPrintGrid = New CPrintReportString.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim dv As DataView = Nothing ' TODO: Passenden Wert initialisieren
        Dim dvExpected As DataView = Nothing ' TODO: Passenden Wert initialisieren
        Dim col As CPrintReportString.PrintGridCollection = Nothing ' TODO: Passenden Wert initialisieren
        Dim colExpected As CPrintReportString.PrintGridCollection = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPO As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPOExpected As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        target.PrintGrid(dv, col, colPO)
        Assert.AreEqual(dvExpected, dv)
        Assert.AreEqual(colExpected, col)
        Assert.AreEqual(colPOExpected, colPO)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintGrid"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintGridTest1()
        Dim target As CPrintReportString.CPrintGrid = New CPrintReportString.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim dt As DataTable = Nothing ' TODO: Passenden Wert initialisieren
        Dim dtExpected As DataTable = Nothing ' TODO: Passenden Wert initialisieren
        Dim col As CPrintReportString.PrintGridCollection = Nothing ' TODO: Passenden Wert initialisieren
        Dim colExpected As CPrintReportString.PrintGridCollection = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPO As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPOExpected As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        target.PrintGrid(dt, col, colPO)
        Assert.AreEqual(dtExpected, dt)
        Assert.AreEqual(colExpected, col)
        Assert.AreEqual(colPOExpected, colPO)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintGrid"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintGridTest()
        Dim target As CPrintReportString.CPrintGrid = New CPrintReportString.CPrintGrid ' TODO: Passenden Wert initialisieren
        Dim lv As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim col As CPrintReportString.PrintListViewCollection = Nothing ' TODO: Passenden Wert initialisieren
        Dim colExpected As CPrintReportString.PrintListViewCollection = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPO As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        Dim colPOExpected As CPrintReportString.PrintOptions = Nothing ' TODO: Passenden Wert initialisieren
        target.PrintGrid(lv, col, colPO)
        Assert.AreEqual(lvExpected, lv)
        Assert.AreEqual(colExpected, col)
        Assert.AreEqual(colPOExpected, colPO)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub
End Class
