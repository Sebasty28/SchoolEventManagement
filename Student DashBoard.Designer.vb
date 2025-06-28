<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_DashBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.panel_Feedback = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_FeedbackExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.panel_Feedback.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Register
        '
        Me.btn_Register.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Register.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Register.ForeColor = System.Drawing.Color.White
        Me.btn_Register.Location = New System.Drawing.Point(440, 388)
        Me.btn_Register.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(149, 34)
        Me.btn_Register.TabIndex = 6
        Me.btn_Register.Text = "Register"
        Me.btn_Register.UseVisualStyleBackColor = False
        '
        'btn_FeedBack
        '
        Me.btn_FeedBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_FeedBack.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FeedBack.ForeColor = System.Drawing.Color.White
        Me.btn_FeedBack.Location = New System.Drawing.Point(600, 388)
        Me.btn_FeedBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_FeedBack.Name = "btn_FeedBack"
        Me.btn_FeedBack.Size = New System.Drawing.Size(149, 34)
        Me.btn_FeedBack.TabIndex = 7
        Me.btn_FeedBack.Text = "Feedback"
        Me.btn_FeedBack.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(43, 70)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(273, 292)
        Me.ListBox1.TabIndex = 8
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.DarkGray
        Me.btn_Exit.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.White
        Me.btn_Exit.Location = New System.Drawing.Point(13, 418)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(124, 34)
        Me.btn_Exit.TabIndex = 9
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'lbl_GenderValue
        '
        Me.lbl_GenderValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GenderValue.Location = New System.Drawing.Point(499, 337)
        Me.lbl_GenderValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_GenderValue.Name = "lbl_GenderValue"
        Me.lbl_GenderValue.Size = New System.Drawing.Size(85, 26)
        Me.lbl_GenderValue.TabIndex = 15
        Me.lbl_GenderValue.Text = "Gender"
        '
        'lbl_AgeValue
        '
        Me.lbl_AgeValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AgeValue.Location = New System.Drawing.Point(645, 337)
        Me.lbl_AgeValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_AgeValue.Name = "lbl_AgeValue"
        Me.lbl_AgeValue.Size = New System.Drawing.Size(104, 26)
        Me.lbl_AgeValue.TabIndex = 14
        Me.lbl_AgeValue.Text = "Age"
        '
        'lbl_sutdCourseValue
        '
        Me.lbl_sutdCourseValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sutdCourseValue.Location = New System.Drawing.Point(440, 305)
        Me.lbl_sutdCourseValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sutdCourseValue.Name = "lbl_sutdCourseValue"
        Me.lbl_sutdCourseValue.Size = New System.Drawing.Size(309, 23)
        Me.lbl_sutdCourseValue.TabIndex = 13
        Me.lbl_sutdCourseValue.Text = "BSIT 2-1"
        '
        'lbl_studOrgValue
        '
        Me.lbl_studOrgValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studOrgValue.Location = New System.Drawing.Point(440, 254)
        Me.lbl_studOrgValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_studOrgValue.Name = "lbl_studOrgValue"
        Me.lbl_studOrgValue.Size = New System.Drawing.Size(309, 23)
        Me.lbl_studOrgValue.TabIndex = 12
        Me.lbl_studOrgValue.Text = "Organization"
        '
        'lbl_studNameValue
        '
        Me.lbl_studNameValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studNameValue.Location = New System.Drawing.Point(440, 199)
        Me.lbl_studNameValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_studNameValue.Name = "lbl_studNameValue"
        Me.lbl_studNameValue.Size = New System.Drawing.Size(309, 23)
        Me.lbl_studNameValue.TabIndex = 11
        Me.lbl_studNameValue.Text = "Student Name"
        '
        'lbl_studIdValue
        '
        Me.lbl_studIdValue.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studIdValue.Location = New System.Drawing.Point(440, 143)
        Me.lbl_studIdValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_studIdValue.Name = "lbl_studIdValue"
        Me.lbl_studIdValue.Size = New System.Drawing.Size(309, 23)
        Me.lbl_studIdValue.TabIndex = 10
        Me.lbl_studIdValue.Text = "Student ID"
        '
        'panel_Feedback
        '
        Me.panel_Feedback.BackgroundImage = Global.SchoolEventManagement.My.Resources.Resources.FeedbackForm
        Me.panel_Feedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Feedback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Feedback.Controls.Add(Me.Label2)
        Me.panel_Feedback.Controls.Add(Me.Button_FeedbackExit)
        Me.panel_Feedback.Controls.Add(Me.Label1)
        Me.panel_Feedback.Controls.Add(Me.Button1)
        Me.panel_Feedback.Controls.Add(Me.RichTextBox1)
        Me.panel_Feedback.Location = New System.Drawing.Point(70, 23)
        Me.panel_Feedback.Name = "panel_Feedback"
        Me.panel_Feedback.Size = New System.Drawing.Size(568, 388)
        Me.panel_Feedback.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.8!)
        Me.Label2.Location = New System.Drawing.Point(77, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 18
        '
        'Button_FeedbackExit
        '
        Me.Button_FeedbackExit.BackColor = System.Drawing.Color.DarkGray
        Me.Button_FeedbackExit.Font = New System.Drawing.Font("Courier New", 8.8!, System.Drawing.FontStyle.Bold)
        Me.Button_FeedbackExit.ForeColor = System.Drawing.Color.White
        Me.Button_FeedbackExit.Location = New System.Drawing.Point(421, 336)
        Me.Button_FeedbackExit.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_FeedbackExit.Name = "Button_FeedbackExit"
        Me.Button_FeedbackExit.Size = New System.Drawing.Size(112, 34)
        Me.Button_FeedbackExit.TabIndex = 17
        Me.Button_FeedbackExit.Text = "Cancel"
        Me.Button_FeedbackExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Feedback"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Courier New", 8.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(301, 336)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(280, 66)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(267, 263)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Student_DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SchoolEventManagement.My.Resources.Resources.LoginDashboard__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(781, 465)
        Me.Controls.Add(Me.panel_Feedback)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Student_DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Event Management"
        Me.panel_Feedback.ResumeLayout(False)
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
    Friend WithEvents panel_Feedback As Panel
    Friend WithEvents Button_FeedbackExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
End Class
