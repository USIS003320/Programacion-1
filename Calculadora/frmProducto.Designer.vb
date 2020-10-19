<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroProducto = New System.Windows.Forms.Label()
        Me.btnSiguienteProducto = New System.Windows.Forms.Button()
        Me.btnUltimoProducto = New System.Windows.Forms.Button()
        Me.btnAnteriorProducto = New System.Windows.Forms.Button()
        Me.btnPrimeroProducto = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtCalidadProducto = New System.Windows.Forms.TextBox()
        Me.txtPesoProducto = New System.Windows.Forms.TextBox()
        Me.txtPedidosProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblCalidad = New System.Windows.Forms.Label()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblNombreP = New System.Windows.Forms.Label()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroProducto)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProducto)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProducto)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProducto)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProducto)
        Me.grbNavegacion.Location = New System.Drawing.Point(96, 521)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbNavegacion.Size = New System.Drawing.Size(438, 94)
        Me.grbNavegacion.TabIndex = 4
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
        'btnPrimeroProducto
        '
        Me.btnPrimeroProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProducto.Location = New System.Drawing.Point(32, 31)
        Me.btnPrimeroProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrimeroProducto.Name = "btnPrimeroProducto"
        Me.btnPrimeroProducto.Size = New System.Drawing.Size(50, 35)
        Me.btnPrimeroProducto.TabIndex = 0
        Me.btnPrimeroProducto.Text = "l<"
        Me.btnPrimeroProducto.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtCalidadProducto)
        Me.grbDatos.Controls.Add(Me.txtPesoProducto)
        Me.grbDatos.Controls.Add(Me.txtPedidosProducto)
        Me.grbDatos.Controls.Add(Me.txtNombreProducto)
        Me.grbDatos.Controls.Add(Me.lblCalidad)
        Me.grbDatos.Controls.Add(Me.lblPedido)
        Me.grbDatos.Controls.Add(Me.lblPeso)
        Me.grbDatos.Controls.Add(Me.lblNombreP)
        Me.grbDatos.Controls.Add(Me.lblDatos)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(64, 6)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbDatos.Size = New System.Drawing.Size(801, 483)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Productos"
        '
        'txtCalidadProducto
        '
        Me.txtCalidadProducto.Location = New System.Drawing.Point(135, 444)
        Me.txtCalidadProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCalidadProducto.Name = "txtCalidadProducto"
        Me.txtCalidadProducto.Size = New System.Drawing.Size(200, 26)
        Me.txtCalidadProducto.TabIndex = 8
        '
        'txtPesoProducto
        '
        Me.txtPesoProducto.Location = New System.Drawing.Point(135, 346)
        Me.txtPesoProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPesoProducto.Multiline = True
        Me.txtPesoProducto.Name = "txtPesoProducto"
        Me.txtPesoProducto.Size = New System.Drawing.Size(213, 27)
        Me.txtPesoProducto.TabIndex = 7
        '
        'txtPedidosProducto
        '
        Me.txtPedidosProducto.Location = New System.Drawing.Point(135, 226)
        Me.txtPedidosProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPedidosProducto.Name = "txtPedidosProducto"
        Me.txtPedidosProducto.Size = New System.Drawing.Size(200, 26)
        Me.txtPedidosProducto.TabIndex = 6
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(135, 123)
        Me.txtNombreProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(200, 26)
        Me.txtNombreProducto.TabIndex = 5
        '
        'lblCalidad
        '
        Me.lblCalidad.AutoSize = True
        Me.lblCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidad.Location = New System.Drawing.Point(36, 450)
        Me.lblCalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalidad.Name = "lblCalidad"
        Me.lblCalidad.Size = New System.Drawing.Size(78, 20)
        Me.lblCalidad.TabIndex = 4
        Me.lblCalidad.Text = "Calidad:"
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedido.Location = New System.Drawing.Point(51, 232)
        Me.lblPedido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(72, 20)
        Me.lblPedido.TabIndex = 3
        Me.lblPedido.Text = "Pedido:"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(66, 353)
        Me.lblPeso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(57, 20)
        Me.lblPeso.TabIndex = 2
        Me.lblPeso.Text = "Peso:"
        '
        'lblNombreP
        '
        Me.lblNombreP.AutoSize = True
        Me.lblNombreP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreP.Location = New System.Drawing.Point(44, 129)
        Me.lblNombreP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreP.Name = "lblNombreP"
        Me.lblNombreP.Size = New System.Drawing.Size(80, 20)
        Me.lblNombreP.TabIndex = 1
        Me.lblNombreP.Text = "Nombre:"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(51, 42)
        Me.lblDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(142, 20)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos de Producto"
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 621)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmProducto"
        Me.Text = "frmProducto"
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistroProducto As Label
    Friend WithEvents btnSiguienteProducto As Button
    Friend WithEvents btnUltimoProducto As Button
    Friend WithEvents btnAnteriorProducto As Button
    Friend WithEvents btnPrimeroProducto As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtCalidadProducto As TextBox
    Friend WithEvents txtPesoProducto As TextBox
    Friend WithEvents txtPedidosProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblCalidad As Label
    Friend WithEvents lblPedido As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblNombreP As Label
    Friend WithEvents lblDatos As Label
End Class
