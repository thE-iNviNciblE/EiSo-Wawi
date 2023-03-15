Imports System.Collections

Imports System

Imports System.ComponentModel

Imports ZedGraph

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "frmAuktionmanagementTest" und soll
'''alle frmAuktionmanagementTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class frmAuktionmanagementTest


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
'''Ein Test für "frmAuktionmanagement-Konstruktor"
'''</summary>
<TestMethod()>  _
Public Sub frmAuktionmanagementConstructorTest()
    Dim target As frmAuktionmanagement = New frmAuktionmanagement
    Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
End Sub

'''<summary>
'''Ein Test für "AktuallisierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AktuallisierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AktuallisierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AktuellToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AktuellToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AktuellToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AlleMarkierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AlleMarkierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AlleMarkierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AlsBewertetSetzenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AlsBewertetSetzenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AlsBewertetSetzenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AnsichtAktuallisierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AnsichtAktuallisierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AnsichtAktuallisierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AnsichtAktuallisierenToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AnsichtAktuallisierenToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AnsichtAktuallisierenToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AnsichtAktuallisierenToolStripMenuItem2_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AnsichtAktuallisierenToolStripMenuItem2_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AnsichtAktuallisierenToolStripMenuItem2_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ArchivAktuallisierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ArchivAktuallisierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ArchivAktuallisierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ArtikelAlleImportiertenLöschenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ArtikelAlleImportiertenLöschenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ArtikelAlleImportiertenLöschenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ArtikelBeendenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ArtikelBeendenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ArtikelBeendenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ArtikelKomplettLöschenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ArtikelKomplettLöschenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ArtikelKomplettLöschenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ArtikelLöschenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ArtikelLöschenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ArtikelLöschenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ArtikelLöschenToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ArtikelLöschenToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ArtikelLöschenToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ArtikelSuchenUndErsetzenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ArtikelSuchenUndErsetzenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ArtikelSuchenUndErsetzenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AussortiertToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AussortiertToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AussortiertToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AutomatischSpracheÄndernToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub AutomatischSpracheÄndernToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.AutomatischSpracheÄndernToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BackgroundWorker1_DoWork"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BackgroundWorker1_DoWorkTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DoWorkEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BackgroundWorker1_DoWork(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BestelltToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BestelltToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BestelltToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BestellübersichtToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BestellübersichtToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BestellübersichtToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BestellübersichtToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BestellübersichtToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BestellübersichtToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BestellübersichtToolStripMenuItem2_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BestellübersichtToolStripMenuItem2_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BestellübersichtToolStripMenuItem2_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BewertetToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BewertetToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BewertetToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BewertungsprofilinternToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BewertungsprofilinternToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BewertungsprofilinternToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BewertungsprofilÖffnenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BewertungsprofilÖffnenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BewertungsprofilÖffnenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BezahltToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BezahltToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BezahltToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BietverlaufToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BietverlaufToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BietverlaufToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BietverlaufToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BietverlaufToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BietverlaufToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BildLöschenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BildLöschenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BildLöschenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnAbbrechen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnAbbrechen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnAbbrechen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnAbschickenNewsletter_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnAbschickenNewsletter_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnAbschickenNewsletter_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnAdressLabels_click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnAdressLabels_clickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnAdressLabels_click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnAuktionsende_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnAuktionsende_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnAuktionsende_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnAuktionsende_MouseHover"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnAuktionsende_MouseHoverTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnAuktionsende_MouseHover(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnAuktionsende_MouseLeave"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnAuktionsende_MouseLeaveTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnAuktionsende_MouseLeave(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnCheckPictures_Click_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnCheckPictures_Click_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnCheckPictures_Click_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnCheckPictures_Click_2"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnCheckPictures_Click_2Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnCheckPictures_Click_2(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnCheckPictures_Click_3"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnCheckPictures_Click_3Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnCheckPictures_Click_3(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btneBayLiveRefresh_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btneBayLiveRefresh_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btneBayLiveRefresh_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnEdit_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnEdit_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnEdit_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnEinlesen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnEinlesen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnEinlesen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BtnGetAccount_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BtnGetAccount_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BtnGetAccount_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnGetCMSBestellungen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnGetCMSBestellungen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnGetCMSBestellungen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "BtnGetMemberMessages_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub BtnGetMemberMessages_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.BtnGetMemberMessages_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnGoogleBase_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnGoogleBase_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnGoogleBase_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnGoogleBase_Click_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnGoogleBase_Click_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnGoogleBase_Click_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnLiveStopp_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnLiveStopp_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnLiveStopp_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnMailVersandStart_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnMailVersandStart_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnMailVersandStart_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnMeineBayÖffnen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnMeineBayÖffnen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnMeineBayÖffnen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnNachrichtenzenter_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnNachrichtenzenter_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnNachrichtenzenter_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnNachrichtenzenter_Click_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnNachrichtenzenter_Click_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnNachrichtenzenter_Click_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnNewsletterCRC_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnNewsletterCRC_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnNewsletterCRC_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnNewsletterReset_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnNewsletterReset_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnNewsletterReset_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnPaypal_abrufen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnPaypal_abrufen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnPaypal_abrufen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnPrüfeWebArtikel_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnPrüfeWebArtikel_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnPrüfeWebArtikel_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnRechnungansehen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnRechnungansehen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnRechnungansehen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnRefresh2_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnRefresh2_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnRefresh2_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnRefresh2_MouseLeave"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnRefresh2_MouseLeaveTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnRefresh2_MouseLeave(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnSendEMail_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnSendEMail_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnSendEMail_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnSuchen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnSuchen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnSuchen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnTools_CMSArtikel_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnTools_CMSArtikel_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnTools_CMSArtikel_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnTools_eBayGalerie_Click_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnTools_eBayGalerie_Click_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnTools_eBayGalerie_Click_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnVerlaufStatus_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnVerlaufStatus_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnVerlaufStatus_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "btnVor_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub btnVor_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.btnVor_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Button1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Button1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Button1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Button1_Click_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Button1_Click_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Button1_Click_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Button1_Click_2"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Button1_Click_2Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Button1_Click_2(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Button2_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Button2_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Button2_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Button2_Click_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Button2_Click_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Button2_Click_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CheckBox1_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CheckBox1_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.CheckBox1_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkArtikeldatenbank_edit_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkArtikeldatenbank_edit_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkArtikeldatenbank_edit_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkAutomatischerModus_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkAutomatischerModus_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkAutomatischerModus_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Alle_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungen_Alle_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungen_Alle_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_bezahlt_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungen_bezahlt_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungen_bezahlt_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_KeineBewertung_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungen_KeineBewertung_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungen_KeineBewertung_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Komplett_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungen_Komplett_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungen_Komplett_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Storniert_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungen_Storniert_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungen_Storniert_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_verkauft_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungen_verkauft_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungen_verkauft_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Versand_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungen_Versand_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungen_Versand_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungenVerkauft_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungenVerkauft_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungenVerkauft_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungVersand_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBestellungVersand_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBestellungVersand_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBewertung_janein_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBewertung_janein_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBewertung_janein_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBewertungZeitfilter_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBewertungZeitfilter_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBewertungZeitfilter_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkBuyItNow_CheckedChanged_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkBuyItNow_CheckedChanged_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkBuyItNow_CheckedChanged_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkCMSEnglisch_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkCMSEnglisch_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkCMSEnglisch_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkDebug_email_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkDebug_email_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkDebug_email_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkDeleted_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkDeleted_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkDeleted_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkeBayEnde_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkeBayEnde_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkeBayEnde_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkeBayEnde_CheckedChanged_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkeBayEnde_CheckedChanged_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkeBayEnde_CheckedChanged_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkEbayLive_Gebote_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkEbayLive_Gebote_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkEbayLive_Gebote_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkEndTime_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkEndTime_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkEndTime_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkGebote_CheckedChanged_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkGebote_CheckedChanged_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkGebote_CheckedChanged_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkHistoryZeitfilter_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkHistoryZeitfilter_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkHistoryZeitfilter_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkIsGesendet_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkIsGesendet_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkIsGesendet_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkKundenFullReport_CheckedChanged"
'''</summary>
<TestMethod()>  _
Public Sub chkKundenFullReport_CheckedChangedTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkKundenFullReport_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkKundenHeute_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkKundenHeute_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkKundenHeute_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkKundenZeitfilter_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkKundenZeitfilter_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkKundenZeitfilter_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkLiveAlle_CheckedChanged_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkLiveAlle_CheckedChanged_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkLiveAlle_CheckedChanged_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkLiveVerschickt_CheckedChanged_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkLiveVerschickt_CheckedChanged_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkLiveVerschickt_CheckedChanged_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkLiveZeitfilter_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkLiveZeitfilter_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkLiveZeitfilter_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkNewsletter_testmodus_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkNewsletter_testmodus_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkNewsletter_testmodus_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkNewsletterAlle_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkNewsletterAlle_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkNewsletterAlle_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkNewsletterIsWebuser_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkNewsletterIsWebuser_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkNewsletterIsWebuser_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkNurKlickt_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkNurKlickt_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkNurKlickt_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkStartupRückbewertung_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkStartupRückbewertung_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkStartupRückbewertung_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "chkVerschickt_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub chkVerschickt_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.chkVerschickt_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmbArtikelStatus_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmbArtikelStatus_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmbArtikelStatus_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmbLivePlattform_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmbLivePlattform_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmbLivePlattform_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmbPlattform_bestellungen_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmbPlattform_bestellungen_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmbPlattform_bestellungen_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmbPlattform_kunden_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmbPlattform_kunden_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmbPlattform_kunden_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmbSprache_Artikeldatenbank_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmbSprache_Artikeldatenbank_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmbSprache_Artikeldatenbank_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmdRechnen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmdRechnen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmdRechnen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cms_ArtikelVerwaltung_Opening"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cms_ArtikelVerwaltung_OpeningTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cms_ArtikelVerwaltung_Opening(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cms_KategorieListe_Opening"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cms_KategorieListe_OpeningTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cms_KategorieListe_Opening(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CMSAnsichtToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CMSAnsichtToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.CMSAnsichtToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmseBayBewertung_Opening"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmseBayBewertung_OpeningTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmseBayBewertung_Opening(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmseBayHistory_Opening"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmseBayHistory_OpeningTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmseBayHistory_Opening(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "cmsKundenListview_Opening"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub cmsKundenListview_OpeningTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.cmsKundenListview_Opening(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CompleteToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CompleteToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.CompleteToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Copy_Beschreibung_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Copy_Beschreibung_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Copy_Beschreibung_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CopyEBayIDToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CopyEBayIDToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.CopyEBayIDToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CopyEBayIDToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CopyEBayIDToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.CopyEBayIDToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CopyEBayMitgliedsnameToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CopyEBayMitgliedsnameToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.CopyEBayMitgliedsnameToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CreateGraph"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CreateGraphTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim zgc As ZedGraphControl = Nothing ' TODO: Passenden Wert initialisieren
    target.CreateGraph(zgc)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "CreateGroupsTable"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub CreateGroupsTableTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim column As Integer = 0 ' TODO: Passenden Wert initialisieren
Dim expected As Hashtable = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Hashtable
    actual = target.CreateGroupsTable(lvw, column)
    Assert.AreEqual(lvwExpected, lvw)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DatePickerBis_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DatePickerBis_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DatePickerBis_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DatePickerBis_LostFocus"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DatePickerBis_LostFocusTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DatePickerBis_LostFocus(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DatePickStartTo_ValueChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DatePickStartTo_ValueChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DatePickStartTo_ValueChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DateTimePickerVon_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DateTimePickerVon_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DateTimePickerVon_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DateTimePickerVon_LostFocus"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DateTimePickerVon_LostFocusTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DateTimePickerVon_LostFocus(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DateTimePickerVon_ValueChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DateTimePickerVon_ValueChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DateTimePickerVon_ValueChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DelcampeArtikelansichtToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DelcampeArtikelansichtToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DelcampeArtikelansichtToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DelcampeBestellsStatusAktuallisierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DelcampeBestellsStatusAktuallisierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DelcampeBestellsStatusAktuallisierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DelcampeBewertungenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DelcampeBewertungenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DelcampeBewertungenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DelcampeKategorieIDZuweisenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DelcampeKategorieIDZuweisenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DelcampeKategorieIDZuweisenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DelcampeKategorieIDZuweisenToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DelcampeKategorieIDZuweisenToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DelcampeKategorieIDZuweisenToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DelcampeVersandkostenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DelcampeVersandkostenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DelcampeVersandkostenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "DestinctArray"
'''</summary>
Public Sub DestinctArrayTestHelper(Of T)()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim arr() As T = Nothing ' TODO: Passenden Wert initialisieren
Dim expected() As T = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual() As T
    actual = target.DestinctArray(Of T)(arr)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DestinctArrayTest()
    DestinctArrayTestHelper(Of GenericParameterHelper)
End Sub

'''<summary>
'''Ein Test für "DeutschToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DeutschToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.DeutschToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Dispose"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub DisposeTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim disposing As Boolean = false ' TODO: Passenden Wert initialisieren
    target.Dispose(disposing)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "dtp_BewertungBis_LostFocus"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub dtp_BewertungBis_LostFocusTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.dtp_BewertungBis_LostFocus(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "dtp_BewertungVon_LostFocus"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub dtp_BewertungVon_LostFocusTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.dtp_BewertungVon_LostFocus(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayAnsichtToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayAnsichtToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayAnsichtToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayArtikelansichtToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayArtikelansichtToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayArtikelansichtToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayArtikelÖffnenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayArtikelÖffnenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayArtikelÖffnenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayAuktionArtikeldetialsToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayAuktionArtikeldetialsToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayAuktionArtikeldetialsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayBeschreibungErweiternToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayBeschreibungErweiternToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayBeschreibungErweiternToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayBewertungenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayBewertungenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayBewertungenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayCrossPromotionToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayCrossPromotionToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayCrossPromotionToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "eBayGeschichte_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub eBayGeschichte_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.eBayGeschichte_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "eBayHistoryBis_LostFocus"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub eBayHistoryBis_LostFocusTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.eBayHistoryBis_LostFocus(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayKundenInformationenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayKundenInformationenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayKundenInformationenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayLiveToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayLiveToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayLiveToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayÖffnenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayÖffnenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayÖffnenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayÖffnenToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayÖffnenToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayÖffnenToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayÖffnenToolStripMenuItem2_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayÖffnenToolStripMenuItem2_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayÖffnenToolStripMenuItem2_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayVerkaufseventsToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayVerkaufseventsToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayVerkaufseventsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EBayVersandkostenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EBayVersandkostenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EBayVersandkostenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EMailExternesProgrammToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EMailExternesProgrammToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EMailExternesProgrammToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EmailExternesProgrammToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EmailExternesProgrammToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EmailExternesProgrammToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EMailVorschauAnzeigenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EMailVorschauAnzeigenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EMailVorschauAnzeigenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EnglischToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EnglischToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EnglischToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "EntfernenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub EntfernenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.EntfernenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "eshop_daten_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub eshop_daten_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.eshop_daten_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "export"
'''</summary>
<TestMethod()>  _
Public Sub exportTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim strCat As frmAuktionmanagement.export_targets = New frmAuktionmanagement.export_targets ' TODO: Passenden Wert initialisieren
Dim mModus As frmAuktionmanagement.selectModus = New frmAuktionmanagement.selectModus ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.export(lvw, strCat, mModus)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportDelcampeToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportDelcampeToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportDelcampeToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportDelcampeToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportDelcampeToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportDelcampeToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportierenToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportierenToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem2_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportierenToolStripMenuItem2_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportierenToolStripMenuItem2_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem3_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportierenToolStripMenuItem3_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportierenToolStripMenuItem3_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem4_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportierenToolStripMenuItem4_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportierenToolStripMenuItem4_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem5_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportierenToolStripMenuItem5_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportierenToolStripMenuItem5_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportMagentoToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportMagentoToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportMagentoToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportStandardToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportStandardToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportStandardToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportStandardToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportStandardToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportStandardToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ExportToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ExportToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ExportToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "FehlendeÜbersetzungenHolenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub FehlendeÜbersetzungenHolenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.FehlendeÜbersetzungenHolenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "FranzösichToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub FranzösichToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.FranzösichToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "frmAuktionmanagement_Disposed"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub frmAuktionmanagement_DisposedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.frmAuktionmanagement_Disposed(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "frmAuktionmanagement_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub frmAuktionmanagement_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.frmAuktionmanagement_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "frmAuktionmanagement_Leave"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub frmAuktionmanagement_LeaveTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.frmAuktionmanagement_Leave(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "frmAuktionmanagement_Load"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub frmAuktionmanagement_LoadTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.frmAuktionmanagement_Load(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "frmAuktionmanagement_Resize"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub frmAuktionmanagement_ResizeTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.frmAuktionmanagement_Resize(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "frmLoad"
'''</summary>
<TestMethod()>  _
Public Sub frmLoadTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lngWaitTime As Long = 0 ' TODO: Passenden Wert initialisieren
Dim strMessage As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.frmLoad(lngWaitTime, strMessage)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getCheckBox_counts"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub getCheckBox_countsTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getCheckBox_counts(strName)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getCleanFilename"
'''</summary>
<TestMethod()>  _
Public Sub getCleanFilenameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
    Dim actual As String
    actual = target.getCleanFilename(strName)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getCreate_Graph_Month"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub getCreate_Graph_MonthTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim strMonth As Byte = 0 ' TODO: Passenden Wert initialisieren
Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
    Dim actual As String
    actual = target.getCreate_Graph_Month(strMonth)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getDateFromTimepicker"
'''</summary>
<TestMethod()>  _
Public Sub getDateFromTimepickerTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim strDatum As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim bBegin As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
    Dim actual As String
    actual = target.getDateFromTimepicker(strDatum, bBegin)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getEbayData"
'''</summary>
<TestMethod()>  _
Public Sub getEbayDataTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim bGeboteOnly As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getEbayData(bGeboteOnly)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "geteBaySellerList"
'''</summary>
<TestMethod()>  _
Public Sub geteBaySellerListTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim bEnde As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.geteBaySellerList(bEnde)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getGoogleTranslate"
'''</summary>
<TestMethod()>  _
Public Sub getGoogleTranslateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim strText As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim strGoogleZielsprache As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
    Dim actual As String
    actual = target.getGoogleTranslate(strText, strGoogleZielsprache)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getInitLoadTabChange"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub getInitLoadTabChangeTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getInitLoadTabChange(sender)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getLVW_Colum_ReOrder"
'''</summary>
<TestMethod()>  _
Public Sub getLVW_Colum_ReOrderTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getLVW_Colum_ReOrder(lvw)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getLvwData"
'''</summary>
<TestMethod()>  _
Public Sub getLvwDataTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim bSuchen As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getLvwData(lvw, bSuchen)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getMailTextVorlagen"
'''</summary>
<TestMethod()>  _
Public Sub getMailTextVorlagenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim cmbTranslationBereichAuswählen As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
Dim cmbTranslationBereichAuswählenExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getMailTextVorlagen(cmbTranslationBereichAuswählen)
    Assert.AreEqual(cmbTranslationBereichAuswählenExpected, cmbTranslationBereichAuswählen)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getMissingTranslations"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub getMissingTranslationsTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim lvwData As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwDataExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getMissingTranslations(lvwData)
    Assert.AreEqual(lvwDataExpected, lvwData)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getOrderHistory"
'''</summary>
<TestMethod()>  _
Public Sub getOrderHistoryTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim streMail As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getOrderHistory(lvw, streMail)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getPlattforms"
'''</summary>
<TestMethod()>  _
Public Sub getPlattformsTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim cmbCombo As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
Dim cmbComboExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
Dim strTabelle As clsDatenbank.datentabelle = New clsDatenbank.datentabelle ' TODO: Passenden Wert initialisieren
Dim strTime As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getPlattforms(cmbCombo, strTabelle, strTime)
    Assert.AreEqual(cmbComboExpected, cmbCombo)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getSellereBayList"
'''</summary>
<TestMethod()>  _
Public Sub getSellereBayListTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim iSeite As Integer = 0 ' TODO: Passenden Wert initialisieren
Dim bGeboteOnly As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getSellereBayList(iSeite, bGeboteOnly)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getSellerTransaction"
'''</summary>
<TestMethod()>  _
Public Sub getSellerTransactionTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim DateTimePickerVon As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
Dim DatePickerBis As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getSellerTransaction(DateTimePickerVon, DatePickerBis)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getShopMenue"
'''</summary>
<TestMethod()>  _
Public Sub getShopMenueTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getShopMenue(lvw)
    Assert.AreEqual(lvwExpected, lvw)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getSQLQuery_Options"
'''</summary>
<TestMethod()>  _
Public Sub getSQLQuery_OptionsTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim bSuche As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
    Dim actual As String
    actual = target.getSQLQuery_Options(lvw, bSuche)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getSuchen"
'''</summary>
<TestMethod()>  _
Public Sub getSuchenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.getSuchen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getVorlage_linktext"
'''</summary>
<TestMethod()>  _
Public Sub getVorlage_linktextTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim modus As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
    Dim actual As String
    actual = target.getVorlage_linktext(modus)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GoogleMapsToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GoogleMapsToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GoogleMapsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "GoogleMapsToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GoogleMapsToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GoogleMapsToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "GroupiertVerkaufsendeToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GroupiertVerkaufsendeToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GroupiertVerkaufsendeToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "GruppiertBestellstatusToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GruppiertBestellstatusToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GruppiertBestellstatusToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "GruppiertKeineToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GruppiertKeineToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GruppiertKeineToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "GruppiertLandToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GruppiertLandToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GruppiertLandToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "GruppiertMutterspracheToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GruppiertMutterspracheToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GruppiertMutterspracheToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "GruppiertNameToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub GruppiertNameToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.GruppiertNameToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "HöchstbietenderBewertungsprofilToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub HöchstbietenderBewertungsprofilToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.HöchstbietenderBewertungsprofilToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "HöchstbietenderBewertungsprofilToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub HöchstbietenderBewertungsprofilToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.HöchstbietenderBewertungsprofilToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "HöchstbietenderToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub HöchstbietenderToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.HöchstbietenderToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "InitializeComponent"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
    target.InitializeComponent
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "IsSendToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub IsSendToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.IsSendToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KategorieHauptkategorieToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KategorieHauptkategorieToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KategorieHauptkategorieToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KategorieLöschenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KategorieLöschenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KategorieLöschenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KategorieNeueSubkategorieToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KategorieNeueSubkategorieToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KategorieNeueSubkategorieToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KopierenArtikelIDToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KopierenArtikelIDToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KopierenArtikelIDToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KopierenEmailToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KopierenEmailToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KopierenEmailToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KopierenEmailToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KopierenEmailToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KopierenEmailToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KopierenNameToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KopierenNameToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KopierenNameToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KopierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KopierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KopierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KundeLöschenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KundeLöschenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KundeLöschenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KundenBis_ValueChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KundenBis_ValueChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KundenBis_ValueChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KundenEditierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KundenEditierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KundenEditierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KundenNeuToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KundenNeuToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KundenNeuToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KundenverlaufToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KundenverlaufToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KundenverlaufToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "KundenverlaufToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub KundenverlaufToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.KundenverlaufToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Label3_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Label3_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Label3_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lblVon_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lblVon_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lblVon_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Live_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Live_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Live_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "LiveÖffnenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub LiveÖffnenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.LiveÖffnenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lnlInfopanel_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lnlInfopanel_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lnlInfopanel_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "LöschenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub LöschenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.LöschenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvMailStatus_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvMailStatus_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvMailStatus_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvMailStatus_ColumnReordered"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvMailStatus_ColumnReorderedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnReorderedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvMailStatus_ColumnReordered(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvMailStatus_MouseDoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvMailStatus_MouseDoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvMailStatus_MouseDoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwBewertungen_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwBewertungen_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwBewertungen_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwBewertungen_ColumnReordered"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwBewertungen_ColumnReorderedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnReorderedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwBewertungen_ColumnReordered(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwBewertungen_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwBewertungen_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwBewertungen_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwBewertungen_MouseDoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwBewertungen_MouseDoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwBewertungen_MouseDoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayHistory_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayHistory_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayHistory_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayHistory_ColumnReordered"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayHistory_ColumnReorderedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnReorderedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayHistory_ColumnReordered(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayHistory_DoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayHistory_DoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayHistory_DoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayHistory_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayHistory_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayHistory_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayHistory_MouseDoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayHistory_MouseDoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayHistory_MouseDoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayLiveList_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayLiveList_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayLiveList_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayLiveList_ColumnReordered"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayLiveList_ColumnReorderedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnReorderedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayLiveList_ColumnReordered(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayLiveList_DoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayLiveList_DoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayLiveList_DoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayLiveList_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayLiveList_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayLiveList_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayLiveList_MouseDoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayLiveList_MouseDoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayLiveList_MouseDoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvweBayLiveList_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvweBayLiveList_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvweBayLiveList_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwKunden_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwKunden_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwKunden_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwKunden_ColumnReordered"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwKunden_ColumnReorderedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnReorderedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwKunden_ColumnReordered(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwKunden_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwKunden_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwKunden_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwKunden_MouseDoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwKunden_MouseDoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwKunden_MouseDoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwLiveAnsicht_Opening"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwLiveAnsicht_OpeningTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As CancelEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwLiveAnsicht_Opening(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwMenue_DragDrop"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwMenue_DragDropTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DragEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwMenue_DragDrop(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwMenue_DragEnter"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwMenue_DragEnterTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DragEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwMenue_DragEnter(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwMenue_KeyPress"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwMenue_KeyPressTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyPressEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwMenue_KeyPress(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwMenue_MouseHover"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwMenue_MouseHoverTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwMenue_MouseHover(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwMenue_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwMenue_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwMenue_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwPaypal_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwPaypal_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwPaypal_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwStatisticText_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwStatisticText_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwStatisticText_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel_ColumnClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwWebArtikel_ColumnClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwWebArtikel_ColumnClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel_ColumnReordered"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwWebArtikel_ColumnReorderedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnReorderedEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwWebArtikel_ColumnReordered(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel_ItemDrag"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwWebArtikel_ItemDragTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ItemDragEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwWebArtikel_ItemDrag(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel_KeyPress"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwWebArtikel_KeyPressTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyPressEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwWebArtikel_KeyPress(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel_MouseDoubleClick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwWebArtikel_MouseDoubleClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As MouseEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwWebArtikel_MouseDoubleClick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel_MouseHover"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwWebArtikel_MouseHoverTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwWebArtikel_MouseHover(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub lvwWebArtikel_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.lvwWebArtikel_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "MagentoKategorieIDZuweisenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub MagentoKategorieIDZuweisenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.MagentoKategorieIDZuweisenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "MagentoKategorieIDZuweisenToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub MagentoKategorieIDZuweisenToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.MagentoKategorieIDZuweisenToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "Mailversand_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub Mailversand_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.Mailversand_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "menue_kunden_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub menue_kunden_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.menue_kunden_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "MenüÜbersetzungToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub MenüÜbersetzungToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.MenüÜbersetzungToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "NeuerArtikelToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub NeuerArtikelToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.NeuerArtikelToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "NewsletterAnabmeldenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub NewsletterAnabmeldenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.NewsletterAnabmeldenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "NewsletterDeaktivierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub NewsletterDeaktivierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.NewsletterDeaktivierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ÖffnenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ÖffnenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ÖffnenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optCMSToogleArtikel_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optCMSToogleArtikel_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optCMSToogleArtikel_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optCMSToogleBoth_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optCMSToogleBoth_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optCMSToogleBoth_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optCMSToogleKategorie_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optCMSToogleKategorie_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optCMSToogleKategorie_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "OptInvoiceDate_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub OptInvoiceDate_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.OptInvoiceDate_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "OptLastInvoice_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub OptLastInvoice_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.OptLastInvoice_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optMeistegebote_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optMeistegebote_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optMeistegebote_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optMeisteStaedte_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optMeisteStaedte_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optMeisteStaedte_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "OptRange_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub OptRange_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.OptRange_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optStatHerkunftsland_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optStatHerkunftsland_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optStatHerkunftsland_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optTeuersterArtikel_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optTeuersterArtikel_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optTeuersterArtikel_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "optTopKundenListe_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub optTopKundenListe_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.optTopKundenListe_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "OutlookSyncToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub OutlookSyncToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.OutlookSyncToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "parameter_laden"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub parameter_ladenTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
    target.parameter_laden
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "PaypalBerechnenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub PaypalBerechnenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.PaypalBerechnenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "PaypalBerechnungToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub PaypalBerechnungToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.PaypalBerechnungToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "PersonensucheToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub PersonensucheToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.PersonensucheToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "PersonensucheToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub PersonensucheToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.PersonensucheToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "pgrMailstatusGesammt_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub pgrMailstatusGesammt_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.pgrMailstatusGesammt_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "RadioButton1_CheckedChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub RadioButton1_CheckedChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.RadioButton1_CheckedChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "RadioButton1_CheckedChanged_1"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub RadioButton1_CheckedChanged_1Test()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.RadioButton1_CheckedChanged_1(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ReceiveHotKey"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ReceiveHotKeyTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim HotKeyID As String = String.Empty ' TODO: Passenden Wert initialisieren
    target.ReceiveHotKey(HotKeyID)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "RefreshKategorielisteToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub RefreshKategorielisteToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.RefreshKategorielisteToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "setAddToInfoBar"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setAddToInfoBarTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim strDaten As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim bClean As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setAddToInfoBar(strDaten, bClean)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setAktionButton"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setAktionButtonTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
    target.setAktionButton
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "setBewertungForm"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setBewertungFormTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
    target.setBewertungForm
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "setChangeArtikelDatenbank_view"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setChangeArtikelDatenbank_viewTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setChangeArtikelDatenbank_view
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setCockpit_EnableDisable"
'''</summary>
<TestMethod()>  _
Public Sub setCockpit_EnableDisableTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim bModus As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setCockpit_EnableDisable(bModus)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setColorToTxt"
'''</summary>
<TestMethod()>  _
Public Sub setColorToTxtTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim txt As TextBox = Nothing ' TODO: Passenden Wert initialisieren
Dim txtExpected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
Dim strStatus As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setColorToTxt(txt, strStatus)
    Assert.AreEqual(txtExpected, txt)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setDBSync"
'''</summary>
<TestMethod()>  _
Public Sub setDBSyncTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setDBSync
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setDeletePictures"
'''</summary>
<TestMethod()>  _
Public Sub setDeletePicturesTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim strBild As String = String.Empty ' TODO: Passenden Wert initialisieren
Dim bMessage As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setDeletePictures(strBild, bMessage)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setEBayGalerieData"
'''</summary>
<TestMethod()>  _
Public Sub setEBayGalerieDataTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim bGeboteOnly As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setEBayGalerieData(bGeboteOnly)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "seteBayHistory"
'''</summary>
<TestMethod()>  _
Public Sub seteBayHistoryTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.seteBayHistory
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SetGroups"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SetGroupsTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim column As Integer = 0 ' TODO: Passenden Wert initialisieren
    target.SetGroups(lvw, column)
    Assert.AreEqual(lvwExpected, lvw)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "setLookForm"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setLookFormTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim bModus As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setLookForm(lvw, bModus)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setLVW_Colum_ReOrder"
'''</summary>
<TestMethod()>  _
Public Sub setLVW_Colum_ReOrderTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setLVW_Colum_ReOrder(lvw)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setLVW_select_all"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setLVW_select_allTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim lvwData As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwDataExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setLVW_select_all(lvwData)
    Assert.AreEqual(lvwDataExpected, lvwData)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setLVW_select_vorward"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setLVW_select_vorwardTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim lvwData As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwDataExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setLVW_select_vorward(lvwData)
    Assert.AreEqual(lvwDataExpected, lvwData)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setLVWGroups"
'''</summary>
<TestMethod()>  _
Public Sub setLVWGroupsTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim iColum As Byte = 0 ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setLVWGroups(lvw, iColum)
    Assert.AreEqual(lvwExpected, lvw)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setLVWResizeModus"
'''</summary>
<TestMethod()>  _
Public Sub setLVWResizeModusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim mModus As frmAuktionmanagement.setResizeModus = New frmAuktionmanagement.setResizeModus ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setLVWResizeModus(lvw, mModus)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setOpenHoechstbieter"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setOpenHoechstbieterTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
    target.setOpenHoechstbieter
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "setPage"
'''</summary>
<TestMethod()>  _
Public Sub setPageTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim modus As frmAuktionmanagement.eBlatt = New frmAuktionmanagement.eBlatt ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setPage(modus)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setPlattforms2Combo"
'''</summary>
<TestMethod()>  _
Public Sub setPlattforms2ComboTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim cmb As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
Dim cmbExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setPlattforms2Combo(cmb)
    Assert.AreEqual(cmbExpected, cmb)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setRefreshMenueList"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setRefreshMenueListTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
    target.setRefreshMenueList
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "setSelectedToMark"
'''</summary>
<TestMethod()>  _
Public Sub setSelectedToMarkTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvwData As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim lvwDataExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim mBestellStatus As clsDatenbank.yabe_bestellstatus = New clsDatenbank.yabe_bestellstatus ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setSelectedToMark(lvwData, mBestellStatus)
    Assert.AreEqual(lvwDataExpected, lvwData)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setSendMail"
'''</summary>
<TestMethod()>  _
Public Sub setSendMailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim bPreview As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setSendMail(bPreview)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setShopDeleteItem"
'''</summary>
<TestMethod()>  _
Public Sub setShopDeleteItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setShopDeleteItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setShopLVW_refresh"
'''</summary>
<TestMethod()>  _
Public Sub setShopLVW_refreshTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setShopLVW_refresh
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setSort"
'''</summary>
<TestMethod()>  _
Public Sub setSortTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim listview1 As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim listview1Expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim e As ColumnClickEventArgs = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setSort(listview1, e)
    Assert.AreEqual(listview1Expected, listview1)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setSortModus"
'''</summary>
<TestMethod()>  _
Public Sub setSortModusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setSortModus(e, lvw)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setStartNewsletter"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setStartNewsletterTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setStartNewsletter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setStatusMessage"
'''</summary>
<TestMethod()>  _
Public Sub setStatusMessageTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
Dim bPart As Boolean = false ' TODO: Passenden Wert initialisieren
Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
    Dim actual As String
    actual = target.setStatusMessage(lvw, bPart)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setTabIndex"
'''</summary>
<TestMethod()>  _
Public Sub setTabIndexTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim index As Integer = 0 ' TODO: Passenden Wert initialisieren
Dim expected As Boolean = false ' TODO: Passenden Wert initialisieren
    Dim actual As Boolean
    actual = target.setTabIndex(index)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "setVirutalMode"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub setVirutalModeTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
    target.setVirutalMode
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "SNYCEBayAPIDataToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SNYCEBayAPIDataToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.SNYCEBayAPIDataToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "SpracheZurücksetzenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SpracheZurücksetzenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.SpracheZurücksetzenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "StorniertToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub StorniertToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.StorniertToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "SucheArtikelToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SucheArtikelToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.SucheArtikelToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "SucheBestellungenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SucheBestellungenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.SucheBestellungenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "SucheKundenbestellungenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SucheKundenbestellungenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.SucheKundenbestellungenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "SucheKundeToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SucheKundeToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.SucheKundeToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "SYNCCockpitBestellungenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub SYNCCockpitBestellungenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.SYNCCockpitBestellungenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tab_verwaltung_DrawItem"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tab_verwaltung_DrawItemTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DrawItemEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tab_verwaltung_DrawItem(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tabMenue_DrawItem"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tabMenue_DrawItemTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DrawItemEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tabMenue_DrawItem(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tabMenue_SelectedIndexChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tabMenue_SelectedIndexChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tabMenue_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tabPaypal_DrawItem"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tabPaypal_DrawItemTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DrawItemEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tabPaypal_DrawItem(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tabStatistics_DrawItem"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tabStatistics_DrawItemTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DrawItemEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tabStatistics_DrawItem(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tbMeineBay_DrawItem"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tbMeineBay_DrawItemTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As DrawItemEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tbMeineBay_DrawItem(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "TelefonnummernSucheToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub TelefonnummernSucheToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.TelefonnummernSucheToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "TelefonummernSucheToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub TelefonummernSucheToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.TelefonummernSucheToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tmrEbayTime_Tick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tmrEbayTime_TickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tmrEbayTime_Tick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tmrEbayZeitWarten_Tick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tmrEbayZeitWarten_TickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tmrEbayZeitWarten_Tick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tmrEMailWaitTime_Tick"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tmrEMailWaitTime_TickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tmrEMailWaitTime_Tick(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolBilderprüfenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolBilderprüfenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolBilderprüfenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem11_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem11_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem11_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem12_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem12_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem12_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem15_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem15_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem15_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem16_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem16_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem16_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem2_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem2_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem2_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem3_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem3_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem3_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem5_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem5_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem5_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem6_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem6_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem6_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem7_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem7_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem7_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem8_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem8_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem8_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem9_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripMenuItem9_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripMenuItem9_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripTextBox1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripTextBox1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripTextBox1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ToolStripTextBox1_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ToolStripTextBox1_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ToolStripTextBox1_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "tsmeBayLive_Detailansicht_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub tsmeBayLive_Detailansicht_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.tsmeBayLive_Detailansicht_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtGetSellerListSeiteVon_Leave"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtGetSellerListSeiteVon_LeaveTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtGetSellerListSeiteVon_Leave(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtGetSellerListSeiteVon_TextChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtGetSellerListSeiteVon_TextChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtGetSellerListSeiteVon_TextChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtSuchen_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtSuchen_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtSuchen_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtSuchen_GotFocus"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtSuchen_GotFocusTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtSuchen_GotFocus(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtSuchen_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtSuchen_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtSuchen_KeyDown(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtSuchen_LostFocus"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtSuchen_LostFocusTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtSuchen_LostFocus(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtSuchen_TextChanged"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtSuchen_TextChangedTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtSuchen_TextChanged(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtSumme_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtSumme_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim eventSender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim eventArgs As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtSumme_KeyDown(eventSender, eventArgs)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "txtVersand_KeyDown"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub txtVersand_KeyDownTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim eventSender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim eventArgs As KeyEventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.txtVersand_KeyDown(eventSender, eventArgs)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ÜberarbeitenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ÜberarbeitenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ÜberarbeitenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "UmbennenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub UmbennenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.UmbennenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "VersandkostenberechnungToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub VersandkostenberechnungToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.VersandkostenberechnungToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "VerschicktToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub VerschicktToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.VerschicktToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "VersendetEinstellenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub VersendetEinstellenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.VersendetEinstellenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "VorschauAnzeigenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub VorschauAnzeigenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.VorschauAnzeigenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "WebDelcampeAnsichtToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub WebDelcampeAnsichtToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.WebDelcampeAnsichtToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "WebEBayBildAnsehenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub WebEBayBildAnsehenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.WebEBayBildAnsehenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "WebinterfaceToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub WebinterfaceToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.WebinterfaceToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "WebSucheBeiGoogleToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub WebSucheBeiGoogleToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.WebSucheBeiGoogleToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEAnsichtAktuallisierenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEAnsichtAktuallisierenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEAnsichtAktuallisierenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEArtikelansichtToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEArtikelansichtToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEArtikelansichtToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEArtikelübernahmeToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEArtikelübernahmeToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEArtikelübernahmeToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEBestellverlaufProKundenToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEBestellverlaufProKundenToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEBestellverlaufProKundenToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEImportVonArtikelnToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEImportVonArtikelnToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEImportVonArtikelnToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEImportVonArtikelnToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEImportVonArtikelnToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEImportVonArtikelnToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEKundenverlaufToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEKundenverlaufToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEKundenverlaufToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABERechnungsdruckToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABERechnungsdruckToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABERechnungsdruckToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "YABEWebtranslatorToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub YABEWebtranslatorToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.YABEWebtranslatorToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ZuordnungArtikelKundeToolStripMenuItem_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ZuordnungArtikelKundeToolStripMenuItem_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ZuordnungArtikelKundeToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "ZuordnungArtikelKundeToolStripMenuItem1_Click"
'''</summary>
<TestMethod(),  _
 DeploymentItem("YabE.exe")>  _
Public Sub ZuordnungArtikelKundeToolStripMenuItem1_ClickTest()
Dim target As frmAuktionmanagement_Accessor = New frmAuktionmanagement_Accessor ' TODO: Passenden Wert initialisieren
Dim sender As Object = Nothing ' TODO: Passenden Wert initialisieren
Dim e As EventArgs = Nothing ' TODO: Passenden Wert initialisieren
    target.ZuordnungArtikelKundeToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("Eine Methode, die keinen Wert zurückgibt, kann nicht überprüft werden.")
End Sub

'''<summary>
'''Ein Test für "AktuallisierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AktuallisierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AktuallisierenToolStripMenuItem = expected
    actual = target.AktuallisierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AktuellToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AktuellToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AktuellToolStripMenuItem = expected
    actual = target.AktuellToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AlleMarkierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AlleMarkierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AlleMarkierenToolStripMenuItem = expected
    actual = target.AlleMarkierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AlsBewertetSetzenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AlsBewertetSetzenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AlsBewertetSetzenToolStripMenuItem = expected
    actual = target.AlsBewertetSetzenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ÄndernToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ÄndernToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ÄndernToolStripMenuItem = expected
    actual = target.ÄndernToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AnsichtAktuallisierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AnsichtAktuallisierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AnsichtAktuallisierenToolStripMenuItem = expected
    actual = target.AnsichtAktuallisierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AnsichtAktuallisierenToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub AnsichtAktuallisierenToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AnsichtAktuallisierenToolStripMenuItem1 = expected
    actual = target.AnsichtAktuallisierenToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AnsichtAktuallisierenToolStripMenuItem2"
'''</summary>
<TestMethod()>  _
Public Sub AnsichtAktuallisierenToolStripMenuItem2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AnsichtAktuallisierenToolStripMenuItem2 = expected
    actual = target.AnsichtAktuallisierenToolStripMenuItem2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Anzahl"
'''</summary>
<TestMethod()>  _
Public Sub AnzahlTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.Anzahl = expected
    actual = target.Anzahl
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ArchivAktuallisierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ArchivAktuallisierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ArchivAktuallisierenToolStripMenuItem = expected
    actual = target.ArchivAktuallisierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ArtikelAlleImportiertenLöschenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ArtikelAlleImportiertenLöschenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ArtikelAlleImportiertenLöschenToolStripMenuItem = expected
    actual = target.ArtikelAlleImportiertenLöschenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ArtikelBeendenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ArtikelBeendenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ArtikelBeendenToolStripMenuItem = expected
    actual = target.ArtikelBeendenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ArtikelKomplettLöschenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ArtikelKomplettLöschenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ArtikelKomplettLöschenToolStripMenuItem = expected
    actual = target.ArtikelKomplettLöschenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ArtikelLöschenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ArtikelLöschenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ArtikelLöschenToolStripMenuItem = expected
    actual = target.ArtikelLöschenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ArtikelLöschenToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub ArtikelLöschenToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ArtikelLöschenToolStripMenuItem1 = expected
    actual = target.ArtikelLöschenToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ArtikelSuchenUndErsetzenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ArtikelSuchenUndErsetzenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ArtikelSuchenUndErsetzenToolStripMenuItem = expected
    actual = target.ArtikelSuchenUndErsetzenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AussortiertToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AussortiertToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AussortiertToolStripMenuItem = expected
    actual = target.AussortiertToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AutobewertungToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AutobewertungToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AutobewertungToolStripMenuItem = expected
    actual = target.AutobewertungToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "AutomatischSpracheÄndernToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub AutomatischSpracheÄndernToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.AutomatischSpracheÄndernToolStripMenuItem = expected
    actual = target.AutomatischSpracheÄndernToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ballonITips"
'''</summary>
<TestMethod()>  _
Public Sub ballonITipsTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolTip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolTip
    target.ballonITips = expected
    actual = target.ballonITips
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Beschreibung"
'''</summary>
<TestMethod()>  _
Public Sub BeschreibungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.Beschreibung = expected
    actual = target.Beschreibung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BestelltToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BestelltToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BestelltToolStripMenuItem = expected
    actual = target.BestelltToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BestellübersichtToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BestellübersichtToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BestellübersichtToolStripMenuItem = expected
    actual = target.BestellübersichtToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BestellübersichtToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub BestellübersichtToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BestellübersichtToolStripMenuItem1 = expected
    actual = target.BestellübersichtToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BestellübersichtToolStripMenuItem2"
'''</summary>
<TestMethod()>  _
Public Sub BestellübersichtToolStripMenuItem2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BestellübersichtToolStripMenuItem2 = expected
    actual = target.BestellübersichtToolStripMenuItem2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "bestellung_artikel"
'''</summary>
<TestMethod()>  _
Public Sub bestellung_artikelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.bestellung_artikel = expected
    actual = target.bestellung_artikel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "bestellung_bezahlmethode"
'''</summary>
<TestMethod()>  _
Public Sub bestellung_bezahlmethodeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.bestellung_bezahlmethode = expected
    actual = target.bestellung_bezahlmethode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "bestellungen_endsumme"
'''</summary>
<TestMethod()>  _
Public Sub bestellungen_endsummeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.bestellungen_endsumme = expected
    actual = target.bestellungen_endsumme
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "bestellungen_id"
'''</summary>
<TestMethod()>  _
Public Sub bestellungen_idTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.bestellungen_id = expected
    actual = target.bestellungen_id
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "bestellungen_name"
'''</summary>
<TestMethod()>  _
Public Sub bestellungen_nameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.bestellungen_name = expected
    actual = target.bestellungen_name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "bestellungen_woher"
'''</summary>
<TestMethod()>  _
Public Sub bestellungen_woherTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.bestellungen_woher = expected
    actual = target.bestellungen_woher
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "bestellungen_zeitpunkt"
'''</summary>
<TestMethod()>  _
Public Sub bestellungen_zeitpunktTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.bestellungen_zeitpunkt = expected
    actual = target.bestellungen_zeitpunkt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BestellungsstatusToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BestellungsstatusToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub BewertetToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BewertetToolStripMenuItem = expected
    actual = target.BewertetToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BewertungsprofilinternToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BewertungsprofilinternToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BewertungsprofilinternToolStripMenuItem = expected
    actual = target.BewertungsprofilinternToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BewertungsprofilÖffnenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BewertungsprofilÖffnenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BewertungsprofilÖffnenToolStripMenuItem = expected
    actual = target.BewertungsprofilÖffnenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BezahltToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BezahltToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BezahltToolStripMenuItem = expected
    actual = target.BezahltToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BietverlaufToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BietverlaufToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BietverlaufToolStripMenuItem = expected
    actual = target.BietverlaufToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BietverlaufToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub BietverlaufToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BietverlaufToolStripMenuItem1 = expected
    actual = target.BietverlaufToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Bild"
'''</summary>
<TestMethod()>  _
Public Sub BildTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.Bild = expected
    actual = target.Bild
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BildLöschenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub BildLöschenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.BildLöschenToolStripMenuItem = expected
    actual = target.BildLöschenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnAbbrechen"
'''</summary>
<TestMethod()>  _
Public Sub btnAbbrechenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub btnAbschickenNewsletterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnAbschickenNewsletter = expected
    actual = target.btnAbschickenNewsletter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnAdressLabels"
'''</summary>
<TestMethod()>  _
Public Sub btnAdressLabelsTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnAdressLabels = expected
    actual = target.btnAdressLabels
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnAuktionEinlesen"
'''</summary>
<TestMethod()>  _
Public Sub btnAuktionEinlesenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnAuktionEinlesen = expected
    actual = target.btnAuktionEinlesen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnCheckPictures"
'''</summary>
<TestMethod()>  _
Public Sub btnCheckPicturesTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnCheckPictures = expected
    actual = target.btnCheckPictures
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btneBayLiveRefresh"
'''</summary>
<TestMethod()>  _
Public Sub btneBayLiveRefreshTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btneBayLiveRefresh = expected
    actual = target.btneBayLiveRefresh
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnEdit"
'''</summary>
<TestMethod()>  _
Public Sub btnEditTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnEdit = expected
    actual = target.btnEdit
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnEinlesen"
'''</summary>
<TestMethod()>  _
Public Sub btnEinlesenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnEinlesen = expected
    actual = target.btnEinlesen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BtnGetAccount"
'''</summary>
<TestMethod()>  _
Public Sub BtnGetAccountTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.BtnGetAccount = expected
    actual = target.BtnGetAccount
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnGetCMSBestellungen"
'''</summary>
<TestMethod()>  _
Public Sub btnGetCMSBestellungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnGetCMSBestellungen = expected
    actual = target.btnGetCMSBestellungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "BtnGetMemberMessages"
'''</summary>
<TestMethod()>  _
Public Sub BtnGetMemberMessagesTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.BtnGetMemberMessages = expected
    actual = target.BtnGetMemberMessages
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnKundenHolen"
'''</summary>
<TestMethod()>  _
Public Sub btnKundenHolenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnKundenHolen = expected
    actual = target.btnKundenHolen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnLiveStopp"
'''</summary>
<TestMethod()>  _
Public Sub btnLiveStoppTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnLiveStopp = expected
    actual = target.btnLiveStopp
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnMailVersandStart"
'''</summary>
<TestMethod()>  _
Public Sub btnMailVersandStartTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnMailVersandStart = expected
    actual = target.btnMailVersandStart
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnMeineBayÖffnen"
'''</summary>
<TestMethod()>  _
Public Sub btnMeineBayÖffnenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnMeineBayÖffnen = expected
    actual = target.btnMeineBayÖffnen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnNewsletterCRC"
'''</summary>
<TestMethod()>  _
Public Sub btnNewsletterCRCTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnNewsletterCRC = expected
    actual = target.btnNewsletterCRC
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnNewsletterReset"
'''</summary>
<TestMethod()>  _
Public Sub btnNewsletterResetTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnNewsletterReset = expected
    actual = target.btnNewsletterReset
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnPaypal_abrufen"
'''</summary>
<TestMethod()>  _
Public Sub btnPaypal_abrufenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnPaypal_abrufen = expected
    actual = target.btnPaypal_abrufen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnPrüfeWebArtikel"
'''</summary>
<TestMethod()>  _
Public Sub btnPrüfeWebArtikelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnPrüfeWebArtikel = expected
    actual = target.btnPrüfeWebArtikel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnRefresh"
'''</summary>
<TestMethod()>  _
Public Sub btnRefreshTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnRefresh = expected
    actual = target.btnRefresh
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnRefreshBewertungen"
'''</summary>
<TestMethod()>  _
Public Sub btnRefreshBewertungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnRefreshBewertungen = expected
    actual = target.btnRefreshBewertungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnSendEMail"
'''</summary>
<TestMethod()>  _
Public Sub btnSendEMailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnSendEMail = expected
    actual = target.btnSendEMail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnSuchen"
'''</summary>
<TestMethod()>  _
Public Sub btnSuchenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnSuchen = expected
    actual = target.btnSuchen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnTools_eBayGalerie"
'''</summary>
<TestMethod()>  _
Public Sub btnTools_eBayGalerieTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnTools_eBayGalerie = expected
    actual = target.btnTools_eBayGalerie
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnVerlaufStatus"
'''</summary>
<TestMethod()>  _
Public Sub btnVerlaufStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnVerlaufStatus = expected
    actual = target.btnVerlaufStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnVor"
'''</summary>
<TestMethod()>  _
Public Sub btnVorTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnVor = expected
    actual = target.btnVor
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "btnZurück"
'''</summary>
<TestMethod()>  _
Public Sub btnZurückTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.btnZurück = expected
    actual = target.btnZurück
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "CboStatus"
'''</summary>
<TestMethod()>  _
Public Sub CboStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.CboStatus = expected
    actual = target.CboStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "CboType"
'''</summary>
<TestMethod()>  _
Public Sub CboTypeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.CboType = expected
    actual = target.CboType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkArtikeldatenbank_edit"
'''</summary>
<TestMethod()>  _
Public Sub chkArtikeldatenbank_editTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkArtikeldatenbank_edit = expected
    actual = target.chkArtikeldatenbank_edit
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkAutomatischerModus"
'''</summary>
<TestMethod()>  _
Public Sub chkAutomatischerModusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkAutomatischerModus = expected
    actual = target.chkAutomatischerModus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Alle"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungen_AlleTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBestellungen_Alle = expected
    actual = target.chkBestellungen_Alle
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_bezahlt"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungen_bezahltTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBestellungen_bezahlt = expected
    actual = target.chkBestellungen_bezahlt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_KeineBewertung"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungen_KeineBewertungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBestellungen_KeineBewertung = expected
    actual = target.chkBestellungen_KeineBewertung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Komplett"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungen_KomplettTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBestellungen_Komplett = expected
    actual = target.chkBestellungen_Komplett
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Storniert"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungen_StorniertTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBestellungen_Storniert = expected
    actual = target.chkBestellungen_Storniert
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_verkauft"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungen_verkauftTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBestellungen_verkauft = expected
    actual = target.chkBestellungen_verkauft
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungen_Versand"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungen_VersandTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBestellungen_Versand = expected
    actual = target.chkBestellungen_Versand
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBestellungenVerkauft"
'''</summary>
<TestMethod()>  _
Public Sub chkBestellungenVerkauftTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkBestellungenVerkauft = expected
    actual = target.chkBestellungenVerkauft
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBewertung_janein"
'''</summary>
<TestMethod()>  _
Public Sub chkBewertung_janeinTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkBewertung_janein = expected
    actual = target.chkBewertung_janein
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBewertungZeitfilter"
'''</summary>
<TestMethod()>  _
Public Sub chkBewertungZeitfilterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkBewertungZeitfilter = expected
    actual = target.chkBewertungZeitfilter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkBuyItNow"
'''</summary>
<TestMethod()>  _
Public Sub chkBuyItNowTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkBuyItNow = expected
    actual = target.chkBuyItNow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkDebug_email"
'''</summary>
<TestMethod()>  _
Public Sub chkDebug_emailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkDebug_email = expected
    actual = target.chkDebug_email
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkeBayEnde"
'''</summary>
<TestMethod()>  _
Public Sub chkeBayEndeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkeBayEnde = expected
    actual = target.chkeBayEnde
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkEndTime"
'''</summary>
<TestMethod()>  _
Public Sub chkEndTimeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkEndTime = expected
    actual = target.chkEndTime
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkGebote"
'''</summary>
<TestMethod()>  _
Public Sub chkGeboteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkGebote = expected
    actual = target.chkGebote
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkGeboteOhne"
'''</summary>
<TestMethod()>  _
Public Sub chkGeboteOhneTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkGeboteOhne = expected
    actual = target.chkGeboteOhne
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkHistoryZeitfilter"
'''</summary>
<TestMethod()>  _
Public Sub chkHistoryZeitfilterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkHistoryZeitfilter = expected
    actual = target.chkHistoryZeitfilter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkKundenFullReport"
'''</summary>
<TestMethod()>  _
Public Sub chkKundenFullReportTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkKundenFullReport = expected
    actual = target.chkKundenFullReport
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkKundenHeute"
'''</summary>
<TestMethod()>  _
Public Sub chkKundenHeuteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkKundenHeute = expected
    actual = target.chkKundenHeute
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkKundenZeitfilter"
'''</summary>
<TestMethod()>  _
Public Sub chkKundenZeitfilterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkKundenZeitfilter = expected
    actual = target.chkKundenZeitfilter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkLiveAlle"
'''</summary>
<TestMethod()>  _
Public Sub chkLiveAlleTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.chkLiveAlle = expected
    actual = target.chkLiveAlle
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkLiveZeitfilter"
'''</summary>
<TestMethod()>  _
Public Sub chkLiveZeitfilterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkLiveZeitfilter = expected
    actual = target.chkLiveZeitfilter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkNewsletter_testmodus"
'''</summary>
<TestMethod()>  _
Public Sub chkNewsletter_testmodusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkNewsletter_testmodus = expected
    actual = target.chkNewsletter_testmodus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkNewsletterAlle"
'''</summary>
<TestMethod()>  _
Public Sub chkNewsletterAlleTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkNewsletterAlle = expected
    actual = target.chkNewsletterAlle
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkNewsletterIsWebuser"
'''</summary>
<TestMethod()>  _
Public Sub chkNewsletterIsWebuserTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkNewsletterIsWebuser = expected
    actual = target.chkNewsletterIsWebuser
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkNurKlickt"
'''</summary>
<TestMethod()>  _
Public Sub chkNurKlicktTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkNurKlickt = expected
    actual = target.chkNurKlickt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkShopUpdateItemCount"
'''</summary>
<TestMethod()>  _
Public Sub chkShopUpdateItemCountTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkShopUpdateItemCount = expected
    actual = target.chkShopUpdateItemCount
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkStartupRückbewertung"
'''</summary>
<TestMethod()>  _
Public Sub chkStartupRückbewertungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkStartupRückbewertung = expected
    actual = target.chkStartupRückbewertung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "chkVerschickt"
'''</summary>
<TestMethod()>  _
Public Sub chkVerschicktTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As CheckBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As CheckBox
    target.chkVerschickt = expected
    actual = target.chkVerschickt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmBalance"
'''</summary>
<TestMethod()>  _
Public Sub ClmBalanceTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmBalance = expected
    actual = target.ClmBalance
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmBeschreibung"
'''</summary>
<TestMethod()>  _
Public Sub clmBeschreibungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmBeschreibung = expected
    actual = target.clmBeschreibung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmBody"
'''</summary>
<TestMethod()>  _
Public Sub ClmBodyTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmBody = expected
    actual = target.ClmBody
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmComment"
'''</summary>
<TestMethod()>  _
Public Sub ClmCommentTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmComment = expected
    actual = target.ClmComment
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmDate"
'''</summary>
<TestMethod()>  _
Public Sub ClmDateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmDate = expected
    actual = target.ClmDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmEmail"
'''</summary>
<TestMethod()>  _
Public Sub clmEmailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmEmail = expected
    actual = target.clmEmail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmHitcounter"
'''</summary>
<TestMethod()>  _
Public Sub clmHitcounterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmHitcounter = expected
    actual = target.clmHitcounter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmItemId"
'''</summary>
<TestMethod()>  _
Public Sub ClmItemIdTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmItemId = expected
    actual = target.ClmItemId
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmMessageId"
'''</summary>
<TestMethod()>  _
Public Sub ClmMessageIdTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmMessageId = expected
    actual = target.ClmMessageId
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmOrderStatus"
'''</summary>
<TestMethod()>  _
Public Sub clmOrderStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmOrderStatus = expected
    actual = target.clmOrderStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmPreis"
'''</summary>
<TestMethod()>  _
Public Sub clmPreisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmPreis = expected
    actual = target.clmPreis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmRef"
'''</summary>
<TestMethod()>  _
Public Sub ClmRefTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmRef = expected
    actual = target.ClmRef
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmRole"
'''</summary>
<TestMethod()>  _
Public Sub ClmRoleTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmRole = expected
    actual = target.ClmRole
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmScore"
'''</summary>
<TestMethod()>  _
Public Sub ClmScoreTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmScore = expected
    actual = target.ClmScore
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmSender"
'''</summary>
<TestMethod()>  _
Public Sub ClmSenderTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmSender = expected
    actual = target.ClmSender
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmStatus"
'''</summary>
<TestMethod()>  _
Public Sub ClmStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmStatus = expected
    actual = target.ClmStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmTime"
'''</summary>
<TestMethod()>  _
Public Sub ClmTimeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmTime = expected
    actual = target.ClmTime
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmTitel"
'''</summary>
<TestMethod()>  _
Public Sub clmTitelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmTitel = expected
    actual = target.clmTitel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmTransaktionID"
'''</summary>
<TestMethod()>  _
Public Sub clmTransaktionIDTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmTransaktionID = expected
    actual = target.clmTransaktionID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmType"
'''</summary>
<TestMethod()>  _
Public Sub ClmTypeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmType = expected
    actual = target.ClmType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ClmUser"
'''</summary>
<TestMethod()>  _
Public Sub ClmUserTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ClmUser = expected
    actual = target.ClmUser
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "clmWatchcount"
'''</summary>
<TestMethod()>  _
Public Sub clmWatchcountTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.clmWatchcount = expected
    actual = target.clmWatchcount
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmbArtikelStatus"
'''</summary>
<TestMethod()>  _
Public Sub cmbArtikelStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.cmbArtikelStatus = expected
    actual = target.cmbArtikelStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmbPlattform_bestellungen"
'''</summary>
<TestMethod()>  _
Public Sub cmbPlattform_bestellungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.cmbPlattform_bestellungen = expected
    actual = target.cmbPlattform_bestellungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmbPlattform_kunden"
'''</summary>
<TestMethod()>  _
Public Sub cmbPlattform_kundenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.cmbPlattform_kunden = expected
    actual = target.cmbPlattform_kunden
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmbPlattform_Live"
'''</summary>
<TestMethod()>  _
Public Sub cmbPlattform_LiveTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.cmbPlattform_Live = expected
    actual = target.cmbPlattform_Live
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmbSprache_Artikeldatenbank"
'''</summary>
<TestMethod()>  _
Public Sub cmbSprache_ArtikeldatenbankTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.cmbSprache_Artikeldatenbank = expected
    actual = target.cmbSprache_Artikeldatenbank
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmbStatPlattform"
'''</summary>
<TestMethod()>  _
Public Sub cmbStatPlattformTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.cmbStatPlattform = expected
    actual = target.cmbStatPlattform
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmbTranslationBereichAuswählen"
'''</summary>
<TestMethod()>  _
Public Sub cmbTranslationBereichAuswählenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ComboBox
    target.cmbTranslationBereichAuswählen = expected
    actual = target.cmbTranslationBereichAuswählen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmdRechnen"
'''</summary>
<TestMethod()>  _
Public Sub cmdRechnenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Button = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Button
    target.cmdRechnen = expected
    actual = target.cmdRechnen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_artikel"
'''</summary>
<TestMethod()>  _
Public Sub cms_artikelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_artikel = expected
    actual = target.cms_artikel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_ArtikelVerwaltung"
'''</summary>
<TestMethod()>  _
Public Sub cms_ArtikelVerwaltungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cms_ArtikelVerwaltung = expected
    actual = target.cms_ArtikelVerwaltung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_clickcount"
'''</summary>
<TestMethod()>  _
Public Sub cms_clickcountTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_clickcount = expected
    actual = target.cms_clickcount
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_datum"
'''</summary>
<TestMethod()>  _
Public Sub cms_datumTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_datum = expected
    actual = target.cms_datum
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_hauptkategorie"
'''</summary>
<TestMethod()>  _
Public Sub cms_hauptkategorieTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_hauptkategorie = expected
    actual = target.cms_hauptkategorie
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_kategorie_delcampe"
'''</summary>
<TestMethod()>  _
Public Sub cms_kategorie_delcampeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_kategorie_delcampe = expected
    actual = target.cms_kategorie_delcampe
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_kategorie_magento"
'''</summary>
<TestMethod()>  _
Public Sub cms_kategorie_magentoTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_kategorie_magento = expected
    actual = target.cms_kategorie_magento
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_kategorieID"
'''</summary>
<TestMethod()>  _
Public Sub cms_kategorieIDTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_kategorieID = expected
    actual = target.cms_kategorieID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_KategorieListe"
'''</summary>
<TestMethod()>  _
Public Sub cms_KategorieListeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cms_KategorieListe = expected
    actual = target.cms_KategorieListe
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_menueName"
'''</summary>
<TestMethod()>  _
Public Sub cms_menueNameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cms_menueName = expected
    actual = target.cms_menueName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cms_splitcontainer"
'''</summary>
<TestMethod()>  _
Public Sub cms_splitcontainerTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As SplitContainer = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As SplitContainer
    target.cms_splitcontainer = expected
    actual = target.cms_splitcontainer
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "CMSAnsichtToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub CMSAnsichtToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.CMSAnsichtToolStripMenuItem = expected
    actual = target.CMSAnsichtToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsBlidCounter"
'''</summary>
<TestMethod()>  _
Public Sub cmsBlidCounterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cmsBlidCounter = expected
    actual = target.cmsBlidCounter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmseBayBewertung"
'''</summary>
<TestMethod()>  _
Public Sub cmseBayBewertungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmseBayBewertung = expected
    actual = target.cmseBayBewertung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmseBayGalerie_neu"
'''</summary>
<TestMethod()>  _
Public Sub cmseBayGalerie_neuTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmseBayGalerie_neu = expected
    actual = target.cmseBayGalerie_neu
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmseBayNachrichten"
'''</summary>
<TestMethod()>  _
Public Sub cmseBayNachrichtenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmseBayNachrichten = expected
    actual = target.cmseBayNachrichten
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsHomepageGalerie"
'''</summary>
<TestMethod()>  _
Public Sub cmsHomepageGalerieTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmsHomepageGalerie = expected
    actual = target.cmsHomepageGalerie
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsKundenListview"
'''</summary>
<TestMethod()>  _
Public Sub cmsKundenListviewTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmsKundenListview = expected
    actual = target.cmsKundenListview
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsNewsletter"
'''</summary>
<TestMethod()>  _
Public Sub cmsNewsletterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmsNewsletter = expected
    actual = target.cmsNewsletter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsRechnungen"
'''</summary>
<TestMethod()>  _
Public Sub cmsRechnungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmsRechnungen = expected
    actual = target.cmsRechnungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsStatistik_text"
'''</summary>
<TestMethod()>  _
Public Sub cmsStatistik_textTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmsStatistik_text = expected
    actual = target.cmsStatistik_text
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsStatus"
'''</summary>
<TestMethod()>  _
Public Sub cmsStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.cmsStatus = expected
    actual = target.cmsStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "cmsYABEBestellungen"
'''</summary>
<TestMethod()>  _
Public Sub cmsYABEBestellungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.cmsYABEBestellungen = expected
    actual = target.cmsYABEBestellungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "colPaypalFee"
'''</summary>
<TestMethod()>  _
Public Sub colPaypalFeeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.colPaypalFee = expected
    actual = target.colPaypalFee
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "colPaypalGesamt"
'''</summary>
<TestMethod()>  _
Public Sub colPaypalGesamtTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.colPaypalGesamt = expected
    actual = target.colPaypalGesamt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "colPaypalName"
'''</summary>
<TestMethod()>  _
Public Sub colPaypalNameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.colPaypalName = expected
    actual = target.colPaypalName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "colPaypalStatus"
'''</summary>
<TestMethod()>  _
Public Sub colPaypalStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.colPaypalStatus = expected
    actual = target.colPaypalStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "colPaypalSumme"
'''</summary>
<TestMethod()>  _
Public Sub colPaypalSummeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.colPaypalSumme = expected
    actual = target.colPaypalSumme
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "colPaypalTimestamp"
'''</summary>
<TestMethod()>  _
Public Sub colPaypalTimestampTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.colPaypalTimestamp = expected
    actual = target.colPaypalTimestamp
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "colPaypalType"
'''</summary>
<TestMethod()>  _
Public Sub colPaypalTypeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.colPaypalType = expected
    actual = target.colPaypalType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader11"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader11Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader11 = expected
    actual = target.ColumnHeader11
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader12"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader12Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader12 = expected
    actual = target.ColumnHeader12
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader13"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader13Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader13 = expected
    actual = target.ColumnHeader13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader14"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader14Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader14 = expected
    actual = target.ColumnHeader14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader15"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader15Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader15 = expected
    actual = target.ColumnHeader15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader16"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader16Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader16 = expected
    actual = target.ColumnHeader16
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader17"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader17Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader17 = expected
    actual = target.ColumnHeader17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ColumnHeader18"
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader18Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ColumnHeader18 = expected
    actual = target.ColumnHeader18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "CompleteToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub CompleteToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.CompleteToolStripMenuItem = expected
    actual = target.CompleteToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Copy_Beschreibung"
'''</summary>
<TestMethod()>  _
Public Sub Copy_BeschreibungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.Copy_Beschreibung = expected
    actual = target.Copy_Beschreibung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "CopyEBayIDToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub CopyEBayIDToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.CopyEBayIDToolStripMenuItem = expected
    actual = target.CopyEBayIDToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "CopyEBayIDToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub CopyEBayIDToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.CopyEBayIDToolStripMenuItem1 = expected
    actual = target.CopyEBayIDToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "CopyEBayMitgliedsnameToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub CopyEBayMitgliedsnameToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.CopyEBayMitgliedsnameToolStripMenuItem = expected
    actual = target.CopyEBayMitgliedsnameToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DatePickerBis"
'''</summary>
<TestMethod()>  _
Public Sub DatePickerBisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.DatePickerBis = expected
    actual = target.DatePickerBis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DatePickFrom"
'''</summary>
<TestMethod()>  _
Public Sub DatePickFromTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.DatePickFrom = expected
    actual = target.DatePickFrom
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DatePickInvoice"
'''</summary>
<TestMethod()>  _
Public Sub DatePickInvoiceTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.DatePickInvoice = expected
    actual = target.DatePickInvoice
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DatePickStartFrom"
'''</summary>
<TestMethod()>  _
Public Sub DatePickStartFromTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.DatePickStartFrom = expected
    actual = target.DatePickStartFrom
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DatePickStartTo"
'''</summary>
<TestMethod()>  _
Public Sub DatePickStartToTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.DatePickStartTo = expected
    actual = target.DatePickStartTo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DatePickTo"
'''</summary>
<TestMethod()>  _
Public Sub DatePickToTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.DatePickTo = expected
    actual = target.DatePickTo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DateTimePickerVon"
'''</summary>
<TestMethod()>  _
Public Sub DateTimePickerVonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.DateTimePickerVon = expected
    actual = target.DateTimePickerVon
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "delcampe_id"
'''</summary>
<TestMethod()>  _
Public Sub delcampe_idTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.delcampe_id = expected
    actual = target.delcampe_id
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DelcampeArtikelansichtToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub DelcampeArtikelansichtToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.DelcampeArtikelansichtToolStripMenuItem = expected
    actual = target.DelcampeArtikelansichtToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DelcampeBestellsStatusAktuallisierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub DelcampeBestellsStatusAktuallisierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.DelcampeBestellsStatusAktuallisierenToolStripMenuItem = expected
    actual = target.DelcampeBestellsStatusAktuallisierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DelcampeBewertungenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub DelcampeBewertungenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.DelcampeBewertungenToolStripMenuItem = expected
    actual = target.DelcampeBewertungenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DelcampeKategorieIDZuweisenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub DelcampeKategorieIDZuweisenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.DelcampeKategorieIDZuweisenToolStripMenuItem = expected
    actual = target.DelcampeKategorieIDZuweisenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DelcampeKategorieIDZuweisenToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub DelcampeKategorieIDZuweisenToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.DelcampeKategorieIDZuweisenToolStripMenuItem1 = expected
    actual = target.DelcampeKategorieIDZuweisenToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DelcampeVersandkostenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub DelcampeVersandkostenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.DelcampeVersandkostenToolStripMenuItem = expected
    actual = target.DelcampeVersandkostenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "DeutschToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub DeutschToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.DeutschToolStripMenuItem = expected
    actual = target.DeutschToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "dtp_BewertungBis"
'''</summary>
<TestMethod()>  _
Public Sub dtp_BewertungBisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.dtp_BewertungBis = expected
    actual = target.dtp_BewertungBis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "dtp_BewertungVon"
'''</summary>
<TestMethod()>  _
Public Sub dtp_BewertungVonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.dtp_BewertungVon = expected
    actual = target.dtp_BewertungVon
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "dtPaypal"
'''</summary>
<TestMethod()>  _
Public Sub dtPaypalTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.dtPaypal = expected
    actual = target.dtPaypal
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayAnsichtToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayAnsichtToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayAnsichtToolStripMenuItem = expected
    actual = target.EBayAnsichtToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayArtikelansichtToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayArtikelansichtToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayArtikelansichtToolStripMenuItem = expected
    actual = target.EBayArtikelansichtToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayArtikelÖffnenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayArtikelÖffnenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayArtikelÖffnenToolStripMenuItem = expected
    actual = target.EBayArtikelÖffnenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayAuktionArtikeldetialsToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayAuktionArtikeldetialsToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayAuktionArtikeldetialsToolStripMenuItem = expected
    actual = target.EBayAuktionArtikeldetialsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayBeschreibungErweiternToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayBeschreibungErweiternToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayBeschreibungErweiternToolStripMenuItem = expected
    actual = target.EBayBeschreibungErweiternToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayBewertungenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayBewertungenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayBewertungenToolStripMenuItem = expected
    actual = target.EBayBewertungenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayCrossPromotionToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayCrossPromotionToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayCrossPromotionToolStripMenuItem = expected
    actual = target.EBayCrossPromotionToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_Account"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_AccountTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_Account = expected
    actual = target.eBayHistory_Account
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_bewertet"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_bewertetTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_bewertet = expected
    actual = target.eBayHistory_bewertet
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_bild"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_bildTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_bild = expected
    actual = target.eBayHistory_bild
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_eMail"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_eMailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_eMail = expected
    actual = target.eBayHistory_eMail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistory_Gebühr"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistory_GebührTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistory_Gebühr = expected
    actual = target.ebayHistory_Gebühr
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_live"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_liveTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_live = expected
    actual = target.eBayHistory_live
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistory_muttersprache"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistory_mutterspracheTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistory_muttersprache = expected
    actual = target.ebayHistory_muttersprache
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_name"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_nameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_name = expected
    actual = target.eBayHistory_name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_ort"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_ortTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_ort = expected
    actual = target.eBayHistory_ort
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistory_Paypal"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistory_PaypalTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistory_Paypal = expected
    actual = target.ebayHistory_Paypal
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_plattform"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_plattformTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_plattform = expected
    actual = target.eBayHistory_plattform
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_preis"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_preisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_preis = expected
    actual = target.eBayHistory_preis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistory_sprachliste"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistory_sprachlisteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistory_sprachliste = expected
    actual = target.ebayHistory_sprachliste
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_status"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_statusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_status = expected
    actual = target.eBayHistory_status
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistory_straße"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistory_straßeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistory_straße = expected
    actual = target.ebayHistory_straße
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_title"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_titleTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_title = expected
    actual = target.eBayHistory_title
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistory_verkaufsende"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistory_verkaufsendeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistory_verkaufsende = expected
    actual = target.ebayHistory_verkaufsende
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistory_versandkosten"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistory_versandkostenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistory_versandkosten = expected
    actual = target.eBayHistory_versandkosten
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistory_YABEID"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistory_YABEIDTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistory_YABEID = expected
    actual = target.ebayHistory_YABEID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistoryBis"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistoryBisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.eBayHistoryBis = expected
    actual = target.eBayHistoryBis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistoryDelcampeID"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistoryDelcampeIDTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistoryDelcampeID = expected
    actual = target.ebayHistoryDelcampeID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistoryGebote"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistoryGeboteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.eBayHistoryGebote = expected
    actual = target.eBayHistoryGebote
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ebayHistoryLand"
'''</summary>
<TestMethod()>  _
Public Sub ebayHistoryLandTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ebayHistoryLand = expected
    actual = target.ebayHistoryLand
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eBayHistoryVon"
'''</summary>
<TestMethod()>  _
Public Sub eBayHistoryVonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.eBayHistoryVon = expected
    actual = target.eBayHistoryVon
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayKundenInformationenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayKundenInformationenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayKundenInformationenToolStripMenuItem = expected
    actual = target.EBayKundenInformationenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayÖffnenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayÖffnenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayÖffnenToolStripMenuItem = expected
    actual = target.EBayÖffnenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayÖffnenToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub EBayÖffnenToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayÖffnenToolStripMenuItem1 = expected
    actual = target.EBayÖffnenToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayÖffnenToolStripMenuItem2"
'''</summary>
<TestMethod()>  _
Public Sub EBayÖffnenToolStripMenuItem2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayÖffnenToolStripMenuItem2 = expected
    actual = target.EBayÖffnenToolStripMenuItem2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayVerkaufseventsToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayVerkaufseventsToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayVerkaufseventsToolStripMenuItem = expected
    actual = target.EBayVerkaufseventsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EBayVersandkostenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EBayVersandkostenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EBayVersandkostenToolStripMenuItem = expected
    actual = target.EBayVersandkostenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EMailExternesProgrammToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EMailExternesProgrammToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EMailExternesProgrammToolStripMenuItem = expected
    actual = target.EMailExternesProgrammToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EmailExternesProgrammToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub EmailExternesProgrammToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EmailExternesProgrammToolStripMenuItem1 = expected
    actual = target.EmailExternesProgrammToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EMailVorschauAnzeigenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EMailVorschauAnzeigenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EMailVorschauAnzeigenToolStripMenuItem = expected
    actual = target.EMailVorschauAnzeigenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EnglischToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EnglischToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EnglischToolStripMenuItem = expected
    actual = target.EnglischToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "EntfernenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub EntfernenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.EntfernenToolStripMenuItem = expected
    actual = target.EntfernenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ErinnerungSendenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ErinnerungSendenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ErinnerungSendenToolStripMenuItem = expected
    actual = target.ErinnerungSendenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eshop_bestellungen"
'''</summary>
<TestMethod()>  _
Public Sub eshop_bestellungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.eshop_bestellungen = expected
    actual = target.eshop_bestellungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eshop_bilderprüfung"
'''</summary>
<TestMethod()>  _
Public Sub eshop_bilderprüfungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.eshop_bilderprüfung = expected
    actual = target.eshop_bilderprüfung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "eshop_daten"
'''</summary>
<TestMethod()>  _
Public Sub eshop_datenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.eshop_daten = expected
    actual = target.eshop_daten
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportDelcampeToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ExportDelcampeToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportDelcampeToolStripMenuItem = expected
    actual = target.ExportDelcampeToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportDelcampeToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub ExportDelcampeToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportDelcampeToolStripMenuItem1 = expected
    actual = target.ExportDelcampeToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ExportierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportierenToolStripMenuItem = expected
    actual = target.ExportierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub ExportierenToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportierenToolStripMenuItem1 = expected
    actual = target.ExportierenToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem2"
'''</summary>
<TestMethod()>  _
Public Sub ExportierenToolStripMenuItem2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportierenToolStripMenuItem2 = expected
    actual = target.ExportierenToolStripMenuItem2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem3"
'''</summary>
<TestMethod()>  _
Public Sub ExportierenToolStripMenuItem3Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportierenToolStripMenuItem3 = expected
    actual = target.ExportierenToolStripMenuItem3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem4"
'''</summary>
<TestMethod()>  _
Public Sub ExportierenToolStripMenuItem4Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportierenToolStripMenuItem4 = expected
    actual = target.ExportierenToolStripMenuItem4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportierenToolStripMenuItem5"
'''</summary>
<TestMethod()>  _
Public Sub ExportierenToolStripMenuItem5Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportierenToolStripMenuItem5 = expected
    actual = target.ExportierenToolStripMenuItem5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportMagentoToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ExportMagentoToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportMagentoToolStripMenuItem = expected
    actual = target.ExportMagentoToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportStandardToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ExportStandardToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportStandardToolStripMenuItem = expected
    actual = target.ExportStandardToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportStandardToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub ExportStandardToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportStandardToolStripMenuItem1 = expected
    actual = target.ExportStandardToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ExportToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ExportToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ExportToolStripMenuItem = expected
    actual = target.ExportToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "FehlendeÜbersetzungenHolenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub FehlendeÜbersetzungenHolenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.FehlendeÜbersetzungenHolenToolStripMenuItem = expected
    actual = target.FehlendeÜbersetzungenHolenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "FranzösichToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub FranzösichToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.FranzösichToolStripMenuItem = expected
    actual = target.FranzösichToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "getThreadSearch"
'''</summary>
<TestMethod()>  _
Public Sub getThreadSearchTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As BackgroundWorker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As BackgroundWorker
    target.getThreadSearch = expected
    actual = target.getThreadSearch
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GoogleMapsToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub GoogleMapsToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GoogleMapsToolStripMenuItem = expected
    actual = target.GoogleMapsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GoogleMapsToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub GoogleMapsToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GoogleMapsToolStripMenuItem1 = expected
    actual = target.GoogleMapsToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GroupiertVerkaufsendeToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub GroupiertVerkaufsendeToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GroupiertVerkaufsendeToolStripMenuItem = expected
    actual = target.GroupiertVerkaufsendeToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GruppiertBestellstatusToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub GruppiertBestellstatusToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GruppiertBestellstatusToolStripMenuItem = expected
    actual = target.GruppiertBestellstatusToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GruppiertKeineToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub GruppiertKeineToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GruppiertKeineToolStripMenuItem = expected
    actual = target.GruppiertKeineToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GruppiertLandToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub GruppiertLandToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GruppiertLandToolStripMenuItem = expected
    actual = target.GruppiertLandToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GruppiertMutterspracheToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub GruppiertMutterspracheToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GruppiertMutterspracheToolStripMenuItem = expected
    actual = target.GruppiertMutterspracheToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "GruppiertNameToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub GruppiertNameToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.GruppiertNameToolStripMenuItem = expected
    actual = target.GruppiertNameToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "HöchstbietenderBewertungsprofilToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub HöchstbietenderBewertungsprofilToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.HöchstbietenderBewertungsprofilToolStripMenuItem = expected
    actual = target.HöchstbietenderBewertungsprofilToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "HöchstbietenderBewertungsprofilToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub HöchstbietenderBewertungsprofilToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.HöchstbietenderBewertungsprofilToolStripMenuItem1 = expected
    actual = target.HöchstbietenderBewertungsprofilToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "HöchstbietenderToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub HöchstbietenderToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.HöchstbietenderToolStripMenuItem = expected
    actual = target.HöchstbietenderToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "HotKey"
'''</summary>
<TestMethod()>  _
Public Sub HotKeyTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As clsHotKey = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As clsHotKey
    target.HotKey = expected
    actual = target.HotKey
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ID"
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.ID = expected
    actual = target.ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "imgAuktionsmanagement"
'''</summary>
<TestMethod()>  _
Public Sub imgAuktionsmanagementTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ImageList = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ImageList
    target.imgAuktionsmanagement = expected
    actual = target.imgAuktionsmanagement
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "IsSendToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub IsSendToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.IsSendToolStripMenuItem = expected
    actual = target.IsSendToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KategorieHauptkategorieToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KategorieHauptkategorieToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KategorieHauptkategorieToolStripMenuItem = expected
    actual = target.KategorieHauptkategorieToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KategorieLöschenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KategorieLöschenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KategorieLöschenToolStripMenuItem = expected
    actual = target.KategorieLöschenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KategorieNeueSubkategorieToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KategorieNeueSubkategorieToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KategorieNeueSubkategorieToolStripMenuItem = expected
    actual = target.KategorieNeueSubkategorieToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_Artikel"
'''</summary>
<TestMethod()>  _
Public Sub kd_ArtikelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_Artikel = expected
    actual = target.kd_Artikel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_eBayName"
'''</summary>
<TestMethod()>  _
Public Sub kd_eBayNameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_eBayName = expected
    actual = target.kd_eBayName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_eMail"
'''</summary>
<TestMethod()>  _
Public Sub kd_eMailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_eMail = expected
    actual = target.kd_eMail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_käufe"
'''</summary>
<TestMethod()>  _
Public Sub kd_käufeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_käufe = expected
    actual = target.kd_käufe
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_Land"
'''</summary>
<TestMethod()>  _
Public Sub kd_LandTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_Land = expected
    actual = target.kd_Land
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_last"
'''</summary>
<TestMethod()>  _
Public Sub kd_lastTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_last = expected
    actual = target.kd_last
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_muttersprache"
'''</summary>
<TestMethod()>  _
Public Sub kd_mutterspracheTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_muttersprache = expected
    actual = target.kd_muttersprache
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_nachname"
'''</summary>
<TestMethod()>  _
Public Sub kd_nachnameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_nachname = expected
    actual = target.kd_nachname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_newsletter"
'''</summary>
<TestMethod()>  _
Public Sub kd_newsletterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_newsletter = expected
    actual = target.kd_newsletter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_Ort"
'''</summary>
<TestMethod()>  _
Public Sub kd_OrtTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_Ort = expected
    actual = target.kd_Ort
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_plattform"
'''</summary>
<TestMethod()>  _
Public Sub kd_plattformTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_plattform = expected
    actual = target.kd_plattform
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_PLZ"
'''</summary>
<TestMethod()>  _
Public Sub kd_PLZTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_PLZ = expected
    actual = target.kd_PLZ
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_sprachenliste"
'''</summary>
<TestMethod()>  _
Public Sub kd_sprachenlisteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_sprachenliste = expected
    actual = target.kd_sprachenliste
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "kd_strasse"
'''</summary>
<TestMethod()>  _
Public Sub kd_strasseTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.kd_strasse = expected
    actual = target.kd_strasse
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KopierenArtikelIDToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KopierenArtikelIDToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KopierenArtikelIDToolStripMenuItem = expected
    actual = target.KopierenArtikelIDToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KopierenEmailToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KopierenEmailToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KopierenEmailToolStripMenuItem = expected
    actual = target.KopierenEmailToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KopierenEmailToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub KopierenEmailToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KopierenEmailToolStripMenuItem1 = expected
    actual = target.KopierenEmailToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KopierenNameToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KopierenNameToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KopierenNameToolStripMenuItem = expected
    actual = target.KopierenNameToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KopierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KopierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KopierenToolStripMenuItem = expected
    actual = target.KopierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KundeLöschenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KundeLöschenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KundeLöschenToolStripMenuItem = expected
    actual = target.KundeLöschenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KundenBis"
'''</summary>
<TestMethod()>  _
Public Sub KundenBisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.KundenBis = expected
    actual = target.KundenBis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KundenEditierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KundenEditierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KundenEditierenToolStripMenuItem = expected
    actual = target.KundenEditierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KundenNeuToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KundenNeuToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KundenNeuToolStripMenuItem = expected
    actual = target.KundenNeuToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KundenverlaufToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub KundenverlaufToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.KundenverlaufToolStripMenuItem = expected
    actual = target.KundenverlaufToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "KundenVon"
'''</summary>
<TestMethod()>  _
Public Sub KundenVonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As DateTimePicker = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As DateTimePicker
    target.KundenVon = expected
    actual = target.KundenVon
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label1"
'''</summary>
<TestMethod()>  _
Public Sub Label1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label10Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label11Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label12Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label13Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label13 = expected
    actual = target.Label13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label14"
'''</summary>
<TestMethod()>  _
Public Sub Label14Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label14 = expected
    actual = target.Label14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label15"
'''</summary>
<TestMethod()>  _
Public Sub Label15Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label15 = expected
    actual = target.Label15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label16"
'''</summary>
<TestMethod()>  _
Public Sub Label16Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label16 = expected
    actual = target.Label16
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label17"
'''</summary>
<TestMethod()>  _
Public Sub Label17Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label17 = expected
    actual = target.Label17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label18"
'''</summary>
<TestMethod()>  _
Public Sub Label18Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label18 = expected
    actual = target.Label18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label19"
'''</summary>
<TestMethod()>  _
Public Sub Label19Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label19 = expected
    actual = target.Label19
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label2"
'''</summary>
<TestMethod()>  _
Public Sub Label2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label2 = expected
    actual = target.Label2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label20"
'''</summary>
<TestMethod()>  _
Public Sub Label20Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label20 = expected
    actual = target.Label20
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label21"
'''</summary>
<TestMethod()>  _
Public Sub Label21Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label21 = expected
    actual = target.Label21
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label22"
'''</summary>
<TestMethod()>  _
Public Sub Label22Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label22 = expected
    actual = target.Label22
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label23"
'''</summary>
<TestMethod()>  _
Public Sub Label23Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label23 = expected
    actual = target.Label23
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label24"
'''</summary>
<TestMethod()>  _
Public Sub Label24Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label24 = expected
    actual = target.Label24
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label25"
'''</summary>
<TestMethod()>  _
Public Sub Label25Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label25 = expected
    actual = target.Label25
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label26"
'''</summary>
<TestMethod()>  _
Public Sub Label26Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label26 = expected
    actual = target.Label26
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label27"
'''</summary>
<TestMethod()>  _
Public Sub Label27Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label27 = expected
    actual = target.Label27
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label28"
'''</summary>
<TestMethod()>  _
Public Sub Label28Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label28 = expected
    actual = target.Label28
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label29"
'''</summary>
<TestMethod()>  _
Public Sub Label29Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label29 = expected
    actual = target.Label29
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label3"
'''</summary>
<TestMethod()>  _
Public Sub Label3Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label3 = expected
    actual = target.Label3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label30"
'''</summary>
<TestMethod()>  _
Public Sub Label30Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label30 = expected
    actual = target.Label30
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label31"
'''</summary>
<TestMethod()>  _
Public Sub Label31Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label31 = expected
    actual = target.Label31
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Label4"
'''</summary>
<TestMethod()>  _
Public Sub Label4Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label5Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label6Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label7Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label8Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub Label9Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.Label9 = expected
    actual = target.Label9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblAccBalance"
'''</summary>
<TestMethod()>  _
Public Sub LblAccBalanceTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblAccBalance = expected
    actual = target.LblAccBalance
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblAccState"
'''</summary>
<TestMethod()>  _
Public Sub LblAccStateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblAccState = expected
    actual = target.LblAccState
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblBestellungen_main"
'''</summary>
<TestMethod()>  _
Public Sub lblBestellungen_mainTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblBestellungen_main = expected
    actual = target.lblBestellungen_main
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblBewertung_bis"
'''</summary>
<TestMethod()>  _
Public Sub lblBewertung_bisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblBewertung_bis = expected
    actual = target.lblBewertung_bis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblBewertung_von"
'''</summary>
<TestMethod()>  _
Public Sub lblBewertung_vonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblBewertung_von = expected
    actual = target.lblBewertung_von
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblBis"
'''</summary>
<TestMethod()>  _
Public Sub lblBisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblBis = expected
    actual = target.lblBis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblEntries"
'''</summary>
<TestMethod()>  _
Public Sub LblEntriesTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblEntries = expected
    actual = target.LblEntries
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblFilter"
'''</summary>
<TestMethod()>  _
Public Sub lblFilterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblFilter = expected
    actual = target.lblFilter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblKunden_Main_label"
'''</summary>
<TestMethod()>  _
Public Sub lblKunden_Main_labelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblKunden_Main_label = expected
    actual = target.lblKunden_Main_label
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblKundenMessage"
'''</summary>
<TestMethod()>  _
Public Sub lblKundenMessageTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblKundenMessage = expected
    actual = target.lblKundenMessage
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblLive_bis"
'''</summary>
<TestMethod()>  _
Public Sub lblLive_bisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblLive_bis = expected
    actual = target.lblLive_bis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblLive_von"
'''</summary>
<TestMethod()>  _
Public Sub lblLive_vonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblLive_von = expected
    actual = target.lblLive_von
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblLiveMessage"
'''</summary>
<TestMethod()>  _
Public Sub lblLiveMessageTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblLiveMessage = expected
    actual = target.lblLiveMessage
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblPayMethod"
'''</summary>
<TestMethod()>  _
Public Sub LblPayMethodTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblPayMethod = expected
    actual = target.LblPayMethod
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblSeite"
'''</summary>
<TestMethod()>  _
Public Sub lblSeiteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblSeite = expected
    actual = target.lblSeite
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblStartSep"
'''</summary>
<TestMethod()>  _
Public Sub LblStartSepTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblStartSep = expected
    actual = target.LblStartSep
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblStatus"
'''</summary>
<TestMethod()>  _
Public Sub LblStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblStatus = expected
    actual = target.LblStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblTimeRange"
'''</summary>
<TestMethod()>  _
Public Sub LblTimeRangeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblTimeRange = expected
    actual = target.LblTimeRange
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LblType"
'''</summary>
<TestMethod()>  _
Public Sub LblTypeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.LblType = expected
    actual = target.LblType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lblVon"
'''</summary>
<TestMethod()>  _
Public Sub lblVonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.lblVon = expected
    actual = target.lblVon
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ListBox1"
'''</summary>
<TestMethod()>  _
Public Sub ListBox1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListBox
    target.ListBox1 = expected
    actual = target.ListBox1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_auktion_plattform"
'''</summary>
<TestMethod()>  _
Public Sub live_auktion_plattformTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_auktion_plattform = expected
    actual = target.live_auktion_plattform
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_auktionbeginn"
'''</summary>
<TestMethod()>  _
Public Sub live_auktionbeginnTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_auktionbeginn = expected
    actual = target.live_auktionbeginn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_auktionend"
'''</summary>
<TestMethod()>  _
Public Sub live_auktionendTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_auktionend = expected
    actual = target.live_auktionend
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_beschreibung"
'''</summary>
<TestMethod()>  _
Public Sub live_beschreibungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_beschreibung = expected
    actual = target.live_beschreibung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_completed_status"
'''</summary>
<TestMethod()>  _
Public Sub live_completed_statusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_completed_status = expected
    actual = target.live_completed_status
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_ebaybild"
'''</summary>
<TestMethod()>  _
Public Sub live_ebaybildTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_ebaybild = expected
    actual = target.live_ebaybild
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_eBayFragen"
'''</summary>
<TestMethod()>  _
Public Sub live_eBayFragenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_eBayFragen = expected
    actual = target.live_eBayFragen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_ebayID"
'''</summary>
<TestMethod()>  _
Public Sub live_ebayIDTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_ebayID = expected
    actual = target.live_ebayID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_ebaymitglied"
'''</summary>
<TestMethod()>  _
Public Sub live_ebaymitgliedTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_ebaymitglied = expected
    actual = target.live_ebaymitglied
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_email"
'''</summary>
<TestMethod()>  _
Public Sub live_emailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_email = expected
    actual = target.live_email
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_endpreis"
'''</summary>
<TestMethod()>  _
Public Sub live_endpreisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_endpreis = expected
    actual = target.live_endpreis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_gebote"
'''</summary>
<TestMethod()>  _
Public Sub live_geboteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_gebote = expected
    actual = target.live_gebote
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_hitcounter"
'''</summary>
<TestMethod()>  _
Public Sub live_hitcounterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_hitcounter = expected
    actual = target.live_hitcounter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_lastupdate"
'''</summary>
<TestMethod()>  _
Public Sub live_lastupdateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_lastupdate = expected
    actual = target.live_lastupdate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_ListType"
'''</summary>
<TestMethod()>  _
Public Sub live_ListTypeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_ListType = expected
    actual = target.live_ListType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_paypal_endsumme"
'''</summary>
<TestMethod()>  _
Public Sub live_paypal_endsummeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_paypal_endsumme = expected
    actual = target.live_paypal_endsumme
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_person_land"
'''</summary>
<TestMethod()>  _
Public Sub live_person_landTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_person_land = expected
    actual = target.live_person_land
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_person_name"
'''</summary>
<TestMethod()>  _
Public Sub live_person_nameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_person_name = expected
    actual = target.live_person_name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_startpreis"
'''</summary>
<TestMethod()>  _
Public Sub live_startpreisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_startpreis = expected
    actual = target.live_startpreis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_versandkosten"
'''</summary>
<TestMethod()>  _
Public Sub live_versandkostenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_versandkosten = expected
    actual = target.live_versandkosten
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_verschickt"
'''</summary>
<TestMethod()>  _
Public Sub live_verschicktTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_verschickt = expected
    actual = target.live_verschickt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_watchcounter"
'''</summary>
<TestMethod()>  _
Public Sub live_watchcounterTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_watchcounter = expected
    actual = target.live_watchcounter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "live_yabe_id"
'''</summary>
<TestMethod()>  _
Public Sub live_yabe_idTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.live_yabe_id = expected
    actual = target.live_yabe_id
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LiveÖffnenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub LiveÖffnenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.LiveÖffnenToolStripMenuItem = expected
    actual = target.LiveÖffnenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "LöschenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub LöschenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.LöschenToolStripMenuItem = expected
    actual = target.LöschenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvMailStatus"
'''</summary>
<TestMethod()>  _
Public Sub lvMailStatusTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvMailStatus = expected
    actual = target.lvMailStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwBewertungen"
'''</summary>
<TestMethod()>  _
Public Sub lvwBewertungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwBewertungen = expected
    actual = target.lvwBewertungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvweBayGalerie"
'''</summary>
<TestMethod()>  _
Public Sub lvweBayGalerieTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvweBayGalerie = expected
    actual = target.lvweBayGalerie
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvweBayHistory"
'''</summary>
<TestMethod()>  _
Public Sub lvweBayHistoryTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvweBayHistory = expected
    actual = target.lvweBayHistory
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvweBayLiveList"
'''</summary>
<TestMethod()>  _
Public Sub lvweBayLiveListTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvweBayLiveList = expected
    actual = target.lvweBayLiveList
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwEbayNachrichten"
'''</summary>
<TestMethod()>  _
Public Sub lvwEbayNachrichtenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwEbayNachrichten = expected
    actual = target.lvwEbayNachrichten
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwEbayRechnung"
'''</summary>
<TestMethod()>  _
Public Sub lvwEbayRechnungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwEbayRechnung = expected
    actual = target.lvwEbayRechnung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwGetBestellungen"
'''</summary>
<TestMethod()>  _
Public Sub lvwGetBestellungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwGetBestellungen = expected
    actual = target.lvwGetBestellungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwKunden"
'''</summary>
<TestMethod()>  _
Public Sub lvwKundenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwKunden = expected
    actual = target.lvwKunden
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwLiveAnsicht"
'''</summary>
<TestMethod()>  _
Public Sub lvwLiveAnsichtTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ContextMenuStrip = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ContextMenuStrip
    target.lvwLiveAnsicht = expected
    actual = target.lvwLiveAnsicht
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwMenue"
'''</summary>
<TestMethod()>  _
Public Sub lvwMenueTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwMenue = expected
    actual = target.lvwMenue
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwPaypal"
'''</summary>
<TestMethod()>  _
Public Sub lvwPaypalTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwPaypal = expected
    actual = target.lvwPaypal
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwStatisticText"
'''</summary>
<TestMethod()>  _
Public Sub lvwStatisticTextTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwStatisticText = expected
    actual = target.lvwStatisticText
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "lvwWebArtikel"
'''</summary>
<TestMethod()>  _
Public Sub lvwWebArtikelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ListView = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ListView
    target.lvwWebArtikel = expected
    actual = target.lvwWebArtikel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "magento_id"
'''</summary>
<TestMethod()>  _
Public Sub magento_idTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.magento_id = expected
    actual = target.magento_id
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "MagentoKategorieIDZuweisenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub MagentoKategorieIDZuweisenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.MagentoKategorieIDZuweisenToolStripMenuItem = expected
    actual = target.MagentoKategorieIDZuweisenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "MagentoKategorieIDZuweisenToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub MagentoKategorieIDZuweisenToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.MagentoKategorieIDZuweisenToolStripMenuItem1 = expected
    actual = target.MagentoKategorieIDZuweisenToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_anzahl"
'''</summary>
<TestMethod()>  _
Public Sub mail_anzahlTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_anzahl = expected
    actual = target.mail_anzahl
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_benutzername"
'''</summary>
<TestMethod()>  _
Public Sub mail_benutzernameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_benutzername = expected
    actual = target.mail_benutzername
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_clicked"
'''</summary>
<TestMethod()>  _
Public Sub mail_clickedTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_clicked = expected
    actual = target.mail_clicked
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_country"
'''</summary>
<TestMethod()>  _
Public Sub mail_countryTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_country = expected
    actual = target.mail_country
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_crc"
'''</summary>
<TestMethod()>  _
Public Sub mail_crcTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_crc = expected
    actual = target.mail_crc
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_email"
'''</summary>
<TestMethod()>  _
Public Sub mail_emailTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_email = expected
    actual = target.mail_email
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_id"
'''</summary>
<TestMethod()>  _
Public Sub mail_idTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_id = expected
    actual = target.mail_id
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_last_clicked"
'''</summary>
<TestMethod()>  _
Public Sub mail_last_clickedTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_last_clicked = expected
    actual = target.mail_last_clicked
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_name"
'''</summary>
<TestMethod()>  _
Public Sub mail_nameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_name = expected
    actual = target.mail_name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_nr"
'''</summary>
<TestMethod()>  _
Public Sub mail_nrTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_nr = expected
    actual = target.mail_nr
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_Ort"
'''</summary>
<TestMethod()>  _
Public Sub mail_OrtTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_Ort = expected
    actual = target.mail_Ort
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_preis"
'''</summary>
<TestMethod()>  _
Public Sub mail_preisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_preis = expected
    actual = target.mail_preis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_sprache"
'''</summary>
<TestMethod()>  _
Public Sub mail_spracheTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_sprache = expected
    actual = target.mail_sprache
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_user_pwd"
'''</summary>
<TestMethod()>  _
Public Sub mail_user_pwdTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_user_pwd = expected
    actual = target.mail_user_pwd
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_verschickt"
'''</summary>
<TestMethod()>  _
Public Sub mail_verschicktTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_verschickt = expected
    actual = target.mail_verschickt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "mail_webuser"
'''</summary>
<TestMethod()>  _
Public Sub mail_webuserTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.mail_webuser = expected
    actual = target.mail_webuser
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_artikelverwaltung"
'''</summary>
<TestMethod()>  _
Public Sub menue_artikelverwaltungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_artikelverwaltung = expected
    actual = target.menue_artikelverwaltung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_bestellverlauf"
'''</summary>
<TestMethod()>  _
Public Sub menue_bestellverlaufTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_bestellverlauf = expected
    actual = target.menue_bestellverlauf
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_eBay_Live"
'''</summary>
<TestMethod()>  _
Public Sub menue_eBay_LiveTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_eBay_Live = expected
    actual = target.menue_eBay_Live
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_eBayBewertungen"
'''</summary>
<TestMethod()>  _
Public Sub menue_eBayBewertungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_eBayBewertungen = expected
    actual = target.menue_eBayBewertungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_kunden"
'''</summary>
<TestMethod()>  _
Public Sub menue_kundenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_kunden = expected
    actual = target.menue_kunden
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_Mailversand"
'''</summary>
<TestMethod()>  _
Public Sub menue_MailversandTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_Mailversand = expected
    actual = target.menue_Mailversand
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_meineBay"
'''</summary>
<TestMethod()>  _
Public Sub menue_meineBayTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_meineBay = expected
    actual = target.menue_meineBay
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_Statistik"
'''</summary>
<TestMethod()>  _
Public Sub menue_StatistikTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_Statistik = expected
    actual = target.menue_Statistik
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "menue_tbPaypal"
'''</summary>
<TestMethod()>  _
Public Sub menue_tbPaypalTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.menue_tbPaypal = expected
    actual = target.menue_tbPaypal
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "MenüÜbersetzungToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub MenüÜbersetzungToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.MenüÜbersetzungToolStripMenuItem = expected
    actual = target.MenüÜbersetzungToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Name"
'''</summary>
<TestMethod()>  _
Public Sub NameTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.Name = expected
    actual = target.Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "NeuerArtikelToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub NeuerArtikelToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.NeuerArtikelToolStripMenuItem = expected
    actual = target.NeuerArtikelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "NewsletterAnabmeldenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub NewsletterAnabmeldenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.NewsletterAnabmeldenToolStripMenuItem = expected
    actual = target.NewsletterAnabmeldenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "NewsletterDeaktivierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub NewsletterDeaktivierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.NewsletterDeaktivierenToolStripMenuItem = expected
    actual = target.NewsletterDeaktivierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ÖffnenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ÖffnenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ÖffnenToolStripMenuItem = expected
    actual = target.ÖffnenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optCMSToogleArtikel"
'''</summary>
<TestMethod()>  _
Public Sub optCMSToogleArtikelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optCMSToogleArtikel = expected
    actual = target.optCMSToogleArtikel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optCMSToogleBoth"
'''</summary>
<TestMethod()>  _
Public Sub optCMSToogleBothTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optCMSToogleBoth = expected
    actual = target.optCMSToogleBoth
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optCMSToogleKategorie"
'''</summary>
<TestMethod()>  _
Public Sub optCMSToogleKategorieTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optCMSToogleKategorie = expected
    actual = target.optCMSToogleKategorie
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "OptInvoiceDate"
'''</summary>
<TestMethod()>  _
Public Sub OptInvoiceDateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.OptInvoiceDate = expected
    actual = target.OptInvoiceDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "OptLastInvoice"
'''</summary>
<TestMethod()>  _
Public Sub OptLastInvoiceTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.OptLastInvoice = expected
    actual = target.OptLastInvoice
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optMeistegebote"
'''</summary>
<TestMethod()>  _
Public Sub optMeistegeboteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optMeistegebote = expected
    actual = target.optMeistegebote
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optMeisteStaedte"
'''</summary>
<TestMethod()>  _
Public Sub optMeisteStaedteTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optMeisteStaedte = expected
    actual = target.optMeisteStaedte
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "OptRange"
'''</summary>
<TestMethod()>  _
Public Sub OptRangeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.OptRange = expected
    actual = target.OptRange
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optStatHerkunftsland"
'''</summary>
<TestMethod()>  _
Public Sub optStatHerkunftslandTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optStatHerkunftsland = expected
    actual = target.optStatHerkunftsland
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optStatUmsatz"
'''</summary>
<TestMethod()>  _
Public Sub optStatUmsatzTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optStatUmsatz = expected
    actual = target.optStatUmsatz
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optTeuersterArtikel"
'''</summary>
<TestMethod()>  _
Public Sub optTeuersterArtikelTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optTeuersterArtikel = expected
    actual = target.optTeuersterArtikel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "optTopKundenListe"
'''</summary>
<TestMethod()>  _
Public Sub optTopKundenListeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As RadioButton = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As RadioButton
    target.optTopKundenListe = expected
    actual = target.optTopKundenListe
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "OutlookSyncToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub OutlookSyncToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.OutlookSyncToolStripMenuItem = expected
    actual = target.OutlookSyncToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "PersonensucheToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub PersonensucheToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.PersonensucheToolStripMenuItem = expected
    actual = target.PersonensucheToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "PersonensucheToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub PersonensucheToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.PersonensucheToolStripMenuItem1 = expected
    actual = target.PersonensucheToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "pgrBewertungenUpdate"
'''</summary>
<TestMethod()>  _
Public Sub pgrBewertungenUpdateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ProgressBar
    target.pgrBewertungenUpdate = expected
    actual = target.pgrBewertungenUpdate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "pgreBayLiveUpdate"
'''</summary>
<TestMethod()>  _
Public Sub pgreBayLiveUpdateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ProgressBar
    target.pgreBayLiveUpdate = expected
    actual = target.pgreBayLiveUpdate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "pgreBayVerlaufUpdate"
'''</summary>
<TestMethod()>  _
Public Sub pgreBayVerlaufUpdateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ProgressBar
    target.pgreBayVerlaufUpdate = expected
    actual = target.pgreBayVerlaufUpdate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "pgrKundenverlauf"
'''</summary>
<TestMethod()>  _
Public Sub pgrKundenverlaufTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ProgressBar
    target.pgrKundenverlauf = expected
    actual = target.pgrKundenverlauf
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "pgrMailstatusGesammt"
'''</summary>
<TestMethod()>  _
Public Sub pgrMailstatusGesammtTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ProgressBar
    target.pgrMailstatusGesammt = expected
    actual = target.pgrMailstatusGesammt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "Preis"
'''</summary>
<TestMethod()>  _
Public Sub PreisTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ColumnHeader = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ColumnHeader
    target.Preis = expected
    actual = target.Preis
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "progStatistik"
'''</summary>
<TestMethod()>  _
Public Sub progStatistikTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ProgressBar
    target.progStatistik = expected
    actual = target.progStatistik
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "RefreshKategorielisteToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub RefreshKategorielisteToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.RefreshKategorielisteToolStripMenuItem = expected
    actual = target.RefreshKategorielisteToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SNYCEBayAPIDataToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SNYCEBayAPIDataToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SNYCEBayAPIDataToolStripMenuItem = expected
    actual = target.SNYCEBayAPIDataToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SpracheToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SpracheToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SpracheToolStripMenuItem = expected
    actual = target.SpracheToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SpracheZurücksetzenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SpracheZurücksetzenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SpracheZurücksetzenToolStripMenuItem = expected
    actual = target.SpracheZurücksetzenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "StatusToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub StatusToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.StatusToolStripMenuItem = expected
    actual = target.StatusToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "StorniertToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub StorniertToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.StorniertToolStripMenuItem = expected
    actual = target.StorniertToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SucheArtikelToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SucheArtikelToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SucheArtikelToolStripMenuItem = expected
    actual = target.SucheArtikelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SucheBestellungenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SucheBestellungenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SucheBestellungenToolStripMenuItem = expected
    actual = target.SucheBestellungenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SucheKundenbestellungenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SucheKundenbestellungenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SucheKundenbestellungenToolStripMenuItem = expected
    actual = target.SucheKundenbestellungenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SucheKundenBewertungenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SucheKundenBewertungenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SucheKundenBewertungenToolStripMenuItem = expected
    actual = target.SucheKundenBewertungenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SucheKundeToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SucheKundeToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SucheKundeToolStripMenuItem = expected
    actual = target.SucheKundeToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "SYNCCockpitBestellungenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub SYNCCockpitBestellungenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.SYNCCockpitBestellungenToolStripMenuItem = expected
    actual = target.SYNCCockpitBestellungenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tab_paypal_api"
'''</summary>
<TestMethod()>  _
Public Sub tab_paypal_apiTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.tab_paypal_api = expected
    actual = target.tab_paypal_api
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tab_paypal_schnellberechnung"
'''</summary>
<TestMethod()>  _
Public Sub tab_paypal_schnellberechnungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.tab_paypal_schnellberechnung = expected
    actual = target.tab_paypal_schnellberechnung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tab_verwaltung"
'''</summary>
<TestMethod()>  _
Public Sub tab_verwaltungTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabControl
    target.tab_verwaltung = expected
    actual = target.tab_verwaltung
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tabMenue"
'''</summary>
<TestMethod()>  _
Public Sub tabMenueTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabControl
    target.tabMenue = expected
    actual = target.tabMenue
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TabPage1"
'''</summary>
<TestMethod()>  _
Public Sub TabPage1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.TabPage1 = expected
    actual = target.TabPage1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TabPage2"
'''</summary>
<TestMethod()>  _
Public Sub TabPage2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.TabPage2 = expected
    actual = target.TabPage2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TabPage5"
'''</summary>
<TestMethod()>  _
Public Sub TabPage5Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.TabPage5 = expected
    actual = target.TabPage5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TabPage6"
'''</summary>
<TestMethod()>  _
Public Sub TabPage6Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabPage = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabPage
    target.TabPage6 = expected
    actual = target.TabPage6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tabPaypal"
'''</summary>
<TestMethod()>  _
Public Sub tabPaypalTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabControl
    target.tabPaypal = expected
    actual = target.tabPaypal
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tabStatistics"
'''</summary>
<TestMethod()>  _
Public Sub tabStatisticsTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabControl
    target.tabStatistics = expected
    actual = target.tabStatistics
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tbMeineBay"
'''</summary>
<TestMethod()>  _
Public Sub tbMeineBayTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TabControl = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TabControl
    target.tbMeineBay = expected
    actual = target.tbMeineBay
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TelefonnummernSucheToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub TelefonnummernSucheToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.TelefonnummernSucheToolStripMenuItem = expected
    actual = target.TelefonnummernSucheToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TelefonummernSucheToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub TelefonummernSucheToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.TelefonummernSucheToolStripMenuItem = expected
    actual = target.TelefonummernSucheToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tmrEbayTime"
'''</summary>
<TestMethod()>  _
Public Sub tmrEbayTimeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Timer
    target.tmrEbayTime = expected
    actual = target.tmrEbayTime
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tmrEbayZeitWarten"
'''</summary>
<TestMethod()>  _
Public Sub tmrEbayZeitWartenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Timer
    target.tmrEbayZeitWarten = expected
    actual = target.tmrEbayZeitWarten
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tmrEMailWaitTime"
'''</summary>
<TestMethod()>  _
Public Sub tmrEMailWaitTimeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Timer = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Timer
    target.tmrEMailWaitTime = expected
    actual = target.tmrEMailWaitTime
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolBilderprüfenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ToolBilderprüfenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolBilderprüfenToolStripMenuItem = expected
    actual = target.ToolBilderprüfenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem1 = expected
    actual = target.ToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem10"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem10Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem10 = expected
    actual = target.ToolStripMenuItem10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem11"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem11Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem11 = expected
    actual = target.ToolStripMenuItem11
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem12"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem12Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem12 = expected
    actual = target.ToolStripMenuItem12
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem13"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem13Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem13 = expected
    actual = target.ToolStripMenuItem13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem14"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem14Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem14 = expected
    actual = target.ToolStripMenuItem14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem15"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem15Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem15 = expected
    actual = target.ToolStripMenuItem15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem16"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem16Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem16 = expected
    actual = target.ToolStripMenuItem16
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem2"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripMenuItem3Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripMenuItem4Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem4 = expected
    actual = target.ToolStripMenuItem4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem5"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem5Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem5 = expected
    actual = target.ToolStripMenuItem5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem6"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem6Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem6 = expected
    actual = target.ToolStripMenuItem6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem7"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem7Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem7 = expected
    actual = target.ToolStripMenuItem7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem8"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem8Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem8 = expected
    actual = target.ToolStripMenuItem8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripMenuItem9"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem9Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem9 = expected
    actual = target.ToolStripMenuItem9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator1"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator1 = expected
    actual = target.ToolStripSeparator1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator10"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator10Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator11Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator12Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator13Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator14Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator15Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator16Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator17Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator17 = expected
    actual = target.ToolStripSeparator17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator18"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator18Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator18 = expected
    actual = target.ToolStripSeparator18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator19"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator19Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator19 = expected
    actual = target.ToolStripSeparator19
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator2"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator2Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator2 = expected
    actual = target.ToolStripSeparator2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator20"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator20Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator20 = expected
    actual = target.ToolStripSeparator20
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator21"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator21Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator21 = expected
    actual = target.ToolStripSeparator21
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator22"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator22Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator22 = expected
    actual = target.ToolStripSeparator22
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator23"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator23Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator23 = expected
    actual = target.ToolStripSeparator23
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator24"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator24Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator24 = expected
    actual = target.ToolStripSeparator24
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator25"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator25Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator25 = expected
    actual = target.ToolStripSeparator25
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator26"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator26Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator26 = expected
    actual = target.ToolStripSeparator26
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator27"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator27Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator27 = expected
    actual = target.ToolStripSeparator27
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator28"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator28Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator28 = expected
    actual = target.ToolStripSeparator28
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator29"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator29Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator29 = expected
    actual = target.ToolStripSeparator29
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator3"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator3Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator3 = expected
    actual = target.ToolStripSeparator3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator30"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator30Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator30 = expected
    actual = target.ToolStripSeparator30
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator31"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator31Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator31 = expected
    actual = target.ToolStripSeparator31
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator32"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator32Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator32 = expected
    actual = target.ToolStripSeparator32
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator33"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator33Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator33 = expected
    actual = target.ToolStripSeparator33
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator34"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator34Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator34 = expected
    actual = target.ToolStripSeparator34
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator35"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator35Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator35 = expected
    actual = target.ToolStripSeparator35
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator36"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator36Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator36 = expected
    actual = target.ToolStripSeparator36
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator37"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator37Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator37 = expected
    actual = target.ToolStripSeparator37
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator39"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator39Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator39 = expected
    actual = target.ToolStripSeparator39
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator4"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator4Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator4 = expected
    actual = target.ToolStripSeparator4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator40"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator40Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator40 = expected
    actual = target.ToolStripSeparator40
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator41"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator41Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator41 = expected
    actual = target.ToolStripSeparator41
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator42"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator42Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator42 = expected
    actual = target.ToolStripSeparator42
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator43"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator43Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator43 = expected
    actual = target.ToolStripSeparator43
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator44"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator44Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator44 = expected
    actual = target.ToolStripSeparator44
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator45"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator45Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator45 = expected
    actual = target.ToolStripSeparator45
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator46"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator46Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator46 = expected
    actual = target.ToolStripSeparator46
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator47"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator47Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator47 = expected
    actual = target.ToolStripSeparator47
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator48"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator48Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator48 = expected
    actual = target.ToolStripSeparator48
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator49"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator49Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator49 = expected
    actual = target.ToolStripSeparator49
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator5"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator5Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator5 = expected
    actual = target.ToolStripSeparator5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator50"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator50Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator50 = expected
    actual = target.ToolStripSeparator50
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator51"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator51Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator51 = expected
    actual = target.ToolStripSeparator51
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator52"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator52Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator52 = expected
    actual = target.ToolStripSeparator52
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator53"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator53Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator53 = expected
    actual = target.ToolStripSeparator53
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripSeparator6"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator6Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator7Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator8Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
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
<TestMethod()>  _
Public Sub ToolStripSeparator9Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripSeparator = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator9 = expected
    actual = target.ToolStripSeparator9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ToolStripTextBox1"
'''</summary>
<TestMethod()>  _
Public Sub ToolStripTextBox1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripTextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripTextBox
    target.ToolStripTextBox1 = expected
    actual = target.ToolStripTextBox1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "tsmeBayLive_Detailansicht"
'''</summary>
<TestMethod()>  _
Public Sub tsmeBayLive_DetailansichtTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.tsmeBayLive_Detailansicht = expected
    actual = target.tsmeBayLive_Detailansicht
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TxtAccBalance"
'''</summary>
<TestMethod()>  _
Public Sub TxtAccBalanceTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.TxtAccBalance = expected
    actual = target.TxtAccBalance
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TxtAccState"
'''</summary>
<TestMethod()>  _
Public Sub TxtAccStateTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.TxtAccState = expected
    actual = target.TxtAccState
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtBewertungen"
'''</summary>
<TestMethod()>  _
Public Sub txtBewertungenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtBewertungen = expected
    actual = target.txtBewertungen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtBezahltag"
'''</summary>
<TestMethod()>  _
Public Sub txtBezahltagTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtBezahltag = expected
    actual = target.txtBezahltag
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtEndsumme"
'''</summary>
<TestMethod()>  _
Public Sub txtEndsummeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtEndsumme = expected
    actual = target.txtEndsumme
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtGetSellerListSeiteVon"
'''</summary>
<TestMethod()>  _
Public Sub txtGetSellerListSeiteVonTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtGetSellerListSeiteVon = expected
    actual = target.txtGetSellerListSeiteVon
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "TxtPayMethod"
'''</summary>
<TestMethod()>  _
Public Sub TxtPayMethodTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.TxtPayMethod = expected
    actual = target.TxtPayMethod
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtSuchen"
'''</summary>
<TestMethod()>  _
Public Sub txtSuchenTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtSuchen = expected
    actual = target.txtSuchen
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtSumme"
'''</summary>
<TestMethod()>  _
Public Sub txtSummeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtSumme = expected
    actual = target.txtSumme
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtVersand"
'''</summary>
<TestMethod()>  _
Public Sub txtVersandTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtVersand = expected
    actual = target.txtVersand
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "txtZwischensumme"
'''</summary>
<TestMethod()>  _
Public Sub txtZwischensummeTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As TextBox = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As TextBox
    target.txtZwischensumme = expected
    actual = target.txtZwischensumme
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ÜberarbeitenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ÜberarbeitenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ÜberarbeitenToolStripMenuItem = expected
    actual = target.ÜberarbeitenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "UmbennenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub UmbennenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.UmbennenToolStripMenuItem = expected
    actual = target.UmbennenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "VarianteIIIToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub VarianteIIIToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.VarianteIIIToolStripMenuItem = expected
    actual = target.VarianteIIIToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "VarianteIIToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub VarianteIIToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.VarianteIIToolStripMenuItem = expected
    actual = target.VarianteIIToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "VarianteIToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub VarianteIToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.VarianteIToolStripMenuItem = expected
    actual = target.VarianteIToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "VersandkostenberechnungToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub VersandkostenberechnungToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.VersandkostenberechnungToolStripMenuItem = expected
    actual = target.VersandkostenberechnungToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "VerschicktToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub VerschicktToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.VerschicktToolStripMenuItem = expected
    actual = target.VerschicktToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "VersendetEinstellenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub VersendetEinstellenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.VersendetEinstellenToolStripMenuItem = expected
    actual = target.VersendetEinstellenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "VorschauAnzeigenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub VorschauAnzeigenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.VorschauAnzeigenToolStripMenuItem = expected
    actual = target.VorschauAnzeigenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "WebEBayBildAnsehenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub WebEBayBildAnsehenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.WebEBayBildAnsehenToolStripMenuItem = expected
    actual = target.WebEBayBildAnsehenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "WebinterfaceToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub WebinterfaceToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.WebinterfaceToolStripMenuItem = expected
    actual = target.WebinterfaceToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "WebSucheBeiGoogleToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub WebSucheBeiGoogleToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.WebSucheBeiGoogleToolStripMenuItem = expected
    actual = target.WebSucheBeiGoogleToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "yabe_dashboard_header"
'''</summary>
<TestMethod()>  _
Public Sub yabe_dashboard_headerTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As Label = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As Label
    target.yabe_dashboard_header = expected
    actual = target.yabe_dashboard_header
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEAnsichtAktuallisierenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEAnsichtAktuallisierenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEAnsichtAktuallisierenToolStripMenuItem = expected
    actual = target.YABEAnsichtAktuallisierenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEAnsichtToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEAnsichtToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEAnsichtToolStripMenuItem = expected
    actual = target.YABEAnsichtToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEArtikelansichtToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEArtikelansichtToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEArtikelansichtToolStripMenuItem = expected
    actual = target.YABEArtikelansichtToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEArtikelübernahmeToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEArtikelübernahmeToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEArtikelübernahmeToolStripMenuItem = expected
    actual = target.YABEArtikelübernahmeToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEBestellverlaufProKundenToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEBestellverlaufProKundenToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEBestellverlaufProKundenToolStripMenuItem = expected
    actual = target.YABEBestellverlaufProKundenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEImportVonArtikelnToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEImportVonArtikelnToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEImportVonArtikelnToolStripMenuItem = expected
    actual = target.YABEImportVonArtikelnToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEImportVonArtikelnToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub YABEImportVonArtikelnToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEImportVonArtikelnToolStripMenuItem1 = expected
    actual = target.YABEImportVonArtikelnToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEKundenverlaufToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEKundenverlaufToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEKundenverlaufToolStripMenuItem = expected
    actual = target.YABEKundenverlaufToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABERechnungsdruckToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABERechnungsdruckToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABERechnungsdruckToolStripMenuItem = expected
    actual = target.YABERechnungsdruckToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "YABEWebtranslatorToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub YABEWebtranslatorToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.YABEWebtranslatorToolStripMenuItem = expected
    actual = target.YABEWebtranslatorToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ZedGraphControl1"
'''</summary>
<TestMethod()>  _
Public Sub ZedGraphControl1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ZedGraphControl = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ZedGraphControl
    target.ZedGraphControl1 = expected
    actual = target.ZedGraphControl1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ZuordnungArtikelKundeToolStripMenuItem"
'''</summary>
<TestMethod()>  _
Public Sub ZuordnungArtikelKundeToolStripMenuItemTest()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ZuordnungArtikelKundeToolStripMenuItem = expected
    actual = target.ZuordnungArtikelKundeToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub

'''<summary>
'''Ein Test für "ZuordnungArtikelKundeToolStripMenuItem1"
'''</summary>
<TestMethod()>  _
Public Sub ZuordnungArtikelKundeToolStripMenuItem1Test()
Dim target As frmAuktionmanagement = New frmAuktionmanagement ' TODO: Passenden Wert initialisieren
Dim expected As ToolStripMenuItem = Nothing ' TODO: Passenden Wert initialisieren
    Dim actual As ToolStripMenuItem
    target.ZuordnungArtikelKundeToolStripMenuItem1 = expected
    actual = target.ZuordnungArtikelKundeToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
End Sub
End Class
