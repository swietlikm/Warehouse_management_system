<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOS_wyslij
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
        Me.TB_ilosc_pak = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_lotto_nat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_wyslij = New System.Windows.Forms.Button()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_uwagi_mod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TB_ilosc_pak
        '
        Me.TB_ilosc_pak.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_ilosc_pak.Enabled = False
        Me.TB_ilosc_pak.Location = New System.Drawing.Point(97, 89)
        Me.TB_ilosc_pak.MaxLength = 20
        Me.TB_ilosc_pak.Name = "TB_ilosc_pak"
        Me.TB_ilosc_pak.Size = New System.Drawing.Size(208, 20)
        Me.TB_ilosc_pak.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Formuła:"
        '
        'TB_lotto_nat
        '
        Me.TB_lotto_nat.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_lotto_nat.Location = New System.Drawing.Point(97, 167)
        Me.TB_lotto_nat.MaxLength = 9
        Me.TB_lotto_nat.Name = "TB_lotto_nat"
        Me.TB_lotto_nat.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_nat.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 232
        Me.Label2.Text = "Lotto nat:"
        '
        'BT_wyslij
        '
        Me.BT_wyslij.BackColor = System.Drawing.Color.FloralWhite
        Me.BT_wyslij.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_wyslij.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_wyslij.Location = New System.Drawing.Point(79, 247)
        Me.BT_wyslij.Name = "BT_wyslij"
        Me.BT_wyslij.Size = New System.Drawing.Size(156, 30)
        Me.BT_wyslij.TabIndex = 7
        Me.BT_wyslij.Text = "Wyślij"
        Me.BT_wyslij.UseVisualStyleBackColor = False
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Location = New System.Drawing.Point(97, 193)
        Me.TB_uwagi.MaxLength = 80
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(208, 20)
        Me.TB_uwagi.TabIndex = 5
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(54, 196)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 231
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto_prod
        '
        Me.TB_lotto_prod.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_lotto_prod.Location = New System.Drawing.Point(97, 141)
        Me.TB_lotto_prod.MaxLength = 8
        Me.TB_lotto_prod.Name = "TB_lotto_prod"
        Me.TB_lotto_prod.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_prod.TabIndex = 3
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(35, 144)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(58, 13)
        Me.lblLottoProd.TabIndex = 230
        Me.lblLottoProd.Text = "Lotto prod:"
        '
        'TB_ilosc
        '
        Me.TB_ilosc.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_ilosc.Enabled = False
        Me.TB_ilosc.Location = New System.Drawing.Point(97, 115)
        Me.TB_ilosc.MaxLength = 7
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.Size = New System.Drawing.Size(60, 20)
        Me.TB_ilosc.TabIndex = 1
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIlosc
        '
        Me.lblIlosc.AutoSize = True
        Me.lblIlosc.Location = New System.Drawing.Point(61, 118)
        Me.lblIlosc.Name = "lblIlosc"
        Me.lblIlosc.Size = New System.Drawing.Size(32, 13)
        Me.lblIlosc.TabIndex = 229
        Me.lblIlosc.Text = "Ilość:"
        '
        'TB_regal
        '
        Me.TB_regal.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Location = New System.Drawing.Point(97, 63)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(60, 20)
        Me.TB_regal.TabIndex = 0
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(55, 66)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 228
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.BackColor = System.Drawing.SystemColors.Window
        Me.TB_galileo.Enabled = False
        Me.TB_galileo.Location = New System.Drawing.Point(9, 37)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.ReadOnly = True
        Me.TB_galileo.Size = New System.Drawing.Size(296, 20)
        Me.TB_galileo.TabIndex = 10
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(202, 9)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 9
        Me.BT_kody.Text = "..."
        Me.BT_kody.UseVisualStyleBackColor = True
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Enabled = False
        Me.TB_kod.Location = New System.Drawing.Point(97, 11)
        Me.TB_kod.MaxLength = 15
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 8
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(46, 14)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(46, 13)
        Me.lblKodZP.TabIndex = 227
        Me.lblKodZP.Text = "Kod ZP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Uwagi ruchu:"
        '
        'CB_uwagi_mod
        '
        Me.CB_uwagi_mod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_uwagi_mod.Items.AddRange(New Object() {"", "Zwrot", "Obróbka obca", "Do klienta"})
        Me.CB_uwagi_mod.Location = New System.Drawing.Point(97, 218)
        Me.CB_uwagi_mod.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CB_uwagi_mod.MaxLength = 80
        Me.CB_uwagi_mod.Name = "CB_uwagi_mod"
        Me.CB_uwagi_mod.Size = New System.Drawing.Size(208, 21)
        Me.CB_uwagi_mod.TabIndex = 6
        '
        'DOS_wyslij
        '
        Me.AcceptButton = Me.BT_wyslij
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 284)
        Me.Controls.Add(Me.CB_uwagi_mod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_ilosc_pak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_lotto_nat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BT_wyslij)
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
        Me.Name = "DOS_wyslij"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dostawa - Wyślij"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_ilosc_pak As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_lotto_nat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BT_wyslij As Button
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
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_uwagi_mod As ComboBox
End Class
