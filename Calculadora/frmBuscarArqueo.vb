Public Class frmBuscarArque
    Dim objConexion As New db_conexion
    Public _idAr As Integer
    Private Sub btnSeleccionarArqueo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarArqueo.Click
        _idAr = grdBuscarArqueo.CurrentRow.Cells("idArqueo").Value.ToString()
        Close()
    End Sub

    Private Sub frmBuscarArque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarArqueo.DataSource = objConexion.obtenerDatos().Tables("Arqueo").DefaultView
    End Sub

    Private Sub txtBuscarArqueo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarArqueo.TextChanged
        filtrarDatosArqueo(txtBuscarArqueo.Text)
    End Sub
    Private Sub filtrarDatosArqueo(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarArqueo.DataSource
        bs.Filter = "Nombre like '%" & valor & "%' or nombre like '%" & valor & "%'"
        grdBuscarArqueo.DataSource = bs
    End Sub

    Private Sub btnCancelarArqueo_Click(sender As Object, e As EventArgs) Handles btnCancelarArqueo.Click
        _idAr = 0
        Close()
    End Sub
End Class