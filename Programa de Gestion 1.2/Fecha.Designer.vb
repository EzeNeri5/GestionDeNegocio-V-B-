<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fecha
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.VentasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.VentasTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ComprasTableAdapter()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IdPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'BasedeDatosDataSet
        '
        Me.BasedeDatosDataSet.DataSetName = "BasedeDatosDataSet"
        Me.BasedeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFactura, Me.TipoFactura, Me.IdCliente, Me.IdArticulo, Me.Cantidad, Me.Precio, Me.Total, Me.FechaVenta})
        Me.DataGridView2.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.Location = New System.Drawing.Point(14, 53)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(888, 290)
        Me.DataGridView2.TabIndex = 1
        '
        'IdFactura
        '
        Me.IdFactura.HeaderText = "IdFactura"
        Me.IdFactura.Name = "IdFactura"
        '
        'TipoFactura
        '
        Me.TipoFactura.HeaderText = "TipoFactura"
        Me.TipoFactura.Name = "TipoFactura"
        '
        'IdCliente
        '
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.Name = "IdCliente"
        '
        'IdArticulo
        '
        Me.IdArticulo.HeaderText = "IdArticulo"
        Me.IdArticulo.Name = "IdArticulo"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'FechaVenta
        '
        Me.FechaVenta.HeaderText = "FechaVenta"
        Me.FechaVenta.Name = "FechaVenta"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1020, 125)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 26)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(1020, 173)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(137, 26)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(1020, 287)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Filtrar Venta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(1020, 639)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 42)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(920, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(920, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hasta"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(1020, 414)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 44)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Filtrar compra"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPedido, Me.IdProveedor, Me.IdArticulo_, Me.Cantidad_, Me.Precio_, Me.Total_, Me.FechaCompra})
        Me.DataGridView4.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView4.Location = New System.Drawing.Point(12, 393)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(890, 290)
        Me.DataGridView4.TabIndex = 9
        '
        'IdPedido
        '
        Me.IdPedido.HeaderText = "IdPedido"
        Me.IdPedido.Name = "IdPedido"
        '
        'IdProveedor
        '
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        '
        'IdArticulo_
        '
        Me.IdArticulo_.HeaderText = "IdArticulo_"
        Me.IdArticulo_.Name = "IdArticulo_"
        '
        'Cantidad_
        '
        Me.Cantidad_.HeaderText = "Cantidad_"
        Me.Cantidad_.Name = "Cantidad_"
        '
        'Precio_
        '
        Me.Precio_.HeaderText = "Precio_"
        Me.Precio_.Name = "Precio_"
        '
        'Total_
        '
        Me.Total_.HeaderText = "Total_"
        Me.Total_.Name = "Total_"
        '
        'FechaCompra
        '
        Me.FechaCompra.HeaderText = "FechaCompra"
        Me.FechaCompra.Name = "FechaCompra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 37)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ventas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 37)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Compras"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(1020, 539)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 46)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Filtro Stock"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Fecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 694)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Fecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fecha"
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IdFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents IdPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
