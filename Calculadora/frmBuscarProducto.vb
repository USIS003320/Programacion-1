Public Class frmBuscarProducto
    Dim objConexion As New db_conexion
    Public _idP As Integer

    Private Sub frmBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarProducto.DataSource = objConexion.obtenerDatos().Tables("Productos").DefaultView
    End Sub
    Private Sub filtrarDatosProductos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarProducto.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or nombre like '%" & valor & "%'"
        grdBuscarProducto.DataSource = bs
    End Sub

    Private Sub btnSeleccionarProducto_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProducto.Click
        _idP = grdBuscarProducto.CurrentRow.Cells("idProducto").Value.ToString()
        Close()
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        filtrarDatosProductos(txtBuscarProducto.Text)
    End Sub

    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        _idP = 0
        Close()
    End Sub
End Class