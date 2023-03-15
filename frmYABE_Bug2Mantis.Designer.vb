<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYABE_Bug2Mantis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYABE_Bug2Mantis))
        Me.txtTitel = New System.Windows.Forms.TextBox()
        Me.txtBeschreibung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.categoryComboBox = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.versionComboBox = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.projectComboBox = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.reproducibilityComboBox = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.severityComboBox = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.priorityComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTitel
        '
        Me.txtTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitel.Location = New System.Drawing.Point(12, 32)
        Me.txtTitel.Name = "txtTitel"
        Me.txtTitel.Size = New System.Drawing.Size(607, 24)
        Me.txtTitel.TabIndex = 0
        '
        'txtBeschreibung
        '
        Me.txtBeschreibung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBeschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBeschreibung.Location = New System.Drawing.Point(14, 266)
        Me.txtBeschreibung.Multiline = True
        Me.txtBeschreibung.Name = "txtBeschreibung"
        Me.txtBeschreibung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBeschreibung.Size = New System.Drawing.Size(920, 373)
        Me.txtBeschreibung.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titel des Problems"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Beschreibung des Problems"
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Image = Global.YabE.My.Resources.Resources._24
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.Location = New System.Drawing.Point(14, 645)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(239, 23)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "&Fehlerbericht übertragen"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'categoryComboBox
        '
        Me.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.categoryComboBox.Location = New System.Drawing.Point(140, 123)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(176, 25)
        Me.categoryComboBox.TabIndex = 22
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(12, 123)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(100, 21)
        Me.label9.TabIndex = 30
        Me.label9.Text = "Kategorie"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'versionComboBox
        '
        Me.versionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.versionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versionComboBox.Location = New System.Drawing.Point(140, 91)
        Me.versionComboBox.Name = "versionComboBox"
        Me.versionComboBox.Size = New System.Drawing.Size(176, 25)
        Me.versionComboBox.TabIndex = 20
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(12, 91)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(100, 21)
        Me.label8.TabIndex = 29
        Me.label8.Text = "Version"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'projectComboBox
        '
        Me.projectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.projectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.projectComboBox.Location = New System.Drawing.Point(140, 59)
        Me.projectComboBox.Name = "projectComboBox"
        Me.projectComboBox.Size = New System.Drawing.Size(176, 25)
        Me.projectComboBox.TabIndex = 19
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(12, 59)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 21)
        Me.label6.TabIndex = 28
        Me.label6.Text = "Projekt"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reproducibilityComboBox
        '
        Me.reproducibilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.reproducibilityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reproducibilityComboBox.Location = New System.Drawing.Point(140, 219)
        Me.reproducibilityComboBox.Name = "reproducibilityComboBox"
        Me.reproducibilityComboBox.Size = New System.Drawing.Size(176, 25)
        Me.reproducibilityComboBox.TabIndex = 26
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(12, 219)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 21)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Reproduzierbar"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'severityComboBox
        '
        Me.severityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.severityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.severityComboBox.Location = New System.Drawing.Point(140, 187)
        Me.severityComboBox.Name = "severityComboBox"
        Me.severityComboBox.Size = New System.Drawing.Size(176, 25)
        Me.severityComboBox.TabIndex = 25
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(12, 187)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 21)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Dringlichkeit"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'priorityComboBox
        '
        Me.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.priorityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.priorityComboBox.Location = New System.Drawing.Point(140, 155)
        Me.priorityComboBox.Name = "priorityComboBox"
        Me.priorityComboBox.Size = New System.Drawing.Size(176, 25)
        Me.priorityComboBox.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Priorität"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmYABE_Bug2Mantis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(969, 675)
        Me.Controls.Add(Me.categoryComboBox)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.versionComboBox)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.projectComboBox)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.reproducibilityComboBox)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.severityComboBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.priorityComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBeschreibung)
        Me.Controls.Add(Me.txtTitel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmYABE_Bug2Mantis"
        Me.Text = "EiSo - Mantis Bugreport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitel As System.Windows.Forms.TextBox
    Friend WithEvents txtBeschreibung As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Private WithEvents categoryComboBox As System.Windows.Forms.ComboBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents versionComboBox As System.Windows.Forms.ComboBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents projectComboBox As System.Windows.Forms.ComboBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents reproducibilityComboBox As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents severityComboBox As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents priorityComboBox As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
End Class
