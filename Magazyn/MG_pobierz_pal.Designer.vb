<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MG_pobierz_pal
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_pobierz = New System.Windows.Forms.Button()
        Me.LV_lista = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilosc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_prod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_nat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_regal = New System.Windows.Forms.TextBox()
        Me.CB_uwagi_mod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Uwagi do ruchu:"
        '
        'BT_pobierz
        '
        Me.BT_pobierz.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BT_pobierz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_pobierz.Location = New System.Drawing.Point(98, 220)
        Me.BT_pobierz.Name = "BT_pobierz"
        Me.BT_pobierz.Size = New System.Drawing.Size(156, 30)
        Me.BT_pobierz.TabIndex = 85
        Me.BT_pobierz.Text = "Pobierz"
        Me.BT_pobierz.UseVisualStyleBackColor = False
        '
        'LV_lista
        '
        Me.LV_lista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LV_lista.AutoArrange = False
        Me.LV_lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.kod, Me.ilosc, Me.lotto_prod, Me.lotto_nat})
        Me.LV_lista.FullRowSelect = True
        Me.LV_lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV_lista.HideSelection = False
        Me.LV_lista.Location = New System.Drawing.Point(12, 36)
        Me.LV_lista.MultiSelect = False
        Me.LV_lista.Name = "LV_lista"
        Me.LV_lista.ShowItemToolTips = True
        Me.LV_lista.Size = New System.Drawing.Size(313, 153)
        Me.LV_lista.TabIndex = 80
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
        Me.Label1.Location = New System.Drawing.Point(97, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Regał:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TB_regal
        '
        Me.TB_regal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Location = New System.Drawing.Point(144, 10)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(100, 20)
        Me.TB_regal.TabIndex = 78
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB_uwagi_mod
        '
        Me.CB_uwagi_mod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_uwagi_mod.Items.AddRange(New Object() {"", "Wysyłka", "Wydano na produkcję", "Wydano na selekcję"})
        Me.CB_uwagi_mod.Location = New System.Drawing.Point(99, 194)
        Me.CB_uwagi_mod.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CB_uwagi_mod.MaxLength = 80
        Me.CB_uwagi_mod.Name = "CB_uwagi_mod"
        Me.CB_uwagi_mod.Size = New System.Drawing.Size(226, 21)
        Me.CB_uwagi_mod.TabIndex = 84
        '
        'MG_pobierz_pal
        '
        Me.AcceptButton = Me.BT_pobierz
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 258)
        Me.Controls.Add(Me.CB_uwagi_mod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BT_pobierz)
        Me.Controls.Add(Me.LV_lista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_regal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MG_pobierz_pal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn główny - Pobierz paletę"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents BT_pobierz As Button
    Friend WithEvents LV_lista As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents kod As ColumnHeader
    Friend WithEvents ilosc As ColumnHeader
    Friend WithEvents lotto_prod As ColumnHeader
    Friend WithEvents lotto_nat As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_regal As TextBox
    Friend WithEvents CB_uwagi_mod As ComboBox
End Class
