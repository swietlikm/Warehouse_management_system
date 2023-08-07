<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MG_przenies_regal
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
        Me.CB_uwagi_mod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_przenies_regal = New System.Windows.Forms.Button()
        Me.LV_lista = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilosc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_prod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_nat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_regal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_nowy_regal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CB_uwagi_mod
        '
        Me.CB_uwagi_mod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_uwagi_mod.Items.AddRange(New Object() {"", "Błąd", "Porządki"})
        Me.CB_uwagi_mod.Location = New System.Drawing.Point(133, 271)
        Me.CB_uwagi_mod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_uwagi_mod.MaxLength = 80
        Me.CB_uwagi_mod.Name = "CB_uwagi_mod"
        Me.CB_uwagi_mod.Size = New System.Drawing.Size(300, 24)
        Me.CB_uwagi_mod.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 274)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Uwagi do ruchu:"
        '
        'BT_przenies_regal
        '
        Me.BT_przenies_regal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BT_przenies_regal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_przenies_regal.Location = New System.Drawing.Point(133, 303)
        Me.BT_przenies_regal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_przenies_regal.Name = "BT_przenies_regal"
        Me.BT_przenies_regal.Size = New System.Drawing.Size(208, 37)
        Me.BT_przenies_regal.TabIndex = 3
        Me.BT_przenies_regal.Text = "Przenieś regał"
        Me.BT_przenies_regal.UseVisualStyleBackColor = False
        '
        'LV_lista
        '
        Me.LV_lista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LV_lista.AutoArrange = False
        Me.LV_lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.kod, Me.ilosc, Me.lotto_prod, Me.lotto_nat})
        Me.LV_lista.FullRowSelect = True
        Me.LV_lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV_lista.HideSelection = False
        Me.LV_lista.Location = New System.Drawing.Point(16, 44)
        Me.LV_lista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LV_lista.MultiSelect = False
        Me.LV_lista.Name = "LV_lista"
        Me.LV_lista.ShowItemToolTips = True
        Me.LV_lista.Size = New System.Drawing.Size(416, 187)
        Me.LV_lista.TabIndex = 4
        Me.LV_lista.UseCompatibleStateImageBehavior = False
        Me.LV_lista.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 0
        '
        'kod
        '
        Me.kod.Text = "Kod"
        Me.kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.kod.Width = 90
        '
        'ilosc
        '
        Me.ilosc.Text = "Ilość"
        Me.ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lotto_prod
        '
        Me.lotto_prod.Text = "Lotto  prod"
        Me.lotto_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lotto_prod.Width = 70
        '
        'lotto_nat
        '
        Me.lotto_nat.Text = "Lotto nat"
        Me.lotto_nat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lotto_nat.Width = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Regał:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TB_regal
        '
        Me.TB_regal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Location = New System.Drawing.Point(192, 12)
        Me.TB_regal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(132, 22)
        Me.TB_regal.TabIndex = 0
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Nowy regał:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TB_nowy_regal
        '
        Me.TB_nowy_regal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_nowy_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_nowy_regal.Location = New System.Drawing.Point(192, 240)
        Me.TB_nowy_regal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_nowy_regal.MaxLength = 4
        Me.TB_nowy_regal.Name = "TB_nowy_regal"
        Me.TB_nowy_regal.Size = New System.Drawing.Size(132, 22)
        Me.TB_nowy_regal.TabIndex = 1
        Me.TB_nowy_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MG_przenies_regal
        '
        Me.AcceptButton = Me.BT_przenies_regal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 346)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_nowy_regal)
        Me.Controls.Add(Me.CB_uwagi_mod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BT_przenies_regal)
        Me.Controls.Add(Me.LV_lista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_regal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MG_przenies_regal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn główny - Przenieś regał"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_uwagi_mod As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BT_przenies_regal As Button
    Friend WithEvents LV_lista As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents kod As ColumnHeader
    Friend WithEvents ilosc As ColumnHeader
    Friend WithEvents lotto_prod As ColumnHeader
    Friend WithEvents lotto_nat As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_regal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_nowy_regal As TextBox
End Class
