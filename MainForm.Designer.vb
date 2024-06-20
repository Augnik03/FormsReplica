<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitle.Location = New Point(27, 31)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(400, 28)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Augnik, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.ForeColor = Color.Black
        btnViewSubmissions.Location = New Point(100, 154)
        btnViewSubmissions.Margin = New Padding(4, 5, 4, 5)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(200, 77)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnCreateNewSubmission.FlatStyle = FlatStyle.Flat
        btnCreateNewSubmission.ForeColor = Color.Black
        btnCreateNewSubmission.Location = New Point(100, 262)
        btnCreateNewSubmission.Margin = New Padding(4, 5, 4, 5)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(200, 77)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(447, 385)
        Controls.Add(lblTitle)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        Margin = New Padding(4, 5, 4, 5)
        Name = "MainForm"
        Text = "Main Form"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Friend WithEvents btnCreateNewSubmission As System.Windows.Forms.Button
End Class
