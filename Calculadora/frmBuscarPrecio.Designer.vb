<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPrecio
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
        Me.grdBuscarPrecio = New System.Windows.Forms.DataGridView()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarPrecio = New System.Windows.Forms.TextBox()
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        CType(Me.grdBuscarPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Location = New System.Drawing.Point(923, 758)
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
        Me.btnSeleccionarProducto.Location = New System.Drawing.Point(573, 758)
        Me.btnSeleccionarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSeleccionarProducto.Name = "btnSeleccionarProducto"
        Me.btnSeleccionarProducto.Size = New System.Drawing.Size(318, 62)
        Me.btnSeleccionarProducto.TabIndex = 13
        Me.btnSeleccionarProducto.Text = "Seleccionar Precio"
        Me.btnSeleccionarProducto.UseVisualStyleBackColor = True
        '
        'grdBuscarPrecio
        '
        Me.grdBuscarPrecio.AllowUserToAddRows = False
        Me.grdBuscarPrecio.AllowUserToDeleteRows = False
        Me.grdBuscarPrecio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarPrecio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.nombre, Me.Medidas})
        Me.grdBuscarPrecio.Location = New System.Drawing.Point(50, 75)
        Me.grdBuscarPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdBuscarPrecio.Name = "grdBuscarPrecio"
        Me.grdBuscarPrecio.ReadOnly = True
        Me.grdBuscarPrecio.RowHeadersWidth = 62
        Me.grdBuscarPrecio.Size = New System.Drawing.Size(1191, 674)
        Me.grdBuscarPrecio.TabIndex = 12
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
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'Medidas
        '
        Me.Medidas.DataPropertyName = "Precio"
        Me.Medidas.HeaderText = "Precio"
        Me.Medidas.MinimumWidth = 8
        Me.Medidas.Name = "Medidas"
        Me.Medidas.ReadOnly = True
        Me.Medidas.Width = 150
        '
        'txtBuscarPrecio
        '
        Me.txtBuscarPrecio.Location = New System.Drawing.Point(145, 32)
        Me.txtBuscarPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBuscarPrecio.Name = "txtBuscarPrecio"
        Me.txtBuscarPrecio.Size = New System.Drawing.Size(888, 26)
        Me.txtBuscarPrecio.TabIndex = 11
        '
        'lblBuscarProducto
        '
        Me.lblBuscarProducto.AutoSize = True
        Me.lblBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarProducto.Location = New System.Drawing.Point(45, 34)
        Me.lblBuscarProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(86, 25)
        Me.lblBuscarProducto.TabIndex = 10
        Me.lblBuscarProducto.Text = "Buscar:"
        '
        'frmBuscarPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 853)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnSeleccionarProducto)
        Me.Controls.Add(Me.grdBuscarPrecio)
        Me.Controls.Add(Me.txtBuscarPrecio)
        Me.Controls.Add(Me.lblBuscarProducto)
        Me.Name = "frmBuscarPrecio"
        Me.Text = "frmBuscarPrecio"
        CType(Me.grdBuscarPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnSeleccionarProducto As Button
    Friend WithEvents grdBuscarPrecio As DataGridView
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Medidas As DataGridViewTextBoxColumn
    Friend WithEvents txtBuscarPrecio As TextBox
    Friend WithEvents lblBuscarProducto As Label
End Class
