<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoogleBaseManager
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ItemCount = New System.Windows.Forms.Label
        Me.BaseGrid = New System.Windows.Forms.DataGrid
        Me.PostData = New System.Windows.Forms.Button
        Me.GetData = New System.Windows.Forms.Button
        Me.BaseUri = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.AppKey = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Password = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Username = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.BaseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemCount
        '
        Me.ItemCount.Location = New System.Drawing.Point(33, 427)
        Me.ItemCount.Name = "ItemCount"
        Me.ItemCount.Size = New System.Drawing.Size(177, 16)
        Me.ItemCount.TabIndex = 23
        Me.ItemCount.Text = "Keine Artikel"
        '
        'BaseGrid
        '
        Me.BaseGrid.CaptionVisible = False
        Me.BaseGrid.DataMember = ""
        Me.BaseGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.BaseGrid.Location = New System.Drawing.Point(23, 147)
        Me.BaseGrid.Name = "BaseGrid"
        Me.BaseGrid.Size = New System.Drawing.Size(812, 272)
        Me.BaseGrid.TabIndex = 22
        '
        'PostData
        '
        Me.PostData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PostData.Enabled = False
        Me.PostData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PostData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostData.Location = New System.Drawing.Point(543, 63)
        Me.PostData.Name = "PostData"
        Me.PostData.Size = New System.Drawing.Size(159, 32)
        Me.PostData.TabIndex = 20
        Me.PostData.Text = "&Daten eintragen"
        Me.PostData.UseVisualStyleBackColor = False
        '
        'GetData
        '
        Me.GetData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GetData.Enabled = False
        Me.GetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GetData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetData.Location = New System.Drawing.Point(543, 15)
        Me.GetData.Name = "GetData"
        Me.GetData.Size = New System.Drawing.Size(159, 32)
        Me.GetData.TabIndex = 19
        Me.GetData.Text = "&Daten holen"
        Me.GetData.UseVisualStyleBackColor = False
        '
        'BaseUri
        '
        Me.BaseUri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BaseUri.Location = New System.Drawing.Point(201, 95)
        Me.BaseUri.Name = "BaseUri"
        Me.BaseUri.Size = New System.Drawing.Size(307, 21)
        Me.BaseUri.TabIndex = 18
        Me.BaseUri.Text = "http://base.google.com/base/feeds/items"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Googlebase URI:"
        '
        'AppKey
        '
        Me.AppKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AppKey.Location = New System.Drawing.Point(201, 67)
        Me.AppKey.Name = "AppKey"
        Me.AppKey.Size = New System.Drawing.Size(307, 21)
        Me.AppKey.TabIndex = 16
        Me.AppKey.Text = "ABQIAAAALY1sx7qXLhWEKvO9N0l8iRT2yXp_ZAY8_ufC3CFXhHIE1NvwkxTCnG8nyqjFeOGVFiZdwggQR" & _
            "G50ew"
        Me.AppKey.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Applicationkey:"
        Me.Label3.Visible = False
        '
        'Password
        '
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.Location = New System.Drawing.Point(201, 43)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(307, 21)
        Me.Password.TabIndex = 14
        Me.Password.Text = "!HWikSdF!"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Passwort"
        '
        'Username
        '
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Username.Location = New System.Drawing.Point(201, 15)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(307, 21)
        Me.Username.TabIndex = 13
        Me.Username.Text = "DummesAOL@gmail.com"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Benutzername"
        '
        'frmGoogleBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 454)
        Me.Controls.Add(Me.ItemCount)
        Me.Controls.Add(Me.BaseGrid)
        Me.Controls.Add(Me.PostData)
        Me.Controls.Add(Me.GetData)
        Me.Controls.Add(Me.BaseUri)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AppKey)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmGoogleBase"
        Me.Text = "frmGoogleBase"
        CType(Me.BaseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemCount As System.Windows.Forms.Label
    Friend WithEvents BaseGrid As System.Windows.Forms.DataGrid
    Friend WithEvents PostData As System.Windows.Forms.Button
    Friend WithEvents GetData As System.Windows.Forms.Button
    Friend WithEvents BaseUri As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AppKey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
