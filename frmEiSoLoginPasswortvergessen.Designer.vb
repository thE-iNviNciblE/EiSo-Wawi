<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEiSoLoginPasswortvergessen
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
        Me.txtEmailadresse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPasswortLost = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmailadresse
        '
        Me.txtEmailadresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailadresse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailadresse.Location = New System.Drawing.Point(14, 88)
        Me.txtEmailadresse.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailadresse.Name = "txtEmailadresse"
        Me.txtEmailadresse.Size = New System.Drawing.Size(327, 21)
        Me.txtEmailadresse.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Email Adresse"
        '
        'btnPasswortLost
        '
        Me.btnPasswortLost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPasswortLost.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnPasswortLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasswortLost.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswortLost.Image = Global.YabE.My.Resources.Resources.user_add
        Me.btnPasswortLost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPasswortLost.Location = New System.Drawing.Point(14, 113)
        Me.btnPasswortLost.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPasswortLost.Name = "btnPasswortLost"
        Me.btnPasswortLost.Size = New System.Drawing.Size(346, 27)
        Me.btnPasswortLost.TabIndex = 61
        Me.btnPasswortLost.Text = "&Zugangsdaten zu EiSo vergessen"
        Me.btnPasswortLost.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Geben Sie hier Ihre Emailadresse ein um sich das Passwort zuschicken zu lassen."
        '
        'frmEiSoLoginPasswortvergessen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 159)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPasswortLost)
        Me.Controls.Add(Me.txtEmailadresse)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmEiSoLoginPasswortvergessen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EiSo Passwort vergessen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailadresse As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPasswortLost As Button
    Friend WithEvents Label1 As Label
End Class
