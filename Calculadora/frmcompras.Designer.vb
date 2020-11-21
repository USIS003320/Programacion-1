<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcompras
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
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim Fecha_compraLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim IdProveedorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcompras))
        Me.ComprasBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComprasBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NfacturaTextBox1 = New System.Windows.Forms.TextBox()
        Me.Fecha_compraDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.IdTipofacturaComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IdPagoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IdProveedorComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DcomprasproductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcomprasproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sistemaDataSet1 = New Calculadora.db_sistemaDataSet()
        Me.ComprasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter1 = New Calculadora.db_sistemaDataSetTableAdapters.comprasTableAdapter()
        Me.TableAdapterManager1 = New Calculadora.db_sistemaDataSetTableAdapters.TableAdapterManager()
        NfacturaLabel = New System.Windows.Forms.Label()
        Fecha_compraLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        IdProveedorLabel = New System.Windows.Forms.Label()
        CType(Me.ComprasBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.DcomprasproductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(526, 15)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(66, 13)
        NfacturaLabel.TabIndex = 3
        NfacturaLabel.Text = "Factura No.:"
        '
        'Fecha_compraLabel
        '
        Fecha_compraLabel.AutoSize = True
        Fecha_compraLabel.Location = New System.Drawing.Point(31, 81)
        Fecha_compraLabel.Name = "Fecha_compraLabel"
        Fecha_compraLabel.Size = New System.Drawing.Size(75, 13)
        Fecha_compraLabel.TabIndex = 5
        Fecha_compraLabel.Text = "fecha compra:"
        AddHandler Fecha_compraLabel.Click, AddressOf Me.fecha_compraLabel_Click
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(362, 81)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(67, 13)
        IdTipofacturaLabel.TabIndex = 9
        IdTipofacturaLabel.Text = "Tipo factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(572, 81)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(67, 13)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Forma Pago:"
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.Location = New System.Drawing.Point(31, 45)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(59, 13)
        IdProveedorLabel.TabIndex = 13
        IdProveedorLabel.Text = "Proveedor:"
        AddHandler IdProveedorLabel.Click, AddressOf Me.IdProveedorLabel_Click
        '
        'ComprasBindingSource1BindingNavigator
        '
        Me.ComprasBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.ComprasBindingSource1BindingNavigator.BindingSource = Me.ComprasBindingSource1
        Me.ComprasBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.ComprasBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.ComprasBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.ComprasBindingSource1BindingNavigatorSaveItem})
        Me.ComprasBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComprasBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.ComprasBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.ComprasBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.ComprasBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.ComprasBindingSource1BindingNavigator.Name = "ComprasBindingSource1BindingNavigator"
        Me.ComprasBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.ComprasBindingSource1BindingNavigator.Size = New System.Drawing.Size(811, 25)
        Me.ComprasBindingSource1BindingNavigator.TabIndex = 0
        Me.ComprasBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Agregar nuevo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Mover siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ComprasBindingSource1BindingNavigatorSaveItem
        '
        Me.ComprasBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComprasBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("ComprasBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComprasBindingSource1BindingNavigatorSaveItem.Name = "ComprasBindingSource1BindingNavigatorSaveItem"
        Me.ComprasBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ComprasBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NfacturaTextBox1
        '
        Me.NfacturaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource1, "nfactura", True))
        Me.NfacturaTextBox1.Location = New System.Drawing.Point(598, 12)
        Me.NfacturaTextBox1.Name = "NfacturaTextBox1"
        Me.NfacturaTextBox1.Size = New System.Drawing.Size(166, 20)
        Me.NfacturaTextBox1.TabIndex = 4
        '
        'Fecha_compraDateTimePicker1
        '
        Me.Fecha_compraDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource1, "fecha_compra", True))
        Me.Fecha_compraDateTimePicker1.Location = New System.Drawing.Point(112, 80)
        Me.Fecha_compraDateTimePicker1.Name = "Fecha_compraDateTimePicker1"
        Me.Fecha_compraDateTimePicker1.Size = New System.Drawing.Size(244, 20)
        Me.Fecha_compraDateTimePicker1.TabIndex = 6
        '
        'IdTipofacturaComboBox1
        '
        Me.IdTipofacturaComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource1, "idTipofactura", True))
        Me.IdTipofacturaComboBox1.FormattingEnabled = True
        Me.IdTipofacturaComboBox1.Location = New System.Drawing.Point(435, 78)
        Me.IdTipofacturaComboBox1.Name = "IdTipofacturaComboBox1"
        Me.IdTipofacturaComboBox1.Size = New System.Drawing.Size(131, 21)
        Me.IdTipofacturaComboBox1.TabIndex = 10
        '
        'IdPagoComboBox1
        '
        Me.IdPagoComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource1, "idPago", True))
        Me.IdPagoComboBox1.FormattingEnabled = True
        Me.IdPagoComboBox1.Location = New System.Drawing.Point(645, 78)
        Me.IdPagoComboBox1.Name = "IdPagoComboBox1"
        Me.IdPagoComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.IdPagoComboBox1.TabIndex = 12
        '
        'IdProveedorComboBox1
        '
        Me.IdProveedorComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource1, "IdProveedor", True))
        Me.IdProveedorComboBox1.FormattingEnabled = True
        Me.IdProveedorComboBox1.Location = New System.Drawing.Point(96, 42)
        Me.IdProveedorComboBox1.Name = "IdProveedorComboBox1"
        Me.IdProveedorComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.IdProveedorComboBox1.TabIndex = 14
        '
        'DcomprasproductosDataGridView
        '
        Me.DcomprasproductosDataGridView.AllowUserToAddRows = False
        Me.DcomprasproductosDataGridView.AllowUserToDeleteRows = False
        Me.DcomprasproductosDataGridView.AutoGenerateColumns = False
        Me.DcomprasproductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DcomprasproductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8})
        Me.DcomprasproductosDataGridView.DataSource = Me.DcomprasproductosBindingSource
        Me.DcomprasproductosDataGridView.Location = New System.Drawing.Point(34, 106)
        Me.DcomprasproductosDataGridView.Name = "DcomprasproductosDataGridView"
        Me.DcomprasproductosDataGridView.ReadOnly = True
        Me.DcomprasproductosDataGridView.Size = New System.Drawing.Size(744, 402)
        Me.DcomprasproductosDataGridView.TabIndex = 14
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
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CANTIDAD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "medidas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MEDIDAS"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pedidos"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pedidos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DcomprasproductosBindingSource
        '
        Me.DcomprasproductosBindingSource.DataMember = "dcomprasproductos"
        Me.DcomprasproductosBindingSource.DataSource = Me.Db_sistemaDataSet1
        '
        'Db_sistemaDataSet1
        '
        Me.Db_sistemaDataSet1.DataSetName = "db_sistemaDataSet"
        Me.Db_sistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource1
        '
        Me.ComprasBindingSource1.DataMember = "compras"
        Me.ComprasBindingSource1.DataSource = Me.Db_sistemaDataSet1
        '
        'ComprasTableAdapter1
        '
        Me.ComprasTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ArqueoTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager1.comprasTableAdapter = Me.ComprasTableAdapter1
        Me.TableAdapterManager1.dcomprasTableAdapter = Nothing
        Me.TableAdapterManager1.empleadosTableAdapter = Nothing
        Me.TableAdapterManager1.GananciasTableAdapter = Nothing
        Me.TableAdapterManager1.pagosTableAdapter = Nothing
        Me.TableAdapterManager1.ProductosTableAdapter = Nothing
        Me.TableAdapterManager1.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.tipofacturaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Calculadora.db_sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmcompras
        '
        Me.ClientSize = New System.Drawing.Size(811, 553)
        Me.Controls.Add(Me.DcomprasproductosDataGridView)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Me.NfacturaTextBox1)
        Me.Controls.Add(Fecha_compraLabel)
        Me.Controls.Add(Me.Fecha_compraDateTimePicker1)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(Me.IdTipofacturaComboBox1)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdPagoComboBox1)
        Me.Controls.Add(IdProveedorLabel)
        Me.Controls.Add(Me.IdProveedorComboBox1)
        Me.Controls.Add(Me.ComprasBindingSource1BindingNavigator)
        Me.Name = "frmcompras"
        Me.Text = "Formulario Compras"
        CType(Me.ComprasBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasBindingSource1BindingNavigator.ResumeLayout(False)
        Me.ComprasBindingSource1BindingNavigator.PerformLayout()
        CType(Me.DcomprasproductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub IdProveedorLabel_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub fecha_compraLabel_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
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
    Friend WithEvents Fecha_hora_registroDateTimePicker As DateTimePicker
    Friend WithEvents IdTipofacturaComboBox As ComboBox
    Friend WithEvents IdPagoComboBox As ComboBox
    Friend WithEvents IdProveedorComboBox As ComboBox
    Friend WithEvents Db_sistemaDataSet1 As db_sistemaDataSet
    Friend WithEvents ComprasBindingSource1 As BindingSource
    Friend WithEvents ComprasTableAdapter1 As db_sistemaDataSetTableAdapters.comprasTableAdapter
    Friend WithEvents TableAdapterManager1 As db_sistemaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ComprasBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NfacturaTextBox1 As TextBox
    Friend WithEvents Fecha_compraDateTimePicker1 As DateTimePicker
    Friend WithEvents IdTipofacturaComboBox1 As ComboBox
    Friend WithEvents IdPagoComboBox1 As ComboBox
    Friend WithEvents IdProveedorComboBox1 As ComboBox
    Friend WithEvents DcomprasproductosBindingSource As BindingSource
    Friend WithEvents DcomprasproductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
