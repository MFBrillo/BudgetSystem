Public Class Form1
    Public AccountDT As DataTable
    Public RegistryDT As DataTable
    Public AssetsDT As DataTable
    Public Category As DataTable
    Public Subcategory As DataTable

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RegistrycodeTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegistrycodeTxt.SelectedIndexChanged

    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click

        Dim inputText1 As String = RegistrycodeTxt.Text
        Dim firstCharacter As String = ""

        If Not String.IsNullOrEmpty(inputText1) Then
            firstCharacter = inputText1.Substring(0, 3)
        End If

        Dim inputText2 As String = AssetIDTxt.Text
        Dim secondeCharacter As String = ""

        If Not String.IsNullOrEmpty(inputText2) Then
            secondeCharacter = inputText2.Substring(0, 1)
        End If

        'Dim inputText3 As String = AccountIDtxt.Text
        'Dim Character3 As String = ""
        'Dim Character4 As String = ""

        'Dim inputText5 As String = AccountIDtxt.Text

        'If Not String.IsNullOrEmpty(inputText2) Then
        '    Character3 = inputText3.Substring(0, 3)
        'End If

        'If Not String.IsNullOrEmpty(inputText2) Then
        '    Character4 = inputText3.Substring(0, 5)
        'End If

        'Dim Character5 As String = ""
        'For i As Integer = 0 To inputText5.Length - 1
        '    Character5 &= inputText5(i)
        '    If i = 0 OrElse i = 2 OrElse i = 4 Then
        '        Character5 &= "-"
        '    End If
        'Next

        Try
            Dim mySql As New MySQLCore
            Dim columnValues As New Dictionary(Of String, String)
            ' Dim registrycode As String

            columnValues.Add("registrycode", firstCharacter)
            columnValues.Add("accountname", Accountnametxt.Text)
            columnValues.Add("assetid", secondeCharacter)
            columnValues.Add("accountid", AccountIDtxt.Text)
            'columnValues.Add("categoryid", Character3)
            'columnValues.Add("subcategoryid", Character4)
            'columnValues.Add("accountcode", Character5)
            columnValues.Add("accountdescription", Decriptiontxt.Text)

            mySql.MySql_ExecuteNonQueryString("gl_accounts", columnValues, Nothing, 1)
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
        Custom_Load()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        Custom_ComboBoxDatasource(RegistrycodeTxt, RegistryDT, "Registry1", "Registry1")
        Custom_ComboBoxDatasource(AssetIDTxt, AssetsDT, "Asset", "Asset")


    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AccountDT = SqlLoad.MySql_SelectString("*", "gl_accounts")
        RegistryDT = SqlLoad.MySql_SelectString("*", "vi_registry")
        AssetsDT = SqlLoad.MySql_SelectString("*", "vi_assets")
        'Category = SqlLoad.MySql_SelectString("*", "vi_category")
        'AssetsDT = SqlLoad.MySql_SelectString("*", "vi_assets")

        Dim columns = "id as ID,registryid 'Registry ID',assetid 'Asset ID',accountid 'Account ID',accountname 'Account Name',accountdescription 'Account Description'"
        Dim table = "gl_accounts"
        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns, table)
        Dim cols() = {"registrycode", "categoryid", "subcategoryid", "accountcode", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AccountIDtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AccountIDtxt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf AccountIDtxt.Text.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub AccountIDtxt_OnValueChanged(sender As Object, e As EventArgs) Handles AccountIDtxt.OnValueChanged

    End Sub

    Private Sub AssetIDTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.SelectedIndexChanged

    End Sub

    Private Sub Accountnametxt_OnValueChanged(sender As Object, e As EventArgs) Handles Accountnametxt.OnValueChanged

    End Sub

    Private Sub CategoryIDtxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryIDtxt.SelectedIndexChanged


    End Sub

    Private Sub AssetIDTxt_TextChanged(sender As Object, e As EventArgs) Handles AssetIDTxt.TextChanged
        Dim inputText1 As String = AssetIDTxt.Text
        Dim secondeCharacter As String = ""

        If Not String.IsNullOrEmpty(inputText1) Then
            secondeCharacter = inputText1.Substring(0, 1)
        End If

        Dim SqlLoad As New MySQLCore
        Category = SqlLoad.MySql_SelectString("*", "vi_category", Nothing, $" where assetid = '{secondeCharacter}'")
        Custom_ComboBoxDatasource(CategoryIDtxt, Category, "Category1", "Category1")
    End Sub

    Private Sub CategoryIDtxt_TabStopChanged(sender As Object, e As EventArgs) Handles CategoryIDtxt.TabStopChanged


    End Sub

    Private Sub CategoryIDtxt_TextChanged(sender As Object, e As EventArgs) Handles CategoryIDtxt.TextChanged
        Dim inputText1 As String = CategoryIDtxt.Text
        Dim secondeCharacter As String = ""

        If Not String.IsNullOrEmpty(inputText1) Then
            secondeCharacter = inputText1.Substring(0, 3)
        End If

        Dim SqlLoad As New MySQLCore
        Subcategory = SqlLoad.MySql_SelectString("*", "vi_subcategory", Nothing, $" where categoryid = '{secondeCharacter}'")
        Custom_ComboBoxDatasource(Subcategorytxt, Subcategory, "Subcategory1", "subcategory1")
    End Sub
End Class
