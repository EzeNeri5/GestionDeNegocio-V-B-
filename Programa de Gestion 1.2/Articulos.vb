Public Class Articulos

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)

    End Sub

    Private Sub ButtonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolver.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrearArticulos.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ModificarArticulo.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fila, consulta, aux As Integer
        Dim nomb As String
        consulta = Val(InputBox("Ingrese el Codigo"))
        fila = Me.ArticulosBindingSource.Find("Codigo", consulta)
        nomb = Me.ArticulosBindingSource.Current("Descripcion")
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            Me.ArticulosBindingSource.Position = fila
            aux = MsgBox("Quiere eliminar producto: " & Me.ArticulosBindingSource.Current("Descripcion"), 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.ArticulosBindingSource.RemoveCurrent()
                Me.ArticulosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                MsgBox("Se elimino exitosamente")
            Else
            End If

        End If
    End Sub
End Class