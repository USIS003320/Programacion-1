Public Class frmGanancias
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmGanancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Productos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProducto")}

        cboCategoriaGanancias.DataSource = objConexion.obtenerDatos().Tables("Ganancias").DefaultView()
        cboCategoriaGanancias.DisplayMember = "Ganancias"
        cboCategoriaGanancias.ValueMember = "Ganancias.idProducto"

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()

            cboCategoriaGanancias.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtPrecioVentas.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtPrecioCompras.Text = dataTable.Rows(posicion).ItemArray(3).ToString()

            lblRegistroGanancias.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProductos()
            MessageBox.Show("No hay registro que mostrar", "Registro de Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosProductos()
        txtPrecioVentas.Text = ""
        txtPrecioCompras.Text = ""
    End Sub

    Private Sub btnPrimerGanancias_Click(sender As Object, e As EventArgs) Handles btnPrimerGanancias.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorGanancias_Click(sender As Object, e As EventArgs) Handles btnAnteriorGanancias.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteGanancias_Click(sender As Object, e As EventArgs) Handles btnSiguienteGanancias.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Ganancias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoGanancias_Click(sender As Object, e As EventArgs) Handles btnUltimoGanancias.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatosdeGanancias.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarGanancias.Enabled = estado
        btnBuscarGanancias.Enabled = estado
    End Sub

    Private Sub btnAgregarGanancias_Click(sender As Object, e As EventArgs) Handles btnAgregarGanancias.Click
        If btnAgregarGanancias.Text = "Nuevo" Then
            btnAgregarGanancias.Text = "Guardar"
            btnModificarGanancias.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatosProductos()
        Else
            Dim msg = objConexion.mantenimientoDatosProductos(New String() {
                Me.Tag, cboCategoriaGanancias.SelectedValue, txtPrecioVentas.Text, txtPrecioCompras.Text
            }, accion)
            MessageBox.Show(msg, "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatos()
            HabDescontroles(True)
            btnAgregarGanancias.Text = "Nuevo"
            btnModificarGanancias.Text = "Modificar"
        End If
    End Sub

    Private Sub btnModificarGanancias_Click(sender As Object, e As EventArgs) Handles btnModificarGanancias.Click
        If btnModificarGanancias.Text = "Modificar" Then
            btnAgregarGanancias.Text = "Guardar"
            btnModificarGanancias.Text = "Cancelar"
            accion = "Modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarGanancias.Text = "Nuevo"
            btnModificarGanancias.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarGanancias_Click(sender As Object, e As EventArgs) Handles btnEliminarGanancias.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtPrecioVentas.Text, "Registro de Ganancias",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Dim msg = objConexion.mantenimientoDatosGanancias(New String() {Me.Tag}, "eliminar")
            If msg IsNot "error" Then
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub

    Private Sub btnBuscarGanancias_Click(sender As Object, e As EventArgs) Handles btnBuscarGanancias.Click
        Dim objBuscarGanancia As New frmBuscarGanancias
        objBuscarGanancia.ShowDialog()
        If objBuscarGanancia._idG > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarGanancia._idG))
            mostrarDatos()
        End If
    End Sub
End Class
