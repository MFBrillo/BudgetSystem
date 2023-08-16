Public Class AccountDescription
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
    End Sub
    Private Sub AccountDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nametxt.Text = ChartofAccounts.accountdescriptiontxt
        'Codetxt.Text = ChartofAccounts.accountcode
        Dim input As String = ChartofAccounts.accountcode
        ' Remove hyphens from the input
        Dim result As String = input.Replace("-", "")
        Codetxt.Text = result
    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Dim SqlLoad As New MySQLCore
        OpaquePrompt.Show()
        CustomYesNoPrompt("Save Entries", "Do you want to save changes")
        If YesNoPrompt.YesOption = True Then

            'If Descriptiontxt.Text = "" Then
            '    CustomMsg("Save Record Failed", "Insert Correct Data.", "OK")
            'Else
            '    Try
            '        Dim mySql As New MySQLCore
            '        Dim columnValues As New Dictionary(Of String, String)
            '        columnValues.Add("assetid", assetid)
            '        columnValues.Add("categoryid", categoryid)
            '        columnValues.Add("subcategoryid", subcategoryid)
            '        columnValues.Add("accountname", Accountnametxt.Text)
            '        columnValues.Add("accountid", AccountIDtxt.Text)
            '        columnValues.Add("accountdescription", Decriptiontxt.Text)
            '        columnValues.Add("accountcode", AccountCodetxt.Text)
            '        mySql.MySql_ExecuteNonQueryString("gl_accounts", columnValues, Nothing, 1)
            '    Catch ex As Exception
            '        MsgBox("ERROR" & ex.Message)
            '    End Try

            'End If
            Form1.Activate()
            Me.Close()
        Else
            OpaquePrompt.Close()
            Me.Close()
            Form1.Activate()
        End If
    End Sub
End Class