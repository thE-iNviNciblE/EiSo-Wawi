Imports YabE.net.cubss

Public Class clsMagento_thread

    Dim mc As New clsMagentoAPI
    Public gbl_strSession As String ' Globale Session 
    Private magentoAPI As New MagentoService
    Public isLogedIn As Boolean = False
    Public arryList As ArrayList

    Sub New()
        Call getLogin()
    End Sub

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

            '  magentoAPI.Url = "http://www.philafriend.de/api/v2_soap?wsdl=1"
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


    '#########################################################
    '# >> Neuen Magento Artikel anlegen 
    '#########################################################
    Public Function setItemNew() As Integer
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
            ' MsgBox(ex.Message)
            Return -1
        End Try
    End Function
End Class
