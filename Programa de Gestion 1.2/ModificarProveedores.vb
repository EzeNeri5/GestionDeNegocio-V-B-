Public Class ModificarProveedores

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub ModificarProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox10.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dni, direc As Integer
        If TextBox1.Text <> "" Then
            dni = Me.ProveedoresBindingSource.Find("Cuit/Cuil", Val(TextBox1.Text))
            If dni <= -1 Then
                MsgBox("No se encontro Cuit/Cuil")
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
            Else
                TextBox1.Text = ""
                TextBox11.Text = ""
                Me.ProveedoresBindingSource.Position = dni
                TextBox2.Text = Me.ProveedoresBindingSource.Current("Cuit/Cuil")
                TextBox3.Text = Me.ProveedoresBindingSource.Current("Telefono")
                TextBox4.Text = Me.ProveedoresBindingSource.Current("Nombre")
                TextBox5.Text = Me.ProveedoresBindingSource.Current("Apellido")
                TextBox8.Text = Me.ProveedoresBindingSource.Current("Calle")
                TextBox9.Text = Me.ProveedoresBindingSource.Current("Altura")
                direc = Me.DireccionBindingSource.Find("IdDireccion", Me.ProveedoresBindingSource.Current("IdDireccion"))
                DireccionBindingSource.Position = direc
                TextBox6.Text = Me.DireccionBindingSource.Current("CodigoPostal")
                TextBox7.Text = Me.DireccionBindingSource.Current("Localidad")
                TextBox10.Text = Me.DireccionBindingSource.Current("Provincia")
            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim apellido, direc As String
        apellido = Me.ProveedoresBindingSource.Find("Apellido", TextBox11.Text)
        If apellido <= -1 Then
            MsgBox("No se encontro Apellido")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox10.Text = ""
            TextBox1.Text = ""
        Else
            TextBox1.Text = ""
            TextBox11.Text = ""
            Me.ProveedoresBindingSource.Position = Val(apellido)
            TextBox2.Text = Me.ProveedoresBindingSource.Current("Cuit/Cuil")
            TextBox3.Text = Me.ProveedoresBindingSource.Current("Telefono")
            TextBox4.Text = Me.ProveedoresBindingSource.Current("Nombre")
            TextBox5.Text = Me.ProveedoresBindingSource.Current("Apellido")
            TextBox8.Text = Me.ProveedoresBindingSource.Current("Calle")
            TextBox9.Text = Me.ProveedoresBindingSource.Current("Altura")
            direc = Me.DireccionBindingSource.Find("IdDireccion", Me.ProveedoresBindingSource.Current("IdDireccion"))
            DireccionBindingSource.Position = direc
            TextBox6.Text = Me.DireccionBindingSource.Current("CodigoPostal")
            TextBox7.Text = Me.DireccionBindingSource.Current("Localidad")
            TextBox10.Text = Me.DireccionBindingSource.Current("Provincia")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim aux As Integer

        aux = MsgBox(" Quiere realizar modificar el cliente: ", 32 + 1, "Modificar")
        If aux = 1 Then
            Me.ProveedoresBindingSource.Current("Cuit/Cuil") = Val(TextBox2.Text)
            Me.ProveedoresBindingSource.Current("Telefono") = Val(TextBox3.Text)
            Me.ProveedoresBindingSource.Current("Nombre") = TextBox4.Text
            Me.ProveedoresBindingSource.Current("Apellido") = TextBox5.Text
            Me.ProveedoresBindingSource.Current("Calle") = TextBox8.Text
            Me.ProveedoresBindingSource.Current("Altura") = Val(TextBox9.Text)

            Me.ProveedoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
            Me.ProveedoresTableAdapter.Fill(Me.BasedeDatosDataSet.Proveedores)
            Proveedores.ProveedoresTableAdapter.Fill(Proveedores.BasedeDatosDataSet.Proveedores)
            'Me.ClientesBindingSource.Position = aux
            MsgBox("Modificacion con Exito")
            TextBox11.Text = ""
            TextBox1.Text = ""
            aux = 0
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub
End Class