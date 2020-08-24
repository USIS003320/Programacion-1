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
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.cbxEntrada3 = New System.Windows.Forms.ComboBox()
        Me.cbxSalida3 = New System.Windows.Forms.ComboBox()
        Me.lblRespuesta2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.btnCalcular2 = New System.Windows.Forms.Button()
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        Me.cbxEntrada4 = New System.Windows.Forms.ComboBox()
        Me.cbxSalida4 = New System.Windows.Forms.ComboBox()
        Me.lblRespuesta3 = New System.Windows.Forms.Label()
        Me.lblNum4 = New System.Windows.Forms.Label()
        Me.btnCalcular3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(846, 377)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(112, 35)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(808, 111)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(148, 26)
        Me.txtNum1.TabIndex = 1
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(1114, 326)
        Me.lblNum1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(71, 20)
        Me.lblNum1.TabIndex = 2
        Me.lblNum1.Text = "Longitud"
        '
        'cbxEntrada
        '
        Me.cbxEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada.FormattingEnabled = True
        Me.cbxEntrada.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxEntrada.Location = New System.Drawing.Point(670, 254)
        Me.cbxEntrada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxEntrada.Name = "cbxEntrada"
        Me.cbxEntrada.Size = New System.Drawing.Size(180, 28)
        Me.cbxEntrada.TabIndex = 3
        '
        'cbxSalida1
        '
        Me.cbxSalida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida1.FormattingEnabled = True
        Me.cbxSalida1.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas", "Pie", "Yarda", "Milla", "Decámetro", "Decímetro"})
        Me.cbxSalida1.Location = New System.Drawing.Point(952, 254)
        Me.cbxSalida1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxSalida1.Name = "cbxSalida1"
        Me.cbxSalida1.Size = New System.Drawing.Size(180, 28)
        Me.cbxSalida1.TabIndex = 4
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(854, 326)
        Me.lblRespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(104, 20)
        Me.lblRespuesta.TabIndex = 5
        Me.lblRespuesta.Text = "Respuesta: ?"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(424, 326)
        Me.lblNum2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(73, 20)
        Me.lblNum2.TabIndex = 6
        Me.lblNum2.Text = "Cantidad"
        '
        'lblRespuestaM
        '
        Me.lblRespuestaM.AutoSize = True
        Me.lblRespuestaM.Location = New System.Drawing.Point(194, 326)
        Me.lblRespuestaM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaM.Name = "lblRespuestaM"
        Me.lblRespuestaM.Size = New System.Drawing.Size(104, 20)
        Me.lblRespuestaM.TabIndex = 7
        Me.lblRespuestaM.Text = "Respuesta: ?"
        '
        'cbxEntrada2
        '
        Me.cbxEntrada2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada2.FormattingEnabled = True
        Me.cbxEntrada2.Items.AddRange(New Object() {"Dolar Estadounidense", "Colon Salvadoreño", "Colon Costarricense", "Euro", "Yen", "Quetzal Guatemalteco", "Sol Peruano", "Lempira", "Peso Mexicano", "Yuan"})
        Me.cbxEntrada2.Location = New System.Drawing.Point(46, 252)
        Me.cbxEntrada2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxEntrada2.Name = "cbxEntrada2"
        Me.cbxEntrada2.Size = New System.Drawing.Size(180, 28)
        Me.cbxEntrada2.TabIndex = 8
        '
        'cbxSalida2
        '
        Me.cbxSalida2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida2.FormattingEnabled = True
        Me.cbxSalida2.Items.AddRange(New Object() {"Dolar Estadounidense", "Colon Salvadoreño", "Colon Costarricense", "Euro", "Yen", "Quetzal Guatemalteco", "Sol Peruano", "Lempira", "Peso Mexicano", "Yuan"})
        Me.cbxSalida2.Location = New System.Drawing.Point(261, 252)
        Me.cbxSalida2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxSalida2.Name = "cbxSalida2"
        Me.cbxSalida2.Size = New System.Drawing.Size(180, 28)
        Me.cbxSalida2.TabIndex = 9
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(176, 111)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(148, 26)
        Me.txtNum2.TabIndex = 10
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(198, 395)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(112, 35)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(176, 526)
        Me.txtNum3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(148, 26)
        Me.txtNum3.TabIndex = 12
        '
        'cbxEntrada3
        '
        Me.cbxEntrada3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada3.FormattingEnabled = True
        Me.cbxEntrada3.Items.AddRange(New Object() {"Tonelada", "Tonelada cortas", "Kilonewton", "Kilogramo", "Hectogramo", "Onza", "Gramo", "Centigramo", "Miligramo", "Libra"})
        Me.cbxEntrada3.Location = New System.Drawing.Point(46, 624)
        Me.cbxEntrada3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxEntrada3.Name = "cbxEntrada3"
        Me.cbxEntrada3.Size = New System.Drawing.Size(180, 28)
        Me.cbxEntrada3.TabIndex = 13
        '
        'cbxSalida3
        '
        Me.cbxSalida3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida3.FormattingEnabled = True
        Me.cbxSalida3.Items.AddRange(New Object() {"Tonelada", "Tonelada cortas", "Kilonewton", "Kilogramo", "Hectogramo", "Onza", "Gramo", "Centigramo", "Miligramo", "Libra"})
        Me.cbxSalida3.Location = New System.Drawing.Point(261, 624)
        Me.cbxSalida3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxSalida3.Name = "cbxSalida3"
        Me.cbxSalida3.Size = New System.Drawing.Size(180, 28)
        Me.cbxSalida3.TabIndex = 14
        '
        'lblRespuesta2
        '
        Me.lblRespuesta2.AutoSize = True
        Me.lblRespuesta2.Location = New System.Drawing.Point(194, 713)
        Me.lblRespuesta2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuesta2.Name = "lblRespuesta2"
        Me.lblRespuesta2.Size = New System.Drawing.Size(104, 20)
        Me.lblRespuesta2.TabIndex = 15
        Me.lblRespuesta2.Text = "Respuesta: ?"
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Location = New System.Drawing.Point(424, 713)
        Me.lblNum3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(48, 20)
        Me.lblNum3.TabIndex = 16
        Me.lblNum3.Text = "Masa"
        '
        'btnCalcular2
        '
        Me.btnCalcular2.Location = New System.Drawing.Point(198, 784)
        Me.btnCalcular2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcular2.Name = "btnCalcular2"
        Me.btnCalcular2.Size = New System.Drawing.Size(112, 35)
        Me.btnCalcular2.TabIndex = 17
        Me.btnCalcular2.Text = "Calcular"
        Me.btnCalcular2.UseVisualStyleBackColor = True
        '
        'txtNum4
        '
        Me.txtNum4.Location = New System.Drawing.Point(808, 526)
        Me.txtNum4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(148, 26)
        Me.txtNum4.TabIndex = 18
        '
        'cbxEntrada4
        '
        Me.cbxEntrada4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada4.FormattingEnabled = True
        Me.cbxEntrada4.Items.AddRange(New Object() {"Hectolitro", "Decalitro", "Decímetro cubico", "Litro", "Decilitro", "Centilitro", "Centimetro cubico", "Mililitro", "Barril", "Galon"})
        Me.cbxEntrada4.Location = New System.Drawing.Point(670, 624)
        Me.cbxEntrada4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxEntrada4.Name = "cbxEntrada4"
        Me.cbxEntrada4.Size = New System.Drawing.Size(180, 28)
        Me.cbxEntrada4.TabIndex = 19
        '
        'cbxSalida4
        '
        Me.cbxSalida4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida4.FormattingEnabled = True
        Me.cbxSalida4.Items.AddRange(New Object() {"Hectolitro", "Decalitro", "Decimetro cubico", "Litro", "Decilitro", "Centilitro", "Centimetro cubico", "Mililitro", "Barril", "Galon"})
        Me.cbxSalida4.Location = New System.Drawing.Point(952, 624)
        Me.cbxSalida4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxSalida4.Name = "cbxSalida4"
        Me.cbxSalida4.Size = New System.Drawing.Size(180, 28)
        Me.cbxSalida4.TabIndex = 20
        '
        'lblRespuesta3
        '
        Me.lblRespuesta3.AutoSize = True
        Me.lblRespuesta3.Location = New System.Drawing.Point(854, 713)
        Me.lblRespuesta3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuesta3.Name = "lblRespuesta3"
        Me.lblRespuesta3.Size = New System.Drawing.Size(104, 20)
        Me.lblRespuesta3.TabIndex = 21
        Me.lblRespuesta3.Text = "Respuesta: ?"
        '
        'lblNum4
        '
        Me.lblNum4.AutoSize = True
        Me.lblNum4.Location = New System.Drawing.Point(1114, 713)
        Me.lblNum4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum4.Name = "lblNum4"
        Me.lblNum4.Size = New System.Drawing.Size(72, 20)
        Me.lblNum4.TabIndex = 22
        Me.lblNum4.Text = "Volumen"
        '
        'btnCalcular3
        '
        Me.btnCalcular3.Location = New System.Drawing.Point(846, 784)
        Me.btnCalcular3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcular3.Name = "btnCalcular3"
        Me.btnCalcular3.Size = New System.Drawing.Size(112, 35)
        Me.btnCalcular3.TabIndex = 23
        Me.btnCalcular3.Text = "Calcular"
        Me.btnCalcular3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 883)
        Me.Controls.Add(Me.btnCalcular3)
        Me.Controls.Add(Me.lblNum4)
        Me.Controls.Add(Me.lblRespuesta3)
        Me.Controls.Add(Me.cbxSalida4)
        Me.Controls.Add(Me.cbxEntrada4)
        Me.Controls.Add(Me.txtNum4)
        Me.Controls.Add(Me.btnCalcular2)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblRespuesta2)
        Me.Controls.Add(Me.cbxSalida3)
        Me.Controls.Add(Me.cbxEntrada3)
        Me.Controls.Add(Me.txtNum3)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents txtNum3 As TextBox
    Friend WithEvents cbxEntrada3 As ComboBox
    Friend WithEvents cbxSalida3 As ComboBox
    Friend WithEvents lblRespuesta2 As Label
    Friend WithEvents lblNum3 As Label
    Friend WithEvents btnCalcular2 As Button
    Friend WithEvents txtNum4 As TextBox
    Friend WithEvents cbxEntrada4 As ComboBox
    Friend WithEvents cbxSalida4 As ComboBox
    Friend WithEvents lblRespuesta3 As Label
    Friend WithEvents lblNum4 As Label
    Friend WithEvents btnCalcular3 As Button
End Class
