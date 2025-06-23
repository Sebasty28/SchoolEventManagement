Public Class Login
    Private Sub btn_student_Click(sender As Object, e As EventArgs) Handles btn_student.Click
        If txt_name.Text = "Admin" And txt_email.Text = "Adminpogi@gmail.com" Then
            MessageBox.Show("Welcome Admin", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Admin_DashBoard.Show()
            Hide()
        ElseIf txt_name.Text = "Darrel" And txt_email.Text = "Darrelmaspogi@gmail.com" Then
            MessageBox.Show("Welcome Student", "Student Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid credentials", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_reg.Click

    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub
End Class