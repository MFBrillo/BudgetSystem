Imports System.Text.RegularExpressions
Public Class AddOffice
    Public OfficeTypeDT As DataTable
    Public OfficeDT As DataTable
    Public Saveupdate As Integer
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Dim SqlLoad As New MySQLCore
        If Saveupdate = 1 Then
            OfficeDT = SqlLoad.MySql_SelectString("officeid", "gl_offices", Nothing, Nothing, "order by id desc", "limit 1")
            Dim lastofficeid As Integer = Convert.ToInt32(OfficeDT.Rows(0)("officeid"))
            Dim newofficeid As Integer
            newofficeid = lastofficeid + 1
            OpaquePrompt.Show()
            CustomYesNoPrompt("Save Entries", "Do you want to save changes")
            If YesNoPrompt.YesOption = True Then
                Try
                    Dim mySql As New MySQLCore
                    Dim columnValues As New Dictionary(Of String, String)
                    columnValues.Add("officeid", newofficeid)
                    columnValues.Add("officetypeid", officetypeid)
                    columnValues.Add("officecode_pbo", PBOCodetxt.Text)
                    columnValues.Add("mandatory_aipcode", AIPCodetxt.Text)
                    columnValues.Add("officecode_acctg", AccountingCodeTxt.Text)
                    columnValues.Add("officeaccronym", Accronymtxt.Text)
                    columnValues.Add("officename", Nametxt.Text)
                    columnValues.Add("officedescription", Descriptiontxt.Text)
                    mySql.MySql_ExecuteNonQueryString("gl_offices", columnValues, Nothing, 1)
                Catch ex As Exception
                    MsgBox("ERROR" & ex.Message)
                End Try

            End If
            OpaquePrompt.Close()
            Form1.Activate()
        ElseIf Saveupdate = 2 Then
            OfficeDT = SqlLoad.MySql_SelectString("officeid", "gl_offices",, "where")
            OpaquePrompt.Show()
            CustomYesNoPrompt("Update Data", "Do you want to save changes")
            'If YesNoPrompt.YesOption = True Then
            '    Try
            '        Dim mySql As New MySQLCore
            '        Dim columnValues As New Dictionary(Of String, String)
            '        columnValues.Add("officeid", lastofficeid)
            '        columnValues.Add("officetypeid", officetypeid)
            '        columnValues.Add("officecode_pbo", PBOCodetxt.Text)
            '        columnValues.Add("mandatory_aipcode", AIPCodetxt.Text)
            '        columnValues.Add("officecode_acctg", AccountingCodeTxt.Text)
            '        columnValues.Add("officeaccronym", Accronymtxt.Text)
            '        columnValues.Add("officename", Nametxt.Text)
            '        columnValues.Add("officedescription", Descriptiontxt.Text)
            '        mySql.MySql_ExecuteNonQueryString("gl_offices", columnValues, Nothing, 2)
            '    Catch ex As Exception
            '        MsgBox("ERROR" & ex.Message)
            '    End Try

            'End If
        End If
    End Sub
    Sub Custom_Load()
        Dim SqlLoad As New MySQLCore
        OfficeTypeDT = SqlLoad.MySql_SelectString("*", "vi_office_type")
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
    End Sub

    Public Shared assetidOfficeTypeid
    Private Sub AddOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_Load()
        Custom_ComboBoxDatasource(Officetypetxt, OfficeTypeDT, "officetype", "officetype")
    End Sub

    Private Function GetInitials(inputText As String) As String
        Dim words As String() = Regex.Split(inputText, "\s+")
        Dim initials As String = String.Join("", words.Select(Function(word) word.Substring(0, 1)))
        Return initials.ToUpper()
    End Function
    Sub lastnumber()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("officeid", "gl_offices", Nothing, Nothing, "order by id desc", "limit 1")
        Dim lastofficeid As Integer = Convert.ToInt32(OfficeDT.Rows(0)("officeid"))
        Dim newofficeid As Integer
        newofficeid = lastofficeid + 1

    End Sub
    Private Sub Nametxt_OnValueChanged(sender As Object, e As EventArgs) Handles Nametxt.OnValueChanged
        Dim inputText As String = Nametxt.Text.Trim()
        Dim initials As String = GetInitials(inputText)
        Accronymtxt.Text = initials
    End Sub
    Dim officetypeid
    Private Sub Officetypetxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Officetypetxt.SelectedIndexChanged
        Try

            Dim SqlLoad As New MySQLCore
            Dim dt = SqlLoad.MySql_SelectString("officetypeid", "gl_officetype", , $"where officetype ='{Officetypetxt.Text}'")
            officetypeid = dt.Rows(0).Item("officetypeid").ToString
        Catch ex As Exception

        End Try
    End Sub
End Class