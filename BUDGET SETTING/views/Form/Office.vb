
Public Class Office
    Public OfficeDT As DataTable
    Private Sub Office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        Custom_LoadOffice()
        Header_Accounts()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
    End Sub

    Sub Custom_LoadOffice()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        DataGridView1.DataSource = OfficeDT
        Dim oldcolumns() = {"officecode_acctg", "officename", "officedescription", "officeaccronym"}
        Dim columns() = {"Acct. Code", "Office", "Description", "Accronym"}
        Dim cols() = {"id", "officeid", "officetypeid", "mandatory_aipcode", "officecode_pbo", "open_office", "subcategoryid", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_RenameColumn(DataGridView1, oldcolumns, columns)

        Dim myImage As Image = My.Resources.pencil
        Add_GridImageButton(DataGridView1, "Edit", myImage, "ImgDGBtn1", 10, 50)
        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick
    End Sub
    Private Sub Header_Accounts()
        DataGridView1.Columns("officecode_acctg").Width = 50
        DataGridView1.Columns("officename").Width = 150
        DataGridView1.Columns("officedescription").Width = 150
        DataGridView1.Columns("officeaccronym").Width = 50
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim mySql As New MySQLCore
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
            If columnName = "ImgDGBtn1" Then
                OpaquePrompt.Show()
                CustomYesNoPrompt("Update Data", "Do you want to Update Data")
                If YesNoPrompt.YesOption = True Then
                    Dim id As String = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString
                    Dim officecode_acctg As String = DataGridView1.Rows(e.RowIndex).Cells("officecode_acctg").Value.ToString
                    Dim officename As String = DataGridView1.Rows(e.RowIndex).Cells("officename").Value.ToString
                    Dim officedescription As String = DataGridView1.Rows(e.RowIndex).Cells("officedescription").Value.ToString
                    Dim officeaccronym As String = DataGridView1.Rows(e.RowIndex).Cells("officeaccronym").Value.ToString
                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("id", id)
                    columnValues.Add("officecode_acctg", $"'{officecode_acctg}'")
                    columnValues.Add("officename", $"""{officename}""")
                    columnValues.Add("officedescription", $"""{officedescription}""")
                    columnValues.Add("officeaccronym", $"'{officeaccronym}'")
                    mySql.MySql_ExecuteNonQueryString("gl_offices", columnValues, $"id={id}", 2)
                    CustomMsg("Update ", "Update Successful")
                End If
                Form1.Activate()
            End If
        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Addbtn.Click
        AddOffice.Saveupdate = 1
        AddOffice.title = "Add Office"
        OpaquePrompt.Show()
        AddOffice.ShowDialog()
    End Sub
    Private Sub Searchtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Searchtxt.OnValueChanged
        Try
            If OfficeDT.Rows.Count > 0 AndAlso DataGridView1.Rows.Count > 0 Then

                Dim conditions As New List(Of LinQCondition)()
                conditions.Add(New LinQCondition With {
                .Column = "officename",
                .Value = Searchtxt.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            })
                Dim filteredDataTable As DataTable = Linq_Query(OfficeDT, conditions)
                DataGridView1.DataSource = filteredDataTable
                'accountdescription2 = filteredDataTable.Rows(0).Item("accountname").ToString
                'accountcode2 = filteredDataTable.Rows(0).Item("code").ToString
                'accountid2 = filteredDataTable.Rows(0).Item("id").ToString
                'msgbox(accountcode2)
            ElseIf Searchtxt.Text = "" Then
                Custom_LoadOffice()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Shared officename
    Public Shared officeid

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Dim mySql As New MySQLCore
        'Dim searchrowid As String
        'searchrowid = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()
        'AddOffice.officeid = searchrowid
        'MsgBox(searchrowid)
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class