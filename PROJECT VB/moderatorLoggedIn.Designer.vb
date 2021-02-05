<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class moderatorLoggedIn
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CandidateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ManageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.VoterToolStripMenuItem, Me.CandidateToolStripMenuItem})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.LoginToolStripMenuItem.Text = "[Moderator]"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AdminToolStripMenuItem.Text = "Sign Up New Admin"
        '
        'VoterToolStripMenuItem
        '
        Me.VoterToolStripMenuItem.Name = "VoterToolStripMenuItem"
        Me.VoterToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VoterToolStripMenuItem.Text = "Sign Up Voter"
        '
        'CandidateToolStripMenuItem
        '
        Me.CandidateToolStripMenuItem.Name = "CandidateToolStripMenuItem"
        Me.CandidateToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CandidateToolStripMenuItem.Text = "Logout"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoterToolStripMenuItem1, Me.AdminToolStripMenuItem1})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ManageToolStripMenuItem.Text = "View"
        '
        'VoterToolStripMenuItem1
        '
        Me.VoterToolStripMenuItem1.Name = "VoterToolStripMenuItem1"
        Me.VoterToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.VoterToolStripMenuItem1.Text = "Voter"
        '
        'AdminToolStripMenuItem1
        '
        Me.AdminToolStripMenuItem1.Name = "AdminToolStripMenuItem1"
        Me.AdminToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AdminToolStripMenuItem1.Text = "Admin"
        '
        'moderatorLoggedIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "moderatorLoggedIn"
        Me.Text = "[MODERATOR] - Arecs Voting System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CandidateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem1 As ToolStripMenuItem
End Class
