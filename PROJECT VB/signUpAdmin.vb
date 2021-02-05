Imports MySql.Data.MySqlClient

Public Class signupAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Ad_name.Text = Nothing Or Ad_email.Text = Nothing Or Ad_pass.Text = Nothing Or confirm.Text = Nothing Then
            MsgBox("Enter Input Field!", MsgBoxStyle.Critical)
            If Ad_pass.Text <> confirm.Text Then
                MsgBox("Password does not match!", MsgBoxStyle.Exclamation)
            End If
        End If

        Try
            Dim iReturn As Boolean
            Using SQLConnection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
                Using sqlCommand As New MySqlCommand()
                    With sqlCommand
                        .CommandText = "INSERT INTO Admin (`Mod_id`, `Ad_name`, `Ad_email`, `Ad_pass`) values (@mod_id,@ad_name,@ad_email,@ad_pass)"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@mod_id", 1)
                        .Parameters.AddWithValue("@ad_name", Ad_name.Text)
                        .Parameters.AddWithValue("@ad_email", Ad_email.Text)
                        .Parameters.AddWithValue("@ad_pass", Ad_pass.Text)

                    End With
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()
                        iReturn = True
                    Catch ex As MySqlException
                        MsgBox("Error in MySQL")
                        iReturn = False
                    Finally
                        SQLConnection.Close()
                    End Try
                End Using
            End Using

            MessageBox.Show("Successfully Sign Up")
            Ad_name.Clear()
            Ad_email.Clear()
            Ad_pass.Clear()
            confirm.Clear()
        Catch ex As Exception
            MsgBox("Failed To Sign Up ")
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class