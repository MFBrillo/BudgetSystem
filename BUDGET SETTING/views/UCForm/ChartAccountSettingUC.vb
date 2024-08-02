Public Class ChartAccountSettingUC
    Public AssetsDT As DataTable
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Public assetheader As Boolean
    Public categoryheader As Boolean
    Private Sub ChartAccountSettingUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadAsset()
        Custom_LoadCategory()
        Custom_LoadSubcategory()
        DataGridView1.AllowUserToOrderColumns = False
        Dim myImage As Image = My.Resources.save
        Add_GridImageButton(DataGridView1, "Save", myImage, "ImgDGBtn1", 4, 100)
        Add_GridImageButton(DataGridView2, "Save", myImage, "ImgDGBtn2", 7, 100)
        Add_GridImageButton(DataGridView3, "Save", myImage, "ImgDGBtn3", 7, 100)
        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick
        AddHandler DataGridView2.CellContentClick, AddressOf DataGridView2_CellContentClick
        AddHandler DataGridView3.CellContentClick, AddressOf DataGridView3_CellContentClick

        Dim columns1() = {"description"}
        disable_datagridcol(DataGridView1, columns1)
        Dim columns2() = {"code"}
        disable_datagridcol(DataGridView2, columns2)
        Dim columns3() = {"code"}
        disable_datagridcol(DataGridView3, columns3)

    End Sub

    Sub disable_datagridcol(datagrid As DataGridView, cols() As String)
        For Each St As String In cols
            datagrid.Columns(St).ReadOnly = True
        Next
    End Sub
    Sub Custom_LoadAsset()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
        DataGridView1.DataSource = AssetsDT
        Dim oldcolumns() = {"asset", "description"}
        Dim columns() = {"Name", "Description"}
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
    Sub assetupdate()
        Dim SqlLoad As New MySQLCore
        For Each row As DataRow In AssetsDT.Rows
            Dim cols As New Dictionary(Of String, String)
            cols("id") = $"'{row.Item("id").ToString}'"
            cols("asset") = $"'{row.Item("asset").ToString}'"
            cols("description") = $"'{row.Item("description").ToString}'"
            SqlLoad.MySql_ExecuteNonQueryString("gl_assets", cols, $"id={cols("id")}", 2)
        Next
    End Sub
    Sub categoryupdate()
        Dim SqlLoad As New MySQLCore
        For Each row As DataRow In CategoryDT.Rows
            Dim cols As New Dictionary(Of String, String)
            cols("id") = $"'{row.Item("id").ToString}'"
            cols("assetid") = $"'{row.Item("assetid").ToString}'"
            cols("categoryid") = $"'{row.Item("categoryid").ToString}'"
            cols("code") = $"'{row.Item("code").ToString}'"
            cols("category") = $"'{row.Item("category").ToString}'"
            cols("description") = $"'{row.Item("description").ToString}'"
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
            SqlLoad.MySql_ExecuteNonQueryString("gl_assets_subcategory", cols, $"id={cols("id")}", 2)
        Next
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        ' Prevent sorting when header is clicked
        assetheader = True
    End Sub
    Public categoryid As String
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Dim mySql As New MySQLCore
        Custom_LoadSubcategory()
        categoryid = DataGridView2.Rows(e.RowIndex).Cells("categoryid").Value.ToString
        Try
            If SubcategoryDT.Rows.Count > 0 AndAlso e.RowIndex < DataGridView3.Rows.Count Then
                Dim conditions As New List(Of LinQCondition) From {
                    New LinQCondition With {
                        .Column = "categoryid",
                        .Value = categoryid,
                        .ComparisonType = ComparisonTypeEnum.Equal_enum
                    }
                }
                Dim subcategory = Linq_Query(SubcategoryDT, conditions)
                Dim subcategoryid = DataGridView3.Rows(e.RowIndex).Cells("subcategoryid").Value.ToString
                DataGridView3.DataSource = subcategory
            Else
                ClearDGV(DataGridView3)
            End If
        Catch ex As Exception
            ' Handle any exceptions here (e.g., show an error message or log the error)
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub
    Sub categoryfilter()
        Custom_LoadCategory()
        If CategoryDT.Rows.Count > 0 AndAlso DataGridView2.Rows.Count > 0 Then
            Dim conditions As New List(Of LinQCondition) From {
                New LinQCondition With {
                    .Column = "assetid",
                    .Value = assetid,
                    .ComparisonType = ComparisonTypeEnum.Equal_enum
                }
            }
            Dim category = Linq_Query(CategoryDT, conditions)
            If category.Rows.Count > 0 Then
                DataGridView2.DataSource = category
                categoryid = DataGridView2.Rows(0).Cells("categoryid").Value.ToString()
                Try
                    Custom_LoadSubcategory()
                    Dim conditions1 As New List(Of LinQCondition) From {
                        New LinQCondition With {
                            .Column = "categoryid",
                            .Value = categoryid,
                            .ComparisonType = ComparisonTypeEnum.Equal_enum
                        }
                    }
                    Dim subcategory = Linq_Query(SubcategoryDT, conditions1)
                    If subcategory.Rows.Count > 0 Then
                        DataGridView3.DataSource = subcategory
                    Else
                        ClearDGV(DataGridView3)
                    End If
                Catch ex As Exception
                    ClearDGV(DataGridView3)
                End Try
            End If
        End If
    End Sub
    Public assetid As String
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim mySql As New MySQLCore

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim columnName As String = DataGridView2.Columns(e.ColumnIndex).Name

            If columnName = "ImgDGBtn2" Then
                OpaquePrompt.Show()
                CustomYesNoPrompt("Update Data", "Do you want to Update Data")
                If YesNoPrompt.YesOption = True Then
                    Dim id As String = DataGridView2.Rows(e.RowIndex).Cells("id").Value.ToString
                    Dim category As String = DataGridView2.Rows(e.RowIndex).Cells("category").Value.ToString
                    Dim description As String = DataGridView2.Rows(e.RowIndex).Cells("description").Value.ToString
                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("id", id)
                    columnValues.Add("category", $"'{category}'")
                    columnValues.Add("description", $"'{description}'")
                    mySql.MySql_ExecuteNonQueryString("gl_assets_category", columnValues, $"id={id}", 2)

                    CustomMsg("Update ", "Update Successful")
                Else
                    Dim uc = New ChartAccountSettingUC
                    Form1.ShowUserControl(uc)
                End If
                Form1.Activate()
            End If

        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim mySql As New MySQLCore
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim columnName As String = DataGridView3.Columns(e.ColumnIndex).Name
            If columnName = "ImgDGBtn3" Then
                OpaquePrompt.Show()
                CustomYesNoPrompt("Update Data", "Do you want to Update Data")
                If YesNoPrompt.YesOption = True Then
                    Dim id As String = DataGridView3.Rows(e.RowIndex).Cells("id").Value.ToString

                    Dim subcategory As String = DataGridView3.Rows(e.RowIndex).Cells("subcategory").Value.ToString
                    Dim description As String = DataGridView3.Rows(e.RowIndex).Cells("description").Value.ToString

                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("id", id)
                    columnValues.Add("subcategory", $"'{subcategory}'")
                    columnValues.Add("description", $"'{description}'")
                    mySql.MySql_ExecuteNonQueryString("gl_assets_subcategory", columnValues, $"id={id}", 2)

                    CustomMsg("Update ", "Update Successful")
                Else
                    Dim uc = New ChartAccountSettingUC
                    Form1.ShowUserControl(uc)
                End If
                Form1.Activate()
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim mySql As New MySQLCore
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
            If columnName = "ImgDGBtn1" Then
                OpaquePrompt.Show()
                CustomYesNoPrompt("Update Data", "Do you want to Update Data")
                If YesNoPrompt.YesOption = True Then
                    Dim id As String = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString
                    assetid = DataGridView1.Rows(e.RowIndex).Cells("assetid").Value.ToString()
                    Dim asset As String = DataGridView1.Rows(e.RowIndex).Cells("asset").Value.ToString
                    Dim description As String = DataGridView1.Rows(e.RowIndex).Cells("description").Value.ToString

                    Dim columnValues As New Dictionary(Of String, String)

                    columnValues.Add("id", id)
                    columnValues.Add("assetid", assetid)
                    columnValues.Add("asset", $"'{asset}'")
                    columnValues.Add("description", $"'{description}'")
                    mySql.MySql_ExecuteNonQueryString("gl_assets", columnValues, $"id={id}", 2)

                    CustomMsg("Update ", "Update Successful")
                Else
                    Dim uc = New ChartAccountSettingUC
                    Form1.ShowUserControl(uc)
                End If
                Form1.Activate()
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If assetheader = False Then
            assetid = DataGridView1.Rows(e.RowIndex).Cells("assetid").Value.ToString()
            Dim asset = DataGridView1.Rows(e.RowIndex).Cells("asset").Value.ToString()
            Dim id = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()
            Dim description = DataGridView1.Rows(e.RowIndex).Cells("description").Value.ToString()
            categoryfilter()
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
