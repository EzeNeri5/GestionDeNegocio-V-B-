Public Class ModificarArticulo

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub ModificarArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DescripcionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dni, direc As Integer
        If TextBox1.Text <> "" Then
            dni = Me.ArticulosBindingSource.Find("Codigo", Val(TextBox1.Text))
            If dni <= -1 Then
                MsgBox("No se encontro Articulo")
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox11.Text = ""
            Else
                TextBox1.Text = ""
                TextBox11.Text = ""
                Me.ArticulosBindingSource.Position = dni
                TextBox6.Text = Me.ArticulosBindingSource.Current("Codigo")
                TextBox4.Text = Me.ArticulosBindingSource.Current("Descripcion")
                TextBox5.Text = Me.ArticulosBindingSource.Current("Color")
                TextBox7.Text = Me.ArticulosBindingSource.Current("Cantidad")
                TextBox8.Text = Me.ArticulosBindingSource.Current("Stock Minimo")
                direc = Me.MarcasBindingSource.Find("IdMarca", Me.ArticulosBindingSource.Current("IdMarca"))
                MarcasBindingSource.Position = direc
                TextBox9.Text = Me.MarcasBindingSource.Current("Marca")
            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim descrip, direc As String
        descrip = Me.ArticulosBindingSource.Find("Descripcion", TextBox11.Text)
        If descrip <= -1 Then
            MsgBox("No se encontro Articulo")
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox11.Text = ""
        Else
            TextBox1.Text = ""
            TextBox11.Text = ""
            Me.ArticulosBindingSource.Position = descrip
            TextBox6.Text = Me.ArticulosBindingSource.Current("Codigo")
            TextBox4.Text = Me.ArticulosBindingSource.Current("Descripcion")
            TextBox5.Text = Me.ArticulosBindingSource.Current("Color")
            TextBox7.Text = Me.ArticulosBindingSource.Current("Cantidad")
            TextBox8.Text = Me.ArticulosBindingSource.Current("Stock Minimo")
            direc = Me.MarcasBindingSource.Find("IdMarca", Me.ArticulosBindingSource.Current("IdMarca"))
            MarcasBindingSource.Position = direc
            TextBox9.Text = Me.MarcasBindingSource.Current("Marca")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim aux As Integer

        aux = MsgBox(" Quiere realizar modificar el producto: ", 32 + 1, "Modificar")
        If aux = 1 Then
            Me.ArticulosBindingSource.Current("Codigo") = Val(TextBox6.Text)
            Me.ArticulosBindingSource.Current("Descripcion") = TextBox4.Text
            Me.ArticulosBindingSource.Current("Color") = TextBox5.Text
            Me.ArticulosBindingSource.Current("Cantidad") = Val(TextBox7.Text)
            Me.ArticulosBindingSource.Current("Stock Minimo") = Val(TextBox8.Text)

            Me.ArticulosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
            Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)
            Articulos.ArticulosTableAdapter.Fill(Articulos.BasedeDatosDataSet.Articulos)
            'Me.ClientesBindingSource.Position = aux
            MsgBox("Modificacion con Exito")
            TextBox11.Text = ""
            TextBox1.Text = ""
            aux = 0
        End If
    End Sub
End Class