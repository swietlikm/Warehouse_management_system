<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MP_info
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
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_roznica_PR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_roznica = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_ilosc_galileo = New System.Windows.Forms.TextBox()
        Me.TB_ilosc = New System.Windows.Forms.TextBox()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.TB_czas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_opis = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.TB_lotto = New System.Windows.Forms.TextBox()
        Me.GB_lotto_nat = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_data = New System.Windows.Forms.TextBox()
        Me.TB_nr_zam = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_lotto_info = New System.Windows.Forms.TextBox()
        Me.TB_nazwa_dostawcy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_lotto_kod = New System.Windows.Forms.TextBox()
        Me.GB2.SuspendLayout()
        Me.GB1.SuspendLayout()
        Me.GB_lotto_nat.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.Label5)
        Me.GB2.Controls.Add(Me.TB_roznica_PR)
        Me.GB2.Controls.Add(Me.Label4)
        Me.GB2.Controls.Add(Me.Label3)
        Me.GB2.Controls.Add(Me.TB_roznica)
        Me.GB2.Controls.Add(Me.Label2)
        Me.GB2.Controls.Add(Me.TB_ilosc_galileo)
        Me.GB2.Controls.Add(Me.TB_ilosc)
        Me.GB2.Location = New System.Drawing.Point(10, 84)
        Me.GB2.Margin = New System.Windows.Forms.Padding(2)
        Me.GB2.Name = "GB2"
        Me.GB2.Padding = New System.Windows.Forms.Padding(2)
        Me.GB2.Size = New System.Drawing.Size(444, 70)
        Me.GB2.TabIndex = 28
        Me.GB2.TabStop = False
        Me.GB2.Text = "Stan magazynowy"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Różnica %:"
        '
        'TB_roznica_PR
        '
        Me.TB_roznica_PR.Location = New System.Drawing.Point(246, 39)
        Me.TB_roznica_PR.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_roznica_PR.Name = "TB_roznica_PR"
        Me.TB_roznica_PR.ReadOnly = True
        Me.TB_roznica_PR.Size = New System.Drawing.Size(76, 20)
        Me.TB_roznica_PR.TabIndex = 9
        Me.TB_roznica_PR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Różnica:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Galileo:"
        '
        'TB_roznica
        '
        Me.TB_roznica.Location = New System.Drawing.Point(246, 17)
        Me.TB_roznica.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_roznica.Name = "TB_roznica"
        Me.TB_roznica.ReadOnly = True
        Me.TB_roznica.Size = New System.Drawing.Size(76, 20)
        Me.TB_roznica.TabIndex = 6
        Me.TB_roznica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Magazyn:"
        '
        'TB_ilosc_galileo
        '
        Me.TB_ilosc_galileo.BackColor = System.Drawing.SystemColors.Window
        Me.TB_ilosc_galileo.Location = New System.Drawing.Point(68, 39)
        Me.TB_ilosc_galileo.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_ilosc_galileo.Name = "TB_ilosc_galileo"
        Me.TB_ilosc_galileo.ReadOnly = True
        Me.TB_ilosc_galileo.Size = New System.Drawing.Size(76, 20)
        Me.TB_ilosc_galileo.TabIndex = 5
        Me.TB_ilosc_galileo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_ilosc
        '
        Me.TB_ilosc.BackColor = System.Drawing.SystemColors.Window
        Me.TB_ilosc.Location = New System.Drawing.Point(68, 17)
        Me.TB_ilosc.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_ilosc.Name = "TB_ilosc"
        Me.TB_ilosc.ReadOnly = True
        Me.TB_ilosc.Size = New System.Drawing.Size(76, 20)
        Me.TB_ilosc.TabIndex = 4
        Me.TB_ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.TB_czas)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Controls.Add(Me.TB_opis)
        Me.GB1.Controls.Add(Me.label1)
        Me.GB1.Controls.Add(Me.TB_kod)
        Me.GB1.Controls.Add(Me.TB_lotto)
        Me.GB1.Location = New System.Drawing.Point(9, 10)
        Me.GB1.Margin = New System.Windows.Forms.Padding(2)
        Me.GB1.Name = "GB1"
        Me.GB1.Padding = New System.Windows.Forms.Padding(2)
        Me.GB1.Size = New System.Drawing.Size(444, 69)
        Me.GB1.TabIndex = 27
        Me.GB1.TabStop = False
        Me.GB1.Text = "Dane"
        '
        'TB_czas
        '
        Me.TB_czas.Location = New System.Drawing.Point(364, 45)
        Me.TB_czas.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_czas.Name = "TB_czas"
        Me.TB_czas.Size = New System.Drawing.Size(76, 20)
        Me.TB_czas.TabIndex = 27
        Me.TB_czas.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 44)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Lotto:"
        '
        'TB_opis
        '
        Me.TB_opis.BackColor = System.Drawing.SystemColors.Window
        Me.TB_opis.Location = New System.Drawing.Point(148, 17)
        Me.TB_opis.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_opis.Name = "TB_opis"
        Me.TB_opis.ReadOnly = True
        Me.TB_opis.Size = New System.Drawing.Size(292, 20)
        Me.TB_opis.TabIndex = 6
        Me.TB_opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(36, 20)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Kod:"
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.SystemColors.Window
        Me.TB_kod.Location = New System.Drawing.Point(69, 17)
        Me.TB_kod.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.ReadOnly = True
        Me.TB_kod.Size = New System.Drawing.Size(76, 20)
        Me.TB_kod.TabIndex = 0
        Me.TB_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_lotto
        '
        Me.TB_lotto.BackColor = System.Drawing.SystemColors.Window
        Me.TB_lotto.Location = New System.Drawing.Point(69, 41)
        Me.TB_lotto.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_lotto.Name = "TB_lotto"
        Me.TB_lotto.ReadOnly = True
        Me.TB_lotto.Size = New System.Drawing.Size(76, 20)
        Me.TB_lotto.TabIndex = 1
        Me.TB_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GB_lotto_nat
        '
        Me.GB_lotto_nat.Controls.Add(Me.Label12)
        Me.GB_lotto_nat.Controls.Add(Me.Label11)
        Me.GB_lotto_nat.Controls.Add(Me.TB_data)
        Me.GB_lotto_nat.Controls.Add(Me.TB_nr_zam)
        Me.GB_lotto_nat.Controls.Add(Me.Label9)
        Me.GB_lotto_nat.Controls.Add(Me.Label10)
        Me.GB_lotto_nat.Controls.Add(Me.TB_lotto_info)
        Me.GB_lotto_nat.Controls.Add(Me.TB_nazwa_dostawcy)
        Me.GB_lotto_nat.Controls.Add(Me.Label7)
        Me.GB_lotto_nat.Controls.Add(Me.TB_lotto_kod)
        Me.GB_lotto_nat.Location = New System.Drawing.Point(10, 158)
        Me.GB_lotto_nat.Margin = New System.Windows.Forms.Padding(2)
        Me.GB_lotto_nat.Name = "GB_lotto_nat"
        Me.GB_lotto_nat.Padding = New System.Windows.Forms.Padding(2)
        Me.GB_lotto_nat.Size = New System.Drawing.Size(444, 98)
        Me.GB_lotto_nat.TabIndex = 30
        Me.GB_lotto_nat.TabStop = False
        Me.GB_lotto_nat.Text = "Lotto natychmiastowe"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 74)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Data utw.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 50)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Nr zam:"
        '
        'TB_data
        '
        Me.TB_data.BackColor = System.Drawing.SystemColors.Window
        Me.TB_data.Location = New System.Drawing.Point(70, 71)
        Me.TB_data.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_data.Name = "TB_data"
        Me.TB_data.ReadOnly = True
        Me.TB_data.Size = New System.Drawing.Size(76, 20)
        Me.TB_data.TabIndex = 38
        Me.TB_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_nr_zam
        '
        Me.TB_nr_zam.BackColor = System.Drawing.SystemColors.Window
        Me.TB_nr_zam.Location = New System.Drawing.Point(68, 47)
        Me.TB_nr_zam.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_nr_zam.Name = "TB_nr_zam"
        Me.TB_nr_zam.ReadOnly = True
        Me.TB_nr_zam.Size = New System.Drawing.Size(76, 20)
        Me.TB_nr_zam.TabIndex = 37
        Me.TB_nr_zam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 23)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Dostawca:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 46)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Lotto. dostawcy:"
        '
        'TB_lotto_info
        '
        Me.TB_lotto_info.BackColor = System.Drawing.SystemColors.Window
        Me.TB_lotto_info.Location = New System.Drawing.Point(238, 43)
        Me.TB_lotto_info.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_lotto_info.Name = "TB_lotto_info"
        Me.TB_lotto_info.ReadOnly = True
        Me.TB_lotto_info.Size = New System.Drawing.Size(193, 20)
        Me.TB_lotto_info.TabIndex = 32
        '
        'TB_nazwa_dostawcy
        '
        Me.TB_nazwa_dostawcy.BackColor = System.Drawing.SystemColors.Window
        Me.TB_nazwa_dostawcy.Location = New System.Drawing.Point(238, 20)
        Me.TB_nazwa_dostawcy.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_nazwa_dostawcy.Name = "TB_nazwa_dostawcy"
        Me.TB_nazwa_dostawcy.ReadOnly = True
        Me.TB_nazwa_dostawcy.Size = New System.Drawing.Size(193, 20)
        Me.TB_nazwa_dostawcy.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Kod:"
        '
        'TB_lotto_kod
        '
        Me.TB_lotto_kod.BackColor = System.Drawing.SystemColors.Window
        Me.TB_lotto_kod.Location = New System.Drawing.Point(68, 23)
        Me.TB_lotto_kod.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_lotto_kod.Name = "TB_lotto_kod"
        Me.TB_lotto_kod.ReadOnly = True
        Me.TB_lotto_kod.Size = New System.Drawing.Size(76, 20)
        Me.TB_lotto_kod.TabIndex = 28
        Me.TB_lotto_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MP_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 265)
        Me.Controls.Add(Me.GB_lotto_nat)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MP_info"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazyn prętów - Informacje"
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.GB_lotto_nat.ResumeLayout(False)
        Me.GB_lotto_nat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_roznica_PR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_roznica As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_ilosc_galileo As TextBox
    Friend WithEvents TB_ilosc As TextBox
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents TB_czas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_opis As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents TB_lotto As TextBox
    Friend WithEvents GB_lotto_nat As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TB_data As TextBox
    Friend WithEvents TB_nr_zam As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_nazwa_dostawcy As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TB_lotto_info As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_lotto_kod As TextBox
End Class
