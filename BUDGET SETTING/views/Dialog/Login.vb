Public Class Login

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        ' Get the username and password from the user input
        Dim username As String = Usernametxt.Text
        Dim password As String = Passwordtxt.Text

        ' You might want to retrieve the salt associated with the user from a database
        Dim salt As String = "unique_salt_for_user"

        ' Hash the password using MD5
        Dim hashedMD5Password As String = MD5Encryption.MD5Password(password)

        ' Hash the password using SHA-256 with the provided salt
        Dim hashedPasswordWithSalt As String = MD5Encryption.HashPassword(password, salt)

        ' Now you can use these hashed values for authentication or storage
        ' Compare the hashed password with the stored hashed password in your database

        ' For example:
        If CheckCredentials(username, hashedMD5Password) Then
            ' Successful login
            CustomMsg("Login", "Successful Login!", "Procced")
            Form1.is_login = True
            Form1.isLoginPanel.Enabled = True
            OpaquePrompt.Dispose()
            Me.Close()
        Else
            CustomMsg("Invalid", "Invalid Username or Password", "Close")
            placeholder()
        End If
    End Sub
    Private Function CheckCredentials(username As String, hashedPassword As String) As Boolean
        Dim mySql As New MySQLCore
        Dim columns As String = "username, hashpassword"
        Dim tablename As String = "gl_users"

        ' Build the WHERE clause
        Dim whereclause As String = $"WHERE username = '{username}' AND hashpassword = '{hashedPassword}' AND (officeid = 29 OR accesslevel BETWEEN 1 AND 2)"

        ' Call the MySql_SelectString function to execute the query
        Dim resultTable As DataTable = mySql.MySql_SelectString(columns, tablename, Nothing, whereclause)

        ' Check if any rows were returned
        If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
            ' Credentials are valid
            Return True
        Else
            ' Credentials are invalid
            Return False
        End If
    End Function
    Public Sub placeholder()
        Usernametxt.Text = "Username"
        Usernametxt.ForeColor = Color.Gray ' Change text color if needed
        Passwordtxt.Text = "Password"
        Passwordtxt.ForeColor = Color.Gray ' Change text color if needed
        Usernametxt.Focus()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        placeholder()
        OpaquePrompt.Show()
    End Sub
    Private Sub Usernametxt_GotFocus(sender As Object, e As EventArgs) Handles Usernametxt.GotFocus
        If Usernametxt.Text = "Username" Then
            Usernametxt.Text = ""
            'Usernametxt.ForeColor = Color.Gray ' Change text color if needed
            Usernametxt.ForeColor = Color.FromArgb(60, 60, 60) ' Change text color if needed
        End If
    End Sub
    Private Sub Usernametxt_LostFocus(sender As Object, e As EventArgs) Handles Usernametxt.LostFocus
        If String.IsNullOrWhiteSpace(Usernametxt.Text) Then
            Usernametxt.Text = "Username"
            Usernametxt.ForeColor = Color.Gray ' Change text color if needed
        End If
    End Sub
    Private Sub Passwordtxt_LostFocus(sender As Object, e As EventArgs) Handles Passwordtxt.LostFocus
        If String.IsNullOrWhiteSpace(Passwordtxt.Text) Then
            Passwordtxt.Text = "Password"
            Passwordtxt.ForeColor = Color.Gray ' Change text color if needed
        End If
    End Sub
    Private Sub Passwordtxt_TextChanged(sender As Object, e As EventArgs) Handles Passwordtxt.TextChanged
        If Passwordtxt.Text = "" Then
            Passwordtxt.UseSystemPasswordChar = False
        Else
            Passwordtxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Passwordtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Passwordtxt.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Prevent the "ding" sound
            e.Handled = True

            ' Trigger the Click event of the OK button
            Loginbtn.PerformClick()
        End If
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        ConnectionForm.ShowDialog()
    End Sub

    Private Sub Closebtn_Click_1(sender As Object, e As EventArgs) Handles Closebtn.Click
        End
    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        ConnectionForm.ShowDialog()
    End Sub
End Class