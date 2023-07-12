Public Class Category
    Public CategoryDT As DataTable
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
    Sub cleartextbox()
        Categorynametxt.Text = ""
        CategoryDestxt.Text = ""
    End Sub
    Sub autocategoryid()
        Dim SqlLoad As New MySQLCore
        CategoryDT = SqlLoad.MySql_SelectString("MAX(categoryid+1) AS NewAccountID", "gl_assets_category", Nothing, $" where assetid = '{AssetIDtxt.Text}'")

        If CategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(CategoryDT.Rows(0)("NewAccountID")) Then
            Dim newAccountID As Integer = Convert.ToInt32(CategoryDT.Rows(0)("NewAccountID"))
            CategoryIDtxt.Text = newAccountID.ToString()
        End If
    End Sub

    Private Sub AddCategorybtn_Click(sender As Object, e As EventArgs) Handles AddCategorybtn.Click
        Dim mySql As New MySQLCore
        Try
            Dim columnValues As New Dictionary(Of String, String)
            columnValues.Add("assetid", AssetIDtxt.Text)
            columnValues.Add("categoryid", CategoryIDtxt.Text)
            columnValues.Add("category", Categorynametxt.Text)
            columnValues.Add("description", CategoryDestxt.Text)

            Dim dt = mySql.MySql_SelectString("categoryid", "gl_assets_category", $"WHERE category = '{Categorynametxt.Text}'")

            If dt.Rows.Count > 0 Then
                ' Data already exists
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
End Class