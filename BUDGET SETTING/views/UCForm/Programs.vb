Public Class Programs
    Public ProgramDT As DataTable
    Public OfficeDT As DataTable
    Public VIOfficeDT As DataTable
    Public VIProgramDT As DataTable
    Public VISector As DataTable
    Public VISubsector As DataTable
    Public LastProgramDT As DataTable
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        VIProgramDT = SqlLoad.MySql_SelectString("*", "vi_moises_spcprogramslists")
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        ProgramDT = SqlLoad.MySql_SelectString("*", "gl_spcprogramslists")
        VIOfficeDT = SqlLoad.MySql_SelectString("*", "vi_moises_offices")
        VISector = SqlLoad.MySql_SelectString("*", "vi_moises_sectors",, $"where sectorguideid='{sectorguideid}'")
    End Sub
    Sub Custom_Load2()
        Dim SqlLoad As New MySQLCore
        DataGridView2.DataSource = SqlLoad.MySql_SelectString("*", "vi_moises_offices")
        Dim cols() = {"ID", "TYPE", "BUDGET CODE", "ACCT. CODE", "DESCRIPTION", "ACCRONYM"}
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub
    Private Sub Programs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        Custom_Load()
        Action()
        Custom_ComboBoxDatasource(Sectoridcbb, VISector, "sectorname", "sectorname")
        DataGridView1.DataSource = SqlLoad.MySql_SelectString("*", "vi_moises_spcprogramslists", Nothing,)
        Dim cols() = {"ID", "Program ID", "Sector ID", "Subsector ID"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub
    Public LastProgid As DataTable
    Public Shared subsectorid
    Public Shared programcode
    Public Shared progid
    Public Shared sectorid
    Public officeid
    Public officename
    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click

        Dim SqlLoad As New MySQLCore
        Dim columnValues As New Dictionary(Of String, String)
        columnValues.Add("progid", progid)
        columnValues.Add("sectorid", sectorid)
        columnValues.Add("subsectorid", subsectorid)
        columnValues.Add("officeid", officeid)
        columnValues.Add("sectorguideid", sectorguideid)
        columnValues.Add("programcode", $"'{Programcodetxt.Text}'")
        columnValues.Add("programname", $"'{Programnametxt.Text}'")
        columnValues.Add("programdescription", $"'{Programdescriptiontxt.Text}'")
        'columnValues.Add("programcode", $"'{AccountIDtxt.Text}'")
        SqlLoad.MySql_ExecuteNonQueryString("wap_spcprogramslists_temp", columnValues, Nothing, 1)

    End Sub
    Sub Autoprogramcode()
        Dim SqlLoad As New MySQLCore
        ProgramDT = SqlLoad.MySql_SelectString("programcode", "gl_spcprogramslists", Nothing, $"where subsectorid ='{subsectorid}'")
        If ProgramDT.Rows.Count > 0 AndAlso Not IsDBNull(ProgramDT.Rows(0)("programcode")) Then
            LastProgid = SqlLoad.MySql_SelectString("programcode", "gl_spcprogramslists", Nothing, $"where subsectorid ='{subsectorid}'", "order by id desc", "limit 1")

            Dim numbers() As Integer = (From row As DataRow In ProgramDT.Rows Select Convert.ToInt32(row("programcode"))).ToArray()
            Dim lowestNumber As Integer = numbers.Min()

            If LastProgid.Rows.Count = 0 OrElse IsDBNull(LastProgid.Rows(0)("programcode")) Then
                Programcodetxt.Text = (lowestNumber + 1).ToString("D3") ' Format as "001"
            Else
                If LastProgid.Rows.Count > 0 AndAlso Not IsDBNull(LastProgid.Rows(0)("programcode")) Then
                    Dim newlastcategoryID As Integer = Convert.ToInt32(LastProgid.Rows(0)("programcode"))

                    While Array.IndexOf(numbers, lowestNumber) >= 0
                        lowestNumber += 1
                    End While
                    Programcodetxt.Text = lowestNumber.ToString("D3") ' Format as "001"
                End If
            End If
        Else
            Try
                Programcodetxt.Text = (Convert.ToInt32(subsectorid) * 1000 + 1).ToString("D3") ' Format as "001"
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub Autoprogid()
        Dim SqlLoad As New MySQLCore
        ProgramDT = SqlLoad.MySql_SelectString("progid", "gl_spcprogramslists", Nothing, "order by progid desc", "limit 1")
        LastProgramDT = SqlLoad.MySql_SelectString("progid", "gl_spcprogramslists", Nothing, "order by progid desc", "limit 1")
        Dim newprogidID As Integer = Convert.ToInt32(ProgramDT.Rows(0)("progid"))
        progidlbl.Text = (newprogidID + 1)
        progid = (newprogidID + 1)
    End Sub
    Private Sub Officetxt_OnValueChanged(sender As Object, e As EventArgs) Handles Officetxt.OnValueChanged
        DataGridView2.Visible = True
        Custom_Load2()
        Try
            If VIOfficeDT IsNot Nothing Then
                Dim conditions As New List(Of LinQCondition)()
                conditions.Add(New LinQCondition With {
                .Column = "NAME",
                .Value = Officetxt.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            })
                Dim filteredDataTable1 As DataTable = Linq_Query(VIOfficeDT, conditions)
                DataGridView2.DataSource = filteredDataTable1
                officeidtxt.Text = filteredDataTable1.Rows(0).Item("ID").ToString
            End If
        Catch ex As Exception
            'MsgBox("Data Not Find",, "Input Error")
            CustomMsg("Input Error", "Data Not Find")
            Officetxt.Text = ""
        End Try
    End Sub
    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim searchrow As String
        searchrow = DataGridView2.Rows(e.RowIndex).Cells("NAME").Value.ToString()
        Custom_Load2()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "NAME",
                             .Value = searchrow,
                             .ComparisonType = ComparisonTypeEnum.Equal_enum}
        }
        Dim office As DataTable = Linq_Query(VIOfficeDT, conditions)
        officename = office.Rows(0).Item("NAME").ToString
        officeid = office.Rows(0).Item("ID").ToString
        Officetxt.Text = officename
        DataGridView2.Visible = False
    End Sub
    Sub subsector()
        Dim SqlLoad As New MySQLCore
        If sectorid IsNot Nothing Then
            VISubsector = SqlLoad.MySql_SelectString("MIN(subsectorid) as subsectorid,sectorid, subsectorname", "vi_moises_subsectors", , $"where sectorid={sectorid}", "GROUP BY  sectorid, subsectorname", "ORDER BY subsectorid")
            Custom_ComboBoxDatasource(Subsectoridcbb, VISubsector, "subsectorname", "subsectorname")
        End If
    End Sub
    Private Sub Subsectoridcbb_DropDown(sender As Object, e As EventArgs) Handles Subsectoridcbb.DropDown
        subsector()
    End Sub
    Private Sub Sectoridcbb_DropDownClosed(sender As Object, e As EventArgs) Handles Sectoridcbb.DropDownClosed
        Try
            If VISector IsNot Nothing Then
                Dim conditions As New List(Of LinQCondition)()
                conditions.Add(New LinQCondition With {
                        .Column = "sectorname",
                        .Value = Sectoridcbb.Text,
                        .ComparisonType = ComparisonTypeEnum.Like_enum
                    })
                Dim sectorid1 As DataTable = Linq_Query(VISector, conditions)
                sectorid = sectorid1.Rows(0).Item("sectorid").ToString
                sectoridtxt.Text = sectorid
            End If
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub
    Private Sub Subsectoridcbb_DropDownClosed(sender As Object, e As EventArgs) Handles Subsectoridcbb.DropDownClosed
        If sectorid IsNot Nothing Then
            Dim conditions As New List(Of LinQCondition)()
            conditions.Add(New LinQCondition With {
                        .Column = "subsectorname",
                        .Value = Subsectoridcbb.Text,
                        .ComparisonType = ComparisonTypeEnum.Like_enum
                    })
            Dim subsectorid1 As DataTable = Linq_Query(VISubsector, conditions)
            subsectorid = subsectorid1.Rows(0).Item("subsectorid").ToString
            Subsectoridtxt.Text = subsectorid
            Autoprogramcode()
            Autoprogid()
        Else
            CustomMsg("Invalid Data", "Please Choose Sector")
            Sectoridcbb.Focus()
        End If
    End Sub
    Sub Action()
        ActionCbb.Items.Add("Add Program")
        ActionCbb.Items.Add("Add Office in Program")
    End Sub
    Private Sub Descriptionbtn_Click(sender As Object, e As EventArgs) Handles Descriptionbtn.Click
        OpaquePrompt.Show()
        'AccountDescription.Nametxt.Text = accountdescriptiontxt
        AddProgram.ShowDialog()
    End Sub
    Public Shared addprogram2
    Private Sub Searchtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Searchtxt.OnValueChanged
        Try
            If VIProgramDT IsNot Nothing Then
                Dim conditions As New List(Of LinQCondition)()
                conditions.Add(New LinQCondition With {
                .Column = "Program Name",
                .Value = Searchtxt.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            })
                Dim filteredDataTable As DataTable = Linq_Query(VIProgramDT, conditions)
                DataGridView1.DataSource = filteredDataTable
                Custom_Load()
                addprogram2 = filteredDataTable.Rows(0).Item("Program Name").ToString
                'accountcode2 = filteredDataTable.Rows(0).Item("code").ToString
                'msgbox(accountcode2)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim searchrow As String
        searchrow = DataGridView1.Rows(e.RowIndex).Cells("Program Name").Value.ToString()
        Custom_Load()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "Program Name",
                             .Value = searchrow,
                             .ComparisonType = ComparisonTypeEnum.Equal_enum}
        }
        Dim programname As DataTable = Linq_Query(VIProgramDT, conditions)
        'accountdescription2 = accountname.Rows(0).Item("Account").ToString
        OpaquePrompt.Show()
        AddProgram.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim searchrow As String
        searchrow = DataGridView1.Rows(e.RowIndex).Cells("Program Name").Value.ToString()
        Custom_Load()
        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                             .Column = "Program Name",
                             .Value = searchrow,
                             .ComparisonType = ComparisonTypeEnum.Equal_enum}
     }
        Dim programname As DataTable = Linq_Query(VIProgramDT, conditions)
        addprogram2 = programname.Rows(0).Item("Program Name").ToString
        progid = programname.Rows(0).Item("Program ID").ToString
        sectorid = programname.Rows(0).Item("Sector ID").ToString
        programcode = programname.Rows(0).Item("Program Code").ToString
        subsectorid = programname.Rows(0).Item("Subsector ID").ToString
        'accountdescription2 = accountname.Rows(0).Item("Account").ToString
        'accountcode2 = accountname.Rows(0).Item("code").ToString
        'MsgBox(accountcode2)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
    'Public AddOffice As Boolean = 0
    'Sub SelectAction(ByVal sender As String)
    '    Select Case sender     'Get BunifuFlatButton Text Property
    '        Case "Add Program"
    '            MsgBox("Add Program")
    '            AddOffice = 0
    '        Case "Add Office in Program"
    '            MsgBox("Add Office in Program")
    '            AddOffice = 1
    '    End Select
    'End Sub
    'Private Sub ActionCbb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActionCbb.SelectedIndexChanged
    '    SelectAction(ActionCbb.Text)
    'End Sub
End Class
