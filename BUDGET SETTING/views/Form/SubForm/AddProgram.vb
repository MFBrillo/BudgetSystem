Public Class AddProgram
    Public ProgramDT As DataTable
    Public VIOfficeDT As DataTable
    Dim programname = Programs.addprogram2
    Dim officeid
    Dim officename
    Dim sectorid = Programs.sectorid
    Dim subsectorid = Programs.subsectorid
    Dim progid = Programs.progid
    Dim programcode = Programs.programcode
    Dim update1 = 1
    Private Sub AddProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlLoad As New MySQLCore
        'MsgBox(accountcode)
        ProgramDT = SqlLoad.MySql_SelectString("*", "gl_spcprogramslists")
        VIOfficeDT = SqlLoad.MySql_SelectString("*", "vi_moises_offices")
        If Programs.progid IsNot Nothing Then
            sectorlbl.Text = sectorid
            subsectoridlbl.Text = subsectorid
            progidlbl.Text = progid
            programcodelbl.Text = programcode
            sectorguidedlbl.Text = sectorguideid
            updatelbl.Text = update1
            programnamelbl.Text = programname
            Programnametxt.Text = programname
        Else
            MsgBox("Please Choose Account to Edit")
            OpaquePrompt.Close()
            Me.Close()
            Form1.Activate()
        End If
    End Sub
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
    End Sub
    Sub Custom_Load2()
        Dim SqlLoad As New MySQLCore
        DataGridView2.DataSource = SqlLoad.MySql_SelectString("*", "vi_moises_offices")
        Dim cols() = {"ID", "TYPE", "BUDGET CODE", "ACCT. CODE", "DESCRIPTION", "ACCRONYM"}
        Datagrid_HideColumn(DataGridView2, cols)
    End Sub
    Private Sub Nametxt_OnValueChanged(sender As Object, e As EventArgs) Handles Officenametxt.OnValueChanged
        DataGridView2.Visible = True
        Custom_Load2()
        Try
            If VIOfficeDT IsNot Nothing Then
                Dim conditions As New List(Of LinQCondition)()
                conditions.Add(New LinQCondition With {
                .Column = "NAME",
                .Value = Officenametxt.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            })
                Dim filteredDataTable1 As DataTable = Linq_Query(VIOfficeDT, conditions)
                DataGridView2.DataSource = filteredDataTable1
                'Officenametxt.Text = filteredDataTable1.Rows(0).Item("ID").ToString
            End If
        Catch ex As Exception
            'MsgBox("Data Not Find",, "Input Error")
            CustomMsg("Input Error", "Data Not Find")
            Officenametxt.Text = ""
        End Try
        Descriptiontxt.Text = Programnametxt.Text + " - " + Officenametxt.Text
    End Sub
    Private Sub Officenametxt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Officenametxt.MouseDoubleClick
        'Descriptiontxt.Text = Programnametxt.Text + "-" + Officenametxt.Text
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
        Officenametxt.Text = officename
        officeidlbl.Text = officeid
        DataGridView2.Visible = False
    End Sub
    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class