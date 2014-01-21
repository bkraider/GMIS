
Public Class Calculator

    Function Add(p1 As Integer, p2 As Integer) As Integer
        Return p1 + p2
    End Function

    Function Subtract(p1 As Integer, p2 As Integer) As Integer
        Return p1 - p2
    End Function

    Function Multiply(p1 As Integer, p2 As Integer) As Integer
        Return p1 * p2
    End Function

    Function Divide(p1 As Integer, p2 As Integer) As Integer
        If p2 = 0 Then
            Throw New ArgumentOutOfRangeException
        End If
        Return p1 / p2
    End Function

End Class
