<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.EntrarBTT = New System.Windows.Forms.Button()
        Me.LbOlvContraseña = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_Salsamentaria_1DataSet = New appSalsamentaria.BDD_Salsamentaria_1DataSet()
        Me.UsuarioTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager()
        Me.Usuario_RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Usuario_RolTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.Usuario_RolTableAdapter()
        ContraseñaLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuario_RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.BackColor = System.Drawing.Color.Transparent
        ContraseñaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(63, 193)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(78, 19)
        ContraseñaLabel.TabIndex = 10
        ContraseñaLabel.Text = "Contraseña"
        '
        'CedulaLabel
        '
        CedulaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        CedulaLabel.AutoSize = True
        CedulaLabel.BackColor = System.Drawing.Color.Transparent
        CedulaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CedulaLabel.Location = New System.Drawing.Point(63, 142)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(56, 19)
        CedulaLabel.TabIndex = 9
        CedulaLabel.Text = "Usuario"
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(66, 215)
        Me.ContraseñaTextBox.MaxLength = 20
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(202, 26)
        Me.ContraseñaTextBox.TabIndex = 12
        Me.ContraseñaTextBox.UseSystemPasswordChar = True
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Cedula", True))
        Me.CedulaTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CedulaTextBox.Location = New System.Drawing.Point(66, 164)
        Me.CedulaTextBox.MaxLength = 10
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(202, 26)
        Me.CedulaTextBox.TabIndex = 11
        '
        'EntrarBTT
        '
        Me.EntrarBTT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EntrarBTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EntrarBTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EntrarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntrarBTT.Location = New System.Drawing.Point(66, 256)
        Me.EntrarBTT.Name = "EntrarBTT"
        Me.EntrarBTT.Size = New System.Drawing.Size(202, 32)
        Me.EntrarBTT.TabIndex = 8
        Me.EntrarBTT.Text = "Entrar"
        Me.EntrarBTT.UseVisualStyleBackColor = True
        '
        'LbOlvContraseña
        '
        Me.LbOlvContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LbOlvContraseña.AutoSize = True
        Me.LbOlvContraseña.BackColor = System.Drawing.Color.Transparent
        Me.LbOlvContraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOlvContraseña.LinkColor = System.Drawing.Color.Black
        Me.LbOlvContraseña.Location = New System.Drawing.Point(80, 300)
        Me.LbOlvContraseña.Name = "LbOlvContraseña"
        Me.LbOlvContraseña.Size = New System.Drawing.Size(164, 19)
        Me.LbOlvContraseña.TabIndex = 13
        Me.LbOlvContraseña.TabStop = True
        Me.LbOlvContraseña.Text = "¿Olvidaste tu contraseña?"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(106, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 122)
        Me.Panel1.TabIndex = 14
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'BDD_Salsamentaria_1DataSet
        '
        Me.BDD_Salsamentaria_1DataSet.DataSetName = "BDD_Salsamentaria_1DataSet"
        Me.BDD_Salsamentaria_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.Inventario_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario_RolTableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'Usuario_RolBindingSource
        '
        Me.Usuario_RolBindingSource.DataMember = "Usuario_Rol"
        Me.Usuario_RolBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'Usuario_RolTableAdapter
        '
        Me.Usuario_RolTableAdapter.ClearBeforeFill = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(334, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbOlvContraseña)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.EntrarBTT)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(CedulaLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuario_RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDD_Salsamentaria_1DataSet As BDD_Salsamentaria_1DataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents CedulaTextBox As TextBox
    Friend WithEvents EntrarBTT As Button
    Friend WithEvents LbOlvContraseña As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Usuario_RolBindingSource As BindingSource
    Friend WithEvents Usuario_RolTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.Usuario_RolTableAdapter
    Friend WithEvents Panel1 As Panel
End Class
