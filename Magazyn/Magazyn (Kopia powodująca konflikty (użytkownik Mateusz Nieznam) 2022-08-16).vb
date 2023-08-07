Imports System.Data.Odbc
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Magazyn
    Private Sub Magazyn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUser() 'ładowanie użytkowników

        LoadMG() 'ładowanie Magazynu głównego
        LoadMGR() 'ładowanie ruchów Magazynu głównego

        'LoadMP() 'ładowanie Magazynu Prętów
        'LoadMPR() 'ładowanie ruchów Magazynu Prętów

        'ładowanie etykiety STATUS
        Select Case TabControl.SelectedIndex
            Case 0
                LblStatus.Text = "Magazyn główny - Ilość pozycji: " & MagDataGridView.Rows.Count
            Case 1

            Case 2
                LblStatus.Text = "Magazyn główny - Ilość pozycji: " & MagRDataGridView.Rows.Count
            Case 3

        End Select

    End Sub

    'Private Sub MagDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MagDataGridView.CellFormatting
    '    If e.ColumnIndex = 5 AndAlso IsNumeric(e.Value) AndAlso e.Value > 1000 AndAlso e.Value < 1000000 Then
    '        e.Value = Format(e.Value, "0 000")
    '    End If
    '    If e.ColumnIndex = 5 AndAlso IsNumeric(e.Value) AndAlso e.Value > 1000000 Then
    '        e.Value = Format(e.Value, "0 000 000")
    '    End If
    'End Sub
    Private Sub Wyloguj_Click(sender As Object, e As EventArgs) Handles Wyloguj.Click
        Close()
        Logowanie.Show()
        Logowanie.TB_haslo.Text = Nothing
        Logowanie.BT_podglad.Select()
    End Sub
    Private Sub Magazyn_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Logowanie.Show()
        Logowanie.TB_haslo.Text = Nothing
        Logowanie.BT_podglad.Select()
    End Sub
    Private Sub LoadMG()

        MGTableAdapter.Fill(MagDbDataSet.MG)

        With MagDataGridView

            .Enabled = True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeight = 25

            .Columns(0).Visible = False ' ID

            .Columns(1).Width = 90
            .Columns(1).HeaderText = "Kod"

            .Columns(2).Width = 270
            .Columns(2).HeaderText = "Opis Galileo"

            .Columns(3).Width = 50
            .Columns(3).HeaderText = "Regał"

            .Columns(4).Width = 60
            .Columns(4).HeaderText = "Ilość"

            .Columns(5).Width = 60
            .Columns(5).HeaderText = "Galileo" 'ilośc GALILEO

            .Columns(6).Width = 70
            .Columns(6).HeaderText = "Lotto prod"

            .Columns(7).Width = 70
            .Columns(7).HeaderText = "Lotto nat"

            .Columns(8).Width = 300
            .Columns(8).HeaderText = "Uwagi"

            .Columns(9).HeaderText = "Data dodania"

            .Columns(10).HeaderText = "Data modyfikacji"

            .Columns(11).Width = 50
            .Columns(11).HeaderText = "L.mod"

            .Columns(12).Visible = False ' autor

        End With

        For Each col As DataGridViewColumn In MagDataGridView.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub LoadMGR()

        MG_ruchyTableAdapter.Fill(MagDbDataSet.MG_ruchy)

        With MagRDataGridView

            .Enabled = True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeight = 25

            .Columns(0).Visible = False ' ID

            .Columns(1).HeaderText = "Data ruchu"

            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Akcja"

            .Columns(3).Width = 100
            .Columns(3).HeaderText = "Kod"

            .Columns(4).Width = 270
            .Columns(4).HeaderText = "Opis"

            .Columns(5).Width = 50
            .Columns(5).HeaderText = "Regał"

            .Columns(6).Width = 70
            .Columns(6).HeaderText = "Ilość"

            .Columns(7).Width = 70
            .Columns(7).HeaderText = "Lotto prod"

            .Columns(8).Width = 70
            .Columns(8).HeaderText = "Lotto nat"

            .Columns(9).Width = 230
            .Columns(9).HeaderText = "Uwagi"

            .Columns(10).Width = 160
            .Columns(10).HeaderText = "Uwagi ruchu"

            .Columns(11).Width = 50
            .Columns(11).HeaderText = "Nr mod"

            .Columns(12).Width = 50
            .Columns(12).HeaderText = "MgID"
            .Columns(12).Visible = False

            ' autor
            If user <> "Admin" Then
                .Columns(13).Visible = False
            Else
                .Columns(13).Visible = True
            End If

        End With

        For Each col As DataGridViewColumn In MagRDataGridView.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub LoadUser()
        label_user.Text = user
        Select Case user

            Case "Podgląd"

                'Right click menu
                PobierzToolStripMenuItem.Visible = False
                PobierzPaletęToolStripMenuItem.Visible = False
                InwentaryzacjaToolStripMenuItem.Visible = False
                PrzenieśToolStripMenuItem.Visible = False
                ZmieńToolStripMenuItem.Visible = False
                ToolStripSeparator1.Visible = False
                ToolStripSeparator2.Visible = False
                ToolStripSeparator3.Visible = False
                ToolStripSeparator5.Visible = False

                For Each tabControl As Control In Controls.OfType(Of TabControl)
                    For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                        For Each button As Control In tabPage.Controls.OfType(Of Button)
                            If (button.Name <> "BT_x" And button.Name <> "BT_x2") Then
                                button.Enabled = False
                            End If
                        Next
                    Next
                Next

            Case "Edycja"

                label_user.ForeColor = Color.Blue

            Case "Admin"

                label_user.ForeColor = Color.Red
                UżytkownicyToolStripMenuItem.Visible = True
                DbClearToolStripMenuItem.Visible = True

        End Select
    End Sub
    Private Sub BT_dodaj_Click(sender As Object, e As EventArgs) Handles BT_dodaj.Click
        MG_dodaj.Show()
    End Sub
    Private Sub MagDataGridView_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MagDataGridView.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            If e.ColumnIndex = -1 = False And e.RowIndex = -1 = False Then
                MagDataGridView.CurrentCell = MagDataGridView.Item(e.ColumnIndex, e.RowIndex)
                index = MagDataGridView.Item(0, e.RowIndex).Value
                kod = MagDataGridView.Item(1, e.RowIndex).Value
                regal = MagDataGridView.Item(3, e.RowIndex).Value
                lotto_prod = MagDataGridView.Item(6, e.RowIndex).Value
                lotto_nat = MagDataGridView.Item(7, e.RowIndex).Value
                PoKodzieToolStripMenuItem.Text = "Po kodzie: " & kod
                PoRegaleToolStripMenuItem.Text = "Po regale: " & regal
                If lotto_prod <> "" Then
                    PoLottoProdToolStripMenuItem.Visible = True
                    PoLottoProdToolStripMenuItem.Text = "Po lotto prod: " & lotto_prod
                Else
                    PoLottoProdToolStripMenuItem.Visible = False
                End If
                If lotto_nat <> "" Then
                    PoLottoNatToolStripMenuItem.Text = "Po lotto nat: " & lotto_nat
                    PoLottoNatToolStripMenuItem.Visible = True
                Else
                    PoLottoNatToolStripMenuItem.Visible = False
                End If
                'Menu_rozwijane.Show(MagDataGridView, e.Location)
                Menu_rozwijane.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub MagDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MagDataGridView.CellMouseDoubleClick
        If user = "Admin" Then
            If e.RowIndex >= 0 Then
                index = MagDataGridView.Item(0, e.RowIndex).Value
                MG_Edytuj.Show()
            End If
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        LblStatus.ForeColor = DefaultForeColor
        Select Case TabControl.SelectedIndex
            Case 0
                LblStatus.Text = "Magazyn główny. Ilość pozycji: " & MagDataGridView.Rows.Count
            Case 1

            Case 2
                LblStatus.Text = "Ruchy - Magazyn główny. Ilość pozycji: " & MagRDataGridView.Rows.Count
            Case 3

        End Select
    End Sub

    Private Sub BT_pobierz_Click(sender As Object, e As EventArgs) Handles BT_pobierz.Click
        kod = ""
        MG_pobierz.Show()
    End Sub

    Private Sub PobierzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PobierzToolStripMenuItem.Click
        MG_pobierz.Show()
    End Sub

    Private Sub BT_przenies_Click(sender As Object, e As EventArgs) Handles BT_przenies.Click
        kod = ""
        MG_przenies.Show()
    End Sub

    Private Sub PrzenieśToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrzenieśToolStripMenuItem.Click
        MG_przenies.Show()
    End Sub

    Private Sub BT_inwentaryzacja_Click(sender As Object, e As EventArgs) Handles BT_inwentaryzacja.Click
        kod = ""
        MG_inwentaryzacja.Show()
    End Sub

    Private Sub InwentaryzacjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InwentaryzacjaToolStripMenuItem.Click
        MG_inwentaryzacja.Show()
    End Sub

    Private Sub BT_pobierz_pal_Click(sender As Object, e As EventArgs) Handles BT_pobierz_pal.Click
        regal = ""
        MG_pobierz_pal.Show()
    End Sub

    Private Sub ExportDoExcelaWSZYSTKO(sender As Object, e As EventArgs) Handles WszystkoToolStripMenuItem.Click

        Dim ExportCmd As OleDbCommand
        Dim SFD As SaveFileDialog = SaveFileDialog
        SFD.Filter = "Excel Files (*.xls*)|*.xls"

        Dim xl As Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet

        If Not SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        If MagDbCon.State() = ConnectionState.Closed Then
            MagDbCon.Open()
        End If

        ExportCmd = New OleDbCommand("SELECT * INTO [Excel 8.0;DATABASE=" & SFD.FileName & ";HDR=YES;].[Magazyn główny] from MG", MagDbCon)
        ExportCmd.ExecuteNonQuery()
        ExportCmd = New OleDbCommand("SELECT * INTO [Excel 8.0;DATABASE=" & SFD.FileName & ";HDR=YES;].[Ruchy Magazyn główny] from MG_ruchy", MagDbCon)
        ExportCmd.ExecuteNonQuery()
        MagDbCon.Close()

        xl = CreateObject("Excel.Application")
        wb = xl.Workbooks.Open(SFD.FileName)

        For Each ws In wb.Worksheets

            ws.Range("A:Z").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ws.Range("A:Z").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ws.Range("A1:N1").AutoFilter(Field:=1)
            ws.Range("A:Z").EntireColumn.AutoFit()

        Next

        xl.Visible = True
        xl.WindowState = Excel.XlWindowState.xlMaximized

    End Sub

    'Private Sub WszystkoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WszystkoToolStripMenuItem.Click
    '    Dim ile As Integer
    '    Dim wszystkie As Integer
    '    Dim stan As Integer = 0
    '    Dim xl As Excel.Application
    '    xl = CreateObject("Excel.Application")

    '    'nowy WB
    '    Dim wb As Excel.Workbook
    '    wb = xl.Workbooks.Add
    '    'nowy sheet
    '    Dim ws As Excel.Worksheet
    '    ws = wb.Worksheets(1)
    '    ws.Name = "Magazyn Główny"
    '    xl.Application.ScreenUpdating = False
    '    MagDbCon.Open()
    '    Dim da As New OleDbDataAdapter("Select * From MG", MagDbCon)
    '    Dim daR As New OleDbDataAdapter("Select * From MG_ruchy", MagDbCon)
    '    Dim ds As New DataSet
    '    da.Fill(ds, "MG")
    '    daR.Fill(ds, "MG_ruchy")
    '    MagDbCon.Close()

    '    ile = ds.Tables("MG").Rows.Count
    '    wszystkie = ds.Tables("MG").Rows.Count + ds.Tables("MG_ruchy").Rows.Count - 2
    '    Ladowanie.Show()

    '    ws.Cells(1, 1) = "ID"
    '    ws.Cells(1, 2) = "Kod ZP"
    '    ws.Cells(1, 3) = "Opis"
    '    ws.Cells(1, 4) = "Regał"
    '    ws.Cells(1, 5) = "Ilość"
    '    ws.Cells(1, 6) = "Lotto prod"
    '    ws.Cells(1, 7) = "Lotto nat"
    '    ws.Cells(1, 8) = "Data dodania"
    '    ws.Cells(1, 9) = "Data modyfikacji"
    '    ws.Cells(1, 10) = "l mod"
    '    ws.Cells(1, 11) = "uwagi"
    '    For i As Integer = 0 To ile - 1
    '        stan += 1
    '        Ladowanie.ProgressBar.Value = stan / wszystkie * 100
    '        Ladowanie.lblGen.Text = "Generowanie pliku: " & Round((stan / wszystkie) * 100) & "%"
    '        With ds.Tables("MG").Rows(i)
    '            ws.Cells(i + 2, 1) = .Item("MgID")
    '            ws.Cells(i + 2, 2) = .Item("KodZP")
    '            ws.Cells(i + 2, 3) = .Item("opis")
    '            ws.Cells(i + 2, 4) = .Item("regal")
    '            ws.Cells(i + 2, 5) = .Item("ilosc")
    '            ws.Cells(i + 2, 6) = .Item("lotto_prod")
    '            ws.Cells(i + 2, 7) = .Item("lotto_nat")
    '            ws.Cells(i + 2, 8) = .Item("data_dodania")
    '            ws.Cells(i + 2, 9) = .Item("data_modyfikacji")
    '            ws.Cells(i + 2, 10) = .Item("l_mod")
    '            ws.Cells(i + 2, 11) = .Item("uwagi")
    '        End With
    '    Next
    '    ws.Range("A:Z").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '    ws.Range("A:Z").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '    ws.Range("A1:K1").AutoFilter(Field:=1)
    '    ws.Range("A:Z").EntireColumn.AutoFit()

    '    'ruchy
    '    wb.Worksheets.Add(After:=ws)
    '    ws = wb.Worksheets(2)
    '    ws.Name = "Ruchy - Magazyn Główny"
    '    ws.Cells(1, 1) = "ID"
    '    ws.Cells(1, 2) = "Kod ZP"
    '    ws.Cells(1, 3) = "Opis"
    '    ws.Cells(1, 4) = "Akcja"
    '    ws.Cells(1, 5) = "Regał"
    '    ws.Cells(1, 6) = "Ilość"
    '    ws.Cells(1, 7) = "Lotto prod"
    '    ws.Cells(1, 8) = "Lotto nat"
    '    ws.Cells(1, 9) = "Data"
    '    ws.Cells(1, 10) = "Uwagi - mag"
    '    ws.Cells(1, 11) = "Uwagi - ruch"
    '    ws.Cells(1, 12) = "Nr mod"
    '    ws.Cells(1, 13) = "ID - mag"

    '    ile = ds.Tables("MG_ruchy").Rows.Count

    '    For i As Integer = 0 To ile - 1
    '        stan += 1
    '        Ladowanie.ProgressBar.Value = (stan / wszystkie) * 100
    '        Ladowanie.lblGen.Text = "Generowanie pliku: " & Round((stan / wszystkie) * 100) & "%"
    '        With ds.Tables("MG_ruchy").Rows(i)
    '            ws.Cells(i + 2, 1) = .Item("MG_ruchyID")
    '            ws.Cells(i + 2, 2) = .Item("KodZP")
    '            ws.Cells(i + 2, 3) = .Item("opis_gal")
    '            ws.Cells(i + 2, 4) = .Item("akcja")
    '            ws.Cells(i + 2, 5) = .Item("regal")
    '            ws.Cells(i + 2, 6) = .Item("ilosc")
    '            ws.Cells(i + 2, 7) = .Item("lotto_prod")
    '            ws.Cells(i + 2, 8) = .Item("lotto_nat")
    '            ws.Cells(i + 2, 9) = .Item("data")
    '            ws.Cells(i + 2, 10) = .Item("uwagi")
    '            ws.Cells(i + 2, 11) = .Item("uwagi_mod")
    '            ws.Cells(i + 2, 12) = .Item("Nr_mod")
    '            ws.Cells(i + 2, 13) = .Item("MgID")
    '        End With
    '    Next

    '    ws.Range("A:Z").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '    ws.Range("A:Z").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '    ws.Range("A1:M1").AutoFilter(Field:=1)
    '    ws.Range("A:Z").EntireColumn.AutoFit()

    '    Ladowanie.Close()

    '    'zwróć wynik w postaci arkusza
    '    CType(wb.Worksheets(1), Excel.Worksheet).Select()

    '    xl.WindowState = Excel.XlWindowState.xlMaximized
    '    xl.Visible = True
    '    xl.ScreenUpdating = True
    'End Sub

    Private Sub PoRegaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoRegaleToolStripMenuItem.Click
        F_regal.Text = regal
    End Sub

    Private Sub PoKodzieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoKodzieToolStripMenuItem.Click
        F_Kod.Text = kod
    End Sub

    Private Sub BT_x_Click(sender As Object, e As EventArgs) Handles BT_x.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                    textbox.Text = ""
                Next
            Next
        Next
    End Sub

    Private Sub PobierzPaletęToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PobierzPaletęToolStripMenuItem.Click
        MG_pobierz_pal.Show()
    End Sub

    Private Sub ZmieńToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZmieńToolStripMenuItem.Click
        MG_Edytuj.Show()
    End Sub

    Private Sub PoLottoProdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoLottoProdToolStripMenuItem.Click
        F_lotto_prod.Text = lotto_prod
    End Sub

    Private Sub PoLottoNatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoLottoNatToolStripMenuItem.Click
        F_lotto_nat.Text = lotto_nat
    End Sub

    Private Sub OProgramieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OProgramieToolStripMenuItem.Click
        OProgramie.ShowDialog()
    End Sub

    Private Sub DbClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DbClearToolStripMenuItem.Click
        ds = New DataSet

        If MagDbCon.State = ConnectionState.Closed Then
            MagDbCon.Open()
        End If

        'lasowanie MG_ruchy
        Dim sql As String = "Select * FROM MG_ruchy"
        Dim da As New OleDbDataAdapter(sql, MagDbCon)
        da.Fill(ds, "MG_ruchy")
        If ds.Tables("MG_ruchy").Rows.Count > 0 Then
            For Each row As DataRow In ds.Tables("MG_ruchy").Rows
                row.Delete()
            Next
            Dim cb As New OleDbCommandBuilder(da)
            da.Update(ds, "MG_ruchy")
        End If

        'kasowanie MG
        sql = "Select * FROM MG"
        da = New OleDbDataAdapter(sql, MagDbCon)
        da.Fill(ds, "MG")
        If ds.Tables("MG").Rows.Count > 0 Then
            For Each row As DataRow In ds.Tables("MG").Rows
                row.Delete()
            Next
            Dim cb As New OleDbCommandBuilder(da)
            da.Update(ds, "MG")
        End If
        MGTableAdapter.Fill(MagDbDataSet.MG)
        MG_ruchyTableAdapter.Fill(MagDbDataSet.MG_ruchy)

        MagDbCon.Close()
    End Sub

    Private Sub UżytkownicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UżytkownicyToolStripMenuItem.Click
        Uzytkownicy.Show()
    End Sub
    Private Sub PobierzDaneGalileoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PobierzDaneGalileoToolStripMenuItem.Click
        'Dim ZCPSql As String = "SELECT ... sum(cast GIATME...) "

        Dim dt As New DataTable
        Dim SzukanyWiersz As DataRow
        Dim SzukanyKod As String
        Dim ilosc As Double

        If MagDataGridView.Rows.Count < 1 Then
            MsgBox("Brak danych do których można przypisać ilości z galileo")
            Exit Sub
        End If

        'Try
        '    If ZCPCon.State = ConnectionState.Closed Then
        '        ZCPCon.Open()
        '        Dim da As New OdbcDataAdapter(ZCPSql, ZCPCon)
        '        da.Fill(dt)
        '    End If
        'Catch ex As Exception
        '    PokazBlad()
        'Exit Sub
        'End Try

        ' If dt.Rows.Count > 0 Then
        For Each row As DataGridViewRow In MagDataGridView.Rows
            SzukanyKod = row.Cells(1).Value
            SzukanyWiersz = dt.Select("CDARME ='" & SzukanyKod & "'").First
            ilosc = SzukanyWiersz.Item(0)
            row.Cells(5).Value = ilosc
        Next
        'End If
    End Sub

    Private Sub ZobaczRuchyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZobaczRuchyToolStripMenuItem.Click

        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                For Each button As Control In tabPage.Controls.OfType(Of Button)

                    If (button.Name <> "BT_x" And button.Name <> "BT_x2") Then
                        button.Enabled = False
                    End If

                    If tabPage.TabIndex = 2 Then
                        For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                            textbox.Text = ""
                            textbox.Enabled = False
                        Next
                    End If
                Next
            Next
        Next
        TabControl.SelectedIndex = 2
        FR_MGID.Text = index
        MGruchyBindingSource.RemoveFilter()
        MGruchyBindingSource.Filter = String.Format("MGID = " & index)
        MagRDataGridView.DataSource = MGruchyBindingSource
    End Sub
    Private Sub MG_Filtrowanie(sender As Object, e As EventArgs) Handles F_Kod.TextChanged, F_opis.TextChanged, F_regal.TextChanged, F_uwagi.TextChanged, F_lotto_prod.TextChanged, F_lotto_nat.TextChanged, F_ilosc.TextChanged, F_data_dodania.TextChanged
        MGBindingSource.Filter = String.Format("KodZP like '%{0}%' and opis like '%{1}%' and regal like '%{2}%' 
        and uwagi like '%{3}%' and lotto_prod like '%{4}%' and lotto_nat like '%{5}%' and Convert(ilosc, 'System.String') like '%{6}%' 
        and Convert(data_dodania, 'System.String') like '%{7}%'", F_Kod.Text, F_opis.Text, F_regal.Text, F_uwagi.Text,
        F_lotto_prod.Text, F_lotto_nat.Text, F_ilosc.Text, F_data_dodania.Text)
        MagDataGridView.DataSource = MGBindingSource

        If F_Kod.Text <> "" Or F_opis.Text <> "" Or F_regal.Text <> "" Or F_ilosc.Text <> "" Or F_galileo.Text <> "" Or
            F_lotto_prod.Text <> "" Or F_lotto_nat.Text <> "" Or F_uwagi.Text <> "" Or F_data_dodania.Text <> "" Or
            F_data_modyfikacji.Text <> "" Then
            lblwidok.Visible = True
        Else
            lblwidok.Visible = False
            MGBindingSource.RemoveFilter()
            MagDataGridView.DataSource = MGBindingSource
        End If

        Select Case TabControl.SelectedIndex
            Case 0
                LblStatus.Text = "Magazyn główny. Ilość pozycji: " & MagDataGridView.Rows.Count
            Case 1

            Case 2
                LblStatus.Text = "Ruchy - Magazyn główny. Ilość pozycji: " & MagRDataGridView.Rows.Count
            Case 3

        End Select

    End Sub
    Private Sub MGR_Filtrowanie(sender As Object, e As EventArgs) Handles FR_kod.TextChanged, FR_opis.TextChanged,
        FR_regal.TextChanged, FR_uwagi.TextChanged, FR_lotto_prod.TextChanged, FR_lotto_nat.TextChanged, FR_akcja.TextChanged,
        FR_data.TextChanged, FR_uwagi_mod.TextChanged
        MGruchyBindingSource.Filter = String.Format("KodZP like '%{0}%' and opis_gal like '%{1}%' and regal like '%{2}%'
        and uwagi like '%{3}%' and lotto_prod like '%{4}%' and lotto_nat like '%{5}%' and akcja like '%{6}%'
        and Convert(data, 'System.String') like '%{7}%' and uwagi_mod like '%{8}%'",
        FR_kod.Text, FR_opis.Text, FR_regal.Text, FR_uwagi.Text, FR_lotto_prod.Text, FR_lotto_nat.Text, FR_akcja.Text, FR_data.Text,
        FR_uwagi_mod.Text)

        MagRDataGridView.DataSource = MGruchyBindingSource

        If FR_kod.Text <> "" Or FR_opis.Text <> "" Or FR_regal.Text <> "" Or FR_ilosc.Text <> "" Or FR_lotto_prod.Text <> "" Or
            FR_lotto_nat.Text <> "" Or FR_uwagi.Text <> "" Or FR_data.Text <> "" Or FR_data.Text <> "" Or FR_akcja.Text <> "" Or
            FR_uwagi_mod.Text <> "" Then
            lblWidokRuchy.Visible = True
        Else
            lblWidokRuchy.Visible = False
            MGruchyBindingSource.RemoveFilter()
            MagRDataGridView.DataSource = MGruchyBindingSource
        End If

        Select Case TabControl.SelectedIndex
            Case 0
                LblStatus.Text = "Magazyn główny. Ilość pozycji: " & MagDataGridView.Rows.Count
            Case 1

            Case 2
                LblStatus.Text = "Ruchy - Magazyn główny. Ilość pozycji: " & MagRDataGridView.Rows.Count
            Case 3

        End Select
    End Sub

    Private Sub BT_x2_Click(sender As Object, e As EventArgs) Handles BT_x2.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                For Each button As Control In tabPage.Controls.OfType(Of Button)
                    If tabPage.TabIndex = 2 Then
                        For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                            textbox.Text = ""
                            textbox.Enabled = True
                        Next
                    End If
                Next
            Next
        Next
        MGruchyBindingSource.RemoveFilter()
        MagRDataGridView.DataSource = MGruchyBindingSource
    End Sub
End Class