<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarGanancias
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
        Me.btnCancelarGanancias = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grdBuscarGanancias = New System.Windows.Forms.DataGridView()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pedidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarGanancias = New System.Windows.Forms.TextBox()
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        CType(Me.grdBuscarGanancias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Location = New System.Drawing.Point(899, 931)
        Me.btnCancelarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(318, 62)
        Me.btnCancelarProducto.TabIndex = 14
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnSeleccionarProducto
        '
        Me.btnSeleccionarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProducto.Location = New System.Drawing.Point(549, 931)
        Me.btnSeleccionarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSeleccionarProducto.Name = "btnSeleccionarProducto"
        Me.btnSeleccionarProducto.Size = New System.Drawing.Size(318, 62)
        Me.btnSeleccionarProducto.TabIndex = 13
        Me.btnSeleccionarProducto.Text = "Seleccionar Producto"
        Me.btnSeleccionarProducto.UseVisualStyleBackColor = True
        '
        'btnCancelarGanancias
        '
        Me.btnCancelarGanancias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarGanancias.Location = New System.Drawing.Point(891, 743)
        Me.btnCancelarGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelarGanancias.Name = "btnCancelarGanancias"
        Me.btnCancelarGanancias.Size = New System.Drawing.Size(318, 62)
        Me.btnCancelarGanancias.TabIndex = 19
        Me.btnCancelarGanancias.Text = "Cancelar"
        Me.btnCancelarGanancias.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(541, 743)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(318, 62)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Seleccionar Ganancias"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grdBuscarGanancias
        '
        Me.grdBuscarGanancias.AllowUserToAddRows = False
        Me.grdBuscarGanancias.AllowUserToDeleteRows = False
        Me.grdBuscarGanancias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarGanancias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.categoria, Me.codigo, Me.nombre, Me.Pedidos, Me.Medidas})
        Me.grdBuscarGanancias.Location = New System.Drawing.Point(18, 60)
        Me.grdBuscarGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdBuscarGanancias.Name = "grdBuscarGanancias"
        Me.grdBuscarGanancias.ReadOnly = True
        Me.grdBuscarGanancias.RowHeadersWidth = 62
        Me.grdBuscarGanancias.Size = New System.Drawing.Size(1191, 674)
        Me.grdBuscarGanancias.TabIndex = 17
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "idProducto"
        Me.idProducto.HeaderText = "ID"
        Me.idProducto.MinimumWidth = 8
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Visible = False
        Me.idProducto.Width = 150
        '
        'categoria
        '
        Me.categoria.DataPropertyName = "categoria"
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.MinimumWidth = 8
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Width = 150
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.MinimumWidth = 8
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'Pedidos
        '
        Me.Pedidos.DataPropertyName = "pedidos"
        Me.Pedidos.HeaderText = "Pedidos"
        Me.Pedidos.MinimumWidth = 8
        Me.Pedidos.Name = "Pedidos"
        Me.Pedidos.ReadOnly = True
        Me.Pedidos.Width = 150
        '
        'Medidas
        '
        Me.Medidas.DataPropertyName = "medidas"
        Me.Medidas.HeaderText = "Medidas"
        Me.Medidas.MinimumWidth = 8
        Me.Medidas.Name = "Medidas"
        Me.Medidas.ReadOnly = True
        Me.Medidas.Width = 150
        '
        'txtBuscarGanancias
        '
        Me.txtBuscarGanancias.Location = New System.Drawing.Point(113, 17)
        Me.txtBuscarGanancias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBuscarGanancias.Name = "txtBuscarGanancias"
        Me.txtBuscarGanancias.Size = New System.Drawing.Size(888, 26)
        Me.txtBuscarGanancias.TabIndex = 16
        '
        'lblBuscarProducto
        '
        Me.lblBuscarProducto.AutoSize = True
        Me.lblBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarProducto.Location = New System.Drawing.Point(13, 19)
        Me.lblBuscarProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(86, 25)
        Me.lblBuscarProducto.TabIndex = 15
        Me.lblBuscarProducto.Text = "Buscar:"
        '
        'frmBuscarGanancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 844)
        Me.Controls.Add(Me.btnCancelarGanancias)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grdBuscarGanancias)
        Me.Controls.Add(Me.txtBuscarGanancias)
        Me.Controls.Add(Me.lblBuscarProducto)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnSeleccionarProducto)
        Me.Name = "frmBuscarGanancias"
        Me.Text = "frmBuscarGanancias"
        CType(Me.grdBuscarGanancias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnSeleccionarProducto As Button
    Friend WithEvents btnCancelarGanancias As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents grdBuscarGanancias As DataGridView
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Pedidos As DataGridViewTextBoxColumn
    Friend WithEvents Medidas As DataGridViewTextBoxColumn
    Friend WithEvents txtBuscarGanancias As TextBox
    Friend WithEvents lblBuscarProducto As Label
End Class
