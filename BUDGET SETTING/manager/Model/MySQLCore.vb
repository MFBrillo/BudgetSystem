Imports MySql.Data.MySqlClient
Public Class MySQLCore

    Private ReadOnly Conn As MySqlConnection = MySQLConn.MysqlSettings
    Friend Function MySql_CheckConn(Optional ByVal showmsg As Integer = 0) As Integer
        Dim server = My.MySettings.Default.Servername, sysad = My.MySettings.Default.SysAd

        Try
            'Connected successfully
            Conn.Open()
            If showmsg = 1 Then
                CustomMsg("CHECK CONNECTION", $"You are connected to {server}. -{sysad}", "OK")
            End If
            Conn.Close()
            Return 1
        Catch ex As Exception
            If showmsg = 1 Then
                CustomMsg("CHECK CONNECTION", $"{Err.Description}. -{sysad}", "OK")
            End If
            Conn.Close()
            Return 0
        End Try
    End Function

    'Use to populate datatable, datagrid, and textbox objects using stored procedures
    Friend Function MySQL_Datatable(ByVal SProcs As String, Optional ByVal paramvalues As Dictionary(Of String, String) = Nothing) As DataTable
        Using cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter   'multiple result
            Dim dt As New DataTable
            Try

                Conn.Open()
                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = SProcs

                    If paramvalues IsNot Nothing Then
                        For i As Integer = 0 To paramvalues.Count - 1
                            .Parameters.AddWithValue(paramvalues.Keys.ElementAt(i), paramvalues.Values.ElementAt(i))
                        Next
                    End If
                End With
                da.SelectCommand = cmd
                da.Fill(dt)

                cmd.Dispose()
                da.Dispose()
                Conn.Close()

                Return dt

            Catch ex As Exception
                MsgBox("Datatable :: " & Err.Description)
                'Err.Clear()
                cmd.Dispose()
                Conn.Close()
                Return Nothing
            End Try

        End Using

    End Function

    'Use to INSERT and UPDATE using stored procedures
    Friend Sub MySql_ExecuteNonQuery(ByVal sprocs As String, columnvalues As Dictionary(Of String, String))
        Using cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter   'multiple result
            Dim dt As New DataTable          'table
            Try
                Conn.Open()
                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = sprocs
                    For i As Integer = 0 To columnvalues.Count - 1
                        .Parameters.AddWithValue(columnvalues.Keys.ElementAt(i), columnvalues.Values.ElementAt(i))
                    Next
                    cmd.ExecuteNonQuery()
                End With
                cmd.Dispose()
                Conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cmd.Dispose()
                Conn.Close()
            End Try
        End Using
    End Sub

    'Local SQL Select statement
    Friend Function MySql_SelectString(ByVal columns As String,
                                       ByVal tablename As String,
                                       Optional jointbl As String = Nothing,
                                       Optional whereclause As String = Nothing,
                                       Optional orderby As String = Nothing,
                                       Optional limit As String = Nothing,
                                       Optional reviewsql As Integer = 0) As DataTable
        Using cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter   'multiple result
            Dim dt As New DataTable
            Try
                Dim SQL As String

                SQL = $"SELECT {columns}" & vbCrLf &
                    $"FROM {tablename}" & vbCrLf &
                    $"{jointbl}" & vbCrLf &
                    $"{whereclause}" & vbCrLf &
                    $"{orderby}" & vbCrLf &
                    $"{limit};"

                If reviewsql = 1 Then MsgBox(SQL)
                Conn.Open()
                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = SQL
                End With

                da.SelectCommand = cmd
                da.Fill(dt)

                cmd.Dispose()
                da.Dispose()
                Conn.Close()

                Return dt

            Catch ex As Exception
                CustomMsg(Err.Description, "Server not found")
                'Err.Clear()
                cmd.Dispose()
                Conn.Close()
                Return Nothing
            End Try

        End Using
    End Function

    'Local Insert/Update SQL statement
    Friend Sub MySql_ExecuteNonQueryString(ByVal tablename As String, columnvalues As Dictionary(Of String, String), Optional whereClause As String = Nothing, Optional usersqltype As Integer = 1)
        Using cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter   'multiple result
            Dim dt As New DataTable          'table
            Try
                Conn.Open()
                With cmd
                    'Prepare the parameters
                    Dim sqlcolumns(columnvalues.Count - 1) As String,
                        sqlvalues As String = Nothing,
                        sqlfields(columnvalues.Count - 1) As String,
                        params(columnvalues.Count - 1) As String

                    For i As Integer = 0 To columnvalues.Count - 1
                        cmd.Parameters.AddWithValue(params(i), columnvalues.Values.ElementAt(i))
                    Next

                    'SELECT sqlnonquery type (INSERT/UPDATE)
                    Dim SqlNonQuery As String = Nothing

                    If usersqltype = 1 Then
                        Dim columns As String = String.Join(",", columnvalues.Select(Function(cols) $"{cols.Key}").ToArray())
                        Dim values As String = String.Join(",", columnvalues.Select(Function(cols) $"'{cols.Value}'").ToArray())
                        SqlNonQuery = $"INSERT INTO {tablename}({columns}) VALUES({values});"

                    ElseIf usersqltype = 2 Then
                        Dim fields(columnvalues.Count - 1) As String
                        For i As Integer = 0 To columnvalues.Count - 1
                            fields(i) = $"{columnvalues.Keys.ElementAt(i)} = {columnvalues.Values.ElementAt(i)}"
                        Next
                        SqlNonQuery = $"UPDATE {tablename} SET {String.Join(", ", fields)} WHERE  {whereClause}"

                    Else
                        MsgBox(SqlNonQuery & vbCrLf & vbCrLf & " INVALID usersql:: " & usersqltype)
                        cmd.Dispose()
                        Conn.Close()
                        Exit Sub
                    End If

                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = SqlNonQuery
                    cmd.ExecuteNonQuery()
                End With
                cmd.Dispose()
                Conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cmd.Dispose()
                Conn.Close()
            End Try
        End Using
    End Sub

    Friend Function MySql_NonQueryScript(ByVal tablename As String, columnvalues As Dictionary(Of String, String), Optional whereClause As String = Nothing, Optional usersqltype As Integer = 1) As String
        'Prepare the parameters
        Dim sqlcolumns(columnvalues.Count - 1) As String,
            sqlvalues As String = Nothing,
            sqlfields(columnvalues.Count - 1) As String,
            params(columnvalues.Count - 1) As String

        'For i As Integer = 0 To columnvalues.Count - 1
        '    cmd.Parameters.AddWithValue(params(i), columnvalues.Values.ElementAt(i))
        'Next

        'SELECT sqlnonquery type (INSERT/UPDATE)
        Dim SqlNonQuery As String = Nothing
        If usersqltype = 1 Then
            Dim columns As String = String.Join(",", columnvalues.Select(Function(cols) $"{cols.Key}").ToArray())
            Dim values As String = String.Join(",", columnvalues.Select(Function(cols) $"{cols.Value}").ToArray())
            SqlNonQuery = $"INSERT INTO {tablename}({columns}) 
                            VALUES({values});" & vbCrLf

        ElseIf usersqltype = 2 Then
            Dim fields = String.Join(",", sqlfields)
            SqlNonQuery = $"UPDATE {tablename}
                            SET    {fields}
                            WHERE  {whereClause};" & vbCrLf
        End If
        Return SqlNonQuery
    End Function

    Friend Function MySql_ExecuteNonQueryScript(ByVal SqlNonQuery As String) As DataTable
        Using cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter   'multiple result
            Dim dt As New DataTable          'table
            Try
                Conn.Open()
                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = SqlNonQuery

                    cmd.ExecuteNonQuery()
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                da.Dispose()
                cmd.Dispose()
                Conn.Close()
                Return dt
            Catch ex As Exception
                Return Nothing
                MsgBox(ex.Message)
                cmd.Dispose()
                Conn.Close()
            End Try
        End Using
    End Function

    'SELECT MYSQL to Textbox
    Public Function MySql_Select(ByVal SqlString As String,
                                Optional ReturnColumn As String = Nothing,
                                Optional ObjectName() As TextBox = Nothing,
                                Optional ByVal indexnumber As Integer = 0) As String
        Try
            Dim da As New MySqlDataAdapter   'multiple result
            Dim dt As New DataTable          'table
            Dim dr As MySqlDataReader        'individual result
            MsgBox(SqlString)
            Conn.Open()

            Using cmd As New MySqlCommand
                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = SqlString
                    .ExecuteNonQuery()
                End With
                dr = cmd.ExecuteReader()

                While dr.Read
                    'By default, the indexNumber of Item is 0. You can skip the index by 
                    'providing IndexNumber inside the function to find your field name.
                    If ObjectName IsNot Nothing Then
                        For Index As Integer = 0 To dr.FieldCount - 1
                            ObjectName(Index).Text = dr.Item(indexnumber).ToString
                            If indexnumber = dr.FieldCount - 1 Then Exit For
                            indexnumber += 1
                        Next
                    Else
                        Return dr.Item(ReturnColumn).ToString
                    End If
                End While
                cmd.Dispose()
                Conn.Close()
                dr.Close()
            End Using
            Conn.Close()
            dr.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
            Err.Clear()
            Conn.Close()
        End Try
        Return 0
    End Function

    'SELECT MYSQL to Combobox
    Public Function Mysql_to_Combobox(ByVal columns As String,
                                       ByVal tablename As String,
                                       ByVal ComboboxName() As ComboBox,
                                       Optional jointbl As String = Nothing,
                                       Optional whereclause As String = Nothing,
                                       Optional orderby As String = Nothing,
                                       Optional limit As String = Nothing,
                                       Optional ByVal indexnumber As Integer = 0) As String
        Try
            Dim da As New MySqlDataAdapter   'multiple result
            Dim dt As New DataTable          'table
            Dim dr As MySqlDataReader        'individual result
            Conn.Open()

            Dim SQL As String

            SQL = $"SELECT {columns}" & vbCrLf &
                    $"FROM {tablename}" & vbCrLf &
                    $"{jointbl}" & vbCrLf &
                    $"{whereclause}" & vbCrLf &
                    $"{orderby}" & vbCrLf &
                    $"{limit};"
            Using cmd As New MySqlCommand
                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = SQL

                    cmd.ExecuteNonQuery()
                End With

                dr = cmd.ExecuteReader()

                While dr.Read
                    'By default, the indexNumber of Item is 0. You can skip the index by 
                    'providing IndexNumber inside the function to find your field name.

                    For Index As Integer = 0 To dr.FieldCount - 1
                        ComboboxName(Index).Items.Add(dr.Item(indexnumber).ToString)
                        If indexnumber = dr.FieldCount - 1 Then Exit For
                        indexnumber += 1
                    Next

                End While

                cmd.Dispose()
                Conn.Close()
                dr.Close()
            End Using
            Conn.Close()
            dr.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
            Err.Clear()
            Conn.Close()
        End Try
        Return 0
    End Function

    Friend Function MySql_Delete(ByVal tablename As String,
                             ByVal whereclause As String,
                             Optional reviewsql As Integer = 0) As Boolean
        Using cmd As New MySqlCommand
            Try
                Dim SQL As String

                SQL = $"DELETE FROM {tablename}" & vbCrLf &
                      $"WHERE {whereclause};"

                If reviewsql = 1 Then MsgBox(SQL)
                Conn.Open()

                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = SQL
                End With

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                cmd.Dispose()
                Conn.Close()

                Return rowsAffected > 0

            Catch ex As Exception
                CustomMsg(Err.Description, "Server not found")
                'Err.Clear()
                cmd.Dispose()
                Conn.Close()
                Return False
            End Try
        End Using
    End Function

End Class
