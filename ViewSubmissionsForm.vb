Imports System.Net.Http
Imports System.Timers
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of BackendSubmission)
    Private stopwatch As Stopwatch
    Private timer As System.Timers.Timer

    Public Sub New()
        InitializeComponent()
        stopwatch = New Stopwatch()
        timer = New System.Timers.Timer(1000) ' 1 second interval
        AddHandler timer.Elapsed, AddressOf OnTimedEvent
        timer.Start()
        FetchSubmissionsAsync()
    End Sub

    Private Async Sub FetchSubmissionsAsync()
        Try
            Dim httpClient As New HttpClient()
            Dim response As HttpResponseMessage = Await httpClient.GetAsync("http://localhost:3000/submissions")

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"JSON Response: {jsonResponse}") ' Debug: Show JSON response
                submissions = JsonConvert.DeserializeObject(Of List(Of BackendSubmission))(jsonResponse)
                If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                    Me.BeginInvoke(New Action(Sub() DisplaySubmission()))
                Else
                    MessageBox.Show("No submissions available.")
                End If
            Else
                MessageBox.Show("Failed to fetch submissions")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhoneNumber.Text = submission.PhoneNumber
            txtGitHubLink.Text = submission.GitHubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        If stopwatch.IsRunning Then
            txtStopwatchTime.BeginInvoke(New Action(Sub() UpdateStopwatchTime()))
        End If
    End Sub

    Private Sub UpdateStopwatchTime()
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub
End Class

Public Class BackendSubmission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class
