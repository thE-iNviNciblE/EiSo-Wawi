Imports System.IO
Imports Google.API.Search

Public Class frmYABE_Vorlageneditor

    Public iLoad As Integer = 1
    Public iCMBIndex As String = ""
    Public strPathVorlage As String = ""
    Public bIsload As Boolean = False
    Private bIsloading As Boolean = True

    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub frmTranslationEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = My.Settings.yabe_gui_translator_location
        Me.Size = My.Settings.yabe_gui_rechnungsdruck_size

        bIsload = True
        clsDatenbank_modul.getComboSprachen(cmbSprache)
        cmbSprache.SelectedIndex = 0
        clsDatenbank_modul.getComboGroups(cmbGruppierung)
        cmbGruppierung.SelectedIndex = frmMain.frmManage.cmbTranslationBereichAuswählen.SelectedIndex

        clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlage, iCMBIndex)
        Try
            cmbVorlage.SelectedIndex = 0
        Catch ex As Exception

        End Try


        bIsload = False
        Me.Text = cmbSprache.Text & " - " & clsDatenbank_modul.getTranslationText(cmbVorlage.Text, "lastUpdate")

        bIsloading = False

    End Sub

    Private Sub data()
        DHTMLControll.DOM.body.innerText = txtVorlageQuellcode.Text
    End Sub
    Private Sub btnAbschickenNewsletter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbschickenNewsletter.Click
        Dim strText As String = ""
        btnAbbrechen.Enabled = False
        btnAbschickenNewsletter.Enabled = False
        If LinkLabel1.Text = "HTML" Then
            strText = DHTMLControll.DOM.body.innerHTML
        Else
            strText = txtVorlageQuellcode.Text
        End If

        If clsDatenbank_modul.setTranslationText(cmbVorlage.Text, strText, cmbSprache.Text) = False Then
            MsgBox("Es ist ein Fehler beim '" & cmbVorlage.Text & "' in '" & cmbSprache.Text & "' Speichern aufgetreten" & vbCrLf & "Bitte erneut auf speichern klicken!", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Der Text '" & cmbVorlage.Text & "' in '" & cmbSprache.Text & "' wurde erfolgreich gespeichert!", MsgBoxStyle.Information)
            '  Me.Dispose()
        End If

        btnAbbrechen.Enabled = True
        btnAbschickenNewsletter.Enabled = True

    End Sub


    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked


        If LinkLabel1.Text = "HTML" Then
            LinkLabel1.Text = "Design"
            txtVorlageQuellcode.Visible = True
            txtVorlageQuellcode.Text = DHTMLControll.DOM.body.innerHTML
            DHTMLControll.Visible = False
        Else
            LinkLabel1.Text = "HTML"
            DHTMLControll.DOM.body.innerHTML = txtVorlageQuellcode.Text
            txtVorlageQuellcode.Visible = False
            DHTMLControll.Visible = True
        End If
    End Sub

    Private Sub Bold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bold.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_BOLD)

    End Sub

    Private Sub Hyperlink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hyperlink.Click

        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_HYPERLINK)
    End Sub

    Private Sub Suchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Suchen.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_FINDTEXT)
    End Sub

    Private Sub Bild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bild.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_IMAGE)
    End Sub

    Private Sub Redo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Redo.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_REDO)
    End Sub

    Private Sub Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Undo.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_UNDO)
    End Sub

    Private Sub NeuToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripButton.Click
        If DHTMLControll.DocumentHTML.Length > 0 Then

            If MessageBox.Show("Soll die Datei " & strPathVorlage & " wirklich geschlossen werden?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                DHTMLControll.DocumentHTML = ""
            End If
        End If

    End Sub

    Private Sub ÖffnenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripButton.Click


        OpenFileDialog1.Title = "YABE -> HTML Import"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            strPathVorlage = OpenFileDialog1.FileName

            DHTMLControll.DOM.body.innerHTML = ""
            txtVorlageQuellcode.Text = ""

            If LinkLabel1.Text = "HTML" Then
                DHTMLControll.DOM.body.innerHTML = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Else
                txtVorlageQuellcode.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If

            frmMain.master_Message_label.Text = "Lade Vorlage: " & OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SpeichernToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripButton.Click
        Dim strHTMLExport As String = ""

        SaveFileDialog1.Title = "YABE -> HTML Export"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strHTMLExport = SaveFileDialog1.FileName
        Else
            MsgBox("Es ist ein Fehler beim Speichern aufgetretten", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "YABE -> Fehler beim Speichern")
        End If


        If LinkLabel1.Text = "HTML" Then
            My.Computer.FileSystem.WriteAllText(strHTMLExport, DHTMLControll.DOM.body.innerHTML, False)
        Else
            My.Computer.FileSystem.WriteAllText(strHTMLExport, txtVorlageQuellcode.Text, False)
        End If

        MsgBox("Datei wurde unter '" & strHTMLExport & "' gespeichert", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "YABE - Datei gespeichert")


    End Sub

    Private Sub frmTranslationEditor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaden.Click
        Dim strFieldMapping As String = ""

        btnLaden.Enabled = False

        '#MsgBox(TranslateText("Hallo Welt", "de", "en"))


        '# Feldmapping holen 
        strFieldMapping = clsDatenbank_modul.getTranslate_l18n_mapping(cmbSprache.Text)


        txtVorlageQuellcode.Text = clsDatenbank_modul.getTranslationText(cmbVorlage.Text, "Text" & strFieldMapping)
        DHTMLControll.DOM.body.innerHTML = ""
        DHTMLControll.DOM.body.innerHTML = txtVorlageQuellcode.Text
        bIsload = True
        btnLaden.Enabled = True
    End Sub

    Private Sub cmbTranslationBereichAuswählen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSprache.SelectedIndexChanged

        If bIsloading = False Then
            btnLaden.PerformClick()
        End If

        'clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlage, cmbGruppierung.Text)

    End Sub

    Private Sub DHTMLControll_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DHTMLControll.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbVorlage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVorlage.SelectedIndexChanged
        If bIsloading = False Then
            Me.Text = cmbSprache.Text & " - " & clsDatenbank_modul.getTranslationText(cmbVorlage.Text, "lastUpdate")
            btnLaden.PerformClick()
        End If
    End Sub

    Private Sub cmbGruppierung_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGruppierung.SelectedIndexChanged
        clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlage, cmbGruppierung.Text)
        cmbVorlage.SelectedIndex = 0
    End Sub

    Private Sub NeueVorlageAnlegenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeueVorlageAnlegenToolStripMenuItem.Click
        Dim strNeuerName As String
        Dim iSel As Byte = 0

        strNeuerName = InputBox("Bitte geben Sie den neuen Vorlagennamen für den Bereich '" & cmbGruppierung.Text & "' ein", "Vorlagen Namen ändern")

        If Not strNeuerName = "" Then
            If clsDatenbank_modul.setTranslate_vorlage_neu(strNeuerName, cmbGruppierung.Text) = True Then
                '# Neuladen der Vorlagen 
                If clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlage, cmbGruppierung.Text) = True Then
                    cmbVorlage.SelectedIndex = cmbVorlage.Items.Count - 1
                End If
            End If
        End If

    End Sub

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click

        If MsgBox("Möchten Sie die Vorlage '" & cmbVorlage.Text & "' wirklich unwiderruflich löschen?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.MsgBoxSetForeground, "Vorlage löschen") = MsgBoxResult.Yes Then

            '# Löschen einleiten 
            If clsDatenbank_modul.setTranslate_vorlage_delete(cmbVorlage.Text) = True Then

                '# Neuladen der Vorlagen 
                If clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlage, cmbGruppierung.Text) = True Then

                    If cmbVorlage.Items.Count > 0 Then
                        cmbVorlage.SelectedIndex = 0
                    End If

                End If

                MsgBox("Die Vorlage '" & cmbVorlage.Text & "' wurde erfolgreich gelöscht", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Vorlage löschen")
            End If
        End If

    End Sub

    Private Sub UmbennenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UmbennenToolStripMenuItem.Click
        Dim strNeuerName As String
        Dim iSel As Byte = 0
        strNeuerName = InputBox("Bitte geben Sie den neuen Kategorienamen für '" & cmbVorlage.Text & "' ein", "Vorlagen Namen ändern")

        If Not strNeuerName = "" Then
            If clsDatenbank_modul.setTranslate_vorlage_renamme(strNeuerName, cmbVorlage.Text) = True Then
                iSel = cmbVorlage.SelectedIndex

                If clsDatenbank_modul.getComboEmailTextBereiche(cmbVorlage, cmbGruppierung.Text) = True Then
                    cmbVorlage.SelectedIndex = iSel
                End If

                MsgBox("Die Vorlage wurde erfolgreich umbenannt")
            End If

        End If

    End Sub

    Private Sub DruckenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripButton.Click
        DHTMLControll.PrintDocument()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Static bIsClicked As Boolean = False

        If bIsClicked = False Then
            DHTMLControll.BrowseMode = True
            bIsClicked = True
        Else
            DHTMLControll.BrowseMode = False
            bIsClicked = False
        End If

    End Sub

    Private Sub frmTranslationEditor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.yabe_gui_translator_location = Me.Location
        My.Settings.yabe_gui_rechnungsdruck_size = Me.Size
        My.Settings.Save()
    End Sub
End Class