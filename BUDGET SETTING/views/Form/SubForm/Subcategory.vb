Public Class Subcategory
    Public SubcategoryDT As DataTable
    Public LastSubcategoryDT As DataTable
    Public BeforLastSubcategoryDT As DataTable
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
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
    Sub Cleartextbox()
        Subcategorynametxt.Text = ""
        SubcategoryDestxt.Text = ""
    End Sub
    Sub Autosubcategoryid()
        Dim SqlLoad As New MySQLCore
        SubcategoryDT = SqlLoad.MySql_SelectString("subcategoryid", "gl_assets_subcategory", Nothing, $"where categoryid ='{CategoryIDtxt.Text}' and assetid = '{Assetidtxt.Text} '")
        If SubcategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(SubcategoryDT.Rows(0)("subcategoryid")) Then
            LastSubcategoryDT = SqlLoad.MySql_SelectString("subcategoryid", "gl_assets_subcategory", Nothing, $"where categoryid ='{CategoryIDtxt.Text}'", "order by id desc", "limit 1")
            BeforLastSubcategoryDT = SqlLoad.MySql_SelectString("subcategoryid", "gl_assets_subcategory", Nothing, $"where categoryid ='{CategoryIDtxt.Text}'", "order by id desc", "limit 1 offset 1")
            If BeforLastSubcategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(SubcategoryDT.Rows(0)("subcategoryid")) Then
                Dim newcategoryID As Integer = Convert.ToInt32(SubcategoryDT.Rows(0)("subcategoryid"))
                Dim newbeforelastcategoryID As Integer = Convert.ToInt32(BeforLastSubcategoryDT.Rows(0)("subcategoryid"))
                If LastSubcategoryDT.Rows.Count = 0 OrElse IsDBNull(LastSubcategoryDT.Rows(0)("subcategoryid")) Then
                    SubcategoryIDtxt.Text = newcategoryID
                Else
                    If LastSubcategoryDT.Rows.Count > 0 AndAlso Not IsDBNull(LastSubcategoryDT.Rows(0)("subcategoryid")) Then
                        Dim newlastcategoryID As Integer = Convert.ToInt32(LastSubcategoryDT.Rows(0)("subcategoryid"))
                        If (newlastcategoryID - newbeforelastcategoryID) = 1 Then
                            SubcategoryIDtxt.Text = newlastcategoryID + 1
                        Else
                            SubcategoryIDtxt.Text = newbeforelastcategoryID + 1
                        End If
                    End If
                End If
            Else
                SubcategoryIDtxt.Text = Convert.ToInt32(CategoryIDtxt.Text + "02")
            End If
        Else
            Try
                SubcategoryIDtxt.Text = Convert.ToInt32(CategoryIDtxt.Text + "01")
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub AssetAddbtn_Click(sender As Object, e As EventArgs) Handles AssetAddbtn.Click
        Dim mySql As New MySQLCore
        Try
            Dim ColumnValues As New Dictionary(Of String, String)
            ColumnValues.Add("assetid", Assetidtxt.Text)
            ColumnValues.Add("categoryid", CategoryIDtxt.Text)
            ColumnValues.Add("subcategoryid", SubcategoryIDtxt.Text)
            ColumnValues.Add("code", SubcategoryCodetxt.Text)
            ColumnValues.Add("subcategory", Subcategorynametxt.Text)
            ColumnValues.Add("description", SubcategoryDestxt.Text)
            Dim dt = mySql.MySql_SelectString("subcategoryid", "gl_assets_subcategory", $"WHERE subcategory = '{Subcategorynametxt.Text}'")
            If dt.Rows.Count > 0 Then
                ' Data already exists
                MsgBox("Already exists")
            Else
                ' Data does not exist, insert the new row
                mySql.MySql_ExecuteNonQueryString("gl_assets_subcategory", ColumnValues, Nothing, 1)
                'Asset.ref()
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
        Custom_ComboBoxDatasource(ChartofAccounts.subcategoryCBB, SubcategoryDT, "subcategory", "subcategory")
        ChartofAccounts.subcategoryCBB.SelectedIndex = ChartofAccounts.subcategoryCBB.Items.Count - 1
    End Sub
    Private Sub SubcategoryIDtxt_OnValueChanged(sender As Object, e As EventArgs) Handles SubcategoryIDtxt.OnValueChanged
        Dim input As String = SubcategoryIDtxt.Text
        ' Assuming the input string contains only digits
        If input.Length <= 1 Then
            SubcategoryCodetxt.Text = input ' Return as it is if it's a single digit
        Else
            Dim firstPart As String = input.Substring(0, 1) ' Extract the first digit
            Dim secondPart As String = input.Substring(1, 2) ' Extract the second and third digit
            Dim thirdPard As String = input.Substring(3) ' Extract the rest of the string
            SubcategoryCodetxt.Text = $"{firstPart}-{secondPart}-{thirdPard}"
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class