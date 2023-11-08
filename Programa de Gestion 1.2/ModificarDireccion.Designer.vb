<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarDireccion
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
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.DireccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DireccionTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.DireccionTableAdapter()
        Me.TableAdapterManager = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.Location = New System.Drawing.Point(64, 40)
        CodigoPostalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(111, 20)
        CodigoPostalLabel.TabIndex = 3
        CodigoPostalLabel.Text = "Codigo Postal:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(64, 80)
        LocalidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(81, 20)
        LocalidadLabel.TabIndex = 5
        LocalidadLabel.Text = "Localidad:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(64, 120)
        ProvinciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(76, 20)
        ProvinciaLabel.TabIndex = 7
        ProvinciaLabel.Text = "Provincia:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(80, 75)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(63, 20)
        Label2.TabIndex = 11
        Label2.Text = "Buscar:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(141, 37)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(107, 20)
        Label3.TabIndex = 13
        Label3.Text = "Codigo Postal"
        AddHandler Label3.Click, AddressOf Me.Label3_Click
        '
        'BasedeDatosDataSet
        '
        Me.BasedeDatosDataSet.DataSetName = "BasedeDatosDataSet"
        Me.BasedeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DireccionBindingSource
        '
        Me.DireccionBindingSource.DataMember = "Direccion"
        Me.DireccionBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'DireccionTableAdapter
        '
        Me.DireccionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.DireccionTableAdapter = Me.DireccionTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "CodigoPostal", True))
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(186, 35)
        Me.CodigoPostalTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(148, 26)
        Me.CodigoPostalTextBox.TabIndex = 4
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(186, 75)
        Me.LocalidadTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(148, 26)
        Me.LocalidadTextBox.TabIndex = 6
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(186, 115)
        Me.ProvinciaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(148, 26)
        Me.ProvinciaTextBox.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(CodigoPostalLabel)
        Me.GroupBox1.Controls.Add(Me.CodigoPostalTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(LocalidadLabel)
        Me.GroupBox1.Controls.Add(Me.ProvinciaTextBox)
        Me.GroupBox1.Controls.Add(Me.LocalidadTextBox)
        Me.GroupBox1.Controls.Add(ProvinciaLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 295)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 240)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(224, 175)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(69, 175)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(171, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 86)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Direccion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DireccionBindingSource
        Me.ComboBox1.DisplayMember = "CodigoPostal"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 72)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "IdDireccion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 157)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 129)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'ModificarDireccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ModificarDireccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarDireccion"
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents DireccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DireccionTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.DireccionTableAdapter
    Friend WithEvents TableAdapterManager As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodigoPostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
