Public Class CrearMarcas

    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub CrearMarcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        Me.MarcasBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        Marcas.MarcasTableAdapter.Fill(Marcas.BasedeDatosDataSet.Marcas)
        MsgBox("Se guardo con exito")
        Me.MarcasBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class