<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Prog07DataSet = New ExBDSQL.Prog07DataSet()
        Me.Prog07DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RHTableAdapter = New ExBDSQL.Prog07DataSetTableAdapters.RHTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prog07DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prog07DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de Gestores"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.DepartamentoDataGridViewTextBoxColumn, Me.LocalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RHBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 161)
        Me.DataGridView1.TabIndex = 1
        '
        'Prog07DataSet
        '
        Me.Prog07DataSet.DataSetName = "Prog07DataSet"
        Me.Prog07DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Prog07DataSetBindingSource
        '
        Me.Prog07DataSetBindingSource.DataSource = Me.Prog07DataSet
        Me.Prog07DataSetBindingSource.Position = 0
        '
        'RHBindingSource
        '
        Me.RHBindingSource.DataMember = "RH"
        Me.RHBindingSource.DataSource = Me.Prog07DataSetBindingSource
        '
        'RHTableAdapter
        '
        Me.RHTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'DepartamentoDataGridViewTextBoxColumn
        '
        Me.DepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.Name = "DepartamentoDataGridViewTextBoxColumn"
        '
        'LocalDataGridViewTextBoxColumn
        '
        Me.LocalDataGridViewTextBoxColumn.DataPropertyName = "Local"
        Me.LocalDataGridViewTextBoxColumn.HeaderText = "Local"
        Me.LocalDataGridViewTextBoxColumn.Name = "LocalDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 296)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prog07DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prog07DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Prog07DataSetBindingSource As BindingSource
    Friend WithEvents Prog07DataSet As Prog07DataSet
    Friend WithEvents RHBindingSource As BindingSource
    Friend WithEvents RHTableAdapter As Prog07DataSetTableAdapters.RHTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
