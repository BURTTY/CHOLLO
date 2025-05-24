Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: focus on username when form loads
        txtadminuser.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnadminlogin.Click
        Dim username As String = txtadminuser.Text
        Dim password As String = txtadminpass.Text

        If username = "admin" And password = "admin123" Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form4 As New ADMIN_DASHBOARD()
            form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtadminuser.Clear()
            txtadminpass.Clear()
            txtadminuser.Focus()
        End If
    End Sub
End Class
