<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signUpVoter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.confirm = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Voter_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Voter_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Voter_course = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Voter_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Voter_pass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(54, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 74)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "CONFIRM " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PASSWORD"
        '
        'confirm
        '
        Me.confirm.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm.Location = New System.Drawing.Point(230, 324)
        Me.confirm.Name = "confirm"
        Me.confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirm.Size = New System.Drawing.Size(277, 27)
        Me.confirm.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(265, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "SIGN UP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "FULL NAME"
        '
        'Voter_name
        '
        Me.Voter_name.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_name.Location = New System.Drawing.Point(230, 91)
        Me.Voter_name.Name = "Voter_name"
        Me.Voter_name.Size = New System.Drawing.Size(277, 25)
        Me.Voter_name.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 37)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "STUDENT ID"
        '
        'Voter_id
        '
        Me.Voter_id.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_id.Location = New System.Drawing.Point(230, 133)
        Me.Voter_id.Name = "Voter_id"
        Me.Voter_id.Size = New System.Drawing.Size(277, 25)
        Me.Voter_id.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 37)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "COURSE"
        '
        'Voter_course
        '
        Me.Voter_course.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_course.FormattingEnabled = True
        Me.Voter_course.Items.AddRange(New Object() {"CS110", "CS230", "CS245", "CS246", "CS251", "CS253"})
        Me.Voter_course.Location = New System.Drawing.Point(230, 176)
        Me.Voter_course.Name = "Voter_course"
        Me.Voter_course.Size = New System.Drawing.Size(110, 25)
        Me.Voter_course.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 37)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "EMAIL"
        '
        'Voter_email
        '
        Me.Voter_email.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_email.Location = New System.Drawing.Point(230, 220)
        Me.Voter_email.Name = "Voter_email"
        Me.Voter_email.Size = New System.Drawing.Size(277, 25)
        Me.Voter_email.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 37)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "PASSWORD"
        '
        'Voter_pass
        '
        Me.Voter_pass.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_pass.Location = New System.Drawing.Point(230, 264)
        Me.Voter_pass.Name = "Voter_pass"
        Me.Voter_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Voter_pass.Size = New System.Drawing.Size(277, 27)
        Me.Voter_pass.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(223, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 40)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "VOTER SIGN-UP"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(420, 294)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "default password"
        '
        'signUpVoter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Voter_pass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Voter_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Voter_course)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Voter_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Voter_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Label7)
        Me.Name = "signUpVoter"
        Me.Text = "[Moderator] Sign Up Voter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents confirm As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Voter_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Voter_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Voter_course As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Voter_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Voter_pass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
