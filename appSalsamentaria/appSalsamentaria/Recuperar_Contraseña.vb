'Libreria de Net.Mail para poder enviar el correo
Imports System.Net.Mail
Public Class Recuperar_Contraseña
    'Variables para el envio del correo
    Dim message As New MailMessage
    Dim smtp As New SmtpClient
    'Variables que recolectan los datos de la consulta a la base de datos
    Dim Contraseña As String
    Dim Usuario As String
    Dim Nombre As String
    ''' <summary>
    ''' Carga datos en la tabla Usuario y vacia text box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Recuperar_Contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla Usuario 
        Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)
        'Muestra los campos texto vacios
        CorreoTextBox.Text = ""
    End Sub
    ''' <summary>
    ''' Genera un envio al correo electronico con los datos de login
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EnviarBTT_Click(sender As Object, e As EventArgs) Handles EnviarBTT.Click
        Try
            'Validamos si los datos escritos son iguales en la base de datos
            If Me.UsuarioTableAdapter.ValidarDatos_Correo(Me.BDD_Salsamentaria_1DataSet.Usuario, CorreoTextBox.Text) Then

                'Extraer el resultado de la consulta a una tabla (Datatable)
                Dim dt As DataTable = New DataTable
                If (TypeOf UsuarioBindingSource.DataSource Is DataSet) Then
                    dt = CType(UsuarioBindingSource.DataSource, DataSet).Tables(UsuarioBindingSource.DataMember)
                ElseIf (TypeOf UsuarioBindingSource.DataSource Is DataTable) Then
                    dt = CType(UsuarioBindingSource.DataSource, DataTable)
                End If
                'Recorremos 
                For Each drw As DataRow In dt.Rows
                    Contraseña = drw("Contraseña").ToString
                    Usuario = drw("Cedula").ToString
                    Nombre = drw("Nombre").ToString
                Next drw

                'Al comprobar los datos iniciamos con la carga del mensaje 
                message.From = New MailAddress("stocktvp@gmail.com") 'Quien envia el correo
                message.To.Add(CorreoTextBox.Text) 'Para quien va dirijido
                message.Subject = "Solicitud de restablecimiento de contraseña" 'El asunto del mensaje
                message.Body = "
Hola, " + Nombre + ":

---------------------------------------------------------------------------------

Este es un mensaje de correo electrónico automático, no lo responda.

Hemos generado el envio de los datos para tu ingreso.

A continuación encontrará los datos de su cuenta.

Información de su cuenta:

 Usuario: " + Usuario + "
 Contraseña: " + Contraseña + "
 
Si no solicito esto, ignore este correo electrónico. 

---------------------------------------------------------------------------------

El equipo de asistencia técnica." 'EL cuerpo del mensaje
                message.Priority = MailPriority.Normal 'Prioridad del mensaje
                'Coneccion al correo electronico.
                smtp.EnableSsl = True  ' Coneccion Ssl
                smtp.Port = "587" 'Puerto SMTP
                smtp.Host = "smtp.gmail.com" 'Servidor SMTP
                smtp.Credentials = New Net.NetworkCredential("stocktvp@gmail.com", "stocktvp1234") 'Usuario SMTP y Contraseña SMTP
                smtp.Send(message)
                'Mensaje de alerta que se hizo el envio correctamente
                MsgBox("Hemos enviado un correo electrónico. ", MsgBoxStyle.Information, "Revisa tu correo electrónico")
                'Cierra la ventana del login
                Me.Close()
            Else
                'Si el usuario no es correcto muestra mensaje de error
                MsgBox("No pudimos encontrar tu cuenta con esa información.", MsgBoxStyle.Critical, "Usuario no encontrado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class