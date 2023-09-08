Public Class AccountDescription
    Public AccountDT As DataTable
    Dim assetid
    Dim categoryid
    Dim subcategoryid
    Dim accountid
    Dim accountcode = ChartofAccounts.accountcode2

    Public findaccountDT As DataTable

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
    End Sub
    Private Sub AccountDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        Nametxt.Text = ChartofAccounts.accountdescription2
        'Codetxt.Text = ChartofAccounts.accountcode
        Dim input As String = ChartofAccounts.accountcode2
        ' Remove hyphens from the input
        Dim result As String = input.Replace("-", "")
        accountid = result

        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                            .Column = "accountid",
                            .Value = result,
                            .ComparisonType = ComparisonTypeEnum.Equal_enum}
        }
        Dim accountname As DataTable = Linq_Query(AccountDT, conditions)
        assetid = accountname.Rows(0).Item("assetid").ToString
        subcategoryid = accountname.Rows(0).Item("subcategoryid").ToString
        categoryid = accountname.Rows(0).Item("categoryid").ToString
        accountid = accountname.Rows(0).Item("accountid").ToString


    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Dim SqlLoad As New MySQLCore
        CustomYesNoPrompt("Save Entries", "Do you want to save changes")
        If YesNoPrompt.YesOption = True Then
            If Descriptiontxt.Text = "" And Nametxt.Text = "" Then
                CustomMsg("Save Record Failed", "Account Name and Account Description are Empty.", "OK")
            ElseIf Descriptiontxt.Text = "" Then
                CustomMsg("Save Record Failed", "Account Name is Empty.", "OK")
            ElseIf Nametxt.Text = "" Then
                CustomMsg("Save Record Failed", "Account Description is Empty.", "OK")
            Else
                Dim mySql As New MySQLCore
                Dim columnValues As New Dictionary(Of String, String)
                columnValues.Add("assetid", assetid)
                columnValues.Add("categoryid", categoryid)
                columnValues.Add("subcategoryid", subcategoryid)
                columnValues.Add("accountid", accountid)
                columnValues.Add("accountcode", accountcode)
                columnValues.Add("accountname", Nametxt.Text)
                columnValues.Add("accountdescription", Descriptiontxt.Text)
                mySql.MySql_ExecuteNonQueryString("gl_accounts", columnValues, Nothing, 1)
            End If
            Form1.Activate()
            Me.Close()
        Else
            OpaquePrompt.Close()
            Me.Close()
            Form1.Activate()
        End If
    End Sub
End Class