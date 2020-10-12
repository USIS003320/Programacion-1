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




End Class
