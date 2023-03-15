Imports Futureware.MantisConnect ' Mantis einbinden 
Imports System.Net

'##################################
'# >> Mantis SOAP Connector
'##################################
Public Class clsMantis

    Dim nc As NetworkCredential
    Dim session As New Session(My.Settings.app_mantis_url, My.Settings.app_mantis_usr, My.Settings.app_mantis_pwd, nc)

    '# Übertragen eines Neuen Fehleres 
    Public Function setNewIssue(ByVal aryList As ArrayList, ByVal projectComboBox As ComboBox, ByVal priorityComboBox As ComboBox, ByVal severityComboBox As ComboBox, ByVal categoryComboBox As ComboBox, ByVal reproducibilityComboBox As ComboBox) As Boolean

        Try


            session.Connect() 'Verbindung herstellen 

            '# Neuen Fehlerbericht erzeugen 
            Dim Issue As New Issue()



            Issue.Project = New ObjectRef(aryList.Item(2).ToString)
            'Issue.ProductVersion = aryList.Item(3).ToString
            'Issue.Category = New ObjectRef(aryList.Item(4).ToString)
            'Issue.Priority = New ObjectRef(aryList.Item(5).ToString)
            'Issue.Severity = New ObjectRef(aryList.Item(6).ToString)
            'Issue.Reproducibility = New ObjectRef(aryList.Item(7).ToString)

            ' Issue.Project = New ObjectRef(projectComboBox.Text)
            'Issue.Priority = New ObjectRef(priorityComboBox.Text)
            'Issue.Severity = New ObjectRef(severityComboBox.Text)
            'Issue.Reproducibility  = New ObjectRef(reproducibilityComboBox.Text)
            Issue.Category = New ObjectRef(categoryComboBox.Text)


            Issue.Summary = aryList.Item(0).ToString ' Kurzüberblick
            Issue.Description = aryList.Item(1).ToString ' Beschreibung
            Issue.ReportedBy = New User()
            Issue.ReportedBy.Name = session.Username

            session.Request.IssueAdd(Issue) ' Issue eintragen ! 

            Return True
        Catch ex As Exception
            Call debug_message(ex, "setNewIssue2Mantis")
            Return False
        End Try
    End Function

    '# Projekt holen 
    Public Function getIssueProject(ByRef cmbIssue As ComboBox) As Boolean


        cmbIssue.DataSource = session.Request.UserGetAccesibleProjects()
        cmbIssue.DisplayMember = "Name"
        cmbIssue.ValueMember = "Id"

        Return True

    End Function

    '# Prioritäten abrufen 
    Public Function getPriority(ByRef cmbIssue As ComboBox) As Boolean

        cmbIssue.DataSource = session.Config.PriorityEnum.Labels

        Return True
    End Function

    '# 
    Public Function getServertiy(ByRef cmbIssue As ComboBox) As Boolean

        cmbIssue.DataSource = session.Config.SeverityEnum.Labels

        Return True
    End Function

    '# Reproduzierbarkeitsgrad 
    Public Function getReproduce(ByRef cmbIssue As ComboBox) As Boolean

        cmbIssue.DataSource = session.Config.ReproducibilityEnum.Labels

        Return True
    End Function

    '# Projektkategorien abrufen 
    Public Function getProjectCategories(ByVal iProjectID As Integer, ByRef cmbIssue As ComboBox) As Boolean
        cmbIssue.DataSource = session.Request.ProjectGetCategories(iProjectID)
        cmbIssue.DisplayMember = "Name"
        Return True
    End Function

    '# Projektversionen 
    Public Function getProjectVersions(ByVal iProjectID As Integer, ByRef cmbIssue As ComboBox) As Boolean

        cmbIssue.DataSource = session.Request.ProjectGetVersions(iProjectID)
        cmbIssue.DisplayMember = "Name"
        Return True
    End Function
End Class

