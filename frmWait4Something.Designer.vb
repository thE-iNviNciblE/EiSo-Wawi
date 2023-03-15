<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWait4Something
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
        Me.components = New System.ComponentModel.Container()
        Me.pgrWait4Something = New System.Windows.Forms.ProgressBar()
        Me.tmrCheckStatus = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblBitteWarten = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pgrWait4Something
        '
        Me.pgrWait4Something.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgrWait4Something.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgrWait4Something.ForeColor = System.Drawing.Color.Khaki
        Me.pgrWait4Something.Location = New System.Drawing.Point(14, 34)
        Me.pgrWait4Something.MarqueeAnimationSpeed = 1
        Me.pgrWait4Something.Name = "pgrWait4Something"
        Me.pgrWait4Something.Size = New System.Drawing.Size(323, 19)
        Me.pgrWait4Something.Step = 5
        Me.pgrWait4Something.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgrWait4Something.TabIndex = 1
        Me.pgrWait4Something.UseWaitCursor = True
        '
        'tmrCheckStatus
        '
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(14, 70)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(59, 17)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Label1"
        Me.lblMessage.UseWaitCursor = True
        '
        'lblBitteWarten
        '
        Me.lblBitteWarten.AutoSize = True
        Me.lblBitteWarten.Location = New System.Drawing.Point(14, 9)
        Me.lblBitteWarten.Name = "lblBitteWarten"
        Me.lblBitteWarten.Size = New System.Drawing.Size(257, 17)
        Me.lblBitteWarten.TabIndex = 3
        Me.lblBitteWarten.Text = "Anmelden bei eBay...Bitte warten..."
        Me.lblBitteWarten.Visible = False
        '
        'frmWait4Something
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(355, 112)
        Me.Controls.Add(Me.lblBitteWarten)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.pgrWait4Something)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWait4Something"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EiSo Wartepause..."
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgrWait4Something As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrCheckStatus As System.Windows.Forms.Timer
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblBitteWarten As System.Windows.Forms.Label

End Class
