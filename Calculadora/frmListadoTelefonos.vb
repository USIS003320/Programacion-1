Public Class frmListadoTelefonos
    Private Sub frmListadoTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistemaDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.empleadosTableAdapter.Fill(Me.db_sistemaDataSet.empleados)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class