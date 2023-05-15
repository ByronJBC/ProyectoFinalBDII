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
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("INSERT 
        INTO MUE_PRODUCTO(PRO_PRODUCTO,PRO_DESCRIPCION,PRO_NOMBRE,TIP_TIPO_PRODUCTO,
        TIM_TIPO_MATERIAL,DIM_DIMENSION,COL_COLOR,PRO_PESO,PRO_IMAGEN,
        PRO_NOMBRE_IMAGEN) 
        VALUES ('" & txtIdProducto.Text & "','" & txtDescripcion.Text & "','" & txtNombre.Text & "',
        '" & txtTipoProducto.Text & "','" & txtTipoMaterial.Text & "','" & txtDimension.Text & "',
        '" & txtColor.Text & "','" & txtPeso.Text & "','" & txtImagen.Text & "',
        '" & txtNombreImagen.Text & "')", Conex)
        cmd.ExecuteNonQuery()

        Limpiar()

        Conexion.Conex.Close()
    End Sub
End Class