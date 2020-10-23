Public Class frmBuscarProveedor
    Dim objConexion As New db_conexion
    Public _idR As Integer
    Private Sub btnSeleccionarProveedor_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProveedor.Click
        _idR = grdBuscarProveedor.CurrentRow.Cells("idProveedor").Value.ToString()
        Close()
    End Sub

    Private Sub frmBuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarProveedor.DataSource = objConexion.obtenerDatos().Tables("Proveedor").DefaultView
    End Sub
    Private Sub filtrarDatosProveedor(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarProveedor.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or nombre like '%" & valor & "%'"
        grdBuscarProveedor.DataSource = bs
    End Sub

    Private Sub btnCancelarProveedor_Click(sender As Object, e As EventArgs) Handles btnCancelarProveedor.Click
        _idR = 0
        Close()
    End Sub
End Class