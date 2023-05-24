Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader


Public Class Clientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Llenar_Clientes()
    End Sub

    Public Sub Llenar_Clientes()
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MOSTRAR_CLIENTES", Conex)

        Dim lct As OracleDataReader = cmd.ExecuteReader()


        Dim dt As New System.Data.DataTable()
        dt.Columns.AddRange(New System.Data.DataColumn(4) {
            New System.Data.DataColumn("ID"),
            New System.Data.DataColumn("Cliente"),
            New System.Data.DataColumn("NIT"),
            New System.Data.DataColumn("Telefono"),
            New System.Data.DataColumn("Email")})
        While (lct.Read())
            dt.Rows.Add(lct(0), lct(1), lct(2), lct(3), lct(4))
        End While

        GridViewClientes.DataSource = dt
        GridViewClientes.DataBind()
        GridViewClientes.HeaderRow.TableSection = TableRowSection.TableHeader

    End Sub
    Protected Sub GridViewClientes_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        If e.CommandName = "EditarCliente" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As String = GridViewClientes.DataKeys(indice).Value

            Response.Redirect("UpdateCliente.aspx?id=" + id)

        ElseIf e.CommandName = "EliminarCliente" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = GridViewClientes.DataKeys(indice).Value
            Dim codeError As Integer
            Dim msgeError As String = ""

            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("ELIMINAR_CLIENTE", Conex) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add(":id", id)
            cmd.Parameters.Add(":codeError", codeError)
            cmd.Parameters.Add(":msgeError", msgeError)
            cmd.ExecuteNonQuery()

            Console.WriteLine("Codigo de error: ", codeError)
            Console.WriteLine("Descripcion de error: ", msgeError)

            Response.Write("<script language=""javascript"">alert('Cliente Eliminado.');</script>")
            Response.Redirect("~/Clientes.aspx")
        Else
            Response.Write("<script language=""javascript"">alert('Opción Inválida.');</script>")
        End If
    End Sub

    Protected Sub BtnAddCliente_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/AddCliente.aspx")
    End Sub

End Class