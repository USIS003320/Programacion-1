<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreciosPrductos
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
        Me.cbxProductos = New System.Windows.Forms.ComboBox()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbxProductos
        '
        Me.cbxProductos.FormattingEnabled = True
        Me.cbxProductos.Location = New System.Drawing.Point(120, 49)
        Me.cbxProductos.Name = "cbxProductos"
        Me.cbxProductos.Size = New System.Drawing.Size(121, 21)
        Me.cbxProductos.TabIndex = 0
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(56, 52)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(58, 13)
        Me.lblProductos.TabIndex = 1
        Me.lblProductos.Text = "Productos:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(263, 52)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(322, 49)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'frmPreciosPrductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 199)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.cbxProductos)
        Me.Name = "frmPreciosPrductos"
        Me.Text = "Precios de Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxProductos As ComboBox
    Friend WithEvents lblProductos As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
End Class
