Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch
    Private timer As Timer

    Public Sub New()
        InitializeComponent()
        stopwatch = New Stopwatch()
        timer = New Timer()
        AddHandler timer.Tick, AddressOf OnTimedEvent
        timer.Interval = 1000 ' 1 second interval
    End Sub

    Private Sub OnTimedEvent(sender As Object, e As EventArgs)
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim submission As New Submission With {
                .SubmissionName = txtName.Text,
                .SubmissionEmail = txtEmail.Text,
                .SubmissionPhoneNumber = txtPhoneNumber.Text,
                .SubmissionGitHubLink = txtGitHubLink.Text,
                .SubmissionStopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
            }

            Dim httpClient As New HttpClient()
            Dim content As New StringContent(JsonConvert.SerializeObject(submission), Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = httpClient.PostAsync("http://localhost:3000/submit", content).Result

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission received")
            Else
                MessageBox.Show("Failed to submit")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

End Class

Public Class Submission
    Public Property SubmissionName As String
    Public Property SubmissionEmail As String
    Public Property SubmissionPhoneNumber As String
    Public Property SubmissionGitHubLink As String
    Public Property SubmissionStopwatchTime As String
End Class
