<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroProveedor = New System.Windows.Forms.Label()
        Me.btnSiguienteProveedor = New System.Windows.Forms.Button()
        Me.btnUltimoProveedor = New System.Windows.Forms.Button()
        Me.btnAnteriorProveedor = New System.Windows.Forms.Button()
        Me.btnPrimerProveedor = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtTelefonodeProveedor = New System.Windows.Forms.TextBox()
        Me.txtDirecciondeProveedor = New System.Windows.Forms.TextBox()
        Me.txtNombredeProveedor = New System.Windows.Forms.TextBox()
        Me.txtCodigodeProveedor = New System.Windows.Forms.TextBox()
        Me.lblTelefonoProveedor = New System.Windows.Forms.Label()
        Me.lblCodigoProveedor = New System.Windows.Forms.Label()
        Me.lblDireccionProveedor = New System.Windows.Forms.Label()
        Me.lblNombreProveedor = New System.Windows.Forms.Label()
        Me.lblDatosProveedor = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnModificarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProveedor)
        Me.grbEdicion.Location = New System.Drawing.Point(56, 12)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(280, 61)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(216, 25)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(58, 23)
        Me.btnBuscarProveedor.TabIndex = 3
        Me.btnBuscarProveedor.Text = "Buscar"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'btnEliminarProveedor
        '
        Me.btnEliminarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProveedor.Location = New System.Drawing.Point(135, 25)
        Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
        Me.btnEliminarProveedor.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarProveedor.TabIndex = 2
        Me.btnEliminarProveedor.Text = "Eliminar"
        Me.btnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProveedor.Location = New System.Drawing.Point(67, 25)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(60, 23)
        Me.btnModificarProveedor.TabIndex = 1
        Me.btnModificarProveedor.Text = "Modificar"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(7, 25)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(54, 23)
        Me.btnAgregarProveedor.TabIndex = 0
        Me.btnAgregarProveedor.Text = "Nuevo"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerProveedor)
        Me.grbNavegacion.Location = New System.Drawing.Point(348, 12)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(292, 61)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroProveedor
        '
        Me.lblRegistroProveedor.AutoSize = True
        Me.lblRegistroProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroProveedor.Location = New System.Drawing.Point(121, 25)
        Me.lblRegistroProveedor.Name = "lblRegistroProveedor"
        Me.lblRegistroProveedor.Size = New System.Drawing.Size(42, 13)
        Me.lblRegistroProveedor.TabIndex = 4
        Me.lblRegistroProveedor.Text = "x de n"
        '
        'btnSiguienteProveedor
        '
        Me.btnSiguienteProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProveedor.Location = New System.Drawing.Point(202, 20)
        Me.btnSiguienteProveedor.Name = "btnSiguienteProveedor"
        Me.btnSiguienteProveedor.Size = New System.Drawing.Size(28, 23)
        Me.btnSiguienteProveedor.TabIndex = 3
        Me.btnSiguienteProveedor.Text = ">"
        Me.btnSiguienteProveedor.UseVisualStyleBackColor = True
        '
        'btnUltimoProveedor
        '
        Me.btnUltimoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProveedor.Location = New System.Drawing.Point(236, 20)
        Me.btnUltimoProveedor.Name = "btnUltimoProveedor"
        Me.btnUltimoProveedor.Size = New System.Drawing.Size(33, 23)
        Me.btnUltimoProveedor.TabIndex = 2
        Me.btnUltimoProveedor.Text = ">l"
        Me.btnUltimoProveedor.UseVisualStyleBackColor = True
        '
        'btnAnteriorProveedor
        '
        Me.btnAnteriorProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProveedor.Location = New System.Drawing.Point(60, 20)
        Me.btnAnteriorProveedor.Name = "btnAnteriorProveedor"
        Me.btnAnteriorProveedor.Size = New System.Drawing.Size(28, 23)
        Me.btnAnteriorProveedor.TabIndex = 1
        Me.btnAnteriorProveedor.Text = "<"
        Me.btnAnteriorProveedor.UseVisualStyleBackColor = True
        '
        'btnPrimerProveedor
        '
        Me.btnPrimerProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerProveedor.Location = New System.Drawing.Point(21, 20)
        Me.btnPrimerProveedor.Name = "btnPrimerProveedor"
        Me.btnPrimerProveedor.Size = New System.Drawing.Size(33, 23)
        Me.btnPrimerProveedor.TabIndex = 0
        Me.btnPrimerProveedor.Text = "l<"
        Me.btnPrimerProveedor.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtTelefonodeProveedor)
        Me.grbDatos.Controls.Add(Me.txtDirecciondeProveedor)
        Me.grbDatos.Controls.Add(Me.txtNombredeProveedor)
        Me.grbDatos.Controls.Add(Me.txtCodigodeProveedor)
        Me.grbDatos.Controls.Add(Me.lblTelefonoProveedor)
        Me.grbDatos.Controls.Add(Me.lblCodigoProveedor)
        Me.grbDatos.Controls.Add(Me.lblDireccionProveedor)
        Me.grbDatos.Controls.Add(Me.lblNombreProveedor)
        Me.grbDatos.Controls.Add(Me.lblDatosProveedor)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(56, 96)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(584, 410)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de proveedor"
        '
        'txtTelefonodeProveedor
        '
        Me.txtTelefonodeProveedor.Location = New System.Drawing.Point(105, 353)
        Me.txtTelefonodeProveedor.Name = "txtTelefonodeProveedor"
        Me.txtTelefonodeProveedor.Size = New System.Drawing.Size(164, 20)
        Me.txtTelefonodeProveedor.TabIndex = 8
        '
        'txtDirecciondeProveedor
        '
        Me.txtDirecciondeProveedor.Location = New System.Drawing.Point(101, 208)
        Me.txtDirecciondeProveedor.Multiline = True
        Me.txtDirecciondeProveedor.Name = "txtDirecciondeProveedor"
        Me.txtDirecciondeProveedor.Size = New System.Drawing.Size(275, 92)
        Me.txtDirecciondeProveedor.TabIndex = 7
        '
        'txtNombredeProveedor
        '
        Me.txtNombredeProveedor.Location = New System.Drawing.Point(90, 146)
        Me.txtNombredeProveedor.Name = "txtNombredeProveedor"
        Me.txtNombredeProveedor.Size = New System.Drawing.Size(286, 20)
        Me.txtNombredeProveedor.TabIndex = 6
        '
        'txtCodigodeProveedor
        '
        Me.txtCodigodeProveedor.Location = New System.Drawing.Point(90, 69)
        Me.txtCodigodeProveedor.Name = "txtCodigodeProveedor"
        Me.txtCodigodeProveedor.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigodeProveedor.TabIndex = 5
        '
        'lblTelefonoProveedor
        '
        Me.lblTelefonoProveedor.AutoSize = True
        Me.lblTelefonoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoProveedor.Location = New System.Drawing.Point(38, 356)
        Me.lblTelefonoProveedor.Name = "lblTelefonoProveedor"
        Me.lblTelefonoProveedor.Size = New System.Drawing.Size(61, 13)
        Me.lblTelefonoProveedor.TabIndex = 4
        Me.lblTelefonoProveedor.Text = "Telefono:"
        '
        'lblCodigoProveedor
        '
        Me.lblCodigoProveedor.AutoSize = True
        Me.lblCodigoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProveedor.Location = New System.Drawing.Point(34, 72)
        Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
        Me.lblCodigoProveedor.Size = New System.Drawing.Size(50, 13)
        Me.lblCodigoProveedor.TabIndex = 3
        Me.lblCodigoProveedor.Text = "Codigo:"
        '
        'lblDireccionProveedor
        '
        Me.lblDireccionProveedor.AutoSize = True
        Me.lblDireccionProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionProveedor.Location = New System.Drawing.Point(30, 211)
        Me.lblDireccionProveedor.Name = "lblDireccionProveedor"
        Me.lblDireccionProveedor.Size = New System.Drawing.Size(65, 13)
        Me.lblDireccionProveedor.TabIndex = 2
        Me.lblDireccionProveedor.Text = "Direccion:"
        '
        'lblNombreProveedor
        '
        Me.lblNombreProveedor.AutoSize = True
        Me.lblNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProveedor.Location = New System.Drawing.Point(30, 149)
        Me.lblNombreProveedor.Name = "lblNombreProveedor"
        Me.lblNombreProveedor.Size = New System.Drawing.Size(54, 13)
        Me.lblNombreProveedor.TabIndex = 1
        Me.lblNombreProveedor.Text = "Nombre:"
        '
        'lblDatosProveedor
        '
        Me.lblDatosProveedor.AutoSize = True
        Me.lblDatosProveedor.Location = New System.Drawing.Point(34, 27)
        Me.lblDatosProveedor.Name = "lblDatosProveedor"
        Me.lblDatosProveedor.Size = New System.Drawing.Size(102, 13)
        Me.lblDatosProveedor.TabIndex = 0
        Me.lblDatosProveedor.Text = "Datos de Proveedor"
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 531)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Controls.Add(Me.grbEdicion)
        Me.Name = "frmProveedor"
        Me.Text = "Registro Proveedor"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroProveedor As Label
    Friend WithEvents btnSiguienteProveedor As Button
    Friend WithEvents btnUltimoProveedor As Button
    Friend WithEvents btnAnteriorProveedor As Button
    Friend WithEvents btnPrimerProveedor As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtTelefonodeProveedor As TextBox
    Friend WithEvents txtDirecciondeProveedor As TextBox
    Friend WithEvents txtNombredeProveedor As TextBox
    Friend WithEvents txtCodigodeProveedor As TextBox
    Friend WithEvents lblTelefonoProveedor As Label
    Friend WithEvents lblCodigoProveedor As Label
    Friend WithEvents lblDireccionProveedor As Label
    Friend WithEvents lblNombreProveedor As Label
    Friend WithEvents lblDatosProveedor As Label
End Class
