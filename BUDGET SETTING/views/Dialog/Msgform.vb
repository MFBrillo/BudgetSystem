Public Class Msgform
    Private Sub CloseNow_Click(sender As Object, e As EventArgs) Handles CloseNow.Click
        TitleText.Visible = False
        Me.Dispose()
    End Sub

    Private Sub BunifuGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel2.Paint

    End Sub
    Private Sub Msgform_Load(sender As Object, e As EventArgs) Handles Me.Load
        AppName.Text = My.MySettings.Default.AppName
        CloseNow.Focus()
    End Sub
    Private Sub CloseNow_KeyDown(sender As Object, e As KeyEventArgs) Handles CloseNow.KeyDown
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

    Private Sub MsgText_Click(sender As Object, e As EventArgs) Handles MsgText.Click

    End Sub
End Class