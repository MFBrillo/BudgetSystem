Public Class Verify
    Public AccountDT As DataTable
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
        OpaquePrompt.Close()
        Form1.Activate()
    End Sub
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts_temp")
        DataGridView1.DataSource = SqlLoad.MySql_SelectString("*", "vi_accounts_temp", Nothing,)
        Add_GridButton(DataGridView1, "Pending", "Approve", "ApproveDGBtn", 4, 100)
        Dim cols() = {"Verify"}
        Datagrid_HideColumn(DataGridView1, cols)
        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView_CellContentClick
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        OpaquePrompt.Show()
        CustomYesNoPrompt("Verifu Entries", "Do you want to Approve changes")
        If YesNoPrompt.YesOption = True Then

            If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("ApproveDGBtn").Index Then
                Dim SqlLoad As New MySQLCore
                AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts_temp")
                Dim row As DataRow = AccountDT.Rows(e.RowIndex)
                Dim assetid As Integer = row.Item("assetid").ToString
                Dim categoryid As Integer = row.Item("categoryid").ToString
                Dim subcategoryid As Integer = row.Item("subcategoryid").ToString
                Dim accountid As Integer = row.Item("accountid").ToString
                Dim accounctcode As String = row.Item("accountcode").ToString
                Dim accountname As String = row.Item("accountname").ToString
                Dim accountdescription As String = row.Item("accountdescription").ToString

                Try
                    Dim mySql As New MySQLCore
                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("assetid", assetid)
                    columnValues.Add("categoryid", categoryid)
                    columnValues.Add("subcategoryid", subcategoryid)
                    columnValues.Add("accountname", accountname)
                    columnValues.Add("accountid", accountid)
                    columnValues.Add("accountdescription", accountdescription)
                    columnValues.Add("accountcode", accounctcode)
                    mySql.MySql_ExecuteNonQueryString("gl_accounts", columnValues, Nothing, 1)

                    mySql.MySql_Delete("gl_accounts_temp", $"accountid= {accountid}")
                Catch ex As Exception
                    MsgBox("ERROR" & ex.Message)
                End Try


            End If


        End If
        Form1.Activate()
    End Sub
    Private Sub Verify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class