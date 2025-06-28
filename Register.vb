Public Class Register
    Dim dataProcess As New dataProcess()
    Public Sub New()
        InitializeComponent()
        txt_studID.Text = dataProcess.GenerateStudentID()
    End Sub

    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        If String.IsNullOrWhiteSpace(txt_name.Text) OrElse String.IsNullOrWhiteSpace(txt_org.Text) OrElse String.IsNullOrWhiteSpace(txt_studID.Text) Then
            MessageBox.Show("Please fill-up all the field/s.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim name = txt_name.Text.ToUpper()
        Dim studentID = txt_studID.Text
        Dim email = txt_Email.Text
        Dim org = txt_org.Text
        Dim Course_Section = txt_course_section.Text
        Dim age As Integer
        Dim gender As Char = If(cb_gender.Text = "Male", "M"c, "F"c)
        If Not Integer.TryParse(cb_age.Text, age) Then
            MessageBox.Show("Please select a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If Not dataProcess.ValidateStudent(studentID) Then
            dataProcess.LoadNewAccounts(name, studentID, email, org, Course_Section, age, gender)
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub ClearFields()
        txt_name.Clear()
        txt_Email.Clear()
        txt_org.Clear()
        txt_studID.Clear()
        cb_age.SelectedIndex = 0
        cb_gender.SelectedIndex = 0
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Hide()
    End Sub

End Class