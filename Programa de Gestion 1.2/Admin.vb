Public Class Admin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

       
        If TextBox1.Text = "alfa" And TextBox2.Text = "alfa" Then

            CrearUsuarios.Show()
            Close()


        Else

            MsgBox("Usuario y/o Contraseña incorrecto")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub
End Class