Public Class SubcategoryUC
    Public SubcategoryDT As DataTable
    Sub Custom_LoadCategory()
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")
        Dim columns = "assetid 'ASSET ID',asset 'ASSET NAME',description 'ASSET DESCRIPTION'"
        Dim table = "gl_assets"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"id", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub SubcategoryUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
