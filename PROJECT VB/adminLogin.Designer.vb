<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class adminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminLogin))
        Me.submit = New System.Windows.Forms.Button()
        Me.Ad_pass = New System.Windows.Forms.TextBox()
        Me.Ad_email = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(291, 153)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(94, 23)
        Me.submit.TabIndex = 16
        Me.submit.Text = "LOGIN"
        '
        'Ad_pass
        '
        Me.Ad_pass.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ad_pass.Location = New System.Drawing.Point(161, 105)
        Me.Ad_pass.Name = "Ad_pass"
        Me.Ad_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Ad_pass.Size = New System.Drawing.Size(220, 22)
        Me.Ad_pass.TabIndex = 15
        '
        'Ad_email
        '
        Me.Ad_email.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ad_email.Location = New System.Drawing.Point(161, 52)
        Me.Ad_email.Name = "Ad_email"
        Me.Ad_email.Size = New System.Drawing.Size(220, 22)
        Me.Ad_email.TabIndex = 13
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswordLabel.Location = New System.Drawing.Point(162, 77)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(88, 23)
        Me.PasswordLabel.TabIndex = 14
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
        Me.UsernameLabel.TabIndex = 11
        Me.UsernameLabel.Text = "&ADMIN EMAIL"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(16, 16)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(133, 141)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 12
        Me.LogoPictureBox.TabStop = False
        '
        'adminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Ad_pass)
        Me.Controls.Add(Me.Ad_email)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adminLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submit As Button
    Friend WithEvents Ad_pass As TextBox
    Friend WithEvents Ad_email As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
End Class
