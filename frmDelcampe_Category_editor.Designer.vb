<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelcampe_Category_editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelcampe_Category_editor))
        Me.lstDelcampeXML_main = New System.Windows.Forms.ComboBox
        Me.lvwMain = New System.Windows.Forms.ListView
        Me.colCategoryID = New System.Windows.Forms.ColumnHeader
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.colParent = New System.Windows.Forms.ColumnHeader
        Me.lvwMain_2 = New System.Windows.Forms.ListView
        Me.colKategorie_2 = New System.Windows.Forms.ColumnHeader
        Me.colName_2 = New System.Windows.Forms.ColumnHeader
        Me.colParent_2 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvwMain_3 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.lvwMain_4 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.lvwMain_5 = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.lvwMain_6 = New System.Windows.Forms.ListView
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.lblBereich = New System.Windows.Forms.Label
        Me.txtSearchID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSuchen = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstDelcampeXML_main
        '
        Me.lstDelcampeXML_main.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstDelcampeXML_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lstDelcampeXML_main.FormattingEnabled = True
        Me.lstDelcampeXML_main.Location = New System.Drawing.Point(12, 43)
        Me.lstDelcampeXML_main.Name = "lstDelcampeXML_main"
        Me.lstDelcampeXML_main.Size = New System.Drawing.Size(287, 21)
        Me.lstDelcampeXML_main.TabIndex = 2
        '
        'lvwMain
        '
        Me.lvwMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCategoryID, Me.colName, Me.colParent})
        Me.lvwMain.FullRowSelect = True
        Me.lvwMain.GridLines = True
        Me.lvwMain.HideSelection = False
        Me.lvwMain.Location = New System.Drawing.Point(12, 96)
        Me.lvwMain.Name = "lvwMain"
        Me.lvwMain.ShowItemToolTips = True
        Me.lvwMain.Size = New System.Drawing.Size(253, 198)
        Me.lvwMain.TabIndex = 3
        Me.lvwMain.UseCompatibleStateImageBehavior = False
        Me.lvwMain.View = System.Windows.Forms.View.Details
        '
        'colCategoryID
        '
        Me.colCategoryID.DisplayIndex = 1
        Me.colCategoryID.Text = "ID"
        Me.colCategoryID.Width = 54
        '
        'colName
        '
        Me.colName.DisplayIndex = 0
        Me.colName.Text = "Name"
        Me.colName.Width = 186
        '
        'colParent
        '
        Me.colParent.Text = "ParentID"
        Me.colParent.Width = 0
        '
        'lvwMain_2
        '
        Me.lvwMain_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMain_2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKategorie_2, Me.colName_2, Me.colParent_2})
        Me.lvwMain_2.FullRowSelect = True
        Me.lvwMain_2.GridLines = True
        Me.lvwMain_2.HideSelection = False
        Me.lvwMain_2.Location = New System.Drawing.Point(271, 96)
        Me.lvwMain_2.Name = "lvwMain_2"
        Me.lvwMain_2.ShowItemToolTips = True
        Me.lvwMain_2.Size = New System.Drawing.Size(253, 198)
        Me.lvwMain_2.TabIndex = 4
        Me.lvwMain_2.UseCompatibleStateImageBehavior = False
        Me.lvwMain_2.View = System.Windows.Forms.View.Details
        Me.lvwMain_2.Visible = False
        '
        'colKategorie_2
        '
        Me.colKategorie_2.DisplayIndex = 1
        Me.colKategorie_2.Text = "ID"
        Me.colKategorie_2.Width = 54
        '
        'colName_2
        '
        Me.colName_2.DisplayIndex = 0
        Me.colName_2.Text = "Name"
        Me.colName_2.Width = 180
        '
        'colParent_2
        '
        Me.colParent_2.Text = "Partent"
        Me.colParent_2.Width = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Delcampe Kategorieverwaltung"
        '
        'lvwMain_3
        '
        Me.lvwMain_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMain_3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwMain_3.FullRowSelect = True
        Me.lvwMain_3.GridLines = True
        Me.lvwMain_3.HideSelection = False
        Me.lvwMain_3.Location = New System.Drawing.Point(530, 96)
        Me.lvwMain_3.Name = "lvwMain_3"
        Me.lvwMain_3.ShowItemToolTips = True
        Me.lvwMain_3.Size = New System.Drawing.Size(253, 198)
        Me.lvwMain_3.TabIndex = 6
        Me.lvwMain_3.UseCompatibleStateImageBehavior = False
        Me.lvwMain_3.View = System.Windows.Forms.View.Details
        Me.lvwMain_3.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 0
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 186
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Partent"
        Me.ColumnHeader3.Width = 0
        '
        'lvwMain_4
        '
        Me.lvwMain_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMain_4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwMain_4.FullRowSelect = True
        Me.lvwMain_4.GridLines = True
        Me.lvwMain_4.HideSelection = False
        Me.lvwMain_4.Location = New System.Drawing.Point(12, 300)
        Me.lvwMain_4.Name = "lvwMain_4"
        Me.lvwMain_4.ShowItemToolTips = True
        Me.lvwMain_4.Size = New System.Drawing.Size(253, 198)
        Me.lvwMain_4.TabIndex = 7
        Me.lvwMain_4.UseCompatibleStateImageBehavior = False
        Me.lvwMain_4.View = System.Windows.Forms.View.Details
        Me.lvwMain_4.Visible = False
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 1
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.Width = 54
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 0
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 189
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Partent"
        Me.ColumnHeader6.Width = 0
        '
        'lvwMain_5
        '
        Me.lvwMain_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMain_5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvwMain_5.FullRowSelect = True
        Me.lvwMain_5.GridLines = True
        Me.lvwMain_5.HideSelection = False
        Me.lvwMain_5.Location = New System.Drawing.Point(271, 300)
        Me.lvwMain_5.Name = "lvwMain_5"
        Me.lvwMain_5.ShowItemToolTips = True
        Me.lvwMain_5.Size = New System.Drawing.Size(253, 198)
        Me.lvwMain_5.TabIndex = 8
        Me.lvwMain_5.UseCompatibleStateImageBehavior = False
        Me.lvwMain_5.View = System.Windows.Forms.View.Details
        Me.lvwMain_5.Visible = False
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 1
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 54
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 0
        Me.ColumnHeader8.Text = "Name"
        Me.ColumnHeader8.Width = 189
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Partent"
        Me.ColumnHeader9.Width = 0
        '
        'lvwMain_6
        '
        Me.lvwMain_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwMain_6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvwMain_6.FullRowSelect = True
        Me.lvwMain_6.GridLines = True
        Me.lvwMain_6.HideSelection = False
        Me.lvwMain_6.Location = New System.Drawing.Point(530, 300)
        Me.lvwMain_6.Name = "lvwMain_6"
        Me.lvwMain_6.ShowItemToolTips = True
        Me.lvwMain_6.Size = New System.Drawing.Size(253, 198)
        Me.lvwMain_6.TabIndex = 9
        Me.lvwMain_6.UseCompatibleStateImageBehavior = False
        Me.lvwMain_6.View = System.Windows.Forms.View.Details
        Me.lvwMain_6.Visible = False
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.DisplayIndex = 1
        Me.ColumnHeader10.Text = "ID"
        Me.ColumnHeader10.Width = 54
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.DisplayIndex = 0
        Me.ColumnHeader11.Text = "Name"
        Me.ColumnHeader11.Width = 189
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Partent"
        Me.ColumnHeader12.Width = 0
        '
        'lblBereich
        '
        Me.lblBereich.AutoSize = True
        Me.lblBereich.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBereich.Location = New System.Drawing.Point(14, 74)
        Me.lblBereich.Name = "lblBereich"
        Me.lblBereich.Size = New System.Drawing.Size(0, 18)
        Me.lblBereich.TabIndex = 10
        '
        'txtSearchID
        '
        Me.txtSearchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchID.Location = New System.Drawing.Point(439, 44)
        Me.txtSearchID.Name = "txtSearchID"
        Me.txtSearchID.Size = New System.Drawing.Size(130, 21)
        Me.txtSearchID.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Kategorie ID"
        '
        'btnSuchen
        '
        Me.btnSuchen.BackColor = System.Drawing.Color.Bisque
        Me.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuchen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuchen.Image = Global.YabE.My.Resources.Resources.search2
        Me.btnSuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuchen.Location = New System.Drawing.Point(575, 43)
        Me.btnSuchen.Name = "btnSuchen"
        Me.btnSuchen.Size = New System.Drawing.Size(145, 23)
        Me.btnSuchen.TabIndex = 13
        Me.btnSuchen.Text = "&Suchen"
        Me.btnSuchen.UseVisualStyleBackColor = False
        '
        'frmDelcampe_Category_editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 511)
        Me.Controls.Add(Me.btnSuchen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchID)
        Me.Controls.Add(Me.lblBereich)
        Me.Controls.Add(Me.lvwMain_6)
        Me.Controls.Add(Me.lvwMain_5)
        Me.Controls.Add(Me.lvwMain_4)
        Me.Controls.Add(Me.lvwMain_3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwMain_2)
        Me.Controls.Add(Me.lvwMain)
        Me.Controls.Add(Me.lstDelcampeXML_main)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDelcampe_Category_editor"
        Me.Text = "Delcampe Lister - Kategorieauswahl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstDelcampeXML_main As System.Windows.Forms.ComboBox
    Friend WithEvents lvwMain As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCategoryID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMain_2 As System.Windows.Forms.ListView
    Friend WithEvents colName_2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents colKategorie_2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colParent As System.Windows.Forms.ColumnHeader
    Friend WithEvents colParent_2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMain_3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMain_4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMain_5 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMain_6 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblBereich As System.Windows.Forms.Label
    Friend WithEvents txtSearchID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSuchen As System.Windows.Forms.Button

End Class
