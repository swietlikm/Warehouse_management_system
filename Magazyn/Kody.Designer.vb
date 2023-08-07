<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kody
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.lblKod = New System.Windows.Forms.Label()
        Me.CB_aktywne = New System.Windows.Forms.CheckBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.a, Me.b})
        Me.DGV.Location = New System.Drawing.Point(12, 64)
        Me.DGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(568, 327)
        Me.DGV.TabIndex = 0
        '
        'a
        '
        Me.a.HeaderText = "Kod ZP"
        Me.a.MinimumWidth = 6
        Me.a.Name = "a"
        Me.a.ReadOnly = True
        Me.a.Width = 125
        '
        'b
        '
        Me.b.HeaderText = "Opis Galileo"
        Me.b.MinimumWidth = 6
        Me.b.Name = "b"
        Me.b.ReadOnly = True
        Me.b.Width = 280
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TB_kod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(211, 23)
        Me.TB_kod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(127, 22)
        Me.TB_kod.TabIndex = 0
        '
        'lblKod
        '
        Me.lblKod.AutoSize = True
        Me.lblKod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblKod.Location = New System.Drawing.Point(123, 26)
        Me.lblKod.Name = "lblKod"
        Me.lblKod.Size = New System.Drawing.Size(81, 17)
        Me.lblKod.TabIndex = 2
        Me.lblKod.Text = "Wyszukaj:"
        '
        'CB_aktywne
        '
        Me.CB_aktywne.AutoSize = True
        Me.CB_aktywne.Checked = True
        Me.CB_aktywne.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_aktywne.Location = New System.Drawing.Point(357, 27)
        Me.CB_aktywne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_aktywne.Name = "CB_aktywne"
        Me.CB_aktywne.Size = New System.Drawing.Size(157, 21)
        Me.CB_aktywne.TabIndex = 3
        Me.CB_aktywne.Text = "Pokaż tylko aktywne"
        Me.CB_aktywne.UseVisualStyleBackColor = True
        '
        'Kody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 402)
        Me.Controls.Add(Me.CB_aktywne)
        Me.Controls.Add(Me.lblKod)
        Me.Controls.Add(Me.TB_kod)
        Me.Controls.Add(Me.DGV)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Kody"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wyszukiwarka kodów galileo"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents lblKod As Label
    Friend WithEvents a As DataGridViewTextBoxColumn
    Friend WithEvents b As DataGridViewTextBoxColumn
    Friend WithEvents CB_aktywne As CheckBox
    Friend WithEvents ToolTip As ToolTip
End Class
