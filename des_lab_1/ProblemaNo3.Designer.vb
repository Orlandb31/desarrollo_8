<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProblemaNo3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProblemaNo3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGanacias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSocio1 = New System.Windows.Forms.TextBox()
        Me.txtSocio2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSocio3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(549, 80)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enunciado: "
        '
        'txtGanacias
        '
        Me.txtGanacias.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGanacias.Location = New System.Drawing.Point(236, 169)
        Me.txtGanacias.Name = "txtGanacias"
        Me.txtGanacias.Size = New System.Drawing.Size(134, 26)
        Me.txtGanacias.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ganancias de la Empresa:"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(57, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Calcular ganancias"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Socio 1"
        '
        'txtSocio1
        '
        Me.txtSocio1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSocio1.Location = New System.Drawing.Point(255, 378)
        Me.txtSocio1.Name = "txtSocio1"
        Me.txtSocio1.Size = New System.Drawing.Size(75, 26)
        Me.txtSocio1.TabIndex = 7
        Me.txtSocio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSocio2
        '
        Me.txtSocio2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSocio2.Location = New System.Drawing.Point(439, 378)
        Me.txtSocio2.Name = "txtSocio2"
        Me.txtSocio2.Size = New System.Drawing.Size(75, 26)
        Me.txtSocio2.TabIndex = 9
        Me.txtSocio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(445, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Socio 2"
        '
        'txtSocio3
        '
        Me.txtSocio3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSocio3.Location = New System.Drawing.Point(607, 378)
        Me.txtSocio3.Name = "txtSocio3"
        Me.txtSocio3.Size = New System.Drawing.Size(75, 26)
        Me.txtSocio3.TabIndex = 11
        Me.txtSocio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(613, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Socio 3"
        '
        'ProblemaNo3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 452)
        Me.Controls.Add(Me.txtSocio3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSocio2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSocio1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGanacias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProblemaNo3"
        Me.Text = "ProblemaNo3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGanacias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSocio1 As TextBox
    Friend WithEvents txtSocio2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSocio3 As TextBox
    Friend WithEvents Label6 As Label
End Class
