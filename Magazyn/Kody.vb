Imports System.ComponentModel
Imports System.Data.Odbc
Public Class Kody
    Dim kod As String
    Dim Sql As String
    Dim Sql1 As String
    Dim Sql2 As String
    Dim sql3 As String
    Private Sub DGV_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.ColumnHeaderMouseClick
        DGV.Rows.Clear()
        If TB_kod.Text = "" Then
            MsgBox("Podaj kod")
            Exit Sub
        Else
            kod = Trim(TB_kod.Text)
        End If
        Try
            If ZCPCon.State = ConnectionState.Closed Then
                ZCPCon.Open()
            End If
        Catch ex As Exception
            MsgBox("Brak połączenia z bazą danych Galileo!", vbCritical)
        End Try

        If CB_aktywne.Checked = True Then
            sql3 = " And MGART00F.STATMA =' '"
        Else
            sql3 = ""
        End If

        Sql1 = "SELECT MGART00F.CDARMA, MGART00F.DSARMA FROM AS400.MGART00F MGART00F WHERE "

        If e.ColumnIndex = 0 Then
            Sql2 = "MGART00F.CDARMA Like '%" & kod & "%'" & sql3 & "ORDER BY MGART00F.CDARMA"
        End If
        If e.ColumnIndex = 1 Then
            Sql2 = "MGART00F.DSARMA Like '%" & kod & "%'" & sql3 & "ORDER BY MGART00F.CDARMA"
        End If

        Sql = Sql1 & Sql2
        Dim da As New OdbcDataAdapter(Sql, ZCPCon)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                DGV.Rows.Add(New String() {dr.Item(0), dr.Item(1)})
            Next
        Else
            DGV.Rows.Add(New String() {"B/D", "B/D"})
        End If
    End Sub
    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex >= 0 Then
            My.Computer.Clipboard.SetText(Trim(DGV.Item(0, e.RowIndex).Value))
        End If
    End Sub
    Private Sub Kody_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ZCPCon.State = ConnectionState.Open Then
            ZCPCon.Close()
        End If
    End Sub
    Private Sub Kody_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class