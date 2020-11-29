Public Class Formprueba
    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComprasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_sistemaDataSet)

    End Sub

    Private Sub Formprueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.FillVentas(Me.Db_sistemaDataSet.compras)

    End Sub

    Private Sub Fecha_compraDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Fecha_compraDateTimePicker.ValueChanged

    End Sub

    Private Sub IdTipofacturaLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class