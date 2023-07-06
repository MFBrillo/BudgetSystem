Public Class FundsSpecialFunds
    Public FundDT As DataTable
    Public FundDT1 As DataTable
    Public SpecialFundDT As DataTable
    Private Sub FundsSpecialFunds_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Custom_Load()
        Custom_ComboBoxDatasource(FundIDCBB, FundDT1, "fundname1", "fundname1")
        Header_Accounts()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        FundDT = SqlLoad.MySql_SelectString("*", "gl_funds")
        FundDT1 = SqlLoad.MySql_SelectString("*", "vi_funds")
        SpecialFundDT = SqlLoad.MySql_SelectString("*", "gl_spcfunds")
        Dim columns1 = "fundid 'Fund ID',fundcode 'Fund Code',fundname 'Fund Name'"
        Dim columns2 = "fundid 'Fund ID',spcfundid 'Special Fund ID',spcfunddescription 'Special Fund Description'"

        Dim table1 = "gl_funds"
        Dim table2 = "gl_spcfunds"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns1, table1)
        DataGridView2.DataSource = SqlLoad.MySql_SelectString(columns2, table2)
        Dim cols() = {"id", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub
    Private Sub Header_Accounts()

        DataGridView1.Columns("Fund ID").Width = 90
        DataGridView1.Columns("Fund Code").Width = 90
        DataGridView2.Columns("Fund ID").Width = 90
        DataGridView2.Columns("Special Fund ID").Width = 90


        ' DataGridView1.Columns("Fund Name").Width = 90

        'DataGridView1.Columns("Account Name").Width = 200
        'DataGridView1.Columns("Account Description").Width = 200
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddSpcFund.Click
        Dim inputText1 As String = FundIDCBB.Text
        Dim firstCharacter As String = ""

        If Not String.IsNullOrEmpty(inputText1) Then
            firstCharacter = inputText1.Substring(0, 1)
        End If

        Try
            Dim mySql As New MySQLCore
            Dim columnValues As New Dictionary(Of String, String)
            columnValues.Add("fundid", firstCharacter)
            columnValues.Add("spcfundid", SpecialFundIDtxt.Text)
            columnValues.Add("spcfunddescription", SpeicialFundtxt.Text)

            Dim dt = mySql.MySql_SelectString("spcfunddescription", "gl_spcfunds", $"WHERE spcfundid = '{SpecialFundIDtxt.Text}'")
            If dt.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_spcfunds", columnValues, Nothing, 1)
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Custom_Load()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddFundbtn.Click

        Dim mySql As New MySQLCore
        Try
            Dim columnValues As New Dictionary(Of String, String)
            columnValues.Add("fundid", FundIDtxt.Text)
            columnValues.Add("fundcode", FundCodetxt.Text)
            columnValues.Add("fundname", FundNametxt.Text)

            Dim dt = mySql.MySql_SelectString("fundname", "gl_funds", $"WHERE fundcode = '{FundCodetxt.Text}' OR fundname LIKE '%{FundNametxt.Text}%'")

            If dt.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_funds", columnValues, Nothing, 1)
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Custom_Load()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
