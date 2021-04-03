Public Class Factura
    'Determina si el formulario se relleno
    Dim FormLleno = 0
    ''' <summary>
    ''' Revisa si los textbox tienen información
    ''' </summary>
    ''' <param name="Vacio"></param>
    Private Sub RevisarTexTBox(ByVal Vacio As Control)
        'Quita el texto de los textbox
        If (Vacio.GetType.Name = "TextBox") Then
            If String.IsNullOrEmpty(Vacio.Text) Then
                Vacio.BackColor = Color.FromArgb(255, 192, 192)
            Else
                FormLleno = FormLleno + 1
                Vacio.BackColor = Color.FromArgb(247, 247, 247)
            End If
        Else
            For Each Contenedor As Control In Vacio.Controls
                RevisarTexTBox(Contenedor)
            Next
        End If
    End Sub
    ''' <summary>
    ''' Vacia los textbox
    ''' </summary>
    Sub VaciarTexTBox(ByVal Vaciar As Control)
        'Quita el texto de los textbox
        If (Vaciar.GetType.Name = "TextBox") Then
            Vaciar.Text = String.Empty
        Else
            For Each Contenedor As Control In Vaciar.Controls
                VaciarTexTBox(Contenedor)
            Next
        End If
    End Sub
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Cliente' 
            Me.ClienteTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Cliente)
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Inventario' 
            Me.InventarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Inventario)
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Detalles_Pedido' 
            Me.Detalles_PedidoTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Detalles_Pedido)
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Factura' 
            Me.FacturaTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Factura)
            'Carga los textbox sin texto
            For Each Vaciar As Control In Me.Controls
                VaciarTexTBox(Vaciar)
            Next
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Graba los datos en las tablas 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RegistrarBTT_Click(sender As Object, e As EventArgs) Handles RegistrarBTT.Click
        Try
            'Revisar si el form esta lleno
            For Each Vacio As Control In Me.Controls
                RevisarTexTBox(Vacio)
            Next
            If FormLleno < 9 Then
                MsgBox("Complete la informaciòn", MsgBoxStyle.Exclamation, "AutoRib")
                FormLleno = 0
            Else
                'Comprueba si cedula textbox contiene datos
                If CedulaTextBox.Text = "" Then
                    'Mensaje de Ayuda
                    MsgBox("Para poder Registrar una venta debes completar el formulario", MsgBoxStyle.Exclamation, "AutoRib")
                Else
                    Dim FechaActual As Date = Today
                    Dim ID_Inventario As String
                    Dim Cantidad_Inventario As String
                    Dim ID_Cliente As String
                    Dim dt As DataTable = New DataTable
                    'Extraer el resultado de la consulta a una tabla (Datatable)
                    If (TypeOf InventarioBindingSource.DataSource Is DataSet) Then
                        dt = CType(InventarioBindingSource.DataSource, DataSet).Tables(InventarioBindingSource.DataMember)
                    ElseIf (TypeOf InventarioBindingSource.DataSource Is DataTable) Then
                        dt = CType(InventarioBindingSource.DataSource, DataTable)
                    End If
                    ''consulta a la base de datos Cliente
                    Me.ClienteTableAdapter.Buscar_Datos(Me.BDD_Salsamentaria_1DataSet.Cliente, CedulaTextBox.Text)
                    'Recorremos Data Table
                    For Each DFilas As DataRow In dt.Rows
                        ID_Cliente = DFilas("Id").ToString
                    Next
                    'consulta a la base de datos en la tabla Factura
                    Me.FacturaTableAdapter.Insert(N_FacturaTextBox.Text, Forma_PagoCheckBox.Checked, ID_Cliente, FechaActual)
                    ' Trae el Id de la tabla Factura
                    Dim Id_Factura As BDD_Salsamentaria_1DataSet.FacturaRow = BDD_Salsamentaria_1DataSet.Factura.NewFacturaRow()

                    'Recorre todo el DGV 
                    For Each Filas As DataGridViewRow In FacturaDataGridView.Rows
                        'consulta a la base de datos inventario
                        Me.InventarioTableAdapter.Buscar_Dato(Me.BDD_Salsamentaria_1DataSet.Inventario, Filas.Cells(0).Value)
                        'Recorremos Data Table
                        For Each drw As DataRow In dt.Rows
                            ID_Inventario = drw("ID").ToString
                            Cantidad_Inventario = drw("Cantidad").ToString
                        Next drw
                        If Cantidad_Inventario >= Convert.ToInt32(Filas.Cells(1).Value) Then
                            'consulta a la base de datos en la tabla Detalles_Pedido 
                            Me.Detalles_PedidoTableAdapter.Insert((Id_Factura.Id * -1), ID_Inventario, Convert.ToInt32(Filas.Cells(1).Value), Convert.ToInt32(Filas.Cells(3).Value))
                            'consulta a la base de datos en la tabla Inventario 
                            Me.InventarioTableAdapter.UpdateQuery((Cantidad_Inventario - Convert.ToInt32(Filas.Cells(1).Value)), ID_Inventario)
                        Else
                            'Mensaje de Ayuda
                            MsgBox("Para poder Registrar el pedido se debe verificar la cantidad en el inventario del producto " & Convert.ToString(Filas.Cells(2).Value), MsgBoxStyle.Exclamation, "AutoRib")
                        End If
                    Next
                    'Carga los textbox sin texto
                    For Each Vaciar As Control In Me.Controls
                        VaciarTexTBox(Vaciar)
                    Next
                    'Limpia el DGV
                    FacturaDataGridView.Rows.Clear()
                End If
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' Busca en la tabla inventario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BuscarBTT_Click(sender As Object, e As EventArgs) Handles BuscarBTT.Click
        Try
            'Comprueba si Producto textbox contiene datos
            If Referencia_ProductoTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Buscar un registro debes ingresar primero la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.InventarioTableAdapter.Buscar_Dato(Me.BDD_Salsamentaria_1DataSet.Inventario, Referencia_ProductoTextBox.Text)
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Agrega el Registro al DataGridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AgregarBTT_Click(sender As Object, e As EventArgs) Handles AgregarBTT.Click
        Try
            If CantidadTextBox.Text = "" Then
                MsgBox("Para poder Agregar un registro debes ingresar primero la Cantidad", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                If Vlr_UnidadTextBox.Text = "" Then
                    MsgBox("Para poder Agregar un registro debes ingresar primero el Vlr Unidad", MsgBoxStyle.Exclamation, "AutoRib")
                Else
                    If Referencia_ProductoTextBox.Text = "" Then
                        MsgBox("Para poder Agregar un registro debes ingresar primero Referencia Producto", MsgBoxStyle.Exclamation, "AutoRib")
                    Else
                        '' Agregra los datos a el DataGridView 
                        FacturaDataGridView.Rows.Add(Referencia_ProductoTextBox.Text, CantidadTextBox.Text, NombreTextBox.Text, Vlr_UnidadTextBox.Text)
                        Dim Total As Integer
                        ''Multiplica el valor unitario por la cantidad y suma el total
                        ''Recorre todo el DGV Multiplica y suma el total
                        For Each Fila As DataGridViewRow In FacturaDataGridView.Rows
                            Total = (Convert.ToInt32(Fila.Cells(1).Value) * Convert.ToInt32(Fila.Cells(3).Value)) + Total
                        Next
                        ''Aqui hace la multiplicacion y suma por indicador de la fila
                        'Total = Total + (Convert.ToInt32(FacturaDataGridView.CurrentRow.Cells(0).Value) * Convert.ToInt32(FacturaDataGridView.CurrentRow.Cells(2).Value))
                        TextBox1.Text = Total
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Elimina el Registro de la fila seleccionada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FacturaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaDataGridView.CellContentClick
        Try
            Dim Total As Integer
            Total = TextBox1.Text
            ''Resta lo que se elimino en el Total
            Total = Total - (Convert.ToInt32(FacturaDataGridView.CurrentRow.Cells(1).Value) * Convert.ToInt32(FacturaDataGridView.CurrentRow.Cells(3).Value))
            TextBox1.Text = Total
            '' Elimina el registro seleccionado
            If Me.FacturaDataGridView.Columns(e.ColumnIndex).Name = "Eliminar" Then
                FacturaDataGridView.Rows.Remove(FacturaDataGridView.CurrentRow)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Vacia los textboxs para agregar un nuevo registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NuevoBTT_Click(sender As Object, e As EventArgs) Handles NuevoBTT.Click
        CantidadTextBox.Text = ""
        NombreTextBox.Text = ""
        Vlr_UnidadTextBox.Text = ""
        Referencia_ProductoTextBox.Text = ""
    End Sub
    ''' <summary>
    ''' Solo permite escribir numeros
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CantidadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            'Propiedad Iscontrol permite borrar(Usara tecla retroceso)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Solo permite escribir numeros
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Vlr_UnidadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            'Propiedad Iscontrol permite borrar(Usara tecla retroceso)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Solo permite escribir numeros
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CedulaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CedulaTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            'Propiedad Iscontrol permite borrar(Usara tecla retroceso)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Busca en la tabla Cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BuscarClienteBTT_Click(sender As Object, e As EventArgs) Handles BuscarClienteBTT.Click
        Try
            'Comprueba si cedula textbox contiene datos
            If CedulaTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Buscar un registro debes ingresar primero la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.ClienteTableAdapter.Buscar_Datos(Me.BDD_Salsamentaria_1DataSet.Cliente, CedulaTextBox.Text)
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ModificarBTT_Click(sender As Object, e As EventArgs) Handles ModificarBTT.Click

    End Sub

    Private Sub Forma_PagoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Forma_PagoCheckBox.CheckedChanged

    End Sub
End Class