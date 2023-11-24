Imports System.Windows.Forms
Public Class Verify


    Public Sub ShowForm(ByVal form As Form)                      'Clear panel and add form projects/modules
        Programlbl.Controls.Clear()
        form.TopLevel = False
        Programlbl.Controls.Add(form)
        form.Size = Programlbl.Size
        form.Show()
    End Sub
    Public Sub ShowUserControl(ByVal uc As UserControl)                      'Clear panel and add form projects/modules
        Programlbl.Controls.Clear()
        Programlbl.Controls.Add(uc)
        uc.Size = Programlbl.Size
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

#End Region
    Private Sub Submain_Paint(sender As Object, e As PaintEventArgs) Handles Programlbl.Paint
    End Sub
    Private Sub Verify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard()
    End Sub

    Public Sub Dashboard()
        Dim SqlLoad As New MySQLCore

        Dim officetxt = SqlLoad.MySql_SelectString("COUNT(*) rowcount", "gl_offices")
        Officelbl.Text = officetxt.Rows(0).Item("rowcount").ToString

        Dim accounttxt = SqlLoad.MySql_SelectString("COUNT(*) rowcount", "gl_accounts")
        Accountlbl.Text = accounttxt.Rows(0).Item("rowcount").ToString

        Dim grouptxt = SqlLoad.MySql_SelectString("COUNT(*) rowcount", "gl_assets")
        Grouplbl.Text = grouptxt.Rows(0).Item("rowcount").ToString

        Dim majortxt = SqlLoad.MySql_SelectString("COUNT(*) rowcount", "gl_assets_category")
        Majorlbl.Text = majortxt.Rows(0).Item("rowcount").ToString

        Dim subtxt = SqlLoad.MySql_SelectString("COUNT(*) rowcount", "gl_assets_subcategory")
        Sublbl.Text = subtxt.Rows(0).Item("rowcount").ToString

        'Dim dt = SqlLoad.MySql_SelectString("assetid", "gl_assets", , $"where asset ='{AssetIDTxt.Text}'")
        'assetid = dt.Rows(0).Item("assetid").ToString
    End Sub
    Public Sub LoadString()

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the user wants to close the form
        If MessageBox.Show("Do you want to close this window?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            ' Cancel the form closing event if the user selects "No"
            e.Cancel = True
            InitializeTables.Main()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        ' Check if the pressed key is the "Esc" key
        If keyData = Keys.Escape Then
            ' Close the form when "Esc" key is pressed
            Me.Close()
            Return True ' Return True to indicate that the key press has been handled
        End If

        ' Call the base class's method for any other key press
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class