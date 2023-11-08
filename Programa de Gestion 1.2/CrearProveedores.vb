Public Class CrearProveedores

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub CrearProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
        Me.ProveedoresBindingSource.AddNew()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ProveedoresBindingSource.Current("IdDireccion") = ComboBox1.SelectedValue

        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
        Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
        Proveedores.ProveedoresTableAdapter.Fill(Proveedores.BasedeDatosDataSet.Proveedores)
        MsgBox("Se guardo con exito")
        Me.ProveedoresBindingSource.AddNew()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class