Public Class frmcajapago
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"

    Private Sub frmcajapago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("cajapago")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCajapago")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigocliente.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombrecliente.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtformadepago.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtsalidapago.Text = dataTable.Rows(posicion).ItemArray(4).ToString()

            lblRegistrocliente.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosEmpleado()
            MessageBox.Show("No hay registro que mostrar", "Registro de cajapago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimerocliente_Click(sender As Object, e As EventArgs) Handles btnPrimerocliente.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguientecliente_Click(sender As Object, e As EventArgs) Handles btnSiguientecliente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de cajapago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorcliente_Click(sender As Object, e As EventArgs) Handles btnAnteriorcliente.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de cajapago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimocliente_Click(sender As Object, e As EventArgs) Handles btnUltimocliente.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarcliente_Click(sender As Object, e As EventArgs) Handles btnAgregarcliente.Click
        If btnAgregarcliente.Text = "Nuevo" Then
            btnAgregarcliente.Text = "Guardar"
            btnModificarcliente.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatosEmpleado()
        Else
            Dim msg = objConexion.mantenimientoDatosEmpleado(New String() {
                Me.Tag, txtCodigocliente.Text, txtNombrecliente.Text, txtCodigocliente.Text, txtsalidapago.Text
            }, accion)
            MessageBox.Show(msg, "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatos()
            HabDescontroles(True)
            btnAgregarcliente.Text = "Nuevo"
            btnModificarcliente.Text = "Modificar"
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbCajadepagos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarcliente.Enabled = estado
        btnBuscarcliente.Enabled = estado
    End Sub
    Private Sub limpiarDatosEmpleado()
        txtCodigocliente.Text = ""
        txtNombrecliente.Text = ""
        txtformadepago.Text = ""
        txtsalidapago.Text = ""
    End Sub

    Private Sub btnModificarcliente_Click(sender As Object, e As EventArgs) Handles btnModificarcliente.Click
        If btnModificarcliente.Text = "Modificar" Then
            btnAgregarcliente.Text = "Guardar"
            btnModificarcliente.Text = "Cancelar"
            accion = "Modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarcliente.Text = "Nuevo"
            btnModificarcliente.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarcliente_Click(sender As Object, e As EventArgs) Handles btnEliminarcliente.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombrecliente.Text, "Registro de cajapago",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatoscajapago(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarcliente_Click(sender As Object, e As EventArgs) Handles btnBuscarcliente.Click
        'Dim objBuscarcliente As New frmBuscarEmpleados
        'objBuscarcliente.ShowDialog()
        'If objBuscarcliente._idE > 0 Then
        'posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarcliente._idE))
        'mostrarDatos()
        'End If
    End Sub
End Class