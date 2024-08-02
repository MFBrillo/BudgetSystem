Public Class Office
    Public OfficeDT As DataTable
    Dim filteredDataTable As DataTable

    Private Sub Office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        Custom_LoadOffice()
        Header_Accounts()
        Typesearchtxt.Text = "Office"
    End Sub
    Sub Custom_LoadOffice()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")

        DataGridView1.DataSource = OfficeDT
        Dim oldcolumns() = {"officecode_acctg", "officeheadpersonnel", "officeheadpos", "officename", "officedescription", "officeaccronym"}
        Dim columns() = {"Acct. Code", "Office Head", "Position", "Office", "Description", "Accronym"}
        Dim cols() = {"id", "officeid", "officetypeid", "usersprofileid", "mandatory_aipcode", "officecode_pbo", "open_office", "subcategoryid", "officeadd", "logdate"}
        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_RenameColumn(DataGridView1, oldcolumns, columns)

        Dim myImage As Image = My.Resources.pencil
        Add_GridImageButton(DataGridView1, "Edit", myImage, "ImgDGBtn1", DataGridView1.Columns.Count - 1, 50)
        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick
    End Sub

    Private Sub Header_Accounts()
        DataGridView1.Columns("officecode_acctg").Width = 50
        DataGridView1.Columns("officeheadpersonnel").Width = 150
        DataGridView1.Columns("officeheadpos").Width = 150
        DataGridView1.Columns("officename").Width = 150
        DataGridView1.Columns("officedescription").Width = 130
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
                    Dim officehead As String = DataGridView1.Rows(e.RowIndex).Cells("officeheadpersonnel").Value.ToString
                    Dim officepos As String = DataGridView1.Rows(e.RowIndex).Cells("officeheadpos").Value.ToString
                    Dim officename As String = DataGridView1.Rows(e.RowIndex).Cells("officename").Value.ToString
                    Dim officedescription As String = DataGridView1.Rows(e.RowIndex).Cells("officedescription").Value.ToString
                    Dim officeaccronym As String = DataGridView1.Rows(e.RowIndex).Cells("officeaccronym").Value.ToString
                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("id", id)
                    columnValues.Add("officecode_acctg", $"'{officecode_acctg}'")
                    columnValues.Add("officeheadpersonnel", $"""{officehead}""")
                    columnValues.Add("officeheadpos", $"""{officepos}""")
                    columnValues.Add("officename", $"""{officename}""")
                    columnValues.Add("officedescription", $"""{officedescription}""")
                    columnValues.Add("officeaccronym", $"'{officeaccronym}'")
                    mySql.MySql_ExecuteNonQueryString("gl_offices", columnValues, $"id={id}", 2)
                    CustomMsg("Update ", "Update Successful")
                    Dim form = New Office
                    Form1.ShowForm(form)
                    Form1.Activate()
                End If

            End If

        End If
    End Sub
    Dim searchint As Boolean = False
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
                Select Case Typesearchtxt.Text
                    Case "Office"
                        conditions.Add(New LinQCondition With {
                        .Column = "officename",
                        .Value = Searchtxt.Text,
                        .ComparisonType = ComparisonTypeEnum.Like_enum
                    })
                    Case "Accronym"
                        conditions.Add(New LinQCondition With {
                        .Column = "officeaccronym",
                        .Value = Searchtxt.Text,
                        .ComparisonType = ComparisonTypeEnum.Like_enum
                    })
                End Select
                filteredDataTable = Linq_Query(OfficeDT, conditions)
                DataGridView1.DataSource = filteredDataTable
            ElseIf Searchtxt.Text = "" Then
                Custom_LoadOffice()
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub
    Public Shared officename
    Public Shared officeid

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class