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
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT CLI_CLIENTE, CLI_NUMERO_DOCUMENTACION, CLI_NIT, CLI_NUMERO_CELULAR, CLI_CORREO FROM MUE_CLIENTE", Conex)

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

        lct.Close()

    End Sub

    Protected Sub GridViewClientes_RowCommandEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridViewClientes.RowCommand
        If e.CommandName = "EditarCliente" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = GridViewClientes.DataKeys(indice).Value

            If id = 3 Then
                Response.Write("<script language=""javascript"">alert('Aquí se editará el cliente.');</script>")
            End If

        End If
    End Sub

    Protected Sub GridViewClientes_RowCommandDelete(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridViewClientes.RowCommand
        If e.CommandName = "EliminarCliente" Then

            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = GridViewClientes.DataKeys(indice).Value

            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_CLIENTE WHERE CLI_CLIENTE = :id", Conex)
            cmd.Parameters.Add(":id", id)


            Dim lct As OracleDataReader = cmd.ExecuteReader()


        End If
    End Sub

    Protected Sub btnAddCliente_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/AddCliente.aspx")
    End Sub
End Class