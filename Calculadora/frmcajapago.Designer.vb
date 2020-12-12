<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcajapago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarcliente = New System.Windows.Forms.Button()
        Me.btnEliminarcliente = New System.Windows.Forms.Button()
        Me.btnModificarcliente = New System.Windows.Forms.Button()
        Me.btnAgregarcliente = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrocliente = New System.Windows.Forms.Label()
        Me.btnSiguientecliente = New System.Windows.Forms.Button()
        Me.btnUltimocliente = New System.Windows.Forms.Button()
        Me.btnAnteriorcliente = New System.Windows.Forms.Button()
        Me.btnPrimerocliente = New System.Windows.Forms.Button()
        Me.grbCajadepagos = New System.Windows.Forms.GroupBox()
        Me.txtformadepago = New System.Windows.Forms.TextBox()
        Me.txtsalidapago = New System.Windows.Forms.TextBox()
        Me.txtNombrecliente = New System.Windows.Forms.TextBox()
        Me.txtCodigocliente = New System.Windows.Forms.TextBox()
        Me.lblsalidapago = New System.Windows.Forms.Label()
        Me.lblCodigodecliente = New System.Windows.Forms.Label()
        Me.lbleentradadepago = New System.Windows.Forms.Label()
        Me.lblNombrecliente = New System.Windows.Forms.Label()
        Me.lblcajadepago = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbCajadepagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarcliente)
        Me.grbEdicion.Controls.Add(Me.btnEliminarcliente)
        Me.grbEdicion.Controls.Add(Me.btnModificarcliente)
        Me.grbEdicion.Controls.Add(Me.btnAgregarcliente)
        Me.grbEdicion.Location = New System.Drawing.Point(326, 428)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(280, 61)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarcliente
        '
        Me.btnBuscarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarcliente.Location = New System.Drawing.Point(216, 25)
        Me.btnBuscarcliente.Name = "btnBuscarcliente"
        Me.btnBuscarcliente.Size = New System.Drawing.Size(58, 23)
        Me.btnBuscarcliente.TabIndex = 3
        Me.btnBuscarcliente.Text = "Buscar"
        Me.btnBuscarcliente.UseVisualStyleBackColor = True
        '
        'btnEliminarcliente
        '
        Me.btnEliminarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarcliente.Location = New System.Drawing.Point(134, 25)
        Me.btnEliminarcliente.Name = "btnEliminarcliente"
        Me.btnEliminarcliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarcliente.TabIndex = 2
        Me.btnEliminarcliente.Text = "Eliminar"
        Me.btnEliminarcliente.UseVisualStyleBackColor = True
        '
        'btnModificarcliente
        '
        Me.btnModificarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarcliente.Location = New System.Drawing.Point(67, 25)
        Me.btnModificarcliente.Name = "btnModificarcliente"
        Me.btnModificarcliente.Size = New System.Drawing.Size(60, 23)
        Me.btnModificarcliente.TabIndex = 1
        Me.btnModificarcliente.Text = "Modificar"
        Me.btnModificarcliente.UseVisualStyleBackColor = True
        '
        'btnAgregarcliente
        '
        Me.btnAgregarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarcliente.Location = New System.Drawing.Point(7, 25)
        Me.btnAgregarcliente.Name = "btnAgregarcliente"
        Me.btnAgregarcliente.Size = New System.Drawing.Size(54, 23)
        Me.btnAgregarcliente.TabIndex = 0
        Me.btnAgregarcliente.Text = "Nuevo"
        Me.btnAgregarcliente.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrocliente)
        Me.grbNavegacion.Controls.Add(Me.btnSiguientecliente)
        Me.grbNavegacion.Controls.Add(Me.btnUltimocliente)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorcliente)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerocliente)
        Me.grbNavegacion.Location = New System.Drawing.Point(28, 428)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(292, 61)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrocliente
        '
        Me.lblRegistrocliente.AutoSize = True
        Me.lblRegistrocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrocliente.Location = New System.Drawing.Point(121, 25)
        Me.lblRegistrocliente.Name = "lblRegistrocliente"
        Me.lblRegistrocliente.Size = New System.Drawing.Size(42, 13)
        Me.lblRegistrocliente.TabIndex = 4
        Me.lblRegistrocliente.Text = "x de n"
        '
        'btnSiguientecliente
        '
        Me.btnSiguientecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientecliente.Location = New System.Drawing.Point(202, 20)
        Me.btnSiguientecliente.Name = "btnSiguientecliente"
        Me.btnSiguientecliente.Size = New System.Drawing.Size(28, 23)
        Me.btnSiguientecliente.TabIndex = 3
        Me.btnSiguientecliente.Text = ">"
        Me.btnSiguientecliente.UseVisualStyleBackColor = True
        '
        'btnUltimocliente
        '
        Me.btnUltimocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimocliente.Location = New System.Drawing.Point(236, 20)
        Me.btnUltimocliente.Name = "btnUltimocliente"
        Me.btnUltimocliente.Size = New System.Drawing.Size(33, 23)
        Me.btnUltimocliente.TabIndex = 2
        Me.btnUltimocliente.Text = ">l"
        Me.btnUltimocliente.UseVisualStyleBackColor = True
        '
        'btnAnteriorcliente
        '
        Me.btnAnteriorcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorcliente.Location = New System.Drawing.Point(60, 20)
        Me.btnAnteriorcliente.Name = "btnAnteriorcliente"
        Me.btnAnteriorcliente.Size = New System.Drawing.Size(28, 23)
        Me.btnAnteriorcliente.TabIndex = 1
        Me.btnAnteriorcliente.Text = "<"
        Me.btnAnteriorcliente.UseVisualStyleBackColor = True
        '
        'btnPrimerocliente
        '
        Me.btnPrimerocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerocliente.Location = New System.Drawing.Point(21, 20)
        Me.btnPrimerocliente.Name = "btnPrimerocliente"
        Me.btnPrimerocliente.Size = New System.Drawing.Size(33, 23)
        Me.btnPrimerocliente.TabIndex = 0
        Me.btnPrimerocliente.Text = "l<"
        Me.btnPrimerocliente.UseVisualStyleBackColor = True
        '
        'grbCajadepagos
        '
        Me.grbCajadepagos.Controls.Add(Me.txtformadepago)
        Me.grbCajadepagos.Controls.Add(Me.txtsalidapago)
        Me.grbCajadepagos.Controls.Add(Me.txtNombrecliente)
        Me.grbCajadepagos.Controls.Add(Me.txtCodigocliente)
        Me.grbCajadepagos.Controls.Add(Me.lblsalidapago)
        Me.grbCajadepagos.Controls.Add(Me.lblCodigodecliente)
        Me.grbCajadepagos.Controls.Add(Me.lbleentradadepago)
        Me.grbCajadepagos.Controls.Add(Me.lblNombrecliente)
        Me.grbCajadepagos.Controls.Add(Me.lblcajadepago)
        Me.grbCajadepagos.Enabled = False
        Me.grbCajadepagos.Location = New System.Drawing.Point(28, 12)
        Me.grbCajadepagos.Name = "grbCajadepagos"
        Me.grbCajadepagos.Size = New System.Drawing.Size(584, 410)
        Me.grbCajadepagos.TabIndex = 3
        Me.grbCajadepagos.TabStop = False
        Me.grbCajadepagos.Text = "Cajas de pagos"
        '
        'txtformadepago
        '
        Me.txtformadepago.Location = New System.Drawing.Point(119, 254)
        Me.txtformadepago.Name = "txtformadepago"
        Me.txtformadepago.Size = New System.Drawing.Size(123, 20)
        Me.txtformadepago.TabIndex = 9
        '
        'txtsalidapago
        '
        Me.txtsalidapago.Location = New System.Drawing.Point(120, 325)
        Me.txtsalidapago.Name = "txtsalidapago"
        Me.txtsalidapago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsalidapago.Size = New System.Drawing.Size(164, 20)
        Me.txtsalidapago.TabIndex = 8
        '
        'txtNombrecliente
        '
        Me.txtNombrecliente.Location = New System.Drawing.Point(124, 165)
        Me.txtNombrecliente.Name = "txtNombrecliente"
        Me.txtNombrecliente.Size = New System.Drawing.Size(286, 20)
        Me.txtNombrecliente.TabIndex = 6
        '
        'txtCodigocliente
        '
        Me.txtCodigocliente.Location = New System.Drawing.Point(129, 72)
        Me.txtCodigocliente.Name = "txtCodigocliente"
        Me.txtCodigocliente.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigocliente.TabIndex = 5
        '
        'lblsalidapago
        '
        Me.lblsalidapago.AutoSize = True
        Me.lblsalidapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalidapago.Location = New System.Drawing.Point(18, 328)
        Me.lblsalidapago.Name = "lblsalidapago"
        Me.lblsalidapago.Size = New System.Drawing.Size(96, 13)
        Me.lblsalidapago.TabIndex = 4
        Me.lblsalidapago.Text = "Salida de pago:"
        '
        'lblCodigodecliente
        '
        Me.lblCodigodecliente.AutoSize = True
        Me.lblCodigodecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigodecliente.Location = New System.Drawing.Point(10, 72)
        Me.lblCodigodecliente.Name = "lblCodigodecliente"
        Me.lblCodigodecliente.Size = New System.Drawing.Size(113, 13)
        Me.lblCodigodecliente.TabIndex = 3
        Me.lblCodigodecliente.Text = "Codigo del cliente:"
        '
        'lbleentradadepago
        '
        Me.lbleentradadepago.AutoSize = True
        Me.lbleentradadepago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleentradadepago.Location = New System.Drawing.Point(18, 257)
        Me.lbleentradadepago.Name = "lbleentradadepago"
        Me.lbleentradadepago.Size = New System.Drawing.Size(95, 13)
        Me.lbleentradadepago.TabIndex = 2
        Me.lbleentradadepago.Text = "Forma de pago:"
        '
        'lblNombrecliente
        '
        Me.lblNombrecliente.AutoSize = True
        Me.lblNombrecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrecliente.Location = New System.Drawing.Point(6, 168)
        Me.lblNombrecliente.Name = "lblNombrecliente"
        Me.lblNombrecliente.Size = New System.Drawing.Size(117, 13)
        Me.lblNombrecliente.TabIndex = 1
        Me.lblNombrecliente.Text = "Nombre del cliente:"
        '
        'lblcajadepago
        '
        Me.lblcajadepago.AutoSize = True
        Me.lblcajadepago.Location = New System.Drawing.Point(34, 27)
        Me.lblcajadepago.Name = "lblcajadepago"
        Me.lblcajadepago.Size = New System.Drawing.Size(70, 13)
        Me.lblcajadepago.TabIndex = 0
        Me.lblcajadepago.Text = "Caja de pago"
        '
        'frmcajapago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 504)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbCajadepagos)
        Me.Name = "frmcajapago"
        Me.Text = "Caja de pagos"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbCajadepagos.ResumeLayout(False)
        Me.grbCajadepagos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarcliente As Button
    Friend WithEvents btnEliminarcliente As Button
    Friend WithEvents btnModificarcliente As Button
    Friend WithEvents btnAgregarcliente As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrocliente As Label
    Friend WithEvents btnSiguientecliente As Button
    Friend WithEvents btnUltimocliente As Button
    Friend WithEvents btnAnteriorcliente As Button
    Friend WithEvents btnPrimerocliente As Button
    Friend WithEvents grbCajadepagos As GroupBox
    Friend WithEvents txtsalidapago As TextBox
    Friend WithEvents txtNombrecliente As TextBox
    Friend WithEvents txtCodigocliente As TextBox
    Friend WithEvents lblsalidapago As Label
    Friend WithEvents lblCodigodecliente As Label
    Friend WithEvents lbleentradadepago As Label
    Friend WithEvents lblNombrecliente As Label
    Friend WithEvents lblcajadepago As Label
    Friend WithEvents txtformadepago As TextBox
End Class
