Public Class CrearCompra

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Compras.Show()
        Close()

    End Sub

    Private Sub CrearCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BasedeDatosDataSet.Compras)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasedeDatosDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BasedeDatosDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)

        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasedeDatosDataSet.Clientes)

        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BasedeDatosDataSet.Compras)
        Me.ComprasBindingSource.AddNew()
        'IdPedidoTextBox.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila, consulta, aux, importe As Integer

        'opero sobre tabla venta
        ''Me.ComprasBindingSource.Current("IdPedido") = Val(IdPedidoTextBox.Text)
        Me.ComprasBindingSource.Current("IdProveedor") = Val(ComboBox1.SelectedValue)
        Me.ComprasBindingSource.Current("IdArticulo") = Val(ComboBox2.SelectedValue)
        Me.ComprasBindingSource.Current("Cantidad") = Val(CantidadTextBox.Text)
        Me.ComprasBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
        importe = Val(PrecioTextBox.Text) * Val(CantidadTextBox.Text)
        TotalTextBox.Text = importe
        Me.ComprasBindingSource.Current("Total") = importe
        Me.ComprasBindingSource.Current("Fecha") = Date.Now
        'TotalTextBox.Text = importe

        'opero sobre tabla stock
        Me.ArticulosBindingSource.Current("Cantidad") = Me.ArticulosBindingSource.Current("Cantidad") + (Val(CantidadTextBox.Text))

        'cierro y grabo
        Me.ArticulosBindingSource.EndEdit()
        Me.ComprasBindingSource.EndEdit()
        Me.ComprasTableAdapter.Update(Me.BasedeDatosDataSet.Compras)
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
        ComprasTableAdapter.Fill(Compras.BasedeDatosDataSet.Compras)
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)

        MsgBox("Compra exitosa")
        'IdPedidoTextBox.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        CantidadTextBox.Text = ""
        PrecioTextBox.Text = ""
        CantidadTextBox.Text = ""

        Me.ComprasBindingSource.AddNew()

    End Sub

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub PrecioTextBox_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles PrecioTextBox.Layout
        
    End Sub

    Private Sub PrecioTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrecioTextBox.LostFocus
       
    End Sub

    Private Sub PrecioTextBox_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrecioTextBox.SizeChanged
        'Dim importe As Integer
        'TotalTextBox.Text = importe
    End Sub

    Private Sub PrecioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecioTextBox.TextChanged
        TotalTextBox.Text = Val(PrecioTextBox.Text) * Val(CantidadTextBox.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://www.mercadolibre.com.ar")


    End Sub

    Private Sub TotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalTextBox.TextChanged

    End Sub
End Class