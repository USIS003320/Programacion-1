Public Class frmBuscarPrecio
    Dim objConexion As New db_conexion
    Public _idP As Integer
    Private Sub frmBuscarPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarPrecio.DataSource = objConexion.obtenerDatos().Tables("Productos").DefaultView
    End Sub
    Private Sub filtrarDatosProductos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarPrecio.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or nombre like '%" & valor & "%'"
        grdBuscarPrecio.DataSource = bs
    End Sub
    Private Sub btnSeleccionarProducto_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProducto.Click
        _idP = grdBuscarPrecio.CurrentRow.Cells("idProducto").Value.ToString()
        Close()
    End Sub
    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarPrecio.TextChanged
        filtrarDatosProductos(txtBuscarPrecio.Text)
    End Sub
    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        _idP = 0
        Close()
    End Sub
End Class