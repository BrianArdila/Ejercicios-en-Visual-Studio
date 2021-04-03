Public Class Temas
    Dim RutaTema As String = ""
    ''' <summary>
    ''' Carga la ruta del tema a aplicar
    ''' </summary>
    Sub AplicarTema()
        RutaTema = "\Temas\" & TemasComboBox.SelectedItem & ".ssk"
        SkinEngine1.SkinFile = RutaTema
    End Sub
    ''' <summary>
    ''' Carga el tema escogio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AplicarTemaBTT_Click(sender As Object, e As EventArgs) Handles AplicarTemaBTT.Click
        AplicarTema()
        MsgBox("Se nesesita reiniciar la aplicacion para efectuar los cambios", MsgBoxStyle.MsgBoxHelp, "AutoRib")
        My.Settings.NombreTema = RutaTema
    End Sub
    ''' <summary>
    ''' Cambia la imagen dependiendo el tema selecionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TemasComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TemasComboBox.SelectedIndexChanged
        VistaTemasPBox.ImageLocation = "..\..\ImagenesTemas\" & TemasComboBox.SelectedItem & ".gif"
    End Sub
End Class