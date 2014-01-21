Public Class MathFuncs
    Public Function AddTwoIntegers(a As Object, b As Object) As Integer
        Dim cati As New Conversion

        Return cati.ConvertAnythingToInteger(a) +
               cati.ConvertAnythingToInteger(b)

    End Function
End Class

