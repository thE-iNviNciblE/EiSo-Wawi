Imports System.Xml.Serialization
Imports System.IO
Imports CookComputing.XmlRpc
Imports YabE.net.cubss
Imports System.Net

Public Class clsMagentoAPI

    Public gbl_strSession As String ' Globale Session 
    Private magentoAPI As New MagentoService
    Public setStoreviewName As String
    Dim mc_filer As New filters

    Public isLogedIn As Boolean = False



    '##############################################
    '# >> Produktliste 
    '##############################################
    Public Function getCategory_products_info(ByRef lvw As ListView, ByVal id As String, ByVal produktSet As String) As Boolean
        Try
            Dim mc_filter As New catalogProductRequestAttributes
            Dim str(7) As String
            str(0) = "name"
            str(1) = "sku"
            str(2) = "status"
            str(3) = "visibility"
            str(4) = "price"
            str(5) = "type"
            str(6) = "short_description"
            str(7) = "description"

            mc_filter.attributes = str
            'mc_filter.additional_attributes = str
            'mc_filer.attributes()
            Dim objResource As catalogProductReturnEntity
            objResource = magentoAPI.catalogProductInfo(gbl_strSession, id, "admin", mc_filter, Nothing)
            Dim lvwItem As New ListViewItem
            lvwItem.Text = id
            lvwItem.SubItems.Add(objResource.name)
            lvwItem.SubItems.Add(objResource.price)
            lvwItem.SubItems.Add(produktSet)
            lvwItem.SubItems.Add(objResource.type)
            lvwItem.SubItems.Add(objResource.visibility)
            lvwItem.SubItems.Add(objResource.sku)
            lvwItem.SubItems.Add(objResource.status)
            lvwItem.SubItems.Add(objResource.short_description)
            lvwItem.SubItems.Add(objResource.description)
            Application.DoEvents()

            lvw.Items.Add(lvwItem)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    '#########################################################################
    '# >> 
    '#########################################################################
    Public Function setNewImage(ByVal sku As String, ByVal strBild As String) As Boolean
        Try
            Dim objMediaResource As New catalogProductAttributeMediaCreateEntity
            Dim objFileImage As New catalogProductImageFileEntity

            Dim request As WebRequest = WebRequest.Create(strBild)

            clsUpdateDownloader = New WebFileDownloader
            'txtDownloadTo.Text.TrimEnd("\"c) 
            Application.DoEvents()
            clsUpdateDownloader.DownloadFileWithProgress(strBild, "C:\123.jpg", False)


            Dim fullImpgPath As String = "C:\123.jpg"
            objFileImage.name = sku
            objFileImage.content = System.Convert.ToBase64String(System.IO.File.ReadAllBytes(fullImpgPath))
            Dim ext As String = System.IO.Path.GetExtension(fullImpgPath).ToLower()
            Select Case ext
                Case ".gif"
                    objFileImage.mime = "image/gif"

                Case ".jpg"
                    objFileImage.mime = "image/jpeg"
                Case ".jpeg"
                    objFileImage.mime = "image/jpeg"

                Case ".png"
                    objFileImage.mime = "image/png"

                Case ".bmp"
                    objFileImage.mime = "image/bmp"

                Case ".tif"
                Case ".tiff"
                    objFileImage.mime = "image/tiff"


                    ' objFileImage.mime = "application/octet-stream"
            End Select

            objMediaResource.position = 0
            objMediaResource.exclude = 0
            Dim strType(2) As String
            strType(0) = "image"
            strType(1) = "small_image"
            strType(2) = "thumbnail"
            objMediaResource.types = strType

            objMediaResource.file = objFileImage
            magentoAPI.catalogProductAttributeMediaCreate(gbl_strSession, sku, objMediaResource, "admin", Nothing)

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setNewMagentoImage")
            Return False
        End Try
    End Function

    '####################################################################
    '# >> Attributliste von Magento holen 
    '####################################################################
    Public Function getAttributList(ByVal cmb As ComboBox) As Boolean
        Try
            Dim atrib() As catalogProductAttributeSetEntity
            '
            atrib = magentoAPI.catalogProductAttributeSetList(gbl_strSession)
            Dim i As Integer = 0
            For i = 0 To atrib.Length
                cmb.Items.Add(atrib(i).name)
            Next
        Catch ex As Exception
            Call debug_message(ex, "getAttributList")
            Return False
        End Try
    End Function

    '#########################################################
    '# >> Neuen Magento Artikel anlegen 
    '#########################################################
    Public Function setItemNew(ByVal arryList As ArrayList) As Integer
        Try
            Dim productID As Integer
            Dim objResource As New catalogProductCreateEntity
            '# 0 - Gewicht
            '# 1 - Steuerklasse (ID)
            '# 2 - Preis  (0.0)
            '# 3 - Kurzbeschreibung
            '# 4 - Lange Beschreibung
            '# 5 - Name
            '# 6 - Status (ID)
            '# 7 - Sichtbarkeit (ID)
            '# 8 - URL - KEY (Name) 
            '# 9 - Attributset (ID)
            '# 10 - SKU 
            '# 11 - Kategorien

            objResource.weight = arryList.Item(0)
            objResource.tax_class_id = arryList.Item(1)
            objResource.price = arryList.Item(2)
            objResource.short_description = arryList.Item(3)
            objResource.description = arryList.Item(4)
            objResource.name = arryList.Item(5)
            objResource.status = arryList.Item(6)
            objResource.visibility = arryList.Item(7)
            objResource.url_key = arryList.Item(8)
            Dim str() As String = arryList.Item(11).ToString.Split(",")
            objResource.categories = str

            productID = magentoAPI.catalogProductCreate(gbl_strSession, "simple", "4", arryList.Item(10), objResource)

            'Call setNewImage(productID)
            Return productID
        Catch ex As Exception
            MsgBox(ex.Message)
            'Return -1
        End Try
    End Function

    '########################################
    '# >> Kategorie Informationen laden
    '########################################
    Public Function getCategoryInfo(ByVal iCat As Integer) As catalogCategoryInfo
        Try
            Dim objResource As catalogCategoryInfo
            Dim strAttribut() As String
            objResource = magentoAPI.catalogCategoryInfo(gbl_strSession, iCat, "", strAttribut)

            Return objResource
        Catch ex As Exception

        End Try
    End Function

    '########################################
    '# >> Kategorie Produkte Laden Produkte 
    '########################################
    Public Function getCategory_productsBYcat(ByRef lvw As ListView, Optional ByVal Category_id As Integer = 2) As Boolean
        Try

            lvw.Items.Clear()
            Dim objResource() As catalogAssignedProduct

            objResource = magentoAPI.catalogCategoryAssignedProducts(gbl_strSession, Category_id)
            Application.DoEvents()
            Call getAry2Products(lvw, objResource)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '########################################
    '# >> Kategorie Informationen SPEICHERN
    '########################################
    Public Function setCategoryInfo(ByVal strCatID As String, ByVal catData As catalogCategoryEntityCreate) As Boolean
        Try

            If magentoAPI.catalogCategoryUpdate(gbl_strSession, strCatID, catData, setStoreviewName) Then
                MsgBox("Kategorie Informationen wurden gespeichert :-)", MsgBoxStyle.Information)
            Else
                MsgBox("Kategorie Informationen konnten nicht gespeichert werden", MsgBoxStyle.Exclamation)
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '########################################
    '# >> Produkte Informationen laden 
    '########################################
    Public Function getProductInfo(ByVal strProduct As String, ByVal strType As String) As catalogProductReturnEntity
        Try

            Dim objResource As catalogProductReturnEntity
            Dim productRequest As New catalogProductRequestAttributes
            Dim strFields(4) As String
            strFields(0) = "description"
            strFields(1) = "status"
            strFields(2) = "name"
            strFields(3) = "type_id"
            strFields(4) = "weight"
            productRequest.attributes = strFields
            ' productRequest.attributes = 
            objResource = magentoAPI.catalogProductInfo(gbl_strSession, "34", "de", productRequest, "26")
            Return objResource
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    '########################################
    '# >> Produkte laden 
    '########################################
    Public Function getCategory_products(ByRef lvw As ListView, Optional ByVal Category_id As Integer = 2) As Boolean
        Try

            lvw.Items.Clear()
            Dim objResource() As catalogProductEntity

            '# Komplexer Filter 
            Dim aE As associativeEntity
            aE = New associativeEntity()
            aE.key = "like" 'like - is - gt - 
            aE.value = "YabE%" '"n%"
            'aE.value = "8" '"n%"

            Dim cF(0) As complexFilter
            cF(0) = New complexFilter()
            cF(0).key = "name"
            'cF(0).key = "category_ids"
            cF(0).value = aE



            'ReDim ase(0)
            ' ase(0).key = "category_id"
            '  ase(0).value = Category_id

            ' flt.value = ase ' Category_id
            ' flt.key = "category_id"
            ' cpf = flt

            '  ReDim mc_filer.filter(0)
            '  mc_filer.filter(0) = ase
            ' ReDim mc_filer.complex_filter(0)
            ' mc_filer.complex_filter = flt
            ' mc_filer.filter = ase
            Dim mc_filter As filters
            mc_filter = New filters()
            mc_filter.complex_filter = cF

            objResource = magentoAPI.catalogProductList(gbl_strSession, mc_filter, setStoreviewName)

            Call getAry2Products(lvw, objResource)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '##############################################
    '# >> Category - Info 
    '##############################################
    Public Function getCategory_info(ByRef lvw As ListView, Optional ByVal Category_id As Integer = 2) As Boolean
        Try

            Dim objResource As catalogCategoryInfo
            Dim str() As String
            objResource = magentoAPI.catalogCategoryInfo(gbl_strSession, Category_id, setStoreviewName, str)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function getOrders(ByVal lvw As ListView) As Boolean
        Try

            Dim objResource() As salesOrderEntity
            objResource = magentoAPI.salesOrderList(gbl_strSession, mc_filer)
            Call getAryOrder2Listview(lvw, objResource)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '##############################################
    '# >> Category 
    '##############################################
    Public Function getUserList(ByRef lvw As ListView) As Boolean
        Try

            lvw.Items.Clear()
            Dim objResource() As customerCustomerEntity
            objResource = magentoAPI.customerCustomerList(gbl_strSession, mc_filer)

            If getAryKunden2Listview(lvw, objResource) = False Then
                MsgBox("Es ist ein Fehler aufgetreten")
            End If



            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '##############################################
    '# >> Kategory 
    '##############################################
    Public Function getCategoryTree(ByRef lvw As ListView, ByVal bInsert_menue As Boolean, Optional ByVal catID As Integer = 2) As Boolean
        Try


            Dim objResource As catalogCategoryTree
            If gbl_strSession = Nothing Then
                Call getLogin()
            End If
            objResource = magentoAPI.catalogCategoryTree(gbl_strSession, catID, setStoreviewName)

            Call getAry2Category(lvw, objResource, bInsert_menue)


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '###########################################################
    '# >> Login Starten und Session ID zuweisen 
    '###########################################################
    Public Function getLogin() As Boolean

        Dim strSession As String
        '        strSession = magentoAPI.login("api_invincible", "ooiNdiEfljxsgszSvKvC")

        Try

            If My.Settings.magento_username.Length = 0 Then
                MsgBox("Bitte unter den Optionen den Benutzernamen für Magento eintragen", MsgBoxStyle.Exclamation)
                Return False
            End If

            If My.Settings.magento_pwd.Length = 0 Then
                MsgBox("Bitte unter den Optionen den Passwort für Magento eintragen", MsgBoxStyle.Exclamation)
                Return False
            End If

            If My.Settings.magento_url.Length = 0 Then
                MsgBox("Bitte eine Shop URL in den Optionen hinterlegen", MsgBoxStyle.Exclamation)
                Return False
            End If

            'magentoAPI.Url = "http://www.philafriend.de/api/v2_soap?wsdl=1"
            'magentoAPI.Url = "http://www.td-briefmarken.de/index.php/api/v2_soap/index/"
            'magentoAPI.Url = My.Settings.magento_url
            magentoAPI.AllowAutoRedirect = True
            strSession = magentoAPI.login(My.Settings.magento_username, My.Settings.magento_pwd)
            If strSession.Length > 0 Then
                gbl_strSession = strSession
                isLogedIn = True
                Return True
            Else
                isLogedIn = False
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            isLogedIn = False
            Return False
        End Try


    End Function

    '#################################
    '#
    '# >> Magento Array PARSER
    '#
    '#################################
    Private Function getAryOrder2Listview(ByRef lvw As ListView, ByVal strAry() As salesOrderEntity) As Boolean
        Try
            Dim iCount As Integer = 0

            lvw.Items.Clear()

            For iCount = 0 To strAry.Length - 1

                Try
                    Dim request As WebRequest = WebRequest.Create("http://www.philafriend.de/yabe.php?order_id=" & strAry(iCount).order_id)

                    '# Server - Login 
                    request.Credentials = CredentialCache.DefaultCredentials

                    '# Server - Antwort 
                    Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

                    '# Status anzeigen 
                    Console.WriteLine(response.StatusDescription)

                    '# Hole den Stream 
                    Dim dataStream As Stream = response.GetResponseStream()

                    '# Benutzerstream Reader zum einlesen 
                    Dim reader As New StreamReader(dataStream)

                    '# Alles einlesen 
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim strLines() As String = responseFromServer.Split("<br>")
                    '  salesItem = strAry(iCount).items(0).name
                    Dim iloop As Integer = 0
                    For iloop = 0 To strLines.Length - 1

                        Dim lvwItem As New ListViewItem
                        lvwItem.Text = strAry(iCount).order_id
                        lvwItem.SubItems.Add(strAry(iCount).customer_firstname & " " & strAry(iCount).customer_lastname)
                        lvwItem.SubItems.Add(strAry(iCount).customer_email)

                        Dim strRows() As String = strLines(iloop).Split("|")

                        If strRows.Length > 1 Then
                            lvwItem.SubItems.Add(strRows(5)) ' Ort
                            lvwItem.SubItems.Add(strRows(7)) ' Land
                            lvwItem.SubItems.Add(strRows(8)) ' Strasse 


                            ' lvwItem.SubItems.Add(Math.Round((Convert.ToDouble(strRows(1).Replace(".", ",")) + (Convert.ToDouble(strRows(1).Replace(".", ",")) / 100 * My.Settings.yabe_magento_sync_mwst)), 2))
                            'lvwItem.SubItems.Add(strRows(1))
                            Dim dblTax As Double = Convert.ToDouble(strRows(11).Replace(".", ","))
                            Dim dblItem As Double = Math.Round(Convert.ToDouble(strRows(1).Replace(".", ",")))
                            lvwItem.SubItems.Add(dblItem)
                            lvwItem.SubItems.Add(strRows(0).Replace("br>", "").Trim)
                            lvwItem.SubItems.Add(strRows(9))
                            lvwItem.SubItems.Add(strAry(iCount).created_at)
                            lvwItem.SubItems.Add(strAry(iCount).customer_id)
                            lvwItem.SubItems.Add(strRows(2))
                            lvwItem.SubItems.Add(strRows(6))
                            lvw.Items.Add(lvwItem)
                        End If

                    Next

                Catch ex As Exception
                    MsgBox(ex.Message, "getAryOrder2Listview")
                End Try
              


            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "getAryOrder2Listview")
            Return False
        End Try
    End Function
    '# >> Kunden 2 Listview
    Private Function getAryKunden2Listview(ByRef lvw As ListView, ByVal strAry() As customerCustomerEntity) As Boolean
        Try
            Dim iCount As Integer = 0

            For iCount = 0 To strAry.Length - 1



                Dim objResource() As customerAddressEntityItem
                objResource = magentoAPI.customerAddressList(gbl_strSession, strAry(iCount).customer_id)

                'objResource(0).city
                'objResource(0).country_id
                'objResource(0).street 
                'objResource(0).postcode  



                Dim lvwData As New ListViewItem
                lvwData.Text = strAry(iCount).customer_id
                lvwData.SubItems.Add(strAry(iCount).firstname)
                lvwData.SubItems.Add(strAry(iCount).email)

                Try
                    lvwData.SubItems.Add(objResource(0).country_id)
                Catch ex As Exception
                    lvwData.SubItems.Add("")
                End Try

                lvwData.SubItems.Add("")
                Try
                    lvwData.SubItems.Add(objResource(0).street)
                Catch ex As Exception
                    lvwData.SubItems.Add("")
                End Try

                Try
                    lvwData.SubItems.Add(objResource(0).postcode)
                Catch ex As Exception
                    lvwData.SubItems.Add("")
                End Try

                Try
                    lvwData.SubItems.Add(objResource(0).city)
                Catch ex As Exception
                    lvwData.SubItems.Add("")
                End Try

                Try
                    If objResource(0).is_default_billing = True And objResource(0).is_default_shipping Then
                        lvwData.SubItems.Add("Beides")
                    Else
                        If objResource(0).is_default_billing = True Then
                            lvwData.SubItems.Add("Bezahlung")
                        ElseIf objResource(0).is_default_shipping Then
                            lvwData.SubItems.Add("Versand")
                        End If
                    End If
                Catch ex As Exception
                    lvwData.SubItems.Add("keine Adresse")
                End Try

                lvwData.SubItems.Add(strAry(iCount).lastname)
                Try
                    lvwData.SubItems.Add(objResource(0).telephone)
                Catch ex As Exception
                    lvwData.SubItems.Add("")
                End Try

                Try
                    lvwData.SubItems.Add(objResource(0).increment_id)
                Catch ex As Exception
                    lvwData.SubItems.Add("")
                End Try

                lvw.Items.Add(lvwData)

            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    '#########################################################
    '# >> Kundenprofil aktualisieren  
    '#########################################################
    Public Function setCustomerData(ByVal customerID As Integer, ByVal customerData As customerCustomerEntityToCreate) As Boolean
        Try
            Dim bRes As Boolean = False

            bRes = magentoAPI.customerCustomerUpdate(gbl_strSession, customerID, customerData)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    '#########################################################
    '# >> Kundenprofil NEUE ANLEGEN  
    '#########################################################
    Public Function setCustomerData_new(ByVal customerData As customerCustomerEntityToCreate) As Integer
        Try


            Return magentoAPI.customerCustomerCreate(gbl_strSession, customerData)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function
    '#########################################################
    '# >> Kunden Adressdaten aktualisieren  
    '#########################################################
    Public Function setCustomerAdressData_new(ByVal customerID As Integer, ByVal adressData As customerAddressEntityCreate) As Integer
        Try

            Return magentoAPI.customerAddressCreate(gbl_strSession, customerID, adressData)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    '#########################################################
    '# >> Kunden Adressdaten aktualisieren  
    '#########################################################
    Public Function setCustomerAdressData(ByVal adressID As Integer, ByVal adressData As customerAddressEntityCreate) As Boolean
        Try
            Dim bRes As Boolean = False

            bRes = magentoAPI.customerAddressUpdate(gbl_strSession, adressID, adressData)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '#########################################################
    '# >> Länderliste
    '#########################################################
    Public Function setCustomer_delete(ByVal id As Integer) As Boolean
        Try

            Return magentoAPI.customerCustomerDelete(gbl_strSession, id)


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    '#########################################################
    '# >> Länderliste
    '#########################################################
    Public Function getCountryList(ByVal cmbData As ComboBox) As Boolean
        Try
            Dim country() As directoryCountryEntity
            Dim i As Integer

            country = magentoAPI.directoryCountryList(gbl_strSession)

            For i = 0 To country.Length
                cmbData.Items.Add(country(i).country_id)
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '#########################################################
    '# >> Regionslist
    '#########################################################
    Public Function getRegionList(ByVal cmbData As ComboBox, ByVal strCountry As String) As Boolean
        Try
            Dim region() As directoryRegionEntity
            Dim i As Integer

            region = magentoAPI.directoryRegionList(gbl_strSession, strCountry)

            For i = 0 To region.Length
                cmbData.Items.Add(region(i).name)
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '# >> Categorie 2 Childen 
    Private Function getCategoryChildren(ByRef lvw As ListView, ByVal strAry() As catalogCategoryEntity, ByVal iParrent As Integer, ByVal bInsert As Boolean) As Boolean
        Dim iCount As Integer = 0
        Dim iCount2 As Integer = 0
        Dim iSpace As Integer = 0
        Dim strSpace As String = " "
        Dim strSpace_new As String = ""
        Dim iParrent_sub As Integer = -1
        Try
            Try
                iSpace = strAry(iCount).level
                For iCount2 = 0 To iSpace
                    strSpace_new &= strSpace
                Next
            Catch ex As Exception
                strSpace_new = "  "
            End Try


            For iCount = 0 To strAry.Length - 1



                Dim lvwData As New ListViewItem
                lvwData.Text = strAry(iCount).category_id
                lvwData.SubItems.Add(strSpace_new & strAry(iCount).name)
                lvwData.SubItems.Add(strAry(iCount).level)
                lvwData.SubItems.Add(strAry(iCount).position)
                lvw.Items.Add(lvwData)
                Application.DoEvents()
                If bInsert = True Then
                    iParrent_sub = clsDatenbank_modul.setCMS_NewMenue_Sub(strAry(iCount).name, iParrent, strAry(iCount).category_id)
                End If


                If Not strAry(iCount).children Is Nothing Then

                    getCategoryChildren(lvw, strAry(iCount).children, iParrent_sub, bInsert)

                End If

            Next

        Catch ex As Exception
            MsgBox(ex, "getCategoryChildren")
        End Try
    End Function

    '# >> Categorie 2 Listview 
    Private Function getAry2Category(ByRef lvw As ListView, ByVal strAry As catalogCategoryTree, ByVal bInsertMenue As Boolean) As Boolean
        Try
            Dim iCount As Integer = 0
            Dim bStop As Boolean = False
            Dim iParrent As Integer

            For iCount = 0 To strAry.children.Length - 1

                Dim lvwData As New ListViewItem
                lvwData.Text = strAry.children(iCount).category_id
                lvwData.SubItems.Add(" >> " & strAry.children(iCount).name)
                lvwData.SubItems.Add(strAry.children(iCount).level)
                lvwData.SubItems.Add(strAry.children(iCount).position)
                lvw.Items.Add(lvwData)
                Application.DoEvents()
                'Call getAry2Category_level(lvw, strAry.children(iCount))
                If bInsertMenue = True Then
                    iParrent = clsDatenbank_modul.setCMS_NewMenue_Sub(strAry.children(iCount).name, 0, strAry.children(iCount).category_id)
                End If

                Application.DoEvents()

                If Not strAry.children(iCount).children Is Nothing Then

                    getCategoryChildren(lvw, strAry.children(iCount).children, iParrent, bInsertMenue)

                End If

            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    '# >> Unterkategorien 2 Listview 
    Private Function getAry2Category_level(ByRef lvw As ListView, ByVal strAry As catalogCategoryEntity) As Boolean

        Dim lvwData As New ListViewItem
        lvwData.Text = strAry.category_id
        lvwData.SubItems.Add(strAry.name)
        lvwData.SubItems.Add(strAry.level)
        lvwData.SubItems.Add(strAry.position)
        lvw.Items.Add(lvwData)
    End Function

    '# >> Produkte 2 Listview - > Auskategorie abrufen 
    Private Function getAry2Products(ByRef lvw As ListView, ByVal strAry() As catalogAssignedProduct) As Boolean
        Dim iCount As Integer = 0

        Try

            For iCount = 0 To strAry.Length - 1

                'Dim lvwData As New ListViewItem
                'lvwData.Text = strAry(iCount).product_id
                ' lvwData.SubItems.Add("")
                ' lvwData.SubItems.Add(strAry(iCount).set)
                ' lvwData.SubItems.Add(strAry(iCount).sku)
                ' lvwData.SubItems.Add(strAry(iCount).type)

                Call getCategory_products_info(lvw, strAry(iCount).product_id, strAry(iCount).set)

                ' lvw.Items.Add(lvwData)
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function setNewCustomer() As Boolean
        Try

            Dim customer As customerCustomerEntityToCreate
            'customer.
            magentoAPI.customerCustomerCreate(gbl_strSession, customer)


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '#######################################
    '# >> Artikel deaktivieren im Shop
    '# 1: Aktiv
    '# 2: Inaktiv
    '#######################################
    Public Function setItem_update_disable(ByVal strSKU As String, ByVal strModus As String) As Boolean
        Try
            Dim data As New catalogProductCreateEntity
            data.status = strModus
            Dim i As Integer = magentoAPI.catalogProductUpdate(gbl_strSession, strSKU, data, setStoreviewName, Nothing)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '# Magento Artikel löschen
    Public Function setItem_delete(ByVal strSKU As String) As Boolean
        Try

            Dim i As Integer = magentoAPI.catalogProductDelete(gbl_strSession, strSKU, Nothing)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '# >> Produkte 2 Listview - > Auskategorie abrufen 
    Private Function getAry2Products(ByRef lvw As ListView, ByVal strAry() As catalogProductEntity) As Boolean
        Try

            Dim iCount As Integer = 0

            For iCount = 0 To strAry.Length - 1

                Dim lvwData As New ListViewItem
                lvwData.Text = strAry(iCount).product_id
                lvwData.SubItems.Add(strAry(iCount).name)
                lvwData.SubItems.Add(strAry(iCount).set)
                lvwData.SubItems.Add(strAry(iCount).sku)
                lvwData.SubItems.Add(strAry(iCount).type)
                lvwData.SubItems.Add(strAry(iCount).sku)
                lvwData.SubItems.Add(strAry(iCount).sku)
                'Call getCategory_products_info(lvw, strAry(iCount).name)

                lvw.Items.Add(lvwData)
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function setCategory_new(ByVal lvwItem As ListViewItem) As Boolean
        Dim catData As New catalogCategoryEntityCreate
        Dim iResult As Integer
        Dim str(1) As String
        str(0) = "position"
        str(1) = "name"
        catData.name = "Testing"
        catData.is_active = 1
        catData.is_activeSpecified = True
        catData.available_sort_by = str
        catData.default_sort_by = "position"
        catData.is_anchorSpecified = True
        catData.is_anchor = 1
        iResult = magentoAPI.catalogCategoryCreate(gbl_strSession, 2, catData, setStoreviewName)
        MsgBox(iResult)

    End Function

    '#######################################################################
    '# >> Magento CSV Export 
    '#######################################################################
    Public Function setCSVExporter(ByVal oItem As ListViewItem, Optional ByVal aryDataList As ArrayList = Nothing) As String
        Dim Q As String = Chr(34)
        Dim QC As String = Chr(34) + ";"
        Dim sLine As String = ""
        Dim strBild As String = ""
        Dim strBild_TN As String = ""

        sLine = Q + oItem.SubItems(0).Text + QC

        '# 0 Storeview
        '# 1 Status
        '# 2 Sichtbarkeit
        '# 3 Steuerklasse
        '# 4 Menge 
        '# 5 Shop Name 
        '# 6 Attributset
        sLine += Q + aryDataList.Item(5).ToString() + QC ' Shop Name 
        sLine += Q + aryDataList.Item(0).ToString() + QC ' Storeview
        sLine += Q + aryDataList.Item(6).ToString() + QC ' Attributset
        sLine += Q + "simple" + QC
        sLine += Q & oItem.SubItems(4).Text & QC ' ToDo 
        sLine += Q + "0" + QC


        sLine += Q & setBeschreibungsLänge(oItem.SubItems(1).Text, 12) & QC ' Name

        sLine += Q + oItem.SubItems(2).Text + QC ' Preis
        sLine += Q + oItem.SubItems(1).Text + QC ' Beschreibung

        sLine += Q + setBeschreibungsLänge(oItem.SubItems(1).Text, 8) + QC ' Kurzbeschreibung


        sLine += Q + "0.00" + QC ' Gewicht
        sLine += Q + aryDataList.Item(1).ToString() + QC ' Status
        sLine += Q + aryDataList.Item(2).ToString() + QC ' Sichtbarkeit
        sLine += Q + aryDataList.Item(3).ToString() + QC ' Steuerklasse
        sLine += Q + aryDataList.Item(4).ToString() + QC ' Menge
        sLine += Q + "0" + QC ' Minimale Menge

        strBild = oItem.SubItems(3).Text
        strBild_TN = oItem.SubItems(3).Text

        strBild = strBild.Replace(My.Settings.shop_url & "/eBay/", "/")
        strBild = strBild.Replace(".JPG", ".jpg")

        'strBild_TN = strBild_TN.Replace("http://www.philafriend1.de/eBay/", "e/b/TN_")
        'If strBild_TN.Contains("philafriend") = True Then
        '    strBild_TN = strBild_TN.Replace("philafriend1/", "TN_")
        '    strBild_TN = strBild_TN.Replace("philafriend2/", "TN_")
        '    strBild_TN = strBild_TN.Replace("philafriend3/", "TN_")
        '    strBild_TN = strBild_TN.Replace("philafriend/", "TN_")
        'End If

        sLine += Q + strBild + QC ' Hauptbild
        sLine += Q + strBild + QC ' Kleiner Bild 
        sLine += Q + strBild + QC ' Thumbnail

        Return sLine
    End Function

End Class
