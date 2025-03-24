Imports MySql.Data.MySqlClient
Module connection
    Public Function strConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=dbenrolment")
    End Function
    Public con As MySqlConnection = strConnection()
End Module
