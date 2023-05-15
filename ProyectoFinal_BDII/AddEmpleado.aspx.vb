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
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("INSERT 
        INTO MUE_EMPLEADOS(EMP_EMPLEADO,EMP_PRIMER_NOMBRE,EMP_SEGUNDO_NOMBRE,EMP_PRIMER_APELLIDO,
        EMP_SEGUNDO_APELLIDO,EMP_CORREO,EMP_PASSWORD,ARE_AREA,EMP_TELEFONO,
        EMP_FECHA,ROL_ROL,EMP_REGISTRO,SUC_SUCURSAL) 
        values ('" & txtIdEmpleado.Text & "','" & txtPrimerNombre.Text & "','" & txtSegundoNombre.Text & "',
        '" & txtPrimerApellido.Text & "','" & txtSegundoApellido.Text & "','" & txtEmail.Text & "',
        '" & txtPassword.Text & "','" & txtArea.Text & "','" & txtTelefono.Text & "',
        '" & txtFecha.Text & "','" & txtRol.Text & "','" & txtRegistro.Text & "',
        '" & txtSucursal.Text & "')", Conex)
        cmd.ExecuteNonQuery()

        Limpiar()

        Conexion.Conex.Close()
    End Sub
End Class