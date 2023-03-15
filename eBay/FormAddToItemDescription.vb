Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util


Public Class FrmAddToItemDescription
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

    Friend WithEvents LblAppend As System.Windows.Forms.Label

    Friend WithEvents TxtAppend As System.Windows.Forms.TextBox
    Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser

    Friend WithEvents BtnAddToItemDescriptionCall As System.Windows.Forms.Button


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddToItemDescription))
        Me.BtnAddToItemDescriptionCall = New System.Windows.Forms.Button
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.TxtStatus = New System.Windows.Forms.TextBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.TxtItemId = New System.Windows.Forms.TextBox
        Me.LblItemId = New System.Windows.Forms.Label
        Me.LblAppend = New System.Windows.Forms.Label
        Me.TxtAppend = New System.Windows.Forms.TextBox
        Me.webBrowser = New System.Windows.Forms.WebBrowser
        Me.GrpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAddToItemDescriptionCall
        '
        Me.BtnAddToItemDescriptionCall.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAddToItemDescriptionCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToItemDescriptionCall.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddToItemDescriptionCall.Image = Global.YabE.My.Resources.Resources._03
        Me.BtnAddToItemDescriptionCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddToItemDescriptionCall.Location = New System.Drawing.Point(88, 155)
        Me.BtnAddToItemDescriptionCall.Name = "BtnAddToItemDescriptionCall"
        Me.BtnAddToItemDescriptionCall.Size = New System.Drawing.Size(334, 23)
        Me.BtnAddToItemDescriptionCall.TabIndex = 23
        Me.BtnAddToItemDescriptionCall.Text = "eBay Beschreibung erweitern"
        Me.BtnAddToItemDescriptionCall.UseVisualStyleBackColor = False
        '
        'GrpResult
        '
        Me.GrpResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpResult.Controls.Add(Me.TxtStatus)
        Me.GrpResult.Controls.Add(Me.LblStatus)
        Me.GrpResult.Location = New System.Drawing.Point(8, 198)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(751, 64)
        Me.GrpResult.TabIndex = 25
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'TxtStatus
        '
        Me.TxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStatus.Location = New System.Drawing.Point(80, 24)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(665, 20)
        Me.TxtStatus.TabIndex = 41
        '
        'LblStatus
        '
        Me.LblStatus.Location = New System.Drawing.Point(16, 24)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(80, 23)
        Me.LblStatus.TabIndex = 42
        Me.LblStatus.Text = "Status:"
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(88, 8)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(172, 20)
        Me.TxtItemId.TabIndex = 26
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(8, 8)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(80, 23)
        Me.LblItemId.TabIndex = 27
        Me.LblItemId.Text = "Artikel-ID:"
        '
        'LblAppend
        '
        Me.LblAppend.Location = New System.Drawing.Point(8, 32)
        Me.LblAppend.Name = "LblAppend"
        Me.LblAppend.Size = New System.Drawing.Size(88, 23)
        Me.LblAppend.TabIndex = 31
        Me.LblAppend.Text = "Kommentare:"
        '
        'TxtAppend
        '
        Me.TxtAppend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAppend.Location = New System.Drawing.Point(88, 32)
        Me.TxtAppend.Multiline = True
        Me.TxtAppend.Name = "TxtAppend"
        Me.TxtAppend.Size = New System.Drawing.Size(334, 117)
        Me.TxtAppend.TabIndex = 30
        '
        'webBrowser
        '
        Me.webBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webBrowser.Location = New System.Drawing.Point(445, 8)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.Size = New System.Drawing.Size(314, 172)
        Me.webBrowser.TabIndex = 32
        '
        'FrmAddToItemDescription
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(771, 274)
        Me.Controls.Add(Me.webBrowser)
        Me.Controls.Add(Me.TxtAppend)
        Me.Controls.Add(Me.LblAppend)
        Me.Controls.Add(Me.TxtItemId)
        Me.Controls.Add(Me.LblItemId)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnAddToItemDescriptionCall)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddToItemDescription"
        Me.Text = "Yabe - eBay Beschreibung erweitern"
        Me.GrpResult.ResumeLayout(False)
        Me.GrpResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext


    Private Sub BtnAddToItemDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddToItemDescriptionCall.Click
        Try
            TxtStatus.Text = ""
            Context = clseBayAPI.setAPIContext()
            Dim apicall As AddToItemDescriptionCall = New AddToItemDescriptionCall(Context)
            apicall.AddToItemDescription(TxtItemId.Text, TxtAppend.Text)
            TxtStatus.Text = apicall.ApiResponse.Ack.ToString()


        Catch ex As Exception
            'Me.txtErrors.Text = ex.Message
            MsgBox(ex.Message)

        End Try


    End Sub

End Class

