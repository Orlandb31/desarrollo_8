<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProblemaNo5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtalta = New System.Windows.Forms.TextBox()
        Me.txtbaja = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROGRAMA 5(SUBASTA INTERNET)"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(148, 145)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(162, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Oferta mas Alta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Oferta mas baja"
        '
        'txtalta
        '
        Me.txtalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalta.Location = New System.Drawing.Point(359, 147)
        Me.txtalta.Name = "txtalta"
        Me.txtalta.ReadOnly = True
        Me.txtalta.Size = New System.Drawing.Size(100, 30)
        Me.txtalta.TabIndex = 3
        '
        'txtbaja
        '
        Me.txtbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbaja.Location = New System.Drawing.Point(359, 228)
        Me.txtbaja.Name = "txtbaja"
        Me.txtbaja.ReadOnly = True
        Me.txtbaja.Size = New System.Drawing.Size(100, 30)
        Me.txtbaja.TabIndex = 4
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(196, 336)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(141, 46)
        Me.btncalcular.TabIndex = 5
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(402, 336)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(111, 46)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Cerrar"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'programa5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtbaja)
        Me.Controls.Add(Me.txtalta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "programa5"
        Me.Text = "programa5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtalta As TextBox
    Friend WithEvents txtbaja As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnclose As Button
End Class
