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
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroEmpleado = New System.Windows.Forms.Label()
        Me.btnSiguienteEmpleado = New System.Windows.Forms.Button()
        Me.btnUltimoEmpleado = New System.Windows.Forms.Button()
        Me.btnAnteriorEmpleado = New System.Windows.Forms.Button()
        Me.btnPrimeroEmpleado = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
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
        Me.grbDatos.Location = New System.Drawing.Point(24, 12)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(584, 410)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de empleados"
        '
        'txtTelefonoEmpleado
        '
        Me.txtTelefonoEmpleado.Location = New System.Drawing.Point(105, 353)
        Me.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado"
        Me.txtTelefonoEmpleado.Size = New System.Drawing.Size(164, 20)
        Me.txtTelefonoEmpleado.TabIndex = 8
        '
        'txtDireccionEmpleado
        '
        Me.txtDireccionEmpleado.Location = New System.Drawing.Point(105, 224)
        Me.txtDireccionEmpleado.Multiline = True
        Me.txtDireccionEmpleado.Name = "txtDireccionEmpleado"
        Me.txtDireccionEmpleado.Size = New System.Drawing.Size(275, 92)
        Me.txtDireccionEmpleado.TabIndex = 7
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(94, 147)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(286, 20)
        Me.txtNombreEmpleado.TabIndex = 6
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.Location = New System.Drawing.Point(90, 80)
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigoEmpleado.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(38, 356)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 13)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(34, 80)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Codigo:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(34, 227)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 13)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(34, 150)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(34, 27)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(100, 13)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos de Empleado"
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.lblRegistroEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnSiguienteEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnUltimoEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnAnteriorEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnPrimeroEmpleado)
        Me.grbEdicion.Location = New System.Drawing.Point(24, 440)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(292, 61)
        Me.grbEdicion.TabIndex = 1
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'lblRegistroEmpleado
        '
        Me.lblRegistroEmpleado.AutoSize = True
        Me.lblRegistroEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroEmpleado.Location = New System.Drawing.Point(121, 25)
        Me.lblRegistroEmpleado.Name = "lblRegistroEmpleado"
        Me.lblRegistroEmpleado.Size = New System.Drawing.Size(42, 13)
        Me.lblRegistroEmpleado.TabIndex = 4
        Me.lblRegistroEmpleado.Text = "x de n"
        '
        'btnSiguienteEmpleado
        '
        Me.btnSiguienteEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteEmpleado.Location = New System.Drawing.Point(202, 20)
        Me.btnSiguienteEmpleado.Name = "btnSiguienteEmpleado"
        Me.btnSiguienteEmpleado.Size = New System.Drawing.Size(28, 23)
        Me.btnSiguienteEmpleado.TabIndex = 3
        Me.btnSiguienteEmpleado.Text = ">"
        Me.btnSiguienteEmpleado.UseVisualStyleBackColor = True
        '
        'btnUltimoEmpleado
        '
        Me.btnUltimoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoEmpleado.Location = New System.Drawing.Point(236, 20)
        Me.btnUltimoEmpleado.Name = "btnUltimoEmpleado"
        Me.btnUltimoEmpleado.Size = New System.Drawing.Size(33, 23)
        Me.btnUltimoEmpleado.TabIndex = 2
        Me.btnUltimoEmpleado.Text = ">l"
        Me.btnUltimoEmpleado.UseVisualStyleBackColor = True
        '
        'btnAnteriorEmpleado
        '
        Me.btnAnteriorEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorEmpleado.Location = New System.Drawing.Point(60, 20)
        Me.btnAnteriorEmpleado.Name = "btnAnteriorEmpleado"
        Me.btnAnteriorEmpleado.Size = New System.Drawing.Size(28, 23)
        Me.btnAnteriorEmpleado.TabIndex = 1
        Me.btnAnteriorEmpleado.Text = "<"
        Me.btnAnteriorEmpleado.UseVisualStyleBackColor = True
        '
        'btnPrimeroEmpleado
        '
        Me.btnPrimeroEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroEmpleado.Location = New System.Drawing.Point(21, 20)
        Me.btnPrimeroEmpleado.Name = "btnPrimeroEmpleado"
        Me.btnPrimeroEmpleado.Size = New System.Drawing.Size(33, 23)
        Me.btnPrimeroEmpleado.TabIndex = 0
        Me.btnPrimeroEmpleado.Text = "l<"
        Me.btnPrimeroEmpleado.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.btnBuscarEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnEliminarEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnModificarEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnAgregarEmpleado)
        Me.grbNavegacion.Location = New System.Drawing.Point(358, 440)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(280, 61)
        Me.grbNavegacion.TabIndex = 2
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(7, 25)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(54, 23)
        Me.btnAgregarEmpleado.TabIndex = 0
        Me.btnAgregarEmpleado.Text = "Nuevo"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(67, 25)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(60, 23)
        Me.btnModificarEmpleado.TabIndex = 1
        Me.btnModificarEmpleado.Text = "Modificar"
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(134, 25)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarEmpleado.TabIndex = 2
        Me.btnEliminarEmpleado.Text = "Eliminar"
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(216, 25)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(58, 23)
        Me.btnBuscarEmpleado.TabIndex = 3
        Me.btnBuscarEmpleado.Text = "Buscar"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 531)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmEmpleados"
        Me.Text = "Registro de empleados"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbEdicion.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
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
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents grbNavegacion As GroupBox
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
