Public Class Fecha

    Private Sub Fecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BasedeDatosDataSet.Compras)
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BasedeDatosDataSet.Ventas)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim fila, contador, total, filaconsulta As Integer
        Dim fecha1, fecha2 As String
        fila = 0
        contador = 0
        total = 0
        filaconsulta = 0

        fecha1 = DateTimePicker1.Value.Date
        fecha2 = DateTimePicker2.Value.Date
        Me.DataGridView2.Rows.Clear() ' para limpiar la grilla, de esa forma no se acumula los datos que ya habiamos buscado
        Me.VentasBindingSource.MoveFirst()

        Do
            If Me.VentasBindingSource.Current("fecha") IsNot DBNull.Value Then

                If Me.VentasBindingSource.Current("fecha") >= fecha1 And Me.VentasBindingSource.Current("fecha") <= fecha2 Then

                    DataGridView2.Rows.Add() ' datagridview es la grilla que agregue yo y Rows es la columna que voy agregando

                    DataGridView2.Item(0, fila).Value = VentasBindingSource.Current("IdFactura") ' 0 es por que la primera columna es cero
                    DataGridView2.Item(1, fila).Value = VentasBindingSource.Current("TipoFactura")
                    DataGridView2.Item(2, fila).Value = VentasBindingSource.Current("IdCliente")
                    DataGridView2.Item(3, fila).Value = VentasBindingSource.Current("IdArticulo")
                    DataGridView2.Item(4, fila).Value = VentasBindingSource.Current("Cantidad")
                    DataGridView2.Item(5, fila).Value = VentasBindingSource.Current("Precio")
                    DataGridView2.Item(6, fila).Value = VentasBindingSource.Current("Total")
                    DataGridView2.Item(7, fila).Value = VentasBindingSource.Current("Fecha")

                    total = total + Me.VentasBindingSource.Current("Total")
                    fila = fila + 1

                End If
            End If
            contador = contador + 1
            Me.VentasBindingSource.MoveNext()

        Loop Until contador = Me.VentasBindingSource.Count

        If fila = 0 Then
            MsgBox("no se encontro el registro")
        Else
            DataGridView2.Item(5, fila).Value = "Total Facturado: "
            DataGridView2.Item(6, fila).Value = total

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()


    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim fila, contador, total, filaconsulta As Integer
        Dim fecha1, fecha2 As String
        fila = 0
        contador = 0
        total = 0
        filaconsulta = 0

        fecha1 = DateTimePicker1.Value.Date
        fecha2 = DateTimePicker2.Value.Date
        Me.DataGridView4.Rows.Clear() ' para limpiar la grilla, de esa forma no se acumula los datos que ya habiamos buscado

        Me.ComprasBindingSource.MoveFirst()

        Do

            If Me.ComprasBindingSource.Current("fecha") IsNot DBNull.Value Then

                If Me.ComprasBindingSource.Current("fecha") >= fecha1 And Me.ComprasBindingSource.Current("fecha") <= fecha2 Then


                    DataGridView4.Rows.Add() ' datagridview es la grilla que agregue yo y Rows es la columna que voy agregando

                    DataGridView4.Item(0, fila).Value = ComprasBindingSource.Current("IdPedido") ' 0 es por que la primera columna es cero
                    DataGridView4.Item(1, fila).Value = ComprasBindingSource.Current("IdProveedor")
                    DataGridView4.Item(2, fila).Value = ComprasBindingSource.Current("IdArticulo")
                    DataGridView4.Item(3, fila).Value = ComprasBindingSource.Current("Cantidad")
                    DataGridView4.Item(4, fila).Value = ComprasBindingSource.Current("Precio")
                    DataGridView4.Item(5, fila).Value = ComprasBindingSource.Current("Total")
                    DataGridView4.Item(6, fila).Value = ComprasBindingSource.Current("Fecha")


                    total = total + Me.ComprasBindingSource.Current("Total")

                    fila = fila + 1

                End If
            End If
            contador = contador + 1

            Me.ComprasBindingSource.MoveNext()


        Loop Until contador = Me.ComprasBindingSource.Count



        If fila = 0 Then
            MsgBox("no se encontro el registro")
        Else
            DataGridView4.Item(4, fila).Value = "Total Comprado: "
            DataGridView4.Item(5, fila).Value = total

        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Stock.Show()

    End Sub
End Class