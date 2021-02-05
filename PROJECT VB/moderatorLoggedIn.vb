Public Class moderatorLoggedIn


    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        signupAdmin.Show()
    End Sub

    Private Sub VoterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoterToolStripMenuItem.Click
        signUpVoter.Show()
    End Sub

    Private Sub VoterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VoterToolStripMenuItem1.Click
        manageVoter.Show()

    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
        manageAdmin.Show()
    End Sub

    Private Sub CandidateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CandidateToolStripMenuItem.Click
        Me.Close()
        main.Show()
    End Sub
End Class