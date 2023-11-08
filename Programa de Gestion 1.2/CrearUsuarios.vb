Public Class CrearUsuarios

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub CrearUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BasedeDatosDataSet.Usuarios)
        Me.UsuariosBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
        Me.UsuariosTableAdapter.Fill(Me.BasedeDatosDataSet.Usuarios)
        Usuarios.UsuariosTableAdapter.Fill(Usuarios.BasedeDatosDataSet.Usuarios)
        MsgBox("Se guardo con exito")
        Me.UsuariosBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub ClaveTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaveTextBox.TextChanged
        ClaveTextBox.PasswordChar = "*"
    End Sub

    
End Class