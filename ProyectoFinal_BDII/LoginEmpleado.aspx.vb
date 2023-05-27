Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader
Public Class LoginEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()
    End Sub
    Private Sub Limpiar()
        txt_UserName.Text = ""
        txt_Password.Text = ""
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_EMPLEADO WHERE EMP_CORREO = :usuario AND EMP_PASSWORD = :password", Conex)

        cmd.Parameters.Add(":usuario", txt_UserName.Text)
        cmd.Parameters.Add(":password", txt_Password.Text)


        Dim lct As OracleDataReader = cmd.ExecuteReader()

        If lct.Read() Then
            If lct(0) <> 0 Then
                Response.Redirect("~/HomeAdmin.aspx")
                Limpiar()
                Conexion.Conex.Close()
            Else
                Response.Redirect("~/Login.aspx")
                Limpiar()
                Conexion.Conex.Close()
            End If
        Else
            Response.Write("<script language=""javascript"">alert('Usuario o Contraseña Incorrectos!');</script>")
            Limpiar()
            Conexion.Conex.Close()
        End If
    End Sub
End Class