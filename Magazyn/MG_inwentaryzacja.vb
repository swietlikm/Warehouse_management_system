Imports System.Data.OleDb
Public Class MG_inwentaryzacja
    Dim MgID As Integer
    Dim KodZP As String
    Dim l_mod As Integer
    Dim uwagi_mod As String

    Dim NowaIlosc As Single = 0
    Dim PierwotnaIlosc As Single = 0
    Private Sub MG_pobierz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kod <> "" Then
            MgID = index
            TB_kod.Text = kod
        End If
    End Sub
    Private Sub TB_kod_TextChanged(sender As Object, e As EventArgs) Handles TB_kod.TextChanged
        NowaIlosc = 0 'czyść ilości
        PierwotnaIlosc = 0 'czyść ilości
        LV_lista.Items.Clear() 'czyść ListView
        TB_clear_EX(Me, "TB_kod") 'czyść wszystko oprócz TB_kod

        Dim Lista As ListViewItem
        Dim LVwpis(4) As String
        OpenMagConnection()
        SqlString = "SELECT * FROM MG WHERE KodZP='" & TB_kod.Text & "'"
        ds = New DataSet
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MG")
        MagDbCon.Close()

        'wypisz wszystkie pozycje z magazynu dla danego MP
        If ds.Tables("MG").Rows.Count > 0 Then
            For i = 0 To ds.Tables("MG").Rows.Count - 1
                With ds.Tables("MG").Rows(i)
                    LVwpis(0) = .Item("MgID")
                    LVwpis(1) = .Item("regal").ToString
                    LVwpis(2) = .Item("ilosc")
                    LVwpis(3) = .Item("lotto_prod").ToString
                    LVwpis(4) = .Item("lotto_nat").ToString
                    Lista = New ListViewItem(LVwpis)
                End With
                LV_lista.Items.Add(Lista)
                If LVwpis(0) = MgID Then
                    LV_lista.Items(i).Selected = True
                End If
            Next

            'zaznacz wpis jeżeli jest tylko jeden
            If ds.Tables("MG").Rows.Count = 1 Then
                LV_lista.Items(0).Selected = True
            End If
        End If
    End Sub
    Private Sub LV_lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_lista.SelectedIndexChanged
        If LV_lista.SelectedItems.Count > 0 Then
            MgID = LV_lista.SelectedItems(0).SubItems(0).Text
            OpenMagConnection()
            da = New OleDbDataAdapter("SELECT * FROM MG WHERE MgID =" & MgID, MagDbCon)
            dt = New DataTable
            da.Fill(dt)
            MagDbCon.Close()
            With dt.Rows(0)
                TB_regal.Text = .Item("regal").ToString
                TB_lotto_prod.Text = .Item("lotto_prod").ToString
                TB_lotto_nat.Text = .Item("lotto_nat").ToString
                TB_uwagi.Text = .Item("uwagi").ToString
                TB_galileo.Text = .Item("opis").ToString
                TB_formula.Text = .Item("ilosc_pak").ToString
                PierwotnaIlosc = .Item("ilosc")
            End With
        End If
    End Sub
    Private Sub BT_inwentaryzacja_Click(sender As Object, e As EventArgs) Handles BT_inwentaryzacja.Click
        If Sprawdzaj() = False Then
            Exit Sub
        End If

        Try
            OpenMagConnection()
        Catch
            PokazBlad()
            Exit Sub
        End Try

        SqlString = "SELECT * FROM MG WHERE MgID=" & MgID
        ds = New DataSet
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MG")
        If ds.Tables("MG").Rows.Count > 0 Then
            dr = ds.Tables("MG").Rows(0)
            KodZP = dr.Item("KodZP")
            NowaIlosc = TB_ilosc.Text
            PierwotnaIlosc = dr.Item("ilosc")
            l_mod = CInt(dr.Item("l_mod"))
            uwagi_mod = CB_uwagi_mod.Text
        Else
            Exit Sub
        End If

        If PierwotnaIlosc = NowaIlosc Then
            MsgBox("Ilość jest taka sama jak na regale", vbCritical)
            Exit Sub
        End If

        'Aktualizacja MG
        With dr
            If NowaIlosc = 0 Then
                .Delete()
            Else
                .Item("ilosc_pak") = TB_formula.Text
                .Item("ilosc") = NowaIlosc
                .Item("data_modyfikacji") = Now.ToString(FormatDaty)
                .Item("l_mod") = l_mod + 1
            End If
        End With
        da.Update(ds, "MG")

        'Aktualizacja MG_ruchy
        SqlString = "SELECT * FROM MG_ruchy"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MG_ruchy")
        dNewRow = ds.Tables("MG_ruchy").NewRow()

        With dNewRow
            .Item("data") = Now.ToString(FormatDaty)
            .Item("akcja") = "Inwentaryzacja"
            .Item("KodZP") = TB_kod.Text
            .Item("opis_gal") = TB_galileo.Text
            .Item("regal") = TB_regal.Text
            .Item("ilosc") = NowaIlosc
            .Item("lotto_prod") = TB_lotto_prod.Text
            .Item("lotto_nat") = TB_lotto_nat.Text
            If CB_stan.Checked = True Then
                .Item("stan") = "ok"
            End If
            .Item("uwagi") = TB_uwagi.Text
            If uwagi_mod <> "" Then
                .Item("uwagi_mod") = uwagi_mod & " | Zmieniono ilość z " & PierwotnaIlosc & " na " & NowaIlosc
            Else
                .Item("uwagi_mod") = "Zmieniono ilość z " & PierwotnaIlosc & " na " & NowaIlosc
            End If
            .Item("nr_mod") = l_mod + 1
            .Item("uzytkownik") = PCuser
            .Item("MgID") = MgID
        End With

        ds.Tables("MG_ruchy").Rows.Add(dNewRow)
        da.Update(ds, "MG_ruchy")
        MagDbCon.Close()

        MsgBox("Zmieniono " & KodZP & vbNewLine & vbNewLine & "Poprzednia ilość: " & PierwotnaIlosc & vbNewLine & "Nowa ilość: " & NowaIlosc, vbInformation)
        TB_clear(Me)
        CB_clear(Me)
        TB_kod.Select()
        AktualizujMGDGV()
        kod = ""
        MgID = 0
    End Sub
    Function Sprawdzaj() As Boolean
        Dim status As Boolean = True
        If TB_kod.Text = "" Then
            MsgBox("Podaj kod MP", vbCritical)
            TB_kod.Select()
            status = False
            Return status
        End If
        If LV_lista.Items.Count < 1 Then
            MsgBox("Brak podanego kodu na magazynie", vbCritical)
            TB_kod.Select()
            status = False
            Return status
        End If
        If LV_lista.SelectedItems.Count <= 0 Then
            MsgBox("Zaznacz wpis", vbCritical)
            status = False
            Return status
        End If
        If TB_ilosc.Text = "" Then
            MsgBox("Podaj ilość", vbCritical)
            TB_ilosc.Select()
            status = False
            Return status
            Exit Function
        End If
        If IsNumeric(TB_ilosc.Text) = False Then
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
        Return status
    End Function
    Private Sub MG_pobierz_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BT_kody_Click(sender As Object, e As EventArgs) Handles BT_kody.Click
        Kody.Show()
    End Sub
    Private Sub TB_formula_TextChanged(sender As Object, e As EventArgs) Handles TB_formula.TextChanged
        Dim result = New DataTable().Compute(Nothing, Nothing)
        If TB_formula.Text <> "" Then
            Dim equation As String = TB_formula.Text
            Try
                result = New DataTable().Compute(equation, Nothing)
            Catch ex As Exception
            End Try
            If IsNumeric(result) Then
                TB_ilosc.Text = result
            Else
                TB_ilosc.Text = ""
            End If
        Else
            TB_ilosc.Text = ""
        End If
    End Sub

    Private Sub TB_formula_LostFocus(sender As Object, e As EventArgs) Handles TB_formula.LostFocus
        If TB_formula.Text <> "" And Not (IsNumeric(TB_ilosc.Text)) Then
            TB_formula.BackColor = Color.LightPink
        Else
            TB_formula.BackColor = Color.Empty
        End If
    End Sub
End Class