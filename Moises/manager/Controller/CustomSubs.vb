Module CustomSubs
    Public Sub CustomMsg(ByVal Title As String, ByVal Message As String, Optional ByVal BtnText As String = "Close Now")
        Msgform.MsgText.Text = Message
        Msgform.TitleText.Text = Title
        Msgform.MsgText.Visible = True
        Msgform.TitleText.Visible = True
        Msgform.CloseNow.Text = BtnText
        Msgform.ShowDialog()
    End Sub

    Public Sub ClearFields(ByVal container As Object)
        Dim xControl As Control
        For Each xControl In container.Controls
            If (TypeOf xControl Is TextBox) Or (TypeOf xControl Is ComboBox) Or (TypeOf xControl Is DateTimePicker) Then
                xControl.Text = ""
            End If

            If (TypeOf xControl Is ListBox) Then
                Dim list As New ListBox
                list = xControl
            End If

            If (TypeOf xControl Is ComboBox) Then
                Dim Combo As ComboBox = xControl
                Combo.SelectedIndex = -1
            End If
        Next
    End Sub

    Public Sub ClearDGV(ByVal grid As DataGridView)
        grid.DataSource = Nothing
        grid.Refresh()
    End Sub

    Public Sub Datagrid_HideColumn(ByVal grid As DataGridView, ByVal cols As String())
        For Each col In cols
            If grid.Columns.Contains(col) Then grid.Columns(col).Visible = False
        Next
    End Sub

    Public Sub Custom_ComboBoxDatasource(ByVal combo As ComboBox, ByVal dt As DataTable, ByVal DisplayMember As String, ByVal ValueMember As String, Optional ByVal selectedindex As Integer = -1)
        With combo
            .DataSource = dt
            .DisplayMember = DisplayMember
            .ValueMember = ValueMember
            .SelectedIndex = selectedindex
        End With
    End Sub

    Public Sub GotoMousePointer(targetControl As Control)
        Dim targetLocation As Point = targetControl.PointToScreen(New Point(targetControl.Width / 2, targetControl.Height / 2))
        Cursor.Position = targetLocation
    End Sub

    'This will create a button to datagridview
    Friend Sub Add_GridButton(ByVal grid As DataGridView, ByVal header As String, ByVal btnText As String, ByVal btnName As String, ByVal displayedIndex As Integer, Optional btnwidth As Integer = 80)
        Dim btn As New DataGridViewButtonColumn With {
            .HeaderText = header,
            .Text = btnText,
            .Name = btnName,
            .Width = btnwidth,
            .UseColumnTextForButtonValue = True
        }
        btn.DefaultCellStyle.ForeColor = Color.Black
        btn.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(51, 153, 255)

        If grid.Columns.Contains(btnName) = False Then grid.Columns.Add(btn)
        Try
            grid.Columns(btnName).DisplayIndex = displayedIndex
            AddHandler grid.RowPostPaint, Sub(s, e)
                                              btn.Width = btnwidth
                                          End Sub
        Catch ex As Exception
            CustomMsg("Error found!", Err.Description)
        End Try

    End Sub

    Friend Sub Add_GridText(ByVal DataGridViewName As DataGridView, ByVal ColumnControl As List(Of DataGridViewColumn))
        For i = 0 To ColumnControl.Count - 1
            DataGridViewName.Columns.Add(ColumnControl(i))
        Next
    End Sub

    Friend Sub Add_GridObj(datagrid As DataGridView, Controls As List(Of DataGridViewColumn))
        For i = 0 To Controls.Count - 1
            datagrid.Columns.Add(Controls(i))
        Next
    End Sub

    Friend Sub Set_GridColWidth(column As Dictionary(Of String, Integer), datagrid As DataGridView)
        If column IsNot Nothing Then
            For i As Integer = 0 To column.Count - 1
                Dim col = column.ElementAt(i).Key.ToString
                Dim colwidth = column.ElementAt(i).Value
                datagrid.Columns(col).Width = colwidth
            Next
        End If
    End Sub

    Friend Sub SetMousePointerToNextObject(targetControl As Control)
        Dim targetLocation As Point = targetControl.PointToScreen(New Point(targetControl.Width / 2, targetControl.Height / 2))
        Cursor.Position = targetLocation
    End Sub


End Module
