Imports System
Imports System.Globalization
Imports eBay.Service.Core.Soap
Imports eBay.Service.Core.Sdk
Imports eBay.Service.Call
Imports eBay.Service.Util



Public Class FrmGetAllBidders
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


    Friend WithEvents TxtItemId As System.Windows.Forms.TextBox

    Friend WithEvents LblItemId As System.Windows.Forms.Label


    Friend WithEvents BtnGetAllBidders As System.Windows.Forms.Button

    Friend WithEvents ClmAction As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmUser As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmCurrency As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmMaxBid As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmQuantiy As System.Windows.Forms.ColumnHeader

    Friend WithEvents ClmTimeBid As System.Windows.Forms.ColumnHeader

    Friend WithEvents GrpResults As System.Windows.Forms.GroupBox

    Friend WithEvents LstHighBids As System.Windows.Forms.ListView

    Friend WithEvents CboCallMode As System.Windows.Forms.ComboBox
    Friend WithEvents ctnHöchstbietender As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MitgliedsinfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents chkNurGeboteAnzeigen As System.Windows.Forms.CheckBox
    Friend WithEvents ClmEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClmName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTitel As System.Windows.Forms.Label

    Friend WithEvents LblCallMode As System.Windows.Forms.Label


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGetAllBidders))
        Me.TxtItemId = New System.Windows.Forms.TextBox()
        Me.LblItemId = New System.Windows.Forms.Label()
        Me.GrpResults = New System.Windows.Forms.GroupBox()
        Me.LstHighBids = New System.Windows.Forms.ListView()
        Me.ClmAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmCurrency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmMaxBid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmQuantiy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmTimeBid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClmName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctnHöchstbietender = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MitgliedsinfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnGetAllBidders = New System.Windows.Forms.Button()
        Me.CboCallMode = New System.Windows.Forms.ComboBox()
        Me.LblCallMode = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.chkNurGeboteAnzeigen = New System.Windows.Forms.CheckBox()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.GrpResults.SuspendLayout()
        Me.ctnHöchstbietender.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtItemId
        '
        Me.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemId.Location = New System.Drawing.Point(145, 60)
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(186, 24)
        Me.TxtItemId.TabIndex = 30
        '
        'LblItemId
        '
        Me.LblItemId.Location = New System.Drawing.Point(21, 60)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(126, 21)
        Me.LblItemId.TabIndex = 37
        Me.LblItemId.Text = "Artikelnummer"
        '
        'GrpResults
        '
        Me.GrpResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpResults.Controls.Add(Me.LstHighBids)
        Me.GrpResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrpResults.Location = New System.Drawing.Point(6, 91)
        Me.GrpResults.Name = "GrpResults"
        Me.GrpResults.Size = New System.Drawing.Size(1044, 339)
        Me.GrpResults.TabIndex = 45
        Me.GrpResults.TabStop = False
        Me.GrpResults.Text = "Ergebnis"
        '
        'LstHighBids
        '
        Me.LstHighBids.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LstHighBids.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstHighBids.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstHighBids.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClmAction, Me.ClmUser, Me.ClmCurrency, Me.ClmMaxBid, Me.ClmQuantiy, Me.ClmTimeBid, Me.ClmEmail, Me.ClmName})
        Me.LstHighBids.ContextMenuStrip = Me.ctnHöchstbietender
        Me.LstHighBids.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstHighBids.FullRowSelect = True
        Me.LstHighBids.GridLines = True
        Me.LstHighBids.HideSelection = False
        Me.LstHighBids.HotTracking = True
        Me.LstHighBids.HoverSelection = True
        Me.LstHighBids.Location = New System.Drawing.Point(4, 21)
        Me.LstHighBids.MultiSelect = False
        Me.LstHighBids.Name = "LstHighBids"
        Me.LstHighBids.Size = New System.Drawing.Size(1032, 310)
        Me.LstHighBids.TabIndex = 15
        Me.LstHighBids.UseCompatibleStateImageBehavior = False
        Me.LstHighBids.View = System.Windows.Forms.View.Details
        '
        'ClmAction
        '
        Me.ClmAction.Text = "Aktion"
        Me.ClmAction.Width = 90
        '
        'ClmUser
        '
        Me.ClmUser.Text = "Mitglied"
        Me.ClmUser.Width = 125
        '
        'ClmCurrency
        '
        Me.ClmCurrency.Text = "Währung"
        Me.ClmCurrency.Width = 75
        '
        'ClmMaxBid
        '
        Me.ClmMaxBid.Text = "Preis"
        Me.ClmMaxBid.Width = 58
        '
        'ClmQuantiy
        '
        Me.ClmQuantiy.Text = "Menge"
        Me.ClmQuantiy.Width = 59
        '
        'ClmTimeBid
        '
        Me.ClmTimeBid.Text = "Zeitpunkt"
        Me.ClmTimeBid.Width = 158
        '
        'ClmEmail
        '
        Me.ClmEmail.Text = "Email"
        Me.ClmEmail.Width = 175
        '
        'ClmName
        '
        Me.ClmName.Text = "Info"
        Me.ClmName.Width = 292
        '
        'ctnHöchstbietender
        '
        Me.ctnHöchstbietender.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MitgliedsinfoToolStripMenuItem})
        Me.ctnHöchstbietender.Name = "ctnHöchstbietender"
        Me.ctnHöchstbietender.Size = New System.Drawing.Size(218, 28)
        '
        'MitgliedsinfoToolStripMenuItem
        '
        Me.MitgliedsinfoToolStripMenuItem.Image = Global.YabE.My.Resources.Resources.GetInfo
        Me.MitgliedsinfoToolStripMenuItem.Name = "MitgliedsinfoToolStripMenuItem"
        Me.MitgliedsinfoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MitgliedsinfoToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.MitgliedsinfoToolStripMenuItem.Text = "&Mitgliedsinfo"
        '
        'BtnGetAllBidders
        '
        Me.BtnGetAllBidders.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnGetAllBidders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetAllBidders.Image = Global.YabE.My.Resources.Resources.send
        Me.BtnGetAllBidders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetAllBidders.Location = New System.Drawing.Point(657, 56)
        Me.BtnGetAllBidders.Name = "BtnGetAllBidders"
        Me.BtnGetAllBidders.Size = New System.Drawing.Size(375, 28)
        Me.BtnGetAllBidders.TabIndex = 46
        Me.BtnGetAllBidders.Text = "&Höchtbieter abrufen"
        Me.BtnGetAllBidders.UseVisualStyleBackColor = False
        '
        'CboCallMode
        '
        Me.CboCallMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCallMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCallMode.Location = New System.Drawing.Point(613, 19)
        Me.CboCallMode.Name = "CboCallMode"
        Me.CboCallMode.Size = New System.Drawing.Size(185, 25)
        Me.CboCallMode.TabIndex = 57
        Me.CboCallMode.Visible = False
        '
        'LblCallMode
        '
        Me.LblCallMode.Location = New System.Drawing.Point(527, 23)
        Me.LblCallMode.Name = "LblCallMode"
        Me.LblCallMode.Size = New System.Drawing.Size(103, 22)
        Me.LblCallMode.TabIndex = 56
        Me.LblCallMode.Text = "Modus"
        Me.LblCallMode.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.YabE.My.Resources.Resources.links
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(337, 56)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 28)
        Me.btnBack.TabIndex = 58
        Me.btnBack.Text = "&Zurück"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnVor
        '
        Me.btnVor.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVor.Image = Global.YabE.My.Resources.Resources.rechts
        Me.btnVor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVor.Location = New System.Drawing.Point(487, 56)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(143, 28)
        Me.btnVor.TabIndex = 59
        Me.btnVor.Text = "&Vor"
        Me.btnVor.UseVisualStyleBackColor = False
        '
        'chkNurGeboteAnzeigen
        '
        Me.chkNurGeboteAnzeigen.AutoSize = True
        Me.chkNurGeboteAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNurGeboteAnzeigen.Location = New System.Drawing.Point(341, 21)
        Me.chkNurGeboteAnzeigen.Name = "chkNurGeboteAnzeigen"
        Me.chkNurGeboteAnzeigen.Size = New System.Drawing.Size(114, 21)
        Me.chkNurGeboteAnzeigen.TabIndex = 60
        Me.chkNurGeboteAnzeigen.Text = "Nur Gebote"
        Me.chkNurGeboteAnzeigen.UseVisualStyleBackColor = True
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.Location = New System.Drawing.Point(15, 11)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(293, 32)
        Me.lblTitel.TabIndex = 61
        Me.lblTitel.Text = "eBay Höchstbieter"
        '
        'FrmGetAllBidders
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(9, 17)
        Me.ClientSize = New System.Drawing.Size(1065, 444)
        Me.Controls.Add(Me.lblTitel)
        Me.Controls.Add(Me.GrpResults)
        Me.Controls.Add(Me.TxtItemId)
        Me.Controls.Add(Me.chkNurGeboteAnzeigen)
        Me.Controls.Add(Me.CboCallMode)
        Me.Controls.Add(Me.LblItemId)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.LblCallMode)
        Me.Controls.Add(Me.BtnGetAllBidders)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGetAllBidders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EiSo - eBay Höchstbieter"
        Me.GrpResults.ResumeLayout(False)
        Me.ctnHöchstbietender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public lvwDataInput As ListView
    Public Context As ApiContext

    Private Sub FrmGetAllBidders_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim modes() As String = [Enum].GetNames(GetType(GetAllBiddersModeCodeType))
        Dim mode As String

        For Each mode In modes
            If mode <> "CustomCode" Then
                CboCallMode.Items.Add(mode)

            End If
        Next mode

        CboCallMode.SelectedIndex = 0

        If TxtItemId.Text.Length > 0 Then
            BtnGetAllBidders.PerformClick()
        End If

    End Sub

    Private Sub BtnGetAllBidders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetAllBidders.Click

        Try
            BtnGetAllBidders.Enabled = False
            LstHighBids.Items.Clear()


            clseBayAPI.geteBayBidderList(LstHighBids, TxtItemId.Text, CboCallMode.SelectedItem.ToString())

            frmMain.master_Message_label.Text = "Updates: " & clseBayAPI.iCount_update & " | Neu: " & clseBayAPI.iCount_insert

            BtnGetAllBidders.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            BtnGetAllBidders.Enabled = True

        End Try

    End Sub

    Private Sub MitgliedsinfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MitgliedsinfoToolStripMenuItem.Click

        If LstHighBids.SelectedItems.Count > 0 Then

            Dim frmBenutzerinfo As New FrmGetUser
            frmBenutzerinfo.TxtUserId.Text = LstHighBids.SelectedItems(0).SubItems(1).Text
            frmBenutzerinfo.TxtItemId.Text = TxtItemId.Text
            frmBenutzerinfo.ShowDialog(Me)
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim iAnzahl As Integer = 0

        If frmMain.frmManage.lvwEiSoCockpit.SelectedItems.Count > 0 Then

            btnBack.Enabled = False

            Call setLvwView_blättern(lvwBlättern_modus.back, lvwDataInput, btnVor, btnBack, TxtItemId)

            BtnGetAllBidders.PerformClick()
            btnBack.Enabled = True

        End If



    End Sub

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        Dim iAnzahl As Integer = 0
        Try
            If frmMain.frmManage.lvwEiSoCockpit.SelectedItems.Count > 0 Then

                btnVor.Enabled = False

                Call setLvwView_blättern(lvwBlättern_modus.vor, lvwDataInput, btnVor, btnBack, TxtItemId)

                BtnGetAllBidders.PerformClick()
                btnVor.Enabled = True

            End If

        Catch ex As Exception
            btnVor.Enabled = True
            btnBack.Enabled = True
        End Try
    End Sub

    '###########################################
    '# >> Nur Gebote anzeigen 
    '###########################################
    Private Sub chkNurGeboteAnzeigen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNurGeboteAnzeigen.CheckedChanged

        If chkNurGeboteAnzeigen.Checked = True Then
            frmMain.frmManage.chkGebote.Checked = True
            frmMain.frmManage.lvwEiSoCockpit.Items(0).Selected = True
        Else
            frmMain.frmManage.chkGebote.Checked = False
            frmMain.frmManage.lvwEiSoCockpit.Items(0).Selected = True
        End If

    End Sub

    Private Sub btnSyncEmails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

