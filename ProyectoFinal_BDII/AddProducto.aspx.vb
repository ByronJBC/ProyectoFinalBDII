Imports Microsoft.Win32
Imports OracleInternal

Public Class AddProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()
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

    Protected Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProducto.Click
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



        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("INSERTAR_PRODUCTO", Conex) With {
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

        Response.Write("<script language=""javascript"">alert('Producto Agregado.');</script>")
        Limpiar()

        Conexion.Conex.Close()
    End Sub
End Class