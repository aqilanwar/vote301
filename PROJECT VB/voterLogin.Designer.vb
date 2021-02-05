<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class voterLogin
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voterLogin))
        Me.submit = New System.Windows.Forms.Button()
        Me.Voter_pass = New System.Windows.Forms.TextBox()
        Me.Voter_id = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(291, 153)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(94, 23)
        Me.submit.TabIndex = 22
        Me.submit.Text = "LOGIN"
        '
        'Voter_pass
        '
        Me.Voter_pass.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_pass.Location = New System.Drawing.Point(161, 105)
        Me.Voter_pass.Name = "Voter_pass"
        Me.Voter_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Voter_pass.Size = New System.Drawing.Size(220, 22)
        Me.Voter_pass.TabIndex = 21
        '
        'Voter_id
        '
        Me.Voter_id.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_id.Location = New System.Drawing.Point(161, 52)
        Me.Voter_id.Name = "Voter_id"
        Me.Voter_id.Size = New System.Drawing.Size(220, 22)
        Me.Voter_id.TabIndex = 19
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswordLabel.Location = New System.Drawing.Point(162, 77)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(88, 23)
        Me.PasswordLabel.TabIndex = 20
        Me.PasswordLabel.Text = "&PASSWORD"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(160, 26)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(169, 23)
        Me.UsernameLabel.TabIndex = 17
        Me.UsernameLabel.Text = "&STUDENT ID"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(16, 16)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(133, 141)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 18
        Me.LogoPictureBox.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(163, 130)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 13)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "default password"
        '
        'voterLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Voter_pass)
        Me.Controls.Add(Me.Voter_id)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "voterLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Voter Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submit As Button
    Friend WithEvents Voter_pass As TextBox
    Friend WithEvents Voter_id As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
