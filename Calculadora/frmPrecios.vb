Public Class frmPrecios
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Productos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProductos")}

        cboPrecio.DataSource = objConexion.obtenerDatos().Tables("Precios").DefaultView()
        cboPrecio.DisplayMember = "precios"
        cboPrecio.ValueMember = "precios.idPrecios"

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()

            cboPrecio.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtPrecios.Text = dataTable.Rows(posicion).ItemArray(2).ToString()

            lblRegistroProducto.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProductos()
            MessageBox.Show("No hay registro que mostrar", "Registro de Precios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosProductos()
        txtPrecios.Text = ""

    End Sub
    Private Sub btnPrimeroProducto_Click(sender As Object, e As EventArgs) Handles btnPrimerProducto.Click
        posicion = 0
        mostrarDatos()
    End Sub
    Private Sub btnAnteriorProducto_Click(sender As Object, e As EventArgs) Handles btnAnteriorProducto.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Precio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoProducto_Click(sender As Object, e As EventArgs) Handles btnUltimoProducto.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub btnSiguienteProducto_Click(sender As Object, e As EventArgs) Handles btnSiguienteProducto.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Precio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatosdeProductos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProducto.Enabled = estado
        btnBuscarProducto.Enabled = estado
    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If btnAgregarProducto.Text = "Nuevo" Then
            btnAgregarProducto.Text = "Guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatosProductos()
        Else
            Dim msg = objConexion.mantenimientoDatosPrecios(New String() {
                Me.Tag, cboPrecio.SelectedValue, txtPrecios.Text
            }, accion)
            MessageBox.Show(msg, "Registro de Precios", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatos()
            HabDescontroles(True)
            btnAgregarProducto.Text = "Nuevo"
            btnModificarProducto.Text = "Modificar"
        End If
    End Sub
    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        If btnModificarProducto.Text = "Modificar" Then
            btnAgregarProducto.Text = "Guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "Modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarProducto.Text = "Nuevo"
            btnModificarProducto.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtPrecios.Text, "Registro de Productos",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Dim msg = objConexion.mantenimientoDatosPrecios(New String() {Me.Tag}, "eliminar")
            If msg IsNot "error" Then
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub
    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim objBuscarPrecio As New frmBuscarPrecio
        objBuscarPrecio.ShowDialog()
        If objBuscarPrecio._idP > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarPrecio._idP))
            mostrarDatos()
        End If
    End Sub
End Class