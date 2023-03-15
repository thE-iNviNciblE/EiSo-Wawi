<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFehlerreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFehlerreport))
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnProgrammreport_email = New System.Windows.Forms.Button()
        Me.btnProgramm_neustarten = New System.Windows.Forms.Button()
        Me.btnWeitermachen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.Location = New System.Drawing.Point(5, 12)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(850, 274)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "Label1"
        '
        'btnProgrammreport_email
        '
        Me.btnProgrammreport_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProgrammreport_email.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnProgrammreport_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProgrammreport_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgrammreport_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgrammreport_email.Image = Global.YabE.My.Resources.Resources.email3
        Me.btnProgrammreport_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammreport_email.Location = New System.Drawing.Point(581, 304)
        Me.btnProgrammreport_email.Name = "btnProgrammreport_email"
        Me.btnProgrammreport_email.Size = New System.Drawing.Size(281, 23)
        Me.btnProgrammreport_email.TabIndex = 49
        Me.btnProgrammreport_email.Text = "&Report an Entwickler"
        Me.btnProgrammreport_email.UseVisualStyleBackColor = False
        '
        'btnProgramm_neustarten
        '
        Me.btnProgramm_neustarten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProgramm_neustarten.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnProgramm_neustarten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProgramm_neustarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgramm_neustarten.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgramm_neustarten.Image = Global.YabE.My.Resources.Resources.abbrechen1
        Me.btnProgramm_neustarten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgramm_neustarten.Location = New System.Drawing.Point(284, 304)
        Me.btnProgramm_neustarten.Name = "btnProgramm_neustarten"
        Me.btnProgramm_neustarten.Size = New System.Drawing.Size(281, 23)
        Me.btnProgramm_neustarten.TabIndex = 50
        Me.btnProgramm_neustarten.Text = "&Programm neustarten"
        Me.btnProgramm_neustarten.UseVisualStyleBackColor = False
        '
        'btnWeitermachen
        '
        Me.btnWeitermachen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWeitermachen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnWeitermachen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnWeitermachen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeitermachen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeitermachen.Image = Global.YabE.My.Resources.Resources._24
        Me.btnWeitermachen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWeitermachen.Location = New System.Drawing.Point(12, 304)
        Me.btnWeitermachen.Name = "btnWeitermachen"
        Me.btnWeitermachen.Size = New System.Drawing.Size(266, 23)
        Me.btnWeitermachen.TabIndex = 51
        Me.btnWeitermachen.Text = "&Weitermachen..."
        Me.btnWeitermachen.UseVisualStyleBackColor = False
        '
        'frmFehlerreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 339)
        Me.Controls.Add(Me.btnWeitermachen)
        Me.Controls.Add(Me.btnProgramm_neustarten)
        Me.Controls.Add(Me.btnProgrammreport_email)
        Me.Controls.Add(Me.lblError)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFehlerreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo Fehlerreport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblError As Label
    Friend WithEvents btnProgrammreport_email As Button
    Friend WithEvents btnProgramm_neustarten As Button
    Friend WithEvents btnWeitermachen As Button
End Class
