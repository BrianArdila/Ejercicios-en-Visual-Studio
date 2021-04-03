<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
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
        Dim Referencia_ProductoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim DescripciónLabel As System.Windows.Forms.Label
        Dim Vlr_CompraLabel As System.Windows.Forms.Label
        Dim Venta_PesoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Referencia_ProductoLabel1 As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.Referencia_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_Salsamentaria_1DataSet = New appSalsamentaria.BDD_Salsamentaria_1DataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.DescripciónTextBox = New System.Windows.Forms.TextBox()
        Me.Vlr_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.Venta_PesoCheckBox = New System.Windows.Forms.CheckBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.GBoxDatosUser = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.InventarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualizarBTT = New System.Windows.Forms.Button()
        Me.BuscarBTT = New System.Windows.Forms.Button()
        Me.ModificarBTT = New System.Windows.Forms.Button()
        Me.EliminarBTT = New System.Windows.Forms.Button()
        Me.AgregarBTT = New System.Windows.Forms.Button()
        Me.R_PBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.InventarioTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.InventarioTableAdapter()
        Me.TableAdapterManager = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager()
        Referencia_ProductoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        DescripciónLabel = New System.Windows.Forms.Label()
        Vlr_CompraLabel = New System.Windows.Forms.Label()
        Venta_PesoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Referencia_ProductoLabel1 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatosUser.SuspendLayout()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Referencia_ProductoLabel
        '
        Referencia_ProductoLabel.AutoSize = True
        Referencia_ProductoLabel.Location = New System.Drawing.Point(18, 57)
        Referencia_ProductoLabel.Name = "Referencia_ProductoLabel"
        Referencia_ProductoLabel.Size = New System.Drawing.Size(136, 19)
        Referencia_ProductoLabel.TabIndex = 24
        Referencia_ProductoLabel.Text = "Referencia Producto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(18, 89)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(63, 19)
        NombreLabel.TabIndex = 26
        NombreLabel.Text = "Nombre:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Location = New System.Drawing.Point(18, 121)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(52, 19)
        ActivoLabel.TabIndex = 28
        ActivoLabel.Text = "Activo:"
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.Location = New System.Drawing.Point(18, 154)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(84, 19)
        DescripciónLabel.TabIndex = 30
        DescripciónLabel.Text = "Descripción:"
        '
        'Vlr_CompraLabel
        '
        Vlr_CompraLabel.AutoSize = True
        Vlr_CompraLabel.Location = New System.Drawing.Point(18, 184)
        Vlr_CompraLabel.Name = "Vlr_CompraLabel"
        Vlr_CompraLabel.Size = New System.Drawing.Size(81, 19)
        Vlr_CompraLabel.TabIndex = 32
        Vlr_CompraLabel.Text = "vlr Compra:"
        '
        'Venta_PesoLabel
        '
        Venta_PesoLabel.AutoSize = True
        Venta_PesoLabel.Location = New System.Drawing.Point(18, 225)
        Venta_PesoLabel.Name = "Venta_PesoLabel"
        Venta_PesoLabel.Size = New System.Drawing.Size(80, 19)
        Venta_PesoLabel.TabIndex = 40
        Venta_PesoLabel.Text = "Venta Peso:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(18, 257)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(67, 19)
        CantidadLabel.TabIndex = 42
        CantidadLabel.Text = "Cantidad:"
        '
        'Referencia_ProductoLabel1
        '
        Referencia_ProductoLabel1.AutoSize = True
        Referencia_ProductoLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Referencia_ProductoLabel1.Location = New System.Drawing.Point(22, 22)
        Referencia_ProductoLabel1.Name = "Referencia_ProductoLabel1"
        Referencia_ProductoLabel1.Size = New System.Drawing.Size(136, 19)
        Referencia_ProductoLabel1.TabIndex = 56
        Referencia_ProductoLabel1.Text = "Referencia Producto:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(18, 30)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(25, 19)
        IdLabel.TabIndex = 43
        IdLabel.Text = "Id:"
        '
        'Referencia_ProductoTextBox
        '
        Me.Referencia_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Referencia_Producto", True))
        Me.Referencia_ProductoTextBox.Location = New System.Drawing.Point(156, 55)
        Me.Referencia_ProductoTextBox.MaxLength = 20
        Me.Referencia_ProductoTextBox.Name = "Referencia_ProductoTextBox"
        Me.Referencia_ProductoTextBox.Size = New System.Drawing.Size(233, 26)
        Me.Referencia_ProductoTextBox.TabIndex = 25
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'BDD_Salsamentaria_1DataSet
        '
        Me.BDD_Salsamentaria_1DataSet.DataSetName = "BDD_Salsamentaria_1DataSet"
        Me.BDD_Salsamentaria_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(156, 87)
        Me.NombreTextBox.MaxLength = 50
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(233, 26)
        Me.NombreTextBox.TabIndex = 27
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.InventarioBindingSource, "Activo", True))
        Me.ActivoCheckBox.Location = New System.Drawing.Point(156, 117)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(233, 28)
        Me.ActivoCheckBox.TabIndex = 29
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'DescripciónTextBox
        '
        Me.DescripciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Descripción", True))
        Me.DescripciónTextBox.Location = New System.Drawing.Point(156, 151)
        Me.DescripciónTextBox.MaxLength = 255
        Me.DescripciónTextBox.Name = "DescripciónTextBox"
        Me.DescripciónTextBox.Size = New System.Drawing.Size(233, 26)
        Me.DescripciónTextBox.TabIndex = 31
        '
        'Vlr_CompraTextBox
        '
        Me.Vlr_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "vlr_Compra", True))
        Me.Vlr_CompraTextBox.Location = New System.Drawing.Point(156, 181)
        Me.Vlr_CompraTextBox.Name = "Vlr_CompraTextBox"
        Me.Vlr_CompraTextBox.Size = New System.Drawing.Size(233, 26)
        Me.Vlr_CompraTextBox.TabIndex = 33
        '
        'Venta_PesoCheckBox
        '
        Me.Venta_PesoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.InventarioBindingSource, "Venta_Peso", True))
        Me.Venta_PesoCheckBox.Location = New System.Drawing.Point(156, 220)
        Me.Venta_PesoCheckBox.Name = "Venta_PesoCheckBox"
        Me.Venta_PesoCheckBox.Size = New System.Drawing.Size(233, 28)
        Me.Venta_PesoCheckBox.TabIndex = 41
        Me.Venta_PesoCheckBox.Text = "Por peso"
        Me.Venta_PesoCheckBox.UseVisualStyleBackColor = True
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(156, 255)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(233, 26)
        Me.CantidadTextBox.TabIndex = 43
        '
        'GBoxDatosUser
        '
        Me.GBoxDatosUser.Controls.Add(IdLabel)
        Me.GBoxDatosUser.Controls.Add(Me.IdTextBox)
        Me.GBoxDatosUser.Controls.Add(Referencia_ProductoLabel)
        Me.GBoxDatosUser.Controls.Add(Me.Referencia_ProductoTextBox)
        Me.GBoxDatosUser.Controls.Add(NombreLabel)
        Me.GBoxDatosUser.Controls.Add(Me.NombreTextBox)
        Me.GBoxDatosUser.Controls.Add(ActivoLabel)
        Me.GBoxDatosUser.Controls.Add(Me.ActivoCheckBox)
        Me.GBoxDatosUser.Controls.Add(DescripciónLabel)
        Me.GBoxDatosUser.Controls.Add(Me.DescripciónTextBox)
        Me.GBoxDatosUser.Controls.Add(Vlr_CompraLabel)
        Me.GBoxDatosUser.Controls.Add(Me.Vlr_CompraTextBox)
        Me.GBoxDatosUser.Controls.Add(Venta_PesoLabel)
        Me.GBoxDatosUser.Controls.Add(Me.Venta_PesoCheckBox)
        Me.GBoxDatosUser.Controls.Add(CantidadLabel)
        Me.GBoxDatosUser.Controls.Add(Me.CantidadTextBox)
        Me.GBoxDatosUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxDatosUser.Location = New System.Drawing.Point(14, 12)
        Me.GBoxDatosUser.Name = "GBoxDatosUser"
        Me.GBoxDatosUser.Size = New System.Drawing.Size(409, 293)
        Me.GBoxDatosUser.TabIndex = 49
        Me.GBoxDatosUser.TabStop = False
        Me.GBoxDatosUser.Text = "Datos del producto"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(156, 23)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(233, 26)
        Me.IdTextBox.TabIndex = 44
        '
        'InventarioDataGridView
        '
        Me.InventarioDataGridView.AllowUserToAddRows = False
        Me.InventarioDataGridView.AllowUserToDeleteRows = False
        Me.InventarioDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.InventarioDataGridView.AutoGenerateColumns = False
        Me.InventarioDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.InventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9})
        Me.InventarioDataGridView.DataSource = Me.InventarioBindingSource
        Me.InventarioDataGridView.Location = New System.Drawing.Point(33, 364)
        Me.InventarioDataGridView.Name = "InventarioDataGridView"
        Me.InventarioDataGridView.ReadOnly = True
        Me.InventarioDataGridView.Size = New System.Drawing.Size(799, 220)
        Me.InventarioDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Referencia_Producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Referencia_Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripción"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "vlr_Compra"
        Me.DataGridViewTextBoxColumn5.HeaderText = "vlr_Compra"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'ActualizarBTT
        '
        Me.ActualizarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarBTT.Image = CType(resources.GetObject("ActualizarBTT.Image"), System.Drawing.Image)
        Me.ActualizarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarBTT.Location = New System.Drawing.Point(483, 268)
        Me.ActualizarBTT.Name = "ActualizarBTT"
        Me.ActualizarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ActualizarBTT.TabIndex = 56
        Me.ActualizarBTT.Text = "Actualizar"
        Me.ActualizarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarBTT.UseVisualStyleBackColor = True
        '
        'BuscarBTT
        '
        Me.BuscarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBTT.Image = CType(resources.GetObject("BuscarBTT.Image"), System.Drawing.Image)
        Me.BuscarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarBTT.Location = New System.Drawing.Point(137, 78)
        Me.BuscarBTT.Name = "BuscarBTT"
        Me.BuscarBTT.Size = New System.Drawing.Size(122, 54)
        Me.BuscarBTT.TabIndex = 55
        Me.BuscarBTT.Text = "Buscar"
        Me.BuscarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarBTT.UseVisualStyleBackColor = True
        '
        'ModificarBTT
        '
        Me.ModificarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarBTT.Image = CType(resources.GetObject("ModificarBTT.Image"), System.Drawing.Image)
        Me.ModificarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarBTT.Location = New System.Drawing.Point(638, 206)
        Me.ModificarBTT.Name = "ModificarBTT"
        Me.ModificarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ModificarBTT.TabIndex = 54
        Me.ModificarBTT.Text = "Modificar"
        Me.ModificarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarBTT.UseVisualStyleBackColor = True
        '
        'EliminarBTT
        '
        Me.EliminarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EliminarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarBTT.Image = CType(resources.GetObject("EliminarBTT.Image"), System.Drawing.Image)
        Me.EliminarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarBTT.Location = New System.Drawing.Point(638, 268)
        Me.EliminarBTT.Name = "EliminarBTT"
        Me.EliminarBTT.Size = New System.Drawing.Size(122, 54)
        Me.EliminarBTT.TabIndex = 53
        Me.EliminarBTT.Text = "Eliminar"
        Me.EliminarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarBTT.UseVisualStyleBackColor = True
        '
        'AgregarBTT
        '
        Me.AgregarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBTT.Image = CType(resources.GetObject("AgregarBTT.Image"), System.Drawing.Image)
        Me.AgregarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarBTT.Location = New System.Drawing.Point(483, 206)
        Me.AgregarBTT.Name = "AgregarBTT"
        Me.AgregarBTT.Size = New System.Drawing.Size(122, 54)
        Me.AgregarBTT.TabIndex = 52
        Me.AgregarBTT.Text = "Agregar"
        Me.AgregarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarBTT.UseVisualStyleBackColor = True
        '
        'R_PBuscarTextBox
        '
        Me.R_PBuscarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Referencia_Producto", True))
        Me.R_PBuscarTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_PBuscarTextBox.Location = New System.Drawing.Point(26, 44)
        Me.R_PBuscarTextBox.Name = "R_PBuscarTextBox"
        Me.R_PBuscarTextBox.Size = New System.Drawing.Size(233, 26)
        Me.R_PBuscarTextBox.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Referencia_ProductoLabel1)
        Me.GroupBox3.Controls.Add(Me.R_PBuscarTextBox)
        Me.GroupBox3.Controls.Add(Me.BuscarBTT)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(501, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 149)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar producto"
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.Inventario_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario_RolTableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(856, 596)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ActualizarBTT)
        Me.Controls.Add(Me.ModificarBTT)
        Me.Controls.Add(Me.EliminarBTT)
        Me.Controls.Add(Me.AgregarBTT)
        Me.Controls.Add(Me.InventarioDataGridView)
        Me.Controls.Add(Me.GBoxDatosUser)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Inventario"
        Me.ShowIcon = False
        Me.Text = "Inventario"
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatosUser.ResumeLayout(False)
        Me.GBoxDatosUser.PerformLayout()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BDD_Salsamentaria_1DataSet As BDD_Salsamentaria_1DataSet
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents InventarioTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents TableAdapterManager As BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Referencia_ProductoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ActivoCheckBox As CheckBox
    Friend WithEvents DescripciónTextBox As TextBox
    Friend WithEvents Vlr_CompraTextBox As TextBox
    Friend WithEvents Venta_PesoCheckBox As CheckBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents GBoxDatosUser As GroupBox
    Friend WithEvents InventarioDataGridView As DataGridView
    Friend WithEvents ActualizarBTT As Button
    Friend WithEvents BuscarBTT As Button
    Friend WithEvents ModificarBTT As Button
    Friend WithEvents EliminarBTT As Button
    Friend WithEvents AgregarBTT As Button
    Friend WithEvents R_PBuscarTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
