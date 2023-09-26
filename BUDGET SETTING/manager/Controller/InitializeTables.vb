Module InitializeTables
    Public gl_accounts As DataTable
    Public wap_accounts_temp As DataTable
    Public gl_assets As DataTable
    Public wap_assets_temp As DataTable
    Public gl_assets_category As DataTable
    Public wap_assets_category_temp As DataTable
    Public gl_assets_sub_category As DataTable
    Public wap_assets_subcategory_temp As DataTable
    Public gl_offices As DataTable
    Public wap_offices_temp As DataTable

    Public vi_accounts As DataTable
    Public vi_accounts_temp As DataTable
    Public vi_assets As DataTable
    Public vi_assets_temp As DataTable
    Public vi_assets_category As DataTable
    Public vi_assets_category_temp As DataTable
    Public vi_assets_sub_category As DataTable
    Public vi_assets_subcategory_temp As DataTable
    Public vi_offices As DataTable
    Public vi_offices_temp As DataTable
    Public islogin
    Public username
    Public accesslevel

    Public tbl_gl_accounts As String = "gl_accounts"
    Public isInitialized As Integer = 0
    Sub Main()
        Dim core = New MySQLCore
        gl_accounts = core.MySQL_Datatable("gl_accounts")
        'gl_accounts_temp = core.MySQL_Datatable("gl_accounts_temp")
        gl_assets = core.MySQL_Datatable("gl_assets")
        'gl_assets_temp = core.MySQL_Datatable("gl_assets_temp")
        gl_assets_category = core.MySQL_Datatable("gl_assets_category")
        'gl_assets_category_temp = core.MySQL_Datatable("gl_assets_category_temp")
        gl_assets_sub_category = core.MySQL_Datatable("gl_assets_subcategory")
        'gl_assets_subcategory_temp = core.MySQL_Datatable("gl_assets_subcategory_temp")
        'gl_offices = core.MySQL_Datatable("gl_offices")
        'gl_offices_temp = core.MySQL_Datatable("gl_offices_temp")

        'vi_accounts = core.MySQL_Datatable("vi_accounts")
        'vi_accounts_temp = core.MySQL_Datatable("vi_accounts_temp")
        'vi_assets = core.MySQL_Datatable("vi_assets")
        'vi_assets_temp = core.MySQL_Datatable("vi_assets_temp")
        'vi_assets_category = core.MySQL_Datatable("vi_assets_category")
        'vi_assets_category_temp = core.MySQL_Datatable("vi_assets_category_temp")
        'vi_assets_sub_category = core.MySQL_Datatable("vi_assets_sub_category")
        'vi_assets_subcategory_temp = core.MySQL_Datatable("vi_assets_subcategory_temp")
        'vi_offices = core.MySQL_Datatable("vi_offices")
        'vi_offices_temp = core.MySQL_Datatable("vi_offices_temp")
        isInitialized = 1
    End Sub
    Sub Is_Login()
        Dim sql As New MySQLCore
        Dim dt = sql.MySql_SelectString("is_login, username,accesslevel", "gl_users", , $"where pcname ='{my_pcName}'")
        islogin = dt.Rows(0).Item("is_login").ToString
        username = dt.Rows(0).Item("username").ToString
        accesslevel = dt.Rows(0).Item("accesslevel").ToString
        If islogin = 1 Then
            'MsgBox(accesslevel)
            Form1.Statuslbl.Text = "Online"
            Form1.Userlbl.Text = username
            If accesslevel = 1 Then
                Form1.Verifybtn.Visible = True
            Else
                Form1.Verifybtn.Visible = False
            End If
        ElseIf islogin = 0 Then
            Form1.Statuslbl.Text = "Offline"
            Form1.Userlbl.Text = "No User"
        End If
    End Sub
End Module
