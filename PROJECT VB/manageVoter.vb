Imports MySql.Data.MySqlClient
Imports System.IO
Public Class manageVoter
    Public connection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
    Private Sub manageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        str = "SELECT Voter_id, Voter_name,Voter_course,Voter_email FROM Voter "
        Try
            connection.Open()
            Dim search As New MySqlDataAdapter(str, connection)
            Dim ds As New DataSet
            search.Fill(ds, "Voter")
            DataGridView1.DataSource = ds.Tables("Voter")
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class