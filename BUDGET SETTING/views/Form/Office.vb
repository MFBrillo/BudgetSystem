Public Class Office
    Public OfficeDT As DataTable
    Friend Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        DataGridView1.DataSource = OfficeDT
        Dim oldcolumns() = {"officetypeid", "officecode_pbo", "officecode_acctg", "officename", "officedescription", "officeaccronym"}
        Dim newcolumns() = {"Office Type", "Office Code PBO", "Office Code Accounting", "Office Name", "Office Description", "Office Accronym"}
        Dim cols() = {"id", "officeid", "mandatory_aipcode", "logdate", "open_office"}
        Datagrid_HideColumn(DataGridView1, cols)
        Datagrid_RenameColumn(DataGridView1, oldcolumns, newcolumns)
        Header_Accounts()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
    End Sub
    Private Sub Header_Accounts()
        DataGridView1.Columns("officetypeid").Width = 100
        DataGridView1.Columns("officecode_pbo").Width = 100
        DataGridView1.Columns("officecode_acctg").Width = 100
        DataGridView1.Columns("officeaccronym").Width = 120
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Officetypetxt.Text = DataGridView1.Rows(e.RowIndex).Cells("officetypeid").Value.ToString()
        AIPtxt.Text = DataGridView1.Rows(e.RowIndex).Cells("mandatory_aipcode").Value.ToString()
        OfficePBOtxt.Text = DataGridView1.Rows(e.RowIndex).Cells("officecode_pbo").Value.ToString()
        OfficeAccountingtxt.Text = DataGridView1.Rows(e.RowIndex).Cells("officecode_acctg").Value.ToString()
        OfficeAccrotxt.Text = DataGridView1.Rows(e.RowIndex).Cells("officeaccronym").Value.ToString()
        Officenametxt.Text = DataGridView1.Rows(e.RowIndex).Cells("officename").Value.ToString()
        OfficeDesctxt.Text = DataGridView1.Rows(e.RowIndex).Cells("officedescription").Value.ToString()
    End Sub
End Class