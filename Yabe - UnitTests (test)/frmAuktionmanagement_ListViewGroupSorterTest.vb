Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmAuktionmanagement_ListViewGroupSorterTest" und soll
'''alle frmAuktionmanagement_ListViewGroupSorterTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmAuktionmanagement_ListViewGroupSorterTest


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
    '''Ein Test für "ListViewGroupSorter-Konstruktor"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmAuktionmanagement_ListViewGroupSorterConstructorTest()
        Dim theOrder As SortOrder = New SortOrder ' TODO: Passenden Wert initialisieren
        Dim target As frmAuktionmanagement_Accessor.ListViewGroupSorter = New frmAuktionmanagement_Accessor.ListViewGroupSorter(theOrder)
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "Compare"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CompareTest()
        'Eine assemblyübergreifende Klassenvererbung wird von private-Accessoren nicht beibehalten. In jeder private-Accessorklasse wird jedoch die statische Methode AttachShadow() bereitgestellt, um ein privates Objekt aus einer private-Accessorklasse in eine andere zu übertragen.
        Assert.Inconclusive("Eine assemblyübergreifende Klassenvererbung wird von private-Accessoren nicht bei" & _
                "behalten. In jeder private-Accessorklasse wird jedoch die statische Methode Atta" & _
                "chShadow() bereitgestellt, um ein privates Objekt aus einer private-Accessorklas" & _
                "se in eine andere zu übertragen.")
    End Sub
End Class
