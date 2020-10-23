<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProducto
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
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnSeleccionarProducto = New System.Windows.Forms.Button()
        Me.grdBuscarProducto = New System.Windows.Forms.DataGridView()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pedidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        CType(Me.grdBuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Location = New System.Drawing.Point(612, 487)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(212, 40)
        Me.btnCancelarProducto.TabIndex = 9
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnSeleccionarProducto
        '
        Me.btnSeleccionarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProducto.Location = New System.Drawing.Point(379, 487)
        Me.btnSeleccionarProducto.Name = "btnSeleccionarProducto"
        Me.btnSeleccionarProducto.Size = New System.Drawing.Size(212, 40)
        Me.btnSeleccionarProducto.TabIndex = 8
        Me.btnSeleccionarProducto.Text = "Seleccionar Producto"
        Me.btnSeleccionarProducto.UseVisualStyleBackColor = True
        '
        'grdBuscarProducto
        '
        Me.grdBuscarProducto.AllowUserToAddRows = False
        Me.grdBuscarProducto.AllowUserToDeleteRows = False
        Me.grdBuscarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.categoria, Me.codigo, Me.nombre, Me.Pedidos, Me.Medidas})
        Me.grdBuscarProducto.Location = New System.Drawing.Point(30, 43)
        Me.grdBuscarProducto.Name = "grdBuscarProducto"
        Me.grdBuscarProducto.ReadOnly = True
        Me.grdBuscarProducto.Size = New System.Drawing.Size(794, 438)
        Me.grdBuscarProducto.TabIndex = 7
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "idProducto"
        Me.idProducto.HeaderText = "ID"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Visible = False
        '
        'categoria
        '
        Me.categoria.DataPropertyName = "categoria"
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Width = 150
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'Pedidos
        '
        Me.Pedidos.DataPropertyName = "pedidos"
        Me.Pedidos.HeaderText = "Pedidos"
        Me.Pedidos.Name = "Pedidos"
        Me.Pedidos.ReadOnly = True
        Me.Pedidos.Width = 150
        '
        'Medidas
        '
        Me.Medidas.DataPropertyName = "medidas"
        Me.Medidas.HeaderText = "Medidas"
        Me.Medidas.Name = "Medidas"
        Me.Medidas.ReadOnly = True
        Me.Medidas.Width = 150
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(93, 15)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(593, 20)
        Me.txtBuscarProducto.TabIndex = 6
        '
        'lblBuscarProducto
        '
        Me.lblBuscarProducto.AutoSize = True
        Me.lblBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarProducto.Location = New System.Drawing.Point(27, 16)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(60, 16)
        Me.lblBuscarProducto.TabIndex = 5
        Me.lblBuscarProducto.Text = "Buscar:"
        '
        'frmBuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 535)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnSeleccionarProducto)
        Me.Controls.Add(Me.grdBuscarProducto)
        Me.Controls.Add(Me.txtBuscarProducto)
        Me.Controls.Add(Me.lblBuscarProducto)
        Me.Name = "frmBuscarProducto"
        Me.Text = "Buscar Producto"
        CType(Me.grdBuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnSeleccionarProducto As Button
    Friend WithEvents grdBuscarProducto As DataGridView
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents lblBuscarProducto As Label
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Pedidos As DataGridViewTextBoxColumn
    Friend WithEvents Medidas As DataGridViewTextBoxColumn
End Class
