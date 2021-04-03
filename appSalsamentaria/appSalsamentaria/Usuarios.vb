Imports System.ComponentModel

Public Class Usuarios
    'Determina si el formulario se relleno
    Dim FormLleno = 0
    'Variable que recolecta el Rol(Cargo) de la consulta a la base de datos
    Dim Rol As String
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
    ''' Actualiza el form y las base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ActualizarBTT_Click(sender As Object, e As EventArgs) Handles ActualizarBTT.Click
        Try
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario_Rol'
            Me.Usuario_RolTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario_Rol)
            'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
            Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)
            'Carga los textbox sin texto
            For Each Vaciar As Control In Me.Controls
                VaciarTexTBox(Vaciar)
            Next
            CargoComboBox.Text = "Ninguno"
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' carga datos en la tabla y los textboxs vacios al cargar el form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario_Rol'
        Me.Usuario_RolTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario_Rol)
        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
        Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)
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
            For Each Vacio As Control In GBoxDatosUser.Controls
                RevisarTexTBox(Vacio)
            Next
            If FormLleno < 7 Then
                MsgBox("Complete la informaciòn", MsgBoxStyle.Exclamation, "AutoRib")
                FormLleno = 0
            Else
                'Comprueba si cedula textbox contiene datos
                If CedulaTextBox.Text = "" Then
                    'Mensaje de Ayuda
                    MsgBox("Para poder agregar un registro debes ingresar primero la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
                Else
                    If ContraseñaTextBox.TextLength < 8 Then
                        'Mensaje de Ayuda
                        MsgBox("La contraseña debe tener como mínimo 8 caracteres", MsgBoxStyle.Exclamation, "AutoRib")
                    Else
                        If CargoComboBox.Text = "Ninguno" Then
                            'Mensaje de Ayuda
                            MsgBox("Ingrese un cargo", MsgBoxStyle.Exclamation, "AutoRib")
                        Else
                            If TelefonoTextBox.TextLength < 7 Then
                                'Mensaje de Ayuda
                                MsgBox("La telefono debe tener como mínimo 7 caracteres", MsgBoxStyle.Exclamation, "AutoRib")
                            Else
                                Dim FechaActual As Date = Today
                                'consulta a la base de datos a la tabla usuario
                                Me.UsuarioTableAdapter.Insert(NombreTextBox.Text, ApellidoTextBox.Text, CedulaTextBox.Text, TelefonoTextBox.Text, CorreoTextBox.Text, ContraseñaTextBox.Text, FechaActual)
                                'Mueve el apuntador del Datagridview a la ultima fila
                                Dim Columna As Integer = 0
                                Dim Fila As Integer = Me.UsuarioDataGridView.Rows.Count
                                Me.UsuarioDataGridView.CurrentCell = Me.UsuarioDataGridView(Columna, (Fila - 2))
                                'Valida que tipo de cargo tiene
                                If CargoComboBox.Text = "Administrador" Then
                                    ' Ingresa datos la tabla Usuario_Rol
                                    Me.Usuario_RolTableAdapter.Insert(IdTextBox.Text, 1)
                                Else
                                    'Valida si el cargo es de mantenimiento
                                    If CargoComboBox.Text = "Mantenimiento" Then
                                        ' Ingresa datos la tabla Usuario_Rol
                                        Me.Usuario_RolTableAdapter.Insert(IdTextBox.Text, 3)
                                    Else
                                        ' Ingresa datos la tabla Usuario_Rol
                                        Me.Usuario_RolTableAdapter.Insert(IdTextBox.Text, 2)
                                    End If
                                End If
                                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                                Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)
                                'Carga los textbox sin texto
                                For Each c As Control In Me.Controls
                                    VaciarTexTBox(c)
                                Next
                                CargoComboBox.Text = "Ninguno"
                            End If
                        End If
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
            'Comprueba si cedula textbox contiene datos
            If CedulaTextBox.Text = "" Then
                'Mensaje de Ayuda
                MsgBox("Para poder Eliminar un registro debes ingresar primero la cedula del usuario", MsgBoxStyle.Exclamation, "AutoRib")
            Else
                'consulta a la base de datos a la tabla usuario(Busca a el dato)
                Me.UsuarioTableAdapter.Buscar_Datos(Me.BDD_Salsamentaria_1DataSet.Usuario, CedulaTextBox.Text)
                'Elimina los datos de las tablas usuario y usuario_rol
                Me.Usuario_RolTableAdapter.DeleteQuery(IdTextBox.Text)
                Me.UsuarioTableAdapter.DeleteQuery(CedulaTextBox.Text)

                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario_Rol'
                Me.Usuario_RolTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario_Rol)
                'Carga los textbox sin texto
                For Each c As Control In Me.Controls
                    VaciarTexTBox(c)
                Next
                CargoComboBox.Text = "Ninguno"
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
                'Busca el dato en las tablas
                Me.UsuarioTableAdapter.Buscar_Datos(Me.BDD_Salsamentaria_1DataSet.Usuario, CdBuscarTextBox.Text)
                'Consulta a la base de datos 
                Me.Usuario_RolTableAdapter.Buscar_Dato(Me.BDD_Salsamentaria_1DataSet.Usuario_Rol, IdTextBox.Text)

                'Extraer el resultado de la consulta a una tabla (Datatable)
                Dim dt As DataTable = New DataTable
                If (TypeOf Usuario_RolBindingSource.DataSource Is DataSet) Then
                    dt = CType(Usuario_RolBindingSource.DataSource, DataSet).Tables(Usuario_RolBindingSource.DataMember)
                ElseIf (TypeOf Usuario_RolBindingSource.DataSource Is DataTable) Then
                    dt = CType(Usuario_RolBindingSource.DataSource, DataTable)
                End If
                'Recorremos 
                For Each drw As DataRow In dt.Rows
                    Rol = drw("ID_Rol").ToString
                Next drw

                If Rol = 1 Then
                    CargoComboBox.Text = "Administrador"
                ElseIf Rol = 2 Then
                    CargoComboBox.Text = "Vendedor"
                ElseIf Rol = 3 Then
                    CargoComboBox.Text = "Mantenimiento"
                End If
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
                Me.UsuarioTableAdapter.Actualizar_Datos(NombreTextBox.Text, ApellidoTextBox.Text, CedulaTextBox.Text, TelefonoTextBox.Text, CorreoTextBox.Text, ContraseñaTextBox.Text, IdTextBox.Text)
                'Valida que tipo de cargo tiene
                If CargoComboBox.Text = "Administrador" Then
                    ' Ingresa datos la tabla Usuario_Rol
                    Me.Usuario_RolTableAdapter.UpdateQuery(IdTextBox.Text, 1, IdTextBox.Text)
                Else
                    'Valida si el cargo es de mantenimiento
                    If CargoComboBox.Text = "Mantenimiento" Then
                        ' Ingresa datos la tabla Usuario_Rol
                        Me.Usuario_RolTableAdapter.UpdateQuery(IdTextBox.Text, 3, IdTextBox.Text)
                    Else
                        ' Ingresa datos la tabla Usuario_Rol
                        Me.Usuario_RolTableAdapter.UpdateQuery(IdTextBox.Text, 2, IdTextBox.Text)
                    End If

                End If
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario
                Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)
                'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario_Rol'
                Me.Usuario_RolTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario_Rol)
                'Carga los textbox sin texto
                For Each c As Control In Me.Controls
                    VaciarTexTBox(c)
                Next
                CargoComboBox.Text = "Ninguno"
            End If
        Catch ex As Exception ' ex es la variable que controla las excepciones(errores)
            'Mensaje de Ayuda
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Solo deja escribir numeros
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
    ''' Solo permite ingresar numeros
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CdBuscarTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CdBuscarTextBox.KeyPress
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
    ''' Solo permite escribir letras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ApellidoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
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
    ''' Solo permite escribir letras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextBox.KeyPress
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
End Class