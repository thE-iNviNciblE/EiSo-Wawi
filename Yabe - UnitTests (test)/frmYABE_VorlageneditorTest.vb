Imports System

Imports System.DirectoryServices

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmYABE_VorlageneditorTest" und soll
'''alle frmYABE_VorlageneditorTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmYABE_VorlageneditorTest


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
    '''Ein Test für "frmYABE_Vorlageneditor-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmYABE_VorlageneditorConstructorTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "Bild_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Bild_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Bild_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Bold_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Bold_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Bold_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAbbrechen_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnAbbrechen_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnAbbrechen_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAbschickenNewsletter_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnAbschickenNewsletter_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnAbschickenNewsletter_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Button1_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Button1_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Button1_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbGruppierung_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbGruppierung_SelectedIndexChangedTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbGruppierung_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbTranslationBereichAuswählen_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbTranslationBereichAuswählen_SelectedIndexChangedTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbTranslationBereichAuswählen_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbVorlage_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub cmbVorlage_SelectedIndexChangedTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.cmbVorlage_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "data"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub dataTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        target.data()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DHTMLControll_PreviewKeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DHTMLControll_PreviewKeyDownTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As PreviewKeyDownEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DHTMLControll_PreviewKeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DruckenToolStripButton_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DruckenToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmTranslationEditor_FormClosing"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmTranslationEditor_FormClosingTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As FormClosingEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmTranslationEditor_FormClosing(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmTranslationEditor_KeyDown"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmTranslationEditor_KeyDownTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmTranslationEditor_KeyDown(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmTranslationEditor_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmTranslationEditor_LoadTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmTranslationEditor_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Hyperlink_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Hyperlink_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Hyperlink_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel1_LinkClicked_1"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LinkLabel1_LinkClicked_1Test()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As LinkLabelLinkClickedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LinkLabel1_LinkClicked_1(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel2_LinkClicked"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LinkLabel2_LinkClickedTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As LinkLabelLinkClickedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LinkLabel2_LinkClicked(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub LöschenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.LöschenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NeueVorlageAnlegenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NeueVorlageAnlegenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NeueVorlageAnlegenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NeuToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NeuToolStripButton_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NeuToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ÖffnenToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ÖffnenToolStripButton_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ÖffnenToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Redo_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Redo_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Redo_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "SpeichernToolStripButton_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SpeichernToolStripButton_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SpeichernToolStripButton_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Suchen_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Suchen_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Suchen_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "UmbennenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub UmbennenToolStripMenuItem_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.UmbennenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Undo_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub Undo_ClickTest()
        Dim target As frmYABE_Vorlageneditor_Accessor = New frmYABE_Vorlageneditor_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.Undo_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AusschneidenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub AusschneidenToolStripButtonTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.AusschneidenToolStripButton = expected
        actual = target.AusschneidenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Bild"
    '''</summary>
    <TestMethod()> _
    Public Sub BildTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Bild = expected
        actual = target.Bild
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Bold"
    '''</summary>
    <TestMethod()> _
    Public Sub BoldTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Bold = expected
        actual = target.Bold
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAbbrechen"
    '''</summary>
    <TestMethod()> _
    Public Sub btnAbbrechenTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnAbbrechen = expected
        actual = target.btnAbbrechen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnAbschickenNewsletter"
    '''</summary>
    <TestMethod()> _
    Public Sub btnAbschickenNewsletterTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnAbschickenNewsletter = expected
        actual = target.btnAbschickenNewsletter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnLaden"
    '''</summary>
    <TestMethod()> _
    Public Sub btnLadenTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnLaden = expected
        actual = target.btnLaden
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbGruppierung"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbGruppierungTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbGruppierung = expected
        actual = target.cmbGruppierung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbSprache"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbSpracheTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbSprache = expected
        actual = target.cmbSprache
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "cmbVorlage"
    '''</summary>
    <TestMethod()> _
    Public Sub cmbVorlageTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ComboBox
        target.cmbVorlage = expected
        actual = target.cmbVorlage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "conNeueVorlage"
    '''</summary>
    <TestMethod()> _
    Public Sub conNeueVorlageTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.conNeueVorlage = expected
        actual = target.conNeueVorlage
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DirectorySearcher1"
    '''</summary>
    <TestMethod()> _
    Public Sub DirectorySearcher1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As DirectorySearcher = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As DirectorySearcher
        target.DirectorySearcher1 = expected
        actual = target.DirectorySearcher1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DruckenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub DruckenToolStripButtonTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.DruckenToolStripButton = expected
        actual = target.DruckenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EinfügenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub EinfügenToolStripButtonTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.EinfügenToolStripButton = expected
        actual = target.EinfügenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Hyperlink"
    '''</summary>
    <TestMethod()> _
    Public Sub HyperlinkTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Hyperlink = expected
        actual = target.Hyperlink
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KopierenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub KopierenToolStripButtonTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.KopierenToolStripButton = expected
        actual = target.KopierenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label2"
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lblVorlagenHeader"
    '''</summary>
    <TestMethod()> _
    Public Sub lblVorlagenHeaderTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.lblVorlagenHeader = expected
        actual = target.lblVorlagenHeader
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel1"
    '''</summary>
    <TestMethod()> _
    Public Sub LinkLabel1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As LinkLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As LinkLabel
        target.LinkLabel1 = expected
        actual = target.LinkLabel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LinkLabel2"
    '''</summary>
    <TestMethod()> _
    Public Sub LinkLabel2Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As LinkLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As LinkLabel
        target.LinkLabel2 = expected
        actual = target.LinkLabel2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "LöschenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub LöschenToolStripMenuItemTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.LöschenToolStripMenuItem = expected
        actual = target.LöschenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NeueVorlageAnlegenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub NeueVorlageAnlegenToolStripMenuItemTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.NeueVorlageAnlegenToolStripMenuItem = expected
        actual = target.NeueVorlageAnlegenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NeuToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub NeuToolStripButtonTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.NeuToolStripButton = expected
        actual = target.NeuToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ÖffnenToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub ÖffnenToolStripButtonTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.ÖffnenToolStripButton = expected
        actual = target.ÖffnenToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OpenFileDialog1"
    '''</summary>
    <TestMethod()> _
    Public Sub OpenFileDialog1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As OpenFileDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As OpenFileDialog
        target.OpenFileDialog1 = expected
        actual = target.OpenFileDialog1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Panel1"
    '''</summary>
    <TestMethod()> _
    Public Sub Panel1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Panel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Redo"
    '''</summary>
    <TestMethod()> _
    Public Sub RedoTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Redo = expected
        actual = target.Redo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SaveFileDialog1"
    '''</summary>
    <TestMethod()> _
    Public Sub SaveFileDialog1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As SaveFileDialog = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As SaveFileDialog
        target.SaveFileDialog1 = expected
        actual = target.SaveFileDialog1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SpeichernToolStripButton"
    '''</summary>
    <TestMethod()> _
    Public Sub SpeichernToolStripButtonTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.SpeichernToolStripButton = expected
        actual = target.SpeichernToolStripButton
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Suchen"
    '''</summary>
    <TestMethod()> _
    Public Sub SuchenTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Suchen = expected
        actual = target.Suchen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tabelle"
    '''</summary>
    <TestMethod()> _
    Public Sub tabelleTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.tabelle = expected
        actual = target.tabelle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStrip1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStrip
        target.ToolStrip1 = expected
        actual = target.ToolStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparatorTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator = expected
        actual = target.toolStripSeparator
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator1Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator1 = expected
        actual = target.ToolStripSeparator1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "toolStripSeparator2"
    '''</summary>
    <TestMethod()> _
    Public Sub toolStripSeparator2Test()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.toolStripSeparator2 = expected
        actual = target.toolStripSeparator2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "txtVorlageQuellcode"
    '''</summary>
    <TestMethod()> _
    Public Sub txtVorlageQuellcodeTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TextBox
        target.txtVorlageQuellcode = expected
        actual = target.txtVorlageQuellcode
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "UmbennenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub UmbennenToolStripMenuItemTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.UmbennenToolStripMenuItem = expected
        actual = target.UmbennenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Undo"
    '''</summary>
    <TestMethod()> _
    Public Sub UndoTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripButton
        target.Undo = expected
        actual = target.Undo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "yabe_dashboard_header"
    '''</summary>
    <TestMethod()> _
    Public Sub yabe_dashboard_headerTest()
        Dim target As frmYABE_Vorlageneditor = New frmYABE_Vorlageneditor ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.yabe_dashboard_header = expected
        actual = target.yabe_dashboard_header
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
