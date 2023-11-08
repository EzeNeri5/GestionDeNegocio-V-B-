<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ComprasTableAdapter()
        Me.TableAdapterManager = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager()
        Me.ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BasedeDatosDataSet
        '
        Me.BasedeDatosDataSet.DataSetName = "BasedeDatosDataSet"
        Me.BasedeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.DireccionTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ComprasDataGridView
        '
        Me.ComprasDataGridView.AutoGenerateColumns = False
        Me.ComprasDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ComprasDataGridView.DataSource = Me.ComprasBindingSource
        Me.ComprasDataGridView.Location = New System.Drawing.Point(79, 276)
        Me.ComprasDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComprasDataGridView.Name = "ComprasDataGridView"
        Me.ComprasDataGridView.RowTemplate.Height = 24
        Me.ComprasDataGridView.Size = New System.Drawing.Size(1000, 350)
        Me.ComprasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPedido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPedido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdProveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(372, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 86)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Compras"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonVolver)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(158, 100)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(775, 156)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'ButtonVolver
        '
        Me.ButtonVolver.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVolver.ForeColor = System.Drawing.Color.Crimson
        Me.ButtonVolver.Location = New System.Drawing.Point(556, 49)
        Me.ButtonVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(152, 59)
        Me.ButtonVolver.TabIndex = 1
        Me.ButtonVolver.Text = "Volver"
        Me.ButtonVolver.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(36, 49)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nueva compra"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programa_de_Gestion.My.Resources.Resources.Sin_título_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1178, 644)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComprasDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents TableAdapterManager As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonVolver As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
