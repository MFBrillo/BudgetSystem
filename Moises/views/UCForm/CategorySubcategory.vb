Public Class CategorySubcategory
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Private Sub CategorySubcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")

        Dim columns1 = "registryid, assetid,categoryid, code, category, description"
        Dim columns2 = "assetid, categoryid, subcategoryid, code, subcategory, description"

        Dim table1 = "gl_assets_category"
        Dim table2 = "gl_assets_subcategory"

        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns1, table1)
        DataGridView2.DataSource = SqlLoad.MySql_SelectString(columns2, table2)

        Dim cols() = {"id", "logdate"}

        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub
End Class
