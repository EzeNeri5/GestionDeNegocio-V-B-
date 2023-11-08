<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.BasedeDatosDataSet = New Programa_de_Gestion.BasedeDatosDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager()
        Me.ArticulosTableAdapter = New Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ArticulosTableAdapter()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(435, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 82)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ButtonVolver)
        Me.GroupBox1.Location = New System.Drawing.Point(318, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(500, 129)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(36, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 78)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nueva Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonVolver
        '
        Me.ButtonVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVolver.ForeColor = System.Drawing.Color.Crimson
        Me.ButtonVolver.Location = New System.Drawing.Point(368, 29)
        Me.ButtonVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(105, 78)
        Me.ButtonVolver.TabIndex = 0
        Me.ButtonVolver.Text = "Volver"
        Me.ButtonVolver.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.DireccionTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(83, 265)
        Me.VentasDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.Size = New System.Drawing.Size(1000, 350)
        Me.VentasDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFactura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdFactura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TipoFactura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TipoFactura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdCliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.BasedeDatosDataSet
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programa_de_Gestion.My.Resources.Resources.Sin_título_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1178, 644)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BasedeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonVolver As System.Windows.Forms.Button
    Friend WithEvents BasedeDatosDataSet As Programa_de_Gestion.BasedeDatosDataSet
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosTableAdapter As Programa_de_Gestion.BasedeDatosDataSetTableAdapters.ArticulosTableAdapter
    Friend WithEvents VentasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
End Class
