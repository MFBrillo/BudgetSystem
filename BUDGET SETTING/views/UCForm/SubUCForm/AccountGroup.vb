Public Class AccountGroup
    Public AssetDT As DataTable
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        Dim columns = "Asset 'ACCOUNT GROUP',Description 'DESCRIPTION'"
        Dim table = "vi_moises_assets"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"ID"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub
    Private Sub AccountGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub


End Class
