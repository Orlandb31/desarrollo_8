Public Class ProblemaNo3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim accSocio1, accSocio2, accSocio3 As Integer
        Dim cantAcciones As Integer
        Dim Socio1, Socio2, Socio3 As New Socio

        accSocio1 = 35
        accSocio2 = 40
        accSocio3 = 25

        cantAcciones = accSocio1 + accSocio2 + accSocio3

        Socio1.Establecer(accSocio1, cantAcciones)
        Socio2.Establecer(accSocio2, cantAcciones)
        Socio3.Establecer(accSocio3, cantAcciones)

        txtSocio1.Text = Format(Socio1.CalcularGanancia(Val(txtGanacias.Text)), "#.##")
        txtSocio2.Text = Format(Socio2.CalcularGanancia(Val(txtGanacias.Text)), "#.##")
        txtSocio3.Text = Format(Socio3.CalcularGanancia(Val(txtGanacias.Text)), "#.##")


    End Sub
End Class