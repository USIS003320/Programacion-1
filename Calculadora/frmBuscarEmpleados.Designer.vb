<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmpleados
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
        Me.lblBuscarEmpleado = New System.Windows.Forms.Label()
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.grdBuscarEmpleado = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionarEmpleado = New System.Windows.Forms.Button()
        Me.btnCancelarEmpleado = New System.Windows.Forms.Button()
        CType(Me.grdBuscarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscarEmpleado
        '
        Me.lblBuscarEmpleado.AutoSize = True
        Me.lblBuscarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEmpleado.Location = New System.Drawing.Point(12, 20)
        Me.lblBuscarEmpleado.Name = "lblBuscarEmpleado"
        Me.lblBuscarEmpleado.Size = New System.Drawing.Size(60, 16)
        Me.lblBuscarEmpleado.TabIndex = 0
        Me.lblBuscarEmpleado.Text = "Buscar:"
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(78, 16)
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(593, 20)
        Me.txtBuscarEmpleado.TabIndex = 1
        '
        'grdBuscarEmpleado
        '
        Me.grdBuscarEmpleado.AllowUserToAddRows = False
        Me.grdBuscarEmpleado.AllowUserToDeleteRows = False
        Me.grdBuscarEmpleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.codigo, Me.nombre, Me.direccion, Me.telefono})
        Me.grdBuscarEmpleado.Location = New System.Drawing.Point(15, 61)
        Me.grdBuscarEmpleado.Name = "grdBuscarEmpleado"
        Me.grdBuscarEmpleado.ReadOnly = True
        Me.grdBuscarEmpleado.Size = New System.Drawing.Size(794, 438)
        Me.grdBuscarEmpleado.TabIndex = 2
        '
        'idEmpleado
        '
        Me.idEmpleado.DataPropertyName = "idEmpleado"
        Me.idEmpleado.HeaderText = "ID"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 250
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 150
        '
        'btnSeleccionarEmpleado
        '
        Me.btnSeleccionarEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarEmpleado.Location = New System.Drawing.Point(364, 514)
        Me.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado"
        Me.btnSeleccionarEmpleado.Size = New System.Drawing.Size(212, 40)
        Me.btnSeleccionarEmpleado.TabIndex = 3
        Me.btnSeleccionarEmpleado.Text = "Seleccionar Empleado"
        Me.btnSeleccionarEmpleado.UseVisualStyleBackColor = True
        '
        'btnCancelarEmpleado
        '
        Me.btnCancelarEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEmpleado.Location = New System.Drawing.Point(597, 514)
        Me.btnCancelarEmpleado.Name = "btnCancelarEmpleado"
        Me.btnCancelarEmpleado.Size = New System.Drawing.Size(212, 40)
        Me.btnCancelarEmpleado.TabIndex = 4
        Me.btnCancelarEmpleado.Text = "Cancelar"
        Me.btnCancelarEmpleado.UseVisualStyleBackColor = True
        '
        'frmBuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 566)
        Me.Controls.Add(Me.btnCancelarEmpleado)
        Me.Controls.Add(Me.btnSeleccionarEmpleado)
        Me.Controls.Add(Me.grdBuscarEmpleado)
        Me.Controls.Add(Me.txtBuscarEmpleado)
        Me.Controls.Add(Me.lblBuscarEmpleado)
        Me.Name = "frmBuscarEmpleados"
        Me.Text = "Busqueda de registro de Empleados"
        CType(Me.grdBuscarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscarEmpleado As Label
    Friend WithEvents txtBuscarEmpleado As TextBox
    Friend WithEvents grdBuscarEmpleado As DataGridView
    Friend WithEvents btnSeleccionarEmpleado As Button
    Friend WithEvents btnCancelarEmpleado As Button
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
End Class
