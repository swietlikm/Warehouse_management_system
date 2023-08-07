Imports System.Data.OleDb
Public Class MP_przenies
    Dim MpID As Integer
    Dim KodMP As String
    Dim l_mod As Integer
    Dim uwagi_mod As String

    Dim StaryRegal As String
    Dim NowyRegal As String
    Private Sub MP_pobierz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kod <> "" Then
            MpID = index
            TB_kod.Text = kod
        End If
    End Sub
    Private Sub TB_kod_TextChanged(sender As Object, e As EventArgs) Handles TB_kod.TextChanged
        StaryRegal = ""
        NowyRegal = ""
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
                StaryRegal = .Item("regal").ToString
                TB_lotto.Text = .Item("lotto").ToString
                TB_uwagi.Text = .Item("uwagi").ToString
                TB_galileo.Text = .Item("opis").ToString
                TB_ilosc.Text = .Item("ilosc")
            End With
        End If
    End Sub
    Private Sub BT_inwentaryzacja_Click(sender As Object, e As EventArgs) Handles BT_przenies.Click
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
            NowyRegal = TB_regal.Text
            StaryRegal = dr.Item("regal")
            uwagi_mod = CB_uwagi_mod.Text
        Else
            Exit Sub
        End If

        If NowyRegal = StaryRegal Then
            MsgBox("Podałeś ten sam regał", vbCritical)
            Exit Sub
        End If

        'Aktualizacja MP
        With dr
            KodMP = .Item("KodMP")
            l_mod = CInt(.Item("l_mod"))
            .Item("regal") = NowyRegal
            .Item("data_modyfikacji") = Now.ToString(FormatDaty)
            .Item("l_mod") = l_mod + 1
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
            .Item("akcja") = "Przeniesiono"
            .Item("KodMP") = TB_kod.Text
            .Item("opis_gal") = TB_galileo.Text
            .Item("regal") = NowyRegal
            .Item("ilosc") = TB_ilosc.Text
            .Item("lotto") = TB_lotto.Text
            .Item("uwagi") = TB_uwagi.Text
            If uwagi_mod <> "" Then
                .Item("uwagi_mod") = uwagi_mod & " | Przeniesiono z " & StaryRegal & " na " & NowyRegal
            Else
                .Item("uwagi_mod") = "Przeniesiono z " & StaryRegal & " na " & NowyRegal
            End If
            .Item("nr_mod") = l_mod + 1
            .Item("uzytkownik") = PCuser
            .Item("MpID") = MpID
        End With

        ds.Tables("MP_ruchy").Rows.Add(dNewRow)
        da.Update(ds, "MP_ruchy")
        MagDbCon.Close()

        MsgBox("Przeniesino " & KodMP & vbNewLine & vbNewLine & "Nowy regał: " & NowyRegal, vbInformation)
        TB_clear(Me)
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
        If TB_regal.Text = "" Then
            MsgBox("Podaj regał", vbCritical)
            TB_regal.Select()
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
End Class