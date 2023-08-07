<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MG_pobierz
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
        Me.CB_uwagi_mod = New System.Windows.Forms.ComboBox()
        Me.LV_lista = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.regal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilosc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_prod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lotto_nat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TB_ilosc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_max = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_pobierz = New System.Windows.Forms.Button()
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
        Me.TB_lotto_nat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_ilosc_pak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_formula = New System.Windows.Forms.TextBox()
        Me.TB_aktualna_formula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_pozostanie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_wynik_nowej_formuly = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_stan = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CB_uwagi_mod
        '
        Me.CB_uwagi_mod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_uwagi_mod.Items.AddRange(New Object() {"", "Wysyłka", "Wydano na produkcję", "Wydano na selekcję"})
        Me.CB_uwagi_mod.Location = New System.Drawing.Point(118, 402)
        Me.CB_uwagi_mod.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_uwagi_mod.MaxLength = 80
        Me.CB_uwagi_mod.Name = "CB_uwagi_mod"
        Me.CB_uwagi_mod.Size = New System.Drawing.Size(186, 21)
        Me.CB_uwagi_mod.TabIndex = 15
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
        Me.LV_lista.TabIndex = 2
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
        Me.TB_ilosc.TabIndex = 7
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "Pobierana ilość:"
        '
        'BT_max
        '
        Me.BT_max.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_max.Location = New System.Drawing.Point(184, 279)
        Me.BT_max.Name = "BT_max"
        Me.BT_max.Size = New System.Drawing.Size(37, 20)
        Me.BT_max.TabIndex = 8
        Me.BT_max.Text = "Max"
        Me.BT_max.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Uwagi do ruchu:"
        '
        'BT_pobierz
        '
        Me.BT_pobierz.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BT_pobierz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_pobierz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_pobierz.Location = New System.Drawing.Point(81, 428)
        Me.BT_pobierz.Name = "BT_pobierz"
        Me.BT_pobierz.Size = New System.Drawing.Size(156, 30)
        Me.BT_pobierz.TabIndex = 16
        Me.BT_pobierz.Text = "Pobierz"
        Me.BT_pobierz.UseVisualStyleBackColor = False
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Enabled = False
        Me.TB_uwagi.Location = New System.Drawing.Point(118, 377)
        Me.TB_uwagi.MaxLength = 80
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(186, 20)
        Me.TB_uwagi.TabIndex = 14
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(72, 380)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 195
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto_prod
        '
        Me.TB_lotto_prod.Enabled = False
        Me.TB_lotto_prod.Location = New System.Drawing.Point(118, 202)
        Me.TB_lotto_prod.MaxLength = 8
        Me.TB_lotto_prod.Name = "TB_lotto_prod"
        Me.TB_lotto_prod.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_prod.TabIndex = 4
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(54, 205)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(58, 13)
        Me.lblLottoProd.TabIndex = 194
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
        Me.TB_regal.TabIndex = 3
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(72, 180)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 193
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.Enabled = False
        Me.TB_galileo.Location = New System.Drawing.Point(10, 38)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.Size = New System.Drawing.Size(298, 20)
        Me.TB_galileo.TabIndex = 1
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(225, 9)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 16
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
        Me.TB_kod.TabIndex = 0
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(68, 14)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(46, 13)
        Me.lblKodZP.TabIndex = 192
        Me.lblKodZP.Text = "Kod ZP:"
        '
        'TB_lotto_nat
        '
        Me.TB_lotto_nat.Enabled = False
        Me.TB_lotto_nat.Location = New System.Drawing.Point(118, 227)
        Me.TB_lotto_nat.MaxLength = 8
        Me.TB_lotto_nat.Name = "TB_lotto_nat"
        Me.TB_lotto_nat.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_nat.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "Lotto nat:"
        '
        'TB_ilosc_pak
        '
        Me.TB_ilosc_pak.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_ilosc_pak.Location = New System.Drawing.Point(118, 331)
        Me.TB_ilosc_pak.MaxLength = 100
        Me.TB_ilosc_pak.Name = "TB_ilosc_pak"
        Me.TB_ilosc_pak.Size = New System.Drawing.Size(135, 20)
        Me.TB_ilosc_pak.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Nowa formuła:"
        '
        'TB_formula
        '
        Me.TB_formula.BackColor = System.Drawing.SystemColors.Window
        Me.TB_formula.Location = New System.Drawing.Point(259, 279)
        Me.TB_formula.MaxLength = 50
        Me.TB_formula.Name = "TB_formula"
        Me.TB_formula.Size = New System.Drawing.Size(45, 20)
        Me.TB_formula.TabIndex = 9
        '
        'TB_aktualna_formula
        '
        Me.TB_aktualna_formula.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_aktualna_formula.Location = New System.Drawing.Point(118, 253)
        Me.TB_aktualna_formula.MaxLength = 100
        Me.TB_aktualna_formula.Name = "TB_aktualna_formula"
        Me.TB_aktualna_formula.ReadOnly = True
        Me.TB_aktualna_formula.Size = New System.Drawing.Size(186, 20)
        Me.TB_aktualna_formula.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 204
        Me.Label5.Text = "Aktualna formuła:"
        '
        'TB_pozostanie
        '
        Me.TB_pozostanie.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_pozostanie.Enabled = False
        Me.TB_pozostanie.Location = New System.Drawing.Point(118, 305)
        Me.TB_pozostanie.MaxLength = 7
        Me.TB_pozostanie.Name = "TB_pozostanie"
        Me.TB_pozostanie.Size = New System.Drawing.Size(60, 20)
        Me.TB_pozostanie.TabIndex = 10
        Me.TB_pozostanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "Pozostała ilość:"
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
        Me.TB_wynik_nowej_formuly.TabIndex = 12
        Me.TB_wynik_nowej_formuly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 208
        Me.Label7.Text = "Galileo:"
        '
        'CB_stan
        '
        Me.CB_stan.AutoSize = True
        Me.CB_stan.Location = New System.Drawing.Point(118, 358)
        Me.CB_stan.Name = "CB_stan"
        Me.CB_stan.Size = New System.Drawing.Size(15, 14)
        Me.CB_stan.TabIndex = 13
        Me.CB_stan.UseVisualStyleBackColor = True
        '
        'MG_pobierz
        '
        Me.AcceptButton = Me.BT_pobierz
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 466)
        Me.Controls.Add(Me.CB_stan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_wynik_nowej_formuly)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_pozostanie)
        Me.Controls.Add(Me.TB_aktualna_formula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_formula)
        Me.Controls.Add(Me.TB_ilosc_pak)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_lotto_nat)
        Me.Controls.Add(Me.CB_uwagi_mod)
        Me.Controls.Add(Me.LV_lista)
        Me.Controls.Add(Me.TB_ilosc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BT_max)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_pobierz)
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
        Me.Name = "MG_pobierz"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn główny - Pobierz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_uwagi_mod As ComboBox
    Friend WithEvents LV_lista As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents regal As ColumnHeader
    Friend WithEvents ilosc As ColumnHeader
    Friend WithEvents lotto_prod As ColumnHeader
    Friend WithEvents TB_ilosc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BT_max As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_pobierz As Button
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
    Friend WithEvents TB_lotto_nat As TextBox
    Friend WithEvents lotto_nat As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_ilosc_pak As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_formula As TextBox
    Friend WithEvents TB_aktualna_formula As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_pozostanie As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_wynik_nowej_formuly As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CB_stan As CheckBox
End Class
