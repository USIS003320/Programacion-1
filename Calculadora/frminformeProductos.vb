Public Class frminformeProductos
    Private Sub frminformeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistemaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.db_sistemaDataSet.Productos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class