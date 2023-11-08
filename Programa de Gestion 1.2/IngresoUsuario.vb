Public Class IngresoUsuario

    Private Sub ButtonIngresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIngresar.Click
        Dim usu, clave As String
        usu = TextBox1.Text
        clave = TextBox2.Text
        If usu <> "" And clave <> "" Then
            usu = Me.UsuariosBindingSource.Find("Usuario", TextBox1.Text)
            If clave = Me.UsuariosBindingSource.Current("Clave") Then
                Principal.Show()
            Else
                MsgBox("Usuario y/o Contraseña incorrecto")
            End If
        Else
            MsgBox("Usuario y/o Contraseña incorrecto")
        End If
    End Sub
    Private Sub ButtonIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub IngresoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BasedeDatosDataSet.Usuarios)

    End Sub

    Private Sub UsuariosBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub
End Class