Module InitializeTables
    Public sectorguideid
    Sub sectorguide()
        Dim sql As New MySQLCore
        Dim dt = sql.MySql_SelectString("*", "gl_config")
        sectorguideid = dt.Rows(0).Item("sectorguideid").ToString
    End Sub
End Module
