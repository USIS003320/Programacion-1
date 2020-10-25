<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.txtDireccionEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroEmpleado = New System.Windows.Forms.Label()
        Me.btnSiguienteEmpleado = New System.Windows.Forms.Button()
        Me.btnUltimoEmpleado = New System.Windows.Forms.Button()
        Me.btnAnteriorEmpleado = New System.Windows.Forms.Button()
        Me.btnPrimeroEmpleado = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtTelefonoEmpleado)
        Me.grbDatos.Controls.Add(Me.txtDireccionEmpleado)
        Me.grbDatos.Controls.Add(Me.txtNombreEmpleado)
        Me.grbDatos.Controls.Add(Me.txtCodigoEmpleado)
        Me.grbDatos.Controls.Add(Me.lblTelefono)
        Me.grbDatos.Controls.Add(Me.lblCodigo)
        Me.grbDatos.Controls.Add(Me.lblDireccion)
        Me.grbDatos.Controls.Add(Me.lblNombre)
        Me.grbDatos.Controls.Add(Me.lblDatos)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(36, 18)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatos.Size = New System.Drawing.Size(876, 631)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de empleados"
        '
        'txtTelefonoEmpleado
        '
        Me.txtTelefonoEmpleado.Location = New System.Drawing.Point(158, 543)
        Me.txtTelefonoEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado"
        Me.txtTelefonoEmpleado.Size = New System.Drawing.Size(244, 26)
        Me.txtTelefonoEmpleado.TabIndex = 8
        '
        'txtDireccionEmpleado
        '
        Me.txtDireccionEmpleado.Location = New System.Drawing.Point(152, 320)
        Me.txtDireccionEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccionEmpleado.Multiline = True
        Me.txtDireccionEmpleado.Name = "txtDireccionEmpleado"
        Me.txtDireccionEmpleado.Size = New System.Drawing.Size(410, 139)
        Me.txtDireccionEmpleado.TabIndex = 7
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(135, 225)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(427, 26)
        Me.txtNombreEmpleado.TabIndex = 6
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.Location = New System.Drawing.Point(135, 106)
        Me.txtCodigoEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.Size = New System.Drawing.Size(186, 26)
        Me.txtCodigoEmpleado.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(57, 548)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(87, 20)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(51, 111)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(73, 20)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Codigo:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(45, 325)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(96, 20)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(45, 229)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(80, 20)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(51, 42)
        Me.lblDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(150, 20)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos de Empleado"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroEmpleado)
        Me.grbNavegacion.Location = New System.Drawing.Point(36, 677)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Size = New System.Drawing.Size(438, 94)
        Me.grbNavegacion.TabIndex = 1
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroEmpleado
        '
        Me.lblRegistroEmpleado.AutoSize = True
        Me.lblRegistroEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroEmpleado.Location = New System.Drawing.Point(182, 38)
        Me.lblRegistroEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistroEmpleado.Name = "lblRegistroEmpleado"
        Me.lblRegistroEmpleado.Size = New System.Drawing.Size(60, 20)
        Me.lblRegistroEmpleado.TabIndex = 4
        Me.lblRegistroEmpleado.Text = "x de n"
        '
        'btnSiguienteEmpleado
        '
        Me.btnSiguienteEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteEmpleado.Location = New System.Drawing.Point(303, 31)
        Me.btnSiguienteEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSiguienteEmpleado.Name = "btnSiguienteEmpleado"
        Me.btnSiguienteEmpleado.Size = New System.Drawing.Size(42, 35)
        Me.btnSiguienteEmpleado.TabIndex = 3
        Me.btnSiguienteEmpleado.Text = ">"
        Me.btnSiguienteEmpleado.UseVisualStyleBackColor = True
        '
        'btnUltimoEmpleado
        '
        Me.btnUltimoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoEmpleado.Location = New System.Drawing.Point(354, 31)
        Me.btnUltimoEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUltimoEmpleado.Name = "btnUltimoEmpleado"
        Me.btnUltimoEmpleado.Size = New System.Drawing.Size(50, 35)
        Me.btnUltimoEmpleado.TabIndex = 2
        Me.btnUltimoEmpleado.Text = ">l"
        Me.btnUltimoEmpleado.UseVisualStyleBackColor = True
        '
        'btnAnteriorEmpleado
        '
        Me.btnAnteriorEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorEmpleado.Location = New System.Drawing.Point(90, 31)
        Me.btnAnteriorEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnteriorEmpleado.Name = "btnAnteriorEmpleado"
        Me.btnAnteriorEmpleado.Size = New System.Drawing.Size(42, 35)
        Me.btnAnteriorEmpleado.TabIndex = 1
        Me.btnAnteriorEmpleado.Text = "<"
        Me.btnAnteriorEmpleado.UseVisualStyleBackColor = True
        '
        'btnPrimeroEmpleado
        '
        Me.btnPrimeroEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroEmpleado.Location = New System.Drawing.Point(32, 31)
        Me.btnPrimeroEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrimeroEmpleado.Name = "btnPrimeroEmpleado"
        Me.btnPrimeroEmpleado.Size = New System.Drawing.Size(50, 35)
        Me.btnPrimeroEmpleado.TabIndex = 0
        Me.btnPrimeroEmpleado.Text = "l<"
        Me.btnPrimeroEmpleado.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnEliminarEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnModificarEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnAgregarEmpleado)
        Me.grbEdicion.Location = New System.Drawing.Point(537, 677)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 94)
        Me.grbEdicion.TabIndex = 2
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(324, 38)
        Me.btnBuscarEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(87, 35)
        Me.btnBuscarEmpleado.TabIndex = 3
        Me.btnBuscarEmpleado.Text = "Buscar"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(201, 38)
        Me.btnEliminarEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(112, 35)
        Me.btnEliminarEmpleado.TabIndex = 2
        Me.btnEliminarEmpleado.Text = "Eliminar"
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(100, 38)
        Me.btnModificarEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(90, 35)
        Me.btnModificarEmpleado.TabIndex = 1
        Me.btnModificarEmpleado.Text = "Modificar"
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(10, 38)
        Me.btnAgregarEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(81, 35)
        Me.btnAgregarEmpleado.TabIndex = 0
        Me.btnAgregarEmpleado.Text = "Nuevo"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 817)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEmpleados"
        Me.Text = "Registro de empleados"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtCodigoEmpleado As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDatos As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents txtTelefonoEmpleado As TextBox
    Friend WithEvents txtDireccionEmpleado As TextBox
    Friend WithEvents lblRegistroEmpleado As Label
    Friend WithEvents btnSiguienteEmpleado As Button
    Friend WithEvents btnUltimoEmpleado As Button
    Friend WithEvents btnAnteriorEmpleado As Button
    Friend WithEvents btnPrimeroEmpleado As Button
    Friend WithEvents btnBuscarEmpleado As Button
    Friend WithEvents btnEliminarEmpleado As Button
    Friend WithEvents btnModificarEmpleado As Button
    Friend WithEvents btnAgregarEmpleado As Button
End Class
