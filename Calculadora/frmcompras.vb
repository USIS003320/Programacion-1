Public Class frmcompras
    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_sistemaDataSet)

    End Sub

    Private Sub frmcompras_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.Db_sistemaDataSet.compras)

    End Sub

    Private Sub ComprasBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComprasBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ComprasBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Db_sistemaDataSet1)

    End Sub

    Private Sub frmcompras_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet1.dcomprasproductos' Puede moverla o quitarla según sea necesario.
        Me.DcomprasproductosTableAdapter.FillDcomprasProducto(Me.Db_sistemaDataSet1.dcomprasproductos)
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet1.compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter1.Fill(Me.Db_sistemaDataSet1.compras)

    End Sub

    Private Function DcomprasproductosTableAdapter() As Object
        Throw New NotImplementedException()
    End Function
End Class