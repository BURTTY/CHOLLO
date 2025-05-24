Public Class ADMIN_DASHBOARD

    Private Sub ADMIN_DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set password char for masking password input
        txtadpass.PasswordChar = "*"c
    End Sub

    ' Save user data
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            con()

            ' Format the DateTimePicker value as MM/dd/yyyy for Access
            Dim birthDateStr As String = dtpbirth.Value.ToString("MM/dd/yyyy")

            Dim sql As String
            sql = "INSERT INTO [tbl-adminregister] (Username, [Password], Email, Contact, FirstName, MiddleName, LastName, BirthDate, Address) " &
                  "VALUES ('" & txtaduser.Text & "','" & txtadpass.Text & "','" & txtademail.Text & "','" & txtadcon.Text & "','" &
                  txtadfirst.Text & "','" & txtadmid.Text & "','" & txtadlast.Text & "',#" & birthDateStr & "#,'" & txtadaddress.Text & "')"

            cn.Execute(sql)
            MsgBox("User saved successfully.", MsgBoxStyle.Information)
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Delete user by Username
    Private Sub btndele_Click(sender As Object, e As EventArgs) Handles btndele.Click
        Try
            con()
            Dim sql As String = "DELETE FROM [tbl-adminregister] WHERE Username='" & txtaduser.Text & "'"
            cn.Execute(sql)
            MsgBox("User deleted successfully.", MsgBoxStyle.Information)
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Exit the form
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    ' Clear all input fields
    Private Sub ClearFields()
        txtaduser.Clear()
        txtadpass.Clear()
        txtademail.Clear()
        txtadcon.Clear()
        txtadfirst.Clear()
        txtadmid.Clear()
        txtadlast.Clear()
        dtpbirth.Value = DateTime.Now  ' Reset DateTimePicker to today (or any default)
        txtadaddress.Clear()
    End Sub

End Class
