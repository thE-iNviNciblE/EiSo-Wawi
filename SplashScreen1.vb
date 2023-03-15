Public NotInheritable Class SplashScreen1

    Public bCloseOnClick As Boolean = False

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If bCloseOnClick = False Then

            tmrCloseDown.Enabled = True



            'Anwendungstitel
            If My.Application.Info.Title <> "" Then
                'ApplicationTitle.Text = My.Application.Info.Title
            Else
                'Wenn der Anwendungstitel fehlt, Anwendungsnamen ohne Erweiterung verwenden.
                'ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If

            'Application.DoEvents()
            'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

            'Copyrightinformationen
            'Copyright.Text = My.Application.Info.Copyright
        End If

    End Sub

    Private Sub tmrCloseDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCloseDown.Tick
        tmrCloseDown.Enabled = False
        Me.Close()
    End Sub

    Private Sub MainLayoutPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainLayoutPanel.Click

        Me.Close()
        frmMain.laden_auktionsmanagement()

    End Sub
 
    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
