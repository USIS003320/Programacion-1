Public Class Form1
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 10
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 1000
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 1000000
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.0394
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.00328084
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.00109361
            lblNum1.Text = "yard"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.000000621371
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.0001
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Milimetros" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.01
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 10
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 100
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 10000
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.0394
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.00328084
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.00109361
            lblNum1.Text = "yard"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.000000621371
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.001
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Centimetros" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.1
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1000
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 100
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 1000
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 39.37
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 3.28
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1.09
            lblNum1.Text = "yard"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.000000621371
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.1
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Metros" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 10
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 100000
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "kilometros" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 100000
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1000
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 39.37
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 3937
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1093
            lblNum1.Text = "yard"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 0.621371
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 100
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Kilometros" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 10000
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 25.4
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 2.54
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 39.37
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 39370
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 12
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 36
            lblNum1.Text = "yard"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 63360
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 394
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Pulgadas" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 3.937
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 305
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 30.48
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 3.281
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 3281
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 12
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 3
            lblNum1.Text = "yard"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 5280
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 32.808
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Pie" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 3.048
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "yard"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 914
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 91.44
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 1.094
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 1094
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 36
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 3
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 1760
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 10.936
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Yarda" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 9.144
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1609000.0
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 160934
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 1609
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1.609
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 63360
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 5280
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1760
            lblNum1.Text = "yarda"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 161
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Milla" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 16093
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "dam"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 10000
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 1000
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 10
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 100
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 394
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 32.808
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 10.936
            lblNum1.Text = "yarda"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 161
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Decámetro" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 100
            lblNum1.Text = "dm"
        End If

        If cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Decímetro" Then
            lblRespuesta.Text = Val(txtNum1.Text)
            lblNum1.Text = "dm"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Milimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 100
            lblNum1.Text = "mm"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Centimetros" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 10
            lblNum1.Text = "cm"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Metros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 10
            lblNum1.Text = "m"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Kilometros" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 10000
            lblNum1.Text = "km"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Pulgadas" Then
            lblRespuesta.Text = Val(txtNum1.Text) * 3.937
            lblNum1.Text = "pulg"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Pie" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 3.048
            lblNum1.Text = "pie"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Yarda" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 9.144
            lblNum1.Text = "yarda"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Milla" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 16093
            lblNum1.Text = "milla"
        ElseIf cbxEntrada.Text = "Decímetro" And cbxSalida1.Text = "Decámetro" Then
            lblRespuesta.Text = Val(txtNum1.Text) / 100
            lblNum1.Text = "dam"
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Dolar Estadounidense"
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 8.75
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 595.4
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.85
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 105.8
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 7.7
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 3.58
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 24.66
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 21.98
        ElseIf cbxEntrada2.Text = "Dolar Estadounidense" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 6.92
        End If

        If cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Colon Salvadoreño"
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.11
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 68.05
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.097
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 12.09
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.88
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.41
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 2.82
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 2.51
        ElseIf cbxEntrada2.Text = "Colon Salvadoreño" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.79
        End If

        If cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Colon Costarricense"
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.0017
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.015
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.0014
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.18
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.013
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.006
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.041
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.037
        ElseIf cbxEntrada2.Text = "Colon Costarricense" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.012
        End If

        If cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Euro"
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 1.18
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 10.33
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 702.28
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 124.79
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 9.09
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 4.22
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 29.09
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 25.92
        ElseIf cbxEntrada2.Text = "Euro" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 8.16
        End If

        If cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Yen"
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.0095
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.083
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 5.63
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.008
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.073
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.034
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.23
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.21
        ElseIf cbxEntrada2.Text = "Yen" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.065
        End If

        If cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Quetzal Guatemalteco"
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.13
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 1.14
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 77.32
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.11
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 13.74
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.46
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 3.2
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 2.85
        ElseIf cbxEntrada2.Text = "Quetzal Guatemalteco" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.9
        End If

        If cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Sol Peruano"
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.28
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 2.45
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 166.41
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.24
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 29.57
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 2.15
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 6.89
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 6.14
        ElseIf cbxEntrada2.Text = "Sol Peruano" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 1.93
        End If

        If cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Lempira"
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.041
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.36
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 24.15
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.034
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 4.29
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.31
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.15
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.89
        ElseIf cbxEntrada2.Text = "Lempira" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.28
        End If

        If cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Peso Mexicano"
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.046
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.4
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 27.29
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 27.09
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 4.81
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.35
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.16
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 1.12
        ElseIf cbxEntrada2.Text = "Peso Mexicano" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.31
        End If

        If cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Yuan" Then
            lblRespuestaM.Text = Val(txtNum2.Text)
            lblNum2.Text = "Yuan"
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Dolar Estadounidense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.14
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Colon Salvadoreño" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 1.27
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Colon Costarricense" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 86.05
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Euro" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.12
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Yen" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 15.29
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Quetzal Guatemalteco" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 1.11
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Sol Peruano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 0.52
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Lempira" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 3.56
        ElseIf cbxEntrada2.Text = "Yuan" And cbxSalida2.Text = "Peso Mexicano" Then
            lblRespuestaM.Text = Val(txtNum2.Text) * 3.18
        End If

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub btnCalcular2_Click(sender As Object, e As EventArgs) Handles btnCalcular2.Click
        If cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 9.8
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1000
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10000
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 35274
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1000000
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1.102
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 100000000
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1000000000
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Tonelada" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 2205
            lblNum3.Text = "lb"
        End If
        If cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.102
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 101.97
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1019.72
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 3278.46
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 101971.6
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.1124
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10197160.05
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 101971600.5
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Kilonewton" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 224.81
            lblNum3.Text = "lb"
        End If
        If cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.91
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 8.9
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 907.18
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 9071.85
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 29166.67
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 907184.74
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 90718474
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 907184740
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Tonelada cortas" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 2000
            lblNum3.Text = "lb"
        End If

        If cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10 ^ -3
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.01
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 32.15
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1000
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0011
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 100000
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1000000
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Kilogramo" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 2.2
            lblNum3.Text = "lb"
        End If

        If cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10 ^ -4
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.000981
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.1
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 3.22
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 100
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.00011
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10000
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 100000
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Hectogramo" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.22
            lblNum3.Text = "lb"
        End If

        If cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0000286
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.000278
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.03
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.28
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 28.35
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0000313
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 2834.95
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 28349.52
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Onza" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.06
            lblNum3.Text = "lb"
        End If

        If cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.000001
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.00000981
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.001
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.01
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.03
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0000011
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 100
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1000
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Gramo" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0022
            lblNum3.Text = "lb"
        End If

        If cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0000001
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 9.81 * 10 ^ -8
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.00001
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0001
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.000322
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.01
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1.1 * 10 ^ -8
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Centigramo" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.000022
            lblNum3.Text = "lb"
        End If

        If cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 10 ^ -9
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 9.81 * 10 ^ -9
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.000001
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.00001
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0000322
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.001
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 1.1 * 10 ^ -9
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.1
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Miligramo" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0000022
            lblNum3.Text = "lb"
        End If

        If cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Tonelada" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.000454
            lblNum3.Text = "t"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Kilonewton" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.00445
            lblNum3.Text = "kN"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Kilogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.45
            lblNum3.Text = "kg"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Hectogramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 4.54
            lblNum3.Text = "hg"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Onza" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 14.58
            lblNum3.Text = "oz"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Gramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 453.59
            lblNum3.Text = "g"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Toneladas cortas" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 0.0005
            lblNum3.Text = "Tm"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Centigramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 45359.24
            lblNum3.Text = "cg"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Miligramo" Then
            lblRespuesta2.Text = Val(txtNum3.Text) * 453592.37
            lblNum3.Text = "mg"
        ElseIf cbxEntrada3.Text = "Libra" And cbxSalida3.Text = "Libra" Then
            lblRespuesta2.Text = Val(txtNum3.Text)
            lblNum3.Text = "lb"
        End If
    End Sub

    Private Sub btnCalcular3_Click(sender As Object, e As EventArgs) Handles btnCalcular3.Click
        If cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1000
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10000
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100000
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100000
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.86
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Hectolitro" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 22.7
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1000
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10000
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10000
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.09
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Decalitro" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 2.27
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1000
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10000
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Decimetro cubico" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.23
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1000
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10000
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Litro" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.23
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.001
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 100
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 8.65 * 10 ^ -4
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Decilitro" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.02
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -4
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -3
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 8.65 * 10 ^ -5
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Centilitro" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 2.27 * 10 ^ -3
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -5
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -4
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -3
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -3
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 8.65 * 10 ^ -6
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Centimetro cubico" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 2.27 * 10 ^ -4
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -5
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -4
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -3
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 10 ^ -3
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.01
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.1
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 8.65 * 10 ^ -6
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Mililitro" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 2.27 * 10 ^ -4
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1.64
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 16.36
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 163.65
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 163.65
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 1636.5
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 16365
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 163650
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 163650
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Barril" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 37.15
            lblNum4.Text = "gal"
        End If

        If cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Hectolitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.05
            lblNum4.Text = "hl"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Decalitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.45
            lblNum4.Text = "dal"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Decimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 4.55
            lblNum4.Text = "dm3"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Litro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 4.55
            lblNum4.Text = "l"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Decilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 45.46
            lblNum4.Text = "dl"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Centilitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 454.61
            lblNum4.Text = "cl"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Centimetro cubico" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 4546.1
            lblNum4.Text = "cc"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Mililitro" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 4546.1
            lblNum4.Text = "ml"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Barril" Then
            lblRespuesta3.Text = Val(txtNum4.Text) * 0.04
            lblNum4.Text = "bl"
        ElseIf cbxEntrada4.Text = "Galon" And cbxSalida4.Text = "Galon" Then
            lblRespuesta3.Text = Val(txtNum4.Text)
            lblNum4.Text = "gal"
        End If
    End Sub
End Class