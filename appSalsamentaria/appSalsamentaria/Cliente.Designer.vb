<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim CedulaLabel1 As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente))
        Me.BDD_Salsamentaria_1DataSet = New appSalsamentaria.BDD_Salsamentaria_1DataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager()
        Me.BuscarBTT = New System.Windows.Forms.Button()
        Me.ModificarBTT = New System.Windows.Forms.Button()
        Me.EliminarBTT = New System.Windows.Forms.Button()
        Me.AgregarBTT = New System.Windows.Forms.Button()
        Me.ActualizarBTT = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBoxDatos = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CdBuscarTextBox = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        CedulaLabel1 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(7, 51)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(63, 19)
        NombreLabel.TabIndex = 35
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(7, 81)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(63, 19)
        ApellidoLabel.TabIndex = 37
        ApellidoLabel.Text = "Apellido:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CedulaLabel.Location = New System.Drawing.Point(7, 111)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(55, 19)
        CedulaLabel.TabIndex = 39
        CedulaLabel.Text = "Cedula:"
        '
        'CedulaLabel1
        '
        CedulaLabel1.AutoSize = True
        CedulaLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CedulaLabel1.Location = New System.Drawing.Point(13, 24)
        CedulaLabel1.Name = "CedulaLabel1"
        CedulaLabel1.Size = New System.Drawing.Size(55, 19)
        CedulaLabel1.TabIndex = 21
        CedulaLabel1.Text = "Cedula:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(7, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(25, 19)
        IdLabel.TabIndex = 40
        IdLabel.Text = "Id:"
        '
        'BDD_Salsamentaria_1DataSet
        '
        Me.BDD_Salsamentaria_1DataSet.DataSetName = "BDD_Salsamentaria_1DataSet"
        Me.BDD_Salsamentaria_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.Detalles_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.Inventario_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario_RolTableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'BuscarBTT
        '
        Me.BuscarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarBTT.Image = CType(resources.GetObject("BuscarBTT.Image"), System.Drawing.Image)
        Me.BuscarBTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarBTT.Location = New System.Drawing.Point(128, 78)
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
        Me.ModificarBTT.Location = New System.Drawing.Point(582, 159)
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
        Me.EliminarBTT.Location = New System.Drawing.Point(582, 227)
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
        Me.AgregarBTT.Location = New System.Drawing.Point(419, 156)
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
        Me.ActualizarBTT.Location = New System.Drawing.Point(419, 227)
        Me.ActualizarBTT.Name = "ActualizarBTT"
        Me.ActualizarBTT.Size = New System.Drawing.Size(122, 54)
        Me.ActualizarBTT.TabIndex = 33
        Me.ActualizarBTT.Text = "Actualizar"
        Me.ActualizarBTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActualizarBTT.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(105, 47)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(233, 26)
        Me.NombreTextBox.TabIndex = 36
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(105, 77)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(233, 26)
        Me.ApellidoTextBox.TabIndex = 38
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cedula", True))
        Me.CedulaTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CedulaTextBox.Location = New System.Drawing.Point(105, 107)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(233, 26)
        Me.CedulaTextBox.TabIndex = 40
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(142, 287)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        Me.ClienteDataGridView.Size = New System.Drawing.Size(444, 292)
        Me.ClienteDataGridView.TabIndex = 42
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'GBoxDatos
        '
        Me.GBoxDatos.Controls.Add(IdLabel)
        Me.GBoxDatos.Controls.Add(Me.IdTextBox)
        Me.GBoxDatos.Controls.Add(NombreLabel)
        Me.GBoxDatos.Controls.Add(Me.NombreTextBox)
        Me.GBoxDatos.Controls.Add(ApellidoLabel)
        Me.GBoxDatos.Controls.Add(Me.ApellidoTextBox)
        Me.GBoxDatos.Controls.Add(CedulaLabel)
        Me.GBoxDatos.Controls.Add(Me.CedulaTextBox)
        Me.GBoxDatos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxDatos.Location = New System.Drawing.Point(28, 58)
        Me.GBoxDatos.Name = "GBoxDatos"
        Me.GBoxDatos.Size = New System.Drawing.Size(358, 153)
        Me.GBoxDatos.TabIndex = 43
        Me.GBoxDatos.TabStop = False
        Me.GBoxDatos.Text = "Datos del cliente"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(105, 20)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(233, 26)
        Me.IdTextBox.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(CedulaLabel1)
        Me.GroupBox2.Controls.Add(Me.CdBuscarTextBox)
        Me.GroupBox2.Controls.Add(Me.BuscarBTT)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(435, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 138)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar cliente"
        '
        'CdBuscarTextBox
        '
        Me.CdBuscarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cedula", True))
        Me.CdBuscarTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdBuscarTextBox.Location = New System.Drawing.Point(17, 46)
        Me.CdBuscarTextBox.Name = "CdBuscarTextBox"
        Me.CdBuscarTextBox.Size = New System.Drawing.Size(233, 26)
        Me.CdBuscarTextBox.TabIndex = 22
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(745, 591)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBoxDatos)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.ActualizarBTT)
        Me.Controls.Add(Me.ModificarBTT)
        Me.Controls.Add(Me.EliminarBTT)
        Me.Controls.Add(Me.AgregarBTT)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cliente"
        Me.ShowIcon = False
        Me.Text = "Cliente"
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatos.ResumeLayout(False)
        Me.GBoxDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BDD_Salsamentaria_1DataSet As BDD_Salsamentaria_1DataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuscarBTT As Button
    Friend WithEvents ModificarBTT As Button
    Friend WithEvents EliminarBTT As Button
    Friend WithEvents AgregarBTT As Button
    Friend WithEvents ActualizarBTT As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents CedulaTextBox As TextBox
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents GBoxDatos As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CdBuscarTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
End Class
