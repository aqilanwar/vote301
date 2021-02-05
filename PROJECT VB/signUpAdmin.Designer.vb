<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signupAdmin
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
        Me.Ad_name = New System.Windows.Forms.TextBox()
        Me.Ad_email = New System.Windows.Forms.TextBox()
        Me.Ad_pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.confirm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Ad_name
        '
        Me.Ad_name.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ad_name.Location = New System.Drawing.Point(250, 145)
        Me.Ad_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ad_name.Name = "Ad_name"
        Me.Ad_name.Size = New System.Drawing.Size(366, 27)
        Me.Ad_name.TabIndex = 0
        '
        'Ad_email
        '
        Me.Ad_email.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ad_email.Location = New System.Drawing.Point(250, 199)
        Me.Ad_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ad_email.Name = "Ad_email"
        Me.Ad_email.Size = New System.Drawing.Size(366, 27)
        Me.Ad_email.TabIndex = 2
        '
        'Ad_pass
        '
        Me.Ad_pass.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ad_pass.Location = New System.Drawing.Point(250, 253)
        Me.Ad_pass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ad_pass.Name = "Ad_pass"
        Me.Ad_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Ad_pass.Size = New System.Drawing.Size(161, 27)
        Me.Ad_pass.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 413)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'confirm
        '
        Me.confirm.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm.Location = New System.Drawing.Point(250, 318)
        Me.confirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.confirm.Name = "confirm"
        Me.confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirm.Size = New System.Drawing.Size(161, 27)
        Me.confirm.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 253)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 37)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "PASSWORD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(51, 139)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 37)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "FULL NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(51, 307)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 74)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "CONFIRM " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PASSWORD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(51, 199)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 37)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "EMAIL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(243, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 40)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ADMIN SIGN-UP"
        '
        'signupAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Ad_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Ad_email)
        Me.Controls.Add(Me.Ad_pass)
        Me.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "signupAdmin"
        Me.Text = "[Moderator] Sign Up Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ad_name As TextBox
    Friend WithEvents Ad_email As TextBox
    Friend WithEvents Ad_pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents confirm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
