<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTipofactura = New System.Windows.Forms.Label()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.cboTipoFactura = New System.Windows.Forms.ComboBox()
        Me.cboFormapago = New System.Windows.Forms.ComboBox()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroCompra = New System.Windows.Forms.Label()
        Me.btnSiguienteCompra = New System.Windows.Forms.Button()
        Me.btnUltimaCompra = New System.Windows.Forms.Button()
        Me.btnAnteriorcompra = New System.Windows.Forms.Button()
        Me.btnPrimerCompra = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCompra = New System.Windows.Forms.Button()
        Me.btnEliminarCompra = New System.Windows.Forms.Button()
        Me.btnModificarCompra = New System.Windows.Forms.Button()
        Me.btnAgregarCompra = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(46, 19)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedor.TabIndex = 0
        Me.lblProveedor.Text = "Proveedor"
        '
        'cboProveedor
        '
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(109, 16)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(121, 21)
        Me.cboProveedor.TabIndex = 1
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(684, 19)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(66, 13)
        Me.lblFactura.TabIndex = 2
        Me.lblFactura.Text = "Factura No.:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(6, 77)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(79, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha Compra:"
        '
        'lblTipofactura
        '
        Me.lblTipofactura.AutoSize = True
        Me.lblTipofactura.Location = New System.Drawing.Point(310, 81)
        Me.lblTipofactura.Name = "lblTipofactura"
        Me.lblTipofactura.Size = New System.Drawing.Size(70, 13)
        Me.lblTipofactura.TabIndex = 4
        Me.lblTipofactura.Text = "Tipo Factura:"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Location = New System.Drawing.Point(528, 81)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(67, 13)
        Me.lblFormaPago.TabIndex = 5
        Me.lblFormaPago.Text = "Forma Pago:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(91, 74)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(756, 16)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 7
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.FormattingEnabled = True
        Me.cboTipoFactura.Location = New System.Drawing.Point(383, 77)
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoFactura.TabIndex = 8
        '
        'cboFormapago
        '
        Me.cboFormapago.FormattingEnabled = True
        Me.cboFormapago.Location = New System.Drawing.Point(598, 74)
        Me.cboFormapago.Name = "cboFormapago"
        Me.cboFormapago.Size = New System.Drawing.Size(121, 21)
        Me.cboFormapago.TabIndex = 9
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroCompra)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCompra)
        Me.grbNavegacion.Controls.Add(Me.btnUltimaCompra)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorcompra)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerCompra)
        Me.grbNavegacion.Location = New System.Drawing.Point(25, 544)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(292, 61)
        Me.grbNavegacion.TabIndex = 11
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroCompra
        '
        Me.lblRegistroCompra.AutoSize = True
        Me.lblRegistroCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroCompra.Location = New System.Drawing.Point(121, 25)
        Me.lblRegistroCompra.Name = "lblRegistroCompra"
        Me.lblRegistroCompra.Size = New System.Drawing.Size(42, 13)
        Me.lblRegistroCompra.TabIndex = 4
        Me.lblRegistroCompra.Text = "x de n"
        '
        'btnSiguienteCompra
        '
        Me.btnSiguienteCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCompra.Location = New System.Drawing.Point(202, 20)
        Me.btnSiguienteCompra.Name = "btnSiguienteCompra"
        Me.btnSiguienteCompra.Size = New System.Drawing.Size(28, 23)
        Me.btnSiguienteCompra.TabIndex = 3
        Me.btnSiguienteCompra.Text = ">"
        Me.btnSiguienteCompra.UseVisualStyleBackColor = True
        '
        'btnUltimaCompra
        '
        Me.btnUltimaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimaCompra.Location = New System.Drawing.Point(236, 20)
        Me.btnUltimaCompra.Name = "btnUltimaCompra"
        Me.btnUltimaCompra.Size = New System.Drawing.Size(33, 23)
        Me.btnUltimaCompra.TabIndex = 2
        Me.btnUltimaCompra.Text = ">l"
        Me.btnUltimaCompra.UseVisualStyleBackColor = True
        '
        'btnAnteriorcompra
        '
        Me.btnAnteriorcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorcompra.Location = New System.Drawing.Point(60, 20)
        Me.btnAnteriorcompra.Name = "btnAnteriorcompra"
        Me.btnAnteriorcompra.Size = New System.Drawing.Size(28, 23)
        Me.btnAnteriorcompra.TabIndex = 1
        Me.btnAnteriorcompra.Text = "<"
        Me.btnAnteriorcompra.UseVisualStyleBackColor = True
        '
        'btnPrimerCompra
        '
        Me.btnPrimerCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerCompra.Location = New System.Drawing.Point(21, 20)
        Me.btnPrimerCompra.Name = "btnPrimerCompra"
        Me.btnPrimerCompra.Size = New System.Drawing.Size(33, 23)
        Me.btnPrimerCompra.TabIndex = 0
        Me.btnPrimerCompra.Text = "l<"
        Me.btnPrimerCompra.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarCompra)
        Me.grbEdicion.Controls.Add(Me.btnEliminarCompra)
        Me.grbEdicion.Controls.Add(Me.btnModificarCompra)
        Me.grbEdicion.Controls.Add(Me.btnAgregarCompra)
        Me.grbEdicion.Location = New System.Drawing.Point(339, 544)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(280, 61)
        Me.grbEdicion.TabIndex = 14
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarCompra
        '
        Me.btnBuscarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCompra.Location = New System.Drawing.Point(216, 25)
        Me.btnBuscarCompra.Name = "btnBuscarCompra"
        Me.btnBuscarCompra.Size = New System.Drawing.Size(58, 23)
        Me.btnBuscarCompra.TabIndex = 3
        Me.btnBuscarCompra.Text = "Buscar"
        Me.btnBuscarCompra.UseVisualStyleBackColor = True
        '
        'btnEliminarCompra
        '
        Me.btnEliminarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCompra.Location = New System.Drawing.Point(134, 25)
        Me.btnEliminarCompra.Name = "btnEliminarCompra"
        Me.btnEliminarCompra.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarCompra.TabIndex = 2
        Me.btnEliminarCompra.Text = "Eliminar"
        Me.btnEliminarCompra.UseVisualStyleBackColor = True
        '
        'btnModificarCompra
        '
        Me.btnModificarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCompra.Location = New System.Drawing.Point(67, 25)
        Me.btnModificarCompra.Name = "btnModificarCompra"
        Me.btnModificarCompra.Size = New System.Drawing.Size(60, 23)
        Me.btnModificarCompra.TabIndex = 1
        Me.btnModificarCompra.Text = "Modificar"
        Me.btnModificarCompra.UseVisualStyleBackColor = True
        '
        'btnAgregarCompra
        '
        Me.btnAgregarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCompra.Location = New System.Drawing.Point(7, 25)
        Me.btnAgregarCompra.Name = "btnAgregarCompra"
        Me.btnAgregarCompra.Size = New System.Drawing.Size(54, 23)
        Me.btnAgregarCompra.TabIndex = 0
        Me.btnAgregarCompra.Text = "Nuevo"
        Me.btnAgregarCompra.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 492)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(149, 492)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "PRECIO"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 150
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 150
        '
        'nombre
        '
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 250
        '
        'codigo
        '
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 150
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.cantidad, Me.precio, Me.subtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(60, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(819, 342)
        Me.DataGridView1.TabIndex = 10
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 617)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cboFormapago)
        Me.Controls.Add(Me.cboTipoFactura)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFormaPago)
        Me.Controls.Add(Me.lblTipofactura)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.lblProveedor)
        Me.Name = "frmCompras"
        Me.Text = "Formulario de compras"
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProveedor As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents lblFactura As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblTipofactura As Label
    Friend WithEvents lblFormaPago As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents cboFormapago As ComboBox
    Friend WithEvents cboTipoFactura As ComboBox
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroCompra As Label
    Friend WithEvents btnSiguienteCompra As Button
    Friend WithEvents btnUltimaCompra As Button
    Friend WithEvents btnAnteriorcompra As Button
    Friend WithEvents btnPrimerCompra As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarCompra As Button
    Friend WithEvents btnEliminarCompra As Button
    Friend WithEvents btnModificarCompra As Button
    Friend WithEvents btnAgregarCompra As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
