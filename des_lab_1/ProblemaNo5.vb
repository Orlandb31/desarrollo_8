Public Class ProblemaNo5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim subasta(10) As Double
        For i = 0 To 10
            subasta(i) = InputBox("Ingrese su oferta", "Subasta de RACKS")
        Next
        txtalta.Text = Val(Mayor1(subasta))
        txtbaja.Text = Val(des_lab_1.logica.menor(subasta))


    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class