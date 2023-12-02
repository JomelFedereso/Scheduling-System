Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form2


    Private myconnection As New connectiondb
    Dim dr As MySqlDataReader
    Private selectedRoomID As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub backroombtn_Click(sender As Object, e As EventArgs) Handles backroombtn.Click

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles room.TextChanged

    End Sub


    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM room", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(Format(CBool(dr("option"))), dr("room_id"), dr("room"))
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
        If Not String.IsNullOrEmpty(room.Text) Then
            myconnection.open()
            Try
                Using con As MySqlConnection = myconnection.con
                    Using cmd As New MySqlCommand()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO room (`room`) VALUES (@room)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@room", room.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Successfully Added!")
                myconnection.Close()
            Catch ex As Exception
                MsgBox("An error occurred while saving data.")
            End Try
        Else
            MsgBox("Room name cannot be empty. Please provide a valid room.")
        End If
    End Sub
    Private Sub edit()
        If Not String.IsNullOrEmpty(room.Text) AndAlso selectedRoomID <> -1 Then
            myconnection.open()
            Try
                Using con As MySqlConnection = myconnection.con
                    Using cmd As New MySqlCommand()
                        cmd.Connection = con
                        cmd.CommandText = "UPDATE room SET room = @room WHERE room_id = @selectedRoomID"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@room", room.Text)
                        cmd.Parameters.AddWithValue("@selectedRoomID", selectedRoomID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using


                MsgBox("Successfully Updated!")

                myconnection.Close()
            Catch ex As Exception
                MsgBox("An error occurred while updating data.")
            End Try
        Else
            MsgBox("Please select a room from the DataGridView and provide a valid room name to update.")
        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savee()
        LoadData()

        room.Clear()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellDoubleClick
        If e.ColumnIndex = DataGridView1.Columns("opt2").Index AndAlso e.RowIndex >= 0 Then

            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("opt2").Value = False
            Next


            Dim cell As DataGridViewCheckBoxCell = DataGridView1.Rows(e.RowIndex).Cells("opt2")
            cell.Value = True


            room.Text = DataGridView1.Rows(e.RowIndex).Cells("roomno").Value.ToString()

            ' Assign the "room_id" value to selectedRoomID
            Dim roomIDValue As Integer
            If Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells("room_id").Value.ToString(), roomIDValue) Then
                selectedRoomID = roomIDValue
            Else


                selectedRoomID = -1
            End If
        End If




    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        edit()
        LoadData()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class