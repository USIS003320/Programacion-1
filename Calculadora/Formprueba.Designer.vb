<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formprueba
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formprueba))
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim Fecha_compraLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim IdProveedorLabel As System.Windows.Forms.Label
        Me.Db_sistemaDataSet = New Calculadora.db_sistemaDataSet()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Calculadora.db_sistemaDataSetTableAdapters.comprasTableAdapter()
        Me.TableAdapterManager = New Calculadora.db_sistemaDataSetTableAdapters.TableAdapterManager()
        Me.ComprasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ComprasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_compraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipofacturaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.IdProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NfacturaLabel = New System.Windows.Forms.Label()
        Fecha_compraLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        IdProveedorLabel = New System.Windows.Forms.Label()
        CType(Me.Db_sistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasBindingNavigator.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_sistemaDataSet
        '
        Me.Db_sistemaDataSet.DataSetName = "db_sistemaDataSet"
        Me.Db_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "compras"
        Me.ComprasBindingSource.DataSource = Me.Db_sistemaDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArqueoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.dcomprasTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.GananciasTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.tipofacturaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Calculadora.db_sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComprasBindingNavigator
        '
        Me.ComprasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ComprasBindingNavigator.BindingSource = Me.ComprasBindingSource
        Me.ComprasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComprasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ComprasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComprasBindingNavigatorSaveItem})
        Me.ComprasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComprasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ComprasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ComprasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ComprasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ComprasBindingNavigator.Name = "ComprasBindingNavigator"
        Me.ComprasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComprasBindingNavigator.Size = New System.Drawing.Size(842, 25)
        Me.ComprasBindingNavigator.TabIndex = 0
        Me.ComprasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ComprasBindingNavigatorSaveItem
        '
        Me.ComprasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComprasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ComprasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComprasBindingNavigatorSaveItem.Name = "ComprasBindingNavigatorSaveItem"
        Me.ComprasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ComprasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(651, 12)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(55, 13)
        NfacturaLabel.TabIndex = 3
        NfacturaLabel.Text = "factura n.:"
        '
        'NfacturaTextBox
        '
        Me.NfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "nfactura", True))
        Me.NfacturaTextBox.Location = New System.Drawing.Point(705, 12)
        Me.NfacturaTextBox.Name = "NfacturaTextBox"
        Me.NfacturaTextBox.Size = New System.Drawing.Size(131, 20)
        Me.NfacturaTextBox.TabIndex = 4
        '
        'Fecha_compraLabel
        '
        Fecha_compraLabel.AutoSize = True
        Fecha_compraLabel.Location = New System.Drawing.Point(12, 74)
        Fecha_compraLabel.Name = "Fecha_compraLabel"
        Fecha_compraLabel.Size = New System.Drawing.Size(75, 13)
        Fecha_compraLabel.TabIndex = 5
        Fecha_compraLabel.Text = "fecha compra:"
        '
        'Fecha_compraDateTimePicker
        '
        Me.Fecha_compraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource, "fecha_compra", True))
        Me.Fecha_compraDateTimePicker.Location = New System.Drawing.Point(93, 69)
        Me.Fecha_compraDateTimePicker.Name = "Fecha_compraDateTimePicker"
        Me.Fecha_compraDateTimePicker.Size = New System.Drawing.Size(204, 20)
        Me.Fecha_compraDateTimePicker.TabIndex = 6
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(303, 74)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(67, 13)
        IdTipofacturaLabel.TabIndex = 9
        IdTipofacturaLabel.Text = "Tipo factura:"
        AddHandler IdTipofacturaLabel.Click, AddressOf Me.IdTipofacturaLabel_Click
        '
        'IdTipofacturaComboBox
        '
        Me.IdTipofacturaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "idTipofactura", True))
        Me.IdTipofacturaComboBox.FormattingEnabled = True
        Me.IdTipofacturaComboBox.Location = New System.Drawing.Point(376, 71)
        Me.IdTipofacturaComboBox.Name = "IdTipofacturaComboBox"
        Me.IdTipofacturaComboBox.Size = New System.Drawing.Size(157, 21)
        Me.IdTipofacturaComboBox.TabIndex = 10
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(589, 71)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(78, 13)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Forma de pago"
        '
        'IdPagoComboBox
        '
        Me.IdPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "idPago", True))
        Me.IdPagoComboBox.FormattingEnabled = True
        Me.IdPagoComboBox.Location = New System.Drawing.Point(690, 71)
        Me.IdPagoComboBox.Name = "IdPagoComboBox"
        Me.IdPagoComboBox.Size = New System.Drawing.Size(146, 21)
        Me.IdPagoComboBox.TabIndex = 12
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.Location = New System.Drawing.Point(12, 45)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(59, 13)
        IdProveedorLabel.TabIndex = 13
        IdProveedorLabel.Text = "Proveedor:"
        '
        'IdProveedorComboBox
        '
        Me.IdProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "IdProveedor", True))
        Me.IdProveedorComboBox.FormattingEnabled = True
        Me.IdProveedorComboBox.Location = New System.Drawing.Point(77, 42)
        Me.IdProveedorComboBox.Name = "IdProveedorComboBox"
        Me.IdProveedorComboBox.Size = New System.Drawing.Size(200, 21)
        Me.IdProveedorComboBox.TabIndex = 14
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Db_sistemaDataSet
        '
        'DataTable1DataGridView
        '
        Me.DataTable1DataGridView.AllowUserToAddRows = False
        Me.DataTable1DataGridView.AllowUserToDeleteRows = False
        Me.DataTable1DataGridView.AutoGenerateColumns = False
        Me.DataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.subtotal, Me.DataGridViewTextBoxColumn8})
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(41, 112)
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.ReadOnly = True
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(789, 336)
        Me.DataTable1DataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDetalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idDetalle"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdCompra"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdCompra"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idProducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idProducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 225
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CANTIDAD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pedidos"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pedidos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'Formprueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 486)
        Me.Controls.Add(Me.DataTable1DataGridView)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Me.NfacturaTextBox)
        Me.Controls.Add(Fecha_compraLabel)
        Me.Controls.Add(Me.Fecha_compraDateTimePicker)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(Me.IdTipofacturaComboBox)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdPagoComboBox)
        Me.Controls.Add(IdProveedorLabel)
        Me.Controls.Add(Me.IdProveedorComboBox)
        Me.Controls.Add(Me.ComprasBindingNavigator)
        Me.Name = "Formprueba"
        Me.Text = "Formprueba"
        CType(Me.Db_sistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasBindingNavigator.ResumeLayout(False)
        Me.ComprasBindingNavigator.PerformLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_sistemaDataSet As db_sistemaDataSet
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As db_sistemaDataSetTableAdapters.comprasTableAdapter
    Friend WithEvents TableAdapterManager As db_sistemaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ComprasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NfacturaTextBox As TextBox
    Friend WithEvents Fecha_compraDateTimePicker As DateTimePicker
    Friend WithEvents IdTipofacturaComboBox As ComboBox
    Friend WithEvents IdPagoComboBox As ComboBox
    Friend WithEvents IdProveedorComboBox As ComboBox
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
