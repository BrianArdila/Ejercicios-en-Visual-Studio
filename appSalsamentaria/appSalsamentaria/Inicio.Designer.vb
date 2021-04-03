<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.components = New System.ComponentModel.Container()
        Me.LBHora = New System.Windows.Forms.Label()
        Me.LBFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LBHora
        '
        Me.LBHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBHora.AutoSize = True
        Me.LBHora.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBHora.Location = New System.Drawing.Point(503, 457)
        Me.LBHora.Name = "LBHora"
        Me.LBHora.Size = New System.Drawing.Size(155, 55)
        Me.LBHora.TabIndex = 3
        Me.LBHora.Text = "Label3"
        '
        'LBFecha
        '
        Me.LBFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBFecha.AutoSize = True
        Me.LBFecha.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFecha.Location = New System.Drawing.Point(464, 521)
        Me.LBFecha.Name = "LBFecha"
        Me.LBFecha.Size = New System.Drawing.Size(90, 31)
        Me.LBFecha.TabIndex = 2
        Me.LBFecha.Text = "Label2"
        '
        'Timer1
        '
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(847, 617)
        Me.Controls.Add(Me.LBHora)
        Me.Controls.Add(Me.LBFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBHora As Label
    Friend WithEvents LBFecha As Label
    Friend WithEvents Timer1 As Timer
End Class
