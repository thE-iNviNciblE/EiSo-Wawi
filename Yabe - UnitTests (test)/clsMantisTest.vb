Imports System.Windows.Forms

Imports System.Collections

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsMantisTest" und soll
'''alle clsMantisTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsMantisTest


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
    '''Ein Test für "clsMantis-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsMantisConstructorTest()
        Dim target As clsMantis = New clsMantis
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "getIssueProject"
    '''</summary>
    <TestMethod()> _
    Public Sub getIssueProjectTest()
        Dim target As clsMantis = New clsMantis ' TODO: Passenden Wert initialisieren
        Dim cmbIssue As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbIssueExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getIssueProject(cmbIssue)
        Assert.AreEqual(cmbIssueExpected, cmbIssue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getPriority"
    '''</summary>
    <TestMethod()> _
    Public Sub getPriorityTest()
        Dim target As clsMantis = New clsMantis ' TODO: Passenden Wert initialisieren
        Dim cmbIssue As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbIssueExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getPriority(cmbIssue)
        Assert.AreEqual(cmbIssueExpected, cmbIssue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getProjectCategories"
    '''</summary>
    <TestMethod()> _
    Public Sub getProjectCategoriesTest()
        Dim target As clsMantis = New clsMantis ' TODO: Passenden Wert initialisieren
        Dim iProjectID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim cmbIssue As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbIssueExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getProjectCategories(iProjectID, cmbIssue)
        Assert.AreEqual(cmbIssueExpected, cmbIssue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getProjectVersions"
    '''</summary>
    <TestMethod()> _
    Public Sub getProjectVersionsTest()
        Dim target As clsMantis = New clsMantis ' TODO: Passenden Wert initialisieren
        Dim iProjectID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim cmbIssue As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbIssueExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getProjectVersions(iProjectID, cmbIssue)
        Assert.AreEqual(cmbIssueExpected, cmbIssue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getReproduce"
    '''</summary>
    <TestMethod()> _
    Public Sub getReproduceTest()
        Dim target As clsMantis = New clsMantis ' TODO: Passenden Wert initialisieren
        Dim cmbIssue As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbIssueExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getReproduce(cmbIssue)
        Assert.AreEqual(cmbIssueExpected, cmbIssue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getServertiy"
    '''</summary>
    <TestMethod()> _
    Public Sub getServertiyTest()
        Dim target As clsMantis = New clsMantis ' TODO: Passenden Wert initialisieren
        Dim cmbIssue As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbIssueExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getServertiy(cmbIssue)
        Assert.AreEqual(cmbIssueExpected, cmbIssue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewIssue"
    '''</summary>
    <TestMethod()> _
    Public Sub setNewIssueTest()
        Dim target As clsMantis = New clsMantis ' TODO: Passenden Wert initialisieren
        Dim aryList As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim projectComboBox As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim priorityComboBox As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim severityComboBox As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim categoryComboBox As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim reproducibilityComboBox As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewIssue(aryList, projectComboBox, priorityComboBox, severityComboBox, categoryComboBox, reproducibilityComboBox)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
