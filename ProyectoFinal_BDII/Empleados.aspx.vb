Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader

Public Class Empleados
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Llenar_Empleados()
    End Sub

    Public Sub Llenar_Empleados()
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MOSTRAR_EMPLEADOS", Conex)

        Dim lct As OracleDataReader = cmd.ExecuteReader()

        Dim dt As New System.Data.DataTable()
        dt.Columns.AddRange(New System.Data.DataColumn(4) {
            New System.Data.DataColumn("ID"),
            New System.Data.DataColumn("Empleado"),
            New System.Data.DataColumn("ROL"),
            New System.Data.DataColumn("Telefono"),
            New System.Data.DataColumn("Email")})
        While (lct.Read())
            dt.Rows.Add(lct(0), lct(1), lct(2), lct(3), lct(4))
        End While


        GridViewEmpleados.DataSource = dt
        GridViewEmpleados.DataBind()
        GridViewEmpleados.HeaderRow.TableSection = TableRowSection.TableHeader

        lct.Close()

    End Sub

    Protected Sub GridViewEmpleados_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        If e.CommandName = "EditarEmpleado" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As String = GridViewEmpleados.DataKeys(indice).Value

            Response.Redirect("UpdateEmpleado.aspx?id=" + id)

        ElseIf e.CommandName = "EliminarEmpleado" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = GridViewEmpleados.DataKeys(indice).Value
            Dim codeError As Integer
            Dim msgeError As String = ""

            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("ELIMINAR_EMPLEADO", Conex) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add(":id", id)
            cmd.Parameters.Add(":codeError", codeError)
            cmd.Parameters.Add(":msgeError", msgeError)
            cmd.ExecuteNonQuery()

            Console.WriteLine("Codigo de error: ", codeError)
            Console.WriteLine("Descripcion de error: ", msgeError)

            Response.Write("<script language=""javascript"">alert('Empleado Eliminado.');</script>")
            Response.Redirect("~/Empleados.aspx")
        Else
            Response.Write("<script language=""javascript"">alert('Opción Inválida.');</script>")
        End If
    End Sub

    Protected Sub BtnAddEmpleado_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/AddEmpleado.aspx")
    End Sub

End Class