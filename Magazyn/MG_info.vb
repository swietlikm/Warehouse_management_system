Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Math
Imports System.ComponentModel

Public Class MG_info
    Dim pierwszeotwarcie As Boolean = True
    Dim pUruchomieniePrzelew = True
    Dim dtp As DataTable
    Dim ilosc_magazyn As Single
    Dim ilosc_galileo As Single
    Dim ilosc_lotto As Single
    Dim roznica As Single
    Dim roznica_pr As Single
    Private Sub MG_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim time As Integer = My.Computer.Clock.TickCount

        If user = "Admin" Then
            TB_czas.Visible = True
        End If

        Me.Size = New Size(490, 440)
        Me.TabControl1.Size = New Size(460, 382)

        TB_kod.Text = kod
        TB_opis.Text = opis
        TB_regal.Text = regal
        TB_lotto_prod.Text = lotto_prod
        TB_lotto_nat.Text = lotto_nat

        LoadMagazynQtty()
        LoadRegalQtty()
        LoadRewQtty()

        Try
            LoadGalileoQtty()
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych galileo", vbCritical)
                Close()
                Exit Sub
            Else
                PokazBlad()
                Exit Sub
            End If
        End Try

        If lotto_prod = "" Then
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage3)
        End If

        If lotto_nat <> "" Then
            GB_lotto_nat.Visible = True
            LoadLottoNat()
        Else
            GB_lotto_nat.Visible = False
        End If
        Dim time2 As Integer = My.Computer.Clock.TickCount
        Dim czas As Double = Round((time2 - time) / 1000, 1)
        TB_czas.Text = czas & " sek"
    End Sub
    Private Sub TB_roznica_PR_TextChanged(sender As Object, e As EventArgs) Handles TB_roznica_PR.TextChanged
        If roznica_pr < 3 Then
            TB_roznica.BackColor = Color.LightGreen
            TB_roznica_PR.BackColor = Color.LightGreen
        Else
            TB_roznica.BackColor = Color.LightCoral
            TB_roznica_PR.BackColor = Color.LightCoral
        End If
    End Sub
    Private Sub LoadMagazynQtty()
        SqlString = "Select sum(ilosc) from MG WHERE KodZP ='" & kod & "'"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ilosc_magazyn = dt.Rows(0).Item(0)
            TB_ilosc.Text = ilosc_magazyn
        End If
    End Sub
    Private Sub LoadRegalQtty()
        SqlString = "Select sum(ilosc) from MG WHERE KodZP ='" & kod & "' and regal='" & regal & "'"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TB_ilosc_regal.Text = dt.Rows(0).Item(0)
        End If
    End Sub
    Private Sub LoadRewQtty()
        Dim kodNoRew As String
        Dim dIndex = kod.IndexOf("-")
        kodNoRew = kod.Substring(0, dIndex + 1)
        SqlString = "Select sum(ilosc) from MG WHERE KodZP like '" & kodNoRew & "%'"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TB_ilosc_rew.Text = dt.Rows(0).Item(0)
        End If
    End Sub
    Private Sub LoadGalileoQtty()
        Dim SqlODBC As String = "SELECT Sum(cast(MGESI00F.GIATME as INT))
        FROM S100A014.ZPL80DAT.MGESI00F MGESI00F
        WHERE (MGESI00F.CDMGME<>'900') and MGESI00F.CDARME = '" & kod & "'
        GROUP BY MGESI00F.CDARME
        ORDER BY MGESI00F.CDARME"
        Dim da As New OdbcDataAdapter(SqlODBC, GalileoCon)
        dt = New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            ilosc_galileo = dt.Rows(0).Item(0)
            TB_ilosc_galileo.Text = dt.Rows(0).Item(0)
            roznica = Abs(ilosc_magazyn - ilosc_galileo)
            roznica_pr = Round((Abs(ilosc_magazyn - TB_ilosc_galileo.Text) / Min(ilosc_magazyn, ilosc_galileo) * 100), 1)
            TB_roznica.Text = roznica
            TB_roznica_PR.Text = roznica_pr & " %"
        Else
            TB_ilosc_galileo.Text = "0"
        End If
    End Sub
    Sub LoadLottoProd()
        TB_lotto2.Text = lotto_prod
        SqlString = "Select * From AS400.MGART00F MGART00F, AS400.PMORD00F PMORD00F WHERE MGART00F.CDARMA = PMORD00F.CDARPO and PMORD00F.ORPRPO='" & lotto_prod & "'"
        Dim da = New OdbcDataAdapter(SqlString, ZCPCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TB_kod_lotto_prod.Text = Trim(dt.Rows(0).Item("CDARPO")).ToString
            'ilość pokazuje z dodatkowymi 4 zerami 0000 dlatego ilosc dziele przez 10.000
            TB_ilosc_zam.Text = dt.Rows(0).Item("QORDPO") / 10000
            ilosc_lotto = dt.Rows(0).Item("QORDPO") / 10000
            TB_cykl.Text = Trim(dt.Rows(0).Item("CDCIPO"))
            TB_klient.Text = Nothing
            TB_nr_klienta.Text = dt.Rows(0).Item("CLIEPO")
            TB_data_utw.Text = dt.Rows(0).Item("DT01PO")
            TB_data_mod.Text = dt.Rows(0).Item("DTMNPO")
        Else
            TB_lotto_prod.BackColor = Color.Red
        End If
    End Sub
    Private Sub TB_kod_lotto_prod_TextChanged(sender As Object, e As EventArgs)
        If TB_kod.Text <> TB_kod_lotto_prod.Text And TB_kod_lotto_prod.Text <> "" And
           TB_lotto_prod.Text <> "" Then
            TB_kod_lotto_prod.BackColor = Color.Red
            TB_lotto_prod.BackColor = Color.Red
        End If
    End Sub
    Private Sub TB_lotto_kod_TextChanged(sender As Object, e As EventArgs) Handles TB_lotto_kod.TextChanged
        If TB_lotto_kod.Text <> "" And TB_lotto_kod.Text <> kod Then
            TB_lotto_kod.BackColor = Color.Red
            TB_lotto_nat.BackColor = Color.Red
        End If
    End Sub
    Private Sub Pobierz_klienta()
        Dim da = New OdbcDataAdapter("Select CGPCO00F.DSCOCP From S100A014.ZPL80DAT.CGPCO00F CGPCO00F WHERE CGPCO00F.CONTCP='" & TB_nr_klienta.Text & "'", GalileoCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TB_klient.Text = Trim(dt.Rows(0).Item(0))
        Else
            TB_klient.Text = Nothing
        End If
    End Sub
    Private Sub Pobierz_wykaz()
        Dim dtL As DataTable
        Dim dtT As DataTable
        Dim MP As String
        SqlString = "SELECT MGART00F.DSARMA, MGART00F.UMBAMA, PMIMP00F.CDARPI, PMIMP00F.QIMPPI, PMIMP00F.QPREPI, Cast(PMIMP00F.DTUMPI as int)
                     FROM ZPL80DAT.PMIMP00F PMIMP00F, ZPL80DAT.MGART00F MGART00F 
                     WHERE MGART00F.CDARMA=PMIMP00F.CDARPI and PMIMP00F.ORPRPI='" & lotto_prod & "'"
        Dim da = New OdbcDataAdapter(SqlString, GalileoCon)
        dtL = New DataTable
        da.Fill(dtL)
        Tabela_MP.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dtL.Rows.Count > 0 Then
            Tabela_MP.Rows.Add(dtL.Rows.Count)
            For i = 0 To dtL.Rows.Count - 1
                Tabela_MP.Rows(i).Cells(0).Value = Trim(dtL.Rows(i).Item("CDARPI")) 'kod z wykazu
                Tabela_MP.Rows(i).Cells(1).Value = dtL.Rows(i).Item("DSARMA") 'opis z MGART00F
                Tabela_MP.Rows(i).Cells(2).Value = dtL.Rows(i).Item("UMBAMA") 'jednostka KG/NR

                Dim ilosc As Single = dtL.Rows(i).Item("QIMPPI") 'ilość
                Tabela_MP.Rows(i).Cells(3).Value = ilosc

                Dim ilosc_przelana As Single = dtL.Rows(i).Item("QPREPI") 'ilość zam
                Tabela_MP.Rows(i).Cells(4).Value = ilosc_przelana
                If dtL.Rows(i).Item(5).ToString <> 0 Then
                    Dim data = DateTime.ParseExact(dtL.Rows(i).Item(5).ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                    Tabela_MP.Rows(i).Cells(5).Value = data.ToString("dd.MM.yyyy")
                End If
            Next
        End If
        If Tabela_MP.Rows.Count > 0 Then
            For Each r As DataGridViewRow In Tabela_MP.Rows
                MP = r.Cells(0).Value
                SqlString = "SELECT Sum(cast(MGESI00F.GIATME as INT))
                         FROM S100A014.ZPL80DAT.MGESI00F MGESI00F
                         WHERE (MGESI00F.CDMGME<>'900') and MGESI00F.CDARME = '" & MP & "'
                         GROUP BY MGESI00F.CDARME
                         ORDER BY MGESI00F.CDARME"
                da = New OdbcDataAdapter(SqlString, GalileoCon)
                dtT = New DataTable
                da.Fill(dtT)
                r.Cells(6).Value = dtT.Rows(0).Item(0)
            Next
        End If
    End Sub
    Sub CheckLottoProd()
        If TB_kod_lotto_prod.Text <> kod Then
            If Tabela_MP.Rows.Count > 0 Then
                For Each r As DataGridViewRow In Tabela_MP.Rows
                    If r.Cells(0).Value <> kod Then
                        TB_kod_lotto_prod.BackColor = Color.Red
                        TB_lotto_prod.BackColor = Color.Red
                        TB_lotto2.BackColor = Color.Red
                    Else
                        TB_kod_lotto_prod.BackColor = Color.Empty
                        TB_lotto_prod.BackColor = Color.Empty
                        TB_lotto2.BackColor = Color.Empty
                        Exit Sub
                    End If
                Next
            Else
                TB_kod_lotto_prod.BackColor = Color.Red
                TB_lotto_prod.BackColor = Color.Red
                TB_lotto2.BackColor = Color.Red
            End If
        End If
    End Sub
    Private Sub Pobierz_fazy()
        SqlString = "SELECT PCIMP00F.CDFACI, PCIMP00F.DSFACI, PCIMP00F.CDCLCI, cast(PCIMP00F.QPROCI as INT),
                     cast(PCIMP00F.QSCACI as INT), PCIMP00F.DTFICI
                     FROM AS400.PCIMP00F PCIMP00F WHERE PCIMP00F.ORPRCI='" & lotto_prod & "'"
        Dim da = New OdbcDataAdapter(SqlString, ZCPCon)
        dt = New DataTable
        da.Fill(dt)
        Tabela_fazy.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dt.Rows.Count > 0 Then
            Tabela_fazy.Rows.Add(dt.Rows.Count)
            For i = 0 To dt.Rows.Count - 1
                Tabela_fazy.Rows(i).Cells(0).Value = dt.Rows(i).Item("CDFACI") 'faza
                Tabela_fazy.Rows(i).Cells(1).Value = Trim(dt.Rows(i).Item("DSFACI")) 'opis fazy
                Tabela_fazy.Rows(i).Cells(2).Value = dt.Rows(i).Item("CDCLCI") 'grupa maszyn
                Tabela_fazy.Rows(i).Cells(3).Value = dt.Rows(i).Item(3) 'wyprodukowano
                Tabela_fazy.Rows(i).Cells(4).Value = dt.Rows(i).Item(4) 'braki
                Tabela_fazy.Rows(i).Cells(5).Value = dt.Rows(i).Item("DTFICI") 'data ost mod
            Next
        End If
    End Sub
    Sub LoadLottoNat()
        SqlString = "SELECT RLAN100F.CDLTRA, RLAN100F.CDARRA, RLAN100F.CDCFRA, RLAN100F.LTFORA, RLAN100F.NRORRA,
                     RLAN100F.DTAPRA, CGPCO00F.DSCOCP
                     FROM ZPL80DAT.RLAN100F RLAN100F, S100A014.ZPL80DAT.CGPCO00F CGPCO00F
                     WHERE RLAN100F.CDCFRA=CGPCO00F.CONTCP and
                     RLAN100F.CDLTRA LIKE '%" & lotto_nat & "'"
        Dim da = New OdbcDataAdapter(SqlString, GalileoCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TB_lotto_kod.Text = Trim(dt.Rows(0).Item("CDARRA")).ToString
            TB_nazwa_dostawcy.Text = Trim(dt.Rows(0).Item("DSCOCP")).ToString
            TB_nr_zam.Text = Trim(dt.Rows(0).Item("NRORRA")).ToString
            TB_data.Text = Format(CInt(Trim(dt.Rows(0).Item("DTAPRA"))), "0000/00/00")
            TB_lotto_info.Text = Trim(dt.Rows(0).Item("LTFORA")).ToString
        End If
    End Sub
    Private Sub MP_info_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                Me.Size = New Size(490, 440)
                Me.TabControl1.Size = New Size(460, 382)
            Case 1
                If lotto_prod <> "" And pierwszeotwarcie = True Then
                    LoadLottoProd()
                    Pobierz_klienta()
                    Pobierz_wykaz()
                    CheckLottoProd()
                    Pobierz_fazy()
                    pierwszeotwarcie = False
                End If
                Me.Size = New Size(735, 553)
                Me.TabControl1.Size = New Size(699, 494)
            Case 2
                If lotto_prod <> "" And pUruchomieniePrzelew = True Then
                    LoadPrzelewy()
                    pUruchomieniePrzelew = False
                End If
                Me.Size = New Size(735, 553)
                Me.TabControl1.Size = New Size(699, 494)
        End Select
    End Sub
    Sub LoadPrzelewy()
        SqlString = "SELECT RLMOV00F.SEGNRM, Trim(RLMOV00F.CDLTRM), Trim(RLMOV00F.CDARRM), Trim(RLMOV00F.DSARRM), 
                    Cast(RLMOV00F.QTMORM as float), RLMOV00F.CDUMRM, Cast(RLMOV00F.DTOPRM as int), CGPCO00F.DSCOCP, 
                    RLAN100F.LTFORA, RLAN100F.NRORRA, RLAN100F.DTAPRA
                    FROM ZPL80DAT.RLMOV00F RLMOV00F, ZPL80DAT.RLAN100F RLAN100F, S100A014.ZPL80DAT.CGPCO00F CGPCO00F
                    WHERE RLAN100F.CDCFRA=CGPCO00F.CONTCP and RLAN100F.CDLTRA=RLMOV00F.CDLTRM and RLMOV00F.ORPRRM ='" & lotto_prod & "'"
        Dim da = New OdbcDataAdapter(SqlString, GalileoCon)
        dtp = New DataTable
        da.Fill(dtp)
        DGV_przelewy.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dtp.Rows.Count > 0 Then
            DGV_przelewy.Rows.Add(dtp.Rows.Count)
            For i = 0 To dtp.Rows.Count - 1
                With DGV_przelewy.Rows(i)
                    .Cells(0).Value = dtp.Rows(i).Item(0)
                    .Cells(1).Value = dtp.Rows(i).Item(1)
                    .Cells(2).Value = dtp.Rows(i).Item(2)
                    .Cells(3).Value = dtp.Rows(i).Item(3)
                    .Cells(4).Value = dtp.Rows(i).Item(4)
                    .Cells(5).Value = dtp.Rows(i).Item(5)
                    If dtp.Rows(i).Item(6).ToString <> 0 Then
                        Dim data = DateTime.ParseExact(dtp.Rows(i).Item(6).ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                        .Cells(6).Value = data.ToString("dd.MM.yyyy")
                    End If
                End With
            Next
        End If
        If dtp.Rows.Count > 1 Then
            DGV_przelewy.CurrentCell.Selected = False
            TB_przel_lotto.Text = ""
            TB_przel_dostawca.Text = ""
            TB_przel_lotto_dostawcy.Text = ""
            TB_przel_numer_zam.Text = ""
            TB_przel_data_dodania.Text = ""
        End If
    End Sub
    Private Sub DGV_przelewy_CellMouseClick(sender As Object, e As EventArgs) Handles DGV_przelewy.SelectionChanged, DGV_przelewy.CellMouseClick
        If DGV_przelewy.CurrentRow.Index >= 0 Then
            Dim index As Integer = DGV_przelewy.CurrentRow.Index
            TB_przel_lotto.Text = Trim(dtp.Rows(index).Item(1)).ToString
            TB_przel_dostawca.Text = Trim(dtp.Rows(index).Item("DSCOCP")).ToString
            TB_przel_lotto_dostawcy.Text = Trim(dtp.Rows(index).Item("LTFORA")).ToString
            TB_przel_numer_zam.Text = Trim(dtp.Rows(index).Item("NRORRA")).ToString
            If dtp.Rows(index).Item("DTAPRA").ToString <> 0 Then
                Dim data = DateTime.ParseExact(dtp.Rows(index).Item("DTAPRA").ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                TB_przel_data_dodania.Text = data.ToString("dd.MM.yyyy")
            End If
        End If
    End Sub

    Private Sub MG_info_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class