Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader

Public Class Empleados
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Llenar_Empleados()
    End Sub

    Public Sub Llenar_Empleados()
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_EMPLEADOS", Conex)

        Dim lct As OracleDataReader = cmd.ExecuteReader()

        Dim dt As New System.Data.DataTable()
        dt.Columns.AddRange(New System.Data.DataColumn(4) {
            New System.Data.DataColumn("ID"),
            New System.Data.DataColumn("Empleado"),
            New System.Data.DataColumn("ROL"),
            New System.Data.DataColumn("Telefono"),
            New System.Data.DataColumn("Email")})
        While (lct.Read())
            dt.Rows.Add(lct(0), lct(1), lct(10), lct(8), lct(5))
        End While


        GridViewEmpleados.DataSource = dt
        GridViewEmpleados.DataBind()
        GridViewEmpleados.HeaderRow.TableSection = TableRowSection.TableHeader

        lct.Close()

    End Sub

    Protected Sub GridViewEmpleados_RowCommandEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        If e.CommandName = "EditarEmpleado" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As String = GridViewEmpleados.DataKeys(indice).Value

            Response.Redirect("UpdateEmpleado.aspx?id=" + id)

        End If
    End Sub

    Protected Sub GridViewEmpleados_RowCommandDelete(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        If e.CommandName = "EliminarEmpleado" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = GridViewEmpleados.DataKeys(indice).Value

            Dim cmd3 As New Oracle.ManagedDataAccess.Client.OracleCommand("DELETE FROM MUE_EMPLEADOS WHERE EMP_EMPLEADO = :id", Conex)
            cmd3.Parameters.Add(":id", id)
            cmd3.ExecuteNonQuery()

            Response.Write("<script language=""javascript"">alert('Empleado Eliminado.');</script>")

            Response.Redirect("~/Empleado.aspx")
        End If
    End Sub


    Protected Sub BtnAddEmpleado_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/AddEmpleado.aspx")
    End Sub

End Class