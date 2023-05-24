Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader
Public Class Productos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Llenar_Productos()
    End Sub

    Public Sub Llenar_Productos()
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MOSTRAR_PRODUCTOS", Conex)

        Dim lct As OracleDataReader = cmd.ExecuteReader()

        Dim dt As New System.Data.DataTable()
        dt.Columns.AddRange(New System.Data.DataColumn(4) {
            New System.Data.DataColumn("ID"),
            New System.Data.DataColumn("Producto"),
            New System.Data.DataColumn("Descripcion"),
            New System.Data.DataColumn("Color"),
            New System.Data.DataColumn("Peso")})
        While (lct.Read())
            dt.Rows.Add(lct(0), lct(1), lct(2), lct(3), lct(4))
        End While


        GridViewProductos.DataSource = dt
        GridViewProductos.DataBind()
        GridViewProductos.HeaderRow.TableSection = TableRowSection.TableHeader

        lct.Close()

    End Sub
    Protected Sub GridViewProductos_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        If e.CommandName = "EditarProducto" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As String = GridViewProductos.DataKeys(indice).Value

            Response.Redirect("UpdateProducto.aspx?id=" + id)

        ElseIf e.CommandName = "EliminarProducto" Then
            Dim indice As Integer = Convert.ToInt32(e.CommandArgument)
            Dim id As Integer = GridViewProductos.DataKeys(indice).Value
            Dim codeError As Integer
            Dim msgeError As String = ""

            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("ELIMINAR_PRODUCTO", Conex) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add(":id", id)
            cmd.Parameters.Add(":codeError", codeError)
            cmd.Parameters.Add(":msgeError", msgeError)
            cmd.ExecuteNonQuery()

            Console.WriteLine("Codigo de error: ", codeError)
            Console.WriteLine("Descripcion de error: ", msgeError)

            Response.Write("<script language=""javascript"">alert('Producto Eliminado.');</script>")
            Response.Redirect("~/Productos.aspx")
        Else
            Response.Write("<script language=""javascript"">alert('Opción Inválida.');</script>")
        End If
    End Sub

    Protected Sub BtnAddProducto_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/AddProducto.aspx")
    End Sub
End Class