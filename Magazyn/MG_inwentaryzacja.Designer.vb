<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MG_inwentaryzacja
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_lotto_nat = New System.Windows.Forms.TextBox()
        Me.CB_uwagi_mod = New System.Windows.Forms.ComboBox()
        Me.LV_lista = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.regal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilosc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_prod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_nat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TB_ilosc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_inwentaryzacja = New System.Windows.Forms.Button()
        Me.TB_uwagi = New System.Windows.Forms.TextBox()
        Me.lblUwagi = New System.Windows.Forms.Label()
        Me.TB_lotto_prod = New System.Windows.Forms.TextBox()
        Me.lblLottoProd = New System.Windows.Forms.Label()
        Me.TB_regal = New System.Windows.Forms.TextBox()
        Me.lblRegal = New System.Windows.Forms.Label()
        Me.TB_galileo = New System.Windows.Forms.TextBox()
        Me.BT_kody = New System.Windows.Forms.Button()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.lblKodZP = New System.Windows.Forms.Label()
        Me.TB_formula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_stan = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "Lotto nat:"
        '
        'TB_lotto_nat
        '
        Me.TB_lotto_nat.Enabled = False
        Me.TB_lotto_nat.Location = New System.Drawing.Point(110, 227)
        Me.TB_lotto_nat.MaxLength = 8
        Me.TB_lotto_nat.Name = "TB_lotto_nat"
        Me.TB_lotto_nat.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_nat.TabIndex = 4
        '
        'CB_uwagi_mod
        '
        Me.CB_uwagi_mod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_uwagi_mod.Items.AddRange(New Object() {"", "Brak na regale", "Wydano na produkcję", "Wydano na selekejcę"})
        Me.CB_uwagi_mod.Location = New System.Drawing.Point(110, 350)
        Me.CB_uwagi_mod.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CB_uwagi_mod.MaxLength = 80
        Me.CB_uwagi_mod.Name = "CB_uwagi_mod"
        Me.CB_uwagi_mod.Size = New System.Drawing.Size(194, 21)
        Me.CB_uwagi_mod.TabIndex = 9
        '
        'LV_lista
        '
        Me.LV_lista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LV_lista.AutoArrange = False
        Me.LV_lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.regal, Me.ilosc, Me.lotto_prod, Me.lotto_nat})
        Me.LV_lista.FullRowSelect = True
        Me.LV_lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV_lista.HideSelection = False
        Me.LV_lista.Location = New System.Drawing.Point(10, 63)
        Me.LV_lista.MultiSelect = False
        Me.LV_lista.Name = "LV_lista"
        Me.LV_lista.ShowItemToolTips = True
        Me.LV_lista.Size = New System.Drawing.Size(298, 110)
        Me.LV_lista.TabIndex = 1
        Me.LV_lista.UseCompatibleStateImageBehavior = False
        Me.LV_lista.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 0
        '
        'regal
        '
        Me.regal.Text = "Regał"
        Me.regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ilosc
        '
        Me.ilosc.Text = "Ilość"
        Me.ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ilosc.Width = 70
        '
        'lotto_prod
        '
        Me.lotto_prod.Text = "Lotto prod"
        Me.lotto_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lotto_prod.Width = 70
        '
        'lotto_nat
        '
        Me.lotto_nat.Text = "Lotto nat"
        Me.lotto_nat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lotto_nat.Width = 70
        '
        'TB_ilosc
        '
        Me.TB_ilosc.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_ilosc.Location = New System.Drawing.Point(110, 279)
        Me.TB_ilosc.MaxLength = 7
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.Size = New System.Drawing.Size(60, 20)
        Me.TB_ilosc.TabIndex = 6
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "Nowa ilość:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Uwagi do ruchu:"
        '
        'BT_inwentaryzacja
        '
        Me.BT_inwentaryzacja.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BT_inwentaryzacja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_inwentaryzacja.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_inwentaryzacja.Location = New System.Drawing.Point(71, 376)
        Me.BT_inwentaryzacja.Name = "BT_inwentaryzacja"
        Me.BT_inwentaryzacja.Size = New System.Drawing.Size(156, 30)
        Me.BT_inwentaryzacja.TabIndex = 10
        Me.BT_inwentaryzacja.Text = "Inwentaryzacja"
        Me.BT_inwentaryzacja.UseVisualStyleBackColor = False
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Enabled = False
        Me.TB_uwagi.Location = New System.Drawing.Point(110, 325)
        Me.TB_uwagi.MaxLength = 80
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(194, 20)
        Me.TB_uwagi.TabIndex = 8
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(64, 328)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 214
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto_prod
        '
        Me.TB_lotto_prod.Enabled = False
        Me.TB_lotto_prod.Location = New System.Drawing.Point(110, 202)
        Me.TB_lotto_prod.MaxLength = 8
        Me.TB_lotto_prod.Name = "TB_lotto_prod"
        Me.TB_lotto_prod.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_prod.TabIndex = 3
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(47, 205)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(58, 13)
        Me.lblLottoProd.TabIndex = 213
        Me.lblLottoProd.Text = "Lotto prod:"
        '
        'TB_regal
        '
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Enabled = False
        Me.TB_regal.Location = New System.Drawing.Point(110, 177)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(50, 20)
        Me.TB_regal.TabIndex = 2
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(64, 180)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 212
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.Enabled = False
        Me.TB_galileo.Location = New System.Drawing.Point(10, 38)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.Size = New System.Drawing.Size(298, 20)
        Me.TB_galileo.TabIndex = 202
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(225, 9)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 201
        Me.BT_kody.Text = "..."
        Me.BT_kody.UseVisualStyleBackColor = True
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(120, 11)
        Me.TB_kod.MaxLength = 15
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 0
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(68, 14)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(46, 13)
        Me.lblKodZP.TabIndex = 211
        Me.lblKodZP.Text = "Kod ZP:"
        '
        'TB_formula
        '
        Me.TB_formula.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_formula.Location = New System.Drawing.Point(110, 253)
        Me.TB_formula.MaxLength = 100
        Me.TB_formula.Name = "TB_formula"
        Me.TB_formula.Size = New System.Drawing.Size(194, 20)
        Me.TB_formula.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Formuła:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Galileo:"
        '
        'CB_stan
        '
        Me.CB_stan.AutoSize = True
        Me.CB_stan.Location = New System.Drawing.Point(110, 306)
        Me.CB_stan.Name = "CB_stan"
        Me.CB_stan.Size = New System.Drawing.Size(15, 14)
        Me.CB_stan.TabIndex = 7
        Me.CB_stan.UseVisualStyleBackColor = True
        '
        'MG_inwentaryzacja
        '
        Me.AcceptButton = Me.BT_inwentaryzacja
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 414)
        Me.Controls.Add(Me.CB_stan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_formula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_lotto_nat)
        Me.Controls.Add(Me.CB_uwagi_mod)
        Me.Controls.Add(Me.LV_lista)
        Me.Controls.Add(Me.TB_ilosc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_inwentaryzacja)
        Me.Controls.Add(Me.TB_uwagi)
        Me.Controls.Add(Me.lblUwagi)
        Me.Controls.Add(Me.TB_lotto_prod)
        Me.Controls.Add(Me.lblLottoProd)
        Me.Controls.Add(Me.TB_regal)
        Me.Controls.Add(Me.lblRegal)
        Me.Controls.Add(Me.TB_galileo)
        Me.Controls.Add(Me.BT_kody)
        Me.Controls.Add(Me.TB_kod)
        Me.Controls.Add(Me.lblKodZP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MG_inwentaryzacja"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn główny - Inwentaryzacja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TB_lotto_nat As TextBox
    Friend WithEvents CB_uwagi_mod As ComboBox
    Friend WithEvents LV_lista As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents regal As ColumnHeader
    Friend WithEvents ilosc As ColumnHeader
    Friend WithEvents lotto_prod As ColumnHeader
    Friend WithEvents lotto_nat As ColumnHeader
    Friend WithEvents TB_ilosc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_inwentaryzacja As Button
    Friend WithEvents TB_uwagi As TextBox
    Friend WithEvents lblUwagi As Label
    Friend WithEvents TB_lotto_prod As TextBox
    Friend WithEvents lblLottoProd As Label
    Friend WithEvents TB_regal As TextBox
    Friend WithEvents lblRegal As Label
    Friend WithEvents TB_galileo As TextBox
    Friend WithEvents BT_kody As Button
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents lblKodZP As Label
    Friend WithEvents TB_formula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_stan As CheckBox
End Class
