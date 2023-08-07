<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MG_doloz
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
        Me.TB_wynik_nowej_formuly = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_pozostanie = New System.Windows.Forms.TextBox()
        Me.TB_aktualna_formula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_wynik_aktualna_formula = New System.Windows.Forms.TextBox()
        Me.TB_ilosc_pak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.BT_doloz = New System.Windows.Forms.Button()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_stan = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TB_wynik_nowej_formuly
        '
        Me.TB_wynik_nowej_formuly.BackColor = System.Drawing.SystemColors.Window
        Me.TB_wynik_nowej_formuly.Enabled = False
        Me.TB_wynik_nowej_formuly.Location = New System.Drawing.Point(259, 331)
        Me.TB_wynik_nowej_formuly.MaxLength = 7
        Me.TB_wynik_nowej_formuly.Name = "TB_wynik_nowej_formuly"
        Me.TB_wynik_nowej_formuly.ReadOnly = True
        Me.TB_wynik_nowej_formuly.Size = New System.Drawing.Size(45, 20)
        Me.TB_wynik_nowej_formuly.TabIndex = 219
        Me.TB_wynik_nowej_formuly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 233
        Me.Label6.Text = "Suma:"
        '
        'TB_pozostanie
        '
        Me.TB_pozostanie.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_pozostanie.Enabled = False
        Me.TB_pozostanie.Location = New System.Drawing.Point(118, 305)
        Me.TB_pozostanie.MaxLength = 7
        Me.TB_pozostanie.Name = "TB_pozostanie"
        Me.TB_pozostanie.Size = New System.Drawing.Size(60, 20)
        Me.TB_pozostanie.TabIndex = 217
        Me.TB_pozostanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_aktualna_formula
        '
        Me.TB_aktualna_formula.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_aktualna_formula.Location = New System.Drawing.Point(118, 253)
        Me.TB_aktualna_formula.MaxLength = 100
        Me.TB_aktualna_formula.Name = "TB_aktualna_formula"
        Me.TB_aktualna_formula.ReadOnly = True
        Me.TB_aktualna_formula.Size = New System.Drawing.Size(186, 20)
        Me.TB_aktualna_formula.TabIndex = 213
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 232
        Me.Label5.Text = "Aktualna formuła:"
        '
        'TB_wynik_aktualna_formula
        '
        Me.TB_wynik_aktualna_formula.BackColor = System.Drawing.SystemColors.Window
        Me.TB_wynik_aktualna_formula.Location = New System.Drawing.Point(259, 279)
        Me.TB_wynik_aktualna_formula.MaxLength = 500
        Me.TB_wynik_aktualna_formula.Name = "TB_wynik_aktualna_formula"
        Me.TB_wynik_aktualna_formula.Size = New System.Drawing.Size(45, 20)
        Me.TB_wynik_aktualna_formula.TabIndex = 216
        Me.TB_wynik_aktualna_formula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_ilosc_pak
        '
        Me.TB_ilosc_pak.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_ilosc_pak.Location = New System.Drawing.Point(118, 331)
        Me.TB_ilosc_pak.MaxLength = 100
        Me.TB_ilosc_pak.Name = "TB_ilosc_pak"
        Me.TB_ilosc_pak.Size = New System.Drawing.Size(135, 20)
        Me.TB_ilosc_pak.TabIndex = 218
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Nowa formuła:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Lotto nat:"
        '
        'TB_lotto_nat
        '
        Me.TB_lotto_nat.Enabled = False
        Me.TB_lotto_nat.Location = New System.Drawing.Point(118, 227)
        Me.TB_lotto_nat.MaxLength = 8
        Me.TB_lotto_nat.Name = "TB_lotto_nat"
        Me.TB_lotto_nat.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_nat.TabIndex = 212
        '
        'CB_uwagi_mod
        '
        Me.CB_uwagi_mod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_uwagi_mod.Items.AddRange(New Object() {"", "Zwrot", "Powrót z obróbki obcej"})
        Me.CB_uwagi_mod.Location = New System.Drawing.Point(118, 406)
        Me.CB_uwagi_mod.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_uwagi_mod.MaxLength = 80
        Me.CB_uwagi_mod.Name = "CB_uwagi_mod"
        Me.CB_uwagi_mod.Size = New System.Drawing.Size(186, 21)
        Me.CB_uwagi_mod.TabIndex = 222
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
        Me.LV_lista.TabIndex = 209
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
        Me.TB_ilosc.Location = New System.Drawing.Point(118, 279)
        Me.TB_ilosc.MaxLength = 7
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.Size = New System.Drawing.Size(60, 20)
        Me.TB_ilosc.TabIndex = 214
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "Dodawana ilość:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 228
        Me.Label1.Text = "Uwagi do ruchu:"
        '
        'BT_doloz
        '
        Me.BT_doloz.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BT_doloz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_doloz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_doloz.Location = New System.Drawing.Point(81, 432)
        Me.BT_doloz.Name = "BT_doloz"
        Me.BT_doloz.Size = New System.Drawing.Size(156, 30)
        Me.BT_doloz.TabIndex = 222
        Me.BT_doloz.Text = "Dołóż"
        Me.BT_doloz.UseVisualStyleBackColor = False
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Enabled = False
        Me.TB_uwagi.Location = New System.Drawing.Point(118, 381)
        Me.TB_uwagi.MaxLength = 80
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(186, 20)
        Me.TB_uwagi.TabIndex = 221
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(72, 384)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 227
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto_prod
        '
        Me.TB_lotto_prod.Enabled = False
        Me.TB_lotto_prod.Location = New System.Drawing.Point(118, 202)
        Me.TB_lotto_prod.MaxLength = 8
        Me.TB_lotto_prod.Name = "TB_lotto_prod"
        Me.TB_lotto_prod.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_prod.TabIndex = 211
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(54, 205)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(58, 13)
        Me.lblLottoProd.TabIndex = 226
        Me.lblLottoProd.Text = "Lotto prod:"
        '
        'TB_regal
        '
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Enabled = False
        Me.TB_regal.Location = New System.Drawing.Point(118, 177)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(50, 20)
        Me.TB_regal.TabIndex = 210
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(72, 180)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 225
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.Enabled = False
        Me.TB_galileo.Location = New System.Drawing.Point(10, 38)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.Size = New System.Drawing.Size(298, 20)
        Me.TB_galileo.TabIndex = 208
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(225, 10)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 223
        Me.BT_kody.Text = "..."
        Me.BT_kody.UseVisualStyleBackColor = True
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(118, 11)
        Me.TB_kod.MaxLength = 15
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 207
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(68, 14)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(46, 13)
        Me.lblKodZP.TabIndex = 224
        Me.lblKodZP.Text = "Kod ZP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "Galileo:"
        '
        'CB_stan
        '
        Me.CB_stan.AutoSize = True
        Me.CB_stan.Location = New System.Drawing.Point(118, 361)
        Me.CB_stan.Name = "CB_stan"
        Me.CB_stan.Size = New System.Drawing.Size(15, 14)
        Me.CB_stan.TabIndex = 220
        Me.CB_stan.UseVisualStyleBackColor = True
        '
        'MG_doloz
        '
        Me.AcceptButton = Me.BT_doloz
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 468)
        Me.Controls.Add(Me.CB_stan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_wynik_nowej_formuly)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_pozostanie)
        Me.Controls.Add(Me.TB_aktualna_formula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_wynik_aktualna_formula)
        Me.Controls.Add(Me.TB_ilosc_pak)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_lotto_nat)
        Me.Controls.Add(Me.CB_uwagi_mod)
        Me.Controls.Add(Me.LV_lista)
        Me.Controls.Add(Me.TB_ilosc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_doloz)
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
        Me.Name = "MG_doloz"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn główny - Dołóż"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_wynik_nowej_formuly As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_pozostanie As TextBox
    Friend WithEvents TB_aktualna_formula As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_wynik_aktualna_formula As TextBox
    Friend WithEvents TB_ilosc_pak As TextBox
    Friend WithEvents Label4 As Label
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
    Friend WithEvents BT_doloz As Button
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
    Friend WithEvents Label7 As Label
    Friend WithEvents CB_stan As CheckBox
End Class
