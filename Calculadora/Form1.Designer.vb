<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optDivision = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optResiduo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(175, 60)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(41, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Tag = ""
        Me.lblnum1.Text = "Num 1:"
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(381, 60)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(41, 13)
        Me.lblnum2.TabIndex = 1
        Me.lblnum2.Text = "Num 2:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(289, 211)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(508, 60)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblrespuesta.TabIndex = 3
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(220, 57)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(46, 20)
        Me.txtnum1.TabIndex = 4
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(426, 57)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(48, 20)
        Me.txtnum2.TabIndex = 5
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Location = New System.Drawing.Point(271, 36)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(31, 17)
        Me.optSuma.TabIndex = 6
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(271, 60)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(28, 17)
        Me.optResta.TabIndex = 7
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(271, 83)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicar.TabIndex = 8
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optDivision
        '
        Me.optDivision.AutoSize = True
        Me.optDivision.Location = New System.Drawing.Point(271, 107)
        Me.optDivision.Name = "optDivision"
        Me.optDivision.Size = New System.Drawing.Size(30, 17)
        Me.optDivision.TabIndex = 9
        Me.optDivision.TabStop = True
        Me.optDivision.Text = "/"
        Me.optDivision.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(271, 131)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(75, 17)
        Me.optPorcentaje.TabIndex = 10
        Me.optPorcentaje.TabStop = True
        Me.optPorcentaje.Text = "porcentaje"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(271, 155)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(31, 17)
        Me.optExponenciacion.TabIndex = 11
        Me.optExponenciacion.TabStop = True
        Me.optExponenciacion.Tag = ""
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optResiduo
        '
        Me.optResiduo.AutoSize = True
        Me.optResiduo.Location = New System.Drawing.Point(271, 179)
        Me.optResiduo.Name = "optResiduo"
        Me.optResiduo.Size = New System.Drawing.Size(59, 17)
        Me.optResiduo.TabIndex = 12
        Me.optResiduo.TabStop = True
        Me.optResiduo.Text = "residuo"
        Me.optResiduo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.optResiduo)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optDivision)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form1"
        Me.Text = "Calculadora basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum1 As Label
    Friend WithEvents lblnum2 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optDivision As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optResiduo As RadioButton
End Class
