<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearVentas
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
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim IdArticuloLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TipoFacturaLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager()
        Me.ArticulosTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ArticulosTableAdapter()
        Me.ClientesTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ClientesTableAdapter()
        Me.MarcasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdClienteLabel = New System.Windows.Forms.Label()
        IdArticuloLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TipoFacturaLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(15, 42)
        IdClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(80, 20)
        IdClienteLabel.TabIndex = 5
        IdClienteLabel.Text = "Id Cliente:"
        '
        'IdArticuloLabel
        '
        IdArticuloLabel.AutoSize = True
        IdArticuloLabel.Location = New System.Drawing.Point(26, 46)
        IdArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdArticuloLabel.Name = "IdArticuloLabel"
        IdArticuloLabel.Size = New System.Drawing.Size(70, 20)
        IdArticuloLabel.TabIndex = 7
        IdArticuloLabel.Text = "Articulos"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(234, 92)
        CantidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(77, 20)
        CantidadLabel.TabIndex = 9
        CantidadLabel.Text = "Cantidad:"
        AddHandler CantidadLabel.Click, AddressOf Me.CantidadLabel_Click
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(510, 92)
        PrecioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(57, 20)
        PrecioLabel.TabIndex = 11
        PrecioLabel.Text = "Precio:"
        AddHandler PrecioLabel.Click, AddressOf Me.PrecioLabel_Click
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(256, 148)
        TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(48, 20)
        TotalLabel.TabIndex = 13
        TotalLabel.Text = "Total:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(40, 45)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(58, 20)
        FechaLabel.TabIndex = 15
        FechaLabel.Text = "Fecha:"
        '
        'TipoFacturaLabel1
        '
        TipoFacturaLabel1.AutoSize = True
        TipoFacturaLabel1.Location = New System.Drawing.Point(332, 46)
        TipoFacturaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TipoFacturaLabel1.Name = "TipoFacturaLabel1"
        TipoFacturaLabel1.Size = New System.Drawing.Size(102, 20)
        TipoFacturaLabel1.TabIndex = 19
        TipoFacturaLabel1.Text = "Tipo Factura:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(506, 42)
        ApellidoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(69, 20)
        ApellidoLabel.TabIndex = 21
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(248, 42)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(69, 20)
        NombreLabel.TabIndex = 22
        NombreLabel.Text = "Nombre:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(466, 48)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(96, 20)
        DescripcionLabel.TabIndex = 25
        DescripcionLabel.Text = "Descripcion:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(44, 92)
        ColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(50, 20)
        ColorLabel.TabIndex = 26
        ColorLabel.Text = "Color:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(244, 46)
        CodigoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(63, 20)
        CodigoLabel.TabIndex = 27
        CodigoLabel.Text = "Codigo:"
        '
        'BasedeDatosDataSet
        '
        Me.BasedeDatosDataSet.DataSetName = "BasedeDatosDataSet"
        Me.BasedeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.DireccionTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(316, 89)
        Me.CantidadTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(114, 26)
        Me.CantidadTextBox.TabIndex = 15
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(598, 89)
        Me.PrecioTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(114, 26)
        Me.PrecioTextBox.TabIndex = 16
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(316, 145)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(114, 26)
        Me.TotalTextBox.TabIndex = 17
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(110, 38)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(115, 26)
        Me.FechaDateTimePicker.TabIndex = 1
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B"})
        Me.ComboBox1.Location = New System.Drawing.Point(446, 42)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(129, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ClientesBindingSource
        Me.ComboBox2.DisplayMember = "IdCliente"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(105, 38)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(116, 28)
        Me.ComboBox2.TabIndex = 5
        Me.ComboBox2.ValueMember = "IdCliente"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ArticulosBindingSource
        Me.ComboBox3.DisplayMember = "Codigo"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(104, 42)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(114, 28)
        Me.ComboBox3.TabIndex = 11
        Me.ComboBox3.ValueMember = "IdArticulo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(TipoFacturaLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(744, 102)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(CodigoLabel)
        Me.GroupBox2.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox2.Controls.Add(ColorLabel)
        Me.GroupBox2.Controls.Add(Me.ColorTextBox)
        Me.GroupBox2.Controls.Add(DescripcionLabel)
        Me.GroupBox2.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(IdArticuloLabel)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(CantidadLabel)
        Me.GroupBox2.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox2.Controls.Add(PrecioLabel)
        Me.GroupBox2.Controls.Add(Me.TotalTextBox)
        Me.GroupBox2.Controls.Add(Me.PrecioTextBox)
        Me.GroupBox2.Controls.Add(TotalLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 312)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(744, 266)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(316, 42)
        Me.CodigoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(94, 26)
        Me.CodigoTextBox.TabIndex = 12
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(104, 89)
        Me.ColorTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(106, 26)
        Me.ColorTextBox.TabIndex = 14
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(574, 43)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(148, 26)
        Me.DescripcionTextBox.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(388, 208)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(192, 208)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(585, 38)
        Me.ApellidoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(148, 26)
        Me.ApellidoTextBox.TabIndex = 10
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(328, 38)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(148, 26)
        Me.NombreTextBox.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(NombreLabel)
        Me.GroupBox3.Controls.Add(IdClienteLabel)
        Me.GroupBox3.Controls.Add(Me.NombreTextBox)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(ApellidoLabel)
        Me.GroupBox3.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 208)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(744, 91)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(238, -8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 82)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'CrearVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 594)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CrearVentas"
        Me.Text = "CrearVentas"
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArticulosTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ArticulosTableAdapter
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Protected WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MarcasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
End Class
