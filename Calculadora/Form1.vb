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

    Private Sub ListadoDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpleadosToolStripMenuItem.Click
        Dim objlistadodeempleados As New frmlistadoempleados
        objlistadodeempleados.MdiParent = Me
        objlistadodeempleados.Show()
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim objListadoProveedores As New frmListadoProveedor
        objListadoProveedores.MdiParent = Me
        objListadoProveedores.Show()
    End Sub

    Private Sub InformeArqueoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeArqueoToolStripMenuItem.Click
        Dim objInformeArqueo As New frminformearqueo
        objInformeArqueo.MdiParent = Me
        objInformeArqueo.Show()
    End Sub

    Private Sub InformeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeProductosToolStripMenuItem.Click
        Dim objinformeProductos As New frminformeProductos
        objinformeProductos.MdiParent = Me
        objinformeProductos.Show()
    End Sub
End Class