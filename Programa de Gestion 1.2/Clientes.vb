Public Class Clientes

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Direccion' Puede moverla o quitarla según sea necesario.
        Me.DireccionTableAdapter.Fill(Me.BasedeDatosDataSet.Direccion)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasedeDatosDataSet.Clientes)

    End Sub

    Private Sub ClientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrearClientes.Show()

    End Sub

    Private Sub ButtonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolver.Click
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ModificarCliente.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fila, consulta, aux As Integer
        Dim nomb As String
        consulta = Val(InputBox("Ingrese el Cuit/Cuil/DNI"))
        fila = Me.ClientesBindingSource.Find("Cuit/Cuil/DNI", consulta)
        nomb = Me.ClientesBindingSource.Current("Apellido")
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            Me.ClientesBindingSource.Position = fila
            aux = MsgBox("Quiere eliminar el cliente: " & Me.ClientesBindingSource.Current("Apellido"), 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.ClientesBindingSource.RemoveCurrent()
                Me.ClientesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                MsgBox("Se elimino exitosamente")
            Else
            End If

        End If
    End Sub
End Class