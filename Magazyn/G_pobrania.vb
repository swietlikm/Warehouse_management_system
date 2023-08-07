Imports System.Data.Odbc
Public Class G_pobrania
    Dim dtP As DataTable
    Private Sub BT_szukaj_Click(sender As Object, e As EventArgs) Handles BT_szukaj.Click
        If TB_lotto.Text <> "" And Len(TB_lotto.Text) = 8 Then
            LoadPrzelewy(TB_lotto.Text)
        Else
            MsgBox("Podaj prawidłowy kod lotto produkcyjnego składający się z 8 cyfr", vbCritical)
        End If
    End Sub
    Sub LoadPrzelewy(lotto_prod As String)

        For Each TB As Control In GB_info.Controls.OfType(Of TextBox)
            TB.Text = Nothing
        Next
        SqlString = "SELECT RLMOV00F.SEGNRM, Trim(RLMOV00F.CDLTRM), Trim(RLMOV00F.CDARRM), Trim(RLMOV00F.DSARRM), 
                    Cast(RLMOV00F.QTMORM as float), RLMOV00F.CDUMRM, Cast(RLMOV00F.DTOPRM as int), CGPCO00F.DSCOCP, 
                    RLAN100F.LTFORA, RLAN100F.NRORRA, RLAN100F.DTAPRA
                    FROM ZPL80DAT.RLMOV00F RLMOV00F, ZPL80DAT.RLAN100F RLAN100F, S100A014.ZPL80DAT.CGPCO00F CGPCO00F
                    WHERE RLAN100F.CDCFRA=CGPCO00F.CONTCP and RLAN100F.CDLTRA=RLMOV00F.CDLTRM and RLMOV00F.ORPRRM ='" & lotto_prod & "'"
        Dim da = New OdbcDataAdapter(SqlString, GalileoCon)
        dtP = New DataTable
        da.Fill(dtP)
        DGV_przelewy.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dtP.Rows.Count > 0 Then
            AddHandler DGV_przelewy.SelectionChanged, AddressOf DGV_przelewy_CellMouseClick
            AddHandler DGV_przelewy.CellMouseClick, AddressOf DGV_przelewy_CellMouseClick
            DGV_przelewy.Rows.Add(dtP.Rows.Count)
            For i = 0 To dtP.Rows.Count - 1
                With DGV_przelewy.Rows(i)
                    .Cells(0).Value = dtP.Rows(i).Item(0)
                    .Cells(1).Value = dtP.Rows(i).Item(1)
                    .Cells(2).Value = dtP.Rows(i).Item(2)
                    .Cells(3).Value = dtP.Rows(i).Item(3)
                    .Cells(4).Value = dtP.Rows(i).Item(4)
                    .Cells(5).Value = dtP.Rows(i).Item(5)
                    If dtP.Rows(i).Item(6).ToString <> 0 Then
                        Dim data = DateTime.ParseExact(dtP.Rows(i).Item(6).ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                        .Cells(6).Value = data.ToString("dd.MM.yyyy")
                    End If
                End With
            Next
            If dtP.Rows.Count > 1 Then
                DGV_przelewy.CurrentCell.Selected = False
                For Each TB As Control In GB_info.Controls.OfType(Of TextBox)
                    TB.Text = Nothing
                Next
            End If
        Else
            SqlString = "SELECT RLMOV00F.SEGNRM, Trim(RLMOV00F.CDLTRM), Trim(RLMOV00F.CDARRM), Trim(RLMOV00F.DSARRM), 
                    Cast(RLMOV00F.QTMORM as float), RLMOV00F.CDUMRM, Cast(RLMOV00F.DTOPRM as int)
                    FROM ZPL80DAT.RLMOV00F RLMOV00F
                    WHERE RLMOV00F.ORPRRM ='" & lotto_prod & "'"
            da = New OdbcDataAdapter(SqlString, GalileoCon)
            dtP = New DataTable
            da.Fill(dtP)
            If dtP.Rows.Count > 0 Then
                RemoveHandler DGV_przelewy.SelectionChanged, AddressOf DGV_przelewy_CellMouseClick
                RemoveHandler DGV_przelewy.CellMouseClick, AddressOf DGV_przelewy_CellMouseClick
                DGV_przelewy.Rows.Add(dtP.Rows.Count)
                For i = 0 To dtP.Rows.Count - 1
                    With DGV_przelewy.Rows(i)
                        .Cells(0).Value = dtP.Rows(i).Item(0)
                        .Cells(1).Value = dtP.Rows(i).Item(1)
                        .Cells(2).Value = dtP.Rows(i).Item(2)
                        .Cells(3).Value = dtP.Rows(i).Item(3)
                        .Cells(4).Value = dtP.Rows(i).Item(4)
                        .Cells(5).Value = dtP.Rows(i).Item(5)
                        If dtP.Rows(i).Item(6).ToString <> 0 Then
                            Dim data = DateTime.ParseExact(dtP.Rows(i).Item(6).ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                            .Cells(6).Value = data.ToString("dd.MM.yyyy")
                        End If
                    End With
                Next
            Else
                MsgBox("Nie odnaleziono ruchów dla podanego numeru lotto", vbCritical)
            End If
        End If
    End Sub
    Private Sub DGV_przelewy_CellMouseClick(sender As Object, e As EventArgs) Handles DGV_przelewy.SelectionChanged, DGV_przelewy.CellMouseClick
        If DGV_przelewy.CurrentRow.Index >= 0 Then
            Try
                Dim index As Integer = DGV_przelewy.CurrentRow.Index
                TB_przel_lotto.Text = Trim(dtP.Rows(index).Item(1)).ToString
                TB_przel_dostawca.Text = Trim(dtP.Rows(index).Item("DSCOCP")).ToString
                TB_przel_lotto_dostawcy.Text = Trim(dtP.Rows(index).Item("LTFORA")).ToString
                TB_przel_numer_zam.Text = Trim(dtP.Rows(index).Item("NRORRA")).ToString
                If dtP.Rows(index).Item("DTAPRA").ToString <> 0 Then
                    Dim data = DateTime.ParseExact(dtP.Rows(index).Item("DTAPRA").ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                    TB_przel_data_dodania.Text = data.ToString("dd.MM.yyyy")
                End If
            Catch
            End Try
        End If
    End Sub
End Class