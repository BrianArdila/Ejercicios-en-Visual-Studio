Public Class Cliente
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
            Me.ClienteTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Cliente)
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
    ''' carga la base de datos antes de mostrar el form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Cliente' 
        Me.ClienteTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Cliente)
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
            If FormLleno < 4 Then
                MsgBox("Complete la informaciòn", MsgBoxStyle.Exclamation, "AutoRib")
                FormLleno = 0
            Else
                'Comprueba si cedula textbox contiene datos
                If CedulaTextBox.Text = "" Then
                    'Mensaje de Ayuda
                    MsgBox("Para poder Agregar un registro debes ingresar primero la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
                Else
                    Dim FechaActual As Date = Today
                    'consulta a la base de datos 
                    Me.ClienteTableAdapter.Insert(NombreTextBox.Text, ApellidoTextBox.Text, CedulaTextBox.Text, FechaActual)
                    'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                    Me.ClienteTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Cliente)
                    'Carga los textbox sin texto
                    For Each Vaciar As Control In Me.Controls
                        VaciarTexTBox(Vaciar)
                    Next
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
            'Comprueba si cedula textbox contiene datos
            If CedulaTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Eliminar un registro debes ingresar primero la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.ClienteTableAdapter.DeleteQuery(CedulaTextBox.Text)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                Me.ClienteTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Cliente)
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
            If CdBuscarTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Buscar un registro debes ingresar primero la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.ClienteTableAdapter.Buscar_Datos(Me.BDD_Salsamentaria_1DataSet.Cliente, CdBuscarTextBox.Text)
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
            'Comprueba si cedula textbox contiene datos
            If CedulaTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Modificar un registro debes ingresar la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos 
                Me.ClienteTableAdapter.Actualizar_Datos(NombreTextBox.Text, ApellidoTextBox.Text, CedulaTextBox.Text, IdTextBox.Text)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                Me.ClienteTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Cliente)
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
End Class