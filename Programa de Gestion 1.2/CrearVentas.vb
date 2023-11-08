Public Class CrearVentas

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub CrearVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasedeDatosDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BasedeDatosDataSet.Ventas)
        Me.VentasBindingSource.AddNew()
        'ComboBox1.Items.Add("A")
        'ComboBox1.Items.Add("B")
        ComboBox1.Items.Add("C")
        ComboBox1.Items.Add("E")
        ComboBox1.Items.Add("M")
        ComboBox1.Items.Add("X")
        ComboBox1.Items.Add("Cons. Final")
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ColorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila, consulta, aux, importe As Integer

        consulta = ComboBox3.SelectedValue
        fila = ArticulosBindingSource.Find("IdArticulo", consulta)

        If fila = -1 Then
            MsgBox("NO se encontro")
        Else
            Me.ArticulosBindingSource.Position = fila
            aux = MsgBox(" Quiere realizar la venta del producto: " & consulta, 32 + 1, "venta")
            If aux = 1 Then
                If Me.ArticulosBindingSource.Current("Cantidad") >= Val(CantidadTextBox.Text) Then

                    'valor
                    importe = Val(PrecioTextBox.Text) * Val(CantidadTextBox.Text)

                    'opero sobre tabla venta
                    Me.VentasBindingSource.Current("TipoFactura") = ComboBox1.SelectedItem
                    Me.VentasBindingSource.Current("IdCliente") = ComboBox2.SelectedValue
                    Me.VentasBindingSource.Current("IdArticulo") = ComboBox3.SelectedValue
                    Me.VentasBindingSource.Current("Cantidad") = Val(CantidadTextBox.Text)
                    Me.VentasBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
                    Me.VentasBindingSource.Current("Total") = importe
                    Me.VentasBindingSource.Current("Fecha") = Date.Now

                    'opero sobre tabla stock
                    Me.ArticulosBindingSource.Current("Cantidad") = Me.ArticulosBindingSource.Current("Cantidad") - (Val(CantidadTextBox.Text))

                    'cierro y grabo
                    Me.ArticulosBindingSource.EndEdit()
                    Me.VentasBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                    Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
                    Me.VentasTableAdapter.Fill(Me.BasedeDatosDataSet.Ventas)
                    Ventas.VentasTableAdapter.Fill(Ventas.BasedeDatosDataSet.Ventas)

                    MsgBox("Venta exitosa")
                    DescripcionTextBox.Text = ""
                    ColorTextBox.Text = ""
                    NombreTextBox.Text = ""
                    ApellidoTextBox.Text = ""
                    CantidadTextBox.Text = ""
                    TotalTextBox.Text = ""
                    PrecioTextBox.Text = ""
                    ComboBox3.Focus()

                    If Me.ArticulosBindingSource.Current("Cantidad") <= Me.ArticulosBindingSource.Current("Stock Minimo") Then
                        MsgBox("A superado el stock minimo")
                    End If

                Else
                    MsgBox("NO hay stock SUFICIENTE, el stock actual es :" & Me.ArticulosBindingSource.Current("Cantidad") & "unidades")

                End If
            End If
        End If
    End Sub

    Private Sub PrecioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecioTextBox.TextChanged
        TotalTextBox.Text = Val(PrecioTextBox.Text) * Val(CantidadTextBox.Text)
    End Sub

    Private Sub PrecioLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CantidadTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CantidadTextBox.TextChanged

    End Sub

    Private Sub CantidadLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class