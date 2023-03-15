Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FormGetUserDisputes
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

		Friend WithEvents BtnGetUserDisputes As System.Windows.Forms.Button 

		Friend WithEvents CboSort As System.Windows.Forms.ComboBox 

		Friend WithEvents LblSort As System.Windows.Forms.Label

		Friend WithEvents CboFilter As System.Windows.Forms.ComboBox

		Friend WithEvents LblFilter As System.Windows.Forms.Label 



    Friend WithEvents LstDisputes As System.Windows.Forms.ListView

    Friend WithEvents ClmDisputeId As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmItemId As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmTransactionId As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmState As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmStatus As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmUserId As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmOtherPartyName As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmRole As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmDisputeReason As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmDisputeExplanation As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmDisputeModifiedTime As System.Windows.Forms.ColumnHeader





    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGetUserDisputes))
        Me.BtnGetUserDisputes = New System.Windows.Forms.Button
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.LstDisputes = New System.Windows.Forms.ListView
        Me.ClmDisputeId = New System.Windows.Forms.ColumnHeader
        Me.ClmItemId = New System.Windows.Forms.ColumnHeader
        Me.ClmTransactionId = New System.Windows.Forms.ColumnHeader
        Me.ClmState = New System.Windows.Forms.ColumnHeader
        Me.ClmStatus = New System.Windows.Forms.ColumnHeader
        Me.ClmOtherPartyName = New System.Windows.Forms.ColumnHeader
        Me.ClmRole = New System.Windows.Forms.ColumnHeader
        Me.ClmDisputeReason = New System.Windows.Forms.ColumnHeader
        Me.ClmDisputeExplanation = New System.Windows.Forms.ColumnHeader
        Me.ClmDisputeModifiedTime = New System.Windows.Forms.ColumnHeader
        Me.CboSort = New System.Windows.Forms.ComboBox
        Me.LblSort = New System.Windows.Forms.Label
        Me.CboFilter = New System.Windows.Forms.ComboBox
        Me.LblFilter = New System.Windows.Forms.Label
        Me.ClmUserId = New System.Windows.Forms.ColumnHeader
        Me.GrpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGetUserDisputes
        '
        Me.BtnGetUserDisputes.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetUserDisputes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetUserDisputes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetUserDisputes.Image = Global.YabE.My.Resources.Resources._24
        Me.BtnGetUserDisputes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetUserDisputes.Location = New System.Drawing.Point(93, 68)
        Me.BtnGetUserDisputes.Name = "BtnGetUserDisputes"
        Me.BtnGetUserDisputes.Size = New System.Drawing.Size(171, 23)
        Me.BtnGetUserDisputes.TabIndex = 9
        Me.BtnGetUserDisputes.Text = "Einsprüche abrufen"
        Me.BtnGetUserDisputes.UseVisualStyleBackColor = False
        '
        'GrpResult
        '
        Me.GrpResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpResult.Controls.Add(Me.LstDisputes)
        Me.GrpResult.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpResult.Location = New System.Drawing.Point(8, 104)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(876, 316)
        Me.GrpResult.TabIndex = 10
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'LstDisputes
        '
        Me.LstDisputes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstDisputes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmDisputeId, Me.ClmItemId, Me.ClmTransactionId, Me.ClmState, Me.ClmStatus, Me.ClmOtherPartyName, Me.ClmRole, Me.ClmDisputeReason, Me.ClmDisputeExplanation, Me.ClmDisputeModifiedTime})
        Me.LstDisputes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstDisputes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstDisputes.FullRowSelect = True
        Me.LstDisputes.GridLines = True
        Me.LstDisputes.Location = New System.Drawing.Point(3, 16)
        Me.LstDisputes.Name = "LstDisputes"
        Me.LstDisputes.Size = New System.Drawing.Size(870, 297)
        Me.LstDisputes.TabIndex = 13
        Me.LstDisputes.UseCompatibleStateImageBehavior = False
        Me.LstDisputes.View = System.Windows.Forms.View.Details
        '
        'ClmDisputeId
        '
        Me.ClmDisputeId.Text = "Dispute Id"
        Me.ClmDisputeId.Width = 0
        '
        'ClmItemId
        '
        Me.ClmItemId.Text = "ArtikelID"
        Me.ClmItemId.Width = 83
        '
        'ClmTransactionId
        '
        Me.ClmTransactionId.Text = "Transaction Id"
        Me.ClmTransactionId.Width = 109
        '
        'ClmState
        '
        Me.ClmState.Text = "State"
        Me.ClmState.Width = 108
        '
        'ClmStatus
        '
        Me.ClmStatus.Text = "Status"
        Me.ClmStatus.Width = 104
        '
        'ClmOtherPartyName
        '
        Me.ClmOtherPartyName.Text = "OtherPartyName"
        Me.ClmOtherPartyName.Width = 90
        '
        'ClmRole
        '
        Me.ClmRole.Text = "My Role"
        Me.ClmRole.Width = 55
        '
        'ClmDisputeReason
        '
        Me.ClmDisputeReason.Text = "DisputeReason"
        Me.ClmDisputeReason.Width = 90
        '
        'ClmDisputeExplanation
        '
        Me.ClmDisputeExplanation.Text = "DisputeExplanation"
        Me.ClmDisputeExplanation.Width = 112
        '
        'ClmDisputeModifiedTime
        '
        Me.ClmDisputeModifiedTime.Text = "DisputeModifiedTime"
        Me.ClmDisputeModifiedTime.Width = 114
        '
        'CboSort
        '
        Me.CboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboSort.Location = New System.Drawing.Point(93, 5)
        Me.CboSort.Name = "CboSort"
        Me.CboSort.Size = New System.Drawing.Size(339, 21)
        Me.CboSort.TabIndex = 57
        '
        'LblSort
        '
        Me.LblSort.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSort.Location = New System.Drawing.Point(21, 9)
        Me.LblSort.Name = "LblSort"
        Me.LblSort.Size = New System.Drawing.Size(80, 18)
        Me.LblSort.TabIndex = 56
        Me.LblSort.Text = "Sortierung"
        '
        'CboFilter
        '
        Me.CboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboFilter.Location = New System.Drawing.Point(93, 40)
        Me.CboFilter.Name = "CboFilter"
        Me.CboFilter.Size = New System.Drawing.Size(339, 21)
        Me.CboFilter.TabIndex = 59
        '
        'LblFilter
        '
        Me.LblFilter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFilter.Location = New System.Drawing.Point(21, 40)
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(80, 18)
        Me.LblFilter.TabIndex = 58
        Me.LblFilter.Text = "Gründe:"
        '
        'FormGetUserDisputes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(892, 425)
        Me.Controls.Add(Me.CboFilter)
        Me.Controls.Add(Me.LblFilter)
        Me.Controls.Add(Me.CboSort)
        Me.Controls.Add(Me.LblSort)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnGetUserDisputes)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGetUserDisputes"
        Me.Text = "YabE - Mahnungen"
        Me.GrpResult.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Context As ApiContext


    Private Sub FrmGetUserDisputes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim sorts() As String = [Enum].GetNames(GetType(DisputeSortTypeCodeType))
        Dim srt As String

        For Each srt In sorts

            If srt <> "CustomCode" Then

                CboSort.Items.Add(srt)
            End If
        Next srt


        CboSort.SelectedIndex = 0



        Dim filters() As String = [Enum].GetNames(GetType(DisputeFilterTypeCodeType))
        Dim fltr As String

        For Each fltr In filters

            If fltr <> "CustomCode" Then

                CboFilter.Items.Add(fltr)

            End If

        Next fltr

        CboFilter.SelectedIndex = 0

    End Sub

    Private Sub BtnGetUserDisputes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetUserDisputes.Click

        Try

            BtnGetUserDisputes.Enabled = False
            LstDisputes.Items.Clear()

            Context = clseBayAPI.setAPIContext()
            Dim apicall As GetUserDisputesCall = New GetUserDisputesCall(Context)

            apicall.DisputeFilterType = [Enum].Parse(GetType(DisputeFilterTypeCodeType), CboFilter.SelectedItem.ToString())

            apicall.DisputeSortType = [Enum].Parse(GetType(DisputeSortTypeCodeType), CboSort.SelectedItem.ToString())

            Dim page As PaginationType = New PaginationType()
            page.PageNumber = 1

            Dim disputes As DisputeTypeCollection = apicall.GetUserDisputes(page)
            Dim dsp As DisputeType


            For Each dsp In disputes

                Dim listparams(10) As String
                listparams(0) = dsp.DisputeID
                listparams(1) = dsp.Item.ItemID
                listparams(2) = dsp.TransactionID
                listparams(3) = dsp.DisputeState.ToString()
                listparams(4) = dsp.DisputeStatus.ToString()
                listparams(5) = dsp.OtherPartyName
                listparams(6) = dsp.UserRole.ToString()
                listparams(7) = dsp.DisputeReason.ToString()
                listparams(8) = dsp.DisputeExplanation.ToString()
                listparams(9) = dsp.DisputeModifiedTime.ToString()


                Dim vi As ListViewItem = New ListViewItem(listparams)

                Me.LstDisputes.Items.Add(vi)


            Next

            BtnGetUserDisputes.Enabled = True
        Catch ex As Exception
            BtnGetUserDisputes.Enabled = True
            Call debug_message(ex, strQuery & vbCrLf & "btnGetUserDisputes")

        End Try

    End Sub
End Class