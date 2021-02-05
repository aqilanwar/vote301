<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voterMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VoterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoteNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeeMyVoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VoterToolStripMenuItem
        '
        Me.VoterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoteNowToolStripMenuItem, Me.SeeMyVoteToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.VoterToolStripMenuItem.Name = "VoterToolStripMenuItem"
        Me.VoterToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VoterToolStripMenuItem.Text = "[Voter]"
        '
        'VoteNowToolStripMenuItem
        '
        Me.VoteNowToolStripMenuItem.Name = "VoteNowToolStripMenuItem"
        Me.VoteNowToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.VoteNowToolStripMenuItem.Text = "Vote Now"
        '
        'SeeMyVoteToolStripMenuItem
        '
        Me.SeeMyVoteToolStripMenuItem.Name = "SeeMyVoteToolStripMenuItem"
        Me.SeeMyVoteToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SeeMyVoteToolStripMenuItem.Text = "See My Vote"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'voterMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "voterMenu"
        Me.Text = "[Voter] Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VoterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoteNowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeeMyVoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
