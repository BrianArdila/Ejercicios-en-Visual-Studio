Public Class Inicio
    ''' <summary>
    ''' Carga la fecha y la hora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBHora.Text = TimeOfDay
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
        LBFecha.Text = DateTime.Now.ToLongDateString
    End Sub
    ''' <summary>
    ''' Nos cuenta los segundos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBHora.Text = TimeOfDay
    End Sub
End Class