Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FormLeaveFeedback
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










    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CboType As System.Windows.Forms.ComboBox
    Friend WithEvents LblDuration As System.Windows.Forms.Label
    Friend WithEvents txtFeedbackAbgeben As System.Windows.Forms.TextBox
    Friend WithEvents TxtComments As System.Windows.Forms.TextBox
    Friend WithEvents TxtTransactionId As System.Windows.Forms.TextBox
    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtUserId As System.Windows.Forms.TextBox
    Friend WithEvents LblComments As System.Windows.Forms.Label
    Friend WithEvents LblTransactionId As System.Windows.Forms.Label
    Friend WithEvents LblItemId As System.Windows.Forms.Label
    Friend WithEvents BtnLeaveFeedback As System.Windows.Forms.Button
    Friend WithEvents LblUserId As System.Windows.Forms.Label
    Friend WithEvents btnExternalProfil As System.Windows.Forms.Button

    Friend WithEvents LblStatus As System.Windows.Forms.Label




    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLeaveFeedback))
        Me.GrpResult = New System.Windows.Forms.GroupBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.TxtStatus = New System.Windows.Forms.TextBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CboType = New System.Windows.Forms.ComboBox
        Me.LblDuration = New System.Windows.Forms.Label
        Me.txtFeedbackAbgeben = New System.Windows.Forms.TextBox
        Me.TxtComments = New System.Windows.Forms.TextBox
        Me.TxtTransactionId = New System.Windows.Forms.TextBox
        Me.TxtItemId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtUserId = New System.Windows.Forms.TextBox
        Me.LblComments = New System.Windows.Forms.Label
        Me.LblTransactionId = New System.Windows.Forms.Label
        Me.LblItemId = New System.Windows.Forms.Label
        Me.btnExternalProfil = New System.Windows.Forms.Button
        Me.BtnLeaveFeedback = New System.Windows.Forms.Button
        Me.LblUserId = New System.Windows.Forms.Label
        Me.btnVor = New System.Windows.Forms.Button
        Me.GrpResult.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.LblStatus)
        Me.GrpResult.Controls.Add(Me.TxtStatus)
        Me.GrpResult.Location = New System.Drawing.Point(5, 248)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(614, 64)
        Me.GrpResult.TabIndex = 25
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Ergebnis"
        '
        'LblStatus
        '
        Me.LblStatus.Location = New System.Drawing.Point(41, 29)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(64, 23)
        Me.LblStatus.TabIndex = 42
        Me.LblStatus.Text = "Status"
        '
        'TxtStatus
        '
        Me.TxtStatus.BackColor = System.Drawing.Color.White
        Me.TxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStatus.Location = New System.Drawing.Point(148, 27)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(442, 21)
        Me.TxtStatus.TabIndex = 41
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(5, 327)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(111, 23)
        Me.btnBack.TabIndex = 57
        Me.btnBack.Text = "&Zurück"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.CboType)
        Me.GroupBox1.Controls.Add(Me.LblDuration)
        Me.GroupBox1.Controls.Add(Me.txtFeedbackAbgeben)
        Me.GroupBox1.Controls.Add(Me.TxtComments)
        Me.GroupBox1.Controls.Add(Me.TxtTransactionId)
        Me.GroupBox1.Controls.Add(Me.TxtItemId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtUserId)
        Me.GroupBox1.Controls.Add(Me.LblComments)
        Me.GroupBox1.Controls.Add(Me.LblTransactionId)
        Me.GroupBox1.Controls.Add(Me.LblItemId)
        Me.GroupBox1.Controls.Add(Me.btnExternalProfil)
        Me.GroupBox1.Controls.Add(Me.BtnLeaveFeedback)
        Me.GroupBox1.Controls.Add(Me.LblUserId)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 227)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bewertung"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.YabE.My.Resources.Resources.linie
        Me.PictureBox1.Location = New System.Drawing.Point(22, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'CboType
        '
        Me.CboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboType.Location = New System.Drawing.Point(423, 61)
        Me.CboType.Name = "CboType"
        Me.CboType.Size = New System.Drawing.Size(174, 21)
        Me.CboType.TabIndex = 69
        '
        'LblDuration
        '
        Me.LblDuration.Location = New System.Drawing.Point(355, 64)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(51, 18)
        Me.LblDuration.TabIndex = 68
        Me.LblDuration.Text = "Type:"
        '
        'txtFeedbackAbgeben
        '
        Me.txtFeedbackAbgeben.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFeedbackAbgeben.Location = New System.Drawing.Point(155, 147)
        Me.txtFeedbackAbgeben.Name = "txtFeedbackAbgeben"
        Me.txtFeedbackAbgeben.Size = New System.Drawing.Size(442, 21)
        Me.txtFeedbackAbgeben.TabIndex = 65
        '
        'TxtComments
        '
        Me.TxtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComments.Location = New System.Drawing.Point(155, 97)
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(442, 21)
        Me.TxtComments.TabIndex = 64
        '
        'TxtTransactionId
        '
        Me.TxtTransactionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTransactionId.Location = New System.Drawing.Point(423, 22)
        Me.TxtTransactionId.Name = "TxtTransactionId"
        Me.TxtTransactionId.Size = New System.Drawing.Size(174, 21)
        Me.TxtTransactionId.TabIndex = 62
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(155, 23)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(157, 21)
        Me.TxtItemId.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Kommentar"
        '
        'TxtUserId
        '
        Me.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserId.Location = New System.Drawing.Point(155, 62)
        Me.TxtUserId.Name = "TxtUserId"
        Me.TxtUserId.Size = New System.Drawing.Size(157, 21)
        Me.TxtUserId.TabIndex = 57
        '
        'LblComments
        '
        Me.LblComments.Location = New System.Drawing.Point(18, 99)
        Me.LblComments.Name = "LblComments"
        Me.LblComments.Size = New System.Drawing.Size(88, 23)
        Me.LblComments.TabIndex = 67
        Me.LblComments.Text = "Sagte"
        '
        'LblTransactionId
        '
        Me.LblTransactionId.Location = New System.Drawing.Point(358, 21)
        Me.LblTransactionId.Name = "LblTransactionId"
        Me.LblTransactionId.Size = New System.Drawing.Size(63, 23)
        Me.LblTransactionId.TabIndex = 63
        Me.LblTransactionId.Text = "ID"
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(18, 24)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(80, 23)
        Me.LblItemId.TabIndex = 61
        Me.LblItemId.Text = "eBayID"
        '
        'btnExternalProfil
        '
        Me.btnExternalProfil.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnExternalProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExternalProfil.Image = Global.YabE.My.Resources.Resources.firefox_button
        Me.btnExternalProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExternalProfil.Location = New System.Drawing.Point(393, 190)
        Me.btnExternalProfil.Name = "btnExternalProfil"
        Me.btnExternalProfil.Size = New System.Drawing.Size(204, 23)
        Me.btnExternalProfil.TabIndex = 58
        Me.btnExternalProfil.Text = "&Bewertungsprofil"
        Me.btnExternalProfil.UseVisualStyleBackColor = False
        '
        'BtnLeaveFeedback
        '
        Me.BtnLeaveFeedback.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnLeaveFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLeaveFeedback.Image = Global.YabE.My.Resources.Resources.send
        Me.BtnLeaveFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLeaveFeedback.Location = New System.Drawing.Point(155, 190)
        Me.BtnLeaveFeedback.Name = "BtnLeaveFeedback"
        Me.BtnLeaveFeedback.Size = New System.Drawing.Size(204, 23)
        Me.BtnLeaveFeedback.TabIndex = 58
        Me.BtnLeaveFeedback.Text = "Feedback abgeben"
        Me.BtnLeaveFeedback.UseVisualStyleBackColor = False
        '
        'LblUserId
        '
        Me.LblUserId.Location = New System.Drawing.Point(18, 59)
        Me.LblUserId.Name = "LblUserId"
        Me.LblUserId.Size = New System.Drawing.Size(108, 23)
        Me.LblUserId.TabIndex = 59
        Me.LblUserId.Text = "Mitgliedsname"
        '
        'btnVor
        '
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(510, 327)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(111, 23)
        Me.btnVor.TabIndex = 58
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'FormLeaveFeedback
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.ClientSize = New System.Drawing.Size(633, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GrpResult)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLeaveFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YabE - eBay Kommentar hinterlassen"
        Me.GrpResult.ResumeLayout(False)
        Me.GrpResult.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Context As ApiContext

    Private Sub FormLeaveFeedback_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If

        If e.KeyCode = Keys.Left Then
            btnBack.PerformClick()
        End If

        If e.KeyCode = Keys.Right Then
            btnVor.PerformClick()
        End If

    End Sub

    Private Sub FrmLeaveFeedback_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtFeedbackAbgeben.Focus()

        Dim s As Type = GetType(CommentTypeCodeType)
        Dim item As String
        TxtTransactionId.Text = 0

        For Each item In [Enum].GetNames(s)

            If item <> "CustomCode" And item <> "Withdrawn" Then
                CboType.Items.Add(item)
            End If
        Next item

        CboType.SelectedIndex = 0

    End Sub

    '####################################################
    '# >> Feedback hinterlassen 
    '#################################################### 
    Private Sub BtnLeaveFeedback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLeaveFeedback.Click
        Try

            If txtFeedbackAbgeben.Text.Length = 0 Then
                MsgBox("Bitte einen Kommentartext eintragen")
                Exit Sub
            End If

            BtnLeaveFeedback.Enabled = False

            TxtStatus.Text = ""
            Context = clseBayAPI.setAPIContext()

            Dim apicall As LeaveFeedbackCall = New LeaveFeedbackCall(Context)
            Dim type As CommentTypeCodeType = [Enum].Parse(GetType(CommentTypeCodeType), CboType.SelectedItem.ToString())
            apicall.LeaveFeedback(TxtItemId.Text, txtFeedbackAbgeben.Text, CommentTypeCodeType.Positive, TxtTransactionId.Text, TxtUserId.Text)

            TxtStatus.Text = apicall.ApiResponse.Ack.ToString()
            TxtComments.Text = My.Settings.yabe_gui_bewerten_defaultText

            '# Bewertung erfolgreich 
            If TxtStatus.Text = "Success" Then
                clsDatenbank_modul.setFeedbackUser(TxtItemId.Text)
                frmMain.frmManage.lvwBewertungen.SelectedItems(0).Remove()
                TxtStatus.Text = "Die eBay Bewertung erfolgreich abgegeben"
            End If

        Catch ex As Exception
            If ex.Message.ToString = "Sie haben für dieses eBay Mitglied keine Bewertung abgegeben." + vbNewLine + " Für diese Transaktion haben Sie bereits eine eBay Bewertung abgegeben." Then
                clsDatenbank_modul.setFeedbackUser(TxtItemId.Text)
                MsgBox("Das eBay Mitglied " & TxtUserId.Text & " wurde bereits bewerted", MsgBoxStyle.Information)
                frmMain.frmManage.lvwBewertungen.SelectedItems(0).Remove()
            Else
                Call debug_message(ex, strQuery & vbCrLf & "btnLeaveFeedback")
            End If

            BtnLeaveFeedback.Enabled = True
        End Try

        BtnLeaveFeedback.Enabled = True
    End Sub

    '####################################################
    '# >> Rückwärtsblättern 
    '#################################################### 
    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0

        If frmMain.frmManage.lvwBewertungen.SelectedItems.Count > 0 Then

            iAnzahl = frmMain.frmManage.lvwBewertungen.SelectedItems(0).Index
            iAnzahl += 1
            btnBack.Enabled = True

            If iAnzahl = frmMain.frmManage.lvwBewertungen.Items.Count - 1 Then
                btnVor.Enabled = False
            End If

            frmMain.frmManage.lvwBewertungen.Items(iAnzahl).Selected = True
            frmMain.frmManage.lvwBewertungen.Items(iAnzahl).EnsureVisible()
            TxtItemId.Text = frmMain.frmManage.lvwBewertungen.SelectedItems(0).SubItems(2).Text
            TxtUserId.Text = frmMain.frmManage.lvwBewertungen.SelectedItems(0).Text
            TxtComments.Text = frmMain.frmManage.lvwBewertungen.SelectedItems(0).SubItems(4).Text



        End If
    End Sub

    '####################################################
    '# >> Vorwärtsblättern 
    '####################################################
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0

        If frmMain.frmManage.lvwBewertungen.SelectedItems.Count > 0 Then

            iAnzahl = frmMain.frmManage.lvwBewertungen.SelectedItems(0).Index
            iAnzahl -= 1
            btnVor.Enabled = True

            If iAnzahl = 0 Then
                btnBack.Enabled = False
            End If
            If iAnzahl = -1 Then
                iAnzahl = 0
            End If

            frmMain.frmManage.lvwBewertungen.Items(iAnzahl).Selected = True
            frmMain.frmManage.lvwBewertungen.Items(iAnzahl).EnsureVisible()
            TxtItemId.Text = frmMain.frmManage.lvwBewertungen.SelectedItems(0).SubItems(2).Text
            TxtUserId.Text = frmMain.frmManage.lvwBewertungen.SelectedItems(0).Text
            TxtComments.Text = frmMain.frmManage.lvwBewertungen.SelectedItems(0).SubItems(4).Text



        End If
    End Sub

    Private Sub btnExternalProfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExternalProfil.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        ExterneAnwendung.StartInfo.FileName = "http://feedback.ebay.de/ws/eBayISAPI.dll?ViewFeedback2&userid=" & TxtUserId.Text
        ExterneAnwendung.Start()
    End Sub

    Private Sub txtFeedbackAbgeben_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFeedbackAbgeben.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLeaveFeedback.PerformClick()
        End If
    End Sub

    Private Sub txtFeedbackAbgeben_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFeedbackAbgeben.TextChanged

    End Sub
End Class

