<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEiSoPasswortändern
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPasswortLost = New System.Windows.Forms.Button()
        Me.txtPasswortAktuell = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPasswortNeu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPasswortNeu2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBenutzername
        '
        Me.txtBenutzername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBenutzername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBenutzername.Location = New System.Drawing.Point(14, 84)
        Me.txtBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(194, 21)
        Me.txtBenutzername.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Benutzername*"
        '
        'btnPasswortLost
        '
        Me.btnPasswortLost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPasswortLost.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnPasswortLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasswortLost.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswortLost.Image = Global.YabE.My.Resources.Resources.user_add
        Me.btnPasswortLost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPasswortLost.Location = New System.Drawing.Point(11, 205)
        Me.btnPasswortLost.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPasswortLost.Name = "btnPasswortLost"
        Me.btnPasswortLost.Size = New System.Drawing.Size(434, 27)
        Me.btnPasswortLost.TabIndex = 64
        Me.btnPasswortLost.Text = "&EiSo Passwort ändern"
        Me.btnPasswortLost.UseVisualStyleBackColor = False
        '
        'txtPasswortAktuell
        '
        Me.txtPasswortAktuell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswortAktuell.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswortAktuell.Location = New System.Drawing.Point(14, 122)
        Me.txtPasswortAktuell.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasswortAktuell.Name = "txtPasswortAktuell"
        Me.txtPasswortAktuell.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswortAktuell.Size = New System.Drawing.Size(194, 21)
        Me.txtPasswortAktuell.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Aktuelles Passwort*"
        '
        'txtPasswortNeu
        '
        Me.txtPasswortNeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswortNeu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswortNeu.Location = New System.Drawing.Point(14, 170)
        Me.txtPasswortNeu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasswortNeu.Name = "txtPasswortNeu"
        Me.txtPasswortNeu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswortNeu.Size = New System.Drawing.Size(194, 21)
        Me.txtPasswortNeu.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Neues Passwort*"
        '
        'txtPasswortNeu2
        '
        Me.txtPasswortNeu2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswortNeu2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswortNeu2.Location = New System.Drawing.Point(254, 170)
        Me.txtPasswortNeu2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasswortNeu2.Name = "txtPasswortNeu2"
        Me.txtPasswortNeu2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswortNeu2.Size = New System.Drawing.Size(194, 21)
        Me.txtPasswortNeu2.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Neues Passwort wiederholen*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Sie können hier Ihr Passwort verändern"
        '
        'frmEiSoPasswortändern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 243)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPasswortNeu2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPasswortNeu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPasswortAktuell)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPasswortLost)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmEiSoPasswortändern"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EiSo Passwort ändern"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPasswortLost As Button
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPasswortAktuell As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPasswortNeu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPasswortNeu2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
