Public Class ModificarDireccion

    Private Sub DireccionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DireccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub ModificarDireccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aux As Integer

        Me.DireccionBindingSource.EndEdit()
        Me.DireccionTableAdapter.Update(Me.BasedeDatosDataSet.Direccion)
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        Direccion.DireccionTableAdapter.Fill(Direccion.BasedeDatosDataSet.Direccion)
        Me.DireccionBindingSource.Position = aux
        MsgBox("Se Modifico conn exito")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class