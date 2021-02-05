Imports MySql.Data.MySqlClient

Public Class manageAdmin
    Public connection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")

    Private Sub manageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        str = "SELECT Ad_id, Ad_name, Ad_email FROM Admin "
        Try
            connection.Open()
            Dim search As New MySqlDataAdapter(str, connection)
            Dim ds As New DataSet
            search.Fill(ds, "Admin")
            DataGridView1.DataSource = ds.Tables("Admin")
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class