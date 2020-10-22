<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroProducto = New System.Windows.Forms.Label()
        Me.btnSiguienteProducto = New System.Windows.Forms.Button()
        Me.btnUltimoProducto = New System.Windows.Forms.Button()
        Me.btnAnteriorProducto = New System.Windows.Forms.Button()
        Me.btnPrimerProducto = New System.Windows.Forms.Button()
        Me.grbDatosdeProductos = New System.Windows.Forms.GroupBox()
        Me.cboCategoriaProducto = New System.Windows.Forms.ComboBox()
        Me.lblCategoriaProducto = New System.Windows.Forms.Label()
        Me.txtMedidasProducto = New System.Windows.Forms.TextBox()
        Me.txtPedidosProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblMedidasProducto = New System.Windows.Forms.Label()
        Me.lblCodigoProducto = New System.Windows.Forms.Label()
        Me.lblPedidosProducto = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblDatosdeProducto = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatosdeProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProducto)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProducto)
        Me.grbEdicion.Controls.Add(Me.btnModificarProducto)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProducto)
        Me.grbEdicion.Location = New System.Drawing.Point(374, 440)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(280, 61)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.Location = New System.Drawing.Point(216, 25)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(58, 23)
        Me.btnBuscarProducto.TabIndex = 3
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.Location = New System.Drawing.Point(134, 25)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarProducto.TabIndex = 2
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.Location = New System.Drawing.Point(67, 25)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(60, 23)
        Me.btnModificarProducto.TabIndex = 1
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(7, 25)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(54, 23)
        Me.btnAgregarProducto.TabIndex = 0
        Me.btnAgregarProducto.Text = "Nuevo"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroProducto)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProducto)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProducto)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProducto)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerProducto)
        Me.grbNavegacion.Location = New System.Drawing.Point(40, 440)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(292, 61)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroProducto
        '
        Me.lblRegistroProducto.AutoSize = True
        Me.lblRegistroProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroProducto.Location = New System.Drawing.Point(121, 25)
        Me.lblRegistroProducto.Name = "lblRegistroProducto"
        Me.lblRegistroProducto.Size = New System.Drawing.Size(42, 13)
        Me.lblRegistroProducto.TabIndex = 4
        Me.lblRegistroProducto.Text = "x de n"
        '
        'btnSiguienteProducto
        '
        Me.btnSiguienteProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProducto.Location = New System.Drawing.Point(202, 20)
        Me.btnSiguienteProducto.Name = "btnSiguienteProducto"
        Me.btnSiguienteProducto.Size = New System.Drawing.Size(28, 23)
        Me.btnSiguienteProducto.TabIndex = 3
        Me.btnSiguienteProducto.Text = ">"
        Me.btnSiguienteProducto.UseVisualStyleBackColor = True
        '
        'btnUltimoProducto
        '
        Me.btnUltimoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProducto.Location = New System.Drawing.Point(236, 20)
        Me.btnUltimoProducto.Name = "btnUltimoProducto"
        Me.btnUltimoProducto.Size = New System.Drawing.Size(33, 23)
        Me.btnUltimoProducto.TabIndex = 2
        Me.btnUltimoProducto.Text = ">l"
        Me.btnUltimoProducto.UseVisualStyleBackColor = True
        '
        'btnAnteriorProducto
        '
        Me.btnAnteriorProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProducto.Location = New System.Drawing.Point(60, 20)
        Me.btnAnteriorProducto.Name = "btnAnteriorProducto"
        Me.btnAnteriorProducto.Size = New System.Drawing.Size(28, 23)
        Me.btnAnteriorProducto.TabIndex = 1
        Me.btnAnteriorProducto.Text = "<"
        Me.btnAnteriorProducto.UseVisualStyleBackColor = True
        '
        'btnPrimerProducto
        '
        Me.btnPrimerProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerProducto.Location = New System.Drawing.Point(21, 20)
        Me.btnPrimerProducto.Name = "btnPrimerProducto"
        Me.btnPrimerProducto.Size = New System.Drawing.Size(33, 23)
        Me.btnPrimerProducto.TabIndex = 0
        Me.btnPrimerProducto.Text = "l<"
        Me.btnPrimerProducto.UseVisualStyleBackColor = True
        '
        'grbDatosdeProductos
        '
        Me.grbDatosdeProductos.Controls.Add(Me.cboCategoriaProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.lblCategoriaProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.txtMedidasProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.txtPedidosProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.txtNombreProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.txtCodigoProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.lblMedidasProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.lblCodigoProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.lblPedidosProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.lblNombreProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.lblDatosdeProducto)
        Me.grbDatosdeProductos.Enabled = False
        Me.grbDatosdeProductos.Location = New System.Drawing.Point(40, 12)
        Me.grbDatosdeProductos.Name = "grbDatosdeProductos"
        Me.grbDatosdeProductos.Size = New System.Drawing.Size(584, 410)
        Me.grbDatosdeProductos.TabIndex = 3
        Me.grbDatosdeProductos.TabStop = False
        Me.grbDatosdeProductos.Text = "Datos de producto"
        '
        'cboCategoriaProducto
        '
        Me.cboCategoriaProducto.FormattingEnabled = True
        Me.cboCategoriaProducto.Location = New System.Drawing.Point(91, 78)
        Me.cboCategoriaProducto.Name = "cboCategoriaProducto"
        Me.cboCategoriaProducto.Size = New System.Drawing.Size(202, 21)
        Me.cboCategoriaProducto.TabIndex = 10
        '
        'lblCategoriaProducto
        '
        Me.lblCategoriaProducto.AutoSize = True
        Me.lblCategoriaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaProducto.Location = New System.Drawing.Point(20, 81)
        Me.lblCategoriaProducto.Name = "lblCategoriaProducto"
        Me.lblCategoriaProducto.Size = New System.Drawing.Size(65, 13)
        Me.lblCategoriaProducto.TabIndex = 9
        Me.lblCategoriaProducto.Text = "Categoria:"
        '
        'txtMedidasProducto
        '
        Me.txtMedidasProducto.Location = New System.Drawing.Point(89, 357)
        Me.txtMedidasProducto.Name = "txtMedidasProducto"
        Me.txtMedidasProducto.Size = New System.Drawing.Size(164, 20)
        Me.txtMedidasProducto.TabIndex = 8
        '
        'txtPedidosProducto
        '
        Me.txtPedidosProducto.Location = New System.Drawing.Point(88, 292)
        Me.txtPedidosProducto.Name = "txtPedidosProducto"
        Me.txtPedidosProducto.Size = New System.Drawing.Size(275, 20)
        Me.txtPedidosProducto.TabIndex = 7
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(88, 222)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(286, 20)
        Me.txtNombreProducto.TabIndex = 6
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(76, 156)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigoProducto.TabIndex = 5
        '
        'lblMedidasProducto
        '
        Me.lblMedidasProducto.AutoSize = True
        Me.lblMedidasProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedidasProducto.Location = New System.Drawing.Point(25, 360)
        Me.lblMedidasProducto.Name = "lblMedidasProducto"
        Me.lblMedidasProducto.Size = New System.Drawing.Size(58, 13)
        Me.lblMedidasProducto.TabIndex = 4
        Me.lblMedidasProducto.Text = "Medidas:"
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.AutoSize = True
        Me.lblCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProducto.Location = New System.Drawing.Point(20, 159)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblCodigoProducto.TabIndex = 3
        Me.lblCodigoProducto.Text = "Codigo:"
        '
        'lblPedidosProducto
        '
        Me.lblPedidosProducto.AutoSize = True
        Me.lblPedidosProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedidosProducto.Location = New System.Drawing.Point(25, 295)
        Me.lblPedidosProducto.Name = "lblPedidosProducto"
        Me.lblPedidosProducto.Size = New System.Drawing.Size(56, 13)
        Me.lblPedidosProducto.TabIndex = 2
        Me.lblPedidosProducto.Text = "Pedidos:"
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProducto.Location = New System.Drawing.Point(25, 225)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(54, 13)
        Me.lblNombreProducto.TabIndex = 1
        Me.lblNombreProducto.Text = "Nombre:"
        '
        'lblDatosdeProducto
        '
        Me.lblDatosdeProducto.AutoSize = True
        Me.lblDatosdeProducto.Location = New System.Drawing.Point(34, 28)
        Me.lblDatosdeProducto.Name = "lblDatosdeProducto"
        Me.lblDatosdeProducto.Size = New System.Drawing.Size(96, 13)
        Me.lblDatosdeProducto.TabIndex = 0
        Me.lblDatosdeProducto.Text = "Datos de Producto"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 521)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatosdeProductos)
        Me.Name = "frmProductos"
        Me.Text = "Registro de Productos"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatosdeProductos.ResumeLayout(False)
        Me.grbDatosdeProductos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroProducto As Label
    Friend WithEvents btnSiguienteProducto As Button
    Friend WithEvents btnUltimoProducto As Button
    Friend WithEvents btnAnteriorProducto As Button
    Friend WithEvents btnPrimerProducto As Button
    Friend WithEvents grbDatosdeProductos As GroupBox
    Friend WithEvents txtMedidasProducto As TextBox
    Friend WithEvents txtPedidosProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents lblMedidasProducto As Label
    Friend WithEvents lblCodigoProducto As Label
    Friend WithEvents lblPedidosProducto As Label
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblDatosdeProducto As Label
    Friend WithEvents lblCategoriaProducto As Label
    Friend WithEvents cboCategoriaProducto As ComboBox
End Class
