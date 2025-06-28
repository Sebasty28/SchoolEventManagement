Public Class Student_DashBoard

    Private userAccount As Account

    Public Sub New(account As Account)
        InitializeComponent()
        userAccount = account
    End Sub

    Private Sub Student_DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_Feedback.Visible = False
        lbl_studNameValue.Text = userAccount.Name
        lbl_studIdValue.Text = userAccount.StudentID
        lbl_studOrgValue.Text = userAccount.Organization
        lbl_sutdCourseValue.Text = userAccount.CourseSection
        lbl_AgeValue.Text = userAccount.Age.ToString()
        lbl_GenderValue.Text = If(userAccount.Gender = "M"c, "Male", "Female")
    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        MessageBox.Show("Registration Success. Event Registration.", "Registred Successfully",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btn_FeedBack_Click(sender As Object, e As EventArgs) Handles btn_FeedBack.Click
        panel_Feedback.Visible = True
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim log As New Login()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button_FeedbackExit_Click(sender As Object, e As EventArgs) Handles Button_FeedbackExit.Click
        panel_Feedback.Visible = False
    End Sub


End Class