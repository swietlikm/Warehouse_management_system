Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Math
Public Class MP_info
    Dim ilosc_magazyn As Single
    Dim ilosc_galileo As Single
    Dim roznica As Single
    Dim roznica_pr As Single
    Private Sub MG_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim time As Integer = My.Computer.Clock.TickCount
        If user = "Admin" Then
            TB_czas.Visible = True
        End If

        'czyszczenie wszystkiego
        For Each GB As GroupBox In Me.Controls.OfType(Of GroupBox)()
            For Each TB As TextBox In GB.Controls.OfType(Of TextBox)()
                TB.Clear()
                TB.BackColor = Color.White
            Next
        Next

        'ladowanie danych
        TB_kod.Text = kod
        TB_opis.Text = opis
        TB_lotto.Text = lotto_mp

        LoadMagazynQtty()

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

        LoadLottoNat()

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
        OpenMagConnection()
        SqlString = "Select sum(ilosc) from MP WHERE KodMP ='" & kod & "'"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ilosc_magazyn = dt.Rows(0).Item(0)
            TB_ilosc.Text = ilosc_magazyn
        End If
        MagDbCon.Close()
    End Sub
    Private Sub LoadGalileoQtty()
        Dim SqlODBC As String = "SELECT Sum(cast(MGESI00F.GIATME as FLOAT))
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
    Sub LoadLottoNat()
        SqlString = "SELECT RLAN100F.CDLTRA, RLAN100F.CDARRA, RLAN100F.CDCFRA, RLAN100F.LTFORA, RLAN100F.NRORRA,
                     RLAN100F.DTAPRA, CGPCO00F.DSCOCP
                     FROM ZPL80DAT.RLAN100F RLAN100F, S100A014.ZPL80DAT.CGPCO00F CGPCO00F
                     WHERE RLAN100F.CDCFRA=CGPCO00F.CONTCP and
                     RLAN100F.CDLTRA LIKE '%" & lotto_mp & "'"
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

    Private Sub TB_lotto_kod_TextChanged(sender As Object, e As EventArgs) Handles TB_lotto_kod.TextChanged
        If TB_lotto_kod.Text <> "" And TB_lotto_kod.Text <> kod Then
            TB_lotto_kod.BackColor = Color.Red
        End If
    End Sub
    Private Sub MP_info_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class