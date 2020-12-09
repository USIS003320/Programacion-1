<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArqueoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GananciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeArqueoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDePreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Calculadora.My.Resources.Resources.Lacteos
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1374, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Archi
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Salir
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(147, 34)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ArqueoToolStripMenuItem, Me.GananciasToolStripMenuItem})
        Me.EmpresaToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.iconfinder_Home_56264
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(129, 29)
        Me.EmpresaToolStripMenuItem.Text = "EMPRESA"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Empleado
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Proveedor
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ArqueoToolStripMenuItem
        '
        Me.ArqueoToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Arqueo
        Me.ArqueoToolStripMenuItem.Name = "ArqueoToolStripMenuItem"
        Me.ArqueoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ArqueoToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.ArqueoToolStripMenuItem.Text = "Arqueo"
        '
        'GananciasToolStripMenuItem
        '
        Me.GananciasToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Dinero
        Me.GananciasToolStripMenuItem.Name = "GananciasToolStripMenuItem"
        Me.GananciasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GananciasToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.GananciasToolStripMenuItem.Text = "Ganancias"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem, Me.FacturacionCompraToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.iconfinder_ilustracoes_04_10_1519778
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(153, 29)
        Me.InventarioToolStripMenuItem.Text = "INVENTARIO"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Productos
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(272, 34)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'FacturacionCompraToolStripMenuItem
        '
        Me.FacturacionCompraToolStripMenuItem.Name = "FacturacionCompraToolStripMenuItem"
        Me.FacturacionCompraToolStripMenuItem.Size = New System.Drawing.Size(272, 34)
        Me.FacturacionCompraToolStripMenuItem.Text = "Facturacion Compra"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeEmpleadosToolStripMenuItem, Me.InformeArqueoToolStripMenuItem, Me.InformeProductosToolStripMenuItem, Me.ListadoDePreciosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Report
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(134, 29)
        Me.ReportesToolStripMenuItem.Text = "REPORTES"
        '
        'ListadoDeEmpleadosToolStripMenuItem
        '
        Me.ListadoDeEmpleadosToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Employee
        Me.ListadoDeEmpleadosToolStripMenuItem.Name = "ListadoDeEmpleadosToolStripMenuItem"
        Me.ListadoDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.ListadoDeEmpleadosToolStripMenuItem.Text = "Listado de Empleados"
        '
        'InformeArqueoToolStripMenuItem
        '
        Me.InformeArqueoToolStripMenuItem.Name = "InformeArqueoToolStripMenuItem"
        Me.InformeArqueoToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.InformeArqueoToolStripMenuItem.Text = "Informe arqueo"
        '
        'InformeProductosToolStripMenuItem
        '
        Me.InformeProductosToolStripMenuItem.Name = "InformeProductosToolStripMenuItem"
        Me.InformeProductosToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.InformeProductosToolStripMenuItem.Text = "Informe Productos"
        '
        'ListadoDePreciosToolStripMenuItem
        '
        Me.ListadoDePreciosToolStripMenuItem.Name = "ListadoDePreciosToolStripMenuItem"
        Me.ListadoDePreciosToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.ListadoDePreciosToolStripMenuItem.Text = "Listado de Precios"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.lacteos_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1374, 788)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMenu"
        Me.Text = "Sistema Lacteos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArqueoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GananciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeArqueoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDePreciosToolStripMenuItem As ToolStripMenuItem
End Class
