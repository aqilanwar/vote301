Imports MySql.Data.MySqlClient


Public Class voterLoggedin
    Public sID As String
    Public Sub New(ByVal s_ID As String)
        InitializeComponent()
        sID = s_ID
    End Sub

    Public connection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
    Dim dr As MySqlDataReader

    Private Sub voterLoggedin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        connection.Open()
        Dim command As New MySqlCommand("SELECT * FROM candidate ", connection)
        dr = command.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr.Item("Can_pic"), dr.Item("Can_name").ToString, dr.Item("Can_course").ToString, dr.Item("Can_manifesto").ToString, dr.Item("Can_id").ToString, dr.Item("Can_id").ToString)
        End While

        dr.Close()
        connection.Close()

        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 100
        Next

        Dim imagecolumn = DirectCast(DataGridView1.Columns("Column1"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim v As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Dim name As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim ans As String
        ans = MsgBox("Are you sure to vote " + name + " ?", vbYesNo)

        If ans = vbYes Then
            Try
                connection.Open()
                Dim command As New MySqlCommand("UPDATE candidate set Can_vote=Can_vote + 1 WHERE Can_id=@ID ", connection)
                command.Parameters.Add("@ID", MySqlDbType.UInt64).Value = v
                command.ExecuteNonQuery()

                Dim command2 As New MySqlCommand("UPDATE voter set Can_id=@VID WHERE Voter_id=@ID ", connection)
                command2.Parameters.Add("@VID", MySqlDbType.UInt64).Value = v
                command2.Parameters.Add("@ID", MySqlDbType.UInt64).Value = sID

                command2.ExecuteNonQuery()
                MsgBox("Thank you for voting !", MsgBoxStyle.Information)
                connection.Close()
                Me.Close()
                main.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
                connection.Close()
            End Try

        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub
End Class