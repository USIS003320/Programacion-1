<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGanancias
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
        Me.btnBuscarGanancias = New System.Windows.Forms.Button()
        Me.btnEliminarGanancias = New System.Windows.Forms.Button()
        Me.btnModificarGanancias = New System.Windows.Forms.Button()
        Me.btnAgregarGanancias = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroGanancias = New System.Windows.Forms.Label()
        Me.btnSiguienteGanancias = New System.Windows.Forms.Button()
        Me.btnUltimoGanancias = New System.Windows.Forms.Button()
        Me.btnAnteriorGanancias = New System.Windows.Forms.Button()
        Me.btnPrimerGanancias = New System.Windows.Forms.Button()
        Me.grbDatosdeGanancias = New System.Windows.Forms.GroupBox()
        Me.cboCategoriaGanancias = New System.Windows.Forms.ComboBox()
        Me.lblCategoriaGanancias = New System.Windows.Forms.Label()
        Me.txtPrecioCompras = New System.Windows.Forms.TextBox()
        Me.txtPrecioVentas = New System.Windows.Forms.TextBox()
        Me.lblPreciodeProducto = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblDatosdeProducto = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatosdeGanancias.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarGanancias)
        Me.grbEdicion.Controls.Add(Me.btnEliminarGanancias)
        Me.grbEdicion.Controls.Add(Me.btnModificarGanancias)
        Me.grbEdicion.Controls.Add(Me.btnAgregarGanancias)
        Me.grbEdicion.Location = New System.Drawing.Point(514, 459)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 94)
        Me.grbEdicion.TabIndex = 8
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarGanancias
        '
        Me.btnBuscarGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarGanancias.Location = New System.Drawing.Point(324, 38)
        Me.btnBuscarGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscarGanancias.Name = "btnBuscarGanancias"
        Me.btnBuscarGanancias.Size = New System.Drawing.Size(87, 35)
        Me.btnBuscarGanancias.TabIndex = 3
        Me.btnBuscarGanancias.Text = "Buscar"
        Me.btnBuscarGanancias.UseVisualStyleBackColor = True
        '
        'btnEliminarGanancias
        '
        Me.btnEliminarGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarGanancias.Location = New System.Drawing.Point(201, 38)
        Me.btnEliminarGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarGanancias.Name = "btnEliminarGanancias"
        Me.btnEliminarGanancias.Size = New System.Drawing.Size(112, 35)
        Me.btnEliminarGanancias.TabIndex = 2
        Me.btnEliminarGanancias.Text = "Eliminar"
        Me.btnEliminarGanancias.UseVisualStyleBackColor = True
        '
        'btnModificarGanancias
        '
        Me.btnModificarGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarGanancias.Location = New System.Drawing.Point(100, 38)
        Me.btnModificarGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificarGanancias.Name = "btnModificarGanancias"
        Me.btnModificarGanancias.Size = New System.Drawing.Size(90, 35)
        Me.btnModificarGanancias.TabIndex = 1
        Me.btnModificarGanancias.Text = "Modificar"
        Me.btnModificarGanancias.UseVisualStyleBackColor = True
        '
        'btnAgregarGanancias
        '
        Me.btnAgregarGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarGanancias.Location = New System.Drawing.Point(10, 38)
        Me.btnAgregarGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarGanancias.Name = "btnAgregarGanancias"
        Me.btnAgregarGanancias.Size = New System.Drawing.Size(81, 35)
        Me.btnAgregarGanancias.TabIndex = 0
        Me.btnAgregarGanancias.Text = "Nuevo"
        Me.btnAgregarGanancias.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroGanancias)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteGanancias)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoGanancias)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorGanancias)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerGanancias)
        Me.grbNavegacion.Location = New System.Drawing.Point(13, 459)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Size = New System.Drawing.Size(438, 94)
        Me.grbNavegacion.TabIndex = 7
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroGanancias
        '
        Me.lblRegistroGanancias.AutoSize = True
        Me.lblRegistroGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroGanancias.Location = New System.Drawing.Point(182, 38)
        Me.lblRegistroGanancias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistroGanancias.Name = "lblRegistroGanancias"
        Me.lblRegistroGanancias.Size = New System.Drawing.Size(60, 20)
        Me.lblRegistroGanancias.TabIndex = 4
        Me.lblRegistroGanancias.Text = "x de n"
        '
        'btnSiguienteGanancias
        '
        Me.btnSiguienteGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteGanancias.Location = New System.Drawing.Point(303, 31)
        Me.btnSiguienteGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSiguienteGanancias.Name = "btnSiguienteGanancias"
        Me.btnSiguienteGanancias.Size = New System.Drawing.Size(42, 35)
        Me.btnSiguienteGanancias.TabIndex = 3
        Me.btnSiguienteGanancias.Text = ">"
        Me.btnSiguienteGanancias.UseVisualStyleBackColor = True
        '
        'btnUltimoGanancias
        '
        Me.btnUltimoGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoGanancias.Location = New System.Drawing.Point(354, 31)
        Me.btnUltimoGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUltimoGanancias.Name = "btnUltimoGanancias"
        Me.btnUltimoGanancias.Size = New System.Drawing.Size(50, 35)
        Me.btnUltimoGanancias.TabIndex = 2
        Me.btnUltimoGanancias.Text = ">l"
        Me.btnUltimoGanancias.UseVisualStyleBackColor = True
        '
        'btnAnteriorGanancias
        '
        Me.btnAnteriorGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorGanancias.Location = New System.Drawing.Point(90, 31)
        Me.btnAnteriorGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnteriorGanancias.Name = "btnAnteriorGanancias"
        Me.btnAnteriorGanancias.Size = New System.Drawing.Size(42, 35)
        Me.btnAnteriorGanancias.TabIndex = 1
        Me.btnAnteriorGanancias.Text = "<"
        Me.btnAnteriorGanancias.UseVisualStyleBackColor = True
        '
        'btnPrimerGanancias
        '
        Me.btnPrimerGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerGanancias.Location = New System.Drawing.Point(32, 31)
        Me.btnPrimerGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrimerGanancias.Name = "btnPrimerGanancias"
        Me.btnPrimerGanancias.Size = New System.Drawing.Size(50, 35)
        Me.btnPrimerGanancias.TabIndex = 0
        Me.btnPrimerGanancias.Text = "l<"
        Me.btnPrimerGanancias.UseVisualStyleBackColor = True
        '
        'grbDatosdeGanancias
        '
        Me.grbDatosdeGanancias.Controls.Add(Me.cboCategoriaGanancias)
        Me.grbDatosdeGanancias.Controls.Add(Me.lblCategoriaGanancias)
        Me.grbDatosdeGanancias.Controls.Add(Me.txtPrecioCompras)
        Me.grbDatosdeGanancias.Controls.Add(Me.txtPrecioVentas)
        Me.grbDatosdeGanancias.Controls.Add(Me.lblPreciodeProducto)
        Me.grbDatosdeGanancias.Controls.Add(Me.lblNombreProducto)
        Me.grbDatosdeGanancias.Controls.Add(Me.lblDatosdeProducto)
        Me.grbDatosdeGanancias.Enabled = False
        Me.grbDatosdeGanancias.Location = New System.Drawing.Point(13, 14)
        Me.grbDatosdeGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatosdeGanancias.Name = "grbDatosdeGanancias"
        Me.grbDatosdeGanancias.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatosdeGanancias.Size = New System.Drawing.Size(876, 422)
        Me.grbDatosdeGanancias.TabIndex = 6
        Me.grbDatosdeGanancias.TabStop = False
        Me.grbDatosdeGanancias.Text = "Datos de Ganancias"
        '
        'cboCategoriaGanancias
        '
        Me.cboCategoriaGanancias.FormattingEnabled = True
        Me.cboCategoriaGanancias.Location = New System.Drawing.Point(186, 122)
        Me.cboCategoriaGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCategoriaGanancias.Name = "cboCategoriaGanancias"
        Me.cboCategoriaGanancias.Size = New System.Drawing.Size(301, 28)
        Me.cboCategoriaGanancias.TabIndex = 10
        '
        'lblCategoriaGanancias
        '
        Me.lblCategoriaGanancias.AutoSize = True
        Me.lblCategoriaGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaGanancias.Location = New System.Drawing.Point(30, 125)
        Me.lblCategoriaGanancias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoriaGanancias.Name = "lblCategoriaGanancias"
        Me.lblCategoriaGanancias.Size = New System.Drawing.Size(90, 20)
        Me.lblCategoriaGanancias.TabIndex = 9
        Me.lblCategoriaGanancias.Text = "Producto:"
        '
        'txtPrecioCompras
        '
        Me.txtPrecioCompras.Location = New System.Drawing.Point(195, 343)
        Me.txtPrecioCompras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecioCompras.Name = "txtPrecioCompras"
        Me.txtPrecioCompras.Size = New System.Drawing.Size(427, 26)
        Me.txtPrecioCompras.TabIndex = 6
        '
        'txtPrecioVentas
        '
        Me.txtPrecioVentas.Location = New System.Drawing.Point(195, 242)
        Me.txtPrecioVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecioVentas.Name = "txtPrecioVentas"
        Me.txtPrecioVentas.Size = New System.Drawing.Size(186, 26)
        Me.txtPrecioVentas.TabIndex = 5
        '
        'lblPreciodeProducto
        '
        Me.lblPreciodeProducto.AutoSize = True
        Me.lblPreciodeProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreciodeProducto.Location = New System.Drawing.Point(30, 245)
        Me.lblPreciodeProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreciodeProducto.Name = "lblPreciodeProducto"
        Me.lblPreciodeProducto.Size = New System.Drawing.Size(149, 20)
        Me.lblPreciodeProducto.TabIndex = 3
        Me.lblPreciodeProducto.Text = "Precio de Venta:"
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProducto.Location = New System.Drawing.Point(38, 346)
        Me.lblNombreProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(149, 20)
        Me.lblNombreProducto.TabIndex = 1
        Me.lblNombreProducto.Text = "Precio de Venta:"
        '
        'lblDatosdeProducto
        '
        Me.lblDatosdeProducto.AutoSize = True
        Me.lblDatosdeProducto.Location = New System.Drawing.Point(51, 43)
        Me.lblDatosdeProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatosdeProducto.Name = "lblDatosdeProducto"
        Me.lblDatosdeProducto.Size = New System.Drawing.Size(155, 20)
        Me.lblDatosdeProducto.TabIndex = 0
        Me.lblDatosdeProducto.Text = "Datos de Ganancias"
        '
        'frmGanancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 586)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatosdeGanancias)
        Me.Name = "frmGanancias"
        Me.Text = "frmGanancias"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatosdeGanancias.ResumeLayout(False)
        Me.grbDatosdeGanancias.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarGanancias As Button
    Friend WithEvents btnEliminarGanancias As Button
    Friend WithEvents btnModificarGanancias As Button
    Friend WithEvents btnAgregarGanancias As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroGanancias As Label
    Friend WithEvents btnSiguienteGanancias As Button
    Friend WithEvents btnUltimoGanancias As Button
    Friend WithEvents btnAnteriorGanancias As Button
    Friend WithEvents btnPrimerGanancias As Button
    Friend WithEvents grbDatosdeGanancias As GroupBox
    Friend WithEvents cboCategoriaGanancias As ComboBox
    Friend WithEvents lblCategoriaGanancias As Label
    Friend WithEvents txtPrecioCompras As TextBox
    Friend WithEvents txtPrecioVentas As TextBox
    Friend WithEvents lblPreciodeProducto As Label
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblDatosdeProducto As Label
End Class
