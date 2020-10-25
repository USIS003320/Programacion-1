Public Class frmProveedor
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Proveedor")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProveedor")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigodeProveedor.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombredeProveedor.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDirecciondeProveedor.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtTelefonodeProveedor.Text = dataTable.Rows(posicion).ItemArray(4).ToString()

            lblRegistroProveedor.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProveedor()
            MessageBox.Show("No hay registro que mostrar", "Registro de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimerProveedor_Click(sender As Object, e As EventArgs) Handles btnPrimerProveedor.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteProveedor_Click(sender As Object, e As EventArgs) Handles btnSiguienteProveedor.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorProveedor_Click(sender As Object, e As EventArgs) Handles btnAnteriorProveedor.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoProveedor_Click(sender As Object, e As EventArgs) Handles btnUltimoProveedor.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        If btnAgregarProveedor.Text = "Nuevo" Then
            btnAgregarProveedor.Text = "Guardar"
            btnModificarProveedor.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatosProveedor()
        Else
            Dim msg = objConexion.mantenimientoDatosProveedor(New String() {
                Me.Tag, txtCodigodeProveedor.Text, txtNombredeProveedor.Text, txtDirecciondeProveedor.Text, txtTelefonodeProveedor.Text
            }, accion)
            MessageBox.Show(msg, "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatos()
            HabDescontroles(True)
            btnAgregarProveedor.Text = "Nuevo"
            btnModificarProveedor.Text = "Modificar"
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProveedor.Enabled = estado
        btnBuscarProveedor.Enabled = estado
    End Sub

    Private Sub limpiarDatosProveedor()
        txtCodigodeProveedor.Text = ""
        txtNombredeProveedor.Text = ""
        txtDirecciondeProveedor.Text = ""
        txtTelefonodeProveedor.Text = ""
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        If btnModificarProveedor.Text = "Modificar" Then
            btnAgregarProveedor.Text = "Guardar"
            btnModificarProveedor.Text = "Cancelar"
            accion = "Modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarProveedor.Text = "Nuevo"
            btnModificarProveedor.Text = "Modificar"
        End If

    End Sub

    Private Sub btnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnEliminarProveedor.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombredeProveedor.Text, "Registro de Proveedor",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosProveedor(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Dim objBuscarProveedor As New frmBuscarProveedor
        objBuscarProveedor.ShowDialog()
        If objBuscarProveedor._idR > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarProveedor._idR))
            mostrarDatos()
        End If
    End Sub
End Class