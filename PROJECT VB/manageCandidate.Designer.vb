<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageCandidate
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.searchId = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Can_id = New System.Windows.Forms.TextBox()
        Me.Can_manifesto = New System.Windows.Forms.TextBox()
        Me.Can_name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Can_course = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'searchId
        '
        Me.searchId.Location = New System.Drawing.Point(367, 51)
        Me.searchId.Name = "searchId"
        Me.searchId.Size = New System.Drawing.Size(100, 20)
        Me.searchId.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(490, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Insert Student ID :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(584, 154)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(617, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Select Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(599, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 37)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "PICTURE"
        '
        'Can_id
        '
        Me.Can_id.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_id.Location = New System.Drawing.Point(211, 141)
        Me.Can_id.Margin = New System.Windows.Forms.Padding(2)
        Me.Can_id.Name = "Can_id"
        Me.Can_id.Size = New System.Drawing.Size(150, 27)
        Me.Can_id.TabIndex = 47
        '
        'Can_manifesto
        '
        Me.Can_manifesto.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_manifesto.Location = New System.Drawing.Point(211, 241)
        Me.Can_manifesto.Margin = New System.Windows.Forms.Padding(2)
        Me.Can_manifesto.Multiline = True
        Me.Can_manifesto.Name = "Can_manifesto"
        Me.Can_manifesto.Size = New System.Drawing.Size(296, 110)
        Me.Can_manifesto.TabIndex = 45
        '
        'Can_name
        '
        Me.Can_name.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_name.Location = New System.Drawing.Point(211, 99)
        Me.Can_name.Margin = New System.Windows.Forms.Padding(2)
        Me.Can_name.Name = "Can_name"
        Me.Can_name.Size = New System.Drawing.Size(296, 27)
        Me.Can_name.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(35, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 37)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "COURSE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(35, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 37)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "STUDENT ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(35, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 37)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "FULL NAME"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(35, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 37)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "MANIFESTO"
        '
        'Can_course
        '
        Me.Can_course.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can_course.FormattingEnabled = True
        Me.Can_course.Items.AddRange(New Object() {"CS110", "CS230", "CS245", "CS246", "CS251", "CS253"})
        Me.Can_course.Location = New System.Drawing.Point(211, 183)
        Me.Can_course.Name = "Can_course"
        Me.Can_course.Size = New System.Drawing.Size(110, 27)
        Me.Can_course.TabIndex = 58
        '
        'manageCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 495)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Can_course)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Can_id)
        Me.Controls.Add(Me.Can_manifesto)
        Me.Controls.Add(Me.Can_name)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.searchId)
        Me.Name = "manageCandidate"
        Me.Text = "[Moderator] Manage Candidate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents searchId As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Can_id As TextBox
    Friend WithEvents Can_manifesto As TextBox
    Friend WithEvents Can_name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Can_course As ComboBox
End Class
