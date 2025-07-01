Public Class EventInfo
    Public Property EventName As String
    Public Property EventVenue As String
    Public Property Organization As String
    Public Property DateStart As Date
    Public Property DateEnd As Date

    Public Overrides Function ToString() As String
        Return $"{EventName} at {EventVenue} | {Organization} | {DateStart.ToShortDateString()} - {DateEnd.ToShortDateString()}"
    End Function
End Class
