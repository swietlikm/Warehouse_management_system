<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOS_edytuj
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
        Me.TB_lotto_nat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_usun = New System.Windows.Forms.CheckBox()
        Me.BT_zmien = New System.Windows.Forms.Button()
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
        Me.TB_ilosc_pak = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_id = New System.Windows.Forms.TextBox()
        Me.TB_wymiar = New System.Windows.Forms.TextBox()
        Me.lblWymiar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TB_lotto_nat
        '
        Me.TB_lotto_nat.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_lotto_nat.Location = New System.Drawing.Point(97, 187)
        Me.TB_lotto_nat.MaxLength = 9
        Me.TB_lotto_nat.Name = "TB_lotto_nat"
        Me.TB_lotto_nat.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_nat.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 210
        Me.Label2.Text = "Lotto nat:"
        '
        'CB_usun
        '
        Me.CB_usun.AutoSize = True
        Me.CB_usun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_usun.ForeColor = System.Drawing.Color.Red
        Me.CB_usun.Location = New System.Drawing.Point(97, 255)
        Me.CB_usun.Name = "CB_usun"
        Me.CB_usun.Size = New System.Drawing.Size(84, 17)
        Me.CB_usun.TabIndex = 6
        Me.CB_usun.Text = "Usuń wpis"
        Me.CB_usun.UseVisualStyleBackColor = True
        '
        'BT_zmien
        '
        Me.BT_zmien.BackColor = System.Drawing.Color.FloralWhite
        Me.BT_zmien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BT_zmien.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_zmien.Location = New System.Drawing.Point(78, 277)
        Me.BT_zmien.Name = "BT_zmien"
        Me.BT_zmien.Size = New System.Drawing.Size(156, 30)
        Me.BT_zmien.TabIndex = 7
        Me.BT_zmien.Text = "Zapisz"
        Me.BT_zmien.UseVisualStyleBackColor = False
        '
        'TB_uwagi
        '
        Me.TB_uwagi.Location = New System.Drawing.Point(97, 213)
        Me.TB_uwagi.MaxLength = 80
        Me.TB_uwagi.Multiline = True
        Me.TB_uwagi.Name = "TB_uwagi"
        Me.TB_uwagi.Size = New System.Drawing.Size(208, 36)
        Me.TB_uwagi.TabIndex = 5
        '
        'lblUwagi
        '
        Me.lblUwagi.AutoSize = True
        Me.lblUwagi.Location = New System.Drawing.Point(53, 215)
        Me.lblUwagi.Name = "lblUwagi"
        Me.lblUwagi.Size = New System.Drawing.Size(40, 13)
        Me.lblUwagi.TabIndex = 204
        Me.lblUwagi.Text = "Uwagi:"
        '
        'TB_lotto_prod
        '
        Me.TB_lotto_prod.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_lotto_prod.Location = New System.Drawing.Point(97, 161)
        Me.TB_lotto_prod.MaxLength = 8
        Me.TB_lotto_prod.Name = "TB_lotto_prod"
        Me.TB_lotto_prod.Size = New System.Drawing.Size(60, 20)
        Me.TB_lotto_prod.TabIndex = 3
        '
        'lblLottoProd
        '
        Me.lblLottoProd.AutoSize = True
        Me.lblLottoProd.Location = New System.Drawing.Point(33, 163)
        Me.lblLottoProd.Name = "lblLottoProd"
        Me.lblLottoProd.Size = New System.Drawing.Size(58, 13)
        Me.lblLottoProd.TabIndex = 203
        Me.lblLottoProd.Text = "Lotto prod:"
        '
        'TB_ilosc
        '
        Me.TB_ilosc.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_ilosc.Location = New System.Drawing.Point(97, 135)
        Me.TB_ilosc.MaxLength = 7
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.Size = New System.Drawing.Size(60, 20)
        Me.TB_ilosc.TabIndex = 2
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIlosc
        '
        Me.lblIlosc.AutoSize = True
        Me.lblIlosc.Location = New System.Drawing.Point(61, 137)
        Me.lblIlosc.Name = "lblIlosc"
        Me.lblIlosc.Size = New System.Drawing.Size(32, 13)
        Me.lblIlosc.TabIndex = 202
        Me.lblIlosc.Text = "Ilość:"
        '
        'TB_regal
        '
        Me.TB_regal.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_regal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_regal.Location = New System.Drawing.Point(97, 86)
        Me.TB_regal.MaxLength = 4
        Me.TB_regal.Name = "TB_regal"
        Me.TB_regal.Size = New System.Drawing.Size(60, 20)
        Me.TB_regal.TabIndex = 0
        Me.TB_regal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegal
        '
        Me.lblRegal.AutoSize = True
        Me.lblRegal.Location = New System.Drawing.Point(54, 89)
        Me.lblRegal.Name = "lblRegal"
        Me.lblRegal.Size = New System.Drawing.Size(40, 13)
        Me.lblRegal.TabIndex = 201
        Me.lblRegal.Text = "Regał:"
        '
        'TB_galileo
        '
        Me.TB_galileo.BackColor = System.Drawing.SystemColors.Window
        Me.TB_galileo.Enabled = False
        Me.TB_galileo.Location = New System.Drawing.Point(9, 60)
        Me.TB_galileo.Name = "TB_galileo"
        Me.TB_galileo.ReadOnly = True
        Me.TB_galileo.Size = New System.Drawing.Size(296, 20)
        Me.TB_galileo.TabIndex = 11
        Me.TB_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_kody
        '
        Me.BT_kody.Location = New System.Drawing.Point(202, 32)
        Me.BT_kody.Name = "BT_kody"
        Me.BT_kody.Size = New System.Drawing.Size(25, 23)
        Me.BT_kody.TabIndex = 10
        Me.BT_kody.Text = "..."
        Me.BT_kody.UseVisualStyleBackColor = True
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(97, 34)
        Me.TB_kod.MaxLength = 15
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 9
        '
        'lblKodZP
        '
        Me.lblKodZP.AutoSize = True
        Me.lblKodZP.Location = New System.Drawing.Point(46, 37)
        Me.lblKodZP.Name = "lblKodZP"
        Me.lblKodZP.Size = New System.Drawing.Size(46, 13)
        Me.lblKodZP.TabIndex = 200
        Me.lblKodZP.Text = "Kod ZP:"
        '
        'TB_ilosc_pak
        '
        Me.TB_ilosc_pak.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_ilosc_pak.Location = New System.Drawing.Point(97, 110)
        Me.TB_ilosc_pak.MaxLength = 100
        Me.TB_ilosc_pak.Name = "TB_ilosc_pak"
        Me.TB_ilosc_pak.Size = New System.Drawing.Size(208, 20)
        Me.TB_ilosc_pak.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Formuła:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "ID:"
        '
        'TB_id
        '
        Me.TB_id.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_id.Enabled = False
        Me.TB_id.Location = New System.Drawing.Point(97, 8)
        Me.TB_id.MaxLength = 4
        Me.TB_id.Name = "TB_id"
        Me.TB_id.ReadOnly = True
        Me.TB_id.Size = New System.Drawing.Size(60, 20)
        Me.TB_id.TabIndex = 8
        Me.TB_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_wymiar
        '
        Me.TB_wymiar.BackColor = System.Drawing.Color.FloralWhite
        Me.TB_wymiar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_wymiar.Location = New System.Drawing.Point(245, 86)
        Me.TB_wymiar.MaxLength = 4
        Me.TB_wymiar.Name = "TB_wymiar"
        Me.TB_wymiar.Size = New System.Drawing.Size(60, 20)
        Me.TB_wymiar.TabIndex = 215
        Me.TB_wymiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_wymiar.Visible = False
        '
        'lblWymiar
        '
        Me.lblWymiar.AutoSize = True
        Me.lblWymiar.Location = New System.Drawing.Point(194, 89)
        Me.lblWymiar.Name = "lblWymiar"
        Me.lblWymiar.Size = New System.Drawing.Size(45, 13)
        Me.lblWymiar.TabIndex = 216
        Me.lblWymiar.Text = "Wymiar:"
        Me.lblWymiar.Visible = False
        '
        'DOS_edytuj
        '
        Me.AcceptButton = Me.BT_zmien
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 315)
        Me.Controls.Add(Me.TB_wymiar)
        Me.Controls.Add(Me.lblWymiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_id)
        Me.Controls.Add(Me.TB_ilosc_pak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_lotto_nat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_usun)
        Me.Controls.Add(Me.BT_zmien)
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
        Me.Name = "DOS_edytuj"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dostawa - Edytuj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_lotto_nat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_usun As CheckBox
    Friend WithEvents BT_zmien As Button
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
    Friend WithEvents TB_ilosc_pak As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_id As TextBox
    Friend WithEvents TB_wymiar As TextBox
    Friend WithEvents lblWymiar As Label
End Class
