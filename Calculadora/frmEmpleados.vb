Public Class frmEmpleados
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Empleados")

        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigoEmpleado.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombreEmpleado.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDireccionEmpleado.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtTelefonoEmpleado.Text = dataTable.Rows(posicion).ItemArray(4).ToString()

            lblRegistroEmpleado.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosEmpleado()
            MessageBox.Show("No hay registrp que mostrar", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroEmpleado_Click(sender As Object, e As EventArgs) Handles btnPrimeroEmpleado.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteEmpleado_Click(sender As Object, e As EventArgs) Handles btnSiguienteEmpleado.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorEmpleado_Click(sender As Object, e As EventArgs) Handles btnAnteriorEmpleado.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoEmpleado_Click(sender As Object, e As EventArgs) Handles btnUltimoEmpleado.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        If btnAgregarEmpleado.Text = "Nuevo" Then
            btnAgregarEmpleado.Text = "Guardar"
            btnModificarEmpleado.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatosEmpleado()
        Else
            Dim msg = objConexion.mantenimientoDatosEmpleado(New String() {
                Me.Tag, txtCodigoEmpleado.Text, txtNombreEmpleado.Text, txtDireccionEmpleado.Text, txtTelefonoEmpleado.Text
            }, accion)
            MessageBox.Show(msg, "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatos()
            HabDescontroles(True)
            btnAgregarEmpleado.Text = "Nuevo"
            btnModificarEmpleado.Text = "Modificar"
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarEmpleado.Enabled = estado
        btnBuscarEmpleado.Enabled = estado
    End Sub

    Private Sub limpiarDatosEmpleado()
        txtCodigoEmpleado.Text = ""
        txtNombreEmpleado.Text = ""
        txtDireccionEmpleado.Text = ""
        txtTelefonoEmpleado.Text = ""
    End Sub

    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        If btnModificarEmpleado.Text = "Modificar" Then
            btnAgregarEmpleado.Text = "Guardar"
            btnModificarEmpleado.Text = "Cancelar"
            accion = "Modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarEmpleado.Text = "Nuevo"
            btnModificarEmpleado.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombreEmpleado.Text, "Registro de empleado",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosEmpleado(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If
    End Sub
End Class