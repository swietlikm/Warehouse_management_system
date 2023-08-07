Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.IO
Imports System.Reflection
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Magazyn
    Dim int As Integer
    Dim StopEvent As Boolean = False
    Private Sub Magazyn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableDoubleBuffered(MGdgv)
        EnableDoubleBuffered(MPdgv)
        EnableDoubleBuffered(MGRdgv)
        EnableDoubleBuffered(MPRdgv)
        EnableDoubleBuffered(DOSdgv)
        Me.Size = New Size(1392, 726)
        Me.TabControl.Size = New Size(1352, 635)

        LoadUser() 'ładowanie użytkowników

        LoadMG() 'ładowanie Magazynu głównego
        LoadMGR() 'ładowanie ruchów Magazynu głównego

        LoadMP() 'ładowanie Magazynu Prętów
        LoadMPR() 'ładowanie ruchów Magazynu Prętów

        LoadDostawy()

        OdswiezStatus() 'ładowanie etykiety STATUS

    End Sub

    Private Sub MG_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MGdgv.CellFormatting
        If (e.ColumnIndex = 5 Or e.ColumnIndex = 6) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000 AndAlso e.Value < 1000000 Then
            If Integer.TryParse(e.Value, int) Then
                e.Value = Format(e.Value, "0 000")
            Else
                e.Value = Format(e.Value, "0 000.0")
            End If
        End If
        If (e.ColumnIndex = 5 Or e.ColumnIndex = 6) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000000 Then
            If Integer.TryParse(e.Value, int) Then
                e.Value = Format(e.Value, "0 000 000")
            Else
                e.Value = Format(e.Value, "0 000 000.0")
            End If
        End If
        If (e.ColumnIndex = 9) And (e.Value.ToString.ToLower.Contains("brak") Or e.Value.ToString.ToLower.Contains("nok") Or e.Value.ToString.ToLower.Contains("brak") Or e.Value.ToString.ToLower.Contains("czerw")) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 176, 176)
            e.CellStyle.SelectionBackColor = Color.FromArgb(255, 176, 176)
        End If
        If (e.ColumnIndex = 9) And (e.Value.ToString.ToLower.Contains("sel") Or e.Value.ToString.ToLower.Contains("reklamac") Or
            e.Value.ToString.ToLower.Contains("zolt") Or e.Value.ToString.ToLower.Contains("żółt")) Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.SelectionBackColor = Color.Yellow
        End If
    End Sub

    Private Sub MP_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MPdgv.CellFormatting, DOSdgv.CellFormatting
        If (e.ColumnIndex = 4 Or e.ColumnIndex = 5) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000 AndAlso e.Value < 1000000 Then
            If Integer.TryParse(e.Value, int) Then
                e.Value = Format(e.Value, "0 000")
            Else
                e.Value = Format(e.Value, "0 000.0")
            End If
        End If
        If (e.ColumnIndex = 4 Or e.ColumnIndex = 5) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000000 Then
            If Integer.TryParse(e.Value, int) Then
                e.Value = Format(e.Value, "0 000 000")
            Else
                e.Value = Format(e.Value, "0 000 000.0")
            End If
        End If
        If (e.ColumnIndex = 7) And (e.Value.ToString.ToLower.Contains("brak") Or e.Value.ToString.ToLower.Contains("nok") Or e.Value.ToString.ToLower.Contains("brak") Or e.Value.ToString.ToLower.Contains("czerw")) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 176, 176)
            e.CellStyle.SelectionBackColor = Color.FromArgb(255, 176, 176)
        End If
        If (e.ColumnIndex = 7) And (e.Value.ToString.ToLower.Contains("sel") Or e.Value.ToString.ToLower.Contains("reklamac") Or
            e.Value.ToString.ToLower.Contains("zolt") Or e.Value.ToString.ToLower.Contains("żółt")) Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.SelectionBackColor = Color.Yellow
        End If
    End Sub
    Private Sub Ruchy_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MGRdgv.CellFormatting, MPRdgv.CellFormatting
        If e.ColumnIndex = 6 AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000 AndAlso e.Value < 1000000 Then
            If Integer.TryParse(e.Value, int) Then
                e.Value = Format(e.Value, "0 000")
            Else
                e.Value = Format(e.Value, "0 000.0")
            End If
        End If
        If e.ColumnIndex = 6 AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000000 Then
            If Integer.TryParse(e.Value, int) Then
                e.Value = Format(e.Value, "0 000 000")
            Else
                e.Value = Format(e.Value, "0 000 000.0")
            End If
        End If
    End Sub
    Private Sub Wyloguj_Click(sender As Object, e As EventArgs) Handles Wyloguj.Click
        Close()
        Logowanie.Show()
        Logowanie.TB_haslo.Text = Nothing
        Logowanie.BT_podglad.Select()
        Dim keepOpen As New List(Of String) From {Logowanie.Text}
        For index = Application.OpenForms.Count - 1 To 0 Step -1
            If Not keepOpen.Contains(Application.OpenForms(index).Text) Then
                Application.OpenForms(index).Close()
            End If
        Next
    End Sub
    Private Sub Magazyn_Closed(sender As Object, e As EventArgs) Handles Me.Closing
        Logowanie.Show()
        Logowanie.TB_haslo.Text = Nothing
        Logowanie.BT_podglad.Select()
    End Sub
    Private Sub LoadMG()

        MGTableAdapter.Fill(MagDbDataSet.MG)

        With MGdgv

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

            .Columns(4).Width = 100
            .Columns(4).HeaderText = "Formuła"

            .Columns(5).Width = 60
            .Columns(5).HeaderText = "Ilość"

            .Columns(6).Width = 60
            .Columns(6).HeaderText = "Galileo" 'ilośc GALILEO

            .Columns(7).Width = 70
            .Columns(7).HeaderText = "Lotto prod"

            .Columns(8).Width = 70
            .Columns(8).HeaderText = "Lotto nat"

            .Columns(9).Width = 285
            .Columns(9).HeaderText = "Uwagi"

            .Columns(10).Width = 100
            .Columns(10).HeaderText = "Data dodania"

            .Columns(11).Width = 100
            .Columns(11).HeaderText = "Data modyfikacji"

            .Columns(12).Width = 50
            .Columns(12).HeaderText = "L.mod"

        End With

        For Each col As DataGridViewColumn In MGdgv.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub LoadMGR()

        MG_ruchyTableAdapter.Fill(MagDbDataSet.MG_ruchy)

        With MGRdgv

            .Enabled = True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeight = 25

            .Columns(0).Visible = False ' ID

            .Columns(1).Width = 100
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

            .Columns(9).Width = 200
            .Columns(9).HeaderText = "Uwagi"

            .Columns(10).Width = 70
            .Columns(10).HeaderText = "Galileo"

            .Columns(11).Width = 160
            .Columns(11).HeaderText = "Uwagi ruchu"

            .Columns(12).Width = 50
            .Columns(12).HeaderText = "Nr mod"

            .Columns(13).Width = 50
            .Columns(13).HeaderText = "MgID"
            .Columns(13).Visible = False

            ' autor
            If user <> "Admin" Then
                .Columns(14).Visible = False
            Else
                .Columns(14).Visible = True
            End If

        End With

        For Each col As DataGridViewColumn In MGRdgv.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub LoadMP()

        MPTableAdapter.Fill(MagDbDataSet.MP)

        With MPdgv

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
            .Columns(6).HeaderText = "Lotto"

            .Columns(7).Width = 200
            .Columns(7).HeaderText = "Uwagi"

            .Columns(8).Width = 80
            .Columns(8).HeaderText = "Materiał"

            .Columns(9).Width = 50
            .Columns(9).HeaderText = "Przekrój"

            .Columns(10).Width = 50
            .Columns(10).HeaderText = "Wymiar"

            .Columns(11).Width = 100
            .Columns(11).HeaderText = "Data dodania"

            .Columns(12).Width = 100
            .Columns(12).HeaderText = "Data modyfikacji"

            .Columns(13).Width = 50
            .Columns(13).HeaderText = "L.mod"

        End With

        For Each col As DataGridViewColumn In MPdgv.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub LoadMPR()

        MP_ruchyTableAdapter.Fill(MagDbDataSet.MP_ruchy)

        With MPRdgv

            .Enabled = True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeight = 25

            .Columns(0).Visible = False ' ID

            .Columns(1).Width = 100
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

            .Columns(9).Width = 200
            .Columns(9).HeaderText = "Uwagi"

            .Columns(10).Width = 70
            .Columns(10).HeaderText = "Galileo"

            .Columns(11).Width = 160
            .Columns(11).HeaderText = "Uwagi ruchu"

            .Columns(12).Width = 50
            .Columns(12).HeaderText = "Nr mod"

            .Columns(13).Width = 50
            .Columns(13).HeaderText = "MgID"
            .Columns(13).Visible = False

            ' autor
            If user <> "Admin" Then
                .Columns(14).Visible = False
            Else
                .Columns(14).Visible = True
            End If

        End With

        For Each col As DataGridViewColumn In MPRdgv.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub LoadDostawy()

        DOSTAWYTableAdapter.Fill(MagDbDataSet.DOSTAWY)

        With DOSdgv

            .Enabled = True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeight = 25

            .Columns(0).Visible = False ' ID

            .Columns(1).Width = 90
            .Columns(1).HeaderText = "Kod"

            .Columns(2).Width = 270
            .Columns(2).HeaderText = "Opis"

            .Columns(3).Width = 50
            .Columns(3).HeaderText = "Regał"

            .Columns(4).Width = 60
            .Columns(4).HeaderText = "Ilość"

            .Columns(5).Width = 100
            .Columns(5).HeaderText = "Formuła"

            .Columns(6).Width = 75
            .Columns(6).HeaderText = "Wymiar"

            .Columns(7).Width = 70
            .Columns(7).HeaderText = "Lotto prod"

            .Columns(8).Width = 70
            .Columns(8).HeaderText = "Lotto nat"

            .Columns(9).Width = 280
            .Columns(9).HeaderText = "Uwagi"

            .Columns(10).Width = 100
            .Columns(10).HeaderText = "Data dodania"

        End With

        For Each col As DataGridViewColumn In DOSdgv.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub LoadUser()
        label_user.Text = user
        Select Case user

            Case "Podgląd"

                MaterialyToolStripMenuItem.Visible = False

                'Right click menu
                PobierzToolStripMenuItem.Visible = False
                PobierzPaletęToolStripMenuItem.Visible = False
                InwentaryzacjaToolStripMenuItem.Visible = False
                PrzenieśToolStripMenuItem.Visible = False
                PrzenieśRegałToolStripMenuItem.Visible = False
                ZmieńToolStripMenuItem.Visible = False
                DołóżToolStripMenuItem.Visible = False
                ToolStripSeparator1.Visible = False
                ToolStripSeparator2.Visible = False
                ToolStripSeparator3.Visible = False
                ToolStripSeparator4.Visible = False

                TSM_MP_edytuj.Visible = False
                TSM_MP_inwentaryzacja.Visible = False
                TSM_MP_przenies.Visible = False
                TSM_MP_pobierz.Visible = False
                TSM_MP_doloz.Visible = False
                ToolStripSeparator5.Visible = False
                ToolStripSeparator6.Visible = False
                ToolStripSeparator7.Visible = False
                ToolStripSeparator8.Visible = False

                TSM_DOS_edytuj.Visible = False
                TSM_DOS_przenies.Visible = False
                TSM_DOS_edytuj.Visible = False
                WyślijToolStripMenuItem.Visible = False
                TSM_DOS_usun.Visible = False
                ToolStripSeparator10.Visible = False
                ToolStripSeparator11.Visible = False

                For Each tabControl As Control In Controls.OfType(Of TabControl)
                    For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                        For Each button As Control In tabPage.Controls.OfType(Of Button)
                            If (button.Name <> "BT_x" And button.Name <> "BT_x2" And button.Name <> "BT_x3" And button.Name <> "BT_x4" And button.Name <> "BT_x5") Then
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
                BackupToolStripMenuItem.Visible = True

        End Select
    End Sub
    Private Sub BT_dodaj_Click(sender As Object, e As EventArgs) Handles BT_dodaj.Click
        MG_dodaj.Show()
    End Sub
    Private Sub MGdgv_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MGdgv.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            If e.ColumnIndex = -1 = False And e.RowIndex = -1 = False Then
                'MGDataGridView.CurrentCell = MGDataGridView.Item(e.ColumnIndex, e.RowIndex)
                MGdgv.ClearSelection()
                MGdgv.Rows(e.RowIndex).Selected = True
                index = MGdgv.Item(0, e.RowIndex).Value
                kod = MGdgv.Item(1, e.RowIndex).Value.ToString
                regal = MGdgv.Item(3, e.RowIndex).Value.ToString
                lotto_prod = MGdgv.Item(7, e.RowIndex).Value.ToString
                lotto_nat = MGdgv.Item(8, e.RowIndex).Value.ToString
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
                Menu_rozwijane.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub MPdgv_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MPdgv.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            If e.ColumnIndex = -1 = False And e.RowIndex = -1 = False Then
                'MPDataGridView.CurrentCell = MPDataGridView.Item(e.ColumnIndex, e.RowIndex)
                MPdgv.ClearSelection()
                MPdgv.Rows(e.RowIndex).Selected = True
                index = MPdgv.Item(0, e.RowIndex).Value
                kod = MPdgv.Item(1, e.RowIndex).Value.ToString
                regal = MPdgv.Item(3, e.RowIndex).Value.ToString
                lotto_mp = MPdgv.Item(6, e.RowIndex).Value.ToString
                MP_PoKodzie.Text = "Po kodzie: " & kod
                MP_PoRegale.Text = "Po regale: " & regal
                If lotto_mp <> "" Then
                    MP_PoLotto.Visible = True
                    MP_PoLotto.Text = "Po lotto: " & lotto_mp
                End If
            End If
            MP_menu_rozwijane.Show(Cursor.Position)
        End If
    End Sub
    Private Sub MGRdgv_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MGRdgv.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            If e.ColumnIndex = -1 = False And e.RowIndex = -1 = False Then
                'MGDataGridView.CurrentCell = MGDataGridView.Item(e.ColumnIndex, e.RowIndex)
                MGRdgv.ClearSelection()
                MGRdgv.Rows(e.RowIndex).Selected = True
                index = MGRdgv.Item(13, e.RowIndex).Value
                data = MGRdgv.Item(1, e.RowIndex).Value.ToString
                kod = MGRdgv.Item(3, e.RowIndex).Value.ToString
                regal = MGRdgv.Item(5, e.RowIndex).Value.ToString
                lotto_prod = MGRdgv.Item(7, e.RowIndex).Value.ToString
                lotto_nat = MGRdgv.Item(8, e.RowIndex).Value.ToString
                PoKodzieToolStripMenuItem1.Text = "Po kodzie: " & kod
                PoRegaleToolStripMenuItem1.Text = "Po regale: " & regal
                If lotto_prod <> "" Then
                    PoLottoProdToolStripMenuItem1.Visible = True
                    PoLottoProdToolStripMenuItem1.Text = "Po lotto prod: " & lotto_prod
                Else
                    PoLottoProdToolStripMenuItem1.Visible = False
                End If
                If lotto_nat <> "" Then
                    PoLottoNatToolStripMenuItem1.Text = "Po lotto nat: " & lotto_nat
                    PoLottoNatToolStripMenuItem1.Visible = True
                Else
                    PoLottoNatToolStripMenuItem1.Visible = False
                End If
                MGR_MenuStrip.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub MPRdgv_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MPRdgv.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            If e.ColumnIndex = -1 = False And e.RowIndex = -1 = False Then
                MPRdgv.ClearSelection()
                MPRdgv.Rows(e.RowIndex).Selected = True
                index = MPRdgv.Item(13, e.RowIndex).Value
                data = MPRdgv.Item(1, e.RowIndex).Value.ToString
                kod = MPRdgv.Item(3, e.RowIndex).Value.ToString
                regal = MPRdgv.Item(5, e.RowIndex).Value.ToString
                lotto_prod = MPRdgv.Item(7, e.RowIndex).Value.ToString
                lotto_nat = MPRdgv.Item(8, e.RowIndex).Value.ToString
                PoKodzieToolStripMenuItem2.Text = "Po kodzie: " & kod
                PoRegaleToolStripMenuItem2.Text = "Po regale: " & regal
                If lotto_prod <> "" Then
                    PoLottoProdToolStripMenuItem2.Visible = True
                    PoLottoProdToolStripMenuItem2.Text = "Po lotto prod: " & lotto_prod
                Else
                    PoLottoProdToolStripMenuItem2.Visible = False
                End If
                If lotto_nat <> "" Then
                    PoLottoNatToolStripMenuItem2.Text = "Po lotto nat: " & lotto_nat
                    PoLottoNatToolStripMenuItem2.Visible = True
                Else
                    PoLottoNatToolStripMenuItem2.Visible = False
                End If
                MPR_MenuStrip.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub DOSdgv_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DOSdgv.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            If e.ColumnIndex = -1 = False And e.RowIndex = -1 = False Then
                DOSdgv.ClearSelection()
                DOSdgv.Rows(e.RowIndex).Selected = True
                idDostawy = DOSdgv.Item(0, e.RowIndex).Value
                kod = DOSdgv.Item(1, e.RowIndex).Value.ToString
                regal = DOSdgv.Item(3, e.RowIndex).Value.ToString
                ile = DOSdgv.Item(4, e.RowIndex).Value
                ile_pak = DOSdgv.Item(5, e.RowIndex).Value.ToString
                D_wymiar = DOSdgv.Item(6, e.RowIndex).Value.ToString
                lotto_prod = DOSdgv.Item(7, e.RowIndex).Value.ToString
                lotto_nat = DOSdgv.Item(8, e.RowIndex).Value.ToString
                uwagi = DOSdgv.Item(9, e.RowIndex).Value.ToString
                TSM_DOS_filtruj_po_kodzie.Text = "Po kodzie: " & kod
                TSM_DOS_filtruj_po_regale.Text = "Po regale: " & regal
            End If
            DOSTAWY_menu_rozwijane.Show(Cursor.Position)
        End If
    End Sub
    Private Sub MagDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MGdgv.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            index = MGdgv.Item(0, e.RowIndex).Value
            kod = MGdgv.Item(1, e.RowIndex).Value.ToString
            opis = MGdgv.Item(2, e.RowIndex).Value.ToString
            regal = MGdgv.Item(3, e.RowIndex).Value.ToString
            lotto_prod = MGdgv.Item(7, e.RowIndex).Value.ToString
            lotto_nat = MGdgv.Item(8, e.RowIndex).Value.ToString
            MG_info.ShowDialog()
        End If
    End Sub
    Private Sub MPDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MPdgv.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            kod = MPdgv.Item(1, e.RowIndex).Value.ToString
            opis = MPdgv.Item(2, e.RowIndex).Value.ToString
            lotto_mp = MPdgv.Item(6, e.RowIndex).Value.ToString
            MP_info.ShowDialog()
        End If
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

    Private Sub ExportujDoExcelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportujDoExcelaToolStripMenuItem.Click

        Dim ExportCmd As OleDbCommand
        Dim SFD As SaveFileDialog = SaveFileDialog
        SFD.Filter = "Excel Files (*.xls*)|*.xls"

        Dim xl As Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
