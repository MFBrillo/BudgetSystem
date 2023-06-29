Module LoaderController
    Public CloseLoader As Boolean

    Public Async Sub RunProcess(ByVal path As String)
        Try
            Await Task.Run(Sub()
                               Process.Start(path, "")
                           End Sub)

        Catch ex As Exception
            Err.Clear()
        End Try
    End Sub

    Public Async Sub KillProcess()
        Await Task.Run(Sub()
                           Application.Exit()
                       End Sub)
    End Sub

    Public Async Sub OpenLoaderForm(ByVal LoaderForm As Form)
        Await Task.Run(Sub()
                           CloseLoader = False

                           ' Set the text displayed in the caption.
                           LoaderForm.Text = "Loader Form"
                           ' Set the opacity to 75%.
                           LoaderForm.Opacity = 0.6
                           ' Size the form to be 300 pixels in height and width.
                           LoaderForm.Size = New Size(300, 300)
                           ' Display the form in the center of the screen.
                           LoaderForm.StartPosition = FormStartPosition.CenterScreen

                           ' Display the form as a modal dialog box.
                           LoaderForm.ShowDialog()
                       End Sub)
    End Sub

    Public Async Sub CloseLoaderForm()
        Await Task.Run(Sub() CloseLoader = True)
    End Sub

End Module
