Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        lstEjercicios.Items.Clear()

        lstEjercicios.Items.Add("numeros pares del 1 al 20")
        For i = 2 To 20 Step 2
            lstEjercicios.Items.Add(i)
        Next

        lstEjercicios.Items.Add("numeros Impares del 1 al 20")
        For i = 1 To 20 Step 2
            lstEjercicios.Items.Add(i)
        Next
    End Sub

    Private Sub btnParImpar_Click(sender As Object, e As EventArgs) Handles btnParImpar.Click
        Dim num = txtNum.Text
        If num Mod 2 = 0 Then
            MessageBox.Show("El numero: " + num + ", es par")
        Else
            MessageBox.Show("El numero: " + num + ", es Impar")
        End If

    End Sub

    Private Sub btnPrimo_Click(sender As Object, e As EventArgs) Handles btnPrimo.Click
        Dim num = txtNum.Text
        Dim i = 0, acu = 1
        While 1 < 3 And acu <= num
            If num Mod acu = 0 then 
                 i += 1
            End If
            acu += 1
        End While
        If i <= 2 Then
            MessageBox.Show("Es primo")
        Else
            MessageBox.Show("No es primo")
        End If

    End Sub

    Private Sub btnCajero_Clik(sender As Object, e As EventArgs) Handles btnCajero.Click
        Dim denominaciones() = {100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01}, valor = txtNum.Text, Cantidad = 0
        Dim denomina As String

        lstEjercicios.Items.Clear()

        For Each denominacion In denominaciones
            While valor > 0 And denominacion <= valor
                valor = Math.Round(valor - denominacion, 2)
                Cantidad += 1
            End While
            If Cantidad > 0 Then
                If denominacion <= 1 Then
                    denomina = " Moneda de "
                Else
                    denomina = " billete de "
                End If
                lstEjercicios.Items.Add(Cantidad.ToString() + denomina + denominacion.ToString())
                Cantidad = 0
            End If
        Next
    End Sub
End Class