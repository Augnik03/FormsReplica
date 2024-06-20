<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.lblStopwatchTime = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(30, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(407, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Augnik, Slidely Task 2 - View Submissions"
        ' 
        ' lblName
        ' 
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblName.Location = New System.Drawing.Point(30, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(30, 110)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(55, 23)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        ' 
        ' lblPhoneNumber
        ' 
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(30, 160)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(131, 23)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number:"
        ' 
        ' lblGitHubLink
        ' 
        Me.lblGitHubLink.AutoSize = True
        Me.lblGitHubLink.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblGitHubLink.Location = New System.Drawing.Point(30, 210)
        Me.lblGitHubLink.Name = "lblGitHubLink"
        Me.lblGitHubLink.Size = New System.Drawing.Size(103, 23)
        Me.lblGitHubLink.TabIndex = 4
        Me.lblGitHubLink.Text = "GitHub Link:"
        ' 
        ' lblStopwatchTime
        ' 
        Me.lblStopwatchTime.AutoSize = True
        Me.lblStopwatchTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStopwatchTime.Location = New System.Drawing.Point(30, 260)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(135, 23)
        Me.lblStopwatchTime.TabIndex = 5
        Me.lblStopwatchTime.Text = "Stopwatch Time:"
        ' 
        ' txtName
        ' 
        Me.txtName.Location = New System.Drawing.Point(180, 60)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 27)
        Me.txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        Me.txtEmail.Location = New System.Drawing.Point(180, 110)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(200, 27)
        Me.txtEmail.TabIndex = 7
        ' 
        ' txtPhoneNumber
        ' 
        Me.txtPhoneNumber.Location = New System.Drawing.Point(180, 160)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 27)
        Me.txtPhoneNumber.TabIndex = 8
        ' 
        ' txtGitHubLink
        ' 
        Me.txtGitHubLink.Location = New System.Drawing.Point(180, 210)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.ReadOnly = True
        Me.txtGitHubLink.Size = New System.Drawing.Size(200, 27)
        Me.txtGitHubLink.TabIndex = 9
        ' 
        ' txtStopwatchTime
        ' 
        Me.txtStopwatchTime.Location = New System.Drawing.Point(180, 260)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(200, 27)
        Me.txtStopwatchTime.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(45, 320)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(120, 50)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(223, 320)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(120, 50)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 400)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.lblGitHubLink)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
