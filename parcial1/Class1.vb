Public Class Calculator

    Public Function Sum(ByVal numero1 As Double, ByVal numero2 As Double) As Double
        Return numero1 + numero2
    End Function

    Public Function Substraction(ByVal numero1 As Double, ByVal numero2 As Double) As Double
        Return numero1 - numero2
    End Function

    Public Function Multi(ByVal numero1 As Double, ByVal numero2 As Double) As Double
        Return numero1 * numero2
    End Function

    Public Function Division(ByVal numero1 As Double, ByVal numero2 As Double) As Double
        If numero2 = 0 Then
            Throw New ArgumentException("No se puede dividir por cero.")
        End If
        Return numero1 / numero2
    End Function

End Class
