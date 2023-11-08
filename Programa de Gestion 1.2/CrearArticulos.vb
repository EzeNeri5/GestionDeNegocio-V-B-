Public Class CrearArticulos

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub CrearArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        Me.ArticulosBindingSource.AddNew()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        'ComboBox3.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ArticulosBindingSource.Current("IdMarca") = ComboBox1.SelectedValue
        Me.ArticulosBindingSource.Current("IdProveedor") = ComboBox2.SelectedValue

        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        Articulos.ArticulosTableAdapter.Fill(Articulos.BasedeDatosDataSet.Articulos)
        MsgBox("Se guardo con exito")
        Me.ArticulosBindingSource.AddNew()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class