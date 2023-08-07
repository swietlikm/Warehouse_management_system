<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uzytkownicy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Uzytkownicy))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MagDbDataSet = New MagDbDataSet()
        Me.UZYTKOWNICYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UZYTKOWNICYTableAdapter = New MagDbDataSetTableAdapters.UZYTKOWNICYTableAdapter()
        Me.TableAdapterManager = New MagDbDataSetTableAdapters.TableAdapterManager()
        Me.UZYTKOWNICYBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UZYTKOWNICYBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UZYTKOWNICYDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MagDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UZYTKOWNICYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UZYTKOWNICYBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UZYTKOWNICYBindingNavigator.SuspendLayout()
        CType(Me.UZYTKOWNICYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MagDbDataSet
        '
        Me.MagDbDataSet.DataSetName = "MagDbDataSet"
        Me.MagDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UZYTKOWNICYBindingSource
        '
        Me.UZYTKOWNICYBindingSource.DataMember = "UZYTKOWNICY"
        Me.UZYTKOWNICYBindingSource.DataSource = Me.MagDbDataSet
        '
        'UZYTKOWNICYTableAdapter
        '
        Me.UZYTKOWNICYTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DOSTAWYTableAdapter = Nothing
        Me.TableAdapterManager.MATERIALYTableAdapter = Nothing
        Me.TableAdapterManager.MG_ruchyTableAdapter = Nothing
        Me.TableAdapterManager.MGTableAdapter = Nothing
        Me.TableAdapterManager.MP_ruchyTableAdapter = Nothing
        Me.TableAdapterManager.MPTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MagDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UZYTKOWNICYTableAdapter = Me.UZYTKOWNICYTableAdapter
        '
        'UZYTKOWNICYBindingNavigator
        '
        Me.UZYTKOWNICYBindingNavigator.AddNewItem = Nothing
        Me.UZYTKOWNICYBindingNavigator.BindingSource = Me.UZYTKOWNICYBindingSource
        Me.UZYTKOWNICYBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UZYTKOWNICYBindingNavigator.DeleteItem = Nothing
        Me.UZYTKOWNICYBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UZYTKOWNICYBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.UZYTKOWNICYBindingNavigatorSaveItem})
        Me.UZYTKOWNICYBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UZYTKOWNICYBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UZYTKOWNICYBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UZYTKOWNICYBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UZYTKOWNICYBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UZYTKOWNICYBindingNavigator.Name = "UZYTKOWNICYBindingNavigator"
        Me.UZYTKOWNICYBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UZYTKOWNICYBindingNavigator.Size = New System.Drawing.Size(331, 27)
        Me.UZYTKOWNICYBindingNavigator.TabIndex = 0
        Me.UZYTKOWNICYBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 24)
        Me.BindingNavigatorCountItem.Text = "z {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Suma elementów"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
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
        'UZYTKOWNICYBindingNavigatorSaveItem
        '
        Me.UZYTKOWNICYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UZYTKOWNICYBindingNavigatorSaveItem.Image = CType(resources.GetObject("UZYTKOWNICYBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UZYTKOWNICYBindingNavigatorSaveItem.Name = "UZYTKOWNICYBindingNavigatorSaveItem"
        Me.UZYTKOWNICYBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.UZYTKOWNICYBindingNavigatorSaveItem.Text = "Zapisz dane"
        '
        'UZYTKOWNICYDataGridView
        '
        Me.UZYTKOWNICYDataGridView.AllowUserToAddRows = False
        Me.UZYTKOWNICYDataGridView.AllowUserToDeleteRows = False
        Me.UZYTKOWNICYDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UZYTKOWNICYDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.UZYTKOWNICYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UZYTKOWNICYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3})
        Me.UZYTKOWNICYDataGridView.DataSource = Me.UZYTKOWNICYBindingSource
        Me.UZYTKOWNICYDataGridView.Location = New System.Drawing.Point(15, 34)
        Me.UZYTKOWNICYDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UZYTKOWNICYDataGridView.Name = "UZYTKOWNICYDataGridView"
        Me.UZYTKOWNICYDataGridView.RowHeadersVisible = False
        Me.UZYTKOWNICYDataGridView.RowHeadersWidth = 51
        Me.UZYTKOWNICYDataGridView.Size = New System.Drawing.Size(299, 95)
        Me.UZYTKOWNICYDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "status"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "*"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "status"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "haslo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "haslo"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'Uzytkownicy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 142)
        Me.Controls.Add(Me.UZYTKOWNICYDataGridView)
        Me.Controls.Add(Me.UZYTKOWNICYBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Uzytkownicy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uzytkownicy"
        CType(Me.MagDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UZYTKOWNICYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UZYTKOWNICYBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UZYTKOWNICYBindingNavigator.ResumeLayout(False)
        Me.UZYTKOWNICYBindingNavigator.PerformLayout()
        CType(Me.UZYTKOWNICYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MagDbDataSet As MagDbDataSet
    Friend WithEvents UZYTKOWNICYBindingSource As BindingSource
    Friend WithEvents UZYTKOWNICYTableAdapter As MagDbDataSetTableAdapters.UZYTKOWNICYTableAdapter
    Friend WithEvents TableAdapterManager As MagDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UZYTKOWNICYBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UZYTKOWNICYBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UZYTKOWNICYDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
