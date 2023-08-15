Public Class AccountDescription
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        OpaquePrompt.Close()
        Me.Close()
        Form1.Activate()
    End Sub
End Class