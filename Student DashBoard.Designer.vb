<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_DashBoard
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
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.btn_FeedBack = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_GenderValue = New System.Windows.Forms.Label()
        Me.lbl_AgeValue = New System.Windows.Forms.Label()
        Me.lbl_sutdCourseValue = New System.Windows.Forms.Label()
        Me.lbl_studOrgValue = New System.Windows.Forms.Label()
        Me.lbl_studNameValue = New System.Windows.Forms.Label()
        Me.lbl_studIdValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Register
        '
        Me.btn_Register.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Register.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Register.ForeColor = System.Drawing.Color.White
        Me.btn_Register.Location = New System.Drawing.Point(330, 315)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(112, 28)
        Me.btn_Register.TabIndex = 6
        Me.btn_Register.Text = "Register"
        Me.btn_Register.UseVisualStyleBackColor = False
        '
        'btn_FeedBack
        '
        Me.btn_FeedBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_FeedBack.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FeedBack.ForeColor = System.Drawing.Color.White
        Me.btn_FeedBack.Location = New System.Drawing.Point(450, 315)
        Me.btn_FeedBack.Name = "btn_FeedBack"
        Me.btn_FeedBack.Size = New System.Drawing.Size(108, 28)
        Me.btn_FeedBack.TabIndex = 7
        Me.btn_FeedBack.Text = "Feedback"
        Me.btn_FeedBack.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(32, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(206, 238)
        Me.ListBox1.TabIndex = 8
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.DarkGray
        Me.btn_Exit.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.White
        Me.btn_Exit.Location = New System.Drawing.Point(10, 340)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(93, 28)
        Me.btn_Exit.TabIndex = 9
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'lbl_GenderValue
        '
        Me.lbl_GenderValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GenderValue.Location = New System.Drawing.Point(374, 274)
        Me.lbl_GenderValue.Name = "lbl_GenderValue"
        Me.lbl_GenderValue.Size = New System.Drawing.Size(64, 21)
        Me.lbl_GenderValue.TabIndex = 15
        Me.lbl_GenderValue.Text = "Gender"
        '
        'lbl_AgeValue
        '
        Me.lbl_AgeValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AgeValue.Location = New System.Drawing.Point(484, 274)
        Me.lbl_AgeValue.Name = "lbl_AgeValue"
        Me.lbl_AgeValue.Size = New System.Drawing.Size(78, 21)
        Me.lbl_AgeValue.TabIndex = 14
        Me.lbl_AgeValue.Text = "Age"
        '
        'lbl_sutdCourseValue
        '
        Me.lbl_sutdCourseValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sutdCourseValue.Location = New System.Drawing.Point(330, 248)
        Me.lbl_sutdCourseValue.Name = "lbl_sutdCourseValue"
        Me.lbl_sutdCourseValue.Size = New System.Drawing.Size(232, 19)
        Me.lbl_sutdCourseValue.TabIndex = 13
        Me.lbl_sutdCourseValue.Text = "BSIT 2-1"
        '
        'lbl_studOrgValue
        '
        Me.lbl_studOrgValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studOrgValue.Location = New System.Drawing.Point(330, 206)
        Me.lbl_studOrgValue.Name = "lbl_studOrgValue"
        Me.lbl_studOrgValue.Size = New System.Drawing.Size(232, 19)
        Me.lbl_studOrgValue.TabIndex = 12
        Me.lbl_studOrgValue.Text = "Organization"
        '
        'lbl_studNameValue
        '
        Me.lbl_studNameValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studNameValue.Location = New System.Drawing.Point(330, 162)
        Me.lbl_studNameValue.Name = "lbl_studNameValue"
        Me.lbl_studNameValue.Size = New System.Drawing.Size(232, 19)
        Me.lbl_studNameValue.TabIndex = 11
        Me.lbl_studNameValue.Text = "Student Name"
        '
        'lbl_studIdValue
        '
        Me.lbl_studIdValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studIdValue.Location = New System.Drawing.Point(330, 116)
        Me.lbl_studIdValue.Name = "lbl_studIdValue"
        Me.lbl_studIdValue.Size = New System.Drawing.Size(232, 19)
        Me.lbl_studIdValue.TabIndex = 10
        Me.lbl_studIdValue.Text = "Student ID"
        '
        'Student_DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SchoolEventManagement.My.Resources.Resources.LoginDashboard__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 378)
        Me.Controls.Add(Me.lbl_GenderValue)
        Me.Controls.Add(Me.lbl_AgeValue)
        Me.Controls.Add(Me.lbl_sutdCourseValue)
        Me.Controls.Add(Me.lbl_studOrgValue)
        Me.Controls.Add(Me.lbl_studNameValue)
        Me.Controls.Add(Me.lbl_studIdValue)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_FeedBack)
        Me.Controls.Add(Me.btn_Register)
        Me.Name = "Student_DashBoard"
        Me.Text = "Student_DashBoard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Register As Button
    Friend WithEvents btn_FeedBack As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_Exit As Button
    Friend WithEvents lbl_GenderValue As Label
    Friend WithEvents lbl_AgeValue As Label
    Friend WithEvents lbl_sutdCourseValue As Label
    Friend WithEvents lbl_studOrgValue As Label
    Friend WithEvents lbl_studNameValue As Label
    Friend WithEvents lbl_studIdValue As Label
End Class
