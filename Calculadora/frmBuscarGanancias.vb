Public Class frmBuscarGanancias
    Dim objConexion As New db_conexion
    Public _idG As Integer
    Private Sub frmBuscarGanancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarGanancias.DataSource = objConexion.obtenerDatos().Tables("Ganancias").DefaultView
    End Sub
    Private Sub filtrarDatosGanancias(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarGanancias.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or nombre like '%" & valor & "%'"
        grdBuscarGanancias.DataSource = bs
    End Sub

    Private Sub btnSeleccionarProducto_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProducto.Click
        _idG = grdBuscarGanancias.CurrentRow.Cells("idGanancias").Value.ToString()
        Close()
    End Sub
    Private Sub txtBuscarGanancias_TextChanged(sender As Object, e As EventArgs)
        filtrarDatosGanancias(txtBuscarGanancias.Text)
    End Sub

    Private Sub btnCancelarGanancias_Click(sender As Object, e As EventArgs) Handles btnCancelarGanancias.Click
        _idG = 0
        Close()
    End Sub

End Class
