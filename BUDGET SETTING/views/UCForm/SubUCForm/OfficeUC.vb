Public Class OfficeUC
    Public OfficeDT As DataTable
    Private Sub OfficeUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "wap_offices_temp")
        DataGridView1.DataSource = SqlLoad.MySql_SelectString("*", "vi_moises_offices_temp", Nothing,)
        Add_GridButton(DataGridView1, "Pending", "Approve", "ApproveDGBtn", 7, 100)
        Dim cols() = {"ID"}
        Datagrid_HideColumn(DataGridView1, cols)
        AddHandler DataGridView1.CellClick, AddressOf DataGridView1_CellClick
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim mySql As New MySQLCore
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If TypeOf (DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)) Is DataGridViewButtonCell Then
                OpaquePrompt.Show()
                CustomYesNoPrompt("Adding Office", "Do you want to Approve?")
                If YesNoPrompt.YesOption = True Then
                    OfficeDT = mySql.MySql_SelectString("officeid", "gl_offices", Nothing, Nothing, "order by id desc", "limit 1")
                    Dim lastofficeid As Integer = Convert.ToInt32(OfficeDT.Rows(0)("officeid"))
                    Dim newofficeid As Integer
                    newofficeid = lastofficeid + 1
                    OfficeDT = mySql.MySql_SelectString("*", "wap_offices_temp")
                    Dim row As DataRow = OfficeDT.Rows(e.RowIndex)
                    Dim idoffice As Integer = row.Item("idoffice").ToString

                    'Dim officeid As Integer = row.Item("officeid").ToString
                    Dim officeid As Integer = row.Item("officeid").ToString
                    Dim officetypeid As Integer = row.Item("officetypeid").ToString
                    Dim mandatory_aipcode As Integer = row.Item("mandatory_aipcode").ToString
                    Dim officecode_pbo As Integer = row.Item("officecode_pbo").ToString
                    Dim officecode_acctg As String = row.Item("officecode_acctg").ToString
                    Dim officename As String = row.Item("officename").ToString
                    Dim officedescription As String = row.Item("officedescription").ToString
                    Dim officeaccronym As String = row.Item("officeaccronym").ToString
                    Dim update1 As Integer = row.Item("update1").ToString
                    If update1 = 0 Then
                        Try
                            Dim columnValues As New Dictionary(Of String, String)
                            columnValues.Add("id", newofficeid)
                            columnValues.Add("officeid", newofficeid)
                            columnValues.Add("officetypeid", officetypeid)
                            columnValues.Add("mandatory_aipcode", $"'{mandatory_aipcode}'")
                            columnValues.Add("officecode_pbo", $"'{officecode_pbo}'")
                            columnValues.Add("officecode_acctg", $"'{officecode_acctg}'")
                            columnValues.Add("officename", $"'{officename}'")
                            columnValues.Add("officedescription", $"'{officedescription}'")
                            columnValues.Add("officeaccronym", $"'{officeaccronym}'")
                            mySql.MySql_ExecuteNonQueryString("gl_offices", columnValues, Nothing, 1)
                            mySql.MySql_Delete("wap_offices_temp", $"idoffice= {idoffice}")
                        Catch ex As Exception
                            MsgBox("ERROR" & ex.Message)
                        End Try
                    ElseIf update1 = 1 Then
                        Try
                            Dim columnValues As New Dictionary(Of String, String)
                            'columnValues.Add("id", newofficeid)
                            columnValues.Add("officeid", officeid)
                            columnValues.Add("officetypeid", officetypeid)
                            columnValues.Add("mandatory_aipcode", $"'{mandatory_aipcode}'")
                            columnValues.Add("officecode_pbo", $"'{officecode_pbo}'")
                            columnValues.Add("officecode_acctg", $"'{officecode_acctg}'")
                            columnValues.Add("officename", $"'{officename}'")
                            columnValues.Add("officedescription", $"'{officedescription}'")
                            columnValues.Add("officeaccronym", $"'{officeaccronym}'")
                            mySql.MySql_ExecuteNonQueryString("gl_offices", columnValues, $"id={officeid}", 2)
                            mySql.MySql_Delete("wap_offices_temp", $"idoffice= {idoffice}")
                        Catch ex As Exception
                            MsgBox("ERROR" & ex.Message)
                        End Try
                    Else
                        MsgBox("Update")
                    End If
                End If
                OpaquePrompt.Dispose()
                Verify.Refresh()
                Verify.Activate()
                Custom_Load()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
