Public Class MainForm
    ' Define submissionsList here or retrieve it from another source
    Private submissionsList As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        ' Initialize submissionsList with some data
        submissionsList = New List(Of Submission)()
        ' Add some sample submissions (replace this with your actual data)
        submissionsList.Add(New Submission With {
            .Name = "John Doe",
            .Email = "john@example.com",
            .PhoneNumber = "123-456-7890",
            .GitHubLink = "https://github.com/johndoe",
            .StopwatchTime = TimeSpan.FromMinutes(10) ' Sample stopwatch time
        })
        submissionsList.Add(New Submission With {
            .Name = "Jane Smith",
            .Email = "jane@example.com",
            .PhoneNumber = "987-654-3210",
            .GitHubLink = "https://github.com/janesmith",
            .StopwatchTime = TimeSpan.FromMinutes(15) ' Sample stopwatch time
        })
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm(submissionsList)
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()
    End Sub
End Class
