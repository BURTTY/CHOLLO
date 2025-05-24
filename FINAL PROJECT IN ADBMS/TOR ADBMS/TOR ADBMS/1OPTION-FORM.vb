Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Any code when Form1 loads
    End Sub

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        OpenForm("admin")
    End Sub

    Private Sub btnprofessor_Click(sender As Object, e As EventArgs) Handles btnprofessor.Click
        OpenForm("professor")
    End Sub

    Private Sub OpenForm(role As String)
        If role = "admin" Then
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
        ElseIf role = "professor" Then
            Dim form3 As New _3PROFESSOR_LOGIN()
            form3.Show()
            Me.Hide()
        End If
    End Sub
End Class
