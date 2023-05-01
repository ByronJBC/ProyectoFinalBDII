Imports Oracle.ManagedDataAccess.Client

Module Conexion
    Public Conex As OracleConnection

    Public Sub AbrirConexion()
        Conex = New OracleConnection
        Conex.ConnectionString = "User Id=PFBDII1;Password=1234;Data Source=localhost:1521/orcl; "
        Conex.Open()
    End Sub

End Module
