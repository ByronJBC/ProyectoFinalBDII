Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader

Public Class Catalogo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindProductos()
        End If
    End Sub

    Protected Sub BindProductos()

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_PRODUCTO", Conex)

        Dim lct As OracleDataReader = cmd.ExecuteReader()

        Dim dt As New System.Data.DataTable()
        dt.Columns.AddRange(New System.Data.DataColumn(4) {
            New System.Data.DataColumn("ID"),
            New System.Data.DataColumn("Producto"),
            New System.Data.DataColumn("Descripcion"),
            New System.Data.DataColumn("Color"),
            New System.Data.DataColumn("Peso")})
        While (lct.Read())
            dt.Rows.Add(lct(0), lct(2), lct(1), lct(6), lct(7))
        End While


        rptProductos.DataSource = dt
        rptProductos.DataBind()
    End Sub

    Protected Sub rptProductos_ItemCommand(source As Object, e As RepeaterCommandEventArgs) Handles rptProductos.ItemCommand
        If e.CommandName = "AgregarCarrito" Then
            Dim productoId As Integer = Convert.ToInt32(e.CommandArgument)

            ' Lógica para agregar el producto al carrito
            ' Puedes almacenar los productos en una lista en la sesión, base de datos, etc.

            ' Redirige a la página del carrito de compras
            Response.Redirect("Carrito.aspx")
        End If
    End Sub

    Protected Sub buscarProductos() Handles btnSearch.Click
        Dim term As String = txtSearch.Text.Trim()
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_PRODUCTO where PRO_NOMBRE LIKE '%' || :term || '%'", Conex)
        cmd.Parameters.Add(":term", ID)
        Dim lct As OracleDataReader = cmd.ExecuteReader()


        Dim dt As New System.Data.DataTable()
        dt.Columns.AddRange(New System.Data.DataColumn(4) {
            New System.Data.DataColumn("ID"),
            New System.Data.DataColumn("Producto"),
            New System.Data.DataColumn("Descripcion"),
            New System.Data.DataColumn("Color"),
            New System.Data.DataColumn("Peso")})
        While (lct.Read())
            dt.Rows.Add(lct(0), lct(2), lct(1), lct(6), lct(7))
        End While


        rptProductos.DataSource = dt
        rptProductos.DataBind()
    End Sub
End Class
