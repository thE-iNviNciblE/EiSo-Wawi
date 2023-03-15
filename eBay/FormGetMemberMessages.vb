Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FrmGetMemberMessages
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

    Friend WithEvents DatePickStartTo As System.Windows.Forms.DateTimePicker

    Friend WithEvents LblStartSep As System.Windows.Forms.Label

    Friend WithEvents GrpResult As System.Windows.Forms.GroupBox

    Friend WithEvents DatePickStartFrom As System.Windows.Forms.DateTimePicker

    Friend WithEvents ClmItemId As System.Windows.Forms.ColumnHeader

    Friend WithEvents BtnGetMemberMessages As System.Windows.Forms.Button

    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox

    Friend WithEvents LblItemId As System.Windows.Forms.Label

    Friend WithEvents CboStatus As System.Windows.Forms.ComboBox

    Friend WithEvents LblStatus As System.Windows.Forms.Label

    Friend WithEvents CboType As System.Windows.Forms.ComboBox

    Friend WithEvents LblType As System.Windows.Forms.Label

    Friend WithEvents ChkPublic As System.Windows.Forms.CheckBox

    Friend WithEvents LblTimeRange As System.Windows.Forms.Label

    Friend WithEvents ChkStartFrom As System.Windows.Forms.CheckBox

    Friend WithEvents ChkStartTo As System.Windows.Forms.CheckBox

    Friend WithEvents LblMessages As System.Windows.Forms.Label

    Friend WithEvents LstMessages As System.Windows.Forms.ListView

    Friend WithEvents ClmStatus As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmType As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmSender As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmMessageId As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents ClmBody As System.Windows.Forms.ColumnHeader

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGetMemberMessages))
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.LblMessages = New System.Windows.Forms.Label
        Me.LstMessages = New System.Windows.Forms.ListView
        Me.ClmItemId = New System.Windows.Forms.ColumnHeader
        Me.ClmMessageId = New System.Windows.Forms.ColumnHeader
        Me.ClmStatus = New System.Windows.Forms.ColumnHeader
        Me.ClmType = New System.Windows.Forms.ColumnHeader
        Me.ClmSender = New System.Windows.Forms.ColumnHeader
        Me.ClmBody = New System.Windows.Forms.ColumnHeader
        Me.DatePickStartTo = New System.Windows.Forms.DateTimePicker
        Me.DatePickStartFrom = New System.Windows.Forms.DateTimePicker
        Me.LblStartSep = New System.Windows.Forms.Label
        Me.TxtItemId = New System.Windows.Forms.TextBox
        Me.LblItemId = New System.Windows.Forms.Label
        Me.CboStatus = New System.Windows.Forms.ComboBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.CboType = New System.Windows.Forms.ComboBox
        Me.LblType = New System.Windows.Forms.Label
        Me.ChkPublic = New System.Windows.Forms.CheckBox
        Me.LblTimeRange = New System.Windows.Forms.Label
        Me.ChkStartFrom = New System.Windows.Forms.CheckBox
        Me.ChkStartTo = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnGetMemberMessages = New System.Windows.Forms.Button
        Me.GrpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.LblMessages)
        Me.GrpResult.Controls.Add(Me.LstMessages)
        Me.GrpResult.Location = New System.Drawing.Point(8, 67)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(857, 501)
        Me.GrpResult.TabIndex = 24
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'LblMessages
        '
        Me.LblMessages.Location = New System.Drawing.Point(16, 17)
        Me.LblMessages.Name = "LblMessages"
        Me.LblMessages.Size = New System.Drawing.Size(112, 23)
        Me.LblMessages.TabIndex = 15
        Me.LblMessages.Text = "Nachrichten:"
        '
        'LstMessages
        '
        Me.LstMessages.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LstMessages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmItemId, Me.ClmMessageId, Me.ClmStatus, Me.ClmType, Me.ClmSender, Me.ClmBody})
        Me.LstMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMessages.FullRowSelect = True
        Me.LstMessages.GridLines = True
        Me.LstMessages.HideSelection = False
        Me.LstMessages.HotTracking = True
        Me.LstMessages.HoverSelection = True
        Me.LstMessages.Location = New System.Drawing.Point(8, 35)
        Me.LstMessages.MultiSelect = False
        Me.LstMessages.Name = "LstMessages"
        Me.LstMessages.Size = New System.Drawing.Size(841, 460)
        Me.LstMessages.TabIndex = 4
        Me.LstMessages.UseCompatibleStateImageBehavior = False
        Me.LstMessages.View = System.Windows.Forms.View.Details
        '
        'ClmItemId
        '
        Me.ClmItemId.Text = "eBayID"
        Me.ClmItemId.Width = 56
        '
        'ClmMessageId
        '
        Me.ClmMessageId.Text = "MID"
        Me.ClmMessageId.Width = 69
        '
        'ClmStatus
        '
        Me.ClmStatus.Text = "Status"
        Me.ClmStatus.Width = 50
        '
        'ClmType
        '
        Me.ClmType.Text = "Fragetyp"
        Me.ClmType.Width = 87
        '
        'ClmSender
        '
        Me.ClmSender.Text = "Sender"
        Me.ClmSender.Width = 51
        '
        'ClmBody
        '
        Me.ClmBody.Text = "Frage"
        Me.ClmBody.Width = 272
        '
        'DatePickStartTo
        '
        Me.DatePickStartTo.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DatePickStartTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickStartTo.Location = New System.Drawing.Point(626, 13)
        Me.DatePickStartTo.Name = "DatePickStartTo"
        Me.DatePickStartTo.Size = New System.Drawing.Size(198, 20)
        Me.DatePickStartTo.TabIndex = 65
        '
        'DatePickStartFrom
        '
        Me.DatePickStartFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DatePickStartFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickStartFrom.Location = New System.Drawing.Point(626, 42)
        Me.DatePickStartFrom.Name = "DatePickStartFrom"
        Me.DatePickStartFrom.Size = New System.Drawing.Size(198, 20)
        Me.DatePickStartFrom.TabIndex = 64
        '
        'LblStartSep
        '
        Me.LblStartSep.Location = New System.Drawing.Point(570, 9)
        Me.LblStartSep.Name = "LblStartSep"
        Me.LblStartSep.Size = New System.Drawing.Size(16, 23)
        Me.LblStartSep.TabIndex = 63
        Me.LblStartSep.Text = " - "
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(70, 8)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(167, 21)
        Me.TxtItemId.TabIndex = 70
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(8, 8)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(80, 16)
        Me.LblItemId.TabIndex = 72
        Me.LblItemId.Text = "eBayID"
        '
        'CboStatus
        '
        Me.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboStatus.Location = New System.Drawing.Point(70, 37)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(167, 21)
        Me.CboStatus.TabIndex = 74
        '
        'LblStatus
        '
        Me.LblStatus.Location = New System.Drawing.Point(5, 38)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(80, 18)
        Me.LblStatus.TabIndex = 73
        Me.LblStatus.Text = "Status:"
        '
        'CboType
        '
        Me.CboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboType.Location = New System.Drawing.Point(322, 38)
        Me.CboType.Name = "CboType"
        Me.CboType.Size = New System.Drawing.Size(171, 21)
        Me.CboType.TabIndex = 76
        '
        'LblType
        '
        Me.LblType.Location = New System.Drawing.Point(269, 38)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(80, 18)
        Me.LblType.TabIndex = 75
        Me.LblType.Text = "Type:"
        '
        'ChkPublic
        '
        Me.ChkPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkPublic.Location = New System.Drawing.Point(272, 5)
        Me.ChkPublic.Name = "ChkPublic"
        Me.ChkPublic.Size = New System.Drawing.Size(178, 24)
        Me.ChkPublic.TabIndex = 77
        Me.ChkPublic.Text = "Öffentlich Empfangene"
        '
        'LblTimeRange
        '
        Me.LblTimeRange.Location = New System.Drawing.Point(522, 42)
        Me.LblTimeRange.Name = "LblTimeRange"
        Me.LblTimeRange.Size = New System.Drawing.Size(64, 16)
        Me.LblTimeRange.TabIndex = 78
        Me.LblTimeRange.Text = "Zeitfilter:"
        '
        'ChkStartFrom
        '
        Me.ChkStartFrom.Checked = True
        Me.ChkStartFrom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStartFrom.Location = New System.Drawing.Point(596, 37)
        Me.ChkStartFrom.Name = "ChkStartFrom"
        Me.ChkStartFrom.Size = New System.Drawing.Size(12, 24)
        Me.ChkStartFrom.TabIndex = 79
        '
        'ChkStartTo
        '
        Me.ChkStartTo.Checked = True
        Me.ChkStartTo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStartTo.Location = New System.Drawing.Point(596, 9)
        Me.ChkStartTo.Name = "ChkStartTo"
        Me.ChkStartTo.Size = New System.Drawing.Size(10, 24)
        Me.ChkStartTo.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(522, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Bis"
        '
        'BtnGetMemberMessages
        '
        Me.BtnGetMemberMessages.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetMemberMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetMemberMessages.Image = Global.YabE.My.Resources.Resources.send
        Me.BtnGetMemberMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetMemberMessages.Location = New System.Drawing.Point(16, 574)
        Me.BtnGetMemberMessages.Name = "BtnGetMemberMessages"
        Me.BtnGetMemberMessages.Size = New System.Drawing.Size(299, 23)
        Me.BtnGetMemberMessages.TabIndex = 23
        Me.BtnGetMemberMessages.Text = "&eBay Nachrichten"
        Me.BtnGetMemberMessages.UseVisualStyleBackColor = False
        '
        'FrmGetMemberMessages
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.ClientSize = New System.Drawing.Size(877, 609)
        Me.Controls.Add(Me.ChkStartFrom)
        Me.Controls.Add(Me.TxtItemId)
        Me.Controls.Add(Me.ChkStartTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTimeRange)
        Me.Controls.Add(Me.ChkPublic)
        Me.Controls.Add(Me.CboType)
        Me.Controls.Add(Me.LblType)
        Me.Controls.Add(Me.CboStatus)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblItemId)
        Me.Controls.Add(Me.DatePickStartTo)
        Me.Controls.Add(Me.DatePickStartFrom)
        Me.Controls.Add(Me.LblStartSep)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.BtnGetMemberMessages)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGetMemberMessages"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YabE - eBay Nachrichtenzentrale"
        Me.GrpResult.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Context As ApiContext

    Private Sub FrmGetMemberMessages_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim now As DateTime = DateTime.Now
        DatePickStartTo.Value = now
        DatePickStartFrom.Value = now.AddDays(-5)

        Dim types As Type = GetType(MessageTypeCodeType)
        Dim typ As String

        For Each typ In [Enum].GetNames(types)
            If typ <> "CustomCode" Then
                CboType.Items.Add(typ)
            End If
        Next typ

        CboType.SelectedIndex = 0



        Dim statie As Type = GetType(MessageStatusTypeCodeType)
        Dim stat As String

        For Each stat In [Enum].GetNames(statie)
            If stat <> "CustomCode" Then
                CboStatus.Items.Add(stat)
            End If

        Next stat
        CboStatus.SelectedIndex = 0
    End Sub

    Private Sub BtnGetMemberMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetMemberMessages.Click

        Try
            BtnGetMemberMessages.Enabled = False
            LstMessages.Items.Clear()

            Context = clseBayAPI.setAPIContext
            Application.DoEvents()
            Dim apicall As GetMemberMessagesCall = New GetMemberMessagesCall(Context)
            apicall.DisplayToPublic = ChkPublic.Checked
            Dim messages As MemberMessageExchangeTypeCollection

            If TxtItemId.Text <> String.Empty Then
                Application.DoEvents()
                messages = apicall.GetMemberMessages(TxtItemId.Text, [Enum].Parse(GetType(MessageTypeCodeType), CboType.SelectedItem.ToString()), [Enum].Parse(GetType(MessageStatusTypeCodeType), CboStatus.SelectedItem.ToString()))
            Else
                Dim fltr As TimeFilter = New TimeFilter()

                If ChkStartFrom.Checked Then
                    fltr.TimeFrom = DatePickStartFrom.Value
                End If

                If ChkStartTo.Checked Then
                    fltr.TimeTo = DatePickStartTo.Value
                End If
                Application.DoEvents()
                messages = apicall.GetMemberMessages(fltr, [Enum].Parse(GetType(MessageTypeCodeType), CboType.SelectedItem.ToString()), [Enum].Parse(GetType(MessageStatusTypeCodeType), CboStatus.SelectedItem.ToString()))
            End If

            Dim msg As MemberMessageExchangeType
            For Each msg In messages

                Dim listparams(6) As String
                If Not msg.Item Is Nothing Then
                    listparams(0) = msg.Item.ItemID
                Else
                    listparams(0) = ""
                End If

                listparams(1) = msg.Question.MessageID
                listparams(2) = msg.MessageStatus.ToString()
                listparams(3) = msg.Question.QuestionType.ToString()
                listparams(4) = msg.Question.SenderID
                listparams(5) = msg.Question.Body

                Dim vi As ListViewItem = New ListViewItem(listparams)

                LstMessages.Items.Add(vi)

            Next msg

            BtnGetMemberMessages.Enabled = True

        Catch ex As Exception
            MsgBox(ex)

        End Try

    End Sub

End Class
