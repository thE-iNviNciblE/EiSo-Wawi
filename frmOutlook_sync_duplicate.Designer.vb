<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutlook_sync_duplicate
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
        Me.txtSuche = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.chkSichtbar = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSuchen = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSuche
        '
        Me.txtSuche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuche.Location = New System.Drawing.Point(16, 37)
        Me.txtSuche.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuche.Name = "txtSuche"
        Me.txtSuche.Size = New System.Drawing.Size(658, 22)
        Me.txtSuche.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(16, 69)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(27, 25)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(935, 543)
        Me.WebBrowser1.TabIndex = 2
        '
        'chkSichtbar
        '
        Me.chkSichtbar.AutoSize = True
        Me.chkSichtbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSichtbar.Location = New System.Drawing.Point(16, 9)
        Me.chkSichtbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSichtbar.Name = "chkSichtbar"
        Me.chkSichtbar.Size = New System.Drawing.Size(78, 21)
        Me.chkSichtbar.TabIndex = 3
        Me.chkSichtbar.Text = "Sichtbar"
        Me.chkSichtbar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 620)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(967, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'btnSuchen
        '
        Me.btnSuchen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSuchen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuchen.ImageIndex = 2
        Me.btnSuchen.Location = New System.Drawing.Point(683, 33)
        Me.btnSuchen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSuchen.Name = "btnSuchen"
        Me.btnSuchen.Size = New System.Drawing.Size(233, 28)
        Me.btnSuchen.TabIndex = 9
        Me.btnSuchen.Text = "Suche starten"
        Me.btnSuchen.UseVisualStyleBackColor = False
        '
        'frmOutlook_sync_duplicate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 642)
        Me.Controls.Add(Me.btnSuchen)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkSichtbar)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.txtSuche)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmOutlook_sync_duplicate"
        Me.Text = "EiSo doppelte Suchen..."
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Public WithEvents txtSuche As System.Windows.Forms.TextBox
    Friend WithEvents chkSichtbar As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSuchen As System.Windows.Forms.Button
End Class
