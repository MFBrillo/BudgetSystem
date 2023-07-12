Public Class Subcategory
    Public SubcategoryDT As DataTable
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Me.Close()
    End Sub
    Private Sub Subcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cleartextbox()
        Custom_Load()
        autosubcategoryid()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("*", "gl_assets_subcategory")
    End Sub
    Sub cleartextbox()
        Subcategorynametxt.Text = ""
        SubcategoryDestxt.Text = ""
    End Sub

    Sub autosubcategoryid()
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("MAX(subcategoryid+1) AS NewAccountID", "gl_assets_subcategory", Nothing, $" where categoryid = '{CategoryIDtxt.Text}'")

        If SubcategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(SubcategoryDT.Rows(0)("NewAccountID")) Then
            Dim newAccountID As Integer = Convert.ToInt32(SubcategoryDT.Rows(0)("NewAccountID"))
            SubcategoryIDtxt.Text = newAccountID.ToString()
        End If
    End Sub

    Private Sub AssetAddbtn_Click(sender As Object, e As EventArgs) Handles AssetAddbtn.Click
        Dim mySql As New MySQLCore
        Try
            Dim columnValues As New Dictionary(Of String, String)
            columnValues.Add("assetid", Assetidtxt.Text)
            columnValues.Add("categoryid", CategoryIDtxt.Text)
            columnValues.Add("subcategoryid", SubcategoryIDtxt.Text)
            columnValues.Add("code", SubcategoryCodetxt.Text)
            columnValues.Add("subcategory", Subcategorynametxt.Text)
            columnValues.Add("description", SubcategoryDestxt.Text)

            Dim dt = mySql.MySql_SelectString("subcategoryid", "gl_assets_subcategory", $"WHERE subcategory = '{Subcategorynametxt.Text}'")

            If dt.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_assets_subcategory", columnValues, Nothing, 1)

                'Asset.ref()
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class