<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarMarcas
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MarcasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.TableAdapterManager = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(164, 35)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(53, 20)
        Label3.TabIndex = 13
        Label3.Text = "Marca"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(36, 85)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(63, 20)
        Label2.TabIndex = 11
        Label2.Text = "Buscar:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(38, 148)
        MarcaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(57, 20)
        MarcaLabel.TabIndex = 20
        MarcaLabel.Text = "Marca:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(MarcaLabel)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.MarcaTextBox)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 200)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 288)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(210, 218)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(124, 143)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(148, 26)
        Me.MarcaTextBox.TabIndex = 21
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'BasedeDatosDataSet
        '
        Me.BasedeDatosDataSet.DataSetName = "BasedeDatosDataSet"
        Me.BasedeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MarcasBindingSource
        Me.ComboBox1.DisplayMember = "Marca"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 72)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "IdMarca"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(56, 218)
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
        Me.Label1.Location = New System.Drawing.Point(213, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 86)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Marcas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.DireccionTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ModificarMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ModificarMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarMarcas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents TableAdapterManager As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
End Class
