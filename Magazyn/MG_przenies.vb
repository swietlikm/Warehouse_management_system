Imports System.Data.OleDb
Public Class MG_przenies
    Dim MgID As Integer
    Dim KodZP As String
    Dim l_mod As Integer
    Dim uwagi_mod As String

    Dim StaryRegal As String
    Dim NowyRegal As String
    Private Sub MG_pobierz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kod <> "" Then
            MgID = index
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
                StaryRegal = .Item("regal").ToString
                TB_lotto_prod.Text = .Item("lotto_prod").ToString
                TB_lotto_nat.Text = .Item("lotto_nat").ToString
                TB_uwagi.Text = .Item("uwagi").ToString
                TB_galileo.Text = .Item("opis").ToString
                TB_ilosc.Text = .Item("ilosc")
                TB_ilosc_pak.Text = .Item("ilosc_pak").ToString
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

        SqlString = "SELECT * FROM MG WHERE MgID=" & MgID
        ds = New DataSet
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MG")
        If ds.Tables("MG").Rows.Count > 0 Then
            dr = ds.Tables("MG").Rows(0)
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

        'Aktualizacja MG
        With dr
            KodZP = .Item("KodZP")
            l_mod = CInt(.Item("l_mod"))
            .Item("regal") = NowyRegal
            .Item("data_modyfikacji") = Now.ToString(FormatDaty)
            .Item("l_mod") = l_mod + 1
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
            .Item("akcja") = "Przeniesiono"
            .Item("KodZP") = TB_kod.Text
            .Item("opis_gal") = TB_galileo.Text
            .Item("regal") = NowyRegal
            .Item("ilosc") = TB_ilosc.Text
            .Item("lotto_prod") = TB_lotto_prod.Text
            .Item("lotto_nat") = TB_lotto_nat.Text
            .Item("uwagi") = TB_uwagi.Text
            If uwagi_mod <> "" Then
                .Item("uwagi_mod") = uwagi_mod & " | Przeniesiono z " & StaryRegal & " na " & NowyRegal
            Else
                .Item("uwagi_mod") = "Przeniesiono z " & StaryRegal & " na " & NowyRegal
            End If
            .Item("nr_mod") = l_mod + 1
            .Item("uzytkownik") = PCuser
            .Item("MgID") = MgID
        End With

        ds.Tables("MG_ruchy").Rows.Add(dNewRow)
        da.Update(ds, "MG_ruchy")
        MagDbCon.Close()

        MsgBox("Przeniesino " & KodZP & vbNewLine & vbNewLine & "Nowy regał: " & NowyRegal, vbInformation)
        TB_clear(Me)
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