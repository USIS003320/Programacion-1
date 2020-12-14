<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrecios
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
        Me.cboPrecio = New System.Windows.Forms.ComboBox()
        Me.txtPrecios = New System.Windows.Forms.TextBox()
        Me.lblMedidasProducto = New System.Windows.Forms.Label()
        Me.lblNombrePrecio = New System.Windows.Forms.Label()
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
        Me.grbEdicion.Location = New System.Drawing.Point(527, 297)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 94)
        Me.grbEdicion.TabIndex = 8
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.Location = New System.Drawing.Point(324, 38)
        Me.btnBuscarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(87, 35)
        Me.btnBuscarProducto.TabIndex = 3
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.Location = New System.Drawing.Point(201, 38)
        Me.btnEliminarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(112, 35)
        Me.btnEliminarProducto.TabIndex = 2
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.Location = New System.Drawing.Point(100, 38)
        Me.btnModificarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(90, 35)
        Me.btnModificarProducto.TabIndex = 1
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(10, 38)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(81, 35)
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
        Me.grbNavegacion.Location = New System.Drawing.Point(26, 297)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Size = New System.Drawing.Size(438, 94)
        Me.grbNavegacion.TabIndex = 7
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroProducto
        '
        Me.lblRegistroProducto.AutoSize = True
        Me.lblRegistroProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroProducto.Location = New System.Drawing.Point(182, 38)
        Me.lblRegistroProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistroProducto.Name = "lblRegistroProducto"
        Me.lblRegistroProducto.Size = New System.Drawing.Size(60, 20)
        Me.lblRegistroProducto.TabIndex = 4
        Me.lblRegistroProducto.Text = "x de n"
        '
        'btnSiguienteProducto
        '
        Me.btnSiguienteProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProducto.Location = New System.Drawing.Point(303, 31)
        Me.btnSiguienteProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSiguienteProducto.Name = "btnSiguienteProducto"
        Me.btnSiguienteProducto.Size = New System.Drawing.Size(42, 35)
        Me.btnSiguienteProducto.TabIndex = 3
        Me.btnSiguienteProducto.Text = ">"
        Me.btnSiguienteProducto.UseVisualStyleBackColor = True
        '
        'btnUltimoProducto
        '
        Me.btnUltimoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProducto.Location = New System.Drawing.Point(354, 31)
        Me.btnUltimoProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUltimoProducto.Name = "btnUltimoProducto"
        Me.btnUltimoProducto.Size = New System.Drawing.Size(50, 35)
        Me.btnUltimoProducto.TabIndex = 2
        Me.btnUltimoProducto.Text = ">l"
        Me.btnUltimoProducto.UseVisualStyleBackColor = True
        '
        'btnAnteriorProducto
        '
        Me.btnAnteriorProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProducto.Location = New System.Drawing.Point(90, 31)
        Me.btnAnteriorProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnteriorProducto.Name = "btnAnteriorProducto"
        Me.btnAnteriorProducto.Size = New System.Drawing.Size(42, 35)
        Me.btnAnteriorProducto.TabIndex = 1
        Me.btnAnteriorProducto.Text = "<"
        Me.btnAnteriorProducto.UseVisualStyleBackColor = True
        '
        'btnPrimerProducto
        '
        Me.btnPrimerProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerProducto.Location = New System.Drawing.Point(32, 31)
        Me.btnPrimerProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrimerProducto.Name = "btnPrimerProducto"
        Me.btnPrimerProducto.Size = New System.Drawing.Size(50, 35)
        Me.btnPrimerProducto.TabIndex = 0
        Me.btnPrimerProducto.Text = "l<"
        Me.btnPrimerProducto.UseVisualStyleBackColor = True
        '
        'grbDatosdeProductos
        '
        Me.grbDatosdeProductos.Controls.Add(Me.cboPrecio)
        Me.grbDatosdeProductos.Controls.Add(Me.txtPrecios)
        Me.grbDatosdeProductos.Controls.Add(Me.lblMedidasProducto)
        Me.grbDatosdeProductos.Controls.Add(Me.lblNombrePrecio)
        Me.grbDatosdeProductos.Controls.Add(Me.lblDatosdeProducto)
        Me.grbDatosdeProductos.Enabled = False
        Me.grbDatosdeProductos.Location = New System.Drawing.Point(24, 14)
        Me.grbDatosdeProductos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatosdeProductos.Name = "grbDatosdeProductos"
        Me.grbDatosdeProductos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatosdeProductos.Size = New System.Drawing.Size(876, 253)
        Me.grbDatosdeProductos.TabIndex = 6
        Me.grbDatosdeProductos.TabStop = False
        Me.grbDatosdeProductos.Text = "Datos de producto"
        '
        'cboPrecio
        '
        Me.cboPrecio.FormattingEnabled = True
        Me.cboPrecio.Location = New System.Drawing.Point(125, 193)
        Me.cboPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboPrecio.Name = "cboPrecio"
        Me.cboPrecio.Size = New System.Drawing.Size(301, 28)
        Me.cboPrecio.TabIndex = 11
        '
        'txtPrecios
        '
        Me.txtPrecios.Location = New System.Drawing.Point(126, 100)
        Me.txtPrecios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecios.Name = "txtPrecios"
        Me.txtPrecios.Size = New System.Drawing.Size(244, 26)
        Me.txtPrecios.TabIndex = 8
        '
        'lblMedidasProducto
        '
        Me.lblMedidasProducto.AutoSize = True
        Me.lblMedidasProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedidasProducto.Location = New System.Drawing.Point(38, 196)
        Me.lblMedidasProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedidasProducto.Name = "lblMedidasProducto"
        Me.lblMedidasProducto.Size = New System.Drawing.Size(79, 20)
        Me.lblMedidasProducto.TabIndex = 4
        Me.lblMedidasProducto.Text = "Precios:"
        '
        'lblNombrePrecio
        '
        Me.lblNombrePrecio.AutoSize = True
        Me.lblNombrePrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePrecio.Location = New System.Drawing.Point(38, 103)
        Me.lblNombrePrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombrePrecio.Name = "lblNombrePrecio"
        Me.lblNombrePrecio.Size = New System.Drawing.Size(80, 20)
        Me.lblNombrePrecio.TabIndex = 1
        Me.lblNombrePrecio.Text = "Nombre:"
        '
        'lblDatosdeProducto
        '
        Me.lblDatosdeProducto.AutoSize = True
        Me.lblDatosdeProducto.Location = New System.Drawing.Point(51, 43)
        Me.lblDatosdeProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatosdeProducto.Name = "lblDatosdeProducto"
        Me.lblDatosdeProducto.Size = New System.Drawing.Size(142, 20)
        Me.lblDatosdeProducto.TabIndex = 0
        Me.lblDatosdeProducto.Text = "Datos de Producto"
        '
        'frmPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 415)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatosdeProductos)
        Me.Name = "frmPrecios"
        Me.Text = "frmPrecios"
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
    Friend WithEvents txtPrecios As TextBox
    Friend WithEvents lblMedidasProducto As Label
    Friend WithEvents lblNombrePrecio As Label
    Friend WithEvents lblDatosdeProducto As Label
    Friend WithEvents cboPrecio As ComboBox
End Class
