Public Class ProblemaNo4
    Private Sub BtnEjucutar_Click(sender As Object, e As EventArgs) Handles btnEjucutar.Click
        Dim temperaturas(), temp, i As Integer
        i = 0
        temp = 1
        ReDim temperaturas(i)
        Do While temp <> 0
            temp = InputBox("ingrese un numero", "cargar un numero")
            temperaturas(i) = temp
            ReDim Preserve temperaturas(i + 1)
            i += 1
        Loop
        tbMayor.Text() = Mayor(temperaturas)
        tbMen.Text() = des_lab_1.Module1.Menor(temperaturas)
        tbTotal.Text() = temperaturas.Length - 2
        Label2.Show()
        Label3.Show()
        Label4.Show()
        tbMayor.Show()
        tbMen.Show()
        tbTotal.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        tbMayor.Hide()
        tbMen.Hide()
        tbTotal.Hide()
    End Sub

End Class