Imports Oracle.ManagedDataAccess.Client
Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader

Public Class UpdateProductos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Dim codigo = Request.QueryString("id")

        LlenarProducto(codigo)
    End Sub

    Public Sub LlenarProducto(ByVal codigo As String)
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
        Dim xSQL As New StringBuilder
        xSQL.AppendLine("UPDATE MUE_PRODUCTO")
        xSQL.AppendLine("SET")
        xSQL.AppendLine("PRO_DESCRIPCION = :descripcion")
        xSQL.AppendLine("WHERE PRO_PRODUCTO = :id")

        Dim cmd1 As New OracleCommand(xSQL.ToString, Conex)

        cmd1.Parameters.Add(":descripcion", txtDescripcion.Text)
        cmd1.Parameters.Add(":id", txtIdProducto.Text)
        'cmd1.ExecuteNonQuery()

        'Dim command As OracleCommand = Conex.CreateCommand()
        Dim transaction As OracleTransaction

        transaction = Conex.BeginTransaction(IsolationLevel.ReadCommitted)
        cmd1.Transaction = transaction

        cmd1.ExecuteNonQuery()
        transaction.Commit()

        Conexion.Conex.Close()

        Limpiar()

        Response.Write("<script language=""javascript"">alert('Producto Actualizado.');</script>")
        Response.Redirect("~/Productos.aspx")
    End Sub
End Class