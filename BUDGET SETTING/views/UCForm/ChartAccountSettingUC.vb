Public Class ChartAccountSettingUC
    Public AssetsDT As DataTable
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Public assetheader As Boolean
    Public categoryheader As Boolean
    Private Sub ChartAccountSettingUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadCategory()
        Custom_LoadAsset()
        DataGridView1.AllowUserToOrderColumns = False
    End Sub
    Sub Custom_LoadAsset()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
        DataGridView1.DataSource = AssetsDT
        Dim oldcolumns() = {"asset", "description"}
        Dim columns() = {"Asset Name", "Asset Description"}
        Dim cols() = {"id", "assetid", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_RenameColumn(DataGridView1, oldcolumns, columns)
    End Sub
    Sub Custom_LoadCategory()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category")
        DataGridView2.DataSource = CategoryDT
        Dim oldcolumns() = {"code", "category", "description"}
        Dim newcolumns() = {"Category Code", "Category Name", "Category Description"}
        Dim cols() = {"id", "assetid", "registryid", "logdate", "categoryid"}
        Datagrid_HideColumn(DataGridView2, cols)
        Datagrid_RenameColumn(DataGridView2, oldcolumns, newcolumns)
    End Sub
    Sub Custom_LoadSubcategory()
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")
        DataGridView3.DataSource = SubcategoryDT
        Dim oldcolumns() = {"code", "subcategory", "description"}
        Dim newcolumns() = {"Subcaterory Code", "Subcategory Name", "Subcategory Description"}
        Dim cols() = {"id", "categoryid", "assetid", "logdate", "subcategoryid"}
        Datagrid_HideColumn(DataGridView3, cols)
        Datagrid_RenameColumn(DataGridView3, oldcolumns, newcolumns)
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick




    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Dim categoryid As String
        categoryid = DataGridView2.Rows(e.RowIndex).Cells("categoryid").Value.ToString()
        Custom_LoadSubcategory()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "categoryid",
                             .Value = categoryid,
                             .ComparisonType = ComparisonTypeEnum.Equal_enum}
     }
        Dim subcategory = Linq_Query(SubcategoryDT, conditions)
        DataGridView3.DataSource = subcategory
    End Sub
    Sub assetupdate()
        Dim SqlLoad As New MySQLCore
        For Each row As DataRow In AssetsDT.Rows
            Dim cols As New Dictionary(Of String, String)
            cols("id") = $"'{row.Item("id").ToString}'"
            cols("assetid") = $"'{row.Item("assetid").ToString}'"
            cols("asset") = $"'{row.Item("asset").ToString}'"
            SqlLoad.MySql_ExecuteNonQueryString("gl_assets", cols, $"id={cols("id")}", 2)
        Next
    End Sub
    Sub categoryupdate()

        Dim SqlLoad As New MySQLCore
        For Each row As DataRow In CategoryDT.Rows
            Dim cols As New Dictionary(Of String, String)
            cols("id") = $"'{row.Item("id").ToString}'"
            'cols("category")=
            cols("code") = $"'{row.Item("code").ToString}'"
            cols("category") = $"'{row.Item("category").ToString}'"
            cols("description") = $"'{row.Item("description").ToString}'"

            Dim code = row.Item("code").ToString  ' Get the value from the "code" column
            Dim input As String = code
            Dim parts() As String = input.Split("-"c)  ' Split the value by the hyphen '-' delimiter

            If parts.Length >= 2 Then  ' Check if there are at least two parts
                Dim result As String = parts(1)  ' Assign the second part to the result variable
                'Label5.Text = result  ' Display the result in a Label control
                cols("categoryid") = result
            Else
                Console.WriteLine("Invalid input format.")
            End If

            SqlLoad.MySql_ExecuteNonQueryString("gl_assets_category", cols, $"id={cols("id")}", 2)
        Next
    End Sub
    Sub subcategoryupdate()
        Dim SqlLoad As New MySQLCore
        For Each row As DataRow In SubcategoryDT.Rows
            Dim cols As New Dictionary(Of String, String)
            cols("id") = $"'{row.Item("id").ToString}'"
            cols("code") = $"'{row.Item("code").ToString}'"
            cols("subcategory") = $"'{row.Item("subcategory").ToString}'"
            cols("description") = $"'{row.Item("description").ToString}'"

            Dim code As String = $"'{row.Item("code").ToString}'"
            Dim parts() As String = code.Split("-"c)

            If parts.Length >= 3 Then
                Dim result1 As String = parts(0) & parts(1) & parts(2)
                Dim result2 As String = result1.Substring(0, 3)
                cols("subcategoryid") = result1
                cols("categoryid") = result2
                'Label5.Text = result2
            End If
            SqlLoad.MySql_ExecuteNonQueryString("gl_assets_subcategory", cols, $"id={cols("id")}", 2)
        Next
    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        OpaquePrompt.Show()
        CustomYesNoPrompt("Save Entries", "Do you want to save changes")
        If YesNoPrompt.YesOption = True Then
            assetupdate()
            categoryupdate()
            subcategoryupdate()
        End If
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If assetheader = False Then
            Dim assetid As String
            assetid = DataGridView1.Rows(e.RowIndex).Cells("assetid").Value.ToString()
            Custom_LoadCategory()
            'Custom_LoadSubcategory()
            Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                .Column = "assetid",
                .Value = assetid,
                .ComparisonType = ComparisonTypeEnum.Equal_enum}
     }
            Dim category = Linq_Query(CategoryDT, conditions)
            DataGridView2.DataSource = category

            Try
                Dim categoryid As String
                categoryid = DataGridView2.Rows(e.RowIndex).Cells("categoryid").Value.ToString()
                Custom_LoadSubcategory()
                Dim conditions1 As New List(Of LinQCondition) From {
            New LinQCondition With {
                                 .Column = "categoryid",
                                 .Value = categoryid,
                                 .ComparisonType = ComparisonTypeEnum.Equal_enum}
         }
                Dim subcategory = Linq_Query(SubcategoryDT, conditions1)
                DataGridView3.DataSource = subcategory

            Catch ex As Exception
                ClearDGV(DataGridView3)
            End Try

        End If
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        ' Prevent sorting when header is clicked
        assetheader = True
    End Sub
End Class
