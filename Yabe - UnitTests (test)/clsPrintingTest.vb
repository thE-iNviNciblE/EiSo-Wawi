Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsPrintingTest" und soll
'''alle clsPrintingTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsPrintingTest


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
    '''Ein Test für "clsPrinting-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsPrintingConstructorTest()
        Dim target As clsPrinting = New clsPrinting
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "PrintOrPreviewGrid"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintOrPreviewGridTest()
        Dim target As clsPrinting = New clsPrinting ' TODO: Passenden Wert initialisieren
        Dim Preview As CPrintReportString.PrintPreview = New CPrintReportString.PrintPreview ' TODO: Passenden Wert initialisieren
        target.PrintOrPreviewGrid(Preview)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintOrPreviewListView"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintOrPreviewListViewTest()
        Dim target As clsPrinting = New clsPrinting ' TODO: Passenden Wert initialisieren
        Dim Preview As CPrintReportString.PrintPreview = New CPrintReportString.PrintPreview ' TODO: Passenden Wert initialisieren
        Dim ListView1 As ListView = Nothing ' TODO: Passenden Wert initialisieren
        target.PrintOrPreviewListView(Preview, ListView1)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub
End Class
