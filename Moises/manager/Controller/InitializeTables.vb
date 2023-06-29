Module InitializeTables

    Public gl_offices As DataTable
    Public gl_sectors As DataTable
    Public gl_registry As DataTable
    Public gl_subsectors As DataTable
    Public isInitialized As Integer = 0
    Sub Main()
        Dim core = New MySQLCore
        gl_offices = core.MySql_SelectString("officeid, officetypeid, officecode_pbo, officecode_acctg, officename, officeaccronym", "gl_offices", Nothing, "WHERE length(officecode_acctg) between 5 and 6")
        gl_registry = core.MySql_SelectString("registryid, registrycode, registryname, registrydescription", "gl_registry")
        gl_sectors = core.MySql_SelectString("sectorid, sectorcode, sectorname", "gl_sectors")
        gl_subsectors = core.MySql_SelectString("officeid, officetypeid, officecode_pbo, officecode_acctg, officename, officeaccronym", "gl_offices", Nothing, "WHERE length(officecode_acctg) between 5 and 6")
        isInitialized = 1
    End Sub

    Sub Test2()
        'this is another test
    End Sub

End Module
