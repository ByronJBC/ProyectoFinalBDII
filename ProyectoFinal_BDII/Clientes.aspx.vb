Imports System.ComponentModel
Imports System.Data.OracleClient
Imports System.Runtime.Remoting.Messaging
Imports System.Web.Services.Description
Imports Oracle.ManagedDataAccess.Client
Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader


Public Class Clientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Llenar_Clientes()
    End Sub

    Public Sub Llenar_Clientes()
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT CLI_CLIENTE, CLI_NUMERO_DOCUMENTACION, CLI_NIT, CLI_NUMERO_RESIDENCIAL, CLI_CORREO FROM MUE_CLIENTE", Conex)

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

    Protected Sub GridViewClientes_RowCommandEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        If e.CommandName = "EditarCliente" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As String = GridViewClientes.DataKeys(indice).Value

            Response.Redirect("UpdateCliente.aspx?id=" + id)

        End If
    End Sub

    Protected Sub GridViewClientes_RowCommandDelete(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        If e.CommandName = "EliminarCliente" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = GridViewClientes.DataKeys(indice).Value


            Dim cmd1 As New Oracle.ManagedDataAccess.Client.OracleCommand("DELETE FROM MUE_FACTURA_DETALLE WHERE FAG_FACTURA_GENERAL IN (
                                                                        SELECT FAG_FACTURA_GENERAL FROM MUE_FACTURA_GENERAL WHERE CLI_CLIENTE = :id)", Conex)
            cmd1.Parameters.Add(":id", id)
            cmd1.ExecuteNonQuery()

            Dim cmd2 As New Oracle.ManagedDataAccess.Client.OracleCommand("DELETE FROM MUE_FACTURA_GENERAL WHERE CLI_CLIENTE = :id", Conex)
            cmd2.Parameters.Add(":id", id)
            cmd2.ExecuteNonQuery()

            Dim cmd3 As New Oracle.ManagedDataAccess.Client.OracleCommand("DELETE FROM MUE_CLIENTE WHERE CLI_CLIENTE = :id", Conex)
            cmd3.Parameters.Add(":id", id)
            cmd3.ExecuteNonQuery()

            Response.Write("<script language=""javascript"">alert('Cliente Eliminado.');</script>")

            Response.Redirect("~/Clientes.aspx")
        End If
    End Sub

    Protected Sub BtnAddCliente_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/AddCliente.aspx")
    End Sub

End Class