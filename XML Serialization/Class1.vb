Public Class Employee
    Public Property EmpName As String
    Public Property EmpID As String

    Public Property EmpList As String()


    Public Sub New()
    End Sub

    Public Sub New(empName As String, empID As String)
        empName = empName
        empID = empID
    End Sub
End Class
