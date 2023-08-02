Public Class ChartAccountSettingUC
    Public AssetsDT As DataTable
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Private Sub ChartAccountSettingUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadSubcategory()
        Custom_LoadCategory()
        Custom_LoadAsset()
        Header_Accounts()
    End Sub
    Sub Custom_LoadAsset()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "vi_assets")
        DataGridView1.DataSource = AssetsDT
        Dim columns = "id 'ID',assetname 'ASSET NAME'"
        Dim table = "vi_assets"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"assetid", "assetdescription"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub
    Private Sub Header_Accounts()
        DataGridView1.Columns("ID").Width = 90
    End Sub
    Sub Custom_LoadCategory()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "vi_category")
        DataGridView2.DataSource = CategoryDT
        Dim columns = "*"
        Dim table = "vi_category"
        DataGridView2.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"assetid"}
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub
    Sub Custom_LoadSubcategory()
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "vi_subcategory")
        DataGridView3.DataSource = SubcategoryDT
        Dim columns = "*"
        Dim table = "vi_subcategory"
        DataGridView3.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"categoryid"}
        Datagrid_HideColumn(DataGridView3, cols)
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim assetid As String
        assetid = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()
        Custom_LoadCategory()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "assetid",
                             .Value = assetid,
                             .ComparisonType = ComparisonTypeEnum.Like_enum}
     }
        DataGridView2.DataSource = Linq_Query(CategoryDT, conditions)

    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim categoryid As String
        categoryid = DataGridView2.Rows(e.RowIndex).Cells("categoryid").Value.ToString()
        Custom_LoadSubcategory()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "categoryid",
                             .Value = categoryid,
                             .ComparisonType = ComparisonTypeEnum.Like_enum}
     }
        DataGridView3.DataSource = Linq_Query(SubcategoryDT, conditions)
    End Sub
End Class
