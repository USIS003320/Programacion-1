Public Class frmEmpleados
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Empleados")

        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        MessageBox.Show("Nombre: " + dataTable.Rows(0).ItemArray(2).ToString())
    End Sub
End Class