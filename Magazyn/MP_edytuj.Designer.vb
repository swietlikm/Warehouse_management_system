<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MP_edytuj
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
        Me.CB_przekroj = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_material = New System.Windows.Forms.ComboBox()
        Me.TB_wymiar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_zmien = New System.Windows.Forms.Button()
        Me.TB_uwagi = New System.Windows.Forms.TextBox()
        Me.lblUwagi = New System.Windows.Forms.Label()
        Me.TB_lotto = New System.Windows.Forms.TextBox()
        Me.lblLottoProd = New System.Windows.Forms.Label()
        Me.TB_ilosc = New System.Windows.Forms.TextBox()
        Me.lblIlosc = New System.Windows.Forms.Label()
        Me.TB_regal = New System.Windows.Forms.TextBox()
        Me.lblRegal = New System.Windows.Forms.Label()
        Me.TB_galileo = New System.Windows.Forms.TextBox()
        Me.BT_kody = New System.Windows.Forms.Button()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.lblKodZP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_uwagi_mod = New System.Windows.Forms.TextBox()
        Me.TB_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CB_przekroj
        '
        Me.CB_przekroj.BackColor = System.Drawing.SystemColors.Window
        Me.CB_przekroj.Items.AddRange(New Object() {"D", "E", "Q"})
        Me.CB_przekroj.Location = New System.Drawing.Point(98, 190)
        Me.CB_przekroj.MaxDropDownItems = 3
        Me.CB_przekroj.MaxLength = 1
        Me.CB_przekroj.Name = "CB_przekroj"
        Me.CB_przekroj.Size = New System.Drawing.Size(50, 21)
        Me.CB_przekroj.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Wymiar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Przekrój:"
        '
        'CB_material
        '
        Me.CB_material.BackColor = System.Drawing.SystemColors.Window
        Me.CB_material.FormattingEnabled = True
        Me.CB_material.Location = New System.Drawing.Point(98, 163)
        Me.CB_material.Name = "CB_material"
        Me.CB_material.Size = New System.Drawing.Size(207, 21)
        Me.CB_material.TabIndex = 7
        '
        'TB_wymiar
        '
        Me.TB_wymiar.BackColor = System.Drawing.SystemColors.Window
        Me.TB_wymiar.Location = New System.Drawing.Point(98, 216)
        Me.TB_wymiar.MaxLength = 8
        Me.TB_wymiar.Name = "TB_wymiar"
        Me.TB_wymiar.Size = New System.Drawing.Size(50, 20)
        Me.TB_wymiar.TabIndex = 9
        Me.TB_wymiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Materiał:"
        '
        'BT_zmien
        '
        Me.BT_zmien.BackColor = System.Drawing.Color.LemonChiffon
        Me.BT_zmien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_zmien.ForeColor = System.Drawing.Color.DarkBlue
        Me.BT_zmien.Location = New System.Drawing.Point(75, 308)
        Me.BT_zmien.Name = "BT_zmien"
        Me.BT_zmien.Size = New System.Drawing.Size(156, 30)
        Me.BT_zmien.TabIndex = 12
        Me.BT_zmien.Text = "Zapisz"
        Me.BT_zmien.UseVisualStyleBackColor = False
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Location = New System.Drawing.Point(98, 242)
        Me.TB_uwagi.MaxLength = 80
        Me.TB_uwagi.Multiline = True
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(207, 33)
        Me.TB_uwagi.TabIndex = 10
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(52, 245)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 137
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto
        '
        Me.TB_lotto.BackColor = System.Drawing.Color.LemonChiffon
        Me.TB_lotto.Location = New System.Drawing.Point(98, 138)
        Me.TB_lotto.MaxLength = 9
        Me.TB_lotto.Name = "TB_lotto"
        Me.TB_lotto.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto.TabIndex = 6
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(58, 141)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(34, 13)
        Me.lblLottoProd.TabIndex = 136
        Me.lblLottoProd.Text = "Lotto:"
        '
        'TB_ilosc
        '
        Me.TB_ilosc.BackColor = System.Drawing.Color.LemonChiffon
        Me.TB_ilosc.Enabled = False
        Me.TB_ilosc.Location = New System.Drawing.Point(98, 112)
        Me.TB_ilosc.MaxLength = 7
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.Size = New System.Drawing.Size(60, 20)
        Me.TB_ilosc.TabIndex = 5
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIlosc
        '
        Me.lblIlosc.AutoSize = True
        Me.lblIlosc.Location = New System.Drawing.Point(60, 115)
        Me.lblIlosc.Name = "lblIlosc"
        Me.lblIlosc.Size = New System.Drawing.Size(32, 13)
        Me.lblIlosc.TabIndex = 135
        Me.lblIlosc.Text = "Ilość:"
        '
        'TB_regal
        '
        Me.TB_regal.BackColor = System.Drawing.Color.LemonChiffon
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Enabled = False
        Me.TB_regal.Location = New System.Drawing.Point(98, 86)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(60, 20)
        Me.TB_regal.TabIndex = 4
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(52, 89)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 134
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.Location = New System.Drawing.Point(10, 60)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.ReadOnly = True
        Me.TB_galileo.Size = New System.Drawing.Size(296, 20)
        Me.TB_galileo.TabIndex = 3
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(203, 32)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 15
        Me.BT_kody.Text = "..."
        Me.BT_kody.UseVisualStyleBackColor = True
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.Color.LemonChiffon
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(98, 34)
        Me.TB_kod.MaxLength = 15
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 14
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(44, 37)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(48, 13)
        Me.lblKodZP.TabIndex = 132
        Me.lblKodZP.Text = "Kod MP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Uwagi mod:"
        '
        'TB_uwagi_mod
        '
        Me.TB_uwagi_mod.Location = New System.Drawing.Point(98, 281)
        Me.TB_uwagi_mod.MaxLength = 80
        Me.TB_uwagi_mod.Name = "TB_uwagi_mod"
        Me.TB_uwagi_mod.Size = New System.Drawing.Size(207, 20)
        Me.TB_uwagi_mod.TabIndex = 11
        '
        'TB_id
        '
        Me.TB_id.BackColor = System.Drawing.Color.LemonChiffon
        Me.TB_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_id.Enabled = False
        Me.TB_id.Location = New System.Drawing.Point(98, 8)
        Me.TB_id.MaxLength = 4
        Me.TB_id.Name = "TB_id"
        Me.TB_id.Size = New System.Drawing.Size(50, 20)
        Me.TB_id.TabIndex = 13
        Me.TB_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "ID:"
        '
        'MP_edytuj
        '
        Me.AcceptButton = Me.BT_zmien
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 346)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_id)
        Me.Controls.Add(Me.TB_uwagi_mod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_przekroj)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_material)
        Me.Controls.Add(Me.TB_wymiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BT_zmien)
        Me.Controls.Add(Me.TB_uwagi)
        Me.Controls.Add(Me.lblUwagi)
        Me.Controls.Add(Me.TB_lotto)
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
        Me.Name = "MP_edytuj"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn prętów - Edycja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_przekroj As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_material As ComboBox
    Friend WithEvents TB_wymiar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BT_zmien As Button
    Friend WithEvents TB_uwagi As TextBox
    Friend WithEvents lblUwagi As Label
    Friend WithEvents TB_lotto As TextBox
    Friend WithEvents lblLottoProd As Label
    Friend WithEvents TB_ilosc As TextBox
    Friend WithEvents lblIlosc As Label
    Friend WithEvents TB_regal As TextBox
    Friend WithEvents lblRegal As Label
    Friend WithEvents TB_galileo As TextBox
    Friend WithEvents BT_kody As Button
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents lblKodZP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_uwagi_mod As TextBox
    Friend WithEvents TB_id As TextBox
    Friend WithEvents Label8 As Label
End Class
