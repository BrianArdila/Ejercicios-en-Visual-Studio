<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Principal))
        Me.TTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.PlMenuLateral = New System.Windows.Forms.Panel()
        Me.RetraerMenuBTT = New System.Windows.Forms.Button()
        Me.SalirBTT = New System.Windows.Forms.Button()
        Me.AjustesBTT = New System.Windows.Forms.Button()
        Me.UsuariosBTT = New System.Windows.Forms.Button()
        Me.InventarioBTT = New System.Windows.Forms.Button()
        Me.FacturaBTT = New System.Windows.Forms.Button()
        Me.ClienteBTT = New System.Windows.Forms.Button()
        Me.ProveedorBTT = New System.Windows.Forms.Button()
        Me.HomeBTT = New System.Windows.Forms.Button()
        Me.PlContenedor = New System.Windows.Forms.Panel()
        Me.PlEncabezado = New System.Windows.Forms.Panel()
        Me.LBDatosCliente = New System.Windows.Forms.Label()
        Me.PlPie_Página = New System.Windows.Forms.Panel()
        Me.LBInfContacto = New System.Windows.Forms.Label()
        Me.TLPanelPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.PlMenuLateral.SuspendLayout()
        Me.PlEncabezado.SuspendLayout()
        Me.PlPie_Página.SuspendLayout()
        Me.TLPanelPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlMenuLateral
        '
        Me.PlMenuLateral.BackColor = System.Drawing.Color.White
        Me.PlMenuLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlMenuLateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlMenuLateral.Controls.Add(Me.RetraerMenuBTT)
        Me.PlMenuLateral.Controls.Add(Me.SalirBTT)
        Me.PlMenuLateral.Controls.Add(Me.AjustesBTT)
        Me.PlMenuLateral.Controls.Add(Me.UsuariosBTT)
        Me.PlMenuLateral.Controls.Add(Me.InventarioBTT)
        Me.PlMenuLateral.Controls.Add(Me.FacturaBTT)
        Me.PlMenuLateral.Controls.Add(Me.ClienteBTT)
        Me.PlMenuLateral.Controls.Add(Me.ProveedorBTT)
        Me.PlMenuLateral.Controls.Add(Me.HomeBTT)
        Me.PlMenuLateral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PlMenuLateral.Margin = New System.Windows.Forms.Padding(0)
        Me.PlMenuLateral.Name = "PlMenuLateral"
        Me.TLPanelPrincipal.SetRowSpan(Me.PlMenuLateral, 3)
        Me.PlMenuLateral.Size = New System.Drawing.Size(161, 686)
        Me.PlMenuLateral.TabIndex = 0
        '
        'RetraerMenuBTT
        '
        Me.RetraerMenuBTT.BackColor = System.Drawing.Color.Transparent
        Me.RetraerMenuBTT.Dock = System.Windows.Forms.DockStyle.Top
        Me.RetraerMenuBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RetraerMenuBTT.Image = CType(resources.GetObject("RetraerMenuBTT.Image"), System.Drawing.Image)
        Me.RetraerMenuBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RetraerMenuBTT.Location = New System.Drawing.Point(0, 0)
        Me.RetraerMenuBTT.Name = "RetraerMenuBTT"
        Me.RetraerMenuBTT.Size = New System.Drawing.Size(157, 45)
        Me.RetraerMenuBTT.TabIndex = 8
        Me.RetraerMenuBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RetraerMenuBTT.UseVisualStyleBackColor = False
        '
        'SalirBTT
        '
        Me.SalirBTT.BackColor = System.Drawing.Color.Transparent
        Me.SalirBTT.Cursor = System.Windows.Forms.Cursors.Default
        Me.SalirBTT.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SalirBTT.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.SalirBTT.FlatAppearance.BorderSize = 0
        Me.SalirBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalirBTT.Image = CType(resources.GetObject("SalirBTT.Image"), System.Drawing.Image)
        Me.SalirBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalirBTT.Location = New System.Drawing.Point(0, 637)
        Me.SalirBTT.Name = "SalirBTT"
        Me.SalirBTT.Size = New System.Drawing.Size(157, 45)
        Me.SalirBTT.TabIndex = 7
        Me.SalirBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalirBTT.UseVisualStyleBackColor = True
        '
        'AjustesBTT
        '
        Me.AjustesBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AjustesBTT.BackColor = System.Drawing.Color.Transparent
        Me.AjustesBTT.FlatAppearance.BorderSize = 0
        Me.AjustesBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AjustesBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjustesBTT.Image = CType(resources.GetObject("AjustesBTT.Image"), System.Drawing.Image)
        Me.AjustesBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AjustesBTT.Location = New System.Drawing.Point(0, 502)
        Me.AjustesBTT.Name = "AjustesBTT"
        Me.AjustesBTT.Size = New System.Drawing.Size(156, 64)
        Me.AjustesBTT.TabIndex = 6
        Me.AjustesBTT.Text = "Ajustes"
        Me.AjustesBTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AjustesBTT.UseVisualStyleBackColor = False
        '
        'UsuariosBTT
        '
        Me.UsuariosBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosBTT.BackColor = System.Drawing.Color.Transparent
        Me.UsuariosBTT.FlatAppearance.BorderSize = 0
        Me.UsuariosBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UsuariosBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuariosBTT.Image = CType(resources.GetObject("UsuariosBTT.Image"), System.Drawing.Image)
        Me.UsuariosBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UsuariosBTT.Location = New System.Drawing.Point(0, 432)
        Me.UsuariosBTT.Name = "UsuariosBTT"
        Me.UsuariosBTT.Size = New System.Drawing.Size(156, 64)
        Me.UsuariosBTT.TabIndex = 5
        Me.UsuariosBTT.Text = "Usuarios"
        Me.UsuariosBTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsuariosBTT.UseVisualStyleBackColor = False
        '
        'InventarioBTT
        '
        Me.InventarioBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InventarioBTT.BackColor = System.Drawing.Color.Transparent
        Me.InventarioBTT.FlatAppearance.BorderSize = 0
        Me.InventarioBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.InventarioBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventarioBTT.Image = CType(resources.GetObject("InventarioBTT.Image"), System.Drawing.Image)
        Me.InventarioBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InventarioBTT.Location = New System.Drawing.Point(0, 362)
        Me.InventarioBTT.Name = "InventarioBTT"
        Me.InventarioBTT.Size = New System.Drawing.Size(156, 64)
        Me.InventarioBTT.TabIndex = 4
        Me.InventarioBTT.Text = "Inventario"
        Me.InventarioBTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InventarioBTT.UseVisualStyleBackColor = False
        '
        'FacturaBTT
        '
        Me.FacturaBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturaBTT.BackColor = System.Drawing.Color.Transparent
        Me.FacturaBTT.FlatAppearance.BorderSize = 0
        Me.FacturaBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FacturaBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacturaBTT.Image = CType(resources.GetObject("FacturaBTT.Image"), System.Drawing.Image)
        Me.FacturaBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FacturaBTT.Location = New System.Drawing.Point(1, 292)
        Me.FacturaBTT.Name = "FacturaBTT"
        Me.FacturaBTT.Size = New System.Drawing.Size(156, 64)
        Me.FacturaBTT.TabIndex = 3
        Me.FacturaBTT.Text = "Factura"
        Me.FacturaBTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FacturaBTT.UseVisualStyleBackColor = False
        '
        'ClienteBTT
        '
        Me.ClienteBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteBTT.BackColor = System.Drawing.Color.Transparent
        Me.ClienteBTT.FlatAppearance.BorderSize = 0
        Me.ClienteBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClienteBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteBTT.Image = CType(resources.GetObject("ClienteBTT.Image"), System.Drawing.Image)
        Me.ClienteBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClienteBTT.Location = New System.Drawing.Point(1, 222)
        Me.ClienteBTT.Name = "ClienteBTT"
        Me.ClienteBTT.Size = New System.Drawing.Size(156, 64)
        Me.ClienteBTT.TabIndex = 2
        Me.ClienteBTT.Text = "Clientes"
        Me.ClienteBTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClienteBTT.UseVisualStyleBackColor = False
        '
        'ProveedorBTT
        '
        Me.ProveedorBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedorBTT.BackColor = System.Drawing.Color.Transparent
        Me.ProveedorBTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProveedorBTT.FlatAppearance.BorderSize = 0
        Me.ProveedorBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProveedorBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedorBTT.Image = CType(resources.GetObject("ProveedorBTT.Image"), System.Drawing.Image)
        Me.ProveedorBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProveedorBTT.Location = New System.Drawing.Point(1, 152)
        Me.ProveedorBTT.Name = "ProveedorBTT"
        Me.ProveedorBTT.Size = New System.Drawing.Size(156, 64)
        Me.ProveedorBTT.TabIndex = 1
        Me.ProveedorBTT.Text = "Proveedor"
        Me.ProveedorBTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProveedorBTT.UseVisualStyleBackColor = False
        '
        'HomeBTT
        '
        Me.HomeBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeBTT.BackColor = System.Drawing.Color.Transparent
        Me.HomeBTT.FlatAppearance.BorderSize = 0
        Me.HomeBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBTT.Image = CType(resources.GetObject("HomeBTT.Image"), System.Drawing.Image)
        Me.HomeBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.HomeBTT.Location = New System.Drawing.Point(1, 82)
        Me.HomeBTT.Name = "HomeBTT"
        Me.HomeBTT.Size = New System.Drawing.Size(156, 64)
        Me.HomeBTT.TabIndex = 0
        Me.HomeBTT.Text = "Inicio"
        Me.HomeBTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeBTT.UseVisualStyleBackColor = False
        '
        'PlContenedor
        '
        Me.PlContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlContenedor.Font = New System.Drawing.Font("Lucida Fax", 8.25!)
        Me.PlContenedor.Location = New System.Drawing.Point(161, 34)
        Me.PlContenedor.Margin = New System.Windows.Forms.Padding(0)
        Me.PlContenedor.Name = "PlContenedor"
        Me.PlContenedor.Size = New System.Drawing.Size(847, 617)
        Me.PlContenedor.TabIndex = 1
        '
        'PlEncabezado
        '
        Me.PlEncabezado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlEncabezado.Controls.Add(Me.LBDatosCliente)
        Me.PlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlEncabezado.Location = New System.Drawing.Point(161, 0)
        Me.PlEncabezado.Margin = New System.Windows.Forms.Padding(0)
        Me.PlEncabezado.Name = "PlEncabezado"
        Me.PlEncabezado.Size = New System.Drawing.Size(847, 34)
        Me.PlEncabezado.TabIndex = 3
        '
        'LBDatosCliente
        '
        Me.LBDatosCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LBDatosCliente.AutoSize = True
        Me.LBDatosCliente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBDatosCliente.Location = New System.Drawing.Point(101, 8)
        Me.LBDatosCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.LBDatosCliente.Name = "LBDatosCliente"
        Me.LBDatosCliente.Size = New System.Drawing.Size(627, 19)
        Me.LBDatosCliente.TabIndex = 0
        Me.LBDatosCliente.Text = "VENTA DE POLLO QUESO Y RELLENAS MARTICA NIT: 281.549.30-8 Reg. Simplificado"
        Me.LBDatosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlPie_Página
        '
        Me.PlPie_Página.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PlPie_Página.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlPie_Página.Controls.Add(Me.LBInfContacto)
        Me.PlPie_Página.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlPie_Página.Location = New System.Drawing.Point(161, 651)
        Me.PlPie_Página.Margin = New System.Windows.Forms.Padding(0)
        Me.PlPie_Página.Name = "PlPie_Página"
        Me.PlPie_Página.Size = New System.Drawing.Size(847, 35)
        Me.PlPie_Página.TabIndex = 2
        '
        'LBInfContacto
        '
        Me.LBInfContacto.AutoSize = True
        Me.LBInfContacto.Location = New System.Drawing.Point(16, 10)
        Me.LBInfContacto.Name = "LBInfContacto"
        Me.LBInfContacto.Size = New System.Drawing.Size(0, 13)
        Me.LBInfContacto.TabIndex = 0
        '
        'TLPanelPrincipal
        '
        Me.TLPanelPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.TLPanelPrincipal.ColumnCount = 2
        Me.TLPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TLPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.0!))
        Me.TLPanelPrincipal.Controls.Add(Me.PlPie_Página, 1, 2)
        Me.TLPanelPrincipal.Controls.Add(Me.PlEncabezado, 1, 0)
        Me.TLPanelPrincipal.Controls.Add(Me.PlContenedor, 1, 1)
        Me.TLPanelPrincipal.Controls.Add(Me.PlMenuLateral, 0, 0)
        Me.TLPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TLPanelPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPanelPrincipal.Name = "TLPanelPrincipal"
        Me.TLPanelPrincipal.RowCount = 3
        Me.TLPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TLPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TLPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TLPanelPrincipal.Size = New System.Drawing.Size(1008, 686)
        Me.TLPanelPrincipal.TabIndex = 6
        '
        'Panel_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 686)
        Me.Controls.Add(Me.TLPanelPrincipal)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Panel_Principal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel Principal"
        Me.PlMenuLateral.ResumeLayout(False)
        Me.PlEncabezado.ResumeLayout(False)
        Me.PlEncabezado.PerformLayout()
        Me.PlPie_Página.ResumeLayout(False)
        Me.PlPie_Página.PerformLayout()
        Me.TLPanelPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TTipHelp As ToolTip
    Friend WithEvents PlMenuLateral As Panel
    Friend WithEvents RetraerMenuBTT As Button
    Friend WithEvents SalirBTT As Button
    Friend WithEvents AjustesBTT As Button
    Friend WithEvents UsuariosBTT As Button
    Friend WithEvents InventarioBTT As Button
    Friend WithEvents FacturaBTT As Button
    Friend WithEvents ClienteBTT As Button
    Friend WithEvents ProveedorBTT As Button
    Friend WithEvents HomeBTT As Button
    Friend WithEvents TLPanelPrincipal As TableLayoutPanel
    Friend WithEvents PlPie_Página As Panel
    Friend WithEvents LBInfContacto As Label
    Friend WithEvents PlEncabezado As Panel
    Friend WithEvents LBDatosCliente As Label
    Friend WithEvents PlContenedor As Panel
End Class
