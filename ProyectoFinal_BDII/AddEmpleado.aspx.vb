Public Class AddEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()
    End Sub

    Private Sub Limpiar()
        txtIdEmpleado.Text = ""
        txtPrimerNombre.Text = ""
        txtSegundoNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtArea.Text = ""
        txtRol.Text = ""
        txtTelefono.Text = ""
        txtFecha.Text = ""
        txtRegistro.Text = ""
        txtSucursal.Text = ""
    End Sub

    Protected Sub BtnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        Dim idEmpleado As Integer = txtIdEmpleado.Text
        Dim primerNombre As String = txtPrimerNombre.Text
        Dim segundoNombre As String = txtSegundoNombre.Text
        Dim primerApellido As String = txtPrimerApellido.Text
        Dim segundoApellido As String = txtSegundoApellido.Text
        Dim correo As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim area As Integer = txtArea.Text
        Dim telefono As Integer = txtTelefono.Text
        Dim fecha As String = txtFecha.Text
        Dim rol As Integer = txtRol.Text
        Dim registro As Integer = txtRegistro.Text
        Dim sucursal As Integer = txtSucursal.Text
        Dim activo As Integer = 1
        Dim codeError As Integer
        Dim msgeError As String = ""


        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("INSERTAR_EMPLEADO", Conex) With {
                .CommandType = CommandType.StoredProcedure
            }

        cmd.Parameters.Add(":id", idEmpleado)
        cmd.Parameters.Add(":primerNom", primerNombre)
        cmd.Parameters.Add(":segundoNom", segundoNombre)
        cmd.Parameters.Add(":primerApe", primerApellido)
        cmd.Parameters.Add(":segundoApe", segundoApellido)
        cmd.Parameters.Add(":correo", correo)
        cmd.Parameters.Add(":password", password)
        cmd.Parameters.Add(":area", area)
        cmd.Parameters.Add(":telefono", telefono)
        cmd.Parameters.Add(":fecha", fecha)
        cmd.Parameters.Add(":rol", rol)
        cmd.Parameters.Add(":registro", registro)
        cmd.Parameters.Add(":sucursal", sucursal)
        cmd.Parameters.Add(":activo", activo)
        cmd.Parameters.Add(":codeError", codeError)
        cmd.Parameters.Add(":msgeError", msgeError)
        cmd.ExecuteNonQuery()

        Console.WriteLine("Codigo de error: ", codeError)
        Console.WriteLine("Descripcion de error: ", msgeError)

        Response.Write("<script language=""javascript"">alert('Empleado Agregado.');</script>")
        Limpiar()
        Conexion.Conex.Close()
    End Sub
End Class