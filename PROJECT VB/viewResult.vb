Imports MySql.Data.MySqlClient
Imports System.IO
Public Class viewResult
    Public conn As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
    Private Sub viewResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("Select * from(select Can_name, Can_pic,Can_vote from candidate order by Can_vote desc limit 3) candidate ", conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        Try

            adapter.Fill(table)

            Dim imgByte() As Byte
            Dim imgByte2() As Byte
            Dim imgByte3() As Byte

            If table.Rows.Count = 3 Then


                president_name.Text = table(0)(0)
                vicepresident_name.Text = table(1)(0)
                secretary_name.Text = table(2)(0)

                imgByte = table(0)(1)
                imgByte2 = table(1)(1)
                imgByte3 = table(2)(1)

                Dim ms As New MemoryStream(imgByte)
                Dim ms2 As New MemoryStream(imgByte2)
                Dim ms3 As New MemoryStream(imgByte3)

                president_pic.Image = Image.FromStream(ms)
                vicepresident_pic.Image = Image.FromStream(ms2)
                secretary_pic.Image = Image.FromStream(ms3)

            Else

                MessageBox.Show("No Data Found")


                PictureBox1.Image = Nothing

            End If

        Catch ex As Exception

            MessageBox.Show("ERROR")


            PictureBox1.Image = Nothing

        End Try
    End Sub

    Private Sub PositionLabel1_Click(sender As Object, e As EventArgs) Handles PositionLabel1.Click

    End Sub

    Private Sub president_pic_Click(sender As Object, e As EventArgs) Handles president_pic.Click

    End Sub
End Class