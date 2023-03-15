

Public Class frmYABE_Bug2Mantis

    Dim mantis As New clsMantis

    '# Wirkliches Laden des Formulars 
    Private Sub laden()
        Try

            '# Alle entsprechenden Felder laden von der Mantis Klasse
            Call mantis.getIssueProject(projectComboBox)
            Call mantis.getProjectVersions(My.Settings.app_mantis_default_project, versionComboBox)
            Call mantis.getProjectCategories(My.Settings.app_mantis_default_project, categoryComboBox)
            Call mantis.getPriority(priorityComboBox)
            Call mantis.getServertiy(severityComboBox)
            Call mantis.getReproduce(reproducibilityComboBox)

        Catch ex As Exception
            Call debug_message(ex, "MantisConnect - laden")
        End Try
    End Sub

    Private Sub frmBugreport2Mantis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call laden()
    End Sub

    '# Abschicken des Fehlers 
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim aryList As New ArrayList

        aryList.Add(txtTitel.Text)
        aryList.Add(txtBeschreibung.Text)

        aryList.Add(projectComboBox.Text)
        aryList.Add(versionComboBox.Text)
        aryList.Add(categoryComboBox.Text)
        aryList.Add(priorityComboBox.Text)
        aryList.Add(severityComboBox.Text)
        aryList.Add(reproducibilityComboBox.Text)

        Call mantis.setNewIssue(aryList, projectComboBox, priorityComboBox, severityComboBox, categoryComboBox, reproducibilityComboBox)
        'Call mantis.setNewIssue(aryList)


    End Sub

    Private Sub projectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles projectComboBox.SelectedIndexChanged


        Call mantis.getProjectVersions(10, versionComboBox)
        Call mantis.getProjectCategories(10, categoryComboBox)
    End Sub
End Class