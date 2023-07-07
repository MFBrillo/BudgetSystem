Public Class Asset
    Public AssetsDT As DataTable
    Public Asset As New ChartofAccounts
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Me.Close()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "vi_accounts")
    End Sub
    Private Sub AssetAddbtn_Click(sender As Object, e As EventArgs) Handles AssetAddbtn.Click
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
                'Asset.ref()
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Me.Close()

    End Sub

    Private Sub Asset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Assettxt.Text = ""
        AssetDescrptiontxt.Text = ""
    End Sub
End Class
