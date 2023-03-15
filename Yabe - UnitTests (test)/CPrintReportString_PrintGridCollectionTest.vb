Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "CPrintReportString_PrintGridCollectionTest" und soll
'''alle CPrintReportString_PrintGridCollectionTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class CPrintReportString_PrintGridCollectionTest


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
    '''Ein Test für "PrintGridCollection-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub CPrintReportString_PrintGridCollectionConstructorTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "Add"
    '''</summary>
    <TestMethod()> _
    Public Sub AddTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection ' TODO: Passenden Wert initialisieren
        Dim item As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        target.Add(item)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Contains"
    '''</summary>
    <TestMethod()> _
    Public Sub ContainsTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection ' TODO: Passenden Wert initialisieren
        Dim value As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.Contains(value)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CopyTo"
    '''</summary>
    <TestMethod()> _
    Public Sub CopyToTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection ' TODO: Passenden Wert initialisieren
        Dim array As Array = Nothing ' TODO: Passenden Wert initialisieren
        Dim index As Integer = 0 ' TODO: Passenden Wert initialisieren
        target.CopyTo(array, index)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "IndexOf"
    '''</summary>
    <TestMethod()> _
    Public Sub IndexOfTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection ' TODO: Passenden Wert initialisieren
        Dim value As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.IndexOf(value)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Insert"
    '''</summary>
    <TestMethod()> _
    Public Sub InsertTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection ' TODO: Passenden Wert initialisieren
        Dim index As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim value As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        target.Insert(index, value)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Remove"
    '''</summary>
    <TestMethod()> _
    Public Sub RemoveTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection ' TODO: Passenden Wert initialisieren
        Dim value As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        target.Remove(value)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Item"
    '''</summary>
    <TestMethod()> _
    Public Sub ItemTest()
        Dim target As CPrintReportString.PrintGridCollection = New CPrintReportString.PrintGridCollection ' TODO: Passenden Wert initialisieren
        Dim index As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As CPrintReportString.PrintStructureDataGrid = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CPrintReportString.PrintStructureDataGrid
        target(index) = expected
        actual = target(index)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
