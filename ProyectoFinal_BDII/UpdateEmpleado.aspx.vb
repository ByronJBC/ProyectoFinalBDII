Imports Oracle.ManagedDataAccess.Client
Imports OracleDataReader = Oracle.ManagedDataAccess.Client.OracleDataReader
Public Class UpdateEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Dim codigo = Request.QueryString("id")

        LlenarEmpleado(codigo)
    End Sub

    Public Sub LlenarEmpleado(ByVal codigo As String)
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
        Dim xSQL As New StringBuilder
        xSQL.AppendLine("UPDATE MUE_EMPLEADOS")
        xSQL.AppendLine("SET")
        xSQL.AppendLine("ARE_AREA = :area")
        xSQL.AppendLine("WHERE EMP_EMPLEADO = :id")

        Dim cmd1 As New OracleCommand(xSQL.ToString, Conex)

        cmd1.Parameters.Add(":area", txtArea.Text)
        cmd1.Parameters.Add(":id", txtIdEmpleado.Text)
        'cmd1.ExecuteNonQuery()

        'Dim command As OracleCommand = Conex.CreateCommand()
        Dim transaction As OracleTransaction

        transaction = Conex.BeginTransaction(IsolationLevel.ReadCommitted)
        cmd1.Transaction = transaction

        cmd1.ExecuteNonQuery()
        transaction.Commit()

        Conexion.Conex.Close()




        Limpiar()

        Response.Write("<script language=""javascript"">alert('Empleado Actualizado.');</script>")
        Response.Redirect("~/Empleados.aspx")
    End Sub
End Class