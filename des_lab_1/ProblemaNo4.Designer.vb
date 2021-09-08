<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProblemaNo4
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMen = New System.Windows.Forms.TextBox()
        Me.tbMayor = New System.Windows.Forms.TextBox()
        Me.btnEjucutar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total de personas"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(296, 247)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbTotal.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cantidad de personas con temperatura menor a 33°"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cantidad de personas con temperatura mayor a 37°"
        '
        'tbMen
        '
        Me.tbMen.Location = New System.Drawing.Point(296, 195)
        Me.tbMen.Name = "tbMen"
        Me.tbMen.ReadOnly = True
        Me.tbMen.Size = New System.Drawing.Size(100, 20)
        Me.tbMen.TabIndex = 12
        '
        'tbMayor
        '
        Me.tbMayor.Location = New System.Drawing.Point(296, 162)
        Me.tbMayor.Name = "tbMayor"
        Me.tbMayor.ReadOnly = True
        Me.tbMayor.Size = New System.Drawing.Size(100, 20)
        Me.tbMayor.TabIndex = 11
        '
        'btnEjucutar
        '
        Me.btnEjucutar.Location = New System.Drawing.Point(178, 83)
        Me.btnEjucutar.Name = "btnEjucutar"
        Me.btnEjucutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjucutar.TabIndex = 10
        Me.btnEjucutar.Text = "Ejecutar"
        Me.btnEjucutar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Puesto Control"
        '
        'ProblemaNo4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 409)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbMen)
        Me.Controls.Add(Me.tbMayor)
        Me.Controls.Add(Me.btnEjucutar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProblemaNo4"
        Me.Text = "ProblemaNo4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbMen As TextBox
    Friend WithEvents tbMayor As TextBox
    Friend WithEvents btnEjucutar As Button
    Friend WithEvents Label1 As Label
End Class
