<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminLoggedin
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
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignUpCandidateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCandidateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.ManageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignUpCandidateToolStripMenuItem, Me.ViewResultToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'SignUpCandidateToolStripMenuItem
        '
        Me.SignUpCandidateToolStripMenuItem.Name = "SignUpCandidateToolStripMenuItem"
        Me.SignUpCandidateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SignUpCandidateToolStripMenuItem.Text = "Sign Up Candidate"
        '
        'ViewResultToolStripMenuItem
        '
        Me.ViewResultToolStripMenuItem.Name = "ViewResultToolStripMenuItem"
        Me.ViewResultToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewResultToolStripMenuItem.Text = "View Result"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCandidateToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'ViewCandidateToolStripMenuItem
        '
        Me.ViewCandidateToolStripMenuItem.Name = "ViewCandidateToolStripMenuItem"
        Me.ViewCandidateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewCandidateToolStripMenuItem.Text = "Candidate"
        '
        'adminLoggedin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROJECT_VB.My.Resources.Resources.CSC301_arecs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "adminLoggedin"
        Me.Text = "adminLoggedin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignUpCandidateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCandidateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
