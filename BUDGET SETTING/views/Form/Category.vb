Public Class Category
    Public CategoryDT As DataTable
    Public LastCategoryDT As DataTable
    Public BeforLastCategoryDT As DataTable
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Me.Close()
    End Sub
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cleartextbox()
        Custom_Load()
        autocategoryid()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category")
    End Sub
    Sub Cleartextbox()
        Categorynametxt.Text = ""
        CategoryDestxt.Text = ""
    End Sub
    Sub Autocategoryid()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("categoryid", "gl_assets_category", Nothing, $"where assetid ='{AssetIDtxt.Text}'")
        If CategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(CategoryDT.Rows(0)("categoryid")) Then
            LastCategoryDT = SqlLoad.MySql_SelectString("categoryid", "gl_assets_category", Nothing, $"where assetid ='{AssetIDtxt.Text}'", "order by id desc", "limit 1")
            BeforLastCategoryDT = SqlLoad.MySql_SelectString("categoryid", "gl_assets_category", Nothing, $"where assetid ='{AssetIDtxt.Text}'", "order by id desc", "limit 1 offset 1")
            If BeforLastCategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(CategoryDT.Rows(0)("categoryid")) Then
                Dim newcategoryID As Integer = Convert.ToInt32(CategoryDT.Rows(0)("categoryid"))
                Dim newbeforelastcategoryID As Integer = Convert.ToInt32(BeforLastCategoryDT.Rows(0)("categoryid"))
                If LastCategoryDT.Rows.Count = 0 OrElse IsDBNull(LastCategoryDT.Rows(0)("categoryid")) Then
                    CategoryIDtxt.Text = newcategoryID
                Else
                    If LastCategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(LastCategoryDT.Rows(0)("categoryid")) Then
                        Dim newlastcategoryID As Integer = Convert.ToInt32(LastCategoryDT.Rows(0)("categoryid"))
                        If (newlastcategoryID - newbeforelastcategoryID) = 1 Then
                            CategoryIDtxt.Text = newlastcategoryID + 1
                        Else
                            CategoryIDtxt.Text = newbeforelastcategoryID + 1
                        End If
                    End If
                End If
            Else
                CategoryIDtxt.Text = Convert.ToInt32(AssetIDtxt.Text + "02")
            End If
        Else
            Try
                CategoryIDtxt.Text = Convert.ToInt32(AssetIDtxt.Text + "01")
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub AddCategorybtn_Click(sender As Object, e As EventArgs) Handles AddCategorybtn.Click
        Dim mySql As New MySQLCore
        Try
            Dim ColumnValues As New Dictionary(Of String, String)
            ColumnValues.Add("assetid", AssetIDtxt.Text)
            columnValues.Add("categoryid", CategoryIDtxt.Text)
            columnValues.Add("category", Categorynametxt.Text)
            columnValues.Add("description", CategoryDestxt.Text)
            columnValues.Add("code", Categorycodetxt.Text)
            Dim dt = mySql.MySql_SelectString("categoryid", "gl_assets_category", $"WHERE category = '{Categorynametxt.Text}'")
            If dt.Rows.Count > 0 Then
                ' Data already exists
                mySql.MySql_ExecuteNonQueryString("gl_assets_category", columnValues, Nothing, 2)
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_assets_category", columnValues, Nothing, 1)
                'Asset.ref()
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Me.Close()
    End Sub
    Private Sub AssetIDtxt_OnValueChanged(sender As Object, e As EventArgs) Handles AssetIDtxt.OnValueChanged
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Categorycodetxt_OnValueChanged_1(sender As Object, e As EventArgs) Handles Categorycodetxt.OnValueChanged

    End Sub

    Private Sub CategoryIDtxt_OnValueChanged(sender As Object, e As EventArgs) Handles CategoryIDtxt.OnValueChanged
        Dim input As String = CategoryIDtxt.Text

        ' Assuming the input string contains only digits
        If input.Length <= 1 Then
            Categorycodetxt.Text = input ' Return as it is if it's a single digit
        Else
            Dim firstPart As String = input.Substring(0, 1) ' Extract the first digit
            Dim secondPart As String = input.Substring(1) ' Extract the rest of the string

            Categorycodetxt.Text = $"{firstPart}-{secondPart}"
        End If
    End Sub
    Public Sub PopulateTextBox(categoryname As String, categoryDes As String, assetID As String, categoryID As String, categorycode As String)

        Categorynametxt.Text = categoryname
        CategoryDestxt.Text = categoryDes
        AssetIDtxt.Text = assetID
        CategoryIDtxt.Text = categoryID
        Categorycodetxt.Text = categorycode
    End Sub
End Class