Imports MySql.Data.MySqlClient

Public Class adminLogin
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand


    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        con = New MySqlConnection
        con.ConnectionString = "host=127.0.0.1;user=root;database=arecs"
        Dim reader As MySqlDataReader

        Try
            con.Open()
            Dim query As String

            query = "SELECT * FROM Admin where Ad_Email ='" & Ad_email.Text & "' AND Ad_pass='" & Ad_pass.Text & "' "

            cmd = New MySqlCommand(query, con)
            reader = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MsgBox("Username and password are correct !", MsgBoxStyle.DefaultButton1, " Welcome Admin : " + reader("Ad_name"))
                Me.Close()
                main.Hide()
                adminLoggedin.Show()


            ElseIf count > 1 Then
                MsgBox("Username and password are duplicate", MsgBoxStyle.Exclamation, "ERROR")
            Else
                MsgBox("Username and password are wrong", MsgBoxStyle.Critical, "ERROR")
            End If

            con.Close()

        Catch ex As Exception

        End Try

    End Sub
End Class
