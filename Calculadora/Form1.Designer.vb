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
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblRespuestaVarianza = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lblDesvTipica = New System.Windows.Forms.Label()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.x1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x1xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x21xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalF1 = New System.Windows.Forms.Label()
        Me.lblTotalx1xF1 = New System.Windows.Forms.Label()
        Me.lblTotalx21xF1 = New System.Windows.Forms.Label()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(31, 414)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(188, 45)
        Me.btnMediaAritmetica.TabIndex = 0
        Me.btnMediaAritmetica.Text = "Calculos Estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(77, 62)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(151, 20)
        Me.txtSerie.TabIndex = 1
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(37, 65)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(34, 13)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Serie:"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(107, 98)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaMedia.TabIndex = 3
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblRespuestaVarianza
        '
        Me.lblRespuestaVarianza.AutoSize = True
        Me.lblRespuestaVarianza.Location = New System.Drawing.Point(107, 119)
        Me.lblRespuestaVarianza.Name = "lblRespuestaVarianza"
        Me.lblRespuestaVarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaVarianza.TabIndex = 4
        Me.lblRespuestaVarianza.Text = "?"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(37, 98)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(38, 13)
        Me.lblMedia.TabIndex = 5
        Me.lblMedia.Text = "media:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(37, 119)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(50, 13)
        Me.lblVarianza.TabIndex = 6
        Me.lblVarianza.Text = "varianza:"
        '
        'lblDesvTipica
        '
        Me.lblDesvTipica.AutoSize = True
        Me.lblDesvTipica.Location = New System.Drawing.Point(28, 143)
        Me.lblDesvTipica.Name = "lblDesvTipica"
        Me.lblDesvTipica.Size = New System.Drawing.Size(70, 13)
        Me.lblDesvTipica.TabIndex = 7
        Me.lblDesvTipica.Text = "Desv. Tipica:"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(107, 143)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaDesvTipica.TabIndex = 8
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x1, Me.f1, Me.n1, Me.x1xf1, Me.x21xf1})
        Me.grdEstadistica.Location = New System.Drawing.Point(287, 12)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.Size = New System.Drawing.Size(543, 447)
        Me.grdEstadistica.TabIndex = 9
        '
        'x1
        '
        Me.x1.HeaderText = "X1"
        Me.x1.Name = "x1"
        '
        'f1
        '
        Me.f1.HeaderText = "F1"
        Me.f1.Name = "f1"
        '
        'n1
        '
        Me.n1.HeaderText = "N1"
        Me.n1.Name = "n1"
        '
        'x1xf1
        '
        Me.x1xf1.HeaderText = "x1 x  F1"
        Me.x1xf1.Name = "x1xf1"
        '
        'x21xf1
        '
        Me.x21xf1.HeaderText = "x21 x F1"
        Me.x21xf1.Name = "x21xf1"
        '
        'lblTotalF1
        '
        Me.lblTotalF1.AutoSize = True
        Me.lblTotalF1.Location = New System.Drawing.Point(487, 471)
        Me.lblTotalF1.Name = "lblTotalF1"
        Me.lblTotalF1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalF1.TabIndex = 10
        Me.lblTotalF1.Text = "0.0"
        '
        'lblTotalx1xF1
        '
        Me.lblTotalx1xF1.AutoSize = True
        Me.lblTotalx1xF1.Location = New System.Drawing.Point(691, 471)
        Me.lblTotalx1xF1.Name = "lblTotalx1xF1"
        Me.lblTotalx1xF1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalx1xF1.TabIndex = 11
        Me.lblTotalx1xF1.Text = "0.0"
        '
        'lblTotalx21xF1
        '
        Me.lblTotalx21xF1.AutoSize = True
        Me.lblTotalx21xF1.Location = New System.Drawing.Point(785, 471)
        Me.lblTotalx21xF1.Name = "lblTotalx21xF1"
        Me.lblTotalx21xF1.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalx21xF1.TabIndex = 12
        Me.lblTotalx21xF1.Text = "0.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 586)
        Me.Controls.Add(Me.lblTotalx21xF1)
        Me.Controls.Add(Me.lblTotalx1xF1)
        Me.Controls.Add(Me.lblTotalF1)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lblDesvTipica)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.lblRespuestaVarianza)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.Name = "Form1"
        Me.Text = "Matrices y Poo"
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMediaAritmetica As Button
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents lblSerie As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblRespuestaVarianza As Label
    Friend WithEvents lblMedia As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lblDesvTipica As Label
    Friend WithEvents lblRespuestaDesvTipica As Label
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents x1 As DataGridViewTextBoxColumn
    Friend WithEvents f1 As DataGridViewTextBoxColumn
    Friend WithEvents n1 As DataGridViewTextBoxColumn
    Friend WithEvents x1xf1 As DataGridViewTextBoxColumn
    Friend WithEvents x21xf1 As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalF1 As Label
    Friend WithEvents lblTotalx1xF1 As Label
    Friend WithEvents lblTotalx21xF1 As Label
End Class
