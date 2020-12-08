Public Class frmListadoProveedor
    Private Sub frmListadoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistemaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.db_sistemaDataSet.Proveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class