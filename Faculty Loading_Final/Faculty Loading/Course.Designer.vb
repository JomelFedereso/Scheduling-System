<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class course_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        coursecode = New DataGridViewTextBoxColumn()
        coursedescription = New DataGridViewTextBoxColumn()
        backcoursebtn = New Button()
        PictureBox1 = New PictureBox()
        course = New TextBox()
        course_description = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(206, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(356, 51)
        Label1.TabIndex = 0
        Label1.Text = "Course Offering"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {coursecode, coursedescription})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(822, 286)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(773, 411)
        DataGridView1.TabIndex = 2
        ' 
        ' coursecode
        ' 
        coursecode.HeaderText = "Course"
        coursecode.MinimumWidth = 6
        coursecode.Name = "coursecode"
        coursecode.ReadOnly = True
        coursecode.Width = 220
        ' 
        ' coursedescription
        ' 
        coursedescription.HeaderText = "Description"
        coursedescription.MinimumWidth = 6
        coursedescription.Name = "coursedescription"
        coursedescription.ReadOnly = True
        coursedescription.Width = 500
        ' 
        ' backcoursebtn
        ' 
        backcoursebtn.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        backcoursebtn.Location = New Point(11, 12)
        backcoursebtn.Name = "backcoursebtn"
        backcoursebtn.Size = New Size(87, 40)
        backcoursebtn.TabIndex = 3
        backcoursebtn.Text = "Back"
        backcoursebtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.pieces_blue_stationery
        PictureBox1.Location = New Point(11, -12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1942, 1000)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' course
        ' 
        course.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        course.Location = New Point(60, 85)
        course.Name = "course"
        course.Size = New Size(244, 38)
        course.TabIndex = 0
        ' 
        ' course_description
        ' 
        course_description.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        course_description.Location = New Point(60, 245)
        course_description.Name = "course_description"
        course_description.Size = New Size(244, 38)
        course_description.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(60, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 31)
        Label2.TabIndex = 2
        Label2.Text = "Course"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(71, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 31)
        Label3.TabIndex = 3
        Label3.Text = "Description"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(60, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 44)
        Button1.TabIndex = 4
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(201, 354)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 44)
        Button2.TabIndex = 5
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top
        GroupBox1.Controls.Add(course)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(course_description)
        GroupBox1.Location = New Point(389, 201)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(375, 518)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' course_form
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1924, 1055)
        Controls.Add(backcoursebtn)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "course_form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Course Menu"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents backcoursebtn As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents course As TextBox
    Friend WithEvents course_description As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents coursecode As DataGridViewTextBoxColumn
    Friend WithEvents coursedescription As DataGridViewTextBoxColumn
End Class
