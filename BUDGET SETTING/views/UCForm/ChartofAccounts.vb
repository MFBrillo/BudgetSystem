Imports System.Windows.Forms
Public Class ChartofAccounts
    Public AccountDT As DataTable
    Public AssetsDT As DataTable
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Public Shared assetCBB As ComboBox
    Public Shared categoryCBB As ComboBox
    Public Shared subcategoryCBB As ComboBox
    Private WithEvents dgvContextMenu As New ContextMenuStrip()
    Dim filteredDataTable As DataTable
    Private Sub RegularAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        Custom_Load()
        Custom_LoadAccounts()
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "asset", "asset")
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")
    End Sub
    Sub Custom_LoadAccounts()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        DataGridView1.DataSource = AccountDT
        Dim oldcolumns() = {"accountcode", "accountname", "accountdescription"}
        Dim columns() = {"Account Code", "Account", "Description"}
        Dim cols() = {"id", "registryid", "registrycode", "assetid", "categoryid", "subcategoryid", "accountid", "usetemplate", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_RenameColumn(DataGridView1, oldcolumns, columns)
        Header_Accounts()

        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick
    End Sub

    Private Sub Header_Accounts()
        DataGridView1.Columns("accountcode").Width = 20
        DataGridView1.Columns("accountname").Width = 50
        DataGridView1.Columns("accountdescription").Width = 350
        Dim myImage As Image = My.Resources.pencil
        Dim myImageadd As Image = My.Resources.add
        Add_GridImageButton(DataGridView1, "Update", myImage, "ImgDGBtn1", DataGridView1.Columns.Count - 1, 100)
        Add_GridImageButton(DataGridView1, "Add", myImageadd, "ImgDGBtn2", DataGridView1.Columns.Count - 2, 80)
    End Sub

    Public Shared assetid
    Private Sub AssetIDTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.SelectedIndexChanged
        Try
            Dim sql As New MySQLCore
            Dim dt = sql.MySql_SelectString("assetid", "gl_assets", , $"where asset ='{AssetIDTxt.Text}'")
            assetid = dt.Rows(0).Item("assetid").ToString
            cleartext1()
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
            Accountnumber1()
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
    Public Shared accountid
    Sub Accountnumber()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subcategoryid}'")
        If AccountDT.Rows.Count > 0 AndAlso Not IsDBNull(AccountDT.Rows(0)("accountid")) Then

            LastAccountDT = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subcategoryid}'", "order by id desc", "limit 1")
            Dim newcategoryID As Integer = Convert.ToInt32(AccountDT.Rows(0)("accountid"))
            If LastAccountDT.Rows.Count = 0 OrElse IsDBNull(LastAccountDT.Rows(0)("accountid")) Then
                AccountIDtxt.Text = newcategoryID
            Else
                If LastAccountDT.Rows.Count > 0 AndAlso Not IsDBNull(LastAccountDT.Rows(0)("accountid")) Then
                    Dim newlastcategoryID As Integer = Convert.ToInt32(LastAccountDT.Rows(0)("accountid"))
                    AccountIDtxt.Text = newlastcategoryID + 1
                End If
            End If
        Else
            Try
                AccountIDtxt.Text = Convert.ToInt32(subcategoryid + "01")
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub Accountnumber1()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subcategoryid}'")
        If AccountDT.Rows.Count > 0 AndAlso Not IsDBNull(AccountDT.Rows(0)("accountid")) Then
            LastAccountDT = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subcategoryid}'", "order by id desc", "limit 1")
            Dim numbers() As Integer = (From row As DataRow In AccountDT.Rows Select Convert.ToInt32(row("accountid"))).ToArray()
            Dim lowestNumber As Integer = numbers.Min()
            If LastAccountDT.Rows.Count = 0 OrElse IsDBNull(LastAccountDT.Rows(0)("accountid")) Then
                AccountIDtxt.Text = lowestNumber + 1
            Else
                If LastAccountDT.Rows.Count > 0 AndAlso Not IsDBNull(LastAccountDT.Rows(0)("accountid")) Then
                    Dim newlastcategoryID As Integer = Convert.ToInt32(LastAccountDT.Rows(0)("accountid"))

                    While Array.IndexOf(numbers, lowestNumber) >= 0
                        lowestNumber += 1
                    End While

                    AccountIDtxt.Text = lowestNumber
                End If
            End If
        Else
            Try
                AccountIDtxt.Text = Convert.ToInt32(subcategoryid + "01")
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub Custom_Accounts()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        Dim columns = "accountcode 'ACCOUNT CODE',accountname 'ACCOUNT NAME',accountdescription 'ACCOUNT DESCRIPTION'"
        Dim table = "gl_accounts"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"id", "registrycode", "categoryid", "subcategoryid", "accountid", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
        DataGridView1.Columns("Account Code").Width = 150
    End Sub
    Friend firstCharacter1 As String = ""
    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Dim SqlLoad As New MySQLCore
        OpaquePrompt.Show()
        CustomYesNoPrompt("Save Entries", "Do you want to save changes")
        If YesNoPrompt.YesOption = True Then
            If Accountnametxt.Text = "" Then
                CustomMsg("Save Record Failed", "Insert Correct Data.", "OK")
            Else
                Try
                    Dim mySql As New MySQLCore
                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("assetid", assetid)
                    columnValues.Add("categoryid", categoryid)
                    columnValues.Add("subcategoryid", subcategoryid)
                    columnValues.Add("accountname", $"""{Accountnametxt.Text}""")
                    columnValues.Add("accountid", $"'{AccountIDtxt.Text}'")
                    columnValues.Add("accountdescription", $"""{Decriptiontxt.Text}""")
                    columnValues.Add("accountcode", $"'{AccountCodetxt.Text}'")
                    mySql.MySql_ExecuteNonQueryString("gl_accounts", columnValues, Nothing, 1)
                Catch ex As Exception
                    MsgBox("ERROR" & ex.Message)
                End Try

            End If

            Form1.Activate()
            Dim uc = New ChartofAccounts
            Form1.ShowUserControl(uc)

        End If
    End Sub
    Sub lastindex()
        If DataGridView1.Rows.Count > 0 Then
            ' Get the index of the last row
            Dim lastIndex As Integer = DataGridView1.Rows.Count - 1
            ' Select the last row
            DataGridView1.Rows(lastIndex).Selected = True
            ' Scroll to the selected row to make it visible
            DataGridView1.FirstDisplayedScrollingRowIndex = lastIndex
        End If
    End Sub
    Sub cleartext1()
        AccountIDtxt.Text = ""
        AccountCodetxt.Text = ""
        Accountnametxt.Text = ""
        Decriptiontxt.Text = ""
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        assetCBB = AssetIDTxt
        OpaquePrompt.Show()
        Asset.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AddCategorybtn.Click
        categoryCBB = CategoryIDtxt
        OpaquePrompt.Show()
        Category.AssetIDtxt.Text = assetid
        Category.ShowDialog()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AddSubcategorybtn.Click
        subcategoryCBB = SubcategoryIDtxt
        OpaquePrompt.Show()
        Subcategory.Assetidtxt.Text = assetid
        Subcategory.CategoryIDtxt.Text = categoryid
        Subcategory.ShowDialog()
    End Sub
    Private Sub AssetIDTxt_DropDown(sender As Object, e As EventArgs) Handles AssetIDTxt.DropDown
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "asset", "asset")
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category",, $"where assetid ='{assetid}'")
        Custom_ComboBoxDatasource(CategoryIDtxt, CategoryDT, "category", "category")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory",, $"where categoryid ='{categoryid}'")
        Custom_ComboBoxDatasource(SubcategoryIDtxt, SubcategoryDT, "subcategory", "subcategory")
        cleartext1()
    End Sub
    Private Sub CategoryIDtxt_DropDown(sender As Object, e As EventArgs) Handles CategoryIDtxt.DropDown
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_category",, $"where assetid ='{assetid}'")
        Custom_ComboBoxDatasource(CategoryIDtxt, CategoryDT, "category", "category")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory",, $"where categoryid ='{categoryid}'")
        Custom_ComboBoxDatasource(SubcategoryIDtxt, SubcategoryDT, "subcategory", "subcategory")
        cleartext1()
    End Sub
    Private Sub Subcategorytxt_DropDown(sender As Object, e As EventArgs) Handles SubcategoryIDtxt.DropDown
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory",, $"where categoryid ='{categoryid}'")
        Custom_ComboBoxDatasource(SubcategoryIDtxt, SubcategoryDT, "subcategory", "subcategory")
    End Sub
    Friend Shared assetid2
    Friend Shared categoryid2
    Friend Shared subcategoryid2
    Friend Shared accountid2
    Friend Shared accountcode2
    Friend Shared accountname2
    Friend Shared accountdescription2


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        OpaquePrompt.Show()
        EditAccounts.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim mySql As New MySQLCore
            Dim searchrowid As String
            Custom_Load()
            searchrowid = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()
            accountid2 = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()
            Dim conditions As New List(Of LinQCondition) From {
            New LinQCondition With {
                             .Column = "id",
                             .Value = searchrowid,
                             .ComparisonType = ComparisonTypeEnum.Equal_enum}
        }
            Dim accountname As DataTable = Linq_Query(AccountDT, conditions)
            accountdescription2 = accountname.Rows(0).Item("accountname").ToString
            accountcode2 = accountname.Rows(0).Item("accountcode").ToString
            accountid2 = accountname.Rows(0).Item("id").ToString
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
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
                    Dim accountname As String = DataGridView1.Rows(e.RowIndex).Cells("accountname").Value.ToString
                    Dim accountdescription As String = DataGridView1.Rows(e.RowIndex).Cells("accountdescription").Value.ToString

                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("id", id)
                    columnValues.Add("accountname", $"""{accountname}""")
                    columnValues.Add("accountdescription", $"""{accountdescription}""")
                    mySql.MySql_ExecuteNonQueryString("gl_accounts", columnValues, $"id={id}", 2)

                    CustomMsg("Update ", "Update Successful")

                    Dim uc = New ChartofAccounts
                    Form1.ShowUserControl(uc)
                    Form1.Activate()
                End If

            ElseIf columnName = "ImgDGBtn2" Then
                OpaquePrompt.Show()
                AccountDescription.ShowDialog()
            End If
        End If

    End Sub
    Private Sub Searchtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Searchtxt.OnValueChanged
        Dim mySql As New MySQLCore
        Try
            If AccountDT.Rows.Count > 0 AndAlso DataGridView1.Rows.Count > 0 Then
                Dim conditions As New List(Of LinQCondition)()
                conditions.Add(New LinQCondition With {
                .Column = "accountname",
                .Value = Searchtxt.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            })

                filteredDataTable = Linq_Query(AccountDT, conditions)
                DataGridView1.DataSource = filteredDataTable

            ElseIf Searchtxt.Text = "" Then

                ClearDGV(DataGridView1)
                DataGridView1.Refresh()
                Custom_Load()
                Custom_LoadAccounts()

            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub
End Class
