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

    Private Sub ArqueoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArqueoToolStripMenuItem.Click
        Dim objProveedores As New frmArqueo
        objProveedores.MdiParent = Me
        objProveedores.Show()
    End Sub

    Private Sub GananciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GananciasToolStripMenuItem.Click
        Dim objProveedores As New frmGanancias
        objProveedores.MdiParent = Me
        objProveedores.Show()
    End Sub

    Private Sub FacturacionCompraToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FacturacionCompraToolStripMenuItem.Click
        Dim objCompras As New frmCompras
        objCompras.MdiParent = Me
        objCompras.Show()
    End Sub
End Class