Public Class ReportesVentas

    Private Sub ComprasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub ReportesCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BasedeDatosDataSet.Compras)

    End Sub
End Class