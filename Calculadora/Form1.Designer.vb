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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.cbxEntrada = New System.Windows.Forms.ComboBox()
        Me.cbxSalida1 = New System.Windows.Forms.ComboBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblRespuestaM = New System.Windows.Forms.Label()
        Me.cbxEntrada2 = New System.Windows.Forms.ComboBox()
        Me.cbxSalida2 = New System.Windows.Forms.ComboBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(564, 245)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(539, 72)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 1
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(743, 212)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(48, 13)
        Me.lblNum1.TabIndex = 2
        Me.lblNum1.Text = "Longitud"
        '
        'cbxEntrada
        '
        Me.cbxEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada.FormattingEnabled = True
        Me.cbxEntrada.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxEntrada.Location = New System.Drawing.Point(447, 165)
        Me.cbxEntrada.Name = "cbxEntrada"
        Me.cbxEntrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxEntrada.TabIndex = 3
        '
        'cbxSalida1
        '
        Me.cbxSalida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida1.FormattingEnabled = True
        Me.cbxSalida1.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxSalida1.Location = New System.Drawing.Point(635, 165)
        Me.cbxSalida1.Name = "cbxSalida1"
        Me.cbxSalida1.Size = New System.Drawing.Size(121, 21)
        Me.cbxSalida1.TabIndex = 4
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(569, 212)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblRespuesta.TabIndex = 5
        Me.lblRespuesta.Text = "Respuesta: ?"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(283, 212)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(49, 13)
        Me.lblNum2.TabIndex = 6
        Me.lblNum2.Text = "Cantidad"
        '
        'lblRespuestaM
        '
        Me.lblRespuestaM.AutoSize = True
        Me.lblRespuestaM.Location = New System.Drawing.Point(129, 212)
        Me.lblRespuestaM.Name = "lblRespuestaM"
        Me.lblRespuestaM.Size = New System.Drawing.Size(70, 13)
        Me.lblRespuestaM.TabIndex = 7
        Me.lblRespuestaM.Text = "Respuesta: ?"
        '
        'cbxEntrada2
        '
        Me.cbxEntrada2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada2.FormattingEnabled = True
        Me.cbxEntrada2.Items.AddRange(New Object() {"Dolar Estadounidense", "Colon Salvadoreño", "Colon Costarricense", "Euro", "Yen", "Quetzal Guatemalteco", "Sol Peruano", "Lempira", "Peso Mexicano", "Yuan"})
        Me.cbxEntrada2.Location = New System.Drawing.Point(31, 164)
        Me.cbxEntrada2.Name = "cbxEntrada2"
        Me.cbxEntrada2.Size = New System.Drawing.Size(121, 21)
        Me.cbxEntrada2.TabIndex = 8
        '
        'cbxSalida2
        '
        Me.cbxSalida2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida2.FormattingEnabled = True
        Me.cbxSalida2.Items.AddRange(New Object() {"Dolar Estadounidense", "Colon Salvadoreño", "Colon Costarricense", "Euro", "Yen", "Quetzal Guatemalteco", "Sol Peruano", "Lempira", "Peso Mexicano", "Yuan"})
        Me.cbxSalida2.Location = New System.Drawing.Point(174, 164)
        Me.cbxSalida2.Name = "cbxSalida2"
        Me.cbxSalida2.Size = New System.Drawing.Size(121, 21)
        Me.cbxSalida2.TabIndex = 9
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(117, 72)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 10
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(132, 257)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 364)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.cbxSalida2)
        Me.Controls.Add(Me.cbxEntrada2)
        Me.Controls.Add(Me.lblRespuestaM)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.cbxSalida1)
        Me.Controls.Add(Me.cbxEntrada)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "Form1"
        Me.Text = "Conversores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents cbxEntrada As ComboBox
    Friend WithEvents cbxSalida1 As ComboBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblRespuestaM As Label
    Friend WithEvents cbxEntrada2 As ComboBox
    Friend WithEvents cbxSalida2 As ComboBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnCalcular As Button
End Class
