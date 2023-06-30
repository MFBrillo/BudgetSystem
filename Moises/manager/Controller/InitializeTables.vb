Module InitializeTables
    Public gl_offices As DataTable
    Public gl_sectors As DataTable
    Public gl_registry As DataTable
    Public gl_subsectors As DataTable
    Public gl_spcfunds As DataTable
    Public gl_funds As DataTable
    Public gl_accounts As DataTable
    Public gl_lgulevel As DataTable
    Public isInitialized As Integer = 0
    Sub Main()
        Dim core = New MySQLCore
        gl_offices = core.MySQL_Datatable("gl_offices")
        gl_registry = core.MySQL_Datatable("gl_registry")
        gl_sectors = core.MySQL_Datatable("gl_sectors")
        gl_subsectors = core.MySQL_Datatable("gl_subsectors")
        gl_spcfunds = core.MySQL_Datatable("gl_spcfunds")
        gl_funds = core.MySQL_Datatable("gl_funds")
        gl_accounts = core.MySQL_Datatable("gl_accounts")
        gl_lgulevel = core.MySQL_Datatable("gl_lgulevel")
        isInitialized = 1
    End Sub

    Sub Test2()
        'this is another test
    End Sub

End Module
