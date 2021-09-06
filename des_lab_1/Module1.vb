Module Module1
    Public Function Mayor(ByVal vector() As Integer) As Integer
        Dim contador As Integer
        Mayor = 0
        For contador = 0 To vector.Length - 1
            If vector(contador) >= 37 Then
                Mayor += 1
            End If
        Next
    End Function
    Public Function Menor(ByVal vector() As Integer) As Integer
        Dim contador As Integer
        Menor = 0
        For contador = 0 To vector.Length - 1
            If vector(contador) = 0 Then
                Exit For
            End If
            If vector(contador) <= 33 Then
                Menor += 1
            End If
        Next
    End Function

End Module
