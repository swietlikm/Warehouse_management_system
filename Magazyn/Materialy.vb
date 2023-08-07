Public Class Materialy
    Private Sub Materialy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MATERIALYTableAdapter.Fill(MagDbDataSet.MATERIALY)
    End Sub

    Private Sub MATERIALYBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MATERIALYBindingNavigatorSaveItem.Click
        Try
            Validate()
            MATERIALYBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MagDbDataSet)
        Catch ex As Exception
            PokazBlad()
            Exit Sub
        End Try
    End Sub
End Class