Imports MySql.Data.MySqlClient

Module MySQLConn
    Public Function MySqlSettings() As MySqlConnection
        Dim Server = My.MySettings.Default.Servername
        Dim UID = My.MySettings.Default.Username
        Dim PortAddress = My.MySettings.Default.Port
        Dim DBPass = My.MySettings.Default.Password
        Dim DBName = My.MySettings.Default.Databasename
        Return New MySqlConnection($"server={Server}; user id={UID}; port={PortAddress}; password={DBPass}; database={DBName}")
    End Function
End Module
