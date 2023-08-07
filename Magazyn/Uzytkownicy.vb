Public Class Uzytkownicy
    Private Sub UZYTKOWNICYBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UZYTKOWNICYBindingNavigatorSaveItem.Click
        Try
            Validate()
            UZYTKOWNICYBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MagDbDataSet)
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try
        MsgBox("Dane zapisano pomyślnie", vbInformation)
    End Sub

    Private Sub Uzytkownicy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UZYTKOWNICYTableAdapter.Fill(Me.MagDbDataSet.UZYTKOWNICY)
    End Sub
End Class