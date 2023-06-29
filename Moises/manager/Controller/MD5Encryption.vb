Imports System.Security.Cryptography
Imports System.Text

Module MD5Encryption
    Function MD5Password(ByVal password As String) As String
        Dim md5 As MD5 = System.Security.Cryptography.MD5.Create()
        Dim inputBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(password)
        Dim hash As Byte() = md5.ComputeHash(inputBytes)
        Dim sb As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            sb.Append(hash(i).ToString("x2"))
        Next
        'change this later; looks like it's working now :)) haha
        Dim id As String = sb.ToString
        Return id
    End Function
    Function HashPassword(ByVal Password As String, ByVal Salt As String) As String
        Dim pwd As String = Password & Salt
        Dim hasher As New Security.Cryptography.SHA256Managed()
        Dim pwdb As Byte() = System.Text.Encoding.UTF8.GetBytes(pwd)
        Dim pwdh As Byte() = hasher.ComputeHash(pwdb)
        Return Convert.ToBase64String(pwdh)
    End Function

End Module