Public Class Direccion

    Private Sub DireccionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DireccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub Direccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)

    End Sub

    Private Sub ButtonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolver.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrearDireccion.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fila, consulta, aux As Integer
        Dim usu As String
        consulta = Val(InputBox("Ingrese Codigo Postal"))
        fila = Me.DireccionBindingSource.Find("CodigoPostal", consulta)
        usu = Me.DireccionBindingSource.Current("Localidad")
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            Me.DireccionBindingSource.Position = fila
            aux = MsgBox("Quiere eliminar el Usuario: " & Me.DireccionBindingSource.Current("Localidad"), 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.DireccionBindingSource.RemoveCurrent()
                Me.DireccionBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                MsgBox("Se elimino exitosamente")
            Else
            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ModificarDireccion.Show()

    End Sub
End Class