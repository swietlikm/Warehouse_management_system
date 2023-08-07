Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class MP_edytuj
    Dim l_mod As Integer
    Private Sub MP_edytuj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenMagConnection()

            SqlString = "SELECT * FROM MP WHERE MpID =" & index
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            ds = New DataSet
            da.Fill(ds, "MP")
            dr = ds.Tables("MP").Rows(0)

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
            TB_id.Text = .Item("MpID")
            TB_kod.Text = .Item("KodMP").ToString
            TB_galileo.Text = .Item("opis").ToString
            TB_regal.Text = .Item("regal").ToString
            TB_ilosc.Text = .Item("ilosc").ToString
            TB_lotto.Text = .Item("lotto").ToString
            TB_uwagi.Text = .Item("uwagi").ToString
            CB_material.Text = .Item("material").ToString
            CB_przekroj.Text = .Item("przekroj").ToString
            TB_wymiar.Text = .Item("wymiar").ToString
            l_mod = .Item("l_mod").ToString
        End With
        Try
            SqlString = "SELECT oznaczenie FROM MATERIALY ORDER BY oznaczenie"
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            dt = New DataTable
            da.Fill(dt)
            MagDbCon.Close()
            If dt.Rows.Count > 0 Then
                Dim items = dt.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
                CB_material.Items.AddRange(items)
            End If
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try
        MagDbCon.Close()
    End Sub

    Private Sub BT_zmien_Click(sender As Object, e As EventArgs) Handles BT_zmien.Click
        If PoprawneDane() = False Then
            Exit Sub
        End If
        Try
            OpenMagConnection()
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try
        SqlString = "SELECT * FROM MP WHERE MpID =" & CInt(TB_id.Text)
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        ds = New DataSet
        da.Fill(ds, "MP")
        dr = ds.Tables("MP").Rows(0)

        'Test zmian
        With dr
            If .Item("KodMP").ToString = TB_kod.Text And .Item("opis").ToString = TB_galileo.Text And .Item("regal").ToString = TB_regal.Text And
                .Item("ilosc") = TB_ilosc.Text And .Item("lotto").ToString = TB_lotto.Text And .Item("uwagi").ToString = TB_uwagi.Text And
                .Item("material").ToString = CB_material.Text And .Item("przekroj").ToString = CB_przekroj.Text And .Item("wymiar").ToString = TB_wymiar.Text Then
                MsgBox("Nic nie zmieniłeś", vbCritical)
                Exit Sub
            End If
        End With

        With dr
            .Item("KodMP") = TB_kod.Text
            .Item("opis") = TB_galileo.Text
            .Item("regal") = TB_regal.Text
            .Item("ilosc") = TB_ilosc.Text

            .Item("lotto") = TB_lotto.Text

            .Item("material") = CB_material.Text
            .Item("przekroj") = CB_przekroj.Text
            .Item("wymiar") = TB_wymiar.Text

            .Item("uwagi") = TB_uwagi.Text
            .Item("data_modyfikacji") = Now.ToString(FormatDaty)
            .Item("l_mod") = l_mod + 1
        End With
        da.Update(ds, "MP")

        SqlString = "SELECT * FROM MP_ruchy"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MP_ruchy")
        dNewRow = ds.Tables("MP_ruchy").NewRow()

        With dNewRow
            .Item("data") = Now.ToString(FormatDaty)
            .Item("akcja") = "Zmieniono wpis"
            .Item("KodMP") = TB_kod.Text
            .Item("opis_gal") = TB_galileo.Text
            .Item("regal") = TB_regal.Text
            .Item("ilosc") = TB_ilosc.Text
            .Item("lotto") = TB_lotto.Text
            .Item("uwagi") = TB_uwagi.Text
            .Item("uwagi_mod") = TB_uwagi_mod.Text
            .Item("nr_mod") = l_mod + 1
            .Item("uzytkownik") = PCuser
            .Item("MpID") = CInt(TB_id.Text)
        End With

        ds.Tables("MP_ruchy").Rows.Add(dNewRow)
        da.Update(ds, "MP_ruchy")
        MagDbCon.Close()

        MsgBox("Zmodyfikowano wpis kodu " & TB_kod.Text, vbInformation)
        AktualizujMPDGV()
        Close()

    End Sub
    Function PoprawneDane() As Boolean
        Dim status As Boolean = True

        If TB_kod.Text = "" Or Not TB_kod.Text.StartsWith("MP") Then
            MsgBox("Podaj kod MP", vbCritical)
            TB_kod.Select()
            status = False
            Return status
        End If
        If TB_galileo.Text = "" Then
            MsgBox("Podałeś nieistniejący kod MP", vbCritical)
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
        If Not (IsNumeric(TB_lotto.Text) And Len(TB_lotto.Text) = 9) Then
            MsgBox("Podaj poprawny numer lotto składający się z 9 cyfr", vbCritical)
            TB_lotto.Select()
            status = False
            Return status
        End If
        If CB_przekroj.Text <> "" Then
            If CB_przekroj.Text.ToUpper <> "D" And CB_przekroj.Text.ToUpper <> "E" And CB_przekroj.Text.ToUpper <> "Q" Then
                MsgBox("Podaj poprawny przekrój poprzeczny prętów", vbCritical)
                TB_lotto.Select()
                status = False
                Return status
            End If
        End If
        Return status
    End Function
    Private Sub MPdodaj_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
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
                                 WHERE MGART00F.CDARMA like 'MP%' and MGART00F.CDARMA='" & Trim(TB_kod.Text.ToUpper) & "'"
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
End Class