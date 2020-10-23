Public Class frmMenu
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim objEmpleados As New frmEmpleados
        objEmpleados.MdiParent = Me
        objEmpleados.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim objProductos As New frmProductos
        objProductos.MdiParent = Me
        objProductos.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim objProveedores As New frmProveedor
        objProveedores.MdiParent = Me
        objProveedores.Show()
    End Sub
End Class