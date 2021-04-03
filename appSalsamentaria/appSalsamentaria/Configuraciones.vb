Public Class Configuraciones
    Dim Form_Hijo As Form 'Carga los Forms anidados
    ''' <summary>
    ''' Abre los From como hijos del panel principal
    ''' </summary>
    ''' <param name="formHijo"></param>
    Sub AbrirFormInPanel(formHijo As Object)
        ' Igualamos la variable al parametro
        Form_Hijo = formHijo
        'Pregunta si el panelcontrolador tiene valor mayor que cero
        If Me.PlContenedor.Controls.Count > 0 Then
            'RTA Si entonses quita el control de la ubicacion
            Me.PlContenedor.Controls.RemoveAt(0)
        End If
        'Ajustamos el from a el panel
        Form_Hijo.TopLevel = False
        Form_Hijo.FormBorderStyle = FormBorderStyle.None
        Form_Hijo.Dock = DockStyle.Fill
        'Añadimos el  From a el panel
        Me.PlContenedor.Controls.Add(Form_Hijo)
        ' Obtenermos los datos del From
        Me.PlContenedor.Tag = Form_Hijo
        'Muestra el From
        Form_Hijo.Show()
    End Sub
    ''' <summary>
    ''' Abrimos el form temas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CambioTemaBTT_Click(sender As Object, e As EventArgs) Handles CambioTemaBTT.Click
        AbrirFormInPanel(New Temas)
    End Sub
    ''' <summary>
    ''' Abrimos el form Manual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HoraBTT_Click(sender As Object, e As EventArgs) Handles HoraBTT.Click
        AbrirFormInPanel(New Manual)
    End Sub
    ''' <summary>
    ''' Abrimos el form Informacion de contacto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InfoContactoBTT_Click(sender As Object, e As EventArgs) Handles InfoContactoBTT.Click
        AbrirFormInPanel(New InfoContacto)
    End Sub
    ''' <summary>
    ''' Nos lleva a el panel principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VolverBTT_Click(sender As Object, e As EventArgs) Handles VolverBTT.Click
        Me.Close()
        Panel_Principal.Show()
    End Sub
    ''' <summary>
    ''' Siempre que se cierre debe devolver a el panel principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Configuraciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Panel_Principal.Show()
    End Sub
End Class