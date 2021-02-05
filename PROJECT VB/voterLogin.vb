Imports MySql.Data.MySqlClient

Public Class voterLogin
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand


    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        con = New MySqlConnection
        con.ConnectionString = "host=127.0.0.1;user=root;database=arecs"
        Dim reader As MySqlDataReader
        Dim checkVoterID As String

        Try
            con.Open()
            Dim query As String

            query = "SELECT * FROM Voter where Voter_id ='" & Voter_id.Text & "' AND Voter_pass='" & Voter_pass.Text & "' "

            cmd = New MySqlCommand(query, con)
            reader = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                checkVoterID = reader.GetValue(1)
                count = count + 1
            End While

            If count = 1 Then
                MsgBox("Username and password are correct !", MsgBoxStyle.DefaultButton1, " Welcome Voter : " + reader("Voter_name"))
                Dim s_ID As String
                s_ID = Voter_id.Text
                If checkVoterID = 0 Then
                    Dim frm As New voterLoggedin(s_ID)
                    Me.Close()
                    main.Hide()
                    frm.Show()
                Else
                    MsgBox("You Already Voted. ")
                End If

            ElseIf count > 1 Then
                MsgBox("Student ID and password are duplicate")
            Else
                MsgBox("Student ID and password are wrong", MsgBoxStyle.Critical, "ERROR")
            End If
            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("yourstudentid@uitm", MsgBoxStyle.Information, "hint")
    End Sub
End Class
