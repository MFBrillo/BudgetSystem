Public Class YesNoPrompt
    Private Sub Msgform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppName.Text = My.MySettings.Default.AppName
        YesBtn.Focus()
    End Sub
    Private Sub CloseNow_Click(sender As Object, e As EventArgs)
        TitleText.Visible = False
        Me.Dispose()
    End Sub

    Private Sub CloseNow_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TitleText.Visible = False
            Me.Dispose()
        End If

    End Sub

    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If i = 2 Then
            TitleText.Visible = False
            Timer1.Enabled = False
            Me.Dispose()
        End If
    End Sub
    Public Shared YesOption As Boolean = 0, NoOption As Boolean = 0
    Private Sub YesBtn_Click(sender As Object, e As EventArgs) Handles YesBtn.Click
        YesOption = True
        NoOption = False
        Me.Dispose()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub NoBtn_Click(sender As Object, e As EventArgs) Handles NoBtn.Click
        NoOption = True
        YesOption = False
        Me.Dispose()
    End Sub

    Private Sub BunifuGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel2.Paint

    End Sub

    Private Sub MsgText_Click(sender As Object, e As EventArgs) Handles MsgText.Click

    End Sub

    Private Sub YesNoPrompt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        OpaquePrompt.Dispose()
    End Sub
End Class