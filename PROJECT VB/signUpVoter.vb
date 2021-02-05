Imports MySql.Data.MySqlClient

Public Class signUpVoter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Voter_name.Text = Nothing Or Voter_course.Text = Nothing Or Voter_email.Text = Nothing Or Voter_id.Text = Nothing Or Voter_pass.Text = Nothing Or confirm.Text = Nothing Then
            MsgBox("Enter Input Field!", MsgBoxStyle.Critical)
            If Voter_pass.Text <> confirm.Text Then
                MsgBox("Password does not match!", MsgBoxStyle.Exclamation)
            End If
        End If

        Try
                Dim iReturn As Boolean
                Using SQLConnection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
                    Using sqlCommand As New MySqlCommand()
                        With sqlCommand
                            .CommandText = "INSERT INTO voter (`Mod_id`,`Voter_id`, `Voter_name`, `Voter_course` , `Voter_pass`, `Voter_email`  ) values (@mod_id,@voter_id,@voter_name,@voter_course,@voter_pass,@voter_email)"
                            .Connection = SQLConnection
                            .CommandType = CommandType.Text
                            .Parameters.AddWithValue("@mod_id", 1)
                            .Parameters.AddWithValue("@voter_id", Voter_id.Text)
                            .Parameters.AddWithValue("@voter_name", Voter_name.Text)
                            .Parameters.AddWithValue("@voter_course", Voter_course.Text)
                            .Parameters.AddWithValue("@voter_pass", Voter_pass.Text)
                            .Parameters.AddWithValue("@Voter_email", Voter_email.Text)
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
                Voter_id.Clear()
                Voter_name.Clear()
                Voter_pass.Clear()
                Voter_email.Clear()
                confirm.Clear()
            Catch ex As Exception
                MsgBox("Failed To Sign Up ")
            End Try
    End Sub

    Private Sub Voter_pass_TextChanged(sender As Object, e As EventArgs) Handles Voter_pass.TextChanged

    End Sub

    Private Sub confirm_TextChanged(sender As Object, e As EventArgs) Handles confirm.TextChanged

    End Sub

    Private Sub signUpVoter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("studentid@uitm", MsgBoxStyle.Information)
    End Sub
End Class