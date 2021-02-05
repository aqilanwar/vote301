Imports MySql.Data.MySqlClient

Public Class moderatorLogin
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        con = New MySqlConnection
        con.ConnectionString = "host=127.0.0.1;user=root;database=arecs"
        Dim reader As MySqlDataReader

        Try
            con.Open()
            Dim query As String

            query = "SELECT * FROM Moderator where Mod_Email ='" & Mod_email.Text & "' AND Mod_pass='" & Mod_pass.Text & "' "

            cmd = New MySqlCommand(query, con)
            reader = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MsgBox("Username and password are correct !", MsgBoxStyle.DefaultButton1, " Welcome Moderator : " + reader("Mod_name"))
                Me.Close()
                main.Hide()
                moderatorLoggedIn.Show()


            ElseIf count > 1 Then
                MsgBox("Username and password are duplicate")
            Else
                MsgBox("Username and password are wrong", MsgBoxStyle.Critical, "ERROR")
            End If

            con.Close()

        Catch ex As Exception

        End Try

    End Sub


End Class
