Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Imports Mysqlx
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Schedule
    Private myconnection As New connectiondb
    Dim dr As MySqlDataReader



    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        instructor()
        major()
        schoolyr()
        yearlvl()
        sem()

        Label4.Parent = PictureBox3
        Label4.BackColor = Color.Transparent

        Label6.Parent = PictureBox3
        Label6.BackColor = Color.Transparent
        PictureBox1.Parent = PictureBox3
        PictureBox1.BackColor = Color.Transparent

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub







    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub








    Private Sub instructor()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT last_name, first_name FROM instructor ORDER BY last_name"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox1.Items.Clear()

                            While reader.Read()
                                Dim firstName As String = reader("last_name").ToString()
                                Dim lastName As String = reader("first_name").ToString()
                                Dim fullName As String = firstName & " " & lastName

                                ComboBox1.Items.Add(fullName)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub sem()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT DISTINCT semester FROM subject"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox2.Items.Clear()

                            While reader.Read()
                                Dim semester As String = reader("semester").ToString()


                                ComboBox2.Items.Add(semester)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub schoolyr()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT DISTINCT academicYr FROM subject"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox3.Items.Clear()

                            While reader.Read()
                                Dim academicYr As String = reader("academicYr").ToString()


                                ComboBox3.Items.Add(academicYr)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub yearlvl()
        myconnection.open()
        Try
            Using con As MySqlConnection = myconnection.con
                Dim query As String = "SELECT DISTINCT yrLvl FROM subject"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ComboBox5.Items.Clear()

                            While reader.Read()
                                Dim yrLvl As String = reader("yrLvl").ToString()


                                ComboBox5.Items.Add(yrLvl)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub


    Private Sub major()
        Try
            Using con As MySqlConnection = myconnection.con
                con.Open()
                Dim query As String = "SELECT DISTINCT course FROM course"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            ComboBox4.Items.Clear()

                            While reader.Read()
                                Dim major As String = reader("course").ToString()
                                ComboBox4.Items.Add(major)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub LoadData()
        myconnection.open()
        Try
            DataGridView1.Rows.Clear()
            Using con As MySqlConnection = myconnection.con
                Using cmd As New MySqlCommand("SELECT * FROM subject ORDER BY subject_code", con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("subject_code"), dr("subject_description"), dr("units"), dr("course"), dr("yrLvl"), dr("section"), dr("day"), dr("time"), dr("room"))
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


    Dim totalUnits As Integer = 0

    Private disabledRows As New Dictionary(Of String, Boolean)

    Private Sub UpdateDataGridView()
        If ComboBox4.SelectedIndex <> -1 AndAlso ComboBox2.SelectedIndex <> -1 AndAlso ComboBox3.SelectedIndex <> -1 AndAlso ComboBox5.SelectedIndex <> -1 Then
            Try
                Dim selectedCourse As String = ComboBox4.SelectedItem.ToString()
                Dim selectedSemester As String = ComboBox2.SelectedItem.ToString()
                Dim selectedAcademicYr As String = ComboBox3.SelectedItem.ToString()
                Dim selectedYrLvl As String = ComboBox5.SelectedItem.ToString()

                Dim text1 As String = ComboBox1.Text
                Dim text2 As String = ComboBox2.Text
                Dim text3 As String = ComboBox3.Text

                Label6.Text = text1 & " Temporary Schedule " & text2 & " " & text3


                Using con As MySqlConnection = myconnection.con
                    con.Open()

                    Dim query As String = "SELECT subject_id, course, subject_code, subject_description, semester, units, yrLvl, section, day, time, room FROM subject " &
                                         "WHERE course = @course AND semester = @semester AND academicYr = @academicYr AND yrLvl = @yrLvl " &
                                         "ORDER BY subject_code"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@course", selectedCourse)
                        cmd.Parameters.AddWithValue("@semester", selectedSemester)
                        cmd.Parameters.AddWithValue("@academicYr", selectedAcademicYr)
                        cmd.Parameters.AddWithValue("@yrLvl", selectedYrLvl)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            DataGridView1.Rows.Clear()

                            While reader.Read()
                                Dim subjectId As String = reader("subject_id").ToString()
                                Dim subjectCode As String = reader("subject_code").ToString()
                                Dim subjectDescription As String = reader("subject_description").ToString()
                                Dim units As String = reader("units").ToString()
                                Dim course As String = reader("course").ToString()
                                Dim year As String = reader("yrLvl").ToString()
                                Dim section As String = reader("section").ToString()
                                Dim day As String = reader("day").ToString()
                                Dim time As String = reader("time").ToString()
                                Dim room As String = reader("room").ToString()

                                DataGridView1.Rows.Add(subjectId, subjectCode, subjectDescription, units, course, year, section, day, time, room)


                                If Not disabledRows.ContainsKey(subjectId) Then
                                    disabledRows.Add(subjectId, False)
                                End If
                            End While
                        End Using
                    End Using
                End Using


                For Each row As DataGridViewRow In DataGridView1.Rows

                    Dim subjectId As String = If(row.Cells("Column11").Value IsNot Nothing, row.Cells("Column11").Value.ToString(), String.Empty)

                    If disabledRows.ContainsKey(subjectId) AndAlso disabledRows(subjectId) Then
                        row.ReadOnly = True
                        row.DefaultCellStyle.ForeColor = Color.Gray
                    Else
                        row.ReadOnly = False
                        row.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.ColumnIndex = DataGridView1.Columns("Column1").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim subjectId As String = selectedRow.Cells("Column11").Value.ToString()

            If Not disabledRows.ContainsKey(subjectId) OrElse Not disabledRows(subjectId) Then

                disabledRows(subjectId) = True
                selectedRow.ReadOnly = True
                selectedRow.DefaultCellStyle.ForeColor = Color.Gray

                Dim subjectCode As String = selectedRow.Cells("Column1").Value.ToString()
                Dim subjectDescription As String = selectedRow.Cells("Column2").Value.ToString()
                Dim units As Integer = Integer.Parse(selectedRow.Cells("Column3").Value.ToString())
                Dim subject As String = subjectCode & " - " & subjectDescription
                Dim crs As String = selectedRow.Cells("Column4").Value.ToString()
                Dim room As String = selectedRow.Cells("Column5").Value.ToString()
                Dim time As String = selectedRow.Cells("Column6").Value.ToString()
                Dim day As String = selectedRow.Cells("Column7").Value.ToString()
                Dim section As String = selectedRow.Cells("Column8").Value.ToString()
                Dim year As String = selectedRow.Cells("Column10").Value.ToString()
                Dim yrsc As String = year & " - " & section

                totalUnits += units
                Label5.Text = "Total Units: " & totalUnits.ToString()

                DataGridView2.Rows.Add(subjectId, "Delete", subject, units, crs, yrsc, day, time, room)
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.ColumnIndex = DataGridView2.Columns("Columndel").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            Dim subjectId As String = selectedRow.Cells("Column12").Value.ToString()
            Dim unitsToRestore As Integer = Integer.Parse(selectedRow.Cells("Columnunits").Value.ToString())

            DataGridView2.Rows.RemoveAt(e.RowIndex)

            totalUnits -= unitsToRestore
            Label5.Text = "Total Units: " & totalUnits.ToString()

            If disabledRows.ContainsKey(subjectId) Then
                disabledRows(subjectId) = False
            End If


            UpdateDataGridView()
        End If
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        UpdateDataGridView()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        UpdateDataGridView()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        UpdateDataGridView()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        UpdateDataGridView()
    End Sub


    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click
        ExportData()
    End Sub
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

    End Sub


    Private Sub ExportData()
        Dim excelApp As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim excelWorkbook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try
            ' Initialize Excel application
            excelApp = New Microsoft.Office.Interop.Excel.Application()
            excelApp.Visible = True
            excelWorkbook = excelApp.Workbooks.Add()
            excelWorksheet = TryCast(excelWorkbook.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)

            ' Populate the first row with time values (8:00 AM to 5:30 PM)
            Dim startTime As New TimeSpan(7, 30, 0) ' Start at 8:00 AM
            For timeIndex As Integer = 2 To 21 ' 20 represents 5:30 PM, as it starts from 0
                Dim currentTime As TimeSpan = startTime.Add(New TimeSpan(0, 30 * (timeIndex - 1), 0))
                excelWorksheet.Cells(timeIndex, 1) = currentTime.ToString("hh\:mm")
                excelWorksheet.Cells(timeIndex, 2) = currentTime.Add(New TimeSpan(0, 30, 0)).ToString("hh\:mm")
            Next

            ' Set the cell format for the time columns
            excelWorksheet.Range("A2:A21").NumberFormat = "h:mm AM/PM"
            excelWorksheet.Range("B2:B21").NumberFormat = "h:mm AM/PM"

            ' Populate the second row with day names
            Dim days() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
            For dayIndex As Integer = 0 To days.Length - 1
                excelWorksheet.Cells(1, dayIndex + 3) = days(dayIndex)
            Next

            ' Iterate through the DataGridView rows and export the data
            For rowIndex As Integer = 0 To DataGridView2.Rows.Count - 1
                Dim dayName As String = Convert.ToString(DataGridView2.Rows(rowIndex).Cells(6).Value)?.Trim()
                Dim timeRange As String = Convert.ToString(DataGridView2.Rows(rowIndex).Cells(7).Value)

                If Not String.IsNullOrEmpty(dayName) AndAlso Not String.IsNullOrEmpty(timeRange) Then
                    Dim times() As String = timeRange.Split("-"c)
                    If times.Length = 2 Then
                        Dim startTimeString As String = times(0).Trim()
                        Dim startTimeSpan As TimeSpan

                        If TimeSpan.TryParse(startTimeString, startTimeSpan) Then
                            Dim startHour As Integer = startTimeSpan.Hours
                            Dim startMinute As Integer = startTimeSpan.Minutes

                            ' Adjust for PM hours
                            If startTimeString.Contains("PM") AndAlso startHour < 12 Then
                                startHour += 12
                            End If

                            ' Check if start time is earlier than 8:00 AM
                            If startHour < 8 Then
                                startHour += 12  ' Add 12 hours to convert to PM time
                            End If

                            Dim startExcelRow As Integer = ((startHour - 8) * 2) + If(startMinute = 30, 1, 0) + 2


                            ' Find the index of the dayName in the days array
                            Dim dayIndex As Integer = Array.IndexOf(days, dayName)

                            If dayIndex <> -1 Then ' Check if dayName is found in the array
                                Dim excelColumn As Integer = dayIndex + 3 ' Adjusted to start from column 3

                                If startExcelRow < 2 Or startExcelRow > 21 Then
                                    MessageBox.Show($"Invalid start time calculation for row {rowIndex + 1}. Time: {startTimeString}")
                                End If

                                Dim mergedCell As Microsoft.Office.Interop.Excel.Range = excelWorksheet.Range(excelWorksheet.Cells(startExcelRow, excelColumn), excelWorksheet.Cells(startExcelRow + 5, excelColumn))
                                mergedCell.Merge()

                                ' Set the value and format for the merged cell
                                mergedCell.Value = $"{DataGridView2.Rows(rowIndex).Cells(2).Value} - {DataGridView2.Rows(rowIndex).Cells(8).Value}"
                                mergedCell.WrapText = True  ' Enable text wrapping
                                mergedCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter  ' Center align the text
                                mergedCell.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter  ' Middle align the text



                                ' Adjust the font size and cell size
                                mergedCell.Font.Size = 12  ' Set the desired font size

                                ' Set custom row height and column width for the merged cell range
                                mergedCell.Rows.RowHeight = 20  ' Set the desired row height
                                mergedCell.Columns.ColumnWidth = 15  ' Set the desired column width



                            Else
                                MessageBox.Show($"Invalid day name: {dayName}")
                            End If
                        Else
                            MessageBox.Show($"Invalid start time format: {startTimeString}")
                        End If
                    Else
                        MessageBox.Show($"Invalid time range format: {timeRange}")
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally
            ' Release Excel objects
            If excelWorksheet IsNot Nothing Then Marshal.ReleaseComObject(excelWorksheet)
            If excelWorkbook IsNot Nothing Then Marshal.ReleaseComObject(excelWorkbook)
            If excelApp IsNot Nothing Then Marshal.ReleaseComObject(excelApp)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class