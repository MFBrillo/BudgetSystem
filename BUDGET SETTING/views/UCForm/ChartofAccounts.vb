Public Class ChartofAccounts
    Public AccountDT As DataTable
    Public RegistryDT As DataTable
    Public AssetsDT As DataTable
    Public CategoryDT As DataTable
    Public SubcategoryDT As DataTable
    Private Sub RegularAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        'Custom_ComboBoxDatasource(RegistrycodeTxt, RegistryDT, "Registry1", "Registry1")
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "Asset", "Asset")
        Header_Accounts()
    End Sub
    Friend Sub ref()
        Dim SqlLoad As New MySQLCore
        Custom_Load()
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "Asset", "Asset")
        'Header_Accounts()
    End Sub
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        RegistryDT = SqlLoad.MySql_SelectString("*", "vi_registry")
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "vi_subcategory")
        CategoryDT = SqlLoad.MySql_SelectString("*", "vi_category")
        AssetsDT = SqlLoad.MySql_SelectString("*", "vi_assets")
        Dim columns = "id as ID,registryid 'Registry ID',assetid 'Asset ID',accountid 'Account ID',accountname 'Account Name',accountdescription 'Account Description'"
        Dim table = "gl_accounts"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table, Nothing, "where length(registrycode)=3")
        Dim cols() = {"registrycode", "categoryid", "subcategoryid", "accountcode", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub
    Private Sub Header_Accounts()
        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("Registry ID").Width = 90
        DataGridView1.Columns("Asset ID").Width = 90
        DataGridView1.Columns("Account ID").Width = 90
    End Sub

    Friend firstCharacter1 As String = ""
    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        If Accountnametxt.Text = "" Then
            CustomMsg("Save Record Failed", "Insert Correct Data.", "OK")

        Else
            'Dim inputText1 As String = RegistrycodeTxt.Text
            'Dim firstCharacter1 As String = ""

            'If Not String.IsNullOrEmpty(inputText1) Then
            '    firstCharacter1 = inputText1.Substring(0, 3)
            'End If

            'Dim inputText As String = RegistrycodeTxt.Text
            'Dim firstCharacter As String = ""

            'If Not String.IsNullOrEmpty(inputText) Then
            '    firstCharacter = inputText.Substring(0, 1)
            'End If

            Dim inputText2 As String = AssetIDTxt.Text
            Dim firstCharacter2 As String = ""

            If Not String.IsNullOrEmpty(inputText2) Then
                firstCharacter2 = inputText2.Substring(0, 1)
            End If

            Dim inputText3 As String = CategoryIDtxt.Text
            Dim firstCharacter3 As String = ""

            If Not String.IsNullOrEmpty(inputText3) Then
                firstCharacter3 = inputText3.Substring(0, 3)
            End If

            Dim inputText4 As String = Subcategorytxt.Text
            Dim firstCharacter4 As String = ""

            If Not String.IsNullOrEmpty(inputText4) Then
                firstCharacter4 = inputText4.Substring(0, 5)
            End If
            Try
                Dim mySql As New MySQLCore
                Dim columnValues As New Dictionary(Of String, String)
                'columnValues.Add("registryid", firstCharacter)
                'columnValues.Add("registrycode", firstCharacter1)
                columnValues.Add("assetid", firstCharacter2)
                columnValues.Add("categoryid", firstCharacter3)
                columnValues.Add("subcategoryid", firstCharacter4)
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
    Private Sub AssetIDTxt_TextChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.TextChanged
        Dim inputText1 As String = AssetIDTxt.Text
        Dim secondeCharacter As String = ""

        If Not String.IsNullOrEmpty(inputText1) Then
            secondeCharacter = inputText1.Substring(0, 1)
        End If

        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("*", "vi_category", Nothing, $" where assetid = '{secondeCharacter}'")
        Custom_ComboBoxDatasource(CategoryIDtxt, CategoryDT, "Category1", "Category1")

        RegistryDT = SqlLoad.MySql_SelectString("*", "vi_registry", Nothing, $" where assetid = '{secondeCharacter}'")
        'Custom_ComboBoxDatasource(RegistrycodeTxt, RegistryDT, "Registry1", "Registry1")
        'Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "Asset", "Asset")

    End Sub
    Private Sub CategoryIDtxt_TextChanged(sender As Object, e As EventArgs) Handles CategoryIDtxt.TextChanged
        Dim inputText1 As String = CategoryIDtxt.Text
        Dim secondeCharacter As String = ""

        If Not String.IsNullOrEmpty(inputText1) Then
            secondeCharacter = inputText1.Substring(0, 3)
        End If

        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "vi_subcategory", Nothing, $" where categoryid = '{secondeCharacter}'")
        Custom_ComboBoxDatasource(Subcategorytxt, SubcategoryDT, "Subcategory1", "subcategory1")
    End Sub
    Private Sub Subcategorytxt_TextChanged(sender As Object, e As EventArgs) Handles Subcategorytxt.TextChanged
        If Subcategorytxt.Text = "" Then
            AccountIDtxt.Text = ""
        Else
            Dim inputText1 As String = Subcategorytxt.Text
            Dim secondeCharacter As String = ""

            If Not String.IsNullOrEmpty(inputText1) Then
                secondeCharacter = inputText1.Substring(0, 5)
            End If

            Dim SqlLoad As New MySQLCore
            AccountDT = SqlLoad.MySql_SelectString("MAX(accountid+1) AS NewAccountID", "gl_accounts", Nothing, $" where subcategoryid = '{inputText1}'")

            If AccountDT.Rows.Count > 0 AndAlso Not IsDBNull(AccountDT.Rows(0)("NewAccountID")) Then
                Dim newAccountID As Integer = Convert.ToInt32(AccountDT.Rows(0)("NewAccountID"))
                AccountIDtxt.Text = newAccountID.ToString()
            End If
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

    Private Sub AssetIDTxt_SelectedValueChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.SelectedValueChanged
        'If AssetIDTxt.Text = "<add new>" Then
        '    Asset.ShowDialog()
        '    Asset.TopMost = True
        'End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Asset.ShowDialog()
    End Sub

    Private Sub AssetIDTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
