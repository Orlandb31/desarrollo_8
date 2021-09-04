Public Class ProblemaNo2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim edejuan, edealberto, edeana, edegisela As Integer

        edejuan = Val(txtEdaddejuan.Text)

        If edejuan >= 0 Then
            edealberto = CInt(edejuan * (2 / 3))
            edeana = CInt(edejuan * (4 / 3))
            edegisela = edejuan + edeana + edealberto
            txtAlberto.Text = edealberto
            txtAna.Text = edeana
            txtMdeGisela.Text = edegisela
            txtJuan.Text = edejuan
        Else
            MsgBox("Debe ser un Número positivo")
            txtEdaddejuan.Clear()
        End If
    End Sub
End Class