Public Class Form1
    Dim ObjEstadistica As New Estadistica

    Private Sub btnMediaAritmetica_Click(sender As Object, e As EventArgs) Handles btnMediaAritmetica.Click
        lblRespuestaMedia.Text = ObjEstadistica.calcularMedia(txtSerie.Text.Split(","))
        lblRespuestaVarianza.Text = ObjEstadistica.calcularVarianza(txtSerie.Text.Split(","))
        lblRespuestaDesvTipica.Text = ObjEstadistica.calcularDesvTipica(txtSerie.Text.Split(","))
    End Sub
End Class