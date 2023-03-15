Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "CPrintReportString_PrintStructureListViewTest" und soll
'''alle CPrintReportString_PrintStructureListViewTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class CPrintReportString_PrintStructureListViewTest


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
    '''Ein Test für "PrintStructureListView-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub CPrintReportString_PrintStructureListViewConstructorTest()
        Dim target As CPrintReportString.PrintStructureListView = New CPrintReportString.PrintStructureListView
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub
End Class
