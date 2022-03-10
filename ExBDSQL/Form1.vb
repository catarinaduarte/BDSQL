Public Class Form1
    Private Sub RHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RHBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Prog07DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Prog07DataSet.RH' table. You can move, or remove it, as needed.
        Me.RHTableAdapter.Fill(Me.Prog07DataSet.RH)

    End Sub

    Private Sub DepartamentoTextBox_TextChanged(sender As Object, e As EventArgs) Handles DepartamentoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

End Class
