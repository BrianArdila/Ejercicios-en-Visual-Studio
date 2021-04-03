<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.AgregarBTT = New System.Windows.Forms.Button()
        Me.EliminarBTT = New System.Windows.Forms.Button()
        Me.ModificarBTT = New System.Windows.Forms.Button()
        Me.BuscarBTT = New System.Windows.Forms.Button()
        Me.ActualizarBTT = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_Salsamentaria_1DataSet = New appSalsamentaria.BDD_Salsamentaria_1DataSet()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.CargoComboBox = New System.Windows.Forms.ComboBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CdBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GBoxDatosUser = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario_RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager()
        Me.Usuario_RolTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.Usuario_RolTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatosUser.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuario_RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(17, 54)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(63, 19)
        NombreLabel.TabIndex = 51
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(17, 86)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(63, 19)
        ApellidoLabel.TabIndex = 53
        ApellidoLabel.Text = "Apellido:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CedulaLabel.Location = New System.Drawing.Point(17, 118)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(55, 19)
        CedulaLabel.TabIndex = 55
        CedulaLabel.Text = "Cedula:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(17, 150)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 19)
        TelefonoLabel.TabIndex = 57
        TelefonoLabel.Text = "Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(17, 215)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(56, 19)
        CorreoLabel.TabIndex = 59
        CorreoLabel.Text = "Correo:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(17, 247)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(81, 19)
        ContraseñaLabel.TabIndex = 61
        ContraseñaLabel.Text = "Contraseña:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoLabel.Location = New System.Drawing.Point(17, 182)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(50, 19)
        CargoLabel.TabIndex = 64
        CargoLabel.Text = "Cargo:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(17, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(25, 19)
        IdLabel.TabIndex = 65
        IdLabel.Text = "Id:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(15, 20)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(55, 19)
        Label1.TabIndex = 67
        Label1.Text = "Cedula:"
        '
        'AgregarBTT
        '
        Me.AgregarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBTT.Image = CType(resources.GetObject("AgregarBTT.Image"), System.Drawing.Image)
        Me.AgregarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarBTT.Location = New System.Drawing.Point(462, 191)
        Me.AgregarBTT.Name = "AgregarBTT"
        Me.AgregarBTT.Size = New System.Drawing.Size(122, 54)
        Me.AgregarBTT.TabIndex = 14
        Me.AgregarBTT.Text = "Agregar"
        Me.AgregarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarBTT.UseVisualStyleBackColor = True
        '
        'EliminarBTT
        '
        Me.EliminarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EliminarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarBTT.Image = CType(resources.GetObject("EliminarBTT.Image"), System.Drawing.Image)
        Me.EliminarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarBTT.Location = New System.Drawing.Point(617, 266)
        Me.EliminarBTT.Name = "EliminarBTT"
        Me.EliminarBTT.Size = New System.Drawing.Size(122, 54)
        Me.EliminarBTT.TabIndex = 15
        Me.EliminarBTT.Text = "Eliminar"
        Me.EliminarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarBTT.UseVisualStyleBackColor = True
        '
        'ModificarBTT
        '
        Me.ModificarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarBTT.Image = CType(resources.GetObject("ModificarBTT.Image"), System.Drawing.Image)
        Me.ModificarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarBTT.Location = New System.Drawing.Point(617, 191)
        Me.ModificarBTT.Name = "ModificarBTT"
        Me.ModificarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ModificarBTT.TabIndex = 16
        Me.ModificarBTT.Text = "Modificar"
        Me.ModificarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarBTT.UseVisualStyleBackColor = True
        '
        'BuscarBTT
        '
        Me.BuscarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBTT.Image = CType(resources.GetObject("BuscarBTT.Image"), System.Drawing.Image)
        Me.BuscarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarBTT.Location = New System.Drawing.Point(143, 81)
        Me.BuscarBTT.Name = "BuscarBTT"
        Me.BuscarBTT.Size = New System.Drawing.Size(122, 54)
        Me.BuscarBTT.TabIndex = 17
        Me.BuscarBTT.Text = "Buscar"
        Me.BuscarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarBTT.UseVisualStyleBackColor = True
        '
        'ActualizarBTT
        '
        Me.ActualizarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarBTT.Image = CType(resources.GetObject("ActualizarBTT.Image"), System.Drawing.Image)
        Me.ActualizarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarBTT.Location = New System.Drawing.Point(462, 265)
        Me.ActualizarBTT.Name = "ActualizarBTT"
        Me.ActualizarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ActualizarBTT.TabIndex = 31
        Me.ActualizarBTT.Text = "Actualizar"
        Me.ActualizarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarBTT.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BackColor = System.Drawing.Color.White
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(121, 51)
        Me.NombreTextBox.MaxLength = 50
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(246, 26)
        Me.NombreTextBox.TabIndex = 52
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
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(121, 83)
        Me.ApellidoTextBox.MaxLength = 50
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(246, 26)
        Me.ApellidoTextBox.TabIndex = 54
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.BackColor = System.Drawing.Color.White
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Cedula", True))
        Me.CedulaTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CedulaTextBox.Location = New System.Drawing.Point(121, 115)
        Me.CedulaTextBox.MaxLength = 10
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(246, 26)
        Me.CedulaTextBox.TabIndex = 56
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(121, 147)
        Me.TelefonoTextBox.MaxLength = 15
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(246, 26)
        Me.TelefonoTextBox.TabIndex = 58
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Correo", True))
        Me.CorreoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextBox.Location = New System.Drawing.Point(121, 212)
        Me.CorreoTextBox.MaxLength = 41
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(246, 26)
        Me.CorreoTextBox.TabIndex = 60
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(121, 244)
        Me.ContraseñaTextBox.MaxLength = 20
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(246, 26)
        Me.ContraseñaTextBox.TabIndex = 62
        Me.ContraseñaTextBox.UseSystemPasswordChar = True
        '
        'CargoComboBox
        '
        Me.CargoComboBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargoComboBox.FormattingEnabled = True
        Me.CargoComboBox.Items.AddRange(New Object() {"Administrador", "Vendedor"})
        Me.CargoComboBox.Location = New System.Drawing.Point(121, 179)
        Me.CargoComboBox.Name = "CargoComboBox"
        Me.CargoComboBox.Size = New System.Drawing.Size(246, 27)
        Me.CargoComboBox.TabIndex = 65
        Me.CargoComboBox.Text = "Ninguno"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(121, 19)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(246, 26)
        Me.IdTextBox.TabIndex = 66
        '
        'CdBuscarTextBox
        '
        Me.CdBuscarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CdBuscarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Cedula", True))
        Me.CdBuscarTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdBuscarTextBox.Location = New System.Drawing.Point(19, 45)
        Me.CdBuscarTextBox.MaxLength = 10
        Me.CdBuscarTextBox.Name = "CdBuscarTextBox"
        Me.CdBuscarTextBox.Size = New System.Drawing.Size(246, 26)
        Me.CdBuscarTextBox.TabIndex = 68
        '
        'GBoxDatosUser
        '
        Me.GBoxDatosUser.Controls.Add(IdLabel)
        Me.GBoxDatosUser.Controls.Add(Me.IdTextBox)
        Me.GBoxDatosUser.Controls.Add(Me.CargoComboBox)
        Me.GBoxDatosUser.Controls.Add(CargoLabel)
        Me.GBoxDatosUser.Controls.Add(NombreLabel)
        Me.GBoxDatosUser.Controls.Add(Me.NombreTextBox)
        Me.GBoxDatosUser.Controls.Add(ApellidoLabel)
        Me.GBoxDatosUser.Controls.Add(Me.ApellidoTextBox)
        Me.GBoxDatosUser.Controls.Add(CedulaLabel)
        Me.GBoxDatosUser.Controls.Add(Me.CedulaTextBox)
        Me.GBoxDatosUser.Controls.Add(TelefonoLabel)
        Me.GBoxDatosUser.Controls.Add(Me.TelefonoTextBox)
        Me.GBoxDatosUser.Controls.Add(CorreoLabel)
        Me.GBoxDatosUser.Controls.Add(Me.CorreoTextBox)
        Me.GBoxDatosUser.Controls.Add(ContraseñaLabel)
        Me.GBoxDatosUser.Controls.Add(Me.ContraseñaTextBox)
        Me.GBoxDatosUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxDatosUser.Location = New System.Drawing.Point(25, 12)
        Me.GBoxDatosUser.Name = "GBoxDatosUser"
        Me.GBoxDatosUser.Size = New System.Drawing.Size(382, 290)
        Me.GBoxDatosUser.TabIndex = 69
        Me.GBoxDatosUser.TabStop = False
        Me.GBoxDatosUser.Text = "Datos del usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.CdBuscarTextBox)
        Me.GroupBox2.Controls.Add(Me.BuscarBTT)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(462, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 147)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar usuario"
        '
        'UsuarioDataGridView
        '
        Me.UsuarioDataGridView.AllowUserToAddRows = False
        Me.UsuarioDataGridView.AllowUserToDeleteRows = False
        Me.UsuarioDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.UsuarioDataGridView.AutoGenerateColumns = False
        Me.UsuarioDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UsuarioDataGridView.DataSource = Me.UsuarioBindingSource
        Me.UsuarioDataGridView.Location = New System.Drawing.Point(63, 334)
        Me.UsuarioDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.UsuarioDataGridView.Name = "UsuarioDataGridView"
        Me.UsuarioDataGridView.ReadOnly = True
        Me.UsuarioDataGridView.Size = New System.Drawing.Size(643, 251)
        Me.UsuarioDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'Usuario_RolBindingSource
        '
        Me.Usuario_RolBindingSource.DataMember = "Usuario_Rol"
        Me.Usuario_RolBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
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
        'Usuario_RolTableAdapter
        '
        Me.Usuario_RolTableAdapter.ClearBeforeFill = True
        '
        'Usuarios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBoxDatosUser)
        Me.Controls.Add(Me.UsuarioDataGridView)
        Me.Controls.Add(Me.ActualizarBTT)
        Me.Controls.Add(Me.ModificarBTT)
        Me.Controls.Add(Me.EliminarBTT)
        Me.Controls.Add(Me.AgregarBTT)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuarios"
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatosUser.ResumeLayout(False)
        Me.GBoxDatosUser.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuario_RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BDD_Salsamentaria_1DataSet As BDD_Salsamentaria_1DataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AgregarBTT As Button
    Friend WithEvents EliminarBTT As Button
    Friend WithEvents ModificarBTT As Button
    Friend WithEvents BuscarBTT As Button
    Friend WithEvents ActualizarBTT As Button
    Friend WithEvents Usuario_RolBindingSource As BindingSource
    Friend WithEvents Usuario_RolTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.Usuario_RolTableAdapter
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents CedulaTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents CargoComboBox As ComboBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents CdBuscarTextBox As TextBox
    Friend WithEvents GBoxDatosUser As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridView As DataGridView
End Class
