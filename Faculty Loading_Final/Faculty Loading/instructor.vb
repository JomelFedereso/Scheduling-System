Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Public Class instructor
    Private myconnection As New connectiondb
    Dim gender As String
    Dim dr As MySqlDataReader
    Private Sub instructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub Radmale_CheckedChanged(sender As Object, e As EventArgs) Handles Radmale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savee()
        LoadData()

        last_name.Clear()
        first_name.Clear()
        middle_name.Clear()

        Radmale.Checked = False
        Radfemale.Checked = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles last_name.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM instructor", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("instructor_id"), dr("last_name"), dr("first_name"), dr("middle_name"), dr("department"))
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
    Private Sub savee()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO instructor (`last_name`, `first_name`, `middle_name`, `gender`, `department`) VALUES (@last_name, @first_name, @middle_name, @gender, @department)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@last_name", last_name.Text)
                    cmd.Parameters.AddWithValue("@first_name", first_name.Text)
                    cmd.Parameters.AddWithValue("middle_name", middle_name.Text)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@department", Dept.Text)
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MsgBox("Successfully Added!")

            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub first_name_TextChanged(sender As Object, e As EventArgs) Handles first_name.TextChanged

    End Sub

    Private Sub middle_name_TextChanged(sender As Object, e As EventArgs) Handles middle_name.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

