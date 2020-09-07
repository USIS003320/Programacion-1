Public Class Form1
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click

        If cbxEntrada.Text = "Pie Cuadrado" And cbxSalida.Text = "Vara Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.36
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxSalida.Text = "Yarda Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 9
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxSalida.Text = "Metro Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 10.764
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxSalida.Text = "Tareas" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 628.8
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxSalida.Text = "Manzana" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 70.44
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxSalida.Text = "Hectarea" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 107639
        End If

        If cbxEntrada.Text = "Vara Cuadrada" And cbxSalida.Text = "Pie Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 2.74
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxSalida.Text = "Yarda Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.91
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxSalida.Text = "Metro Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.83
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxSalida.Text = "Tareas" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 1000
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxSalida.Text = "Manzana" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 10000
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxSalida.Text = "Hectarea" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.00006987
        End If

        If cbxEntrada.Text = "Yarda Cuadrada" And cbxSalida.Text = "Vara Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 1.09
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxSalida.Text = "Pie Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 9
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxSalida.Text = "Metro Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 1.196
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxSalida.Text = "Tareas" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.3649
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxSalida.Text = "Manzana" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.00010854
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxSalida.Text = "Hectarea" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 11960
        End If

        If cbxEntrada.Text = "Metro Cuadrado" And cbxSalida.Text = "Vara Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 1.19
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxSalida.Text = "Pie Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 10.76
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxSalida.Text = "Yarda Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 1.196
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxSalida.Text = "Tareas" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 1000
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxSalida.Text = "Manzana" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.0001434
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxSalida.Text = "Hectarea" Then
            lblRespuesta.Text = Val(txtCantidad.Text) / 10000
        End If


        If cbxEntrada.Text = "Tareas" And cbxSalida.Text = "Vara Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 624.29
        ElseIf cbxEntrada.Text = "Tareas" And cbxSalida.Text = "Pie Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 470382
        ElseIf cbxEntrada.Text = "Tareas" And cbxSalida.Text = "Yarda Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 522.64
        ElseIf cbxEntrada.Text = "Tareas" And cbxSalida.Text = "Metro Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 437
        ElseIf cbxEntrada.Text = "Tareas" And cbxSalida.Text = "Manzana" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.06
        ElseIf cbxEntrada.Text = "Tareas" And cbxSalida.Text = "Hectarea" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.04
        End If

        If cbxEntrada.Text = "Manzana" And cbxSalida.Text = "Vara Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 10000
        ElseIf cbxEntrada.Text = "Manzana" And cbxSalida.Text = "Pie Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 75220.68
        ElseIf cbxEntrada.Text = "Manzana" And cbxSalida.Text = "Yarda Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 8424.55
        ElseIf cbxEntrada.Text = "Manzana" And cbxSalida.Text = "Metro Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 7044
        ElseIf cbxEntrada.Text = "Manzana" And cbxSalida.Text = "Tareas" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 11.202
        ElseIf cbxEntrada.Text = "Manzana" And cbxSalida.Text = "Hectarea" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 0.69
        End If


        If cbxEntrada.Text = "Hectarea" And cbxSalida.Text = "Vara cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 14233
        ElseIf cbxEntrada.Text = "Hectarea" And cbxSalida.Text = "Pie Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 107639
        ElseIf cbxEntrada.Text = "Hectarea" And cbxSalida.Text = "Yarda Cuadrada" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 11960
        ElseIf cbxEntrada.Text = "Hectarea" And cbxSalida.Text = "Metro Cuadrado" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 10000
        ElseIf cbxEntrada.Text = "Hectarea" And cbxSalida.Text = "Tareas" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 15.903
        ElseIf cbxEntrada.Text = "Hectarea" And cbxSalida.Text = "Manzana" Then
            lblRespuesta.Text = Val(txtCantidad.Text) * 1.419
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respuesta, unidad, cantidad As String

        respuesta = txtrespuesta2.Text
        unidad = txtUnidades.Text
        cantidad = txtCantidad2.Text

        txtrespuesta2.Text = (cantidad \ unidad).ToString() + "/" + (cantidad Mod unidad).ToString()

    End Sub
End class