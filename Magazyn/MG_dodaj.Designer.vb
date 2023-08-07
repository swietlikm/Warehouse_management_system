<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MG_dodaj
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
        Me.BT_dodaj = New System.Windows.Forms.Button()
        Me.TB_uwagi = New System.Windows.Forms.TextBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_formula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_stan = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_dodaj
        '
        Me.BT_dodaj.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BT_dodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_dodaj.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_dodaj.Location = New System.Drawing.Point(73, 248)
        Me.BT_dodaj.Name = "BT_dodaj"
        Me.BT_dodaj.Size = New System.Drawing.Size(156, 30)
        Me.BT_dodaj.TabIndex = 9
        Me.BT_dodaj.Text = "Dodaj na magazyn"
        Me.BT_dodaj.UseVisualStyleBackColor = False
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Location = New System.Drawing.Point(100, 209)
        Me.TB_uwagi.MaxLength = 65
        Me.TB_uwagi.Multiline = True
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(204, 33)
        Me.TB_uwagi.TabIndex = 8
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(53, 211)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 137
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto_prod
        '
        Me.TB_lotto_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_lotto_prod.Location = New System.Drawing.Point(100, 139)
        Me.TB_lotto_prod.MaxLength = 8
        Me.TB_lotto_prod.Name = "TB_lotto_prod"
        Me.TB_lotto_prod.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_prod.TabIndex = 5
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(36, 142)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(58, 13)
        Me.lblLottoProd.TabIndex = 136
        Me.lblLottoProd.Text = "Lotto prod:"
        '
        'TB_ilosc
        '
        Me.TB_ilosc.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_ilosc.Location = New System.Drawing.Point(100, 115)
        Me.TB_ilosc.MaxLength = 7
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.Size = New System.Drawing.Size(60, 20)
        Me.TB_ilosc.TabIndex = 4
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIlosc
        '
        Me.lblIlosc.AutoSize = True
        Me.lblIlosc.Location = New System.Drawing.Point(64, 117)
        Me.lblIlosc.Name = "lblIlosc"
        Me.lblIlosc.Size = New System.Drawing.Size(32, 13)
        Me.lblIlosc.TabIndex = 135
        Me.lblIlosc.Text = "Ilość:"
        '
        'TB_regal
        '
        Me.TB_regal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Location = New System.Drawing.Point(100, 63)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(61, 20)
        Me.TB_regal.TabIndex = 2
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(57, 66)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 134
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.Enabled = False
        Me.TB_galileo.Location = New System.Drawing.Point(11, 37)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.Size = New System.Drawing.Size(296, 20)
        Me.TB_galileo.TabIndex = 1
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(207, 10)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 9
        Me.BT_kody.Text = "..."
        Me.BT_kody.UseVisualStyleBackColor = True
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(100, 11)
        Me.TB_kod.MaxLength = 15
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 0
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(48, 14)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(46, 13)
        Me.lblKodZP.TabIndex = 133
        Me.lblKodZP.Text = "Kod ZP:"
        '
        'TB_lotto_nat
        '
        Me.TB_lotto_nat.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TB_lotto_nat.Location = New System.Drawing.Point(100, 163)
        Me.TB_lotto_nat.MaxLength = 9
        Me.TB_lotto_nat.Name = "TB_lotto_nat"
        Me.TB_lotto_nat.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_nat.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Lotto nat:"
        '
        'TB_formula
        '
        Me.TB_formula.BackColor = System.Drawing.Color.White
        Me.TB_formula.Location = New System.Drawing.Point(100, 89)
        Me.TB_formula.MaxLength = 100
        Me.TB_formula.Name = "TB_formula"
        Me.TB_formula.Size = New System.Drawing.Size(207, 20)
        Me.TB_formula.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Formuła:"
        '
        'CB_stan
        '
        Me.CB_stan.AutoSize = True
        Me.CB_stan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CB_stan.Location = New System.Drawing.Point(100, 190)
        Me.CB_stan.Name = "CB_stan"
        Me.CB_stan.Size = New System.Drawing.Size(15, 14)
        Me.CB_stan.TabIndex = 7
        Me.CB_stan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Galileo:"
        '
        'MG_dodaj
        '
        Me.AcceptButton = Me.BT_dodaj
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 284)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_stan)
        Me.Controls.Add(Me.TB_formula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_lotto_nat)
        Me.Controls.Add(Me.BT_dodaj)
        Me.Controls.Add(Me.TB_uwagi)
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
        Me.Name = "MG_dodaj"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn główny - Dodaj nową pozycję"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_dodaj As Button
    Friend WithEvents TB_uwagi As TextBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_formula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_stan As CheckBox
    Friend WithEvents Label3 As Label
End Class
