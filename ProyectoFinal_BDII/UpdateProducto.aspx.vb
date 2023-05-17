Imports Oracle.ManagedDataAccess.Client
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
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("UPDATE MUE_PRODUCTO 
        SET PRO_DESCRIPCION='" & txtDescripcion.Text & "',PRO_NOMBRE='" & txtNombre.Text & "',
        TIP_TIPO_PRODUCTO='" & txtTipoProducto.Text & "',TIM_TIPO_MATERIAL='" & txtTipoMaterial.Text & "',
        DIM_DIMENSION='" & txtDimension.Text & "',COL_COLOR='" & txtColor.Text & "',
        PRO_PESO='" & txtPeso.Text & "',PRO_IMAGEN='" & txtImagen.Text & "',
        PRO_NOMBRE_IMAGEN='" & txtNombreImagen.Text & "'
        WHERE PRO_PRODUCTO =" & txtIdProducto.Text & "", Conex)

        cmd.ExecuteNonQuery()

        Dim transaction As OracleTransaction

        transaction = Conex.BeginTransaction(IsolationLevel.ReadCommitted)
        cmd.Transaction = transaction
        transaction.Commit()

        Conexion.Conex.Close()

        Limpiar()

        Response.Write("<script language=""javascript"">alert('Producto Actualizado.');</script>")
        Response.Redirect("~/Productos.aspx")
    End Sub
End Class