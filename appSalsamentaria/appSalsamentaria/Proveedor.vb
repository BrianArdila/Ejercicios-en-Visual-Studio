Public Class Proveedor
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
    ''' Actualiza los datos de la tabla usuario y mantiene los textboxs vacios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ActualizarBTT_Click(sender As Object, e As EventArgs) Handles ActualizarBTT.Click
        Try
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
            Me.ProveedorTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Proveedor)
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
    ''' Carga la base de datos antes de mostrar el form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Proveedor'
        Me.ProveedorTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Proveedor)
    End Sub
    ''' <summary>
    ''' Inserta datos nuevos a la tabla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AgregarBTT_Click(sender As Object, e As EventArgs) Handles AgregarBTT.Click
        Try
            IdTextBox.Text = -1
            'Revisar si el form esta lleno
            For Each Vacio As Control In GBoxDatos.Controls
                RevisarTexTBox(Vacio)
            Next
            If FormLleno < 6 Then
                MsgBox("Complete la informaciòn", MsgBoxStyle.Exclamation, "AutoRib")
                FormLleno = 0
            Else
                'Comprueba si Nit textbox contiene datos
                If NITTextBox.Text = "" Then
                    'Mensaje de Ayuda
                    MsgBox("Para poder agregar un registro debes ingresar primero el NIT del proveedor", MsgBoxStyle.Exclamation, "AutoRib")
                Else
                    If TelefonoTextBox.TextLength < 7 Then
                        'Mensaje de Ayuda
                        MsgBox("La telefono debe tener como mínimo 7 caracteres", MsgBoxStyle.Exclamation, "AutoRib")
                    Else
                        Dim FechaActual As Date = Today
                        'consulta a la base de datos 
                        Me.ProveedorTableAdapter.Insert(MarcaTextBox.Text, Nombre_EmpresaTextBox.Text, NITTextBox.Text, TelefonoTextBox.Text, DireccionTextBox.Text, FechaActual)
                        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                        Me.ProveedorTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Proveedor)
                        'Carga los textbox sin texto
                        For Each Vaciar As Control In Me.Controls
                            VaciarTexTBox(Vaciar)
                        Next
                    End If
                End If
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Elimina una fila de la tabla 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EliminarBTT_Click(sender As Object, e As EventArgs) Handles EliminarBTT.Click
        Try
            'Comprueba si nit textbox contiene datos
            If NITTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Eliminar un registro debes ingresar primero  el NIT del proveedor", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.ProveedorTableAdapter.DeleteQuery(NITTextBox.Text)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                Me.ProveedorTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Proveedor)
                'Carga los textbox sin texto
                For Each Vaciar As Control In Me.Controls
                    VaciarTexTBox(Vaciar)
                Next
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Busca datos por medio de la cedula
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BuscarBTT_Click(sender As Object, e As EventArgs) Handles BuscarBTT.Click
        Try
            'Comprueba si cedula textbox contiene datos
            If NITBuscarTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Buscar un registro debes ingresar primero  el NIT del proveedor", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.ProveedorTableAdapter.Buscar_Datos(Me.BDD_Salsamentaria_1DataSet.Proveedor, NITBuscarTextBox.Text)
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Modifica datos de la tabla 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ModificarBTT_Click(sender As Object, e As EventArgs) Handles ModificarBTT.Click
        Try
            'Comprueba si nit textbox contiene datos
            If NITTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Modificar un registro debes ingresar  el NIT del proveedor", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.ProveedorTableAdapter.Actualizar_Datos(MarcaTextBox.Text, Nombre_EmpresaTextBox.Text, NITTextBox.Text, TelefonoTextBox.Text, DireccionTextBox.Text, IdTextBox.Text)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                Me.ProveedorTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Proveedor)
                'Carga los textbox sin texto
                For Each Vaciar As Control In Me.Controls
                    VaciarTexTBox(Vaciar)
                Next
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
    Private Sub TelefonoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Solo permite escrbir numero con signos de puntuacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NITTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NITTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Solo permite escrbir numero con signos de puntuacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NITBuscarTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NITBuscarTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' solo deja escribir letras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MarcaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MarcaTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            'Propiedad Iscontrol permite borrar(Usara tecla retroceso)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Permite escribir solo letras y signos de puntuacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Nombre_EmpresaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre_EmpresaTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            'Propiedad Iscontrol permite borrar(Usara tecla retroceso)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class