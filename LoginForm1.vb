Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security

Public Class LoginForm1

    ' TODO: Code zum Durchführen der benutzerdefinierten Authentifizierung mithilfe des angegebenen Benutzernamens und des Kennworts hinzufügen 
    ' (Siehe http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Der benutzerdefinierte Prinzipal kann anschließend wie folgt an den Prinzipal des aktuellen Threads angefügt werden: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' wobei CustomPrincipal die IPrincipal-Implementierung ist, die für die Durchführung der Authentifizierung verwendet wird. 
    ' Anschließend gibt My.User Identitätsinformationen zurück, die in das CustomPrincipal-Objekt gekapselt sind,
    ' z.B. den Benutzernamen, den Anzeigenamen usw.

    Private Shared Function customCertValidation(ByVal sender As Object,
                                                ByVal cert As X509Certificate,
                                                ByVal chain As X509Chain,
                                                ByVal errors As SslPolicyErrors) As Boolean
        Return True
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim result As String = ""
        Using client As New WebClient

            'Dim reqparm As New Specialized.NameValueCollection
            'reqparm.Add("modus", "api_login_user")
            'reqparm.Add("txtUsername", UsernameTextBox.Text)
            'reqparm.Add("txtPasswort", PasswordTextBox.Text)

            'Dim responsebytes = client.UploadValues("http://shopste.com/api.php", "POST", reqparm)

            '  result = client.UploadString("http://shopste.com/api.php", "modus=api_login_user&txtUsername=" + UsernameTextBox.Text & "&txtPasswort=" + PasswordTextBox.Text)
            ' MessageBox.Show(result)
        End Using


        ServicePointManager.ServerCertificateValidationCallback =
            New System.Net.Security.RemoteCertificateValidationCallback(AddressOf customCertValidation)

        Dim Request As HttpWebRequest = CType(WebRequest.Create(My.Settings.SHOPSTE_API_URL), HttpWebRequest)
        Request.Method = "POST"
        Request.ContentType = "application/x-www-form-urlencoded"
        Dim Post As String = "modus=api_login_user&txtUsername=" & UsernameTextBox.Text & "&txtPasswort=" & PasswordTextBox.Text
        Dim byteArray() As Byte = Encoding.UTF8.GetBytes(Post)
        Request.ContentLength = byteArray.Length
        Dim DataStream As Stream = Request.GetRequestStream()
        DataStream.Write(byteArray, 0, byteArray.Length)
        DataStream.Close()
        Dim Response As HttpWebResponse = Request.GetResponse()
        DataStream = Response.GetResponseStream()
        Dim reader As New StreamReader(DataStream)
        Dim ServerResponse As String = reader.ReadToEnd()
        reader.Close()
        DataStream.Close()
        Response.Close()

        If InStr(ServerResponse, "LOGIN_OK") Then
            Dim str() As String = ServerResponse.Split("~")
            My.Settings.domain_id = str(1)
            My.Settings.domain_name = str(2)
            My.Settings.benutzername = UsernameTextBox.Text
            My.Settings.passwort = PasswordTextBox.Text

            If str.Length >= 3 Then
                My.Settings.shopste_main_kategorie = str(3)
            End If

            My.Settings.Save()

            If My.Settings.DELCAMPE_ENDE_BEI_NULL = "false" Then
                setShopsteConfig(My.Settings.domain_id, "DELCAMPE_ENDE_BEI_NULL", "N")
            Else
                setShopsteConfig(My.Settings.domain_id, "DELCAMPE_ENDE_BEI_NULL", "Y")
            End If

            If My.Settings.DELCAMPE_AKTIV = "false" Then
                setShopsteConfig(My.Settings.domain_id, "DELCAMPE_AKTIV", "N")
            Else
                setShopsteConfig(My.Settings.domain_id, "DELCAMPE_AKTIV", "Y")
            End If

            setShopsteConfig(My.Settings.domain_id, "EISO_IMPORT", "Y")
            setShopsteConfig(My.Settings.domain_id, "EISO_USERNAME", My.Settings.yabe_username)
            setShopsteConfig(My.Settings.domain_id, "EISO_PASSWORT", My.Settings.yabe_pwd)
            setShopsteConfig(My.Settings.domain_id, "EISO_SERVER", My.Settings.EISO_SERVER)
            setShopsteConfig(My.Settings.domain_id, "EISO_SERVER_HTTPS", My.Settings.EISO_SERVER_HTTPS)
            setShopsteConfig(My.Settings.domain_id, "EISO_PREFIX", My.Settings.EISO_PREFIX)

            setShopsteConfig(My.Settings.domain_id, "EISO_SHOP_URL", My.Settings.shop_url)

            reader.Close()
            DataStream.Close()
            Response.Close()

            Me.Close()
        Else
            MessageBox.Show("Login nicht OK")
        End If

    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = My.Settings.benutzername
        PasswordTextBox.Text = settings_crypt(False, My.Settings.passwort)
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
