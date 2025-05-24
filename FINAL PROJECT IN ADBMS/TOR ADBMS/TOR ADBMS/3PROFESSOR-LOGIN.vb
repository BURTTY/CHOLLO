Public Class _3PROFESSOR_LOGIN

    Private Sub _3PROFESSOR_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Initialize form controls here if needed
    End Sub

    Private Sub btnproflogin_Click(sender As Object, e As EventArgs) Handles btnproflogin.Click
        Try
            Call con() ' Connect to database

            Dim username As String = txtprofuser.Text.Trim()
            Dim password As String = txtprofpass.Text.Trim()

            Dim sql As String = "SELECT * FROM [tbl-adminregister] WHERE Username = '" & username & "' AND [Password] = '" & password & "'"

            rs = New ADODB.Recordset
            rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                MsgBox("Login successful. Welcome, " & rs.Fields("FirstName").Value & "!", MsgBoxStyle.Information)
                Me.Hide()

                ' Open PROFESSOR_DASHBOARD form
                Dim dash As New PROFESSOR_DASHBOARD()
                dash.Show()

            Else
                MsgBox("Invalid username or password.", MsgBoxStyle.Exclamation)
            End If

            rs.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
