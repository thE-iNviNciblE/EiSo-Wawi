Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmMainTest" und soll
'''alle frmMainTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmMainTest


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
    '''Ein Test für "frmMain-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmMainConstructorTest()
        Dim target As frmMain = New frmMain
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "AdminpanelToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub AdminpanelToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.AdminpanelToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AuktionsmanagerToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub AuktionsmanagerToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.AuktionsmanagerToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BeendenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BeendenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BeendenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungenMitKundenSynchronisierenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BestellungenMitKundenSynchronisierenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BestellungenMitKundenSynchronisierenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BestellungenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BestellungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BewertungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BewertungenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BewertungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BewertungenToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BewertungenToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BewertungenToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BewertungenToolStripMenuItem2_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BewertungenToolStripMenuItem2_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BewertungenToolStripMenuItem2_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "CubssEBayGalerieToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CubssEBayGalerieToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.CubssEBayGalerieToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DebugmodusAktivierenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DebugmodusAktivierenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DebugmodusAktivierenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeListerCSVImportToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeListerCSVImportToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeListerCSVImportToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DruckenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DruckenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayAbmahnungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayAbmahnungenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayAbmahnungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayBewertungenHolenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayBewertungenHolenToolStripMenuItem_ClickTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayBewertungenHolenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayCentralToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayCentralToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayCentralToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayDatenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayDatenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayDatenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayEmpholeneKategorieToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayEmpholeneKategorieToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayEmpholeneKategorieToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayGalerieAnzeigenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayGalerieAnzeigenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayGalerieAnzeigenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayGalerieToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayGalerieToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayGalerieToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayHilfeToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayHilfeToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayHilfeToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayHistoryToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayHistoryToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayHistoryToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayLiveListeHolenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayLiveListeHolenToolStripMenuItem_ClickTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayLiveListeHolenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayNewsToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayNewsToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayNewsToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBaySucheToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBaySucheToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBaySucheToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBaySucheToolStripMenuItem_Click_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBaySucheToolStripMenuItem_Click_1Test()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBaySucheToolStripMenuItem_Click_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayVerlaufToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayVerlaufToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayVerlaufToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EmailVerschickenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EmailVerschickenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EmailVerschickenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ExportToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ExportToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ExportToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ExportVerzeichnisÖffnenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ExportVerzeichnisÖffnenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ExportVerzeichnisÖffnenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "FehlerMeldenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub FehlerMeldenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.FehlerMeldenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmMain_FormClosed"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmMain_FormClosedTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As FormClosedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmMain_FormClosed(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmMain_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmMain_LoadTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmMain_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmMain_LocationChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmMain_LocationChangedTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmMain_LocationChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmMain_Resize"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmMain_ResizeTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmMain_Resize(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InfoToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InfoToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.InfoToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InhaltToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InhaltToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.InhaltToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KundendatenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KundendatenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KundendatenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KundendatenToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KundendatenToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KundendatenToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KundendatenToolStripMenuItem2_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KundendatenToolStripMenuItem2_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KundendatenToolStripMenuItem2_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "laden_auktionsmanagement"
    '''</summary>
    <TestMethod()> _
    Public Sub laden_auktionsmanagementTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.laden_auktionsmanagement
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LivemodusToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LivemodusToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LivemodusToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LivemodusToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LivemodusToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LivemodusToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MagentoCenterToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MagentoCenterToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MagentoCenterToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MailtextToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MailtextToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MailtextToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinDelcampeToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeinDelcampeToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeinDelcampeToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinEBayToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeinEBayToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeinEBayToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NewsletterToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NewsletterToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NewsletterToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NotifyIcon1_MouseDoubleClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NotifyIcon1_MouseDoubleClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NotifyIcon1_MouseDoubleClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OptionenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OptionenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OptionenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "OutlookSynchronisierenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub OutlookSynchronisierenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.OutlookSynchronisierenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ProcessCmdKey"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ProcessCmdKeyTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim msg As Message = New Message ' TODO: Passenden Wert initialisieren
        Dim msgExpected As Message = New Message ' TODO: Passenden Wert initialisieren
        Dim keyData As Keys = New Keys ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.ProcessCmdKey(msg, keyData)
        Assert.AreEqual(msgExpected, msg)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ProfildatenMitKundendatenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ProfildatenMitKundendatenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ProfildatenMitKundendatenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "RechnerinfoToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub RechnerinfoToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.RechnerinfoToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setAuktionManagerTools"
    '''</summary>
    <TestMethod()> _
    Public Sub setAuktionManagerToolsTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim bModus As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setAuktionManagerTools(bModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setAutoBewertung"
    '''</summary>
    <TestMethod()> _
    Public Sub setAutoBewertungTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setAutoBewertung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setBigWindow"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setBigWindowTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        target.setBigWindow()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setChangeDebugModus"
    '''</summary>
    <TestMethod()> _
    Public Sub setChangeDebugModusTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setChangeDebugModus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setLoadOptionForm"
    '''</summary>
    <TestMethod()> _
    Public Sub setLoadOptionFormTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setLoadOptionForm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopCounterÖffnenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ShopCounterÖffnenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ShopCounterÖffnenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopGoogleBaseToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ShopGoogleBaseToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ShopGoogleBaseToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "StartseiteToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub StartseiteToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.StartseiteToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "StatistikToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub StatistikToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.StatistikToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "StatistikToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub StatistikToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.StatistikToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SynchronisierenToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SynchronisierenToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SynchronisierenToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SyncOutlookToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SyncOutlookToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SyncOutlookToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SyncToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SyncToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SyncToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Timer1_Tick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Timer1_TickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Timer1_Tick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrBewertungen_Tick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub tmrBewertungen_TickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.tmrBewertungen_Tick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "tool_ebayMessage_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub tool_ebayMessage_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.tool_ebayMessage_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "toolDown_eBayTime_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub toolDown_eBayTime_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.toolDown_eBayTime_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripMenuItem2_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ToolStripMenuItem2_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ToolStripMenuItem2_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripMenuItem3_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ToolStripMenuItem3_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ToolStripMenuItem3_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "VerkaufseventsToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub VerkaufseventsToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.VerkaufseventsToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "WebseiteToolStripMenuItem1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub WebseiteToolStripMenuItem1_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.WebseiteToolStripMenuItem1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEAnalyserToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEAnalyserToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEAnalyserToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YabeArtikeldatenbankToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YabeArtikeldatenbankToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YabeArtikeldatenbankToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YabeArtikeldatenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YabeArtikeldatenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YabeArtikeldatenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEArtikelEinstellenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEArtikelEinstellenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEArtikelEinstellenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABECockpitToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABECockpitToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABECockpitToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEShopImporterToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEShopImporterToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEShopImporterToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEShopÜbersetzungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEShopÜbersetzungenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEShopÜbersetzungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEStartupToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEStartupToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEStartupToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEVersandkostenMitteilenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEVersandkostenMitteilenToolStripMenuItem_ClickTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEVersandkostenMitteilenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AdminpanelToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub AdminpanelToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.AdminpanelToolStripMenuItem = expected
        actual = target.AdminpanelToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "AdminpanelToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub AdminpanelToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.AdminpanelToolStripMenuItem1 = expected
        actual = target.AdminpanelToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "AuktionsmanagerToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub AuktionsmanagerToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.AuktionsmanagerToolStripMenuItem = expected
        actual = target.AuktionsmanagerToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BeendenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BeendenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BeendenToolStripMenuItem = expected
        actual = target.BeendenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungenMitKundenSynchronisierenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BestellungenMitKundenSynchronisierenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BestellungenMitKundenSynchronisierenToolStripMenuItem = expected
        actual = target.BestellungenMitKundenSynchronisierenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BestellungenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BestellungenToolStripMenuItem = expected
        actual = target.BestellungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BewertungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BewertungenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BewertungenToolStripMenuItem = expected
        actual = target.BewertungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BewertungenToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub BewertungenToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BewertungenToolStripMenuItem1 = expected
        actual = target.BewertungenToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ContextMenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ContextMenuStrip1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.ContextMenuStrip1 = expected
        actual = target.ContextMenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CubssEBayGalerieToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub CubssEBayGalerieToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.CubssEBayGalerieToolStripMenuItem = expected
        actual = target.CubssEBayGalerieToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DateiToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DateiToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DateiToolStripMenuItem = expected
        actual = target.DateiToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DebugmodusAktivierenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DebugmodusAktivierenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DebugmodusAktivierenToolStripMenuItem = expected
        actual = target.DebugmodusAktivierenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeListerCSVImportToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeListerCSVImportToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeListerCSVImportToolStripMenuItem = expected
        actual = target.DelcampeListerCSVImportToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DruckenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DruckenToolStripMenuItem = expected
        actual = target.DruckenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayAbmahnungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayAbmahnungenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayAbmahnungenToolStripMenuItem = expected
        actual = target.EBayAbmahnungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayBewertungenHolenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayBewertungenHolenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayBewertungenHolenToolStripMenuItem = expected
        actual = target.EBayBewertungenHolenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayCentralToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayCentralToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayCentralToolStripMenuItem = expected
        actual = target.EBayCentralToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayDatenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayDatenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayDatenToolStripMenuItem = expected
        actual = target.EBayDatenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayEmpholeneKategorieToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayEmpholeneKategorieToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayEmpholeneKategorieToolStripMenuItem = expected
        actual = target.EBayEmpholeneKategorieToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayGalerieAnzeigenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayGalerieAnzeigenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayGalerieAnzeigenToolStripMenuItem = expected
        actual = target.EBayGalerieAnzeigenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayGalerieToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayGalerieToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayGalerieToolStripMenuItem1 = expected
        actual = target.EBayGalerieToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayHilfeToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayHilfeToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayHilfeToolStripMenuItem = expected
        actual = target.EBayHilfeToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayHistoryToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayHistoryToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayHistoryToolStripMenuItem = expected
        actual = target.EBayHistoryToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem = expected
        actual = target.EBayLiveansichtMitEBayHistorySynchronisierenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayLiveListeHolenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayLiveListeHolenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayLiveListeHolenToolStripMenuItem = expected
        actual = target.EBayLiveListeHolenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayNewsToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayNewsToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayNewsToolStripMenuItem1 = expected
        actual = target.EBayNewsToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBaySucheToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBaySucheToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBaySucheToolStripMenuItem = expected
        actual = target.EBaySucheToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayToolStripMenuItem = expected
        actual = target.EBayToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EmailVerschickenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EmailVerschickenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EmailVerschickenToolStripMenuItem = expected
        actual = target.EmailVerschickenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ExportVerzeichnisÖffnenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ExportVerzeichnisÖffnenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ExportVerzeichnisÖffnenToolStripMenuItem = expected
        actual = target.ExportVerzeichnisÖffnenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ExtrasToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ExtrasToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ExtrasToolStripMenuItem = expected
        actual = target.ExtrasToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FehlerMeldenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub FehlerMeldenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.FehlerMeldenToolStripMenuItem = expected
        actual = target.FehlerMeldenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FunktionenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub FunktionenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.FunktionenToolStripMenuItem = expected
        actual = target.FunktionenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "HilfeToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub HilfeToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.HilfeToolStripMenuItem = expected
        actual = target.HilfeToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ImageList1"
    '''</summary>
    <TestMethod()> _
    Public Sub ImageList1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ImageList = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ImageList
        target.ImageList1 = expected
        actual = target.ImageList1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InfoToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub InfoToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.InfoToolStripMenuItem = expected
        actual = target.InfoToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InhaltToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub InhaltToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.InhaltToolStripMenuItem = expected
        actual = target.InhaltToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KundendatenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub KundendatenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KundendatenToolStripMenuItem = expected
        actual = target.KundendatenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KundendatenToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub KundendatenToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KundendatenToolStripMenuItem1 = expected
        actual = target.KundendatenToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LivemodusToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub LivemodusToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.LivemodusToolStripMenuItem = expected
        actual = target.LivemodusToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LivemodusToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub LivemodusToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.LivemodusToolStripMenuItem1 = expected
        actual = target.LivemodusToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MagentoCenterToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MagentoCenterToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MagentoCenterToolStripMenuItem = expected
        actual = target.MagentoCenterToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MailtextToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MailtextToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MailtextToolStripMenuItem = expected
        actual = target.MailtextToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinDelcampeToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeinDelcampeToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeinDelcampeToolStripMenuItem = expected
        actual = target.MeinDelcampeToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeinEBayToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeinEBayToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeinEBayToolStripMenuItem = expected
        actual = target.MeinEBayToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub MenuStrip1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As MenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As MenuStrip
        target.MenuStrip1 = expected
        actual = target.MenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Message_label"
    '''</summary>
    <TestMethod()> _
    Public Sub Message_labelTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.Message_label = expected
        actual = target.Message_label
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NewsletterToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub NewsletterToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.NewsletterToolStripMenuItem = expected
        actual = target.NewsletterToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NotifyIcon1"
    '''</summary>
    <TestMethod()> _
    Public Sub NotifyIcon1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As NotifyIcon = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As NotifyIcon
        target.NotifyIcon1 = expected
        actual = target.NotifyIcon1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ÖffnenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ÖffnenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ÖffnenToolStripMenuItem = expected
        actual = target.ÖffnenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OptionenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub OptionenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.OptionenToolStripMenuItem = expected
        actual = target.OptionenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OutlookSynchronisierenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub OutlookSynchronisierenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.OutlookSynchronisierenToolStripMenuItem = expected
        actual = target.OutlookSynchronisierenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ProfildatenMitKundendatenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ProfildatenMitKundendatenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ProfildatenMitKundendatenToolStripMenuItem = expected
        actual = target.ProfildatenMitKundendatenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "RechnerinfoToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub RechnerinfoToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.RechnerinfoToolStripMenuItem = expected
        actual = target.RechnerinfoToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SeitenansichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SeitenansichtToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SeitenansichtToolStripMenuItem = expected
        actual = target.SeitenansichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopCounterÖffnenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ShopCounterÖffnenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ShopCounterÖffnenToolStripMenuItem = expected
        actual = target.ShopCounterÖffnenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ShopGoogleBaseToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ShopGoogleBaseToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ShopGoogleBaseToolStripMenuItem = expected
        actual = target.ShopGoogleBaseToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StartseiteToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub StartseiteToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.StartseiteToolStripMenuItem = expected
        actual = target.StartseiteToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatistikToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub StatistikToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.StatistikToolStripMenuItem = expected
        actual = target.StatistikToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatistikToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatistikToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.StatistikToolStripMenuItem1 = expected
        actual = target.StatistikToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SynchronisierenToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub SynchronisierenToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SynchronisierenToolStripMenuItem1 = expected
        actual = target.SynchronisierenToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SyncOutlookToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SyncOutlookToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SyncOutlookToolStripMenuItem = expected
        actual = target.SyncOutlookToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SyncToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SyncToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SyncToolStripMenuItem = expected
        actual = target.SyncToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrBewertungen"
    '''</summary>
    <TestMethod()> _
    Public Sub tmrBewertungenTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Timer
        target.tmrBewertungen = expected
        actual = target.tmrBewertungen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tmrLiveAnsicht"
    '''</summary>
    <TestMethod()> _
    Public Sub tmrLiveAnsichtTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Timer
        target.tmrLiveAnsicht = expected
        actual = target.tmrLiveAnsicht
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tool_ebayMessage"
    '''</summary>
    <TestMethod()> _
    Public Sub tool_ebayMessageTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.tool_ebayMessage = expected
        actual = target.tool_ebayMessage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolDown_eBayTime"
    '''</summary>
    <TestMethod()> _
    Public Sub toolDown_eBayTimeTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.toolDown_eBayTime = expected
        actual = target.toolDown_eBayTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolDown_Progressbar"
    '''</summary>
    <TestMethod()> _
    Public Sub toolDown_ProgressbarTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.toolDown_Progressbar = expected
        actual = target.toolDown_Progressbar
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripDropDownButton1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripDropDownButton1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripDropDownButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripDropDownButton
        target.ToolStripDropDownButton1 = expected
        actual = target.ToolStripDropDownButton1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ToolStripMenuItem1 = expected
        actual = target.ToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripMenuItem2"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripMenuItem2Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ToolStripMenuItem2 = expected
        actual = target.ToolStripMenuItem2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripMenuItem3"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripMenuItem3Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ToolStripMenuItem3 = expected
        actual = target.ToolStripMenuItem3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripMenuItem4"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripMenuItem4Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ToolStripMenuItem4 = expected
        actual = target.ToolStripMenuItem4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparatorTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator = expected
        actual = target.toolStripSeparator
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator1"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparator1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator1 = expected
        actual = target.toolStripSeparator1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator10"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator10Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator10 = expected
        actual = target.ToolStripSeparator10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator11"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator11Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator11 = expected
        actual = target.ToolStripSeparator11
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator12"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator12Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator12 = expected
        actual = target.ToolStripSeparator12
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator13"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator13Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator13 = expected
        actual = target.ToolStripSeparator13
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator14"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator14Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator14 = expected
        actual = target.ToolStripSeparator14
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator15"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator15Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator15 = expected
        actual = target.ToolStripSeparator15
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator16"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator16Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator16 = expected
        actual = target.ToolStripSeparator16
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator17"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator17Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator17 = expected
        actual = target.ToolStripSeparator17
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator2"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparator2Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator2 = expected
        actual = target.toolStripSeparator2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator3"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator3Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator3 = expected
        actual = target.ToolStripSeparator3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator4"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator4Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator4 = expected
        actual = target.ToolStripSeparator4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator5"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparator5Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator5 = expected
        actual = target.toolStripSeparator5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator6"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator6Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator6 = expected
        actual = target.ToolStripSeparator6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator7"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator7Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator7 = expected
        actual = target.ToolStripSeparator7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator8"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator8Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator8 = expected
        actual = target.ToolStripSeparator8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator9"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator9Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator9 = expected
        actual = target.ToolStripSeparator9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "VerkaufseventsToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub VerkaufseventsToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.VerkaufseventsToolStripMenuItem = expected
        actual = target.VerkaufseventsToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "WebseiteToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub WebseiteToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.WebseiteToolStripMenuItem = expected
        actual = target.WebseiteToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "WebseiteToolStripMenuItem1"
    '''</summary>
    <TestMethod()> _
    Public Sub WebseiteToolStripMenuItem1Test()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.WebseiteToolStripMenuItem1 = expected
        actual = target.WebseiteToolStripMenuItem1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEAnalyserToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEAnalyserToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEAnalyserToolStripMenuItem = expected
        actual = target.YABEAnalyserToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YabeArtikeldatenbankToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YabeArtikeldatenbankToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YabeArtikeldatenbankToolStripMenuItem = expected
        actual = target.YabeArtikeldatenbankToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YabeArtikeldatenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YabeArtikeldatenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YabeArtikeldatenToolStripMenuItem = expected
        actual = target.YabeArtikeldatenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEArtikelEinstellenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEArtikelEinstellenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEArtikelEinstellenToolStripMenuItem = expected
        actual = target.YABEArtikelEinstellenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABECockpitToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABECockpitToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABECockpitToolStripMenuItem = expected
        actual = target.YABECockpitToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEShopImporterToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEShopImporterToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEShopImporterToolStripMenuItem = expected
        actual = target.YABEShopImporterToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEShopÜbersetzungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEShopÜbersetzungenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEShopÜbersetzungenToolStripMenuItem = expected
        actual = target.YABEShopÜbersetzungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEStartupToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEStartupToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEStartupToolStripMenuItem = expected
        actual = target.YABEStartupToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEVersandkostenMitteilenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEVersandkostenMitteilenToolStripMenuItemTest()
        Dim target As frmMain = New frmMain ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEVersandkostenMitteilenToolStripMenuItem = expected
        actual = target.YABEVersandkostenMitteilenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
