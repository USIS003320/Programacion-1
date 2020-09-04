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
        Me.cboDepto = New System.Windows.Forms.ComboBox()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.lblMun = New System.Windows.Forms.Label()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboDepto
        '
        Me.cboDepto.FormattingEnabled = True
        Me.cboDepto.Location = New System.Drawing.Point(83, 70)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Size = New System.Drawing.Size(121, 21)
        Me.cboDepto.TabIndex = 0
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Location = New System.Drawing.Point(38, 73)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(39, 13)
        Me.lblDepto.TabIndex = 1
        Me.lblDepto.Text = "Depto:"
        '
        'lblMun
        '
        Me.lblMun.AutoSize = True
        Me.lblMun.Location = New System.Drawing.Point(223, 73)
        Me.lblMun.Name = "lblMun"
        Me.lblMun.Size = New System.Drawing.Size(31, 13)
        Me.lblMun.TabIndex = 2
        Me.lblMun.Text = "Mun:"
        '
        'cboMun
        '
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(260, 70)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(121, 21)
        Me.cboMun.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 169)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.lblMun)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.cboDepto)
        Me.Name = "Form1"
        Me.Text = "Ejercicio combo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDepto As ComboBox
    Friend WithEvents lblDepto As Label
    Friend WithEvents lblMun As Label
    Friend WithEvents cboMun As ComboBox
End Class
