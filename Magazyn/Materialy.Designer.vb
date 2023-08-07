<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materialy
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Materialy))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MagDbDataSet = New MagDbDataSet()
        Me.MATERIALYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATERIALYTableAdapter = New MagDbDataSetTableAdapters.MATERIALYTableAdapter()
        Me.TableAdapterManager = New MagDbDataSetTableAdapters.TableAdapterManager()
        Me.MATERIALYBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MATERIALYBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MATERIALYDataGridView = New System.Windows.Forms.DataGridView()
        Me.OznaczenieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MagDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIALYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIALYBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MATERIALYBindingNavigator.SuspendLayout()
        CType(Me.MATERIALYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MagDbDataSet
        '
        Me.MagDbDataSet.DataSetName = "MagDbDataSet"
        Me.MagDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MATERIALYBindingSource
        '
        Me.MATERIALYBindingSource.DataMember = "MATERIALY"
        Me.MATERIALYBindingSource.DataSource = Me.MagDbDataSet
        '
        'MATERIALYTableAdapter
        '
        Me.MATERIALYTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MATERIALYTableAdapter = Me.MATERIALYTableAdapter
        Me.TableAdapterManager.MG_ruchyTableAdapter = Nothing
        Me.TableAdapterManager.MGTableAdapter = Nothing
        Me.TableAdapterManager.MP_ruchyTableAdapter = Nothing
        Me.TableAdapterManager.MPTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MagDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UZYTKOWNICYTableAdapter = Nothing
        '
        'MATERIALYBindingNavigator
        '
        Me.MATERIALYBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MATERIALYBindingNavigator.BindingSource = Me.MATERIALYBindingSource
        Me.MATERIALYBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MATERIALYBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MATERIALYBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MATERIALYBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MATERIALYBindingNavigatorSaveItem})
        Me.MATERIALYBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MATERIALYBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MATERIALYBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MATERIALYBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MATERIALYBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MATERIALYBindingNavigator.Name = "MATERIALYBindingNavigator"
        Me.MATERIALYBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MATERIALYBindingNavigator.Size = New System.Drawing.Size(356, 27)
        Me.MATERIALYBindingNavigator.TabIndex = 0
        Me.MATERIALYBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Dodaj nowy"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 24)
        Me.BindingNavigatorCountItem.Text = "z {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Suma elementów"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Usuń"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Pozycja"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Przenieś następny"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Przenieś ostatni"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'MATERIALYBindingNavigatorSaveItem
        '
        Me.MATERIALYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MATERIALYBindingNavigatorSaveItem.Image = CType(resources.GetObject("MATERIALYBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MATERIALYBindingNavigatorSaveItem.Name = "MATERIALYBindingNavigatorSaveItem"
        Me.MATERIALYBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.MATERIALYBindingNavigatorSaveItem.Text = "Zapisz dane"
        '
        'MATERIALYDataGridView
        '
        Me.MATERIALYDataGridView.AutoGenerateColumns = False
        Me.MATERIALYDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MATERIALYDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MATERIALYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MATERIALYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OznaczenieDataGridViewTextBoxColumn})
        Me.MATERIALYDataGridView.DataSource = Me.MATERIALYBindingSource
        Me.MATERIALYDataGridView.Location = New System.Drawing.Point(12, 30)
        Me.MATERIALYDataGridView.Name = "MATERIALYDataGridView"
        Me.MATERIALYDataGridView.RowHeadersVisible = False
        Me.MATERIALYDataGridView.RowHeadersWidth = 51
        Me.MATERIALYDataGridView.RowTemplate.Height = 24
        Me.MATERIALYDataGridView.Size = New System.Drawing.Size(330, 359)
        Me.MATERIALYDataGridView.TabIndex = 2
        '
        'OznaczenieDataGridViewTextBoxColumn
        '
        Me.OznaczenieDataGridViewTextBoxColumn.DataPropertyName = "oznaczenie"
        Me.OznaczenieDataGridViewTextBoxColumn.HeaderText = "Nazwa"
        Me.OznaczenieDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OznaczenieDataGridViewTextBoxColumn.Name = "OznaczenieDataGridViewTextBoxColumn"
        Me.OznaczenieDataGridViewTextBoxColumn.Width = 220
        '
        'Materialy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 400)
        Me.Controls.Add(Me.MATERIALYDataGridView)
        Me.Controls.Add(Me.MATERIALYBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Materialy"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materialy"
        CType(Me.MagDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIALYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIALYBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MATERIALYBindingNavigator.ResumeLayout(False)
        Me.MATERIALYBindingNavigator.PerformLayout()
        CType(Me.MATERIALYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MagDbDataSet As MagDbDataSet
    Friend WithEvents MATERIALYBindingSource As BindingSource
    Friend WithEvents MATERIALYTableAdapter As MagDbDataSetTableAdapters.MATERIALYTableAdapter
    Friend WithEvents TableAdapterManager As MagDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MATERIALYBindingNavigator As BindingNavigator
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
    Friend WithEvents MATERIALYBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MATERIALYDataGridView As DataGridView
    Friend WithEvents OznaczenieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
