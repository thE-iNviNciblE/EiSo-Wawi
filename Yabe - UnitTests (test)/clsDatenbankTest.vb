Imports System

Imports MySql.Data.MySqlClient

Imports System.Data

Imports System.Windows.Forms

Imports eBay.Service.Core.Soap

Imports System.Collections

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports YabE



'''<summary>
'''Dies ist eine Testklasse für "clsDatenbankTest" und soll
'''alle clsDatenbankTest Komponententests enthalten.
'''</summary>
<TestClass()> _
Public Class clsDatenbankTest


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
    '''Ein Test für "clsDatenbank-Konstruktor"
    '''</summary>
    <TestMethod()> _
    Public Sub clsDatenbankConstructorTest()
        Dim target As clsDatenbank = New clsDatenbank
        Assert.Inconclusive("TODO: Code zum Überprüfen des Ziels implementieren")
    End Sub

    '''<summary>
    '''Ein Test für "chkCMS_picture_check"
    '''</summary>
    <TestMethod()> _
    Public Sub chkCMS_picture_checkTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lblMessage As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwTarget As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwTargetExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.chkCMS_picture_check(lvw, lblMessage, lvwTarget)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(lvwTargetExpected, lvwTarget)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkeBayID"
    '''</summary>
    <TestMethod()> _
    Public Sub chkeBayIDTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim eBaycatID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.chkeBayID(eBaycatID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkGebote"
    '''</summary>
    <TestMethod()> _
    Public Sub chkGeboteTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBay_ID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.chkGebote(streBay_ID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkLogin"
    '''</summary>
    <TestMethod()> _
    Public Sub chkLoginTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strUsername As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strPWD As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.chkLogin(strUsername, strPWD)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkUpdate_Add"
    '''</summary>
    <TestMethod()> _
    Public Sub chkUpdate_AddTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strValue As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strTable As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim col As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.chkUpdate_Add(strValue, strTable, col)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkYABE_Kunden_isUserStored"
    '''</summary>
    <TestMethod()> _
    Public Sub chkYABE_Kunden_isUserStoredTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strtabelle As clsDatenbank.datentabelle = New clsDatenbank.datentabelle ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.chkYABE_Kunden_isUserStored(strEmail, strtabelle)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "chkYABE_Orders"
    '''</summary>
    <TestMethod()> _
    Public Sub chkYABE_OrdersTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.chkYABE_Orders(strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "CMS2MagentoID"
    '''</summary>
    <TestMethod()> _
    Public Sub CMS2MagentoIDTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strCMSID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.CMS2MagentoID(strCMSID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "DownloadWebpage"
    '''</summary>
    <TestMethod()> _
    Public Sub DownloadWebpageTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim URL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModus As clsDatenbank.chkBilderData = New clsDatenbank.chkBilderData ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.DownloadWebpage(URL, strModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getArtikeldatenbank_Beschreibung_Export"
    '''</summary>
    <TestMethod()> _
    Public Sub getArtikeldatenbank_Beschreibung_ExportTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strSprache As clsDatenbank.email_sprache = New clsDatenbank.email_sprache ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getArtikeldatenbank_Beschreibung_Export(strID, strSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_catCount"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_catCountTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iCat As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strWhere As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getCMS_catCount(iCat, strWhere)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_items"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_itemsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim iDelcampeID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iHauptkategorie As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCMS_items(strQuery, lvw, iDelcampeID, iHauptkategorie)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_items_delete"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_items_deleteTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCMS_items_delete(strQuery)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_Menue"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_MenueTest1()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim cms_menue As TreeView = Nothing ' TODO: Passenden Wert initialisieren
        Dim cms_menueExpected As TreeView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCMS_Menue(cms_menue)
        Assert.AreEqual(cms_menueExpected, cms_menue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_Menue"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_MenueTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getCMS_Menue(strQuery, lvw, strSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_menuItem"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_menuItemTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strZielSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual() As String
        actual = target.getCMS_menuItem(id, strZielSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_Query"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_QueryTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getCMS_Query(strQuery)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMS_ShopItems"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMS_ShopItemsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strField As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strValue As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getCMS_ShopItems(strField, strValue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMSMenue_highestChild"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMSMenue_highestChildTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iParrent As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.getCMSMenue_highestChild(iParrent)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMSMenue_highestParent"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMSMenue_highestParentTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.getCMSMenue_highestParent
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCMSParent"
    '''</summary>
    <TestMethod()> _
    Public Sub getCMSParentTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.getCMSParent(id)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getComboEmailTextBereiche"
    '''</summary>
    <TestMethod()> _
    Public Sub getComboEmailTextBereicheTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim cmb As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim strFunction As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getComboEmailTextBereiche(cmb, strFunction)
        Assert.AreEqual(cmbExpected, cmb)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getComboGroups"
    '''</summary>
    <TestMethod()> _
    Public Sub getComboGroupsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim cmb As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getComboGroups(cmb)
        Assert.AreEqual(cmbExpected, cmb)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getComboMailtextTranslation2ID"
    '''</summary>
    <TestMethod()> _
    Public Sub getComboMailtextTranslation2IDTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strText As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim actual As Integer
        actual = target.getComboMailtextTranslation2ID(strText)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getComboShopGroups"
    '''</summary>
    <TestMethod()> _
    Public Sub getComboShopGroupsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim cmb As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getComboShopGroups(cmb)
        Assert.AreEqual(cmbExpected, cmb)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getComboSprachen"
    '''</summary>
    <TestMethod()> _
    Public Sub getComboSprachenTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim cmb As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim cmbExpected As ComboBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getComboSprachen(cmb)
        Assert.AreEqual(cmbExpected, cmb)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getCustomerLastOrder"
    '''</summary>
    <TestMethod()> _
    Public Sub getCustomerLastOrderTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getCustomerLastOrder(strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getEBayArtikelGalerie"
    '''</summary>
    <TestMethod()> _
    Public Sub getEBayArtikelGalerieTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getEBayArtikelGalerie(lvw)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayLive_email"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayLive_emailTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim eBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.geteBayLive_email(eBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "geteBayUmsatzMonth"
    '''</summary>
    <TestMethod()> _
    Public Sub geteBayUmsatzMonthTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvwData As ListBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwDataExpected As ListBox = Nothing ' TODO: Passenden Wert initialisieren
        Dim plattform As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.geteBayUmsatzMonth(lvwData, plattform)
        Assert.AreEqual(lvwDataExpected, lvwData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getFirstLastItem"
    '''</summary>
    <TestMethod()> _
    Public Sub getFirstLastItemTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim bLast As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getFirstLastItem(bLast)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getFunc_EmailAdress_Translation"
    '''</summary>
    <TestMethod()> _
    Public Sub getFunc_EmailAdress_TranslationTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEMail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getFunc_EmailAdress_Translation(strEMail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getHistory_items"
    '''</summary>
    <TestMethod()> _
    Public Sub getHistory_itemsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getHistory_items(strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getIseBayIDStored"
    '''</summary>
    <TestMethod()> _
    Public Sub getIseBayIDStoredTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim eBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getIseBayIDStored(eBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getKaufAnzahl"
    '''</summary>
    <TestMethod()> _
    Public Sub getKaufAnzahlTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getKaufAnzahl(strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getLanuage2GoogleCode"
    '''</summary>
    <TestMethod()> _
    Public Sub getLanuage2GoogleCodeTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getLanuage2GoogleCode(strSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getLasteBayArtikel"
    '''</summary>
    <TestMethod()> _
    Public Sub getLasteBayArtikelTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEMail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getLasteBayArtikel(strEMail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getListviewData"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getListviewDataTest1()
        Dim target As clsDatenbank_Accessor = New clsDatenbank_Accessor ' TODO: Passenden Wert initialisieren
        Dim lvwdata As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwdataExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim dbReader As MySqlDataReader = Nothing ' TODO: Passenden Wert initialisieren
        Dim nr As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getListviewData(lvwdata, dbReader, nr)
        Assert.AreEqual(lvwdataExpected, lvwdata)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getListviewData"
    '''</summary>
    <TestMethod()> _
    Public Sub getListviewDataTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvwData As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwDataExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getListviewData(lvwData, strQuery)
        Assert.AreEqual(lvwDataExpected, lvwData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getMemberAdress"
    '''</summary>
    <TestMethod()> _
    Public Sub getMemberAdressTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strMembername As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual() As String
        actual = target.getMemberAdress(strMembername)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getMysqlTimestamp"
    '''</summary>
    <TestMethod()> _
    Public Sub getMysqlTimestampTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim datum As DateTime = New DateTime ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getMysqlTimestamp(datum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getNewsletter"
    '''</summary>
    <TestMethod()> _
    Public Sub getNewsletterTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streMail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getNewsletter(streMail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getNewsletter_MD5"
    '''</summary>
    <TestMethod()> _
    Public Sub getNewsletter_MD5Test()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strString As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getNewsletter_MD5(strString)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getNewsletterGalerie"
    '''</summary>
    <TestMethod()> _
    Public Sub getNewsletterGalerieTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getNewsletterGalerie
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getPersonalID"
    '''</summary>
    <TestMethod()> _
    Public Sub getPersonalIDTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streMail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getPersonalID(streMail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getPlattforms"
    '''</summary>
    <TestMethod()> _
    Public Sub getPlattformsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual() As String
        actual = target.getPlattforms
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getQueryCount"
    '''</summary>
    <TestMethod()> _
    Public Sub getQueryCountTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strTable As clsDatenbank.datentabelle = New clsDatenbank.datentabelle ' TODO: Passenden Wert initialisieren
        Dim strWhere As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getQueryCount(strTable, strWhere)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getSimilarItems"
    '''</summary>
    <TestMethod()> _
    Public Sub getSimilarItemsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strData As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected(,) As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual(,) As String
        actual = target.getSimilarItems(strData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getSoldItemsbyEmail"
    '''</summary>
    <TestMethod()> _
    Public Sub getSoldItemsbyEmailTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim eBay_account As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lvwArtikelListe As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwArtikelListeExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim aryListData As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim aryListDataExpected As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim bModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getSoldItemsbyEmail(eBay_account, lvwArtikelListe, aryListData, bModus)
        Assert.AreEqual(lvwArtikelListeExpected, lvwArtikelListe)
        Assert.AreEqual(aryListDataExpected, aryListData)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getSprache_ISO_Ary"
    '''</summary>
    <TestMethod()> _
    Public Sub getSprache_ISO_AryTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected(,) As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual(,) As String
        actual = target.getSprache_ISO_Ary
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getSQLStatement2Countas"
    '''</summary>
    <TestMethod()> _
    Public Sub getSQLStatement2CountasTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strSQL As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getSQLStatement2Countas(strSQL)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getTotalSum"
    '''</summary>
    <TestMethod()> _
    Public Sub getTotalSumTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strMitgliedsname As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strTable As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getTotalSum(strMitgliedsname, strTable)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getTranslate_l18n_mapping"
    '''</summary>
    <TestMethod()> _
    Public Sub getTranslate_l18n_mappingTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim cmbSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getTranslate_l18n_mapping(cmbSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getTranslateSearch_replace"
    '''</summary>
    <TestMethod()> _
    Public Sub getTranslateSearch_replaceTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strText As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getTranslateSearch_replace(strText, strSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getTranslationText"
    '''</summary>
    <TestMethod()> _
    Public Sub getTranslationTextTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strField As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getTranslationText(strName, strField)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getUniqueBuyer_lvw"
    '''</summary>
    <TestMethod()> _
    Public Sub getUniqueBuyer_lvwTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvwKäuferliste As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwKäuferlisteExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim streBayAccount As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bHistory As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getUniqueBuyer_lvw(lvwKäuferliste, streBayAccount, bHistory)
        Assert.AreEqual(lvwKäuferlisteExpected, lvwKäuferliste)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getWebArtikel2GUI"
    '''</summary>
    <TestMethod()> _
    Public Sub getWebArtikel2GUITest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim frm As frmCMS_change_item = Nothing ' TODO: Passenden Wert initialisieren
        Dim frmExpected As frmCMS_change_item = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getWebArtikel2GUI(strQuery, frm)
        Assert.AreEqual(frmExpected, frm)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getWebBestellungen"
    '''</summary>
    <TestMethod()> _
    Public Sub getWebBestellungenTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.getWebBestellungen(strQuery, lvw)
        Assert.AreEqual(lvwExpected, lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getWebBezahlmethode"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getWebBezahlmethodeTest()
        Dim target As clsDatenbank_Accessor = New clsDatenbank_Accessor ' TODO: Passenden Wert initialisieren
        Dim iModus As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getWebBezahlmethode(iModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getWebWoher"
    '''</summary>
    <TestMethod(), _
     DeploymentItem("YabE.exe")> _
    Public Sub getWebWoherTest()
        Dim target As clsDatenbank_Accessor = New clsDatenbank_Accessor ' TODO: Passenden Wert initialisieren
        Dim iModus As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getWebWoher(iModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getYABE_adress_id"
    '''</summary>
    <TestMethod()> _
    Public Sub getYABE_adress_idTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getYABE_adress_id(strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getYABE_profil_id"
    '''</summary>
    <TestMethod()> _
    Public Sub getYABE_profil_idTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.getYABE_profil_id(strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "getYABEUserData"
    '''</summary>
    <TestMethod()> _
    Public Sub getYABEUserDataTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim actual As ArrayList
        actual = target.getYABEUserData(strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "MD5StringHash"
    '''</summary>
    <TestMethod()> _
    Public Sub MD5StringHashTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strString As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.MD5StringHash(strString)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setArtikeldatenbank_Beschreibung_empty"
    '''</summary>
    <TestMethod()> _
    Public Sub setArtikeldatenbank_Beschreibung_emptyTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strSprach As clsDatenbank.email_sprache = New clsDatenbank.email_sprache ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setArtikeldatenbank_Beschreibung_empty(strID, strSprach)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setChangeDB"
    '''</summary>
    <TestMethod()> _
    Public Sub setChangeDBTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strDB As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModus As clsDatenbank.datenbankzugriff = New clsDatenbank.datenbankzugriff ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setChangeDB(strDB, strModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_history_orders"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_history_ordersTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setCMS_history_orders
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_import_delete"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_import_deleteTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMS_import_delete
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_item_delcampe"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_item_delcampeTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iItemID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iDelcampeID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMS_item_delcampe(iItemID, iDelcampeID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_item_magento"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_item_magentoTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strMagento As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMS_item_magento(iID, strMagento)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_menue_delcampe"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_menue_delcampeTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iMenueId As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iDelcampeNeu As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMS_menue_delcampe(iMenueId, iDelcampeNeu)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_menue_magento"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_menue_magentoTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iMenueId As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strMagento As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMS_menue_magento(iMenueId, strMagento)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_menueItem_save"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_menueItem_saveTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strZielsprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strChange As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMS_menueItem_save(id, strZielsprache, strChange)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMS_NewMenue"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMS_NewMenueTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iParent As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iChild As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iChild2 As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iChild3 As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMS_NewMenue(strName, iParent, iChild, iChild2, iChild3)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMSItem_count"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMSItem_countTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iCat As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iCount As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMSItem_count(iCat, iCount)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMSMenue_delete"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMSMenue_deleteTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMSMenue_delete(id)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setCMSMenueName"
    '''</summary>
    <TestMethod()> _
    Public Sub setCMSMenueNameTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iIndex As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setCMSMenueName(strName, iIndex, strSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDataGrid"
    '''</summary>
    <TestMethod()> _
    Public Sub setDataGridTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim datagrid As DataGridView = Nothing ' TODO: Passenden Wert initialisieren
        Dim datagridExpected As DataGridView = Nothing ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim tblMisc As DataSet = Nothing ' TODO: Passenden Wert initialisieren
        Dim tblMiscExpected As DataSet = Nothing ' TODO: Passenden Wert initialisieren
        Dim da As MySqlDataAdapter = Nothing ' TODO: Passenden Wert initialisieren
        Dim daExpected As MySqlDataAdapter = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setDataGrid(datagrid, strQuery, tblMisc, da)
        Assert.AreEqual(datagridExpected, datagrid)
        Assert.AreEqual(tblMiscExpected, tblMisc)
        Assert.AreEqual(daExpected, da)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDeleted"
    '''</summary>
    <TestMethod()> _
    Public Sub setDeletedTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strTable As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setDeleted(streBayID, strTable)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDeleteOrder"
    '''</summary>
    <TestMethod()> _
    Public Sub setDeleteOrderTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim Id As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim email As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setDeleteOrder(Id, email)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDeleteReal"
    '''</summary>
    <TestMethod()> _
    Public Sub setDeleteRealTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strTable As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setDeleteReal(streBayID, strTable)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setDropLivelist"
    '''</summary>
    <TestMethod()> _
    Public Sub setDropLivelistTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setDropLivelist
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "seteBayFeedBack2Article"
    '''</summary>
    <TestMethod()> _
    Public Sub seteBayFeedBack2ArticleTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim eBay_ID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.seteBayFeedBack2Article(eBay_ID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "seteBayID2Menue"
    '''</summary>
    <TestMethod()> _
    Public Sub seteBayID2MenueTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim eBaycatID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim menueId As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim streBayName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.seteBayID2Menue(eBaycatID, menueId, streBayName)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "seteBayStats"
    '''</summary>
    <TestMethod()> _
    Public Sub seteBayStatsTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iPositive As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iNeutral As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iNegative As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim eBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.seteBayStats(iPositive, iNeutral, iNegative, eBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "seteBayTransaktionData"
    '''</summary>
    <TestMethod()> _
    Public Sub seteBayTransaktionDataTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim oTransaktions As TransactionType = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.seteBayTransaktionData(oTransaktions)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "seteMail_send"
    '''</summary>
    <TestMethod()> _
    Public Sub seteMail_sendTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.seteMail_send(streBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "seteMailDb"
    '''</summary>
    <TestMethod()> _
    Public Sub seteMailDbTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvw As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.seteMailDb(lvw)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setFeedbackBewerted"
    '''</summary>
    <TestMethod()> _
    Public Sub setFeedbackBewertedTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setFeedbackBewerted(streBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setFeedbackUser"
    '''</summary>
    <TestMethod()> _
    Public Sub setFeedbackUserTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setFeedbackUser(streBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setGalerie_delete"
    '''</summary>
    <TestMethod()> _
    Public Sub setGalerie_deleteTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setGalerie_delete(id)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setINITDB"
    '''</summary>
    <TestMethod()> _
    Public Sub setINITDBTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strDBPfad As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strConnection As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setINITDB(strDBPfad, strConnection)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setInsert_Update_tLvw2SQL"
    '''</summary>
    <TestMethod()> _
    Public Sub setInsert_Update_tLvw2SQLTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvwData As ListViewItem = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setInsert_Update_tLvw2SQL(lvwData, lvwName, strModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setKunden_delete"
    '''</summary>
    <TestMethod()> _
    Public Sub setKunden_deleteTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim email As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim eBay_account As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setKunden_delete(email, eBay_account)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setListviewData_save"
    '''</summary>
    <TestMethod()> _
    Public Sub setListviewData_saveTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lvwData As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim lvwDataExpected As ListView = Nothing ' TODO: Passenden Wert initialisieren
        Dim frm As frmAuktionmanagement = Nothing ' TODO: Passenden Wert initialisieren
        Dim pgreBayLiveUpdate As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim pgreBayLiveUpdateExpected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setListviewData_save(lvwData, frm, pgreBayLiveUpdate)
        Assert.AreEqual(lvwDataExpected, lvwData)
        Assert.AreEqual(pgreBayLiveUpdateExpected, pgreBayLiveUpdate)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setListViewTranslation"
    '''</summary>
    <TestMethod()> _
    Public Sub setListViewTranslationTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim setListviewId As clsDatenbank.getlvwEbayLive = New clsDatenbank.getlvwEbayLive ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setListViewTranslation(setListviewId)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewsletter"
    '''</summary>
    <TestMethod()> _
    Public Sub setNewsletterTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streMail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewsletter(streMail, bModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewsletter_CRC"
    '''</summary>
    <TestMethod()> _
    Public Sub setNewsletter_CRCTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewsletter_CRC(strModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewsletter_reset"
    '''</summary>
    <TestMethod()> _
    Public Sub setNewsletter_resetTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewsletter_reset
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewsletterCRC_update"
    '''</summary>
    <TestMethod()> _
    Public Sub setNewsletterCRC_updateTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim id As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim CRC As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewsletterCRC_update(id, CRC)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setNewslettereMailSended"
    '''</summary>
    <TestMethod()> _
    Public Sub setNewslettereMailSendedTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strEMail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setNewslettereMailSended(strEMail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setOrder2Profil"
    '''</summary>
    <TestMethod()> _
    Public Sub setOrder2ProfilTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setOrder2Profil(strID, strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setOrdered_byBeschreibung"
    '''</summary>
    <TestMethod()> _
    Public Sub setOrdered_byBeschreibungTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strBeschreibung As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setOrdered_byBeschreibung(strBeschreibung)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setOrdered_byYABEID"
    '''</summary>
    <TestMethod()> _
    Public Sub setOrdered_byYABEIDTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strYABEID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setOrdered_byYABEID(strYABEID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setPersonalID2Item"
    '''</summary>
    <TestMethod()> _
    Public Sub setPersonalID2ItemTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim iPersonal As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strTable As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setPersonalID2Item(streBayID, iPersonal, strTable)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setProgressbarModus"
    '''</summary>
    <TestMethod()> _
    Public Sub setProgressbarModusTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim pogrgressbar As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim pogrgressbarExpected As ProgressBar = Nothing ' TODO: Passenden Wert initialisieren
        Dim strQuery As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setProgressbarModus(pogrgressbar, strQuery)
        Assert.AreEqual(pogrgressbarExpected, pogrgressbar)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSYNC_History_live"
    '''</summary>
    <TestMethod()> _
    Public Sub setSYNC_History_liveTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim ID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSYNC_History_live(ID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSyncOrders2Profil"
    '''</summary>
    <TestMethod()> _
    Public Sub setSyncOrders2ProfilTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSyncOrders2Profil
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setSyncProfil2Adress"
    '''</summary>
    <TestMethod()> _
    Public Sub setSyncProfil2AdressTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setSyncProfil2Adress
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setTestOpenDB"
    '''</summary>
    <TestMethod()> _
    Public Sub setTestOpenDBTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim expected As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim actual As String
        actual = target.setTestOpenDB
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setTranslate_vorlage_delete"
    '''</summary>
    <TestMethod()> _
    Public Sub setTranslate_vorlage_deleteTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strBereich As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setTranslate_vorlage_delete(strBereich)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setTranslate_vorlage_neu"
    '''</summary>
    <TestMethod()> _
    Public Sub setTranslate_vorlage_neuTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strName As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strBereich As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setTranslate_vorlage_neu(strName, strBereich)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setTranslate_vorlage_renamme"
    '''</summary>
    <TestMethod()> _
    Public Sub setTranslate_vorlage_renammeTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strBereich As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strBereichOld As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setTranslate_vorlage_renamme(strBereich, strBereichOld)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setTranslationText"
    '''</summary>
    <TestMethod()> _
    Public Sub setTranslationTextTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strVorlage As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strText As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setTranslationText(strVorlage, strText, strSprache)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setUpdateIsSend"
    '''</summary>
    <TestMethod()> _
    Public Sub setUpdateIsSendTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID() As String = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setUpdateIsSend(streBayID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setUpdateVersandkosten"
    '''</summary>
    <TestMethod()> _
    Public Sub setUpdateVersandkostenTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim streBayID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strVersandkosten As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bModus As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strPaypal As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setUpdateVersandkosten(streBayID, strVersandkosten, bModus, strPaypal)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebArtikel"
    '''</summary>
    <TestMethod()> _
    Public Sub setWebArtikelTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim frm As frmCMS_change_item = Nothing ' TODO: Passenden Wert initialisieren
        Dim bUpdate As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebArtikel(frm, bUpdate)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebArtikel_übernahme"
    '''</summary>
    <TestMethod()> _
    Public Sub setWebArtikel_übernahmeTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim frm As frmCMS_Item2Shop = Nothing ' TODO: Passenden Wert initialisieren
        Dim bUpdate As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebArtikel_übernahme(frm, bUpdate)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebArtikel_update_replace"
    '''</summary>
    <TestMethod()> _
    Public Sub setWebArtikel_update_replaceTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strSprache As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strWebID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strBeschreibungNeu As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebArtikel_update_replace(strSprache, strWebID, strBeschreibungNeu)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebartikelStatus"
    '''</summary>
    <TestMethod()> _
    Public Sub setWebartikelStatusTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim iStatus As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim iID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebartikelStatus(iStatus, iID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setWebHTMLGalerie"
    '''</summary>
    <TestMethod()> _
    Public Sub setWebHTMLGalerieTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim lbl As Label = Nothing ' TODO: Passenden Wert initialisieren
        Dim bGeboteOnly As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setWebHTMLGalerie(lbl, bGeboteOnly)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABE_item_update"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABE_item_updateTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strField As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strValue As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strTabele As clsDatenbank.datentabelle = New clsDatenbank.datentabelle ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABE_item_update(strField, strValue, strID, strTabele)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABE_Kunde_newAdress"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABE_Kunde_newAdressTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim mModus As clsDatenbank.modus = New clsDatenbank.modus ' TODO: Passenden Wert initialisieren
        Dim strUsername As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strAdditional As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABE_Kunde_newAdress(mModus, strUsername, strEmail, strAdditional)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABE_Kunde_newProfile"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABE_Kunde_newProfileTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim mModus As clsDatenbank.modus = New clsDatenbank.modus ' TODO: Passenden Wert initialisieren
        Dim strUsername As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strAdditional As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABE_Kunde_newProfile(mModus, strUsername, strEmail, strAdditional)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABE_Kunde_Profil2Adress"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABE_Kunde_Profil2AdressTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim profilID As Integer = 0 ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABE_Kunde_Profil2Adress(profilID, strEmail)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABE_kunden_adress_ArrayList"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABE_kunden_adress_ArrayListTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim mModus As clsDatenbank.modus = New clsDatenbank.modus ' TODO: Passenden Wert initialisieren
        Dim aryList As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABE_kunden_adress_ArrayList(mModus, aryList)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABE_kunden_adress_eBayTransaktion"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABE_kunden_adress_eBayTransaktionTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim mModus As clsDatenbank.modus = New clsDatenbank.modus ' TODO: Passenden Wert initialisieren
        Dim oGetSellerTransactionsCall As TransactionType = Nothing ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABE_kunden_adress_eBayTransaktion(mModus, oGetSellerTransactionsCall)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABE_Order_status"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABE_Order_statusTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim strID As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim strModus As clsDatenbank.yabe_bestellstatus = New clsDatenbank.yabe_bestellstatus ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABE_Order_status(strID, strModus)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub

    '''<summary>
    '''Ein Test für "setYABEKunden"
    '''</summary>
    <TestMethod()> _
    Public Sub setYABEKundenTest()
        Dim target As clsDatenbank = New clsDatenbank ' TODO: Passenden Wert initialisieren
        Dim aryList As ArrayList = Nothing ' TODO: Passenden Wert initialisieren
        Dim strEmail As String = String.Empty ' TODO: Passenden Wert initialisieren
        Dim bInsert As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim expected As Boolean = False ' TODO: Passenden Wert initialisieren
        Dim actual As Boolean
        actual = target.setYABEKunden(aryList, strEmail, bInsert)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Überprüfen Sie die Richtigkeit dieser Testmethode.")
    End Sub
End Class