ponow:
        SFD.FileName = "Magazyn " & Now.ToString("yyyy.MM.dd HH.mm.ss")
        If Not SFD.ShowDialog = Windows.Forms.DialogResult.OK Then

            Exit Sub
        End If

        If MagDbCon.State() = ConnectionState.Closed Then
            MagDbCon.Open()
        End If
        Try
            ExportCmd = New OleDbCommand("SELECT * INTO [Excel 8.0;DATABASE=" & SFD.FileName & ";HDR=YES;].[Magazyn główny] from MG", MagDbCon)
            ExportCmd.ExecuteNonQuery()
            ExportCmd = New OleDbCommand("SELECT * INTO [Excel 8.0;DATABASE=" & SFD.FileName & ";HDR=YES;].[Magazyn prętów] from MP", MagDbCon)
            ExportCmd.ExecuteNonQuery()
            ExportCmd = New OleDbCommand("SELECT Mg_ruchyID, data, akcja, KodZP, opis_gal, regal, ilosc, lotto_prod, lotto_nat, uwagi, stan, uwagi_mod, nr_mod, MgID INTO [Excel 8.0;DATABASE=" & SFD.FileName & ";HDR=YES;].[Ruchy Magazyn główny] from MG_ruchy ORDER BY data DESC", MagDbCon)
            ExportCmd.ExecuteNonQuery()
            ExportCmd = New OleDbCommand("SELECT Mg_ruchyID, data, akcja, KodMP, opis_gal, regal, ilosc, lotto_prod, lotto, uwagi, stan, uwagi_mod, nr_mod, MpID INTO [Excel 8.0;DATABASE=" & SFD.FileName & ";HDR=YES;].[Ruchy Magazyn prętów] from MP_ruchy ORDER BY data DESC", MagDbCon)
            ExportCmd.ExecuteNonQuery()
            MagDbCon.Close()
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Musisz wskazać nowy plik!", vbCritical)
                GoTo ponow
            End If
        End Try
        xl = CreateObject("Excel.Application")
        wb = xl.Workbooks.Open(SFD.FileName)

        For Each ws In wb.Worksheets

            ws.Range("A:Z").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ws.Range("A:Z").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ws.Range("A1:O1").AutoFilter(Field:=1)
            ws.Range("A:Z").EntireColumn.AutoFit()

        Next

        xl.WindowState = Excel.XlWindowState.xlMaximized
        xl.Visible = True
        wb.Save()
    End Sub
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
                    textbox.Enabled = True
                Next
            Next
        Next
        lblwidok.Visible = False
        MGBindingSource.RemoveFilter()
        MGdgv.DataSource = MGBindingSource
        OdswiezStatus()
    End Sub

    Private Sub PobierzPaletęToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PobierzPaletęToolStripMenuItem.Click
        MG_pobierz_pal.Show()
    End Sub

    Private Sub ZmieńToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZmieńToolStripMenuItem.Click
        MG_edytuj.Show()
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
    'Private Sub DbClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DbClearToolStripMenuItem.Click
    '    Dim odp As String

    '    If MagDbCon.State = ConnectionState.Closed Then
    '        MagDbCon.Open()
    '    End If

    '    odp = MsgBox("Czy aby na pewno chcesz skasować całą bazę danych?", MessageBoxButtons.YesNo, "Kasowanie bazy danych")

    '    If odp = DialogResult.Yes Then

    '        KasujBD("SELECT * FROM MG")
    '        KasujBD("SELECT * FROM MG_ruchy")
    '        KasujBD("SELECT * FROM MP")
    '        KasujBD("SELECT * FROM MP_ruchy")

    '        MagDbCon.Close()

    '        AktualizujWszystkieDGV()

    '    End If
    'End Sub
    'Private Sub KasujBD(sql As String)
    '    dt = New DataTable
    '    da = New OleDbDataAdapter(sql, MagDbCon)
    '    cb = New OleDbCommandBuilder(da)
    '    da.Fill(dt)
    '    If dt.Rows.Count > 0 Then
    '        For Each row As DataRow In dt.Rows
    '            row.Delete()
    '        Next
    '        da.Update(dt)
    '    End If
    'End Sub
    Private Sub UżytkownicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UżytkownicyToolStripMenuItem.Click
        Uzytkownicy.Show()
    End Sub
    Private Sub MG_zobacz_ruchy_Click(sender As Object, e As EventArgs) Handles ZobaczRuchyToolStripMenuItem.Click

        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 2 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = False
                    Next
                    lblWidokRuchy.Visible = True
                End If
            Next
        Next
        MGruchyBindingSource.RemoveFilter()
        MGruchyBindingSource.Filter = String.Format("MgID = " & index)
        MGRdgv.DataSource = MGruchyBindingSource
        TabControl.SelectedIndex = 2

        If MGstan.Text = "Koniec" Then
            StopEvent = True
            For Each r As DataGridViewRow In MGRdgv.Rows
                If r.Cells("stanMG").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next
            StopEvent = False
        End If

        OdswiezStatus()
    End Sub
    Private Sub TSM_MP_zobacz_ruchy_Click(sender As Object, e As EventArgs) Handles TSM_MP_zobacz_ruchy.Click

        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 3 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = False
                    Next
                    lblWidok_MPR.Visible = True
                End If
            Next
        Next
        MPruchyBindingSource.RemoveFilter()
        MPruchyBindingSource.Filter = String.Format("MPID = " & index)
        MPRdgv.DataSource = MPruchyBindingSource
        TabControl.SelectedIndex = 3

        If MPstan.Text = "Koniec" Then
            StopEvent = True
            For Each r As DataGridViewRow In MPRdgv.Rows
                If r.Cells("stan").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next
            StopEvent = False
        End If

        OdswiezStatus()
    End Sub
    Private Sub MG_Filtrowanie(sender As Object, e As EventArgs) Handles F_Kod.TextChanged, F_opis.TextChanged, F_regal.TextChanged, F_uwagi.TextChanged,
        F_lotto_prod.TextChanged, F_lotto_nat.TextChanged, F_data_dodania.TextChanged
        Try
            MGBindingSource.Filter = String.Format("KodZP like '%{0}%' and opis like '%{1}%' and regal like '%{2}' 
        and uwagi like '%{3}%' and lotto_prod like '%{4}%' and lotto_nat like '%{5}%' and Convert(ilosc, 'System.String') like '%{6}%' 
        and Convert(data_dodania, 'System.String') like '%{7}%'", F_Kod.Text, F_opis.Text, F_regal.Text, F_uwagi.Text,
        F_lotto_prod.Text, F_lotto_nat.Text, F_ilosc.Text, F_data_dodania.Text)
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try
        MGdgv.DataSource = MGBindingSource

        If F_Kod.Text <> "" Or F_opis.Text <> "" Or F_regal.Text <> "" Or F_ilosc.Text <> "" Or F_galileo.Text <> "" Or
            F_lotto_prod.Text <> "" Or F_lotto_nat.Text <> "" Or F_uwagi.Text <> "" Or F_data_dodania.Text <> "" Then
            lblwidok.Visible = True
        Else
            lblwidok.Visible = False
            MGBindingSource.RemoveFilter()
            MGdgv.DataSource = MGBindingSource
        End If

        OdswiezStatus()

    End Sub
    Private Sub MGR_Filtrowanie(sender As Object, e As EventArgs) Handles FR_data.TextChanged, FR_kod.TextChanged, FR_opis.TextChanged,
        FR_regal.TextChanged, FR_uwagi.TextChanged, FR_lotto_prod.TextChanged, FR_lotto_nat.TextChanged, FR_akcja.TextChanged

        MGruchyBindingSource.Filter = String.Format("Convert(data,'System.String') like '%{0}%' and KodZP like '%{1}%'
        and opis_gal like '%{2}%' and regal like '%{3}'
        and uwagi like '%{4}%' and lotto_prod like '%{5}%' and lotto_nat like '%{6}%' and akcja like '%{7}%'",
        FR_data.Text, FR_kod.Text, FR_opis.Text, FR_regal.Text, FR_uwagi.Text, FR_lotto_prod.Text, FR_lotto_nat.Text, FR_akcja.Text)

        MGRdgv.DataSource = MGruchyBindingSource

        If FR_kod.Text <> "" Or FR_opis.Text <> "" Or FR_regal.Text <> "" Or FR_ilosc.Text <> "" Or FR_lotto_prod.Text <> "" Or
            FR_lotto_nat.Text <> "" Or FR_uwagi.Text <> "" Or FR_data.Text <> "" Or FR_data.Text <> "" Or FR_akcja.Text <> "" Then
            lblWidokRuchy.Visible = True
        Else
            lblWidokRuchy.Visible = False
            MGruchyBindingSource.RemoveFilter()
            MGRdgv.DataSource = MGruchyBindingSource
        End If

        If MGstan.Text = "Koniec" Then
            StopEvent = True
            For Each r As DataGridViewRow In MGRdgv.Rows
                If r.Cells("stanMG").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next
            StopEvent = False
        End If

        OdswiezStatus()

    End Sub
    Private Sub DOS_Filtrowanie(sender As Object, e As EventArgs) Handles FD_kod.TextChanged, FD_opis.TextChanged, FD_regal.TextChanged,
        FD_lotto_prod.TextChanged, FD_lotto_nat.TextChanged, FD_uwagi.TextChanged, FD_data.TextChanged

        DOSTAWYBindingSource.Filter = String.Format("KodZP like '%{0}'
        and opis like '%{1}%' and regal like '%{2}' and lotto_prod like '%{3}%' and lotto_nat like '%{4}%' 
        and uwagi like '%{5}%' and Convert(data_dodania,'System.String') like '%{6}%'",
        FD_kod.Text, FD_opis.Text, FD_regal.Text, FD_lotto_prod.Text, FD_lotto_nat.Text, FD_uwagi.Text, FD_data.Text)

        DOSdgv.DataSource = DOSTAWYBindingSource

        If FD_kod.Text <> "" Or FD_opis.Text <> "" Or FD_regal.Text <> "" Or FD_lotto_prod.Text <> "" Or FD_lotto_nat.Text <> "" Or
            FD_uwagi.Text <> "" Or FD_data.Text <> "" Then
            lblDostawy.Visible = True
        Else
            lblDostawy.Visible = False
            DOSTAWYBindingSource.RemoveFilter()
            DOSdgv.DataSource = DOSTAWYBindingSource
        End If

        OdswiezStatus()

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
        lblWidokRuchy.Visible = False
        MGruchyBindingSource.RemoveFilter()
        MGRdgv.DataSource = MGruchyBindingSource
        OdswiezStatus()
    End Sub
    Private Sub BT_MP_dodaj_Click(sender As Object, e As EventArgs) Handles BT_MP_dodaj.Click
        MP_dodaj.Show()
    End Sub
    Private Sub MP_edytuj_Click(sender As Object, e As EventArgs) Handles TSM_MP_edytuj.Click
        MP_edytuj.Show()
    End Sub
    Private Sub FILTRUJ_MP_TextChanged(sender As Object, e As EventArgs) Handles FMP_kod.TextChanged, FMP_opis.TextChanged,
        FMP_regal.TextChanged, FMP_lotto.TextChanged, FMP_material.TextChanged, FMP_przekroj.TextChanged, FMP_wymiar.TextChanged,
        FMP_uwagi.TextChanged, FMP_data_dodania.TextChanged
        MPBindingSource.Filter = String.Format("KodMP like '%{0}' and opis like '%{1}%' and regal like '%{2}' and lotto like '%{3}%' and
            material like '%{4}%' and przekroj like '%{5}' and wymiar like '%{6}' and uwagi like '%{7}%' and
            Convert(data_dodania,'System.String') like '%{8}%'",
            FMP_kod.Text, FMP_opis.Text, FMP_regal.Text, FMP_lotto.Text, FMP_material.Text, FMP_przekroj.Text, FMP_wymiar.Text,
            FMP_uwagi.Text, FMP_data_dodania.Text)

        MPdgv.DataSource = MPBindingSource

        If FMP_kod.Text <> "" Or FMP_opis.Text <> "" Or FMP_regal.Text <> "" Or FMP_lotto.Text <> "" Or
            FMP_material.Text <> "" Or FMP_przekroj.Text <> "" Or FMP_wymiar.Text <> "" Or FMP_uwagi.Text <> "" Or
            FMP_data_dodania.Text <> "" Then
            lblWidok_MP.Visible = True
        Else
            lblWidok_MP.Visible = False
            MPBindingSource.RemoveFilter()
            MPdgv.DataSource = MPBindingSource
        End If
        OdswiezStatus()
    End Sub
    Private Sub MPR_Filtrowanie(sender As Object, e As EventArgs) Handles FMPR_data.TextChanged, FMPR_kod.TextChanged, FMPR_opis.TextChanged,
        FMPR_regal.TextChanged, FMPR_uwagi.TextChanged, FMPR_lotto.TextChanged, FMPR_akcja.TextChanged, FMPR_lotto_prod.TextChanged

        MPruchyBindingSource.Filter = String.Format("Convert(data,'System.String') like '%{0}' and Convert(KodMP,'System.String') like '%{1}'
        and Convert(opis_gal,'System.String') like '%{2}%' and Convert(regal,'System.String') like '%{3}' and Convert(uwagi,'System.String') like '%{4}%'
        and Convert(lotto,'System.String') like '%{5}%' and Convert(akcja,'System.String') like '%{6}%' and CONVERT(ISNULL(lotto_prod, ''),'System.String') LIKE '%{7}%'",
        _FMPR_data.Text, FMPR_kod.Text, FMPR_opis.Text, FMPR_regal.Text,
        _FMPR_uwagi.Text, FMPR_lotto.Text, FMPR_akcja.Text, FMPR_lotto_prod.Text)

        MPRdgv.DataSource = MPruchyBindingSource

        If FMPR_kod.Text <> "" Or FMPR_opis.Text <> "" Or FMPR_regal.Text <> "" Or FMPR_ilosc.Text <> "" Or FMPR_lotto.Text <> "" Or
            FMPR_uwagi.Text <> "" Or FMPR_data.Text <> "" Or FMPR_data.Text <> "" Or FMPR_akcja.Text <> "" Or FMPR_lotto_prod.Text <> "" Then
            lblWidok_MPR.Visible = True
        Else
            lblWidok_MPR.Visible = False
            MPruchyBindingSource.RemoveFilter()
            MPRdgv.DataSource = MPruchyBindingSource
        End If

        If MPstan.Text = "Koniec" Then
            StopEvent = True
            For Each r As DataGridViewRow In MPRdgv.Rows
                If r.Cells("stan").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next
            StopEvent = False
        End If

        OdswiezStatus()
    End Sub
    Private Sub MPR_czysc_filtry_Click(sender As Object, e As EventArgs) Handles BT_x4.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 3 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = True
                    Next
                End If
            Next
        Next
        lblWidok_MPR.Visible = False
        MPruchyBindingSource.RemoveFilter()
        MPRdgv.DataSource = MPruchyBindingSource
        OdswiezStatus()
    End Sub
    Private Sub MP_czysc_filtry_Click(sender As Object, e As EventArgs) Handles BT_x3.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 1 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = True
                    Next
                End If
            Next
        Next
        lblWidok_MP.Visible = False
        MPBindingSource.RemoveFilter()
        MPdgv.DataSource = MPBindingSource
        OdswiezStatus()
    End Sub
    Private Sub DOS_czysc_filtry_Click(sender As Object, e As EventArgs) Handles BT_x5.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 4 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = True
                    Next
                End If
            Next
        Next
        lblDostawy.Visible = False
        DOSTAWYBindingSource.RemoveFilter()
        DOSdgv.DataSource = DOSTAWYBindingSource
        OdswiezStatus()
    End Sub
    Private Sub MP_PoKodzie_Click(sender As Object, e As EventArgs) Handles MP_PoKodzie.Click
        FMP_kod.Text = kod
    End Sub
    Private Sub BT_MP_pobierz_Click(sender As Object, e As EventArgs) Handles BT_MP_pobierz.Click
        kod = ""
        MP_pobierz.Show()
    End Sub
    Private Sub TSM_MP_pobierz_Click(sender As Object, e As EventArgs) Handles TSM_MP_pobierz.Click
        MP_pobierz.Show()
    End Sub
    Private Sub TSM_MP_inwentaryzacja_Click(sender As Object, e As EventArgs) Handles TSM_MP_inwentaryzacja.Click
        MP_inwentaryzacja.Show()
    End Sub

    Private Sub BT_MP_inwentaryzacja_Click(sender As Object, e As EventArgs) Handles BT_MP_inwentaryzacja.Click
        kod = ""
        MP_inwentaryzacja.Show()
    End Sub

    Private Sub BT_MP_przenies_Click(sender As Object, e As EventArgs) Handles BT_MP_przenies.Click
        kod = ""
        MP_przenies.Show()
    End Sub

    Private Sub TSM_MP_przenies_Click(sender As Object, e As EventArgs) Handles TSM_MP_przenies.Click
        MP_przenies.Show()
    End Sub

    Private Sub MP_PoLotto_Click(sender As Object, e As EventArgs) Handles MP_PoLotto.Click
        FMP_lotto.Text = lotto_mp
    End Sub
    Private Sub MP_PoRegale_Click(sender As Object, e As EventArgs) Handles MP_PoRegale.Click
        FMP_regal.Text = regal
    End Sub

    Private Sub MaterialyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialyToolStripMenuItem.Click
        Materialy.Show()
    End Sub

    'Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
    '    Zegar.Text = Format(Now, "dd-MM-yyyy") & "   " & Format(Now, "HH:mm:ss")
    'End Sub
    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        OdswiezStatus()
    End Sub

    Private Sub OdświeżToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdświeżToolStripMenuItem.Click
        AktualizujWszystkieDGV()
    End Sub
    Private Sub KodyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KodyToolStripMenuItem.Click
        Kody.Show()
    End Sub

    Private Sub PobierzStanyMagazynoweToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PobierzStanyMagazynoweToolStripMenuItem.Click
        Dim i As Integer = 0
        Dim Sql As String = "SELECT Trim(MGESI00F.CDARME), Sum(cast(MGESI00F.GIATME as FLOAT))
        FROM S100A014.ZPL80DAT.MGESI00F MGESI00F
        WHERE (MGESI00F.CDMGME<>'900') and (MGESI00F.GIATME>'0')
        GROUP BY MGESI00F.CDARME
        ORDER BY MGESI00F.CDARME"

        Dim dt As New DataTable
        Dim LookupRow As DataRow
        Dim LookupCode As String
        Dim sumawpisow As Integer
        If MGdgv.Rows.Count < 1 And MPdgv.Rows.Count < 1 Then
            MsgBox("Brak danych do których można przypisać ilości z galileo")
            Exit Sub
        Else
            sumawpisow = MGdgv.Rows.Count + MPdgv.Rows.Count
        End If

        Try
            If GalileoCon.State = ConnectionState.Closed Then
                GalileoCon.Open()
                Dim da As New OdbcDataAdapter(Sql, GalileoCon)
                da.Fill(dt)
                GalileoCon.Close()
            End If
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych Galileo", vbCritical)
            Else
                PokazBlad()
            End If
            Exit Sub
        End Try

        If dt.Rows.Count > 0 Then
            Ladowanie.Show()
            'MG
            For Each r As DataGridViewRow In MGdgv.Rows
                i += 1
                Ladowanie.ProgressBar.Value = i / sumawpisow * 100
                LookupCode = r.Cells(1).Value
                Dim fRow = From row In dt.AsEnumerable()
                           Where row.Field(Of String)(dt.Columns(0).ColumnName) = LookupCode
                If fRow.Count > 0 Then
                    LookupRow = fRow.First
                    r.Cells(6).Value = LookupRow.Item(1)
                End If
            Next

            'MP
            For Each r As DataGridViewRow In MPdgv.Rows
                i += 1
                Ladowanie.ProgressBar.Value = i / sumawpisow * 100
                LookupCode = r.Cells(1).Value
                Dim fRow = From row In dt.AsEnumerable()
                           Where row.Field(Of String)(dt.Columns(0).ColumnName) = LookupCode
                If fRow.Count > 0 Then
                    LookupRow = fRow.First
                    r.Cells(5).Value = LookupRow.Item(1)
                End If
            Next
            Ladowanie.Close()
            MsgBox("Zakończono pobieranie danych Galileo", vbInformation)
        End If
    End Sub
    Private Sub BT_DOS_dodaj_Click(sender As Object, e As EventArgs) Handles BT_DOS_dodaj.Click
        DOS_dodaj.Show()
    End Sub
    Private Sub TSM_DOS_edytuj_Click(sender As Object, e As EventArgs) Handles TSM_DOS_edytuj.Click
        DOS_edytuj.Show()
    End Sub
    Private Sub TSM_DOS_usun_Click(sender As Object, e As EventArgs) Handles TSM_DOS_usun.Click
        Dim odp As String = MsgBox("Czy na pewno chcesz usunąć wpis kodu " &
                                   kod & "?", MessageBoxButtons.YesNo + MsgBoxStyle.Question, "Kasowanie dostawy")

        If odp = DialogResult.Yes Then
            Try
                OpenMagConnection()
            Catch ex As Exception
                PokazBlad()
                Exit Sub
            End Try
            SqlString = "SELECT * FROM DOSTAWY WHERE ID =" & idDostawy
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            cb = New OleDbCommandBuilder(da)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Delete()
            Else
                MsgBox("Ten wpis nie istnieje", vbCritical)
            End If
            da.Update(dt)
            MagDbCon.Close()
            AktualizujDOSDGV()
        End If
    End Sub

    Private Sub TSM_DOS_filtruj_po_kodzie_Click(sender As Object, e As EventArgs) Handles TSM_DOS_filtruj_po_kodzie.Click
        FD_kod.Text = kod
    End Sub

    Private Sub TSM_DOS_filtruj_po_regale_Click(sender As Object, e As EventArgs) Handles TSM_DOS_filtruj_po_regale.Click
        FD_regal.Text = regal
    End Sub

    Private Sub TSM_DOS_przenies_MG_Click(sender As Object, e As EventArgs) Handles TSM_DOS_przenies_MG.Click
        With MG_dodaj
            .Show()
            .TB_kod.Text = kod
            .TB_regal.Text = regal
            .TB_lotto_prod.Text = lotto_prod
            .TB_lotto_nat.Text = lotto_nat
            .TB_ilosc.Text = ile
            .TB_formula.Text = ile_pak
            .TB_uwagi.Text = uwagi
            .TB_lotto_prod.Select()
            dostawa = True
        End With
    End Sub
    Private Sub TSM_DOS_przenies_MP_Click(sender As Object, e As EventArgs) Handles TSM_DOS_przenies_MP.Click
        With MP_dodaj
            .Show()
            .TB_kod.Text = kod
            .TB_regal.Text = regal
            .TB_lotto.Text = lotto_nat
            .TB_ilosc.Text = ile
            .TB_wymiar.Text = D_wymiar
            .TB_uwagi.Text = uwagi
            .TB_lotto.Select()
            dostawa = True
        End With
    End Sub

    Private Sub DołóżToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DołóżToolStripMenuItem.Click
        MG_doloz.Show()
    End Sub

    Private Sub BT_doloz_Click(sender As Object, e As EventArgs) Handles BT_doloz.Click
        kod = ""
        MG_doloz.Show()
    End Sub

    Private Sub BT_MP_doloz_Click(sender As Object, e As EventArgs) Handles BT_MP_doloz.Click
        kod = ""
        MP_doloz.Show()
    End Sub

    Private Sub TSM_MP_doloz_Click(sender As Object, e As EventArgs) Handles TSM_MP_doloz.Click
        MP_doloz.Show()
    End Sub

    Private Sub WyślijToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WyślijToolStripMenuItem.Click
        DOS_wyslij.Show()
    End Sub

    Private Sub LottoProdukcyjneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LottoProdukcyjneToolStripMenuItem.Click
        G_lotto_prod.Show()
    End Sub

    Private Sub LottoNatychmiastoweToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LottoNatychmiastoweToolStripMenuItem.Click
        G_lotto_nat.Show()
    End Sub

    Private Sub ZCPQV_Click(sender As Object, e As EventArgs) Handles ZCPQV.Click
        Try
            Process.Start("V:\ZP MAG\ZCP Quick View.exe")
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Nie odnaleziono ścieżki V:\ZP MAG\ZCP Quick View.exe", vbCritical)
            Else
                PokazBlad()
            End If
        End Try
    End Sub
    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered",
                                                     BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        If Not Directory.Exists(MyDocFolder & "\_backup") Then
            Directory.CreateDirectory(MyDocFolder & "\_backup")
        End If
        Try
            My.Computer.FileSystem.CopyFile(FullDatabasePath, MyDocFolder & "\_backup\backup " & Now.ToString("yyyy-MM-dd HH.mm.ss") & ".mdb", True)
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try
        MsgBox("Backup został utworzony!", vbInformation)
    End Sub

    Private Sub MGDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles MGdgv.SelectionChanged, MPdgv.SelectionChanged, DOSdgv.SelectionChanged
        OdswiezStatus()
    End Sub

    Private Sub PrzenieśRegałToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrzenieśRegałToolStripMenuItem.Click
        MG_przenies_regal.Show()
    End Sub

    Private Sub BT_przenies_regal_Click(sender As Object, e As EventArgs) Handles BT_przenies_regal.Click
        regal = ""
        MG_przenies_regal.Show()
    End Sub

    Private Sub PokażWMagazynieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokażWMagazynieToolStripMenuItem.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 0 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = False
                    Next
                    lblwidok.Visible = True
                End If
            Next
        Next
        MGBindingSource.RemoveFilter()
        MGBindingSource.Filter = String.Format("MgID=" & index)
        MGdgv.DataSource = MGBindingSource
        TabControl.SelectedIndex = 0
        OdswiezStatus()
    End Sub

    Private Sub PokażRuchyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokażRuchyToolStripMenuItem.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 2 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = False
                    Next
                    lblWidokRuchy.Visible = True
                End If
            Next
        Next
        MGruchyBindingSource.RemoveFilter()
        MGruchyBindingSource.Filter = String.Format("MgID=" & index)
        MGRdgv.DataSource = MGruchyBindingSource

        If MGstan.Text = "Koniec" Then
            StopEvent = True
            For Each r As DataGridViewRow In MGRdgv.Rows
                If r.Cells("stanMG").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next
            StopEvent = False
        End If

        OdswiezStatus()
    End Sub
    Private Sub PokażWMagazynieToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PokażWMagazynieToolStripMenuItem1.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 1 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = False
                    Next
                    lblWidok_MP.Visible = True
                End If
            Next
        Next
        MPBindingSource.RemoveFilter()
        MPBindingSource.Filter = String.Format("MpID=" & index)
        MPdgv.DataSource = MPBindingSource
        TabControl.SelectedIndex = 1
        OdswiezStatus()
    End Sub
    Private Sub PokażRuchyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PokażRuchyToolStripMenuItem1.Click
        For Each tabControl As Control In Controls.OfType(Of TabControl)
            For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
                If tabPage.TabIndex = 3 Then
                    For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
                        textbox.Text = ""
                        textbox.Enabled = False
                    Next
                    lblWidokRuchy.Visible = True
                End If
            Next
        Next
        MPruchyBindingSource.RemoveFilter()
        MPruchyBindingSource.Filter = String.Format("MpID=" & index)
        MPRdgv.DataSource = MPruchyBindingSource

        If MPstan.Text = "Koniec" Then
            StopEvent = True
            For Each r As DataGridViewRow In MPRdgv.Rows
                If r.Cells("stan").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next
            StopEvent = False
        End If

        OdswiezStatus()
    End Sub

    Private Sub PoKodzieToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PoKodzieToolStripMenuItem1.Click
        FR_kod.Text = kod
    End Sub

    Private Sub PoRegaleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PoRegaleToolStripMenuItem1.Click
        FR_regal.Text = regal
    End Sub

    Private Sub PoLottoProdToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PoLottoProdToolStripMenuItem1.Click
        FR_lotto_prod.Text = lotto_prod
    End Sub

    Private Sub PoLottoNatToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PoLottoNatToolStripMenuItem1.Click
        FR_lotto_nat.Text = lotto_nat
    End Sub
    Private Sub PoKodzieToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PoKodzieToolStripMenuItem2.Click
        FMPR_kod.Text = kod
    End Sub

    Private Sub PoRegaleToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PoRegaleToolStripMenuItem2.Click
        FMPR_regal.Text = regal
    End Sub

    'Private Sub PoLottoProdToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PoLottoProdToolStripMenuItem2.Click
    '    FMPR_lotto_prod.Text = lotto_prod
    '    For Each tabControl As Control In Controls.OfType(Of TabControl)
    '        For Each tabPage As Control In tabControl.Controls.OfType(Of TabPage)
    '            If tabPage.TabIndex = 3 Then
    '                For Each textbox As Control In tabPage.Controls.OfType(Of TextBox)
    '                    textbox.Text = ""
    '                    textbox.Enabled = False
    '                Next
    '                lblWidokRuchy.Visible = True
    '            End If
    '        Next
    '    Next
    '    MPruchyBindingSource.RemoveFilter()
    '    MPruchyBindingSource.Filter = String.Format("lotto_prod=" & "2")
    '    MprDataGridView.DataSource = MPruchyBindingSource
    '    OdswiezStatus()
    'End Sub

    Private Sub PoLottoNatToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PoLottoNatToolStripMenuItem2.Click
        FMPR_lotto.Text = lotto_nat
    End Sub

    Private Sub PobraniaMateriałówToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PobraniaMateriałówToolStripMenuItem.Click
        G_pobrania.Show()
    End Sub
    Private Sub MGstan_Click(sender As Object, e As EventArgs) Handles MGstan.Click
        Dim dgv As DataGridView = MGRdgv
        Dim bt As Button = MGstan
        Dim ColStan As DataGridViewColumn = dgv.Columns("stanMG")

        If bt.Text = "Edytuj" Then

            Dim CBcolumn As New DataGridViewCheckBoxColumn

            With CBcolumn
                .HeaderText = "Galileo"
                .Name = "stanCB"
                .Width = ColStan.Width
            End With

            StopEvent = True

            dgv.Columns.Insert(dgv.Columns.Count - 1, CBcolumn)
            Dim ColStanCB As DataGridViewColumn = dgv.Columns("stanCB")
            ColStanCB.DisplayIndex = ColStan.Index
            ColStan.Visible = False

            For Each r As DataGridViewRow In dgv.Rows
                If r.Cells("stanMG").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next

            StopEvent = False

            'zmiana ReadOnly w kolumnie statusCB
            dgv.ReadOnly = False
            For Each c As DataGridViewColumn In dgv.Columns
                c.ReadOnly = True
            Next
            ColStanCB.ReadOnly = False

            bt.Text = "Koniec"
            bt.BackColor = Color.FromArgb(225, 255, 225)

        ElseIf bt.Text = "Koniec" Then
            ColStan.Visible = True
            dgv.Columns.Remove("stanCB")
            dgv.ReadOnly = True
            bt.Text = "Edytuj"
            bt.BackColor = Color.Transparent
            AktualizujMGR()
        End If
    End Sub
    Private Sub MPstan_Click(sender As Object, e As EventArgs) Handles MPstan.Click
        Dim dgv As DataGridView = MPRdgv
        Dim bt As Button = MPstan
        Dim ColStan As DataGridViewColumn = dgv.Columns("stan")

        If bt.Text = "Edytuj" Then

            Dim CBcolumn As New DataGridViewCheckBoxColumn

            With CBcolumn
                .HeaderText = "Galileo"
                .Name = "stanCB"
                .Width = ColStan.Width
            End With

            StopEvent = True

            dgv.Columns.Insert(dgv.Columns.Count - 1, CBcolumn)
            Dim ColStanCB As DataGridViewColumn = dgv.Columns("stanCB")
            ColStanCB.DisplayIndex = ColStan.Index
            ColStan.Visible = False

            For Each r As DataGridViewRow In dgv.Rows
                If r.Cells("stan").Value.ToString = "ok" Then
                    r.Cells("stanCB").Value = True
                End If
            Next

            StopEvent = False

            'zmiana ReadOnly w kolumnie statusCB
            dgv.ReadOnly = False
            For Each c As DataGridViewColumn In dgv.Columns
                c.ReadOnly = True
            Next
            ColStanCB.ReadOnly = False

            bt.Text = "Koniec"
            bt.BackColor = Color.LemonChiffon

        ElseIf bt.Text = "Koniec" Then
            ColStan.Visible = True
            dgv.Columns.Remove("stanCB")
            dgv.ReadOnly = True
            bt.Text = "Edytuj"
            bt.BackColor = Color.Transparent
            AktualizujMPR()
        End If
    End Sub
    Private Sub EndEditMode(sender As System.Object, e As EventArgs) Handles MGRdgv.CurrentCellDirtyStateChanged
        'if current cell of grid is dirty, commits edit
        If MGRdgv.IsCurrentCellDirty Then
            MGRdgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub EndEditMode2(sender As System.Object, e As EventArgs) Handles MPRdgv.CurrentCellDirtyStateChanged
        'if current cell of grid is dirty, commits edit
        If MPRdgv.IsCurrentCellDirty Then
            MPRdgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub MGRDGVCellValueChanged(sender As DataGridView, e As DataGridViewCellEventArgs) Handles MGRdgv.CellValueChanged
        If e.RowIndex = -1 Then Exit Sub
        If StopEvent = False Then
            Dim MGReRow As DataGridViewRow = MGRdgv.Rows(e.RowIndex)
            OpenMagConnection()
            SqlString = "SELECT MG_ruchyID, stan from MG_ruchy WHERE MG_ruchyID=" & MGReRow.Cells(0).Value
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            cb = New OleDbCommandBuilder(da)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If MGReRow.Cells("stanCB").Value = True Then
                    dt.Rows(0).Item(1) = "ok"
                Else
                    dt.Rows(0).Item(1) = ""
                End If
                da.Update(dt)
            End If
            MagDbCon.Close()
        End If
    End Sub
    Private Sub MPRDGVCellValueChanged(sender As DataGridView, e As DataGridViewCellEventArgs) Handles MPRdgv.CellValueChanged
        If e.RowIndex = -1 Then Exit Sub
        If StopEvent = False Then
            Dim MPReRow As DataGridViewRow = MPRdgv.Rows(e.RowIndex)
            OpenMagConnection()
            SqlString = "SELECT MG_ruchyID, stan from MP_ruchy WHERE MG_ruchyID=" & MPReRow.Cells(0).Value
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            cb = New OleDbCommandBuilder(da)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If MPReRow.Cells("stanCB").Value = True Then
                    dt.Rows(0).Item(1) = "ok"
                Else
                    dt.Rows(0).Item(1) = ""
                End If
                da.Update(dt)
            End If
            MagDbCon.Close()
        End If
    End Sub
End Class