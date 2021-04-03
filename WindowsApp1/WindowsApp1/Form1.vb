Public Class Form1
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_Salsamentaria_1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDD_Salsamentaria_1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.BDD_Salsamentaria_1DataSet.Usuario)

    End Sub
End Class
