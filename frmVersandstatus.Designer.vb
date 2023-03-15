<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVersandstatus
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
        Me.btnVersandstatusAbschicken = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbSprache_Versandstatus = New System.Windows.Forms.ComboBox
        Me.txtAnschrift = New System.Windows.Forms.TextBox
        Me.txtLand = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnVersandstatusAbschicken
        '
        Me.btnVersandstatusAbschicken.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVersandstatusAbschicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVersandstatusAbschicken.Image = Global.YabE.My.Resources.Resources.adressbuch
        Me.btnVersandstatusAbschicken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVersandstatusAbschicken.Location = New System.Drawing.Point(12, 136)
        Me.btnVersandstatusAbschicken.Name = "btnVersandstatusAbschicken"
        Me.btnVersandstatusAbschicken.Size = New System.Drawing.Size(347, 25)
        Me.btnVersandstatusAbschicken.TabIndex = 12
        Me.btnVersandstatusAbschicken.Text = "&Versandstatus abschicken"
        Me.btnVersandstatusAbschicken.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(219, 17)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Sprache auwählen"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSprache_Versandstatus
        '
        Me.cmbSprache_Versandstatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSprache_Versandstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprache_Versandstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprache_Versandstatus.FormattingEnabled = True
        Me.cmbSprache_Versandstatus.Location = New System.Drawing.Point(10, 97)
        Me.cmbSprache_Versandstatus.Name = "cmbSprache_Versandstatus"
        Me.cmbSprache_Versandstatus.Size = New System.Drawing.Size(219, 21)
        Me.cmbSprache_Versandstatus.TabIndex = 42
        '
        'txtAnschrift
        '
        Me.txtAnschrift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnschrift.Location = New System.Drawing.Point(10, 12)
        Me.txtAnschrift.Name = "txtAnschrift"
        Me.txtAnschrift.Size = New System.Drawing.Size(333, 20)
        Me.txtAnschrift.TabIndex = 55
        '
        'txtLand
        '
        Me.txtLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLand.Location = New System.Drawing.Point(10, 38)
        Me.txtLand.Name = "txtLand"
        Me.txtLand.Size = New System.Drawing.Size(219, 20)
        Me.txtLand.TabIndex = 56
        '
        'frmVersandstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 173)
        Me.Controls.Add(Me.txtLand)
        Me.Controls.Add(Me.txtAnschrift)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmbSprache_Versandstatus)
        Me.Controls.Add(Me.btnVersandstatusAbschicken)
        Me.Name = "frmVersandstatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Versandstatus Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVersandstatusAbschicken As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAnschrift As System.Windows.Forms.TextBox
    Friend WithEvents txtLand As System.Windows.Forms.TextBox
    Public WithEvents cmbSprache_Versandstatus As System.Windows.Forms.ComboBox
End Class
