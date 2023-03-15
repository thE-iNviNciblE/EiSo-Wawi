Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsImporterTest" und soll
'''alle clsImporterTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsImporterTest


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
    '''Ein Test für "clsImporter-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsImporterConstructorTest()
        Dim target As clsImporter = New clsImporter
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "getCSVParser"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getCSVParserTest()
        Dim target As clsImporter_Accessor = New clsImporter_Accessor ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim modus As clsImporter.Importmodus = New clsImporter.Importmodus ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCSVParser(lvw, modus)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getDelcampeCSV"
    '''</summary>
    <TestMethod()> _
    Public Sub getDelcampeCSVTest()
        Dim target As clsImporter = New clsImporter ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strROW() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getDelcampeCSV(lvw, strROW)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayCSV"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayCSVTest()
        Dim target As clsImporter = New clsImporter ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strROW() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.geteBayCSV(lvw, strROW)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getImportFile"
    '''</summary>
    <TestMethod()> _
    Public Sub getImportFileTest()
        Dim target As clsImporter = New clsImporter ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim modus As clsImporter.Importmodus = New clsImporter.Importmodus ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getImportFile(lvw, modus)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
