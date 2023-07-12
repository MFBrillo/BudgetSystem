﻿Public Class Form1
    Friend menu_width As Integer            'Menu width when click
    Friend colapsed_width As Integer

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
            Chartbtn.TextAlign = ContentAlignment.MiddleCenter
            Sectorbtn.TextAlign = ContentAlignment.MiddleCenter
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
            Chartbtn.TextAlign = ContentAlignment.MiddleLeft
            Sectorbtn.TextAlign = ContentAlignment.MiddleLeft

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
                'Case "RegularBtn"
                '    Dim uc = New RegularAccounts
                '    ShowUserControl(uc)
                'Case "Categorybtn"
                '    Dim uc = New CategorySubcategory
                '    ShowUserControl(uc)
                'Case "Fundsbtn"
                '    Dim uc = New FundsSpecialFunds
                '    ShowUserControl(uc)
                'Case "Registrybtn"
                '    Dim uc = New RegistryAsset
                '    ShowUserControl(uc)
                'Case "Sectorbtn"
                '    Dim uc = New SectorSubsector
                '    ShowUserControl(uc)
        End Select
    End Sub

#End Region
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Fundsbtn.Click, Sectorbtn.Click, Chartbtn.Click
        SelectMenu(sender.Name)
    End Sub

    Private Sub MenuController_Paint(sender As Object, e As PaintEventArgs) Handles MenuController.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class
