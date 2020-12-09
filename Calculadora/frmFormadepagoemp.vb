Public Class frmFormadepagoemp
    Private Sub frmFormadepagoemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistemaDataSet.Arqueo' Puede moverla o quitarla según sea necesario.
        Me.ArqueoTableAdapter.Fill(Me.db_sistemaDataSet.Arqueo)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class