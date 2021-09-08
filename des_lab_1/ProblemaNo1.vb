Public Class ProblemaNo1
    Private Sub cal_Click(sender As Object, e As EventArgs) Handles cal.Click

        Dim sb, sn, snt As Double

        sb = Val(horas.Text) * Val(tarifa.Text)
        snt = sb * 0.12
        sn = sb - snt
        bruto.Text = sb
        neto.Text = sn

    End Sub
End Class