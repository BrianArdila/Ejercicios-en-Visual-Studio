Public Class Login
    '|DataDirectory| ojo dato importante en el app.config
    'Contiene el numero de intentos de ingreso
    Dim Intentos As Integer = 0
    'Variables que recolectan los datos de la consulta a la base de datos
    Dim ID_Usuario As String
    Dim Rol As String
    ''' <summary>
    ''' Al cargar la aplicación, intenta conectarse a la base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario_Rol' 
        Me.Usuario_RolTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario_Rol)
        'TODO: esta línea de código carga datos en la tabla Usuario'
        Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)
        'Muestra los campos texto vacios
        CedulaTextBox.Text = ""
        ContraseñaTextBox.Text = ""
        'Carga el tema seleccionado
        Dim CargarTema As Temas = New Temas
        CargarTema.SkinEngine1.SkinFile = My.Settings.NombreTema
    End Sub

    ''' <summary>
    ''' Redirecciona a Recuperar_Contraseña
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LbOlvContraseña_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbOlvContraseña.LinkClicked
        'Redirige a el form recuperar contraseña
        Recuperar_Contraseña.Show()
    End Sub
    ''' <summary>
    ''' Función que se encarga de Comparar  los datos a la tabla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EntrarBTT_Click_1(sender As Object, e As EventArgs) Handles EntrarBTT.Click
        Try
            'Contador de intentos
            Intentos = 1 + Intentos
            'Validadamos si los datos escritos son iguales
            If Me.UsuarioTableAdapter.BuscarDatos_Login(Me.BDD_Salsamentaria_1DataSet.Usuario, CedulaTextBox.Text, ContraseñaTextBox.Text) Then

                'Extraer el resultado de la consulta a una tabla (Datatable)
                Dim dt As DataTable = New DataTable
                If (TypeOf UsuarioBindingSource.DataSource Is DataSet) Then
                    dt = CType(UsuarioBindingSource.DataSource, DataSet).Tables(UsuarioBindingSource.DataMember)
                ElseIf (TypeOf UsuarioBindingSource.DataSource Is DataTable) Then
                    dt = CType(UsuarioBindingSource.DataSource, DataTable)
                End If
                'Recorremos 
                For Each drw As DataRow In dt.Rows
                    ID_Usuario = drw("ID").ToString
                Next drw

                'Consulta a la base de datos 
                Me.Usuario_RolTableAdapter.Buscar_Dato(Me.BDD_Salsamentaria_1DataSet.Usuario_Rol, ID_Usuario)

                'Extraer el resultado de la consulta a una tabla (Datatable)
                If (TypeOf Usuario_RolBindingSource.DataSource Is DataSet) Then
                    dt = CType(Usuario_RolBindingSource.DataSource, DataSet).Tables(Usuario_RolBindingSource.DataMember)
                ElseIf (TypeOf Usuario_RolBindingSource.DataSource Is DataTable) Then
                    dt = CType(Usuario_RolBindingSource.DataSource, DataTable)
                End If
                'Recorremos 
                For Each drw As DataRow In dt.Rows
                    Rol = drw("ID_Rol").ToString
                Next drw
                'Validamos los permisos de usuario
                If (Rol = 1) Then
                    'Al comprobar los datos nos dirije a el panel principal
                    Panel_Principal.Show()
                    'Cierra el From
                    Me.Close()
                Else
                    ' Validamos permiso de mantenimiento
                    If (Rol = 3) Then
                        'Al comprobar los datos nos dirije a el panel principal
                        Panel_Principal.Show()
                        'Cierra el From
                        Me.Close()
                    Else
                        'Al comprobar los datos nos dirije a la Factura
                        Factura.Show()
                        'Cierra el From
                        Me.Close()
                    End If
                End If

            Else
                'Si el usuario no es correcto muestra mensaje de error
                MsgBox("El Usuario o la contraseña no coinciden con ninguna cuenta.", MsgBoxStyle.Critical, "Usuario no encontrado")
                'Si exede mas de 3 intentos nos envia mensaje de error
                If Intentos > 3 Then
                    'Mensaje critico de error
                    MsgBox("Has agotado el número de intentos" + vbLf + "Por favor espere y vuelva a intentarlo", MsgBoxStyle.Critical, "Intentos  agotados")
                    'Reinicia el contador
                    Intentos = 0
                    'Apaga el boton
                    EntrarBTT.Enabled = False
                    'Enciende el Tiempo
                    Timer1.Start()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' Evento que se activa despues de haber pasado los 5 sg
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Activa el boton
        EntrarBTT.Enabled = True
        'Frena el Tiempo
        Timer1.Stop()
    End Sub
End Class
