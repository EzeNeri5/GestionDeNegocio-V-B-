Public Class Marcas

    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)

    End Sub

    Private Sub Marcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.BasedeDatosDataSet.Marcas)

    End Sub

    Private Sub MarcasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MarcasDataGridView.CellContentClick

    End Sub

    Private Sub ButtonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolver.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrearMarcas.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ModificarMarcas.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fila, consulta, aux As String
        consulta = InputBox("Ingrese la marca")
        fila = Me.MarcasBindingSource.Find("Marca", consulta)
        If fila <> "" Then
            MsgBox("No se encontro")
        Else
            Me.MarcasBindingSource.Position = fila
            aux = MsgBox("Quiere eliminar marca: " & Me.MarcasBindingSource.Current("Marca"), 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.MarcasBindingSource.RemoveCurrent()
                Me.MarcasBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasedeDatosDataSet)
                MsgBox("Se elimino exitosamente")
            Else
            End If

        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class