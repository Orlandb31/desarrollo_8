Public Class Socio
    Private accSocio, AccTotal As Integer

    Public Sub Establecer(ByVal acc As Integer, ByVal tot As Integer)
        accSocio = acc
        AccTotal = tot
    End Sub

    Public Function CalcularGanancia(ByVal gEmpresa) As Double

        CalcularGanancia = gEmpresa * (accSocio / AccTotal)

    End Function

End Class
