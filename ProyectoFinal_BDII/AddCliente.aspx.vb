Imports System.Drawing.Imaging

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

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("INSERTAR_CLIENTE", Conex) With {
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

        Response.Write("<script language=""javascript"">alert('Cliente Agregado.');</script>")
        Limpiar()
        Conexion.Conex.Close()

    End Sub
End Class