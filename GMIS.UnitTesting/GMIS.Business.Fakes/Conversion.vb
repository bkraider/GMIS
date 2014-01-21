Public Class Conversion
    Function ConvertAnythingToInteger(ByVal obj As Object) As Integer
        Dim i As Integer = 0
        i = Convert.ToInt32(obj)
        Return i
    End Function
End Class
