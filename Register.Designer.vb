<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.btn_reg = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.txt_course_section = New System.Windows.Forms.TextBox()
        Me.txt_studID = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_org = New System.Windows.Forms.TextBox()
        Me.cb_gender = New System.Windows.Forms.ComboBox()
        Me.cb_age = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_reg
        '
        Me.btn_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_reg.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reg.ForeColor = System.Drawing.Color.White
        Me.btn_reg.Location = New System.Drawing.Point(319, 320)
        Me.btn_reg.Name = "btn_reg"
        Me.btn_reg.Size = New System.Drawing.Size(115, 32)
        Me.btn_reg.TabIndex = 18
        Me.btn_reg.Text = "Register"
        Me.btn_reg.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.DarkGray
        Me.btn_exit.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.Location = New System.Drawing.Point(446, 320)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(112, 32)
        Me.btn_exit.TabIndex = 19
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'txt_course_section
        '
        Me.txt_course_section.Location = New System.Drawing.Point(325, 250)
        Me.txt_course_section.Multiline = True
        Me.txt_course_section.Name = "txt_course_section"
        Me.txt_course_section.Size = New System.Drawing.Size(234, 19)
        Me.txt_course_section.TabIndex = 22
        '
        'txt_studID
        '
        Me.txt_studID.Location = New System.Drawing.Point(325, 115)
        Me.txt_studID.Multiline = True
        Me.txt_studID.Name = "txt_studID"
        Me.txt_studID.ReadOnly = True
        Me.txt_studID.Size = New System.Drawing.Size(234, 19)
        Me.txt_studID.TabIndex = 25
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(325, 162)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(234, 19)
        Me.txt_name.TabIndex = 26
        '
        'txt_org
        '
        Me.txt_org.Location = New System.Drawing.Point(325, 209)
        Me.txt_org.Multiline = True
        Me.txt_org.Name = "txt_org"
        Me.txt_org.Size = New System.Drawing.Size(234, 19)
        Me.txt_org.TabIndex = 27
        '
        'cb_gender
        '
        Me.cb_gender.FormattingEnabled = True
        Me.cb_gender.Items.AddRange(New Object() {"F", "M"})
        Me.cb_gender.Location = New System.Drawing.Point(373, 275)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(61, 21)
        Me.cb_gender.TabIndex = 28
        '
        'cb_age
        '
        Me.cb_age.FormattingEnabled = True
        Me.cb_age.Items.AddRange(New Object() {"15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33"})
        Me.cb_age.Location = New System.Drawing.Point(474, 275)
        Me.cb_age.Name = "cb_age"
        Me.cb_age.Size = New System.Drawing.Size(61, 21)
        Me.cb_age.TabIndex = 29
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SchoolEventManagement.My.Resources.Resources.LoginDashboard__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 379)
        Me.Controls.Add(Me.cb_age)
        Me.Controls.Add(Me.cb_gender)
        Me.Controls.Add(Me.txt_org)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_studID)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_reg)
        Me.Controls.Add(Me.txt_course_section)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_reg As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents txt_course_section As TextBox
    Friend WithEvents txt_studID As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_org As TextBox
    Friend WithEvents cb_gender As ComboBox
    Friend WithEvents cb_age As ComboBox
End Class
