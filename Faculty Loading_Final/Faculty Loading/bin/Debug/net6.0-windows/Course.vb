Imports MySql.Data.MySqlClient
Public Class course_form
    Private myconnection As New connectiondb
    Dim dr As MySqlDataReader

    Private Sub backcoursebtn_Click(sender As Object, e As EventArgs) Handles backcoursebtn.Click

        Form1.Show()
        Me.Hide()

    End Sub


    Private Sub Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub
    Private Sub savee()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO course (`course`, `course_description` ) VALUES (@course, @course_description )"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@course", course.Text)
                    cmd.Parameters.AddWithValue("@course_description", course_description.Text)
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MsgBox("Successfully Added!")

            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savee()
        LoadData()
        course.Clear()
        course_description.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles course.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles course_description.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM course", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()

                    While dr.Read()
                        DataGridView1.Rows.Add(dr("course"), dr("course_description"))
                    End While
                    dr.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            myconnection.Close()
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class