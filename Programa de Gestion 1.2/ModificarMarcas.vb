Public Class ModificarMarcas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aux As Integer

        Me.MarcasBindingSource.EndEdit()
        Me.MarcasTableAdapter.Update(Me.BasedeDatosDataSet.Marcas)
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        Marcas.MarcasTableAdapter.Fill(Marcas.BasedeDatosDataSet.Marcas)
        Me.MarcasBindingSource.Position = aux
        MsgBox("Se Modifico conn exito")
    End Sub

    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub ModificarMarcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class