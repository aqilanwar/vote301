Imports MySql.Data.MySqlClient

Public Class main
    Private Sub ModeratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModeratorToolStripMenuItem.Click
        moderatorLogin.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim server_Status As String
        Dim MySqlConnection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
        Try
            MySqlConnection.Open()
            server_Status = "ONLINE"
        Catch ex As Exception
            ModeratorToolStripMenuItem.Enabled = False
            AdminToolStripMenuItem.Enabled = False
            VoterToolStripMenuItem.Enabled = False
            server_Status = "OFFLINE"
        End Try
        Label3.Text = server_Status
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        adminLogin.Show()
    End Sub

    Private Sub VoterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoterToolStripMenuItem.Click
        voterLogin.Show()
    End Sub
End Class