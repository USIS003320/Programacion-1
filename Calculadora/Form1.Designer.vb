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
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btnconvertir = New System.Windows.Forms.Button()
        Me.lblde = New System.Windows.Forms.Label()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.cboa = New System.Windows.Forms.ComboBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(157, 30)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(31, 13)
        Me.lbltipo.TabIndex = 0
        Me.lbltipo.Text = "Tipo:"
        '
        'btnconvertir
        '
        Me.btnconvertir.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvertir.Location = New System.Drawing.Point(128, 242)
        Me.btnconvertir.Name = "btnconvertir"
        Me.btnconvertir.Size = New System.Drawing.Size(170, 38)
        Me.btnconvertir.TabIndex = 1
        Me.btnconvertir.Text = "Convertir"
        Me.btnconvertir.UseVisualStyleBackColor = True
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.Location = New System.Drawing.Point(63, 132)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(24, 13)
        Me.lblde.TabIndex = 2
        Me.lblde.Text = "De:"
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(220, 132)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(17, 13)
        Me.lbla.TabIndex = 3
        Me.lbla.Text = "A:"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(377, 131)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblcantidad.TabIndex = 4
        Me.lblcantidad.Text = "Cantidad:"
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(194, 27)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(121, 21)
        Me.cbotipo.TabIndex = 5
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuesta.Location = New System.Drawing.Point(361, 250)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(124, 23)
        Me.lblrespuesta.TabIndex = 6
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'cbode
        '
        Me.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbode.FormattingEnabled = True
        Me.cbode.Location = New System.Drawing.Point(93, 128)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(121, 21)
        Me.cbode.TabIndex = 7
        '
        'cboa
        '
        Me.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboa.FormattingEnabled = True
        Me.cboa.Location = New System.Drawing.Point(243, 128)
        Me.cboa.Name = "cboa"
        Me.cboa.Size = New System.Drawing.Size(121, 21)
        Me.cboa.TabIndex = 8
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(435, 128)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 380)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cboa)
        Me.Controls.Add(Me.cbode)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.lblde)
        Me.Controls.Add(Me.btnconvertir)
        Me.Controls.Add(Me.lbltipo)
        Me.Name = "Form1"
        Me.Text = "Conversores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltipo As Label
    Friend WithEvents btnconvertir As Button
    Friend WithEvents lblde As Label
    Friend WithEvents lbla As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents cbotipo As ComboBox
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents cbode As ComboBox
    Friend WithEvents cboa As ComboBox
    Friend WithEvents txtcantidad As TextBox
End Class
