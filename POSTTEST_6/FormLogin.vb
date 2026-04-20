Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "zulfikar" And txtPassword.Text = "020" Then
            MessageBox.Show("Login berhasil!")

            FormKelola.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username / Password salah!")
        End If
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class
