Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.ComponentModel
Public Class MG_dodaj
    Dim wynik_formuly As Single
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

    Private Sub BT_dodaj_Click(sender As Object, e As EventArgs) Handles BT_dodaj.Click

        If PoprawneDane() = False Then
            Exit Sub
        End If
        Try
            OpenMagConnection()
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try

        Dim odp As String
        odp = MsgBox("Kod: " & TB_kod.Text & vbNewLine & "Regał: " & TB_regal.Text & vbNewLine & "Ilość: " & TB_ilosc.Text &
                     vbNewLine & vbNewLine & "Lotto prod: " & TB_lotto_prod.Text & vbNewLine & "Lotto nat: " & TB_lotto_nat.Text, MsgBoxStyle.OkCancel, "Dodawanie nowej pozycji")
        If odp <> DialogResult.OK Then
            Exit Sub
        End If

        SqlString = "Select * FROM MG"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        ds = New DataSet
        da.Fill(ds, "MG")

        'dodawanie nowej pozycji MG
        dNewRow = ds.Tables("MG").NewRow()
        With dNewRow
            .Item("KodZP") = TB_kod.Text.ToString
            .Item("opis") = TB_galileo.Text.ToString
            .Item("regal") = TB_regal.Text.ToString
            .Item("ilosc") = TB_ilosc.Text
            .Item("ilosc_pak") = TB_formula.Text

            .Item("lotto_prod") = TB_lotto_prod.Text.ToString
            .Item("lotto_nat") = TB_lotto_nat.Text.ToString

            .Item("uwagi") = TB_uwagi.Text.ToString
            .Item("data_dodania") = Now.ToString(FormatDaty)
            .Item("l_mod") = 0
        End With
        ds.Tables("MG").Rows.Add(dNewRow)
        da.Update(ds, "MG")

        'pobieranie ID z nowej pozycji MG
        Dim id As Integer
        Dim identity = "SELECT @@IDENTITY"
        Dim cmd = New OleDbCommand(identity, MagDbCon)
        id = cmd.ExecuteScalar()

        'dodawanie nowego ruchu MG
        SqlString = "Select * FROM MG_Ruchy"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        da.Fill(ds, "MG_Ruchy")

        dNewRow = ds.Tables("MG_Ruchy").NewRow()
        With dNewRow
            .Item("KodZP") = Trim(TB_kod.Text.ToUpper)
            .Item("opis_gal") = TB_galileo.Text
            .Item("akcja") = "Dodano"
            .Item("data") = Now.ToString(FormatDaty)
            .Item("regal") = Trim(TB_regal.Text.ToUpper)
            .Item("ilosc") = TB_ilosc.Text
            .Item("lotto_prod") = TB_lotto_prod.Text
            .Item("lotto_nat") = TB_lotto_nat.Text
            .Item("nr_mod") = 0
            If CB_stan.Checked = True Then
                .Item("stan") = "ok"
            End If
            .Item("uwagi") = TB_uwagi.Text
            .Item("MgID") = id
            .Item("uzytkownik") = PCuser
        End With

        ds.Tables("MG_Ruchy").Rows.Add(dNewRow)
        da.Update(ds, "MG_Ruchy")

        'DOSTAWA
        If dostawa = True Then
            SqlString = "SELECT * FROM DOSTAWY WHERE ID =" & idDostawy
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            cb = New OleDbCommandBuilder(da)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Delete()
            Else
                MsgBox("Wpis dostawy nie istnieje", vbCritical)
            End If
            da.Update(dt)
        End If

        MagDbCon.Close()

        'MsgBox("Dodano nową pozycję na magazynie" & vbNewLine & vbNewLine & "Kod: " & Trim(TB_kod.Text.ToUpper) _
        '       & vbNewLine & "Ilość: " & TB_ilosc.Text & vbNewLine & "Regał: " & TB_regal.Text, vbInformation)

        AktualizujMGDGV()

        If dostawa = True Then
            dostawa = False
            AktualizujDOSDGV()
            Close()
        Else
            TB_clear(Me)
            CB_clear(Me)
            TB_kod.Select()
        End If
        dostawa = False
    End Sub
    Function PoprawneDane() As Boolean
        Dim status As Boolean = True
        If TB_kod.Text = "" Then
            MsgBox("Podaj kod", vbCritical)
            TB_kod.Select()
            status = False
            Return status
        End If
        If TB_kod.Text.StartsWith("MP") Then
            MsgBox("Chcesz dodać MP na Magazyn główny!", vbCritical)
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
        If TB_ilosc.Text <= 0 Then
            MsgBox("Podaj poprawną ilość", vbCritical)
            TB_ilosc.Select()
            status = False
            Return status
        End If
        If TB_formula.Text <> "" And wynik_formuly <> TB_ilosc.Text Then
            MsgBox("Formuła nie jest spójna z ilością", vbCritical)
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
        Return status
    End Function
    Private Sub MPdodaj_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub MPdodaj_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dostawa = False
        If ZCPCon.State = ConnectionState.Open Then
            ZCPCon.Close()
        End If
    End Sub

    Private Sub BT_kody_Click(sender As Object, e As EventArgs) Handles BT_kody.Click
        Kody.Show()
    End Sub
    Private Sub TB_kod_TextChanged(sender As Object, e As EventArgs) Handles TB_kod.TextChanged
        TB_galileo.Text = ""
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
                wynik_formuly = result
            Else
                TB_ilosc.Text = ""
                wynik_formuly = -1
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