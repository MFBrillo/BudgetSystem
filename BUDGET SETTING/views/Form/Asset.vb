Public Class Asset
    Public AssetsDT As DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "gl_assets")
    End Sub
    Public dt1
    Private Sub AssetAddbtn_Click(sender As Object, e As EventArgs) Handles AssetSavebtn.Click
        Dim mySql As New MySQLCore
        Try
            Dim lastid = mySql.MySql_SelectString("MAX(id+1) as lastidd", "gl_assets")
            Dim code = lastid.Rows(0).Item("lastidd").ToString
            Dim ColumnValues As New Dictionary(Of String, String)
            ColumnValues.Add("assetid", code)
            ColumnValues.Add("asset", Assettxt.Text)
            ColumnValues.Add("description", AssetDescrptiontxt.Text)
            If exists = False Then
                Dim dt = mySql.MySql_SelectString("assetid", "gl_assets", $"WHERE asset = '{Assettxt.Text}'")
                dt1 = dt
            End If
            If dt1.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
                'mySql.MySql_ExecuteNonQueryString("gl_assets", columnValues, Nothing, 2)
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_assets", ColumnValues, Nothing, 1)
                '
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
        lastindex()
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()

    End Sub

    Sub lastindex()
        Custom_Load()
        Custom_ComboBoxDatasource(ChartofAccounts.assetCBB, AssetsDT, "asset", "asset")
        ChartofAccounts.assetCBB.SelectedIndex = ChartofAccounts.assetCBB.Items.Count - 1
    End Sub
    Private Sub Asset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cleartxt()
    End Sub
    Sub Cleartxt()
        Assettxt.Text = ""
        AssetDescrptiontxt.Text = ""
    End Sub
    Public Sub PopulateTextBox(asset As String, description As String)
        'TextBox1.Text = dataToDisplay
        Assettxt.Text = asset
        AssetDescrptiontxt.Text = description
        'AssetDescrptiontxt.Text = description
    End Sub
    Public exists As Boolean = False
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        exists = True
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

End Class
