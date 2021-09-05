Module logica
    Public Function Mayor1(ByVal subasta() As Double) As Double
        Dim contador As Integer
        Dim mayor = subasta(0)

        For i = 0 To subasta.Length - 1
            If (subasta(i) > mayor) Then
                mayor = subasta(i)
            End If
        Next
        Mayor1 = mayor
    End Function

    Public Function menor(ByVal subasta() As Double) As Double
        Dim contador As Integer
        Dim pequeño = subasta(0)
        For i = 0 To subasta.Length - 1
            If (subasta(i) <= pequeño) Then
                pequeño = subasta(i)
            End If
        Next
        menor = pequeño
    End Function

End Module
