Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Logowanie
    Private Sub Logowanie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartAPPlog()
        AcceptButton = BT_podglad
    End Sub
    Private Sub TB_haslo_TextChanged(sender As Object, e As EventArgs) Handles TB_haslo.TextChanged
        If TB_haslo.Text <> vbNullString Then
            BT_edycja.Enabled = True
            AcceptButton = BT_edycja
        Else
            BT_edycja.Enabled = False
            AcceptButton = BT_podglad
        End If
    End Sub
    Private Sub BT_edycja_Click(sender As Object, e As EventArgs) Handles BT_edycja.Click
        If MagDbCon.State = ConnectionState.Closed Then
            Try
                MagDbCon.Open()
            Catch ex As Exception
                If Err.Number = 5 Then
                    MsgBox("Nie można odnaleźć bazy danych:" &
                           vbNewLine & FullDatabasePath, vbCritical)
                Else
                    MsgBox(ex.Message, vbCritical)
                End If
                Exit Sub
            End Try
        End If
        Dim cmd As New OleDbCommand("select count(*) from uzytkownicy where haslo=?", MagDbCon)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TB_haslo.Text
        Dim count = Convert.ToInt32(cmd.ExecuteScalar())
        If (count > 0) Then
            da = New OleDbDataAdapter("SELECT * FROM UZYTKOWNICY WHERE haslo ='" & TB_haslo.Text & "'", MagDbCon)
            dt = New DataTable
            da.Fill(dt)
            user = dt.Rows(0).Item(3)
            MagDbCon.Close()
            Magazyn.Show()
            Hide()
        Else
            MsgBox("Niepoprawne hasło!", vbCritical)
            TB_haslo.Select()
        End If
    End Sub
    Private Sub BT_podglad_Click(sender As Object, e As EventArgs) Handles BT_podglad.Click
        user = "Podgląd"
        Magazyn.Show()
        Hide()
    End Sub

    Private Sub Logowanie_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        StopAPPlog()
    End Sub
End Class
