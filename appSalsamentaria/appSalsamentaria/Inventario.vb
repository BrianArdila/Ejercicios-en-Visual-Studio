Public Class Inventario
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
    ''' <summary>
    ''' Carga la base de datos antes de mostrar el form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Inventario' 
        Me.InventarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Inventario)
    End Sub
    ''' <summary>
    ''' agrega datos a la base de datos 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AgregarBTT_Click(sender As Object, e As EventArgs) Handles AgregarBTT.Click
        Try
            IdTextBox.Text = -1
            'Revisar si el form esta lleno
            For Each Vacio As Control In GBoxDatosUser.Controls
                RevisarTexTBox(Vacio)
            Next
            If FormLleno < 6 Then
                MsgBox("Complete la informaciòn", MsgBoxStyle.Exclamation, "AutoRib")
                FormLleno = 0
            Else
                'Comprueba si Referencia textbox contiene datos
                If Referencia_ProductoTextBox.Text = "" Then
                    'Mensaje de Ayuda
                    MsgBox("Para poder Agregar un registro debes ingresar primero la referencia del producto", MsgBoxStyle.Exclamation, "AutoRib")
                Else
                    Dim FechaActual As Date = Today
                    'consulta a la base de datos 
                    Me.InventarioTableAdapter.Insert(Referencia_ProductoTextBox.Text, NombreTextBox.Text, ActivoCheckBox.Checked, DescripciónTextBox.Text, Vlr_CompraTextBox.Text, FechaActual, CantidadTextBox.Text, Venta_PesoCheckBox.Checked)
                    'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Inventario' 
                    Me.InventarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Inventario)
                    'Carga los textbox sin texto
                    For Each c As Control In Me.Controls
                        VaciarTexTBox(c)
                    Next
                End If
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Modifica los datos del inventario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ModificarBTT_Click(sender As Object, e As EventArgs) Handles ModificarBTT.Click
        Try
            'Comprueba si cedula textbox contiene datos
            If IdTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Modificar un registro debes ingresar la referencia del producto", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.InventarioTableAdapter.Actualizar_Datos(Referencia_ProductoTextBox.Text, NombreTextBox.Text, DescripciónTextBox.Text, Vlr_CompraTextBox.Text, CantidadTextBox.Text, ActivoCheckBox.Checked, Venta_PesoCheckBox.Checked, IdTextBox.Text)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Inventario' 
                Me.InventarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Inventario)
                'Carga los textbox sin texto
                For Each c As Control In Me.Controls
                    VaciarTexTBox(c)
                Next
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Carga las tablas de la base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ActualizarBTT_Click(sender As Object, e As EventArgs) Handles ActualizarBTT.Click
        Try
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Inventario' 
            Me.InventarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Inventario)
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
    ''' Elimina un dato de la tabla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EliminarBTT_Click(sender As Object, e As EventArgs) Handles EliminarBTT.Click
        Try
            'Comprueba si Referencia textbox contiene datos
            If Referencia_ProductoTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Eliminar un registro debes ingresar primero la referencia del producto", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos a la tabla usuario(Busca a el dato)
                Me.InventarioTableAdapter.Buscar_Dato(Me.BDD_Salsamentaria_1DataSet.Inventario, Referencia_ProductoTextBox.Text)
                'TODO: esta línea de código Elimina datos en la tabla 
                Me.InventarioTableAdapter.DeleteQuery(Referencia_ProductoTextBox.Text)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Inventario' 
                Me.InventarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Inventario)
                'Carga los textbox sin texto
                For Each c As Control In Me.Controls
                    VaciarTexTBox(c)
                Next
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)

        End Try
    End Sub
    ''' <summary>
    ''' Buscar un dato en la tabla inventario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BuscarBTT_Click(sender As Object, e As EventArgs) Handles BuscarBTT.Click
        Try
            'Comprueba si Referencia textbox contiene datos
            If R_PBuscarTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Buscar un registro debes ingresar primero la referencia del producto", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos a la tabla usuario(Busca a el dato)
                Me.InventarioTableAdapter.Buscar_Dato(Me.BDD_Salsamentaria_1DataSet.Inventario, R_PBuscarTextBox.Text)
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Solo permite escribir numeros
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Vlr_CompraTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Vlr_CompraTextBox.KeyPress
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
    Private Sub CantidadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadTextBox.KeyPress
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
    Private Sub Precio_VentaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
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
End Class