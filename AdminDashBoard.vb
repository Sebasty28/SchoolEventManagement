Public Class Admin_DashBoard
    Private data As New dataProcess()

    Private Sub Admin_DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshEventList()
    End Sub

    Private Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        Dim newEvent As New EventInfo()
        newEvent.EventName = tb_name.Text
        newEvent.EventVenue = txtb_Venue.Text
        newEvent.Organization = txtb_dateEnd.Text
        newEvent.DateStart = DateTime.Parse(TextBox1.Text)
        newEvent.DateEnd = DateTime.Parse(txtb_dateStart.Text)

        Dim hasConflict As Boolean = data.CheckScheduleConflict(newEvent)

        If hasConflict Then
            MessageBox.Show("This event has a conflict with another event's schedule.", "Conflict Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        data.AddEvent(newEvent)
        MessageBox.Show("EVENT CREATED SUCCESSFULLY!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RefreshEventList()
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        If lb_Events.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event to update.")
            Exit Sub
        End If

        Dim selectedEvent As EventInfo = CType(lb_Events.SelectedItem, EventInfo)

        Dim updatedEvent As New EventInfo()
        updatedEvent.EventName = tb_name.Text
        updatedEvent.EventVenue = txtb_Venue.Text
        updatedEvent.Organization = txtb_dateEnd.Text
        updatedEvent.DateStart = DateTime.Parse(TextBox1.Text)
        updatedEvent.DateEnd = DateTime.Parse(txtb_dateStart.Text)

        data.UpdateEvent(selectedEvent.EventName, updatedEvent)

        MessageBox.Show("Event updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RefreshEventList()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If lb_Events.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event to delete.")
            Exit Sub
        End If

        Dim selectedEvent As EventInfo = CType(lb_Events.SelectedItem, EventInfo)

        data.DeleteEvent(selectedEvent.EventName)

        MessageBox.Show("Event deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RefreshEventList()
    End Sub

    Private Sub RefreshEventList()
        lb_Events.Items.Clear()

        Dim allEvents As List(Of EventInfo) = data.GetEvents()

        For Each ev As EventInfo In allEvents
            lb_Events.Items.Add(ev)
        Next

        lb_Events.HorizontalScrollbar = True
    End Sub

    Private Sub lb_Events_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_Events.SelectedIndexChanged
        If lb_Events.SelectedIndex = -1 Then Exit Sub

        Dim selectedEvent As EventInfo = CType(lb_Events.SelectedItem, EventInfo)

        tb_name.Text = selectedEvent.EventName
        txtb_Venue.Text = selectedEvent.EventVenue
        txtb_dateEnd.Text = selectedEvent.Organization
        TextBox1.Text = selectedEvent.DateStart.ToString("yyyy-MM-dd")
        txtb_dateStart.Text = selectedEvent.DateEnd.ToString("yyyy-MM-dd")
    End Sub

    Private Sub btn_Logut_Click(sender As Object, e As EventArgs) Handles btn_Logut.Click
        Dim log As New Login()
        log.Show()
        Me.Hide()
    End Sub
End Class
