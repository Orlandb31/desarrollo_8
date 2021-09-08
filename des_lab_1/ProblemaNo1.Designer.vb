<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProblemaNo1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.horas = New System.Windows.Forms.TextBox()
        Me.tarifa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bruto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cal = New System.Windows.Forms.Button()
        Me.neto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular Salario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Horas de trabajo"
        '
        'horas
        '
        Me.horas.Location = New System.Drawing.Point(126, 91)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(100, 20)
        Me.horas.TabIndex = 2
        '
        'tarifa
        '
        Me.tarifa.Location = New System.Drawing.Point(126, 126)
        Me.tarifa.Name = "tarifa"
        Me.tarifa.Size = New System.Drawing.Size(100, 20)
        Me.tarifa.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tarifa"
        '
        'bruto
        '
        Me.bruto.Enabled = False
        Me.bruto.Location = New System.Drawing.Point(126, 170)
        Me.bruto.Name = "bruto"
        Me.bruto.Size = New System.Drawing.Size(100, 20)
        Me.bruto.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Salario Bruto"
        '
        'cal
        '
        Me.cal.Location = New System.Drawing.Point(142, 253)
        Me.cal.Name = "cal"
        Me.cal.Size = New System.Drawing.Size(75, 23)
        Me.cal.TabIndex = 7
        Me.cal.Text = "Calcular"
        Me.cal.UseVisualStyleBackColor = True
        '
        'neto
        '
        Me.neto.Enabled = False
        Me.neto.Location = New System.Drawing.Point(126, 205)
        Me.neto.Name = "neto"
        Me.neto.Size = New System.Drawing.Size(100, 20)
        Me.neto.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Salario Neto"
        '
        'ProblemaNo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 359)
        Me.Controls.Add(Me.neto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cal)
        Me.Controls.Add(Me.bruto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tarifa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProblemaNo1"
        Me.Text = "ProblemaNo1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents horas As TextBox
    Friend WithEvents tarifa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bruto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cal As Button
    Friend WithEvents neto As TextBox
    Friend WithEvents Label5 As Label
End Class
