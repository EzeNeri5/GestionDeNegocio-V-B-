Public Class Compras

    Private Sub ComprasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BasedeDatosDataSet.Compras)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrearCompra.Show()

    End Sub

    Private Sub ButtonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolver.Click
        Principal.Show()
        Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila, consulta, aux As Integer
        Dim nomb As String
        consulta = Val(InputBox("Ingrese el IdPedido"))
        fila = Me.ComprasBindingSource.Find("IdPedido", consulta)
        'nomb = Me.ComprasBindingSource.Current("Descripcion")
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            Me.ComprasBindingSource.Position = fila
            aux = MsgBox("Quiere eliminar la compra: " & Me.ComprasBindingSource.Current("IdPedido"), 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.ComprasBindingSource.RemoveCurrent()
                Me.ComprasBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                MsgBox("Se elimino exitosamente")
            Else
            End If

        End If
    End Sub
End Class