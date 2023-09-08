Public Class OfficeUC
    Public OfficeDT As DataTable
    Private Sub OfficeUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices_temp")
        DataGridView1.DataSource = SqlLoad.MySql_SelectString("*", "vi_offices_temp", Nothing,)
        Add_GridButton(DataGridView1, "Pending", "Approve", "ApproveDGBtn", 7, 100)
        Dim cols() = {"ID"}
        Datagrid_HideColumn(DataGridView1, cols)
        AddHandler DataGridView1.CellClick, AddressOf DataGridView1_CellClick
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If TypeOf (DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)) Is DataGridViewButtonCell Then
                OpaquePrompt.Show()
                CustomYesNoPrompt("Adding Office", "Do you want to Approve?")
                If YesNoPrompt.YesOption = True Then
                    Dim SqlLoad As New MySQLCore
                    OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices_temp")
                    Dim row As DataRow = OfficeDT.Rows(e.RowIndex)
                    Dim officeid As Integer = row.Item("officeid").ToString
                    Dim officetypeid As Integer = row.Item("officetypeid").ToString
                    Dim mandatory_aipcode As Integer = row.Item("mandatory_aipcode").ToString
                    Dim officecode_pbo As Integer = row.Item("officecode_pbo").ToString
                    Dim officecode_acctg As String = row.Item("officecode_acctg").ToString
                    Dim officename As String = row.Item("officename").ToString
                    Dim officedescription As String = row.Item("officedescription").ToString
                    Dim officeaccronym As String = row.Item("officeaccronym").ToString
                    Try
                        Dim mySql As New MySQLCore
                        Dim columnValues As New Dictionary(Of String, String)
                        columnValues.Add("officeid", officeid)
                        columnValues.Add("officetypeid", officetypeid)
                        columnValues.Add("mandatory_aipcode", mandatory_aipcode)
                        columnValues.Add("officecode_pbo", officecode_pbo)
                        columnValues.Add("officecode_acctg", officecode_acctg)
                        columnValues.Add("officename", officename)
                        columnValues.Add("officedescription", officedescription)
                        columnValues.Add("officeaccronym", officeaccronym)
                        mySql.MySql_ExecuteNonQueryString("gl_offices", columnValues, Nothing, 1)
                        mySql.MySql_Delete("gl_offices_temp", $"officeid= {officeid}")
                    Catch ex As Exception
                        MsgBox("ERROR" & ex.Message)
                    End Try
                    Custom_Load()

                End If
                OpaquePrompt.Dispose()
                'Form1.Activate()
                Verify.Refresh()
                Verify.Activate()
                'MsgBox(sender.name)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
