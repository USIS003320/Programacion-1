Public Class frmProducto
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatosP()
    End Sub
    Sub obtenerDatosP()
        dataTable = objConexion.obtenerDatosP().Tables("Producto")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProducto")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtNombreProducto.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtPedidosProducto.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtPesoProducto.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtCalidadProducto.Text = dataTable.Rows(posicion).ItemArray(4).ToString()

            lblRegistroProducto.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProducto()
            MessageBox.Show("No hay registrp que mostrar", "Registro de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosProducto()
        txtNombreProducto.Text = ""
        txtPedidosProducto.Text = ""
        txtPesoProducto.Text = ""
        txtCalidadProducto.Text = ""
    End Sub

    Private Sub btnPrimeroProducto_Click(sender As Object, e As EventArgs) Handles btnPrimeroProducto.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorProducto_Click(sender As Object, e As EventArgs) Handles btnAnteriorProducto.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteProducto_Click(sender As Object, e As EventArgs) Handles btnSiguienteProducto.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoProducto_Click(sender As Object, e As EventArgs) Handles btnUltimoProducto.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
End Class
