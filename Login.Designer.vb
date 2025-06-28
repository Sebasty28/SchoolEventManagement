<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_studID = New System.Windows.Forms.TextBox()
        Me.btn_student = New System.Windows.Forms.Button()
        Me.btn_reg = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.Location = New System.Drawing.Point(419, 138)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(294, 22)
        Me.txt_name.TabIndex = 5
        '
        'txt_studID
        '
        Me.txt_studID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_studID.Location = New System.Drawing.Point(419, 204)
        Me.txt_studID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_studID.Name = "txt_studID"
        Me.txt_studID.Size = New System.Drawing.Size(294, 22)
        Me.txt_studID.TabIndex = 6
        '
        'btn_student
        '
        Me.btn_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_student.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_student.ForeColor = System.Drawing.Color.White
        Me.btn_student.Location = New System.Drawing.Point(407, 281)
        Me.btn_student.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_student.Name = "btn_student"
        Me.btn_student.Size = New System.Drawing.Size(148, 42)
        Me.btn_student.TabIndex = 8
        Me.btn_student.Text = "Login"
        Me.btn_student.UseVisualStyleBackColor = False
        '
        'btn_reg
        '
        Me.btn_reg.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_reg.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reg.ForeColor = System.Drawing.Color.White
        Me.btn_reg.Location = New System.Drawing.Point(585, 281)
        Me.btn_reg.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_reg.Name = "btn_reg"
        Me.btn_reg.Size = New System.Drawing.Size(137, 42)
        Me.btn_reg.TabIndex = 9
        Me.btn_reg.Text = "Register"
        Me.btn_reg.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(631, 380)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SchoolEventManagement.My.Resources.Resources.LoginDashboard1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(781, 423)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_reg)
        Me.Controls.Add(Me.btn_student)
        Me.Controls.Add(Me.txt_studID)
        Me.Controls.Add(Me.txt_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_studID As TextBox
    Friend WithEvents btn_student As Button
    Friend WithEvents btn_reg As Button
    Friend WithEvents Button1 As Button
End Class
