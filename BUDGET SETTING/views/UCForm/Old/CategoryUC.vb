Public Class CategoryUC
    Public CategoryDT As DataTable
    Private Sub CategoryUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadCategory()
    End Sub
    Sub Custom_LoadCategory()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "vi_category")
        DataGridView1.DataSource = CategoryDT
    End Sub

    Private Sub Searchtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Searchtxt.OnValueChanged
        Dim conditions As New List(Of LinQCondition) From {
       New LinQCondition With {
                             .Column = "category",
                             .Value = Searchtxt.Text,
                             .ComparisonType = ComparisonTypeEnum.Like_enum}
     }
        DataGridView1.DataSource = Linq_Query(CategoryDT, conditions)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
