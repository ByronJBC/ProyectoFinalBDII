Imports Oracle.DataAccess.Client
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
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM USUARIO WHERE USUARIO = :usuario AND PASS = :password", Conex)

        cmd.Parameters.Add(":usuario", txt_UserName.Text)
        cmd.Parameters.Add(":password", txt_Password.Text)


        Dim lct As OracleDataReader = cmd.ExecuteReader()

        If lct.Read() Then
            If lct(3) = 1 Then
                Response.Redirect("~/HomeAdmin.aspx")
                Limpiar()
                Conexion.Conex.Close()
            ElseIf lct(3) = 2 Then
                Response.Redirect("~/Home.aspx")
                Limpiar()
                Conexion.Conex.Close()
            Else
                Response.Redirect("~/Login.aspx")
                Limpiar()
                Conexion.Conex.Close()
            End If
        Else
            Console.Write("No existe el usuario")
            Limpiar()
            Conexion.Conex.Close()
        End If
    End Sub
End Class