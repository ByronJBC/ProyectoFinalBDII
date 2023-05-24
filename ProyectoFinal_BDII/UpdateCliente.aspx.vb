Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader

Public Class UpdateCliente
    Inherits System.Web.UI.Page

    Public nitClt As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        If Not Page.IsPostBack Then
            LlenarCliente()
        End If

    End Sub

    Public Sub LlenarCliente()
        Dim codigo As String = Request.QueryString("id")

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT * FROM MUE_CLIENTE WHERE CLI_CLIENTE = :id", Conex)
        cmd.Parameters.Add(":id", codigo)

        Dim sdr As OracleDataReader = cmd.ExecuteReader()

        If sdr.HasRows Then
            If sdr.Read Then
                txtIdCliente.Text = sdr("CLI_CLIENTE").ToString()
                txtNumDocumentacion.Text = sdr("CLI_NUMERO_DOCUMENTACION").ToString()
                txtNit.Text = sdr("CLI_NIT").ToString()
                txtPrimerNombre.Text = sdr("CLI_PRIMER_NOMBRE").ToString()
                txtSegundoNombre.Text = sdr("CLI_SEGUNDO_NOMBRE").ToString()
                txtPrimerApellido.Text = sdr("CLI_PRIMER_APELLIDO").ToString()
                txtSegundoApellido.Text = sdr("CLI_SEGUNDO_APELLIDO").ToString()
                txtEmail.Text = sdr("CLI_CORREO").ToString()
                txtPassword.Text = sdr("CLI_PASSWORD").ToString()
                txtTipoDocu.Text = sdr("CLI_TIPO_DOCUMENTACION").ToString()
                txtNumResidencial.Text = sdr("CLI_NUMERO_RESIDENCIAL").ToString()
                txtNumCelular.Text = sdr("CLI_NUMERO_CELULAR").ToString()
                txtPais.Text = sdr("CLI_PAIS").ToString()
                txtDepartamento.Text = sdr("CLI_DEPARTAMENTO").ToString()
                txtCiudad.Text = sdr("CLI_CIUDAD_RESIDENCIA").ToString()
                txtDireccion.Text = sdr("CLI_DIRECCION").ToString()
                txtFecha.Text = sdr("CLI_FECHA").ToString()
                txtProfesion.Text = sdr("PRS_PROFESION").ToString()
                txtNotas.Text = sdr("CLI_NOTAS").ToString()
            End If
        End If
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

    Protected Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs)
        Dim idCliente As Integer = txtIdCliente.Text
        Dim numDocumentacion As String = txtNumDocumentacion.Text
        Dim nit As Integer = txtNit.Text
        Dim primerNombre As String = txtPrimerNombre.Text
        Dim segundoNombre As String = txtSegundoNombre.Text
        Dim primerApellido As String = txtPrimerApellido.Text
        Dim segundoApellido As String = txtSegundoApellido.Text
        Dim correo As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim tipoDocumentacion As String = txtTipoDocu.Text
        Dim numResidencial As Integer = txtNumResidencial.Text
        Dim numCelulcar As Integer = txtNumCelular.Text
        Dim pais As String = txtPais.Text
        Dim departamento As String = txtDepartamento.Text
        Dim ciudadResidencia As String = txtCiudad.Text
        Dim direccion As String = txtDireccion.Text
        Dim fecha As String = txtFecha.Text
        Dim profesion As Integer = txtProfesion.Text
        Dim notas As String = txtNotas.Text
        Dim activo As Integer = 1
        Dim codeError As Integer
        Dim msgeError As String = ""

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("MODIFICAR_CLIENTE", Conex) With {
                .CommandType = CommandType.StoredProcedure
            }

        cmd.Parameters.Add(":id", idCliente)
        cmd.Parameters.Add(":numDoc", numDocumentacion)
        cmd.Parameters.Add(":nit", nit)
        cmd.Parameters.Add(":primerNom", primerNombre)
        cmd.Parameters.Add(":segundoNom", segundoNombre)
        cmd.Parameters.Add(":primerApe", primerApellido)
        cmd.Parameters.Add(":segundoApe", segundoApellido)
        cmd.Parameters.Add(":correo", correo)
        cmd.Parameters.Add(":password", password)
        cmd.Parameters.Add(":tipoDocu", tipoDocumentacion)
        cmd.Parameters.Add(":numResidencial", numResidencial)
        cmd.Parameters.Add(":numCelular", numCelulcar)
        cmd.Parameters.Add(":pais", pais)
        cmd.Parameters.Add(":depto", departamento)
        cmd.Parameters.Add(":ciudadRes", ciudadResidencia)
        cmd.Parameters.Add(":direccion", direccion)
        cmd.Parameters.Add(":fecha", fecha)
        cmd.Parameters.Add(":profesion", profesion)
        cmd.Parameters.Add(":notas", notas)
        cmd.Parameters.Add(":activo", activo)
        cmd.Parameters.Add(":codeError", codeError)
        cmd.Parameters.Add(":msgeError", msgeError)
        cmd.ExecuteNonQuery()

        Console.WriteLine("Codigo de error: ", codeError)
        Console.WriteLine("Descripcion de error: ", msgeError)
        Conexion.Conex.Close()
        Limpiar()

        Response.Write("<script language=""javascript"">alert('Cliente Actualizado.');</script>")
        Response.Redirect("~/Clientes.aspx")
    End Sub
End Class