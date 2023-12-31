﻿Public Class Form1
    Friend menu_width As Integer            'Menu width when click
    Friend colapsed_width As Integer
    Public formattedDate As String = currentDate.ToString("MMMM d, yyyy")
    Dim formattedTime As String = currentDate.ToString("hh:mm:ss tt")
#Region "MenuSize()"   'Set Form Size
    Public Sub MenuSize(ByVal menuwidth As Integer, colapsedwidth As Integer, ByVal form As Form)
        form.Bounds = Screen.GetWorkingArea(form.Bounds)
        menu_width = menuwidth                 'Assign new menu, open based on container
        colapsed_width = colapsedwidth              'Assign new menu colapse size
    End Sub
#End Region
#Region "MaximizeNormalForm()"  'Form Maximize and Restore
    Sub MaximizeNormalForm(form As Form)
        If form.WindowState = FormWindowState.Maximized Then
            form.WindowState = FormWindowState.Normal
        Else
            form.Bounds = Screen.GetWorkingArea(form.Bounds)    'Assign new bounds (size)
        End If
    End Sub
#End Region
#Region "ShowForm()"    'Show Form on click
    Public Sub ShowForm(ByVal form As Form)                      'Clear panel and add form projects/modules
        MainPanel.Controls.Clear()
        form.TopLevel = False
        MainPanel.Controls.Add(form)
        form.Size = MainPanel.Size
        form.Show()
    End Sub
    Public Sub ShowUserControl(ByVal uc As UserControl)                      'Clear panel and add form projects/modules
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(uc)
        uc.Size = MainPanel.Size
        uc.Show()
    End Sub
#End Region
#Region "Menu_OnClick"  'Menu On Click change width and colapse width
    Sub Menu_OnClick()
        If MenuController.Width <> colapsed_width Then
            MenuController.Width = colapsed_width
            Officebtn.TextAlign = ContentAlignment.MiddleCenter
            Settingbtn.TextAlign = ContentAlignment.MiddleCenter
            Try
                If userControl IsNot Nothing Then
                    userControl.Size = New Size(MainPanel.Size)
                    userControl.Refresh()
                End If
                If form IsNot Nothing Then
                    form.Size = New Size(MainPanel.Size)                 'Assigns Dashboard form width based on container
                    form.Refresh()
                End If
            Catch ex As Exception
                Err.Clear()
            End Try
        ElseIf MenuController.Width = colapsed_width Then
            MenuController.Width = menu_width
            Officebtn.TextAlign = ContentAlignment.MiddleLeft
            Settingbtn.TextAlign = ContentAlignment.MiddleLeft
            Try
                If userControl IsNot Nothing Then
                    userControl.Size = New Size(MainPanel.Size)
                    userControl.Refresh()
                End If
                If form IsNot Nothing Then
                    form.Size = New Size(MainPanel.Size)                 'Assigns Dashboard form width based on container
                    form.Refresh()
                End If                                                  'Read comment above
            Catch ex As Exception
                Err.Clear()
            End Try
        End If
    End Sub
#End Region
    Public userControl As UserControl
    Public SubMenu As Integer = 0
#Region "Sub SelectMenu"
    Public form As Form
    Public Shared budgetAppropriation As Integer = 0
    Sub SelectMenu(ByVal sender As String)
        Select Case sender     'Get BunifuFlatButton Text Property
            Case "Chartbtn"
                Dim uc = New ChartofAccounts
                ShowUserControl(uc)
            Case "Settingbtn"
                Dim uc = New ChartAccountSettingUC
                ShowUserControl(uc)
            Case "Officebtn"
                Dim form = New Office
                ShowForm(form)

        End Select
    End Sub
#End Region
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Settingbtn.Click, Officebtn.Click, Chartbtn.Click
        SelectMenu(sender.Name)
    End Sub

    Private Sub Verifybtn_Click(sender As Object, e As EventArgs)
        'Me.Enabled = False
        'OpaquePrompt.Show()
        Verify.ShowDialog()
        Verify.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCNamelbl.Text = my_pcName
        InitializeTables.Main()
        'InitializeTables.Is_Login()
        InitializeTables.sectorguide()
        Datelbl.Text = formattedDate
        UpdateTime()
        Timer1.Start()

        Dim uc = New ChartofAccounts
        ShowUserControl(uc)

    End Sub
    Private Sub Statuslbl_TextChanged(sender As Object, e As EventArgs) Handles Statuslbl.TextChanged
        If Statuslbl.Text = "Online" Then
            Statuslbl.ForeColor = Color.Green
        Else
            Statuslbl.ForeColor = Color.Red
        End If
    End Sub



    Private Sub MenuController_Paint(sender As Object, e As PaintEventArgs) Handles MenuController.Paint

    End Sub

    Private Sub MainPanel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTime()
    End Sub



    Private Sub UpdateTime()
        ' Get the current time and format it
        Dim currentTime As DateTime = DateTime.Now
        Dim formattedTime As String = currentTime.ToString("hh:mm:ss tt")

        ' Update the label text with the formatted time
        Timelbl.Text = formattedTime
    End Sub



    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Dispose()
    End Sub
End Class
