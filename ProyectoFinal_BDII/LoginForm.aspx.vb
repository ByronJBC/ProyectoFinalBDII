Public Class LoginForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AbrirConexion()

        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtUsuario.Text = ""
        txtPassword.Text = ""
    End Sub

    ' Protected Sub BtnLogin_Click(sender As Object, e As EventArgs)
    'Private Sub Agregar()
    ' Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select ¨from where UPPER(USUARIO) like'%" & UCase(txtUsuario.Text) & "%'", Conex)
    'Dim ds As New DataSet
    '   da.Fill(ds)
    'If ds.Tables(0).Rows.Count > 0 Then
    '       DataGridView1.Data = ds.Tables(0)
    'Else
    '       DataGridView1.DataSource = Nothing
    'End If
    'End Sub

    Protected Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Console.Write("Estoy en enviar")
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand("INSERT INTO USUARIO(id_usuario,usuario,pass) values (3,'" & txtUsuario.Text & "','" & txtPassword.Text & "')", Conex)
        cmd.ExecuteNonQuery()

        Limpiar()

        Conexion.Conex.Close()

    End Sub
End Class