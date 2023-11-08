Public Class Ventas

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BasedeDatosDataSet.Ventas)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrearVentas.Show()

    End Sub

    Private Sub ButtonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolver.Click
        Principal.Show()
        Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila, consulta, aux As Integer
        consulta = Val(InputBox("Ingrese N Factura"))
        fila = Me.VentasBindingSource.Find("IdFactura", consulta)
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            Me.VentasBindingSource.Position = fila
            aux = MsgBox("Quiere eliminar la Factura: " & Me.VentasBindingSource.Current("IdFactura"), 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.VentasBindingSource.RemoveCurrent()
                Me.VentasBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                MsgBox("Se elimino exitosamente")
            Else
            End If

        End If
    End Sub
End Class