Imports System.Reflection

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

        data.AddEvent(newEvent)

        MessageBox.Show("EVENT CREATED SUCCESSFULLY!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RefreshEventList()
    End Sub
    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        If lb_Events.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event to update.")
            Exit Sub
        End If

        Dim selectedLine As String = lb_Events.SelectedItem.ToString()
        Dim selectedName As String = selectedLine.Split("]"c)(0).Replace("[", "").Trim()

        Dim updatedEvent As New EventInfo()
        updatedEvent.EventName = tb_name.Text
        updatedEvent.EventVenue = txtb_Venue.Text
        updatedEvent.Organization = txtb_dateEnd.Text
        updatedEvent.DateStart = DateTime.Parse(TextBox1.Text)
        updatedEvent.DateEnd = DateTime.Parse(txtb_dateStart.Text)

        data.UpdateEvent(selectedName, updatedEvent)

        MessageBox.Show("Event updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RefreshEventList()
    End Sub
    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If lb_Events.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event to delete.")
            Exit Sub
        End If

        Dim selectedLine As String = lb_Events.SelectedItem.ToString()
        Dim selectedName As String = selectedLine.Split("]"c)(0).Replace("[", "").Trim()

        data.DeleteEvent(selectedName)

        MessageBox.Show("Event deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RefreshEventList()
    End Sub
    Private Sub RefreshEventList()
        lb_Events.Items.Clear()

        Dim allEvents As List(Of EventInfo) = data.GetEvents()

        For Each ev As EventInfo In allEvents
            Dim display As String = "[ " & ev.EventName & " ] at " & ev.EventVenue & " | " & ev.Organization & " | " & ev.DateStart.ToShortDateString() & " - " & ev.DateEnd.ToShortDateString()
            lb_Events.Items.Add(display)
        Next
    End Sub
    Private Sub lb_Events_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_Events.SelectedIndexChanged
        If lb_Events.SelectedIndex = -1 Then
            Exit Sub
        End If

        Dim selectedLine As String = lb_Events.SelectedItem.ToString()
        Dim selectedName As String = selectedLine.Split("]"c)(0).Replace("[", "").Trim()

        Dim foundEvents As List(Of EventInfo) = data.GetEvents()

        For Each ev As EventInfo In foundEvents
            If ev.EventName = selectedName Then
                tb_name.Text = ev.EventName
                txtb_Venue.Text = ev.EventVenue
                txtb_dateEnd.Text = ev.Organization
                TextBox1.Text = ev.DateStart.ToString("yyyy-MM-dd")
                txtb_dateStart.Text = ev.DateEnd.ToString("yyyy-MM-dd")
                Exit For
            End If
        Next
    End Sub
    Private Sub btn_Logut_Click(sender As Object, e As EventArgs) Handles btn_Logut.Click
        Dim log As New Login()
        log.Show()
        Me.Hide()
    End Sub


End Class