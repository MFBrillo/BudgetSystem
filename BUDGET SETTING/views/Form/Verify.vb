Public Class Verify
    Public Sub ShowForm(ByVal form As Form)                      'Clear panel and add form projects/modules
        Submain.Controls.Clear()
        form.TopLevel = False
        Submain.Controls.Add(form)
        form.Size = Submain.Size
        form.Show()
    End Sub
    Public Sub ShowUserControl(ByVal uc As UserControl)                      'Clear panel and add form projects/modules
        Submain.Controls.Clear()
        Submain.Controls.Add(uc)
        uc.Size = Submain.Size
        uc.Show()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Me.Close()
        'OpaquePrompt.Close()
        Form1.Enabled = True
        Form1.Activate()
    End Sub
    Public userControl As UserControl
    Public SubMenu As Integer = 0
#Region "Sub SelectMenu"
    Public form As Form
    Public Shared budgetAppropriation As Integer = 0
    Sub SelectMenu(ByVal sender As String)
        Select Case sender     'Get BunifuFlatButton Text Property
            Case "Accountbtn"
                Dim uc = New AccountUC
                ShowUserControl(uc)
            Case "Officebtn"
                Dim uc = New OfficeUC
                ShowUserControl(uc)
        End Select
    End Sub
#End Region
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Accountbtn.Click, Officebtn.Click
        SelectMenu(sender.Name)
    End Sub

    Private Sub Submain_Paint(sender As Object, e As PaintEventArgs) Handles Submain.Paint

    End Sub
End Class