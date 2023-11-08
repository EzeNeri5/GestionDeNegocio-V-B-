<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearArticulos
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Stock_MinimoLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager()
        Me.DireccionTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.DireccionTableAdapter()
        Me.MarcasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.ProveedoresTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ProveedoresTableAdapter()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_MinimoTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DireccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CodigoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Stock_MinimoLabel = New System.Windows.Forms.Label()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(76, 34)
        CodigoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(63, 20)
        CodigoLabel.TabIndex = 15
        CodigoLabel.Text = "Codigo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(42, 98)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(96, 20)
        DescripcionLabel.TabIndex = 17
        DescripcionLabel.Text = "Descripcion:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(411, 100)
        ColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(50, 20)
        ColorLabel.TabIndex = 19
        ColorLabel.Text = "Color:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(63, 55)
        CantidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(77, 20)
        CantidadLabel.TabIndex = 25
        CantidadLabel.Text = "Cantidad:"
        '
        'Stock_MinimoLabel
        '
        Stock_MinimoLabel.AutoSize = True
        Stock_MinimoLabel.Location = New System.Drawing.Point(327, 55)
        Stock_MinimoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Stock_MinimoLabel.Name = "Stock_MinimoLabel"
        Stock_MinimoLabel.Size = New System.Drawing.Size(108, 20)
        Stock_MinimoLabel.TabIndex = 27
        Stock_MinimoLabel.Text = "Stock Minimo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(239, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 86)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Articulo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BasedeDatosDataSet
        '
        Me.BasedeDatosDataSet.DataSetName = "BasedeDatosDataSet"
        Me.BasedeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.DireccionTableAdapter = Me.DireccionTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'DireccionTableAdapter
        '
        Me.DireccionTableAdapter.ClearBeforeFill = True
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(150, 29)
        Me.CodigoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(148, 26)
        Me.CodigoTextBox.TabIndex = 16
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(150, 94)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(230, 26)
        Me.DescripcionTextBox.TabIndex = 18
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(471, 94)
        Me.ColorTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(148, 26)
        Me.ColorTextBox.TabIndex = 20
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(150, 51)
        Me.CantidadTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(148, 26)
        Me.CantidadTextBox.TabIndex = 26
        '
        'Stock_MinimoTextBox
        '
        Me.Stock_MinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Stock Minimo", True))
        Me.Stock_MinimoTextBox.Location = New System.Drawing.Point(447, 51)
        Me.Stock_MinimoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Stock_MinimoTextBox.Name = "Stock_MinimoTextBox"
        Me.Stock_MinimoTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Stock_MinimoTextBox.TabIndex = 28
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(CantidadLabel)
        Me.GroupBox3.Controls.Add(Me.Stock_MinimoTextBox)
        Me.GroupBox3.Controls.Add(Stock_MinimoLabel)
        Me.GroupBox3.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(72, 404)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(670, 112)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 258)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(670, 128)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marca y Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Proveedor"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ProveedoresBindingSource
        Me.ComboBox2.DisplayMember = "Nombre"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(416, 52)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.ValueMember = "IdProveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MarcasBindingSource
        Me.ComboBox1.DisplayMember = "Marca"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(118, 52)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "IdMarca"
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CodigoLabel)
        Me.GroupBox1.Controls.Add(Me.ColorTextBox)
        Me.GroupBox1.Controls.Add(ColorLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(670, 143)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Articulo"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(423, 531)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(248, 531)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DireccionBindingSource
        '
        Me.DireccionBindingSource.DataMember = "Direccion"
        Me.DireccionBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'CrearArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 594)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CrearArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearArticulos"
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_MinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DireccionTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.DireccionTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MarcasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DireccionBindingSource As System.Windows.Forms.BindingSource
End Class
