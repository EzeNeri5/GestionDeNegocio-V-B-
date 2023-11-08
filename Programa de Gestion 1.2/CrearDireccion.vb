Public Class CrearDireccion

    Private Sub DireccionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DireccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub CrearDireccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        Me.DireccionBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DireccionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        Direccion.DireccionTableAdapter.Fill(Direccion.BasedeDatosDataSet.Direccion)
        MsgBox("Se guardo con exito")
        Me.DireccionBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class