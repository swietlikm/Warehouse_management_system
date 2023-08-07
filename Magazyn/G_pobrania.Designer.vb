<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_pobrania
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGV_przelewy = New System.Windows.Forms.DataGridView()
        Me.GB_info = New System.Windows.Forms.GroupBox()
        Me.TB_przel_data_dodania = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TB_przel_lotto_dostawcy = New System.Windows.Forms.TextBox()
        Me.TB_przel_numer_zam = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TB_przel_dostawca = New System.Windows.Forms.TextBox()
        Me.TB_przel_lotto = New System.Windows.Forms.TextBox()
        Me.TB_lotto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_szukaj = New System.Windows.Forms.Button()
        Me.Ruch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotto_przelew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kod_przelew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opis_przelew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ilosc_przelew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wsp_przelew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_przelew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_przelewy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_przelewy)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 53)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(904, 239)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Wykaz ruchów"
        '
        'DGV_przelewy
        '
        Me.DGV_przelewy.AllowUserToAddRows = False
        Me.DGV_przelewy.AllowUserToDeleteRows = False
        Me.DGV_przelewy.AllowUserToResizeColumns = False
        Me.DGV_przelewy.AllowUserToResizeRows = False
        Me.DGV_przelewy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_przelewy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_przelewy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_przelewy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_przelewy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ruch, Me.lotto_przelew, Me.kod_przelew, Me.opis_przelew, Me.ilosc_przelew, Me.wsp_przelew, Me.data_przelew})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_przelewy.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_przelewy.Location = New System.Drawing.Point(11, 26)
        Me.DGV_przelewy.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.DGV_przelewy.MultiSelect = False
        Me.DGV_przelewy.Name = "DGV_przelewy"
        Me.DGV_przelewy.ReadOnly = True
        Me.DGV_przelewy.RowHeadersVisible = False
        Me.DGV_przelewy.RowHeadersWidth = 51
        Me.DGV_przelewy.RowTemplate.Height = 24
        Me.DGV_przelewy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_przelewy.Size = New System.Drawing.Size(885, 202)
        Me.DGV_przelewy.TabIndex = 23
        '
        'GB_info
        '
        Me.GB_info.Controls.Add(Me.TB_przel_data_dodania)
        Me.GB_info.Controls.Add(Me.Label29)
        Me.GB_info.Controls.Add(Me.Label28)
        Me.GB_info.Controls.Add(Me.TB_przel_lotto_dostawcy)
        Me.GB_info.Controls.Add(Me.TB_przel_numer_zam)
        Me.GB_info.Controls.Add(Me.Label27)
        Me.GB_info.Controls.Add(Me.Label24)
        Me.GB_info.Controls.Add(Me.Label23)
        Me.GB_info.Controls.Add(Me.TB_przel_dostawca)
        Me.GB_info.Controls.Add(Me.TB_przel_lotto)
        Me.GB_info.Location = New System.Drawing.Point(7, 298)
        Me.GB_info.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_info.Name = "GB_info"
        Me.GB_info.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_info.Size = New System.Drawing.Size(904, 128)
        Me.GB_info.TabIndex = 37
        Me.GB_info.TabStop = False
        Me.GB_info.Text = "Lotto natychmiastowe - informacje"
        '
        'TB_przel_data_dodania
        '
        Me.TB_przel_data_dodania.BackColor = System.Drawing.SystemColors.Window
        Me.TB_przel_data_dodania.Location = New System.Drawing.Point(740, 23)
        Me.TB_przel_data_dodania.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_przel_data_dodania.Name = "TB_przel_data_dodania"
        Me.TB_przel_data_dodania.ReadOnly = True
        Me.TB_przel_data_dodania.Size = New System.Drawing.Size(132, 22)
        Me.TB_przel_data_dodania.TabIndex = 43
        Me.TB_przel_data_dodania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(633, 27)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(97, 17)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "Data dodania:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(29, 91)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(106, 17)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "Lotto dostawcy:"
        '
        'TB_przel_lotto_dostawcy
        '
        Me.TB_przel_lotto_dostawcy.BackColor = System.Drawing.SystemColors.Window
        Me.TB_przel_lotto_dostawcy.Location = New System.Drawing.Point(147, 87)
        Me.TB_przel_lotto_dostawcy.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_przel_lotto_dostawcy.Name = "TB_przel_lotto_dostawcy"
        Me.TB_przel_lotto_dostawcy.ReadOnly = True
        Me.TB_przel_lotto_dostawcy.Size = New System.Drawing.Size(340, 22)
        Me.TB_przel_lotto_dostawcy.TabIndex = 40
        Me.TB_przel_lotto_dostawcy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_przel_numer_zam
        '
        Me.TB_przel_numer_zam.BackColor = System.Drawing.SystemColors.Window
        Me.TB_przel_numer_zam.Location = New System.Drawing.Point(445, 23)
        Me.TB_przel_numer_zam.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_przel_numer_zam.Name = "TB_przel_numer_zam"
        Me.TB_przel_numer_zam.ReadOnly = True
        Me.TB_przel_numer_zam.Size = New System.Drawing.Size(132, 22)
        Me.TB_przel_numer_zam.TabIndex = 39
        Me.TB_przel_numer_zam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(380, 27)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 17)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "Nr zam:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(61, 59)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 17)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Dostawca:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(65, 27)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 17)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Lotto nat.:"
        '
        'TB_przel_dostawca
        '
        Me.TB_przel_dostawca.BackColor = System.Drawing.SystemColors.Window
        Me.TB_przel_dostawca.Location = New System.Drawing.Point(147, 55)
        Me.TB_przel_dostawca.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_przel_dostawca.Name = "TB_przel_dostawca"
        Me.TB_przel_dostawca.ReadOnly = True
        Me.TB_przel_dostawca.Size = New System.Drawing.Size(340, 22)
        Me.TB_przel_dostawca.TabIndex = 35
        Me.TB_przel_dostawca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_przel_lotto
        '
        Me.TB_przel_lotto.BackColor = System.Drawing.SystemColors.Window
        Me.TB_przel_lotto.Location = New System.Drawing.Point(147, 23)
        Me.TB_przel_lotto.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_przel_lotto.Name = "TB_przel_lotto"
        Me.TB_przel_lotto.ReadOnly = True
        Me.TB_przel_lotto.Size = New System.Drawing.Size(196, 22)
        Me.TB_przel_lotto.TabIndex = 34
        Me.TB_przel_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_lotto
        '
        Me.TB_lotto.BackColor = System.Drawing.SystemColors.Window
        Me.TB_lotto.Location = New System.Drawing.Point(392, 22)
        Me.TB_lotto.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_lotto.MaxLength = 8
        Me.TB_lotto.Name = "TB_lotto"
        Me.TB_lotto.Size = New System.Drawing.Size(132, 22)
        Me.TB_lotto.TabIndex = 45
        Me.TB_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Lotto prod:"
        '
        'BT_szukaj
        '
        Me.BT_szukaj.Location = New System.Drawing.Point(533, 20)
        Me.BT_szukaj.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_szukaj.Name = "BT_szukaj"
        Me.BT_szukaj.Size = New System.Drawing.Size(100, 28)
        Me.BT_szukaj.TabIndex = 46
        Me.BT_szukaj.Text = "Pobierz"
        Me.BT_szukaj.UseVisualStyleBackColor = True
        '
        'Ruch
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ruch.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ruch.HeaderText = "Ruch"
        Me.Ruch.MinimumWidth = 6
        Me.Ruch.Name = "Ruch"
        Me.Ruch.ReadOnly = True
        Me.Ruch.Width = 35
        '
        'lotto_przelew
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.lotto_przelew.DefaultCellStyle = DataGridViewCellStyle3
        Me.lotto_przelew.HeaderText = "Lotto"
        Me.lotto_przelew.MinimumWidth = 6
        Me.lotto_przelew.Name = "lotto_przelew"
        Me.lotto_przelew.ReadOnly = True
        '
        'kod_przelew
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kod_przelew.DefaultCellStyle = DataGridViewCellStyle4
        Me.kod_przelew.HeaderText = "Kod"
        Me.kod_przelew.MinimumWidth = 6
        Me.kod_przelew.Name = "kod_przelew"
        Me.kod_przelew.ReadOnly = True
        Me.kod_przelew.Width = 70
        '
        'opis_przelew
        '
        Me.opis_przelew.HeaderText = "Opis"
        Me.opis_przelew.MinimumWidth = 6
        Me.opis_przelew.Name = "opis_przelew"
        Me.opis_przelew.ReadOnly = True
        Me.opis_przelew.Width = 255
        '
        'ilosc_przelew
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ilosc_przelew.DefaultCellStyle = DataGridViewCellStyle5
        Me.ilosc_przelew.HeaderText = "Ilość przelana"
        Me.ilosc_przelew.MinimumWidth = 6
        Me.ilosc_przelew.Name = "ilosc_przelew"
        Me.ilosc_przelew.ReadOnly = True
        Me.ilosc_przelew.Width = 65
        '
        'wsp_przelew
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.wsp_przelew.DefaultCellStyle = DataGridViewCellStyle6
        Me.wsp_przelew.HeaderText = "Jedn."
        Me.wsp_przelew.MinimumWidth = 6
        Me.wsp_przelew.Name = "wsp_przelew"
        Me.wsp_przelew.ReadOnly = True
        Me.wsp_przelew.Width = 35
        '
        'data_przelew
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.data_przelew.DefaultCellStyle = DataGridViewCellStyle7
        Me.data_przelew.HeaderText = "Data przelewu"
        Me.data_przelew.MinimumWidth = 6
        Me.data_przelew.Name = "data_przelew"
        Me.data_przelew.ReadOnly = True
        Me.data_przelew.Width = 80
        '
        'G_pobrania
        '
        Me.AcceptButton = Me.BT_szukaj
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 433)
        Me.Controls.Add(Me.BT_szukaj)
        Me.Controls.Add(Me.TB_lotto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GB_info)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "G_pobrania"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pobrania materiałów"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_przelewy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_info.ResumeLayout(False)
        Me.GB_info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGV_przelewy As DataGridView
    Friend WithEvents GB_info As GroupBox
    Friend WithEvents TB_przel_data_dodania As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents TB_przel_lotto_dostawcy As TextBox
    Friend WithEvents TB_przel_numer_zam As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TB_przel_dostawca As TextBox
    Friend WithEvents TB_przel_lotto As TextBox
    Friend WithEvents TB_lotto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_szukaj As Button
    Friend WithEvents Ruch As DataGridViewTextBoxColumn
    Friend WithEvents lotto_przelew As DataGridViewTextBoxColumn
    Friend WithEvents kod_przelew As DataGridViewTextBoxColumn
    Friend WithEvents opis_przelew As DataGridViewTextBoxColumn
    Friend WithEvents ilosc_przelew As DataGridViewTextBoxColumn
    Friend WithEvents wsp_przelew As DataGridViewTextBoxColumn
    Friend WithEvents data_przelew As DataGridViewTextBoxColumn
End Class
