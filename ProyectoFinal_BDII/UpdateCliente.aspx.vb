Imports Oracle.ManagedDataAccess.Client
Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader

Public Class UpdateCliente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Dim codigo = Request.QueryString("id")

        LlenarCliente(codigo)

    End Sub

    Public Sub LlenarCliente(ByVal codigo As String)
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


    Protected Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs) Handles BtnActualizarCliente.Click
        Dim xSQL As New StringBuilder
        xSQL.AppendLine("UPDATE MUE_CLIENTE")
        xSQL.AppendLine("SET")
        xSQL.AppendLine("CLI_NIT = :nit")
        xSQL.AppendLine(" WHERE CLI_CLIENTE = :id")

        Dim cmd1 As New OracleCommand(xSQL.ToString, Conex)

        cmd1.Parameters.Add(":nit", txtNit.Text)
        cmd1.Parameters.Add(":id", txtIdCliente.Text)
        'cmd1.ExecuteNonQuery()

        'Dim command As OracleCommand = Conex.CreateCommand()
        Dim transaction As OracleTransaction

        transaction = Conex.BeginTransaction(IsolationLevel.ReadCommitted)
        cmd1.Transaction = transaction

        cmd1.ExecuteNonQuery()
        transaction.Commit()

        Conexion.Conex.Close()




        Limpiar()

        Response.Write("<script language=""javascript"">alert('Cliente Actualizado.');</script>")
        Response.Redirect("~/Clientes.aspx")
    End Sub

End Class