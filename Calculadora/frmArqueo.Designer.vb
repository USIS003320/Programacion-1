<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArqueo
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
        Me.btnBuscarArqueo = New System.Windows.Forms.Button()
        Me.btnEliminarArqueo = New System.Windows.Forms.Button()
        Me.btnModificarArqueo = New System.Windows.Forms.Button()
        Me.btnAgregarArqueo = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroArqueo = New System.Windows.Forms.Label()
        Me.btnSiguienteArqueo = New System.Windows.Forms.Button()
        Me.btnUltimoArqueo = New System.Windows.Forms.Button()
        Me.btnAnteriorArqueo = New System.Windows.Forms.Button()
        Me.btnPrimeroArqueo = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtTelefonoArqueo = New System.Windows.Forms.TextBox()
        Me.txtDireccionArqueo = New System.Windows.Forms.TextBox()
        Me.txtPagoArqueo = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleadoAr = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarArqueo)
        Me.grbEdicion.Controls.Add(Me.btnEliminarArqueo)
        Me.grbEdicion.Controls.Add(Me.btnModificarArqueo)
        Me.grbEdicion.Controls.Add(Me.btnAgregarArqueo)
        Me.grbEdicion.Location = New System.Drawing.Point(514, 673)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 94)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarArqueo
        '
        Me.btnBuscarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarArqueo.Location = New System.Drawing.Point(324, 38)
        Me.btnBuscarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscarArqueo.Name = "btnBuscarArqueo"
        Me.btnBuscarArqueo.Size = New System.Drawing.Size(87, 35)
        Me.btnBuscarArqueo.TabIndex = 3
        Me.btnBuscarArqueo.Text = "Buscar"
        Me.btnBuscarArqueo.UseVisualStyleBackColor = True
        '
        'btnEliminarArqueo
        '
        Me.btnEliminarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarArqueo.Location = New System.Drawing.Point(201, 38)
        Me.btnEliminarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarArqueo.Name = "btnEliminarArqueo"
        Me.btnEliminarArqueo.Size = New System.Drawing.Size(112, 35)
        Me.btnEliminarArqueo.TabIndex = 2
        Me.btnEliminarArqueo.Text = "Eliminar"
        Me.btnEliminarArqueo.UseVisualStyleBackColor = True
        '
        'btnModificarArqueo
        '
        Me.btnModificarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarArqueo.Location = New System.Drawing.Point(100, 38)
        Me.btnModificarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificarArqueo.Name = "btnModificarArqueo"
        Me.btnModificarArqueo.Size = New System.Drawing.Size(90, 35)
        Me.btnModificarArqueo.TabIndex = 1
        Me.btnModificarArqueo.Text = "Modificar"
        Me.btnModificarArqueo.UseVisualStyleBackColor = True
        '
        'btnAgregarArqueo
        '
        Me.btnAgregarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarArqueo.Location = New System.Drawing.Point(10, 38)
        Me.btnAgregarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarArqueo.Name = "btnAgregarArqueo"
        Me.btnAgregarArqueo.Size = New System.Drawing.Size(81, 35)
        Me.btnAgregarArqueo.TabIndex = 0
        Me.btnAgregarArqueo.Text = "Nuevo"
        Me.btnAgregarArqueo.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroArqueo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteArqueo)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoArqueo)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorArqueo)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroArqueo)
        Me.grbNavegacion.Location = New System.Drawing.Point(13, 673)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Size = New System.Drawing.Size(438, 94)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroArqueo
        '
        Me.lblRegistroArqueo.AutoSize = True
        Me.lblRegistroArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroArqueo.Location = New System.Drawing.Point(182, 38)
        Me.lblRegistroArqueo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistroArqueo.Name = "lblRegistroArqueo"
        Me.lblRegistroArqueo.Size = New System.Drawing.Size(60, 20)
        Me.lblRegistroArqueo.TabIndex = 4
        Me.lblRegistroArqueo.Text = "x de n"
        '
        'btnSiguienteArqueo
        '
        Me.btnSiguienteArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteArqueo.Location = New System.Drawing.Point(303, 31)
        Me.btnSiguienteArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSiguienteArqueo.Name = "btnSiguienteArqueo"
        Me.btnSiguienteArqueo.Size = New System.Drawing.Size(42, 35)
        Me.btnSiguienteArqueo.TabIndex = 3
        Me.btnSiguienteArqueo.Text = ">"
        Me.btnSiguienteArqueo.UseVisualStyleBackColor = True
        '
        'btnUltimoArqueo
        '
        Me.btnUltimoArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoArqueo.Location = New System.Drawing.Point(354, 31)
        Me.btnUltimoArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUltimoArqueo.Name = "btnUltimoArqueo"
        Me.btnUltimoArqueo.Size = New System.Drawing.Size(50, 35)
        Me.btnUltimoArqueo.TabIndex = 2
        Me.btnUltimoArqueo.Text = ">l"
        Me.btnUltimoArqueo.UseVisualStyleBackColor = True
        '
        'btnAnteriorArqueo
        '
        Me.btnAnteriorArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorArqueo.Location = New System.Drawing.Point(90, 31)
        Me.btnAnteriorArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnteriorArqueo.Name = "btnAnteriorArqueo"
        Me.btnAnteriorArqueo.Size = New System.Drawing.Size(42, 35)
        Me.btnAnteriorArqueo.TabIndex = 1
        Me.btnAnteriorArqueo.Text = "<"
        Me.btnAnteriorArqueo.UseVisualStyleBackColor = True
        '
        'btnPrimeroArqueo
        '
        Me.btnPrimeroArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroArqueo.Location = New System.Drawing.Point(32, 31)
        Me.btnPrimeroArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrimeroArqueo.Name = "btnPrimeroArqueo"
        Me.btnPrimeroArqueo.Size = New System.Drawing.Size(50, 35)
        Me.btnPrimeroArqueo.TabIndex = 0
        Me.btnPrimeroArqueo.Text = "l<"
        Me.btnPrimeroArqueo.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtTelefonoArqueo)
        Me.grbDatos.Controls.Add(Me.txtDireccionArqueo)
        Me.grbDatos.Controls.Add(Me.txtPagoArqueo)
        Me.grbDatos.Controls.Add(Me.txtNombreEmpleadoAr)
        Me.grbDatos.Controls.Add(Me.lblTelefono)
        Me.grbDatos.Controls.Add(Me.lblPago)
        Me.grbDatos.Controls.Add(Me.lblDireccion)
        Me.grbDatos.Controls.Add(Me.lblNombre)
        Me.grbDatos.Controls.Add(Me.lblDatos)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(13, 14)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatos.Size = New System.Drawing.Size(876, 631)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Arqueo"
        '
        'txtTelefonoArqueo
        '
        Me.txtTelefonoArqueo.Location = New System.Drawing.Point(186, 340)
        Me.txtTelefonoArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefonoArqueo.Name = "txtTelefonoArqueo"
        Me.txtTelefonoArqueo.Size = New System.Drawing.Size(244, 26)
        Me.txtTelefonoArqueo.TabIndex = 8
        '
        'txtDireccionArqueo
        '
        Me.txtDireccionArqueo.Location = New System.Drawing.Point(186, 149)
        Me.txtDireccionArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccionArqueo.Multiline = True
        Me.txtDireccionArqueo.Name = "txtDireccionArqueo"
        Me.txtDireccionArqueo.Size = New System.Drawing.Size(410, 139)
        Me.txtDireccionArqueo.TabIndex = 7
        '
        'txtPagoArqueo
        '
        Me.txtPagoArqueo.Location = New System.Drawing.Point(186, 444)
        Me.txtPagoArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPagoArqueo.Name = "txtPagoArqueo"
        Me.txtPagoArqueo.Size = New System.Drawing.Size(427, 26)
        Me.txtPagoArqueo.TabIndex = 6
        '
        'txtNombreEmpleadoAr
        '
        Me.txtNombreEmpleadoAr.Location = New System.Drawing.Point(252, 73)
        Me.txtNombreEmpleadoAr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreEmpleadoAr.Name = "txtNombreEmpleadoAr"
        Me.txtNombreEmpleadoAr.Size = New System.Drawing.Size(186, 26)
        Me.txtNombreEmpleadoAr.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(45, 340)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(87, 20)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(45, 447)
        Me.lblPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(140, 20)
        Me.lblPago.TabIndex = 3
        Me.lblPago.Text = "Forma de pago:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(45, 149)
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
        Me.lblNombre.Location = New System.Drawing.Point(45, 79)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(204, 20)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre de Empleados:"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(51, 42)
        Me.lblDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(130, 20)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos de Arqueo"
        '
        'frmArqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 774)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmArqueo"
        Me.Text = "Registro de Arqueo"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarArqueo As Button
    Friend WithEvents btnEliminarArqueo As Button
    Friend WithEvents btnModificarArqueo As Button
    Friend WithEvents btnAgregarArqueo As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroArqueo As Label
    Friend WithEvents btnSiguienteArqueo As Button
    Friend WithEvents btnUltimoArqueo As Button
    Friend WithEvents btnAnteriorArqueo As Button
    Friend WithEvents btnPrimeroArqueo As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtTelefonoArqueo As TextBox
    Friend WithEvents txtDireccionArqueo As TextBox
    Friend WithEvents txtPagoArqueo As TextBox
    Friend WithEvents txtNombreEmpleadoAr As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDatos As Label
End Class
