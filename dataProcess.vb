Imports System.Reflection

Public Class dataProcess
    Public Shared accounts As New List(Of Account)()
    Public Shared events As New List(Of EventInfo)()

    Public Sub New()
        LoadDummyAccounts()
    End Sub

    Public Sub LoadDummyAccounts()

        accounts.Add(New Account With {
                     .Name = "DARREL",
                     .StudentID = "2025-001-BN-0",
                     .Age = 20,
                     .CourseSection = "BSIT 2-1",
                     .Organization = "IBITS",
                     .Gender = "M"c})

        accounts.Add(New Account With {
                     .Name = "ADMIN",
                     .StudentID = "2025-002-ADMIN-0"})

    End Sub

    Public Sub LoadNewAccounts(name As String, StudentID As String, email As String, organization As String, CourseSection As String, Age As Integer, gender As Char)
        If ValidateStudent(StudentID) Then
            Debug.WriteLine("Student ID already exists: " & StudentID)
            Return
        End If
        accounts.Add(New Account With {
                     .Name = name,
                     .StudentID = StudentID,
                     .Email = email,
                     .Age = Age,
                     .CourseSection = CourseSection,
                     .Organization = organization,
                     .Gender = gender})
        Debug.WriteLine("New account added: " & name & ", ID: " & StudentID)
    End Sub

    Public Function GenerateStudentID() As String
        Dim AccountCount As Integer = accounts.Count
        Dim studentID As String = $"2025-{AccountCount + 1:D3}-BN-0"
        Return studentID
    End Function

    Public Function ValidateStudent(studentID As String) As Boolean
        For Each account As Account In accounts
            If account.StudentID = studentID Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function GetAccounts() As List(Of Account)
        Return accounts
    End Function

    Public Sub AddEvent(eventInfo As EventInfo)
        events.Add(eventInfo)
        Debug.WriteLine("Event added: " & eventInfo.EventName)
    End Sub

    Public Sub DeleteEvent(eventName As String)
        For i As Integer = 0 To events.Count - 1
            If events(i).EventName = eventName Then
                events.RemoveAt(i)
                Debug.WriteLine("Event deleted: " & eventName)
                Exit For
            End If
        Next
    End Sub

    Public Function GetEvents() As List(Of EventInfo)
        Return events
    End Function

    Public Sub UpdateEvent(originalName As String, updatedEvent As EventInfo)
        For i As Integer = 0 To events.Count - 1
            If events(i).EventName = originalName Then
                events(i) = updatedEvent
                Debug.WriteLine("Event updated: " & updatedEvent.EventName)
                Exit For
            End If
        Next
    End Sub
End Class
