Imports Oracle.ManagedDataAccess.Client
Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader


Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()


    End Sub

    Private Sub Limpiar()
        txt_UserName.Text = ""
        txt_Password.Text = ""
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_CLIENTE WHERE CLI_CORREO = :usuario AND CLI_PASSWORD = :password", Conex)

        cmd.Parameters.Add(":usuario", txt_UserName.Text)
        cmd.Parameters.Add(":password", txt_Password.Text)


        Dim lct As OracleDataReader = cmd.ExecuteReader()

        If lct.Read() Then
            If lct(1) <> 0 Then
                Response.Redirect("~/Home.aspx")
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