Imports System.ComponentModel

Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmBestellung_VersandkostenTest" und soll
'''alle frmBestellung_VersandkostenTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmBestellung_VersandkostenTest


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
    '''Ein Test für "frmBestellung_Versandkosten-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmBestellung_VersandkostenConstructorTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungArtikelNochmalVersendenliveToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BestellungArtikelNochmalVersendenliveToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BestellungArtikelNochmalVersendenliveToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungLöschenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BestellungLöschenToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BestellungLöschenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BewertetToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BewertetToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BewertetToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BezahltToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BezahltToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BezahltToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BildanzeigenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub BildanzeigenToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.BildanzeigenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnClose_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnClose_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnClose_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSaveShippment_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnSaveShippment_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnSaveShippment_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "checkEndpreis"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub checkEndpreisTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        target.checkEndpreis()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkInternational_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkInternational_CheckedChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkInternational_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkPaypalMit_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkPaypalMit_CheckedChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkPaypalMit_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "CompleteToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub CompleteToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.CompleteToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "conArtikelliste_Opening"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub conArtikelliste_OpeningTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.conArtikelliste_Opening(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArtikelAnzeigenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayArtikelAnzeigenToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayArtikelAnzeigenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArtikelinformationToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayArtikelinformationToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayArtikelinformationToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayInformationenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayInformationenToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayInformationenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayKundeninformationToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayKundeninformationToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayKundeninformationToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmVersandkostenanzeige_FormClosing"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmVersandkostenanzeige_FormClosingTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As FormClosingEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmVersandkostenanzeige_FormClosing(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmVersandkostenanzeige_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmVersandkostenanzeige_KeyDownTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmVersandkostenanzeige_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmVersandkostenanzeige_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmVersandkostenanzeige_LoadTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmVersandkostenanzeige_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lbleBayVersand_LinkClicked"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lbleBayVersand_LinkClickedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As LinkLabelLinkClickedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lbleBayVersand_LinkClicked(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwArtikelListe_ColumnClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwArtikelListe_ColumnClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwArtikelListe_ColumnClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwArtikelListe_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwArtikelListe_SelectedIndexChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwArtikelListe_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwKundenliste_ColumnClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwKundenliste_ColumnClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwKundenliste_ColumnClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwKundenliste_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwKundenliste_SelectedIndexChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwKundenliste_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setCalcPaypal"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setCalcPaypalTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCalcPaypal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StorniertToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub StorniertToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.StorniertToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundenbestellungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SucheKundenbestellungenToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SucheKundenbestellungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SucheKundenToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SucheKundenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEndbetrag_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtEndbetrag_TextChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtEndbetrag_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMitPaypal_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtMitPaypal_TextChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtMitPaypal_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtUmsatz_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtUmsatz_TextChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtUmsatz_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtVersandkosten_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtVersandkosten_KeyDownTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtVersandkosten_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtVersandkosten_Leave"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtVersandkosten_LeaveTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtVersandkosten_Leave(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "txtVersandkosten_TextChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub txtVersandkosten_TextChangedTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.txtVersandkosten_TextChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "VerschicktToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub VerschicktToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.VerschicktToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundenverlaufToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEKundenverlaufToolStripMenuItem_ClickTest()
        Dim target As frmBestellung_Versandkosten_Accessor = New frmBestellung_Versandkosten_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEKundenverlaufToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungArtikelNochmalVersendenliveToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BestellungArtikelNochmalVersendenliveToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BestellungArtikelNochmalVersendenliveToolStripMenuItem = expected
        actual = target.BestellungArtikelNochmalVersendenliveToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungLöschenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BestellungLöschenToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BestellungLöschenToolStripMenuItem = expected
        actual = target.BestellungLöschenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BestellungsstatusToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BestellungsstatusToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BestellungsstatusToolStripMenuItem = expected
        actual = target.BestellungsstatusToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BewertetToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BewertetToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BewertetToolStripMenuItem = expected
        actual = target.BewertetToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BezahltToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BezahltToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BezahltToolStripMenuItem = expected
        actual = target.BezahltToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "BildanzeigenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub BildanzeigenToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.BildanzeigenToolStripMenuItem = expected
        actual = target.BildanzeigenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnClose"
    '''</summary>
    <TestMethod()> _
    Public Sub btnCloseTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnClose = expected
        actual = target.btnClose
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnSaveShippment"
    '''</summary>
    <TestMethod()> _
    Public Sub btnSaveShippmentTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnSaveShippment = expected
        actual = target.btnSaveShippment
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkInternational"
    '''</summary>
    <TestMethod()> _
    Public Sub chkInternationalTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkInternational = expected
        actual = target.chkInternational
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkListVersandarten"
    '''</summary>
    <TestMethod()> _
    Public Sub chkListVersandartenTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As CheckedListBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckedListBox
        target.chkListVersandarten = expected
        actual = target.chkListVersandarten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkMitRechnung"
    '''</summary>
    <TestMethod()> _
    Public Sub chkMitRechnungTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkMitRechnung = expected
        actual = target.chkMitRechnung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkPaypalMit"
    '''</summary>
    <TestMethod()> _
    Public Sub chkPaypalMitTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkPaypalMit = expected
        actual = target.chkPaypalMit
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CompleteToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub CompleteToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.CompleteToolStripMenuItem = expected
        actual = target.CompleteToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "conArtikelliste"
    '''</summary>
    <TestMethod()> _
    Public Sub conArtikellisteTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.conArtikelliste = expected
        actual = target.conArtikelliste
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ContextMenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ContextMenuStrip1Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.ContextMenuStrip1 = expected
        actual = target.ContextMenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArtikelAnzeigenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayArtikelAnzeigenToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayArtikelAnzeigenToolStripMenuItem = expected
        actual = target.EBayArtikelAnzeigenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArtikelinformationToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayArtikelinformationToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayArtikelinformationToolStripMenuItem = expected
        actual = target.EBayArtikelinformationToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayInformationenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayInformationenToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayInformationenToolStripMenuItem = expected
        actual = target.EBayInformationenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ErinnerungSendenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ErinnerungSendenToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ErinnerungSendenToolStripMenuItem = expected
        actual = target.ErinnerungSendenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ImageList1"
    '''</summary>
    <TestMethod()> _
    Public Sub ImageList1Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ImageList = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ImageList
        target.ImageList1 = expected
        actual = target.ImageList1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label10"
    '''</summary>
    <TestMethod()> _
    Public Sub Label10Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label10 = expected
        actual = target.Label10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label11"
    '''</summary>
    <TestMethod()> _
    Public Sub Label11Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label11 = expected
        actual = target.Label11
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label12"
    '''</summary>
    <TestMethod()> _
    Public Sub Label12Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label12 = expected
        actual = target.Label12
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label13"
    '''</summary>
    <TestMethod()> _
    Public Sub Label13Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label13 = expected
        actual = target.Label13
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label2"
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label3"
    '''</summary>
    <TestMethod()> _
    Public Sub Label3Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label3 = expected
        actual = target.Label3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label4"
    '''</summary>
    <TestMethod()> _
    Public Sub Label4Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label4 = expected
        actual = target.Label4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label5"
    '''</summary>
    <TestMethod()> _
    Public Sub Label5Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label5 = expected
        actual = target.Label5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label6"
    '''</summary>
    <TestMethod()> _
    Public Sub Label6Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label6 = expected
        actual = target.Label6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label7"
    '''</summary>
    <TestMethod()> _
    Public Sub Label7Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label7 = expected
        actual = target.Label7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label8"
    '''</summary>
    <TestMethod()> _
    Public Sub Label8Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label8 = expected
        actual = target.Label8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label9"
    '''</summary>
    <TestMethod()> _
    Public Sub Label9Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label9 = expected
        actual = target.Label9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lbleBayVersand"
    '''</summary>
    <TestMethod()> _
    Public Sub lbleBayVersandTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As LinkLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As LinkLabel
        target.lbleBayVersand = expected
        actual = target.lbleBayVersand
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "liste_artikel_anzahl"
    '''</summary>
    <TestMethod()> _
    Public Sub liste_artikel_anzahlTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.liste_artikel_anzahl = expected
        actual = target.liste_artikel_anzahl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "liste_benutzername"
    '''</summary>
    <TestMethod()> _
    Public Sub liste_benutzernameTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.liste_benutzername = expected
        actual = target.liste_benutzername
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "liste_umsatz"
    '''</summary>
    <TestMethod()> _
    Public Sub liste_umsatzTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.liste_umsatz = expected
        actual = target.liste_umsatz
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwArtikelListe"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwArtikelListeTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwArtikelListe = expected
        actual = target.lvwArtikelListe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwKundenliste"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwKundenlisteTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwKundenliste = expected
        actual = target.lvwKundenliste
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StorniertToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub StorniertToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.StorniertToolStripMenuItem = expected
        actual = target.StorniertToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundenbestellungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SucheKundenbestellungenToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SucheKundenbestellungenToolStripMenuItem = expected
        actual = target.SucheKundenbestellungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SucheKundenToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SucheKundenToolStripMenuItem = expected
        actual = target.SucheKundenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator1Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator1 = expected
        actual = target.ToolStripSeparator1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator17"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator17Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator17 = expected
        actual = target.ToolStripSeparator17
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator2"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator2Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator2 = expected
        actual = target.ToolStripSeparator2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator28"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator28Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator28 = expected
        actual = target.ToolStripSeparator28
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator3"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator3Test()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator3 = expected
        actual = target.ToolStripSeparator3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtAnschrift"
    '''</summary>
    <TestMethod()> _
    Public Sub txtAnschriftTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtAnschrift = expected
        actual = target.txtAnschrift
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtBenutzername"
    '''</summary>
    <TestMethod()> _
    Public Sub txtBenutzernameTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtBenutzername = expected
        actual = target.txtBenutzername
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtCountryCode"
    '''</summary>
    <TestMethod()> _
    Public Sub txtCountryCodeTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtCountryCode = expected
        actual = target.txtCountryCode
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEmail"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEmailTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEmail = expected
        actual = target.txtEmail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtEndbetrag"
    '''</summary>
    <TestMethod()> _
    Public Sub txtEndbetragTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtEndbetrag = expected
        actual = target.txtEndbetrag
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtLand"
    '''</summary>
    <TestMethod()> _
    Public Sub txtLandTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtLand = expected
        actual = target.txtLand
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtMitPaypal"
    '''</summary>
    <TestMethod()> _
    Public Sub txtMitPaypalTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtMitPaypal = expected
        actual = target.txtMitPaypal
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtUmsatz"
    '''</summary>
    <TestMethod()> _
    Public Sub txtUmsatzTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtUmsatz = expected
        actual = target.txtUmsatz
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtVersandkosten"
    '''</summary>
    <TestMethod()> _
    Public Sub txtVersandkostenTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtVersandkosten = expected
        actual = target.txtVersandkosten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_Artikelbeschreibung"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_ArtikelbeschreibungTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_Artikelbeschreibung = expected
        actual = target.versand_Artikelbeschreibung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_auktionsende"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_auktionsendeTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_auktionsende = expected
        actual = target.versand_auktionsende
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_bild"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_bildTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_bild = expected
        actual = target.versand_bild
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_ebayID"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_ebayIDTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_ebayID = expected
        actual = target.versand_ebayID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_endpreis"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_endpreisTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_endpreis = expected
        actual = target.versand_endpreis
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_plattform"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_plattformTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_plattform = expected
        actual = target.versand_plattform
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_status"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_statusTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_status = expected
        actual = target.versand_status
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "versand_versandkosten"
    '''</summary>
    <TestMethod()> _
    Public Sub versand_versandkostenTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.versand_versandkosten = expected
        actual = target.versand_versandkosten
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "VerschicktToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub VerschicktToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.VerschicktToolStripMenuItem = expected
        actual = target.VerschicktToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundenverlaufToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEKundenverlaufToolStripMenuItemTest()
        Dim target As frmBestellung_Versandkosten = New frmBestellung_Versandkosten ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEKundenverlaufToolStripMenuItem = expected
        actual = target.YABEKundenverlaufToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
