Imports MySql.Data.MySqlClient
Imports System.IO
Public Class signUpCandidate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            With OpenFileDialog1

                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True

                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True

                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"

                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False



                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim iReturn As Boolean
            Using SQLConnection As New MySqlConnection("host=127.0.0.1; user=root; database=arecs")
                Using sqlCommand As New MySqlCommand()
                    With sqlCommand
                        Dim caption As String
                        Dim arrImage() As Byte
                        Dim mstream As New System.IO.MemoryStream()
                        caption = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
                        'SPECIFIES THE FILE FORMAT OF THE IMAGE
                        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                        'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
                        arrImage = mstream.GetBuffer()

                        'GET THE SIZE OF THE STREAM IN BYTES
                        Dim FileSize As UInt32
                        FileSize = mstream.Length
                        'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
                        mstream.Close()
                        .CommandText = "INSERT INTO Candidate (`Can_id`, `Can_name`, `Can_course`, `Can_manifesto`, `Can_pic`) values (@Can_id,@Can_name,@Can_course,@Can_manifesto,@Can_pic)"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@Can_id", Can_id.Text)
                        .Parameters.AddWithValue("@Can_name", Can_name.Text)
                        .Parameters.AddWithValue("@Can_course", Can_course.Text)
                        .Parameters.AddWithValue("@Can_manifesto", Can_manifesto.Text)
                        .Parameters.AddWithValue("@Can_pic", arrImage)

                    End With
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()
                        iReturn = True
                    Catch ex As MySqlException
                        MsgBox("Error!")
                        iReturn = False
                    Finally
                        SQLConnection.Close()
                    End Try
                End Using
            End Using

            MessageBox.Show("Successfully Sign Up")

        Catch ex As Exception
            MsgBox("Failed To Sign Up ")
        End Try
    End Sub

End Class