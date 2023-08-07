Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.ComponentModel
Public Class DOS_dodaj
    Dim wynik_formuly As Single
    Private Sub TB_kod_LostFocus(sender As Object, e As EventArgs) Handles TB_kod.LostFocus
        Try
            If ZCPCon.State = ConnectionState.Closed Then
                ZCPCon.Open()
            End If
            Dim Sql As String = "SELECT MGART00F.DSARMA FROM AS400.MGART00F MGART00F 
                                 WHERE MGART00F.CDARMA='" & Trim(TB_kod.Text.ToUpper) & "'"
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

        SqlString = "Select * FROM DOSTAWY"
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        ds = New DataSet
        da.Fill(ds, "DOS")

        'dodawanie nowej pozycji
        dNewRow = ds.Tables("DOS").NewRow()
        With dNewRow
            If CB_MP.Checked = True Then
                .Item("KodZP") = "MP"
                .Item("wymiar") = TB_wymiar.Text.ToString
            Else
                .Item("KodZP") = TB_kod.Text.ToString
            End If
            .Item("opis") = TB_galileo.Text.ToString
            .Item("regal") = TB_regal.Text.ToString
            .Item("ilosc") = TB_ilosc.Text
            .Item("ilosc_pak") = TB_formula.Text.ToString
            .Item("lotto_prod") = TB_lotto_prod.Text.ToString
            .Item("lotto_nat") = TB_lotto_nat.Text.ToString

            .Item("uwagi") = TB_uwagi.Text.ToString
            .Item("data_dodania") = Now.ToString(FormatDaty)
        End With
        ds.Tables("DOS").Rows.Add(dNewRow)
        da.Update(ds, "DOS")
        MagDbCon.Close()

        MsgBox("Dodano nową dostawę" & vbNewLine & vbNewLine & "Kod: " & Trim(TB_kod.Text.ToUpper) _
               & vbNewLine & "Ilość: " & TB_ilosc.Text & vbNewLine & "Regał: " & TB_regal.Text, vbInformation)

        AktualizujDOSDGV()
        TB_clear(Me)
        TB_kod.Select()
    End Sub
    Function PoprawneDane() As Boolean
        Dim status As Boolean = True
        If TB_kod.Text = "" And CB_MP.Checked = False Then
            MsgBox("Podaj kod", vbCritical)
            TB_kod.Select()
            status = False
            Return status
        End If
        If CB_MP.Checked = True And TB_wymiar.Text = "" Then
            MsgBox("Podaj wymiar MP", vbCritical)
            TB_wymiar.Select()
            status = False
            Return status
        End If
        If TB_galileo.Text = "" And CB_MP.Checked = False Then
            MsgBox("Podałeś nieistniejący kod", vbCritical)
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
        If TB_formula.Text <> "" And wynik_formuly <> TB_ilosc.Text Then
            MsgBox("Wynik formuły nie jest spójny z ilością", vbCritical)
            status = False
            Return status
        End If
        Return status
    End Function
    Private Sub DOSdodaj_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
    Private Sub DOSdodaj_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ZCPCon.State = ConnectionState.Open Then
            ZCPCon.Close()
        End If
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

    Private Sub CB_MP_CheckedChanged(sender As Object, e As EventArgs) Handles CB_MP.CheckedChanged
        If CB_MP.Checked = True Then
            lblWymiar.Visible = True
            TB_wymiar.Visible = True
            TB_kod.Enabled = False
            TB_kod.Text = ""
            TB_galileo.Enabled = True
            TB_galileo.Text = ""
        Else
            lblWymiar.Visible = False
            TB_wymiar.Visible = False
            TB_kod.Enabled = True
            TB_galileo.Enabled = False
        End If
    End Sub
End Class