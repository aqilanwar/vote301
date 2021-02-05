Imports MySql.Data.MySqlClient
Public Class viewCandidate
    Public connection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
    Dim dr As MySqlDataReader

    Private Sub viewCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        Dim command As New MySqlCommand("SELECT * FROM candidate ", connection)
        dr = command.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr.Item("Can_pic"), dr.Item("Can_name").ToString, dr.Item("Can_course").ToString, dr.Item("Can_manifesto").ToString, dr.Item("Can_vote").ToString)
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

End Class