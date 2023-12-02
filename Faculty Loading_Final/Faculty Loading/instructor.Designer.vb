<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructor
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(instructor))
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Dept = New TextBox()
        Label6 = New Label()
        Radfemale = New RadioButton()
        Radmale = New RadioButton()
        Label5 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        middle_name = New TextBox()
        first_name = New TextBox()
        last_name = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        InstructorID = New DataGridViewTextBoxColumn()
        lastname = New DataGridViewTextBoxColumn()
        firstname = New DataGridViewTextBoxColumn()
        middlename = New DataGridViewTextBoxColumn()
        Department = New DataGridViewTextBoxColumn()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(206, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 51)
        Label1.TabIndex = 0
        Label1.Text = "Faculty Members"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top
        GroupBox1.Controls.Add(Dept)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Radfemale)
        GroupBox1.Controls.Add(Radmale)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(middle_name)
        GroupBox1.Controls.Add(first_name)
        GroupBox1.Controls.Add(last_name)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(248, 177)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(319, 609)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Instructor Details"
        ' 
        ' Dept
        ' 
        Dept.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Dept.Location = New Point(47, 344)
        Dept.Multiline = True
        Dept.Name = "Dept"
        Dept.Size = New Size(218, 38)
        Dept.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(47, 314)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 27)
        Label6.TabIndex = 17
        Label6.Text = "Department"
        ' 
        ' Radfemale
        ' 
        Radfemale.AutoSize = True
        Radfemale.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Radfemale.Location = New Point(157, 424)
        Radfemale.Name = "Radfemale"
        Radfemale.Size = New Size(108, 35)
        Radfemale.TabIndex = 16
        Radfemale.TabStop = True
        Radfemale.Text = "Female"
        Radfemale.UseVisualStyleBackColor = True
        ' 
        ' Radmale
        ' 
        Radmale.AutoSize = True
        Radmale.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Radmale.Location = New Point(47, 424)
        Radmale.Name = "Radmale"
        Radmale.Size = New Size(86, 35)
        Radmale.TabIndex = 15
        Radmale.TabStop = True
        Radmale.Text = "Male"
        Radmale.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(93, 394)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 27)
        Label5.TabIndex = 14
        Label5.Text = "Gender"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(170, 482)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 38)
        Button2.TabIndex = 13
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(39, 482)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 38)
        Button1.TabIndex = 12
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' middle_name
        ' 
        middle_name.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        middle_name.Location = New Point(47, 254)
        middle_name.Multiline = True
        middle_name.Name = "middle_name"
        middle_name.Size = New Size(218, 38)
        middle_name.TabIndex = 5
        ' 
        ' first_name
        ' 
        first_name.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        first_name.Location = New Point(47, 161)
        first_name.Multiline = True
        first_name.Name = "first_name"
        first_name.Size = New Size(218, 38)
        first_name.TabIndex = 4
        ' 
        ' last_name
        ' 
        last_name.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        last_name.Location = New Point(47, 70)
        last_name.Multiline = True
        last_name.Name = "last_name"
        last_name.Size = New Size(218, 38)
        last_name.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(47, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 27)
        Label4.TabIndex = 2
        Label4.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(47, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 27)
        Label3.TabIndex = 1
        Label3.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(47, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 27)
        Label2.TabIndex = 0
        Label2.Text = "Last Name"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {InstructorID, lastname, firstname, middlename, Department})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(642, 201)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1053, 609)
        DataGridView1.TabIndex = 2
        ' 
        ' InstructorID
        ' 
        InstructorID.Frozen = True
        InstructorID.HeaderText = "Instructor ID"
        InstructorID.MinimumWidth = 6
        InstructorID.Name = "InstructorID"
        InstructorID.Visible = False
        InstructorID.Width = 150
        ' 
        ' lastname
        ' 
        lastname.Frozen = True
        lastname.HeaderText = "Last Name"
        lastname.MinimumWidth = 6
        lastname.Name = "lastname"
        lastname.Width = 250
        ' 
        ' firstname
        ' 
        firstname.HeaderText = "First Name"
        firstname.MinimumWidth = 6
        firstname.Name = "firstname"
        firstname.Width = 250
        ' 
        ' middlename
        ' 
        middlename.HeaderText = "Middle Name"
        middlename.MinimumWidth = 6
        middlename.Name = "middlename"
        middlename.Width = 250
        ' 
        ' Department
        ' 
        Department.HeaderText = "Department"
        Department.MinimumWidth = 6
        Department.Name = "Department"
        Department.Width = 250
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 40)
        Button3.TabIndex = 3
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-14, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1949, 1100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' instructor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "instructor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Instructor"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents middle_name As TextBox
    Friend WithEvents first_name As TextBox
    Friend WithEvents last_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Radfemale As RadioButton
    Friend WithEvents Radmale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Dept As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents InstructorID As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents middlename As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
End Class
