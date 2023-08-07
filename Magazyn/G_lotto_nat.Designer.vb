<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_lotto_nat
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
        Me.BT_pobierz = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_lotto = New System.Windows.Forms.TextBox()
        Me.GB_lotto_nat = New System.Windows.Forms.GroupBox()
        Me.TB_opis = New System.Windows.Forms.TextBox()
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
        Me.GB_lotto_nat.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_pobierz
        '
        Me.BT_pobierz.Location = New System.Drawing.Point(352, 22)
        Me.BT_pobierz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_pobierz.Name = "BT_pobierz"
        Me.BT_pobierz.Size = New System.Drawing.Size(75, 27)
        Me.BT_pobierz.TabIndex = 34
        Me.BT_pobierz.Text = "Pobierz"
        Me.BT_pobierz.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Lotto:"
        '
        'TB_lotto
        '
        Me.TB_lotto.Location = New System.Drawing.Point(245, 23)
        Me.TB_lotto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_lotto.MaxLength = 9
        Me.TB_lotto.Name = "TB_lotto"
        Me.TB_lotto.Size = New System.Drawing.Size(100, 22)
        Me.TB_lotto.TabIndex = 33
        Me.TB_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GB_lotto_nat
        '
        Me.GB_lotto_nat.Controls.Add(Me.TB_opis)
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
        Me.GB_lotto_nat.Location = New System.Drawing.Point(12, 66)
        Me.GB_lotto_nat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GB_lotto_nat.Name = "GB_lotto_nat"
        Me.GB_lotto_nat.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GB_lotto_nat.Size = New System.Drawing.Size(592, 121)
        Me.GB_lotto_nat.TabIndex = 35
        Me.GB_lotto_nat.TabStop = False
        Me.GB_lotto_nat.Text = "Lotto natychmiastowe"
        '
        'TB_opis
        '
        Me.TB_opis.BackColor = System.Drawing.SystemColors.Window
        Me.TB_opis.Location = New System.Drawing.Point(197, 25)
        Me.TB_opis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_opis.Name = "TB_opis"
        Me.TB_opis.ReadOnly = True
        Me.TB_opis.Size = New System.Drawing.Size(388, 22)
        Me.TB_opis.TabIndex = 41
        Me.TB_opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 17)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Data utw.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Nr zam:"
        '
        'TB_data
        '
        Me.TB_data.BackColor = System.Drawing.SystemColors.Window
        Me.TB_data.Location = New System.Drawing.Point(91, 80)
        Me.TB_data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_data.Name = "TB_data"
        Me.TB_data.ReadOnly = True
        Me.TB_data.Size = New System.Drawing.Size(100, 22)
        Me.TB_data.TabIndex = 38
        Me.TB_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_nr_zam
        '
        Me.TB_nr_zam.BackColor = System.Drawing.SystemColors.Window
        Me.TB_nr_zam.Location = New System.Drawing.Point(91, 52)
        Me.TB_nr_zam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_nr_zam.Name = "TB_nr_zam"
        Me.TB_nr_zam.ReadOnly = True
        Me.TB_nr_zam.Size = New System.Drawing.Size(100, 22)
        Me.TB_nr_zam.TabIndex = 37
        Me.TB_nr_zam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Dostawca:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(221, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Lotto. dostawcy:"
        '
        'TB_lotto_info
        '
        Me.TB_lotto_info.BackColor = System.Drawing.SystemColors.Window
        Me.TB_lotto_info.Location = New System.Drawing.Point(340, 80)
        Me.TB_lotto_info.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_lotto_info.Name = "TB_lotto_info"
        Me.TB_lotto_info.ReadOnly = True
        Me.TB_lotto_info.Size = New System.Drawing.Size(245, 22)
        Me.TB_lotto_info.TabIndex = 32
        Me.TB_lotto_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_nazwa_dostawcy
        '
        Me.TB_nazwa_dostawcy.BackColor = System.Drawing.SystemColors.Window
        Me.TB_nazwa_dostawcy.Location = New System.Drawing.Point(340, 52)
        Me.TB_nazwa_dostawcy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_nazwa_dostawcy.Name = "TB_nazwa_dostawcy"
        Me.TB_nazwa_dostawcy.ReadOnly = True
        Me.TB_nazwa_dostawcy.Size = New System.Drawing.Size(245, 22)
        Me.TB_nazwa_dostawcy.TabIndex = 35
        Me.TB_nazwa_dostawcy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Kod:"
        '
        'TB_lotto_kod
        '
        Me.TB_lotto_kod.BackColor = System.Drawing.SystemColors.Window
        Me.TB_lotto_kod.Location = New System.Drawing.Point(91, 25)
        Me.TB_lotto_kod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_lotto_kod.Name = "TB_lotto_kod"
        Me.TB_lotto_kod.ReadOnly = True
        Me.TB_lotto_kod.Size = New System.Drawing.Size(100, 22)
        Me.TB_lotto_kod.TabIndex = 28
        Me.TB_lotto_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G_lotto_nat
        '
        Me.AcceptButton = Me.BT_pobierz
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 198)
        Me.Controls.Add(Me.GB_lotto_nat)
        Me.Controls.Add(Me.BT_pobierz)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_lotto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "G_lotto_nat"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotto natychmiastwe - informacje"
        Me.GB_lotto_nat.ResumeLayout(False)
        Me.GB_lotto_nat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_pobierz As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_lotto As TextBox
    Friend WithEvents GB_lotto_nat As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TB_data As TextBox
    Friend WithEvents TB_nr_zam As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TB_lotto_info As TextBox
    Friend WithEvents TB_nazwa_dostawcy As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_lotto_kod As TextBox
    Friend WithEvents TB_opis As TextBox
End Class
