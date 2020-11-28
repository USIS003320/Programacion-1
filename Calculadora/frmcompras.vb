Public Class frmCompras
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("compras")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCompra")}

        cboProveedor.DataSource = objConexion.obtenerDatos().Tables("Proveedor").DefaultView()
        cboProveedor.DisplayMember = "nombre"
        cboProveedor.ValueMember = "nombre.IdProveedor "

        'cboTipoFactura.DataSource = objConexion.obtenerDatos().Tables("tipofactura").DefaultView()
        'cboProveedor.DisplayMember = "Tipofactura"
        'cboProveedor.ValueMember = "tipofactura.idTipofactura"

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()

            cboProveedor.SelectedValue = dataTable.Rows(posicion).ItemArray(3).ToString()
            cboFormapago.SelectedValue = dataTable.Rows(posicion).ItemArray(2).ToString()
            cboTipoFactura.SelectedValue = dataTable.Rows(posicion).ItemArray(3).ToString()
            cboFormapago.SelectedValue = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtFactura.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            dtpFecha.Value = dataTable.Rows(posicion).ItemArray(6).ToString()

            lblRegistroCompra.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatoscompras()
            MessageBox.Show("No hay registro que mostrar", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatoscompras()
        txtFactura.Text = ""
    End Sub

    Private Sub btnPrimerCompra_Click(sender As Object, e As EventArgs) Handles btnPrimerCompra.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorcompra_Click(sender As Object, e As EventArgs) Handles btnAnteriorcompra.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimaCompra_Click(sender As Object, e As EventArgs) Handles btnUltimaCompra.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteCompra_Click(sender As Object, e As EventArgs) Handles btnSiguienteCompra.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbEdicion.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarCompra.Enabled = estado
        btnBuscarCompra.Enabled = estado
    End Sub

    Private Sub btnAgregarCompra_Click(sender As Object, e As EventArgs) Handles btnAgregarCompra.Click
        If btnAgregarCompra.Text = "Nuevo" Then
            btnAgregarCompra.Text = "Guardar"
            btnModificarCompra.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatoscompras()
        Else
            Dim msg = objConexion.mantenimientoDatosProductos(New String() {
                Me.Tag, cboProveedor.SelectedValue, dtpFecha.Value, cboTipoFactura.SelectedValue, cboFormapago.SelectedValue, txtFactura.Text
            }, accion)
            MessageBox.Show(msg, "Registro de compra", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatos()
            HabDescontroles(True)
            btnAgregarCompra.Text = "Nuevo"
            btnModificarCompra.Text = "Modificar"
        End If
    End Sub

    Private Sub btnModificarCompra_Click(sender As Object, e As EventArgs) Handles btnModificarCompra.Click
        If btnModificarCompra.Text = "Modificar" Then
            btnAgregarCompra.Text = "Guardar"
            btnModificarCompra.Text = "Cancelar"
            accion = "Modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarCompra.Text = "Nuevo"
            btnModificarCompra.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarCompra_Click(sender As Object, e As EventArgs) Handles btnEliminarCompra.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtFactura.Text, "Registro de compra",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Dim msg = objConexion.mantenimientoDatosCompras(New String() {Me.Tag}, "eliminar")
            If msg IsNot "error" Then
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub
End Class