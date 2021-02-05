Imports MySql.Data.MySqlClient
Imports System.IO
Public Class manageCandidate
    Public connection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim command As New MySqlCommand("SELECT `Can_id`, `Can_name`, `Can_course`, `Can_position` , `Can_manifesto`, `Can_pic` FROM candidate WHERE `Can_id` = @ID", connection)
        command.Parameters.Add("@ID", MySqlDbType.UInt64).Value = searchId.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        Try

            adapter.Fill(table)

            Dim imgByte() As Byte

            If table.Rows.Count = 1 Then

                Can_id.Text = table(0)(0)
                Can_name.Text = table(0)(1)
                Can_course.Text = table(0)(2)
                Can_manifesto.Text = table(0)(3)
                imgByte = table(0)(4)

                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)

            Else

                MessageBox.Show("No Data Found")

                Can_id.Text = ""
                Can_name.Text = ""
                Can_course.Text = ""
                Can_manifesto.Text = ""

                PictureBox1.Image = Nothing

            End If

        Catch ex As Exception

            MessageBox.Show("ERROR")

            Can_id.Text = ""
            Can_name.Text = ""
            Can_course.Text = ""
            Can_manifesto.Text = ""

            PictureBox1.Image = Nothing

        End Try
    End Sub

    Private Sub manageCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class