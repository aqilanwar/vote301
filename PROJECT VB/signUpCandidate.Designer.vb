<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signUpCandidate
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
        Me.Can_id = New System.Windows.Forms.TextBox()
        Me.Can_name = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Can_course = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Can_manifesto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Can_id
        '
        Me.Can_id.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_id.Location = New System.Drawing.Point(221, 187)
        Me.Can_id.Margin = New System.Windows.Forms.Padding(2)
        Me.Can_id.Name = "Can_id"
        Me.Can_id.Size = New System.Drawing.Size(150, 27)
        Me.Can_id.TabIndex = 4
        '
        'Can_name
        '
        Me.Can_name.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_name.Location = New System.Drawing.Point(221, 146)
        Me.Can_name.Margin = New System.Windows.Forms.Padding(2)
        Me.Can_name.Name = "Can_name"
        Me.Can_name.Size = New System.Drawing.Size(296, 27)
        Me.Can_name.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(685, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(629, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Select Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(605, 143)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Can_course
        '
        Me.Can_course.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_course.FormattingEnabled = True
        Me.Can_course.Items.AddRange(New Object() {"CS110", "CS230", "CS245", "CS246", "CS251", "CS253"})
        Me.Can_course.Location = New System.Drawing.Point(221, 234)
        Me.Can_course.Name = "Can_course"
        Me.Can_course.Size = New System.Drawing.Size(110, 27)
        Me.Can_course.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(45, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 37)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "COURSE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(45, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 37)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "STUDENT ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(45, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 37)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "MANIFESTO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(45, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 37)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "FULL NAME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(622, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 37)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "PICTURE"
        '
        'Can_manifesto
        '
        Me.Can_manifesto.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_manifesto.Location = New System.Drawing.Point(223, 272)
        Me.Can_manifesto.Margin = New System.Windows.Forms.Padding(2)
        Me.Can_manifesto.Multiline = True
        Me.Can_manifesto.Name = "Can_manifesto"
        Me.Can_manifesto.Size = New System.Drawing.Size(296, 110)
        Me.Can_manifesto.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(243, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 40)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CANDIDATE SIGN-UP"
        '
        'signUpCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Can_id)
        Me.Controls.Add(Me.Can_manifesto)
        Me.Controls.Add(Me.Can_name)
        Me.Controls.Add(Me.Can_course)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Name = "signUpCandidate"
        Me.Text = "[Moderator] Sign Up Candidate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Can_id As TextBox
    Friend WithEvents Can_name As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Can_course As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Can_manifesto As TextBox
    Friend WithEvents Label6 As Label
End Class
