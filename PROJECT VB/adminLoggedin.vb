Public Class adminLoggedin
    Private Sub SignUpCandidateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpCandidateToolStripMenuItem.Click
        signUpCandidate.Show()
    End Sub

    Private Sub ViewCandidateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCandidateToolStripMenuItem.Click
        viewCandidate.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub ViewResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewResultToolStripMenuItem.Click
        viewResult.Show()
    End Sub
End Class