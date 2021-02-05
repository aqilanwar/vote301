<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class moderatorLogin
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
    Friend WithEvents Mod_email As System.Windows.Forms.TextBox
    Friend WithEvents Mod_pass As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(moderatorLogin))
        Me.Mod_email = New System.Windows.Forms.TextBox()
        Me.Mod_pass = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mod_email
        '
        Me.Mod_email.Location = New System.Drawing.Point(174, 44)
        Me.Mod_email.Name = "Mod_email"
        Me.Mod_email.Size = New System.Drawing.Size(220, 20)
        Me.Mod_email.TabIndex = 1
        '
        'Mod_pass
        '
        Me.Mod_pass.Location = New System.Drawing.Point(174, 101)
        Me.Mod_pass.Name = "Mod_pass"
        Me.Mod_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Mod_pass.Size = New System.Drawing.Size(220, 20)
        Me.Mod_pass.TabIndex = 3
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(300, 157)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "LOGIN"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(23, 24)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(133, 141)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 13
        Me.LogoPictureBox.TabStop = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswordLabel.Location = New System.Drawing.Point(173, 73)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(88, 23)
        Me.PasswordLabel.TabIndex = 16
        Me.PasswordLabel.Text = "&PASSWORD"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(171, 18)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(169, 23)
        Me.UsernameLabel.TabIndex = 15
        Me.UsernameLabel.Text = "&MODERATOR EMAIL"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'moderatorLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Mod_pass)
        Me.Controls.Add(Me.Mod_email)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "moderatorLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Moderator Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
End Class
