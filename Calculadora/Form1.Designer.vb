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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblRespuestaRomano = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(75, 58)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(45, 13)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Capital: "
        '
        'lblRespuestaRomano
        '
        Me.lblRespuestaRomano.AutoSize = True
        Me.lblRespuestaRomano.Location = New System.Drawing.Point(232, 58)
        Me.lblRespuestaRomano.Name = "lblRespuestaRomano"
        Me.lblRespuestaRomano.Size = New System.Drawing.Size(99, 13)
        Me.lblRespuestaRomano.TabIndex = 1
        Me.lblRespuestaRomano.Text = "Numero Romano: ?"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(126, 55)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 2
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(93, 159)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(151, 52)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 262)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblRespuestaRomano)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "Form1"
        Me.Text = "Conversor numeros romanos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents lblRespuestaRomano As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents btnCalcular As Button
End Class
