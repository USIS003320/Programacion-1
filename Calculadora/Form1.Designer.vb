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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cbxEntrada = New System.Windows.Forms.ComboBox()
        Me.cbxSalida = New System.Windows.Forms.ComboBox()
        Me.txtrespuesta2 = New System.Windows.Forms.TextBox()
        Me.lblRespuesta2 = New System.Windows.Forms.Label()
        Me.txtCantidad2 = New System.Windows.Forms.TextBox()
        Me.lblCantidad2 = New System.Windows.Forms.Label()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.lblUnidad2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(46, 34)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(708, 462)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txtUnidades)
        Me.TabPage1.Controls.Add(Me.lblUnidad2)
        Me.TabPage1.Controls.Add(Me.txtCantidad2)
        Me.TabPage1.Controls.Add(Me.lblCantidad2)
        Me.TabPage1.Controls.Add(Me.txtrespuesta2)
        Me.TabPage1.Controls.Add(Me.lblRespuesta2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(700, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Universal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblA)
        Me.TabPage2.Controls.Add(Me.lblDe)
        Me.TabPage2.Controls.Add(Me.btnConvertir)
        Me.TabPage2.Controls.Add(Me.txtCantidad)
        Me.TabPage2.Controls.Add(Me.lblRespuesta)
        Me.TabPage2.Controls.Add(Me.lblCantidad)
        Me.TabPage2.Controls.Add(Me.cbxEntrada)
        Me.TabPage2.Controls.Add(Me.cbxSalida)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(700, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "conversor Area"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(270, 186)
        Me.lblA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(24, 20)
        Me.lblA.TabIndex = 7
        Me.lblA.Text = "A:"
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(27, 186)
        Me.lblDe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(34, 20)
        Me.lblDe.TabIndex = 6
        Me.lblDe.Text = "De:"
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(196, 269)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(160, 57)
        Me.btnConvertir.TabIndex = 5
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(146, 46)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(148, 26)
        Me.txtCantidad.TabIndex = 4
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(304, 51)
        Me.lblRespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(104, 20)
        Me.lblRespuesta.TabIndex = 3
        Me.lblRespuesta.Text = "Respuesta: ?"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(58, 51)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(77, 20)
        Me.lblCantidad.TabIndex = 2
        Me.lblCantidad.Text = "Cantidad:"
        '
        'cbxEntrada
        '
        Me.cbxEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntrada.FormattingEnabled = True
        Me.cbxEntrada.Items.AddRange(New Object() {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectarea"})
        Me.cbxEntrada.Location = New System.Drawing.Point(72, 182)
        Me.cbxEntrada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxEntrada.Name = "cbxEntrada"
        Me.cbxEntrada.Size = New System.Drawing.Size(180, 28)
        Me.cbxEntrada.TabIndex = 1
        '
        'cbxSalida
        '
        Me.cbxSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSalida.FormattingEnabled = True
        Me.cbxSalida.Items.AddRange(New Object() {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectarea"})
        Me.cbxSalida.Location = New System.Drawing.Point(309, 182)
        Me.cbxSalida.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxSalida.Name = "cbxSalida"
        Me.cbxSalida.Size = New System.Drawing.Size(180, 28)
        Me.cbxSalida.TabIndex = 0
        '
        'txtrespuesta2
        '
        Me.txtrespuesta2.Location = New System.Drawing.Point(147, 166)
        Me.txtrespuesta2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtrespuesta2.Name = "txtrespuesta2"
        Me.txtrespuesta2.Size = New System.Drawing.Size(148, 26)
        Me.txtrespuesta2.TabIndex = 6
        '
        'lblRespuesta2
        '
        Me.lblRespuesta2.AutoSize = True
        Me.lblRespuesta2.Location = New System.Drawing.Point(45, 172)
        Me.lblRespuesta2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuesta2.Name = "lblRespuesta2"
        Me.lblRespuesta2.Size = New System.Drawing.Size(91, 20)
        Me.lblRespuesta2.TabIndex = 5
        Me.lblRespuesta2.Text = "Respuesta:"
        '
        'txtCantidad2
        '
        Me.txtCantidad2.Location = New System.Drawing.Point(147, 70)
        Me.txtCantidad2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCantidad2.Name = "txtCantidad2"
        Me.txtCantidad2.Size = New System.Drawing.Size(148, 26)
        Me.txtCantidad2.TabIndex = 8
        '
        'lblCantidad2
        '
        Me.lblCantidad2.AutoSize = True
        Me.lblCantidad2.Location = New System.Drawing.Point(59, 75)
        Me.lblCantidad2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidad2.Name = "lblCantidad2"
        Me.lblCantidad2.Size = New System.Drawing.Size(77, 20)
        Me.lblCantidad2.TabIndex = 7
        Me.lblCantidad2.Text = "Cantidad:"
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(448, 70)
        Me.txtUnidades.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(148, 26)
        Me.txtUnidades.TabIndex = 10
        '
        'lblUnidad2
        '
        Me.lblUnidad2.AutoSize = True
        Me.lblUnidad2.Location = New System.Drawing.Point(360, 75)
        Me.lblUnidad2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnidad2.Name = "lblUnidad2"
        Me.lblUnidad2.Size = New System.Drawing.Size(64, 20)
        Me.lblUnidad2.TabIndex = 9
        Me.lblUnidad2.Text = "Unidad:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 293)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 57)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 585)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Parcial 1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnConvertir As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents cbxEntrada As ComboBox
    Friend WithEvents cbxSalida As ComboBox
    Friend WithEvents lblA As Label
    Friend WithEvents lblDe As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents lblUnidad2 As Label
    Friend WithEvents txtCantidad2 As TextBox
    Friend WithEvents lblCantidad2 As Label
    Friend WithEvents txtrespuesta2 As TextBox
    Friend WithEvents lblRespuesta2 As Label
End Class
