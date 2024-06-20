<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubLink = New Label()
        lblStopwatchTime = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitle.Location = New Point(30, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(413, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Augnik, Slidely Task 2 - Create Submission"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 10.0F)
        lblName.Location = New Point(30, 60)
        lblName.Name = "lblName"
        lblName.Size = New Size(60, 23)
        lblName.TabIndex = 1
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10.0F)
        lblEmail.Location = New Point(30, 110)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(55, 23)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email:"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Font = New Font("Segoe UI", 10.0F)
        lblPhoneNumber.Location = New Point(30, 160)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(131, 23)
        lblPhoneNumber.TabIndex = 3
        lblPhoneNumber.Text = "Phone Number:"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Font = New Font("Segoe UI", 10.0F)
        lblGitHubLink.Location = New Point(30, 210)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(103, 23)
        lblGitHubLink.TabIndex = 4
        lblGitHubLink.Text = "GitHub Link:"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Font = New Font("Segoe UI", 10.0F)
        lblStopwatchTime.Location = New Point(30, 260)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(135, 23)
        lblStopwatchTime.TabIndex = 5
        lblStopwatchTime.Text = "Stopwatch Time:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(180, 60)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 27)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(180, 110)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 27)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(180, 160)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(200, 27)
        txtPhoneNumber.TabIndex = 8
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(180, 210)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(200, 27)
        txtGitHubLink.TabIndex = 9
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(180, 260)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(200, 27)
        txtStopwatchTime.TabIndex = 10
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(250, 320)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(145, 50)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.LightBlue
        btnToggleStopwatch.FlatAppearance.BorderSize = 0
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.ForeColor = Color.Black
        btnToggleStopwatch.Location = New Point(30, 320)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(200, 50)
        btnToggleStopwatch.TabIndex = 12
        btnToggleStopwatch.Text = "Start/Stop Stopwatch"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(539, 492)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblTitle)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
End Class
