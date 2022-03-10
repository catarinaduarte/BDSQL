<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim LocalLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Prog07DataSet = New ExBDSQL.Prog07DataSet()
        Me.RHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RHTableAdapter = New ExBDSQL.Prog07DataSetTableAdapters.RHTableAdapter()
        Me.TableAdapterManager = New ExBDSQL.Prog07DataSetTableAdapters.TableAdapterManager()
        Me.RHBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RHBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DepartamentoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        LocalLabel = New System.Windows.Forms.Label()
        CType(Me.Prog07DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RHBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RHBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(43, 97)
        IdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(20, 15)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(33, 166)
        NomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(44, 15)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de Gestores"
        '
        'Prog07DataSet
        '
        Me.Prog07DataSet.DataSetName = "Prog07DataSet"
        Me.Prog07DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RHBindingSource
        '
        Me.RHBindingSource.DataMember = "RH"
        Me.RHBindingSource.DataSource = Me.Prog07DataSet
        '
        'RHTableAdapter
        '
        Me.RHTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RHTableAdapter = Me.RHTableAdapter
        Me.TableAdapterManager.UpdateOrder = ExBDSQL.Prog07DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RHBindingNavigator
        '
        Me.RHBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RHBindingNavigator.BindingSource = Me.RHBindingSource
        Me.RHBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RHBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RHBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RHBindingNavigatorSaveItem})
        Me.RHBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RHBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RHBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RHBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RHBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RHBindingNavigator.Name = "RHBindingNavigator"
        Me.RHBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RHBindingNavigator.Size = New System.Drawing.Size(452, 25)
        Me.RHBindingNavigator.TabIndex = 1
        Me.RHBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(35, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RHBindingNavigatorSaveItem
        '
        Me.RHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RHBindingNavigatorSaveItem.Image = CType(resources.GetObject("RHBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RHBindingNavigatorSaveItem.Name = "RHBindingNavigatorSaveItem"
        Me.RHBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RHBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RHBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(114, 77)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdTextBox.Multiline = True
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(326, 50)
        Me.IdTextBox.TabIndex = 3
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RHBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(114, 141)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NomeTextBox.Multiline = True
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(326, 55)
        Me.NomeTextBox.TabIndex = 5
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartamentoLabel.Location = New System.Drawing.Point(11, 228)
        DepartamentoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(89, 15)
        DepartamentoLabel.TabIndex = 6
        DepartamentoLabel.Text = "Departamento:"
        '
        'DepartamentoTextBox
        '
        Me.DepartamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RHBindingSource, "Departamento", True))
        Me.DepartamentoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartamentoTextBox.Location = New System.Drawing.Point(114, 206)
        Me.DepartamentoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DepartamentoTextBox.Multiline = True
        Me.DepartamentoTextBox.Name = "DepartamentoTextBox"
        Me.DepartamentoTextBox.Size = New System.Drawing.Size(326, 49)
        Me.DepartamentoTextBox.TabIndex = 7
        '
        'LocalLabel
        '
        LocalLabel.AutoSize = True
        LocalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalLabel.Location = New System.Drawing.Point(43, 301)
        LocalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LocalLabel.Name = "LocalLabel"
        LocalLabel.Size = New System.Drawing.Size(40, 15)
        LocalLabel.TabIndex = 8
        LocalLabel.Text = "Local:"
        '
        'LocalTextBox
        '
        Me.LocalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RHBindingSource, "Local", True))
        Me.LocalTextBox.Location = New System.Drawing.Point(114, 271)
        Me.LocalTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LocalTextBox.Multiline = True
        Me.LocalTextBox.Name = "LocalTextBox"
        Me.LocalTextBox.Size = New System.Drawing.Size(326, 45)
        Me.LocalTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Dados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 418)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(LocalLabel)
        Me.Controls.Add(Me.LocalTextBox)
        Me.Controls.Add(DepartamentoLabel)
        Me.Controls.Add(Me.DepartamentoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.RHBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Prog07DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RHBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RHBindingNavigator.ResumeLayout(False)
        Me.RHBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Prog07DataSet As Prog07DataSet
    Friend WithEvents RHBindingSource As BindingSource
    Friend WithEvents RHTableAdapter As Prog07DataSetTableAdapters.RHTableAdapter
    Friend WithEvents TableAdapterManager As Prog07DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RHBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RHBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents DepartamentoTextBox As TextBox
    Friend WithEvents LocalTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
