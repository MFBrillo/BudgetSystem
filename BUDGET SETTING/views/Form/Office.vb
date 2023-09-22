
Public Class Office
    Public OfficeDT As DataTable
    Public VIOfficeDT As DataTable
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        VIOfficeDT = SqlLoad.MySql_SelectString("*", "vi_moises_offices")

    End Sub
    Private Sub Office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        DataGridView1.DataSource = SqlLoad.MySql_SelectString("*", "vi_moises_offices")
        Dim cols() = {"ID"}
        Datagrid_HideColumn(DataGridView1, cols)
        Custom_Load()
        Header_Accounts()
    End Sub
    Private Sub Header_Accounts()
        DataGridView1.Columns("TYPE").Width = 80
        DataGridView1.Columns("BUDGET CODE").Width = 120
        DataGridView1.Columns("ACCT. CODE").Width = 150
        DataGridView1.Columns("ACCRONYM").Width = 120
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Addbtn.Click

        AddOffice.Saveupdate = 1
        AddOffice.title = "Add Office"
        OpaquePrompt.Show()
        AddOffice.ShowDialog()
    End Sub

    Private Sub Searchtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Searchtxt.OnValueChanged
        ClearDGV(DataGridView1)

        Try
            If VIOfficeDT IsNot Nothing Then
                Dim conditions As New List(Of LinQCondition) From {
            New LinQCondition With {
                            .Column = "NAME",
                            .Value = Searchtxt.Text,
                            .ComparisonType = ComparisonTypeEnum.Like_enum}
        }
                Dim filterdata = Linq_Query(VIOfficeDT, conditions)
                DataGridView1.DataSource = filterdata
                officeid = filterdata.Rows(0).Item("ID").ToString
                AddOffice.officeid = officeid
                Header_Accounts()

            End If
            Dim cols() = {"ID"}
            Datagrid_HideColumn(DataGridView1, cols)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Searchtxt_TextChanged(sender As Object, e As EventArgs) Handles Searchtxt.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public officename
    Public officeid
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim searchrow As String
        searchrow = DataGridView1.Rows(e.RowIndex).Cells("NAME").Value.ToString()
        Custom_Load()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "NAME",
                             .Value = searchrow,
                             .ComparisonType = ComparisonTypeEnum.Equal_enum}
     }
        Dim accountname As DataTable = Linq_Query(VIOfficeDT, conditions)
        officename = accountname.Rows(0).Item("NAME").ToString
        officeid = accountname.Rows(0).Item("ID").ToString
        AddOffice.officeid = officeid
        AddOffice.Saveupdate = 2
        AddOffice.title = "Update Office"
        OpaquePrompt.Show()
        AddOffice.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Editbtn.Click

        AddOffice.Saveupdate = 2
        AddOffice.title = "Update Office"
        OpaquePrompt.Show()
        AddOffice.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim searchrow As String
        searchrow = DataGridView1.Rows(e.RowIndex).Cells("NAME").Value.ToString()
        Custom_Load()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "NAME",
                             .Value = searchrow,
                             .ComparisonType = ComparisonTypeEnum.Equal_enum}
     }
        Dim accountname As DataTable = Linq_Query(VIOfficeDT, conditions)
        officename = accountname.Rows(0).Item("NAME").ToString
        officeid = accountname.Rows(0).Item("ID").ToString
        AddOffice.officeid = officeid

    End Sub
End Class