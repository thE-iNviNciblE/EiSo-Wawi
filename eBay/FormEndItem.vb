Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FrmEndItem
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

    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox

    Friend WithEvents LblItemId As System.Windows.Forms.Label

    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox

    Friend WithEvents LblStatus As System.Windows.Forms.Label

    Friend WithEvents BtnEndItem As System.Windows.Forms.Button

    Friend WithEvents CboReason As System.Windows.Forms.ComboBox

    Friend WithEvents LblReason As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEndItem))
        Me.BtnEndItem = New System.Windows.Forms.Button
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.TxtStatus = New System.Windows.Forms.TextBox
        Me.TxtItemId = New System.Windows.Forms.TextBox
        Me.LblItemId = New System.Windows.Forms.Label
        Me.CboReason = New System.Windows.Forms.ComboBox
        Me.LblReason = New System.Windows.Forms.Label
        Me.GrpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEndItem
        '
        Me.BtnEndItem.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnEndItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEndItem.Image = Global.YabE.My.Resources.Resources.send
        Me.BtnEndItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEndItem.Location = New System.Drawing.Point(12, 67)
        Me.BtnEndItem.Name = "BtnEndItem"
        Me.BtnEndItem.Size = New System.Drawing.Size(342, 23)
        Me.BtnEndItem.TabIndex = 23
        Me.BtnEndItem.Text = "eBay Artikel Beenden"
        Me.BtnEndItem.UseVisualStyleBackColor = False
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.LblStatus)
        Me.GrpResult.Controls.Add(Me.TxtStatus)
        Me.GrpResult.Location = New System.Drawing.Point(8, 96)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(352, 64)
        Me.GrpResult.TabIndex = 25
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'LblStatus
        '
        Me.LblStatus.Location = New System.Drawing.Point(16, 24)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(80, 23)
        Me.LblStatus.TabIndex = 42
        Me.LblStatus.Text = "Status:"
        '
        'TxtStatus
        '
        Me.TxtStatus.BackColor = System.Drawing.Color.White
        Me.TxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStatus.Location = New System.Drawing.Point(96, 24)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(250, 21)
        Me.TxtStatus.TabIndex = 41
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(104, 8)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(250, 21)
        Me.TxtItemId.TabIndex = 26
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(9, 10)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(80, 23)
        Me.LblItemId.TabIndex = 27
        Me.LblItemId.Text = "eBayID:"
        '
        'CboReason
        '
        Me.CboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboReason.Location = New System.Drawing.Point(104, 35)
        Me.CboReason.Name = "CboReason"
        Me.CboReason.Size = New System.Drawing.Size(250, 21)
        Me.CboReason.TabIndex = 55
        '
        'LblReason
        '
        Me.LblReason.Location = New System.Drawing.Point(12, 38)
        Me.LblReason.Name = "LblReason"
        Me.LblReason.Size = New System.Drawing.Size(80, 18)
        Me.LblReason.TabIndex = 54
        Me.LblReason.Text = "Grund:"
        '
        'FrmEndItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.ClientSize = New System.Drawing.Size(368, 165)
        Me.Controls.Add(Me.CboReason)
        Me.Controls.Add(Me.LblReason)
        Me.Controls.Add(Me.TxtItemId)
        Me.Controls.Add(Me.LblItemId)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnEndItem)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEndItem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "eBay Artikel Beenden"
        Me.GrpResult.ResumeLayout(False)
        Me.GrpResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext

    Private Sub FrmEndItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim reasons As Type = GetType(EndReasonCodeType)

        Dim rsn As String

        For Each rsn In [Enum].GetNames(reasons)

            If rsn <> "CustomCode" Then
                CboReason.Items.Add(rsn)
            End If
        Next rsn

        CboReason.SelectedIndex = 0

    End Sub



    Private Sub BtnEndItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEndItem.Click

        Try

            If MsgBox("Möchten Sie den eBay Artikel wirklich beenden?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If

            TxtStatus.Text = ""
            Context = clseBayAPI.setAPIContext()
            Application.DoEvents()
            Dim apicall As EndItemCall = New EndItemCall(Context)
            apicall.EndItem(TxtItemId.Text, [Enum].Parse(GetType(EndReasonCodeType), CboReason.SelectedItem.ToString()))

            TxtStatus.Text = apicall.ApiResponse.Ack.ToString()

        Catch ex As Exception
            'Me.txtErrors.Text = ex
            MsgBox(ex)

        End Try

    End Sub

End Class

