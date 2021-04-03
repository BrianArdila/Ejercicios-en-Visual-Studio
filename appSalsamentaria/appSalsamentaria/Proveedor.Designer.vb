<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim Nombre_EmpresaLabel As System.Windows.Forms.Label
        Dim NITLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim NITLabel1 As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor))
        Me.BuscarBTT = New System.Windows.Forms.Button()
        Me.ModificarBTT = New System.Windows.Forms.Button()
        Me.EliminarBTT = New System.Windows.Forms.Button()
        Me.AgregarBTT = New System.Windows.Forms.Button()
        Me.ActualizarBTT = New System.Windows.Forms.Button()
        Me.BDD_Salsamentaria_1DataSet = New appSalsamentaria.BDD_Salsamentaria_1DataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.ProveedorTableAdapter()
        Me.TableAdapterManager = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NITTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.GBoxDatos = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NITBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        MarcaLabel = New System.Windows.Forms.Label()
        Nombre_EmpresaLabel = New System.Windows.Forms.Label()
        NITLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NITLabel1 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(14, 49)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(52, 19)
        MarcaLabel.TabIndex = 35
        MarcaLabel.Text = "Marca:"
        '
        'Nombre_EmpresaLabel
        '
        Nombre_EmpresaLabel.AutoSize = True
        Nombre_EmpresaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_EmpresaLabel.Location = New System.Drawing.Point(14, 79)
        Nombre_EmpresaLabel.Name = "Nombre_EmpresaLabel"
        Nombre_EmpresaLabel.Size = New System.Drawing.Size(120, 19)
        Nombre_EmpresaLabel.TabIndex = 37
        Nombre_EmpresaLabel.Text = "Nombre Empresa:"
        '
        'NITLabel
        '
        NITLabel.AutoSize = True
        NITLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NITLabel.Location = New System.Drawing.Point(14, 109)
        NITLabel.Name = "NITLabel"
        NITLabel.Size = New System.Drawing.Size(37, 19)
        NITLabel.TabIndex = 39
        NITLabel.Text = "NIT:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(14, 139)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 19)
        TelefonoLabel.TabIndex = 41
        TelefonoLabel.Text = "Telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(14, 169)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(70, 19)
        DireccionLabel.TabIndex = 43
        DireccionLabel.Text = "Direccion:"
        '
        'NITLabel1
        '
        NITLabel1.AutoSize = True
        NITLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NITLabel1.Location = New System.Drawing.Point(21, 24)
        NITLabel1.Name = "NITLabel1"
        NITLabel1.Size = New System.Drawing.Size(37, 19)
        NITLabel1.TabIndex = 47
        NITLabel1.Text = "NIT:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(15, 24)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(25, 19)
        IdLabel.TabIndex = 44
        IdLabel.Text = "Id:"
        '
        'BuscarBTT
        '
        Me.BuscarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBTT.Image = CType(resources.GetObject("BuscarBTT.Image"), System.Drawing.Image)
        Me.BuscarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarBTT.Location = New System.Drawing.Point(136, 78)
        Me.BuscarBTT.Name = "BuscarBTT"
        Me.BuscarBTT.Size = New System.Drawing.Size(122, 54)
        Me.BuscarBTT.TabIndex = 21
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
        Me.ModificarBTT.Location = New System.Drawing.Point(607, 175)
        Me.ModificarBTT.Name = "ModificarBTT"
        Me.ModificarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ModificarBTT.TabIndex = 20
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
        Me.EliminarBTT.Location = New System.Drawing.Point(607, 242)
        Me.EliminarBTT.Name = "EliminarBTT"
        Me.EliminarBTT.Size = New System.Drawing.Size(122, 54)
        Me.EliminarBTT.TabIndex = 19
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
        Me.AgregarBTT.Location = New System.Drawing.Point(452, 175)
        Me.AgregarBTT.Name = "AgregarBTT"
        Me.AgregarBTT.Size = New System.Drawing.Size(122, 54)
        Me.AgregarBTT.TabIndex = 18
        Me.AgregarBTT.Text = "Agregar"
        Me.AgregarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarBTT.UseVisualStyleBackColor = True
        '
        'ActualizarBTT
        '
        Me.ActualizarBTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarBTT.Image = CType(resources.GetObject("ActualizarBTT.Image"), System.Drawing.Image)
        Me.ActualizarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarBTT.Location = New System.Drawing.Point(452, 242)
        Me.ActualizarBTT.Name = "ActualizarBTT"
        Me.ActualizarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ActualizarBTT.TabIndex = 33
        Me.ActualizarBTT.Text = "Actualizar"
        Me.ActualizarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarBTT.UseVisualStyleBackColor = True
        '
        'BDD_Salsamentaria_1DataSet
        '
        Me.BDD_Salsamentaria_1DataSet.DataSetName = "BDD_Salsamentaria_1DataSet"
        Me.BDD_Salsamentaria_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Detalles_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.Inventario_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario_RolTableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AllowUserToAddRows = False
        Me.ProveedorDataGridView.AllowUserToDeleteRows = False
        Me.ProveedorDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(59, 310)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.ReadOnly = True
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(644, 272)
        Me.ProveedorDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre_Empresa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre_Empresa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NIT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NIT"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Marca", True))
        Me.MarcaTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaTextBox.Location = New System.Drawing.Point(138, 46)
        Me.MarcaTextBox.MaxLength = 70
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(246, 26)
        Me.MarcaTextBox.TabIndex = 36
        '
        'Nombre_EmpresaTextBox
        '
        Me.Nombre_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nombre_Empresa", True))
        Me.Nombre_EmpresaTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_EmpresaTextBox.Location = New System.Drawing.Point(138, 76)
        Me.Nombre_EmpresaTextBox.MaxLength = 70
        Me.Nombre_EmpresaTextBox.Name = "Nombre_EmpresaTextBox"
        Me.Nombre_EmpresaTextBox.Size = New System.Drawing.Size(246, 26)
        Me.Nombre_EmpresaTextBox.TabIndex = 38
        '
        'NITTextBox
        '
        Me.NITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "NIT", True))
        Me.NITTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NITTextBox.Location = New System.Drawing.Point(138, 106)
        Me.NITTextBox.MaxLength = 25
        Me.NITTextBox.Name = "NITTextBox"
        Me.NITTextBox.Size = New System.Drawing.Size(246, 26)
        Me.NITTextBox.TabIndex = 40
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(138, 136)
        Me.TelefonoTextBox.MaxLength = 15
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(246, 26)
        Me.TelefonoTextBox.TabIndex = 42
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(138, 166)
        Me.DireccionTextBox.MaxLength = 80
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(246, 26)
        Me.DireccionTextBox.TabIndex = 44
        '
        'GBoxDatos
        '
        Me.GBoxDatos.Controls.Add(IdLabel)
        Me.GBoxDatos.Controls.Add(Me.IdTextBox)
        Me.GBoxDatos.Controls.Add(MarcaLabel)
        Me.GBoxDatos.Controls.Add(Me.MarcaTextBox)
        Me.GBoxDatos.Controls.Add(Nombre_EmpresaLabel)
        Me.GBoxDatos.Controls.Add(Me.Nombre_EmpresaTextBox)
        Me.GBoxDatos.Controls.Add(NITLabel)
        Me.GBoxDatos.Controls.Add(Me.NITTextBox)
        Me.GBoxDatos.Controls.Add(TelefonoLabel)
        Me.GBoxDatos.Controls.Add(Me.TelefonoTextBox)
        Me.GBoxDatos.Controls.Add(DireccionLabel)
        Me.GBoxDatos.Controls.Add(Me.DireccionTextBox)
        Me.GBoxDatos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxDatos.Location = New System.Drawing.Point(25, 25)
        Me.GBoxDatos.Name = "GBoxDatos"
        Me.GBoxDatos.Size = New System.Drawing.Size(404, 212)
        Me.GBoxDatos.TabIndex = 47
        Me.GBoxDatos.TabStop = False
        Me.GBoxDatos.Text = "Datos del proveedor"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(138, 18)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(246, 26)
        Me.IdTextBox.TabIndex = 45
        '
        'NITBuscarTextBox
        '
        Me.NITBuscarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "NIT", True))
        Me.NITBuscarTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NITBuscarTextBox.Location = New System.Drawing.Point(25, 46)
        Me.NITBuscarTextBox.MaxLength = 25
        Me.NITBuscarTextBox.Name = "NITBuscarTextBox"
        Me.NITBuscarTextBox.Size = New System.Drawing.Size(233, 26)
        Me.NITBuscarTextBox.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(NITLabel1)
        Me.GroupBox2.Controls.Add(Me.NITBuscarTextBox)
        Me.GroupBox2.Controls.Add(Me.BuscarBTT)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(450, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 144)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar proveedor"
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBoxDatos)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.ActualizarBTT)
        Me.Controls.Add(Me.ModificarBTT)
        Me.Controls.Add(Me.EliminarBTT)
        Me.Controls.Add(Me.AgregarBTT)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Proveedor"
        Me.ShowIcon = False
        Me.Text = "Proveedor"
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatos.ResumeLayout(False)
        Me.GBoxDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BuscarBTT As Button
    Friend WithEvents ModificarBTT As Button
    Friend WithEvents EliminarBTT As Button
    Friend WithEvents AgregarBTT As Button
    Friend WithEvents ActualizarBTT As Button
    Friend WithEvents BDD_Salsamentaria_1DataSet As BDD_Salsamentaria_1DataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents TableAdapterManager As BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents Nombre_EmpresaTextBox As TextBox
    Friend WithEvents NITTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents GBoxDatos As GroupBox
    Friend WithEvents NITBuscarTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
End Class
