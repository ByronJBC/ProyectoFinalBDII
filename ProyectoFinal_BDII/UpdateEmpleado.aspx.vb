Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader
Public Class UpdateEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        If Not Page.IsPostBack Then
            LlenarEmpleado()
        End If
    End Sub

    Public Sub LlenarEmpleado()
        Dim codigo = Request.QueryString("id")

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_EMPLEADOS WHERE EMP_EMPLEADO = :id", Conex)
        cmd.Parameters.Add(":id", codigo)

        Dim sdr As OracleDataReader = cmd.ExecuteReader()

        If sdr.HasRows Then
            If sdr.Read Then
                txtIdEmpleado.Text = sdr("EMP_EMPLEADO").ToString()
                txtPrimerNombre.Text = sdr("EMP_PRIMER_NOMBRE").ToString()
                txtSegundoNombre.Text = sdr("EMP_SEGUNDO_NOMBRE").ToString()
                txtPrimerApellido.Text = sdr("EMP_PRIMER_APELLIDO").ToString()
                txtSegundoApellido.Text = sdr("EMP_SEGUNDO_APELLIDO").ToString()
                txtEmail.Text = sdr("EMP_CORREO").ToString()
                txtPassword.Text = sdr("EMP_PASSWORD").ToString()
                txtArea.Text = sdr("ARE_AREA").ToString()
                txtTelefono.Text = sdr("EMP_TELEFONO").ToString()
                txtFecha.Text = sdr("EMP_FECHA").ToString()
                txtRol.Text = sdr("ROL_ROL").ToString()
                txtRegistro.Text = sdr("EMP_REGISTRO").ToString()
                txtSucursal.Text = sdr("SUC_SUCURSAL").ToString()
            End If
        End If
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

    Protected Sub btnActualizarEmpleado_Click1(sender As Object, e As EventArgs)
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


        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("MODIFICAR_EMPLEADO", Conex) With {
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
        Conexion.Conex.Close()
        Limpiar()

        Response.Write("<script language=""javascript"">alert('Empleado Actualizado.');</script>")
        Response.Redirect("~/Empleados.aspx")
    End Sub
End Class