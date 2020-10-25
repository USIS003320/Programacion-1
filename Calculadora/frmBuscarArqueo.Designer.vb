<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarArque
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
        Me.btnCancelarArqueo = New System.Windows.Forms.Button()
        Me.btnSeleccionarArqueo = New System.Windows.Forms.Button()
        Me.grdBuscarArqueo = New System.Windows.Forms.DataGridView()
        Me.txtBuscarArqueo = New System.Windows.Forms.TextBox()
        Me.lblBuscarArqueo = New System.Windows.Forms.Label()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarArqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarArqueo
        '
        Me.btnCancelarArqueo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarArqueo.Location = New System.Drawing.Point(903, 784)
        Me.btnCancelarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelarArqueo.Name = "btnCancelarArqueo"
        Me.btnCancelarArqueo.Size = New System.Drawing.Size(318, 62)
        Me.btnCancelarArqueo.TabIndex = 9
        Me.btnCancelarArqueo.Text = "Cancelar"
        Me.btnCancelarArqueo.UseVisualStyleBackColor = True
        '
        'btnSeleccionarArqueo
        '
        Me.btnSeleccionarArqueo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarArqueo.Location = New System.Drawing.Point(553, 784)
        Me.btnSeleccionarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSeleccionarArqueo.Name = "btnSeleccionarArqueo"
        Me.btnSeleccionarArqueo.Size = New System.Drawing.Size(318, 62)
        Me.btnSeleccionarArqueo.TabIndex = 8
        Me.btnSeleccionarArqueo.Text = "Seleccionar Arqueo"
        Me.btnSeleccionarArqueo.UseVisualStyleBackColor = True
        '
        'grdBuscarArqueo
        '
        Me.grdBuscarArqueo.AllowUserToAddRows = False
        Me.grdBuscarArqueo.AllowUserToDeleteRows = False
        Me.grdBuscarArqueo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarArqueo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarArqueo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado})
        Me.grdBuscarArqueo.Location = New System.Drawing.Point(29, 87)
        Me.grdBuscarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdBuscarArqueo.Name = "grdBuscarArqueo"
        Me.grdBuscarArqueo.ReadOnly = True
        Me.grdBuscarArqueo.RowHeadersWidth = 62
        Me.grdBuscarArqueo.Size = New System.Drawing.Size(1191, 674)
        Me.grdBuscarArqueo.TabIndex = 7
        '
        'txtBuscarArqueo
        '
        Me.txtBuscarArqueo.Location = New System.Drawing.Point(124, 18)
        Me.txtBuscarArqueo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBuscarArqueo.Name = "txtBuscarArqueo"
        Me.txtBuscarArqueo.Size = New System.Drawing.Size(888, 26)
        Me.txtBuscarArqueo.TabIndex = 6
        '
        'lblBuscarArqueo
        '
        Me.lblBuscarArqueo.AutoSize = True
        Me.lblBuscarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarArqueo.Location = New System.Drawing.Point(25, 24)
        Me.lblBuscarArqueo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarArqueo.Name = "lblBuscarArqueo"
        Me.lblBuscarArqueo.Size = New System.Drawing.Size(86, 25)
        Me.lblBuscarArqueo.TabIndex = 5
        Me.lblBuscarArqueo.Text = "Buscar:"
        '
        'idEmpleado
        '
        Me.idEmpleado.DataPropertyName = "idArqueo"
        Me.idEmpleado.HeaderText = "ID"
        Me.idEmpleado.MinimumWidth = 8
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Visible = False
        Me.idEmpleado.Width = 150
        '
        'frmBuscarArque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 865)
        Me.Controls.Add(Me.btnCancelarArqueo)
        Me.Controls.Add(Me.btnSeleccionarArqueo)
        Me.Controls.Add(Me.grdBuscarArqueo)
        Me.Controls.Add(Me.txtBuscarArqueo)
        Me.Controls.Add(Me.lblBuscarArqueo)
        Me.Name = "frmBuscarArque"
        Me.Text = "Busqueda de registro de Arqueo"
        CType(Me.grdBuscarArqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarArqueo As Button
    Friend WithEvents btnSeleccionarArqueo As Button
    Friend WithEvents grdBuscarArqueo As DataGridView
    Friend WithEvents txtBuscarArqueo As TextBox
    Friend WithEvents lblBuscarArqueo As Label
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
End Class
