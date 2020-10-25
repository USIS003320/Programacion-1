Public Class frmArqueo
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"
    Private Sub frmArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatosAr()
    End Sub
    Sub obtenerDatosAr()
        dataTable = objConexion.obtenerDatos().Tables("Arqueo")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idArqueo")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtNombreEmpleadoAr.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtDireccionArqueo.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtTelefonoArqueo.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtPagoArqueo.Text = dataTable.Rows(posicion).ItemArray(4).ToString()

            lblRegistroArqueo.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosEmpleado()
            MessageBox.Show("No hay registro que mostrar", "Registro de Arqueo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosEmpleado()
        txtNombreEmpleadoAr.Text = ""
        txtDireccionArqueo.Text = ""
        txtTelefonoArqueo.Text = ""
        txtPagoArqueo.Text = ""
    End Sub

    Private Sub btnPrimeroArqueo_Click(sender As Object, e As EventArgs) Handles btnPrimeroArqueo.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorArqueo_Click(sender As Object, e As EventArgs) Handles btnAnteriorArqueo.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Arqueo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteArqueo_Click(sender As Object, e As EventArgs) Handles btnSiguienteArqueo.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Arqueo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoArqueo_Click(sender As Object, e As EventArgs) Handles btnUltimoArqueo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarArqueo_Click(sender As Object, e As EventArgs) Handles btnAgregarArqueo.Click
        If btnAgregarArqueo.Text = "Nuevo" Then
            btnAgregarArqueo.Text = "Guardar"
            btnModificarArqueo.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatosEmpleado()
        Else
            Dim msg = objConexion.mantenimientoDatosArqueo(New String() {
                Me.Tag, txtNombreEmpleadoAr.Text, txtDireccionArqueo.Text, txtTelefonoArqueo.Text, txtPagoArqueo.Text
            }, accion)
            MessageBox.Show(msg, "Registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatosAr()
            HabDescontroles(True)
            btnAgregarArqueo.Text = "Nuevo"
            btnModificarArqueo.Text = "Modificar"
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarArqueo.Enabled = estado
        btnBuscarArqueo.Enabled = estado
    End Sub

    Private Sub btnModificarArqueo_Click(sender As Object, e As EventArgs) Handles btnModificarArqueo.Click
        If btnModificarArqueo.Text = "Modificar" Then
            btnAgregarArqueo.Text = "Guardar"
            btnModificarArqueo.Text = "Cancelar"
            accion = "Modificar"
            HabDescontroles(False)
        Else
            obtenerDatosAr()
            HabDescontroles(True)
            btnAgregarArqueo.Text = "Nuevo"
            btnModificarArqueo.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarArqueo_Click(sender As Object, e As EventArgs) Handles btnEliminarArqueo.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombreEmpleadoAr.Text, "Registro de empleado",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosArqueo(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatosAr()
        End If
    End Sub

    Private Sub btnBuscarArqueo_Click(sender As Object, e As EventArgs) Handles btnBuscarArqueo.Click
        Dim objBuscarArqueo As New frmBuscarArque
        objBuscarArqueo.ShowDialog()
        If objBuscarArqueo._idAr > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarArqueo._idAr))
            mostrarDatos()
        End If
    End Sub
End Class