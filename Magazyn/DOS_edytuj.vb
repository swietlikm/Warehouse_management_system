Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class DOS_edytuj
    Private Sub MG_edytuj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenMagConnection()

            SqlString = "SELECT * FROM DOSTAWY WHERE ID =" & idDostawy
            da = New OleDbDataAdapter(SqlString, MagDbCon)
            ds = New DataSet
            da.Fill(ds, "DOSTAWY")
            MagDbCon.Close()
            dr = ds.Tables("DOSTAWY").Rows(0)
            If dr.Item("KodZP").ToString.StartsWith("MP") Then
                lblWymiar.Visible = True
                TB_wymiar.Visible = True
            End If
        Catch ex As Exception
            If Err.Number = 9 Then
                MsgBox("Wpis nie istnieje", vbCritical)
                AktualizujDOSDGV()
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
            TB_id.Text = .Item("ID").ToString
            TB_kod.Text = .Item("KodZP").ToString
            TB_galileo.Text = .Item("opis").ToString
            TB_regal.Text = .Item("regal").ToString

            TB_ilosc.Text = .Item("ilosc").ToString
            TB_ilosc_pak.Text = .Item("ilosc_pak").ToString
            TB_wymiar.Text = .Item("wymiar").ToString

            TB_lotto_prod.Text = .Item("lotto_prod").ToString
            TB_lotto_nat.Text = .Item("lotto_nat").ToString

            TB_uwagi.Text = .Item("uwagi").ToString
        End With
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
        SqlString = "SELECT * FROM DOSTAWY WHERE ID =" & CInt(TB_id.Text)
        da = New OleDbDataAdapter(SqlString, MagDbCon)
        cb = New OleDbCommandBuilder(da)
        ds = New DataSet
        da.Fill(ds, "DOSTAWY")
        dr = ds.Tables("DOSTAWY").Rows(0)

        With dr
            If CB_usun.Checked = True Then
                dr.Delete()
            Else
                .Item("KodZP") = TB_kod.Text
                .Item("opis") = TB_galileo.Text
                .Item("regal") = TB_regal.Text

                .Item("ilosc") = TB_ilosc.Text
                .Item("ilosc_pak") = TB_ilosc_pak.Text
                .Item("wymiar") = TB_wymiar.Text

                .Item("lotto_prod") = TB_lotto_prod.Text
                .Item("lotto_nat") = TB_lotto_nat.Text

                .Item("uwagi") = TB_uwagi.Text
            End If
        End With
        da.Update(ds, "DOSTAWY")
        MagDbCon.Close()

        If CB_usun.Checked = True Then
            MsgBox("Usunięto wpis", vbInformation)
        Else
            MsgBox("Zmodyfikowano wpis kodu " & TB_kod.Text, vbInformation)
        End If

        AktualizujDOSDGV()
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
    Private Sub DOS_DODAJ_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub BT_kody_Click(sender As Object, e As EventArgs) Handles BT_kody.Click
        Kody.Show()
    End Sub

    Private Sub CB_usun_CheckedChanged(sender As Object, e As EventArgs) Handles CB_usun.CheckedChanged
        If CB_usun.Checked = True Then
            TbEnabled(Me, False)
        Else
            TbEnabled(Me, True)
            TB_id.Enabled = False
            TB_galileo.Enabled = False
        End If
    End Sub
    Private Sub TB_kod_LostFocus(sender As Object, e As EventArgs) Handles TB_kod.LostFocus
        If TB_kod.Text <> "MP" Then
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
        End If
    End Sub
    Private Sub TB_ilosc_pak_TextChanged(sender As Object, e As EventArgs) Handles TB_ilosc_pak.TextChanged
        Try
            Dim equation As String = TB_ilosc_pak.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TB_ilosc.Text = result
        Catch ex As Exception
        End Try
    End Sub
End Class