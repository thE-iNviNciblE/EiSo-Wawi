Imports System.Collections

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsDelcampeTest" und soll
'''alle clsDelcampeTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsDelcampeTest


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
    '''Ein Test für "clsDelcampe-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsDelcampeConstructorTest()
        Dim target As clsDelcampe = New clsDelcampe
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "getCSVExport_Repeat"
    '''</summary>
    <TestMethod()> _
    Public Sub getCSVExport_RepeatTest()
        Dim target As clsDelcampe = New clsDelcampe ' TODO: Passenden Wert initialisieren
        Dim oLV As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim sFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bIncludeHidden As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim sLine As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strSprache() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim strBeschreibung As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim oItem As ListViewItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim mModus As selectModus = New selectModus ' TODO: Passenden Wert initialisieren
        Dim aryAuktion As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getCSVExport_Repeat(oLV, sFile, bIncludeHidden, sLine, strSprache, strBeschreibung, oItem, mModus, aryAuktion)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
