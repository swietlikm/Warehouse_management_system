<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MG_edytuj
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_id = New System.Windows.Forms.TextBox()
        Me.TB_uwagi_mod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_zmien = New System.Windows.Forms.Button()
        Me.lblUwagi = New System.Windows.Forms.Label()
        Me.TB_lotto_prod = New System.Windows.Forms.TextBox()
        Me.lblLottoProd = New System.Windows.Forms.Label()
        Me.TB_ilosc = New System.Windows.Forms.TextBox()
        Me.lblIlosc = New System.Windows.Forms.Label()
        Me.TB_regal = New System.Windows.Forms.TextBox()
        Me.lblRegal = New System.Windows.Forms.Label()
        Me.TB_galileo = New System.Windows.Forms.TextBox()
        Me.BT_kody = New System.Windows.Forms.Button()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.lblKodZP = New System.Windows.Forms.Label()
        Me.TB_lotto_nat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_formula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_uwagi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "ID:"
        '
        'TB_id
        '
        Me.TB_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_id.Enabled = False
        Me.TB_id.Location = New System.Drawing.Point(98, 8)
        Me.TB_id.MaxLength = 4
        Me.TB_id.Name = "TB_id"
        Me.TB_id.Size = New System.Drawing.Size(50, 20)
        Me.TB_id.TabIndex = 166
        Me.TB_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_uwagi_mod
        '
        Me.TB_uwagi_mod.Location = New System.Drawing.Point(98, 255)
        Me.TB_uwagi_mod.MaxLength = 80
        Me.TB_uwagi_mod.Name = "TB_uwagi_mod"
        Me.TB_uwagi_mod.Size = New System.Drawing.Size(208, 20)
        Me.TB_uwagi_mod.TabIndex = 164
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Uwagi mod:"
        '
        'BT_zmien
        '
        Me.BT_zmien.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BT_zmien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_zmien.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_zmien.Location = New System.Drawing.Point(72, 281)
        Me.BT_zmien.Name = "BT_zmien"
        Me.BT_zmien.Size = New System.Drawing.Size(156, 30)
        Me.BT_zmien.TabIndex = 165
        Me.BT_zmien.Text = "Zapisz"
        Me.BT_zmien.UseVisualStyleBackColor = False
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(53, 219)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 174
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto_prod
        '
        Me.TB_lotto_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_lotto_prod.Location = New System.Drawing.Point(98, 164)
        Me.TB_lotto_prod.MaxLength = 8
        Me.TB_lotto_prod.Name = "TB_lotto_prod"
        Me.TB_lotto_prod.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_prod.TabIndex = 160
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(34, 167)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(58, 13)
        Me.lblLottoProd.TabIndex = 173
        Me.lblLottoProd.Text = "Lotto prod:"
        '
        'TB_ilosc
        '
        Me.TB_ilosc.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_ilosc.Enabled = False
        Me.TB_ilosc.Location = New System.Drawing.Point(98, 138)
        Me.TB_ilosc.MaxLength = 7
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.Size = New System.Drawing.Size(60, 20)
        Me.TB_ilosc.TabIndex = 159
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIlosc
        '
        Me.lblIlosc.AutoSize = True
        Me.lblIlosc.Location = New System.Drawing.Point(60, 141)
        Me.lblIlosc.Name = "lblIlosc"
        Me.lblIlosc.Size = New System.Drawing.Size(32, 13)
        Me.lblIlosc.TabIndex = 172
        Me.lblIlosc.Text = "Ilość:"
        '
        'TB_regal
        '
        Me.TB_regal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Enabled = False
        Me.TB_regal.Location = New System.Drawing.Point(98, 86)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(50, 20)
        Me.TB_regal.TabIndex = 157
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(52, 89)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 171
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.Location = New System.Drawing.Point(10, 60)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.ReadOnly = True
        Me.TB_galileo.Size = New System.Drawing.Size(296, 20)
        Me.TB_galileo.TabIndex = 156
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(203, 32)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 168
        Me.BT_kody.Text = "..."
        Me.BT_kody.UseVisualStyleBackColor = True
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(98, 34)
        Me.TB_kod.MaxLength = 15
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 167
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(46, 37)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(46, 13)
        Me.lblKodZP.TabIndex = 170
        Me.lblKodZP.Text = "Kod ZP:"
        '
        'TB_lotto_nat
        '
        Me.TB_lotto_nat.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_lotto_nat.Location = New System.Drawing.Point(98, 190)
        Me.TB_lotto_nat.MaxLength = 9
        Me.TB_lotto_nat.Name = "TB_lotto_nat"
        Me.TB_lotto_nat.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_nat.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Lotto nat:"
        '
        'TB_formula
        '
        Me.TB_formula.BackColor = System.Drawing.SystemColors.Window
        Me.TB_formula.Location = New System.Drawing.Point(98, 112)
        Me.TB_formula.MaxLength = 100
        Me.TB_formula.Name = "TB_formula"
        Me.TB_formula.Size = New System.Drawing.Size(208, 20)
        Me.TB_formula.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Formuła:"
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Location = New System.Drawing.Point(99, 216)
        Me.TB_uwagi.MaxLength = 65
        Me.TB_uwagi.Multiline = True
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(207, 33)
        Me.TB_uwagi.TabIndex = 163
        '
        'MG_edytuj
        '
        Me.AcceptButton = Me.BT_zmien
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 318)
        Me.Controls.Add(Me.TB_uwagi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_formula)
        Me.Controls.Add(Me.TB_lotto_nat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_id)
        Me.Controls.Add(Me.TB_uwagi_mod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_zmien)
        Me.Controls.Add(Me.lblUwagi)
        Me.Controls.Add(Me.TB_lotto_prod)
        Me.Controls.Add(Me.lblLottoProd)
        Me.Controls.Add(Me.TB_ilosc)
        Me.Controls.Add(Me.lblIlosc)
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
        Me.Name = "MG_edytuj"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn główny - Edycja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents TB_id As TextBox
    Friend WithEvents TB_uwagi_mod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_zmien As Button
    Friend WithEvents lblUwagi As Label
    Friend WithEvents TB_lotto_prod As TextBox
    Friend WithEvents lblLottoProd As Label
    Friend WithEvents TB_ilosc As TextBox
    Friend WithEvents lblIlosc As Label
    Friend WithEvents TB_regal As TextBox
    Friend WithEvents lblRegal As Label
    Friend WithEvents TB_galileo As TextBox
    Friend WithEvents BT_kody As Button
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents lblKodZP As Label
    Friend WithEvents TB_lotto_nat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_formula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_uwagi As TextBox
End Class
