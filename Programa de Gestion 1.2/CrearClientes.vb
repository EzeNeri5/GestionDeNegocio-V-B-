Public Class CrearClientes

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub CrearClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasedeDatosDataSet.Clientes)
        Me.ClientesBindingSource.AddNew()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClientesBindingSource.Current("IdDireccion") = ComboBox1.SelectedValue

        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
        Me.ClientesTableAdapter.Fill(Me.BasedeDatosDataSet.Clientes)
        Clientes.ClientesTableAdapter.Fill(Clientes.BasedeDatosDataSet.Clientes)
        MsgBox("Se guardo con exito")
        Me.ClientesBindingSource.AddNew()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub
End Class