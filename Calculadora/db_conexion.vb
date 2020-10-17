Imports System.Data
Imports System.Data.SqlClient

Public Class db_conexion
    Dim miConexion = New SqlConnection
    Dim miCommand = New SqlCommand
    Dim miAdapter As New SqlDataAdapter
    Dim ds As New DataSet

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()
    End Sub

    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select * from empleados"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "empleados")

        Return ds
    End Function
    Public Function mantenimientoDatosEmpleado(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "Nuevo"
                sql = "INSERT INTO empleados (codigo,nombre,direccion,telefono) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "modificar"
                sql = "UPDATE empleados SET codigo='" + datos(1) + "',nombre='" + datos(2) + "',direccion='" + datos(3) + "',telefono='" + datos(4) + "' WHERE idEmpleado='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM empleados WHERE idEmpleado='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion terminada con exito"
        Else
            msg = "Fallo el proceso"
        End If
        Return msg
    End Function

    Private Function executesql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function

End Class
