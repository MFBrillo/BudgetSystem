Public Class Programs
    Public ProgramDT As DataTable
    Public OfficeDT As DataTable
    Public VIOfficeDT As DataTable
    Public VISector As DataTable
    Public VISubsector As DataTable
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        VIOfficeDT = SqlLoad.MySql_SelectString("*", "vi_moises_offices")
        VISector = SqlLoad.MySql_SelectString("*", "vi_moises_sectors",, $"where sectorguideid='{sectorguideid}'")
        DataGridView1.DataSource = SqlLoad.MySql_SelectString("*", "vi_moises_spcprogramslists", Nothing,)
        Dim cols() = {"ID"}
        Datagrid_HideColumn(DataGridView1, cols)
    End Sub
    Sub Custom_Load2()
        Dim SqlLoad As New MySQLCore
        'VIOfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        DataGridView2.DataSource = SqlLoad.MySql_SelectString("*", "vi_moises_offices", Nothing,)
        Dim cols() = {"ID", "TYPE", "BUDGET CODE", "ACCT. CODE", "DESCRIPTION", "ACCRONYM"}
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub
    Private Sub Programs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        Custom_ComboBoxDatasource(Sectoridcbb, VISector, "sectorname", "sectorname")
    End Sub
    Public LastProgcode As DataTable
    Public Shared subsectorid
    Public Shared progcode
    Public Shared progid
    Public Shared sectorid
    Sub Autoprogramcode()
        Dim SqlLoad As New MySQLCore
        ProgramDT = SqlLoad.MySql_SelectString("programcode", "gl_spcprogramslists", Nothing, $"where subcategoryid ='{subsectorid}'")
        If ProgramDT.Rows.Count > 0 AndAlso Not IsDBNull(ProgramDT.Rows(0)("programcode")) Then
            LastProgcode = SqlLoad.MySql_SelectString("accountid", "gl_accounts", Nothing, $"where subcategoryid ='{subsectorid}'", "order by id desc", "limit 1")
            Dim newcategoryID As Integer = Convert.ToInt32(ProgramDT.Rows(0)("accountid"))
            If LastProgcode.Rows.Count = 0 OrElse IsDBNull(LastProgcode.Rows(0)("accountid")) Then
                Programidtxt.Text = newcategoryID
            Else
                If LastProgcode.Rows.Count > 0 AndAlso Not IsDBNull(LastProgcode.Rows(0)("accountid")) Then
                    Dim newlastcategoryID As Integer = Convert.ToInt32(LastProgcode.Rows(0)("accountid"))
                    Programidtxt.Text = newlastcategoryID + 1
                End If
            End If
        Else
            Try
                Programidtxt.Text = Convert.ToInt32(subsectorid + "01")
            Catch ex As Exception

            End Try
        End If
    End Sub
    Public officeid
    Public officename
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
        VISubsector = SqlLoad.MySql_SelectString("MIN(id) as ID, sectorid, subsectorname", "vi_moises_subsectors", , $"where sectorid={sectorid}", "GROUP BY sectorid, subsectorname", "ORDER BY id")
        Custom_ComboBoxDatasource(Subsectoridcbb, VISubsector, "subsectorname", "subsectorname")
    End Sub
    Private Sub Subsectoridcbb_DropDown(sender As Object, e As EventArgs) Handles Subsectoridcbb.DropDown
        subsector()
    End Sub
    Private Sub Sectoridcbb_DropDownClosed(sender As Object, e As EventArgs) Handles Sectoridcbb.DropDownClosed
        Custom_Load2()
        Dim conditions As New List(Of LinQCondition)()
        conditions.Add(New LinQCondition With {
                .Column = "sectorname",
                .Value = Sectoridcbb.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            })
        Dim sectorid1 As DataTable = Linq_Query(VISector, conditions)
        sectorid = sectorid1.Rows(0).Item("ID").ToString
        sectoridtxt.Text = sectorid
    End Sub
    Private Sub Subsectoridcbb_DropDownClosed(sender As Object, e As EventArgs) Handles Subsectoridcbb.DropDownClosed
        Custom_Load2()
        Dim conditions As New List(Of LinQCondition)()
        conditions.Add(New LinQCondition With {
                .Column = "subsectorname",
                .Value = Subsectoridcbb.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            })
        Dim subsectorid1 As DataTable = Linq_Query(VISubsector, conditions)
        subsectorid = subsectorid1.Rows(0).Item("ID").ToString
        Subsectoridtxt.Text = subsectorid
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class
