Imports System.Data.OracleClient
Imports Oracle.ManagedDataAccess.Client
Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader


Public Class Clientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Llenar_Clientes()
    End Sub

    Public Sub Llenar_Clientes()
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT CLI_NUMERO_DOCUMENTACION, CLI_NIT, CLI_NUMERO_CELULAR, CLI_CORREO FROM MUE_CLIENTE", Conex)

        Dim lct As OracleDataReader = cmd.ExecuteReader()

        Dim dt As New System.Data.DataTable()
        dt.Columns.AddRange(New System.Data.DataColumn(3) {
            New System.Data.DataColumn("Cliente"),
            New System.Data.DataColumn("NIT"),
            New System.Data.DataColumn("Telefono"),
            New System.Data.DataColumn("Email")})
        While (lct.Read())
            dt.Rows.Add(lct(0), lct(1), lct(2), lct(3))
        End While


        GridView1.DataSource = dt
        GridView1.DataBind()
        GridView1.HeaderRow.TableSection = TableRowSection.TableHeader

        lct.Close()

    End Sub

End Class