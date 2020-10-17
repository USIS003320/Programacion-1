Public Class frmBuscarEmpleados
    Dim objConexion As New db_conexion
    Public _idE As Integer
    Private Sub btnSeleccionarEmpleado_Click(sender As Object, e As EventArgs) Handles btnSeleccionarEmpleado.Click
        _idE = grdBuscarEmpleado.CurrentRow.Cells("idEmpleado").Value.ToString()
        Close()
    End Sub

    Private Sub frmBuscarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarEmpleado.DataSource = objConexion.obtenerDatos().Tables("empleados").DefaultView
    End Sub

    Private Sub txtBuscarEmpleado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarEmpleado.KeyUp
        filtrarDatosEmpleados(txtBuscarEmpleado.Text)
    End Sub
    Private Sub filtrarDatosEmpleados(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarEmpleado.DataSource
        bs.Filter = "nombre like '%" & valor & "%' or nombre like '%" & valor & "%'"
        grdBuscarEmpleado.DataSource = bs
    End Sub

    Private Sub btnCancelarEmpleado_Click(sender As Object, e As EventArgs) Handles btnCancelarEmpleado.Click
        _idE = 0
        Close()
    End Sub
End Class