<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProveedor
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
        Me.btnCancelarProveedor = New System.Windows.Forms.Button()
        Me.btnSeleccionarProveedor = New System.Windows.Forms.Button()
        Me.grdBuscarProveedor = New System.Windows.Forms.DataGridView()
        Me.txtBuscarProveedor = New System.Windows.Forms.TextBox()
        Me.lblBuscarProveedor = New System.Windows.Forms.Label()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProveedor
        '
        Me.btnCancelarProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProveedor.Location = New System.Drawing.Point(617, 554)
        Me.btnCancelarProveedor.Name = "btnCancelarProveedor"
        Me.btnCancelarProveedor.Size = New System.Drawing.Size(212, 40)
        Me.btnCancelarProveedor.TabIndex = 9
        Me.btnCancelarProveedor.Text = "Cancelar"
        Me.btnCancelarProveedor.UseVisualStyleBackColor = True
        '
        'btnSeleccionarProveedor
        '
        Me.btnSeleccionarProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProveedor.Location = New System.Drawing.Point(384, 554)
        Me.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor"
        Me.btnSeleccionarProveedor.Size = New System.Drawing.Size(212, 40)
        Me.btnSeleccionarProveedor.TabIndex = 8
        Me.btnSeleccionarProveedor.Text = "Seleccionar Proveedor"
        Me.btnSeleccionarProveedor.UseVisualStyleBackColor = True
        '
        'grdBuscarProveedor
        '
        Me.grdBuscarProveedor.AllowUserToAddRows = False
        Me.grdBuscarProveedor.AllowUserToDeleteRows = False
        Me.grdBuscarProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProveedor, Me.codigo, Me.nombre, Me.direccion, Me.telefono})
        Me.grdBuscarProveedor.Location = New System.Drawing.Point(33, 47)
        Me.grdBuscarProveedor.Name = "grdBuscarProveedor"
        Me.grdBuscarProveedor.ReadOnly = True
        Me.grdBuscarProveedor.Size = New System.Drawing.Size(794, 501)
        Me.grdBuscarProveedor.TabIndex = 7
        '
        'txtBuscarProveedor
        '
        Me.txtBuscarProveedor.Location = New System.Drawing.Point(96, 12)
        Me.txtBuscarProveedor.Name = "txtBuscarProveedor"
        Me.txtBuscarProveedor.Size = New System.Drawing.Size(593, 20)
        Me.txtBuscarProveedor.TabIndex = 6
        '
        'lblBuscarProveedor
        '
        Me.lblBuscarProveedor.AutoSize = True
        Me.lblBuscarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarProveedor.Location = New System.Drawing.Point(30, 16)
        Me.lblBuscarProveedor.Name = "lblBuscarProveedor"
        Me.lblBuscarProveedor.Size = New System.Drawing.Size(60, 16)
        Me.lblBuscarProveedor.TabIndex = 5
        Me.lblBuscarProveedor.Text = "Buscar:"
        '
        'idProveedor
        '
        Me.idProveedor.DataPropertyName = "idProveedor"
        Me.idProveedor.HeaderText = "ID"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        Me.idProveedor.Visible = False
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
        'frmBuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 598)
        Me.Controls.Add(Me.btnCancelarProveedor)
        Me.Controls.Add(Me.btnSeleccionarProveedor)
        Me.Controls.Add(Me.grdBuscarProveedor)
        Me.Controls.Add(Me.txtBuscarProveedor)
        Me.Controls.Add(Me.lblBuscarProveedor)
        Me.Name = "frmBuscarProveedor"
        Me.Text = "Buscar Proveedor"
        CType(Me.grdBuscarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProveedor As Button
    Friend WithEvents btnSeleccionarProveedor As Button
    Friend WithEvents grdBuscarProveedor As DataGridView
    Friend WithEvents txtBuscarProveedor As TextBox
    Friend WithEvents lblBuscarProveedor As Label
    Friend WithEvents idProveedor As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
End Class
