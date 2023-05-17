Imports System.Reflection.Emit
Imports Oracle.ManagedDataAccess.Client
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



    Public Sub txtChanged(ByVal sender As Object, ByVal e As EventArgs)
        nitClt = (CType(sender, TextBox)).Text
        nitClt = nitClt.ToUpper()
        'txtNit2.Text = nitClt
    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Label1.Text = "hola"
    End Sub


    Protected Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("UPDATE MUE_CLIENTE 
        SET CLI_NUMERO_DOCUMENTACION=" & txtNumDocumentacion.Text & ",
        CLI_NIT=" & txtNit.Text & ",CLI_PRIMER_NOMBRE='" & txtPrimerNombre.Text & "',
        CLI_SEGUNDO_NOMBRE='" & txtSegundoNombre.Text & "',CLI_PRIMER_APELLIDO='" & txtPrimerApellido.Text & "',
        CLI_SEGUNDO_APELLIDO='" & txtSegundoApellido.Text & "',CLI_CORREO='" & txtEmail.Text & "',
        CLI_PASSWORD='" & txtPassword.Text & "',CLI_TIPO_DOCUMENTACION='" & txtTipoDocu.Text & "',
        CLI_NUMERO_RESIDENCIAL=" & txtNumResidencial.Text & ",CLI_NUMERO_CELULAR=" & txtNumCelular.Text & ",
        CLI_PAIS='" & txtPais.Text & "',CLI_DEPARTAMENTO='" & txtDepartamento.Text & "',
        CLI_CIUDAD_RESIDENCIA='" & txtCiudad.Text & "',CLI_DIRECCION='" & txtDireccion.Text & "',
        CLI_FECHA='" & txtFecha.Text & "',PRS_PROFESION=" & txtProfesion.Text & ",
        CLI_NOTAS='" & txtNotas.Text & "' WHERE CLI_CLIENTE =" & txtIdCliente.Text & "", Conex)

        cmd.ExecuteNonQuery()

        Dim transaction As OracleTransaction

        transaction = Conex.BeginTransaction(IsolationLevel.ReadCommitted)
        cmd.Transaction = transaction
        transaction.Commit()

        Conexion.Conex.Close()

        Limpiar()

        Response.Write("<script language=""javascript"">alert('Cliente Actualizado.');</script>")
        Response.Redirect("~/Clientes.aspx")
    End Sub
End Class