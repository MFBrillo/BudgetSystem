Public Class ChartofAccounts
    Public AccountDT As DataTable
    Public AssetsDT As DataTable
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Private Sub RegularAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "asset", "asset")
        Header_Accounts()
    End Sub
    Public Shared assetid
    Private Sub AssetIDTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.SelectedIndexChanged
        Try
            Dim sql As New MySQLCore
            Dim dt = sql.MySql_SelectString("assetid", "gl_assets", , $"where asset ='{AssetIDTxt.Text}'")
            assetid = dt.Rows(0).Item("assetid").ToString
        Catch ex As Exception
        End Try
    End Sub
    Public Shared categoryid
    Private Sub CategoryIDtxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryIDtxt.SelectedIndexChanged
        Try
            Dim sql As New MySQLCore
            Dim dt = sql.MySql_SelectString("categoryid", "gl_assets_category", , $"where category ='{CategoryIDtxt.Text}'")
            categoryid = dt.Rows(0).Item("categoryid").ToString
        Catch ex As Exception

        End Try
    End Sub
    Public Shared subcategoryid
    Private Sub Subcategorytxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubcategoryIDtxt.SelectedIndexChanged
        Try
            Dim sql As New MySQLCore
            Dim dt = sql.MySql_SelectString("subcategoryid", "gl_assets_subcategory", , $"where subcategory ='{SubcategoryIDtxt.Text}'")
            subcategoryid = dt.Rows(0).Item("subcategoryid").ToString
            Accountnumber()
            Accountcode1()
        Catch ex As Exception
        End Try
    End Sub

    Sub Accountcode1()
        Dim input As String = AccountIDtxt.Text
        ' Assuming the input string contains only digits
        If input.Length <= 1 Then
            AccountCodetxt.Text = input ' Return as it is if it's a single digit
        Else
            Dim firstPart As String = input.Substring(0, 1) ' Extract the first digit
            Dim secondPart As String = input.Substring(1, 2) ' Extract the rest of the string
            Dim thirdPart As String = input.Substring(3, 2) ' Extract the first digit
            Dim fourthPart As String = input.Substring(5) ' Extract the rest of the string
            AccountCodetxt.Text = $"{firstPart}-{secondPart}-{thirdPart}-{fourthPart}"
        End If
    End Sub

    Public LastAccountDT As DataTable
    Public BeforLastAccountDT As DataTable
    Public Shared accountid
    Sub Accountnumber()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subcategoryid}'")
        If AccountDT.Rows.Count > 0 AndAlso Not IsDBNull(AccountDT.Rows(0)("accountid")) Then
            LastAccountDT = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subcategoryid}'", "order by id desc", "limit 1")
            BeforLastAccountDT = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subcategoryid}'", "order by id desc", "limit 1 offset 1")
            If BeforLastAccountDT.Rows.Count > 0 AndAlso Not IsDBNull(AccountDT.Rows(0)("accountid")) Then
                Dim newcategoryID As Integer = Convert.ToInt32(AccountDT.Rows(0)("accountid"))
                Dim newbeforelastcategoryID As Integer = Convert.ToInt32(BeforLastAccountDT.Rows(0)("accountid"))
                If LastAccountDT.Rows.Count = 0 OrElse IsDBNull(LastAccountDT.Rows(0)("accountid")) Then
                    AccountIDtxt.Text = newcategoryID
                Else
                    If LastAccountDT.Rows.Count > 0 AndAlso Not IsDBNull(LastAccountDT.Rows(0)("accountid")) Then
                        Dim newlastcategoryID As Integer = Convert.ToInt32(LastAccountDT.Rows(0)("accountid"))
                        If (newlastcategoryID - newbeforelastcategoryID) = 1 Then
                            AccountIDtxt.Text = newlastcategoryID + 1
                        Else
                            AccountIDtxt.Text = newbeforelastcategoryID + 1
                        End If
                    End If
                End If
            Else
                AccountIDtxt.Text = Convert.ToInt32(subcategoryid + "02")
            End If
        Else
            Try
                AccountIDtxt.Text = Convert.ToInt32(subcategoryid + "01")
            Catch ex As Exception

            End Try

        End If
    End Sub
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category")
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")
        Dim columns = "accountid 'ACCOUNT ID',accountname 'ACCOUNT NAME',accountdescription 'ACCOUNT DESCRIPTION'"
        Dim table = "gl_accounts"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"id", "registrycode", "categoryid", "subcategoryid", "accountcode", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub
    Private Sub Header_Accounts()
        DataGridView1.Columns("Account ID").Width = 120
    End Sub
    Friend firstCharacter1 As String = ""
    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        If Accountnametxt.Text = "" Then
            CustomMsg("Save Record Failed", "Insert Correct Data.", "OK")
        Else
            Try
                Dim mySql As New MySQLCore
                Dim columnValues As New Dictionary(Of String, String)
                columnValues.Add("assetid", assetid)
                columnValues.Add("categoryid", categoryid)
                columnValues.Add("subcategoryid", subcategoryid)
                columnValues.Add("accountname", Accountnametxt.Text)
                columnValues.Add("accountid", AccountIDtxt.Text)
                columnValues.Add("accountdescription", Decriptiontxt.Text)
                columnValues.Add("accountcode", AccountCodetxt.Text)
                mySql.MySql_ExecuteNonQueryString("gl_accounts", columnValues, Nothing, 1)
            Catch ex As Exception
                MsgBox("ERROR" & ex.Message)
            End Try
            Custom_Load()
        End If
        Disablesave()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Enablesave()
    End Sub
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Enablesave()
    End Sub
    Sub Enablesave()
        Savebtn.Enabled = True
        Addbtn.Enabled = False
        Editbtn.Enabled = False
    End Sub
    Sub Disablesave()
        Savebtn.Enabled = False
        Addbtn.Enabled = True
        Editbtn.Enabled = True
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Asset.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AddCategorybtn.Click
        Category.AssetIDtxt.Text = assetid
        Category.ShowDialog()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AddSubcategorybtn.Click
        Subcategory.Assetidtxt.Text = assetid
        Subcategory.CategoryIDtxt.Text = categoryid
        Subcategory.ShowDialog()
    End Sub
    Private Sub AssetIDTxt_DropDown(sender As Object, e As EventArgs) Handles AssetIDTxt.DropDown
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "asset", "asset")
    End Sub
    Private Sub CategoryIDtxt_DropDown(sender As Object, e As EventArgs) Handles CategoryIDtxt.DropDown
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category",, $"where assetid ='{assetid}'")
        Custom_ComboBoxDatasource(CategoryIDtxt, CategoryDT, "category", "category")
        'Custom_ComboBoxDatasource(CategoryIDtxt2, CategoryDT, "categoryid", "categoryid")
    End Sub
    Private Sub Subcategorytxt_DropDown(sender As Object, e As EventArgs) Handles SubcategoryIDtxt.DropDown
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory",, $"where categoryid ='{categoryid}'")
        Custom_ComboBoxDatasource(SubcategoryIDtxt, SubcategoryDT, "subcategory", "subcategory")
        ' Custom_ComboBoxDatasource(SubcategoryIDtxt2, SubcategoryDT, "subcategoryid", "subcategoryid")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
