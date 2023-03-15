<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMagento_UserEdit
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
        Me.txtAddTelefon = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAddOrt = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtAddPLZ = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtAddStrasse = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtAddNachname = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtAddVorname = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.btnSaveUser = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.txtAddEmail = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblAdressID = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbRegion = New System.Windows.Forms.ComboBox
        Me.cmbLand = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'txtAddTelefon
        '
        Me.txtAddTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddTelefon.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddTelefon.Location = New System.Drawing.Point(124, 219)
        Me.txtAddTelefon.Name = "txtAddTelefon"
        Me.txtAddTelefon.Size = New System.Drawing.Size(126, 21)
        Me.txtAddTelefon.TabIndex = 71
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(33, 222)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 13)
        Me.Label29.TabIndex = 72
        Me.Label29.Text = "Telefon*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(33, 281)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 13)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Region*"
        '
        'txtAddOrt
        '
        Me.txtAddOrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddOrt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddOrt.Location = New System.Drawing.Point(125, 192)
        Me.txtAddOrt.Name = "txtAddOrt"
        Me.txtAddOrt.Size = New System.Drawing.Size(210, 21)
        Me.txtAddOrt.TabIndex = 67
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(34, 195)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 13)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "Ort*"
        '
        'txtAddPLZ
        '
        Me.txtAddPLZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddPLZ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPLZ.Location = New System.Drawing.Point(124, 166)
        Me.txtAddPLZ.Name = "txtAddPLZ"
        Me.txtAddPLZ.Size = New System.Drawing.Size(80, 21)
        Me.txtAddPLZ.TabIndex = 65
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(34, 168)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "PLZ*"
        '
        'txtAddStrasse
        '
        Me.txtAddStrasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddStrasse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddStrasse.Location = New System.Drawing.Point(125, 138)
        Me.txtAddStrasse.Name = "txtAddStrasse"
        Me.txtAddStrasse.Size = New System.Drawing.Size(210, 21)
        Me.txtAddStrasse.TabIndex = 63
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(34, 141)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Strasse*"
        '
        'txtAddNachname
        '
        Me.txtAddNachname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddNachname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddNachname.Location = New System.Drawing.Point(125, 78)
        Me.txtAddNachname.Name = "txtAddNachname"
        Me.txtAddNachname.Size = New System.Drawing.Size(210, 21)
        Me.txtAddNachname.TabIndex = 61
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(34, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Nachname*"
        '
        'txtAddVorname
        '
        Me.txtAddVorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddVorname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddVorname.Location = New System.Drawing.Point(125, 45)
        Me.txtAddVorname.Name = "txtAddVorname"
        Me.txtAddVorname.Size = New System.Drawing.Size(210, 21)
        Me.txtAddVorname.TabIndex = 59
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(34, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Vorname*"
        '
        'btnSaveUser
        '
        Me.btnSaveUser.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUser.Image = Global.YabE.My.Resources.Resources.add_user
        Me.btnSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveUser.Location = New System.Drawing.Point(124, 352)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(255, 28)
        Me.btnSaveUser.TabIndex = 73
        Me.btnSaveUser.Text = "Benutzer speichern"
        Me.btnSaveUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "UserID"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(122, 19)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(15, 13)
        Me.lblUserID.TabIndex = 75
        Me.lblUserID.Text = "0"
        '
        'txtAddEmail
        '
        Me.txtAddEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddEmail.Location = New System.Drawing.Point(124, 108)
        Me.txtAddEmail.Name = "txtAddEmail"
        Me.txtAddEmail.Size = New System.Drawing.Size(210, 21)
        Me.txtAddEmail.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Email*"
        '
        'lblAdressID
        '
        Me.lblAdressID.AutoSize = True
        Me.lblAdressID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdressID.Location = New System.Drawing.Point(265, 19)
        Me.lblAdressID.Name = "lblAdressID"
        Me.lblAdressID.Size = New System.Drawing.Size(15, 13)
        Me.lblAdressID.TabIndex = 78
        Me.lblAdressID.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Land*"
        '
        'cmbRegion
        '
        Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRegion.FormattingEnabled = True
        Me.cmbRegion.Location = New System.Drawing.Point(124, 278)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(210, 21)
        Me.cmbRegion.TabIndex = 80
        '
        'cmbLand
        '
        Me.cmbLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLand.FormattingEnabled = True
        Me.cmbLand.Location = New System.Drawing.Point(124, 246)
        Me.cmbLand.Name = "cmbLand"
        Me.cmbLand.Size = New System.Drawing.Size(210, 21)
        Me.cmbLand.TabIndex = 81
        '
        'frmMagento_UserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 402)
        Me.Controls.Add(Me.cmbLand)
        Me.Controls.Add(Me.cmbRegion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAdressID)
        Me.Controls.Add(Me.txtAddEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveUser)
        Me.Controls.Add(Me.txtAddTelefon)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtAddOrt)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtAddPLZ)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtAddStrasse)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtAddNachname)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtAddVorname)
        Me.Controls.Add(Me.Label19)
        Me.Name = "frmMagento_UserEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Magento Benutzer "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddTelefon As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAddOrt As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAddPLZ As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtAddStrasse As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtAddNachname As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAddVorname As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnSaveUser As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtAddEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAdressID As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbRegion As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLand As System.Windows.Forms.ComboBox
End Class
