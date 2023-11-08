Public Class Stock

    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedeDatosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BasedeDatosDataSet.Articulos)

        ComboBox1.Items.Add("IdArticulo") ' primero cargo los items que quiero que carguen en combobox despues trabajo por el textbox de busqueda 
        ComboBox1.Items.Add("Codigo")
        ComboBox1.Items.Add("Descripcion")
        ComboBox1.Items.Add("Cantidad")
        ComboBox1.Text = "IdArticulo"

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim vista As New DataView
        vista.Table = Me.BasedeDatosDataSet.Articulos

        vista.RowFilter = "Descripcion LIKE'" & Me.TextBox1.Text & "%'" ' se usa la comilla simple ' para concatenar el textbox ejemplo "Descripcion LIKE ' M %'"
        Me.DataGridView1.DataSource = vista

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        Dim vista As New DataView

        vista.Table = Me.BasedeDatosDataSet.Articulos

        vista.RowFilter = "Codigo = " & Val(Me.TextBox2.Text) ' aca no lleva % por que el articulo es unico, depende de si tenemos dos proveedores con un mismo articulo 

        Me.DataGridView1.DataSource = vista


    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        Dim vista As New DataView  ' aca es para hacer el buscador del combobox
        Dim aux As String

        vista.Table = Me.BasedeDatosDataSet.Articulos

        aux = ComboBox1.Text

        'vista.RowFilter = "Descripcion LIKE'" & Me.TextBox1.Text & "%'"

        'vista.rowfilter = Combobox.text & " LIKE '" & textbox3.text & "&%'" ESTO SOLO FUNCIONA PARA STRING



        vista.RowFilter = "Convert (" & ComboBox1.Text & ",'System.String') LIKE'" & TextBox3.Text & "%'"
        'COVERT : EN FORMA DINAMICA TODA LA CADENA DEL String
        'System.String SIEMPRE EN MAYUSCULA LAS S

        Me.DataGridView1.DataSource = vista

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()

    End Sub

End Class