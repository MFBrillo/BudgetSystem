Imports MySql.Data.MySqlClient

Module MySQLConn
    Public Function MySqlSettings() As MySqlConnection
        '    Dim Server = My.MySettings.Default.Servername
        '    Dim UID = My.MySettings.Default.UsernameDb
        '    Dim PortAddress = My.MySettings.Default.Portaddress
        '    Dim DBPass = My.MySettings.Default.PasswordDb
        '    Dim DBName = My.MySettings.Default.Databasename
        Dim Server = "ictserver"
        My.MySettings.Default.Servername = Server
        Dim UID = "ICTDEV"
        Dim PortAddress = "3306"
        Dim DBPass = "CapizDevT3@m2023"
        Dim DBName = "centraldb"
        Return New MySqlConnection($"server={Server}; user id={UID}; port={PortAddress}; password={DBPass}; database={DBName}")
    End Function
End Module
