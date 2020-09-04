<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblcapital = New System.Windows.Forms.Label()
        Me.lblinteres = New System.Windows.Forms.Label()
        Me.lbltiempo = New System.Windows.Forms.Label()
        Me.lblinteressimple = New System.Windows.Forms.Label()
        Me.lblinterescompuesto = New System.Windows.Forms.Label()
        Me.txtcapital = New System.Windows.Forms.TextBox()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.txttiempo = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblcapital
        '
        Me.lblcapital.AutoSize = True
        Me.lblcapital.Location = New System.Drawing.Point(68, 56)
        Me.lblcapital.Name = "lblcapital"
        Me.lblcapital.Size = New System.Drawing.Size(42, 13)
        Me.lblcapital.TabIndex = 0
        Me.lblcapital.Text = "Capital:"
        '
        'lblinteres
        '
        Me.lblinteres.AutoSize = True
        Me.lblinteres.Location = New System.Drawing.Point(227, 56)
        Me.lblinteres.Name = "lblinteres"
        Me.lblinteres.Size = New System.Drawing.Size(42, 13)
        Me.lblinteres.TabIndex = 1
        Me.lblinteres.Text = "Interes:"
        '
        'lbltiempo
        '
        Me.lbltiempo.AutoSize = True
        Me.lbltiempo.Location = New System.Drawing.Point(390, 56)
        Me.lbltiempo.Name = "lbltiempo"
        Me.lbltiempo.Size = New System.Drawing.Size(69, 13)
        Me.lbltiempo.TabIndex = 2
        Me.lbltiempo.Text = "Tiempo(año):"
        '
        'lblinteressimple
        '
        Me.lblinteressimple.AutoSize = True
        Me.lblinteressimple.Location = New System.Drawing.Point(133, 130)
        Me.lblinteressimple.Name = "lblinteressimple"
        Me.lblinteressimple.Size = New System.Drawing.Size(85, 13)
        Me.lblinteressimple.TabIndex = 3
        Me.lblinteressimple.Text = "Interes Simple: ?"
        '
        'lblinterescompuesto
        '
        Me.lblinterescompuesto.AutoSize = True
        Me.lblinterescompuesto.Location = New System.Drawing.Point(308, 130)
        Me.lblinterescompuesto.Name = "lblinterescompuesto"
        Me.lblinterescompuesto.Size = New System.Drawing.Size(111, 13)
        Me.lblinterescompuesto.TabIndex = 4
        Me.lblinterescompuesto.Text = "Interes compuestos: ?"
        '
        'txtcapital
        '
        Me.txtcapital.Location = New System.Drawing.Point(113, 53)
        Me.txtcapital.Name = "txtcapital"
        Me.txtcapital.Size = New System.Drawing.Size(100, 20)
        Me.txtcapital.TabIndex = 5
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(275, 53)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(100, 20)
        Me.txtinteres.TabIndex = 6
        '
        'txttiempo
        '
        Me.txttiempo.Location = New System.Drawing.Point(465, 53)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(100, 20)
        Me.txttiempo.TabIndex = 7
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(189, 189)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(163, 55)
        Me.btncalcular.TabIndex = 8
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 365)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.txtcapital)
        Me.Controls.Add(Me.lblinterescompuesto)
        Me.Controls.Add(Me.lblinteressimple)
        Me.Controls.Add(Me.lbltiempo)
        Me.Controls.Add(Me.lblinteres)
        Me.Controls.Add(Me.lblcapital)
        Me.Name = "Form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcapital As Label
    Friend WithEvents lblinteres As Label
    Friend WithEvents lbltiempo As Label
    Friend WithEvents lblinteressimple As Label
    Friend WithEvents lblinterescompuesto As Label
    Friend WithEvents txtcapital As TextBox
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents txttiempo As TextBox
    Friend WithEvents btncalcular As Button
End Class
