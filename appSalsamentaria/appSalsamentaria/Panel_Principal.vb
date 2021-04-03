Public Class Panel_Principal
    'Variable que rescata la respuesta del MgsBox
    Dim RespuestaExit As MsgBoxResult 'Capta la respuesta del Msg
    Dim ActivarToolTip As Boolean 'Indicador para activar el tooltip
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
    ''' Muestra el inicio del panel principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HomeBTT_Click(sender As Object, e As EventArgs) Handles HomeBTT.Click
        'Redirige o  abre un form 
        AbrirFormInPanel(New Inicio)
    End Sub
    ''' <summary>
    ''' Sale del sistema
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SalirBTT_Click(sender As Object, e As EventArgs) Handles SalirBTT.Click
        'Cierra la aplicacion
        Application.Exit()
    End Sub
    ''' <summary>
    ''' Redirige a el form Proveedor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ProveedorBTT_Click(sender As Object, e As EventArgs) Handles ProveedorBTT.Click
        'Redirige o  abre un form 
        AbrirFormInPanel(New Proveedor)
        Dim Limpiar As Proveedor = New Proveedor
        'Carga los textbox sin texto
        For Each Vaciar As Control In Me.Controls
            Limpiar.VaciarTexTBox(Vaciar)
        Next
    End Sub
    ''' <summary>
    ''' Redirige ael form Cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClienteBTT_Click(sender As Object, e As EventArgs) Handles ClienteBTT.Click
        'Redirige o  abre un form 
        AbrirFormInPanel(New Cliente)
        Dim Limpiar As Cliente = New Cliente
        'Carga los textbox sin texto
        For Each Vaciar As Control In Me.Controls
            Limpiar.VaciarTexTBox(Vaciar)
        Next
    End Sub
    ''' <summary>
    ''' Redirige a el form Factura
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FacturaBTT_Click(sender As Object, e As EventArgs) Handles FacturaBTT.Click
        'Redirige o  abre un form 
        AbrirFormInPanel(New Factura)
        Me.WindowState = FormWindowState.Maximized
        Dim Limpiar As Factura = New Factura
        'Carga los textbox sin texto
        For Each Vaciar As Control In Me.Controls
            Limpiar.VaciarTexTBox(Vaciar)
        Next
    End Sub
    ''' <summary>
    ''' Redirige a el form Inventario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InventarioBTT_Click(sender As Object, e As EventArgs) Handles InventarioBTT.Click
        'Redirige o  abre un form 
        AbrirFormInPanel(New Inventario)
        Dim Limpiar As Inventario = New Inventario
        'Carga los textbox sin texto
        For Each Vaciar As Control In Me.Controls
            Limpiar.VaciarTexTBox(Vaciar)
        Next
    End Sub
    ''' <summary>
    ''' RetraerMenu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RetraerMenu_Click(sender As Object, e As EventArgs) Handles RetraerMenuBTT.Click
        'Se iguala la variable a el TLPanelPrincipal
        Dim styles As TableLayoutColumnStyleCollection = TLPanelPrincipal.ColumnStyles
        For Each Estilo As ColumnStyle In styles
            'Pregunta si el ajuste de la fila esta fijo
            If (Estilo.SizeType = SizeType.Absolute) Then
                'RTA si entonses se ajusta a los elementos dentro de la columna
                Estilo.SizeType = SizeType.AutoSize
                ActivarToolTip = False
            Else
                'Establecer el ancho de columna a 80 píxeles.
                Estilo.SizeType = SizeType.Absolute
                Estilo.Width = 80
                ActivarToolTip = True
            End If

        Next

    End Sub
    ''' <summary>
    ''' Mensaje al boton de cerrar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Panel_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Pregunta si quieres cerrar
        RespuestaExit = CType(MsgBox("¿Desea cerrar la aplicacion?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "AutoRib"), MsgBoxResult)
        If RespuestaExit = MsgBoxResult.Yes Then
            'Cierra el form
            e.Cancel = False ' e.Cancel responde al evento si lo cierra o no 
        Else
            e.Cancel = True ' e.Cancel responde al evento si lo cierra o no 
        End If
    End Sub
    ''' <summary>
    ''' Redirige a el from Ajustes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AjustesBTT_Click(sender As Object, e As EventArgs) Handles AjustesBTT.Click
        'Redirige o  abre un form 
        Configuraciones.Show()
        Me.Hide()
    End Sub
    ''' <summary>
    ''' Redirige a el form Usuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UsuariosBTT_Click_1(sender As Object, e As EventArgs) Handles UsuariosBTT.Click
        'Redirige o  abre un form 
        AbrirFormInPanel(New Usuarios)
        Dim Limpiar As Usuarios = New Usuarios()
        'Carga los textbox sin texto
        For Each Vaciar As Control In Me.Controls
            Limpiar.VaciarTexTBox(Vaciar)
        Next
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip  en RetraerMenu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RetraerMenu_MouseEnter(sender As Object, e As EventArgs) Handles RetraerMenuBTT.MouseEnter
        'se asigna texto al botton
        TTipHelp.SetToolTip(RetraerMenuBTT, "Alinea la barra de menú a la izquierda")
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en Salir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SalirBTT_MouseEnter(sender As Object, e As EventArgs) Handles SalirBTT.MouseEnter
        TTipHelp.SetToolTip(SalirBTT, "Cerrar el Programa")
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en home
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HomeBTT_MouseEnter(sender As Object, e As EventArgs) Handles HomeBTT.MouseEnter
        'Validamos el valor de la variable 
        If ActivarToolTip = True Then
            'Agrega el texto al tooltip
            TTipHelp.SetToolTip(HomeBTT, "Inicio")
        Else
            'Retira el texto al tooltip
            TTipHelp.SetToolTip(HomeBTT, "")
        End If
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en inventario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InventarioBTT_MouseEnter(sender As Object, e As EventArgs) Handles InventarioBTT.MouseEnter
        'Validamos el valor de la variable 
        If ActivarToolTip = True Then
            'Agrega el texto al tooltip
            TTipHelp.SetToolTip(InventarioBTT, "Inventario")
        Else
            'Retira el texto al tooltip
            TTipHelp.SetToolTip(InventarioBTT, "")
        End If
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en Proveedor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ProveedorBTT_MouseEnter(sender As Object, e As EventArgs) Handles ProveedorBTT.MouseEnter
        'Validamos el valor de la variable 
        If ActivarToolTip = True Then
            'Agrega el texto al tooltip
            TTipHelp.SetToolTip(ProveedorBTT, "Proveedor")
        Else
            'Retira el texto al tooltip
            TTipHelp.SetToolTip(ProveedorBTT, "")
        End If
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en Cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClienteBTT_MouseEnter(sender As Object, e As EventArgs) Handles ClienteBTT.MouseEnter
        'Validamos el valor de la variable 
        If ActivarToolTip = True Then
            'Agrega el texto al tooltip
            TTipHelp.SetToolTip(ClienteBTT, "Clientes")
        Else
            'Retira el texto al tooltip
            TTipHelp.SetToolTip(ClienteBTT, "")
        End If
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en Factura
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FacturaBTT_MouseEnter(sender As Object, e As EventArgs) Handles FacturaBTT.MouseEnter
        'Validamos el valor de la variable 
        If ActivarToolTip = True Then
            'Agrega el texto al tooltip
            TTipHelp.SetToolTip(FacturaBTT, "Factura")
        Else
            'Retira el texto al tooltip
            TTipHelp.SetToolTip(FacturaBTT, "")
        End If
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en Ajustes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AjustesBTT_MouseEnter(sender As Object, e As EventArgs) Handles AjustesBTT.MouseEnter
        'Validamos el valor de la variable 
        If ActivarToolTip = True Then
            'Agrega el texto al tooltip
            TTipHelp.SetToolTip(AjustesBTT, "Ajustes")
        Else
            'Retira el texto al tooltip
            TTipHelp.SetToolTip(AjustesBTT, "")
        End If
    End Sub
    ''' <summary>
    ''' Aplica funcion ToolTip en Usuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UsuariosBTT_MouseEnter(sender As Object, e As EventArgs) Handles UsuariosBTT.MouseEnter
        'Validamos el valor de la variable 
        If ActivarToolTip = True Then
            'Agrega el texto al tooltip
            TTipHelp.SetToolTip(UsuariosBTT, "Usuarios")
        Else
            'Retira el texto al tooltip
            TTipHelp.SetToolTip(UsuariosBTT, "")
        End If
    End Sub
    ''' <summary>
    ''' Cambia el estilo del form antes de mostral el form 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub Panel_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se iguala la variable a el TLPanelPrincipal
        Dim styles As TableLayoutColumnStyleCollection = TLPanelPrincipal.ColumnStyles
        For Each Estilo As ColumnStyle In styles
            'RTA si entonses se ajusta a los elementos dentro de la columna
            Estilo.SizeType = SizeType.AutoSize
        Next
        'Redirige o  abre un form 
        AbrirFormInPanel(New Inicio)
    End Sub
    ''' <summary>
    ''' Se activa para cerrar completamente la aplicacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Panel_Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Cierra la aplicacion
        Application.Exit()
    End Sub
End Class