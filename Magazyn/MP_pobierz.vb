Imports System.Data.OleDb
Public Class MP_pobierz
    Dim MpID As Integer
    Dim KodMP As String
    Dim l_mod As Integer
    Dim uwagi_mod As String

    Dim PobieranaIlosc As Single = 0
    Dim PierwotnaIlosc As Single = 0
    Private Sub MP_pobierz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kod <> "" Then
            MpID = index
            TB_kod.Text = kod
        End If
    End Sub
    Private Sub TB_kod_TextChanged(sender As Object, e As EventArgs) Handles TB_kod.TextChanged
        PobieranaIlosc = 0 'czyść ilości
        PierwotnaIlosc = 0 'czyść ilości
        LV_lista.Items.Clear() 'czyść ListView
        TB_clear_EX(Me, "TB_kod") 'czyść wszystko oprócz TB_kod

        Dim Lista As ListViewItem
        Dim LVwpis(4) As String
        OpenMagConnection()
        SqlString = "SELECT * FROM MP WHERE KodMP='" & TB_kod.Text & "'"
        ds = New DataSet
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MP")
        MagDbCon.Close()

        'wypisz wszystkie pozycje z magazynu dla danego MP
        If ds.Tables("MP").Rows.Count > 0 Then
            For i = 0 To ds.Tables("MP").Rows.Count - 1
                With ds.Tables("MP").Rows(i)
                    LVwpis(0) = .Item("MpID")
                    LVwpis(1) = .Item("regal").ToString
                    LVwpis(2) = .Item("ilosc")
                    LVwpis(3) = .Item("lotto").ToString
                    Lista = New ListViewItem(LVwpis)
                End With
                LV_lista.Items.Add(Lista)
                If LVwpis(0) = MpID Then
                    LV_lista.Items(i).Selected = True
                End If
            Next

            'zaznacz wpis jeżeli jest tylko jeden
            If ds.Tables("MP").Rows.Count = 1 Then
                LV_lista.Items(0).Selected = True
            End If
        End If
    End Sub
    Private Sub LV_lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_lista.SelectedIndexChanged
        If LV_lista.SelectedItems.Count > 0 Then
            MpID = LV_lista.SelectedItems(0).SubItems(0).Text
            OpenMagConnection()
            da = New OleDbDataAdapter("SELECT * FROM MP WHERE MpID =" & MpID, MagDbCon)
            dt = New DataTable
            da.Fill(dt)
            MagDbCon.Close()
            With dt.Rows(0)
                TB_regal.Text = .Item("regal").ToString
                TB_lotto.Text = .Item("lotto").ToString
                TB_uwagi.Text = .Item("uwagi").ToString
                TB_galileo.Text = .Item("opis").ToString
                PierwotnaIlosc = .Item("ilosc")
            End With
        End If
    End Sub
    Private Sub BT_pobierz_Click(sender As Object, e As EventArgs) Handles BT_pobierz.Click
        If Sprawdzaj() = False Then
            Exit Sub
        End If

        Try
            OpenMagConnection()
        Catch
            PokazBlad()
            Exit Sub
        End Try

        SqlString = "SELECT * FROM MP WHERE MpID=" & MpID
        ds = New DataSet
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MP")
        If ds.Tables("MP").Rows.Count > 0 Then
            dr = ds.Tables("MP").Rows(0)
            KodMP = dr.Item("KodMP")
            PobieranaIlosc = TB_ilosc.Text
            PierwotnaIlosc = dr.Item("ilosc")
            l_mod = CInt(dr.Item("l_mod"))
            uwagi_mod = CB_uwagi_mod.Text
        Else
            Exit Sub
        End If

        If PobieranaIlosc > PierwotnaIlosc Then
            MsgBox("Chcesz pobrać więcej niż jest na regale!", vbCritical)
            Exit Sub
        End If

        'Aktualizacja MP
        With dr
            If PierwotnaIlosc = PobieranaIlosc Then
                .Delete()
            Else
                .Item("ilosc") = PierwotnaIlosc - PobieranaIlosc
                .Item("data_modyfikacji") = Now.ToString(FormatDaty)
                .Item("l_mod") = l_mod + 1
            End If
        End With
        da.Update(ds, "MP")

        'Aktualizacja MP_ruchy
        SqlString = "SELECT * FROM MP_ruchy"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MP_ruchy")
        dNewRow = ds.Tables("MP_ruchy").NewRow()

        With dNewRow
            .Item("data") = Now.ToString(FormatDaty)
            .Item("akcja") = "Pobrano"
            .Item("KodMP") = TB_kod.Text
            .Item("opis_gal") = TB_galileo.Text
            .Item("regal") = TB_regal.Text
            .Item("ilosc") = PobieranaIlosc
            .Item("lotto") = TB_lotto.Text
            .Item("lotto_prod") = TB_lotto_prod.Text
            If CB_stan.Checked = True Then
                .Item("stan") = "ok"
            End If
            .Item("uwagi") = TB_uwagi.Text
            If uwagi_mod <> "" Then
                .Item("uwagi_mod") = uwagi_mod & " | Zmieniono ilość z " & PierwotnaIlosc & " na " & PierwotnaIlosc - PobieranaIlosc
            Else
                .Item("uwagi_mod") = "Zmieniono ilość z " & PierwotnaIlosc & " na " & PierwotnaIlosc - PobieranaIlosc
            End If
            .Item("nr_mod") = l_mod + 1
            .Item("uzytkownik") = PCuser
            .Item("MpID") = MpID
        End With

        ds.Tables("MP_ruchy").Rows.Add(dNewRow)
        da.Update(ds, "MP_ruchy")
        MagDbCon.Close()

        MsgBox("Pobrano " & KodMP & vbNewLine & vbNewLine & "Poprzednia ilość: " & PierwotnaIlosc & vbNewLine & "Pobrano: " & PobieranaIlosc & vbNewLine & "Pozostało: " & PierwotnaIlosc - PobieranaIlosc, vbInformation)
        TB_clear(Me)
        CB_clear(Me)
        TB_kod.Select()
        AktualizujMPDGV()
        kod = ""
        MpID = 0
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
        If TB_ilosc.Text <= 0 Then
            MsgBox("Podaj poprawną ilość", vbCritical)
            TB_ilosc.Select()
            status = False
            Return status
        End If
        If TB_lotto_prod.Text <> "" Then
            If Not (IsNumeric(TB_lotto_prod.Text) And Len(TB_lotto_prod.Text) = 8) Then
                MsgBox("Podaj poprawny numer lotto składający się z 8 cyfr", vbCritical)
                TB_lotto.Select()
                status = False
                Return status
            End If
        End If
        Return status
    End Function
    Private Sub BT_max_Click(sender As Object, e As EventArgs) Handles BT_max.Click
        TB_ilosc.Text = PierwotnaIlosc
    End Sub
    Private Sub MG_pobierz_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BT_kody_Click(sender As Object, e As EventArgs) Handles BT_kody.Click
        Kody.Show()
    End Sub
End Class