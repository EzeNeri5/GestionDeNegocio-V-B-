<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearClientes
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
        Dim Cuit_Cuil_DNILabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel1 As System.Windows.Forms.Label
        Dim CalleLabel1 As System.Windows.Forms.Label
        Dim AlturaLabel1 As System.Windows.Forms.Label
        Dim TelefonoLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TelefonoTextBox1 = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlturaTextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DireccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalleTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ApellidoTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.Cuit_Cuil_DNITextBox1 = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager()
        Me.DireccionTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.DireccionTableAdapter()
        Cuit_Cuil_DNILabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel1 = New System.Windows.Forms.Label()
        CalleLabel1 = New System.Windows.Forms.Label()
        AlturaLabel1 = New System.Windows.Forms.Label()
        TelefonoLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cuit_Cuil_DNILabel1
        '
        Cuit_Cuil_DNILabel1.AutoSize = True
        Cuit_Cuil_DNILabel1.Location = New System.Drawing.Point(159, 34)
        Cuit_Cuil_DNILabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cuit_Cuil_DNILabel1.Name = "Cuit_Cuil_DNILabel1"
        Cuit_Cuil_DNILabel1.Size = New System.Drawing.Size(103, 20)
        Cuit_Cuil_DNILabel1.TabIndex = 29
        Cuit_Cuil_DNILabel1.Text = "Cuit/Cuil/DNI:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(32, 88)
        NombreLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(69, 20)
        NombreLabel1.TabIndex = 31
        NombreLabel1.Text = "Nombre:"
        '
        'ApellidoLabel1
        '
        ApellidoLabel1.AutoSize = True
        ApellidoLabel1.Location = New System.Drawing.Point(392, 88)
        ApellidoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidoLabel1.Name = "ApellidoLabel1"
        ApellidoLabel1.Size = New System.Drawing.Size(69, 20)
        ApellidoLabel1.TabIndex = 33
        ApellidoLabel1.Text = "Apellido:"
        '
        'CalleLabel1
        '
        CalleLabel1.AutoSize = True
        CalleLabel1.Location = New System.Drawing.Point(42, 46)
        CalleLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CalleLabel1.Name = "CalleLabel1"
        CalleLabel1.Size = New System.Drawing.Size(48, 20)
        CalleLabel1.TabIndex = 35
        CalleLabel1.Text = "Calle:"
        '
        'AlturaLabel1
        '
        AlturaLabel1.AutoSize = True
        AlturaLabel1.Location = New System.Drawing.Point(364, 46)
        AlturaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AlturaLabel1.Name = "AlturaLabel1"
        AlturaLabel1.Size = New System.Drawing.Size(55, 20)
        AlturaLabel1.TabIndex = 37
        AlturaLabel1.Text = "Altura:"
        '
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.Location = New System.Drawing.Point(192, 57)
        TelefonoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel1.Name = "TelefonoLabel1"
        TelefonoLabel1.Size = New System.Drawing.Size(75, 20)
        TelefonoLabel1.TabIndex = 41
        TelefonoLabel1.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(234, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 86)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(425, 543)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(249, 543)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(TelefonoLabel1)
        Me.GroupBox3.Controls.Add(Me.TelefonoTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 411)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(732, 112)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto"
        '
        'TelefonoTextBox1
        '
        Me.TelefonoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefono", True))
        Me.TelefonoTextBox1.Location = New System.Drawing.Point(279, 52)
        Me.TelefonoTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TelefonoTextBox1.Name = "TelefonoTextBox1"
        Me.TelefonoTextBox1.Size = New System.Drawing.Size(181, 26)
        Me.TelefonoTextBox1.TabIndex = 42
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'BasedeDatosDataSet
        '
        Me.BasedeDatosDataSet.DataSetName = "BasedeDatosDataSet"
        Me.BasedeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(AlturaLabel1)
        Me.GroupBox2.Controls.Add(CalleLabel1)
        Me.GroupBox2.Controls.Add(Me.AlturaTextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.CalleTextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 234)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(732, 178)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Provincia:"
        '
        'AlturaTextBox1
        '
        Me.AlturaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Altura", True))
        Me.AlturaTextBox1.Location = New System.Drawing.Point(429, 35)
        Me.AlturaTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlturaTextBox1.Name = "AlturaTextBox1"
        Me.AlturaTextBox1.Size = New System.Drawing.Size(67, 26)
        Me.AlturaTextBox1.TabIndex = 38
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.DireccionBindingSource
        Me.ComboBox3.DisplayMember = "Provincia"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(512, 95)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(174, 28)
        Me.ComboBox3.TabIndex = 8
        Me.ComboBox3.ValueMember = "IdDireccion"
        '
        'DireccionBindingSource
        '
        Me.DireccionBindingSource.DataMember = "Direccion"
        Me.DireccionBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'CalleTextBox1
        '
        Me.CalleTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Calle", True))
        Me.CalleTextBox1.Location = New System.Drawing.Point(129, 35)
        Me.CalleTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CalleTextBox1.Name = "CalleTextBox1"
        Me.CalleTextBox1.Size = New System.Drawing.Size(224, 26)
        Me.CalleTextBox1.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Localidad: "
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.DireccionBindingSource
        Me.ComboBox2.DisplayMember = "Localidad"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(129, 94)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(224, 28)
        Me.ComboBox2.TabIndex = 6
        Me.ComboBox2.ValueMember = "IdDireccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Codigo Postal:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DireccionBindingSource
        Me.ComboBox1.DisplayMember = "CodigoPostal"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(628, 35)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(85, 28)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "IdDireccion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ApellidoLabel1)
        Me.GroupBox1.Controls.Add(NombreLabel1)
        Me.GroupBox1.Controls.Add(Me.ApellidoTextBox1)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox1)
        Me.GroupBox1.Controls.Add(Cuit_Cuil_DNILabel1)
        Me.GroupBox1.Controls.Add(Me.Cuit_Cuil_DNITextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 94)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(732, 143)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificacion"
        '
        'ApellidoTextBox1
        '
        Me.ApellidoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Apellido", True))
        Me.ApellidoTextBox1.Location = New System.Drawing.Point(471, 82)
        Me.ApellidoTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ApellidoTextBox1.Name = "ApellidoTextBox1"
        Me.ApellidoTextBox1.Size = New System.Drawing.Size(242, 26)
        Me.ApellidoTextBox1.TabIndex = 34
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(111, 82)
        Me.NombreTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(242, 26)
        Me.NombreTextBox1.TabIndex = 32
        '
        'Cuit_Cuil_DNITextBox1
        '
        Me.Cuit_Cuil_DNITextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cuit/Cuil/DNI", True))
        Me.Cuit_Cuil_DNITextBox1.Location = New System.Drawing.Point(279, 29)
        Me.Cuit_Cuil_DNITextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cuit_Cuil_DNITextBox1.Name = "Cuit_Cuil_DNITextBox1"
        Me.Cuit_Cuil_DNITextBox1.Size = New System.Drawing.Size(174, 26)
        Me.Cuit_Cuil_DNITextBox1.TabIndex = 30
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.DireccionTableAdapter = Me.DireccionTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'DireccionTableAdapter
        '
        Me.DireccionTableAdapter.ClearBeforeFill = True
        '
        'CrearClientes
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
        Me.Name = "CrearClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearClientes"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TelefonoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AlturaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CalleTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cuit_Cuil_DNITextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.DireccionTableAdapter
    Friend WithEvents DireccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
