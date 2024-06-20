Imports System.Diagnostics

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
        Dim submission As New SubmissionData With {
            .SubmissionName = txtName.Text,
            .SubmissionEmail = txtEmail.Text,
            .SubmissionPhoneNumber = txtPhoneNumber.Text,
            .SubmissionGitHubLink = txtGitHubLink.Text,
            .SubmissionStopwatchTime = stopwatch.Elapsed
        }

        ' Code to submit the form data to the backend goes here
    End Sub

End Class

Public Class SubmissionData
    Public Property SubmissionName As String
    Public Property SubmissionEmail As String
    Public Property SubmissionPhoneNumber As String
    Public Property SubmissionGitHubLink As String
    Public Property SubmissionStopwatchTime As TimeSpan
End Class





