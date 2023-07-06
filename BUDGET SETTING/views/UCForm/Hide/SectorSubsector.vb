Public Class SectorSubsector
    Public SectorDT As DataTable
    Public SubsectorDT As DataTable
    Private Sub SectorSubsector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        SectorDT = SqlLoad.MySql_SelectString("*", "gl_sectors")
        SubsectorDT = SqlLoad.MySql_SelectString("*", "gl_subsectors")

        Dim columns1 = "sectorid, sectorcode, sectorguideid, sectorname, sectordescription"
        Dim columns2 = "subsectorid, sectorid, officeid, subsectorcode, subsectorname, subsectordescription"

        Dim table1 = "gl_sectors"
        Dim table2 = "gl_subsectors"

        DataGridView1.DataSource = SqlLoad.MySql_SelectString(columns1, table1)
        DataGridView2.DataSource = SqlLoad.MySql_SelectString(columns2, table2)

        Dim cols() = {"id", "logdate"}

        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub
End Class
