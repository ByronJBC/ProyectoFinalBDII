Public Class AddCliente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()
    End Sub

    Private Sub Limpiar()
        txtIdCliente.Text = ""
        txtNumDocumentacion.Text = ""
        txtNit.Text = ""
        txtPrimerNombre.Text = ""
        txtSegundoNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtTipoDocu.Text = ""
        txtNumResidencial.Text = ""
        txtNumCelular.Text = ""
        txtProfesion.Text = ""
        txtPais.Text = ""
        txtDepartamento.Text = ""
        txtCiudad.Text = ""
        txtDireccion.Text = ""
        txtFecha.Text = ""
        txtNotas.Text = ""
    End Sub


    Protected Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("INSERT 
        INTO MUE_CLIENTE(CLI_CLIENTE,CLI_NUMERO_DOCUMENTACION,CLI_NIT,CLI_PRIMER_NOMBRE,
        CLI_SEGUNDO_NOMBRE,CLI_PRIMER_APELLIDO,CLI_SEGUNDO_APELLIDO,CLI_CORREO,CLI_PASSWORD,
        CLI_TIPO_DOCUMENTACION,CLI_NUMERO_RESIDENCIAL,CLI_NUMERO_CELULAR,CLI_PAIS,
        CLI_DEPARTAMENTO,CLI_CIUDAD_RESIDENCIA,CLI_DIRECCION,CLI_FECHA,PRS_PROFESION,CLI_NOTAS) 
        values ('" & txtIdCliente.Text & "','" & txtNumDocumentacion.Text & "','" & txtNit.Text & "',
        '" & txtPrimerNombre.Text & "','" & txtSegundoNombre.Text & "','" & txtPrimerApellido.Text & "',
        '" & txtSegundoApellido.Text & "','" & txtEmail.Text & "','" & txtPassword.Text & "',
        '" & txtTipoDocu.Text & "','" & txtNumResidencial.Text & "','" & txtNumCelular.Text & "',
        '" & txtPais.Text & "','" & txtDepartamento.Text & "','" & txtCiudad.Text & "',
        '" & txtDireccion.Text & "','" & txtFecha.Text & "','" & txtProfesion.Text & "',
        '" & txtNotas.Text & "')", Conex)
        cmd.ExecuteNonQuery()

        Limpiar()

        Conexion.Conex.Close()

    End Sub
End Class