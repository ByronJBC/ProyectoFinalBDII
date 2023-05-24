Imports Oracle.ManagedDataAccess.Client

Module Conexion
    Public Conex As OracleConnection

    Public Sub AbrirConexion()
        Conex = New OracleConnection With {
            .ConnectionString = "User Id=PFDBII;Password=1234;Data Source=localhost:1521/ORCL; "
        }
        Conex.Open()
    End Sub

End Module
