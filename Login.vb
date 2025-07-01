Public Class Login
    Dim dataProcess As New dataProcess()
    Public Shared accounts As New List(Of Account)()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btn_student_Click(sender As Object, e As EventArgs) Handles btn_student.Click
        If String.IsNullOrWhiteSpace(txt_name.Text) OrElse String.IsNullOrWhiteSpace(txt_studID.Text) Then
            MessageBox.Show("Please fill-up all the field/s.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim name = txt_name.Text.ToUpper()
        Dim studentID = txt_studID.Text.ToUpper()
        For Each account As Account In dataProcess.GetAccounts()
            If account.Name = name And name.Contains("ADMIN") And account.StudentID = studentID Then
                MessageBox.Show("Welcome " & account.Name & "!", "Admin Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim adminForm As New Admin_DashBoard()
                adminForm.Show()
                Me.Hide()
                Return
            ElseIf account.Name = name AndAlso account.StudentID = studentID Then
                MessageBox.Show("Welcome " & account.Name & "!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim from_student As New Student_DashBoard(account)
                from_student.Show()
                Me.Hide()
                Return
            End If
        Next
        MessageBox.Show("Invalid login credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        Dim reg As New Register()
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class