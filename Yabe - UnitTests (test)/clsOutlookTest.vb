Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsOutlookTest" und soll
'''alle clsOutlookTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsOutlookTest


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
    '''Ein Test für "clsOutlook-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsOutlookConstructorTest()
        Dim target As clsOutlook = New clsOutlook
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "email_filter"
    '''</summary>
    <TestMethod()> _
    Public Sub email_filterTest()
        Dim target As clsOutlook = New clsOutlook ' TODO: Passenden Wert initialisieren
        Dim lvwOut As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwOutExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim bModus As clsOutlook.mOutlook = New clsOutlook.mOutlook ' TODO: Passenden Wert initialisieren
        Dim strFolderName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim dbBeginn As DateTime = New DateTime ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.email_filter(lvwOut, bModus, strFolderName, dbBeginn)
        Assert.AreEqual(lvwOutExpected, lvwOut)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getContacts"
    '''</summary>
    <TestMethod()> _
    Public Sub getContactsTest()
        Dim target As clsOutlook = New clsOutlook ' TODO: Passenden Wert initialisieren
        Dim lvwOut As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwOutExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getContacts(lvwOut)
        Assert.AreEqual(lvwOutExpected, lvwOut)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getEMAIL_text_delcampe"
    '''</summary>
    <TestMethod()> _
    Public Sub getEMAIL_text_delcampeTest()
        Dim target As clsOutlook = New clsOutlook ' TODO: Passenden Wert initialisieren
        Dim strText As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lvwItem As ListViewItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwItemExpected As ListViewItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim strModus As clsOutlook.enumPlattformModus = New clsOutlook.enumPlattformModus ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getEMAIL_text_delcampe(strText, lvwItem, strModus)
        Assert.AreEqual(lvwItemExpected, lvwItem)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getOutlook_emails"
    '''</summary>
    <TestMethod()> _
    Public Sub getOutlook_emailsTest()
        Dim target As clsOutlook = New clsOutlook ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getOutlook_emails
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "olAddContact"
    '''</summary>
    <TestMethod()> _
    Public Sub olAddContactTest()
        Dim target As clsOutlook = New clsOutlook ' TODO: Passenden Wert initialisieren
        Dim sLastName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim sFirstName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim sCompanyName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim sPhoneNumber As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim sEMail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim sWebPage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.olAddContact(sLastName, sFirstName, sCompanyName, sPhoneNumber, sEMail, sWebPage)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setOutlook2Yabe_items"
    '''</summary>
    <TestMethod()> _
    Public Sub setOutlook2Yabe_itemsTest()
        Dim target As clsOutlook = New clsOutlook ' TODO: Passenden Wert initialisieren
        Dim lvwOut As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwOutExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim oMail As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim bModus As clsOutlook.mOutlook = New clsOutlook.mOutlook ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setOutlook2Yabe_items(lvwOut, oMail, bModus)
        Assert.AreEqual(lvwOutExpected, lvwOut)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
