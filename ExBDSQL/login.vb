Public Class login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
   
        If txtNome.Text.Length <= 0 Then
            MessageBox.Show("Digite o seu nome de utilizador!")
        ElseIf txtPassword.Text.Length <= 0 Then
            MessageBox.Show("Digite a sua password!")
        End If
        
        Dim str As String = "Data Source=(localdb)\MSSQLLocalDB;Database=Prog07;Integrated Security=True" "
        
        Dim sql As String = "Select count(*) from utilizadores where Nome=@nome and Password=@password" 
        
        Using Conn As New SqlConnection(str)

         Using cmd As New SqlCommand(sql,Conn)
            cmd.Paameters.AddWhithValue.(@nome,txtNome.Text)
            cmd.Parameters.AddWithValue(@Password,txtText)
            Dim value= cmd.Executesclar()
            If Value >0 Then
                Message.Box.Show(login efecctuado com sucesso!)
                From1.Show()
            End if

    End Using
    End Using
End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

