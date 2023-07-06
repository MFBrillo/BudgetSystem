Public Class CategorySubcategory
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Public RegistryDT As DataTable
    Public AssetsDT As DataTable

    Private Sub CategorySubcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        Custom_ComboBoxDatasource(RegistryIDcbb, RegistryDT, "Registry1", "Registry1")
        Custom_ComboBoxDatasource(AssetIDCBB, AssetsDT, "Asset", "Asset")

        Header_Accounts()

    End Sub

    Private Sub Header_Accounts()
        DataGridView1.Columns("Registry ID").Width = 90
        DataGridView1.Columns("Asset ID").Width = 90
        DataGridView1.Columns("Category ID").Width = 90
        DataGridView1.Columns("Category Code").Width = 90
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")
        RegistryDT = SqlLoad.MySql_SelectString("*", "vi_registry")
        AssetsDT = SqlLoad.MySql_SelectString("*", "vi_assets")

        Dim columns1 = "registrycode 'Registry ID', assetid 'Asset ID',categoryid 'Category ID', categoryidcode 'Category Code', category 'Category Name', description 'Category Description'"
        Dim columns2 = "assetid, categoryid, subcategoryid, code, subcategory, description"

        Dim table1 = "gl_assets_category"
        Dim table2 = "gl_assets_subcategory"

        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns1, table1,, "where length(registrycode) = 3")
        DataGridView2.DataSource = SqlLoad.MySql_SelectString(columns2, table2)

        Dim cols() = {"id", "logdate"}

        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub

    Private Sub AddFundbtn_Click(sender As Object, e As EventArgs) Handles AddCategorybtn.Click
        Dim mySql As New MySQLCore
        Try
            Dim inputText1 As String = RegistryIDcbb.Text
            Dim firstCharacter1 As String = ""

            If Not String.IsNullOrEmpty(inputText1) Then
                firstCharacter1 = inputText1.Substring(0, 3)
            End If

            Dim inputText2 As String = AssetIDCBB.Text
            Dim firstCharacter2 As String = ""

            If Not String.IsNullOrEmpty(inputText2) Then
                firstCharacter2 = inputText2.Substring(0, 3)
            End If

            Dim columnValues As New Dictionary(Of String, String)
            columnValues.Add("registrycode", firstCharacter1)
            columnValues.Add("assetid", firstCharacter2)
            columnValues.Add("categoryid", CategoryIDtxt.Text)
            columnValues.Add("categotycode", Categorycodetxt.Text)
            columnValues.Add("category", Categorynametxt.Text)
            columnValues.Add("description", CategoryDestxt.Text)

            Dim dt = mySql.MySql_SelectString("registrycode", "gl_assets_category", $"WHERE categoryid = '{CategoryIDtxt.Text}' OR categotycode LIKE '%{Categorycodetxt.Text}%'")

            If dt.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_assets_category", columnValues, Nothing, 1)
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Custom_Load()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
