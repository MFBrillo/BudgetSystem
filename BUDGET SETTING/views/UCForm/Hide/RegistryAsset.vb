Public Class RegistryAsset

    Public Assest As DataTable
    Public Registry As DataTable
    Private Sub RegistryAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        Header_Accounts()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        Assest = SqlLoad.MySql_SelectString("*", "gl_assets")
        Registry = SqlLoad.MySql_SelectString("*", "gl_registry")

        Dim columns1 = "registrycode 'Registry Code',registryname 'Registry Name', registrydescription 'Registry Description'"
        Dim columns2 = "assetid 'Asset ID', asset 'Asset', description 'Description'"
        Dim table1 = "gl_registry"
        Dim table2 = "gl_assets"

        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns1, table1)
        DataGridView2.DataSource = SqlLoad.MySql_SelectString(columns2, table2)
        Dim cols() = {"id", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub

    Private Sub Header_Accounts()
        DataGridView1.Columns("Registry Code").Width = 90
        DataGridView1.Columns("Registry Description").Width = 150
        DataGridView2.Columns("Asset ID").Width = 120
    End Sub

    Private Sub AddFundbtn_Click(sender As Object, e As EventArgs) Handles AddFundbtn.Click
        Dim mySql As New MySQLCore
        Try
            Dim inputText1 As String = Registrycodetxt.Text
            Dim secondeCharacter As String = ""

            If Not String.IsNullOrEmpty(inputText1) Then
                secondeCharacter = inputText1.Substring(0, 1)
            End If

            Dim columnValues As New Dictionary(Of String, String)
            columnValues.Add("registryid", secondeCharacter)
            columnValues.Add("registrycode", Registrycodetxt.Text)
            columnValues.Add("registryname", Registrynametxt.Text)
            columnValues.Add("registrydescription", RegistryDescriptiontxt.Text)

            Dim dt = mySql.MySql_SelectString("registryname", "gl_registry", $"WHERE registryid = '{Registrycodetxt.Text}' OR registrycode LIKE '%{Registrycodetxt.Text}%'")

            If dt.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_registry", columnValues, Nothing, 1)
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Custom_Load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AssetAddbtn.Click
        Dim mySql As New MySQLCore
        Try

            Dim lastid = mySql.MySql_SelectString("MAX(id+1) as lastidd", "gl_assets")



            Dim code = lastid.Rows(0).Item("lastidd").ToString
            Dim columnValues As New Dictionary(Of String, String)
            columnValues.Add("assetid", code)
            columnValues.Add("asset", Assettxt.Text)
            columnValues.Add("description", AssetDescrptiontxt.Text)

            Dim dt = mySql.MySql_SelectString("assetid", "gl_assets", $"WHERE asset = '{Assettxt.Text}'")

            If dt.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_assets", columnValues, Nothing, 1)
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Custom_Load()




    End Sub
End Class
