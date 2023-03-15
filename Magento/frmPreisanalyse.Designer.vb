<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreisanalyse
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
        Me.txtMagentoTitel = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMagentoPreis = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbVergleich = New System.Windows.Forms.TabPage
        Me.tbWeb = New System.Windows.Forms.TabPage
        Me.yabe_dashboard_header = New System.Windows.Forms.Label
        Me.cmbPreisanbieter = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lvwPreisData = New System.Windows.Forms.ListView
        Me.chBeschreibung = New System.Windows.Forms.ColumnHeader
        Me.chPreis = New System.Windows.Forms.ColumnHeader
        Me.chVersandkosten = New System.Windows.Forms.ColumnHeader
        Me.btnStartPreisvergleich = New System.Windows.Forms.Button
        Me.wbVergleich = New System.Windows.Forms.WebBrowser
        Me.TabControl1.SuspendLayout()
        Me.tbVergleich.SuspendLayout()
        Me.tbWeb.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMagentoTitel
        '
        Me.txtMagentoTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoTitel.Location = New System.Drawing.Point(14, 55)
        Me.txtMagentoTitel.Name = "txtMagentoTitel"
        Me.txtMagentoTitel.Size = New System.Drawing.Size(521, 20)
        Me.txtMagentoTitel.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 14)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Magento Titel"
        '
        'txtMagentoPreis
        '
        Me.txtMagentoPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMagentoPreis.Location = New System.Drawing.Point(557, 55)
        Me.txtMagentoPreis.Name = "txtMagentoPreis"
        Me.txtMagentoPreis.Size = New System.Drawing.Size(84, 20)
        Me.txtMagentoPreis.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(554, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Magento Preis"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbVergleich)
        Me.TabControl1.Controls.Add(Me.tbWeb)
        Me.TabControl1.Location = New System.Drawing.Point(12, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(923, 514)
        Me.TabControl1.TabIndex = 45
        '
        'tbVergleich
        '
        Me.tbVergleich.Controls.Add(Me.btnStartPreisvergleich)
        Me.tbVergleich.Controls.Add(Me.lvwPreisData)
        Me.tbVergleich.Controls.Add(Me.Label3)
        Me.tbVergleich.Controls.Add(Me.cmbPreisanbieter)
        Me.tbVergleich.Location = New System.Drawing.Point(4, 23)
        Me.tbVergleich.Name = "tbVergleich"
        Me.tbVergleich.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVergleich.Size = New System.Drawing.Size(915, 487)
        Me.tbVergleich.TabIndex = 0
        Me.tbVergleich.Text = "Preisvergleich"
        Me.tbVergleich.UseVisualStyleBackColor = True
        '
        'tbWeb
        '
        Me.tbWeb.Controls.Add(Me.wbVergleich)
        Me.tbWeb.Location = New System.Drawing.Point(4, 23)
        Me.tbWeb.Name = "tbWeb"
        Me.tbWeb.Padding = New System.Windows.Forms.Padding(3)
        Me.tbWeb.Size = New System.Drawing.Size(915, 487)
        Me.tbWeb.TabIndex = 1
        Me.tbWeb.Text = "Webansicht"
        Me.tbWeb.UseVisualStyleBackColor = True
        '
        'yabe_dashboard_header
        '
        Me.yabe_dashboard_header.AutoSize = True
        Me.yabe_dashboard_header.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yabe_dashboard_header.Location = New System.Drawing.Point(12, 10)
        Me.yabe_dashboard_header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.yabe_dashboard_header.Name = "yabe_dashboard_header"
        Me.yabe_dashboard_header.Size = New System.Drawing.Size(147, 23)
        Me.yabe_dashboard_header.TabIndex = 46
        Me.yabe_dashboard_header.Text = "Preisanalyse"
        '
        'cmbPreisanbieter
        '
        Me.cmbPreisanbieter.FormattingEnabled = True
        Me.cmbPreisanbieter.Items.AddRange(New Object() {"Idealo"})
        Me.cmbPreisanbieter.Location = New System.Drawing.Point(20, 43)
        Me.cmbPreisanbieter.Name = "cmbPreisanbieter"
        Me.cmbPreisanbieter.Size = New System.Drawing.Size(194, 22)
        Me.cmbPreisanbieter.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Anbieter"
        '
        'lvwPreisData
        '
        Me.lvwPreisData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chBeschreibung, Me.chPreis, Me.chVersandkosten})
        Me.lvwPreisData.Location = New System.Drawing.Point(20, 84)
        Me.lvwPreisData.Name = "lvwPreisData"
        Me.lvwPreisData.Size = New System.Drawing.Size(874, 246)
        Me.lvwPreisData.TabIndex = 2
        Me.lvwPreisData.UseCompatibleStateImageBehavior = False
        Me.lvwPreisData.View = System.Windows.Forms.View.Details
        '
        'chBeschreibung
        '
        Me.chBeschreibung.Text = "Beschreibung"
        Me.chBeschreibung.Width = 404
        '
        'chPreis
        '
        Me.chPreis.Text = "Preis"
        Me.chPreis.Width = 111
        '
        'chVersandkosten
        '
        Me.chVersandkosten.Text = "Versandkosten"
        Me.chVersandkosten.Width = 165
        '
        'btnStartPreisvergleich
        '
        Me.btnStartPreisvergleich.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartPreisvergleich.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartPreisvergleich.Image = Global.YabE.My.Resources.Resources._24
        Me.btnStartPreisvergleich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartPreisvergleich.Location = New System.Drawing.Point(233, 42)
        Me.btnStartPreisvergleich.Name = "btnStartPreisvergleich"
        Me.btnStartPreisvergleich.Size = New System.Drawing.Size(149, 23)
        Me.btnStartPreisvergleich.TabIndex = 3
        Me.btnStartPreisvergleich.Text = "Preisvergleich"
        Me.btnStartPreisvergleich.UseVisualStyleBackColor = True
        '
        'wbVergleich
        '
        Me.wbVergleich.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbVergleich.Location = New System.Drawing.Point(3, 3)
        Me.wbVergleich.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbVergleich.Name = "wbVergleich"
        Me.wbVergleich.Size = New System.Drawing.Size(909, 481)
        Me.wbVergleich.TabIndex = 0
        '
        'frmPreisanalyse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 610)
        Me.Controls.Add(Me.yabe_dashboard_header)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtMagentoPreis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMagentoTitel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPreisanalyse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preissuchmaschinen - Preisanalyse"
        Me.TabControl1.ResumeLayout(False)
        Me.tbVergleich.ResumeLayout(False)
        Me.tbVergleich.PerformLayout()
        Me.tbWeb.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMagentoTitel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMagentoPreis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbVergleich As System.Windows.Forms.TabPage
    Friend WithEvents tbWeb As System.Windows.Forms.TabPage
    Friend WithEvents yabe_dashboard_header As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPreisanbieter As System.Windows.Forms.ComboBox
    Friend WithEvents lvwPreisData As System.Windows.Forms.ListView
    Friend WithEvents chBeschreibung As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPreis As System.Windows.Forms.ColumnHeader
    Friend WithEvents chVersandkosten As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnStartPreisvergleich As System.Windows.Forms.Button
    Friend WithEvents wbVergleich As System.Windows.Forms.WebBrowser
End Class
