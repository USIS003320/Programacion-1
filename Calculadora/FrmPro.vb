Public Class FrmPro
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "Nuevo"

    Private Sub FrmPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos1()
    End Sub

    Private Sub obtenerDatos1()
        dataTable = objConexion.obtenerDatos().Tables("Tables")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProveedor")}
        mostrarDatos()
    End Sub

    Private Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            TextBox1.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            TextBox2.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            TextBox3.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            TextBox4.Text = dataTable.Rows(posicion).ItemArray(4).ToString()

            Label1.Text = posicion + 1 & " de " & dataTable.Rows.Count
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Proveedores.", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro", "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "Nuevo" Then
            Button5.Text = "Guardar"
            Button5.Text = "Cancelar"
            accion = "Nuevo"

            HabDescontroles(False)
            limpiarDatosProveedor()
        Else
            Dim msg = objConexion.mantenimientoDatosProveedores(New String() {
                Me.Tag, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text
                }, accion)
            MessageBox.Show(msg, "Registro de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)

            obtenerDatos()
            HabDescontroles(True)
            Button5.Text = "Nuevo"
            Button6.Text = "Modificar"
        End If
    End Sub

    Private Sub limpiarDatosProveedor()
        Throw New NotImplementedException()
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        GroupBox2.Enabled = Not estado
        GroupBox3.Enabled = estado
        Button7.Enabled = estado
        Button8.Enabled = estado

    End Sub
End Class