Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmOutlook_syncTest" und soll
'''alle frmOutlook_syncTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmOutlook_syncTest


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
    '''Ein Test für "frmOutlook_sync-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub frmOutlook_syncConstructorTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikeldatenbankArtikelSuchenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ArtikeldatenbankArtikelSuchenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ArtikeldatenbankArtikelSuchenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnEmailsRead_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnEmailsRead_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnEmailsRead_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnOoutLook2Yabe_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnOoutLook2Yabe_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnOoutLook2Yabe_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnOutlook_contacts_sync_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnOutlook_contacts_sync_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnOutlook_contacts_sync_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "btnOutlook_items_sync_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub btnOutlook_items_sync_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.btnOutlook_items_sync_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "chkHeute_CheckedChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub chkHeute_CheckedChangedTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.chkHeute_CheckedChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeArchivToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeArchivToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeArchivToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeKundenprofileAktullisierenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeKundenprofileAktullisierenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeKundenprofileAktullisierenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeOrdnerToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DelcampeOrdnerToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.DelcampeOrdnerToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "Dispose"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub DisposeTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim disposing As Boolean = False ' TODO: Passenden Wert initialisieren
        target.Dispose(disposing)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArchivToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayArchivToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayArchivToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EBayToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EBayToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EntferneMakierteToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EntferneMakierteToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EntferneMakierteToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "EntwürfeToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub EntwürfeToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.EntwürfeToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "ExportAnsichtToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ExportAnsichtToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ExportAnsichtToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmOutlook_sync_Leave"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmOutlook_sync_LeaveTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmOutlook_sync_Leave(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmOutlook_sync_Load"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmOutlook_sync_LoadTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmOutlook_sync_Load(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "frmOutlook_sync_LostFocus"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub frmOutlook_sync_LostFocusTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.frmOutlook_sync_LostFocus(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "GelöschteEmailsToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub GelöschteEmailsToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.GelöschteEmailsToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "GesendeteToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub GesendeteToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.GesendeteToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "getOutlook2Yabe_emails"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getOutlook2Yabe_emailsTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getOutlook2Yabe_emails
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ImmerImVordergrundToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub ImmerImVordergrundToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.ImmerImVordergrundToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InboxToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InboxToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.InboxToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "InitializeComponent"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        target.InitializeComponent()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "KalenderToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub KalenderToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.KalenderToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lookform"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lookformTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim modus As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.lookform(modus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_items_ColumnClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwOutlook_items_ColumnClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwOutlook_items_ColumnClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_items_DragDrop"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwOutlook_items_DragDropTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As DragEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwOutlook_items_DragDrop(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_items_DragEnter"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwOutlook_items_DragEnterTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As DragEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwOutlook_items_DragEnter(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_items_ItemDrag"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwOutlook_items_ItemDragTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As ItemDragEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwOutlook_items_ItemDrag(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_items_MouseDoubleClick"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwOutlook_items_MouseDoubleClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwOutlook_items_MouseDoubleClick(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_items_SelectedIndexChanged"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub lvwOutlook_items_SelectedIndexChangedTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.lvwOutlook_items_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineAufgabenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub MeineAufgabenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.MeineAufgabenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NurBewertungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NurBewertungenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NurBewertungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "NurVerkäufeToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub NurVerkäufeToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.NurVerkäufeToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "outlook_items_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub outlook_items_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.outlook_items_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "PostausgangToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub PostausgangToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.PostausgangToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setLvwDataSelect_Aktion"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setLvwDataSelect_AktionTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim strModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setLvwDataSelect_Aktion(strModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setOpenWebBrowser"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub setOpenWebBrowserTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        target.setOpenWebBrowser()
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "setOutLook2Yabe"
    '''</summary>
    <TestMethod()> _
    Public Sub setOutLook2YabeTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setOutLook2Yabe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundenbestellungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub SucheKundenbestellungenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.SucheKundenbestellungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TextLesenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TextLesenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TextLesenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "TransparentToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub TransparentToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.TransparentToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEBrowserToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEBrowserToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEBrowserToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundenbestellungenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEKundenbestellungenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEKundenbestellungenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundendatenbanToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEKundendatenbanToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEKundendatenbanToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEMakiereBekannteKundenToolStripMenuItem_Click"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub YABEMakiereBekannteKundenToolStripMenuItem_ClickTest()
        Dim target As frmOutlook_sync_Accessor = New frmOutlook_sync_Accessor ' TODO: Passenden Wert initialisieren
        Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
        Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
        target.YABEMakiereBekannteKundenToolStripMenuItem_Click(sender, e)
        Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
    End Sub

    '''<summary>
    '''Ein Test für "AnsichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub AnsichtToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.AnsichtToolStripMenuItem = expected
        actual = target.AnsichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ArtikeldatenbankArtikelSuchenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ArtikeldatenbankArtikelSuchenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ArtikeldatenbankArtikelSuchenToolStripMenuItem = expected
        actual = target.ArtikeldatenbankArtikelSuchenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Beschreibung"
    '''</summary>
    <TestMethod()> _
    Public Sub BeschreibungTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.Beschreibung = expected
        actual = target.Beschreibung
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnEmailsRead"
    '''</summary>
    <TestMethod()> _
    Public Sub btnEmailsReadTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnEmailsRead = expected
        actual = target.btnEmailsRead
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnOoutLook2Yabe"
    '''</summary>
    <TestMethod()> _
    Public Sub btnOoutLook2YabeTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnOoutLook2Yabe = expected
        actual = target.btnOoutLook2Yabe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "btnOutlook_contacts_sync"
    '''</summary>
    <TestMethod()> _
    Public Sub btnOutlook_contacts_syncTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Button
        target.btnOutlook_contacts_sync = expected
        actual = target.btnOutlook_contacts_sync
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkHeute"
    '''</summary>
    <TestMethod()> _
    Public Sub chkHeuteTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As CheckBox
        target.chkHeute = expected
        actual = target.chkHeute
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "conOutlook_items"
    '''</summary>
    <TestMethod()> _
    Public Sub conOutlook_itemsTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ContextMenuStrip
        target.conOutlook_items = expected
        actual = target.conOutlook_items
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeArchivToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeArchivToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeArchivToolStripMenuItem = expected
        actual = target.DelcampeArchivToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeKundenprofileAktullisierenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeKundenprofileAktullisierenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeKundenprofileAktullisierenToolStripMenuItem = expected
        actual = target.DelcampeKundenprofileAktullisierenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DelcampeOrdnerToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub DelcampeOrdnerToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.DelcampeOrdnerToolStripMenuItem = expected
        actual = target.DelcampeOrdnerToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayArchivToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayArchivToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayArchivToolStripMenuItem = expected
        actual = target.EBayArchivToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EBayToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EBayToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EBayToolStripMenuItem = expected
        actual = target.EBayToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EntferneMakierteToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EntferneMakierteToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EntferneMakierteToolStripMenuItem = expected
        actual = target.EntferneMakierteToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "EntwürfeToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub EntwürfeToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.EntwürfeToolStripMenuItem = expected
        actual = target.EntwürfeToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ExportAnsichtToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ExportAnsichtToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ExportAnsichtToolStripMenuItem = expected
        actual = target.ExportAnsichtToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "FunktionenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub FunktionenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.FunktionenToolStripMenuItem = expected
        actual = target.FunktionenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GelöschteEmailsToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub GelöschteEmailsToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.GelöschteEmailsToolStripMenuItem = expected
        actual = target.GelöschteEmailsToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "GesendeteToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub GesendeteToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.GesendeteToolStripMenuItem = expected
        actual = target.GesendeteToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ID"
    '''</summary>
    <TestMethod()> _
    Public Sub IDTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.ID = expected
        actual = target.ID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ImageList1"
    '''</summary>
    <TestMethod()> _
    Public Sub ImageList1Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ImageList = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ImageList
        target.ImageList1 = expected
        actual = target.ImageList1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ImmerImVordergrundToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub ImmerImVordergrundToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.ImmerImVordergrundToolStripMenuItem = expected
        actual = target.ImmerImVordergrundToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "InboxToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub InboxToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.InboxToolStripMenuItem = expected
        actual = target.InboxToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_auctionservice"
    '''</summary>
    <TestMethod()> _
    Public Sub item_auctionserviceTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_auctionservice = expected
        actual = target.item_auctionservice
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_content"
    '''</summary>
    <TestMethod()> _
    Public Sub item_contentTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_content = expected
        actual = target.item_content
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_date"
    '''</summary>
    <TestMethod()> _
    Public Sub item_dateTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_date = expected
        actual = target.item_date
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_delcampe_mutter"
    '''</summary>
    <TestMethod()> _
    Public Sub item_delcampe_mutterTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_delcampe_mutter = expected
        actual = target.item_delcampe_mutter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_delcampe_sprachliste"
    '''</summary>
    <TestMethod()> _
    Public Sub item_delcampe_sprachlisteTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_delcampe_sprachliste = expected
        actual = target.item_delcampe_sprachliste
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_delcampeuser_id"
    '''</summary>
    <TestMethod()> _
    Public Sub item_delcampeuser_idTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_delcampeuser_id = expected
        actual = target.item_delcampeuser_id
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_email"
    '''</summary>
    <TestMethod()> _
    Public Sub item_emailTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_email = expected
        actual = target.item_email
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_id"
    '''</summary>
    <TestMethod()> _
    Public Sub item_idTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_id = expected
        actual = target.item_id
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_item_name"
    '''</summary>
    <TestMethod()> _
    Public Sub item_item_nameTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_item_name = expected
        actual = target.item_item_name
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_item_price"
    '''</summary>
    <TestMethod()> _
    Public Sub item_item_priceTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_item_price = expected
        actual = target.item_item_price
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_item_sku"
    '''</summary>
    <TestMethod()> _
    Public Sub item_item_skuTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_item_sku = expected
        actual = target.item_item_sku
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_person_city"
    '''</summary>
    <TestMethod()> _
    Public Sub item_person_cityTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_person_city = expected
        actual = target.item_person_city
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_person_login"
    '''</summary>
    <TestMethod()> _
    Public Sub item_person_loginTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_person_login = expected
        actual = target.item_person_login
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_person_name"
    '''</summary>
    <TestMethod()> _
    Public Sub item_person_nameTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_person_name = expected
        actual = target.item_person_name
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_person_street"
    '''</summary>
    <TestMethod()> _
    Public Sub item_person_streetTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_person_street = expected
        actual = target.item_person_street
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_person_zip"
    '''</summary>
    <TestMethod()> _
    Public Sub item_person_zipTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_person_zip = expected
        actual = target.item_person_zip
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_plattformModus"
    '''</summary>
    <TestMethod()> _
    Public Sub item_plattformModusTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_plattformModus = expected
        actual = target.item_plattformModus
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_subject"
    '''</summary>
    <TestMethod()> _
    Public Sub item_subjectTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_subject = expected
        actual = target.item_subject
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "item_webID"
    '''</summary>
    <TestMethod()> _
    Public Sub item_webIDTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ColumnHeader
        target.item_webID = expected
        actual = target.item_webID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "KalenderToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub KalenderToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.KalenderToolStripMenuItem = expected
        actual = target.KalenderToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "Label1"
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_contacts"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwOutlook_contactsTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwOutlook_contacts = expected
        actual = target.lvwOutlook_contacts
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "lvwOutlook_items"
    '''</summary>
    <TestMethod()> _
    Public Sub lvwOutlook_itemsTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ListView
        target.lvwOutlook_items = expected
        actual = target.lvwOutlook_items
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MeineAufgabenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub MeineAufgabenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.MeineAufgabenToolStripMenuItem = expected
        actual = target.MeineAufgabenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MenuStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub MenuStrip1Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As MenuStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As MenuStrip
        target.MenuStrip1 = expected
        actual = target.MenuStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NurBewertungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub NurBewertungenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.NurBewertungenToolStripMenuItem = expected
        actual = target.NurBewertungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "NurVerkäufeToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub NurVerkäufeToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.NurVerkäufeToolStripMenuItem = expected
        actual = target.NurVerkäufeToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "optOutlook_filter_alle"
    '''</summary>
    <TestMethod()> _
    Public Sub optOutlook_filter_alleTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.optOutlook_filter_alle = expected
        actual = target.optOutlook_filter_alle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "optOutlook_filter_delcampe"
    '''</summary>
    <TestMethod()> _
    Public Sub optOutlook_filter_delcampeTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.optOutlook_filter_delcampe = expected
        actual = target.optOutlook_filter_delcampe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "optOutlook_filter_ebay"
    '''</summary>
    <TestMethod()> _
    Public Sub optOutlook_filter_ebayTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As RadioButton
        target.optOutlook_filter_ebay = expected
        actual = target.optOutlook_filter_ebay
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "outlook_contacts"
    '''</summary>
    <TestMethod()> _
    Public Sub outlook_contactsTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.outlook_contacts = expected
        actual = target.outlook_contacts
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "outlook_items"
    '''</summary>
    <TestMethod()> _
    Public Sub outlook_itemsTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabPage
        target.outlook_items = expected
        actual = target.outlook_items
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "OutlookOrdnerToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub OutlookOrdnerToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.OutlookOrdnerToolStripMenuItem = expected
        actual = target.OutlookOrdnerToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "PostausgangToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub PostausgangToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.PostausgangToolStripMenuItem = expected
        actual = target.PostausgangToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "StatusStrip1"
    '''</summary>
    <TestMethod()> _
    Public Sub StatusStrip1Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As StatusStrip = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As StatusStrip
        target.StatusStrip1 = expected
        actual = target.StatusStrip1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "SucheKundenbestellungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub SucheKundenbestellungenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.SucheKundenbestellungenToolStripMenuItem = expected
        actual = target.SucheKundenbestellungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "tabOutlook_menue"
    '''</summary>
    <TestMethod()> _
    Public Sub tabOutlook_menueTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As TabControl
        target.tabOutlook_menue = expected
        actual = target.tabOutlook_menue
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TextLesenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub TextLesenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.TextLesenToolStripMenuItem = expected
        actual = target.TextLesenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator1Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator1 = expected
        actual = target.ToolStripSeparator1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator2"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator2Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator2 = expected
        actual = target.ToolStripSeparator2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator3"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator3Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
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
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator4 = expected
        actual = target.ToolStripSeparator4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator5"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator5Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator5 = expected
        actual = target.ToolStripSeparator5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripSeparator6"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripSeparator6Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
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
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
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
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripSeparator
        target.ToolStripSeparator8 = expected
        actual = target.ToolStripSeparator8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "ToolStripStatusLabel1"
    '''</summary>
    <TestMethod()> _
    Public Sub ToolStripStatusLabel1Test()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripStatusLabel = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripStatusLabel
        target.ToolStripStatusLabel1 = expected
        actual = target.ToolStripStatusLabel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "TransparentToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub TransparentToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.TransparentToolStripMenuItem = expected
        actual = target.TransparentToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "yabe_dashboard_header"
    '''</summary>
    <TestMethod()> _
    Public Sub yabe_dashboard_headerTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As Label
        target.yabe_dashboard_header = expected
        actual = target.yabe_dashboard_header
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEBrowserToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEBrowserToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEBrowserToolStripMenuItem = expected
        actual = target.YABEBrowserToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundenbestellungenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEKundenbestellungenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEKundenbestellungenToolStripMenuItem = expected
        actual = target.YABEKundenbestellungenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEKundendatenbanToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEKundendatenbanToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEKundendatenbanToolStripMenuItem = expected
        actual = target.YABEKundendatenbanToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "YABEMakiereBekannteKundenToolStripMenuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub YABEMakiereBekannteKundenToolStripMenuItemTest()
        Dim target As frmOutlook_sync = New frmOutlook_sync ' TODO: Passenden Wert initialisieren
        Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ToolStripMenuItem
        target.YABEMakiereBekannteKundenToolStripMenuItem = expected
        actual = target.YABEMakiereBekannteKundenToolStripMenuItem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
