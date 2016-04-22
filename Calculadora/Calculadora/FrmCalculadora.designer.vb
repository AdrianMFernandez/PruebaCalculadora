<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadora
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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.cmdSuma = New System.Windows.Forms.Button()
        Me.cmdMultiplicacion = New System.Windows.Forms.Button()
        Me.cmdDivision = New System.Windows.Forms.Button()
        Me.cmdResta = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstResultados = New System.Windows.Forms.ListBox()
        Me.cboResultados = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(129, 45)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(117, 31)
        Me.txtNum1.TabIndex = 0
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(129, 100)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(117, 31)
        Me.txtNum2.TabIndex = 2
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdSuma
        '
        Me.cmdSuma.BackColor = System.Drawing.Color.DarkGray
        Me.cmdSuma.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuma.Location = New System.Drawing.Point(252, 45)
        Me.cmdSuma.Name = "cmdSuma"
        Me.cmdSuma.Size = New System.Drawing.Size(60, 67)
        Me.cmdSuma.TabIndex = 3
        Me.cmdSuma.Text = "+"
        Me.cmdSuma.UseVisualStyleBackColor = False
        '
        'cmdMultiplicacion
        '
        Me.cmdMultiplicacion.BackColor = System.Drawing.Color.DarkGray
        Me.cmdMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMultiplicacion.Location = New System.Drawing.Point(252, 118)
        Me.cmdMultiplicacion.Name = "cmdMultiplicacion"
        Me.cmdMultiplicacion.Size = New System.Drawing.Size(60, 67)
        Me.cmdMultiplicacion.TabIndex = 5
        Me.cmdMultiplicacion.Text = "x"
        Me.cmdMultiplicacion.UseVisualStyleBackColor = False
        '
        'cmdDivision
        '
        Me.cmdDivision.BackColor = System.Drawing.Color.DarkGray
        Me.cmdDivision.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDivision.Location = New System.Drawing.Point(318, 118)
        Me.cmdDivision.Name = "cmdDivision"
        Me.cmdDivision.Size = New System.Drawing.Size(60, 67)
        Me.cmdDivision.TabIndex = 6
        Me.cmdDivision.Text = "/"
        Me.cmdDivision.UseVisualStyleBackColor = False
        '
        'cmdResta
        '
        Me.cmdResta.BackColor = System.Drawing.Color.DarkGray
        Me.cmdResta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResta.Location = New System.Drawing.Point(318, 45)
        Me.cmdResta.Name = "cmdResta"
        Me.cmdResta.Size = New System.Drawing.Size(60, 67)
        Me.cmdResta.TabIndex = 7
        Me.cmdResta.Text = "-"
        Me.cmdResta.UseVisualStyleBackColor = False
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(129, 160)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(117, 25)
        Me.lblResultado.TabIndex = 8
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Numero 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Resultado"
        '
        'lstResultados
        '
        Me.lstResultados.FormattingEnabled = True
        Me.lstResultados.Location = New System.Drawing.Point(12, 214)
        Me.lstResultados.Name = "lstResultados"
        Me.lstResultados.Size = New System.Drawing.Size(171, 134)
        Me.lstResultados.TabIndex = 12
        '
        'cboResultados
        '
        Me.cboResultados.FormattingEnabled = True
        Me.cboResultados.Location = New System.Drawing.Point(191, 214)
        Me.cboResultados.Name = "cboResultados"
        Me.cboResultados.Size = New System.Drawing.Size(187, 21)
        Me.cboResultados.TabIndex = 13
        '
        'FrmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(385, 354)
        Me.Controls.Add(Me.cboResultados)
        Me.Controls.Add(Me.lstResultados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.cmdResta)
        Me.Controls.Add(Me.cmdDivision)
        Me.Controls.Add(Me.cmdMultiplicacion)
        Me.Controls.Add(Me.cmdSuma)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "FrmCalculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdSuma As System.Windows.Forms.Button
    Friend WithEvents cmdMultiplicacion As System.Windows.Forms.Button
    Friend WithEvents cmdDivision As System.Windows.Forms.Button
    Friend WithEvents cmdResta As System.Windows.Forms.Button
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstResultados As ListBox
    Friend WithEvents cboResultados As ComboBox
End Class
