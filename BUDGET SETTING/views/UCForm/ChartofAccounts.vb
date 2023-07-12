Public Class ChartofAccounts
    Public AccountDT As DataTable
    Public RegistryDT As DataTable
    Public AssetsDT As DataTable
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable

    Private Sub RegularAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "asset", "asset")
        Custom_ComboBoxDatasource(CategoryIDtxt, CategoryDT, "category", "category")
        Custom_ComboBoxDatasource(SubcategoryIDtxt, SubcategoryDT, "subcategory", "subcategory")
        Header_Accounts()
    End Sub
    Public Shared assetcontrol As Boolean = False
    Friend Sub combobox_Load()
        If assetcontrol = True Then
            Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "asset", "asset")
        End If
    End Sub

    Public Shared assetid
    Private Sub AssetIDTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.SelectedIndexChanged
        Try
            Dim sql As New MySQLCore
            Dim dt = sql.MySql_SelectString("id", "gl_assets", , $"where asset ='{AssetIDTxt.Text}'")
            assetid = dt.Rows(0).Item("id").ToString
            Label2.Text = assetid
        Catch ex As Exception
        End Try
    End Sub
    Public Shared categoryid
    Private Sub CategoryIDtxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryIDtxt.SelectedIndexChanged
        Try
            Dim sql As New MySQLCore

            Dim dt = sql.MySql_SelectString("categoryid", "gl_assets_category", , $"where category ='{CategoryIDtxt.Text}'")
            categoryid = dt.Rows(0).Item("categoryid").ToString
            Label3.Text = categoryid

        Catch ex As Exception
        End Try
    End Sub
    Public Shared subcategoryid
    Private Sub Subcategorytxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubcategoryIDtxt.SelectedIndexChanged
        Try
            Dim sql As New MySQLCore
            Dim dt = sql.MySql_SelectString("subcategoryid", "gl_assets_subcategory", , $"where subcategory ='{SubcategoryIDtxt.Text}'")
            subcategoryid = dt.Rows(0).Item("subcategoryid").ToString
            Label4.Text = subcategoryid

        Catch ex As Exception
        End Try
    End Sub

    Sub autogenerateaccountid()
        If SubcategoryIDtxt.Text = "" Then
            AccountIDtxt.Text = ""

        Else
            Dim SqlLoad As New MySQLCore
            AccountDT = SqlLoad.MySql_SelectString("MAX(accountid+1) AS NewAccountID", "gl_accounts", Nothing, $" where subcategoryid = '{subcategoryid}'")

            If AccountDT.Rows.Count > 0 AndAlso Not IsDBNull(AccountDT.Rows(0)("NewAccountID")) Then
                Dim newAccountID As Integer = Convert.ToInt32(AccountDT.Rows(0)("NewAccountID"))
                AccountIDtxt.Text = newAccountID.ToString()
            End If

            Dim inputText As String = AccountIDtxt.Text
            Dim outputText As String = ""

            For i As Integer = 0 To inputText.Length - 1
                outputText &= inputText(i)
                If i = 0 OrElse i = 2 OrElse i = 4 Then
                    outputText &= "-"
                End If
            Next
            AccountCodetxt.Text = outputText
        End If


    End Sub
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category")
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")

        Dim columns = "id As ID,assetid 'Asset ID',accountid 'Account ID',accountname 'Account Name',accountdescription 'Account Description'"
        Dim table = "gl_accounts"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"registrycode", "categoryid", "subcategoryid", "accountcode", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub

    Private Sub Header_Accounts()
        DataGridView1.Columns("ID").Width = 90
        DataGridView1.Columns("Asset ID").Width = 90
        DataGridView1.Columns("Account ID").Width = 90
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
        disablesave()
    End Sub
    Private Sub AccountIDtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AccountIDtxt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf AccountIDtxt.Text.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        enablesave()
    End Sub
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        enablesave()
    End Sub
    Sub enablesave()
        Savebtn.Enabled = True
        Addbtn.Enabled = False
        Editbtn.Enabled = False
    End Sub
    Sub disablesave()
        Savebtn.Enabled = False
        Addbtn.Enabled = True
        Editbtn.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Asset.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AddCategorybtn.Click
        Category.AssetIDtxt.Text = assetid
        Category.CategoryIDtxt.Text = categoryid
        Category.ShowDialog()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AddSubcategorybtn.Click
        Subcategory.Assetidtxt.Text = assetid
        Subcategory.CategoryIDtxt.Text = categoryid
        Subcategory.SubcategoryIDtxt.Text = subcategoryid
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

    End Sub
    Private Sub Subcategorytxt_DropDown(sender As Object, e As EventArgs) Handles SubcategoryIDtxt.DropDown


        Dim SqlLoad As New MySQLCore
            SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory",, $"where categoryid ='{categoryid}'")
            Custom_ComboBoxDatasource(SubcategoryIDtxt, SubcategoryDT, "subcategory", "subcategory")


    End Sub
    Private Sub AssetIDTxt_DropDownClosed(sender As Object, e As EventArgs) Handles AssetIDTxt.DropDownClosed

    End Sub

    Private Sub SubcategoryIDtxt_DropDownClosed(sender As Object, e As EventArgs) Handles SubcategoryIDtxt.DropDownClosed
        autogenerateaccountid()
    End Sub
End Class
