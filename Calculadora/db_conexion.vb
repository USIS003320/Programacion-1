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

        miCommand.CommandText = "select * from Proveedor"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Proveedor")


        miCommand.CommandText = "select * from Productos"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Productos")

        miCommand.CommandText = "select * from categorias"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "categorias")

        miCommand.CommandText = "select * from Arqueo"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Arqueo")

        miCommand.CommandText = "select * from Ganancias"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Ganancias")

        miCommand.CommandText = "select * from compras"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "compras")

        miCommand.CommandText = "select * from dcompras"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "dcompras")

        miCommand.CommandText = "select * from pagos"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "pagos")

        miCommand.CommandText = "select * from tipofactura"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "tipofactura")


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
    Public Function mantenimientoDatosProductos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "Nuevo"
                sql = "INSERT INTO Productos (idCategoria,codigo,nombre,pedidos,medidas) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE Productos SET idCategoria='" + datos(1) + "',codigo='" + datos(2) + "',nombre='" + datos(3) + "',pedidos='" + datos(4) + "',medidas='" + datos(5) + "' WHERE idProducto='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Productos WHERE idProducto='" + datos(0) + "'"
        End Select
        If executesql(sql) > 0 Then
            msg = "Accion terminada con exito"
        Else
            msg = "Fallo el proceso"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosProveedor(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "Nuevo"
                sql = "INSERT INTO Proveedor (codigo,nombre,direccion,telefono) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "modificar"
                sql = "UPDATE Proveedor SET codigo='" + datos(1) + "',nombre='" + datos(2) + "',direccion='" + datos(3) + "',telefono='" + datos(4) + "' WHERE idProveedor='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Proveedor WHERE idProveedor='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion terminada con exito"
        Else
            msg = "Fallo el proceso"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosArqueo(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "Nuevo"
                sql = "INSERT INTO Arqueo (Nombre de Empleados,Direccion,Telefono,Forma de Pago) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "modificar"
                sql = "UPDATE Arqueo SET Nombre de Empleados='" + datos(1) + "',Direccion='" + datos(2) + "',Telefono='" + datos(3) + "',Forma de Pago='" + datos(4) + "' WHERE idArqueo='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Arqueo WHERE idArqueo='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion terminada con exito"
        Else
            msg = "Fallo el proceso"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosGanancias(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "Nuevo"
                sql = "INSERT INTO Ganancias (idProducto,PreciodeVenta,PreciodeCompra) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "')"
            Case "modificar"
                sql = "UPDATE Ganancias SET idProducto='" + datos(1) + "',PreciodeVenta='" + datos(2) + "',PreciodeCompra='" + datos(3) + "' WHERE idGanancias='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Ganancias WHERE idGanancias='" + datos(0) + "'"
        End Select
        If executesql(sql) > 0 Then
            msg = "Accion terminada con exito"
        Else
            msg = "Fallo el proceso"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosCompras(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "Nuevo"
                sql = "INSERT INTO compras (nfactura, Fecha_compra,fecha_hora_registro,idTipofactura,idPago,idProveedor) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE compras SET nfactura='" + datos(1) + "',fecha_compra='" + datos(2) + "',fecha_hora_registro='" + datos(3) + "',idTipofactura='" + datos(4) + "',idPago='" + datos(5) + "',idProveedor='" + datos(5) + "' WHERE idCompra='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM compras WHERE idCompra='" + datos(0) + "'"
        End Select
        If executesql(sql) > 0 Then
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

    Friend Function mantenimientoDatosProveedores(v() As String, accion As String) As Object
        Throw New NotImplementedException()
    End Function
End Class
