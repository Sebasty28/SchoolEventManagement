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

        LoadEventList()
    End Sub

    Private Sub LoadEventList()
        ListBox1.Items.Clear()

        Dim data As New dataProcess()
        Dim allEvents As List(Of EventInfo) = data.GetEvents()

        For Each ev As EventInfo In allEvents
            Dim display As String = ev.EventName & " - " & ev.DateStart.ToString("MMM dd") & " to " & ev.DateEnd.ToString("MMM dd") & " @ " & ev.EventVenue
            ListBox1.Items.Add(display)
        Next
        ListBox1.HorizontalScrollbar = True
    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event to register.")
            Return
        End If

        MessageBox.Show("Registered successfully for: " & ListBox1.SelectedItem.ToString(),
                    "Event Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub btn_SubmitFeedback_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim feedbackText As String = RichTextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(feedbackText) Then
            MessageBox.Show("Please enter your feedback before submitting.", "Empty Feedback", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event to give feedback.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedEvent As String = ListBox1.SelectedItem.ToString()
        Dim displayText As String = userAccount.Name & ": " & feedbackText

        RichTextBox1.AppendText(displayText & Environment.NewLine)

        MessageBox.Show("Thank you for your feedback on: " & selectedEvent, "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        panel_Feedback.Visible = False
    End Sub


End Class