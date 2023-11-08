Public Class Usuarios

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BasedeDatosDataSet.Usuarios)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin.Show()

    End Sub

    Private Sub ButtonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolver.Click
        Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       
        Dim fila, consulta, aux As Integer
        Dim usu As String
        consulta = Val(InputBox("Ingrese Id del Usuario"))
        fila = Me.UsuariosBindingSource.Find("IdUsuario", consulta)
        usu = Me.UsuariosBindingSource.Current("Usuario")
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            Me.UsuariosBindingSource.Position = fila
            aux = MsgBox("Quiere eliminar el Usuario: " & Me.UsuariosBindingSource.Current("Usuario"), 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.UsuariosBindingSource.RemoveCurrent()
                Me.UsuariosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                MsgBox("Se elimino exitosamente")
            Else
            End If

        End If
    End Sub
End Class