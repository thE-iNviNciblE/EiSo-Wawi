<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMS_MagentoExport
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
        Me.txtSichtbarkeit = New System.Windows.Forms.TextBox
        Me.Label161 = New System.Windows.Forms.Label
        Me.txtMenge = New System.Windows.Forms.TextBox
        Me.Label159 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtMagentoStatus = New System.Windows.Forms.Label
        Me.txtMagentoSteuerklasse = New System.Windows.Forms.TextBox
        Me.Label160 = New System.Windows.Forms.Label
        Me.Label158 = New System.Windows.Forms.Label
        Me.txtMagentoStoreview = New System.Windows.Forms.TextBox
        Me.Label157 = New System.Windows.Forms.Label
        Me.Label156 = New System.Windows.Forms.Label
        Me.btnMagentoCSVExport_save = New System.Windows.Forms.Button
        Me.btnAbrechen = New System.Windows.Forms.Button
        Me.txtAttributset = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShopName = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtSichtbarkeit
        '
        Me.txtSichtbarkeit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSichtbarkeit.Location = New System.Drawing.Point(155, 143)
        Me.txtSichtbarkeit.Name = "txtSichtbarkeit"
        Me.txtSichtbarkeit.Size = New System.Drawing.Size(249, 21)
        Me.txtSichtbarkeit.TabIndex = 89
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Location = New System.Drawing.Point(16, 151)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(75, 13)
        Me.Label161.TabIndex = 88
        Me.Label161.Text = "Sichtbarkeit"
        '
        'txtMenge
        '
        Me.txtMenge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMenge.Location = New System.Drawing.Point(155, 170)
        Me.txtMenge.Name = "txtMenge"
        Me.txtMenge.Size = New System.Drawing.Size(89, 21)
        Me.txtMenge.TabIndex = 87
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.Location = New System.Drawing.Point(16, 178)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(44, 13)
        Me.Label159.TabIndex = 86
        Me.Label159.Text = "Menge"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(155, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(249, 21)
        Me.TextBox1.TabIndex = 85
        '
        'txtMagentoStatus
        '
        Me.txtMagentoStatus.AutoSize = True
        Me.txtMagentoStatus.Location = New System.Drawing.Point(16, 124)
        Me.txtMagentoStatus.Name = "txtMagentoStatus"
        Me.txtMagentoStatus.Size = New System.Drawing.Size(43, 13)
        Me.txtMagentoStatus.TabIndex = 84
        Me.txtMagentoStatus.Text = "Status"
        '
        'txtMagentoSteuerklasse
        '
        Me.txtMagentoSteuerklasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoSteuerklasse.Location = New System.Drawing.Point(155, 197)
        Me.txtMagentoSteuerklasse.Name = "txtMagentoSteuerklasse"
        Me.txtMagentoSteuerklasse.Size = New System.Drawing.Size(249, 21)
        Me.txtMagentoSteuerklasse.TabIndex = 83
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Location = New System.Drawing.Point(16, 205)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(81, 13)
        Me.Label160.TabIndex = 82
        Me.Label160.Text = "Steuerklasse"
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Location = New System.Drawing.Point(16, 97)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(101, 13)
        Me.Label158.TabIndex = 81
        Me.Label158.Text = "Storeview Name"
        '
        'txtMagentoStoreview
        '
        Me.txtMagentoStoreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoStoreview.Location = New System.Drawing.Point(155, 89)
        Me.txtMagentoStoreview.Name = "txtMagentoStoreview"
        Me.txtMagentoStoreview.Size = New System.Drawing.Size(249, 21)
        Me.txtMagentoStoreview.TabIndex = 80
        '
        'Label157
        '
        Me.Label157.AutoSize = True
        Me.Label157.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label157.Location = New System.Drawing.Point(11, 45)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(128, 13)
        Me.Label157.TabIndex = 79
        Me.Label157.Text = "CSV Export Optionen"
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label156.Location = New System.Drawing.Point(9, 9)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(198, 25)
        Me.Label156.TabIndex = 78
        Me.Label156.Text = "Magento Export"
        '
        'btnMagentoCSVExport_save
        '
        Me.btnMagentoCSVExport_save.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnMagentoCSVExport_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMagentoCSVExport_save.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagentoCSVExport_save.Image = Global.YabE.My.Resources.Resources._03
        Me.btnMagentoCSVExport_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMagentoCSVExport_save.Location = New System.Drawing.Point(10, 266)
        Me.btnMagentoCSVExport_save.Name = "btnMagentoCSVExport_save"
        Me.btnMagentoCSVExport_save.Size = New System.Drawing.Size(221, 23)
        Me.btnMagentoCSVExport_save.TabIndex = 90
        Me.btnMagentoCSVExport_save.Text = "&Artikel als CSV speichern"
        Me.btnMagentoCSVExport_save.UseVisualStyleBackColor = False
        '
        'btnAbrechen
        '
        Me.btnAbrechen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnAbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrechen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrechen.Image = Global.YabE.My.Resources.Resources.abbrechen
        Me.btnAbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrechen.Location = New System.Drawing.Point(237, 266)
        Me.btnAbrechen.Name = "btnAbrechen"
        Me.btnAbrechen.Size = New System.Drawing.Size(167, 23)
        Me.btnAbrechen.TabIndex = 91
        Me.btnAbrechen.Text = "&Abbrechen"
        Me.btnAbrechen.UseVisualStyleBackColor = False
        '
        'txtAttributset
        '
        Me.txtAttributset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAttributset.Location = New System.Drawing.Point(155, 224)
        Me.txtAttributset.Name = "txtAttributset"
        Me.txtAttributset.Size = New System.Drawing.Size(249, 21)
        Me.txtAttributset.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Attributset"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Shop Name"
        '
        'txtShopName
        '
        Me.txtShopName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShopName.Location = New System.Drawing.Point(155, 62)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(249, 21)
        Me.txtShopName.TabIndex = 94
        '
        'frmCMS_MagentoExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 307)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.txtAttributset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMagentoCSVExport_save)
        Me.Controls.Add(Me.btnAbrechen)
        Me.Controls.Add(Me.txtSichtbarkeit)
        Me.Controls.Add(Me.Label161)
        Me.Controls.Add(Me.txtMenge)
        Me.Controls.Add(Me.Label159)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtMagentoStatus)
        Me.Controls.Add(Me.txtMagentoSteuerklasse)
        Me.Controls.Add(Me.Label160)
        Me.Controls.Add(Me.Label158)
        Me.Controls.Add(Me.txtMagentoStoreview)
        Me.Controls.Add(Me.Label157)
        Me.Controls.Add(Me.Label156)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCMS_MagentoExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Magento CSV Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSichtbarkeit As System.Windows.Forms.TextBox
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents txtMenge As System.Windows.Forms.TextBox
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMagentoStatus As System.Windows.Forms.Label
    Friend WithEvents txtMagentoSteuerklasse As System.Windows.Forms.TextBox
    Friend WithEvents Label160 As System.Windows.Forms.Label
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoStoreview As System.Windows.Forms.TextBox
    Friend WithEvents Label157 As System.Windows.Forms.Label
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents btnMagentoCSVExport_save As System.Windows.Forms.Button
    Friend WithEvents btnAbrechen As System.Windows.Forms.Button
    Friend WithEvents txtAttributset As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShopName As System.Windows.Forms.TextBox
End Class
