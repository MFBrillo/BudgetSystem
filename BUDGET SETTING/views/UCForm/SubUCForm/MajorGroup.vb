Public Class MajorGroup


    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        Dim columns = "assetid 'ACCOUNT GROUP ID',categoryid 'MAJOR GOURP ID' ,category 'MAJOR GROUP'"
        Dim table = "vi_moises_category"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"id"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub
    Private Sub MajorGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub
End Class
