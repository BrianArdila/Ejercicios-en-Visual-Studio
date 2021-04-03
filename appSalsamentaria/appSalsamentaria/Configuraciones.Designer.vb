<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuraciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuraciones))
        Me.CambioTemaBTT = New System.Windows.Forms.Button()
        Me.HoraBTT = New System.Windows.Forms.Button()
        Me.InfoContactoBTT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VolverBTT = New System.Windows.Forms.Button()
        Me.PlContenedor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CambioTemaBTT
        '
        resources.ApplyResources(Me.CambioTemaBTT, "CambioTemaBTT")
        Me.CambioTemaBTT.Name = "CambioTemaBTT"
        Me.CambioTemaBTT.UseVisualStyleBackColor = True
        '
        'HoraBTT
        '
        resources.ApplyResources(Me.HoraBTT, "HoraBTT")
        Me.HoraBTT.Name = "HoraBTT"
        Me.HoraBTT.UseVisualStyleBackColor = True
        '
        'InfoContactoBTT
        '
        resources.ApplyResources(Me.InfoContactoBTT, "InfoContactoBTT")
        Me.InfoContactoBTT.Name = "InfoContactoBTT"
        Me.InfoContactoBTT.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.VolverBTT)
        Me.Panel2.Controls.Add(Me.HoraBTT)
        Me.Panel2.Controls.Add(Me.CambioTemaBTT)
        Me.Panel2.Controls.Add(Me.InfoContactoBTT)
        Me.Panel2.Name = "Panel2"
        '
        'VolverBTT
        '
        resources.ApplyResources(Me.VolverBTT, "VolverBTT")
        Me.VolverBTT.Name = "VolverBTT"
        Me.VolverBTT.UseVisualStyleBackColor = True
        '
        'PlContenedor
        '
        Me.PlContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.PlContenedor, "PlContenedor")
        Me.PlContenedor.Name = "PlContenedor"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Configuraciones
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PlContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Configuraciones"
        Me.ShowIcon = False
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CambioTemaBTT As Button
    Friend WithEvents HoraBTT As Button
    Friend WithEvents InfoContactoBTT As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PlContenedor As Panel
    Friend WithEvents VolverBTT As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
