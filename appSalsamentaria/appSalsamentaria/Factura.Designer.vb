<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
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
        Dim N_FacturaLabel As System.Windows.Forms.Label
        Dim Referencia_ProductoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Vlr_UnidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Dim Forma_PagoLabel As System.Windows.Forms.Label
        Me.N_FacturaTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_Salsamentaria_1DataSet = New appSalsamentaria.BDD_Salsamentaria_1DataSet()
        Me.NuevoBTT = New System.Windows.Forms.Button()
        Me.RegistrarBTT = New System.Windows.Forms.Button()
        Me.AgregarBTT = New System.Windows.Forms.Button()
        Me.BuscarBTT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Vlr_UnidadTextBox = New System.Windows.Forms.TextBox()
        Me.Detalles_PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Referencia_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.RefProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VlrUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.BuscarClienteBTT = New System.Windows.Forms.Button()
        Me.FacturaTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager()
        Me.InventarioTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.InventarioTableAdapter()
        Me.ClienteTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.ClienteTableAdapter()
        Me.Detalles_PedidoTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.Detalles_PedidoTableAdapter()
        Me.Detalles_PedidoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModificarBTT = New System.Windows.Forms.Button()
        Me.Forma_PagoCheckBox = New System.Windows.Forms.CheckBox()
        N_FacturaLabel = New System.Windows.Forms.Label()
        Referencia_ProductoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Vlr_UnidadLabel = New System.Windows.Forms.Label()
        Forma_PagoLabel = New System.Windows.Forms.Label()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Detalles_PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalles_PedidoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_FacturaLabel
        '
        N_FacturaLabel.AutoSize = True
        N_FacturaLabel.Location = New System.Drawing.Point(11, 30)
        N_FacturaLabel.Name = "N_FacturaLabel"
        N_FacturaLabel.Size = New System.Drawing.Size(74, 19)
        N_FacturaLabel.TabIndex = 3
        N_FacturaLabel.Text = "N Factura:"
        '
        'Referencia_ProductoLabel
        '
        Referencia_ProductoLabel.AutoSize = True
        Referencia_ProductoLabel.Location = New System.Drawing.Point(11, 26)
        Referencia_ProductoLabel.Name = "Referencia_ProductoLabel"
        Referencia_ProductoLabel.Size = New System.Drawing.Size(136, 19)
        Referencia_ProductoLabel.TabIndex = 0
        Referencia_ProductoLabel.Text = "Referencia Producto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(189, 32)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(63, 19)
        NombreLabel.TabIndex = 40
        NombreLabel.Text = "Nombre:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(11, 32)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(63, 19)
        NombreLabel1.TabIndex = 39
        NombreLabel1.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(214, 32)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(63, 19)
        ApellidoLabel.TabIndex = 40
        ApellidoLabel.Text = "Apellido:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(420, 31)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(55, 19)
        CedulaLabel.TabIndex = 41
        CedulaLabel.Text = "Cedula:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(11, 33)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(67, 19)
        CantidadLabel.TabIndex = 41
        CantidadLabel.Text = "Cantidad:"
        '
        'Vlr_UnidadLabel
        '
        Vlr_UnidadLabel.AutoSize = True
        Vlr_UnidadLabel.Location = New System.Drawing.Point(444, 32)
        Vlr_UnidadLabel.Name = "Vlr_UnidadLabel"
        Vlr_UnidadLabel.Size = New System.Drawing.Size(79, 19)
        Vlr_UnidadLabel.TabIndex = 42
        Vlr_UnidadLabel.Text = "Vlr Unidad:"
        '
        'N_FacturaTextBox
        '
        Me.N_FacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "N_Factura", True))
        Me.N_FacturaTextBox.Location = New System.Drawing.Point(91, 27)
        Me.N_FacturaTextBox.Name = "N_FacturaTextBox"
        Me.N_FacturaTextBox.Size = New System.Drawing.Size(109, 26)
        Me.N_FacturaTextBox.TabIndex = 4
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'BDD_Salsamentaria_1DataSet
        '
        Me.BDD_Salsamentaria_1DataSet.DataSetName = "BDD_Salsamentaria_1DataSet"
        Me.BDD_Salsamentaria_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NuevoBTT
        '
        Me.NuevoBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoBTT.Image = CType(resources.GetObject("NuevoBTT.Image"), System.Drawing.Image)
        Me.NuevoBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NuevoBTT.Location = New System.Drawing.Point(634, 15)
        Me.NuevoBTT.Name = "NuevoBTT"
        Me.NuevoBTT.Size = New System.Drawing.Size(122, 54)
        Me.NuevoBTT.TabIndex = 37
        Me.NuevoBTT.Text = "Nuevo"
        Me.NuevoBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NuevoBTT.UseVisualStyleBackColor = True
        '
        'RegistrarBTT
        '
        Me.RegistrarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistrarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarBTT.Image = CType(resources.GetObject("RegistrarBTT.Image"), System.Drawing.Image)
        Me.RegistrarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RegistrarBTT.Location = New System.Drawing.Point(1074, 590)
        Me.RegistrarBTT.Name = "RegistrarBTT"
        Me.RegistrarBTT.Size = New System.Drawing.Size(122, 54)
        Me.RegistrarBTT.TabIndex = 36
        Me.RegistrarBTT.Text = "Registrar"
        Me.RegistrarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RegistrarBTT.UseVisualStyleBackColor = True
        '
        'AgregarBTT
        '
        Me.AgregarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBTT.Image = CType(resources.GetObject("AgregarBTT.Image"), System.Drawing.Image)
        Me.AgregarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarBTT.Location = New System.Drawing.Point(762, 14)
        Me.AgregarBTT.Name = "AgregarBTT"
        Me.AgregarBTT.Size = New System.Drawing.Size(122, 54)
        Me.AgregarBTT.TabIndex = 34
        Me.AgregarBTT.Text = "Agregar"
        Me.AgregarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarBTT.UseVisualStyleBackColor = True
        '
        'BuscarBTT
        '
        Me.BuscarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBTT.Image = CType(resources.GetObject("BuscarBTT.Image"), System.Drawing.Image)
        Me.BuscarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarBTT.Location = New System.Drawing.Point(129, 56)
        Me.BuscarBTT.Name = "BuscarBTT"
        Me.BuscarBTT.Size = New System.Drawing.Size(122, 54)
        Me.BuscarBTT.TabIndex = 38
        Me.BuscarBTT.Text = "Buscar"
        Me.BuscarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarBTT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Vlr_UnidadLabel)
        Me.GroupBox1.Controls.Add(Me.Vlr_UnidadTextBox)
        Me.GroupBox1.Controls.Add(CantidadLabel)
        Me.GroupBox1.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.NuevoBTT)
        Me.GroupBox1.Controls.Add(Me.AgregarBTT)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 89)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripción"
        '
        'Vlr_UnidadTextBox
        '
        Me.Vlr_UnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalles_PedidoBindingSource, "Vlr_Unidad", True))
        Me.Vlr_UnidadTextBox.Location = New System.Drawing.Point(529, 29)
        Me.Vlr_UnidadTextBox.Name = "Vlr_UnidadTextBox"
        Me.Vlr_UnidadTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Vlr_UnidadTextBox.TabIndex = 43
        '
        'Detalles_PedidoBindingSource
        '
        Me.Detalles_PedidoBindingSource.DataMember = "FacturaDetalles_Pedido"
        Me.Detalles_PedidoBindingSource.DataSource = Me.FacturaBindingSource
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalles_PedidoBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(84, 30)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CantidadTextBox.TabIndex = 42
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(258, 29)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(179, 26)
        Me.NombreTextBox.TabIndex = 41
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Referencia_ProductoLabel)
        Me.GroupBox2.Controls.Add(Me.Referencia_ProductoTextBox)
        Me.GroupBox2.Controls.Add(Me.BuscarBTT)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(939, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 122)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Producto"
        '
        'Referencia_ProductoTextBox
        '
        Me.Referencia_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Referencia_Producto", True))
        Me.Referencia_ProductoTextBox.Location = New System.Drawing.Point(151, 22)
        Me.Referencia_ProductoTextBox.Name = "Referencia_ProductoTextBox"
        Me.Referencia_ProductoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Referencia_ProductoTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ModificarBTT)
        Me.GroupBox3.Controls.Add(Me.Forma_PagoCheckBox)
        Me.GroupBox3.Controls.Add(Forma_PagoLabel)
        Me.GroupBox3.Controls.Add(Me.N_FacturaTextBox)
        Me.GroupBox3.Controls.Add(N_FacturaLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 73)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factura"
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AllowUserToAddRows = False
        Me.FacturaDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RefProducto, Me.Cantidad, Me.Nombre, Me.VlrUnidad, Me.Eliminar})
        Me.FacturaDataGridView.Location = New System.Drawing.Point(81, 266)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.ReadOnly = True
        Me.FacturaDataGridView.Size = New System.Drawing.Size(1044, 318)
        Me.FacturaDataGridView.TabIndex = 44
        '
        'RefProducto
        '
        Me.RefProducto.HeaderText = "Ref Producto"
        Me.RefProducto.Name = "RefProducto"
        Me.RefProducto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 150
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 500
        '
        'VlrUnidad
        '
        Me.VlrUnidad.HeaderText = "Vlr Unidad"
        Me.VlrUnidad.Name = "VlrUnidad"
        Me.VlrUnidad.ReadOnly = True
        Me.VlrUnidad.Width = 150
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.ToolTipText = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(877, 590)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 44)
        Me.TextBox1.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(762, 590)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 42)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Total: "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(CedulaLabel)
        Me.GroupBox4.Controls.Add(Me.CedulaTextBox)
        Me.GroupBox4.Controls.Add(ApellidoLabel)
        Me.GroupBox4.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox4.Controls.Add(NombreLabel1)
        Me.GroupBox4.Controls.Add(Me.NombreTextBox1)
        Me.GroupBox4.Controls.Add(Me.BuscarClienteBTT)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(748, 74)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(481, 29)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(124, 26)
        Me.CedulaTextBox.TabIndex = 42
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(283, 29)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.ReadOnly = True
        Me.ApellidoTextBox.Size = New System.Drawing.Size(131, 26)
        Me.ApellidoTextBox.TabIndex = 41
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(80, 29)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.ReadOnly = True
        Me.NombreTextBox1.Size = New System.Drawing.Size(128, 26)
        Me.NombreTextBox1.TabIndex = 40
        '
        'BuscarClienteBTT
        '
        Me.BuscarClienteBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarClienteBTT.Image = CType(resources.GetObject("BuscarClienteBTT.Image"), System.Drawing.Image)
        Me.BuscarClienteBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarClienteBTT.Location = New System.Drawing.Point(611, 13)
        Me.BuscarClienteBTT.Name = "BuscarClienteBTT"
        Me.BuscarClienteBTT.Size = New System.Drawing.Size(122, 54)
        Me.BuscarClienteBTT.TabIndex = 39
        Me.BuscarClienteBTT.Text = "Buscar"
        Me.BuscarClienteBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarClienteBTT.UseVisualStyleBackColor = True
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.Inventario_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario_RolTableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Detalles_PedidoTableAdapter
        '
        Me.Detalles_PedidoTableAdapter.ClearBeforeFill = True
        '
        'Detalles_PedidoBindingSource1
        '
        Me.Detalles_PedidoBindingSource1.DataSource = Me.BDD_Salsamentaria_1DataSet
        Me.Detalles_PedidoBindingSource1.Position = 0
        '
        'ModificarBTT
        '
        Me.ModificarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarBTT.Image = CType(resources.GetObject("ModificarBTT.Image"), System.Drawing.Image)
        Me.ModificarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarBTT.Location = New System.Drawing.Point(401, 12)
        Me.ModificarBTT.Name = "ModificarBTT"
        Me.ModificarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ModificarBTT.TabIndex = 48
        Me.ModificarBTT.Text = "Modificar"
        Me.ModificarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarBTT.UseVisualStyleBackColor = True
        '
        'Forma_PagoCheckBox
        '
        Me.Forma_PagoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FacturaBindingSource, "Forma_Pago", True))
        Me.Forma_PagoCheckBox.Location = New System.Drawing.Point(307, 27)
        Me.Forma_PagoCheckBox.Name = "Forma_PagoCheckBox"
        Me.Forma_PagoCheckBox.Size = New System.Drawing.Size(94, 24)
        Me.Forma_PagoCheckBox.TabIndex = 6
        Me.Forma_PagoCheckBox.Text = "Credito"
        Me.Forma_PagoCheckBox.UseVisualStyleBackColor = True
        '
        'Forma_PagoLabel
        '
        Forma_PagoLabel.AutoSize = True
        Forma_PagoLabel.Location = New System.Drawing.Point(214, 29)
        Forma_PagoLabel.Name = "Forma_PagoLabel"
        Forma_PagoLabel.Size = New System.Drawing.Size(87, 19)
        Forma_PagoLabel.TabIndex = 5
        Forma_PagoLabel.Text = "Forma Pago:"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 657)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RegistrarBTT)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Factura"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Detalles_PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalles_PedidoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDD_Salsamentaria_1DataSet As BDD_Salsamentaria_1DataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager As BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents N_FacturaTextBox As TextBox
    Friend WithEvents NuevoBTT As Button
    Friend WithEvents RegistrarBTT As Button
    Friend WithEvents AgregarBTT As Button
    Friend WithEvents BuscarBTT As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InventarioTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Referencia_ProductoTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BuscarClienteBTT As Button
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents CedulaTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents RefProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents VlrUnidad As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Detalles_PedidoTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.Detalles_PedidoTableAdapter
    Friend WithEvents Detalles_PedidoBindingSource1 As BindingSource
    Friend WithEvents Detalles_PedidoBindingSource As BindingSource
    Friend WithEvents Vlr_UnidadTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents ModificarBTT As Button
    Friend WithEvents Forma_PagoCheckBox As CheckBox
End Class
