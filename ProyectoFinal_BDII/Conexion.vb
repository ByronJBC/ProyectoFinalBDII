Imports Oracle.ManagedDataAccess.Client

Module Conexion
    Public Conex As OracleConnection

    Public Sub AbrirConexion()
        Conex = New OracleConnection With {
            .ConnectionString = "User Id=adminijavi;Password=123456;Data Source=192.168.9.100:1521/orcl; "
        }
        Conex.Open()
    End Sub
    '.ConnectionString = "User Id=PFDBII;Password=1234;Data Source=localhost:1521/ORCL; "

End Module
