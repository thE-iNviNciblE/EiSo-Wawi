Imports System.Drawing.Printing

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "CPrintReportStringTest" und soll
'''alle CPrintReportStringTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class CPrintReportStringTest


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
    '''Ein Test für "CPrintReportString-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub CPrintReportStringConstructorTest()
        Dim target As CPrintReportString = New CPrintReportString
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "GetMarginExtenders"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub GetMarginExtendersTest()
        Dim target As CPrintReportString_Accessor = New CPrintReportString_Accessor ' TODO: Passenden Wert initialisieren
        Dim lmExt As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim lmExtExpected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim rmExt As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim rmExtExpected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim tmExt As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim tmExtExpected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim bmExt As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim bmExtExpected As Integer = 0 ' TODO: Passenden Wert initialisieren
        target.GetMarginExtenders(lmExt, rmExt, tmExt, bmExt)
        Assert.AreEqual(lmExtExpected, lmExt)
        Assert.AreEqual(rmExtExpected, rmExt)
        Assert.AreEqual(tmExtExpected, tmExt)
        Assert.AreEqual(bmExtExpected, bmExt)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "GetOneMarginExtender"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub GetOneMarginExtenderTest()
        Dim target As CPrintReportString_Accessor = New CPrintReportString_Accessor ' TODO: Passenden Wert initialisieren
        Dim ext As CPrintReportString.MarginExtender = New CPrintReportString.MarginExtender ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.GetOneMarginExtender(ext)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintOrPreview"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintOrPreviewTest4()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim CPL As CPrintReportString.CharsPerLine = New CPrintReportString.CharsPerLine ' TODO: Passenden Wert initialisieren
        Dim PPrintBlock As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PPrintBlockExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PSubTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PVOption As CPrintReportString.PrintPreview = New CPrintReportString.PrintPreview ' TODO: Passenden Wert initialisieren
        Dim Layout As CPrintReportString.PrintOrientation = New CPrintReportString.PrintOrientation ' TODO: Passenden Wert initialisieren
        Dim ColHdr1 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr2 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr3 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr4 As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.PrintOrPreview(CPL, PPrintBlock, PTitle, PSubTitle, PVOption, Layout, ColHdr1, ColHdr2, ColHdr3, ColHdr4)
        Assert.AreEqual(PPrintBlockExpected, PPrintBlock)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintOrPreview"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintOrPreviewTest3()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim CPL As CPrintReportString.CharsPerLine = New CPrintReportString.CharsPerLine ' TODO: Passenden Wert initialisieren
        Dim PPrintBlock As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PPrintBlockExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PSubTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PVOption As CPrintReportString.PrintPreview = New CPrintReportString.PrintPreview ' TODO: Passenden Wert initialisieren
        Dim Layout As CPrintReportString.PrintOrientation = New CPrintReportString.PrintOrientation ' TODO: Passenden Wert initialisieren
        Dim ColHdr1 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr2 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr3 As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.PrintOrPreview(CPL, PPrintBlock, PTitle, PSubTitle, PVOption, Layout, ColHdr1, ColHdr2, ColHdr3)
        Assert.AreEqual(PPrintBlockExpected, PPrintBlock)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintOrPreview"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintOrPreviewTest2()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim CPL As CPrintReportString.CharsPerLine = New CPrintReportString.CharsPerLine ' TODO: Passenden Wert initialisieren
        Dim PPrintBlock As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PPrintBlockExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PSubTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PVOption As CPrintReportString.PrintPreview = New CPrintReportString.PrintPreview ' TODO: Passenden Wert initialisieren
        Dim Layout As CPrintReportString.PrintOrientation = New CPrintReportString.PrintOrientation ' TODO: Passenden Wert initialisieren
        Dim ColHdr1 As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.PrintOrPreview(CPL, PPrintBlock, PTitle, PSubTitle, PVOption, Layout, ColHdr1)
        Assert.AreEqual(PPrintBlockExpected, PPrintBlock)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintOrPreview"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintOrPreviewTest1()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim CPL As CPrintReportString.CharsPerLine = New CPrintReportString.CharsPerLine ' TODO: Passenden Wert initialisieren
        Dim PPrintBlock As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PPrintBlockExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PSubTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PVOption As CPrintReportString.PrintPreview = New CPrintReportString.PrintPreview ' TODO: Passenden Wert initialisieren
        Dim Layout As CPrintReportString.PrintOrientation = New CPrintReportString.PrintOrientation ' TODO: Passenden Wert initialisieren
        target.PrintOrPreview(CPL, PPrintBlock, PTitle, PSubTitle, PVOption, Layout)
        Assert.AreEqual(PPrintBlockExpected, PPrintBlock)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintOrPreview"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintOrPreviewTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim CPL As CPrintReportString.CharsPerLine = New CPrintReportString.CharsPerLine ' TODO: Passenden Wert initialisieren
        Dim PPrintBlock As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PPrintBlockExpected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PSubTitle As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim PVOption As CPrintReportString.PrintPreview = New CPrintReportString.PrintPreview ' TODO: Passenden Wert initialisieren
        Dim Layout As CPrintReportString.PrintOrientation = New CPrintReportString.PrintOrientation ' TODO: Passenden Wert initialisieren
        Dim ColHdr1 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr2 As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.PrintOrPreview(CPL, PPrintBlock, PTitle, PSubTitle, PVOption, Layout, ColHdr1, ColHdr2)
        Assert.AreEqual(PPrintBlockExpected, PPrintBlock)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PrtDoc_PrintPage"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub PrtDoc_PrintPageTest()
        Dim target As CPrintReportString_Accessor = New CPrintReportString_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As PrintPageEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.PrtDoc_PrintPage(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SetUpColHdrArray"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SetUpColHdrArrayTest()
        Dim target As CPrintReportString_Accessor = New CPrintReportString_Accessor ' TODO: Passenden Wert initialisieren
        Dim ColHdr1 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr2 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr3 As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim ColHdr4 As String = String.Empty ' TODO: Passenden Wert initialisieren
        target.SetUpColHdrArray(ColHdr1, ColHdr2, ColHdr3, ColHdr4)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BottomMarginExtender"
    '''</summary>
    <TestMethod()> _
    Public Sub BottomMarginExtenderTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As CPrintReportString.MarginExtender = New CPrintReportString.MarginExtender ' TODO: Passenden Wert initialisieren
        Dim actual As CPrintReportString.MarginExtender
        target.BottomMarginExtender = expected
        actual = target.BottomMarginExtender
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColHdr1"
    '''</summary>
    <TestMethod()> _
    Public Sub ColHdr1Test()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.ColHdr1 = expected
        actual = target.ColHdr1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColHdr2"
    '''</summary>
    <TestMethod()> _
    Public Sub ColHdr2Test()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.ColHdr2 = expected
        actual = target.ColHdr2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColHdr3"
    '''</summary>
    <TestMethod()> _
    Public Sub ColHdr3Test()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.ColHdr3 = expected
        actual = target.ColHdr3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ColHdr4"
    '''</summary>
    <TestMethod()> _
    Public Sub ColHdr4Test()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.ColHdr4 = expected
        actual = target.ColHdr4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DrawBox"
    '''</summary>
    <TestMethod()> _
    Public Sub DrawBoxTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        target.DrawBox = expected
        actual = target.DrawBox
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LeftMarginExtender"
    '''</summary>
    <TestMethod()> _
    Public Sub LeftMarginExtenderTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As CPrintReportString.MarginExtender = New CPrintReportString.MarginExtender ' TODO: Passenden Wert initialisieren
        Dim actual As CPrintReportString.MarginExtender
        target.LeftMarginExtender = expected
        actual = target.LeftMarginExtender
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintDoc"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub PrintDocTest()
        Dim target As CPrintReportString_Accessor = New CPrintReportString_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As PrintDocument = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As PrintDocument
        target.PrintDoc = expected
        actual = target.PrintDoc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PrintFooter"
    '''</summary>
    <TestMethod()> _
    Public Sub PrintFooterTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        target.PrintFooter = expected
        actual = target.PrintFooter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "RightMarginExtender"
    '''</summary>
    <TestMethod()> _
    Public Sub RightMarginExtenderTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As CPrintReportString.MarginExtender = New CPrintReportString.MarginExtender ' TODO: Passenden Wert initialisieren
        Dim actual As CPrintReportString.MarginExtender
        target.RightMarginExtender = expected
        actual = target.RightMarginExtender
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SepLines"
    '''</summary>
    <TestMethod()> _
    Public Sub SepLinesTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        target.SepLines = expected
        actual = target.SepLines
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SubTitle"
    '''</summary>
    <TestMethod()> _
    Public Sub SubTitleTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.SubTitle = expected
        actual = target.SubTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SubTitle2"
    '''</summary>
    <TestMethod()> _
    Public Sub SubTitle2Test()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.SubTitle2 = expected
        actual = target.SubTitle2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SubTitle3"
    '''</summary>
    <TestMethod()> _
    Public Sub SubTitle3Test()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.SubTitle3 = expected
        actual = target.SubTitle3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SubTitle4"
    '''</summary>
    <TestMethod()> _
    Public Sub SubTitle4Test()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.SubTitle4 = expected
        actual = target.SubTitle4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Title"
    '''</summary>
    <TestMethod()> _
    Public Sub TitleTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        target.Title = expected
        actual = target.Title
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TitleFontSize"
    '''</summary>
    <TestMethod()> _
    Public Sub TitleFontSizeTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As Single = 0.0! ' TODO: Passenden Wert initialisieren
        Dim actual As Single
        target.TitleFontSize = expected
        actual = target.TitleFontSize
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TitleFontStyle"
    '''</summary>
    <TestMethod()> _
    Public Sub TitleFontStyleTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As CPrintReportString.TitleStyle = New CPrintReportString.TitleStyle ' TODO: Passenden Wert initialisieren
        Dim actual As CPrintReportString.TitleStyle
        target.TitleFontStyle = expected
        actual = target.TitleFontStyle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TopMarginExtender"
    '''</summary>
    <TestMethod()> _
    Public Sub TopMarginExtenderTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As CPrintReportString.MarginExtender = New CPrintReportString.MarginExtender ' TODO: Passenden Wert initialisieren
        Dim actual As CPrintReportString.MarginExtender
        target.TopMarginExtender = expected
        actual = target.TopMarginExtender
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "WordWrap"
    '''</summary>
    <TestMethod()> _
    Public Sub WordWrapTest()
        Dim target As CPrintReportString = New CPrintReportString ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        target.WordWrap = expected
        actual = target.WordWrap
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
