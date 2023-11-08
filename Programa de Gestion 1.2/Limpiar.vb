Public Class Limpiar
    Public Sub limpiar(ByVal formaux As Form)
        'Dim aux, aux1 As Control

        'For Each aux In formaux.Controls

        '    If TypeOf aux Is TextBox Then
        '        aux.Text = ""
        '    End If
        '    If TypeOf aux1 Is ComboBox Then
        '        aux1.Text = ""
        '     End If
        '    Next
        'End Sub
        Dim txt As Object
        Dim txttemporal As TextBox
        Dim cmbtemporal As ComboBox

        For Each txt In formaux.Controls
            If TypeOf txt Is TextBox Then
                txttemporal = CType(txt, TextBox)
                txttemporal.Clear()

            ElseIf TypeOf txt Is ComboBox Then
                cmbtemporal = CType(txt, ComboBox)
                cmbtemporal.SelectedIndex = 0
            End If
        Next



    End Sub
End Class
