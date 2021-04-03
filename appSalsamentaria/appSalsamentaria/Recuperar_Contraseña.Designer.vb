<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recuperar_Contraseña
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
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.BDD_Salsamentaria_1DataSet = New appSalsamentaria.BDD_Salsamentaria_1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New appSalsamentaria.BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.EnviarBTT = New System.Windows.Forms.Button()
        CorreoLabel = New System.Windows.Forms.Label()
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CorreoLabel
        '
        CorreoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CorreoLabel.AutoSize = True
        CorreoLabel.BackColor = System.Drawing.Color.Transparent
        CorreoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(35, 45)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(116, 19)
        CorreoLabel.TabIndex = 3
        CorreoLabel.Text = "Ingresa tu Correo"
        '
        'BDD_Salsamentaria_1DataSet
        '
        Me.BDD_Salsamentaria_1DataSet.DataSetName = "BDD_Salsamentaria_1DataSet"
        Me.BDD_Salsamentaria_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.BDD_Salsamentaria_1DataSet
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
        'CorreoTextBox
        '
        Me.CorreoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Correo", True))
        Me.CorreoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextBox.Location = New System.Drawing.Point(39, 67)
        Me.CorreoTextBox.MaxLength = 41
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(202, 26)
        Me.CorreoTextBox.TabIndex = 4
        '
        'EnviarBTT
        '
        Me.EnviarBTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnviarBTT.Location = New System.Drawing.Point(39, 109)
        Me.EnviarBTT.Name = "EnviarBTT"
        Me.EnviarBTT.Size = New System.Drawing.Size(202, 32)
        Me.EnviarBTT.TabIndex = 5
        Me.EnviarBTT.Text = "Enviar"
        Me.EnviarBTT.UseVisualStyleBackColor = True
        '
        'Recuperar_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 199)
        Me.Controls.Add(Me.EnviarBTT)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.MaximizeBox = False
        Me.Name = "Recuperar_Contraseña"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar contraseña"
        CType(Me.BDD_Salsamentaria_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDD_Salsamentaria_1DataSet As BDD_Salsamentaria_1DataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As BDD_Salsamentaria_1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As BDD_Salsamentaria_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents EnviarBTT As Button
End Class
