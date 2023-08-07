Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class MG_edytuj
    Dim wynik_formuly As Single
    Private Sub MG_edytuj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenMagConnection()

            SqlString = "SELECT * FROM MG WHERE MgID =" & index
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            ds = New DataSet
            da.Fill(ds, "MG")
            MagDbCon.Close()
            dr = ds.Tables("MG").Rows(0)

        Catch ex As Exception
            If Err.Number = 9 Then
                MsgBox("Wpis nie istnieje, odśwież Magazyn", vbCritical)
                Close()
                Exit Sub
            Else
                PokazBlad()
                Close()
                Exit Sub
            End If
        End Try

        'load TB and CB data
        With dr
            TB_id.Text = .Item("MgID")
            TB_kod.Text = .Item("KodZP").ToString
            TB_galileo.Text = .Item("opis").ToString
            TB_regal.Text = .Item("regal").ToString
            TB_ilosc.Text = .Item("ilosc").ToString
            TB_formula.Text = .Item("ilosc_pak").ToString
            TB_lotto_prod.Text = .Item("lotto_prod").ToString
            TB_lotto_nat.Text = .Item("lotto_nat").ToString
            TB_uwagi.Text = .Item("uwagi").ToString
        End With
    End Sub

    Private Sub BT_zmien_Click(sender As Object, e As EventArgs) Handles BT_zmien.Click
        Dim l_mod As Integer
        If PoprawneDane() = False Then
            Exit Sub
        End If

        Try
            OpenMagConnection()
            SqlString = "SELECT * FROM MG WHERE MgID =" & CInt(TB_id.Text)
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            cb = New OleDbCommandBuilder(da)
            ds = New DataSet
            da.Fill(ds, "MG")
            dr = ds.Tables("MG").Rows(0)
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try

        'Test zmian
        With dr
            If .Item("KodZP").ToString = TB_kod.Text And .Item("opis").ToString = TB_galileo.Text And .Item("regal").ToString = TB_regal.Text And
                .Item("ilosc") = TB_ilosc.Text And .Item("lotto_prod").ToString = TB_lotto_prod.Text And .Item("lotto_nat").ToString = TB_lotto_nat.Text And
                .Item("uwagi").ToString = TB_uwagi.Text And .Item("ilosc_pak").ToString = TB_formula.Text Then
                MsgBox("Nic nie zmieniłeś", vbCritical)
                Exit Sub
            End If
        End With

        With dr
            .Item("KodZP") = TB_kod.Text
            .Item("opis") = TB_galileo.Text
            .Item("regal") = TB_regal.Text
            .Item("ilosc") = TB_ilosc.Text
            .Item("ilosc_pak") = TB_formula.Text

            .Item("lotto_prod") = TB_lotto_prod.Text
            .Item("lotto_nat") = TB_lotto_nat.Text

            .Item("uwagi") = TB_uwagi.Text
            .Item("data_modyfikacji") = Now.ToString(FormatDaty)
            l_mod = .Item("l_mod") + 1
            .Item("l_mod") = l_mod
        End With
        da.Update(ds, "MG")

        SqlString = "SELECT * FROM MG_ruchy"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MG_ruchy")
        dNewRow = ds.Tables("MG_ruchy").NewRow()

        With dNewRow
            .Item("data") = Now.ToString(FormatDaty)
            .Item("akcja") = "Zmieniono wpis"
            .Item("KodZP") = TB_kod.Text
            .Item("opis_gal") = TB_galileo.Text
            .Item("regal") = TB_regal.Text
            .Item("ilosc") = TB_ilosc.Text
            .Item("lotto_prod") = TB_lotto_prod.Text
            .Item("lotto_nat") = TB_lotto_nat.Text
            .Item("uwagi") = TB_uwagi.Text
            .Item("uwagi_mod") = TB_uwagi_mod.Text
            .Item("nr_mod") = l_mod
            .Item("uzytkownik") = PCuser
            .Item("MgID") = CInt(TB_id.Text)
        End With

        ds.Tables("MG_ruchy").Rows.Add(dNewRow)
        da.Update(ds, "MG_ruchy")
        MagDbCon.Close()

        MsgBox("Zmodyfikowano wpis kodu " & TB_kod.Text, vbInformation)
        AktualizujMGDGV()
        Close()

    End Sub
    Function PoprawneDane() As Boolean
        Dim status As Boolean = True

        If TB_kod.Text = "" Then
            MsgBox("Podaj kod", vbCritical)
            TB_kod.Select()
            status = False
            Return status
        End If
        If TB_galileo.Text = "" Then
            MsgBox("Podałeś nieistniejący kod", vbCritical)
            status = False
            Return status
        End If
        If TB_regal.Text = "" Then
            MsgBox("Podaj numer regału", vbCritical)
            TB_regal.Select()
            status = False
            Return status
        End If
        If TB_ilosc.Text = "" Then
            MsgBox("Podaj ilość", vbCritical)
            TB_ilosc.Select()
            status = False
            Return status
        End If
        If Not IsNumeric(TB_ilosc.Text) Then
            MsgBox("Podaj poprawną ilość", vbCritical)
            TB_ilosc.Select()
            status = False
            Return status
        End If
        If TB_ilosc.Text < 0 Then
            MsgBox("Podaj poprawną ilość", vbCritical)
            TB_ilosc.Select()
            status = False
            Return status
        End If
        If TB_lotto_prod.Text = "" And TB_lotto_nat.Text = "" Then
            MsgBox("Podaj numer lotto", vbCritical)
            status = False
            Return status
        End If
        If TB_lotto_prod.Text <> "" Then
            If Not (IsNumeric(TB_lotto_prod.Text) And Len(TB_lotto_prod.Text) = 8) Then
                MsgBox("Podaj poprawny numer lotto składający się z 8 cyfr", vbCritical)
                status = False
                Return status
            End If
        End If
        If TB_lotto_nat.Text <> "" Then
            If Not (IsNumeric(TB_lotto_nat.Text) And Len(TB_lotto_nat.Text) = 9) Then
                MsgBox("Podaj poprawny numer lotto składający się z 9 cyfr", vbCritical)
                status = False
                Return status
            End If
        End If
        If TB_formula.Text <> "" Then
            If TB_ilosc.Text <> wynik_formuly Then
                MsgBox("Formuła nie jest spójna z ilością na regale", vbCritical)
                status = False
                Return status
            End If
        End If
        Return status
    End Function
    Private Sub MGdodaj_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BT_kody_Click(sender As Object, e As EventArgs) Handles BT_kody.Click
        Kody.Show()
    End Sub
    Private Sub TB_kod_LostFocus(sender As Object, e As EventArgs) Handles TB_kod.LostFocus
        Try
            If ZCPCon.State = ConnectionState.Closed Then
                ZCPCon.Open()
            End If
            Dim Sql As String = "SELECT MGART00F.DSARMA FROM AS400.MGART00F MGART00F 
                                 WHERE MGART00F.CDARMA Not Like 'MP%' and MGART00F.CDARMA='" & Trim(TB_kod.Text.ToUpper) & "'"
            Dim da As New OdbcDataAdapter(Sql, ZCPCon)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TB_galileo.Text = Trim(dt.Rows(0).Item(0).ToString)
            Else
                TB_galileo.Text = ""
            End If
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych Galileo!", vbCritical)
                TbEnabled(Me, False)
                BtEnabled(Me, False)
                CBEnabled(Me, False)
            Else
                PokazBlad()
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub TB_kod_TextChanged(sender As Object, e As EventArgs) Handles TB_kod.TextChanged
        TB_galileo.Text = ""
    End Sub
    Private Sub TB_formula_TextChanged(sender As Object, e As EventArgs) Handles TB_formula.TextChanged
        Dim wynik = New DataTable().Compute(Nothing, Nothing)
        If TB_formula.Text <> "" Then
            Dim formula As String = TB_formula.Text
            Try
                wynik = New DataTable().Compute(formula, Nothing)
            Catch ex As Exception
            End Try
            If IsNumeric(wynik) Then
                wynik_formuly = wynik
            Else
                wynik_formuly = -1
            End If
        End If
    End Sub
    Private Sub TB_formula_LostFocus(sender As Object, e As EventArgs) Handles TB_formula.LostFocus
        If TB_formula.Text <> "" And wynik_formuly <> TB_ilosc.Text Then
            TB_formula.BackColor = Color.LightPink
        Else
            TB_formula.BackColor = Color.Empty
        End If
    End Sub
End Class