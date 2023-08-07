Imports System.Data.Odbc
Public Class G_lotto_prod
    Dim lotto_prod As String
    Private Sub Pobierz_Click(sender As Object, e As EventArgs) Handles BT_pobierz.Click
        lotto_prod = TB_lotto.Text
        For Each GB As Control In Controls.OfType(Of GroupBox)
            For Each TB As TextBox In GB.Controls.OfType(Of TextBox)
                If TB.Name <> "TB_lotto" Then
                    TB.Text = Nothing
                End If
            Next
        Next
        Try
            LoadLottoProd()
            Pobierz_klienta()
            Pobierz_fazy()
            Pobierz_wykaz()
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych galileo")
                Exit Sub
            Else
                PokazBlad()
                Exit Sub
            End If
        End Try
    End Sub
    Sub LoadLottoProd()
        SqlString = "Select * From AS400.MGART00F MGART00F, AS400.PMORD00F PMORD00F WHERE MGART00F.CDARMA = PMORD00F.CDARPO and PMORD00F.ORPRPO='" & lotto_prod & "'"
        Dim da = New OdbcDataAdapter(SqlString, ZCPCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TB_kod_lotto_prod.Text = Trim(dt.Rows(0).Item("CDARPO")).ToString
            TB_opis.Text = Trim(dt.Rows(0).Item("DSARMA")).ToString
            'ilość pokazuje z dodatkowymi 4 zerami 0000 dlatego ilosc dziele przez 10.000
            TB_ilosc_zam.Text = dt.Rows(0).Item("QORDPO") / 10000
            TB_cykl.Text = Trim(dt.Rows(0).Item("CDCIPO"))
            TB_nr_klienta.Text = dt.Rows(0).Item("CLIEPO")
            TB_klient.Text = Nothing

            TB_data_utw.Text = dt.Rows(0).Item("DT01PO")
            TB_data_mod.Text = dt.Rows(0).Item("DTMNPO")
        End If
    End Sub
    Sub Pobierz_klienta()
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
    Private Sub DOS_DODAJ_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class