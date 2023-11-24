Public Class EditAccounts
    Public AccountDT As DataTable
    Dim accountid = ChartofAccounts.accountid2
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
    End Sub

    Private Sub EditAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        IDlbl.Text = accountid
    End Sub
End Class