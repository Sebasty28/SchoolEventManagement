Public Class dataProcess
    Public Shared accounts As New List(Of Account)()
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

    End Sub
    Public Sub LoadNewAccounts(name As String, StudentID As String, organization As String, CourseSection As String, Age As Integer, gender As Char)
        If ValidateStudent(StudentID) Then
            Debug.WriteLine("Student ID already exists: " & StudentID)
            Return
        End If
        accounts.Add(New Account With {
                     .Name = name,
                     .StudentID = StudentID,
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
End Class
