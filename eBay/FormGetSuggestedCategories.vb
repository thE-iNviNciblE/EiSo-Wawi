Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FormGetSuggestedCategories
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer


		Friend WithEvents GrpResult As System.Windows.Forms.GroupBox 

		Friend WithEvents LblCategories As System.Windows.Forms.Label 

		Friend WithEvents LstCategories As System.Windows.Forms.ListView 

		Friend WithEvents BtnGetSuggestedCategories As System.Windows.Forms.Button 

		Friend WithEvents ClmCatId As System.Windows.Forms.ColumnHeader 

		Friend WithEvents ClmName As System.Windows.Forms.ColumnHeader 

		Friend WithEvents LblQuery As System.Windows.Forms.Label 

		Friend WithEvents TxtQuery As System.Windows.Forms.TextBox 

		Friend WithEvents ClmPercent As System.Windows.Forms.ColumnHeader 

		<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGetSuggestedCategories))
        Me.BtnGetSuggestedCategories = New System.Windows.Forms.Button
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.LblCategories = New System.Windows.Forms.Label
        Me.LstCategories = New System.Windows.Forms.ListView
        Me.ClmCatId = New System.Windows.Forms.ColumnHeader
        Me.ClmName = New System.Windows.Forms.ColumnHeader
        Me.ClmPercent = New System.Windows.Forms.ColumnHeader
        Me.LblQuery = New System.Windows.Forms.Label
        Me.TxtQuery = New System.Windows.Forms.TextBox
        Me.GrpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGetSuggestedCategories
        '
        Me.BtnGetSuggestedCategories.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetSuggestedCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetSuggestedCategories.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetSuggestedCategories.Location = New System.Drawing.Point(160, 42)
        Me.BtnGetSuggestedCategories.Name = "BtnGetSuggestedCategories"
        Me.BtnGetSuggestedCategories.Size = New System.Drawing.Size(288, 23)
        Me.BtnGetSuggestedCategories.TabIndex = 9
        Me.BtnGetSuggestedCategories.Text = "Empfohlene Kategorien"
        Me.BtnGetSuggestedCategories.UseVisualStyleBackColor = False
        '
        'GrpResult
        '
        Me.GrpResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpResult.AutoSize = True
        Me.GrpResult.Controls.Add(Me.LblCategories)
        Me.GrpResult.Controls.Add(Me.LstCategories)
        Me.GrpResult.Location = New System.Drawing.Point(8, 72)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(504, 347)
        Me.GrpResult.TabIndex = 10
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'LblCategories
        '
        Me.LblCategories.Location = New System.Drawing.Point(16, 24)
        Me.LblCategories.Name = "LblCategories"
        Me.LblCategories.Size = New System.Drawing.Size(475, 23)
        Me.LblCategories.TabIndex = 12
        Me.LblCategories.Text = "Empfohlende Kategorien:"
        '
        'LstCategories
        '
        Me.LstCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstCategories.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmCatId, Me.ClmName, Me.ClmPercent})
        Me.LstCategories.FullRowSelect = True
        Me.LstCategories.GridLines = True
        Me.LstCategories.Location = New System.Drawing.Point(16, 48)
        Me.LstCategories.Name = "LstCategories"
        Me.LstCategories.Size = New System.Drawing.Size(480, 280)
        Me.LstCategories.TabIndex = 13
        Me.LstCategories.UseCompatibleStateImageBehavior = False
        Me.LstCategories.View = System.Windows.Forms.View.Details
        '
        'ClmCatId
        '
        Me.ClmCatId.Text = "KategorieID"
        Me.ClmCatId.Width = 70
        '
        'ClmName
        '
        Me.ClmName.Text = "Kategoriename"
        Me.ClmName.Width = 297
        '
        'ClmPercent
        '
        Me.ClmPercent.Text = "Gefunden (%)"
        Me.ClmPercent.Width = 89
        '
        'LblQuery
        '
        Me.LblQuery.Location = New System.Drawing.Point(64, 16)
        Me.LblQuery.Name = "LblQuery"
        Me.LblQuery.Size = New System.Drawing.Size(96, 23)
        Me.LblQuery.TabIndex = 13
        Me.LblQuery.Text = "Abfrage:"
        '
        'TxtQuery
        '
        Me.TxtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuery.Location = New System.Drawing.Point(160, 16)
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.Size = New System.Drawing.Size(288, 20)
        Me.TxtQuery.TabIndex = 14
        '
        'FormGetSuggestedCategories
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 413)
        Me.Controls.Add(Me.TxtQuery)
        Me.Controls.Add(Me.LblQuery)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnGetSuggestedCategories)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGetSuggestedCategories"
        Me.ShowInTaskbar = False
        Me.Text = "YabE - empfohlene Kategorien"
        Me.GrpResult.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext


		Private Sub  BtnGetSuggestedCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetSuggestedCategories.Click

			Try

            BtnGetSuggestedCategories.Enabled = True

				LstCategories.Items.Clear()
            Context = clseBayAPI.setAPIContext()
				Dim apicall As GetSuggestedCategoriesCall = new GetSuggestedCategoriesCall(Context)

            Dim cats As SuggestedCategoryTypeCollection = apicall.GetSuggestedCategories(TxtQuery.Text)

            If Not (cats Is Nothing) Then

                Dim category As SuggestedCategoryType
                For Each category In cats

                    Dim listparams(3) As String

                    listparams(0) = category.Category.CategoryID
                    listparams(1) = String.Join(" : ", category.Category.CategoryParentName.ToArray()) + " : " + category.Category.CategoryName
                    listparams(2) = category.PercentItemFound.ToString()

                    Dim vi As ListViewItem = New ListViewItem(listparams)
                    Me.LstCategories.Items.Add(vi)

                Next category
            End If

            BtnGetSuggestedCategories.Enabled = True
        Catch ex As Exception
            ' Call debug_message(ex,strQuery & vbcrlf & "btnGetSuggested Categories")
            BtnGetSuggestedCategories.Enabled = True
        End Try

    End Sub

    Private Sub TxtQuery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuery.KeyDown

        If e.KeyCode = Keys.Enter Then
            BtnGetSuggestedCategories.PerformClick()
        End If

    End Sub
 
 
End Class

