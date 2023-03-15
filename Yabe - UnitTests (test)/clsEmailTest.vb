Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsEmailTest" und soll
'''alle clsEmailTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsEmailTest


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
    '''Ein Test für "clsEmail-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsEmailConstructorTest()
        Dim target As clsEmail = New clsEmail
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "getDebugEmail_Content"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getDebugEmail_ContentTest()
        Dim target As clsEmail_Accessor = New clsEmail_Accessor ' TODO: Passenden Wert initialisieren
        Dim strFile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getDebugEmail_Content(strFile)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getEMailTemplate"
    '''</summary>
    <TestMethod()> _
    Public Sub getEMailTemplateTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strPfad As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getEMailTemplate(strPfad)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getMailMessageError"
    '''</summary>
    <TestMethod()> _
    Public Sub getMailMessageErrorTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strMessage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strMethode As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getMailMessageError(strMessage, strMethode)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getTemplateVars"
    '''</summary>
    <TestMethod()> _
    Public Sub getTemplateVarsTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strData As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strDataExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModul As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iWoPos As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strPlattform As clsEmail.bPlattform = New clsEmail.bPlattform ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getTemplateVars(strData, strModul, iWoPos, strPlattform)
        Assert.AreEqual(strDataExpected, strData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setConfig"
    '''</summary>
    <TestMethod()> _
    Public Sub setConfigTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim bsetDebug As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setConfig(lvw, bsetDebug)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setReplaceData"
    '''</summary>
    <TestMethod()> _
    Public Sub setReplaceDataTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strContent As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iWoPos As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setReplaceData(strContent, iWoPos)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSendDebugReport"
    '''</summary>
    <TestMethod()> _
    Public Sub setSendDebugReportTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strBetreff As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strfile As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSendDebugReport(strBetreff, strfile)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSendMail"
    '''</summary>
    <TestMethod()> _
    Public Sub setSendMailTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strContent As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strBetreff As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSendMail(strContent, strBetreff)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSendMail_bestellstatus"
    '''</summary>
    <TestMethod()> _
    Public Sub setSendMail_bestellstatusTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strStatus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lvwData As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSendMail_bestellstatus(strStatus, lvwData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSendNewsletter"
    '''</summary>
    <TestMethod()> _
    Public Sub setSendNewsletterTest()
        Dim target As clsEmail = New clsEmail ' TODO: Passenden Wert initialisieren
        Dim strContent As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strBetreff As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bDebug As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSendNewsletter(strContent, strBetreff, bDebug)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWhitespace2HTML"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setWhitespace2HTMLTest()
        Dim target As clsEmail_Accessor = New clsEmail_Accessor ' TODO: Passenden Wert initialisieren
        Dim strWhitespace As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setWhitespace2HTML(strWhitespace)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
