Imports System.Data.OleDb
Public Class MG_pobierz_pal
    Dim ile_pozycji As Integer
    Private Sub MG_przenies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If regal <> "" Then
            TB_regal.Text = regal
        End If
    End Sub
    Private Sub TB_regal_TextChanged(sender As Object, e As EventArgs) Handles TB_regal.TextChanged
        Dim Lista As ListViewItem
        Dim LVwpis(4) As String

        LV_lista.Items.Clear()
        regal = TB_regal.Text

        OpenMagConnection()
        dt = New DataTable
        da = New OleDbDataAdapter("SELECT * FROM MG WHERE regal ='" & regal & "'", MagDbCon)
        da.Fill(dt)
        MagDbCon.Close()

        ile_pozycji = dt.Rows.Count

        If ile_pozycji > 0 Then
            For i As Integer = 0 To ile_pozycji - 1
                With dt.Rows(i)
                    LVwpis(0) = .Item("MgID")
                    LVwpis(1) = .Item("KodZP").ToString
                    LVwpis(2) = .Item("ilosc").ToString
                    LVwpis(3) = .Item("lotto_prod").ToString
                    LVwpis(4) = .Item("lotto_nat").ToString
                    Lista = New ListViewItem(LVwpis)
                End With
                LV_lista.Items.Add(Lista)
            Next
        End If
    End Sub
    Private Sub BT_pobierz_Click(sender As Object, e As EventArgs) Handles BT_pobierz.Click
        Dim MG As DataRow
        Dim i As Integer = 0
        Dim uwagi_mod As String
        Dim l_mod As Integer

        regal = TB_regal.Text
        uwagi_mod = CB_uwagi_mod.Text

        If regal = "" Then
            MsgBox("Podaj regał", vbCritical)
            TB_regal.Select()
            Exit Sub
        End If

        'start połączenia
        Try
            OpenMagConnection()
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try

        ds = New DataSet
        'pobieranie danych z mag
        da = New OleDbDataAdapter("SELECT * FROM MG WHERE regal ='" & regal & "'", MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MG")

        'pobieranie danych z ruchy
        daR = New OleDbDataAdapter("SELECT * FROM MG_ruchy", MagDbCon)
        cbR = New OleDbCommandBuilder(daR)
        daR.Fill(ds, "MG_ruchy")
        MagDbCon.Close()

        'przypisanie wartości z magazynu
        ile_pozycji = ds.Tables("MG").Rows.Count

        If ile_pozycji < 1 Then
            MsgBox("Pdany regał jest pusty", vbCritical)
            Exit Sub
        End If

        For i = 0 To ile_pozycji - 1
            MG = ds.Tables("MG").Rows(i)
            With MG
                If .Item("l_mod").ToString = "" Then
                    l_mod = 0
                Else
                    l_mod = .Item("l_mod")
                End If
            End With

            'aktualizacja MG_ruchy
            dNewRow = ds.Tables("MG_ruchy").NewRow()
            With dNewRow
                .Item("KodZP") = MG.Item("KodZP").ToString
                .Item("opis_gal") = MG.Item("opis").ToString
                .Item("regal") = regal
                .Item("ilosc") = MG.Item("ilosc")
                .Item("lotto_prod") = MG.Item("lotto_prod").ToString
                .Item("lotto_nat") = MG.Item("lotto_nat").ToString
                .Item("data") = Now.ToString(FormatDaty)
                .Item("akcja") = "Pobrano paletę"
                .Item("nr_mod") = l_mod + 1
                .Item("uwagi") = MG.Item("uwagi").ToString
                If uwagi_mod <> "" Then
                    .Item("uwagi_mod") = uwagi_mod & " | Zmieniono ilość z " & MG.Item("ilosc") & " na " & 0
                Else
                    .Item("uwagi_mod") = "Zmieniono ilość z " & MG.Item("ilosc") & " na " & 0
                End If
                .Item("MgID") = MG.Item("MgID")
                .Item("uzytkownik") = PCuser
            End With
            ds.Tables("MG_ruchy").Rows.Add(dNewRow)

            'usuwanie wpisu MG
            ds.Tables("MG").Rows(i).Delete()
        Next
        da.Update(ds, "MG")
        daR.Update(ds, "MG_ruchy")
        MagDbCon.Close()

        MsgBox("Pobrano " & ile_pozycji & " poz. z regału " & regal, vbInformation)

        'czyść TB + ListView
        LV_lista.Items.Clear()
        TB_clear(Me)
        AktualizujMGDGV()
        TB_regal.Select()
    End Sub
    Private Sub MG_pal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class