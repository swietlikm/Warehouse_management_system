Imports System.Data.Odbc
Public Class G_lotto_nat
    Dim lotto_nat As String
    Private Sub Pobierz_Click(sender As Object, e As EventArgs) Handles BT_pobierz.Click
        lotto_nat = TB_lotto.Text

        'czyszczenie all TB
        For Each GB As Control In Controls.OfType(Of GroupBox)
            For Each TB As TextBox In GB.Controls.OfType(Of TextBox)
                If TB.Name <> "TB_lotto" Then
                    TB.Text = Nothing
                End If
            Next
        Next

        'ladowanie danych
        Try
            LoadLottoNat()
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
    Sub LoadLottoNat()
        SqlString = "Select RLAN100F.CDLTRA, RLAN100F.CDARRA, RLAN100F.CDCFRA, RLAN100F.LTFORA, RLAN100F.NRORRA,
                     RLAN100F.DTAPRA, CGPCO00F.DSCOCP, MGART00F.DSARMA
                     From ZPL80DAT.RLAN100F RLAN100F, ZPL80DAT.MGART00F MGART00F, S100A014.ZPL80DAT.CGPCO00F CGPCO00F
                     Where MGART00F.CDARMA = RLAN100F.CDARRA And RLAN100F.CDCFRA = CGPCO00F.CONTCP And
                     RLAN100F.CDLTRA Like '%" & lotto_nat & "'"
        Dim da = New OdbcDataAdapter(SqlString, GalileoCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            TB_lotto_kod.Text = Trim(dt.Rows(0).Item("CDARRA")).ToString
            TB_nazwa_dostawcy.Text = Trim(dt.Rows(0).Item("DSCOCP")).ToString
            TB_nr_zam.Text = Trim(dt.Rows(0).Item("NRORRA")).ToString
            TB_data.Text = Format(CInt(Trim(dt.Rows(0).Item("DTAPRA"))), "0000/00/00")
            TB_lotto_info.Text = Trim(dt.Rows(0).Item("LTFORA")).ToString
            TB_opis.Text = Trim(dt.Rows(0).Item("DSARMA")).ToString
        ElseIf dt.Rows.Count > 1 Then
            MsgBox("Znaleziono więcej niż jeden wpis, popraw numer lotto!", vbCritical)
        Else
            MsgBox("Nie odnaleziono danych dla podanego numeru lotto!", vbCritical)
        End If
    End Sub
End Class