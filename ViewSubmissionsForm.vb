Imports System.Timers

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)
    Private stopwatch As Stopwatch
    Private timer As System.Timers.Timer

    Public Sub New(submissionsList As List(Of Submission))
        InitializeComponent()
        submissions = submissionsList
        stopwatch = New Stopwatch()
        timer = New System.Timers.Timer(1000) ' 1 second interval
        AddHandler timer.Elapsed, AddressOf OnTimedEvent
        timer.Start()
        DisplaySubmission()
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhoneNumber.Text = submission.PhoneNumber
            txtGitHubLink.Text = submission.GitHubLink
            UpdateStopwatchTime()
        End If
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            txtStopwatchTime.Invoke(Sub() UpdateStopwatchTime())
            stopwatch.Start()
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

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As TimeSpan
End Class
