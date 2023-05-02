Public Class HomeAdmin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Response.Redirect("~/Clientes.aspx")
    End Sub

    Protected Sub BtnEmpleados_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/Empleados.aspx")
    End Sub
End Class