Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader

Public Class UpdateProductos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        If Not Page.IsPostBack Then
            LlenarProducto()
        End If
    End Sub

    Public Sub LlenarProducto()
        Dim codigo = Request.QueryString("id")

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_PRODUCTO WHERE PRO_PRODUCTO = :id", Conex)
        cmd.Parameters.Add(":id", codigo)

        Dim sdr As OracleDataReader = cmd.ExecuteReader()

        If sdr.HasRows Then
            If sdr.Read Then
                txtIdProducto.Text = sdr("PRO_PRODUCTO").ToString()
                txtDescripcion.Text = sdr("PRO_DESCRIPCION").ToString()
                txtNombre.Text = sdr("PRO_NOMBRE").ToString()
                txtTipoProducto.Text = sdr("TIP_TIPO_PRODUCTO").ToString()
                txtTipoMaterial.Text = sdr("TIM_TIPO_MATERIAL").ToString()
                txtDimension.Text = sdr("DIM_DIMENSION").ToString()
                txtColor.Text = sdr("COL_COLOR").ToString()
                txtPeso.Text = sdr("PRO_PESO").ToString()
                txtImagen.Text = sdr("PRO_IMAGEN").ToString()
                txtNombreImagen.Text = sdr("PRO_NOMBRE_IMAGEN").ToString()
            End If
        End If
    End Sub

    Private Sub Limpiar()
        txtIdProducto.Text = ""
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtTipoProducto.Text = ""
        txtTipoMaterial.Text = ""
        txtDimension.Text = ""
        txtColor.Text = ""
        txtPeso.Text = ""
        txtNombreImagen.Text = ""
        txtImagen.Text = ""
    End Sub

    Protected Sub BtnActualizarProducto_Click(sender As Object, e As EventArgs)
        Dim idProducto As Integer = txtIdProducto.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim nombre As String = txtNombre.Text
        Dim tipoProducto As String = txtTipoProducto.Text
        Dim tipoMaterial As String = txtTipoMaterial.Text
        Dim dimension As String = txtDimension.Text
        Dim color As String = txtColor.Text
        Dim peso As String = txtPeso.Text
        Dim imagen As String = txtImagen.Text
        Dim nombreImagen As String = txtNombreImagen.Text
        Dim activo As Integer = 1
        Dim codeError As Integer
        Dim msgeError As String = ""

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("MODIFICAR_PRODUCTO", Conex) With {
                .CommandType = CommandType.StoredProcedure
            }

        cmd.Parameters.Add(":id", idProducto)
        cmd.Parameters.Add(":descripcion", descripcion)
        cmd.Parameters.Add(":nombre", nombre)
        cmd.Parameters.Add(":tipoProducto", tipoProducto)
        cmd.Parameters.Add(":tipoMaterial", tipoMaterial)
        cmd.Parameters.Add(":dimension", dimension)
        cmd.Parameters.Add(":color", color)
        cmd.Parameters.Add(":peso", peso)
        cmd.Parameters.Add(":imagen", imagen)
        cmd.Parameters.Add(":nomImagen", nombreImagen)
        cmd.Parameters.Add(":activo", activo)
        cmd.Parameters.Add(":codeError", codeError)
        cmd.Parameters.Add(":msgeError", msgeError)
        cmd.ExecuteNonQuery()

        Console.WriteLine("Codigo de error: ", codeError)
        Console.WriteLine("Descripcion de error: ", msgeError)
        Conexion.Conex.Close()
        Limpiar()

        Response.Write("<script language=""javascript"">alert('Producto Actualizado.');</script>")
        Response.Redirect("~/Productos.aspx")
    End Sub
End Class