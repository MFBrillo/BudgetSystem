Public Class ConnectionForm
    Sub loadData()
        Servernametxt.Text = My.MySettings.Default.Servername
        UsernameDbtxt.Text = My.MySettings.Default.Username
        PortAddresstxt.Text = My.MySettings.Default.Port
        PasswordDbtxt.Text = My.MySettings.Default.Password
        Databasenametxt.Text = My.MySettings.Default.Databasename
    End Sub
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub



    Private Sub Savebtn_Click_1(sender As Object, e As EventArgs) Handles Savebtn.Click
        OpaquePrompt.Show()
        CustomYesNoPrompt("Setting Change", "Do you want to save your Server and Application Details?")
        If YesNoPrompt.YesOption = True Then
            My.MySettings.Default.Servername = Servernametxt.Text
            My.MySettings.Default.Username = UsernameDbtxt.Text
            My.MySettings.Default.Port = PortAddresstxt.Text
            My.MySettings.Default.Password = PasswordDbtxt.Text
            My.MySettings.Default.Databasename = Databasenametxt.Text
            My.MySettings.Default.Save()
            Me.Close()
            End
        End If

    End Sub

    Private Sub ConnectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Private Sub Resettxt_Click(sender As Object, e As EventArgs) Handles Resettxt.Click
        ClearFields(Servernametxt)
        ClearFields(UsernameDbtxt)
        ClearFields(PortAddresstxt)
        ClearFields(PasswordDbtxt)
        ClearFields(Databasenametxt)
    End Sub
End Class