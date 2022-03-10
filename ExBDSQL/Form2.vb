Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Prog07DataSet.RH' table. You can move, or remove it, as needed.
        Me.RHTableAdapter.Fill(Me.Prog07DataSet.RH)

    End Sub
End Class